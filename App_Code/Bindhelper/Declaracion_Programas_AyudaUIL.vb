Imports System.Collections.Generic

Namespace BindHelper
    
    Partial Public NotInheritable Class Declaracion_Programas_AyudaUIL
        
        Private Shared Sub Bind(ByVal control As ListControl, ByVal Lista As List(Of Declaracion_Programas_AyudaBRL), Optional ByVal firstItem As ListItem = Nothing)
            control.DataSource = Lista
            control.DataValueField = "ID"
            control.DataTextField = "ID"
            control.DataBind
            If Not firstItem Is Nothing  Then
                control.Items.Insert(0, firstItem)
            End If
        End Sub
        
        Public Shared Function BindToListControl(ByVal control As ListControl, Optional ByVal firstItem As ListItem = Nothing) As List(Of Declaracion_Programas_AyudaBRL)
            Dim Lista As List(Of Declaracion_Programas_AyudaBRL)
            Lista = Declaracion_Programas_AyudaBRL.CargarTodos()
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
        
        	Public Shared Function BindToListControlPorId_Declaracion(ByVal control As ListControl, ByVal Id_Declaracion As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Declaracion_Programas_AyudaBRL)
            Dim Lista As List(Of Declaracion_Programas_AyudaBRL)
            Lista = Declaracion_Programas_AyudaBRL.CargarPorId_Declaracion(Id_Declaracion)
            Bind(control, Lista, firstItem)
            Return Lista
    End Function
    


	Public Shared Function BindToListControlPorId_Programa_Ayuda(ByVal control As ListControl, ByVal Id_Programa_Ayuda As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Declaracion_Programas_AyudaBRL)
            Dim Lista As List(Of Declaracion_Programas_AyudaBRL)
            Lista = Declaracion_Programas_AyudaBRL.CargarPorId_Programa_Ayuda(Id_Programa_Ayuda)
            Bind(control, Lista, firstItem)
            Return Lista
    End Function
    




        
    End Class
    
End Namespace


