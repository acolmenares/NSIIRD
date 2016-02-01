Imports ingNovar.Utilidades2
imports system.data
Imports system.collections.generic


Partial Public Class Tmp_PsicosocialBrl

    Private _Id As Int32
    Private _Id_usuario As Int32
    Private _IdDeclaracion As Int32
    Private _fecha_valoracion As DateTime
    Private _regional As String
    Private _Lugar_entrega As String
    Private _Primer_Nombre As String
    Private _Primer_Apellido As String
    Private _Identificacion As String
    Private _Emociones As String
    Private _TipoFamilia As Int32
    Private _YoTristezaPE As Int32
    Private _YoMiedoPE As Int32
    Private _YoRabiaPE As Int32
    Private _YoNoDormirPE As Int32
    Private _YoDolorCabezaPE As Int32
    Private _YoDolorEstomagoPE As Int32
    Private _YoApetitoPE As Int32
    Private _YoVenganzaPE As Int32
    Private _YoCulpaPE As Int32
    Private _YoMuertoPE As Int32
    Private _YoRelComuPE As Int32
    Private _YoRelFamiPE As Int32
    Private _FamTristezaPE As Int32
    Private _FamMiedoPE As Int32
    Private _FamRabiaPE As Int32
    Private _FamNoDormirPE As Int32
    Private _FamDolorCabezaPE As Int32
    Private _FamDolorEstomagoPE As Int32
    Private _FamApetitoPE As Int32
    Private _FamVenganzaPE As Int32
    Private _FamCulpaPE As Int32
    Private _FamMuertoPE As Int32
    Private _FamRelComuPE As Int32
    Private _FamRelFamiPE As Int32
    Private _FamiliarPE As String
    Private _VecinoPE As String
    Private _AyudaEspiritualPE As String
    Private _FunSaludPE As String
    Private _OrgVictimasPE As String
    Private _YoTristezaSE As Int32
    Private _YoMiedoSE As Int32
    Private _YoRabiaSE As Int32
    Private _YoNoDormirSE As Int32
    Private _YoDolorCabezaSE As Int32
    Private _YoDolorEstomagoSE As Int32
    Private _YoApetitoSE As Int32
    Private _YoVenganzaSE As Int32
    Private _YoCulpaSE As Int32
    Private _YoMuertoSE As Int32
    Private _YoRelComuSE As Int32
    Private _YoRelFamisE As Int32
    Private _FamTristezaSE As Int32
    Private _FamMiedoSE As Int32
    Private _FamRabiaSE As Int32
    Private _FamNoDormirSE As Int32
    Private _FamDolorCabezaSE As Int32
    Private _FamDolorEstomagoSE As Int32
    Private _FamApetitoSE As Int32
    Private _FamVenganzaSE As Int32
    Private _FamCulpaSE As Int32
    Private _FamMuertoSE As Int32
    Private _FamRelComuSE As Int32
    Private _FamRelFamiSE As Int32
    Private _FamiliarSE As String
    Private _VecinoSE As String
    Private _AyudaEspiritualSE As String
    Private _FunSaludSE As String
    Private _OrgVictimasSE As String


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

    Public Event Id_usuarioChanging(ByVal Value As Int32)
    Public Event Id_usuarioChanged()
	
    Public Property Id_usuario() As Int32
        Get
            Return Me._Id_usuario
        End Get
        Set(ByVal Value As Int32)
            If _Id_usuario <> Value Then
                RaiseEvent Id_usuarioChanging(Value)
				Me._Id_usuario = Value
                RaiseEvent Id_usuarioChanged()
            End If
        End Set
    End Property

    Public Event IdDeclaracionChanging(ByVal Value As Int32)
    Public Event IdDeclaracionChanged()
	
    Public Property IdDeclaracion() As Int32
        Get
            Return Me._IdDeclaracion
        End Get
        Set(ByVal Value As Int32)
            If _IdDeclaracion <> Value Then
                RaiseEvent IdDeclaracionChanging(Value)
				Me._IdDeclaracion = Value
                RaiseEvent IdDeclaracionChanged()
            End If
        End Set
    End Property

    Public Event fecha_valoracionChanging(ByVal Value As DateTime)
    Public Event fecha_valoracionChanged()
	
    Public Property fecha_valoracion() As DateTime
        Get
            Return Me._fecha_valoracion
        End Get
        Set(ByVal Value As DateTime)
            If _fecha_valoracion <> Value Then
                RaiseEvent fecha_valoracionChanging(Value)
				Me._fecha_valoracion = Value
                RaiseEvent fecha_valoracionChanged()
            End If
        End Set
    End Property

    Public Event regionalChanging(ByVal Value As String)
    Public Event regionalChanged()
	
    Public Property regional() As String
        Get
            Return Me._regional
        End Get
        Set(ByVal Value As String)
            If _regional <> Value Then
                RaiseEvent regionalChanging(Value)
				Me._regional = Value
                RaiseEvent regionalChanged()
            End If
        End Set
    End Property

    Public Event Lugar_entregaChanging(ByVal Value As String)
    Public Event Lugar_entregaChanged()
	
    Public Property Lugar_entrega() As String
        Get
            Return Me._Lugar_entrega
        End Get
        Set(ByVal Value As String)
            If _Lugar_entrega <> Value Then
                RaiseEvent Lugar_entregaChanging(Value)
				Me._Lugar_entrega = Value
                RaiseEvent Lugar_entregaChanged()
            End If
        End Set
    End Property

    Public Event Primer_NombreChanging(ByVal Value As String)
    Public Event Primer_NombreChanged()
	
    Public Property Primer_Nombre() As String
        Get
            Return Me._Primer_Nombre
        End Get
        Set(ByVal Value As String)
            If _Primer_Nombre <> Value Then
                RaiseEvent Primer_NombreChanging(Value)
				Me._Primer_Nombre = Value
                RaiseEvent Primer_NombreChanged()
            End If
        End Set
    End Property

    Public Event Primer_ApellidoChanging(ByVal Value As String)
    Public Event Primer_ApellidoChanged()
	
    Public Property Primer_Apellido() As String
        Get
            Return Me._Primer_Apellido
        End Get
        Set(ByVal Value As String)
            If _Primer_Apellido <> Value Then
                RaiseEvent Primer_ApellidoChanging(Value)
				Me._Primer_Apellido = Value
                RaiseEvent Primer_ApellidoChanged()
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

    Public Event EmocionesChanging(ByVal Value As String)
    Public Event EmocionesChanged()
	
    Public Property Emociones() As String
        Get
            Return Me._Emociones
        End Get
        Set(ByVal Value As String)
            If _Emociones <> Value Then
                RaiseEvent EmocionesChanging(Value)
				Me._Emociones = Value
                RaiseEvent EmocionesChanged()
            End If
        End Set
    End Property

    Public Event TipoFamiliaChanging(ByVal Value As Int32)
    Public Event TipoFamiliaChanged()
	
    Public Property TipoFamilia() As Int32
        Get
            Return Me._TipoFamilia
        End Get
        Set(ByVal Value As Int32)
            If _TipoFamilia <> Value Then
                RaiseEvent TipoFamiliaChanging(Value)
				Me._TipoFamilia = Value
                RaiseEvent TipoFamiliaChanged()
            End If
        End Set
    End Property

    Public Event YoTristezaPEChanging(ByVal Value As Int32)
    Public Event YoTristezaPEChanged()
	
    Public Property YoTristezaPE() As Int32
        Get
            Return Me._YoTristezaPE
        End Get
        Set(ByVal Value As Int32)
            If _YoTristezaPE <> Value Then
                RaiseEvent YoTristezaPEChanging(Value)
				Me._YoTristezaPE = Value
                RaiseEvent YoTristezaPEChanged()
            End If
        End Set
    End Property

    Public Event YoMiedoPEChanging(ByVal Value As Int32)
    Public Event YoMiedoPEChanged()
	
    Public Property YoMiedoPE() As Int32
        Get
            Return Me._YoMiedoPE
        End Get
        Set(ByVal Value As Int32)
            If _YoMiedoPE <> Value Then
                RaiseEvent YoMiedoPEChanging(Value)
				Me._YoMiedoPE = Value
                RaiseEvent YoMiedoPEChanged()
            End If
        End Set
    End Property

    Public Event YoRabiaPEChanging(ByVal Value As Int32)
    Public Event YoRabiaPEChanged()
	
    Public Property YoRabiaPE() As Int32
        Get
            Return Me._YoRabiaPE
        End Get
        Set(ByVal Value As Int32)
            If _YoRabiaPE <> Value Then
                RaiseEvent YoRabiaPEChanging(Value)
				Me._YoRabiaPE = Value
                RaiseEvent YoRabiaPEChanged()
            End If
        End Set
    End Property

    Public Event YoNoDormirPEChanging(ByVal Value As Int32)
    Public Event YoNoDormirPEChanged()
	
    Public Property YoNoDormirPE() As Int32
        Get
            Return Me._YoNoDormirPE
        End Get
        Set(ByVal Value As Int32)
            If _YoNoDormirPE <> Value Then
                RaiseEvent YoNoDormirPEChanging(Value)
				Me._YoNoDormirPE = Value
                RaiseEvent YoNoDormirPEChanged()
            End If
        End Set
    End Property

    Public Event YoDolorCabezaPEChanging(ByVal Value As Int32)
    Public Event YoDolorCabezaPEChanged()
	
    Public Property YoDolorCabezaPE() As Int32
        Get
            Return Me._YoDolorCabezaPE
        End Get
        Set(ByVal Value As Int32)
            If _YoDolorCabezaPE <> Value Then
                RaiseEvent YoDolorCabezaPEChanging(Value)
				Me._YoDolorCabezaPE = Value
                RaiseEvent YoDolorCabezaPEChanged()
            End If
        End Set
    End Property

    Public Event YoDolorEstomagoPEChanging(ByVal Value As Int32)
    Public Event YoDolorEstomagoPEChanged()
	
    Public Property YoDolorEstomagoPE() As Int32
        Get
            Return Me._YoDolorEstomagoPE
        End Get
        Set(ByVal Value As Int32)
            If _YoDolorEstomagoPE <> Value Then
                RaiseEvent YoDolorEstomagoPEChanging(Value)
				Me._YoDolorEstomagoPE = Value
                RaiseEvent YoDolorEstomagoPEChanged()
            End If
        End Set
    End Property

    Public Event YoApetitoPEChanging(ByVal Value As Int32)
    Public Event YoApetitoPEChanged()
	
    Public Property YoApetitoPE() As Int32
        Get
            Return Me._YoApetitoPE
        End Get
        Set(ByVal Value As Int32)
            If _YoApetitoPE <> Value Then
                RaiseEvent YoApetitoPEChanging(Value)
				Me._YoApetitoPE = Value
                RaiseEvent YoApetitoPEChanged()
            End If
        End Set
    End Property

    Public Event YoVenganzaPEChanging(ByVal Value As Int32)
    Public Event YoVenganzaPEChanged()
	
    Public Property YoVenganzaPE() As Int32
        Get
            Return Me._YoVenganzaPE
        End Get
        Set(ByVal Value As Int32)
            If _YoVenganzaPE <> Value Then
                RaiseEvent YoVenganzaPEChanging(Value)
				Me._YoVenganzaPE = Value
                RaiseEvent YoVenganzaPEChanged()
            End If
        End Set
    End Property

    Public Event YoCulpaPEChanging(ByVal Value As Int32)
    Public Event YoCulpaPEChanged()
	
    Public Property YoCulpaPE() As Int32
        Get
            Return Me._YoCulpaPE
        End Get
        Set(ByVal Value As Int32)
            If _YoCulpaPE <> Value Then
                RaiseEvent YoCulpaPEChanging(Value)
				Me._YoCulpaPE = Value
                RaiseEvent YoCulpaPEChanged()
            End If
        End Set
    End Property

    Public Event YoMuertoPEChanging(ByVal Value As Int32)
    Public Event YoMuertoPEChanged()
	
    Public Property YoMuertoPE() As Int32
        Get
            Return Me._YoMuertoPE
        End Get
        Set(ByVal Value As Int32)
            If _YoMuertoPE <> Value Then
                RaiseEvent YoMuertoPEChanging(Value)
				Me._YoMuertoPE = Value
                RaiseEvent YoMuertoPEChanged()
            End If
        End Set
    End Property

    Public Event YoRelComuPEChanging(ByVal Value As Int32)
    Public Event YoRelComuPEChanged()
	
    Public Property YoRelComuPE() As Int32
        Get
            Return Me._YoRelComuPE
        End Get
        Set(ByVal Value As Int32)
            If _YoRelComuPE <> Value Then
                RaiseEvent YoRelComuPEChanging(Value)
				Me._YoRelComuPE = Value
                RaiseEvent YoRelComuPEChanged()
            End If
        End Set
    End Property

    Public Event YoRelFamiPEChanging(ByVal Value As Int32)
    Public Event YoRelFamiPEChanged()
	
    Public Property YoRelFamiPE() As Int32
        Get
            Return Me._YoRelFamiPE
        End Get
        Set(ByVal Value As Int32)
            If _YoRelFamiPE <> Value Then
                RaiseEvent YoRelFamiPEChanging(Value)
				Me._YoRelFamiPE = Value
                RaiseEvent YoRelFamiPEChanged()
            End If
        End Set
    End Property

    Public Event FamTristezaPEChanging(ByVal Value As Int32)
    Public Event FamTristezaPEChanged()
	
    Public Property FamTristezaPE() As Int32
        Get
            Return Me._FamTristezaPE
        End Get
        Set(ByVal Value As Int32)
            If _FamTristezaPE <> Value Then
                RaiseEvent FamTristezaPEChanging(Value)
				Me._FamTristezaPE = Value
                RaiseEvent FamTristezaPEChanged()
            End If
        End Set
    End Property

    Public Event FamMiedoPEChanging(ByVal Value As Int32)
    Public Event FamMiedoPEChanged()
	
    Public Property FamMiedoPE() As Int32
        Get
            Return Me._FamMiedoPE
        End Get
        Set(ByVal Value As Int32)
            If _FamMiedoPE <> Value Then
                RaiseEvent FamMiedoPEChanging(Value)
				Me._FamMiedoPE = Value
                RaiseEvent FamMiedoPEChanged()
            End If
        End Set
    End Property

    Public Event FamRabiaPEChanging(ByVal Value As Int32)
    Public Event FamRabiaPEChanged()
	
    Public Property FamRabiaPE() As Int32
        Get
            Return Me._FamRabiaPE
        End Get
        Set(ByVal Value As Int32)
            If _FamRabiaPE <> Value Then
                RaiseEvent FamRabiaPEChanging(Value)
				Me._FamRabiaPE = Value
                RaiseEvent FamRabiaPEChanged()
            End If
        End Set
    End Property

    Public Event FamNoDormirPEChanging(ByVal Value As Int32)
    Public Event FamNoDormirPEChanged()
	
    Public Property FamNoDormirPE() As Int32
        Get
            Return Me._FamNoDormirPE
        End Get
        Set(ByVal Value As Int32)
            If _FamNoDormirPE <> Value Then
                RaiseEvent FamNoDormirPEChanging(Value)
				Me._FamNoDormirPE = Value
                RaiseEvent FamNoDormirPEChanged()
            End If
        End Set
    End Property

    Public Event FamDolorCabezaPEChanging(ByVal Value As Int32)
    Public Event FamDolorCabezaPEChanged()
	
    Public Property FamDolorCabezaPE() As Int32
        Get
            Return Me._FamDolorCabezaPE
        End Get
        Set(ByVal Value As Int32)
            If _FamDolorCabezaPE <> Value Then
                RaiseEvent FamDolorCabezaPEChanging(Value)
				Me._FamDolorCabezaPE = Value
                RaiseEvent FamDolorCabezaPEChanged()
            End If
        End Set
    End Property

    Public Event FamDolorEstomagoPEChanging(ByVal Value As Int32)
    Public Event FamDolorEstomagoPEChanged()
	
    Public Property FamDolorEstomagoPE() As Int32
        Get
            Return Me._FamDolorEstomagoPE
        End Get
        Set(ByVal Value As Int32)
            If _FamDolorEstomagoPE <> Value Then
                RaiseEvent FamDolorEstomagoPEChanging(Value)
				Me._FamDolorEstomagoPE = Value
                RaiseEvent FamDolorEstomagoPEChanged()
            End If
        End Set
    End Property

    Public Event FamApetitoPEChanging(ByVal Value As Int32)
    Public Event FamApetitoPEChanged()
	
    Public Property FamApetitoPE() As Int32
        Get
            Return Me._FamApetitoPE
        End Get
        Set(ByVal Value As Int32)
            If _FamApetitoPE <> Value Then
                RaiseEvent FamApetitoPEChanging(Value)
				Me._FamApetitoPE = Value
                RaiseEvent FamApetitoPEChanged()
            End If
        End Set
    End Property

    Public Event FamVenganzaPEChanging(ByVal Value As Int32)
    Public Event FamVenganzaPEChanged()
	
    Public Property FamVenganzaPE() As Int32
        Get
            Return Me._FamVenganzaPE
        End Get
        Set(ByVal Value As Int32)
            If _FamVenganzaPE <> Value Then
                RaiseEvent FamVenganzaPEChanging(Value)
				Me._FamVenganzaPE = Value
                RaiseEvent FamVenganzaPEChanged()
            End If
        End Set
    End Property

    Public Event FamCulpaPEChanging(ByVal Value As Int32)
    Public Event FamCulpaPEChanged()
	
    Public Property FamCulpaPE() As Int32
        Get
            Return Me._FamCulpaPE
        End Get
        Set(ByVal Value As Int32)
            If _FamCulpaPE <> Value Then
                RaiseEvent FamCulpaPEChanging(Value)
				Me._FamCulpaPE = Value
                RaiseEvent FamCulpaPEChanged()
            End If
        End Set
    End Property

    Public Event FamMuertoPEChanging(ByVal Value As Int32)
    Public Event FamMuertoPEChanged()
	
    Public Property FamMuertoPE() As Int32
        Get
            Return Me._FamMuertoPE
        End Get
        Set(ByVal Value As Int32)
            If _FamMuertoPE <> Value Then
                RaiseEvent FamMuertoPEChanging(Value)
				Me._FamMuertoPE = Value
                RaiseEvent FamMuertoPEChanged()
            End If
        End Set
    End Property

    Public Event FamRelComuPEChanging(ByVal Value As Int32)
    Public Event FamRelComuPEChanged()
	
    Public Property FamRelComuPE() As Int32
        Get
            Return Me._FamRelComuPE
        End Get
        Set(ByVal Value As Int32)
            If _FamRelComuPE <> Value Then
                RaiseEvent FamRelComuPEChanging(Value)
				Me._FamRelComuPE = Value
                RaiseEvent FamRelComuPEChanged()
            End If
        End Set
    End Property

    Public Event FamRelFamiPEChanging(ByVal Value As Int32)
    Public Event FamRelFamiPEChanged()
	
    Public Property FamRelFamiPE() As Int32
        Get
            Return Me._FamRelFamiPE
        End Get
        Set(ByVal Value As Int32)
            If _FamRelFamiPE <> Value Then
                RaiseEvent FamRelFamiPEChanging(Value)
				Me._FamRelFamiPE = Value
                RaiseEvent FamRelFamiPEChanged()
            End If
        End Set
    End Property

    Public Event FamiliarPEChanging(ByVal Value As String)
    Public Event FamiliarPEChanged()
	
    Public Property FamiliarPE() As String
        Get
            Return Me._FamiliarPE
        End Get
        Set(ByVal Value As String)
            If _FamiliarPE <> Value Then
                RaiseEvent FamiliarPEChanging(Value)
				Me._FamiliarPE = Value
                RaiseEvent FamiliarPEChanged()
            End If
        End Set
    End Property

    Public Event VecinoPEChanging(ByVal Value As String)
    Public Event VecinoPEChanged()
	
    Public Property VecinoPE() As String
        Get
            Return Me._VecinoPE
        End Get
        Set(ByVal Value As String)
            If _VecinoPE <> Value Then
                RaiseEvent VecinoPEChanging(Value)
				Me._VecinoPE = Value
                RaiseEvent VecinoPEChanged()
            End If
        End Set
    End Property

    Public Event AyudaEspiritualPEChanging(ByVal Value As String)
    Public Event AyudaEspiritualPEChanged()
	
    Public Property AyudaEspiritualPE() As String
        Get
            Return Me._AyudaEspiritualPE
        End Get
        Set(ByVal Value As String)
            If _AyudaEspiritualPE <> Value Then
                RaiseEvent AyudaEspiritualPEChanging(Value)
				Me._AyudaEspiritualPE = Value
                RaiseEvent AyudaEspiritualPEChanged()
            End If
        End Set
    End Property

    Public Event FunSaludPEChanging(ByVal Value As String)
    Public Event FunSaludPEChanged()
	
    Public Property FunSaludPE() As String
        Get
            Return Me._FunSaludPE
        End Get
        Set(ByVal Value As String)
            If _FunSaludPE <> Value Then
                RaiseEvent FunSaludPEChanging(Value)
				Me._FunSaludPE = Value
                RaiseEvent FunSaludPEChanged()
            End If
        End Set
    End Property

    Public Event OrgVictimasPEChanging(ByVal Value As String)
    Public Event OrgVictimasPEChanged()
	
    Public Property OrgVictimasPE() As String
        Get
            Return Me._OrgVictimasPE
        End Get
        Set(ByVal Value As String)
            If _OrgVictimasPE <> Value Then
                RaiseEvent OrgVictimasPEChanging(Value)
				Me._OrgVictimasPE = Value
                RaiseEvent OrgVictimasPEChanged()
            End If
        End Set
    End Property

    Public Event YoTristezaSEChanging(ByVal Value As Int32)
    Public Event YoTristezaSEChanged()
	
    Public Property YoTristezaSE() As Int32
        Get
            Return Me._YoTristezaSE
        End Get
        Set(ByVal Value As Int32)
            If _YoTristezaSE <> Value Then
                RaiseEvent YoTristezaSEChanging(Value)
				Me._YoTristezaSE = Value
                RaiseEvent YoTristezaSEChanged()
            End If
        End Set
    End Property

    Public Event YoMiedoSEChanging(ByVal Value As Int32)
    Public Event YoMiedoSEChanged()
	
    Public Property YoMiedoSE() As Int32
        Get
            Return Me._YoMiedoSE
        End Get
        Set(ByVal Value As Int32)
            If _YoMiedoSE <> Value Then
                RaiseEvent YoMiedoSEChanging(Value)
				Me._YoMiedoSE = Value
                RaiseEvent YoMiedoSEChanged()
            End If
        End Set
    End Property

    Public Event YoRabiaSEChanging(ByVal Value As Int32)
    Public Event YoRabiaSEChanged()
	
    Public Property YoRabiaSE() As Int32
        Get
            Return Me._YoRabiaSE
        End Get
        Set(ByVal Value As Int32)
            If _YoRabiaSE <> Value Then
                RaiseEvent YoRabiaSEChanging(Value)
				Me._YoRabiaSE = Value
                RaiseEvent YoRabiaSEChanged()
            End If
        End Set
    End Property

    Public Event YoNoDormirSEChanging(ByVal Value As Int32)
    Public Event YoNoDormirSEChanged()
	
    Public Property YoNoDormirSE() As Int32
        Get
            Return Me._YoNoDormirSE
        End Get
        Set(ByVal Value As Int32)
            If _YoNoDormirSE <> Value Then
                RaiseEvent YoNoDormirSEChanging(Value)
				Me._YoNoDormirSE = Value
                RaiseEvent YoNoDormirSEChanged()
            End If
        End Set
    End Property

    Public Event YoDolorCabezaSEChanging(ByVal Value As Int32)
    Public Event YoDolorCabezaSEChanged()
	
    Public Property YoDolorCabezaSE() As Int32
        Get
            Return Me._YoDolorCabezaSE
        End Get
        Set(ByVal Value As Int32)
            If _YoDolorCabezaSE <> Value Then
                RaiseEvent YoDolorCabezaSEChanging(Value)
				Me._YoDolorCabezaSE = Value
                RaiseEvent YoDolorCabezaSEChanged()
            End If
        End Set
    End Property

    Public Event YoDolorEstomagoSEChanging(ByVal Value As Int32)
    Public Event YoDolorEstomagoSEChanged()
	
    Public Property YoDolorEstomagoSE() As Int32
        Get
            Return Me._YoDolorEstomagoSE
        End Get
        Set(ByVal Value As Int32)
            If _YoDolorEstomagoSE <> Value Then
                RaiseEvent YoDolorEstomagoSEChanging(Value)
				Me._YoDolorEstomagoSE = Value
                RaiseEvent YoDolorEstomagoSEChanged()
            End If
        End Set
    End Property

    Public Event YoApetitoSEChanging(ByVal Value As Int32)
    Public Event YoApetitoSEChanged()
	
    Public Property YoApetitoSE() As Int32
        Get
            Return Me._YoApetitoSE
        End Get
        Set(ByVal Value As Int32)
            If _YoApetitoSE <> Value Then
                RaiseEvent YoApetitoSEChanging(Value)
				Me._YoApetitoSE = Value
                RaiseEvent YoApetitoSEChanged()
            End If
        End Set
    End Property

    Public Event YoVenganzaSEChanging(ByVal Value As Int32)
    Public Event YoVenganzaSEChanged()
	
    Public Property YoVenganzaSE() As Int32
        Get
            Return Me._YoVenganzaSE
        End Get
        Set(ByVal Value As Int32)
            If _YoVenganzaSE <> Value Then
                RaiseEvent YoVenganzaSEChanging(Value)
				Me._YoVenganzaSE = Value
                RaiseEvent YoVenganzaSEChanged()
            End If
        End Set
    End Property

    Public Event YoCulpaSEChanging(ByVal Value As Int32)
    Public Event YoCulpaSEChanged()
	
    Public Property YoCulpaSE() As Int32
        Get
            Return Me._YoCulpaSE
        End Get
        Set(ByVal Value As Int32)
            If _YoCulpaSE <> Value Then
                RaiseEvent YoCulpaSEChanging(Value)
				Me._YoCulpaSE = Value
                RaiseEvent YoCulpaSEChanged()
            End If
        End Set
    End Property

    Public Event YoMuertoSEChanging(ByVal Value As Int32)
    Public Event YoMuertoSEChanged()
	
    Public Property YoMuertoSE() As Int32
        Get
            Return Me._YoMuertoSE
        End Get
        Set(ByVal Value As Int32)
            If _YoMuertoSE <> Value Then
                RaiseEvent YoMuertoSEChanging(Value)
				Me._YoMuertoSE = Value
                RaiseEvent YoMuertoSEChanged()
            End If
        End Set
    End Property

    Public Event YoRelComuSEChanging(ByVal Value As Int32)
    Public Event YoRelComuSEChanged()
	
    Public Property YoRelComuSE() As Int32
        Get
            Return Me._YoRelComuSE
        End Get
        Set(ByVal Value As Int32)
            If _YoRelComuSE <> Value Then
                RaiseEvent YoRelComuSEChanging(Value)
				Me._YoRelComuSE = Value
                RaiseEvent YoRelComuSEChanged()
            End If
        End Set
    End Property

    Public Event YoRelFamisEChanging(ByVal Value As Int32)
    Public Event YoRelFamisEChanged()
	
    Public Property YoRelFamisE() As Int32
        Get
            Return Me._YoRelFamisE
        End Get
        Set(ByVal Value As Int32)
            If _YoRelFamisE <> Value Then
                RaiseEvent YoRelFamisEChanging(Value)
				Me._YoRelFamisE = Value
                RaiseEvent YoRelFamisEChanged()
            End If
        End Set
    End Property

    Public Event FamTristezaSEChanging(ByVal Value As Int32)
    Public Event FamTristezaSEChanged()
	
    Public Property FamTristezaSE() As Int32
        Get
            Return Me._FamTristezaSE
        End Get
        Set(ByVal Value As Int32)
            If _FamTristezaSE <> Value Then
                RaiseEvent FamTristezaSEChanging(Value)
				Me._FamTristezaSE = Value
                RaiseEvent FamTristezaSEChanged()
            End If
        End Set
    End Property

    Public Event FamMiedoSEChanging(ByVal Value As Int32)
    Public Event FamMiedoSEChanged()
	
    Public Property FamMiedoSE() As Int32
        Get
            Return Me._FamMiedoSE
        End Get
        Set(ByVal Value As Int32)
            If _FamMiedoSE <> Value Then
                RaiseEvent FamMiedoSEChanging(Value)
				Me._FamMiedoSE = Value
                RaiseEvent FamMiedoSEChanged()
            End If
        End Set
    End Property

    Public Event FamRabiaSEChanging(ByVal Value As Int32)
    Public Event FamRabiaSEChanged()
	
    Public Property FamRabiaSE() As Int32
        Get
            Return Me._FamRabiaSE
        End Get
        Set(ByVal Value As Int32)
            If _FamRabiaSE <> Value Then
                RaiseEvent FamRabiaSEChanging(Value)
				Me._FamRabiaSE = Value
                RaiseEvent FamRabiaSEChanged()
            End If
        End Set
    End Property

    Public Event FamNoDormirSEChanging(ByVal Value As Int32)
    Public Event FamNoDormirSEChanged()
	
    Public Property FamNoDormirSE() As Int32
        Get
            Return Me._FamNoDormirSE
        End Get
        Set(ByVal Value As Int32)
            If _FamNoDormirSE <> Value Then
                RaiseEvent FamNoDormirSEChanging(Value)
				Me._FamNoDormirSE = Value
                RaiseEvent FamNoDormirSEChanged()
            End If
        End Set
    End Property

    Public Event FamDolorCabezaSEChanging(ByVal Value As Int32)
    Public Event FamDolorCabezaSEChanged()
	
    Public Property FamDolorCabezaSE() As Int32
        Get
            Return Me._FamDolorCabezaSE
        End Get
        Set(ByVal Value As Int32)
            If _FamDolorCabezaSE <> Value Then
                RaiseEvent FamDolorCabezaSEChanging(Value)
				Me._FamDolorCabezaSE = Value
                RaiseEvent FamDolorCabezaSEChanged()
            End If
        End Set
    End Property

    Public Event FamDolorEstomagoSEChanging(ByVal Value As Int32)
    Public Event FamDolorEstomagoSEChanged()
	
    Public Property FamDolorEstomagoSE() As Int32
        Get
            Return Me._FamDolorEstomagoSE
        End Get
        Set(ByVal Value As Int32)
            If _FamDolorEstomagoSE <> Value Then
                RaiseEvent FamDolorEstomagoSEChanging(Value)
				Me._FamDolorEstomagoSE = Value
                RaiseEvent FamDolorEstomagoSEChanged()
            End If
        End Set
    End Property

    Public Event FamApetitoSEChanging(ByVal Value As Int32)
    Public Event FamApetitoSEChanged()
	
    Public Property FamApetitoSE() As Int32
        Get
            Return Me._FamApetitoSE
        End Get
        Set(ByVal Value As Int32)
            If _FamApetitoSE <> Value Then
                RaiseEvent FamApetitoSEChanging(Value)
				Me._FamApetitoSE = Value
                RaiseEvent FamApetitoSEChanged()
            End If
        End Set
    End Property

    Public Event FamVenganzaSEChanging(ByVal Value As Int32)
    Public Event FamVenganzaSEChanged()
	
    Public Property FamVenganzaSE() As Int32
        Get
            Return Me._FamVenganzaSE
        End Get
        Set(ByVal Value As Int32)
            If _FamVenganzaSE <> Value Then
                RaiseEvent FamVenganzaSEChanging(Value)
				Me._FamVenganzaSE = Value
                RaiseEvent FamVenganzaSEChanged()
            End If
        End Set
    End Property

    Public Event FamCulpaSEChanging(ByVal Value As Int32)
    Public Event FamCulpaSEChanged()
	
    Public Property FamCulpaSE() As Int32
        Get
            Return Me._FamCulpaSE
        End Get
        Set(ByVal Value As Int32)
            If _FamCulpaSE <> Value Then
                RaiseEvent FamCulpaSEChanging(Value)
				Me._FamCulpaSE = Value
                RaiseEvent FamCulpaSEChanged()
            End If
        End Set
    End Property

    Public Event FamMuertoSEChanging(ByVal Value As Int32)
    Public Event FamMuertoSEChanged()
	
    Public Property FamMuertoSE() As Int32
        Get
            Return Me._FamMuertoSE
        End Get
        Set(ByVal Value As Int32)
            If _FamMuertoSE <> Value Then
                RaiseEvent FamMuertoSEChanging(Value)
				Me._FamMuertoSE = Value
                RaiseEvent FamMuertoSEChanged()
            End If
        End Set
    End Property

    Public Event FamRelComuSEChanging(ByVal Value As Int32)
    Public Event FamRelComuSEChanged()
	
    Public Property FamRelComuSE() As Int32
        Get
            Return Me._FamRelComuSE
        End Get
        Set(ByVal Value As Int32)
            If _FamRelComuSE <> Value Then
                RaiseEvent FamRelComuSEChanging(Value)
				Me._FamRelComuSE = Value
                RaiseEvent FamRelComuSEChanged()
            End If
        End Set
    End Property

    Public Event FamRelFamiSEChanging(ByVal Value As Int32)
    Public Event FamRelFamiSEChanged()
	
    Public Property FamRelFamiSE() As Int32
        Get
            Return Me._FamRelFamiSE
        End Get
        Set(ByVal Value As Int32)
            If _FamRelFamiSE <> Value Then
                RaiseEvent FamRelFamiSEChanging(Value)
				Me._FamRelFamiSE = Value
                RaiseEvent FamRelFamiSEChanged()
            End If
        End Set
    End Property

    Public Event FamiliarSEChanging(ByVal Value As String)
    Public Event FamiliarSEChanged()
	
    Public Property FamiliarSE() As String
        Get
            Return Me._FamiliarSE
        End Get
        Set(ByVal Value As String)
            If _FamiliarSE <> Value Then
                RaiseEvent FamiliarSEChanging(Value)
				Me._FamiliarSE = Value
                RaiseEvent FamiliarSEChanged()
            End If
        End Set
    End Property

    Public Event VecinoSEChanging(ByVal Value As String)
    Public Event VecinoSEChanged()
	
    Public Property VecinoSE() As String
        Get
            Return Me._VecinoSE
        End Get
        Set(ByVal Value As String)
            If _VecinoSE <> Value Then
                RaiseEvent VecinoSEChanging(Value)
				Me._VecinoSE = Value
                RaiseEvent VecinoSEChanged()
            End If
        End Set
    End Property

    Public Event AyudaEspiritualSEChanging(ByVal Value As String)
    Public Event AyudaEspiritualSEChanged()
	
    Public Property AyudaEspiritualSE() As String
        Get
            Return Me._AyudaEspiritualSE
        End Get
        Set(ByVal Value As String)
            If _AyudaEspiritualSE <> Value Then
                RaiseEvent AyudaEspiritualSEChanging(Value)
				Me._AyudaEspiritualSE = Value
                RaiseEvent AyudaEspiritualSEChanged()
            End If
        End Set
    End Property

    Public Event FunSaludSEChanging(ByVal Value As String)
    Public Event FunSaludSEChanged()
	
    Public Property FunSaludSE() As String
        Get
            Return Me._FunSaludSE
        End Get
        Set(ByVal Value As String)
            If _FunSaludSE <> Value Then
                RaiseEvent FunSaludSEChanging(Value)
				Me._FunSaludSE = Value
                RaiseEvent FunSaludSEChanged()
            End If
        End Set
    End Property

    Public Event OrgVictimasSEChanging(ByVal Value As String)
    Public Event OrgVictimasSEChanged()
	
    Public Property OrgVictimasSE() As String
        Get
            Return Me._OrgVictimasSE
        End Get
        Set(ByVal Value As String)
            If _OrgVictimasSE <> Value Then
                RaiseEvent OrgVictimasSEChanging(Value)
				Me._OrgVictimasSE = Value
                RaiseEvent OrgVictimasSEChanged()
            End If
        End Set
    End Property

    Public ReadOnly Property Declaracion() As DeclaracionBrl
        Get
            Return DeclaracionBrl.CargarPorID(IdDeclaracion)
        End Get
    End Property


    Public ReadOnly Property PrimeraEntregaIndice As Double
        Get
            Dim wsuma01 As Integer = 0
            Dim wcantidad01 As Double = 0
            Dim windice As Double = 0
            wsuma01 = YoApetitoPE + YoCulpaPE + YoDolorCabezaPE + YoDolorEstomagoPE + YoMiedoPE + YoMuertoPE + YoNoDormirPE + YoRabiaPE + YoRelComuPE + YoRelFamiPE + YoTristezaPE + YoVenganzaPE + _
            FamApetitoPE + FamCulpaPE + FamDolorCabezaPE + FamDolorEstomagoPE + FamMiedoPE + FamMuertoPE + FamNoDormirPE + FamRabiaPE + FamRelComuPE + FamRelFamiPE + FamTristezaPE + FamVenganzaPE

            If YoApetitoPE <> 0 Then wcantidad01 += 1
            If YoCulpaPE <> 0 Then wcantidad01 += 1
            If YoDolorCabezaPE <> 0 Then wcantidad01 += 1
            If YoDolorEstomagoPE <> 0 Then wcantidad01 += 1
            If YoMiedoPE <> 0 Then wcantidad01 += 1
            If YoMuertoPE <> 0 Then wcantidad01 += 1
            If YoNoDormirPE <> 0 Then wcantidad01 += 1
            If YoRabiaPE <> 0 Then wcantidad01 += 1
            If YoRelComuPE <> 0 Then wcantidad01 += 1
            If YoRelFamiPE <> 0 Then wcantidad01 += 1
            If YoTristezaPE <> 0 Then wcantidad01 += 1
            If YoVenganzaPE <> 0 Then wcantidad01 += 1
            If FamApetitoPE <> 0 Then wcantidad01 += 1
            If FamCulpaPE <> 0 Then wcantidad01 += 1
            If FamDolorCabezaPE <> 0 Then wcantidad01 += 1
            If FamDolorEstomagoPE <> 0 Then wcantidad01 += 1
            If FamMiedoPE <> 0 Then wcantidad01 += 1
            If FamMuertoPE <> 0 Then wcantidad01 += 1
            If FamNoDormirPE <> 0 Then wcantidad01 += 1
            If FamRabiaPE <> 0 Then wcantidad01 += 1
            If FamRelComuPE <> 0 Then wcantidad01 += 1
            If FamRelFamiPE <> 0 Then wcantidad01 += 1
            If FamTristezaPE <> 0 Then wcantidad01 += 1
            If FamVenganzaPE <> 0 Then wcantidad01 += 1


            Dim wsuma02 As Integer = 0
            Dim wcantidad02 As Double = 0

            If FamiliarPE = "SI" Then wsuma02 += 1
            If VecinoPE = "SI" Then wsuma02 += 1
            If OrgVictimasPE = "SI" Then wsuma02 += 1
            If AyudaEspiritualPE = "SI" Then wsuma02 += 1
            If FunSaludPE = "SI" Then wsuma02 += 1
            Try
                wcantidad02 = wsuma02 / 25
            Catch ex As Exception
                wcantidad02 = 0
            End Try

            windice = (wsuma01 / (wcantidad01 * 5)) - wcantidad02

            Return windice

        End Get
    End Property

    Public ReadOnly Property SegundaEntregaIndice As Double
        Get
            Dim wsuma01 As Integer = 0
            Dim wcantidad01 As Double = 0
            Dim windice As Double = 0
            wsuma01 = YoApetitoSE + YoCulpaSE + YoDolorCabezaSE + YoDolorEstomagoSE + YoMiedoSE + YoMuertoSE + YoNoDormirSE + YoRabiaSE + YoRelComuSE + YoRelFamisE + YoTristezaSE + YoVenganzaSE + _
            FamApetitoSE + FamCulpaSE + FamDolorCabezaSE + FamDolorEstomagoSE + FamMiedoSE + FamMuertoSE + FamNoDormirSE + FamRabiaSE + FamRelComuSE + FamRelFamiSE + FamTristezaSE + FamVenganzaSE

            If YoApetitoSE <> 0 Then wcantidad01 += 1
            If YoCulpaSE <> 0 Then wcantidad01 += 1
            If YoDolorCabezaSE <> 0 Then wcantidad01 += 1
            If YoDolorEstomagoSE <> 0 Then wcantidad01 += 1
            If YoMiedoSE <> 0 Then wcantidad01 += 1
            If YoMuertoSE <> 0 Then wcantidad01 += 1
            If YoNoDormirSE <> 0 Then wcantidad01 += 1
            If YoRabiaSE <> 0 Then wcantidad01 += 1
            If YoRelComuSE <> 0 Then wcantidad01 += 1
            If YoRelFamisE <> 0 Then wcantidad01 += 1
            If YoTristezaSE <> 0 Then wcantidad01 += 1
            If YoVenganzaSE <> 0 Then wcantidad01 += 1
            If FamApetitoSE <> 0 Then wcantidad01 += 1
            If FamCulpaSE <> 0 Then wcantidad01 += 1
            If FamDolorCabezaSE <> 0 Then wcantidad01 += 1
            If FamDolorEstomagoSE <> 0 Then wcantidad01 += 1
            If FamMiedoSE <> 0 Then wcantidad01 += 1
            If FamMuertoSE <> 0 Then wcantidad01 += 1
            If FamNoDormirSE <> 0 Then wcantidad01 += 1
            If FamRabiaSE <> 0 Then wcantidad01 += 1
            If FamRelComuSE <> 0 Then wcantidad01 += 1
            If FamRelFamiSE <> 0 Then wcantidad01 += 1
            If FamTristezaSE <> 0 Then wcantidad01 += 1
            If FamVenganzaSE <> 0 Then wcantidad01 += 1



            Dim wsuma02 As Integer = 0
            Dim wcantidad02 As Double = 0

            If FamiliarSE = "SI" Then wsuma02 += 1
            If VecinoSE = "SI" Then wsuma02 += 1
            If OrgVictimasSE = "SI" Then wsuma02 += 1
            If AyudaEspiritualSE = "SI" Then wsuma02 += 1
            If FunSaludSE = "SI" Then wsuma02 += 1
            Try
                wcantidad02 = wsuma02 / 25
            Catch ex As Exception
                wcantidad02 = 0
            End Try

            windice = (wsuma01 / (wcantidad01 * 5)) - wcantidad02

            Return windice

        End Get
    End Property


    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Tmp_PsicosocialBrl

        Dim objTmp_Psicosocial As New Tmp_PsicosocialBrl

        With objTmp_Psicosocial
            .ID = fila("Id")
            .Id_usuario = isDBNullToNothing(fila("Id_usuario"))
            .IdDeclaracion = isDBNullToNothing(fila("IdDeclaracion"))
            .fecha_valoracion = isDBNullToNothing(fila("fecha_valoracion"))
            .regional = isDBNullToNothing(fila("regional"))
            .Lugar_entrega = isDBNullToNothing(fila("Lugar_entrega"))
            .Primer_Nombre = isDBNullToNothing(fila("Primer_Nombre"))
            .Primer_Apellido = isDBNullToNothing(fila("Primer_Apellido"))
            .Identificacion = isDBNullToNothing(fila("Identificacion"))
            .Emociones = isDBNullToNothing(fila("Emociones"))
            .TipoFamilia = isDBNullToNothing(fila("TipoFamilia"))
            .YoTristezaPE = isDBNullToNothing(fila("YoTristezaPE"))
            .YoMiedoPE = isDBNullToNothing(fila("YoMiedoPE"))
            .YoRabiaPE = isDBNullToNothing(fila("YoRabiaPE"))
            .YoNoDormirPE = isDBNullToNothing(fila("YoNoDormirPE"))
            .YoDolorCabezaPE = isDBNullToNothing(fila("YoDolorCabezaPE"))
            .YoDolorEstomagoPE = isDBNullToNothing(fila("YoDolorEstomagoPE"))
            .YoApetitoPE = isDBNullToNothing(fila("YoApetitoPE"))
            .YoVenganzaPE = isDBNullToNothing(fila("YoVenganzaPE"))
            .YoCulpaPE = isDBNullToNothing(fila("YoCulpaPE"))
            .YoMuertoPE = isDBNullToNothing(fila("YoMuertoPE"))
            .YoRelComuPE = isDBNullToNothing(fila("YoRelComuPE"))
            .YoRelFamiPE = isDBNullToNothing(fila("YoRelFamiPE"))
            .FamTristezaPE = isDBNullToNothing(fila("FamTristezaPE"))
            .FamMiedoPE = isDBNullToNothing(fila("FamMiedoPE"))
            .FamRabiaPE = isDBNullToNothing(fila("FamRabiaPE"))
            .FamNoDormirPE = isDBNullToNothing(fila("FamNoDormirPE"))
            .FamDolorCabezaPE = isDBNullToNothing(fila("FamDolorCabezaPE"))
            .FamDolorEstomagoPE = isDBNullToNothing(fila("FamDolorEstomagoPE"))
            .FamApetitoPE = isDBNullToNothing(fila("FamApetitoPE"))
            .FamVenganzaPE = isDBNullToNothing(fila("FamVenganzaPE"))
            .FamCulpaPE = isDBNullToNothing(fila("FamCulpaPE"))
            .FamMuertoPE = isDBNullToNothing(fila("FamMuertoPE"))
            .FamRelComuPE = isDBNullToNothing(fila("FamRelComuPE"))
            .FamRelFamiPE = isDBNullToNothing(fila("FamRelFamiPE"))
            .FamiliarPE = isDBNullToNothing(fila("FamiliarPE"))
            .VecinoPE = isDBNullToNothing(fila("VecinoPE"))
            .AyudaEspiritualPE = isDBNullToNothing(fila("AyudaEspiritualPE"))
            .FunSaludPE = isDBNullToNothing(fila("FunSaludPE"))
            .OrgVictimasPE = isDBNullToNothing(fila("OrgVictimasPE"))
            .YoTristezaSE = isDBNullToNothing(fila("YoTristezaSE"))
            .YoMiedoSE = isDBNullToNothing(fila("YoMiedoSE"))
            .YoRabiaSE = isDBNullToNothing(fila("YoRabiaSE"))
            .YoNoDormirSE = isDBNullToNothing(fila("YoNoDormirSE"))
            .YoDolorCabezaSE = isDBNullToNothing(fila("YoDolorCabezaSE"))
            .YoDolorEstomagoSE = isDBNullToNothing(fila("YoDolorEstomagoSE"))
            .YoApetitoSE = isDBNullToNothing(fila("YoApetitoSE"))
            .YoVenganzaSE = isDBNullToNothing(fila("YoVenganzaSE"))
            .YoCulpaSE = isDBNullToNothing(fila("YoCulpaSE"))
            .YoMuertoSE = isDBNullToNothing(fila("YoMuertoSE"))
            .YoRelComuSE = isDBNullToNothing(fila("YoRelComuSE"))
            .YoRelFamisE = isDBNullToNothing(fila("YoRelFamisE"))
            .FamTristezaSE = isDBNullToNothing(fila("FamTristezaSE"))
            .FamMiedoSE = isDBNullToNothing(fila("FamMiedoSE"))
            .FamRabiaSE = isDBNullToNothing(fila("FamRabiaSE"))
            .FamNoDormirSE = isDBNullToNothing(fila("FamNoDormirSE"))
            .FamDolorCabezaSE = isDBNullToNothing(fila("FamDolorCabezaSE"))
            .FamDolorEstomagoSE = isDBNullToNothing(fila("FamDolorEstomagoSE"))
            .FamApetitoSE = isDBNullToNothing(fila("FamApetitoSE"))
            .FamVenganzaSE = isDBNullToNothing(fila("FamVenganzaSE"))
            .FamCulpaSE = isDBNullToNothing(fila("FamCulpaSE"))
            .FamMuertoSE = isDBNullToNothing(fila("FamMuertoSE"))
            .FamRelComuSE = isDBNullToNothing(fila("FamRelComuSE"))
            .FamRelFamiSE = isDBNullToNothing(fila("FamRelFamiSE"))
            .FamiliarSE = isDBNullToNothing(fila("FamiliarSE"))
            .VecinoSE = isDBNullToNothing(fila("VecinoSE"))
            .AyudaEspiritualSE = isDBNullToNothing(fila("AyudaEspiritualSE"))
            .FunSaludSE = isDBNullToNothing(fila("FunSaludSE"))
            .OrgVictimasSE = isDBNullToNothing(fila("OrgVictimasSE"))

        End With

        Return objTmp_Psicosocial

    End Function

    Public Shared Event LoadingTmp_PsicosocialList(ByVal LoadType As String)
    Public Shared Event LoadedTmp_PsicosocialList(ByVal target As List(Of Tmp_PsicosocialBrl), ByVal LoadType As String)

    Public Shared Function CargarTodos() As List(Of Tmp_PsicosocialBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Tmp_PsicosocialBrl)

        RaiseEvent LoadingTmp_PsicosocialList("CargarTodos")

        dsDatos = Tmp_PsicosocialDAL.CargarTodos()

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedTmp_PsicosocialList(lista, "CargarTodos")

        Return lista

    End Function

    Public Shared Event CargandoPorId(ByVal id As Int32)
    Public Shared Event CargadoPorId(ByVal target As Tmp_PsicosocialBrl)

    Public Shared Function CargarPorID(ByVal ID As Int32) As Tmp_PsicosocialBrl

        Dim dsDatos As System.Data.DataSet
        Dim objTmp_Psicosocial As Tmp_PsicosocialBrl = Nothing
        dsDatos = Tmp_PsicosocialDAL.CargarPorID(ID)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objTmp_Psicosocial = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objTmp_Psicosocial

    End Function

    Public Shared Function CargarPorID_Usuario(ByVal ID_Usuario As Int32) As List(Of Tmp_PsicosocialBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Tmp_PsicosocialBrl)

        RaiseEvent LoadingTmp_PsicosocialList("CargarTodos")

        dsDatos = Tmp_PsicosocialDAL.CargarPorID_Usuario(ID_Usuario)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function


    Public Shared Function CargarPorID_Declaracion(ByVal ID_Declaracion As Int32) As Tmp_PsicosocialBrl

        Dim dsDatos As System.Data.DataSet
        Dim objTmp_Psicosocial As Tmp_PsicosocialBrl = Nothing
        dsDatos = Tmp_PsicosocialDAL.CargarPorID_Declaracion(ID_Declaracion)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objTmp_Psicosocial = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objTmp_Psicosocial

    End Function


End Class


