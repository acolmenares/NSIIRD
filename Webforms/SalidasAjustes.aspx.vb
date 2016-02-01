Imports ingNovar.Utilidades2
Imports System.Collections.Generic

Partial Class WebForms_SalidasAjustes
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

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Regional, 72, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Bodegas, 31, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Productos, 32, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_capacidad, 33, New ListItem("Seleccione", 0))

        Dim ListDetalleAjustes As List(Of Salidas_DetalleBrl) = Session("ListDetalleAjustes")

        btn_Nuevo_producto.Enabled = False
        pnl_aprobaciones.Visible = False
        LblId.Text = ""

        If Request.QueryString.Item("Editar") = 1 Then
            Dim objSalidas As SalidasBrl = SalidasBrl.CargarPorID(Request.QueryString.Item("ID"))

            If objSalidas Is Nothing Then
                lblMensaje.Text = "Registro no existe"
                lblMensaje.Visible = True
                Exit Sub
            End If

            txt_Numero.Text = objSalidas.Numero
            rdpfecha.SelectedDate = objSalidas.Fecha
            If ddl_Regional.Items.FindByValue(objSalidas.Id_Regional) IsNot Nothing Then ddl_Regional.SelectedValue = objSalidas.Id_Regional
            If ddl_Bodegas.Items.FindByValue(objSalidas.Id_Bodega) IsNot Nothing Then ddl_Bodegas.SelectedValue = objSalidas.Id_Bodega
            txtNombre_Entrego.Text = objSalidas.Nombre_Entrega
            txt_Nombre_Recibe.Text = objSalidas.Nombre_Salida
            txtObservacion.Text = objSalidas.Observacion
            LblId.Text = objSalidas.ID

            ' colocando las aprobaciones
            If objSalidas.Salidas_Aprobaciones.Item(0).Aprobacion_Logistica_Oficina Then
                Me.chk_AOL.Checked = True
            Else
                Me.chk_AOL.Checked = False
            End If

            If objSalidas.Salidas_Aprobaciones.Item(0).Aprobacion_Finanzas_Oficina Then
                Me.chk_AFO.Checked = True
            Else
                Me.chk_AFO.Checked = False
            End If

            If objSalidas.Salidas_Aprobaciones.Item(0).Aprobacion_Coordinador_Oficina Then
                Me.chk_ACO.Checked = True
            Else
                Me.chk_ACO.Checked = False
            End If

            If objSalidas.Salidas_Aprobaciones.Item(0).Aprobacion_Coordinador_Logistica Then
                Me.CHK_ACL.Checked = True
            Else
                Me.CHK_ACL.Checked = False
            End If

            If objSalidas.Salidas_Aprobaciones.Item(0).Aprobacion_Director_Financiero Then
                Me.CHK_ADF.Checked = True
            Else
                Me.CHK_ADF.Checked = False
            End If

            If objSalidas.Salidas_Aprobaciones.Item(0).Aprobacion_Director_Pais Then
                Me.Chk_ADP.Checked = True
            Else
                Me.Chk_ADP.Checked = False
            End If

            ListDetalleAjustes = objSalidas.Salidas_Detalle
            Session("ListDetalleAjustes") = ListDetalleAjustes
            btn_Nuevo_producto.Enabled = True
            pnl_aprobaciones.Visible = True
            Rg_Listado.DataSource = Session("ListDetalleAjustes")
            Rg_Listado.DataBind()

        End If


        btnGuardar.Visible = True
        btnGuardarOtro.Visible = True
        btnEliminar.Visible = True
        btn_limpiar.Visible = True
        btn_Guardar_Producto.Visible = True
        btn_Nuevo_producto.Visible = True


    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Validate("FACT")
        If Not IsValid Then Exit Sub

        Dim ID As Int32

        Try
            ID = Grabar()
            Response.Redirect("SalidasAjustes.aspx?Editar=1&Mensaje=1&ID=" & ID)
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
            Response.Redirect("SalidasAjustes.aspx?Mensaje=1")
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Private Function Grabar() As Int32

        Dim objsalidas As SalidasBrl
        Dim objaprobaciones As Salidas_AprobacionesBrl
        If Request.QueryString.Item("Editar") = 1 Then
            objsalidas = SalidasBrl.CargarPorID(Request.QueryString.Item("ID"))
            objsalidas.Fecha_Modificacion = Now
            objsalidas.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text
            objaprobaciones = objsalidas.Salidas_Aprobaciones.Item(0)
        Else
            objsalidas = New SalidasBrl
            objsalidas.Fecha_Creacion = Now
            objsalidas.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
            objsalidas.Tipo = "M"  ' Tipo Manual
            objsalidas.Id_Tipo_Salida = 3568 ' por codigo de subtablas ajustes
            objaprobaciones = New Salidas_AprobacionesBrl
            objsalidas.Legalizado = 0
        End If

        objsalidas.Numero = txt_Numero.Text
        objsalidas.Fecha = rdpfecha.SelectedDate
        objsalidas.Nombre_Entrega = txtNombre_Entrego.Text
        objsalidas.Nombre_Salida = txt_Nombre_Recibe.Text
        objsalidas.Id_Regional = ddl_Regional.SelectedValue
        objsalidas.Id_Bodega = ddl_Bodegas.SelectedValue
        objsalidas.Observacion = txtObservacion.Text
        If chk_AOL.Checked Then
            objaprobaciones.Aprobacion_Logistica_Oficina = True
        Else
            objaprobaciones.Aprobacion_Logistica_Oficina = False
        End If
        If objaprobaciones.ID = 0 Then
            objsalidas.Salidas_Aprobaciones.Add(objaprobaciones)
        End If

        objsalidas.Guardar()

        LblId.Text = objsalidas.ID
        Return objsalidas.ID

    End Function

    Protected Sub btn_nuevo_producto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Nuevo_producto.Click
        lblMensaje.Visible = False
        If LblId.Text = "" Then
            lblMensaje.Text = "No puedes ingresar productos sin ingresar los datos iniciales del documento.!"
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
        lblIdProducto.Text = ""
        '
        Dim ListEntradasDetalleSalidas As New List(Of Salidas_Detalle_EntradasBrl)
        ListEntradasDetalleSalidas = Salidas_Detalle_EntradasBrl.CargarPorId_Salida_Detalle(0)
        Session("EntradasAjustes") = ListEntradasDetalleSalidas
        dgEntradas.DataSource = Session("EntradasAjustes")
        dgEntradas.DataBind()
        '
        btn_nuevaentrada_Click(Nothing, Nothing)
    End Sub

    Protected Sub btn_nuevaentrada_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_nuevaAsignacion.Click
        ddl_entradas.SelectedValue = 0
        txt_cantidadentrada.Text = ""
        lblIdEntrada.Text = ""
    End Sub

    Public Sub subCommandItem(ByVal sender As Object, ByVal e As DataGridCommandEventArgs) '' Handles dgListado.ItemCommand
        Select Case e.CommandName
            Case "EliminarProducto"
                subeliminarproducto(sender, e)
        End Select
    End Sub


    Protected Sub Rg_Listado_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Listado.NeedDataSource
        Rg_Listado.DataSource = Session("ListEntradasTraslados")
    End Sub

    Public Sub subeliminarproducto(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)
        Try
            Dim lblIdInterno As Label
            lblIdInterno = e.Item.FindControl("lblId")
            Dim objdetalle As Salidas_DetalleBrl = Salidas_DetalleBrl.CargarPorID(Val(lblIdInterno.Text))
            For Each fila As Salidas_Detalle_EntradasBrl In objdetalle.Salidas_Detalle_Entradas
                fila.Eliminar()
            Next

            objdetalle = Salidas_DetalleBrl.CargarPorID(Val(lblIdInterno.Text))
            objdetalle.Eliminar()

            Dim ListDetalleAjustes As List(Of Salidas_DetalleBrl)
            ListDetalleAjustes = Salidas_DetalleBrl.CargarPorId_Salida(Request.QueryString.Item("Id"))
            Session("ListDetalleAjustes") = ListDetalleAjustes
            Rg_Listado.DataSource = Session("ListDetalleAjustes")
            Rg_Listado.DataBind()

        Catch ex As Exception
        End Try

    End Sub

    Public Sub subCommandItemEntradas(ByVal sender As Object, ByVal e As DataGridCommandEventArgs) ''Handles dgEntradas.ItemCommand
        Select Case e.CommandName
            Case "Edit"
                subEditarEntradas(sender, e)
            Case "EliminarEntradas"
                subeliminarEntradas(sender, e)
        End Select
    End Sub

    Public Sub subeliminarEntradas(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)
        Dim lblIdInterno As Label
        lblIdInterno = e.Item.FindControl("lblId")
        If lblIdInterno.Text.Trim <> "0" Then
            Dim objdetalle As Salidas_Detalle_EntradasBrl = Salidas_Detalle_EntradasBrl.CargarPorID(lblIdInterno.Text)
            If objdetalle IsNot Nothing Then
                Try
                    objdetalle.Eliminar()
                Catch ex As Exception
                    Exit Sub
                End Try

            End If
        End If
        ' Elimina los registros en la vista del sistema
        '
        Dim indicefila As Integer = e.Item.ItemIndex
        Dim indicepagina As Integer = dgEntradas.CurrentPageIndex
        Dim itemsporpagina As Integer = dgEntradas.PageSize
        Dim elitem As Integer = (itemsporpagina * indicepagina) + indicefila

        Dim ListEntradasDetalleSalidas As New List(Of Salidas_Detalle_EntradasBrl)
        ListEntradasDetalleSalidas = CType(Session("EntradasAjustes"), List(Of Salidas_Detalle_EntradasBrl))
        ListEntradasDetalleSalidas.RemoveAt(elitem)
        Session("EntradasAjustes") = ListEntradasDetalleSalidas
        dgEntradas.DataSource = Session("EntradasAjustes")
        dgEntradas.DataBind()

    End Sub

    Public Sub subEditarEntradas(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

        Dim ListEntradasDetalleSalidas As New List(Of Salidas_Detalle_EntradasBrl)
        ListEntradasDetalleSalidas = CType(Session("EntradasAjustes"), List(Of Salidas_Detalle_EntradasBrl))

        Dim indicefila As Integer = e.Item.ItemIndex
        Dim indicepagina As Integer = dgEntradas.CurrentPageIndex
        Dim itemsporpagina As Integer = dgEntradas.PageSize
        Dim elitem As Integer = (itemsporpagina * indicepagina) + indicefila

        ddl_entradas.SelectedValue = ListEntradasDetalleSalidas.Item(elitem).Id_Entrada_Distribucion
        txt_cantidadentrada.Text = ListEntradasDetalleSalidas.Item(elitem).Cantidad
        lblIdEntrada.Text = ListEntradasDetalleSalidas.Item(elitem).ID
        lbl_CantidadAntesEditar.Text = ListEntradasDetalleSalidas.Item(elitem).Cantidad
    End Sub

    Protected Sub Rg_Listado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rg_Listado.SelectedIndexChanged
        Dim item As Telerik.Web.UI.GridDataItem = Me.Rg_Listado.SelectedItems.Item(Rg_Listado.SelectedIndexes.Item(0))

        Dim objproducto As Salidas_DetalleBrl = Salidas_DetalleBrl.CargarPorID(item("id").Text)
        lblIdProducto.Text = objproducto.ID
        ddl_Productos.SelectedValue = objproducto.Id_Producto
        ddl_capacidad.SelectedValue = objproducto.Id_Capacidad
        txtCantidad.Text = objproducto.Cantidad

        Session("EntradasAjustes") = objproducto.Salidas_Detalle_Entradas
        dgEntradas.DataSource = Session("EntradasAjustes")
        dgEntradas.DataBind()

        pnl_producto.Visible = True
        ddl_Productos_SelectedIndexChanged(Nothing, Nothing)
        btn_nuevaentrada_Click(Nothing, Nothing)

    End Sub

    Public Sub CambioPaginaEntradas(ByVal sender As Object, ByVal e As DataGridPageChangedEventArgs) '' Handles dgEntradas.PageIndexChanged
        dgEntradas.CurrentPageIndex = e.NewPageIndex
        dgEntradas.SelectedIndex = -1
        dgEntradas.DataSource = Session("EntradasAjustes")
        dgEntradas.DataBind()
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_GuardarAsignacion.Click
        Validate("ASIG")
        If Not IsValid Then Exit Sub

        ' Proceso de validacion de que no sobrepase el limite
        Dim objdetalle As Entradas_DistribucionBrl = Entradas_DistribucionBrl.CargarPorID(ddl_entradas.SelectedValue)
        If objdetalle.Cantidad < Val(txt_cantidadentrada.Text) Then
            lblMensaje.Visible = True
            lblMensaje.Text = "La cantidad a descargar de la entrada es inferior a la que se esta registrando."
            lblMensaje.ForeColor = Drawing.Color.Red
            Exit Sub
        End If

        Dim wcantidadsalidas As Integer = Salidas_Detalle_EntradasBrl.CantidadSalida(ddl_entradas.SelectedValue)
        If lbl_CantidadAntesEditar.Text <> "" Then
            wcantidadsalidas -= Val(lbl_CantidadAntesEditar.Text)
        End If

        If (wcantidadsalidas + Val(txt_cantidadentrada.Text)) > objdetalle.Cantidad Then
            lblMensaje.Visible = True
            lblMensaje.Text = "La cantidad a descargar es superior a la pendiente por ingresar al sistema."
            lblMensaje.ForeColor = Drawing.Color.Red
            Exit Sub
        End If

        '

        Dim ListEntradas As New List(Of Salidas_Detalle_EntradasBrl)
        ListEntradas = CType(Session("EntradasAjustes"), List(Of Salidas_Detalle_EntradasBrl))
        Dim objtempasignacion As Salidas_Detalle_EntradasBrl
        If lblIdEntrada.Text = "" Then

            ' Crear Registro
            objtempasignacion = New Salidas_Detalle_EntradasBrl
            objtempasignacion.Cantidad = Val(txt_cantidadentrada.Text)
            objtempasignacion.Id_Entrada_Distribucion = Me.ddl_entradas.SelectedValue
            objtempasignacion.Fecha_Creacion = Now
            objtempasignacion.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
            ListEntradas.Add(objtempasignacion)
        Else

            'ListAsignaciones = CType(Session("Asignaciones"), List(Of Entradas_DistribucionBrl))
            For Each fila As Salidas_Detalle_EntradasBrl In ListEntradas
                If fila.ID = Val(lblIdEntrada.Text) Then
                    fila.Cantidad = Val(txt_cantidadentrada.Text)
                    fila.Id_Entrada_Distribucion = ddl_entradas.SelectedValue
                    fila.Fecha_Modificacion = Now
                    fila.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text
                End If
            Next
        End If

        '
        Session("EntradasAjustes") = ListEntradas
        dgEntradas.DataSource = Session("EntradasAjustes")
        dgEntradas.DataBind()
        btn_nuevaentrada_Click(Nothing, Nothing)
    End Sub

    Protected Sub btn_Guardar_Producto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Guardar_Producto.Click
        Validate("PROD")
        If Not IsValid Then Exit Sub
        lblMensaje.Visible = False

        ' validar las entrdas sea igual a la cantidad del producto

        Dim wvalor As Double = 0
        Dim ListEntradas As New List(Of Salidas_Detalle_EntradasBrl)
        ListEntradas = CType(Session("EntradasAjustes"), List(Of Salidas_Detalle_EntradasBrl))
        For Each fila As Salidas_Detalle_EntradasBrl In ListEntradas
            wvalor += fila.Cantidad
        Next
        If wvalor <> Val(txtCantidad.Text) Then
            lblMensaje.Text = "La cantidad de entradas no es igual a la comprada."
            lblMensaje.Visible = True
            lblMensaje.ForeColor = Drawing.Color.Red
            Exit Sub
        End If


        ' Creando el registro del producto

        Dim ProductoDetalle As Salidas_DetalleBrl
        If lblIdProducto.Text = "" Then
            ProductoDetalle = New Salidas_DetalleBrl
            ProductoDetalle.Fecha_Creacion = Now
            ProductoDetalle.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
        Else
            ProductoDetalle = Salidas_DetalleBrl.CargarPorID(lblIdProducto.Text)
            ProductoDetalle.Fecha_Modificacion = Now
            ProductoDetalle.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text
        End If
        ProductoDetalle.Cantidad = Val(txtCantidad.Text)
        ProductoDetalle.Id_Capacidad = ddl_capacidad.SelectedValue
        ProductoDetalle.Id_Salida = LblId.Text
        ProductoDetalle.Id_Producto = ddl_Productos.SelectedValue

        ProductoDetalle.Salidas_Detalle_Entradas = ListEntradas
        ProductoDetalle.Guardar()

        '
        ' cargando los productos

        Dim ListDetalleSalidas As List(Of Salidas_DetalleBrl)
        ListDetalleSalidas = Salidas_DetalleBrl.CargarPorId_Salida(Request.QueryString.Item("Id"))
        Session("ListDetalleAjustes") = ListDetalleSalidas

        Rg_Listado.DataSource = Session("ListDetalleAjustes")
        Rg_Listado.DataBind()
        pnl_producto.Visible = False
        btn_limpiar_Click(Nothing, Nothing)

    End Sub

    Protected Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try

            Dim ListSalida As New List(Of Salidas_DetalleBrl)
            ListSalida = Salidas_DetalleBrl.CargarPorId_Salida(Request.QueryString.Item("Id"))
            For Each detalle As Salidas_DetalleBrl In ListSalida
                For Each fila As Salidas_Detalle_EntradasBrl In detalle.Salidas_Detalle_Entradas
                    fila.Eliminar()
                Next
            Next
            ListSalida = Salidas_DetalleBrl.CargarPorId_Salida(Request.QueryString.Item("Id"))
            For Each detalle As Salidas_DetalleBrl In ListSalida
                detalle.Eliminar()
            Next

            Dim objentrada As SalidasBrl = SalidasBrl.CargarPorID(Request.QueryString.Item("Id"))
            objentrada.Eliminar()

            Response.Redirect("SalidasAjustesList.aspx?Refrescar=1")
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Protected Sub ddl_Productos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_Productos.SelectedIndexChanged
        If ddl_Productos.SelectedValue > 0 Then
            BindHelper.Entradas_DistribucionUIL.BindToListControlPorId_BodegayId_Producto(ddl_entradas, ddl_Bodegas.SelectedValue, ddl_Productos.SelectedValue, New ListItem("Seleccione", 0))
        Else
            ddl_entradas.Items.Clear()
        End If
    End Sub

    Protected Sub dgEntradas_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgEntradas.ItemDataBound
        If e.Item.ItemType = ListItemType.AlternatingItem Or e.Item.ItemType = ListItemType.Item Then
            Dim btneliminarasig As ImageButton
            btneliminarasig = e.Item.FindControl("btneliminarasig")
            If Request.QueryString.Item("Editar") = 0 Then
                btneliminarasig.Visible = False
            End If
        End If
    End Sub

    Protected Sub btn_nuevo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_nuevo.Click
        Response.Redirect("../webforms/SalidasAjustes.aspx")
    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Session.Remove("ListDetalleAjustes")
        If Request.QueryString.Item("TA") >= 1 Then
            Response.Redirect("SalidasAjustesAprobarList.aspx?TA=" & Request.QueryString.Item("TA"))
        End If
        Response.Redirect("SalidasAjustesList.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        If Request.QueryString.Item("Id") > 0 Then
            Response.Redirect("../webforms/SalidasAjustes.aspx?Editar=1&Id=" + Request.QueryString.Item("Id"))
        Else
            btn_nuevo_Click(sender, e)
        End If
    End Sub

    Protected Sub Rg_Listado_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles Rg_Listado.ItemDataBound
        If e.Item.ItemType = ListItemType.AlternatingItem Or e.Item.ItemType = ListItemType.Item Then
            Dim btneliminarben As ImageButton
            btneliminarben = e.Item.FindControl("btneliminarben")
            If Request.QueryString.Item("Editar") = 0 Then
                btneliminarben.Visible = False
            End If
        End If
    End Sub
End Class
