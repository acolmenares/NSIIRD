Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Raciones_RegionalesDAL

    Public Shared Function Insertar(ByVal Id_Racion As Int32, ByVal Id_Regional As Int32) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Raciones_RegionalesInsertar", isNothingToDBNull(Id_Racion), isNothingToDBNull(Id_Regional))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Racion As Int32, ByVal Id_Regional As Int32)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Raciones_RegionalesActualizar", Id, isNothingToDBNull(Id_Racion), isNothingToDBNull(Id_Regional))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Raciones_RegionalesEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Raciones_RegionalesConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Raciones_RegionalesConsultarPorID", Id)
    End Function

    Public Shared Function CargarPorId_Regional(ByVal Id_Regional As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Raciones_RegionalesConsultarPorId_Regional", Id_Regional)
    End Function

    Public Shared Function CargarPorId_Racion(ByVal Id_Racion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Raciones_RegionalesConsultarPorId_Racion", Id_Racion)
    End Function

End Class

