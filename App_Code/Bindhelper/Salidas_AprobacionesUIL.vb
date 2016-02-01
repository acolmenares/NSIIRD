Imports System.Collections.Generic

Namespace BindHelper
    
    Partial Public NotInheritable Class Salidas_AprobacionesUIL
        
        Private Shared Sub Bind(ByVal control As ListControl, ByVal Lista As List(Of Salidas_AprobacionesBRL), Optional ByVal firstItem As ListItem = Nothing)
            control.DataSource = Lista
            control.DataValueField = "ID"
            control.DataTextField = "ID"
            control.DataBind
            If Not firstItem Is Nothing  Then
                control.Items.Insert(0, firstItem)
            End If
        End Sub
        
        Public Shared Function BindToListControl(ByVal control As ListControl, Optional ByVal firstItem As ListItem = Nothing) As List(Of Salidas_AprobacionesBRL)
            Dim Lista As List(Of Salidas_AprobacionesBRL)
            Lista = Salidas_AprobacionesBRL.CargarTodos()
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
        
        	Public Shared Function BindToListControlPorId_Salida(ByVal control As ListControl, ByVal Id_Salida As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Salidas_AprobacionesBRL)
            Dim Lista As List(Of Salidas_AprobacionesBRL)
            Lista = Salidas_AprobacionesBRL.CargarPorId_Salida(Id_Salida)
            Bind(control, Lista, firstItem)
            Return Lista
    End Function
    




        
    End Class
    
End Namespace


