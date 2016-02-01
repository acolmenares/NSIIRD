Imports ingNovar.Utilidades2
Imports System.Collections.Generic
Imports System.Data

Partial Class WebForms_Gestantes
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
                btnGuardar.Enabled = objper_perfil.Peditar

            Else
                btnGuardar.Enabled = objper_perfil.Pcrear
            End If

            ' asignando los permisos

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

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Control_Prenatal, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Ingesta_Micronutrientes, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Remitidas, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Visita_Domiciliaria, 4, New ListItem("Seleccione", 0))

        Dim ListGestantes As List(Of GestantesBrl)
        Dim objGestantes As GestantesBrl
        ListGestantes = GestantesBrl.CargarPorId_Persona(Request.QueryString.Item("ID"))

        If ListGestantes.Count = 0 Then
            objGestantes = New GestantesBrl
        Else
            objGestantes = ListGestantes.Item(0)
        End If

        If objGestantes IsNot Nothing Then
            If Request.QueryString.Item("Editar") = 1 Then
                If ddl_Control_Prenatal.Items.FindByValue(objGestantes.Id_Control_Prenatal) IsNot Nothing Then ddl_Control_Prenatal.SelectedValue = objGestantes.Id_Control_Prenatal
                ddl_Control_Prenatal_SelectedIndexChanged(Nothing, Nothing)

                If ddl_Control_Prenatal.SelectedValue = 19 Then
                    rdpFechaControlPrenatal.DbSelectedDate = objGestantes.Fecha_Control_Prenatal
                Else
                    rdpFechaControlPrenatal.DbSelectedDate = Nothing
                End If
                txtUnidad_Basica_Atencion.Text = objGestantes.Unidad_Basica_Atencion
                If ddl_Ingesta_Micronutrientes.Items.FindByValue(objGestantes.Id_Ingesta_Micronutrientes) IsNot Nothing Then ddl_Ingesta_Micronutrientes.SelectedValue = objGestantes.Id_Ingesta_Micronutrientes
                txtEnfermedades.Text = objGestantes.Enfermedades
                txtSemanas_Gestacion.Text = objGestantes.Semanas_Gestacion
                If ddl_Remitidas.Items.FindByValue(objGestantes.Id_Remitidas) IsNot Nothing Then ddl_Remitidas.SelectedValue = objGestantes.Id_Remitidas
                ddl_Remitidas_SelectedIndexChanged(Nothing, Nothing)
                If ddl_Remitidas.SelectedValue = 19 Then
                    rdpFechaRemision.DbSelectedDate = objGestantes.Fecha_Remision
                Else
                    rdpFechaRemision.DbSelectedDate = Nothing
                End If

                If ddl_Visita_Domiciliaria.Items.FindByValue(objGestantes.Id_Visita_Domiciliaria) IsNot Nothing Then ddl_Visita_Domiciliaria.SelectedValue = objGestantes.Id_Visita_Domiciliaria
                ddl_Visita_Domiciliaria_SelectedIndexChanged(Nothing, Nothing)
                If ddl_Visita_Domiciliaria.SelectedValue = 19 Then
                    rdpFechaVisita.DbSelectedDate = objGestantes.Fecha_Visita
                Else
                    rdpFechaVisita.DbSelectedDate = Nothing
                End If
                txtObservaciones.Text = objGestantes.Observaciones
                txt_Observaciones_Visita.Text = objGestantes.Observaciones_Visita
                txt_peso.Text = objGestantes.Peso
                txt_talla.Text = objGestantes.Talla
                LBL_IMC.Text = objGestantes.IMC / 100
                Lbl_Estado_Nutricional.Text = objGestantes.Estado_Nutricional
                Chb_cerrado.Checked = objGestantes.Cierre
            End If
        End If

        Dim objPersonas As New PersonasBrl
        objPersonas = PersonasBrl.CargarPorID(Request.QueryString.Item("Id"))
        lbl_Nombre_completo.Text = objPersonas.NombreCompleto
        lbl_Edad.Text = objPersonas.Edad
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Validate()
        If Not IsValid Then Exit Sub
        If Chb_Cerrado.Checked Then
            lblMensaje.Text = "Registro Cerrado. No se puede modificar.!!!!"
            lblMensaje.Visible = True
            Exit Sub
        End If

        Dim ID As Int32

        Try
            ID = Grabar()
            Response.Redirect("Gestantes.aspx?Editar=1&Mensaje=1&ID=" & Request.QueryString.Item("Id"))
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Private Function Grabar() As Int32
        Dim ListGestantes As New List(Of GestantesBrl)
        Dim objGestantes As GestantesBrl

        If Request.QueryString.Item("Editar") = 1 Then

            ListGestantes = GestantesBrl.CargarPorId_Persona(Request.QueryString.Item("ID"))
            If ListGestantes.Count = 0 Then
                objGestantes = New GestantesBrl
                objGestantes.Fecha_Creacion = Now
                objGestantes.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
            Else
                objGestantes = ListGestantes.Item(0)
                objGestantes.Fecha_Modificacion = Now
                objGestantes.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text
            End If
        Else
            objGestantes = New GestantesBrl
            objGestantes.Fecha_Creacion = Now
            objGestantes.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
        End If

        objGestantes.Id_Persona = Request.QueryString.Item("Id")
        objGestantes.Id_Control_Prenatal = ddl_Control_Prenatal.SelectedValue
        objGestantes.Unidad_Basica_Atencion = txtUnidad_Basica_Atencion.Text
        objGestantes.Id_Ingesta_Micronutrientes = ddl_Ingesta_Micronutrientes.SelectedValue
        objGestantes.Enfermedades = txtEnfermedades.Text
        objGestantes.Semanas_Gestacion = txtSemanas_Gestacion.Text
        objGestantes.Id_Remitidas = ddl_Remitidas.SelectedValue
        Try
            objGestantes.Fecha_Remision = rdpFechaRemision.DbSelectedDate
        Catch ex As Exception
            objGestantes.Fecha_Remision = Nothing
        End Try

        objGestantes.Id_Visita_Domiciliaria = ddl_Visita_Domiciliaria.SelectedValue
        Try
            objGestantes.Fecha_Visita = rdpFechaVisita.DbSelectedDate
        Catch ex As Exception
            objGestantes.Fecha_Visita = Nothing
        End Try

        objGestantes.Observaciones = txtObservaciones.Text
        Try
            objGestantes.Fecha_Control_Prenatal = rdpFechaControlPrenatal.DbSelectedDate
        Catch ex As Exception
            objGestantes.Fecha_Control_Prenatal = Nothing
        End Try

        objGestantes.Observaciones_Visita = txt_Observaciones_Visita.Text
        objGestantes.Peso = Val(txt_peso.Text)
        objGestantes.Talla = Val(txt_talla.Text)
        objGestantes.IMC = Int(CType(LBL_IMC.Text, Double) * 100)
        objGestantes.Estado_Nutricional = Lbl_Estado_Nutricional.Text
        objGestantes.Guardar()

        Return objGestantes.ID

    End Function

    Protected Sub txtSemanas_Gestacion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSemanas_Gestacion.TextChanged, txt_peso.TextChanged, txt_talla.TextChanged
        Dim wpaso As Boolean = True
        If txtSemanas_Gestacion.Text.Trim = "" Then
            wpaso = False
        End If
        If Me.txt_peso.Text.Trim = "" Or txt_peso.Text.Trim = "0" Then
            wpaso = False
        End If
        If txt_talla.Text.Trim = "" Or txt_talla.Text.Trim = "0" Then
            wpaso = False
        End If

        If wpaso Then
            Dim wdato As Double = 0
            wdato = Val(txt_peso.Text) / (Int(Val(txt_talla.Text)) * Int(Val(txt_talla.Text)) / 10000)
            LBL_IMC.Text = Int(wdato * 100) / 100
            Dim objimc As IMCBrl = IMCBrl.CargarPorConsultaBase(txtSemanas_Gestacion.Text, wdato)
            If objimc IsNot Nothing Then
                Lbl_Estado_Nutricional.Text = objimc.Estado
            Else
                Lbl_Estado_Nutricional.Text = ""
            End If
        End If
    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/GestantesList.aspx")
    End Sub

    Protected Sub ddl_Control_Prenatal_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddl_Control_Prenatal.SelectedIndexChanged
        If ddl_Control_Prenatal.SelectedValue = 19 Then
            rdpFechaControlPrenatal.Enabled = True
        Else
            rdpFechaControlPrenatal.Enabled = False
            rdpFechaControlPrenatal.DbSelectedDate = Nothing
        End If
    End Sub

    Protected Sub ddl_Remitidas_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddl_Remitidas.SelectedIndexChanged
        If ddl_Remitidas.SelectedValue = 19 Then
            rdpFechaRemision.Enabled = True
        Else
            rdpFechaRemision.Enabled = False
            rdpFechaRemision.DbSelectedDate = Nothing
        End If
    End Sub

    Protected Sub ddl_Visita_Domiciliaria_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddl_Visita_Domiciliaria.SelectedIndexChanged
        If ddl_Visita_Domiciliaria.SelectedValue = 19 Then
            rdpFechaVisita.Enabled = True
        Else
            rdpFechaVisita.Enabled = False
            rdpFechaVisita.DbSelectedDate = Nothing
        End If
    End Sub
End Class
