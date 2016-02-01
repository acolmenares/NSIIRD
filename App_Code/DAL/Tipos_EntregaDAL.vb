Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Tipos_EntregaDAL

    Public Shared Function Insertar(ByVal Descripcion As String, ByVal Dias As Int32) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Tipos_EntregaInsertar", isNothingToDBNull(Descripcion), isNothingToDBNull(Dias))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Descripcion As String, ByVal Dias As Int32)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Tipos_EntregaActualizar", Id, isNothingToDBNull(Descripcion), isNothingToDBNull(Dias))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Tipos_EntregaEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Tipos_EntregaConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Tipos_EntregaConsultarPorID", Id)
    End Function
    

End Class

