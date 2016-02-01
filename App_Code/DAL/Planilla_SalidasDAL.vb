Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Planilla_SalidasDAL

    Public Shared Function Insertar(ByVal Id_Planilla As Int32, ByVal Id_Salida As Int32) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Planilla_SalidasInsertar", isNothingToDBNull(Id_Planilla), isNothingToDBNull(Id_Salida))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Planilla As Int32, ByVal Id_Salida As Int32)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Planilla_SalidasActualizar", Id, isNothingToDBNull(Id_Planilla), isNothingToDBNull(Id_Salida))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Planilla_SalidasEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Planilla_SalidasConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Planilla_SalidasConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Planilla(ByVal Id_Planilla As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Planilla_SalidasConsultarPorId_Planilla", Id_Planilla)
    End Function


    Public Shared Function CargarPorId_Salida(ByVal Id_Salida As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Planilla_SalidasConsultarPorId_Salida", Id_Salida)
    End Function



End Class

