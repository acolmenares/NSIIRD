Imports System.Collections.Generic

Namespace BindHelper
    
    Partial Public NotInheritable Class Declaracion_Fuentes_IngresoUIL
        
        Private Shared Sub Bind(ByVal control As ListControl, ByVal Lista As List(Of Declaracion_Fuentes_IngresoBRL), Optional ByVal firstItem As ListItem = Nothing)
            control.DataSource = Lista
            control.DataValueField = "ID"
            control.DataTextField = "ID"
            control.DataBind
            If Not firstItem Is Nothing  Then
                control.Items.Insert(0, firstItem)
            End If
        End Sub
        
        Public Shared Function BindToListControl(ByVal control As ListControl, Optional ByVal firstItem As ListItem = Nothing) As List(Of Declaracion_Fuentes_IngresoBRL)
            Dim Lista As List(Of Declaracion_Fuentes_IngresoBRL)
            Lista = Declaracion_Fuentes_IngresoBRL.CargarTodos()
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
        
        	Public Shared Function BindToListControlPorId_Declaracion(ByVal control As ListControl, ByVal Id_Declaracion As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Declaracion_Fuentes_IngresoBRL)
            Dim Lista As List(Of Declaracion_Fuentes_IngresoBRL)
            Lista = Declaracion_Fuentes_IngresoBRL.CargarPorId_Declaracion(Id_Declaracion)
            Bind(control, Lista, firstItem)
            Return Lista
    End Function
    


	Public Shared Function BindToListControlPorId_Fuentes_Ingreso(ByVal control As ListControl, ByVal Id_Fuentes_Ingreso As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Declaracion_Fuentes_IngresoBRL)
            Dim Lista As List(Of Declaracion_Fuentes_IngresoBRL)
            Lista = Declaracion_Fuentes_IngresoBRL.CargarPorId_Fuentes_Ingreso(Id_Fuentes_Ingreso)
            Bind(control, Lista, firstItem)
            Return Lista
    End Function
    




        
    End Class
    
End Namespace


