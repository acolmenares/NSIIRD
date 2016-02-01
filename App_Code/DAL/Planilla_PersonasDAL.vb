Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Planilla_PersonasDAL

    Public Shared Function Insertar(ByVal Id_Planilla As Int32, ByVal Id_Persona As Int32) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Planilla_PersonasInsertar", isNothingToDBNull(Id_Planilla), isNothingToDBNull(Id_Persona))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Planilla As Int32, ByVal Id_Persona As Int32)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Planilla_PersonasActualizar", Id, isNothingToDBNull(Id_Planilla), isNothingToDBNull(Id_Persona))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Planilla_PersonasEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Planilla_PersonasConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Planilla_PersonasConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Persona(ByVal Id_Persona As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Planilla_PersonasConsultarPorId_Persona", Id_Persona)
    End Function


    Public Shared Function CargarPorId_Planilla(ByVal Id_Planilla As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Planilla_PersonasConsultarPorId_Planilla", Id_Planilla)
    End Function



End Class

