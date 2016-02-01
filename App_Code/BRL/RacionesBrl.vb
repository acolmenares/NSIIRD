Imports ingNovar.Utilidades2
Imports System.Data
Imports System.Collections.Generic
Imports SeguridadUsuarios

Partial Public Class RacionesBrl

    Private _Id As Int32
    Private _Id_Producto As Int32
    Private _Fecha_Inicial As DateTime
    Private _Fecha_Final As DateTime
    Private _Cantidad As Double
    Private _Id_Capacidad As Int32
    Private _Por_Familia As Boolean
    Private _Por_Persona As Boolean
    Private _Fecha_Creacion As DateTime
    Private _Id_Usuario_Creacion As Int32
    Private _Fecha_Modificacion As DateTime
    Private _Id_Usuario_Modificacion As Int32

    Private objListRaciones_Entregas As List(Of Raciones_EntregasBrl)
    Private objListRaciones_Lugares As List(Of Raciones_LugaresBrl)
    Private objListRaciones_Tipos As List(Of Raciones_TiposBrl)


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

    Public Event Fecha_InicialChanging(ByVal Value As DateTime)
    Public Event Fecha_InicialChanged()
	
    Public Property Fecha_Inicial() As DateTime
        Get
            Return Me._Fecha_Inicial
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_Inicial <> Value Then
                RaiseEvent Fecha_InicialChanging(Value)
                Me._Fecha_Inicial = Value
                RaiseEvent Fecha_InicialChanged()
            End If
        End Set
    End Property

    Public Event Fecha_FinalChanging(ByVal Value As DateTime)
    Public Event Fecha_FinalChanged()

    Public Property Fecha_Final() As DateTime
        Get
            Return Me._Fecha_Final
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_Final <> Value Then
                RaiseEvent Fecha_FinalChanging(Value)
				Me._Fecha_Final = Value
                RaiseEvent Fecha_FinalChanged()
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

    Public Event Id_CapacidadChanging(ByVal Value As Int32)
    Public Event Id_CapacidadChanged()

    Public Property Id_Capacidad() As Int32
        Get
            Return Me._Id_Capacidad
        End Get
        Set(ByVal Value As Int32)
            If _Id_Capacidad <> Value Then
                RaiseEvent Id_CapacidadChanging(Value)
				Me._Id_Capacidad = Value
                RaiseEvent Id_CapacidadChanged()
            End If
        End Set
    End Property

    Public Event Por_PersonaChanging(ByVal Value As Boolean)
    Public Event Por_PersonaChanged()

    Public Property Por_Persona() As Boolean
        Get
            Return Me._Por_Persona
        End Get
        Set(ByVal Value As Boolean)
            If _Por_Persona <> Value Then
                RaiseEvent Por_PersonaChanging(Value)
                Me._Por_Persona = Value
                RaiseEvent Por_PersonaChanged()
            End If
        End Set
    End Property

    Public Event Por_FamiliaChanging(ByVal Value As Boolean)
    Public Event Por_FamiliaChanged()

    Public Property Por_Familia() As Boolean
        Get
            Return Me._Por_Familia
        End Get
        Set(ByVal Value As Boolean)
            If _Por_Familia <> Value Then
                RaiseEvent Por_FamiliaChanging(Value)
				Me._Por_Familia = Value
                RaiseEvent Por_FamiliaChanged()
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

    Public ReadOnly Property Capacidad() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Capacidad)
        End Get
    End Property

    Public ReadOnly Property Producto() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Producto)
        End Get
    End Property

    Public Readonly Property UsuariosCreacion() As UsuariosBrl
        Get
            Return UsuariosBrl.CargarPorID(Id_Usuario_Creacion)
        End Get
    End Property

    Public Readonly Property UsuariosModificacion() As UsuariosBrl
        Get
            Return UsuariosBrl.CargarPorID(Id_Usuario_Modificacion)
        End Get
    End Property

    Public Property Raciones_Entregas() As List(Of Raciones_EntregasBrl)
        Get
            If (Me.objListRaciones_Entregas Is Nothing) Then
                objListRaciones_Entregas = Raciones_EntregasBrl.CargarPorId_Racion(Me.ID)
            End If
            Return Me.objListRaciones_Entregas
        End Get
        Set(ByVal Value As List(Of Raciones_EntregasBrl))
            Me.objListRaciones_Entregas = Value
        End Set
    End Property

    Public Property Raciones_Lugares() As List(Of Raciones_LugaresBrl)
        Get
            If (Me.objListRaciones_Lugares Is Nothing) Then
                objListRaciones_Lugares = Raciones_LugaresBrl.CargarPorId_Racion(Me.ID)
            End If
            Return Me.objListRaciones_Lugares
        End Get
        Set(ByVal Value As List(Of Raciones_LugaresBrl))
            Me.objListRaciones_Lugares = Value
        End Set
    End Property

    Public Property Raciones_Tipos() As List(Of Raciones_TiposBrl)
        Get
            If (Me.objListRaciones_Tipos Is Nothing) Then
                objListRaciones_Tipos = Raciones_TiposBrl.CargarPorId_Racion(Me.ID)
            End If
            Return Me.objListRaciones_Tipos
        End Get
        Set(ByVal Value As List(Of Raciones_TiposBrl))
            Me.objListRaciones_Tipos = Value
        End Set
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
            Me.ID = RacionesDAL.Insertar(Id_Producto, Fecha_Inicial, Fecha_Final, Cantidad, Id_Capacidad, Por_Persona, Por_Familia, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion)
            RaiseEvent Inserted()			
		Else
            RaiseEvent Updating()		
            RacionesDAL.Actualizar(ID, Id_Producto, Fecha_Inicial, Fecha_Final, Cantidad, Id_Capacidad, Por_Persona, Por_Familia, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion)
            RaiseEvent Updated()			
		End If   
        If Not objListRaciones_Entregas Is Nothing Then
            For Each fila As Raciones_EntregasBrl In objListRaciones_Entregas
                fila.Id_Racion = Me.ID
                Try
					fila.Guardar()
				Catch ex as Exception
				End Try
            Next
        End If

        If Not objListRaciones_Lugares Is Nothing Then
            For Each fila As Raciones_LugaresBrl In objListRaciones_Lugares
                fila.Id_Racion = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListRaciones_Tipos Is Nothing Then
            For Each fila As Raciones_TiposBrl In objListRaciones_Tipos
                fila.Id_Racion = Me.ID
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
            totalHijos += Raciones_Entregas.Count
            totalHijos += Raciones_Lugares.Count
            totalHijos += Raciones_Tipos.Count

            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            
			RacionesDAL.Eliminar(Me.ID)
			
            RaiseEvent Deleted()
            
        End If
	End Sub

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As RacionesBrl
		
		Dim objRaciones As New RacionesBrl
		
		With objRaciones
			.ID = fila("Id")
			.Id_Producto = isDBNullToNothing(fila("Id_Producto"))
            .Fecha_Inicial = isDBNullToNothing(fila("Fecha_Inicial"))
			.Fecha_Final = isDBNullToNothing(fila("Fecha_Final"))
			.Cantidad = isDBNullToNothing(fila("Cantidad"))
			.Id_Capacidad = isDBNullToNothing(fila("Id_Capacidad"))
            .Por_Familia = isDBNullToNothing(fila("Por_Familia"))
            .Por_Persona = isDBNullToNothing(fila("Por_Persona"))
            .Fecha_Creacion = isDBNullToNothing(fila("Fecha_Creacion"))
			.Id_Usuario_Creacion = isDBNullToNothing(fila("Id_Usuario_Creacion"))
			.Fecha_Modificacion = isDBNullToNothing(fila("Fecha_Modificacion"))
            .Id_Usuario_Modificacion = isDBNullToNothing(fila("Id_Usuario_Modificacion"))

		End With
		
		Return objRaciones
		
    End Function
	
	Public Shared Event LoadingRacionesList(ByVal LoadType As String)
	Public Shared Event LoadedRacionesList(target As List(Of RacionesBrl), ByVal LoadType As String)
	
	Public Shared Function CargarTodos() As List(Of RacionesBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of RacionesBrl)
	
		RaiseEvent LoadingRacionesList("CargarTodos")
	
		dsDatos = RacionesDAL.CargarTodos()

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedRacionesList(lista, "CargarTodos")
        
        Return lista
        
    End Function

	Public Shared Event LoadingPorId(ByVal id As Int32)
    Public Shared Event LoadedPorId(ByVal target As RacionesBrl)

	Public Shared Function CargarPorID(ID As Int32) As RacionesBrl

		Dim dsDatos As System.Data.DataSet
		Dim objRaciones As RacionesBrl = Nothing 
        dsDatos = RacionesDAL.CargarPorID(ID)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objRaciones = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
		
        Return objRaciones
        
    End Function

	Public Shared Function CargarPorId_Capacidad(ByVal Id_Capacidad As Int32) As List(Of RacionesBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of RacionesBrl)
	
		RaiseEvent LoadingRacionesList("CargarPorId_Capacidad")
		
		dsDatos = RacionesDAL.CargarPorId_Capacidad(Id_Capacidad)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedRacionesList(lista, "CargarPorId_Capacidad")
        
        Return lista
        
	End Function

	Public Shared Function CargarPorId_Producto(ByVal Id_Producto As Int32) As List(Of RacionesBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of RacionesBrl)
	
		RaiseEvent LoadingRacionesList("CargarPorId_Producto")
        dsDatos = RacionesDAL.CargarPorId_Producto(Id_Producto)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedRacionesList(lista, "CargarPorId_Producto")
        
        Return lista
        
	End Function

	Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As Int32) As List(Of RacionesBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of RacionesBrl)
	
		RaiseEvent LoadingRacionesList("CargarPorId_Usuario_Creacion")
		
		dsDatos = RacionesDAL.CargarPorId_Usuario_Creacion(Id_Usuario_Creacion)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedRacionesList(lista, "CargarPorId_Usuario_Creacion")
        
        Return lista
        
	End Function

	Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As Int32) As List(Of RacionesBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of RacionesBrl)
	
		RaiseEvent LoadingRacionesList("CargarPorId_Usuario_Modificacion")
		
		dsDatos = RacionesDAL.CargarPorId_Usuario_Modificacion(Id_Usuario_Modificacion)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedRacionesList(lista, "CargarPorId_Usuario_Modificacion")
        
        Return lista
        
	End Function


    Public Shared Function CargarRaciones(ByVal fecha As String, ByVal id_lugar As Int32, ByVal id_tipoentrega As Int32) As List(Of RacionesBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of RacionesBrl)
        dsDatos = RacionesDAL.CargarRaciones(fecha, id_lugar, id_tipoentrega)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

End Class


