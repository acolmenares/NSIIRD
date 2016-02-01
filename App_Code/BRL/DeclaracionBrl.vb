Imports ingNovar.Utilidades2
Imports System.data
Imports System.Collections.Generic
Imports SeguridadUsuarios

Partial Public Class DeclaracionBrl

    Private _Id As Int32
    Private _Id_Fuente As Int32
    Private _Fecha_Declaracion As DateTime
    Private _Gestantes As Int32
    Private _Menores_Ninos As Int32
    Private _Menores_Ninas As Int32
    Private _Recien_Nacidos As Int32
    Private _Lactantes As Int32
    Private _Resto_Nucleo As Int32
    Private _Fecha_Desplazamiento As DateTime
    Private _Id_Municipio_Expulsor As Int32
    Private _Vereda_Desplazamiento As String
    Private _Fecha_Valoracion As DateTime
    Private _Id_Ha_Regresado As Int32
    Private _Id_Retornaria As Int32
    Private _Id_Explicacion_Retorno As Int32
    Private _Id_Ha_Declarado_Antes As Int32
    Private _Id_Ha_Recibido_Ayuda As Int32
    Private _Id_Ha_Muerto_Alguien As Int32
    Private _Cuantos_Muertos As Int32
    Private _Cuantos_Muertos_Menores As Int32
    Private _Id_Motivo_Muerte As Int32
    Private _Id_Parentesco_Muerte As Int32
    Private _Id_Enfermedad As Int32
    Private _Id_Velar_Enterrar As Int32
    Private _Id_Tiene_Desaparecido As Int32
    Private _Id_Parentesco_Desaparecido As Int32
    Private _Id_Reporto As Int32
    Private _Id_Entidad_Legal As Int32
    Private _Id_Aplico_Reparaciones As Int32
    Private _Dias_Aplico As Int32
    Private _Id_Estado_Aplicacion As Int32
    Private _Id_Motivo_No_Aplico As Int32
    Private _Id_Llegada_Insultos As Int32
    Private _Id_Llegada_Insultos_Usted As Int32
    Private _Id_Llegada_Insultos_Miembro As Int32
    Private _Llegada_Insultos_Agresor As String
    Private _Id_Llegada_Sexual As Int32
    Private _Id_Llegada_Sexual_Usted As Int32
    Private _Id_Llegada_Sexual_Miembro As Int32
    Private _Llegada_Sexual_Agresor As String
    Private _Id_Llegada_Golpes As Int32
    Private _Id_Llegada_Golpes_Usted As Int32
    Private _Id_Llegada_Golpes_Miembro As Int32
    Private _Llegada_Golpes_Agresor As String

    Private _Fecha_Segunda_Encuesta As DateTime
    Private _Id_Ha_Redibido_Ayuda_Despues As Int32
    Private _Dias_Aplico_Despues As Int32
    Private _Id_Estatus_Aplicacion_Despues As Int32
    Private _Id_Razon_No_Aplico As Int32
    Private _Id_Oido_Mesa_Desplazados As Int32
    Private _Id_Pertenece_Asociacion As Int32
    Private _Cual_Asociacion As String
    Private _Id_Esta_Trabajando As Int32
    Private _Id_Beneficiado_programas As Int32

    Private _Id_Grupo As Int32
    Private _Id_Regional As Int32
    Private _Id_Motivo_Noatender As Int32
    Private _Id_Tipo_Tenencia_Vivienda As Int32
    Private _Id_Cuantas_Habitaciones As Int32
    Private _Id_Cuantas_Personas_Vivienda As Int32
    Private _Id_Cuantas_Personas_Habitacion As Int32
    Private _Id_Materiales_Vivienda As Int32
    Private _Id_Forma_Declaracion As Int32
    Private _Id_Departamento_Expulsor As Int32
    Private _Id_Cuantos_Desplazamientos As Int32
    Private _Lugar_Desplazamiento As String
    Private _Fecha_Desplazamiento_Anterior As DateTime
    Private _Id_Motivo_Desplazamiento As Int32
    Private _Id_Cuanto_Tiempo_Demoro As Int32
    Private _Id_Motivo_Demora As Int32
    Private _Id_Motivo_NoDeclaro_Municipio As Int32
    Private _Id_Vivio_Cabezera_Municipal As Int32
    Private _Id_Tiempo_Casco_Urbano As Int32
    Private _Id_Entidad_Inicial_Atencion As Int32
    Private _Id_Recibio_Ayuda_Entidad_Inicial As Int32
    Private _Id_Como_Fue_Atencion As Int32
    Private _Id_Como_Brindar_Atencion As Int32
    Private _Promedio_Ingresos_Mensuales As Double
    Private _Fecha_Muerte As DateTime
    Private _Cuantos_Familiares_Desaparecidos As Int32
    Private _Id_Porque_No_Reporto As Int32
    Private _Id_Despues_Hijos_617 As Int32
    Private _Cuantos_Despues_Hijos As Int32
    Private _Cuantos_Despues_Hijos_Estudian As Int32
    Private _Id_Tipo_Bien_Rural As Int32
    Private _Id_Documento_Propiedad As Int32
    Private _Id_Destino_Tierra As Int32
    Private _Id_Situacion_Actual_Tierras As Int32
    Private _Observaciones As String
    Private _Id_Despues_Afiliado_Regimen_Subsidiado As Int32
    Private _Cuantos_Despues_Afiliado_Regimen_Subsidiado As Int32
    Private _Id_Despues_Afiliado_Regimen_Contributivo As Int32
    Private _Cuantos_Despues_Afiliado_Regimen_Contributivo As Int32
    Private _Id_Despues_Afiliado_Sisben As Int32
    Private _Cuantos_Despues_Afiliado_Sisben As Int32
    Private _Id_ley_Reparacion As Int32
    Private _Id_Es_Del_Municipio As Int32
    Private _Motivo_Desplazamiento As String
    Private _Fecha_Ingreso_Registro As DateTime
    Private _Tipo_Declaracion As Int32
    Private _Horario As String
    Private _Id_Tipo_Familia_desplazada As Int32
    Private _Id_Vulnerables_NoDesplazada As Int32
    Private _Motivo_Remision As String
    Private _Id_Solicito_Ayuda As Int32
    Private _Id_Concejo_Expulsor As Int32
    Private _Id_Lugar_fuente As Int32
    Private _Id_EnLinea As Int32
    Private _Id_Agua_Potable As Int32
    Private _Id_Tiene_documento As Int32
    Private _Id_Tipo_Familia_No_Desplazada As Int32
    Private _Id_Atender As Int32
    Private _Fecha_Radicacion As DateTime
    Private _Numero_Declaracion As String
    Private _Fecha_Creacion As DateTime
    Private _Id_Usuario_Creacion As Int32
    Private _Fecha_Modificacion As DateTime
    Private _Id_Usuario_Modificacion As Int32
    Private _Fecha_Cierre As DateTime
    Private _Cierre As Boolean
    Private _Id_Familias_Accion As Int32
    Private _Municipio_Familias_Accion As String
    Private _Id_Red_Unidos As Int32
    Private _Municipio_Unidos As String
    Private _Id_VBG_general As Int32
    Private _VBG_General_Agresor As String
    Private _Id_Ha_Muerto_Despues As Int32
    Private _Id_Solicito_Atencion_Psicologica As Int32
    Private _Id_Afectado_Desplazamiento As Int32
    Private _Id_Emociones As Int32
    Private _Id_Tipo_Adiccion As Int32
    Private _Id_Adiccion_Alcohol As Int32
    Private _Id_Adiccion_Droga As Int32
    Private _Id_Municipio_Faccion As Int32

    Private objListDeclaracion_Entidades_Ayuda As List(Of Declaracion_Entidades_AyudaBrl)
    Private objListDeclaracion_Programas_Ayuda As List(Of Declaracion_Programas_AyudaBrl)
    Private objListDeclaracion_Fuentes_Ingreso As List(Of Declaracion_Fuentes_IngresoBrl)
    Private objListDeclaracion_Obtencion_Agua As List(Of Declaracion_Obtencion_AguaBrl)
    Private objListDeclaracion_Trabajos As List(Of Declaracion_TrabajosBrl)
    Private objListDeclaracion_Ayudas_Dadas As List(Of Declaracion_Ayudas_DadasBrl)
    Private objListPersonas As List(Of PersonasBrl)
    Private objListPersonasEducacion As List(Of PersonasBrl)
    Private objListPersonasEducacionPendiente As List(Of PersonasBrl)
    Private objListPersonasBeneficiarios As List(Of PersonasBrl)
    Private objListDeclaracion_Bienes As List(Of Declaracion_BienesBrl)
    Private objListDeclaracion_Causas_Desplazamiento As List(Of Declaracion_Causas_DesplazamientoBrl)
    Private objListDeclaracion_Causas_NoEstudio As List(Of Declaracion_Causas_NoEstudioBrl)
    Private objListDeclaracion_Danos_Familia As List(Of Declaracion_Danos_FamiliaBrl)
    Private objListDeclaracion_Instituciones_Confianza As List(Of Declaracion_Instituciones_ConfianzaBrl)
    Private objListDeclaracion_Nivel_Educativo As List(Of Declaracion_Nivel_EducativoBrl)
    Private objListDeclaracion_Servicio_salud As List(Of Declaracion_Servicio_saludBrl)
    Private objListDeclaracion_Vulnerabilidad As List(Of Declaracion_VulnerabilidadBrl)
    Private objListDeclaracion_Unidades As List(Of Declaracion_UnidadesBrl)
    Private objListEstadosDeclaracion As List(Of Declaracion_EstadosBrl)

    Private objListDeclaracion_Muertos As List(Of Declaracion_MuertosBrl)
    Private objListDeclaracion_Desaparecidos As List(Of Declaracion_DesaparecidosBrl)
    Private objListDeclaracion_Psicosocial As List(Of Declaracion_PsicosocialBrl)
    Private objListDeclaracion_Personas_Ayuda As List(Of Declaracion_Personas_AyudaBrl)
    Private objListDeclaracion_Apoyo_Ayuda As List(Of Declaracion_Apoyo_AyudaBrl)
    Private objListDeclaracion_Seguimientos As List(Of Declaracion_SeguimientosBrl)

    Private objListDeclaracion_PAARI As List(Of Declaracion_PAARIBrl)

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

    Public Event Id_FuenteChanging(ByVal Value As Int32)
    Public Event Id_FuenteChanged()
	
    Public Property Id_Fuente() As Int32
        Get
            Return Me._Id_Fuente
        End Get
        Set(ByVal Value As Int32)
            If _Id_Fuente <> Value Then
                RaiseEvent Id_FuenteChanging(Value)
				Me._Id_Fuente = Value
                RaiseEvent Id_FuenteChanged()
            End If
        End Set
    End Property

    Public Event Fecha_DeclaracionChanging(ByVal Value As DateTime)
    Public Event Fecha_DeclaracionChanged()
	
    Public Property Fecha_Declaracion() As DateTime
        Get
            Return Me._Fecha_Declaracion
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_Declaracion <> Value Then
                RaiseEvent Fecha_DeclaracionChanging(Value)
				Me._Fecha_Declaracion = Value
                RaiseEvent Fecha_DeclaracionChanged()
            End If
        End Set
    End Property

    Public Event GestantesChanging(ByVal Value As Int32)
    Public Event GestantesChanged()
	
    Public Property Gestantes() As Int32
        Get
            Return Me._Gestantes
        End Get
        Set(ByVal Value As Int32)
            If _Gestantes <> Value Then
                RaiseEvent GestantesChanging(Value)
				Me._Gestantes = Value
                RaiseEvent GestantesChanged()
            End If
        End Set
    End Property

    Public Event MenoresChanging(ByVal Value As Int32)
    Public Event MenoresChanged()
	
    Public Property Menores_Ninos() As Int32
        Get
            Return Me._Menores_Ninos
        End Get
        Set(ByVal Value As Int32)
            If _Menores_Ninos <> Value Then
                RaiseEvent MenoresChanging(Value)
                Me._Menores_Ninos = Value
                RaiseEvent MenoresChanged()
            End If
        End Set
    End Property

    Public Property Menores_Ninas() As Int32
        Get
            Return Me._Menores_Ninas
        End Get
        Set(ByVal Value As Int32)
            If _Menores_Ninas <> Value Then
                RaiseEvent MenoresChanging(Value)
                Me._Menores_Ninas = Value
                RaiseEvent MenoresChanged()
            End If
        End Set
    End Property

    Public Property Recien_Nacidos() As Int32
        Get
            Return Me._Recien_Nacidos
        End Get
        Set(ByVal Value As Int32)
            If _Recien_Nacidos <> Value Then
                Me._Recien_Nacidos = Value
            End If
        End Set
    End Property

    Public Property Lactantes() As Int32
        Get
            Return Me._Lactantes
        End Get
        Set(ByVal Value As Int32)
            If _Lactantes <> Value Then
                Me._Lactantes = Value
            End If
        End Set
    End Property

    Public Property Resto_Nucleo() As Int32
        Get
            Return Me._Resto_Nucleo
        End Get
        Set(ByVal Value As Int32)
            If _Resto_Nucleo <> Value Then
                Me._Resto_Nucleo = Value
            End If
        End Set
    End Property

    Public Event Fecha_DesplazamientoChanging(ByVal Value As DateTime)
    Public Event Fecha_DesplazamientoChanged()
	
    Public Property Fecha_Desplazamiento() As DateTime
        Get
            Return Me._Fecha_Desplazamiento
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_Desplazamiento <> Value Then
                RaiseEvent Fecha_DesplazamientoChanging(Value)
				Me._Fecha_Desplazamiento = Value
                RaiseEvent Fecha_DesplazamientoChanged()
            End If
        End Set
    End Property

    Public Event Id_Municipio_ExpulsorChanging(ByVal Value As Int32)
    Public Event Id_Municipio_ExpulsorChanged()
	
    Public Property Id_Municipio_Expulsor() As Int32
        Get
            Return Me._Id_Municipio_Expulsor
        End Get
        Set(ByVal Value As Int32)
            If _Id_Municipio_Expulsor <> Value Then
                RaiseEvent Id_Municipio_ExpulsorChanging(Value)
				Me._Id_Municipio_Expulsor = Value
                RaiseEvent Id_Municipio_ExpulsorChanged()
            End If
        End Set
    End Property

    Public Event Vereda_DesplazamientoChanging(ByVal Value As String)
    Public Event Vereda_DesplazamientoChanged()
	
    Public Property Vereda_Desplazamiento() As String
        Get
            Return Me._Vereda_Desplazamiento
        End Get
        Set(ByVal Value As String)
            If _Vereda_Desplazamiento <> Value Then
                RaiseEvent Vereda_DesplazamientoChanging(Value)
                Me._Vereda_Desplazamiento = Value
                RaiseEvent Vereda_DesplazamientoChanged()
            End If
        End Set
    End Property

    Public Event Fecha_ValoracionChanging(ByVal Value As DateTime)
    Public Event Fecha_valoracionChanged()
	
    Public Property Fecha_Valoracion() As DateTime
        Get
            Return Me._Fecha_Valoracion
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_valoracion <> Value Then
                RaiseEvent Fecha_ValoracionChanging(Value)
                Me._Fecha_valoracion = Value
                RaiseEvent Fecha_valoracionChanged()
            End If
        End Set
    End Property

    Public Event Id_Ha_RegresadoChanging(ByVal Value As Int32)
    Public Event Id_Ha_RegresadoChanged()
	
    Public Property Id_Ha_Regresado() As Int32
        Get
            Return Me._Id_Ha_Regresado
        End Get
        Set(ByVal Value As Int32)
            If _Id_Ha_Regresado <> Value Then
                RaiseEvent Id_Ha_RegresadoChanging(Value)
				Me._Id_Ha_Regresado = Value
                RaiseEvent Id_Ha_RegresadoChanged()
            End If
        End Set
    End Property

    Public Event Id_RetornariaChanging(ByVal Value As Int32)
    Public Event Id_RetornariaChanged()
	
    Public Property Id_Retornaria() As Int32
        Get
            Return Me._Id_Retornaria
        End Get
        Set(ByVal Value As Int32)
            If _Id_Retornaria <> Value Then
                RaiseEvent Id_RetornariaChanging(Value)
				Me._Id_Retornaria = Value
                RaiseEvent Id_RetornariaChanged()
            End If
        End Set
    End Property

    Public Event Id_Explicacion_RetornoChanging(ByVal Value As Int32)
    Public Event Id_Explicacion_RetornoChanged()
	
    Public Property Id_Explicacion_Retorno() As Int32
        Get
            Return Me._Id_Explicacion_Retorno
        End Get
        Set(ByVal Value As Int32)
            If _Id_Explicacion_Retorno <> Value Then
                RaiseEvent Id_Explicacion_RetornoChanging(Value)
				Me._Id_Explicacion_Retorno = Value
                RaiseEvent Id_Explicacion_RetornoChanged()
            End If
        End Set
    End Property

    Public Event Id_Ha_Declarado_AntesChanging(ByVal Value As Int32)
    Public Event Id_Ha_Declarado_AntesChanged()
	
    Public Property Id_Ha_Declarado_Antes() As Int32
        Get
            Return Me._Id_Ha_Declarado_Antes
        End Get
        Set(ByVal Value As Int32)
            If _Id_Ha_Declarado_Antes <> Value Then
                RaiseEvent Id_Ha_Declarado_AntesChanging(Value)
				Me._Id_Ha_Declarado_Antes = Value
                RaiseEvent Id_Ha_Declarado_AntesChanged()
            End If
        End Set
    End Property

    Public Event Id_Ha_Recibido_AyudaChanging(ByVal Value As Int32)
    Public Event Id_Ha_Recibido_AyudaChanged()
	
    Public Property Id_Ha_Recibido_Ayuda() As Int32
        Get
            Return Me._Id_Ha_Recibido_Ayuda
        End Get
        Set(ByVal Value As Int32)
            If _Id_Ha_Recibido_Ayuda <> Value Then
                RaiseEvent Id_Ha_Recibido_AyudaChanging(Value)
				Me._Id_Ha_Recibido_Ayuda = Value
                RaiseEvent Id_Ha_Recibido_AyudaChanged()
            End If
        End Set
    End Property

    Public Event Id_Ha_Muerto_AlguienChanging(ByVal Value As Int32)
    Public Event Id_Ha_Muerto_AlguienChanged()
	
    Public Property Id_Ha_Muerto_Alguien() As Int32
        Get
            Return Me._Id_Ha_Muerto_Alguien
        End Get
        Set(ByVal Value As Int32)
            If _Id_Ha_Muerto_Alguien <> Value Then
                RaiseEvent Id_Ha_Muerto_AlguienChanging(Value)
				Me._Id_Ha_Muerto_Alguien = Value
                RaiseEvent Id_Ha_Muerto_AlguienChanged()
            End If
        End Set
    End Property

    Public Event Cuantos_MuertosChanging(ByVal Value As Int32)
    Public Event Cuantos_MuertosChanged()
	
    Public Property Cuantos_Muertos() As Int32
        Get
            Return Me._Cuantos_Muertos
        End Get
        Set(ByVal Value As Int32)
            If _Cuantos_Muertos <> Value Then
                RaiseEvent Cuantos_MuertosChanging(Value)
				Me._Cuantos_Muertos = Value
                RaiseEvent Cuantos_MuertosChanged()
            End If
        End Set
    End Property

    Public Event Cuantos_Muertos_MenoresChanging(ByVal Value As Int32)
    Public Event Cuantos_Muertos_MenoresChanged()
	
    Public Property Cuantos_Muertos_Menores() As Int32
        Get
            Return Me._Cuantos_Muertos_Menores
        End Get
        Set(ByVal Value As Int32)
            If _Cuantos_Muertos_Menores <> Value Then
                RaiseEvent Cuantos_Muertos_MenoresChanging(Value)
				Me._Cuantos_Muertos_Menores = Value
                RaiseEvent Cuantos_Muertos_MenoresChanged()
            End If
        End Set
    End Property

    Public Event Id_Motivo_MuerteChanging(ByVal Value As Int32)
    Public Event Id_Motivo_MuerteChanged()
	
    Public Property Id_Motivo_Muerte() As Int32
        Get
            Return Me._Id_Motivo_Muerte
        End Get
        Set(ByVal Value As Int32)
            If _Id_Motivo_Muerte <> Value Then
                RaiseEvent Id_Motivo_MuerteChanging(Value)
				Me._Id_Motivo_Muerte = Value
                RaiseEvent Id_Motivo_MuerteChanged()
            End If
        End Set
    End Property

    Public Event Id_Parentesco_MuerteChanging(ByVal Value As Int32)
    Public Event Id_Parentesco_MuerteChanged()
	
    Public Property Id_Parentesco_Muerte() As Int32
        Get
            Return Me._Id_Parentesco_Muerte
        End Get
        Set(ByVal Value As Int32)
            If _Id_Parentesco_Muerte <> Value Then
                RaiseEvent Id_Parentesco_MuerteChanging(Value)
				Me._Id_Parentesco_Muerte = Value
                RaiseEvent Id_Parentesco_MuerteChanged()
            End If
        End Set
    End Property

    Public Event Id_EnfermedadChanging(ByVal Value As Int32)
    Public Event Id_EnfermedadChanged()
	
    Public Property Id_Enfermedad() As Int32
        Get
            Return Me._Id_Enfermedad
        End Get
        Set(ByVal Value As Int32)
            If _Id_Enfermedad <> Value Then
                RaiseEvent Id_EnfermedadChanging(Value)
				Me._Id_Enfermedad = Value
                RaiseEvent Id_EnfermedadChanged()
            End If
        End Set
    End Property

    Public Event Id_Velar_EnterrarChanging(ByVal Value As Int32)
    Public Event Id_Velar_EnterrarChanged()
	
    Public Property Id_Velar_Enterrar() As Int32
        Get
            Return Me._Id_Velar_Enterrar
        End Get
        Set(ByVal Value As Int32)
            If _Id_Velar_Enterrar <> Value Then
                RaiseEvent Id_Velar_EnterrarChanging(Value)
				Me._Id_Velar_Enterrar = Value
                RaiseEvent Id_Velar_EnterrarChanged()
            End If
        End Set
    End Property

    Public Event Id_Tiene_DesaparecidoChanging(ByVal Value As Int32)
    Public Event Id_Tiene_DesaparecidoChanged()
	
    Public Property Id_Tiene_Desaparecido() As Int32
        Get
            Return Me._Id_Tiene_Desaparecido
        End Get
        Set(ByVal Value As Int32)
            If _Id_Tiene_Desaparecido <> Value Then
                RaiseEvent Id_Tiene_DesaparecidoChanging(Value)
				Me._Id_Tiene_Desaparecido = Value
                RaiseEvent Id_Tiene_DesaparecidoChanged()
            End If
        End Set
    End Property

    Public Event Id_Parentesco_DesaparecidoChanging(ByVal Value As Int32)
    Public Event Id_Parentesco_DesaparecidoChanged()
	
    Public Property Id_Parentesco_Desaparecido() As Int32
        Get
            Return Me._Id_Parentesco_Desaparecido
        End Get
        Set(ByVal Value As Int32)
            If _Id_Parentesco_Desaparecido <> Value Then
                RaiseEvent Id_Parentesco_DesaparecidoChanging(Value)
				Me._Id_Parentesco_Desaparecido = Value
                RaiseEvent Id_Parentesco_DesaparecidoChanged()
            End If
        End Set
    End Property

    Public Event Id_ReportoChanging(ByVal Value As Int32)
    Public Event Id_ReportoChanged()
	
    Public Property Id_Reporto() As Int32
        Get
            Return Me._Id_Reporto
        End Get
        Set(ByVal Value As Int32)
            If _Id_Reporto <> Value Then
                RaiseEvent Id_ReportoChanging(Value)
				Me._Id_Reporto = Value
                RaiseEvent Id_ReportoChanged()
            End If
        End Set
    End Property

    Public Event Id_Entidad_LegalChanging(ByVal Value As Int32)
    Public Event Id_Entidad_LegalChanged()
	
    Public Property Id_Entidad_Legal() As Int32
        Get
            Return Me._Id_Entidad_Legal
        End Get
        Set(ByVal Value As Int32)
            If _Id_Entidad_Legal <> Value Then
                RaiseEvent Id_Entidad_LegalChanging(Value)
				Me._Id_Entidad_Legal = Value
                RaiseEvent Id_Entidad_LegalChanged()
            End If
        End Set
    End Property

    Public Event Id_Aplico_ReparacionesChanging(ByVal Value As Int32)
    Public Event Id_Aplico_ReparacionesChanged()
	
    Public Property Id_Aplico_Reparaciones() As Int32
        Get
            Return Me._Id_Aplico_Reparaciones
        End Get
        Set(ByVal Value As Int32)
            If _Id_Aplico_Reparaciones <> Value Then
                RaiseEvent Id_Aplico_ReparacionesChanging(Value)
				Me._Id_Aplico_Reparaciones = Value
                RaiseEvent Id_Aplico_ReparacionesChanged()
            End If
        End Set
    End Property

    Public Event Dias_AplicoChanging(ByVal Value As Int32)
    Public Event Dias_AplicoChanged()
	
    Public Property Dias_Aplico() As Int32
        Get
            Return Me._Dias_Aplico
        End Get
        Set(ByVal Value As Int32)
            If _Dias_Aplico <> Value Then
                RaiseEvent Dias_AplicoChanging(Value)
				Me._Dias_Aplico = Value
                RaiseEvent Dias_AplicoChanged()
            End If
        End Set
    End Property

    Public Event Id_Estado_AplicacionChanging(ByVal Value As Int32)
    Public Event Id_Estado_AplicacionChanged()
	
    Public Property Id_Estado_Aplicacion() As Int32
        Get
            Return Me._Id_Estado_Aplicacion
        End Get
        Set(ByVal Value As Int32)
            If _Id_Estado_Aplicacion <> Value Then
                RaiseEvent Id_Estado_AplicacionChanging(Value)
				Me._Id_Estado_Aplicacion = Value
                RaiseEvent Id_Estado_AplicacionChanged()
            End If
        End Set
    End Property

    Public Event Id_Motivo_No_AplicoChanging(ByVal Value As Int32)
    Public Event Id_Motivo_No_AplicoChanged()
	
    Public Property Id_Motivo_No_Aplico() As Int32
        Get
            Return Me._Id_Motivo_No_Aplico
        End Get
        Set(ByVal Value As Int32)
            If _Id_Motivo_No_Aplico <> Value Then
                RaiseEvent Id_Motivo_No_AplicoChanging(Value)
				Me._Id_Motivo_No_Aplico = Value
                RaiseEvent Id_Motivo_No_AplicoChanged()
            End If
        End Set
    End Property

    Public Event Id_Llegada_InsultosChanging(ByVal Value As Int32)
    Public Event Id_Llegada_InsultosChanged()
	
    Public Property Id_Llegada_Insultos() As Int32
        Get
            Return Me._Id_Llegada_Insultos
        End Get
        Set(ByVal Value As Int32)
            If _Id_Llegada_Insultos <> Value Then
                RaiseEvent Id_Llegada_InsultosChanging(Value)
				Me._Id_Llegada_Insultos = Value
                RaiseEvent Id_Llegada_InsultosChanged()
            End If
        End Set
    End Property

    Public Event Id_Llegada_Insultos_UstedChanging(ByVal Value As Int32)
    Public Event Id_Llegada_Insultos_UstedChanged()
	
    Public Property Id_Llegada_Insultos_Usted() As Int32
        Get
            Return Me._Id_Llegada_Insultos_Usted
        End Get
        Set(ByVal Value As Int32)
            If _Id_Llegada_Insultos_Usted <> Value Then
                RaiseEvent Id_Llegada_Insultos_UstedChanging(Value)
				Me._Id_Llegada_Insultos_Usted = Value
                RaiseEvent Id_Llegada_Insultos_UstedChanged()
            End If
        End Set
    End Property

    Public Event Id_Llegada_Insultos_MiembroChanging(ByVal Value As Int32)
    Public Event Id_Llegada_Insultos_MiembroChanged()
	
    Public Property Id_Llegada_Insultos_Miembro() As Int32
        Get
            Return Me._Id_Llegada_Insultos_Miembro
        End Get
        Set(ByVal Value As Int32)
            If _Id_Llegada_Insultos_Miembro <> Value Then
                RaiseEvent Id_Llegada_Insultos_MiembroChanging(Value)
				Me._Id_Llegada_Insultos_Miembro = Value
                RaiseEvent Id_Llegada_Insultos_MiembroChanged()
            End If
        End Set
    End Property

    Public Event Llegada_Insultos_AgresorChanging(ByVal Value As String)
    Public Event Llegada_Insultos_AgresorChanged()
	
    Public Property Llegada_Insultos_Agresor() As String
        Get
            Return Me._Llegada_Insultos_Agresor
        End Get
        Set(ByVal Value As String)
            If _Llegada_Insultos_Agresor <> Value Then
                RaiseEvent Llegada_Insultos_AgresorChanging(Value)
				Me._Llegada_Insultos_Agresor = Value
                RaiseEvent Llegada_Insultos_AgresorChanged()
            End If
        End Set
    End Property

    Public Event Id_Llegada_SexualChanging(ByVal Value As Int32)
    Public Event Id_Llegada_SexualChanged()
	
    Public Property Id_Llegada_Sexual() As Int32
        Get
            Return Me._Id_Llegada_Sexual
        End Get
        Set(ByVal Value As Int32)
            If _Id_Llegada_Sexual <> Value Then
                RaiseEvent Id_Llegada_SexualChanging(Value)
				Me._Id_Llegada_Sexual = Value
                RaiseEvent Id_Llegada_SexualChanged()
            End If
        End Set
    End Property

    Public Event Id_Llegada_Sexual_UstedChanging(ByVal Value As Int32)
    Public Event Id_Llegada_Sexual_UstedChanged()
	
    Public Property Id_Llegada_Sexual_Usted() As Int32
        Get
            Return Me._Id_Llegada_Sexual_Usted
        End Get
        Set(ByVal Value As Int32)
            If _Id_Llegada_Sexual_Usted <> Value Then
                RaiseEvent Id_Llegada_Sexual_UstedChanging(Value)
				Me._Id_Llegada_Sexual_Usted = Value
                RaiseEvent Id_Llegada_Sexual_UstedChanged()
            End If
        End Set
    End Property

    Public Event Id_Llegada_Sexual_MiembroChanging(ByVal Value As Int32)
    Public Event Id_Llegada_Sexual_MiembroChanged()
	
    Public Property Id_Llegada_Sexual_Miembro() As Int32
        Get
            Return Me._Id_Llegada_Sexual_Miembro
        End Get
        Set(ByVal Value As Int32)
            If _Id_Llegada_Sexual_Miembro <> Value Then
                RaiseEvent Id_Llegada_Sexual_MiembroChanging(Value)
				Me._Id_Llegada_Sexual_Miembro = Value
                RaiseEvent Id_Llegada_Sexual_MiembroChanged()
            End If
        End Set
    End Property

    Public Event Llegada_Sexual_AgresorChanging(ByVal Value As String)
    Public Event Llegada_Sexual_AgresorChanged()
	
    Public Property Llegada_Sexual_Agresor() As String
        Get
            Return Me._Llegada_Sexual_Agresor
        End Get
        Set(ByVal Value As String)
            If _Llegada_Sexual_Agresor <> Value Then
                RaiseEvent Llegada_Sexual_AgresorChanging(Value)
				Me._Llegada_Sexual_Agresor = Value
                RaiseEvent Llegada_Sexual_AgresorChanged()
            End If
        End Set
    End Property

    Public Event Id_Llegada_GolpesChanging(ByVal Value As Int32)
    Public Event Id_Llegada_GolpesChanged()
	
    Public Property Id_Llegada_Golpes() As Int32
        Get
            Return Me._Id_Llegada_Golpes
        End Get
        Set(ByVal Value As Int32)
            If _Id_Llegada_Golpes <> Value Then
                RaiseEvent Id_Llegada_GolpesChanging(Value)
				Me._Id_Llegada_Golpes = Value
                RaiseEvent Id_Llegada_GolpesChanged()
            End If
        End Set
    End Property

    Public Event Id_Llegada_Golpes_UstedChanging(ByVal Value As Int32)
    Public Event Id_Llegada_Golpes_UstedChanged()
	
    Public Property Id_Llegada_Golpes_Usted() As Int32
        Get
            Return Me._Id_Llegada_Golpes_Usted
        End Get
        Set(ByVal Value As Int32)
            If _Id_Llegada_Golpes_Usted <> Value Then
                RaiseEvent Id_Llegada_Golpes_UstedChanging(Value)
				Me._Id_Llegada_Golpes_Usted = Value
                RaiseEvent Id_Llegada_Golpes_UstedChanged()
            End If
        End Set
    End Property

    Public Event Id_Llegada_Golpes_MiembroChanging(ByVal Value As Int32)
    Public Event Id_Llegada_Golpes_MiembroChanged()
	
    Public Property Id_Llegada_Golpes_Miembro() As Int32
        Get
            Return Me._Id_Llegada_Golpes_Miembro
        End Get
        Set(ByVal Value As Int32)
            If _Id_Llegada_Golpes_Miembro <> Value Then
                RaiseEvent Id_Llegada_Golpes_MiembroChanging(Value)
				Me._Id_Llegada_Golpes_Miembro = Value
                RaiseEvent Id_Llegada_Golpes_MiembroChanged()
            End If
        End Set
    End Property

    Public Event Llegada_Golpes_AgresorChanging(ByVal Value As String)
    Public Event Llegada_Golpes_AgresorChanged()
	
    Public Property Llegada_Golpes_Agresor() As String
        Get
            Return Me._Llegada_Golpes_Agresor
        End Get
        Set(ByVal Value As String)
            If _Llegada_Golpes_Agresor <> Value Then
                RaiseEvent Llegada_Golpes_AgresorChanging(Value)
				Me._Llegada_Golpes_Agresor = Value
                RaiseEvent Llegada_Golpes_AgresorChanged()
            End If
        End Set
    End Property

    Public Event Fecha_Segunda_EncuestaChanging(ByVal Value As DateTime)
    Public Event Fecha_Segunda_EncuestaChanged()
	
    Public Property Fecha_Segunda_Encuesta() As DateTime
        Get
            Return Me._Fecha_Segunda_Encuesta
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_Segunda_Encuesta <> Value Then
                RaiseEvent Fecha_Segunda_EncuestaChanging(Value)
				Me._Fecha_Segunda_Encuesta = Value
                RaiseEvent Fecha_Segunda_EncuestaChanged()
            End If
        End Set
    End Property

    Public Event Id_Ha_Redibido_Ayuda_DespuesChanging(ByVal Value As Int32)
    Public Event Id_Ha_Redibido_Ayuda_DespuesChanged()
	
    Public Property Id_Ha_Redibido_Ayuda_Despues() As Int32
        Get
            Return Me._Id_Ha_Redibido_Ayuda_Despues
        End Get
        Set(ByVal Value As Int32)
            If _Id_Ha_Redibido_Ayuda_Despues <> Value Then
                RaiseEvent Id_Ha_Redibido_Ayuda_DespuesChanging(Value)
				Me._Id_Ha_Redibido_Ayuda_Despues = Value
                RaiseEvent Id_Ha_Redibido_Ayuda_DespuesChanged()
            End If
        End Set
    End Property

    Public Event Dias_Aplico_DespuesChanging(ByVal Value As Int32)
    Public Event Dias_Aplico_DespuesChanged()
	
    Public Property Dias_Aplico_Despues() As Int32
        Get
            Return Me._Dias_Aplico_Despues
        End Get
        Set(ByVal Value As Int32)
            If _Dias_Aplico_Despues <> Value Then
                RaiseEvent Dias_Aplico_DespuesChanging(Value)
				Me._Dias_Aplico_Despues = Value
                RaiseEvent Dias_Aplico_DespuesChanged()
            End If
        End Set
    End Property

    Public Event Id_Estatus_Aplicacion_DespuesChanging(ByVal Value As Int32)
    Public Event Id_Estatus_Aplicacion_DespuesChanged()
	
    Public Property Id_Estatus_Aplicacion_Despues() As Int32
        Get
            Return Me._Id_Estatus_Aplicacion_Despues
        End Get
        Set(ByVal Value As Int32)
            If _Id_Estatus_Aplicacion_Despues <> Value Then
                RaiseEvent Id_Estatus_Aplicacion_DespuesChanging(Value)
				Me._Id_Estatus_Aplicacion_Despues = Value
                RaiseEvent Id_Estatus_Aplicacion_DespuesChanged()
            End If
        End Set
    End Property

    Public Event Id_Razon_No_AplicoChanging(ByVal Value As Int32)
    Public Event Id_Razon_No_AplicoChanged()
	
    Public Property Id_Razon_No_Aplico() As Int32
        Get
            Return Me._Id_Razon_No_Aplico
        End Get
        Set(ByVal Value As Int32)
            If _Id_Razon_No_Aplico <> Value Then
                RaiseEvent Id_Razon_No_AplicoChanging(Value)
				Me._Id_Razon_No_Aplico = Value
                RaiseEvent Id_Razon_No_AplicoChanged()
            End If
        End Set
    End Property

    Public Event Id_Oido_Mesa_DesplazadosChanging(ByVal Value As Int32)
    Public Event Id_Oido_Mesa_DesplazadosChanged()
	
    Public Property Id_Oido_Mesa_Desplazados() As Int32
        Get
            Return Me._Id_Oido_Mesa_Desplazados
        End Get
        Set(ByVal Value As Int32)
            If _Id_Oido_Mesa_Desplazados <> Value Then
                RaiseEvent Id_Oido_Mesa_DesplazadosChanging(Value)
				Me._Id_Oido_Mesa_Desplazados = Value
                RaiseEvent Id_Oido_Mesa_DesplazadosChanged()
            End If
        End Set
    End Property

    Public Event Id_Pertenece_AsociacionChanging(ByVal Value As Int32)
    Public Event Id_Pertenece_AsociacionChanged()
	
    Public Property Id_Pertenece_Asociacion() As Int32
        Get
            Return Me._Id_Pertenece_Asociacion
        End Get
        Set(ByVal Value As Int32)
            If _Id_Pertenece_Asociacion <> Value Then
                RaiseEvent Id_Pertenece_AsociacionChanging(Value)
				Me._Id_Pertenece_Asociacion = Value
                RaiseEvent Id_Pertenece_AsociacionChanged()
            End If
        End Set
    End Property

    Public Event Cual_AsociacionChanging(ByVal Value As String)
    Public Event Cual_AsociacionChanged()
	
    Public Property Cual_Asociacion() As String
        Get
            Return Me._Cual_Asociacion
        End Get
        Set(ByVal Value As String)
            If _Cual_Asociacion <> Value Then
                RaiseEvent Cual_AsociacionChanging(Value)
				Me._Cual_Asociacion = Value
                RaiseEvent Cual_AsociacionChanged()
            End If
        End Set
    End Property

    Public Event Id_Esta_TrabajandoChanging(ByVal Value As Int32)
    Public Event Id_Esta_TrabajandoChanged()
	
    Public Property Id_Esta_Trabajando() As Int32
        Get
            Return Me._Id_Esta_Trabajando
        End Get
        Set(ByVal Value As Int32)
            If _Id_Esta_Trabajando <> Value Then
                RaiseEvent Id_Esta_TrabajandoChanging(Value)
				Me._Id_Esta_Trabajando = Value
                RaiseEvent Id_Esta_TrabajandoChanged()
            End If
        End Set
    End Property

    Public Event Id_Beneficiado_ProgramasChanging(ByVal Value As Int32)
    Public Event Id_Beneficiado_ProgramasChanged()

    Public Property Id_Beneficiado_Programas() As Int32
        Get
            Return Me._Id_Beneficiado_programas
        End Get
        Set(ByVal Value As Int32)
            If _Id_Beneficiado_programas <> Value Then
                RaiseEvent Id_Beneficiado_ProgramasChanging(Value)
                Me._Id_Beneficiado_programas = Value
                RaiseEvent Id_Beneficiado_ProgramasChanged()
            End If
        End Set
    End Property

    Public Event Id_GrupoChanging(ByVal Value As Int32)
    Public Event Id_GrupoChanged()

    Public Property Id_Grupo() As Int32
        Get
            Return Me._Id_Grupo
        End Get
        Set(ByVal Value As Int32)
            If _Id_Grupo <> Value Then
                RaiseEvent Id_GrupoChanging(Value)
                Me._Id_Grupo = Value
                RaiseEvent Id_GrupoChanged()
            End If
        End Set
    End Property

    Public Event Id_RegionalChanging(ByVal Value As Int32)
    Public Event Id_RegionalChanged()

    Public Property Id_Regional() As Int32
        Get
            Return Me._Id_Regional
        End Get
        Set(ByVal Value As Int32)
            If _Id_Regional <> Value Then
                RaiseEvent Id_RegionalChanging(Value)
                Me._Id_Regional = Value
                RaiseEvent Id_RegionalChanged()
            End If
        End Set
    End Property

    Public Event Id_Motivo_NoatenderChanging(ByVal Value As Int32)
    Public Event Id_Motivo_NoatenderChanged()

    Public Property Id_Motivo_Noatender() As Int32
        Get
            Return Me._Id_Motivo_Noatender
        End Get
        Set(ByVal Value As Int32)
            If _Id_Motivo_Noatender <> Value Then
                RaiseEvent Id_Motivo_NoatenderChanging(Value)
                Me._Id_Motivo_Noatender = Value
                RaiseEvent Id_Motivo_NoatenderChanged()
            End If
        End Set
    End Property

    Public Event Id_Tipo_Tenencia_ViviendaChanging(ByVal Value As Int32)
    Public Event Id_Tipo_Tenencia_ViviendaChanged()

    Public Property Id_Tipo_Tenencia_Vivienda() As Int32
        Get
            Return Me._Id_Tipo_Tenencia_Vivienda
        End Get
        Set(ByVal Value As Int32)
            If _Id_Tipo_Tenencia_Vivienda <> Value Then
                RaiseEvent Id_Tipo_Tenencia_ViviendaChanging(Value)
                Me._Id_Tipo_Tenencia_Vivienda = Value
                RaiseEvent Id_Tipo_Tenencia_ViviendaChanged()
            End If
        End Set
    End Property

    Public Event Id_Cuantas_HabitacionesChanging(ByVal Value As Int32)
    Public Event Id_Cuantas_HabitacionesChanged()

    Public Property Id_Cuantas_Habitaciones() As Int32
        Get
            Return Me._Id_Cuantas_Habitaciones
        End Get
        Set(ByVal Value As Int32)
            If _Id_Cuantas_Habitaciones <> Value Then
                RaiseEvent Id_Cuantas_HabitacionesChanging(Value)
                Me._Id_Cuantas_Habitaciones = Value
                RaiseEvent Id_Cuantas_HabitacionesChanged()
            End If
        End Set
    End Property

    Public Event Id_Cuantas_Personas_ViviendaChanging(ByVal Value As Int32)
    Public Event Id_Cuantas_Personas_ViviendaChanged()

    Public Property Id_Cuantas_Personas_Vivienda() As Int32
        Get
            Return Me._Id_Cuantas_Personas_Vivienda
        End Get
        Set(ByVal Value As Int32)
            If _Id_Cuantas_Personas_Vivienda <> Value Then
                RaiseEvent Id_Cuantas_Personas_ViviendaChanging(Value)
                Me._Id_Cuantas_Personas_Vivienda = Value
                RaiseEvent Id_Cuantas_Personas_ViviendaChanged()
            End If
        End Set
    End Property

    Public Event Id_Cuantas_Personas_HabitacionChanging(ByVal Value As Int32)
    Public Event Id_Cuantas_Personas_HabitacionChanged()

    Public Property Id_Cuantas_Personas_Habitacion() As Int32
        Get
            Return Me._Id_Cuantas_Personas_Habitacion
        End Get
        Set(ByVal Value As Int32)
            If _Id_Cuantas_Personas_Habitacion <> Value Then
                RaiseEvent Id_Cuantas_Personas_HabitacionChanging(Value)
                Me._Id_Cuantas_Personas_Habitacion = Value
                RaiseEvent Id_Cuantas_Personas_HabitacionChanged()
            End If
        End Set
    End Property

    Public Event Id_Materiales_ViviendaChanging(ByVal Value As Int32)
    Public Event Id_Materiales_ViviendaChanged()

    Public Property Id_Materiales_Vivienda() As Int32
        Get
            Return Me._Id_Materiales_Vivienda
        End Get
        Set(ByVal Value As Int32)
            If _Id_Materiales_Vivienda <> Value Then
                RaiseEvent Id_Materiales_ViviendaChanging(Value)
                Me._Id_Materiales_Vivienda = Value
                RaiseEvent Id_Materiales_ViviendaChanged()
            End If
        End Set
    End Property

    Public Event Id_Forma_DeclaracionChanging(ByVal Value As Int32)
    Public Event Id_Forma_DeclaracionChanged()

    Public Property Id_Forma_Declaracion() As Int32
        Get
            Return Me._Id_Forma_Declaracion
        End Get
        Set(ByVal Value As Int32)
            If _Id_Forma_Declaracion <> Value Then
                RaiseEvent Id_Forma_DeclaracionChanging(Value)
                Me._Id_Forma_Declaracion = Value
                RaiseEvent Id_Forma_DeclaracionChanged()
            End If
        End Set
    End Property

    Public Event Id_Departamento_ExpulsorChanging(ByVal Value As Int32)
    Public Event Id_Departamento_ExpulsorChanged()

    Public Property Id_Departamento_Expulsor() As Int32
        Get
            Return Me._Id_Departamento_Expulsor
        End Get
        Set(ByVal Value As Int32)
            If _Id_Departamento_Expulsor <> Value Then
                RaiseEvent Id_Departamento_ExpulsorChanging(Value)
                Me._Id_Departamento_Expulsor = Value
                RaiseEvent Id_Departamento_ExpulsorChanged()
            End If
        End Set
    End Property

    Public Event Id_Cuantos_DesplazamientosChanging(ByVal Value As Int32)
    Public Event Id_Cuantos_DesplazamientosChanged()

    Public Property Id_Cuantos_Desplazamientos() As Int32
        Get
            Return Me._Id_Cuantos_Desplazamientos
        End Get
        Set(ByVal Value As Int32)
            If _Id_Cuantos_Desplazamientos <> Value Then
                RaiseEvent Id_Cuantos_DesplazamientosChanging(Value)
                Me._Id_Cuantos_Desplazamientos = Value
                RaiseEvent Id_Cuantos_DesplazamientosChanged()
            End If
        End Set
    End Property

    Public Event Lugar_DesplazamientoChanging(ByVal Value As String)
    Public Event Lugar_DesplazamientoChanged()

    Public Property Lugar_Desplazamiento() As String
        Get
            Return Me._Lugar_Desplazamiento
        End Get
        Set(ByVal Value As String)
            If _Lugar_Desplazamiento <> Value Then
                RaiseEvent Lugar_DesplazamientoChanging(Value)
                Me._Lugar_Desplazamiento = Value
                RaiseEvent Lugar_DesplazamientoChanged()
            End If
        End Set
    End Property

    Public Event Fecha_Desplazamiento_AnteriorChanging(ByVal Value As DateTime)
    Public Event Fecha_Desplazamiento_AnteriorChanged()

    Public Property Fecha_Desplazamiento_Anterior() As DateTime
        Get
            Return Me._Fecha_Desplazamiento_Anterior
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_Desplazamiento_Anterior <> Value Then
                RaiseEvent Fecha_Desplazamiento_AnteriorChanging(Value)
                Me._Fecha_Desplazamiento_Anterior = Value
                RaiseEvent Fecha_Desplazamiento_AnteriorChanged()
            End If
        End Set
    End Property

    Public Event Id_Motivo_DesplazamientoChanging(ByVal Value As Int32)
    Public Event Id_Motivo_DesplazamientoChanged()

    Public Property Id_Motivo_Desplazamiento() As Int32
        Get
            Return Me._Id_Motivo_Desplazamiento
        End Get
        Set(ByVal Value As Int32)
            If _Id_Motivo_Desplazamiento <> Value Then
                RaiseEvent Id_Motivo_DesplazamientoChanging(Value)
                Me._Id_Motivo_Desplazamiento = Value
                RaiseEvent Id_Motivo_DesplazamientoChanged()
            End If
        End Set
    End Property

    Public Event Id_Cuanto_Tiempo_DemoroChanging(ByVal Value As Int32)
    Public Event Id_Cuanto_Tiempo_DemoroChanged()

    Public Property Id_Cuanto_Tiempo_Demoro() As Int32
        Get
            Return Me._Id_Cuanto_Tiempo_Demoro
        End Get
        Set(ByVal Value As Int32)
            If _Id_Cuanto_Tiempo_Demoro <> Value Then
                RaiseEvent Id_Cuanto_Tiempo_DemoroChanging(Value)
                Me._Id_Cuanto_Tiempo_Demoro = Value
                RaiseEvent Id_Cuanto_Tiempo_DemoroChanged()
            End If
        End Set
    End Property

    Public Event Id_Motivo_DemoraChanging(ByVal Value As Int32)
    Public Event Id_Motivo_DemoraChanged()

    Public Property Id_Motivo_Demora() As Int32
        Get
            Return Me._Id_Motivo_Demora
        End Get
        Set(ByVal Value As Int32)
            If _Id_Motivo_Demora <> Value Then
                RaiseEvent Id_Motivo_DemoraChanging(Value)
                Me._Id_Motivo_Demora = Value
                RaiseEvent Id_Motivo_DemoraChanged()
            End If
        End Set
    End Property

    Public Event Id_Motivo_NoDeclaro_MunicipioChanging(ByVal Value As Int32)
    Public Event Id_Motivo_NoDeclaro_MunicipioChanged()

    Public Property Id_Motivo_NoDeclaro_Municipio() As Int32
        Get
            Return Me._Id_Motivo_NoDeclaro_Municipio
        End Get
        Set(ByVal Value As Int32)
            If _Id_Motivo_NoDeclaro_Municipio <> Value Then
                RaiseEvent Id_Motivo_NoDeclaro_MunicipioChanging(Value)
                Me._Id_Motivo_NoDeclaro_Municipio = Value
                RaiseEvent Id_Motivo_NoDeclaro_MunicipioChanged()
            End If
        End Set
    End Property

    Public Event Id_Vivio_Cabezera_MunicipalChanging(ByVal Value As Int32)
    Public Event Id_Vivio_Cabezera_MunicipalChanged()

    Public Property Id_Vivio_Cabezera_Municipal() As Int32
        Get
            Return Me._Id_Vivio_Cabezera_Municipal
        End Get
        Set(ByVal Value As Int32)
            If _Id_Vivio_Cabezera_Municipal <> Value Then
                RaiseEvent Id_Vivio_Cabezera_MunicipalChanging(Value)
                Me._Id_Vivio_Cabezera_Municipal = Value
                RaiseEvent Id_Vivio_Cabezera_MunicipalChanged()
            End If
        End Set
    End Property

    Public Event Id_Tiempo_Casco_UrbanoChanging(ByVal Value As Int32)
    Public Event Id_Tiempo_Casco_UrbanoChanged()

    Public Property Id_Tiempo_Casco_Urbano() As Int32
        Get
            Return Me._Id_Tiempo_Casco_Urbano
        End Get
        Set(ByVal Value As Int32)
            If _Id_Tiempo_Casco_Urbano <> Value Then
                RaiseEvent Id_Tiempo_Casco_UrbanoChanging(Value)
                Me._Id_Tiempo_Casco_Urbano = Value
                RaiseEvent Id_Tiempo_Casco_UrbanoChanged()
            End If
        End Set
    End Property

    Public Event Id_Entidad_Inicial_AtencionChanging(ByVal Value As Int32)
    Public Event Id_Entidad_Inicial_AtencionChanged()

    Public Property Id_Entidad_Inicial_Atencion() As Int32
        Get
            Return Me._Id_Entidad_Inicial_Atencion
        End Get
        Set(ByVal Value As Int32)
            If _Id_Entidad_Inicial_Atencion <> Value Then
                RaiseEvent Id_Entidad_Inicial_AtencionChanging(Value)
                Me._Id_Entidad_Inicial_Atencion = Value
                RaiseEvent Id_Entidad_Inicial_AtencionChanged()
            End If
        End Set
    End Property

    Public Event Id_Recibio_Ayuda_Entidad_InicialChanging(ByVal Value As Int32)
    Public Event Id_Recibio_Ayuda_Entidad_InicialChanged()

    Public Property Id_Recibio_Ayuda_Entidad_Inicial() As Int32
        Get
            Return Me._Id_Recibio_Ayuda_Entidad_Inicial
        End Get
        Set(ByVal Value As Int32)
            If _Id_Recibio_Ayuda_Entidad_Inicial <> Value Then
                RaiseEvent Id_Recibio_Ayuda_Entidad_InicialChanging(Value)
                Me._Id_Recibio_Ayuda_Entidad_Inicial = Value
                RaiseEvent Id_Recibio_Ayuda_Entidad_InicialChanged()
            End If
        End Set
    End Property

    Public Event Id_Como_Fue_AtencionChanging(ByVal Value As Int32)
    Public Event Id_Como_Fue_AtencionChanged()

    Public Property Id_Como_Fue_Atencion() As Int32
        Get
            Return Me._Id_Como_Fue_Atencion
        End Get
        Set(ByVal Value As Int32)
            If _Id_Como_Fue_Atencion <> Value Then
                RaiseEvent Id_Como_Fue_AtencionChanging(Value)
                Me._Id_Como_Fue_Atencion = Value
                RaiseEvent Id_Como_Fue_AtencionChanged()
            End If
        End Set
    End Property

    Public Event Id_Como_Brindar_AtencionChanging(ByVal Value As Int32)
    Public Event Id_Como_Brindar_AtencionChanged()

    Public Property Id_Como_Brindar_Atencion() As Int32
        Get
            Return Me._Id_Como_Brindar_Atencion
        End Get
        Set(ByVal Value As Int32)
            If _Id_Como_Brindar_Atencion <> Value Then
                RaiseEvent Id_Como_Brindar_AtencionChanging(Value)
                Me._Id_Como_Brindar_Atencion = Value
                RaiseEvent Id_Como_Brindar_AtencionChanged()
            End If
        End Set
    End Property

    Public Event Promedio_Ingresos_MensualesChanging(ByVal Value As Double)
    Public Event Promedio_Ingresos_MensualesChanged()

    Public Property Promedio_Ingresos_Mensuales() As Double
        Get
            Return Me._Promedio_Ingresos_Mensuales
        End Get
        Set(ByVal Value As Double)
            If _Promedio_Ingresos_Mensuales <> Value Then
                RaiseEvent Promedio_Ingresos_MensualesChanging(Value)
                Me._Promedio_Ingresos_Mensuales = Value
                RaiseEvent Promedio_Ingresos_MensualesChanged()
            End If
        End Set
    End Property

    Public Event Fecha_MuerteChanging(ByVal Value As DateTime)
    Public Event Fecha_MuerteChanged()

    Public Property Fecha_Muerte() As DateTime
        Get
            Return Me._Fecha_Muerte
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_Muerte <> Value Then
                RaiseEvent Fecha_MuerteChanging(Value)
                Me._Fecha_Muerte = Value
                RaiseEvent Fecha_MuerteChanged()
            End If
        End Set
    End Property

    Public Event Cuantos_Familiares_DesaparecidosChanging(ByVal Value As Int32)
    Public Event Cuantos_Familiares_DesaparecidosChanged()

    Public Property Cuantos_Familiares_Desaparecidos() As Int32
        Get
            Return Me._Cuantos_Familiares_Desaparecidos
        End Get
        Set(ByVal Value As Int32)
            If _Cuantos_Familiares_Desaparecidos <> Value Then
                RaiseEvent Cuantos_Familiares_DesaparecidosChanging(Value)
                Me._Cuantos_Familiares_Desaparecidos = Value
                RaiseEvent Cuantos_Familiares_DesaparecidosChanged()
            End If
        End Set
    End Property

    Public Event Id_Porque_No_ReportoChanging(ByVal Value As Int32)
    Public Event Id_Porque_No_ReportoChanged()

    Public Property Id_Porque_No_Reporto() As Int32
        Get
            Return Me._Id_Porque_No_Reporto
        End Get
        Set(ByVal Value As Int32)
            If _Id_Porque_No_Reporto <> Value Then
                RaiseEvent Id_Porque_No_ReportoChanging(Value)
                Me._Id_Porque_No_Reporto = Value
                RaiseEvent Id_Porque_No_ReportoChanged()
            End If
        End Set
    End Property

    Public Event Id_Despues_Hijos_617Changing(ByVal Value As Int32)
    Public Event Id_Despues_Hijos_617Changed()

    Public Property Id_Despues_Hijos_617() As Int32
        Get
            Return Me._Id_Despues_Hijos_617
        End Get
        Set(ByVal Value As Int32)
            If _Id_Despues_Hijos_617 <> Value Then
                RaiseEvent Id_Despues_Hijos_617Changing(Value)
                Me._Id_Despues_Hijos_617 = Value
                RaiseEvent Id_Despues_Hijos_617Changed()
            End If
        End Set
    End Property

    Public Event Cuantos_Despues_HijosChanging(ByVal Value As Int32)
    Public Event Cuantos_Despues_HijosChanged()

    Public Property Cuantos_Despues_Hijos() As Int32
        Get
            Return Me._Cuantos_Despues_Hijos
        End Get
        Set(ByVal Value As Int32)
            If _Cuantos_Despues_Hijos <> Value Then
                RaiseEvent Cuantos_Despues_HijosChanging(Value)
                Me._Cuantos_Despues_Hijos = Value
                RaiseEvent Cuantos_Despues_HijosChanged()
            End If
        End Set
    End Property

    Public Event Cuantos_Despues_Hijos_EstudianChanging(ByVal Value As Int32)
    Public Event Cuantos_Despues_Hijos_EstudianChanged()

    Public Property Cuantos_Despues_Hijos_Estudian() As Int32
        Get
            Return Me._Cuantos_Despues_Hijos_Estudian
        End Get
        Set(ByVal Value As Int32)
            If _Cuantos_Despues_Hijos_Estudian <> Value Then
                RaiseEvent Cuantos_Despues_Hijos_EstudianChanging(Value)
                Me._Cuantos_Despues_Hijos_Estudian = Value
                RaiseEvent Cuantos_Despues_Hijos_EstudianChanged()
            End If
        End Set
    End Property

    Public Event Id_Tipo_Bien_RuralChanging(ByVal Value As Int32)
    Public Event Id_Tipo_Bien_RuralChanged()

    Public Property Id_Tipo_Bien_Rural() As Int32
        Get
            Return Me._Id_Tipo_Bien_Rural
        End Get
        Set(ByVal Value As Int32)
            If _Id_Tipo_Bien_Rural <> Value Then
                RaiseEvent Id_Tipo_Bien_RuralChanging(Value)
                Me._Id_Tipo_Bien_Rural = Value
                RaiseEvent Id_Tipo_Bien_RuralChanged()
            End If
        End Set
    End Property

    Public Event Id_Documento_PropiedadChanging(ByVal Value As Int32)
    Public Event Id_Documento_PropiedadChanged()

    Public Property Id_Documento_Propiedad() As Int32
        Get
            Return Me._Id_Documento_Propiedad
        End Get
        Set(ByVal Value As Int32)
            If _Id_Documento_Propiedad <> Value Then
                RaiseEvent Id_Documento_PropiedadChanging(Value)
                Me._Id_Documento_Propiedad = Value
                RaiseEvent Id_Documento_PropiedadChanged()
            End If
        End Set
    End Property

    Public Event Id_Destino_TierraChanging(ByVal Value As Int32)
    Public Event Id_Destino_TierraChanged()

    Public Property Id_Destino_Tierra() As Int32
        Get
            Return Me._Id_Destino_Tierra
        End Get
        Set(ByVal Value As Int32)
            If _Id_Destino_Tierra <> Value Then
                RaiseEvent Id_Destino_TierraChanging(Value)
                Me._Id_Destino_Tierra = Value
                RaiseEvent Id_Destino_TierraChanged()
            End If
        End Set
    End Property

    Public Event Id_Situacion_Actual_TierrasChanging(ByVal Value As Int32)
    Public Event Id_Situacion_Actual_TierrasChanged()

    Public Property Id_Situacion_Actual_Tierras() As Int32
        Get
            Return Me._Id_Situacion_Actual_Tierras
        End Get
        Set(ByVal Value As Int32)
            If _Id_Situacion_Actual_Tierras <> Value Then
                RaiseEvent Id_Situacion_Actual_TierrasChanging(Value)
                Me._Id_Situacion_Actual_Tierras = Value
                RaiseEvent Id_Situacion_Actual_TierrasChanged()
            End If
        End Set
    End Property

    Public Event ObservacionesChanging(ByVal Value As String)
    Public Event ObservacionesChanged()

    Public Property Observaciones() As String
        Get
            Return Me._Observaciones
        End Get
        Set(ByVal Value As String)
            If _Observaciones <> Value Then
                RaiseEvent ObservacionesChanging(Value)
                Me._Observaciones = Value
                RaiseEvent ObservacionesChanged()
            End If
        End Set
    End Property

    Public Event Id_Despues_Afiliado_Regimen_SubsidiadoChanging(ByVal Value As Int32)
    Public Event Id_Despues_Afiliado_Regimen_SubsidiadoChanged()

    Public Property Id_Despues_Afiliado_Regimen_Subsidiado() As Int32
        Get
            Return Me._Id_Despues_Afiliado_Regimen_Subsidiado
        End Get
        Set(ByVal Value As Int32)
            If _Id_Despues_Afiliado_Regimen_Subsidiado <> Value Then
                RaiseEvent Id_Despues_Afiliado_Regimen_SubsidiadoChanging(Value)
                Me._Id_Despues_Afiliado_Regimen_Subsidiado = Value
                RaiseEvent Id_Despues_Afiliado_Regimen_SubsidiadoChanged()
            End If
        End Set
    End Property

    Public Event Cuantos_Despues_Afiliado_Regimen_SubsidiadoChanging(ByVal Value As Int32)
    Public Event Cuantos_Despues_Afiliado_Regimen_SubsidiadoChanged()

    Public Property Cuantos_Despues_Afiliado_Regimen_Subsidiado() As Int32
        Get
            Return Me._Cuantos_Despues_Afiliado_Regimen_Subsidiado
        End Get
        Set(ByVal Value As Int32)
            If _Cuantos_Despues_Afiliado_Regimen_Subsidiado <> Value Then
                RaiseEvent Cuantos_Despues_Afiliado_Regimen_SubsidiadoChanging(Value)
                Me._Cuantos_Despues_Afiliado_Regimen_Subsidiado = Value
                RaiseEvent Cuantos_Despues_Afiliado_Regimen_SubsidiadoChanged()
            End If
        End Set
    End Property

    Public Event Id_Despues_Afiliado_Regimen_ContributivoChanging(ByVal Value As Int32)
    Public Event Id_Despues_Afiliado_Regimen_ContributivoChanged()

    Public Property Id_Despues_Afiliado_Regimen_Contributivo() As Int32
        Get
            Return Me._Id_Despues_Afiliado_Regimen_Contributivo
        End Get
        Set(ByVal Value As Int32)
            If _Id_Despues_Afiliado_Regimen_Contributivo <> Value Then
                RaiseEvent Id_Despues_Afiliado_Regimen_ContributivoChanging(Value)
                Me._Id_Despues_Afiliado_Regimen_Contributivo = Value
                RaiseEvent Id_Despues_Afiliado_Regimen_ContributivoChanged()
            End If
        End Set
    End Property

    Public Event Cuantos_Despues_Afiliado_Regimen_ContributivoChanging(ByVal Value As Int32)
    Public Event Cuantos_Despues_Afiliado_Regimen_ContributivoChanged()

    Public Property Cuantos_Despues_Afiliado_Regimen_Contributivo() As Int32
        Get
            Return Me._Cuantos_Despues_Afiliado_Regimen_Contributivo
        End Get
        Set(ByVal Value As Int32)
            If _Cuantos_Despues_Afiliado_Regimen_Contributivo <> Value Then
                RaiseEvent Cuantos_Despues_Afiliado_Regimen_ContributivoChanging(Value)
                Me._Cuantos_Despues_Afiliado_Regimen_Contributivo = Value
                RaiseEvent Cuantos_Despues_Afiliado_Regimen_ContributivoChanged()
            End If
        End Set
    End Property

    Public Event Id_Despues_Afiliado_SisbenChanging(ByVal Value As Int32)
    Public Event Id_Despues_Afiliado_SisbenChanged()

    Public Property Id_Despues_Afiliado_Sisben() As Int32
        Get
            Return Me._Id_Despues_Afiliado_Sisben
        End Get
        Set(ByVal Value As Int32)
            If _Id_Despues_Afiliado_Sisben <> Value Then
                RaiseEvent Id_Despues_Afiliado_SisbenChanging(Value)
                Me._Id_Despues_Afiliado_Sisben = Value
                RaiseEvent Id_Despues_Afiliado_SisbenChanged()
            End If
        End Set
    End Property

    Public Event Cuantos_Despues_Afiliado_SisbenChanging(ByVal Value As Int32)
    Public Event Cuantos_Despues_Afiliado_SisbenChanged()

    Public Property Cuantos_Despues_Afiliado_Sisben() As Int32
        Get
            Return Me._Cuantos_Despues_Afiliado_Sisben
        End Get
        Set(ByVal Value As Int32)
            If _Cuantos_Despues_Afiliado_Sisben <> Value Then
                RaiseEvent Cuantos_Despues_Afiliado_SisbenChanging(Value)
                Me._Cuantos_Despues_Afiliado_Sisben = Value
                RaiseEvent Cuantos_Despues_Afiliado_SisbenChanged()
            End If
        End Set
    End Property

    Public Property Id_ley_reparacion() As Int32
        Get
            Return Me._Id_ley_Reparacion
        End Get
        Set(ByVal Value As Int32)
            If _Id_ley_Reparacion <> Value Then
                Me._Id_ley_Reparacion = Value
            End If
        End Set
    End Property

    Public Property Id_Es_Del_Municipio() As Int32
        Get
            Return Me._Id_Es_Del_Municipio
        End Get
        Set(ByVal Value As Int32)
            If _Id_Es_Del_Municipio <> Value Then
                Me._Id_Es_Del_Municipio = Value
            End If
        End Set
    End Property

    Public Event Motivo_DesplazamientoChanging(ByVal Value As String)
    Public Event Motivo_DesplazamientoChanged()

    Public Property Motivo_Desplazamiento() As String
        Get
            Return Me._Motivo_Desplazamiento
        End Get
        Set(ByVal Value As String)
            If _Motivo_Desplazamiento <> Value Then
                RaiseEvent Motivo_DesplazamientoChanging(Value)
                Me._Motivo_Desplazamiento = Value
                RaiseEvent Motivo_DesplazamientoChanged()
            End If
        End Set
    End Property

    Public Property Fecha_Ingreso_Registro() As DateTime
        Get
            Return Me._Fecha_Ingreso_Registro
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_Ingreso_Registro <> Value Then
                Me._Fecha_Ingreso_Registro = Value
            End If
        End Set
    End Property

    Public Property Tipo_Declaracion() As Int32
        Get
            Return Me._Tipo_Declaracion
        End Get
        Set(ByVal Value As Int32)
            If _Tipo_Declaracion <> Value Then
                Me._Tipo_Declaracion = Value
            End If
        End Set
    End Property

    Public Property Horario() As String
        Get
            Return Me._Horario
        End Get
        Set(ByVal Value As String)
            If _Horario <> Value Then
                Me._Horario = Value
            End If
        End Set
    End Property

    Public Property Id_Tipo_Familia_desplazada() As Int32
        Get
            Return Me._Id_Tipo_Familia_desplazada
        End Get
        Set(ByVal Value As Int32)
            If _Id_Tipo_Familia_desplazada <> Value Then
                Me._Id_Tipo_Familia_desplazada = Value
            End If
        End Set
    End Property

    Public Property Id_Vulnerables_NoDesplazada() As Int32
        Get
            Return Me._Id_Vulnerables_NoDesplazada
        End Get
        Set(ByVal Value As Int32)
            If _Id_Vulnerables_NoDesplazada <> Value Then
                Me._Id_Vulnerables_NoDesplazada = Value
            End If
        End Set
    End Property

    Public Property Motivo_Remision() As String
        Get
            Return Me._Motivo_Remision
        End Get
        Set(ByVal Value As String)
            If _Motivo_Remision <> Value Then
                Me._Motivo_Remision = Value
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

    Public Event Id_Concejo_ExpulsorChanging(ByVal Value As Int32)
    Public Event Id_Concejo_ExpulsorChanged()

    Public Property Id_Concejo_Expulsor() As Int32
        Get
            Return Me._Id_Concejo_Expulsor
        End Get
        Set(ByVal Value As Int32)
            If _Id_Concejo_Expulsor <> Value Then
                RaiseEvent Id_Concejo_ExpulsorChanging(Value)
                Me._Id_Concejo_Expulsor = Value
                RaiseEvent Id_Concejo_ExpulsorChanged()
            End If
        End Set
    End Property

    Public Event Id_SolicitoAyudaChanging(ByVal Value As Int32)
    Public Event Id_SolicitoAyudaChanged()

    Public Property Id_Solicito_Ayuda() As Int32
        Get
            Return Me._Id_Solicito_Ayuda
        End Get
        Set(ByVal Value As Int32)
            If _Id_Solicito_Ayuda <> Value Then
                RaiseEvent Id_SolicitoAyudaChanging(Value)
                Me._Id_Solicito_Ayuda = Value
                RaiseEvent Id_SolicitoAyudaChanged()
            End If
        End Set
    End Property

    Public Event Id_Lugar_fuenteChanging(ByVal Value As Int32)
    Public Event Id_Lugar_fuenteChanged()

    Public Property Id_Lugar_Fuente() As Int32
        Get
            Return Me._Id_Lugar_fuente
        End Get
        Set(ByVal Value As Int32)
            If _Id_Lugar_fuente <> Value Then
                RaiseEvent Id_Lugar_fuenteChanging(Value)
                Me._Id_Lugar_fuente = Value
                RaiseEvent Id_Lugar_fuenteChanged()
            End If
        End Set
    End Property

    Public Event Id_EnLineaChanging(ByVal Value As Int32)
    Public Event Id_EnLineaChanged()

    Public Property Id_EnLinea() As Int32
        Get
            Return Me._Id_EnLinea
        End Get
        Set(ByVal Value As Int32)
            If _Id_EnLinea <> Value Then
                RaiseEvent Id_EnLineaChanging(Value)
                Me._Id_EnLinea = Value
                RaiseEvent Id_EnLineaChanged()
            End If
        End Set
    End Property

    Public Property Id_Agua_Potable() As Int32
        Get
            Return Me._Id_Agua_Potable
        End Get
        Set(ByVal Value As Int32)
            If _Id_Agua_Potable <> Value Then
                Me._Id_Agua_Potable = Value
            End If
        End Set
    End Property

    Public Property Id_Tiene_Documento() As Int32
        Get
            Return Me._Id_Tiene_documento
        End Get
        Set(ByVal Value As Int32)
            If _Id_Tiene_documento <> Value Then
                Me._Id_Tiene_documento = Value
            End If
        End Set
    End Property

    Public Property Id_Tipo_Familia_No_Desplazada() As Int32
        Get
            Return Me._Id_Tipo_Familia_No_Desplazada
        End Get
        Set(ByVal Value As Int32)
            If _Id_Tipo_Familia_No_Desplazada <> Value Then
                Me._Id_Tipo_Familia_No_Desplazada = Value
            End If
        End Set
    End Property

    Public Event Id_AtenderChanging(ByVal Value As Int32)
    Public Event Id_AtenderChanged()

    Public Property Id_Atender() As Int32
        Get
            Return Me._Id_Atender
        End Get
        Set(ByVal Value As Int32)
            If _Id_Atender <> Value Then
                RaiseEvent Id_AtenderChanging(Value)
                Me._Id_Atender = Value
                RaiseEvent Id_AtenderChanged()
            End If
        End Set
    End Property

    Public Event Fecha_RadicacionChanging(ByVal Value As DateTime)
    Public Event Fecha_RadicacionChanged()

    Public Property Fecha_Radicacion() As DateTime
        Get
            Return Me._Fecha_Radicacion
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_Radicacion <> Value Then
                RaiseEvent Fecha_RadicacionChanging(Value)
                Me._Fecha_Radicacion = Value
                RaiseEvent Fecha_RadicacionChanged()
            End If
        End Set
    End Property

    Public Event Numero_DeclaracionChanging(ByVal Value As String)
    Public Event Numero_DeclaracionChanged()

    Public Property Numero_Declaracion() As String
        Get
            Return Me._Numero_Declaracion
        End Get
        Set(ByVal Value As String)
            If _Numero_Declaracion <> Value Then
                RaiseEvent Numero_DeclaracionChanging(Value)
                Me._Numero_Declaracion = Value
                RaiseEvent Numero_DeclaracionChanged()
            End If
        End Set
    End Property

    Public Event Fecha_CierreChanging(ByVal Value As DateTime)
    Public Event Fecha_CierreChanged()

    Public Property Fecha_Cierre() As DateTime
        Get
            Return Me._Fecha_Cierre
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_Cierre <> Value Then
                RaiseEvent Fecha_CierreChanging(Value)
                Me._Fecha_Cierre = Value
                RaiseEvent Fecha_CierreChanged()
            End If
        End Set
    End Property

    Public Event CierreChanging(ByVal Value As Boolean)
    Public Event CierreChanged()

    Public Property Cierre() As Boolean
        Get
            Return Me._Cierre
        End Get
        Set(ByVal Value As Boolean)
            If _Cierre <> Value Then
                RaiseEvent CierreChanging(Value)
                Me._Cierre = Value
                RaiseEvent CierreChanged()
            End If
        End Set
    End Property

    Public Event Id_Familias_AccionChanging(ByVal Value As Int32)
    Public Event Id_Familias_AccionChanged()

    Public Property Id_Familias_Accion() As Int32
        Get
            Return Me._Id_Familias_Accion
        End Get
        Set(ByVal Value As Int32)
            If _Id_Familias_Accion <> Value Then
                RaiseEvent Id_Familias_AccionChanging(Value)
                Me._Id_Familias_Accion = Value
                RaiseEvent Id_Familias_AccionChanged()
            End If
        End Set
    End Property

    Public Event Municipio_Familias_AccionChanging(ByVal Value As String)
    Public Event Municipio_Familias_AccionChanged()

    Public Property Municipio_Familias_Accion() As String
        Get
            Return Me._Municipio_Familias_Accion
        End Get
        Set(ByVal Value As String)
            If _Municipio_Familias_Accion <> Value Then
                RaiseEvent Municipio_Familias_AccionChanging(Value)
                Me._Municipio_Familias_Accion = Value
                RaiseEvent Municipio_Familias_AccionChanged()
            End If
        End Set
    End Property


    Public Event Id_Red_UnidosChanging(ByVal Value As Int32)
    Public Event Id_Red_UnidosChanged()

    Public Property Id_Red_Unidos() As Int32
        Get
            Return Me._Id_Red_Unidos
        End Get
        Set(ByVal Value As Int32)
            If _Id_Red_Unidos <> Value Then
                RaiseEvent Id_Red_UnidosChanging(Value)
                Me._Id_Red_Unidos = Value
                RaiseEvent Id_Red_UnidosChanged()
            End If
        End Set
    End Property

    Public Event Municipio_UnidosChanging(ByVal Value As String)
    Public Event Municipio_UnidosChanged()

    Public Property Municipio_Unidos() As String
        Get
            Return Me._Municipio_Unidos
        End Get
        Set(ByVal Value As String)
            If _Municipio_Unidos <> Value Then
                RaiseEvent Municipio_UnidosChanging(Value)
                Me._Municipio_Unidos = Value
                RaiseEvent Municipio_UnidosChanged()
            End If
        End Set
    End Property

    Public Event Id_VBG_generalChanging(ByVal Value As Int32)
    Public Event Id_VBG_generalChanged()

    Public Property Id_VBG_general() As Int32
        Get
            Return Me._Id_VBG_general
        End Get
        Set(ByVal Value As Int32)
            If _Id_VBG_general <> Value Then
                RaiseEvent Id_VBG_generalChanging(Value)
                Me._Id_VBG_general = Value
                RaiseEvent Id_VBG_generalChanged()
            End If
        End Set
    End Property

    Public Event VBG_General_AgresorChanging(ByVal Value As String)
    Public Event VBG_General_AgresorChanged()

    Public Property VBG_General_Agresor() As String
        Get
            Return Me._VBG_General_Agresor
        End Get
        Set(ByVal Value As String)
            If _VBG_General_Agresor <> Value Then
                RaiseEvent VBG_General_AgresorChanging(Value)
                Me._VBG_General_Agresor = Value
                RaiseEvent VBG_General_AgresorChanged()
            End If
        End Set
    End Property

    Public Event Id_Ha_Muerto_DespuesChanging(ByVal Value As Int32)
    Public Event Id_Ha_Muerto_DespuesChanged()

    Public Property Id_Ha_Muerto_Despues() As Int32
        Get
            Return Me._Id_Ha_Muerto_Despues
        End Get
        Set(ByVal Value As Int32)
            If _Id_Ha_Muerto_Despues <> Value Then
                RaiseEvent Id_Ha_Muerto_DespuesChanging(Value)
                Me._Id_Ha_Muerto_Despues = Value
                RaiseEvent Id_Ha_Muerto_DespuesChanged()
            End If
        End Set
    End Property

    Public Event Id_Solicito_Atencion_PsicologicaChanging(ByVal Value As Int32)
    Public Event Id_Solicito_Atencion_PsicologicaChanged()

    Public Property Id_Solicito_Atencion_Psicologica() As Int32
        Get
            Return Me._Id_Solicito_Atencion_Psicologica
        End Get
        Set(ByVal Value As Int32)
            If _Id_Solicito_Atencion_Psicologica <> Value Then
                RaiseEvent Id_Solicito_Atencion_PsicologicaChanging(Value)
                Me._Id_Solicito_Atencion_Psicologica = Value
                RaiseEvent Id_Solicito_Atencion_PsicologicaChanged()
            End If
        End Set
    End Property

    Public Event Id_Afectado_DesplazamientoChanging(ByVal Value As Int32)
    Public Event Id_Afectado_DesplazamientoChanged()

    Public Property Id_Afectado_Desplazamiento() As Int32
        Get
            Return Me._Id_Afectado_Desplazamiento
        End Get
        Set(ByVal Value As Int32)
            If _Id_Afectado_Desplazamiento <> Value Then
                RaiseEvent Id_Afectado_DesplazamientoChanging(Value)
                Me._Id_Afectado_Desplazamiento = Value
                RaiseEvent Id_Afectado_DesplazamientoChanged()
            End If
        End Set
    End Property

    Public Property Id_Emociones() As Int32
        Get
            Return Me._Id_Emociones
        End Get
        Set(ByVal Value As Int32)
            If _Id_Emociones <> Value Then
                Me._Id_Emociones = Value
            End If
        End Set
    End Property

    Public Property Id_Tipo_Adiccion() As Int32
        Get
            Return Me._Id_Tipo_Adiccion
        End Get
        Set(ByVal Value As Int32)
            If _Id_Tipo_Adiccion <> Value Then
                Me._Id_Tipo_Adiccion = Value
            End If
        End Set
    End Property

    Public Property Id_Adiccion_Alcohol() As Int32
        Get
            Return Me._Id_Adiccion_Alcohol
        End Get
        Set(ByVal Value As Int32)
            If _Id_Adiccion_Alcohol <> Value Then
                Me._Id_Adiccion_Alcohol = Value
            End If
        End Set
    End Property

    Public Property Id_Adiccion_Droga() As Int32
        Get
            Return Me._Id_Adiccion_Droga
        End Get
        Set(ByVal Value As Int32)
            If _Id_Adiccion_Droga <> Value Then
                Me._Id_Adiccion_Droga = Value
            End If
        End Set
    End Property

    Public Event Id_Municipio_FaccionChanging(ByVal Value As Int32)
    Public Event Id_Municipio_FaccionChanged()

    Public Property Id_Municipio_Faccion() As Int32
        Get
            Return Me._Id_Municipio_Faccion
        End Get
        Set(ByVal Value As Int32)
            If _Id_Municipio_Faccion <> Value Then
                RaiseEvent Id_Municipio_FaccionChanging(Value)
                Me._Id_Municipio_Faccion = Value
                RaiseEvent Id_Municipio_FaccionChanged()
            End If
        End Set
    End Property

    '
    '
    '
    Public Property Declaracion_Entidades_Ayuda() As List(Of Declaracion_Entidades_AyudaBrl)
        Get
            If (Me.objListDeclaracion_Entidades_Ayuda Is Nothing) Then
                objListDeclaracion_Entidades_Ayuda = Declaracion_Entidades_AyudaBrl.CargarPorId_Declaracion(Me.ID)
            End If
            Return Me.objListDeclaracion_Entidades_Ayuda
        End Get
        Set(ByVal Value As List(Of Declaracion_Entidades_AyudaBrl))
            Me.objListDeclaracion_Entidades_Ayuda = Value
        End Set
    End Property

    Public Property Declaracion_Ayudas_Dadas() As List(Of Declaracion_Ayudas_DadasBrl)
        Get
            If (Me.objListDeclaracion_Ayudas_Dadas Is Nothing) Then
                objListDeclaracion_Ayudas_Dadas = Declaracion_Ayudas_DadasBrl.CargarPorId_Declaracion(Me.ID)
            End If
            Return Me.objListDeclaracion_Ayudas_Dadas
        End Get
        Set(ByVal Value As List(Of Declaracion_Ayudas_DadasBrl))
            Me.objListDeclaracion_Ayudas_Dadas = Value
        End Set
    End Property

    Public Property Declaracion_Fuentes_Ingreso() As List(Of Declaracion_Fuentes_IngresoBrl)
        Get
            If (Me.objListDeclaracion_Fuentes_Ingreso Is Nothing) Then
                objListDeclaracion_Fuentes_Ingreso = Declaracion_Fuentes_IngresoBrl.CargarPorId_Declaracion(Me.ID)
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
                objListDeclaracion_Obtencion_Agua = Declaracion_Obtencion_AguaBrl.CargarPorId_Declaracion(Me.ID)
            End If
            Return Me.objListDeclaracion_Obtencion_Agua
        End Get
        Set(ByVal Value As List(Of Declaracion_Obtencion_AguaBrl))
            Me.objListDeclaracion_Obtencion_Agua = Value
        End Set
    End Property

    Public Property Declaracion_Trabajos() As List(Of Declaracion_TrabajosBrl)
        Get
            If (Me.objListDeclaracion_Trabajos Is Nothing) Then
                objListDeclaracion_Trabajos = Declaracion_TrabajosBrl.CargarPorId_Declaracion(Me.ID)
            End If
            Return Me.objListDeclaracion_Trabajos
        End Get
        Set(ByVal Value As List(Of Declaracion_TrabajosBrl))
            Me.objListDeclaracion_Trabajos = Value
        End Set
    End Property

    Public Property Declaracion_Programas_Ayuda() As List(Of Declaracion_Programas_AyudaBrl)
        Get
            If (Me.objListDeclaracion_Programas_Ayuda Is Nothing) Then
                objListDeclaracion_Programas_Ayuda = Declaracion_Programas_AyudaBrl.CargarPorId_Declaracion(Me.ID)
            End If
            Return Me.objListDeclaracion_Programas_Ayuda
        End Get
        Set(ByVal Value As List(Of Declaracion_Programas_AyudaBrl))
            Me.objListDeclaracion_Programas_Ayuda = Value
        End Set
    End Property

    Public Property Personas() As List(Of PersonasBrl)
        Get
            If (Me.objListPersonas Is Nothing) Then
                objListPersonas = PersonasBrl.CargarPorId_Declaracion(Me.ID)
            End If
            Return Me.objListPersonas
        End Get
        Set(ByVal Value As List(Of PersonasBrl))
            Me.objListPersonas = Value
        End Set
    End Property

    Public Property PersonasEducacion() As List(Of PersonasBrl)
        Get
            If (Me.objListPersonasEducacion Is Nothing) Then
                objListPersonasEducacion = PersonasBrl.CargarPorId_Declaracion_Educacion(Me.ID)
            End If
            Return Me.objListPersonasEducacion
        End Get
        Set(ByVal Value As List(Of PersonasBrl))
            Me.objListPersonasEducacion = Value
        End Set
    End Property

    Public Property PersonasEducacionPendiente() As List(Of PersonasBrl)
        Get
            If (Me.objListPersonasEducacionPendiente Is Nothing) Then
                objListPersonasEducacionPendiente = PersonasBrl.CargarPorId_Declaracion_EducacionPendiente(Me.ID)
            End If
            Return Me.objListPersonasEducacionPendiente
        End Get
        Set(ByVal Value As List(Of PersonasBrl))
            Me.objListPersonasEducacionPendiente = Value
        End Set
    End Property


    Public Property Declaracion_Bienes() As List(Of Declaracion_BienesBrl)
        Get
            If (Me.objListDeclaracion_Bienes Is Nothing) Then
                objListDeclaracion_Bienes = Declaracion_BienesBrl.CargarPorId_Declaracion(Me.ID)
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
                objListDeclaracion_Causas_Desplazamiento = Declaracion_Causas_DesplazamientoBrl.CargarPorId_Declaracion(Me.ID)
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
                objListDeclaracion_Causas_NoEstudio = Declaracion_Causas_NoEstudioBrl.CargarPorId_Declaracion(Me.ID)
            End If
            Return Me.objListDeclaracion_Causas_NoEstudio
        End Get
        Set(ByVal Value As List(Of Declaracion_Causas_NoEstudioBrl))
            Me.objListDeclaracion_Causas_NoEstudio = Value
        End Set
    End Property

    Public Property Declaracion_Danos_Familia() As List(Of Declaracion_Danos_FamiliaBrl)
        Get
            If (Me.objListDeclaracion_Danos_Familia Is Nothing) Then
                objListDeclaracion_Danos_Familia = Declaracion_Danos_FamiliaBrl.CargarPorId_Declaracion(Me.ID)
            End If
            Return Me.objListDeclaracion_Danos_Familia
        End Get
        Set(ByVal Value As List(Of Declaracion_Danos_FamiliaBrl))
            Me.objListDeclaracion_Danos_Familia = Value
        End Set
    End Property

    Public Property Declaracion_Instituciones_Confianza() As List(Of Declaracion_Instituciones_ConfianzaBrl)
        Get
            If (Me.objListDeclaracion_Instituciones_Confianza Is Nothing) Then
                objListDeclaracion_Instituciones_Confianza = Declaracion_Instituciones_ConfianzaBrl.CargarPorId_Declaracion(Me.ID)
            End If
            Return Me.objListDeclaracion_Instituciones_Confianza
        End Get
        Set(ByVal Value As List(Of Declaracion_Instituciones_ConfianzaBrl))
            Me.objListDeclaracion_Instituciones_Confianza = Value
        End Set
    End Property

    Public Property Declaracion_Nivel_Educativo() As List(Of Declaracion_Nivel_EducativoBrl)
        Get
            If (Me.objListDeclaracion_Nivel_Educativo Is Nothing) Then
                objListDeclaracion_Nivel_Educativo = Declaracion_Nivel_EducativoBrl.CargarPorId_Declaracion(Me.ID)
            End If
            Return Me.objListDeclaracion_Nivel_Educativo
        End Get
        Set(ByVal Value As List(Of Declaracion_Nivel_EducativoBrl))
            Me.objListDeclaracion_Nivel_Educativo = Value
        End Set
    End Property

    Public Property Declaracion_Servicio_salud() As List(Of Declaracion_Servicio_saludBrl)
        Get
            If (Me.objListDeclaracion_Servicio_salud Is Nothing) Then
                objListDeclaracion_Servicio_salud = Declaracion_Servicio_saludBrl.CargarPorId_Declaracion(Me.ID)
            End If
            Return Me.objListDeclaracion_Servicio_salud
        End Get
        Set(ByVal Value As List(Of Declaracion_Servicio_saludBrl))
            Me.objListDeclaracion_Servicio_salud = Value
        End Set
    End Property

    Public Property Declaracion_Vulnerabilidad() As List(Of Declaracion_VulnerabilidadBrl)
        Get
            If (Me.objListDeclaracion_Vulnerabilidad Is Nothing) Then
                objListDeclaracion_Vulnerabilidad = Declaracion_VulnerabilidadBrl.CargarPorId_Declaracion(Me.ID)
            End If
            Return Me.objListDeclaracion_Vulnerabilidad
        End Get
        Set(ByVal Value As List(Of Declaracion_VulnerabilidadBrl))
            Me.objListDeclaracion_Vulnerabilidad = Value
        End Set
    End Property

    Public Property Declaracion_Unidades() As List(Of Declaracion_UnidadesBrl)
        Get
            If (Me.objListDeclaracion_Unidades Is Nothing) Then
                objListDeclaracion_Unidades = Declaracion_UnidadesBrl.CargarPorId_Declaracion(Me.ID)
            End If
            Return Me.objListDeclaracion_Unidades
        End Get
        Set(ByVal Value As List(Of Declaracion_UnidadesBrl))
            Me.objListDeclaracion_Unidades = Value
        End Set
    End Property

    Public Property Declaracion_Estados() As List(Of Declaracion_EstadosBrl)
        Get
            If (Me.objListEstadosDeclaracion Is Nothing) Then
                objListEstadosDeclaracion = Declaracion_EstadosBrl.CargarPorId_Declaracion(Me.ID)
            End If
            Return Me.objListEstadosDeclaracion
        End Get
        Set(ByVal Value As List(Of Declaracion_EstadosBrl))
            Me.objListEstadosDeclaracion = Value
        End Set
    End Property

    '
    '  Manuales
    '
    Public Property PersonasBeneficiarios() As List(Of PersonasBrl)
        Get
            If (Me.objListPersonasBeneficiarios Is Nothing) Then
                objListPersonasBeneficiarios = PersonasBrl.CargarPorId_DeclaracionYBeneficiarios(Me.ID)
            End If
            Return Me.objListPersonasBeneficiarios
        End Get
        Set(ByVal Value As List(Of PersonasBrl))
            Me.objListPersonasBeneficiarios = Value
        End Set
    End Property

    Public ReadOnly Property Aplico_Reparaciones() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Aplico_Reparaciones)
        End Get
    End Property

    Public ReadOnly Property Enfermedad() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Enfermedad)
        End Get
    End Property

    Public ReadOnly Property Entidad_Legal() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Entidad_Legal)
        End Get
    End Property

    Public ReadOnly Property Esta_Trabajando() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Esta_Trabajando)
        End Get
    End Property

    Public ReadOnly Property Estado_Aplicacion() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Estado_Aplicacion)
        End Get
    End Property

    Public ReadOnly Property Estatus_Aplicacion_Despues() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Estatus_Aplicacion_Despues)
        End Get
    End Property

    Public ReadOnly Property Explicacion_Retorno() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Explicacion_Retorno)
        End Get
    End Property

    Public ReadOnly Property Fuente() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Fuente)
        End Get
    End Property

    Public ReadOnly Property Ha_Declarado_Antes() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Ha_Declarado_Antes)
        End Get
    End Property

    Public ReadOnly Property Ha_Muerto_Alguien() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Ha_Muerto_Alguien)
        End Get
    End Property

    Public ReadOnly Property Ha_Muerto_Despues() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Ha_Muerto_Despues)
        End Get
    End Property

    Public ReadOnly Property Ha_Redibido_Ayuda_Despues() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Ha_Redibido_Ayuda_Despues)
        End Get
    End Property

    Public ReadOnly Property Ha_Regresado() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Ha_Regresado)
        End Get
    End Property

    Public ReadOnly Property Llegada_Golpes() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Llegada_Golpes)
        End Get
    End Property

    Public ReadOnly Property Llegada_Golpes_Miembro() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Llegada_Golpes_Miembro)
        End Get
    End Property

    Public ReadOnly Property Llegada_Golpes_Usted() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Llegada_Golpes_Usted)
        End Get
    End Property

    Public ReadOnly Property Llegada_Insultos() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Llegada_Insultos)
        End Get
    End Property

    Public ReadOnly Property Llegada_Insultos_Miembro() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Llegada_Insultos_Miembro)
        End Get
    End Property

    Public ReadOnly Property Llegada_Insultos_Usted() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Llegada_Insultos_Usted)
        End Get
    End Property

    Public ReadOnly Property Llegada_Sexual() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Llegada_Sexual)
        End Get
    End Property

    Public ReadOnly Property Llegada_Sexual_Miembro() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Llegada_Sexual_Miembro)
        End Get
    End Property

    Public ReadOnly Property Llegada_Sexual_Usted() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Llegada_Sexual_Usted)
        End Get
    End Property

    Public ReadOnly Property Motivo_Muerte() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Motivo_Muerte)
        End Get
    End Property

    Public ReadOnly Property Motivo_No_Aplico() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Motivo_No_Aplico)
        End Get
    End Property

    Public ReadOnly Property Municipio_Expulsor() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Municipio_Expulsor)
        End Get
    End Property

    Public ReadOnly Property Oido_Mesa_Desplazados() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Oido_Mesa_Desplazados)
        End Get
    End Property

    Public ReadOnly Property Parentesco_Desaparecido() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Parentesco_Desaparecido)
        End Get
    End Property

    Public ReadOnly Property Parentesco_Muerte() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Parentesco_Muerte)
        End Get
    End Property

    Public ReadOnly Property Pertenece_Asociacion() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Pertenece_Asociacion)
        End Get
    End Property

    Public ReadOnly Property Razon_No_Aplico() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Razon_No_Aplico)
        End Get
    End Property

    Public ReadOnly Property Reporto() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Reporto)
        End Get
    End Property

    Public ReadOnly Property Retornaria() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Retornaria)
        End Get
    End Property

    Public ReadOnly Property Tiene_Desaparecido() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Tiene_Desaparecido)
        End Get
    End Property

    Public ReadOnly Property Velar_Enterrar() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Velar_Enterrar)
        End Get
    End Property

    Public ReadOnly Property Beneficiado_programas() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Beneficiado_Programas)
        End Get
    End Property

    Public ReadOnly Property Grupo() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Grupo)
        End Get
    End Property

    Public ReadOnly Property TipoDeclaracion() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Tipo_Declaracion)
        End Get
    End Property

    Public ReadOnly Property Regionales() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Regional)
        End Get
    End Property

    Public ReadOnly Property Atender() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Atender)
        End Get
    End Property

    Public ReadOnly Property Motivos_NoAtender() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Motivo_Noatender)
        End Get
    End Property

    Public ReadOnly Property Como_Brindar_Atencion() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Como_Brindar_Atencion)
        End Get
    End Property

    Public ReadOnly Property Como_Fue_Atencion() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Como_Fue_Atencion)
        End Get
    End Property

    Public ReadOnly Property Cuantas_Habitaciones() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Cuantas_Habitaciones)
        End Get
    End Property

    Public ReadOnly Property Cuantas_Personas_Habitacion() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Cuantas_Personas_Habitacion)
        End Get
    End Property

    Public ReadOnly Property Cuantas_Personas_Vivienda() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Cuantas_Personas_Vivienda)
        End Get
    End Property

    Public ReadOnly Property Cuanto_Tiempo_Demoro() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Cuanto_Tiempo_Demoro)
        End Get
    End Property

    Public ReadOnly Property Cuantos_Desplazamientos() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Cuantos_Desplazamientos)
        End Get
    End Property

    Public ReadOnly Property Departamento_Expulsor() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Departamento_Expulsor)
        End Get
    End Property

    Public ReadOnly Property Despues_Hijos_617() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Despues_Hijos_617)
        End Get
    End Property

    Public ReadOnly Property Entidad_Inicial_Atencion() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Entidad_Inicial_Atencion)
        End Get
    End Property

    Public ReadOnly Property Forma_Declaracion() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Forma_Declaracion)
        End Get
    End Property

    Public ReadOnly Property Materiales_Vivienda() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Materiales_Vivienda)
        End Get
    End Property

    Public ReadOnly Property Motivo_Demora() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Motivo_Demora)
        End Get
    End Property

    Public ReadOnly Property Motivo_NoDeclaro_Municipio() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Motivo_NoDeclaro_Municipio)
        End Get
    End Property

    Public ReadOnly Property Porque_No_Reporto() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Porque_No_Reporto)
        End Get
    End Property

    Public ReadOnly Property Recibio_Ayuda_Entidad_Inicial() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Recibio_Ayuda_Entidad_Inicial)
        End Get
    End Property

    Public ReadOnly Property Tiempo_Casco_Urbano() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Tiempo_Casco_Urbano)
        End Get
    End Property

    Public ReadOnly Property Tipo_Tenencia_Vivienda() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Tipo_Tenencia_Vivienda)
        End Get
    End Property

    Public ReadOnly Property Vivio_Cabezera_Municipal() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Vivio_Cabezera_Municipal)
        End Get
    End Property

    Public ReadOnly Property Despues_Afiliado_Regimen_Contributivo() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Despues_Afiliado_Regimen_Contributivo)
        End Get
    End Property

    Public ReadOnly Property Despues_Afiliado_Regimen_Subsidiado() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Despues_Afiliado_Regimen_Subsidiado)
        End Get
    End Property

    Public ReadOnly Property Despues_Afiliado_Sisben() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Despues_Afiliado_Sisben)
        End Get
    End Property

    Public ReadOnly Property Destino_Tierra() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Destino_Tierra)
        End Get
    End Property

    Public ReadOnly Property Documento_Propiedad() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Documento_Propiedad)
        End Get
    End Property

    Public ReadOnly Property Situacion_Actual_Tierras() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Situacion_Actual_Tierras)
        End Get
    End Property

    Public ReadOnly Property Tipo_Bien_Rural() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Tipo_Bien_Rural)
        End Get
    End Property

    Public ReadOnly Property Ley_Reparacion() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_ley_reparacion)
        End Get
    End Property

    Public ReadOnly Property Es_Del_Municipio() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Es_Del_Municipio)
        End Get
    End Property

    Public ReadOnly Property Tipo_Familia_Desplazada() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Tipo_Familia_desplazada)
        End Get
    End Property

    Public ReadOnly Property Vulnerables_NoDesplazada() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Vulnerables_NoDesplazada)
        End Get
    End Property

    Public ReadOnly Property Solicito_Ayuda() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Solicito_Ayuda)
        End Get
    End Property

    Public ReadOnly Property ConcejoExpulsor() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Concejo_Expulsor)
        End Get
    End Property

    Public ReadOnly Property Lugar_fuente() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Lugar_Fuente)
        End Get
    End Property

    Public ReadOnly Property EnLinea() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_EnLinea)
        End Get
    End Property

    Public ReadOnly Property AguaPotable() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Agua_Potable)
        End Get
    End Property

    Public ReadOnly Property TieneDocumento() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Tiene_Documento)
        End Get
    End Property

    Public ReadOnly Property Emociones() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Emociones)
        End Get
    End Property

    Public Property Declaracion_Muertos() As List(Of Declaracion_MuertosBrl)
        Get
            If (Me.objListDeclaracion_Muertos Is Nothing) Then
                objListDeclaracion_Muertos = Declaracion_MuertosBrl.CargarPorId_Declaracion(Me.ID)
            End If
            Return Me.objListDeclaracion_Muertos
        End Get
        Set(ByVal Value As List(Of Declaracion_MuertosBrl))
            Me.objListDeclaracion_Muertos = Value
        End Set
    End Property

    Public Property Declaracion_Desaparecidos() As List(Of Declaracion_DesaparecidosBrl)
        Get
            If (Me.objListDeclaracion_Desaparecidos Is Nothing) Then
                objListDeclaracion_Desaparecidos = Declaracion_DesaparecidosBrl.CargarPorId_Declaracion(Me.ID)
            End If
            Return Me.objListDeclaracion_Desaparecidos
        End Get
        Set(ByVal Value As List(Of Declaracion_DesaparecidosBrl))
            Me.objListDeclaracion_Desaparecidos = Value
        End Set
    End Property

    Public Property Declaracion_Psicosocial() As List(Of Declaracion_PsicosocialBrl)
        Get
            If (Me.objListDeclaracion_Psicosocial Is Nothing) Then
                objListDeclaracion_Psicosocial = Declaracion_PsicosocialBrl.CargarPorId_Declaracion(Me.ID)
            End If
            Return Me.objListDeclaracion_Psicosocial
        End Get
        Set(ByVal Value As List(Of Declaracion_PsicosocialBrl))
            Me.objListDeclaracion_Psicosocial = Value
        End Set
    End Property

    Public ReadOnly Property Afectado_Desplazamiento() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Afectado_Desplazamiento)
        End Get
    End Property

    Public ReadOnly Property Familias_Accion() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Familias_Accion)
        End Get
    End Property

    Public ReadOnly Property Unidos() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Red_Unidos)
        End Get
    End Property

    Public ReadOnly Property Solicito_Atencion_Psicosocial() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Solicito_Atencion_Psicologica)
        End Get
    End Property

    Public ReadOnly Property VBG_General() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_VBG_general)
        End Get
    End Property

    Public ReadOnly Property Tipo_Adiccion() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Tipo_Adiccion)
        End Get
    End Property

    Public ReadOnly Property Adiccion_Alcohol() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Adiccion_Alcohol)
        End Get
    End Property

    Public ReadOnly Property Adiccion_Droga() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Adiccion_Droga)
        End Get
    End Property

    Public Property Declaracion_Personas_Ayuda() As List(Of Declaracion_Personas_AyudaBrl)
        Get
            If (Me.objListDeclaracion_Personas_Ayuda Is Nothing) Then
                objListDeclaracion_Personas_Ayuda = Declaracion_Personas_AyudaBrl.CargarPorId_Declaracion(Me.ID)
            End If
            Return Me.objListDeclaracion_Personas_Ayuda
        End Get
        Set(ByVal Value As List(Of Declaracion_Personas_AyudaBrl))
            Me.objListDeclaracion_Personas_Ayuda = Value
        End Set
    End Property

    Public Property Declaracion_Apoyo_Ayuda() As List(Of Declaracion_Apoyo_AyudaBrl)
        Get
            If (Me.objListDeclaracion_Apoyo_Ayuda Is Nothing) Then
                objListDeclaracion_Apoyo_Ayuda = Declaracion_Apoyo_AyudaBrl.CargarPorId_Declaracion(Me.ID)
            End If
            Return Me.objListDeclaracion_Apoyo_Ayuda
        End Get
        Set(ByVal Value As List(Of Declaracion_Apoyo_AyudaBrl))
            Me.objListDeclaracion_Apoyo_Ayuda = Value
        End Set
    End Property

    Public Property Declaracion_Seguimientos() As List(Of Declaracion_SeguimientosBrl)
        Get
            If (Me.objListDeclaracion_Seguimientos Is Nothing) Then
                objListDeclaracion_Seguimientos = Declaracion_SeguimientosBrl.CargarPorId_Declaracion(Me.ID)
            End If
            Return Me.objListDeclaracion_Seguimientos
        End Get
        Set(ByVal Value As List(Of Declaracion_SeguimientosBrl))
            Me.objListDeclaracion_Seguimientos = Value
        End Set
    End Property

    Public Property Declaracion_PAARI() As List(Of Declaracion_PAARIBrl)
        Get
            If (Me.objListDeclaracion_PAARI Is Nothing) Then
                objListDeclaracion_PAARI = Declaracion_PAARIBrl.CargarPorId_Declaracion(Me.ID)
            End If
            Return Me.objListDeclaracion_PAARI
        End Get
        Set(ByVal Value As List(Of Declaracion_PAARIBrl))
            Me.objListDeclaracion_PAARI = Value
        End Set
    End Property

    Public ReadOnly Property Tmp_Psicosocial() As Tmp_PsicosocialBrl
        Get
            Return Tmp_PsicosocialBrl.CargarPorID_Declaracion(ID)
        End Get
    End Property

    Public ReadOnly Property Municipio_Faccion() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Municipio_Faccion)
        End Get
    End Property

    '
    '
    '
    Public ReadOnly Property TipoFamiliaxaEmpacar() As Double
        Get
            Dim wcantidad As Integer = 0
            Try

                If Menores_Ninas.ToString <> "" Then
                    wcantidad = wcantidad + Menores_Ninas
                End If
                If Menores_Ninos.ToString <> "" Then
                    wcantidad = wcantidad + Menores_Ninos
                End If
                If Lactantes.ToString <> "" Then
                    wcantidad = wcantidad + Lactantes
                End If
                If Resto_Nucleo.ToString <> "" Then
                    wcantidad = wcantidad + Resto_Nucleo
                End If
                If Recien_Nacidos.ToString <> "" Then
                    wcantidad = wcantidad + Recien_Nacidos
                End If
                If Gestantes.ToString <> "" Then
                    wcantidad = wcantidad + Gestantes
                End If
                Return wcantidad
            Catch ex As Exception
                Return 0
            End Try
        End Get
    End Property

    Public ReadOnly Property Declarante() As String
        Get
            If Tipo_Declaracion = 921 Then Return "D"
            If Tipo_Declaracion = 922 Then Return "V"
            If Tipo_Declaracion = 923 Then Return "E"
            Return "X"
        End Get
    End Property

    Public ReadOnly Property Personas_Declarante() As PersonasBrl
        Get
            Return PersonasBrl.CargarPorId_DeclaracionYDeclarante(Me.ID)
        End Get
    End Property

    Public ReadOnly Property TipoFamilia() As Integer
        Get
            If Personas Is Nothing Then
                Return 0
            Else
                Return Personas.Count
            End If
        End Get
    End Property

    Public ReadOnly Property conteobeneficiarios() As Integer
        Get
            If PersonasBeneficiarios Is Nothing Then
                Return 0
            Else
                Return PersonasBeneficiarios.Count
            End If
        End Get
    End Property

    Public ReadOnly Property NombreRegional() As String
        Get
            If Regionales Is Nothing Then
                Return ""
            Else
                Return Regionales.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Atendido() As String
        Get
            If Atender Is Nothing Then
                Return ""
            Else
                Return Atender.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property NombreFuente() As String
        Get
            If Fuente Is Nothing Then
                Return ""
            Else
                Return Fuente.Descripcion()
            End If
        End Get
    End Property

    Public ReadOnly Property NombreLugarFuente() As String
        Get
            If Lugar_fuente Is Nothing Then
                Return ""
            Else
                Return Lugar_fuente.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property MotivoNoAtencion() As String
        Get
            If Motivos_NoAtender Is Nothing Then
                Return ""
            Else
                Return Motivos_NoAtender.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property FormaDeclaracion() As String
        Get
            If Forma_Declaracion Is Nothing Then
                Return ""
            Else
                Return Forma_Declaracion.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property DescripcionGrupo() As String
        Get
            If Grupo Is Nothing Then
                Return ""
            Else
                Return Grupo.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property HaRegresado() As String
        Get
            If Ha_Regresado Is Nothing Then
                Return ""
            Else
                Return Ha_Regresado.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property DatoRetornaria() As String
        Get
            If Retornaria Is Nothing Then
                Return ""
            Else
                Return Retornaria.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Muerto() As String
        Get
            If Ha_Muerto_Alguien Is Nothing Then
                Return ""
            Else
                Return Ha_Muerto_Alguien.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Muerto_Despues() As String
        Get
            If Ha_Muerto_Despues Is Nothing Then
                Return ""
            Else
                Return Ha_Muerto_Despues.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property DescripcionDepartamento() As String
        Get
            If Departamento_Expulsor Is Nothing Then
                Return ""
            Else
                Return Departamento_Expulsor.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property DescripcionMunicipio() As String
        Get
            If Municipio_Expulsor Is Nothing Then
                Return ""
            Else
                Return Municipio_Expulsor.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property DescripcionConcejo() As String
        Get
            If ConcejoExpulsor Is Nothing Then
                Return ""
            Else
                Return ConcejoExpulsor.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property MotivoNoRetorno() As String
        Get
            If Explicacion_Retorno Is Nothing Then
                Return ""
            Else
                Return Explicacion_Retorno.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property HaDeclaradoAntes() As String
        Get
            If Ha_Declarado_Antes Is Nothing Then
                Return ""
            Else
                Return Ha_Declarado_Antes.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Atencion_Psicosocial() As String
        Get
            If Solicito_Atencion_Psicosocial Is Nothing Then
                Return ""
            Else
                Return Solicito_Atencion_Psicosocial.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property NomnbreEnfermedad() As String
        Get
            If Enfermedad Is Nothing Then
                Return ""
            Else
                Return Enfermedad.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property MotivoMuerte() As String
        Get
            If Motivo_Muerte Is Nothing Then
                Return ""
            Else
                Return Motivo_Muerte.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property ParentescoMuerte() As String
        Get
            If Parentesco_Muerte Is Nothing Then
                Return ""
            Else
                Return Parentesco_Muerte.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property VelarMuerte() As String
        Get
            If Me.Velar_Enterrar Is Nothing Then
                Return ""
            Else
                Return Velar_Enterrar.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Desaparecido() As String
        Get
            If Tiene_Desaparecido Is Nothing Then
                Return ""
            Else
                Return Tiene_Desaparecido.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property ParentescoDesaparecido() As String
        Get
            If Parentesco_Desaparecido Is Nothing Then
                Return ""
            Else
                Return Parentesco_Desaparecido.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property ReportoDesaparicion() As String
        Get
            If Reporto Is Nothing Then
                Return ""
            Else
                Return Reporto.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property PorqueNoReporto() As String
        Get
            If Porque_No_Reporto Is Nothing Then
                Return ""
            Else
                Return Porque_No_Reporto.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property FuenteDenuncia() As String
        Get
            If Entidad_Legal Is Nothing Then
                Return ""
            Else
                Return Entidad_Legal.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property aplicoreparaciones() As String
        Get
            If Aplico_Reparaciones Is Nothing Then
                Return ""
            Else
                Return Aplico_Reparaciones.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property EstadoAplicacion() As String
        Get
            If Me.Estado_Aplicacion Is Nothing Then
                Return ""
            Else
                Return Estado_Aplicacion.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property MotivoNoAplico() As String
        Get
            If Me.Motivo_No_Aplico Is Nothing Then
                Return ""
            Else
                Return Motivo_No_Aplico.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property llegadaInsultos() As String
        Get
            If Llegada_Insultos Is Nothing Then
                Return ""
            Else
                Return Llegada_Insultos.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property MiembroInsultos() As String
        Get
            If Llegada_Insultos_Miembro Is Nothing Then
                Return ""
            Else
                Return Llegada_Insultos_Miembro.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Ustedinsultos() As String
        Get
            If Llegada_Insultos_Usted Is Nothing Then
                Return ""
            Else
                Return Llegada_Insultos_Usted.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property llegadaSexual() As String
        Get
            If Llegada_Sexual Is Nothing Then
                Return ""
            Else
                Return Llegada_Sexual.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property MiembroSexual() As String
        Get
            If Llegada_Sexual_Miembro Is Nothing Then
                Return ""
            Else
                Return Llegada_Sexual_Miembro.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property UstedSexual() As String
        Get
            If Llegada_Sexual_Usted Is Nothing Then
                Return ""
            Else
                Return Llegada_Sexual_Usted.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property llegadaGolpes() As String
        Get
            If Llegada_Golpes Is Nothing Then
                Return ""
            Else
                Return Llegada_Golpes.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property MiembroGolpes() As String
        Get
            If Llegada_Golpes_Miembro Is Nothing Then
                Return ""
            Else
                Return Llegada_Golpes_Miembro.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property UstedGolpes() As String
        Get
            If Llegada_Golpes_Usted Is Nothing Then
                Return ""
            Else
                Return Llegada_Golpes_Usted.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property HaRecibidoAyudaDespues() As String
        Get
            If Me.Ha_Redibido_Ayuda_Despues Is Nothing Then
                Return ""
            Else
                Return Ha_Redibido_Ayuda_Despues.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property EstatusAplicacionDespues() As String
        Get
            If Me.Estatus_Aplicacion_Despues Is Nothing Then
                Return ""
            Else
                Return Estatus_Aplicacion_Despues.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property TipoTenencia() As String
        Get
            If Tipo_Tenencia_Vivienda Is Nothing Then
                Return ""
            Else
                Return Tipo_Tenencia_Vivienda.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property PersonasVivienda() As String
        Get
            If Cuantas_Personas_Vivienda Is Nothing Then
                Return ""
            Else
                Return Cuantas_Personas_Vivienda.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property CuantasHabitaciones() As String
        Get
            If Cuantas_Habitaciones Is Nothing Then
                Return ""
            Else
                Return Cuantas_Habitaciones.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property PersonasHabitacion() As String
        Get
            If Cuantas_Personas_Habitacion Is Nothing Then
                Return ""
            Else
                Return Cuantas_Personas_Habitacion.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property MaterialesVivienda() As String
        Get
            If Materiales_Vivienda Is Nothing Then
                Return ""
            Else
                Return Materiales_Vivienda.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property CuantasVecesHaSidoDesplazado() As String
        Get
            If Me.Cuantos_Desplazamientos Is Nothing Then
                Return ""
            Else
                Return Cuantos_Desplazamientos.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property DescripcionTipo_Bien_Rural() As String
        Get
            If Me.Tipo_Bien_Rural Is Nothing Then
                Return ""
            Else
                Return Tipo_Bien_Rural.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property DescripcionDocumento_Propiedad() As String
        Get
            If Me.Documento_Propiedad Is Nothing Then
                Return ""
            Else
                Return Documento_Propiedad.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Copia_Documento() As String
        Get
            If Me.TieneDocumento Is Nothing Then
                Return ""
            Else
                Return TieneDocumento.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property DescripcionDestino_Tierra() As String
        Get
            If Me.Destino_Tierra Is Nothing Then
                Return ""
            Else
                Return Destino_Tierra.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Situacion_Actual() As String
        Get
            If Me.Situacion_Actual_Tierras Is Nothing Then
                Return ""
            Else
                Return Situacion_Actual_Tierras.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property CausasDesplazamiento() As String
        Get
            Dim wcadena As String = ""
            For Each fila As Declaracion_Causas_DesplazamientoBrl In Declaracion_Causas_Desplazamiento
                wcadena = wcadena + fila.SubTablasCausa_Desplazamiento.Descripcion + "-"
            Next
            Return wcadena
        End Get
    End Property

    Public ReadOnly Property TiempoDeclarar() As String
        Get
            If Me.Cuanto_Tiempo_Demoro Is Nothing Then
                Return ""
            Else
                Return Cuanto_Tiempo_Demoro.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property TardoTiempoDeclarar() As String
        Get
            If Me.Motivo_Demora Is Nothing Then
                Return ""
            Else
                Return Motivo_Demora.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property EsDelMunicipio() As String
        Get
            If Me.Es_Del_Municipio Is Nothing Then
                Return ""
            Else
                Return Es_Del_Municipio.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property MotivoNoDecMunicipio() As String
        Get
            If Me.Motivo_NoDeclaro_Municipio Is Nothing Then
                Return ""
            Else
                Return Motivo_NoDeclaro_Municipio.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property VivioCabMunicipal() As String
        Get
            If Me.Vivio_Cabezera_Municipal Is Nothing Then
                Return ""
            Else
                Return Vivio_Cabezera_Municipal.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property TiempoCascoUrbano() As String
        Get
            If Me.Tiempo_Casco_Urbano Is Nothing Then
                Return ""
            Else
                Return Tiempo_Casco_Urbano.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property BuscoAyuda() As String
        Get
            If Me.Tiempo_Casco_Urbano Is Nothing Then
                Return ""
            Else
                Return Tiempo_Casco_Urbano.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property EntidadInicial() As String
        Get
            If Me.Entidad_Inicial_Atencion Is Nothing Then
                Return ""
            Else
                Return Entidad_Inicial_Atencion.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property ComoFueAtencion() As String
        Get
            If Me.Como_Fue_Atencion Is Nothing Then
                Return ""
            Else
                Return Como_Fue_Atencion.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property BrindarAtencion() As String
        Get
            If Me.Como_Brindar_Atencion Is Nothing Then
                Return ""
            Else
                Return Como_Brindar_Atencion.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Declarante_Solicito_Ayuda() As String
        Get
            If Me.Solicito_Ayuda Is Nothing Then
                Return ""
            Else
                Return Solicito_Ayuda.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property DeclaracionEnLinea() As String
        Get
            If Me.EnLinea Is Nothing Then
                Return ""
            Else
                Return EnLinea.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Agua_potable() As String
        Get
            If Me.AguaPotable Is Nothing Then
                Return ""
            Else
                Return AguaPotable.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Tiene_Documento() As String
        Get
            If Me.TieneDocumento Is Nothing Then
                Return ""
            Else
                Return TieneDocumento.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Es_Benefiado_programas() As String
        Get
            If Me.Beneficiado_programas Is Nothing Then
                Return ""
            Else
                Return Beneficiado_programas.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Ha_Oido_Mesa_Desplazados() As String
        Get
            Dim wcadena As String = ""
            If Declaracion_Seguimientos.Count > 0 Then
                If Declaracion_Seguimientos.Item(0).Id_Tipo_Entrega = 918 Then
                    Return Declaracion_Seguimientos.Item(0).Oido_OVD.Descripcion
                Else
                    Return ""
                End If
            End If
            Return ""
        End Get
    End Property

    Public ReadOnly Property ADD_Familias_Accion() As String
        Get
            If Familias_Accion Is Nothing Then
                Return ""
            Else
                Return Familias_Accion.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property ADD_Unidos() As String
        Get
            If Unidos Is Nothing Then
                Return ""
            Else
                Return Unidos.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Ha_VBG_General() As String
        Get
            If VBG_General Is Nothing Then
                Return ""
            Else
                Return VBG_General.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Ha_Afectado_Desplazamiento() As String
        Get
            If Afectado_Desplazamiento Is Nothing Then
                Return ""
            Else
                Return Afectado_Desplazamiento.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Ha_Sentido_Emociones() As String
        Get
            If Emociones Is Nothing Then
                Return ""
            Else
                Return Emociones.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Ha_Tenido_Adiccion() As String
        Get
            If Tipo_Adiccion Is Nothing Then
                Return ""
            Else
                Return Tipo_Adiccion.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Ha_Adiccion_Alcohol() As String
        Get
            If Adiccion_Alcohol Is Nothing Then
                Return ""
            Else
                Return Adiccion_Alcohol.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Ha_Adiccion_Droga() As String
        Get
            If Adiccion_Droga Is Nothing Then
                Return ""
            Else
                Return Adiccion_Droga.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property PersonasAyuda() As String
        Get
            Dim wcadena As String = ""
            For Each fila As Declaracion_Personas_AyudaBrl In Declaracion_Personas_Ayuda
                wcadena = wcadena + fila.Personas_Ayuda.Descripcion + "-"
            Next
            Return wcadena
        End Get
    End Property

    Public ReadOnly Property ApoyoAyuda() As String
        Get
            Dim wcadena As String = ""
            For Each fila As Declaracion_Apoyo_AyudaBrl In Declaracion_Apoyo_Ayuda
                wcadena = wcadena + fila.Apoyo_Ayuda.Descripcion + "-"
            Next
            Return wcadena
        End Get
    End Property


    Public ReadOnly Property EntidadesAyuda() As String
        Get
            Dim wcadena As String = ""
            For Each fila As Declaracion_Entidades_AyudaBrl In Declaracion_Entidades_Ayuda
                wcadena = wcadena + fila.SubTablasEntidad_Ayuda.Descripcion + "-"
            Next
            Return wcadena
        End Get
    End Property

    Public ReadOnly Property TiposdeAyuda() As String
        Get
            Dim wcadena As String = ""
            For Each fila As Declaracion_Ayudas_DadasBrl In Declaracion_Ayudas_Dadas
                wcadena = wcadena + fila.Tipo_Ayuda.Descripcion + "-"
            Next
            Return wcadena
        End Get
    End Property

    Public ReadOnly Property ObtencionAgua() As String
        Get
            Dim wcadena As String = ""
            For Each fila As Declaracion_Obtencion_AguaBrl In Declaracion_Obtencion_Agua
                wcadena = wcadena + fila.SubTablasLugar_Agua.Descripcion + "-"
            Next
            Return wcadena
        End Get
    End Property

    Public ReadOnly Property FuenteIngresos() As String
        Get
            Dim wcadena As String = ""
            For Each fila As Declaracion_Fuentes_IngresoBrl In Declaracion_Fuentes_Ingreso
                wcadena = wcadena + fila.Fuentes_Ingreso.Descripcion + "-"
            Next
            Return wcadena
        End Get
    End Property

    Public ReadOnly Property DanosFamilia() As String
        Get
            Dim wcadena As String = ""
            For Each fila As Declaracion_Danos_FamiliaBrl In Declaracion_Danos_Familia
                wcadena = wcadena + fila.SubTablasDanos_Familia.Descripcion + "-"
            Next
            Return wcadena
        End Get
    End Property

    Public ReadOnly Property Declaracion_Bienes_Perdio() As String
        Get
            Dim wcadena As String = ""
            For Each fila As Declaracion_BienesBrl In Declaracion_Bienes
                wcadena = wcadena + fila.SubTablasBienes.Descripcion + "-"
            Next
            Return wcadena
        End Get
    End Property

    Public ReadOnly Property EstadoRUV() As String
        Get
            Dim wsalida As String = " "
            For Each fila As Declaracion_UnidadesBrl In Declaracion_Unidades
                If fila.Id_Unidad = 32 Then
                    wsalida = fila.EstadoUnidad.Descripcion
                End If
            Next
            Return wsalida
        End Get
    End Property

    Public ReadOnly Property Fecha_Valoracion_RUV() As Date
        Get
            Dim wsalida As Date = Nothing
            For Each fila As Declaracion_UnidadesBrl In Declaracion_Unidades
                If fila.Id_Unidad = 32 Then
                    wsalida = fila.Fecha_Inclusion
                End If
            Next
            Return wsalida
        End Get
    End Property

    Public ReadOnly Property WFecha_Valoracion_RUV As String
        Get
            If Fecha_Valoracion_RUV.Year = 1 Then
                Return ""
            Else
                Return Format(Fecha_Valoracion_RUV, "dd/MMM/yyyy")
            End If
        End Get
    End Property

    Public ReadOnly Property Fecha_Investigacion_RUV() As Date
        Get
            Dim wsalida As Date = Nothing
            For Each fila As Declaracion_UnidadesBrl In Declaracion_Unidades
                If fila.Id_Unidad = 32 Then
                    wsalida = fila.Fecha_Investigacion
                End If
            Next
            Return wsalida
        End Get
    End Property

    Public ReadOnly Property WFecha_Investigacion_RUV As String
        Get
            If Fecha_Investigacion_RUV.Year = 1 Then
                Return ""
            Else
                Return Format(Fecha_Investigacion_RUV, "dd/MMM/yyyy")
            End If
        End Get
    End Property

    ' PAARI

    Public ReadOnly Property EstadoPAARI() As String
        Get
            Dim wsalida As String = ""
            For Each fila As Declaracion_UnidadesBrl In Declaracion_Unidades
                If fila.Id_Unidad = 274 Then
                    Try
                        wsalida = fila.EstadoUnidad.Descripcion
                    Catch ex As Exception
                        wsalida = ""
                    End Try

                End If
            Next
            Return wsalida
        End Get
    End Property

    Public ReadOnly Property Fecha_InclusionPAARI() As Date
        Get
            Dim wsalida As Date = Nothing
            For Each fila As Declaracion_UnidadesBrl In Declaracion_Unidades
                If fila.Id_Unidad = 274 Then
                    wsalida = fila.Fecha_Inclusion
                End If
            Next
            Return wsalida
        End Get
    End Property

    Public ReadOnly Property WFecha_InclusionPAARI As String
        Get
            If Fecha_InclusionPAARI.Year = 1 Then
                Return ""
            Else
                Return Format(Fecha_InclusionPAARI, "dd/MMM/yyyy")
            End If
        End Get
    End Property

    Public ReadOnly Property Fecha_InvestigacionPAARI() As Date
        Get
            Dim wsalida As Date = Nothing
            For Each fila As Declaracion_UnidadesBrl In Declaracion_Unidades
                If fila.Id_Unidad = 274 Then
                    wsalida = fila.Fecha_Investigacion
                End If
            Next
            Return wsalida
        End Get
    End Property

    Public ReadOnly Property WFecha_InvestigacionPAARI As String
        Get
            If Fecha_InvestigacionPAARI.Year = 1 Then
                Return ""
            Else
                Return Format(Fecha_InvestigacionPAARI, "dd/MMM/yyyy")
            End If
        End Get
    End Property

    ' Familias en Acción

    Public ReadOnly Property EstadoFaccion() As String
        Get
            Dim wsalida As String = " "
            For Each fila As Declaracion_UnidadesBrl In Declaracion_Unidades
                If fila.Id_Unidad = 273 Then
                    wsalida = fila.EstadoUnidad.Descripcion
                End If
            Next
            Return wsalida
        End Get
    End Property

    Public ReadOnly Property Fecha_InclusionFaccion() As Date
        Get
            Dim wsalida As Date = Nothing
            For Each fila As Declaracion_UnidadesBrl In Declaracion_Unidades
                If fila.Id_Unidad = 273 Then
                    wsalida = fila.Fecha_Inclusion
                End If
            Next
            Return wsalida
        End Get
    End Property

    Public ReadOnly Property WFecha_InclusionFaccion As String
        Get
            If Fecha_InclusionFaccion.Year = 1 Then
                Return ""
            Else
                Return Format(Fecha_InclusionFaccion, "dd/MMM/yyyy")
            End If
        End Get
    End Property

    Public ReadOnly Property Fecha_InvestigacionFaccion() As Date
        Get
            Dim wsalida As Date = Nothing
            For Each fila As Declaracion_UnidadesBrl In Declaracion_Unidades
                If fila.Id_Unidad = 273 Then
                    wsalida = fila.Fecha_Investigacion
                End If
            Next
            Return wsalida
        End Get
    End Property

    Public ReadOnly Property WFecha_InvestigacionFaccion As String
        Get
            If Fecha_InvestigacionFaccion.Year = 1 Then
                Return ""
            Else
                Return Format(Fecha_InvestigacionFaccion, "dd/MMM/yyyy")
            End If
        End Get
    End Property

    ' Acto Administrativo

    Public ReadOnly Property EstadoActoAdministrativo() As String
        Get
            Dim wsalida As String = " "
            For Each fila As Declaracion_UnidadesBrl In Declaracion_Unidades
                If fila.Id_Unidad = 161 Then
                    wsalida = fila.EstadoUnidad.Descripcion
                End If
            Next
            Return wsalida
        End Get
    End Property

    Public ReadOnly Property Fecha_InclusionEstadoActoAdministrativo() As Date
        Get
            Dim wsalida As Date = Nothing
            For Each fila As Declaracion_UnidadesBrl In Declaracion_Unidades
                If fila.Id_Unidad = 161 Then
                    wsalida = fila.Fecha_Inclusion
                End If
            Next
            Return wsalida
        End Get
    End Property

    Public ReadOnly Property WFecha_InclusionEstadoActoAdministrativo As String
        Get
            If Fecha_InclusionEstadoActoAdministrativo.Year = 1 Then
                Return ""
            Else
                Return Format(Fecha_InclusionEstadoActoAdministrativo, "dd/MMM/yyyy")
            End If
        End Get
    End Property

    Public ReadOnly Property Fecha_InvestigacionEstadoActoAdministrativo() As Date
        Get
            Dim wsalida As Date = Nothing
            For Each fila As Declaracion_UnidadesBrl In Declaracion_Unidades
                If fila.Id_Unidad = 161 Then
                    wsalida = fila.Fecha_Investigacion
                End If
            Next
            Return wsalida
        End Get
    End Property

    Public ReadOnly Property WFecha_InvestigacionEstadoActoAdministrativo As String
        Get
            If Fecha_InclusionEstadoActoAdministrativo.Year = 1 Then
                Return ""
            Else
                Return Format(Fecha_InvestigacionEstadoActoAdministrativo, "dd/MMM/yyyy")
            End If
        End Get
    End Property


    ' Notificacion

    Public ReadOnly Property EstadoNotificacion() As String
        Get
            Dim wsalida As String = " "
            For Each fila As Declaracion_UnidadesBrl In Declaracion_Unidades
                If fila.Id_Unidad = 1501 Then
                    wsalida = fila.EstadoUnidad.Descripcion
                End If
            Next
            Return wsalida
        End Get
    End Property

    Public ReadOnly Property Fecha_InclusionNotificacion() As Date
        Get
            Dim wsalida As Date = Nothing
            For Each fila As Declaracion_UnidadesBrl In Declaracion_Unidades
                If fila.Id_Unidad = 1501 Then
                    wsalida = fila.Fecha_Inclusion
                End If
            Next
            Return wsalida
        End Get
    End Property

    Public ReadOnly Property WFecha_InclusionNotificacion As String
        Get
            If Fecha_InclusionNotificacion.Year = 1 Then
                Return ""
            Else
                Return Format(Fecha_InclusionNotificacion, "dd/MMM/yyyy")
            End If
        End Get
    End Property

    Public ReadOnly Property Fecha_InvestigacionNotificacion() As Date
        Get
            Dim wsalida As Date = Nothing
            For Each fila As Declaracion_UnidadesBrl In Declaracion_Unidades
                If fila.Id_Unidad = 1501 Then
                    wsalida = fila.Fecha_Investigacion
                End If
            Next
            Return wsalida
        End Get
    End Property

    Public ReadOnly Property WFecha_InvestigacionNotificacion As String
        Get
            If Fecha_InclusionNotificacion.Year = 1 Then
                Return ""
            Else
                Return Format(Fecha_InvestigacionNotificacion, "dd/MMM/yyyy")
            End If
        End Get
    End Property

    Public ReadOnly Property MunicipioFaccion() As String
        Get
            If Municipio_Faccion Is Nothing Then
                Return ""
            Else
                Return Municipio_Faccion.Descripcion
            End If
        End Get
    End Property


    '
    ''''Estados de la declaracion
    '

    Public ReadOnly Property Elegible() As String
        Get
            Dim wcadena As String = ""
            For Each fila As Declaracion_EstadosBrl In Declaracion_Estados
                If fila.TipoEstado.Orden = 10 Then
                    wcadena = fila.ComoEstado.Descripcion
                End If
            Next
            Return wcadena
        End Get
    End Property

    Public ReadOnly Property Fecha_Elegible() As String
        Get
            Dim wfecha As DateTime = Nothing
            For Each fila As Declaracion_EstadosBrl In Declaracion_Estados
                If fila.TipoEstado.Orden = 10 Then
                    wfecha = fila.Fecha
                End If
            Next
            If wfecha = Nothing Then
                Return ""
            Else
                Return Format(wfecha, "dd/MMM/yyyy")
            End If

        End Get
    End Property

    Public ReadOnly Property Contactado() As String
        Get
            Dim wcadena As String = ""
            For Each fila As Declaracion_EstadosBrl In Declaracion_Estados
                If fila.TipoEstado.Orden = 20 Then
                    wcadena = fila.ComoEstado.Descripcion
                End If
            Next
            Return wcadena
        End Get
    End Property

    Public ReadOnly Property Fecha_Contactado() As String
        Get
            Dim wfecha As DateTime = Nothing
            For Each fila As Declaracion_EstadosBrl In Declaracion_Estados
                If fila.TipoEstado.Orden = 20 Then
                    wfecha = fila.Fecha
                End If
            Next
            If wfecha = Nothing Then
                Return ""
            Else
                Return Format(wfecha, "dd/MMM/yyyy")
            End If
        End Get
    End Property

    Public ReadOnly Property Programado() As String
        Get
            Dim wcadena As String = ""
            For Each fila As Declaracion_EstadosBrl In Declaracion_Estados
                If fila.TipoEstado.Orden = 30 Then
                    wcadena = fila.ComoEstado.Descripcion
                End If
            Next
            Return wcadena
        End Get
    End Property

    Public ReadOnly Property Fecha_Programado() As String
        Get
            Dim wfecha As DateTime = Nothing
            For Each fila As Declaracion_EstadosBrl In Declaracion_Estados
                If fila.TipoEstado.Orden = 30 Then
                    wfecha = fila.Fecha
                End If
            Next
            If wfecha = Nothing Then
                Return ""
            Else
                Return Format(wfecha, "dd/MMM/yyyy")
            End If
        End Get
    End Property

    Public ReadOnly Property Reprogramado() As String
        Get
            Dim wcadena As String = ""
            For Each fila As Declaracion_EstadosBrl In Declaracion_Estados
                If fila.TipoEstado.Orden = 50 Then
                    wcadena = fila.ComoEstado.Descripcion
                End If
            Next
            Return wcadena
        End Get
    End Property

    Public ReadOnly Property Fecha_Reprogramado() As String
        Get
            Dim wfecha As DateTime = Nothing
            For Each fila As Declaracion_EstadosBrl In Declaracion_Estados
                If fila.TipoEstado.Orden = 50 Then
                    wfecha = fila.Fecha
                End If
            Next
            If wfecha = Nothing Then
                Return ""
            Else
                Return Format(wfecha, "dd/MMM/yyyy")
            End If
        End Get
    End Property

    Public ReadOnly Property TipoEntregaReprogramacion As String
        Get
            Dim wcadena As String = ""
            For Each fila As Declaracion_EstadosBrl In Declaracion_Estados
                If (fila.Id_Tipo_Estado = 4038) Or (fila.Id_Tipo_Estado = 4039) Then
                    If fila.Id_Asistio = 20 Then
                        wcadena = fila.Programa.TipoEntrega.Descripcion
                    End If
                End If
            Next
            Return wcadena
        End Get
    End Property

    Public ReadOnly Property Ha_Pertenece_Asociacion() As String
        Get
            Dim wcadena As String = ""
            If Declaracion_Seguimientos.Count > 0 Then
                If Declaracion_Seguimientos.Item(0).Id_Tipo_Entrega = 918 Then
                    If Declaracion_Seguimientos.Item(0).Id_Pertenece_OVD <> 0 Then
                        Return Declaracion_Seguimientos.Item(0).Pertenece_OVD.Descripcion
                    End If
                Else
                    Return ""
                End If
            End If
            Return ""
        End Get
    End Property

    Public ReadOnly Property Ha_Afectado_Desplazamiento_2E() As String
        Get
            Dim wcadena As String = ""
            If Declaracion_Seguimientos.Count > 0 Then
                If Declaracion_Seguimientos.Item(0).Id_Tipo_Entrega = 918 Then
                    Return Declaracion_Seguimientos.Item(0).Afectado_Desplazamiento.Descripcion
                Else
                    Return ""
                End If
            End If
            Return ""
        End Get
    End Property

    Public ReadOnly Property Ha_Sentido_Emociones_Hablar() As String
        Get
            Dim wcadena As String = ""
            If Declaracion_Seguimientos.Count > 0 Then
                If Declaracion_Seguimientos.Item(0).Id_Tipo_Entrega = 918 Then
                    Return Declaracion_Seguimientos.Item(0).Emociones.Descripcion
                Else
                    Return ""
                End If
            End If
            Return ""
        End Get
    End Property

    Public ReadOnly Property VFechaAtencion As String
        Get
            If Fecha_Valoracion.Year = 1 Then
                Return ""
            Else
                Return Format(Fecha_Valoracion, "dd/MMM/yyyy")
            End If

        End Get
    End Property

    Public ReadOnly Property Ninos05 As Integer
        Get
            Dim wcant As Integer = 0
            For Each fila As PersonasBrl In Personas
                If fila.Edad >= 0 And fila.Edad < 5 Then
                    wcant += 1
                End If
            Next
            Return wcant
        End Get
    End Property

    Public ReadOnly Property Ninos0617 As Integer
        Get
            Dim wcant As Integer = 0
            For Each fila As PersonasBrl In Personas
                If fila.Edad >= 6 And fila.Edad <= 17 Then
                    wcant += 1
                End If
            Next
            Return wcant
        End Get
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
            Me.ID = DeclaracionDAL.Insertar(Id_Fuente, Fecha_Declaracion, Gestantes, Menores_Ninos, Menores_Ninas, Recien_Nacidos, Lactantes, Resto_Nucleo, Fecha_Desplazamiento, Id_Municipio_Expulsor, Vereda_Desplazamiento, Fecha_Valoracion, Id_Ha_Regresado, Id_Retornaria, Id_Explicacion_Retorno, Id_Ha_Declarado_Antes, Id_Ha_Recibido_Ayuda, Id_Ha_Muerto_Alguien, Cuantos_Muertos, Cuantos_Muertos_Menores, Id_Motivo_Muerte, Id_Parentesco_Muerte, Id_Enfermedad, Id_Velar_Enterrar, Id_Tiene_Desaparecido, Id_Parentesco_Desaparecido, Id_Reporto, Id_Entidad_Legal, Id_Aplico_Reparaciones, Dias_Aplico, Id_Estado_Aplicacion, Id_Motivo_No_Aplico, Id_Llegada_Insultos, Id_Llegada_Insultos_Usted, Id_Llegada_Insultos_Miembro, Llegada_Insultos_Agresor, Id_Llegada_Sexual, Id_Llegada_Sexual_Usted, Id_Llegada_Sexual_Miembro, Llegada_Sexual_Agresor, Id_Llegada_Golpes, Id_Llegada_Golpes_Usted, Id_Llegada_Golpes_Miembro, Llegada_Golpes_Agresor, Fecha_Segunda_Encuesta, Id_Ha_Redibido_Ayuda_Despues, Dias_Aplico_Despues, Id_Estatus_Aplicacion_Despues, Id_Razon_No_Aplico, Id_Oido_Mesa_Desplazados, Id_Pertenece_Asociacion, Cual_Asociacion, Id_Esta_Trabajando, Id_Beneficiado_Programas, Id_Grupo, Id_Regional, Id_Atender, Id_Motivo_Noatender, Id_Tipo_Tenencia_Vivienda, Id_Cuantas_Habitaciones, Id_Cuantas_Personas_Vivienda, Id_Cuantas_Personas_Habitacion, Id_Materiales_Vivienda, Id_Forma_Declaracion, Id_Departamento_Expulsor, Id_Cuantos_Desplazamientos, Lugar_Desplazamiento, Fecha_Desplazamiento_Anterior, Id_Motivo_Desplazamiento, Id_Cuanto_Tiempo_Demoro, Id_Motivo_Demora, Id_Motivo_NoDeclaro_Municipio, Id_Vivio_Cabezera_Municipal, Id_Tiempo_Casco_Urbano, Id_Entidad_Inicial_Atencion, Id_Recibio_Ayuda_Entidad_Inicial, Id_Como_Fue_Atencion, Id_Como_Brindar_Atencion, Promedio_Ingresos_Mensuales, Fecha_Muerte, Cuantos_Familiares_Desaparecidos, Id_Porque_No_Reporto, Id_Despues_Hijos_617, Cuantos_Despues_Hijos, Cuantos_Despues_Hijos_Estudian, Id_Tipo_Bien_Rural, Id_Documento_Propiedad, Id_Destino_Tierra, Id_Situacion_Actual_Tierras, Observaciones, Id_Despues_Afiliado_Regimen_Subsidiado, Cuantos_Despues_Afiliado_Regimen_Subsidiado, Id_Despues_Afiliado_Regimen_Contributivo, Cuantos_Despues_Afiliado_Regimen_Contributivo, Id_Despues_Afiliado_Sisben, Cuantos_Despues_Afiliado_Sisben, Id_ley_reparacion.ToString, Id_Es_Del_Municipio, Motivo_Desplazamiento, Fecha_Ingreso_Registro, Tipo_Declaracion, Horario, Id_Tipo_Familia_desplazada, Id_Vulnerables_NoDesplazada, Motivo_Remision, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Id_Solicito_Ayuda, Id_Concejo_Expulsor, Id_Lugar_Fuente, Id_EnLinea, Id_Agua_Potable, Id_Tiene_Documento, Id_Tipo_Familia_No_Desplazada, Fecha_Radicacion, Numero_Declaracion, Fecha_Cierre, Cierre, Id_Familias_Accion, Id_Red_Unidos, Municipio_Unidos, Id_VBG_general, VBG_General_Agresor, Id_Ha_Muerto_Despues, Id_Solicito_Atencion_Psicologica, Id_Afectado_Desplazamiento, Id_Emociones, Id_Tipo_Adiccion, Id_Adiccion_Alcohol, Id_Adiccion_Droga, Municipio_Familias_Accion, Id_Municipio_Faccion)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            DeclaracionDAL.Actualizar(ID, Id_Fuente, Fecha_Declaracion, Gestantes, Menores_Ninos, Menores_Ninas, Recien_Nacidos, Lactantes, Resto_Nucleo, Fecha_Desplazamiento, Id_Municipio_Expulsor, Vereda_Desplazamiento, Fecha_Valoracion, Id_Ha_Regresado, Id_Retornaria, Id_Explicacion_Retorno, Id_Ha_Declarado_Antes, Id_Ha_Recibido_Ayuda, Id_Ha_Muerto_Alguien, Cuantos_Muertos, Cuantos_Muertos_Menores, Id_Motivo_Muerte, Id_Parentesco_Muerte, Id_Enfermedad, Id_Velar_Enterrar, Id_Tiene_Desaparecido, Id_Parentesco_Desaparecido, Id_Reporto, Id_Entidad_Legal, Id_Aplico_Reparaciones, Dias_Aplico, Id_Estado_Aplicacion, Id_Motivo_No_Aplico, Id_Llegada_Insultos, Id_Llegada_Insultos_Usted, Id_Llegada_Insultos_Miembro, Llegada_Insultos_Agresor, Id_Llegada_Sexual, Id_Llegada_Sexual_Usted, Id_Llegada_Sexual_Miembro, Llegada_Sexual_Agresor, Id_Llegada_Golpes, Id_Llegada_Golpes_Usted, Id_Llegada_Golpes_Miembro, Llegada_Golpes_Agresor, Fecha_Segunda_Encuesta, Id_Ha_Redibido_Ayuda_Despues, Dias_Aplico_Despues, Id_Estatus_Aplicacion_Despues, Id_Razon_No_Aplico, Id_Oido_Mesa_Desplazados, Id_Pertenece_Asociacion, Cual_Asociacion, Id_Esta_Trabajando, Id_Beneficiado_Programas, Id_Grupo, Id_Regional, Id_Atender, Id_Motivo_Noatender, Id_Tipo_Tenencia_Vivienda, Id_Cuantas_Habitaciones, Id_Cuantas_Personas_Vivienda, Id_Cuantas_Personas_Habitacion, Id_Materiales_Vivienda, Id_Forma_Declaracion, Id_Departamento_Expulsor, Id_Cuantos_Desplazamientos, Lugar_Desplazamiento, Fecha_Desplazamiento_Anterior, Id_Motivo_Desplazamiento, Id_Cuanto_Tiempo_Demoro, Id_Motivo_Demora, Id_Motivo_NoDeclaro_Municipio, Id_Vivio_Cabezera_Municipal, Id_Tiempo_Casco_Urbano, Id_Entidad_Inicial_Atencion, Id_Recibio_Ayuda_Entidad_Inicial, Id_Como_Fue_Atencion, Id_Como_Brindar_Atencion, Promedio_Ingresos_Mensuales, Fecha_Muerte, Cuantos_Familiares_Desaparecidos, Id_Porque_No_Reporto, Id_Despues_Hijos_617, Cuantos_Despues_Hijos, Cuantos_Despues_Hijos_Estudian, Id_Tipo_Bien_Rural, Id_Documento_Propiedad, Id_Destino_Tierra, Id_Situacion_Actual_Tierras, Observaciones, Id_Despues_Afiliado_Regimen_Subsidiado, Cuantos_Despues_Afiliado_Regimen_Subsidiado, Id_Despues_Afiliado_Regimen_Contributivo, Cuantos_Despues_Afiliado_Regimen_Contributivo, Id_Despues_Afiliado_Sisben, Cuantos_Despues_Afiliado_Sisben, Id_ley_reparacion.ToString, Id_Es_Del_Municipio, Motivo_Desplazamiento, Fecha_Ingreso_Registro, Tipo_Declaracion, Horario, Id_Tipo_Familia_desplazada, Id_Vulnerables_NoDesplazada, Motivo_Remision, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Id_Solicito_Ayuda, Id_Concejo_Expulsor, Id_Lugar_Fuente, Id_EnLinea, Id_Agua_Potable, Id_Tiene_Documento, Id_Tipo_Familia_No_Desplazada, Fecha_Radicacion, Numero_Declaracion, Fecha_Cierre, Cierre, Id_Familias_Accion, Id_Red_Unidos, Municipio_Unidos, Id_VBG_general, VBG_General_Agresor, Id_Ha_Muerto_Despues, Id_Solicito_Atencion_Psicologica, Id_Afectado_Desplazamiento, Id_Emociones, Id_Tipo_Adiccion, Id_Adiccion_Alcohol, Id_Adiccion_Droga, Municipio_Familias_Accion, Id_Municipio_Faccion)
            RaiseEvent Updated()
        End If
        If Not objListDeclaracion_Entidades_Ayuda Is Nothing Then
            For Each fila As Declaracion_Entidades_AyudaBrl In objListDeclaracion_Entidades_Ayuda
                fila.Id_Declaracion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracion_Fuentes_Ingreso Is Nothing Then
            For Each fila As Declaracion_Fuentes_IngresoBrl In objListDeclaracion_Fuentes_Ingreso
                fila.Id_Declaracion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracion_Obtencion_Agua Is Nothing Then
            For Each fila As Declaracion_Obtencion_AguaBrl In objListDeclaracion_Obtencion_Agua
                fila.Id_Declaracion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracion_Trabajos Is Nothing Then
            For Each fila As Declaracion_TrabajosBrl In objListDeclaracion_Trabajos
                fila.Id_Declaracion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListPersonas Is Nothing Then
            For Each fila As PersonasBrl In objListPersonas
                fila.Id_Declaracion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListDeclaracion_Programas_Ayuda Is Nothing Then
            For Each fila As Declaracion_Programas_AyudaBrl In objListDeclaracion_Programas_Ayuda
                fila.Id_Declaracion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracion_Bienes Is Nothing Then
            For Each fila As Declaracion_BienesBrl In objListDeclaracion_Bienes
                fila.Id_Declaracion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracion_Causas_Desplazamiento Is Nothing Then
            For Each fila As Declaracion_Causas_DesplazamientoBrl In objListDeclaracion_Causas_Desplazamiento
                fila.Id_Declaracion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracion_Causas_NoEstudio Is Nothing Then
            For Each fila As Declaracion_Causas_NoEstudioBrl In objListDeclaracion_Causas_NoEstudio
                fila.Id_Declaracion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracion_Danos_Familia Is Nothing Then
            For Each fila As Declaracion_Danos_FamiliaBrl In objListDeclaracion_Danos_Familia
                fila.Id_Declaracion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracion_Instituciones_Confianza Is Nothing Then
            For Each fila As Declaracion_Instituciones_ConfianzaBrl In objListDeclaracion_Instituciones_Confianza
                fila.Id_Declaracion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracion_Nivel_Educativo Is Nothing Then
            For Each fila As Declaracion_Nivel_EducativoBrl In objListDeclaracion_Nivel_Educativo
                fila.Id_Declaracion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracion_Servicio_salud Is Nothing Then
            For Each fila As Declaracion_Servicio_saludBrl In objListDeclaracion_Servicio_salud
                fila.Id_Declaracion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If


        If Not objListDeclaracion_Vulnerabilidad Is Nothing Then
            For Each fila As Declaracion_VulnerabilidadBrl In objListDeclaracion_Vulnerabilidad
                fila.Id_Declaracion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracion_Unidades Is Nothing Then
            For Each fila As Declaracion_UnidadesBrl In objListDeclaracion_Unidades
                fila.Id_Declaracion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracion_Muertos Is Nothing Then
            For Each fila As Declaracion_MuertosBrl In objListDeclaracion_Muertos
                fila.Id_Declaracion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracion_Desaparecidos Is Nothing Then
            For Each fila As Declaracion_DesaparecidosBrl In objListDeclaracion_Desaparecidos
                fila.Id_Declaracion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracion_Psicosocial Is Nothing Then
            For Each fila As Declaracion_PsicosocialBrl In objListDeclaracion_Psicosocial
                fila.Id_Declaracion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If


        If Not objListDeclaracion_Personas_Ayuda Is Nothing Then
            For Each fila As Declaracion_Personas_AyudaBrl In objListDeclaracion_Personas_Ayuda
                fila.Id_Declaracion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracion_Apoyo_Ayuda Is Nothing Then
            For Each fila As Declaracion_Apoyo_AyudaBrl In objListDeclaracion_Apoyo_Ayuda
                fila.Id_Declaracion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListDeclaracion_Seguimientos Is Nothing Then
            For Each fila As Declaracion_SeguimientosBrl In objListDeclaracion_Seguimientos
                fila.Id_Declaracion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If


        If Not objListDeclaracion_PAARI Is Nothing Then
            For Each fila As Declaracion_PAARIBrl In objListDeclaracion_PAARI
                fila.Id_Declaracion = Me.ID
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

            totalHijos += Declaracion_Entidades_Ayuda.Count
            totalHijos += Declaracion_Fuentes_Ingreso.Count
            totalHijos += Declaracion_Obtencion_Agua.Count
            totalHijos += Declaracion_Trabajos.Count
            totalHijos += Personas.Count
            totalHijos += Declaracion_Programas_Ayuda.Count
            totalHijos += Declaracion_Bienes.Count
            totalHijos += Declaracion_Causas_Desplazamiento.Count
            totalHijos += Declaracion_Causas_NoEstudio.Count
            totalHijos += Declaracion_Danos_Familia.Count
            totalHijos += Declaracion_Instituciones_Confianza.Count
            totalHijos += Declaracion_Nivel_Educativo.Count
            totalHijos += Declaracion_Servicio_salud.Count
            totalHijos += Declaracion_Vulnerabilidad.Count
            totalHijos += Declaracion_Unidades.Count
            totalHijos += Declaracion_Estados.Count
            totalHijos += Declaracion_Muertos.Count
            totalHijos += Declaracion_Desaparecidos.Count
            totalHijos += Declaracion_Psicosocial.Count
            totalHijos += Declaracion_Personas_Ayuda.Count
            totalHijos += Declaracion_Apoyo_Ayuda.Count
            totalHijos += Declaracion_Seguimientos.Count
            totalHijos += Declaracion_PAARI.Count
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")

            DeclaracionDAL.Eliminar(Me.ID)

            RaiseEvent Deleted()

        End If
    End Sub

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As DeclaracionBrl

        Dim objDeclaracion As New DeclaracionBrl

        With objDeclaracion
            .ID = fila("Id")
            .Id_Fuente = isDBNullToNothing(fila("Id_Fuente"))
            .Fecha_Declaracion = isDBNullToNothing(fila("Fecha_Declaracion"))
            .Gestantes = isDBNullToNothing(fila("Gestantes"))
            .Lactantes = isDBNullToNothing(fila("Lactantes"))
            .Menores_Ninos = isDBNullToNothing(fila("Menores_Ninos"))
            .Menores_Ninas = isDBNullToNothing(fila("Menores_Ninas"))
            .Recien_Nacidos = isDBNullToNothing(fila("Recien_Nacidos"))
            .Resto_Nucleo = isDBNullToNothing(fila("Resto_Nucleo"))
            .Fecha_Desplazamiento = isDBNullToNothing(fila("Fecha_Desplazamiento"))
            .Id_Municipio_Expulsor = isDBNullToNothing(fila("Id_Municipio_Expulsor"))
            .Vereda_Desplazamiento = isDBNullToNothing(fila("Vereda_Desplazamiento"))
            .Fecha_Valoracion = isDBNullToNothing(fila("Fecha_Valoracion"))
            .Id_Ha_Regresado = isDBNullToNothing(fila("Id_Ha_Regresado"))
            .Id_Retornaria = isDBNullToNothing(fila("Id_Retornaria"))
            .Id_Explicacion_Retorno = isDBNullToNothing(fila("Id_Explicacion_Retorno"))
            .Id_Ha_Declarado_Antes = isDBNullToNothing(fila("Id_Ha_Declarado_Antes"))
            .Id_Ha_Recibido_Ayuda = isDBNullToNothing(fila("Id_Ha_Recibido_Ayuda"))
            .Id_Ha_Muerto_Alguien = isDBNullToNothing(fila("Id_Ha_Muerto_Alguien"))
            .Cuantos_Muertos = isDBNullToNothing(fila("Cuantos_Muertos"))
            .Cuantos_Muertos_Menores = isDBNullToNothing(fila("Cuantos_Muertos_Menores"))
            .Id_Motivo_Muerte = isDBNullToNothing(fila("Id_Motivo_Muerte"))
            .Id_Parentesco_Muerte = isDBNullToNothing(fila("Id_Parentesco_Muerte"))
            .Id_Enfermedad = isDBNullToNothing(fila("Id_Enfermedad"))
            .Id_Velar_Enterrar = isDBNullToNothing(fila("Id_Velar_Enterrar"))
            .Id_Tiene_Desaparecido = isDBNullToNothing(fila("Id_Tiene_Desaparecido"))
            .Id_Parentesco_Desaparecido = isDBNullToNothing(fila("Id_Parentesco_Desaparecido"))
            .Id_Reporto = isDBNullToNothing(fila("Id_Reporto"))
            .Id_Entidad_Legal = isDBNullToNothing(fila("Id_Entidad_Legal"))
            .Id_Aplico_Reparaciones = isDBNullToNothing(fila("Id_Aplico_Reparaciones"))
            .Dias_Aplico = isDBNullToNothing(fila("Dias_Aplico"))
            .Id_Estado_Aplicacion = isDBNullToNothing(fila("Id_Estado_Aplicacion"))
            .Id_Motivo_No_Aplico = isDBNullToNothing(fila("Id_Motivo_No_Aplico"))
            .Id_Llegada_Insultos = isDBNullToNothing(fila("Id_Llegada_Insultos"))
            .Id_Llegada_Insultos_Usted = isDBNullToNothing(fila("Id_Llegada_Insultos_Usted"))
            .Id_Llegada_Insultos_Miembro = isDBNullToNothing(fila("Id_Llegada_Insultos_Miembro"))
            .Llegada_Insultos_Agresor = isDBNullToNothing(fila("Llegada_Insultos_Agresor"))
            .Id_Llegada_Sexual = isDBNullToNothing(fila("Id_Llegada_Sexual"))
            .Id_Llegada_Sexual_Usted = isDBNullToNothing(fila("Id_Llegada_Sexual_Usted"))
            .Id_Llegada_Sexual_Miembro = isDBNullToNothing(fila("Id_Llegada_Sexual_Miembro"))
            .Llegada_Sexual_Agresor = isDBNullToNothing(fila("Llegada_Sexual_Agresor"))
            .Id_Llegada_Golpes = isDBNullToNothing(fila("Id_Llegada_Golpes"))
            .Id_Llegada_Golpes_Usted = isDBNullToNothing(fila("Id_Llegada_Golpes_Usted"))
            .Id_Llegada_Golpes_Miembro = isDBNullToNothing(fila("Id_Llegada_Golpes_Miembro"))
            .Llegada_Golpes_Agresor = isDBNullToNothing(fila("Llegada_Golpes_Agresor"))
            .Fecha_Segunda_Encuesta = isDBNullToNothing(fila("Fecha_Segunda_Encuesta"))
            .Id_Ha_Redibido_Ayuda_Despues = isDBNullToNothing(fila("Id_Ha_Redibido_Ayuda_Despues"))
            .Dias_Aplico_Despues = isDBNullToNothing(fila("Dias_Aplico_Despues"))
            .Id_Estatus_Aplicacion_Despues = isDBNullToNothing(fila("Id_Estatus_Aplicacion_Despues"))
            .Id_Razon_No_Aplico = isDBNullToNothing(fila("Id_Razon_No_Aplico"))
            .Id_Oido_Mesa_Desplazados = isDBNullToNothing(fila("Id_Oido_Mesa_Desplazados"))
            .Id_Pertenece_Asociacion = isDBNullToNothing(fila("Id_Pertenece_Asociacion"))
            .Cual_Asociacion = isDBNullToNothing(fila("Cual_Asociacion"))
            .Id_Esta_Trabajando = isDBNullToNothing(fila("Id_Esta_Trabajando"))
            .Id_Beneficiado_Programas = isDBNullToNothing(fila("Id_Beneficiado_programas"))
            .Id_Grupo = isDBNullToNothing(fila("Id_Grupo"))
            .Id_Regional = isDBNullToNothing(fila("Id_Regional"))
            .Id_Atender = isDBNullToNothing(fila("Id_Atender"))
            .Id_Motivo_Noatender = isDBNullToNothing(fila("Id_Motivo_Noatender"))
            .Id_Tipo_Tenencia_Vivienda = isDBNullToNothing(fila("Id_Tipo_Tenencia_Vivienda"))
            .Id_Cuantas_Habitaciones = isDBNullToNothing(fila("Id_Cuantas_Habitaciones"))
            .Id_Cuantas_Personas_Vivienda = isDBNullToNothing(fila("Id_Cuantas_Personas_Vivienda"))
            .Id_Cuantas_Personas_Habitacion = isDBNullToNothing(fila("Id_Cuantas_Personas_Habitacion"))
            .Id_Materiales_Vivienda = isDBNullToNothing(fila("Id_Materiales_Vivienda"))
            .Id_Forma_Declaracion = isDBNullToNothing(fila("Id_Forma_Declaracion"))
            .Id_Departamento_Expulsor = isDBNullToNothing(fila("Id_Departamento_Expulsor"))
            .Id_Cuantos_Desplazamientos = isDBNullToNothing(fila("Id_Cuantos_Desplazamientos"))
            .Lugar_Desplazamiento = isDBNullToNothing(fila("Lugar_Desplazamiento"))
            .Fecha_Desplazamiento_Anterior = isDBNullToNothing(fila("Fecha_Desplazamiento_Anterior"))
            .Id_Motivo_Desplazamiento = isDBNullToNothing(fila("Id_Motivo_Desplazamiento"))
            .Id_Cuanto_Tiempo_Demoro = isDBNullToNothing(fila("Id_Cuanto_Tiempo_Demoro"))
            .Id_Motivo_Demora = isDBNullToNothing(fila("Id_Motivo_Demora"))
            .Id_Motivo_NoDeclaro_Municipio = isDBNullToNothing(fila("Id_Motivo_NoDeclaro_Municipio"))
            .Id_Vivio_Cabezera_Municipal = isDBNullToNothing(fila("Id_Vivio_Cabezera_Municipal"))
            .Id_Tiempo_Casco_Urbano = isDBNullToNothing(fila("Id_Tiempo_Casco_Urbano"))
            .Id_Entidad_Inicial_Atencion = isDBNullToNothing(fila("Id_Entidad_Inicial_Atencion"))
            .Id_Recibio_Ayuda_Entidad_Inicial = isDBNullToNothing(fila("Id_Recibio_Ayuda_Entidad_Inicial"))
            .Id_Como_Fue_Atencion = isDBNullToNothing(fila("Id_Como_Fue_Atencion"))
            .Id_Como_Brindar_Atencion = isDBNullToNothing(fila("Id_Como_Brindar_Atencion"))
            .Promedio_Ingresos_Mensuales = isDBNullToNothing(fila("Promedio_Ingresos_Mensuales"))
            .Fecha_Muerte = isDBNullToNothing(fila("Fecha_Muerte"))
            .Cuantos_Familiares_Desaparecidos = isDBNullToNothing(fila("Cuantos_Familiares_Desaparecidos"))
            .Id_Porque_No_Reporto = isDBNullToNothing(fila("Id_Porque_No_Reporto"))
            .Id_Despues_Hijos_617 = isDBNullToNothing(fila("Id_Despues_Hijos_617"))
            .Cuantos_Despues_Hijos = isDBNullToNothing(fila("Cuantos_Despues_Hijos"))
            .Cuantos_Despues_Hijos_Estudian = isDBNullToNothing(fila("Cuantos_Despues_Hijos_Estudian"))
            .Id_Tipo_Bien_Rural = isDBNullToNothing(fila("Id_Tipo_Bien_Rural"))
            .Id_Documento_Propiedad = isDBNullToNothing(fila("Id_Documento_Propiedad"))
            .Id_Destino_Tierra = isDBNullToNothing(fila("Id_Destino_Tierra"))
            .Id_Situacion_Actual_Tierras = isDBNullToNothing(fila("Id_Situacion_Actual_Tierras"))
            .Observaciones = isDBNullToNothing(fila("Observaciones"))
            .Id_Despues_Afiliado_Regimen_Subsidiado = isDBNullToNothing(fila("Id_Despues_Afiliado_Regimen_Subsidiado"))
            .Cuantos_Despues_Afiliado_Regimen_Subsidiado = isDBNullToNothing(fila("Cuantos_Despues_Afiliado_Regimen_Subsidiado"))
            .Id_Despues_Afiliado_Regimen_Contributivo = isDBNullToNothing(fila("Id_Despues_Afiliado_Regimen_Contributivo"))
            .Cuantos_Despues_Afiliado_Regimen_Contributivo = isDBNullToNothing(fila("Cuantos_Despues_Afiliado_Regimen_Contributivo"))
            .Id_Despues_Afiliado_Sisben = isDBNullToNothing(fila("Id_Despues_Afiliado_Sisben"))
            .Cuantos_Despues_Afiliado_Sisben = isDBNullToNothing(fila("Cuantos_Despues_Afiliado_Sisben"))
            .Id_ley_reparacion = isDBNullToNothing(fila("Id_ley_Reparacion"))
            .Id_Es_Del_Municipio = isDBNullToNothing(fila("Id_Es_Del_Municipio"))
            .Motivo_Desplazamiento = isDBNullToNothing(fila("Motivo_Desplazamiento"))
            .Fecha_Ingreso_Registro = isDBNullToNothing(fila("Fecha_Ingreso_Registro"))
            .Tipo_Declaracion = isDBNullToNothing(fila("Tipo_Declaracion"))
            .Horario = isDBNullToNothing(fila("Horario"))
            .Id_Tipo_Familia_desplazada = isDBNullToNothing(fila("Id_Tipo_Familia_desplazada"))
            .Id_Vulnerables_NoDesplazada = isDBNullToNothing(fila("Id_Vulnerables_NoDesplazada"))
            .Motivo_Remision = isDBNullToNothing(fila("Motivo_Remision"))
            .Id_Solicito_Ayuda = isDBNullToNothing(fila("Id_Solicito_Ayuda"))
            .Id_Concejo_Expulsor = isDBNullToNothing(fila("Id_Concejo_Expulsor"))
            .Id_Lugar_Fuente = isDBNullToNothing(fila("Id_Lugar_Fuente"))
            .Id_EnLinea = isDBNullToNothing(fila("Id_EnLinea"))
            .Id_Agua_Potable = isDBNullToNothing(fila("Id_Agua_Potable"))
            .Id_Tiene_Documento = isDBNullToNothing(fila("Id_Tiene_Documento"))
            .Id_Tipo_Familia_No_Desplazada = isDBNullToNothing(fila("Id_Tipo_Familia_No_Desplazada"))
            .Fecha_Radicacion = isDBNullToNothing(fila("Fecha_Radicacion"))
            .Numero_Declaracion = isDBNullToNothing(fila("Numero_Declaracion"))
            .Fecha_Creacion = isDBNullToNothing(fila("Fecha_Creacion"))
            .Id_Usuario_Creacion = isDBNullToNothing(fila("Id_Usuario_Creacion"))
            .Fecha_Modificacion = isDBNullToNothing(fila("Fecha_Modificacion"))
            .Id_Usuario_Modificacion = isDBNullToNothing(fila("Id_Usuario_Modificacion"))
            .Fecha_Cierre = isDBNullToNothing(fila("Fecha_Cierre"))
            .Cierre = isDBNullToNothing(fila("Cierre"))
            .Id_Familias_Accion = isDBNullToNothing(fila("Id_Familias_Accion"))
            .Municipio_Familias_Accion = isDBNullToNothing(fila("Municipio_Familias_Accion"))
            .Id_Red_Unidos = isDBNullToNothing(fila("Id_Red_Unidos"))
            .Municipio_Unidos = isDBNullToNothing(fila("Municipio_Unidos"))
            .Id_VBG_general = isDBNullToNothing(fila("Id_VBG_general"))
            .VBG_General_Agresor = isDBNullToNothing(fila("VBG_General_Agresor"))
            .Id_Ha_Muerto_Despues = isDBNullToNothing(fila("Id_Ha_Muerto_Despues"))
            .Id_Solicito_Atencion_Psicologica = isDBNullToNothing(fila("Id_Solicito_Atencion_Psicologica"))
            .Id_Afectado_Desplazamiento = isDBNullToNothing(fila("Id_Afectado_Desplazamiento"))
            .Id_Emociones = isDBNullToNothing(fila("Id_Emociones"))
            .Id_Tipo_Adiccion = isDBNullToNothing(fila("Id_Tipo_Adiccion"))
            .Id_Adiccion_Alcohol = isDBNullToNothing(fila("Id_Adiccion_Alcohol"))
            .Id_Adiccion_Droga = isDBNullToNothing(fila("Id_Adiccion_Droga"))
            .Id_Municipio_Faccion = isDBNullToNothing(fila("Id_Municipio_Faccion"))
        End With

        Return objDeclaracion

    End Function

    Public Shared Event LoadingDeclaracionList(ByVal LoadType As String)
    Public Shared Event LoadedDeclaracionList(ByVal target As List(Of DeclaracionBrl), ByVal LoadType As String)

    Public Shared Function CargarTodos() As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        RaiseEvent LoadingDeclaracionList("CargarTodos")
        dsDatos = DeclaracionDAL.CargarTodos()
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedDeclaracionList(lista, "CargarTodos")
        Return lista

    End Function

    Public Shared Function Cargarbusqueda(ByVal grupo As Integer, ByVal identificacion As String, ByVal nombre As String, ByVal regional As Integer, ByVal Fecha_Inicial_Radicacion As String, ByVal Fecha_Final_Radicacion As String, ByVal Fecha_Inicial_Entrega As String, ByVal Fecha_Final_Entrega As String, ByVal Fuente As Int32, ByVal fecha_inicial_Programacion As String, ByVal fecha_final_Programacion As String, ByVal horario As String, ByVal declarante As Int32, ByVal lugar As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        dsDatos = DeclaracionDAL.CargarporBusqueda(grupo, identificacion, nombre, regional, Fecha_Inicial_Radicacion, Fecha_Final_Radicacion, Fecha_Inicial_Entrega, Fecha_Final_Entrega, Fuente, fecha_inicial_Programacion, fecha_final_Programacion, horario, declarante, lugar)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarBusquedaDeclaraciones(ByVal Id_programa As Int32, ByVal grupo As Integer, ByVal identificacion As String, ByVal nombre As String, ByVal regional As Integer, ByVal Fecha_Inicial_Radicacion As String, ByVal Fecha_Final_Radicacion As String, ByVal Fecha_Inicial_Entrega As String, ByVal Fecha_Final_Entrega As String, ByVal Fuente As Int32, ByVal fecha_inicial_declaracion As String, ByVal fecha_final_Declaracion As String, ByVal horario As String, ByVal declarante As Int32, ByVal lugar As Int32, ByVal tiporeporte As String) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        dsDatos = DeclaracionDAL.CargarBusquedaDeclaraciones(Id_programa, grupo, identificacion, nombre, regional, Fecha_Inicial_Radicacion, Fecha_Final_Radicacion, Fecha_Inicial_Entrega, Fecha_Final_Entrega, Fuente, fecha_inicial_declaracion, fecha_final_Declaracion, horario, declarante, lugar, tiporeporte)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function

    Public Shared Function CargarbusquedaEstados(ByVal regional As Integer, ByVal declarante As Int32, ByVal Fecha_Inicial_Radicacion As String, ByVal Fecha_Final_Radicacion As String, ByVal fecha_inicial_declaracion As String, ByVal fecha_final_declaracion As String, ByVal Id_LugarEntrega As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        dsDatos = DeclaracionDAL.CargarporBusquedaEstados(regional, declarante, Fecha_Inicial_Radicacion, Fecha_Final_Radicacion, fecha_inicial_declaracion, fecha_final_declaracion, Id_LugarEntrega)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function

    Public Shared Function CargarbusquedaAsignacion(ByVal identificacion As String, ByVal nombre As String, ByVal regional As Integer, ByVal Fecha_Inicial_Programacion As String, ByVal Fecha_Final_Programacion As String, ByVal Fuente As Int32, ByVal horario As String, ByVal declarante As Int32, ByVal lugar As Int32, ByVal Id_programa As Int32, ByVal pendiente As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        dsDatos = DeclaracionDAL.CargarporBusquedaAsignacion(identificacion, nombre, regional, Fecha_Inicial_Programacion, Fecha_Final_Programacion, Fuente, horario, declarante, lugar, Id_programa, pendiente)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Event LoadingPorId(ByVal id As Int32)
    Public Shared Event LoadedPorId(ByVal target As DeclaracionBrl)

    Public Shared Function CargarPorID(ByVal ID As Int32) As DeclaracionBrl

        Dim dsDatos As System.Data.DataSet
        Dim objDeclaracion As DeclaracionBrl = Nothing
        dsDatos = DeclaracionDAL.CargarPorID(ID)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objDeclaracion = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))

        Return objDeclaracion

    End Function

    Public Shared Function CargarPorId_Aplico_Reparaciones(ByVal Id_Aplico_Reparaciones As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Aplico_Reparaciones")

        dsDatos = DeclaracionDAL.CargarPorId_Aplico_Reparaciones(Id_Aplico_Reparaciones)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Aplico_Reparaciones")

        Return lista

    End Function

    Public Shared Function CargarPorId_Condicion_Especial(ByVal Id_Condicion_Especial As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Condicion_Especial")

        dsDatos = DeclaracionDAL.CargarPorId_Condicion_Especial(Id_Condicion_Especial)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Condicion_Especial")

        Return lista

    End Function

    Public Shared Function CargarPorId_Enfermedad(ByVal Id_Enfermedad As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Enfermedad")

        dsDatos = DeclaracionDAL.CargarPorId_Enfermedad(Id_Enfermedad)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Enfermedad")

        Return lista

    End Function

    Public Shared Function CargarPorId_Entidad_Legal(ByVal Id_Entidad_Legal As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Entidad_Legal")

        dsDatos = DeclaracionDAL.CargarPorId_Entidad_Legal(Id_Entidad_Legal)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Entidad_Legal")

        Return lista

    End Function

    Public Shared Function CargarPorId_Esta_Trabajando(ByVal Id_Esta_Trabajando As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Esta_Trabajando")

        dsDatos = DeclaracionDAL.CargarPorId_Esta_Trabajando(Id_Esta_Trabajando)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Esta_Trabajando")

        Return lista

    End Function

    Public Shared Function CargarPorId_Estado_Aplicacion(ByVal Id_Estado_Aplicacion As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Estado_Aplicacion")

        dsDatos = DeclaracionDAL.CargarPorId_Estado_Aplicacion(Id_Estado_Aplicacion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Estado_Aplicacion")

        Return lista

    End Function

    Public Shared Function CargarPorId_Estatus_Aplicacion_Despues(ByVal Id_Estatus_Aplicacion_Despues As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Estatus_Aplicacion_Despues")

        dsDatos = DeclaracionDAL.CargarPorId_Estatus_Aplicacion_Despues(Id_Estatus_Aplicacion_Despues)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Estatus_Aplicacion_Despues")

        Return lista

    End Function

    Public Shared Function CargarPorId_Explicacion_Retorno(ByVal Id_Explicacion_Retorno As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Explicacion_Retorno")

        dsDatos = DeclaracionDAL.CargarPorId_Explicacion_Retorno(Id_Explicacion_Retorno)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Explicacion_Retorno")

        Return lista

    End Function

    Public Shared Function CargarPorId_Fuente(ByVal Id_Fuente As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Fuente")

        dsDatos = DeclaracionDAL.CargarPorId_Fuente(Id_Fuente)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Fuente")

        Return lista

    End Function

    Public Shared Function CargarPorId_Ha_Declarado_Antes(ByVal Id_Ha_Declarado_Antes As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Ha_Declarado_Antes")

        dsDatos = DeclaracionDAL.CargarPorId_Ha_Declarado_Antes(Id_Ha_Declarado_Antes)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Ha_Declarado_Antes")

        Return lista

    End Function

    Public Shared Function CargarPorId_Ha_Muerto_Alguien(ByVal Id_Ha_Muerto_Alguien As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Ha_Muerto_Alguien")

        dsDatos = DeclaracionDAL.CargarPorId_Ha_Muerto_Alguien(Id_Ha_Muerto_Alguien)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Ha_Muerto_Alguien")

        Return lista

    End Function

    Public Shared Function CargarPorId_Ha_Recibido_Ayuda(ByVal Id_Ha_Recibido_Ayuda As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Ha_Recibido_Ayuda")

        dsDatos = DeclaracionDAL.CargarPorId_Ha_Recibido_Ayuda(Id_Ha_Recibido_Ayuda)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Ha_Recibido_Ayuda")

        Return lista

    End Function

    Public Shared Function CargarPorId_Ha_Redibido_Ayuda_Despues(ByVal Id_Ha_Redibido_Ayuda_Despues As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Ha_Redibido_Ayuda_Despues")

        dsDatos = DeclaracionDAL.CargarPorId_Ha_Redibido_Ayuda_Despues(Id_Ha_Redibido_Ayuda_Despues)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Ha_Redibido_Ayuda_Despues")

        Return lista

    End Function

    Public Shared Function CargarPorId_Ha_Regresado(ByVal Id_Ha_Regresado As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Ha_Regresado")

        dsDatos = DeclaracionDAL.CargarPorId_Ha_Regresado(Id_Ha_Regresado)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Ha_Regresado")

        Return lista

    End Function

    Public Shared Function CargarPorId_Llegada_Golpes(ByVal Id_Llegada_Golpes As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Llegada_Golpes")

        dsDatos = DeclaracionDAL.CargarPorId_Llegada_Golpes(Id_Llegada_Golpes)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Llegada_Golpes")

        Return lista

    End Function

    Public Shared Function CargarPorId_Llegada_Golpes_Miembro(ByVal Id_Llegada_Golpes_Miembro As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Llegada_Golpes_Miembro")

        dsDatos = DeclaracionDAL.CargarPorId_Llegada_Golpes_Miembro(Id_Llegada_Golpes_Miembro)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Llegada_Golpes_Miembro")

        Return lista

    End Function

    Public Shared Function CargarPorId_Llegada_Golpes_Usted(ByVal Id_Llegada_Golpes_Usted As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Llegada_Golpes_Usted")

        dsDatos = DeclaracionDAL.CargarPorId_Llegada_Golpes_Usted(Id_Llegada_Golpes_Usted)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Llegada_Golpes_Usted")

        Return lista

    End Function

    Public Shared Function CargarPorId_Llegada_Insultos(ByVal Id_Llegada_Insultos As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Llegada_Insultos")

        dsDatos = DeclaracionDAL.CargarPorId_Llegada_Insultos(Id_Llegada_Insultos)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Llegada_Insultos")

        Return lista

    End Function

    Public Shared Function CargarPorId_Llegada_Insultos_Miembro(ByVal Id_Llegada_Insultos_Miembro As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Llegada_Insultos_Miembro")

        dsDatos = DeclaracionDAL.CargarPorId_Llegada_Insultos_Miembro(Id_Llegada_Insultos_Miembro)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Llegada_Insultos_Miembro")

        Return lista

    End Function

    Public Shared Function CargarPorId_Llegada_Insultos_Usted(ByVal Id_Llegada_Insultos_Usted As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Llegada_Insultos_Usted")

        dsDatos = DeclaracionDAL.CargarPorId_Llegada_Insultos_Usted(Id_Llegada_Insultos_Usted)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Llegada_Insultos_Usted")

        Return lista

    End Function

    Public Shared Function CargarPorId_Llegada_Sexual(ByVal Id_Llegada_Sexual As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Llegada_Sexual")

        dsDatos = DeclaracionDAL.CargarPorId_Llegada_Sexual(Id_Llegada_Sexual)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Llegada_Sexual")

        Return lista

    End Function

    Public Shared Function CargarPorId_Llegada_Sexual_Miembro(ByVal Id_Llegada_Sexual_Miembro As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Llegada_Sexual_Miembro")

        dsDatos = DeclaracionDAL.CargarPorId_Llegada_Sexual_Miembro(Id_Llegada_Sexual_Miembro)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Llegada_Sexual_Miembro")

        Return lista

    End Function

    Public Shared Function CargarPorId_Llegada_Sexual_Usted(ByVal Id_Llegada_Sexual_Usted As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Llegada_Sexual_Usted")

        dsDatos = DeclaracionDAL.CargarPorId_Llegada_Sexual_Usted(Id_Llegada_Sexual_Usted)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Llegada_Sexual_Usted")

        Return lista

    End Function

    Public Shared Function CargarPorId_Motivo_Muerte(ByVal Id_Motivo_Muerte As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Motivo_Muerte")

        dsDatos = DeclaracionDAL.CargarPorId_Motivo_Muerte(Id_Motivo_Muerte)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Motivo_Muerte")

        Return lista

    End Function

    Public Shared Function CargarPorId_Motivo_No_Aplico(ByVal Id_Motivo_No_Aplico As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Motivo_No_Aplico")

        dsDatos = DeclaracionDAL.CargarPorId_Motivo_No_Aplico(Id_Motivo_No_Aplico)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Motivo_No_Aplico")

        Return lista

    End Function

    Public Shared Function CargarPorId_Municipio_Expulsor(ByVal Id_Municipio_Expulsor As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Municipio_Expulsor")

        dsDatos = DeclaracionDAL.CargarPorId_Municipio_Expulsor(Id_Municipio_Expulsor)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Municipio_Expulsor")

        Return lista

    End Function

    Public Shared Function CargarPorId_Oido_Mesa_Desplazados(ByVal Id_Oido_Mesa_Desplazados As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Oido_Mesa_Desplazados")

        dsDatos = DeclaracionDAL.CargarPorId_Oido_Mesa_Desplazados(Id_Oido_Mesa_Desplazados)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Oido_Mesa_Desplazados")

        Return lista

    End Function

    Public Shared Function CargarPorId_Parentesco_Desaparecido(ByVal Id_Parentesco_Desaparecido As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Parentesco_Desaparecido")

        dsDatos = DeclaracionDAL.CargarPorId_Parentesco_Desaparecido(Id_Parentesco_Desaparecido)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Parentesco_Desaparecido")

        Return lista

    End Function

    Public Shared Function CargarPorId_Parentesco_Muerte(ByVal Id_Parentesco_Muerte As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Parentesco_Muerte")

        dsDatos = DeclaracionDAL.CargarPorId_Parentesco_Muerte(Id_Parentesco_Muerte)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Parentesco_Muerte")

        Return lista

    End Function

    Public Shared Function CargarPorId_Pertenece_Asociacion(ByVal Id_Pertenece_Asociacion As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Pertenece_Asociacion")

        dsDatos = DeclaracionDAL.CargarPorId_Pertenece_Asociacion(Id_Pertenece_Asociacion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Pertenece_Asociacion")

        Return lista

    End Function

    Public Shared Function CargarPorId_Razon_No_Aplico(ByVal Id_Razon_No_Aplico As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Razon_No_Aplico")

        dsDatos = DeclaracionDAL.CargarPorId_Razon_No_Aplico(Id_Razon_No_Aplico)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Razon_No_Aplico")

        Return lista

    End Function

    Public Shared Function CargarPorId_Reporto(ByVal Id_Reporto As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Reporto")

        dsDatos = DeclaracionDAL.CargarPorId_Reporto(Id_Reporto)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Reporto")

        Return lista

    End Function

    Public Shared Function CargarPorId_Retornaria(ByVal Id_Retornaria As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Retornaria")

        dsDatos = DeclaracionDAL.CargarPorId_Retornaria(Id_Retornaria)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Retornaria")

        Return lista

    End Function

    Public Shared Function CargarPorId_Tiene_Desaparecido(ByVal Id_Tiene_Desaparecido As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Tiene_Desaparecido")

        dsDatos = DeclaracionDAL.CargarPorId_Tiene_Desaparecido(Id_Tiene_Desaparecido)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Tiene_Desaparecido")

        Return lista

    End Function

    Public Shared Function CargarPorId_Velar_Enterrar(ByVal Id_Velar_Enterrar As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Velar_Enterrar")

        dsDatos = DeclaracionDAL.CargarPorId_Velar_Enterrar(Id_Velar_Enterrar)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Velar_Enterrar")

        Return lista

    End Function

    Public Shared Function CargarPorId_beneficiado_programas(ByVal Id_beneficiado_programas As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_beneficiado_programas")

        dsDatos = DeclaracionDAL.CargarPorId_beneficiado_programas(Id_beneficiado_programas)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_beneficiado_programas")

        Return lista

    End Function

    Public Shared Function CargarPorId_Grupo(ByVal Id_Grupo As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Grupo")

        dsDatos = DeclaracionDAL.CargarPorId_Grupo(Id_Grupo)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Grupo")

        Return lista

    End Function

    Public Shared Function CargarPorId_Regional(ByVal Id_Regional As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Regional")

        dsDatos = DeclaracionDAL.CargarPorId_Regional(Id_Regional)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Regional")

        Return lista

    End Function

    Public Shared Function CargarPorId_Atender(ByVal Id_Atender As Int32) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        RaiseEvent LoadingDeclaracionList("CargarPorId_Atender")
        dsDatos = DeclaracionDAL.CargarPorId_Atender(Id_Atender)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Atender")
        Return lista
    End Function

    Public Shared Function CargarPorId_Motivo_Noatender(ByVal Id_Motivo_Noatender As Int32) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        RaiseEvent LoadingDeclaracionList("CargarPorId_Motivo_Noatender")
        dsDatos = DeclaracionDAL.CargarPorId_Motivo_Noatender(Id_Motivo_Noatender)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Motivo_Noatender")
        Return lista
    End Function

    Public Shared Function CargarPorId_Como_Brindar_Atencion(ByVal Id_Como_Brindar_Atencion As Int32) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        RaiseEvent LoadingDeclaracionList("CargarPorId_Como_Brindar_Atencion")
        dsDatos = DeclaracionDAL.CargarPorId_Como_Brindar_Atencion(Id_Como_Brindar_Atencion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Como_Brindar_Atencion")
        Return lista
    End Function

    Public Shared Function CargarPorId_Como_Fue_Atencion(ByVal Id_Como_Fue_Atencion As Int32) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        RaiseEvent LoadingDeclaracionList("CargarPorId_Como_Fue_Atencion")
        dsDatos = DeclaracionDAL.CargarPorId_Como_Fue_Atencion(Id_Como_Fue_Atencion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Como_Fue_Atencion")
        Return lista
    End Function

    Public Shared Function CargarPorId_Cuantas_Habitaciones(ByVal Id_Cuantas_Habitaciones As Int32) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        RaiseEvent LoadingDeclaracionList("CargarPorId_Cuantas_Habitaciones")
        dsDatos = DeclaracionDAL.CargarPorId_Cuantas_Habitaciones(Id_Cuantas_Habitaciones)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Cuantas_Habitaciones")
        Return lista
    End Function

    Public Shared Function CargarPorId_Cuantas_Personas_Habitacion(ByVal Id_Cuantas_Personas_Habitacion As Int32) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        RaiseEvent LoadingDeclaracionList("CargarPorId_Cuantas_Personas_Habitacion")
        dsDatos = DeclaracionDAL.CargarPorId_Cuantas_Personas_Habitacion(Id_Cuantas_Personas_Habitacion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Cuantas_Personas_Habitacion")
        Return lista
    End Function

    Public Shared Function CargarPorId_Cuantas_Personas_Vivienda(ByVal Id_Cuantas_Personas_Vivienda As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Cuantas_Personas_Vivienda")

        dsDatos = DeclaracionDAL.CargarPorId_Cuantas_Personas_Vivienda(Id_Cuantas_Personas_Vivienda)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Cuantas_Personas_Vivienda")

        Return lista

    End Function

    Public Shared Function CargarPorId_Cuanto_Tiempo_Demoro(ByVal Id_Cuanto_Tiempo_Demoro As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Cuanto_Tiempo_Demoro")

        dsDatos = DeclaracionDAL.CargarPorId_Cuanto_Tiempo_Demoro(Id_Cuanto_Tiempo_Demoro)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Cuanto_Tiempo_Demoro")

        Return lista

    End Function

    Public Shared Function CargarPorId_Cuantos_Desplazamientos(ByVal Id_Cuantos_Desplazamientos As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Cuantos_Desplazamientos")

        dsDatos = DeclaracionDAL.CargarPorId_Cuantos_Desplazamientos(Id_Cuantos_Desplazamientos)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Cuantos_Desplazamientos")

        Return lista

    End Function

    Public Shared Function CargarPorId_Departamento_Expulsor(ByVal Id_Departamento_Expulsor As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Departamento_Expulsor")

        dsDatos = DeclaracionDAL.CargarPorId_Departamento_Expulsor(Id_Departamento_Expulsor)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Departamento_Expulsor")

        Return lista

    End Function

    Public Shared Function CargarPorId_Despues_Hijos_617(ByVal Id_Despues_Hijos_617 As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Despues_Hijos_617")

        dsDatos = DeclaracionDAL.CargarPorId_Despues_Hijos_617(Id_Despues_Hijos_617)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Despues_Hijos_617")

        Return lista

    End Function

    Public Shared Function CargarPorId_Entidad_Inicial_Atencion(ByVal Id_Entidad_Inicial_Atencion As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Entidad_Inicial_Atencion")

        dsDatos = DeclaracionDAL.CargarPorId_Entidad_Inicial_Atencion(Id_Entidad_Inicial_Atencion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Entidad_Inicial_Atencion")

        Return lista

    End Function

    Public Shared Function CargarPorId_Forma_Declaracion(ByVal Id_Forma_Declaracion As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Forma_Declaracion")

        dsDatos = DeclaracionDAL.CargarPorId_Forma_Declaracion(Id_Forma_Declaracion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Forma_Declaracion")

        Return lista

    End Function

    Public Shared Function CargarPorId_Materiales_Vivienda(ByVal Id_Materiales_Vivienda As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Materiales_Vivienda")

        dsDatos = DeclaracionDAL.CargarPorId_Materiales_Vivienda(Id_Materiales_Vivienda)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Materiales_Vivienda")

        Return lista

    End Function

    Public Shared Function CargarPorId_Motivo_Demora(ByVal Id_Motivo_Demora As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Motivo_Demora")

        dsDatos = DeclaracionDAL.CargarPorId_Motivo_Demora(Id_Motivo_Demora)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Motivo_Demora")

        Return lista

    End Function

    Public Shared Function CargarPorId_Motivo_Desplazamiento(ByVal Id_Motivo_Desplazamiento As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Motivo_Desplazamiento")

        dsDatos = DeclaracionDAL.CargarPorId_Motivo_Desplazamiento(Id_Motivo_Desplazamiento)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Motivo_Desplazamiento")

        Return lista

    End Function

    Public Shared Function CargarPorId_Motivo_NoDeclaro_Municipio(ByVal Id_Motivo_NoDeclaro_Municipio As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Motivo_NoDeclaro_Municipio")

        dsDatos = DeclaracionDAL.CargarPorId_Motivo_NoDeclaro_Municipio(Id_Motivo_NoDeclaro_Municipio)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Motivo_NoDeclaro_Municipio")

        Return lista

    End Function

    Public Shared Function CargarPorId_Porque_No_Reporto(ByVal Id_Porque_No_Reporto As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Porque_No_Reporto")

        dsDatos = DeclaracionDAL.CargarPorId_Porque_No_Reporto(Id_Porque_No_Reporto)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Porque_No_Reporto")

        Return lista

    End Function

    Public Shared Function CargarPorId_Recibio_Ayuda_Entidad_Inicial(ByVal Id_Recibio_Ayuda_Entidad_Inicial As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Recibio_Ayuda_Entidad_Inicial")

        dsDatos = DeclaracionDAL.CargarPorId_Recibio_Ayuda_Entidad_Inicial(Id_Recibio_Ayuda_Entidad_Inicial)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Recibio_Ayuda_Entidad_Inicial")

        Return lista

    End Function

    Public Shared Function CargarPorId_Tiempo_Casco_Urbano(ByVal Id_Tiempo_Casco_Urbano As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Tiempo_Casco_Urbano")

        dsDatos = DeclaracionDAL.CargarPorId_Tiempo_Casco_Urbano(Id_Tiempo_Casco_Urbano)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Tiempo_Casco_Urbano")

        Return lista

    End Function

    Public Shared Function CargarPorId_Tipo_Tenencia_Vivienda(ByVal Id_Tipo_Tenencia_Vivienda As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Tipo_Tenencia_Vivienda")

        dsDatos = DeclaracionDAL.CargarPorId_Tipo_Tenencia_Vivienda(Id_Tipo_Tenencia_Vivienda)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Tipo_Tenencia_Vivienda")

        Return lista

    End Function

    Public Shared Function CargarPorId_Vivio_Cabezera_Municipal(ByVal Id_Vivio_Cabezera_Municipal As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Vivio_Cabezera_Municipal")

        dsDatos = DeclaracionDAL.CargarPorId_Vivio_Cabezera_Municipal(Id_Vivio_Cabezera_Municipal)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Vivio_Cabezera_Municipal")

        Return lista

    End Function

    Public Shared Function CargarPorId_Despues_Afiliado_Regimen_Contributivo(ByVal Id_Despues_Afiliado_Regimen_Contributivo As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Despues_Afiliado_Regimen_Contributivo")

        dsDatos = DeclaracionDAL.CargarPorId_Despues_Afiliado_Regimen_Contributivo(Id_Despues_Afiliado_Regimen_Contributivo)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Despues_Afiliado_Regimen_Contributivo")

        Return lista

    End Function

    Public Shared Function CargarPorId_Despues_Afiliado_Regimen_Subsidiado(ByVal Id_Despues_Afiliado_Regimen_Subsidiado As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Despues_Afiliado_Regimen_Subsidiado")

        dsDatos = DeclaracionDAL.CargarPorId_Despues_Afiliado_Regimen_Subsidiado(Id_Despues_Afiliado_Regimen_Subsidiado)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Despues_Afiliado_Regimen_Subsidiado")

        Return lista

    End Function

    Public Shared Function CargarPorId_Despues_Afiliado_Sisben(ByVal Id_Despues_Afiliado_Sisben As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Despues_Afiliado_Sisben")

        dsDatos = DeclaracionDAL.CargarPorId_Despues_Afiliado_Sisben(Id_Despues_Afiliado_Sisben)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Despues_Afiliado_Sisben")

        Return lista

    End Function

    Public Shared Function CargarPorId_Destino_Tierra(ByVal Id_Destino_Tierra As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Destino_Tierra")

        dsDatos = DeclaracionDAL.CargarPorId_Destino_Tierra(Id_Destino_Tierra)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Destino_Tierra")

        Return lista

    End Function

    Public Shared Function CargarPorId_Documento_Propiedad(ByVal Id_Documento_Propiedad As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Documento_Propiedad")

        dsDatos = DeclaracionDAL.CargarPorId_Documento_Propiedad(Id_Documento_Propiedad)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Documento_Propiedad")

        Return lista

    End Function

    Public Shared Function CargarPorId_Situacion_Actual_Tierras(ByVal Id_Situacion_Actual_Tierras As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Situacion_Actual_Tierras")

        dsDatos = DeclaracionDAL.CargarPorId_Situacion_Actual_Tierras(Id_Situacion_Actual_Tierras)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Situacion_Actual_Tierras")

        Return lista

    End Function

    Public Shared Function CargarPorId_Tipo_Bien_Rural(ByVal Id_Tipo_Bien_Rural As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)

        RaiseEvent LoadingDeclaracionList("CargarPorId_Tipo_Bien_Rural")

        dsDatos = DeclaracionDAL.CargarPorId_Tipo_Bien_Rural(Id_Tipo_Bien_Rural)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Tipo_Bien_Rural")

        Return lista

    End Function

    Public Shared Function CargarPorId_Ley_Reparacion(ByVal Id_Ley_Reparacion As Int32) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        dsDatos = DeclaracionDAL.CargarPorid_ley_reparacion(Id_Ley_Reparacion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_Es_Del_Municipio(ByVal Id_Es_Del_Municipio As Int32) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        dsDatos = DeclaracionDAL.CargarPorId_Es_Del_Municipio(Id_Es_Del_Municipio)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_tipo_familia_Desplazada(ByVal Id_Tipo_Familia_Desplazada As Int32) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        dsDatos = DeclaracionDAL.CargarPorId_Tipo_Familia_desplazada(Id_Tipo_Familia_Desplazada)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_Vulnerables_NoDesplazada(ByVal Id_Vulnerables_NoDesplazada As Int32) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        dsDatos = DeclaracionDAL.CargarPorId_Vulnerables_NoDesplazada(Id_Vulnerables_NoDesplazada)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        dsDatos = DeclaracionDAL.CargarPorId_Usuario_Creacion(Id_Usuario_Creacion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function

    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As Int32) As List(Of DeclaracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        dsDatos = DeclaracionDAL.CargarPorId_Usuario_Modificacion(Id_Usuario_Modificacion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function

    Public Shared Function CargarPorId_Solicito_Ayuda(ByVal Id_Solicito_Ayuda As Int32) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        dsDatos = DeclaracionDAL.CargarPorId_Solicito_Ayuda(Id_Solicito_Ayuda)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_Concejo_Expulsor(ByVal Id_Concejo_Expulsor As Int32) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        dsDatos = DeclaracionDAL.CargarPorId_Concejo_Expulsor(Id_Concejo_Expulsor)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_Lugar_Fuente(ByVal Id_Lugar_Fuente As Int32) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        dsDatos = DeclaracionDAL.CargarPorId_Lugar_Fuente(Id_Lugar_Fuente)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_EnLinea(ByVal Id_EnLinea As Int32) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        dsDatos = DeclaracionDAL.CargarPorId_EnLinea(Id_EnLinea)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_Agua_Potable(ByVal Id_Agua_Potable As Int32) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        dsDatos = DeclaracionDAL.CargarPorId_Agua_Potable(Id_Agua_Potable)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_Tiene_Documento(ByVal Id_Tiene_documento As Int32) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        dsDatos = DeclaracionDAL.CargarPorId_Tiene_documento(Id_Tiene_documento)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_Afectado_Desplazamiento(ByVal Id_Afectado_Desplazamiento As Int32) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        RaiseEvent LoadingDeclaracionList("CargarPorId_Afectado_Desplazamiento")
        dsDatos = DeclaracionDAL.CargarPorId_Afectado_Desplazamiento(Id_Afectado_Desplazamiento)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Afectado_Desplazamiento")
        Return lista
    End Function

    Public Shared Function CargarPorId_Familias_Accion(ByVal Id_Familias_Accion As Int32) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        RaiseEvent LoadingDeclaracionList("CargarPorId_Familias_Accion")
        dsDatos = DeclaracionDAL.CargarPorId_Familias_Accion(Id_Familias_Accion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Familias_Accion")
        Return lista
    End Function

    Public Shared Function CargarPorId_Ha_Muerto_Despues(ByVal Id_Ha_Muerto_Despues As Int32) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        RaiseEvent LoadingDeclaracionList("CargarPorId_Ha_Muerto_Despues")
        dsDatos = DeclaracionDAL.CargarPorId_Ha_Muerto_Despues(Id_Ha_Muerto_Despues)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Ha_Muerto_Despues")
        Return lista
    End Function

    Public Shared Function CargarPorId_Red_Unidos(ByVal Id_Red_Unidos As Int32) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        RaiseEvent LoadingDeclaracionList("CargarPorId_Red_Unidos")
        dsDatos = DeclaracionDAL.CargarPorId_Red_Unidos(Id_Red_Unidos)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Red_Unidos")
        Return lista
    End Function

    Public Shared Function CargarPorId_Solicito_Atencion_Psicologica(ByVal Id_Solicito_Atencion_Psicologica As Int32) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        RaiseEvent LoadingDeclaracionList("CargarPorId_Solicito_Atencion_Psicologica")
        dsDatos = DeclaracionDAL.CargarPorId_Solicito_Atencion_Psicologica(Id_Solicito_Atencion_Psicologica)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Solicito_Atencion_Psicologica")
        Return lista
    End Function

    Public Shared Function CargarPorId_VBG_general(ByVal Id_VBG_general As Int32) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        RaiseEvent LoadingDeclaracionList("CargarPorId_VBG_general")
        dsDatos = DeclaracionDAL.CargarPorId_VBG_general(Id_VBG_general)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_VBG_general")
        Return lista
    End Function

    Public Shared Function CargarPorId_Emociones(ByVal Id_Emociones As Int32) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        RaiseEvent LoadingDeclaracionList("CargarPorId_Emociones")
        dsDatos = DeclaracionDAL.CargarPorId_Emociones(Id_Emociones)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedDeclaracionList(lista, "CargarPorId_Emociones")
        Return lista
    End Function

    Public Shared Function CargarPorIndicadores(ByVal id_Lugar_entrega As Int32, ByVal trimestrales As String, ByVal regionales As String, ByVal entregas As String, ByVal grupos As String, _
            ByVal fechadeclaracioninicial As String, ByVal fechadeclaracionfinal As String, ByVal fechadesplazamientoinicial As String, ByVal fechadesplazamientofinal As String, ByVal fechaatencioninicial As String, _
            ByVal fechaatencionfinal As String, ByVal accionsocial As Integer, ByVal atendido As Integer, ByVal motivonoatencion As Integer, ByVal departamento As Integer, ByVal municipio As Integer, ByVal concejo As Integer, _
            ByVal wfecha_radicacion_inicial As String, ByVal wfecha_radicacion_final As String) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        dsDatos = DeclaracionDAL.CargarporIndicadores(id_Lugar_entrega, trimestrales, regionales, entregas, grupos, fechadeclaracioninicial, fechadeclaracionfinal, fechadesplazamientoinicial, fechadesplazamientofinal, _
        fechaatencioninicial, fechaatencionfinal, accionsocial, atendido, motivonoatencion, departamento, municipio, concejo, wfecha_radicacion_inicial, wfecha_radicacion_final)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_Tipo_Familia_No_Desplazada(ByVal Id_Tipo_Familia_No_Desplazada As Int32) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        dsDatos = DeclaracionDAL.CargarPorId_Tipo_Familia_No_Desplazada(Id_Tipo_Familia_No_Desplazada)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorNumero_Declaracion(ByVal Numero_Declaracion As String) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        dsDatos = DeclaracionDAL.CargarPorNumero_Declaracion(Numero_Declaracion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_Tipo_Adiccion(ByVal Id_Tipo_Adiccion As Int32) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        dsDatos = DeclaracionDAL.CargarPorId_Tipo_Adiccion(Id_Tipo_Adiccion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_Adiccion_Alcohol(ByVal Id_Adiccion_Alcohol As Int32) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        dsDatos = DeclaracionDAL.CargarPorId_Adiccion_Alcohol(Id_Adiccion_Alcohol)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_Adiccion_Droga(ByVal Id_Adiccion_Droga As Int32) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        dsDatos = DeclaracionDAL.CargarPorId_Adiccion_Droga(Id_Adiccion_Droga)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorReprogramaciones(ByVal Id_Regional As Int32) As List(Of DeclaracionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DeclaracionBrl)
        dsDatos = DeclaracionDAL.CargarPorReprogramaciones(Id_Regional)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

End Class


