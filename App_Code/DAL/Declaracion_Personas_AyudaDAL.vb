Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Declaracion_Personas_AyudaDAL

    Public Shared Function Insertar(ByVal Id_Declaracion As Int32, ByVal Id_Personas_Ayuda As Int32, ByVal Id_Tipo_Entrega As Int32, Id_Declaracion_Seguimiento As Int32) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Declaracion_Personas_AyudaInsertar", isNothingToDBNull(Id_Declaracion), isNothingToDBNull(Id_Personas_Ayuda), isNothingToDBNull(Id_Tipo_Entrega), isNothingToDBNull(Id_Declaracion_Seguimiento))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Declaracion As Int32, ByVal Id_Personas_Ayuda As Int32, ByVal Id_Tipo_Entrega As Int32, Id_Declaracion_Seguimiento As Int32)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Declaracion_Personas_AyudaActualizar", Id, isNothingToDBNull(Id_Declaracion), isNothingToDBNull(Id_Personas_Ayuda), isNothingToDBNull(Id_Tipo_Entrega), isNothingToDBNull(Id_Declaracion_Seguimiento))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Declaracion_Personas_AyudaEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_Personas_AyudaConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_Personas_AyudaConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Declaracion(ByVal Id_Declaracion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_Personas_AyudaConsultarPorId_Declaracion", Id_Declaracion)
    End Function

    Public Shared Function CargarPorId_Personas_Ayuda(ByVal Id_Personas_Ayuda As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_Personas_AyudaConsultarPorId_Personas_Ayuda", Id_Personas_Ayuda)
    End Function

    Public Shared Function CargarPorId_Tipo_Entrega(ByVal Id_Tipo_Entrega As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_Personas_AyudaConsultarPorId_Tipo_Entrega", Id_Tipo_Entrega)
    End Function

    Public Shared Function CargarPorId_Declaracion_Seguimiento(ByVal Id_Declaracion_Seguimiento As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_Personas_AyudaConsultarPorId_Declaracion_Seguimiento", Id_Declaracion_Seguimiento)
    End Function

End Class

