Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Collections.Generic

Partial Public Class Salidas_Detalle_EntradasBrl

    Public Shared Function CantidadSalida(ByVal Id_Entrada_Distribucion As Integer) As Double
        Return Salidas_DetalleEntradasDAL.CantidadSalidasEntrada(Id_Entrada_Distribucion)
    End Function

    Public Shared Function CargarEspecialPorId_Salida(ByVal Id_Salida As Int32) As List(Of Salidas_Detalle_EntradasBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Salidas_Detalle_EntradasBrl)

        RaiseEvent LoadingSalidas_DetalleEntradasList("CargarEspecialPorId_Salida")
        dsDatos = Salidas_DetalleEntradasDAL.CargarEspecialPorId_Salida(Id_Salida)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedSalidas_DetalleEntradasList(lista, "CargarEspecialPorId_Salida")
        Return lista

    End Function
End Class
