Imports System.Collections.Generic

Namespace BindHelper
    
    Partial Public NotInheritable Class PersonasUIL
        
        Private Shared Sub Bind(ByVal control As ListControl, ByVal Lista As List(Of PersonasBRL), Optional ByVal firstItem As ListItem = Nothing)
            control.DataSource = Lista
            control.DataValueField = "ID"
            control.DataTextField = "NombreCompleto"
            control.DataBind
            If Not firstItem Is Nothing  Then
                control.Items.Insert(0, firstItem)
            End If
        End Sub

        Private Shared Sub BindIdentificacion(ByVal control As ListControl, ByVal Lista As List(Of PersonasBrl), Optional ByVal firstItem As ListItem = Nothing)
            control.DataSource = Lista
            control.DataValueField = "Id"
            control.DataTextField = "DatosDeclaracion"
            control.DataBind()
            If Not firstItem Is Nothing Then
                control.Items.Insert(0, firstItem)
            End If
        End Sub

        Public Shared Function BindToListControl(ByVal control As ListControl, Optional ByVal firstItem As ListItem = Nothing) As List(Of PersonasBrl)
            Dim Lista As List(Of PersonasBrl)
            Lista = PersonasBrl.CargarTodos()
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Declaracion(ByVal control As ListControl, ByVal Id_Declaracion As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of PersonasBrl)
            Dim Lista As List(Of PersonasBrl)
            Lista = PersonasBrl.CargarPorId_Declaracion(Id_Declaracion)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Discapacitado(ByVal control As ListControl, ByVal Id_Discapacitado As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of PersonasBrl)
            Dim Lista As List(Of PersonasBrl)
            Lista = PersonasBrl.CargarPorId_Discapacitado(Id_Discapacitado)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Estudia_Actualmente(ByVal control As ListControl, ByVal Id_Estudia_Actualmente As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of PersonasBRL)
            Dim Lista As List(Of PersonasBRL)
            Lista = PersonasBRL.CargarPorId_Estudia_Actualmente(Id_Estudia_Actualmente)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Estudia_Antes(ByVal control As ListControl, ByVal Id_Estudia_Antes As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of PersonasBrl)
            Dim Lista As List(Of PersonasBrl)
            Lista = PersonasBrl.CargarPorId_Estudia_Antes(Id_Estudia_Antes)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Genero(ByVal control As ListControl, ByVal Id_Genero As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of PersonasBrl)
            Dim Lista As List(Of PersonasBrl)
            Lista = PersonasBrl.CargarPorId_Genero(Id_Genero)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Tipo_Miembro(ByVal control As ListControl, ByVal Id_Tipo_Miembro As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of PersonasBrl)
            Dim Lista As List(Of PersonasBrl)
            Lista = PersonasBrl.CargarPorId_Tipo_Miembro(Id_Tipo_Miembro)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Motivo_NoEstudio(ByVal control As ListControl, ByVal Id_Motivo_NoEstudio As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of PersonasBrl)
            Dim Lista As List(Of PersonasBrl)
            Lista = PersonasBrl.CargarPorId_Motivo_NoEstudio(Id_Motivo_NoEstudio)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Parentesco(ByVal control As ListControl, ByVal Id_Parentesco As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of PersonasBRL)
            Dim Lista As List(Of PersonasBRL)
            Lista = PersonasBRL.CargarPorId_Parentesco(Id_Parentesco)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Tipo_Identificacion(ByVal control As ListControl, ByVal Id_Tipo_Identificacion As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of PersonasBrl)
            Dim Lista As List(Of PersonasBrl)
            Lista = PersonasBrl.CargarPorId_Tipo_Identificacion(Id_Tipo_Identificacion)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Ultimo_Grado(ByVal control As ListControl, ByVal Id_Ultimo_Grado As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of PersonasBRL)
            Dim Lista As List(Of PersonasBRL)
            Lista = PersonasBRL.CargarPorId_Ultimo_Grado(Id_Ultimo_Grado)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorIdentificacionAtendidos(ByVal control As ListControl, ByVal tipo As Int32, ByVal identificacion As String, Optional ByVal firstItem As ListItem = Nothing) As List(Of PersonasBrl)
            Dim Lista As List(Of PersonasBrl)
            Lista = PersonasBrl.CargarPorIdentificacionAtendidos(tipo, identificacion)
            BindIdentificacion(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Grupo(ByVal control As ListControl, ByVal Id_Grupo As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of PersonasBrl)
            Dim Lista As List(Of PersonasBrl)
            Lista = PersonasBrl.CargarPorId_Grupo(Id_Grupo)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Programa_EntregaAdicional(ByVal control As ListControl, ByVal Id_Programa As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of PersonasBrl)
            Dim Lista As List(Of PersonasBrl)
            Lista = PersonasBrl.CargarPorId_Programa_EntregaAdicional(Id_Programa)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

    End Class
    
End Namespace


