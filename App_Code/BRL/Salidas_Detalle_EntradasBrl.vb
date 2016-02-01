Imports ingNovar.Utilidades2
Imports System.Data
Imports System.Collections.Generic

Partial Public Class Salidas_Detalle_EntradasBrl

    Private _Id As Int32
    Private _Id_Salida_Detalle As Int32
    Private _Cantidad As Double
    Private _Id_Entrada_Distribucion As Int32
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

    Public Event Id_Salida_DetalleChanging(ByVal Value As Int32)
    Public Event Id_Salida_DetalleChanged()

    Public Property Id_Salida_Detalle() As Int32
        Get
            Return Me._Id_Salida_Detalle
        End Get
        Set(ByVal Value As Int32)
            If _Id_Salida_Detalle <> Value Then
                RaiseEvent Id_Salida_DetalleChanging(Value)
                Me._Id_Salida_Detalle = Value
                RaiseEvent Id_Salida_DetalleChanged()
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

    Public Event Id_Entrada_DistribucionChanging(ByVal Value As Int32)
    Public Event Id_Entrada_DistribucionChanged()

    Public Property Id_Entrada_Distribucion() As Int32
        Get
            Return Me._Id_Entrada_Distribucion
        End Get
        Set(ByVal Value As Int32)
            If _Id_Entrada_Distribucion <> Value Then
                RaiseEvent Id_Entrada_DistribucionChanging(Value)
                Me._Id_Entrada_Distribucion = Value
                RaiseEvent Id_Entrada_DistribucionChanged()
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

    Public ReadOnly Property Entrada_Distribucion() As Entradas_DistribucionBrl
        Get
            Return Entradas_DistribucionBrl.CargarPorID(Id_Entrada_Distribucion)
        End Get
    End Property

    Public ReadOnly Property Salidas_Detalle() As Salidas_DetalleBrl
        Get
            Return Salidas_DetalleBrl.CargarPorID(Id_Salida_Detalle)
        End Get
    End Property

    Public ReadOnly Property CantidadEntregada() As Double
        Get
            Return Salidas_Detalle_EntradasBrl.CantidadSalida(Id_Entrada_Distribucion)
        End Get
    End Property

    Public ReadOnly Property DescripcionProductosSalida() As String
        Get
            Return Entrada_Distribucion.Entradas_Detalle.Producto.Descripcion & " " & Cantidad.ToString & " " & Salidas_Detalle.Capacidad.Descripcion & " por $ " & _
            Entrada_Distribucion.Entradas_Detalle.Valor_Unitario

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
            Me.ID = Salidas_DetalleEntradasDAL.Insertar(Id_Salida_Detalle, Cantidad, Id_Entrada_Distribucion, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Fecha_Cierre, Cierre)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            Salidas_DetalleEntradasDAL.Actualizar(ID, Id_Salida_Detalle, Cantidad, Id_Entrada_Distribucion, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Fecha_Cierre, Cierre)
            RaiseEvent Updated()
        End If

        RaiseEvent Saved()

    End Sub

    Public Sub Eliminar()
        Dim totalHijos As Long = 0
        If Me.ID <> Nothing Then

            RaiseEvent Deleting()
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            Salidas_DetalleEntradasDAL.Eliminar(Me.ID)

            RaiseEvent Deleted()

        End If
    End Sub

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Salidas_Detalle_EntradasBrl

        Dim objSalidas_DetalleEntradas As New Salidas_Detalle_EntradasBrl

        With objSalidas_DetalleEntradas
            .ID = fila("Id")
            .Id_Entrada_Distribucion = isDBNullToNothing(fila("Id_Entrada_Distribucion"))
            .Cantidad = isDBNullToNothing(fila("Cantidad"))
            .Id_Salida_Detalle = isDBNullToNothing(fila("Id_Salida_Detalle"))
            .Fecha_Creacion = isDBNullToNothing(fila("Fecha_Creacion"))
            .Id_Usuario_Creacion = isDBNullToNothing(fila("Id_Usuario_Creacion"))
            .Fecha_Modificacion = isDBNullToNothing(fila("Fecha_Modificacion"))
            .Id_Usuario_Modificacion = isDBNullToNothing(fila("Id_Usuario_Modificacion"))
            .Fecha_Cierre = isDBNullToNothing(fila("Fecha_Cierre"))
            .Cierre = isDBNullToNothing(fila("Cierre"))
        End With

        Return objSalidas_DetalleEntradas

    End Function

    Public Shared Event LoadingSalidas_DetalleEntradasList(ByVal LoadType As String)
    Public Shared Event LoadedSalidas_DetalleEntradasList(ByVal target As List(Of Salidas_Detalle_EntradasBrl), ByVal LoadType As String)

    Public Shared Function CargarTodos() As List(Of Salidas_Detalle_EntradasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Salidas_Detalle_EntradasBrl)

        RaiseEvent LoadingSalidas_DetalleEntradasList("CargarTodos")

        dsDatos = Salidas_DetalleEntradasDAL.CargarTodos()

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSalidas_DetalleEntradasList(lista, "CargarTodos")

        Return lista

    End Function

    Public Shared Event LoadingPorId(ByVal id As Int32)
    Public Shared Event LoadedPorId(ByVal target As Salidas_Detalle_EntradasBrl)

    Public Shared Function CargarPorID(ByVal ID As Int32) As Salidas_Detalle_EntradasBrl

        Dim dsDatos As System.Data.DataSet
        Dim objEntradas_OrdenCompra As Salidas_Detalle_EntradasBrl = Nothing

        dsDatos = Salidas_DetalleEntradasDAL.CargarPorID(ID)

        If dsDatos.Tables(0).Rows.Count <> 0 Then objEntradas_OrdenCompra = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))

        Return objEntradas_OrdenCompra

    End Function

    Public Shared Function CargarPorId_Entrada_Distribucion(ByVal Id_Entrada_Distribucion As Int32) As List(Of Salidas_Detalle_EntradasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Salidas_Detalle_EntradasBrl)

        RaiseEvent LoadingSalidas_DetalleEntradasList("CargarPorId_Entrada_Distribucion")

        dsDatos = Salidas_DetalleEntradasDAL.CargarPorId_Entrada_Distribucion(Id_Entrada_Distribucion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSalidas_DetalleEntradasList(lista, "CargarPorId_Entrada_Detalle")

        Return lista

    End Function

    Public Shared Function CargarPorId_Salida_Detalle(ByVal Id_Salida_Detalle As Int32) As List(Of Salidas_Detalle_EntradasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Salidas_Detalle_EntradasBrl)

        RaiseEvent LoadingSalidas_DetalleEntradasList("CargarPorId_Salida_Detalle")

        dsDatos = Salidas_DetalleEntradasDAL.CargarPorId_Salida_Detalle(Id_Salida_Detalle)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSalidas_DetalleEntradasList(lista, "CargarPorId_Salida_Detalle")

        Return lista

    End Function

End Class


