Imports System.Collections.Generic
Imports ingNovar.Utilidades2
Imports System.Data
Imports Telerik.Web.UI
Imports Especiales

Partial Class WebForms_DeclaracionList
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

            'Rg_Listado.Columns(11).Visible = objper_perfil.Peliminar
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
            ddl_regional.Enabled = objper_usuario.Pvertodo

            'Rg_Listado.Columns(11).Visible = objper_usuario.Peliminar
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
        'BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_grupo, 26, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Fuente, 6, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_tipodeclarante, 76, New ListItem("Seleccione", 0))
        'BindHelper.ProgramacionUIL.BindToListControl(ddl_Programa, New ListItem("Seleccione", 0))

        ddl_regional_SelectedIndexChanged(Nothing, Nothing)

        Dim ListDeclaracion As List(Of DeclaracionBrl) = Session("ListDeclaracion")

        'si no hay una variable de sesión con la lista.
        If ListDeclaracion Is Nothing Or Request.QueryString.Item("Refrescar") = 1 Then
            ListDeclaracion = DeclaracionBrl.CargarPorId_Regional(0)
            Session("ListDeclaracion") = ListDeclaracion
        End If

        Rg_Listado.DataSource = Session("ListDeclaracion")
        Rg_Listado.DataBind()

    End Sub

    Public Sub subEncuesta1(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Dim lblId As Label
        lblId = e.Item.FindControl("lblId")
        Response.Redirect("PrimeraEncuesta.aspx?Editar=1&ID=" & lblId.Text)
    End Sub

    Public Sub subEncuesta2(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Dim lblId As Label
        lblId = e.Item.FindControl("lblId")
        Response.Redirect("SegundaEncuesta.aspx?Editar=1&ID=" & lblId.Text)
    End Sub

    Public Sub SubEncVulnerable(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Dim lblId As Label
        lblId = e.Item.FindControl("lblId")
        Response.Redirect("EncuestaVulnerables.aspx?Editar=1&ID=" & lblId.Text)
    End Sub

    Public Sub subCommandItem(ByVal sender As Object, ByVal e As GridCommandEventArgs)

        Select Case e.CommandName
            Case "Encuesta1"
                subEncuesta1(sender, e)
            Case "Encuesta2"
                subEncuesta2(sender, e)
            Case "EncuestaVul"
                SubEncVulnerable(sender, e)
        End Select

    End Sub

    Protected Sub Rg_Listado_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Listado.NeedDataSource
        Rg_Listado.DataSource = Session("ListDeclaracion")
    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        Response.Redirect("../webforms/DeclaracionList.aspx?Refrescar=1")
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

        ddl_regional.SelectedValue = SeguridadUsuarios.Usuarios.RegionalUsuario(CType(Session("IdUsuario"), Integer))
        ddl_regional_SelectedIndexChanged(Nothing, Nothing)
        txt_nombre.Text = ""
        txt_identificacion.Text = ""
        ddl_tipodeclarante.SelectedValue = 0
        rdb_Horario.ClearSelection()
        ddl_Fuente.SelectedValue = 0

        rdpfechaFinalDeclaracion.SelectedDate = Nothing
        rdpfechaInicialDeclaracion.SelectedDate = Nothing
        rdpfechaFinalEntrega.SelectedDate = Nothing
        rdpfechaInicialEntrega.SelectedDate = Nothing
        rdpfechaInicialRadicacion.SelectedDate = Nothing
        rdpfechaFinalRadicacion.SelectedDate = Nothing

        Dim ListDeclaracion As List(Of DeclaracionBrl)
        ListDeclaracion = DeclaracionBrl.CargarPorId_Regional(0)
        Session("ListDeclaracion") = ListDeclaracion
        Rg_Listado.DataSource = Session("ListDeclaracion")
        Rg_Listado.DataBind()

    End Sub

    Protected Sub btn_Procesar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_Procesar.Click, btn_actualizar.Click
        Dim whorario As String = ""

        Session.Remove("ListDeclaracion")
        Dim ListDeclaracion As New List(Of DeclaracionBrl)
        Select Case rdb_Horario.SelectedValue
            Case "TO"
                whorario = ""
            Case "AM", "PM", "TD"
                whorario = rdb_Horario.SelectedValue
            Case Else
                whorario = ""
        End Select


        Dim wfechainicioentrega As String = ""
        Dim wfechafinalentrega As String = ""
        If rdpfechaInicialEntrega.SelectedDate.ToString.Trim <> "" Then
            wfechainicioentrega = ajustarFecha10digitos(rdpfechaInicialEntrega.SelectedDate)
        End If
        If rdpfechaFinalEntrega.SelectedDate.ToString.Trim <> "" Then
            wfechafinalentrega = ajustarFecha10digitos(rdpfechaFinalEntrega.SelectedDate)
        End If

        Dim wfechainicioradicacion As String = ""
        Dim wfechafinalradicacion As String = ""
        If rdpfechaInicialRadicacion.SelectedDate.ToString.Trim <> "" Then
            wfechainicioradicacion = ajustarFecha10digitos(rdpfechaInicialRadicacion.SelectedDate)
        End If
        If rdpfechaFinalRadicacion.SelectedDate.ToString.Trim <> "" Then
            wfechafinalradicacion = ajustarFecha10digitos(rdpfechaFinalRadicacion.SelectedDate)
        End If

        Dim wfechainiciodeclaracion As String = ""
        Dim wfechafinaldeclaracion As String = ""
        If rdpfechaInicialDeclaracion.SelectedDate.ToString.Trim <> "" Then
            wfechainiciodeclaracion = ajustarFecha10digitos(rdpfechaInicialDeclaracion.SelectedDate)
        End If
        If rdpfechaFinalDeclaracion.SelectedDate.ToString.Trim <> "" Then
            wfechafinaldeclaracion = ajustarFecha10digitos(rdpfechaFinalDeclaracion.SelectedDate)
        End If

        ListDeclaracion = DeclaracionBrl.CargarBusquedaDeclaraciones(ddl_Programa.SelectedValue, ddl_grupo.SelectedValue, txt_identificacion.Text.Trim, txt_nombre.Text.Trim, ddl_regional.SelectedValue, wfechainicioradicacion, wfechafinalradicacion, wfechainicioentrega, wfechafinalentrega, ddl_Fuente.SelectedValue, wfechainiciodeclaracion, wfechafinaldeclaracion, whorario, ddl_tipodeclarante.SelectedValue, ddl_LugarFuente.SelectedValue, "T")
        Session("ListDeclaracion") = ListDeclaracion
        Rg_Listado.DataSource = Session("ListDeclaracion")
        Rg_Listado.DataBind()
    End Sub

    Protected Sub ddl_regional_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_regional.SelectedIndexChanged
        If ddl_regional.SelectedValue > 0 Then
            BindHelper.SubTablasUIL.BindToListControlPorId_TablaPadre(ddl_LugarFuente, 73, ddl_regional.SelectedValue, New ListItem("Seleccione", 0))
            BindHelper.ProgramacionUIL.BindToListControlPorId_Regional(ddl_Programa, ddl_regional.SelectedValue, New ListItem("Seleccione", 0))
        Else
            BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_LugarFuente, 73, New ListItem("Seleccione", 0))
            BindHelper.ProgramacionUIL.BindToListControl(ddl_Programa, New ListItem("Seleccione", 0))
        End If
        ddl_LugarFuente_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Protected Sub ddl_LugarFuente_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_LugarFuente.SelectedIndexChanged
        If ddl_LugarFuente.SelectedValue > 0 Then
            BindHelper.SubTablasUIL.BindToListControlPorId_TablaPadre(ddl_grupo, 26, ddl_LugarFuente.SelectedValue, New ListItem("Seleccione", 0))
            BindHelper.ProgramacionUIL.BindToListControlPorId_LugarEntrega(ddl_Programa, ddl_LugarFuente.SelectedValue, New ListItem("Seleccione", 0))
        Else
            BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_grupo, 0, New ListItem("Seleccione", 0))
            BindHelper.ProgramacionUIL.BindToListControlPorId_Regional(ddl_Programa, ddl_regional.SelectedValue, New ListItem("Seleccione", 0))
        End If
        ddl_grupo.SelectedValue = 0
    End Sub
End Class
