Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class PersonasDAL

    Public Shared Function Insertar(ByVal Id_Declaracion As Int32, ByVal Tipo As String, ByVal Id_Tipo_Identificacion As Int32, ByVal Identificacion As String, ByVal Primer_Nombre As String, ByVal Segundo_Nombre As String, ByVal Primer_Apellido As String, ByVal Segundo_Apellido As String, ByVal Id_Genero As Int32, ByVal Fecha_Nacimiento As DateTime, ByVal Edad As Int32, ByVal Id_Parentesco As Int32, ByVal Id_Discapacitado As Int32, ByVal Id_Estudia_Antes As Int32, ByVal Id_Estudia_Actualmente As Int32, ByVal Id_Ultimo_Grado As Int32, ByVal Institucion_Estudia As String, ByVal Id_Motivo_NoEstudio As Int32, ByVal Id_Tipo_Discapacidad As Int32, ByVal Id_Grupo_Etnico As Int32, ByVal Id_Embarazada As Int32, ByVal Id_Lactando As Int32, ByVal Id_Solicito_Atencion_Psicologica As Int32, ByVal Id_Recibio_Atencion_Psicologica As Int32, ByVal Quien_Atencion_Psicologica As String, ByVal Id_Recibio_Tratamiento As Int32, ByVal Id_Causas_Discapacidad As Int32, ByVal Id_Sabe_Leer_Escribir As Int32, ByVal Institucion_Estudiaba As String, ByVal Id_Paga_Matricula As Int32, ByVal Id_Tipo_Apoyo_Educativo As Int32, ByVal Id_Problemas_Establecimiento As Int32, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Edad_Semanas As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean, ByVal Id_Tipo_Miembro As Int32, ByVal Id_Afectado_Desplazamiento As Int32, ByVal Id_Certificado As Int32, Id_Municipio_Institucion_Antes As Int32, Id_Municipio_Institucion_Actual As Int32) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.PersonasInsertar", isNothingToDBNull(Id_Declaracion), isNothingToDBNull(Tipo), isNothingToDBNull(Id_Tipo_Identificacion), isNothingToDBNull(Identificacion), isNothingToDBNull(Primer_Nombre), isNothingToDBNull(Segundo_Nombre), isNothingToDBNull(Primer_Apellido), isNothingToDBNull(Segundo_Apellido), isNothingToDBNull(Id_Genero), isNothingToDBNull(Fecha_Nacimiento), isNothingToDBNull(Edad), isNothingToDBNull(Id_Parentesco), isNothingToDBNull(Id_Discapacitado), isNothingToDBNull(Id_Estudia_Antes), isNothingToDBNull(Id_Estudia_Actualmente), isNothingToDBNull(Id_Ultimo_Grado), isNothingToDBNull(Institucion_Estudia), isNothingToDBNull(Id_Motivo_NoEstudio), isNothingToDBNull(Id_Tipo_Discapacidad), isNothingToDBNull(Id_Grupo_Etnico), isNothingToDBNull(Id_Embarazada), isNothingToDBNull(Id_Lactando), isNothingToDBNull(Id_Solicito_Atencion_Psicologica), isNothingToDBNull(Id_Recibio_Atencion_Psicologica), isNothingToDBNull(Quien_Atencion_Psicologica), isNothingToDBNull(Id_Recibio_Tratamiento), isNothingToDBNull(Id_Causas_Discapacidad), isNothingToDBNull(Id_Sabe_Leer_Escribir), isNothingToDBNull(Institucion_Estudiaba), isNothingToDBNull(Id_Paga_Matricula), isNothingToDBNull(Id_Tipo_Apoyo_Educativo), isNothingToDBNull(Id_Problemas_Establecimiento), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Edad_Semanas), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre), isNothingToDBNull(Id_Tipo_Miembro), isNothingToDBNull(Id_Afectado_Desplazamiento), isNothingToDBNull(Id_Certificado), isNothingToDBNull(Id_Municipio_Institucion_Antes), isNothingToDBNull(Id_Municipio_Institucion_Actual))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Declaracion As Int32, ByVal Tipo As String, ByVal Id_Tipo_Identificacion As Int32, ByVal Identificacion As String, ByVal Primer_Nombre As String, ByVal Segundo_Nombre As String, ByVal Primer_Apellido As String, ByVal Segundo_Apellido As String, ByVal Id_Genero As Int32, ByVal Fecha_Nacimiento As DateTime, ByVal Edad As Int32, ByVal Id_Parentesco As Int32, ByVal Id_Discapacitado As Int32, ByVal Id_Estudia_Antes As Int32, ByVal Id_Estudia_Actualmente As Int32, ByVal Id_Ultimo_Grado As Int32, ByVal Institucion_Estudia As String, ByVal Id_Motivo_NoEstudio As Int32, ByVal Id_Tipo_Discapacidad As Int32, ByVal Id_Grupo_Etnico As Int32, ByVal Id_Embarazada As Int32, ByVal Id_Lactando As Int32, ByVal Id_Solicito_Atencion_Psicologica As Int32, ByVal Id_Recibio_Atencion_Psicologica As Int32, ByVal Quien_Atencion_Psicologica As String, ByVal Id_Recibio_Tratamiento As Int32, ByVal Id_Causas_Discapacidad As Int32, ByVal Id_Sabe_Leer_Escribir As Int32, ByVal Institucion_Estudiaba As String, ByVal Id_Paga_Matricula As Int32, ByVal Id_Tipo_Apoyo_Educativo As Int32, ByVal Id_Problemas_Establecimiento As Int32, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal edad_semanas As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean, ByVal Id_Tipo_Miembro As Int32, ByVal Id_Afectado_Desplazamiento As Int32, ByVal Id_Certificado As Int32, Id_Municipio_Institucion_Antes As Int32, Id_Municipio_Institucion_Actual As Int32)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.PersonasActualizar", Id, isNothingToDBNull(Id_Declaracion), isNothingToDBNull(Tipo), isNothingToDBNull(Id_Tipo_Identificacion), isNothingToDBNull(Identificacion), isNothingToDBNull(Primer_Nombre), isNothingToDBNull(Segundo_Nombre), isNothingToDBNull(Primer_Apellido), isNothingToDBNull(Segundo_Apellido), isNothingToDBNull(Id_Genero), isNothingToDBNull(Fecha_Nacimiento), isNothingToDBNull(Edad), isNothingToDBNull(Id_Parentesco), isNothingToDBNull(Id_Discapacitado), isNothingToDBNull(Id_Estudia_Antes), isNothingToDBNull(Id_Estudia_Actualmente), isNothingToDBNull(Id_Ultimo_Grado), isNothingToDBNull(Institucion_Estudia), isNothingToDBNull(Id_Motivo_NoEstudio), isNothingToDBNull(Id_Tipo_Discapacidad), isNothingToDBNull(Id_Grupo_Etnico), isNothingToDBNull(Id_Embarazada), isNothingToDBNull(Id_Lactando), isNothingToDBNull(Id_Solicito_Atencion_Psicologica), isNothingToDBNull(Id_Recibio_Atencion_Psicologica), isNothingToDBNull(Quien_Atencion_Psicologica), isNothingToDBNull(Id_Recibio_Tratamiento), isNothingToDBNull(Id_Causas_Discapacidad), isNothingToDBNull(Id_Sabe_Leer_Escribir), isNothingToDBNull(Institucion_Estudiaba), isNothingToDBNull(Id_Paga_Matricula), isNothingToDBNull(Id_Tipo_Apoyo_Educativo), isNothingToDBNull(Id_Problemas_Establecimiento), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(edad_semanas), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre), isNothingToDBNull(Id_Tipo_Miembro), isNothingToDBNull(Id_Afectado_Desplazamiento), isNothingToDBNull(Id_Certificado), isNothingToDBNull(Id_Municipio_Institucion_Antes), isNothingToDBNull(Id_Municipio_Institucion_Actual))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.PersonasEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Declaracion(ByVal Id_Declaracion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Declaracion", Id_Declaracion)
    End Function

    Public Shared Function CargarPorId_Declaracion_Educacion(ByVal Id_Declaracion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Declaracion_Educacion", Id_Declaracion)
    End Function

    Public Shared Function CargarPorId_Declaracion_EducacionPendiente(ByVal Id_Declaracion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Declaracion_EducacionPendiente", Id_Declaracion)
    End Function

    Public Shared Function CargarPorId_Discapacitado(ByVal Id_Discapacitado As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Discapacitado", Id_Discapacitado)
    End Function

    Public Shared Function CargarPorId_Estudia_Actualmente(ByVal Id_Estudia_Actualmente As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Estudia_Actualmente", Id_Estudia_Actualmente)
    End Function

    Public Shared Function CargarPorId_Estudia_Antes(ByVal Id_Estudia_Antes As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Estudia_Antes", Id_Estudia_Antes)
    End Function

    Public Shared Function CargarPorId_Genero(ByVal Id_Genero As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Genero", Id_Genero)
    End Function

    Public Shared Function CargarPorId_Motivo_NoEstudio(ByVal Id_Motivo_NoEstudio As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Motivo_NoEstudio", Id_Motivo_NoEstudio)
    End Function

    Public Shared Function CargarPorId_Parentesco(ByVal Id_Parentesco As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Parentesco", Id_Parentesco)
    End Function

    Public Shared Function CargarPorId_Tipo_Identificacion(ByVal Id_Tipo_Identificacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Tipo_Identificacion", Id_Tipo_Identificacion)
    End Function

    Public Shared Function CargarPorId_Ultimo_Grado(ByVal Id_Ultimo_Grado As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Ultimo_Grado", Id_Ultimo_Grado)
    End Function

    Public Shared Function CargarPorId_Causas_Discapacidad(ByVal Id_Causas_Discapacidad As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Causas_Discapacidad", Id_Causas_Discapacidad)
    End Function

    Public Shared Function CargarPorId_Embarazada(ByVal Id_Embarazada As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Embarazada", Id_Embarazada)
    End Function

    Public Shared Function CargarPorId_Grupo_Etnico(ByVal Id_Grupo_Etnico As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Grupo_Etnico", Id_Grupo_Etnico)
    End Function

    Public Shared Function CargarPorId_Lactando(ByVal Id_Lactando As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Lactando", Id_Lactando)
    End Function

    Public Shared Function CargarPorId_Paga_Matricula(ByVal Id_Paga_Matricula As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Paga_Matricula", Id_Paga_Matricula)
    End Function

    Public Shared Function CargarPorId_Problemas_Establecimiento(ByVal Id_Problemas_Establecimiento As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Problemas_Establecimiento", Id_Problemas_Establecimiento)
    End Function

    Public Shared Function CargarPorId_Recibio_Atencion_Psicologica(ByVal Id_Recibio_Atencion_Psicologica As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Recibio_Atencion_Psicologica", Id_Recibio_Atencion_Psicologica)
    End Function

    Public Shared Function CargarPorId_Recibio_Tratamiento(ByVal Id_Recibio_Tratamiento As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Recibio_Tratamiento", Id_Recibio_Tratamiento)
    End Function

    Public Shared Function CargarPorId_Sabe_Leer_Escribir(ByVal Id_Sabe_Leer_Escribir As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Sabe_Leer_Escribir", Id_Sabe_Leer_Escribir)
    End Function

    Public Shared Function CargarPorId_Solicito_Atencion_Psicologica(ByVal Id_Solicito_Atencion_Psicologica As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Solicito_Atencion_Psicologica", Id_Solicito_Atencion_Psicologica)
    End Function

    Public Shared Function CargarPorId_Tipo_Apoyo_Educativo(ByVal Id_Tipo_Apoyo_Educativo As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Tipo_Apoyo_Educativo", Id_Tipo_Apoyo_Educativo)
    End Function

    Public Shared Function CargarPorId_Tipo_Discapacidad(ByVal Id_Tipo_Discapacidad As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Tipo_Discapacidad", Id_Tipo_Discapacidad)
    End Function

    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Usuario_Creacion", Id_Usuario_Creacion)
    End Function

    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Usuario_Modificacion", Id_Usuario_Modificacion)
    End Function

    Public Shared Function CargarPorSaludEdadNino(ByVal grupo As String, ByVal identificacion As String, ByVal nombre As String, ByVal regional As Integer, ByVal fecha_inicial As String, ByVal fecha_final As String, ByVal tipodeclaracion As Integer, ByVal Id_lugarEntrega As Int32, ByVal id_Programa As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorSaludEdadNino", isNothingToDBNull(grupo), isNothingToDBNull(identificacion), isNothingToDBNull(nombre), isNothingToDBNull(regional), isNothingToDBNull(fecha_inicial), isNothingToDBNull(fecha_final), isNothingToDBNull(tipodeclaracion), isNothingToDBNull(Id_lugarEntrega), isNothingToDBNull(id_Programa))
    End Function

    Public Shared Function CargarPorId_EmbarazadaBusqueda(ByVal id_embarazada As Integer, ByVal grupo As String, ByVal identificacion As String, ByVal nombre As String, ByVal regional As Integer, ByVal fecha_inicial As String, ByVal fecha_final As String, ByVal tipodeclaracion As Integer, ByVal Regimen As Integer, ByVal lactando As Integer) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_EmbarazadaConsulta", id_embarazada, isNothingToDBNull(grupo), isNothingToDBNull(identificacion), isNothingToDBNull(nombre), isNothingToDBNull(regional), isNothingToDBNull(fecha_inicial), isNothingToDBNull(fecha_final), isNothingToDBNull(tipodeclaracion), isNothingToDBNull(Regimen), isNothingToDBNull(lactando))
    End Function

    Public Shared Function CargarPorIDyDeclarante(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorIDyDeclarante", Id)
    End Function

    Public Shared Function CargarPorIDyBeneficiarios(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorIDyBeneficiarios", Id)
    End Function

    Public Shared Function CargarPorIdentificacion(ByVal tipo As Integer, ByVal identificacion As String) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorIdentificacion", isNothingToDBNull(tipo), identificacion)
    End Function

    Public Shared Function CargarPorIdentificacionAtendidos(ByVal tipo As Integer, ByVal identificacion As String) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorIdentificacionAtendidos", isNothingToDBNull(tipo), identificacion)
    End Function

    Public Shared Function CargarPorEdadNino() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorEdadNino")
    End Function

    Public Shared Function CargarporIndicadores(ByVal id_Lugar_entrega As Int32, ByVal trimestrales As String, ByVal regionales As String, ByVal entregas As String, ByVal grupos As String, _
        ByVal fechadeclaracioninicial As String, ByVal fechadeclaracionfinal As String, ByVal fechadesplazamientoinicial As String, ByVal fechadesplazamientofinal As String, ByVal fechaatencioninicial As String, _
        ByVal fechaatencionfinal As String, ByVal accionsocial As Integer, ByVal atendido As Integer, ByVal motivonoatencion As Integer, ByVal departamento As Integer, ByVal municipio As Integer, ByVal concejo As Integer, _
         ByVal ninos5 As Integer, ByVal gestantes As Integer, ByVal ninos6y17 As Integer, ByVal estudia_actualmente As Integer, ByVal estudia_antes As Integer, ByVal wfecha_radicacion_inicial As String, ByVal wfecha_radicacion_final As String) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorIndicadores", isNothingToDBNull(id_Lugar_entrega), isNothingToDBNull(trimestrales), isNothingToDBNull(regionales), isNothingToDBNull(entregas), isNothingToDBNull(grupos), isNothingToDBNull(fechadeclaracioninicial), isNothingToDBNull(fechadeclaracionfinal), isNothingToDBNull(fechadesplazamientoinicial), isNothingToDBNull(fechadesplazamientofinal), _
                    isNothingToDBNull(fechaatencioninicial), isNothingToDBNull(fechaatencionfinal), isNothingToDBNull(accionsocial), isNothingToDBNull(atendido), isNothingToDBNull(motivonoatencion), isNothingToDBNull(departamento), isNothingToDBNull(municipio), isNothingToDBNull(concejo), isNothingToDBNull(ninos5), isNothingToDBNull(gestantes), isNothingToDBNull(ninos6y17), isNothingToDBNull(estudia_actualmente), isNothingToDBNull(estudia_antes), _
                    isNothingToDBNull(wfecha_radicacion_inicial), isNothingToDBNull(wfecha_radicacion_final))
    End Function

    Public Shared Function CargarPorFiltroEducacion(ByVal id_grupo As Int32, ByVal identificacion As String, ByVal nombre As String, ByVal id_regional As Integer, _
        ByVal fechaatencioninicial As String, ByVal fechaatencionfinal As String, ByVal wdeclarante As Integer, ByVal Id_LugarEntrega As Int32, ByVal chk_pendiente As Boolean) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorFiltroEducacion", isNothingToDBNull(id_grupo), isNothingToDBNull(identificacion), isNothingToDBNull(nombre), isNothingToDBNull(id_regional), _
                    isNothingToDBNull(fechaatencioninicial), isNothingToDBNull(fechaatencionfinal), isNothingToDBNull(wdeclarante), isNothingToDBNull(Id_LugarEntrega), chk_pendiente)
    End Function

    Public Shared Function CargarPorBusqueda(ByVal id_grupo As Int32, ByVal lugarfuente As Int32, ByVal horario As String, ByVal declarante As Int32, ByVal regional As Int32, ByVal fechadeclaracioninicial As String, ByVal fechadeclaracionfinal As String, _
       ByVal fechadesplazamientoinicial As String, ByVal fechadesplazamientofinal As String, ByVal fechaatencioninicial As String, ByVal fechaatencionfinal As String, ByVal identificacion As String, ByVal nombre As String, ByVal fuente As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarBusqueda", isNothingToDBNull(id_grupo), isNothingToDBNull(lugarfuente), isNothingToDBNull(horario), isNothingToDBNull(declarante), isNothingToDBNull(regional), isNothingToDBNull(fechadeclaracioninicial), isNothingToDBNull(fechadeclaracionfinal), _
              isNothingToDBNull(fechadesplazamientoinicial), isNothingToDBNull(fechadesplazamientofinal), isNothingToDBNull(fechaatencioninicial), isNothingToDBNull(fechaatencionfinal), isNothingToDBNull(identificacion), isNothingToDBNull(nombre), isNothingToDBNull(fuente))
    End Function

    Public Shared Function CargarPorId_Tipo_Miembro(ByVal Id_Tipo_Miembro As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Tipo_Miembro", Id_Tipo_Miembro)
    End Function

    Public Shared Function CargarPorId_Afectado_Desplazamiento(ByVal Id_Afectado_Desplazamiento As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Afectado_Desplazamiento", Id_Afectado_Desplazamiento)
    End Function

    Public Shared Function CargarPorId_Certificado(ByVal Id_Certificado As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Certificado", Id_Certificado)
    End Function

    Public Shared Function CargarPorFiltroRegimenSalud(ByVal id_grupo As Int32, ByVal identificacion As String, ByVal nombre As String, ByVal id_regional As Integer, _
        ByVal fechaatencioninicial As String, ByVal fechaatencionfinal As String, ByVal wdeclarante As Integer, ByVal Id_LugarEntrega As Int32, ByVal chk_pendiente As Boolean) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorFiltroRegimenSalud", isNothingToDBNull(id_grupo), isNothingToDBNull(identificacion), isNothingToDBNull(nombre), isNothingToDBNull(id_regional), _
                    isNothingToDBNull(fechaatencioninicial), isNothingToDBNull(fechaatencionfinal), isNothingToDBNull(wdeclarante), isNothingToDBNull(Id_LugarEntrega), chk_pendiente)
    End Function

    Public Shared Function CargarPorId_Grupo(ByVal Id_Grupo As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Grupo", Id_Grupo)
    End Function

    Public Shared Function CargarPorId_Programa_EntregaAdicional(ByVal Id_Programa As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PersonasConsultarPorId_Programa_EntregaAdicional", Id_Programa)
    End Function

End Class

