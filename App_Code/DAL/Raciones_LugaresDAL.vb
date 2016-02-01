Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Raciones_LugaresDAL

    Public Shared Function Insertar(ByVal Id_Racion As Int32, ByVal Id_LugarEntrega As Int32) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Raciones_LugaresInsertar", isNothingToDBNull(Id_Racion), isNothingToDBNull(Id_LugarEntrega))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Racion As Int32, ByVal Id_LugarEntrega As Int32)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Raciones_LugaresActualizar", Id, isNothingToDBNull(Id_Racion), isNothingToDBNull(Id_LugarEntrega))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Raciones_LugaresEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Raciones_LugaresConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Raciones_LugaresConsultarPorID", Id)
    End Function

    Public Shared Function CargarPorId_LugarEntrega(ByVal Id_LugarEntrega As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Raciones_LugaresConsultarPorId_LugarEntrega", Id_LugarEntrega)
    End Function

    Public Shared Function CargarPorId_Racion(ByVal Id_Racion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Raciones_LugaresConsultarPorId_Racion", Id_Racion)
    End Function

End Class

