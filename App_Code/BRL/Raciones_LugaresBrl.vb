Imports ingNovar.Utilidades2
Imports System.Collections.Generic
Imports System.Data

Partial Public Class Raciones_LugaresBrl

    Private _Id As Int32
    Private _Id_Racion As Int32
    Private _Id_LugarEntrega As Int32

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

    Public Event Id_RacionChanging(ByVal Value As Int32)
    Public Event Id_RacionChanged()

    Public Property Id_Racion() As Int32
        Get
            Return Me._Id_Racion
        End Get
        Set(ByVal Value As Int32)
            If _Id_Racion <> Value Then
                RaiseEvent Id_RacionChanging(Value)
                Me._Id_Racion = Value
                RaiseEvent Id_RacionChanged()
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

    Public ReadOnly Property Lugar_Entrega() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_LugarEntrega)
        End Get
    End Property

    Public ReadOnly Property Racion() As RacionesBrl
        Get
            Return RacionesBrl.CargarPorID(Id_Racion)
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
            Me.ID = Raciones_LugaresDAL.Insertar(Id_Racion, Id_LugarEntrega)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            Raciones_LugaresDAL.Actualizar(ID, Id_Racion, Id_LugarEntrega)
            RaiseEvent Updated()
        End If

        RaiseEvent Saved()

    End Sub

    Public Sub Eliminar()
        Dim totalHijos As Long = 0
        If Me.ID <> Nothing Then

            RaiseEvent Deleting()
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            Raciones_LugaresDAL.Eliminar(Me.ID)

            RaiseEvent Deleted()

        End If
    End Sub

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Raciones_LugaresBrl

        Dim objRaciones_Regionales As New Raciones_LugaresBrl
        With objRaciones_Regionales
            .ID = fila("Id")
            .Id_Racion = isDBNullToNothing(fila("Id_Racion"))
            .Id_LugarEntrega = isDBNullToNothing(fila("Id_LugarEntrega"))
        End With
        Return objRaciones_Regionales

    End Function

    Public Shared Event LoadingRaciones_regionalesList(ByVal LoadType As String)
    Public Shared Event LoadedRaciones_RegionalesList(ByVal target As List(Of Raciones_LugaresBrl), ByVal LoadType As String)

    Public Shared Function CargarTodos() As List(Of Raciones_LugaresBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Raciones_LugaresBrl)

        RaiseEvent LoadingRaciones_regionalesList("CargarTodos")

        dsDatos = Raciones_LugaresDAL.CargarTodos()

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedRaciones_RegionalesList(lista, "CargarTodos")

        Return lista

    End Function

    Public Shared Event LoadingPorId(ByVal id As Int32)
    Public Shared Event LoadedPorId(ByVal target As Raciones_LugaresBrl)

    Public Shared Function CargarPorID(ByVal ID As Int32) As Raciones_LugaresBrl

        Dim dsDatos As System.Data.DataSet
        Dim objRaciones_Regionales As Raciones_LugaresBrl = Nothing
        dsDatos = Raciones_LugaresDAL.CargarPorID(ID)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objRaciones_Regionales = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objRaciones_Regionales

    End Function

    Public Shared Function CargarPorId_LugarEntrega(ByVal Id_LugarEntrega As Int32) As List(Of Raciones_LugaresBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Raciones_LugaresBrl)

        dsDatos = Raciones_LugaresDAL.CargarPorId_LugarEntrega(Id_LugarEntrega)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function

    Public Shared Function CargarPorId_Racion(ByVal Id_Racion As Int32) As List(Of Raciones_LugaresBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Raciones_LugaresBrl)

        dsDatos = Raciones_LugaresDAL.CargarPorId_Racion(Id_Racion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function

End Class


