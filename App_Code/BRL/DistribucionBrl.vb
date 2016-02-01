Imports ingNovar.Utilidades2
imports system.data
Imports system.collections.generic

Partial Public Class DistribucionBrl

    Private _Id As Int32
    Private _Id_Tipo_Entrega As Int32
    Private _Id_Atendido As Int32
    Private _Fecha As DateTime
    Private _Dias As Int32
    Private _Id_Grupo As Int32
    Private _Id_Salida As Int32
    Private _Id_Racion As Int32
    Private _Fecha_Cierre As DateTime
    Private _Cierre As Boolean

    Private objListDistribucion_Detalle As List(Of Distribucion_DetalleBrl)

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

    Public Event Id_AtendidoChanging(ByVal Value As Int32)
    Public Event Id_AtendidoChanged()
	
    Public Property Id_Atendido() As Int32
        Get
            Return Me._Id_Atendido
        End Get
        Set(ByVal Value As Int32)
            If _Id_Atendido <> Value Then
                RaiseEvent Id_AtendidoChanging(Value)
				Me._Id_Atendido = Value
                RaiseEvent Id_AtendidoChanged()
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

    Public Event Id_GrupoChanging(ByVal Value As Int32)
    Public Event Id_GrupoChanged()
	
    Public Property Id_Grupo() As Int32
        Get
            Return Me._Id_Grupo
        End Get
        Set(ByVal Value As Int32)
            If _Id_Grupo <> Value Then
                RaiseEvent Id_GrupoChanging(Value)
				Me._Id_Grupo = Value
                RaiseEvent Id_GrupoChanged()
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

    Public Property Distribucion_Detalle() As List(Of Distribucion_DetalleBrl)
        Get
            If (Me.objListDistribucion_Detalle Is Nothing) Then
                objListDistribucion_Detalle = Distribucion_DetalleBrl.CargarPorId_Distribucion(Me.ID)
            End If
            Return Me.objListDistribucion_Detalle
        End Get
        Set(ByVal Value As List(Of Distribucion_DetalleBrl))
            Me.objListDistribucion_Detalle = Value
        End Set
    End Property

    Public Readonly Property SubTablasAtendido() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Atendido)
        End Get
    End Property

    Public Readonly Property SubTablasGrupo() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Grupo)
        End Get
    End Property

    Public Readonly Property Raciones() As RacionesBrl
        Get
            Return RacionesBrl.CargarPorID(Id_Racion)
        End Get
    End Property

    Public Readonly Property Salidas() As SalidasBrl
        Get
            Return SalidasBrl.CargarPorID(Id_Salida)
        End Get
    End Property

    Public Readonly Property SubTablasTipoEntrega() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Tipo_Entrega)
        End Get
    End Property

    Public ReadOnly Property Atendido() As String
        Get
            If SubTablasAtendido Is Nothing Then
                Return ""
            Else
                Return SubTablasAtendido.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property NumeroSalida() As String
        Get
            If Salidas Is Nothing Then
                Return ""
            Else
                Return Salidas.Numero
            End If
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
            Me.ID = DistribucionDAL.Insertar(Id_Tipo_Entrega, Id_Atendido, Fecha, Dias, Id_Grupo, Id_Salida, Id_Racion, Fecha_Cierre, Cierre)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            DistribucionDAL.Actualizar(ID, Id_Tipo_Entrega, Id_Atendido, Fecha, Dias, Id_Grupo, Id_Salida, Id_Racion, Fecha_Cierre, Cierre)
            RaiseEvent Updated()
        End If
        If Not objListDistribucion_Detalle Is Nothing Then
            For Each fila As Distribucion_DetalleBrl In objListDistribucion_Detalle
                fila.Id_Distribucion = Me.ID
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
            totalHijos += Distribucion_Detalle.Count

            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            
			DistribucionDAL.Eliminar(Me.ID)
			
            RaiseEvent Deleted()
            
        End If
	End Sub

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As DistribucionBrl
		
		Dim objDistribucion As New DistribucionBrl
		
		With objDistribucion
			.ID = fila("Id")
			.Id_Tipo_Entrega = isDBNullToNothing(fila("Id_Tipo_Entrega"))
			.Id_Atendido = isDBNullToNothing(fila("Id_Atendido"))
			.Fecha = isDBNullToNothing(fila("Fecha"))
			.Dias = isDBNullToNothing(fila("Dias"))
			.Id_Grupo = isDBNullToNothing(fila("Id_Grupo"))
			.Id_Salida = isDBNullToNothing(fila("Id_Salida"))
			.Id_Racion = isDBNullToNothing(fila("Id_Racion"))
            .Fecha_Cierre = isDBNullToNothing(fila("Fecha_Cierre"))
            .Cierre = isDBNullToNothing(fila("Cierre"))
		End With
		
		Return objDistribucion
		
    End Function
	
	Public Shared Event LoadingDistribucionList(ByVal LoadType As String)
	Public Shared Event LoadedDistribucionList(target As List(Of DistribucionBrl), ByVal LoadType As String)
	
	Public Shared Function CargarTodos() As List(Of DistribucionBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of DistribucionBrl)
	
		RaiseEvent LoadingDistribucionList("CargarTodos")
	
		dsDatos = DistribucionDAL.CargarTodos()

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDistribucionList(lista, "CargarTodos")
        
        Return lista
        
    End Function

	Public Shared Event CargandoPorId(ByVal id As Int32)
    Public Shared Event CargadoPorId(ByVal target As DistribucionBrl)

	Public Shared Function CargarPorID(ID As Int32) As DistribucionBrl

		Dim dsDatos As System.Data.DataSet
		Dim objDistribucion As DistribucionBrl = Nothing 
        dsDatos = DistribucionDAL.CargarPorID(ID)

		If dsDatos.Tables(0).Rows.Count <> 0 Then objDistribucion = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objDistribucion
        
    End Function

	Public Shared Function CargarPorId_Atendido(ByVal Id_Atendido As Int32) As List(Of DistribucionBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of DistribucionBrl)
	
		RaiseEvent LoadingDistribucionList("CargarPorId_Atendido")
		
		dsDatos = DistribucionDAL.CargarPorId_Atendido(Id_Atendido)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDistribucionList(lista, "CargarPorId_Atendido")
        
        Return lista
        
	End Function

    Public Shared Function CargarPorId_Grupo(ByVal Id_Grupo As Int32) As List(Of DistribucionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DistribucionBrl)

        RaiseEvent LoadingDistribucionList("CargarPorId_Grupo")

        dsDatos = DistribucionDAL.CargarPorId_Grupo(Id_Grupo)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDistribucionList(lista, "CargarPorId_Grupo")

        Return lista

    End Function

    Public Shared Function CargarPorId_Racion(ByVal Id_Racion As Int32) As List(Of DistribucionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DistribucionBrl)

        RaiseEvent LoadingDistribucionList("CargarPorId_Racion")

        dsDatos = DistribucionDAL.CargarPorId_Racion(Id_Racion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDistribucionList(lista, "CargarPorId_Racion")

        Return lista

    End Function

    Public Shared Function CargarPorId_Salida(ByVal Id_Salida As Int32) As List(Of DistribucionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DistribucionBrl)

        RaiseEvent LoadingDistribucionList("CargarPorId_Salida")

        dsDatos = DistribucionDAL.CargarPorId_Salida(Id_Salida)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDistribucionList(lista, "CargarPorId_Salida")

        Return lista

    End Function

    Public Shared Function CargarPorId_Tipo_Entrega(ByVal Id_Tipo_Entrega As Int32) As List(Of DistribucionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of DistribucionBrl)

        RaiseEvent LoadingDistribucionList("CargarPorId_Tipo_Entrega")

        dsDatos = DistribucionDAL.CargarPorId_Tipo_Entrega(Id_Tipo_Entrega)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDistribucionList(lista, "CargarPorId_Tipo_Entrega")

        Return lista

    End Function

End Class


