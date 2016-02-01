Imports ingNovar.Utilidades2
imports system.data
Imports system.collections.generic

Partial Public Class Distribucion_DetalleBrl

    Private _Id As Int32
    Private _Id_Distribucion As Int32
    Private _Id_Producto As Int32
    Private _Id_Capacidad As Int32
    Private _Cantidad As Double
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

    Public Event Id_DistribucionChanging(ByVal Value As Int32)
    Public Event Id_DistribucionChanged()

    Public Property Id_Distribucion() As Int32
        Get
            Return Me._Id_Distribucion
        End Get
        Set(ByVal Value As Int32)
            If _Id_Distribucion <> Value Then
                RaiseEvent Id_DistribucionChanging(Value)
                Me._Id_Distribucion = Value
                RaiseEvent Id_DistribucionChanged()
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

    Public Event Id_CapacidadChanging(ByVal Value As Int32)
    Public Event Id_CapacidadChanged()

    Public Property Id_Capacidad() As Int32
        Get
            Return Me._Id_Capacidad
        End Get
        Set(ByVal Value As Int32)
            If _Id_Capacidad <> Value Then
                RaiseEvent Id_CapacidadChanging(Value)
                Me._Id_Capacidad = Value
                RaiseEvent Id_CapacidadChanged()
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

    Public ReadOnly Property SubTablasCapacidad() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Capacidad)
        End Get
    End Property

    Public ReadOnly Property Distribucion() As DistribucionBrl
        Get
            Return DistribucionBrl.CargarPorID(Id_Distribucion)
        End Get
    End Property

    Public ReadOnly Property SubTablasProducto() As SubTablasBrl
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
            Me.ID = Distribucion_DetalleDAL.Insertar(Id_Distribucion, Id_Producto, Id_Capacidad, Cantidad, Fecha_Cierre, Cierre)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            Distribucion_DetalleDAL.Actualizar(ID, Id_Distribucion, Id_Producto, Id_Capacidad, Cantidad, Fecha_Cierre, Cierre)
            RaiseEvent Updated()
        End If

        RaiseEvent Saved()

    End Sub

    Public Sub Eliminar()
        Dim totalHijos As Long = 0
        If Me.ID <> Nothing Then
            RaiseEvent Deleting()
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            Distribucion_DetalleDAL.Eliminar(Me.ID)
            RaiseEvent Deleted()
        End If
    End Sub

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Distribucion_DetalleBrl

        Dim objDistribucion_Detalle As New Distribucion_DetalleBrl

        With objDistribucion_Detalle
            .ID = fila("Id")
            .Id_Distribucion = isDBNullToNothing(fila("Id_Distribucion"))
            .Id_Producto = isDBNullToNothing(fila("Id_Producto"))
            .Id_Capacidad = isDBNullToNothing(fila("Id_Capacidad"))
            .Cantidad = isDBNullToNothing(fila("Cantidad"))
            .Fecha_Cierre = isDBNullToNothing(fila("Fecha_Cierre"))
            .Cierre = isDBNullToNothing(fila("Cierre"))
        End With

        Return objDistribucion_Detalle

    End Function

    Public Shared Event LoadingDistribucion_DetalleList(ByVal LoadType As String)
    Public Shared Event LoadedDistribucion_DetalleList(ByVal target As List(Of Distribucion_DetalleBrl), ByVal LoadType As String)

    Public Shared Function CargarTodos() As List(Of Distribucion_DetalleBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Distribucion_DetalleBrl)

        RaiseEvent LoadingDistribucion_DetalleList("CargarTodos")

        dsDatos = Distribucion_DetalleDAL.CargarTodos()

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDistribucion_DetalleList(lista, "CargarTodos")

        Return lista

    End Function

    Public Shared Event CargandoPorId(ByVal id As Int32)
    Public Shared Event CargadoPorId(ByVal target As Distribucion_DetalleBrl)

    Public Shared Function CargarPorID(ByVal ID As Int32) As Distribucion_DetalleBrl

        Dim dsDatos As System.Data.DataSet
        Dim objDistribucion_Detalle As Distribucion_DetalleBrl = Nothing
        dsDatos = Distribucion_DetalleDAL.CargarPorID(ID)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objDistribucion_Detalle = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objDistribucion_Detalle

    End Function

    Public Shared Function CargarPorId_Capacidad(ByVal Id_Capacidad As Int32) As List(Of Distribucion_DetalleBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Distribucion_DetalleBrl)
        RaiseEvent LoadingDistribucion_DetalleList("CargarPorId_Capacidad")
        dsDatos = Distribucion_DetalleDAL.CargarPorId_Capacidad(Id_Capacidad)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedDistribucion_DetalleList(lista, "CargarPorId_Capacidad")
        Return lista

    End Function

    Public Shared Function CargarPorId_Distribucion(ByVal Id_Distribucion As Int32) As List(Of Distribucion_DetalleBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Distribucion_DetalleBrl)
        RaiseEvent LoadingDistribucion_DetalleList("CargarPorId_Distribucion")
        dsDatos = Distribucion_DetalleDAL.CargarPorId_Distribucion(Id_Distribucion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedDistribucion_DetalleList(lista, "CargarPorId_Distribucion")
        Return lista

    End Function

    Public Shared Function CargarPorId_Producto(ByVal Id_Producto As Int32) As List(Of Distribucion_DetalleBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Distribucion_DetalleBrl)
        RaiseEvent LoadingDistribucion_DetalleList("CargarPorId_Producto")
        dsDatos = Distribucion_DetalleDAL.CargarPorId_Producto(Id_Producto)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedDistribucion_DetalleList(lista, "CargarPorId_Producto")
        Return lista

    End Function

End Class


