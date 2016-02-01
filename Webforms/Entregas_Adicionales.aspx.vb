Imports ingNovar.Utilidades2
Imports System.Collections.Generic

Partial Class WebForms_Entregas_Adicionales
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        Dim objper_perfil As New SeguridadUsuarios.Permisos_PerfilBrl
        Dim objper_usuario As New SeguridadUsuarios.Permisos_UsuarioBrl
        '
        ' Ingresa Primero aca
        ' Validamos la seguridad
        '
        ' Perfil
        Dim objusuario As SeguridadUsuarios.UsuariosBrl
        objusuario = SeguridadUsuarios.UsuariosBrl.CargarPorID(CType(Session("IdUsuario"), Integer))
        If objusuario Is Nothing Then
            Response.Redirect(strPaginaError)
            Exit Sub
        End If
        ' Pagina

        Dim objpagina As SeguridadUsuarios.PaginasBrl
        objpagina = SeguridadUsuarios.PaginasBrl.CargarPorURL(Request.FilePath)
        If objpagina Is Nothing Then
            Response.Redirect(strPaginaError)
            Exit Sub
        End If

        ' Permisos por Perfil

        objper_perfil = SeguridadUsuarios.Usuarios.EstadoPerPagina(objusuario.Id_Perfil, objpagina.ID)
        objper_usuario = SeguridadUsuarios.Usuarios.EstadoPerUsuario(objusuario.ID, objpagina.ID)

        If objper_perfil Is Nothing And objper_usuario Is Nothing Then
            Response.Redirect(strPaginaError)
            Exit Sub
        End If

        ' En alguno de los dos hay permisos
        ' Hay datos en la pagina de perfiles, se inicia la validacion de datos
        '
        If objper_perfil IsNot Nothing Then
            If objper_perfil.Pver = False Or objper_perfil.Pconsultar = False Then
                Response.Redirect(strPaginaError)
                Exit Sub
            End If

            ' asignando los permisos

            If Request.QueryString.Item("Id") > 0 Then  ' va a editar
                btn_crear.Enabled = objper_perfil.Peditar
                btn_cargar.Enabled = objper_perfil.Pcrear
            Else
                btn_crear.Enabled = objper_perfil.Pcrear
                btn_cargar.Enabled = objper_perfil.Pcrear
            End If

            ' asignando los permisos
            btn_nuevo.Enabled = objper_perfil.Pcrear
            Rg_Listado.Columns(6).Visible = objper_perfil.Peliminar

        End If

        If objper_usuario IsNot Nothing Then
            If objper_usuario.Pver = False Or objper_usuario.Pconsultar = False Then
                Response.Redirect(strPaginaError)
                Exit Sub
            End If

            ' asignando los permisos

            If Request.QueryString.Item("Id") > 0 Then  ' va a editar
                btn_crear.Enabled = objper_usuario.Peditar
                btn_cargar.Enabled = objper_usuario.Pcrear
            Else
                btn_crear.Enabled = objper_usuario.Pcrear
                btn_cargar.Enabled = objper_usuario.Pcrear
            End If

            '
            btn_nuevo.Enabled = objper_usuario.Pcrear
            Rg_Listado.Columns(6).Visible = objper_perfil.Peliminar

        End If

    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If IsPostBack Then Exit Sub

        If Session("IdUsuario") Is Nothing Then
            Session.RemoveAll()
            Response.Redirect("../login.aspx")
            Exit Sub
        End If

        Dim lblidUsuario As Label
        lblidUsuario = Master.FindControl("lblidusuario")
        lblidUsuario.Text = Session("IdUsuario")

        Dim LblNombreUsuario As Label
        LblNombreUsuario = Master.FindControl("LblNombreUsuario")
        LblNombreUsuario.Text = Session("NombreUsuario")

        Dim Lbl_regional As Label
        Lbl_regional = Master.FindControl("Lbl_regional")
        Lbl_regional.Text = Session("NombreRegional")

        Dim Lbl_usuario As Label
        Lbl_usuario = Master.FindControl("Lbl_usuario")
        Lbl_usuario.Text = Session("LoginUsuario")

        Dim Lbl_perfil As Label
        Lbl_perfil = Master.FindControl("Lbl_perfil")
        Lbl_perfil.Text = Session("NombrePerfil")

        If Request.QueryString.Item("Mensaje") = 1 Then
            lblMensaje.Text = "Operación exitosa"
            lblMensaje.Visible = True
        End If

        If Request.QueryString.Item("Mensaje") = 2 Then
            lblMensaje.Text = "Declarante ingresado al grupo de entrega."
            lblMensaje.Visible = True
        End If

        BindHelper.ProgramacionUIL.BindToListControlPorId_RegionalyEstado(ddlPrograma, SeguridadUsuarios.Usuarios.RegionalUsuario(CType(Session("IdUsuario"), Integer)), 213, New ListItem("Seleccione", 0))
        BindHelper.PersonasUIL.BindToListControlPorIdentificacionAtendidos(ddl_personas, 0, "ABCDEFG", New ListItem("Seleccione", 0))
        ddlPrograma.Enabled = True
        btn_crear.Enabled = True
        Dim ListEngregaAdicionalPersonas As New List(Of Entregas_Adicionales_PersonasBrl)
        If Request.QueryString.Item("Editar") = 1 Then
            Dim objEntregaAdicional As Entregas_AdicionalesBrl = Entregas_AdicionalesBrl.CargarPorID(Request.QueryString.Item("ID"))
            ddlPrograma.SelectedValue = objEntregaAdicional.Id_Programa
            lbl_Fecha.Text = Format(objEntregaAdicional.Fecha, "dd/MMM/yyyy")
            ListEngregaAdicionalPersonas = objEntregaAdicional.Entregas_Adicionales_Personas
            ddlPrograma.Enabled = False
            btn_crear.Enabled = False
        Else
            ListEngregaAdicionalPersonas = Entregas_Adicionales_PersonasBrl.CargarPorId_Persona(0)
        End If

        Session("ListEngregaAdicionalPersonas") = ListEngregaAdicionalPersonas
        Rg_Listado.DataSource = Session("ListEngregaAdicionalPersonas")
        Rg_Listado.DataBind()

    End Sub

    Private Function Grabar() As Int32

        Dim objentregaadicional As Entregas_AdicionalesBrl

        If Request.QueryString.Item("Editar") = 1 Then
            objentregaadicional = Entregas_AdicionalesBrl.CargarPorID(Request.QueryString.Item("ID"))
            objentregaadicional.Fecha_Modificacion = Now
            objentregaadicional.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text

        Else
            objentregaadicional = New Entregas_AdicionalesBrl
            objentregaadicional.Fecha_Creacion = Now
            objentregaadicional.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
            objentregaadicional.Id_Programa = ddlPrograma.SelectedValue
        End If

        Dim objprograma As ProgramacionBrl = ProgramacionBrl.CargarPorID(ddlPrograma.SelectedValue)
        objentregaadicional.Fecha = objprograma.Fecha
        objentregaadicional.Id_Tipo_Entrega = objprograma.Id_TipoEntrega

        objentregaadicional.Guardar()
        Return objentregaadicional.ID

    End Function

    Protected Sub btn_crear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_crear.Click
        Validate("PROGRAMA")
        If Not IsValid Then Exit Sub

        Try
            ID = Grabar()
            Response.Redirect("Entregas_Adicionales.aspx?Mensaje=1&Editar=1&Id=" & ID)
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try
    End Sub

    Protected Sub btn_buscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_buscar.Click, txt_Identificacion.TextChanged
        ' Buscar la identificacion 
        If txt_Identificacion.Text <> "" Then
            BindHelper.PersonasUIL.BindToListControlPorIdentificacionAtendidos(ddl_personas, 0, txt_Identificacion.Text.Trim, New ListItem("Seleccione", 0))
        End If
    End Sub

    Protected Sub btn_cargar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_cargar.Click
        If ddl_personas.SelectedValue > 0 Then
            Dim objentrega_adicional_persona As New Entregas_Adicionales_PersonasBrl

            objentrega_adicional_persona.Id_Entrega_Adicional = Request.QueryString.Item("Id")
            objentrega_adicional_persona.Id_Persona = ddl_personas.SelectedValue
            objentrega_adicional_persona.Fecha_Creacion = Now
            objentrega_adicional_persona.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
            Try
                objentrega_adicional_persona.Guardar()
            Catch ex As Exception
                lblMensaje.Text = ex.Message
                lblMensaje.ForeColor = Drawing.Color.Red
                lblMensaje.Visible = True
                Exit Sub
            End Try

            ddl_personas.Items.Clear()
            txt_Identificacion.Text = ""
            Response.Redirect("Entregas_Adicionales.aspx?Mensaje=2&Editar=1&Id=" & Request.QueryString.Item("Id"))

        Else
            lblMensaje.Text = "No se ha seleccionado Declarante."
            lblMensaje.ForeColor = Drawing.Color.Red
            lblMensaje.Visible = True
        End If
    End Sub


    Protected Sub btn_nuevo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_nuevo.Click
        Response.Redirect("../webforms/Entregas_Adicionales.aspx")
    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/Entregas_AdicionalesList.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        If Request.QueryString.Item("Id") > 0 Then
            Response.Redirect("../webforms/Entregas_Adicionales.aspx?Editar=1&Id=" + Request.QueryString.Item("Id"))
        Else
            btn_nuevo_Click(sender, e)
        End If
    End Sub

    Protected Sub ddlPrograma_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddlPrograma.SelectedIndexChanged
        If ddlPrograma.SelectedValue > 0 Then
            Dim objprograma As ProgramacionBrl = ProgramacionBrl.CargarPorID(ddlPrograma.SelectedValue)
            lbl_Fecha.Text = Format(objprograma.Fecha, "dd/MMM/yyyy")
        End If
    End Sub

    Protected Sub subCommandItem(sender As Object, e As Telerik.Web.UI.GridCommandEventArgs) Handles Rg_Listado.ItemCommand
        Select Case e.CommandName
            Case "Eliminar"
                subEliminar(sender, e)
            Case "Encuesta"
                subEncuesta(sender, e)
        End Select
    End Sub

    Public Sub subEncuesta(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs)
        Dim lblid_declaracion_seguimiento As Label
        lblid_declaracion_seguimiento = e.Item.FindControl("lblid_declaracion_seguimiento")
        Dim lblid_declaracion As Label
        lblid_declaracion = e.Item.FindControl("lblid_declaracion")
        Dim lblid As Label
        lblid = e.Item.FindControl("lblid")


        If lblid_declaracion_seguimiento.Text.Trim = "0" Then
            Response.Redirect("EncuestaEspecial.aspx?Id_Declaracion=" & lblid_declaracion.Text & "&IdEAP=" & lblid.Text)
        Else
            Response.Redirect("EncuestaEspecial.aspx?Editar=1&ID=" & lblid_declaracion_seguimiento.Text & "&Id_Declaracion=" & lblid_declaracion.Text & "&IdEAP=" & lblid.Text)
        End If


    End Sub

    Public Sub subEliminar(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs)
        Dim lblId As Label
        lblId = e.Item.FindControl("lblId")
        Dim objEntregas_Adicionales_Persona As New Entregas_Adicionales_PersonasBrl

        objEntregas_Adicionales_Persona = Entregas_Adicionales_PersonasBrl.CargarPorID(lblId.Text)

        If objEntregas_Adicionales_Persona.Id_Declaracion_Seguimiento = 0 Then  '' NO tiene encuesta diligenciada
            objEntregas_Adicionales_Persona.Eliminar()
        Else
            lblMensaje.Text = "Este Vulnerable tiene registro de Seguimiento. No se puede eliminar !!!!"
            lblMensaje.Visible = True
            Exit Sub
        End If

        btn_actualizar_Click(Nothing, Nothing)
    End Sub

    Protected Sub Rg_Listado_NeedDataSource(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Listado.NeedDataSource
        Rg_Listado.DataSource = Session("ListEngregaAdicionalPersonas")
    End Sub
End Class
