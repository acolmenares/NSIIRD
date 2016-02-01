Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Trimestral_GruposDAL

    Public Shared Function Insertar(ByVal Id_Trimestral As Int32, ByVal Id_Grupo As Int32) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Trimestral_GruposInsertar", isNothingToDBNull(Id_Trimestral), isNothingToDBNull(Id_Grupo))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Trimestral As Int32, ByVal Id_Grupo As Int32)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Trimestral_GruposActualizar", Id, isNothingToDBNull(Id_Trimestral), isNothingToDBNull(Id_Grupo))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Trimestral_GruposEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Trimestral_GruposConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Trimestral_GruposConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Grupo(ByVal Id_Grupo As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Trimestral_GruposConsultarPorId_Grupo", Id_Grupo)
    End Function


    Public Shared Function CargarPorId_Trimestral(ByVal Id_Trimestral As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Trimestral_GruposConsultarPorId_Trimestral", Id_Trimestral)
    End Function



End Class

