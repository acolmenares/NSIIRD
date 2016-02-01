Imports ingNovar.Utilidades2
Imports System.Collections.Generic

Partial Class WebForms_ReProgramaciones
    Inherits System.Web.UI.Page

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

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(Lst_Tipos_Contacto, 19)
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_MotivoPorQueNo, 29, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_reprogramado, 4, New ListItem("Seleccione", 0))
        BindHelper.ProgramacionUIL.BindToListControlPorId_Estado(ddl_Programa_Reprograma, 213, New ListItem("Seleccione", 0))

        Dim objDeclaracion As DeclaracionBrl = DeclaracionBrl.CargarPorID(Request.QueryString.Item("ID"))

        If objDeclaracion Is Nothing Then
            lblMensaje.Text = "Registro no existe"
            lblMensaje.Visible = True
            Exit Sub
        End If

        lbl_FechaDeclaracion.Text = FechaUtil.toStringDDMMYYY(objDeclaracion.Fecha_Declaracion, "/")
        lbl_FechaRadicacion.Text = FechaUtil.toStringDDMMYYY(objDeclaracion.Fecha_Radicacion, "/")
        Try
            lbl_fuente.Text = objDeclaracion.Fuente.Descripcion
        Catch ex As Exception
            lbl_fuente.Text = "N/A"
        End Try

        Lbl_regional.Text = objDeclaracion.Regionales.Descripcion
        lbl_lugarFuente.Text = objDeclaracion.NombreLugarFuente
        lbl_enlinea.Text = objDeclaracion.DeclaracionEnLinea
        lbl_FechaDesplazamiento.Text = FechaUtil.toStringDDMMYYY(objDeclaracion.Fecha_Desplazamiento, "/")
        lbl_NumeroDeclaracion.Text = objDeclaracion.Numero_Declaracion
        lbl_Horario.Text = objDeclaracion.Horario
        lbl_tipo_declarante.Text = objDeclaracion.TipoDeclaracion.Descripcion
        lbl_TipoFamilia.Text = objDeclaracion.TipoFamiliaxaEmpacar
        txt_observaciones.Text = objDeclaracion.Observaciones


        ' cargas los datos de la persona
        Lst_Tipos_Contacto_Persona.Items.Clear()
        Dim objpersona As PersonasBrl = PersonasBrl.CargarPorId_DeclaracionYDeclarante(Request.QueryString.Item("Id"))
        If objpersona IsNot Nothing Then
            lbl_PrimerNombre.Text = objpersona.Primer_Nombre
            lbl_SegundoNombre.Text = objpersona.Segundo_Nombre
            lbl_PrimerApellido.Text = objpersona.Primer_Apellido
            lbl_SegundoApellido.Text = objpersona.Segundo_Apellido
            lbl_TipoIdentificacion.Text = objpersona.Tipo_Identificacion.Descripcion
            lbl_Identificacion.Text = objpersona.Identificacion
            lbl_Edad.Text = objpersona.Edad
            lbl_Genero.Text = objpersona.GeneroPersona
            lbl_FechaNacimiento.Text = FechaUtil.toStringDDMMYYY(objpersona.Fecha_Nacimiento, "/")


            Dim objcontactos As List(Of Personas_ContactosBrl)
            objcontactos = Personas_ContactosBrl.CargarPorId_Persona(objpersona.ID)
            For Each fila As Personas_ContactosBrl In objcontactos
                Me.Lst_Tipos_Contacto_Persona.Items.Add(New ListItem(fila.SubTablasTipoContacto.Descripcion & " : " & fila.Descripcion, fila.Id_Tipo_Contacto))
            Next
        End If

        cargarestados()
    End Sub

    Public Sub cargarestados()
        Dim objestadosDeclaracion As List(Of Declaracion_EstadosBrl) = Declaracion_EstadosBrl.CargarPorId_Declaracion(Request.QueryString.Item("ID"))
        Session("EstadosDeclaracion") = objestadosDeclaracion
        gv_estados.DataSource = Session("EstadosDeclaracion")
        gv_estados.DataBind()
        ddl_MotivoPorQueNo.Visible = False
    End Sub

    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton1.Click
        If Len(txtvalor.Text) <> 0 Then
            If Lst_Tipos_Contacto.SelectedValue <> 0 Then
                Lst_Tipos_Contacto_Persona.Items.Add(New ListItem(Lst_Tipos_Contacto.SelectedItem.Text.Trim & " : " & txtvalor.Text.Trim, Lst_Tipos_Contacto.SelectedValue))
                txtvalor.Text = ""
                Lst_Tipos_Contacto.SelectedIndex = -1
                Lst_Tipos_Contacto.ClearSelection()
            End If
        Else
            lblMensaje.Text = "No hay dato de descripción del tipo de contacto"
            lblMensaje.Visible = True
            lblMensaje.ForeColor = Drawing.Color.Red
        End If
    End Sub

    Protected Sub LinkButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton2.Click
        ' para retirar un registro de la base de contactos
        Lst_Tipos_Contacto_Persona.Items.RemoveAt(Lst_Tipos_Contacto_Persona.SelectedIndex)
        Lst_Tipos_Contacto_Persona.ClearSelection()
    End Sub

    Protected Sub gv_estados_RowDeleting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewDeleteEventArgs) Handles gv_estados.RowDeleting
        'Dim fila As GridViewRow = gv_estados.Rows(e.RowIndex)
        Try
            Dim objestado As Declaracion_EstadosBrl = CType(Session("EstadosDeclaracion"), List(Of Declaracion_EstadosBrl)).Item(e.RowIndex)


            If (objestado.Id_Tipo_Estado = 4036) Or (objestado.Id_Tipo_Estado = 4037) Then
                If objestado.Id_Como_Estado = 20 Then
                    Dim objdeclaracion As DeclaracionBrl = DeclaracionBrl.CargarPorID(objestado.Id_Declaracion)
                    objdeclaracion.Id_Atender = 0
                    objdeclaracion.Id_Motivo_Noatender = 0
                    objdeclaracion.Observaciones = txt_observaciones.Text
                    objdeclaracion.Guardar()
                End If
            End If

            objestado.Eliminar()

        Finally
            cargarestados()
        End Try

    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/ReProgramacionesList.aspx")
    End Sub

    Protected Sub btn_nuevo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_nuevo.Click
        Response.Redirect("../webforms/ReProgramaciones.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        If Request.QueryString.Item("Id") > 0 Then
            Response.Redirect("../webforms/ReProgramaciones.aspx?Id=" + Request.QueryString.Item("Id"))
        Else
            btn_nuevo_Click(sender, e)
        End If
    End Sub

    Protected Sub btn_limpiarReprogramación_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_limpiarReprogramación.Click
        ddl_reprogramado.SelectedValue = 0
        ddl_MotivoPorQueNo.SelectedValue = 0
        ddl_Programa_Reprograma.SelectedValue = 0
        ddl_MotivoPorQueNo.Visible = False
        ddl_Programa_Reprograma.Visible = False

    End Sub

    Protected Sub btn_GrabarReprogramacion_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_GrabarReprogramacion.Click
        Validate("REPROGRAMADO")
        If Not IsValid Then Exit Sub
        lblMensaje.Visible = False

        Dim objestado As New Declaracion_EstadosBrl
        objestado.Id_Declaracion = Request.QueryString.Item("ID")
        objestado.Fecha_Creacion = Now
        objestado.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text

        If ddl_reprogramado.SelectedValue = 19 Then

            Dim objprograma As ProgramacionBrl = ProgramacionBrl.CargarPorID(ddl_Programa_Reprograma.SelectedValue)

            objestado.Fecha = objprograma.Fecha
            objestado.Id_Tipo_Estado = 4039 ' estado reprogramado
            objestado.Id_Como_Estado = ddl_reprogramado.SelectedValue
            objestado.Id_Programa = ddl_Programa_Reprograma.SelectedValue
            objestado.Guardar()
        Else
            objestado.Fecha = Now
            objestado.Id_Tipo_Estado = 4036
            objestado.Id_Como_Estado = 20
            objestado.Id_Motivo_NoAtencion = ddl_MotivoPorQueNo.SelectedValue
            objestado.Guardar()

            ' cambiando el estado de la declaracion solo en e

            Dim objdeclaracion As DeclaracionBrl = objestado.Declaracion
            If objdeclaracion.Id_Grupo = 0 Then
                objdeclaracion.Id_Atender = 20
                objdeclaracion.Id_Motivo_Noatender = ddl_MotivoPorQueNo.SelectedValue
                objdeclaracion.Guardar()
            End If

        End If

            cargarestados()
            gv_estados.DataSource = Session("EstadosDeclaracion")
            gv_estados.DataBind()
            btn_limpiarReprogramación_Click(Nothing, Nothing)
    End Sub

    Protected Sub ddl_reprogramado_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ddl_reprogramado.SelectedIndexChanged
        ddl_Programa_Reprograma.Visible = False
        rev_reprograma.Enabled = False
        rev_reprograma.Visible = False
        rev_Motivo_NoContactado.Visible = False

        If ddl_reprogramado.SelectedValue = 20 Then
            ddl_Programa_Reprograma.SelectedValue = 0
            ddl_MotivoPorQueNo.Visible = True
            rev_Motivo_NoContactado.Enabled = True
            rev_Motivo_NoContactado.Visible = True
        End If
        If ddl_reprogramado.SelectedValue = 19 Then
            ddl_Programa_Reprograma.Visible = True
            rev_reprograma.Enabled = True
            rev_reprograma.Visible = True
        End If
    End Sub

End Class
