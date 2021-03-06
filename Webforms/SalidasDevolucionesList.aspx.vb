﻿Imports System.Collections.Generic
Imports ingNovar.Utilidades2
Imports System.Data
Imports Especiales

Partial Class WebForms_SalidasDevolucionesList
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

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_regional, 72, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Bodega, 31, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Productos, 32, New ListItem("Seleccione", 0))

        Dim ListSalidas As List(Of SalidasBrl) = Session("ListSalidasDevoluciones")

        'si no hay una variable de sesión con la lista.
        If ListSalidas Is Nothing Or Request.QueryString.Item("Refrescar") = 1 Then
            ListSalidas = SalidasBrl.CargarPorId_Tipo_Salida(0)  ' Devoluciones 
            Session("ListSalidasDevoluciones") = ListSalidas
        End If

        Rg_Listado.DataSource = Session("ListSalidasDevoluciones")
        Rg_Listado.DataBind()

    End Sub

    Protected Sub Rg_Listado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rg_Listado.SelectedIndexChanged
        Dim item As Telerik.Web.UI.GridDataItem = Me.Rg_Listado.SelectedItems.Item(Rg_Listado.SelectedIndexes.Item(0))
        Response.Redirect("SalidasDevoluciones.aspx?Editar=1&ID=" & item("id").Text)
    End Sub

    Protected Sub Rg_Listado_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Listado.NeedDataSource
        Rg_Listado.DataSource = Session("ListSalidasDevoluciones")
    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_nuevo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_nuevo.Click
        Response.Redirect("../webforms/SalidasDevoluciones.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        Response.Redirect("../webforms/SalidasDevolucionesList.aspx?Refrescar=1")
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
        Dim ListSalidasDevoluciones As New List(Of SalidasBrl)
        Session.Remove("ListSalidasDonaciones")
        ListSalidasDevoluciones = SalidasBrl.CargarPorId_Regional(0)
        Session("ListSalidasDevoluciones") = ListSalidasDevoluciones
        txt_Numero.Text = ""
        ddl_regional.SelectedValue = 0
        ddl_Bodega.SelectedValue = 0
        ddl_Productos.SelectedValue = 0
        rdpFechaInicial.SelectedDate = Nothing
        rdpFechaFinal.SelectedDate = Nothing
        Rg_Listado.DataSource = Session("ListSalidasDevoluciones")
        Rg_Listado.DataBind()
    End Sub

    Protected Sub btn_Procesar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_Procesar.Click
        Dim wfechainicio As String = ""
        Dim wfechafinal As String = ""
        If rdpFechaInicial.SelectedDate.ToString.Trim <> "" Then
            wfechainicio = ajustarFecha10digitos(rdpFechaInicial.SelectedDate)
        End If
        If rdpFechaFinal.SelectedDate.ToString.Trim <> "" Then
            wfechafinal = ajustarFecha10digitos(rdpFechaFinal.SelectedDate)
        End If

        Dim ListSalidasDevoluciones As New List(Of SalidasBrl)
        ListSalidasDevoluciones = SalidasBrl.CargarPorBusqueda(ddl_regional.SelectedValue, ddl_Bodega.SelectedValue, ddl_Productos.SelectedValue, wfechainicio, wfechafinal, txt_Numero.Text, 3273)
        Session("ListSalidasDevoluciones") = ListSalidasDevoluciones
        Rg_Listado.DataSource = Session("ListSalidasDevoluciones")
        Rg_Listado.DataBind()
    End Sub
End Class
