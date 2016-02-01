Imports System.Collections.Generic

Namespace BindHelper
    
    Partial Public NotInheritable Class TablasUIL
        
        Private Shared Sub Bind(ByVal control As ListControl, ByVal Lista As List(Of TablasBRL), Optional ByVal firstItem As ListItem = Nothing)
            control.DataSource = Lista
            control.DataValueField = "ID"
            control.DataTextField = "Descripcion"
            control.DataBind
            If Not firstItem Is Nothing  Then
                control.Items.Insert(0, firstItem)
            End If
        End Sub
        
        Public Shared Function BindToListControl(ByVal control As ListControl, Optional ByVal firstItem As ListItem = Nothing) As List(Of TablasBRL)
            Dim Lista As List(Of TablasBRL)
            Lista = TablasBRL.CargarTodos()
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
        
        

        
    End Class
    
End Namespace


