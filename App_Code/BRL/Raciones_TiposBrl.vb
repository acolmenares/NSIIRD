Imports ingNovar.Utilidades2
Imports System.Collections.Generic
Imports System.Data

Partial Public Class Raciones_TiposBrl

    Private _Id As Int32
    Private _Id_Racion As Int32
    Private _Tipo As Int32

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

    Public Event TipoChanging(ByVal Value As Int32)
    Public Event TipoChanged()

    Public Property Tipo() As Int32
        Get
            Return Me._Tipo
        End Get
        Set(ByVal Value As Int32)
            If _Tipo <> Value Then
                RaiseEvent TipoChanging(Value)
                Me._Tipo = Value
                RaiseEvent TipoChanged()
            End If
        End Set
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
            Me.ID = Raciones_TiposDAL.Insertar(Id_Racion, Tipo)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            Raciones_TiposDAL.Actualizar(ID, Id_Racion, Tipo)
            RaiseEvent Updated()
        End If

        RaiseEvent Saved()

    End Sub

    Public Sub Eliminar()
        Dim totalHijos As Long = 0
        If Me.ID <> Nothing Then

            RaiseEvent Deleting()
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            Raciones_TiposDAL.Eliminar(Me.ID)

            RaiseEvent Deleted()

        End If
    End Sub

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Raciones_TiposBrl

        Dim objRaciones_Tipos As New Raciones_TiposBrl
        With objRaciones_Tipos
            .ID = fila("Id")
            .Id_Racion = isDBNullToNothing(fila("Id_Racion"))
            .Tipo = isDBNullToNothing(fila("Tipo"))
        End With
        Return objRaciones_Tipos

    End Function

    Public Shared Event LoadingRaciones_regionalesList(ByVal LoadType As String)
    Public Shared Event LoadedRaciones_RegionalesList(ByVal target As List(Of Raciones_TiposBrl), ByVal LoadType As String)

    Public Shared Function CargarTodos() As List(Of Raciones_TiposBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Raciones_TiposBrl)

        dsDatos = Raciones_TiposDAL.CargarTodos()

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next


        Return lista

    End Function

    Public Shared Event LoadingPorId(ByVal id As Int32)
    Public Shared Event LoadedPorId(ByVal target As Raciones_TiposBrl)

    Public Shared Function CargarPorID(ByVal ID As Int32) As Raciones_TiposBrl

        Dim dsDatos As System.Data.DataSet
        Dim objRaciones_Tipos As Raciones_TiposBrl = Nothing
        dsDatos = Raciones_TiposDAL.CargarPorID(ID)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objRaciones_Tipos = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objRaciones_Tipos

    End Function

    Public Shared Function CargarPorId_Racion(ByVal Id_Racion As Int32) As List(Of Raciones_TiposBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Raciones_TiposBrl)

        dsDatos = Raciones_TiposDAL.CargarPorId_Racion(Id_Racion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function

End Class


