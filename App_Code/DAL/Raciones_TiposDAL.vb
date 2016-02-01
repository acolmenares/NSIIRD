Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Raciones_TiposDAL

    Public Shared Function Insertar(ByVal Id_Racion As Int32, ByVal Tipo As Int32) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Raciones_TiposInsertar", isNothingToDBNull(Id_Racion), isNothingToDBNull(Tipo))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Racion As Int32, ByVal Tipo As Int32)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Raciones_TiposActualizar", Id, isNothingToDBNull(Id_Racion), isNothingToDBNull(Tipo))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Raciones_TiposEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Raciones_TiposConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Raciones_TiposConsultarPorID", Id)
    End Function

    Public Shared Function CargarPorId_Racion(ByVal Id_Racion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Raciones_TiposConsultarPorId_Racion", Id_Racion)
    End Function

End Class

