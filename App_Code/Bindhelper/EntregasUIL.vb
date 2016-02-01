Imports System.Collections.Generic

Namespace BindHelper
    
    Partial Public NotInheritable Class EntregasUIL
        
        Private Shared Sub Bind(ByVal control As ListControl, ByVal Lista As List(Of EntregasBRL), Optional ByVal firstItem As ListItem = Nothing)
            control.DataSource = Lista
            control.DataValueField = "ID"
            control.DataTextField = "ID"
            control.DataBind
            If Not firstItem Is Nothing  Then
                control.Items.Insert(0, firstItem)
            End If
        End Sub
        
        Public Shared Function BindToListControl(ByVal control As ListControl, Optional ByVal firstItem As ListItem = Nothing) As List(Of EntregasBRL)
            Dim Lista As List(Of EntregasBRL)
            Lista = EntregasBRL.CargarTodos()
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
        
        	Public Shared Function BindToListControlPorId_Capacidad(ByVal control As ListControl, ByVal Id_Capacidad As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of EntregasBRL)
            Dim Lista As List(Of EntregasBRL)
            Lista = EntregasBRL.CargarPorId_Capacidad(Id_Capacidad)
            Bind(control, Lista, firstItem)
            Return Lista
    End Function
    


	Public Shared Function BindToListControlPorId_Declaracion(ByVal control As ListControl, ByVal Id_Declaracion As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of EntregasBRL)
            Dim Lista As List(Of EntregasBRL)
            Lista = EntregasBRL.CargarPorId_Declaracion(Id_Declaracion)
            Bind(control, Lista, firstItem)
            Return Lista
    End Function
    


	Public Shared Function BindToListControlPorId_Producto(ByVal control As ListControl, ByVal Id_Producto As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of EntregasBRL)
            Dim Lista As List(Of EntregasBRL)
            Lista = EntregasBRL.CargarPorId_Producto(Id_Producto)
            Bind(control, Lista, firstItem)
            Return Lista
    End Function
    


	Public Shared Function BindToListControlPorId_Racion(ByVal control As ListControl, ByVal Id_Racion As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of EntregasBRL)
            Dim Lista As List(Of EntregasBRL)
            Lista = EntregasBRL.CargarPorId_Racion(Id_Racion)
            Bind(control, Lista, firstItem)
            Return Lista
    End Function
    


	Public Shared Function BindToListControlPorId_Tipo(ByVal control As ListControl, ByVal Id_Tipo As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of EntregasBRL)
            Dim Lista As List(Of EntregasBRL)
            Lista = EntregasBRL.CargarPorId_Tipo(Id_Tipo)
            Bind(control, Lista, firstItem)
            Return Lista
    End Function
    


	Public Shared Function BindToListControlPorId_Usuario_Creacion(ByVal control As ListControl, ByVal Id_Usuario_Creacion As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of EntregasBRL)
            Dim Lista As List(Of EntregasBRL)
            Lista = EntregasBRL.CargarPorId_Usuario_Creacion(Id_Usuario_Creacion)
            Bind(control, Lista, firstItem)
            Return Lista
    End Function
    


	Public Shared Function BindToListControlPorId_Usuario_Modificacion(ByVal control As ListControl, ByVal Id_Usuario_Modificacion As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of EntregasBRL)
            Dim Lista As List(Of EntregasBRL)
            Lista = EntregasBRL.CargarPorId_Usuario_Modificacion(Id_Usuario_Modificacion)
            Bind(control, Lista, firstItem)
            Return Lista
    End Function
    


	Public Shared Function BindToListControlPorId_Orden_Salida(ByVal control As ListControl, ByVal Id_Orden_Salida As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of EntregasBRL)
            Dim Lista As List(Of EntregasBRL)
            Lista = EntregasBRL.CargarPorId_Orden_Salida(Id_Orden_Salida)
            Bind(control, Lista, firstItem)
            Return Lista
    End Function
    




        
    End Class
    
End Namespace


