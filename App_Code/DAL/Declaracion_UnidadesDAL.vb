Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Declaracion_UnidadesDAL

    Public Shared Function Insertar(ByVal Id_Declaracion As Int32, ByVal Id_Unidad As Int32, ByVal Id_EstadoUnidad As Int32, ByVal Fecha_Inclusion As DateTime, ByVal Fecha_Investigacion As DateTime, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean, ByVal Fuente As String) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Declaracion_UnidadesInsertar", isNothingToDBNull(Id_Declaracion), isNothingToDBNull(Id_Unidad), isNothingToDBNull(Id_EstadoUnidad), isNothingToDBNull(Fecha_Inclusion), isNothingToDBNull(Fecha_Investigacion), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre), isNothingToDBNull(Fuente))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Declaracion As Int32, ByVal Id_Unidad As Int32, ByVal Id_EstadoUnidad As Int32, ByVal Fecha_Inclusion As DateTime, ByVal Fecha_Investigacion As DateTime, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean, ByVal Fuente As String)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Declaracion_UnidadesActualizar", Id, isNothingToDBNull(Id_Declaracion), isNothingToDBNull(Id_Unidad), isNothingToDBNull(Id_EstadoUnidad), isNothingToDBNull(Fecha_Inclusion), isNothingToDBNull(Fecha_Investigacion), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre), isNothingToDBNull(Fuente))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Declaracion_UnidadesEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_UnidadesConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_UnidadesConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Declaracion(ByVal Id_Declaracion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_UnidadesConsultarPorId_Declaracion", Id_Declaracion)
    End Function

    Public Shared Function CargarPorId_EstadoUnidad(ByVal Id_EstadoUnidad As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_UnidadesConsultarPorId_EstadoUnidad", Id_EstadoUnidad)
    End Function

    Public Shared Function CargarPorId_Unidad(ByVal Id_Unidad As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_UnidadesConsultarPorId_Unidad", Id_Unidad)
    End Function

    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_UnidadesConsultarPorId_Usuario_Creacion", Id_Usuario_Creacion)
    End Function

    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_UnidadesConsultarPorId_Usuario_Modificacion", Id_Usuario_Modificacion)
    End Function

End Class

