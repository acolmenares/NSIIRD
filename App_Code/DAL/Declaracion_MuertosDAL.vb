Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Declaracion_MuertosDAL

    Public Shared Function Insertar(ByVal Id_Declaracion As Int32, ByVal Tipo As String, ByVal Mayor_Menor As String, ByVal Id_Motivo_Muerte As Int32, ByVal Id_Enfermedad As Int32, ByVal Id_Parentesco As Int32, ByVal Id_Velar_Enterrar As Int32) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Declaracion_MuertosInsertar", isNothingToDBNull(Id_Declaracion), isNothingToDBNull(Tipo), isNothingToDBNull(Mayor_Menor), isNothingToDBNull(Id_Motivo_Muerte), isNothingToDBNull(Id_Enfermedad), isNothingToDBNull(Id_Parentesco), isNothingToDBNull(Id_Velar_Enterrar))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Declaracion As Int32, ByVal Tipo As String, ByVal Mayor_Menor As String, ByVal Id_Motivo_Muerte As Int32, ByVal Id_Enfermedad As Int32, ByVal Id_Parentesco As Int32, ByVal Id_Velar_Enterrar As Int32)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Declaracion_MuertosActualizar", Id, isNothingToDBNull(Id_Declaracion), isNothingToDBNull(Tipo), isNothingToDBNull(Mayor_Menor), isNothingToDBNull(Id_Motivo_Muerte), isNothingToDBNull(Id_Enfermedad), isNothingToDBNull(Id_Parentesco), isNothingToDBNull(Id_Velar_Enterrar))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Declaracion_MuertosEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_MuertosConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_MuertosConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Declaracion(ByVal Id_Declaracion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_MuertosConsultarPorId_Declaracion", Id_Declaracion)
    End Function


    Public Shared Function CargarPorId_Enfermedad(ByVal Id_Enfermedad As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_MuertosConsultarPorId_Enfermedad", Id_Enfermedad)
    End Function


    Public Shared Function CargarPorId_Motivo_Muerte(ByVal Id_Motivo_Muerte As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_MuertosConsultarPorId_Motivo_Muerte", Id_Motivo_Muerte)
    End Function


    Public Shared Function CargarPorId_Parentesco(ByVal Id_Parentesco As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_MuertosConsultarPorId_Parentesco", Id_Parentesco)
    End Function


    Public Shared Function CargarPorId_Velar_Enterrar(ByVal Id_Velar_Enterrar As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_MuertosConsultarPorId_Velar_Enterrar", Id_Velar_Enterrar)
    End Function



End Class

