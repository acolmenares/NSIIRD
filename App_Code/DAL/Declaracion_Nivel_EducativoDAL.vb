Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Declaracion_Nivel_EducativoDAL

    Public Shared Function Insertar(ByVal Id_Declaracion As Int32, ByVal Id_Grado_Escolar As Int32, ByVal Cantidad As Int32, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Declaracion_Nivel_EducativoInsertar", isNothingToDBNull(Id_Declaracion), isNothingToDBNull(Id_Grado_Escolar), isNothingToDBNull(Cantidad), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Declaracion As Int32, ByVal Id_Grado_Escolar As Int32, ByVal Cantidad As Int32, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Declaracion_Nivel_EducativoActualizar", Id, isNothingToDBNull(Id_Declaracion), isNothingToDBNull(Id_Grado_Escolar), isNothingToDBNull(Cantidad), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Declaracion_Nivel_EducativoEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_Nivel_EducativoConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_Nivel_EducativoConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Declaracion(ByVal Id_Declaracion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_Nivel_EducativoConsultarPorId_Declaracion", Id_Declaracion)
    End Function


    Public Shared Function CargarPorId_Grado_Escolar(ByVal Id_Grado_Escolar As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_Nivel_EducativoConsultarPorId_Grado_Escolar", Id_Grado_Escolar)
    End Function


    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_Nivel_EducativoConsultarPorId_Usuario_Creacion", Id_Usuario_Creacion)
    End Function


    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_Nivel_EducativoConsultarPorId_Usuario_Modificacion", Id_Usuario_Modificacion)
    End Function



End Class

