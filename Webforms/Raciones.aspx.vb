Imports ingNovar.Utilidades2
Imports System.Collections.Generic

Partial Class WebForms_Raciones
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

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Productos, 32, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Capacidad, 33, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(Lst_Tipos_Entrega, 77)
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(Lst_Lugares, 73)

        If Request.QueryString.Item("Editar") = 1 Then
            Dim objRaciones As RacionesBrl = RacionesBrl.CargarPorID(Request.QueryString.Item("ID"))

            If objRaciones Is Nothing Then
                lblMensaje.Text = "Registro no existe"
                lblMensaje.Visible = True
                Exit Sub
            End If

            If ddl_Productos.Items.FindByValue(objRaciones.Id_Producto) IsNot Nothing Then ddl_Productos.SelectedValue = objRaciones.Id_Producto
            If ddl_Capacidad.Items.FindByValue(objRaciones.Id_Capacidad) IsNot Nothing Then ddl_Capacidad.SelectedValue = objRaciones.Id_Capacidad
            rdpFechaInicial.SelectedDate = objRaciones.Fecha_Inicial
            rdpFechaFinal.SelectedDate = objRaciones.Fecha_Final
            txtCantidad.Text = objRaciones.Cantidad

            If objRaciones.Por_Familia Then
                rdb_condicion.Items(0).Selected = True
                rdb_condicion.Items(1).Selected = False
            End If
            If objRaciones.Por_Persona Then
                rdb_condicion.Items(0).Selected = False
                rdb_condicion.Items(1).Selected = True
            End If

            For Each fila As Raciones_EntregasBrl In objRaciones.Raciones_Entregas
                Dim detalle As New ListItem
                detalle.Text = fila.Tipo_Entrega.Descripcion
                detalle.Value = fila.Id_Tipo_Entrega
                lst_Tipos_Entrega_Racion.Items.Add(detalle)
            Next

            For Each fila As Raciones_LugaresBrl In objRaciones.Raciones_Lugares
                Dim detalle As New ListItem
                detalle.Text = fila.Lugar_Entrega.Descripcion
                detalle.Value = fila.Id_LugarEntrega
                Lst_Lugares_Racion.Items.Add(detalle)
            Next


            For Each fila As Raciones_TiposBrl In objRaciones.Raciones_Tipos
                chb_tipofamilia.Items(fila.Tipo - 1).Selected = True
            Next

        End If


    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Validate()
        If Not IsValid Then Exit Sub

        Dim ID As Int32

        Try
            ID = Grabar()
            Response.Redirect("Raciones.aspx?Editar=1&Mensaje=1&ID=" & ID)
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Private Sub btnGuardarOtro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarOtro.Click
        Validate()
        If Not IsValid Then Exit Sub

        Try
            Grabar()
            Response.Redirect("Raciones.aspx?Mensaje=1")
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Private Function Grabar() As Int32

        Dim objRaciones As RacionesBRL

        If Request.QueryString.Item("Editar") = 1 Then
            objRaciones = RacionesBrl.CargarPorID(Request.QueryString.Item("ID"))
            objRaciones.Fecha_Modificacion = Now
            objRaciones.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text
        Else
            objRaciones = New RacionesBrl
            objRaciones.Fecha_Creacion = Now
            objRaciones.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
        End If

        objRaciones.Id_Producto = ddl_Productos.SelectedValue
        objRaciones.Fecha_Inicial = rdpFechaInicial.DbSelectedDate
        objRaciones.Fecha_Final = rdpFechaFinal.DbSelectedDate
        objRaciones.Cantidad = txtCantidad.Text
        objRaciones.Id_Capacidad = ddl_Capacidad.SelectedValue
        If rdb_condicion.Items(0).Selected Then
            objRaciones.Por_Familia = True  ' Se manejo por familia
            objRaciones.Por_Persona = False
        Else
            objRaciones.Por_Familia = False ' Se maneja por Beneficiarios
            objRaciones.Por_Persona = True
        End If

        ' Grabando los datos de entregas
        ' eliminado tablas de apoyo

        For Each fila As Raciones_EntregasBrl In objRaciones.Raciones_Entregas
            fila.Eliminar()
        Next
        For Each fila As Raciones_LugaresBrl In objRaciones.Raciones_Lugares
            fila.Eliminar()
        Next
        For Each fila As Raciones_TiposBrl In objRaciones.Raciones_Tipos
            fila.Eliminar()
        Next

        ' Entregas

        Dim ListRaciones_Entrega As New List(Of Raciones_EntregasBrl)
        For Each fila As ListItem In Me.lst_Tipos_Entrega_Racion.Items
            Dim objraciones_entrega As New Raciones_EntregasBrl
            objraciones_entrega.Id_Tipo_Entrega = fila.Value
            objraciones_entrega.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
            objraciones_entrega.Fecha_Creacion = Now
            ListRaciones_Entrega.Add(objraciones_entrega)
        Next

        ' Lugares
        Dim ListRaciones_lugares As New List(Of Raciones_LugaresBrl)
        For Each fila As ListItem In Me.Lst_Lugares_Racion.Items
            Dim objraciones_Lugar As New Raciones_LugaresBrl
            objraciones_Lugar.Id_LugarEntrega = fila.Value
            ListRaciones_lugares.Add(objraciones_Lugar)
        Next

        'Tipos
        Dim LIstRaciones_Tipos As New List(Of Raciones_TiposBrl)
        For Each fila As ListItem In chb_tipofamilia.Items
            If fila.Selected Then
                Dim objraciones_tipo As New Raciones_TiposBrl
                objraciones_tipo.Tipo = fila.Value
                LIstRaciones_Tipos.Add(objraciones_tipo)
            End If
        Next

        objRaciones.Raciones_Entregas = ListRaciones_Entrega
        objRaciones.Raciones_Lugares = ListRaciones_lugares
        objRaciones.Raciones_Tipos = LIstRaciones_Tipos
        objRaciones.Guardar()
        Return objRaciones.ID

    End Function

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim objRaciones As RacionesBrl

        Try
            If Request.QueryString.Item("Refrescar") = 1 Then
                ' eliminando las entregas
                objRaciones = RacionesBrl.CargarPorID(Request.QueryString.Item("ID"))

                For Each fila As Raciones_EntregasBrl In objRaciones.Raciones_Entregas
                    fila.Eliminar()
                Next
                For Each fila As Raciones_LugaresBrl In objRaciones.Raciones_Lugares
                    fila.Eliminar()
                Next

                objRaciones = RacionesBrl.CargarPorID(Request.QueryString.Item("ID"))
                objRaciones.Eliminar()
                Response.Redirect("Raciones.aspx?Mensaje=1")
            End If
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Protected Sub imb_cargar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imb_cargar.Click
        If Me.Lst_Tipos_Entrega.SelectedIndex >= 0 Then
            Dim item As New ListItem
            item.Text = Me.Lst_Tipos_Entrega.SelectedItem.Text
            item.Value = Me.Lst_Tipos_Entrega.SelectedItem.Value
            lst_Tipos_Entrega_Racion.Items.Add(item)
            Lst_Tipos_Entrega.ClearSelection()
        End If
    End Sub

    Protected Sub imb_retirar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imb_retirar.Click
        If Me.lst_Tipos_Entrega_Racion.SelectedIndex >= 0 Then
            lst_Tipos_Entrega_Racion.Items.RemoveAt(Me.lst_Tipos_Entrega_Racion.SelectedIndex)
            lst_Tipos_Entrega_Racion.ClearSelection()
        End If
    End Sub

    Protected Sub imb_cargar1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imb_cargar1.Click
        If Me.Lst_Lugares.SelectedIndex >= 0 Then
            Dim item As New ListItem
            item.Text = Me.Lst_Lugares.SelectedItem.Text
            item.Value = Me.Lst_Lugares.SelectedItem.Value
            Lst_Lugares_Racion.Items.Add(item)
            Lst_Lugares.ClearSelection()
        End If
    End Sub

    Protected Sub imb_retirar1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imb_retirar1.Click
        If Me.Lst_Lugares_Racion.SelectedIndex >= 0 Then
            Lst_Lugares_Racion.Items.RemoveAt(Me.Lst_Lugares_Racion.SelectedIndex)
            Lst_Lugares_Racion.ClearSelection()
        End If
    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/RacionesList.aspx")
    End Sub

    Protected Sub btn_nuevo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_nuevo.Click
        Response.Redirect("../webforms/Raciones.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        If Request.QueryString.Item("Id") > 0 Then
            Response.Redirect("../webforms/Raciones.aspx?Editar=1&Id=" + Request.QueryString.Item("Id"))
        Else
            btn_nuevo_Click(sender, e)
        End If
    End Sub
End Class
