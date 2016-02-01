Imports ingNovar.Utilidades2
Imports System.Data
Imports System.Collections.Generic

Partial Public Class Tmp_SaludBrl

    Private _Id As Int32
    Private _Id_Usuario As Int32
    Private _DescripcionGrupo As String
    Private _Declarante As String
    Private _Tipo_Identificacion As String
    Private _Identificacion As String
    Private _Edad As Int32
    Private _Nombre_Completo As String
    Private _Genero As String
    Private _Fecha_Nacimiento As DateTime
    Private _Nombre_Declarante As String
    Private _Identificacion_Declarante As String
    Private _Telefono_Declarante As String
    Private _Direccion_Declarante As String
    Private _Celular_Declarante As String
    Private _Barrio_Declarante As String
    Private _Id_Persona As Int32
    Private _CYD As String
    Private _Patologia As String
    Private _Lactando As String
    Private _Lactancia_Meses As Int32
    Private _Lactancia_exclusiva As Int32
    Private _Desparasitacion As String
    Private _Suplementacion As String
    Private _Carnet As String
    Private _Motivo_NoCarnet As String
    Private _Vacunacion As String
    Private _Motivo_No_VacunacionCompleta As String
    Private _Vacunados As String
    Private _MotivoNoVacunados As String
    Private _Fecha_Esquema_Vacunacion As DateTime
    Private _Observaciones_Salud As String
    Private _Fecha_Valoracion01 As DateTime
    Private _AntropometriaPeso01 As Double
    Private _AntropometriaTalla01 As Double
    Private _Antropometia_Perimetro_Branquial01 As Double
    Private _Recuperado01 As String
    Private _Observaciones01 As String
    Private _PesoTalla01 As String
    Private _PesoEdad01 As String
    Private _TallaLongitud01 As String
    Private _IMC_Edad01 As String
    Private _Edad01 As Int32
    Private _Meses01 As Int32
    Private _TallaParaEdad01 As String
    Private _EstadoNutricional01 As String
    Private _Fecha_Valoracion02 As DateTime
    Private _AntropometriaPeso02 As Double
    Private _AntropometriaTalla02 As Double
    Private _Antropometia_Perimetro_Branquial02 As Double
    Private _Recuperado02 As String
    Private _Observaciones02 As String
    Private _PesoTalla02 As String
    Private _PesoEdad02 As String
    Private _TallaLongitud02 As String
    Private _IMC_Edad02 As String
    Private _Edad02 As Int32
    Private _Meses02 As Int32
    Private _TallaParaEdad02 As String
    Private _EstadoNutricional02 As String
    Private _Fecha_Valoracion03 As DateTime
    Private _AntropometriaPeso03 As Double
    Private _AntropometriaTalla03 As Double
    Private _Antropometia_Perimetro_Branquial03 As Double
    Private _Recuperado03 As String
    Private _Observaciones03 As String
    Private _PesoTalla03 As String
    Private _PesoEdad03 As String
    Private _TallaLongitud03 As String
    Private _IMC_Edad03 As String
    Private _Edad03 As Int32
    Private _Meses03 As Int32
    Private _TallaParaEdad03 As String
    Private _EstadoNutricional03 As String
    Private _Fecha_ValoracionSeg As DateTime
    Private _AntropometriaPesoSeg As Double
    Private _AntropometriaTallaSeg As Double
    Private _Antropometia_Perimetro_BranquialSeg As Double
    Private _RecuperadoSeg As String
    Private _ObservacionesSeg As String
    Private _PesoTallaSeg As String
    Private _PesoEdadSeg As String
    Private _TallaLongitudSeg As String
    Private _IMC_EdadSeg As String
    Private _EdadSeg As Int32
    Private _MesesSeg As Int32
    Private _TallaParaEdadSeg As String
    Private _EstadoNutricionalSeg As String
    Private _FechaRemision01 As DateTime
    Private _FechaRealizado01 As DateTime
    Private _EntidadRemision01 As String
    Private _ServicioRemision01 As String
    Private _FechaRemision02 As DateTime
    Private _FechaRealizado02 As DateTime
    Private _EntidadRemision02 As String
    Private _ServicioRemision02 As String
    Private _FechaRemision03 As DateTime
    Private _FechaRealizado03 As DateTime
    Private _EntidadRemision03 As String
    Private _ServicioRemision03 As String
    Private _Regional As String
    Private _LugarEntrega As String

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

    Public Event DescripcionGrupoChanging(ByVal Value As String)
    Public Event DescripcionGrupoChanged()

    Public Property DescripcionGrupo() As String
        Get
            Return Me._DescripcionGrupo
        End Get
        Set(ByVal Value As String)
            If _DescripcionGrupo <> Value Then
                RaiseEvent DescripcionGrupoChanging(Value)
                Me._DescripcionGrupo = Value
                RaiseEvent DescripcionGrupoChanged()
            End If
        End Set
    End Property

    Public Event DeclaranteChanging(ByVal Value As String)
    Public Event DeclaranteChanged()

    Public Property Declarante() As String
        Get
            Return Me._Declarante
        End Get
        Set(ByVal Value As String)
            If _Declarante <> Value Then
                RaiseEvent DeclaranteChanging(Value)
                Me._Declarante = Value
                RaiseEvent DeclaranteChanged()
            End If
        End Set
    End Property

    Public Event Tipo_IdentificacionChanging(ByVal Value As String)
    Public Event Tipo_IdentificacionChanged()

    Public Property Tipo_Identificacion() As String
        Get
            Return Me._Tipo_Identificacion
        End Get
        Set(ByVal Value As String)
            If _Tipo_Identificacion <> Value Then
                RaiseEvent Tipo_IdentificacionChanging(Value)
                Me._Tipo_Identificacion = Value
                RaiseEvent Tipo_IdentificacionChanged()
            End If
        End Set
    End Property

    Public Event IdentificacionChanging(ByVal Value As String)
    Public Event IdentificacionChanged()

    Public Property Identificacion() As String
        Get
            Return Me._Identificacion
        End Get
        Set(ByVal Value As String)
            If _Identificacion <> Value Then
                RaiseEvent IdentificacionChanging(Value)
                Me._Identificacion = Value
                RaiseEvent IdentificacionChanged()
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

    Public Event Nombre_CompletoChanging(ByVal Value As String)
    Public Event Nombre_CompletoChanged()

    Public Property Nombre_Completo() As String
        Get
            Return Me._Nombre_Completo
        End Get
        Set(ByVal Value As String)
            If _Nombre_Completo <> Value Then
                RaiseEvent Nombre_CompletoChanging(Value)
                Me._Nombre_Completo = Value
                RaiseEvent Nombre_CompletoChanged()
            End If
        End Set
    End Property

    Public Event GeneroChanging(ByVal Value As String)
    Public Event GeneroChanged()

    Public Property Genero() As String
        Get
            Return Me._Genero
        End Get
        Set(ByVal Value As String)
            If _Genero <> Value Then
                RaiseEvent GeneroChanging(Value)
                Me._Genero = Value
                RaiseEvent GeneroChanged()
            End If
        End Set
    End Property

    Public Event Fecha_NacimientoChanging(ByVal Value As DateTime)
    Public Event Fecha_NacimientoChanged()

    Public Property Fecha_Nacimiento() As DateTime
        Get
            Return Me._Fecha_Nacimiento
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_Nacimiento <> Value Then
                RaiseEvent Fecha_NacimientoChanging(Value)
                Me._Fecha_Nacimiento = Value
                RaiseEvent Fecha_NacimientoChanged()
            End If
        End Set
    End Property

    Public Event Nombre_DeclaranteChanging(ByVal Value As String)
    Public Event Nombre_DeclaranteChanged()

    Public Property Nombre_Declarante() As String
        Get
            Return Me._Nombre_Declarante
        End Get
        Set(ByVal Value As String)
            If _Nombre_Declarante <> Value Then
                RaiseEvent Nombre_DeclaranteChanging(Value)
                Me._Nombre_Declarante = Value
                RaiseEvent Nombre_DeclaranteChanged()
            End If
        End Set
    End Property

    Public Event Identificacion_DeclaranteChanging(ByVal Value As String)
    Public Event Identificacion_DeclaranteChanged()

    Public Property Identificacion_Declarante() As String
        Get
            Return Me._Identificacion_Declarante
        End Get
        Set(ByVal Value As String)
            If _Identificacion_Declarante <> Value Then
                RaiseEvent Identificacion_DeclaranteChanging(Value)
                Me._Identificacion_Declarante = Value
                RaiseEvent Identificacion_DeclaranteChanged()
            End If
        End Set
    End Property

    Public Event Telefono_DeclaranteChanging(ByVal Value As String)
    Public Event Telefono_DeclaranteChanged()

    Public Property Telefono_Declarante() As String
        Get
            Return Me._Telefono_Declarante
        End Get
        Set(ByVal Value As String)
            If _Telefono_Declarante <> Value Then
                RaiseEvent Telefono_DeclaranteChanging(Value)
                Me._Telefono_Declarante = Value
                RaiseEvent Telefono_DeclaranteChanged()
            End If
        End Set
    End Property

    Public Event Direccion_DeclaranteChanging(ByVal Value As String)
    Public Event Direccion_DeclaranteChanged()

    Public Property Direccion_Declarante() As String
        Get
            Return Me._Direccion_Declarante
        End Get
        Set(ByVal Value As String)
            If _Direccion_Declarante <> Value Then
                RaiseEvent Direccion_DeclaranteChanging(Value)
                Me._Direccion_Declarante = Value
                RaiseEvent Direccion_DeclaranteChanged()
            End If
        End Set
    End Property

    Public Event Celular_DeclaranteChanging(ByVal Value As String)
    Public Event Celular_DeclaranteChanged()

    Public Property Celular_Declarante() As String
        Get
            Return Me._Celular_Declarante
        End Get
        Set(ByVal Value As String)
            If _Celular_Declarante <> Value Then
                RaiseEvent Celular_DeclaranteChanging(Value)
                Me._Celular_Declarante = Value
                RaiseEvent Celular_DeclaranteChanged()
            End If
        End Set
    End Property

    Public Event Barrio_DeclaranteChanging(ByVal Value As String)
    Public Event Barrio_DeclaranteChanged()

    Public Property Barrio_Declarante() As String
        Get
            Return Me._Barrio_Declarante
        End Get
        Set(ByVal Value As String)
            If _Barrio_Declarante <> Value Then
                RaiseEvent Barrio_DeclaranteChanging(Value)
                Me._Barrio_Declarante = Value
                RaiseEvent Barrio_DeclaranteChanged()
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

    Public Event CYDChanging(ByVal Value As String)
    Public Event CYDChanged()

    Public Property CYD() As String
        Get
            Return Me._CYD
        End Get
        Set(ByVal Value As String)
            If _CYD <> Value Then
                RaiseEvent CYDChanging(Value)
                Me._CYD = Value
                RaiseEvent CYDChanged()
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

    Public Event LactandoChanging(ByVal Value As String)
    Public Event LactandoChanged()

    Public Property Lactando() As String
        Get
            Return Me._Lactando
        End Get
        Set(ByVal Value As String)
            If _Lactando <> Value Then
                RaiseEvent LactandoChanging(Value)
                Me._Lactando = Value
                RaiseEvent LactandoChanged()
            End If
        End Set
    End Property

    Public Event Lactancia_MesesChanging(ByVal Value As Int32)
    Public Event Lactancia_MesesChanged()

    Public Property Lactancia_Meses() As Int32
        Get
            Return Me._Lactancia_Meses
        End Get
        Set(ByVal Value As Int32)
            If _Lactancia_Meses <> Value Then
                RaiseEvent Lactancia_MesesChanging(Value)
                Me._Lactancia_Meses = Value
                RaiseEvent Lactancia_MesesChanged()
            End If
        End Set
    End Property

    Public Event Lactancia_exclusivaChanging(ByVal Value As Int32)
    Public Event Lactancia_exclusivaChanged()

    Public Property Lactancia_exclusiva() As Int32
        Get
            Return Me._Lactancia_exclusiva
        End Get
        Set(ByVal Value As Int32)
            If _Lactancia_exclusiva <> Value Then
                RaiseEvent Lactancia_exclusivaChanging(Value)
                Me._Lactancia_exclusiva = Value
                RaiseEvent Lactancia_exclusivaChanged()
            End If
        End Set
    End Property

    Public Event DesparasitacionChanging(ByVal Value As String)
    Public Event DesparasitacionChanged()

    Public Property Desparasitacion() As String
        Get
            Return Me._Desparasitacion
        End Get
        Set(ByVal Value As String)
            If _Desparasitacion <> Value Then
                RaiseEvent DesparasitacionChanging(Value)
                Me._Desparasitacion = Value
                RaiseEvent DesparasitacionChanged()
            End If
        End Set
    End Property

    Public Event SuplementacionChanging(ByVal Value As String)
    Public Event SuplementacionChanged()

    Public Property Suplementacion() As String
        Get
            Return Me._Suplementacion
        End Get
        Set(ByVal Value As String)
            If _Suplementacion <> Value Then
                RaiseEvent SuplementacionChanging(Value)
                Me._Suplementacion = Value
                RaiseEvent SuplementacionChanged()
            End If
        End Set
    End Property

    Public Event CarnetChanging(ByVal Value As String)
    Public Event CarnetChanged()

    Public Property Carnet() As String
        Get
            Return Me._Carnet
        End Get
        Set(ByVal Value As String)
            If _Carnet <> Value Then
                RaiseEvent CarnetChanging(Value)
                Me._Carnet = Value
                RaiseEvent CarnetChanged()
            End If
        End Set
    End Property

    Public Event Motivo_NoCarnetChanging(ByVal Value As String)
    Public Event Motivo_NoCarnetChanged()

    Public Property Motivo_NoCarnet() As String
        Get
            Return Me._Motivo_NoCarnet
        End Get
        Set(ByVal Value As String)
            If _Motivo_NoCarnet <> Value Then
                RaiseEvent Motivo_NoCarnetChanging(Value)
                Me._Motivo_NoCarnet = Value
                RaiseEvent Motivo_NoCarnetChanged()
            End If
        End Set
    End Property

    Public Event VacunacionChanging(ByVal Value As String)
    Public Event VacunacionChanged()

    Public Property Vacunacion() As String
        Get
            Return Me._Vacunacion
        End Get
        Set(ByVal Value As String)
            If _Vacunacion <> Value Then
                RaiseEvent VacunacionChanging(Value)
                Me._Vacunacion = Value
                RaiseEvent VacunacionChanged()
            End If
        End Set
    End Property

    Public Event Motivo_No_VacunacionCompletaChanging(ByVal Value As String)
    Public Event Motivo_No_VacunacionCompletaChanged()

    Public Property Motivo_No_VacunacionCompleta() As String
        Get
            Return Me._Motivo_No_VacunacionCompleta
        End Get
        Set(ByVal Value As String)
            If _Motivo_No_VacunacionCompleta <> Value Then
                RaiseEvent Motivo_No_VacunacionCompletaChanging(Value)
                Me._Motivo_No_VacunacionCompleta = Value
                RaiseEvent Motivo_No_VacunacionCompletaChanged()
            End If
        End Set
    End Property

    Public Event VacunadosChanging(ByVal Value As String)
    Public Event VacunadosChanged()

    Public Property Vacunados() As String
        Get
            Return Me._Vacunados
        End Get
        Set(ByVal Value As String)
            If _Vacunados <> Value Then
                RaiseEvent VacunadosChanging(Value)
                Me._Vacunados = Value
                RaiseEvent VacunadosChanged()
            End If
        End Set
    End Property

    Public Event MotivoNoVacunadosChanging(ByVal Value As String)
    Public Event MotivoNoVacunadosChanged()

    Public Property MotivoNoVacunados() As String
        Get
            Return Me._MotivoNoVacunados
        End Get
        Set(ByVal Value As String)
            If _MotivoNoVacunados <> Value Then
                RaiseEvent MotivoNoVacunadosChanging(Value)
                Me._MotivoNoVacunados = Value
                RaiseEvent MotivoNoVacunadosChanged()
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

    Public Event Observaciones_SaludChanging(ByVal Value As String)
    Public Event Observaciones_SaludChanged()

    Public Property Observaciones_Salud() As String
        Get
            Return Me._Observaciones_Salud
        End Get
        Set(ByVal Value As String)
            If _Observaciones_Salud <> Value Then
                RaiseEvent Observaciones_SaludChanging(Value)
                Me._Observaciones_Salud = Value
                RaiseEvent Observaciones_SaludChanged()
            End If
        End Set
    End Property

    Public Event Fecha_Valoracion01Changing(ByVal Value As DateTime)
    Public Event Fecha_Valoracion01Changed()

    Public Property Fecha_Valoracion01() As DateTime
        Get
            Return Me._Fecha_Valoracion01
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_Valoracion01 <> Value Then
                RaiseEvent Fecha_Valoracion01Changing(Value)
                Me._Fecha_Valoracion01 = Value
                RaiseEvent Fecha_Valoracion01Changed()
            End If
        End Set
    End Property

    Public Event AntropometriaPeso01Changing(ByVal Value As Double)
    Public Event AntropometriaPeso01Changed()

    Public Property AntropometriaPeso01() As Double
        Get
            Return Me._AntropometriaPeso01
        End Get
        Set(ByVal Value As Double)
            If _AntropometriaPeso01 <> Value Then
                RaiseEvent AntropometriaPeso01Changing(Value)
                Me._AntropometriaPeso01 = Value
                RaiseEvent AntropometriaPeso01Changed()
            End If
        End Set
    End Property

    Public Event AntropometriaTalla01Changing(ByVal Value As Double)
    Public Event AntropometriaTalla01Changed()

    Public Property AntropometriaTalla01() As Double
        Get
            Return Me._AntropometriaTalla01
        End Get
        Set(ByVal Value As Double)
            If _AntropometriaTalla01 <> Value Then
                RaiseEvent AntropometriaTalla01Changing(Value)
                Me._AntropometriaTalla01 = Value
                RaiseEvent AntropometriaTalla01Changed()
            End If
        End Set
    End Property

    Public Event Antropometia_Perimetro_Branquial01Changing(ByVal Value As Double)
    Public Event Antropometia_Perimetro_Branquial01Changed()

    Public Property Antropometia_Perimetro_Branquial01() As Double
        Get
            Return Me._Antropometia_Perimetro_Branquial01
        End Get
        Set(ByVal Value As Double)
            If _Antropometia_Perimetro_Branquial01 <> Value Then
                RaiseEvent Antropometia_Perimetro_Branquial01Changing(Value)
                Me._Antropometia_Perimetro_Branquial01 = Value
                RaiseEvent Antropometia_Perimetro_Branquial01Changed()
            End If
        End Set
    End Property

    Public Event Recuperado01Changing(ByVal Value As String)
    Public Event Recuperado01Changed()

    Public Property Recuperado01() As String
        Get
            Return Me._Recuperado01
        End Get
        Set(ByVal Value As String)
            If _Recuperado01 <> Value Then
                RaiseEvent Recuperado01Changing(Value)
                Me._Recuperado01 = Value
                RaiseEvent Recuperado01Changed()
            End If
        End Set
    End Property

    Public Event Observaciones01Changing(ByVal Value As String)
    Public Event Observaciones01Changed()

    Public Property Observaciones01() As String
        Get
            Return Me._Observaciones01
        End Get
        Set(ByVal Value As String)
            If _Observaciones01 <> Value Then
                RaiseEvent Observaciones01Changing(Value)
                Me._Observaciones01 = Value
                RaiseEvent Observaciones01Changed()
            End If
        End Set
    End Property

    Public Event PesoTalla01Changing(ByVal Value As String)
    Public Event PesoTalla01Changed()

    Public Property PesoTalla01() As String
        Get
            Return Me._PesoTalla01
        End Get
        Set(ByVal Value As String)
            If _PesoTalla01 <> Value Then
                RaiseEvent PesoTalla01Changing(Value)
                Me._PesoTalla01 = Value
                RaiseEvent PesoTalla01Changed()
            End If
        End Set
    End Property

    Public Event PesoEdad01Changing(ByVal Value As String)
    Public Event PesoEdad01Changed()

    Public Property PesoEdad01() As String
        Get
            Return Me._PesoEdad01
        End Get
        Set(ByVal Value As String)
            If _PesoEdad01 <> Value Then
                RaiseEvent PesoEdad01Changing(Value)
                Me._PesoEdad01 = Value
                RaiseEvent PesoEdad01Changed()
            End If
        End Set
    End Property

    Public Event TallaLongitud01Changing(ByVal Value As String)
    Public Event TallaLongitud01Changed()

    Public Property TallaLongitud01() As String
        Get
            Return Me._TallaLongitud01
        End Get
        Set(ByVal Value As String)
            If _TallaLongitud01 <> Value Then
                RaiseEvent TallaLongitud01Changing(Value)
                Me._TallaLongitud01 = Value
                RaiseEvent TallaLongitud01Changed()
            End If
        End Set
    End Property

    Public Event IMC_Edad01Changing(ByVal Value As String)
    Public Event IMC_Edad01Changed()

    Public Property IMC_Edad01() As String
        Get
            Return Me._IMC_Edad01
        End Get
        Set(ByVal Value As String)
            If _IMC_Edad01 <> Value Then
                RaiseEvent IMC_Edad01Changing(Value)
                Me._IMC_Edad01 = Value
                RaiseEvent IMC_Edad01Changed()
            End If
        End Set
    End Property

    Public Event Edad01Changing(ByVal Value As Int32)
    Public Event Edad01Changed()

    Public Property Edad01() As Int32
        Get
            Return Me._Edad01
        End Get
        Set(ByVal Value As Int32)
            If _Edad01 <> Value Then
                RaiseEvent Edad01Changing(Value)
                Me._Edad01 = Value
                RaiseEvent Edad01Changed()
            End If
        End Set
    End Property

    Public Event Meses01Changing(ByVal Value As Int32)
    Public Event Meses01Changed()

    Public Property Meses01() As Int32
        Get
            Return Me._Meses01
        End Get
        Set(ByVal Value As Int32)
            If _Meses01 <> Value Then
                RaiseEvent Meses01Changing(Value)
                Me._Meses01 = Value
                RaiseEvent Meses01Changed()
            End If
        End Set
    End Property

    Public Event TallaParaEdad01Changing(ByVal Value As String)
    Public Event TallaParaEdad01Changed()

    Public Property TallaParaEdad01() As String
        Get
            Return Me._TallaParaEdad01
        End Get
        Set(ByVal Value As String)
            If _TallaParaEdad01 <> Value Then
                RaiseEvent TallaParaEdad01Changing(Value)
                Me._TallaParaEdad01 = Value
                RaiseEvent TallaParaEdad01Changed()
            End If
        End Set
    End Property

    Public Event EstadoNutricional01Changing(ByVal Value As String)
    Public Event EstadoNutricional01Changed()

    Public Property EstadoNutricional01() As String
        Get
            Return Me._EstadoNutricional01
        End Get
        Set(ByVal Value As String)
            If _EstadoNutricional01 <> Value Then
                RaiseEvent EstadoNutricional01Changing(Value)
                Me._EstadoNutricional01 = Value
                RaiseEvent EstadoNutricional01Changed()
            End If
        End Set
    End Property

    Public Event Fecha_Valoracion02Changing(ByVal Value As DateTime)
    Public Event Fecha_Valoracion02Changed()

    Public Property Fecha_Valoracion02() As DateTime
        Get
            Return Me._Fecha_Valoracion02
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_Valoracion02 <> Value Then
                RaiseEvent Fecha_Valoracion02Changing(Value)
                Me._Fecha_Valoracion02 = Value
                RaiseEvent Fecha_Valoracion02Changed()
            End If
        End Set
    End Property

    Public Event AntropometriaPeso02Changing(ByVal Value As Double)
    Public Event AntropometriaPeso02Changed()

    Public Property AntropometriaPeso02() As Double
        Get
            Return Me._AntropometriaPeso02
        End Get
        Set(ByVal Value As Double)
            If _AntropometriaPeso02 <> Value Then
                RaiseEvent AntropometriaPeso02Changing(Value)
                Me._AntropometriaPeso02 = Value
                RaiseEvent AntropometriaPeso02Changed()
            End If
        End Set
    End Property

    Public Event AntropometriaTalla02Changing(ByVal Value As Double)
    Public Event AntropometriaTalla02Changed()

    Public Property AntropometriaTalla02() As Double
        Get
            Return Me._AntropometriaTalla02
        End Get
        Set(ByVal Value As Double)
            If _AntropometriaTalla02 <> Value Then
                RaiseEvent AntropometriaTalla02Changing(Value)
                Me._AntropometriaTalla02 = Value
                RaiseEvent AntropometriaTalla02Changed()
            End If
        End Set
    End Property

    Public Event Antropometia_Perimetro_Branquial02Changing(ByVal Value As Double)
    Public Event Antropometia_Perimetro_Branquial02Changed()

    Public Property Antropometia_Perimetro_Branquial02() As Double
        Get
            Return Me._Antropometia_Perimetro_Branquial02
        End Get
        Set(ByVal Value As Double)
            If _Antropometia_Perimetro_Branquial02 <> Value Then
                RaiseEvent Antropometia_Perimetro_Branquial02Changing(Value)
                Me._Antropometia_Perimetro_Branquial02 = Value
                RaiseEvent Antropometia_Perimetro_Branquial02Changed()
            End If
        End Set
    End Property

    Public Event Recuperado02Changing(ByVal Value As String)
    Public Event Recuperado02Changed()

    Public Property Recuperado02() As String
        Get
            Return Me._Recuperado02
        End Get
        Set(ByVal Value As String)
            If _Recuperado02 <> Value Then
                RaiseEvent Recuperado02Changing(Value)
                Me._Recuperado02 = Value
                RaiseEvent Recuperado02Changed()
            End If
        End Set
    End Property

    Public Event Observaciones02Changing(ByVal Value As String)
    Public Event Observaciones02Changed()

    Public Property Observaciones02() As String
        Get
            Return Me._Observaciones02
        End Get
        Set(ByVal Value As String)
            If _Observaciones02 <> Value Then
                RaiseEvent Observaciones02Changing(Value)
                Me._Observaciones02 = Value
                RaiseEvent Observaciones02Changed()
            End If
        End Set
    End Property

    Public Event PesoTalla02Changing(ByVal Value As String)
    Public Event PesoTalla02Changed()

    Public Property PesoTalla02() As String
        Get
            Return Me._PesoTalla02
        End Get
        Set(ByVal Value As String)
            If _PesoTalla02 <> Value Then
                RaiseEvent PesoTalla02Changing(Value)
                Me._PesoTalla02 = Value
                RaiseEvent PesoTalla02Changed()
            End If
        End Set
    End Property

    Public Event PesoEdad02Changing(ByVal Value As String)
    Public Event PesoEdad02Changed()

    Public Property PesoEdad02() As String
        Get
            Return Me._PesoEdad02
        End Get
        Set(ByVal Value As String)
            If _PesoEdad02 <> Value Then
                RaiseEvent PesoEdad02Changing(Value)
                Me._PesoEdad02 = Value
                RaiseEvent PesoEdad02Changed()
            End If
        End Set
    End Property

    Public Event TallaLongitud02Changing(ByVal Value As String)
    Public Event TallaLongitud02Changed()

    Public Property TallaLongitud02() As String
        Get
            Return Me._TallaLongitud02
        End Get
        Set(ByVal Value As String)
            If _TallaLongitud02 <> Value Then
                RaiseEvent TallaLongitud02Changing(Value)
                Me._TallaLongitud02 = Value
                RaiseEvent TallaLongitud02Changed()
            End If
        End Set
    End Property

    Public Event IMC_Edad02Changing(ByVal Value As String)
    Public Event IMC_Edad02Changed()

    Public Property IMC_Edad02() As String
        Get
            Return Me._IMC_Edad02
        End Get
        Set(ByVal Value As String)
            If _IMC_Edad02 <> Value Then
                RaiseEvent IMC_Edad02Changing(Value)
                Me._IMC_Edad02 = Value
                RaiseEvent IMC_Edad02Changed()
            End If
        End Set
    End Property

    Public Event Edad02Changing(ByVal Value As Int32)
    Public Event Edad02Changed()

    Public Property Edad02() As Int32
        Get
            Return Me._Edad02
        End Get
        Set(ByVal Value As Int32)
            If _Edad02 <> Value Then
                RaiseEvent Edad02Changing(Value)
                Me._Edad02 = Value
                RaiseEvent Edad02Changed()
            End If
        End Set
    End Property

    Public Event Meses02Changing(ByVal Value As Int32)
    Public Event Meses02Changed()

    Public Property Meses02() As Int32
        Get
            Return Me._Meses02
        End Get
        Set(ByVal Value As Int32)
            If _Meses02 <> Value Then
                RaiseEvent Meses02Changing(Value)
                Me._Meses02 = Value
                RaiseEvent Meses02Changed()
            End If
        End Set
    End Property

    Public Event TallaParaEdad02Changing(ByVal Value As String)
    Public Event TallaParaEdad02Changed()

    Public Property TallaParaEdad02() As String
        Get
            Return Me._TallaParaEdad02
        End Get
        Set(ByVal Value As String)
            If _TallaParaEdad02 <> Value Then
                RaiseEvent TallaParaEdad02Changing(Value)
                Me._TallaParaEdad02 = Value
                RaiseEvent TallaParaEdad02Changed()
            End If
        End Set
    End Property

    Public Event EstadoNutricional02Changing(ByVal Value As String)
    Public Event EstadoNutricional02Changed()

    Public Property EstadoNutricional02() As String
        Get
            Return Me._EstadoNutricional02
        End Get
        Set(ByVal Value As String)
            If _EstadoNutricional02 <> Value Then
                RaiseEvent EstadoNutricional02Changing(Value)
                Me._EstadoNutricional02 = Value
                RaiseEvent EstadoNutricional02Changed()
            End If
        End Set
    End Property

    Public Event Fecha_Valoracion03Changing(ByVal Value As DateTime)
    Public Event Fecha_Valoracion03Changed()

    Public Property Fecha_Valoracion03() As DateTime
        Get
            Return Me._Fecha_Valoracion03
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_Valoracion03 <> Value Then
                RaiseEvent Fecha_Valoracion03Changing(Value)
                Me._Fecha_Valoracion03 = Value
                RaiseEvent Fecha_Valoracion03Changed()
            End If
        End Set
    End Property

    Public Event AntropometriaPeso03Changing(ByVal Value As Double)
    Public Event AntropometriaPeso03Changed()

    Public Property AntropometriaPeso03() As Double
        Get
            Return Me._AntropometriaPeso03
        End Get
        Set(ByVal Value As Double)
            If _AntropometriaPeso03 <> Value Then
                RaiseEvent AntropometriaPeso03Changing(Value)
                Me._AntropometriaPeso03 = Value
                RaiseEvent AntropometriaPeso03Changed()
            End If
        End Set
    End Property

    Public Event AntropometriaTalla03Changing(ByVal Value As Double)
    Public Event AntropometriaTalla03Changed()

    Public Property AntropometriaTalla03() As Double
        Get
            Return Me._AntropometriaTalla03
        End Get
        Set(ByVal Value As Double)
            If _AntropometriaTalla03 <> Value Then
                RaiseEvent AntropometriaTalla03Changing(Value)
                Me._AntropometriaTalla03 = Value
                RaiseEvent AntropometriaTalla03Changed()
            End If
        End Set
    End Property

    Public Event Antropometia_Perimetro_Branquial03Changing(ByVal Value As Double)
    Public Event Antropometia_Perimetro_Branquial03Changed()

    Public Property Antropometia_Perimetro_Branquial03() As Double
        Get
            Return Me._Antropometia_Perimetro_Branquial03
        End Get
        Set(ByVal Value As Double)
            If _Antropometia_Perimetro_Branquial03 <> Value Then
                RaiseEvent Antropometia_Perimetro_Branquial03Changing(Value)
                Me._Antropometia_Perimetro_Branquial03 = Value
                RaiseEvent Antropometia_Perimetro_Branquial03Changed()
            End If
        End Set
    End Property

    Public Event Recuperado03Changing(ByVal Value As String)
    Public Event Recuperado03Changed()

    Public Property Recuperado03() As String
        Get
            Return Me._Recuperado03
        End Get
        Set(ByVal Value As String)
            If _Recuperado03 <> Value Then
                RaiseEvent Recuperado03Changing(Value)
                Me._Recuperado03 = Value
                RaiseEvent Recuperado03Changed()
            End If
        End Set
    End Property

    Public Event Observaciones03Changing(ByVal Value As String)
    Public Event Observaciones03Changed()

    Public Property Observaciones03() As String
        Get
            Return Me._Observaciones03
        End Get
        Set(ByVal Value As String)
            If _Observaciones03 <> Value Then
                RaiseEvent Observaciones03Changing(Value)
                Me._Observaciones03 = Value
                RaiseEvent Observaciones03Changed()
            End If
        End Set
    End Property

    Public Event PesoTalla03Changing(ByVal Value As String)
    Public Event PesoTalla03Changed()

    Public Property PesoTalla03() As String
        Get
            Return Me._PesoTalla03
        End Get
        Set(ByVal Value As String)
            If _PesoTalla03 <> Value Then
                RaiseEvent PesoTalla03Changing(Value)
                Me._PesoTalla03 = Value
                RaiseEvent PesoTalla03Changed()
            End If
        End Set
    End Property

    Public Event PesoEdad03Changing(ByVal Value As String)
    Public Event PesoEdad03Changed()

    Public Property PesoEdad03() As String
        Get
            Return Me._PesoEdad03
        End Get
        Set(ByVal Value As String)
            If _PesoEdad03 <> Value Then
                RaiseEvent PesoEdad03Changing(Value)
                Me._PesoEdad03 = Value
                RaiseEvent PesoEdad03Changed()
            End If
        End Set
    End Property

    Public Event TallaLongitud03Changing(ByVal Value As String)
    Public Event TallaLongitud03Changed()

    Public Property TallaLongitud03() As String
        Get
            Return Me._TallaLongitud03
        End Get
        Set(ByVal Value As String)
            If _TallaLongitud03 <> Value Then
                RaiseEvent TallaLongitud03Changing(Value)
                Me._TallaLongitud03 = Value
                RaiseEvent TallaLongitud03Changed()
            End If
        End Set
    End Property

    Public Event IMC_Edad03Changing(ByVal Value As String)
    Public Event IMC_Edad03Changed()

    Public Property IMC_Edad03() As String
        Get
            Return Me._IMC_Edad03
        End Get
        Set(ByVal Value As String)
            If _IMC_Edad03 <> Value Then
                RaiseEvent IMC_Edad03Changing(Value)
                Me._IMC_Edad03 = Value
                RaiseEvent IMC_Edad03Changed()
            End If
        End Set
    End Property

    Public Event Edad03Changing(ByVal Value As Int32)
    Public Event Edad03Changed()

    Public Property Edad03() As Int32
        Get
            Return Me._Edad03
        End Get
        Set(ByVal Value As Int32)
            If _Edad03 <> Value Then
                RaiseEvent Edad03Changing(Value)
                Me._Edad03 = Value
                RaiseEvent Edad03Changed()
            End If
        End Set
    End Property

    Public Event Meses03Changing(ByVal Value As Int32)
    Public Event Meses03Changed()

    Public Property Meses03() As Int32
        Get
            Return Me._Meses03
        End Get
        Set(ByVal Value As Int32)
            If _Meses03 <> Value Then
                RaiseEvent Meses03Changing(Value)
                Me._Meses03 = Value
                RaiseEvent Meses03Changed()
            End If
        End Set
    End Property

    Public Event TallaParaEdad03Changing(ByVal Value As String)
    Public Event TallaParaEdad03Changed()

    Public Property TallaParaEdad03() As String
        Get
            Return Me._TallaParaEdad03
        End Get
        Set(ByVal Value As String)
            If _TallaParaEdad03 <> Value Then
                RaiseEvent TallaParaEdad03Changing(Value)
                Me._TallaParaEdad03 = Value
                RaiseEvent TallaParaEdad03Changed()
            End If
        End Set
    End Property

    Public Event EstadoNutricional03Changing(ByVal Value As String)
    Public Event EstadoNutricional03Changed()

    Public Property EstadoNutricional03() As String
        Get
            Return Me._EstadoNutricional03
        End Get
        Set(ByVal Value As String)
            If _EstadoNutricional03 <> Value Then
                RaiseEvent EstadoNutricional03Changing(Value)
                Me._EstadoNutricional03 = Value
                RaiseEvent EstadoNutricional03Changed()
            End If
        End Set
    End Property

    Public Event Fecha_ValoracionSegChanging(ByVal Value As DateTime)
    Public Event Fecha_ValoracionSegChanged()

    Public Property Fecha_ValoracionSeg() As DateTime
        Get
            Return Me._Fecha_ValoracionSeg
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_ValoracionSeg <> Value Then
                RaiseEvent Fecha_ValoracionSegChanging(Value)
                Me._Fecha_ValoracionSeg = Value
                RaiseEvent Fecha_ValoracionSegChanged()
            End If
        End Set
    End Property

    Public Event AntropometriaPesoSegChanging(ByVal Value As Double)
    Public Event AntropometriaPesoSegChanged()

    Public Property AntropometriaPesoSeg() As Double
        Get
            Return Me._AntropometriaPesoSeg
        End Get
        Set(ByVal Value As Double)
            If _AntropometriaPesoSeg <> Value Then
                RaiseEvent AntropometriaPesoSegChanging(Value)
                Me._AntropometriaPesoSeg = Value
                RaiseEvent AntropometriaPesoSegChanged()
            End If
        End Set
    End Property

    Public Event AntropometriaTallaSegChanging(ByVal Value As Double)
    Public Event AntropometriaTallaSegChanged()

    Public Property AntropometriaTallaSeg() As Double
        Get
            Return Me._AntropometriaTallaSeg
        End Get
        Set(ByVal Value As Double)
            If _AntropometriaTallaSeg <> Value Then
                RaiseEvent AntropometriaTallaSegChanging(Value)
                Me._AntropometriaTallaSeg = Value
                RaiseEvent AntropometriaTallaSegChanged()
            End If
        End Set
    End Property

    Public Event Antropometia_Perimetro_BranquialSegChanging(ByVal Value As Double)
    Public Event Antropometia_Perimetro_BranquialSegChanged()

    Public Property Antropometia_Perimetro_BranquialSeg() As Double
        Get
            Return Me._Antropometia_Perimetro_BranquialSeg
        End Get
        Set(ByVal Value As Double)
            If _Antropometia_Perimetro_BranquialSeg <> Value Then
                RaiseEvent Antropometia_Perimetro_BranquialSegChanging(Value)
                Me._Antropometia_Perimetro_BranquialSeg = Value
                RaiseEvent Antropometia_Perimetro_BranquialSegChanged()
            End If
        End Set
    End Property

    Public Event RecuperadoSegChanging(ByVal Value As String)
    Public Event RecuperadoSegChanged()

    Public Property RecuperadoSeg() As String
        Get
            Return Me._RecuperadoSeg
        End Get
        Set(ByVal Value As String)
            If _RecuperadoSeg <> Value Then
                RaiseEvent RecuperadoSegChanging(Value)
                Me._RecuperadoSeg = Value
                RaiseEvent RecuperadoSegChanged()
            End If
        End Set
    End Property

    Public Event ObservacionesSegChanging(ByVal Value As String)
    Public Event ObservacionesSegChanged()

    Public Property ObservacionesSeg() As String
        Get
            Return Me._ObservacionesSeg
        End Get
        Set(ByVal Value As String)
            If _ObservacionesSeg <> Value Then
                RaiseEvent ObservacionesSegChanging(Value)
                Me._ObservacionesSeg = Value
                RaiseEvent ObservacionesSegChanged()
            End If
        End Set
    End Property

    Public Event PesoTallaSegChanging(ByVal Value As String)
    Public Event PesoTallaSegChanged()

    Public Property PesoTallaSeg() As String
        Get
            Return Me._PesoTallaSeg
        End Get
        Set(ByVal Value As String)
            If _PesoTallaSeg <> Value Then
                RaiseEvent PesoTallaSegChanging(Value)
                Me._PesoTallaSeg = Value
                RaiseEvent PesoTallaSegChanged()
            End If
        End Set
    End Property

    Public Event PesoEdadSegChanging(ByVal Value As String)
    Public Event PesoEdadSegChanged()

    Public Property PesoEdadSeg() As String
        Get
            Return Me._PesoEdadSeg
        End Get
        Set(ByVal Value As String)
            If _PesoEdadSeg <> Value Then
                RaiseEvent PesoEdadSegChanging(Value)
                Me._PesoEdadSeg = Value
                RaiseEvent PesoEdadSegChanged()
            End If
        End Set
    End Property

    Public Event TallaLongitudSegChanging(ByVal Value As String)
    Public Event TallaLongitudSegChanged()

    Public Property TallaLongitudSeg() As String
        Get
            Return Me._TallaLongitudSeg
        End Get
        Set(ByVal Value As String)
            If _TallaLongitudSeg <> Value Then
                RaiseEvent TallaLongitudSegChanging(Value)
                Me._TallaLongitudSeg = Value
                RaiseEvent TallaLongitudSegChanged()
            End If
        End Set
    End Property

    Public Event IMC_EdadSegChanging(ByVal Value As String)
    Public Event IMC_EdadSegChanged()

    Public Property IMC_EdadSeg() As String
        Get
            Return Me._IMC_EdadSeg
        End Get
        Set(ByVal Value As String)
            If _IMC_EdadSeg <> Value Then
                RaiseEvent IMC_EdadSegChanging(Value)
                Me._IMC_EdadSeg = Value
                RaiseEvent IMC_EdadSegChanged()
            End If
        End Set
    End Property

    Public Event EdadSegChanging(ByVal Value As Int32)
    Public Event EdadSegChanged()

    Public Property EdadSeg() As Int32
        Get
            Return Me._EdadSeg
        End Get
        Set(ByVal Value As Int32)
            If _EdadSeg <> Value Then
                RaiseEvent EdadSegChanging(Value)
                Me._EdadSeg = Value
                RaiseEvent EdadSegChanged()
            End If
        End Set
    End Property

    Public Event MesesSegChanging(ByVal Value As Int32)
    Public Event MesesSegChanged()

    Public Property MesesSeg() As Int32
        Get
            Return Me._MesesSeg
        End Get
        Set(ByVal Value As Int32)
            If _MesesSeg <> Value Then
                RaiseEvent MesesSegChanging(Value)
                Me._MesesSeg = Value
                RaiseEvent MesesSegChanged()
            End If
        End Set
    End Property

    Public Event TallaParaEdadSegChanging(ByVal Value As String)
    Public Event TallaParaEdadSegChanged()

    Public Property TallaParaEdadSeg() As String
        Get
            Return Me._TallaParaEdadSeg
        End Get
        Set(ByVal Value As String)
            If _TallaParaEdadSeg <> Value Then
                RaiseEvent TallaParaEdadSegChanging(Value)
                Me._TallaParaEdadSeg = Value
                RaiseEvent TallaParaEdadSegChanged()
            End If
        End Set
    End Property

    Public Event EstadoNutricionalSegChanging(ByVal Value As String)
    Public Event EstadoNutricionalSegChanged()

    Public Property EstadoNutricionalSeg() As String
        Get
            Return Me._EstadoNutricionalSeg
        End Get
        Set(ByVal Value As String)
            If _EstadoNutricionalSeg <> Value Then
                RaiseEvent EstadoNutricionalSegChanging(Value)
                Me._EstadoNutricionalSeg = Value
                RaiseEvent EstadoNutricionalSegChanged()
            End If
        End Set
    End Property

    Public Event FechaRemision01Changing(ByVal Value As DateTime)
    Public Event FechaRemision01Changed()

    Public Property FechaRemision01() As DateTime
        Get
            Return Me._FechaRemision01
        End Get
        Set(ByVal Value As DateTime)
            If _FechaRemision01 <> Value Then
                RaiseEvent FechaRemision01Changing(Value)
                Me._FechaRemision01 = Value
                RaiseEvent FechaRemision01Changed()
            End If
        End Set
    End Property

    Public Event FechaRealizado01Changing(ByVal Value As DateTime)
    Public Event FechaRealizado01Changed()

    Public Property FechaRealizado01() As DateTime
        Get
            Return Me._FechaRealizado01
        End Get
        Set(ByVal Value As DateTime)
            If _FechaRealizado01 <> Value Then
                RaiseEvent FechaRealizado01Changing(Value)
                Me._FechaRealizado01 = Value
                RaiseEvent FechaRealizado01Changed()
            End If
        End Set
    End Property

    Public Event EntidadRemision01Changing(ByVal Value As String)
    Public Event EntidadRemision01Changed()

    Public Property EntidadRemision01() As String
        Get
            Return Me._EntidadRemision01
        End Get
        Set(ByVal Value As String)
            If _EntidadRemision01 <> Value Then
                RaiseEvent EntidadRemision01Changing(Value)
                Me._EntidadRemision01 = Value
                RaiseEvent EntidadRemision01Changed()
            End If
        End Set
    End Property

    Public Event ServicioRemision01Changing(ByVal Value As String)
    Public Event ServicioRemision01Changed()

    Public Property ServicioRemision01() As String
        Get
            Return Me._ServicioRemision01
        End Get
        Set(ByVal Value As String)
            If _ServicioRemision01 <> Value Then
                RaiseEvent ServicioRemision01Changing(Value)
                Me._ServicioRemision01 = Value
                RaiseEvent ServicioRemision01Changed()
            End If
        End Set
    End Property

    Public Event FechaRemision02Changing(ByVal Value As DateTime)
    Public Event FechaRemision02Changed()

    Public Property FechaRemision02() As DateTime
        Get
            Return Me._FechaRemision02
        End Get
        Set(ByVal Value As DateTime)
            If _FechaRemision02 <> Value Then
                RaiseEvent FechaRemision02Changing(Value)
                Me._FechaRemision02 = Value
                RaiseEvent FechaRemision02Changed()
            End If
        End Set
    End Property

    Public Event FechaRealizado02Changing(ByVal Value As DateTime)
    Public Event FechaRealizado02Changed()

    Public Property FechaRealizado02() As DateTime
        Get
            Return Me._FechaRealizado02
        End Get
        Set(ByVal Value As DateTime)
            If _FechaRealizado02 <> Value Then
                RaiseEvent FechaRealizado02Changing(Value)
                Me._FechaRealizado02 = Value
                RaiseEvent FechaRealizado02Changed()
            End If
        End Set
    End Property

    Public Event EntidadRemision02Changing(ByVal Value As String)
    Public Event EntidadRemision02Changed()

    Public Property EntidadRemision02() As String
        Get
            Return Me._EntidadRemision02
        End Get
        Set(ByVal Value As String)
            If _EntidadRemision02 <> Value Then
                RaiseEvent EntidadRemision02Changing(Value)
                Me._EntidadRemision02 = Value
                RaiseEvent EntidadRemision02Changed()
            End If
        End Set
    End Property

    Public Event ServicioRemision02Changing(ByVal Value As String)
    Public Event ServicioRemision02Changed()

    Public Property ServicioRemision02() As String
        Get
            Return Me._ServicioRemision02
        End Get
        Set(ByVal Value As String)
            If _ServicioRemision02 <> Value Then
                RaiseEvent ServicioRemision02Changing(Value)
                Me._ServicioRemision02 = Value
                RaiseEvent ServicioRemision02Changed()
            End If
        End Set
    End Property

    Public Event FechaRemision03Changing(ByVal Value As DateTime)
    Public Event FechaRemision03Changed()

    Public Property FechaRemision03() As DateTime
        Get
            Return Me._FechaRemision03
        End Get
        Set(ByVal Value As DateTime)
            If _FechaRemision03 <> Value Then
                RaiseEvent FechaRemision03Changing(Value)
                Me._FechaRemision03 = Value
                RaiseEvent FechaRemision03Changed()
            End If
        End Set
    End Property

    Public Event FechaRealizado03Changing(ByVal Value As DateTime)
    Public Event FechaRealizado03Changed()

    Public Property FechaRealizado03() As DateTime
        Get
            Return Me._FechaRealizado03
        End Get
        Set(ByVal Value As DateTime)
            If _FechaRealizado03 <> Value Then
                RaiseEvent FechaRealizado03Changing(Value)
                Me._FechaRealizado03 = Value
                RaiseEvent FechaRealizado03Changed()
            End If
        End Set
    End Property

    Public Event EntidadRemision03Changing(ByVal Value As String)
    Public Event EntidadRemision03Changed()

    Public Property EntidadRemision03() As String
        Get
            Return Me._EntidadRemision03
        End Get
        Set(ByVal Value As String)
            If _EntidadRemision03 <> Value Then
                RaiseEvent EntidadRemision03Changing(Value)
                Me._EntidadRemision03 = Value
                RaiseEvent EntidadRemision03Changed()
            End If
        End Set
    End Property

    Public Event ServicioRemision03Changing(ByVal Value As String)
    Public Event ServicioRemision03Changed()

    Public Property ServicioRemision03() As String
        Get
            Return Me._ServicioRemision03
        End Get
        Set(ByVal Value As String)
            If _ServicioRemision03 <> Value Then
                RaiseEvent ServicioRemision03Changing(Value)
                Me._ServicioRemision03 = Value
                RaiseEvent ServicioRemision03Changed()
            End If
        End Set
    End Property

    Public Event RegionalChanging(ByVal Value As String)
    Public Event RegionalChanged()

    Public Property Regional() As String
        Get
            Return Me._Regional
        End Get
        Set(ByVal Value As String)
            If _Regional <> Value Then
                RaiseEvent RegionalChanging(Value)
                Me._Regional = Value
                RaiseEvent RegionalChanged()
            End If
        End Set
    End Property

    Public Event LugarEntregaChanging(ByVal Value As String)
    Public Event LugarEntregaChanged()

    Public Property LugarEntrega() As String
        Get
            Return Me._LugarEntrega
        End Get
        Set(ByVal Value As String)
            If _LugarEntrega <> Value Then
                RaiseEvent LugarEntregaChanging(Value)
                Me._LugarEntrega = Value
                RaiseEvent LugarEntregaChanged()
            End If
        End Set
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
            Me.ID = Tmp_SaludDAL.Insertar(Id_Usuario, DescripcionGrupo, Declarante, Tipo_Identificacion, Identificacion, Edad, Nombre_Completo, Genero, Fecha_Nacimiento, Nombre_Declarante, Identificacion_Declarante, Id_Persona, CYD, Patologia, Lactando, Lactancia_Meses, Lactancia_exclusiva, Desparasitacion, Suplementacion, Carnet, Motivo_NoCarnet, Vacunacion, Motivo_No_VacunacionCompleta, Vacunados, MotivoNoVacunados, Fecha_Esquema_Vacunacion, Observaciones_Salud, Fecha_Valoracion01, AntropometriaPeso01, AntropometriaTalla01, Antropometia_Perimetro_Branquial01, Recuperado01, Observaciones01, PesoTalla01, PesoEdad01, TallaLongitud01, IMC_Edad01, Edad01, Meses01, TallaParaEdad01, EstadoNutricional01, Fecha_Valoracion02, AntropometriaPeso02, AntropometriaTalla02, Antropometia_Perimetro_Branquial02, Recuperado02, Observaciones02, PesoTalla02, PesoEdad02, TallaLongitud02, IMC_Edad02, Edad02, Meses02, TallaParaEdad02, EstadoNutricional02, Fecha_Valoracion03, AntropometriaPeso03, AntropometriaTalla03, Antropometia_Perimetro_Branquial03, Recuperado03, Observaciones03, PesoTalla03, PesoEdad03, TallaLongitud03, IMC_Edad03, Edad03, Meses03, TallaParaEdad03, EstadoNutricional03, Fecha_ValoracionSeg, AntropometriaPesoSeg, AntropometriaTallaSeg, Antropometia_Perimetro_BranquialSeg, RecuperadoSeg, ObservacionesSeg, PesoTallaSeg, PesoEdadSeg, TallaLongitudSeg, IMC_EdadSeg, EdadSeg, MesesSeg, TallaParaEdadSeg, EstadoNutricionalSeg, FechaRemision01, FechaRealizado01, EntidadRemision01, ServicioRemision01, FechaRemision02, FechaRealizado02, EntidadRemision02, ServicioRemision02, FechaRemision03, FechaRealizado03, EntidadRemision03, ServicioRemision03)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            Tmp_SaludDAL.Actualizar(ID, Id_Usuario, DescripcionGrupo, Declarante, Tipo_Identificacion, Identificacion, Edad, Nombre_Completo, Genero, Fecha_Nacimiento, Nombre_Declarante, Identificacion_Declarante, Id_Persona, CYD, Patologia, Lactando, Lactancia_Meses, Lactancia_exclusiva, Desparasitacion, Suplementacion, Carnet, Motivo_NoCarnet, Vacunacion, Motivo_No_VacunacionCompleta, Vacunados, MotivoNoVacunados, Fecha_Esquema_Vacunacion, Observaciones_Salud, Fecha_Valoracion01, AntropometriaPeso01, AntropometriaTalla01, Antropometia_Perimetro_Branquial01, Recuperado01, Observaciones01, PesoTalla01, PesoEdad01, TallaLongitud01, IMC_Edad01, Edad01, Meses01, TallaParaEdad01, EstadoNutricional01, Fecha_Valoracion02, AntropometriaPeso02, AntropometriaTalla02, Antropometia_Perimetro_Branquial02, Recuperado02, Observaciones02, PesoTalla02, PesoEdad02, TallaLongitud02, IMC_Edad02, Edad02, Meses02, TallaParaEdad02, EstadoNutricional02, Fecha_Valoracion03, AntropometriaPeso03, AntropometriaTalla03, Antropometia_Perimetro_Branquial03, Recuperado03, Observaciones03, PesoTalla03, PesoEdad03, TallaLongitud03, IMC_Edad03, Edad03, Meses03, TallaParaEdad03, EstadoNutricional03, Fecha_ValoracionSeg, AntropometriaPesoSeg, AntropometriaTallaSeg, Antropometia_Perimetro_BranquialSeg, RecuperadoSeg, ObservacionesSeg, PesoTallaSeg, PesoEdadSeg, TallaLongitudSeg, IMC_EdadSeg, EdadSeg, MesesSeg, TallaParaEdadSeg, EstadoNutricionalSeg, FechaRemision01, FechaRealizado01, EntidadRemision01, ServicioRemision01, FechaRemision02, FechaRealizado02, EntidadRemision02, ServicioRemision02, FechaRemision03, FechaRealizado03, EntidadRemision03, ServicioRemision03)
            RaiseEvent Updated()
        End If

        RaiseEvent Saved()

    End Sub

    Public Sub Eliminar()
        Dim totalHijos As Long = 0
        If Me.ID <> Nothing Then

            RaiseEvent Deleting()
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            Tmp_SaludDAL.Eliminar(Me.ID)
            RaiseEvent Deleted()

        End If
    End Sub

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Tmp_SaludBrl

        Dim objTmp_Salud As New Tmp_SaludBrl

        With objTmp_Salud
            .ID = fila("Id")
            .Id_Usuario = isDBNullToNothing(fila("Id_Usuario"))
            .DescripcionGrupo = isDBNullToNothing(fila("DescripcionGrupo"))
            .Declarante = isDBNullToNothing(fila("Declarante"))
            .Tipo_Identificacion = isDBNullToNothing(fila("Tipo_Identificacion"))
            .Identificacion = isDBNullToNothing(fila("Identificacion"))
            .Edad = isDBNullToNothing(fila("Edad"))
            .Nombre_Completo = isDBNullToNothing(fila("Nombre_Completo"))
            .Genero = isDBNullToNothing(fila("Genero"))
            .Fecha_Nacimiento = isDBNullToNothing(fila("Fecha_Nacimiento"))
            .Nombre_Declarante = isDBNullToNothing(fila("Nombre_Declarante"))
            .Identificacion_Declarante = isDBNullToNothing(fila("Identificacion_Declarante"))
            .Id_Persona = isDBNullToNothing(fila("Id_Persona"))
            .CYD = isDBNullToNothing(fila("CYD"))
            .Patologia = isDBNullToNothing(fila("Patologia"))
            .Lactando = isDBNullToNothing(fila("Lactando"))
            .Lactancia_Meses = isDBNullToNothing(fila("Lactancia_Meses"))
            .Lactancia_exclusiva = isDBNullToNothing(fila("Lactancia_exclusiva"))
            .Desparasitacion = isDBNullToNothing(fila("Desparasitacion"))
            .Suplementacion = isDBNullToNothing(fila("Suplementacion"))
            .Carnet = isDBNullToNothing(fila("Carnet"))
            .Motivo_NoCarnet = isDBNullToNothing(fila("Motivo_NoCarnet"))
            .Vacunacion = isDBNullToNothing(fila("Vacunacion"))
            .Motivo_No_VacunacionCompleta = isDBNullToNothing(fila("Motivo_No_VacunacionCompleta"))
            .Vacunados = isDBNullToNothing(fila("Vacunados"))
            .MotivoNoVacunados = isDBNullToNothing(fila("MotivoNoVacunados"))
            .Fecha_Esquema_Vacunacion = isDBNullToNothing(fila("Fecha_Esquema_Vacunacion"))
            .Observaciones_Salud = isDBNullToNothing(fila("Observaciones_Salud"))
            .Fecha_Valoracion01 = isDBNullToNothing(fila("Fecha_Valoracion01"))
            .AntropometriaPeso01 = isDBNullToNothing(fila("AntropometriaPeso01"))
            .AntropometriaTalla01 = isDBNullToNothing(fila("AntropometriaTalla01"))
            .Antropometia_Perimetro_Branquial01 = isDBNullToNothing(fila("Antropometia_Perimetro_Branquial01"))
            .Recuperado01 = isDBNullToNothing(fila("Recuperado01"))
            .Observaciones01 = isDBNullToNothing(fila("Observaciones01"))
            .PesoTalla01 = isDBNullToNothing(fila("PesoTalla01"))
            .PesoEdad01 = isDBNullToNothing(fila("PesoEdad01"))
            .TallaLongitud01 = isDBNullToNothing(fila("TallaLongitud01"))
            .IMC_Edad01 = isDBNullToNothing(fila("IMC_Edad01"))
            .Edad01 = isDBNullToNothing(fila("Edad01"))
            .Meses01 = isDBNullToNothing(fila("Meses01"))
            .TallaParaEdad01 = isDBNullToNothing(fila("TallaParaEdad01"))
            .EstadoNutricional01 = isDBNullToNothing(fila("EstadoNutricional01"))
            .Fecha_Valoracion02 = isDBNullToNothing(fila("Fecha_Valoracion02"))
            .AntropometriaPeso02 = isDBNullToNothing(fila("AntropometriaPeso02"))
            .AntropometriaTalla02 = isDBNullToNothing(fila("AntropometriaTalla02"))
            .Antropometia_Perimetro_Branquial02 = isDBNullToNothing(fila("Antropometia_Perimetro_Branquial02"))
            .Recuperado02 = isDBNullToNothing(fila("Recuperado02"))
            .Observaciones02 = isDBNullToNothing(fila("Observaciones02"))
            .PesoTalla02 = isDBNullToNothing(fila("PesoTalla02"))
            .PesoEdad02 = isDBNullToNothing(fila("PesoEdad02"))
            .TallaLongitud02 = isDBNullToNothing(fila("TallaLongitud02"))
            .IMC_Edad02 = isDBNullToNothing(fila("IMC_Edad02"))
            .Edad02 = isDBNullToNothing(fila("Edad02"))
            .Meses02 = isDBNullToNothing(fila("Meses02"))
            .TallaParaEdad02 = isDBNullToNothing(fila("TallaParaEdad02"))
            .EstadoNutricional02 = isDBNullToNothing(fila("EstadoNutricional02"))
            .Fecha_Valoracion03 = isDBNullToNothing(fila("Fecha_Valoracion03"))
            .AntropometriaPeso03 = isDBNullToNothing(fila("AntropometriaPeso03"))
            .AntropometriaTalla03 = isDBNullToNothing(fila("AntropometriaTalla03"))
            .Antropometia_Perimetro_Branquial03 = isDBNullToNothing(fila("Antropometia_Perimetro_Branquial03"))
            .Recuperado03 = isDBNullToNothing(fila("Recuperado03"))
            .Observaciones03 = isDBNullToNothing(fila("Observaciones03"))
            .PesoTalla03 = isDBNullToNothing(fila("PesoTalla03"))
            .PesoEdad03 = isDBNullToNothing(fila("PesoEdad03"))
            .TallaLongitud03 = isDBNullToNothing(fila("TallaLongitud03"))
            .IMC_Edad03 = isDBNullToNothing(fila("IMC_Edad03"))
            .Edad03 = isDBNullToNothing(fila("Edad03"))
            .Meses03 = isDBNullToNothing(fila("Meses03"))
            .TallaParaEdad03 = isDBNullToNothing(fila("TallaParaEdad03"))
            .EstadoNutricional03 = isDBNullToNothing(fila("EstadoNutricional03"))
            .Fecha_ValoracionSeg = isDBNullToNothing(fila("Fecha_ValoracionSeg"))
            .AntropometriaPesoSeg = isDBNullToNothing(fila("AntropometriaPesoSeg"))
            .AntropometriaTallaSeg = isDBNullToNothing(fila("AntropometriaTallaSeg"))
            .Antropometia_Perimetro_BranquialSeg = isDBNullToNothing(fila("Antropometia_Perimetro_BranquialSeg"))
            .RecuperadoSeg = isDBNullToNothing(fila("RecuperadoSeg"))
            .ObservacionesSeg = isDBNullToNothing(fila("ObservacionesSeg"))
            .PesoTallaSeg = isDBNullToNothing(fila("PesoTallaSeg"))
            .PesoEdadSeg = isDBNullToNothing(fila("PesoEdadSeg"))
            .TallaLongitudSeg = isDBNullToNothing(fila("TallaLongitudSeg"))
            .IMC_EdadSeg = isDBNullToNothing(fila("IMC_EdadSeg"))
            .EdadSeg = isDBNullToNothing(fila("EdadSeg"))
            .MesesSeg = isDBNullToNothing(fila("MesesSeg"))
            .TallaParaEdadSeg = isDBNullToNothing(fila("TallaParaEdadSeg"))
            .EstadoNutricionalSeg = isDBNullToNothing(fila("EstadoNutricionalSeg"))
            .FechaRemision01 = isDBNullToNothing(fila("FechaRemision01"))
            .FechaRealizado01 = isDBNullToNothing(fila("FechaRealizado01"))
            .EntidadRemision01 = isDBNullToNothing(fila("EntidadRemision01"))
            .ServicioRemision01 = isDBNullToNothing(fila("ServicioRemision01"))
            .FechaRemision02 = isDBNullToNothing(fila("FechaRemision02"))
            .FechaRealizado02 = isDBNullToNothing(fila("FechaRealizado02"))
            .EntidadRemision02 = isDBNullToNothing(fila("EntidadRemision02"))
            .ServicioRemision02 = isDBNullToNothing(fila("ServicioRemision02"))
            .FechaRemision03 = isDBNullToNothing(fila("FechaRemision03"))
            .FechaRealizado03 = isDBNullToNothing(fila("FechaRealizado03"))
            .EntidadRemision03 = isDBNullToNothing(fila("EntidadRemision03"))
            .ServicioRemision03 = isDBNullToNothing(fila("ServicioRemision03"))

            .Telefono_Declarante = isDBNullToNothing(fila("Telefono_Declarante"))
            .Direccion_Declarante = isDBNullToNothing(fila("Direccion_Declarante"))
            .Celular_Declarante = isDBNullToNothing(fila("Celular_Declarante"))
            .Barrio_Declarante = isDBNullToNothing(fila("Barrio_Declarante"))

            .Regional = isDBNullToNothing(fila("Regional"))
            .LugarEntrega = isDBNullToNothing(fila("LugarEntrega"))
        End With

        Return objTmp_Salud

    End Function

    Public Shared Event LoadingTmp_SaludList(ByVal LoadType As String)
    Public Shared Event LoadedTmp_SaludList(ByVal target As List(Of Tmp_SaludBrl), ByVal LoadType As String)

    Public Shared Function CargarTodos() As List(Of Tmp_SaludBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Tmp_SaludBrl)

        RaiseEvent LoadingTmp_SaludList("CargarTodos")

        dsDatos = Tmp_SaludDAL.CargarTodos()

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedTmp_SaludList(lista, "CargarTodos")

        Return lista

    End Function

    Public Shared Event LoadingPorId(ByVal id As Int32)
    Public Shared Event LoadedPorId(ByVal target As Tmp_SaludBrl)

    Public Shared Function CargarPorID(ByVal ID As Int32) As Tmp_SaludBrl

        Dim dsDatos As System.Data.DataSet
        Dim objTmp_Salud As Tmp_SaludBrl = Nothing

        dsDatos = Tmp_SaludDAL.CargarPorID(ID)

        If dsDatos.Tables(0).Rows.Count <> 0 Then objTmp_Salud = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))

        Return objTmp_Salud

    End Function

    Public Shared Function CargarPorIdUsuario(ByVal id_usuario As Int32) As List(Of Tmp_SaludBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Tmp_SaludBrl)
        dsDatos = Tmp_SaludDAL.CargarPorId_Usuario(id_usuario)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista

    End Function


End Class


