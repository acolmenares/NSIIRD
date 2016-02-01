Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Personas_Regimen_SaludDAL

    Public Shared Function Insertar(ByVal Id_Persona As Int32, ByVal Id_Tipo_Entrega As Int32, ByVal Id_Regimen_Salud As Int32, ByVal Id_Eps As Int32, ByVal Municipio As String, ByVal Fecha As DateTime, ByVal Id_Necesita_Traslado As Int32, ByVal Id_Motivo_No_Necesita_Traslado As Int32, ByVal Id_Realizo_Traslado As Int32, ByVal Id_Motivo_No_Realizo_Traslado As Int32, ByVal Observaciones As String, ByVal Id_Cerrar As Int32, Id_Declaracion_Seguimiento As Int32, ByVal Id_Municipio As Int32) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Personas_Regimen_SaludInsertar", isNothingToDBNull(Id_Persona), isNothingToDBNull(Id_Tipo_Entrega), isNothingToDBNull(Id_Regimen_Salud), isNothingToDBNull(Id_Eps), isNothingToDBNull(Municipio), isNothingToDBNull(Fecha), isNothingToDBNull(Id_Necesita_Traslado), isNothingToDBNull(Id_Motivo_No_Necesita_Traslado), isNothingToDBNull(Id_Realizo_Traslado), isNothingToDBNull(Id_Motivo_No_Realizo_Traslado), isNothingToDBNull(Observaciones), isNothingToDBNull(Id_Cerrar), isNothingToDBNull(Id_Declaracion_Seguimiento), isNothingToDBNull(Id_Municipio))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Persona As Int32, ByVal Id_Tipo_Entrega As Int32, ByVal Id_Regimen_Salud As Int32, ByVal Id_Eps As Int32, ByVal Municipio As String, ByVal Fecha As DateTime, ByVal Id_Necesita_Traslado As Int32, ByVal Id_Motivo_No_Necesita_Traslado As Int32, ByVal Id_Realizo_Traslado As Int32, ByVal Id_Motivo_No_Realizo_Traslado As Int32, ByVal Observaciones As String, ByVal Id_Cerrar As Int32, Id_Declaracion_Seguimiento As Int32, ByVal Id_Municipio As Int32)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Personas_Regimen_SaludActualizar", Id, isNothingToDBNull(Id_Persona), isNothingToDBNull(Id_Tipo_Entrega), isNothingToDBNull(Id_Regimen_Salud), isNothingToDBNull(Id_Eps), isNothingToDBNull(Municipio), isNothingToDBNull(Fecha), isNothingToDBNull(Id_Necesita_Traslado), isNothingToDBNull(Id_Motivo_No_Necesita_Traslado), isNothingToDBNull(Id_Realizo_Traslado), isNothingToDBNull(Id_Motivo_No_Realizo_Traslado), isNothingToDBNull(Observaciones), isNothingToDBNull(Id_Cerrar), isNothingToDBNull(Id_Declaracion_Seguimiento), isNothingToDBNull(Id_Municipio))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Personas_Regimen_SaludEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_Regimen_SaludConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_Regimen_SaludConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Eps(ByVal Id_Eps As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_Regimen_SaludConsultarPorId_Eps", Id_Eps)
    End Function

    Public Shared Function CargarPorId_Persona(ByVal Id_Persona As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_Regimen_SaludConsultarPorId_Persona", Id_Persona)
    End Function

    Public Shared Function CargarPorId_Regimen_Salud(ByVal Id_Regimen_Salud As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_Regimen_SaludConsultarPorId_Regimen_Salud", Id_Regimen_Salud)
    End Function

    Public Shared Function CargarPorId_Tipo_Entrega(ByVal Id_Tipo_Entrega As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_Regimen_SaludConsultarPorId_Tipo_Entrega", Id_Tipo_Entrega)
    End Function

    Public Shared Function CargarPorIDySegundaEntrega(ByVal Id_Persona As Int32, ByVal Id_Tipo_Entrega As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_Regimen_SaludConsultarPorIdyId_Tipo_Entrega", Id_Persona, Id_Tipo_Entrega)
    End Function

    Public Shared Function CargarPorId_Necesita_Traslado(ByVal Id_Necesita_Traslado As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_Regimen_SaludConsultarPorId_Necesita_Traslado", Id_Necesita_Traslado)
    End Function

    Public Shared Function CargarPorId_Motivo_No_Necesita_Traslado(ByVal Id_Motivo_No_Necesita_Traslado As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_Regimen_SaludConsultarPorId_Motivo_No_Necesita_Traslado", Id_Motivo_No_Necesita_Traslado)
    End Function

    Public Shared Function CargarPorId_Realizo_Traslado(ByVal Id_Realizo_Traslado As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_Regimen_SaludConsultarPorId_Realizo_Traslado", Id_Realizo_Traslado)
    End Function

    Public Shared Function CargarPorId_Motivo_No_Realizo_Traslado(ByVal Id_Motivo_No_Realizo_Traslado As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_Regimen_SaludConsultarPorId_Motivo_No_Realizo_Traslado", Id_Motivo_No_Realizo_Traslado)
    End Function

    Public Shared Function CargarPorId_Cerrar(ByVal Id_Cerrar As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_Regimen_SaludConsultarPorId_Cerrar", Id_Cerrar)
    End Function

    Public Shared Function CargarPorId_Declaracion_Seguimiento(ByVal Id_Declaracion_Seguimiento As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_Regimen_SaludConsultarPorId_Declaracion_Seguimiento", Id_Declaracion_Seguimiento)
    End Function

End Class

