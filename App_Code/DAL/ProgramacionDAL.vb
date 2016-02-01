Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2
Imports System.Data

Public Class ProgramacionDAL

    Public Shared Function Insertar(ByVal Fecha As DateTime, ByVal Id_Regional As Int32, ByVal Numero As String, ByVal Id_Estado As Int32, ByVal Id_Grupo As Int32, ByVal Id_LugarEntrega As Int32, ByVal Id_TipoEntrega As Int32, ByVal Id_Bodega As Int32) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.ProgramacionInsertar", isNothingToDBNull(Fecha), isNothingToDBNull(Id_Regional), isNothingToDBNull(Numero), isNothingToDBNull(Id_Estado), isNothingToDBNull(Id_Grupo), isNothingToDBNull(Id_LugarEntrega), isNothingToDBNull(Id_TipoEntrega), isNothingToDBNull(Id_Bodega))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Fecha As DateTime, ByVal Id_Regional As Int32, ByVal Numero As String, ByVal Id_Estado As Int32, ByVal Id_Grupo As Int32, ByVal Id_LugarEntrega As Int32, ByVal Id_TipoEntrega As Int32, ByVal Id_Bodega As Int32)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.ProgramacionActualizar", Id, isNothingToDBNull(Fecha), isNothingToDBNull(Id_Regional), isNothingToDBNull(Numero), isNothingToDBNull(Id_Estado), isNothingToDBNull(Id_Grupo), isNothingToDBNull(Id_LugarEntrega), isNothingToDBNull(Id_TipoEntrega), isNothingToDBNull(Id_Bodega))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.ProgramacionEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.ProgramacionConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.ProgramacionConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Estado(ByVal Id_Estado As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.ProgramacionConsultarPorId_Estado", Id_Estado)
    End Function

    Public Shared Function CargarPorId_Grupo(ByVal Id_Grupo As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.ProgramacionConsultarPorId_Grupo", Id_Grupo)
    End Function

    Public Shared Function CargarPorId_Regional(ByVal Id_Regional As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.ProgramacionConsultarPorId_Regional", Id_Regional)
    End Function

    Public Shared Function CargarPorId_LugarEntrega(ByVal Id_LugarEntrega As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.ProgramacionConsultarPorId_LugarEntrega", Id_LugarEntrega)
    End Function

    Public Shared Function CargarPorId_TipoEntrega(ByVal Id_TipoEntrega As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.ProgramacionConsultarPorId_TipoEntrega", Id_TipoEntrega)
    End Function

    Public Shared Function CargarporBusqueda(ByVal Id_Regional As Int32, ByVal Id_LugarEntrega As Int32, ByVal Id_Programa As Integer, ByVal Fecha_Inicial_Programacion As String, ByVal Fecha_Final_Programacion As String) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.ProgramacionConsultarBusqueda", isNothingToDBNull(Id_Regional), isNothingToDBNull(Id_LugarEntrega), isNothingToDBNull(Id_Programa), isNothingToDBNull(Fecha_Inicial_Programacion), isNothingToDBNull(Fecha_Final_Programacion))
    End Function

    Public Shared Function CargarporBusquedaPorEstado(ByVal Id_Regional As Int32, ByVal Id_grupo As Int32, ByVal Id_Lugar_Entrega As Integer, ByVal Id_Estado As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.ProgramacionConsultarBusquedaPorEstado", isNothingToDBNull(Id_Regional), isNothingToDBNull(Id_grupo), isNothingToDBNull(Id_Lugar_Entrega), isNothingToDBNull(Id_Estado))
    End Function

    Public Shared Function CargarPorResumenPrograma(ByVal Id_Grupo As Int32, ByVal Id_Programa As Int32, ByVal Id_Tipo_Entrega As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.ProgramacionCargarResumenPrograma", Id_Grupo, Id_Programa, Id_Tipo_Entrega)
    End Function

End Class

