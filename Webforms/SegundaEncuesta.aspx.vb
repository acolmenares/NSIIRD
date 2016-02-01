Imports ingNovar.Utilidades2
Imports System.Collections.Generic

Partial Class WebForms_SegundaEncuesta
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

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Departamento_Instituto, 46, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_departamento_rs, 46, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_familiasAccion, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_sirvio, 4, New ListItem("Seleccione", 0))

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(Lst_PersonasAyuda, 88)
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(Lst_ApoyoPersonas, 89)


        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Estudia_Actualmente, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Certificado, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Seguimiento, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_MotivoNoestudio, 5, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_GradoEscolar, 18, New ListItem("Seleccione", 0))

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_regimen, 7, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_eps, 30, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_atencion_psicosocial, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Necesita_Traslado, 4, New ListItem("Seleccione", 0))


        Dim ListEmociones As List(Of SubTablasBrl)
        ListEmociones = SubTablasBrl.CargarPorId_Tabla(87)
        Dg_Emociones.DataSource = ListEmociones
        Dg_Emociones.DataBind()

        ''
        ''  inicio de cargue de listas del paari
        ''
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_cereales, 97, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_raices, 97, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_verduras, 97, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_frutas, 97, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_carnes, 97, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_huevos, 97, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_leguminosas, 97, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_lacteos, 97, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_grasas, 97, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Azucares, 97, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_harinas, 97, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Enbutidos, 97, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_enlatados, 97, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_agua, 97, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_bienestarina, 97, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_gaseosas, 97, New ListItem("Seleccione", 0))

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_tipo_vivienda, 74, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_tipo_vivienda_otro, 92, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_material_pisos, 93, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_material_paredes, 94, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_zona_riesgo, 95, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_personas_cuarto, 43, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_alcantarillado, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_obtiene_agua, 23, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_acueducto, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_servicio_sanitario, 96, New ListItem("Seleccione", 0))

        ''
        ''  Fin de cargue da listas del paari
        ''



        '
        ' cargando Informacion
        '

        If Request.QueryString.Item("Editar") = 1 Then
            Dim objDeclaracion As DeclaracionBrl = DeclaracionBrl.CargarPorID(Request.QueryString.Item("ID"))

            If objDeclaracion Is Nothing Then
                lblMensaje.Text = "Registro no existe"
                lblMensaje.Visible = True
                Exit Sub
            End If

            Dim objseguimiento As Declaracion_SeguimientosBrl
            Dim ListSeguimientos As List(Of Declaracion_SeguimientosBrl) = objDeclaracion.Declaracion_Seguimientos
            FilterHelper.FilterHelper(ListSeguimientos, "Id_Tipo_Entrega", 918)
            If ListSeguimientos.Count > 0 Then
                objseguimiento = ListSeguimientos.Item(0)
            Else
                objseguimiento = New Declaracion_SeguimientosBrl
            End If

            If ddl_haoidoasociaciones.Items.FindByValue(objseguimiento.Id_Oido_OVD) IsNot Nothing Then ddl_haoidoasociaciones.SelectedValue = objseguimiento.Id_Oido_OVD
            If ddl_pertenece_asociacion.Items.FindByValue(objseguimiento.Id_Pertenece_OVD) IsNot Nothing Then ddl_pertenece_asociacion.SelectedValue = objseguimiento.Id_Pertenece_OVD
            txt_Asociacion.Text = objseguimiento.Cual_OVD
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

            If Me.ddl_familiasAccion.Items.FindByValue(objseguimiento.Id_Familias_Accion) IsNot Nothing Then ddl_familiasAccion.SelectedValue = objseguimiento.Id_Familias_Accion
            txt_municipio_faccion.Text = objseguimiento.Municipio_Familias_Accion
            ddl_familiasAccion_SelectedIndexChanged(Nothing, Nothing)
            If Me.ddl_atencion_psicosocial.Items.FindByValue(objseguimiento.Id_Solicitado_Atencion_Psicosocial) IsNot Nothing Then ddl_atencion_psicosocial.SelectedValue = objseguimiento.Id_Solicitado_Atencion_Psicosocial

            ' Cargando las listas

            Dim ListPersonasAyuda As List(Of Declaracion_Personas_AyudaBrl)
            ListPersonasAyuda = objDeclaracion.Declaracion_Personas_Ayuda
            FilterHelper.FilterHelper(ListPersonasAyuda, "Id_Tipo_Entrega", 918)
            For Each fila As Declaracion_Personas_AyudaBrl In ListPersonasAyuda
                Lst_PersonasAyuda_Declarante.Items.Add(New ListItem(fila.Personas_Ayuda.Descripcion, fila.Id_Personas_Ayuda))
            Next

            Dim ListApoyoPersonas As List(Of Declaracion_Apoyo_AyudaBrl)
            ListApoyoPersonas = objDeclaracion.Declaracion_Apoyo_Ayuda
            FilterHelper.FilterHelper(ListApoyoPersonas, "Id_Tipo_Entrega", 918)
            For Each fila As Declaracion_Apoyo_AyudaBrl In ListApoyoPersonas
                Lst_ApoyoPersonas_Declarante.Items.Add(New ListItem(fila.Apoyo_Ayuda.Descripcion, fila.Id_Apoyo_Ayuda))
            Next


            ' cargando la inrformacion adicional
            lbl_Nombre_Completo.Text = objDeclaracion.Personas_Declarante.NombreCompleto
            lbl_Grupo.Text = objDeclaracion.DescripcionGrupo
            txt_Observaciones.Text = objseguimiento.Observaciones

            Session("Beneficiarios") = objDeclaracion.PersonasEducacionPendiente
            Rg_Listado.DataSource = Session("Beneficiarios")
            Rg_Listado.DataBind()

            Session("ListRegimenSalud") = objDeclaracion.Personas
            Rg_Regimen.DataSource = Session("ListRegimenSalud")
            Rg_Regimen.DataBind()

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
                    Dim Listemocion As List(Of Declaracion_PsicosocialBrl) = Declaracion_PsicosocialBrl.CargarPorId_Declaracion(objDeclaracion.ID)
                    FilterHelper.FilterHelper(Listemocion, "Id_Emocion", lblidemo.Text)
                    FilterHelper.FilterHelper(Listemocion, "Id_Tipo_Entrega", 918)  ' Segunda Entrega
                    If Listemocion.Count > 0 Then
                        ddl_emociones_usted.SelectedValue = Listemocion.Item(0).Dato_Usted
                        ddl_emociones_familia.SelectedValue = Listemocion.Item(0).Dato_Familia
                    End If
                End If
            Next

            Dim objpaari As List(Of Declaracion_PAARIBrl) = objDeclaracion.Declaracion_PAARI
            FilterHelper.FilterHelper(objpaari, "Id_Tipo_Entrega", 918)
            If objpaari.Count >= 1 Then
                ' Hay un registro de paari en esta entrega
                ddl_cereales.SelectedValue = objpaari.Item(0).Id_Alimentacion_Consumo
                ddl_raices.SelectedValue = objpaari.Item(0).Id_Alimentacion_Raices
                ddl_verduras.SelectedValue = objpaari.Item(0).Id_Alimentacion_Verduras
                ddl_frutas.SelectedValue = objpaari.Item(0).Id_Alimentacion_Frutas
                ddl_carnes.SelectedValue = objpaari.Item(0).Id_Alimentacion_Carnes
                ddl_huevos.SelectedValue = objpaari.Item(0).Id_Alimentacion_Huevos
                ddl_leguminosas.SelectedValue = objpaari.Item(0).Id_Alimentacion_Leguminosas
                ddl_lacteos.SelectedValue = objpaari.Item(0).Id_Alimentacion_Lacteos
                ddl_grasas.SelectedValue = objpaari.Item(0).Id_Alimentacion_Grasas
                ddl_Azucares.SelectedValue = objpaari.Item(0).Id_Alimentacion_Azucares
                ddl_harinas.SelectedValue = objpaari.Item(0).Id_Alimentacion_Harinas
                ddl_Enbutidos.SelectedValue = objpaari.Item(0).Id_Alimentacion_Enbutidos
                ddl_enlatados.SelectedValue = objpaari.Item(0).Id_Alimentacion_Enlatados
                ddl_gaseosas.SelectedValue = objpaari.Item(0).Id_Alimentacion_Gaseosas
                ddl_agua.SelectedValue = objpaari.Item(0).Id_Alimentacion_Agua
                ddl_bienestarina.SelectedValue = objpaari.Item(0).Id_Alimentacion_Bienestarina

                '

                ddl_tipo_vivienda.SelectedValue = objpaari.Item(0).Id_Alojamiento_Tipo_Vivienda
                ddl_tipo_vivienda_otro.SelectedValue = objpaari.Item(0).Id_Alojamiento_Tipo_Vivienda_Otro
                ddl_material_pisos.SelectedValue = objpaari.Item(0).Id_Alojamiento_Material_Pisos
                ddl_material_paredes.SelectedValue = objpaari.Item(0).Id_Alojamiento_Material_Paredes
                ddl_zona_riesgo.SelectedValue = objpaari.Item(0).Id_Alojamiento_Zona_Riesgo
                ddl_personas_cuarto.SelectedValue = objpaari.Item(0).Id_Alojamiento_Cuantos_Duermen
                ddl_tipo_vivienda_SelectedIndexChanged(Nothing, Nothing)

                ddl_acueducto.SelectedValue = objpaari.Item(0).Id_Alojamiento_Acueducto
                ddl_obtiene_agua.SelectedValue = objpaari.Item(0).Id_Alojamiento_Obtiene_Agua
                ddl_acueducto_SelectedIndexChanged(Nothing, Nothing)

                ddl_alcantarillado.SelectedValue = objpaari.Item(0).Id_Alojamiento_Alcantarillado
                ddl_servicio_sanitario.SelectedValue = objpaari.Item(0).Id_Alojamiento_Servicio_Sanitario
                ddl_alcantarillado_SelectedIndexChanged(Nothing, Nothing)

                btn_paari_Click(Nothing, Nothing)
            End If

        End If

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Validate("SE")
        If Not IsValid Then Exit Sub

        Dim ID As Int32

        Try
            ID = Grabar()
            Response.Redirect("SegundaEncuesta.aspx?Editar=1&Mensaje=1&ID=" & ID)
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Private Function Grabar() As Int32
        Dim ListDeclaracion As List(Of Declaracion_SeguimientosBrl)
        Dim objDeclaracion As Declaracion_SeguimientosBrl

        If Request.QueryString.Item("Editar") = 1 Then
            ListDeclaracion = Declaracion_SeguimientosBrl.CargarPorId_Declaracion(Request.QueryString.Item("ID"))
            FilterHelper.FilterHelper(ListDeclaracion, "Id_Tipo_Entrega ", 918)
            If ListDeclaracion.Count = 0 Then
                objDeclaracion = New Declaracion_SeguimientosBrl
            Else
                objDeclaracion = ListDeclaracion.Item(0)
            End If
        Else
            objDeclaracion = New Declaracion_SeguimientosBrl
        End If

        If objDeclaracion Is Nothing Then
            lblMensaje.Text = "Se presento problemas al grabar la segunda encuesta. Verifique enlace de donde carga la información."
            Return 0
            Exit Function
        End If

        Dim objdec As DeclaracionBrl = DeclaracionBrl.CargarPorID(Request.QueryString.Item("ID"))

        If objDeclaracion.Fecha = Nothing Then
            For Each fila As Declaracion_EstadosBrl In objdec.Declaracion_Estados
                If fila.Id_Programa <> 0 Then
                    If fila.Programa.Id_TipoEntrega = 918 Then  '' Segunda entrega
                        If fila.Id_Programa <> 0 Then
                            objDeclaracion.Fecha = fila.Programa.Fecha
                        End If
                    End If
                End If
            Next
        End If

        objDeclaracion.Id_Declaracion = Request.QueryString.Item("Id")
        objDeclaracion.Id_Tipo_Entrega = 918 ' Segunda entrega
        objDeclaracion.Id_Oido_OVD = ddl_haoidoasociaciones.SelectedValue
        objDeclaracion.Id_Pertenece_OVD = ddl_pertenece_asociacion.SelectedValue
        objDeclaracion.Cual_OVD = txt_Asociacion.Text
        objDeclaracion.Id_Emociones = ddl_emociones.SelectedValue
        objDeclaracion.Id_Aliviado = ddl_aliviado.SelectedValue
        objDeclaracion.Id_Comprender_Miedos = ddl_comprender_miedos.SelectedValue
        objDeclaracion.Id_Escuchado_Grupo = ddl_escuchado.SelectedValue
        objDeclaracion.Id_Ayuda_Barrio = ddl_ayuda_personas.SelectedValue
        objDeclaracion.Id_Identificar_Habilidades = Me.ddl_habilidades_salir.SelectedValue
        objDeclaracion.Id_Ayuda_Bienestar = Me.ddl_bienestar_emocional.SelectedValue
        objDeclaracion.Id_Relaciones_Familia = Me.ddl_relaciones_familia.SelectedValue
        objDeclaracion.Id_Momentos_Dificiles = Me.ddl_momentos.SelectedValue
        objDeclaracion.Id_Identificar_Organizaciones = Me.ddl_identificar_organizaciones.SelectedValue
        objDeclaracion.Id_Identificar_Instituciones = Me.ddl_identificar_instituciones.SelectedValue
        objDeclaracion.Id_No_Sirvio = Me.ddl_sirvio.SelectedValue
        objDeclaracion.Id_Apoyo_Emocional = Me.ddl_apoyo_emocional.SelectedValue
        objDeclaracion.Municipio_Familias_Accion = txt_municipio_faccion.Text
        objDeclaracion.Id_Familias_Accion = Me.ddl_familiasAccion.SelectedValue
        objDeclaracion.Id_Solicitado_Atencion_Psicosocial = Me.ddl_atencion_psicosocial.SelectedValue
        objDeclaracion.Observaciones = txt_Observaciones.Text

        objDeclaracion.Guardar()

        ' Grabar la  informacion de las listas 
        ' Generalmente es actualizar.
        ' Primero se elimina lo existente

        Dim listPersonasAyudaDec As List(Of Declaracion_Personas_AyudaBrl)
        listPersonasAyudaDec = Declaracion_Personas_AyudaBrl.CargarPorId_Declaracion(objDeclaracion.Id_Declaracion)
        For Each fila As Declaracion_Personas_AyudaBrl In listPersonasAyudaDec
            If fila.Id_Tipo_Entrega = 918 Then fila.Eliminar()
        Next

        Dim listApoyoAyudaDec As List(Of Declaracion_Apoyo_AyudaBrl)
        listApoyoAyudaDec = Declaracion_Apoyo_AyudaBrl.CargarPorId_Declaracion(objDeclaracion.Id_Declaracion)
        For Each fila As Declaracion_Apoyo_AyudaBrl In listApoyoAyudaDec
            If fila.Id_Tipo_Entrega = 918 Then fila.Eliminar()
        Next

        Dim ListFuentesIngresoDec As List(Of Declaracion_Fuentes_IngresoBrl)
        ListFuentesIngresoDec = Declaracion_Fuentes_IngresoBrl.CargarPorId_Declaracion(objDeclaracion.Id_Declaracion)
        For Each fila As Declaracion_Fuentes_IngresoBrl In ListFuentesIngresoDec
            If fila.Id_Tipo_Entrega = 918 Then fila.Eliminar()
        Next

        ' grabando los nuevos registros

        Dim objpersonasayudadec As Declaracion_Personas_AyudaBrl
        For Each detalle As ListItem In Me.Lst_PersonasAyuda_Declarante.Items
            objpersonasayudadec = New Declaracion_Personas_AyudaBrl
            objpersonasayudadec.Id_Declaracion = objDeclaracion.Id_Declaracion
            objpersonasayudadec.Id_Personas_Ayuda = detalle.Value
            objpersonasayudadec.Id_Tipo_Entrega = 918 ' Segunda Entrega
            objpersonasayudadec.Guardar()
        Next

        Dim objapoyoayudadec As Declaracion_Apoyo_AyudaBrl
        For Each detalle As ListItem In Me.Lst_ApoyoPersonas_Declarante.Items
            objapoyoayudadec = New Declaracion_Apoyo_AyudaBrl
            objapoyoayudadec.Id_Declaracion = objDeclaracion.Id_Declaracion
            objapoyoayudadec.Id_Apoyo_Ayuda = detalle.Value
            objapoyoayudadec.Id_Tipo_Entrega = 918 ' Segunda Entrega
            objapoyoayudadec.Guardar()
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
                Dim Listemociones As List(Of Declaracion_PsicosocialBrl) = Declaracion_PsicosocialBrl.CargarPorId_Declaracion(objDeclaracion.Id_Declaracion)
                FilterHelper.FilterHelper(Listemociones, "Id_Emocion", lblidemo.Text)
                FilterHelper.FilterHelper(Listemociones, "Id_Tipo_Entrega", 918) ' Filtro Segunda Entrega
                If Listemociones.Count = 0 Then ' Nuevo
                    objemocion = New Declaracion_PsicosocialBrl
                    objemocion.Id_Declaracion = objDeclaracion.Id_Declaracion
                Else
                    objemocion = Listemociones.Item(0)
                End If

                objemocion.Id_Emocion = lblidemo.Text
                objemocion.Id_Tipo_Entrega = 918   ' Segunda Entrega
                objemocion.Dato_Usted = ddl_emociones_usted.SelectedValue
                objemocion.Dato_Familia = ddl_emociones_familia.SelectedValue
                objemocion.Guardar()
            End If
        Next

        '
        '  Informacion de PAARI
        '


        Dim ListPaari As List(Of Declaracion_PAARIBrl) = Declaracion_PAARIBrl.CargarPorId_Declaracion(Request.QueryString.Item("Id"))
        FilterHelper.FilterHelper(ListPaari, "Id_Tipo_Entrega", 918)
        Dim objpaari As Declaracion_PAARIBrl
        If ListPaari.Count >= 1 Then
            ' existe registro
            objpaari = ListPaari.Item(0)
            objpaari.Fecha_Modificacion = Now
            objpaari.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text
        Else
            objpaari = New Declaracion_PAARIBrl
            objpaari.Fecha_Creacion = Now
            objpaari.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
            objpaari.Id_Declaracion = Request.QueryString.Item("Id")
            objpaari.Id_Tipo_Entrega = 918
        End If

        btn_paari_Click(Nothing, Nothing)

        objpaari.Id_Alimentacion_Consumo = ddl_cereales.SelectedValue
        objpaari.Id_Alimentacion_Raices = ddl_raices.SelectedValue
        objpaari.Id_Alimentacion_Verduras = ddl_verduras.SelectedValue
        objpaari.Id_Alimentacion_Frutas = ddl_frutas.SelectedValue
        objpaari.Id_Alimentacion_Carnes = ddl_carnes.SelectedValue
        objpaari.Id_Alimentacion_Huevos = ddl_huevos.SelectedValue
        objpaari.Id_Alimentacion_Leguminosas = ddl_leguminosas.SelectedValue
        objpaari.Id_Alimentacion_Lacteos = ddl_lacteos.SelectedValue
        objpaari.Id_Alimentacion_Grasas = ddl_grasas.SelectedValue
        objpaari.Id_Alimentacion_Azucares = ddl_Azucares.SelectedValue
        objpaari.Id_Alimentacion_Harinas = ddl_harinas.SelectedValue
        objpaari.Id_Alimentacion_Enbutidos = ddl_Enbutidos.SelectedValue
        objpaari.Id_Alimentacion_Enlatados = ddl_enlatados.SelectedValue
        objpaari.Id_Alimentacion_Gaseosas = ddl_gaseosas.SelectedValue
        objpaari.Id_Alimentacion_Agua = ddl_agua.SelectedValue
        objpaari.Id_Alimentacion_Bienestarina = ddl_bienestarina.SelectedValue

        objpaari.Id_Alojamiento_Tipo_Vivienda = ddl_tipo_vivienda.SelectedValue
        objpaari.Id_Alojamiento_Tipo_Vivienda_Otro = ddl_tipo_vivienda_otro.SelectedValue
        objpaari.Id_Alojamiento_Material_Pisos = ddl_material_pisos.SelectedValue
        objpaari.Id_Alojamiento_Material_Paredes = ddl_material_paredes.SelectedValue
        objpaari.Id_Alojamiento_Zona_Riesgo = ddl_zona_riesgo.SelectedValue
        objpaari.Id_Alojamiento_Cuantos_Duermen = ddl_personas_cuarto.SelectedValue
        objpaari.Id_Alojamiento_Acueducto = ddl_acueducto.SelectedValue
        objpaari.Id_Alojamiento_Obtiene_Agua = ddl_obtiene_agua.SelectedValue
        objpaari.Id_Alojamiento_Alcantarillado = ddl_alcantarillado.SelectedValue
        objpaari.Id_Alojamiento_Servicio_Sanitario = ddl_servicio_sanitario.SelectedValue
        objpaari.Valor_Alimentacion = lbl_dato_alimentacion.Text
        objpaari.Valor_Alojamiento = lbl_dato_alojamiento.Text
        objpaari.Guardar()

        Return objDeclaracion.Id_Declaracion

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
            If objpersona.Personas_EducacionSegunda_Entrega IsNot Nothing Then
                lblId.Text = objpersona.Personas_EducacionSegunda_Entrega.ID
                ddl_Estudia_Actualmente.SelectedValue = objpersona.Personas_EducacionSegunda_Entrega.Id_Estudia_Actualmente
                ddl_Estudia_Actualmente_SelectedIndexChanged(Nothing, Nothing)


                Txt_Establecimiento.Text = objpersona.Personas_EducacionSegunda_Entrega.Establecimiento
                ddl_MotivoNoestudio.SelectedValue = objpersona.Personas_EducacionSegunda_Entrega.Id_Motivo_NoEstudia
                ddl_MotivoNoestudio_SelectedIndexChanged(Nothing, Nothing)

                If ddl_Certificado.Items.FindByValue(objpersona.Personas_EducacionSegunda_Entrega.Id_Certificado_Matricula) IsNot Nothing Then ddl_Certificado.SelectedValue = objpersona.Personas_EducacionSegunda_Entrega.Id_Certificado_Matricula
                ddl_GradoEscolar.SelectedValue = objpersona.Personas_EducacionSegunda_Entrega.Id_grado_escolar
                ddl_Seguimiento.SelectedValue = objpersona.Personas_EducacionSegunda_Entrega.Id_Seguimiento
                Try
                    ddl_Departamento_Instituto.SelectedValue = objpersona.Personas_EducacionSegunda_Entrega.Municipio_Institucion.Id_Padre
                    ddl_Departamento_Instituto_SelectedIndexChanged(Nothing, Nothing)
                    ddl_Municipio_Instituto.SelectedValue = objpersona.Personas_EducacionSegunda_Entrega.Id_Municipio_Instituto
                Catch ex As Exception

                End Try
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
        ddl_Certificado.Enabled = False
        rev_certificado.Enabled = False
        Txt_Establecimiento.Text = ""
        Txt_Establecimiento.Enabled = False
        rfv_establecimiento.Enabled = False
        ddl_GradoEscolar.Enabled = False
        rev_gradoescolar.Enabled = False
        ddl_Departamento_Instituto.Enabled = False
        ddl_Municipio_Instituto.Enabled = False
        rev_municipio_instituto.Enabled = False

        If ddl_Estudia_Actualmente.SelectedValue = 20 Then
            ddl_MotivoNoestudio.Enabled = True
            rev_MotivoNoestudia.Enabled = True
            ddl_Certificado.SelectedValue = 0
            ddl_Departamento_Instituto.SelectedValue = 0
            ddl_Departamento_Instituto_SelectedIndexChanged(Nothing, Nothing)
            ddl_GradoEscolar.SelectedValue = 0
        End If

        If ddl_Estudia_Actualmente.SelectedValue = 19 Then
            Txt_Establecimiento.Enabled = True
            rfv_establecimiento.Enabled = True
            ddl_GradoEscolar.Enabled = True
            rev_gradoescolar.Enabled = True
            ddl_Certificado.Enabled = True
            rev_certificado.Enabled = True
            ddl_Departamento_Instituto.Enabled = True
            ddl_Municipio_Instituto.Enabled = True
            rev_municipio_instituto.Enabled = True
        End If

    End Sub

    Protected Sub btn_GrabarBeneficiario_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_GrabarBeneficiario.Click
        If LblIdPersona.Text <> "" Then

            Validate("BE")
            lblerror.Visible = False
            If Not IsValid Then
                lblerror.Visible = True
                Exit Sub
            End If

            Dim objeducacion As Personas_EducacionBrl
            ' Grabar el beneficiario
            If lblId.Text.Trim = "" Then
                objeducacion = New Personas_EducacionBrl
                objeducacion.Id_Persona = LblIdPersona.Text
                objeducacion.Id_Tipo_Entrega = 918 ' indica que es de segunda entrega
            Else
                objeducacion = Personas_EducacionBrl.CargarPorID(lblId.Text)
            End If

            objeducacion.Id_Certificado_Matricula = ddl_Certificado.SelectedValue
            objeducacion.Id_Estudia_Actualmente = ddl_Estudia_Actualmente.SelectedValue
            objeducacion.Id_grado_escolar = ddl_GradoEscolar.SelectedValue
            objeducacion.Id_Motivo_NoEstudia = ddl_MotivoNoestudio.SelectedValue
            objeducacion.Id_Seguimiento = ddl_Seguimiento.SelectedValue
            objeducacion.Establecimiento = Txt_Establecimiento.Text
            objeducacion.Id_Municipio_Instituto = ddl_Municipio_Instituto.SelectedValue


            Dim objdeclaracion As DeclaracionBrl = DeclaracionBrl.CargarPorID(Request.QueryString.Item("Id"))

            If objeducacion.Fecha = Nothing Then
                For Each fila As Declaracion_EstadosBrl In objdeclaracion.Declaracion_Estados
                    If fila.Programa IsNot Nothing Then
                        If fila.Programa.Id_TipoEntrega = 918 Then  '' Segunda entrega
                            If fila.Id_Programa <> 0 Then
                                objeducacion.Fecha = fila.Programa.Fecha
                            End If
                        End If
                    End If
                Next
            End If

            lblerror.Visible = False
            Try

                objeducacion.Guardar()


                Dim objpersonas As List(Of PersonasBrl) = objDeclaracion.PersonasEducacionPendiente
                lblId.Text = ""
                LblIdPersona.Text = ""
                lbl_NC.Text = ""
                ddl_Estudia_Actualmente.SelectedValue = 0
                ddl_Estudia_Actualmente_SelectedIndexChanged(Nothing, Nothing)
                ddl_Departamento_Instituto.SelectedValue = 0
                ddl_Departamento_Instituto_SelectedIndexChanged(Nothing, Nothing)
                ddl_Certificado.SelectedValue = 0
                ddl_GradoEscolar.SelectedValue = 0
                Session("Beneficiarios") = objpersonas
                Rg_Listado.DataSource = Session("Beneficiarios")
                Rg_Listado.DataBind()
            Catch ex As Exception
                lblerror.Visible = True
            End Try
        End If

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
            ' Grabar el beneficiario
            If lblidrs.Text.Trim = "" Then
                objregimen = New Personas_Regimen_SaludBrl
                objregimen.Id_Persona = lblidpersonars.Text

                Dim objdeclaracion As DeclaracionBrl = DeclaracionBrl.CargarPorID(Request.QueryString.Item("Id"))

                If objregimen.Fecha = Nothing Then
                    For Each fila As Declaracion_EstadosBrl In objdeclaracion.Declaracion_Estados
                        If fila.Programa IsNot Nothing Then
                            If fila.Programa.Id_TipoEntrega = 918 Then  '' Segunda entrega
                                If fila.Id_Programa <> 0 Then
                                    objregimen.Fecha = fila.Programa.Fecha
                                End If
                            End If
                        End If
                    Next
                End If

            Else
                objregimen = Personas_Regimen_SaludBrl.CargarPorID(lblidrs.Text)
            End If

            objregimen.Id_Regimen_Salud = ddl_regimen.SelectedValue

            objregimen.Id_Eps = ddl_eps.SelectedValue
            objregimen.Id_Municipio = ddl_municipio_rs.SelectedValue
            objregimen.Id_Tipo_Entrega = 918
            objregimen.Id_Cerrar = 20
            objregimen.Id_Necesita_Traslado = ddl_Necesita_Traslado.SelectedValue
            lblerror1.Visible = False


            Try

                objregimen.Guardar()
                Dim objpersonasregimen As List(Of PersonasBrl) = PersonasBrl.CargarPorId_Declaracion(Request.QueryString.Item("Id"))
                lblidrs.Text = ""
                lblidpersonars.Text = ""
                lbl_NC2.Text = ""
                ddl_regimen.SelectedValue = 0
                ddl_eps.SelectedValue = 0
                ddl_departamento_rs.SelectedValue = 0
                ddl_departamento_rs_SelectedIndexChanged(Nothing, Nothing)
                ddl_Necesita_Traslado.SelectedValue = 0
                Session("ListRegimenSalud") = objpersonasregimen
                Rg_Regimen.DataSource = Session("ListRegimenSalud")
                Rg_Regimen.DataBind()

                ddl_regimen.Enabled = False
                rev_regimen.Enabled = False
                ddl_departamento_rs.Enabled = False
                ddl_municipio_rs.Enabled = False
                rev_regimen_municipio.Enabled = False
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
            If objpersona.Personas_RegimenSegunda_Entrega IsNot Nothing Then
                ddl_regimen.SelectedValue = objpersona.Personas_RegimenSegunda_Entrega.Id_Regimen_Salud
                lblidrs.Text = objpersona.Personas_RegimenSegunda_Entrega.ID

                ddl_departamento_rs.SelectedValue = objpersona.Personas_RegimenSegunda_Entrega.MunicipioRS.Id_Padre
                ddl_departamento_rs_SelectedIndexChanged(Nothing, Nothing)
                ddl_municipio_rs.SelectedValue = objpersona.Personas_RegimenSegunda_Entrega.Id_Municipio

                ddl_eps.SelectedValue = objpersona.Personas_RegimenSegunda_Entrega.Id_Eps
                ddl_Necesita_Traslado.SelectedValue = objpersona.Personas_RegimenSegunda_Entrega.Id_Necesita_Traslado
            End If
            '
            lbl_NC2.Text = objpersona.NombreCompleto
            lblidpersonars.Text = objpersona.ID

            ddl_regimen.Enabled = True
            rev_regimen.Enabled = True
            ddl_departamento_rs.Enabled = True
            ddl_municipio_rs.Enabled = True
            rev_regimen_municipio.Enabled = True
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
        Response.Redirect("../webforms/DeclaracionList.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        Response.Redirect("../webforms/SegundaEncuesta.aspx?Editar=1&Id=" + Request.QueryString.Item("Id"))
    End Sub

    Protected Sub Rg_Regimen_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Regimen.NeedDataSource
        Rg_Regimen.DataSource = Session("ListRegimenSalud")
    End Sub

    Protected Sub Rg_Listado_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Listado.NeedDataSource
        Rg_Listado.DataSource = Session("Beneficiarios")
    End Sub

    Protected Sub ddl_MotivoNoestudio_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ddl_MotivoNoestudio.SelectedIndexChanged
        If ddl_Estudia_Actualmente.SelectedValue = 20 Then
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
        End If
    End Sub

    Protected Sub ddl_Departamento_Instituto_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddl_Departamento_Instituto.SelectedIndexChanged
        BindHelper.SubTablasUIL.BindToListControlPorId_TablaPadre(ddl_Municipio_Instituto, 15, ddl_Departamento_Instituto.SelectedValue, New ListItem("Seleccione", 0))
    End Sub

    Protected Sub ddl_familiasAccion_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddl_familiasAccion.SelectedIndexChanged
        If ddl_familiasAccion.SelectedValue = 19 Then
            txt_municipio_faccion.Enabled = True
            rfv_Municipio_Faccion.Enabled = True
        Else
            txt_municipio_faccion.Enabled = False
            rfv_Municipio_Faccion.Enabled = False
            txt_municipio_faccion.Text = ""
        End If
    End Sub

    Protected Sub ddl_departamento_rs_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddl_departamento_rs.SelectedIndexChanged
        BindHelper.SubTablasUIL.BindToListControlPorId_TablaPadre(ddl_municipio_rs, 15, ddl_departamento_rs.SelectedValue, New ListItem("Seleccione", 0))
    End Sub

    Protected Sub btn_paari_Click(sender As Object, e As System.EventArgs) Handles btn_paari.Click
        '
        '  Proceso de Calificacion de Alimentacion
        '
        Dim wvalor As Double = 0
        Dim wmultiplo As Double = 0
        Dim objdeclaracion As DeclaracionBrl = DeclaracionBrl.CargarPorID(Request.QueryString.Item("Id"))
        '

        If ddl_cereales.SelectedValue >= ddl_harinas.SelectedValue Then
            wmultiplo = ddl_cereales.SelectedValue - 258
        Else
            wmultiplo = ddl_harinas.SelectedValue - 258
        End If


        wvalor = wvalor + (wmultiplo * 2)
        '
        If ddl_raices.SelectedValue > 0 Then
            wmultiplo = ddl_raices.SelectedValue - 258
        Else
            wmultiplo = 0
        End If
        wvalor = wvalor + (wmultiplo * 2)
        '
        wvalor = wvalor + ddl_verduras.SelectedValue - 258 + ddl_frutas.SelectedValue - 258
        '

        If ddl_carnes.SelectedValue >= ddl_Enbutidos.SelectedValue Then
            If ddl_carnes.SelectedValue >= ddl_enlatados.SelectedValue Then
                wmultiplo = ddl_carnes.SelectedValue - 258
            Else
                wmultiplo = ddl_enlatados.SelectedValue - 258
            End If
        Else
            If ddl_Enbutidos.SelectedValue >= ddl_enlatados.SelectedValue Then
                wmultiplo = ddl_Enbutidos.SelectedValue - 258
            Else
                wmultiplo = ddl_enlatados.SelectedValue - 258
            End If
        End If
        wvalor = wvalor + (wmultiplo * 4)

        wvalor = wvalor + ((ddl_huevos.SelectedValue - 258) * 4)
        wvalor = wvalor + ((ddl_leguminosas.SelectedValue - 258) * 3)
        wvalor = wvalor + ((ddl_lacteos.SelectedValue - 258) * 4)
        wvalor = wvalor + ((ddl_grasas.SelectedValue - 258) * 0.5)
        wvalor = wvalor + ((ddl_Azucares.SelectedValue - 258) * 0.5)
        wvalor = wvalor + ((ddl_bienestarina.SelectedValue - 258) * 3)

        Select Case wvalor
            Case 0 To 74
                lbl_Alimentacion.Text = "Carencia Grave : " + Format(wvalor, "#,###.##")
            Case 74.5 To 101.5
                lbl_Alimentacion.Text = "Carencia Leve : " + Format(wvalor, "#,###.##")
            Case Is >= 102
                lbl_Alimentacion.Text = "No Carencia : " + Format(wvalor, "#,###.##")
            Case Else
                lbl_Alimentacion.Text = "Falta datos para Proceso."
        End Select
        lbl_dato_alimentacion.Text = wvalor.ToString

        '
        ' Proceso de Calificacion de Alojamiento
        '
        wvalor = 0
        Select Case ddl_tipo_vivienda.SelectedValue
            Case 203 ' otro
                'Select Case objdeclaracion.Id_Ubicacion
                '    Case 281 'urbano
                wvalor = wvalor + 10
                'Case 282 ' rural
                '    Select Case objdeclaracion.Personas_Declarante.Id_Grupo_Etnico
                '        Case 35 'afro
                '            wvalor = wvalor + 10
                '        Case 36 ' indigena
                '            Select Case ddl_tipo_vivienda_otro.SelectedValue
                '                Case 224
                '                    wvalor = wvalor + 0
                '                Case Else
                '                    wvalor = wvalor + 10
                '            End Select
                '        Case 277 'Rroom
                '            Select Case ddl_tipo_vivienda_otro.SelectedValue
                '                Case 204, 222
                '                    wvalor = wvalor + 0
                '                Case Else
                '                    wvalor = wvalor + 10
                '            End Select
                '        Case 37
                '            wvalor = wvalor + 10
                '    End Select
                'End Select
        End Select

        If ddl_material_pisos.SelectedValue = 231 Then wvalor = wvalor + 2

        If ddl_material_paredes.SelectedValue = 236 Then
            'If objdeclaracion.Id_Ubicacion = 281 Then
            wvalor = wvalor + 1
            'End If
        End If

        If ddl_material_paredes.SelectedValue = 237 Then
            wvalor = wvalor + 1
        End If

        If ddl_material_paredes.SelectedValue = 238 Then
            wvalor = wvalor + 2
        End If

        If ddl_material_paredes.SelectedValue = 239 Then
            wvalor = wvalor + 2
        End If

        If ddl_personas_cuarto.SelectedValue = 680 Then
            'If objdeclaracion.Id_Ubicacion = 281 Then
            wvalor = wvalor + 1
            'End If
        End If

        If ddl_personas_cuarto.SelectedValue >= 681 Then
            If objdeclaracion.Personas_Declarante.Id_Grupo_Etnico = 37 Then
                wvalor = wvalor + 3
            End If
        End If

        Select Case ddl_zona_riesgo.SelectedValue
            Case 240, 241, 242, 243, 244
                wvalor = wvalor + 2
        End Select

        If ddl_acueducto.SelectedValue = 20 Then
            'If objdeclaracion.Id_Ubicacion = 281 Then
            wvalor += 2
            'End If
        End If

        If ddl_alcantarillado.SelectedValue = 20 Then
            ' If objdeclaracion.Id_Ubicacion = 281 Then
            wvalor += 1
            'End If
        End If

        'If ddl_alcantarillado.SelectedValue = 20 Then
        '    If objdeclaracion.Id_Ubicacion = 282 Then
        '        Select Case ddl_servicio_sanitario.SelectedValue
        '            Case 254, 255, 256, 257
        '                wvalor += 1
        '        End Select
        '    End If
        'End If

        'If ddl_acueducto.SelectedValue = 20 Then
        '    If objdeclaracion.Id_Ubicacion = 282 Then
        '        Select Case ddl_servicio_sanitario.SelectedValue
        '            Case 92, 249, 89, 250, 251
        '                wvalor += 1
        '            Case 820, 90
        '                wvalor += 2
        '        End Select
        '    End If
        'End If

        Select Case wvalor
            Case Is = 0
                Lbl_Alojamiento.Text = "No Carencia - " + Format(wvalor, "#,###.##")
            Case 1 To 3
                Lbl_Alojamiento.Text = "Carencia Leve - " + Format(wvalor, "#,###.##")
            Case Is > 3
                Lbl_Alojamiento.Text = "Carencia Grave - " + Format(wvalor, "#,###.##")
            Case Else
                Lbl_Alojamiento.Text = "Falta Datos para Proceso"
        End Select
        lbl_dato_alojamiento.Text = wvalor.ToString

    End Sub

    Protected Sub ddl_tipo_vivienda_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddl_tipo_vivienda.SelectedIndexChanged
        ddl_tipo_vivienda_otro.Enabled = False
        rev_tipo_vivienda_otro.Enabled = False
        ddl_material_pisos.Enabled = True
        rev_Material_pisos.Enabled = True
        ddl_material_paredes.Enabled = True
        rev_material_paredes.Enabled = True
        ddl_zona_riesgo.Enabled = True
        rev_zona_riesgo.Enabled = True
        ddl_personas_cuarto.Enabled = False
        rev_personas_cuarto.Enabled = False



        Select Case ddl_tipo_vivienda.SelectedValue

            Case Is = 203
                ddl_tipo_vivienda_otro.Enabled = True
                rev_tipo_vivienda_otro.Enabled = True
                ddl_material_pisos.Enabled = False
                rev_Material_pisos.Enabled = False
                ddl_material_paredes.Enabled = False
                rev_material_paredes.Enabled = False
                ddl_material_pisos.SelectedValue = 0
                ddl_material_paredes.SelectedValue = 0
                ddl_zona_riesgo.Enabled = False
                rev_zona_riesgo.Enabled = False
                ddl_zona_riesgo.SelectedValue = 0
                ddl_personas_cuarto.SelectedValue = 0

            Case 174, 185
                ddl_personas_cuarto.Enabled = True
                rev_personas_cuarto.Enabled = True
                ddl_tipo_vivienda_otro.SelectedValue = 0
            Case Else
                ddl_tipo_vivienda_otro.SelectedValue = 0
                ddl_personas_cuarto.SelectedValue = 0
        End Select


    End Sub

    Protected Sub ddl_acueducto_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddl_acueducto.SelectedIndexChanged
        ddl_obtiene_agua.Enabled = False
        rev_obtiene_agua.Enabled = False
        If ddl_acueducto.SelectedValue = 20 Then
            ddl_obtiene_agua.Enabled = True
            rev_obtiene_agua.Enabled = True
        End If
        If ddl_acueducto.SelectedValue = 19 Then
            ddl_obtiene_agua.SelectedValue = 0
        End If

    End Sub

    Protected Sub ddl_alcantarillado_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddl_alcantarillado.SelectedIndexChanged

        ddl_servicio_sanitario.Enabled = False
        rev_servicio_sanitario.Enabled = False
        If ddl_alcantarillado.SelectedValue = 20 Then
            ddl_servicio_sanitario.Enabled = True
            rev_servicio_sanitario.Enabled = True
        End If
        If ddl_alcantarillado.SelectedValue = 19 Then
            ddl_servicio_sanitario.SelectedValue = 0
        End If
    End Sub

End Class
