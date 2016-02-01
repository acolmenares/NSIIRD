Imports ingNovar.Utilidades2
Imports System.Data
Imports System.Collections.Generic
Imports SeguridadUsuarios

Partial Public Class Declaracion_UnidadesBrl

    Private _Id As Int32
    Private _Id_Declaracion As Int32
    Private _Id_Unidad As Int32
    Private _Id_EstadoUnidad As Int32
    Private _Fecha_Inclusion As DateTime
    Private _Fecha_Investigacion As DateTime
    Private _Fuente As String
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

    Public Event Id_UnidadChanging(ByVal Value As Int32)
    Public Event Id_UnidadChanged()

    Public Property Id_Unidad() As Int32
        Get
            Return Me._Id_Unidad
        End Get
        Set(ByVal Value As Int32)
            If _Id_Unidad <> Value Then
                RaiseEvent Id_UnidadChanging(Value)
                Me._Id_Unidad = Value
                RaiseEvent Id_UnidadChanged()
            End If
        End Set
    End Property

    Public Event Id_EstadoUnidadChanging(ByVal Value As Int32)
    Public Event Id_EstadoUnidadChanged()

    Public Property Id_EstadoUnidad() As Int32
        Get
            Return Me._Id_EstadoUnidad
        End Get
        Set(ByVal Value As Int32)
            If _Id_EstadoUnidad <> Value Then
                RaiseEvent Id_EstadoUnidadChanging(Value)
                Me._Id_EstadoUnidad = Value
                RaiseEvent Id_EstadoUnidadChanged()
            End If
        End Set
    End Property

    Public Event Fecha_InclusionChanging(ByVal Value As DateTime)
    Public Event Fecha_InclusionChanged()

    Public Property Fecha_Inclusion() As DateTime
        Get
            Return Me._Fecha_Inclusion
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_Inclusion <> Value Then
                RaiseEvent Fecha_InclusionChanging(Value)
                Me._Fecha_Inclusion = Value
                RaiseEvent Fecha_InclusionChanged()
            End If
        End Set
    End Property

    Public Event Fecha_InvestigacionChanging(ByVal Value As DateTime)
    Public Event Fecha_InvestigacionChanged()

    Public Property Fecha_Investigacion() As DateTime
        Get
            Return Me._Fecha_Investigacion
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_Investigacion <> Value Then
                RaiseEvent Fecha_InvestigacionChanging(Value)
                Me._Fecha_Investigacion = Value
                RaiseEvent Fecha_InvestigacionChanged()
            End If
        End Set
    End Property

    Public Event FuenteChanging(ByVal Value As String)
    Public Event FuenteChanged()

    Public Property Fuente() As String
        Get
            Return Me._Fuente
        End Get
        Set(ByVal Value As String)
            If _Fuente <> Value Then
                RaiseEvent FuenteChanging(Value)
                Me._Fuente = Value
                RaiseEvent FuenteChanged()
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

    Public ReadOnly Property Fecha_InclusionAjustada() As DateTime
        Get
            If Fecha_Inclusion.ToString.Trim = "01/01/0001 12:00:00 a.m." Then
                Return Nothing
            Else
                Return Fecha_Inclusion
            End If
        End Get
    End Property

    Public ReadOnly Property Declaracion() As DeclaracionBrl
        Get
            Return DeclaracionBrl.CargarPorID(Id_Declaracion)
        End Get
    End Property

    Public ReadOnly Property EstadoUnidad() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_EstadoUnidad)
        End Get
    End Property

    Public ReadOnly Property Unidad() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Unidad)
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
            Me.ID = Declaracion_UnidadesDAL.Insertar(Id_Declaracion, Id_Unidad, Id_EstadoUnidad, Fecha_Inclusion, Fecha_Investigacion, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Fecha_Cierre, Cierre, Fuente)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            Declaracion_UnidadesDAL.Actualizar(ID, Id_Declaracion, Id_Unidad, Id_EstadoUnidad, Fecha_Inclusion, Fecha_Investigacion, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Fecha_Cierre, Cierre, Fuente)
            RaiseEvent Updated()
        End If
        RaiseEvent Saved()

    End Sub

    Public Sub Eliminar()
        Dim totalHijos As Long = 0
        If Me.ID <> Nothing Then
            RaiseEvent Deleting()
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            Declaracion_UnidadesDAL.Eliminar(Me.ID)
            RaiseEvent Deleted()

        End If
    End Sub

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Declaracion_UnidadesBrl

        Dim objDeclaracion_Unidades As New Declaracion_UnidadesBrl

        With objDeclaracion_Unidades
            .ID = fila("Id")
            .Id_Declaracion = isDBNullToNothing(fila("Id_Declaracion"))
            .Id_Unidad = isDBNullToNothing(fila("Id_Unidad"))
            .Id_EstadoUnidad = isDBNullToNothing(fila("Id_EstadoUnidad"))
            .Fecha_Inclusion = isDBNullToNothing(fila("Fecha_Inclusion"))
            .Fecha_Investigacion = isDBNullToNothing(fila("Fecha_Investigacion"))
            .Fecha_Creacion = isDBNullToNothing(fila("Fecha_Creacion"))
            .Id_Usuario_Creacion = isDBNullToNothing(fila("Id_Usuario_Creacion"))
            .Fecha_Modificacion = isDBNullToNothing(fila("Fecha_Modificacion"))
            .Id_Usuario_Modificacion = isDBNullToNothing(fila("Id_Usuario_Modificacion"))
            .Fecha_Cierre = isDBNullToNothing(fila("Fecha_Cierre"))
            .Cierre = isDBNullToNothing(fila("Cierre"))
            .Fuente = isDBNullToNothing(fila("Fuente"))
        End With

        Return objDeclaracion_Unidades

    End Function

    Public Shared Event LoadingDeclaracion_UnidadesList(ByVal LoadType As String)
    Public Shared Event LoadedDeclaracion_UnidadesList(ByVal target As List(Of Declaracion_UnidadesBrl), ByVal LoadType As String)

    Public Shared Function CargarTodos() As List(Of Declaracion_UnidadesBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Declaracion_UnidadesBrl)

        RaiseEvent LoadingDeclaracion_UnidadesList("CargarTodos")

        dsDatos = Declaracion_UnidadesDAL.CargarTodos()

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracion_UnidadesList(lista, "CargarTodos")

        Return lista

    End Function

    Public Shared Event CargandoPorId(ByVal id As Int32)
    Public Shared Event CargadoPorId(ByVal target As Declaracion_UnidadesBrl)

    Public Shared Function CargarPorID(ByVal ID As Int32) As Declaracion_UnidadesBrl

        Dim dsDatos As System.Data.DataSet
        Dim objDeclaracion_Unidades As Declaracion_UnidadesBrl = Nothing
        dsDatos = Declaracion_UnidadesDAL.CargarPorID(ID)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objDeclaracion_Unidades = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objDeclaracion_Unidades

    End Function

    Public Shared Function CargarPorId_Declaracion(ByVal Id_Declaracion As Int32) As List(Of Declaracion_UnidadesBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Declaracion_UnidadesBrl)
        RaiseEvent LoadingDeclaracion_UnidadesList("CargarPorId_Declaracion")
        dsDatos = Declaracion_UnidadesDAL.CargarPorId_Declaracion(Id_Declaracion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedDeclaracion_UnidadesList(lista, "CargarPorId_Declaracion")
        Return lista

    End Function

    Public Shared Function CargarPorId_EstadoUnidad(ByVal Id_EstadoUnidad As Int32) As List(Of Declaracion_UnidadesBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Declaracion_UnidadesBrl)
        RaiseEvent LoadingDeclaracion_UnidadesList("CargarPorId_EstadoUnidad")
        dsDatos = Declaracion_UnidadesDAL.CargarPorId_EstadoUnidad(Id_EstadoUnidad)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedDeclaracion_UnidadesList(lista, "CargarPorId_EstadoUnidad")
        Return lista

    End Function

    Public Shared Function CargarPorId_Unidad(ByVal Id_Unidad As Int32) As List(Of Declaracion_UnidadesBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Declaracion_UnidadesBrl)
        RaiseEvent LoadingDeclaracion_UnidadesList("CargarPorId_Unidad")
        dsDatos = Declaracion_UnidadesDAL.CargarPorId_Unidad(Id_Unidad)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedDeclaracion_UnidadesList(lista, "CargarPorId_Unidad")

        Return lista

    End Function

    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As Int32) As List(Of Declaracion_UnidadesBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Declaracion_UnidadesBrl)
        RaiseEvent LoadingDeclaracion_UnidadesList("CargarPorId_Usuario_Creacion")
        dsDatos = Declaracion_UnidadesDAL.CargarPorId_Usuario_Creacion(Id_Usuario_Creacion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedDeclaracion_UnidadesList(lista, "CargarPorId_Usuario_Creacion")
        Return lista

    End Function

    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As Int32) As List(Of Declaracion_UnidadesBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Declaracion_UnidadesBrl)
        RaiseEvent LoadingDeclaracion_UnidadesList("CargarPorId_Usuario_Modificacion")
        dsDatos = Declaracion_UnidadesDAL.CargarPorId_Usuario_Modificacion(Id_Usuario_Modificacion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedDeclaracion_UnidadesList(lista, "CargarPorId_Usuario_Modificacion")
        Return lista
    End Function

End Class


