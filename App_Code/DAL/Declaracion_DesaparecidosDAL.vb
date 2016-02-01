Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Declaracion_DesaparecidosDAL

    Public Shared Function Insertar(ByVal Id_Declaracion As Int32, ByVal Id_Parentesco As Int32, ByVal Id_Reporto As Int32, ByVal Id_PorQueNo_Reporto As Int32, ByVal Id_Lugar_Denuncia As Int32) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Declaracion_DesaparecidosInsertar", isNothingToDBNull(Id_Declaracion), isNothingToDBNull(Id_Parentesco), isNothingToDBNull(Id_Reporto), isNothingToDBNull(Id_PorQueNo_Reporto), isNothingToDBNull(Id_Lugar_Denuncia))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Declaracion As Int32, ByVal Id_Parentesco As Int32, ByVal Id_Reporto As Int32, ByVal Id_PorQueNo_Reporto As Int32, ByVal Id_Lugar_Denuncia As Int32)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Declaracion_DesaparecidosActualizar", Id, isNothingToDBNull(Id_Declaracion), isNothingToDBNull(Id_Parentesco), isNothingToDBNull(Id_Reporto), isNothingToDBNull(Id_PorQueNo_Reporto), isNothingToDBNull(Id_Lugar_Denuncia))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Declaracion_DesaparecidosEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_DesaparecidosConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_DesaparecidosConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Declaracion(ByVal Id_Declaracion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_DesaparecidosConsultarPorId_Declaracion", Id_Declaracion)
    End Function


    Public Shared Function CargarPorId_Lugar_Denuncia(ByVal Id_Lugar_Denuncia As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_DesaparecidosConsultarPorId_Lugar_Denuncia", Id_Lugar_Denuncia)
    End Function


    Public Shared Function CargarPorId_Parentesco(ByVal Id_Parentesco As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_DesaparecidosConsultarPorId_Parentesco", Id_Parentesco)
    End Function


    Public Shared Function CargarPorId_PorQueNo_Reporto(ByVal Id_PorQueNo_Reporto As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_DesaparecidosConsultarPorId_PorQueNo_Reporto", Id_PorQueNo_Reporto)
    End Function


    Public Shared Function CargarPorId_Reporto(ByVal Id_Reporto As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_DesaparecidosConsultarPorId_Reporto", Id_Reporto)
    End Function



End Class

