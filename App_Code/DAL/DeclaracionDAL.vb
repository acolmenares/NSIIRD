Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class DeclaracionDAL

    Public Shared Function Insertar(ByVal Id_Fuente As Int32, ByVal Fecha_Declaracion As DateTime, ByVal Gestantes As Int32, ByVal Menores_Ninos As Int32, ByVal Menores_Ninas As Int32, ByVal Recien_Nacidos As Int32, ByVal Lactantes As Int32, ByVal Resto_Nucleo As Int32, ByVal Fecha_Desplazamiento As DateTime, ByVal Id_Municipio_Expulsor As Int32, ByVal Vereda_Desplazamiento As String, ByVal Fecha_Valoracion As DateTime, ByVal Id_Ha_Regresado As Int32, ByVal Id_Retornaria As Int32, ByVal Id_Explicacion_Retorno As Int32, ByVal Id_Ha_Declarado_Antes As Int32, ByVal Id_Ha_Recibido_Ayuda As Int32, ByVal Id_Ha_Muerto_Alguien As Int32, ByVal Cuantos_Muertos As Int32, ByVal Cuantos_Muertos_Menores As Int32, ByVal Id_Motivo_Muerte As Int32, ByVal Id_Parentesco_Muerte As Int32, ByVal Id_Enfermedad As Int32, ByVal Id_Velar_Enterrar As Int32, ByVal Id_Tiene_Desaparecido As Int32, ByVal Id_Parentesco_Desaparecido As Int32, ByVal Id_Reporto As Int32, ByVal Id_Entidad_Legal As Int32, ByVal Id_Aplico_Reparaciones As Int32, ByVal Dias_Aplico As Int32, ByVal Id_Estado_Aplicacion As Int32, ByVal Id_Motivo_No_Aplico As Int32, ByVal Id_Llegada_Insultos As Int32, ByVal Id_Llegada_Insultos_Usted As Int32, ByVal Id_Llegada_Insultos_Miembro As Int32, ByVal Llegada_Insultos_Agresor As String, ByVal Id_Llegada_Sexual As Int32, ByVal Id_Llegada_Sexual_Usted As Int32, ByVal Id_Llegada_Sexual_Miembro As Int32, ByVal Llegada_Sexual_Agresor As String, ByVal Id_Llegada_Golpes As Int32, ByVal Id_Llegada_Golpes_Usted As Int32, ByVal Id_Llegada_Golpes_Miembro As Int32, ByVal Llegada_Golpes_Agresor As String, ByVal Fecha_Segunda_Encuesta As DateTime, ByVal Id_Ha_Redibido_Ayuda_Despues As Int32, ByVal Dias_Aplico_Despues As Int32, ByVal Id_Estatus_Aplicacion_Despues As Int32, ByVal Id_Razon_No_Aplico As Int32, ByVal Id_Oido_Mesa_Desplazados As Int32, ByVal Id_Pertenece_Asociacion As Int32, ByVal Cual_Asociacion As String, ByVal Id_Esta_Trabajando As Int32, ByVal Id_beneficiado_programas As Int32, ByVal Id_Grupo As Int32, ByVal Id_Regional As Int32, ByVal Id_Atender As Int32, ByVal Id_Motivo_Noatender As Int32, ByVal Id_Tipo_Tenencia_Vivienda As Int32, ByVal Id_Cuantas_Habitaciones As Int32, ByVal Id_Cuantas_Personas_Vivienda As Int32, ByVal Id_Cuantas_Personas_Habitacion As Int32, ByVal Id_Materiales_Vivienda As Int32, ByVal Id_Forma_Declaracion As Int32, ByVal Id_Departamento_Expulsor As Int32, ByVal Id_Cuantos_Desplazamientos As Int32, ByVal Lugar_Desplazamiento As String, ByVal Fecha_Desplazamiento_Anterior As DateTime, ByVal Id_Motivo_Desplazamiento As Int32, ByVal Id_Cuanto_Tiempo_Demoro As Int32, ByVal Id_Motivo_Demora As Int32, ByVal Id_Motivo_NoDeclaro_Municipio As Int32, ByVal Id_Vivio_Cabezera_Municipal As Int32, ByVal Id_Tiempo_Casco_Urbano As Int32, ByVal Id_Entidad_Inicial_Atencion As Int32, ByVal Id_Recibio_Ayuda_Entidad_Inicial As Int32, ByVal Id_Como_Fue_Atencion As Int32, ByVal Id_Como_Brindar_Atencion As Int32, ByVal Promedio_Ingresos_Mensuales As Double, ByVal Fecha_Muerte As DateTime, ByVal Cuantos_Familiares_Desaparecidos As Int32, ByVal Id_Porque_No_Reporto As Int32, ByVal Id_Despues_Hijos_617 As Int32, ByVal Cuantos_Despues_Hijos As Int32, ByVal Cuantos_Despues_Hijos_Estudian As Int32, ByVal Id_Tipo_Bien_Rural As Int32, ByVal Id_Documento_Propiedad As Int32, ByVal Id_Destino_Tierra As Int32, ByVal Id_Situacion_Actual_Tierras As Int32, ByVal Observaciones As String, ByVal Id_Despues_Afiliado_Regimen_Subsidiado As Int32, ByVal Cuantos_Despues_Afiliado_Regimen_Subsidiado As Int32, ByVal Id_Despues_Afiliado_Regimen_Contributivo As Int32, ByVal Cuantos_Despues_Afiliado_Regimen_Contributivo As Int32, ByVal Id_Despues_Afiliado_Sisben As Int32, ByVal Cuantos_Despues_Afiliado_Sisben As Int32, ByVal Id_Ley_Reparacion As Int32, ByVal Id_Es_Del_Municipio As Int32, ByVal Motivo_Desplazamiento As String, ByVal fecha_ingreso_registro As Date, ByVal tipo_declaracion As Int32, ByVal horario As String, ByVal id_tipo_familia_desplazada As Int32, ByVal Id_Vulnerables_NoDesplazada As Int32, ByVal Motivo_Remision As String, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal id_solicito_ayuda As Int32, ByVal id_concejo_expulsor As Int32, ByVal id_lugar_fuente As Int32, ByVal id_enlinea As Int32, ByVal id_agua_potable As Int32, ByVal id_tiene_documento As Int32, ByVal id_tipo_familia_No_desplazada As Int32, ByVal Fecha_Radicacion As DateTime, ByVal Numero_Declaracion As String, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean, ByVal Id_Familias_Accion As Int32, ByVal Id_Red_Unidos As Int32, ByVal Municipio_Unidos As String, ByVal Id_VBG_general As Int32, ByVal VBG_General_Agresor As String, ByVal Id_Ha_Muerto_Despues As Int32, ByVal Id_Solicito_Atencion_Psicologica As Int32, ByVal Id_Afectado_Desplazamiento As Int32, ByVal Id_Emociones As Int32, ByVal Id_Tipo_Adiccion As Int32, ByVal Id_Adiccion_Alcohol As Int32, ByVal Id_Adiccion_Droga As Int32, ByVal Municipio_Familias_Accion As String, ByVal Id_Municipio_Faccion As Int32) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.DeclaracionInsertar", isNothingToDBNull(Id_Fuente), isNothingToDBNull(Fecha_Declaracion), isNothingToDBNull(Gestantes), isNothingToDBNull(Menores_Ninos), isNothingToDBNull(Menores_Ninas), isNothingToDBNull(Recien_Nacidos), isNothingToDBNull(Lactantes), isNothingToDBNull(Resto_Nucleo), isNothingToDBNull(Fecha_Desplazamiento), isNothingToDBNull(Id_Municipio_Expulsor), isNothingToDBNull(Vereda_Desplazamiento), isNothingToDBNull(Fecha_Valoracion), isNothingToDBNull(Id_Ha_Regresado), isNothingToDBNull(Id_Retornaria), isNothingToDBNull(Id_Explicacion_Retorno), isNothingToDBNull(Id_Ha_Declarado_Antes), isNothingToDBNull(Id_Ha_Recibido_Ayuda), isNothingToDBNull(Id_Ha_Muerto_Alguien), isNothingToDBNull(Cuantos_Muertos), isNothingToDBNull(Cuantos_Muertos_Menores), isNothingToDBNull(Id_Motivo_Muerte), isNothingToDBNull(Id_Parentesco_Muerte), isNothingToDBNull(Id_Enfermedad), isNothingToDBNull(Id_Velar_Enterrar), isNothingToDBNull(Id_Tiene_Desaparecido), isNothingToDBNull(Id_Parentesco_Desaparecido), isNothingToDBNull(Id_Reporto), isNothingToDBNull(Id_Entidad_Legal), isNothingToDBNull(Id_Aplico_Reparaciones), isNothingToDBNull(Dias_Aplico), isNothingToDBNull(Id_Estado_Aplicacion), isNothingToDBNull(Id_Motivo_No_Aplico), isNothingToDBNull(Id_Llegada_Insultos), isNothingToDBNull(Id_Llegada_Insultos_Usted), isNothingToDBNull(Id_Llegada_Insultos_Miembro), isNothingToDBNull(Llegada_Insultos_Agresor), isNothingToDBNull(Id_Llegada_Sexual), isNothingToDBNull(Id_Llegada_Sexual_Usted), isNothingToDBNull(Id_Llegada_Sexual_Miembro), isNothingToDBNull(Llegada_Sexual_Agresor), isNothingToDBNull(Id_Llegada_Golpes), isNothingToDBNull(Id_Llegada_Golpes_Usted), isNothingToDBNull(Id_Llegada_Golpes_Miembro), isNothingToDBNull(Llegada_Golpes_Agresor), isNothingToDBNull(Fecha_Segunda_Encuesta), isNothingToDBNull(Id_Ha_Redibido_Ayuda_Despues), isNothingToDBNull(Dias_Aplico_Despues), isNothingToDBNull(Id_Estatus_Aplicacion_Despues), isNothingToDBNull(Id_Razon_No_Aplico), isNothingToDBNull(Id_Oido_Mesa_Desplazados), isNothingToDBNull(Id_Pertenece_Asociacion), isNothingToDBNull(Cual_Asociacion), isNothingToDBNull(Id_Esta_Trabajando), isNothingToDBNull(Id_beneficiado_programas), isNothingToDBNull(Id_Grupo), isNothingToDBNull(Id_Regional), isNothingToDBNull(Id_Atender), isNothingToDBNull(Id_Motivo_Noatender), isNothingToDBNull(Id_Tipo_Tenencia_Vivienda), isNothingToDBNull(Id_Cuantas_Habitaciones), isNothingToDBNull(Id_Cuantas_Personas_Vivienda), isNothingToDBNull(Id_Cuantas_Personas_Habitacion), isNothingToDBNull(Id_Materiales_Vivienda), isNothingToDBNull(Id_Forma_Declaracion), isNothingToDBNull(Id_Departamento_Expulsor), isNothingToDBNull(Id_Cuantos_Desplazamientos), isNothingToDBNull(Lugar_Desplazamiento), isNothingToDBNull(Fecha_Desplazamiento_Anterior), isNothingToDBNull(Id_Motivo_Desplazamiento), isNothingToDBNull(Id_Cuanto_Tiempo_Demoro), isNothingToDBNull(Id_Motivo_Demora), isNothingToDBNull(Id_Motivo_NoDeclaro_Municipio), isNothingToDBNull(Id_Vivio_Cabezera_Municipal), isNothingToDBNull(Id_Tiempo_Casco_Urbano), isNothingToDBNull(Id_Entidad_Inicial_Atencion), isNothingToDBNull(Id_Recibio_Ayuda_Entidad_Inicial), isNothingToDBNull(Id_Como_Fue_Atencion), isNothingToDBNull(Id_Como_Brindar_Atencion), isNothingToDBNull(Promedio_Ingresos_Mensuales), isNothingToDBNull(Fecha_Muerte), isNothingToDBNull(Cuantos_Familiares_Desaparecidos), isNothingToDBNull(Id_Porque_No_Reporto), isNothingToDBNull(Id_Despues_Hijos_617), isNothingToDBNull(Cuantos_Despues_Hijos), isNothingToDBNull(Cuantos_Despues_Hijos_Estudian), isNothingToDBNull(Id_Tipo_Bien_Rural), isNothingToDBNull(Id_Documento_Propiedad), isNothingToDBNull(Id_Destino_Tierra), isNothingToDBNull(Id_Situacion_Actual_Tierras), isNothingToDBNull(Observaciones), isNothingToDBNull(Id_Despues_Afiliado_Regimen_Subsidiado), isNothingToDBNull(Cuantos_Despues_Afiliado_Regimen_Subsidiado), isNothingToDBNull(Id_Despues_Afiliado_Regimen_Contributivo), isNothingToDBNull(Cuantos_Despues_Afiliado_Regimen_Contributivo), isNothingToDBNull(Id_Despues_Afiliado_Sisben), isNothingToDBNull(Cuantos_Despues_Afiliado_Sisben), isNothingToDBNull(Id_Ley_Reparacion), isNothingToDBNull(Id_Es_Del_Municipio), isNothingToDBNull(Motivo_Desplazamiento), isNothingToDBNull(fecha_ingreso_registro), isNothingToDBNull(tipo_declaracion), isNothingToDBNull(horario), isNothingToDBNull(id_tipo_familia_desplazada), isNothingToDBNull(Id_Vulnerables_NoDesplazada), isNothingToDBNull(Motivo_Remision), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(id_solicito_ayuda), isNothingToDBNull(id_concejo_expulsor), isNothingToDBNull(id_lugar_fuente), isNothingToDBNull(id_enlinea), isNothingToDBNull(id_agua_potable), isNothingToDBNull(id_tiene_documento), isNothingToDBNull(id_tipo_familia_No_desplazada), isNothingToDBNull(Fecha_Radicacion), isNothingToDBNull(Numero_Declaracion), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre), isNothingToDBNull(Id_Familias_Accion), isNothingToDBNull(Id_Red_Unidos), isNothingToDBNull(Municipio_Unidos), isNothingToDBNull(Id_VBG_general), isNothingToDBNull(VBG_General_Agresor), isNothingToDBNull(Id_Ha_Muerto_Despues), isNothingToDBNull(Id_Solicito_Atencion_Psicologica), isNothingToDBNull(Id_Afectado_Desplazamiento), isNothingToDBNull(Id_Emociones), isNothingToDBNull(Id_Tipo_Adiccion), isNothingToDBNull(Id_Adiccion_Alcohol), isNothingToDBNull(Id_Adiccion_Droga), isNothingToDBNull(Municipio_Familias_Accion), isNothingToDBNull(Id_Municipio_Faccion))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Fuente As Int32, ByVal Fecha_Declaracion As DateTime, ByVal Gestantes As Int32, ByVal Menores_Ninos As Int32, ByVal Menores_Ninas As Int32, ByVal Recien_Nacidos As Int32, ByVal Lactantes As Int32, ByVal Resto_Nucleo As Int32, ByVal Fecha_Desplazamiento As DateTime, ByVal Id_Municipio_Expulsor As Int32, ByVal Vereda_Desplazamiento As String, ByVal Fecha_Valoracion As DateTime, ByVal Id_Ha_Regresado As Int32, ByVal Id_Retornaria As Int32, ByVal Id_Explicacion_Retorno As Int32, ByVal Id_Ha_Declarado_Antes As Int32, ByVal Id_Ha_Recibido_Ayuda As Int32, ByVal Id_Ha_Muerto_Alguien As Int32, ByVal Cuantos_Muertos As Int32, ByVal Cuantos_Muertos_Menores As Int32, ByVal Id_Motivo_Muerte As Int32, ByVal Id_Parentesco_Muerte As Int32, ByVal Id_Enfermedad As Int32, ByVal Id_Velar_Enterrar As Int32, ByVal Id_Tiene_Desaparecido As Int32, ByVal Id_Parentesco_Desaparecido As Int32, ByVal Id_Reporto As Int32, ByVal Id_Entidad_Legal As Int32, ByVal Id_Aplico_Reparaciones As Int32, ByVal Dias_Aplico As Int32, ByVal Id_Estado_Aplicacion As Int32, ByVal Id_Motivo_No_Aplico As Int32, ByVal Id_Llegada_Insultos As Int32, ByVal Id_Llegada_Insultos_Usted As Int32, ByVal Id_Llegada_Insultos_Miembro As Int32, ByVal Llegada_Insultos_Agresor As String, ByVal Id_Llegada_Sexual As Int32, ByVal Id_Llegada_Sexual_Usted As Int32, ByVal Id_Llegada_Sexual_Miembro As Int32, ByVal Llegada_Sexual_Agresor As String, ByVal Id_Llegada_Golpes As Int32, ByVal Id_Llegada_Golpes_Usted As Int32, ByVal Id_Llegada_Golpes_Miembro As Int32, ByVal Llegada_Golpes_Agresor As String, ByVal Fecha_Segunda_Encuesta As DateTime, ByVal Id_Ha_Redibido_Ayuda_Despues As Int32, ByVal Dias_Aplico_Despues As Int32, ByVal Id_Estatus_Aplicacion_Despues As Int32, ByVal Id_Razon_No_Aplico As Int32, ByVal Id_Oido_Mesa_Desplazados As Int32, ByVal Id_Pertenece_Asociacion As Int32, ByVal Cual_Asociacion As String, ByVal Id_Esta_Trabajando As Int32, ByVal Id_beneficiado_programas As Int32, ByVal Id_Grupo As Int32, ByVal Id_Regional As Int32, ByVal Id_Atender As Int32, ByVal Id_Motivo_Noatender As Int32, ByVal Id_Tipo_Tenencia_Vivienda As Int32, ByVal Id_Cuantas_Habitaciones As Int32, ByVal Id_Cuantas_Personas_Vivienda As Int32, ByVal Id_Cuantas_Personas_Habitacion As Int32, ByVal Id_Materiales_Vivienda As Int32, ByVal Id_Forma_Declaracion As Int32, ByVal Id_Departamento_Expulsor As Int32, ByVal Id_Cuantos_Desplazamientos As Int32, ByVal Lugar_Desplazamiento As String, ByVal Fecha_Desplazamiento_Anterior As DateTime, ByVal Id_Motivo_Desplazamiento As Int32, ByVal Id_Cuanto_Tiempo_Demoro As Int32, ByVal Id_Motivo_Demora As Int32, ByVal Id_Motivo_NoDeclaro_Municipio As Int32, ByVal Id_Vivio_Cabezera_Municipal As Int32, ByVal Id_Tiempo_Casco_Urbano As Int32, ByVal Id_Entidad_Inicial_Atencion As Int32, ByVal Id_Recibio_Ayuda_Entidad_Inicial As Int32, ByVal Id_Como_Fue_Atencion As Int32, ByVal Id_Como_Brindar_Atencion As Int32, ByVal Promedio_Ingresos_Mensuales As Double, ByVal Fecha_Muerte As DateTime, ByVal Cuantos_Familiares_Desaparecidos As Int32, ByVal Id_Porque_No_Reporto As Int32, ByVal Id_Despues_Hijos_617 As Int32, ByVal Cuantos_Despues_Hijos As Int32, ByVal Cuantos_Despues_Hijos_Estudian As Int32, ByVal Id_Tipo_Bien_Rural As Int32, ByVal Id_Documento_Propiedad As Int32, ByVal Id_Destino_Tierra As Int32, ByVal Id_Situacion_Actual_Tierras As Int32, ByVal Observaciones As String, ByVal Id_Despues_Afiliado_Regimen_Subsidiado As Int32, ByVal Cuantos_Despues_Afiliado_Regimen_Subsidiado As Int32, ByVal Id_Despues_Afiliado_Regimen_Contributivo As Int32, ByVal Cuantos_Despues_Afiliado_Regimen_Contributivo As Int32, ByVal Id_Despues_Afiliado_Sisben As Int32, ByVal Cuantos_Despues_Afiliado_Sisben As Int32, ByVal Id_Ley_Reparacion As Int32, ByVal Id_Es_Del_Municipio As Int32, ByVal Motivo_Desplazamiento As String, ByVal fecha_ingreso_registro As Date, ByVal tipo_declaracion As Int32, ByVal horario As String, ByVal id_tipo_familia_desplazada As Int32, ByVal Id_Vulnerables_NoDesplazada As Int32, ByVal Motivo_Remision As String, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal id_solicito_ayuda As Int32, ByVal id_concejo_expulsor As Int32, ByVal id_lugar_fuente As Int32, ByVal id_enlinea As Int32, ByVal id_agua_potable As Int32, ByVal id_tiene_documento As Int32, ByVal id_tipo_familia_No_desplazada As Int32, ByVal Fecha_Radicacion As DateTime, ByVal Numero_Declaracion As String, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean, ByVal Id_Familias_Accion As Int32, ByVal Id_Red_Unidos As Int32, ByVal Municipio_Unidos As String, ByVal Id_VBG_general As Int32, ByVal VBG_General_Agresor As String, ByVal Id_Ha_Muerto_Despues As Int32, ByVal Id_Solicito_Atencion_Psicologica As Int32, ByVal Id_Afectado_Desplazamiento As Int32, ByVal Id_Emociones As Int32, ByVal Id_Tipo_Adiccion As Int32, ByVal Id_Adiccion_Alcohol As Int32, ByVal Id_Adiccion_Droga As Int32, ByVal Municipio_Familias_Accion As String, ByVal Id_Municipio_Faccion As Int32)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.DeclaracionActualizar", Id, isNothingToDBNull(Id_Fuente), isNothingToDBNull(Fecha_Declaracion), isNothingToDBNull(Gestantes), isNothingToDBNull(Menores_Ninos), isNothingToDBNull(Menores_Ninas), isNothingToDBNull(Recien_Nacidos), isNothingToDBNull(Lactantes), isNothingToDBNull(Resto_Nucleo), isNothingToDBNull(Fecha_Desplazamiento), isNothingToDBNull(Id_Municipio_Expulsor), isNothingToDBNull(Vereda_Desplazamiento), isNothingToDBNull(Fecha_Valoracion), isNothingToDBNull(Id_Ha_Regresado), isNothingToDBNull(Id_Retornaria), isNothingToDBNull(Id_Explicacion_Retorno), isNothingToDBNull(Id_Ha_Declarado_Antes), isNothingToDBNull(Id_Ha_Recibido_Ayuda), isNothingToDBNull(Id_Ha_Muerto_Alguien), isNothingToDBNull(Cuantos_Muertos), isNothingToDBNull(Cuantos_Muertos_Menores), isNothingToDBNull(Id_Motivo_Muerte), isNothingToDBNull(Id_Parentesco_Muerte), isNothingToDBNull(Id_Enfermedad), isNothingToDBNull(Id_Velar_Enterrar), isNothingToDBNull(Id_Tiene_Desaparecido), isNothingToDBNull(Id_Parentesco_Desaparecido), isNothingToDBNull(Id_Reporto), isNothingToDBNull(Id_Entidad_Legal), isNothingToDBNull(Id_Aplico_Reparaciones), isNothingToDBNull(Dias_Aplico), isNothingToDBNull(Id_Estado_Aplicacion), isNothingToDBNull(Id_Motivo_No_Aplico), isNothingToDBNull(Id_Llegada_Insultos), isNothingToDBNull(Id_Llegada_Insultos_Usted), isNothingToDBNull(Id_Llegada_Insultos_Miembro), isNothingToDBNull(Llegada_Insultos_Agresor), isNothingToDBNull(Id_Llegada_Sexual), isNothingToDBNull(Id_Llegada_Sexual_Usted), isNothingToDBNull(Id_Llegada_Sexual_Miembro), isNothingToDBNull(Llegada_Sexual_Agresor), isNothingToDBNull(Id_Llegada_Golpes), isNothingToDBNull(Id_Llegada_Golpes_Usted), isNothingToDBNull(Id_Llegada_Golpes_Miembro), isNothingToDBNull(Llegada_Golpes_Agresor), isNothingToDBNull(Fecha_Segunda_Encuesta), isNothingToDBNull(Id_Ha_Redibido_Ayuda_Despues), isNothingToDBNull(Dias_Aplico_Despues), isNothingToDBNull(Id_Estatus_Aplicacion_Despues), isNothingToDBNull(Id_Razon_No_Aplico), isNothingToDBNull(Id_Oido_Mesa_Desplazados), isNothingToDBNull(Id_Pertenece_Asociacion), isNothingToDBNull(Cual_Asociacion), isNothingToDBNull(Id_Esta_Trabajando), isNothingToDBNull(Id_beneficiado_programas), isNothingToDBNull(Id_Grupo), isNothingToDBNull(Id_Regional), isNothingToDBNull(Id_Atender), isNothingToDBNull(Id_Motivo_Noatender), isNothingToDBNull(Id_Tipo_Tenencia_Vivienda), isNothingToDBNull(Id_Cuantas_Habitaciones), isNothingToDBNull(Id_Cuantas_Personas_Vivienda), isNothingToDBNull(Id_Cuantas_Personas_Habitacion), isNothingToDBNull(Id_Materiales_Vivienda), isNothingToDBNull(Id_Forma_Declaracion), isNothingToDBNull(Id_Departamento_Expulsor), isNothingToDBNull(Id_Cuantos_Desplazamientos), isNothingToDBNull(Lugar_Desplazamiento), isNothingToDBNull(Fecha_Desplazamiento_Anterior), isNothingToDBNull(Id_Motivo_Desplazamiento), isNothingToDBNull(Id_Cuanto_Tiempo_Demoro), isNothingToDBNull(Id_Motivo_Demora), isNothingToDBNull(Id_Motivo_NoDeclaro_Municipio), isNothingToDBNull(Id_Vivio_Cabezera_Municipal), isNothingToDBNull(Id_Tiempo_Casco_Urbano), isNothingToDBNull(Id_Entidad_Inicial_Atencion), isNothingToDBNull(Id_Recibio_Ayuda_Entidad_Inicial), isNothingToDBNull(Id_Como_Fue_Atencion), isNothingToDBNull(Id_Como_Brindar_Atencion), isNothingToDBNull(Promedio_Ingresos_Mensuales), isNothingToDBNull(Fecha_Muerte), isNothingToDBNull(Cuantos_Familiares_Desaparecidos), isNothingToDBNull(Id_Porque_No_Reporto), isNothingToDBNull(Id_Despues_Hijos_617), isNothingToDBNull(Cuantos_Despues_Hijos), isNothingToDBNull(Cuantos_Despues_Hijos_Estudian), isNothingToDBNull(Id_Tipo_Bien_Rural), isNothingToDBNull(Id_Documento_Propiedad), isNothingToDBNull(Id_Destino_Tierra), isNothingToDBNull(Id_Situacion_Actual_Tierras), isNothingToDBNull(Observaciones), isNothingToDBNull(Id_Despues_Afiliado_Regimen_Subsidiado), isNothingToDBNull(Cuantos_Despues_Afiliado_Regimen_Subsidiado), isNothingToDBNull(Id_Despues_Afiliado_Regimen_Contributivo), isNothingToDBNull(Cuantos_Despues_Afiliado_Regimen_Contributivo), isNothingToDBNull(Id_Despues_Afiliado_Sisben), isNothingToDBNull(Cuantos_Despues_Afiliado_Sisben), isNothingToDBNull(Id_Ley_Reparacion), isNothingToDBNull(Id_Es_Del_Municipio), isNothingToDBNull(Motivo_Desplazamiento), isNothingToDBNull(fecha_ingreso_registro), isNothingToDBNull(tipo_declaracion), isNothingToDBNull(horario), isNothingToDBNull(id_tipo_familia_desplazada), isNothingToDBNull(Id_Vulnerables_NoDesplazada), isNothingToDBNull(Motivo_Remision), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(id_solicito_ayuda), isNothingToDBNull(id_concejo_expulsor), isNothingToDBNull(id_lugar_fuente), isNothingToDBNull(id_enlinea), isNothingToDBNull(id_agua_potable), isNothingToDBNull(id_tiene_documento), isNothingToDBNull(id_tipo_familia_No_desplazada), isNothingToDBNull(Fecha_Radicacion), isNothingToDBNull(Numero_Declaracion), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre), isNothingToDBNull(Id_Familias_Accion), isNothingToDBNull(Id_Red_Unidos), isNothingToDBNull(Municipio_Unidos), isNothingToDBNull(Id_VBG_general), isNothingToDBNull(VBG_General_Agresor), isNothingToDBNull(Id_Ha_Muerto_Despues), isNothingToDBNull(Id_Solicito_Atencion_Psicologica), isNothingToDBNull(Id_Afectado_Desplazamiento), isNothingToDBNull(Id_Emociones), isNothingToDBNull(Id_Tipo_Adiccion), isNothingToDBNull(Id_Adiccion_Alcohol), isNothingToDBNull(Id_Adiccion_Droga), isNothingToDBNull(Municipio_Familias_Accion), isNothingToDBNull(Id_Municipio_Faccion))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.DeclaracionEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Aplico_Reparaciones(ByVal Id_Aplico_Reparaciones As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Aplico_Reparaciones", Id_Aplico_Reparaciones)
    End Function

    Public Shared Function CargarPorId_Asistian_Escuela(ByVal Id_Asistian_Escuela As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Asistian_Escuela", Id_Asistian_Escuela)
    End Function

    Public Shared Function CargarPorId_Condicion_Especial(ByVal Id_Condicion_Especial As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Condicion_Especial", Id_Condicion_Especial)
    End Function

    Public Shared Function CargarPorId_Enfermedad(ByVal Id_Enfermedad As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Enfermedad", Id_Enfermedad)
    End Function

    Public Shared Function CargarPorId_Entidad_Legal(ByVal Id_Entidad_Legal As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Entidad_Legal", Id_Entidad_Legal)
    End Function

    Public Shared Function CargarPorId_Esta_Trabajando(ByVal Id_Esta_Trabajando As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Esta_Trabajando", Id_Esta_Trabajando)
    End Function

    Public Shared Function CargarPorId_Estado_Aplicacion(ByVal Id_Estado_Aplicacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Estado_Aplicacion", Id_Estado_Aplicacion)
    End Function

    Public Shared Function CargarPorId_Estatus_Aplicacion_Despues(ByVal Id_Estatus_Aplicacion_Despues As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Estatus_Aplicacion_Despues", Id_Estatus_Aplicacion_Despues)
    End Function

    Public Shared Function CargarPorId_Explicacion_Retorno(ByVal Id_Explicacion_Retorno As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Explicacion_Retorno", Id_Explicacion_Retorno)
    End Function

    Public Shared Function CargarPorId_Fuente(ByVal Id_Fuente As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Fuente", Id_Fuente)
    End Function

    Public Shared Function CargarPorId_Ha_Declarado_Antes(ByVal Id_Ha_Declarado_Antes As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Ha_Declarado_Antes", Id_Ha_Declarado_Antes)
    End Function

    Public Shared Function CargarPorId_Ha_Muerto_Alguien(ByVal Id_Ha_Muerto_Alguien As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Ha_Muerto_Alguien", Id_Ha_Muerto_Alguien)
    End Function

    Public Shared Function CargarPorId_Ha_Recibido_Ayuda(ByVal Id_Ha_Recibido_Ayuda As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Ha_Recibido_Ayuda", Id_Ha_Recibido_Ayuda)
    End Function

    Public Shared Function CargarPorId_Ha_Redibido_Ayuda_Despues(ByVal Id_Ha_Redibido_Ayuda_Despues As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Ha_Redibido_Ayuda_Despues", Id_Ha_Redibido_Ayuda_Despues)
    End Function

    Public Shared Function CargarPorId_Ha_Regresado(ByVal Id_Ha_Regresado As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Ha_Regresado", Id_Ha_Regresado)
    End Function

    Public Shared Function CargarPorId_Llegada_Golpes(ByVal Id_Llegada_Golpes As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Llegada_Golpes", Id_Llegada_Golpes)
    End Function

    Public Shared Function CargarPorId_Llegada_Golpes_Miembro(ByVal Id_Llegada_Golpes_Miembro As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Llegada_Golpes_Miembro", Id_Llegada_Golpes_Miembro)
    End Function

    Public Shared Function CargarPorId_Llegada_Golpes_Usted(ByVal Id_Llegada_Golpes_Usted As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Llegada_Golpes_Usted", Id_Llegada_Golpes_Usted)
    End Function

    Public Shared Function CargarPorId_Llegada_Insultos(ByVal Id_Llegada_Insultos As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Llegada_Insultos", Id_Llegada_Insultos)
    End Function

    Public Shared Function CargarPorId_Llegada_Insultos_Miembro(ByVal Id_Llegada_Insultos_Miembro As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Llegada_Insultos_Miembro", Id_Llegada_Insultos_Miembro)
    End Function

    Public Shared Function CargarPorId_Llegada_Insultos_Usted(ByVal Id_Llegada_Insultos_Usted As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Llegada_Insultos_Usted", Id_Llegada_Insultos_Usted)
    End Function

    Public Shared Function CargarPorId_Llegada_Sexual(ByVal Id_Llegada_Sexual As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Llegada_Sexual", Id_Llegada_Sexual)
    End Function

    Public Shared Function CargarPorId_Llegada_Sexual_Miembro(ByVal Id_Llegada_Sexual_Miembro As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Llegada_Sexual_Miembro", Id_Llegada_Sexual_Miembro)
    End Function

    Public Shared Function CargarPorId_Llegada_Sexual_Usted(ByVal Id_Llegada_Sexual_Usted As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Llegada_Sexual_Usted", Id_Llegada_Sexual_Usted)
    End Function

    Public Shared Function CargarPorId_Motivo_Muerte(ByVal Id_Motivo_Muerte As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Motivo_Muerte", Id_Motivo_Muerte)
    End Function

    Public Shared Function CargarPorId_Motivo_No_Aplico(ByVal Id_Motivo_No_Aplico As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Motivo_No_Aplico", Id_Motivo_No_Aplico)
    End Function

    Public Shared Function CargarPorId_Municipio_Expulsor(ByVal Id_Municipio_Expulsor As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Municipio_Expulsor", Id_Municipio_Expulsor)
    End Function

    Public Shared Function CargarPorId_Oido_Mesa_Desplazados(ByVal Id_Oido_Mesa_Desplazados As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Oido_Mesa_Desplazados", Id_Oido_Mesa_Desplazados)
    End Function

    Public Shared Function CargarPorId_Parentesco_Desaparecido(ByVal Id_Parentesco_Desaparecido As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Parentesco_Desaparecido", Id_Parentesco_Desaparecido)
    End Function

    Public Shared Function CargarPorId_Parentesco_Muerte(ByVal Id_Parentesco_Muerte As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Parentesco_Muerte", Id_Parentesco_Muerte)
    End Function

    Public Shared Function CargarPorId_Pertenece_Asociacion(ByVal Id_Pertenece_Asociacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Pertenece_Asociacion", Id_Pertenece_Asociacion)
    End Function

    Public Shared Function CargarPorId_Razon_No_Aplico(ByVal Id_Razon_No_Aplico As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Razon_No_Aplico", Id_Razon_No_Aplico)
    End Function

    Public Shared Function CargarPorId_Reporto(ByVal Id_Reporto As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Reporto", Id_Reporto)
    End Function

    Public Shared Function CargarPorId_Retornaria(ByVal Id_Retornaria As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Retornaria", Id_Retornaria)
    End Function

    Public Shared Function CargarPorId_Tiene_Desaparecido(ByVal Id_Tiene_Desaparecido As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Tiene_Desaparecido", Id_Tiene_Desaparecido)
    End Function

    Public Shared Function CargarPorId_Velar_Enterrar(ByVal Id_Velar_Enterrar As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Velar_Enterrar", Id_Velar_Enterrar)
    End Function

    Public Shared Function CargarPorId_beneficiado_programas(ByVal Id_beneficiado_programas As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_beneficiado_programas", Id_beneficiado_programas)
    End Function

    Public Shared Function CargarPorId_Grupo(ByVal Id_Grupo As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Grupo", Id_Grupo)
    End Function

    Public Shared Function CargarPorId_Regional(ByVal Id_Regional As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Regional", Id_Regional)
    End Function

    Public Shared Function CargarPorId_Atender(ByVal Id_Atender As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Atender", Id_Atender)
    End Function

    Public Shared Function CargarPorId_Motivo_Noatender(ByVal Id_Motivo_Noatender As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Motivo_Noatender", Id_Motivo_Noatender)
    End Function

    Public Shared Function CargarPorId_Como_Brindar_Atencion(ByVal Id_Como_Brindar_Atencion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Como_Brindar_Atencion", Id_Como_Brindar_Atencion)
    End Function

    Public Shared Function CargarPorId_Como_Fue_Atencion(ByVal Id_Como_Fue_Atencion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Como_Fue_Atencion", Id_Como_Fue_Atencion)
    End Function

    Public Shared Function CargarPorId_Cuantas_Habitaciones(ByVal Id_Cuantas_Habitaciones As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Cuantas_Habitaciones", Id_Cuantas_Habitaciones)
    End Function

    Public Shared Function CargarPorId_Cuantas_Personas_Habitacion(ByVal Id_Cuantas_Personas_Habitacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Cuantas_Personas_Habitacion", Id_Cuantas_Personas_Habitacion)
    End Function

    Public Shared Function CargarPorId_Cuantas_Personas_Vivienda(ByVal Id_Cuantas_Personas_Vivienda As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Cuantas_Personas_Vivienda", Id_Cuantas_Personas_Vivienda)
    End Function

    Public Shared Function CargarPorId_Cuanto_Tiempo_Demoro(ByVal Id_Cuanto_Tiempo_Demoro As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Cuanto_Tiempo_Demoro", Id_Cuanto_Tiempo_Demoro)
    End Function

    Public Shared Function CargarPorId_Cuantos_Desplazamientos(ByVal Id_Cuantos_Desplazamientos As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Cuantos_Desplazamientos", Id_Cuantos_Desplazamientos)
    End Function

    Public Shared Function CargarPorId_Departamento_Expulsor(ByVal Id_Departamento_Expulsor As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Departamento_Expulsor", Id_Departamento_Expulsor)
    End Function

    Public Shared Function CargarPorId_Despues_Hijos_617(ByVal Id_Despues_Hijos_617 As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Despues_Hijos_617", Id_Despues_Hijos_617)
    End Function

    Public Shared Function CargarPorId_Entidad_Inicial_Atencion(ByVal Id_Entidad_Inicial_Atencion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Entidad_Inicial_Atencion", Id_Entidad_Inicial_Atencion)
    End Function

    Public Shared Function CargarPorId_Forma_Declaracion(ByVal Id_Forma_Declaracion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Forma_Declaracion", Id_Forma_Declaracion)
    End Function

    Public Shared Function CargarPorId_Materiales_Vivienda(ByVal Id_Materiales_Vivienda As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Materiales_Vivienda", Id_Materiales_Vivienda)
    End Function

    Public Shared Function CargarPorId_Motivo_Demora(ByVal Id_Motivo_Demora As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Motivo_Demora", Id_Motivo_Demora)
    End Function

    Public Shared Function CargarPorId_Motivo_Desplazamiento(ByVal Id_Motivo_Desplazamiento As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Motivo_Desplazamiento", Id_Motivo_Desplazamiento)
    End Function

    Public Shared Function CargarPorId_Motivo_NoDeclaro_Municipio(ByVal Id_Motivo_NoDeclaro_Municipio As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Motivo_NoDeclaro_Municipio", Id_Motivo_NoDeclaro_Municipio)
    End Function

    Public Shared Function CargarPorId_Porque_No_Reporto(ByVal Id_Porque_No_Reporto As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Porque_No_Reporto", Id_Porque_No_Reporto)
    End Function

    Public Shared Function CargarPorId_Recibio_Ayuda_Entidad_Inicial(ByVal Id_Recibio_Ayuda_Entidad_Inicial As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Recibio_Ayuda_Entidad_Inicial", Id_Recibio_Ayuda_Entidad_Inicial)
    End Function

    Public Shared Function CargarPorId_Tiempo_Casco_Urbano(ByVal Id_Tiempo_Casco_Urbano As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Tiempo_Casco_Urbano", Id_Tiempo_Casco_Urbano)
    End Function

    Public Shared Function CargarPorId_Tipo_Tenencia_Vivienda(ByVal Id_Tipo_Tenencia_Vivienda As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Tipo_Tenencia_Vivienda", Id_Tipo_Tenencia_Vivienda)
    End Function

    Public Shared Function CargarPorId_Vivio_Cabezera_Municipal(ByVal Id_Vivio_Cabezera_Municipal As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Vivio_Cabezera_Municipal", Id_Vivio_Cabezera_Municipal)
    End Function

    Public Shared Function CargarPorId_Despues_Afiliado_Regimen_Contributivo(ByVal Id_Despues_Afiliado_Regimen_Contributivo As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Despues_Afiliado_Regimen_Contributivo", Id_Despues_Afiliado_Regimen_Contributivo)
    End Function

    Public Shared Function CargarPorId_Despues_Afiliado_Regimen_Subsidiado(ByVal Id_Despues_Afiliado_Regimen_Subsidiado As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Despues_Afiliado_Regimen_Subsidiado", Id_Despues_Afiliado_Regimen_Subsidiado)
    End Function

    Public Shared Function CargarPorId_Despues_Afiliado_Sisben(ByVal Id_Despues_Afiliado_Sisben As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Despues_Afiliado_Sisben", Id_Despues_Afiliado_Sisben)
    End Function

    Public Shared Function CargarPorId_Destino_Tierra(ByVal Id_Destino_Tierra As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Destino_Tierra", Id_Destino_Tierra)
    End Function

    Public Shared Function CargarPorId_Documento_Propiedad(ByVal Id_Documento_Propiedad As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Documento_Propiedad", Id_Documento_Propiedad)
    End Function

    Public Shared Function CargarPorId_Situacion_Actual_Tierras(ByVal Id_Situacion_Actual_Tierras As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Situacion_Actual_Tierras", Id_Situacion_Actual_Tierras)
    End Function

    Public Shared Function CargarPorId_Tipo_Bien_Rural(ByVal Id_Tipo_Bien_Rural As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Tipo_Bien_Rural", Id_Tipo_Bien_Rural)
    End Function

    Public Shared Function CargarPorid_ley_reparacion(ByVal id_ley_reparacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorid_ley_reparacion", id_ley_reparacion)
    End Function

    Public Shared Function CargarPorId_Es_Del_Municipio(ByVal Id_Es_Del_Municipio As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Es_Del_Municipio", Id_Es_Del_Municipio)
    End Function

    Public Shared Function CargarPorId_Tipo_Familia_desplazada(ByVal Id_Tipo_Familia_desplazada As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Tipo_Familia_desplazada", Id_Tipo_Familia_desplazada)
    End Function

    Public Shared Function CargarPorId_Vulnerables_NoDesplazada(ByVal Id_Vulnerables_NoDesplazada As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Vulnerables_NoDesplazada", Id_Vulnerables_NoDesplazada)
    End Function

    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Usuario_Creacion", Id_Usuario_Creacion)
    End Function

    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Usuario_Modificacion", Id_Usuario_Modificacion)
    End Function

    Public Shared Function CargarPorId_Solicito_Ayuda(ByVal Id_Solicito_Ayuda As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Solicito_Ayuda", Id_Solicito_Ayuda)
    End Function

    Public Shared Function CargarPorId_Concejo_Expulsor(ByVal Id_Concejo_Expulsor As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Concejo_Expulsor", Id_Concejo_Expulsor)
    End Function

    Public Shared Function CargarPorId_Lugar_Fuente(ByVal Id_Lugar_Fuente As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Lugar_Fuente", Id_Lugar_Fuente)
    End Function

    Public Shared Function CargarPorId_EnLinea(ByVal Id_Enlinea As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_EnLinea", Id_Enlinea)
    End Function

    Public Shared Function CargarPorId_Agua_Potable(ByVal Id_Agua_Potable As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Agua_Potable", Id_Agua_Potable)
    End Function

    Public Shared Function CargarPorId_Tiene_documento(ByVal Id_Tiene_documento As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Agua_Potable", Id_Tiene_documento)
    End Function

    Public Shared Function CargarporBusqueda(ByVal grupo As Integer, ByVal identificacion As String, ByVal nombre As String, ByVal regional As Integer, ByVal Fecha_Inicial_Radicacion As String, ByVal Fecha_Final_Radicacion As String, ByVal Fecha_Inicial_Entrega As String, ByVal Fecha_Final_Entrega As String, ByVal Fuente As Int32, ByVal fecha_inicial_programacion As String, ByVal fecha_final_programacion As String, ByVal horario As String, ByVal declarante As Int32, ByVal lugar As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarBusqueda", isNothingToDBNull(grupo), isNothingToDBNull(identificacion), isNothingToDBNull(nombre), isNothingToDBNull(regional), isNothingToDBNull(Fecha_Inicial_Radicacion), isNothingToDBNull(Fecha_Final_Radicacion), isNothingToDBNull(Fecha_Inicial_Entrega), isNothingToDBNull(Fecha_Final_Entrega), isNothingToDBNull(Fuente), isNothingToDBNull(fecha_inicial_programacion), isNothingToDBNull(fecha_final_programacion), isNothingToDBNull(horario), isNothingToDBNull(declarante), isNothingToDBNull(lugar))
    End Function

    Public Shared Function CargarBusquedaDeclaraciones(ByVal id_programa As Int32, ByVal grupo As Integer, ByVal identificacion As String, ByVal nombre As String, ByVal regional As Integer, ByVal Fecha_Inicial_Radicacion As String, ByVal Fecha_Final_Radicacion As String, ByVal Fecha_Inicial_Entrega As String, ByVal Fecha_Final_Entrega As String, ByVal Fuente As Int32, ByVal fecha_inicial_declaracion As String, ByVal fecha_final_declaracion As String, ByVal horario As String, ByVal declarante As Int32, ByVal lugar As Int32, ByVal tiporeporte As String) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarBusquedaDeclarantes", isNothingToDBNull(id_programa), isNothingToDBNull(grupo), isNothingToDBNull(identificacion), isNothingToDBNull(nombre), isNothingToDBNull(regional), isNothingToDBNull(Fecha_Inicial_Radicacion), isNothingToDBNull(Fecha_Final_Radicacion), isNothingToDBNull(Fecha_Inicial_Entrega), isNothingToDBNull(Fecha_Final_Entrega), isNothingToDBNull(Fuente), isNothingToDBNull(fecha_inicial_declaracion), isNothingToDBNull(fecha_final_declaracion), isNothingToDBNull(horario), isNothingToDBNull(declarante), isNothingToDBNull(lugar), isNothingToDBNull(tiporeporte))
    End Function

    Public Shared Function CargarporBusquedaAsignacion(ByVal identificacion As String, ByVal nombre As String, ByVal regional As Integer, ByVal Fecha_Inicial_Radicacion As String, ByVal Fecha_Final_Radicacion As String, ByVal Fuente As Int32, ByVal horario As String, ByVal declarante As Int32, ByVal lugar As Int32, ByVal Id_programa As Int32, ByVal pendiente As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarBusquedaAsignacion", isNothingToDBNull(identificacion), isNothingToDBNull(nombre), isNothingToDBNull(regional), isNothingToDBNull(Fecha_Inicial_Radicacion), isNothingToDBNull(Fecha_Final_Radicacion), isNothingToDBNull(Fuente), isNothingToDBNull(horario), isNothingToDBNull(declarante), isNothingToDBNull(lugar), isNothingToDBNull(Id_programa), isNothingToDBNull(pendiente))
    End Function

    Public Shared Sub CargarBusquedaPsicosocial(ByVal Usuario As Integer, ByVal grupo As Integer, ByVal identificacion As String, ByVal nombre As String, ByVal regional As Integer, ByVal Fecha_Inicial_Radicacion As String, ByVal Fecha_Final_Radicacion As String, ByVal Fecha_Inicial_Entrega As String, ByVal Fecha_Final_Entrega As String, ByVal Fuente As Int32, ByVal fecha_inicial_declaracion As String, ByVal fecha_final_declaracion As String, ByVal horario As String, ByVal declarante As Int32, ByVal lugar As Int32)

        Dim cnn As New System.Data.SqlClient.SqlConnection(strCadenaConexion)
        Dim cmd As System.Data.SqlClient.SqlCommand
        cmd = New System.Data.SqlClient.SqlCommand()
        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.CommandText = "dbo.DeclaracionConsultaPsicosocial"

        cmd.Parameters.Add("@Id_Usuario", Data.SqlDbType.Int, 20).Value = Usuario
        cmd.Parameters.Add("@Grupo", Data.SqlDbType.Int, 20).Value = isNothingToDBNull(grupo)
        cmd.Parameters.Add("@Identificacion", Data.SqlDbType.NVarChar, 50).Value = isNothingToDBNull(identificacion)
        cmd.Parameters.Add("@Nombre", Data.SqlDbType.NVarChar, 50).Value = isNothingToDBNull(nombre)
        cmd.Parameters.Add("@Regional", Data.SqlDbType.Int, 20).Value = isNothingToDBNull(regional)
        cmd.Parameters.Add("@Fecha_Inicial_Radicacion", Data.SqlDbType.NVarChar, 11).Value = isNothingToDBNull(Fecha_Inicial_Radicacion)
        cmd.Parameters.Add("@Fecha_Final_Radicacion", Data.SqlDbType.NVarChar, 11).Value = isNothingToDBNull(Fecha_Final_Radicacion)
        cmd.Parameters.Add("@Fecha_Inicial_Entrega", Data.SqlDbType.NVarChar, 11).Value = isNothingToDBNull(Fecha_Inicial_Entrega)
        cmd.Parameters.Add("@Fecha_Final_Entrega", Data.SqlDbType.NVarChar, 11).Value = isNothingToDBNull(Fecha_Final_Entrega)
        cmd.Parameters.Add("@Fuente", Data.SqlDbType.Int, 20).Value = isNothingToDBNull(Fuente)
        cmd.Parameters.Add("@Fecha_Inicial_Declaracion", Data.SqlDbType.NVarChar, 11).Value = isNothingToDBNull(fecha_inicial_declaracion)
        cmd.Parameters.Add("@Fecha_Final_Declaracion", Data.SqlDbType.NVarChar, 11).Value = isNothingToDBNull(fecha_final_declaracion)
        cmd.Parameters.Add("@Horario", Data.SqlDbType.NVarChar, 2).Value = isNothingToDBNull(horario)
        cmd.Parameters.Add("@Declarante", Data.SqlDbType.Int, 20).Value = isNothingToDBNull(declarante)
        cmd.Parameters.Add("@Lugar", Data.SqlDbType.Int, 20).Value = isNothingToDBNull(lugar)
        cmd.CommandTimeout = TiempoConexion

        cmd.ExecuteNonQuery()
        cnn.Close()

        ''SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.DeclaracionConsultaPsicosocial", isNothingToDBNull(Usuario), isNothingToDBNull(grupo), isNothingToDBNull(identificacion), isNothingToDBNull(nombre), isNothingToDBNull(regional), isNothingToDBNull(Fecha_Inicial_Radicacion), isNothingToDBNull(Fecha_Final_Radicacion), isNothingToDBNull(Fecha_Inicial_Entrega), isNothingToDBNull(Fecha_Final_Entrega), isNothingToDBNull(Fuente), isNothingToDBNull(fecha_inicial_declaracion), isNothingToDBNull(fecha_final_declaracion), isNothingToDBNull(horario), isNothingToDBNull(declarante), isNothingToDBNull(lugar))
    End Sub

    Public Shared Function CargarporIndicadores(ByVal id_Lugar_entrega As Int32, ByVal trimestrales As String, ByVal regionales As String, ByVal entregas As String, ByVal grupos As String, _
    ByVal fechadeclaracioninicial As String, ByVal fechadeclaracionfinal As String, ByVal fechadesplazamientoinicial As String, ByVal fechadesplazamientofinal As String, ByVal fechaatencioninicial As String, _
    ByVal fechaatencionfinal As String, ByVal accionsocial As Integer, ByVal atendido As Integer, ByVal motivonoatencion As Integer, ByVal departamento As Integer, ByVal municipio As Integer, ByVal concejo As Integer, _
    ByVal wfecha_radicacion_inicial As String, ByVal wfecha_radicacion_final As String) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorIndicadores", isNothingToDBNull(id_Lugar_entrega), isNothingToDBNull(trimestrales), isNothingToDBNull(regionales), isNothingToDBNull(entregas), isNothingToDBNull(grupos), isNothingToDBNull(fechadeclaracioninicial), isNothingToDBNull(fechadeclaracionfinal), isNothingToDBNull(fechadesplazamientoinicial), isNothingToDBNull(fechadesplazamientofinal), _
                    isNothingToDBNull(fechaatencioninicial), isNothingToDBNull(fechaatencionfinal), isNothingToDBNull(accionsocial), isNothingToDBNull(atendido), isNothingToDBNull(motivonoatencion), isNothingToDBNull(departamento), isNothingToDBNull(municipio), isNothingToDBNull(concejo), isNothingToDBNull(wfecha_radicacion_inicial), isNothingToDBNull(wfecha_radicacion_final))
    End Function

    Public Shared Function CargarPorId_Tipo_Familia_No_Desplazada(ByVal Id_Tipo_Familia_No_Desplazada As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Tipo_Familia_No_Desplazada", Id_Tipo_Familia_No_Desplazada)
    End Function

    Public Shared Function CargarporBusquedaEstados(ByVal regional As Integer, ByVal declarante As Int32, ByVal Fecha_Inicial_Radicacion As String, ByVal Fecha_Final_Radicacion As String, ByVal fecha_inicial_declaracion As String, ByVal fecha_final_declaracion As String, ByVal Id_LugarEntrega As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarBusquedaEstados", isNothingToDBNull(regional), isNothingToDBNull(declarante), isNothingToDBNull(Fecha_Inicial_Radicacion), isNothingToDBNull(Fecha_Final_Radicacion), isNothingToDBNull(fecha_inicial_declaracion), isNothingToDBNull(fecha_final_declaracion), isNothingToDBNull(Id_LugarEntrega))
    End Function

    Public Shared Function CargarPorNumero_Declaracion(ByVal Numero_Declaracion As String) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorNumero_Declaracion", Numero_Declaracion)
    End Function

    Public Shared Function CargarPorId_Afectado_Desplazamiento(ByVal Id_Afectado_Desplazamiento As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Afectado_Desplazamiento", Id_Afectado_Desplazamiento)
    End Function

    Public Shared Function CargarPorId_Familias_Accion(ByVal Id_Familias_Accion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Familias_Accion", Id_Familias_Accion)
    End Function

    Public Shared Function CargarPorId_Ha_Muerto_Despues(ByVal Id_Ha_Muerto_Despues As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Ha_Muerto_Despues", Id_Ha_Muerto_Despues)
    End Function

    Public Shared Function CargarPorId_Red_Unidos(ByVal Id_Red_Unidos As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Red_Unidos", Id_Red_Unidos)
    End Function

    Public Shared Function CargarPorId_Solicito_Atencion_Psicologica(ByVal Id_Solicito_Atencion_Psicologica As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Solicito_Atencion_Psicologica", Id_Solicito_Atencion_Psicologica)
    End Function

    Public Shared Function CargarPorId_VBG_general(ByVal Id_VBG_general As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_VBG_general", Id_VBG_general)
    End Function

    Public Shared Function CargarPorId_Emociones(ByVal Id_Emociones As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Emociones", Id_Emociones)
    End Function

    Public Shared Function CargarPorId_Tipo_Adiccion(ByVal Id_Tipo_Adiccion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Tipo_Adiccion", Id_Tipo_Adiccion)
    End Function

    Public Shared Function CargarPorId_Adiccion_Alcohol(ByVal Id_Adiccion_Alcohol As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Adiccion_Alcohol", Id_Adiccion_Alcohol)
    End Function

    Public Shared Function CargarPorId_Adiccion_Droga(ByVal Id_Adiccion_Droga As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.DeclaracionConsultarPorId_Adiccion_Droga", Id_Adiccion_Droga)
    End Function

    Public Shared Function CargarPorReprogramaciones(ByVal Id_Regional As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.ConsultaReprogramaciones", Id_Regional)
    End Function

    Public Shared Function cargarbasemiranda() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.BaseMirandaCargar")
    End Function

    Public Shared Sub ActualizarBaseMiranda(ByVal documento As Double, ByVal Estado As String, ByVal Fecha As DateTime)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.BaseMirandaActualizar", documento, isNothingToDBNull(Estado), isNothingToDBNull(Fecha))
    End Sub


End Class

