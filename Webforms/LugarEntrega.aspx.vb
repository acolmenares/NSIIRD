Imports ingNovar.Utilidades2
Imports System.Collections.Generic

Partial Class WebForms_LugarEntrega
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
            Dim objLentrega As SubTablasBrl = SubTablasBrl.CargarPorID(Request.QueryString.Item("ID"))

            If objLentrega Is Nothing Then
                lblMensaje.Text = "Registro no existe"
                lblMensaje.Visible = True
                Exit Sub
            End If

            txtDescripcion.Text = objLentrega.Descripcion
            If ddl_Regional.Items.FindByValue(objLentrega.Id_Padre) IsNot Nothing Then ddl_Regional.SelectedValue = objLentrega.Id_Padre

        End If

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Validate()
        If Not IsValid Then Exit Sub

        Dim ID As Int32

        Try
            ID = Grabar()
            Response.Redirect("LugarEntrega.aspx?Editar=1&Mensaje=1&ID=" & ID)
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
            Response.Redirect("LugarEntrega.aspx?Mensaje=1")
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Session.Remove("LugarEntrega")
        Response.Redirect("LugaresEntregaList.aspx?Refrescar=1")
    End Sub

    Private Function Grabar() As Int32

        Dim objLentrega As SubTablasBrl

        If Request.QueryString.Item("Editar") = 1 Then
            objLentrega = SubTablasBrl.CargarPorID(Request.QueryString.Item("ID"))
            objLentrega.Fecha_Modificacion = Now
            objLentrega.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text
        Else
            objLentrega = New SubTablasBrl
            objLentrega.Fecha_Creacion = Now
            objLentrega.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
            objLentrega.Activo = 1
            objLentrega.Id_Tabla = 73
        End If

        objLentrega.Descripcion = txtDescripcion.Text
        objLentrega.Id_Padre = ddl_Regional.SelectedValue


        objLentrega.Guardar()

        Return objLentrega.ID

    End Function

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim objLentrega As SubTablasBrl

        Try
            If Request.QueryString.Item("Editar") = 1 Then
                objLentrega = SubTablasBrl.CargarPorID(Request.QueryString.Item("ID"))
                objLentrega.Eliminar()
                Response.Redirect("LugarEntrega.aspx?Mensaje=1")
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
        Response.Redirect("../webforms/LugaresEntregaList.aspx")
    End Sub

    Protected Sub btn_nuevo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_nuevo.Click
        Response.Redirect("../webforms/LugarEntrega.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        If Request.QueryString.Item("Id") > 0 Then
            Response.Redirect("../webforms/LugarEntrega.aspx?Editar=1&Id=" + Request.QueryString.Item("Id"))
        Else
            btn_nuevo_Click(sender, e)
        End If
    End Sub
End Class
