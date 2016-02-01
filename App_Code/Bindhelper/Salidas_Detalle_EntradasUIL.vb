Imports System.Collections.Generic
Imports System.Data
Imports ingNovar.Utilidades2

Namespace BindHelper
    
    Partial Public NotInheritable Class Salidas_Detalle_EntradasUIL
        
        Private Shared Sub Bind(ByVal control As ListControl, ByVal Lista As List(Of Salidas_Detalle_EntradasBRL), Optional ByVal firstItem As ListItem = Nothing)
            control.DataSource = Lista
            control.DataValueField = "ID"
            control.DataTextField = "DescripcionProductosSalida"
            control.DataBind
            If Not firstItem Is Nothing  Then
                control.Items.Insert(0, firstItem)
            End If
        End Sub
        
        Public Shared Function BindToListControl(ByVal control As ListControl, Optional ByVal firstItem As ListItem = Nothing) As List(Of Salidas_Detalle_EntradasBRL)
            Dim Lista As List(Of Salidas_Detalle_EntradasBRL)
            Lista = Salidas_Detalle_EntradasBRL.CargarTodos()
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
        
        Public Shared Function BindToListControlPorId_Entrada_Distribucion(ByVal control As ListControl, ByVal Id_Entrada_Distribucion As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Salidas_Detalle_EntradasBRL)
            Dim Lista As List(Of Salidas_Detalle_EntradasBRL)
            Lista = Salidas_Detalle_EntradasBRL.CargarPorId_Entrada_Distribucion(Id_Entrada_Distribucion)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Salida_Detalle(ByVal control As ListControl, ByVal Id_Salida_Detalle As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Salidas_Detalle_EntradasBRL)
            Dim Lista As List(Of Salidas_Detalle_EntradasBRL)
            Lista = Salidas_Detalle_EntradasBRL.CargarPorId_Salida_Detalle(Id_Salida_Detalle)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Salida(ByVal control As ListControl, ByVal Id_Salida As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Salidas_Detalle_EntradasBrl)
            Dim Lista As List(Of Salidas_Detalle_EntradasBrl)
            Lista = Salidas_Detalle_EntradasBrl.CargarEspecialPorId_Salida(Id_Salida)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function


    End Class
    
End Namespace


