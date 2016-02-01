Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Salidas_AprobacionesDAL

    Public Shared Function Insertar(ByVal Id_Salida As Int32, ByVal Aprobacion_Logistica_Oficina As Boolean, ByVal Fecha_ALO As DateTime, ByVal Aprobacion_Finanzas_Oficina As Boolean, ByVal Fecha_AFO As DateTime, ByVal Aprobacion_Coordinador_Oficina As Boolean, ByVal Fecha_ACO As DateTime, ByVal Aprobacion_Coordinador_Logistica As Boolean, ByVal Fecha_ACL As DateTime, ByVal Aprobacion_Director_Financiero As Boolean, ByVal Fecha_ADF As DateTime, ByVal Aprobacion_Director_Pais As Boolean, ByVal Fecha_ADP As DateTime, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Salidas_AprobacionesInsertar", isNothingToDBNull(Id_Salida), isNothingToDBNull(Aprobacion_Logistica_Oficina), isNothingToDBNull(Fecha_ALO), isNothingToDBNull(Aprobacion_Finanzas_Oficina), isNothingToDBNull(Fecha_AFO), isNothingToDBNull(Aprobacion_Coordinador_Oficina), isNothingToDBNull(Fecha_ACO), isNothingToDBNull(Aprobacion_Coordinador_Logistica), isNothingToDBNull(Fecha_ACL), isNothingToDBNull(Aprobacion_Director_Financiero), isNothingToDBNull(Fecha_ADF), isNothingToDBNull(Aprobacion_Director_Pais), isNothingToDBNull(Fecha_ADP), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Salida As Int32, ByVal Aprobacion_Logistica_Oficina As Boolean, ByVal Fecha_ALO As DateTime, ByVal Aprobacion_Finanzas_Oficina As Boolean, ByVal Fecha_AFO As DateTime, ByVal Aprobacion_Coordinador_Oficina As Boolean, ByVal Fecha_ACO As DateTime, ByVal Aprobacion_Coordinador_Logistica As Boolean, ByVal Fecha_ACL As DateTime, ByVal Aprobacion_Director_Financiero As Boolean, ByVal Fecha_ADF As DateTime, ByVal Aprobacion_Director_Pais As Boolean, ByVal Fecha_ADP As DateTime, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Salidas_AprobacionesActualizar", Id, isNothingToDBNull(Id_Salida), isNothingToDBNull(Aprobacion_Logistica_Oficina), isNothingToDBNull(Fecha_ALO), isNothingToDBNull(Aprobacion_Finanzas_Oficina), isNothingToDBNull(Fecha_AFO), isNothingToDBNull(Aprobacion_Coordinador_Oficina), isNothingToDBNull(Fecha_ACO), isNothingToDBNull(Aprobacion_Coordinador_Logistica), isNothingToDBNull(Fecha_ACL), isNothingToDBNull(Aprobacion_Director_Financiero), isNothingToDBNull(Fecha_ADF), isNothingToDBNull(Aprobacion_Director_Pais), isNothingToDBNull(Fecha_ADP), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Salidas_AprobacionesEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Salidas_AprobacionesConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Salidas_AprobacionesConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Salida(ByVal Id_Salida As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Salidas_AprobacionesConsultarPorId_Salida", Id_Salida)
    End Function

End Class

