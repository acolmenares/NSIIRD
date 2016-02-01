Imports ingNovar.Utilidades2
Imports System.Data
Imports System.Collections.Generic
Imports Telerik.Web.UI

Partial Class WebForms_Salud
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

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Crecimiento_Desarrollo, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Motivo_Crecimiento_Desarrollo, 78, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Crecimiento_Desarrollo_IRD, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Motivo_Crecimiento_Desarrollo_IRD, 78, New ListItem("Seleccione", 0))

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddlId_Lactancia_Lactando, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Vacunacion_Carnet, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Razon_No_Carnet, 63, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Esquema_Vacunacion_Completo, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Razon_No_Vacunacion_Completo, 65, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Ninos_Vacunados, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Motivo_No_Vacunados, 65, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Recuperado, 4, New ListItem("Seleccione", 0))

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Entidad_Remision, 67, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Informacion, 66, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Tipo_Proceso, 77, New ListItem("Seleccione", 0))

        Dim objpersona As PersonasBrl = PersonasBrl.CargarPorID(Request.QueryString.Item("Id"))
        Session("Persona") = objpersona
        lblIdValoracion.Text = ""
        lblIdRemision.Text = ""
        lblidsalud.Text = ""
        lbl_Fecha_Nacimiento.Text = Format(objpersona.Fecha_Nacimiento, "dd/MMM/yyyy")
        lbl_Grupo.Text = objpersona.Declaracion.DescripcionGrupo

        Dim ListSalud As List(Of SaludBrl) = SaludBrl.CargarPorId_Persona(Request.QueryString.Item("ID"))
        Dim objSalud As SaludBrl
        If ListSalud.Count = 0 Then
            objSalud = New SaludBrl
            lbl_Nombre_completo.Text = objpersona.NombreCompleto
        Else
            objSalud = ListSalud.Item(0)
            lbl_Nombre_completo.Text = objSalud.Personas.NombreCompleto
            If ddl_Crecimiento_Desarrollo.Items.FindByValue(objSalud.Id_Crecimiento_Desarrollo) IsNot Nothing Then ddl_Crecimiento_Desarrollo.SelectedValue = objSalud.Id_Crecimiento_Desarrollo
            If ddl_Crecimiento_Desarrollo_IRD.Items.FindByValue(objSalud.Id_Crecimiento_Desarrollo_IRD) IsNot Nothing Then ddl_Crecimiento_Desarrollo_IRD.SelectedValue = objSalud.Id_Crecimiento_Desarrollo_IRD
            If ddl_Motivo_Crecimiento_Desarrollo.Items.FindByValue(objSalud.Id_Motivo_No_CYD) IsNot Nothing Then ddl_Motivo_Crecimiento_Desarrollo.SelectedValue = objSalud.Id_Motivo_No_CYD
            If ddl_Motivo_Crecimiento_Desarrollo_IRD.Items.FindByValue(objSalud.Id_Motivo_NO_CYD_IRD) IsNot Nothing Then ddl_Motivo_Crecimiento_Desarrollo_IRD.SelectedValue = objSalud.Id_Motivo_NO_CYD_IRD

            txtPatologia.Text = objSalud.Patologia
            If ddlId_Lactancia_Lactando.Items.FindByValue(objSalud.Id_Lactancia_Lactando) IsNot Nothing Then ddlId_Lactancia_Lactando.SelectedValue = objSalud.Id_Lactancia_Lactando
            txtLactancia_meses.Text = objSalud.Lactancia_meses
            txtLactancia_Exclusiva.Text = objSalud.Lactancia_Exclusiva
            If ddl_Vacunacion_Carnet.Items.FindByValue(objSalud.Id_Vacunacion_Carnet) IsNot Nothing Then ddl_Vacunacion_Carnet.SelectedValue = objSalud.Id_Vacunacion_Carnet
            If ddl_Razon_No_Carnet.Items.FindByValue(objSalud.Id_Razon_No_Carnet) IsNot Nothing Then ddl_Razon_No_Carnet.SelectedValue = objSalud.Id_Razon_No_Carnet
            If ddl_Esquema_Vacunacion_Completo.Items.FindByValue(objSalud.Id_Esquema_Vacunacion_Completo) IsNot Nothing Then ddl_Esquema_Vacunacion_Completo.SelectedValue = objSalud.Id_Esquema_Vacunacion_Completo
            If ddl_Razon_No_Vacunacion_Completo.Items.FindByValue(objSalud.Id_Razon_No_Vacunacion_Completo) IsNot Nothing Then ddl_Razon_No_Vacunacion_Completo.SelectedValue = objSalud.Id_Razon_No_Vacunacion_Completo
            Chb_Cerrado.Checked = objSalud.Cierre
            txtObservaciones.Text = objSalud.Observaciones
            lblidsalud.Text = objSalud.ID

            ' validar datos
            ddlSubTablasId_Vacunacion_Carnet_SelectedIndexChanged(Nothing, Nothing)
            ddlSubTablasId_Esquema_Vacunacion_Completo_SelectedIndexChanged(Nothing, Nothing)


            If ddl_Ninos_Vacunados.Items.FindByValue(objSalud.Id_Ninos_Vacunados) IsNot Nothing Then ddl_Ninos_Vacunados.SelectedValue = objSalud.Id_Ninos_Vacunados
            If ddl_Motivo_No_Vacunados.Items.FindByValue(objSalud.Id_Motivo_No_Vacunados) IsNot Nothing Then ddl_Motivo_No_Vacunados.SelectedValue = objSalud.Id_Motivo_No_Vacunados
            rdpfecha_Vacunacion.SelectedDate = objSalud.Fecha_Esquema_Vacunacion

            ddlSubTablasId_Ninos_Vacunados_SelectedIndexChanged(Nothing, Nothing)
            '
        End If

        ddl_Crecimiento_Desarrollo_SelectedIndexChanged(Nothing, Nothing)
        ddl_Crecimiento_Desarrollo_SelectedIndexChanged(Nothing, Nothing)
        cargartablas(lblidsalud.Text, 0)

        SetFocus(txtPatologia)
    End Sub

    Private Sub cargartablas(ByVal id As String, ByVal tipo As Integer)
        Dim wcodigo As Integer = 0
        If id = "" Then wcodigo = 0 Else wcodigo = Val(id)

        If (tipo = 1) Or (tipo = 0) Then
            Dim objSaludValoraciones As List(Of Salud_ValoracionBrl)

            objSaludValoraciones = Salud_ValoracionBrl.CargarPorId_salud(wcodigo)
            Session("SaludValoraciones") = objSaludValoraciones
            Rg_Valoraciones.DataSource = Session("SaludValoraciones")
            Rg_Valoraciones.DataBind()
        End If

        If (tipo = 2) Or (tipo = 0) Then
            Dim objSaludRemisiones As List(Of Salud_RemisionesBrl)

            objSaludRemisiones = Salud_RemisionesBrl.CargarPorId_Salud(wcodigo)
            Session("SaludRemisiones") = objSaludRemisiones
            Rg_Remisiones.DataSource = Session("SaludRemisiones")
            Rg_Remisiones.DataBind()
        End If

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Validate("GVG")
        If Not IsValid Then Exit Sub

        If Chb_Cerrado.Checked Then
            lblMensaje.Text = "Registro Cerrado. No se puede modificar.!!!!"
            lblMensaje.Visible = True
            Exit Sub
        End If

        Dim ID As Int32

        Try
            ID = Grabar()
            Response.Redirect("Salud.aspx?Editar=1&Mensaje=1&ID=" & Request.QueryString.Item("Id"))
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Private Sub btnGuardarOtro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarOtro.Click
        Validate("GVG")
        If Not IsValid Then Exit Sub
        If Chb_Cerrado.Checked Then
            lblMensaje.Text = "Registro Cerrado. No se puede modificar.!!!!"
            lblMensaje.Visible = True
            Exit Sub
        End If
        Try
            Grabar()
            Response.Redirect("Salud.aspx?Mensaje=1")
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Private Function Grabar() As Int32

        Dim ListSalud As List(Of SaludBrl)
        Dim objsalud As SaludBrl
        ListSalud = SaludBrl.CargarPorId_Persona(Request.QueryString.Item("ID"))
        If ListSalud.Count = 0 Then
            objsalud = New SaludBrl
            objsalud.Fecha_Creacion = Now
            objsalud.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
        Else
            objsalud = ListSalud.Item(0)
            objsalud.Fecha_Modificacion = Now
            objsalud.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text
        End If

        objsalud.Id_Persona = Request.QueryString.Item("Id")
        objsalud.Id_Crecimiento_Desarrollo = ddl_Crecimiento_Desarrollo.SelectedValue
        objsalud.Id_Motivo_No_CYD = ddl_Motivo_Crecimiento_Desarrollo.SelectedValue
        objsalud.Id_Crecimiento_Desarrollo_IRD = ddl_Crecimiento_Desarrollo_IRD.SelectedValue
        objsalud.Id_Motivo_NO_CYD_IRD = ddl_Motivo_Crecimiento_Desarrollo_IRD.SelectedValue
        objsalud.Patologia = txtPatologia.Text
        objsalud.Id_Lactancia_Lactando = ddlId_Lactancia_Lactando.SelectedValue

        Try
            objsalud.Lactancia_meses = txtLactancia_meses.Text
        Catch ex As Exception
            objsalud.Lactancia_meses = 0
        End Try
        Try
            objsalud.Lactancia_Exclusiva = txtLactancia_Exclusiva.Text
        Catch ex As Exception
            objsalud.Lactancia_Exclusiva = 0
        End Try

        objsalud.Id_Vacunacion_Carnet = ddl_Vacunacion_Carnet.SelectedValue
        objsalud.Id_Razon_No_Carnet = ddl_Razon_No_Carnet.SelectedValue
        objsalud.Id_Esquema_Vacunacion_Completo = ddl_Esquema_Vacunacion_Completo.SelectedValue
        objsalud.Id_Razon_No_Vacunacion_Completo = ddl_Razon_No_Vacunacion_Completo.SelectedValue
        Try
            objsalud.Fecha_Esquema_Vacunacion = rdpfecha_Vacunacion.SelectedDate
        Catch ex As Exception
            objsalud.Fecha_Esquema_Vacunacion = Nothing
        End Try

        objsalud.Id_Ninos_Vacunados = ddl_Ninos_Vacunados.SelectedValue
        objsalud.Id_Motivo_No_Vacunados = ddl_Motivo_No_Vacunados.SelectedValue
        objsalud.Observaciones = txtObservaciones.Text
        objsalud.Guardar()
        lblidsalud.Text = objsalud.ID

        Return objsalud.ID

    End Function

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim objSalud As SaludBrl

        Try
            If Request.QueryString.Item("Editar") = 1 Then
                objSalud = SaludBRL.CargarPorID(Request.QueryString.Item("ID"))
                objSalud.Eliminar()
                Response.Redirect("Salud.aspx?Mensaje=1")
            End If
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Public Sub subCommandItemValoraciones(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Select Case e.CommandName
            Case "Eliminar"
                subEliminarValoraciones(sender, e)
        End Select
    End Sub

    Protected Sub Rg_Valoraciones_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Valoraciones.NeedDataSource
        Rg_Remisiones.DataSource = Session("SaludValoraciones")
    End Sub

    Protected Sub Rg_Valoraciones_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rg_Valoraciones.SelectedIndexChanged
        Dim item As Telerik.Web.UI.GridDataItem = Rg_Valoraciones.SelectedItems.Item(Rg_Valoraciones.SelectedIndexes.Item(0))

        Dim objsaludvaloracion As Salud_ValoracionBrl
        objsaludvaloracion = Salud_ValoracionBrl.CargarPorID(item("id").Text)
        If objsaludvaloracion IsNot Nothing Then
            rdpfechaValoracion.SelectedDate = objsaludvaloracion.Fecha_Valoracion
            txt_peso.Text = objsaludvaloracion.Antropometria_Peso
            txt_talla.Text = objsaludvaloracion.Antropometria_Talla
            txt_perimetro.Text = objsaludvaloracion.Antropometia_Perimetro_Branquial
            txt_peso_talla.Text = objsaludvaloracion.Peso_talla
            txt_peso_edad.Text = objsaludvaloracion.Peso_edad
            txt_talla_longitud.Text = objsaludvaloracion.Talla_Longitud
            ddl_Recuperado.SelectedValue = objsaludvaloracion.Id_Recuperado
            txt_Diferencia_Peso.Text = objsaludvaloracion.Diferencia_Peso
            txt_Observaciones.Text = objsaludvaloracion.Observaciones
            Lbl_Edad_Anos_Actual.Text = objsaludvaloracion.Edad
            Lbl_Edad_Meses_Actual.Text = objsaludvaloracion.Meses
            lblIdValoracion.Text = objsaludvaloracion.ID
            Txt_IMC_Edad.Text = objsaludvaloracion.IMC_Edad
            Txt_Valoracion_TE.Text = objsaludvaloracion.Talla_Para_Edad
            txt_Estado_Nutricional.Text = objsaludvaloracion.Estado_Nutricional
            ddl_Tipo_Proceso.SelectedValue = objsaludvaloracion.Id_Tipo_Proceso
            Chb_Cerrado_Valoracion.Checked = objsaludvaloracion.Cierre
        End If
    End Sub

    Public Sub subEliminarValoraciones(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Dim lblId As Label
        lblId = e.Item.FindControl("lblIdV")
        Dim objsaludvaloracion As Salud_ValoracionBrl
        objsaludvaloracion = Salud_ValoracionBrl.CargarPorID(lblId.Text)
        If objsaludvaloracion.Cierre = False Then
            lblMensaje.Text = "Registro Cerrado. No se puede Eliminar.!!!!"
            lblMensaje.Visible = True
            Exit Sub
        End If
        objsaludvaloracion.Eliminar()
        cargartablas(lblidsalud.Text, 1)
    End Sub

    Public Sub subCommandItemRemisiones(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Select Case e.CommandName
            Case "Eliminar"
                subEliminarRemisiones(sender, e)
        End Select
    End Sub

    Protected Sub Rg_Remisiones_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Remisiones.NeedDataSource
        Rg_Remisiones.DataSource = Session("SaludRemisiones")
    End Sub

    Protected Sub Rg_Listado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rg_Remisiones.SelectedIndexChanged
        Dim item As Telerik.Web.UI.GridDataItem = Me.Rg_Remisiones.SelectedItems.Item(Rg_Remisiones.SelectedIndexes.Item(0))

        Dim objsaludremisiones As Salud_RemisionesBrl
        objsaludremisiones = Salud_RemisionesBrl.CargarPorID(item("id").Text)
        If objsaludremisiones IsNot Nothing Then
            rdpfechaVerificacion.DbSelectedDate = objsaludremisiones.Fecha_Ingreso
            rdpfechaRemision.DbSelectedDate = objsaludremisiones.Fecha_Remision
            ddl_Entidad_Remision.SelectedValue = objsaludremisiones.Id_Entidad_Remision
            ddl_Informacion.SelectedValue = objsaludremisiones.Id_Entidad_Informacion
            Txt_Observaciones_Remision.Text = objsaludremisiones.Observaciones
            lblIdRemision.Text = objsaludremisiones.ID
            Chb_Cerrado_Remision.Checked = objsaludremisiones.Cierre
        End If
    End Sub

    Public Sub subEliminarRemisiones(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Dim lblId As Label
        lblId = e.Item.FindControl("lblIdR")
        Dim objsaludremisiones As Salud_RemisionesBrl
        objsaludremisiones = Salud_RemisionesBrl.CargarPorID(lblId.Text)
        If objsaludremisiones.Cierre = False Then
            lblMensaje.Text = "Registro Cerrado. No se puede Eliminar.!!!!"
            lblMensaje.Visible = True
            Exit Sub
        End If
        objsaludremisiones.Eliminar()
        cargartablas(lblidsalud.Text, 2)
    End Sub

    Protected Sub btnNuevaValoracion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNuevaValoracion.Click
        lblIdValoracion.Text = ""
        rdpfechaValoracion.SelectedDate = Nothing
        Lbl_Edad_Anos_Actual.Text = ""
        Lbl_Edad_Meses_Actual.Text = ""
        txt_peso.Text = ""
        txt_talla.Text = ""
        txt_perimetro.Text = ""
        txt_peso_talla.Text = ""
        txt_peso_edad.Text = ""
        txt_talla_longitud.Text = ""
        Txt_IMC_Edad.Text = ""
        txt_Estado_Nutricional.Text = ""
        Txt_Valoracion_TE.Text = ""
        txt_Diferencia_Peso.Text = ""
        ddl_Recuperado.SelectedValue = 0
        txt_Observaciones.Text = ""
        Chb_Cerrado_Valoracion.Checked = False
    End Sub

    Protected Sub btnNuevaRemision_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNuevaRemision.Click
        lblIdRemision.Text = ""
        ddl_Entidad_Remision.SelectedValue = 0
        ddl_Informacion.SelectedValue = 0
        rdpfechaRemision.SelectedDate = Nothing
        rdpfechaVerificacion.SelectedDate = Nothing
        Txt_Observaciones_Remision.Text = ""
        Chb_Cerrado_Remision.Checked = False
    End Sub

    Protected Sub btnGuardarValoracion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardarValoracion.Click
        If lblidsalud.Text = "" Then
            lblMensaje.Visible = True
            lblMensaje.Text = "Favor  grabar primero el registro de salud antes de generar valoración"
            lblMensaje.ForeColor = Drawing.Color.Red
            Exit Sub
        End If

        If Chb_Cerrado_Valoracion.Checked Then
            lblMensaje.Text = "Registro Cerrado. No se puede modificar.!!!!"
            lblMensaje.Visible = True
            Exit Sub
        End If

        btn_calcular_Click(Nothing, Nothing)
        Validate("GV1")
        If Not IsValid Then Exit Sub

        Dim objvaloracion As Salud_ValoracionBrl
        If lblIdValoracion.Text = "" Then
            objvaloracion = New Salud_ValoracionBrl
            objvaloracion.Fecha_Creacion = Now
            objvaloracion.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
            objvaloracion.Id_salud = lblidsalud.Text
        Else
            objvaloracion = Salud_ValoracionBrl.CargarPorID(lblIdValoracion.Text)
            objvaloracion.Fecha_Modificacion = Now
            objvaloracion.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text
        End If

        Try
            objvaloracion.Fecha_Valoracion = rdpfechaValoracion.SelectedDate
        Catch ex As Exception
            objvaloracion.Fecha_Valoracion = Nothing
        End Try
        objvaloracion.Antropometria_Peso = CType(txt_peso.Text, Double)
        objvaloracion.Antropometria_Talla = CType(txt_talla.Text, Double)
        Try
            objvaloracion.Antropometia_Perimetro_Branquial = CType(txt_perimetro.Text, Double)
        Catch ex As Exception
            objvaloracion.Antropometia_Perimetro_Branquial = 0
        End Try

        objvaloracion.Peso_talla = CType(txt_peso_talla.Text, Double)
        objvaloracion.Peso_edad = CType(txt_peso_edad.Text, Double)
        objvaloracion.Talla_Longitud = CType(txt_talla_longitud.Text, Double)
        objvaloracion.Diferencia_Peso = CType(txt_Diferencia_Peso.Text, Double)
        objvaloracion.IMC_Edad = CType(Txt_IMC_Edad.Text, Double)
        objvaloracion.Id_Recuperado = ddl_Recuperado.SelectedValue
        objvaloracion.Observaciones = txt_Observaciones.Text
        objvaloracion.Edad = Lbl_Edad_Anos_Actual.Text
        objvaloracion.Meses = Lbl_Edad_Meses_Actual.Text
        objvaloracion.Talla_Para_Edad = Txt_Valoracion_TE.Text
        objvaloracion.Estado_Nutricional = txt_Estado_Nutricional.Text
        objvaloracion.Id_Tipo_Proceso = ddl_Tipo_Proceso.SelectedValue

        objvaloracion.Guardar()
        btnNuevaValoracion_Click(Nothing, Nothing)
        cargartablas(lblidsalud.Text, 1)

    End Sub

    Protected Sub BtnGuardarRemision_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnGuardarRemision.Click
        Validate("GV2")
        If Not IsValid Then Exit Sub

        If Chb_Cerrado_Remision.Checked Then
            lblMensaje.Text = "Registro Cerrado. No se puede modificar.!!!!"
            lblMensaje.Visible = True
            Exit Sub
        End If

        Dim objremision As Salud_RemisionesBrl
        If lblIdRemision.Text = "" Then
            objremision = New Salud_RemisionesBrl
            objremision.Fecha_Creacion = Now
            objremision.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
        Else
            objremision = Salud_RemisionesBrl.CargarPorID(lblIdRemision.Text)
            objremision.Fecha_Modificacion = Now
            objremision.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text
        End If
        objremision.Id_Salud = lblidsalud.Text
        Try
            objremision.Fecha_Remision = rdpfechaRemision.DbSelectedDate
        Catch ex As Exception
            objremision.Fecha_Remision = Nothing
        End Try
        objremision.Id_Entidad_Remision = ddl_Entidad_Remision.SelectedValue
        objremision.Id_Entidad_Informacion = ddl_Informacion.SelectedValue
        Try
            objremision.Fecha_Ingreso = rdpfechaVerificacion.DbSelectedDate
        Catch ex As Exception
            objremision.Fecha_Ingreso = Nothing
        End Try

        objremision.Observaciones = Txt_Observaciones_Remision.Text
        objremision.Guardar()
        btnNuevaRemision_Click(Nothing, Nothing)
        cargartablas(lblidsalud.Text, 2)
    End Sub

    Protected Sub ddlSubTablasId_Vacunacion_Carnet_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_Vacunacion_Carnet.SelectedIndexChanged
        If ddl_Vacunacion_Carnet.SelectedValue = 20 Then
            ddl_Razon_No_Carnet.Enabled = True
            rev_Razon_No_Carnet.Enabled = True
        Else
            ddl_Razon_No_Carnet.Enabled = False
            rev_Razon_No_Carnet.Enabled = False
            ddl_Razon_No_Carnet.SelectedValue = 0
        End If
    End Sub

    Protected Sub ddlSubTablasId_Esquema_Vacunacion_Completo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_Esquema_Vacunacion_Completo.SelectedIndexChanged
        Select Case ddl_Esquema_Vacunacion_Completo.SelectedValue
            Case 20
                ddl_Razon_No_Vacunacion_Completo.Enabled = True
                Rev_Razon_No_Vacunacion_Completo.Enabled = True
                rdpfecha_Vacunacion.Enabled = False
                rdpfecha_Vacunacion.SelectedDate = Nothing
                rfv_Fecha_Esquema_Vacunacion.Enabled = False
                ddl_Motivo_No_Vacunados.Enabled = False
                revMotivo_No_Vacunados.Enabled = False
                ddl_Motivo_No_Vacunados.SelectedValue = 0
                ddl_Ninos_Vacunados.Enabled = True
            Case 19
                rdpfecha_Vacunacion.Enabled = False
                ddl_Razon_No_Vacunacion_Completo.Enabled = False
                ddl_Razon_No_Vacunacion_Completo.SelectedValue = 0
                Rev_Razon_No_Vacunacion_Completo.Enabled = False
                rfv_Fecha_Esquema_Vacunacion.Enabled = False
                ddl_Ninos_Vacunados.Enabled = False
                ddl_Motivo_No_Vacunados.Enabled = False
                revMotivo_No_Vacunados.Enabled = False
                ddl_Ninos_Vacunados.SelectedValue = 0
                ddl_Motivo_No_Vacunados.SelectedValue = 0

            Case Else
                ddl_Razon_No_Vacunacion_Completo.Enabled = False
                ddl_Razon_No_Vacunacion_Completo.SelectedValue = 0
                Rev_Razon_No_Vacunacion_Completo.Enabled = False
                rdpfecha_Vacunacion.Enabled = False
                rdpfecha_Vacunacion.SelectedDate = Nothing
                rfv_Fecha_Esquema_Vacunacion.Enabled = False
        End Select

    End Sub

    Protected Sub ddlSubTablasId_Ninos_Vacunados_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_Ninos_Vacunados.SelectedIndexChanged
        Select Case ddl_Ninos_Vacunados.SelectedValue
            Case 20
                ddl_Motivo_No_Vacunados.Enabled = True
                revMotivo_No_Vacunados.Enabled = True
                rdpfecha_Vacunacion.Enabled = False
                rfv_Fecha_Esquema_Vacunacion.Enabled = False
                rdpfecha_Vacunacion.SelectedDate = Nothing
            Case 19
                rdpfecha_Vacunacion.Enabled = True
                rfv_Fecha_Esquema_Vacunacion.Enabled = True
                ddl_Motivo_No_Vacunados.Enabled = False
                revMotivo_No_Vacunados.Enabled = False
                ddl_Motivo_No_Vacunados.SelectedValue = 0

            Case Else
                ddl_Motivo_No_Vacunados.Enabled = False
                revMotivo_No_Vacunados.Enabled = False
                ddl_Motivo_No_Vacunados.SelectedValue = 0
                rdpfecha_Vacunacion.Enabled = False
                rfv_Fecha_Esquema_Vacunacion.Enabled = False

        End Select
    End Sub

    Protected Sub btn_calcular_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_calcular.Click
        ' Fecha
        Dim objpersona As PersonasBrl = CType(Session("Persona"), PersonasBrl)
        Dim wmesnac, wanonac, wdianac, wmesval, wanoval, wdiaval As Integer
        Dim wmeses As Integer = 0
        Dim wanos As Integer = 0

        If rdpfechaValoracion.SelectedDate.ToString.Trim <> "" Then


            ' Calculando la edad actual despues del cambio de Fecha actual de valoracion
            If objpersona.Fecha_Nacimiento.ToString <> "" Then
                wanonac = Year(objpersona.Fecha_Nacimiento)
                wmesnac = Month(objpersona.Fecha_Nacimiento)
                wdianac = Day(objpersona.Fecha_Nacimiento)
                wanoval = Mid(rdpfechaValoracion.SelectedDate.ToString.Trim, 7, 4)
                wmesval = Mid(rdpfechaValoracion.SelectedDate.ToString.Trim, 4, 2)
                wdiaval = Mid(rdpfechaValoracion.SelectedDate.ToString.Trim, 1, 2)

                wanos = wanoval - wanonac
                If wmesval > wmesnac Then
                    wmeses = wmesval - wmesnac
                    If wdiaval < wdianac Then
                        wmeses = wmeses - 1
                    End If
                End If
                If wmesval = wmesnac Then
                    If wdiaval >= wdianac Then
                        wmeses = 0
                    End If
                    If wdiaval < wdianac Then
                        wanos = wanos - 1
                        wmeses = 11
                    End If
                End If

                If wmesval < wmesnac Then
                    wmeses = 12 + wmesval - wmesnac
                    wanos = wanos - 1
                    If wdiaval < wdianac Then
                        wmeses = wmeses - 1
                    End If
                End If


            End If
            Lbl_Edad_Anos_Actual.Text = Str(wanos)
            Lbl_Edad_Meses_Actual.Text = Str(wmeses)
        End If
        '
        'Peso / Edad
        '
        If txt_peso_edad.Text.Trim <> "" Then

            Dim wvalor As Double = 0
            wmeses = (Val(Lbl_Edad_Anos_Actual.Text) * 12 + Val(Lbl_Edad_Meses_Actual.Text))
            If wmeses <= 23 Then
                wvalor = Val(txt_peso_edad.Text.Trim)
                Select Case wvalor
                    Case Is > 2
                        txt_Estado_Nutricional.Text = "Obesidad"
                    Case 1.01 To 2
                        txt_Estado_Nutricional.Text = "Sobrepeso"
                    Case -0.99 To 1
                        txt_Estado_Nutricional.Text = "Adecuado"
                    Case -1.99 To -1
                        txt_Estado_Nutricional.Text = "RDNT global"
                    Case Is <= -2
                        txt_Estado_Nutricional.Text = "Desnutrición Global"
                End Select
            End If
        End If
        '
        'Peso /Talla
        '
        If txt_peso_talla.Text.Trim <> "" Then

            wmeses = (Val(Lbl_Edad_Anos_Actual.Text) * 12 + Val(Lbl_Edad_Meses_Actual.Text))
            If wmeses <= 59 And wmeses >= 24 Then
                Select Case Val(txt_peso_talla.Text)
                    Case Is > 2
                        txt_Estado_Nutricional.Text = "Obesidad"
                    Case 1.01 To 2
                        txt_Estado_Nutricional.Text = "Sobrepeso"
                    Case -0.99 To 1
                        txt_Estado_Nutricional.Text = "Adecuado"
                    Case -1.99 To -1
                        txt_Estado_Nutricional.Text = "RDNT Aguda"
                    Case Is <= -2
                        txt_Estado_Nutricional.Text = "Desnutrición Aguda"
                End Select
            End If
        End If
        '
        'Talla / Longitud
        '
        If txt_talla_longitud.Text.Trim <> "" Then
            wmeses = (Val(Lbl_Edad_Anos_Actual.Text) * 12 + Val(Lbl_Edad_Meses_Actual.Text))
            If wmeses <= 59 Then
                Select Case Val(txt_talla_longitud.Text)
                    Case Is >= -0.99
                        Txt_Valoracion_TE.Text = "Adecuado"
                    Case -1.99 To -1
                        Txt_Valoracion_TE.Text = "Riesgo de Talla Baja"
                    Case Is <= -2
                        Txt_Valoracion_TE.Text = "Talla Baja"

                End Select
            End If
        End If
        '
        'Peso 
        '
        Dim wvlr01 As Double
        Dim wvlr02 As Integer

        If txt_peso.Text <> "" Then
            Dim wid As Int32
            If lblidsalud.Text.Trim <> "" Then
                Dim objpesoantsaludval As New Salud_ValoracionBrl
                If lblIdValoracion.Text = "" Then wid = 0 Else wid = Val(lblIdValoracion.Text)
                objpesoantsaludval = Salud_ValoracionBrl.CargarPorUltimoRegistro(lblidsalud.Text, wid, rdpfechaValoracion.SelectedDate.ToString)
                If objpesoantsaludval Is Nothing Then
                    txt_Diferencia_Peso.Text = "0"
                Else
                    wvlr01 = CType(txt_peso.Text, Double) - objpesoantsaludval.Antropometria_Peso
                    wvlr02 = Int(wvlr01 * 100)
                    wvlr01 = wvlr02 / 100
                    txt_Diferencia_Peso.Text = wvlr01
                End If
            End If
        End If
    End Sub

    Protected Sub ddl_Crecimiento_Desarrollo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_Crecimiento_Desarrollo.SelectedIndexChanged
        If ddl_Crecimiento_Desarrollo.SelectedValue = 20 Then ' NO
            ddl_Motivo_Crecimiento_Desarrollo.Enabled = True
            rev_Motivo_CYD.Enabled = True
        Else
            ddl_Motivo_Crecimiento_Desarrollo.Enabled = False
            rev_Motivo_CYD.Enabled = False
            ddl_Motivo_Crecimiento_Desarrollo.SelectedValue = 0
        End If
    End Sub

    Protected Sub ddlId_Crecimiento_Desarrollo_IRD_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_Crecimiento_Desarrollo_IRD.SelectedIndexChanged
        If ddl_Crecimiento_Desarrollo_IRD.SelectedValue = 20 Then ' NO
            ddl_Motivo_Crecimiento_Desarrollo_IRD.Enabled = True

        Else
            ddl_Motivo_Crecimiento_Desarrollo_IRD.Enabled = False

            ddl_Motivo_Crecimiento_Desarrollo_IRD.SelectedValue = 0
        End If
    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/SaludList.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        If Request.QueryString.Item("Id") > 0 Then
            Response.Redirect("../webforms/Salud.aspx?Editar=1&Id=" + Request.QueryString.Item("Id"))
        End If
    End Sub
End Class
