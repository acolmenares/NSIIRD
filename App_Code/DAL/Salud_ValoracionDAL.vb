Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Salud_ValoracionDAL

    Public Shared Function Insertar(ByVal Id_salud As Int32, ByVal Fecha_Valoracion As DateTime, ByVal Antropometria_Peso As Double, ByVal Antropometria_Talla As Double, ByVal Antropometia_Perimetro_Branquial As Double, ByVal Diferencia_Peso As Double, ByVal Id_Recuperado As Int32, ByVal Observaciones As String, ByVal Peso_talla As Double, ByVal Peso_edad As Double, ByVal Talla_Longitud As Double, ByVal IMC_Edad As Double, ByVal Edad As Int32, ByVal Meses As Int32, ByVal Talla_Para_Edad As String, ByVal Estado_Nutricional As String, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Id_Tipo_Proceso As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Salud_ValoracionInsertar", isNothingToDBNull(Id_salud), isNothingToDBNull(Fecha_Valoracion), isNothingToDBNull(Antropometria_Peso), isNothingToDBNull(Antropometria_Talla), isNothingToDBNull(Antropometia_Perimetro_Branquial), isNothingToDBNull(Diferencia_Peso), isNothingToDBNull(Id_Recuperado), isNothingToDBNull(Observaciones), isNothingToDBNull(Peso_talla), isNothingToDBNull(Peso_edad), isNothingToDBNull(Talla_Longitud), isNothingToDBNull(IMC_Edad), isNothingToDBNull(Edad), isNothingToDBNull(Meses), isNothingToDBNull(Talla_Para_Edad), isNothingToDBNull(Estado_Nutricional), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Id_Tipo_Proceso), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_salud As Int32, ByVal Fecha_Valoracion As DateTime, ByVal Antropometria_Peso As Double, ByVal Antropometria_Talla As Double, ByVal Antropometia_Perimetro_Branquial As Double, ByVal Diferencia_Peso As Double, ByVal Id_Recuperado As Int32, ByVal Observaciones As String, ByVal Peso_talla As Double, ByVal Peso_edad As Double, ByVal Talla_Longitud As Double, ByVal IMC_Edad As Double, ByVal Edad As Int32, ByVal Meses As Int32, ByVal Talla_Para_Edad As String, ByVal Estado_Nutricional As String, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Id_Tipo_Proceso As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Salud_ValoracionActualizar", Id, isNothingToDBNull(Id_salud), isNothingToDBNull(Fecha_Valoracion), isNothingToDBNull(Antropometria_Peso), isNothingToDBNull(Antropometria_Talla), isNothingToDBNull(Antropometia_Perimetro_Branquial), isNothingToDBNull(Diferencia_Peso), isNothingToDBNull(Id_Recuperado), isNothingToDBNull(Observaciones), isNothingToDBNull(Peso_talla), isNothingToDBNull(Peso_edad), isNothingToDBNull(Talla_Longitud), isNothingToDBNull(IMC_Edad), isNothingToDBNull(Edad), isNothingToDBNull(Meses), isNothingToDBNull(Talla_Para_Edad), isNothingToDBNull(Estado_Nutricional), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Id_Tipo_Proceso), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Salud_ValoracionEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Salud_ValoracionConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Salud_ValoracionConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Recuperado(ByVal Id_Recuperado As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Salud_ValoracionConsultarPorId_Recuperado", Id_Recuperado)
    End Function

    Public Shared Function CargarPorId_Salud(ByVal Id_Salud As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Salud_ValoracionConsultarPorId_Salud", Id_Salud)
    End Function

    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Salud_ValoracionConsultarPorId_Usuario_Creacion", Id_Usuario_Creacion)
    End Function

    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Salud_ValoracionConsultarPorId_Usuario_Modificacion", Id_Usuario_Modificacion)
    End Function

    Public Shared Function CargarPorUltimoRegistro(ByVal IDSalud As Int32, ByVal idvaloracion As Int32, ByVal fecha As String) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Salud_ValoracionConsultarPorUltimoRegistro", IDSalud, isNothingToDBNull(idvaloracion), isNothingToDBNull(fecha))
    End Function

    Public Shared Function CargarPorId_Tipo_Proceso(ByVal Id_Tipo_Proceso As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Salud_ValoracionConsultarPorId_Tipo_Proceso", Id_Tipo_Proceso)
    End Function

End Class

