Imports ingNovar.Utilidades2
Imports System.Collections.Generic

Partial Class WebForms_Asignaciones
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
        If objper_perfil IsNot Nothing Then
            If objper_perfil.Pver = False Or objper_perfil.Pconsultar = False Then
                Response.Redirect(strPaginaError)
                Exit Sub
            End If

            ' asignando los permisos

            If Request.QueryString.Item("Id") > 0 Then  ' va a editar
                btn_GrabarElegible.Enabled = objper_perfil.Peditar
                btn_GrabarContactado.Enabled = objper_perfil.Peditar
                btn_GrabarProgramacion.Enabled = objper_perfil.Peditar
            Else
                btn_GrabarElegible.Enabled = objper_perfil.Pcrear
                btn_GrabarContactado.Enabled = objper_perfil.Pcrear
                btn_GrabarProgramacion.Enabled = objper_perfil.Pcrear
            End If

            Rg_Listado.ClientSettings.EnablePostBackOnRowClick = objper_perfil.Peditar

        End If

        If objper_usuario IsNot Nothing Then
            If objper_usuario.Pver = False Or objper_usuario.Pconsultar = False Then
                Response.Redirect(strPaginaError)
                Exit Sub
            End If

            ' asignando los permisos

            If Request.QueryString.Item("Id") > 0 Then  ' va a editar
                btn_GrabarElegible.Enabled = objper_usuario.Peditar
                btn_GrabarContactado.Enabled = objper_usuario.Peditar
                btn_GrabarProgramacion.Enabled = objper_usuario.Peditar
            Else
                btn_GrabarElegible.Enabled = objper_usuario.Pcrear
                btn_GrabarContactado.Enabled = objper_usuario.Pcrear
                btn_GrabarProgramacion.Enabled = objper_usuario.Pcrear
            End If

            Rg_Listado.ClientSettings.EnablePostBackOnRowClick = objper_usuario.Peliminar
        End If

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

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(Lst_Tipos_Contacto, 19)
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_MotivoPorQueNo, 29, New ListItem("Seleccione", 0))

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_elegible, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_contactado, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Programado, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_ProgramadoV, 4, New ListItem("Seleccione", 0))

        Dim objDeclaracion As DeclaracionBrl = DeclaracionBrl.CargarPorID(Request.QueryString.Item("ID"))


        If objDeclaracion Is Nothing Then
            lblMensaje.Text = "Registro no existe"
            lblMensaje.Visible = True
            Exit Sub
        End If

        BindHelper.ProgramacionUIL.BindToListControlPorId_RegionalyEstado(ddl_Programa, objDeclaracion.Id_Regional, 213, New ListItem("Seleccione", 0))
        BindHelper.ProgramacionUIL.BindToListControlPorId_RegionalyEstado(ddl_ProgramaV, objDeclaracion.Id_Regional, 213, New ListItem("Seleccione", 0))
        lbl_FechaDeclaracion.Text = Format(objDeclaracion.Fecha_Declaracion, "dd/MMM/yyyy")
        lbl_FechaRadicacion.Text = Format(objDeclaracion.Fecha_Radicacion, "dd/MMM/yyyy")
        Try
            lbl_fuente.Text = objDeclaracion.Fuente.Descripcion
        Catch ex As Exception
            lbl_fuente.Text = "N/A"
        End Try

        lbl_regional_Declarante.Text = objDeclaracion.NombreRegional
        lbl_lugarFuente.Text = objDeclaracion.NombreLugarFuente
        lbl_enlinea.Text = objDeclaracion.DeclaracionEnLinea
        lbl_FechaDesplazamiento.Text = Format(objDeclaracion.Fecha_Desplazamiento, "dd/MMM/yyyy")
        lbl_NumeroDeclaracion.Text = objDeclaracion.Numero_Declaracion
        lbl_Horario.Text = objDeclaracion.Horario
        lbl_tipo_declarante.Text = objDeclaracion.TipoDeclaracion.Descripcion
        lbl_TipoFamilia.Text = objDeclaracion.TipoFamiliaxaEmpacar
        txt_observaciones.Text = objDeclaracion.Observaciones

        If objDeclaracion.Id_Atender <> 0 Then
            If objDeclaracion.Id_Atender = 20 Then
                If ddl_MotivoPorQueNo.Items.FindByValue(objDeclaracion.Id_Motivo_Noatender) IsNot Nothing Then ddl_MotivoPorQueNo.SelectedValue = objDeclaracion.Id_Motivo_Noatender
            End If
        End If


        ' cargas los datos de la persona
        Lst_Tipos_Contacto_Persona.Items.Clear()
        Dim objpersona As PersonasBrl = PersonasBrl.CargarPorId_DeclaracionYDeclarante(Request.QueryString.Item("Id"))
        If objpersona IsNot Nothing Then
            lbl_PrimerNombre.Text = objpersona.Primer_Nombre
            lbl_SegundoNombre.Text = objpersona.Segundo_Nombre
            lbl_PrimerApellido.Text = objpersona.Primer_Apellido
            lbl_SegundoApellido.Text = objpersona.Segundo_Apellido
            lbl_TipoIdentificacion.Text = objpersona.Tipo_Identificacion.Descripcion
            lbl_Identificacion.Text = objpersona.Identificacion
            lbl_Edad.Text = objpersona.Edad
            lbl_Genero.Text = objpersona.GeneroPersona
            lbl_FechaNacimiento.Text = Format(objpersona.Fecha_Nacimiento, "dd/MMM/yyyy")


            Dim objcontactos As List(Of Personas_ContactosBrl)
            objcontactos = Personas_ContactosBrl.CargarPorId_Persona(objpersona.ID)
            For Each fila As Personas_ContactosBrl In objcontactos
                Me.Lst_Tipos_Contacto_Persona.Items.Add(New ListItem(fila.SubTablasTipoContacto.Descripcion & " : " & fila.Descripcion, fila.Id_Tipo_Contacto))
            Next
        End If

        cargarestados()
    End Sub

    Public Sub cargarestados()
        Dim objestadosDeclaracion As List(Of Declaracion_EstadosBrl) = Declaracion_EstadosBrl.CargarPorId_Declaracion(Request.QueryString.Item("ID"))
        Session("EstadosDeclaracion") = objestadosDeclaracion
        Rg_Listado.DataSource = Session("EstadosDeclaracion")
        Rg_Listado.DataBind()

        ' habilitar los vistas de las asignaciones

        rts_estados.Enabled = False
        rts_estados.Tabs(0).Enabled = False ' elegible
        rts_estados.Tabs(1).Enabled = False ' contactado
        rts_estados.Tabs(2).Enabled = False ' programado

        RadPageView1.Enabled = False
        RadPageView2.Enabled = False
        RadPageView3.Enabled = False
        RadPageView4.Enabled = True

        ddl_MotivoPorQueNo.Visible = False

        If objestadosDeclaracion.Count = 0 Then
            rts_estados.Enabled = True
            rts_estados.Tabs(0).Enabled = True ' elegible
            rts_estados.Tabs(1).Enabled = False ' contactado
            rts_estados.Tabs(2).Enabled = False ' programado

            RadPageView1.Enabled = True
            RadPageView2.Enabled = False
            RadPageView3.Enabled = False

        Else
            ' hay registros


            Dim objelegible As New Declaracion_EstadosBrl
            Dim objcontactado As New Declaracion_EstadosBrl
            Dim objprogramado As New Declaracion_EstadosBrl

            For Each fila As Declaracion_EstadosBrl In objestadosDeclaracion
                If fila.Id_Tipo_Estado = 4036 Then ' existe elegible
                    objelegible = fila
                End If
                If fila.Id_Tipo_Estado = 4037 Then
                    objcontactado = fila
                End If
                If fila.Id_Tipo_Estado = 4038 Then
                    objprogramado = fila
                End If

            Next

            If objelegible IsNot Nothing Then ' existe registro de elegible
                rts_estados.Enabled = True
                rts_estados.Tabs(0).Enabled = True ' elegible
                RadPageView1.Enabled = True
                If objelegible.Id_Como_Estado = 20 Then
                    rts_estados.Tabs(1).Enabled = False ' contactado
                    RadPageView2.Enabled = False
                    Exit Sub
                Else
                    rts_estados.Tabs(1).Enabled = True ' contactado
                    RadPageView2.Enabled = True
                End If
            End If

            If objcontactado IsNot Nothing Then ' existe registro de contactado
                If objcontactado.Id_Como_Estado = 19 Then
                    rts_estados.Tabs(2).Enabled = True ' programado
                    RadPageView3.Enabled = True
                End If
            End If

            If objprogramado IsNot Nothing Then ' existe registro de programado

                btn_GrabarProgramacion.Enabled = True
                If objprogramado.Id_Como_Estado = 19 Then
                    rts_estados.Tabs(2).Enabled = True
                    RadPageView3.Enabled = False
                    btn_GrabarProgramacion.Enabled = False

                    RadPageView2.Enabled = False
                    RadPageView1.Enabled = False

                End If
            End If

        End If
    End Sub

    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton1.Click
        If Len(txtvalor.Text) <> 0 Then
            If Lst_Tipos_Contacto.SelectedIndex >= 0 Then
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
        Try
            Lst_Tipos_Contacto_Persona.Items.RemoveAt(Lst_Tipos_Contacto_Persona.SelectedIndex)
            Lst_Tipos_Contacto_Persona.ClearSelection()
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btn_GrabarRegistro_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_GrabarElegible.Click
        Validate("ELEGIBLE")
        If Not IsValid Then Exit Sub
        lblMensaje.Visible = False

        Dim objestado As Declaracion_EstadosBrl
        If lbl_IdEstado.Text = "" Then
            objestado = New Declaracion_EstadosBrl
            objestado.Id_Declaracion = Request.QueryString.Item("ID")
            objestado.Fecha_Creacion = Now
            objestado.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
        Else
            objestado = Declaracion_EstadosBrl.CargarPorID(lbl_IdEstado.Text)
            objestado.Fecha_Modificacion = Now
            objestado.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text
        End If

        Try
            objestado.Fecha = rdp_FechaElegible.DbSelectedDate
        Catch ex As Exception
            objestado.Fecha = Now()
        End Try
        objestado.Id_Tipo_Estado = 4036 ' estado elegible
        objestado.Id_Como_Estado = ddl_elegible.SelectedValue
        Try
            objestado.Guardar()
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
            Exit Sub
        End Try

        ' colocando el motivo de no atencion en el declarante
        Dim objdeclaracion As DeclaracionBrl = DeclaracionBrl.CargarPorID(Request.QueryString.Item("Id"))
        If ddl_elegible.SelectedValue = 20 Then
            objdeclaracion.Id_Atender = 20
            objdeclaracion.Id_Motivo_Noatender = ddl_MotivoPorQueNo.SelectedValue

        End If
        If ddl_elegible.SelectedValue = 19 Then
            objdeclaracion.Id_Atender = 0
            objdeclaracion.Id_Motivo_Noatender = 0
        End If


        objdeclaracion.Observaciones = txt_observaciones.Text
        objdeclaracion.Guardar()

        lbl_IdEstado.Text = ""
        ddl_elegible.SelectedValue = 0
        rdp_FechaElegible.DbSelectedDate = Nothing


        cargarestados()

    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/AsignacionesList.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        Response.Redirect("../webforms/Asignaciones.aspx?Id=" + Request.QueryString.Item("Id"))
    End Sub

    Protected Sub btn_GrabarContactado_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_GrabarContactado.Click
        Validate("CONTACTADO")
        If Not IsValid Then Exit Sub
        lblMensaje.Visible = False

        Dim objestado As Declaracion_EstadosBrl
        If lbl_IdContacto.Text = "" Then
            objestado = New Declaracion_EstadosBrl
            objestado.Id_Declaracion = Request.QueryString.Item("ID")
            objestado.Fecha_Creacion = Now
            objestado.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
        Else
            objestado = Declaracion_EstadosBrl.CargarPorID(lbl_IdContacto.Text)
            objestado.Fecha_Modificacion = Now
            objestado.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text
        End If

        Try
            objestado.Fecha = rdp_FechaContacto.DbSelectedDate
        Catch ex As Exception
            objestado.Fecha = Now()
        End Try
        objestado.Id_Tipo_Estado = 4037 ' estado contactado
        objestado.Id_Como_Estado = ddl_contactado.SelectedValue
        Try
            objestado.Guardar()
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

        ' Colocando observaciones de contacto
        Dim objdeclaracion As DeclaracionBrl = DeclaracionBrl.CargarPorID(Request.QueryString.Item("Id"))
        objdeclaracion.Observaciones = txt_observaciones.Text
        objdeclaracion.Guardar()

        lbl_IdContacto.Text = ""
        rdp_FechaContacto.DbSelectedDate = Nothing
        ddl_contactado.SelectedValue = 0

        cargarestados()

    End Sub

    Protected Sub btn_GrabarProgramacion_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_GrabarProgramacion.Click
        Validate("PROGRAMADO")
        If Not IsValid Then Exit Sub
        lblMensaje.Visible = False

        Dim objestado As Declaracion_EstadosBrl
        If lbl_IdProgramado.Text = "" Then
            objestado = New Declaracion_EstadosBrl
            objestado.Id_Declaracion = Request.QueryString.Item("ID")
            objestado.Fecha_Creacion = Now
            objestado.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
        Else
            objestado = Declaracion_EstadosBrl.CargarPorID(lbl_IdProgramado.Text)
            objestado.Fecha_Modificacion = Now
            objestado.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text
        End If

        objestado.Fecha = Now()

        If ddl_Programa.SelectedValue > 0 Then
            ' se selecciono un programa
            Dim objprograma As ProgramacionBrl = ProgramacionBrl.CargarPorID(ddl_Programa.SelectedValue)

            Try
                objestado.Fecha = objprograma.Fecha
            Catch ex As Exception
                objestado.Fecha = Now()
            End Try
        End If

        objestado.Id_Tipo_Estado = 4038 ' estado programado
        objestado.Id_Como_Estado = ddl_Programado.SelectedValue
        objestado.Id_Programa = ddl_Programa.SelectedValue
        Try
            objestado.Guardar()
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

        ' Colocando observaciones de contacto
        Dim objdeclaracion As DeclaracionBrl = DeclaracionBrl.CargarPorID(Request.QueryString.Item("Id"))
        objdeclaracion.Observaciones = txt_observaciones.Text
        objdeclaracion.Guardar()


        lbl_IdProgramado.Text = ""
        ddl_Programado.SelectedValue = 0
        ddl_Programado_SelectedIndexChanged(Nothing, Nothing)
        ddl_Programa.SelectedValue = 0

        cargarestados()


    End Sub

    Protected Sub ddl_elegible_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ddl_elegible.SelectedIndexChanged

        ddl_MotivoPorQueNo.Visible = False
        Lbl_Noelegible.Visible = False
        rev_Motivonoelegible.Visible = False

        If ddl_elegible.SelectedValue = 20 Then
            ddl_MotivoPorQueNo.Visible = True
            Lbl_Noelegible.Visible = True
            rev_Motivonoelegible.Visible = True
        End If
        If ddl_elegible.SelectedValue = 19 Then
            ddl_MotivoPorQueNo.SelectedValue = 0
        End If

    End Sub

    Protected Sub ddl_Programado_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ddl_Programado.SelectedIndexChanged
        lbl_Programa.Visible = False
        ddl_Programa.Visible = False
        rev_Programa.Visible = False
        lbl_Fecha_Programacion.Visible = False
        Label_Fecha_Programacion.Visible = False
        If ddl_Programado.SelectedValue = 19 Then
            ddl_Programa.Visible = True
            rev_Programa.Visible = True
            lbl_Programa.Visible = True
        End If
        If ddl_Programado.SelectedValue = 20 Then
            ddl_Programa.SelectedValue = 0
        End If
    End Sub

    Protected Sub ddl_ProgramadoV_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ddl_ProgramadoV.SelectedIndexChanged
        lbl_ProgramaV.Visible = False
        ddl_ProgramaV.Visible = False
        rev_ProgramaV.Visible = False
        lbl_Fecha_ProgramacionV.Visible = False
        Label_Fecha_ProgramacionV.Visible = False
        If ddl_ProgramadoV.SelectedValue = 19 Then
            ddl_ProgramaV.Visible = True
            rev_ProgramaV.Visible = True
            lbl_ProgramaV.Visible = True
        End If
        If ddl_ProgramadoV.SelectedValue = 20 Then
            ddl_ProgramaV.SelectedValue = 0
        End If
    End Sub

    Protected Sub ddl_Programa_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddl_Programa.SelectedIndexChanged
        lbl_Fecha_Programacion.Visible = True
        Label_Fecha_Programacion.Visible = True

        If ddl_Programa.SelectedValue > 0 Then
            Dim objprograma As ProgramacionBrl = ProgramacionBrl.CargarPorID(ddl_Programa.SelectedValue)
            If objprograma IsNot Nothing Then
                lbl_Fecha_Programacion.Text = Format(objprograma.Fecha, "dd/MMM/yyyy")
            Else
                lbl_Fecha_Programacion.Text = "No existe Programa, Por favor volver a seleccionarlo.!!!"
            End If
        Else
            lbl_Fecha_Programacion.Text = "Favor seleccionar Programa."
        End If
    End Sub

    Protected Sub ddl_ProgramaV_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddl_ProgramaV.SelectedIndexChanged
        lbl_Fecha_ProgramacionV.Visible = True
        Label_Fecha_ProgramacionV.Visible = True

        If ddl_ProgramaV.SelectedValue > 0 Then
            Dim objprograma As ProgramacionBrl = ProgramacionBrl.CargarPorID(ddl_ProgramaV.SelectedValue)
            If objprograma IsNot Nothing Then
                lbl_Fecha_ProgramacionV.Text = Format(objprograma.Fecha, "dd/MMM/yyyy")
            Else
                lbl_Fecha_ProgramacionV.Text = "No existe Programa, Por favor volver a seleccionarlo.!!!"
            End If
        Else
            lbl_Fecha_ProgramacionV.Text = "Favor seleccionar Programa."
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Validate("PROGRAMADOVULNERABLE")
        If Not IsValid Then Exit Sub
        lblMensaje.Visible = False

        Dim objestado As Declaracion_EstadosBrl
        If lbl_IdProgramadoV.Text = "" Then
            objestado = New Declaracion_EstadosBrl
            objestado.Id_Declaracion = Request.QueryString.Item("ID")
            objestado.Fecha_Creacion = Now
            objestado.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
        Else
            objestado = Declaracion_EstadosBrl.CargarPorID(lbl_IdProgramado.Text)
            objestado.Fecha_Modificacion = Now
            objestado.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text
        End If

        objestado.Fecha = Now()

        If ddl_ProgramaV.SelectedValue > 0 Then
            ' se selecciono un programa
            Dim objprograma As ProgramacionBrl = ProgramacionBrl.CargarPorID(ddl_ProgramaV.SelectedValue)

            Try
                objestado.Fecha = objprograma.Fecha
            Catch ex As Exception
                objestado.Fecha = Now()
            End Try
        End If

        objestado.Id_Tipo_Estado = 4050 ' estado programado especial
        objestado.Id_Como_Estado = ddl_ProgramadoV.SelectedValue
        objestado.Id_Programa = ddl_ProgramaV.SelectedValue
        Try
            objestado.Guardar()
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

        ' Colocando observaciones de contacto
        Dim objdeclaracion As DeclaracionBrl = DeclaracionBrl.CargarPorID(Request.QueryString.Item("Id"))
        objdeclaracion.Observaciones = txt_observaciones.Text
        objdeclaracion.Guardar()


        lbl_IdProgramadoV.Text = ""
        ddl_ProgramadoV.SelectedValue = 0
        ddl_ProgramadoV_SelectedIndexChanged(Nothing, Nothing)
        ddl_ProgramaV.SelectedValue = 0

        cargarestados()
    End Sub
End Class
