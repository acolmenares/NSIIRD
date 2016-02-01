Imports System.Collections.Generic
Imports ingNovar.Utilidades2
Imports System.Data
Imports Telerik.Web.UI

Partial Class WebForms_LegalizacionList
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

            Rg_Entregas.MasterTableView.CommandItemSettings.ShowExportToCsvButton = objper_perfil.Pexportarcsv
            Rg_Entregas.MasterTableView.CommandItemSettings.ShowExportToExcelButton = objper_perfil.Pexportarexcel
            Rg_Entregas.MasterTableView.CommandItemSettings.ShowExportToPdfButton = objper_perfil.Pexportarpdf
            Rg_Entregas.MasterTableView.CommandItemSettings.ShowExportToWordButton = objper_perfil.Pexportarword

            Rg_Resumen.MasterTableView.CommandItemSettings.ShowExportToCsvButton = objper_perfil.Pexportarcsv
            Rg_Resumen.MasterTableView.CommandItemSettings.ShowExportToExcelButton = objper_perfil.Pexportarexcel
            Rg_Resumen.MasterTableView.CommandItemSettings.ShowExportToPdfButton = objper_perfil.Pexportarpdf
            Rg_Resumen.MasterTableView.CommandItemSettings.ShowExportToWordButton = objper_perfil.Pexportarword

            Rg_Programas.MasterTableView.CommandItemSettings.ShowExportToCsvButton = objper_perfil.Pexportarcsv
            Rg_Programas.MasterTableView.CommandItemSettings.ShowExportToExcelButton = objper_perfil.Pexportarexcel
            Rg_Programas.MasterTableView.CommandItemSettings.ShowExportToPdfButton = objper_perfil.Pexportarpdf
            Rg_Programas.MasterTableView.CommandItemSettings.ShowExportToWordButton = objper_perfil.Pexportarword

            ddl_regional.Enabled = objper_perfil.Pvertodo
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

            Rg_Entregas.MasterTableView.CommandItemSettings.ShowExportToCsvButton = objper_usuario.Pexportarcsv
            Rg_Entregas.MasterTableView.CommandItemSettings.ShowExportToExcelButton = objper_usuario.Pexportarexcel
            Rg_Entregas.MasterTableView.CommandItemSettings.ShowExportToPdfButton = objper_usuario.Pexportarpdf
            Rg_Entregas.MasterTableView.CommandItemSettings.ShowExportToWordButton = objper_usuario.Pexportarword

            Rg_Resumen.MasterTableView.CommandItemSettings.ShowExportToCsvButton = objper_usuario.Pexportarcsv
            Rg_Resumen.MasterTableView.CommandItemSettings.ShowExportToExcelButton = objper_usuario.Pexportarexcel
            Rg_Resumen.MasterTableView.CommandItemSettings.ShowExportToPdfButton = objper_usuario.Pexportarpdf
            Rg_Resumen.MasterTableView.CommandItemSettings.ShowExportToWordButton = objper_usuario.Pexportarword

            Rg_Programas.MasterTableView.CommandItemSettings.ShowExportToCsvButton = objper_usuario.Pexportarcsv
            Rg_Programas.MasterTableView.CommandItemSettings.ShowExportToExcelButton = objper_usuario.Pexportarexcel
            Rg_Programas.MasterTableView.CommandItemSettings.ShowExportToPdfButton = objper_usuario.Pexportarpdf
            Rg_Programas.MasterTableView.CommandItemSettings.ShowExportToWordButton = objper_usuario.Pexportarword

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
        ddl_regional_SelectedIndexChanged(Nothing, Nothing)

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_unidad, 33, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_productos, 32, New ListItem("Seleccione", 0))

        Dim ListLegalizacion As List(Of ProgramacionBrl) = Session("ListLegalizacion")

        'si no hay una variable de sesión con la lista.
        If ListLegalizacion Is Nothing Or Request.QueryString.Item("Refrescar") = 1 Then
            ListLegalizacion = ProgramacionBrl.CargarPorId_Regional(0)
            Session("ListLegalizacion") = ListLegalizacion
        End If

        Rg_Programas.DataSource = Session("ListLegalizacion")
        Rg_Programas.DataBind()

        RadTabStrip1.Visible = False
        RadMultiPage1.Visible = False
        lbl_Id.Text = ""
        lbl_mensaje.Text = ""

    End Sub

    Protected Sub Rg_Programas_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Programas.NeedDataSource
        Rg_Programas.DataSource = Session("ListLegalizacion")
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
        Session.Remove("ListLegalizacion")
        Dim ListLegalizacion As New List(Of ProgramacionBrl)
        ListLegalizacion = ProgramacionBrl.CargarPorId_Regional(0)
        Session("ListLegalizacion") = ListLegalizacion
        ddl_regional.SelectedValue = SeguridadUsuarios.Usuarios.RegionalUsuario(CType(Session("IdUsuario"), Integer))
        ddl_regional_SelectedIndexChanged(Nothing, Nothing)
        ddl_LugarEntrega_SelectedIndexChanged(Nothing, Nothing)
        Rg_Programas.DataSource = Session("ListLegalizacion")
        Rg_Programas.DataBind()

        RadTabStrip1.Visible = False
        RadMultiPage1.Visible = False

    End Sub

    Protected Sub btn_Procesar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_Procesar.Click, btn_actualizar.Click
        Session.Remove("ListLegalizacion")
        Dim ListLegalizacion As List(Of ProgramacionBrl)

        ListLegalizacion = ProgramacionBrl.CargarbusquedaPorEstado(ddl_regional.SelectedValue, ddl_Grupo.SelectedValue, ddl_LugarEntrega.SelectedValue, 215)
        Session("ListLegalizacion") = ListLegalizacion
        Rg_Programas.DataSource = Session("ListLegalizacion")
        Rg_Programas.DataBind()
        btn_buscar_Click(Nothing, Nothing)
    End Sub

    Protected Sub Rg_Programas_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rg_Programas.SelectedIndexChanged
        Dim item As Telerik.Web.UI.GridDataItem = Me.Rg_Programas.SelectedItems.Item(Rg_Programas.SelectedIndexes.Item(0))
        Dim objprograma As ProgramacionBrl = ProgramacionBrl.CargarPorID(item("id").Text)
        Select Case objprograma.Id_TipoEntrega

            Case Is = 72, 918
                BindHelper.PersonasUIL.BindToListControlPorId_Grupo(ddl_declarantes, objprograma.Id_Grupo, New ListItem("Seleccione", 0))
            Case Is = 920, 3695
                BindHelper.PersonasUIL.BindToListControlPorId_Programa_EntregaAdicional(ddl_declarantes, objprograma.ID, New ListItem("Seleccione", 0))
            Case Else
                BindHelper.PersonasUIL.BindToListControlPorId_Grupo(ddl_declarantes, objprograma.Id_Grupo, New ListItem("Seleccione", 0))
        End Select

        lbl_Id.Text = objprograma.ID
        '
        '  Entregas de Comida
        '

        Dim ListSalidas As List(Of SalidasBrl) = SalidasBrl.CargarPorId_Grupo(objprograma.Id_Grupo)
        FilterHelper.FilterHelper(ListSalidas, "Id_Tipo_Entrega", objprograma.Id_TipoEntrega)

        Dim ListSalidasDetalle As New List(Of Salidas_DetalleBrl)
        For Each fila As SalidasBrl In ListSalidas
            For Each fila1 As Salidas_DetalleBrl In fila.Salidas_Detalle
                ListSalidasDetalle.Add(fila1)
            Next
        Next

        Session("ListSalidasDetalle") = ListSalidasDetalle
        Rg_Entregas.DataSource = Session("ListSalidasDetalle")
        Rg_Entregas.DataBind()


        '
        '  Personas con Productos entregados
        '
        Dim ListPersonasEntregas As List(Of Personas_EntregasBrl)
        ListPersonasEntregas = Personas_EntregasBrl.CargarPorId_Programa(objprograma.ID)
        Session("ListPersonasEntregas") = ListPersonasEntregas

        Rg_Listado.DataSource = Session("ListPersonasEntregas")
        Rg_Listado.DataBind()

        '
        ' Resumen de Productos
        '
        btn_resumen_Click(Nothing, Nothing)
        '
        RadTabStrip1.Visible = True
        RadMultiPage1.Visible = True
    End Sub

    Protected Sub Rg_Listado_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Listado.NeedDataSource
        Rg_Listado.DataSource = Session("ListPersonasEntregas")
    End Sub

    Protected Sub Rg_Entregas_NeedDataSource(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Entregas.NeedDataSource
        Rg_Entregas.DataSource = Session("ListSalidasDetalle")
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Validate("ENTREGA")
        If Not IsValid Then Exit Sub
        If lbl_Id.Text <> "" Then

            Dim objpersonasentrega As New Personas_EntregasBrl
            objpersonasentrega.Id_Programa = lbl_Id.Text
            objpersonasentrega.Id_Producto = ddl_productos.SelectedValue
            objpersonasentrega.Id_Persona = ddl_declarantes.SelectedValue
            objpersonasentrega.Id_Unidad = ddl_unidad.SelectedValue
            objpersonasentrega.Cantidad = txt_cantidad.Text
            objpersonasentrega.Cantidad_Legalizada = txt_cantidad.Text
            objpersonasentrega.Guardar()
            ddl_declarantes.SelectedValue = 0
            ddl_productos.SelectedValue = 0
            ddl_unidad.SelectedValue = 0
            txt_cantidad.Text = ""

            btn_resumen_Click(Nothing, Nothing)
            btn_recargar_Click(Nothing, Nothing)
        End If
    End Sub

    Protected Sub btn_recargar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_recargar.Click
        Dim ListPersonasEntregas As List(Of Personas_EntregasBrl)
        ListPersonasEntregas = Personas_EntregasBrl.CargarPorId_Programa(lbl_Id.Text)
        Session("ListPersonasEntregas") = ListPersonasEntregas

        Rg_Listado.DataSource = Session("ListPersonasEntregas")
        Rg_Listado.DataBind()
    End Sub

    Protected Sub btn_Legalizar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Legalizar.Click
        If lbl_Id.Text <> "" Then
            Dim wtienesaldo As Boolean = False
            Dim objprograma As ProgramacionBrl = ProgramacionBrl.CargarPorID(lbl_Id.Text)
            '
            ' Validar si no hay saldos negativos en la legalización
            '
            Dim ds As DataSet = ProgramacionDAL.CargarPorResumenPrograma(objprograma.Id_Grupo, objprograma.ID, objprograma.Id_TipoEntrega)
            For Each fila As DataRow In ds.Tables(0).Rows
                If fila("Saldo") < 0 Then
                    wtienesaldo = True
                End If
            Next

            If wtienesaldo = False Then
                objprograma.Id_Estado = 216
                objprograma.Guardar()

                btn_limpiar_Click(Nothing, Nothing)
            Else
                lbl_mensaje.Text = "Tiene Productos con saldos negativos... Revisar Resumen !!!"
                lbl_mensaje.Visible = True
            End If


        Else
            lbl_mensaje.Text = "No existe registro de programacion cargado !!!"
            lbl_mensaje.Visible = True
        End If

    End Sub

    Protected Sub btn_pasar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_pasar.Click

        For Each dataItem As GridDataItem In Rg_Listado.MasterTableView.Items

            If dataItem.ItemType = GridItemType.AlternatingItem Or dataItem.ItemType = GridItemType.Item Then
                CType(dataItem.FindControl("txt_legalizado"), TextBox).Text = dataItem("Cantidad").Text
            End If

        Next

    End Sub

    Protected Sub btn_grabar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_grabar.Click
        Dim lblid As Label
        Dim objpersonaentrega As Personas_EntregasBrl

        For Each dataItem As GridDataItem In Rg_Listado.MasterTableView.Items
            If dataItem.ItemType = GridItemType.AlternatingItem Or dataItem.ItemType = GridItemType.Item Then
                lblid = dataItem.FindControl("lblid")
                objpersonaentrega = Personas_EntregasBrl.CargarPorID(lblid.Text)
                objpersonaentrega.Cantidad_Legalizada = CType(dataItem.FindControl("txt_legalizado"), TextBox).Text
                objpersonaentrega.Guardar()
            End If
        Next
        lbl_mensaje.Text = "Registros Guardados"
    End Sub

    Protected Sub btn_resumen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_resumen.Click

        Dim objprograma As ProgramacionBrl = ProgramacionBrl.CargarPorID(lbl_Id.Text)
        If objprograma IsNot Nothing Then
            Dim ds As DataSet
            ds = ProgramacionDAL.CargarPorResumenPrograma(objprograma.Id_Grupo, objprograma.ID, objprograma.Id_TipoEntrega)
            Session("Resumen") = ds
            Rg_Resumen.DataSource = Session("Resumen")
            Rg_Resumen.DataBind()

        End If
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
            BindHelper.SubTablasUIL.BindToListControlPorId_TablaPadre(ddl_Grupo, 26, ddl_LugarEntrega.SelectedValue, New ListItem("Seleccione", 0))
        Else
            BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Grupo, 0, New ListItem("Seleccione", 0))
        End If
    End Sub
End Class
