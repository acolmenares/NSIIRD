Imports ingNovar.Utilidades2
Imports System.Data
Imports System.Collections.Generic
Imports SeguridadUsuarios

Partial Public Class Tmp_InventariosBrl

    Private _Id As Int32
    Private _Id_Usuario As Int32
    Private _Id_Regional As Int32
    Private _Id_Bodega As Int32
    Private _Id_Producto As Int32
    Private _Inventario_Inicial As Double
    Private _Antes As Double
    Private _Compras As Double
    Private _Devoluciones As Double
    Private _Donaciones As Double
    Private _Traslados_Entradas As Double
    Private _Ajustes_Entradas_Aprobadas As Double
    Private _Ajustes_Entradas_NoAprobadas As Double
    Private _Salidas_Automaticas As Double
    Private _Salidas_Manuales As Double
    Private _Devoluciones_Proveedor As Double
    Private _Traslados_Salidas As Double
    Private _Salidas_Donaciones As Double
    Private _Ajustes_Sin_Aprobar As Double
    Private _Ajustes_Aprobados As Double
    Private _Entradas_Devoluciones As Double


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

    Public Event Id_UsuarioChanging(ByVal Value As Int32)
    Public Event Id_UsuarioChanged()

    Public Property Id_Usuario() As Int32
        Get
            Return Me._Id_Usuario
        End Get
        Set(ByVal Value As Int32)
            If _Id_Usuario <> Value Then
                RaiseEvent Id_UsuarioChanging(Value)
                Me._Id_Usuario = Value
                RaiseEvent Id_UsuarioChanged()
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

    Public Event Id_ProductoChanging(ByVal Value As Int32)
    Public Event Id_ProductoChanged()

    Public Property Id_Producto() As Int32
        Get
            Return Me._Id_Producto
        End Get
        Set(ByVal Value As Int32)
            If _Id_Producto <> Value Then
                RaiseEvent Id_ProductoChanging(Value)
                Me._Id_Producto = Value
                RaiseEvent Id_ProductoChanged()
            End If
        End Set
    End Property

    Public Event Inventario_InicialChanging(ByVal Value As Double)
    Public Event Inventario_InicialChanged()

    Public Property Inventario_Inicial() As Double
        Get
            Return Me._Inventario_Inicial
        End Get
        Set(ByVal Value As Double)
            If _Inventario_Inicial <> Value Then
                RaiseEvent Inventario_InicialChanging(Value)
                Me._Inventario_Inicial = Value
                RaiseEvent Inventario_InicialChanged()
            End If
        End Set
    End Property

    Public Event AntesChanging(ByVal Value As Double)
    Public Event AntesChanged()

    Public Property Antes() As Double
        Get
            Return Me._Antes
        End Get
        Set(ByVal Value As Double)
            If _Antes <> Value Then
                RaiseEvent AntesChanging(Value)
                Me._Antes = Value
                RaiseEvent AntesChanged()
            End If
        End Set
    End Property

    Public Event ComprasChanging(ByVal Value As Double)
    Public Event ComprasChanged()

    Public Property Compras() As Double
        Get
            Return Me._Compras
        End Get
        Set(ByVal Value As Double)
            If _Compras <> Value Then
                RaiseEvent ComprasChanging(Value)
                Me._Compras = Value
                RaiseEvent ComprasChanged()
            End If
        End Set
    End Property

    Public Event DevolucionesChanging(ByVal Value As Double)
    Public Event DevolucionesChanged()

    Public Property Devoluciones() As Double
        Get
            Return Me._Devoluciones
        End Get
        Set(ByVal Value As Double)
            If _Devoluciones <> Value Then
                RaiseEvent DevolucionesChanging(Value)
                Me._Devoluciones = Value
                RaiseEvent DevolucionesChanged()
            End If
        End Set
    End Property

    Public Event DonacionesChanging(ByVal Value As Double)
    Public Event DonacionesChanged()

    Public Property Donaciones() As Double
        Get
            Return Me._Donaciones
        End Get
        Set(ByVal Value As Double)
            If _Donaciones <> Value Then
                RaiseEvent DonacionesChanging(Value)
                Me._Donaciones = Value
                RaiseEvent DonacionesChanged()
            End If
        End Set
    End Property

    Public Event Traslados_EntradasChanging(ByVal Value As Double)
    Public Event Traslados_EntradasChanged()

    Public Property Traslados_Entradas() As Double
        Get
            Return Me._Traslados_Entradas
        End Get
        Set(ByVal Value As Double)
            If _Traslados_Entradas <> Value Then
                RaiseEvent Traslados_EntradasChanging(Value)
                Me._Traslados_Entradas = Value
                RaiseEvent Traslados_EntradasChanged()
            End If
        End Set
    End Property

    Public Event Ajustes_EntradasChanging(ByVal Value As Double)
    Public Event Ajustes_EntradasChanged()

    Public Property Ajustes_Entradas_Aprobadas() As Double
        Get
            Return Me._Ajustes_Entradas_Aprobadas
        End Get
        Set(ByVal Value As Double)
            If _Ajustes_Entradas_Aprobadas <> Value Then
                RaiseEvent Ajustes_EntradasChanging(Value)
                Me._Ajustes_Entradas_Aprobadas = Value
                RaiseEvent Ajustes_EntradasChanged()
            End If
        End Set
    End Property

    Public Property Ajustes_Entradas_NoAprobadas() As Double
        Get
            Return Me._Ajustes_Entradas_NoAprobadas
        End Get
        Set(ByVal Value As Double)
            If _Ajustes_Entradas_NoAprobadas <> Value Then
                RaiseEvent Ajustes_EntradasChanging(Value)
                Me._Ajustes_Entradas_NoAprobadas = Value
                RaiseEvent Ajustes_EntradasChanged()
            End If
        End Set
    End Property

    Public Event Salidas_AutomaticasChanging(ByVal Value As Double)
    Public Event Salidas_AutomaticasChanged()

    Public Property Salidas_Automaticas() As Double
        Get
            Return Me._Salidas_Automaticas
        End Get
        Set(ByVal Value As Double)
            If _Salidas_Automaticas <> Value Then
                RaiseEvent Salidas_AutomaticasChanging(Value)
                Me._Salidas_Automaticas = Value
                RaiseEvent Salidas_AutomaticasChanged()
            End If
        End Set
    End Property

    Public Event Salidas_ManualesChanging(ByVal Value As Double)
    Public Event Salidas_ManualesChanged()

    Public Property Salidas_Manuales() As Double
        Get
            Return Me._Salidas_Manuales
        End Get
        Set(ByVal Value As Double)
            If _Salidas_Manuales <> Value Then
                RaiseEvent Salidas_ManualesChanging(Value)
                Me._Salidas_Manuales = Value
                RaiseEvent Salidas_ManualesChanged()
            End If
        End Set
    End Property

    Public Event Devoluciones_ProveedorChanging(ByVal Value As Double)
    Public Event Devoluciones_ProveedorChanged()

    Public Property Devoluciones_Proveedor() As Double
        Get
            Return Me._Devoluciones_Proveedor
        End Get
        Set(ByVal Value As Double)
            If _Devoluciones_Proveedor <> Value Then
                RaiseEvent Devoluciones_ProveedorChanging(Value)
                Me._Devoluciones_Proveedor = Value
                RaiseEvent Devoluciones_ProveedorChanged()
            End If
        End Set
    End Property

    Public Event Traslados_SalidasChanging(ByVal Value As Double)
    Public Event Traslados_SalidasChanged()

    Public Property Traslados_Salidas() As Double
        Get
            Return Me._Traslados_Salidas
        End Get
        Set(ByVal Value As Double)
            If _Traslados_Salidas <> Value Then
                RaiseEvent Traslados_SalidasChanging(Value)
                Me._Traslados_Salidas = Value
                RaiseEvent Traslados_SalidasChanged()
            End If
        End Set
    End Property

    Public Event Ajustes_Sin_AprobarChanging(ByVal Value As Double)
    Public Event Ajustes_Sin_AprobarChanged()

    Public Property Ajustes_Sin_Aprobar() As Double
        Get
            Return Me._Ajustes_Sin_Aprobar
        End Get
        Set(ByVal Value As Double)
            If _Ajustes_Sin_Aprobar <> Value Then
                RaiseEvent Ajustes_Sin_AprobarChanging(Value)
                Me._Ajustes_Sin_Aprobar = Value
                RaiseEvent Ajustes_Sin_AprobarChanged()
            End If
        End Set
    End Property

    Public Event Ajustes_AprobadosChanging(ByVal Value As Double)
    Public Event Ajustes_AprobadosChanged()

    Public Property Ajustes_Aprobados() As Double
        Get
            Return Me._Ajustes_Aprobados
        End Get
        Set(ByVal Value As Double)
            If _Ajustes_Aprobados <> Value Then
                RaiseEvent Ajustes_AprobadosChanging(Value)
                Me._Ajustes_Aprobados = Value
                RaiseEvent Ajustes_AprobadosChanged()
            End If
        End Set
    End Property

    Public Event Salidas_DonacionesChanging(ByVal Value As Double)
    Public Event Salidas_DonacionesChanged()

    Public Property Salidas_Donaciones() As Double
        Get
            Return Me._Salidas_Donaciones
        End Get
        Set(ByVal Value As Double)
            If _Salidas_Donaciones <> Value Then
                RaiseEvent Salidas_DonacionesChanging(Value)
                Me._Salidas_Donaciones = Value
                RaiseEvent Salidas_DonacionesChanged()
            End If
        End Set
    End Property

    Public Event Entradas_DevolucionesChanging(ByVal Value As Double)
    Public Event Entradas_DevolucionesChanged()

    Public Property Entradas_Devoluciones() As Double
        Get
            Return Me._Entradas_Devoluciones
        End Get
        Set(ByVal Value As Double)
            If _Entradas_Devoluciones <> Value Then
                RaiseEvent Entradas_DevolucionesChanging(Value)
                Me._Entradas_Devoluciones = Value
                RaiseEvent Entradas_DevolucionesChanged()
            End If
        End Set
    End Property

    Public ReadOnly Property Usuarios() As UsuariosBrl
        Get
            Return UsuariosBrl.CargarPorID(Id_Usuario)
        End Get
    End Property

    Public ReadOnly Property Bodega() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Bodega)
        End Get
    End Property

    Public ReadOnly Property Producto() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Producto)
        End Get
    End Property

    Public ReadOnly Property Regional() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Regional)
        End Get
    End Property

    Public ReadOnly Property Ingresos() As Double
        Get
            Return Inventario_Inicial + Compras + Devoluciones + Traslados_Entradas + Donaciones + Ajustes_Entradas_Aprobadas + Ajustes_Entradas_NoAprobadas + Entradas_Devoluciones
        End Get
    End Property

    Public ReadOnly Property Salidas() As Double
        Get
            Return Salidas_Automaticas + Salidas_Manuales + Traslados_Salidas + Devoluciones_Proveedor + Ajustes_Aprobados + Ajustes_Sin_Aprobar + Salidas_Donaciones
        End Get
    End Property

    Public ReadOnly Property GranTotal() As Double
        Get
            Return Antes + Ingresos - Salidas
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

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Tmp_InventariosBrl

        Dim objTmp_Inventarios As New Tmp_InventariosBrl

        With objTmp_Inventarios
            .ID = fila("Id")
            .Id_Usuario = isDBNullToNothing(fila("Id_Usuario"))
            .Id_Regional = isDBNullToNothing(fila("Id_Regional"))
            .Id_Bodega = isDBNullToNothing(fila("Id_Bodega"))
            .Id_Producto = isDBNullToNothing(fila("Id_Producto"))
            .Inventario_Inicial = isDBNullToNothing(fila("Inventario_Inicial"))
            .Antes = isDBNullToNothing(fila("Antes"))
            .Compras = isDBNullToNothing(fila("Compras"))
            .Devoluciones = isDBNullToNothing(fila("Devoluciones"))
            .Donaciones = isDBNullToNothing(fila("Donaciones"))
            .Traslados_Entradas = isDBNullToNothing(fila("Traslados_Entradas"))
            .Ajustes_Entradas_Aprobadas = isDBNullToNothing(fila("Ajustes_Entradas_Aprobadas"))
            .Ajustes_Entradas_NoAprobadas = isDBNullToNothing(fila("Ajustes_Entradas_NoAprobadas"))
            .Salidas_Automaticas = isDBNullToNothing(fila("Salidas_Automaticas"))
            .Salidas_Manuales = isDBNullToNothing(fila("Salidas_Manuales"))
            .Devoluciones_Proveedor = isDBNullToNothing(fila("Devoluciones_Proveedor"))
            .Traslados_Salidas = isDBNullToNothing(fila("Traslados_Salidas"))
            .Ajustes_Sin_Aprobar = isDBNullToNothing(fila("Ajustes_Sin_Aprobar"))
            .Ajustes_Aprobados = isDBNullToNothing(fila("Ajustes_Aprobados"))
            .Salidas_Donaciones = isDBNullToNothing(fila("Salidas_Donaciones"))
            .Entradas_Devoluciones = isDBNullToNothing(fila("Entradas_Devoluciones"))

        End With

        Return objTmp_Inventarios

    End Function

    Public Shared Event LoadingTmp_InventariosList(ByVal LoadType As String)
    Public Shared Event LoadedTmp_InventariosList(ByVal target As List(Of Tmp_InventariosBrl), ByVal LoadType As String)

    Public Shared Function CargarTodos() As List(Of Tmp_InventariosBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Tmp_InventariosBrl)

        RaiseEvent LoadingTmp_InventariosList("CargarTodos")

        dsDatos = Tmp_InventariosDAL.CargarTodos()

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedTmp_InventariosList(lista, "CargarTodos")

        Return lista

    End Function

    Public Shared Event LoadingPorId(ByVal id As Int32)
    Public Shared Event LoadedPorId(ByVal target As Tmp_InventariosBrl)

    Public Shared Function CargarPorID(ByVal ID As Int32) As Tmp_InventariosBrl

        Dim dsDatos As System.Data.DataSet
        Dim objTmp_Inventarios As Tmp_InventariosBrl = Nothing

        dsDatos = Tmp_InventariosDAL.CargarPorID(ID)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objTmp_Inventarios = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objTmp_Inventarios

    End Function

    Public Shared Function CargarPorId_Usuario(ByVal Id_Usuario As Int32) As List(Of Tmp_InventariosBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Tmp_InventariosBrl)

        RaiseEvent LoadingTmp_InventariosList("CargarPorId_Usuario")

        dsDatos = Tmp_InventariosDAL.CargarPorId_Usuario(Id_Usuario)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedTmp_InventariosList(lista, "CargarPorId_Usuario")

        Return lista

    End Function



    Public Shared Function CargarPorId_Bodega(ByVal Id_Bodega As Int32) As List(Of Tmp_InventariosBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Tmp_InventariosBrl)

        RaiseEvent LoadingTmp_InventariosList("CargarPorId_Bodega")

        dsDatos = Tmp_InventariosDAL.CargarPorId_Bodega(Id_Bodega)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedTmp_InventariosList(lista, "CargarPorId_Bodega")

        Return lista

    End Function



    Public Shared Function CargarPorId_Producto(ByVal Id_Producto As Int32) As List(Of Tmp_InventariosBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Tmp_InventariosBrl)

        RaiseEvent LoadingTmp_InventariosList("CargarPorId_Producto")

        dsDatos = Tmp_InventariosDAL.CargarPorId_Producto(Id_Producto)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedTmp_InventariosList(lista, "CargarPorId_Producto")

        Return lista

    End Function



    Public Shared Function CargarPorId_Regional(ByVal Id_Regional As Int32) As List(Of Tmp_InventariosBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Tmp_InventariosBrl)

        RaiseEvent LoadingTmp_InventariosList("CargarPorId_Regional")

        dsDatos = Tmp_InventariosDAL.CargarPorId_Regional(Id_Regional)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedTmp_InventariosList(lista, "CargarPorId_Regional")

        Return lista

    End Function



End Class


