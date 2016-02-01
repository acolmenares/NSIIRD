Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Salidas_DetalleEntradasDAL

    Public Shared Function Insertar(ByVal Id_Salida_Detalle As Int32, ByVal Cantidad As Double, ByVal Id_Entrada_Distribucion As Int32, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Salidas_Detalle_EntradasInsertar", isNothingToDBNull(Id_Salida_Detalle), isNothingToDBNull(Cantidad), isNothingToDBNull(Id_Entrada_Distribucion), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Salida_Detalle As Int32, ByVal Cantidad As Double, ByVal Id_Entrada_Distribucion As Int32, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Salidas_Detalle_EntradasActualizar", Id, isNothingToDBNull(Id_Salida_Detalle), isNothingToDBNull(Cantidad), isNothingToDBNull(Id_Entrada_Distribucion), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Salidas_Detalle_EntradasEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Salidas_Detalle_EntradasConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Salidas_Detalle_EntradasConsultarPorID", Id)
    End Function

    Public Shared Function CargarPorId_Entrada_Distribucion(ByVal Id_Entrada_Distribucion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Salidas_Detalle_EntradasConsultarPorId_Entrada_Distribucion", Id_Entrada_Distribucion)
    End Function

    Public Shared Function CargarPorId_Salida_Detalle(ByVal Id_Salida_Detalle As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Salidas_Detalle_EntradasConsultarPorId_Salida_Detalle", Id_Salida_Detalle)
    End Function

    Public Shared Function CantidadSalidasEntrada(ByVal Id_Entrada_Distribucion As System.Int32) As Double
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Salidas_Detalle_EntradasConsultarPorCantidadSalidasEntradas", Id_Entrada_Distribucion)
    End Function

    Public Shared Function CargarEspecialPorId_Salida(ByVal Id_Salida As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Salidas_Detalle_EntradasConsultarEspecialPorId_Salida", Id_Salida)
    End Function

End Class

