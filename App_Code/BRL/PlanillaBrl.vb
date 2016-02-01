Imports ingNovar.Utilidades2
Imports System.Data
Imports System.Collections.Generic

Partial Public Class PlanillaBrl

    Private _Id As Int32
    Private _Id_Grupo As Int32
    Private _Fecha As DateTime
    Private _Id_Tipo_Declaracion As Int32
    Private _Fecha_Creacion As DateTime
    Private _Id_Usuario_Creacion As Int32
    Private _Fecha_Modificacion As DateTime
    Private _Id_Usuario_Modificacion As Int32
    Private objListPlanilla_Personas As List(Of Planilla_PersonasBrl)
    Private objListPlanilla_Salidas As List(Of Planilla_SalidasBrl)


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

    Public Event Id_Tipo_DeclaracionChanging(ByVal Value As Int32)
    Public Event Id_Tipo_DeclaracionChanged()
	
    Public Property Id_Tipo_Declaracion() As Int32
        Get
            Return Me._Id_Tipo_Declaracion
        End Get
        Set(ByVal Value As Int32)
            If _Id_Tipo_Declaracion <> Value Then
                RaiseEvent Id_Tipo_DeclaracionChanging(Value)
                Me._Id_Tipo_Declaracion = Value
                RaiseEvent Id_Tipo_DeclaracionChanged()
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

    Public Property Planilla_Personas() As List(Of Planilla_PersonasBrl)
        Get
            If (Me.objListPlanilla_Personas Is Nothing) Then
                objListPlanilla_Personas = Planilla_PersonasBrl.CargarPorId_Planilla(Me.ID)
            End If
            Return Me.objListPlanilla_Personas
        End Get
        Set(ByVal Value As List(Of Planilla_PersonasBrl))
            Me.objListPlanilla_Personas = Value
        End Set
    End Property

    Public Property Planilla_Salidas() As List(Of Planilla_SalidasBrl)
        Get
            If (Me.objListPlanilla_Salidas Is Nothing) Then
                objListPlanilla_Salidas = Planilla_SalidasBrl.CargarPorId_Planilla(Me.ID)
            End If
            Return Me.objListPlanilla_Salidas
        End Get
        Set(ByVal Value As List(Of Planilla_SalidasBrl))
            Me.objListPlanilla_Salidas = Value
        End Set
    End Property

    Public Readonly Property Grupos() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Grupo)
        End Get
    End Property

    Public Readonly Property Tipo_Declaracion() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Tipo_Declaracion)
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
            Me.ID = PlanillaDAL.Insertar(Id_Grupo, Fecha, Id_Tipo_Declaracion, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            PlanillaDAL.Actualizar(ID, Id_Grupo, Fecha, Id_Tipo_Declaracion, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion)
            RaiseEvent Updated()
        End If
        If Not objListPlanilla_Personas Is Nothing Then
            For Each fila As Planilla_PersonasBrl In objListPlanilla_Personas
                fila.Id_Planilla = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListPlanilla_Salidas Is Nothing Then
            For Each fila As Planilla_SalidasBrl In objListPlanilla_Salidas
                fila.Id_Planilla = Me.ID
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
            totalHijos += Planilla_Personas.Count
            totalHijos += Planilla_Salidas.Count
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            PlanillaDAL.Eliminar(Me.ID)
			
            RaiseEvent Deleted()
            
        End If
	End Sub
	
    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As PlanillaBrl

        Dim objPlanilla As New PlanillaBrl

        With objPlanilla
            .ID = fila("Id")
            .Id_Grupo = isDBNullToNothing(fila("Id_Grupo"))
            .Fecha = isDBNullToNothing(fila("Fecha"))
            .Id_Tipo_Declaracion = isDBNullToNothing(fila("Id_Tipo_Declaracion"))
            .Fecha_Creacion = isDBNullToNothing(fila("Fecha_Creacion"))
            .Id_Usuario_Creacion = isDBNullToNothing(fila("Id_Usuario_Creacion"))
            .Fecha_Modificacion = isDBNullToNothing(fila("Fecha_Modificacion"))
            .Id_Usuario_Modificacion = isDBNullToNothing(fila("Id_Usuario_Modificacion"))

        End With

        Return objPlanilla

    End Function
	
	Public Shared Event LoadingPlanillaList(ByVal LoadType As String)
	Public Shared Event LoadedPlanillaList(target As List(Of PlanillaBrl), ByVal LoadType As String)
	
	Public Shared Function CargarTodos() As List(Of PlanillaBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of PlanillaBrl)
	
		RaiseEvent LoadingPlanillaList("CargarTodos")
	
		dsDatos = PlanillaDAL.CargarTodos()

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedPlanillaList(lista, "CargarTodos")
        
        Return lista
        
    End Function

	Public Shared Event LoadingPorId(ByVal id As Int32)
    Public Shared Event LoadedPorId(ByVal target As PlanillaBrl)

	Public Shared Function CargarPorID(ID As Int32) As PlanillaBrl

		Dim dsDatos As System.Data.DataSet
		Dim objPlanilla As PlanillaBrl = Nothing 
        dsDatos = PlanillaDAL.CargarPorID(ID)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objPlanilla = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objPlanilla
        
    End Function

	Public Shared Function CargarPorId_Grupo(ByVal Id_Grupo As Int32) As List(Of PlanillaBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of PlanillaBrl)
	
		RaiseEvent LoadingPlanillaList("CargarPorId_Grupo")
        dsDatos = PlanillaDAL.CargarPorId_Grupo(Id_Grupo)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPlanillaList(lista, "CargarPorId_Grupo")
        
        Return lista
        
	End Function

	Public Shared Function CargarPorId_Tipo_Declaracion(ByVal Id_Tipo_Declaracion As Int32) As List(Of PlanillaBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of PlanillaBrl)
	
		RaiseEvent LoadingPlanillaList("CargarPorId_Tipo_Declaracion")
        dsDatos = PlanillaDAL.CargarPorId_Tipo_Declaracion(Id_Tipo_Declaracion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPlanillaList(lista, "CargarPorId_Tipo_Declaracion")
        
        Return lista
        
	End Function
End Class


