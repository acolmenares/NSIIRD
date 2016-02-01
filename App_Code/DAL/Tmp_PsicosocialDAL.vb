﻿Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Tmp_PsicosocialDAL

    Public Shared Function Insertar(ByVal Id_usuario As Int32, ByVal IdDeclaracion As Int32, ByVal fecha_valoracion As DateTime, ByVal regional As String, ByVal Lugar_entrega As String, ByVal Primer_Nombre As String, ByVal Primer_Apellido As String, ByVal Identificacion As String, ByVal Emociones As String, ByVal TipoFamilia As Int32, ByVal YoTristezaPE As Int32, ByVal YoMiedoPE As Int32, ByVal YoRabiaPE As Int32, ByVal YoNoDormirPE As Int32, ByVal YoDolorCabezaPE As Int32, ByVal YoDolorEstomagoPE As Int32, ByVal YoApetitoPE As Int32, ByVal YoVenganzaPE As Int32, ByVal YoCulpaPE As Int32, ByVal YoMuertoPE As Int32, ByVal YoRelComuPE As Int32, ByVal YoRelFamiPE As Int32, ByVal FamTristezaPE As Int32, ByVal FamMiedoPE As Int32, ByVal FamRabiaPE As Int32, ByVal FamNoDormirPE As Int32, ByVal FamDolorCabezaPE As Int32, ByVal FamDolorEstomagoPE As Int32, ByVal FamApetitoPE As Int32, ByVal FamVenganzaPE As Int32, ByVal FamCulpaPE As Int32, ByVal FamMuertoPE As Int32, ByVal FamRelComuPE As Int32, ByVal FamRelFamiPE As Int32, ByVal FamiliarPE As String, ByVal VecinoPE As String, ByVal AyudaEspiritualPE As String, ByVal FunSaludPE As String, ByVal OrgVictimasPE As String, ByVal YoTristezaSE As Int32, ByVal YoMiedoSE As Int32, ByVal YoRabiaSE As Int32, ByVal YoNoDormirSE As Int32, ByVal YoDolorCabezaSE As Int32, ByVal YoDolorEstomagoSE As Int32, ByVal YoApetitoSE As Int32, ByVal YoVenganzaSE As Int32, ByVal YoCulpaSE As Int32, ByVal YoMuertoSE As Int32, ByVal YoRelComuSE As Int32, ByVal YoRelFamisE As Int32, ByVal FamTristezaSE As Int32, ByVal FamMiedoSE As Int32, ByVal FamRabiaSE As Int32, ByVal FamNoDormirSE As Int32, ByVal FamDolorCabezaSE As Int32, ByVal FamDolorEstomagoSE As Int32, ByVal FamApetitoSE As Int32, ByVal FamVenganzaSE As Int32, ByVal FamCulpaSE As Int32, ByVal FamMuertoSE As Int32, ByVal FamRelComuSE As Int32, ByVal FamRelFamiSE As Int32, ByVal FamiliarSE As String, ByVal VecinoSE As String, ByVal AyudaEspiritualSE As String, ByVal FunSaludSE As String, ByVal OrgVictimasSE As String) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Tmp_PsicosocialInsertar", Id_usuario, IdDeclaracion, isNothingToDBNull(fecha_valoracion), isNothingToDBNull(regional), isNothingToDBNull(Lugar_entrega), isNothingToDBNull(Primer_Nombre), isNothingToDBNull(Primer_Apellido), isNothingToDBNull(Identificacion), Emociones, isNothingToDBNull(TipoFamilia), YoTristezaPE, YoMiedoPE, YoRabiaPE, YoNoDormirPE, YoDolorCabezaPE, YoDolorEstomagoPE, YoApetitoPE, YoVenganzaPE, YoCulpaPE, YoMuertoPE, YoRelComuPE, YoRelFamiPE, FamTristezaPE, FamMiedoPE, FamRabiaPE, FamNoDormirPE, FamDolorCabezaPE, FamDolorEstomagoPE, FamApetitoPE, FamVenganzaPE, FamCulpaPE, FamMuertoPE, FamRelComuPE, FamRelFamiPE, FamiliarPE, VecinoPE, AyudaEspiritualPE, FunSaludPE, OrgVictimasPE, YoTristezaSE, YoMiedoSE, YoRabiaSE, YoNoDormirSE, YoDolorCabezaSE, YoDolorEstomagoSE, YoApetitoSE, YoVenganzaSE, YoCulpaSE, YoMuertoSE, YoRelComuSE, YoRelFamisE, FamTristezaSE, FamMiedoSE, FamRabiaSE, FamNoDormirSE, FamDolorCabezaSE, FamDolorEstomagoSE, FamApetitoSE, FamVenganzaSE, FamCulpaSE, FamMuertoSE, FamRelComuSE, FamRelFamiSE, FamiliarSE, VecinoSE, AyudaEspiritualSE, FunSaludSE, OrgVictimasSE)
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_usuario As Int32, ByVal IdDeclaracion As Int32, ByVal fecha_valoracion As DateTime, ByVal regional As String, ByVal Lugar_entrega As String, ByVal Primer_Nombre As String, ByVal Primer_Apellido As String, ByVal Identificacion As String, ByVal Emociones As String, ByVal TipoFamilia As Int32, ByVal YoTristezaPE As Int32, ByVal YoMiedoPE As Int32, ByVal YoRabiaPE As Int32, ByVal YoNoDormirPE As Int32, ByVal YoDolorCabezaPE As Int32, ByVal YoDolorEstomagoPE As Int32, ByVal YoApetitoPE As Int32, ByVal YoVenganzaPE As Int32, ByVal YoCulpaPE As Int32, ByVal YoMuertoPE As Int32, ByVal YoRelComuPE As Int32, ByVal YoRelFamiPE As Int32, ByVal FamTristezaPE As Int32, ByVal FamMiedoPE As Int32, ByVal FamRabiaPE As Int32, ByVal FamNoDormirPE As Int32, ByVal FamDolorCabezaPE As Int32, ByVal FamDolorEstomagoPE As Int32, ByVal FamApetitoPE As Int32, ByVal FamVenganzaPE As Int32, ByVal FamCulpaPE As Int32, ByVal FamMuertoPE As Int32, ByVal FamRelComuPE As Int32, ByVal FamRelFamiPE As Int32, ByVal FamiliarPE As String, ByVal VecinoPE As String, ByVal AyudaEspiritualPE As String, ByVal FunSaludPE As String, ByVal OrgVictimasPE As String, ByVal YoTristezaSE As Int32, ByVal YoMiedoSE As Int32, ByVal YoRabiaSE As Int32, ByVal YoNoDormirSE As Int32, ByVal YoDolorCabezaSE As Int32, ByVal YoDolorEstomagoSE As Int32, ByVal YoApetitoSE As Int32, ByVal YoVenganzaSE As Int32, ByVal YoCulpaSE As Int32, ByVal YoMuertoSE As Int32, ByVal YoRelComuSE As Int32, ByVal YoRelFamisE As Int32, ByVal FamTristezaSE As Int32, ByVal FamMiedoSE As Int32, ByVal FamRabiaSE As Int32, ByVal FamNoDormirSE As Int32, ByVal FamDolorCabezaSE As Int32, ByVal FamDolorEstomagoSE As Int32, ByVal FamApetitoSE As Int32, ByVal FamVenganzaSE As Int32, ByVal FamCulpaSE As Int32, ByVal FamMuertoSE As Int32, ByVal FamRelComuSE As Int32, ByVal FamRelFamiSE As Int32, ByVal FamiliarSE As String, ByVal VecinoSE As String, ByVal AyudaEspiritualSE As String, ByVal FunSaludSE As String, ByVal OrgVictimasSE As String)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Tmp_PsicosocialActualizar", Id, Id_usuario, IdDeclaracion, isNothingToDBNull(fecha_valoracion), isNothingToDBNull(regional), isNothingToDBNull(Lugar_entrega), isNothingToDBNull(Primer_Nombre), isNothingToDBNull(Primer_Apellido), isNothingToDBNull(Identificacion), Emociones, isNothingToDBNull(TipoFamilia), YoTristezaPE, YoMiedoPE, YoRabiaPE, YoNoDormirPE, YoDolorCabezaPE, YoDolorEstomagoPE, YoApetitoPE, YoVenganzaPE, YoCulpaPE, YoMuertoPE, YoRelComuPE, YoRelFamiPE, FamTristezaPE, FamMiedoPE, FamRabiaPE, FamNoDormirPE, FamDolorCabezaPE, FamDolorEstomagoPE, FamApetitoPE, FamVenganzaPE, FamCulpaPE, FamMuertoPE, FamRelComuPE, FamRelFamiPE, FamiliarPE, VecinoPE, AyudaEspiritualPE, FunSaludPE, OrgVictimasPE, YoTristezaSE, YoMiedoSE, YoRabiaSE, YoNoDormirSE, YoDolorCabezaSE, YoDolorEstomagoSE, YoApetitoSE, YoVenganzaSE, YoCulpaSE, YoMuertoSE, YoRelComuSE, YoRelFamisE, FamTristezaSE, FamMiedoSE, FamRabiaSE, FamNoDormirSE, FamDolorCabezaSE, FamDolorEstomagoSE, FamApetitoSE, FamVenganzaSE, FamCulpaSE, FamMuertoSE, FamRelComuSE, FamRelFamiSE, FamiliarSE, VecinoSE, AyudaEspiritualSE, FunSaludSE, OrgVictimasSE)
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Tmp_PsicosocialEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Tmp_PsicosocialConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Tmp_PsicosocialConsultarPorID", Id)
    End Function

    Public Shared Function CargarPorID_Usuario(ByVal Id_Usuario As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Tmp_PsicosocialConsultarPorId_Usuario", Id_Usuario)
    End Function

    Public Shared Function CargarPorId_Declaracion(ByVal Id_Declaracion As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Tmp_PsicosocialConsultarPorId_Declaracion", Id_Declaracion)
    End Function

End Class
