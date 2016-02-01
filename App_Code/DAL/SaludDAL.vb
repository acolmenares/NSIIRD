Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class SaludDAL

    Public Shared Function Insertar(ByVal Id_Persona As Int32, ByVal Id_Crecimiento_Desarrollo As Int32, ByVal Patologia As String, ByVal Id_Lactancia_Lactando As Int32, ByVal Lactancia_meses As Int32, ByVal Lactancia_Exclusiva As Int32, ByVal Id_Vitaminas_Desparasitacion As Int32, ByVal Id_Vitaminas_Suplementacion As Int32, ByVal Id_Vacunacion_Carnet As Int32, ByVal Id_Razon_No_Carnet As Int32, ByVal Id_Esquema_Vacunacion_Completo As Int32, ByVal Id_Razon_No_Vacunacion_Completo As Int32, ByVal Fecha_Esquema_Vacunacion As DateTime, ByVal Id_Ninos_Vacunados As Int32, ByVal Id_Motivo_No_Vacunados As Int32, ByVal Observaciones As String, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Id_Motivo_No_CYD As Int32, ByVal Id_Crecimiento_Desarrollo_IRD As Int32, ByVal Id_Motivo_NO_CYD_IRD As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.SaludInsertar", isNothingToDBNull(Id_Persona), isNothingToDBNull(Id_Crecimiento_Desarrollo), isNothingToDBNull(Patologia), isNothingToDBNull(Id_Lactancia_Lactando), isNothingToDBNull(Lactancia_meses), isNothingToDBNull(Lactancia_Exclusiva), isNothingToDBNull(Id_Vitaminas_Desparasitacion), isNothingToDBNull(Id_Vitaminas_Suplementacion), isNothingToDBNull(Id_Vacunacion_Carnet), isNothingToDBNull(Id_Razon_No_Carnet), isNothingToDBNull(Id_Esquema_Vacunacion_Completo), isNothingToDBNull(Id_Razon_No_Vacunacion_Completo), isNothingToDBNull(Fecha_Esquema_Vacunacion), isNothingToDBNull(Id_Ninos_Vacunados), isNothingToDBNull(Id_Motivo_No_Vacunados), isNothingToDBNull(Observaciones), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Id_Motivo_No_CYD), isNothingToDBNull(Id_Crecimiento_Desarrollo_IRD), isNothingToDBNull(Id_Motivo_NO_CYD_IRD), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Persona As Int32, ByVal Id_Crecimiento_Desarrollo As Int32, ByVal Patologia As String, ByVal Id_Lactancia_Lactando As Int32, ByVal Lactancia_meses As Int32, ByVal Lactancia_Exclusiva As Int32, ByVal Id_Vitaminas_Desparasitacion As Int32, ByVal Id_Vitaminas_Suplementacion As Int32, ByVal Id_Vacunacion_Carnet As Int32, ByVal Id_Razon_No_Carnet As Int32, ByVal Id_Esquema_Vacunacion_Completo As Int32, ByVal Id_Razon_No_Vacunacion_Completo As Int32, ByVal Fecha_Esquema_Vacunacion As DateTime, ByVal Id_Ninos_Vacunados As Int32, ByVal Id_Motivo_No_Vacunados As Int32, ByVal Observaciones As String, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Id_Motivo_No_CYD As Int32, ByVal Id_Crecimiento_Desarrollo_IRD As Int32, ByVal Id_Motivo_NO_CYD_IRD As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.SaludActualizar", Id, isNothingToDBNull(Id_Persona), isNothingToDBNull(Id_Crecimiento_Desarrollo), isNothingToDBNull(Patologia), isNothingToDBNull(Id_Lactancia_Lactando), isNothingToDBNull(Lactancia_meses), isNothingToDBNull(Lactancia_Exclusiva), isNothingToDBNull(Id_Vitaminas_Desparasitacion), isNothingToDBNull(Id_Vitaminas_Suplementacion), isNothingToDBNull(Id_Vacunacion_Carnet), isNothingToDBNull(Id_Razon_No_Carnet), isNothingToDBNull(Id_Esquema_Vacunacion_Completo), isNothingToDBNull(Id_Razon_No_Vacunacion_Completo), isNothingToDBNull(Fecha_Esquema_Vacunacion), isNothingToDBNull(Id_Ninos_Vacunados), isNothingToDBNull(Id_Motivo_No_Vacunados), isNothingToDBNull(Observaciones), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Id_Motivo_No_CYD), isNothingToDBNull(Id_Crecimiento_Desarrollo_IRD), isNothingToDBNull(Id_Motivo_NO_CYD_IRD), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.SaludEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SaludConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SaludConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Crecimiento_Desarrollo(ByVal Id_Crecimiento_Desarrollo As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SaludConsultarPorId_Crecimiento_Desarrollo", Id_Crecimiento_Desarrollo)
    End Function

    Public Shared Function CargarPorId_Esquema_Vacunacion_Completo(ByVal Id_Esquema_Vacunacion_Completo As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SaludConsultarPorId_Esquema_Vacunacion_Completo", Id_Esquema_Vacunacion_Completo)
    End Function

    Public Shared Function CargarPorId_Lactancia_Lactando(ByVal Id_Lactancia_Lactando As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SaludConsultarPorId_Lactancia_Lactando", Id_Lactancia_Lactando)
    End Function

    Public Shared Function CargarPorId_Motivo_No_Vacunados(ByVal Id_Motivo_No_Vacunados As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SaludConsultarPorId_Motivo_No_Vacunados", Id_Motivo_No_Vacunados)
    End Function

    Public Shared Function CargarPorId_Ninos_Vacunados(ByVal Id_Ninos_Vacunados As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SaludConsultarPorId_Ninos_Vacunados", Id_Ninos_Vacunados)
    End Function

    Public Shared Function CargarPorId_Razon_No_Carnet(ByVal Id_Razon_No_Carnet As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SaludConsultarPorId_Razon_No_Carnet", Id_Razon_No_Carnet)
    End Function

    Public Shared Function CargarPorId_Razon_No_Vacunacion_Completo(ByVal Id_Razon_No_Vacunacion_Completo As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SaludConsultarPorId_Razon_No_Vacunacion_Completo", Id_Razon_No_Vacunacion_Completo)
    End Function

    Public Shared Function CargarPorId_Vacunacion_Carnet(ByVal Id_Vacunacion_Carnet As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SaludConsultarPorId_Vacunacion_Carnet", Id_Vacunacion_Carnet)
    End Function

    Public Shared Function CargarPorId_Vitaminas_Desparasitacion(ByVal Id_Vitaminas_Desparasitacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SaludConsultarPorId_Vitaminas_Desparasitacion", Id_Vitaminas_Desparasitacion)
    End Function

    Public Shared Function CargarPorId_Vitaminas_Suplementacion(ByVal Id_Vitaminas_Suplementacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SaludConsultarPorId_Vitaminas_Suplementacion", Id_Vitaminas_Suplementacion)
    End Function

    Public Shared Function CargarPorId_Persona(ByVal Id_Persona As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SaludConsultarPorId_Persona", Id_Persona)
    End Function

    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SaludConsultarPorId_Usuario_Creacion", Id_Usuario_Creacion)
    End Function

    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SaludConsultarPorId_Usuario_Modificacion", Id_Usuario_Modificacion)
    End Function

    Public Shared Function CargarPorId_Motivo_No_CYD(ByVal Id_Motivo_No_CYD As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SaludConsultarPorId_Motivo_NO_Crecimiento_Desarrollo", Id_Motivo_No_CYD)
    End Function

    Public Shared Function CargarPorId_Crecimiento_Desarrollo_IRD(ByVal Id_Crecimiento_Desarrollo_IRD As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SaludConsultarPorId_Crecimiento_Desarrollo_IRD", Id_Crecimiento_Desarrollo_IRD)
    End Function

    Public Shared Function CargarPorId_Motivo_No_CYD_IRD(ByVal Id_Motivo_No_CYD_IRD As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SaludConsultarPorId_Motivo_NO_Crecimiento_Desarrollo_IRD", Id_Motivo_No_CYD_IRD)
    End Function

End Class

