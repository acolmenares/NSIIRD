Imports System.Collections.Generic

Namespace BindHelper
    
    Partial Public NotInheritable Class DeclaracionUIL
        
        Private Shared Sub Bind(ByVal control As ListControl, ByVal Lista As List(Of DeclaracionBRL), Optional ByVal firstItem As ListItem = Nothing)
            control.DataSource = Lista
            control.DataValueField = "ID"
            control.DataTextField = "ID"
            control.DataBind
            If Not firstItem Is Nothing  Then
                control.Items.Insert(0, firstItem)
            End If
        End Sub
        
        Public Shared Function BindToListControl(ByVal control As ListControl, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBRL)
            Dim Lista As List(Of DeclaracionBRL)
            Lista = DeclaracionBRL.CargarTodos()
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
        
        	Public Shared Function BindToListControlPorId_Aplico_Reparaciones(ByVal control As ListControl, ByVal Id_Aplico_Reparaciones As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBRL)
            Dim Lista As List(Of DeclaracionBRL)
            Lista = DeclaracionBRL.CargarPorId_Aplico_Reparaciones(Id_Aplico_Reparaciones)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Condicion_Especial(ByVal control As ListControl, ByVal Id_Condicion_Especial As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Condicion_Especial(Id_Condicion_Especial)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Enfermedad(ByVal control As ListControl, ByVal Id_Enfermedad As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Enfermedad(Id_Enfermedad)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Entidad_Legal(ByVal control As ListControl, ByVal Id_Entidad_Legal As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Entidad_Legal(Id_Entidad_Legal)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Esta_Trabajando(ByVal control As ListControl, ByVal Id_Esta_Trabajando As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Esta_Trabajando(Id_Esta_Trabajando)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Estado_Aplicacion(ByVal control As ListControl, ByVal Id_Estado_Aplicacion As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Estado_Aplicacion(Id_Estado_Aplicacion)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Estatus_Aplicacion_Despues(ByVal control As ListControl, ByVal Id_Estatus_Aplicacion_Despues As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Estatus_Aplicacion_Despues(Id_Estatus_Aplicacion_Despues)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Explicacion_Retorno(ByVal control As ListControl, ByVal Id_Explicacion_Retorno As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Explicacion_Retorno(Id_Explicacion_Retorno)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Fuente(ByVal control As ListControl, ByVal Id_Fuente As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Fuente(Id_Fuente)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Ha_Declarado_Antes(ByVal control As ListControl, ByVal Id_Ha_Declarado_Antes As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Ha_Declarado_Antes(Id_Ha_Declarado_Antes)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Ha_Muerto_Alguien(ByVal control As ListControl, ByVal Id_Ha_Muerto_Alguien As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Ha_Muerto_Alguien(Id_Ha_Muerto_Alguien)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Ha_Recibido_Ayuda(ByVal control As ListControl, ByVal Id_Ha_Recibido_Ayuda As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Ha_Recibido_Ayuda(Id_Ha_Recibido_Ayuda)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Ha_Redibido_Ayuda_Despues(ByVal control As ListControl, ByVal Id_Ha_Redibido_Ayuda_Despues As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Ha_Redibido_Ayuda_Despues(Id_Ha_Redibido_Ayuda_Despues)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Ha_Regresado(ByVal control As ListControl, ByVal Id_Ha_Regresado As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Ha_Regresado(Id_Ha_Regresado)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Llegada_Golpes(ByVal control As ListControl, ByVal Id_Llegada_Golpes As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Llegada_Golpes(Id_Llegada_Golpes)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Llegada_Golpes_Miembro(ByVal control As ListControl, ByVal Id_Llegada_Golpes_Miembro As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Llegada_Golpes_Miembro(Id_Llegada_Golpes_Miembro)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Llegada_Golpes_Usted(ByVal control As ListControl, ByVal Id_Llegada_Golpes_Usted As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Llegada_Golpes_Usted(Id_Llegada_Golpes_Usted)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Llegada_Insultos(ByVal control As ListControl, ByVal Id_Llegada_Insultos As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Llegada_Insultos(Id_Llegada_Insultos)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Llegada_Insultos_Miembro(ByVal control As ListControl, ByVal Id_Llegada_Insultos_Miembro As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Llegada_Insultos_Miembro(Id_Llegada_Insultos_Miembro)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Llegada_Insultos_Usted(ByVal control As ListControl, ByVal Id_Llegada_Insultos_Usted As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Llegada_Insultos_Usted(Id_Llegada_Insultos_Usted)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Llegada_Sexual(ByVal control As ListControl, ByVal Id_Llegada_Sexual As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Llegada_Sexual(Id_Llegada_Sexual)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Llegada_Sexual_Miembro(ByVal control As ListControl, ByVal Id_Llegada_Sexual_Miembro As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Llegada_Sexual_Miembro(Id_Llegada_Sexual_Miembro)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Llegada_Sexual_Usted(ByVal control As ListControl, ByVal Id_Llegada_Sexual_Usted As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Llegada_Sexual_Usted(Id_Llegada_Sexual_Usted)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Motivo_Muerte(ByVal control As ListControl, ByVal Id_Motivo_Muerte As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Motivo_Muerte(Id_Motivo_Muerte)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Motivo_No_Aplico(ByVal control As ListControl, ByVal Id_Motivo_No_Aplico As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Motivo_No_Aplico(Id_Motivo_No_Aplico)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Municipio_Expulsor(ByVal control As ListControl, ByVal Id_Municipio_Expulsor As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Municipio_Expulsor(Id_Municipio_Expulsor)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Oido_Mesa_Desplazados(ByVal control As ListControl, ByVal Id_Oido_Mesa_Desplazados As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Oido_Mesa_Desplazados(Id_Oido_Mesa_Desplazados)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Parentesco_Desaparecido(ByVal control As ListControl, ByVal Id_Parentesco_Desaparecido As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Parentesco_Desaparecido(Id_Parentesco_Desaparecido)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Parentesco_Muerte(ByVal control As ListControl, ByVal Id_Parentesco_Muerte As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Parentesco_Muerte(Id_Parentesco_Muerte)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Pertenece_Asociacion(ByVal control As ListControl, ByVal Id_Pertenece_Asociacion As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Pertenece_Asociacion(Id_Pertenece_Asociacion)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Razon_No_Aplico(ByVal control As ListControl, ByVal Id_Razon_No_Aplico As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Razon_No_Aplico(Id_Razon_No_Aplico)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Reporto(ByVal control As ListControl, ByVal Id_Reporto As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Reporto(Id_Reporto)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Retornaria(ByVal control As ListControl, ByVal Id_Retornaria As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Retornaria(Id_Retornaria)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Tiene_Desaparecido(ByVal control As ListControl, ByVal Id_Tiene_Desaparecido As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Tiene_Desaparecido(Id_Tiene_Desaparecido)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
    
        Public Shared Function BindToListControlPorId_Velar_Enterrar(ByVal control As ListControl, ByVal Id_Velar_Enterrar As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Velar_Enterrar(Id_Velar_Enterrar)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function

        Public Shared Function BindToListControlPorId_Solicito_Ayuda(ByVal control As ListControl, ByVal Id_Solicito_Ayuda As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of DeclaracionBrl)
            Dim Lista As List(Of DeclaracionBrl)
            Lista = DeclaracionBrl.CargarPorId_Solicito_Ayuda(Id_Solicito_Ayuda)
            Bind(control, Lista, firstItem)
            Return Lista
        End Function


    End Class
    
End Namespace


