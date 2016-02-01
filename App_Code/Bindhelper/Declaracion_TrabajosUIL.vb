Imports System.Collections.Generic

Namespace BindHelper
    
    Partial Public NotInheritable Class Declaracion_TrabajosUIL
        
        Private Shared Sub Bind(ByVal control As ListControl, ByVal Lista As List(Of Declaracion_TrabajosBRL), Optional ByVal firstItem As ListItem = Nothing)
            control.DataSource = Lista
            control.DataValueField = "ID"
            control.DataTextField = "ID"
            control.DataBind
            If Not firstItem Is Nothing  Then
                control.Items.Insert(0, firstItem)
            End If
        End Sub
        
        Public Shared Function BindToListControl(ByVal control As ListControl, Optional ByVal firstItem As ListItem = Nothing) As List(Of Declaracion_TrabajosBRL)
            Dim Lista As List(Of Declaracion_TrabajosBRL)
            Lista = Declaracion_TrabajosBRL.CargarTodos()
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
        
        	Public Shared Function BindToListControlPorId_Declaracion(ByVal control As ListControl, ByVal Id_Declaracion As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Declaracion_TrabajosBRL)
            Dim Lista As List(Of Declaracion_TrabajosBRL)
            Lista = Declaracion_TrabajosBRL.CargarPorId_Declaracion(Id_Declaracion)
            Bind(control, Lista, firstItem)
            Return Lista
    End Function
    


	Public Shared Function BindToListControlPorId_Tipo_Trabajo(ByVal control As ListControl, ByVal Id_Tipo_Trabajo As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Declaracion_TrabajosBRL)
            Dim Lista As List(Of Declaracion_TrabajosBRL)
            Lista = Declaracion_TrabajosBRL.CargarPorId_Tipo_Trabajo(Id_Tipo_Trabajo)
            Bind(control, Lista, firstItem)
            Return Lista
    End Function
    




        
    End Class
    
End Namespace


