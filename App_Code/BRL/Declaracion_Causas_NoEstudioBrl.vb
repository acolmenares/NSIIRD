Imports ingNovar.Utilidades2
imports system.data
Imports system.Collections.generic
Imports SeguridadUsuarios

Partial Public Class Declaracion_Causas_NoEstudioBrl

    Private _Id As Int32
    Private _Id_Declaracion As Int32
    Private _Id_Causa_No_Estudio As Int32
    Private _Cuantos As Int32
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

    Public Event Id_Causa_No_EstudioChanging(ByVal Value As Int32)
    Public Event Id_Causa_No_EstudioChanged()
	
    Public Property Id_Causa_No_Estudio() As Int32
        Get
            Return Me._Id_Causa_No_Estudio
        End Get
        Set(ByVal Value As Int32)
            If _Id_Causa_No_Estudio <> Value Then
                RaiseEvent Id_Causa_No_EstudioChanging(Value)
				Me._Id_Causa_No_Estudio = Value
                RaiseEvent Id_Causa_No_EstudioChanged()
            End If
        End Set
    End Property

    Public Event CuantosChanging(ByVal Value As Int32)
    Public Event CuantosChanged()
	
    Public Property Cuantos() As Int32
        Get
            Return Me._Cuantos
        End Get
        Set(ByVal Value As Int32)
            If _Cuantos <> Value Then
                RaiseEvent CuantosChanging(Value)
				Me._Cuantos = Value
                RaiseEvent CuantosChanged()
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

    Public Readonly Property Declaracion() As DeclaracionBrl
        Get
            Return DeclaracionBrl.CargarPorID(Id_Declaracion)
        End Get
    End Property

    Public Readonly Property SubTablasCausa_No_Estudio() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Causa_No_Estudio)
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
            Me.ID = Declaracion_Causas_NoEstudioDAL.Insertar(Id_Declaracion, Id_Causa_No_Estudio, Cuantos, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Fecha_Cierre, Cierre)
            RaiseEvent Inserted()			
		Else
            RaiseEvent Updating()		
            Declaracion_Causas_NoEstudioDAL.Actualizar(ID, Id_Declaracion, Id_Causa_No_Estudio, Cuantos, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Fecha_Cierre, Cierre)
            RaiseEvent Updated()			
		End If   


        RaiseEvent Saved()
        
	End Sub
	
	Public Sub Eliminar()
		Dim totalHijos As Long = 0
		If Me.ID <> Nothing Then 
			
            RaiseEvent Deleting()

            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            
			Declaracion_Causas_NoEstudioDAL.Eliminar(Me.ID)
			
            RaiseEvent Deleted()
            
        End If
	End Sub
	

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Declaracion_Causas_NoEstudioBrl
		
		Dim objDeclaracion_Causas_NoEstudio As New Declaracion_Causas_NoEstudioBrl
		
		With objDeclaracion_Causas_NoEstudio
			.ID = fila("Id")
			.Id_Declaracion = isDBNullToNothing(fila("Id_Declaracion"))
			.Id_Causa_No_Estudio = isDBNullToNothing(fila("Id_Causa_No_Estudio"))
			.Cuantos = isDBNullToNothing(fila("Cuantos"))
			.Fecha_Creacion = isDBNullToNothing(fila("Fecha_Creacion"))
			.Id_Usuario_Creacion = isDBNullToNothing(fila("Id_Usuario_Creacion"))
			.Fecha_Modificacion = isDBNullToNothing(fila("Fecha_Modificacion"))
			.Id_Usuario_Modificacion = isDBNullToNothing(fila("Id_Usuario_Modificacion"))
            .Fecha_Cierre = isDBNullToNothing(fila("Fecha_Cierre"))
            .Cierre = isDBNullToNothing(fila("Cierre"))
		End With
		
		Return objDeclaracion_Causas_NoEstudio
		
    End Function
	
	Public Shared Event LoadingDeclaracion_Causas_NoEstudioList(ByVal LoadType As String)
	Public Shared Event LoadedDeclaracion_Causas_NoEstudioList(target As List(Of Declaracion_Causas_NoEstudioBrl), ByVal LoadType As String)
	
	Public Shared Function CargarTodos() As List(Of Declaracion_Causas_NoEstudioBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_Causas_NoEstudioBrl)
	
		RaiseEvent LoadingDeclaracion_Causas_NoEstudioList("CargarTodos")
	
		dsDatos = Declaracion_Causas_NoEstudioDAL.CargarTodos()

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_Causas_NoEstudioList(lista, "CargarTodos")
        
        Return lista
        
    End Function

	Public Shared Event CargandoPorId(ByVal id As Int32)
    Public Shared Event CargadoPorId(ByVal target As Declaracion_Causas_NoEstudioBrl)

	Public Shared Function CargarPorID(ID As Int32) As Declaracion_Causas_NoEstudioBrl

		Dim dsDatos As System.Data.DataSet
		Dim objDeclaracion_Causas_NoEstudio As Declaracion_Causas_NoEstudioBrl = Nothing 
		
		RaiseEvent CargandoPorId(ID)
			
		dsDatos = Declaracion_Causas_NoEstudioDAL.CargarPorID(ID)
		
		If dsDatos.Tables(0).Rows.Count <> 0 Then objDeclaracion_Causas_NoEstudio = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
		
        Return objDeclaracion_Causas_NoEstudio
        
    End Function

	Public Shared Function CargarPorId_Declaracion(ByVal Id_Declaracion As Int32) As List(Of Declaracion_Causas_NoEstudioBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_Causas_NoEstudioBrl)
	
		RaiseEvent LoadingDeclaracion_Causas_NoEstudioList("CargarPorId_Declaracion")
		
		dsDatos = Declaracion_Causas_NoEstudioDAL.CargarPorId_Declaracion(Id_Declaracion)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_Causas_NoEstudioList(lista, "CargarPorId_Declaracion")
        
        Return lista
        
	End Function

    Public Shared Function CargarPorId_Causa_No_Estudio(ByVal Id_Causa_No_Estudio As Int32) As List(Of Declaracion_Causas_NoEstudioBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Declaracion_Causas_NoEstudioBrl)

        RaiseEvent LoadingDeclaracion_Causas_NoEstudioList("CargarPorId_Causa_No_Estudio")

        dsDatos = Declaracion_Causas_NoEstudioDAL.CargarPorId_Causa_No_Estudio(Id_Causa_No_Estudio)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracion_Causas_NoEstudioList(lista, "CargarPorId_Causa_No_Estudio")

        Return lista

    End Function

	Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As Int32) As List(Of Declaracion_Causas_NoEstudioBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_Causas_NoEstudioBrl)
	
		RaiseEvent LoadingDeclaracion_Causas_NoEstudioList("CargarPorId_Usuario_Creacion")
		
		dsDatos = Declaracion_Causas_NoEstudioDAL.CargarPorId_Usuario_Creacion(Id_Usuario_Creacion)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_Causas_NoEstudioList(lista, "CargarPorId_Usuario_Creacion")
        
        Return lista
        
	End Function

	Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As Int32) As List(Of Declaracion_Causas_NoEstudioBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_Causas_NoEstudioBrl)
	
		RaiseEvent LoadingDeclaracion_Causas_NoEstudioList("CargarPorId_Usuario_Modificacion")
		
		dsDatos = Declaracion_Causas_NoEstudioDAL.CargarPorId_Usuario_Modificacion(Id_Usuario_Modificacion)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_Causas_NoEstudioList(lista, "CargarPorId_Usuario_Modificacion")
        
        Return lista
        
	End Function

End Class


