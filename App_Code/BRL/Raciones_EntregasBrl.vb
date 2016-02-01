Imports ingNovar.Utilidades2
Imports System.Data
Imports System.Collections.Generic
Imports SeguridadUsuarios

Partial Public Class Raciones_EntregasBrl

    Private _Id As Int32
    Private _Id_Racion As Int32
    Private _Id_Tipo_Entrega As Int32
    Private _Fecha_Creacion As DateTime
    Private _Id_Usuario_Creacion As Int32
    Private _Fecha_Modificacion As DateTime
    Private _Id_Usuario_Modificacion As Int32


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


    Public Event Id_Tipo_EntregaChanging(ByVal Value As Int32)
    Public Event Id_Tipo_EntregaChanged()
	
	''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
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

    Public ReadOnly Property Tipo_Entrega() As SubTablasBrl
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

    Public ReadOnly Property Raciones() As RacionesBrl
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
            Me.ID = Raciones_EntregasDAL.Insertar(Id_Racion, Id_Tipo_Entrega, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            Raciones_EntregasDAL.Actualizar(ID, Id_Racion, Id_Tipo_Entrega, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion)
            RaiseEvent Updated()
        End If

        RaiseEvent Saved()

    End Sub
	
	Public Sub Eliminar()
		Dim totalHijos As Long = 0
        If Me.ID <> Nothing Then

            RaiseEvent Deleting()
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")

            Raciones_EntregasDAL.Eliminar(Me.ID)

            RaiseEvent Deleted()

        End If
	End Sub

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Raciones_EntregasBrl
		
		Dim objRaciones_Entregas As New Raciones_EntregasBrl
		
		With objRaciones_Entregas
			.ID = fila("Id")
			.Id_Racion = isDBNullToNothing(fila("Id_Racion"))
			.Id_Tipo_Entrega = isDBNullToNothing(fila("Id_Tipo_Entrega"))
			.Fecha_Creacion = isDBNullToNothing(fila("Fecha_Creacion"))
			.Id_Usuario_Creacion = isDBNullToNothing(fila("Id_Usuario_Creacion"))
			.Fecha_Modificacion = isDBNullToNothing(fila("Fecha_Modificacion"))
			.Id_Usuario_Modificacion = isDBNullToNothing(fila("Id_Usuario_Modificacion"))
        End With
		
		Return objRaciones_Entregas
		
    End Function
	
	Public Shared Event LoadingRaciones_EntregasList(ByVal LoadType As String)
	Public Shared Event LoadedRaciones_EntregasList(target As List(Of Raciones_EntregasBrl), ByVal LoadType As String)
	
	Public Shared Function CargarTodos() As List(Of Raciones_EntregasBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Raciones_EntregasBrl)
	
		RaiseEvent LoadingRaciones_EntregasList("CargarTodos")
	
		dsDatos = Raciones_EntregasDAL.CargarTodos()

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedRaciones_EntregasList(lista, "CargarTodos")
        
        Return lista
        
    End Function

	Public Shared Event LoadingPorId(ByVal id As Int32)
    Public Shared Event LoadedPorId(ByVal target As Raciones_EntregasBrl)

	Public Shared Function CargarPorID(ID As Int32) As Raciones_EntregasBrl

		Dim dsDatos As System.Data.DataSet
		Dim objRaciones_Entregas As Raciones_EntregasBrl = Nothing 
        dsDatos = Raciones_EntregasDAL.CargarPorID(ID)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objRaciones_Entregas = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objRaciones_Entregas
        
    End Function

	Public Shared Function CargarPorId_Tipo_Entrega(ByVal Id_Tipo_Entrega As Int32) As List(Of Raciones_EntregasBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Raciones_EntregasBrl)
	
		RaiseEvent LoadingRaciones_EntregasList("CargarPorId_Tipo_Entrega")
		
		dsDatos = Raciones_EntregasDAL.CargarPorId_Tipo_Entrega(Id_Tipo_Entrega)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedRaciones_EntregasList(lista, "CargarPorId_Tipo_Entrega")
        
        Return lista
        
	End Function

	Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As Int32) As List(Of Raciones_EntregasBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Raciones_EntregasBrl)
	
		RaiseEvent LoadingRaciones_EntregasList("CargarPorId_Usuario_Creacion")
		
		dsDatos = Raciones_EntregasDAL.CargarPorId_Usuario_Creacion(Id_Usuario_Creacion)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedRaciones_EntregasList(lista, "CargarPorId_Usuario_Creacion")
        
        Return lista
        
	End Function

    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As Int32) As List(Of Raciones_EntregasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Raciones_EntregasBrl)

        RaiseEvent LoadingRaciones_EntregasList("CargarPorId_Usuario_Modificacion")

        dsDatos = Raciones_EntregasDAL.CargarPorId_Usuario_Modificacion(Id_Usuario_Modificacion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedRaciones_EntregasList(lista, "CargarPorId_Usuario_Modificacion")

        Return lista

    End Function

    Public Shared Function CargarPorId_Racion(ByVal Id_Racion As Int32) As List(Of Raciones_EntregasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Raciones_EntregasBrl)

        RaiseEvent LoadingRaciones_EntregasList("CargarPorId_Racion")

        dsDatos = Raciones_EntregasDAL.CargarPorId_Racion(Id_Racion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedRaciones_EntregasList(lista, "CargarPorId_Racion")

        Return lista

    End Function



End Class


