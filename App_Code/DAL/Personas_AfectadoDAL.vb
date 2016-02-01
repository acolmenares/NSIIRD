Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Personas_AfectadoDAL

    Public Shared Function Insertar(ByVal Id_Persona As Int32, ByVal Id_Tipo_Entrega As Int32, ByVal Id_Afectado As Int32) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Personas_AfectadoInsertar", isNothingToDBNull(Id_Persona), isNothingToDBNull(Id_Tipo_Entrega), isNothingToDBNull(Id_Afectado))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Persona As Int32, ByVal Id_Tipo_Entrega As Int32, ByVal Id_Afectado As Int32)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Personas_AfectadoActualizar", Id, isNothingToDBNull(Id_Persona), isNothingToDBNull(Id_Tipo_Entrega), isNothingToDBNull(Id_Afectado))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Personas_AfectadoEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_AfectadoConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_AfectadoConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Afectado(ByVal Id_Afectado As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_AfectadoConsultarPorId_Afectado", Id_Afectado)
    End Function

    Public Shared Function CargarPorId_Persona(ByVal Id_Persona As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_AfectadoConsultarPorId_Persona", Id_Persona)
    End Function

    Public Shared Function CargarPorId_Tipo_Entrega(ByVal Id_Tipo_Entrega As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_AfectadoConsultarPorId_Tipo_Entrega", Id_Tipo_Entrega)
    End Function

End Class

