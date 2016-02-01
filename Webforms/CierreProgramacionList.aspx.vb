Imports System.Collections.Generic
Imports ingNovar.Utilidades2
Imports System.Data
Imports Telerik.Web.UI

Partial Class WebForms_CierreProgramacionList
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
            'btn_nuevo.Enabled = objper_perfil.Pcrear
            btn_buscar.Enabled = objper_perfil.Pconsultar
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToCsvButton = objper_perfil.Pexportarcsv
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToExcelButton = objper_perfil.Pexportarexcel
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToPdfButton = objper_perfil.Pexportarpdf
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToWordButton = objper_perfil.Pexportarword
            Rg_Listado.ClientSettings.EnablePostBackOnRowClick = objper_perfil.Peditar
            Rg_Listado.ClientSettings.Selecting.AllowRowSelect = objper_perfil.Peditar



            ddl_regional.Enabled = objper_perfil.Pvertodo
            btn_Legalizar.Enabled = objper_perfil.Pcrear


            '
            '  Cuando hay grillas adicionales
            '
            Rg_Programas.MasterTableView.CommandItemSettings.ShowExportToCsvButton = objper_perfil.Pexportarcsv
            Rg_Programas.MasterTableView.CommandItemSettings.ShowExportToExcelButton = objper_perfil.Pexportarexcel
            Rg_Programas.MasterTableView.CommandItemSettings.ShowExportToPdfButton = objper_perfil.Pexportarpdf
            Rg_Programas.MasterTableView.CommandItemSettings.ShowExportToWordButton = objper_perfil.Pexportarword
            Rg_Programas.ClientSettings.EnablePostBackOnRowClick = objper_perfil.Peditar
            Rg_Programas.ClientSettings.Selecting.AllowRowSelect = objper_perfil.Peditar

            '
            Rg_Resumen.MasterTableView.CommandItemSettings.ShowExportToCsvButton = objper_perfil.Pexportarcsv
            Rg_Resumen.MasterTableView.CommandItemSettings.ShowExportToExcelButton = objper_perfil.Pexportarexcel
            Rg_Resumen.MasterTableView.CommandItemSettings.ShowExportToPdfButton = objper_perfil.Pexportarpdf
            Rg_Resumen.MasterTableView.CommandItemSettings.ShowExportToWordButton = objper_perfil.Pexportarword
            Rg_Resumen.ClientSettings.EnablePostBackOnRowClick = objper_perfil.Peditar
            Rg_Resumen.ClientSettings.Selecting.AllowRowSelect = objper_perfil.Peditar

        End If

        If objper_usuario IsNot Nothing Then
            If objper_usuario.Pver = False Or objper_usuario.Pconsultar = False Then
                Response.Redirect(strPaginaError)
                Exit Sub
            End If

            ' asignando los permisos
            'btn_nuevo.Enabled = objper_usuario.Pcrear
            btn_buscar.Enabled = objper_usuario.Pconsultar
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToCsvButton = objper_usuario.Pexportarcsv
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToExcelButton = objper_usuario.Pexportarexcel
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToPdfButton = objper_usuario.Pexportarpdf
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToWordButton = objper_usuario.Pexportarword
            Rg_Listado.ClientSettings.EnablePostBackOnRowClick = objper_usuario.Peditar
            Rg_Listado.ClientSettings.Selecting.AllowRowSelect = objper_usuario.Peditar
            ddl_regional.Enabled = objper_usuario.Pvertodo
            btn_Legalizar.Enabled = objper_usuario.Pcrear

            '
            '  Cuando hay grillas adicionales
            '
            Rg_Programas.MasterTableView.CommandItemSettings.ShowExportToCsvButton = objper_usuario.Pexportarcsv
            Rg_Programas.MasterTableView.CommandItemSettings.ShowExportToExcelButton = objper_usuario.Pexportarexcel
            Rg_Programas.MasterTableView.CommandItemSettings.ShowExportToPdfButton = objper_usuario.Pexportarpdf
            Rg_Programas.MasterTableView.CommandItemSettings.ShowExportToWordButton = objper_usuario.Pexportarword
            Rg_Programas.ClientSettings.EnablePostBackOnRowClick = objper_usuario.Peditar
            Rg_Programas.ClientSettings.Selecting.AllowRowSelect = objper_usuario.Peditar

            '
            Rg_Resumen.MasterTableView.CommandItemSettings.ShowExportToCsvButton = objper_usuario.Pexportarcsv
            Rg_Resumen.MasterTableView.CommandItemSettings.ShowExportToExcelButton = objper_usuario.Pexportarexcel
            Rg_Resumen.MasterTableView.CommandItemSettings.ShowExportToPdfButton = objper_usuario.Pexportarpdf
            Rg_Resumen.MasterTableView.CommandItemSettings.ShowExportToWordButton = objper_usuario.Pexportarword
            Rg_Resumen.ClientSettings.EnablePostBackOnRowClick = objper_usuario.Peditar
            Rg_Resumen.ClientSettings.Selecting.AllowRowSelect = objper_usuario.Peditar

        End If

        ' Definiendo el dato de la regional
        ddl_regional.SelectedValue = SeguridadUsuarios.Usuarios.RegionalUsuario(CType(Session("IdUsuario"), Integer))

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


        If Request.QueryString.Item("Mensaje") = 3 Then
            lbl_mensaje.Text = "Se realizo el cierre a satisfacción!!!!"
            lbl_mensaje.Visible = True

        End If

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_regional, 72, New ListItem("Seleccione", 0))
        ddl_regional_SelectedIndexChanged(Nothing, Nothing)

        Dim ListLegalizacionCierre As List(Of ProgramacionBrl) = Session("ListLegalizacionCierre")

        'si no hay una variable de sesión con la lista.
        If ListLegalizacionCierre Is Nothing Or Request.QueryString.Item("Refrescar") = 1 Then
            ListLegalizacionCierre = ProgramacionBrl.CargarPorId_Regional(0)
            Session("ListLegalizacionCierre") = ListLegalizacionCierre
        End If

        Rg_Programas.DataSource = Session("ListLegalizacionCierre")
        Rg_Programas.DataBind()

        RadTabStrip1.Visible = False
        RadMultiPage1.Visible = False
        lbl_Id.Text = ""
        lbl_mensaje.Text = ""

    End Sub

    Protected Sub Rg_Programas_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Programas.NeedDataSource
        Rg_Programas.DataSource = Session("ListLegalizacionCierre")
    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        Response.Redirect("../webforms/CierreProgramacionList.aspx?Refrescar=1")
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
        Session.Remove("ListLegalizacionCierre")
        Dim ListLegalizacionCierre As New List(Of ProgramacionBrl)
        ListLegalizacionCierre = ProgramacionBrl.CargarPorId_Regional(0)
        Session("ListLegalizacionCierre") = ListLegalizacionCierre
        ddl_regional.SelectedValue = SeguridadUsuarios.Usuarios.RegionalUsuario(CType(Session("IdUsuario"), Integer))
        ddl_regional_SelectedIndexChanged(Nothing, Nothing)
        Rg_Programas.DataSource = Session("ListLegalizacionCierre")
        Rg_Programas.DataBind()

        RadTabStrip1.Visible = False
        RadMultiPage1.Visible = False
    End Sub

    Protected Sub btn_Procesar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_Procesar.Click, btn_actualizar.Click
        Session.Remove("ListLegalizacionCierre")
        Dim ListLegalizacionCierre As List(Of ProgramacionBrl)
        ListLegalizacionCierre = ProgramacionBrl.CargarbusquedaPorEstado(ddl_regional.SelectedValue, ddl_Grupo.SelectedValue, ddl_Lugar_Entrega.SelectedValue, 216)
        Session("ListLegalizacionCierre") = ListLegalizacionCierre
        Rg_Programas.DataSource = Session("ListLegalizacionCierre")
        Rg_Programas.DataBind()

    End Sub

    Protected Sub Rg_Programas_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rg_Programas.SelectedIndexChanged
        Dim item As Telerik.Web.UI.GridDataItem = Me.Rg_Programas.SelectedItems.Item(Rg_Programas.SelectedIndexes.Item(0))
        Dim objprograma As ProgramacionBrl = ProgramacionBrl.CargarPorID(item("id").Text)
        lbl_Id.Text = objprograma.ID

        '
        '  Declarantes y Beneficiarios del Grupo
        '
        Dim ListDeclaracionEstados As List(Of Declaracion_EstadosBrl) = Declaracion_EstadosBrl.CargarPorId_Programa(lbl_Id.Text)
        Dim ListDeclaracion As New List(Of DeclaracionBrl)
        Dim ListPersonasDeclarantes As New List(Of PersonasBrl)
        'ListDeclaracion = DeclaracionBrl.CargarPorId_Grupo(objprograma.Id_Grupo)
        For Each filaestado As Declaracion_EstadosBrl In ListDeclaracionEstados
            If filaestado.Id_Asistio = 19 Then
                ListDeclaracion.Add(filaestado.Declaracion)
                ListPersonasDeclarantes.Add(filaestado.Declaracion.Personas_Declarante)
            End If
        Next

        Session("ListPersonasDeclarantes") = ListPersonasDeclarantes
        Rg_Listado.DataSource = Session("ListPersonasDeclarantes")
        Rg_Listado.DataBind()

        '
        ' Resumen de Productos
        '
        btn_resumen_Click(Nothing, Nothing)
        '

        Dim wcantidad As Integer = 0
        Dim wcansalud As Integer = 0
        Dim wcanedade As Integer = 0
        Dim wcantfam2e As Integer = 0
        Dim wcantBen2e As Integer = 0
        For Each fila As DeclaracionBrl In ListDeclaracion
            wcantidad += fila.Personas.Count
            For Each fila1 As PersonasBrl In fila.Personas
                If fila1.Edad >= 1 And fila1.Edad <= 4 Then
                    wcansalud += 1
                End If
            Next
            For Each fila2 As Declaracion_EstadosBrl In fila.Declaracion_Estados
                If fila2.Id_Tipo_Estado = 4038 Then
                    If fila2.Programa IsNot Nothing Then
                        If fila2.Programa.Id_TipoEntrega = 918 Then
                            If fila2.Id_Asistio = 19 Then
                                wcantfam2e += 1
                                wcantBen2e += fila.Personas.Count
                            End If
                        End If
                    End If
                End If
            Next

            wcanedade += fila.PersonasEducacion.Count
        Next

        lbl_familias.Text = ListDeclaracion.Count
        lbl_Beneficiarios.Text = wcantidad.ToString
        lbl_GrupoActivo.Text = objprograma.Grupo.Descripcion
        lbl_salud.Text = wcansalud.ToString
        lbl_edadescolar.Text = wcanedade.ToString
        lbl_familias_2E.Text = wcantfam2e.ToString
        lbl_Beneficiarios_2E.Text = wcantBen2e.ToString

        '
        ' Sacando los datos de reprogramados
        '
        Dim wcantfamrep As Integer = 0
        Dim wcantbenrep As Integer = 0


        For Each fila As Declaracion_EstadosBrl In LisTDeclaracionEstados
            If fila.Declaracion.Id_Grupo <> objprograma.Id_Grupo Then
                wcantfamrep += 1
                wcantbenrep += fila.Declaracion.Personas.Count
            End If
        Next
        lbl_Familias_REP.Text = wcantfamrep.ToString
        lbl_Beneficiarios_REP.Text = wcantbenrep.ToString


        RadTabStrip1.Visible = True
        RadMultiPage1.Visible = True
    End Sub

    Protected Sub Rg_Listado_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Listado.NeedDataSource
        Rg_Listado.DataSource = Session("ListPersonasDeclarantes")
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
                If fila("Saldo") > 0 Then
                    wtienesaldo = True
                End If
            Next

            '
            ' Salvando el grupo de programacion
            '
            objprograma.Id_Estado = 217
            objprograma.Guardar()

            '

            If wtienesaldo Then
                '
                ' crear la devolucion de la mercancia
                '

                '
                ' encabezado de la entrada
                '
                Dim objentrada As New EntradasBrl
                Dim ListEntradasDetalle As List(Of Entradas_DetalleBrl)
                Dim objentradadetalle As Entradas_DetalleBrl
                Dim ListEntradasDetalleDistribucion As List(Of Entradas_DistribucionBrl)
                Dim objentradadistribucion As Entradas_DistribucionBrl

                objentrada.Id_Tipo_Entrada = 158 ' tipo de entrada de devolucion
                objentrada.Numero_Entrada = objprograma.Numero
                objentrada.Fecha = Now
                objentrada.Id_Regional = objprograma.Id_Regional
                objentrada.Id_Usuario_Recibio = CType(Master.FindControl("lblidusuario"), Label).Text
                objentrada.Nombre_Entrego = CType(Master.FindControl("lblnombreusuario"), Label).Text
                objentrada.Observacion = "Devolución de Mercancia de acuerdo a RP " + objprograma.Numero
                objentrada.Fecha_Creacion = Now
                objentrada.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
                objentrada.Id_Tercero = 1 ' IRD

                ListEntradasDetalle = New List(Of Entradas_DetalleBrl)
                Dim ListSalidas As List(Of SalidasBrl) = SalidasBrl.CargarPorId_Grupo(objprograma.Id_Grupo)
                Dim wsaldo As Integer = 0
                For Each fila As DataRow In ds.Tables(0).Rows

                    If fila("Saldo") > 0 Then

                        wsaldo = fila("Saldo")

                        For Each filasalida As SalidasBrl In ListSalidas
                            For Each filadetallesalida As Salidas_DetalleBrl In filasalida.Salidas_Detalle
                                If filadetallesalida.Id_Producto = fila("Id") Then ' verifica producto
                                    For Each filasalidadetalleentrada As Salidas_Detalle_EntradasBrl In filadetallesalida.Salidas_Detalle_Entradas
                                        objentradadetalle = New Entradas_DetalleBrl
                                        objentradadetalle.Id_Capacidad = filadetallesalida.Id_Capacidad
                                        objentradadetalle.Valor_Unitario = filasalidadetalleentrada.Entrada_Distribucion.Entradas_Detalle.Valor_Unitario
                                        objentradadetalle.Fecha_Vencimiento = filasalidadetalleentrada.Entrada_Distribucion.Entradas_Detalle.Fecha_Vencimiento
                                        objentradadetalle.Id_Producto = fila("Id")
                                        If filadetallesalida.Cantidad > wsaldo Then
                                            objentradadetalle.Cantidad = wsaldo
                                        Else
                                            objentradadetalle.Cantidad = filadetallesalida.Cantidad
                                        End If
                                        objentradadetalle.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
                                        objentradadetalle.Fecha_Creacion = Now

                                        objentradadistribucion = New Entradas_DistribucionBrl
                                        objentradadistribucion.Id_Bodega = filasalida.Id_Bodega
                                        objentradadistribucion.Cantidad = objentradadetalle.Cantidad
                                        objentradadistribucion.Id_Capacidad = filadetallesalida.Id_Capacidad
                                        objentradadistribucion.Observacion = "Proceso Automatico"
                                        objentradadistribucion.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
                                        objentradadistribucion.Fecha_Creacion = Now

                                        ListEntradasDetalleDistribucion = New List(Of Entradas_DistribucionBrl)
                                        ListEntradasDetalleDistribucion.Add(objentradadistribucion)
                                        objentradadetalle.Entradas_Distribucion = ListEntradasDetalleDistribucion
                                        ListEntradasDetalle.Add(objentradadetalle)
                                        wsaldo = wsaldo - objentradadetalle.Cantidad
                                        If wsaldo <= 0 Then Exit For
                                    Next

                                End If
                                If wsaldo <= 0 Then Exit For
                            Next
                            If wsaldo <= 0 Then Exit For
                        Next

                    End If
                Next
                '
                '
                objentrada.Entradas_Detalle = ListEntradasDetalle
                objentrada.Guardar()

            End If

            Response.Redirect("../webforms/CierreProgramacionList.aspx?Refrescar=1&Mensaje=3")

        End If
    End Sub

    Protected Sub btn_resumen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_resumen.Click
        Dim objprograma As ProgramacionBrl = ProgramacionBrl.CargarPorID(lbl_Id.Text)
        If objprograma IsNot Nothing Then
            Dim ds As DataSet
            ds = ProgramacionDAL.CargarPorResumenPrograma(objprograma.Id_Grupo, objprograma.ID, objprograma.Id_TipoEntrega)
            Session("Resumen") = ds
            Rg_Resumen.DataSource = Session("Resumen")
            Rg_Resumen.DataBind()

            Dim wtienesaldo As Boolean = False

            For Each fila As DataRow In ds.Tables(0).Rows
                If fila("Saldo") > 0 Then
                    wtienesaldo = True
                    Exit For
                End If
            Next

            If wtienesaldo = False Then
                lbl_devolucion.Text = "NO"
            Else
                lbl_devolucion.Text = "SI"
            End If
        End If
    End Sub

    Protected Sub Rg_Listado_DetailTableDataBind(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridDetailTableDataBindEventArgs) Handles Rg_Listado.DetailTableDataBind
        Dim dataItem As GridDataItem = CType(e.DetailTableView.ParentItem, GridDataItem)
        Select Case e.DetailTableView.Name
            Case "Beneficiarios"
                Dim IdDeclarante As String = dataItem.GetDataKeyValue("ID").ToString()
                Dim objpersona As PersonasBrl = PersonasBrl.CargarPorID(IdDeclarante)
                Dim ListPersonas As List(Of PersonasBrl) = PersonasBrl.CargarPorId_DeclaracionYBeneficiarios(objpersona.Id_Declaracion)
                e.DetailTableView.DataSource = ListPersonas
        End Select

    End Sub

    Protected Sub ddl_regional_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_regional.SelectedIndexChanged
        If ddl_regional.SelectedValue > 0 Then
            BindHelper.SubTablasUIL.BindToListControlPorId_TablaPadre(ddl_Lugar_Entrega, 73, ddl_regional.SelectedValue, New ListItem("Seleccione", 0))
        Else
            BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Lugar_Entrega, 73, New ListItem("Seleccione", 0))
        End If
        ddl_LugarEntrega_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Protected Sub ddl_LugarEntrega_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_Lugar_Entrega.SelectedIndexChanged
        If ddl_Lugar_Entrega.SelectedValue > 0 Then
            BindHelper.SubTablasUIL.BindToListControlPorId_TablaPadre(ddl_Grupo, 26, ddl_Lugar_Entrega.SelectedValue, New ListItem("Seleccione", 0))
        Else
            BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Grupo, 0, New ListItem("Seleccione", 0))
        End If
    End Sub
End Class
