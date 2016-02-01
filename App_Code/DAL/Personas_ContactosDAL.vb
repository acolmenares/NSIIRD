Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Personas_ContactosDAL

    Public Shared Function Insertar(ByVal Id_Persona As Int32, ByVal Id_Tipo_Contacto As Int32, ByVal Descripcion As String, ByVal Activo As Boolean, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Personas_ContactosInsertar", isNothingToDBNull(Id_Persona), isNothingToDBNull(Id_Tipo_Contacto), isNothingToDBNull(Descripcion), isNothingToDBNull(Activo), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Persona As Int32, ByVal Id_Tipo_Contacto As Int32, ByVal Descripcion As String, ByVal Activo As Boolean, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Personas_ContactosActualizar", Id, isNothingToDBNull(Id_Persona), isNothingToDBNull(Id_Tipo_Contacto), isNothingToDBNull(Descripcion), isNothingToDBNull(Activo), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Personas_ContactosEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_ContactosConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_ContactosConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Persona(ByVal Id_Persona As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_ContactosConsultarPorId_Persona", Id_Persona)
    End Function

    Public Shared Function CargarPorId_Tipo_Contacto(ByVal Id_Tipo_Contacto As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_ContactosConsultarPorId_Tipo_Contacto", Id_Tipo_Contacto)
    End Function

    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_ContactosConsultarPorId_Usuario_Creacion", Id_Usuario_Creacion)
    End Function

    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_ContactosConsultarPorId_Usuario_Modificacion", Id_Usuario_Modificacion)
    End Function

    Public Shared Function CargarPorId_PersonaYTipo_Contacto(ByVal Id_Persona As System.Int32, ByVal Id_Tipo_Contacto As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Personas_ContactosConsultarPorId_PersonayTipo_Contacto", Id_Persona, Id_Tipo_Contacto)
    End Function

End Class

