Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Declaracion_SeguimientosDAL

    Public Shared Function Insertar(ByVal Id_Declaracion As Int32, ByVal Id_Tipo_Entrega As Int32, ByVal Fecha As DateTime, ByVal Id_Oido_OVD As Int32, ByVal Id_Pertenece_OVD As Int32, ByVal Cual_OVD As String, ByVal Ingresos_Mensuales As Double, ByVal Id_Afectado_Desplazamiento As Int32, ByVal Id_Emociones As Int32, ByVal Id_Aliviado As Int32, ByVal Id_Comprender_Miedos As Int32, ByVal Id_Escuchado_Grupo As Int32, ByVal Id_Ayuda_Barrio As Int32, ByVal Id_Identificar_Habilidades As Int32, ByVal Id_Ayuda_Bienestar As Int32, ByVal Id_Relaciones_Familia As Int32, ByVal Id_Momentos_Dificiles As Int32, ByVal Id_Identificar_Organizaciones As Int32, ByVal Id_Identificar_Instituciones As Int32, ByVal Id_No_Sirvio As Int32, ByVal Id_Apoyo_Emocional As Int32, ByVal Id_Unidos As Int32, ByVal Municipio_Unidos As String, ByVal Id_Familias_Accion As Int32, ByVal Id_Alimentos_ICBF As Int32, ByVal Observaciones As String, Id_Solicitado_Atencion_Psicosocial As Int32, Municipio_Familias_Accion As String) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Declaracion_SeguimientosInsertar", isNothingToDBNull(Id_Declaracion), isNothingToDBNull(Id_Tipo_Entrega), isNothingToDBNull(Fecha), isNothingToDBNull(Id_Oido_OVD), isNothingToDBNull(Id_Pertenece_OVD), isNothingToDBNull(Cual_OVD), isNothingToDBNull(Ingresos_Mensuales), isNothingToDBNull(Id_Afectado_Desplazamiento), isNothingToDBNull(Id_Emociones), isNothingToDBNull(Id_Aliviado), isNothingToDBNull(Id_Comprender_Miedos), isNothingToDBNull(Id_Escuchado_Grupo), isNothingToDBNull(Id_Ayuda_Barrio), isNothingToDBNull(Id_Identificar_Habilidades), isNothingToDBNull(Id_Ayuda_Bienestar), isNothingToDBNull(Id_Relaciones_Familia), isNothingToDBNull(Id_Momentos_Dificiles), isNothingToDBNull(Id_Identificar_Organizaciones), isNothingToDBNull(Id_Identificar_Instituciones), isNothingToDBNull(Id_No_Sirvio), isNothingToDBNull(Id_Apoyo_Emocional), isNothingToDBNull(Id_Unidos), isNothingToDBNull(Municipio_Unidos), isNothingToDBNull(Id_Familias_Accion), isNothingToDBNull(Id_Alimentos_ICBF), isNothingToDBNull(Observaciones), isNothingToDBNull(Id_Solicitado_Atencion_Psicosocial), isNothingToDBNull(Municipio_Familias_Accion))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Declaracion As Int32, ByVal Id_Tipo_Entrega As Int32, ByVal Fecha As DateTime, ByVal Id_Oido_OVD As Int32, ByVal Id_Pertenece_OVD As Int32, ByVal Cual_OVD As String, ByVal Ingresos_Mensuales As Double, ByVal Id_Afectado_Desplazamiento As Int32, ByVal Id_Emociones As Int32, ByVal Id_Aliviado As Int32, ByVal Id_Comprender_Miedos As Int32, ByVal Id_Escuchado_Grupo As Int32, ByVal Id_Ayuda_Barrio As Int32, ByVal Id_Identificar_Habilidades As Int32, ByVal Id_Ayuda_Bienestar As Int32, ByVal Id_Relaciones_Familia As Int32, ByVal Id_Momentos_Dificiles As Int32, ByVal Id_Identificar_Organizaciones As Int32, ByVal Id_Identificar_Instituciones As Int32, ByVal Id_No_Sirvio As Int32, ByVal Id_Apoyo_Emocional As Int32, ByVal Id_Unidos As Int32, ByVal Municipio_Unidos As String, ByVal Id_Familias_Accion As Int32, ByVal Id_Alimentos_ICBF As Int32, ByVal Observaciones As String, Id_Solicitado_Atencion_Psicosocial As Int32, Municipio_Familias_Accion As String)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Declaracion_SeguimientosActualizar", Id, isNothingToDBNull(Id_Declaracion), isNothingToDBNull(Id_Tipo_Entrega), isNothingToDBNull(Fecha), isNothingToDBNull(Id_Oido_OVD), isNothingToDBNull(Id_Pertenece_OVD), isNothingToDBNull(Cual_OVD), isNothingToDBNull(Ingresos_Mensuales), isNothingToDBNull(Id_Afectado_Desplazamiento), isNothingToDBNull(Id_Emociones), isNothingToDBNull(Id_Aliviado), isNothingToDBNull(Id_Comprender_Miedos), isNothingToDBNull(Id_Escuchado_Grupo), isNothingToDBNull(Id_Ayuda_Barrio), isNothingToDBNull(Id_Identificar_Habilidades), isNothingToDBNull(Id_Ayuda_Bienestar), isNothingToDBNull(Id_Relaciones_Familia), isNothingToDBNull(Id_Momentos_Dificiles), isNothingToDBNull(Id_Identificar_Organizaciones), isNothingToDBNull(Id_Identificar_Instituciones), isNothingToDBNull(Id_No_Sirvio), isNothingToDBNull(Id_Apoyo_Emocional), isNothingToDBNull(Id_Unidos), isNothingToDBNull(Municipio_Unidos), isNothingToDBNull(Id_Familias_Accion), isNothingToDBNull(Id_Alimentos_ICBF), isNothingToDBNull(Observaciones), isNothingToDBNull(Id_Solicitado_Atencion_Psicosocial), isNothingToDBNull(Municipio_Familias_Accion))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Declaracion_SeguimientosEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_SeguimientosConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_SeguimientosConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Afectado_Desplazamiento(ByVal Id_Afectado_Desplazamiento As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_SeguimientosConsultarPorId_Afectado_Desplazamiento", Id_Afectado_Desplazamiento)
    End Function

    Public Shared Function CargarPorId_Alimentos_ICBF(ByVal Id_Alimentos_ICBF As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_SeguimientosConsultarPorId_Alimentos_ICBF", Id_Alimentos_ICBF)
    End Function

    Public Shared Function CargarPorId_Aliviado(ByVal Id_Aliviado As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_SeguimientosConsultarPorId_Aliviado", Id_Aliviado)
    End Function

    Public Shared Function CargarPorId_Apoyo_Emocional(ByVal Id_Apoyo_Emocional As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_SeguimientosConsultarPorId_Apoyo_Emocional", Id_Apoyo_Emocional)
    End Function

    Public Shared Function CargarPorId_Ayuda_Barrio(ByVal Id_Ayuda_Barrio As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_SeguimientosConsultarPorId_Ayuda_Barrio", Id_Ayuda_Barrio)
    End Function

    Public Shared Function CargarPorId_Ayuda_Bienestar(ByVal Id_Ayuda_Bienestar As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_SeguimientosConsultarPorId_Ayuda_Bienestar", Id_Ayuda_Bienestar)
    End Function

    Public Shared Function CargarPorId_Comprender_Miedos(ByVal Id_Comprender_Miedos As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_SeguimientosConsultarPorId_Comprender_Miedos", Id_Comprender_Miedos)
    End Function

    Public Shared Function CargarPorId_Declaracion(ByVal Id_Declaracion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_SeguimientosConsultarPorId_Declaracion", Id_Declaracion)
    End Function

    Public Shared Function CargarPorId_Emociones(ByVal Id_Emociones As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_SeguimientosConsultarPorId_Emociones", Id_Emociones)
    End Function

    Public Shared Function CargarPorId_Escuchado_Grupo(ByVal Id_Escuchado_Grupo As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_SeguimientosConsultarPorId_Escuchado_Grupo", Id_Escuchado_Grupo)
    End Function

    Public Shared Function CargarPorId_Familias_Accion(ByVal Id_Familias_Accion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_SeguimientosConsultarPorId_Familias_Accion", Id_Familias_Accion)
    End Function

    Public Shared Function CargarPorId_Identificar_Habilidades(ByVal Id_Identificar_Habilidades As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_SeguimientosConsultarPorId_Identificar_Habilidades", Id_Identificar_Habilidades)
    End Function

    Public Shared Function CargarPorId_Identificar_Instituciones(ByVal Id_Identificar_Instituciones As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_SeguimientosConsultarPorId_Identificar_Instituciones", Id_Identificar_Instituciones)
    End Function

    Public Shared Function CargarPorId_Identificar_Organizaciones(ByVal Id_Identificar_Organizaciones As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_SeguimientosConsultarPorId_Identificar_Organizaciones", Id_Identificar_Organizaciones)
    End Function

    Public Shared Function CargarPorId_Momentos_Dificiles(ByVal Id_Momentos_Dificiles As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_SeguimientosConsultarPorId_Momentos_Dificiles", Id_Momentos_Dificiles)
    End Function

    Public Shared Function CargarPorId_No_Sirvio(ByVal Id_No_Sirvio As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_SeguimientosConsultarPorId_No_Sirvio", Id_No_Sirvio)
    End Function

    Public Shared Function CargarPorId_Oido_OVD(ByVal Id_Oido_OVD As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_SeguimientosConsultarPorId_Oido_OVD", Id_Oido_OVD)
    End Function

    Public Shared Function CargarPorId_Pertenece_OVD(ByVal Id_Pertenece_OVD As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_SeguimientosConsultarPorId_Pertenece_OVD", Id_Pertenece_OVD)
    End Function

    Public Shared Function CargarPorId_Relaciones_Familia(ByVal Id_Relaciones_Familia As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_SeguimientosConsultarPorId_Relaciones_Familia", Id_Relaciones_Familia)
    End Function

    Public Shared Function CargarPorId_Tipo_Entrega(ByVal Id_Tipo_Entrega As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_SeguimientosConsultarPorId_Tipo_Entrega", Id_Tipo_Entrega)
    End Function

    Public Shared Function CargarPorId_Unidos(ByVal Id_Unidos As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_SeguimientosConsultarPorId_Unidos", Id_Unidos)
    End Function

End Class

