Imports ingNovar.Utilidades2
Imports System.Data
Imports System.Collections.Generic
Imports SeguridadUsuarios

Partial Public Class SaludBrl

    Private _Id As Int32
    Private _Id_Persona As Int32
    Private _Id_Crecimiento_Desarrollo As Int32
    Private _Patologia As String
    Private _Id_Lactancia_Lactando As Int32
    Private _Lactancia_meses As Int32
    Private _Lactancia_Exclusiva As Int32
    Private _Id_Vitaminas_Desparasitacion As Int32
    Private _Id_Vitaminas_Suplementacion As Int32
    Private _Id_Vacunacion_Carnet As Int32
    Private _Id_Razon_No_Carnet As Int32
    Private _Id_Esquema_Vacunacion_Completo As Int32
    Private _Id_Razon_No_Vacunacion_Completo As Int32
    Private _Fecha_Esquema_Vacunacion As DateTime
    Private _Id_Ninos_Vacunados As Int32
    Private _Id_Motivo_No_Vacunados As Int32
    Private _Observaciones As String
    Private _Fecha_Creacion As DateTime
    Private _Id_Usuario_Creacion As Int32
    Private _Fecha_Modificacion As DateTime
    Private _Id_Usuario_Modificacion As Int32
    Private _Id_Motivo_No_CYD As Int32
    Private _Id_Crecimiento_Desarrollo_IRD As Int32
    Private _Id_Motivo_NO_CYD_IRD As Int32
    Private _Fecha_Cierre As DateTime
    Private _Cierre As Boolean

    Private objListSalud_Remisiones As List(Of Salud_RemisionesBrl)
    Private objListSalud_Valoracion As List(Of Salud_ValoracionBrl)


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

    Public Event Id_Crecimiento_DesarrolloChanging(ByVal Value As Int32)
    Public Event Id_Crecimiento_DesarrolloChanged()
	
    Public Property Id_Crecimiento_Desarrollo() As Int32
        Get
            Return Me._Id_Crecimiento_Desarrollo
        End Get
        Set(ByVal Value As Int32)
            If _Id_Crecimiento_Desarrollo <> Value Then
                RaiseEvent Id_Crecimiento_DesarrolloChanging(Value)
				Me._Id_Crecimiento_Desarrollo = Value
                RaiseEvent Id_Crecimiento_DesarrolloChanged()
            End If
        End Set
    End Property

    Public Event PatologiaChanging(ByVal Value As String)
    Public Event PatologiaChanged()
	
    Public Property Patologia() As String
        Get
            Return Me._Patologia
        End Get
        Set(ByVal Value As String)
            If _Patologia <> Value Then
                RaiseEvent PatologiaChanging(Value)
				Me._Patologia = Value
                RaiseEvent PatologiaChanged()
            End If
        End Set
    End Property

    Public Event Id_Lactancia_LactandoChanging(ByVal Value As Int32)
    Public Event Id_Lactancia_LactandoChanged()
	
    Public Property Id_Lactancia_Lactando() As Int32
        Get
            Return Me._Id_Lactancia_Lactando
        End Get
        Set(ByVal Value As Int32)
            If _Id_Lactancia_Lactando <> Value Then
                RaiseEvent Id_Lactancia_LactandoChanging(Value)
				Me._Id_Lactancia_Lactando = Value
                RaiseEvent Id_Lactancia_LactandoChanged()
            End If
        End Set
    End Property

    Public Event Lactancia_mesesChanging(ByVal Value As Int32)
    Public Event Lactancia_mesesChanged()
	
    Public Property Lactancia_meses() As Int32
        Get
            Return Me._Lactancia_meses
        End Get
        Set(ByVal Value As Int32)
            If _Lactancia_meses <> Value Then
                RaiseEvent Lactancia_mesesChanging(Value)
				Me._Lactancia_meses = Value
                RaiseEvent Lactancia_mesesChanged()
            End If
        End Set
    End Property

    Public Event Lactancia_ExclusivaChanging(ByVal Value As Int32)
    Public Event Lactancia_ExclusivaChanged()
	
    Public Property Lactancia_Exclusiva() As Int32
        Get
            Return Me._Lactancia_Exclusiva
        End Get
        Set(ByVal Value As Int32)
            If _Lactancia_Exclusiva <> Value Then
                RaiseEvent Lactancia_ExclusivaChanging(Value)
                Me._Lactancia_Exclusiva = Value
                RaiseEvent Lactancia_ExclusivaChanged()
            End If
        End Set
    End Property

    Public Event Id_Vitaminas_DesparasitacionChanging(ByVal Value As Int32)
    Public Event Id_Vitaminas_DesparasitacionChanged()
	
    Public Property Id_Vitaminas_Desparasitacion() As Int32
        Get
            Return Me._Id_Vitaminas_Desparasitacion
        End Get
        Set(ByVal Value As Int32)
            If _Id_Vitaminas_Desparasitacion <> Value Then
                RaiseEvent Id_Vitaminas_DesparasitacionChanging(Value)
				Me._Id_Vitaminas_Desparasitacion = Value
                RaiseEvent Id_Vitaminas_DesparasitacionChanged()
            End If
        End Set
    End Property

    Public Event Id_Vitaminas_SuplementacionChanging(ByVal Value As Int32)
    Public Event Id_Vitaminas_SuplementacionChanged()
	
    Public Property Id_Vitaminas_Suplementacion() As Int32
        Get
            Return Me._Id_Vitaminas_Suplementacion
        End Get
        Set(ByVal Value As Int32)
            If _Id_Vitaminas_Suplementacion <> Value Then
                RaiseEvent Id_Vitaminas_SuplementacionChanging(Value)
				Me._Id_Vitaminas_Suplementacion = Value
                RaiseEvent Id_Vitaminas_SuplementacionChanged()
            End If
        End Set
    End Property

    Public Event Id_Vacunacion_CarnetChanging(ByVal Value As Int32)
    Public Event Id_Vacunacion_CarnetChanged()
	
    Public Property Id_Vacunacion_Carnet() As Int32
        Get
            Return Me._Id_Vacunacion_Carnet
        End Get
        Set(ByVal Value As Int32)
            If _Id_Vacunacion_Carnet <> Value Then
                RaiseEvent Id_Vacunacion_CarnetChanging(Value)
				Me._Id_Vacunacion_Carnet = Value
                RaiseEvent Id_Vacunacion_CarnetChanged()
            End If
        End Set
    End Property

    Public Event Id_Razon_No_CarnetChanging(ByVal Value As Int32)
    Public Event Id_Razon_No_CarnetChanged()
	
    Public Property Id_Razon_No_Carnet() As Int32
        Get
            Return Me._Id_Razon_No_Carnet
        End Get
        Set(ByVal Value As Int32)
            If _Id_Razon_No_Carnet <> Value Then
                RaiseEvent Id_Razon_No_CarnetChanging(Value)
				Me._Id_Razon_No_Carnet = Value
                RaiseEvent Id_Razon_No_CarnetChanged()
            End If
        End Set
    End Property

    Public Event Id_Esquema_Vacunacion_CompletoChanging(ByVal Value As Int32)
    Public Event Id_Esquema_Vacunacion_CompletoChanged()
	
    Public Property Id_Esquema_Vacunacion_Completo() As Int32
        Get
            Return Me._Id_Esquema_Vacunacion_Completo
        End Get
        Set(ByVal Value As Int32)
            If _Id_Esquema_Vacunacion_Completo <> Value Then
                RaiseEvent Id_Esquema_Vacunacion_CompletoChanging(Value)
				Me._Id_Esquema_Vacunacion_Completo = Value
                RaiseEvent Id_Esquema_Vacunacion_CompletoChanged()
            End If
        End Set
    End Property

    Public Event Id_Razon_No_Vacunacion_CompletoChanging(ByVal Value As Int32)
    Public Event Id_Razon_No_Vacunacion_CompletoChanged()
	
    Public Property Id_Razon_No_Vacunacion_Completo() As Int32
        Get
            Return Me._Id_Razon_No_Vacunacion_Completo
        End Get
        Set(ByVal Value As Int32)
            If _Id_Razon_No_Vacunacion_Completo <> Value Then
                RaiseEvent Id_Razon_No_Vacunacion_CompletoChanging(Value)
				Me._Id_Razon_No_Vacunacion_Completo = Value
                RaiseEvent Id_Razon_No_Vacunacion_CompletoChanged()
            End If
        End Set
    End Property

    Public Event Fecha_Esquema_VacunacionChanging(ByVal Value As DateTime)
    Public Event Fecha_Esquema_VacunacionChanged()
	
    Public Property Fecha_Esquema_Vacunacion() As DateTime
        Get
            Return Me._Fecha_Esquema_Vacunacion
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_Esquema_Vacunacion <> Value Then
                RaiseEvent Fecha_Esquema_VacunacionChanging(Value)
				Me._Fecha_Esquema_Vacunacion = Value
                RaiseEvent Fecha_Esquema_VacunacionChanged()
            End If
        End Set
    End Property

    Public Event Id_Ninos_VacunadosChanging(ByVal Value As Int32)
    Public Event Id_Ninos_VacunadosChanged()
	
    Public Property Id_Ninos_Vacunados() As Int32
        Get
            Return Me._Id_Ninos_Vacunados
        End Get
        Set(ByVal Value As Int32)
            If _Id_Ninos_Vacunados <> Value Then
                RaiseEvent Id_Ninos_VacunadosChanging(Value)
				Me._Id_Ninos_Vacunados = Value
                RaiseEvent Id_Ninos_VacunadosChanged()
            End If
        End Set
    End Property

    Public Event Id_Motivo_No_VacunadosChanging(ByVal Value As Int32)
    Public Event Id_Motivo_No_VacunadosChanged()
	
    Public Property Id_Motivo_No_Vacunados() As Int32
        Get
            Return Me._Id_Motivo_No_Vacunados
        End Get
        Set(ByVal Value As Int32)
            If _Id_Motivo_No_Vacunados <> Value Then
                RaiseEvent Id_Motivo_No_VacunadosChanging(Value)
				Me._Id_Motivo_No_Vacunados = Value
                RaiseEvent Id_Motivo_No_VacunadosChanged()
            End If
        End Set
    End Property

    Public Event ObservacionesChanging(ByVal Value As String)
    Public Event ObservacionesChanged()
	
    Public Property Observaciones() As String
        Get
            Return Me._Observaciones
        End Get
        Set(ByVal Value As String)
            If _Observaciones <> Value Then
                RaiseEvent ObservacionesChanging(Value)
				Me._Observaciones = Value
                RaiseEvent ObservacionesChanged()
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

    Public Event Id_Motivo_No_CYDChanging(ByVal Value As Int32)
    Public Event Id_Motivo_No_CYDChanged()

    Public Property Id_Motivo_No_CYD() As Int32
        Get
            Return Me._Id_Motivo_No_CYD
        End Get
        Set(ByVal Value As Int32)
            If _Id_Motivo_No_CYD <> Value Then
                RaiseEvent Id_Motivo_No_CYDChanging(Value)
                Me._Id_Motivo_No_CYD = Value
                RaiseEvent Id_Motivo_No_CYDChanged()
            End If
        End Set
    End Property

    Public Event Id_Crecimiento_Desarrollo_IRDChanging(ByVal Value As Int32)
    Public Event Id_Crecimiento_Desarrollo_IRDChanged()

    Public Property Id_Crecimiento_Desarrollo_IRD() As Int32
        Get
            Return Me._Id_Crecimiento_Desarrollo_IRD
        End Get
        Set(ByVal Value As Int32)
            If _Id_Crecimiento_Desarrollo_IRD <> Value Then
                RaiseEvent Id_Crecimiento_Desarrollo_IRDChanging(Value)
                Me._Id_Crecimiento_Desarrollo_IRD = Value
                RaiseEvent Id_Crecimiento_Desarrollo_IRDChanged()
            End If
        End Set
    End Property

    Public Event Id_Motivo_NO_CYD_IRDChanging(ByVal Value As Int32)
    Public Event Id_Motivo_NO_CYD_IRDChanged()

    Public Property Id_Motivo_NO_CYD_IRD() As Int32
        Get
            Return Me._Id_Motivo_NO_CYD_IRD
        End Get
        Set(ByVal Value As Int32)
            If _Id_Motivo_NO_CYD_IRD <> Value Then
                RaiseEvent Id_Motivo_NO_CYD_IRDChanging(Value)
                Me._Id_Motivo_NO_CYD_IRD = Value
                RaiseEvent Id_Motivo_NO_CYD_IRDChanged()
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

    Public Property Salud_Remisiones() As List(Of Salud_RemisionesBrl)
        Get
            If (Me.objListSalud_Remisiones Is Nothing) Then
                objListSalud_Remisiones = Salud_RemisionesBrl.CargarPorId_Salud(Me.ID)
            End If
            Return Me.objListSalud_Remisiones
        End Get
        Set(ByVal Value As List(Of Salud_RemisionesBrl))
            Me.objListSalud_Remisiones = Value
        End Set
    End Property

    Public Property Salud_Valoracion() As List(Of Salud_ValoracionBrl)
        Get
            If (Me.objListSalud_Valoracion Is Nothing) Then
                objListSalud_Valoracion = Salud_ValoracionBrl.CargarPorId_salud(Me.ID)
            End If
            Return Me.objListSalud_Valoracion
        End Get
        Set(ByVal Value As List(Of Salud_ValoracionBrl))
            Me.objListSalud_Valoracion = Value
        End Set
    End Property

    Public ReadOnly Property Crecimiento_Desarrollo() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Crecimiento_Desarrollo)
        End Get
    End Property

    Public ReadOnly Property Esquema_Vacunacion_Completo() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Esquema_Vacunacion_Completo)
        End Get
    End Property

    Public ReadOnly Property Lactancia_Lactando() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Lactancia_Lactando)
        End Get
    End Property

    Public ReadOnly Property Motivo_No_Vacunados() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Motivo_No_Vacunados)
        End Get
    End Property

    Public ReadOnly Property Ninos_Vacunados() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Ninos_Vacunados)
        End Get
    End Property

    Public ReadOnly Property Razon_No_Carnet() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Razon_No_Carnet)
        End Get
    End Property

    Public ReadOnly Property Razon_No_Vacunacion_Completo() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Razon_No_Vacunacion_Completo)
        End Get
    End Property

    Public ReadOnly Property Vacunacion_Carnet() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Vacunacion_Carnet)
        End Get
    End Property

    Public ReadOnly Property Vitaminas_Desparasitacion() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Vitaminas_Desparasitacion)
        End Get
    End Property

    Public ReadOnly Property Vitaminas_Suplementacion() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Vitaminas_Suplementacion)
        End Get
    End Property

    Public Readonly Property Personas() As PersonasBrl
        Get
            Return PersonasBrl.CargarPorID(Id_Persona)
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

    Public ReadOnly Property Motivo_NoCrecimiento_Desarrollo() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Motivo_No_CYD)
        End Get
    End Property

    Public ReadOnly Property Crecimiento_Desarrollo_IRD() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Crecimiento_Desarrollo_IRD)
        End Get
    End Property

    Public ReadOnly Property Motivo_NoCrecimiento_Desarrollo_IRD() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Motivo_NO_CYD_IRD)
        End Get
    End Property

    Public ReadOnly Property CrecimientoyDesarrollo() As String
        Get
            If Crecimiento_Desarrollo Is Nothing Then
                Return ""
            Else
                Return Crecimiento_Desarrollo.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Lactando() As String
        Get
            If Lactancia_Lactando Is Nothing Then
                Return ""
            Else
                Return Lactancia_Lactando.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property TieneCarnet() As String
        Get
            If Vacunacion_Carnet Is Nothing Then
                Return ""
            Else
                Return Vacunacion_Carnet.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property MotivoNoCarnet() As String
        Get
            If Razon_No_Carnet Is Nothing Then
                Return ""
            Else
                Return Razon_No_Carnet.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property VacunacionCompleta() As String
        Get
            If Esquema_Vacunacion_Completo Is Nothing Then
                Return ""
            Else
                Return Esquema_Vacunacion_Completo.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property MotivoNovacunacionCompleta() As String
        Get
            If Razon_No_Vacunacion_Completo Is Nothing Then
                Return ""
            Else
                Return Razon_No_Vacunacion_Completo.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property MotivoNovacunados() As String
        Get
            If Motivo_No_Vacunados Is Nothing Then
                Return ""
            Else
                Return Motivo_No_Vacunados.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Desparasitacion() As String
        Get
            If Vitaminas_Desparasitacion Is Nothing Then
                Return ""
            Else
                Return Vitaminas_Desparasitacion.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Suplementacion() As String
        Get
            If Vitaminas_Suplementacion Is Nothing Then
                Return ""
            Else
                Return Vitaminas_Suplementacion.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Vacunados() As String
        Get
            If Ninos_Vacunados Is Nothing Then
                Return ""
            Else
                Return Ninos_Vacunados.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property CantidadValoraciones() As Integer
        Get
            Return Salud_Valoracion.Count
        End Get
    End Property

    Public ReadOnly Property RealizoValoracion_PrimeraEntrega() As Boolean
        Get
            For Each fila As Salud_ValoracionBrl In Salud_Valoracion
                If fila.Id_Tipo_Proceso = 72 Then
                    Return True
                End If
            Next
            Return False
        End Get
    End Property

    Public ReadOnly Property RealizoValoracion_SegundaEntrega() As Boolean
        Get
            For Each fila As Salud_ValoracionBrl In Salud_Valoracion
                If fila.Id_Tipo_Proceso = 918 Then
                    Return True
                End If
            Next
            Return False
        End Get
    End Property

    Public ReadOnly Property RealizoValoracion_Seguimiento() As Boolean
        Get
            For Each fila As Salud_ValoracionBrl In Salud_Valoracion
                If fila.Id_Tipo_Proceso = 919 Then
                    Return True
                End If
            Next
            Return False
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
            Me.ID = SaludDAL.Insertar(Id_Persona, Id_Crecimiento_Desarrollo, Patologia, Id_Lactancia_Lactando, Lactancia_meses, Lactancia_Exclusiva, Id_Vitaminas_Desparasitacion, Id_Vitaminas_Suplementacion, Id_Vacunacion_Carnet, Id_Razon_No_Carnet, Id_Esquema_Vacunacion_Completo, Id_Razon_No_Vacunacion_Completo, Fecha_Esquema_Vacunacion, Id_Ninos_Vacunados, Id_Motivo_No_Vacunados, Observaciones, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Id_Motivo_No_CYD, Id_Crecimiento_Desarrollo_IRD, Id_Motivo_NO_CYD_IRD, Fecha_Cierre, Cierre)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            SaludDAL.Actualizar(ID, Id_Persona, Id_Crecimiento_Desarrollo, Patologia, Id_Lactancia_Lactando, Lactancia_meses, Lactancia_Exclusiva, Id_Vitaminas_Desparasitacion, Id_Vitaminas_Suplementacion, Id_Vacunacion_Carnet, Id_Razon_No_Carnet, Id_Esquema_Vacunacion_Completo, Id_Razon_No_Vacunacion_Completo, Fecha_Esquema_Vacunacion, Id_Ninos_Vacunados, Id_Motivo_No_Vacunados, Observaciones, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Id_Motivo_No_CYD, Id_Crecimiento_Desarrollo_IRD, Id_Motivo_NO_CYD_IRD, Fecha_Cierre, Cierre)
            RaiseEvent Updated()
        End If

        If Not objListSalud_Remisiones Is Nothing Then
            For Each fila As Salud_RemisionesBrl In objListSalud_Remisiones
                fila.Id_Salud = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception
                End Try
            Next
        End If

        If Not objListSalud_Valoracion Is Nothing Then
            For Each fila As Salud_ValoracionBrl In objListSalud_Valoracion
                fila.Id_salud = Me.ID
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
            totalHijos += Salud_Remisiones.Count
            totalHijos += Salud_Valoracion.Count

            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            SaludDAL.Eliminar(Me.ID)

            RaiseEvent Deleted()

        End If
    End Sub

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As SaludBrl

        Dim objSalud As New SaludBrl

        With objSalud
            .ID = fila("Id")
            .Id_Persona = isDBNullToNothing(fila("Id_Persona"))
            .Id_Crecimiento_Desarrollo = isDBNullToNothing(fila("Id_Crecimiento_Desarrollo"))
            .Patologia = isDBNullToNothing(fila("Patologia"))
            .Id_Lactancia_Lactando = isDBNullToNothing(fila("Id_Lactancia_Lactando"))
            .Lactancia_meses = isDBNullToNothing(fila("Lactancia_meses"))
            .Lactancia_Exclusiva = isDBNullToNothing(fila("Lactancia_Exclusiva"))
            .Id_Vitaminas_Desparasitacion = isDBNullToNothing(fila("Id_Vitaminas_Desparasitacion"))
            .Id_Vitaminas_Suplementacion = isDBNullToNothing(fila("Id_Vitaminas_Suplementacion"))
            .Id_Vacunacion_Carnet = isDBNullToNothing(fila("Id_Vacunacion_Carnet"))
            .Id_Razon_No_Carnet = isDBNullToNothing(fila("Id_Razon_No_Carnet"))
            .Id_Esquema_Vacunacion_Completo = isDBNullToNothing(fila("Id_Esquema_Vacunacion_Completo"))
            .Id_Razon_No_Vacunacion_Completo = isDBNullToNothing(fila("Id_Razon_No_Vacunacion_Completo"))
            .Fecha_Esquema_Vacunacion = isDBNullToNothing(fila("Fecha_Esquema_Vacunacion"))
            .Id_Ninos_Vacunados = isDBNullToNothing(fila("Id_Ninos_Vacunados"))
            .Id_Motivo_No_Vacunados = isDBNullToNothing(fila("Id_Motivo_No_Vacunados"))
            .Observaciones = isDBNullToNothing(fila("Observaciones"))
            .Fecha_Creacion = isDBNullToNothing(fila("Fecha_Creacion"))
            .Id_Usuario_Creacion = isDBNullToNothing(fila("Id_Usuario_Creacion"))
            .Fecha_Modificacion = isDBNullToNothing(fila("Fecha_Modificacion"))
            .Id_Usuario_Modificacion = isDBNullToNothing(fila("Id_Usuario_Modificacion"))
            .Id_Motivo_No_CYD = isDBNullToNothing(fila("Id_Motivo_No_CYD"))
            .Id_Crecimiento_Desarrollo_IRD = isDBNullToNothing(fila("Id_Crecimiento_Desarrollo_IRD"))
            .Id_Motivo_NO_CYD_IRD = isDBNullToNothing(fila("Id_Motivo_NO_CYD_IRD"))
            .Fecha_Cierre = isDBNullToNothing(fila("Fecha_Cierre"))
            .Cierre = isDBNullToNothing(fila("Cierre"))
        End With

        Return objSalud

    End Function

    Public Shared Event LoadingSaludList(ByVal LoadType As String)
    Public Shared Event LoadedSaludList(ByVal target As List(Of SaludBrl), ByVal LoadType As String)

    Public Shared Function CargarTodos() As List(Of SaludBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SaludBrl)

        RaiseEvent LoadingSaludList("CargarTodos")

        dsDatos = SaludDAL.CargarTodos()

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSaludList(lista, "CargarTodos")

        Return lista

    End Function

    Public Shared Event LoadingPorId(ByVal id As Int32)
    Public Shared Event LoadedPorId(ByVal target As SaludBrl)

    Public Shared Function CargarPorID(ByVal ID As Int32) As SaludBrl

        Dim dsDatos As System.Data.DataSet
        Dim objSalud As SaludBrl = Nothing
        dsDatos = SaludDAL.CargarPorID(ID)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objSalud = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objSalud

    End Function

    Public Shared Function CargarPorId_Crecimiento_Desarrollo(ByVal Id_Crecimiento_Desarrollo As Int32) As List(Of SaludBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SaludBrl)

        RaiseEvent LoadingSaludList("CargarPorId_Crecimiento_Desarrollo")

        dsDatos = SaludDAL.CargarPorId_Crecimiento_Desarrollo(Id_Crecimiento_Desarrollo)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSaludList(lista, "CargarPorId_Crecimiento_Desarrollo")

        Return lista

    End Function

    Public Shared Function CargarPorId_Esquema_Vacunacion_Completo(ByVal Id_Esquema_Vacunacion_Completo As Int32) As List(Of SaludBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SaludBrl)

        RaiseEvent LoadingSaludList("CargarPorId_Esquema_Vacunacion_Completo")

        dsDatos = SaludDAL.CargarPorId_Esquema_Vacunacion_Completo(Id_Esquema_Vacunacion_Completo)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSaludList(lista, "CargarPorId_Esquema_Vacunacion_Completo")

        Return lista

    End Function

    Public Shared Function CargarPorId_Lactancia_Lactando(ByVal Id_Lactancia_Lactando As Int32) As List(Of SaludBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SaludBrl)

        RaiseEvent LoadingSaludList("CargarPorId_Lactancia_Lactando")

        dsDatos = SaludDAL.CargarPorId_Lactancia_Lactando(Id_Lactancia_Lactando)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSaludList(lista, "CargarPorId_Lactancia_Lactando")

        Return lista

    End Function

    Public Shared Function CargarPorId_Motivo_No_Vacunados(ByVal Id_Motivo_No_Vacunados As Int32) As List(Of SaludBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SaludBrl)

        RaiseEvent LoadingSaludList("CargarPorId_Motivo_No_Vacunados")

        dsDatos = SaludDAL.CargarPorId_Motivo_No_Vacunados(Id_Motivo_No_Vacunados)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSaludList(lista, "CargarPorId_Motivo_No_Vacunados")

        Return lista

    End Function

    Public Shared Function CargarPorId_Ninos_Vacunados(ByVal Id_Ninos_Vacunados As Int32) As List(Of SaludBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SaludBrl)

        RaiseEvent LoadingSaludList("CargarPorId_Ninos_Vacunados")

        dsDatos = SaludDAL.CargarPorId_Ninos_Vacunados(Id_Ninos_Vacunados)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSaludList(lista, "CargarPorId_Ninos_Vacunados")

        Return lista

    End Function

    Public Shared Function CargarPorId_Razon_No_Carnet(ByVal Id_Razon_No_Carnet As Int32) As List(Of SaludBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SaludBrl)

        RaiseEvent LoadingSaludList("CargarPorId_Razon_No_Carnet")

        dsDatos = SaludDAL.CargarPorId_Razon_No_Carnet(Id_Razon_No_Carnet)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSaludList(lista, "CargarPorId_Razon_No_Carnet")

        Return lista

    End Function

    Public Shared Function CargarPorId_Razon_No_Vacunacion_Completo(ByVal Id_Razon_No_Vacunacion_Completo As Int32) As List(Of SaludBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SaludBrl)

        RaiseEvent LoadingSaludList("CargarPorId_Razon_No_Vacunacion_Completo")

        dsDatos = SaludDAL.CargarPorId_Razon_No_Vacunacion_Completo(Id_Razon_No_Vacunacion_Completo)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSaludList(lista, "CargarPorId_Razon_No_Vacunacion_Completo")

        Return lista

    End Function

    Public Shared Function CargarPorId_Vacunacion_Carnet(ByVal Id_Vacunacion_Carnet As Int32) As List(Of SaludBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SaludBrl)

        RaiseEvent LoadingSaludList("CargarPorId_Vacunacion_Carnet")

        dsDatos = SaludDAL.CargarPorId_Vacunacion_Carnet(Id_Vacunacion_Carnet)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSaludList(lista, "CargarPorId_Vacunacion_Carnet")

        Return lista

    End Function

    Public Shared Function CargarPorId_Vitaminas_Desparasitacion(ByVal Id_Vitaminas_Desparasitacion As Int32) As List(Of SaludBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SaludBrl)

        RaiseEvent LoadingSaludList("CargarPorId_Vitaminas_Desparasitacion")

        dsDatos = SaludDAL.CargarPorId_Vitaminas_Desparasitacion(Id_Vitaminas_Desparasitacion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSaludList(lista, "CargarPorId_Vitaminas_Desparasitacion")

        Return lista

    End Function

    Public Shared Function CargarPorId_Vitaminas_Suplementacion(ByVal Id_Vitaminas_Suplementacion As Int32) As List(Of SaludBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SaludBrl)

        RaiseEvent LoadingSaludList("CargarPorId_Vitaminas_Suplementacion")

        dsDatos = SaludDAL.CargarPorId_Vitaminas_Suplementacion(Id_Vitaminas_Suplementacion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSaludList(lista, "CargarPorId_Vitaminas_Suplementacion")

        Return lista

    End Function

    Public Shared Function CargarPorId_Persona(ByVal Id_Persona As Int32) As List(Of SaludBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SaludBrl)
        dsDatos = SaludDAL.CargarPorId_Persona(Id_Persona)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As Int32) As List(Of SaludBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SaludBrl)
        dsDatos = SaludDAL.CargarPorId_Usuario_Creacion(Id_Usuario_Creacion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function

    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As Int32) As List(Of SaludBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SaludBrl)
        dsDatos = SaludDAL.CargarPorId_Usuario_Modificacion(Id_Usuario_Modificacion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_Motivo_No_CYD(ByVal Id_Motivo_No_CYD As Int32) As List(Of SaludBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SaludBrl)
        RaiseEvent LoadingSaludList("CargarPorId_Motivo_No_CYD")
        dsDatos = SaludDAL.CargarPorId_Motivo_No_CYD(Id_Motivo_No_CYD)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedSaludList(lista, "CargarPorId_Motivo_No_CYD")
        Return lista
    End Function

    Public Shared Function CargarPorId_Crecimiento_Desarrollo_IRD(ByVal Id_Crecimiento_Desarrollo_IRD As Int32) As List(Of SaludBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SaludBrl)
        RaiseEvent LoadingSaludList("CargarPorId_Crecimiento_Desarrollo_IRD")
        dsDatos = SaludDAL.CargarPorId_Crecimiento_Desarrollo_IRD(Id_Crecimiento_Desarrollo_IRD)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedSaludList(lista, "CargarPorId_Crecimiento_Desarrollo_IRD")
        Return lista
    End Function

    Public Shared Function CargarPorId_Motivo_NO_CYD_IRD(ByVal Id_Motivo_NO_CYD_IRD As Int32) As List(Of SaludBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SaludBrl)
        RaiseEvent LoadingSaludList("CargarPorId_Motivo_NO_CYD_IRD")
        dsDatos = SaludDAL.CargarPorId_Motivo_NO_CYD_IRD(Id_Motivo_NO_CYD_IRD)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedSaludList(lista, "CargarPorId_Motivo_NO_CYD_IRD")
        Return lista
    End Function
End Class


