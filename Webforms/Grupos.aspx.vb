Imports ingNovar.Utilidades2
Imports System.Collections.Generic

Partial Class WebForms_Grupos
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

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Regional, 72, New ListItem("Seleccione", 0))

        If Request.QueryString.Item("Editar") = 1 Then
            Dim objGrupo As SubTablasBrl = SubTablasBrl.CargarPorID(Request.QueryString.Item("ID"))

            If objGrupo Is Nothing Then
                lblMensaje.Text = "Registro no existe"
                lblMensaje.Visible = True
                Exit Sub
            End If

            txtDescripcion.Text = objGrupo.Descripcion
            BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Lugar_Entrega, 73, New ListItem("Seleccione", 0))
            If ddl_Lugar_Entrega.Items.FindByValue(objGrupo.Id_Padre) IsNot Nothing Then
                ddl_Lugar_Entrega.SelectedValue = objGrupo.Id_Padre

                Try
                    ddl_Regional.SelectedValue = SubTablasBrl.CargarPorID(objGrupo.Id_Padre).Id_Padre
                Catch ex As Exception
                End Try

            End If

        End If

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Validate()
        If Not IsValid Then Exit Sub

        Dim ID As Int32

        Try
            ID = Grabar()
            Response.Redirect("Grupos.aspx?Editar=1&Mensaje=1&ID=" & ID)
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Private Sub btnGuardarOtro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarOtro.Click
        Validate()
        If Not IsValid Then Exit Sub

        Try
            Grabar()
            Response.Redirect("Grupos.aspx?Mensaje=1")
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Session.Remove("Grupos")
        Response.Redirect("GruposList.aspx?Refrescar=1")
    End Sub

    Private Function Grabar() As Int32

        Dim objGrupo As SubTablasBrl

        If Request.QueryString.Item("Editar") = 1 Then
            objGrupo = SubTablasBrl.CargarPorID(Request.QueryString.Item("ID"))
            objGrupo.Fecha_Modificacion = Now
            objGrupo.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text
        Else
            objGrupo = New SubTablasBrl
            objGrupo.Fecha_Creacion = Now
            objGrupo.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
            objGrupo.Activo = 1
            objGrupo.Id_Tabla = 26 ' Grupos
        End If


        objGrupo.Descripcion = txtDescripcion.Text
        objGrupo.Id_Padre = ddl_Lugar_Entrega.SelectedValue

        objGrupo.Guardar()

        Return objGrupo.ID

    End Function

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim objGrupo As SubTablasBrl

        Try
            If Request.QueryString.Item("Editar") = 1 Then
                objGrupo = SubTablasBrl.CargarPorID(Request.QueryString.Item("ID"))
                objGrupo.Eliminar()
                Response.Redirect("Grupos.aspx?Mensaje=1")
            End If
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Protected Sub ddl_Regional_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_Regional.SelectedIndexChanged
        If ddl_Regional.SelectedValue <> 0 Then
            BindHelper.SubTablasUIL.BindToListControlPorId_TablaPadre(ddl_Lugar_Entrega, 73, ddl_Regional.SelectedValue, New ListItem("Seleccione", 0))
        Else
            ddl_Lugar_Entrega.Items.Clear()
        End If
    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/GruposList.aspx")
    End Sub

    Protected Sub btn_nuevo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_nuevo.Click
        Response.Redirect("../webforms/Grupos.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        If Request.QueryString.Item("Id") > 0 Then
            Response.Redirect("../webforms/Grupos.aspx?Editar=1&Id=" + Request.QueryString.Item("Id"))
        Else
            btn_nuevo_Click(sender, e)
        End If
    End Sub
End Class
