Imports ingNovar.Utilidades2
Imports System.Data
Imports System.Collections.Generic
Imports SeguridadUsuarios

Partial Public Class Entregas_Adicionales_PersonasBrl

    Private _Id As Int32
    Private _Id_Persona As Int32
    Private _Fecha_Creacion As DateTime
    Private _Id_Usuario_Creacion As Int32
    Private _Fecha_Modificacion As DateTime
    Private _Id_Usuario_Modificacion As Int32
    Private _Fecha_Cierre As DateTime
    Private _Cierre As Boolean
    Private _Id_Entrega_Adicional As Int32
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

    Public Event Id_Entrega_AdicionalChanging(ByVal Value As Int32)
    Public Event Id_Entrega_AdicionalChanged()

    Public Property Id_Entrega_Adicional() As Int32
        Get
            Return Me._Id_Entrega_Adicional
        End Get
        Set(ByVal Value As Int32)
            If _Id_Entrega_Adicional <> Value Then
                RaiseEvent Id_Entrega_AdicionalChanging(Value)
                Me._Id_Entrega_Adicional = Value
                RaiseEvent Id_Entrega_AdicionalChanged()
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

    Public ReadOnly Property Declaracion_Seguimiento() As Declaracion_SeguimientosBrl
        Get
            Return Declaracion_SeguimientosBrl.CargarPorID(Id_Declaracion_Seguimiento)
        End Get
    End Property

    Public ReadOnly Property Entregas_Adicionales() As Entregas_AdicionalesBrl
        Get
            Return Entregas_AdicionalesBrl.CargarPorID(Id_Entrega_Adicional)
        End Get
    End Property

    Public ReadOnly Property Personas() As PersonasBrl
        Get
            Return PersonasBrl.CargarPorID(Id_Persona)
        End Get
    End Property

    Public Readonly Property UsuariosCreacion() As UsuariosBrl
        Get
            Return UsuariosBrl.CargarPorID(Id_Usuario_Creacion)
        End Get
    End Property

    Public Readonly Property UsuariosModificacion() As UsuariosBrl
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
            Me.ID = Entregas_Adicionales_PersonasDAL.Insertar(Id_Persona, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Fecha_Cierre, Cierre, Id_Entrega_Adicional, Id_Declaracion_Seguimiento)
            RaiseEvent Inserted()			
		Else
            RaiseEvent Updating()		
            Entregas_Adicionales_PersonasDAL.Actualizar(ID, Id_Persona, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Fecha_Cierre, Cierre, Id_Entrega_Adicional, Id_Declaracion_Seguimiento)
            RaiseEvent Updated()			
		End If   
        RaiseEvent Saved()
        
	End Sub
	
	Public Sub Eliminar()
		Dim totalHijos As Long = 0
		If Me.ID <> Nothing Then 
			
            RaiseEvent Deleting()
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            Entregas_Adicionales_PersonasDAL.Eliminar(Me.ID)
            RaiseEvent Deleted()
            
        End If
	End Sub
	
    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Entregas_Adicionales_PersonasBrl

        Dim objEntregas_Adicionales_Personas As New Entregas_Adicionales_PersonasBrl

        With objEntregas_Adicionales_Personas
            .ID = fila("Id")
            .Id_Persona = isDBNullToNothing(fila("Id_Persona"))
            .Fecha_Creacion = isDBNullToNothing(fila("Fecha_Creacion"))
            .Id_Usuario_Creacion = isDBNullToNothing(fila("Id_Usuario_Creacion"))
            .Fecha_Modificacion = isDBNullToNothing(fila("Fecha_Modificacion"))
            .Id_Usuario_Modificacion = isDBNullToNothing(fila("Id_Usuario_Modificacion"))
            .Fecha_Cierre = isDBNullToNothing(fila("Fecha_Cierre"))
            .Cierre = isDBNullToNothing(fila("Cierre"))
            .Id_Entrega_Adicional = isDBNullToNothing(fila("Id_Entrega_Adicional"))
            .Id_Declaracion_Seguimiento = isDBNullToNothing(fila("Id_Declaracion_Seguimiento"))

        End With

        Return objEntregas_Adicionales_Personas

    End Function
	
	Public Shared Event LoadingEntregas_Adicionales_PersonasList(ByVal LoadType As String)
	Public Shared Event LoadedEntregas_Adicionales_PersonasList(target As List(Of Entregas_Adicionales_PersonasBrl), ByVal LoadType As String)
	
	Public Shared Function CargarTodos() As List(Of Entregas_Adicionales_PersonasBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Entregas_Adicionales_PersonasBrl)
	
		RaiseEvent LoadingEntregas_Adicionales_PersonasList("CargarTodos")
	
		dsDatos = Entregas_Adicionales_PersonasDAL.CargarTodos()

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedEntregas_Adicionales_PersonasList(lista, "CargarTodos")
        
        Return lista
        
    End Function

	Public Shared Event LoadingPorId(ByVal id As Int32)
    Public Shared Event LoadedPorId(ByVal target As Entregas_Adicionales_PersonasBrl)

	Public Shared Function CargarPorID(ID As Int32) As Entregas_Adicionales_PersonasBrl

        Dim dsDatos As System.Data.DataSet
		Dim objEntregas_Adicionales_Personas As Entregas_Adicionales_PersonasBrl = Nothing 

        dsDatos = Entregas_Adicionales_PersonasDAL.CargarPorID(ID)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objEntregas_Adicionales_Personas = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objEntregas_Adicionales_Personas
        
    End Function

    Public Shared Function CargarPorId_Entrega_Adicional(ByVal Id_Entrega_Adicional As Int32) As List(Of Entregas_Adicionales_PersonasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Entregas_Adicionales_PersonasBrl)

        dsDatos = Entregas_Adicionales_PersonasDAL.CargarPorId_Entrega_Adicional(Id_Entrega_Adicional)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        Return lista

    End Function

    Public Shared Function CargarPorId_Declaracion_Seguimiento(ByVal Id_Declaracion_Seguimiento As Int32) As List(Of Entregas_Adicionales_PersonasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Entregas_Adicionales_PersonasBrl)

        dsDatos = Entregas_Adicionales_PersonasDAL.CargarPorId_Declaracion_Seguimiento(Id_Declaracion_Seguimiento)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        Return lista

    End Function

    Public Shared Function CargarPorId_Persona(ByVal Id_Persona As Int32) As List(Of Entregas_Adicionales_PersonasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Entregas_Adicionales_PersonasBrl)

        RaiseEvent LoadingEntregas_Adicionales_PersonasList("CargarPorId_Persona")
        dsDatos = Entregas_Adicionales_PersonasDAL.CargarPorId_Persona(Id_Persona)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedEntregas_Adicionales_PersonasList(lista, "CargarPorId_Persona")
        Return lista

    End Function

    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As Int32) As List(Of Entregas_Adicionales_PersonasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Entregas_Adicionales_PersonasBrl)

        RaiseEvent LoadingEntregas_Adicionales_PersonasList("CargarPorId_Usuario_Creacion")
        dsDatos = Entregas_Adicionales_PersonasDAL.CargarPorId_Usuario_Creacion(Id_Usuario_Creacion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedEntregas_Adicionales_PersonasList(lista, "CargarPorId_Usuario_Creacion")
        Return lista

    End Function

	Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As Int32) As List(Of Entregas_Adicionales_PersonasBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Entregas_Adicionales_PersonasBrl)
	
		RaiseEvent LoadingEntregas_Adicionales_PersonasList("CargarPorId_Usuario_Modificacion")
        dsDatos = Entregas_Adicionales_PersonasDAL.CargarPorId_Usuario_Modificacion(Id_Usuario_Modificacion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedEntregas_Adicionales_PersonasList(lista, "CargarPorId_Usuario_Modificacion")
        Return lista
        
	End Function

End Class


