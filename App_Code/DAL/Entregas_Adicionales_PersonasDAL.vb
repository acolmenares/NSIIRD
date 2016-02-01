Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Entregas_Adicionales_PersonasDAL

    Public Shared Function Insertar(ByVal Id_Persona As Int32, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean, Id_Entrega_Adicional As Int32, Id_Declaracion_Seguimiento As Int32) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Entregas_Adicionales_PersonasInsertar", isNothingToDBNull(Id_Persona), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre), isNothingToDBNull(Id_Entrega_Adicional), isNothingToDBNull(Id_Declaracion_Seguimiento))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Persona As Int32, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean, Id_Entrega_Adicional As Int32, Id_Declaracion_Seguimiento As Int32)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Entregas_Adicionales_PersonasActualizar", Id, isNothingToDBNull(Id_Persona), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre), isNothingToDBNull(Id_Entrega_Adicional), isNothingToDBNull(Id_Declaracion_Seguimiento))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Entregas_Adicionales_PersonasEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_PersonasConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_PersonasConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Entrega_Adicional(ByVal Id_Entrega_Adicional As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_PersonasConsultarPorId_Entrega_Adicional", Id_Entrega_Adicional)
    End Function

    Public Shared Function CargarPorId_Persona(ByVal Id_Persona As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_PersonasConsultarPorId_Persona", Id_Persona)
    End Function

    Public Shared Function CargarPorId_Declaracion_Seguimiento(ByVal Id_Declaracion_Seguimiento As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_PersonasConsultarPorId_Declaracion_Seguimiento", Id_Declaracion_Seguimiento)
    End Function

    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_PersonasConsultarPorId_Usuario_Creacion", Id_Usuario_Creacion)
    End Function

    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_PersonasConsultarPorId_Usuario_Modificacion", Id_Usuario_Modificacion)
    End Function

End Class

