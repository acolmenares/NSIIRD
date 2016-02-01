Imports ingNovar.Utilidades2
Imports System.Collections.Generic

Partial Class WebForms_Concejo
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
                btnGuardarOtro.Enabled = objper_perfil.Pcrear
            Else
                btnGuardar.Enabled = objper_perfil.Pcrear
                btnGuardarOtro.Enabled = objper_perfil.Pcrear
            End If
            btnEliminar.Enabled = objper_perfil.Peliminar

            ' asignando los permisos

            btn_nuevo.Enabled = objper_perfil.Pcrear

        End If

        If objper_usuario IsNot Nothing Then
            If objper_usuario.Pver = False Or objper_usuario.Pconsultar = False Then
                Response.Redirect(strPaginaError)
                Exit Sub
            End If

            ' asignando los permisos

            If Request.QueryString.Item("Id") > 0 Then  ' va a editar
                btnGuardar.Enabled = objper_usuario.Peditar
                btnGuardarOtro.Enabled = objper_usuario.Pcrear
            Else
                btnGuardar.Enabled = objper_usuario.Pcrear
                btnGuardarOtro.Enabled = objper_usuario.Pcrear
            End If
            btnEliminar.Enabled = objper_usuario.Peliminar
            '
            btn_nuevo.Enabled = objper_usuario.Pcrear

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

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Municipios, 15, New ListItem("Seleccione", 0))

        If Request.QueryString.Item("Editar") = 1 Then
            Dim objconcejo As SubTablasBrl = SubTablasBrl.CargarPorID(Request.QueryString.Item("ID"))

            If objconcejo Is Nothing Then
                lblMensaje.Text = "Registro no existe"
                lblMensaje.Visible = True
                Exit Sub
            End If

            txtDescripcion.Text = objconcejo.Descripcion
            If ddl_Municipios.Items.FindByValue(objconcejo.Id_Padre) IsNot Nothing Then ddl_Municipios.SelectedValue = objconcejo.Id_Padre

        End If

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        lblMensaje.Text = ""
        Validate()
        If Not IsValid Then Exit Sub

        Dim ID As Int32

        Try
            ID = Grabar()
            Response.Redirect("Concejo.aspx?Editar=1&Mensaje=1&ID=" & ID)
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Private Sub btnGuardarOtro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarOtro.Click
        lblMensaje.Text = ""
        Validate()
        If Not IsValid Then Exit Sub

        Try
            Grabar()
            Response.Redirect("Concejo.aspx?Mensaje=1")
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Private Function Grabar() As Int32

        Dim objconcejo As SubTablasBrl

        If Request.QueryString.Item("Editar") = 1 Then
            objconcejo = SubTablasBrl.CargarPorID(Request.QueryString.Item("ID"))
            objconcejo.Fecha_Modificacion = Now
            objconcejo.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text

        Else
            objconcejo = New SubTablasBrl
            objconcejo.Fecha_Creacion = Now
            objconcejo.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
            objconcejo.Activo = 1
            objconcejo.Id_Tabla = 17
        End If

        objconcejo.Descripcion = txtDescripcion.Text
        objconcejo.Id_Padre = ddl_Municipios.SelectedValue

        objconcejo.Guardar()

        Return objconcejo.ID

    End Function

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim objconcejo As SubTablasBrl

        Try
            If Request.QueryString.Item("Editar") = 1 Then
                objconcejo = SubTablasBrl.CargarPorID(Request.QueryString.Item("ID"))
                objconcejo.Eliminar()
                Response.Redirect("ConcejoList.aspx?Refrescar=1")
            End If
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/ConcejosList.aspx")
    End Sub

    Protected Sub btn_nuevo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_nuevo.Click
        Response.Redirect("../webforms/Concejo.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        If Request.QueryString.Item("Id") > 0 Then
            Response.Redirect("../webforms/Concejo.aspx?Editar=1&Id=" + Request.QueryString.Item("Id"))
        Else
            btn_nuevo_Click(sender, e)
        End If
    End Sub
End Class
