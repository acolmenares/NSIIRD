Imports ingNovar.Utilidades2
imports system.data
Imports system.collections.generic


Partial Public Class Declaracion_PsicosocialBrl

    Private _Id As Int32
    Private _Id_Declaracion As Int32
    Private _Id_Emocion As Int32
    Private _Dato_Usted As Int32
    Private _Dato_Familia As Int32
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

    Public Event Id_EmocionChanging(ByVal Value As Int32)
    Public Event Id_EmocionChanged()
	
    Public Property Id_Emocion() As Int32
        Get
            Return Me._Id_Emocion
        End Get
        Set(ByVal Value As Int32)
            If _Id_Emocion <> Value Then
                RaiseEvent Id_EmocionChanging(Value)
                Me._Id_Emocion = Value
                RaiseEvent Id_EmocionChanged()
            End If
        End Set
    End Property

    Public Event Dato_UstedChanging(ByVal Value As Int32)
    Public Event Dato_UstedChanged()
	
    Public Property Dato_Usted() As Int32
        Get
            Return Me._Dato_Usted
        End Get
        Set(ByVal Value As Int32)
            If _Dato_Usted <> Value Then
                RaiseEvent Dato_UstedChanging(Value)
                Me._Dato_Usted = Value
                RaiseEvent Dato_UstedChanged()
            End If
        End Set
    End Property

    Public Event Dato_FamiliaChanging(ByVal Value As Int32)
    Public Event Dato_FamiliaChanged()

    Public Property Dato_Familia() As Int32
        Get
            Return Me._Dato_Familia
        End Get
        Set(ByVal Value As Int32)
            If _Dato_Familia <> Value Then
                RaiseEvent Dato_FamiliaChanging(Value)
                Me._Dato_Familia = Value
                RaiseEvent Dato_FamiliaChanged()
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

    Public ReadOnly Property Emocion() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Emocion)
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
            Me.ID = Declaracion_PsicosocialDAL.Insertar(Id_Declaracion, Id_Emocion, Dato_Usted, Dato_Familia, Id_Tipo_Entrega, Id_Declaracion_Seguimiento)
            RaiseEvent Inserted()			
		Else
            RaiseEvent Updating()		
            Declaracion_PsicosocialDAL.Actualizar(ID, Id_Declaracion, Id_Emocion, Dato_Usted, Dato_Familia, Id_Tipo_Entrega, Id_Declaracion_Seguimiento)
            RaiseEvent Updated()			
		End If   


        RaiseEvent Saved()
        
	End Sub
	
	Public Sub Eliminar()
		Dim totalHijos As Long = 0
		If Me.ID <> Nothing Then 
            RaiseEvent Deleting()
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            Declaracion_PsicosocialDAL.Eliminar(Me.ID)
            RaiseEvent Deleted()
        End If
	End Sub
	
    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Declaracion_PsicosocialBrl

        Dim objDeclaracion_Psicosocial As New Declaracion_PsicosocialBrl

        With objDeclaracion_Psicosocial
            .ID = fila("Id")
            .Id_Declaracion = isDBNullToNothing(fila("Id_Declaracion"))
            .Id_Emocion = isDBNullToNothing(fila("Id_Emocion"))
            .Dato_Usted = isDBNullToNothing(fila("Dato_Usted"))
            .Dato_Familia = isDBNullToNothing(fila("Dato_Familia"))
            .Id_Tipo_Entrega = isDBNullToNothing(fila("Id_Tipo_Entrega"))
            .Id_Declaracion_Seguimiento = isDBNullToNothing(fila("Id_Declaracion_Seguimiento"))
        End With

        Return objDeclaracion_Psicosocial

    End Function
	
	Public Shared Event LoadingDeclaracion_PsicosocialList(ByVal LoadType As String)
	Public Shared Event LoadedDeclaracion_PsicosocialList(target As List(Of Declaracion_PsicosocialBrl), ByVal LoadType As String)
	
	Public Shared Function CargarTodos() As List(Of Declaracion_PsicosocialBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_PsicosocialBrl)
	
		RaiseEvent LoadingDeclaracion_PsicosocialList("CargarTodos")
	
		dsDatos = Declaracion_PsicosocialDAL.CargarTodos()

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_PsicosocialList(lista, "CargarTodos")
        
        Return lista
        
    End Function

	Public Shared Event CargandoPorId(ByVal id As Int32)
    Public Shared Event CargadoPorId(ByVal target As Declaracion_PsicosocialBrl)

	Public Shared Function CargarPorID(ID As Int32) As Declaracion_PsicosocialBrl

        Dim dsDatos As System.Data.DataSet
		Dim objDeclaracion_Psicosocial As Declaracion_PsicosocialBrl = Nothing 
        dsDatos = Declaracion_PsicosocialDAL.CargarPorID(ID)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objDeclaracion_Psicosocial = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objDeclaracion_Psicosocial

    End Function

	Public Shared Function CargarPorId_Declaracion(ByVal Id_Declaracion As Int32) As List(Of Declaracion_PsicosocialBrl)

        Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_PsicosocialBrl)

        dsDatos = Declaracion_PsicosocialDAL.CargarPorId_Declaracion(Id_Declaracion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        Return lista

    End Function

    Public Shared Function CargarPorId_Emocion(ByVal Id_Emocion As Int32) As List(Of Declaracion_PsicosocialBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Declaracion_PsicosocialBrl)

        dsDatos = Declaracion_PsicosocialDAL.CargarPorId_Emocion(Id_Emocion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        Return lista

    End Function

    Public Shared Function CargarPorId_Tipo_Entrega(ByVal Id_Tipo_Entrega As Int32) As List(Of Declaracion_PsicosocialBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Declaracion_PsicosocialBrl)

        dsDatos = Declaracion_PsicosocialDAL.CargarPorId_Tipo_Entrega(Id_Tipo_Entrega)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        Return lista

    End Function

    Public Shared Function CargarPorId_Declaracion_Seguimiento(ByVal Id_Declaracion_Seguimiento As Int32) As List(Of Declaracion_PsicosocialBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Declaracion_PsicosocialBrl)

        dsDatos = Declaracion_PsicosocialDAL.CargarPorId_Declaracion_Seguimiento(Id_Declaracion_Seguimiento)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        Return lista

    End Function


End Class


