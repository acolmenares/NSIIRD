Imports System.Collections.Generic
Imports ingNovar.Utilidades2
Imports System.Data

Partial Class WebForms_GruposList
    Inherits System.Web.UI.Page
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.IsPostBack Then Exit Sub
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


        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Lugar_Entrega, 73, New ListItem("Seleccione", 0))

        Dim ListGrupos As List(Of SubTablasBrl) = Session("ListGrupos")

        'si no hay una variable de sesión con la lista.
        If ListGrupos Is Nothing Or Request.QueryString.Item("Refrescar") = 1 Then
            ListGrupos = SubTablasBrl.CargarPorId_Tabla(26)
            Session("ListGrupos") = ListGrupos
        End If

        Rg_Listado.DataSource = Session("ListGrupos")
        Rg_Listado.DataBind()

    End Sub

    Protected Sub Rg_Listado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rg_Listado.SelectedIndexChanged
        Dim item As Telerik.Web.UI.GridDataItem = Me.Rg_Listado.SelectedItems.Item(Rg_Listado.SelectedIndexes.Item(0))
        Response.Redirect("Grupos.aspx?Editar=1&ID=" & item("id").Text)
    End Sub

    Protected Sub Rg_Listado_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Listado.NeedDataSource
        Rg_Listado.DataSource = Session("ListGrupos")
    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_nuevo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_nuevo.Click
        Response.Redirect("../webforms/Grupos.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        Response.Redirect("../webforms/GruposList.aspx?Refrescar=1")
    End Sub

    Protected Sub btn_buscar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_buscar.Click
        If pnl_buscar.Visible Then
            pnl_buscar.Visible = False
            btn_buscar.ImageUrl = "~/Images/Zoom In.jpg"
        Else
            pnl_buscar.Visible = True
            btn_buscar.ImageUrl = "~/Images/Zoom Out.jpg"
        End If
    End Sub

    Protected Sub btn_limpiar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_limpiar.Click
        Dim ListGrupos As New List(Of SubTablasBrl)
        Session.Remove("ListGrupos")
        ListGrupos = SubTablasBrl.CargarPorId_Tabla(0)
        Session("ListGrupos") = ListGrupos
        txt_descripcion.Text = ""
        ddl_Lugar_Entrega.SelectedValue = 0
        Rg_Listado.DataSource = Session("ListGrupos")
        Rg_Listado.DataBind()
    End Sub

    Protected Sub btn_Procesar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_Procesar.Click
        Dim ListGrupos As New List(Of SubTablasBrl)
        Session.Remove("ListGrupos")
        ListGrupos = SubTablasBrl.CargarBusqueda(26, txt_descripcion.Text, ddl_Lugar_Entrega.SelectedValue)
        Session("ListGrupos") = ListGrupos
        Rg_Listado.DataSource = Session("ListGrupos")
        Rg_Listado.DataBind()
    End Sub
End Class
