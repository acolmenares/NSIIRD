Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class Declaracion_PAARIDAL

    Public Shared Function Insertar(ByVal Id_Declaracion As Int32, ByVal Id_Tipo_Entrega As Int32, ByVal Id_Alimentacion_Consumo As Int32, ByVal Id_Alimentacion_Raices As Int32, ByVal Id_Alimentacion_Verduras As Int32, ByVal Id_Alimentacion_Frutas As Int32, ByVal Id_Alimentacion_Carnes As Int32, ByVal Id_Alimentacion_Huevos As Int32, ByVal Id_Alimentacion_Leguminosas As Int32, ByVal Id_Alimentacion_Lacteos As Int32, ByVal Id_Alimentacion_Grasas As Int32, ByVal Id_Alimentacion_Azucares As Int32, ByVal Id_Alimentacion_Harinas As Int32, ByVal Id_Alimentacion_Enbutidos As Int32, ByVal Id_Alimentacion_Enlatados As Int32, ByVal Id_Alimentacion_Gaseosas As Int32, ByVal Id_Alimentacion_Agua As Int32, ByVal Id_Alimentacion_Bienestarina As Int32, ByVal Id_Alojamiento_Tipo_Vivienda As Int32, ByVal Id_Alojamiento_Tipo_Vivienda_Otro As Int32, ByVal Id_Alojamiento_Material_Pisos As Int32, ByVal Id_Alojamiento_Material_Paredes As Int32, ByVal Id_Alojamiento_Zona_Riesgo As Int32, ByVal Id_Alojamiento_Cuantos_Duermen As Int32, ByVal Id_Alojamiento_Acueducto As Int32, ByVal Id_Alojamiento_Obtiene_Agua As Int32, ByVal Id_Alojamiento_Alcantarillado As Int32, ByVal Id_Alojamiento_Servicio_Sanitario As Int32, Valor_Alimentacion As Double, Valor_Alojamiento As Double, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Declaracion_PAARIInsertar", isNothingToDBNull(Id_Declaracion), isNothingToDBNull(Id_Tipo_Entrega), isNothingToDBNull(Id_Alimentacion_Consumo), isNothingToDBNull(Id_Alimentacion_Raices), isNothingToDBNull(Id_Alimentacion_Verduras), isNothingToDBNull(Id_Alimentacion_Frutas), isNothingToDBNull(Id_Alimentacion_Carnes), isNothingToDBNull(Id_Alimentacion_Huevos), isNothingToDBNull(Id_Alimentacion_Leguminosas), isNothingToDBNull(Id_Alimentacion_Lacteos), isNothingToDBNull(Id_Alimentacion_Grasas), isNothingToDBNull(Id_Alimentacion_Azucares), isNothingToDBNull(Id_Alimentacion_Harinas), isNothingToDBNull(Id_Alimentacion_Enbutidos), isNothingToDBNull(Id_Alimentacion_Enlatados), isNothingToDBNull(Id_Alimentacion_Gaseosas), isNothingToDBNull(Id_Alimentacion_Agua), isNothingToDBNull(Id_Alimentacion_Bienestarina), isNothingToDBNull(Id_Alojamiento_Tipo_Vivienda), isNothingToDBNull(Id_Alojamiento_Tipo_Vivienda_Otro), isNothingToDBNull(Id_Alojamiento_Material_Pisos), isNothingToDBNull(Id_Alojamiento_Material_Paredes), isNothingToDBNull(Id_Alojamiento_Zona_Riesgo), isNothingToDBNull(Id_Alojamiento_Cuantos_Duermen), isNothingToDBNull(Id_Alojamiento_Acueducto), isNothingToDBNull(Id_Alojamiento_Obtiene_Agua), isNothingToDBNull(Id_Alojamiento_Alcantarillado), isNothingToDBNull(Id_Alojamiento_Servicio_Sanitario), isNothingToDBNull(Valor_Alimentacion), isNothingToDBNull(Valor_Alojamiento), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Declaracion As Int32, ByVal Id_Tipo_Entrega As Int32, ByVal Id_Alimentacion_Consumo As Int32, ByVal Id_Alimentacion_Raices As Int32, ByVal Id_Alimentacion_Verduras As Int32, ByVal Id_Alimentacion_Frutas As Int32, ByVal Id_Alimentacion_Carnes As Int32, ByVal Id_Alimentacion_Huevos As Int32, ByVal Id_Alimentacion_Leguminosas As Int32, ByVal Id_Alimentacion_Lacteos As Int32, ByVal Id_Alimentacion_Grasas As Int32, ByVal Id_Alimentacion_Azucares As Int32, ByVal Id_Alimentacion_Harinas As Int32, ByVal Id_Alimentacion_Enbutidos As Int32, ByVal Id_Alimentacion_Enlatados As Int32, ByVal Id_Alimentacion_Gaseosas As Int32, ByVal Id_Alimentacion_Agua As Int32, ByVal Id_Alimentacion_Bienestarina As Int32, ByVal Id_Alojamiento_Tipo_Vivienda As Int32, ByVal Id_Alojamiento_Tipo_Vivienda_Otro As Int32, ByVal Id_Alojamiento_Material_Pisos As Int32, ByVal Id_Alojamiento_Material_Paredes As Int32, ByVal Id_Alojamiento_Zona_Riesgo As Int32, ByVal Id_Alojamiento_Cuantos_Duermen As Int32, ByVal Id_Alojamiento_Acueducto As Int32, ByVal Id_Alojamiento_Obtiene_Agua As Int32, ByVal Id_Alojamiento_Alcantarillado As Int32, ByVal Id_Alojamiento_Servicio_Sanitario As Int32, Valor_Alimentacion As Double, Valor_Alojamiento As Double, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.Declaracion_PAARIActualizar", Id, isNothingToDBNull(Id_Declaracion), isNothingToDBNull(Id_Tipo_Entrega), isNothingToDBNull(Id_Alimentacion_Consumo), isNothingToDBNull(Id_Alimentacion_Raices), isNothingToDBNull(Id_Alimentacion_Verduras), isNothingToDBNull(Id_Alimentacion_Frutas), isNothingToDBNull(Id_Alimentacion_Carnes), isNothingToDBNull(Id_Alimentacion_Huevos), isNothingToDBNull(Id_Alimentacion_Leguminosas), isNothingToDBNull(Id_Alimentacion_Lacteos), isNothingToDBNull(Id_Alimentacion_Grasas), isNothingToDBNull(Id_Alimentacion_Azucares), isNothingToDBNull(Id_Alimentacion_Harinas), isNothingToDBNull(Id_Alimentacion_Enbutidos), isNothingToDBNull(Id_Alimentacion_Enlatados), isNothingToDBNull(Id_Alimentacion_Gaseosas), isNothingToDBNull(Id_Alimentacion_Agua), isNothingToDBNull(Id_Alimentacion_Bienestarina), isNothingToDBNull(Id_Alojamiento_Tipo_Vivienda), isNothingToDBNull(Id_Alojamiento_Tipo_Vivienda_Otro), isNothingToDBNull(Id_Alojamiento_Material_Pisos), isNothingToDBNull(Id_Alojamiento_Material_Paredes), isNothingToDBNull(Id_Alojamiento_Zona_Riesgo), isNothingToDBNull(Id_Alojamiento_Cuantos_Duermen), isNothingToDBNull(Id_Alojamiento_Acueducto), isNothingToDBNull(Id_Alojamiento_Obtiene_Agua), isNothingToDBNull(Id_Alojamiento_Alcantarillado), isNothingToDBNull(Id_Alojamiento_Servicio_Sanitario), isNothingToDBNull(Valor_Alimentacion), isNothingToDBNull(Valor_Alojamiento), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.Declaracion_PAARIEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Alimentacion_Agua(ByVal Id_Alimentacion_Agua As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarPorId_Alimentacion_Agua", Id_Alimentacion_Agua)
    End Function

    Public Shared Function CargarPorId_Alimentacion_Azucares(ByVal Id_Alimentacion_Azucares As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarPorId_Alimentacion_Azucares", Id_Alimentacion_Azucares)
    End Function

    Public Shared Function CargarPorId_Alimentacion_Bienestarina(ByVal Id_Alimentacion_Bienestarina As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarPorId_Alimentacion_Bienestarina", Id_Alimentacion_Bienestarina)
    End Function

    Public Shared Function CargarPorId_Alimentacion_Carnes(ByVal Id_Alimentacion_Carnes As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarPorId_Alimentacion_Carnes", Id_Alimentacion_Carnes)
    End Function

    Public Shared Function CargarPorId_Alimentacion_Consumo(ByVal Id_Alimentacion_Consumo As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarPorId_Alimentacion_Consumo", Id_Alimentacion_Consumo)
    End Function

    Public Shared Function CargarPorId_Alimentacion_Enbutidos(ByVal Id_Alimentacion_Enbutidos As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarPorId_Alimentacion_Enbutidos", Id_Alimentacion_Enbutidos)
    End Function

    Public Shared Function CargarPorId_Alimentacion_Enlatados(ByVal Id_Alimentacion_Enlatados As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarPorId_Alimentacion_Enlatados", Id_Alimentacion_Enlatados)
    End Function

    Public Shared Function CargarPorId_Alimentacion_Frutas(ByVal Id_Alimentacion_Frutas As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarPorId_Alimentacion_Frutas", Id_Alimentacion_Frutas)
    End Function

    Public Shared Function CargarPorId_Alimentacion_Gaseosas(ByVal Id_Alimentacion_Gaseosas As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarPorId_Alimentacion_Gaseosas", Id_Alimentacion_Gaseosas)
    End Function

    Public Shared Function CargarPorId_Alimentacion_Grasas(ByVal Id_Alimentacion_Grasas As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarPorId_Alimentacion_Grasas", Id_Alimentacion_Grasas)
    End Function

    Public Shared Function CargarPorId_Alimentacion_Harinas(ByVal Id_Alimentacion_Harinas As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarPorId_Alimentacion_Harinas", Id_Alimentacion_Harinas)
    End Function

    Public Shared Function CargarPorId_Alimentacion_Huevos(ByVal Id_Alimentacion_Huevos As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarPorId_Alimentacion_Huevos", Id_Alimentacion_Huevos)
    End Function

    Public Shared Function CargarPorId_Alimentacion_Lacteos(ByVal Id_Alimentacion_Lacteos As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarPorId_Alimentacion_Lacteos", Id_Alimentacion_Lacteos)
    End Function

    Public Shared Function CargarPorId_Alimentacion_Leguminosas(ByVal Id_Alimentacion_Leguminosas As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarPorId_Alimentacion_Leguminosas", Id_Alimentacion_Leguminosas)
    End Function

    Public Shared Function CargarPorId_Alimentacion_Raices(ByVal Id_Alimentacion_Raices As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarPorId_Alimentacion_Raices", Id_Alimentacion_Raices)
    End Function

    Public Shared Function CargarPorId_Alimentacion_Verduras(ByVal Id_Alimentacion_Verduras As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarPorId_Alimentacion_Verduras", Id_Alimentacion_Verduras)
    End Function

    Public Shared Function CargarPorId_Alojamiento_Acueducto(ByVal Id_Alojamiento_Acueducto As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarPorId_Alojamiento_Acueducto", Id_Alojamiento_Acueducto)
    End Function

    Public Shared Function CargarPorId_Alojamiento_Alcantarillado(ByVal Id_Alojamiento_Alcantarillado As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarPorId_Alojamiento_Alcantarillado", Id_Alojamiento_Alcantarillado)
    End Function

    Public Shared Function CargarPorId_Alojamiento_Cuantos_Duermen(ByVal Id_Alojamiento_Cuantos_Duermen As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarPorId_Alojamiento_Cuantos_Duermen", Id_Alojamiento_Cuantos_Duermen)
    End Function

    Public Shared Function CargarPorId_Alojamiento_Material_Paredes(ByVal Id_Alojamiento_Material_Paredes As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarPorId_Alojamiento_Material_Paredes", Id_Alojamiento_Material_Paredes)
    End Function

    Public Shared Function CargarPorId_Alojamiento_Material_Pisos(ByVal Id_Alojamiento_Material_Pisos As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarPorId_Alojamiento_Material_Pisos", Id_Alojamiento_Material_Pisos)
    End Function

    Public Shared Function CargarPorId_Alojamiento_Obtiene_Agua(ByVal Id_Alojamiento_Obtiene_Agua As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarPorId_Alojamiento_Obtiene_Agua", Id_Alojamiento_Obtiene_Agua)
    End Function

    Public Shared Function CargarPorId_Alojamiento_Servicio_Sanitario(ByVal Id_Alojamiento_Servicio_Sanitario As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarPorId_Alojamiento_Servicio_Sanitario", Id_Alojamiento_Servicio_Sanitario)
    End Function

    Public Shared Function CargarPorId_Alojamiento_Tipo_Vivienda(ByVal Id_Alojamiento_Tipo_Vivienda As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarPorId_Alojamiento_Tipo_Vivienda", Id_Alojamiento_Tipo_Vivienda)
    End Function

    Public Shared Function CargarPorId_Alojamiento_Tipo_Vivienda_Otro(ByVal Id_Alojamiento_Tipo_Vivienda_otro As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarPorId_Alojamiento_Tipo_Vivienda_Otro", Id_Alojamiento_Tipo_Vivienda_otro)
    End Function

    Public Shared Function CargarPorId_Alojamiento_Zona_Riesgo(ByVal Id_Alojamiento_Zona_Riesgo As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarPorId_Alojamiento_Zona_Riesgo", Id_Alojamiento_Zona_Riesgo)
    End Function

    Public Shared Function CargarPorId_Declaracion(ByVal Id_Declaracion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarPorId_Declaracion", Id_Declaracion)
    End Function

    Public Shared Function CargarPorId_Tipo_Entrega(ByVal Id_Tipo_Entrega As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.Declaracion_PAARIConsultarPorId_Tipo_Entrega", Id_Tipo_Entrega)
    End Function

End Class

