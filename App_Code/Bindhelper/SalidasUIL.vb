Imports System.Collections.Generic

Namespace BindHelper
    
    Partial Public NotInheritable Class SalidasUIL
        
        Private Shared Sub Bind(ByVal control As ListControl, ByVal Lista As List(Of SalidasBRL), Optional ByVal firstItem As ListItem = Nothing)
            control.DataSource = Lista
            control.DataValueField = "ID"
            control.DataTextField = "DescripcionSalida"
            control.DataBind
            If Not firstItem Is Nothing  Then
                control.Items.Insert(0, firstItem)
            End If
        End Sub
        
        Public Shared Function BindToListControl(ByVal control As ListControl, Optional ByVal firstItem As ListItem = Nothing) As List(Of SalidasBRL)
            Dim Lista As List(Of SalidasBRL)
            Lista = SalidasBRL.CargarTodos()
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Tercero(ByVal control As ListControl, ByVal Id_Tercero As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of SalidasBrl)
            Dim Lista As List(Of SalidasBrl)
            Lista = SalidasBrl.CargarPorId_Tercero(Id_Tercero)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Reg_Grupo(ByVal control As ListControl, ByVal Id_Reg_Grupo As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of SalidasBrl)
            Dim Lista As List(Of SalidasBrl)
            Lista = SalidasBrl.CargarPorId_Grupo(Id_Reg_Grupo)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Tipo_Entrega(ByVal control As ListControl, ByVal Id_Tipo_Entrega As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of SalidasBrl)
            Dim Lista As List(Of SalidasBrl)
            Lista = SalidasBrl.CargarPorId_Tipo_Entrega(Id_Tipo_Entrega)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Tipo_Salida(ByVal control As ListControl, ByVal Id_Tipo_Salida As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of SalidasBrl)
            Dim Lista As List(Of SalidasBrl)
            Lista = SalidasBrl.CargarPorId_Tipo_Salida(Id_Tipo_Salida)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Bodega(ByVal control As ListControl, ByVal Id_Bodega As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of SalidasBrl)
            Dim Lista As List(Of SalidasBrl)
            Lista = SalidasBrl.CargarPorId_Bodega(Id_Bodega)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Regional(ByVal control As ListControl, ByVal Id_Regional As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of SalidasBrl)
            Dim Lista As List(Of SalidasBRL)
            Lista = SalidasBRL.CargarPorId_Regional(Id_Regional)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Usuario_Creacion(ByVal control As ListControl, ByVal Id_Usuario_Creacion As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of SalidasBrl)
            Dim Lista As List(Of SalidasBrl)
            Lista = SalidasBrl.CargarPorId_Usuario_Creacion(Id_Usuario_Creacion)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Usuario_Modificacion(ByVal control As ListControl, ByVal Id_Usuario_Modificacion As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of SalidasBrl)
            Dim Lista As List(Of SalidasBrl)
            Lista = SalidasBrl.CargarPorId_Usuario_Modificacion(Id_Usuario_Modificacion)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

    End Class
    
End Namespace


