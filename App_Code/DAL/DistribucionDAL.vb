Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class DistribucionDAL

    Public Shared Function Insertar(ByVal Id_Tipo_Entrega As Int32, ByVal Id_Atendido As Int32, ByVal Fecha As DateTime, ByVal Dias As Int32, ByVal Id_Grupo As Int32, ByVal Id_Salida As Int32, ByVal Id_Racion As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.DistribucionInsertar", isNothingToDBNull(Id_Tipo_Entrega), isNothingToDBNull(Id_Atendido), isNothingToDBNull(Fecha), isNothingToDBNull(Dias), isNothingToDBNull(Id_Grupo), isNothingToDBNull(Id_Salida), isNothingToDBNull(Id_Racion), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Tipo_Entrega As Int32, ByVal Id_Atendido As Int32, ByVal Fecha As DateTime, ByVal Dias As Int32, ByVal Id_Grupo As Int32, ByVal Id_Salida As Int32, ByVal Id_Racion As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.DistribucionActualizar", Id, isNothingToDBNull(Id_Tipo_Entrega), isNothingToDBNull(Id_Atendido), isNothingToDBNull(Fecha), isNothingToDBNull(Dias), isNothingToDBNull(Id_Grupo), isNothingToDBNull(Id_Salida), isNothingToDBNull(Id_Racion), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.DistribucionEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DistribucionConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DistribucionConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Atendido(ByVal Id_Atendido As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DistribucionConsultarPorId_Atendido", Id_Atendido)
    End Function


    Public Shared Function CargarPorId_Grupo(ByVal Id_Grupo As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DistribucionConsultarPorId_Grupo", Id_Grupo)
    End Function


    Public Shared Function CargarPorId_Racion(ByVal Id_Racion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DistribucionConsultarPorId_Racion", Id_Racion)
    End Function


    Public Shared Function CargarPorId_Salida(ByVal Id_Salida As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DistribucionConsultarPorId_Salida", Id_Salida)
    End Function


    Public Shared Function CargarPorId_Tipo_Entrega(ByVal Id_Tipo_Entrega As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DistribucionConsultarPorId_Tipo_Entrega", Id_Tipo_Entrega)
    End Function



End Class

