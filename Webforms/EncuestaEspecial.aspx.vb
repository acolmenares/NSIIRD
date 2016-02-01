Imports ingNovar.Utilidades2
Imports System.Collections.Generic

Partial Class WebForms_EncuestaEspecial
    Inherits System.Web.UI.Page

    Dim wmensaje As String = ""

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


            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToCsvButton = objper_perfil.Pexportarcsv
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToExcelButton = objper_perfil.Pexportarexcel
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToPdfButton = objper_perfil.Pexportarpdf
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToWordButton = objper_perfil.Pexportarword

            Rg_Regimen.MasterTableView.CommandItemSettings.ShowExportToCsvButton = objper_perfil.Pexportarcsv
            Rg_Regimen.MasterTableView.CommandItemSettings.ShowExportToExcelButton = objper_perfil.Pexportarexcel
            Rg_Regimen.MasterTableView.CommandItemSettings.ShowExportToPdfButton = objper_perfil.Pexportarpdf
            Rg_Regimen.MasterTableView.CommandItemSettings.ShowExportToWordButton = objper_perfil.Pexportarword

        End If

        If objper_usuario IsNot Nothing Then
            If objper_usuario.Pver = False Or objper_usuario.Pconsultar = False Then
                Response.Redirect(strPaginaError)
                Exit Sub
            End If

            ' asignando los permisos

            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToCsvButton = objper_usuario.Pexportarcsv
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToExcelButton = objper_usuario.Pexportarexcel
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToPdfButton = objper_usuario.Pexportarpdf
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToWordButton = objper_usuario.Pexportarword

            Rg_Regimen.MasterTableView.CommandItemSettings.ShowExportToCsvButton = objper_usuario.Pexportarcsv
            Rg_Regimen.MasterTableView.CommandItemSettings.ShowExportToExcelButton = objper_usuario.Pexportarexcel
            Rg_Regimen.MasterTableView.CommandItemSettings.ShowExportToPdfButton = objper_usuario.Pexportarpdf
            Rg_Regimen.MasterTableView.CommandItemSettings.ShowExportToWordButton = objper_usuario.Pexportarword


        End If

        ' Definiendo el dato de la regional
        'ddl_Regional.SelectedValue = SeguridadUsuarios.Usuarios.RegionalUsuario(CType(Session("IdUsuario"), Integer))

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


        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_haoidoasociaciones, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_pertenece_asociacion, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_emociones, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Afectado_Desplazamiento, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_apoyo_emocional, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_emociones, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_aliviado, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_comprender_miedos, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_escuchado, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_ayuda_personas, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_habilidades_salir, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_bienestar_emocional, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_relaciones_familia, 4, New ListItem("Seleccione", 0))

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_momentos, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_identificar_organizaciones, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_identificar_instituciones, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_sirvio, 4, New ListItem("Seleccione", 0))

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_unidos, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_familiasAccion, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_sirvio, 4, New ListItem("Seleccione", 0))


        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(Lst_PersonasAyuda, 88)
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(Lst_ApoyoPersonas, 89)
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(Lst_FuentesIngreso, 24)

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Estudia_Actualmente, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Certificado, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Seguimiento, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_MotivoNoestudio, 5, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_GradoEscolar, 18, New ListItem("Seleccione", 0))

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_regimen, 7, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_eps, 30, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_icbf, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Necesita_Traslado, 4, New ListItem("Seleccione", 0))


        Dim ListEmociones As List(Of SubTablasBrl)
        ListEmociones = SubTablasBrl.CargarPorId_Tabla(87)
        Dg_Emociones.DataSource = ListEmociones
        Dg_Emociones.DataBind()

        pnl_regimen_salud.Visible = False
        pnl_educacion.Visible = False

        '
        ' cargando Informacion
        '
        Dim objseguimiento As New Declaracion_SeguimientosBrl

        If Request.QueryString.Item("Editar") = 1 Then

            objseguimiento = Declaracion_SeguimientosBrl.CargarPorID(Request.QueryString.Item("ID"))

            If objseguimiento Is Nothing Then
                objseguimiento = New Declaracion_SeguimientosBrl
            End If

            rdpfecha.SelectedDate = objseguimiento.Fecha
            If ddl_haoidoasociaciones.Items.FindByValue(objseguimiento.Id_Oido_OVD) IsNot Nothing Then ddl_haoidoasociaciones.SelectedValue = objseguimiento.Id_Oido_OVD
            If ddl_pertenece_asociacion.Items.FindByValue(objseguimiento.Id_Pertenece_OVD) IsNot Nothing Then ddl_pertenece_asociacion.SelectedValue = objseguimiento.Id_Pertenece_OVD
            txt_Asociacion.Text = objseguimiento.Cual_OVD
            Txt_ingresos.Text = Format(objseguimiento.Ingresos_Mensuales, "C")
            If ddl_Afectado_Desplazamiento.Items.FindByValue(objseguimiento.Id_Afectado_Desplazamiento) IsNot Nothing Then ddl_Afectado_Desplazamiento.SelectedValue = objseguimiento.Id_Afectado_Desplazamiento
            If ddl_apoyo_emocional.Items.FindByValue(objseguimiento.Id_Apoyo_Emocional) IsNot Nothing Then ddl_apoyo_emocional.SelectedValue = objseguimiento.Id_Apoyo_Emocional

            If Me.ddl_emociones.Items.FindByValue(objseguimiento.Id_Emociones) IsNot Nothing Then ddl_emociones.SelectedValue = objseguimiento.Id_Emociones
            ddl_emociones_SelectedIndexChanged(Nothing, Nothing)
            If Me.ddl_aliviado.Items.FindByValue(objseguimiento.Id_Aliviado) IsNot Nothing Then ddl_aliviado.SelectedValue = objseguimiento.Id_Aliviado
            If Me.ddl_comprender_miedos.Items.FindByValue(objseguimiento.Id_Comprender_Miedos) IsNot Nothing Then ddl_comprender_miedos.SelectedValue = objseguimiento.Id_Comprender_Miedos
            If Me.ddl_escuchado.Items.FindByValue(objseguimiento.Id_Escuchado_Grupo) IsNot Nothing Then ddl_escuchado.SelectedValue = objseguimiento.Id_Escuchado_Grupo
            If Me.ddl_ayuda_personas.Items.FindByValue(objseguimiento.Id_Ayuda_Barrio) IsNot Nothing Then ddl_ayuda_personas.SelectedValue = objseguimiento.Id_Ayuda_Barrio
            If Me.ddl_habilidades_salir.Items.FindByValue(objseguimiento.Id_Identificar_Habilidades) IsNot Nothing Then ddl_habilidades_salir.SelectedValue = objseguimiento.Id_Identificar_Habilidades
            If Me.ddl_bienestar_emocional.Items.FindByValue(objseguimiento.Id_Ayuda_Bienestar) IsNot Nothing Then ddl_bienestar_emocional.SelectedValue = objseguimiento.Id_Ayuda_Bienestar
            If Me.ddl_relaciones_familia.Items.FindByValue(objseguimiento.Id_Relaciones_Familia) IsNot Nothing Then ddl_relaciones_familia.SelectedValue = objseguimiento.Id_Relaciones_Familia
            If Me.ddl_momentos.Items.FindByValue(objseguimiento.Id_Momentos_Dificiles) IsNot Nothing Then ddl_momentos.SelectedValue = objseguimiento.Id_Momentos_Dificiles
            If Me.ddl_identificar_organizaciones.Items.FindByValue(objseguimiento.Id_Identificar_Organizaciones) IsNot Nothing Then ddl_identificar_organizaciones.SelectedValue = objseguimiento.Id_Identificar_Organizaciones
            If Me.ddl_identificar_instituciones.Items.FindByValue(objseguimiento.Id_Identificar_Instituciones) IsNot Nothing Then ddl_identificar_instituciones.SelectedValue = objseguimiento.Id_Identificar_Instituciones
            If Me.ddl_sirvio.Items.FindByValue(objseguimiento.Id_No_Sirvio) IsNot Nothing Then ddl_sirvio.SelectedValue = objseguimiento.Id_No_Sirvio

            If Me.ddl_unidos.Items.FindByValue(objseguimiento.Id_Unidos) IsNot Nothing Then ddl_unidos.SelectedValue = objseguimiento.Id_Unidos
            ddl_unidos_SelectedIndexChanged(Nothing, Nothing)
            If Me.ddl_familiasAccion.Items.FindByValue(objseguimiento.Id_Familias_Accion) IsNot Nothing Then ddl_familiasAccion.SelectedValue = objseguimiento.Id_Familias_Accion
            If Me.ddl_icbf.Items.FindByValue(objseguimiento.Id_Alimentos_ICBF) IsNot Nothing Then ddl_icbf.SelectedValue = objseguimiento.Id_Alimentos_ICBF
            txt_municipio_unidos.Text = objseguimiento.Municipio_Unidos


            ' Cargando las listas

            Dim ListPersonasAyuda As List(Of Declaracion_Personas_AyudaBrl)
            ListPersonasAyuda = Declaracion_Personas_AyudaBrl.CargarPorId_Declaracion_Seguimiento(objseguimiento.ID)
            For Each fila As Declaracion_Personas_AyudaBrl In ListPersonasAyuda
                Lst_PersonasAyuda_Declarante.Items.Add(New ListItem(fila.Personas_Ayuda.Descripcion, fila.Id_Personas_Ayuda))
            Next

            Dim ListApoyoPersonas As List(Of Declaracion_Apoyo_AyudaBrl)
            ListApoyoPersonas = Declaracion_Apoyo_AyudaBrl.CargarPorId_Declaracion_Seguimiento(objseguimiento.ID)
            For Each fila As Declaracion_Apoyo_AyudaBrl In ListApoyoPersonas
                Lst_ApoyoPersonas_Declarante.Items.Add(New ListItem(fila.Apoyo_Ayuda.Descripcion, fila.Id_Apoyo_Ayuda))
            Next

            Dim ListFuentesIngresoDeclarante As List(Of Declaracion_Fuentes_IngresoBrl)
            ListFuentesIngresoDeclarante = Declaracion_Fuentes_IngresoBrl.CargarPorId_Declaracion_Seguimiento(objseguimiento.ID)
            For Each fila As Declaracion_Fuentes_IngresoBrl In ListFuentesIngresoDeclarante
                Lst_FuentesIngresoDeclarante.Items.Add(New ListItem(fila.Fuentes_Ingreso.Descripcion, fila.Id_Fuentes_Ingreso))
            Next


            ' cargando la inrformacion adicional
            lbl_Nombre_Completo.Text = objseguimiento.Declaracion.Personas_Declarante.NombreCompleto
            Try
                lbl_Programa.Text = objseguimiento.Entregas_Adicionales_Personas.Item(0).Entregas_Adicionales.Programa.Numero
            Catch ex As Exception
                lbl_Programa.Text = "Presento Error !!!!"
            End Try

            txt_Observaciones.Text = objseguimiento.Observaciones



            ' Validaciones

            ddl_haoidoasociaciones_SelectedIndexChanged(Nothing, Nothing)
            ddl_pertenece_asociacion_SelectedIndexChanged(Nothing, Nothing)
            '
            '
            ' Emociones de lo Psicosocial
            '
            Dim lblidemo As Label
            Dim ddl_emociones_usted, ddl_emociones_familia As DropDownList
            For Each fila As DataGridItem In Dg_Emociones.Items
                If fila.ItemType = ListItemType.AlternatingItem Or fila.ItemType = ListItemType.Item Then
                    lblidemo = fila.FindControl("lblid")
                    ddl_emociones_usted = fila.FindControl("ddl_emociones_usted")
                    ddl_emociones_familia = fila.FindControl("ddl_emociones_familia")
                    Dim Listemocion As List(Of Declaracion_PsicosocialBrl) = Declaracion_PsicosocialBrl.CargarPorId_Declaracion_Seguimiento(objseguimiento.ID)
                    FilterHelper.FilterHelper(Listemocion, "Id_Emocion", lblidemo.Text)
                    If Listemocion.Count > 0 Then
                        ddl_emociones_usted.SelectedValue = Listemocion.Item(0).Dato_Usted
                        ddl_emociones_familia.SelectedValue = Listemocion.Item(0).Dato_Familia
                    End If
                End If
            Next

            Session("Beneficiarios") = objseguimiento.Entregas_Adicionales_Personas.Item(0).Personas.Declaracion.PersonasEducacionPendiente
            Rg_Listado.DataSource = Session("Beneficiarios")
            Rg_Listado.DataBind()

            Session("ListRegimenSalud") = objseguimiento.Entregas_Adicionales_Personas.Item(0).Personas.Declaracion.Personas
            Rg_Regimen.DataSource = Session("ListRegimenSalud")
            Rg_Regimen.DataBind()

            'Session("Psicosocial") = objdeclaracion.Personas
            'Dg_Psicosocial.DataSource = Session("Psicosocial")
            'Dg_Psicosocial.DataBind()

            pnl_regimen_salud.Visible = True
            pnl_educacion.Visible = True

        End If



    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Validate("SE")
        If Not IsValid Then Exit Sub

        Dim ID As Int32

        Try
            ID = Grabar()

            Response.Redirect("EncuestaEspecial.aspx?Editar=1&Mensaje=1&ID=" & ID & "&Id_Declaracion=" & Request.QueryString.Item("Id_Declaracion") & "&IdEAP=" & Request.QueryString.Item("IdEAP"))
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Private Function Grabar() As Int32

        Dim objseguimiento As New Declaracion_SeguimientosBrl

        If Request.QueryString.Item("Editar") = 1 Then
            objseguimiento = Declaracion_SeguimientosBrl.CargarPorID(Request.QueryString.Item("ID"))
            If objseguimiento Is Nothing Then
                objseguimiento = New Declaracion_SeguimientosBrl

            End If
        End If

        objseguimiento.Fecha = rdpfecha.DbSelectedDate
        objseguimiento.Id_Declaracion = Request.QueryString.Item("Id_Declaracion")

        Dim objentrega As Entregas_Adicionales_PersonasBrl = Entregas_Adicionales_PersonasBrl.CargarPorID(Request.QueryString.Item("IdEAP"))
        objseguimiento.Id_Tipo_Entrega = objentrega.Entregas_Adicionales.Programa.Id_TipoEntrega

        objseguimiento.Id_Oido_OVD = ddl_haoidoasociaciones.SelectedValue
        objseguimiento.Id_Pertenece_OVD = ddl_pertenece_asociacion.SelectedValue
        objseguimiento.Cual_OVD = txt_Asociacion.Text
        objseguimiento.Ingresos_Mensuales = Txt_ingresos.Text
        objseguimiento.Id_Afectado_Desplazamiento = ddl_Afectado_Desplazamiento.SelectedValue
        objseguimiento.Id_Emociones = ddl_emociones.SelectedValue
        objseguimiento.Id_Aliviado = ddl_aliviado.SelectedValue
        objseguimiento.Id_Comprender_Miedos = ddl_comprender_miedos.SelectedValue
        objseguimiento.Id_Escuchado_Grupo = ddl_escuchado.SelectedValue
        objseguimiento.Id_Ayuda_Barrio = ddl_ayuda_personas.SelectedValue
        objseguimiento.Id_Identificar_Habilidades = Me.ddl_habilidades_salir.SelectedValue
        objseguimiento.Id_Ayuda_Bienestar = Me.ddl_bienestar_emocional.SelectedValue
        objseguimiento.Id_Relaciones_Familia = Me.ddl_relaciones_familia.SelectedValue
        objseguimiento.Id_Momentos_Dificiles = Me.ddl_momentos.SelectedValue
        objseguimiento.Id_Identificar_Organizaciones = Me.ddl_identificar_organizaciones.SelectedValue
        objseguimiento.Id_Identificar_Instituciones = Me.ddl_identificar_instituciones.SelectedValue
        objseguimiento.Id_No_Sirvio = Me.ddl_sirvio.SelectedValue
        objseguimiento.Id_Apoyo_Emocional = Me.ddl_apoyo_emocional.SelectedValue
        objseguimiento.Id_Unidos = ddl_unidos.SelectedValue
        objseguimiento.Municipio_Unidos = txt_municipio_unidos.Text
        objseguimiento.Id_Familias_Accion = Me.ddl_familiasAccion.SelectedValue
        objseguimiento.Id_Alimentos_ICBF = Me.ddl_icbf.SelectedValue
        objseguimiento.Observaciones = txt_Observaciones.Text
        objseguimiento.Guardar()

        ' Grabar la  informacion de las listas 
        ' Generalmente es actualizar.
        ' Primero se elimina lo existente

        Dim listPersonasAyudaDec As List(Of Declaracion_Personas_AyudaBrl)
        listPersonasAyudaDec = Declaracion_Personas_AyudaBrl.CargarPorId_Declaracion_Seguimiento(objseguimiento.ID)
        For Each fila As Declaracion_Personas_AyudaBrl In listPersonasAyudaDec
            fila.Eliminar()
        Next

        Dim listApoyoAyudaDec As List(Of Declaracion_Apoyo_AyudaBrl)
        listApoyoAyudaDec = Declaracion_Apoyo_AyudaBrl.CargarPorId_Declaracion_Seguimiento(objseguimiento.ID)
        For Each fila As Declaracion_Apoyo_AyudaBrl In listApoyoAyudaDec
            fila.Eliminar()
        Next

        Dim ListFuentesIngresoDec As List(Of Declaracion_Fuentes_IngresoBrl)
        ListFuentesIngresoDec = Declaracion_Fuentes_IngresoBrl.CargarPorId_Declaracion_Seguimiento(objseguimiento.ID)
        For Each fila As Declaracion_Fuentes_IngresoBrl In ListFuentesIngresoDec
            fila.Eliminar()
        Next

        ' grabando los nuevos registros

        Dim objpersonasayudadec As Declaracion_Personas_AyudaBrl
        For Each detalle As ListItem In Me.Lst_PersonasAyuda_Declarante.Items
            objpersonasayudadec = New Declaracion_Personas_AyudaBrl
            objpersonasayudadec.Id_Declaracion = objseguimiento.Id_Declaracion
            objpersonasayudadec.Id_Personas_Ayuda = detalle.Value
            objpersonasayudadec.Id_Tipo_Entrega = objentrega.Entregas_Adicionales.Programa.Id_TipoEntrega
            objpersonasayudadec.Id_Declaracion_Seguimiento = objseguimiento.ID
            objpersonasayudadec.Guardar()
        Next

        Dim objapoyoayudadec As Declaracion_Apoyo_AyudaBrl
        For Each detalle As ListItem In Me.Lst_ApoyoPersonas_Declarante.Items
            objapoyoayudadec = New Declaracion_Apoyo_AyudaBrl
            objapoyoayudadec.Id_Declaracion = objseguimiento.Id_Declaracion
            objapoyoayudadec.Id_Apoyo_Ayuda = detalle.Value
            objapoyoayudadec.Id_Tipo_Entrega = objentrega.Entregas_Adicionales.Programa.Id_TipoEntrega
            objapoyoayudadec.Id_Declaracion_Seguimiento = objseguimiento.ID
            objapoyoayudadec.Guardar()
        Next

        Dim objfueingdec As Declaracion_Fuentes_IngresoBrl
        For Each detalle As ListItem In Me.Lst_FuentesIngresoDeclarante.Items
            objfueingdec = New Declaracion_Fuentes_IngresoBrl
            objfueingdec.Id_Declaracion = objseguimiento.Id_Declaracion
            objfueingdec.Id_Fuentes_Ingreso = detalle.Value
            objfueingdec.Id_Tipo_Entrega = objentrega.Entregas_Adicionales.Programa.Id_TipoEntrega
            objfueingdec.Id_Declaracion_Seguimiento = objseguimiento.ID
            objfueingdec.Fecha_Creacion = Now
            objfueingdec.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
            objfueingdec.Guardar()
        Next

        '
        '  Guardo emociones
        '
        Dim objemocion As New Declaracion_PsicosocialBrl
        Dim lblidemo As Label
        Dim ddl_emociones_usted, ddl_emociones_familia As DropDownList
        For Each fila As DataGridItem In Dg_Emociones.Items
            If fila.ItemType = ListItemType.AlternatingItem Or fila.ItemType = ListItemType.Item Then
                lblidemo = fila.FindControl("lblid")
                ddl_emociones_usted = fila.FindControl("ddl_emociones_usted")
                ddl_emociones_familia = fila.FindControl("ddl_emociones_familia")
                Dim Listemociones As List(Of Declaracion_PsicosocialBrl) = Declaracion_PsicosocialBrl.CargarPorId_Declaracion_Seguimiento(objseguimiento.ID)
                FilterHelper.FilterHelper(Listemociones, "Id_Emocion", lblidemo.Text)
                If Listemociones.Count = 0 Then ' Nuevo
                    objemocion = New Declaracion_PsicosocialBrl
                    objemocion.Id_Declaracion = objseguimiento.Id_Declaracion
                Else
                    objemocion = Listemociones.Item(0)
                End If

                objemocion.Id_Emocion = lblidemo.Text
                objemocion.Id_Tipo_Entrega = objentrega.Entregas_Adicionales.Programa.Id_TipoEntrega
                objemocion.Dato_Usted = ddl_emociones_usted.SelectedValue
                objemocion.Dato_Familia = ddl_emociones_familia.SelectedValue
                objemocion.Id_Declaracion_Seguimiento = objseguimiento.ID
                objemocion.Guardar()
            End If
        Next

        '
        '  Guardo el registro de la encuesta en la entrega adicional persona
        '
        If Request.QueryString.Item("Editar") Is Nothing Then
            Dim objentregaespecial As Entregas_Adicionales_PersonasBrl = Entregas_Adicionales_PersonasBrl.CargarPorID(Request.QueryString.Item("IdEAP"))
            objentregaespecial.Id_Declaracion_Seguimiento = objseguimiento.ID
            objentregaespecial.Guardar()
        End If

        Return objseguimiento.ID

    End Function

    Protected Sub ddl_haoidoasociaciones_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_haoidoasociaciones.SelectedIndexChanged
        If ddl_haoidoasociaciones.SelectedValue = 19 Then
            ddl_pertenece_asociacion.Enabled = True
            rev_Pertenece_Asociacion.Enabled = True
        Else
            ddl_pertenece_asociacion.Enabled = False
            rev_Pertenece_Asociacion.Enabled = False
            ddl_pertenece_asociacion.SelectedValue = 0
        End If
        ddl_pertenece_asociacion_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Protected Sub ddl_pertenece_asociacion_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_pertenece_asociacion.SelectedIndexChanged
        If ddl_pertenece_asociacion.SelectedValue = 19 Then
            txt_Asociacion.Enabled = True
            rfv_Nombre_Asociacion.Enabled = True
        Else
            txt_Asociacion.Enabled = False
            rfv_Nombre_Asociacion.Enabled = False
            txt_Asociacion.Text = ""
        End If
    End Sub

    Protected Sub Rg_Listado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rg_Listado.SelectedIndexChanged
        Dim item As Telerik.Web.UI.GridDataItem = Me.Rg_Listado.SelectedItems.Item(Rg_Listado.SelectedIndexes.Item(0))
        Dim objpersona As PersonasBrl = PersonasBrl.CargarPorID(item("Id").Text)
        lblId.Text = ""
        LblIdPersona.Text = ""
        ddl_Estudia_Actualmente.SelectedValue = 0
        ddl_Estudia_Actualmente.Enabled = False
        rev_EstudiaActualmente.Enabled = False
        Txt_Establecimiento.Text = ""
        ddl_MotivoNoestudio.SelectedValue = 0
        ddl_Certificado.SelectedValue = 0
        ddl_GradoEscolar.SelectedValue = 0
        ddl_Seguimiento.SelectedValue = 0
        btn_GrabarBeneficiario.Enabled = False

        If objpersona IsNot Nothing Then
            Dim ListEducacion As List(Of Personas_EducacionBrl) = Personas_EducacionBrl.CargarPorId_Declaracion_Seguimiento(Request.QueryString.Item("Id"))
            FilterHelper.FilterHelper(ListEducacion, "Id_Persona", objpersona.ID)
            If ListEducacion.Count > 0 Then

                lblId.Text = ListEducacion.Item(0).ID
                ddl_Estudia_Actualmente.SelectedValue = ListEducacion.Item(0).Id_Estudia_Actualmente
                ddl_Estudia_Actualmente_SelectedIndexChanged(Nothing, Nothing)

                Txt_Establecimiento.Text = ListEducacion.Item(0).Establecimiento
                ddl_MotivoNoestudio.SelectedValue = ListEducacion.Item(0).Id_Motivo_NoEstudia
                ddl_MotivoNoestudio_SelectedIndexChanged(Nothing, Nothing)

                If ddl_Certificado.Items.FindByValue(ListEducacion.Item(0).Id_Certificado_Matricula) IsNot Nothing Then ddl_Certificado.SelectedValue = ListEducacion.Item(0).Id_Certificado_Matricula
                ddl_GradoEscolar.SelectedValue = ListEducacion.Item(0).Id_grado_escolar
                ddl_Seguimiento.SelectedValue = ListEducacion.Item(0).Id_Seguimiento
            End If
            '
            lbl_NC.Text = objpersona.NombreCompleto
            LblIdPersona.Text = objpersona.ID
            ddl_Estudia_Actualmente.Enabled = True
            rev_EstudiaActualmente.Enabled = True
            btn_GrabarBeneficiario.Enabled = True

        End If
    End Sub

    Protected Sub ddl_Estudia_Actualmente_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_Estudia_Actualmente.SelectedIndexChanged

        ddl_MotivoNoestudio.Enabled = False
        rev_MotivoNoestudia.Enabled = False
        ddl_MotivoNoestudio.SelectedValue = 0
        ddl_Certificado.Enabled = False
        ddl_Certificado.SelectedValue = 0
        rev_certificado.Enabled = False
        Txt_Establecimiento.Text = ""
        Txt_Establecimiento.Enabled = False
        rfv_establecimiento.Enabled = False
        ddl_GradoEscolar.Enabled = False
        ddl_GradoEscolar.SelectedValue = 0
        rev_gradoescolar.Enabled = False

        If ddl_Estudia_Actualmente.SelectedValue = 20 Then
            ddl_MotivoNoestudio.Enabled = True
            rev_MotivoNoestudia.Enabled = True
            SetFocus(ddl_MotivoNoestudio)
        End If

        If ddl_Estudia_Actualmente.SelectedValue = 19 Then
            Txt_Establecimiento.Enabled = True
            rfv_establecimiento.Enabled = True
            ddl_GradoEscolar.Enabled = True
            rev_gradoescolar.Enabled = True
            ddl_Certificado.Enabled = True
            rev_certificado.Enabled = True
            SetFocus(ddl_Certificado)
        End If

        'ddl_MotivoNoestudio_SelectedIndexChanged(Nothing, Nothing)


    End Sub

    Protected Sub btn_GrabarBeneficiario_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_GrabarBeneficiario.Click
        If LblIdPersona.Text <> "" Then

            Validate("BE")
            lblerror.Visible = False
            If Not IsValid Then
                lblerror.Visible = True
                Exit Sub
            End If

            Dim objentrega As Entregas_Adicionales_PersonasBrl = Entregas_Adicionales_PersonasBrl.CargarPorID(Request.QueryString.Item("IdEAP"))

            Dim objeducacion As Personas_EducacionBrl
            ' Grabar el beneficiario
            If lblId.Text.Trim = "" Then
                objeducacion = New Personas_EducacionBrl
                objeducacion.Id_Persona = LblIdPersona.Text
                objeducacion.Id_Tipo_Entrega = objentrega.Entregas_Adicionales.Programa.Id_TipoEntrega
                objeducacion.Id_Declaracion_Seguimiento = Request.QueryString.Item("Id")
            Else
                objeducacion = Personas_EducacionBrl.CargarPorID(lblId.Text)
            End If

            objeducacion.Id_Certificado_Matricula = ddl_Certificado.SelectedValue
            objeducacion.Id_Estudia_Actualmente = ddl_Estudia_Actualmente.SelectedValue
            objeducacion.Id_grado_escolar = ddl_GradoEscolar.SelectedValue
            objeducacion.Id_Motivo_NoEstudia = ddl_MotivoNoestudio.SelectedValue
            objeducacion.Id_Seguimiento = ddl_Seguimiento.SelectedValue
            objeducacion.Establecimiento = Txt_Establecimiento.Text


            Try
                objeducacion.Fecha = rdpfecha.SelectedDate
            Catch ex As Exception
                objeducacion.Fecha = Now()
            End Try
            lblerror.Visible = False
            Try

                objeducacion.Guardar()

                lblId.Text = ""
                LblIdPersona.Text = ""
                lbl_NC.Text = ""
                ddl_Estudia_Actualmente.SelectedValue = 0
                ddl_Estudia_Actualmente_SelectedIndexChanged(Nothing, Nothing)
                Dim objpersonas As List(Of PersonasBrl) = PersonasBrl.CargarPorId_Declaracion_EducacionPendiente(Request.QueryString.Item("Id_Declaracion"))
                Session("Beneficiarios") = objpersonas
                Rg_Listado.DataSource = Session("Beneficiarios")
                Rg_Listado.DataBind()
            Catch ex As Exception
                lblerror.Visible = True
            End Try
        End If

    End Sub

    Protected Sub Lst_FuentesIngreso_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lst_FuentesIngreso.SelectedIndexChanged
        Lst_FuentesIngresoDeclarante.Items.Add(New ListItem(Lst_FuentesIngreso.SelectedItem.Text, Lst_FuentesIngreso.SelectedItem.Value))
        Lst_FuentesIngreso.Items.RemoveAt(Lst_FuentesIngreso.SelectedIndex)
    End Sub

    Protected Sub Lst_FuentesIngresoDeclarante_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lst_FuentesIngresoDeclarante.SelectedIndexChanged
        Lst_FuentesIngreso.Items.Add(New ListItem(Lst_FuentesIngresoDeclarante.SelectedItem.Text, Lst_FuentesIngresoDeclarante.SelectedItem.Value))
        Lst_FuentesIngresoDeclarante.Items.RemoveAt(Lst_FuentesIngresoDeclarante.SelectedIndex)
    End Sub

    Protected Sub btn_GrabarRegimen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_GrabarRegimen.Click
        If lblidpersonars.Text <> "" Then

            Validate("RS")
            lblerror1.Visible = False
            If Not IsValid Then
                lblerror1.Visible = True
                Exit Sub
            End If

            Dim objregimen As Personas_Regimen_SaludBrl
            Dim objentrega As Entregas_Adicionales_PersonasBrl = Entregas_Adicionales_PersonasBrl.CargarPorID(Request.QueryString.Item("IdEAP"))

            ' Grabar el beneficiario
            If lblidrs.Text.Trim = "" Then
                objregimen = New Personas_Regimen_SaludBrl
                objregimen.Id_Persona = lblidpersonars.Text
                objregimen.Fecha = rdpfecha.DbSelectedDate
                objregimen.Id_Tipo_Entrega = objentrega.Entregas_Adicionales.Programa.Id_TipoEntrega
                objregimen.Id_Declaracion_Seguimiento = Request.QueryString.Item("Id")
            Else
                objregimen = Personas_Regimen_SaludBrl.CargarPorID(lblidrs.Text)
            End If

            objregimen.Id_Regimen_Salud = ddl_regimen.SelectedValue

            objregimen.Id_Eps = ddl_eps.SelectedValue
            objregimen.Municipio = txt_municipio_regimen.Text
            objregimen.Id_Cerrar = 20
            objregimen.Id_Necesita_Traslado = ddl_Necesita_Traslado.SelectedValue
            lblerror1.Visible = False


            Try

                objregimen.Guardar()
                lblidrs.Text = ""
                lblidpersonars.Text = ""
                lbl_NC2.Text = ""
                ddl_regimen.SelectedValue = 0
                ddl_eps.SelectedValue = 0
                txt_municipio_regimen.Text = ""
                ddl_Necesita_Traslado.SelectedValue = 0
                Dim objpersonasregimen As List(Of PersonasBrl) = PersonasBrl.CargarPorId_Declaracion(Request.QueryString.Item("Id_Declaracion"))
                Session("ListRegimenSalud") = objpersonasregimen
                Rg_Regimen.DataSource = Session("ListRegimenSalud")
                Rg_Regimen.DataBind()

                ddl_regimen.Enabled = False
                rev_regimen.Enabled = False
                txt_municipio_regimen.Enabled = False
                rfv_municipio_regimen.Enabled = False
                ddl_Necesita_Traslado.Enabled = False
                rev_Necesita_Traslado.Enabled = False
                ddl_eps.Enabled = False
                rev_eps.Enabled = False
                btn_GrabarRegimen.Enabled = False

            Catch ex As Exception
                lblerror1.Visible = True
            End Try
        End If
    End Sub

    Protected Sub Rg_Regimen_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rg_Regimen.SelectedIndexChanged
        Dim item As Telerik.Web.UI.GridDataItem = Me.Rg_Regimen.SelectedItems.Item(Rg_Regimen.SelectedIndexes.Item(0))

        Dim objpersona As PersonasBrl = PersonasBrl.CargarPorID(item("Id").Text)
        lblidrs.Text = ""
        lblidpersonars.Text = ""
        If objpersona IsNot Nothing Then
            Dim ListRegimen As List(Of Personas_Regimen_SaludBrl) = Personas_Regimen_SaludBrl.CargarPorId_Declaracion_Seguimiento(Request.QueryString.Item("Id"))
            FilterHelper.FilterHelper(ListRegimen, "Id_Persona", objpersona.ID)
            If ListRegimen.Count > 0 Then
                ddl_regimen.SelectedValue = ListRegimen.Item(0).Id_Regimen_Salud
                lblidrs.Text = ListRegimen.Item(0).ID
                txt_municipio_regimen.Text = ListRegimen.Item(0).Municipio
                ddl_eps.SelectedValue = ListRegimen.Item(0).Id_Eps
                ddl_Necesita_Traslado.SelectedValue = ListRegimen.Item(0).Id_Necesita_Traslado

            End If
            '
            lbl_NC2.Text = objpersona.NombreCompleto
            lblidpersonars.Text = objpersona.ID

            ddl_regimen.Enabled = True
            rev_regimen.Enabled = True
            txt_municipio_regimen.Enabled = True
            rfv_municipio_regimen.Enabled = True
            ddl_Necesita_Traslado.Enabled = True
            rev_Necesita_Traslado.Enabled = True
            ddl_eps.Enabled = True
            rev_eps.Enabled = True
            btn_GrabarRegimen.Enabled = True

        End If

    End Sub

    Protected Sub ddl_emociones_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_emociones.SelectedIndexChanged
        If ddl_emociones.SelectedValue = 19 Then
            Lst_PersonasAyuda.Enabled = True
            Lst_PersonasAyuda_Declarante.Enabled = True
            Lst_ApoyoPersonas.Enabled = True
            Lst_ApoyoPersonas_Declarante.Enabled = True
        Else
            Lst_PersonasAyuda.Enabled = False
            Lst_PersonasAyuda_Declarante.Enabled = False
            Lst_ApoyoPersonas.Enabled = False
            Lst_ApoyoPersonas_Declarante.Enabled = False
            Lst_PersonasAyuda_Declarante.Items.Clear()
            Lst_ApoyoPersonas_Declarante.Items.Clear()

        End If
    End Sub

    Protected Sub ddl_unidos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_unidos.SelectedIndexChanged
        If ddl_unidos.SelectedValue = 19 Then
            txt_municipio_unidos.Enabled = True
            rfv_Municipio_Unidos.Enabled = True
        Else
            txt_municipio_unidos.Enabled = False
            rfv_Municipio_Unidos.Enabled = False
            txt_municipio_unidos.Text = ""
        End If
    End Sub

    Protected Sub Lst_PersonasAyuda_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lst_PersonasAyuda.SelectedIndexChanged
        Lst_PersonasAyuda_Declarante.Items.Add(New ListItem(Lst_PersonasAyuda.SelectedItem.Text, Lst_PersonasAyuda.SelectedItem.Value))
        Lst_PersonasAyuda.Items.RemoveAt(Lst_PersonasAyuda.SelectedIndex)
    End Sub

    Protected Sub Lst_PersonasAyuda_Declarante_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lst_PersonasAyuda_Declarante.SelectedIndexChanged
        Lst_PersonasAyuda.Items.Add(New ListItem(Lst_PersonasAyuda_Declarante.SelectedItem.Text, Lst_PersonasAyuda_Declarante.SelectedItem.Value))
        Lst_PersonasAyuda_Declarante.Items.RemoveAt(Lst_PersonasAyuda_Declarante.SelectedIndex)
    End Sub

    Protected Sub Lst_ApoyoPersonas_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lst_ApoyoPersonas.SelectedIndexChanged
        Lst_ApoyoPersonas_Declarante.Items.Add(New ListItem(Lst_ApoyoPersonas.SelectedItem.Text, Lst_ApoyoPersonas.SelectedItem.Value))
        Lst_ApoyoPersonas.Items.RemoveAt(Lst_ApoyoPersonas.SelectedIndex)
    End Sub

    Protected Sub Lst_ApoyoPersonas_Declarante_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lst_ApoyoPersonas_Declarante.SelectedIndexChanged
        Lst_ApoyoPersonas.Items.Add(New ListItem(Lst_ApoyoPersonas_Declarante.SelectedItem.Text, Lst_ApoyoPersonas_Declarante.SelectedItem.Value))
        Lst_ApoyoPersonas_Declarante.Items.RemoveAt(Lst_ApoyoPersonas_Declarante.SelectedIndex)
    End Sub

    Protected Sub ddl_Certificado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_Certificado.SelectedIndexChanged
        ddl_Seguimiento.SelectedValue = 19
        If ddl_Certificado.SelectedValue = 19 Then
            ddl_Seguimiento.SelectedValue = 20
        End If

    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/Entregas_Adicionales.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        If Request.QueryString.Item("Id") > 0 Then
            Response.Redirect("../webforms/EncuestaEspecial.aspx?Editar=1&Id=" + Request.QueryString.Item("Id") & "&Id_Declaracion=" & Request.QueryString.Item("Id_Declaracion") & "&IdEAP=" & Request.QueryString.Item("IdEAP"))
        Else
            Response.Redirect("../webforms/EncuestaEspecial.aspx?Id_Declaracion=" & Request.QueryString.Item("Id_Declaracion") & "&IdEAP=" & Request.QueryString.Item("IdEAP"))
        End If

    End Sub

    Protected Sub Rg_Regimen_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Regimen.NeedDataSource
        Rg_Regimen.DataSource = Session("ListRegimenSalud")
    End Sub

    Protected Sub Rg_Listado_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Listado.NeedDataSource
        Rg_Listado.DataSource = Session("Beneficiarios")
    End Sub

    Protected Sub ddl_MotivoNoestudio_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ddl_MotivoNoestudio.SelectedIndexChanged
        If ddl_MotivoNoestudio.SelectedValue = 1693 Then
            ddl_Certificado.SelectedValue = 19
            ddl_Certificado.Enabled = False
            rev_certificado.Enabled = False
        Else
            ddl_Certificado.Enabled = False
            rev_certificado.Enabled = False
            ddl_Certificado.SelectedValue = 0
        End If
        ddl_Certificado_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Protected Sub Rg_Regimen_ItemDataBound(sender As Object, e As Telerik.Web.UI.GridItemEventArgs) Handles Rg_Regimen.ItemDataBound

        If e.Item.ItemType = Telerik.Web.UI.GridItemType.AlternatingItem Or e.Item.ItemType = Telerik.Web.UI.GridItemType.Item Then

            Dim objregimen As List(Of Personas_Regimen_SaludBrl) = Personas_Regimen_SaludBrl.CargarPorId_Declaracion_Seguimiento(Request.QueryString.Item("Id"))
            FilterHelper.FilterHelper(objregimen, "Id_Persona", e.Item.Cells(3).Text)
            If objregimen.Count > 0 Then
                e.Item.Cells(7).Text = objregimen.Item(0).Regimen_Salud.Descripcion   ' regimen de salud
                e.Item.Cells(8).Text = objregimen.Item(0).Municipio    ' Municipio
                e.Item.Cells(9).Text = objregimen.Item(0).Eps.Descripcion   ' EPS
                e.Item.Cells(10).Text = objregimen.Item(0).Necesita_Traslado.Descripcion   ' Traslado

            End If


        End If

    End Sub

    Protected Sub Rg_Listado_ItemDataBound(sender As Object, e As Telerik.Web.UI.GridItemEventArgs) Handles Rg_Listado.ItemDataBound
        If e.Item.ItemType = Telerik.Web.UI.GridItemType.AlternatingItem Or e.Item.ItemType = Telerik.Web.UI.GridItemType.Item Then
            Dim objeducacion As List(Of Personas_EducacionBrl) = Personas_EducacionBrl.CargarPorId_Declaracion_Seguimiento(Request.QueryString.Item("Id"))
            FilterHelper.FilterHelper(objeducacion, "Id_Persona", e.Item.Cells(3).Text)
            If objeducacion.Count > 0 Then
                e.Item.Cells(10).Text = objeducacion.Item(0).Estudia_Actualmente      ' Estudia actualmente
                e.Item.Cells(11).Text = objeducacion.Item(0).Grado_Escolar      ' Grado
                e.Item.Cells(12).Text = objeducacion.Item(0).Certificado   ' Certificado
                e.Item.Cells(13).Text = objeducacion.Item(0).MotivoNoEstudia   ' Motivo No estudia
                e.Item.Cells(14).Text = objeducacion.Item(0).Seguimiento     ' Seguimiento
            End If

        End If
    End Sub
End Class
