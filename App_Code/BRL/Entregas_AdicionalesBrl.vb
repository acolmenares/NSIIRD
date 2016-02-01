Imports ingNovar.Utilidades2
Imports System.Data
Imports System.Collections.Generic
Imports SeguridadUsuarios

Partial Public Class Entregas_AdicionalesBrl

    Private _Id As Int32
    Private _Fecha As DateTime
    Private _Id_Tipo_Entrega As Int32
    Private _Fecha_Creacion As DateTime
    Private _Id_Usuario_Creacion As Int32
    Private _Fecha_Modificacion As DateTime
    Private _Id_Usuario_Modificacion As Int32
    Private _Fecha_Cierre As DateTime
    Private _Cierre As Boolean
    Private _Id_Programa As Int32

    Private objListEntregas_Adicionales_Personas As List(Of Entregas_Adicionales_PersonasBrl)

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

    Public Property Entregas_Adicionales_Personas() As List(Of Entregas_Adicionales_PersonasBrl)
        Get
            If (Me.objListEntregas_Adicionales_Personas Is Nothing) Then
                objListEntregas_Adicionales_Personas = Entregas_Adicionales_PersonasBrl.CargarPorId_Entrega_Adicional(Me.ID)
            End If
            Return Me.objListEntregas_Adicionales_Personas
        End Get
        Set(ByVal Value As List(Of Entregas_Adicionales_PersonasBrl))
            Me.objListEntregas_Adicionales_Personas = Value
        End Set
    End Property

    Public ReadOnly Property Programa() As ProgramacionBrl
        Get
            Return ProgramacionBrl.CargarPorID(Id_Programa)
        End Get
    End Property

    Public ReadOnly Property TipoEntrega() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Tipo_Entrega)
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

    Public ReadOnly Property ConteoFamilias() As Integer
        Get
            Return Entregas_Adicionales_Personas.Count
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
            Me.ID = Entregas_AdicionalesDAL.Insertar(Fecha, Id_Tipo_Entrega, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Fecha_Cierre, Cierre, Id_Programa)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            Entregas_AdicionalesDAL.Actualizar(ID, Fecha, Id_Tipo_Entrega, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Fecha_Cierre, Cierre, Id_Programa)
            RaiseEvent Updated()
        End If
        If Not objListEntregas_Adicionales_Personas Is Nothing Then
            For Each fila As Entregas_Adicionales_PersonasBrl In objListEntregas_Adicionales_Personas
                fila.Id_Entrega_Adicional = Me.ID
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
            totalHijos += Entregas_Adicionales_Personas.Count
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            Entregas_AdicionalesDAL.Eliminar(Me.ID)

            RaiseEvent Deleted()

        End If
    End Sub

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Entregas_AdicionalesBrl

        Dim objEntregas_Adicionales As New Entregas_AdicionalesBrl
        With objEntregas_Adicionales
            .ID = fila("Id")
            .Fecha = isDBNullToNothing(fila("Fecha"))
            .Id_Tipo_Entrega = isDBNullToNothing(fila("Id_Tipo_Entrega"))
            .Fecha_Creacion = isDBNullToNothing(fila("Fecha_Creacion"))
            .Id_Usuario_Creacion = isDBNullToNothing(fila("Id_Usuario_Creacion"))
            .Fecha_Modificacion = isDBNullToNothing(fila("Fecha_Modificacion"))
            .Id_Usuario_Modificacion = isDBNullToNothing(fila("Id_Usuario_Modificacion"))
            .Fecha_Cierre = isDBNullToNothing(fila("Fecha_Cierre"))
            .Cierre = isDBNullToNothing(fila("Cierre"))
            .Id_Programa = isDBNullToNothing(fila("Id_Programa"))

        End With

        Return objEntregas_Adicionales

    End Function

    Public Shared Event LoadingEntregas_AdicionalesList(ByVal LoadType As String)
    Public Shared Event LoadedEntregas_AdicionalesList(ByVal target As List(Of Entregas_AdicionalesBrl), ByVal LoadType As String)

    Public Shared Function CargarTodos() As List(Of Entregas_AdicionalesBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Entregas_AdicionalesBrl)

        RaiseEvent LoadingEntregas_AdicionalesList("CargarTodos")
        dsDatos = Entregas_AdicionalesDAL.CargarTodos()
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedEntregas_AdicionalesList(lista, "CargarTodos")
        Return lista

    End Function

    Public Shared Event LoadingPorId(ByVal id As Int32)
    Public Shared Event LoadedPorId(ByVal target As Entregas_AdicionalesBrl)

    Public Shared Function CargarPorID(ByVal ID As Int32) As Entregas_AdicionalesBrl

        Dim dsDatos As System.Data.DataSet
        Dim objEntregas_Adicionales As Entregas_AdicionalesBrl = Nothing

        dsDatos = Entregas_AdicionalesDAL.CargarPorID(ID)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objEntregas_Adicionales = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objEntregas_Adicionales

    End Function

    Public Shared Function CargarPorId_Programa(ByVal Id_Programa As Int32) As List(Of Entregas_AdicionalesBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Entregas_AdicionalesBrl)

        dsDatos = Entregas_AdicionalesDAL.CargarPorId_Programa(Id_Programa)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function

    Public Shared Function CargarPorId_Tipo_Entrega(ByVal Id_Tipo_Entrega As Int32) As List(Of Entregas_AdicionalesBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Entregas_AdicionalesBrl)

        dsDatos = Entregas_AdicionalesDAL.CargarPorId_Tipo_Entrega(Id_Tipo_Entrega)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        Return lista

    End Function

    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As Int32) As List(Of Entregas_AdicionalesBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Entregas_AdicionalesBrl)

        RaiseEvent LoadingEntregas_AdicionalesList("CargarPorId_Usuario_Creacion")
        dsDatos = Entregas_AdicionalesDAL.CargarPorId_Usuario_Creacion(Id_Usuario_Creacion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedEntregas_AdicionalesList(lista, "CargarPorId_Usuario_Creacion")
        Return lista

    End Function

    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As Int32) As List(Of Entregas_AdicionalesBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Entregas_AdicionalesBrl)

        RaiseEvent LoadingEntregas_AdicionalesList("CargarPorId_Usuario_Modificacion")
        dsDatos = Entregas_AdicionalesDAL.CargarPorId_Usuario_Modificacion(Id_Usuario_Modificacion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedEntregas_AdicionalesList(lista, "CargarPorId_Usuario_Modificacion")
        Return lista

    End Function

End Class


