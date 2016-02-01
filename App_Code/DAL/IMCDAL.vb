Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class IMCDAL

    Public Shared Function Insertar(ByVal Semana As Int32, ByVal Estado As String, ByVal Imc_Inicial As Double, ByVal Imc_Final As Double) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.IMCInsertar", isNothingToDBNull(Semana), isNothingToDBNull(Estado), isNothingToDBNull(Imc_Inicial), isNothingToDBNull(Imc_Final))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Semana As Int32, ByVal Estado As String, ByVal Imc_Inicial As Double, ByVal Imc_Final As Double)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.IMCActualizar", Id, isNothingToDBNull(Semana), isNothingToDBNull(Estado), isNothingToDBNull(Imc_Inicial), isNothingToDBNull(Imc_Final))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.IMCEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.IMCConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.IMCConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorConsultaBase(ByVal Semana As Int32, ByVal IMC As Double) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.IMCConsultarPorConsultaBase", Semana, IMC)
    End Function

End Class

