Imports System.Collections.Generic

Namespace BindHelper
    
    Partial Public NotInheritable Class ProgramacionUIL
        
        Private Shared Sub Bind(ByVal control As ListControl, ByVal Lista As List(Of ProgramacionBRL), Optional ByVal firstItem As ListItem = Nothing)
            control.DataSource = Lista
            control.DataValueField = "ID"
            control.DataTextField = "Numero"
            control.DataBind
            If Not firstItem Is Nothing  Then
                control.Items.Insert(0, firstItem)
            End If
        End Sub
        
        Public Shared Function BindToListControl(ByVal control As ListControl, Optional ByVal firstItem As ListItem = Nothing) As List(Of ProgramacionBRL)
            Dim Lista As List(Of ProgramacionBRL)
            Lista = ProgramacionBRL.CargarTodos()
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
        
        	Public Shared Function BindToListControlPorId_Estado(ByVal control As ListControl, ByVal Id_Estado As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of ProgramacionBRL)
            Dim Lista As List(Of ProgramacionBRL)
            Lista = ProgramacionBRL.CargarPorId_Estado(Id_Estado)
            Bind(control, Lista, firstItem)
            Return Lista
    End Function
    
        Public Shared Function BindToListControlPorId_Grupo(ByVal control As ListControl, ByVal Id_Grupo As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of ProgramacionBrl)
            Dim Lista As List(Of ProgramacionBrl)
            Lista = ProgramacionBrl.CargarPorId_Grupo(Id_Grupo)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

	Public Shared Function BindToListControlPorId_Regional(ByVal control As ListControl, ByVal Id_Regional As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of ProgramacionBRL)
            Dim Lista As List(Of ProgramacionBRL)
            Lista = ProgramacionBRL.CargarPorId_Regional(Id_Regional)
            Bind(control, Lista, firstItem)
            Return Lista
    End Function

        Public Shared Function BindToListControlPorId_RegionalyEstado(ByVal control As ListControl, ByVal Id_Regional As Int32, ByVal Id_Estado As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of ProgramacionBrl)
            Dim Lista As List(Of ProgramacionBrl)
            Lista = ProgramacionBrl.CargarbusquedaPorEstado(Id_Regional, 0, 0, Id_Estado)
            Bind(Control, Lista, firstItem)
            Return Lista
        End Function


        Public Shared Function BindToListControlPorId_LugarEntrega(ByVal control As ListControl, ByVal Id_LugarEntrega As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of ProgramacionBrl)
            Dim Lista As List(Of ProgramacionBrl)
            Lista = ProgramacionBrl.CargarPorId_LugarEntrega(Id_LugarEntrega)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function


    End Class
    
End Namespace


