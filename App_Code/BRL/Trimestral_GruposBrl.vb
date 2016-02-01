Imports ingNovar.Utilidades2
imports system.data
Imports system.collections.generic


Partial Public Class Trimestral_GruposBrl

    Private _Id As Int32
    Private _Id_Trimestral As Int32
    Private _Id_Grupo As Int32


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

    Public Event Id_TrimestralChanging(ByVal Value As Int32)
    Public Event Id_TrimestralChanged()
	
    Public Property Id_Trimestral() As Int32
        Get
            Return Me._Id_Trimestral
        End Get
        Set(ByVal Value As Int32)
            If _Id_Trimestral <> Value Then
                RaiseEvent Id_TrimestralChanging(Value)
				Me._Id_Trimestral = Value
                RaiseEvent Id_TrimestralChanged()
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

    Public ReadOnly Property SubTablasGrupo() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Grupo)
        End Get
    End Property

    Public Readonly Property Trimestral() As TrimestralBrl
        Get
            Return TrimestralBrl.CargarPorID(Id_Trimestral)
        End Get
    End Property

    Public ReadOnly Property NombreGrupo() As String
        Get
            If SubTablasGrupo Is Nothing Then
                Return ""
            Else
                Return SubTablasGrupo.Descripcion
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
			Me.ID = Trimestral_GruposDAL.Insertar(Id_Trimestral, Id_Grupo)
            RaiseEvent Inserted()			
		Else
            RaiseEvent Updating()		
			Trimestral_GruposDAL.Actualizar(ID, Id_Trimestral, Id_Grupo)
            RaiseEvent Updated()			
		End If   


        RaiseEvent Saved()
        
	End Sub
	
	Public Sub Eliminar()
		Dim totalHijos As Long = 0
		If Me.ID <> Nothing Then 
			
            RaiseEvent Deleting()
            
            
            
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            
			Trimestral_GruposDAL.Eliminar(Me.ID)
			
            RaiseEvent Deleted()
            
        End If
	End Sub
	

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Trimestral_GruposBrl
		
		Dim objTrimestral_Grupos As New Trimestral_GruposBrl
		
		With objTrimestral_Grupos
			.ID = fila("Id")
			.Id_Trimestral = isDBNullToNothing(fila("Id_Trimestral"))
			.Id_Grupo = isDBNullToNothing(fila("Id_Grupo"))

		End With
		
		Return objTrimestral_Grupos
		
    End Function
	
	Public Shared Event LoadingTrimestral_GruposList(ByVal LoadType As String)
	Public Shared Event LoadedTrimestral_GruposList(target As List(Of Trimestral_GruposBrl), ByVal LoadType As String)
	
	Public Shared Function CargarTodos() As List(Of Trimestral_GruposBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Trimestral_GruposBrl)
	
		RaiseEvent LoadingTrimestral_GruposList("CargarTodos")
	
		dsDatos = Trimestral_GruposDAL.CargarTodos()

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedTrimestral_GruposList(lista, "CargarTodos")
        
        Return lista
        
    End Function

	Public Shared Event CargandoPorId(ByVal id As Int32)
    Public Shared Event CargadoPorId(ByVal target As Trimestral_GruposBrl)

	Public Shared Function CargarPorID(ID As Int32) As Trimestral_GruposBrl

		Dim dsDatos As System.Data.DataSet
		Dim objTrimestral_Grupos As Trimestral_GruposBrl = Nothing 
		
		RaiseEvent CargandoPorId(ID)
			
		dsDatos = Trimestral_GruposDAL.CargarPorID(ID)
		
		If dsDatos.Tables(0).Rows.Count <> 0 Then objTrimestral_Grupos = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
		
        Return objTrimestral_Grupos
        
    End Function

	Public Shared Function CargarPorId_Grupo(ByVal Id_Grupo As Int32) As List(Of Trimestral_GruposBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Trimestral_GruposBrl)
	
		RaiseEvent LoadingTrimestral_GruposList("CargarPorId_Grupo")
		
		dsDatos = Trimestral_GruposDAL.CargarPorId_Grupo(Id_Grupo)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedTrimestral_GruposList(lista, "CargarPorId_Grupo")
        
        Return lista
        
	End Function



	Public Shared Function CargarPorId_Trimestral(ByVal Id_Trimestral As Int32) As List(Of Trimestral_GruposBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Trimestral_GruposBrl)
	
		RaiseEvent LoadingTrimestral_GruposList("CargarPorId_Trimestral")
		
		dsDatos = Trimestral_GruposDAL.CargarPorId_Trimestral(Id_Trimestral)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedTrimestral_GruposList(lista, "CargarPorId_Trimestral")
        
        Return lista
        
	End Function



End Class


