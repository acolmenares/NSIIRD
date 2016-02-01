Imports ingNovar.Utilidades2
Imports System.Data
Imports System.Collections.Generic
Imports Telerik.Web.UI

Partial Class WebForms_Personas_Educacion
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
                btnGuardar.Enabled = objper_perfil.Peditar
            Else
                btnGuardar.Enabled = objper_perfil.Pcrear
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
                btnGuardar.Enabled = objper_usuario.Peditar
            Else
                btnGuardar.Enabled = objper_usuario.Pcrear
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

        Dim objpersona As PersonasBrl = PersonasBrl.CargarPorID(Request.QueryString.Item("Id"))
        If objpersona Is Nothing Then
            lbl_NombreCompleto.Text = ""
            lbl_Grupo.Text = ""
        Else
            lbl_NombreCompleto.Text = objpersona.NombreCompleto
            lbl_Grupo.Text = objpersona.Declaracion.DescripcionGrupo
        End If

        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Estudia_Actualmente, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Motivo_NoEstudia, 5, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Certificado_Matricula, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Seguimiento, 4, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_grado_escolar, 18, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Departamento_Instituto, 46, New ListItem("Seleccione", 0))

        Dim objPersonas_Educacion As List(Of Personas_EducacionBrl) = Personas_EducacionBrl.CargarPorId_Persona(Request.QueryString.Item("ID"))

        Try
            lbl_Municipio.Text = objPersonas_Educacion.Item(0).Personas.Declaracion.Municipio_Expulsor.Descripcion
        Catch ex As Exception
            lbl_Municipio.Text = "Sin Definir!!!"
        End Try

        Session("Educacion") = objPersonas_Educacion
        Rg_Listado.DataSource = Session("Educacion")
        Rg_Listado.DataBind()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Validate("SE")
        If Not IsValid Then Exit Sub

        If chb_cerrado.Checked Then
            lblMensaje.Text = "Registro Cerrado. No se puede Modificar.!!!!"
            lblMensaje.Visible = True
            Exit Sub
        End If

        Dim ID As Int32

        Try
            ID = Grabar()
            Response.Redirect("Personas_Educacion.aspx?Editar=1&Mensaje=1&ID=" & Request.QueryString.Item("id"))
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        rdpfecha.SelectedDate = Nothing
        lblId.Text = ""
        ddl_Estudia_Actualmente.SelectedValue = 0
        ddl_Certificado_Matricula.SelectedValue = 0
        ddl_Certificado_Matricula.Enabled = False
        ddl_Motivo_NoEstudia.Enabled = False
        rev_Motivo_NoEstudia.Enabled = False
        rev_Certificado.Enabled = False
        txtEstablecimiento.Enabled = False
        txtEstablecimiento.Text = ""
        rfv_Establecimiento.Enabled = False
        ddl_grado_escolar.Enabled = False
        ddl_grado_escolar.SelectedValue = 0
        rev_GradoEscolar.Enabled = False
        ddl_Seguimiento.SelectedValue = 0
        rdb_verificacion.SelectedValue = "0"
        chb_cerrado.Checked = False
        txt_observaciones.Text = ""
        ddl_Departamento_Instituto.SelectedValue = 0
        ddl_Departamento_Instituto_SelectedIndexChanged(Nothing, Nothing)

    End Sub

    Private Function Grabar() As Int32
        Dim objPersonas_Educacion As Personas_EducacionBrl
        If lblId.Text <> "" Then
            objPersonas_Educacion = Personas_EducacionBrl.CargarPorID(lblId.Text)
        Else
            objPersonas_Educacion = New Personas_EducacionBrl
            objPersonas_Educacion.Id_Persona = Request.QueryString.Item("Id")
            objPersonas_Educacion.Id_Tipo_Entrega = 919
        End If

        Try
            objPersonas_Educacion.Fecha = rdpfecha.DbSelectedDate
        Catch ex As Exception
            objPersonas_Educacion.Fecha = Now()
        End Try

        objPersonas_Educacion.Id_Estudia_Actualmente = ddl_Estudia_Actualmente.SelectedValue
        objPersonas_Educacion.Id_Motivo_NoEstudia = ddl_Motivo_NoEstudia.SelectedValue
        objPersonas_Educacion.Id_Certificado_Matricula = ddl_Certificado_Matricula.SelectedValue
        objPersonas_Educacion.Id_Seguimiento = ddl_Seguimiento.SelectedValue
        objPersonas_Educacion.Establecimiento = txtEstablecimiento.Text
        objPersonas_Educacion.Id_grado_escolar = ddl_grado_escolar.SelectedValue
        objPersonas_Educacion.Verificado_Entidad = rdb_verificacion.SelectedValue
        objPersonas_Educacion.Observaciones = txt_observaciones.Text
        objPersonas_Educacion.Id_Municipio_Instituto = ddl_municipio_Instituto.SelectedValue
        objPersonas_Educacion.Guardar()

        Return objPersonas_Educacion.ID

    End Function

    Protected Sub ddl_Estudia_Actualmente_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_Estudia_Actualmente.SelectedIndexChanged
        ddl_Seguimiento.SelectedValue = 19
        ddl_Certificado_Matricula.Enabled = False
        rev_Certificado.Enabled = False
        ddl_Certificado_Matricula.SelectedValue = 0
        txtEstablecimiento.Enabled = False
        txtEstablecimiento.Text = ""
        rfv_Establecimiento.Enabled = False
        ddl_grado_escolar.Enabled = False
        ddl_grado_escolar.SelectedValue = 0
        rev_GradoEscolar.Enabled = False
        rev_Municipio.Enabled = False

        If ddl_Estudia_Actualmente.SelectedValue = 19 Then
            ddl_Motivo_NoEstudia.Enabled = False
            rev_Motivo_NoEstudia.Enabled = False
            ddl_Motivo_NoEstudia.SelectedValue = 0
            txtEstablecimiento.Enabled = True
            rfv_Establecimiento.Enabled = True
            ddl_grado_escolar.Enabled = True
            rev_GradoEscolar.Enabled = True
            ddl_Certificado_Matricula.Enabled = True
            rev_Certificado.Enabled = True
            ddl_Departamento_Instituto.Enabled = True
            ddl_municipio_Instituto.Enabled = True
            rev_Municipio.Enabled = True
        End If

        If ddl_Estudia_Actualmente.SelectedValue = 20 Then
            ddl_Motivo_NoEstudia.Enabled = True
            rev_Motivo_NoEstudia.Enabled = True
            txtEstablecimiento.Enabled = False
            txtEstablecimiento.Text = ""
            rfv_Establecimiento.Enabled = False
            ddl_grado_escolar.Enabled = False
            ddl_grado_escolar.SelectedValue = 0
            rev_GradoEscolar.Enabled = False
            ddl_Certificado_Matricula.Enabled = False
            rev_Certificado.Enabled = False
            ddl_Departamento_Instituto.Enabled = False
            ddl_Departamento_Instituto.SelectedValue = 0
            ddl_Departamento_Instituto_SelectedIndexChanged(Nothing, Nothing)
            ddl_municipio_Instituto.Enabled = False
            rev_Municipio.Enabled = False

        End If

    End Sub

    Public Sub subCommandItem(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Select Case e.CommandName
            Case "Eliminar"
                subEliminar(sender, e)
        End Select
    End Sub

    Protected Sub Rg_Listado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rg_Listado.SelectedIndexChanged
        Dim item As Telerik.Web.UI.GridDataItem = Me.Rg_Listado.SelectedItems.Item(Rg_Listado.SelectedIndexes.Item(0))

        Dim objPersonas_Educacion As Personas_EducacionBrl = Personas_EducacionBrl.CargarPorID(item("id").Text)
        lblId.Text = ""
        If objPersonas_Educacion IsNot Nothing Then
            rdpfecha.SelectedDate = objPersonas_Educacion.Fecha
            If ddl_Estudia_Actualmente.Items.FindByValue(objPersonas_Educacion.Id_Estudia_Actualmente) IsNot Nothing Then ddl_Estudia_Actualmente.SelectedValue = objPersonas_Educacion.Id_Estudia_Actualmente
            ddl_Estudia_Actualmente_SelectedIndexChanged(Nothing, Nothing)
            If ddl_Motivo_NoEstudia.Items.FindByValue(objPersonas_Educacion.Id_Motivo_NoEstudia) IsNot Nothing Then ddl_Motivo_NoEstudia.SelectedValue = objPersonas_Educacion.Id_Motivo_NoEstudia
            If ddl_Estudia_Actualmente.SelectedValue = 20 Then
                ddl_Motivo_NoEstudia_SelectedIndexChanged(Nothing, Nothing)
            End If
            If ddl_Certificado_Matricula.Items.FindByValue(objPersonas_Educacion.Id_Certificado_Matricula) IsNot Nothing Then ddl_Certificado_Matricula.SelectedValue = objPersonas_Educacion.Id_Certificado_Matricula
            If ddl_Seguimiento.Items.FindByValue(objPersonas_Educacion.Id_Seguimiento) IsNot Nothing Then ddl_Seguimiento.SelectedValue = objPersonas_Educacion.Id_Seguimiento
            txtEstablecimiento.Text = objPersonas_Educacion.Establecimiento
            If ddl_grado_escolar.Items.FindByValue(objPersonas_Educacion.Id_grado_escolar) IsNot Nothing Then ddl_grado_escolar.SelectedValue = objPersonas_Educacion.Id_grado_escolar
            lblId.Text = objPersonas_Educacion.ID
            rdb_verificacion.SelectedValue = objPersonas_Educacion.Verificado_Entidad
            txt_observaciones.Text = objPersonas_Educacion.Observaciones
            If objPersonas_Educacion.Id_Municipio_Instituto <> 0 Then
                ddl_Departamento_Instituto.SelectedValue = objPersonas_Educacion.Municipio_Institucion.Id_Padre
                ddl_Departamento_Instituto_SelectedIndexChanged(Nothing, Nothing)
                ddl_municipio_Instituto.SelectedValue = objPersonas_Educacion.Id_Municipio_Instituto
            End If

            ddl_Certificado_Matricula_SelectedIndexChanged(Nothing, Nothing)
            rdb_verificacion_SelectedIndexChanged(Nothing, Nothing)
        End If

    End Sub

    Protected Sub Rg_Listado_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Listado.NeedDataSource
        Rg_Listado.DataSource = Session("Educacion")
    End Sub

    Public Sub subEliminar(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Dim lblIdInterno As Label
        lblIdInterno = e.Item.FindControl("lblId")
        Dim objPersona_Educacion As Personas_EducacionBrl
        objPersona_Educacion = Personas_EducacionBrl.CargarPorID(lblIdInterno.Text)
        If objPersona_Educacion.Cierre = False Then
            objPersona_Educacion.Eliminar()

            Dim objPersonas_Educacion As List(Of Personas_EducacionBrl) = Personas_EducacionBrl.CargarPorId_Persona(Request.QueryString.Item("ID"))

            Session("Educacion") = objPersonas_Educacion
            Rg_Listado.DataSource = Session("Educacion")
            Rg_Listado.DataBind()
        Else
            lblMensaje.Text = "Registro Cerrado. No se puede Eliminar.!!!!"
            lblMensaje.Visible = True
        End If
    End Sub

    Protected Sub ddl_Certificado_Matricula_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_Certificado_Matricula.SelectedIndexChanged
        ddl_Seguimiento.SelectedValue = 19
        If ddl_Certificado_Matricula.SelectedValue = 19 Then
            ddl_Seguimiento.SelectedValue = 20
        End If
        If ddl_Certificado_Matricula.SelectedValue = 20 Then
            ddl_Seguimiento.SelectedValue = 19
        End If
    End Sub

    Protected Sub rdb_verificacion_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdb_verificacion.SelectedIndexChanged
        If rdb_verificacion.SelectedValue = "1" Then
            If ddl_Estudia_Actualmente.SelectedValue = 19 Then
                ddl_Seguimiento.SelectedValue = 20
            End If
        Else
            ddl_Seguimiento.SelectedValue = 19
        End If
    End Sub

    Protected Sub btn_nuevo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_nuevo.Click
        Response.Redirect("../webforms/Personas_Educacion.aspx?Editar= 1&Id=" + Request.QueryString.Item("Id"))
    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/Personas_EducacionList.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        If Request.QueryString.Item("Id") > 0 Then
            Response.Redirect("../webforms/Personas_Educacion.aspx?Editar=1&Id=" + Request.QueryString.Item("Id"))
        Else
            btn_nuevo_Click(sender, e)
        End If
    End Sub

    Protected Sub Rg_Listado_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles Rg_Listado.ItemDataBound
        If e.Item.ItemType = GridItemType.AlternatingItem Or e.Item.ItemType = GridItemType.Item Then
            Dim lbltipo1 As New Label
            lbltipo1 = e.Item.FindControl("lblTipoSeguimiento")
            Select Case lbltipo1.Text
                Case Is = "918" 'Segunda Entrega

                    e.Item.Cells(12).Visible = False
                    e.Item.Cells(5).ForeColor = Drawing.Color.Orange
                Case Is = "72"  'Primera Entrega

                    e.Item.Cells(12).Visible = False
                    e.Item.Cells(5).ForeColor = Drawing.Color.Navy
                Case Else
                    e.Item.Cells(5).ForeColor = Drawing.Color.Brown
            End Select


        End If
    End Sub

    Protected Sub ddl_Motivo_NoEstudia_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ddl_Motivo_NoEstudia.SelectedIndexChanged
        If ddl_Motivo_NoEstudia.SelectedValue = 1693 Then
            ddl_Certificado_Matricula.SelectedValue = 19
        Else
            ddl_Certificado_Matricula.SelectedValue = Nothing
        End If
        ddl_Certificado_Matricula_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Protected Sub ddl_Departamento_Instituto_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddl_Departamento_Instituto.SelectedIndexChanged
        BindHelper.SubTablasUIL.BindToListControlPorId_TablaPadre(ddl_municipio_Instituto, 15, ddl_Departamento_Instituto.SelectedValue, New ListItem("Seleccione", 0))
    End Sub
End Class
