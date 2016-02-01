Imports ingNovar.Utilidades2
Imports System.Data
Imports System.Collections.Generic
Imports SeguridadUsuarios

Partial Public Class EntregasBrl

    Private _Id As Int32
    Private _Fecha As DateTime
    Private _Dias As Int32
    Private _Id_Declaracion As Int32
    Private _Id_Tipo As Int32
    Private _Id_Producto As Int32
    Private _Id_Capacidad As Int32
    Private _Cantidad As Double
    Private _Id_Orden_Salida As Int32
    Private _Id_Racion As Int32
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

    Public Event DiasChanging(ByVal Value As Int32)
    Public Event DiasChanged()
	
    Public Property Dias() As Int32
        Get
            Return Me._Dias
        End Get
        Set(ByVal Value As Int32)
            If _Dias <> Value Then
                RaiseEvent DiasChanging(Value)
				Me._Dias = Value
                RaiseEvent DiasChanged()
            End If
        End Set
    End Property

    Public Event Id_DeclaracionChanging(ByVal Value As Int32)
    Public Event Id_DeclaracionChanged()
	
    Public Property Id_Declaracion() As Int32
        Get
            Return Me._Id_Declaracion
        End Get
        Set(ByVal Value As Int32)
            If _Id_Declaracion <> Value Then
                RaiseEvent Id_DeclaracionChanging(Value)
				Me._Id_Declaracion = Value
                RaiseEvent Id_DeclaracionChanged()
            End If
        End Set
    End Property

    Public Event Id_TipoChanging(ByVal Value As Int32)
    Public Event Id_TipoChanged()
	
    Public Property Id_Tipo() As Int32
        Get
            Return Me._Id_Tipo
        End Get
        Set(ByVal Value As Int32)
            If _Id_Tipo <> Value Then
                RaiseEvent Id_TipoChanging(Value)
				Me._Id_Tipo = Value
                RaiseEvent Id_TipoChanged()
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

    Public Event Id_Orden_SalidaChanging(ByVal Value As Int32)
    Public Event Id_Orden_SalidaChanged()
	
    Public Property Id_Orden_Salida() As Int32
        Get
            Return Me._Id_Orden_Salida
        End Get
        Set(ByVal Value As Int32)
            If _Id_Orden_Salida <> Value Then
                RaiseEvent Id_Orden_SalidaChanging(Value)
				Me._Id_Orden_Salida = Value
                RaiseEvent Id_Orden_SalidaChanged()
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

    Public Readonly Property SubTablasCapacidad() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Capacidad)
        End Get
    End Property

    Public Readonly Property Declaracion() As DeclaracionBrl
        Get
            Return DeclaracionBrl.CargarPorID(Id_Declaracion)
        End Get
    End Property

    Public Readonly Property SubTablasProducto() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Producto)
        End Get
    End Property

    Public Readonly Property Raciones() As RacionesBrl
        Get
            Return RacionesBrl.CargarPorID(Id_Racion)
        End Get
    End Property

    Public Readonly Property SubTablasTipoEntrega() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Tipo)
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

    Public Readonly Property Salidas() As SalidasBrl
        Get
            Return SalidasBrl.CargarPorID(Id_Orden_Salida)
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
            Me.ID = EntregasDAL.Insertar(Fecha, Dias, Id_Declaracion, Id_Tipo, Id_Producto, Id_Capacidad, Cantidad, Id_Orden_Salida, Id_Racion, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Fecha_Cierre, Cierre)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            EntregasDAL.Actualizar(ID, Fecha, Dias, Id_Declaracion, Id_Tipo, Id_Producto, Id_Capacidad, Cantidad, Id_Orden_Salida, Id_Racion, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Fecha_Cierre, Cierre)
            RaiseEvent Updated()
        End If
        RaiseEvent Saved()

    End Sub
	
	Public Sub Eliminar()
		Dim totalHijos As Long = 0
		If Me.ID <> Nothing Then 
			
            RaiseEvent Deleting()
            
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            
			EntregasDAL.Eliminar(Me.ID)
			
            RaiseEvent Deleted()
            
        End If
	End Sub
	
    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As EntregasBrl

        Dim objEntregas As New EntregasBrl

        With objEntregas
            .ID = fila("Id")
            .Fecha = isDBNullToNothing(fila("Fecha"))
            .Dias = isDBNullToNothing(fila("Dias"))
            .Id_Declaracion = isDBNullToNothing(fila("Id_Declaracion"))
            .Id_Tipo = isDBNullToNothing(fila("Id_Tipo"))
            .Id_Producto = isDBNullToNothing(fila("Id_Producto"))
            .Id_Capacidad = isDBNullToNothing(fila("Id_Capacidad"))
            .Cantidad = isDBNullToNothing(fila("Cantidad"))
            .Id_Orden_Salida = isDBNullToNothing(fila("Id_Orden_Salida"))
            .Id_Racion = isDBNullToNothing(fila("Id_Racion"))
            .Fecha_Creacion = isDBNullToNothing(fila("Fecha_Creacion"))
            .Id_Usuario_Creacion = isDBNullToNothing(fila("Id_Usuario_Creacion"))
            .Fecha_Modificacion = isDBNullToNothing(fila("Fecha_Modificacion"))
            .Id_Usuario_Modificacion = isDBNullToNothing(fila("Id_Usuario_Modificacion"))
            .Fecha_Cierre = isDBNullToNothing(fila("Fecha_Cierre"))
            .Cierre = isDBNullToNothing(fila("Cierre"))
        End With

        Return objEntregas

    End Function
	
	Public Shared Event LoadingEntregasList(ByVal LoadType As String)
	Public Shared Event LoadedEntregasList(target As List(Of EntregasBrl), ByVal LoadType As String)
	
	Public Shared Function CargarTodos() As List(Of EntregasBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of EntregasBrl)
	
		RaiseEvent LoadingEntregasList("CargarTodos")
	
		dsDatos = EntregasDAL.CargarTodos()

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedEntregasList(lista, "CargarTodos")
        
        Return lista
        
    End Function

	Public Shared Event CargandoPorId(ByVal id As Int32)
    Public Shared Event CargadoPorId(ByVal target As EntregasBrl)

	Public Shared Function CargarPorID(ID As Int32) As EntregasBrl

		Dim dsDatos As System.Data.DataSet
		Dim objEntregas As EntregasBrl = Nothing 
		
		'RaiseEvent CargandoPorId(ID)
			
		dsDatos = EntregasDAL.CargarPorID(ID)
		
		If dsDatos.Tables(0).Rows.Count <> 0 Then objEntregas = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
		
		'RaiseEvent CargadoPorId(objJoven)

        Return objEntregas
        
    End Function
	Public Shared Function CargarPorId_Capacidad(ByVal Id_Capacidad As Int32) As List(Of EntregasBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of EntregasBrl)
	
		RaiseEvent LoadingEntregasList("CargarPorId_Capacidad")
		
		dsDatos = EntregasDAL.CargarPorId_Capacidad(Id_Capacidad)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedEntregasList(lista, "CargarPorId_Capacidad")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Declaracion(ByVal Id_Declaracion As Int32) As List(Of EntregasBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of EntregasBrl)
	
		RaiseEvent LoadingEntregasList("CargarPorId_Declaracion")
		
		dsDatos = EntregasDAL.CargarPorId_Declaracion(Id_Declaracion)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedEntregasList(lista, "CargarPorId_Declaracion")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Producto(ByVal Id_Producto As Int32) As List(Of EntregasBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of EntregasBrl)
	
		RaiseEvent LoadingEntregasList("CargarPorId_Producto")
		
		dsDatos = EntregasDAL.CargarPorId_Producto(Id_Producto)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedEntregasList(lista, "CargarPorId_Producto")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Racion(ByVal Id_Racion As Int32) As List(Of EntregasBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of EntregasBrl)
	
		RaiseEvent LoadingEntregasList("CargarPorId_Racion")
		
		dsDatos = EntregasDAL.CargarPorId_Racion(Id_Racion)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedEntregasList(lista, "CargarPorId_Racion")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Tipo(ByVal Id_Tipo As Int32) As List(Of EntregasBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of EntregasBrl)
	
		RaiseEvent LoadingEntregasList("CargarPorId_Tipo")
		
		dsDatos = EntregasDAL.CargarPorId_Tipo(Id_Tipo)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedEntregasList(lista, "CargarPorId_Tipo")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As Int32) As List(Of EntregasBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of EntregasBrl)
	
		RaiseEvent LoadingEntregasList("CargarPorId_Usuario_Creacion")
		
		dsDatos = EntregasDAL.CargarPorId_Usuario_Creacion(Id_Usuario_Creacion)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedEntregasList(lista, "CargarPorId_Usuario_Creacion")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As Int32) As List(Of EntregasBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of EntregasBrl)
	
		RaiseEvent LoadingEntregasList("CargarPorId_Usuario_Modificacion")
		
		dsDatos = EntregasDAL.CargarPorId_Usuario_Modificacion(Id_Usuario_Modificacion)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedEntregasList(lista, "CargarPorId_Usuario_Modificacion")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Orden_Salida(ByVal Id_Orden_Salida As Int32) As List(Of EntregasBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of EntregasBrl)
	
		RaiseEvent LoadingEntregasList("CargarPorId_Orden_Salida")
		
		dsDatos = EntregasDAL.CargarPorId_Orden_Salida(Id_Orden_Salida)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedEntregasList(lista, "CargarPorId_Orden_Salida")
        
        Return lista
        
	End Function



End Class


