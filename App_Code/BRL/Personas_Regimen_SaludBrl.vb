Imports ingNovar.Utilidades2
imports system.data
Imports system.collections.generic


Partial Public Class Personas_Regimen_SaludBrl

    Private _Id As Int32
    Private _Id_Persona As Int32
    Private _Id_Tipo_Entrega As Int32
    Private _Id_Regimen_Salud As Int32
    Private _Id_Eps As Int32
    Private _Municipio As String
    Private _Fecha As DateTime
    Private _Id_Necesita_Traslado As Int32
    Private _Id_Motivo_No_Necesita_Traslado As Int32
    Private _Id_Realizo_Traslado As Int32
    Private _Id_Motivo_No_Realizo_Traslado As Int32
    Private _Observaciones As String
    Private _Id_Cerrar As Int32
    Private _Id_Declaracion_Seguimiento As Int32
    Private _Id_Municipio As Int32

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

    Public Event Id_Regimen_SaludChanging(ByVal Value As Int32)
    Public Event Id_Regimen_SaludChanged()
	
    Public Property Id_Regimen_Salud() As Int32
        Get
            Return Me._Id_Regimen_Salud
        End Get
        Set(ByVal Value As Int32)
            If _Id_Regimen_Salud <> Value Then
                RaiseEvent Id_Regimen_SaludChanging(Value)
				Me._Id_Regimen_Salud = Value
                RaiseEvent Id_Regimen_SaludChanged()
            End If
        End Set
    End Property

    Public Event Id_EpsChanging(ByVal Value As Int32)
    Public Event Id_EpsChanged()
	
    Public Property Id_Eps() As Int32
        Get
            Return Me._Id_Eps
        End Get
        Set(ByVal Value As Int32)
            If _Id_Eps <> Value Then
                RaiseEvent Id_EpsChanging(Value)
				Me._Id_Eps = Value
                RaiseEvent Id_EpsChanged()
            End If
        End Set
    End Property

    Public Event MunicipioChanging(ByVal Value As String)
    Public Event MunicipioChanged()
	
    Public Property Municipio() As String
        Get
            Return Me._Municipio
        End Get
        Set(ByVal Value As String)
            If _Municipio <> Value Then
                RaiseEvent MunicipioChanging(Value)
				Me._Municipio = Value
                RaiseEvent MunicipioChanged()
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

    Public Event Id_Necesita_TrasladoChanging(ByVal Value As Int32)
    Public Event Id_Necesita_TrasladoChanged()

    Public Property Id_Necesita_Traslado() As Int32
        Get
            Return Me._Id_Necesita_Traslado
        End Get
        Set(ByVal Value As Int32)
            If _Id_Necesita_Traslado <> Value Then
                RaiseEvent Id_Necesita_TrasladoChanging(Value)
                Me._Id_Necesita_Traslado = Value
                RaiseEvent Id_Necesita_TrasladoChanged()
            End If
        End Set
    End Property

    Public Event Id_Motivo_No_Necesita_TrasladoChanging(ByVal Value As Int32)
    Public Event Id_Motivo_No_Necesita_TrasladoChanged()

    Public Property Id_Motivo_No_Necesita_Traslado() As Int32
        Get
            Return Me._Id_Motivo_No_Necesita_Traslado
        End Get
        Set(ByVal Value As Int32)
            If _Id_Motivo_No_Necesita_Traslado <> Value Then
                RaiseEvent Id_Motivo_No_Necesita_TrasladoChanging(Value)
                Me._Id_Motivo_No_Necesita_Traslado = Value
                RaiseEvent Id_Motivo_No_Necesita_TrasladoChanged()
            End If
        End Set
    End Property

    Public Event Id_Realizo_TrasladoChanging(ByVal Value As Int32)
    Public Event Id_Realizo_TrasladoChanged()

    Public Property Id_Realizo_Traslado() As Int32
        Get
            Return Me._Id_Realizo_Traslado
        End Get
        Set(ByVal Value As Int32)
            If _Id_Realizo_Traslado <> Value Then
                RaiseEvent Id_Realizo_TrasladoChanging(Value)
                Me._Id_Realizo_Traslado = Value
                RaiseEvent Id_Realizo_TrasladoChanged()
            End If
        End Set
    End Property

    Public Event Id_Motivo_No_Realizo_TrasladoChanging(ByVal Value As Int32)
    Public Event Id_Motivo_No_Realizo_TrasladoChanged()

    Public Property Id_Motivo_No_Realizo_Traslado() As Int32
        Get
            Return Me._Id_Motivo_No_Realizo_Traslado
        End Get
        Set(ByVal Value As Int32)
            If _Id_Motivo_No_Realizo_Traslado <> Value Then
                RaiseEvent Id_Motivo_No_Realizo_TrasladoChanging(Value)
                Me._Id_Motivo_No_Realizo_Traslado = Value
                RaiseEvent Id_Motivo_No_Realizo_TrasladoChanged()
            End If
        End Set
    End Property

    Public Event ObservacionesChanging(ByVal Value As String)
    Public Event ObservacionesChanged()

    Public Property Observaciones() As String
        Get
            Return Me._Observaciones
        End Get
        Set(ByVal Value As String)
            If _Observaciones <> Value Then
                RaiseEvent ObservacionesChanging(Value)
                Me._Observaciones = Value
                RaiseEvent ObservacionesChanged()
            End If
        End Set
    End Property

    Public Event Id_CerrarChanging(ByVal Value As Int32)
    Public Event Id_CerrarChanged()

    Public Property Id_Cerrar() As Int32
        Get
            Return Me._Id_Cerrar
        End Get
        Set(ByVal Value As Int32)
            If _Id_Cerrar <> Value Then
                RaiseEvent Id_CerrarChanging(Value)
                Me._Id_Cerrar = Value
                RaiseEvent Id_CerrarChanged()
            End If
        End Set
    End Property

    Public Event Id_Declaracion_SeguimientoChanging(ByVal Value As Int32)
    Public Event Id_Declaracion_SeguimientoChanged()

    Public Property Id_Declaracion_Seguimiento() As Int32
        Get
            Return Me._Id_Declaracion_Seguimiento
        End Get
        Set(ByVal Value As Int32)
            If _Id_Declaracion_Seguimiento <> Value Then
                RaiseEvent Id_Declaracion_SeguimientoChanging(Value)
                Me._Id_Declaracion_Seguimiento = Value
                RaiseEvent Id_Declaracion_SeguimientoChanged()
            End If
        End Set
    End Property

    Public Event Id_MunicipioChanging(ByVal Value As Int32)
    Public Event Id_MunicipioChanged()

    Public Property Id_Municipio() As Int32
        Get
            Return Me._Id_Municipio
        End Get
        Set(ByVal Value As Int32)
            If _Id_Municipio <> Value Then
                RaiseEvent Id_MunicipioChanging(Value)
                Me._Id_Municipio = Value
                RaiseEvent Id_MunicipioChanged()
            End If
        End Set
    End Property

    Public Readonly Property Eps() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Eps)
        End Get
    End Property

    Public Readonly Property Personas() As PersonasBrl
        Get
            Return PersonasBrl.CargarPorID(Id_Persona)
        End Get
    End Property

    Public Readonly Property Regimen_Salud() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Regimen_Salud)
        End Get
    End Property

    Public Readonly Property Tipo_Entrega() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Tipo_Entrega)
        End Get
    End Property

    Public ReadOnly Property Necesita_Traslado() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Necesita_Traslado)
        End Get
    End Property

    Public ReadOnly Property Motivo_No_Necesita_Traslado() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Motivo_No_Necesita_Traslado)
        End Get
    End Property

    Public ReadOnly Property Realizo_Traslado() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Realizo_Traslado)
        End Get
    End Property

    Public ReadOnly Property Motivo_No_Realizo_Traslado() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Motivo_No_Realizo_Traslado)
        End Get
    End Property

    Public ReadOnly Property MunicipioRS() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Municipio)
        End Get
    End Property

    Public ReadOnly Property Cerrar() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Cerrar)
        End Get
    End Property

    Public ReadOnly Property NecesitaTraslado() As String
        Get
            If Necesita_Traslado Is Nothing Then
                Return ""
            Else
                Return Necesita_Traslado.Descripcion
            End If

        End Get
    End Property

    Public ReadOnly Property MotivoNoTraslado() As String
        Get
            If Motivo_No_Necesita_Traslado Is Nothing Then
                Return ""
            Else
                Return Motivo_No_Necesita_Traslado.Descripcion
            End If

        End Get
    End Property

    Public ReadOnly Property RealizoTraslado() As String
        Get
            If Realizo_Traslado Is Nothing Then
                Return ""
            Else
                Return Realizo_Traslado.Descripcion
            End If

        End Get
    End Property

    Public ReadOnly Property Cerrado As String
        Get
            If Cerrar Is Nothing Then
                Return ""
            Else
                Return Cerrar.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property MunicipioRegimenSalud() As String
        Get
            If MunicipioRS Is Nothing Then
                Return ""
            Else
                Return MunicipioRS.Descripcion
            End If

        End Get
    End Property


    Public ReadOnly Property Declaracion_Seguimiento() As Declaracion_SeguimientosBrl
        Get
            Return Declaracion_SeguimientosBrl.CargarPorID(Id_Declaracion_Seguimiento)
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
            Me.ID = Personas_Regimen_SaludDAL.Insertar(Id_Persona, Id_Tipo_Entrega, Id_Regimen_Salud, Id_Eps, Municipio, Fecha, Id_Necesita_Traslado, Id_Motivo_No_Necesita_Traslado, Id_Realizo_Traslado, Id_Motivo_No_Realizo_Traslado, Observaciones, Id_Cerrar, Id_Declaracion_Seguimiento, Id_Municipio)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            Personas_Regimen_SaludDAL.Actualizar(ID, Id_Persona, Id_Tipo_Entrega, Id_Regimen_Salud, Id_Eps, Municipio, Fecha, Id_Necesita_Traslado, Id_Motivo_No_Necesita_Traslado, Id_Realizo_Traslado, Id_Motivo_No_Realizo_Traslado, Observaciones, Id_Cerrar, Id_Declaracion_Seguimiento, Id_Municipio)
            RaiseEvent Updated()
        End If

        RaiseEvent Saved()

    End Sub

    Public Sub Eliminar()
        Dim totalHijos As Long = 0
        If Me.ID <> Nothing Then

            RaiseEvent Deleting()
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")

            Personas_Regimen_SaludDAL.Eliminar(Me.ID)

            RaiseEvent Deleted()

        End If
    End Sub


    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Personas_Regimen_SaludBrl

        Dim objPersonas_Regimen_Salud As New Personas_Regimen_SaludBrl

        With objPersonas_Regimen_Salud
            .ID = fila("Id")
            .Id_Persona = isDBNullToNothing(fila("Id_Persona"))
            .Id_Tipo_Entrega = isDBNullToNothing(fila("Id_Tipo_Entrega"))
            .Id_Regimen_Salud = isDBNullToNothing(fila("Id_Regimen_Salud"))
            .Id_Eps = isDBNullToNothing(fila("Id_Eps"))
            .Municipio = isDBNullToNothing(fila("Municipio"))
            .Fecha = isDBNullToNothing(fila("Fecha"))
            .Id_Necesita_Traslado = isDBNullToNothing(fila("Id_Necesita_Traslado"))
            .Id_Motivo_No_Necesita_Traslado = isDBNullToNothing(fila("Id_Motivo_No_Necesita_Traslado"))
            .Id_Realizo_Traslado = isDBNullToNothing(fila("Id_Realizo_Traslado"))
            .Id_Motivo_No_Realizo_Traslado = isDBNullToNothing(fila("Id_Motivo_No_Realizo_Traslado"))
            .Observaciones = isDBNullToNothing(fila("Observaciones"))
            .Id_Cerrar = isDBNullToNothing(fila("Id_Cerrar"))
            .Id_Declaracion_Seguimiento = isDBNullToNothing(fila("Id_Declaracion_Seguimiento"))
            .Id_Municipio = isDBNullToNothing(fila("Id_Municipio"))
        End With

        Return objPersonas_Regimen_Salud

    End Function

    Public Shared Event LoadingPersonas_Regimen_SaludList(ByVal LoadType As String)
    Public Shared Event LoadedPersonas_Regimen_SaludList(ByVal target As List(Of Personas_Regimen_SaludBrl), ByVal LoadType As String)

    Public Shared Function CargarTodos() As List(Of Personas_Regimen_SaludBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_Regimen_SaludBrl)

        RaiseEvent LoadingPersonas_Regimen_SaludList("CargarTodos")

        dsDatos = Personas_Regimen_SaludDAL.CargarTodos()

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedPersonas_Regimen_SaludList(lista, "CargarTodos")

        Return lista

    End Function

    Public Shared Event CargandoPorId(ByVal id As Int32)
    Public Shared Event CargadoPorId(ByVal target As Personas_Regimen_SaludBrl)

    Public Shared Function CargarPorID(ByVal ID As Int32) As Personas_Regimen_SaludBrl

        Dim dsDatos As System.Data.DataSet
        Dim objPersonas_Regimen_Salud As Personas_Regimen_SaludBrl = Nothing

        dsDatos = Personas_Regimen_SaludDAL.CargarPorID(ID)

        If dsDatos.Tables(0).Rows.Count <> 0 Then objPersonas_Regimen_Salud = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))

        Return objPersonas_Regimen_Salud

    End Function

    Public Shared Function CargarPorId_Eps(ByVal Id_Eps As Int32) As List(Of Personas_Regimen_SaludBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_Regimen_SaludBrl)

        RaiseEvent LoadingPersonas_Regimen_SaludList("CargarPorId_Eps")

        dsDatos = Personas_Regimen_SaludDAL.CargarPorId_Eps(Id_Eps)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedPersonas_Regimen_SaludList(lista, "CargarPorId_Eps")

        Return lista

    End Function

    Public Shared Function CargarPorId_Persona(ByVal Id_Persona As Int32) As List(Of Personas_Regimen_SaludBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_Regimen_SaludBrl)

        RaiseEvent LoadingPersonas_Regimen_SaludList("CargarPorId_Persona")

        dsDatos = Personas_Regimen_SaludDAL.CargarPorId_Persona(Id_Persona)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedPersonas_Regimen_SaludList(lista, "CargarPorId_Persona")

        Return lista

    End Function

    Public Shared Function CargarPorId_Regimen_Salud(ByVal Id_Regimen_Salud As Int32) As List(Of Personas_Regimen_SaludBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_Regimen_SaludBrl)

        RaiseEvent LoadingPersonas_Regimen_SaludList("CargarPorId_Regimen_Salud")

        dsDatos = Personas_Regimen_SaludDAL.CargarPorId_Regimen_Salud(Id_Regimen_Salud)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedPersonas_Regimen_SaludList(lista, "CargarPorId_Regimen_Salud")

        Return lista

    End Function

    Public Shared Function CargarPorId_Tipo_Entrega(ByVal Id_Tipo_Entrega As Int32) As List(Of Personas_Regimen_SaludBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_Regimen_SaludBrl)

        RaiseEvent LoadingPersonas_Regimen_SaludList("CargarPorId_Tipo_Entrega")

        dsDatos = Personas_Regimen_SaludDAL.CargarPorId_Tipo_Entrega(Id_Tipo_Entrega)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedPersonas_Regimen_SaludList(lista, "CargarPorId_Tipo_Entrega")

        Return lista

    End Function

    Public Shared Function CargarPorId_PersonaySegundaEntrega(ByVal ID_Persona As Int32, ByVal Id_Tipo_Entrega As Int32) As Personas_Regimen_SaludBrl

        Dim dsDatos As System.Data.DataSet
        Dim objPersonas_Regimen_Salud As Personas_Regimen_SaludBrl = Nothing
        dsDatos = Personas_Regimen_SaludDAL.CargarPorIDySegundaEntrega(ID_Persona, Id_Tipo_Entrega)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objPersonas_Regimen_Salud = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objPersonas_Regimen_Salud

    End Function

    Public Shared Function CargarPorId_Necesita_Traslado(ByVal Id_Necesita_Traslado As Int32) As List(Of Personas_Regimen_SaludBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_Regimen_SaludBrl)
        dsDatos = Personas_Regimen_SaludDAL.CargarPorId_Necesita_Traslado(Id_Necesita_Traslado)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function

    Public Shared Function CargarPorId_Motivo_No_Necesita_Traslado(ByVal Id_Motivo_No_Necesita_Traslado As Int32) As List(Of Personas_Regimen_SaludBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_Regimen_SaludBrl)
        dsDatos = Personas_Regimen_SaludDAL.CargarPorId_Motivo_No_Necesita_Traslado(Id_Motivo_No_Necesita_Traslado)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function

    Public Shared Function CargarPorId_Realizo_Traslado(ByVal Id_Realizo_Traslado As Int32) As List(Of Personas_Regimen_SaludBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_Regimen_SaludBrl)
        dsDatos = Personas_Regimen_SaludDAL.CargarPorId_Realizo_Traslado(Id_Realizo_Traslado)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function

    Public Shared Function CargarPorId_Motivo_No_Realizo_Traslado(ByVal Id_Motivo_No_Realizo_Traslado As Int32) As List(Of Personas_Regimen_SaludBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_Regimen_SaludBrl)
        dsDatos = Personas_Regimen_SaludDAL.CargarPorId_Motivo_No_Realizo_Traslado(Id_Motivo_No_Realizo_Traslado)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function

    Public Shared Function CargarPorId_Cerrar(ByVal Id_Cerrar As Int32) As List(Of Personas_Regimen_SaludBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_Regimen_SaludBrl)
        dsDatos = Personas_Regimen_SaludDAL.CargarPorId_Cerrar(Id_Cerrar)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function

    Public Shared Function CargarPorId_Declaracion_Seguimiento(ByVal Id_Declaracion_Seguimiento As Int32) As List(Of Personas_Regimen_SaludBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_Regimen_SaludBrl)

        dsDatos = Personas_Regimen_SaludDAL.CargarPorId_Declaracion_Seguimiento(Id_Declaracion_Seguimiento)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        Return lista

    End Function


End Class


