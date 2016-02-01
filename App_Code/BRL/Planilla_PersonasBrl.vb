Imports ingNovar.Utilidades2
Imports System.Data
Imports System.Collections.Generic

Partial Public Class Planilla_PersonasBrl

    Private _Id As Int32
    Private _Id_Planilla As Int32
    Private _Id_Persona As Int32
    Private _Id_Planilla_Temporal As Int32

    Private objListPlanilla_Personas_Productos As List(Of Planilla_Personas_ProductosBrl)


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

    Public Event Id_PlanillaChanging(ByVal Value As Int32)
    Public Event Id_PlanillaChanged()

    Public Property Id_Planilla() As Int32
        Get
            Return Me._Id_Planilla
        End Get
        Set(ByVal Value As Int32)
            If _Id_Planilla <> Value Then
                RaiseEvent Id_PlanillaChanging(Value)
                Me._Id_Planilla = Value
                RaiseEvent Id_PlanillaChanged()
            End If
        End Set
    End Property

    Public Event Id_PersonaChanging(ByVal Value As Int32)
    Public Event Id_PersonaChanged()

    Public Property Id_Persona() As Int32
        Get
            Return Me._Id_Persona
        End Get
        Set(ByVal Value As Int32)
            If _Id_Persona <> Value Then
                RaiseEvent Id_PersonaChanging(Value)
                Me._Id_Persona = Value
                RaiseEvent Id_PersonaChanged()
            End If
        End Set
    End Property

    Public Event Id_PlanillaTemporalChanging(ByVal Value As Int32)
    Public Event Id_PlanillaTemporalChanged()

    Public Property Id_Planilla_Temporal() As Int32
        Get
            Return Me._Id_Planilla_Temporal
        End Get
        Set(ByVal Value As Int32)
            If _Id_Planilla_Temporal <> Value Then
                RaiseEvent Id_PlanillaTemporalChanging(Value)
                Me._Id_Planilla_Temporal = Value
                RaiseEvent Id_PlanillaTemporalChanged()
            End If
        End Set
    End Property

    Public Property Planilla_Personas_Productos() As List(Of Planilla_Personas_ProductosBrl)
        Get
            If (Me.objListPlanilla_Personas_Productos Is Nothing) Then
                objListPlanilla_Personas_Productos = Planilla_Personas_ProductosBrl.CargarPorId_Planilla_Personas(Me.ID)
            End If
            Return Me.objListPlanilla_Personas_Productos
        End Get
        Set(ByVal Value As List(Of Planilla_Personas_ProductosBrl))
            Me.objListPlanilla_Personas_Productos = Value
        End Set
    End Property

    Public ReadOnly Property Personas() As PersonasBrl
        Get
            Return PersonasBrl.CargarPorID(Id_Persona)
        End Get
    End Property

    Public ReadOnly Property Planilla() As PlanillaBrl
        Get
            Return PlanillaBrl.CargarPorID(Id_Planilla)
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
            Me.ID = Planilla_PersonasDAL.Insertar(Id_Planilla, Id_Persona)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            Planilla_PersonasDAL.Actualizar(ID, Id_Planilla, Id_Persona)
            RaiseEvent Updated()
        End If
        If Not objListPlanilla_Personas_Productos Is Nothing Then
            For Each fila As Planilla_Personas_ProductosBrl In objListPlanilla_Personas_Productos
                fila.Id_Planilla_Personas = Me.ID
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
            totalHijos += Planilla_Personas_Productos.Count
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            Planilla_PersonasDAL.Eliminar(Me.ID)
            RaiseEvent Deleted()

        End If
    End Sub

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Planilla_PersonasBrl

        Dim objPlanilla_Personas As New Planilla_PersonasBrl

        With objPlanilla_Personas
            .ID = fila("Id")
            .Id_Planilla = isDBNullToNothing(fila("Id_Planilla"))
            .Id_Persona = isDBNullToNothing(fila("Id_Persona"))

        End With

        Return objPlanilla_Personas

    End Function

    Public Shared Event LoadingPlanilla_PersonasList(ByVal LoadType As String)
    Public Shared Event LoadedPlanilla_PersonasList(ByVal target As List(Of Planilla_PersonasBrl), ByVal LoadType As String)

    Public Shared Function CargarTodos() As List(Of Planilla_PersonasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Planilla_PersonasBrl)

        RaiseEvent LoadingPlanilla_PersonasList("CargarTodos")

        dsDatos = Planilla_PersonasDAL.CargarTodos()

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedPlanilla_PersonasList(lista, "CargarTodos")

        Return lista

    End Function

    Public Shared Event LoadingPorId(ByVal id As Int32)
    Public Shared Event LoadedPorId(ByVal target As Planilla_PersonasBrl)

    Public Shared Function CargarPorID(ByVal ID As Int32) As Planilla_PersonasBrl

        Dim dsDatos As System.Data.DataSet
        Dim objPlanilla_Personas As Planilla_PersonasBrl = Nothing
        dsDatos = Planilla_PersonasDAL.CargarPorID(ID)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objPlanilla_Personas = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objPlanilla_Personas

    End Function

    Public Shared Function CargarPorId_Persona(ByVal Id_Persona As Int32) As List(Of Planilla_PersonasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Planilla_PersonasBrl)

        RaiseEvent LoadingPlanilla_PersonasList("CargarPorId_Persona")
        dsDatos = Planilla_PersonasDAL.CargarPorId_Persona(Id_Persona)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPlanilla_PersonasList(lista, "CargarPorId_Persona")

        Return lista

    End Function

    Public Shared Function CargarPorId_Planilla(ByVal Id_Planilla As Int32) As List(Of Planilla_PersonasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Planilla_PersonasBrl)

        RaiseEvent LoadingPlanilla_PersonasList("CargarPorId_Planilla")
        dsDatos = Planilla_PersonasDAL.CargarPorId_Planilla(Id_Planilla)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPlanilla_PersonasList(lista, "CargarPorId_Planilla")

        Return lista

    End Function



End Class


