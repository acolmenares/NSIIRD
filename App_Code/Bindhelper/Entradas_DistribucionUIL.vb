Imports System.Collections.Generic

Namespace BindHelper
    
    Partial Public NotInheritable Class Entradas_DistribucionUIL

        Private Shared Sub Bind(ByVal control As ListControl, ByVal Lista As List(Of Entradas_DistribucionBrl), Optional ByVal firstItem As ListItem = Nothing)
            control.DataSource = Lista
            control.DataValueField = "ID"
            control.DataTextField = "detalleysaldo"
            control.DataBind()
            If Not firstItem Is Nothing Then
                control.Items.Insert(0, firstItem)
            End If
        End Sub

        Public Shared Function BindToListControl(ByVal control As ListControl, Optional ByVal firstItem As ListItem = Nothing) As List(Of Entradas_DistribucionBrl)
            Dim Lista As List(Of Entradas_DistribucionBrl)
            Lista = Entradas_DistribucionBrl.CargarTodos()
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Entrada_Detalle(ByVal control As ListControl, ByVal Id_Entrada_Detalle As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Entradas_DistribucionBrl)
            Dim Lista As List(Of Entradas_DistribucionBrl)
            Lista = Entradas_DistribucionBrl.CargarPorId_Entrada_Detalle(Id_Entrada_Detalle)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Bodega(ByVal control As ListControl, ByVal Id_Bodega As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Entradas_DistribucionBrl)
            Dim Lista As List(Of Entradas_DistribucionBrl)
            Lista = Entradas_DistribucionBrl.CargarPorId_Bodega(Id_Bodega)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Capacidad(ByVal control As ListControl, ByVal Id_Capacidad As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Entradas_DistribucionBrl)
            Dim Lista As List(Of Entradas_DistribucionBrl)
            Lista = Entradas_DistribucionBrl.CargarPorId_Capacidad(Id_Capacidad)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Usuario_Creacion(ByVal control As ListControl, ByVal Id_Usuario_Creacion As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Entradas_DistribucionBrl)
            Dim Lista As List(Of Entradas_DistribucionBrl)
            Lista = Entradas_DistribucionBrl.CargarPorId_Usuario_Creacion(Id_Usuario_Creacion)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Usuario_Modificacion(ByVal control As ListControl, ByVal Id_Usuario_Modificacion As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Entradas_DistribucionBrl)
            Dim Lista As List(Of Entradas_DistribucionBrl)
            Lista = Entradas_DistribucionBrl.CargarPorId_Usuario_Modificacion(Id_Usuario_Modificacion)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_BodegayId_Producto(ByVal control As ListControl, ByVal Id_Bodega As Int32, ByVal id_producto As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Entradas_DistribucionBrl)
            Dim Lista As List(Of Entradas_DistribucionBrl)
            Lista = Entradas_DistribucionBrl.CargarPorId_BodegayId_Producto(Id_Bodega, id_producto)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

    End Class

End Namespace


