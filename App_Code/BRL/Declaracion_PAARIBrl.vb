Imports ingNovar.Utilidades2
imports system.data
Imports System.Collections.Generic
Imports SeguridadUsuarios


Partial Public Class Declaracion_PAARIBrl

    Private _Id As Int32
    Private _Id_Declaracion As Int32
    Private _Id_Tipo_Entrega As Int32
    Private _Id_Alimentacion_Consumo As Int32
    Private _Id_Alimentacion_Raices As Int32
    Private _Id_Alimentacion_Verduras As Int32
    Private _Id_Alimentacion_Frutas As Int32
    Private _Id_Alimentacion_Carnes As Int32
    Private _Id_Alimentacion_Huevos As Int32
    Private _Id_Alimentacion_Leguminosas As Int32
    Private _Id_Alimentacion_Lacteos As Int32
    Private _Id_Alimentacion_Grasas As Int32
    Private _Id_Alimentacion_Azucares As Int32
    Private _Id_Alimentacion_Harinas As Int32
    Private _Id_Alimentacion_Enbutidos As Int32
    Private _Id_Alimentacion_Enlatados As Int32
    Private _Id_Alimentacion_Gaseosas As Int32
    Private _Id_Alimentacion_Agua As Int32
    Private _Id_Alimentacion_Bienestarina As Int32
    Private _Id_Alojamiento_Tipo_Vivienda As Int32
    Private _Id_Alojamiento_Tipo_Vivienda_Otro As Int32
    Private _Id_Alojamiento_Material_Pisos As Int32
    Private _Id_Alojamiento_Material_Paredes As Int32
    Private _Id_Alojamiento_Zona_Riesgo As Int32
    Private _Id_Alojamiento_Cuantos_Duermen As Int32
    Private _Id_Alojamiento_Acueducto As Int32
    Private _Id_Alojamiento_Obtiene_Agua As Int32
    Private _Id_Alojamiento_Alcantarillado As Int32
    Private _Id_Alojamiento_Servicio_Sanitario As Int32

    Private _Valor_Alimentacion As Double
    Private _Valor_Alojamiento As Double

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

    Public Event Id_Alimentacion_ConsumoChanging(ByVal Value As Int32)
    Public Event Id_Alimentacion_ConsumoChanged()
	
    Public Property Id_Alimentacion_Consumo() As Int32
        Get
            Return Me._Id_Alimentacion_Consumo
        End Get
        Set(ByVal Value As Int32)
            If _Id_Alimentacion_Consumo <> Value Then
                RaiseEvent Id_Alimentacion_ConsumoChanging(Value)
				Me._Id_Alimentacion_Consumo = Value
                RaiseEvent Id_Alimentacion_ConsumoChanged()
            End If
        End Set
    End Property

    Public Event Id_Alimentacion_RaicesChanging(ByVal Value As Int32)
    Public Event Id_Alimentacion_RaicesChanged()
	
    Public Property Id_Alimentacion_Raices() As Int32
        Get
            Return Me._Id_Alimentacion_Raices
        End Get
        Set(ByVal Value As Int32)
            If _Id_Alimentacion_Raices <> Value Then
                RaiseEvent Id_Alimentacion_RaicesChanging(Value)
				Me._Id_Alimentacion_Raices = Value
                RaiseEvent Id_Alimentacion_RaicesChanged()
            End If
        End Set
    End Property

    Public Event Id_Alimentacion_VerdurasChanging(ByVal Value As Int32)
    Public Event Id_Alimentacion_VerdurasChanged()
	
    Public Property Id_Alimentacion_Verduras() As Int32
        Get
            Return Me._Id_Alimentacion_Verduras
        End Get
        Set(ByVal Value As Int32)
            If _Id_Alimentacion_Verduras <> Value Then
                RaiseEvent Id_Alimentacion_VerdurasChanging(Value)
				Me._Id_Alimentacion_Verduras = Value
                RaiseEvent Id_Alimentacion_VerdurasChanged()
            End If
        End Set
    End Property

    Public Event Id_Alimentacion_FrutasChanging(ByVal Value As Int32)
    Public Event Id_Alimentacion_FrutasChanged()
	
    Public Property Id_Alimentacion_Frutas() As Int32
        Get
            Return Me._Id_Alimentacion_Frutas
        End Get
        Set(ByVal Value As Int32)
            If _Id_Alimentacion_Frutas <> Value Then
                RaiseEvent Id_Alimentacion_FrutasChanging(Value)
				Me._Id_Alimentacion_Frutas = Value
                RaiseEvent Id_Alimentacion_FrutasChanged()
            End If
        End Set
    End Property

    Public Event Id_Alimentacion_CarnesChanging(ByVal Value As Int32)
    Public Event Id_Alimentacion_CarnesChanged()
	
    Public Property Id_Alimentacion_Carnes() As Int32
        Get
            Return Me._Id_Alimentacion_Carnes
        End Get
        Set(ByVal Value As Int32)
            If _Id_Alimentacion_Carnes <> Value Then
                RaiseEvent Id_Alimentacion_CarnesChanging(Value)
				Me._Id_Alimentacion_Carnes = Value
                RaiseEvent Id_Alimentacion_CarnesChanged()
            End If
        End Set
    End Property

    Public Event Id_Alimentacion_HuevosChanging(ByVal Value As Int32)
    Public Event Id_Alimentacion_HuevosChanged()
	
    Public Property Id_Alimentacion_Huevos() As Int32
        Get
            Return Me._Id_Alimentacion_Huevos
        End Get
        Set(ByVal Value As Int32)
            If _Id_Alimentacion_Huevos <> Value Then
                RaiseEvent Id_Alimentacion_HuevosChanging(Value)
				Me._Id_Alimentacion_Huevos = Value
                RaiseEvent Id_Alimentacion_HuevosChanged()
            End If
        End Set
    End Property

    Public Event Id_Alimentacion_LeguminosasChanging(ByVal Value As Int32)
    Public Event Id_Alimentacion_LeguminosasChanged()
	
    Public Property Id_Alimentacion_Leguminosas() As Int32
        Get
            Return Me._Id_Alimentacion_Leguminosas
        End Get
        Set(ByVal Value As Int32)
            If _Id_Alimentacion_Leguminosas <> Value Then
                RaiseEvent Id_Alimentacion_LeguminosasChanging(Value)
				Me._Id_Alimentacion_Leguminosas = Value
                RaiseEvent Id_Alimentacion_LeguminosasChanged()
            End If
        End Set
    End Property

    Public Event Id_Alimentacion_LacteosChanging(ByVal Value As Int32)
    Public Event Id_Alimentacion_LacteosChanged()
	
    Public Property Id_Alimentacion_Lacteos() As Int32
        Get
            Return Me._Id_Alimentacion_Lacteos
        End Get
        Set(ByVal Value As Int32)
            If _Id_Alimentacion_Lacteos <> Value Then
                RaiseEvent Id_Alimentacion_LacteosChanging(Value)
				Me._Id_Alimentacion_Lacteos = Value
                RaiseEvent Id_Alimentacion_LacteosChanged()
            End If
        End Set
    End Property

    Public Event Id_Alimentacion_GrasasChanging(ByVal Value As Int32)
    Public Event Id_Alimentacion_GrasasChanged()
	
    Public Property Id_Alimentacion_Grasas() As Int32
        Get
            Return Me._Id_Alimentacion_Grasas
        End Get
        Set(ByVal Value As Int32)
            If _Id_Alimentacion_Grasas <> Value Then
                RaiseEvent Id_Alimentacion_GrasasChanging(Value)
				Me._Id_Alimentacion_Grasas = Value
                RaiseEvent Id_Alimentacion_GrasasChanged()
            End If
        End Set
    End Property

    Public Event Id_Alimentacion_AzucaresChanging(ByVal Value As Int32)
    Public Event Id_Alimentacion_AzucaresChanged()
	
    Public Property Id_Alimentacion_Azucares() As Int32
        Get
            Return Me._Id_Alimentacion_Azucares
        End Get
        Set(ByVal Value As Int32)
            If _Id_Alimentacion_Azucares <> Value Then
                RaiseEvent Id_Alimentacion_AzucaresChanging(Value)
				Me._Id_Alimentacion_Azucares = Value
                RaiseEvent Id_Alimentacion_AzucaresChanged()
            End If
        End Set
    End Property

    Public Event Id_Alimentacion_HarinasChanging(ByVal Value As Int32)
    Public Event Id_Alimentacion_HarinasChanged()
	
    Public Property Id_Alimentacion_Harinas() As Int32
        Get
            Return Me._Id_Alimentacion_Harinas
        End Get
        Set(ByVal Value As Int32)
            If _Id_Alimentacion_Harinas <> Value Then
                RaiseEvent Id_Alimentacion_HarinasChanging(Value)
				Me._Id_Alimentacion_Harinas = Value
                RaiseEvent Id_Alimentacion_HarinasChanged()
            End If
        End Set
    End Property

    Public Event Id_Alimentacion_EnbutidosChanging(ByVal Value As Int32)
    Public Event Id_Alimentacion_EnbutidosChanged()
	
    Public Property Id_Alimentacion_Enbutidos() As Int32
        Get
            Return Me._Id_Alimentacion_Enbutidos
        End Get
        Set(ByVal Value As Int32)
            If _Id_Alimentacion_Enbutidos <> Value Then
                RaiseEvent Id_Alimentacion_EnbutidosChanging(Value)
				Me._Id_Alimentacion_Enbutidos = Value
                RaiseEvent Id_Alimentacion_EnbutidosChanged()
            End If
        End Set
    End Property

    Public Event Id_Alimentacion_EnlatadosChanging(ByVal Value As Int32)
    Public Event Id_Alimentacion_EnlatadosChanged()
	
    Public Property Id_Alimentacion_Enlatados() As Int32
        Get
            Return Me._Id_Alimentacion_Enlatados
        End Get
        Set(ByVal Value As Int32)
            If _Id_Alimentacion_Enlatados <> Value Then
                RaiseEvent Id_Alimentacion_EnlatadosChanging(Value)
				Me._Id_Alimentacion_Enlatados = Value
                RaiseEvent Id_Alimentacion_EnlatadosChanged()
            End If
        End Set
    End Property

    Public Event Id_Alimentacion_GaseosasChanging(ByVal Value As Int32)
    Public Event Id_Alimentacion_GaseosasChanged()
	
    Public Property Id_Alimentacion_Gaseosas() As Int32
        Get
            Return Me._Id_Alimentacion_Gaseosas
        End Get
        Set(ByVal Value As Int32)
            If _Id_Alimentacion_Gaseosas <> Value Then
                RaiseEvent Id_Alimentacion_GaseosasChanging(Value)
				Me._Id_Alimentacion_Gaseosas = Value
                RaiseEvent Id_Alimentacion_GaseosasChanged()
            End If
        End Set
    End Property

    Public Event Id_Alimentacion_AguaChanging(ByVal Value As Int32)
    Public Event Id_Alimentacion_AguaChanged()
	
    Public Property Id_Alimentacion_Agua() As Int32
        Get
            Return Me._Id_Alimentacion_Agua
        End Get
        Set(ByVal Value As Int32)
            If _Id_Alimentacion_Agua <> Value Then
                RaiseEvent Id_Alimentacion_AguaChanging(Value)
				Me._Id_Alimentacion_Agua = Value
                RaiseEvent Id_Alimentacion_AguaChanged()
            End If
        End Set
    End Property

    Public Event Id_Alimentacion_BienestarinaChanging(ByVal Value As Int32)
    Public Event Id_Alimentacion_BienestarinaChanged()
	
    Public Property Id_Alimentacion_Bienestarina() As Int32
        Get
            Return Me._Id_Alimentacion_Bienestarina
        End Get
        Set(ByVal Value As Int32)
            If _Id_Alimentacion_Bienestarina <> Value Then
                RaiseEvent Id_Alimentacion_BienestarinaChanging(Value)
				Me._Id_Alimentacion_Bienestarina = Value
                RaiseEvent Id_Alimentacion_BienestarinaChanged()
            End If
        End Set
    End Property

    Public Event Id_Alojamiento_Tipo_ViviendaChanging(ByVal Value As Int32)
    Public Event Id_Alojamiento_Tipo_ViviendaChanged()
	
    Public Property Id_Alojamiento_Tipo_Vivienda() As Int32
        Get
            Return Me._Id_Alojamiento_Tipo_Vivienda
        End Get
        Set(ByVal Value As Int32)
            If _Id_Alojamiento_Tipo_Vivienda <> Value Then
                RaiseEvent Id_Alojamiento_Tipo_ViviendaChanging(Value)
				Me._Id_Alojamiento_Tipo_Vivienda = Value
                RaiseEvent Id_Alojamiento_Tipo_ViviendaChanged()
            End If
        End Set
    End Property

    Public Event Id_Alojamiento_Tipo_Vivienda_OtroChanging(ByVal Value As Int32)
    Public Event Id_Alojamiento_Tipo_Vivienda_OtroChanged()

    Public Property Id_Alojamiento_Tipo_Vivienda_Otro() As Int32
        Get
            Return Me._Id_Alojamiento_Tipo_Vivienda_Otro
        End Get
        Set(ByVal Value As Int32)
            If _Id_Alojamiento_Tipo_Vivienda_Otro <> Value Then
                RaiseEvent Id_Alojamiento_Tipo_Vivienda_OtroChanging(Value)
                Me._Id_Alojamiento_Tipo_Vivienda_Otro = Value
                RaiseEvent Id_Alojamiento_Tipo_Vivienda_OtroChanged()
            End If
        End Set
    End Property


    Public Event Id_Alojamiento_Material_PisosChanging(ByVal Value As Int32)
    Public Event Id_Alojamiento_Material_PisosChanged()
	
    Public Property Id_Alojamiento_Material_Pisos() As Int32
        Get
            Return Me._Id_Alojamiento_Material_Pisos
        End Get
        Set(ByVal Value As Int32)
            If _Id_Alojamiento_Material_Pisos <> Value Then
                RaiseEvent Id_Alojamiento_Material_PisosChanging(Value)
				Me._Id_Alojamiento_Material_Pisos = Value
                RaiseEvent Id_Alojamiento_Material_PisosChanged()
            End If
        End Set
    End Property

    Public Event Id_Alojamiento_Material_ParedesChanging(ByVal Value As Int32)
    Public Event Id_Alojamiento_Material_ParedesChanged()
	
    Public Property Id_Alojamiento_Material_Paredes() As Int32
        Get
            Return Me._Id_Alojamiento_Material_Paredes
        End Get
        Set(ByVal Value As Int32)
            If _Id_Alojamiento_Material_Paredes <> Value Then
                RaiseEvent Id_Alojamiento_Material_ParedesChanging(Value)
				Me._Id_Alojamiento_Material_Paredes = Value
                RaiseEvent Id_Alojamiento_Material_ParedesChanged()
            End If
        End Set
    End Property

    Public Event Id_Alojamiento_Zona_RiesgoChanging(ByVal Value As Int32)
    Public Event Id_Alojamiento_Zona_RiesgoChanged()
	
    Public Property Id_Alojamiento_Zona_Riesgo() As Int32
        Get
            Return Me._Id_Alojamiento_Zona_Riesgo
        End Get
        Set(ByVal Value As Int32)
            If _Id_Alojamiento_Zona_Riesgo <> Value Then
                RaiseEvent Id_Alojamiento_Zona_RiesgoChanging(Value)
				Me._Id_Alojamiento_Zona_Riesgo = Value
                RaiseEvent Id_Alojamiento_Zona_RiesgoChanged()
            End If
        End Set
    End Property

    Public Event Id_Alojamiento_Cuantos_DuermenChanging(ByVal Value As Int32)
    Public Event Id_Alojamiento_Cuantos_DuermenChanged()
	
    Public Property Id_Alojamiento_Cuantos_Duermen() As Int32
        Get
            Return Me._Id_Alojamiento_Cuantos_Duermen
        End Get
        Set(ByVal Value As Int32)
            If _Id_Alojamiento_Cuantos_Duermen <> Value Then
                RaiseEvent Id_Alojamiento_Cuantos_DuermenChanging(Value)
				Me._Id_Alojamiento_Cuantos_Duermen = Value
                RaiseEvent Id_Alojamiento_Cuantos_DuermenChanged()
            End If
        End Set
    End Property

    Public Event Id_Alojamiento_AcueductoChanging(ByVal Value As Int32)
    Public Event Id_Alojamiento_AcueductoChanged()
	
    Public Property Id_Alojamiento_Acueducto() As Int32
        Get
            Return Me._Id_Alojamiento_Acueducto
        End Get
        Set(ByVal Value As Int32)
            If _Id_Alojamiento_Acueducto <> Value Then
                RaiseEvent Id_Alojamiento_AcueductoChanging(Value)
				Me._Id_Alojamiento_Acueducto = Value
                RaiseEvent Id_Alojamiento_AcueductoChanged()
            End If
        End Set
    End Property

    Public Event Id_Alojamiento_Obtiene_AguaChanging(ByVal Value As Int32)
    Public Event Id_Alojamiento_Obtiene_AguaChanged()
	
    Public Property Id_Alojamiento_Obtiene_Agua() As Int32
        Get
            Return Me._Id_Alojamiento_Obtiene_Agua
        End Get
        Set(ByVal Value As Int32)
            If _Id_Alojamiento_Obtiene_Agua <> Value Then
                RaiseEvent Id_Alojamiento_Obtiene_AguaChanging(Value)
				Me._Id_Alojamiento_Obtiene_Agua = Value
                RaiseEvent Id_Alojamiento_Obtiene_AguaChanged()
            End If
        End Set
    End Property

    Public Event Id_Alojamiento_AlcantarilladoChanging(ByVal Value As Int32)
    Public Event Id_Alojamiento_AlcantarilladoChanged()
	
    Public Property Id_Alojamiento_Alcantarillado() As Int32
        Get
            Return Me._Id_Alojamiento_Alcantarillado
        End Get
        Set(ByVal Value As Int32)
            If _Id_Alojamiento_Alcantarillado <> Value Then
                RaiseEvent Id_Alojamiento_AlcantarilladoChanging(Value)
				Me._Id_Alojamiento_Alcantarillado = Value
                RaiseEvent Id_Alojamiento_AlcantarilladoChanged()
            End If
        End Set
    End Property

    Public Event Id_Alojamiento_Servicio_SanitarioChanging(ByVal Value As Int32)
    Public Event Id_Alojamiento_Servicio_SanitarioChanged()
	
    Public Property Id_Alojamiento_Servicio_Sanitario() As Int32
        Get
            Return Me._Id_Alojamiento_Servicio_Sanitario
        End Get
        Set(ByVal Value As Int32)
            If _Id_Alojamiento_Servicio_Sanitario <> Value Then
                RaiseEvent Id_Alojamiento_Servicio_SanitarioChanging(Value)
				Me._Id_Alojamiento_Servicio_Sanitario = Value
                RaiseEvent Id_Alojamiento_Servicio_SanitarioChanged()
            End If
        End Set
    End Property

    Public Event Valor_AlimentacionChanging(ByVal Value As Double)
    Public Event Valor_AlimentacionChanged()

    Public Property Valor_Alimentacion() As Double
        Get
            Return Me._Valor_Alimentacion
        End Get
        Set(ByVal Value As Double)
            If _Valor_Alimentacion <> Value Then
                RaiseEvent Valor_AlimentacionChanging(Value)
                Me._Valor_Alimentacion = Value
                RaiseEvent Valor_AlimentacionChanged()
            End If
        End Set
    End Property

    Public Event Valor_AlojamientoChanging(ByVal Value As Double)
    Public Event Valor_AlojamientoChanged()

    Public Property Valor_Alojamiento() As Double
        Get
            Return Me._Valor_Alojamiento
        End Get
        Set(ByVal Value As Double)
            If _Valor_Alojamiento <> Value Then
                RaiseEvent Valor_AlojamientoChanging(Value)
                Me._Valor_Alojamiento = Value
                RaiseEvent Valor_AlojamientoChanged()
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

    Public Readonly Property Agua() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Alimentacion_Agua)
        End Get
    End Property

    Public Readonly Property Azucares() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Alimentacion_Azucares)
        End Get
    End Property

    Public Readonly Property Bienestarina() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Alimentacion_Bienestarina)
        End Get
    End Property

    Public Readonly Property Carnes() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Alimentacion_Carnes)
        End Get
    End Property

    Public Readonly Property Consumo() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Alimentacion_Consumo)
        End Get
    End Property

    Public Readonly Property Enbutidos() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Alimentacion_Enbutidos)
        End Get
    End Property

    Public Readonly Property Enlatados() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Alimentacion_Enlatados)
        End Get
    End Property

    Public Readonly Property Frutas() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Alimentacion_Frutas)
        End Get
    End Property

    Public Readonly Property Gaseosas() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Alimentacion_Gaseosas)
        End Get
    End Property

    Public Readonly Property Grasas() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Alimentacion_Grasas)
        End Get
    End Property

    Public Readonly Property Harinas() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Alimentacion_Harinas)
        End Get
    End Property

    Public Readonly Property Huevos() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Alimentacion_Huevos)
        End Get
    End Property

    Public Readonly Property Lacteos() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Alimentacion_Lacteos)
        End Get
    End Property

    Public Readonly Property Leguminosas() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Alimentacion_Leguminosas)
        End Get
    End Property

    Public Readonly Property Raices() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Alimentacion_Raices)
        End Get
    End Property

    Public Readonly Property Verduras() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Alimentacion_Verduras)
        End Get
    End Property

    Public Readonly Property Acueducto() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Alojamiento_Acueducto)
        End Get
    End Property

    Public Readonly Property Alcantarillado() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Alojamiento_Alcantarillado)
        End Get
    End Property

    Public Readonly Property Cuantos_Duermen() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Alojamiento_Cuantos_Duermen)
        End Get
    End Property

    Public Readonly Property Material_Paredes() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Alojamiento_Material_Paredes)
        End Get
    End Property

    Public Readonly Property Material_Pisos() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Alojamiento_Material_Pisos)
        End Get
    End Property

    Public Readonly Property Obtiene_Agua() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Alojamiento_Obtiene_Agua)
        End Get
    End Property

    Public Readonly Property Servicio_Sanitario() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Alojamiento_Servicio_Sanitario)
        End Get
    End Property

    Public Readonly Property Tipo_Vivienda() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Alojamiento_Tipo_Vivienda)
        End Get
    End Property

    Public ReadOnly Property Tipo_Vivienda_Otro() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Alojamiento_Tipo_Vivienda_Otro)
        End Get
    End Property

    Public Readonly Property Zona_Riesgo() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Alojamiento_Zona_Riesgo)
        End Get
    End Property

    Public Readonly Property Declaracion() As DeclaracionBrl
        Get
            Return DeclaracionBrl.CargarPorID(Id_Declaracion)
        End Get
    End Property

    Public Readonly Property TipoEntrega() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Tipo_Entrega)
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
            Me.ID = Declaracion_PAARIDAL.Insertar(Id_Declaracion, Id_Tipo_Entrega, Id_Alimentacion_Consumo, Id_Alimentacion_Raices, Id_Alimentacion_Verduras, Id_Alimentacion_Frutas, Id_Alimentacion_Carnes, Id_Alimentacion_Huevos, Id_Alimentacion_Leguminosas, Id_Alimentacion_Lacteos, Id_Alimentacion_Grasas, Id_Alimentacion_Azucares, Id_Alimentacion_Harinas, Id_Alimentacion_Enbutidos, Id_Alimentacion_Enlatados, Id_Alimentacion_Gaseosas, Id_Alimentacion_Agua, Id_Alimentacion_Bienestarina, Id_Alojamiento_Tipo_Vivienda, Id_Alojamiento_Tipo_Vivienda_Otro, Id_Alojamiento_Material_Pisos, Id_Alojamiento_Material_Paredes, Id_Alojamiento_Zona_Riesgo, Id_Alojamiento_Cuantos_Duermen, Id_Alojamiento_Acueducto, Id_Alojamiento_Obtiene_Agua, Id_Alojamiento_Alcantarillado, Id_Alojamiento_Servicio_Sanitario, Valor_Alimentacion, Valor_Alojamiento, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion)
            RaiseEvent Inserted()			
		Else
            RaiseEvent Updating()		
            Declaracion_PAARIDAL.Actualizar(ID, Id_Declaracion, Id_Tipo_Entrega, Id_Alimentacion_Consumo, Id_Alimentacion_Raices, Id_Alimentacion_Verduras, Id_Alimentacion_Frutas, Id_Alimentacion_Carnes, Id_Alimentacion_Huevos, Id_Alimentacion_Leguminosas, Id_Alimentacion_Lacteos, Id_Alimentacion_Grasas, Id_Alimentacion_Azucares, Id_Alimentacion_Harinas, Id_Alimentacion_Enbutidos, Id_Alimentacion_Enlatados, Id_Alimentacion_Gaseosas, Id_Alimentacion_Agua, Id_Alimentacion_Bienestarina, Id_Alojamiento_Tipo_Vivienda, Id_Alojamiento_Tipo_Vivienda_Otro, Id_Alojamiento_Material_Pisos, Id_Alojamiento_Material_Paredes, Id_Alojamiento_Zona_Riesgo, Id_Alojamiento_Cuantos_Duermen, Id_Alojamiento_Acueducto, Id_Alojamiento_Obtiene_Agua, Id_Alojamiento_Alcantarillado, Id_Alojamiento_Servicio_Sanitario, Valor_Alimentacion, Valor_Alojamiento, Fecha_Creacion, Id_Usuario_Creacion, Fecha_Modificacion, Id_Usuario_Modificacion)
            RaiseEvent Updated()			
		End If   

        RaiseEvent Saved()
        
	End Sub
	
	Public Sub Eliminar()
		Dim totalHijos As Long = 0
		If Me.ID <> Nothing Then 
			
            RaiseEvent Deleting()

            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            
			Declaracion_PAARIDAL.Eliminar(Me.ID)
			
            RaiseEvent Deleted()
            
        End If
	End Sub
	

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Declaracion_PAARIBrl
		
		Dim objDeclaracion_PAARI As New Declaracion_PAARIBrl
		
		With objDeclaracion_PAARI
			.ID = fila("Id")
			.Id_Declaracion = isDBNullToNothing(fila("Id_Declaracion"))
			.Id_Tipo_Entrega = isDBNullToNothing(fila("Id_Tipo_Entrega"))
			.Id_Alimentacion_Consumo = isDBNullToNothing(fila("Id_Alimentacion_Consumo"))
			.Id_Alimentacion_Raices = isDBNullToNothing(fila("Id_Alimentacion_Raices"))
			.Id_Alimentacion_Verduras = isDBNullToNothing(fila("Id_Alimentacion_Verduras"))
			.Id_Alimentacion_Frutas = isDBNullToNothing(fila("Id_Alimentacion_Frutas"))
			.Id_Alimentacion_Carnes = isDBNullToNothing(fila("Id_Alimentacion_Carnes"))
			.Id_Alimentacion_Huevos = isDBNullToNothing(fila("Id_Alimentacion_Huevos"))
			.Id_Alimentacion_Leguminosas = isDBNullToNothing(fila("Id_Alimentacion_Leguminosas"))
			.Id_Alimentacion_Lacteos = isDBNullToNothing(fila("Id_Alimentacion_Lacteos"))
			.Id_Alimentacion_Grasas = isDBNullToNothing(fila("Id_Alimentacion_Grasas"))
			.Id_Alimentacion_Azucares = isDBNullToNothing(fila("Id_Alimentacion_Azucares"))
			.Id_Alimentacion_Harinas = isDBNullToNothing(fila("Id_Alimentacion_Harinas"))
			.Id_Alimentacion_Enbutidos = isDBNullToNothing(fila("Id_Alimentacion_Enbutidos"))
			.Id_Alimentacion_Enlatados = isDBNullToNothing(fila("Id_Alimentacion_Enlatados"))
			.Id_Alimentacion_Gaseosas = isDBNullToNothing(fila("Id_Alimentacion_Gaseosas"))
			.Id_Alimentacion_Agua = isDBNullToNothing(fila("Id_Alimentacion_Agua"))
			.Id_Alimentacion_Bienestarina = isDBNullToNothing(fila("Id_Alimentacion_Bienestarina"))
            .Id_Alojamiento_Tipo_Vivienda = isDBNullToNothing(fila("Id_Alojamiento_Tipo_Vivienda"))
            .Id_Alojamiento_Tipo_Vivienda_Otro = isDBNullToNothing(fila("Id_Alojamiento_Tipo_Vivienda_Otro"))
			.Id_Alojamiento_Material_Pisos = isDBNullToNothing(fila("Id_Alojamiento_Material_Pisos"))
			.Id_Alojamiento_Material_Paredes = isDBNullToNothing(fila("Id_Alojamiento_Material_Paredes"))
			.Id_Alojamiento_Zona_Riesgo = isDBNullToNothing(fila("Id_Alojamiento_Zona_Riesgo"))
			.Id_Alojamiento_Cuantos_Duermen = isDBNullToNothing(fila("Id_Alojamiento_Cuantos_Duermen"))
			.Id_Alojamiento_Acueducto = isDBNullToNothing(fila("Id_Alojamiento_Acueducto"))
			.Id_Alojamiento_Obtiene_Agua = isDBNullToNothing(fila("Id_Alojamiento_Obtiene_Agua"))
			.Id_Alojamiento_Alcantarillado = isDBNullToNothing(fila("Id_Alojamiento_Alcantarillado"))
            .Id_Alojamiento_Servicio_Sanitario = isDBNullToNothing(fila("Id_Alojamiento_Servicio_Sanitario"))
            .Valor_Alimentacion = isDBNullToNothing(fila("Valor_Alimentacion"))
            .Valor_Alojamiento = isDBNullToNothing(fila("Valor_Alojamiento"))
            .Fecha_Creacion = isDBNullToNothing(fila("Fecha_Creacion"))
			.Id_Usuario_Creacion = isDBNullToNothing(fila("Id_Usuario_Creacion"))
			.Fecha_Modificacion = isDBNullToNothing(fila("Fecha_Modificacion"))
			.Id_Usuario_Modificacion = isDBNullToNothing(fila("Id_Usuario_Modificacion"))

		End With
		
		Return objDeclaracion_PAARI
		
    End Function
	
	Public Shared Event LoadingDeclaracion_PAARIList(ByVal LoadType As String)
	Public Shared Event LoadedDeclaracion_PAARIList(target As List(Of Declaracion_PAARIBrl), ByVal LoadType As String)
	
	Public Shared Function CargarTodos() As List(Of Declaracion_PAARIBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_PAARIBrl)
	
		RaiseEvent LoadingDeclaracion_PAARIList("CargarTodos")
	
		dsDatos = Declaracion_PAARIDAL.CargarTodos()

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_PAARIList(lista, "CargarTodos")
        
        Return lista
        
    End Function

	Public Shared Event CargandoPorId(ByVal id As Int32)
    Public Shared Event CargadoPorId(ByVal target As Declaracion_PAARIBrl)

	Public Shared Function CargarPorID(ID As Int32) As Declaracion_PAARIBrl

		Dim dsDatos As System.Data.DataSet
		Dim objDeclaracion_PAARI As Declaracion_PAARIBrl = Nothing 
		
        dsDatos = Declaracion_PAARIDAL.CargarPorID(ID)
		
		If dsDatos.Tables(0).Rows.Count <> 0 Then objDeclaracion_PAARI = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))

        Return objDeclaracion_PAARI
        
    End Function

	Public Shared Function CargarPorId_Alimentacion_Agua(ByVal Id_Alimentacion_Agua As Int32) As List(Of Declaracion_PAARIBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_PAARIBrl)
	
		RaiseEvent LoadingDeclaracion_PAARIList("CargarPorId_Alimentacion_Agua")
		
		dsDatos = Declaracion_PAARIDAL.CargarPorId_Alimentacion_Agua(Id_Alimentacion_Agua)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_PAARIList(lista, "CargarPorId_Alimentacion_Agua")
        
        Return lista
        
	End Function

	Public Shared Function CargarPorId_Alimentacion_Azucares(ByVal Id_Alimentacion_Azucares As Int32) As List(Of Declaracion_PAARIBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_PAARIBrl)
	
		RaiseEvent LoadingDeclaracion_PAARIList("CargarPorId_Alimentacion_Azucares")
		
		dsDatos = Declaracion_PAARIDAL.CargarPorId_Alimentacion_Azucares(Id_Alimentacion_Azucares)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_PAARIList(lista, "CargarPorId_Alimentacion_Azucares")
        
        Return lista
        
	End Function

	Public Shared Function CargarPorId_Alimentacion_Bienestarina(ByVal Id_Alimentacion_Bienestarina As Int32) As List(Of Declaracion_PAARIBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_PAARIBrl)
	
		RaiseEvent LoadingDeclaracion_PAARIList("CargarPorId_Alimentacion_Bienestarina")
		
		dsDatos = Declaracion_PAARIDAL.CargarPorId_Alimentacion_Bienestarina(Id_Alimentacion_Bienestarina)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_PAARIList(lista, "CargarPorId_Alimentacion_Bienestarina")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Alimentacion_Carnes(ByVal Id_Alimentacion_Carnes As Int32) As List(Of Declaracion_PAARIBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_PAARIBrl)
	
		RaiseEvent LoadingDeclaracion_PAARIList("CargarPorId_Alimentacion_Carnes")
		
		dsDatos = Declaracion_PAARIDAL.CargarPorId_Alimentacion_Carnes(Id_Alimentacion_Carnes)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_PAARIList(lista, "CargarPorId_Alimentacion_Carnes")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Alimentacion_Consumo(ByVal Id_Alimentacion_Consumo As Int32) As List(Of Declaracion_PAARIBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_PAARIBrl)
	
		RaiseEvent LoadingDeclaracion_PAARIList("CargarPorId_Alimentacion_Consumo")
		
		dsDatos = Declaracion_PAARIDAL.CargarPorId_Alimentacion_Consumo(Id_Alimentacion_Consumo)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_PAARIList(lista, "CargarPorId_Alimentacion_Consumo")
        
        Return lista
        
	End Function

	Public Shared Function CargarPorId_Alimentacion_Enbutidos(ByVal Id_Alimentacion_Enbutidos As Int32) As List(Of Declaracion_PAARIBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_PAARIBrl)
	
		RaiseEvent LoadingDeclaracion_PAARIList("CargarPorId_Alimentacion_Enbutidos")
		
		dsDatos = Declaracion_PAARIDAL.CargarPorId_Alimentacion_Enbutidos(Id_Alimentacion_Enbutidos)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_PAARIList(lista, "CargarPorId_Alimentacion_Enbutidos")
        
        Return lista
        
	End Function

	Public Shared Function CargarPorId_Alimentacion_Enlatados(ByVal Id_Alimentacion_Enlatados As Int32) As List(Of Declaracion_PAARIBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_PAARIBrl)
	
		RaiseEvent LoadingDeclaracion_PAARIList("CargarPorId_Alimentacion_Enlatados")
		
		dsDatos = Declaracion_PAARIDAL.CargarPorId_Alimentacion_Enlatados(Id_Alimentacion_Enlatados)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_PAARIList(lista, "CargarPorId_Alimentacion_Enlatados")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Alimentacion_Frutas(ByVal Id_Alimentacion_Frutas As Int32) As List(Of Declaracion_PAARIBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_PAARIBrl)
	
		RaiseEvent LoadingDeclaracion_PAARIList("CargarPorId_Alimentacion_Frutas")
		
		dsDatos = Declaracion_PAARIDAL.CargarPorId_Alimentacion_Frutas(Id_Alimentacion_Frutas)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_PAARIList(lista, "CargarPorId_Alimentacion_Frutas")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Alimentacion_Gaseosas(ByVal Id_Alimentacion_Gaseosas As Int32) As List(Of Declaracion_PAARIBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_PAARIBrl)
	
		RaiseEvent LoadingDeclaracion_PAARIList("CargarPorId_Alimentacion_Gaseosas")
		
		dsDatos = Declaracion_PAARIDAL.CargarPorId_Alimentacion_Gaseosas(Id_Alimentacion_Gaseosas)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_PAARIList(lista, "CargarPorId_Alimentacion_Gaseosas")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Alimentacion_Grasas(ByVal Id_Alimentacion_Grasas As Int32) As List(Of Declaracion_PAARIBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_PAARIBrl)
	
		RaiseEvent LoadingDeclaracion_PAARIList("CargarPorId_Alimentacion_Grasas")
		
		dsDatos = Declaracion_PAARIDAL.CargarPorId_Alimentacion_Grasas(Id_Alimentacion_Grasas)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_PAARIList(lista, "CargarPorId_Alimentacion_Grasas")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Alimentacion_Harinas(ByVal Id_Alimentacion_Harinas As Int32) As List(Of Declaracion_PAARIBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_PAARIBrl)
	
		RaiseEvent LoadingDeclaracion_PAARIList("CargarPorId_Alimentacion_Harinas")
		
		dsDatos = Declaracion_PAARIDAL.CargarPorId_Alimentacion_Harinas(Id_Alimentacion_Harinas)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_PAARIList(lista, "CargarPorId_Alimentacion_Harinas")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Alimentacion_Huevos(ByVal Id_Alimentacion_Huevos As Int32) As List(Of Declaracion_PAARIBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_PAARIBrl)
	
		RaiseEvent LoadingDeclaracion_PAARIList("CargarPorId_Alimentacion_Huevos")
		
		dsDatos = Declaracion_PAARIDAL.CargarPorId_Alimentacion_Huevos(Id_Alimentacion_Huevos)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_PAARIList(lista, "CargarPorId_Alimentacion_Huevos")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Alimentacion_Lacteos(ByVal Id_Alimentacion_Lacteos As Int32) As List(Of Declaracion_PAARIBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_PAARIBrl)
	
		RaiseEvent LoadingDeclaracion_PAARIList("CargarPorId_Alimentacion_Lacteos")
		
		dsDatos = Declaracion_PAARIDAL.CargarPorId_Alimentacion_Lacteos(Id_Alimentacion_Lacteos)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_PAARIList(lista, "CargarPorId_Alimentacion_Lacteos")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Alimentacion_Leguminosas(ByVal Id_Alimentacion_Leguminosas As Int32) As List(Of Declaracion_PAARIBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_PAARIBrl)
	
		RaiseEvent LoadingDeclaracion_PAARIList("CargarPorId_Alimentacion_Leguminosas")
		
		dsDatos = Declaracion_PAARIDAL.CargarPorId_Alimentacion_Leguminosas(Id_Alimentacion_Leguminosas)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_PAARIList(lista, "CargarPorId_Alimentacion_Leguminosas")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Alimentacion_Raices(ByVal Id_Alimentacion_Raices As Int32) As List(Of Declaracion_PAARIBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_PAARIBrl)
	
		RaiseEvent LoadingDeclaracion_PAARIList("CargarPorId_Alimentacion_Raices")
		
		dsDatos = Declaracion_PAARIDAL.CargarPorId_Alimentacion_Raices(Id_Alimentacion_Raices)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_PAARIList(lista, "CargarPorId_Alimentacion_Raices")
        
        Return lista
        
	End Function

    Public Shared Function CargarPorId_Alimentacion_Verduras(ByVal Id_Alimentacion_Verduras As Int32) As List(Of Declaracion_PAARIBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Declaracion_PAARIBrl)

        RaiseEvent LoadingDeclaracion_PAARIList("CargarPorId_Alimentacion_Verduras")

        dsDatos = Declaracion_PAARIDAL.CargarPorId_Alimentacion_Verduras(Id_Alimentacion_Verduras)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedDeclaracion_PAARIList(lista, "CargarPorId_Alimentacion_Verduras")

        Return lista

    End Function


	Public Shared Function CargarPorId_Alojamiento_Acueducto(ByVal Id_Alojamiento_Acueducto As Int32) As List(Of Declaracion_PAARIBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_PAARIBrl)
	
		RaiseEvent LoadingDeclaracion_PAARIList("CargarPorId_Alojamiento_Acueducto")
		
		dsDatos = Declaracion_PAARIDAL.CargarPorId_Alojamiento_Acueducto(Id_Alojamiento_Acueducto)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_PAARIList(lista, "CargarPorId_Alojamiento_Acueducto")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Alojamiento_Alcantarillado(ByVal Id_Alojamiento_Alcantarillado As Int32) As List(Of Declaracion_PAARIBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_PAARIBrl)
	
		RaiseEvent LoadingDeclaracion_PAARIList("CargarPorId_Alojamiento_Alcantarillado")
		
		dsDatos = Declaracion_PAARIDAL.CargarPorId_Alojamiento_Alcantarillado(Id_Alojamiento_Alcantarillado)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_PAARIList(lista, "CargarPorId_Alojamiento_Alcantarillado")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Alojamiento_Cuantos_Duermen(ByVal Id_Alojamiento_Cuantos_Duermen As Int32) As List(Of Declaracion_PAARIBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_PAARIBrl)
	
		RaiseEvent LoadingDeclaracion_PAARIList("CargarPorId_Alojamiento_Cuantos_Duermen")
		
		dsDatos = Declaracion_PAARIDAL.CargarPorId_Alojamiento_Cuantos_Duermen(Id_Alojamiento_Cuantos_Duermen)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_PAARIList(lista, "CargarPorId_Alojamiento_Cuantos_Duermen")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Alojamiento_Material_Paredes(ByVal Id_Alojamiento_Material_Paredes As Int32) As List(Of Declaracion_PAARIBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_PAARIBrl)
	
		RaiseEvent LoadingDeclaracion_PAARIList("CargarPorId_Alojamiento_Material_Paredes")
		
		dsDatos = Declaracion_PAARIDAL.CargarPorId_Alojamiento_Material_Paredes(Id_Alojamiento_Material_Paredes)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_PAARIList(lista, "CargarPorId_Alojamiento_Material_Paredes")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Alojamiento_Material_Pisos(ByVal Id_Alojamiento_Material_Pisos As Int32) As List(Of Declaracion_PAARIBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_PAARIBrl)
	
		RaiseEvent LoadingDeclaracion_PAARIList("CargarPorId_Alojamiento_Material_Pisos")
		
		dsDatos = Declaracion_PAARIDAL.CargarPorId_Alojamiento_Material_Pisos(Id_Alojamiento_Material_Pisos)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_PAARIList(lista, "CargarPorId_Alojamiento_Material_Pisos")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Alojamiento_Obtiene_Agua(ByVal Id_Alojamiento_Obtiene_Agua As Int32) As List(Of Declaracion_PAARIBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_PAARIBrl)
	
		RaiseEvent LoadingDeclaracion_PAARIList("CargarPorId_Alojamiento_Obtiene_Agua")
		
		dsDatos = Declaracion_PAARIDAL.CargarPorId_Alojamiento_Obtiene_Agua(Id_Alojamiento_Obtiene_Agua)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_PAARIList(lista, "CargarPorId_Alojamiento_Obtiene_Agua")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Alojamiento_Servicio_Sanitario(ByVal Id_Alojamiento_Servicio_Sanitario As Int32) As List(Of Declaracion_PAARIBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_PAARIBrl)
	
		RaiseEvent LoadingDeclaracion_PAARIList("CargarPorId_Alojamiento_Servicio_Sanitario")
		
		dsDatos = Declaracion_PAARIDAL.CargarPorId_Alojamiento_Servicio_Sanitario(Id_Alojamiento_Servicio_Sanitario)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_PAARIList(lista, "CargarPorId_Alojamiento_Servicio_Sanitario")
        
        Return lista
        
	End Function

	Public Shared Function CargarPorId_Alojamiento_Tipo_Vivienda(ByVal Id_Alojamiento_Tipo_Vivienda As Int32) As List(Of Declaracion_PAARIBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_PAARIBrl)
	
		RaiseEvent LoadingDeclaracion_PAARIList("CargarPorId_Alojamiento_Tipo_Vivienda")
		
		dsDatos = Declaracion_PAARIDAL.CargarPorId_Alojamiento_Tipo_Vivienda(Id_Alojamiento_Tipo_Vivienda)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_PAARIList(lista, "CargarPorId_Alojamiento_Tipo_Vivienda")
        
        Return lista
        
	End Function

    Public Shared Function CargarPorId_Alojamiento_Tipo_Vivienda_Otro(ByVal Id_Alojamiento_Tipo_Vivienda_Otro As Int32) As List(Of Declaracion_PAARIBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Declaracion_PAARIBrl)

        dsDatos = Declaracion_PAARIDAL.CargarPorId_Alojamiento_Tipo_Vivienda_Otro(Id_Alojamiento_Tipo_Vivienda_Otro)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        Return lista

    End Function

	Public Shared Function CargarPorId_Alojamiento_Zona_Riesgo(ByVal Id_Alojamiento_Zona_Riesgo As Int32) As List(Of Declaracion_PAARIBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_PAARIBrl)
	
		RaiseEvent LoadingDeclaracion_PAARIList("CargarPorId_Alojamiento_Zona_Riesgo")
		
		dsDatos = Declaracion_PAARIDAL.CargarPorId_Alojamiento_Zona_Riesgo(Id_Alojamiento_Zona_Riesgo)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_PAARIList(lista, "CargarPorId_Alojamiento_Zona_Riesgo")
        
        Return lista
        
	End Function

	Public Shared Function CargarPorId_Declaracion(ByVal Id_Declaracion As Int32) As List(Of Declaracion_PAARIBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_PAARIBrl)
	
		RaiseEvent LoadingDeclaracion_PAARIList("CargarPorId_Declaracion")
		
		dsDatos = Declaracion_PAARIDAL.CargarPorId_Declaracion(Id_Declaracion)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_PAARIList(lista, "CargarPorId_Declaracion")
        
        Return lista
        
	End Function


	Public Shared Function CargarPorId_Tipo_Entrega(ByVal Id_Tipo_Entrega As Int32) As List(Of Declaracion_PAARIBrl)

		Dim dsDatos As System.Data.DataSet
		Dim lista As New List(Of Declaracion_PAARIBrl)
	
		RaiseEvent LoadingDeclaracion_PAARIList("CargarPorId_Tipo_Entrega")
		
		dsDatos = Declaracion_PAARIDAL.CargarPorId_Tipo_Entrega(Id_Tipo_Entrega)

        For Each fila as DataRow in dsDatos.Tables(0).Rows
			lista.Add(asignarValoresALasPropiedades(fila))
        Next
        
        RaiseEvent LoadedDeclaracion_PAARIList(lista, "CargarPorId_Tipo_Entrega")
        
        Return lista
        
	End Function



End Class


