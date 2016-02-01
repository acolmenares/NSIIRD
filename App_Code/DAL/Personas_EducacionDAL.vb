Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Personas_EducacionDAL

    Public Shared Function Insertar(ByVal Id_Persona As Int32, ByVal Fecha As Object, ByVal Id_Estudia_Actualmente As Int32, ByVal Id_Motivo_NoEstudia As Int32, ByVal Id_Certificado_Matricula As Int32, ByVal Id_Seguimiento As Int32, ByVal Establecimiento As String, ByVal Id_grado_escolar As Int32, ByVal verificado_entidad As Int16, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean, ByVal observaciones As String, Id_Tipo_Entrega As Int32, Id_Declaracion_Seguimiento As Int32, ByVal Id_Municipio_Institucion As Int32) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Personas_EducacionInsertar", isNothingToDBNull(Id_Persona), isNothingToDBNull(Fecha), isNothingToDBNull(Id_Estudia_Actualmente), isNothingToDBNull(Id_Motivo_NoEstudia), isNothingToDBNull(Id_Certificado_Matricula), isNothingToDBNull(Id_Seguimiento), isNothingToDBNull(Establecimiento), isNothingToDBNull(Id_grado_escolar), isNothingToDBNull(verificado_entidad), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre), isNothingToDBNull(observaciones), isNothingToDBNull(Id_Tipo_Entrega), isNothingToDBNull(Id_Declaracion_Seguimiento), isNothingToDBNull(Id_Municipio_Institucion))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Persona As Int32, ByVal Fecha As Object, ByVal Id_Estudia_Actualmente As Int32, ByVal Id_Motivo_NoEstudia As Int32, ByVal Id_Certificado_Matricula As Int32, ByVal Id_Seguimiento As Int32, ByVal Establecimiento As String, ByVal Id_grado_escolar As Int32, ByVal Verificado_Entidad As Int16, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean, ByVal observaciones As String, Id_Tipo_Entrega As Int32, Id_Declaracion_Seguimiento As Int32, ByVal Id_Municipio_Institucion As Int32)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Personas_EducacionActualizar", Id, isNothingToDBNull(Id_Persona), isNothingToDBNull(Fecha), isNothingToDBNull(Id_Estudia_Actualmente), isNothingToDBNull(Id_Motivo_NoEstudia), isNothingToDBNull(Id_Certificado_Matricula), isNothingToDBNull(Id_Seguimiento), isNothingToDBNull(Establecimiento), isNothingToDBNull(Id_grado_escolar), isNothingToDBNull(Verificado_Entidad), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre), isNothingToDBNull(observaciones), isNothingToDBNull(Id_Tipo_Entrega), isNothingToDBNull(Id_Declaracion_Seguimiento), isNothingToDBNull(Id_Municipio_Institucion))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Personas_EducacionEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_EducacionConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_EducacionConsultarPorID", Id)
    End Function

    Public Shared Function CargarPorIDySegunda_Entrega(ByVal Id As Int32, ByVal Id_Tipo_Entrega As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_EducacionConsultarPorIDySE", Id, Id_Tipo_Entrega)
    End Function

    Public Shared Function CargarPorId_Certificado_Matricula(ByVal Id_Certificado_Matricula As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_EducacionConsultarPorId_Certificado_Matricula", Id_Certificado_Matricula)
    End Function

    Public Shared Function CargarPorId_Estudia_Actualmente(ByVal Id_Estudia_Actualmente As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_EducacionConsultarPorId_Estudia_Actualmente", Id_Estudia_Actualmente)
    End Function

    Public Shared Function CargarPorId_Grado_Escolar(ByVal Id_Grado_Escolar As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_EducacionConsultarPorId_Grado_Escolar", Id_Grado_Escolar)
    End Function

    Public Shared Function CargarPorId_Motivo_NoEstudia(ByVal Id_Motivo_NoEstudia As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_EducacionConsultarPorId_Motivo_NoEstudia", Id_Motivo_NoEstudia)
    End Function

    Public Shared Function CargarPorId_Persona(ByVal Id_Persona As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_EducacionConsultarPorId_Persona", Id_Persona)
    End Function

    Public Shared Function CargarPorId_Seguimiento(ByVal Id_Seguimiento As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_EducacionConsultarPorId_Seguimiento", Id_Seguimiento)
    End Function

    Public Shared Function CargarPorId_Tipo_Entrega(ByVal Id_Tipo_Entrega As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_EducacionConsultarPorId_Tipo_Entrega", Id_Tipo_Entrega)
    End Function

    Public Shared Function CargarPorId_Declaracion_Seguimiento(ByVal Id_Declaracion_Seguimiento As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_EducacionConsultarPorId_Declaracion_Seguimiento", Id_Declaracion_Seguimiento)
    End Function

End Class

