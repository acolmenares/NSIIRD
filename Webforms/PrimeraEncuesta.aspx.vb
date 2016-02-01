Imports ingNovar.Utilidades2
Imports System.Collections.Generic
Imports Telerik.Web.UI

Partial Class WebForms_PrimeraEncuesta
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

        lbl_actcontacto.Text = "0" ' Inicializando los contactos

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Fuente, 6, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Regimen_Salud_Antes, 7, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Eps_Antes, 30, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Regimen_Salud_Despues, 7, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Eps_Despues, 30, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Grupo_Etnico, 9, New ListItem("Seleccione", 0))

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Solicito_Atencion_Psicologica, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Llegada_vbg, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(Lst_ObtieneAgua, 23)
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Discapacitado, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Agua_Potable, 4, New ListItem("Seleccione", 0))

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Genero, 2, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(Ddl_Tipo_Miembro, 86, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Parentesco, 3, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Tipo_Identificacion, 1, New ListItem("Seleccione", 0))

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Genero, 2, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Tipo_Discapacidad, 36, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Embarazada, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_lactando, 4, New ListItem("Seleccione", 0))

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Sabe_Leer, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_EstudiabaAntes, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_EstudiaActualmente, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_UltimoGrado, 18, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_MotivoNoEstudio, 5, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_certificacion, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(Ddl_Tipo_Apoyo_Escolar, 38, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_departamento_antes, 46, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_departamento_actual, 46, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_departamento_rsa, 46, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_departamento_rsd, 46, New ListItem("Seleccione", 0))

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Tipo_Tenencia, 40, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Cuantas_habitaciones, 41, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Cuantas_Personas_Habitan, 42, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Personas_Habitacion, 43, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Materiales_Vivienda, 44, New ListItem("Seleccione", 0))

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(Ddl_Tipo_desplazamiento, 45, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Departamento_Expulsor, 46, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Cuantos_Desplazamientos, 47, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Ha_Declarado_Antes, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Ha_Regresado, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(Lst_Causas, 60)
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(lst_Danos, 61)

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Tiempo_Demoro, 48, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Motivo_Demora, 49, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_EsdelMunicipio, 4, New ListItem("Seleccione", 0))

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(Lst_Tipos_Contacto, 19)
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Familias_Accion, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_emociones, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(Ddl_Concejo_Expulsor, 17, New ListItem("Seleccione", 0))

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(Lst_PersonasAyuda, 88)
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(Lst_ApoyoPersonas, 89)

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Tipo_Adiccion, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_departamento_faccion, 46, New ListItem("Seleccione", 0))

        '
        cargarbeneficiarios(Nothing, Nothing)

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


        If Request.QueryString.Item("Editar") = 1 Then
            Dim objDeclaracion As DeclaracionBrl = DeclaracionBrl.CargarPorID(Request.QueryString.Item("ID"))

            If objDeclaracion Is Nothing Then
                lblMensaje.Text = "Registro no existe"
                lblMensaje.Visible = True
                Exit Sub
            End If

            '
            ' cargando Declaracion
            '

            lbl_Nombre_Completo.Text = objDeclaracion.Personas_Declarante.NombreCompleto
            Try
                lbl_Grupo.Text = objDeclaracion.DescripcionGrupo
            Catch ex As Exception
                lbl_Grupo.Text = ""
            End Try

            txt_NinosMenores.Text = objDeclaracion.Menores_Ninos
            Txt_Gestantes.Text = objDeclaracion.Gestantes
            Txt_RestoNucleo.Text = objDeclaracion.Resto_Nucleo
            Chb_Cerrado.Checked = objDeclaracion.Cierre
            txt_vereda.Text = objDeclaracion.Vereda_Desplazamiento

            'Vivienda
            If ddl_Tipo_Tenencia.Items.FindByValue(objDeclaracion.Id_Tipo_Tenencia_Vivienda) IsNot Nothing Then ddl_Tipo_Tenencia.SelectedValue = objDeclaracion.Id_Tipo_Tenencia_Vivienda
            If ddl_Cuantas_habitaciones.Items.FindByValue(objDeclaracion.Id_Cuantas_Habitaciones) IsNot Nothing Then ddl_Cuantas_habitaciones.SelectedValue = objDeclaracion.Id_Cuantas_Habitaciones
            If ddl_Cuantas_Personas_Habitan.Items.FindByValue(objDeclaracion.Id_Cuantas_Personas_Vivienda) IsNot Nothing Then ddl_Cuantas_Personas_Habitan.SelectedValue = objDeclaracion.Id_Cuantas_Personas_Vivienda
            If ddl_Personas_Habitacion.Items.FindByValue(objDeclaracion.Id_Cuantas_Personas_Habitacion) IsNot Nothing Then ddl_Personas_Habitacion.SelectedValue = objDeclaracion.Id_Cuantas_Personas_Habitacion
            If ddl_Materiales_Vivienda.Items.FindByValue(objDeclaracion.Id_Materiales_Vivienda) IsNot Nothing Then ddl_Materiales_Vivienda.SelectedValue = objDeclaracion.Id_Materiales_Vivienda
            'VBG
            If ddl_Llegada_vbg.Items.FindByValue(objDeclaracion.Id_VBG_general) IsNot Nothing Then ddl_Llegada_vbg.SelectedValue = objDeclaracion.Id_VBG_general
            '
            If ddl_Familias_Accion.Items.FindByValue(objDeclaracion.Id_Familias_Accion) IsNot Nothing Then ddl_Familias_Accion.SelectedValue = objDeclaracion.Id_Familias_Accion
            ddl_Familias_Accion_SelectedIndexChanged(Nothing, Nothing)
            If objDeclaracion.Id_Familias_Accion = 19 Then
                ddl_departamento_faccion.SelectedValue = objDeclaracion.Municipio_Faccion.Id_Padre
                ddl_departamento_faccion_SelectedIndexChanged(Nothing, Nothing)
                ddl_municipio_faccion.SelectedValue = objDeclaracion.Id_Municipio_Faccion
            End If

            'Desplazamiento

            rdpfechaDesplazamiento.SelectedDate = objDeclaracion.Fecha_Desplazamiento
            If Ddl_Tipo_desplazamiento.Items.FindByValue(objDeclaracion.Id_Forma_Declaracion) IsNot Nothing Then Ddl_Tipo_desplazamiento.SelectedValue = objDeclaracion.Id_Forma_Declaracion
            If ddl_Departamento_Expulsor.Items.FindByValue(objDeclaracion.Id_Departamento_Expulsor) IsNot Nothing Then ddl_Departamento_Expulsor.SelectedValue = objDeclaracion.Id_Departamento_Expulsor
            If ddl_Cuantos_Desplazamientos.Items.FindByValue(objDeclaracion.Id_Cuantos_Desplazamientos) IsNot Nothing Then ddl_Cuantos_Desplazamientos.SelectedValue = objDeclaracion.Id_Cuantos_Desplazamientos
            If ddl_Ha_Declarado_Antes.Items.FindByValue(objDeclaracion.Id_Ha_Declarado_Antes) IsNot Nothing Then ddl_Ha_Declarado_Antes.SelectedValue = objDeclaracion.Id_Ha_Declarado_Antes
            txt_Lugar_Otro_Desplazamiento.Text = objDeclaracion.Lugar_Desplazamiento
            rdpfechaOtroDesplazamiento.SelectedDate = objDeclaracion.Fecha_Desplazamiento_Anterior
            If ddl_Ha_Regresado.Items.FindByValue(objDeclaracion.Id_Ha_Regresado) IsNot Nothing Then ddl_Ha_Regresado.SelectedValue = objDeclaracion.Id_Ha_Regresado
            rdpfechaDeclaracion.SelectedDate = objDeclaracion.Fecha_Declaracion
            If ddl_Fuente.Items.FindByValue(objDeclaracion.Id_Fuente) IsNot Nothing Then ddl_Fuente.SelectedValue = objDeclaracion.Id_Fuente
            If ddl_Tiempo_Demoro.Items.FindByValue(objDeclaracion.Id_Cuanto_Tiempo_Demoro) IsNot Nothing Then ddl_Tiempo_Demoro.SelectedValue = objDeclaracion.Id_Cuanto_Tiempo_Demoro
            ddl_Tiempo_Demoro_SelectedIndexChanged(Nothing, Nothing)
            If ddl_Motivo_Demora.Items.FindByValue(objDeclaracion.Id_Motivo_Demora) IsNot Nothing Then ddl_Motivo_Demora.SelectedValue = objDeclaracion.Id_Motivo_Demora
            If ddl_EsdelMunicipio.Items.FindByValue(objDeclaracion.Id_Es_Del_Municipio) IsNot Nothing Then ddl_EsdelMunicipio.SelectedValue = objDeclaracion.Id_Es_Del_Municipio
            If ddl_Agua_Potable.Items.FindByValue(objDeclaracion.Id_Agua_Potable) IsNot Nothing Then ddl_Agua_Potable.SelectedValue = objDeclaracion.Id_Agua_Potable

            ' Reparaciones

            If ddl_Solicito_Atencion_Psicologica.Items.FindByValue(objDeclaracion.Id_Solicito_Atencion_Psicologica) IsNot Nothing Then ddl_Solicito_Atencion_Psicologica.SelectedValue = objDeclaracion.Id_Solicito_Atencion_Psicologica
            ddl_Solicito_Atencion_Psicologica_SelectedIndexChanged(Nothing, Nothing)
            If ddl_emociones.Items.FindByValue(objDeclaracion.Id_Emociones) IsNot Nothing Then ddl_emociones.SelectedValue = objDeclaracion.Id_Emociones
            ddl_emociones_SelectedIndexChanged(Nothing, Nothing)
            txt_Observaciones.Text = objDeclaracion.Observaciones

            ' Cargando las listas

            Dim ListPersonasAyuda As List(Of Declaracion_Personas_AyudaBrl)
            ListPersonasAyuda = objDeclaracion.Declaracion_Personas_Ayuda
            FilterHelper.FilterHelper(ListPersonasAyuda, "Id_Tipo_Entrega", 72)
            For Each fila As Declaracion_Personas_AyudaBrl In ListPersonasAyuda
                Lst_PersonasAyuda_Declarante.Items.Add(New ListItem(fila.Personas_Ayuda.Descripcion, fila.Id_Personas_Ayuda))
            Next

            Dim ListApoyoPersonas As List(Of Declaracion_Apoyo_AyudaBrl)
            ListApoyoPersonas = objDeclaracion.Declaracion_Apoyo_Ayuda
            FilterHelper.FilterHelper(ListApoyoPersonas, "Id_Tipo_Entrega", 72)
            For Each fila As Declaracion_Apoyo_AyudaBrl In ListApoyoPersonas
                Lst_ApoyoPersonas_Declarante.Items.Add(New ListItem(fila.Apoyo_Ayuda.Descripcion, fila.Id_Apoyo_Ayuda))
            Next

            Dim listObtencion_Agua As New List(Of Declaracion_Obtencion_AguaBrl)
            listObtencion_Agua = objDeclaracion.Declaracion_Obtencion_Agua

            ' Declaracion_Obtencion_AguaBrl.CargarPorId_Declaracion(Request.QueryString.Item("ID"))
            For Each fila As Declaracion_Obtencion_AguaBrl In listObtencion_Agua
                Lst_ObtieneAguaDeclarante.Items.Add(New ListItem(fila.SubTablasLugar_Agua.Descripcion, fila.Id_Lugar_Agua))
                ' Lst_ObtieneAgua.Items.RemoveAt(fila.Id_Lugar_Agua)
            Next

            Dim ListCausasDesplazamiento As List(Of Declaracion_Causas_DesplazamientoBrl)
            ListCausasDesplazamiento = objDeclaracion.Declaracion_Causas_Desplazamiento
            'Declaracion_Causas_DesplazamientoBrl.CargarPorId_Declaracion(Request.QueryString.Item("ID"))
            For Each fila As Declaracion_Causas_DesplazamientoBrl In ListCausasDesplazamiento
                Lst_causasDec.Items.Add(New ListItem(fila.SubTablasCausa_Desplazamiento.Descripcion, fila.Id_Causa_Desplazamiento))
                ' Lst_FuentesIngreso.Items.RemoveAt(fila.Id_Fuentes_Ingreso)
            Next

            Dim ListDanosFamilia As List(Of Declaracion_Danos_FamiliaBrl)
            ListDanosFamilia = objDeclaracion.Declaracion_Danos_Familia
            'Declaracion_Danos_FamiliaBrl.CargarPorId_Declaracion(Request.QueryString.Item("ID"))
            For Each fila As Declaracion_Danos_FamiliaBrl In ListDanosFamilia
                Lst_danosDec.Items.Add(New ListItem(fila.SubTablasDanos_Familia.Descripcion, fila.Id_Danos_Familia))
                ' Lst_FuentesIngreso.Items.RemoveAt(fila.Id_Fuentes_Ingreso)
            Next

            ' cargas los datos de la persona
            Lst_Tipos_Contacto_Persona.Items.Clear()
            Dim objpersona As PersonasBrl = PersonasBrl.CargarPorId_DeclaracionYDeclarante(Request.QueryString.Item("Id"))
            If objpersona IsNot Nothing Then
                Dim objcontactos As List(Of Personas_ContactosBrl)
                objcontactos = Personas_ContactosBrl.CargarPorId_Persona(objpersona.ID)
                For Each fila As Personas_ContactosBrl In objcontactos
                    Me.Lst_Tipos_Contacto_Persona.Items.Add(New ListItem(fila.SubTablasTipoContacto.Descripcion & " : " & fila.Descripcion, fila.Id_Tipo_Contacto))
                Next
            End If

            If ddl_Tipo_Adiccion.Items.FindByValue(objDeclaracion.Id_Tipo_Adiccion) IsNot Nothing Then ddl_Tipo_Adiccion.SelectedValue = objDeclaracion.Id_Tipo_Adiccion
            ddl_Tipo_Adiccion_SelectedIndexChanged(Nothing, Nothing)

            Select Case objDeclaracion.Id_Adiccion_Alcohol
                Case Is = 19
                    chk_alcohol.Checked = True
                Case Is = 20
                    chk_alcohol.Checked = False
                Case Else
                    chk_alcohol.Checked = False
            End Select

            Select Case objDeclaracion.Id_Adiccion_Droga
                Case Is = 19
                    chk_droga.Checked = True
                Case Is = 20
                    chk_droga.Checked = False
                Case Else
                    chk_droga.Checked = False
            End Select

            '
            ' Validando los campos
            '
            ddl_Ha_Declarado_Antes_SelectedIndexChanged(Nothing, Nothing)
            ddl_Departamento_Expulsor_SelectedIndexChanged(Nothing, Nothing)
            If ddl_Municipio_Expulsor.Items.FindByValue(objDeclaracion.Id_Municipio_Expulsor) IsNot Nothing Then ddl_Municipio_Expulsor.SelectedValue = objDeclaracion.Id_Municipio_Expulsor
            ddl_Municipio_Expulsor_SelectedIndexChanged(Nothing, Nothing)
            If Ddl_Concejo_Expulsor.Items.FindByValue(objDeclaracion.Id_Concejo_Expulsor) IsNot Nothing Then Ddl_Concejo_Expulsor.SelectedValue = objDeclaracion.Id_Concejo_Expulsor
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
                    FilterHelper.FilterHelper(Listemocion, "Id_Tipo_Entrega", 72)  ' Primera Entrega
                    If Listemocion.Count > 0 Then
                        ddl_emociones_usted.SelectedValue = Listemocion.Item(0).Dato_Usted
                        ddl_emociones_familia.SelectedValue = Listemocion.Item(0).Dato_Familia
                    Else
                        ddl_emociones_usted.SelectedValue = 0
                        ddl_emociones_familia.SelectedValue = 0

                    End If
                End If
            Next

            Dim objpaari As List(Of Declaracion_PAARIBrl) = objDeclaracion.Declaracion_PAARI
            FilterHelper.FilterHelper(objpaari, "Id_Tipo_Entrega", 72)
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

    Public Sub cargarbeneficiarios(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ListPersonas As New List(Of PersonasBrl)
        ListPersonas = PersonasBrl.CargarPorId_Declaracion(Request.QueryString.Item("Id"))
        Session("ListPersonas") = ListPersonas
        Rg_Listado.DataSource = Session("ListPersonas")
        Rg_Listado.DataBind()

        Dg_Psicosocial.DataSource = Session("ListPersonas")
        Dg_Psicosocial.DataBind()
    End Sub

    Public Function validar() As Boolean
        Dim wvalidas As Boolean = False
        wmensaje = ""
        '
        If Lst_causasDec.Items.Count = 0 Then
            wmensaje = wmensaje + "Falta colocar al menos una causa del desplazamiento. "
        End If
        If Lst_danosDec.Items.Count = 0 Then
            wmensaje = wmensaje + "Falta colocar al menos un daño que le causo el desplazamiento a la familia. "
        End If
        '

        If Lst_ObtieneAguaDeclarante.Items.Count = 0 Then
            wmensaje = wmensaje + "Falta seleccionar el modo de obtención del agua. "
        End If

        If ddl_emociones.SelectedValue = 19 Then
            If Lst_PersonasAyuda_Declarante.Items.Count = 0 Then
                wmensaje = wmensaje + "Falta seleccionar al menos una persona de ayuda. "
            End If
            If Lst_ApoyoPersonas_Declarante.Items.Count = 0 Then
                wmensaje = wmensaje + "Falta seleccionar al menos un apoyo de esa persona. "
            End If

        End If

        '
        If wmensaje = "" Then Return False Else Return True
        '
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        lblMensaje.Text = ""
        lblMensaje.Visible = True
        Validate("GA")
        If Not IsValid Then Exit Sub

        If Chb_Cerrado.Checked Then
            lblMensaje.Text = "Registro Cerrado. No se puede Modificar.!!!!"
            lblMensaje.Visible = True
            Exit Sub
        End If

        If validar() Then
            lblMensaje.Text = wmensaje
            Exit Sub
        End If

        Dim ID As Int32

        Try
            ID = Grabar()
            Response.Redirect("PrimeraEncuesta.aspx?Editar=1&Mensaje=1&ID=" & ID)
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Private Function Grabar() As Int32

        Dim objDeclaracion As DeclaracionBrl
        If Request.QueryString.Item("Editar") = 1 Then
            objDeclaracion = DeclaracionBrl.CargarPorID(Request.QueryString.Item("ID"))
            objDeclaracion.Fecha_Modificacion = Now
            objDeclaracion.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text
        Else
            objDeclaracion = New DeclaracionBrl
            objDeclaracion.Fecha_Creacion = Now
            objDeclaracion.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
        End If

        If txt_NinosMenores.Text.Trim = "" Then
            objDeclaracion.Menores_Ninos = 0
        Else
            objDeclaracion.Menores_Ninos = txt_NinosMenores.Text
        End If

        If Txt_Gestantes.Text.Trim = "" Then
            objDeclaracion.Gestantes = 0
        Else
            objDeclaracion.Gestantes = Txt_Gestantes.Text
        End If

        If Txt_RestoNucleo.Text.Trim = "" Then
            objDeclaracion.Resto_Nucleo = 0
        Else
            objDeclaracion.Resto_Nucleo = Txt_RestoNucleo.Text
        End If
        If objDeclaracion.Fecha_Valoracion = Nothing Then
            For Each fila As Declaracion_EstadosBrl In objDeclaracion.Declaracion_Estados
                If fila.Id_Programa <> 0 Then
                    If fila.Programa.Id_TipoEntrega = 72 Then  '' Primera entrega
                        If fila.Id_Programa <> 0 Then
                            objDeclaracion.Fecha_Valoracion = fila.Programa.Fecha
                        End If
                    End If
                End If
            Next
        End If
        objDeclaracion.Id_Tipo_Tenencia_Vivienda = ddl_Tipo_Tenencia.SelectedValue
        objDeclaracion.Id_Cuantas_Habitaciones = ddl_Cuantas_habitaciones.SelectedValue
        objDeclaracion.Id_Cuantas_Personas_Vivienda = ddl_Cuantas_Personas_Habitan.SelectedValue
        objDeclaracion.Id_Cuantas_Personas_Habitacion = ddl_Personas_Habitacion.SelectedValue
        objDeclaracion.Id_Materiales_Vivienda = ddl_Materiales_Vivienda.SelectedValue
        objDeclaracion.Id_Agua_Potable = ddl_Agua_Potable.SelectedValue
        objDeclaracion.Id_Forma_Declaracion = Ddl_Tipo_desplazamiento.SelectedValue
        objDeclaracion.Id_Departamento_Expulsor = ddl_Departamento_Expulsor.SelectedValue
        objDeclaracion.Id_Municipio_Expulsor = ddl_Municipio_Expulsor.SelectedValue
        objDeclaracion.Vereda_Desplazamiento = txt_vereda.Text
        objDeclaracion.Id_Concejo_Expulsor = Ddl_Concejo_Expulsor.SelectedValue
        objDeclaracion.Id_Cuantos_Desplazamientos = ddl_Cuantos_Desplazamientos.SelectedValue
        objDeclaracion.Id_Ha_Declarado_Antes = ddl_Ha_Declarado_Antes.SelectedValue
        Try
            objDeclaracion.Fecha_Desplazamiento_Anterior = rdpfechaOtroDesplazamiento.DbSelectedDate
        Catch ex As Exception
            objDeclaracion.Fecha_Desplazamiento_Anterior = Nothing
        End Try
        objDeclaracion.Lugar_Desplazamiento = txt_Lugar_Otro_Desplazamiento.Text
        objDeclaracion.Id_Ha_Regresado = ddl_Ha_Regresado.SelectedValue
        Try
            objDeclaracion.Fecha_Declaracion = rdpfechaDeclaracion.DbSelectedDate

        Catch ex As Exception
            objDeclaracion.Fecha_Declaracion = Nothing
        End Try
        objDeclaracion.Id_Fuente = ddl_Fuente.SelectedValue
        objDeclaracion.Id_Cuanto_Tiempo_Demoro = ddl_Tiempo_Demoro.SelectedValue
        objDeclaracion.Id_Motivo_Demora = ddl_Motivo_Demora.SelectedValue
        objDeclaracion.Id_Es_Del_Municipio = ddl_EsdelMunicipio.SelectedValue
        objDeclaracion.Id_Familias_Accion = ddl_Familias_Accion.SelectedValue
        objDeclaracion.Id_Municipio_Faccion = ddl_municipio_faccion.SelectedValue
        objDeclaracion.Id_VBG_general = ddl_Llegada_vbg.SelectedValue
        objDeclaracion.Id_Solicito_Atencion_Psicologica = ddl_Solicito_Atencion_Psicologica.SelectedValue
        objDeclaracion.Id_Emociones = ddl_emociones.SelectedValue
        objDeclaracion.Observaciones = txt_Observaciones.Text

        If lbl_actcontacto.Text = "1" Then  ' Se toco los contactos
            ' Eliminado los contactos actuales
            Dim objpersona As PersonasBrl
            objpersona = PersonasBrl.CargarPorId_DeclaracionYDeclarante(Request.QueryString.Item("ID"))
            Dim listpersonas As New List(Of PersonasBrl)
            Dim objcontactos As List(Of Personas_ContactosBrl) = Personas_ContactosBrl.CargarPorId_Persona(objpersona.ID)
            For Each fila As Personas_ContactosBrl In objcontactos
                fila.Eliminar()
            Next

            ' cargando los contactos
            Dim wcadena As String
            Dim objcontacto As New Personas_ContactosBrl
            For Each item As ListItem In Me.Lst_Tipos_Contacto_Persona.Items
                objcontacto = New Personas_ContactosBrl
                objcontacto.Activo = False
                objcontacto.Id_Tipo_Contacto = item.Value
                wcadena = item.Text
                wcadena = item.Text.Substring(wcadena.LastIndexOf(":") + 2, (wcadena.Length - (wcadena.LastIndexOf(":") + 2)))
                objcontacto.Descripcion = wcadena
                objcontacto.Fecha_Creacion = Now
                objcontacto.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
                objcontactos.Add(objcontacto)
            Next

            objpersona.Personas_Contactos = objcontactos
            listpersonas.Add(objpersona)
            objDeclaracion.Personas = listpersonas
        End If

        objDeclaracion.Id_Tipo_Adiccion = ddl_Tipo_Adiccion.SelectedValue
        If chk_alcohol.Checked Then
            objDeclaracion.Id_Adiccion_Alcohol = 19
        Else
            objDeclaracion.Id_Adiccion_Alcohol = 20
        End If
        If chk_droga.Checked Then
            objDeclaracion.Id_Adiccion_Droga = 19
        Else
            objDeclaracion.Id_Adiccion_Droga = 20
        End If



        objDeclaracion.Guardar()

        ' Grabar la  informacion de las listas 
        ' Generalmente es actualizar.
        ' Primero se elimina lo existente

        Dim ListObtencionAguaDec As List(Of Declaracion_Obtencion_AguaBrl)
        ListObtencionAguaDec = Declaracion_Obtencion_AguaBrl.CargarPorId_Declaracion(objDeclaracion.ID)
        For Each fila As Declaracion_Obtencion_AguaBrl In ListObtencionAguaDec
            fila.Eliminar()
        Next

        Dim ListcausasDec As List(Of Declaracion_Causas_DesplazamientoBrl)
        ListcausasDec = Declaracion_Causas_DesplazamientoBrl.CargarPorId_Declaracion(objDeclaracion.ID)
        For Each fila As Declaracion_Causas_DesplazamientoBrl In ListcausasDec
            fila.Eliminar()
        Next

        Dim ListFuentesIngresoDec As List(Of Declaracion_Fuentes_IngresoBrl)
        ListFuentesIngresoDec = Declaracion_Fuentes_IngresoBrl.CargarPorId_Declaracion(objDeclaracion.ID)
        For Each fila As Declaracion_Fuentes_IngresoBrl In ListFuentesIngresoDec
            fila.Eliminar()
        Next

        Dim ListdanosDec As List(Of Declaracion_Danos_FamiliaBrl)
        ListdanosDec = Declaracion_Danos_FamiliaBrl.CargarPorId_Declaracion(objDeclaracion.ID)
        For Each fila As Declaracion_Danos_FamiliaBrl In ListdanosDec
            fila.Eliminar()
        Next

        Dim listPersonasAyudaDec As List(Of Declaracion_Personas_AyudaBrl)
        listPersonasAyudaDec = Declaracion_Personas_AyudaBrl.CargarPorId_Declaracion(objDeclaracion.ID)
        For Each fila As Declaracion_Personas_AyudaBrl In listPersonasAyudaDec
            fila.Eliminar()
        Next

        Dim listApoyoAyudaDec As List(Of Declaracion_Apoyo_AyudaBrl)
        listApoyoAyudaDec = Declaracion_Apoyo_AyudaBrl.CargarPorId_Declaracion(objDeclaracion.ID)
        For Each fila As Declaracion_Apoyo_AyudaBrl In listApoyoAyudaDec
            fila.Eliminar()
        Next

        Dim ListBienesDec As List(Of Declaracion_BienesBrl)  ' funciona para los dos tipos de bienes
        ListBienesDec = Declaracion_BienesBrl.CargarPorId_Declaracion(objDeclaracion.ID)
        For Each fila As Declaracion_BienesBrl In ListBienesDec
            fila.Eliminar()
        Next

        ' grabando los nuevos registros

        Dim objobtaguadec As Declaracion_Obtencion_AguaBrl
        For Each detalle As ListItem In Me.Lst_ObtieneAguaDeclarante.Items
            objobtaguadec = New Declaracion_Obtencion_AguaBrl
            objobtaguadec.Id_Declaracion = objDeclaracion.ID
            objobtaguadec.Id_Lugar_Agua = detalle.Value
            objobtaguadec.Fecha_Creacion = Now
            objobtaguadec.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
            objobtaguadec.Guardar()
        Next

        Dim objcausasdec As Declaracion_Causas_DesplazamientoBrl
        For Each detalle As ListItem In Me.Lst_causasDec.Items
            objcausasdec = New Declaracion_Causas_DesplazamientoBrl
            objcausasdec.Id_Declaracion = objDeclaracion.ID
            objcausasdec.Id_Causa_Desplazamiento = detalle.Value
            objcausasdec.Fecha_Creacion = Now
            objcausasdec.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
            objcausasdec.Guardar()
        Next

        Dim objdanosdec As Declaracion_Danos_FamiliaBrl
        For Each detalle As ListItem In Me.Lst_danosDec.Items
            objdanosdec = New Declaracion_Danos_FamiliaBrl
            objdanosdec.Id_Declaracion = objDeclaracion.ID
            objdanosdec.Id_Danos_Familia = detalle.Value
            objdanosdec.Fecha_Creacion = Now
            objdanosdec.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
            objdanosdec.Guardar()
        Next

        Dim objpersonasayudadec As Declaracion_Personas_AyudaBrl
        For Each detalle As ListItem In Me.Lst_PersonasAyuda_Declarante.Items
            objpersonasayudadec = New Declaracion_Personas_AyudaBrl
            objpersonasayudadec.Id_Declaracion = objDeclaracion.ID
            objpersonasayudadec.Id_Personas_Ayuda = detalle.Value
            objpersonasayudadec.Id_Tipo_Entrega = 72 ' Primera Entrega
            objpersonasayudadec.Guardar()
        Next

        Dim objapoyoayudadec As Declaracion_Apoyo_AyudaBrl
        For Each detalle As ListItem In Me.Lst_ApoyoPersonas_Declarante.Items
            objapoyoayudadec = New Declaracion_Apoyo_AyudaBrl
            objapoyoayudadec.Id_Declaracion = objDeclaracion.ID
            objapoyoayudadec.Id_Apoyo_Ayuda = detalle.Value
            objapoyoayudadec.Id_Tipo_Entrega = 72 ' Primera Entrega
            objapoyoayudadec.Guardar()
        Next

        '
        '  Grabando lo psicosocial
        '

        Dim lblidpsi As Label
        Dim chk_sap, chk_rap, chk_add As CheckBox
        Dim txt_quien As TextBox
        Dim objpersonas As PersonasBrl
        For Each fila As DataGridItem In Dg_Psicosocial.Items
            If fila.ItemType = ListItemType.AlternatingItem Or fila.ItemType = ListItemType.Item Then
                lblidpsi = fila.FindControl("lblidPsi")
                chk_sap = fila.FindControl("chk_sap")
                chk_rap = fila.FindControl("chk_rap")
                chk_add = fila.FindControl("chk_add")
                txt_quien = fila.FindControl("txt_quien")
                objpersonas = PersonasBrl.CargarPorID(lblidpsi.Text)
                objpersonas.Id_Solicito_Atencion_Psicologica = 20
                objpersonas.Id_Recibio_Atencion_Psicologica = 20
                objpersonas.Quien_Atencion_Psicologica = ""
                objpersonas.Id_Afectado_Desplazamiento = 20
                If Me.ddl_Solicito_Atencion_Psicologica.SelectedValue = 19 Then
                    If chk_sap.Checked Then
                        objpersonas.Id_Solicito_Atencion_Psicologica = 19
                    End If
                    If chk_rap.Checked Then
                        objpersonas.Id_Recibio_Atencion_Psicologica = 19
                        objpersonas.Quien_Atencion_Psicologica = txt_quien.Text
                    End If
                End If

                objpersonas.Guardar()
            End If
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
                Dim Listemociones As List(Of Declaracion_PsicosocialBrl) = Declaracion_PsicosocialBrl.CargarPorId_Declaracion(objDeclaracion.ID)
                FilterHelper.FilterHelper(Listemociones, "Id_Emocion", lblidemo.Text)
                FilterHelper.FilterHelper(Listemociones, "Id_Tipo_Entrega", 72) ' Filtro Primera Entrega
                If Listemociones.Count = 0 Then ' Nuevo
                    objemocion = New Declaracion_PsicosocialBrl
                    objemocion.Id_Declaracion = objDeclaracion.ID
                Else
                    objemocion = Listemociones.Item(0)
                End If

                objemocion.Id_Emocion = lblidemo.Text
                objemocion.Id_Tipo_Entrega = 72
                objemocion.Dato_Usted = ddl_emociones_usted.SelectedValue
                objemocion.Dato_Familia = ddl_emociones_familia.SelectedValue
                objemocion.Guardar()
            End If
        Next

        '
        ' Guardando Fecha de Regimen de Salud
        '
        Dim objregimensalud As Personas_Regimen_SaludBrl
        For Each fila As PersonasBrl In objDeclaracion.Personas
            objregimensalud = New Personas_Regimen_SaludBrl
            objregimensalud = fila.Regimen_Salud_Antes
            If objregimensalud IsNot Nothing Then
                objregimensalud.Fecha = objDeclaracion.Fecha_Valoracion
                objregimensalud.Guardar()
            End If
            objregimensalud = New Personas_Regimen_SaludBrl
            objregimensalud = fila.Regimen_Salud_Despues
            If objregimensalud IsNot Nothing Then
                objregimensalud.Fecha = objDeclaracion.Fecha_Valoracion
                objregimensalud.Guardar()
            End If

        Next

        '
        '  Guardando lo de PAARI
        '
        '

        Dim ListPaari As List(Of Declaracion_PAARIBrl) = Declaracion_PAARIBrl.CargarPorId_Declaracion(Request.QueryString.Item("Id"))
        FilterHelper.FilterHelper(ListPaari, "Id_Tipo_Entrega", 72)
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
            objpaari.Id_Tipo_Entrega = 72
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

        Return objDeclaracion.ID

    End Function

    Protected Sub btnLimpiar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        txt_Nombre1.Text = ""
        Txt_Nombre2.Text = ""
        Txt_Apellido1.Text = ""
        Txt_Apellido2.Text = ""
        rdb_Declarante.Checked = False
        rdb_Beneficiario.Checked = True
        ddl_Genero.SelectedValue = 0
        ddl_Grupo_Etnico.SelectedValue = 0
        rdpfechaNacimiento.SelectedDate = Nothing
        txt_edad.Text = ""
        ddl_Tipo_Identificacion.SelectedValue = 0
        txt_Identificacion.Text = ""
        ddl_Parentesco.SelectedValue = 0
        ddl_Parentesco.Enabled = True
        rev_parentesco.Enabled = True
        Ddl_Tipo_Miembro.SelectedValue = 0
        lblid.Text = ""

        ddl_Discapacitado.SelectedValue = 0
        ddl_Tipo_Discapacidad.SelectedValue = 0
        ddl_Eps_Antes.SelectedValue = 0
        ddl_Regimen_Salud_Antes.SelectedValue = 0
        ddl_Eps_Despues.SelectedValue = 0
        ddl_Regimen_Salud_Despues.SelectedValue = 0
        ddl_Embarazada.SelectedValue = 0
        ddl_lactando.SelectedValue = 0
        ddl_Sabe_Leer.SelectedValue = 0
        ddl_EstudiabaAntes.SelectedValue = 0
        ddl_EstudiaActualmente.SelectedValue = 0
        ddl_UltimoGrado.SelectedValue = 0
        txt_Institucion_Estudiaba.Text = ""
        txt_Institucion_Estudia.Text = ""
        ddl_MotivoNoEstudio.SelectedValue = 0
        ddl_certificacion.SelectedValue = 0
        Ddl_Tipo_Apoyo_Escolar.SelectedValue = 0

        ddl_departamento_antes.SelectedValue = 0
        ddl_departamento_antes_SelectedIndexChanged(Nothing, Nothing)
        ddl_departamento_actual.SelectedValue = 0
        ddl_departamento_actual_SelectedIndexChanged(Nothing, Nothing)

        ddl_departamento_rsa.SelectedValue = 0
        ddl_departamento_rsa_SelectedIndexChanged(Nothing, Nothing)
        ddl_departamento_rsd.SelectedValue = 0
        ddl_departamento_rsd_SelectedIndexChanged(Nothing, Nothing)

        lbl_Solicito.Text = "Sin Dato!!"
        lbl_Recibio_Atencion.Text = "Sin Dato!!!"
        Lbl_Afectado_Desplazamiento.Text = "Sin Dato!!"
        lbl_Quien_Atendio.Text = "Sin Dato!!"

        txt_Nombre1.Focus()
    End Sub

    Public Function validarpersona() As Boolean
        wmensaje = ""
        If ddl_Discapacitado.SelectedValue = 19 Then
            If ddl_Tipo_Discapacidad.SelectedValue = 0 Then
                wmensaje = wmensaje + "Falta seleccionar el tipo de discapacidad de la persona. "
            End If
        End If

        If ddl_Genero.SelectedValue = 5 Then
            If (Val(txt_edad.Text.Trim) >= 13) And (Val(txt_edad.Text.Trim) < 50) Then
                If ddl_lactando.SelectedValue = 0 Then
                    wmensaje = wmensaje + "Falta seleccionar si la mujer esta lactando. "
                End If
                If ddl_Embarazada.SelectedValue = 0 Then
                    wmensaje = wmensaje + "Falta seleccionar si la mujer esta embarazada. "
                End If

            End If
        End If
        '
        If lblid.Text.Trim = "" Then
            Dim objvalidapersona As List(Of PersonasBrl) = PersonasBrl.CargarPorIdentificacion(ddl_Tipo_Identificacion.SelectedValue, txt_Identificacion.Text.Trim)
            If objvalidapersona.Count <> 0 Then
                wmensaje = wmensaje + "la Identificación utilizada para esta persona ya fue utilizada por : " + objvalidapersona.Item(0).NombreCompleto + " en el grupo " + objvalidapersona.Item(0).Declaracion.DescripcionGrupo
            End If
        End If

        If wmensaje = "" Then Return False Else Return True


    End Function

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_GuardarPersona.Click
        Validate("GB")
        If Not IsValid Then Exit Sub

        If Chb_Cerrado.Checked Then
            lblMensaje.Text = "Registro Cerrado. No se puede Modificar.!!!!"
            lblMensaje.Visible = True
            Exit Sub
        End If

        If validarpersona() Then
            lblMensaje.Text = wmensaje
            lblMensaje.Visible = True
            Exit Sub
        End If

        Dim objpersona As PersonasBrl
        If lblid.Text.Trim <> "" Then
            objpersona = PersonasBrl.CargarPorID(lblid.Text)
            objpersona.Fecha_Modificacion = Now
            objpersona.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text
        Else
            objpersona = New PersonasBrl
            objpersona.Fecha_Creacion = Now
            objpersona.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
        End If

        objpersona.Primer_Nombre = txt_Nombre1.Text
        objpersona.Segundo_Nombre = Txt_Nombre2.Text
        objpersona.Primer_Apellido = Txt_Apellido1.Text
        objpersona.Segundo_Apellido = Txt_Apellido2.Text

        '
        ' Validacion de Tipo de Persona que se ingresa
        '

        objpersona.Tipo = "B"
        If rdb_Declarante.Checked Then objpersona.Tipo = "D"

        objpersona.Id_Genero = ddl_Genero.SelectedValue
        objpersona.Id_Grupo_Etnico = ddl_Grupo_Etnico.SelectedValue
        If txt_edad.Text.Trim = "" Then
            objpersona.Edad = 0
        Else
            objpersona.Edad = txt_edad.Text
        End If

        objpersona.Fecha_Nacimiento = rdpfechaNacimiento.DbSelectedDate
        objpersona.Id_Tipo_Identificacion = ddl_Tipo_Identificacion.SelectedValue
        objpersona.Identificacion = txt_Identificacion.Text
        objpersona.Id_Parentesco = ddl_Parentesco.SelectedValue
        objpersona.Id_Tipo_Miembro = Ddl_Tipo_Miembro.SelectedValue
        objpersona.Id_Discapacitado = ddl_Discapacitado.SelectedValue
        objpersona.Id_Tipo_Discapacidad = ddl_Tipo_Discapacidad.SelectedValue
        objpersona.Id_Embarazada = ddl_Embarazada.SelectedValue
        objpersona.Id_Lactando = ddl_lactando.SelectedValue
        objpersona.Id_Sabe_Leer_Escribir = ddl_Sabe_Leer.SelectedValue
        objpersona.Id_Estudia_Antes = ddl_EstudiabaAntes.SelectedValue
        objpersona.Id_Estudia_Actualmente = ddl_EstudiaActualmente.SelectedValue
        objpersona.Id_Ultimo_Grado = ddl_UltimoGrado.SelectedValue
        objpersona.Institucion_Estudia = txt_Institucion_Estudia.Text
        objpersona.Institucion_Estudiaba = txt_Institucion_Estudiaba.Text
        objpersona.Id_Motivo_NoEstudio = ddl_MotivoNoEstudio.SelectedValue
        objpersona.Id_Declaracion = Request.QueryString.Item("ID")
        objpersona.Id_Certificado = ddl_certificacion.SelectedValue
        objpersona.Id_Tipo_Apoyo_Educativo = Ddl_Tipo_Apoyo_Escolar.SelectedValue
        objpersona.Id_Municipio_Instituto_Antes = ddl_municipio_instituto_antes.SelectedValue
        objpersona.Id_Municipio_Instituto_Actual = ddl_municipio_instituto_actual.SelectedValue

        '
        '  Guardando lo de Regimen de Salud
        '
        Dim objregimenantes As Personas_Regimen_SaludBrl
        Dim objregimendespues As Personas_Regimen_SaludBrl

        If lblid.Text.Trim = "" Then
            objregimenantes = New Personas_Regimen_SaludBrl
            objregimendespues = New Personas_Regimen_SaludBrl
        Else
            objregimenantes = objpersona.Regimen_Salud_Antes
            If objregimenantes Is Nothing Then objregimenantes = New Personas_Regimen_SaludBrl
            objregimendespues = objpersona.Regimen_Salud_Despues
            If objregimendespues Is Nothing Then objregimendespues = New Personas_Regimen_SaludBrl
        End If


        objregimenantes.Id_Regimen_Salud = ddl_Regimen_Salud_Antes.SelectedValue
        objregimenantes.Id_Eps = ddl_Eps_Antes.SelectedValue
        objregimenantes.Id_Municipio = ddl_municipio_rsa.SelectedValue

        objregimendespues.Id_Regimen_Salud = ddl_Regimen_Salud_Despues.SelectedValue
        objregimendespues.Id_Eps = ddl_Eps_Despues.SelectedValue
        objregimendespues.Id_Municipio = ddl_municipio_rsd.SelectedValue
        objregimenantes.Id_Tipo_Entrega = 54
        objregimendespues.Id_Tipo_Entrega = 72

        If lblid.Text.Trim = "" Then
            objpersona.Personas_Regimen_Salud.Add(objregimenantes)
            objpersona.Personas_Regimen_Salud.Add(objregimendespues)
        Else
            If objregimenantes.Id_Persona = 0 Then
                objpersona.Personas_Regimen_Salud.Add(objregimenantes)
            Else
                objregimenantes.Guardar()
            End If
            If objregimendespues.Id_Persona = 0 Then
                objpersona.Personas_Regimen_Salud.Add(objregimendespues)
            Else
                objregimendespues.Guardar()
            End If

        End If            '
        '
        '
        lblMensaje.Visible = True
        Try
            objpersona.Guardar()
            lblMensaje.Text = "Beneficiario grabado con exito."
            lblMensaje.ForeColor = Drawing.Color.Navy
            btnLimpiar_Click(Nothing, Nothing)
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.ForeColor = Drawing.Color.Red
        End Try
        cargarbeneficiarios(Nothing, Nothing)
    End Sub

    Protected Sub Lst_ObtieneAgua_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lst_ObtieneAgua.SelectedIndexChanged
        Lst_ObtieneAguaDeclarante.Items.Add(New ListItem(Lst_ObtieneAgua.SelectedItem.Text, Lst_ObtieneAgua.SelectedItem.Value))
        Lst_ObtieneAgua.Items.RemoveAt(Lst_ObtieneAgua.SelectedIndex)
    End Sub

    Protected Sub Lst_ObtieneAguaDeclarante_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lst_ObtieneAguaDeclarante.SelectedIndexChanged
        Lst_ObtieneAgua.Items.Add(New ListItem(Lst_ObtieneAguaDeclarante.SelectedItem.Text, Lst_ObtieneAguaDeclarante.SelectedItem.Value))
        Lst_ObtieneAguaDeclarante.Items.RemoveAt(Lst_ObtieneAguaDeclarante.SelectedIndex)
    End Sub

    Public Sub subCommandItem(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Select Case e.CommandName
            Case "EliminarBeneficiario"
                subEliminar(sender, e)
        End Select
    End Sub

    Protected Sub Rg_Listado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rg_Listado.SelectedIndexChanged
        Try
            Dim item As Telerik.Web.UI.GridDataItem = Me.Rg_Listado.SelectedItems.Item(Rg_Listado.SelectedIndexes.Item(0))
            Dim objpersona As PersonasBrl = PersonasBrl.CargarPorID(item("Id").Text)
            lblid.Text = ""
            If objpersona IsNot Nothing Then
                lblid.Text = objpersona.ID
                txt_Nombre1.Text = objpersona.Primer_Nombre
                Txt_Nombre2.Text = objpersona.Segundo_Nombre
                Txt_Apellido1.Text = objpersona.Primer_Apellido
                Txt_Apellido2.Text = objpersona.Segundo_Apellido
                rdb_Declarante.Checked = False
                rdb_Beneficiario.Checked = False

                If objpersona.Tipo = "D" Then
                    rdb_Declarante.Checked = True
                    ddl_Parentesco.Enabled = False
                    rev_parentesco.Enabled = False
                End If
                If objpersona.Tipo = "B" Then
                    rdb_Beneficiario.Checked = True
                    ddl_Parentesco.Enabled = True
                    rev_parentesco.Enabled = True
                End If
                ddl_Genero.SelectedValue = objpersona.Id_Genero
                If ddl_Grupo_Etnico.Items.FindByValue(objpersona.Id_Grupo_Etnico) IsNot Nothing Then ddl_Grupo_Etnico.SelectedValue = objpersona.Id_Grupo_Etnico
                rdpfechaNacimiento.SelectedDate = objpersona.Fecha_Nacimiento
                ddl_EstudiabaAntes.SelectedValue = objpersona.Id_Estudia_Antes
                ddl_EstudiaActualmente.SelectedValue = objpersona.Id_Estudia_Actualmente
                txt_edad.Text = objpersona.Edad
                txt_Edad_TextChanged(Nothing, Nothing)
                ddl_Tipo_Identificacion.SelectedValue = objpersona.Id_Tipo_Identificacion
                txt_Identificacion.Text = objpersona.Identificacion
                ddl_Parentesco.SelectedValue = objpersona.Id_Parentesco
                Ddl_Tipo_Miembro.SelectedValue = objpersona.Id_Tipo_Miembro
                '
                ddl_Discapacitado.SelectedValue = objpersona.Id_Discapacitado
                ddl_Tipo_Discapacidad.SelectedValue = objpersona.Id_Tipo_Discapacidad

                If ddl_Regimen_Salud_Antes.Items.FindByValue(objpersona.Regimen_Salud_Antes.Id_Regimen_Salud) IsNot Nothing Then ddl_Regimen_Salud_Antes.SelectedValue = objpersona.Regimen_Salud_Antes.Id_Regimen_Salud
                If ddl_Eps_Antes.Items.FindByValue(objpersona.Regimen_Salud_Antes.Id_Eps) IsNot Nothing Then ddl_Eps_Antes.SelectedValue = objpersona.Regimen_Salud_Antes.Id_Eps
                If ddl_Regimen_Salud_Despues.Items.FindByValue(objpersona.Regimen_Salud_Despues.Id_Regimen_Salud) IsNot Nothing Then ddl_Regimen_Salud_Despues.SelectedValue = objpersona.Regimen_Salud_Despues.Id_Regimen_Salud
                If ddl_Eps_Despues.Items.FindByValue(objpersona.Regimen_Salud_Despues.Id_Eps) IsNot Nothing Then ddl_Eps_Despues.SelectedValue = objpersona.Regimen_Salud_Despues.Id_Eps

                ddl_departamento_rsa.SelectedValue = objpersona.Regimen_Salud_Antes.MunicipioRS.Id_Padre
                ddl_departamento_rsa_SelectedIndexChanged(Nothing, Nothing)
                ddl_municipio_rsa.SelectedValue = objpersona.Regimen_Salud_Antes.Id_Municipio

                ddl_departamento_rsd.SelectedValue = objpersona.Regimen_Salud_Despues.MunicipioRS.Id_Padre
                ddl_departamento_rsd_SelectedIndexChanged(Nothing, Nothing)
                ddl_municipio_rsd.SelectedValue = objpersona.Regimen_Salud_Despues.Id_Municipio


                ddl_Sabe_Leer.SelectedValue = objpersona.Id_Sabe_Leer_Escribir
                txt_Institucion_Estudiaba.Text = objpersona.Institucion_Estudiaba
                ddl_UltimoGrado.SelectedValue = objpersona.Id_Ultimo_Grado
                txt_Institucion_Estudia.Text = objpersona.Institucion_Estudia
                ddl_MotivoNoEstudio.SelectedValue = objpersona.Id_Motivo_NoEstudio
                ddl_MotivoNoEstudio_SelectedIndexChanged(Nothing, Nothing)
                ddl_Embarazada.SelectedValue = objpersona.Id_Embarazada
                ddl_lactando.SelectedValue = objpersona.Id_Lactando
                ddl_certificacion.SelectedValue = objpersona.Id_Certificado
                Ddl_Tipo_Apoyo_Escolar.SelectedValue = objpersona.Id_Tipo_Apoyo_Educativo

                ddl_departamento_antes.SelectedValue = objpersona.Municipio_Antes.Id_Padre
                ddl_departamento_antes_SelectedIndexChanged(Nothing, Nothing)
                ddl_municipio_instituto_antes.SelectedValue = objpersona.Id_Municipio_Instituto_Antes

                ddl_departamento_actual.SelectedValue = objpersona.Municipio_Actual.Id_Padre
                ddl_departamento_actual_SelectedIndexChanged(Nothing, Nothing)
                ddl_municipio_instituto_actual.SelectedValue = objpersona.Id_Municipio_Instituto_Actual

                ddl_Discapacitado_SelectedIndexChanged(Nothing, Nothing)
                ddl_Genero_SelectedIndexChanged(Nothing, Nothing)


                Try
                    lbl_Solicito.Text = objpersona.Solicito_Atencion_Psicologica.Descripcion
                    lbl_Recibio_Atencion.Text = objpersona.Recibio_Atencion_Psicologica.Descripcion
                    Lbl_Afectado_Desplazamiento.Text = objpersona.Afectado_Desplazamiento.Descripcion
                    lbl_Quien_Atendio.Text = objpersona.Quien_Atencion_Psicologica
                Catch ex As Exception

                End Try
            End If
            'txt_Nombre1.Focus()
        Catch ex As Exception

        End Try


    End Sub

    Public Sub subEliminar(ByVal sender As Object, ByVal e As GridCommandEventArgs)

        If Chb_Cerrado.Checked Then
            lblMensaje.Text = "Registro Cerrado. No se puede Modificar.!!!!"
            lblMensaje.Visible = True
            Exit Sub
        End If

        Dim wvar01 As Double
        Dim lblIdInterno As Label
        lblIdInterno = e.Item.FindControl("lblid")
        Dim objpersona As PersonasBrl = PersonasBrl.CargarPorID(lblIdInterno.Text)

        If objpersona Is Nothing Then
            lblMensaje.Text = "Lamentablemente no exite este registro en el sistema. Favor intentarlo nuevamente.!!!!"
            lblMensaje.Visible = True
            Exit Sub
        End If
        Dim wmensaje As String = "Este proceso eliminará el beneficiario del sistema, validará todos los lugares donde puede tener seguimientos y en caso de no tener nada procederá a " &
                                 " eliminarlo. Desea continuar con el borrado del registro # " + lblIdInterno.Text.Trim + " ???? "

        If MsgBox(wmensaje, MsgBoxStyle.YesNo, "Eliminar Beneficiario del Sistema?") = MsgBoxResult.Yes Then
            '
            'Se procede a validar y eliminar la persona
            '
            If objpersona.Personas_Educacion.Count = 1 Then
                If objpersona.Personas_Entregas.Count = 0 Then
                    If objpersona.Salud.Count = 0 Then

                        For Each fila As Personas_Regimen_SaludBrl In objpersona.Personas_Regimen_Salud
                            fila.Eliminar()
                        Next
                        objpersona = PersonasBrl.CargarPorID(lblIdInterno.Text)

                        wvar01 = objpersona.Eliminar()
                        If wvar01 = 0 Then
                            lblMensaje.Text = "Registro Eliminado a Satisfacción. Se procederá a recargar los Beneficiarios."
                            'MsgBox(lblMensaje.Text)
                            cargarbeneficiarios(Nothing, Nothing)
                        Else
                            lblMensaje.Text = "No se puede eliminar el registro porque existen datos que dependen de él. Llamar al administrador para solución del problema."
                            'MsgBox(lblMensaje.Text)
                            lblMensaje.Visible = True
                        End If


                    Else
                        lblMensaje.Text = "Este beneficiario tiene registros de salud enlazados. No es posible eliminarlo !!!!!"
                        'MsgBox(lblMensaje.Text)
                        lblMensaje.Visible = True
                        Exit Sub

                    End If
                Else
                    lblMensaje.Text = "Este beneficiario tiene entregas realizadas. No es posible eliminarlo !!!!!"
                    'MsgBox(lblMensaje.Text)
                    lblMensaje.Visible = True
                    Exit Sub
                End If
            Else
                lblMensaje.Text = "Este beneficiario tiene registros en Educación. No es posible eliminarlo !!!!!"
                'MsgBox(lblMensaje.Text)
                lblMensaje.Visible = True
                Exit Sub
            End If
        Else
            lblMensaje.Text = "Proceso Cancelado por el Usuario !!!!!"
            'MsgBox(lblMensaje.Text)
            lblMensaje.Visible = True
            Exit Sub
        End If

        txt_Nombre1.Focus()
    End Sub

    Protected Sub Lst_Causas_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lst_Causas.SelectedIndexChanged
        Lst_causasDec.Items.Add(New ListItem(Lst_Causas.SelectedItem.Text, Lst_Causas.SelectedItem.Value))
        Lst_Causas.Items.RemoveAt(Lst_Causas.SelectedIndex)
    End Sub

    Protected Sub lst_Danos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lst_Danos.SelectedIndexChanged
        Lst_danosDec.Items.Add(New ListItem(lst_Danos.SelectedItem.Text, lst_Danos.SelectedItem.Value))
        lst_Danos.Items.RemoveAt(lst_Danos.SelectedIndex)
    End Sub

    Protected Sub Lst_causasDec_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lst_causasDec.SelectedIndexChanged
        Lst_Causas.Items.Add(New ListItem(Lst_causasDec.SelectedItem.Text, Lst_causasDec.SelectedItem.Value))
        Lst_causasDec.Items.RemoveAt(Lst_causasDec.SelectedIndex)
    End Sub

    Protected Sub Lst_danosDec_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lst_danosDec.SelectedIndexChanged
        lst_Danos.Items.Add(New ListItem(Lst_danosDec.SelectedItem.Text, Lst_danosDec.SelectedItem.Value))
        Lst_danosDec.Items.RemoveAt(Lst_danosDec.SelectedIndex)
    End Sub

    Protected Sub ddl_Ha_Declarado_Antes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_Ha_Declarado_Antes.SelectedIndexChanged
        If ddl_Ha_Declarado_Antes.SelectedValue = 19 Then
            txt_Lugar_Otro_Desplazamiento.Enabled = True
            rfv_Lugar_Otro_Desplazamiento.Enabled = True
            rdpfechaOtroDesplazamiento.Enabled = True
            rfv_Fecha_Otra_Declaracion.Enabled = True
        Else
            txt_Lugar_Otro_Desplazamiento.Enabled = False
            rfv_Lugar_Otro_Desplazamiento.Enabled = False
            rdpfechaOtroDesplazamiento.Enabled = False
            rfv_Fecha_Otra_Declaracion.Enabled = False
            txt_Lugar_Otro_Desplazamiento.Text = ""
            rdpfechaOtroDesplazamiento.SelectedDate = Nothing
        End If
    End Sub

    Protected Sub ddl_Discapacitado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_Discapacitado.SelectedIndexChanged
        If ddl_Discapacitado.SelectedValue = 19 Then
            ddl_Tipo_Discapacidad.Enabled = True
            rfv_tipodiscapacidad.Enabled = True

        Else
            ddl_Tipo_Discapacidad.Enabled = False
            ddl_Tipo_Discapacidad.SelectedValue = 0
            rfv_tipodiscapacidad.Enabled = False
        End If
    End Sub

    Protected Sub txt_Edad_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_edad.TextChanged
        If (Val(txt_edad.Text.Trim) >= 6) And (Val(txt_edad.Text.Trim) <= 17) Then
            ddl_Sabe_Leer.Enabled = True
            rev_Sabe_Leer.Enabled = True

            ddl_EstudiabaAntes.Enabled = True
            ddl_EstudiabaAntes_SelectedIndexChanged(Nothing, Nothing)
            rev_Estudiaba_Antes.Enabled = True

            ddl_EstudiaActualmente.Enabled = True
            ddl_EstudiaActualmente_SelectedIndexChanged(Nothing, Nothing)
            rev_Estudia_Actualmente.Enabled = True

            ddl_UltimoGrado.Enabled = True
            ddl_certificacion.Enabled = True
            rev_certificacion.Enabled = True
            Ddl_Tipo_Apoyo_Escolar.Enabled = True


        Else
            ddl_Sabe_Leer.Enabled = False
            ddl_Sabe_Leer.SelectedValue = 0
            rev_Sabe_Leer.Enabled = False
            ddl_EstudiabaAntes.Enabled = False
            ddl_EstudiabaAntes.SelectedValue = 0
            ddl_EstudiabaAntes_SelectedIndexChanged(Nothing, Nothing)
            rev_Estudiaba_Antes.Enabled = False
            txt_Institucion_Estudiaba.Enabled = False
            txt_Institucion_Estudiaba.Text = ""
            ddl_EstudiaActualmente.Enabled = False
            ddl_EstudiaActualmente.SelectedValue = 0
            ddl_EstudiaActualmente_SelectedIndexChanged(Nothing, Nothing)
            rev_Estudia_Actualmente.Enabled = False
            ddl_UltimoGrado.Enabled = False
            ddl_UltimoGrado.SelectedValue = 0
            txt_Institucion_Estudia.Enabled = False
            txt_Institucion_Estudia.Text = ""
            ddl_MotivoNoEstudio.SelectedValue = 0
            ddl_MotivoNoEstudio.Enabled = False
            rev_Motivo_NoEstudiar.Enabled = False
            rfv_Institucion_Estudiaba.Enabled = False
            rfv_Institucion_Estudia.Enabled = False
            ddl_lactando.SelectedValue = 0
            ddl_Embarazada.SelectedValue = 0
            ddl_lactando.Enabled = False
            ddl_Embarazada.Enabled = False
            ddl_certificacion.Enabled = False
            rev_certificacion.Enabled = False
            ddl_certificacion.SelectedValue = 0
            ddl_departamento_actual.Enabled = False
            ddl_departamento_actual.SelectedValue = 0
            ddl_departamento_antes.Enabled = False
            ddl_departamento_antes.SelectedValue = 0
            ddl_departamento_actual_SelectedIndexChanged(Nothing, Nothing)
            ddl_departamento_antes_SelectedIndexChanged(Nothing, Nothing)
            ddl_municipio_instituto_antes.Enabled = False
            ddl_municipio_instituto_antes.SelectedValue = 0
            ddl_municipio_instituto_actual.Enabled = False
            ddl_municipio_instituto_actual.SelectedValue = 0
            rev_municipio_actual.Enabled = False
            rev_municipio_antes.Enabled = False
            Ddl_Tipo_Apoyo_Escolar.Enabled = False
            Ddl_Tipo_Apoyo_Escolar.SelectedValue = 0
        End If


        If ddl_Genero.SelectedValue = 5 Then
            If (Val(txt_edad.Text.Trim) >= 12) And (Val(txt_edad.Text.Trim) <= 50) Then
                ddl_lactando.Enabled = True
                ddl_Embarazada.Enabled = True
            Else
                ddl_lactando.SelectedValue = 0
                ddl_Embarazada.SelectedValue = 0
                ddl_lactando.Enabled = False
                ddl_Embarazada.Enabled = False

            End If
        End If

    End Sub

    Protected Sub ddl_Genero_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_Genero.SelectedIndexChanged

        If ddl_Genero.SelectedValue = 5 Then
            If (Val(txt_edad.Text.Trim) >= 13) And (Val(txt_edad.Text.Trim) < 50) Then
                ddl_lactando.Enabled = True
                ddl_Embarazada.Enabled = True
            End If
        Else
            ddl_lactando.Enabled = False
            ddl_lactando.SelectedValue = 0
            ddl_Embarazada.Enabled = False
            ddl_Embarazada.SelectedValue = 0
        End If

    End Sub

    Protected Sub ddl_EstudiaActualmente_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_EstudiaActualmente.SelectedIndexChanged
        If (Val(txt_edad.Text.Trim) >= 6) And (Val(txt_edad.Text.Trim) <= 17) Then

            If ddl_EstudiaActualmente.SelectedValue = 19 Then
                ddl_MotivoNoEstudio.Enabled = False
                rev_Motivo_NoEstudiar.Enabled = False
                ddl_MotivoNoEstudio.SelectedValue = 0

                txt_Institucion_Estudia.Enabled = True
                rfv_Institucion_Estudia.Enabled = True
                ddl_departamento_actual.Enabled = True
                ddl_municipio_instituto_actual.Enabled = True
                rev_municipio_actual.Enabled = True


            Else
                ddl_MotivoNoEstudio.Enabled = True
                rev_Motivo_NoEstudiar.Enabled = True

                txt_Institucion_Estudia.Enabled = False
                txt_Institucion_Estudia.Text = ""
                rfv_Institucion_Estudia.Enabled = False
                ddl_departamento_actual.Enabled = False
                ddl_departamento_actual.SelectedValue = 0
                ddl_departamento_actual_SelectedIndexChanged(Nothing, Nothing)
                ddl_municipio_instituto_actual.Enabled = False
                rev_municipio_actual.Enabled = False
                ddl_municipio_instituto_actual.SelectedValue = 0


            End If
        End If
    End Sub

    Protected Sub Rg_Listado_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles Rg_Listado.ItemDataBound
        If e.Item.ItemType = GridItemType.AlternatingItem Or e.Item.ItemType = GridItemType.Item Then

            If e.Item.Cells(4).Text = "D" Then
                e.Item.Cells(13).Visible = False
            End If
        End If
    End Sub

    Protected Sub ddl_Departamento_Expulsor_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_Departamento_Expulsor.SelectedIndexChanged
        BindHelper.SubTablasUIL.BindToListControlPorId_Padre(ddl_Municipio_Expulsor, ddl_Departamento_Expulsor.SelectedValue, New ListItem("Seleccione", 0))
        If ddl_Departamento_Expulsor.SelectedValue <> 0 Then
            ddl_Municipio_Expulsor.Enabled = True
            rev_MunicipioExpulsor.Enabled = True

        Else
            ddl_Municipio_Expulsor.SelectedValue = 0
            ddl_Municipio_Expulsor.Enabled = False
            rev_MunicipioExpulsor.Enabled = False
        End If

    End Sub

    Protected Sub ddl_Municipio_Expulsor_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_Municipio_Expulsor.SelectedIndexChanged

        If ddl_Municipio_Expulsor.SelectedValue <> 0 Then
            Ddl_Concejo_Expulsor.Enabled = True
            rev_ConcejoExpulsor.Enabled = True
            txt_vereda.Enabled = True
        Else
            Ddl_Concejo_Expulsor.Enabled = False
            rev_ConcejoExpulsor.Enabled = False
            txt_vereda.Enabled = False
            Ddl_Concejo_Expulsor.SelectedValue = 0
        End If
    End Sub

    Protected Sub ddl_Tiempo_Demoro_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_Tiempo_Demoro.SelectedIndexChanged
        If ddl_Tiempo_Demoro.SelectedValue = 696 Then
            rev_PorqueTardo.Enabled = True
            ddl_Motivo_Demora.Enabled = True
        Else
            rev_PorqueTardo.Enabled = False
            ddl_Motivo_Demora.SelectedValue = 0
            ddl_Motivo_Demora.Enabled = False
        End If
    End Sub

    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton1.Click
        If Len(txtvalor.Text) <> 0 Then
            If Lst_Tipos_Contacto.SelectedIndex >= 0 Then
                Lst_Tipos_Contacto_Persona.Items.Add(New ListItem(Lst_Tipos_Contacto.SelectedItem.Text.Trim & " : " & txtvalor.Text.Trim, Lst_Tipos_Contacto.SelectedValue))
                txtvalor.Text = ""
                Lst_Tipos_Contacto.SelectedIndex = -1
                Lst_Tipos_Contacto.ClearSelection()
                lbl_actcontacto.Text = "1"
            End If
        Else
            lblMensaje.Text = "No hay dato de descripción del tipo de contacto"
            lblMensaje.Visible = True
            lblMensaje.ForeColor = Drawing.Color.Red
        End If
    End Sub

    Protected Sub LinkButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton2.Click
        If Lst_Tipos_Contacto_Persona.SelectedIndex >= 0 Then
            ' para retirar un registro de la base de contactos
            Lst_Tipos_Contacto_Persona.Items.RemoveAt(Lst_Tipos_Contacto_Persona.SelectedIndex)
            Lst_Tipos_Contacto_Persona.ClearSelection()
            lbl_actcontacto.Text = "1"
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

    Protected Sub ddl_Solicito_Atencion_Psicologica_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_Solicito_Atencion_Psicologica.SelectedIndexChanged
        'cargarbeneficiarios(Nothing, Nothing)

        Dim chk_sap, chk_rap As CheckBox
        Dim txt_quien As TextBox
        For Each fila As DataGridItem In Dg_Psicosocial.Items
            If fila.ItemType = ListItemType.AlternatingItem Or fila.ItemType = ListItemType.Item Then
                chk_sap = fila.FindControl("chk_sap")
                chk_rap = fila.FindControl("chk_rap")
                txt_quien = fila.FindControl("txt_quien")
                If ddl_Solicito_Atencion_Psicologica.SelectedValue = 19 Then
                    chk_sap.Enabled = True
                    chk_rap.Enabled = True
                    txt_quien.Enabled = True
                Else
                    chk_sap.Enabled = False
                    chk_sap.Checked = False
                    chk_rap.Enabled = False
                    chk_rap.Checked = False
                    txt_quien.Enabled = False
                    txt_quien.Text = ""
                End If
            End If
        Next
    End Sub


    Protected Sub Dg_Emociones_ItemDataBound(ByVal sender As Object, ByVal e As DataGridItemEventArgs) Handles Dg_Emociones.ItemDataBound
        Dim ddl_emociones_usted As DropDownList
        Dim ddl_emociones_familia As DropDownList
        Dim lblid As Label
        If e.Item.ItemType = ListItemType.AlternatingItem Or e.Item.ItemType = ListItemType.Item Then
            lblid = e.Item.FindControl("lblid")
            ddl_emociones_usted = e.Item.FindControl("ddl_emociones_usted")
            ddl_emociones_familia = e.Item.FindControl("ddl_emociones_familia")
            Dim Listemocion As List(Of Declaracion_PsicosocialBrl) = Declaracion_PsicosocialBrl.CargarPorId_Declaracion(Request.QueryString.Item("Id"))
            FilterHelper.FilterHelper(Listemocion, "Id_Emocion", lblid.Text)
            If Listemocion.Count > 0 Then
                ddl_emociones_usted.SelectedValue = Listemocion.Item(0).Dato_Usted
                ddl_emociones_familia.SelectedValue = Listemocion.Item(0).Dato_Familia
            End If
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

    Protected Sub ddl_Tipo_Adiccion_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_Tipo_Adiccion.SelectedIndexChanged
        If ddl_Tipo_Adiccion.SelectedValue = 19 Then
            chk_alcohol.Enabled = True
            chk_droga.Enabled = True
        Else
            chk_alcohol.Enabled = False
            chk_droga.Enabled = False
            chk_alcohol.Checked = False
            chk_droga.Checked = False
        End If
    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/DeclaracionList.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        Response.Redirect("../webforms/PrimeraEncuesta.aspx?Editar=1&Id=" + Request.QueryString.Item("Id"))
    End Sub

    Protected Sub ddl_MotivoNoEstudio_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ddl_MotivoNoEstudio.SelectedIndexChanged
        If (Val(txt_edad.Text.Trim) >= 6) And (Val(txt_edad.Text.Trim) <= 17) Then
            rev_certificacion.Enabled = True
            ddl_certificacion.Enabled = True
            If ddl_MotivoNoEstudio.SelectedValue = 1693 Then ' graduado
                rev_certificacion.Enabled = False
                ddl_certificacion.Enabled = False
            End If
        End If
    End Sub

    Protected Sub btnCerrar_Click(sender As Object, e As System.EventArgs) Handles btnCerrar.Click
        Response.Redirect("../webforms/DeclaracionList.aspx")
    End Sub

    Protected Sub ddl_Familias_Accion_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddl_Familias_Accion.SelectedIndexChanged
        If ddl_Familias_Accion.SelectedValue = 19 Then
            ddl_departamento_faccion.Enabled = True
            ddl_municipio_faccion.Enabled = True
            rev_Municipio_FA.Enabled = True

        Else
            ddl_departamento_faccion.Enabled = False
            ddl_municipio_faccion.Enabled = False
            rev_Municipio_FA.Enabled = False
            ddl_departamento_faccion.SelectedValue = 0
            ddl_departamento_faccion_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Protected Sub Rg_Listado_NeedDataSource(sender As Object, e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Listado.NeedDataSource
        Rg_Listado.DataSource = Session("ListPersonas")
    End Sub

    Protected Sub ddl_departamento_actual_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddl_departamento_actual.SelectedIndexChanged
        BindHelper.SubTablasUIL.BindToListControlPorId_TablaPadre(ddl_municipio_instituto_actual, 15, ddl_departamento_actual.SelectedValue, New ListItem("Seleccione", 0))
    End Sub

    Protected Sub ddl_departamento_antes_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddl_departamento_antes.SelectedIndexChanged
        BindHelper.SubTablasUIL.BindToListControlPorId_TablaPadre(ddl_municipio_instituto_antes, 15, ddl_departamento_antes.SelectedValue, New ListItem("Seleccione", 0))
    End Sub

    Protected Sub ddl_EstudiabaAntes_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddl_EstudiabaAntes.SelectedIndexChanged
        If (Val(txt_edad.Text.Trim) >= 6) And (Val(txt_edad.Text.Trim) <= 17) Then

            If ddl_EstudiabaAntes.SelectedValue = 19 Then
                txt_Institucion_Estudiaba.Enabled = True
                rfv_Institucion_Estudiaba.Enabled = True
                ddl_departamento_antes.Enabled = True
                ddl_municipio_instituto_antes.Enabled = True
                rev_municipio_antes.Enabled = True

            Else
                txt_Institucion_Estudiaba.Enabled = False
                txt_Institucion_Estudiaba.Text = ""
                rfv_Institucion_Estudiaba.Enabled = False
                ddl_departamento_antes.Enabled = False
                ddl_departamento_antes.SelectedValue = 0
                ddl_departamento_antes_SelectedIndexChanged(Nothing, Nothing)
                ddl_municipio_instituto_antes.Enabled = False
                rev_municipio_antes.Enabled = False
                ddl_municipio_instituto_antes.SelectedValue = 0

            End If
        End If
    End Sub

    Protected Sub ddl_departamento_rsa_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddl_departamento_rsa.SelectedIndexChanged
        BindHelper.SubTablasUIL.BindToListControlPorId_TablaPadre(ddl_municipio_rsa, 15, ddl_departamento_rsa.SelectedValue, New ListItem("Seleccione", 0))
    End Sub

    Protected Sub ddl_departamento_rsd_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddl_departamento_rsd.SelectedIndexChanged
        BindHelper.SubTablasUIL.BindToListControlPorId_TablaPadre(ddl_municipio_rsd, 15, ddl_departamento_rsd.SelectedValue, New ListItem("Seleccione", 0))
    End Sub

    Protected Sub ddl_departamento_faccion_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddl_departamento_faccion.SelectedIndexChanged
        BindHelper.SubTablasUIL.BindToListControlPorId_TablaPadre(ddl_municipio_faccion, 15, ddl_departamento_faccion.SelectedValue, New ListItem("Seleccione", 0))
    End Sub

    Protected Sub btn_paari_Click(sender As Object, e As System.EventArgs) Handles btn_paari.Click
        '
        '  Proceso de Calificacion de Alimentacion
        '
        Dim wvalor As Double = 0
        Dim wmultiplo As Double = 0
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

        Dim objdeclaracion As DeclaracionBrl = DeclaracionBrl.CargarPorID(Request.QueryString.Item("Id"))
        wvalor = 0
        Select Case ddl_tipo_vivienda.SelectedValue
            Case 203 ' otro
                'Select Case ddl_ubicacion.SelectedValue
                '    Case 281 'urbano
                wvalor = wvalor + 10
                '    Case 282 ' rural
                'Select Case objdeclaracion.Personas_Declarante.Id_Grupo_Etnico
                '    Case 35 'afro
                '        wvalor = wvalor + 10
                '    Case 36 ' indigena
                '        Select Case ddl_tipo_vivienda_otro.SelectedValue
                '            Case 224
                '                wvalor = wvalor + 0
                '            Case Else
                '                wvalor = wvalor + 10
                '        End Select
                '    Case 277 'Rroom
                '        Select Case ddl_tipo_vivienda_otro.SelectedValue
                '            Case 204, 222
                '                wvalor = wvalor + 0
                '            Case Else
                '                wvalor = wvalor + 10
                '        End Select
                '    Case 37
                '        wvalor = wvalor + 10
                'End Select
                'End Select
        End Select

        If ddl_material_pisos.SelectedValue = 231 Then wvalor = wvalor + 2

        If ddl_material_paredes.SelectedValue = 236 Then
            'If ddl_ubicacion.SelectedValue = 281 Then
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
            ' If ddl_ubicacion.SelectedValue = 281 Then
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
            'If ddl_ubicacion.SelectedValue = 281 Then
            wvalor += 2
            'End If
        End If

        If ddl_alcantarillado.SelectedValue = 20 Then
            ' If ddl_ubicacion.SelectedValue = 281 Then
            wvalor += 1
            'End If
        End If

        'If ddl_alcantarillado.SelectedValue = 20 Then
        '    If ddl_ubicacion.SelectedValue = 282 Then
        '        Select Case ddl_servicio_sanitario.SelectedValue
        '            Case 254, 255, 256, 257
        '                wvalor += 1
        '        End Select
        '    End If
        'End If

        'If ddl_acueducto.SelectedValue = 20 Then
        '    If ddl_ubicacion.SelectedValue = 282 Then
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
