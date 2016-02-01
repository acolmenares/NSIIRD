Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Salud_RemisionesDAL

    Public Shared Function Insertar(ByVal Id_Salud As Int32, ByVal Id_Entidad_Remision As Int32, ByVal Fecha_Remision As DateTime, ByVal Fecha_Ingreso As DateTime, ByVal Fecha_Retiro As DateTime, ByVal Observaciones As String, ByVal Id_Entidad_Informacion As Int32, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Salud_RemisionesInsertar", isNothingToDBNull(Id_Salud), isNothingToDBNull(Id_Entidad_Remision), isNothingToDBNull(Fecha_Remision), isNothingToDBNull(Fecha_Ingreso), isNothingToDBNull(Fecha_Retiro), isNothingToDBNull(Observaciones), isNothingToDBNull(Id_Entidad_Informacion), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Salud As Int32, ByVal Id_Entidad_Remision As Int32, ByVal Fecha_Remision As DateTime, ByVal Fecha_Ingreso As DateTime, ByVal Fecha_Retiro As DateTime, ByVal Observaciones As String, ByVal Id_Entidad_Informacion As Int32, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Salud_RemisionesActualizar", Id, isNothingToDBNull(Id_Salud), isNothingToDBNull(Id_Entidad_Remision), isNothingToDBNull(Fecha_Remision), isNothingToDBNull(Fecha_Ingreso), isNothingToDBNull(Fecha_Retiro), isNothingToDBNull(Observaciones), isNothingToDBNull(Id_Entidad_Informacion), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Salud_RemisionesEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Salud_RemisionesConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Salud_RemisionesConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Entidad_Remision(ByVal Id_Entidad_Remision As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Salud_RemisionesConsultarPorId_Entidad_Remision", Id_Entidad_Remision)
    End Function

    Public Shared Function CargarPorId_Salud(ByVal Id_Salud As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Salud_RemisionesConsultarPorId_Salud", Id_Salud)
    End Function

    Public Shared Function CargarPorId_Entidad_Informacion(ByVal Id_Entidad_Informacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Salud_RemisionesConsultarPorId_Entidad_Informacion", Id_Entidad_Informacion)
    End Function

    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Salud_RemisionesConsultarPorId_Usuario_Creacion", Id_Usuario_Creacion)
    End Function

    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Salud_RemisionesConsultarPorId_Usuario_Modificacion", Id_Usuario_Modificacion)
    End Function

End Class

