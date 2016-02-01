Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class SalidasDAL

    Public Shared Function Insertar(ByVal Id_Tipo_Salida As Int32, ByVal Numero As String, ByVal Fecha As DateTime, ByVal Nombre_Entrega As String, ByVal Nombre_Salida As String, ByVal Id_regional As Int32, ByVal Id_bodega As Int32, ByVal Id_Tercero As Int32, ByVal Id_Reg_Grupo As Int32, ByVal Id_Tipo_Entrega As Int32, ByVal Dias_Entrega As Int32, ByVal Observacion As String, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Tipo As String, ByVal Legalizado As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean, ByVal Id_Programa As Int32) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.SalidasInsertar", isNothingToDBNull(Id_Tipo_Salida), isNothingToDBNull(Numero), isNothingToDBNull(Fecha), isNothingToDBNull(Nombre_Entrega), isNothingToDBNull(Nombre_Salida), isNothingToDBNull(Id_regional), isNothingToDBNull(Id_bodega), isNothingToDBNull(Id_Tercero), isNothingToDBNull(Id_Reg_Grupo), isNothingToDBNull(Id_Tipo_Entrega), isNothingToDBNull(Dias_Entrega), isNothingToDBNull(Observacion), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Tipo), isNothingToDBNull(Legalizado), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre), isNothingToDBNull(Id_Programa))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Tipo_Salida As Int32, ByVal Numero As String, ByVal Fecha As DateTime, ByVal Nombre_Entrega As String, ByVal Nombre_Salida As String, ByVal Id_regional As Int32, ByVal Id_bodega As Int32, ByVal Id_Tercero As Int32, ByVal Id_Reg_Grupo As Int32, ByVal Id_Tipo_Entrega As Int32, ByVal Dias_Entrega As Int32, ByVal Observacion As String, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Tipo As String, ByVal Legalizado As Int32, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean, ByVal Id_Programa As Int32)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.SalidasActualizar", Id, isNothingToDBNull(Id_Tipo_Salida), isNothingToDBNull(Numero), isNothingToDBNull(Fecha), isNothingToDBNull(Nombre_Entrega), isNothingToDBNull(Nombre_Salida), isNothingToDBNull(Id_regional), isNothingToDBNull(Id_bodega), isNothingToDBNull(Id_Tercero), isNothingToDBNull(Id_Reg_Grupo), isNothingToDBNull(Id_Tipo_Entrega), isNothingToDBNull(Dias_Entrega), isNothingToDBNull(Observacion), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Tipo), isNothingToDBNull(Legalizado), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre), isNothingToDBNull(Id_Programa))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.SalidasEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SalidasConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SalidasConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Regional(ByVal Id_Regional As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SalidasConsultarPorId_Regional", Id_Regional)
    End Function

    Public Shared Function CargarPorId_Bodega(ByVal Id_Bodega As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SalidasConsultarPorId_Bodega", Id_Bodega)
    End Function

    Public Shared Function CargarPorId_Tercero(ByVal Id_Tercero As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SalidasConsultarPorId_Tercero", Id_Tercero)
    End Function

    Public Shared Function CargarPorId_Grupo(ByVal Id_Reg_Grupo As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SalidasConsultarPorId_Reg_Grupo", Id_Reg_Grupo)
    End Function

    Public Shared Function CargarPorId_Tipo_Entrega(ByVal Id_Tipo_Entrega As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SalidasConsultarPorId_Tipo_Entrega", Id_Tipo_Entrega)
    End Function

    Public Shared Function CargarPorId_Tipo_Salida(ByVal Id_Tipo_Salida As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SalidasConsultarPorId_Tipo_Salida", Id_Tipo_Salida)
    End Function

    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SalidasConsultarPorId_Usuario_Creacion", Id_Usuario_Creacion)
    End Function

    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SalidasConsultarPorId_Usuario_Modificacion", Id_Usuario_Modificacion)
    End Function

    Public Shared Function CargarPorAprobacion_Logistica_Oficina(ByVal Id_Bodega As Int32, ByVal Id_Regional As Int32, ByVal numero As String, ByVal Fecha_Inicial As String, ByVal Fecha_Final As String) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SalidasAjustesConsultarPorAprobacion_Logistica_Oficina", isNothingToDBNull(Id_Bodega), isNothingToDBNull(Id_Regional), isNothingToDBNull(numero), isNothingToDBNull(Fecha_Inicial), isNothingToDBNull(Fecha_Final))
    End Function

    Public Shared Function CargarPorAprobacion_Finanzas_Oficina(ByVal Id_Bodega As Int32, ByVal Id_Regional As Int32, ByVal numero As String, ByVal Fecha_Inicial As String, ByVal Fecha_Final As String) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SalidasAjustesConsultarPorAprobacion_Finanzas_Oficina", isNothingToDBNull(Id_Bodega), isNothingToDBNull(Id_Regional), isNothingToDBNull(numero), isNothingToDBNull(Fecha_Inicial), isNothingToDBNull(Fecha_Final))
    End Function

    Public Shared Function CargarPorAprobacion_Coordinador_Oficina(ByVal Id_Bodega As Int32, ByVal Id_Regional As Int32, ByVal numero As String, ByVal Fecha_Inicial As String, ByVal Fecha_Final As String) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SalidasAjustesConsultarPorAprobacion_Coordinador_Oficina", isNothingToDBNull(Id_Bodega), isNothingToDBNull(Id_Regional), isNothingToDBNull(numero), isNothingToDBNull(Fecha_Inicial), isNothingToDBNull(Fecha_Final))
    End Function

    Public Shared Function CargarPorAprobacion_Coordinador_Logistica(ByVal Id_Bodega As Int32, ByVal Id_Regional As Int32, ByVal numero As String, ByVal Fecha_Inicial As String, ByVal Fecha_Final As String) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SalidasAjustesConsultarPorAprobacion_Coordinador_Logistica", isNothingToDBNull(Id_Bodega), isNothingToDBNull(Id_Regional), isNothingToDBNull(numero), isNothingToDBNull(Fecha_Inicial), isNothingToDBNull(Fecha_Final))
    End Function

    Public Shared Function CargarPorAprobacion_Director_Financiero(ByVal Id_Bodega As Int32, ByVal Id_Regional As Int32, ByVal numero As String, ByVal Fecha_Inicial As String, ByVal Fecha_Final As String) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SalidasAjustesConsultarPorAprobacion_Director_Financiero", isNothingToDBNull(Id_Bodega), isNothingToDBNull(Id_Regional), isNothingToDBNull(numero), isNothingToDBNull(Fecha_Inicial), isNothingToDBNull(Fecha_Final))
    End Function

    Public Shared Function CargarPorAprobacion_Director_Pais(ByVal Id_Bodega As Int32, ByVal Id_Regional As Int32, ByVal numero As String, ByVal Fecha_Inicial As String, ByVal Fecha_Final As String) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SalidasAjustesConsultarPorAprobacion_Director_Pais", isNothingToDBNull(Id_Bodega), isNothingToDBNull(Id_Regional), isNothingToDBNull(numero), isNothingToDBNull(Fecha_Inicial), isNothingToDBNull(Fecha_Final))
    End Function

    Public Shared Function CargarPorBusqueda(ByVal Id_Regional As Int32, ByVal id_bodega As Int32, ByVal id_producto As Int32, ByVal fecha_inicial As String, ByVal fecha_final As String, ByVal numero As String, ByVal Id_Tipo_Salida As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SalidasConsultarPorBusqueda", isNothingToDBNull(Id_Regional), isNothingToDBNull(id_bodega), isNothingToDBNull(id_producto), isNothingToDBNull(fecha_inicial), isNothingToDBNull(fecha_final), isNothingToDBNull(numero), Id_Tipo_Salida)
    End Function

    Public Shared Function CargarPorId_Programa(ByVal Id_Programa As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SalidasConsultarPorId_Programa", Id_Programa)
    End Function

End Class

