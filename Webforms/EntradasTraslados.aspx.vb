﻿Imports ingNovar.Utilidades2
Imports System.Collections.Generic
Imports Telerik.Web.UI

Partial Class WebForms_EntradasTraslados
    Inherits System.Web.UI.Page

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


        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Regional_Envio, 72, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Regional, 72, New ListItem("Seleccione", 0))

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Productos, 32, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_capacidad, 33, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_bodegas, 31, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Bodega_Ingresar, 31, New ListItem("Seleccione", 0))

        Dim ListDetalleEntradas As List(Of Entradas_DetalleBrl) = Session("ListDetalleEntradasDonaciones")
        btn_nuevo.Enabled = False
        LblId.Text = ""

        If Request.QueryString.Item("Editar") = 1 Then
            Dim objEntradas As EntradasBrl = EntradasBrl.CargarPorID(Request.QueryString.Item("ID"))

            If objEntradas Is Nothing Then
                lblMensaje.Text = "Registro no existe"
                lblMensaje.Visible = True
                Exit Sub
            End If

            txtNumero_Entrada.Text = objEntradas.Numero_Entrada
            rdpfecha.SelectedDate = objEntradas.Fecha
            If ddl_Regional.Items.FindByValue(objEntradas.Id_Regional) IsNot Nothing Then ddl_Regional.SelectedValue = objEntradas.Id_Regional
            ddl_Regional_SelectedIndexChanged(Nothing, Nothing)
            If ddl_Salidas.Items.FindByValue(objEntradas.Id_Salida_Traslado) IsNot Nothing Then ddl_Salidas.SelectedValue = objEntradas.Id_Salida_Traslado
            If ddl_Regional_Envio.Items.FindByValue(objEntradas.Id_Regional_Envia) IsNot Nothing Then ddl_Regional_Envio.SelectedValue = objEntradas.Id_Regional_Envia
            'If ddlUsuarios.Items.FindByValue(objEntradas.Id_Usuario_Recibio) IsNot Nothing Then ddlUsuarios.SelectedValue = objEntradas.Id_Usuario_Recibio
            txtNombre_Entrego.Text = objEntradas.Nombre_Entrego
            txtNombre_Recibe.Text = objEntradas.Identificacion_Entrego
            txtObservacion.Text = objEntradas.Observacion
            Try
                ddl_Bodega_Ingresar.SelectedValue = Int(objEntradas.Numero_Factura_Proveedor)
            Catch ex As Exception
            End Try

            LblId.Text = objEntradas.ID

            ListDetalleEntradas = objEntradas.Entradas_Detalle
            Session("ListDetalleEntradasTraslados") = ListDetalleEntradas

            btn_nuevo.Enabled = True

            Rg_Listado.DataSource = Session("ListDetalleEntradasTraslados")
            Rg_Listado.DataBind()
        End If
        lbl_Recibido.Text = CType(Master.FindControl("LblNombreUsuario"), Label).Text
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Validate("FACT")
        If Not IsValid Then Exit Sub

        Dim ID As Int32

        Try
            ID = Grabar()
            Response.Redirect("EntradasTraslados.aspx?Editar=1&Mensaje=1&ID=" & ID)
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Private Sub btnGuardarOtro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarOtro.Click
        Validate("FACT")
        If Not IsValid Then Exit Sub

        Try
            Grabar()
            Response.Redirect("EntradasTraslados.aspx?Mensaje=1")
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Private Function Grabar() As Int32

        Dim objEntradas As EntradasBrl

        If Request.QueryString.Item("Editar") = 1 Then
            objEntradas = EntradasBrl.CargarPorID(Request.QueryString.Item("ID"))
            objEntradas.Fecha_Modificacion = Now
            objEntradas.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text
        Else
            objEntradas = New EntradasBrl
            objEntradas.Fecha_Creacion = Now
            objEntradas.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
            objEntradas.Id_Tipo_Entrada = 3272 ' por codigo de subtablas Entradas de traslados

        End If

        objEntradas.Numero_Entrada = txtNumero_Entrada.Text
        objEntradas.Fecha = rdpfecha.SelectedDate
        objEntradas.Id_Regional = ddl_Regional.SelectedValue
        objEntradas.Id_Salida_Traslado = ddl_Salidas.SelectedValue
        objEntradas.Id_Regional_Envia = ddl_Regional_Envio.SelectedValue
        objEntradas.Id_Usuario_Recibio = CType(Master.FindControl("lblidusuario"), Label).Text
        objEntradas.Nombre_Entrego = txtNombre_Entrego.Text
        objEntradas.Identificacion_Entrego = txtNombre_Recibe.Text ' Caso especial tenerlo en cuenta
        objEntradas.Observacion = txtObservacion.Text
        objEntradas.Numero_Factura_Proveedor = ddl_Bodega_Ingresar.SelectedValue.ToString


        ' Grabar los productos de entrada del traslado y a su vez la division contra valoracion de inventario
        If objEntradas.ID = 0 Then  ' solo para nuevos
            Dim objsalida As SalidasBrl = SalidasBrl.CargarPorID(ddl_Salidas.SelectedValue)

            Dim ListDetalleEntradas As New List(Of Entradas_DetalleBrl)
            For Each fila As Salidas_DetalleBrl In objsalida.Salidas_Detalle

                For Each fila1 As Salidas_Detalle_EntradasBrl In fila.Salidas_Detalle_Entradas
                    Dim objdetalle As New Entradas_DetalleBrl
                    objdetalle.Id_Producto = fila.Id_Producto
                    objdetalle.Id_Capacidad = fila.Id_Capacidad
                    objdetalle.Cantidad = fila1.Cantidad
                    objdetalle.Valor_Unitario = fila1.Entrada_Distribucion.Entradas_Detalle.Valor_Unitario
                    objdetalle.Valor_Descuento = fila1.Entrada_Distribucion.Entradas_Detalle.Valor_Descuento
                    objdetalle.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
                    objdetalle.Fecha_Vencimiento = fila1.Entrada_Distribucion.Entradas_Detalle.Fecha_Vencimiento
                    objdetalle.Fecha_Creacion = Now

                    ' Creando la distribucion del traslado en la bodega

                    Dim objdistribucion As New Entradas_DistribucionBrl
                    objdistribucion.Id_Bodega = ddl_Bodega_Ingresar.SelectedValue
                    objdistribucion.Cantidad = fila1.Cantidad
                    objdistribucion.Id_Capacidad = fila1.Salidas_Detalle.Id_Capacidad
                    objdistribucion.Observacion = "Entrega por Traslado"
                    objdistribucion.Fecha_Creacion = Now
                    objdistribucion.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text

                    objdetalle.Entradas_Distribucion.Add(objdistribucion)
                    ListDetalleEntradas.Add(objdetalle)
                Next
            Next
            objEntradas.Entradas_Detalle = ListDetalleEntradas

        End If

        objEntradas.Guardar()

        LblId.Text = objEntradas.ID
        Return objEntradas.ID

    End Function

    Protected Sub btn_nuevo_Producto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_nuevo_Producto.Click
        lblMensaje.Visible = False
        If LblId.Text = "" Then
            lblMensaje.Text = "No puedes ingresar productos sin ingresar los datos iniciales del documento de entrada.!"
            lblMensaje.Visible = True
            lblMensaje.ForeColor = Drawing.Color.Red
            Exit Sub
        End If
        pnl_producto.Visible = Not (pnl_producto.Visible)
        btn_limpiar_Click(Nothing, Nothing)
    End Sub

    Protected Sub btn_limpiar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        ddl_Productos.SelectedValue = 0
        ddl_capacidad.SelectedValue = 0
        txtCantidad.Text = ""
        txtValor_Unitario.Text = ""
        lblIdProducto.Text = ""
        rdpFechaVencimiento.SelectedDate = Nothing
        '
        Dim ListAsignaciones As New List(Of Entradas_DistribucionBrl)
        ListAsignaciones = Entradas_DistribucionBrl.CargarPorId_Entrada_Detalle(0)
        Session("Asignaciones") = ListAsignaciones
        dgAsignacion.DataSource = Session("Asignaciones")
        dgAsignacion.DataBind()
        '
        btn_nuevaasignacion_Click(Nothing, Nothing)
    End Sub

    Protected Sub btn_nuevaasignacion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_nuevaasignacion.Click
        ddl_bodegas.SelectedValue = 0
        txt_cantidadbodega.Text = ""
        txt_observacionbodega.Text = ""
        lblIdAsignacion.Text = ""
    End Sub

    Protected Sub Rg_Listado_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Listado.NeedDataSource
        Rg_Listado.DataSource = Session("ListDetalleEntradasTraslados")
    End Sub

    Public Sub subCommandItem(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Select Case e.CommandName
            Case "EliminarProducto"
                subeliminarproducto(sender, e)
        End Select
    End Sub

    Public Sub subeliminarproducto(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Try
            Dim lblIdInterno As Label
            lblIdInterno = e.Item.FindControl("lblId")
            Dim objdetalle As Entradas_DetalleBrl = Entradas_DetalleBrl.CargarPorID(Val(lblIdInterno.Text))
            For Each fila As Entradas_DistribucionBrl In objdetalle.Entradas_Distribucion
                fila.Eliminar()
            Next

            For Each fila As Entradas_OrdenCompraBrl In objdetalle.Entradas_OrdenCompra
                fila.Eliminar()
            Next
            objdetalle = Entradas_DetalleBrl.CargarPorID(Val(lblIdInterno.Text))
            objdetalle.Eliminar()

            Dim ListProductosDetalle As List(Of Entradas_DetalleBrl)
            ListProductosDetalle = Entradas_DetalleBrl.CargarPorId_Entrada(Request.QueryString.Item("Id"))
            Session("ListDetalleEntradasTraslados") = ListProductosDetalle
            Rg_Listado.DataSource = Session("ListDetalleEntradasTraslados")
            Rg_Listado.DataBind()

        Catch ex As Exception
        End Try

    End Sub

    Public Sub subCommandItemAsignacion(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)
        Select Case e.CommandName
            Case "Edit"
                subEditarAsignacion(sender, e)
            Case "EliminarAsignacion"
                subeliminarasignacion(sender, e)
        End Select
    End Sub

    Public Sub subeliminarasignacion(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)
        Dim lblIdInterno As Label
        lblIdInterno = e.Item.FindControl("lblId")
        If lblIdInterno.Text.Trim <> "0" Then
            Dim objdistribucion As Entradas_DistribucionBrl = Entradas_DistribucionBrl.CargarPorID(lblIdInterno.Text)
            If objdistribucion IsNot Nothing Then
                Try
                    objdistribucion.Eliminar()
                Catch ex As Exception
                    Exit Sub
                End Try

            End If
        End If
        ' Elimina los registros en la vista del sistema
        '
        Dim indicefila As Integer = e.Item.ItemIndex
        Dim indicepagina As Integer = dgAsignacion.CurrentPageIndex
        Dim itemsporpagina As Integer = dgAsignacion.PageSize
        Dim elitem As Integer = (itemsporpagina * indicepagina) + indicefila

        Dim ListAsignaciones As New List(Of Entradas_DistribucionBrl)
        ListAsignaciones = CType(Session("Asignaciones"), List(Of Entradas_DistribucionBrl))
        ListAsignaciones.RemoveAt(elitem)
        Session("Asignaciones") = ListAsignaciones
        dgAsignacion.DataSource = Session("Asignaciones")
        dgAsignacion.DataBind()


    End Sub

    Public Sub subEditarAsignacion(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

        Dim ListAsignaciones As New List(Of Entradas_DistribucionBrl)
        ListAsignaciones = CType(Session("Asignaciones"), List(Of Entradas_DistribucionBrl))

        Dim indicefila As Integer = e.Item.ItemIndex
        Dim indicepagina As Integer = dgAsignacion.CurrentPageIndex
        Dim itemsporpagina As Integer = dgAsignacion.PageSize
        Dim elitem As Integer = (itemsporpagina * indicepagina) + indicefila
        Try
            ddl_bodegas.SelectedValue = ListAsignaciones.Item(elitem).Id_Bodega
        Catch ex As Exception
        End Try
        txt_cantidadbodega.Text = ListAsignaciones.Item(elitem).Cantidad
        txt_observacionbodega.Text = ListAsignaciones.Item(elitem).Observacion
        lblIdAsignacion.Text = ListAsignaciones.Item(elitem).ID

    End Sub

    Protected Sub Rg_Listado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rg_Listado.SelectedIndexChanged
        Dim item As Telerik.Web.UI.GridDataItem = Me.Rg_Listado.SelectedItems.Item(Rg_Listado.SelectedIndexes.Item(0))

        Dim objproducto As Entradas_DetalleBrl = Entradas_DetalleBrl.CargarPorID(item("id").Text)
        lblIdProducto.Text = objproducto.ID
        ddl_Productos.SelectedValue = objproducto.Id_Producto
        ddl_capacidad.SelectedValue = objproducto.Id_Capacidad
        txtCantidad.Text = objproducto.Cantidad
        txtValor_Unitario.Text = objproducto.Valor_Unitario
        rdpFechaVencimiento.SelectedDate = objproducto.Fecha_Vencimiento

        Session("Asignaciones") = objproducto.Entradas_Distribucion
        dgAsignacion.DataSource = Session("Asignaciones")
        dgAsignacion.DataBind()

        pnl_producto.Visible = True
        btn_nuevaasignacion_Click(Nothing, Nothing)

    End Sub

    Public Sub CambioPaginaAsignacion(ByVal sender As Object, ByVal e As DataGridPageChangedEventArgs) Handles dgAsignacion.PageIndexChanged
        dgAsignacion.CurrentPageIndex = e.NewPageIndex
        dgAsignacion.SelectedIndex = -1
        dgAsignacion.DataSource = Session("Asignaciones")
        dgAsignacion.DataBind()
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_GuardarAsgnacion.Click
        Validate("ASIG")
        If Not IsValid Then Exit Sub

        Dim ListAsignaciones As New List(Of Entradas_DistribucionBrl)
        ListAsignaciones = CType(Session("Asignaciones"), List(Of Entradas_DistribucionBrl))
        Dim objtempasignacion As Entradas_DistribucionBrl
        If lblIdAsignacion.Text = "" Then

            ' Crear Registro
            objtempasignacion = New Entradas_DistribucionBrl
            objtempasignacion.Cantidad = Val(txt_cantidadbodega.Text)
            objtempasignacion.Id_Bodega = Me.ddl_bodegas.SelectedValue
            objtempasignacion.Id_Capacidad = Me.ddl_capacidad.SelectedValue
            objtempasignacion.Observacion = Me.txt_observacionbodega.Text
            'objtempasignacion.ID = 0
            objtempasignacion.Fecha_Creacion = Now
            objtempasignacion.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
            ListAsignaciones.Add(objtempasignacion)
        Else

            'ListAsignaciones = CType(Session("Asignaciones"), List(Of Entradas_DistribucionBrl))
            For Each fila As Entradas_DistribucionBrl In ListAsignaciones
                If fila.ID = Val(lblIdAsignacion.Text) Then
                    fila.Cantidad = Val(txt_cantidadbodega.Text)
                    fila.Id_Bodega = ddl_bodegas.SelectedValue
                    fila.Observacion = txt_observacionbodega.Text
                    fila.Fecha_Modificacion = Now
                    fila.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text
                End If
            Next
        End If

        '
        Session("Asignaciones") = ListAsignaciones
        dgAsignacion.DataSource = Session("Asignaciones")
        dgAsignacion.DataBind()
        btn_nuevaasignacion_Click(Nothing, Nothing)
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_GuardarProducto.Click
        Validate("PROD")
        If Not IsValid Then Exit Sub
        lblMensaje.Visible = False
        ' validar la asignacion sea igual a la cantidad del producto

        Dim wvalor As Double = 0
        Dim ListAsignaciones As New List(Of Entradas_DistribucionBrl)
        ListAsignaciones = CType(Session("Asignaciones"), List(Of Entradas_DistribucionBrl))
        For Each fila As Entradas_DistribucionBrl In ListAsignaciones
            wvalor += fila.Cantidad
        Next
        If wvalor <> Val(txtCantidad.Text) Then
            lblMensaje.Text = "La cantidad de distribución no es igual a la comprada."
            lblMensaje.Visible = True
            lblMensaje.ForeColor = Drawing.Color.Red
            Exit Sub
        End If

        ' Creando el registro del producto

        Dim ProductoDetalle As Entradas_DetalleBrl
        If lblIdProducto.Text = "" Then
            ProductoDetalle = New Entradas_DetalleBrl
            ProductoDetalle.Fecha_Creacion = Now
            ProductoDetalle.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
        Else
            ProductoDetalle = Entradas_DetalleBrl.CargarPorID(lblIdProducto.Text)
            ProductoDetalle.Fecha_Modificacion = Now
            ProductoDetalle.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text
        End If
        ProductoDetalle.Cantidad = Val(txtCantidad.Text)
        ProductoDetalle.Id_Capacidad = ddl_capacidad.SelectedValue
        ProductoDetalle.Id_Entrada = LblId.Text
        ProductoDetalle.Id_Producto = ddl_Productos.SelectedValue
        ProductoDetalle.Valor_Unitario = Val(txtValor_Unitario.Text)
        ProductoDetalle.Valor_Descuento = 0

        Try
            ProductoDetalle.Fecha_Vencimiento = rdpFechaVencimiento.DbSelectedDate
        Catch ex As Exception
            ProductoDetalle.Fecha_Vencimiento = Nothing
        End Try

        ProductoDetalle.Entradas_Distribucion = ListAsignaciones
        ProductoDetalle.Guardar()

        '
        ' cargando los productos

        Dim ListProductosDetalle As List(Of Entradas_DetalleBrl)
        ListProductosDetalle = Entradas_DetalleBrl.CargarPorId_Entrada(Request.QueryString.Item("Id"))
        Session("ListDetalleEntradasTraslados") = ListProductosDetalle

        Rg_Listado.DataSource = Session("ListDetalleEntradasTraslados")
        Rg_Listado.DataBind()
        pnl_producto.Visible = False
        btn_limpiar_Click(Nothing, Nothing)

    End Sub

    Protected Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try

            Dim ListDetalle As New List(Of Entradas_DetalleBrl)
            ListDetalle = Entradas_DetalleBrl.CargarPorId_Entrada(Request.QueryString.Item("Id"))
            For Each detalle As Entradas_DetalleBrl In ListDetalle
                For Each fila As Entradas_DistribucionBrl In detalle.Entradas_Distribucion
                    fila.Eliminar()
                Next
            Next
            ListDetalle = Entradas_DetalleBrl.CargarPorId_Entrada(Request.QueryString.Item("Id"))
            For Each detalle As Entradas_DetalleBrl In ListDetalle
                detalle.Eliminar()
            Next

            Dim objentrada As EntradasBrl = EntradasBrl.CargarPorID(Request.QueryString.Item("Id"))
            For Each fila As Entradas_ImpuestosBrl In objentrada.Entradas_Impuestos
                fila.Eliminar()
            Next

            objentrada = EntradasBrl.CargarPorID(Request.QueryString.Item("Id"))
            objentrada.Eliminar()

            Response.Redirect("EntradasTrasladosList.aspx?Refrescar=1")
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Protected Sub ddl_Regional_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_Regional.SelectedIndexChanged
        If ddl_Regional.SelectedValue > 0 Then
            BindHelper.SalidasUIL.BindToListControlPorId_Reg_Grupo(ddl_Salidas, ddl_Regional.SelectedValue, New ListItem("Seleccione", 0))
            BindHelper.SubTablasUIL.BindToListControlPorId_TablaPadre(ddl_bodegas, 31, ddl_Regional.SelectedValue, New ListItem("Seleccione", 0))
        Else
            ddl_Salidas.Items.Clear()
            ddl_bodegas.Items.Clear()
        End If
    End Sub

    Protected Sub ddl_Salidas_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_Salidas.SelectedIndexChanged
        If ddl_Salidas.SelectedValue > 0 Then
            Dim objsalida As SalidasBrl = SalidasBrl.CargarPorID(ddl_Salidas.SelectedValue)
            If objsalida IsNot Nothing Then
                ddl_Regional_Envio.SelectedValue = objsalida.Id_Regional
                txtNombre_Recibe.Text = objsalida.Nombre_Salida
                txtNombre_Entrego.Text = objsalida.Nombre_Entrega
            End If
        Else
            ddl_Regional_Envio.SelectedValue = 0
            txtNombre_Recibe.Text = ""
            txtNombre_Entrego.Text = ""

        End If
    End Sub

    Protected Sub btn_nuevo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_nuevo.Click
        Response.Redirect("../webforms/EntradasTraslados.aspx")
    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/EntradasTrasladosList.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        If Request.QueryString.Item("Id") > 0 Then
            Response.Redirect("../webforms/EntradasTraslados.aspx?Editar=1&Id=" + Request.QueryString.Item("Id"))
        Else
            btn_nuevo_Click(sender, e)
        End If
    End Sub

End Class
