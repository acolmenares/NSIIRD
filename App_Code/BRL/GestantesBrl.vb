Imports ingNovar.Utilidades2
Imports System.Data
Imports System.Collections.Generic
Imports SeguridadUsuarios

Partial Public Class GestantesBrl

    Private _Id As Int32
    Private _Id_Persona As Int32
    Private _Id_Control_Prenatal As Int32
    Private _Unidad_Basica_Atencion As String
    Private _Id_Ingesta_Micronutrientes As Int32
    Private _Enfermedades As String
    Private _Semanas_Gestacion As Int32
    Private _Id_Remitidas As Int32
    Private _Fecha_Remision As DateTime
    Private _Id_Visita_Domiciliaria As Int32
    Private _Fecha_Visita As DateTime
    Private _Observaciones As String
    Private _Fecha_Control_Prenatal As DateTime
    Private _Observaciones_Visita As String
    Private _Peso As Int32
    Private _Talla As Int32
    Private _IMC As Int32
    Private _Estado_Nutricional As String
    Private _Fecha_Creacion As DateTime
    Private _Id_Usuario_Creacion As Int32
    Private _Fecha_Modificacion As DateTime
    Private _Id_Usuario_Modificacion As Int32
    Private _Fecha_Cierre As DateTime
    Private _Cierre As Boolean

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

    Public Event Id_PersonaChanging(ByVal Value As Int32)
    Public Event Id_PersonaChanged()
	
    Public Property Id_Persona() As Int32
        Get
            Return Me._Id_Persona
        End Get
        Set(ByVal Value As Int32)
            If _Id_Persona <> Value Then
                RaiseEvent Id_PersonaChanging(Value)
				Me._Id_Persona = Value
                RaiseEvent Id_PersonaChanged()
            End If
        End Set
    End Property

    Public Event Id_Control_PrenatalChanging(ByVal Value As Int32)
    Public Event Id_Control_PrenatalChanged()
	
    Public Property Id_Control_Prenatal() As Int32
        Get
            Return Me._Id_Control_Prenatal
        End Get
        Set(ByVal Value As Int32)
            If _Id_Control_Prenatal <> Value Then
                RaiseEvent Id_Control_PrenatalChanging(Value)
				Me._Id_Control_Prenatal = Value
                RaiseEvent Id_Control_PrenatalChanged()
            End If
        End Set
    End Property

    Public Event Unidad_Basica_AtencionChanging(ByVal Value As String)
    Public Event Unidad_Basica_AtencionChanged()
	
    Public Property Unidad_Basica_Atencion() As String
        Get
            Return Me._Unidad_Basica_Atencion
        End Get
        Set(ByVal Value As String)
            If _Unidad_Basica_Atencion <> Value Then
                RaiseEvent Unidad_Basica_AtencionChanging(Value)
				Me._Unidad_Basica_Atencion = Value
                RaiseEvent Unidad_Basica_AtencionChanged()
            End If
        End Set
    End Property

    Public Event Id_Ingesta_MicronutrientesChanging(ByVal Value As Int32)
    Public Event Id_Ingesta_MicronutrientesChanged()
	
    Public Property Id_Ingesta_Micronutrientes() As Int32
        Get
            Return Me._Id_Ingesta_Micronutrientes
        End Get
        Set(ByVal Value As Int32)
            If _Id_Ingesta_Micronutrientes <> Value Then
                RaiseEvent Id_Ingesta_MicronutrientesChanging(Value)
				Me._Id_Ingesta_Micronutrientes = Value
                RaiseEvent Id_Ingesta_MicronutrientesChanged()
            End If
        End Set
    End Property

    Public Event EnfermedadesChanging(ByVal Value As String)
    Public Event EnfermedadesChanged()
	
    Public Property Enfermedades() As String
        Get
            Return Me._Enfermedades
        End Get
        Set(ByVal Value As String)
            If _Enfermedades <> Value Then
                RaiseEvent EnfermedadesChanging(Value)
				Me._Enfermedades = Value
                RaiseEvent EnfermedadesChanged()
            End If
        End Set
    End Property

    Public Event Semanas_GestacionChanging(ByVal Value As Int32)
    Public Event Semanas_GestacionChanged()
	
    Public Property Semanas_Gestacion() As Int32
        Get
            Return Me._Semanas_Gestacion
        End Get
        Set(ByVal Value As Int32)
            If _Semanas_Gestacion <> Value Then
                RaiseEvent Semanas_GestacionChanging(Value)
				Me._Semanas_Gestacion = Value
                RaiseEvent Semanas_GestacionChanged()
            End If
        End Set
    End Property

    Public Event Id_RemitidasChanging(ByVal Value As Int32)
    Public Event Id_RemitidasChanged()
	
    Public Property Id_Remitidas() As Int32
        Get
            Return Me._Id_Remitidas
        End Get
        Set(ByVal Value As Int32)
            If _Id_Remitidas <> Value Then
                RaiseEvent Id_RemitidasChanging(Value)
				Me._Id_Remitidas = Value
                RaiseEvent Id_RemitidasChanged()
            End If
        End Set
    End Property

    Public Event Fecha_RemisionChanging(ByVal Value As DateTime)
    Public Event Fecha_RemisionChanged()
	
    Public Property Fecha_Remision() As DateTime
        Get
            Return Me._Fecha_Remision
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_Remision <> Value Then
                RaiseEvent Fecha_RemisionChanging(Value)
				Me._Fecha_Remision = Value
                RaiseEvent Fecha_RemisionChanged()
            End If
        End Set
    End Property

    Public Event Id_Visita_DomiciliariaChanging(ByVal Value As Int32)
    Public Event Id_Visita_DomiciliariaChanged()
	
    Public Property Id_Visita_Domiciliaria() As Int32
        Get
            Return Me._Id_Visita_Domiciliaria
        End Get
        Set(ByVal Value As Int32)
            If _Id_Visita_Domiciliaria <> Value Then
                RaiseEvent Id_Visita_DomiciliariaChanging(Value)
				Me._Id_Visita_Domiciliaria = Value
                RaiseEvent Id_Visita_DomiciliariaChanged()
            End If
        End Set
    End Property

    Public Event Fecha_VisitaChanging(ByVal Value As DateTime)
    Public Event Fecha_VisitaChanged()
	
    Public Property Fecha_Visita() As DateTime
        Get
            Return Me._Fecha_Visita
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_Visita <> Value Then
                RaiseEvent Fecha_VisitaChanging(Value)
				Me._Fecha_Visita = Value
                RaiseEvent Fecha_VisitaChanged()
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

    Public Event Fecha_Control_PrenatalChanging(ByVal Value As DateTime)
    Public Event Fecha_Control_PrenatalChanged()

    Public Property Fecha_Control_Prenatal() As DateTime
        Get
            Return Me._Fecha_Control_Prenatal
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_Control_Prenatal <> Value Then
                RaiseEvent Fecha_Control_PrenatalChanging(Value)
                Me._Fecha_Control_Prenatal = Value
                RaiseEvent Fecha_Control_PrenatalChanged()
            End If
        End Set
    End Property

    Public Event Observaciones_visitaChanging(ByVal Value As String)
    Public Event Observaciones_VisitaChanged()

    Public Property Observaciones_Visita() As String
        Get
            Return Me._Observaciones_Visita
        End Get
        Set(ByVal Value As String)
            If _Observaciones_Visita <> Value Then
                RaiseEvent Observaciones_visitaChanging(Value)
                Me._Observaciones_Visita = Value
                RaiseEvent Observaciones_VisitaChanged()
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

    Public Event PesoChanging(ByVal Value As Double)
    Public Event PesoChanged()

    Public Property Peso() As Double
        Get
            Return Me._Peso
        End Get
        Set(ByVal Value As Double)
            If _Peso <> Value Then
                RaiseEvent PesoChanging(Value)
                Me._Peso = Value
                RaiseEvent PesoChanged()
            End If
        End Set
    End Property

    Public Event TallaChanging(ByVal Value As Double)
    Public Event TallaChanged()

    Public Property Talla() As Double
        Get
            Return Me._Talla
        End Get
        Set(ByVal Value As Double)
            If _Talla <> Value Then
                RaiseEvent TallaChanging(Value)
                Me._Talla = Value
                RaiseEvent TallaChanged()
            End If
        End Set
    End Property

    Public Event IMCChanging(ByVal Value As Double)
    Public Event IMCChanged()

    Public Property IMC() As Double
        Get
            Return Me._IMC
        End Get
        Set(ByVal Value As Double)
            If _IMC <> Value Then
                RaiseEvent IMCChanging(Value)
                Me._IMC = Value
                RaiseEvent IMCChanged()
            End If
        End Set
    End Property

    Public Event Estado_NutricionalChanging(ByVal Value As String)
    Public Event Estado_NutricionalChanged()

    Public Property Estado_Nutricional() As String
        Get
            Return Me._Estado_Nutricional
        End Get
        Set(ByVal Value As String)
            If _Estado_Nutricional <> Value Then
                RaiseEvent Estado_NutricionalChanging(Value)
                Me._Estado_Nutricional = Value
                RaiseEvent Estado_NutricionalChanged()
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

    Public ReadOnly Property Control_prenatal() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Control_Prenatal)
        End Get
    End Property

    Public ReadOnly Property Ingesta_Micronutrientes() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Ingesta_Micronutrientes)
        End Get
    End Property

    Public ReadOnly Property IdRemitidas() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Remitidas)
        End Get
    End Property

    Public ReadOnly Property Visita_Domiciliaria() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Visita_Domiciliaria)
        End Get
    End Property

    Public Readonly Property Personas() As PersonasBrl
        Get
            Return PersonasBrl.CargarPorID(Id_Persona)
        End Get
    End Property

    Public ReadOnly Property ControlPrenatal() As String
        Get
            If Control_prenatal Is Nothing Then
                Return ""
            Else
                Return Control_prenatal.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property IngestaMicronutrientes() As String
        Get
            If Ingesta_Micronutrientes Is Nothing Then
                Return ""
            Else
                Return Ingesta_Micronutrientes.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Remitidas() As String
        Get
            If IdRemitidas Is Nothing Then
                Return ""
            Else
                Return IdRemitidas.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property VisitaDomiciliaria() As String
        Get
            If Visita_Domiciliaria Is Nothing Then
                Return ""
            Else
                Return Visita_Domiciliaria.Descripcion
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
            Me.ID = GestantesDAL.Insertar(Id_Persona, Id_Control_Prenatal, Unidad_Basica_Atencion, Id_Ingesta_Micronutrientes, Enfermedades, Semanas_Gestacion, Id_Remitidas, Fecha_Remision, Id_Visita_Domiciliaria, Fecha_Visita, Observaciones, Fecha_Control_Prenatal, Observaciones_Visita, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Peso, Talla, IMC, Estado_Nutricional, Fecha_Cierre, Cierre)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            GestantesDAL.Actualizar(ID, Id_Persona, Id_Control_Prenatal, Unidad_Basica_Atencion, Id_Ingesta_Micronutrientes, Enfermedades, Semanas_Gestacion, Id_Remitidas, Fecha_Remision, Id_Visita_Domiciliaria, Fecha_Visita, Observaciones, Fecha_Control_Prenatal, Observaciones_Visita, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Peso, Talla, IMC, Estado_Nutricional, Fecha_Cierre, Cierre)
            RaiseEvent Updated()
        End If

        RaiseEvent Saved()

    End Sub

    Public Sub Eliminar()
        Dim totalHijos As Long = 0
        If Me.ID <> Nothing Then

            RaiseEvent Deleting()
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            GestantesDAL.Eliminar(Me.ID)

            RaiseEvent Deleted()

        End If
    End Sub

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As GestantesBrl

        Dim objGestantes As New GestantesBrl

        With objGestantes
            .ID = fila("Id")
            .Id_Persona = isDBNullToNothing(fila("Id_Persona"))
            .Id_Control_Prenatal = isDBNullToNothing(fila("Id_Control_Prenatal"))
            .Unidad_Basica_Atencion = isDBNullToNothing(fila("Unidad_Basica_Atencion"))
            .Id_Ingesta_Micronutrientes = isDBNullToNothing(fila("Id_Ingesta_Micronutrientes"))
            .Enfermedades = isDBNullToNothing(fila("Enfermedades"))
            .Semanas_Gestacion = isDBNullToNothing(fila("Semanas_Gestacion"))
            .Id_Remitidas = isDBNullToNothing(fila("Id_Remitidas"))
            .Fecha_Remision = isDBNullToNothing(fila("Fecha_Remision"))
            .Id_Visita_Domiciliaria = isDBNullToNothing(fila("Id_Visita_Domiciliaria"))
            .Fecha_Visita = isDBNullToNothing(fila("Fecha_Visita"))
            .Observaciones = isDBNullToNothing(fila("Observaciones"))
            .Fecha_Control_Prenatal = isDBNullToNothing(fila("Fecha_Control_Prenatal"))
            .Observaciones_Visita = isDBNullToNothing(fila("Observaciones_Visita"))
            .Peso = isDBNullToNothing(fila("Peso"))
            .Talla = isDBNullToNothing(fila("Talla"))
            .IMC = isDBNullToNothing(fila("IMC"))
            .Estado_Nutricional = isDBNullToNothing(fila("Estado_Nutricional"))
            .Fecha_Creacion = isDBNullToNothing(fila("Fecha_Creacion"))
            .Id_Usuario_Creacion = isDBNullToNothing(fila("Id_Usuario_Creacion"))
            .Fecha_Modificacion = isDBNullToNothing(fila("Fecha_Modificacion"))
            .Id_Usuario_Modificacion = isDBNullToNothing(fila("Id_Usuario_Modificacion"))
            .Fecha_Cierre = isDBNullToNothing(fila("Fecha_Cierre"))
            .Cierre = isDBNullToNothing(fila("Cierre"))

        End With

        Return objGestantes

    End Function

    Public Shared Event LoadingGestantesList(ByVal LoadType As String)
    Public Shared Event LoadedGestantesList(ByVal target As List(Of GestantesBrl), ByVal LoadType As String)

    Public Shared Function CargarTodos() As List(Of GestantesBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of GestantesBrl)

        RaiseEvent LoadingGestantesList("CargarTodos")

        dsDatos = GestantesDAL.CargarTodos()

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedGestantesList(lista, "CargarTodos")

        Return lista

    End Function

    Public Shared Event LoadingPorId(ByVal id As Int32)
    Public Shared Event LoadedPorId(ByVal target As GestantesBrl)

    Public Shared Function CargarPorID(ByVal ID As Int32) As GestantesBrl

        Dim dsDatos As System.Data.DataSet
        Dim objGestantes As GestantesBrl = Nothing

        dsDatos = GestantesDAL.CargarPorID(ID)

        If dsDatos.Tables(0).Rows.Count <> 0 Then objGestantes = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))

        Return objGestantes

    End Function

    Public Shared Function CargarPorId_Control_Prenatal(ByVal Id_Control_Prenatal As Int32) As List(Of GestantesBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of GestantesBrl)

        RaiseEvent LoadingGestantesList("CargarPorId_Control_Prenatal")

        dsDatos = GestantesDAL.CargarPorId_Control_Prenatal(Id_Control_Prenatal)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedGestantesList(lista, "CargarPorId_Control_Prenatal")

        Return lista

    End Function

    Public Shared Function CargarPorId_Ingesta_Micronutrientes(ByVal Id_Ingesta_Micronutrientes As Int32) As List(Of GestantesBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of GestantesBrl)

        RaiseEvent LoadingGestantesList("CargarPorId_Ingesta_Micronutrientes")

        dsDatos = GestantesDAL.CargarPorId_Ingesta_Micronutrientes(Id_Ingesta_Micronutrientes)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedGestantesList(lista, "CargarPorId_Ingesta_Micronutrientes")

        Return lista

    End Function

    Public Shared Function CargarPorId_Remitidas(ByVal Id_Remitidas As Int32) As List(Of GestantesBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of GestantesBrl)

        RaiseEvent LoadingGestantesList("CargarPorId_Remitidas")

        dsDatos = GestantesDAL.CargarPorId_Remitidas(Id_Remitidas)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedGestantesList(lista, "CargarPorId_Remitidas")

        Return lista

    End Function

    Public Shared Function CargarPorId_Visita_Domiciliaria(ByVal Id_Visita_Domiciliaria As Int32) As List(Of GestantesBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of GestantesBrl)

        RaiseEvent LoadingGestantesList("CargarPorId_Visita_Domiciliaria")

        dsDatos = GestantesDAL.CargarPorId_Visita_Domiciliaria(Id_Visita_Domiciliaria)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedGestantesList(lista, "CargarPorId_Visita_Domiciliaria")

        Return lista

    End Function

    Public Shared Function CargarPorId_Persona(ByVal Id_Persona As Int32) As List(Of GestantesBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of GestantesBrl)

        RaiseEvent LoadingGestantesList("CargarPorId_Persona")

        dsDatos = GestantesDAL.CargarPorId_Persona(Id_Persona)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedGestantesList(lista, "CargarPorId_Persona")

        Return lista

    End Function

    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As Int32) As List(Of GestantesBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of GestantesBrl)

        RaiseEvent LoadingGestantesList("CargarPorId_Usuario_Creacion")

        dsDatos = GestantesDAL.CargarPorId_Usuario_Creacion(Id_Usuario_Creacion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedGestantesList(lista, "CargarPorId_Usuario_Creacion")

        Return lista

    End Function

    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As Int32) As List(Of GestantesBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of GestantesBrl)

        RaiseEvent LoadingGestantesList("CargarPorId_Usuario_Modificacion")

        dsDatos = GestantesDAL.CargarPorId_Usuario_Modificacion(Id_Usuario_Modificacion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedGestantesList(lista, "CargarPorId_Usuario_Modificacion")

        Return lista

    End Function

End Class


