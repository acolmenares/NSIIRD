Imports ingNovar.Utilidades2
imports system.data
Imports system.collections.generic


Partial Public Class Declaracion_DesaparecidosBrl

    Private _Id As Int32
    Private _Id_Declaracion As Int32
    Private _Id_Parentesco As Int32
    Private _Id_Reporto As Int32
    Private _Id_PorQueNo_Reporto As Int32
    Private _Id_Lugar_Denuncia As Int32


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

    Public Event Id_ReportoChanging(ByVal Value As Int32)
    Public Event Id_ReportoChanged()
	
    Public Property Id_Reporto() As Int32
        Get
            Return Me._Id_Reporto
        End Get
        Set(ByVal Value As Int32)
            If _Id_Reporto <> Value Then
                RaiseEvent Id_ReportoChanging(Value)
				Me._Id_Reporto = Value
                RaiseEvent Id_ReportoChanged()
            End If
        End Set
    End Property

    Public Event Id_PorQueNo_ReportoChanging(ByVal Value As Int32)
    Public Event Id_PorQueNo_ReportoChanged()
	
    Public Property Id_PorQueNo_Reporto() As Int32
        Get
            Return Me._Id_PorQueNo_Reporto
        End Get
        Set(ByVal Value As Int32)
            If _Id_PorQueNo_Reporto <> Value Then
                RaiseEvent Id_PorQueNo_ReportoChanging(Value)
				Me._Id_PorQueNo_Reporto = Value
                RaiseEvent Id_PorQueNo_ReportoChanged()
            End If
        End Set
    End Property

    Public Event Id_Lugar_DenunciaChanging(ByVal Value As Int32)
    Public Event Id_Lugar_DenunciaChanged()
	
    Public Property Id_Lugar_Denuncia() As Int32
        Get
            Return Me._Id_Lugar_Denuncia
        End Get
        Set(ByVal Value As Int32)
            If _Id_Lugar_Denuncia <> Value Then
                RaiseEvent Id_Lugar_DenunciaChanging(Value)
				Me._Id_Lugar_Denuncia = Value
                RaiseEvent Id_Lugar_DenunciaChanged()
            End If
        End Set
    End Property

    Public Readonly Property Declaracion() As DeclaracionBrl
        Get
            Return DeclaracionBrl.CargarPorID(Id_Declaracion)
        End Get
    End Property

    Public Readonly Property Lugar_Denuncia() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Lugar_Denuncia)
        End Get
    End Property

    Public Readonly Property Parentesco() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Parentesco)
        End Get
    End Property

    Public Readonly Property PorQueNo_Reporto() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_PorQueNo_Reporto)
        End Get
    End Property

    Public Readonly Property Reporto() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Reporto)
        End Get
    End Property

    Public ReadOnly Property MotivoNoReporto() As String
        Get
            If PorQueNo_Reporto Is Nothing Then Return "" Else Return PorQueNo_Reporto.Descripcion
        End Get
    End Property

    Public ReadOnly Property Denuncia() As String
        Get
            If Lugar_Denuncia Is Nothing Then Return "" Else Return Lugar_Denuncia.Descripcion
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
			Me.ID = Declaracion_DesaparecidosDAL.Insertar(Id_Declaracion, Id_Parentesco, Id_Reporto, Id_PorQueNo_Reporto, Id_Lugar_Denuncia)
            RaiseEvent Inserted()			
		Else
            RaiseEvent Updating()		
			Declaracion_DesaparecidosDAL.Actualizar(ID, Id_Declaracion, Id_Parentesco, Id_Reporto, Id_PorQueNo_Reporto, Id_Lugar_Denuncia)
            RaiseEvent Updated()			
		End If   


        RaiseEvent Saved()
        
	End Sub
	
	Public Sub Eliminar()
		Dim totalHijos As Long = 0
		If Me.ID <> Nothing Then 
			
            RaiseEvent Deleting()
            
            
            
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            
			Declaracion_DesaparecidosDAL.Eliminar(Me.ID)
			
            RaiseEvent Deleted()
            
        End If
	End Sub
	

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Declaracion_DesaparecidosBrl
		
		Dim objDeclaracion_Desaparecidos As New Declaracion_DesaparecidosBrl
		
		With objDeclaracion_Desaparecidos
			.ID = fila("Id")
			.Id_Declaracion = isDBNullToNothing(fila("Id_Declaracion"))
			.Id_Parentesco = isDBNullToNothing(fila("Id_Parentesco"))
			.Id_Reporto = isDBNullToNothing(fila("Id_Reporto"))
			.Id_PorQueNo_Reporto = isDBNullToNothing(fila("Id_PorQueNo_Reporto"))
			.Id_Lugar_Denuncia = isDBNullToNothing(fila("Id_Lugar_Denuncia"))

		End With
		
		Return objDeclaracion_Desaparecidos
		
    End Function
	
	Public Shared Event LoadingDeclaracion_DesaparecidosList(ByVal LoadType As String)
	Public Shared Event LoadedDeclaracion_DesaparecidosList(target As List(Of Declaracion_DesaparecidosBrl), ByVal LoadType As String)
	
	Public Shared Function CargarTodos() As List(Of Declaracion_DesaparecidosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_DesaparecidosBrl)
	
		RaiseEvent LoadingDeclaracion_DesaparecidosList("CargarTodos")
	
		dsDatos = Declaracion_DesaparecidosDAL.CargarTodos()

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_DesaparecidosList(lista, "CargarTodos")
        
        Return lista
        
    End Function

	Public Shared Event CargandoPorId(ByVal id As Int32)
    Public Shared Event CargadoPorId(ByVal target As Declaracion_DesaparecidosBrl)

	Public Shared Function CargarPorID(ID As Int32) As Declaracion_DesaparecidosBrl

		Dim dsDatos As System.Data.DataSet
		Dim objDeclaracion_Desaparecidos As Declaracion_DesaparecidosBrl = Nothing 
		
		'RaiseEvent CargandoPorId(ID)
			
		dsDatos = Declaracion_DesaparecidosDAL.CargarPorID(ID)
		
		If dsDatos.Tables(0).Rows.Count <> 0 Then objDeclaracion_Desaparecidos = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
		
		'RaiseEvent CargadoPorId(objJoven)

        Return objDeclaracion_Desaparecidos
        
    End Function
	Public Shared Function CargarPorId_Declaracion(ByVal Id_Declaracion As Int32) As List(Of Declaracion_DesaparecidosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_DesaparecidosBrl)
	
		RaiseEvent LoadingDeclaracion_DesaparecidosList("CargarPorId_Declaracion")
		
		dsDatos = Declaracion_DesaparecidosDAL.CargarPorId_Declaracion(Id_Declaracion)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_DesaparecidosList(lista, "CargarPorId_Declaracion")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Lugar_Denuncia(ByVal Id_Lugar_Denuncia As Int32) As List(Of Declaracion_DesaparecidosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_DesaparecidosBrl)
	
		RaiseEvent LoadingDeclaracion_DesaparecidosList("CargarPorId_Lugar_Denuncia")
		
		dsDatos = Declaracion_DesaparecidosDAL.CargarPorId_Lugar_Denuncia(Id_Lugar_Denuncia)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_DesaparecidosList(lista, "CargarPorId_Lugar_Denuncia")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Parentesco(ByVal Id_Parentesco As Int32) As List(Of Declaracion_DesaparecidosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_DesaparecidosBrl)
	
		RaiseEvent LoadingDeclaracion_DesaparecidosList("CargarPorId_Parentesco")
		
		dsDatos = Declaracion_DesaparecidosDAL.CargarPorId_Parentesco(Id_Parentesco)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_DesaparecidosList(lista, "CargarPorId_Parentesco")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_PorQueNo_Reporto(ByVal Id_PorQueNo_Reporto As Int32) As List(Of Declaracion_DesaparecidosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_DesaparecidosBrl)
	
		RaiseEvent LoadingDeclaracion_DesaparecidosList("CargarPorId_PorQueNo_Reporto")
		
		dsDatos = Declaracion_DesaparecidosDAL.CargarPorId_PorQueNo_Reporto(Id_PorQueNo_Reporto)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_DesaparecidosList(lista, "CargarPorId_PorQueNo_Reporto")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Reporto(ByVal Id_Reporto As Int32) As List(Of Declaracion_DesaparecidosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_DesaparecidosBrl)
	
		RaiseEvent LoadingDeclaracion_DesaparecidosList("CargarPorId_Reporto")
		
		dsDatos = Declaracion_DesaparecidosDAL.CargarPorId_Reporto(Id_Reporto)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_DesaparecidosList(lista, "CargarPorId_Reporto")
        
        Return lista
        
	End Function



End Class


