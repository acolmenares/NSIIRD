Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Planilla_Personas_ProductosDAL

    Public Shared Function Insertar(ByVal Id_Planilla_Personas As Int32, ByVal Id_Producto As Int32, ByVal Cantidad As Double) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Planilla_Personas_ProductosInsertar", isNothingToDBNull(Id_Planilla_Personas), isNothingToDBNull(Id_Producto), isNothingToDBNull(Cantidad))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Planilla_Personas As Int32, ByVal Id_Producto As Int32, ByVal Cantidad As Double)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Planilla_Personas_ProductosActualizar", Id, isNothingToDBNull(Id_Planilla_Personas), isNothingToDBNull(Id_Producto), isNothingToDBNull(Cantidad))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Planilla_Personas_ProductosEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Planilla_Personas_ProductosConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Planilla_Personas_ProductosConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Planilla_Personas(ByVal Id_Planilla_Personas As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Planilla_Personas_ProductosConsultarPorId_Planilla_Personas", Id_Planilla_Personas)
    End Function


    Public Shared Function CargarPorId_Producto(ByVal Id_Producto As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Planilla_Personas_ProductosConsultarPorId_Producto", Id_Producto)
    End Function



End Class

