Imports System.Collections.Generic
Imports ingNovar.Utilidades2
Imports System.Data
Imports Especiales

Partial Class WebForms_SalidasTrasladosList
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
        ddl_regional_SelectedIndexChanged(Nothing, Nothing)
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Productos, 32, New ListItem("Seleccione", 0))

        Dim ListSalidas As List(Of SalidasBrl) = Session("ListSalidasTraslados")

        'si no hay una variable de sesión con la lista.
        If ListSalidas Is Nothing Or Request.QueryString.Item("Refrescar") = 1 Then
            ListSalidas = SalidasBrl.CargarPorId_Tipo_Salida(0)  ' Traslados 
            Session("ListSalidasTraslados") = ListSalidas
        End If

        Rg_Listado.DataSource = Session("ListSalidasTraslados")
        Rg_Listado.DataBind()

    End Sub

    Protected Sub Rg_Listado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rg_Listado.SelectedIndexChanged
        Dim item As Telerik.Web.UI.GridDataItem = Me.Rg_Listado.SelectedItems.Item(Rg_Listado.SelectedIndexes.Item(0))
        Response.Redirect("SalidasTraslados.aspx?Editar=1&ID=" & item("id").Text)
    End Sub

    Protected Sub Rg_Listado_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Listado.NeedDataSource
        Rg_Listado.DataSource = Session("ListSalidasTraslados")
    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_nuevo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_nuevo.Click
        Response.Redirect("../webforms/SalidasTraslados.aspx")
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
        Dim ListSalidasTraslados As New List(Of SalidasBrl)
        Session.Remove("ListSalidasTraslados")
        ListSalidasTraslados = SalidasBrl.CargarPorId_Regional(0)
        Session("ListSalidasTraslados") = ListSalidasTraslados
        txt_Numero.Text = ""
        ddl_regional.SelectedValue = SeguridadUsuarios.Usuarios.RegionalUsuario(CType(Session("IdUsuario"), Integer))
        ddl_Bodega.SelectedValue = 0
        ddl_Productos.SelectedValue = 0
        rdpFechaInicial.DbSelectedDate = Nothing
        rdpFechaFinal.DbSelectedDate = Nothing
        Rg_Listado.DataSource = Session("ListSalidasTraslados")
        Rg_Listado.DataBind()


    End Sub

    Protected Sub btn_Procesar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_Procesar.Click, btn_actualizar.Click
        Dim wfechainicio As String = ""
        Dim wfechafinal As String = ""
        If rdpFechaInicial.SelectedDate.ToString.Trim <> "" Then
            wfechainicio = ajustarFecha10digitos(rdpFechaInicial.SelectedDate)
        End If
        If rdpFechaFinal.SelectedDate.ToString.Trim <> "" Then
            wfechafinal = ajustarFecha10digitos(rdpFechaFinal.SelectedDate)
        End If

        Dim ListSalidasTraslados As New List(Of SalidasBrl)
        ListSalidasTraslados = SalidasBrl.CargarPorBusqueda(ddl_regional.SelectedValue, ddl_Bodega.SelectedValue, ddl_Productos.SelectedValue, wfechainicio, wfechafinal, txt_Numero.Text, 3275)
        Session("ListSalidasTraslados") = ListSalidasTraslados
        Rg_Listado.DataSource = Session("ListSalidasTraslados")
        Rg_Listado.DataBind()
        btn_buscar_Click(Nothing, Nothing)
    End Sub

    Protected Sub ddl_regional_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_regional.SelectedIndexChanged
        If ddl_regional.SelectedValue > 0 Then
            BindHelper.SubTablasUIL.BindToListControlPorId_TablaPadre(ddl_Bodega, 31, ddl_regional.SelectedValue, New ListItem("Seleccione", 0))
        Else
            BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Bodega, 31, New ListItem("Seleccione", 0))
        End If
    End Sub
End Class
