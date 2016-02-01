Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Declaracion_EstadosDAL

    Public Shared Function Insertar(ByVal Id_Declaracion As Int32, ByVal Id_Tipo_Estado As Int32, ByVal Id_Como_Estado As Int32, ByVal Fecha As DateTime, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean, ByVal ID_Programa As Int32, ByVal id_Asistio As Int32, ByVal Id_Motivo_NoAtencion As Int32) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Declaracion_EstadosInsertar", isNothingToDBNull(Id_Declaracion), isNothingToDBNull(Id_Tipo_Estado), isNothingToDBNull(Id_Como_Estado), isNothingToDBNull(Fecha), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre), isNothingToDBNull(ID_Programa), isNothingToDBNull(id_Asistio), isNothingToDBNull(Id_Motivo_NoAtencion))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Declaracion As Int32, ByVal Id_Tipo_Estado As Int32, ByVal Id_Como_Estado As Int32, ByVal Fecha As DateTime, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean, ByVal ID_Programa As Int32, ByVal id_Asistio As Int32, ByVal Id_Motivo_NoAtencion As Int32)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Declaracion_EstadosActualizar", Id, isNothingToDBNull(Id_Declaracion), isNothingToDBNull(Id_Tipo_Estado), isNothingToDBNull(Id_Como_Estado), isNothingToDBNull(Fecha), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre), isNothingToDBNull(ID_Programa), isNothingToDBNull(id_Asistio), isNothingToDBNull(Id_Motivo_NoAtencion))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Declaracion_EstadosEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_EstadosConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_EstadosConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Como_Estado(ByVal Id_Como_Estado As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_EstadosConsultarPorId_Como_Estado", Id_Como_Estado)
    End Function

    Public Shared Function CargarPorId_Declaracion(ByVal Id_Declaracion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_EstadosConsultarPorId_Declaracion", Id_Declaracion)
    End Function

    Public Shared Function CargarPorId_Tipo_Estado(ByVal Id_Tipo_Estado As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_EstadosConsultarPorId_Tipo_Estado", Id_Tipo_Estado)
    End Function

    Public Shared Function CargarPorId_Programa(ByVal Id_Programa As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_EstadosConsultarPorId_Programa", Id_Programa)
    End Function

End Class

