Imports ingNovar.Utilidades2
imports system.data
Imports system.collections.generic


Partial Public Class Personas_EntregasBrl

    Private _Id As Int32
    Private _Id_Persona As Int32
    Private _Id_Programa As Int32
    Private _Id_Producto As Int32
    Private _Id_Unidad As Int32
    Private _Cantidad As Double
    Private _Cantidad_Legalizada As Double


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

    Public Event Cantidad_LegalizadaChanging(ByVal Value As Double)
    Public Event Cantidad_LegalizadaChanged()

    Public Property Cantidad_Legalizada() As Double
        Get
            Return Me._Cantidad_Legalizada
        End Get
        Set(ByVal Value As Double)
            If _Cantidad_Legalizada <> Value Then
                RaiseEvent Cantidad_LegalizadaChanging(Value)
                Me._Cantidad_Legalizada = Value
                RaiseEvent Cantidad_LegalizadaChanged()
            End If
        End Set
    End Property


    Public ReadOnly Property Personas() As PersonasBrl
        Get
            Return PersonasBrl.CargarPorID(Id_Persona)
        End Get
    End Property

    Public ReadOnly Property Productos() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Producto)
        End Get
    End Property

    Public ReadOnly Property Programacion() As ProgramacionBrl
        Get
            Return ProgramacionBrl.CargarPorID(Id_Programa)
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
            Me.ID = Personas_EntregasDAL.Insertar(Id_Persona, Id_Programa, Id_Producto, Id_Unidad, Cantidad, Cantidad_Legalizada)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            Personas_EntregasDAL.Actualizar(ID, Id_Persona, Id_Programa, Id_Producto, Id_Unidad, Cantidad, Cantidad_Legalizada)
            RaiseEvent Updated()
        End If


        RaiseEvent Saved()

    End Sub

    Public Sub Eliminar()
        Dim totalHijos As Long = 0
        If Me.ID <> Nothing Then

            RaiseEvent Deleting()
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")

            Personas_EntregasDAL.Eliminar(Me.ID)

            RaiseEvent Deleted()

        End If
    End Sub


    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Personas_EntregasBrl

        Dim objPersonas_Entregas As New Personas_EntregasBrl

        With objPersonas_Entregas
            .ID = fila("Id")
            .Id_Persona = isDBNullToNothing(fila("Id_Persona"))
            .Id_Programa = isDBNullToNothing(fila("Id_Programa"))
            .Id_Producto = isDBNullToNothing(fila("Id_Producto"))
            .Id_Unidad = isDBNullToNothing(fila("Id_Unidad"))
            .Cantidad = isDBNullToNothing(fila("Cantidad"))
            .Cantidad_Legalizada = isDBNullToNothing(fila("Cantidad_Legalizada"))

        End With

        Return objPersonas_Entregas

    End Function

    Public Shared Event LoadingPersonas_EntregasList(ByVal LoadType As String)
    Public Shared Event LoadedPersonas_EntregasList(ByVal target As List(Of Personas_EntregasBrl), ByVal LoadType As String)

    Public Shared Function CargarTodos() As List(Of Personas_EntregasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_EntregasBrl)

        RaiseEvent LoadingPersonas_EntregasList("CargarTodos")

        dsDatos = Personas_EntregasDAL.CargarTodos()

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedPersonas_EntregasList(lista, "CargarTodos")

        Return lista

    End Function

    Public Shared Event CargandoPorId(ByVal id As Int32)
    Public Shared Event CargadoPorId(ByVal target As Personas_EntregasBrl)

    Public Shared Function CargarPorID(ByVal ID As Int32) As Personas_EntregasBrl

        Dim dsDatos As System.Data.DataSet
        Dim objPersonas_Entregas As Personas_EntregasBrl = Nothing

        'RaiseEvent CargandoPorId(ID)

        dsDatos = Personas_EntregasDAL.CargarPorID(ID)

        If dsDatos.Tables(0).Rows.Count <> 0 Then objPersonas_Entregas = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))

        'RaiseEvent CargadoPorId(objJoven)

        Return objPersonas_Entregas

    End Function
    Public Shared Function CargarPorId_Persona(ByVal Id_Persona As Int32) As List(Of Personas_EntregasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_EntregasBrl)

        RaiseEvent LoadingPersonas_EntregasList("CargarPorId_Persona")

        dsDatos = Personas_EntregasDAL.CargarPorId_Persona(Id_Persona)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedPersonas_EntregasList(lista, "CargarPorId_Persona")

        Return lista

    End Function


    Public Shared Function CargarPorId_Producto(ByVal Id_Producto As Int32) As List(Of Personas_EntregasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_EntregasBrl)

        RaiseEvent LoadingPersonas_EntregasList("CargarPorId_Producto")

        dsDatos = Personas_EntregasDAL.CargarPorId_Producto(Id_Producto)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedPersonas_EntregasList(lista, "CargarPorId_Producto")

        Return lista

    End Function


    Public Shared Function CargarPorId_Programa(ByVal Id_Programa As Int32) As List(Of Personas_EntregasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_EntregasBrl)

        RaiseEvent LoadingPersonas_EntregasList("CargarPorId_Programa")

        dsDatos = Personas_EntregasDAL.CargarPorId_Programa(Id_Programa)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedPersonas_EntregasList(lista, "CargarPorId_Programa")

        Return lista

    End Function


    Public Shared Function CargarPorId_Unidad(ByVal Id_Unidad As Int32) As List(Of Personas_EntregasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_EntregasBrl)

        RaiseEvent LoadingPersonas_EntregasList("CargarPorId_Unidad")

        dsDatos = Personas_EntregasDAL.CargarPorId_Unidad(Id_Unidad)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedPersonas_EntregasList(lista, "CargarPorId_Unidad")

        Return lista

    End Function



End Class


