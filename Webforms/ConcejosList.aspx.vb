﻿Imports System.Collections.Generic
Imports ingNovar.Utilidades2
Imports System.Data
Imports Telerik.Web.UI

Partial Class WebForms_ConcejosList
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
            btn_nuevo.Enabled = objper_perfil.Pcrear
            btn_buscar.Enabled = objper_perfil.Pconsultar
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToCsvButton = objper_perfil.Pexportarcsv
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToExcelButton = objper_perfil.Pexportarexcel
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToPdfButton = objper_perfil.Pexportarpdf
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToWordButton = objper_perfil.Pexportarword
            Rg_Listado.ClientSettings.EnablePostBackOnRowClick = objper_perfil.Peditar
            Rg_Listado.ClientSettings.Selecting.AllowRowSelect = objper_perfil.Peditar
            Rg_Listado.Columns(5).Visible = objper_perfil.Peliminar
            'ddl_Regional.Enabled = objper_perfil.Pvertodo
        End If

        If objper_usuario IsNot Nothing Then
            If objper_usuario.Pver = False Or objper_usuario.Pconsultar = False Then
                Response.Redirect(strPaginaError)
                Exit Sub
            End If

            ' asignando los permisos
            btn_nuevo.Enabled = objper_usuario.Pcrear
            btn_buscar.Enabled = objper_usuario.Pconsultar
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToCsvButton = objper_usuario.Pexportarcsv
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToExcelButton = objper_usuario.Pexportarexcel
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToPdfButton = objper_usuario.Pexportarpdf
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToWordButton = objper_usuario.Pexportarword
            Rg_Listado.ClientSettings.EnablePostBackOnRowClick = objper_usuario.Peditar
            Rg_Listado.ClientSettings.Selecting.AllowRowSelect = objper_usuario.Peditar
            Rg_Listado.Columns(5).Visible = objper_usuario.Peliminar
            'ddl_Regional.Enabled = objper_usuario.Pvertodo
        End If

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

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Municipios, 15, New ListItem("Seleccione", 0))

        Dim ListConcejos As List(Of SubTablasBrl) = Session("ListConcejos")

        'si no hay una variable de sesión con la lista.
        If ListConcejos Is Nothing Or Request.QueryString.Item("Refrescar") = 1 Then
            ListConcejos = SubTablasBrl.CargarPorId_Tabla(17)
            Session("ListConcejos") = ListConcejos
        End If

        Rg_Listado.DataSource = Session("ListConcejos")
        Rg_Listado.DataBind()

    End Sub

    Protected Sub Rg_Listado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rg_Listado.SelectedIndexChanged
        Dim item As Telerik.Web.UI.GridDataItem = Me.Rg_Listado.SelectedItems.Item(Rg_Listado.SelectedIndexes.Item(0))
        Response.Redirect("Concejo.aspx?Editar=1&ID=" & item("id").Text)
    End Sub

    Protected Sub Rg_Listado_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Listado.NeedDataSource
        Rg_Listado.DataSource = Session("ListConcejos")
    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_nuevo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_nuevo.Click
        Response.Redirect("../webforms/Concejo.aspx")
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
        txt_descripcion.Text = ""
        ddl_Municipios.SelectedValue = 0
        btn_Procesar_Click(Nothing, Nothing)
    End Sub

    Protected Sub btn_Procesar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_Procesar.Click, btn_actualizar.Click
        Dim ListConcejos As New List(Of SubTablasBrl)
        Session.Remove("ListConcejos")
        ListConcejos = SubTablasBrl.CargarBusqueda(17, txt_descripcion.Text, ddl_Municipios.SelectedValue)
        Session("ListConcejos") = ListConcejos
        Rg_Listado.DataSource = Session("ListConcejos")
        Rg_Listado.DataBind()
        lblMensaje.Text = ""
        pnl_buscar.Visible = False
    End Sub

    Protected Sub RadGrid1_DeleteCommand(ByVal source As Object, ByVal e As GridCommandEventArgs) Handles Rg_Listado.DeleteCommand
        Dim itemId = DirectCast((DirectCast(e.Item, GridDataItem)).GetDataKeyValue("Id"), Integer)
        Dim objconcejo As SubTablasBrl = SubTablasBrl.CargarPorID(itemId)
        Try
            objconcejo.Eliminar()
            lblMensaje.Text = "El Concejo/Resguardo/Cabildo/Grupo Indígena ha sido eliminado."

        Catch ex As Exception
            lblMensaje.Text = "El Concejo/Resguardo/Cabildo/Grupo Indígena no se puede eliminar. "
        End Try
        ' MsgBox(lblMensaje.Text, MsgBoxStyle.Information, "Mensaje de Concejo/Resguardo/Cabildo/Grupo Indígena")
        btn_Procesar_Click(Nothing, Nothing)

    End Sub

End Class
