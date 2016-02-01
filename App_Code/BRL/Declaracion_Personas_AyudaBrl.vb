Imports ingNovar.Utilidades2
imports system.data
Imports system.collections.generic


Partial Public Class Declaracion_Personas_AyudaBrl

    Private _Id As Int32
    Private _Id_Declaracion As Int32
    Private _Id_Personas_Ayuda As Int32
    Private _Id_Tipo_Entrega As Int32
    Private _Id_Declaracion_Seguimiento As Int32

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

    Public Event Id_Personas_AyudaChanging(ByVal Value As Int32)
    Public Event Id_Personas_AyudaChanged()
	
    Public Property Id_Personas_Ayuda() As Int32
        Get
            Return Me._Id_Personas_Ayuda
        End Get
        Set(ByVal Value As Int32)
            If _Id_Personas_Ayuda <> Value Then
                RaiseEvent Id_Personas_AyudaChanging(Value)
				Me._Id_Personas_Ayuda = Value
                RaiseEvent Id_Personas_AyudaChanged()
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

    Public ReadOnly Property Declaracion() As DeclaracionBrl
        Get
            Return DeclaracionBrl.CargarPorID(Id_Declaracion)
        End Get
    End Property

    Public Readonly Property Personas_Ayuda() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Personas_Ayuda)
        End Get
    End Property

    Public ReadOnly Property Tipo_Entrega() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Tipo_Entrega)
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
            Me.ID = Declaracion_Personas_AyudaDAL.Insertar(Id_Declaracion, Id_Personas_Ayuda, Id_Tipo_Entrega, Id_Declaracion_Seguimiento)
            RaiseEvent Inserted()			
		Else
            RaiseEvent Updating()		
            Declaracion_Personas_AyudaDAL.Actualizar(ID, Id_Declaracion, Id_Personas_Ayuda, Id_Tipo_Entrega, Id_Declaracion_Seguimiento)
            RaiseEvent Updated()			
		End If   

        RaiseEvent Saved()
        
	End Sub
	
	Public Sub Eliminar()
		Dim totalHijos As Long = 0
		If Me.ID <> Nothing Then 
			
            RaiseEvent Deleting()
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            Declaracion_Personas_AyudaDAL.Eliminar(Me.ID)

            RaiseEvent Deleted()
            
        End If
	End Sub

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Declaracion_Personas_AyudaBrl
		
		Dim objDeclaracion_Personas_Ayuda As New Declaracion_Personas_AyudaBrl
		
		With objDeclaracion_Personas_Ayuda
			.ID = fila("Id")
			.Id_Declaracion = isDBNullToNothing(fila("Id_Declaracion"))
			.Id_Personas_Ayuda = isDBNullToNothing(fila("Id_Personas_Ayuda"))
            .Id_Tipo_Entrega = isDBNullToNothing(fila("Id_Tipo_Entrega"))
            .Id_Declaracion_Seguimiento = isDBNullToNothing(fila("Id_Declaracion_Seguimiento"))
		End With
		
		Return objDeclaracion_Personas_Ayuda
		
    End Function
	
	Public Shared Event LoadingDeclaracion_Personas_AyudaList(ByVal LoadType As String)
	Public Shared Event LoadedDeclaracion_Personas_AyudaList(target As List(Of Declaracion_Personas_AyudaBrl), ByVal LoadType As String)
	
	Public Shared Function CargarTodos() As List(Of Declaracion_Personas_AyudaBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_Personas_AyudaBrl)
	
		RaiseEvent LoadingDeclaracion_Personas_AyudaList("CargarTodos")
	
		dsDatos = Declaracion_Personas_AyudaDAL.CargarTodos()

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_Personas_AyudaList(lista, "CargarTodos")
        
        Return lista
        
    End Function

	Public Shared Event CargandoPorId(ByVal id As Int32)
    Public Shared Event CargadoPorId(ByVal target As Declaracion_Personas_AyudaBrl)

	Public Shared Function CargarPorID(ID As Int32) As Declaracion_Personas_AyudaBrl

		Dim dsDatos As System.Data.DataSet
		Dim objDeclaracion_Personas_Ayuda As Declaracion_Personas_AyudaBrl = Nothing 
        dsDatos = Declaracion_Personas_AyudaDAL.CargarPorID(ID)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objDeclaracion_Personas_Ayuda = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objDeclaracion_Personas_Ayuda
        
    End Function

	Public Shared Function CargarPorId_Declaracion(ByVal Id_Declaracion As Int32) As List(Of Declaracion_Personas_AyudaBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_Personas_AyudaBrl)
        RaiseEvent LoadingDeclaracion_Personas_AyudaList("CargarPorId_Declaracion")
        dsDatos = Declaracion_Personas_AyudaDAL.CargarPorId_Declaracion(Id_Declaracion)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedDeclaracion_Personas_AyudaList(lista, "CargarPorId_Declaracion")
        Return lista
        
	End Function

    Public Shared Function CargarPorId_Personas_Ayuda(ByVal Id_Personas_Ayuda As Int32) As List(Of Declaracion_Personas_AyudaBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Declaracion_Personas_AyudaBrl)

        RaiseEvent LoadingDeclaracion_Personas_AyudaList("CargarPorId_Personas_Ayuda")

        dsDatos = Declaracion_Personas_AyudaDAL.CargarPorId_Personas_Ayuda(Id_Personas_Ayuda)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracion_Personas_AyudaList(lista, "CargarPorId_Personas_Ayuda")

        Return lista

    End Function

    Public Shared Function CargarPorId_Tipo_Entrega(ByVal Id_Tipo_Entrega As Int32) As List(Of Declaracion_Personas_AyudaBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Declaracion_Personas_AyudaBrl)

        RaiseEvent LoadingDeclaracion_Personas_AyudaList("CargarPorId_Tipo_Entrega")

        dsDatos = Declaracion_Personas_AyudaDAL.CargarPorId_Tipo_Entrega(Id_Tipo_Entrega)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracion_Personas_AyudaList(lista, "CargarPorId_Tipo_Entrega")

        Return lista

    End Function

    Public Shared Function CargarPorId_Declaracion_Seguimiento(ByVal Id_Declaracion_Seguimiennto As Int32) As List(Of Declaracion_Personas_AyudaBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Declaracion_Personas_AyudaBrl)

        dsDatos = Declaracion_Personas_AyudaDAL.CargarPorId_Declaracion_Seguimiento(Id_Declaracion_Seguimiennto)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        Return lista

    End Function


End Class


