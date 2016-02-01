Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class PlanillaDAL

    Public Shared Function Insertar(ByVal Id_Grupo As Int32, ByVal Fecha As DateTime, ByVal Id_Tipo_Declaracion As Int32, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.PlanillaInsertar", isNothingToDBNull(Id_Grupo), isNothingToDBNull(Fecha), isNothingToDBNull(Id_Tipo_Declaracion), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Grupo As Int32, ByVal Fecha As DateTime, ByVal Id_Tipo_Declaracion As Int32, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.PlanillaActualizar", Id, isNothingToDBNull(Id_Grupo), isNothingToDBNull(Fecha), isNothingToDBNull(Id_Tipo_Declaracion), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.PlanillaEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PlanillaConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PlanillaConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Grupo(ByVal Id_Grupo As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PlanillaConsultarPorId_Grupo", Id_Grupo)
    End Function


    Public Shared Function CargarPorId_Tipo_Declaracion(ByVal Id_Tipo_Declaracion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PlanillaConsultarPorId_Tipo_Declaracion", Id_Tipo_Declaracion)
    End Function



End Class

