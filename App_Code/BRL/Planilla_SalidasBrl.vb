Imports ingNovar.Utilidades2
Imports System.Data
Imports System.Collections.Generic

Partial Public Class Planilla_SalidasBrl

    Private _Id As Int32
    Private _Id_Planilla As Int32
    Private _Id_Salida As Int32


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

    Public Event Id_PlanillaChanging(ByVal Value As Int32)
    Public Event Id_PlanillaChanged()

    Public Property Id_Planilla() As Int32
        Get
            Return Me._Id_Planilla
        End Get
        Set(ByVal Value As Int32)
            If _Id_Planilla <> Value Then
                RaiseEvent Id_PlanillaChanging(Value)
				Me._Id_Planilla = Value
                RaiseEvent Id_PlanillaChanged()
            End If
        End Set
    End Property

    Public Event Id_SalidaChanging(ByVal Value As Int32)
    Public Event Id_SalidaChanged()
	
    Public Property Id_Salida() As Int32
        Get
            Return Me._Id_Salida
        End Get
        Set(ByVal Value As Int32)
            If _Id_Salida <> Value Then
                RaiseEvent Id_SalidaChanging(Value)
                Me._Id_Salida = Value
                RaiseEvent Id_SalidaChanged()
            End If
        End Set
    End Property

    Public Readonly Property Planilla() As PlanillaBrl
        Get
            Return PlanillaBrl.CargarPorID(Id_Planilla)
        End Get
    End Property

    Public Readonly Property Salidas() As SalidasBrl
        Get
            Return SalidasBrl.CargarPorID(Id_Salida)
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
            Me.ID = Planilla_SalidasDAL.Insertar(Id_Planilla, Id_Salida)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            Planilla_SalidasDAL.Actualizar(ID, Id_Planilla, Id_Salida)
            RaiseEvent Updated()
        End If
        RaiseEvent Saved()

    End Sub
	
	Public Sub Eliminar()
		Dim totalHijos As Long = 0
		If Me.ID <> Nothing Then 
            RaiseEvent Deleting()
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            
			Planilla_SalidasDAL.Eliminar(Me.ID)
			
            RaiseEvent Deleted()
            
        End If
	End Sub

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Planilla_SalidasBrl
		
		Dim objPlanilla_Salidas As New Planilla_SalidasBrl
		
		With objPlanilla_Salidas
			.ID = fila("Id")
			.Id_Planilla = isDBNullToNothing(fila("Id_Planilla"))
			.Id_Salida = isDBNullToNothing(fila("Id_Salida"))

		End With
		
		Return objPlanilla_Salidas
		
    End Function
	
	Public Shared Event LoadingPlanilla_SalidasList(ByVal LoadType As String)
	Public Shared Event LoadedPlanilla_SalidasList(target As List(Of Planilla_SalidasBrl), ByVal LoadType As String)
	
	Public Shared Function CargarTodos() As List(Of Planilla_SalidasBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Planilla_SalidasBrl)
	
		RaiseEvent LoadingPlanilla_SalidasList("CargarTodos")
	
		dsDatos = Planilla_SalidasDAL.CargarTodos()

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedPlanilla_SalidasList(lista, "CargarTodos")
        
        Return lista
        
    End Function

	Public Shared Event LoadingPorId(ByVal id As Int32)
    Public Shared Event LoadedPorId(ByVal target As Planilla_SalidasBrl)

	Public Shared Function CargarPorID(ID As Int32) As Planilla_SalidasBrl

		Dim dsDatos As System.Data.DataSet
		Dim objPlanilla_Salidas As Planilla_SalidasBrl = Nothing 
        dsDatos = Planilla_SalidasDAL.CargarPorID(ID)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objPlanilla_Salidas = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objPlanilla_Salidas
        
    End Function

	Public Shared Function CargarPorId_Planilla(ByVal Id_Planilla As Int32) As List(Of Planilla_SalidasBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Planilla_SalidasBrl)
	
		RaiseEvent LoadingPlanilla_SalidasList("CargarPorId_Planilla")
        dsDatos = Planilla_SalidasDAL.CargarPorId_Planilla(Id_Planilla)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPlanilla_SalidasList(lista, "CargarPorId_Planilla")
        Return lista
        
	End Function

    Public Shared Function CargarPorId_Salida(ByVal Id_Salida As Int32) As List(Of Planilla_SalidasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Planilla_SalidasBrl)

        RaiseEvent LoadingPlanilla_SalidasList("CargarPorId_Salida")
        dsDatos = Planilla_SalidasDAL.CargarPorId_Salida(Id_Salida)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPlanilla_SalidasList(lista, "CargarPorId_Salida")
        Return lista

    End Function

End Class


