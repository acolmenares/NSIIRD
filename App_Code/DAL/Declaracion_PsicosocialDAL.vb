Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Declaracion_PsicosocialDAL

    Public Shared Function Insertar(ByVal Id_Declaracion As Int32, ByVal Id_Emocion As Int32, ByVal Dato_Usted As Int32, ByVal Dato_Familia As Int32, ByVal Id_Tipo_Entrega As Int32, Id_Declaracion_Seguimiento As Int32) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Declaracion_PsicosocialInsertar", isNothingToDBNull(Id_Declaracion), isNothingToDBNull(Id_Emocion), isNothingToDBNull(Dato_Usted), isNothingToDBNull(Dato_Familia), isNothingToDBNull(Id_Tipo_Entrega), isNothingToDBNull(Id_Declaracion_Seguimiento))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Declaracion As Int32, ByVal Id_Emocion As Int32, ByVal Dato_Usted As Int32, ByVal Dato_Familia As Int32, ByVal Id_Tipo_Entrega As Int32, Id_Declaracion_Seguimiento As Int32)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Declaracion_PsicosocialActualizar", Id, isNothingToDBNull(Id_Declaracion), isNothingToDBNull(Id_Emocion), isNothingToDBNull(Dato_Usted), isNothingToDBNull(Dato_Familia), isNothingToDBNull(Id_Tipo_Entrega), isNothingToDBNull(Id_Declaracion_Seguimiento))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Declaracion_PsicosocialEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PsicosocialConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PsicosocialConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Declaracion(ByVal Id_Declaracion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PsicosocialConsultarPorId_Declaracion", Id_Declaracion)
    End Function

    Public Shared Function CargarPorId_Emocion(ByVal Id_Emocion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PsicosocialConsultarPorId_Emocion", Id_Emocion)
    End Function

    Public Shared Function CargarPorId_Tipo_Entrega(ByVal Id_Tipo_Entrega As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PsicosocialConsultarPorId_Tipo_Entrega", Id_Tipo_Entrega)
    End Function

    Public Shared Function CargarPorId_Declaracion_Seguimiento(ByVal Id_Declaracion_Seguimiento As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PsicosocialConsultarPorId_Declaracion_Seguimiento", Id_Declaracion_Seguimiento)
    End Function

End Class

