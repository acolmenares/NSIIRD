Imports ingNovar.Utilidades2
imports system.data
Imports system.collections.generic

Partial Public Class Declaracion_EstadosBrl

    Private _Id As Int32
    Private _Id_Declaracion As Int32
    Private _Id_Tipo_Estado As Int32
    Private _Id_Como_Estado As Int32
    Private _Fecha As DateTime
    Private _Fecha_Creacion As DateTime
    Private _Id_Usuario_Creacion As Int32
    Private _Fecha_Modificacion As DateTime
    Private _Id_Usuario_Modificacion As Int32
    Private _Fecha_Cierre As DateTime
    Private _Cierre As Boolean
    Private _Id_Programa As Int32
    Private _Id_Asistio As Int32
    Private _Id_Motivo_NoAtencion As Int32

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

    Public Event Id_Tipo_EstadoChanging(ByVal Value As Int32)
    Public Event Id_Tipo_EstadoChanged()

    Public Property Id_Tipo_Estado() As Int32
        Get
            Return Me._Id_Tipo_Estado
        End Get
        Set(ByVal Value As Int32)
            If _Id_Tipo_Estado <> Value Then
                RaiseEvent Id_Tipo_EstadoChanging(Value)
                Me._Id_Tipo_Estado = Value
                RaiseEvent Id_Tipo_EstadoChanged()
            End If
        End Set
    End Property

    Public Event Id_Como_EstadoChanging(ByVal Value As Int32)
    Public Event Id_Como_EstadoChanged()

    Public Property Id_Como_Estado() As Int32
        Get
            Return Me._Id_Como_Estado
        End Get
        Set(ByVal Value As Int32)
            If _Id_Como_Estado <> Value Then
                RaiseEvent Id_Como_EstadoChanging(Value)
                Me._Id_Como_Estado = Value
                RaiseEvent Id_Como_EstadoChanged()
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

    Public Event Id_ProgramaChanging(ByVal Value As Int32)
    Public Event Id_ProgramaChanged()

    Public Property Id_Programa() As Int32
        Get
            Return Me._Id_Programa
        End Get
        Set(ByVal Value As Int32)
            If _Id_Programa <> Value Then
                RaiseEvent Id_ProgramaChanging(Value)
                Me._Id_Programa = Value
                RaiseEvent Id_ProgramaChanged()
            End If
        End Set
    End Property

    Public Event Id_AsistioChanging(ByVal Value As Int32)
    Public Event Id_AsistioChanged()

    Public Property Id_Asistio() As Int32
        Get
            Return Me._Id_Asistio
        End Get
        Set(ByVal Value As Int32)
            If _Id_Asistio <> Value Then
                RaiseEvent Id_AsistioChanging(Value)
                Me._Id_Asistio = Value
                RaiseEvent Id_AsistioChanged()
            End If
        End Set
    End Property

    Public Event Id_Motivo_NoAtencionChanging(ByVal Value As Int32)
    Public Event Id_Motivo_NoAtencionChanged()

    Public Property Id_Motivo_NoAtencion() As Int32
        Get
            Return Me._Id_Motivo_NoAtencion
        End Get
        Set(ByVal Value As Int32)
            If _Id_Motivo_NoAtencion <> Value Then
                RaiseEvent Id_Motivo_NoAtencionChanging(Value)
                Me._Id_Motivo_NoAtencion = Value
                RaiseEvent Id_Motivo_NoAtencionChanged()
            End If
        End Set
    End Property

    Public ReadOnly Property ComoEstado() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Como_Estado)
        End Get
    End Property

    Public ReadOnly Property Declaracion() As DeclaracionBrl
        Get
            Return DeclaracionBrl.CargarPorID(Id_Declaracion)
        End Get
    End Property

    Public ReadOnly Property TipoEstado() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Tipo_Estado)
        End Get
    End Property

    Public ReadOnly Property Programa() As ProgramacionBrl
        Get
            Return ProgramacionBrl.CargarPorID(Id_Programa)
        End Get
    End Property

    Public ReadOnly Property Asistio() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Asistio)
        End Get
    End Property

    Public ReadOnly Property AsistioEstado As String
        Get
            If Asistio Is Nothing Then
                Return ""
            Else
                Return Asistio.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property ProgramaAsistio As String
        Get
            If Programa Is Nothing Then
                Return ""
            Else
                Return Programa.Numero
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
            Me.ID = Declaracion_EstadosDAL.Insertar(Id_Declaracion, Id_Tipo_Estado, Id_Como_Estado, Fecha, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Fecha_Cierre, Cierre, Id_Programa, Id_Asistio, Id_Motivo_NoAtencion)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            Declaracion_EstadosDAL.Actualizar(ID, Id_Declaracion, Id_Tipo_Estado, Id_Como_Estado, Fecha, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Fecha_Cierre, Cierre, Id_Programa, Id_Asistio, Id_Motivo_NoAtencion)
            RaiseEvent Updated()
        End If

        RaiseEvent Saved()

    End Sub

    Public Sub Eliminar()
        Dim totalHijos As Long = 0
        If Me.ID <> Nothing Then

            RaiseEvent Deleting()
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            Declaracion_EstadosDAL.Eliminar(Me.ID)
            RaiseEvent Deleted()

        End If
    End Sub

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Declaracion_EstadosBrl

        Dim objDeclaracion_Estados As New Declaracion_EstadosBrl

        With objDeclaracion_Estados
            .ID = fila("Id")
            .Id_Declaracion = isDBNullToNothing(fila("Id_Declaracion"))
            .Id_Tipo_Estado = isDBNullToNothing(fila("Id_Tipo_Estado"))
            .Id_Como_Estado = isDBNullToNothing(fila("Id_Como_Estado"))
            .Fecha = isDBNullToNothing(fila("Fecha"))
            .Fecha_Creacion = isDBNullToNothing(fila("Fecha_Creacion"))
            .Id_Usuario_Creacion = isDBNullToNothing(fila("Id_Usuario_Creacion"))
            .Fecha_Modificacion = isDBNullToNothing(fila("Fecha_Modificacion"))
            .Id_Usuario_Modificacion = isDBNullToNothing(fila("Id_Usuario_Modificacion"))
            .Fecha_Cierre = isDBNullToNothing(fila("Fecha_Cierre"))
            .Cierre = isDBNullToNothing(fila("Cierre"))
            .Id_Programa = isDBNullToNothing(fila("Id_Programa"))
            .Id_Asistio = isDBNullToNothing(fila("Id_Asistio"))
            .Id_Motivo_NoAtencion = isDBNullToNothing(fila("Id_Motivo_NoAtencion"))

        End With

        Return objDeclaracion_Estados

    End Function

    Public Shared Event LoadingDeclaracion_EstadosList(ByVal LoadType As String)
    Public Shared Event LoadedDeclaracion_EstadosList(ByVal target As List(Of Declaracion_EstadosBrl), ByVal LoadType As String)

    Public Shared Function CargarTodos() As List(Of Declaracion_EstadosBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Declaracion_EstadosBrl)

        RaiseEvent LoadingDeclaracion_EstadosList("CargarTodos")

        dsDatos = Declaracion_EstadosDAL.CargarTodos()

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracion_EstadosList(lista, "CargarTodos")

        Return lista

    End Function

    Public Shared Event CargandoPorId(ByVal id As Int32)
    Public Shared Event CargadoPorId(ByVal target As Declaracion_EstadosBrl)

    Public Shared Function CargarPorID(ByVal ID As Int32) As Declaracion_EstadosBrl

        Dim dsDatos As System.Data.DataSet
        Dim objDeclaracion_Estados As Declaracion_EstadosBrl = Nothing
        dsDatos = Declaracion_EstadosDAL.CargarPorID(ID)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objDeclaracion_Estados = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objDeclaracion_Estados

    End Function

    Public Shared Function CargarPorId_Como_Estado(ByVal Id_Como_Estado As Int32) As List(Of Declaracion_EstadosBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Declaracion_EstadosBrl)

        RaiseEvent LoadingDeclaracion_EstadosList("CargarPorId_Como_Estado")

        dsDatos = Declaracion_EstadosDAL.CargarPorId_Como_Estado(Id_Como_Estado)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracion_EstadosList(lista, "CargarPorId_Como_Estado")

        Return lista

    End Function

    Public Shared Function CargarPorId_Declaracion(ByVal Id_Declaracion As Int32) As List(Of Declaracion_EstadosBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Declaracion_EstadosBrl)

        RaiseEvent LoadingDeclaracion_EstadosList("CargarPorId_Declaracion")

        dsDatos = Declaracion_EstadosDAL.CargarPorId_Declaracion(Id_Declaracion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracion_EstadosList(lista, "CargarPorId_Declaracion")

        Return lista

    End Function

    Public Shared Function CargarPorId_Tipo_Estado(ByVal Id_Tipo_Estado As Int32) As List(Of Declaracion_EstadosBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Declaracion_EstadosBrl)

        RaiseEvent LoadingDeclaracion_EstadosList("CargarPorId_Tipo_Estado")

        dsDatos = Declaracion_EstadosDAL.CargarPorId_Tipo_Estado(Id_Tipo_Estado)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracion_EstadosList(lista, "CargarPorId_Tipo_Estado")

        Return lista

    End Function

    Public Shared Function CargarPorId_Programa(ByVal Id_Programa As Int32) As List(Of Declaracion_EstadosBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Declaracion_EstadosBrl)
        dsDatos = Declaracion_EstadosDAL.CargarPorId_Programa(Id_Programa)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function


End Class


