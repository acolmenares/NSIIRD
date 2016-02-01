Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class GestantesDAL

    Public Shared Function Insertar(ByVal Id_Persona As Int32, ByVal Id_Control_Prenatal As Int32, ByVal Unidad_Basica_Atencion As String, ByVal Id_Ingesta_Micronutrientes As Int32, ByVal Enfermedades As String, ByVal Semanas_Gestacion As Int32, ByVal Id_Remitidas As Int32, ByVal Fecha_Remision As DateTime, ByVal Id_Visita_Domiciliaria As Int32, ByVal Fecha_Visita As DateTime, ByVal Observaciones As String, ByVal Fecha_Control_Prenatal As DateTime, ByVal Observaciones_Visita As String, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Peso As Double, ByVal Talla As Double, ByVal IMC As Double, ByVal Estado_nutricional As String, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.GestantesInsertar", isNothingToDBNull(Id_Persona), isNothingToDBNull(Id_Control_Prenatal), isNothingToDBNull(Unidad_Basica_Atencion), isNothingToDBNull(Id_Ingesta_Micronutrientes), isNothingToDBNull(Enfermedades), isNothingToDBNull(Semanas_Gestacion), isNothingToDBNull(Id_Remitidas), isNothingToDBNull(Fecha_Remision), isNothingToDBNull(Id_Visita_Domiciliaria), isNothingToDBNull(Fecha_Visita), isNothingToDBNull(Observaciones), isNothingToDBNull(Fecha_Control_Prenatal), isNothingToDBNull(Observaciones_Visita), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Peso), isNothingToDBNull(Talla), isNothingToDBNull(IMC), isNothingToDBNull(Estado_nutricional), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Id_Persona As Int32, ByVal Id_Control_Prenatal As Int32, ByVal Unidad_Basica_Atencion As String, ByVal Id_Ingesta_Micronutrientes As Int32, ByVal Enfermedades As String, ByVal Semanas_Gestacion As Int32, ByVal Id_Remitidas As Int32, ByVal Fecha_Remision As DateTime, ByVal Id_Visita_Domiciliaria As Int32, ByVal Fecha_Visita As DateTime, ByVal Observaciones As String, ByVal Fecha_Control_Prenatal As DateTime, ByVal Observaciones_Visita As String, ByVal Fecha_Creacion As DateTime, ByVal Id_Usuario_Creacion As Int32, ByVal Fecha_Modificacion As DateTime, ByVal Id_Usuario_Modificacion As Int32, ByVal Peso As Double, ByVal Talla As Double, ByVal IMC As Double, ByVal Estado_nutricional As String, ByVal Fecha_Cierre As DateTime, ByVal Cierre As Boolean)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.GestantesActualizar", Id, isNothingToDBNull(Id_Persona), isNothingToDBNull(Id_Control_Prenatal), isNothingToDBNull(Unidad_Basica_Atencion), isNothingToDBNull(Id_Ingesta_Micronutrientes), isNothingToDBNull(Enfermedades), isNothingToDBNull(Semanas_Gestacion), isNothingToDBNull(Id_Remitidas), isNothingToDBNull(Fecha_Remision), isNothingToDBNull(Id_Visita_Domiciliaria), isNothingToDBNull(Fecha_Visita), isNothingToDBNull(Observaciones), isNothingToDBNull(Fecha_Control_Prenatal), isNothingToDBNull(Observaciones_Visita), isNothingToDBNull(Fecha_Creacion), isNothingToDBNull(Id_Usuario_Creacion), isNothingToDBNull(Fecha_Modificacion), isNothingToDBNull(Id_Usuario_Modificacion), isNothingToDBNull(Peso), isNothingToDBNull(Talla), isNothingToDBNull(IMC), isNothingToDBNull(Estado_nutricional), isNothingToDBNull(Fecha_Cierre), isNothingToDBNull(Cierre))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.GestantesEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.GestantesConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.GestantesConsultarPorID", Id)
    End Function
    
    Public Shared Function CargarPorId_Control_Prenatal(ByVal Id_Control_Prenatal As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.GestantesConsultarPorId_Control_Prenatal", Id_Control_Prenatal)
    End Function

    Public Shared Function CargarPorId_Ingesta_Micronutrientes(ByVal Id_Ingesta_Micronutrientes As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.GestantesConsultarPorId_Ingesta_Micronutrientes", Id_Ingesta_Micronutrientes)
    End Function

    Public Shared Function CargarPorId_Remitidas(ByVal Id_Remitidas As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.GestantesConsultarPorId_Remitidas", Id_Remitidas)
    End Function

    Public Shared Function CargarPorId_Visita_Domiciliaria(ByVal Id_Visita_Domiciliaria As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.GestantesConsultarPorId_Visita_Domiciliaria", Id_Visita_Domiciliaria)
    End Function

    Public Shared Function CargarPorId_Persona(ByVal Id_Persona As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.GestantesConsultarPorId_Persona", Id_Persona)
    End Function

    Public Shared Function CargarPorId_Usuario_Creacion(ByVal Id_Usuario_Creacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.GestantesConsultarPorId_Usuario_Creacion", Id_Usuario_Creacion)
    End Function

    Public Shared Function CargarPorId_Usuario_Modificacion(ByVal Id_Usuario_Modificacion As System.Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.GestantesConsultarPorId_Usuario_Modificacion", Id_Usuario_Modificacion)
    End Function

End Class

