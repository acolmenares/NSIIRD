Imports ingNovar.Utilidades2
Imports System.Collections.Generic
Imports Telerik.Web.UI
Imports System.Data

Partial Class WebForms_Programacion
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

            If Request.QueryString.Item("Id") > 0 Then  ' va a editar
                btnGuardar.Enabled = objper_perfil.Peditar
                btnGuardarOtro.Enabled = objper_perfil.Peditar
                btnactivar.Enabled = objper_perfil.Peditar
                btnAsignar.Enabled = objper_perfil.Peditar
                btnGrabarTodo.Enabled = objper_perfil.Peditar
            Else
                btnGuardar.Enabled = objper_perfil.Pcrear
                btnGuardarOtro.Enabled = objper_perfil.Pcrear
                btnactivar.Enabled = objper_perfil.Pcrear
                btnAsignar.Enabled = objper_perfil.Pcrear
                btnGrabarTodo.Enabled = objper_perfil.Pcrear
            End If

            Rg_Listado.ClientSettings.EnablePostBackOnRowClick = objper_perfil.Peditar
            btnEliminar.Enabled = objper_perfil.Peliminar

            ddl_regional.Enabled = objper_perfil.Pvertodo
        End If

        If objper_usuario IsNot Nothing Then
            If objper_usuario.Pver = False Or objper_usuario.Pconsultar = False Then
                Response.Redirect(strPaginaError)
                Exit Sub
            End If

            ' asignando los permisos

            If Request.QueryString.Item("Id") > 0 Then  ' va a editar
                btnGuardar.Enabled = objper_usuario.Peditar
                btnGuardarOtro.Enabled = objper_usuario.Peditar
                btnactivar.Enabled = objper_usuario.Peditar
                btnAsignar.Enabled = objper_usuario.Peditar
                btnGrabarTodo.Enabled = objper_usuario.Peditar
            Else
                btnGuardar.Enabled = objper_usuario.Pcrear
                btnGuardarOtro.Enabled = objper_usuario.Pcrear
                btnactivar.Enabled = objper_usuario.Pcrear
                btnAsignar.Enabled = objper_usuario.Pcrear
                btnGrabarTodo.Enabled = objper_usuario.Pcrear
            End If

            Rg_Listado.ClientSettings.EnablePostBackOnRowClick = objper_usuario.Peliminar
            btnEliminar.Enabled = objper_usuario.Peliminar

            ddl_regional.Enabled = objper_usuario.Pvertodo
        End If

        ' Definiendo el dato de la regional
        ddl_regional.SelectedValue = SeguridadUsuarios.Usuarios.RegionalUsuario(CType(Session("IdUsuario"), Integer))


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

        If Request.QueryString.Item("Mensaje") = 1 Then
            lblMensaje.Text = "Operación exitosa"
            lblMensaje.Visible = True
        End If

        If Request.QueryString.Item("Mensaje") = 2 Then
            lblMensaje.Text = "Se genero el registro de Asignación de Grupo a Satisfacción."
            lblMensaje.Visible = True
        End If

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_regional, 72, New ListItem("Seleccione", 0))
        'BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_bodegas, 31, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_tipoEntrega, 77, New ListItem("Seleccione", 0))
        ddl_regional_SelectedIndexChanged(Nothing, Nothing)

        btnactivar.Visible = False
        btnAsignar.Visible = False
        If Request.QueryString.Item("Editar") = 1 Then
            Dim objProgramacion As ProgramacionBrl = ProgramacionBrl.CargarPorID(Request.QueryString.Item("ID"))

            If objProgramacion Is Nothing Then
                lblMensaje.Text = "Registro no existe"
                lblMensaje.Visible = True
                Exit Sub
            End If
            rdpFechaRadicacion.SelectedDate = objProgramacion.Fecha

            If ddl_regional.Items.FindByValue(objProgramacion.Id_Regional) IsNot Nothing Then ddl_regional.SelectedValue = objProgramacion.Id_Regional
            ddl_regional_SelectedIndexChanged(Nothing, Nothing)
            If ddl_LugarFuente.Items.FindByValue(objProgramacion.Id_LugarEntrega) IsNot Nothing Then ddl_LugarFuente.SelectedValue = objProgramacion.Id_LugarEntrega
            Txt_Numero_Registro.Text = objProgramacion.Numero
            ddl_tipoEntrega.SelectedValue = objProgramacion.Id_TipoEntrega
            ddl_bodegas.SelectedValue = objProgramacion.id_Bodega
            lbl_estado.Text = objProgramacion.Estados.Descripcion
            If objProgramacion.Id_Grupo <> 0 Then
                lbl_Grupo.Text = objProgramacion.Grupo.Descripcion
            End If

            ' validando estados
            btnactivar.Visible = False
            ddl_regional.Enabled = False
            ddl_LugarFuente.Enabled = False
            ddl_tipoEntrega.Enabled = False
            Txt_Numero_Registro.Enabled = False
            rdpFechaRadicacion.Enabled = False
            ddl_bodegas.Enabled = False

            btnGuardar.Visible = False
            btnGuardarOtro.Visible = False
            btnEliminar.Visible = False

            If objProgramacion.Id_Estado = 213 Then ' Abierto
                btnactivar.Visible = True
                ddl_regional.Enabled = True
                ddl_LugarFuente.Enabled = True
                ddl_tipoEntrega.Enabled = True
                Txt_Numero_Registro.Enabled = True
                rdpFechaRadicacion.Enabled = True
                btnGuardar.Visible = True
                btnGuardarOtro.Visible = True
                btnEliminar.Visible = True
                ddl_bodegas.Enabled = True

            End If

            If objProgramacion.Id_Estado = 214 Then ' Activado
                btnAsignar.Visible = True
            Else
                btnAsignar.Visible = False
            End If

            '
            ' Asignando Entrega Adicional al Programa
            '
            If (ddl_tipoEntrega.SelectedValue = 3695) Or (ddl_tipoEntrega.SelectedValue = 920) Then
                Dim Listentregas As List(Of Entregas_AdicionalesBrl) = Entregas_AdicionalesBrl.CargarPorId_Programa(Request.QueryString.Item("Id"))
                If Listentregas.Count > 0 Then
                    lbl_IdEntregaAdicional.Text = Listentregas.Item(0).ID
                Else
                    lbl_IdEntregaAdicional.Text = ""
                End If
            Else
                lbl_IdEntregaAdicional.Text = ""
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Validate("RI")
        If Not IsValid Then Exit Sub

        Dim ID As Int32
        lblMensaje.Visible = False
        Try
            ID = Grabar()
            Response.Redirect("Programacion.aspx?Editar=1&Mensaje=1&ID=" & ID)
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Private Sub btnGuardarOtro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarOtro.Click
        Validate("RI")
        If Not IsValid Then Exit Sub
        lblMensaje.Visible = False

        Try
            Grabar()
            Response.Redirect("Programacion.aspx?Mensaje=1")
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Private Function Grabar() As Int32

        Dim objProgramacion As ProgramacionBrl


        If Request.QueryString.Item("Editar") = 1 Then
            objProgramacion = ProgramacionBrl.CargarPorID(Request.QueryString.Item("ID"))
            'objProgramacion.Fecha_Modificacion = Now
            'objProgramacion.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text
            'objProgramacion.Fecha_Modificacion = Now
            'objProgramacion.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text

        Else
            objProgramacion = New ProgramacionBrl
            objProgramacion.Fecha = Today
            ''objProgramacion.Fecha_Creacion = Now
            ''objProgramacion.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
            objProgramacion.Id_Estado = 213 ' estado de abierto
        End If


        objProgramacion.Fecha = rdpFechaRadicacion.DbSelectedDate
        objProgramacion.Id_Regional = ddl_regional.SelectedValue
        objProgramacion.Id_LugarEntrega = ddl_LugarFuente.SelectedValue
        objProgramacion.Numero = Txt_Numero_Registro.Text
        objProgramacion.Id_TipoEntrega = ddl_tipoEntrega.SelectedValue
        objProgramacion.Id_Bodega = ddl_bodegas.SelectedValue
        objProgramacion.Guardar()
        Return objProgramacion.ID

    End Function

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim objProgramacion As ProgramacionBrl

        Try
            If Request.QueryString.Item("Editar") = 1 Then
                objProgramacion = ProgramacionBrl.CargarPorID(Request.QueryString.Item("ID"))
                If objProgramacion.Id_Estado = 213 Then
                    objProgramacion.Eliminar()
                    Response.Redirect("Programacion.aspx?Mensaje=1")
                Else
                    lblMensaje.Text = "Este registro de Programación no se puede eliminar !!!!! Ya avanzo el proceso.."
                End If
            End If
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/ProgramacionList.aspx")
    End Sub

    Protected Sub btn_nuevo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_nuevo.Click
        Response.Redirect("../webforms/Programacion.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        If Request.QueryString.Item("Id") > 0 Then
            Response.Redirect("../webforms/Programacion.aspx?Editar=1&Id=" + Request.QueryString.Item("Id"))
        Else
            btn_nuevo_Click(sender, e)
        End If
    End Sub

    Protected Sub btn_activar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnactivar.Click

        lblMensaje.Visible = False
        If Request.QueryString.Item("Editar") = 1 Then
            Dim objProgramacion As ProgramacionBrl
            Dim wcantprogramas As Integer = 0
            Dim wcantactivas As Integer = 0
            '
            ' Validando si se debe dejar activar
            '
            Dim ListProgramacion As List(Of ProgramacionBrl) = ProgramacionBrl.Cargarbusqueda(ddl_regional.SelectedValue, ddl_LugarFuente.SelectedValue, 0, "", "")
            For Each fila As ProgramacionBrl In ListProgramacion
                ' If fila.Id_Estado = 214 Then wcantactivas += 1
                Select Case fila.Id_Estado
                    Case 214
                        wcantactivas += 1
                    Case 215, 216
                        wcantprogramas += 1
                End Select
            Next

            ' validando por estado activado

            If wcantactivas > 2 Then ' limite de solo dos programaciones activas por regional y lugar de entrega ' 
                lblMensaje.Text = "Es imposible Activar esta programación ya que hay demasiados programaciones activas.!!!! "
                lblMensaje.Visible = True
                Exit Sub
            End If


            If wcantprogramas > 2 Then ' Sigue abierto algun programa sin legalizar ' 
                lblMensaje.Text = "Es imposible Activar esta programación ya que hay algun grupo de programación sin Cerrar.!!!! "
                lblMensaje.Visible = True
                Exit Sub
            End If

            '
            ' Validando la existencia de productos en la bodega.
            '
            Dim wcantidad As Double = 0
            Dim wexistencia As Double = 0
            Dim wpasovalidacion As Boolean = True
            'Dim ListBodegas As List(Of SubTablasBrl) = SubTablasBrl.CargarPorId_TablaPadre(31, ddl_regional.SelectedValue)

            Dim ListDeclaracionEstados As New List(Of Declaracion_EstadosBrl)
            ListDeclaracionEstados = Declaracion_EstadosBrl.CargarPorId_Programa(Request.QueryString.Item("Id"))
            Dim wtipovalido As Boolean
            For Each fila As Declaracion_EstadosBrl In ListDeclaracionEstados
                Dim ListRaciones As List(Of RacionesBrl)
                ListRaciones = RacionesBrl.CargarRaciones(Now().ToString, ddl_LugarFuente.SelectedValue, ddl_tipoEntrega.SelectedValue)
                For Each racion As RacionesBrl In ListRaciones
                    wtipovalido = False
                    For Each raciontipo As Raciones_TiposBrl In racion.Raciones_Tipos
                        If raciontipo.Tipo = fila.Declaracion.TipoFamiliaxaEmpacar Then
                            wtipovalido = True
                            Exit For
                        End If
                    Next
                    wcantidad = 0
                    If wtipovalido Then
                        If racion.Por_Familia Then
                            wcantidad = racion.Cantidad
                        End If
                        If racion.Por_Persona Then
                            wcantidad = racion.Cantidad * fila.Declaracion.TipoFamiliaxaEmpacar
                        End If
                        Dim EntradasDistribucion As List(Of Entradas_DistribucionBrl) = Entradas_DistribucionBrl.CargarPorId_BodegayId_Producto(ddl_bodegas.SelectedValue, racion.Id_Producto)

                        wexistencia = 0
                        For Each entdis As Entradas_DistribucionBrl In EntradasDistribucion
                            wexistencia += (entdis.Cantidad - Salidas_Detalle_EntradasBrl.CantidadSalida(entdis.ID))
                        Next
                        If wexistencia < wcantidad Then
                            lblMensaje.Text = "El producto : " + racion.Producto.Descripcion + " no tiene la cantidad en bodega para su entrega."
                            lblMensaje.ForeColor = Drawing.Color.Red
                            wpasovalidacion = False
                        End If

                    End If

                Next
            Next

            If Not wpasovalidacion Then
                lblMensaje.Visible = True
                Exit Sub
            End If

            '
            ' Creando el registro de productos por persona en la programacion
            '

            ''Dim ListDeclaracionEstados As New List(Of Declaracion_EstadosBrl)
            ListDeclaracionEstados = Declaracion_EstadosBrl.CargarPorId_Programa(Request.QueryString.Item("Id"))
            ''Dim wtipovalido As Boolean
            For Each fila As Declaracion_EstadosBrl In ListDeclaracionEstados
                Dim objpersonasentrega As Personas_EntregasBrl

                Dim ListRaciones As List(Of RacionesBrl)
                ListRaciones = RacionesBrl.CargarRaciones(Now().ToString, ddl_LugarFuente.SelectedValue, ddl_tipoEntrega.SelectedValue)
                For Each racion As RacionesBrl In ListRaciones
                    wtipovalido = False
                    For Each raciontipo As Raciones_TiposBrl In racion.Raciones_Tipos
                        If raciontipo.Tipo = fila.Declaracion.TipoFamiliaxaEmpacar Then
                            wtipovalido = True
                            Exit For
                        End If
                    Next
                    If wtipovalido Then
                        objpersonasentrega = New Personas_EntregasBrl
                        objpersonasentrega.Id_Persona = fila.Declaracion.Personas_Declarante.ID
                        objpersonasentrega.Id_Programa = fila.Id_Programa
                        objpersonasentrega.Id_Producto = racion.Id_Producto
                        objpersonasentrega.Id_Unidad = racion.Id_Capacidad
                        If racion.Por_Familia Then
                            objpersonasentrega.Cantidad = racion.Cantidad
                        End If
                        If racion.Por_Persona Then
                            objpersonasentrega.Cantidad = racion.Cantidad * fila.Declaracion.TipoFamiliaxaEmpacar
                        End If
                        objpersonasentrega.Guardar()

                    End If
                Next
            Next

            '
            ' Creando el registro de Salida de Mercancia
            '

            ' Creando la salida
            '
            Dim objsalidas As New SalidasBrl
            objsalidas.Id_Tipo_Salida = 3274
            objsalidas.Fecha_Creacion = Now
            objsalidas.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
            objsalidas.Tipo = "A"  ' Tipo Automatico
            objsalidas.Legalizado = 0
            objsalidas.Numero = Txt_Numero_Registro.Text + Left(ddl_tipoEntrega.Text.Trim, 1)
            objsalidas.Fecha = Now
            objsalidas.Nombre_Entrega = CType(Master.FindControl("LblNombreUsuario"), Label).Text
            objsalidas.Id_Regional = ddl_regional.SelectedValue
            objsalidas.Id_Bodega = ddl_bodegas.SelectedValue
            objsalidas.Id_Tipo_Entrega = ddl_tipoEntrega.SelectedValue
            objsalidas.Observacion = "Salida Automática de " + Txt_Numero_Registro.Text
            objsalidas.Dias_Entrega = 0
            objsalidas.Id_Programa = Request.QueryString.Item("Id")
            '
            ' Creando los registros de la salida
            '
            Dim ds As DataSet = Personas_EntregasDAL.CargarPorCantidadesEntrega(Request.QueryString.Item("Id"))
            Dim wsaldo As Double = 0
            Dim wcantidaddescargar As Double = 0

            Dim ListDetalleSalidas As New List(Of Salidas_DetalleBrl)
            Dim objDetalleSalidas As Salidas_DetalleBrl
            Dim ListEntradaDetalleSalidas As List(Of Salidas_Detalle_EntradasBrl)
            Dim objEntradaDetalleSalidas As Salidas_Detalle_EntradasBrl
            For Each fila As DataRow In ds.Tables(0).Rows
                objDetalleSalidas = New Salidas_DetalleBrl
                objDetalleSalidas.Id_Producto = fila(0)
                objDetalleSalidas.Id_Capacidad = fila(1)
                objDetalleSalidas.Cantidad = fila(2)
                objDetalleSalidas.Fecha_Creacion = Now
                objDetalleSalidas.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text


                ' Desagregar en las entradas de distribucion

                Dim EntradasDistribucion As List(Of Entradas_DistribucionBrl) = Entradas_DistribucionBrl.CargarPorId_BodegayId_Producto(ddl_bodegas.SelectedValue, fila(0))
                wsaldo = 0
                wcantidaddescargar = fila(2)
                ListEntradaDetalleSalidas = New List(Of Salidas_Detalle_EntradasBrl)
                For Each entdis As Entradas_DistribucionBrl In EntradasDistribucion
                    wsaldo = entdis.Cantidad - Salidas_Detalle_EntradasBrl.CantidadSalida(entdis.ID)
                    If wsaldo > 0 Then ' VERIFICAMOS SI HAY SALDO
                        ' creamos la descarga
                        objEntradaDetalleSalidas = New Salidas_Detalle_EntradasBrl
                        objEntradaDetalleSalidas.Id_Entrada_Distribucion = entdis.ID
                        If wcantidaddescargar <= wsaldo Then
                            objEntradaDetalleSalidas.Cantidad = wcantidaddescargar
                        Else
                            objEntradaDetalleSalidas.Cantidad = wsaldo
                        End If
                        objEntradaDetalleSalidas.Fecha_Creacion = Now
                        objEntradaDetalleSalidas.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
                        wcantidaddescargar -= objEntradaDetalleSalidas.Cantidad
                        ListEntradaDetalleSalidas.Add(objEntradaDetalleSalidas)
                    End If
                    If wcantidaddescargar <= 0 Then Exit For
                Next
                objDetalleSalidas.Salidas_Detalle_Entradas = ListEntradaDetalleSalidas
                ListDetalleSalidas.Add(objDetalleSalidas)

            Next
            objsalidas.Salidas_Detalle = ListDetalleSalidas
            objsalidas.Guardar()

            '
            ' Activando el grupo
            '

            objProgramacion = ProgramacionBrl.CargarPorID(Request.QueryString.Item("ID"))
            If objProgramacion.Id_Estado = 213 Then
                objProgramacion.Id_Estado = 214 ' PASAR A ACTIVO
            End If
            objProgramacion.Guardar()

            '
            lblMensaje.Text = "Orden de Salida, Planilla y Distribución de Alimentos en Programa Activado se genero con exito !!!"
            lblMensaje.Visible = True


            btn_actualizar_Click(Nothing, Nothing)
        End If

    End Sub

    Protected Sub btnAsignar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAsignar.Click
        Dim objprogramacion As ProgramacionBrl = ProgramacionBrl.CargarPorID(Request.QueryString.Item("id"))
        If objprogramacion.Id_Grupo = 0 Then
            BindHelper.SubTablasUIL.BindToListControlPorGruposSinAsignar(ddl_grupos, ddl_LugarFuente.SelectedValue, New ListItem("Seleccione", 0))
            ddl_grupos.Visible = True
            lbl_GrupoFijo.Visible = False
        Else
            lbl_GrupoFijo.Text = objprogramacion.Grupo.Descripcion
            ddl_grupos.Visible = False
            lbl_GrupoFijo.Visible = True
        End If
        pnl_asignar.Visible = True
        Dim ListDeclaracionEstados As List(Of Declaracion_EstadosBrl)
        ListDeclaracionEstados = Declaracion_EstadosBrl.CargarPorId_Programa(Request.QueryString.Item("Id"))
        Session("ListDeclaracionEstados") = ListDeclaracionEstados
        Rg_Listado.DataSource = Session("ListDeclaracionEstados")
        Rg_Listado.DataBind()

    End Sub

    Protected Sub Rg_Listado_NeedDataSource(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Listado.NeedDataSource
        Rg_Listado.DataSource = Session("ListDeclaracionEstados")
    End Sub

    Protected Sub Rg_Listado_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles Rg_Listado.ItemDataBound
        If e.Item.ItemType = GridItemType.AlternatingItem Or e.Item.ItemType = GridItemType.Item Then
            Dim lbl_IdDeclaracion As Label
            lbl_IdDeclaracion = e.Item.FindControl("lbl_IdDeclaracion")
            Dim objdeclaracion As DeclaracionBrl = DeclaracionBrl.CargarPorID(lbl_IdDeclaracion.Text)
            Dim Lbl_IdPersona As Label
            Lbl_IdPersona = e.Item.FindControl("Lbl_IdPersona")


            Dim chb_encuesta As CheckBox
            chb_encuesta = e.Item.FindControl("chb_encuesta")
            chb_encuesta.Checked = False
            If ddl_tipoEntrega.SelectedValue = 72 Then ' busca primera entrega
                If objdeclaracion.Id_Tipo_Adiccion <> 0 Then
                    chb_encuesta.Checked = True
                End If
            End If

            If ddl_tipoEntrega.SelectedValue = 918 Then ' busca segunda entrega
                If objdeclaracion.Declaracion_Seguimientos.Count > 0 Then
                    For Each fila As Declaracion_SeguimientosBrl In objdeclaracion.Declaracion_Seguimientos
                        If fila.Id_Tipo_Entrega = 918 Then
                            chb_encuesta.Checked = True
                        End If
                    Next
                End If
            End If

            If (ddl_tipoEntrega.SelectedValue = 3695) Or (ddl_tipoEntrega.SelectedValue = 920) Then ' entregas especiales
                Dim listentregas_Adicionales_personas As List(Of Entregas_Adicionales_PersonasBrl) = Entregas_Adicionales_PersonasBrl.CargarPorId_Entrega_Adicional(lbl_IdEntregaAdicional.Text)
                FilterHelper.FilterHelper(listentregas_Adicionales_personas, "Id_Persona", Lbl_IdPersona.Text)
                If listentregas_Adicionales_personas.Count > 0 Then
                    If listentregas_Adicionales_personas.Item(0).Id_Declaracion_Seguimiento > 0 Then
                        chb_encuesta.Checked = True
                    End If
                End If

            End If
        End If

        If e.Item.ItemType = GridItemType.Header Then
            Dim ddl_ProgramasTodosLibres As DropDownList
            ddl_ProgramasTodosLibres = e.Item.FindControl("ddl_ProgramasTodosLibres")
            BindHelper.ProgramacionUIL.BindToListControlPorId_Estado(ddl_ProgramasTodosLibres, 213, New ListItem("Seleccione", 0))
        End If
    End Sub

    Protected Sub chb_asistioChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim chb_asistio As CheckBox
        chb_asistio = CType(sender, CheckBox)
        Dim witem As GridDataItem = CType(CType(sender, CheckBox).NamingContainer, GridItem)
        Dim ddl_Programaslibres As DropDownList
        Dim lbldobleprogramacion As Label
        ddl_Programaslibres = witem.FindControl("ddl_Programaslibres")
        lbldobleprogramacion = witem.FindControl("lbldobleprogramacion")
        ddl_Programaslibres.CssClass = "drop01"
        BindHelper.ProgramacionUIL.BindToListControlPorId_Estado(ddl_Programaslibres, 213, New ListItem("Seleccione", 0))
        '
        Dim lblid As Label
        lblid = witem.FindControl("lblid")
        Dim objestado As Declaracion_EstadosBrl = Declaracion_EstadosBrl.CargarPorID(lblid.Text)


        If chb_asistio.Checked = False Then 'No asistio
            ddl_Programaslibres.SelectedValue = 0
            ddl_Programaslibres.Visible = False
            ' verificamos si hay segunda reprogramacion

            lbldobleprogramacion.Visible = True
            If objestado.Id_Tipo_Estado = 4038 Then ' es programado
                lbldobleprogramacion.Text = "Pasa a Reprogramación"
            Else
                If objestado.Id_Tipo_Estado = 4050 Then
                    lbldobleprogramacion.Text = "Deberá Crearse nuevo Programa de Entrega Especial."
                Else
                    ' es reprogramado
                    If ddl_tipoEntrega.SelectedValue = 72 Then
                        lbldobleprogramacion.Text = "Declarante Excluido !!!"
                    Else
                        lbldobleprogramacion.Text = "Pasa a Reprogramación nuevamente"
                    End If
                End If
            End If
        Else ' Asistio
            If ddl_tipoEntrega.SelectedValue = 72 Then
                ddl_Programaslibres.Visible = True
                lbldobleprogramacion.Visible = False
            Else
                lbldobleprogramacion.Visible = True
                lbldobleprogramacion.Text = "Fin !!!!"
            End If
        End If
    End Sub

    Protected Sub chb_asistiotodosChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim chb_asistiotodos As CheckBox = CType(sender, CheckBox)
        For Each dataItem As GridDataItem In Rg_Listado.MasterTableView.Items
            CType(dataItem.FindControl("chb_asistio"), CheckBox).Checked = chb_asistiotodos.Checked
            If dataItem.ItemType = GridItemType.AlternatingItem Or dataItem.ItemType = GridItemType.Item Then
                chb_asistioChanged(CType(dataItem.FindControl("chb_asistio"), CheckBox), Nothing)
            End If

        Next
    End Sub

    Protected Sub CargarATodosClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim btn_ok As Button = CType(sender, Button)
        Dim ddl_todos As DropDownList
        ddl_todos = CType(btn_ok.Parent.Parent, GridHeaderItem).FindControl("ddl_ProgramasTodosLibres")
        Dim chb_asistio As CheckBox
        For Each dataItem As GridDataItem In Rg_Listado.MasterTableView.Items
            If dataItem.ItemType = GridItemType.AlternatingItem Or dataItem.ItemType = GridItemType.Item Then
                chb_asistio = CType(dataItem.FindControl("chb_asistio"), CheckBox)
                If chb_asistio.Checked Then
                    If ddl_tipoEntrega.SelectedValue = 72 Then
                        CType(dataItem.FindControl("ddl_Programaslibres"), DropDownList).SelectedValue = ddl_todos.SelectedValue
                    Else
                        CType(dataItem.FindControl("ddl_Programaslibres"), DropDownList).SelectedValue = 0
                    End If
                End If
            End If
        Next
    End Sub

    Protected Sub chb_aprobotodosChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim chb_aprobotodos As CheckBox = CType(sender, CheckBox)
        For Each dataItem As GridDataItem In Rg_Listado.MasterTableView.Items
            CType(dataItem.FindControl("chb_aprobo"), CheckBox).Checked = chb_aprobotodos.Checked
        Next
    End Sub

    Protected Sub btnGrabarTodo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGrabarTodo.Click
        'Iniciamos Validaciones
        If ddl_grupos.Visible Then
            If ddl_grupos.SelectedValue = 0 Then
                lblMensaje.Text = "Falta Seleccionar Grupo. Revise Por Favor !!!!"
                lblMensaje.Visible = True
                Exit Sub
            End If
        End If
        Dim wasistio As Boolean = True
        Dim wencuesta As Boolean = True
        Dim waprobado As Boolean = True
        lblMensaje.Text = ""
        Dim chb_asistio As CheckBox
        Dim chb_encuesta As CheckBox
        Dim chb_aprobo As CheckBox
        Dim ddl_programaslibres As DropDownList
        Dim lbldobleprogramacion As Label
        For Each fila As GridDataItem In Rg_Listado.MasterTableView.Items
            chb_asistio = CType(fila.FindControl("chb_asistio"), CheckBox)
            chb_encuesta = CType(fila.FindControl("chb_encuesta"), CheckBox)
            chb_aprobo = CType(fila.FindControl("chb_aprobo"), CheckBox)
            lbldobleprogramacion = CType(fila.FindControl("lbldobleprogramacion"), Label)
            ddl_programaslibres = CType(fila.FindControl("ddl_programaslibres"), DropDownList)
            If chb_asistio.Checked Then
                If ddl_tipoEntrega.SelectedValue = 72 Then
                    If ddl_programaslibres.SelectedValue = 0 Then
                        wasistio = False
                    End If
                End If
            End If
            If ddl_tipoEntrega.SelectedValue <> 920 Then
                If chb_encuesta.Checked = False Then
                    If chb_asistio.Checked = True Then
                        wencuesta = False
                    End If
                End If
            End If
            If chb_aprobo.Checked = False Then
                waprobado = False
            End If
        Next
        If wasistio = False Then
            lblMensaje.Text = "Falta Seleccionar la programación de Segunda entrega. Revise Por Favor !!!!"
            lblMensaje.Visible = True
            Exit Sub
        End If
        If wencuesta = False Then
            lblMensaje.Text = "Falta Ingresar una encuesta del registro de Programación. Revise Por Favor !!!!"
            lblMensaje.Visible = True
            Exit Sub
        End If
        If waprobado = False Then
            lblMensaje.Text = "Falta aprobar algun registro de Programación. Revise Por Favor !!!!"
            lblMensaje.Visible = True
            Exit Sub
        End If


        '
        ' Inicia Proceso de Grabacion
        '

        Dim objestadodeclaracion As New Declaracion_EstadosBrl
        Dim objprogramacion As ProgramacionBrl
        Dim lbl_IdDeclaracion As Label
        Dim lblid As Label
        Dim objdeclaracion As DeclaracionBrl
        '
        '  Ajusto declaraciones
        '  Ajusto estados de declarantes de reprogramacion

        For Each fila As GridDataItem In Rg_Listado.MasterTableView.Items
            lblid = CType(fila.FindControl("lblid"), Label)
            lbl_IdDeclaracion = CType(fila.FindControl("lbl_IdDeclaracion"), Label)
            chb_asistio = CType(fila.FindControl("chb_asistio"), CheckBox)
            lbldobleprogramacion = CType(fila.FindControl("lbldobleprogramacion"), Label)
            ddl_programaslibres = CType(fila.FindControl("ddl_programaslibres"), DropDownList)
            objdeclaracion = DeclaracionBrl.CargarPorID(lbl_IdDeclaracion.Text)
            '
            objestadodeclaracion = Declaracion_EstadosBrl.CargarPorID(lblid.Text)
            If chb_asistio.Checked Then

                objestadodeclaracion.Id_Asistio = 19
                objestadodeclaracion.Guardar()

                If ddl_tipoEntrega.SelectedValue = 72 Then
                    objdeclaracion.Id_Atender = 19
                    objdeclaracion.Id_Grupo = ddl_grupos.SelectedValue
                    objdeclaracion.Id_Motivo_Noatender = Nothing
                    objprogramacion = ProgramacionBrl.CargarPorID(ddl_programaslibres.SelectedValue)
                    '
                    ' Creo la programacion de Segunda Entrega
                    '
                    objestadodeclaracion = New Declaracion_EstadosBrl
                    objestadodeclaracion.Fecha = objprogramacion.Fecha
                    objestadodeclaracion.Id_Declaracion = lbl_IdDeclaracion.Text
                    objestadodeclaracion.Id_Tipo_Estado = 4038
                    objestadodeclaracion.Id_Como_Estado = 19
                    objestadodeclaracion.Fecha_Creacion = Now
                    objestadodeclaracion.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
                    objestadodeclaracion.Id_Programa = ddl_programaslibres.SelectedValue
                    objestadodeclaracion.Guardar()

                    '
                    '  Asignando el grupo a la segunda entrega en la programacion
                    '
                    objprogramacion.Id_Grupo = ddl_grupos.SelectedValue
                    objprogramacion.Guardar()


                End If

            Else

                objestadodeclaracion.Id_Asistio = 20
                objestadodeclaracion.Guardar()

                If ddl_tipoEntrega.SelectedValue = 72 Then

                    If objestadodeclaracion.Id_Tipo_Estado = 4038 Then
                        objdeclaracion.Id_Motivo_Noatender = 1117 ' programado que no asistio
                    End If
                    If objestadodeclaracion.Id_Tipo_Estado = 4039 Then
                        objdeclaracion.Id_Motivo_Noatender = 4548 ' reprogramado que no asistio
                        objdeclaracion.Id_Atender = 20
                    End If

                End If

            End If
            objdeclaracion.Guardar()
        Next


        '  Ajusto el estado de la programacion al grupo de primera entrega

        objprogramacion = ProgramacionBrl.CargarPorID(Request.QueryString.Item("ID"))
        If objprogramacion.Id_Estado = 214 Then
            objprogramacion.Id_Estado = 215 ' PASAR A ASIGNADO
            Select Case ddl_tipoEntrega.SelectedValue
                Case Is = 72, 920, 3695  'PE, EE, EV
                    objprogramacion.Id_Grupo = ddl_grupos.SelectedValue
            End Select

        End If
        objprogramacion.Guardar()

        '
        ' Asignar el grupo a la salida o salidas (si aplica)
        '
        Try
            Dim objsalida As List(Of SalidasBrl) = SalidasBrl.CargarPorId_Programa(Request.QueryString.Item("ID"))
            For Each fila As SalidasBrl In objsalida
                fila.Id_Reg_Grupo = objprogramacion.Id_Grupo
                fila.Guardar()
            Next
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

        ' FIN
        Response.Redirect("Programacion.aspx?Mensaje=2")

    End Sub

    Protected Sub ddl_regional_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddl_regional.SelectedIndexChanged
        If ddl_regional.SelectedValue > 0 Then
            BindHelper.SubTablasUIL.BindToListControlPorId_TablaPadre(ddl_LugarFuente, 73, ddl_regional.SelectedValue, New ListItem("Seleccione", 0))
            BindHelper.SubTablasUIL.BindToListControlPorId_TablaPadre(ddl_bodegas, 31, ddl_regional.SelectedValue, New ListItem("Seleccione", 0))

        Else
            BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_LugarFuente, 73, New ListItem("Seleccione", 0))
            BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_bodegas, 31, New ListItem("Seleccione", 0))
        End If
    End Sub

End Class
