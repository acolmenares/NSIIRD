Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Entregas_AdicionalesDAL

    Public Shared Function Insertar(ByVal Fecha As DateTime, ByVal Id_Tipo_Entrega As Int32, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean, ByVal Id_Programa As Int32) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Entregas_AdicionalesInsertar", isNothingToDBNull(Fecha), isNothingToDBNull(Id_Tipo_Entrega), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre), isNothingToDBNull(Id_Programa))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Fecha As DateTime, ByVal Id_Tipo_Entrega As Int32, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean, ByVal Id_Programa As Int32)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Entregas_AdicionalesActualizar", Id, isNothingToDBNull(Fecha), isNothingToDBNull(Id_Tipo_Entrega), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre), isNothingToDBNull(Id_Programa))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Entregas_AdicionalesEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_AdicionalesConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_AdicionalesConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Programa(ByVal Id_Programa As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_AdicionalesConsultarPorId_Programa", Id_Programa)
    End Function

    Public Shared Function CargarPorId_Tipo_Entrega(ByVal Id_Tipo_Entrega As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_AdicionalesConsultarPorId_Tipo_Entrega", Id_Tipo_Entrega)
    End Function

    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_AdicionalesConsultarPorId_Usuario_Creacion", Id_Usuario_Creacion)
    End Function

    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_AdicionalesConsultarPorId_Usuario_Modificacion", Id_Usuario_Modificacion)
    End Function

End Class

