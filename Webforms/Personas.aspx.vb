Imports ingNovar.Utilidades2
Imports System.Collections.Generic
Imports Microsoft.VisualBasic
Imports Telerik.Web.UI

Partial Class WebForms_Personas
    Inherits System.Web.UI.Page

    ''Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
    ''    Dim objper_perfil As New SeguridadUsuarios.Permisos_PerfilBrl
    ''    Dim objper_usuario As New SeguridadUsuarios.Permisos_UsuarioBrl
    ''    '
    ''    ' Ingresa Primero aca
    ''    ' Validamos la seguridad
    ''    '
    ''    ' Perfil
    ''    Dim objusuario As SeguridadUsuarios.UsuariosBrl
    ''    objusuario = SeguridadUsuarios.UsuariosBrl.CargarPorID(CType(Session("IdUsuario"), Integer))
    ''    If objusuario Is Nothing Then
    ''        Response.Redirect(strPaginaError)
    ''        Exit Sub
    ''    End If
    ''    ' Pagina

    ''    Dim objpagina As SeguridadUsuarios.PaginasBrl
    ''    objpagina = SeguridadUsuarios.PaginasBrl.CargarPorURL(Request.FilePath)
    ''    If objpagina Is Nothing Then
    ''        Response.Redirect(strPaginaError)
    ''        Exit Sub
    ''    End If

    ''    ' Permisos por Perfil

    ''    objper_perfil = SeguridadUsuarios.Usuarios.EstadoPerPagina(objusuario.Id_Perfil, objpagina.ID)
    ''    objper_usuario = SeguridadUsuarios.Usuarios.EstadoPerUsuario(objusuario.ID, objpagina.ID)

    ''    If objper_perfil Is Nothing And objper_usuario Is Nothing Then
    ''        Response.Redirect(strPaginaError)
    ''        Exit Sub
    ''    End If

    ''    ' En alguno de los dos hay permisos
    ''    ' Hay datos en la pagina de perfiles, se inicia la validacion de datos
    ''    If objper_perfil IsNot Nothing Then
    ''        If objper_perfil.Pver = False Or objper_perfil.Pconsultar = False Then
    ''            Response.Redirect(strPaginaError)
    ''            Exit Sub
    ''        End If

    ''        ' asignando los permisos

    ''        If Request.QueryString.Item("Id") > 0 Then  ' va a editar
    ''            btn_refrescar.Enabled = objper_perfil.Peditar
    ''            btn_Grabar.Enabled = objper_perfil.Peditar
    ''        Else

    ''            btn_refrescar.Enabled = objper_perfil.Pcrear
    ''            btn_Grabar.Enabled = objper_perfil.Pcrear
    ''        End If

    ''        Rg_Listado.ClientSettings.EnablePostBackOnRowClick = objper_perfil.Peditar

    ''    End If

    ''    If objper_usuario IsNot Nothing Then
    ''        If objper_usuario.Pver = False Or objper_usuario.Pconsultar = False Then
    ''            Response.Redirect(strPaginaError)
    ''            Exit Sub
    ''        End If

    ''        ' asignando los permisos

    ''        If Request.QueryString.Item("Id") > 0 Then  ' va a editar

    ''            btn_refrescar.Enabled = objper_usuario.Peditar
    ''            btn_Grabar.Enabled = objper_usuario.Peditar
    ''        Else

    ''            btn_refrescar.Enabled = objper_usuario.Pcrear
    ''            btn_Grabar.Enabled = objper_usuario.Pcrear
    ''        End If

    ''        Rg_Listado.ClientSettings.EnablePostBackOnRowClick = objper_usuario.Peliminar
    ''    End If

    ''End Sub

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

        ' cargas los datos de la persona

        Dim objdeclaracion As DeclaracionBrl = DeclaracionBrl.CargarPorID(PersonasBrl.CargarPorID(Request.QueryString.Item("Id")).Id_Declaracion)
        Dim objpersona As PersonasBrl = objdeclaracion.Personas_Declarante
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


            lbl_FechaDeclaracion.Text = Format(objpersona.Declaracion.Fecha_Declaracion, "dd/MMM/yyyy")
            lbl_FechaRadicacion.Text = Format(objpersona.Declaracion.Fecha_Radicacion, "dd/MMM/yyyy")
            Try
                lbl_fuente.Text = objpersona.Declaracion.Fuente.Descripcion
            Catch ex As Exception
                lbl_fuente.Text = "N/A"
            End Try

            lbl_regional_Declarante.Text = objpersona.Declaracion.NombreRegional
            lbl_lugarFuente.Text = objpersona.Declaracion.NombreLugarFuente
            lbl_enlinea.Text = objpersona.Declaracion.DeclaracionEnLinea
            lbl_FechaDesplazamiento.Text = Format(objpersona.Declaracion.Fecha_Desplazamiento, "dd/MMM/yyyy")
            lbl_NumeroDeclaracion.Text = objpersona.Declaracion.Numero_Declaracion
            lbl_Horario.Text = objpersona.Declaracion.Horario
            lbl_tipo_declarante.Text = objpersona.Declaracion.TipoDeclaracion.Descripcion
            lbl_TipoFamilia.Text = objpersona.Declaracion.TipoFamiliaxaEmpacar

            Session("LisTPersonas") = objdeclaracion.Personas
            Rg_Listado.DataSource = Session("LisTPersonas")
            Rg_Listado.DataBind()

        End If

        cargarestados()

    End Sub

    Public Sub cargarestados()
        Dim objdeclaracion As DeclaracionBrl = DeclaracionBrl.CargarPorID(PersonasBrl.CargarPorID(Request.QueryString.Item("Id")).Id_Declaracion)
        Dim objpersona As PersonasBrl = objdeclaracion.Personas_Declarante
        BindHelper.Personas_ContactosUIL.BindToListControlPorId_PersonayTipo_contacto(ddl_celular, objdeclaracion.Personas_Declarante.ID, 76, New ListItem("Seleccione", 0))
        BindHelper.Personas_ContactosUIL.BindToListControlPorId_PersonayTipo_contacto(ddl_telefono, objdeclaracion.Personas_Declarante.ID, 75, New ListItem("Seleccione", 0))
        BindHelper.Personas_ContactosUIL.BindToListControlPorId_PersonayTipo_contacto(ddl_direccion, objdeclaracion.Personas_Declarante.ID, 74, New ListItem("Seleccione", 0))
        BindHelper.Personas_ContactosUIL.BindToListControlPorId_PersonayTipo_contacto(ddl_barrio, objdeclaracion.Personas_Declarante.ID, 79, New ListItem("Seleccione", 0))

        ' Cargando los datos principales
        Dim objcontactos As List(Of Personas_ContactosBrl) = objpersona.Personas_Contactos

        For Each fila As Personas_ContactosBrl In objcontactos
            Select Case fila.Id_Tipo_Contacto
                Case 76 '' celular
                    If fila.Activo Then
                        ddl_celular.SelectedValue = fila.ID
                    End If
                Case 75  '' telefono
                    If fila.Activo Then
                        ddl_telefono.SelectedValue = fila.ID
                    End If
                Case 79  '' barrio
                    If fila.Activo Then
                        ddl_barrio.SelectedValue = fila.ID
                    End If
                Case 74  '' direccion
                    If fila.Activo Then
                        ddl_direccion.SelectedValue = fila.ID
                    End If

            End Select
        Next

        FilterHelper.FilterHelper(objcontactos, "Id_Tipo_Contacto", 76)
        Rg_Celulares.DataSource = objcontactos
        Rg_Celulares.DataBind()

        objcontactos = Personas_ContactosBrl.CargarPorId_Persona(objdeclaracion.Personas_Declarante.ID)
        FilterHelper.FilterHelper(objcontactos, "Id_Tipo_Contacto", 75)
        Rg_telefono.DataSource = objcontactos
        Rg_telefono.DataBind()

        objcontactos = Personas_ContactosBrl.CargarPorId_Persona(objdeclaracion.Personas_Declarante.ID)
        FilterHelper.FilterHelper(objcontactos, "Id_Tipo_Contacto", 74)
        Rg_Direccion.DataSource = objcontactos
        Rg_Direccion.DataBind()

        objcontactos = Personas_ContactosBrl.CargarPorId_Persona(objdeclaracion.Personas_Declarante.ID)
        FilterHelper.FilterHelper(objcontactos, "Id_Tipo_Contacto", 79)
        Rg_Barrio.DataSource = objcontactos
        Rg_Barrio.DataBind()



    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/PersonasList.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        Response.Redirect("../webforms/Personas.aspx?Id=" + Request.QueryString.Item("Id"))
    End Sub

    Protected Sub btn_refrescar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_refrescar.Click
        cargarestados()
    End Sub

    Protected Sub btn_Grabar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Grabar.Click
        Dim objdeclaracion As DeclaracionBrl = DeclaracionBrl.CargarPorID(PersonasBrl.CargarPorID(Request.QueryString.Item("Id")).Id_Declaracion)
        Dim objpersona As PersonasBrl = objdeclaracion.Personas_Declarante

        Dim Listcontactos As List(Of Personas_ContactosBrl) = Personas_ContactosBrl.CargarPorId_Persona(objpersona.ID)

        For Each fila As Personas_ContactosBrl In Listcontactos
            Select Case fila.Id_Tipo_Contacto
                Case 76
                    If fila.ID = ddl_celular.SelectedValue Then fila.Activo = 1 Else fila.Activo = 0
                Case 75
                    If fila.ID = ddl_telefono.SelectedValue Then fila.Activo = 1 Else fila.Activo = 0
                Case 79
                    If fila.ID = ddl_barrio.SelectedValue Then fila.Activo = 1 Else fila.Activo = 0
                Case 74
                    If fila.ID = ddl_direccion.SelectedValue Then fila.Activo = 1 Else fila.Activo = 0
            End Select
            fila.Guardar()
        Next

        cargarestados()
    End Sub

    Protected Sub Rg_Listado_NeedDataSource(sender As Object, e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Listado.NeedDataSource
        Rg_Listado.DataSource = Session("LisTPersonas")
    End Sub

    Public Sub subCommandItemCelular(ByVal sender As Object, ByVal e As GridCommandEventArgs)

        Select Case e.CommandName
            Case "GrabarCelular"
                SubGrabarCelular(sender, e)
            Case "EditarCelular"
                SubEditarCelular(sender, e)
            Case "CancelarCelular"
                SubCancelarCelular(sender, e)
            Case "EliminarCelular"
                SubEliminarCelular(sender, e)
        End Select

    End Sub

    Protected Sub SubGrabarCelular(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Dim lblId As Label
        lblId = e.Item.FindControl("lblId")

        Dim txt_celular As TextBox
        txt_celular = e.Item.FindControl("txt_celular")

        Dim objcontacto As Personas_ContactosBrl = Personas_ContactosBrl.CargarPorID(lblId.Text)
        objcontacto.Descripcion = txt_celular.Text
        objcontacto.Fecha_Modificacion = Now
        objcontacto.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text
        objcontacto.Guardar()

        Dim btn_editar, btn_eliminar, btn_aceptar, btn_cancelar As ImageButton
        btn_editar = e.Item.FindControl("btn_editar")
        btn_editar.Enabled = True

        btn_eliminar = e.Item.FindControl("btn_eliminar")
        btn_eliminar.Enabled = True

        btn_aceptar = e.Item.FindControl("btn_aceptar")
        btn_aceptar.Visible = False

        btn_cancelar = e.Item.FindControl("btn_cancelar")
        btn_cancelar.Visible = False

        txt_celular.Enabled = False

        cargarestados()

    End Sub

    Protected Sub SubEditarCelular(ByVal sender As Object, ByVal e As GridCommandEventArgs)


        Dim txt_celular As TextBox
        txt_celular = e.Item.FindControl("txt_celular")
        txt_celular.Enabled = True
        txt_celular.Focus()

        Dim btn_editar, btn_eliminar, btn_aceptar, btn_cancelar As ImageButton
        btn_editar = e.Item.FindControl("btn_editar")
        btn_editar.Enabled = False

        btn_eliminar = e.Item.FindControl("btn_eliminar")
        btn_eliminar.Enabled = False

        btn_aceptar = e.Item.FindControl("btn_aceptar")
        btn_aceptar.Visible = True

        btn_cancelar = e.Item.FindControl("btn_cancelar")
        btn_cancelar.Visible = True

    End Sub

    Protected Sub SubCancelarCelular(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Dim txt_celular As TextBox
        txt_celular = e.Item.FindControl("txt_celular")

        Dim btn_editar, btn_eliminar, btn_aceptar, btn_cancelar As ImageButton
        btn_editar = e.Item.FindControl("btn_editar")
        btn_editar.Enabled = True

        btn_eliminar = e.Item.FindControl("btn_eliminar")
        btn_eliminar.Enabled = True

        btn_aceptar = e.Item.FindControl("btn_aceptar")
        btn_aceptar.Visible = False

        btn_cancelar = e.Item.FindControl("btn_cancelar")
        btn_cancelar.Visible = False

        txt_celular.Enabled = False

    End Sub

    Protected Sub SubEliminarCelular(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Dim lblId As Label
        lblId = e.Item.FindControl("lblId")

        Dim objcontacto As Personas_ContactosBrl = Personas_ContactosBrl.CargarPorID(lblId.Text)
        objcontacto.Eliminar()

        Dim btn_editar, btn_eliminar, btn_aceptar, btn_cancelar As ImageButton
        btn_editar = e.Item.FindControl("btn_editar")
        btn_editar.Enabled = True

        btn_eliminar = e.Item.FindControl("btn_eliminar")
        btn_eliminar.Enabled = True

        btn_aceptar = e.Item.FindControl("btn_aceptar")
        btn_aceptar.Visible = False

        btn_cancelar = e.Item.FindControl("btn_cancelar")
        btn_cancelar.Visible = False

        cargarestados()
    End Sub

    Protected Sub btn_limpiarcelular_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles btn_limpiarcelular.Click
        txt_nuevocelular.Text = ""
        txt_nuevocelular.Focus()
    End Sub

    Protected Sub btn_nuevocelular_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles btn_nuevocelular.Click
        If txt_nuevocelular.Text.Length > 0 Then
            Dim objdeclaracion As DeclaracionBrl = DeclaracionBrl.CargarPorID(PersonasBrl.CargarPorID(Request.QueryString.Item("Id")).Id_Declaracion)
            Dim objpersona As PersonasBrl = objdeclaracion.Personas_Declarante

            Dim objcontacto As New Personas_ContactosBrl
            objcontacto.Id_Tipo_Contacto = 76
            objcontacto.Id_Persona = objpersona.ID
            objcontacto.Activo = False
            objcontacto.Fecha_Creacion = Now
            objcontacto.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
            objcontacto.Descripcion = txt_nuevocelular.Text
            objcontacto.Guardar()

            cargarestados()
        End If
    End Sub


    '
    '
    '

    Public Sub subCommandItemTelefono(ByVal sender As Object, ByVal e As GridCommandEventArgs)

        Select Case e.CommandName
            Case "GrabarTelefono"
                SubGrabarTelefono(sender, e)
            Case "EditarTelefono"
                SubEditarTelefono(sender, e)
            Case "CancelarTelefono"
                SubCancelarTelefono(sender, e)
            Case "EliminarTelefono"
                SubEliminarTelefono(sender, e)
        End Select

    End Sub

    Protected Sub SubGrabarTelefono(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Dim lblId As Label
        lblId = e.Item.FindControl("lblId")

        Dim txt_telefono As TextBox
        txt_telefono = e.Item.FindControl("txt_telefono")

        Dim objcontacto As Personas_ContactosBrl = Personas_ContactosBrl.CargarPorID(lblId.Text)
        objcontacto.Descripcion = txt_Telefono.Text
        objcontacto.Fecha_Modificacion = Now
        objcontacto.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text
        objcontacto.Guardar()

        Dim btn_editar, btn_eliminar, btn_aceptar, btn_cancelar As ImageButton
        btn_editar = e.Item.FindControl("btn_editar")
        btn_editar.Enabled = True

        btn_eliminar = e.Item.FindControl("btn_eliminar")
        btn_eliminar.Enabled = True

        btn_aceptar = e.Item.FindControl("btn_aceptar")
        btn_aceptar.Visible = False

        btn_cancelar = e.Item.FindControl("btn_cancelar")
        btn_cancelar.Visible = False

        txt_Telefono.Enabled = False

        cargarestados()

    End Sub

    Protected Sub SubEditarTelefono(ByVal sender As Object, ByVal e As GridCommandEventArgs)


        Dim txt_telefono As TextBox
        txt_telefono = e.Item.FindControl("txt_telefono")
        txt_Telefono.Enabled = True
        txt_Telefono.Focus()

        Dim btn_editar, btn_eliminar, btn_aceptar, btn_cancelar As ImageButton
        btn_editar = e.Item.FindControl("btn_editar")
        btn_editar.Enabled = False

        btn_eliminar = e.Item.FindControl("btn_eliminar")
        btn_eliminar.Enabled = False

        btn_aceptar = e.Item.FindControl("btn_aceptar")
        btn_aceptar.Visible = True

        btn_cancelar = e.Item.FindControl("btn_cancelar")
        btn_cancelar.Visible = True

    End Sub

    Protected Sub SubCancelarTelefono(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Dim txt_telefono As TextBox
        txt_telefono = e.Item.FindControl("txt_telefono")

        Dim btn_editar, btn_eliminar, btn_aceptar, btn_cancelar As ImageButton
        btn_editar = e.Item.FindControl("btn_editar")
        btn_editar.Enabled = True

        btn_eliminar = e.Item.FindControl("btn_eliminar")
        btn_eliminar.Enabled = True

        btn_aceptar = e.Item.FindControl("btn_aceptar")
        btn_aceptar.Visible = False

        btn_cancelar = e.Item.FindControl("btn_cancelar")
        btn_cancelar.Visible = False

        txt_Telefono.Enabled = False

    End Sub

    Protected Sub SubEliminarTelefono(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Dim lblId As Label
        lblId = e.Item.FindControl("lblId")

        Dim objcontacto As Personas_ContactosBrl = Personas_ContactosBrl.CargarPorID(lblId.Text)
        objcontacto.Eliminar()

        Dim btn_editar, btn_eliminar, btn_aceptar, btn_cancelar As ImageButton
        btn_editar = e.Item.FindControl("btn_editar")
        btn_editar.Enabled = True

        btn_eliminar = e.Item.FindControl("btn_eliminar")
        btn_eliminar.Enabled = True

        btn_aceptar = e.Item.FindControl("btn_aceptar")
        btn_aceptar.Visible = False

        btn_cancelar = e.Item.FindControl("btn_cancelar")
        btn_cancelar.Visible = False

        cargarestados()
    End Sub

    Protected Sub btn_limpiarTelefono_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles btn_limpiartelefono.Click
        txt_nuevoTelefono.Text = ""
        txt_nuevoTelefono.Focus()
    End Sub

    Protected Sub btn_nuevoTelefono_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles btn_nuevotelefono.Click
        If txt_nuevoTelefono.Text.Length > 0 Then
            Dim objdeclaracion As DeclaracionBrl = DeclaracionBrl.CargarPorID(PersonasBrl.CargarPorID(Request.QueryString.Item("Id")).Id_Declaracion)
            Dim objpersona As PersonasBrl = objdeclaracion.Personas_Declarante

            Dim objcontacto As New Personas_ContactosBrl
            objcontacto.Id_Tipo_Contacto = 75
            objcontacto.Id_Persona = objpersona.ID
            objcontacto.Activo = False
            objcontacto.Fecha_Creacion = Now
            objcontacto.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
            objcontacto.Descripcion = txt_nuevoTelefono.Text
            objcontacto.Guardar()

            cargarestados()
        End If
    End Sub


    '
    '
    '

    Public Sub subCommandItemDireccion(ByVal sender As Object, ByVal e As GridCommandEventArgs)

        Select Case e.CommandName
            Case "GrabarDireccion"
                SubGrabarDireccion(sender, e)
            Case "EditarDireccion"
                SubEditarDireccion(sender, e)
            Case "CancelarDireccion"
                SubCancelarDireccion(sender, e)
            Case "EliminarDireccion"
                SubEliminarDireccion(sender, e)
        End Select

    End Sub

    Protected Sub SubGrabarDireccion(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Dim lblId As Label
        lblId = e.Item.FindControl("lblId")

        Dim txt_Direccion As TextBox
        txt_Direccion = e.Item.FindControl("txt_Direccion")

        Dim objcontacto As Personas_ContactosBrl = Personas_ContactosBrl.CargarPorID(lblId.Text)
        objcontacto.Descripcion = txt_Direccion.Text
        objcontacto.Fecha_Modificacion = Now
        objcontacto.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text
        objcontacto.Guardar()

        Dim btn_editar, btn_eliminar, btn_aceptar, btn_cancelar As ImageButton
        btn_editar = e.Item.FindControl("btn_editar")
        btn_editar.Enabled = True

        btn_eliminar = e.Item.FindControl("btn_eliminar")
        btn_eliminar.Enabled = True

        btn_aceptar = e.Item.FindControl("btn_aceptar")
        btn_aceptar.Visible = False

        btn_cancelar = e.Item.FindControl("btn_cancelar")
        btn_cancelar.Visible = False

        txt_Direccion.Enabled = False

        cargarestados()

    End Sub

    Protected Sub SubEditarDireccion(ByVal sender As Object, ByVal e As GridCommandEventArgs)


        Dim txt_Direccion As TextBox
        txt_Direccion = e.Item.FindControl("txt_Direccion")
        txt_Direccion.Enabled = True
        txt_Direccion.Focus()

        Dim btn_editar, btn_eliminar, btn_aceptar, btn_cancelar As ImageButton
        btn_editar = e.Item.FindControl("btn_editar")
        btn_editar.Enabled = False

        btn_eliminar = e.Item.FindControl("btn_eliminar")
        btn_eliminar.Enabled = False

        btn_aceptar = e.Item.FindControl("btn_aceptar")
        btn_aceptar.Visible = True

        btn_cancelar = e.Item.FindControl("btn_cancelar")
        btn_cancelar.Visible = True

    End Sub

    Protected Sub SubCancelarDireccion(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Dim txt_Direccion As TextBox
        txt_Direccion = e.Item.FindControl("txt_Direccion")

        Dim btn_editar, btn_eliminar, btn_aceptar, btn_cancelar As ImageButton
        btn_editar = e.Item.FindControl("btn_editar")
        btn_editar.Enabled = True

        btn_eliminar = e.Item.FindControl("btn_eliminar")
        btn_eliminar.Enabled = True

        btn_aceptar = e.Item.FindControl("btn_aceptar")
        btn_aceptar.Visible = False

        btn_cancelar = e.Item.FindControl("btn_cancelar")
        btn_cancelar.Visible = False

        txt_Direccion.Enabled = False

    End Sub

    Protected Sub SubEliminarDireccion(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Dim lblId As Label
        lblId = e.Item.FindControl("lblId")

        Dim objcontacto As Personas_ContactosBrl = Personas_ContactosBrl.CargarPorID(lblId.Text)
        objcontacto.Eliminar()

        Dim btn_editar, btn_eliminar, btn_aceptar, btn_cancelar As ImageButton
        btn_editar = e.Item.FindControl("btn_editar")
        btn_editar.Enabled = True

        btn_eliminar = e.Item.FindControl("btn_eliminar")
        btn_eliminar.Enabled = True

        btn_aceptar = e.Item.FindControl("btn_aceptar")
        btn_aceptar.Visible = False

        btn_cancelar = e.Item.FindControl("btn_cancelar")
        btn_cancelar.Visible = False

        cargarestados()
    End Sub

    Protected Sub btn_limpiarDireccion_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles btn_limpiardireccion.Click
        txt_nuevadireccion.Text = ""
        txt_nuevadireccion.Focus()
    End Sub

    Protected Sub btn_nuevaDireccion_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles btn_nuevadireccion.Click
        If txt_nuevadireccion.Text.Length > 0 Then
            Dim objdeclaracion As DeclaracionBrl = DeclaracionBrl.CargarPorID(PersonasBrl.CargarPorID(Request.QueryString.Item("Id")).Id_Declaracion)
            Dim objpersona As PersonasBrl = objdeclaracion.Personas_Declarante

            Dim objcontacto As New Personas_ContactosBrl
            objcontacto.Id_Tipo_Contacto = 74
            objcontacto.Id_Persona = objpersona.ID
            objcontacto.Activo = False
            objcontacto.Fecha_Creacion = Now
            objcontacto.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
            objcontacto.Descripcion = txt_nuevadireccion.Text
            objcontacto.Guardar()

            cargarestados()
        End If
    End Sub

    '
    '
    '
    Public Sub subCommandItemBarrio(ByVal sender As Object, ByVal e As GridCommandEventArgs)

        Select Case e.CommandName
            Case "GrabarBarrio"
                SubGrabarBarrio(sender, e)
            Case "EditarBarrio"
                SubEditarBarrio(sender, e)
            Case "CancelarBarrio"
                SubCancelarBarrio(sender, e)
            Case "EliminarBarrio"
                SubEliminarBarrio(sender, e)
        End Select

    End Sub

    Protected Sub SubGrabarBarrio(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Dim lblId As Label
        lblId = e.Item.FindControl("lblId")

        Dim txt_Barrio As TextBox
        txt_Barrio = e.Item.FindControl("txt_Barrio")

        Dim objcontacto As Personas_ContactosBrl = Personas_ContactosBrl.CargarPorID(lblId.Text)
        objcontacto.Descripcion = txt_Barrio.Text
        objcontacto.Fecha_Modificacion = Now
        objcontacto.Id_Usuario_Modificacion = CType(Master.FindControl("lblidusuario"), Label).Text
        objcontacto.Guardar()

        Dim btn_editar, btn_eliminar, btn_aceptar, btn_cancelar As ImageButton
        btn_editar = e.Item.FindControl("btn_editar")
        btn_editar.Enabled = True

        btn_eliminar = e.Item.FindControl("btn_eliminar")
        btn_eliminar.Enabled = True

        btn_aceptar = e.Item.FindControl("btn_aceptar")
        btn_aceptar.Visible = False

        btn_cancelar = e.Item.FindControl("btn_cancelar")
        btn_cancelar.Visible = False

        txt_Barrio.Enabled = False

        cargarestados()

    End Sub

    Protected Sub SubEditarBarrio(ByVal sender As Object, ByVal e As GridCommandEventArgs)


        Dim txt_Barrio As TextBox
        txt_Barrio = e.Item.FindControl("txt_Barrio")
        txt_Barrio.Enabled = True
        txt_Barrio.Focus()

        Dim btn_editar, btn_eliminar, btn_aceptar, btn_cancelar As ImageButton
        btn_editar = e.Item.FindControl("btn_editar")
        btn_editar.Enabled = False

        btn_eliminar = e.Item.FindControl("btn_eliminar")
        btn_eliminar.Enabled = False

        btn_aceptar = e.Item.FindControl("btn_aceptar")
        btn_aceptar.Visible = True

        btn_cancelar = e.Item.FindControl("btn_cancelar")
        btn_cancelar.Visible = True

    End Sub

    Protected Sub SubCancelarBarrio(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Dim txt_Barrio As TextBox
        txt_Barrio = e.Item.FindControl("txt_Barrio")

        Dim btn_editar, btn_eliminar, btn_aceptar, btn_cancelar As ImageButton
        btn_editar = e.Item.FindControl("btn_editar")
        btn_editar.Enabled = True

        btn_eliminar = e.Item.FindControl("btn_eliminar")
        btn_eliminar.Enabled = True

        btn_aceptar = e.Item.FindControl("btn_aceptar")
        btn_aceptar.Visible = False

        btn_cancelar = e.Item.FindControl("btn_cancelar")
        btn_cancelar.Visible = False

        txt_Barrio.Enabled = False

    End Sub

    Protected Sub SubEliminarBarrio(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Dim lblId As Label
        lblId = e.Item.FindControl("lblId")

        Dim objcontacto As Personas_ContactosBrl = Personas_ContactosBrl.CargarPorID(lblId.Text)
        objcontacto.Eliminar()

        Dim btn_editar, btn_eliminar, btn_aceptar, btn_cancelar As ImageButton
        btn_editar = e.Item.FindControl("btn_editar")
        btn_editar.Enabled = True

        btn_eliminar = e.Item.FindControl("btn_eliminar")
        btn_eliminar.Enabled = True

        btn_aceptar = e.Item.FindControl("btn_aceptar")
        btn_aceptar.Visible = False

        btn_cancelar = e.Item.FindControl("btn_cancelar")
        btn_cancelar.Visible = False

        cargarestados()
    End Sub

    Protected Sub btn_limpiarBarrio_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles btn_limpiarbarrio.Click
        txt_nuevoBarrio.Text = ""
        txt_nuevoBarrio.Focus()
    End Sub

    Protected Sub btn_nuevoBarrio_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles btn_nuevobarrio.Click
        If txt_nuevoBarrio.Text.Length > 0 Then
            Dim objdeclaracion As DeclaracionBrl = DeclaracionBrl.CargarPorID(PersonasBrl.CargarPorID(Request.QueryString.Item("Id")).Id_Declaracion)
            Dim objpersona As PersonasBrl = objdeclaracion.Personas_Declarante

            Dim objcontacto As New Personas_ContactosBrl
            objcontacto.Id_Tipo_Contacto = 79
            objcontacto.Id_Persona = objpersona.ID
            objcontacto.Activo = False
            objcontacto.Fecha_Creacion = Now
            objcontacto.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
            objcontacto.Descripcion = txt_nuevoBarrio.Text
            objcontacto.Guardar()

            cargarestados()
        End If
    End Sub


End Class
