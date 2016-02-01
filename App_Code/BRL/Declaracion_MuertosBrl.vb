Imports ingNovar.Utilidades2
imports system.data
Imports system.collections.generic


Partial Public Class Declaracion_MuertosBrl

    Private _Id As Int32
    Private _Id_Declaracion As Int32
    Private _Tipo As String
    Private _Mayor_Menor As String
    Private _Id_Motivo_Muerte As Int32
    Private _Id_Enfermedad As Int32
    Private _Id_Parentesco As Int32
    Private _Id_Velar_Enterrar As Int32


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

    Public Event TipoChanging(ByVal Value As String)
    Public Event TipoChanged()
	
    Public Property Tipo() As String
        Get
            Return Me._Tipo
        End Get
        Set(ByVal Value As String)
            If _Tipo <> Value Then
                RaiseEvent TipoChanging(Value)
				Me._Tipo = Value
                RaiseEvent TipoChanged()
            End If
        End Set
    End Property

    Public Event Mayor_MenorChanging(ByVal Value As String)
    Public Event Mayor_MenorChanged()
	
    Public Property Mayor_Menor() As String
        Get
            Return Me._Mayor_Menor
        End Get
        Set(ByVal Value As String)
            If _Mayor_Menor <> Value Then
                RaiseEvent Mayor_MenorChanging(Value)
				Me._Mayor_Menor = Value
                RaiseEvent Mayor_MenorChanged()
            End If
        End Set
    End Property

    Public Event Id_Motivo_MuerteChanging(ByVal Value As Int32)
    Public Event Id_Motivo_MuerteChanged()
	
    Public Property Id_Motivo_Muerte() As Int32
        Get
            Return Me._Id_Motivo_Muerte
        End Get
        Set(ByVal Value As Int32)
            If _Id_Motivo_Muerte <> Value Then
                RaiseEvent Id_Motivo_MuerteChanging(Value)
				Me._Id_Motivo_Muerte = Value
                RaiseEvent Id_Motivo_MuerteChanged()
            End If
        End Set
    End Property

    Public Event Id_EnfermedadChanging(ByVal Value As Int32)
    Public Event Id_EnfermedadChanged()
	
    Public Property Id_Enfermedad() As Int32
        Get
            Return Me._Id_Enfermedad
        End Get
        Set(ByVal Value As Int32)
            If _Id_Enfermedad <> Value Then
                RaiseEvent Id_EnfermedadChanging(Value)
				Me._Id_Enfermedad = Value
                RaiseEvent Id_EnfermedadChanged()
            End If
        End Set
    End Property

    Public Event Id_ParentescoChanging(ByVal Value As Int32)
    Public Event Id_ParentescoChanged()
	
    Public Property Id_Parentesco() As Int32
        Get
            Return Me._Id_Parentesco
        End Get
        Set(ByVal Value As Int32)
            If _Id_Parentesco <> Value Then
                RaiseEvent Id_ParentescoChanging(Value)
				Me._Id_Parentesco = Value
                RaiseEvent Id_ParentescoChanged()
            End If
        End Set
    End Property

    Public Event Id_Velar_EnterrarChanging(ByVal Value As Int32)
    Public Event Id_Velar_EnterrarChanged()
	
    Public Property Id_Velar_Enterrar() As Int32
        Get
            Return Me._Id_Velar_Enterrar
        End Get
        Set(ByVal Value As Int32)
            If _Id_Velar_Enterrar <> Value Then
                RaiseEvent Id_Velar_EnterrarChanging(Value)
				Me._Id_Velar_Enterrar = Value
                RaiseEvent Id_Velar_EnterrarChanged()
            End If
        End Set
    End Property

    Public Readonly Property Declaracion() As DeclaracionBrl
        Get
            Return DeclaracionBrl.CargarPorID(Id_Declaracion)
        End Get
    End Property

    Public Readonly Property Enfermedad() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Enfermedad)
        End Get
    End Property

    Public Readonly Property Motivo_Muerte() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Motivo_Muerte)
        End Get
    End Property

    Public Readonly Property Parentesco() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Parentesco)
        End Get
    End Property

    Public Readonly Property Velar_Enterrar() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Velar_Enterrar)
        End Get
    End Property

    Public ReadOnly Property Es_Menor() As String
        Get
            If Mayor_Menor = 1 Then Return "X" Else Return ""
        End Get
    End Property

    Public ReadOnly Property Es_Mayor() As String
        Get
            If Mayor_Menor = 2 Then Return "X" Else Return ""
        End Get
    End Property

    Public ReadOnly Property NombreEnfermedad() As String
        Get
            If Enfermedad Is Nothing Then Return ""
            Return Enfermedad.Descripcion
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
			Me.ID = Declaracion_MuertosDAL.Insertar(Id_Declaracion, Tipo, Mayor_Menor, Id_Motivo_Muerte, Id_Enfermedad, Id_Parentesco, Id_Velar_Enterrar)
            RaiseEvent Inserted()			
		Else
            RaiseEvent Updating()		
			Declaracion_MuertosDAL.Actualizar(ID, Id_Declaracion, Tipo, Mayor_Menor, Id_Motivo_Muerte, Id_Enfermedad, Id_Parentesco, Id_Velar_Enterrar)
            RaiseEvent Updated()			
		End If   


        RaiseEvent Saved()
        
	End Sub
	
	Public Sub Eliminar()
		Dim totalHijos As Long = 0
		If Me.ID <> Nothing Then 
			
            RaiseEvent Deleting()
            
            
            
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            
			Declaracion_MuertosDAL.Eliminar(Me.ID)
			
            RaiseEvent Deleted()
            
        End If
	End Sub
	

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Declaracion_MuertosBrl
		
		Dim objDeclaracion_Muertos As New Declaracion_MuertosBrl
		
		With objDeclaracion_Muertos
			.ID = fila("Id")
			.Id_Declaracion = isDBNullToNothing(fila("Id_Declaracion"))
			.Tipo = isDBNullToNothing(fila("Tipo"))
			.Mayor_Menor = isDBNullToNothing(fila("Mayor_Menor"))
			.Id_Motivo_Muerte = isDBNullToNothing(fila("Id_Motivo_Muerte"))
			.Id_Enfermedad = isDBNullToNothing(fila("Id_Enfermedad"))
			.Id_Parentesco = isDBNullToNothing(fila("Id_Parentesco"))
			.Id_Velar_Enterrar = isDBNullToNothing(fila("Id_Velar_Enterrar"))

		End With
		
		Return objDeclaracion_Muertos
		
    End Function
	
	Public Shared Event LoadingDeclaracion_MuertosList(ByVal LoadType As String)
	Public Shared Event LoadedDeclaracion_MuertosList(target As List(Of Declaracion_MuertosBrl), ByVal LoadType As String)
	
	Public Shared Function CargarTodos() As List(Of Declaracion_MuertosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_MuertosBrl)
	
		RaiseEvent LoadingDeclaracion_MuertosList("CargarTodos")
	
		dsDatos = Declaracion_MuertosDAL.CargarTodos()

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_MuertosList(lista, "CargarTodos")
        
        Return lista
        
    End Function

	Public Shared Event CargandoPorId(ByVal id As Int32)
    Public Shared Event CargadoPorId(ByVal target As Declaracion_MuertosBrl)

	Public Shared Function CargarPorID(ID As Int32) As Declaracion_MuertosBrl

		Dim dsDatos As System.Data.DataSet
		Dim objDeclaracion_Muertos As Declaracion_MuertosBrl = Nothing 
		
		'RaiseEvent CargandoPorId(ID)
			
		dsDatos = Declaracion_MuertosDAL.CargarPorID(ID)
		
		If dsDatos.Tables(0).Rows.Count <> 0 Then objDeclaracion_Muertos = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
		
		'RaiseEvent CargadoPorId(objJoven)

        Return objDeclaracion_Muertos
        
    End Function
	Public Shared Function CargarPorId_Declaracion(ByVal Id_Declaracion As Int32) As List(Of Declaracion_MuertosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_MuertosBrl)
	
		RaiseEvent LoadingDeclaracion_MuertosList("CargarPorId_Declaracion")
		
		dsDatos = Declaracion_MuertosDAL.CargarPorId_Declaracion(Id_Declaracion)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_MuertosList(lista, "CargarPorId_Declaracion")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Enfermedad(ByVal Id_Enfermedad As Int32) As List(Of Declaracion_MuertosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_MuertosBrl)
	
		RaiseEvent LoadingDeclaracion_MuertosList("CargarPorId_Enfermedad")
		
		dsDatos = Declaracion_MuertosDAL.CargarPorId_Enfermedad(Id_Enfermedad)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_MuertosList(lista, "CargarPorId_Enfermedad")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Motivo_Muerte(ByVal Id_Motivo_Muerte As Int32) As List(Of Declaracion_MuertosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_MuertosBrl)
	
		RaiseEvent LoadingDeclaracion_MuertosList("CargarPorId_Motivo_Muerte")
		
		dsDatos = Declaracion_MuertosDAL.CargarPorId_Motivo_Muerte(Id_Motivo_Muerte)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_MuertosList(lista, "CargarPorId_Motivo_Muerte")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Parentesco(ByVal Id_Parentesco As Int32) As List(Of Declaracion_MuertosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_MuertosBrl)
	
		RaiseEvent LoadingDeclaracion_MuertosList("CargarPorId_Parentesco")
		
		dsDatos = Declaracion_MuertosDAL.CargarPorId_Parentesco(Id_Parentesco)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_MuertosList(lista, "CargarPorId_Parentesco")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Velar_Enterrar(ByVal Id_Velar_Enterrar As Int32) As List(Of Declaracion_MuertosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_MuertosBrl)
	
		RaiseEvent LoadingDeclaracion_MuertosList("CargarPorId_Velar_Enterrar")
		
		dsDatos = Declaracion_MuertosDAL.CargarPorId_Velar_Enterrar(Id_Velar_Enterrar)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_MuertosList(lista, "CargarPorId_Velar_Enterrar")
        
        Return lista
        
	End Function



End Class


