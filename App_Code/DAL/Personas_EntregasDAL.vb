Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Personas_EntregasDAL

    Public Shared Function Insertar(ByVal Id_Persona As Int32, ByVal Id_Programa As Int32, ByVal Id_Producto As Int32, ByVal Id_Unidad As Int32, ByVal Cantidad As Double, ByVal Cantidad_legalizada As Double) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Personas_EntregasInsertar", isNothingToDBNull(Id_Persona), isNothingToDBNull(Id_Programa), isNothingToDBNull(Id_Producto), isNothingToDBNull(Id_Unidad), isNothingToDBNull(Cantidad), isNothingToDBNull(Cantidad_legalizada))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Persona As Int32, ByVal Id_Programa As Int32, ByVal Id_Producto As Int32, ByVal Id_Unidad As Int32, ByVal Cantidad As Double, ByVal Cantidad_legalizada As Double)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Personas_EntregasActualizar", Id, isNothingToDBNull(Id_Persona), isNothingToDBNull(Id_Programa), isNothingToDBNull(Id_Producto), isNothingToDBNull(Id_Unidad), isNothingToDBNull(Cantidad), isNothingToDBNull(Cantidad_legalizada))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Personas_EntregasEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_EntregasConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_EntregasConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Persona(ByVal Id_Persona As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_EntregasConsultarPorId_Persona", Id_Persona)
    End Function

    Public Shared Function CargarPorId_Producto(ByVal Id_Producto As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_EntregasConsultarPorId_Producto", Id_Producto)
    End Function

    Public Shared Function CargarPorId_Programa(ByVal Id_Programa As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_EntregasConsultarPorId_Programa", Id_Programa)
    End Function

    Public Shared Function CargarPorId_Unidad(ByVal Id_Unidad As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_EntregasConsultarPorId_Unidad", Id_Unidad)
    End Function

    Public Shared Function CargarPorCantidadesEntrega(ByVal Id_programa As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_EntregasConsultarCantidadesEntrega", Id_programa)
    End Function

    Public Shared Function CargarPlanilla(ByVal Id_programa As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.CargarPlanilla", Id_programa)
    End Function


End Class

