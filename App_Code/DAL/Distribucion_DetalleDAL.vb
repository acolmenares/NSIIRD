Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Distribucion_DetalleDAL

    Public Shared Function Insertar(ByVal Id_Distribucion As Int32, ByVal Id_Producto As Int32, ByVal Id_Capacidad As Int32, ByVal Cantidad As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Distribucion_DetalleInsertar", isNothingToDBNull(Id_Distribucion), isNothingToDBNull(Id_Producto), isNothingToDBNull(Id_Capacidad), isNothingToDBNull(Cantidad), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Distribucion As Int32, ByVal Id_Producto As Int32, ByVal Id_Capacidad As Int32, ByVal Cantidad As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Distribucion_DetalleActualizar", Id, isNothingToDBNull(Id_Distribucion), isNothingToDBNull(Id_Producto), isNothingToDBNull(Id_Capacidad), isNothingToDBNull(Cantidad), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Distribucion_DetalleEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Distribucion_DetalleConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Distribucion_DetalleConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Capacidad(ByVal Id_Capacidad As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Distribucion_DetalleConsultarPorId_Capacidad", Id_Capacidad)
    End Function


    Public Shared Function CargarPorId_Distribucion(ByVal Id_Distribucion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Distribucion_DetalleConsultarPorId_Distribucion", Id_Distribucion)
    End Function


    Public Shared Function CargarPorId_Producto(ByVal Id_Producto As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Distribucion_DetalleConsultarPorId_Producto", Id_Producto)
    End Function



End Class

