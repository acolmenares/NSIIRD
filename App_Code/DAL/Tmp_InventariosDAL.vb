Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Tmp_InventariosDAL

    Public Shared Function Insertar(ByVal Id_Usuario As Int32, ByVal Id_Regional As Int32, ByVal Id_Bodega As Int32, ByVal Id_Producto As Int32, ByVal Inventario_Inicial As Double, ByVal Compras As Double, ByVal Devoluciones As Double, ByVal Donaciones As Double, ByVal Traslados_Entradas As Double, ByVal Salidas_Automaticas As Double, ByVal Salidas_Manuales As Double, ByVal Devoluciones_Proveedor As Double, ByVal Traslados_Salidas As Double, ByVal Ajustes_Sin_Aprobar As Double, ByVal Ajustes_Aprobados As Double) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Tmp_InventariosInsertar", isNothingToDBNull(Id_Usuario), isNothingToDBNull(Id_Regional), isNothingToDBNull(Id_Bodega), isNothingToDBNull(Id_Producto), isNothingToDBNull(Inventario_Inicial), isNothingToDBNull(Compras), isNothingToDBNull(Devoluciones), isNothingToDBNull(Donaciones), isNothingToDBNull(Traslados_Entradas), isNothingToDBNull(Salidas_Automaticas), isNothingToDBNull(Salidas_Manuales), isNothingToDBNull(Devoluciones_Proveedor), isNothingToDBNull(Traslados_Salidas), isNothingToDBNull(Ajustes_Sin_Aprobar), isNothingToDBNull(Ajustes_Aprobados))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Usuario As Int32, ByVal Id_Regional As Int32, ByVal Id_Bodega As Int32, ByVal Id_Producto As Int32, ByVal Inventario_Inicial As Double, ByVal Compras As Double, ByVal Devoluciones As Double, ByVal Donaciones As Double, ByVal Traslados_Entradas As Double, ByVal Salidas_Automaticas As Double, ByVal Salidas_Manuales As Double, ByVal Devoluciones_Proveedor As Double, ByVal Traslados_Salidas As Double, ByVal Ajustes_Sin_Aprobar As Double, ByVal Ajustes_Aprobados As Double)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Tmp_InventariosActualizar", Id, isNothingToDBNull(Id_Usuario), isNothingToDBNull(Id_Regional), isNothingToDBNull(Id_Bodega), isNothingToDBNull(Id_Producto), isNothingToDBNull(Inventario_Inicial), isNothingToDBNull(Compras), isNothingToDBNull(Devoluciones), isNothingToDBNull(Donaciones), isNothingToDBNull(Traslados_Entradas), isNothingToDBNull(Salidas_Automaticas), isNothingToDBNull(Salidas_Manuales), isNothingToDBNull(Devoluciones_Proveedor), isNothingToDBNull(Traslados_Salidas), isNothingToDBNull(Ajustes_Sin_Aprobar), isNothingToDBNull(Ajustes_Aprobados))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Tmp_InventariosEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Tmp_InventariosConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Tmp_InventariosConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Usuario(ByVal Id_Usuario As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Tmp_InventariosConsultarPorId_Usuario", Id_Usuario)
    End Function

    Public Shared Function CargarPorId_Bodega(ByVal Id_Bodega As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Tmp_InventariosConsultarPorId_Bodega", Id_Bodega)
    End Function

    Public Shared Function CargarPorId_Producto(ByVal Id_Producto As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Tmp_InventariosConsultarPorId_Producto", Id_Producto)
    End Function

    Public Shared Function CargarPorId_Regional(ByVal Id_Regional As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Tmp_InventariosConsultarPorId_Regional", Id_Regional)
    End Function

    Public Shared Sub CargarInventarios(ByVal Id_Usuario As Int32, ByVal id_regional As Int32, ByVal id_bodega As Int32, ByVal fecha_inicial As String, ByVal fecha_final As String, ByVal id_tipoentrada As Int32, ByVal id_tiposalida As Int32)
        Dim cnn As New System.Data.SqlClient.SqlConnection(strCadenaConexion)
        Dim cmd As System.Data.SqlClient.SqlCommand
        cmd = New System.Data.SqlClient.SqlCommand()
        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.CommandText = "dbo.CargarInventarios"

        cmd.Parameters.Add("@Id_Usuario", Data.SqlDbType.Int, 20).Value = Id_Usuario
        cmd.Parameters.Add("@id_regional_cargue", Data.SqlDbType.Int, 20).Value = isNothingToDBNull(id_regional)
        cmd.Parameters.Add("@id_bodega_cargue", Data.SqlDbType.Int, 20).Value = isNothingToDBNull(id_bodega)
        cmd.Parameters.Add("@fecha_inicial", Data.SqlDbType.NVarChar, 11).Value = isNothingToDBNull(fecha_inicial)
        cmd.Parameters.Add("@fecha_final", Data.SqlDbType.NVarChar, 11).Value = isNothingToDBNull(fecha_final)
        cmd.Parameters.Add("@id_tipoentrada", Data.SqlDbType.Int, 20).Value = isNothingToDBNull(id_tipoentrada)
        cmd.Parameters.Add("@id_tiposalida", Data.SqlDbType.Int, 20).Value = isNothingToDBNull(id_tiposalida)
        cmd.CommandTimeout = TiempoConexion

        cmd.ExecuteNonQuery()
        cnn.Close()


        'SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.CargarInventarios", Id_Usuario, isNothingToDBNull(id_regional), isNothingToDBNull(id_bodega), isNothingToDBNull(fecha_inicial), isNothingToDBNull(fecha_final), isNothingToDBNull(id_tipoentrada), isNothingToDBNull(id_tiposalida))
    End Sub

End Class

