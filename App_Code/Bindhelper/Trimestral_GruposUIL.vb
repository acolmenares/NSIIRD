Imports System.Collections.Generic

Namespace BindHelper
    
    Partial Public NotInheritable Class Trimestral_GruposUIL
        
        Private Shared Sub Bind(ByVal control As ListControl, ByVal Lista As List(Of Trimestral_GruposBRL), Optional ByVal firstItem As ListItem = Nothing)
            control.DataSource = Lista
            control.DataValueField = "ID"
            control.DataTextField = "NombreGrupo"
            control.DataBind
            If Not firstItem Is Nothing  Then
                control.Items.Insert(0, firstItem)
            End If
        End Sub
        
        Public Shared Function BindToListControl(ByVal control As ListControl, Optional ByVal firstItem As ListItem = Nothing) As List(Of Trimestral_GruposBRL)
            Dim Lista As List(Of Trimestral_GruposBRL)
            Lista = Trimestral_GruposBRL.CargarTodos()
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
        
        	Public Shared Function BindToListControlPorId_Grupo(ByVal control As ListControl, ByVal Id_Grupo As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Trimestral_GruposBRL)
            Dim Lista As List(Of Trimestral_GruposBRL)
            Lista = Trimestral_GruposBRL.CargarPorId_Grupo(Id_Grupo)
            Bind(control, Lista, firstItem)
            Return Lista
    End Function
    
        Public Shared Function BindToListControlPorId_Trimestral(ByVal control As ListControl, ByVal Id_Trimestral As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Trimestral_GruposBrl)
            Dim Lista As List(Of Trimestral_GruposBrl)
            Lista = Trimestral_GruposBrl.CargarPorId_Trimestral(Id_Trimestral)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    End Class
    
End Namespace


