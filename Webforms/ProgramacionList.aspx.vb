Imports System.Collections.Generic
Imports ingNovar.Utilidades2
Imports System.Data
Imports Telerik.Web.UI
Imports Especiales

Partial Class WebForms_ProgramacionList
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
        If objper_perfil IsNot Nothing Then
            If objper_perfil.Pver = False Or objper_perfil.Pconsultar = False Then
                Response.Redirect(strPaginaError)
                Exit Sub
            End If

            ' asignando los permisos

            btn_buscar.Enabled = objper_perfil.Pconsultar
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToCsvButton = objper_perfil.Pexportarcsv
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToExcelButton = objper_perfil.Pexportarexcel
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToPdfButton = objper_perfil.Pexportarpdf
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToWordButton = objper_perfil.Pexportarword
            ddl_Regional.Enabled = objper_perfil.Pvertodo
        End If

        If objper_usuario IsNot Nothing Then
            If objper_usuario.Pver = False Or objper_usuario.Pconsultar = False Then
                Response.Redirect(strPaginaError)
                Exit Sub
            End If

            ' asignando los permisos

            btn_buscar.Enabled = objper_usuario.Pconsultar
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToCsvButton = objper_usuario.Pexportarcsv
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToExcelButton = objper_usuario.Pexportarexcel
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToPdfButton = objper_usuario.Pexportarpdf
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToWordButton = objper_usuario.Pexportarword
            ddl_Regional.Enabled = objper_usuario.Pvertodo
        End If

        ' Definiendo el dato de la regional
        ddl_Regional.SelectedValue = SeguridadUsuarios.Usuarios.RegionalUsuario(CType(Session("IdUsuario"), Integer))

    End Sub

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
        'BindHelper.ProgramacionUIL.BindToListControl(ddl_Programas, New ListItem("Seleccione", 0))
        'BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_LugarFuente, 73, New ListItem("Seleccione", 0))
        ddl_regional_SelectedIndexChanged(Nothing, Nothing)

        Dim ListProgramacion As List(Of ProgramacionBrl) = Session("ListProgramacion")

        'si no hay una variable de sesión con la lista.
        If ListProgramacion Is Nothing Or Request.QueryString.Item("Refrescar") = 1 Then
            ListProgramacion = ProgramacionBrl.CargarPorId_Regional(0)
            Session("ListProgramacion") = ListProgramacion
        End If

        Rg_Listado.DataSource = Session("ListProgramacion")
        Rg_Listado.DataBind()

    End Sub

    Protected Sub Rg_Listado_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Listado.NeedDataSource
        Rg_Listado.DataSource = Session("ListProgramacion")
    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    'Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
    '    Response.Redirect("../webforms/ProgramacionList.aspx?Refrescar=1")
    'End Sub

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
        ddl_regional.SelectedValue = SeguridadUsuarios.Usuarios.RegionalUsuario(CType(Session("IdUsuario"), Integer))
        ddl_regional_SelectedIndexChanged(Nothing, Nothing)
        rdpfechaInicialRadicacion.DbSelectedDate = Nothing
        rdpfechaFinalRadicacion.DbSelectedDate = Nothing
        Rg_Listado.DataSource = Session("ListProgramacion")
        Rg_Listado.DataBind()
    End Sub

    Protected Sub btn_Procesar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_Procesar.Click, btn_actualizar.Click
        Dim ListProgramacion As New List(Of ProgramacionBrl)

        Dim wfechainicioprogramacion As String = ""
        Dim wfechafinalprogramacion As String = ""
        If rdpfechaInicialRadicacion.SelectedDate.ToString.Trim <> "" Then
            wfechainicioprogramacion = ajustarFecha10digitos(rdpfechaInicialRadicacion.SelectedDate)
        End If
        If rdpfechaFinalRadicacion.SelectedDate.ToString.Trim <> "" Then
            wfechafinalprogramacion = ajustarFecha10digitos(rdpfechaFinalRadicacion.SelectedDate)
        End If

        ListProgramacion = ProgramacionBrl.Cargarbusqueda(ddl_regional.SelectedValue, ddl_LugarFuente.SelectedValue, ddl_Programas.SelectedValue, wfechainicioprogramacion, wfechafinalprogramacion)
        Session("ListProgramacion") = ListProgramacion
        Rg_Listado.DataSource = Session("ListProgramacion")
        Rg_Listado.DataBind()
        btn_buscar_Click(Nothing, Nothing)

    End Sub

    Protected Sub btn_nuevo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_nuevo.Click
        Response.Redirect("Programacion.aspx")
    End Sub

    Protected Sub Rg_Listado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rg_Listado.SelectedIndexChanged
        Dim item As Telerik.Web.UI.GridDataItem = Me.Rg_Listado.SelectedItems.Item(Rg_Listado.SelectedIndexes.Item(0))
        Response.Redirect("Programacion.aspx?Editar=1&ID=" & item("id").Text)
    End Sub

    Protected Sub ddl_regional_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddl_regional.SelectedIndexChanged
        If ddl_regional.SelectedValue > 0 Then
            BindHelper.ProgramacionUIL.BindToListControlPorId_Regional(ddl_Programas, ddl_regional.SelectedValue, New ListItem("Seleccione", 0))
            BindHelper.SubTablasUIL.BindToListControlPorId_TablaPadre(ddl_LugarFuente, 73, ddl_regional.SelectedValue, New ListItem("Seleccione", 0))
        Else
            BindHelper.ProgramacionUIL.BindToListControl(ddl_Programas, New ListItem("Seleccione", 0))
            BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_LugarFuente, 73, New ListItem("Seleccione", 0))
        End If
    End Sub


End Class
