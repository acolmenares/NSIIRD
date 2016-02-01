Imports ingNovar.Utilidades2
imports system.data
Imports system.Collections.generic
Imports SeguridadUsuarios

Partial Public Class Declaracion_BienesBrl

    Private _Id As Int32
    Private _Id_Declaracion As Int32
    Private _Id_Bienes As Int32
    Private _Tipo As String
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

    Public Event Id_BienesChanging(ByVal Value As Int32)
    Public Event Id_BienesChanged()

    Public Property Id_Bienes() As Int32
        Get
            Return Me._Id_Bienes
        End Get
        Set(ByVal Value As Int32)
            If _Id_Bienes <> Value Then
                RaiseEvent Id_BienesChanging(Value)
                Me._Id_Bienes = Value
                RaiseEvent Id_BienesChanged()
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

    Public ReadOnly Property Declaracion() As DeclaracionBrl
        Get
            Return DeclaracionBrl.CargarPorID(Id_Declaracion)
        End Get
    End Property

    Public ReadOnly Property SubTablasBienes() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Bienes)
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
            Me.ID = Declaracion_BienesDAL.Insertar(Id_Declaracion, Id_Bienes, Tipo, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Fecha_Cierre, Cierre)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            Declaracion_BienesDAL.Actualizar(ID, Id_Declaracion, Id_Bienes, Tipo, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Fecha_Cierre, Cierre)
            RaiseEvent Updated()
        End If


        RaiseEvent Saved()

    End Sub

    Public Sub Eliminar()
        Dim totalHijos As Long = 0
        If Me.ID <> Nothing Then

            RaiseEvent Deleting()
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            Declaracion_BienesDAL.Eliminar(Me.ID)

            RaiseEvent Deleted()

        End If
    End Sub

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Declaracion_BienesBrl

        Dim objDeclaracion_Bienes As New Declaracion_BienesBrl

        With objDeclaracion_Bienes
            .ID = fila("Id")
            .Id_Declaracion = isDBNullToNothing(fila("Id_Declaracion"))
            .Id_Bienes = isDBNullToNothing(fila("Id_Bienes"))
            .Tipo = isDBNullToNothing(fila("Tipo"))
            .Fecha_Creacion = isDBNullToNothing(fila("Fecha_Creacion"))
            .Id_Usuario_Creacion = isDBNullToNothing(fila("Id_Usuario_Creacion"))
            .Fecha_Modificacion = isDBNullToNothing(fila("Fecha_Modificacion"))
            .Id_Usuario_Modificacion = isDBNullToNothing(fila("Id_Usuario_Modificacion"))
            .Fecha_Cierre = isDBNullToNothing(fila("Fecha_Cierre"))
            .Cierre = isDBNullToNothing(fila("Cierre"))
        End With

        Return objDeclaracion_Bienes

    End Function

    Public Shared Event LoadingDeclaracion_BienesList(ByVal LoadType As String)
    Public Shared Event LoadedDeclaracion_BienesList(ByVal target As List(Of Declaracion_BienesBrl), ByVal LoadType As String)

    Public Shared Function CargarTodos() As List(Of Declaracion_BienesBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Declaracion_BienesBrl)

        RaiseEvent LoadingDeclaracion_BienesList("CargarTodos")

        dsDatos = Declaracion_BienesDAL.CargarTodos()

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracion_BienesList(lista, "CargarTodos")

        Return lista

    End Function

    Public Shared Event CargandoPorId(ByVal id As Int32)
    Public Shared Event CargadoPorId(ByVal target As Declaracion_BienesBrl)

    Public Shared Function CargarPorID(ByVal ID As Int32) As Declaracion_BienesBrl

        Dim dsDatos As System.Data.DataSet
        Dim objDeclaracion_Bienes As Declaracion_BienesBrl = Nothing

        RaiseEvent CargandoPorId(ID)

        dsDatos = Declaracion_BienesDAL.CargarPorID(ID)

        If dsDatos.Tables(0).Rows.Count <> 0 Then objDeclaracion_Bienes = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))

        Return objDeclaracion_Bienes

    End Function

    Public Shared Function CargarPorId_Declaracion(ByVal Id_Declaracion As Int32) As List(Of Declaracion_BienesBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Declaracion_BienesBrl)

        RaiseEvent LoadingDeclaracion_BienesList("CargarPorId_Declaracion")

        dsDatos = Declaracion_BienesDAL.CargarPorId_Declaracion(Id_Declaracion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracion_BienesList(lista, "CargarPorId_Declaracion")

        Return lista

    End Function

    Public Shared Function CargarPorId_Bienes(ByVal Id_Bienes As Int32) As List(Of Declaracion_BienesBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Declaracion_BienesBrl)

        RaiseEvent LoadingDeclaracion_BienesList("CargarPorId_Bienes")

        dsDatos = Declaracion_BienesDAL.CargarPorId_Bienes(Id_Bienes)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracion_BienesList(lista, "CargarPorId_Bienes")

        Return lista

    End Function

    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As Int32) As List(Of Declaracion_BienesBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Declaracion_BienesBrl)

        RaiseEvent LoadingDeclaracion_BienesList("CargarPorId_Usuario_Creacion")

        dsDatos = Declaracion_BienesDAL.CargarPorId_Usuario_Creacion(Id_Usuario_Creacion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracion_BienesList(lista, "CargarPorId_Usuario_Creacion")

        Return lista

    End Function

    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As Int32) As List(Of Declaracion_BienesBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Declaracion_BienesBrl)

        RaiseEvent LoadingDeclaracion_BienesList("CargarPorId_Usuario_Modificacion")

        dsDatos = Declaracion_BienesDAL.CargarPorId_Usuario_Modificacion(Id_Usuario_Modificacion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracion_BienesList(lista, "CargarPorId_Usuario_Modificacion")

        Return lista

    End Function

    Public Shared Function CargarTodosPoridTipo(ByVal ID As Int32, ByVal tipo As String) As List(Of Declaracion_BienesBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Declaracion_BienesBrl)
        dsDatos = Declaracion_BienesDAL.CargarTodosPorIDTipo(ID, tipo)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function


End Class


