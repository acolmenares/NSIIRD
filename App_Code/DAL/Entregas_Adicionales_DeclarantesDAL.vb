Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Entregas_Adicionales_DeclarantesDAL

    Public Shared Function Insertar(ByVal Id_Entrega_Adicional As Int32, ByVal Id_Declaracion As Int32, ByVal Id_Conoce_RUPD As Int32, ByVal Id_Estado_RUPD As Int32, ByVal Fecha_Investigacion As DateTime, ByVal Id_Motivo_No_Incluido As Int32, ByVal Id_Regimen_Subsidiado As Int32, ByVal Cuantos_Subsidiados As Int32, ByVal Id_Regimen_Contributivo As Int32, ByVal Cuantos_Contributivos As Int32, ByVal Id_Incluidos_SISBEN As Int32, ByVal Cuantos_SISBEN As Int32, ByVal Id_Servicio_Salud_NoAccede As Int32, ByVal Nombre_Entidad_Salud As String, ByVal Id_Ha_Recibido_Ayuda_AS As Int32, ByVal Id_Invirtio_Recursos As Int32, ByVal Invirtio_Otros As String, ByVal Id_Beneficiario_Juntos As Int32, ByVal Id_Beneficiario_FamiliasAccion As Int32, ByVal Id_Inscrito_Asociacion_Desplazados As Int32, ByVal Nombre_Asociacion As String, ByVal Id_Llegada_Insultos As Int32, ByVal Id_Llegada_Insultos_Usted As Int32, ByVal Id_Llegada_Insultos_Miembro As Int32, ByVal Llegada_Insultos_Agresor As String, ByVal Id_Llegada_Sexual As Int32, ByVal Id_Llegada_Sexual_Usted As Int32, ByVal Id_Llegada_Sexual_Miembro As Int32, ByVal Llegada_Sexual_Agresor As String, ByVal Id_Llegada_Golpes As Int32, ByVal Id_Llegada_Golpes_Usted As Int32, ByVal Id_Llegada_Golpes_Miembro As Int32, ByVal Llegada_Golpes_Agresor As String, ByVal Observaciones As String, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesInsertar", isNothingToDBNull(Id_Entrega_Adicional), isNothingToDBNull(Id_Declaracion), isNothingToDBNull(Id_Conoce_RUPD), isNothingToDBNull(Id_Estado_RUPD), isNothingToDBNull(Fecha_Investigacion), isNothingToDBNull(Id_Motivo_No_Incluido), isNothingToDBNull(Id_Regimen_Subsidiado), isNothingToDBNull(Cuantos_Subsidiados), isNothingToDBNull(Id_Regimen_Contributivo), isNothingToDBNull(Cuantos_Contributivos), isNothingToDBNull(Id_Incluidos_SISBEN), isNothingToDBNull(Cuantos_SISBEN), isNothingToDBNull(Id_Servicio_Salud_NoAccede), isNothingToDBNull(Nombre_Entidad_Salud), isNothingToDBNull(Id_Ha_Recibido_Ayuda_AS), isNothingToDBNull(Id_Invirtio_Recursos), isNothingToDBNull(Invirtio_Otros), isNothingToDBNull(Id_Beneficiario_Juntos), isNothingToDBNull(Id_Beneficiario_FamiliasAccion), isNothingToDBNull(Id_Inscrito_Asociacion_Desplazados), isNothingToDBNull(Nombre_Asociacion), isNothingToDBNull(Id_Llegada_Insultos), isNothingToDBNull(Id_Llegada_Insultos_Usted), isNothingToDBNull(Id_Llegada_Insultos_Miembro), isNothingToDBNull(Llegada_Insultos_Agresor), isNothingToDBNull(Id_Llegada_Sexual), isNothingToDBNull(Id_Llegada_Sexual_Usted), isNothingToDBNull(Id_Llegada_Sexual_Miembro), isNothingToDBNull(Llegada_Sexual_Agresor), isNothingToDBNull(Id_Llegada_Golpes), isNothingToDBNull(Id_Llegada_Golpes_Usted), isNothingToDBNull(Id_Llegada_Golpes_Miembro), isNothingToDBNull(Llegada_Golpes_Agresor), isNothingToDBNull(Observaciones), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Entrega_Adicional As Int32, ByVal Id_Declaracion As Int32, ByVal Id_Conoce_RUPD As Int32, ByVal Id_Estado_RUPD As Int32, ByVal Fecha_Investigacion As DateTime, ByVal Id_Motivo_No_Incluido As Int32, ByVal Id_Regimen_Subsidiado As Int32, ByVal Cuantos_Subsidiados As Int32, ByVal Id_Regimen_Contributivo As Int32, ByVal Cuantos_Contributivos As Int32, ByVal Id_Incluidos_SISBEN As Int32, ByVal Cuantos_SISBEN As Int32, ByVal Id_Servicio_Salud_NoAccede As Int32, ByVal Nombre_Entidad_Salud As String, ByVal Id_Ha_Recibido_Ayuda_AS As Int32, ByVal Id_Invirtio_Recursos As Int32, ByVal Invirtio_Otros As String, ByVal Id_Beneficiario_Juntos As Int32, ByVal Id_Beneficiario_FamiliasAccion As Int32, ByVal Id_Inscrito_Asociacion_Desplazados As Int32, ByVal Nombre_Asociacion As String, ByVal Id_Llegada_Insultos As Int32, ByVal Id_Llegada_Insultos_Usted As Int32, ByVal Id_Llegada_Insultos_Miembro As Int32, ByVal Llegada_Insultos_Agresor As String, ByVal Id_Llegada_Sexual As Int32, ByVal Id_Llegada_Sexual_Usted As Int32, ByVal Id_Llegada_Sexual_Miembro As Int32, ByVal Llegada_Sexual_Agresor As String, ByVal Id_Llegada_Golpes As Int32, ByVal Id_Llegada_Golpes_Usted As Int32, ByVal Id_Llegada_Golpes_Miembro As Int32, ByVal Llegada_Golpes_Agresor As String, ByVal Observaciones As String, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesActualizar", Id, isNothingToDBNull(Id_Entrega_Adicional), isNothingToDBNull(Id_Declaracion), isNothingToDBNull(Id_Conoce_RUPD), isNothingToDBNull(Id_Estado_RUPD), isNothingToDBNull(Fecha_Investigacion), isNothingToDBNull(Id_Motivo_No_Incluido), isNothingToDBNull(Id_Regimen_Subsidiado), isNothingToDBNull(Cuantos_Subsidiados), isNothingToDBNull(Id_Regimen_Contributivo), isNothingToDBNull(Cuantos_Contributivos), isNothingToDBNull(Id_Incluidos_SISBEN), isNothingToDBNull(Cuantos_SISBEN), isNothingToDBNull(Id_Servicio_Salud_NoAccede), isNothingToDBNull(Nombre_Entidad_Salud), isNothingToDBNull(Id_Ha_Recibido_Ayuda_AS), isNothingToDBNull(Id_Invirtio_Recursos), isNothingToDBNull(Invirtio_Otros), isNothingToDBNull(Id_Beneficiario_Juntos), isNothingToDBNull(Id_Beneficiario_FamiliasAccion), isNothingToDBNull(Id_Inscrito_Asociacion_Desplazados), isNothingToDBNull(Nombre_Asociacion), isNothingToDBNull(Id_Llegada_Insultos), isNothingToDBNull(Id_Llegada_Insultos_Usted), isNothingToDBNull(Id_Llegada_Insultos_Miembro), isNothingToDBNull(Llegada_Insultos_Agresor), isNothingToDBNull(Id_Llegada_Sexual), isNothingToDBNull(Id_Llegada_Sexual_Usted), isNothingToDBNull(Id_Llegada_Sexual_Miembro), isNothingToDBNull(Llegada_Sexual_Agresor), isNothingToDBNull(Id_Llegada_Golpes), isNothingToDBNull(Id_Llegada_Golpes_Usted), isNothingToDBNull(Id_Llegada_Golpes_Miembro), isNothingToDBNull(Llegada_Golpes_Agresor), isNothingToDBNull(Observaciones), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Beneficiario_FamiliasAccion(ByVal Id_Beneficiario_FamiliasAccion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesConsultarPorId_Beneficiario_FamiliasAccion", Id_Beneficiario_FamiliasAccion)
    End Function

    Public Shared Function CargarPorId_Beneficiario_Juntos(ByVal Id_Beneficiario_Juntos As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesConsultarPorId_Beneficiario_Juntos", Id_Beneficiario_Juntos)
    End Function

    Public Shared Function CargarPorId_Conoce_RUPD(ByVal Id_Conoce_RUPD As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesConsultarPorId_Conoce_RUPD", Id_Conoce_RUPD)
    End Function

    Public Shared Function CargarPorId_Declaracion(ByVal Id_Declaracion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesConsultarPorId_Declaracion", Id_Declaracion)
    End Function

    Public Shared Function CargarPorId_Entrega_Adicional(ByVal Id_Entrega_Adicional As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesConsultarPorId_Entrega_Adicional", Id_Entrega_Adicional)
    End Function

    Public Shared Function CargarPorId_Estado_RUPD(ByVal Id_Estado_RUPD As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesConsultarPorId_Estado_RUPD", Id_Estado_RUPD)
    End Function

    Public Shared Function CargarPorId_Ha_Recibido_Ayuda_AS(ByVal Id_Ha_Recibido_Ayuda_AS As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesConsultarPorId_Ha_Recibido_Ayuda_AS", Id_Ha_Recibido_Ayuda_AS)
    End Function

    Public Shared Function CargarPorId_Incluidos_SISBEN(ByVal Id_Incluidos_SISBEN As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesConsultarPorId_Incluidos_SISBEN", Id_Incluidos_SISBEN)
    End Function

    Public Shared Function CargarPorId_Inscrito_Asociacion_Desplazados(ByVal Id_Inscrito_Asociacion_Desplazados As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesConsultarPorId_Inscrito_Asociacion_Desplazados", Id_Inscrito_Asociacion_Desplazados)
    End Function

    Public Shared Function CargarPorId_Invirtio_Recursos(ByVal Id_Invirtio_Recursos As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesConsultarPorId_Invirtio_Recursos", Id_Invirtio_Recursos)
    End Function

    Public Shared Function CargarPorId_Llegada_Golpes(ByVal Id_Llegada_Golpes As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesConsultarPorId_Llegada_Golpes", Id_Llegada_Golpes)
    End Function

    Public Shared Function CargarPorId_Llegada_Golpes_Miembro(ByVal Id_Llegada_Golpes_Miembro As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesConsultarPorId_Llegada_Golpes_Miembro", Id_Llegada_Golpes_Miembro)
    End Function

    Public Shared Function CargarPorId_Llegada_Golpes_Usted(ByVal Id_Llegada_Golpes_Usted As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesConsultarPorId_Llegada_Golpes_Usted", Id_Llegada_Golpes_Usted)
    End Function

    Public Shared Function CargarPorId_Llegada_Insultos(ByVal Id_Llegada_Insultos As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesConsultarPorId_Llegada_Insultos", Id_Llegada_Insultos)
    End Function

    Public Shared Function CargarPorId_Llegada_Insultos_Miembro(ByVal Id_Llegada_Insultos_Miembro As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesConsultarPorId_Llegada_Insultos_Miembro", Id_Llegada_Insultos_Miembro)
    End Function

    Public Shared Function CargarPorId_Llegada_Insultos_Usted(ByVal Id_Llegada_Insultos_Usted As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesConsultarPorId_Llegada_Insultos_Usted", Id_Llegada_Insultos_Usted)
    End Function

    Public Shared Function CargarPorId_Llegada_Sexual(ByVal Id_Llegada_Sexual As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesConsultarPorId_Llegada_Sexual", Id_Llegada_Sexual)
    End Function

    Public Shared Function CargarPorId_Llegada_Sexual_Miembro(ByVal Id_Llegada_Sexual_Miembro As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesConsultarPorId_Llegada_Sexual_Miembro", Id_Llegada_Sexual_Miembro)
    End Function

    Public Shared Function CargarPorId_Llegada_Sexual_Usted(ByVal Id_Llegada_Sexual_Usted As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesConsultarPorId_Llegada_Sexual_Usted", Id_Llegada_Sexual_Usted)
    End Function

    Public Shared Function CargarPorId_Motivo_No_Incluido(ByVal Id_Motivo_No_Incluido As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesConsultarPorId_Motivo_No_Incluido", Id_Motivo_No_Incluido)
    End Function

    Public Shared Function CargarPorId_Regimen_Contributivo(ByVal Id_Regimen_Contributivo As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesConsultarPorId_Regimen_Contributivo", Id_Regimen_Contributivo)
    End Function

    Public Shared Function CargarPorId_Regimen_Subsidiado(ByVal Id_Regimen_Subsidiado As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesConsultarPorId_Regimen_Subsidiado", Id_Regimen_Subsidiado)
    End Function

    Public Shared Function CargarPorId_Servicio_Salud_NoAccede(ByVal Id_Servicio_Salud_NoAccede As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesConsultarPorId_Servicio_Salud_NoAccede", Id_Servicio_Salud_NoAccede)
    End Function

    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesConsultarPorId_Usuario_Creacion", Id_Usuario_Creacion)
    End Function

    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Entregas_Adicionales_DeclarantesConsultarPorId_Usuario_Modificacion", Id_Usuario_Modificacion)
    End Function

End Class

