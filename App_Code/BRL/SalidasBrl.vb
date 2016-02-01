Imports ingNovar.Utilidades2
Imports System.Data
Imports System.Collections.Generic
Imports SeguridadUsuarios

Partial Public Class SalidasBrl

    Private _Id As Int32
    Private _Id_Tipo_Salida As Int32
    Private _Numero As String
    Private _Fecha As DateTime
    Private _Nombre_Entrega As String
    Private _Nombre_Salida As String
    Private _Id_Regional As Int32
    Private _Id_Bodega As Int32
    Private _Id_Tercero As Int32
    Private _Id_Reg_Grupo As Int32
    Private _Id_Tipo_Entrega As Int32
    Private _Dias_Entrega As Int32
    Private _Observacion As String
    Private _Tipo As String
    Private _Legalizado As Integer
    Private _Fecha_Creacion As DateTime
    Private _Id_Usuario_Creacion As Int32
    Private _Fecha_Modificacion As DateTime
    Private _Id_Usuario_Modificacion As Int32
    Private _Fecha_Cierre As DateTime
    Private _Cierre As Boolean
    Private _Id_Programa As Int32


    Private objListSalidas_Detalle As List(Of Salidas_DetalleBrl)
    Private objListEntradas As List(Of EntradasBrl)
    Private objListSalidas_Aprobaciones As List(Of Salidas_AprobacionesBrl)
    Private objListPlanillas_Salidas As List(Of Planilla_SalidasBrl)

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

    Public Event Id_Tipo_SalidaChanging(ByVal Value As Int32)
    Public Event Id_Tipo_SalidaChanged()

    Public Property Id_Tipo_Salida() As Int32
        Get
            Return Me._Id_Tipo_Salida
        End Get
        Set(ByVal Value As Int32)
            If _Id_Tipo_Salida <> Value Then
                RaiseEvent Id_Tipo_SalidaChanging(Value)
                Me._Id_Tipo_Salida = Value
                RaiseEvent Id_Tipo_SalidaChanged()
            End If
        End Set
    End Property

    Public Event NumeroChanging(ByVal Value As String)
    Public Event NumeroChanged()

    Public Property Numero() As String
        Get
            Return Me._Numero
        End Get
        Set(ByVal Value As String)
            If _Numero <> Value Then
                RaiseEvent NumeroChanging(Value)
                Me._Numero = Value
                RaiseEvent NumeroChanged()
            End If
        End Set
    End Property

    Public Event FechaChanging(ByVal Value As DateTime)
    Public Event FechaChanged()

    Public Property Fecha() As DateTime
        Get
            Return Me._Fecha
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha <> Value Then
                RaiseEvent FechaChanging(Value)
                Me._Fecha = Value
                RaiseEvent FechaChanged()
            End If
        End Set
    End Property

    Public Event Nombre_EntregaChanging(ByVal Value As String)
    Public Event Nombre_EntregaChanged()

    Public Property Nombre_Entrega() As String
        Get
            Return Me._Nombre_Entrega
        End Get
        Set(ByVal Value As String)
            If _Nombre_Entrega <> Value Then
                RaiseEvent Nombre_EntregaChanging(Value)
                Me._Nombre_Entrega = Value
                RaiseEvent Nombre_EntregaChanged()
            End If
        End Set
    End Property

    Public Event Nombre_SalidaChanging(ByVal Value As String)
    Public Event Nombre_SalidaChanged()

    Public Property Nombre_Salida() As String
        Get
            Return Me._Nombre_Salida
        End Get
        Set(ByVal Value As String)
            If _Nombre_Salida <> Value Then
                RaiseEvent Nombre_SalidaChanging(Value)
                Me._Nombre_Salida = Value
                RaiseEvent Nombre_SalidaChanged()
            End If
        End Set
    End Property

    Public Event Id_RegionalChanging(ByVal Value As Int32)
    Public Event Id_RegionalChanged()

    Public Property Id_Regional() As Int32
        Get
            Return Me._Id_regional
        End Get
        Set(ByVal Value As Int32)
            If _Id_regional <> Value Then
                RaiseEvent Id_RegionalChanging(Value)
                Me._Id_regional = Value
                RaiseEvent Id_RegionalChanged()
            End If
        End Set
    End Property

    Public Event Id_BodegaChanging(ByVal Value As Int32)
    Public Event Id_BodegaChanged()

    Public Property Id_Bodega() As Int32
        Get
            Return Me._Id_Bodega
        End Get
        Set(ByVal Value As Int32)
            If _Id_Bodega <> Value Then
                RaiseEvent Id_BodegaChanging(Value)
                Me._Id_Bodega = Value
                RaiseEvent Id_BodegaChanged()
            End If
        End Set
    End Property

    Public Event Id_TerceroChanging(ByVal Value As Int32)
    Public Event Id_TerceroChanged()

    Public Property Id_Tercero() As Int32
        Get
            Return Me._Id_Tercero
        End Get
        Set(ByVal Value As Int32)
            If _Id_Tercero <> Value Then
                RaiseEvent Id_TerceroChanging(Value)
                Me._Id_Tercero = Value
                RaiseEvent Id_TerceroChanged()
            End If
        End Set
    End Property

    Public Event Id_Reg_GrupoChanging(ByVal Value As Int32)
    Public Event Id_Reg_GrupoChanged()

    Public Property Id_Reg_Grupo() As Int32
        Get
            Return Me._Id_Reg_Grupo
        End Get
        Set(ByVal Value As Int32)
            If _Id_Reg_Grupo <> Value Then
                RaiseEvent Id_Reg_GrupoChanging(Value)
                Me._Id_Reg_Grupo = Value
                RaiseEvent Id_Reg_GrupoChanged()
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

    Public Event Dias_EntregaChanging(ByVal Value As Int32)
    Public Event Dias_EntregaChanged()

    Public Property Dias_Entrega() As Int32
        Get
            Return Me._Dias_Entrega
        End Get
        Set(ByVal Value As Int32)
            If _Dias_Entrega <> Value Then
                RaiseEvent Dias_EntregaChanging(Value)
                Me._Dias_Entrega = Value
                RaiseEvent Dias_EntregaChanged()
            End If
        End Set
    End Property

    Public Event ObservacionChanging(ByVal Value As String)
    Public Event ObservacionChanged()

    Public Property Observacion() As String
        Get
            Return Me._Observacion
        End Get
        Set(ByVal Value As String)
            If _Observacion <> Value Then
                RaiseEvent ObservacionChanging(Value)
                Me._Observacion = Value
                RaiseEvent ObservacionChanged()
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

    Public Event LegalizadoChanging(ByVal Value As Int32)
    Public Event LegalizadoChanged()

    Public Property Legalizado() As Int32
        Get
            Return Me._Legalizado
        End Get
        Set(ByVal Value As Int32)
            If _Legalizado <> Value Then
                RaiseEvent LegalizadoChanging(Value)
                Me._Legalizado = Value
                RaiseEvent LegalizadoChanged()
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

    Public Event Id_ProgramaChanging(ByVal Value As Int32)
    Public Event Id_ProgramaChanged()

    Public Property Id_Programa() As Int32
        Get
            Return Me._Id_Programa
        End Get
        Set(ByVal Value As Int32)
            If _Id_Programa <> Value Then
                RaiseEvent Id_ProgramaChanging(Value)
                Me._Id_Programa = Value
                RaiseEvent Id_ProgramaChanged()
            End If
        End Set
    End Property

    Public Property Salidas_Detalle() As List(Of Salidas_DetalleBrl)
        Get
            If (Me.objListSalidas_Detalle Is Nothing) Then
                objListSalidas_Detalle = Salidas_DetalleBrl.CargarPorId_Salida(Me.ID)
            End If
            Return Me.objListSalidas_Detalle
        End Get
        Set(ByVal Value As List(Of Salidas_DetalleBrl))
            Me.objListSalidas_Detalle = Value
        End Set
    End Property

    Public Property Entradas() As List(Of EntradasBrl)
        Get
            If (Me.objListEntradas Is Nothing) Then
                objListEntradas = EntradasBrl.CargarPorId_Salida_Traslado(Me.ID)
            End If
            Return Me.objListEntradas
        End Get
        Set(ByVal Value As List(Of EntradasBrl))
            Me.objListEntradas = Value
        End Set
    End Property

    Public Property Planillas_Salidas() As List(Of Planilla_SalidasBrl)
        Get
            If (Me.objListPlanillas_Salidas Is Nothing) Then
                objListPlanillas_Salidas = Planilla_SalidasBrl.CargarPorId_Planilla(Me.ID)
            End If
            Return Me.objListPlanillas_Salidas
        End Get
        Set(ByVal Value As List(Of Planilla_SalidasBrl))
            Me.objListPlanillas_Salidas = Value
        End Set
    End Property

    Public Property Salidas_Aprobaciones() As List(Of Salidas_AprobacionesBrl)
        Get
            If (Me.objListSalidas_Aprobaciones Is Nothing) Then
                objListSalidas_Aprobaciones = Salidas_AprobacionesBrl.CargarPorId_Salida(Me.ID)
            End If
            Return Me.objListSalidas_Aprobaciones
        End Get
        Set(ByVal Value As List(Of Salidas_AprobacionesBrl))
            Me.objListSalidas_Aprobaciones = Value
        End Set
    End Property

    Public ReadOnly Property Regional() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Regional)
        End Get
    End Property

    Public ReadOnly Property Bodega() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Bodega)
        End Get
    End Property

    Public ReadOnly Property Proveedor() As Ppto_TercerosBrl
        Get
            Return Ppto_TercerosBrl.CargarPorID(Id_Tercero)
        End Get
    End Property

    Public ReadOnly Property Reg_Grupo() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Reg_Grupo)
        End Get
    End Property

    Public ReadOnly Property TipoEntrega() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Tipo_Entrega)
        End Get
    End Property

    Public ReadOnly Property TipoSalida() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Tipo_Salida)
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

    Public ReadOnly Property Programa() As ProgramacionBrl
        Get
            Return ProgramacionBrl.CargarPorID(Id_Programa)
        End Get
    End Property

    Public ReadOnly Property DescripcionSalida() As String
        Get
            Return "Sal : " & Numero.Trim & " - Fecha : " & FechaUtil.toStringDDMMYYY(Fecha)
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
            Me.ID = SalidasDAL.Insertar(Id_Tipo_Salida, Numero, Fecha, Nombre_Entrega, Nombre_Salida, Id_Regional, Id_Bodega, Id_Tercero, Id_Reg_Grupo, Id_Tipo_Entrega, Dias_Entrega, Observacion, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Tipo, Legalizado, Fecha_Cierre, Cierre, Id_Programa)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            SalidasDAL.Actualizar(ID, Id_Tipo_Salida, Numero, Fecha, Nombre_Entrega, Nombre_Salida, Id_Regional, Id_Bodega, Id_Tercero, Id_Reg_Grupo, Id_Tipo_Entrega, Dias_Entrega, Observacion, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Tipo, Legalizado, Fecha_Cierre, Cierre, Id_Programa)
            RaiseEvent Updated()
        End If
        If Not objListSalidas_Detalle Is Nothing Then
            For Each fila As Salidas_DetalleBrl In objListSalidas_Detalle
                fila.Id_Salida = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListEntradas Is Nothing Then
            For Each fila As EntradasBrl In objListEntradas
                fila.Id_Salida_Traslado = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListSalidas_Aprobaciones Is Nothing Then
            For Each fila As Salidas_AprobacionesBrl In objListSalidas_Aprobaciones
                fila.Id_Salida = Me.ID
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
            totalHijos += Salidas_Detalle.Count
            totalHijos += Entradas.Count

            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            SalidasDAL.Eliminar(Me.ID)
            RaiseEvent Deleted()

        End If
    End Sub

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As SalidasBrl

        Dim objSalidas As New SalidasBrl
        With objSalidas
            .ID = fila("Id")
            .Id_Tipo_Salida = isDBNullToNothing(fila("Id_Tipo_Salida"))
            .Numero = isDBNullToNothing(fila("Numero"))
            .Fecha = isDBNullToNothing(fila("Fecha"))
            .Nombre_Entrega = isDBNullToNothing(fila("Nombre_Entrega"))
            .Nombre_Salida = isDBNullToNothing(fila("Nombre_Salida"))
            .Id_Regional = isDBNullToNothing(fila("Id_Regional"))
            .Id_Bodega = isDBNullToNothing(fila("Id_Bodega"))
            .Id_Tercero = isDBNullToNothing(fila("Id_Tercero"))
            .Id_Reg_Grupo = isDBNullToNothing(fila("Id_Reg_Grupo"))
            .Id_Tipo_Entrega = isDBNullToNothing(fila("Id_Tipo_Entrega"))
            .Dias_Entrega = isDBNullToNothing(fila("Dias_Entrega"))
            .Observacion = isDBNullToNothing(fila("Observacion"))
            .Fecha_Creacion = isDBNullToNothing(fila("Fecha_Creacion"))
            .Id_Usuario_Creacion = isDBNullToNothing(fila("Id_Usuario_Creacion"))
            .Fecha_Modificacion = isDBNullToNothing(fila("Fecha_Modificacion"))
            .Id_Usuario_Modificacion = isDBNullToNothing(fila("Id_Usuario_Modificacion"))
            .Tipo = isDBNullToNothing(fila("Tipo"))
            .Legalizado = isDBNullToNothing(fila("Legalizado"))
            .Fecha_Cierre = isDBNullToNothing(fila("Fecha_Cierre"))
            .Cierre = isDBNullToNothing(fila("Cierre"))
            .Id_Programa = isDBNullToNothing(fila("Id_Programa"))
        End With

        Return objSalidas

    End Function

    Public Shared Event LoadingSalidasList(ByVal LoadType As String)
    Public Shared Event LoadedSalidasList(ByVal target As List(Of SalidasBrl), ByVal LoadType As String)

    Public Shared Function CargarTodos() As List(Of SalidasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SalidasBrl)
        RaiseEvent LoadingSalidasList("CargarTodos")
        dsDatos = SalidasDAL.CargarTodos()
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedSalidasList(lista, "CargarTodos")
        Return lista

    End Function

    Public Shared Event CargandoPorId(ByVal id As Int32)
    Public Shared Event CargadoPorId(ByVal target As SalidasBrl)

    Public Shared Function CargarPorID(ByVal ID As Int32) As SalidasBrl

        Dim dsDatos As System.Data.DataSet
        Dim objSalidas As SalidasBrl = Nothing
        dsDatos = SalidasDAL.CargarPorID(ID)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objSalidas = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objSalidas

    End Function

    Public Shared Function CargarPorId_Tercero(ByVal Id_Tercero As Int32) As List(Of SalidasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SalidasBrl)
        dsDatos = SalidasDAL.CargarPorId_Tercero(Id_Tercero)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function

    Public Shared Function CargarPorId_Grupo(ByVal Id_Reg_Grupo As Int32) As List(Of SalidasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SalidasBrl)

        RaiseEvent LoadingSalidasList("CargarPorId_Reg_Grupo")

        dsDatos = SalidasDAL.CargarPorId_Grupo(Id_Reg_Grupo)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSalidasList(lista, "CargarPorId_Reg_Grupo")

        Return lista

    End Function

    Public Shared Function CargarPorId_Tipo_Entrega(ByVal Id_Tipo_Entrega As Int32) As List(Of SalidasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SalidasBrl)

        RaiseEvent LoadingSalidasList("CargarPorId_Tipo_Entrega")
        dsDatos = SalidasDAL.CargarPorId_Tipo_Entrega(Id_Tipo_Entrega)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedSalidasList(lista, "CargarPorId_Tipo_Entrega")
        Return lista

    End Function

    Public Shared Function CargarPorId_Tipo_Salida(ByVal Id_Tipo_Salida As Int32) As List(Of SalidasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SalidasBrl)

        RaiseEvent LoadingSalidasList("CargarPorId_Tipo_Salida")
        dsDatos = SalidasDAL.CargarPorId_Tipo_Salida(Id_Tipo_Salida)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedSalidasList(lista, "CargarPorId_Tipo_Salida")
        Return lista

    End Function

    Public Shared Function CargarPorId_Regional(ByVal Id_Regional As Int32) As List(Of SalidasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SalidasBrl)

        RaiseEvent LoadingSalidasList("CargarPorId_Regional")

        dsDatos = SalidasDAL.CargarPorId_Regional(Id_Regional)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSalidasList(lista, "CargarPorId_Regional")

        Return lista

    End Function

    Public Shared Function CargarPorId_Bodega(ByVal Id_Bodega As Int32) As List(Of SalidasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SalidasBrl)

        RaiseEvent LoadingSalidasList("CargarPorId_Bodega")

        dsDatos = SalidasDAL.CargarPorId_Bodega(Id_Bodega)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSalidasList(lista, "CargarPorId_Bodega")

        Return lista

    End Function

    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As Int32) As List(Of SalidasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SalidasBrl)

        RaiseEvent LoadingSalidasList("CargarPorId_Usuario_Creacion")

        dsDatos = SalidasDAL.CargarPorId_Usuario_Creacion(Id_Usuario_Creacion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSalidasList(lista, "CargarPorId_Usuario_Creacion")

        Return lista

    End Function

    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As Int32) As List(Of SalidasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SalidasBrl)

        RaiseEvent LoadingSalidasList("CargarPorId_Usuario_Modificacion")

        dsDatos = SalidasDAL.CargarPorId_Usuario_Modificacion(Id_Usuario_Modificacion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedSalidasList(lista, "CargarPorId_Usuario_Modificacion")

        Return lista

    End Function

    Public Shared Function CargarPorAprobacion_Logistica_Oficina(ByVal Id_Bodega As Int32, ByVal Id_Regional As Int32, ByVal numero As String, ByVal Fecha_Inicial As String, ByVal Fecha_Final As String) As List(Of SalidasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SalidasBrl)
        RaiseEvent LoadingSalidasList("CargarPorAprobacion_Logistica_Oficina")
        dsDatos = SalidasDAL.CargarPorAprobacion_Logistica_Oficina(Id_Bodega, Id_Regional, numero, Fecha_Inicial, Fecha_Final)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedSalidasList(lista, "CargarPorAprobacion_Logistica_Oficina")
        Return lista
    End Function

    Public Shared Function CargarPorAprobacion_Finanzas_Oficina(ByVal Id_Bodega As Int32, ByVal Id_Regional As Int32, ByVal numero As String, ByVal Fecha_Inicial As String, ByVal Fecha_Final As String) As List(Of SalidasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SalidasBrl)
        RaiseEvent LoadingSalidasList("CargarPorAprobacion_Finanzas_Oficina")
        dsDatos = SalidasDAL.CargarPorAprobacion_Finanzas_Oficina(Id_Bodega, Id_Regional, numero, Fecha_Inicial, Fecha_Final)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedSalidasList(lista, "CargarPorAprobacion_Finanzas_Oficina")
        Return lista
    End Function

    Public Shared Function CargarPorAprobacion_Coordinador_Oficina(ByVal Id_Bodega As Int32, ByVal Id_Regional As Int32, ByVal numero As String, ByVal Fecha_Inicial As String, ByVal Fecha_Final As String) As List(Of SalidasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SalidasBrl)
        RaiseEvent LoadingSalidasList("CargarPorAprobacion_Coordinador_Oficina")
        dsDatos = SalidasDAL.CargarPorAprobacion_Coordinador_Oficina(Id_Bodega, Id_Regional, numero, Fecha_Inicial, Fecha_Final)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedSalidasList(lista, "CargarPorAprobacion_Coordinador_Oficina")
        Return lista
    End Function

    Public Shared Function CargarPorAprobacion_Coordinador_Logistica(ByVal Id_Bodega As Int32, ByVal Id_Regional As Int32, ByVal numero As String, ByVal Fecha_Inicial As String, ByVal Fecha_Final As String) As List(Of SalidasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SalidasBrl)
        RaiseEvent LoadingSalidasList("CargarPorAprobacion_Coordinador_Logistica")
        dsDatos = SalidasDAL.CargarPorAprobacion_Coordinador_Logistica(Id_Bodega, Id_Regional, numero, Fecha_Inicial, Fecha_Final)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedSalidasList(lista, "CargarPorAprobacion_Coordinador_Logistica")
        Return lista
    End Function

    Public Shared Function CargarPorAprobacion_Director_Financiero(ByVal Id_Bodega As Int32, ByVal Id_Regional As Int32, ByVal numero As String, ByVal Fecha_Inicial As String, ByVal Fecha_Final As String) As List(Of SalidasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SalidasBrl)
        RaiseEvent LoadingSalidasList("CargarPorAprobacion_Director_Financiero")
        dsDatos = SalidasDAL.CargarPorAprobacion_Director_Financiero(Id_Bodega, Id_Regional, numero, Fecha_Inicial, Fecha_Final)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedSalidasList(lista, "CargarPorAprobacion_Director_Financiero")
        Return lista
    End Function

    Public Shared Function CargarPorAprobacion_Director_Pais(ByVal Id_Bodega As Int32, ByVal Id_Regional As Int32, ByVal numero As String, ByVal Fecha_Inicial As String, ByVal Fecha_Final As String) As List(Of SalidasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SalidasBrl)
        RaiseEvent LoadingSalidasList("CargarPorAprobacion_Director_Pais")
        dsDatos = SalidasDAL.CargarPorAprobacion_Director_Pais(Id_Bodega, Id_Regional, numero, Fecha_Inicial, Fecha_Final)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedSalidasList(lista, "CargarPorAprobacion_Director_Pais")
        Return lista
    End Function

    Public Shared Function CargarPorBusqueda(ByVal Id_Regional As Int32, ByVal id_bodega As Int32, ByVal id_producto As Int32, ByVal fecha_inicial As String, ByVal fecha_final As String, ByVal numero As String, ByVal Id_Tipo_Salida As Int32) As List(Of SalidasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SalidasBrl)
        dsDatos = SalidasDAL.CargarPorBusqueda(Id_Regional, id_bodega, id_producto, fecha_inicial, fecha_final, numero, Id_Tipo_Salida)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_Programa(ByVal Id_Programa As Int32) As List(Of SalidasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of SalidasBrl)
        dsDatos = SalidasDAL.CargarPorId_Programa(Id_Programa)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function


End Class


