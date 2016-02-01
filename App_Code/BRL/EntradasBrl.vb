Imports ingNovar.Utilidades2
Imports System.Data
Imports system.collections.generic
Imports SeguridadUsuarios

Partial Public Class EntradasBrl

    Private _Id As Int32
    Private _Id_Tipo_Entrada As Int32
    Private _Id_Tercero As Int32
    Private _Numero_Entrada As String
    Private _Numero_Factura_Proveedor As String
    Private _Fecha As DateTime
    Private _Id_Regional As Int32
    Private _Id_Regional_Envia As Int32
    Private _Id_Usuario_Recibio As Int32
    Private _Nombre_Entrego As String
    Private _Identificacion_Entrego As String
    Private _Observacion As String
    Private _Id_Salida_Traslado As Int32
    Private _Fecha_Creacion As DateTime
    Private _Id_Usuario_Creacion As Int32
    Private _Fecha_Modificacion As DateTime
    Private _Id_Usuario_Modificacion As Int32
    Private _Fecha_Cierre As DateTime
    Private _Cierre As Boolean

    Private objListEntradas_Detalle As List(Of Entradas_DetalleBrl)
    Private objListEntradas_Impuestos As List(Of Entradas_ImpuestosBrl)


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

    Public Event Id_Tipo_EntradaChanging(ByVal Value As Int32)
    Public Event Id_Tipo_EntradaChanged()

    Public Property Id_Tipo_Entrada() As Int32
        Get
            Return Me._Id_Tipo_Entrada
        End Get
        Set(ByVal Value As Int32)
            If _Id_Tipo_Entrada <> Value Then
                RaiseEvent Id_Tipo_EntradaChanging(Value)
                Me._Id_Tipo_Entrada = Value
                RaiseEvent Id_Tipo_EntradaChanged()
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

    Public Event Numero_EntradaChanging(ByVal Value As String)
    Public Event Numero_EntradaChanged()

    Public Property Numero_Entrada() As String
        Get
            Return Me._Numero_Entrada
        End Get
        Set(ByVal Value As String)
            If _Numero_Entrada <> Value Then
                RaiseEvent Numero_EntradaChanging(Value)
                Me._Numero_Entrada = Value
                RaiseEvent Numero_EntradaChanged()
            End If
        End Set
    End Property

    Public Event Numero_Factura_ProveedorChanging(ByVal Value As String)
    Public Event Numero_Factura_ProveedorChanged()

    Public Property Numero_Factura_Proveedor() As String
        Get
            Return Me._Numero_Factura_Proveedor
        End Get
        Set(ByVal Value As String)
            If _Numero_Factura_Proveedor <> Value Then
                RaiseEvent Numero_Factura_ProveedorChanging(Value)
                Me._Numero_Factura_Proveedor = Value
                RaiseEvent Numero_Factura_ProveedorChanged()
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

    Public Event Id_RegionalChanging(ByVal Value As Int32)
    Public Event Id_RegionalChanged()

    Public Property Id_Regional() As Int32
        Get
            Return Me._Id_Regional
        End Get
        Set(ByVal Value As Int32)
            If _Id_Regional <> Value Then
                RaiseEvent Id_RegionalChanging(Value)
                Me._Id_Regional = Value
                RaiseEvent Id_RegionalChanged()
            End If
        End Set
    End Property

    Public Event Id_Regional_EnviaChanging(ByVal Value As Int32)
    Public Event Id_Regional_EnviaChanged()

    Public Property Id_Regional_Envia() As Int32
        Get
            Return Me._Id_Regional_envia
        End Get
        Set(ByVal Value As Int32)
            If _Id_Regional_envia <> Value Then
                RaiseEvent Id_Regional_EnviaChanging(Value)
                Me._Id_Regional_envia = Value
                RaiseEvent Id_Regional_EnviaChanged()
            End If
        End Set
    End Property

    Public Event Id_Usuario_RecibioChanging(ByVal Value As Int32)
    Public Event Id_Usuario_RecibioChanged()

    Public Property Id_Usuario_Recibio() As Int32
        Get
            Return Me._Id_Usuario_Recibio
        End Get
        Set(ByVal Value As Int32)
            If _Id_Usuario_Recibio <> Value Then
                RaiseEvent Id_Usuario_RecibioChanging(Value)
                Me._Id_Usuario_Recibio = Value
                RaiseEvent Id_Usuario_RecibioChanged()
            End If
        End Set
    End Property

    Public Event Nombre_EntregoChanging(ByVal Value As String)
    Public Event Nombre_EntregoChanged()

    Public Property Nombre_Entrego() As String
        Get
            Return Me._Nombre_Entrego
        End Get
        Set(ByVal Value As String)
            If _Nombre_Entrego <> Value Then
                RaiseEvent Nombre_EntregoChanging(Value)
                Me._Nombre_Entrego = Value
                RaiseEvent Nombre_EntregoChanged()
            End If
        End Set
    End Property

    Public Event Identificacion_EntregoChanging(ByVal Value As String)
    Public Event Identificacion_EntregoChanged()

    Public Property Identificacion_Entrego() As String
        Get
            Return Me._Identificacion_Entrego
        End Get
        Set(ByVal Value As String)
            If _Identificacion_Entrego <> Value Then
                RaiseEvent Identificacion_EntregoChanging(Value)
                Me._Identificacion_Entrego = Value
                RaiseEvent Identificacion_EntregoChanged()
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

    Public Event Id_Salida_TrasladoChanging(ByVal Value As Int32)
    Public Event Id_Salida_TrasladoChanged()

    Public Property Id_Salida_Traslado() As Int32
        Get
            Return Me._Id_Salida_Traslado
        End Get
        Set(ByVal Value As Int32)
            If _Id_Salida_Traslado <> Value Then
                RaiseEvent Id_Salida_TrasladoChanging(Value)
                Me._Id_Salida_Traslado = Value
                RaiseEvent Id_Salida_TrasladoChanged()
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

    Public Property Entradas_Detalle() As List(Of Entradas_DetalleBrl)
        Get
            If (Me.objListEntradas_Detalle Is Nothing) Then
                objListEntradas_Detalle = Entradas_DetalleBrl.CargarPorId_Entrada(Me.ID)
            End If
            Return Me.objListEntradas_Detalle
        End Get
        Set(ByVal Value As List(Of Entradas_DetalleBrl))
            Me.objListEntradas_Detalle = Value
        End Set
    End Property

    Public Property Entradas_Impuestos() As List(Of Entradas_ImpuestosBrl)
        Get
            If (Me.objListEntradas_Impuestos Is Nothing) Then
                objListEntradas_Impuestos = Entradas_ImpuestosBrl.CargarPorId_Entrada(Me.ID)
            End If
            Return Me.objListEntradas_Impuestos
        End Get
        Set(ByVal Value As List(Of Entradas_ImpuestosBrl))
            Me.objListEntradas_Impuestos = Value
        End Set
    End Property

    Public ReadOnly Property Proveedores() As Ppto_TercerosBrl
        Get
            Return Ppto_TercerosBrl.CargarPorID(Id_Tercero)
        End Get
    End Property

    Public ReadOnly Property UsuarioRecibio() As UsuariosBrl
        Get
            Return UsuariosBrl.CargarPorID(Id_Usuario_Recibio)
        End Get
    End Property

    Public ReadOnly Property Regional() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Regional)
        End Get
    End Property

    Public ReadOnly Property RegionalEnvia() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Regional_Envia)
        End Get
    End Property

    Public ReadOnly Property TipoEntrada() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Tipo_Entrada)
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

    Public ReadOnly Property Salida_Traslado() As SalidasBrl
        Get
            Return SalidasBrl.CargarPorID(Id_Salida_Traslado)
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
            Me.ID = EntradasDAL.Insertar(Id_Tipo_Entrada, Id_Tercero, Numero_Entrada, Numero_Factura_Proveedor, Fecha, Id_Regional, Id_Regional_Envia, Id_Usuario_Recibio, Nombre_Entrego, Identificacion_Entrego, Observacion, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Id_Salida_Traslado, Fecha_Cierre, Cierre)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            EntradasDAL.Actualizar(ID, Id_Tipo_Entrada, Id_Tercero, Numero_Entrada, Numero_Factura_Proveedor, Fecha, Id_Regional, Id_Regional_Envia, Id_Usuario_Recibio, Nombre_Entrego, Identificacion_Entrego, Observacion, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion, Id_Salida_Traslado, Fecha_Cierre, Cierre)
            RaiseEvent Updated()
        End If
        If Not objListEntradas_Detalle Is Nothing Then
            For Each fila As Entradas_DetalleBrl In objListEntradas_Detalle
                fila.Id_Entrada = Me.ID
                Try
                    fila.Guardar()
                Catch ex As Exception

                End Try
            Next
        End If

        If Not objListEntradas_Impuestos Is Nothing Then
            For Each fila As Entradas_ImpuestosBrl In objListEntradas_Impuestos
                fila.Id_Entrada = Me.ID
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
            totalHijos += Entradas_Detalle.Count
            totalHijos += Entradas_Impuestos.Count

            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            EntradasDAL.Eliminar(Me.ID)

            RaiseEvent Deleted()

        End If
    End Sub

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As EntradasBrl

        Dim objEntradas As New EntradasBrl

        With objEntradas
            .ID = fila("Id")
            .Id_Tipo_Entrada = isDBNullToNothing(fila("Id_Tipo_Entrada"))
            .Id_Tercero = isDBNullToNothing(fila("Id_Tercero"))
            .Numero_Entrada = isDBNullToNothing(fila("Numero_Entrada"))
            .Numero_Factura_Proveedor = isDBNullToNothing(fila("Numero_Factura_Proveedor"))
            .Fecha = isDBNullToNothing(fila("Fecha"))
            .Id_Regional = isDBNullToNothing(fila("Id_Regional"))
            .Id_Regional_Envia = isDBNullToNothing(fila("Id_Regional_envia"))
            .Id_Usuario_Recibio = isDBNullToNothing(fila("Id_Usuario_Recibio"))
            .Nombre_Entrego = isDBNullToNothing(fila("Nombre_Entrego"))
            .Identificacion_Entrego = isDBNullToNothing(fila("Identificacion_Entrego"))
            .Observacion = isDBNullToNothing(fila("Observacion"))
            .Fecha_Creacion = isDBNullToNothing(fila("Fecha_Creacion"))
            .Id_Usuario_Creacion = isDBNullToNothing(fila("Id_Usuario_Creacion"))
            .Fecha_Modificacion = isDBNullToNothing(fila("Fecha_Modificacion"))
            .Id_Usuario_Modificacion = isDBNullToNothing(fila("Id_Usuario_Modificacion"))
            .Id_Salida_Traslado = isDBNullToNothing(fila("Id_Salida_Traslado"))
            .Fecha_Cierre = isDBNullToNothing(fila("Fecha_Cierre"))
            .Cierre = isDBNullToNothing(fila("Cierre"))
        End With

        Return objEntradas

    End Function

    Public Shared Event LoadingEntradasList(ByVal LoadType As String)
    Public Shared Event LoadedEntradasList(ByVal target As List(Of EntradasBrl), ByVal LoadType As String)

    Public Shared Function CargarTodos() As List(Of EntradasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of EntradasBrl)

        RaiseEvent LoadingEntradasList("CargarTodos")

        dsDatos = EntradasDAL.CargarTodos()

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedEntradasList(lista, "CargarTodos")

        Return lista

    End Function

    Public Shared Event CargandoPorId(ByVal id As Int32)
    Public Shared Event CargadoPorId(ByVal target As EntradasBrl)

    Public Shared Function CargarPorID(ByVal ID As Int32) As EntradasBrl

        Dim dsDatos As System.Data.DataSet
        Dim objEntradas As EntradasBrl = Nothing
        dsDatos = EntradasDAL.CargarPorID(ID)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objEntradas = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objEntradas

    End Function

    Public Shared Function CargarPorId_Tercero(ByVal Id_Tercero As Int32) As List(Of EntradasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of EntradasBrl)
        dsDatos = EntradasDAL.CargarPorId_Tercero(Id_Tercero)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function

    Public Shared Function CargarPorId_Usuario_Recibio(ByVal Id_Usuario_Recibio As Int32) As List(Of EntradasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of EntradasBrl)

        RaiseEvent LoadingEntradasList("CargarPorId_Usuario_Recibio")

        dsDatos = EntradasDAL.CargarPorId_Usuario_Recibio(Id_Usuario_Recibio)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedEntradasList(lista, "CargarPorId_Usuario_Recibio")

        Return lista

    End Function

    Public Shared Function CargarPorId_Regional(ByVal Id_Regional As Int32) As List(Of EntradasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of EntradasBrl)

        RaiseEvent LoadingEntradasList("CargarPorId_Regional")

        dsDatos = EntradasDAL.CargarPorId_Regional(Id_Regional)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedEntradasList(lista, "CargarPorId_Regional")

        Return lista

    End Function

    Public Shared Function CargarPorId_Tipo_Entrada(ByVal Id_Tipo_Entrada As Int32) As List(Of EntradasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of EntradasBrl)

        RaiseEvent LoadingEntradasList("CargarPorId_Tipo_Entrada")

        dsDatos = EntradasDAL.CargarPorId_Tipo_Entrada(Id_Tipo_Entrada)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedEntradasList(lista, "CargarPorId_Tipo_Entrada")

        Return lista

    End Function

    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As Int32) As List(Of EntradasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of EntradasBrl)

        RaiseEvent LoadingEntradasList("CargarPorId_Usuario_Creacion")

        dsDatos = EntradasDAL.CargarPorId_Usuario_Creacion(Id_Usuario_Creacion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedEntradasList(lista, "CargarPorId_Usuario_Creacion")

        Return lista

    End Function

    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As Int32) As List(Of EntradasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of EntradasBrl)

        RaiseEvent LoadingEntradasList("CargarPorId_Usuario_Modificacion")

        dsDatos = EntradasDAL.CargarPorId_Usuario_Modificacion(Id_Usuario_Modificacion)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedEntradasList(lista, "CargarPorId_Usuario_Modificacion")

        Return lista

    End Function

    Public Shared Function CargarPorId_Salida_Traslado(ByVal Id_Salida_Traslado As Int32) As List(Of EntradasBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of EntradasBrl)

        RaiseEvent LoadingEntradasList("CargarPorId_Salida_Traslado")

        dsDatos = EntradasDAL.CargarPorId_Salida_Traslado(Id_Salida_Traslado)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedEntradasList(lista, "CargarPorId_Salida_Traslado")

        Return lista

    End Function


    Public Shared Function CargarPorBusqueda(ByVal Id_Regional As Int32, ByVal id_bodega As Int32, ByVal id_producto As Int32, ByVal fecha_inicial As String, ByVal fecha_final As String, ByVal numero As String, ByVal Id_Tipo_Entrada As Int32) As List(Of EntradasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of EntradasBrl)
        dsDatos = EntradasDAL.CargarPorBusqueda(Id_Regional, id_bodega, id_producto, fecha_inicial, fecha_final, numero, Id_Tipo_Entrada)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

End Class


