Imports ingNovar.Utilidades2
Imports System.Data
Imports System.Collections.Generic
Imports SeguridadUsuarios

Partial Public Class Salud_ValoracionBrl

    Private _Id As Int32
    Private _Id_salud As Int32
    Private _Fecha_Valoracion As DateTime
    Private _Antropometria_Peso As Double
    Private _Antropometria_Talla As Double
    Private _Antropometia_Perimetro_Branquial As Double
    Private _Diferencia_Peso As Double
    Private _Id_Recuperado As Int32
    Private _Observaciones As String
    Private _Peso_talla As Double
    Private _Peso_edad As Double
    Private _Talla_Longitud As Double
    Private _IMC_Edad As Double
    Private _Edad As Int32
    Private _Meses As Int32
    Private _Talla_Para_Edad As String
    Private _Estado_Nutricional As String
    Private _Id_Tipo_Proceso As Int32
    Private _Fecha_Cierre As DateTime
    Private _Cierre As Boolean
    Private _Fecha_Creacion As DateTime
    Private _Id_Usuario_Creacion As Int32
    Private _Fecha_Modificacion As DateTime
    Private _Id_Usuario_Modificacion As Int32


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

    Public Event Id_saludChanging(ByVal Value As Int32)
    Public Event Id_saludChanged()

    Public Property Id_salud() As Int32
        Get
            Return Me._Id_salud
        End Get
        Set(ByVal Value As Int32)
            If _Id_salud <> Value Then
                RaiseEvent Id_saludChanging(Value)
                Me._Id_salud = Value
                RaiseEvent Id_saludChanged()
            End If
        End Set
    End Property

    Public Event Fecha_ValoracionChanging(ByVal Value As DateTime)
    Public Event Fecha_ValoracionChanged()

    Public Property Fecha_Valoracion() As DateTime
        Get
            Return Me._Fecha_Valoracion
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_Valoracion <> Value Then
                RaiseEvent Fecha_ValoracionChanging(Value)
                Me._Fecha_Valoracion = Value
                RaiseEvent Fecha_ValoracionChanged()
            End If
        End Set
    End Property

    Public Event Antropometria_PesoChanging(ByVal Value As Double)
    Public Event Antropometria_PesoChanged()

    Public Property Antropometria_Peso() As Double
        Get
            Return Me._Antropometria_Peso
        End Get
        Set(ByVal Value As Double)
            If _Antropometria_Peso <> Value Then
                RaiseEvent Antropometria_PesoChanging(Value)
                Me._Antropometria_Peso = Value
                RaiseEvent Antropometria_PesoChanged()
            End If
        End Set
    End Property

    Public Event Antropometria_TallaChanging(ByVal Value As Double)
    Public Event Antropometria_TallaChanged()

    Public Property Antropometria_Talla() As Double
        Get
            Return Me._Antropometria_Talla
        End Get
        Set(ByVal Value As Double)
            If _Antropometria_Talla <> Value Then
                RaiseEvent Antropometria_TallaChanging(Value)
                Me._Antropometria_Talla = Value
                RaiseEvent Antropometria_TallaChanged()
            End If
        End Set
    End Property

    Public Event Antropometia_Perimetro_BranquialChanging(ByVal Value As Double)
    Public Event Antropometia_Perimetro_BranquialChanged()

    Public Property Antropometia_Perimetro_Branquial() As Double
        Get
            Return Me._Antropometia_Perimetro_Branquial
        End Get
        Set(ByVal Value As Double)
            If _Antropometia_Perimetro_Branquial <> Value Then
                RaiseEvent Antropometia_Perimetro_BranquialChanging(Value)
                Me._Antropometia_Perimetro_Branquial = Value
                RaiseEvent Antropometia_Perimetro_BranquialChanged()
            End If
        End Set
    End Property

    Public Event Diferencia_PesoChanging(ByVal Value As Double)
    Public Event Diferencia_PesoChanged()

    Public Property Diferencia_Peso() As Double
        Get
            Return Me._Diferencia_Peso
        End Get
        Set(ByVal Value As Double)
            If _Diferencia_Peso <> Value Then
                RaiseEvent Diferencia_PesoChanging(Value)
                Me._Diferencia_Peso = Value
                RaiseEvent Diferencia_PesoChanged()
            End If
        End Set
    End Property

    Public Event Id_RecuperadoChanging(ByVal Value As Int32)
    Public Event Id_RecuperadoChanged()

    Public Property Id_Recuperado() As Int32
        Get
            Return Me._Id_Recuperado
        End Get
        Set(ByVal Value As Int32)
            If _Id_Recuperado <> Value Then
                RaiseEvent Id_RecuperadoChanging(Value)
                Me._Id_Recuperado = Value
                RaiseEvent Id_RecuperadoChanged()
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

    Public Event Peso_tallaChanging(ByVal Value As Double)
    Public Event Peso_tallaChanged()

    Public Property Peso_talla() As Double
        Get
            Return Me._Peso_talla
        End Get
        Set(ByVal Value As Double)
            If _Peso_talla <> Value Then
                RaiseEvent Peso_tallaChanging(Value)
                Me._Peso_talla = Value
                RaiseEvent Peso_tallaChanged()
            End If
        End Set
    End Property

    Public Event Peso_edadChanging(ByVal Value As Double)
    Public Event Peso_edadChanged()

    Public Property Peso_edad() As Double
        Get
            Return Me._Peso_edad
        End Get
        Set(ByVal Value As Double)
            If _Peso_edad <> Value Then
                RaiseEvent Peso_edadChanging(Value)
                Me._Peso_edad = Value
                RaiseEvent Peso_edadChanged()
            End If
        End Set
    End Property

    Public Event Talla_LongitudChanging(ByVal Value As Double)
    Public Event Talla_LongitudChanged()

    Public Property Talla_Longitud() As Double
        Get
            Return Me._Talla_Longitud
        End Get
        Set(ByVal Value As Double)
            If _Talla_Longitud <> Value Then
                RaiseEvent Talla_LongitudChanging(Value)
                Me._Talla_Longitud = Value
                RaiseEvent Talla_LongitudChanged()
            End If
        End Set
    End Property

    Public Event IMC_EdadChanging(ByVal Value As Double)
    Public Event IMC_EdadChanged()

    Public Property IMC_Edad() As Double
        Get
            Return Me._IMC_Edad
        End Get
        Set(ByVal Value As Double)
            If _IMC_Edad <> Value Then
                RaiseEvent IMC_EdadChanging(Value)
                Me._IMC_Edad = Value
                RaiseEvent IMC_EdadChanged()
            End If
        End Set
    End Property

    Public Event EdadChanging(ByVal Value As Int32)
    Public Event EdadChanged()

    Public Property Edad() As Int32
        Get
            Return Me._Edad
        End Get
        Set(ByVal Value As Int32)
            If _Edad <> Value Then
                RaiseEvent EdadChanging(Value)
                Me._Edad = Value
                RaiseEvent EdadChanged()
            End If
        End Set
    End Property

    Public Event MesesChanging(ByVal Value As Int32)
    Public Event MesesChanged()

    Public Property Meses() As Int32
        Get
            Return Me._Meses
        End Get
        Set(ByVal Value As Int32)
            If _Meses <> Value Then
                RaiseEvent MesesChanging(Value)
                Me._Meses = Value
                RaiseEvent MesesChanged()
            End If
        End Set
    End Property

    Public Event Talla_Para_EdadChanging(ByVal Value As String)
    Public Event Talla_Para_EdadChanged()

    Public Property Talla_Para_Edad() As String
        Get
            Return Me._Talla_Para_Edad
        End Get
        Set(ByVal Value As String)
            If _Talla_Para_Edad <> Value Then
                RaiseEvent Talla_Para_EdadChanging(Value)
                Me._Talla_Para_Edad = Value
                RaiseEvent Talla_Para_EdadChanged()
            End If
        End Set
    End Property

    Public Event Estado_NutricionalChanging(ByVal Value As String)
    Public Event Estado_NutricionalChanged()

    Public Property Estado_Nutricional() As String
        Get
            Return Me._Estado_Nutricional
        End Get
        Set(ByVal Value As String)
            If _Estado_Nutricional <> Value Then
                RaiseEvent Estado_NutricionalChanging(Value)
                Me._Estado_Nutricional = Value
                RaiseEvent Estado_NutricionalChanged()
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

    Public Event ID_Tipo_ProcesoChanging(ByVal Value As Int32)
    Public Event ID_Tipo_ProcesoChanged()

    Public Property Id_Tipo_Proceso() As Int32
        Get
            Return Me._Id_Tipo_Proceso
        End Get
        Set(ByVal Value As Int32)
            If _Id_Tipo_Proceso <> Value Then
                RaiseEvent IDChanging(Value)
                Me._Id_Tipo_Proceso = Value
                RaiseEvent IDChanged()
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

    Public ReadOnly Property SubTablasRecuperado() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Recuperado)
        End Get
    End Property

    Public ReadOnly Property Salud() As SaludBrl
        Get
            Return SaludBrl.CargarPorID(Id_salud)
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

    Public ReadOnly Property TipoProceso() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Tipo_Proceso)
        End Get
    End Property

    Public ReadOnly Property Recuperado() As String
        Get
            If SubTablasRecuperado Is Nothing Then
                Return ""
            Else
                Return SubTablasRecuperado.Descripcion
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
            Me.ID = Salud_ValoracionDAL.Insertar(Id_salud, Fecha_Valoracion, Antropometria_Peso, Antropometria_Talla, Antropometia_Perimetro_Branquial, Diferencia_Peso, Id_Recuperado, Observaciones, Peso_talla, Peso_edad, Talla_Longitud, IMC_Edad, Edad, Meses, Talla_Para_Edad, Estado_Nutricional, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Id_Tipo_Proceso, Fecha_Cierre, Cierre)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            Salud_ValoracionDAL.Actualizar(ID, Id_salud, Fecha_Valoracion, Antropometria_Peso, Antropometria_Talla, Antropometia_Perimetro_Branquial, Diferencia_Peso, Id_Recuperado, Observaciones, Peso_talla, Peso_edad, Talla_Longitud, IMC_Edad, Edad, Meses, Talla_Para_Edad, Estado_Nutricional, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Id_Tipo_Proceso, Fecha_Cierre, Cierre)
            RaiseEvent Updated()
        End If
        RaiseEvent Saved()

    End Sub

    Public Sub Eliminar()
        Dim totalHijos As Long = 0
        If Me.ID <> Nothing Then

            RaiseEvent Deleting()
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            Salud_ValoracionDAL.Eliminar(Me.ID)
            RaiseEvent Deleted()

        End If
    End Sub

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Salud_ValoracionBrl

        Dim objSalud_Valoracion As New Salud_ValoracionBrl

        With objSalud_Valoracion
            .ID = fila("Id")
            .Id_salud = isDBNullToNothing(fila("Id_salud"))
            .Fecha_Valoracion = isDBNullToNothing(fila("Fecha_Valoracion"))
            .Antropometria_Peso = isDBNullToNothing(fila("Antropometria_Peso"))
            .Antropometria_Talla = isDBNullToNothing(fila("Antropometria_Talla"))
            .Antropometia_Perimetro_Branquial = isDBNullToNothing(fila("Antropometia_Perimetro_Branquial"))
            .Diferencia_Peso = isDBNullToNothing(fila("Diferencia_Peso"))
            .Id_Recuperado = isDBNullToNothing(fila("Id_Recuperado"))
            .Observaciones = isDBNullToNothing(fila("Observaciones"))
            .Peso_talla = isDBNullToNothing(fila("Peso_talla"))
            .Peso_edad = isDBNullToNothing(fila("Peso_edad"))
            .Talla_Longitud = isDBNullToNothing(fila("Talla_Longitud"))
            .IMC_Edad = isDBNullToNothing(fila("IMC_Edad"))
            .Edad = isDBNullToNothing(fila("Edad"))
            .Meses = isDBNullToNothing(fila("Meses"))
            .Talla_Para_Edad = isDBNullToNothing(fila("Talla_Para_Edad"))
            .Estado_Nutricional = isDBNullToNothing(fila("Estado_Nutricional"))
            .Fecha_Creacion = isDBNullToNothing(fila("Fecha_Creacion"))
            .Id_Usuario_Creacion = isDBNullToNothing(fila("Id_Usuario_Creacion"))
            .Fecha_Modificacion = isDBNullToNothing(fila("Fecha_Modificacion"))
            .Id_Usuario_Modificacion = isDBNullToNothing(fila("Id_Usuario_Modificacion"))
            .Id_Tipo_Proceso = isDBNullToNothing(fila("ID_Tipo_Proceso"))
            .Fecha_Cierre = isDBNullToNothing(fila("Fecha_Cierre"))
            .Cierre = isDBNullToNothing(fila("Cierre"))
        End With

        Return objSalud_Valoracion

    End Function

    Public Shared Event LoadingSalud_ValoracionList(ByVal LoadType As String)
    Public Shared Event LoadedSalud_ValoracionList(ByVal target As List(Of Salud_ValoracionBrl), ByVal LoadType As String)

    Public Shared Function CargarTodos() As List(Of Salud_ValoracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Salud_ValoracionBrl)

        RaiseEvent LoadingSalud_ValoracionList("CargarTodos")

        dsDatos = Salud_ValoracionDAL.CargarTodos()

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSalud_ValoracionList(lista, "CargarTodos")

        Return lista

    End Function

    Public Shared Event CargandoPorId(ByVal id As Int32)
    Public Shared Event CargadoPorId(ByVal target As Salud_ValoracionBrl)

    Public Shared Function CargarPorID(ByVal ID As Int32) As Salud_ValoracionBrl

        Dim dsDatos As System.Data.DataSet
        Dim objSalud_Valoracion As Salud_ValoracionBrl = Nothing
        RaiseEvent CargandoPorId(ID)
        dsDatos = Salud_ValoracionDAL.CargarPorID(ID)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objSalud_Valoracion = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objSalud_Valoracion

    End Function

    Public Shared Function CargarPorId_Recuperado(ByVal Id_Recuperado As Int32) As List(Of Salud_ValoracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Salud_ValoracionBrl)

        RaiseEvent LoadingSalud_ValoracionList("CargarPorId_Recuperado")
        dsDatos = Salud_ValoracionDAL.CargarPorId_Recuperado(Id_Recuperado)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedSalud_ValoracionList(lista, "CargarPorId_Recuperado")

        Return lista

    End Function

    Public Shared Function CargarPorId_salud(ByVal Id_salud As Int32) As List(Of Salud_ValoracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Salud_ValoracionBrl)
        RaiseEvent LoadingSalud_ValoracionList("CargarPorId_salud")
        dsDatos = Salud_ValoracionDAL.CargarPorId_Salud(Id_salud)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedSalud_ValoracionList(lista, "CargarPorId_salud")

        Return lista

    End Function

    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As Int32) As List(Of Salud_ValoracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Salud_ValoracionBrl)

        RaiseEvent LoadingSalud_ValoracionList("CargarPorId_Usuario_Creacion")
        dsDatos = Salud_ValoracionDAL.CargarPorId_Usuario_Creacion(Id_Usuario_Creacion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedSalud_ValoracionList(lista, "CargarPorId_Usuario_Creacion")

        Return lista

    End Function

    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As Int32) As List(Of Salud_ValoracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Salud_ValoracionBrl)

        RaiseEvent LoadingSalud_ValoracionList("CargarPorId_Usuario_Modificacion")
        dsDatos = Salud_ValoracionDAL.CargarPorId_Usuario_Modificacion(Id_Usuario_Modificacion)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSalud_ValoracionList(lista, "CargarPorId_Usuario_Modificacion")

        Return lista

    End Function

    Public Shared Function CargarPorUltimoRegistro(ByVal IDSalud As Int32, ByVal idvaloracion As Int32, ByVal fecha As String) As Salud_ValoracionBrl
        Dim dsDatos As System.Data.DataSet
        Dim objSalud_Valoracion As Salud_ValoracionBrl = Nothing
        dsDatos = Salud_ValoracionDAL.CargarPorUltimoRegistro(IDSalud, idvaloracion, fecha)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objSalud_Valoracion = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objSalud_Valoracion
    End Function

    Public Shared Function CargarPorId_Tipo_Proceso(ByVal Id_Tipo_Proceso As Int32) As List(Of Salud_ValoracionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Salud_ValoracionBrl)

        RaiseEvent LoadingSalud_ValoracionList("CargarPorId_Tipo_Proceso")
        dsDatos = Salud_ValoracionDAL.CargarPorId_Tipo_Proceso(Id_Tipo_Proceso)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedSalud_ValoracionList(lista, "CargarPorId_Tipo_Proceso")

        Return lista

    End Function

End Class


