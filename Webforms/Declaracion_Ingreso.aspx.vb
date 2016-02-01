Imports ingNovar.Utilidades2
Imports System.Collections.Generic

Partial Class WebForms_Declaracion_Ingreso
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        Dim objper_perfil As New SeguridadUsuarios.Permisos_PerfilBrl
        Dim objper_usuario As New SeguridadUsuarios.Permisos_UsuarioBrl
        '
        ' Ingresa Primero aca
        ' Validamos la seguridad
        '
        ' Perfil
        Dim objusuario As SeguridadUsuarios.UsuariosBrl
        objusuario = SeguridadUsuarios.UsuariosBrl.CargarPorID(CType(Session("IdUsuario"), Integer))
        If objusuario Is Nothing Then
            Response.Redirect(strPaginaError)
            Exit Sub
        End If
        ' Pagina

        Dim objpagina As SeguridadUsuarios.PaginasBrl
        objpagina = SeguridadUsuarios.PaginasBrl.CargarPorURL(Request.FilePath)
        If objpagina Is Nothing Then
            Response.Redirect(strPaginaError)
            Exit Sub
        End If

        ' Permisos por Perfil

        objper_perfil = SeguridadUsuarios.Usuarios.EstadoPerPagina(objusuario.Id_Perfil, objpagina.ID)
        objper_usuario = SeguridadUsuarios.Usuarios.EstadoPerUsuario(objusuario.ID, objpagina.ID)

        If objper_perfil Is Nothing And objper_usuario Is Nothing Then
            Response.Redirect(strPaginaError)
            Exit Sub
        End If

        ' En alguno de los dos hay permisos
        ' Hay datos en la pagina de perfiles, se inicia la validacion de datos
        '
        If objper_perfil IsNot Nothing Then
            If objper_perfil.Pver = False Or objper_perfil.Pconsultar = False Then
                Response.Redirect(strPaginaError)
                Exit Sub
            End If

            ' asignando los permisos

            If Request.QueryString.Item("Id") > 0 Then  ' va a editar
                btnGuardar.Enabled = objper_perfil.Peditar
                btnGuardarOtro.Enabled = objper_perfil.Pcrear
            Else
                btnGuardar.Enabled = objper_perfil.Pcrear
                btnGuardarOtro.Enabled = objper_perfil.Pcrear
            End If
            btnEliminar.Enabled = objper_perfil.Peliminar

            ' asignando los permisos

            btn_nuevo.Enabled = objper_perfil.Pcrear
            ddl_Regional.Enabled = objper_perfil.Pvertodo
        End If

        If objper_usuario IsNot Nothing Then
            If objper_usuario.Pver = False Or objper_usuario.Pconsultar = False Then
                Response.Redirect(strPaginaError)
                Exit Sub
            End If

            ' asignando los permisos

            If Request.QueryString.Item("Id") > 0 Then  ' va a editar
                btnGuardar.Enabled = objper_usuario.Peditar
                btnGuardarOtro.Enabled = objper_usuario.Pcrear
            Else
                btnGuardar.Enabled = objper_usuario.Pcrear
                btnGuardarOtro.Enabled = objper_usuario.Pcrear
            End If
            btnEliminar.Enabled = objper_usuario.Peliminar
            '
            btn_nuevo.Enabled = objper_usuario.Pcrear
            ddl_Regional.Enabled = objper_usuario.Pvertodo
        End If

        ' Definiendo el dato de la regional
        ddl_Regional.SelectedValue = SeguridadUsuarios.Usuarios.RegionalUsuario(CType(Session("IdUsuario"), Integer))

    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If IsPostBack Then Exit Sub

        If Session("IdUsuario") Is Nothing Then
            Session.RemoveAll()
            Response.Redirect("../login.aspx")
            Exit Sub
        End If

        Dim lblidUsuario As Label
        lblidUsuario = Master.FindControl("lblidusuario")
        lblidUsuario.Text = Session("IdUsuario")

        Dim LblNombreUsuario As Label
        LblNombreUsuario = Master.FindControl("LblNombreUsuario")
        LblNombreUsuario.Text = Session("NombreUsuario")

        Dim Lbl_regional As Label
        Lbl_regional = Master.FindControl("Lbl_regional")
        Lbl_regional.Text = Session("NombreRegional")

        Dim Lbl_usuario As Label
        Lbl_usuario = Master.FindControl("Lbl_usuario")
        Lbl_usuario.Text = Session("LoginUsuario")

        Dim Lbl_perfil As Label
        Lbl_perfil = Master.FindControl("Lbl_perfil")
        Lbl_perfil.Text = Session("NombrePerfil")

        If Request.QueryString.Item("Mensaje") = 1 Then
            lblMensaje.Text = "Operación exitosa"
            lblMensaje.Visible = True
        End If

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Fuente, 6, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(Lst_Tipos_Contacto, 19)
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_TipoIdentificacion, 1, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_regional, 72, New ListItem("Seleccione", 0))
        ddl_regional_SelectedIndexChanged(Nothing, Nothing)
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_genero, 2, New ListItem("Seleccione", 0))
        'BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_LugarFuente, 73, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Enlinea, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_tipodeclarante, 76, New ListItem("Seleccione", 0))

        pnl_final.Visible = True
        If Request.QueryString.Item("Editar") = 1 Then
            Dim objDeclaracion As DeclaracionBrl = DeclaracionBrl.CargarPorID(Request.QueryString.Item("ID"))

            If objDeclaracion Is Nothing Then
                lblMensaje.Text = "Registro no existe"
                lblMensaje.Visible = True
                Exit Sub
            End If

            rdpFechaDeclaracion.SelectedDate = objDeclaracion.Fecha_Declaracion
            rdpFechaRadicacion.SelectedDate = objDeclaracion.Fecha_Radicacion

            If ddl_Fuente.Items.FindByValue(objDeclaracion.Id_Fuente) IsNot Nothing Then ddl_Fuente.SelectedValue = objDeclaracion.Id_Fuente
            If ddl_regional.Items.FindByValue(objDeclaracion.Id_Regional) IsNot Nothing Then ddl_regional.SelectedValue = objDeclaracion.Id_Regional
            Txt_NinosMenores.Text = objDeclaracion.Menores_Ninos
            Txt_Gestantes.Text = objDeclaracion.Gestantes
            Txt_RestoNucleo.Text = objDeclaracion.Resto_Nucleo
            txt_Observaciones.Text = objDeclaracion.Observaciones
            If ddl_LugarFuente.Items.FindByValue(objDeclaracion.Id_Lugar_Fuente) IsNot Nothing Then ddl_LugarFuente.SelectedValue = objDeclaracion.Id_Lugar_Fuente
            If ddl_Enlinea.Items.FindByValue(objDeclaracion.Id_EnLinea) IsNot Nothing Then ddl_Enlinea.SelectedValue = objDeclaracion.Id_EnLinea
            rdpFechaDesplazamiento.SelectedDate = objDeclaracion.Fecha_Desplazamiento
            Txt_Motivo.Text = objDeclaracion.Motivo_Desplazamiento
            Txt_Numero_Declaracion.Text = objDeclaracion.Numero_Declaracion
            ddl_tipodeclarante.SelectedValue = objDeclaracion.Tipo_Declaracion
            rdb_Horario.SelectedValue = objDeclaracion.Horario

            rdb_Declarante_SelectedIndexChanged(Nothing, Nothing)


            ' cargas los datos de la persona
            Lst_Tipos_Contacto_Persona.Items.Clear()
            Dim objpersona As PersonasBrl = PersonasBrl.CargarPorId_DeclaracionYDeclarante(Request.QueryString.Item("Id"))
            If objpersona IsNot Nothing Then

                txt_PrimerNombre.Text = objpersona.Primer_Nombre
                txt_SegundoNombre.Text = objpersona.Segundo_Nombre
                Txt_PrimerApellido.Text = objpersona.Primer_Apellido
                txt_SegundoApellido.Text = objpersona.Segundo_Apellido
                ddl_TipoIdentificacion.SelectedValue = objpersona.Id_Tipo_Identificacion
                txt_Identificacion.Text = objpersona.Identificacion
                ddl_genero.SelectedValue = objpersona.Id_Genero
                rdpFechaNacimiento.SelectedDate = objpersona.Fecha_Nacimiento

                Dim objcontactos As List(Of Personas_ContactosBrl)
                objcontactos = Personas_ContactosBrl.CargarPorId_Persona(objpersona.ID)
                For Each fila As Personas_ContactosBrl In objcontactos
                    Me.Lst_Tipos_Contacto_Persona.Items.Add(New ListItem(fila.SubTablasTipoContacto.Descripcion & " : " & fila.Descripcion, fila.Id_Tipo_Contacto))
                Next
            End If

            For Each estado As Declaracion_EstadosBrl In objDeclaracion.Declaracion_Estados
                If (estado.Id_Tipo_Estado = 4038) Or (estado.Id_Tipo_Estado = 4039) Then
                    If estado.Programa.Id_Estado <> 213 Then
                        pnl_final.Visible = False
                    End If
                End If

            Next
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Validate("RI")
        If Not IsValid Then Exit Sub
        If validarAdicionales() Then Exit Sub

        If ValidarRegistro() Then
            lblMensaje.Text = "El Número de Declaración ya esta utilizado. Verifique por favor"
            lblMensaje.Visible = True
            Exit Sub
        End If


        Dim ID As Int32
        lblMensaje.Visible = False
        Try
            ID = Grabar()
            Response.Redirect("Declaracion_Ingreso.aspx?Editar=1&Mensaje=1&ID=" & ID)
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Public Function validarAdicionales() As Boolean
        '
        ' Validar las fechas
        '
        Dim wvalidar As Boolean = False
        If ddl_tipodeclarante.SelectedValue = 921 Then
            ' declarante
            If rdpFechaDeclaracion.DbSelectedDate < rdpFechaDesplazamiento.DbSelectedDate Then
                lblMensaje.Text = "Fecha de Declaración no puede ser menor a fecha de desplazamiento.!!!"
                wvalidar = True
            End If
            If rdpFechaRadicacion.DbSelectedDate < rdpFechaDesplazamiento.DbSelectedDate Then
                lblMensaje.Text = "Fecha de Radicación no puede ser menor a fecha de desplazamiento.!!!"
                wvalidar = True
            End If
            If rdpFechaRadicacion.DbSelectedDate < rdpFechaDeclaracion.DbSelectedDate Then
                lblMensaje.Text = "Fecha de Radicación no puede ser menor a fecha de declaración.!!!"
                wvalidar = True
            End If
        End If
        lblMensaje.Visible = True
        Return wvalidar
    End Function

    Private Sub btnGuardarOtro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarOtro.Click
        Validate("RI")
        If Not IsValid Then Exit Sub
        If validarAdicionales() Then Exit Sub
        lblMensaje.Visible = False

        If ValidarRegistro() Then
            lblMensaje.Text = "El Número de Declaración ya esta utilizado. Verifique por favor"
            lblMensaje.Visible = True
            Exit Sub
        End If

        Try
            Grabar()
            Response.Redirect("Declaracion_Ingreso.aspx?Mensaje=1")
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Private Function ValidarRegistro() As Boolean
        Dim wrpta As Boolean = False
        Dim Listdeclaracion As List(Of DeclaracionBrl) = DeclaracionBrl.CargarPorNumero_Declaracion(Txt_Numero_Declaracion.Text)
        If Listdeclaracion.Count > 0 Then
            If Listdeclaracion.Item(0).ID <> Request.QueryString.Item("Id") Then
                wrpta = True
            End If
        End If
        Return wrpta
    End Function

    Private Function Grabar() As Int32

        Dim objDeclaracion As DeclaracionBrl
        Dim objpersona As PersonasBrl

        If Request.QueryString.Item("Editar") = 1 Then
            objDeclaracion = DeclaracionBrl.CargarPorID(Request.QueryString.Item("ID"))
            objpersona = PersonasBrl.CargarPorId_DeclaracionYDeclarante(Request.QueryString.Item("ID"))
            objDeclaracion.Fecha_Modificacion = Now
            objDeclaracion.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text
            objpersona.Fecha_Modificacion = Now
            objpersona.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text

        Else
            objDeclaracion = New DeclaracionBrl
            objDeclaracion.Fecha_Ingreso_Registro = Today
            objDeclaracion.Fecha_Creacion = Now
            objDeclaracion.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
            objpersona = New PersonasBrl
            objpersona.Fecha_Creacion = Now
            objpersona.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
        End If

        objDeclaracion.Id_Fuente = ddl_Fuente.SelectedValue
        Try
            objDeclaracion.Fecha_Declaracion = rdpFechaDeclaracion.DbSelectedDate
        Catch ex As Exception
            objDeclaracion.Fecha_Declaracion = Nothing
        End Try

        objDeclaracion.Fecha_Valoracion = Nothing
        objDeclaracion.Id_Regional = ddl_regional.SelectedValue
        objDeclaracion.Motivo_Desplazamiento = Txt_Motivo.Text
        objDeclaracion.Observaciones = txt_Observaciones.Text
        objDeclaracion.Horario = rdb_Horario.SelectedValue
        objDeclaracion.Tipo_Declaracion = ddl_tipodeclarante.SelectedValue
        objDeclaracion.Id_Lugar_Fuente = ddl_LugarFuente.SelectedValue
        objDeclaracion.Id_EnLinea = ddl_Enlinea.SelectedValue
        objDeclaracion.Numero_Declaracion = Txt_Numero_Declaracion.Text

        If Txt_NinosMenores.Text.Trim = "" Then
            objDeclaracion.Menores_Ninos = 0
        Else
            objDeclaracion.Menores_Ninos = Txt_NinosMenores.Text
        End If

        If Txt_Gestantes.Text.Trim = "" Then
            objDeclaracion.Gestantes = 0
        Else
            objDeclaracion.Gestantes = Txt_Gestantes.Text
        End If

        If Txt_RestoNucleo.Text.Trim = "" Then
            objDeclaracion.Resto_Nucleo = 0
        Else
            objDeclaracion.Resto_Nucleo = Txt_RestoNucleo.Text
        End If
        Try
            objDeclaracion.Fecha_Desplazamiento = rdpFechaDesplazamiento.DbSelectedDate
        Catch ex As Exception
            objDeclaracion.Fecha_Desplazamiento = Nothing
        End Try

        Try
            objDeclaracion.Fecha_Radicacion = rdpFechaRadicacion.DbSelectedDate
        Catch ex As Exception
            objDeclaracion.Fecha_Radicacion = Nothing
        End Try

        objpersona.Primer_Nombre = txt_PrimerNombre.Text
        objpersona.Segundo_Nombre = txt_SegundoNombre.Text
        objpersona.Primer_Apellido = Txt_PrimerApellido.Text
        objpersona.Segundo_Apellido = txt_SegundoApellido.Text
        objpersona.Id_Tipo_Identificacion = ddl_TipoIdentificacion.SelectedValue
        objpersona.Identificacion = txt_Identificacion.Text

        Try
            objpersona.Fecha_Nacimiento = rdpFechaNacimiento.DbSelectedDate
        Catch ex As Exception
            objpersona.Fecha_Nacimiento = Nothing
        End Try

        objpersona.Id_Genero = ddl_genero.SelectedValue
        objpersona.Tipo = "D"

        Dim listpersonas As New List(Of PersonasBrl)
        Dim objcontactos As List(Of Personas_ContactosBrl) = Personas_ContactosBrl.CargarPorId_Persona(objpersona.ID)
        For Each fila As Personas_ContactosBrl In objcontactos
            fila.Eliminar()
        Next

        ' cargando los contactos
        Dim wcadena As String
        Dim objcontacto As New Personas_ContactosBrl
        For Each item As ListItem In Me.Lst_Tipos_Contacto_Persona.Items
            objcontacto = New Personas_ContactosBrl
            objcontacto.Activo = False
            objcontacto.Id_Tipo_Contacto = item.Value
            wcadena = item.Text
            wcadena = item.Text.Substring(wcadena.LastIndexOf(":") + 2, (wcadena.Length - (wcadena.LastIndexOf(":") + 2)))
            objcontacto.Descripcion = wcadena
            objcontacto.Fecha_Creacion = Now
            objcontacto.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
            objcontactos.Add(objcontacto)
        Next

        objpersona.Personas_Contactos = objcontactos
        listpersonas.Add(objpersona)

        objDeclaracion.Personas = listpersonas
        objDeclaracion.Guardar()
        Return objDeclaracion.ID

    End Function

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim objDeclaracion As DeclaracionBrl

        Try
            If Request.QueryString.Item("Editar") = 1 Then
                objDeclaracion = DeclaracionBrl.CargarPorID(Request.QueryString.Item("ID"))
                objDeclaracion.Eliminar()
                Response.Redirect("Declaracion.aspx?Mensaje=1")
            End If
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton1.Click
        If Len(txtvalor.Text) <> 0 Then
            If Lst_Tipos_Contacto.SelectedValue <> 0 Then
                Lst_Tipos_Contacto_Persona.Items.Add(New ListItem(Lst_Tipos_Contacto.SelectedItem.Text.Trim & " : " & txtvalor.Text.Trim, Lst_Tipos_Contacto.SelectedValue))
                txtvalor.Text = ""
                Lst_Tipos_Contacto.SelectedIndex = -1
                Lst_Tipos_Contacto.ClearSelection()
            End If
        Else
            lblMensaje.Text = "No hay dato de descripción del tipo de contacto"
            lblMensaje.Visible = True
            lblMensaje.ForeColor = Drawing.Color.Red
        End If
    End Sub

    Protected Sub LinkButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton2.Click
        ' para retirar un registro de la base de contactos
        Lst_Tipos_Contacto_Persona.Items.RemoveAt(Lst_Tipos_Contacto_Persona.SelectedIndex)
        Lst_Tipos_Contacto_Persona.ClearSelection()
    End Sub

    Protected Sub rdb_Declarante_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_tipodeclarante.SelectedIndexChanged

        Select Case ddl_tipodeclarante.SelectedValue
            Case Is = 922
                rdpFechaDeclaracion.Enabled = False
                rdpFechaDeclaracion.SelectedDate = Nothing
                rfv_Fecha_Declaracion.Enabled = False
                rdpFechaDeclaracion.Enabled = False
                ddl_Fuente.Enabled = False
                ddl_Fuente.SelectedValue = 0
                rev_Fuente.Enabled = False
                rdpFechaDesplazamiento.Enabled = False
                rdpFechaDesplazamiento.SelectedDate = Nothing
                rfv_Fecha_Desplazamiento.Enabled = False
                ddl_LugarFuente.Enabled = False
                ddl_LugarFuente.SelectedValue = 0
                rev_LugarFuente.Enabled = False
                ddl_Enlinea.Enabled = False
                ddl_Enlinea.SelectedValue = 0
                rev_enlinea.Enabled = False
                Txt_Numero_Declaracion.Enabled = False
                Txt_Numero_Declaracion.Text = ""
                rfv_Numero_Declaracion.Enabled = False
            Case Is = 921
                rdpFechaDeclaracion.Enabled = True
                rfv_Fecha_Declaracion.Enabled = True
                ddl_Fuente.Enabled = True
                rev_Fuente.Enabled = True
                rdpFechaDesplazamiento.Enabled = True
                rfv_Fecha_Desplazamiento.Enabled = True
                ddl_LugarFuente.Enabled = True
                rev_LugarFuente.Enabled = True
                ddl_Enlinea.Enabled = True
                rev_enlinea.Enabled = True
                Txt_Numero_Declaracion.Enabled = True
                rfv_Numero_Declaracion.Enabled = True

            Case Is = 923
                rdpFechaDeclaracion.Enabled = False
                rdpFechaDeclaracion.SelectedDate = Nothing
                rfv_Fecha_Declaracion.Enabled = False
                rdpFechaDesplazamiento.Enabled = False
                rdpFechaDesplazamiento.SelectedDate = Nothing
                rfv_Fecha_Desplazamiento.Enabled = False
                ddl_Enlinea.Enabled = False
                ddl_Enlinea.SelectedValue = 0
                rev_enlinea.Enabled = False
                Txt_Motivo.Enabled = False
                Txt_Motivo.Text = ""
                Txt_Numero_Declaracion.Enabled = False
                Txt_Numero_Declaracion.Text = ""
                rfv_Numero_Declaracion.Enabled = False

        End Select
    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/Declaracion_IngresoList.aspx")
    End Sub

    Protected Sub btn_nuevo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_nuevo.Click
        Response.Redirect("../webforms/Declaracion_Ingreso.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        If Request.QueryString.Item("Id") > 0 Then
            Response.Redirect("../webforms/Declaracion_Ingreso.aspx?Editar=1&Id=" + Request.QueryString.Item("Id"))
        Else
            btn_nuevo_Click(sender, e)
        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_incluir.Click
        lbl73.Text = Class1.ConsultaIncluido(txt_Identificacion.Text.Trim)
    End Sub

    Protected Sub ddl_regional_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_regional.SelectedIndexChanged
        If ddl_regional.SelectedValue > 0 Then
            BindHelper.SubTablasUIL.BindToListControlPorId_TablaPadre(ddl_LugarFuente, 73, ddl_regional.SelectedValue, New ListItem("Seleccione", 0))
        Else
            BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_LugarFuente, 73, New ListItem("Seleccione", 0))
        End If
    End Sub

End Class
