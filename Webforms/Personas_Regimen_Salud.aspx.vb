Imports ingNovar.Utilidades2
Imports System.Data
Imports System.Collections.Generic
Imports Telerik.Web.UI

Partial Class WebForms_Personas_Regimen_Salud
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
        If objper_perfil IsNot Nothing Then
            If objper_perfil.Pver = False Or objper_perfil.Pconsultar = False Then
                Response.Redirect(strPaginaError)
                Exit Sub
            End If

            ' asignando los permisos

            If Request.QueryString.Item("Id") > 0 Then  ' va a editar
                btnGuardar.Enabled = objper_perfil.Peditar
            Else
                btnGuardar.Enabled = objper_perfil.Pcrear
            End If

            Rg_Listado.ClientSettings.EnablePostBackOnRowClick = objper_perfil.Peditar

        End If

        If objper_usuario IsNot Nothing Then
            If objper_usuario.Pver = False Or objper_usuario.Pconsultar = False Then
                Response.Redirect(strPaginaError)
                Exit Sub
            End If

            ' asignando los permisos

            If Request.QueryString.Item("Id") > 0 Then  ' va a editar
                btnGuardar.Enabled = objper_usuario.Peditar
            Else
                btnGuardar.Enabled = objper_usuario.Pcrear
            End If

            Rg_Listado.ClientSettings.EnablePostBackOnRowClick = objper_usuario.Peliminar
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

        Dim objpersona As PersonasBrl = PersonasBrl.CargarPorID(Request.QueryString.Item("Id"))
        If objpersona Is Nothing Then
            lbl_NombreCompleto.Text = ""
            lbl_Grupo.Text = ""
        Else
            lbl_NombreCompleto.Text = objpersona.NombreCompleto
            lbl_Grupo.Text = objpersona.Declaracion.DescripcionGrupo
        End If

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Regimen_Salud, 7, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_eps, 30, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Necesita_Traslado, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Motivo_No_Necesita_Traslado, 16, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Realizo_Traslado, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Motivo_No_Realizo_Traslado, 90, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_cerrar, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_departamento, 46, New ListItem("Seleccione", 0))

        Dim objPersonas_Regimen_Salud As List(Of Personas_Regimen_SaludBrl) = Personas_Regimen_SaludBrl.CargarPorId_Persona(Request.QueryString.Item("ID"))

        Session("Regimen_Salud") = objPersonas_Regimen_Salud
        Rg_Listado.DataSource = Session("Regimen_Salud")
        Rg_Listado.DataBind()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click, btnGuardar.Click
        Validate("SE")
        If Not IsValid Then Exit Sub

        If chb_cerrado.Checked Then
            lblMensaje.Text = "Registro Cerrado. No se puede Modificar.!!!!"
            lblMensaje.Visible = True
            Exit Sub
        End If

        Dim ID As Int32

        Try
            ID = Grabar()
            Response.Redirect("Personas_Regimen_Salud.aspx?Editar=1&Mensaje=1&ID=" & Request.QueryString.Item("id"))
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        rdpfecha.SelectedDate = Nothing
        lblId.Text = ""
        ddl_Regimen_Salud.SelectedValue = 0
        ddl_eps.SelectedValue = 0
        ddl_departamento.SelectedValue = 0
        ddl_departamento_SelectedIndexChanged(Nothing, Nothing)
        ddl_Necesita_Traslado.SelectedValue = 0
        ddl_Motivo_No_Necesita_Traslado.SelectedValue = 0

        ddl_Realizo_Traslado.Enabled = False
        ddl_Realizo_Traslado.SelectedValue = 0
        rev_realizo_traslado.Enabled = False
        ddl_Motivo_No_Realizo_Traslado.SelectedValue = 0
        rev_motivo_no_realizar_traslado.Enabled = False
        ddl_cerrar.SelectedValue = 0

        chb_cerrado.Checked = False
        txt_observaciones.Text = ""
        ddl_Necesita_Traslado_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Function Grabar() As Int32
        Dim objPersonas_Regimen_Salud As Personas_Regimen_SaludBrl
        If lblId.Text <> "" Then
            objPersonas_Regimen_Salud = Personas_Regimen_SaludBrl.CargarPorID(lblId.Text)
        Else
            objPersonas_Regimen_Salud = New Personas_Regimen_SaludBrl
            objPersonas_Regimen_Salud.Id_Persona = Request.QueryString.Item("Id")
            objPersonas_Regimen_Salud.Id_Tipo_Entrega = 919  ' Seguimiento
        End If

        Try
            objPersonas_Regimen_Salud.Fecha = rdpfecha.DbSelectedDate
        Catch ex As Exception
            objPersonas_Regimen_Salud.Fecha = Nothing
        End Try

        objPersonas_Regimen_Salud.Id_Regimen_Salud = ddl_Regimen_Salud.SelectedValue
        objPersonas_Regimen_Salud.Id_Eps = ddl_eps.SelectedValue
        objPersonas_Regimen_Salud.Id_Necesita_Traslado = ddl_Necesita_Traslado.SelectedValue
        objPersonas_Regimen_Salud.Id_Municipio = ddl_municipio.SelectedValue
        objPersonas_Regimen_Salud.Id_Motivo_No_Necesita_Traslado = ddl_Motivo_No_Necesita_Traslado.SelectedValue
        objPersonas_Regimen_Salud.Id_Realizo_Traslado = ddl_Realizo_Traslado.SelectedValue
        objPersonas_Regimen_Salud.Id_Motivo_No_Realizo_Traslado = ddl_Motivo_No_Realizo_Traslado.SelectedValue
        objPersonas_Regimen_Salud.Id_Cerrar = ddl_cerrar.SelectedValue
        objPersonas_Regimen_Salud.Observaciones = txt_observaciones.Text
        objPersonas_Regimen_Salud.Guardar()

        Return objPersonas_Regimen_Salud.ID

    End Function

    Public Sub subCommandItem(ByVal sender As Object, ByVal e As GridCommandEventArgs) Handles Rg_Listado.ItemCommand
        Select Case e.CommandName
            Case "Eliminar"
                subEliminar(sender, e)
        End Select
    End Sub

    Protected Sub Rg_Listado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rg_Listado.SelectedIndexChanged
        Dim item As Telerik.Web.UI.GridDataItem = Me.Rg_Listado.SelectedItems.Item(Rg_Listado.SelectedIndexes.Item(0))

        Dim objPersonas_Regimen_Salud As Personas_Regimen_SaludBrl = Personas_Regimen_SaludBrl.CargarPorID(item("Id").Text)

        If objPersonas_Regimen_Salud.Id_Tipo_Entrega = 919 Then

            lblId.Text = ""
            If objPersonas_Regimen_Salud IsNot Nothing Then
                rdpfecha.SelectedDate = objPersonas_Regimen_Salud.Fecha
                If ddl_Regimen_Salud.Items.FindByValue(objPersonas_Regimen_Salud.Id_Regimen_Salud) IsNot Nothing Then ddl_Regimen_Salud.SelectedValue = objPersonas_Regimen_Salud.Id_Regimen_Salud
                If ddl_eps.Items.FindByValue(objPersonas_Regimen_Salud.Id_Eps) IsNot Nothing Then ddl_eps.SelectedValue = objPersonas_Regimen_Salud.Id_Eps

                ddl_departamento.SelectedValue = objPersonas_Regimen_Salud.MunicipioRS.Id_Padre
                ddl_departamento_SelectedIndexChanged(Nothing, Nothing)
                ddl_municipio.SelectedValue = objPersonas_Regimen_Salud.Id_Municipio

                If ddl_Necesita_Traslado.Items.FindByValue(objPersonas_Regimen_Salud.Id_Necesita_Traslado) IsNot Nothing Then ddl_Necesita_Traslado.SelectedValue = objPersonas_Regimen_Salud.Id_Necesita_Traslado
                If ddl_Motivo_No_Necesita_Traslado.Items.FindByValue(objPersonas_Regimen_Salud.Id_Motivo_No_Necesita_Traslado) IsNot Nothing Then ddl_Motivo_No_Necesita_Traslado.SelectedValue = objPersonas_Regimen_Salud.Id_Motivo_No_Necesita_Traslado
                If ddl_Realizo_Traslado.Items.FindByValue(objPersonas_Regimen_Salud.Id_Realizo_Traslado) IsNot Nothing Then ddl_Realizo_Traslado.SelectedValue = objPersonas_Regimen_Salud.Id_Realizo_Traslado
                If ddl_Motivo_No_Realizo_Traslado.Items.FindByValue(objPersonas_Regimen_Salud.Id_Motivo_No_Realizo_Traslado) IsNot Nothing Then ddl_Motivo_No_Realizo_Traslado.SelectedValue = objPersonas_Regimen_Salud.Id_Motivo_No_Realizo_Traslado
                If ddl_cerrar.Items.FindByValue(objPersonas_Regimen_Salud.Id_Cerrar) IsNot Nothing Then ddl_cerrar.SelectedValue = objPersonas_Regimen_Salud.Id_Cerrar
                lblId.Text = objPersonas_Regimen_Salud.ID
                txt_observaciones.Text = objPersonas_Regimen_Salud.Observaciones

                ddl_Necesita_Traslado_SelectedIndexChanged(Nothing, Nothing)
            End If
        End If
    End Sub

    Public Sub subEliminar(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Dim lblIdInterno As Label
        lblIdInterno = e.Item.FindControl("lblId")
        Dim objPersona_Regimen_Salud As Personas_Regimen_SaludBrl
        objPersona_Regimen_Salud = Personas_Regimen_SaludBrl.CargarPorID(lblIdInterno.Text)
        objPersona_Regimen_Salud.Eliminar()

        Dim objPersonas_Regimen_Salud As List(Of Personas_Regimen_SaludBrl) = Personas_Regimen_SaludBrl.CargarPorId_Persona(Request.QueryString.Item("ID"))

        Session("Regimen_Salud") = objPersonas_Regimen_Salud
        Rg_Listado.DataSource = Session("Regimen_Salud")
        Rg_Listado.DataBind()
    End Sub

    Protected Sub Rg_Listado_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles Rg_Listado.ItemDataBound
        If e.Item.ItemType = GridItemType.AlternatingItem Or e.Item.ItemType = GridItemType.Item Then
            Dim lbltipo1 As New Label
            lbltipo1 = e.Item.FindControl("lbltipoSeguimiento")
            Select lbltipo1.Text
                Case Is = "54" 'Antes del Desplazamiento
                    'btneliminar.Visible = False
                    e.Item.Cells(12).Visible = False
                    e.Item.Cells(5).ForeColor = Drawing.Color.Green
                Case Is = "918" 'Segunda Entrega
                    'btneliminar.Visible = False
                    e.Item.Cells(12).Visible = False
                    e.Item.Cells(5).ForeColor = Drawing.Color.Orange
                Case Is = "72"  'Primera Entrega
                    'btneliminar.Visible = False
                    e.Item.Cells(12).Visible = False
                    e.Item.Cells(5).ForeColor = Drawing.Color.Navy
                Case Else
                    e.Item.Cells(5).ForeColor = Drawing.Color.Brown
            End Select
        End If
    End Sub

    Protected Sub ddl_Necesita_Traslado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_Necesita_Traslado.SelectedIndexChanged

        ddl_Motivo_No_Realizo_Traslado.Enabled = False
        ddl_Motivo_No_Realizo_Traslado.SelectedValue = 0
        rev_motivo_no_realizar_traslado.Enabled = False
        ddl_Motivo_No_Necesita_Traslado.Enabled = False
        ddl_Motivo_No_Necesita_Traslado.SelectedValue = 0
        rev_Motivo_No_Necesita_Traslado.Enabled = False

        If ddl_Necesita_Traslado.SelectedValue = 19 Then
            ddl_Realizo_Traslado.Enabled = True
            rev_realizo_traslado.Enabled = True
        End If

        If ddl_Necesita_Traslado.SelectedValue = 20 Then
            ddl_Motivo_No_Necesita_Traslado.Enabled = True
            rev_Motivo_No_Necesita_Traslado.Enabled = True
            ddl_Realizo_Traslado.Enabled = False
            ddl_Realizo_Traslado.SelectedValue = 0
            rev_realizo_traslado.Enabled = False
            ddl_Realizo_Traslado_SelectedIndexChanged(Nothing, Nothing)

        End If
    End Sub

    Protected Sub ddl_Realizo_Traslado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_Realizo_Traslado.SelectedIndexChanged
        ddl_Motivo_No_Realizo_Traslado.SelectedValue = 0
        ddl_Motivo_No_Realizo_Traslado.Enabled = False
        rev_motivo_no_realizar_traslado.Enabled = False

        If ddl_Realizo_Traslado.SelectedValue = 20 Then
            ddl_Motivo_No_Realizo_Traslado.Enabled = True
            rev_motivo_no_realizar_traslado.Enabled = True
        End If
    End Sub

    Protected Sub btn_nuevo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_nuevo.Click
        Response.Redirect("../webforms/Personas_Regimen_Salud.aspx?Id=" + Request.QueryString.Item("Id"))
    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/Personas_Regimen_SaludList.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        If Request.QueryString.Item("Id") > 0 Then
            Response.Redirect("../webforms/Personas_Regimen_Salud.aspx?Editar=1&Id=" + Request.QueryString.Item("Id"))
        Else
            btn_nuevo_Click(sender, e)
        End If
    End Sub

    Protected Sub Rg_Listado_NeedDataSource(sender As Object, e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Listado.NeedDataSource
        Rg_Listado.DataSource = Session("Regimen_Salud")
    End Sub

    Protected Sub ddl_departamento_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddl_departamento.SelectedIndexChanged
        BindHelper.SubTablasUIL.BindToListControlPorId_TablaPadre(ddl_municipio, 15, ddl_departamento.SelectedValue, New ListItem("Seleccione", 0))
    End Sub
End Class
