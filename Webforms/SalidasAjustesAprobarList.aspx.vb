Imports System.Collections.Generic
Imports ingNovar.Utilidades2
Imports System.Data

Partial Class WebForms_SalidasAjustesAprobarList
    Inherits System.Web.UI.Page
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Me.IsPostBack Then Exit Sub
        If Session("IdUsuario") Is Nothing Then
            Session.RemoveAll()
            Response.Redirect("../login.aspx")
            Exit Sub
        End If
        lblidUsuario.Text = Session("IdUsuario")
        Lblnombreusuario.Text = Session("NombreUsuario")

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_bodegas, 31, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_regional, 72, New ListItem("Seleccione", 0))

        Dim ListSalidas As List(Of SalidasBrl) = Session("ListSalidasAjustesAprobar")

        'si no hay una variable de sesión con la lista.
        If ListSalidas Is Nothing Or Request.QueryString.Item("Refrescar") = 1 Then
            ListSalidas = SalidasBrl.CargarPorId_Regional(0) ' carga vacio
            Session("ListSalidasAjustesAprobar") = ListSalidas
        End If

        Me.dgListado.DataSource = Session("ListSalidasAjustesAprobar")
        Me.dgListado.DataBind()

    End Sub

    Public Sub subEditar(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

        Dim lblId As Label
        lblId = e.Item.FindControl("lblId")
        Response.Redirect("SalidasAjustes.aspx?Editar=0&Refrescar=1&ID=" & lblId.Text & "&TA=" + Request.QueryString.Item("TA"))

    End Sub

    Public Sub subCommandItem(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

        Select Case e.CommandName
            Case "Edit"
                subEditar(sender, e)
        End Select

    End Sub

    Public Sub CambioPagina(ByVal sender As Object, ByVal e As DataGridPageChangedEventArgs) Handles dgListado.PageIndexChanged
        dgListado.CurrentPageIndex = e.NewPageIndex
        dgListado.SelectedIndex = -1
        dgListado.DataSource = Session("ListSalidasAjustesAprobar")
        dgListado.DataBind()
    End Sub

    Private Sub lnkBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkBuscar.Click
        If pnl_buscar.Visible = True Then
            lnkBuscar.Text = "Buscar >>"
            pnl_buscar.Visible = False
        Else
            lnkBuscar.Text = "Buscar <<"
            pnl_buscar.Visible = True
        End If
    End Sub

    Protected Sub dgListado_SortCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridSortCommandEventArgs) Handles dgListado.SortCommand
        Dim ListSalidas As List(Of SalidasBrl)
        Dim orden As SortList.SortOrder
        orden = ViewState("Orden" & e.SortExpression)

        If orden = SortList.SortOrder.Asc Then
            orden = SortList.SortOrder.Desc
        Else
            orden = SortList.SortOrder.Asc
        End If

        ViewState("Orden" & e.SortExpression) = orden
        ListSalidas = SalidasBrl.CargarPorId_Tipo_Salida(3568) ' Ajustes de inventario
        SortList.SortByProperty(ListSalidas, e.SortExpression, orden)
        Session("ListSalidasAjustesAprobar") = ListSalidas

        Me.dgListado.DataSource = Session("ListSalidasAjustes")
        Me.dgListado.DataBind()

    End Sub

    Protected Sub ImbEducacion_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImbEducacion.Click
        Session.Remove("ListSalidasAjustesAprobar")
        Dim ListSalidas As New List(Of SalidasBrl)
        Select Case Request.QueryString.Item("TA")
            Case Is = 1
                ListSalidas = SalidasBrl.CargarPorAprobacion_Logistica_Oficina(ddl_bodegas.SelectedValue, ddl_regional.SelectedValue, txt_numero.Text, txt_Fecha_Inicial.Text, Txt_Fecha_Final.Text)
            Case Is = 2
                ListSalidas = SalidasBrl.CargarPorAprobacion_Finanzas_Oficina(ddl_bodegas.SelectedValue, ddl_regional.SelectedValue, txt_numero.Text, txt_Fecha_Inicial.Text, Txt_Fecha_Final.Text)
            Case Is = 3
                ListSalidas = SalidasBrl.CargarPorAprobacion_Coordinador_Oficina(ddl_bodegas.SelectedValue, ddl_regional.SelectedValue, txt_numero.Text, txt_Fecha_Inicial.Text, Txt_Fecha_Final.Text)
            Case Is = 4
                ListSalidas = SalidasBrl.CargarPorAprobacion_Coordinador_Logistica(ddl_bodegas.SelectedValue, ddl_regional.SelectedValue, txt_numero.Text, txt_Fecha_Inicial.Text, Txt_Fecha_Final.Text)
            Case Is = 5
                ListSalidas = SalidasBrl.CargarPorAprobacion_Director_Financiero(ddl_bodegas.SelectedValue, ddl_regional.SelectedValue, txt_numero.Text, txt_Fecha_Inicial.Text, Txt_Fecha_Final.Text)
            Case Is = 6
                ListSalidas = SalidasBrl.CargarPorAprobacion_Director_Pais(ddl_bodegas.SelectedValue, ddl_regional.SelectedValue, txt_numero.Text, txt_Fecha_Inicial.Text, Txt_Fecha_Final.Text)
        End Select
        Session("ListSalidasAjustesAprobar") = ListSalidas
        dgListado.DataSource = Session("ListSalidasAjustesAprobar")
        dgListado.DataBind()

    End Sub

    Protected Sub btn_AprobarOrdenes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_AprobarOrdenes.Click
        For Each fila As DataGridItem In dgListado.Items
            Dim chk_aprobar As CheckBox
            Dim lblid As Label
            chk_aprobar = fila.FindControl("chk_aprobar")
            If chk_aprobar.Checked Then
                Try
                    lblid = fila.FindControl("lblid")
                    Dim objsalida As SalidasBrl = SalidasBrl.CargarPorID(lblid.Text)
                    Select Case Request.QueryString.Item("TA")
                        Case Is = 1
                            objsalida.Salidas_Aprobaciones.Item(0).Aprobacion_Logistica_Oficina = True
                            objsalida.Salidas_Aprobaciones.Item(0).Fecha_ALO = Now
                        Case Is = 2
                            objsalida.Salidas_Aprobaciones.Item(0).Aprobacion_Finanzas_Oficina = True
                            objsalida.Salidas_Aprobaciones.Item(0).Fecha_AFO = Now
                        Case Is = 3
                            objsalida.Salidas_Aprobaciones.Item(0).Aprobacion_Coordinador_Oficina = True
                            objsalida.Salidas_Aprobaciones.Item(0).Fecha_ACO = Now
                        Case Is = 4
                            objsalida.Salidas_Aprobaciones.Item(0).Aprobacion_Coordinador_Logistica = True
                            objsalida.Salidas_Aprobaciones.Item(0).Fecha_ACL = Now
                        Case Is = 5
                            objsalida.Salidas_Aprobaciones.Item(0).Aprobacion_Director_Financiero = True
                            objsalida.Salidas_Aprobaciones.Item(0).Fecha_ADF = Now
                        Case Is = 6
                            objsalida.Salidas_Aprobaciones.Item(0).Aprobacion_Director_Pais = True
                            objsalida.Salidas_Aprobaciones.Item(0).Fecha_ADP = Now
                    End Select
                    objsalida.Guardar()
                Catch ex As Exception
                End Try
            End If
        Next
        ImbEducacion_Click(Nothing, Nothing)
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim ListSalidas As New List(Of SalidasBrl)
        Select Case Request.QueryString.Item("TA")
            Case Is = 1
                ListSalidas = SalidasBrl.CargarPorAprobacion_Logistica_Oficina(0, 0, "", "", "")
            Case Is = 2
                ListSalidas = SalidasBrl.CargarPorAprobacion_Finanzas_Oficina(0, 0, "", "", "")
            Case Is = 3
                ListSalidas = SalidasBrl.CargarPorAprobacion_Coordinador_Oficina(0, 0, "", "", "")
            Case Is = 4
                ListSalidas = SalidasBrl.CargarPorAprobacion_Coordinador_Logistica(0, 0, "", "", "")
            Case Is = 5
                ListSalidas = SalidasBrl.CargarPorAprobacion_Director_Financiero(0, 0, "", "", "")
            Case Is = 6
                ListSalidas = SalidasBrl.CargarPorAprobacion_Director_Pais(0, 0, "", "", "")
        End Select
        Session("ListSalidasAjustesAprobar") = ListSalidas
        dgListado.DataSource = Session("ListSalidasAjustesAprobar")
        dgListado.DataBind()
    End Sub
End Class
