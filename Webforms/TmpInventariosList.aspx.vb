Imports System.Collections.Generic
Imports ingNovar.Utilidades2
Imports System.Data
Imports Especiales

Partial Class WebForms_TmpInventariosList
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

        Dim ListInventarios As List(Of Tmp_InventariosBrl) = Session("ListInventarios")

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_regional, 72, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_bodega, 31, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_TipoSalida, 75, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_tipoentrada, 8, New ListItem("Seleccione", 0))

        'si no hay una variable de sesión con la lista.
        If ListInventarios Is Nothing Or Request.QueryString.Item("Refrescar") = 1 Then
            ListInventarios = Tmp_InventariosBrl.CargarPorId_Usuario(lblidUsuario.Text)
            Session("ListInventarios") = ListInventarios
        End If

        Rg_Listado.DataSource = Session("ListInventarios")
        Rg_Listado.DataBind()

    End Sub

    Protected Sub Rg_Listado_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Listado.NeedDataSource
        Rg_Listado.DataSource = Session("ListInventarios")
    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        Response.Redirect("../webforms/TmpInventariosList.aspx?Refrescar=1")
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
        Dim ListInventarios As New List(Of Tmp_InventariosBrl)
        Session.Remove("ListSalud")
        ListInventarios = Tmp_InventariosBrl.CargarPorId_Bodega(0)
        Session("ListInventarios") = ListInventarios
        ddl_regional.SelectedValue = 0
        ddl_tipoentrada.SelectedValue = 0
        ddl_bodega.SelectedValue = 0
        ddl_TipoSalida.SelectedValue = 0
        rdpFechaInicial.SelectedDate = Nothing
        rdpFechaFinal.SelectedDate = Nothing
        Rg_Listado.DataSource = Session("ListInventarios")
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

        ' Codigo donde se Prepara el reporte de excel
        Dim ListInventarios As New List(Of Tmp_InventariosBrl)
        Tmp_InventariosDAL.CargarInventarios(CType(Master.FindControl("lblidusuario"), Label).Text, ddl_regional.SelectedValue, ddl_bodega.SelectedValue, wfechainicio, wfechafinal, ddl_tipoentrada.SelectedValue, ddl_TipoSalida.SelectedValue)

        Session.Remove("ListInventarios")
        ListInventarios = Tmp_InventariosBrl.CargarPorId_Usuario(CType(Master.FindControl("lblidusuario"), Label).Text)

        Session("ListInventarios") = ListInventarios
        Rg_Listado.DataSource = Session("ListInventarios")
        Rg_Listado.DataBind()

    End Sub

    Protected Sub rdb_vista_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdb_vista.SelectedIndexChanged
        Rg_Listado.Columns(5).Visible = True ' Antes
        Rg_Listado.Columns(6).Visible = True ' Inventario Inicial
        Rg_Listado.Columns(7).Visible = True ' Compras
        Rg_Listado.Columns(8).Visible = True ' Devoluciones
        Rg_Listado.Columns(9).Visible = True ' Donaciones
        Rg_Listado.Columns(10).Visible = True ' Traslados
        Rg_Listado.Columns(11).Visible = True ' Ajustes Entradas Aprobadas
        Rg_Listado.Columns(12).Visible = True ' Ajustes Entradas No Aprobadas
        Rg_Listado.Columns(13).Visible = True ' Entradas Devoluciones

        Rg_Listado.Columns(14).Visible = True ' Ingresos total
        Rg_Listado.Columns(15).Visible = True ' Entregas Automáticas
        Rg_Listado.Columns(16).Visible = True ' Entregas Manuales
        Rg_Listado.Columns(17).Visible = True ' Devolucion Proveedor
        Rg_Listado.Columns(18).Visible = True ' Traslados
        Rg_Listado.Columns(19).Visible = True ' Ajustes sin Aprobar
        Rg_Listado.Columns(20).Visible = True ' Ajustes Aprobados
        Rg_Listado.Columns(21).Visible = True ' salidas Donaciones
        Rg_Listado.Columns(22).Visible = True ' Salidas Total
        Rg_Listado.Columns(23).Visible = True ' Gran Total en Inventario

        Select Case rdb_vista.SelectedValue
            Case Is = 1
                Rg_Listado.Columns(6).Visible = False
                Rg_Listado.Columns(7).Visible = False
                Rg_Listado.Columns(8).Visible = False
                Rg_Listado.Columns(9).Visible = False
                Rg_Listado.Columns(10).Visible = False
                Rg_Listado.Columns(11).Visible = False
                Rg_Listado.Columns(12).Visible = False
                Rg_Listado.Columns(13).Visible = False
                Rg_Listado.Columns(15).Visible = False
                Rg_Listado.Columns(16).Visible = False
                Rg_Listado.Columns(17).Visible = False
                Rg_Listado.Columns(18).Visible = False
                Rg_Listado.Columns(19).Visible = False
                Rg_Listado.Columns(20).Visible = False
                Rg_Listado.Columns(21).Visible = False
            Case Is = 2

                Rg_Listado.Columns(15).Visible = False
                Rg_Listado.Columns(16).Visible = False
                Rg_Listado.Columns(17).Visible = False
                Rg_Listado.Columns(18).Visible = False
                Rg_Listado.Columns(19).Visible = False
                Rg_Listado.Columns(20).Visible = False
                Rg_Listado.Columns(21).Visible = False
                Rg_Listado.Columns(22).Visible = False
            Case Is = 3
                Rg_Listado.Columns(6).Visible = False
                Rg_Listado.Columns(7).Visible = False
                Rg_Listado.Columns(8).Visible = False
                Rg_Listado.Columns(9).Visible = False
                Rg_Listado.Columns(10).Visible = False
                Rg_Listado.Columns(11).Visible = False
                Rg_Listado.Columns(12).Visible = False
                Rg_Listado.Columns(13).Visible = False
                Rg_Listado.Columns(14).Visible = False
        End Select
        Rg_Listado.Rebind()

    End Sub
End Class
