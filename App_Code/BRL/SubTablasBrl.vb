Imports ingNovar.Utilidades2
Imports System.Data
Imports System.Collections.Generic
Imports SeguridadUsuarios


Partial Public Class SubTablasBrl

    Private _Id As Int32
    Private _Id_Tabla As Int32
    Private _Descripcion As String
    Private _Id_Padre As Int32
    Private _Fecha_Creacion As DateTime
    Private _Id_Usuario_Creacion As Int32
    Private _Fecha_Modificacion As DateTime
    Private _Id_Usuario_Modificacion As Int32
    Private _orden As Integer
    Private _Activo As Int32


    Private objListDeclaracion_Ayudas_Dadas As List(Of Declaracion_Ayudas_DadasBrl)
    Private objListDeclaracion_Entidades_Ayuda As List(Of Declaracion_Entidades_AyudaBrl)
    Private objListDeclaracion_Fuentes_Ingreso As List(Of Declaracion_Fuentes_IngresoBrl)
    Private objListDeclaracion_Obtencion_Agua As List(Of Declaracion_Obtencion_AguaBrl)
    Private objListDeclaracionFuente As List(Of DeclaracionBrl)
    Private objListDeclaracionMunicipioExpulsor As List(Of DeclaracionBrl)
    Private objListDeclaracionHa_Recibido_Ayuda As List(Of DeclaracionBrl)
    Private objListDeclaracionParentescoMuerte As List(Of DeclaracionBrl)
    Private objListDeclaracionHa_Muerto_Alguien As List(Of DeclaracionBrl)
    Private objListDeclaracionVelar_Enterrar As List(Of DeclaracionBrl)
    Private objListDeclaracionEnfermedad As List(Of DeclaracionBrl)
    Private objListDeclaracionLlegada_Sexual_Miembro As List(Of DeclaracionBrl)
    Private objListDeclaracionHa_Regresado As List(Of DeclaracionBrl)
    Private objListDeclaracionAplico_Reparaciones As List(Of DeclaracionBrl)
    Private objListDeclaracionLlegada_Sexual As List(Of DeclaracionBrl)
    Private objListDeclaracionLlegada_Insultos_Usted As List(Of DeclaracionBrl)
    Private objListDeclaracionRegimen_Salud As List(Of DeclaracionBrl)
    Private objListDeclaracionRazon_No_Aplico As List(Of DeclaracionBrl)
    Private objListDeclaracionMotivo_Muerte As List(Of DeclaracionBrl)
    Private objListDeclaracionLlegada_Golpes As List(Of DeclaracionBrl)
    Private objListDeclaracionEstado_Aplicacion As List(Of DeclaracionBrl)
    Private objListDeclaracionLlegada_golpes_Miembro As List(Of DeclaracionBrl)
    Private objListDeclaracionParentesco_Desaparecido As List(Of DeclaracionBrl)
    Private objListDeclaracionTiene_Desaparecido As List(Of DeclaracionBrl)
    Private objListDeclaracionReporto As List(Of DeclaracionBrl)
    Private objListDeclaracionHa_Redibido_Ayuda_Despues As List(Of DeclaracionBrl)
    Private objListDeclaracionLlegada_Sexual_Usted As List(Of DeclaracionBrl)
    Private objListDeclaracionMotivo_No_Aplico As List(Of DeclaracionBrl)
    Private objListDeclaracionLlegada_Golpes_Usted As List(Of DeclaracionBrl)
    Private objListDeclaracionOido_Mesa_Desplazados As List(Of DeclaracionBrl)
    Private objListDeclaracionLlegada_Insultos As List(Of DeclaracionBrl)
    Private objListDeclaracionEstatus_Aplicacion_Despues As List(Of DeclaracionBrl)
    Private objListDeclaracionPertenece_Asociacion As List(Of DeclaracionBrl)
    Private objListDeclaracionRetornaria As List(Of DeclaracionBrl)
    Private objListDeclaracionEsta_Trabajando As List(Of DeclaracionBrl)
    Private objListDeclaracionEntidad_Legal As List(Of DeclaracionBrl)
    Private objListDeclaracionExplicacion_Retorno As List(Of DeclaracionBrl)
    Private objListDeclaracionHa_Declarado_Antes As List(Of DeclaracionBrl)
    Private objListDeclaracionLlegada_Insultos_Miembro As List(Of DeclaracionBrl)
    Private objListDeclaracion_Trabajos As List(Of Declaracion_TrabajosBrl)
    Private objListEntradas_Detalle As List(Of Entradas_DetalleBrl)
    Private objListEntradas As List(Of EntradasBrl)
    Private objListPersonas_Contactos As List(Of Personas_ContactosBrl)

    Private objListPersonasMotivo_NoEstudio As List(Of PersonasBrl)
    Private objListPersonasTipo_Identificacion As List(Of PersonasBrl)
    Private objListPersonasDiscapacitado As List(Of PersonasBrl)
    Private objListPersonasGenero As List(Of PersonasBrl)
    Private objListPersonasJefe_Hogar As List(Of PersonasBrl)
    Private objListPersonasParentesco As List(Of PersonasBrl)
    Private objListPersonasEstudia_Actualmente As List(Of PersonasBrl)
    Private objListPersonasEstudia_Antes As List(Of PersonasBrl)
    Private objListPersonasUltimo_Grado As List(Of PersonasBrl)

    Private objListSalidas_TipoSalida As List(Of SalidasBrl)
    Private objListSalidas_TipoEntrega As List(Of SalidasBrl)
    Private objListSalidas_RegGrupo As List(Of SalidasBrl)
    Private objListSalidas_Detalle As List(Of Salidas_DetalleBrl)

    Private objListDeclaracion_grupos As List(Of DeclaracionBrl)
    Private objListDeclaracionBeneficiadoProgramas As List(Of DeclaracionBrl)
    Private objListDeclaracionEstado_AccionSocial As List(Of DeclaracionBrl)
    Private objListDeclaracionAtender As List(Of DeclaracionBrl)
    Private objListDeclaracionMotivo_Noatender As List(Of DeclaracionBrl)
    Private objListDeclaracionEps As List(Of DeclaracionBrl)
    Private objListDeclaracion_Programas_Ayuda As List(Of Declaracion_Programas_AyudaBrl)
    Private objListGestantesControl_Prenatal As List(Of GestantesBrl)
    Private objListGestantesIngesta_Micronutrientes As List(Of GestantesBrl)
    Private objListGestantesRemitidas As List(Of GestantesBrl)
    Private objListGestantesVisita_Domiciliaria As List(Of GestantesBrl)
    Private objListSalud_Remisiones As List(Of Salud_RemisionesBrl)
    Private objListSaludCrecimiento_Desarrollo As List(Of SaludBrl)
    Private objListSaludLactancia_Lactando As List(Of SaludBrl)
    Private objListSaludMotivo_No_Vacunados As List(Of SaludBrl)
    Private objListSaludVitaminas_Desparasitacion As List(Of SaludBrl)
    Private objListSaludVitaminas_Suplementacion As List(Of SaludBrl)
    Private objListSaludVacunacion_Carnet As List(Of SaludBrl)
    Private objListSaludRazon_No_Carnet As List(Of SaludBrl)
    Private objListSaludEsquema_Vacunacion_Completo As List(Of SaludBrl)
    Private objListSaludRazon_No_Vacunacion_Completo As List(Of SaludBrl)
    Private objListSaludNinos_Vacunados As List(Of SaludBrl)

    Private objListSalud_ValoracionTalla_Edad As List(Of Salud_ValoracionBrl)
    Private objListSalud_ValoracionRecuperado As List(Of Salud_ValoracionBrl)


    Private objListDeclaracion_Bienes As List(Of Declaracion_BienesBrl)
    Private objListDeclaracion_Causas_Desplazamiento As List(Of Declaracion_Causas_DesplazamientoBrl)
    Private objListDeclaracion_Causas_NoEstudio As List(Of Declaracion_Causas_NoEstudioBrl)
    Private objListDeclaracionComo_Brindar_Atencion As List(Of DeclaracionBrl)
    Private objListDeclaracionComo_Fue_Atencion As List(Of DeclaracionBrl)
    Private objListDeclaracionCuantas_Habitaciones As List(Of DeclaracionBrl)
    Private objListDeclaracionCuantas_Personas_Habitacion As List(Of DeclaracionBrl)
    Private objListDeclaracionCuantas_Personas_Vivienda As List(Of DeclaracionBrl)
    Private objListDeclaracionCuanto_Tiempo_Demoro As List(Of DeclaracionBrl)
    Private objListDeclaracionCuantos_Desplazamientos As List(Of DeclaracionBrl)
    Private objListDeclaracion_Danos_Familia As List(Of Declaracion_Danos_FamiliaBrl)
    Private objListDeclaracionDepartamento_Expulsor As List(Of DeclaracionBrl)
    Private objListDeclaracionDespues_Hijos_617 As List(Of DeclaracionBrl)
    Private objListDeclaracionEntidad_Inicial_Atencion As List(Of DeclaracionBrl)
    Private objListDeclaracionForma_Declaracion As List(Of DeclaracionBrl)
    Private objListDeclaracion_Instituciones_Confianza As List(Of Declaracion_Instituciones_ConfianzaBrl)
    Private objListDeclaracionMateriales_Vivienda As List(Of DeclaracionBrl)
    Private objListDeclaracionMotivo_Demora As List(Of DeclaracionBrl)
    Private objListDeclaracionMotivo_Desplazamiento As List(Of DeclaracionBrl)
    Private objListDeclaracionMotivo_NoDeclaro_Municipio As List(Of DeclaracionBrl)
    Private objListDeclaracion_Nivel_Educativo As List(Of Declaracion_Nivel_EducativoBrl)
    Private objListDeclaracionPorque_No_Reporto As List(Of DeclaracionBrl)
    Private objListDeclaracionRecibio_Ayuda_Entidad_Inicial As List(Of DeclaracionBrl)
    Private objListDeclaracion_Servicio_salud As List(Of Declaracion_Servicio_saludBrl)
    Private objListDeclaracionTiempo_Casco_Urbano As List(Of DeclaracionBrl)
    Private objListDeclaracionTipo_Tenencia_Vivienda As List(Of DeclaracionBrl)
    Private objListDeclaracionVivio_Cabezera_Municipal As List(Of DeclaracionBrl)
    Private objListPersonasCausas_Discapacidad As List(Of PersonasBrl)
    Private objListPersonasEmbarazada As List(Of PersonasBrl)
    Private objListPersonasEPS As List(Of Personas_Regimen_SaludBrl)
    Private objListPersonasGrupo_Etnico As List(Of PersonasBrl)
    Private objListPersonasLactando As List(Of PersonasBrl)
    Private objListPersonasPaga_matricula As List(Of PersonasBrl)
    Private objListPersonasProblemas_Establecimiento As List(Of PersonasBrl)
    Private objListPersonasRecibio_Atencion_psicologica As List(Of PersonasBrl)
    Private objListPersonasRecibio_Tratamiento As List(Of PersonasBrl)
    Private objListPersonasRegimen_Salud As List(Of Personas_Regimen_SaludBrl)
    Private objListPersonasSabe_Leer_escribir As List(Of PersonasBrl)
    Private objListPersonasSolicito_Atencion_Psicologica As List(Of PersonasBrl)
    Private objListPersonasTipo_Apoyo_educativo As List(Of PersonasBrl)
    Private objListPersonasTipo_Discapacidad As List(Of PersonasBrl)
    Private objListDeclaracionDespues_Afiliado_Regimen_Contributivo As List(Of DeclaracionBrl)
    Private objListDeclaracionDespues_Afiliado_Regimen_Subsidiado As List(Of DeclaracionBrl)
    Private objListDeclaracionDespues_Afiliado_Sisben As List(Of DeclaracionBrl)
    Private objListDeclaracionDestino_Tierra As List(Of DeclaracionBrl)
    Private objListDeclaracionDocumento_Propiedad As List(Of DeclaracionBrl)
    Private objListDeclaracionSituacion_Actual_Tierras As List(Of DeclaracionBrl)
    Private objListDeclaracionTipo_bien_rural As List(Of DeclaracionBrl)
    Private objListPersonasCabeza_hogar As List(Of PersonasBrl)

    Private objListDeclaracionBeneficiado_Programas As List(Of DeclaracionBrl)
    Private objListDeclaracionTipo_Familia_desplazada As List(Of DeclaracionBrl)
    Private objListDeclaracionVulnerables_NoDesplazada As List(Of DeclaracionBrl)
    Private objListDeclaracionVulnerabilidad As List(Of Declaracion_VulnerabilidadBrl)

    '' ''Private objListPersonasIndicadores As List(Of PersonasBrl)

    Private objListPersonas_Educacion_Certificado_Matricula As List(Of Personas_EducacionBrl)
    Private objListPersonas_Educacion_Estudia_Actualmente As List(Of Personas_EducacionBrl)
    Private objListPersonas_Educacion_grado_escolar As List(Of Personas_EducacionBrl)
    Private objListPersonas_Educacion_Motivo_NoEstudia As List(Of Personas_EducacionBrl)
    Private objListPersonas_Educacion_Seguimiento As List(Of Personas_EducacionBrl)

    ' Unidades

    Private objListDeclaracion_UnidadesUnidad As List(Of Declaracion_UnidadesBrl)
    Private objListDeclaracion_UnidadesEstadoUnidad As List(Of Declaracion_UnidadesBrl)
    Private objListDeclaracion_UnidadesIncluido As List(Of Declaracion_UnidadesBrl)
    Private objListTrimestral_Grupos As List(Of Trimestral_GruposBrl)

    Private objListDeclaracionSolicitoAyuda As List(Of DeclaracionBrl)
    Private objListDeclaracionConcejoExpulsor As List(Of DeclaracionBrl)
    Private objListDeclaracionLugarFuente As List(Of DeclaracionBrl)
    Private objListDeclaracionEnLinea As List(Of DeclaracionBrl)

	Public Event Creating()
    Public Event Created()
    
    Public Sub New()
        RaiseEvent Creating()
        'Adicionar código al costructor aquí
        
        RaiseEvent Created()        
    End Sub
    Public Event IDChanging(ByVal Value As Int32)
    Public Event IDChanged()
	
    Public Property ID() As Int32
        Get
            Return Me._Id
        End Get
        Set(ByVal Value As Int32)
            If _Id <> Value Then
                RaiseEvent IDChanging(Value)
				Me._Id = Value
                RaiseEvent IDChanged()
            End If
        End Set
    End Property

    Public Event Id_TablaChanging(ByVal Value As Int32)
    Public Event Id_TablaChanged()
	
    Public Property Id_Tabla() As Int32
        Get
            Return Me._Id_Tabla
        End Get
        Set(ByVal Value As Int32)
            If _Id_Tabla <> Value Then
                RaiseEvent Id_TablaChanging(Value)
				Me._Id_Tabla = Value
                RaiseEvent Id_TablaChanged()
            End If
        End Set
    End Property

    Public Event DescripcionChanging(ByVal Value As String)
    Public Event DescripcionChanged()
	
    Public Property Descripcion() As String
        Get
            Return Me._Descripcion
        End Get
        Set(ByVal Value As String)
            If _Descripcion <> Value Then
                RaiseEvent DescripcionChanging(Value)
				Me._Descripcion = Value
                RaiseEvent DescripcionChanged()
            End If
        End Set
    End Property

    Public Event Id_PadreChanging(ByVal Value As Int32)
    Public Event Id_PadreChanged()

    Public Property Id_Padre() As Int32
        Get
            Return Me._Id_Padre
        End Get
        Set(ByVal Value As Int32)
            If _Id_Padre <> Value Then
                RaiseEvent Id_PadreChanging(Value)
                Me._Id_Padre = Value
                RaiseEvent Id_PadreChanged()
            End If
        End Set
    End Property

    Public Event Fecha_CreacionChanging(ByVal Value As DateTime)
    Public Event Fecha_CreacionChanged()

    Public Property Fecha_Creacion() As DateTime
        Get
            Return Me._Fecha_Creacion
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_Creacion <> Value Then
                RaiseEvent Fecha_CreacionChanging(Value)
                Me._Fecha_Creacion = Value
                RaiseEvent Fecha_CreacionChanged()
            End If
        End Set
    End Property

    Public Event Id_Usuario_CreacionChanging(ByVal Value As Int32)
    Public Event Id_Usuario_CreacionChanged()

    Public Property Id_Usuario_Creacion() As Int32
        Get
            Return Me._Id_Usuario_Creacion
        End Get
        Set(ByVal Value As Int32)
            If _Id_Usuario_Creacion <> Value Then
                RaiseEvent Id_Usuario_CreacionChanging(Value)
                Me._Id_Usuario_Creacion = Value
                RaiseEvent Id_Usuario_CreacionChanged()
            End If
        End Set
    End Property

    Public Event Fecha_ModificacionChanging(ByVal Value As DateTime)
    Public Event Fecha_ModificacionChanged()

    Public Property Fecha_Modificacion() As DateTime
        Get
            Return Me._Fecha_Modificacion
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_Modificacion <> Value Then
                RaiseEvent Fecha_ModificacionChanging(Value)
                Me._Fecha_Modificacion = Value
                RaiseEvent Fecha_ModificacionChanged()
            End If
        End Set
    End Property

    Public Event Id_Usuario_ModificacionChanging(ByVal Value As Int32)
    Public Event Id_Usuario_ModificacionChanged()

    Public Property Id_Usuario_Modificacion() As Int32
        Get
            Return Me._Id_Usuario_Modificacion
        End Get
        Set(ByVal Value As Int32)
            If _Id_Usuario_Modificacion <> Value Then
                RaiseEvent Id_Usuario_ModificacionChanging(Value)
                Me._Id_Usuario_Modificacion = Value
                RaiseEvent Id_Usuario_ModificacionChanged()
            End If
        End Set
    End Property

    Public Event OrdenChanging(ByVal Value As Int32)
    Public Event OrdenChanged()

    Public Property Orden() As Int32
        Get
            Return Me._orden
        End Get
        Set(ByVal Value As Int32)
            If _orden <> Value Then
                RaiseEvent OrdenChanging(Value)
                Me._orden = Value
                RaiseEvent OrdenChanged()
            End If
        End Set
    End Property

    Public Event ActivoChanging(ByVal Value As Int32)
    Public Event ActivoChanged()

    Public Property Activo() As Int32
        Get
            Return Me._Activo
        End Get
        Set(ByVal Value As Int32)
            If _Activo <> Value Then
                RaiseEvent ActivoChanging(Value)
                Me._Activo = Value
                RaiseEvent ActivoChanged()
            End If
        End Set
    End Property

    Public Property Declaracion_Ayudas_Dadas() As List(Of Declaracion_Ayudas_DadasBrl)
        Get
            If (Me.objListDeclaracion_Ayudas_Dadas Is Nothing) Then
                objListDeclaracion_Ayudas_Dadas = Declaracion_Ayudas_DadasBrl.CargarPorId_Tipo_Ayuda(Me.ID)
            End If
            Return Me.objListDeclaracion_Ayudas_Dadas
        End Get
        Set(ByVal Value As List(Of Declaracion_Ayudas_DadasBrl))
            Me.objListDeclaracion_Ayudas_Dadas = Value
        End Set
    End Property

    Public Property Declaracion_Entidades_Ayuda() As List(Of Declaracion_Entidades_AyudaBrl)
        Get
            If (Me.objListDeclaracion_Entidades_Ayuda Is Nothing) Then
                objListDeclaracion_Entidades_Ayuda = Declaracion_Entidades_AyudaBrl.CargarPorId_Entidad_Ayuda(Me.ID)
            End If
            Return Me.objListDeclaracion_Entidades_Ayuda
        End Get
        Set(ByVal Value As List(Of Declaracion_Entidades_AyudaBrl))
            Me.objListDeclaracion_Entidades_Ayuda = Value
        End Set
    End Property

    Public Property Declaracion_Fuentes_Ingreso() As List(Of Declaracion_Fuentes_IngresoBrl)
        Get
            If (Me.objListDeclaracion_Fuentes_Ingreso Is Nothing) Then
                objListDeclaracion_Fuentes_Ingreso = Declaracion_Fuentes_IngresoBrl.CargarPorId_Fuentes_Ingreso(Me.ID)
            End If
            Return Me.objListDeclaracion_Fuentes_Ingreso
        End Get
        Set(ByVal Value As List(Of Declaracion_Fuentes_IngresoBrl))
            Me.objListDeclaracion_Fuentes_Ingreso = Value
        End Set
    End Property

    Public Property Declaracion_Obtencion_Agua() As List(Of Declaracion_Obtencion_AguaBrl)
        Get
            If (Me.objListDeclaracion_Obtencion_Agua Is Nothing) Then
                objListDeclaracion_Obtencion_Agua = Declaracion_Obtencion_AguaBrl.CargarPorId_Lugar_Agua(Me.ID)
            End If
            Return Me.objListDeclaracion_Obtencion_Agua
        End Get
        Set(ByVal Value As List(Of Declaracion_Obtencion_AguaBrl))
            Me.objListDeclaracion_Obtencion_Agua = Value
        End Set
    End Property

    Public Property DeclaracionFuente() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionFuente Is Nothing) Then
                objListDeclaracionFuente = DeclaracionBrl.CargarPorId_Fuente(Me.ID)
            End If
            Return Me.objListDeclaracionFuente
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionFuente = Value
        End Set
    End Property

    Public Property DeclaracionMunicipioExpulsor() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionMunicipioExpulsor Is Nothing) Then
                objListDeclaracionMunicipioExpulsor = DeclaracionBrl.CargarPorId_Municipio_Expulsor(Me.ID)
            End If
            Return Me.objListDeclaracionMunicipioExpulsor
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionMunicipioExpulsor = Value
        End Set
    End Property

    Public Property DeclaracionHa_Recibido_Ayuda() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionHa_Recibido_Ayuda Is Nothing) Then
                objListDeclaracionHa_Recibido_Ayuda = DeclaracionBrl.CargarPorId_Ha_Recibido_Ayuda(Me.ID)
            End If
            Return Me.objListDeclaracionHa_Recibido_Ayuda
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionHa_Recibido_Ayuda = Value
        End Set
    End Property

    Public Property DeclaracionHa_Muerto_Alguien() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionHa_Muerto_Alguien Is Nothing) Then
                objListDeclaracionHa_Muerto_Alguien = DeclaracionBrl.CargarPorId_Ha_Muerto_Alguien(Me.ID)
            End If
            Return Me.objListDeclaracionHa_Muerto_Alguien
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionHa_Muerto_Alguien = Value
        End Set
    End Property

    Public Property DeclaracionMotivo_Muerte() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionMotivo_Muerte Is Nothing) Then
                objListDeclaracionMotivo_Muerte = DeclaracionBrl.CargarPorId_Motivo_Muerte(Me.ID)
            End If
            Return Me.objListDeclaracionMotivo_Muerte
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionMotivo_Muerte = Value
        End Set
    End Property

    Public Property DeclaracionParentescoMuerte() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionParentescoMuerte Is Nothing) Then
                objListDeclaracionParentescoMuerte = DeclaracionBrl.CargarPorId_Parentesco_Muerte(Me.ID)
            End If
            Return Me.objListDeclaracionParentescoMuerte
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionParentescoMuerte = Value
        End Set
    End Property

    Public Property DeclaracionEnfermedad() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionEnfermedad Is Nothing) Then
                objListDeclaracionEnfermedad = DeclaracionBrl.CargarPorId_Enfermedad(Me.ID)
            End If
            Return Me.objListDeclaracionEnfermedad
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionEnfermedad = Value
        End Set
    End Property

    Public Property DeclaracionVelar_Enterrar() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionVelar_Enterrar Is Nothing) Then
                objListDeclaracionVelar_Enterrar = DeclaracionBrl.CargarPorId_Velar_Enterrar(Me.ID)
            End If
            Return Me.objListDeclaracionVelar_Enterrar
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionVelar_Enterrar = Value
        End Set
    End Property

    Public Property DeclaracionTiene_Desaparecido() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionTiene_Desaparecido Is Nothing) Then
                objListDeclaracionTiene_Desaparecido = DeclaracionBrl.CargarPorId_Tiene_Desaparecido(Me.ID)
            End If
            Return Me.objListDeclaracionTiene_Desaparecido
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionTiene_Desaparecido = Value
        End Set
    End Property

    Public Property DeclaracionParentesco_Desaparecido() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionParentesco_Desaparecido Is Nothing) Then
                objListDeclaracionParentesco_Desaparecido = DeclaracionBrl.CargarPorId_Parentesco_Desaparecido(Me.ID)
            End If
            Return Me.objListDeclaracionParentesco_Desaparecido
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionParentesco_Desaparecido = Value
        End Set
    End Property

    Public Property DeclaracionReporto() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionReporto Is Nothing) Then
                objListDeclaracionReporto = DeclaracionBrl.CargarPorId_Reporto(Me.ID)
            End If
            Return Me.objListDeclaracionReporto
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionReporto = Value
        End Set
    End Property

    Public Property DeclaracionEntidad_Legal() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionEntidad_Legal Is Nothing) Then
                objListDeclaracionEntidad_Legal = DeclaracionBrl.CargarPorId_Entidad_Legal(Me.ID)
            End If
            Return Me.objListDeclaracionEntidad_Legal
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionEntidad_Legal = Value
        End Set
    End Property

    Public Property DeclaracionAplico_Reparaciones() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionAplico_Reparaciones Is Nothing) Then
                objListDeclaracionAplico_Reparaciones = DeclaracionBrl.CargarPorId_Aplico_Reparaciones(Me.ID)
            End If
            Return Me.objListDeclaracionAplico_Reparaciones
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionAplico_Reparaciones = Value
        End Set
    End Property

    Public Property DeclaracionEstado_Aplicacion() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionEstado_Aplicacion Is Nothing) Then
                objListDeclaracionEstado_Aplicacion = DeclaracionBrl.CargarPorId_Estado_Aplicacion(Me.ID)
            End If
            Return Me.objListDeclaracionEstado_Aplicacion
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionEstado_Aplicacion = Value
        End Set
    End Property

    Public Property DeclaracionMotivo_No_Aplico() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionMotivo_No_Aplico Is Nothing) Then
                objListDeclaracionMotivo_No_Aplico = DeclaracionBrl.CargarPorId_Motivo_No_Aplico(Me.ID)
            End If
            Return Me.objListDeclaracionMotivo_No_Aplico
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionMotivo_No_Aplico = Value
        End Set
    End Property

    Public Property DeclaracionLlegada_Insultos() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionLlegada_Insultos Is Nothing) Then
                objListDeclaracionLlegada_Insultos = DeclaracionBrl.CargarPorId_Llegada_Insultos(Me.ID)
            End If
            Return Me.objListDeclaracionLlegada_Insultos
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionLlegada_Insultos = Value
        End Set
    End Property

    Public Property DeclaracionLlegada_Insultos_Usted() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionLlegada_Insultos_Usted Is Nothing) Then
                objListDeclaracionLlegada_Insultos_Usted = DeclaracionBrl.CargarPorId_Llegada_Insultos_Usted(Me.ID)
            End If
            Return Me.objListDeclaracionLlegada_Insultos_Usted
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionLlegada_Insultos_Usted = Value
        End Set
    End Property

    Public Property DeclaracionLlegada_Insultos_Miembro() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionLlegada_Insultos_Miembro Is Nothing) Then
                objListDeclaracionLlegada_Insultos_Miembro = DeclaracionBrl.CargarPorId_Llegada_Insultos_Miembro(Me.ID)
            End If
            Return Me.objListDeclaracionLlegada_Insultos_Miembro
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionLlegada_Insultos_Miembro = Value
        End Set
    End Property


    Public Property DeclaracionLlegada_Sexual() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionLlegada_Sexual Is Nothing) Then
                objListDeclaracionLlegada_Sexual = DeclaracionBrl.CargarPorId_Llegada_Sexual(Me.ID)
            End If
            Return Me.objListDeclaracionLlegada_Sexual
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionLlegada_Sexual = Value
        End Set
    End Property

    Public Property DeclaracionLlegada_Sexual_Usted() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionLlegada_Sexual_Usted Is Nothing) Then
                objListDeclaracionLlegada_Sexual_Usted = DeclaracionBrl.CargarPorId_Llegada_Sexual_Usted(Me.ID)
            End If
            Return Me.objListDeclaracionLlegada_Sexual_Usted
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionLlegada_Sexual_Usted = Value
        End Set
    End Property

    Public Property DeclaracionLlegada_Sexual_Miembro() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionLlegada_Sexual_Miembro Is Nothing) Then
                objListDeclaracionLlegada_Sexual_Miembro = DeclaracionBrl.CargarPorId_Llegada_Sexual_Miembro(Me.ID)
            End If
            Return Me.objListDeclaracionLlegada_Sexual_Miembro
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionLlegada_Sexual_Miembro = Value
        End Set
    End Property

    Public Property DeclaracionLlegada_Golpes() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionLlegada_Golpes Is Nothing) Then
                objListDeclaracionLlegada_Golpes = DeclaracionBrl.CargarPorId_Llegada_Golpes(Me.ID)
            End If
            Return Me.objListDeclaracionLlegada_Golpes
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionLlegada_Golpes = Value
        End Set
    End Property

    Public Property DeclaracionLlegada_Golpes_Usted() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionLlegada_Golpes_Usted Is Nothing) Then
                objListDeclaracionLlegada_Golpes_Usted = DeclaracionBrl.CargarPorId_Llegada_Golpes_Usted(Me.ID)
            End If
            Return Me.objListDeclaracionLlegada_Golpes_Usted
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionLlegada_Golpes_Usted = Value
        End Set
    End Property

    Public Property DeclaracionLlegada_golpes_Miembro() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionLlegada_golpes_Miembro Is Nothing) Then
                objListDeclaracionLlegada_golpes_Miembro = DeclaracionBrl.CargarPorId_Llegada_Golpes_Miembro(Me.ID)
            End If
            Return Me.objListDeclaracionLlegada_golpes_Miembro
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionLlegada_golpes_Miembro = Value
        End Set
    End Property

    Public Property DeclaracionHa_Redibido_Ayuda_Despues() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionHa_Redibido_Ayuda_Despues Is Nothing) Then
                objListDeclaracionHa_Redibido_Ayuda_Despues = DeclaracionBrl.CargarPorId_Ha_Redibido_Ayuda_Despues(Me.ID)
            End If
            Return Me.objListDeclaracionHa_Redibido_Ayuda_Despues
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionHa_Redibido_Ayuda_Despues = Value
        End Set
    End Property

    Public Property DeclaracionEstatus_Aplicacion_Despues() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionEstatus_Aplicacion_Despues Is Nothing) Then
                objListDeclaracionEstatus_Aplicacion_Despues = DeclaracionBrl.CargarPorId_Estatus_Aplicacion_Despues(Me.ID)
            End If
            Return Me.objListDeclaracionEstatus_Aplicacion_Despues
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionEstatus_Aplicacion_Despues = Value
        End Set
    End Property

    Public Property DeclaracionRazon_No_Aplico() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionRazon_No_Aplico Is Nothing) Then
                objListDeclaracionRazon_No_Aplico = DeclaracionBrl.CargarPorId_Razon_No_Aplico(Me.ID)
            End If
            Return Me.objListDeclaracionRazon_No_Aplico
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionRazon_No_Aplico = Value
        End Set
    End Property

    Public Property DeclaracionOido_Mesa_Desplazados() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionOido_Mesa_Desplazados Is Nothing) Then
                objListDeclaracionOido_Mesa_Desplazados = DeclaracionBrl.CargarPorId_Oido_Mesa_Desplazados(Me.ID)
            End If
            Return Me.objListDeclaracionOido_Mesa_Desplazados
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionOido_Mesa_Desplazados = Value
        End Set
    End Property

    Public Property DeclaracionPertenece_Asociacion() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionPertenece_Asociacion Is Nothing) Then
                objListDeclaracionPertenece_Asociacion = DeclaracionBrl.CargarPorId_Pertenece_Asociacion(Me.ID)
            End If
            Return Me.objListDeclaracionPertenece_Asociacion
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionPertenece_Asociacion = Value
        End Set
    End Property

    Public Property DeclaracionEsta_Trabajando() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionEsta_Trabajando Is Nothing) Then
                objListDeclaracionEsta_Trabajando = DeclaracionBrl.CargarPorId_Esta_Trabajando(Me.ID)
            End If
            Return Me.objListDeclaracionEsta_Trabajando
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionEsta_Trabajando = Value
        End Set
    End Property

    Public Property DeclaracionHa_Regresado() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionHa_Regresado Is Nothing) Then
                objListDeclaracionHa_Regresado = DeclaracionBrl.CargarPorId_Ha_Regresado(Me.ID)
            End If
            Return Me.objListDeclaracionHa_Regresado
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionHa_Regresado = Value
        End Set
    End Property

    Public Property DeclaracionRetornaria() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionRetornaria Is Nothing) Then
                objListDeclaracionRetornaria = DeclaracionBrl.CargarPorId_Retornaria(Me.ID)
            End If
            Return Me.objListDeclaracionRetornaria
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionRetornaria = Value
        End Set
    End Property

    Public Property DeclaracionExplicacion_Retorno() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionExplicacion_Retorno Is Nothing) Then
                objListDeclaracionExplicacion_Retorno = DeclaracionBrl.CargarPorId_Explicacion_Retorno(Me.ID)
            End If
            Return Me.objListDeclaracionExplicacion_Retorno
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionExplicacion_Retorno = Value
        End Set
    End Property

    Public Property DeclaracionHa_Declarado_Antes() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionHa_Declarado_Antes Is Nothing) Then
                objListDeclaracionHa_Declarado_Antes = DeclaracionBrl.CargarPorId_Ha_Declarado_Antes(Me.ID)
            End If
            Return Me.objListDeclaracionHa_Declarado_Antes
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionHa_Declarado_Antes = Value
        End Set
    End Property

    Public Property Declaracion_Trabajos() As List(Of Declaracion_TrabajosBrl)
        Get
            If (Me.objListDeclaracion_Trabajos Is Nothing) Then
                objListDeclaracion_Trabajos = Declaracion_TrabajosBrl.CargarPorId_Tipo_Trabajo(Me.ID)
            End If
            Return Me.objListDeclaracion_Trabajos
        End Get
        Set(ByVal Value As List(Of Declaracion_TrabajosBrl))
            Me.objListDeclaracion_Trabajos = Value
        End Set
    End Property

    Public Property Entradas() As List(Of EntradasBrl)
        Get
            If (Me.objListEntradas Is Nothing) Then
                objListEntradas = EntradasBrl.CargarPorId_Tipo_Entrada(Me.ID)
            End If
            Return Me.objListEntradas
        End Get
        Set(ByVal Value As List(Of EntradasBrl))
            Me.objListEntradas = Value
        End Set
    End Property

    Public Property Entradas_Detalle_Capacidad() As List(Of Entradas_DetalleBrl)
        Get
            If (Me.objListEntradas_Detalle Is Nothing) Then
                objListEntradas_Detalle = Entradas_DetalleBrl.CargarPorId_Capacidad(Me.ID)
            End If
            Return Me.objListEntradas_Detalle
        End Get
        Set(ByVal Value As List(Of Entradas_DetalleBrl))
            Me.objListEntradas_Detalle = Value
        End Set
    End Property

    Public Property Salidas_Tipo_Salida() As List(Of SalidasBrl)
        Get
            If (Me.objListSalidas_TipoSalida Is Nothing) Then
                objListSalidas_TipoSalida = SalidasBrl.CargarPorId_Tipo_Salida(Me.ID)
            End If
            Return Me.objListSalidas_TipoSalida
        End Get
        Set(ByVal Value As List(Of SalidasBrl))
            Me.objListSalidas_TipoSalida = Value
        End Set
    End Property

    Public Property Salidas_Tipo_Entrega() As List(Of SalidasBrl)
        Get
            If (Me.objListSalidas_TipoEntrega Is Nothing) Then
                objListSalidas_TipoEntrega = SalidasBrl.CargarPorId_Tipo_Entrega(Me.ID)
            End If
            Return Me.objListSalidas_TipoEntrega
        End Get
        Set(ByVal Value As List(Of SalidasBrl))
            Me.objListSalidas_TipoEntrega = Value
        End Set
    End Property

    Public Property Salidas_Reg_Grupo() As List(Of SalidasBrl)
        Get
            If (Me.objListSalidas_RegGrupo Is Nothing) Then
                objListSalidas_RegGrupo = SalidasBrl.CargarPorId_Grupo(Me.ID)
            End If
            Return Me.objListSalidas_RegGrupo
        End Get
        Set(ByVal Value As List(Of SalidasBrl))
            Me.objListSalidas_RegGrupo = Value
        End Set
    End Property

    Public Property Salidas_Detalle_Capacidad() As List(Of Salidas_DetalleBrl)
        Get
            If (Me.objListSalidas_Detalle Is Nothing) Then
                objListSalidas_Detalle = Salidas_DetalleBrl.CargarPorId_Capacidad(Me.ID)
            End If
            Return Me.objListSalidas_Detalle
        End Get
        Set(ByVal Value As List(Of Salidas_DetalleBrl))
            Me.objListSalidas_Detalle = Value
        End Set
    End Property

    Public Property Personas_Contactos() As List(Of Personas_ContactosBrl)
        Get
            If (Me.objListPersonas_Contactos Is Nothing) Then
                objListPersonas_Contactos = Personas_ContactosBrl.CargarPorId_Tipo_Contacto(Me.ID)
            End If
            Return Me.objListPersonas_Contactos
        End Get
        Set(ByVal Value As List(Of Personas_ContactosBrl))
            Me.objListPersonas_Contactos = Value
        End Set
    End Property

    Public Property PersonasTipo_Identificacion() As List(Of PersonasBrl)
        Get
            If (Me.objListPersonasTipo_Identificacion Is Nothing) Then
                objListPersonasTipo_Identificacion = PersonasBrl.CargarPorId_Tipo_Identificacion(Me.ID)
            End If
            Return Me.objListPersonasTipo_Identificacion
        End Get
        Set(ByVal Value As List(Of PersonasBrl))
            Me.objListPersonasTipo_Identificacion = Value
        End Set
    End Property

    Public Property PersonasGenero() As List(Of PersonasBrl)
        Get
            If (Me.objListPersonasGenero Is Nothing) Then
                objListPersonasGenero = PersonasBrl.CargarPorId_Genero(Me.ID)
            End If
            Return Me.objListPersonasGenero
        End Get
        Set(ByVal Value As List(Of PersonasBrl))
            Me.objListPersonasGenero = Value
        End Set
    End Property

    Public Property PersonasParentesco() As List(Of PersonasBrl)
        Get
            If (Me.objListPersonasParentesco Is Nothing) Then
                objListPersonasParentesco = PersonasBrl.CargarPorId_Parentesco(Me.ID)
            End If
            Return Me.objListPersonasParentesco
        End Get
        Set(ByVal Value As List(Of PersonasBrl))
            Me.objListPersonasParentesco = Value
        End Set
    End Property

    Public Property PersonasUltimo_Grado() As List(Of PersonasBrl)
        Get
            If (Me.objListPersonasUltimo_Grado Is Nothing) Then
                objListPersonasUltimo_Grado = PersonasBrl.CargarPorId_Ultimo_Grado(Me.ID)
            End If
            Return Me.objListPersonasUltimo_Grado
        End Get
        Set(ByVal Value As List(Of PersonasBrl))
            Me.objListPersonasUltimo_Grado = Value
        End Set
    End Property

    Public Property PersonasMotivo_NoEstudio() As List(Of PersonasBrl)
        Get
            If (Me.objListPersonasMotivo_NoEstudio Is Nothing) Then
                objListPersonasMotivo_NoEstudio = PersonasBrl.CargarPorId_Motivo_NoEstudio(Me.ID)
            End If
            Return Me.objListPersonasMotivo_NoEstudio
        End Get
        Set(ByVal Value As List(Of PersonasBrl))
            Me.objListPersonasMotivo_NoEstudio = Value
        End Set
    End Property

    Public Property PersonasDiscapacitado() As List(Of PersonasBrl)
        Get
            If (Me.objListPersonasDiscapacitado Is Nothing) Then
                objListPersonasDiscapacitado = PersonasBrl.CargarPorId_Discapacitado(Me.ID)
            End If
            Return Me.objListPersonasDiscapacitado
        End Get
        Set(ByVal Value As List(Of PersonasBrl))
            Me.objListPersonasDiscapacitado = Value
        End Set
    End Property

    Public Property PersonasEstudia_Antes() As List(Of PersonasBrl)
        Get
            If (Me.objListPersonasEstudia_Antes Is Nothing) Then
                objListPersonasEstudia_Antes = PersonasBrl.CargarPorId_Estudia_Antes(Me.ID)
            End If
            Return Me.objListPersonasEstudia_Antes
        End Get
        Set(ByVal Value As List(Of PersonasBrl))
            Me.objListPersonasEstudia_Antes = Value
        End Set
    End Property

    Public ReadOnly Property Tablas() As TablasBrl
        Get
            Return TablasBrl.CargarPorID(Id_Tabla)
        End Get
    End Property

    Public Property PersonasEstudia_Actualmente() As List(Of PersonasBrl)
        Get
            If (Me.objListPersonasEstudia_Actualmente Is Nothing) Then
                objListPersonasEstudia_Actualmente = PersonasBrl.CargarPorId_Estudia_Actualmente(Me.ID)
            End If
            Return Me.objListPersonasEstudia_Actualmente
        End Get
        Set(ByVal Value As List(Of PersonasBrl))
            Me.objListPersonasEstudia_Actualmente = Value
        End Set
    End Property

    Public Property DeclaracionGrupos() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracion_grupos Is Nothing) Then
                objListDeclaracion_grupos = DeclaracionBrl.CargarPorId_Grupo(Me.ID)
            End If
            Return Me.objListDeclaracion_grupos
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracion_grupos = Value
        End Set
    End Property

    Public Property DeclaracionBeneficiadoProgramas() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionBeneficiadoProgramas Is Nothing) Then
                objListDeclaracionBeneficiadoProgramas = DeclaracionBrl.CargarPorId_beneficiado_programas(Me.ID)
            End If
            Return Me.objListDeclaracionBeneficiadoProgramas
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionBeneficiadoProgramas = Value
        End Set
    End Property

    Public Property Declaracion_Programas_Ayuda() As List(Of Declaracion_Programas_AyudaBrl)
        Get
            If (Me.objListDeclaracion_Programas_Ayuda Is Nothing) Then
                objListDeclaracion_Programas_Ayuda = Declaracion_Programas_AyudaBrl.CargarPorId_Programa_Ayuda(Me.ID)
            End If
            Return Me.objListDeclaracion_Programas_Ayuda
        End Get
        Set(ByVal Value As List(Of Declaracion_Programas_AyudaBrl))
            Me.objListDeclaracion_Programas_Ayuda = Value
        End Set
    End Property

    Public Property DeclaracionAtender() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionAtender Is Nothing) Then
                objListDeclaracionAtender = DeclaracionBrl.CargarPorId_Atender(Me.ID)
            End If
            Return Me.objListDeclaracionAtender
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionAtender = Value
        End Set
    End Property

    Public Property DeclaracionMotivo_Noatender() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionMotivo_Noatender Is Nothing) Then
                objListDeclaracionMotivo_Noatender = DeclaracionBrl.CargarPorId_Motivo_Noatender(Me.ID)
            End If
            Return Me.objListDeclaracionMotivo_Noatender
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionMotivo_Noatender = Value
        End Set
    End Property

    Public Property GestantesControl_Prenatal() As List(Of GestantesBrl)
        Get
            If (Me.objListGestantesControl_Prenatal Is Nothing) Then
                objListGestantesControl_Prenatal = GestantesBrl.CargarPorId_Control_Prenatal(Me.ID)
            End If
            Return Me.objListGestantesControl_Prenatal
        End Get
        Set(ByVal Value As List(Of GestantesBrl))
            Me.objListGestantesControl_Prenatal = Value
        End Set
    End Property

    Public Property GestantesIngesta_Micronutrientes() As List(Of GestantesBrl)
        Get
            If (Me.objListGestantesIngesta_Micronutrientes Is Nothing) Then
                objListGestantesIngesta_Micronutrientes = GestantesBrl.CargarPorId_Ingesta_Micronutrientes(Me.ID)
            End If
            Return Me.objListGestantesIngesta_Micronutrientes
        End Get
        Set(ByVal Value As List(Of GestantesBrl))
            Me.objListGestantesIngesta_Micronutrientes = Value
        End Set
    End Property

    Public Property GestantesRemitidas() As List(Of GestantesBrl)
        Get
            If (Me.objListGestantesRemitidas Is Nothing) Then
                objListGestantesRemitidas = GestantesBrl.CargarPorId_Remitidas(Me.ID)
            End If
            Return Me.objListGestantesRemitidas
        End Get
        Set(ByVal Value As List(Of GestantesBrl))
            Me.objListGestantesRemitidas = Value
        End Set
    End Property

    Public Property GestantesVisita_Domiciliaria() As List(Of GestantesBrl)
        Get
            If (Me.objListGestantesVisita_Domiciliaria Is Nothing) Then
                objListGestantesVisita_Domiciliaria = GestantesBrl.CargarPorId_Visita_Domiciliaria(Me.ID)
            End If
            Return Me.objListGestantesVisita_Domiciliaria
        End Get
        Set(ByVal Value As List(Of GestantesBrl))
            Me.objListGestantesVisita_Domiciliaria = Value
        End Set
    End Property

    Public Property Salud_Remisiones() As List(Of Salud_RemisionesBrl)
        Get
            If (Me.objListSalud_Remisiones Is Nothing) Then
                objListSalud_Remisiones = Salud_RemisionesBrl.CargarPorId_Entidad_Remision(Me.ID)
            End If
            Return Me.objListSalud_Remisiones
        End Get
        Set(ByVal Value As List(Of Salud_RemisionesBrl))
            Me.objListSalud_Remisiones = Value
        End Set
    End Property

    Public Property SaludCrecimiento_Desarrollo() As List(Of SaludBrl)
        Get
            If (Me.objListSaludCrecimiento_Desarrollo Is Nothing) Then
                objListSaludCrecimiento_Desarrollo = SaludBrl.CargarPorId_Crecimiento_Desarrollo(Me.ID)
            End If
            Return Me.objListSaludCrecimiento_Desarrollo
        End Get
        Set(ByVal Value As List(Of SaludBrl))
            Me.objListSaludCrecimiento_Desarrollo = Value
        End Set
    End Property

    Public Property SaludLactancia_Lactando() As List(Of SaludBrl)
        Get
            If (Me.objListSaludLactancia_Lactando Is Nothing) Then
                objListSaludLactancia_Lactando = SaludBrl.CargarPorId_Lactancia_Lactando(Me.ID)
            End If
            Return Me.objListSaludLactancia_Lactando
        End Get
        Set(ByVal Value As List(Of SaludBrl))
            Me.objListSaludLactancia_Lactando = Value
        End Set
    End Property

    Public Property SaludMotivo_No_Vacunados() As List(Of SaludBrl)
        Get
            If (Me.objListSaludMotivo_No_Vacunados Is Nothing) Then
                objListSaludMotivo_No_Vacunados = SaludBrl.CargarPorId_Motivo_No_Vacunados(Me.ID)
            End If
            Return Me.objListSaludMotivo_No_Vacunados
        End Get
        Set(ByVal Value As List(Of SaludBrl))
            Me.objListSaludMotivo_No_Vacunados = Value
        End Set
    End Property

    Public Property SaludVitaminas_Desparasitacion() As List(Of SaludBrl)
        Get
            If (Me.objListSaludVitaminas_Desparasitacion Is Nothing) Then
                objListSaludVitaminas_Desparasitacion = SaludBrl.CargarPorId_Vitaminas_Desparasitacion(Me.ID)
            End If
            Return Me.objListSaludVitaminas_Desparasitacion
        End Get
        Set(ByVal Value As List(Of SaludBrl))
            Me.objListSaludVitaminas_Desparasitacion = Value
        End Set
    End Property

    Public Property SaludVitaminas_Suplementacion() As List(Of SaludBrl)
        Get
            If (Me.objListSaludVitaminas_Suplementacion Is Nothing) Then
                objListSaludVitaminas_Suplementacion = SaludBrl.CargarPorId_Vitaminas_Suplementacion(Me.ID)
            End If
            Return Me.objListSaludVitaminas_Suplementacion
        End Get
        Set(ByVal Value As List(Of SaludBrl))
            Me.objListSaludVitaminas_Suplementacion = Value
        End Set
    End Property

    Public Property SaludVacunacion_Carnet() As List(Of SaludBrl)
        Get
            If (Me.objListSaludVacunacion_Carnet Is Nothing) Then
                objListSaludVacunacion_Carnet = SaludBrl.CargarPorId_Vacunacion_Carnet(Me.ID)
            End If
            Return Me.objListSaludVacunacion_Carnet
        End Get
        Set(ByVal Value As List(Of SaludBrl))
            Me.objListSaludVacunacion_Carnet = Value
        End Set
    End Property

    Public Property SaludRazon_No_Carnet() As List(Of SaludBrl)
        Get
            If (Me.objListSaludRazon_No_Carnet Is Nothing) Then
                objListSaludRazon_No_Carnet = SaludBrl.CargarPorId_Razon_No_Carnet(Me.ID)
            End If
            Return Me.objListSaludRazon_No_Carnet
        End Get
        Set(ByVal Value As List(Of SaludBrl))
            Me.objListSaludRazon_No_Carnet = Value
        End Set
    End Property

    Public Property SaludEsquema_Vacunacion_Completo() As List(Of SaludBrl)
        Get
            If (Me.objListSaludEsquema_Vacunacion_Completo Is Nothing) Then
                objListSaludEsquema_Vacunacion_Completo = SaludBrl.CargarPorId_Esquema_Vacunacion_Completo(Me.ID)
            End If
            Return Me.objListSaludEsquema_Vacunacion_Completo
        End Get
        Set(ByVal Value As List(Of SaludBrl))
            Me.objListSaludEsquema_Vacunacion_Completo = Value
        End Set
    End Property

    Public Property SaludRazon_No_Vacunacion_Completo() As List(Of SaludBrl)
        Get
            If (Me.objListSaludRazon_No_Vacunacion_Completo Is Nothing) Then
                objListSaludRazon_No_Vacunacion_Completo = SaludBrl.CargarPorId_Razon_No_Vacunacion_Completo(Me.ID)
            End If
            Return Me.objListSaludRazon_No_Vacunacion_Completo
        End Get
        Set(ByVal Value As List(Of SaludBrl))
            Me.objListSaludRazon_No_Vacunacion_Completo = Value
        End Set
    End Property

    Public Property SaludNinos_Vacunados() As List(Of SaludBrl)
        Get
            If (Me.objListSaludNinos_Vacunados Is Nothing) Then
                objListSaludNinos_Vacunados = SaludBrl.CargarPorId_Ninos_Vacunados(Me.ID)
            End If
            Return Me.objListSaludNinos_Vacunados
        End Get
        Set(ByVal Value As List(Of SaludBrl))
            Me.objListSaludNinos_Vacunados = Value
        End Set
    End Property


    Public Property Salud_ValoracionRecuperado() As List(Of Salud_ValoracionBrl)
        Get
            If (Me.objListSalud_ValoracionRecuperado Is Nothing) Then
                objListSalud_ValoracionRecuperado = Salud_ValoracionBrl.CargarPorId_Recuperado(Me.ID)
            End If
            Return Me.objListSalud_ValoracionRecuperado
        End Get
        Set(ByVal Value As List(Of Salud_ValoracionBrl))
            Me.objListSalud_ValoracionRecuperado = Value
        End Set
    End Property

    Public Property Declaracion_Bienes() As List(Of Declaracion_BienesBrl)
        Get
            If (Me.objListDeclaracion_Bienes Is Nothing) Then
                objListDeclaracion_Bienes = Declaracion_BienesBrl.CargarPorId_Bienes(Me.ID)
            End If
            Return Me.objListDeclaracion_Bienes
        End Get
        Set(ByVal Value As List(Of Declaracion_BienesBrl))
            Me.objListDeclaracion_Bienes = Value
        End Set
    End Property

    Public Property Declaracion_Causas_Desplazamiento() As List(Of Declaracion_Causas_DesplazamientoBrl)
        Get
            If (Me.objListDeclaracion_Causas_Desplazamiento Is Nothing) Then
                objListDeclaracion_Causas_Desplazamiento = Declaracion_Causas_DesplazamientoBrl.CargarPorId_Causa_Desplazamiento(Me.ID)
            End If
            Return Me.objListDeclaracion_Causas_Desplazamiento
        End Get
        Set(ByVal Value As List(Of Declaracion_Causas_DesplazamientoBrl))
            Me.objListDeclaracion_Causas_Desplazamiento = Value
        End Set
    End Property

    Public Property Declaracion_Causas_NoEstudio() As List(Of Declaracion_Causas_NoEstudioBrl)
        Get
            If (Me.objListDeclaracion_Causas_NoEstudio Is Nothing) Then
                objListDeclaracion_Causas_NoEstudio = Declaracion_Causas_NoEstudioBrl.CargarPorId_Causa_No_Estudio(Me.ID)
            End If
            Return Me.objListDeclaracion_Causas_NoEstudio
        End Get
        Set(ByVal Value As List(Of Declaracion_Causas_NoEstudioBrl))
            Me.objListDeclaracion_Causas_NoEstudio = Value
        End Set
    End Property

    Public Property DeclaracionComo_Brindar_Atencion() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionComo_Brindar_Atencion Is Nothing) Then
                objListDeclaracionComo_Brindar_Atencion = DeclaracionBrl.CargarPorId_Como_Brindar_Atencion(Me.ID)
            End If
            Return Me.objListDeclaracionComo_Brindar_Atencion
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionComo_Brindar_Atencion = Value
        End Set
    End Property

    Public Property DeclaracionComo_Fue_Atencion() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionComo_Fue_Atencion Is Nothing) Then
                objListDeclaracionComo_Fue_Atencion = DeclaracionBrl.CargarPorId_Como_Fue_Atencion(Me.ID)
            End If
            Return Me.objListDeclaracionComo_Fue_Atencion
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionComo_Fue_Atencion = Value
        End Set
    End Property

    Public Property DeclaracionCuantas_Habitaciones() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionCuantas_Habitaciones Is Nothing) Then
                objListDeclaracionCuantas_Habitaciones = DeclaracionBrl.CargarPorId_Cuantas_Habitaciones(Me.ID)
            End If
            Return Me.objListDeclaracionCuantas_Habitaciones
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionCuantas_Habitaciones = Value
        End Set
    End Property

    Public Property DeclaracionCuantas_Personas_Habitacion() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionCuantas_Personas_Habitacion Is Nothing) Then
                objListDeclaracionCuantas_Personas_Habitacion = DeclaracionBrl.CargarPorId_Cuantas_Personas_Habitacion(Me.ID)
            End If
            Return Me.objListDeclaracionCuantas_Personas_Habitacion
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionCuantas_Personas_Habitacion = Value
        End Set
    End Property

    Public Property DeclaracionCuantas_Personas_Vivienda() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionCuantas_Personas_Vivienda Is Nothing) Then
                objListDeclaracionCuantas_Personas_Vivienda = DeclaracionBrl.CargarPorId_Cuantas_Personas_Vivienda(Me.ID)
            End If
            Return Me.objListDeclaracionCuantas_Personas_Vivienda
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionCuantas_Personas_Vivienda = Value
        End Set
    End Property

    Public Property DeclaracionCuanto_Tiempo_Demoro() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionCuanto_Tiempo_Demoro Is Nothing) Then
                objListDeclaracionCuanto_Tiempo_Demoro = DeclaracionBrl.CargarPorId_Cuanto_Tiempo_Demoro(Me.ID)
            End If
            Return Me.objListDeclaracionCuanto_Tiempo_Demoro
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionCuanto_Tiempo_Demoro = Value
        End Set
    End Property

    Public Property DeclaracionCuantos_Desplazamientos() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionCuantos_Desplazamientos Is Nothing) Then
                objListDeclaracionCuantos_Desplazamientos = DeclaracionBrl.CargarPorId_Cuantos_Desplazamientos(Me.ID)
            End If
            Return Me.objListDeclaracionCuantos_Desplazamientos
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionCuantos_Desplazamientos = Value
        End Set
    End Property

    Public Property Declaracion_Danos_Familia() As List(Of Declaracion_Danos_FamiliaBrl)
        Get
            If (Me.objListDeclaracion_Danos_Familia Is Nothing) Then
                objListDeclaracion_Danos_Familia = Declaracion_Danos_FamiliaBrl.CargarPorId_Danos_Familia(Me.ID)
            End If
            Return Me.objListDeclaracion_Danos_Familia
        End Get
        Set(ByVal Value As List(Of Declaracion_Danos_FamiliaBrl))
            Me.objListDeclaracion_Danos_Familia = Value
        End Set
    End Property

    Public Property DeclaracionDepartamento_Expulsor() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionDepartamento_Expulsor Is Nothing) Then
                objListDeclaracionDepartamento_Expulsor = DeclaracionBrl.CargarPorId_Departamento_Expulsor(Me.ID)
            End If
            Return Me.objListDeclaracionDepartamento_Expulsor
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionDepartamento_Expulsor = Value
        End Set
    End Property

    Public Property DeclaracionDespues_Hijos_617() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionDespues_Hijos_617 Is Nothing) Then
                objListDeclaracionDespues_Hijos_617 = DeclaracionBrl.CargarPorId_Despues_Hijos_617(Me.ID)
            End If
            Return Me.objListDeclaracionDespues_Hijos_617
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionDespues_Hijos_617 = Value
        End Set
    End Property

    Public Property DeclaracionEntidad_Inicial_Atencion() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionEntidad_Inicial_Atencion Is Nothing) Then
                objListDeclaracionEntidad_Inicial_Atencion = DeclaracionBrl.CargarPorId_Entidad_Inicial_Atencion(Me.ID)
            End If
            Return Me.objListDeclaracionEntidad_Inicial_Atencion
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionEntidad_Inicial_Atencion = Value
        End Set
    End Property

    Public Property DeclaracionForma_Declaracion() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionForma_Declaracion Is Nothing) Then
                objListDeclaracionForma_Declaracion = DeclaracionBrl.CargarPorId_Forma_Declaracion(Me.ID)
            End If
            Return Me.objListDeclaracionForma_Declaracion
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionForma_Declaracion = Value
        End Set
    End Property

    Public Property Declaracion_Instituciones_Confianza() As List(Of Declaracion_Instituciones_ConfianzaBrl)
        Get
            If (Me.objListDeclaracion_Instituciones_Confianza Is Nothing) Then
                objListDeclaracion_Instituciones_Confianza = Declaracion_Instituciones_ConfianzaBrl.CargarPorId_Institucion_Confianza(Me.ID)
            End If
            Return Me.objListDeclaracion_Instituciones_Confianza
        End Get
        Set(ByVal Value As List(Of Declaracion_Instituciones_ConfianzaBrl))
            Me.objListDeclaracion_Instituciones_Confianza = Value
        End Set
    End Property

    Public Property DeclaracionMateriales_Vivienda() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionMateriales_Vivienda Is Nothing) Then
                objListDeclaracionMateriales_Vivienda = DeclaracionBrl.CargarPorId_Materiales_Vivienda(Me.ID)
            End If
            Return Me.objListDeclaracionMateriales_Vivienda
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionMateriales_Vivienda = Value
        End Set
    End Property

    Public Property DeclaracionMotivo_Demora() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionMotivo_Demora Is Nothing) Then
                objListDeclaracionMotivo_Demora = DeclaracionBrl.CargarPorId_Motivo_Demora(Me.ID)
            End If
            Return Me.objListDeclaracionMotivo_Demora
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionMotivo_Demora = Value
        End Set
    End Property

    Public Property DeclaracionMotivo_Desplazamiento() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionMotivo_Desplazamiento Is Nothing) Then
                objListDeclaracionMotivo_Desplazamiento = DeclaracionBrl.CargarPorId_Motivo_Desplazamiento(Me.ID)
            End If
            Return Me.objListDeclaracionMotivo_Desplazamiento
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionMotivo_Desplazamiento = Value
        End Set
    End Property

    Public Property DeclaracionMotivo_NoDeclaro_Municipio() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionMotivo_NoDeclaro_Municipio Is Nothing) Then
                objListDeclaracionMotivo_NoDeclaro_Municipio = DeclaracionBrl.CargarPorId_Motivo_NoDeclaro_Municipio(Me.ID)
            End If
            Return Me.objListDeclaracionMotivo_NoDeclaro_Municipio
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionMotivo_NoDeclaro_Municipio = Value
        End Set
    End Property

    Public Property Declaracion_Nivel_Educativo() As List(Of Declaracion_Nivel_EducativoBrl)
        Get
            If (Me.objListDeclaracion_Nivel_Educativo Is Nothing) Then
                objListDeclaracion_Nivel_Educativo = Declaracion_Nivel_EducativoBrl.CargarPorId_Grado_Escolar(Me.ID)
            End If
            Return Me.objListDeclaracion_Nivel_Educativo
        End Get
        Set(ByVal Value As List(Of Declaracion_Nivel_EducativoBrl))
            Me.objListDeclaracion_Nivel_Educativo = Value
        End Set
    End Property

    Public Property DeclaracionPorque_No_Reporto() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionPorque_No_Reporto Is Nothing) Then
                objListDeclaracionPorque_No_Reporto = DeclaracionBrl.CargarPorId_Porque_No_Reporto(Me.ID)
            End If
            Return Me.objListDeclaracionPorque_No_Reporto
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionPorque_No_Reporto = Value
        End Set
    End Property

    Public Property DeclaracionRecibio_Ayuda_Entidad_Inicial() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionRecibio_Ayuda_Entidad_Inicial Is Nothing) Then
                objListDeclaracionRecibio_Ayuda_Entidad_Inicial = DeclaracionBrl.CargarPorId_Recibio_Ayuda_Entidad_Inicial(Me.ID)
            End If
            Return Me.objListDeclaracionRecibio_Ayuda_Entidad_Inicial
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionRecibio_Ayuda_Entidad_Inicial = Value
        End Set
    End Property

    Public Property Declaracion_Servicio_salud() As List(Of Declaracion_Servicio_saludBrl)
        Get
            If (Me.objListDeclaracion_Servicio_salud Is Nothing) Then
                objListDeclaracion_Servicio_salud = Declaracion_Servicio_saludBrl.CargarPorId_Servicio_Salud(Me.ID)
            End If
            Return Me.objListDeclaracion_Servicio_salud
        End Get
        Set(ByVal Value As List(Of Declaracion_Servicio_saludBrl))
            Me.objListDeclaracion_Servicio_salud = Value
        End Set
    End Property

    Public Property DeclaracionTiempo_Casco_Urbano() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionTiempo_Casco_Urbano Is Nothing) Then
                objListDeclaracionTiempo_Casco_Urbano = DeclaracionBrl.CargarPorId_Tiempo_Casco_Urbano(Me.ID)
            End If
            Return Me.objListDeclaracionTiempo_Casco_Urbano
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionTiempo_Casco_Urbano = Value
        End Set
    End Property

    Public Property DeclaracionTipo_Tenencia_Vivienda() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionTipo_Tenencia_Vivienda Is Nothing) Then
                objListDeclaracionTipo_Tenencia_Vivienda = DeclaracionBrl.CargarPorId_Tipo_Tenencia_Vivienda(Me.ID)
            End If
            Return Me.objListDeclaracionTipo_Tenencia_Vivienda
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionTipo_Tenencia_Vivienda = Value
        End Set
    End Property

    Public Property DeclaracionVivio_Cabezera_Municipal() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionVivio_Cabezera_Municipal Is Nothing) Then
                objListDeclaracionVivio_Cabezera_Municipal = DeclaracionBrl.CargarPorId_Vivio_Cabezera_Municipal(Me.ID)
            End If
            Return Me.objListDeclaracionVivio_Cabezera_Municipal
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionVivio_Cabezera_Municipal = Value
        End Set
    End Property

    Public Property PersonasCausas_Discapacidad() As List(Of PersonasBrl)
        Get
            If (Me.objListPersonasCausas_Discapacidad Is Nothing) Then
                objListPersonasCausas_Discapacidad = PersonasBrl.CargarPorId_Causas_Discapacidad(Me.ID)
            End If
            Return Me.objListPersonasCausas_Discapacidad
        End Get
        Set(ByVal Value As List(Of PersonasBrl))
            Me.objListPersonasCausas_Discapacidad = Value
        End Set
    End Property

    Public Property PersonasEmbarazada() As List(Of PersonasBrl)
        Get
            If (Me.objListPersonasEmbarazada Is Nothing) Then
                objListPersonasEmbarazada = PersonasBrl.CargarPorId_Embarazada(Me.ID)
            End If
            Return Me.objListPersonasEmbarazada
        End Get
        Set(ByVal Value As List(Of PersonasBrl))
            Me.objListPersonasEmbarazada = Value
        End Set
    End Property

    Public Property Personaseps() As List(Of Personas_Regimen_SaludBrl)
        Get
            If (Me.objListPersonasEPS Is Nothing) Then
                objListPersonasEPS = Personas_Regimen_SaludBrl.CargarPorId_Eps(Me.ID)
            End If
            Return Me.objListPersonasEPS
        End Get
        Set(ByVal Value As List(Of Personas_Regimen_SaludBrl))
            Me.objListPersonasEPS = Value
        End Set
    End Property

    Public Property PersonasGrupo_Etnico() As List(Of PersonasBrl)
        Get
            If (Me.objListPersonasGrupo_Etnico Is Nothing) Then
                objListPersonasGrupo_Etnico = PersonasBrl.CargarPorId_Grupo_Etnico(Me.ID)
            End If
            Return Me.objListPersonasGrupo_Etnico
        End Get
        Set(ByVal Value As List(Of PersonasBrl))
            Me.objListPersonasGrupo_Etnico = Value
        End Set
    End Property

    Public Property PersonasLactando() As List(Of PersonasBrl)
        Get
            If (Me.objListPersonasLactando Is Nothing) Then
                objListPersonasLactando = PersonasBrl.CargarPorId_Lactando(Me.ID)
            End If
            Return Me.objListPersonasLactando
        End Get
        Set(ByVal Value As List(Of PersonasBrl))
            Me.objListPersonasLactando = Value
        End Set
    End Property

    Public Property PersonasPaga_Matricula() As List(Of PersonasBrl)
        Get
            If (Me.objListPersonasPaga_Matricula Is Nothing) Then
                objListPersonasPaga_Matricula = PersonasBrl.CargarPorId_Paga_Matricula(Me.ID)
            End If
            Return Me.objListPersonasPaga_Matricula
        End Get
        Set(ByVal Value As List(Of PersonasBrl))
            Me.objListPersonasPaga_Matricula = Value
        End Set
    End Property

    Public Property PersonasProblemas_Establecimiento() As List(Of PersonasBrl)
        Get
            If (Me.objListPersonasProblemas_Establecimiento Is Nothing) Then
                objListPersonasProblemas_Establecimiento = PersonasBrl.CargarPorId_Problemas_Establecimiento(Me.ID)
            End If
            Return Me.objListPersonasProblemas_Establecimiento
        End Get
        Set(ByVal Value As List(Of PersonasBrl))
            Me.objListPersonasProblemas_Establecimiento = Value
        End Set
    End Property

    Public Property PersonasRecibio_Atencion_Psicologica() As List(Of PersonasBrl)
        Get
            If (Me.objListPersonasRecibio_Atencion_Psicologica Is Nothing) Then
                objListPersonasRecibio_Atencion_Psicologica = PersonasBrl.CargarPorId_Recibio_Atencion_Psicologica(Me.ID)
            End If
            Return Me.objListPersonasRecibio_Atencion_Psicologica
        End Get
        Set(ByVal Value As List(Of PersonasBrl))
            Me.objListPersonasRecibio_Atencion_Psicologica = Value
        End Set
    End Property

    Public Property PersonasRecibio_Tratamiento() As List(Of PersonasBrl)
        Get
            If (Me.objListPersonasRecibio_Tratamiento Is Nothing) Then
                objListPersonasRecibio_Tratamiento = PersonasBrl.CargarPorId_Recibio_Tratamiento(Me.ID)
            End If
            Return Me.objListPersonasRecibio_Tratamiento
        End Get
        Set(ByVal Value As List(Of PersonasBrl))
            Me.objListPersonasRecibio_Tratamiento = Value
        End Set
    End Property

    Public Property PersonasRegimen_Salud() As List(Of Personas_Regimen_SaludBrl)
        Get
            If (Me.objListPersonasRegimen_Salud Is Nothing) Then
                objListPersonasRegimen_Salud = Personas_Regimen_SaludBrl.CargarPorId_Regimen_Salud(Me.ID)
            End If
            Return Me.objListPersonasRegimen_Salud
        End Get
        Set(ByVal Value As List(Of Personas_Regimen_SaludBrl))
            Me.objListPersonasRegimen_Salud = Value
        End Set
    End Property

    Public Property PersonasSabe_Leer_Escribir() As List(Of PersonasBrl)
        Get
            If (Me.objListPersonasSabe_Leer_Escribir Is Nothing) Then
                objListPersonasSabe_Leer_Escribir = PersonasBrl.CargarPorId_Sabe_Leer_Escribir(Me.ID)
            End If
            Return Me.objListPersonasSabe_Leer_Escribir
        End Get
        Set(ByVal Value As List(Of PersonasBrl))
            Me.objListPersonasSabe_Leer_Escribir = Value
        End Set
    End Property

    Public Property PersonasSolicito_Atencion_Psicologica() As List(Of PersonasBrl)
        Get
            If (Me.objListPersonasSolicito_Atencion_Psicologica Is Nothing) Then
                objListPersonasSolicito_Atencion_Psicologica = PersonasBrl.CargarPorId_Solicito_Atencion_Psicologica(Me.ID)
            End If
            Return Me.objListPersonasSolicito_Atencion_Psicologica
        End Get
        Set(ByVal Value As List(Of PersonasBrl))
            Me.objListPersonasSolicito_Atencion_Psicologica = Value
        End Set
    End Property

    Public Property PersonasTipo_Apoyo_Educativo() As List(Of PersonasBrl)
        Get
            If (Me.objListPersonasTipo_Apoyo_Educativo Is Nothing) Then
                objListPersonasTipo_Apoyo_Educativo = PersonasBrl.CargarPorId_Tipo_Apoyo_Educativo(Me.ID)
            End If
            Return Me.objListPersonasTipo_Apoyo_Educativo
        End Get
        Set(ByVal Value As List(Of PersonasBrl))
            Me.objListPersonasTipo_Apoyo_Educativo = Value
        End Set
    End Property

    Public Property PersonasTipo_Discapacidad() As List(Of PersonasBrl)
        Get
            If (Me.objListPersonasTipo_Discapacidad Is Nothing) Then
                objListPersonasTipo_Discapacidad = PersonasBrl.CargarPorId_Tipo_Discapacidad(Me.ID)
            End If
            Return Me.objListPersonasTipo_Discapacidad
        End Get
        Set(ByVal Value As List(Of PersonasBrl))
            Me.objListPersonasTipo_Discapacidad = Value
        End Set
    End Property

    Public Property DeclaracionDespues_Afiliado_Regimen_Contributivo() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionDespues_Afiliado_Regimen_Contributivo Is Nothing) Then
                objListDeclaracionDespues_Afiliado_Regimen_Contributivo = DeclaracionBrl.CargarPorId_Despues_Afiliado_Regimen_Contributivo(Me.ID)
            End If
            Return Me.objListDeclaracionDespues_Afiliado_Regimen_Contributivo
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionDespues_Afiliado_Regimen_Contributivo = Value
        End Set
    End Property

    Public Property DeclaracionDespues_Afiliado_Regimen_Subsidiado() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionDespues_Afiliado_Regimen_Subsidiado Is Nothing) Then
                objListDeclaracionDespues_Afiliado_Regimen_Subsidiado = DeclaracionBrl.CargarPorId_Despues_Afiliado_Regimen_Subsidiado(Me.ID)
            End If
            Return Me.objListDeclaracionDespues_Afiliado_Regimen_Subsidiado
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionDespues_Afiliado_Regimen_Subsidiado = Value
        End Set
    End Property

    Public Property DeclaracionDespues_Afiliado_Sisben() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionDespues_Afiliado_Sisben Is Nothing) Then
                objListDeclaracionDespues_Afiliado_Sisben = DeclaracionBrl.CargarPorId_Despues_Afiliado_Sisben(Me.ID)
            End If
            Return Me.objListDeclaracionDespues_Afiliado_Sisben
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionDespues_Afiliado_Sisben = Value
        End Set
    End Property

    Public Property DeclaracionDestino_Tierra() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionDestino_Tierra Is Nothing) Then
                objListDeclaracionDestino_Tierra = DeclaracionBrl.CargarPorId_Destino_Tierra(Me.ID)
            End If
            Return Me.objListDeclaracionDestino_Tierra
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionDestino_Tierra = Value
        End Set
    End Property

    Public Property DeclaracionDocumento_Propiedad() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionDocumento_Propiedad Is Nothing) Then
                objListDeclaracionDocumento_Propiedad = DeclaracionBrl.CargarPorId_Documento_Propiedad(Me.ID)
            End If
            Return Me.objListDeclaracionDocumento_Propiedad
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionDocumento_Propiedad = Value
        End Set
    End Property

    Public Property DeclaracionSituacion_Actual_Tierras() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionSituacion_Actual_Tierras Is Nothing) Then
                objListDeclaracionSituacion_Actual_Tierras = DeclaracionBrl.CargarPorId_Situacion_Actual_Tierras(Me.ID)
            End If
            Return Me.objListDeclaracionSituacion_Actual_Tierras
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionSituacion_Actual_Tierras = Value
        End Set
    End Property

    Public Property DeclaracionTipo_Bien_Rural() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionTipo_Bien_Rural Is Nothing) Then
                objListDeclaracionTipo_Bien_Rural = DeclaracionBrl.CargarPorId_Tipo_Bien_Rural(Me.ID)
            End If
            Return Me.objListDeclaracionTipo_Bien_Rural
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionTipo_Bien_Rural = Value
        End Set
    End Property

    Public Property DeclaracionTipo_Familia_Desplazada() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionTipo_Familia_desplazada Is Nothing) Then
                objListDeclaracionTipo_Familia_desplazada = DeclaracionBrl.CargarPorId_tipo_familia_Desplazada(Me.ID)
            End If
            Return Me.objListDeclaracionTipo_Familia_desplazada
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionTipo_Familia_desplazada = Value
        End Set
    End Property

    Public Property DeclaracionVulnerables_NoDesplazada() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionVulnerables_NoDesplazada Is Nothing) Then
                objListDeclaracionVulnerables_NoDesplazada = DeclaracionBrl.CargarPorId_Vulnerables_NoDesplazada(Me.ID)
            End If
            Return Me.objListDeclaracionVulnerables_NoDesplazada
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionVulnerables_NoDesplazada = Value
        End Set
    End Property

    Public Property DeclaracionFactorVulnerabilidad() As List(Of Declaracion_VulnerabilidadBrl)
        Get
            If (Me.objListDeclaracionVulnerabilidad Is Nothing) Then
                objListDeclaracionVulnerabilidad = Declaracion_VulnerabilidadBrl.CargarPorId_Factor_Vulnerabilidad(Me.ID)
            End If
            Return Me.objListDeclaracionVulnerabilidad
        End Get
        Set(ByVal Value As List(Of Declaracion_VulnerabilidadBrl))
            Me.objListDeclaracionVulnerabilidad = Value
        End Set
    End Property

    Public Property Trimestral_Grupos() As List(Of Trimestral_GruposBrl)
        Get
            If (Me.objListTrimestral_Grupos Is Nothing) Then
                objListTrimestral_Grupos = Trimestral_GruposBrl.CargarPorId_Grupo(Me.ID)
            End If
            Return Me.objListTrimestral_Grupos
        End Get
        Set(ByVal Value As List(Of Trimestral_GruposBrl))
            Me.objListTrimestral_Grupos = Value
        End Set
    End Property

    Public Property DeclaracionSolicito_Ayuda() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionSolicitoAyuda Is Nothing) Then
                objListDeclaracionSolicitoAyuda = DeclaracionBrl.CargarPorId_Solicito_Ayuda(Me.ID)
            End If
            Return Me.objListDeclaracionSolicitoAyuda
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionSolicitoAyuda = Value
        End Set
    End Property

    Public Property DeclaracionConcejoExpulsor() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionConcejoExpulsor Is Nothing) Then
                objListDeclaracionConcejoExpulsor = DeclaracionBrl.CargarPorId_Concejo_Expulsor(Me.ID)
            End If
            Return Me.objListDeclaracionConcejoExpulsor
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionConcejoExpulsor = Value
        End Set
    End Property

    Public Property Declaracionlugar_Fuente() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionLugarFuente Is Nothing) Then
                objListDeclaracionLugarFuente = DeclaracionBrl.CargarPorId_Lugar_Fuente(Me.ID)
            End If
            Return Me.objListDeclaracionLugarFuente
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionLugarFuente = Value
        End Set
    End Property

    Public Property DeclaracionEnLinea() As List(Of DeclaracionBrl)
        Get
            If (Me.objListDeclaracionEnLinea Is Nothing) Then
                objListDeclaracionEnLinea = DeclaracionBrl.CargarPorId_EnLinea(Me.ID)
            End If
            Return Me.objListDeclaracionEnLinea
        End Get
        Set(ByVal Value As List(Of DeclaracionBrl))
            Me.objListDeclaracionEnLinea = Value
        End Set
    End Property

    Public Property Declaracion_UnidadesUnidad() As List(Of Declaracion_UnidadesBrl)
        Get
            If (Me.objListDeclaracion_UnidadesUnidad Is Nothing) Then
                objListDeclaracion_UnidadesUnidad = Declaracion_UnidadesBrl.CargarPorId_Unidad(Me.ID)
            End If
            Return Me.objListDeclaracion_UnidadesUnidad
        End Get
        Set(ByVal Value As List(Of Declaracion_UnidadesBrl))
            Me.objListDeclaracion_UnidadesUnidad = Value
        End Set
    End Property

    Public Property Declaracion_UnidadesEstadoUnidad() As List(Of Declaracion_UnidadesBrl)
        Get
            If (Me.objListDeclaracion_UnidadesEstadoUnidad Is Nothing) Then
                objListDeclaracion_UnidadesEstadoUnidad = Declaracion_UnidadesBrl.CargarPorId_EstadoUnidad(Me.ID)
            End If
            Return Me.objListDeclaracion_UnidadesEstadoUnidad
        End Get
        Set(ByVal Value As List(Of Declaracion_UnidadesBrl))
            Me.objListDeclaracion_UnidadesEstadoUnidad = Value
        End Set
    End Property

    Public ReadOnly Property SubTablasPadre() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Padre)
        End Get
    End Property

    Public ReadOnly Property UsuariosCreacion() As UsuariosBrl
        Get
            Return UsuariosBrl.CargarPorID(Id_Usuario_Creacion)
        End Get
    End Property

    Public ReadOnly Property UsuariosModificacion() As UsuariosBrl
        Get
            Return UsuariosBrl.CargarPorID(Id_Usuario_Modificacion)
        End Get
    End Property

    '
    ' otras funciones
    '
    Public ReadOnly Property Padre() As String
        Get
            If SubTablasPadre Is Nothing Then
                Return ""
            Else
                Return SubTablasPadre.Descripcion
            End If
        End Get
    End Property


    Public ReadOnly Property Abuelo() As String
        Get
            If SubTablasPadre Is Nothing Then
                Return ""
            Else
                Return SubTablasPadre.Padre
            End If
        End Get
    End Property

    Public ReadOnly Property Fecha_Grupo() As DateTime
        Get
            If DeclaracionGrupos Is Nothing Then
                Return Nothing
            Else
                Try
                    Return DeclaracionGrupos.Item(0).Fecha_Valoracion
                Catch ex As Exception
                    Return Nothing
                End Try

            End If
        End Get
    End Property

    Public ReadOnly Property conteodeclarantes() As Integer
        Get
            If DeclaracionGrupos Is Nothing Then
                Return 0
            Else
                FilterHelper.FilterHelper(DeclaracionGrupos, "Id_Atender", 19)
                Return DeclaracionGrupos.Count
            End If
        End Get
    End Property

    Public ReadOnly Property conteobeneficiarios() As Integer
        Get
            Dim wtotal As Integer = 0
            If DeclaracionGrupos IsNot Nothing Then
                For Each fila As DeclaracionBrl In DeclaracionGrupos
                    wtotal = wtotal + fila.Personas.Count
                Next
            End If
            Return wtotal
        End Get
    End Property

    Public ReadOnly Property ConteoDeclarantesDesplazados() As Integer
        Get
            Dim wtotal As Integer = 0
            For Each fila As DeclaracionBrl In DeclaracionGrupos
                If fila.Tipo_Declaracion = 921 Then
                    wtotal += 1
                End If
            Next
            Return wtotal
        End Get
    End Property

    Public ReadOnly Property ConteoBeneficiariosDesplazados() As Integer
        Get
            Dim wtotal As Integer = 0
            For Each fila As DeclaracionBrl In DeclaracionGrupos
                If fila.Tipo_Declaracion = 921 Then
                    wtotal += fila.TipoFamiliaxaEmpacar
                End If
            Next
            Return wtotal
        End Get
    End Property

    Public ReadOnly Property ConteoDeclarantesVulnerables() As Integer
        Get
            Dim wtotal As Integer = 0
            For Each fila As DeclaracionBrl In DeclaracionGrupos
                If fila.Tipo_Declaracion = 922 Then
                    wtotal += 1
                End If
            Next
            Return wtotal
        End Get
    End Property

    Public ReadOnly Property ConteoBeneficiariosVulnerables() As Integer
        Get
            Dim wtotal As Integer = 0
            For Each fila As DeclaracionBrl In DeclaracionGrupos
                If fila.Tipo_Declaracion = 922 Then
                    wtotal += fila.TipoFamiliaxaEmpacar
                End If
            Next
            Return wtotal
        End Get
    End Property

    Public ReadOnly Property conteopersonas() As Integer
        Get
            Dim wtotal As Integer = 0
            If DeclaracionGrupos IsNot Nothing Then
                For Each fila As DeclaracionBrl In DeclaracionGrupos
                    wtotal = wtotal + fila.TipoFamilia
                Next
            End If
            Return wtotal
        End Get
    End Property

    Public ReadOnly Property conteopersonasembarazadas() As Integer
        Get
            Dim wtotal As Integer = 0
            If DeclaracionGrupos IsNot Nothing Then
                For Each fila As DeclaracionBrl In DeclaracionGrupos
                    For Each fila1 As PersonasBrl In fila.Personas
                        If fila1.Id_Embarazada = 19 Then
                            wtotal = wtotal + 1
                        End If
                    Next
                Next
            End If
            Return wtotal
        End Get
    End Property

    Public ReadOnly Property conteopersonaslactando() As Integer
        Get
            Dim wtotal As Integer = 0
            If DeclaracionGrupos IsNot Nothing Then
                For Each fila As DeclaracionBrl In DeclaracionGrupos
                    For Each fila1 As PersonasBrl In fila.Personas
                        If fila1.Id_Lactando = 19 Then
                            wtotal = wtotal + 1
                        End If
                    Next
                Next
            End If
            Return wtotal
        End Get
    End Property

    Public ReadOnly Property conteoPersonasNinos5() As Integer
        Get
            Dim wtotal As Integer = 0
            If DeclaracionGrupos IsNot Nothing Then
                For Each fila As DeclaracionBrl In DeclaracionGrupos
                    For Each fila1 As PersonasBrl In fila.Personas
                        If fila1.Edad >= 1 And fila1.Edad < 5 Then
                            wtotal = wtotal + 1
                        End If
                    Next
                Next
            End If
            Return wtotal
        End Get
    End Property

    Public ReadOnly Property conteoPersonasNinos617() As Integer
        Get
            Dim wtotal As Integer = 0
            If DeclaracionGrupos IsNot Nothing Then
                For Each fila As DeclaracionBrl In DeclaracionGrupos
                    For Each fila1 As PersonasBrl In fila.Personas
                        If fila1.Edad >= 6 And fila1.Edad <= 17 Then
                            wtotal = wtotal + 1
                        End If
                    Next
                Next
            End If
            Return wtotal
        End Get
    End Property

    Public ReadOnly Property TipoFamilia01() As Integer
        Get
            Dim wtotal As Integer = 0
            For Each fila As DeclaracionBrl In DeclaracionGrupos
                If fila.Personas.Count = 1 Then
                    wtotal = wtotal + 1
                End If
            Next
            Return wtotal
        End Get
    End Property

    Public ReadOnly Property TipoFamilia02() As Integer
        Get
            Dim wtotal As Integer = 0
            For Each fila As DeclaracionBrl In DeclaracionGrupos
                If fila.Personas.Count = 2 Then
                    wtotal = wtotal + 1
                End If
            Next
            Return wtotal
        End Get
    End Property

    Public ReadOnly Property TipoFamilia03() As Integer
        Get
            Dim wtotal As Integer = 0
            For Each fila As DeclaracionBrl In DeclaracionGrupos
                If fila.Personas.Count = 3 Then
                    wtotal = wtotal + 1
                End If
            Next
            Return wtotal
        End Get
    End Property

    Public ReadOnly Property TipoFamilia04() As Integer
        Get
            Dim wtotal As Integer = 0
            For Each fila As DeclaracionBrl In DeclaracionGrupos
                If fila.Personas.Count = 4 Then
                    wtotal = wtotal + 1
                End If
            Next
            Return wtotal
        End Get
    End Property

    Public ReadOnly Property TipoFamilia05() As Integer
        Get
            Dim wtotal As Integer = 0
            For Each fila As DeclaracionBrl In DeclaracionGrupos
                If fila.Personas.Count = 5 Then
                    wtotal = wtotal + 1
                End If
            Next
            Return wtotal
        End Get
    End Property

    Public ReadOnly Property TipoFamilia06() As Integer
        Get
            Dim wtotal As Integer = 0
            For Each fila As DeclaracionBrl In DeclaracionGrupos
                If fila.Personas.Count = 6 Then
                    wtotal = wtotal + 1
                End If
            Next
            Return wtotal
        End Get
    End Property

    Public ReadOnly Property TipoFamilia07() As Integer
        Get
            Dim wtotal As Integer = 0
            For Each fila As DeclaracionBrl In DeclaracionGrupos
                If fila.Personas.Count = 7 Then
                    wtotal = wtotal + 1
                End If
            Next
            Return wtotal
        End Get
    End Property

    Public ReadOnly Property TipoFamilia08() As Integer
        Get
            Dim wtotal As Integer = 0
            For Each fila As DeclaracionBrl In DeclaracionGrupos
                If fila.Personas.Count = 8 Then
                    wtotal = wtotal + 1
                End If
            Next
            Return wtotal
        End Get
    End Property

    Public ReadOnly Property TipoFamilia09() As Integer
        Get
            Dim wtotal As Integer = 0
            For Each fila As DeclaracionBrl In DeclaracionGrupos
                If fila.Personas.Count = 9 Then
                    wtotal = wtotal + 1
                End If
            Next
            Return wtotal
        End Get
    End Property

    Public ReadOnly Property TipoFamilia10() As Integer
        Get
            Dim wtotal As Integer = 0
            For Each fila As DeclaracionBrl In DeclaracionGrupos
                If fila.Personas.Count = 10 Then
                    wtotal = wtotal + 1
                End If
            Next
            Return wtotal
        End Get
    End Property

    Public ReadOnly Property TipoFamilia11() As Integer
        Get
            Dim wtotal As Integer = 0
            For Each fila As DeclaracionBrl In DeclaracionGrupos
                If fila.Personas.Count = 11 Then
                    wtotal = wtotal + 1
                End If
            Next
            Return wtotal
        End Get
    End Property

    Public ReadOnly Property TipoFamilia12() As Integer
        Get
            Dim wtotal As Integer = 0
            For Each fila As DeclaracionBrl In DeclaracionGrupos
                If fila.Personas.Count = 12 Then
                    wtotal = wtotal + 1
                End If
            Next
            Return wtotal
        End Get
    End Property

    Public ReadOnly Property TipoFamilia13() As Integer
        Get
            Dim wtotal As Integer = 0
            For Each fila As DeclaracionBrl In DeclaracionGrupos
                If fila.Personas.Count = 13 Then
                    wtotal = wtotal + 1
                End If
            Next
            Return wtotal
        End Get
    End Property

    Public ReadOnly Property TipoFamilia14() As Integer
        Get
            Dim wtotal As Integer = 0
            For Each fila As DeclaracionBrl In DeclaracionGrupos
                If fila.Personas.Count = 14 Then
                    wtotal = wtotal + 1
                End If
            Next
            Return wtotal
        End Get
    End Property

    Public ReadOnly Property TipoFamilia15() As Integer
        Get
            Dim wtotal As Integer = 0
            For Each fila As DeclaracionBrl In DeclaracionGrupos
                If fila.Personas.Count = 15 Then
                    wtotal = wtotal + 1
                End If
            Next
            Return wtotal
        End Get
    End Property

    Public Property Personas_Educacion_Certificado_Matricula() As List(Of Personas_EducacionBrl)
        Get
            If (Me.objListPersonas_Educacion_Certificado_Matricula Is Nothing) Then
                objListPersonas_Educacion_Certificado_Matricula = Personas_EducacionBrl.CargarPorId_Certificado_Matricula(Me.ID)
            End If
            Return Me.objListPersonas_Educacion_Certificado_Matricula
        End Get
        Set(ByVal Value As List(Of Personas_EducacionBrl))
            Me.objListPersonas_Educacion_Certificado_Matricula = Value
        End Set
    End Property

    Public Property Personas_Educacion_Estudia_Actualmente() As List(Of Personas_EducacionBrl)
        Get
            If (Me.objListPersonas_Educacion_Estudia_Actualmente Is Nothing) Then
                objListPersonas_Educacion_Estudia_Actualmente = Personas_EducacionBrl.CargarPorId_Estudia_Actualmente(Me.ID)
            End If
            Return Me.objListPersonas_Educacion_Estudia_Actualmente
        End Get
        Set(ByVal Value As List(Of Personas_EducacionBrl))
            Me.objListPersonas_Educacion_Estudia_Actualmente = Value
        End Set
    End Property

    Public Property Personas_Educacion_grado_escolar() As List(Of Personas_EducacionBrl)
        Get
            If (Me.objListPersonas_Educacion_grado_escolar Is Nothing) Then
                objListPersonas_Educacion_grado_escolar = Personas_EducacionBrl.CargarPorId_grado_escolar(Me.ID)
            End If
            Return Me.objListPersonas_Educacion_grado_escolar
        End Get
        Set(ByVal Value As List(Of Personas_EducacionBrl))
            Me.objListPersonas_Educacion_grado_escolar = Value
        End Set
    End Property

    Public Property Personas_Educacion_Motivo_NoEstudia() As List(Of Personas_EducacionBrl)
        Get
            If (Me.objListPersonas_Educacion_Motivo_NoEstudia Is Nothing) Then
                objListPersonas_Educacion_Motivo_NoEstudia = Personas_EducacionBrl.CargarPorId_Motivo_NoEstudia(Me.ID)
            End If
            Return Me.objListPersonas_Educacion_Motivo_NoEstudia
        End Get
        Set(ByVal Value As List(Of Personas_EducacionBrl))
            Me.objListPersonas_Educacion_Motivo_NoEstudia = Value
        End Set
    End Property

    Public Property Personas_Educacion_Seguimiento() As List(Of Personas_EducacionBrl)
        Get
            If (Me.objListPersonas_Educacion_Seguimiento Is Nothing) Then
                objListPersonas_Educacion_Seguimiento = Personas_EducacionBrl.CargarPorId_Seguimiento(Me.ID)
            End If
            Return Me.objListPersonas_Educacion_Seguimiento
        End Get
        Set(ByVal Value As List(Of Personas_EducacionBrl))
            Me.objListPersonas_Educacion_Seguimiento = Value
        End Set
    End Property

    Public Event Saving()
    Public Event Saved()

    Public Event Inserting()
    Public Event Inserted()

    Public Event Updating()
    Public Event Updated()

    Public Event Deleting()
    Public Event Deleted()

    Public Sub Guardar()
        RaiseEvent Saving()
        If (Me.ID = Nothing) Then
            RaiseEvent Inserting()
            Me.ID = SubTablasDAL.Insertar(Id_Tabla, Descripcion, Id_Padre, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Orden, Activo)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            SubTablasDAL.Actualizar(ID, Id_Tabla, Descripcion, Id_Padre, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Orden, Activo)
            RaiseEvent Updated()
        End If
        If Not objListDeclaracion_Ayudas_Dadas Is Nothing Then
            For Each fila As Declaracion_Ayudas_DadasBrl In objListDeclaracion_Ayudas_Dadas
                fila.Id_Tipo_Ayuda = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracion_Entidades_Ayuda Is Nothing Then
            For Each fila As Declaracion_Entidades_AyudaBrl In objListDeclaracion_Entidades_Ayuda
                fila.Id_Entidad_Ayuda = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracion_Fuentes_Ingreso Is Nothing Then
            For Each fila As Declaracion_Fuentes_IngresoBrl In objListDeclaracion_Fuentes_Ingreso
                fila.Id_Fuentes_Ingreso = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracion_Obtencion_Agua Is Nothing Then
            For Each fila As Declaracion_Obtencion_AguaBrl In objListDeclaracion_Obtencion_Agua
                fila.Id_Lugar_Agua = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionFuente Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionFuente
                fila.Id_Fuente = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionMunicipioExpulsor Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionMunicipioExpulsor
                fila.Id_Municipio_Expulsor = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionHa_Recibido_Ayuda Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionHa_Recibido_Ayuda
                fila.Id_Ha_Recibido_Ayuda = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionHa_Muerto_Alguien Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionHa_Muerto_Alguien
                fila.Id_Ha_Muerto_Alguien = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionMotivo_Muerte Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionMotivo_Muerte
                fila.Id_Motivo_Muerte = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionParentescoMuerte Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionParentescoMuerte
                fila.Id_Parentesco_Muerte = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionEnfermedad Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionEnfermedad
                fila.Id_Enfermedad = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionVelar_Enterrar Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionVelar_Enterrar
                fila.Id_Velar_Enterrar = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionTiene_Desaparecido Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionTiene_Desaparecido
                fila.Id_Tiene_Desaparecido = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionParentesco_Desaparecido Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionParentesco_Desaparecido
                fila.Id_Parentesco_Desaparecido = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionReporto Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionReporto
                fila.Id_Reporto = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionEntidad_Legal Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionEntidad_Legal
                fila.Id_Entidad_Legal = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionAplico_Reparaciones Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionAplico_Reparaciones
                fila.Id_Aplico_Reparaciones = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionEstado_Aplicacion Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionEstado_Aplicacion
                fila.Id_Estado_Aplicacion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionMotivo_No_Aplico Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionMotivo_No_Aplico
                fila.Id_Motivo_No_Aplico = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionLlegada_Insultos Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionLlegada_Insultos
                fila.Id_Llegada_Insultos = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionLlegada_Insultos_Usted Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionLlegada_Insultos_Usted
                fila.Id_Llegada_Insultos_Usted = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionLlegada_Insultos_Miembro Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionLlegada_Insultos_Miembro
                fila.Id_Llegada_Insultos_Miembro = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionLlegada_Sexual Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionLlegada_Sexual
                fila.Id_Llegada_Sexual = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionLlegada_Sexual_Usted Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionLlegada_Sexual_Usted
                fila.Id_Llegada_Sexual_Usted = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionLlegada_Sexual_Miembro Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionLlegada_Sexual_Miembro
                fila.Id_Llegada_Sexual_Miembro = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionLlegada_Golpes Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionLlegada_Golpes
                fila.Id_Llegada_Golpes = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionLlegada_Golpes_Usted Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionLlegada_Golpes_Usted
                fila.Id_Llegada_Golpes_Usted = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionLlegada_golpes_Miembro Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionLlegada_golpes_Miembro
                fila.Id_Llegada_Golpes_Miembro = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionHa_Redibido_Ayuda_Despues Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionHa_Redibido_Ayuda_Despues
                fila.Id_Ha_Redibido_Ayuda_Despues = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionEstatus_Aplicacion_Despues Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionEstatus_Aplicacion_Despues
                fila.Id_Estatus_Aplicacion_Despues = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionRazon_No_Aplico Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionRazon_No_Aplico
                fila.Id_Razon_No_Aplico = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionOido_Mesa_Desplazados Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionOido_Mesa_Desplazados
                fila.Id_Oido_Mesa_Desplazados = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionPertenece_Asociacion Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionPertenece_Asociacion
                fila.Id_Pertenece_Asociacion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionEsta_Trabajando Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionEsta_Trabajando
                fila.Id_Esta_Trabajando = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionHa_Regresado Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionHa_Regresado
                fila.Id_Ha_Regresado = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionRetornaria Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionRetornaria
                fila.Id_Retornaria = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionExplicacion_Retorno Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionExplicacion_Retorno
                fila.Id_Explicacion_Retorno = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionHa_Declarado_Antes Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionHa_Declarado_Antes
                fila.Id_Ha_Declarado_Antes = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracion_Trabajos Is Nothing Then
            For Each fila As Declaracion_TrabajosBrl In objListDeclaracion_Trabajos
                fila.Id_Tipo_Trabajo = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If


        If Not objListEntradas Is Nothing Then
            For Each fila As EntradasBrl In objListEntradas
                fila.Id_Tipo_Entrada = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If


        If Not objListPersonas_Contactos Is Nothing Then
            For Each fila As Personas_ContactosBrl In objListPersonas_Contactos
                fila.Id_Tipo_Contacto = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListPersonasGenero Is Nothing Then
            For Each fila As PersonasBrl In objListPersonasGenero
                fila.Id_Genero = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListPersonasParentesco Is Nothing Then
            For Each fila As PersonasBrl In objListPersonasParentesco
                fila.Id_Parentesco = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListPersonasUltimo_Grado Is Nothing Then
            For Each fila As PersonasBrl In objListPersonasUltimo_Grado
                fila.Id_Ultimo_Grado = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListPersonasMotivo_NoEstudio Is Nothing Then
            For Each fila As PersonasBrl In objListPersonasMotivo_NoEstudio
                fila.Id_Motivo_NoEstudio = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListPersonasDiscapacitado Is Nothing Then
            For Each fila As PersonasBrl In objListPersonasDiscapacitado
                fila.Id_Discapacitado = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListPersonasEstudia_Antes Is Nothing Then
            For Each fila As PersonasBrl In objListPersonasEstudia_Antes
                fila.Id_Estudia_Antes = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If


        If Not objListPersonasEstudia_Actualmente Is Nothing Then
            For Each fila As PersonasBrl In objListPersonasEstudia_Actualmente
                fila.Id_Estudia_Actualmente = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracionBeneficiado_Programas Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionBeneficiado_Programas
                fila.Id_Beneficiado_Programas = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracion_Programas_Ayuda Is Nothing Then
            For Each fila As Declaracion_Programas_AyudaBrl In objListDeclaracion_Programas_Ayuda
                fila.Id_Programa_Ayuda = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionAtender Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionAtender
                fila.Id_Atender = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionMotivo_Noatender Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionMotivo_Noatender
                fila.Id_Motivo_Noatender = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListGestantesControl_Prenatal Is Nothing Then
            For Each fila As GestantesBrl In objListGestantesControl_Prenatal
                fila.Id_Control_Prenatal = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListGestantesIngesta_Micronutrientes Is Nothing Then
            For Each fila As GestantesBrl In objListGestantesIngesta_Micronutrientes
                fila.Id_Ingesta_Micronutrientes = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListGestantesRemitidas Is Nothing Then
            For Each fila As GestantesBrl In objListGestantesRemitidas
                fila.Id_Remitidas = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListGestantesVisita_Domiciliaria Is Nothing Then
            For Each fila As GestantesBrl In objListGestantesVisita_Domiciliaria
                fila.Id_Visita_Domiciliaria = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListSalud_Remisiones Is Nothing Then
            For Each fila As Salud_RemisionesBrl In objListSalud_Remisiones
                fila.Id_Entidad_Remision = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListSaludCrecimiento_Desarrollo Is Nothing Then
            For Each fila As SaludBrl In objListSaludCrecimiento_Desarrollo
                fila.Id_Crecimiento_Desarrollo = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListSaludLactancia_Lactando Is Nothing Then
            For Each fila As SaludBrl In objListSaludLactancia_Lactando
                fila.Id_Lactancia_Lactando = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListSaludMotivo_No_Vacunados Is Nothing Then
            For Each fila As SaludBrl In objListSaludMotivo_No_Vacunados
                fila.Id_Motivo_No_Vacunados = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListSaludVitaminas_Desparasitacion Is Nothing Then
            For Each fila As SaludBrl In objListSaludVitaminas_Desparasitacion
                fila.Id_Vitaminas_Desparasitacion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListSaludVitaminas_Suplementacion Is Nothing Then
            For Each fila As SaludBrl In objListSaludVitaminas_Suplementacion
                fila.Id_Vitaminas_Suplementacion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListSaludVacunacion_Carnet Is Nothing Then
            For Each fila As SaludBrl In objListSaludVacunacion_Carnet
                fila.Id_Vacunacion_Carnet = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListSaludRazon_No_Carnet Is Nothing Then
            For Each fila As SaludBrl In objListSaludRazon_No_Carnet
                fila.Id_Razon_No_Carnet = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListSaludEsquema_Vacunacion_Completo Is Nothing Then
            For Each fila As SaludBrl In objListSaludEsquema_Vacunacion_Completo
                fila.Id_Esquema_Vacunacion_Completo = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListSaludRazon_No_Vacunacion_Completo Is Nothing Then
            For Each fila As SaludBrl In objListSaludRazon_No_Vacunacion_Completo
                fila.Id_Razon_No_Vacunacion_Completo = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListSaludNinos_Vacunados Is Nothing Then
            For Each fila As SaludBrl In objListSaludNinos_Vacunados
                fila.Id_Ninos_Vacunados = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListSalud_ValoracionRecuperado Is Nothing Then
            For Each fila As Salud_ValoracionBrl In objListSalud_ValoracionRecuperado
                fila.Id_Recuperado = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracion_Bienes Is Nothing Then
            For Each fila As Declaracion_BienesBrl In objListDeclaracion_Bienes
                fila.Id_Bienes = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracion_Causas_Desplazamiento Is Nothing Then
            For Each fila As Declaracion_Causas_DesplazamientoBrl In objListDeclaracion_Causas_Desplazamiento
                fila.Id_Causa_Desplazamiento = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracion_Causas_NoEstudio Is Nothing Then
            For Each fila As Declaracion_Causas_NoEstudioBrl In objListDeclaracion_Causas_NoEstudio
                fila.Id_Causa_No_Estudio = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionComo_Brindar_Atencion Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionComo_Brindar_Atencion
                fila.Id_Como_Brindar_Atencion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionComo_Fue_Atencion Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionComo_Fue_Atencion
                fila.Id_Como_Fue_Atencion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionCuantas_Habitaciones Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionCuantas_Habitaciones
                fila.Id_Cuantas_Habitaciones = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionCuantas_Personas_Habitacion Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionCuantas_Personas_Habitacion
                fila.Id_Cuantas_Personas_Habitacion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionCuantas_Personas_Vivienda Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionCuantas_Personas_Vivienda
                fila.Id_Cuantas_Personas_Vivienda = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionCuanto_Tiempo_Demoro Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionCuanto_Tiempo_Demoro
                fila.Id_Cuanto_Tiempo_Demoro = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionCuantos_Desplazamientos Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionCuantos_Desplazamientos
                fila.Id_Cuantos_Desplazamientos = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracion_Danos_Familia Is Nothing Then
            For Each fila As Declaracion_Danos_FamiliaBrl In objListDeclaracion_Danos_Familia
                fila.Id_Danos_Familia = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If



        If Not objListDeclaracionDepartamento_Expulsor Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionDepartamento_Expulsor
                fila.Id_Departamento_Expulsor = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionDespues_Hijos_617 Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionDespues_Hijos_617
                fila.Id_Despues_Hijos_617 = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionEntidad_Inicial_Atencion Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionEntidad_Inicial_Atencion
                fila.Id_Entidad_Inicial_Atencion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionForma_Declaracion Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionForma_Declaracion
                fila.Id_Forma_Declaracion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracion_Instituciones_Confianza Is Nothing Then
            For Each fila As Declaracion_Instituciones_ConfianzaBrl In objListDeclaracion_Instituciones_Confianza
                fila.Id_Institucion_Confianza = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionMateriales_Vivienda Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionMateriales_Vivienda
                fila.Id_Materiales_Vivienda = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionMotivo_Demora Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionMotivo_Demora
                fila.Id_Motivo_Demora = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionMotivo_Desplazamiento Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionMotivo_Desplazamiento
                fila.Id_Motivo_Desplazamiento = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionMotivo_NoDeclaro_Municipio Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionMotivo_NoDeclaro_Municipio
                fila.Id_Motivo_NoDeclaro_Municipio = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracion_Nivel_Educativo Is Nothing Then
            For Each fila As Declaracion_Nivel_EducativoBrl In objListDeclaracion_Nivel_Educativo
                fila.Id_Grado_Escolar = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionPorque_No_Reporto Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionPorque_No_Reporto
                fila.Id_Porque_No_Reporto = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionRecibio_Ayuda_Entidad_Inicial Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionRecibio_Ayuda_Entidad_Inicial
                fila.Id_Recibio_Ayuda_Entidad_Inicial = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracion_Servicio_salud Is Nothing Then
            For Each fila As Declaracion_Servicio_saludBrl In objListDeclaracion_Servicio_salud
                fila.Id_Servicio_Salud = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionTiempo_Casco_Urbano Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionTiempo_Casco_Urbano
                fila.Id_Tiempo_Casco_Urbano = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionTipo_Tenencia_Vivienda Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionTipo_Tenencia_Vivienda
                fila.Id_Tipo_Tenencia_Vivienda = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionVivio_Cabezera_Municipal Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionVivio_Cabezera_Municipal
                fila.Id_Vivio_Cabezera_Municipal = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListPersonasCausas_Discapacidad Is Nothing Then
            For Each fila As PersonasBrl In objListPersonasCausas_Discapacidad
                fila.Id_Causas_Discapacidad = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListPersonasEmbarazada Is Nothing Then
            For Each fila As PersonasBrl In objListPersonasEmbarazada
                fila.Id_Embarazada = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListPersonasGrupo_Etnico Is Nothing Then
            For Each fila As PersonasBrl In objListPersonasGrupo_Etnico
                fila.Id_Grupo_Etnico = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListPersonasLactando Is Nothing Then
            For Each fila As PersonasBrl In objListPersonasLactando
                fila.Id_Lactando = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListPersonasPaga_matricula Is Nothing Then
            For Each fila As PersonasBrl In objListPersonasPaga_matricula
                fila.Id_Paga_Matricula = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListPersonasProblemas_Establecimiento Is Nothing Then
            For Each fila As PersonasBrl In objListPersonasProblemas_Establecimiento
                fila.Id_Problemas_Establecimiento = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListPersonasRecibio_Atencion_psicologica Is Nothing Then
            For Each fila As PersonasBrl In objListPersonasRecibio_Atencion_psicologica
                fila.Id_Recibio_Atencion_Psicologica = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListPersonasRecibio_Tratamiento Is Nothing Then
            For Each fila As PersonasBrl In objListPersonasRecibio_Tratamiento
                fila.Id_Recibio_Tratamiento = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListPersonasSabe_Leer_escribir Is Nothing Then
            For Each fila As PersonasBrl In objListPersonasSabe_Leer_escribir
                fila.Id_Sabe_Leer_Escribir = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListPersonasSolicito_Atencion_Psicologica Is Nothing Then
            For Each fila As PersonasBrl In objListPersonasSolicito_Atencion_Psicologica
                fila.Id_Solicito_Atencion_Psicologica = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListPersonasTipo_Apoyo_educativo Is Nothing Then
            For Each fila As PersonasBrl In objListPersonasTipo_Apoyo_educativo
                fila.Id_Tipo_Apoyo_Educativo = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListPersonasTipo_Discapacidad Is Nothing Then
            For Each fila As PersonasBrl In objListPersonasTipo_Discapacidad
                fila.Id_Tipo_Discapacidad = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionDespues_Afiliado_Regimen_Contributivo Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionDespues_Afiliado_Regimen_Contributivo
                fila.Id_Despues_Afiliado_Regimen_Contributivo = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionDespues_Afiliado_Regimen_Subsidiado Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionDespues_Afiliado_Regimen_Subsidiado
                fila.Id_Despues_Afiliado_Regimen_Subsidiado = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionDespues_Afiliado_Sisben Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionDespues_Afiliado_Sisben
                fila.Id_Despues_Afiliado_Sisben = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionDestino_Tierra Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionDestino_Tierra
                fila.Id_Destino_Tierra = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionDocumento_Propiedad Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionDocumento_Propiedad
                fila.Id_Documento_Propiedad = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionSituacion_Actual_Tierras Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionSituacion_Actual_Tierras
                fila.Id_Situacion_Actual_Tierras = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionTipo_bien_rural Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionTipo_bien_rural
                fila.Id_Tipo_Bien_Rural = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionTipo_Familia_desplazada Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionTipo_Familia_desplazada
                fila.Id_Tipo_Familia_desplazada = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionVulnerables_NoDesplazada Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionVulnerables_NoDesplazada
                fila.Id_Tipo_Familia_desplazada = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracionVulnerabilidad Is Nothing Then
            For Each fila As Declaracion_VulnerabilidadBrl In objListDeclaracionVulnerabilidad
                fila.Id_Factor_Vulnerabilidad = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListPersonas_Educacion_Estudia_Actualmente Is Nothing Then
            For Each fila As Personas_EducacionBrl In objListPersonas_Educacion_Estudia_Actualmente
                fila.Id_Certificado_Matricula = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListPersonas_Educacion_Motivo_NoEstudia Is Nothing Then
            For Each fila As Personas_EducacionBrl In objListPersonas_Educacion_Motivo_NoEstudia
                fila.Id_Estudia_Actualmente = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListPersonas_Educacion_Certificado_Matricula Is Nothing Then
            For Each fila As Personas_EducacionBrl In objListPersonas_Educacion_Certificado_Matricula
                fila.Id_grado_escolar = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If



        If Not objListPersonas_Educacion_Seguimiento Is Nothing Then
            For Each fila As Personas_EducacionBrl In objListPersonas_Educacion_Seguimiento
                fila.Id_Motivo_NoEstudia = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListPersonas_Educacion_grado_escolar Is Nothing Then
            For Each fila As Personas_EducacionBrl In objListPersonas_Educacion_grado_escolar
                fila.Id_Seguimiento = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not Me.objListDeclaracionConcejoExpulsor Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionConcejoExpulsor
                fila.Id_Concejo_Expulsor = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not Me.objListDeclaracionSolicitoAyuda Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionConcejoExpulsor
                fila.Id_Solicito_Ayuda = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not Me.objListDeclaracionLugarFuente Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionConcejoExpulsor
                fila.Id_Lugar_fuente = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not Me.objListDeclaracionEnLinea Is Nothing Then
            For Each fila As DeclaracionBrl In objListDeclaracionConcejoExpulsor
                fila.Id_EnLinea = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracion_UnidadesUnidad Is Nothing Then
            For Each fila As Declaracion_UnidadesBrl In objListDeclaracion_UnidadesUnidad
                fila.Id_Unidad = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If



        If Not objListDeclaracion_UnidadesEstadoUnidad Is Nothing Then
            For Each fila As Declaracion_UnidadesBrl In objListDeclaracion_UnidadesEstadoUnidad
                fila.Id_EstadoUnidad = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If


        RaiseEvent Saved()

    End Sub

    Public Sub Eliminar()
        Dim totalHijos As Long = 0
        If Me.ID <> Nothing Then

            RaiseEvent Deleting()
            totalHijos += Declaracion_Ayudas_Dadas.Count
            totalHijos += Declaracion_Entidades_Ayuda.Count
            totalHijos += Declaracion_Fuentes_Ingreso.Count
            totalHijos += Declaracion_Obtencion_Agua.Count
            totalHijos += Me.DeclaracionFuente.Count
            totalHijos += Me.DeclaracionMunicipioExpulsor.Count
            totalHijos += Me.DeclaracionHa_Recibido_Ayuda.Count
            totalHijos += Me.DeclaracionParentescoMuerte.Count
            totalHijos += Me.DeclaracionHa_Muerto_Alguien.Count
            totalHijos += Me.DeclaracionVelar_Enterrar.Count
            totalHijos += Me.DeclaracionEnfermedad.Count
            totalHijos += Me.DeclaracionLlegada_Sexual_Miembro.Count
            totalHijos += Me.DeclaracionHa_Regresado.Count
            totalHijos += Me.DeclaracionAplico_Reparaciones.Count
            totalHijos += Me.DeclaracionLlegada_Sexual.Count
            totalHijos += Me.DeclaracionLlegada_Insultos_Usted.Count
            totalHijos += Me.DeclaracionRazon_No_Aplico.Count
            totalHijos += Me.DeclaracionMotivo_Muerte.Count
            totalHijos += Me.DeclaracionLlegada_Golpes.Count
            totalHijos += Me.DeclaracionEstado_Aplicacion.Count
            totalHijos += Me.DeclaracionLlegada_golpes_Miembro.Count
            totalHijos += Me.DeclaracionParentesco_Desaparecido.Count
            totalHijos += Me.DeclaracionTiene_Desaparecido.Count
            totalHijos += Me.DeclaracionReporto.Count
            totalHijos += Me.DeclaracionHa_Redibido_Ayuda_Despues.Count
            totalHijos += Me.DeclaracionLlegada_Sexual_Usted.Count
            totalHijos += Me.DeclaracionMotivo_No_Aplico.Count
            totalHijos += Me.DeclaracionLlegada_Golpes_Usted.Count
            totalHijos += Me.DeclaracionOido_Mesa_Desplazados.Count
            totalHijos += Me.DeclaracionLlegada_Insultos.Count
            totalHijos += Me.DeclaracionEstatus_Aplicacion_Despues.Count
            totalHijos += Me.DeclaracionPertenece_Asociacion.Count
            totalHijos += Me.DeclaracionRetornaria.Count
            totalHijos += Me.DeclaracionEsta_Trabajando.Count
            totalHijos += Me.DeclaracionEntidad_Legal.Count
            totalHijos += Me.DeclaracionExplicacion_Retorno.Count
            totalHijos += Me.DeclaracionHa_Declarado_Antes.Count
            totalHijos += Me.DeclaracionLlegada_Insultos_Miembro.Count
            totalHijos += Me.Declaracion_Trabajos.Count

            totalHijos += Entradas_Detalle_Capacidad.Count
            totalHijos += Entradas.Count
            totalHijos += Personas_Contactos.Count
            totalHijos += PersonasMotivo_NoEstudio.Count
            totalHijos += PersonasTipo_Identificacion.Count
            totalHijos += PersonasDiscapacitado.Count
            totalHijos += PersonasGenero.Count
            totalHijos += PersonasParentesco.Count
            totalHijos += PersonasEstudia_Actualmente.Count
            totalHijos += PersonasEstudia_Antes.Count
            totalHijos += PersonasUltimo_Grado.Count
            totalHijos += Salidas_Detalle_Capacidad.Count
            totalHijos += DeclaracionGrupos.Count
            totalHijos += DeclaracionBeneficiadoProgramas.Count
            totalHijos += DeclaracionAtender.Count
            totalHijos += DeclaracionMotivo_Noatender.Count
            totalHijos += Declaracion_Programas_Ayuda.Count
            totalHijos += DeclaracionConcejoExpulsor.Count
            totalHijos += DeclaracionSolicito_Ayuda.Count
            totalHijos += Declaracionlugar_Fuente.Count
            totalHijos += DeclaracionEnLinea.Count

            totalHijos += GestantesControl_Prenatal.Count
            totalHijos += GestantesIngesta_Micronutrientes.Count
            totalHijos += GestantesRemitidas.Count
            totalHijos += GestantesVisita_Domiciliaria.Count
            totalHijos += Salud_Remisiones.Count
            totalHijos += SaludCrecimiento_Desarrollo.Count
            totalHijos += SaludLactancia_Lactando.Count
            totalHijos += SaludMotivo_No_Vacunados.Count
            totalHijos += SaludVitaminas_Desparasitacion.Count
            totalHijos += SaludVitaminas_Suplementacion.Count
            totalHijos += SaludVacunacion_Carnet.Count
            totalHijos += SaludRazon_No_Carnet.Count
            totalHijos += SaludEsquema_Vacunacion_Completo.Count
            totalHijos += SaludRazon_No_Vacunacion_Completo.Count
            totalHijos += SaludNinos_Vacunados.Count
            totalHijos += Salud_ValoracionRecuperado.Count
            totalHijos += Declaracion_Bienes.Count
            totalHijos += Declaracion_Causas_Desplazamiento.Count
            totalHijos += Declaracion_Causas_NoEstudio.Count
            totalHijos += Declaracion_Danos_Familia.Count
            totalHijos += Declaracion_Instituciones_Confianza.Count
            totalHijos += Declaracion_Nivel_Educativo.Count
            totalHijos += Declaracion_Servicio_salud.Count

            totalHijos += Personas_Educacion_Certificado_Matricula.Count
            totalHijos += Personas_Educacion_Estudia_Actualmente.Count
            totalHijos += Personas_Educacion_Motivo_NoEstudia.Count
            totalHijos += Personas_Educacion_Seguimiento.Count
            totalHijos += Personas_Educacion_grado_escolar.Count

            totalHijos += Declaracion_UnidadesUnidad.Count
            totalHijos += Declaracion_UnidadesEstadoUnidad.Count

            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")

            SubTablasDAL.Eliminar(Me.ID)

            RaiseEvent Deleted()

        End If
    End Sub

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As SubTablasBrl
        Dim objSubTablas As New SubTablasBrl
        With objSubTablas
            .ID = fila("Id")
            .Id_Tabla = isDBNullToNothing(fila("Id_Tabla"))
            .Descripcion = isDBNullToNothing(fila("Descripcion"))
            .Id_Padre = isDBNullToNothing(fila("Id_Padre"))
            .Fecha_Creacion = isDBNullToNothing(fila("Fecha_Creacion"))
            .Id_Usuario_Creacion = isDBNullToNothing(fila("Id_Usuario_Creacion"))
            .Fecha_Modificacion = isDBNullToNothing(fila("Fecha_Modificacion"))
            .Id_Usuario_Modificacion = isDBNullToNothing(fila("Id_Usuario_Modificacion"))
            .Orden = isDBNullToNothing(fila("Orden"))
            .Activo = isDBNullToNothing(fila("Activo"))
        End With
        Return objSubTablas
    End Function

    Public Shared Event LoadingSubTablasList(ByVal LoadType As String)
    Public Shared Event LoadedSubTablasList(ByVal target As List(Of SubTablasBrl), ByVal LoadType As String)

    Public Shared Function CargarTodos() As List(Of SubTablasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SubTablasBrl)

        RaiseEvent LoadingSubTablasList("CargarTodos")

        dsDatos = SubTablasDAL.CargarTodos()

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSubTablasList(lista, "CargarTodos")

        Return lista

    End Function

    Public Shared Function CargarBusqueda(ByVal idtabla As Integer, ByVal descripcion As String, ByVal idpadre As Integer) As List(Of SubTablasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SubTablasBrl)
        dsDatos = SubTablasDAL.CargarPorBusqueda(idtabla, descripcion, idpadre)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Event LoadingPorId(ByVal id As Int32)
    Public Shared Event LoadedPorId(ByVal target As SubTablasBrl)

    Public Shared Function CargarPorID(ByVal ID As Int32) As SubTablasBrl

        Dim dsDatos As System.Data.DataSet
        Dim objSubTablas As SubTablasBrl = Nothing

        dsDatos = SubTablasDAL.CargarPorID(ID)

        If dsDatos.Tables(0).Rows.Count <> 0 Then objSubTablas = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))

        Return objSubTablas

    End Function

    Public Shared Function CargarPorId_Tabla(ByVal Id_Tabla As Int32) As List(Of SubTablasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SubTablasBrl)
        dsDatos = SubTablasDAL.CargarPorId_Tabla(Id_Tabla)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function

    Public Shared Function CargarPorGruposLIbres() As List(Of SubTablasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SubTablasBrl)
        dsDatos = SubTablasDAL.CargarPorGruposLibres
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function

    Public Shared Function CargarTiposFamilia(ByVal id_regional As Integer, ByVal id_grupo As Integer, ByVal Fecha_inicial As String, ByVal Fecha_Final As String) As List(Of SubTablasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SubTablasBrl)
        dsDatos = SubTablasDAL.CargarTiposFamilia(id_regional, id_grupo, Fecha_inicial, Fecha_Final)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function

    Public Shared Function CargarPorId_Padre(ByVal Id_Padre As Int32) As List(Of SubTablasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SubTablasBrl)
        dsDatos = SubTablasDAL.CargarPorId_Padre(Id_Padre)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function

    Public Shared Function CargarPorId_TablaPadre(ByVal Id_Tabla As Int32, ByVal Id_Padre As Int32) As List(Of SubTablasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SubTablasBrl)
        dsDatos = SubTablasDAL.CargarPorId_TablaPadre(Id_Tabla, Id_Padre)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function

    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As Int32) As List(Of SubTablasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SubTablasBrl)
        dsDatos = SubTablasDAL.CargarPorId_Usuario_Creacion(Id_Usuario_Creacion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function

    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As Int32) As List(Of SubTablasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SubTablasBrl)
        dsDatos = SubTablasDAL.CargarPorId_Usuario_Modificacion(Id_Usuario_Modificacion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function

    Public Shared Function CargarPorId_Activo(ByVal Activo As Int32) As List(Of SubTablasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SubTablasBrl)
        dsDatos = SubTablasDAL.CargarPorActivo(Activo)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function

    Public Shared Function CargarPorId_Regional(ByVal Id_Regional As Int32) As List(Of SubTablasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SubTablasBrl)
        dsDatos = SubTablasDAL.CargarPorId_Regional(Id_Regional)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function

    Public Shared Function CargarPorGruposSinAsignar(ByVal Id_Lugar_Entrega As Int32) As List(Of SubTablasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SubTablasBrl)
        dsDatos = SubTablasDAL.CargarPorGruposSinAsignar(Id_Lugar_Entrega)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function


End Class


