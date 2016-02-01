Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class RacionesDAL

    Public Shared Function Insertar(ByVal Id_Producto As Int32, ByVal Fecha_Inicial As DateTime, ByVal Fecha_Final As DateTime, ByVal Cantidad As Double, ByVal Id_Capacidad As Int32, ByVal Por_persona As Boolean, ByVal Por_Familia As Boolean, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.RacionesInsertar", isNothingToDBNull(Id_Producto), isNothingToDBNull(Fecha_Inicial), isNothingToDBNull(Fecha_Final), isNothingToDBNull(Cantidad), isNothingToDBNull(Id_Capacidad), isNothingToDBNull(Por_persona), isNothingToDBNull(Por_Familia), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Producto As Int32, ByVal Fecha_Inicial As DateTime, ByVal Fecha_Final As DateTime, ByVal Cantidad As Double, ByVal Id_Capacidad As Int32, ByVal Por_persona As Boolean, ByVal Por_Familia As Boolean, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.RacionesActualizar", Id, isNothingToDBNull(Id_Producto), isNothingToDBNull(Fecha_Inicial), isNothingToDBNull(Fecha_Final), isNothingToDBNull(Cantidad), isNothingToDBNull(Id_Capacidad), isNothingToDBNull(Por_persona), isNothingToDBNull(Por_Familia), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.RacionesEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.RacionesConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.RacionesConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Capacidad(ByVal Id_Capacidad As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.RacionesConsultarPorId_Capacidad", Id_Capacidad)
    End Function

    Public Shared Function CargarPorId_Producto(ByVal Id_Producto As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.RacionesConsultarPorId_Producto", Id_Producto)
    End Function

    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.RacionesConsultarPorId_Usuario_Creacion", Id_Usuario_Creacion)
    End Function

    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.RacionesConsultarPorId_Usuario_Modificacion", Id_Usuario_Modificacion)
    End Function

    Public Shared Function CargarRaciones(ByVal Fecha As String, ByVal Id_Lugar As Int32, ByVal Id_TipoEntrega As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.RacionesCargarRaciones", Fecha, Id_Lugar, Id_TipoEntrega)
    End Function

End Class

