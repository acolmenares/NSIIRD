Imports ingNovar.Utilidades2
Imports System.Collections.Generic
Imports System.Data

Partial Class WebForms_Validar_Identificacion
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

        txt_Identificacion.Text = ""
        If Session("PersonasIdentificacion") IsNot Nothing Then
            Rg_Listado.DataSource = Session("PersonasIdentificacion")
            Rg_Listado.DataBind()
        End If

    End Sub

    Protected Sub btn_validar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_validar.Click

        If txt_Identificacion.Text.Trim = "" Then
            lblMensaje.Text = "Falta Digitar el Número de Identificación."
            lblMensaje.Visible = True
            lblMensaje.ForeColor = Drawing.Color.Red
            Exit Sub
        End If

        Dim objpersonas As New List(Of PersonasBrl)
        objpersonas = PersonasBrl.CargarPorIdentificacion("0", txt_Identificacion.Text)
        Session("PersonasIdentificacion") = objpersonas
        Rg_Listado.DataSource = Session("PersonasIdentificacion")
        Rg_Listado.DataBind()

    End Sub

    Protected Sub Rg_Listado_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Listado.NeedDataSource
        Rg_Listado.DataSource = Session("PersonasIdentificacion")
    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        Response.Redirect("../webforms/Validar_Identificacion.aspx?Refrescar=1")
    End Sub
End Class
