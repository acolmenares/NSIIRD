Imports ingNovar.Utilidades2
imports system.data
Imports system.collections.generic


Partial Public Class Declaracion_SeguimientosBrl

    Private _Id As Int32
    Private _Id_Declaracion As Int32
    Private _Id_Tipo_Entrega As Int32
    Private _Fecha As DateTime
    Private _Id_Oido_OVD As Int32
    Private _Id_Pertenece_OVD As Int32
    Private _Cual_OVD As String
    Private _Ingresos_Mensuales As Double
    Private _Id_Afectado_Desplazamiento As Int32
    Private _Id_Emociones As Int32
    Private _Id_Aliviado As Int32
    Private _Id_Comprender_Miedos As Int32
    Private _Id_Escuchado_Grupo As Int32
    Private _Id_Ayuda_Barrio As Int32
    Private _Id_Identificar_Habilidades As Int32
    Private _Id_Ayuda_Bienestar As Int32
    Private _Id_Relaciones_Familia As Int32
    Private _Id_Momentos_Dificiles As Int32
    Private _Id_Identificar_Organizaciones As Int32
    Private _Id_Identificar_Instituciones As Int32
    Private _Id_No_Sirvio As Int32
    Private _Id_Apoyo_Emocional As Int32
    Private _Id_Unidos As Int32
    Private _Municipio_Unidos As String
    Private _Id_Familias_Accion As Int32
    Private _Id_Alimentos_ICBF As Int32
    Private _Observaciones As String
    Private _Id_Solicitado_Atencion_Psicosocial As Int32
    Private _Municipio_Familias_Accion As String


    Private objListEntregas_Adicionales_Personas As List(Of Entregas_Adicionales_PersonasBrl)

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

    Public Event Id_Tipo_EntregaChanging(ByVal Value As Int32)
    Public Event Id_Tipo_EntregaChanged()
	
    Public Property Id_Tipo_Entrega() As Int32
        Get
            Return Me._Id_Tipo_Entrega
        End Get
        Set(ByVal Value As Int32)
            If _Id_Tipo_Entrega <> Value Then
                RaiseEvent Id_Tipo_EntregaChanging(Value)
				Me._Id_Tipo_Entrega = Value
                RaiseEvent Id_Tipo_EntregaChanged()
            End If
        End Set
    End Property

    Public Event FechaChanging(ByVal Value As DateTime)
    Public Event FechaChanged()
	
    Public Property Fecha() As DateTime
        Get
            Return Me._Fecha
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha <> Value Then
                RaiseEvent FechaChanging(Value)
				Me._Fecha = Value
                RaiseEvent FechaChanged()
            End If
        End Set
    End Property

    Public Event Id_Oido_OVDChanging(ByVal Value As Int32)
    Public Event Id_Oido_OVDChanged()
	
    Public Property Id_Oido_OVD() As Int32
        Get
            Return Me._Id_Oido_OVD
        End Get
        Set(ByVal Value As Int32)
            If _Id_Oido_OVD <> Value Then
                RaiseEvent Id_Oido_OVDChanging(Value)
				Me._Id_Oido_OVD = Value
                RaiseEvent Id_Oido_OVDChanged()
            End If
        End Set
    End Property

    Public Event Id_Pertenece_OVDChanging(ByVal Value As Int32)
    Public Event Id_Pertenece_OVDChanged()
	
    Public Property Id_Pertenece_OVD() As Int32
        Get
            Return Me._Id_Pertenece_OVD
        End Get
        Set(ByVal Value As Int32)
            If _Id_Pertenece_OVD <> Value Then
                RaiseEvent Id_Pertenece_OVDChanging(Value)
				Me._Id_Pertenece_OVD = Value
                RaiseEvent Id_Pertenece_OVDChanged()
            End If
        End Set
    End Property

    Public Event Cual_OVDChanging(ByVal Value As String)
    Public Event Cual_OVDChanged()
	
    Public Property Cual_OVD() As String
        Get
            Return Me._Cual_OVD
        End Get
        Set(ByVal Value As String)
            If _Cual_OVD <> Value Then
                RaiseEvent Cual_OVDChanging(Value)
				Me._Cual_OVD = Value
                RaiseEvent Cual_OVDChanged()
            End If
        End Set
    End Property

    Public Event Ingresos_MensualesChanging(ByVal Value As Double)
    Public Event Ingresos_MensualesChanged()
	
    Public Property Ingresos_Mensuales() As Double
        Get
            Return Me._Ingresos_Mensuales
        End Get
        Set(ByVal Value As Double)
            If _Ingresos_Mensuales <> Value Then
                RaiseEvent Ingresos_MensualesChanging(Value)
				Me._Ingresos_Mensuales = Value
                RaiseEvent Ingresos_MensualesChanged()
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

    Public Event Id_EmocionesChanging(ByVal Value As Int32)
    Public Event Id_EmocionesChanged()
	
    Public Property Id_Emociones() As Int32
        Get
            Return Me._Id_Emociones
        End Get
        Set(ByVal Value As Int32)
            If _Id_Emociones <> Value Then
                RaiseEvent Id_EmocionesChanging(Value)
				Me._Id_Emociones = Value
                RaiseEvent Id_EmocionesChanged()
            End If
        End Set
    End Property

    Public Event Id_AliviadoChanging(ByVal Value As Int32)
    Public Event Id_AliviadoChanged()
	
    Public Property Id_Aliviado() As Int32
        Get
            Return Me._Id_Aliviado
        End Get
        Set(ByVal Value As Int32)
            If _Id_Aliviado <> Value Then
                RaiseEvent Id_AliviadoChanging(Value)
				Me._Id_Aliviado = Value
                RaiseEvent Id_AliviadoChanged()
            End If
        End Set
    End Property

    Public Event Id_Comprender_MiedosChanging(ByVal Value As Int32)
    Public Event Id_Comprender_MiedosChanged()
	
    Public Property Id_Comprender_Miedos() As Int32
        Get
            Return Me._Id_Comprender_Miedos
        End Get
        Set(ByVal Value As Int32)
            If _Id_Comprender_Miedos <> Value Then
                RaiseEvent Id_Comprender_MiedosChanging(Value)
				Me._Id_Comprender_Miedos = Value
                RaiseEvent Id_Comprender_MiedosChanged()
            End If
        End Set
    End Property

    Public Event Id_Escuchado_GrupoChanging(ByVal Value As Int32)
    Public Event Id_Escuchado_GrupoChanged()
	
    Public Property Id_Escuchado_Grupo() As Int32
        Get
            Return Me._Id_Escuchado_Grupo
        End Get
        Set(ByVal Value As Int32)
            If _Id_Escuchado_Grupo <> Value Then
                RaiseEvent Id_Escuchado_GrupoChanging(Value)
				Me._Id_Escuchado_Grupo = Value
                RaiseEvent Id_Escuchado_GrupoChanged()
            End If
        End Set
    End Property

    Public Event Id_Ayuda_BarrioChanging(ByVal Value As Int32)
    Public Event Id_Ayuda_BarrioChanged()
	
    Public Property Id_Ayuda_Barrio() As Int32
        Get
            Return Me._Id_Ayuda_Barrio
        End Get
        Set(ByVal Value As Int32)
            If _Id_Ayuda_Barrio <> Value Then
                RaiseEvent Id_Ayuda_BarrioChanging(Value)
				Me._Id_Ayuda_Barrio = Value
                RaiseEvent Id_Ayuda_BarrioChanged()
            End If
        End Set
    End Property

    Public Event Id_Identificar_HabilidadesChanging(ByVal Value As Int32)
    Public Event Id_Identificar_HabilidadesChanged()
	
    Public Property Id_Identificar_Habilidades() As Int32
        Get
            Return Me._Id_Identificar_Habilidades
        End Get
        Set(ByVal Value As Int32)
            If _Id_Identificar_Habilidades <> Value Then
                RaiseEvent Id_Identificar_HabilidadesChanging(Value)
				Me._Id_Identificar_Habilidades = Value
                RaiseEvent Id_Identificar_HabilidadesChanged()
            End If
        End Set
    End Property

    Public Event Id_Ayuda_BienestarChanging(ByVal Value As Int32)
    Public Event Id_Ayuda_BienestarChanged()
	
    Public Property Id_Ayuda_Bienestar() As Int32
        Get
            Return Me._Id_Ayuda_Bienestar
        End Get
        Set(ByVal Value As Int32)
            If _Id_Ayuda_Bienestar <> Value Then
                RaiseEvent Id_Ayuda_BienestarChanging(Value)
				Me._Id_Ayuda_Bienestar = Value
                RaiseEvent Id_Ayuda_BienestarChanged()
            End If
        End Set
    End Property

    Public Event Id_Relaciones_FamiliaChanging(ByVal Value As Int32)
    Public Event Id_Relaciones_FamiliaChanged()
	
    Public Property Id_Relaciones_Familia() As Int32
        Get
            Return Me._Id_Relaciones_Familia
        End Get
        Set(ByVal Value As Int32)
            If _Id_Relaciones_Familia <> Value Then
                RaiseEvent Id_Relaciones_FamiliaChanging(Value)
				Me._Id_Relaciones_Familia = Value
                RaiseEvent Id_Relaciones_FamiliaChanged()
            End If
        End Set
    End Property

    Public Event Id_Momentos_DificilesChanging(ByVal Value As Int32)
    Public Event Id_Momentos_DificilesChanged()
	
    Public Property Id_Momentos_Dificiles() As Int32
        Get
            Return Me._Id_Momentos_Dificiles
        End Get
        Set(ByVal Value As Int32)
            If _Id_Momentos_Dificiles <> Value Then
                RaiseEvent Id_Momentos_DificilesChanging(Value)
				Me._Id_Momentos_Dificiles = Value
                RaiseEvent Id_Momentos_DificilesChanged()
            End If
        End Set
    End Property

    Public Event Id_Identificar_OrganizacionesChanging(ByVal Value As Int32)
    Public Event Id_Identificar_OrganizacionesChanged()
	
    Public Property Id_Identificar_Organizaciones() As Int32
        Get
            Return Me._Id_Identificar_Organizaciones
        End Get
        Set(ByVal Value As Int32)
            If _Id_Identificar_Organizaciones <> Value Then
                RaiseEvent Id_Identificar_OrganizacionesChanging(Value)
				Me._Id_Identificar_Organizaciones = Value
                RaiseEvent Id_Identificar_OrganizacionesChanged()
            End If
        End Set
    End Property

    Public Event Id_Identificar_InstitucionesChanging(ByVal Value As Int32)
    Public Event Id_Identificar_InstitucionesChanged()
	
    Public Property Id_Identificar_Instituciones() As Int32
        Get
            Return Me._Id_Identificar_Instituciones
        End Get
        Set(ByVal Value As Int32)
            If _Id_Identificar_Instituciones <> Value Then
                RaiseEvent Id_Identificar_InstitucionesChanging(Value)
				Me._Id_Identificar_Instituciones = Value
                RaiseEvent Id_Identificar_InstitucionesChanged()
            End If
        End Set
    End Property

    Public Event Id_No_SirvioChanging(ByVal Value As Int32)
    Public Event Id_No_SirvioChanged()
	
    Public Property Id_No_Sirvio() As Int32
        Get
            Return Me._Id_No_Sirvio
        End Get
        Set(ByVal Value As Int32)
            If _Id_No_Sirvio <> Value Then
                RaiseEvent Id_No_SirvioChanging(Value)
				Me._Id_No_Sirvio = Value
                RaiseEvent Id_No_SirvioChanged()
            End If
        End Set
    End Property

    Public Event Id_Apoyo_EmocionalChanging(ByVal Value As Int32)
    Public Event Id_Apoyo_EmocionalChanged()
	
    Public Property Id_Apoyo_Emocional() As Int32
        Get
            Return Me._Id_Apoyo_Emocional
        End Get
        Set(ByVal Value As Int32)
            If _Id_Apoyo_Emocional <> Value Then
                RaiseEvent Id_Apoyo_EmocionalChanging(Value)
				Me._Id_Apoyo_Emocional = Value
                RaiseEvent Id_Apoyo_EmocionalChanged()
            End If
        End Set
    End Property

    Public Event Id_UnidosChanging(ByVal Value As Int32)
    Public Event Id_UnidosChanged()
	
    Public Property Id_Unidos() As Int32
        Get
            Return Me._Id_Unidos
        End Get
        Set(ByVal Value As Int32)
            If _Id_Unidos <> Value Then
                RaiseEvent Id_UnidosChanging(Value)
				Me._Id_Unidos = Value
                RaiseEvent Id_UnidosChanged()
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

    Public Event Id_Alimentos_ICBFChanging(ByVal Value As Int32)
    Public Event Id_Alimentos_ICBFChanged()
	
    Public Property Id_Alimentos_ICBF() As Int32
        Get
            Return Me._Id_Alimentos_ICBF
        End Get
        Set(ByVal Value As Int32)
            If _Id_Alimentos_ICBF <> Value Then
                RaiseEvent Id_Alimentos_ICBFChanging(Value)
				Me._Id_Alimentos_ICBF = Value
                RaiseEvent Id_Alimentos_ICBFChanged()
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

    Public Event Id_Solicitado_Atencion_PsicosocialChanging(ByVal Value As Int32)
    Public Event Id_Solicitado_Atencion_PsicosocialChanged()

    Public Property Id_Solicitado_Atencion_Psicosocial() As Int32
        Get
            Return Me._Id_Solicitado_Atencion_Psicosocial
        End Get
        Set(ByVal Value As Int32)
            If _Id_Solicitado_Atencion_Psicosocial <> Value Then
                RaiseEvent Id_Solicitado_Atencion_PsicosocialChanging(Value)
                Me._Id_Solicitado_Atencion_Psicosocial = Value
                RaiseEvent Id_Solicitado_Atencion_PsicosocialChanged()
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


    Public Property Entregas_Adicionales_Personas() As List(Of Entregas_Adicionales_PersonasBrl)
        Get
            If (Me.objListEntregas_Adicionales_Personas Is Nothing) Then
                objListEntregas_Adicionales_Personas = Entregas_Adicionales_PersonasBrl.CargarPorId_Declaracion_Seguimiento(Me.ID)
            End If
            Return Me.objListEntregas_Adicionales_Personas
        End Get
        Set(ByVal Value As List(Of Entregas_Adicionales_PersonasBrl))
            Me.objListEntregas_Adicionales_Personas = Value
        End Set
    End Property


    Public ReadOnly Property Afectado_Desplazamiento() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Afectado_Desplazamiento)
        End Get
    End Property

    Public ReadOnly Property Alimentos_ICBF() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Alimentos_ICBF)
        End Get
    End Property

    Public ReadOnly Property Aliviado() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Aliviado)
        End Get
    End Property

    Public ReadOnly Property Apoyo_Emocional() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Apoyo_Emocional)
        End Get
    End Property

    Public ReadOnly Property Ayuda_Barrio() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Ayuda_Barrio)
        End Get
    End Property

    Public ReadOnly Property Ayuda_Bienestar() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Ayuda_Bienestar)
        End Get
    End Property

    Public ReadOnly Property Comprender_Miedos() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Comprender_Miedos)
        End Get
    End Property

    Public Readonly Property Declaracion() As DeclaracionBrl
        Get
            Return DeclaracionBrl.CargarPorID(Id_Declaracion)
        End Get
    End Property

    Public ReadOnly Property Emociones() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Emociones)
        End Get
    End Property

    Public ReadOnly Property Escuchado_Grupo() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Escuchado_Grupo)
        End Get
    End Property

    Public ReadOnly Property Familias_Accion() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Familias_Accion)
        End Get
    End Property

    Public ReadOnly Property Identificar_Habilidades() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Identificar_Habilidades)
        End Get
    End Property

    Public ReadOnly Property Identificar_Instituciones() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Identificar_Instituciones)
        End Get
    End Property

    Public ReadOnly Property Identificar_Organizaciones() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Identificar_Organizaciones)
        End Get
    End Property

    Public ReadOnly Property Momentos_Dificiles() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Momentos_Dificiles)
        End Get
    End Property

    Public ReadOnly Property No_Sirvio() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_No_Sirvio)
        End Get
    End Property

    Public ReadOnly Property Oido_OVD() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Oido_OVD)
        End Get
    End Property

    Public ReadOnly Property Pertenece_OVD() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Pertenece_OVD)
        End Get
    End Property

    Public ReadOnly Property Relaciones_Familia() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Relaciones_Familia)
        End Get
    End Property

    Public ReadOnly Property Tipo_Entrega() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Tipo_Entrega)
        End Get
    End Property

    Public ReadOnly Property Unidos() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Unidos)
        End Get
    End Property

    Public ReadOnly Property Atencion_Psicosocial() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Solicitado_Atencion_Psicosocial)
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
            Me.ID = Declaracion_SeguimientosDAL.Insertar(Id_Declaracion, Id_Tipo_Entrega, Fecha, Id_Oido_OVD, Id_Pertenece_OVD, Cual_OVD, Ingresos_Mensuales, Id_Afectado_Desplazamiento, Id_Emociones, Id_Aliviado, Id_Comprender_Miedos, Id_Escuchado_Grupo, Id_Ayuda_Barrio, Id_Identificar_Habilidades, Id_Ayuda_Bienestar, Id_Relaciones_Familia, Id_Momentos_Dificiles, Id_Identificar_Organizaciones, Id_Identificar_Instituciones, Id_No_Sirvio, Id_Apoyo_Emocional, Id_Unidos, Municipio_Unidos, Id_Familias_Accion, Id_Alimentos_ICBF, Observaciones, Id_Solicitado_Atencion_Psicosocial, Municipio_Familias_Accion)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            Declaracion_SeguimientosDAL.Actualizar(ID, Id_Declaracion, Id_Tipo_Entrega, Fecha, Id_Oido_OVD, Id_Pertenece_OVD, Cual_OVD, Ingresos_Mensuales, Id_Afectado_Desplazamiento, Id_Emociones, Id_Aliviado, Id_Comprender_Miedos, Id_Escuchado_Grupo, Id_Ayuda_Barrio, Id_Identificar_Habilidades, Id_Ayuda_Bienestar, Id_Relaciones_Familia, Id_Momentos_Dificiles, Id_Identificar_Organizaciones, Id_Identificar_Instituciones, Id_No_Sirvio, Id_Apoyo_Emocional, Id_Unidos, Municipio_Unidos, Id_Familias_Accion, Id_Alimentos_ICBF, Observaciones, Id_Solicitado_Atencion_Psicosocial, Municipio_Familias_Accion)
            RaiseEvent Updated()
        End If


        If Not objListEntregas_Adicionales_Personas Is Nothing Then
            For Each fila As Entregas_Adicionales_PersonasBrl In objListEntregas_Adicionales_Personas
                fila.Id_Declaracion_Seguimiento = Me.ID
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
            totalHijos += objListEntregas_Adicionales_Personas.Count

            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            
			Declaracion_SeguimientosDAL.Eliminar(Me.ID)
			
            RaiseEvent Deleted()
            
        End If
	End Sub

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Declaracion_SeguimientosBrl
		
		Dim objDeclaracion_Seguimientos As New Declaracion_SeguimientosBrl
		
		With objDeclaracion_Seguimientos
			.ID = fila("Id")
			.Id_Declaracion = isDBNullToNothing(fila("Id_Declaracion"))
			.Id_Tipo_Entrega = isDBNullToNothing(fila("Id_Tipo_Entrega"))
			.Fecha = isDBNullToNothing(fila("Fecha"))
			.Id_Oido_OVD = isDBNullToNothing(fila("Id_Oido_OVD"))
			.Id_Pertenece_OVD = isDBNullToNothing(fila("Id_Pertenece_OVD"))
			.Cual_OVD = isDBNullToNothing(fila("Cual_OVD"))
			.Ingresos_Mensuales = isDBNullToNothing(fila("Ingresos_Mensuales"))
			.Id_Afectado_Desplazamiento = isDBNullToNothing(fila("Id_Afectado_Desplazamiento"))
			.Id_Emociones = isDBNullToNothing(fila("Id_Emociones"))
			.Id_Aliviado = isDBNullToNothing(fila("Id_Aliviado"))
			.Id_Comprender_Miedos = isDBNullToNothing(fila("Id_Comprender_Miedos"))
			.Id_Escuchado_Grupo = isDBNullToNothing(fila("Id_Escuchado_Grupo"))
			.Id_Ayuda_Barrio = isDBNullToNothing(fila("Id_Ayuda_Barrio"))
			.Id_Identificar_Habilidades = isDBNullToNothing(fila("Id_Identificar_Habilidades"))
			.Id_Ayuda_Bienestar = isDBNullToNothing(fila("Id_Ayuda_Bienestar"))
			.Id_Relaciones_Familia = isDBNullToNothing(fila("Id_Relaciones_Familia"))
			.Id_Momentos_Dificiles = isDBNullToNothing(fila("Id_Momentos_Dificiles"))
			.Id_Identificar_Organizaciones = isDBNullToNothing(fila("Id_Identificar_Organizaciones"))
			.Id_Identificar_Instituciones = isDBNullToNothing(fila("Id_Identificar_Instituciones"))
			.Id_No_Sirvio = isDBNullToNothing(fila("Id_No_Sirvio"))
			.Id_Apoyo_Emocional = isDBNullToNothing(fila("Id_Apoyo_Emocional"))
			.Id_Unidos = isDBNullToNothing(fila("Id_Unidos"))
			.Municipio_Unidos = isDBNullToNothing(fila("Municipio_Unidos"))
			.Id_Familias_Accion = isDBNullToNothing(fila("Id_Familias_Accion"))
			.Id_Alimentos_ICBF = isDBNullToNothing(fila("Id_Alimentos_ICBF"))
            .Observaciones = isDBNullToNothing(fila("Observaciones"))
            .Id_Solicitado_Atencion_Psicosocial = isDBNullToNothing(fila("Id_Solicitado_Atencion_Psicosocial"))
            .Municipio_Familias_Accion = isDBNullToNothing(fila("Municipio_Familias_Accion"))


		End With
		
		Return objDeclaracion_Seguimientos
		
    End Function
	
	Public Shared Event LoadingDeclaracion_SeguimientosList(ByVal LoadType As String)
	Public Shared Event LoadedDeclaracion_SeguimientosList(target As List(Of Declaracion_SeguimientosBrl), ByVal LoadType As String)
	
	Public Shared Function CargarTodos() As List(Of Declaracion_SeguimientosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_SeguimientosBrl)
	
		RaiseEvent LoadingDeclaracion_SeguimientosList("CargarTodos")
	
		dsDatos = Declaracion_SeguimientosDAL.CargarTodos()

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_SeguimientosList(lista, "CargarTodos")
        
        Return lista
        
    End Function

	Public Shared Event CargandoPorId(ByVal id As Int32)
    Public Shared Event CargadoPorId(ByVal target As Declaracion_SeguimientosBrl)

	Public Shared Function CargarPorID(ID As Int32) As Declaracion_SeguimientosBrl

		Dim dsDatos As System.Data.DataSet
		Dim objDeclaracion_Seguimientos As Declaracion_SeguimientosBrl = Nothing 
		
        dsDatos = Declaracion_SeguimientosDAL.CargarPorID(ID)
		
		If dsDatos.Tables(0).Rows.Count <> 0 Then objDeclaracion_Seguimientos = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))

        Return objDeclaracion_Seguimientos
        
    End Function

	Public Shared Function CargarPorId_Afectado_Desplazamiento(ByVal Id_Afectado_Desplazamiento As Int32) As List(Of Declaracion_SeguimientosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_SeguimientosBrl)
	
		RaiseEvent LoadingDeclaracion_SeguimientosList("CargarPorId_Afectado_Desplazamiento")
		
		dsDatos = Declaracion_SeguimientosDAL.CargarPorId_Afectado_Desplazamiento(Id_Afectado_Desplazamiento)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_SeguimientosList(lista, "CargarPorId_Afectado_Desplazamiento")
        
        Return lista
        
	End Function

    Public Shared Function CargarPorId_Alimentos_ICBF(ByVal Id_Alimentos_ICBF As Int32) As List(Of Declaracion_SeguimientosBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Declaracion_SeguimientosBrl)

        RaiseEvent LoadingDeclaracion_SeguimientosList("CargarPorId_Alimentos_ICBF")

        dsDatos = Declaracion_SeguimientosDAL.CargarPorId_Alimentos_ICBF(Id_Alimentos_ICBF)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracion_SeguimientosList(lista, "CargarPorId_Alimentos_ICBF")

        Return lista

    End Function

    Public Shared Function CargarPorId_Aliviado(ByVal Id_Aliviado As Int32) As List(Of Declaracion_SeguimientosBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Declaracion_SeguimientosBrl)

        RaiseEvent LoadingDeclaracion_SeguimientosList("CargarPorId_Aliviado")

        dsDatos = Declaracion_SeguimientosDAL.CargarPorId_Aliviado(Id_Aliviado)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracion_SeguimientosList(lista, "CargarPorId_Aliviado")

        Return lista

    End Function

	Public Shared Function CargarPorId_Apoyo_Emocional(ByVal Id_Apoyo_Emocional As Int32) As List(Of Declaracion_SeguimientosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_SeguimientosBrl)
	
		RaiseEvent LoadingDeclaracion_SeguimientosList("CargarPorId_Apoyo_Emocional")
		
		dsDatos = Declaracion_SeguimientosDAL.CargarPorId_Apoyo_Emocional(Id_Apoyo_Emocional)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_SeguimientosList(lista, "CargarPorId_Apoyo_Emocional")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Ayuda_Barrio(ByVal Id_Ayuda_Barrio As Int32) As List(Of Declaracion_SeguimientosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_SeguimientosBrl)
	
		RaiseEvent LoadingDeclaracion_SeguimientosList("CargarPorId_Ayuda_Barrio")
		
		dsDatos = Declaracion_SeguimientosDAL.CargarPorId_Ayuda_Barrio(Id_Ayuda_Barrio)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_SeguimientosList(lista, "CargarPorId_Ayuda_Barrio")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Ayuda_Bienestar(ByVal Id_Ayuda_Bienestar As Int32) As List(Of Declaracion_SeguimientosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_SeguimientosBrl)
	
		RaiseEvent LoadingDeclaracion_SeguimientosList("CargarPorId_Ayuda_Bienestar")
		
		dsDatos = Declaracion_SeguimientosDAL.CargarPorId_Ayuda_Bienestar(Id_Ayuda_Bienestar)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_SeguimientosList(lista, "CargarPorId_Ayuda_Bienestar")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Comprender_Miedos(ByVal Id_Comprender_Miedos As Int32) As List(Of Declaracion_SeguimientosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_SeguimientosBrl)
	
		RaiseEvent LoadingDeclaracion_SeguimientosList("CargarPorId_Comprender_Miedos")
		
		dsDatos = Declaracion_SeguimientosDAL.CargarPorId_Comprender_Miedos(Id_Comprender_Miedos)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_SeguimientosList(lista, "CargarPorId_Comprender_Miedos")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Declaracion(ByVal Id_Declaracion As Int32) As List(Of Declaracion_SeguimientosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_SeguimientosBrl)
	
		RaiseEvent LoadingDeclaracion_SeguimientosList("CargarPorId_Declaracion")
		
		dsDatos = Declaracion_SeguimientosDAL.CargarPorId_Declaracion(Id_Declaracion)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_SeguimientosList(lista, "CargarPorId_Declaracion")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Emociones(ByVal Id_Emociones As Int32) As List(Of Declaracion_SeguimientosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_SeguimientosBrl)
	
		RaiseEvent LoadingDeclaracion_SeguimientosList("CargarPorId_Emociones")
		
		dsDatos = Declaracion_SeguimientosDAL.CargarPorId_Emociones(Id_Emociones)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_SeguimientosList(lista, "CargarPorId_Emociones")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Escuchado_Grupo(ByVal Id_Escuchado_Grupo As Int32) As List(Of Declaracion_SeguimientosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_SeguimientosBrl)
	
		RaiseEvent LoadingDeclaracion_SeguimientosList("CargarPorId_Escuchado_Grupo")
		
		dsDatos = Declaracion_SeguimientosDAL.CargarPorId_Escuchado_Grupo(Id_Escuchado_Grupo)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_SeguimientosList(lista, "CargarPorId_Escuchado_Grupo")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Familias_Accion(ByVal Id_Familias_Accion As Int32) As List(Of Declaracion_SeguimientosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_SeguimientosBrl)
	
		RaiseEvent LoadingDeclaracion_SeguimientosList("CargarPorId_Familias_Accion")
		
		dsDatos = Declaracion_SeguimientosDAL.CargarPorId_Familias_Accion(Id_Familias_Accion)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_SeguimientosList(lista, "CargarPorId_Familias_Accion")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Identificar_Habilidades(ByVal Id_Identificar_Habilidades As Int32) As List(Of Declaracion_SeguimientosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_SeguimientosBrl)
	
		RaiseEvent LoadingDeclaracion_SeguimientosList("CargarPorId_Identificar_Habilidades")
		
		dsDatos = Declaracion_SeguimientosDAL.CargarPorId_Identificar_Habilidades(Id_Identificar_Habilidades)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_SeguimientosList(lista, "CargarPorId_Identificar_Habilidades")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Identificar_Instituciones(ByVal Id_Identificar_Instituciones As Int32) As List(Of Declaracion_SeguimientosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_SeguimientosBrl)
	
		RaiseEvent LoadingDeclaracion_SeguimientosList("CargarPorId_Identificar_Instituciones")
		
		dsDatos = Declaracion_SeguimientosDAL.CargarPorId_Identificar_Instituciones(Id_Identificar_Instituciones)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_SeguimientosList(lista, "CargarPorId_Identificar_Instituciones")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Identificar_Organizaciones(ByVal Id_Identificar_Organizaciones As Int32) As List(Of Declaracion_SeguimientosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_SeguimientosBrl)
	
		RaiseEvent LoadingDeclaracion_SeguimientosList("CargarPorId_Identificar_Organizaciones")
		
		dsDatos = Declaracion_SeguimientosDAL.CargarPorId_Identificar_Organizaciones(Id_Identificar_Organizaciones)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_SeguimientosList(lista, "CargarPorId_Identificar_Organizaciones")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Momentos_Dificiles(ByVal Id_Momentos_Dificiles As Int32) As List(Of Declaracion_SeguimientosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_SeguimientosBrl)
	
		RaiseEvent LoadingDeclaracion_SeguimientosList("CargarPorId_Momentos_Dificiles")
		
		dsDatos = Declaracion_SeguimientosDAL.CargarPorId_Momentos_Dificiles(Id_Momentos_Dificiles)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_SeguimientosList(lista, "CargarPorId_Momentos_Dificiles")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_No_Sirvio(ByVal Id_No_Sirvio As Int32) As List(Of Declaracion_SeguimientosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_SeguimientosBrl)
	
		RaiseEvent LoadingDeclaracion_SeguimientosList("CargarPorId_No_Sirvio")
		
		dsDatos = Declaracion_SeguimientosDAL.CargarPorId_No_Sirvio(Id_No_Sirvio)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_SeguimientosList(lista, "CargarPorId_No_Sirvio")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Oido_OVD(ByVal Id_Oido_OVD As Int32) As List(Of Declaracion_SeguimientosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_SeguimientosBrl)
	
		RaiseEvent LoadingDeclaracion_SeguimientosList("CargarPorId_Oido_OVD")
		
		dsDatos = Declaracion_SeguimientosDAL.CargarPorId_Oido_OVD(Id_Oido_OVD)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_SeguimientosList(lista, "CargarPorId_Oido_OVD")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Pertenece_OVD(ByVal Id_Pertenece_OVD As Int32) As List(Of Declaracion_SeguimientosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_SeguimientosBrl)
	
		RaiseEvent LoadingDeclaracion_SeguimientosList("CargarPorId_Pertenece_OVD")
		
		dsDatos = Declaracion_SeguimientosDAL.CargarPorId_Pertenece_OVD(Id_Pertenece_OVD)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_SeguimientosList(lista, "CargarPorId_Pertenece_OVD")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Relaciones_Familia(ByVal Id_Relaciones_Familia As Int32) As List(Of Declaracion_SeguimientosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_SeguimientosBrl)
	
		RaiseEvent LoadingDeclaracion_SeguimientosList("CargarPorId_Relaciones_Familia")
		
		dsDatos = Declaracion_SeguimientosDAL.CargarPorId_Relaciones_Familia(Id_Relaciones_Familia)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_SeguimientosList(lista, "CargarPorId_Relaciones_Familia")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Tipo_Entrega(ByVal Id_Tipo_Entrega As Int32) As List(Of Declaracion_SeguimientosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_SeguimientosBrl)
	
		RaiseEvent LoadingDeclaracion_SeguimientosList("CargarPorId_Tipo_Entrega")
		
		dsDatos = Declaracion_SeguimientosDAL.CargarPorId_Tipo_Entrega(Id_Tipo_Entrega)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_SeguimientosList(lista, "CargarPorId_Tipo_Entrega")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Unidos(ByVal Id_Unidos As Int32) As List(Of Declaracion_SeguimientosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_SeguimientosBrl)
	
		RaiseEvent LoadingDeclaracion_SeguimientosList("CargarPorId_Unidos")
		
		dsDatos = Declaracion_SeguimientosDAL.CargarPorId_Unidos(Id_Unidos)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_SeguimientosList(lista, "CargarPorId_Unidos")
        
        Return lista
        
	End Function



End Class


