Imports ingNovar.Utilidades2
Imports System.Data
Imports System.Collections.Generic
Imports SeguridadUsuarios

Partial Public Class Salud_RemisionesBrl

    Private _Id As Int32
    Private _Id_Salud As Int32
    Private _Id_Entidad_Remision As Int32
    Private _Fecha_Remision As DateTime
    Private _Fecha_Ingreso As DateTime
    Private _Fecha_Retiro As DateTime
    Private _Observaciones As String
    Private _Id_Entidad_Informacion As Int32
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

    Public Event Id_SaludChanging(ByVal Value As Int32)
    Public Event Id_SaludChanged()

    Public Property Id_Salud() As Int32
        Get
            Return Me._Id_Salud
        End Get
        Set(ByVal Value As Int32)
            If _Id_Salud <> Value Then
                RaiseEvent Id_SaludChanging(Value)
                Me._Id_Salud = Value
                RaiseEvent Id_SaludChanged()
            End If
        End Set
    End Property

    Public Event Id_Entidad_RemisionChanging(ByVal Value As Int32)
    Public Event Id_Entidad_RemisionChanged()

    Public Property Id_Entidad_Remision() As Int32
        Get
            Return Me._Id_Entidad_Remision
        End Get
        Set(ByVal Value As Int32)
            If _Id_Entidad_Remision <> Value Then
                RaiseEvent Id_Entidad_RemisionChanging(Value)
                Me._Id_Entidad_Remision = Value
                RaiseEvent Id_Entidad_RemisionChanged()
            End If
        End Set
    End Property

    Public Event Fecha_RemisionChanging(ByVal Value As DateTime)
    Public Event Fecha_RemisionChanged()

    Public Property Fecha_Remision() As DateTime
        Get
            Return Me._Fecha_Remision
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_Remision <> Value Then
                RaiseEvent Fecha_RemisionChanging(Value)
                Me._Fecha_Remision = Value
                RaiseEvent Fecha_RemisionChanged()
            End If
        End Set
    End Property

    Public Event Fecha_IngresoChanging(ByVal Value As DateTime)
    Public Event Fecha_IngresoChanged()

    Public Property Fecha_Ingreso() As DateTime
        Get
            Return Me._Fecha_Ingreso
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_Ingreso <> Value Then
                RaiseEvent Fecha_IngresoChanging(Value)
                Me._Fecha_Ingreso = Value
                RaiseEvent Fecha_IngresoChanged()
            End If
        End Set
    End Property

    Public Event Fecha_RetiroChanging(ByVal Value As DateTime)
    Public Event Fecha_RetiroChanged()

    Public Property Fecha_Retiro() As DateTime
        Get
            Return Me._Fecha_Retiro
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_Retiro <> Value Then
                RaiseEvent Fecha_RetiroChanging(Value)
                Me._Fecha_Retiro = Value
                RaiseEvent Fecha_RetiroChanged()
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

    Public Event Id_Entidad_InformacionChanging(ByVal Value As Int32)
    Public Event Id_Entidad_InformacionChanged()

    Public Property Id_Entidad_Informacion() As Int32
        Get
            Return Me._Id_Entidad_Informacion
        End Get
        Set(ByVal Value As Int32)
            If _Id_Entidad_Informacion <> Value Then
                RaiseEvent Id_Entidad_InformacionChanging(Value)
                Me._Id_Entidad_Informacion = Value
                RaiseEvent Id_Entidad_InformacionChanged()
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

    Public ReadOnly Property Entidad_Remision() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Entidad_Remision)
        End Get
    End Property

    Public ReadOnly Property Salud() As SaludBrl
        Get
            Return SaludBrl.CargarPorID(Id_Salud)
        End Get
    End Property

    Public ReadOnly Property Entidad_Informacion() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Entidad_Informacion)
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
            Me.ID = Salud_RemisionesDAL.Insertar(Id_Salud, Id_Entidad_Remision, Fecha_Remision, Fecha_Ingreso, Fecha_Retiro, Observaciones, Id_Entidad_Informacion, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Fecha_Cierre, Cierre)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            Salud_RemisionesDAL.Actualizar(ID, Id_Salud, Id_Entidad_Remision, Fecha_Remision, Fecha_Ingreso, Fecha_Retiro, Observaciones, Id_Entidad_Informacion, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Fecha_Cierre, Cierre)
            RaiseEvent Updated()
        End If

        RaiseEvent Saved()

    End Sub

    Public Sub Eliminar()
        Dim totalHijos As Long = 0
        If Me.ID <> Nothing Then

            RaiseEvent Deleting()

            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")

            Salud_RemisionesDAL.Eliminar(Me.ID)

            RaiseEvent Deleted()

        End If
    End Sub

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Salud_RemisionesBrl

        Dim objSalud_Remisiones As New Salud_RemisionesBrl

        With objSalud_Remisiones
            .ID = fila("Id")
            .Id_Salud = isDBNullToNothing(fila("Id_Salud"))
            .Id_Entidad_Remision = isDBNullToNothing(fila("Id_Entidad_Remision"))
            .Fecha_Remision = isDBNullToNothing(fila("Fecha_Remision"))
            .Fecha_Ingreso = isDBNullToNothing(fila("Fecha_Ingreso"))
            .Fecha_Retiro = isDBNullToNothing(fila("Fecha_Retiro"))
            .Observaciones = isDBNullToNothing(fila("Observaciones"))
            .Id_Entidad_Informacion = isDBNullToNothing(fila("Id_Entidad_Informacion"))
            .Fecha_Creacion = isDBNullToNothing(fila("Fecha_Creacion"))
            .Id_Usuario_Creacion = isDBNullToNothing(fila("Id_Usuario_Creacion"))
            .Fecha_Modificacion = isDBNullToNothing(fila("Fecha_Modificacion"))
            .Id_Usuario_Modificacion = isDBNullToNothing(fila("Id_Usuario_Modificacion"))
            .Fecha_Cierre = isDBNullToNothing(fila("Fecha_Cierre"))
            .Cierre = isDBNullToNothing(fila("Cierre"))
        End With

        Return objSalud_Remisiones

    End Function

    Public Shared Event LoadingSalud_RemisionesList(ByVal LoadType As String)
    Public Shared Event LoadedSalud_RemisionesList(ByVal target As List(Of Salud_RemisionesBrl), ByVal LoadType As String)

    Public Shared Function CargarTodos() As List(Of Salud_RemisionesBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Salud_RemisionesBrl)

        RaiseEvent LoadingSalud_RemisionesList("CargarTodos")

        dsDatos = Salud_RemisionesDAL.CargarTodos()

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSalud_RemisionesList(lista, "CargarTodos")

        Return lista

    End Function

    Public Shared Event CargandoPorId(ByVal id As Int32)
    Public Shared Event CargadoPorId(ByVal target As Salud_RemisionesBrl)

    Public Shared Function CargarPorID(ByVal ID As Int32) As Salud_RemisionesBrl

        Dim dsDatos As System.Data.DataSet
        Dim objSalud_Remisiones As Salud_RemisionesBrl = Nothing

        RaiseEvent CargandoPorId(ID)

        dsDatos = Salud_RemisionesDAL.CargarPorID(ID)

        If dsDatos.Tables(0).Rows.Count <> 0 Then objSalud_Remisiones = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))



        Return objSalud_Remisiones

    End Function

    Public Shared Function CargarPorId_Entidad_Remision(ByVal Id_Entidad_Remision As Int32) As List(Of Salud_RemisionesBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Salud_RemisionesBrl)

        RaiseEvent LoadingSalud_RemisionesList("CargarPorId_Entidad_Remision")

        dsDatos = Salud_RemisionesDAL.CargarPorId_Entidad_Remision(Id_Entidad_Remision)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSalud_RemisionesList(lista, "CargarPorId_Entidad_Remision")

        Return lista

    End Function



    Public Shared Function CargarPorId_Salud(ByVal Id_Salud As Int32) As List(Of Salud_RemisionesBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Salud_RemisionesBrl)

        RaiseEvent LoadingSalud_RemisionesList("CargarPorId_Salud")

        dsDatos = Salud_RemisionesDAL.CargarPorId_Salud(Id_Salud)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSalud_RemisionesList(lista, "CargarPorId_Salud")

        Return lista

    End Function



    Public Shared Function CargarPorId_Entidad_Informacion(ByVal Id_Entidad_Informacion As Int32) As List(Of Salud_RemisionesBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Salud_RemisionesBrl)

        RaiseEvent LoadingSalud_RemisionesList("CargarPorId_Entidad_Informacion")

        dsDatos = Salud_RemisionesDAL.CargarPorId_Entidad_Informacion(Id_Entidad_Informacion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSalud_RemisionesList(lista, "CargarPorId_Entidad_Informacion")

        Return lista

    End Function



    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As Int32) As List(Of Salud_RemisionesBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Salud_RemisionesBrl)

        RaiseEvent LoadingSalud_RemisionesList("CargarPorId_Usuario_Creacion")

        dsDatos = Salud_RemisionesDAL.CargarPorId_Usuario_Creacion(Id_Usuario_Creacion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSalud_RemisionesList(lista, "CargarPorId_Usuario_Creacion")

        Return lista

    End Function



    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As Int32) As List(Of Salud_RemisionesBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Salud_RemisionesBrl)

        RaiseEvent LoadingSalud_RemisionesList("CargarPorId_Usuario_Modificacion")

        dsDatos = Salud_RemisionesDAL.CargarPorId_Usuario_Modificacion(Id_Usuario_Modificacion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSalud_RemisionesList(lista, "CargarPorId_Usuario_Modificacion")

        Return lista

    End Function



End Class


