﻿Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Tmp_SaludDAL

    Public Shared Function Insertar(ByVal Id_Usuario As Int32, ByVal DescripcionGrupo As String, ByVal Declarante As String, ByVal Tipo_Identificacion As String, ByVal Identificacion As String, ByVal Edad As Int32, ByVal Nombre_Completo As String, ByVal Genero As String, ByVal Fecha_Nacimiento As DateTime, ByVal Nombre_Declarante As String, ByVal Identificacion_Declarante As String, ByVal Id_Persona As Int32, ByVal CYD As String, ByVal Patologia As String, ByVal Lactando As String, ByVal Lactancia_Meses As Int32, ByVal Lactancia_exclusiva As Int32, ByVal Desparasitacion As String, ByVal Suplementacion As String, ByVal Carnet As String, ByVal Motivo_NoCarnet As String, ByVal Vacunacion As String, ByVal Motivo_No_VacunacionCompleta As String, ByVal Vacunados As String, ByVal MotivoNoVacunados As String, ByVal Fecha_Esquema_Vacunacion As DateTime, ByVal Observaciones_Salud As String, ByVal Fecha_Valoracion01 As DateTime, ByVal AntropometriaPeso01 As Double, ByVal AntropometriaTalla01 As Double, ByVal Antropometia_Perimetro_Branquial01 As Double, ByVal Recuperado01 As Double, ByVal Observaciones01 As String, ByVal PesoTalla01 As String, ByVal PesoEdad01 As String, ByVal TallaLongitud01 As String, ByVal IMC_Edad01 As String, ByVal Edad01 As Int32, ByVal Meses01 As Int32, ByVal TallaParaEdad01 As String, ByVal EstadoNutricional01 As String, ByVal Fecha_Valoracion02 As DateTime, ByVal AntropometriaPeso02 As Double, ByVal AntropometriaTalla02 As Double, ByVal Antropometia_Perimetro_Branquial02 As Double, ByVal Recuperado02 As Double, ByVal Observaciones02 As String, ByVal PesoTalla02 As String, ByVal PesoEdad02 As String, ByVal TallaLongitud02 As String, ByVal IMC_Edad02 As String, ByVal Edad02 As Int32, ByVal Meses02 As Int32, ByVal TallaParaEdad02 As String, ByVal EstadoNutricional02 As String, ByVal Fecha_Valoracion03 As DateTime, ByVal AntropometriaPeso03 As Double, ByVal AntropometriaTalla03 As Double, ByVal Antropometia_Perimetro_Branquial03 As Double, ByVal Recuperado03 As Double, ByVal Observaciones03 As String, ByVal PesoTalla03 As String, ByVal PesoEdad03 As String, ByVal TallaLongitud03 As String, ByVal IMC_Edad03 As String, ByVal Edad03 As Int32, ByVal Meses03 As Int32, ByVal TallaParaEdad03 As String, ByVal EstadoNutricional03 As String, ByVal Fecha_ValoracionSeg As DateTime, ByVal AntropometriaPesoSeg As Double, ByVal AntropometriaTallaSeg As Double, ByVal Antropometia_Perimetro_BranquialSeg As Double, ByVal RecuperadoSeg As Double, ByVal ObservacionesSeg As String, ByVal PesoTallaSeg As String, ByVal PesoEdadSeg As String, ByVal TallaLongitudSeg As String, ByVal IMC_EdadSeg As String, ByVal EdadSeg As Int32, ByVal MesesSeg As Int32, ByVal TallaParaEdadSeg As String, ByVal EstadoNutricionalSeg As String, ByVal FechaRemision01 As DateTime, ByVal FechaRealizado01 As DateTime, ByVal EntidadRemision01 As String, ByVal ServicioRemision01 As String, ByVal FechaRemision02 As DateTime, ByVal FechaRealizado02 As DateTime, ByVal EntidadRemision02 As String, ByVal ServicioRemision02 As String, ByVal FechaRemision03 As DateTime, ByVal FechaRealizado03 As DateTime, ByVal EntidadRemision03 As String, ByVal ServicioRemision03 As String) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Tmp_SaludInsertar", isNothingToDBNull(Id_Usuario), isNothingToDBNull(DescripcionGrupo), isNothingToDBNull(Declarante), isNothingToDBNull(Tipo_Identificacion), isNothingToDBNull(Identificacion), isNothingToDBNull(Edad), isNothingToDBNull(Nombre_Completo), isNothingToDBNull(Genero), isNothingToDBNull(Fecha_Nacimiento), isNothingToDBNull(Nombre_Declarante), isNothingToDBNull(Identificacion_Declarante), isNothingToDBNull(Id_Persona), isNothingToDBNull(CYD), isNothingToDBNull(Patologia), isNothingToDBNull(Lactando), isNothingToDBNull(Lactancia_Meses), isNothingToDBNull(Lactancia_exclusiva), isNothingToDBNull(Desparasitacion), isNothingToDBNull(Suplementacion), isNothingToDBNull(Carnet), isNothingToDBNull(Motivo_NoCarnet), isNothingToDBNull(Vacunacion), isNothingToDBNull(Motivo_No_VacunacionCompleta), isNothingToDBNull(Vacunados), isNothingToDBNull(MotivoNoVacunados), isNothingToDBNull(Fecha_Esquema_Vacunacion), isNothingToDBNull(Observaciones_Salud), isNothingToDBNull(Fecha_Valoracion01), isNothingToDBNull(AntropometriaPeso01), isNothingToDBNull(AntropometriaTalla01), isNothingToDBNull(Antropometia_Perimetro_Branquial01), isNothingToDBNull(Recuperado01), isNothingToDBNull(Observaciones01), isNothingToDBNull(PesoTalla01), isNothingToDBNull(PesoEdad01), isNothingToDBNull(TallaLongitud01), isNothingToDBNull(IMC_Edad01), isNothingToDBNull(Edad01), isNothingToDBNull(Meses01), isNothingToDBNull(TallaParaEdad01), isNothingToDBNull(EstadoNutricional01), isNothingToDBNull(Fecha_Valoracion02), isNothingToDBNull(AntropometriaPeso02), isNothingToDBNull(AntropometriaTalla02), isNothingToDBNull(Antropometia_Perimetro_Branquial02), isNothingToDBNull(Recuperado02), isNothingToDBNull(Observaciones02), isNothingToDBNull(PesoTalla02), isNothingToDBNull(PesoEdad02), isNothingToDBNull(TallaLongitud02), isNothingToDBNull(IMC_Edad02), isNothingToDBNull(Edad02), isNothingToDBNull(Meses02), isNothingToDBNull(TallaParaEdad02), isNothingToDBNull(EstadoNutricional02), isNothingToDBNull(Fecha_Valoracion03), isNothingToDBNull(AntropometriaPeso03), isNothingToDBNull(AntropometriaTalla03), isNothingToDBNull(Antropometia_Perimetro_Branquial03), isNothingToDBNull(Recuperado03), isNothingToDBNull(Observaciones03), isNothingToDBNull(PesoTalla03), isNothingToDBNull(PesoEdad03), isNothingToDBNull(TallaLongitud03), isNothingToDBNull(IMC_Edad03), isNothingToDBNull(Edad03), isNothingToDBNull(Meses03), isNothingToDBNull(TallaParaEdad03), isNothingToDBNull(EstadoNutricional03), isNothingToDBNull(Fecha_ValoracionSeg), isNothingToDBNull(AntropometriaPesoSeg), isNothingToDBNull(AntropometriaTallaSeg), isNothingToDBNull(Antropometia_Perimetro_BranquialSeg), isNothingToDBNull(RecuperadoSeg), isNothingToDBNull(ObservacionesSeg), isNothingToDBNull(PesoTallaSeg), isNothingToDBNull(PesoEdadSeg), isNothingToDBNull(TallaLongitudSeg), isNothingToDBNull(IMC_EdadSeg), isNothingToDBNull(EdadSeg), isNothingToDBNull(MesesSeg), isNothingToDBNull(TallaParaEdadSeg), isNothingToDBNull(EstadoNutricionalSeg), isNothingToDBNull(FechaRemision01), isNothingToDBNull(FechaRealizado01), isNothingToDBNull(EntidadRemision01), isNothingToDBNull(ServicioRemision01), isNothingToDBNull(FechaRemision02), isNothingToDBNull(FechaRealizado02), isNothingToDBNull(EntidadRemision02), isNothingToDBNull(ServicioRemision02), isNothingToDBNull(FechaRemision03), isNothingToDBNull(FechaRealizado03), isNothingToDBNull(EntidadRemision03), isNothingToDBNull(ServicioRemision03))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Usuario As Int32, ByVal DescripcionGrupo As String, ByVal Declarante As String, ByVal Tipo_Identificacion As String, ByVal Identificacion As String, ByVal Edad As Int32, ByVal Nombre_Completo As String, ByVal Genero As String, ByVal Fecha_Nacimiento As DateTime, ByVal Nombre_Declarante As String, ByVal Identificacion_Declarante As String, ByVal Id_Persona As Int32, ByVal CYD As String, ByVal Patologia As String, ByVal Lactando As String, ByVal Lactancia_Meses As Int32, ByVal Lactancia_exclusiva As Int32, ByVal Desparasitacion As String, ByVal Suplementacion As String, ByVal Carnet As String, ByVal Motivo_NoCarnet As String, ByVal Vacunacion As String, ByVal Motivo_No_VacunacionCompleta As String, ByVal Vacunados As String, ByVal MotivoNoVacunados As String, ByVal Fecha_Esquema_Vacunacion As DateTime, ByVal Observaciones_Salud As String, ByVal Fecha_Valoracion01 As DateTime, ByVal AntropometriaPeso01 As Double, ByVal AntropometriaTalla01 As Double, ByVal Antropometia_Perimetro_Branquial01 As Double, ByVal Recuperado01 As Double, ByVal Observaciones01 As String, ByVal PesoTalla01 As String, ByVal PesoEdad01 As String, ByVal TallaLongitud01 As String, ByVal IMC_Edad01 As String, ByVal Edad01 As Int32, ByVal Meses01 As Int32, ByVal TallaParaEdad01 As String, ByVal EstadoNutricional01 As String, ByVal Fecha_Valoracion02 As DateTime, ByVal AntropometriaPeso02 As Double, ByVal AntropometriaTalla02 As Double, ByVal Antropometia_Perimetro_Branquial02 As Double, ByVal Recuperado02 As Double, ByVal Observaciones02 As String, ByVal PesoTalla02 As String, ByVal PesoEdad02 As String, ByVal TallaLongitud02 As String, ByVal IMC_Edad02 As String, ByVal Edad02 As Int32, ByVal Meses02 As Int32, ByVal TallaParaEdad02 As String, ByVal EstadoNutricional02 As String, ByVal Fecha_Valoracion03 As DateTime, ByVal AntropometriaPeso03 As Double, ByVal AntropometriaTalla03 As Double, ByVal Antropometia_Perimetro_Branquial03 As Double, ByVal Recuperado03 As Double, ByVal Observaciones03 As String, ByVal PesoTalla03 As String, ByVal PesoEdad03 As String, ByVal TallaLongitud03 As String, ByVal IMC_Edad03 As String, ByVal Edad03 As Int32, ByVal Meses03 As Int32, ByVal TallaParaEdad03 As String, ByVal EstadoNutricional03 As String, ByVal Fecha_ValoracionSeg As DateTime, ByVal AntropometriaPesoSeg As Double, ByVal AntropometriaTallaSeg As Double, ByVal Antropometia_Perimetro_BranquialSeg As Double, ByVal RecuperadoSeg As Double, ByVal ObservacionesSeg As String, ByVal PesoTallaSeg As String, ByVal PesoEdadSeg As String, ByVal TallaLongitudSeg As String, ByVal IMC_EdadSeg As String, ByVal EdadSeg As Int32, ByVal MesesSeg As Int32, ByVal TallaParaEdadSeg As String, ByVal EstadoNutricionalSeg As String, ByVal FechaRemision01 As DateTime, ByVal FechaRealizado01 As DateTime, ByVal EntidadRemision01 As String, ByVal ServicioRemision01 As String, ByVal FechaRemision02 As DateTime, ByVal FechaRealizado02 As DateTime, ByVal EntidadRemision02 As String, ByVal ServicioRemision02 As String, ByVal FechaRemision03 As DateTime, ByVal FechaRealizado03 As DateTime, ByVal EntidadRemision03 As String, ByVal ServicioRemision03 As String)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Tmp_SaludActualizar", Id, isNothingToDBNull(Id_Usuario), isNothingToDBNull(DescripcionGrupo), isNothingToDBNull(Declarante), isNothingToDBNull(Tipo_Identificacion), isNothingToDBNull(Identificacion), isNothingToDBNull(Edad), isNothingToDBNull(Nombre_Completo), isNothingToDBNull(Genero), isNothingToDBNull(Fecha_Nacimiento), isNothingToDBNull(Nombre_Declarante), isNothingToDBNull(Identificacion_Declarante), isNothingToDBNull(Id_Persona), isNothingToDBNull(CYD), isNothingToDBNull(Patologia), isNothingToDBNull(Lactando), isNothingToDBNull(Lactancia_Meses), isNothingToDBNull(Lactancia_exclusiva), isNothingToDBNull(Desparasitacion), isNothingToDBNull(Suplementacion), isNothingToDBNull(Carnet), isNothingToDBNull(Motivo_NoCarnet), isNothingToDBNull(Vacunacion), isNothingToDBNull(Motivo_No_VacunacionCompleta), isNothingToDBNull(Vacunados), isNothingToDBNull(MotivoNoVacunados), isNothingToDBNull(Fecha_Esquema_Vacunacion), isNothingToDBNull(Observaciones_Salud), isNothingToDBNull(Fecha_Valoracion01), isNothingToDBNull(AntropometriaPeso01), isNothingToDBNull(AntropometriaTalla01), isNothingToDBNull(Antropometia_Perimetro_Branquial01), isNothingToDBNull(Recuperado01), isNothingToDBNull(Observaciones01), isNothingToDBNull(PesoTalla01), isNothingToDBNull(PesoEdad01), isNothingToDBNull(TallaLongitud01), isNothingToDBNull(IMC_Edad01), isNothingToDBNull(Edad01), isNothingToDBNull(Meses01), isNothingToDBNull(TallaParaEdad01), isNothingToDBNull(EstadoNutricional01), isNothingToDBNull(Fecha_Valoracion02), isNothingToDBNull(AntropometriaPeso02), isNothingToDBNull(AntropometriaTalla02), isNothingToDBNull(Antropometia_Perimetro_Branquial02), isNothingToDBNull(Recuperado02), isNothingToDBNull(Observaciones02), isNothingToDBNull(PesoTalla02), isNothingToDBNull(PesoEdad02), isNothingToDBNull(TallaLongitud02), isNothingToDBNull(IMC_Edad02), isNothingToDBNull(Edad02), isNothingToDBNull(Meses02), isNothingToDBNull(TallaParaEdad02), isNothingToDBNull(EstadoNutricional02), isNothingToDBNull(Fecha_Valoracion03), isNothingToDBNull(AntropometriaPeso03), isNothingToDBNull(AntropometriaTalla03), isNothingToDBNull(Antropometia_Perimetro_Branquial03), isNothingToDBNull(Recuperado03), isNothingToDBNull(Observaciones03), isNothingToDBNull(PesoTalla03), isNothingToDBNull(PesoEdad03), isNothingToDBNull(TallaLongitud03), isNothingToDBNull(IMC_Edad03), isNothingToDBNull(Edad03), isNothingToDBNull(Meses03), isNothingToDBNull(TallaParaEdad03), isNothingToDBNull(EstadoNutricional03), isNothingToDBNull(Fecha_ValoracionSeg), isNothingToDBNull(AntropometriaPesoSeg), isNothingToDBNull(AntropometriaTallaSeg), isNothingToDBNull(Antropometia_Perimetro_BranquialSeg), isNothingToDBNull(RecuperadoSeg), isNothingToDBNull(ObservacionesSeg), isNothingToDBNull(PesoTallaSeg), isNothingToDBNull(PesoEdadSeg), isNothingToDBNull(TallaLongitudSeg), isNothingToDBNull(IMC_EdadSeg), isNothingToDBNull(EdadSeg), isNothingToDBNull(MesesSeg), isNothingToDBNull(TallaParaEdadSeg), isNothingToDBNull(EstadoNutricionalSeg), isNothingToDBNull(FechaRemision01), isNothingToDBNull(FechaRealizado01), isNothingToDBNull(EntidadRemision01), isNothingToDBNull(ServicioRemision01), isNothingToDBNull(FechaRemision02), isNothingToDBNull(FechaRealizado02), isNothingToDBNull(EntidadRemision02), isNothingToDBNull(ServicioRemision02), isNothingToDBNull(FechaRemision03), isNothingToDBNull(FechaRealizado03), isNothingToDBNull(EntidadRemision03), isNothingToDBNull(ServicioRemision03))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Tmp_SaludEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Tmp_SaludConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Tmp_SaludConsultarPorID", Id)
    End Function

    Public Shared Function CargarPorId_Usuario(ByVal Id_Usuario As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Tmp_SaludConsultarPorId_Usuario", Id_Usuario)
    End Function

    Public Shared Sub CargarSalud(ByVal id_usuario As Int32, ByVal grupo As String, ByVal identificacion As String, ByVal nombre As String, ByVal regional As Integer, ByVal fecha_inicial As String, ByVal fecha_final As String, ByVal Tipo_Declaracion As Integer, ByVal Id_LugarEntrega As Int32, ByVal id_programa As Int32)
        Dim cnn As New System.Data.SqlClient.SqlConnection(strCadenaConexion)
        Dim cmd As System.Data.SqlClient.SqlCommand
        cmd = New System.Data.SqlClient.SqlCommand()
        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.CommandText = "dbo.CargarSalud"

        cmd.Parameters.Add("@id_usuario", Data.SqlDbType.Int, 20).Value = id_usuario
        cmd.Parameters.Add("@grupo", Data.SqlDbType.NVarChar, 400).Value = isNothingToDBNull(grupo)
        cmd.Parameters.Add("@identificacion", Data.SqlDbType.NVarChar, 50).Value = isNothingToDBNull(identificacion)
        cmd.Parameters.Add("@nombre", Data.SqlDbType.NVarChar, 400).Value = isNothingToDBNull(nombre)
        cmd.Parameters.Add("@regional", Data.SqlDbType.Int, 20).Value = isNothingToDBNull(regional)
        cmd.Parameters.Add("@fecha_inicial", Data.SqlDbType.NVarChar, 11).Value = isNothingToDBNull(fecha_inicial)
        cmd.Parameters.Add("@fecha_final", Data.SqlDbType.NVarChar, 11).Value = isNothingToDBNull(fecha_final)
        cmd.Parameters.Add("@Tipo_Declaracion", Data.SqlDbType.Int, 20).Value = isNothingToDBNull(Tipo_Declaracion)

        cmd.Parameters.Add("@Id_LugarEntrega", Data.SqlDbType.Int, 20).Value = isNothingToDBNull(Id_LugarEntrega)
        cmd.Parameters.Add("@Id_Programa", Data.SqlDbType.Int, 20).Value = isNothingToDBNull(id_programa)
        cmd.CommandTimeout = TiempoConexion

        cmd.ExecuteNonQuery()
        cnn.Close()
        '        SqlHelper.ExecuteNonQuery(cmd, "dbo.CargarSalud", id_usuario, isNothingToDBNull(grupo), isNothingToDBNull(identificacion), isNothingToDBNull(nombre), isNothingToDBNull(regional), isNothingToDBNull(fecha_inicial), isNothingToDBNull(fecha_final), isNothingToDBNull(genero), isNothingToDBNull(Estado_Nutricional))

        'SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.CargarSalud", id_usuario, isNothingToDBNull(grupo), isNothingToDBNull(identificacion), isNothingToDBNull(nombre), isNothingToDBNull(regional), isNothingToDBNull(fecha_inicial), isNothingToDBNull(fecha_final), isNothingToDBNull(genero), isNothingToDBNull(Estado_Nutricional))
    End Sub

End Class

