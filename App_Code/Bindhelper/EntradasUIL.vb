Imports System.Collections.Generic

Namespace BindHelper
    
    Partial Public NotInheritable Class EntradasUIL
        
        Private Shared Sub Bind(ByVal control As ListControl, ByVal Lista As List(Of EntradasBRL), Optional ByVal firstItem As ListItem = Nothing)
            control.DataSource = Lista
            control.DataValueField = "ID"
            control.DataTextField = "Nombre_Entrego"
            control.DataBind
            If Not firstItem Is Nothing  Then
                control.Items.Insert(0, firstItem)
            End If
        End Sub
        
        Public Shared Function BindToListControl(ByVal control As ListControl, Optional ByVal firstItem As ListItem = Nothing) As List(Of EntradasBRL)
            Dim Lista As List(Of EntradasBRL)
            Lista = EntradasBRL.CargarTodos()
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
        
        Public Shared Function BindToListControlPorId_Tercero(ByVal control As ListControl, ByVal Id_Tercero As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of EntradasBrl)
            Dim Lista As List(Of EntradasBrl)
            Lista = EntradasBrl.CargarPorId_Tercero(Id_Tercero)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Usuario_Recibio(ByVal control As ListControl, ByVal Id_Usuario_Recibio As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of EntradasBrl)
            Dim Lista As List(Of EntradasBrl)
            Lista = EntradasBrl.CargarPorId_Usuario_Recibio(Id_Usuario_Recibio)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Regional(ByVal control As ListControl, ByVal Id_Regional As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of EntradasBrl)
            Dim Lista As List(Of EntradasBrl)
            Lista = EntradasBrl.CargarPorId_Regional(Id_Regional)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Tipo_Entrada(ByVal control As ListControl, ByVal Id_Tipo_Entrada As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of EntradasBrl)
            Dim Lista As List(Of EntradasBrl)
            Lista = EntradasBrl.CargarPorId_Tipo_Entrada(Id_Tipo_Entrada)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

	Public Shared Function BindToListControlPorId_Usuario_Creacion(ByVal control As ListControl, ByVal Id_Usuario_Creacion As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of EntradasBRL)
            Dim Lista As List(Of EntradasBRL)
            Lista = EntradasBRL.CargarPorId_Usuario_Creacion(Id_Usuario_Creacion)
            Bind(control, Lista, firstItem)
            Return Lista
    End Function
    
        Public Shared Function BindToListControlPorId_Usuario_Modificacion(ByVal control As ListControl, ByVal Id_Usuario_Modificacion As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of EntradasBrl)
            Dim Lista As List(Of EntradasBrl)
            Lista = EntradasBrl.CargarPorId_Usuario_Modificacion(Id_Usuario_Modificacion)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
    End Class
    
End Namespace


