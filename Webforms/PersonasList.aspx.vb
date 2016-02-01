Imports System.Collections.Generic
Imports ingNovar.Utilidades2
Imports System.Data
Imports Especiales

Partial Class WebForms_PersonasList
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
            ddl_regional.Enabled = objper_usuario.Pvertodo

        End If

        ' Definiendo el dato de la regional
        ddl_Regional.SelectedValue = SeguridadUsuarios.Usuarios.RegionalUsuario(CType(Session("IdUsuario"), Integer))

    End Sub

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


        Dim ListPersonasDeclaracion As List(Of PersonasBrl) = Session("ListPersonasDeclaracion")


        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_regional, 72, New ListItem("Seleccione", 0))
        ddl_regional_SelectedIndexChanged(Nothing, Nothing)

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Fuente, 6, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_tipodeclarante, 76, New ListItem("Seleccione", 0))

        'si no hay una variable de sesión con la lista.
        If ListPersonasDeclaracion Is Nothing Or Request.QueryString.Item("Refrescar") = 1 Then
            ListPersonasDeclaracion = PersonasBrl.CargarPorId_Causas_Discapacidad(0)
            Session("ListPersonasDeclaracion") = ListPersonasDeclaracion
        End If

        Rg_Listado.DataSource = Session("ListPersonasDeclaracion")
        Rg_Listado.DataBind()

    End Sub

    Protected Sub ddl_regional_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_regional.SelectedIndexChanged
        If ddl_regional.SelectedValue > 0 Then
            BindHelper.SubTablasUIL.BindToListControlPorId_TablaPadre(ddl_LugarEntrega, 73, ddl_regional.SelectedValue, New ListItem("Seleccione", 0))
        Else
            BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_LugarEntrega, 73, New ListItem("Seleccione", 0))
        End If
        ddl_LugarEntrega_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Protected Sub ddl_LugarEntrega_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_LugarEntrega.SelectedIndexChanged
        If ddl_LugarEntrega.SelectedValue > 0 Then
            BindHelper.SubTablasUIL.BindToListControlPorId_TablaPadre(ddl_grupo, 26, ddl_LugarEntrega.SelectedValue, New ListItem("Seleccione", 0))
        Else
            BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_grupo, 0, New ListItem("Seleccione", 0))
        End If
    End Sub

    Protected Sub Rg_Listado_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Listado.NeedDataSource
        Rg_Listado.DataSource = Session("ListPersonasDeclaracion")
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
        Dim ListPersonasDeclaracion As New List(Of PersonasBrl)
        Session.Remove("ListPersonasDeclaracion")
        ListPersonasDeclaracion = PersonasBrl.CargarPorId_Genero(0)
        Session("ListPersonasDeclaracion") = ListPersonasDeclaracion
        txt_identificacion.Text = ""
        txt_nombre.Text = ""
        ddl_regional.SelectedValue = SeguridadUsuarios.Usuarios.RegionalUsuario(CType(Session("IdUsuario"), Integer))
        ddl_regional_SelectedIndexChanged(Nothing, Nothing)
        ddl_LugarEntrega_SelectedIndexChanged(Nothing, Nothing)

        ddl_fuente.SelectedValue = 0
        ddl_tipodeclarante.SelectedValue = 0
        rdb_Horario.ClearSelection()
        rdpFechaInicial_desplazamiento.DbSelectedDate = Nothing
        rdpFechaFinal_Desplazamiento.DbSelectedDate = Nothing
        rdpFechaInicial_Declaracion.DbSelectedDate = Nothing
        rdpFechaFinal_Declaracion.DbSelectedDate = Nothing
        rdpFechaInicial_Entrega.DbSelectedDate = Nothing
        rdpFechaFinal_Entrega.DbSelectedDate = Nothing

        Rg_Listado.DataSource = Session("ListPersonasDeclaracion")
        Rg_Listado.DataBind()
    End Sub

    Protected Sub btn_Procesar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_Procesar.Click, btn_actualizar.Click
        Dim whorario As String = ""

        Session.Remove("ListPersonasDeclaracion")
        Dim ListPersonasDeclaracion As New List(Of PersonasBrl)
        Select Case rdb_Horario.SelectedValue
            Case "TO"
                whorario = ""
            Case "AM", "PM", "TD"
                whorario = rdb_Horario.SelectedValue
            Case Else
                whorario = ""
        End Select

        Dim wfechainicio_desplazamiento As String = ""
        Dim wfechafinal_desplazamiento As String = ""
        If rdpFechaInicial_desplazamiento.SelectedDate.ToString.Trim <> "" Then
            wfechainicio_desplazamiento = ajustarFecha10digitos(rdpFechaInicial_desplazamiento.SelectedDate)
        End If
        If rdpFechaFinal_Desplazamiento.SelectedDate.ToString.Trim <> "" Then
            wfechafinal_desplazamiento = ajustarFecha10digitos(rdpFechaFinal_Desplazamiento.SelectedDate)
        End If

        Dim wfechainicio_Entrega As String = ""
        Dim wfechafinal_Entrega As String = ""
        If rdpFechaInicial_Entrega.SelectedDate.ToString.Trim <> "" Then
            wfechainicio_Entrega = ajustarFecha10digitos(rdpFechaInicial_Entrega.SelectedDate)
        End If
        If rdpFechaFinal_Entrega.SelectedDate.ToString.Trim <> "" Then
            wfechafinal_Entrega = ajustarFecha10digitos(rdpFechaFinal_Entrega.SelectedDate)
        End If

        Dim wfechainicio_Declaracion As String = ""
        Dim wfechafinal_Declaracion As String = ""
        If rdpFechaInicial_Declaracion.SelectedDate.ToString.Trim <> "" Then
            wfechainicio_Declaracion = ajustarFecha10digitos(rdpFechaInicial_Declaracion.SelectedDate)
        End If
        If rdpFechaFinal_Declaracion.SelectedDate.ToString.Trim <> "" Then
            wfechafinal_Declaracion = ajustarFecha10digitos(rdpFechaFinal_Declaracion.SelectedDate)
        End If


        ListPersonasDeclaracion = PersonasBrl.CargarBusqueda(ddl_grupo.SelectedValue, ddl_LugarEntrega.SelectedValue, whorario, Me.ddl_tipodeclarante.SelectedValue, Me.ddl_regional.SelectedValue, wfechainicio_Declaracion, wfechafinal_Declaracion, wfechainicio_desplazamiento, wfechafinal_desplazamiento, wfechainicio_Entrega, _
              wfechafinal_Entrega, txt_identificacion.Text.Trim, txt_nombre.Text.Trim, ddl_Fuente.SelectedValue)
        Session("ListPersonasDeclaracion") = ListPersonasDeclaracion

        Rg_Listado.DataSource = Session("ListPersonasDeclaracion")
        Rg_Listado.DataBind()

        btn_buscar_Click(Nothing, Nothing)

    End Sub

    Protected Sub Rg_Listado_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles Rg_Listado.SelectedIndexChanged
        Dim item As Telerik.Web.UI.GridDataItem = Me.Rg_Listado.SelectedItems.Item(Rg_Listado.SelectedIndexes.Item(0))
        Response.Redirect("Personas.aspx?ID=" & item("id").Text)
    End Sub
End Class
