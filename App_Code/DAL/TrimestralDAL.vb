Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class TrimestralDAL

    Public Shared Function Insertar(ByVal Descripcion As String, ByVal Fecha_Inicial As DateTime, ByVal Fecha_Final As DateTime) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.TrimestralInsertar", isNothingToDBNull(Descripcion), isNothingToDBNull(Fecha_Inicial), isNothingToDBNull(Fecha_Final))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Descripcion As String, ByVal Fecha_Inicial As DateTime, ByVal Fecha_Final As DateTime)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.TrimestralActualizar", Id, isNothingToDBNull(Descripcion), isNothingToDBNull(Fecha_Inicial), isNothingToDBNull(Fecha_Final))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.TrimestralEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.TrimestralConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.TrimestralConsultarPorID", Id)
    End Function

End Class

