Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Declaracion_Instituciones_ConfianzaDAL

    Public Shared Function Insertar(ByVal Id_Declaracion As Int32, ByVal Id_Institucion_Confianza As Int32, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Declaracion_Instituciones_ConfianzaInsertar", isNothingToDBNull(Id_Declaracion), isNothingToDBNull(Id_Institucion_Confianza), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Declaracion As Int32, ByVal Id_Institucion_Confianza As Int32, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Declaracion_Instituciones_ConfianzaActualizar", Id, isNothingToDBNull(Id_Declaracion), isNothingToDBNull(Id_Institucion_Confianza), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Declaracion_Instituciones_ConfianzaEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_Instituciones_ConfianzaConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_Instituciones_ConfianzaConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Declaracion(ByVal Id_Declaracion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_Instituciones_ConfianzaConsultarPorId_Declaracion", Id_Declaracion)
    End Function


    Public Shared Function CargarPorId_Institucion_Confianza(ByVal Id_Institucion_Confianza As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_Instituciones_ConfianzaConsultarPorId_Institucion_Confianza", Id_Institucion_Confianza)
    End Function


    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_Instituciones_ConfianzaConsultarPorId_Usuario_Creacion", Id_Usuario_Creacion)
    End Function


    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_Instituciones_ConfianzaConsultarPorId_Usuario_Modificacion", Id_Usuario_Modificacion)
    End Function



End Class

