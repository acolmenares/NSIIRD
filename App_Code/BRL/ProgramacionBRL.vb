Imports ingNovar.Utilidades2
Imports System.Data
Imports System.Collections.Generic
Imports SeguridadUsuarios

Partial Public Class ProgramacionBrl

    Private _Id As Int32
    Private _Fecha As DateTime
    Private _Id_Regional As Int32
    Private _Numero As String
    Private _Id_Estado As Int32
    Private _Id_Grupo As Int32
    Private _Id_LugarEntrega As Int32
    Private _Id_TipoEntrega As Int32
    Private _Id_Bodega As Int32


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

    Public Event Id_RegionalChanging(ByVal Value As Int32)
    Public Event Id_RegionalChanged()

    Public Property Id_Regional() As Int32
        Get
            Return Me._Id_Regional
        End Get
        Set(ByVal Value As Int32)
            If _Id_Regional <> Value Then
                RaiseEvent Id_RegionalChanging(Value)
                Me._Id_Regional = Value
                RaiseEvent Id_RegionalChanged()
            End If
        End Set
    End Property

    Public Event NumeroChanging(ByVal Value As String)
    Public Event NumeroChanged()

    Public Property Numero() As String
        Get
            Return Me._Numero
        End Get
        Set(ByVal Value As String)
            If _Numero <> Value Then
                RaiseEvent NumeroChanging(Value)
                Me._Numero = Value
                RaiseEvent NumeroChanged()
            End If
        End Set
    End Property

    Public Event Id_EstadoChanging(ByVal Value As Int32)
    Public Event Id_EstadoChanged()

    Public Property Id_Estado() As Int32
        Get
            Return Me._Id_Estado
        End Get
        Set(ByVal Value As Int32)
            If _Id_Estado <> Value Then
                RaiseEvent Id_EstadoChanging(Value)
                Me._Id_Estado = Value
                RaiseEvent Id_EstadoChanged()
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

    Public Event Id_LugarEntregaChanging(ByVal Value As Int32)
    Public Event Id_LugarEntregaChanged()

    Public Property Id_LugarEntrega() As Int32
        Get
            Return Me._Id_LugarEntrega
        End Get
        Set(ByVal Value As Int32)
            If _Id_LugarEntrega <> Value Then
                RaiseEvent Id_LugarEntregaChanging(Value)
                Me._Id_LugarEntrega = Value
                RaiseEvent Id_LugarEntregaChanged()
            End If
        End Set
    End Property

    Public Event Id_TipoEntregaChanging(ByVal Value As Int32)
    Public Event Id_TipoEntregaChanged()

    Public Property Id_TipoEntrega() As Int32
        Get
            Return Me._Id_TipoEntrega
        End Get
        Set(ByVal Value As Int32)
            If _Id_TipoEntrega <> Value Then
                RaiseEvent Id_TipoEntregaChanging(Value)
                Me._Id_TipoEntrega = Value
                RaiseEvent Id_TipoEntregaChanged()
            End If
        End Set
    End Property

    Public Event Id_BodegaChanging(ByVal Value As Int32)
    Public Event Id_BodegaChanged()

    Public Property Id_Bodega() As Int32
        Get
            Return Me._Id_Bodega
        End Get
        Set(ByVal Value As Int32)
            If _Id_Bodega <> Value Then
                RaiseEvent Id_BodegaChanging(Value)
                Me._Id_Bodega = Value
                RaiseEvent Id_BodegaChanged()
            End If
        End Set
    End Property

    Public ReadOnly Property Estados() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Estado)
        End Get
    End Property

    Public ReadOnly Property Grupo() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Grupo)
        End Get
    End Property

    Public ReadOnly Property Regionales() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Regional)
        End Get
    End Property

    Public ReadOnly Property LugarEntrega() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_LugarEntrega)
        End Get
    End Property

    Public ReadOnly Property TipoEntrega() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_TipoEntrega)
        End Get
    End Property

    Public ReadOnly Property Bodegas() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Bodega)
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
            Me.ID = ProgramacionDAL.Insertar(Fecha, Id_Regional, Numero, Id_Estado, Id_Grupo, Id_LugarEntrega, Id_TipoEntrega, Id_Bodega)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            ProgramacionDAL.Actualizar(ID, Fecha, Id_Regional, Numero, Id_Estado, Id_Grupo, Id_LugarEntrega, Id_TipoEntrega, Id_Bodega)
            RaiseEvent Updated()
        End If

        RaiseEvent Saved()

    End Sub

    Public Sub Eliminar()
        Dim totalHijos As Long = 0
        If Me.ID <> Nothing Then

            RaiseEvent Deleting()
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            ProgramacionDAL.Eliminar(Me.ID)
            RaiseEvent Deleted()

        End If
    End Sub

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As ProgramacionBrl

        Dim objProgramacion As New ProgramacionBrl

        With objProgramacion
            .ID = fila("Id")
            .Fecha = isDBNullToNothing(fila("Fecha"))
            .Id_Regional = isDBNullToNothing(fila("Id_Regional"))
            .Numero = isDBNullToNothing(fila("Numero"))
            .Id_Estado = isDBNullToNothing(fila("Id_Estado"))
            .Id_Grupo = isDBNullToNothing(fila("Id_Grupo"))
            .Id_LugarEntrega = isDBNullToNothing(fila("Id_LugarEntrega"))
            .Id_TipoEntrega = isDBNullToNothing(fila("Id_TipoEntrega"))
            .Id_Bodega = isDBNullToNothing(fila("Id_Bodega"))
        End With

        Return objProgramacion

    End Function

    Public Shared Event LoadingProgramacionList(ByVal LoadType As String)
    Public Shared Event LoadedProgramacionList(ByVal target As List(Of ProgramacionBrl), ByVal LoadType As String)

    Public Shared Function CargarTodos() As List(Of ProgramacionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of ProgramacionBrl)

        RaiseEvent LoadingProgramacionList("CargarTodos")

        dsDatos = ProgramacionDAL.CargarTodos()

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedProgramacionList(lista, "CargarTodos")

        Return lista

    End Function

    Public Shared Event CargandoPorId(ByVal id As Int32)
    Public Shared Event CargadoPorId(ByVal target As ProgramacionBrl)

    Public Shared Function CargarPorID(ByVal ID As Int32) As ProgramacionBrl

        Dim dsDatos As System.Data.DataSet
        Dim objProgramacion As ProgramacionBrl = Nothing
        dsDatos = ProgramacionDAL.CargarPorID(ID)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objProgramacion = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objProgramacion

    End Function

    Public Shared Function CargarPorId_Estado(ByVal Id_Estado As Int32) As List(Of ProgramacionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of ProgramacionBrl)

        RaiseEvent LoadingProgramacionList("CargarPorId_Estado")

        dsDatos = ProgramacionDAL.CargarPorId_Estado(Id_Estado)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedProgramacionList(lista, "CargarPorId_Estado")

        Return lista

    End Function

    Public Shared Function CargarPorId_Grupo(ByVal Id_Grupo As Int32) As List(Of ProgramacionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of ProgramacionBrl)

        RaiseEvent LoadingProgramacionList("CargarPorId_Grupo")

        dsDatos = ProgramacionDAL.CargarPorId_Grupo(Id_Grupo)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedProgramacionList(lista, "CargarPorId_Grupo")

        Return lista

    End Function

    Public Shared Function CargarPorId_Regional(ByVal Id_Regional As Int32) As List(Of ProgramacionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of ProgramacionBrl)

        RaiseEvent LoadingProgramacionList("CargarPorId_Regional")

        dsDatos = ProgramacionDAL.CargarPorId_Regional(Id_Regional)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedProgramacionList(lista, "CargarPorId_Regional")

        Return lista

    End Function

    Public Shared Function CargarPorId_LugarEntrega(ByVal Id_LugarEntrega As Int32) As List(Of ProgramacionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of ProgramacionBrl)

        RaiseEvent LoadingProgramacionList("CargarPorId_LugarEntrega")

        dsDatos = ProgramacionDAL.CargarPorId_LugarEntrega(Id_LugarEntrega)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedProgramacionList(lista, "CargarPorId_LugarEntrega")

        Return lista

    End Function

    Public Shared Function Cargarbusqueda(ByVal Id_Regional As Int32, ByVal Id_LugarEntrega As Int32, ByVal Id_Programa As Integer, ByVal Fecha_Inicial_Programacion As String, ByVal Fecha_Final_Programacion As String) As List(Of ProgramacionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of ProgramacionBrl)
        dsDatos = ProgramacionDAL.CargarporBusqueda(Id_Regional, Id_LugarEntrega, Id_Programa, Fecha_Inicial_Programacion, Fecha_Final_Programacion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarbusquedaPorEstado(ByVal Id_Regional As Int32, ByVal Id_grupo As Int32, ByVal Id_Lugar_Entrega As Integer, ByVal Id_Estado As Int32) As List(Of ProgramacionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of ProgramacionBrl)
        dsDatos = ProgramacionDAL.CargarporBusquedaPorEstado(Id_Regional, Id_grupo, Id_Lugar_Entrega, Id_Estado)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

End Class