Imports ingNovar.Utilidades2
Imports System.Collections.Generic
Imports System.data

Partial Public Class Planilla_Personas_ProductosBrl

    Private _Id As Int32
    Private _Id_Planilla_Personas As Int32
    Private _Id_Producto As Int32
    Private _Cantidad As Double

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

    Public Event Id_Planilla_PersonasChanging(ByVal Value As Int32)
    Public Event Id_Planilla_PersonasChanged()
	
    Public Property Id_Planilla_Personas() As Int32
        Get
            Return Me._Id_Planilla_Personas
        End Get
        Set(ByVal Value As Int32)
            If _Id_Planilla_Personas <> Value Then
                RaiseEvent Id_Planilla_PersonasChanging(Value)
                Me._Id_Planilla_Personas = Value
                RaiseEvent Id_Planilla_PersonasChanged()
            End If
        End Set
    End Property

    Public Event Id_ProductoChanging(ByVal Value As Int32)
    Public Event Id_ProductoChanged()
	
    Public Property Id_Producto() As Int32
        Get
            Return Me._Id_Producto
        End Get
        Set(ByVal Value As Int32)
            If _Id_Producto <> Value Then
                RaiseEvent Id_ProductoChanging(Value)
                Me._Id_Producto = Value
                RaiseEvent Id_ProductoChanged()
            End If
        End Set
    End Property

    Public Event CantidadChanging(ByVal Value As Double)
    Public Event CantidadChanged()
	
    Public Property Cantidad() As Double
        Get
            Return Me._Cantidad
        End Get
        Set(ByVal Value As Double)
            If _Cantidad <> Value Then
                RaiseEvent CantidadChanging(Value)
                Me._Cantidad = Value
                RaiseEvent CantidadChanged()
            End If
        End Set
    End Property

    Public Readonly Property Planilla_Personas() As Planilla_PersonasBrl
        Get
            Return Planilla_PersonasBrl.CargarPorID(Id_Planilla_Personas)
        End Get
    End Property

    Public ReadOnly Property Productos() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Producto)
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
			Me.ID = Planilla_Personas_ProductosDAL.Insertar(Id_Planilla_Personas, Id_Producto, Cantidad)
            RaiseEvent Inserted()			
		Else
            RaiseEvent Updating()		
			Planilla_Personas_ProductosDAL.Actualizar(ID, Id_Planilla_Personas, Id_Producto, Cantidad)
            RaiseEvent Updated()			
		End If   
        RaiseEvent Saved()
        
	End Sub
	
	Public Sub Eliminar()
		Dim totalHijos As Long = 0
		If Me.ID <> Nothing Then 
			
            RaiseEvent Deleting()
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            Planilla_Personas_ProductosDAL.Eliminar(Me.ID)
            RaiseEvent Deleted()
            
        End If
	End Sub
	
    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Planilla_Personas_ProductosBrl

        Dim objPlanilla_Personas_Productos As New Planilla_Personas_ProductosBrl

        With objPlanilla_Personas_Productos
            .ID = fila("Id")
            .Id_Planilla_Personas = isDBNullToNothing(fila("Id_Planilla_Personas"))
            .Id_Producto = isDBNullToNothing(fila("Id_Producto"))
            .Cantidad = isDBNullToNothing(fila("Cantidad"))
        End With

        Return objPlanilla_Personas_Productos

    End Function
	
	Public Shared Event LoadingPlanilla_Personas_ProductosList(ByVal LoadType As String)
	Public Shared Event LoadedPlanilla_Personas_ProductosList(target As List(Of Planilla_Personas_ProductosBrl), ByVal LoadType As String)
	
	Public Shared Function CargarTodos() As List(Of Planilla_Personas_ProductosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Planilla_Personas_ProductosBrl)
	
		RaiseEvent LoadingPlanilla_Personas_ProductosList("CargarTodos")
	
		dsDatos = Planilla_Personas_ProductosDAL.CargarTodos()

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedPlanilla_Personas_ProductosList(lista, "CargarTodos")
        
        Return lista
        
    End Function

	Public Shared Event LoadingPorId(ByVal id As Int32)
    Public Shared Event LoadedPorId(ByVal target As Planilla_Personas_ProductosBrl)

	Public Shared Function CargarPorID(ID As Int32) As Planilla_Personas_ProductosBrl

		Dim dsDatos As System.Data.DataSet
		Dim objPlanilla_Personas_Productos As Planilla_Personas_ProductosBrl = Nothing 
        dsDatos = Planilla_Personas_ProductosDAL.CargarPorID(ID)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objPlanilla_Personas_Productos = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objPlanilla_Personas_Productos
        
    End Function

	Public Shared Function CargarPorId_Planilla_Personas(ByVal Id_Planilla_Personas As Int32) As List(Of Planilla_Personas_ProductosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Planilla_Personas_ProductosBrl)
        RaiseEvent LoadingPlanilla_Personas_ProductosList("CargarPorId_Planilla_Personas")
        dsDatos = Planilla_Personas_ProductosDAL.CargarPorId_Planilla_Personas(Id_Planilla_Personas)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPlanilla_Personas_ProductosList(lista, "CargarPorId_Planilla_Personas")
        
        Return lista
        
	End Function

    Public Shared Function CargarPorId_Producto(ByVal Id_Producto As Int32) As List(Of Planilla_Personas_ProductosBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Planilla_Personas_ProductosBrl)

        RaiseEvent LoadingPlanilla_Personas_ProductosList("CargarPorId_Producto")
        dsDatos = Planilla_Personas_ProductosDAL.CargarPorId_Producto(Id_Producto)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPlanilla_Personas_ProductosList(lista, "CargarPorId_Producto")

        Return lista

    End Function

End Class


