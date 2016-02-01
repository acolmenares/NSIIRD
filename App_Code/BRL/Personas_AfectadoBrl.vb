Imports ingNovar.Utilidades2
imports system.data
Imports system.collections.generic

Partial Public Class Personas_AfectadoBrl

    Private _Id As Int32
    Private _Id_Persona As Int32
    Private _Id_Tipo_Entrega As Int32
    Private _Id_Afectado As Int32


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

    Public Event Id_Tipo_EntregaChanging(ByVal Value As Int32)
    Public Event Id_Tipo_EntregaChanged()

    Public Property Id_Tipo_Entrega() As Int32
        Get
            Return Me._Id_Tipo_Entrega
        End Get
        Set(ByVal Value As Int32)
            If _Id_Tipo_Entrega <> Value Then
                RaiseEvent Id_Tipo_EntregaChanging(Value)
                Me._Id_Tipo_Entrega = Value
                RaiseEvent Id_Tipo_EntregaChanged()
            End If
        End Set
    End Property

    Public Event Id_AfectadoChanging(ByVal Value As Int32)
    Public Event Id_AfectadoChanged()

    Public Property Id_Afectado() As Int32
        Get
            Return Me._Id_Afectado
        End Get
        Set(ByVal Value As Int32)
            If _Id_Afectado <> Value Then
                RaiseEvent Id_AfectadoChanging(Value)
                Me._Id_Afectado = Value
                RaiseEvent Id_AfectadoChanged()
            End If
        End Set
    End Property

    Public ReadOnly Property Afectado() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Afectado)
        End Get
    End Property

    Public ReadOnly Property Personas() As PersonasBrl
        Get
            Return PersonasBrl.CargarPorID(Id_Persona)
        End Get
    End Property

    Public ReadOnly Property Tipo_Entrega() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Tipo_Entrega)
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
            Me.ID = Personas_AfectadoDAL.Insertar(Id_Persona, Id_Tipo_Entrega, Id_Afectado)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            Personas_AfectadoDAL.Actualizar(ID, Id_Persona, Id_Tipo_Entrega, Id_Afectado)
            RaiseEvent Updated()
        End If

        RaiseEvent Saved()

    End Sub

    Public Sub Eliminar()
        Dim totalHijos As Long = 0
        If Me.ID <> Nothing Then

            RaiseEvent Deleting()
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")

            Personas_AfectadoDAL.Eliminar(Me.ID)

            RaiseEvent Deleted()

        End If
    End Sub

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Personas_AfectadoBrl

        Dim objPersonas_Afectado As New Personas_AfectadoBrl

        With objPersonas_Afectado
            .ID = fila("Id")
            .Id_Persona = isDBNullToNothing(fila("Id_Persona"))
            .Id_Tipo_Entrega = isDBNullToNothing(fila("Id_Tipo_Entrega"))
            .Id_Afectado = isDBNullToNothing(fila("Id_Afectado"))

        End With

        Return objPersonas_Afectado

    End Function

    Public Shared Event LoadingPersonas_AfectadoList(ByVal LoadType As String)
    Public Shared Event LoadedPersonas_AfectadoList(ByVal target As List(Of Personas_AfectadoBrl), ByVal LoadType As String)

    Public Shared Function CargarTodos() As List(Of Personas_AfectadoBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_AfectadoBrl)

        RaiseEvent LoadingPersonas_AfectadoList("CargarTodos")

        dsDatos = Personas_AfectadoDAL.CargarTodos()

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedPersonas_AfectadoList(lista, "CargarTodos")

        Return lista

    End Function

    Public Shared Event CargandoPorId(ByVal id As Int32)
    Public Shared Event CargadoPorId(ByVal target As Personas_AfectadoBrl)

    Public Shared Function CargarPorID(ByVal ID As Int32) As Personas_AfectadoBrl

        Dim dsDatos As System.Data.DataSet
        Dim objPersonas_Afectado As Personas_AfectadoBrl = Nothing

        'RaiseEvent CargandoPorId(ID)

        dsDatos = Personas_AfectadoDAL.CargarPorID(ID)

        If dsDatos.Tables(0).Rows.Count <> 0 Then objPersonas_Afectado = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))

        'RaiseEvent CargadoPorId(objJoven)

        Return objPersonas_Afectado

    End Function

    Public Shared Function CargarPorId_Afectado(ByVal Id_Afectado As Int32) As List(Of Personas_AfectadoBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_AfectadoBrl)

        RaiseEvent LoadingPersonas_AfectadoList("CargarPorId_Afectado")

        dsDatos = Personas_AfectadoDAL.CargarPorId_Afectado(Id_Afectado)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedPersonas_AfectadoList(lista, "CargarPorId_Afectado")

        Return lista

    End Function

    Public Shared Function CargarPorId_Persona(ByVal Id_Persona As Int32) As List(Of Personas_AfectadoBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_AfectadoBrl)

        RaiseEvent LoadingPersonas_AfectadoList("CargarPorId_Persona")

        dsDatos = Personas_AfectadoDAL.CargarPorId_Persona(Id_Persona)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedPersonas_AfectadoList(lista, "CargarPorId_Persona")

        Return lista

    End Function

    Public Shared Function CargarPorId_Tipo_Entrega(ByVal Id_Tipo_Entrega As Int32) As List(Of Personas_AfectadoBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_AfectadoBrl)

        RaiseEvent LoadingPersonas_AfectadoList("CargarPorId_Tipo_Entrega")

        dsDatos = Personas_AfectadoDAL.CargarPorId_Tipo_Entrega(Id_Tipo_Entrega)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedPersonas_AfectadoList(lista, "CargarPorId_Tipo_Entrega")

        Return lista

    End Function



End Class


