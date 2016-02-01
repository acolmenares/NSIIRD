Imports ingNovar.Utilidades2
Imports System.Data
Imports System.Collections.Generic

Partial Public Class IMCBrl

    Private _Id As Int32
    Private _Semana As Int32
    Private _Estado As String
    Private _Imc_Inicial As Double
    Private _Imc_Final As Double


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

    Public Event SemanaChanging(ByVal Value As Int32)
    Public Event SemanaChanged()
	
    Public Property Semana() As Int32
        Get
            Return Me._Semana
        End Get
        Set(ByVal Value As Int32)
            If _Semana <> Value Then
                RaiseEvent SemanaChanging(Value)
                Me._Semana = Value
                RaiseEvent SemanaChanged()
            End If
        End Set
    End Property

    Public Event EstadoChanging(ByVal Value As String)
    Public Event EstadoChanged()

    Public Property Estado() As String
        Get
            Return Me._Estado
        End Get
        Set(ByVal Value As String)
            If _Estado <> Value Then
                RaiseEvent EstadoChanging(Value)
				Me._Estado = Value
                RaiseEvent EstadoChanged()
            End If
        End Set
    End Property

    Public Event Imc_InicialChanging(ByVal Value As Double)
    Public Event Imc_InicialChanged()

    Public Property Imc_Inicial() As Double
        Get
            Return Me._Imc_Inicial
        End Get
        Set(ByVal Value As Double)
            If _Imc_Inicial <> Value Then
                RaiseEvent Imc_InicialChanging(Value)
				Me._Imc_Inicial = Value
                RaiseEvent Imc_InicialChanged()
            End If
        End Set
    End Property

    Public Event Imc_FinalChanging(ByVal Value As Double)
    Public Event Imc_FinalChanged()
	
    Public Property Imc_Final() As Double
        Get
            Return Me._Imc_Final
        End Get
        Set(ByVal Value As Double)
            If _Imc_Final <> Value Then
                RaiseEvent Imc_FinalChanging(Value)
                Me._Imc_Final = Value
                RaiseEvent Imc_FinalChanged()
            End If
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
			Me.ID = IMCDAL.Insertar(Semana, Estado, Imc_Inicial, Imc_Final)
            RaiseEvent Inserted()			
		Else
            RaiseEvent Updating()		
			IMCDAL.Actualizar(ID, Semana, Estado, Imc_Inicial, Imc_Final)
            RaiseEvent Updated()			
		End If   
        RaiseEvent Saved()
        
	End Sub
	
	Public Sub Eliminar()
		Dim totalHijos As Long = 0
		If Me.ID <> Nothing Then 
            RaiseEvent Deleting()
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            IMCDAL.Eliminar(Me.ID)
            RaiseEvent Deleted()
            
        End If
	End Sub
	
    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As IMCBrl

        Dim objIMC As New IMCBrl

        With objIMC
            .ID = fila("Id")
            .Semana = isDBNullToNothing(fila("Semana"))
            .Estado = isDBNullToNothing(fila("Estado"))
            .Imc_Inicial = isDBNullToNothing(fila("Imc_Inicial"))
            .Imc_Final = isDBNullToNothing(fila("Imc_Final"))
        End With

        Return objIMC

    End Function
	
	Public Shared Event LoadingIMCList(ByVal LoadType As String)
	Public Shared Event LoadedIMCList(target As List(Of IMCBrl), ByVal LoadType As String)
	
	Public Shared Function CargarTodos() As List(Of IMCBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of IMCBrl)
        RaiseEvent LoadingIMCList("CargarTodos")
        dsDatos = IMCDAL.CargarTodos()
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedIMCList(lista, "CargarTodos")
        
        Return lista
        
    End Function

	Public Shared Event LoadingPorId(ByVal id As Int32)
    Public Shared Event LoadedPorId(ByVal target As IMCBrl)

	Public Shared Function CargarPorID(ID As Int32) As IMCBrl
        Dim dsDatos As System.Data.DataSet
		Dim objIMC As IMCBrl = Nothing 
        dsDatos = IMCDAL.CargarPorID(ID)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objIMC = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objIMC
    End Function

    Public Shared Function CargarPorConsultaBase(ByVal Semana As Int32, ByVal IMC As Double) As IMCBrl
        Dim dsDatos As System.Data.DataSet
        Dim objIMC As IMCBrl = Nothing
        dsDatos = IMCDAL.CargarPorConsultaBase(Semana, IMC)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objIMC = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objIMC
    End Function

End Class


