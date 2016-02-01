Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class EntregasDAL

    Public Shared Function Insertar(ByVal Fecha As DateTime, ByVal Dias As Int32, ByVal Id_Declaracion As Int32, ByVal Id_Tipo As Int32, ByVal Id_Producto As Int32, ByVal Id_Capacidad As Int32, ByVal Cantidad As Double, ByVal Id_Orden_Salida As Int32, ByVal Id_Racion As Int32, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.EntregasInsertar", isNothingToDBNull(Fecha), isNothingToDBNull(Dias), isNothingToDBNull(Id_Declaracion), isNothingToDBNull(Id_Tipo), isNothingToDBNull(Id_Producto), isNothingToDBNull(Id_Capacidad), isNothingToDBNull(Cantidad), isNothingToDBNull(Id_Orden_Salida), isNothingToDBNull(Id_Racion), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Fecha As DateTime, ByVal Dias As Int32, ByVal Id_Declaracion As Int32, ByVal Id_Tipo As Int32, ByVal Id_Producto As Int32, ByVal Id_Capacidad As Int32, ByVal Cantidad As Double, ByVal Id_Orden_Salida As Int32, ByVal Id_Racion As Int32, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.EntregasActualizar", Id, isNothingToDBNull(Fecha), isNothingToDBNull(Dias), isNothingToDBNull(Id_Declaracion), isNothingToDBNull(Id_Tipo), isNothingToDBNull(Id_Producto), isNothingToDBNull(Id_Capacidad), isNothingToDBNull(Cantidad), isNothingToDBNull(Id_Orden_Salida), isNothingToDBNull(Id_Racion), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.EntregasEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.EntregasConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.EntregasConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Capacidad(ByVal Id_Capacidad As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.EntregasConsultarPorId_Capacidad", Id_Capacidad)
    End Function


    Public Shared Function CargarPorId_Declaracion(ByVal Id_Declaracion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.EntregasConsultarPorId_Declaracion", Id_Declaracion)
    End Function


    Public Shared Function CargarPorId_Producto(ByVal Id_Producto As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.EntregasConsultarPorId_Producto", Id_Producto)
    End Function


    Public Shared Function CargarPorId_Racion(ByVal Id_Racion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.EntregasConsultarPorId_Racion", Id_Racion)
    End Function


    Public Shared Function CargarPorId_Tipo(ByVal Id_Tipo As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.EntregasConsultarPorId_Tipo", Id_Tipo)
    End Function


    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.EntregasConsultarPorId_Usuario_Creacion", Id_Usuario_Creacion)
    End Function


    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.EntregasConsultarPorId_Usuario_Modificacion", Id_Usuario_Modificacion)
    End Function


    Public Shared Function CargarPorId_Orden_Salida(ByVal Id_Orden_Salida As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.EntregasConsultarPorId_Orden_Salida", Id_Orden_Salida)
    End Function



End Class

