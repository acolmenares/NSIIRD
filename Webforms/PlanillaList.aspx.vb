Imports System.Collections.Generic
Imports ingNovar.Utilidades2
Imports System.Data
Imports Telerik.Web.UI
Imports Especiales

Partial Class WebForms_PlanillaList
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


        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_regional, 72, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_TipoEntrega, 77, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_LugarFuente, 73, New ListItem("Seleccione", 0))
        BindHelper.ProgramacionUIL.BindToListControl(ddl_Programa, New ListItem("Seleccione", 0))

        Dim ListProgramacion As List(Of ProgramacionBrl) = Session("ListProgramacion")

        'si no hay una variable de sesión con la lista.
        If ListProgramacion Is Nothing Or Request.QueryString.Item("Refrescar") = 1 Then
            ListProgramacion = ProgramacionBrl.CargarPorId_Regional(0)
            Session("ListProgramacion") = ListProgramacion
        End If

        Rg_Programas.DataSource = Session("ListProgramacion")
        Rg_Programas.DataBind()

    End Sub

    Protected Sub Rg_Programas_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Programas.NeedDataSource
        Rg_Programas.DataSource = Session("ListProgramacion")
    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        Response.Redirect("../webforms/PlanillaList.aspx?Refrescar=1")
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
        Session.Remove("ListProgramacion")
        Dim ListProgramacion As New List(Of ProgramacionBrl)
        ListProgramacion = ProgramacionBrl.CargarPorId_Regional(0)
        Session("ListProgramacion") = ListProgramacion
        ddl_regional.SelectedValue = 0
        ddl_regional.SelectedValue = 0
        ddl_TipoEntrega.SelectedValue = 0
        ddl_LugarFuente.SelectedValue = 0
        rdpfechaFinalProgramacion.SelectedDate = Nothing
        rdpfechaInicialProgramacion.SelectedDate = Nothing
        Rg_Programas.DataSource = Session("ListProgramacion")
        Rg_Programas.DataBind()
    End Sub

    Protected Sub btn_Procesar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_Procesar.Click
        Dim whorario As String = ""
        Dim wdeclarante As Integer = 0

        Session.Remove("ListProgramacion")

        Dim wfechainicioProgramacion As String = ""
        Dim wfechafinalProgramacion As String = ""
        If rdpfechaInicialProgramacion.SelectedDate.ToString.Trim <> "" Then
            wfechainicioProgramacion = ajustarFecha10digitos(rdpfechaInicialProgramacion.SelectedDate)
        End If
        If rdpfechaFinalProgramacion.SelectedDate.ToString.Trim <> "" Then
            wfechafinalProgramacion = ajustarFecha10digitos(rdpfechaFinalProgramacion.SelectedDate)
        End If
        Dim ListProgramacion As List(Of ProgramacionBrl)

        ListProgramacion = ProgramacionBrl.Cargarbusqueda(ddl_regional.SelectedValue, ddl_LugarFuente.SelectedValue, ddl_Programa.SelectedValue, wfechainicioProgramacion, wfechafinalProgramacion)
        Session("ListProgramacion") = ListProgramacion
        Rg_Programas.DataSource = Session("ListProgramacion")
        Rg_Programas.DataBind()
    End Sub

    Protected Sub Rg_Programas_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rg_Programas.SelectedIndexChanged
        Dim item As Telerik.Web.UI.GridDataItem = Me.Rg_Programas.SelectedItems.Item(Rg_Programas.SelectedIndexes.Item(0))
        'Response.Redirect("Programacion.aspx?Editar=1&ID=" & item("id").Text)
        Dim ListDeclaracionEstados As List(Of Declaracion_EstadosBrl)
        ListDeclaracionEstados = Declaracion_EstadosBrl.CargarPorId_Programa(item("id").Text)
        Session("ListDeclaracionEstados") = ListDeclaracionEstados
        Session("NombreUsuario") = CType(Master.FindControl("lblNombreusuario"), Label).Text
        Dim ds As DataSet
        ds = Personas_EntregasDAL.CargarPlanilla(item("id").Text)
        Session("IdPrograma") = item("id").Text
        Session("PlanillaPrograma") = ds
        Rg_Listado.DataSource = Session("ListDeclaracionEstados")
        Rg_Listado.DataBind()
    End Sub

    Protected Sub Rg_Listado_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Listado.NeedDataSource
        Rg_Listado.DataSource = Session("ListDeclaracionEstados")
    End Sub
End Class
