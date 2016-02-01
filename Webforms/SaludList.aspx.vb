Imports System.Collections.Generic
Imports ingNovar.Utilidades2
Imports System.Data
Imports Especiales

Partial Class WebForms_SaludList
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


        Dim ListSalud As List(Of PersonasBrl) = Session("ListSalud")

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_regional, 72, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(Lst_grupos, 26, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_TipoDeclaracion, 76, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_LugarEntrega, 73, New ListItem("Seleccione", 0))
        BindHelper.ProgramacionUIL.BindToListControl(ddl_programas, New ListItem("Seleccione", 0))

        'si no hay una variable de sesión con la lista.
        If ListSalud Is Nothing Or Request.QueryString.Item("Refrescar") = 1 Then
            ListSalud = PersonasBrl.CargarPorId_Declaracion(0) ' Cargar Vacio
            Session("ListSalud") = ListSalud
        End If

        Rg_Listado.DataSource = Session("ListSalud")
        Rg_Listado.DataBind()

    End Sub

    Protected Sub Rg_Listado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rg_Listado.SelectedIndexChanged
        Dim item As Telerik.Web.UI.GridDataItem = Me.Rg_Listado.SelectedItems.Item(Rg_Listado.SelectedIndexes.Item(0))
        Response.Redirect("Salud.aspx?Editar=1&ID=" & item("id").Text)
    End Sub

    Protected Sub Rg_Listado_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Listado.NeedDataSource
        Rg_Listado.DataSource = Session("ListSalud")
    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_nuevo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_nuevo.Click
        Response.Redirect("../webforms/Salud.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        Response.Redirect("../webforms/SaludList.aspx?Refrescar=1")
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
        Dim ListSalud As New List(Of PersonasBrl)
        Session.Remove("ListSalud")
        ListSalud = PersonasBrl.CargarPorId_Genero(0)
        Session("ListSalud") = ListSalud
        txt_identificacion.Text = ""
        ddl_regional.SelectedValue = 0
        ddl_TipoDeclaracion.SelectedValue = 0
        ddl_regional.SelectedValue = 0
        ddl_programas.SelectedValue = 0
        ddl_LugarEntrega.SelectedValue = 0
        rdpFechaInicial.SelectedDate = Nothing
        rdpFechaFinal.SelectedDate = Nothing
        Rg_Listado.DataSource = Session("ListSalud")
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

        Session.Remove("ListSalud")
        Dim ListSalud As New List(Of PersonasBrl)

        ListSalud = PersonasBrl.CargarPorSaludEdadNino(Grupos, txt_identificacion.Text, txt_nombre.Text, ddl_regional.SelectedValue, wfechainicio, wfechafinal, ddl_TipoDeclaracion.SelectedValue, ddl_LugarEntrega.SelectedValue, ddl_programas.SelectedValue)

        Session("ListSalud") = ListSalud
        Rg_Listado.DataSource = Session("ListSalud")
        Rg_Listado.DataBind()

        ' Codigo donde se Prepara el reporte de excel
        Dim ListSaludExcel As New List(Of Tmp_SaludBrl)
        Tmp_SaludDAL.CargarSalud(CType(Master.FindControl("lblidusuario"), Label).Text, Grupos, txt_identificacion.Text, txt_nombre.Text, ddl_regional.SelectedValue, wfechainicio, wfechafinal, ddl_TipoDeclaracion.SelectedValue, ddl_LugarEntrega.SelectedValue, ddl_programas.SelectedValue)
        ListSaludExcel = Tmp_SaludBrl.CargarPorIdUsuario(CType(Master.FindControl("lblidusuario"), Label).Text)
        Session("ListSaludExcel") = ListSaludExcel

    End Sub

    Public Function Grupos() As String
        Dim wcadena As String = "("

        For Each item As ListItem In Me.Lst_grupos.Items
            If item.Selected Then
                If item.Value <> "0" Then
                    If wcadena <> "(" Then wcadena = wcadena + ","
                    wcadena = wcadena + item.Value.ToString
                End If
            End If
        Next
        wcadena = wcadena + ")"
        If wcadena = "()" Then wcadena = ""
        Return wcadena
    End Function

    Protected Sub Rg_Listado_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles Rg_Listado.ItemDataBound
        If e.Item.ItemType = ListItemType.AlternatingItem Or e.Item.ItemType = ListItemType.Item Then
            Dim wmesnac, wanonac, wdianac, wmesact, wanoact, wdiaact As Integer
            Dim wmeses As Integer = 0
            Dim wanos As Integer = 0
            Dim lbl_edad As New Label
            Dim lbl_meses As New Label
            Dim lbl_Fecha_Valoracion As New Label
            Try
                Dim lbl_Fecha_Nacimiento As New Label
                lbl_Fecha_Nacimiento = e.Item.FindControl("lbl_Fecha_Nacimiento")
                lbl_Fecha_Valoracion = e.Item.FindControl("lbl_Fecha_Valoracion")
                If lbl_Fecha_Nacimiento.Text.Trim = "" Then
                    lbl_Fecha_Nacimiento.Text = lbl_Fecha_Valoracion.Text
                End If
                If lbl_Fecha_Nacimiento IsNot Nothing Then
                    lbl_edad = e.Item.FindControl("lbl_edad")
                    lbl_meses = e.Item.FindControl("lbl_meses")

                    ' Calculando la edad actual despues del cambio de Fecha actual de valoracion

                    wanonac = Mid(lbl_Fecha_Nacimiento.Text, 7, 4)
                    wmesnac = Mid(lbl_Fecha_Nacimiento.Text, 4, 2)
                    wdianac = Mid(lbl_Fecha_Nacimiento.Text, 1, 2)
                    wanoact = Mid(lbl_Fecha_Valoracion.Text, 7, 4)
                    wmesact = Mid(lbl_Fecha_Valoracion.Text, 4, 2)
                    wdiaact = Mid(lbl_Fecha_Valoracion.Text, 1, 2)


                    wanos = wanoact - wanonac
                    If wmesact > wmesnac Then
                        wmeses = wmesact - wmesnac
                        If wdiaact < wdianac Then
                            wmeses = wmeses - 1
                        End If
                    End If
                    If wmesact = wmesnac Then
                        If wdiaact >= wdianac Then
                            wmeses = 0
                        End If
                        If wdiaact < wdianac Then
                            wanos = wanos - 1
                            wmeses = 11
                        End If
                    End If

                    If wmesact < wmesnac Then
                        wmeses = 12 + wmesact - wmesnac
                        wanos = wanos - 1
                        If wdiaact < wdianac Then
                            wmeses = wmeses - 1
                        End If
                    End If

                    lbl_edad.Text = Str(wanos)
                    lbl_meses.Text = Str(wmeses)
                End If
            Catch ex As Exception
            End Try

        End If
    End Sub
End Class
