Imports ingNovar.Utilidades2
imports system.data
Imports system.collections.generic


Partial Public Class TrimestralBrl

    Private _Id As Int32
    Private _Descripcion As String
    Private _Fecha_Inicial As DateTime
    Private _Fecha_Final As DateTime
    Private objListTrimestral_Grupos As List(Of Trimestral_GruposBrl)


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

    Public Event DescripcionChanging(ByVal Value As String)
    Public Event DescripcionChanged()
	
    Public Property Descripcion() As String
        Get
            Return Me._Descripcion
        End Get
        Set(ByVal Value As String)
            If _Descripcion <> Value Then
                RaiseEvent DescripcionChanging(Value)
				Me._Descripcion = Value
                RaiseEvent DescripcionChanged()
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

    Public Property Trimestral_Grupos() As List(Of Trimestral_GruposBrl)
        Get
            If (Me.objListTrimestral_Grupos Is Nothing) Then
                objListTrimestral_Grupos = Trimestral_GruposBrl.CargarPorId_Trimestral(Me.ID)
            End If
            Return Me.objListTrimestral_Grupos
        End Get
        Set(ByVal Value As List(Of Trimestral_GruposBrl))
            Me.objListTrimestral_Grupos = Value
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
            Me.ID = TrimestralDAL.Insertar(Descripcion, Fecha_Inicial, Fecha_Final)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            TrimestralDAL.Actualizar(ID, Descripcion, Fecha_Inicial, Fecha_Final)
            RaiseEvent Updated()
        End If
        If Not objListTrimestral_Grupos Is Nothing Then
            For Each fila As Trimestral_GruposBrl In objListTrimestral_Grupos
                fila.Id_Trimestral = Me.ID
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
            totalHijos += Trimestral_Grupos.Count
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            TrimestralDAL.Eliminar(Me.ID)
            RaiseEvent Deleted()
            
        End If
	End Sub
	
    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As TrimestralBrl
        Dim objTrimestral As New TrimestralBrl
        With objTrimestral
            .ID = fila("Id")
            .Descripcion = isDBNullToNothing(fila("Descripcion"))
            .Fecha_Inicial = isDBNullToNothing(fila("Fecha_Inicial"))
            .Fecha_Final = isDBNullToNothing(fila("Fecha_Final"))
        End With
        Return objTrimestral

    End Function
	
	Public Shared Event LoadingTrimestralList(ByVal LoadType As String)
	Public Shared Event LoadedTrimestralList(target As List(Of TrimestralBrl), ByVal LoadType As String)
	
	Public Shared Function CargarTodos() As List(Of TrimestralBrl)
        Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of TrimestralBrl)
        RaiseEvent LoadingTrimestralList("CargarTodos")
        dsDatos = TrimestralDAL.CargarTodos()
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedTrimestralList(lista, "CargarTodos")
        
        Return lista
        
    End Function

	Public Shared Event CargandoPorId(ByVal id As Int32)
    Public Shared Event CargadoPorId(ByVal target As TrimestralBrl)

	Public Shared Function CargarPorID(ID As Int32) As TrimestralBrl

		Dim dsDatos As System.Data.DataSet
		Dim objTrimestral As TrimestralBrl = Nothing 
        RaiseEvent CargandoPorId(ID)
        dsDatos = TrimestralDAL.CargarPorID(ID)
		
		If dsDatos.Tables(0).Rows.Count <> 0 Then objTrimestral = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objTrimestral
        
    End Function

End Class


