Imports ingNovar.Utilidades2
Imports System.Data
Imports System.Collections.Generic
Imports SeguridadUsuarios

Partial Public Class Salidas_DetalleBrl

    Private _Id As Int32
    Private _Id_Salida As Int32
    Private _Id_Producto As Int32
    Private _Id_Capacidad As Int32
    Private _Cantidad As Double
    Private _Fecha_Creacion As DateTime
    Private _Id_Usuario_Creacion As Int32
    Private _Fecha_Modificacion As DateTime
    Private _Id_Usuario_Modificacion As Int32
    Private _Fecha_Cierre As DateTime
    Private _Cierre As Boolean

    Private objListSalidas_DetalleEntradas As List(Of Salidas_Detalle_EntradasBrl)


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

    Public ReadOnly Property Salidas() As SalidasBrl
        Get
            Return SalidasBrl.CargarPorID(Id_Salida)
        End Get
    End Property

    Public ReadOnly Property Capacidad() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Capacidad)
        End Get
    End Property

    Public ReadOnly Property Productos() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Producto)
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

    Public ReadOnly Property DescripcionDetalleSalida() As String
        Get
            Return Productos.Descripcion & " - " & Format(Cantidad, "N")
        End Get
    End Property

    Public Property Salidas_Detalle_Entradas() As List(Of Salidas_Detalle_EntradasBrl)
        Get
            If (Me.objListSalidas_DetalleEntradas Is Nothing) Then
                objListSalidas_DetalleEntradas = Salidas_Detalle_EntradasBrl.CargarPorId_Salida_Detalle(Me.ID)
            End If
            Return Me.objListSalidas_DetalleEntradas
        End Get
        Set(ByVal Value As List(Of Salidas_Detalle_EntradasBrl))
            Me.objListSalidas_DetalleEntradas = Value
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
            Me.ID = Salidas_DetalleDAL.Insertar(Id_Salida, Id_Producto, Id_Capacidad, Cantidad, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Fecha_Cierre, Cierre)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            Salidas_DetalleDAL.Actualizar(ID, Id_Salida, Id_Producto, Id_Capacidad, Cantidad, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Fecha_Cierre, Cierre)
            RaiseEvent Updated()
        End If

        If Not objListSalidas_DetalleEntradas Is Nothing Then
            For Each fila As Salidas_Detalle_EntradasBrl In objListSalidas_DetalleEntradas
                fila.Id_Salida_Detalle = Me.ID
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

            totalHijos += Salidas_Detalle_Entradas.Count
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")

            Salidas_DetalleDAL.Eliminar(Me.ID)

            RaiseEvent Deleted()

        End If
    End Sub


    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Salidas_DetalleBrl

        Dim objSalidas_Detalle As New Salidas_DetalleBrl

        With objSalidas_Detalle
            .ID = fila("Id")
            .Id_Salida = isDBNullToNothing(fila("Id_Salida"))
            .Id_Producto = isDBNullToNothing(fila("Id_Producto"))
            .Id_Capacidad = isDBNullToNothing(fila("Id_Capacidad"))
            .Cantidad = isDBNullToNothing(fila("Cantidad"))
            .Fecha_Creacion = isDBNullToNothing(fila("Fecha_Creacion"))
            .Id_Usuario_Creacion = isDBNullToNothing(fila("Id_Usuario_Creacion"))
            .Fecha_Modificacion = isDBNullToNothing(fila("Fecha_Modificacion"))
            .Id_Usuario_Modificacion = isDBNullToNothing(fila("Id_Usuario_Modificacion"))
            .Fecha_Cierre = isDBNullToNothing(fila("Fecha_Cierre"))
            .Cierre = isDBNullToNothing(fila("Cierre"))
        End With

        Return objSalidas_Detalle

    End Function

    Public Shared Event LoadingSalidas_DetalleList(ByVal LoadType As String)
    Public Shared Event LoadedSalidas_DetalleList(ByVal target As List(Of Salidas_DetalleBrl), ByVal LoadType As String)

    Public Shared Function CargarTodos() As List(Of Salidas_DetalleBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Salidas_DetalleBrl)

        RaiseEvent LoadingSalidas_DetalleList("CargarTodos")

        dsDatos = Salidas_DetalleDAL.CargarTodos()

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSalidas_DetalleList(lista, "CargarTodos")

        Return lista

    End Function

    Public Shared Event CargandoPorId(ByVal id As Int32)
    Public Shared Event CargadoPorId(ByVal target As Salidas_DetalleBrl)

    Public Shared Function CargarPorID(ByVal ID As Int32) As Salidas_DetalleBrl

        Dim dsDatos As System.Data.DataSet
        Dim objSalidas_Detalle As Salidas_DetalleBrl = Nothing

        'RaiseEvent CargandoPorId(ID)

        dsDatos = Salidas_DetalleDAL.CargarPorID(ID)

        If dsDatos.Tables(0).Rows.Count <> 0 Then objSalidas_Detalle = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))

        'RaiseEvent CargadoPorId(objJoven)

        Return objSalidas_Detalle

    End Function
    Public Shared Function CargarPorId_Salida(ByVal Id_Salida As Int32) As List(Of Salidas_DetalleBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Salidas_DetalleBrl)

        RaiseEvent LoadingSalidas_DetalleList("CargarPorId_Salida")

        dsDatos = Salidas_DetalleDAL.CargarPorId_Salida(Id_Salida)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSalidas_DetalleList(lista, "CargarPorId_Salida")

        Return lista

    End Function


    Public Shared Function CargarPorId_Capacidad(ByVal Id_Capacidad As Int32) As List(Of Salidas_DetalleBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Salidas_DetalleBrl)

        RaiseEvent LoadingSalidas_DetalleList("CargarPorId_Capacidad")

        dsDatos = Salidas_DetalleDAL.CargarPorId_Capacidad(Id_Capacidad)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSalidas_DetalleList(lista, "CargarPorId_Capacidad")

        Return lista

    End Function


    Public Shared Function CargarPorId_Producto(ByVal Id_Producto As Int32) As List(Of Salidas_DetalleBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Salidas_DetalleBrl)

        RaiseEvent LoadingSalidas_DetalleList("CargarPorId_Producto")

        dsDatos = Salidas_DetalleDAL.CargarPorId_Producto(Id_Producto)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSalidas_DetalleList(lista, "CargarPorId_Producto")

        Return lista

    End Function


    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As Int32) As List(Of Salidas_DetalleBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Salidas_DetalleBrl)

        RaiseEvent LoadingSalidas_DetalleList("CargarPorId_Usuario_Creacion")

        dsDatos = Salidas_DetalleDAL.CargarPorId_Usuario_Creacion(Id_Usuario_Creacion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSalidas_DetalleList(lista, "CargarPorId_Usuario_Creacion")

        Return lista

    End Function


    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As Int32) As List(Of Salidas_DetalleBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Salidas_DetalleBrl)

        RaiseEvent LoadingSalidas_DetalleList("CargarPorId_Usuario_Modificacion")

        dsDatos = Salidas_DetalleDAL.CargarPorId_Usuario_Modificacion(Id_Usuario_Modificacion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSalidas_DetalleList(lista, "CargarPorId_Usuario_Modificacion")

        Return lista

    End Function



End Class


