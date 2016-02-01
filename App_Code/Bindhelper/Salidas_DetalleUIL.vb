Imports System.Collections.Generic

Namespace BindHelper
    
    Partial Public NotInheritable Class Salidas_DetalleUIL
        
        Private Shared Sub Bind(ByVal control As ListControl, ByVal Lista As List(Of Salidas_DetalleBRL), Optional ByVal firstItem As ListItem = Nothing)
            control.DataSource = Lista
            control.DataValueField = "ID"
            control.DataTextField = "DescripcionDetalleSalida"
            control.DataBind
            If Not firstItem Is Nothing  Then
                control.Items.Insert(0, firstItem)
            End If
        End Sub
        
        Public Shared Function BindToListControl(ByVal control As ListControl, Optional ByVal firstItem As ListItem = Nothing) As List(Of Salidas_DetalleBRL)
            Dim Lista As List(Of Salidas_DetalleBRL)
            Lista = Salidas_DetalleBRL.CargarTodos()
            Bind(control, Lista, firstItem)
            Return Lista
        End Function


        Public Shared Function BindToListControlPorId_Capacidad(ByVal control As ListControl, ByVal Id_Capacidad As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Salidas_DetalleBrl)
            Dim Lista As List(Of Salidas_DetalleBrl)
            Lista = Salidas_DetalleBrl.CargarPorId_Capacidad(Id_Capacidad)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Producto(ByVal control As ListControl, ByVal Id_Producto As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Salidas_DetalleBrl)
            Dim Lista As List(Of Salidas_DetalleBrl)
            Lista = Salidas_DetalleBrl.CargarPorId_Producto(Id_Producto)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Salida(ByVal control As ListControl, ByVal Id_Salida As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Salidas_DetalleBrl)
            Dim Lista As List(Of Salidas_DetalleBrl)
            Lista = Salidas_DetalleBrl.CargarPorId_Salida(Id_Salida)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Usuario_Creacion(ByVal control As ListControl, ByVal Id_Usuario_Creacion As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Salidas_DetalleBrl)
            Dim Lista As List(Of Salidas_DetalleBrl)
            Lista = Salidas_DetalleBrl.CargarPorId_Usuario_Creacion(Id_Usuario_Creacion)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Usuario_Modificacion(ByVal control As ListControl, ByVal Id_Usuario_Modificacion As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Salidas_DetalleBrl)
            Dim Lista As List(Of Salidas_DetalleBrl)
            Lista = Salidas_DetalleBrl.CargarPorId_Usuario_Modificacion(Id_Usuario_Modificacion)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
    End Class
    
End Namespace


