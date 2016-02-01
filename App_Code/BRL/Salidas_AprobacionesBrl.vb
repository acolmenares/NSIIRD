Imports ingNovar.Utilidades2
Imports System.Data
Imports System.Collections.Generic

Partial Public Class Salidas_AprobacionesBrl

    Private _Id As Int32
    Private _Id_Salida As Int32
    Private _Aprobacion_Logistica_Oficina As Boolean
    Private _Fecha_ALO As DateTime
    Private _Aprobacion_Finanzas_Oficina As Boolean
    Private _Fecha_AFO As DateTime
    Private _Aprobacion_Coordinador_Oficina As Boolean
    Private _Fecha_ACO As DateTime
    Private _Aprobacion_Coordinador_Logistica As Boolean
    Private _Fecha_ACL As DateTime
    Private _Aprobacion_Director_Financiero As Boolean
    Private _Fecha_ADF As DateTime
    Private _Aprobacion_Director_Pais As Boolean
    Private _Fecha_ADP As DateTime
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

    Public Event Aprobacion_Logistica_OficinaChanging(ByVal Value As Boolean)
    Public Event Aprobacion_Logistica_OficinaChanged()

    Public Property Aprobacion_Logistica_Oficina() As Boolean
        Get
            Return Me._Aprobacion_Logistica_Oficina
        End Get
        Set(ByVal Value As Boolean)
            If _Aprobacion_Logistica_Oficina <> Value Then
                RaiseEvent Aprobacion_Logistica_OficinaChanging(Value)
                Me._Aprobacion_Logistica_Oficina = Value
                RaiseEvent Aprobacion_Logistica_OficinaChanged()
            End If
        End Set
    End Property

    Public Event Fecha_ALOChanging(ByVal Value As DateTime)
    Public Event Fecha_ALOChanged()

    Public Property Fecha_ALO() As DateTime
        Get
            Return Me._Fecha_ALO
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_ALO <> Value Then
                RaiseEvent Fecha_ALOChanging(Value)
                Me._Fecha_ALO = Value
                RaiseEvent Fecha_ALOChanged()
            End If
        End Set
    End Property

    Public Event Aprobacion_Finanzas_OficinaChanging(ByVal Value As Boolean)
    Public Event Aprobacion_Finanzas_OficinaChanged()

    Public Property Aprobacion_Finanzas_Oficina() As Boolean
        Get
            Return Me._Aprobacion_Finanzas_Oficina
        End Get
        Set(ByVal Value As Boolean)
            If _Aprobacion_Finanzas_Oficina <> Value Then
                RaiseEvent Aprobacion_Finanzas_OficinaChanging(Value)
                Me._Aprobacion_Finanzas_Oficina = Value
                RaiseEvent Aprobacion_Finanzas_OficinaChanged()
            End If
        End Set
    End Property

    Public Event Fecha_AFOChanging(ByVal Value As DateTime)
    Public Event Fecha_AFOChanged()

    Public Property Fecha_AFO() As DateTime
        Get
            Return Me._Fecha_AFO
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_AFO <> Value Then
                RaiseEvent Fecha_AFOChanging(Value)
                Me._Fecha_AFO = Value
                RaiseEvent Fecha_AFOChanged()
            End If
        End Set
    End Property

    Public Event Aprobacion_Coordinador_OficinaChanging(ByVal Value As Boolean)
    Public Event Aprobacion_Coordinador_OficinaChanged()

    Public Property Aprobacion_Coordinador_Oficina() As Boolean
        Get
            Return Me._Aprobacion_Coordinador_Oficina
        End Get
        Set(ByVal Value As Boolean)
            If _Aprobacion_Coordinador_Oficina <> Value Then
                RaiseEvent Aprobacion_Coordinador_OficinaChanging(Value)
                Me._Aprobacion_Coordinador_Oficina = Value
                RaiseEvent Aprobacion_Coordinador_OficinaChanged()
            End If
        End Set
    End Property

    Public Event Fecha_ACOChanging(ByVal Value As DateTime)
    Public Event Fecha_ACOChanged()

    Public Property Fecha_ACO() As DateTime
        Get
            Return Me._Fecha_ACO
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_ACO <> Value Then
                RaiseEvent Fecha_ACOChanging(Value)
                Me._Fecha_ACO = Value
                RaiseEvent Fecha_ACOChanged()
            End If
        End Set
    End Property

    Public Event Aprobacion_Coordinador_LogisticaChanging(ByVal Value As Boolean)
    Public Event Aprobacion_Coordinador_LogisticaChanged()

    Public Property Aprobacion_Coordinador_Logistica() As Boolean
        Get
            Return Me._Aprobacion_Coordinador_Logistica
        End Get
        Set(ByVal Value As Boolean)
            If _Aprobacion_Coordinador_Logistica <> Value Then
                RaiseEvent Aprobacion_Coordinador_LogisticaChanging(Value)
                Me._Aprobacion_Coordinador_Logistica = Value
                RaiseEvent Aprobacion_Coordinador_LogisticaChanged()
            End If
        End Set
    End Property

    Public Event Fecha_ACLChanging(ByVal Value As DateTime)
    Public Event Fecha_ACLChanged()

    Public Property Fecha_ACL() As DateTime
        Get
            Return Me._Fecha_ACL
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_ACL <> Value Then
                RaiseEvent Fecha_ACLChanging(Value)
                Me._Fecha_ACL = Value
                RaiseEvent Fecha_ACLChanged()
            End If
        End Set
    End Property

    Public Event Aprobacion_Director_FinancieroChanging(ByVal Value As Boolean)
    Public Event Aprobacion_Director_FinancieroChanged()

    Public Property Aprobacion_Director_Financiero() As Boolean
        Get
            Return Me._Aprobacion_Director_Financiero
        End Get
        Set(ByVal Value As Boolean)
            If _Aprobacion_Director_Financiero <> Value Then
                RaiseEvent Aprobacion_Director_FinancieroChanging(Value)
                Me._Aprobacion_Director_Financiero = Value
                RaiseEvent Aprobacion_Director_FinancieroChanged()
            End If
        End Set
    End Property

    Public Event Fecha_ADFChanging(ByVal Value As DateTime)
    Public Event Fecha_ADFChanged()

    Public Property Fecha_ADF() As DateTime
        Get
            Return Me._Fecha_ADF
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_ADF <> Value Then
                RaiseEvent Fecha_ADFChanging(Value)
                Me._Fecha_ADF = Value
                RaiseEvent Fecha_ADFChanged()
            End If
        End Set
    End Property

    Public Event Aprobacion_Director_PaisChanging(ByVal Value As Boolean)
    Public Event Aprobacion_Director_PaisChanged()

    Public Property Aprobacion_Director_Pais() As Boolean
        Get
            Return Me._Aprobacion_Director_Pais
        End Get
        Set(ByVal Value As Boolean)
            If _Aprobacion_Director_Pais <> Value Then
                RaiseEvent Aprobacion_Director_PaisChanging(Value)
                Me._Aprobacion_Director_Pais = Value
                RaiseEvent Aprobacion_Director_PaisChanged()
            End If
        End Set
    End Property

    Public Event Fecha_ADPChanging(ByVal Value As DateTime)
    Public Event Fecha_ADPChanged()

    Public Property Fecha_ADP() As DateTime
        Get
            Return Me._Fecha_ADP
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_ADP <> Value Then
                RaiseEvent Fecha_ADPChanging(Value)
                Me._Fecha_ADP = Value
                RaiseEvent Fecha_ADPChanged()
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
            Me.ID = Salidas_AprobacionesDAL.Insertar(Id_Salida, Aprobacion_Logistica_Oficina, Fecha_ALO, Aprobacion_Finanzas_Oficina, Fecha_AFO, Aprobacion_Coordinador_Oficina, Fecha_ACO, Aprobacion_Coordinador_Logistica, Fecha_ACL, Aprobacion_Director_Financiero, Fecha_ADF, Aprobacion_Director_Pais, Fecha_ADP, Fecha_Cierre, Cierre)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            Salidas_AprobacionesDAL.Actualizar(ID, Id_Salida, Aprobacion_Logistica_Oficina, Fecha_ALO, Aprobacion_Finanzas_Oficina, Fecha_AFO, Aprobacion_Coordinador_Oficina, Fecha_ACO, Aprobacion_Coordinador_Logistica, Fecha_ACL, Aprobacion_Director_Financiero, Fecha_ADF, Aprobacion_Director_Pais, Fecha_ADP, Fecha_Cierre, Cierre)
            RaiseEvent Updated()
        End If
        RaiseEvent Saved()

    End Sub

    Public Sub Eliminar()
        Dim totalHijos As Long = 0
        If Me.ID <> Nothing Then

            RaiseEvent Deleting()
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            Salidas_AprobacionesDAL.Eliminar(Me.ID)
            RaiseEvent Deleted()

        End If
    End Sub

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Salidas_AprobacionesBrl

        Dim objSalidas_Aprobaciones As New Salidas_AprobacionesBrl

        With objSalidas_Aprobaciones
            .ID = fila("Id")
            .Id_Salida = isDBNullToNothing(fila("Id_Salida"))
            .Aprobacion_Logistica_Oficina = isDBNullToNothing(fila("Aprobacion_Logistica_Oficina"))
            .Fecha_ALO = isDBNullToNothing(fila("Fecha_ALO"))
            .Aprobacion_Finanzas_Oficina = isDBNullToNothing(fila("Aprobacion_Finanzas_Oficina"))
            .Fecha_AFO = isDBNullToNothing(fila("Fecha_AFO"))
            .Aprobacion_Coordinador_Oficina = isDBNullToNothing(fila("Aprobacion_Coordinador_Oficina"))
            .Fecha_ACO = isDBNullToNothing(fila("Fecha_ACO"))
            .Aprobacion_Coordinador_Logistica = isDBNullToNothing(fila("Aprobacion_Coordinador_Logistica"))
            .Fecha_ACL = isDBNullToNothing(fila("Fecha_ACL"))
            .Aprobacion_Director_Financiero = isDBNullToNothing(fila("Aprobacion_Director_Financiero"))
            .Fecha_ADF = isDBNullToNothing(fila("Fecha_ADF"))
            .Aprobacion_Director_Pais = isDBNullToNothing(fila("Aprobacion_Director_Pais"))
            .Fecha_ADP = isDBNullToNothing(fila("Fecha_ADP"))
            .Fecha_Cierre = isDBNullToNothing(fila("Fecha_Cierre"))
            .Cierre = isDBNullToNothing(fila("Cierre"))
        End With

        Return objSalidas_Aprobaciones

    End Function

    Public Shared Event LoadingSalidas_AprobacionesList(ByVal LoadType As String)
    Public Shared Event LoadedSalidas_AprobacionesList(ByVal target As List(Of Salidas_AprobacionesBrl), ByVal LoadType As String)

    Public Shared Function CargarTodos() As List(Of Salidas_AprobacionesBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Salidas_AprobacionesBrl)

        RaiseEvent LoadingSalidas_AprobacionesList("CargarTodos")
        dsDatos = Salidas_AprobacionesDAL.CargarTodos()
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedSalidas_AprobacionesList(lista, "CargarTodos")
        Return lista

    End Function

    Public Shared Event LoadingPorId(ByVal id As Int32)
    Public Shared Event LoadedPorId(ByVal target As Salidas_AprobacionesBrl)

    Public Shared Function CargarPorID(ByVal ID As Int32) As Salidas_AprobacionesBrl

        Dim dsDatos As System.Data.DataSet
        Dim objSalidas_Aprobaciones As Salidas_AprobacionesBrl = Nothing

        dsDatos = Salidas_AprobacionesDAL.CargarPorID(ID)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objSalidas_Aprobaciones = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objSalidas_Aprobaciones

    End Function

    Public Shared Function CargarPorId_Salida(ByVal Id_Salida As Int32) As List(Of Salidas_AprobacionesBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Salidas_AprobacionesBrl)

        RaiseEvent LoadingSalidas_AprobacionesList("CargarPorId_Salida")
        dsDatos = Salidas_AprobacionesDAL.CargarPorId_Salida(Id_Salida)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedSalidas_AprobacionesList(lista, "CargarPorId_Salida")
        Return lista

    End Function

End Class


