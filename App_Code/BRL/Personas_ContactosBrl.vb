Imports ingNovar.Utilidades2
Imports System.Data
Imports System.Collections.Generic
Imports SeguridadUsuarios

Partial Public Class Personas_ContactosBrl

    Private _Id As Int32
    Private _Id_Persona As Int32
    Private _Id_Tipo_Contacto As Int32
    Private _Descripcion As String
    Private _Activo As Boolean
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

    Public Event Id_PersonaChanging(ByVal Value As Int32)
    Public Event Id_PersonaChanged()
	
    Public Property Id_Persona() As Int32
        Get
            Return Me._Id_Persona
        End Get
        Set(ByVal Value As Int32)
            If _Id_Persona <> Value Then
                RaiseEvent Id_PersonaChanging(Value)
				Me._Id_Persona = Value
                RaiseEvent Id_PersonaChanged()
            End If
        End Set
    End Property

    Public Event Id_Tipo_ContactoChanging(ByVal Value As Int32)
    Public Event Id_Tipo_ContactoChanged()
	
    Public Property Id_Tipo_Contacto() As Int32
        Get
            Return Me._Id_Tipo_Contacto
        End Get
        Set(ByVal Value As Int32)
            If _Id_Tipo_Contacto <> Value Then
                RaiseEvent Id_Tipo_ContactoChanging(Value)
				Me._Id_Tipo_Contacto = Value
                RaiseEvent Id_Tipo_ContactoChanged()
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

    Public Event ActivoChanging(ByVal Value As Boolean)
    Public Event ActivoChanged()
	
    Public Property Activo() As Boolean
        Get
            Return Me._Activo
        End Get
        Set(ByVal Value As Boolean)
            If _Activo <> Value Then
                RaiseEvent ActivoChanging(Value)
				Me._Activo = Value
                RaiseEvent ActivoChanged()
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

    Public Readonly Property Personas() As PersonasBrl
        Get
            Return PersonasBrl.CargarPorID(Id_Persona)
        End Get
    End Property

    Public ReadOnly Property SubTablasTipoContacto() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Tipo_Contacto)
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
            Me.ID = Personas_ContactosDAL.Insertar(Id_Persona, Id_Tipo_Contacto, Descripcion, Activo, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Fecha_Cierre, Cierre)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            Personas_ContactosDAL.Actualizar(ID, Id_Persona, Id_Tipo_Contacto, Descripcion, Activo, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Fecha_Cierre, Cierre)
            RaiseEvent Updated()
        End If

        RaiseEvent Saved()
        
	End Sub
	
	Public Sub Eliminar()
		Dim totalHijos As Long = 0
		If Me.ID <> Nothing Then 
            RaiseEvent Deleting()
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            Personas_ContactosDAL.Eliminar(Me.ID)
            RaiseEvent Deleted()
            
        End If
	End Sub
	

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Personas_ContactosBrl
		
		Dim objPersonas_Contactos As New Personas_ContactosBrl
		
		With objPersonas_Contactos
			.ID = fila("Id")
			.Id_Persona = isDBNullToNothing(fila("Id_Persona"))
			.Id_Tipo_Contacto = isDBNullToNothing(fila("Id_Tipo_Contacto"))
			.Descripcion = isDBNullToNothing(fila("Descripcion"))
			.Activo = isDBNullToNothing(fila("Activo"))
            .Fecha_Creacion = isDBNullToNothing(fila("Fecha_Creacion"))
            .Id_Usuario_Creacion = isDBNullToNothing(fila("Id_Usuario_Creacion"))
            .Fecha_Modificacion = isDBNullToNothing(fila("Fecha_Modificacion"))
            .Id_Usuario_Modificacion = isDBNullToNothing(fila("Id_Usuario_Modificacion"))
            .Fecha_Cierre = isDBNullToNothing(fila("Fecha_Cierre"))
            .Cierre = isDBNullToNothing(fila("Cierre"))
		End With
		
		Return objPersonas_Contactos
		
    End Function
	
	Public Shared Event LoadingPersonas_ContactosList(ByVal LoadType As String)
	Public Shared Event LoadedPersonas_ContactosList(target As List(Of Personas_ContactosBrl), ByVal LoadType As String)
	
	Public Shared Function CargarTodos() As List(Of Personas_ContactosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Personas_ContactosBrl)
	
		RaiseEvent LoadingPersonas_ContactosList("CargarTodos")
	
		dsDatos = Personas_ContactosDAL.CargarTodos()

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedPersonas_ContactosList(lista, "CargarTodos")
        
        Return lista
        
    End Function

	Public Shared Event LoadingPorId(ByVal id As Int32)
    Public Shared Event LoadedPorId(ByVal target As Personas_ContactosBrl)

	Public Shared Function CargarPorID(ID As Int32) As Personas_ContactosBrl

		Dim dsDatos As System.Data.DataSet
		Dim objPersonas_Contactos As Personas_ContactosBrl = Nothing 
		
        dsDatos = Personas_ContactosDAL.CargarPorID(ID)
		
        If dsDatos.Tables(0).Rows.Count <> 0 Then objPersonas_Contactos = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))

        Return objPersonas_Contactos
        
    End Function

	Public Shared Function CargarPorId_Persona(ByVal Id_Persona As Int32) As List(Of Personas_ContactosBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Personas_ContactosBrl)
	
		RaiseEvent LoadingPersonas_ContactosList("CargarPorId_Persona")
		
		dsDatos = Personas_ContactosDAL.CargarPorId_Persona(Id_Persona)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedPersonas_ContactosList(lista, "CargarPorId_Persona")
        
        Return lista
        
	End Function

    Public Shared Function CargarPorId_Tipo_Contacto(ByVal Id_Tipo_Contacto As Int32) As List(Of Personas_ContactosBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_ContactosBrl)

        RaiseEvent LoadingPersonas_ContactosList("CargarPorId_Tipo_Contacto")

        dsDatos = Personas_ContactosDAL.CargarPorId_Tipo_Contacto(Id_Tipo_Contacto)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedPersonas_ContactosList(lista, "CargarPorId_Tipo_Contacto")

        Return lista

    End Function

    Public Shared Function CargarPorId_PersonayTipo_contacto(ByVal Id_Persona As Int32, ByVal Id_Tipo_Contacto As Int32) As List(Of Personas_ContactosBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_ContactosBrl)

        dsDatos = Personas_ContactosDAL.CargarPorId_PersonaYTipo_Contacto(Id_Persona, Id_Tipo_Contacto)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function



    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As Int32) As List(Of Personas_ContactosBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_ContactosBrl)

        RaiseEvent LoadingPersonas_ContactosList("CargarPorId_Usuario_Creacion")

        dsDatos = Personas_ContactosDAL.CargarPorId_Usuario_Creacion(Id_Usuario_Creacion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedPersonas_ContactosList(lista, "CargarPorId_Usuario_Creacion")

        Return lista

    End Function



    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As Int32) As List(Of Personas_ContactosBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_ContactosBrl)

        RaiseEvent LoadingPersonas_ContactosList("CargarPorId_Usuario_Modificacion")

        dsDatos = Personas_ContactosDAL.CargarPorId_Usuario_Modificacion(Id_Usuario_Modificacion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedPersonas_ContactosList(lista, "CargarPorId_Usuario_Modificacion")

        Return lista

    End Function

End Class


