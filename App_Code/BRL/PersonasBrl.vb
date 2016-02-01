Imports ingNovar.Utilidades2
Imports System.Data
Imports System.Collections.Generic
Imports SeguridadUsuarios

Partial Public Class PersonasBrl

    Private _Id As Int32
    Private _Id_Declaracion As Int32
    Private _Tipo As String
    Private _Id_Tipo_Identificacion As Int32
    Private _Identificacion As String
    Private _Primer_Nombre As String
    Private _Segundo_Nombre As String
    Private _Primer_Apellido As String
    Private _Segundo_Apellido As String
    Private _Id_Genero As Int32
    Private _Fecha_Nacimiento As DateTime
    Private _Edad As Int32
    Private _Id_Parentesco As Int32
    Private _Id_Discapacitado As Int32
    Private _Id_Estudia_Antes As Int32
    Private _Id_Estudia_Actualmente As Int32
    Private _Id_Ultimo_Grado As Int32
    Private _Institucion_Estudia As String
    Private _Id_Motivo_NoEstudio As Int32
    Private _Id_Tipo_Discapacidad As Int32
    Private _Id_Grupo_Etnico As Int32
    Private _Id_Embarazada As Int32
    Private _Id_Lactando As Int32
    Private _Id_Solicito_Atencion_Psicologica As Int32
    Private _Id_Recibio_Atencion_Psicologica As Int32
    Private _Quien_Atencion_Psicologica As String
    Private _Id_Recibio_Tratamiento As Int32
    Private _Id_Causas_Discapacidad As Int32
    Private _Id_Sabe_Leer_Escribir As Int32
    Private _Institucion_Estudiaba As String
    Private _Id_Paga_Matricula As Int32
    Private _Id_Tipo_Apoyo_Educativo As Int32
    Private _Id_Problemas_Establecimiento As Int32
    Private _Fecha_Creacion As DateTime
    Private _Id_Usuario_Creacion As Int32
    Private _Fecha_Modificacion As DateTime
    Private _Id_Usuario_Modificacion As Int32
    Private _Edad_semanas As Int32
    Private _Fecha_Cierre As DateTime
    Private _Cierre As Boolean
    Private _Id_Tipo_Miembro As Int32
    Private _Id_Afectado_Desplazamiento As Int32
    Private _Id_Certificado As Int32
    Private _Id_Municipio_Instituto_Antes As Int32
    Private _Id_Municipio_Instituto_Actual As Int32

    Private objListPersonas_Contactos As List(Of Personas_ContactosBrl)
    Private objListGestantes As List(Of GestantesBrl)
    Private objListSalud As List(Of SaludBrl)
    Private objListPersonas_Educacion As List(Of Personas_EducacionBrl)
    Private objListPersonas_Regimen_Salud As List(Of Personas_Regimen_SaludBrl)
    Private objListPersonas_Afectado As List(Of Personas_AfectadoBrl)
    Private objListPersonas_Entregas As List(Of Personas_EntregasBrl)

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

    Public Event Id_DeclaracionChanging(ByVal Value As Int32)
    Public Event Id_DeclaracionChanged()
	
    Public Property Id_Declaracion() As Int32
        Get
            Return Me._Id_Declaracion
        End Get
        Set(ByVal Value As Int32)
            If _Id_Declaracion <> Value Then
                RaiseEvent Id_DeclaracionChanging(Value)
				Me._Id_Declaracion = Value
                RaiseEvent Id_DeclaracionChanged()
            End If
        End Set
    End Property

    Public Event TipoChanging(ByVal Value As String)
    Public Event TipoChanged()
	
    Public Property Tipo() As String
        Get
            Return Me._Tipo
        End Get
        Set(ByVal Value As String)
            If _Tipo <> Value Then
                RaiseEvent TipoChanging(Value)
				Me._Tipo = Value
                RaiseEvent TipoChanged()
            End If
        End Set
    End Property

    Public Event Id_Tipo_IdentificacionChanging(ByVal Value As Int32)
    Public Event Id_Tipo_IdentificacionChanged()
	
    Public Property Id_Tipo_Identificacion() As Int32
        Get
            Return Me._Id_Tipo_Identificacion
        End Get
        Set(ByVal Value As Int32)
            If _Id_Tipo_Identificacion <> Value Then
                RaiseEvent Id_Tipo_IdentificacionChanging(Value)
				Me._Id_Tipo_Identificacion = Value
                RaiseEvent Id_Tipo_IdentificacionChanged()
            End If
        End Set
    End Property

    Public Event IdentificacionChanging(ByVal Value As String)
    Public Event IdentificacionChanged()
	
    Public Property Identificacion() As String
        Get
            Return Me._Identificacion
        End Get
        Set(ByVal Value As String)
            If _Identificacion <> Value Then
                RaiseEvent IdentificacionChanging(Value)
				Me._Identificacion = Value
                RaiseEvent IdentificacionChanged()
            End If
        End Set
    End Property

    Public Event Primer_NombreChanging(ByVal Value As String)
    Public Event Primer_NombreChanged()
	
    Public Property Primer_Nombre() As String
        Get
            Return Me._Primer_Nombre
        End Get
        Set(ByVal Value As String)
            If _Primer_Nombre <> Value Then
                RaiseEvent Primer_NombreChanging(Value)
				Me._Primer_Nombre = Value
                RaiseEvent Primer_NombreChanged()
            End If
        End Set
    End Property

    Public Event Segundo_NombreChanging(ByVal Value As String)
    Public Event Segundo_NombreChanged()
	
    Public Property Segundo_Nombre() As String
        Get
            Return Me._Segundo_Nombre
        End Get
        Set(ByVal Value As String)
            If _Segundo_Nombre <> Value Then
                RaiseEvent Segundo_NombreChanging(Value)
				Me._Segundo_Nombre = Value
                RaiseEvent Segundo_NombreChanged()
            End If
        End Set
    End Property

    Public Event Primer_ApellidoChanging(ByVal Value As String)
    Public Event Primer_ApellidoChanged()
	
    Public Property Primer_Apellido() As String
        Get
            Return Me._Primer_Apellido
        End Get
        Set(ByVal Value As String)
            If _Primer_Apellido <> Value Then
                RaiseEvent Primer_ApellidoChanging(Value)
				Me._Primer_Apellido = Value
                RaiseEvent Primer_ApellidoChanged()
            End If
        End Set
    End Property

    Public Event Segundo_ApellidoChanging(ByVal Value As String)
    Public Event Segundo_ApellidoChanged()
	
    Public Property Segundo_Apellido() As String
        Get
            Return Me._Segundo_Apellido
        End Get
        Set(ByVal Value As String)
            If _Segundo_Apellido <> Value Then
                RaiseEvent Segundo_ApellidoChanging(Value)
				Me._Segundo_Apellido = Value
                RaiseEvent Segundo_ApellidoChanged()
            End If
        End Set
    End Property

    Public Event Id_GeneroChanging(ByVal Value As Int32)
    Public Event Id_GeneroChanged()
	
    Public Property Id_Genero() As Int32
        Get
            Return Me._Id_Genero
        End Get
        Set(ByVal Value As Int32)
            If _Id_Genero <> Value Then
                RaiseEvent Id_GeneroChanging(Value)
				Me._Id_Genero = Value
                RaiseEvent Id_GeneroChanged()
            End If
        End Set
    End Property

    Public Event Fecha_NacimientoChanging(ByVal Value As DateTime)
    Public Event Fecha_NacimientoChanged()
	
    Public Property Fecha_Nacimiento() As DateTime
        Get
            Return Me._Fecha_Nacimiento
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_Nacimiento <> Value Then
                RaiseEvent Fecha_NacimientoChanging(Value)
				Me._Fecha_Nacimiento = Value
                RaiseEvent Fecha_NacimientoChanged()
            End If
        End Set
    End Property

    Public Event EdadChanging(ByVal Value As Int32)
    Public Event EdadChanged()
	
    Public Property Edad() As Int32
        Get
            Return Me._Edad
        End Get
        Set(ByVal Value As Int32)
            If _Edad <> Value Then
                RaiseEvent EdadChanging(Value)
				Me._Edad = Value
                RaiseEvent EdadChanged()
            End If
        End Set
    End Property

    Public Event Id_ParentescoChanging(ByVal Value As Int32)
    Public Event Id_ParentescoChanged()
	
    Public Property Id_Parentesco() As Int32
        Get
            Return Me._Id_Parentesco
        End Get
        Set(ByVal Value As Int32)
            If _Id_Parentesco <> Value Then
                RaiseEvent Id_ParentescoChanging(Value)
				Me._Id_Parentesco = Value
                RaiseEvent Id_ParentescoChanged()
            End If
        End Set
    End Property

    Public Event Id_DiscapacitadoChanging(ByVal Value As Int32)
    Public Event Id_DiscapacitadoChanged()
	
    Public Property Id_Discapacitado() As Int32
        Get
            Return Me._Id_Discapacitado
        End Get
        Set(ByVal Value As Int32)
            If _Id_Discapacitado <> Value Then
                RaiseEvent Id_DiscapacitadoChanging(Value)
				Me._Id_Discapacitado = Value
                RaiseEvent Id_DiscapacitadoChanged()
            End If
        End Set
    End Property

    Public Event Id_Estudia_AntesChanging(ByVal Value As Int32)
    Public Event Id_Estudia_AntesChanged()
	
    Public Property Id_Estudia_Antes() As Int32
        Get
            Return Me._Id_Estudia_Antes
        End Get
        Set(ByVal Value As Int32)
            If _Id_Estudia_Antes <> Value Then
                RaiseEvent Id_Estudia_AntesChanging(Value)
				Me._Id_Estudia_Antes = Value
                RaiseEvent Id_Estudia_AntesChanged()
            End If
        End Set
    End Property

    Public Event Id_Estudia_ActualmenteChanging(ByVal Value As Int32)
    Public Event Id_Estudia_ActualmenteChanged()
	
    Public Property Id_Estudia_Actualmente() As Int32
        Get
            Return Me._Id_Estudia_Actualmente
        End Get
        Set(ByVal Value As Int32)
            If _Id_Estudia_Actualmente <> Value Then
                RaiseEvent Id_Estudia_ActualmenteChanging(Value)
				Me._Id_Estudia_Actualmente = Value
                RaiseEvent Id_Estudia_ActualmenteChanged()
            End If
        End Set
    End Property

    Public Event Id_Ultimo_GradoChanging(ByVal Value As Int32)
    Public Event Id_Ultimo_GradoChanged()
	
    Public Property Id_Ultimo_Grado() As Int32
        Get
            Return Me._Id_Ultimo_Grado
        End Get
        Set(ByVal Value As Int32)
            If _Id_Ultimo_Grado <> Value Then
                RaiseEvent Id_Ultimo_GradoChanging(Value)
				Me._Id_Ultimo_Grado = Value
                RaiseEvent Id_Ultimo_GradoChanged()
            End If
        End Set
    End Property

    Public Event Institucion_EstudiaChanging(ByVal Value As String)
    Public Event Institucion_EstudiaChanged()
	
    Public Property Institucion_Estudia() As String
        Get
            Return Me._Institucion_Estudia
        End Get
        Set(ByVal Value As String)
            If _Institucion_Estudia <> Value Then
                RaiseEvent Institucion_EstudiaChanging(Value)
				Me._Institucion_Estudia = Value
                RaiseEvent Institucion_EstudiaChanged()
            End If
        End Set
    End Property

    Public Event Id_Motivo_NoEstudioChanging(ByVal Value As Int32)
    Public Event Id_Motivo_NoEstudioChanged()
	
    Public Property Id_Motivo_NoEstudio() As Int32
        Get
            Return Me._Id_Motivo_NoEstudio
        End Get
        Set(ByVal Value As Int32)
            If _Id_Motivo_NoEstudio <> Value Then
                RaiseEvent Id_Motivo_NoEstudioChanging(Value)
				Me._Id_Motivo_NoEstudio = Value
                RaiseEvent Id_Motivo_NoEstudioChanged()
            End If
        End Set
    End Property

    Public Event Id_Tipo_DiscapacidadChanging(ByVal Value As Int32)
    Public Event Id_Tipo_DiscapacidadChanged()

    Public Property Id_Tipo_Discapacidad() As Int32
        Get
            Return Me._Id_Tipo_Discapacidad
        End Get
        Set(ByVal Value As Int32)
            If _Id_Tipo_Discapacidad <> Value Then
                RaiseEvent Id_Tipo_DiscapacidadChanging(Value)
                Me._Id_Tipo_Discapacidad = Value
                RaiseEvent Id_Tipo_DiscapacidadChanged()
            End If
        End Set
    End Property

    Public Event Id_Grupo_EtnicoChanging(ByVal Value As Int32)
    Public Event Id_Grupo_EtnicoChanged()

    Public Property Id_Grupo_Etnico() As Int32
        Get
            Return Me._Id_Grupo_Etnico
        End Get
        Set(ByVal Value As Int32)
            If _Id_Grupo_Etnico <> Value Then
                RaiseEvent Id_Grupo_EtnicoChanging(Value)
                Me._Id_Grupo_Etnico = Value
                RaiseEvent Id_Grupo_EtnicoChanged()
            End If
        End Set
    End Property

    Public Event Id_EmbarazadaChanging(ByVal Value As Int32)
    Public Event Id_EmbarazadaChanged()

    Public Property Id_Embarazada() As Int32
        Get
            Return Me._Id_Embarazada
        End Get
        Set(ByVal Value As Int32)
            If _Id_Embarazada <> Value Then
                RaiseEvent Id_EmbarazadaChanging(Value)
                Me._Id_Embarazada = Value
                RaiseEvent Id_EmbarazadaChanged()
            End If
        End Set
    End Property

    Public Event Id_LactandoChanging(ByVal Value As Int32)
    Public Event Id_LactandoChanged()

    Public Property Id_Lactando() As Int32
        Get
            Return Me._Id_Lactando
        End Get
        Set(ByVal Value As Int32)
            If _Id_Lactando <> Value Then
                RaiseEvent Id_LactandoChanging(Value)
                Me._Id_Lactando = Value
                RaiseEvent Id_LactandoChanged()
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

    Public Event Id_Recibio_Atencion_PsicologicaChanging(ByVal Value As Int32)
    Public Event Id_Recibio_Atencion_PsicologicaChanged()

    Public Property Id_Recibio_Atencion_Psicologica() As Int32
        Get
            Return Me._Id_Recibio_Atencion_Psicologica
        End Get
        Set(ByVal Value As Int32)
            If _Id_Recibio_Atencion_Psicologica <> Value Then
                RaiseEvent Id_Recibio_Atencion_PsicologicaChanging(Value)
                Me._Id_Recibio_Atencion_Psicologica = Value
                RaiseEvent Id_Recibio_Atencion_PsicologicaChanged()
            End If
        End Set
    End Property

    Public Event Quien_Atencion_PsicologicaChanging(ByVal Value As String)
    Public Event Quien_Atencion_PsicologicaChanged()

    Public Property Quien_Atencion_Psicologica() As String
        Get
            Return Me._Quien_Atencion_Psicologica
        End Get
        Set(ByVal Value As String)
            If _Quien_Atencion_Psicologica <> Value Then
                RaiseEvent Quien_Atencion_PsicologicaChanging(Value)
                Me._Quien_Atencion_Psicologica = Value
                RaiseEvent Quien_Atencion_PsicologicaChanged()
            End If
        End Set
    End Property

    Public Event Id_Recibio_TratamientoChanging(ByVal Value As Int32)
    Public Event Id_Recibio_TratamientoChanged()

    Public Property Id_Recibio_Tratamiento() As Int32
        Get
            Return Me._Id_Recibio_Tratamiento
        End Get
        Set(ByVal Value As Int32)
            If _Id_Recibio_Tratamiento <> Value Then
                RaiseEvent Id_Recibio_TratamientoChanging(Value)
                Me._Id_Recibio_Tratamiento = Value
                RaiseEvent Id_Recibio_TratamientoChanged()
            End If
        End Set
    End Property

    Public Event Id_Causas_DiscapacidadChanging(ByVal Value As Int32)
    Public Event Id_Causas_DiscapacidadChanged()

    Public Property Id_Causas_Discapacidad() As Int32
        Get
            Return Me._Id_Causas_Discapacidad
        End Get
        Set(ByVal Value As Int32)
            If _Id_Causas_Discapacidad <> Value Then
                RaiseEvent Id_Causas_DiscapacidadChanging(Value)
                Me._Id_Causas_Discapacidad = Value
                RaiseEvent Id_Causas_DiscapacidadChanged()
            End If
        End Set
    End Property

    Public Event Id_Sabe_Leer_EscribirChanging(ByVal Value As Int32)
    Public Event Id_Sabe_Leer_EscribirChanged()

    Public Property Id_Sabe_Leer_Escribir() As Int32
        Get
            Return Me._Id_Sabe_Leer_Escribir
        End Get
        Set(ByVal Value As Int32)
            If _Id_Sabe_Leer_Escribir <> Value Then
                RaiseEvent Id_Sabe_Leer_EscribirChanging(Value)
                Me._Id_Sabe_Leer_Escribir = Value
                RaiseEvent Id_Sabe_Leer_EscribirChanged()
            End If
        End Set
    End Property

    Public Event Institucion_EstudiabaChanging(ByVal Value As String)
    Public Event Institucion_EstudiabaChanged()

    Public Property Institucion_Estudiaba() As String
        Get
            Return Me._Institucion_Estudiaba
        End Get
        Set(ByVal Value As String)
            If _Institucion_Estudiaba <> Value Then
                RaiseEvent Institucion_EstudiabaChanging(Value)
                Me._Institucion_Estudiaba = Value
                RaiseEvent Institucion_EstudiabaChanged()
            End If
        End Set
    End Property

    Public Event Id_Paga_MatriculaChanging(ByVal Value As Int32)
    Public Event Id_Paga_MatriculaChanged()

    Public Property Id_Paga_Matricula() As Int32
        Get
            Return Me._Id_Paga_Matricula
        End Get
        Set(ByVal Value As Int32)
            If _Id_Paga_Matricula <> Value Then
                RaiseEvent Id_Paga_MatriculaChanging(Value)
                Me._Id_Paga_Matricula = Value
                RaiseEvent Id_Paga_MatriculaChanged()
            End If
        End Set
    End Property

    Public Event Id_Tipo_Apoyo_EducativoChanging(ByVal Value As Int32)
    Public Event Id_Tipo_Apoyo_EducativoChanged()

    Public Property Id_Tipo_Apoyo_Educativo() As Int32
        Get
            Return Me._Id_Tipo_Apoyo_Educativo
        End Get
        Set(ByVal Value As Int32)
            If _Id_Tipo_Apoyo_Educativo <> Value Then
                RaiseEvent Id_Tipo_Apoyo_EducativoChanging(Value)
                Me._Id_Tipo_Apoyo_Educativo = Value
                RaiseEvent Id_Tipo_Apoyo_EducativoChanged()
            End If
        End Set
    End Property

    Public Event Id_Problemas_EstablecimientoChanging(ByVal Value As Int32)
    Public Event Id_Problemas_EstablecimientoChanged()

    Public Property Id_Problemas_Establecimiento() As Int32
        Get
            Return Me._Id_Problemas_Establecimiento
        End Get
        Set(ByVal Value As Int32)
            If _Id_Problemas_Establecimiento <> Value Then
                RaiseEvent Id_Problemas_EstablecimientoChanging(Value)
                Me._Id_Problemas_Establecimiento = Value
                RaiseEvent Id_Problemas_EstablecimientoChanged()
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

    Public Event Edad_SemanasChanging(ByVal Value As Int32)
    Public Event Edad_SemanasChanged()

    Public Property Edad_Semanas() As Int32
        Get
            Return Me._Edad_semanas
        End Get
        Set(ByVal Value As Int32)
            If _Edad_semanas <> Value Then
                RaiseEvent Edad_SemanasChanging(Value)
                Me._Edad_semanas = Value
                RaiseEvent Edad_SemanasChanged()
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

    Public Event Id_Tipo_MiembroChanging(ByVal Value As Int32)
    Public Event Id_Tipo_MiembroChanged()

    Public Property Id_Tipo_Miembro() As Int32
        Get
            Return Me._Id_Tipo_Miembro
        End Get
        Set(ByVal Value As Int32)
            If _Id_Tipo_Miembro <> Value Then
                RaiseEvent Id_Tipo_MiembroChanging(Value)
                Me._Id_Tipo_Miembro = Value
                RaiseEvent Id_Tipo_MiembroChanged()
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

    Public Event Id_CertificadoChanging(ByVal Value As Int32)
    Public Event Id_CertificadoChanged()

    Public Property Id_Certificado() As Int32
        Get
            Return Me._Id_Certificado
        End Get
        Set(ByVal Value As Int32)
            If _Id_Certificado <> Value Then
                RaiseEvent Id_CertificadoChanging(Value)
                Me._Id_Certificado = Value
                RaiseEvent Id_CertificadoChanged()
            End If
        End Set
    End Property

    Public Event Id_Municipio_AntesChanging(ByVal Value As Int32)
    Public Event Id_Municipio_AntesChanged()

    Public Property Id_Municipio_Instituto_Antes() As Int32
        Get
            Return Me._Id_Municipio_Instituto_Antes
        End Get
        Set(ByVal Value As Int32)
            If _Id_Municipio_Instituto_Antes <> Value Then
                RaiseEvent Id_Municipio_AntesChanging(Value)
                Me._Id_Municipio_Instituto_Antes = Value
                RaiseEvent Id_Municipio_AntesChanged()
            End If
        End Set
    End Property

    Public Event Id_Municipio_ActualChanging(ByVal Value As Int32)
    Public Event Id_Municipio_ActualChanged()

    Public Property Id_Municipio_Instituto_Actual() As Int32
        Get
            Return Me._Id_Municipio_Instituto_Actual
        End Get
        Set(ByVal Value As Int32)
            If _Id_Municipio_Instituto_Actual <> Value Then
                RaiseEvent Id_Municipio_ActualChanging(Value)
                Me._Id_Municipio_Instituto_Actual = Value
                RaiseEvent Id_Municipio_ActualChanged()
            End If
        End Set
    End Property

    '
    '
    '

    Public Property Personas_Regimen_Salud() As List(Of Personas_Regimen_SaludBrl)
        Get
            If (Me.objListPersonas_Regimen_Salud Is Nothing) Then
                objListPersonas_Regimen_Salud = Personas_Regimen_SaludBrl.CargarPorId_Persona(Me.ID)
            End If
            Return Me.objListPersonas_Regimen_Salud
        End Get
        Set(ByVal Value As List(Of Personas_Regimen_SaludBrl))
            Me.objListPersonas_Regimen_Salud = Value
        End Set
    End Property

    Public Property Personas_Afectado() As List(Of Personas_AfectadoBrl)
        Get
            If (Me.objListPersonas_Afectado Is Nothing) Then
                objListPersonas_Afectado = Personas_AfectadoBrl.CargarPorId_Persona(Me.ID)
            End If
            Return Me.objListPersonas_Afectado
        End Get
        Set(ByVal Value As List(Of Personas_AfectadoBrl))
            Me.objListPersonas_Afectado = Value
        End Set
    End Property

    Public Property Personas_Contactos() As List(Of Personas_ContactosBrl)
        Get
            If (Me.objListPersonas_Contactos Is Nothing) Then
                objListPersonas_Contactos = Personas_ContactosBrl.CargarPorId_Persona(Me.ID)
            End If
            Return Me.objListPersonas_Contactos
        End Get
        Set(ByVal Value As List(Of Personas_ContactosBrl))
            Me.objListPersonas_Contactos = Value
        End Set
    End Property

    Public Property Personas_Entregas() As List(Of Personas_EntregasBrl)
        Get
            If (Me.objListPersonas_Entregas Is Nothing) Then
                objListPersonas_Entregas = Personas_EntregasBrl.CargarPorId_Persona(Me.ID)
            End If
            Return Me.objListPersonas_Entregas
        End Get
        Set(ByVal Value As List(Of Personas_EntregasBrl))
            Me.objListPersonas_Entregas = Value
        End Set
    End Property

    Public ReadOnly Property Declaracion() As DeclaracionBrl
        Get
            Return DeclaracionBrl.CargarPorID(Id_Declaracion)
        End Get
    End Property

    Public ReadOnly Property Discapacitado() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Discapacitado)
        End Get
    End Property

    Public ReadOnly Property Estudia_Antes() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Estudia_Antes)
        End Get
    End Property

    Public ReadOnly Property Genero() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Genero)
        End Get
    End Property

    Public ReadOnly Property Motivo_NoEstudio() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Motivo_NoEstudio)
        End Get
    End Property

    Public ReadOnly Property Parentesco() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Parentesco)
        End Get
    End Property

    Public ReadOnly Property Tipo_Identificacion() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Tipo_Identificacion)
        End Get
    End Property

    Public ReadOnly Property Ultimo_Grado() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Ultimo_Grado)
        End Get
    End Property

    Public ReadOnly Property Estudia_Actualmente() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Estudia_Actualmente)
        End Get
    End Property

    Public ReadOnly Property CertificadoPrimera_Entrega() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Certificado)
        End Get
    End Property

    Public Property Gestantes() As List(Of GestantesBrl)
        Get
            If (Me.objListGestantes Is Nothing) Then
                objListGestantes = GestantesBrl.CargarPorId_Persona(Me.ID)
            End If
            Return Me.objListGestantes
        End Get
        Set(ByVal Value As List(Of GestantesBrl))
            Me.objListGestantes = Value
        End Set
    End Property

    Public Property Salud() As List(Of SaludBrl)
        Get
            If (Me.objListSalud Is Nothing) Then
                objListSalud = SaludBrl.CargarPorId_Persona(Me.ID)
            End If
            Return Me.objListSalud
        End Get
        Set(ByVal Value As List(Of SaludBrl))
            Me.objListSalud = Value
        End Set
    End Property

    Public ReadOnly Property Causas_Discapacidad() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Causas_Discapacidad)
        End Get
    End Property

    Public ReadOnly Property Embarazada() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Embarazada)
        End Get
    End Property

    Public ReadOnly Property Grupo_Etnico() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Grupo_Etnico)
        End Get
    End Property

    Public ReadOnly Property Lactando() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Lactando)
        End Get
    End Property

    Public ReadOnly Property Paga_Matricula() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Paga_Matricula)
        End Get
    End Property

    Public ReadOnly Property Problemas_Establecimiento() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Problemas_Establecimiento)
        End Get
    End Property

    Public ReadOnly Property Recibio_Atencion_Psicologica() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Recibio_Atencion_Psicologica)
        End Get
    End Property

    Public ReadOnly Property Recibio_Tratamiento() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Recibio_Tratamiento)
        End Get
    End Property

    Public ReadOnly Property Sabe_Leer_Escribir() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Sabe_Leer_Escribir)
        End Get
    End Property

    Public ReadOnly Property Solicito_Atencion_Psicologica() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Solicito_Atencion_Psicologica)
        End Get
    End Property

    Public ReadOnly Property Tipo_Apoyo_Educativo() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Tipo_Apoyo_Educativo)
        End Get
    End Property

    Public ReadOnly Property Tipo_Discapacidad() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Tipo_Discapacidad)
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

    Public ReadOnly Property Tipo_Miembro() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Tipo_Miembro)
        End Get
    End Property

    Public ReadOnly Property Afectado_Desplazamiento() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Afectado_Desplazamiento)
        End Get
    End Property

    Public ReadOnly Property Municipio_Antes() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Municipio_Instituto_Antes)
        End Get
    End Property

    Public ReadOnly Property Municipio_Actual() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Municipio_Instituto_Actual)
        End Get
    End Property

    Public ReadOnly Property DatosDeclaracion() As String
        Get
            Return Declaracion.Declarante & " - Grupo: " & Declaracion.DescripcionGrupo & "-" & NombreCompleto _
              & "-Ide:" & Identificacion & "-Fecha: " & FechaUtil.toStringDDMMYYY(Declaracion.Fecha_Valoracion)
        End Get
    End Property

    ''
    ''  Procedimientos Especiales
    ''

    '' Para sacar la direccion de la persona 
    Public ReadOnly Property Direccion() As Personas_ContactosBrl
        Get
            For Each fila As Personas_ContactosBrl In Personas_ContactosBrl.CargarPorId_Persona(Me.ID)
                If fila.Id_Tipo_Contacto = 74 Then
                    If fila.Activo = True Then
                        Return fila
                    End If
                End If
            Next
            Return New Personas_ContactosBrl
        End Get
    End Property

    '' Para sacar el celular de la persona 
    Public ReadOnly Property Celular() As Personas_ContactosBrl
        Get
            For Each fila As Personas_ContactosBrl In Personas_ContactosBrl.CargarPorId_Persona(Me.ID)
                If fila.Id_Tipo_Contacto = 76 Then
                    If fila.Activo = True Then
                        Return fila
                    End If
                End If
            Next
            Return New Personas_ContactosBrl
        End Get
    End Property

    '' Para sacar el barrio de la persona 
    Public ReadOnly Property Barrio() As Personas_ContactosBrl
        Get
            For Each fila As Personas_ContactosBrl In Personas_ContactosBrl.CargarPorId_Persona(Me.ID)
                If fila.Id_Tipo_Contacto = 79 Then
                    If fila.Activo = True Then
                        Return fila
                    End If
                End If
            Next
            Return New Personas_ContactosBrl
        End Get
    End Property

    '' Para sacar el telefono de la persona 
    Public ReadOnly Property Telefono() As Personas_ContactosBrl
        Get
            For Each fila As Personas_ContactosBrl In Personas_ContactosBrl.CargarPorId_Persona(Me.ID)
                If fila.Id_Tipo_Contacto = 75 Then
                    If fila.Activo = True Then
                        Return fila
                    End If
                End If
            Next
            Return New Personas_ContactosBrl
        End Get
    End Property

    ' Para sacar parentesco cuando este ne null

    Public ReadOnly Property EstadoEmbarazada() As String
        Get
            If Embarazada Is Nothing Then
                Return ""
            Else
                Return Embarazada.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property EstadoLactando() As String
        Get
            If Lactando Is Nothing Then
                Return ""
            Else
                Return Lactando.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property ParentescoPersona() As String
        Get
            If Parentesco Is Nothing Then
                Return ""
            Else
                Return Parentesco.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property TipoMiembro() As String
        Get
            If Tipo_Miembro Is Nothing Then
                Return ""
            Else
                Return Tipo_Miembro.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property NombreCompleto() As String
        Get
            Dim wnombre As String = ""
            If Primer_Nombre IsNot Nothing Then
                wnombre = wnombre + Primer_Nombre.Trim
            End If
            If Segundo_Nombre IsNot Nothing Then
                wnombre = wnombre + " " + Segundo_Nombre.Trim
            End If
            If Primer_Apellido IsNot Nothing Then
                wnombre = wnombre + " " + Primer_Apellido.Trim
            End If
            If Segundo_Apellido IsNot Nothing Then
                wnombre = wnombre + " " + Segundo_Apellido.Trim
            End If
            Return wnombre
        End Get
    End Property

    Public ReadOnly Property GeneroPersona() As String
        Get
            If Genero Is Nothing Then
                Return ""
            Else
                Return Genero.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Persona_Discapacitado() As String
        Get
            If Discapacitado Is Nothing Then
                Return ""
            Else
                Return Discapacitado.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Persona_UltimoGrado() As String
        Get
            If Ultimo_Grado Is Nothing Then
                Return ""
            Else
                Return Ultimo_Grado.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Persona_Grupo_Etnico() As String
        Get
            If Grupo_Etnico Is Nothing Then
                Return ""
            Else
                Return Grupo_Etnico.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Nombre_Municipio_Actual() As String
        Get
            If Municipio_Actual Is Nothing Then
                Return ""
            Else
                Return Municipio_Actual.Descripcion
            End If
        End Get
    End Property





    Public ReadOnly Property Regimen_Salud_Antes() As Personas_Regimen_SaludBrl
        Get
            Dim PRS As List(Of Personas_Regimen_SaludBrl) = Personas_Regimen_SaludBrl.CargarPorId_Persona(ID)
            Dim objrs As New Personas_Regimen_SaludBrl
            FilterHelper.FilterHelper(PRS, "Id_Tipo_Entrega", 54)

            If PRS.Count > 0 Then
                Return PRS.Item(0)
            Else
                Return objrs
            End If
        End Get
    End Property

    Public ReadOnly Property Regimen_Salud_Despues() As Personas_Regimen_SaludBrl
        Get
            Dim PRS As List(Of Personas_Regimen_SaludBrl) = Personas_Regimen_SaludBrl.CargarPorId_Persona(ID)
            Dim objrs As New Personas_Regimen_SaludBrl
            FilterHelper.FilterHelper(PRS, "Id_Tipo_Entrega", 72)
            If PRS.Count > 0 Then
                Return PRS.Item(0)
            Else
                Return objrs
            End If
        End Get
    End Property

    Public ReadOnly Property Persona_Regimen_Salud_Antes() As String
        Get
            Dim wcadena As String = ""
            For Each fila As Personas_Regimen_SaludBrl In Personas_Regimen_Salud
                If fila.Id_Tipo_Entrega = 54 Then
                    wcadena = fila.Regimen_Salud.Descripcion
                End If
            Next
            Return wcadena
        End Get
    End Property

    Public ReadOnly Property EPS_Antes_Persona() As String
        Get
            Dim wcadena As String = ""
            Try
                For Each fila As Personas_Regimen_SaludBrl In Personas_Regimen_Salud
                    If fila.Id_Tipo_Entrega = 54 Then
                        wcadena = fila.Eps.Descripcion
                    End If
                Next
            Catch ex As Exception
            End Try
            Return wcadena
        End Get
    End Property

    Public ReadOnly Property Municipio_Antes_Persona() As String
        Get
            Dim wcadena As String = ""
            For Each fila As Personas_Regimen_SaludBrl In Personas_Regimen_Salud
                If fila.Id_Tipo_Entrega = 54 Then
                    wcadena = fila.MunicipioRegimenSalud
                End If
            Next
            Return wcadena
        End Get
    End Property

    Public ReadOnly Property Persona_Regimen_Salud_Despues() As String
        Get
            Dim wcadena As String = ""
            For Each fila As Personas_Regimen_SaludBrl In Personas_Regimen_Salud
                If fila.Id_Tipo_Entrega = 72 Then
                    wcadena = fila.Regimen_Salud.Descripcion
                End If
            Next
            Return wcadena
        End Get
    End Property

    Public ReadOnly Property EPS_Despues_Persona() As String
        Get
            Dim wcadena As String = ""
            For Each fila As Personas_Regimen_SaludBrl In Personas_Regimen_Salud
                If fila.Id_Tipo_Entrega = 72 Then
                    wcadena = fila.Eps.Descripcion
                End If
            Next
            Return wcadena
        End Get
    End Property

    Public ReadOnly Property Municipio_Despues_Persona() As String
        Get
            Dim wcadena As String = ""
            For Each fila As Personas_Regimen_SaludBrl In Personas_Regimen_Salud
                If fila.Id_Tipo_Entrega = 72 Then
                    wcadena = fila.MunicipioRegimenSalud
                End If
            Next
            Return wcadena
        End Get
    End Property

    Public ReadOnly Property Persona_Regimen_Salud_SE() As String
        Get
            Dim wcadena As String = ""
            For Each fila As Personas_Regimen_SaludBrl In Personas_Regimen_Salud
                If fila.Id_Tipo_Entrega = 918 Then
                    wcadena = fila.Regimen_Salud.Descripcion
                End If
            Next
            Return wcadena
        End Get
    End Property

    Public ReadOnly Property EPS_SE_Persona() As String
        Get
            Dim wcadena As String = ""
            For Each fila As Personas_Regimen_SaludBrl In Personas_Regimen_Salud
                If fila.Id_Tipo_Entrega = 918 Then
                    wcadena = fila.Eps.Descripcion
                End If
            Next
            Return wcadena
        End Get
    End Property

    Public ReadOnly Property Municipio_SE_Persona() As String
        Get
            Dim wcadena As String = ""
            For Each fila As Personas_Regimen_SaludBrl In Personas_Regimen_Salud
                If fila.Id_Tipo_Entrega = 918 Then
                    wcadena = fila.MunicipioRegimenSalud
                End If
            Next
            Return wcadena
        End Get
    End Property

    Public ReadOnly Property Fecha_SE_Persona() As Date
        Get
            Dim wcadena As Date = Nothing
            For Each fila As Personas_Regimen_SaludBrl In Personas_Regimen_Salud
                If fila.Id_Tipo_Entrega = 918 Then
                    wcadena = fila.Fecha
                End If
            Next
            Return wcadena
        End Get
    End Property

    Public ReadOnly Property Persona_Regimen_Salud_Final() As String
        Get
            Dim wcadena As String = ""
            If Personas_Regimen_Salud.Count > 0 Then
                If Personas_Regimen_Salud.Item(Personas_Regimen_Salud.Count - 1).Id_Tipo_Entrega = 919 Then
                    wcadena = Personas_Regimen_Salud.Item(Personas_Regimen_Salud.Count - 1).Regimen_Salud.Descripcion
                End If
            End If

            Return wcadena
        End Get
    End Property

    Public ReadOnly Property Persona_EPS_Final() As String
        Get
            Dim wcadena As String = ""
            Try
                If Personas_Regimen_Salud.Count > 0 Then
                    If Personas_Regimen_Salud.Item(Personas_Regimen_Salud.Count - 1).Id_Tipo_Entrega = 919 Then
                        wcadena = Personas_Regimen_Salud.Item(Personas_Regimen_Salud.Count - 1).Eps.Descripcion
                    End If
                End If
            Catch ex As Exception
            End Try

            Return wcadena
        End Get
    End Property

    Public ReadOnly Property Persona_Municipio_Final() As String
        Get
            Dim wcadena As String = ""
            Try
                If Personas_Regimen_Salud.Count > 0 Then
                    If Personas_Regimen_Salud.Item(Personas_Regimen_Salud.Count - 1).Id_Tipo_Entrega = 919 Then
                        wcadena = Personas_Regimen_Salud.Item(Personas_Regimen_Salud.Count - 1).MunicipioRegimenSalud
                    End If
                End If
            Catch ex As Exception
            End Try

            Return wcadena
        End Get
    End Property

    Public ReadOnly Property Persona_Fecha_Final() As String
        Get
            Dim wcadena As Date = Nothing
            Try
                If Personas_Regimen_Salud.Count > 0 Then
                    If Personas_Regimen_Salud.Item(Personas_Regimen_Salud.Count - 1).Id_Tipo_Entrega = 919 Then
                        wcadena = Personas_Regimen_Salud.Item(Personas_Regimen_Salud.Count - 1).Fecha
                    End If
                End If
            Catch ex As Exception
            End Try

            Return wcadena
        End Get
    End Property

    Public ReadOnly Property Estudiaba_Antes() As String
        Get
            If Estudia_Antes Is Nothing Then
                Return ""
            Else
                Return Estudia_Antes.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Estudiaba_Actualmente() As String
        Get
            If Estudia_Actualmente Is Nothing Then
                Return ""
            Else
                Return Estudia_Actualmente.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Certificado() As String
        Get
            If CertificadoPrimera_Entrega Is Nothing Then
                Return ""
            Else
                Return CertificadoPrimera_Entrega.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Sabe_LeerEscribir() As String
        Get
            If Sabe_Leer_Escribir Is Nothing Then
                Return ""
            Else
                Return Sabe_Leer_Escribir.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property MotivoNoestudiaPrimeraEntrega() As String
        Get
            If Motivo_NoEstudio Is Nothing Then
                Return ""
            Else
                Return Motivo_NoEstudio.Descripcion

            End If
        End Get
    End Property

    Public ReadOnly Property Persona_TipoDiscapacidad() As String
        Get
            If Tipo_Discapacidad Is Nothing Then
                Return ""
            Else
                Return Tipo_Discapacidad.Descripcion

            End If
        End Get
    End Property

    Public Property Personas_Educacion() As List(Of Personas_EducacionBrl)
        Get
            If (Me.objListPersonas_Educacion Is Nothing) Then
                objListPersonas_Educacion = Personas_EducacionBrl.CargarPorId_Persona(Me.ID)
            End If
            Return Me.objListPersonas_Educacion
        End Get
        Set(ByVal Value As List(Of Personas_EducacionBrl))
            Me.objListPersonas_Educacion = Value
        End Set
    End Property

    Public ReadOnly Property Personas_EducacionSegunda_Entrega() As Personas_EducacionBrl
        Get
            Return Personas_EducacionBrl.CargarPorId_PersonaySegunda_Entrega(Me.ID, 918)
        End Get
    End Property

    Public ReadOnly Property Grado_SE() As String
        Get
            If Personas_EducacionSegunda_Entrega Is Nothing Then
                Return ""
            Else
                If Personas_EducacionSegunda_Entrega.SubTablasGrado_Escolar Is Nothing Then
                    Return ""
                Else
                    Return Personas_EducacionSegunda_Entrega.SubTablasGrado_Escolar.Descripcion
                End If
            End If
        End Get
    End Property

    Public ReadOnly Property EstudiaActualmente_SE() As String
        Get
            If Personas_EducacionSegunda_Entrega Is Nothing Then
                Return ""
            Else
                If Personas_EducacionSegunda_Entrega.SubTablasEstudia_Actualmente Is Nothing Then
                    Return ""
                Else
                    Return Personas_EducacionSegunda_Entrega.SubTablasEstudia_Actualmente.Descripcion
                End If
            End If
        End Get
    End Property

    Public ReadOnly Property Certificado_SE() As String
        Get
            If Personas_EducacionSegunda_Entrega Is Nothing Then
                Return ""
            Else
                If Personas_EducacionSegunda_Entrega.SubTablasCertificado_Matricula Is Nothing Then
                    Return ""
                Else
                    Return Personas_EducacionSegunda_Entrega.SubTablasCertificado_Matricula.Descripcion
                End If
            End If
        End Get
    End Property

    Public ReadOnly Property MotivoNoEstudia_SE() As String
        Get
            If Personas_EducacionSegunda_Entrega Is Nothing Then
                Return ""
            Else
                If Personas_EducacionSegunda_Entrega.SubTablasMotivo_NoEstudia Is Nothing Then
                    Return ""
                Else
                    Return Personas_EducacionSegunda_Entrega.SubTablasMotivo_NoEstudia.Descripcion
                End If

            End If
        End Get
    End Property

    Public ReadOnly Property Seguimiento_SE() As String
        Get
            If Personas_EducacionSegunda_Entrega Is Nothing Then
                Return ""
            Else
                If Personas_EducacionSegunda_Entrega.SubTablasSeguimiento Is Nothing Then
                    Return ""
                Else
                    Return Personas_EducacionSegunda_Entrega.SubTablasSeguimiento.Descripcion
                End If
            End If
        End Get
    End Property

    Public ReadOnly Property Establecimiento() As String
        Get
            If Personas_EducacionSegunda_Entrega Is Nothing Then
                Return ""
            Else
                If Personas_EducacionSegunda_Entrega.SubTablasGrado_Escolar Is Nothing Then
                    Return ""
                Else
                    Return Personas_EducacionSegunda_Entrega.Establecimiento
                End If

            End If
        End Get
    End Property

    Public ReadOnly Property Municipio_Establecimiento_SE() As String
        Get
            If Personas_EducacionSegunda_Entrega Is Nothing Then
                Return ""
            Else
                If Personas_EducacionSegunda_Entrega.Municipio_Institucion Is Nothing Then
                    Return ""
                Else
                    Return Personas_EducacionSegunda_Entrega.Municipio_Institucion.Descripcion
                End If

            End If
        End Get
    End Property


    Public ReadOnly Property Fecha_Segunda_Encuesta() As DateTime
        Get
            If Personas_EducacionSegunda_Entrega Is Nothing Then
                Return Nothing
            Else
                Return Personas_EducacionSegunda_Entrega.Fecha
            End If
        End Get
    End Property

    Public ReadOnly Property Personas_EducacionSeguimiento() As Personas_EducacionBrl
        Get
            Return Personas_EducacionBrl.CargarPorId_PersonaySegunda_Entrega(Me.ID, 919)
        End Get
    End Property

    Public Event Fecha_SeguimientoChange(ByVal Value As DateTime)

    Public ReadOnly Property FechaSeguimiento() As DateTime
        Get
            If Personas_EducacionSeguimiento Is Nothing Then
                Return Nothing
                RaiseEvent Fecha_SeguimientoChange(FechaSeguimiento)

            Else
                If Personas_EducacionSeguimiento.Fecha Is Nothing Then
                    Return Nothing
                    RaiseEvent Fecha_SeguimientoChange(FechaSeguimiento)
                Else
                    Return Personas_EducacionSeguimiento.Fecha
                End If
            End If
        End Get
    End Property

    Public ReadOnly Property GradoSeguimiento() As String
        Get
            If Personas_EducacionSeguimiento Is Nothing Then
                Return ""
            Else
                If Personas_EducacionSeguimiento.SubTablasGrado_Escolar Is Nothing Then
                    Return ""
                Else
                    Return Personas_EducacionSeguimiento.SubTablasGrado_Escolar.Descripcion
                End If
            End If
        End Get
    End Property

    Public ReadOnly Property EstudiaActualmenteSeguimiento() As String
        Get
            If Personas_EducacionSeguimiento Is Nothing Then
                Return ""
            Else
                If Personas_EducacionSeguimiento.SubTablasEstudia_Actualmente Is Nothing Then
                    Return ""
                Else
                    Return Personas_EducacionSeguimiento.SubTablasEstudia_Actualmente.Descripcion
                End If
            End If
        End Get
    End Property

    Public ReadOnly Property CertificadoSeguimiento() As String
        Get
            If Personas_EducacionSeguimiento Is Nothing Then
                Return ""
            Else
                If Personas_EducacionSeguimiento.SubTablasCertificado_Matricula Is Nothing Then
                    Return ""
                Else
                    Return Personas_EducacionSeguimiento.SubTablasCertificado_Matricula.Descripcion
                End If
            End If
        End Get
    End Property

    Public ReadOnly Property MotivoNoEstudiaSeguimiento() As String
        Get
            If Personas_EducacionSeguimiento Is Nothing Then
                Return ""
            Else
                If Personas_EducacionSeguimiento.SubTablasMotivo_NoEstudia Is Nothing Then
                    Return ""
                Else
                    Return Personas_EducacionSeguimiento.SubTablasMotivo_NoEstudia.Descripcion
                End If

            End If
        End Get
    End Property

    Public ReadOnly Property SeguimientoSeguimiento() As String
        Get
            If Personas_EducacionSeguimiento Is Nothing Then
                Return ""
            Else
                If Personas_EducacionSeguimiento.SubTablasSeguimiento Is Nothing Then
                    Return ""
                Else
                    Return Personas_EducacionSeguimiento.SubTablasSeguimiento.Descripcion
                End If
            End If
        End Get
    End Property

    Public ReadOnly Property EstablecimientoSeguimiento() As String
        Get
            If Personas_EducacionSeguimiento Is Nothing Then
                Return ""
            Else
                If Personas_EducacionSeguimiento.SubTablasGrado_Escolar Is Nothing Then
                    Return ""
                Else
                    Return Personas_EducacionSeguimiento.Establecimiento
                End If

            End If
        End Get
    End Property

    Public ReadOnly Property MunicipioSeguimiento() As String
        Get
            If Personas_EducacionSeguimiento Is Nothing Then
                Return ""
            Else
                If Personas_EducacionSeguimiento.Municipio_Institucion Is Nothing Then
                    Return ""
                Else
                    Return Personas_EducacionSeguimiento.Municipio_Institucion.Descripcion
                End If

            End If
        End Get
    End Property


    Public ReadOnly Property Verificado() As String
        Get
            If Personas_EducacionSeguimiento Is Nothing Then
                Return ""
            Else
                Select Case Personas_EducacionSeguimiento.Verificado_Entidad
                    Case 0
                        Return "NO"
                    Case 1
                        Return "SI"
                    Case Else
                        Return ""
                End Select


            End If
        End Get
    End Property

    Public ReadOnly Property TipoApoyoEducativo As String
        Get
            If Tipo_Apoyo_Educativo Is Nothing Then
                Return ""
            Else
                Return Tipo_Apoyo_Educativo.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property primeravaloracion() As Boolean
        Get
            If Salud.Count = 0 Then Return False
            If Salud.Item(0).Salud_Valoracion.Count = 0 Then Return False
            Return Salud.Item(0).RealizoValoracion_PrimeraEntrega
        End Get
    End Property

    Public ReadOnly Property segundavaloracion() As Boolean
        Get
            If Salud.Count = 0 Then Return False
            If Salud.Item(0).Salud_Valoracion.Count = 0 Then Return False
            Return Salud.Item(0).RealizoValoracion_SegundaEntrega
        End Get
    End Property

    Public ReadOnly Property seguimientovaloracion() As Boolean
        Get
            If Salud.Count = 0 Then Return False
            If Salud.Item(0).Salud_Valoracion.Count = 0 Then Return False
            Return Salud.Item(0).RealizoValoracion_Seguimiento
        End Get
    End Property

    Public ReadOnly Property cantidadvaloraciones() As Double
        Get
            If Salud.Count = 0 Then Return 0
            If Salud.Item(0).Salud_Valoracion.Count = 0 Then Return 0
            Return Salud.Item(0).CantidadValoraciones
        End Get
    End Property

    Public ReadOnly Property ControlPrenatal() As String
        Get
            If Gestantes.Count = 0 Then Return "SD"
            Return Gestantes.Item(0).ControlPrenatal
        End Get
    End Property

    Public ReadOnly Property FechaControlPrenatal() As DateTime
        Get
            Dim wfecha As DateTime = Nothing
            If Gestantes.Count = 0 Then Return wfecha
            Return Gestantes.Item(0).Fecha_Control_Prenatal
        End Get
    End Property

    Public ReadOnly Property UnidadAtencion() As String
        Get
            If Gestantes.Count = 0 Then Return "SD"
            Return Gestantes.Item(0).Unidad_Basica_Atencion
        End Get
    End Property

    Public ReadOnly Property Ingesta() As String
        Get
            If Gestantes.Count = 0 Then Return "SD"
            Return Gestantes.Item(0).IngestaMicronutrientes
        End Get
    End Property

    Public ReadOnly Property SemanasGestacion() As Integer
        Get
            If Gestantes.Count = 0 Then Return 0
            Return Gestantes.Item(0).Semanas_Gestacion
        End Get
    End Property

    Public ReadOnly Property Remitidas() As String
        Get
            If Gestantes.Count = 0 Then Return "SD"
            Return Gestantes.Item(0).Remitidas
        End Get
    End Property

    Public ReadOnly Property FechaRemision() As DateTime
        Get
            Dim wfecha As DateTime = Nothing
            If Gestantes.Count = 0 Then Return wfecha
            Return Gestantes.Item(0).Fecha_Remision
        End Get
    End Property

    Public ReadOnly Property Enfermedades() As String
        Get
            If Gestantes.Count = 0 Then Return "SD"
            Return Gestantes.Item(0).Enfermedades
        End Get
    End Property

    Public ReadOnly Property Observaciones() As String
        Get
            If Gestantes.Count = 0 Then Return "SD"
            Return Gestantes.Item(0).Observaciones
        End Get
    End Property

    Public ReadOnly Property VisitaDomiciliaria() As String
        Get
            If Gestantes.Count = 0 Then Return "SD"
            Return Gestantes.Item(0).VisitaDomiciliaria
        End Get
    End Property

    Public ReadOnly Property FechaVisita() As DateTime
        Get
            Dim wfecha As DateTime = Nothing
            If Gestantes.Count = 0 Then Return wfecha
            Return Gestantes.Item(0).Fecha_Visita
        End Get
    End Property

    Public ReadOnly Property Observaciones_Visita() As String
        Get
            If Gestantes.Count = 0 Then Return "SD"
            Return Gestantes.Item(0).Observaciones_Visita
        End Get
    End Property

    Public ReadOnly Property CrecimientoyDesarrollo() As String
        Get
            If Salud.Count = 0 Then Return "SD"
            Return Salud.Item(0).CrecimientoyDesarrollo
        End Get
    End Property

    Public ReadOnly Property Patologia() As String
        Get
            If Salud.Count = 0 Then Return "SD"
            Return Salud.Item(0).Patologia
        End Get
    End Property

    Public ReadOnly Property Lactancia_Lactando() As String
        Get
            If Salud.Count = 0 Then Return "SD"
            Return Salud.Item(0).Lactando
        End Get
    End Property

    Public ReadOnly Property Lactancia_meses() As Integer
        Get
            If Salud.Count = 0 Then Return 0
            Return Salud.Item(0).Lactancia_meses
        End Get
    End Property

    Public ReadOnly Property Lactancia_exclusiva() As Integer
        Get
            If Salud.Count = 0 Then Return 0
            Return Salud.Item(0).Lactancia_Exclusiva
        End Get
    End Property

    Public ReadOnly Property Desparasitacion() As String
        Get
            If Salud.Count = 0 Then Return "SD"
            Return Salud.Item(0).Desparasitacion
        End Get
    End Property

    Public ReadOnly Property Suplementacion() As String
        Get
            If Salud.Count = 0 Then Return "SD"
            Return Salud.Item(0).Suplementacion
        End Get
    End Property

    Public ReadOnly Property TieneCarnet() As String
        Get
            If Salud.Count = 0 Then Return "SD"
            Return Salud.Item(0).TieneCarnet
        End Get
    End Property

    Public ReadOnly Property MotivoNoCarnet() As String
        Get
            If Salud.Count = 0 Then Return "SD"
            Return Salud.Item(0).MotivoNoCarnet
        End Get
    End Property

    Public ReadOnly Property VacunacionCompleta() As String
        Get
            If Salud.Count = 0 Then Return "SD"
            Return Salud.Item(0).VacunacionCompleta
        End Get
    End Property

    Public ReadOnly Property MotivoNoVacunacionCompleta() As String
        Get
            If Salud.Count = 0 Then Return "SD"
            Return Salud.Item(0).MotivoNovacunacionCompleta
        End Get
    End Property

    Public ReadOnly Property Vacunados() As String
        Get
            If Salud.Count = 0 Then Return "SD"
            Return Salud.Item(0).Vacunados
        End Get
    End Property

    Public ReadOnly Property MotivoNoVacunados() As String
        Get
            If Salud.Count = 0 Then Return "SD"
            Return Salud.Item(0).MotivoNovacunados
        End Get
    End Property

    Public ReadOnly Property Fecha_Esquema_Vacunacion() As DateTime
        Get
            Dim wfecha As DateTime = Nothing
            If Salud.Count = 0 Then Return wfecha
            Return Salud.Item(0).Fecha_Esquema_Vacunacion
        End Get
    End Property

    Public ReadOnly Property ObservacionesSalud() As String
        Get
            If Salud.Count = 0 Then Return "SD"
            Return Salud.Item(0).Observaciones
        End Get
    End Property

    Public ReadOnly Property SAP() As Boolean
        Get
            If Me.Id_Solicito_Atencion_Psicologica = 19 Then Return True Else Return False
        End Get
    End Property

    Public ReadOnly Property RAP() As Boolean
        Get
            If Me.Id_Recibio_Atencion_Psicologica = 19 Then Return True Else Return False
        End Get
    End Property

    Public ReadOnly Property ADD() As Boolean
        Get
            If Me.Id_Afectado_Desplazamiento = 19 Then Return True Else Return False
        End Get
    End Property

    '
    ' Regimen de salud segunda entrega
    '
    Public ReadOnly Property Personas_RegimenSegunda_Entrega() As Personas_Regimen_SaludBrl
        Get
            Return Personas_Regimen_SaludBrl.CargarPorId_PersonaySegundaEntrega(Me.ID, 918)
        End Get
    End Property

    Public ReadOnly Property RegimenSegundaEntrega() As String
        Get
            If Personas_RegimenSegunda_Entrega Is Nothing Then
                Return ""
            Else
                Return Personas_RegimenSegunda_Entrega.Regimen_Salud.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property EPSSegundaEntrega() As String
        Get
            If Personas_RegimenSegunda_Entrega Is Nothing Then
                Return ""
            Else
                Return Personas_RegimenSegunda_Entrega.Eps.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property MunicipioSegundaEntrega() As String
        Get
            If Personas_RegimenSegunda_Entrega Is Nothing Then
                Return ""
            Else
                Return Personas_RegimenSegunda_Entrega.Municipio
            End If
        End Get
    End Property

    Public ReadOnly Property NecesitaTrasladoSegundaEntrega() As String
        Get
            If Personas_RegimenSegunda_Entrega Is Nothing Then
                Return ""
            Else
                Return Personas_RegimenSegunda_Entrega.Necesita_Traslado.Descripcion
            End If
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
            Me.ID = PersonasDAL.Insertar(Id_Declaracion, Tipo, Id_Tipo_Identificacion, Identificacion, Primer_Nombre, Segundo_Nombre, Primer_Apellido, Segundo_Apellido, Id_Genero, Fecha_Nacimiento, Edad, Id_Parentesco, Id_Discapacitado, Id_Estudia_Antes, Id_Estudia_Actualmente, Id_Ultimo_Grado, Institucion_Estudia, Id_Motivo_NoEstudio, Id_Tipo_Discapacidad, Id_Grupo_Etnico, Id_Embarazada, Id_Lactando, Id_Solicito_Atencion_Psicologica, Id_Recibio_Atencion_Psicologica, Quien_Atencion_Psicologica, Id_Recibio_Tratamiento, Id_Causas_Discapacidad, Id_Sabe_Leer_Escribir, Institucion_Estudiaba, Id_Paga_Matricula, Id_Tipo_Apoyo_Educativo, Id_Problemas_Establecimiento, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Edad_Semanas, Fecha_Cierre, Cierre, Id_Tipo_Miembro, Id_Afectado_Desplazamiento, Id_Certificado, Id_Municipio_Instituto_Antes, Id_Municipio_Instituto_Actual)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            PersonasDAL.Actualizar(ID, Id_Declaracion, Tipo, Id_Tipo_Identificacion, Identificacion, Primer_Nombre, Segundo_Nombre, Primer_Apellido, Segundo_Apellido, Id_Genero, Fecha_Nacimiento, Edad, Id_Parentesco, Id_Discapacitado, Id_Estudia_Antes, Id_Estudia_Actualmente, Id_Ultimo_Grado, Institucion_Estudia, Id_Motivo_NoEstudio, Id_Tipo_Discapacidad, Id_Grupo_Etnico, Id_Embarazada, Id_Lactando, Id_Solicito_Atencion_Psicologica, Id_Recibio_Atencion_Psicologica, Quien_Atencion_Psicologica, Id_Recibio_Tratamiento, Id_Causas_Discapacidad, Id_Sabe_Leer_Escribir, Institucion_Estudiaba, Id_Paga_Matricula, Id_Tipo_Apoyo_Educativo, Id_Problemas_Establecimiento, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Edad_Semanas, Fecha_Cierre, Cierre, Id_Tipo_Miembro, Id_Afectado_Desplazamiento, Id_Certificado, Id_Municipio_Instituto_Antes, Id_Municipio_Instituto_Actual)
            RaiseEvent Updated()
        End If
        If Not objListPersonas_Contactos Is Nothing Then
            For Each fila As Personas_ContactosBrl In objListPersonas_Contactos
                fila.Id_Persona = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListGestantes Is Nothing Then
            For Each fila As GestantesBrl In objListGestantes
                fila.Id_Persona = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListSalud Is Nothing Then
            For Each fila As SaludBrl In objListSalud
                fila.Id_Persona = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListPersonas_Educacion Is Nothing Then
            For Each fila As Personas_EducacionBrl In objListPersonas_Educacion
                fila.Id_Persona = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListPersonas_Regimen_Salud Is Nothing Then
            For Each fila As Personas_Regimen_SaludBrl In objListPersonas_Regimen_Salud
                fila.Id_Persona = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListPersonas_Afectado Is Nothing Then
            For Each fila As Personas_AfectadoBrl In objListPersonas_Afectado
                fila.Id_Persona = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        RaiseEvent Saved()

    End Sub

    Public Function Eliminar() As Integer
        Dim totalHijos As Long = 0
        Dim wvalor As Integer = 0
        If Me.ID <> Nothing Then

            RaiseEvent Deleting()
            totalHijos += Personas_Contactos.Count
            totalHijos += Gestantes.Count
            totalHijos += Salud.Count
            totalHijos += Personas_Educacion.Count
            totalHijos += Personas_Regimen_Salud.Count
            totalHijos += Personas_Afectado.Count

            If totalHijos > 2 Then
                wvalor = 1
            End If
            'Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            Try
                PersonasDAL.Eliminar(Me.ID)
                wvalor = 0
            Catch ex As Exception
                wvalor = 1
            End Try
            RaiseEvent Deleted()

        End If
        Return wvalor
    End Function

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As PersonasBrl

        Dim objPersonas As New PersonasBrl

        With objPersonas
            .ID = fila("Id")
            .Id_Declaracion = isDBNullToNothing(fila("Id_Declaracion"))
            .Tipo = isDBNullToNothing(fila("Tipo"))
            .Id_Tipo_Identificacion = isDBNullToNothing(fila("Id_Tipo_Identificacion"))
            .Identificacion = isDBNullToNothing(fila("Identificacion"))
            .Primer_Nombre = isDBNullToNothing(fila("Primer_Nombre"))
            .Segundo_Nombre = isDBNullToNothing(fila("Segundo_Nombre"))
            .Primer_Apellido = isDBNullToNothing(fila("Primer_Apellido"))
            .Segundo_Apellido = isDBNullToNothing(fila("Segundo_Apellido"))
            .Id_Genero = isDBNullToNothing(fila("Id_Genero"))
            .Fecha_Nacimiento = isDBNullToNothing(fila("Fecha_Nacimiento"))
            .Edad = isDBNullToNothing(fila("Edad"))
            .Id_Parentesco = isDBNullToNothing(fila("Id_Parentesco"))
            .Id_Discapacitado = isDBNullToNothing(fila("Id_Discapacitado"))
            .Id_Estudia_Antes = isDBNullToNothing(fila("Id_Estudia_Antes"))
            .Id_Estudia_Actualmente = isDBNullToNothing(fila("Id_Estudia_Actualmente"))
            .Id_Ultimo_Grado = isDBNullToNothing(fila("Id_Ultimo_Grado"))
            .Institucion_Estudia = isDBNullToNothing(fila("Institucion_Estudia"))
            .Id_Motivo_NoEstudio = isDBNullToNothing(fila("Id_Motivo_NoEstudio"))
            .Id_Tipo_Discapacidad = isDBNullToNothing(fila("Id_Tipo_Discapacidad"))
            .Id_Grupo_Etnico = isDBNullToNothing(fila("Id_Grupo_Etnico"))
            .Id_Embarazada = isDBNullToNothing(fila("Id_Embarazada"))
            .Id_Lactando = isDBNullToNothing(fila("Id_Lactando"))
            .Id_Solicito_Atencion_Psicologica = isDBNullToNothing(fila("Id_Solicito_Atencion_Psicologica"))
            .Id_Recibio_Atencion_Psicologica = isDBNullToNothing(fila("Id_Recibio_Atencion_Psicologica"))
            .Quien_Atencion_Psicologica = isDBNullToNothing(fila("Quien_Atencion_Psicologica"))
            .Id_Recibio_Tratamiento = isDBNullToNothing(fila("Id_Recibio_Tratamiento"))
            .Id_Causas_Discapacidad = isDBNullToNothing(fila("Id_Causas_Discapacidad"))
            .Id_Sabe_Leer_Escribir = isDBNullToNothing(fila("Id_Sabe_Leer_Escribir"))
            .Institucion_Estudiaba = isDBNullToNothing(fila("Institucion_Estudiaba"))
            .Id_Paga_Matricula = isDBNullToNothing(fila("Id_Paga_Matricula"))
            .Id_Tipo_Apoyo_Educativo = isDBNullToNothing(fila("Id_Tipo_Apoyo_Educativo"))
            .Id_Problemas_Establecimiento = isDBNullToNothing(fila("Id_Problemas_Establecimiento"))
            .Fecha_Creacion = isDBNullToNothing(fila("Fecha_Creacion"))
            .Id_Usuario_Creacion = isDBNullToNothing(fila("Id_Usuario_Creacion"))
            .Fecha_Modificacion = isDBNullToNothing(fila("Fecha_Modificacion"))
            .Id_Usuario_Modificacion = isDBNullToNothing(fila("Id_Usuario_Modificacion"))
            .Edad_Semanas = isDBNullToNothing(fila("Edad_Semanas"))
            .Fecha_Cierre = isDBNullToNothing(fila("Fecha_Cierre"))
            .Cierre = isDBNullToNothing(fila("Cierre"))
            .Id_Tipo_Miembro = isDBNullToNothing(fila("Id_Tipo_Miembro"))
            .Id_Afectado_Desplazamiento = isDBNullToNothing(fila("Id_Afectado_Desplazamiento"))
            .Id_Certificado = isDBNullToNothing(fila("Id_Certificado"))
            .Id_Municipio_Instituto_Antes = isDBNullToNothing(fila("Id_Municipio_Instituto"))
            .Id_Municipio_Instituto_Actual = isDBNullToNothing(fila("Id_Municipio_Instituto_Actual"))
        End With

        Return objPersonas

    End Function

    Public Shared Event LoadingPersonasList(ByVal LoadType As String)
    Public Shared Event LoadedPersonasList(ByVal target As List(Of PersonasBrl), ByVal LoadType As String)

    Public Shared Function CargarTodos() As List(Of PersonasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)

        RaiseEvent LoadingPersonasList("CargarTodos")

        dsDatos = PersonasDAL.CargarTodos()

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedPersonasList(lista, "CargarTodos")

        Return lista

    End Function

    Public Shared Event LoadingPorId(ByVal id As Int32)
    Public Shared Event LoadedPorId(ByVal target As PersonasBrl)

    Public Shared Function CargarPorID(ByVal ID As Int32) As PersonasBrl
        Dim dsDatos As System.Data.DataSet
        Dim objPersonas As PersonasBrl = Nothing
        dsDatos = PersonasDAL.CargarPorID(ID)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objPersonas = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objPersonas
    End Function

    Public Shared Function CargarPorId_DeclaracionYDeclarante(ByVal ID As Int32) As PersonasBrl
        Dim dsDatos As System.Data.DataSet
        Dim objPersonas As PersonasBrl = Nothing
        dsDatos = PersonasDAL.CargarPorIDyDeclarante(ID)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objPersonas = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objPersonas
    End Function

    Public Shared Function CargarPorId_DeclaracionYBeneficiarios(ByVal Id As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        dsDatos = PersonasDAL.CargarPorIDyBeneficiarios(Id)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_Declaracion(ByVal Id_Declaracion As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        RaiseEvent LoadingPersonasList("CargarPorId_Declaracion")
        dsDatos = PersonasDAL.CargarPorId_Declaracion(Id_Declaracion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPersonasList(lista, "CargarPorId_Declaracion")
        Return lista
    End Function

    Public Shared Function CargarPorId_Declaracion_Educacion(ByVal Id_Declaracion As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        dsDatos = PersonasDAL.CargarPorId_Declaracion_Educacion(Id_Declaracion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_Declaracion_EducacionPendiente(ByVal Id_Declaracion As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        dsDatos = PersonasDAL.CargarPorId_Declaracion_EducacionPendiente(Id_Declaracion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_Discapacitado(ByVal Id_Discapacitado As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        RaiseEvent LoadingPersonasList("CargarPorId_Discapacitado")
        dsDatos = PersonasDAL.CargarPorId_Discapacitado(Id_Discapacitado)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPersonasList(lista, "CargarPorId_Discapacitado")
        Return lista
    End Function

    Public Shared Function CargarPorId_Genero(ByVal Id_Genero As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        RaiseEvent LoadingPersonasList("CargarPorId_Genero")
        dsDatos = PersonasDAL.CargarPorId_Genero(Id_Genero)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPersonasList(lista, "CargarPorId_Genero")
        Return lista
    End Function

    Public Shared Function CargarPorId_Motivo_NoEstudio(ByVal Id_Motivo_NoEstudio As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        RaiseEvent LoadingPersonasList("CargarPorId_Motivo_NoEstudio")
        dsDatos = PersonasDAL.CargarPorId_Motivo_NoEstudio(Id_Motivo_NoEstudio)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPersonasList(lista, "CargarPorId_Motivo_NoEstudio")
        Return lista
    End Function

    Public Shared Function CargarPorId_Parentesco(ByVal Id_Parentesco As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        RaiseEvent LoadingPersonasList("CargarPorId_Parentesco")
        dsDatos = PersonasDAL.CargarPorId_Parentesco(Id_Parentesco)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPersonasList(lista, "CargarPorId_Parentesco")
        Return lista
    End Function

    Public Shared Function CargarPorId_Tipo_Identificacion(ByVal Id_Tipo_Identificacion As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        RaiseEvent LoadingPersonasList("CargarPorId_Tipo_Identificacion")
        dsDatos = PersonasDAL.CargarPorId_Tipo_Identificacion(Id_Tipo_Identificacion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPersonasList(lista, "CargarPorId_Tipo_Identificacion")
        Return lista
    End Function

    Public Shared Function CargarPorId_Ultimo_Grado(ByVal Id_Ultimo_Grado As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        RaiseEvent LoadingPersonasList("CargarPorId_Ultimo_Grado")
        dsDatos = PersonasDAL.CargarPorId_Ultimo_Grado(Id_Ultimo_Grado)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPersonasList(lista, "CargarPorId_Ultimo_Grado")
        Return lista
    End Function

    Public Shared Function CargarPorId_Estudia_Actualmente(ByVal Id_Estudia_Actualmente As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        RaiseEvent LoadingPersonasList("CargarPorId_Estudia_Actualmente")
        dsDatos = PersonasDAL.CargarPorId_Estudia_Actualmente(Id_Estudia_Actualmente)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPersonasList(lista, "CargarPorId_Estudia_Actualmente")
        Return lista
    End Function

    Public Shared Function CargarPorId_Causas_Discapacidad(ByVal Id_Causas_Discapacidad As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        RaiseEvent LoadingPersonasList("CargarPorId_Causas_Discapacidad")
        dsDatos = PersonasDAL.CargarPorId_Causas_Discapacidad(Id_Causas_Discapacidad)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPersonasList(lista, "CargarPorId_Causas_Discapacidad")
        Return lista
    End Function

    Public Shared Function CargarPorId_Embarazada(ByVal Id_Embarazada As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        RaiseEvent LoadingPersonasList("CargarPorId_Embarazada")
        dsDatos = PersonasDAL.CargarPorId_Embarazada(Id_Embarazada)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPersonasList(lista, "CargarPorId_Embarazada")
        Return lista
    End Function

    Public Shared Function CargarPorId_Grupo_Etnico(ByVal Id_Grupo_Etnico As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        RaiseEvent LoadingPersonasList("CargarPorId_Grupo_Etnico")
        dsDatos = PersonasDAL.CargarPorId_Grupo_Etnico(Id_Grupo_Etnico)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPersonasList(lista, "CargarPorId_Grupo_Etnico")
        Return lista
    End Function

    Public Shared Function CargarPorId_Lactando(ByVal Id_Lactando As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        RaiseEvent LoadingPersonasList("CargarPorId_Lactando")
        dsDatos = PersonasDAL.CargarPorId_Lactando(Id_Lactando)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPersonasList(lista, "CargarPorId_Lactando")
        Return lista
    End Function

    Public Shared Function CargarPorId_Paga_Matricula(ByVal Id_Paga_Matricula As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        RaiseEvent LoadingPersonasList("CargarPorId_Paga_Matricula")
        dsDatos = PersonasDAL.CargarPorId_Paga_Matricula(Id_Paga_Matricula)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPersonasList(lista, "CargarPorId_Paga_Matricula")
        Return lista
    End Function

    Public Shared Function CargarPorId_Problemas_Establecimiento(ByVal Id_Problemas_Establecimiento As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        RaiseEvent LoadingPersonasList("CargarPorId_Problemas_Establecimiento")
        dsDatos = PersonasDAL.CargarPorId_Problemas_Establecimiento(Id_Problemas_Establecimiento)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPersonasList(lista, "CargarPorId_Problemas_Establecimiento")
        Return lista
    End Function

    Public Shared Function CargarPorId_Recibio_Atencion_Psicologica(ByVal Id_Recibio_Atencion_Psicologica As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        RaiseEvent LoadingPersonasList("CargarPorId_Recibio_Atencion_Psicologica")
        dsDatos = PersonasDAL.CargarPorId_Recibio_Atencion_Psicologica(Id_Recibio_Atencion_Psicologica)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPersonasList(lista, "CargarPorId_Recibio_Atencion_Psicologica")
        Return lista
    End Function

    Public Shared Function CargarPorId_Recibio_Tratamiento(ByVal Id_Recibio_Tratamiento As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        RaiseEvent LoadingPersonasList("CargarPorId_Recibio_Tratamiento")
        dsDatos = PersonasDAL.CargarPorId_Recibio_Tratamiento(Id_Recibio_Tratamiento)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPersonasList(lista, "CargarPorId_Recibio_Tratamiento")
        Return lista
    End Function

    Public Shared Function CargarPorId_Sabe_Leer_Escribir(ByVal Id_Sabe_Leer_Escribir As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        RaiseEvent LoadingPersonasList("CargarPorId_Sabe_Leer_Escribir")
        dsDatos = PersonasDAL.CargarPorId_Sabe_Leer_Escribir(Id_Sabe_Leer_Escribir)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPersonasList(lista, "CargarPorId_Sabe_Leer_Escribir")
        Return lista
    End Function

    Public Shared Function CargarPorId_Solicito_Atencion_Psicologica(ByVal Id_Solicito_Atencion_Psicologica As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        RaiseEvent LoadingPersonasList("CargarPorId_Solicito_Atencion_Psicologica")
        dsDatos = PersonasDAL.CargarPorId_Solicito_Atencion_Psicologica(Id_Solicito_Atencion_Psicologica)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPersonasList(lista, "CargarPorId_Solicito_Atencion_Psicologica")
        Return lista
    End Function

    Public Shared Function CargarPorId_Tipo_Apoyo_Educativo(ByVal Id_Tipo_Apoyo_Educativo As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        RaiseEvent LoadingPersonasList("CargarPorId_Tipo_Apoyo_Educativo")
        dsDatos = PersonasDAL.CargarPorId_Tipo_Apoyo_Educativo(Id_Tipo_Apoyo_Educativo)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPersonasList(lista, "CargarPorId_Tipo_Apoyo_Educativo")
        Return lista
    End Function

    Public Shared Function CargarPorId_Tipo_Discapacidad(ByVal Id_Tipo_Discapacidad As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        RaiseEvent LoadingPersonasList("CargarPorId_Tipo_Discapacidad")
        dsDatos = PersonasDAL.CargarPorId_Tipo_Discapacidad(Id_Tipo_Discapacidad)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPersonasList(lista, "CargarPorId_Tipo_Discapacidad")
        Return lista
    End Function

    Public Shared Function CargarPorIdentificacion(ByVal tipo As Integer, ByVal identificacion As String) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        dsDatos = PersonasDAL.CargarPorIdentificacion(tipo, identificacion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorIdentificacionAtendidos(ByVal tipo As Integer, ByVal identificacion As String) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        dsDatos = PersonasDAL.CargarPorIdentificacionAtendidos(tipo, identificacion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorEdadNino() As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        dsDatos = PersonasDAL.CargarPorEdadNino()
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorSaludEdadNino(ByVal grupo As String, ByVal identificacion As String, ByVal nombre As String, ByVal regional As Integer, ByVal fecha_inicial As String, ByVal fecha_final As String, ByVal tipodeclaracion As Integer, ByVal Id_lugarEntrega As Int32, ByVal Id_programa As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        dsDatos = PersonasDAL.CargarPorSaludEdadNino(grupo, identificacion, nombre, regional, fecha_inicial, fecha_final, tipodeclaracion, Id_lugarEntrega, Id_programa)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_EmbarazadaBusqueda(ByVal id_embarazada As Integer, ByVal grupo As String, ByVal identificacion As String, ByVal nombre As String, ByVal regional As Integer, ByVal fecha_inicial As String, ByVal fecha_final As String, ByVal tipodeclaracion As Integer, ByVal regimen As Integer, ByVal lactando As Integer) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        dsDatos = PersonasDAL.CargarPorId_EmbarazadaBusqueda(id_embarazada, grupo, identificacion, nombre, regional, fecha_inicial, fecha_final, tipodeclaracion, regimen, lactando)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        dsDatos = PersonasDAL.CargarPorId_Usuario_Creacion(Id_Usuario_Creacion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        dsDatos = PersonasDAL.CargarPorId_Usuario_Modificacion(Id_Usuario_Modificacion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_Afectado_Desplazamiento(ByVal Id_Afectado_Desplazamiento As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        RaiseEvent LoadingPersonasList("CargarPorId_Afectado_Desplazamiento")
        dsDatos = PersonasDAL.CargarPorId_Afectado_Desplazamiento(Id_Afectado_Desplazamiento)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPersonasList(lista, "CargarPorId_Afectado_Desplazamiento")
        Return lista
    End Function

    Public Shared Function CargarPorIndicadores(ByVal id_Lugar_entrega As Int32, ByVal trimestrales As String, ByVal regionales As String, ByVal entregas As String, ByVal grupos As String, _
    ByVal fechadeclaracioninicial As String, ByVal fechadeclaracionfinal As String, ByVal fechadesplazamientoinicial As String, ByVal fechadesplazamientofinal As String, ByVal fechaatencioninicial As String, _
    ByVal fechaatencionfinal As String, ByVal accionsocial As Integer, ByVal atendido As Integer, ByVal motivonoatencion As Integer, ByVal departamento As Integer, ByVal municipio As Integer, ByVal concejo As Integer, _
     ByVal ninos5 As Integer, ByVal gestantes As Integer, ByVal ninos6y17 As Integer, ByVal estudia_actualmente As Integer, ByVal estudia_antes As Integer, ByVal wfecha_radicacion_inicial As String, ByVal wfecha_radicacion_final As String) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        dsDatos = PersonasDAL.CargarporIndicadores(id_Lugar_entrega, trimestrales, regionales, entregas, grupos, fechadeclaracioninicial, fechadeclaracionfinal, fechadesplazamientoinicial, fechadesplazamientofinal, _
        fechaatencioninicial, fechaatencionfinal, accionsocial, atendido, motivonoatencion, departamento, municipio, concejo, ninos5, gestantes, ninos6y17, estudia_actualmente, estudia_antes, wfecha_radicacion_inicial, wfecha_radicacion_final)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorFiltroEducacion(ByVal id_grupo As Int32, ByVal identificacion As String, ByVal nombre As String, ByVal id_regional As Integer, _
        ByVal fechaatencioninicial As String, ByVal fechaatencionfinal As String, ByVal wdeclarante As Integer, ByVal Id_LugarEntrega As Int32, ByVal chk_pendiente As Boolean) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        dsDatos = PersonasDAL.CargarPorFiltroEducacion(id_grupo, identificacion, nombre, id_regional, fechaatencioninicial, fechaatencionfinal, wdeclarante, Id_LugarEntrega, chk_pendiente)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorFiltroRegimenSalud(ByVal id_grupo As Int32, ByVal identificacion As String, ByVal nombre As String, ByVal id_regional As Integer, _
        ByVal fechaatencioninicial As String, ByVal fechaatencionfinal As String, ByVal wdeclarante As Integer, ByVal Id_LugarEntrega As Int32, ByVal chk_pendiente As Boolean) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        dsDatos = PersonasDAL.CargarPorFiltroRegimenSalud(id_grupo, identificacion, nombre, id_regional, fechaatencioninicial, fechaatencionfinal, wdeclarante, Id_LugarEntrega, chk_pendiente)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarBusqueda(ByVal id_grupo As Int32, ByVal lugarfuente As Int32, ByVal horario As String, ByVal declarante As Int32, ByVal regional As Int32, ByVal fechadeclaracioninicial As String, ByVal fechadeclaracionfinal As String, _
       ByVal fechadesplazamientoinicial As String, ByVal fechadesplazamientofinal As String, ByVal fechaatencioninicial As String, ByVal fechaatencionfinal As String, ByVal identificacion As String, ByVal nombre As String, ByVal fuente As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        dsDatos = PersonasDAL.CargarPorBusqueda(id_grupo, lugarfuente, horario, declarante, regional, fechadeclaracioninicial, fechadeclaracionfinal, fechadesplazamientoinicial, fechadesplazamientofinal, fechaatencioninicial, fechaatencionfinal, identificacion, nombre, fuente)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_Tipo_Miembro(ByVal Id_Tipo_Miembro As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        dsDatos = PersonasDAL.CargarPorId_Tipo_Miembro(Id_Tipo_Miembro)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_Estudia_Antes(ByVal Id_Estudia_Antes As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        RaiseEvent LoadingPersonasList("CargarPorId_Estudia_Antes")
        dsDatos = PersonasDAL.CargarPorId_Estudia_Antes(Id_Estudia_Antes)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPersonasList(lista, "CargarPorId_Estudia_Antes")
        Return lista
    End Function

    Public Shared Function CargarPorId_Certificado(ByVal Id_Certificado As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        dsDatos = PersonasDAL.CargarPorId_Certificado(Id_Certificado)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_Grupo(ByVal Id_Grupo As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        dsDatos = PersonasDAL.CargarPorId_Grupo(Id_Grupo)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_Programa_EntregaAdicional(ByVal Id_Programa As Int32) As List(Of PersonasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of PersonasBrl)
        dsDatos = PersonasDAL.CargarPorId_Programa_EntregaAdicional(Id_Programa)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function


End Class


