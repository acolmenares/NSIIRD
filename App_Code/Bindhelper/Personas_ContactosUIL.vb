Imports System.Collections.Generic

Namespace BindHelper
    
    Partial Public NotInheritable Class Personas_ContactosUIL
        
        Private Shared Sub Bind(ByVal control As ListControl, ByVal Lista As List(Of Personas_ContactosBRL), Optional ByVal firstItem As ListItem = Nothing)
            control.DataSource = Lista
            control.DataValueField = "ID"
            control.DataTextField = "Descripcion"
            control.DataBind
            If Not firstItem Is Nothing  Then
                control.Items.Insert(0, firstItem)
            End If
        End Sub
        
        Public Shared Function BindToListControl(ByVal control As ListControl, Optional ByVal firstItem As ListItem = Nothing) As List(Of Personas_ContactosBRL)
            Dim Lista As List(Of Personas_ContactosBRL)
            Lista = Personas_ContactosBRL.CargarTodos()
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
        
        Public Shared Function BindToListControlPorId_Persona(ByVal control As ListControl, ByVal Id_Persona As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Personas_ContactosBrl)
            Dim Lista As List(Of Personas_ContactosBrl)
            Lista = Personas_ContactosBrl.CargarPorId_Persona(Id_Persona)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Tipo_Contacto(ByVal control As ListControl, ByVal Id_Tipo_Contacto As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Personas_ContactosBrl)
            Dim Lista As List(Of Personas_ContactosBrl)
            Lista = Personas_ContactosBrl.CargarPorId_Tipo_Contacto(Id_Tipo_Contacto)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function


        Public Shared Function BindToListControlPorId_PersonayTipo_contacto(ByVal control As ListControl, ByVal Id_Persona As Int32, ByVal Id_Tipo_Contacto As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Personas_ContactosBrl)
            Dim Lista As List(Of Personas_ContactosBrl)
            Lista = Personas_ContactosBrl.CargarPorId_PersonayTipo_contacto(Id_Persona, Id_Tipo_Contacto)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

    End Class
    
End Namespace


