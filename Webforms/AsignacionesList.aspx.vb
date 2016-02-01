Imports System.Collections.Generic
Imports ingNovar.Utilidades2
Imports System.Data
Imports Especiales
Imports Telerik.Web.UI

Partial Class WebForms_AsignacionesList
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
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Fuente, 6, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_tipodeclarante, 76, New ListItem("Seleccione", 0))
        ddl_regional_SelectedIndexChanged(Nothing, Nothing)

        Dim ListDeclaracionAsignacion As List(Of DeclaracionBrl) = Session("ListDeclaracionAsignacion")

        'si no hay una variable de sesión con la lista.
        If ListDeclaracionAsignacion Is Nothing Or Request.QueryString.Item("Refrescar") = 1 Then
            ListDeclaracionAsignacion = DeclaracionBrl.CargarPorId_Regional(0)
            Session("ListDeclaracionAsignacion") = ListDeclaracionAsignacion
        End If

        Rg_Listado.DataSource = Session("ListDeclaracionAsignacion")
        Rg_Listado.DataBind()

    End Sub

    Protected Sub Rg_Listado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rg_Listado.SelectedIndexChanged
        Dim item As Telerik.Web.UI.GridDataItem = Me.Rg_Listado.SelectedItems.Item(Rg_Listado.SelectedIndexes.Item(0))
        Response.Redirect("Asignaciones.aspx?ID=" & item("id").Text)
    End Sub

    Protected Sub Rg_Listado_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Listado.NeedDataSource
        Rg_Listado.DataSource = Session("ListDeclaracionAsignacion")
    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/principal.aspx")
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
        Session.Remove("ListDeclaracionAsignacion")
        Dim listDeclaracionAsignacion As New List(Of DeclaracionBrl)
        listDeclaracionAsignacion = DeclaracionBrl.CargarPorId_Regional(0)
        Session("ListDeclaracionAsignacion") = listDeclaracionAsignacion
        txt_identificacion.Text = ""
        ddl_regional.SelectedValue = SeguridadUsuarios.Usuarios.RegionalUsuario(CType(Session("IdUsuario"), Integer))
        txt_nombre.Text = ""
        rdpfechaFinalProgramacion.DbSelectedDate = Nothing
        rdpfechaInicialProgramacion.DbSelectedDate = Nothing
        rdb_Horario.ClearSelection()
        chb_todosgrupos.Checked = False
        chb_Pendiente.Checked = True
        ddl_tipodeclarante.SelectedValue = 0
        ddl_Fuente.SelectedValue = 0
        ddl_regional_SelectedIndexChanged(Nothing, Nothing)
        Rg_Listado.DataSource = Session("ListDeclaracionAsignacion")
        Rg_Listado.DataBind()

    End Sub

    Protected Sub btn_Procesar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_Procesar.Click, btn_actualizar.Click
        Dim whorario As String = ""
        Session.Remove("ListDeclaracionAsignacion")
        Dim ListDeclaracionAsignacion As New List(Of DeclaracionBrl)
        Select Case rdb_Horario.SelectedValue
            Case "TO"
                whorario = ""
            Case "AM", "PM", "TD"
                whorario = rdb_Horario.SelectedValue
            Case Else
                whorario = ""
        End Select

        Dim wpendiente As Integer = 0
        If chb_Pendiente.Checked Then wpendiente = 1

        Dim wfechainicioprogramacion As String = ""
        Dim wfechafinalprogramacion As String = ""
        If rdpfechaInicialProgramacion.SelectedDate.ToString.Trim <> "" Then
            wfechainicioprogramacion = ajustarFecha10digitos(rdpfechaInicialProgramacion.SelectedDate)
        End If
        If rdpfechaFinalProgramacion.SelectedDate.ToString.Trim <> "" Then
            wfechafinalprogramacion = ajustarFecha10digitos(rdpfechaFinalProgramacion.SelectedDate)
        End If

        ListDeclaracionAsignacion = DeclaracionBrl.CargarbusquedaAsignacion(txt_identificacion.Text.Trim, txt_nombre.Text.Trim, ddl_regional.SelectedValue, wfechainicioprogramacion, wfechafinalprogramacion, ddl_Fuente.SelectedValue, whorario, ddl_tipodeclarante.SelectedValue, ddl_LugarFuente.SelectedValue, ddl_programa.SelectedValue, wpendiente)
        Session("ListDeclaracionAsignacion") = ListDeclaracionAsignacion
        Rg_Listado.DataSource = Session("ListDeclaracionAsignacion")
        Rg_Listado.DataBind()

        pnl_buscar.Visible = False
    End Sub

    Protected Sub ddl_regional_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_regional.SelectedIndexChanged, chb_todosgrupos.CheckedChanged
        If ddl_regional.SelectedValue > 0 Then
            BindHelper.SubTablasUIL.BindToListControlPorId_TablaPadre(ddl_LugarFuente, 73, ddl_regional.SelectedValue, New ListItem("Seleccione", 0))
            If chb_todosgrupos.Checked Then
                BindHelper.ProgramacionUIL.BindToListControlPorId_Regional(ddl_programa, ddl_regional.SelectedValue, New ListItem("Seleccione", 0))
                lbl_Programa.Text = "Todos los Programas"
            Else
                BindHelper.ProgramacionUIL.BindToListControlPorId_RegionalyEstado(ddl_programa, ddl_regional.SelectedValue, 213, New ListItem("Seleccione", 0))
                lbl_Programa.Text = "Programas Libres"
            End If
        End If
    End Sub
End Class
