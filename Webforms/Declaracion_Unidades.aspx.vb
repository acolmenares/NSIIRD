Imports System.Collections.Generic
Imports ingNovar.Utilidades2
Imports System.Data
Imports Especiales
Imports Telerik.Web.UI

Partial Class WebForms_Declaracion_Unidades
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load

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

        ' dropdown de las unidades de apoyo

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_unidad, 27, New ListItem("Seleccione", 0))
        Dim objDeclaracion As DeclaracionBrl = DeclaracionBrl.CargarPorID(Request.QueryString.Item("ID"))

        If objDeclaracion Is Nothing Then
            lblMensaje.Text = "Registro no existe"
            lblMensaje.Visible = True
            Exit Sub
        End If

        lbl_FechaDeclaracion.Text = FechaUtil.toStringDDMMYYY(objDeclaracion.Fecha_Declaracion, "/")
        lbl_FechaRadicacion.Text = FechaUtil.toStringDDMMYYY(objDeclaracion.Fecha_Radicacion, "/")
        Try
            lbl_fuente.Text = objDeclaracion.Fuente.Descripcion
        Catch ex As Exception
            lbl_fuente.Text = "N/A"
        End Try

        Lbl_regional.Text = objDeclaracion.Regionales.Descripcion
        lbl_lugarFuente.Text = objDeclaracion.NombreLugarFuente
        lbl_enlinea.Text = objDeclaracion.DeclaracionEnLinea
        lbl_FechaDesplazamiento.Text = FechaUtil.toStringDDMMYYY(objDeclaracion.Fecha_Desplazamiento, "/")
        lbl_NumeroDeclaracion.Text = objDeclaracion.Numero_Declaracion
        lbl_Horario.Text = objDeclaracion.Horario
        lbl_tipo_declarante.Text = objDeclaracion.TipoDeclaracion.Descripcion
        lbl_TipoFamilia.Text = objDeclaracion.TipoFamiliaxaEmpacar

        ' cargas los datos de la persona
        Dim objpersona As PersonasBrl = PersonasBrl.CargarPorId_DeclaracionYDeclarante(Request.QueryString.Item("Id"))
        If objpersona IsNot Nothing Then
            lbl_PrimerNombre.Text = objpersona.Primer_Nombre
            lbl_SegundoNombre.Text = objpersona.Segundo_Nombre
            lbl_PrimerApellido.Text = objpersona.Primer_Apellido
            lbl_SegundoApellido.Text = objpersona.Segundo_Apellido
            lbl_TipoIdentificacion.Text = objpersona.Tipo_Identificacion.Descripcion
            lbl_Identificacion.Text = objpersona.Identificacion
            lbl_Edad.Text = objpersona.Edad
            lbl_Genero.Text = objpersona.GeneroPersona
            lbl_FechaNacimiento.Text = FechaUtil.toStringDDMMYYY(objpersona.Fecha_Nacimiento, "/")
        End If

        ' Cargar los datos de las unidades de apoyo

        Dim objunidades As List(Of Declaracion_UnidadesBrl) = Declaracion_UnidadesBrl.CargarPorId_Declaracion(objDeclaracion.ID)
        Session("Unidades") = objunidades
        Rg_Listado.DataSource = Session("Unidades")
        Rg_Listado.DataBind()
        lbl_idestado.Text = ""

    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/Declaracion_UnidadesList.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        If Request.QueryString.Item("Id") > 0 Then
            Response.Redirect("../webforms/Declaracion_Unidades.aspx?Id=" + Request.QueryString.Item("Id"))
        End If
    End Sub

    Protected Sub Rg_Listado_NeedDataSource(sender As Object, e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Listado.NeedDataSource
        Rg_Listado.DataSource = Session("Unidades")
    End Sub

    Protected Sub ddl_unidad_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddl_unidad.SelectedIndexChanged
        BindHelper.SubTablasUIL.BindToListControlPorId_Padre(ddl_estado, ddl_unidad.SelectedValue, New ListItem("Seleccione", 0))
    End Sub

    Protected Sub btn_grabar_Click(sender As Object, e As System.EventArgs) Handles btn_grabar.Click
        Validate()
        If Not IsValid Then Exit Sub

        Dim objDeclaracion As DeclaracionBrl = DeclaracionBrl.CargarPorID(Request.QueryString.Item("ID"))
        Dim objestado As Declaracion_UnidadesBrl
        If lbl_idestado.Text = "" Then
            objestado = New Declaracion_UnidadesBrl
            objestado.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
            objestado.Fecha_Creacion = Now
            objestado.Id_Declaracion = Request.QueryString.Item("Id")
        Else
            objestado = Declaracion_UnidadesBrl.CargarPorID(lbl_idestado.Text)
            objestado.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text
            objestado.Fecha_Modificacion = Now
        End If


        objestado.Id_Unidad = ddl_unidad.SelectedValue
        objestado.Id_EstadoUnidad = ddl_estado.SelectedValue
        objestado.Fecha_Inclusion = rdpFecha.DbSelectedDate
        objestado.Fecha_Investigacion = rdpFecha_Investigacion.DbSelectedDate
        objestado.Fuente = rdb_fuente.SelectedValue
        objestado.Guardar()

        Dim objunidades As List(Of Declaracion_UnidadesBrl) = Declaracion_UnidadesBrl.CargarPorId_Declaracion(objDeclaracion.ID)
        Session("Unidades") = objunidades
        Rg_Listado.DataSource = Session("Unidades")
        Rg_Listado.DataBind()


    End Sub

    Protected Sub btn_limpiar_Click(sender As Object, e As System.EventArgs) Handles btn_limpiar.Click
        lbl_idestado.Text = ""
        ddl_unidad.SelectedValue = 0
        ddl_unidad_SelectedIndexChanged(Nothing, Nothing)
        rdpFecha.DbSelectedDate = Nothing
        rdpFecha_Investigacion.DbSelectedDate = Nothing
        rdb_fuente.SelectedValue = "En IRD"

    End Sub

    Protected Sub Rg_Listado_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles Rg_Listado.SelectedIndexChanged
        Dim item As Telerik.Web.UI.GridDataItem = Me.Rg_Listado.SelectedItems.Item(Rg_Listado.SelectedIndexes.Item(0))
        Dim objestado As Declaracion_UnidadesBrl = Declaracion_UnidadesBrl.CargarPorID(item("Id").Text)
        If objestado IsNot Nothing Then
            ddl_unidad.SelectedValue = objestado.Id_Unidad
            ddl_unidad_SelectedIndexChanged(Nothing, Nothing)
            ddl_estado.SelectedValue = objestado.Id_EstadoUnidad
            rdb_fuente.SelectedValue = objestado.Fuente.TrimEnd
            rdpFecha.DbSelectedDate = objestado.Fecha_Inclusion
            rdpFecha_Investigacion.DbSelectedDate = objestado.Fecha_Investigacion
            lbl_idestado.Text = objestado.ID
        End If


    End Sub

    Protected Sub Rg_Listado_DeleteCommand(sender As Object, e As Telerik.Web.UI.GridCommandEventArgs) Handles Rg_Listado.DeleteCommand
        Dim ItemId = DirectCast((DirectCast(e.Item, GridDataItem)).GetDataKeyValue("Id"), Integer)

        Dim objestado As Declaracion_UnidadesBrl = Declaracion_UnidadesBrl.CargarPorID(ItemId)
        If objestado IsNot Nothing Then
            If objestado.Fuente = "En IRD" Then
                objestado.Eliminar()

                Dim objunidades As List(Of Declaracion_UnidadesBrl) = Declaracion_UnidadesBrl.CargarPorId_Declaracion(Request.QueryString.Item("ID"))
                Session("Unidades") = objunidades
                Rg_Listado.DataSource = Session("Unidades")
                Rg_Listado.DataBind()

                btn_limpiar_Click(Nothing, Nothing)
            Else
                MsgBox("No es posible eliminar este tipo de estado de las unidades de apoyo, ya que es un proceso automático.")
                Exit Sub
            End If


        End If
    End Sub
End Class
