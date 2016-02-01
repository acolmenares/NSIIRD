Imports System.Collections.Generic
Imports ingNovar.Utilidades2
Imports System.Data
Imports Especiales
Imports Telerik.Web.UI

Partial Class WebForms_Declaracion_IngresoList
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

            btn_buscar.Enabled = objper_perfil.Pconsultar
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToCsvButton = objper_perfil.Pexportarcsv
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToExcelButton = objper_perfil.Pexportarexcel
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToPdfButton = objper_perfil.Pexportarpdf
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToWordButton = objper_perfil.Pexportarword
            ddl_Regional.Enabled = objper_perfil.Pvertodo

            Rg_Listado.Columns(11).Visible = objper_perfil.Peliminar
        End If

        If objper_usuario IsNot Nothing Then
            If objper_usuario.Pver = False Or objper_usuario.Pconsultar = False Then
                Response.Redirect(strPaginaError)
                Exit Sub
            End If

            ' asignando los permisos

            btn_buscar.Enabled = objper_usuario.Pconsultar
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToCsvButton = objper_usuario.Pexportarcsv
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToExcelButton = objper_usuario.Pexportarexcel
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToPdfButton = objper_usuario.Pexportarpdf
            Rg_Listado.MasterTableView.CommandItemSettings.ShowExportToWordButton = objper_usuario.Pexportarword
            ddl_regional.Enabled = objper_usuario.Pvertodo

            Rg_Listado.Columns(11).Visible = objper_usuario.Peliminar
        End If

        ' Definiendo el dato de la regional
        ddl_Regional.SelectedValue = SeguridadUsuarios.Usuarios.RegionalUsuario(CType(Session("IdUsuario"), Integer))

    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Me.IsPostBack Then Exit Sub
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


        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_regional, 72, New ListItem("Seleccione", 0))
        ddl_regional_SelectedIndexChanged(Nothing, Nothing)
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Fuente, 6, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_LugarFuente, 73, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_tipodeclarante, 76, New ListItem("Seleccione", 0))

        Dim ListDeclaracion As List(Of DeclaracionBrl) = Session("ListDeclaracionIngreso")

        'si no hay una variable de sesión con la lista.
        If ListDeclaracion Is Nothing Or Request.QueryString.Item("Refrescar") = 1 Then
            ListDeclaracion = DeclaracionBrl.CargarPorId_Regional(0)
            Session("ListDeclaracionIngreso") = ListDeclaracion
        End If

        Rg_Listado.DataSource = Session("ListDeclaracionIngreso")
        Rg_Listado.DataBind()

    End Sub

    Protected Sub Rg_Listado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rg_Listado.SelectedIndexChanged
        Dim item As Telerik.Web.UI.GridDataItem = Me.Rg_Listado.SelectedItems.Item(Rg_Listado.SelectedIndexes.Item(0))
        Response.Redirect("Declaracion_Ingreso.aspx?Editar=1&ID=" & item("id").Text)
    End Sub

    Protected Sub Rg_Listado_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Listado.NeedDataSource
        Rg_Listado.DataSource = Session("ListDeclaracionIngreso")
    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_nuevo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_nuevo.Click
        Response.Redirect("../webforms/Declaracion_Ingreso.aspx")
    End Sub

    Protected Sub btn_buscar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_buscar.Click
        If pnl_buscar.Visible Then
            pnl_buscar.Visible = False
            btn_buscar.ImageUrl = "~/Images/Zoom In.jpg"
        Else
            pnl_buscar.Visible = True
            btn_buscar.ImageUrl = "~/Images/Zoom Out.jpg"
        End If
    End Sub

    Protected Sub btn_limpiar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_limpiar.Click
        Session.Remove("ListDeclaracionIngreso")
        Dim ListDeclaracion As New List(Of DeclaracionBrl)
        ListDeclaracion = DeclaracionBrl.CargarPorId_Regional(0)
        Session("ListDeclaracionIngreso") = ListDeclaracion
        txt_identificacion.Text = ""
        ddl_regional.SelectedValue = SeguridadUsuarios.Usuarios.RegionalUsuario(CType(Session("IdUsuario"), Integer))
        ddl_regional_SelectedIndexChanged(Nothing, Nothing)
        txt_nombre.Text = ""
        ddl_Fuente.SelectedValue = 0
        ddl_tipodeclarante.SelectedValue = 0
        rdb_Horario.ClearSelection()
        rdpfechaFinalRadicacion.SelectedDate = Nothing
        rdpfechaInicialRadicacion.SelectedDate = Nothing
        rdpfechaInicialEntrega.SelectedDate = Nothing
        rdpfechaFinalEntrega.SelectedDate = Nothing
        Rg_Listado.DataSource = Session("ListDeclaracionIngreso")
        Rg_Listado.DataBind()
    End Sub

    Protected Sub btn_Procesar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_Procesar.Click, btn_actualizar.Click
        Dim whorario As String = ""
        Dim wdeclarante As String = ""

        Session.Remove("ListDeclaracionIngreso")
        Dim ListDeclaracion As New List(Of DeclaracionBrl)
        Select Case rdb_Horario.SelectedValue
            Case "TO"
                whorario = ""
            Case "AM", "PM", "TD"
                whorario = rdb_Horario.SelectedValue
            Case Else
                whorario = ""
        End Select

        Dim wfechainicioentrega As String = ""
        Dim wfechafinalentrega As String = ""
        If rdpfechaInicialEntrega.SelectedDate.ToString.Trim <> "" Then
            wfechainicioentrega = ajustarFecha10digitos(rdpfechaInicialEntrega.SelectedDate)
        End If
        If rdpfechaFinalEntrega.SelectedDate.ToString.Trim <> "" Then
            wfechafinalentrega = ajustarFecha10digitos(rdpfechaFinalEntrega.SelectedDate)
        End If

        Dim wfechainicioradicacion As String = ""
        Dim wfechafinalradicacion As String = ""
        If rdpfechaInicialRadicacion.SelectedDate.ToString.Trim <> "" Then
            wfechainicioradicacion = ajustarFecha10digitos(rdpfechaInicialRadicacion.SelectedDate)
        End If
        If rdpfechaFinalRadicacion.SelectedDate.ToString.Trim <> "" Then
            wfechafinalradicacion = ajustarFecha10digitos(rdpfechaFinalRadicacion.SelectedDate)
        End If

        Dim wfechainicioprogramacion As String = ""
        Dim wfechafinalprogramacion As String = ""


        ListDeclaracion = DeclaracionBrl.Cargarbusqueda(0, txt_identificacion.Text.Trim, txt_nombre.Text.Trim, ddl_regional.SelectedValue, wfechainicioradicacion, wfechafinalradicacion, wfechainicioentrega, wfechafinalentrega, ddl_Fuente.SelectedValue, wfechainicioprogramacion, wfechafinalprogramacion, whorario, ddl_tipodeclarante.SelectedValue, ddl_LugarFuente.SelectedValue)
        Session("ListDeclaracionIngreso") = ListDeclaracion
        Rg_Listado.DataSource = Session("ListDeclaracionIngreso")
        Rg_Listado.DataBind()
    End Sub

    Protected Sub ddl_regional_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddl_regional.SelectedIndexChanged
        If ddl_regional.SelectedValue > 0 Then
            BindHelper.SubTablasUIL.BindToListControlPorId_TablaPadre(ddl_LugarFuente, 73, ddl_regional.SelectedValue, New ListItem("Seleccione", 0))
        Else
            BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_LugarFuente, 73, New ListItem("Seleccione", 0))
        End If
    End Sub

    Protected Sub Rg_Listado_DeleteCommand(ByVal source As Object, ByVal e As GridCommandEventArgs) Handles Rg_Listado.DeleteCommand
        Dim ItemId = DirectCast((DirectCast(e.Item, GridDataItem)).GetDataKeyValue("Id"), Integer)
        Dim objregistro As DeclaracionBrl
        Dim wnombre As String = ""
        objregistro = DeclaracionBrl.CargarPorID(ItemId)
        If objregistro IsNot Nothing Then
            ' hay un registro de declaracion
            If objregistro.Declaracion_Estados.Count = 0 Then
                ' No hay registros en estados
                If objregistro.Declaracion_Unidades.Count = 0 Then
                    ' no hay registros de unidades
                    If objregistro.Personas.Count = 1 Then
                        ' solo esta el declarante
                        For Each fila As Personas_ContactosBrl In objregistro.Personas_Declarante.Personas_Contactos
                            fila.Eliminar()
                        Next
                        objregistro = DeclaracionBrl.CargarPorID(ItemId)
                        wnombre = objregistro.Personas_Declarante.NombreCompleto
                        objregistro.Personas_Declarante.Eliminar()
                        objregistro = DeclaracionBrl.CargarPorID(ItemId)
                        objregistro.Eliminar()
                        MsgBox("El registro de declaración de " & wnombre & " ha sido eliminado.", MsgBoxStyle.Information, "REGISTRO INICIAL ELIMINADO")
                        lbl_mensaje.Text = "El registro de declaración de " & wnombre & " ha sido eliminado."

                        btn_Procesar_Click(Nothing, Nothing)
                    Else
                        MsgBox("No se puede eliminar el registro de declaración ya que tiene beneficiarios.", MsgBoxStyle.Information, "Eliminar Registro")
                        lbl_mensaje.Text = "No se puede eliminar el registro de declaración ya que tiene beneficiarios."
                    End If
                Else
                    MsgBox("No se puede eliminar el registro de declaración ya que tiene enlaces en las unidades de apoyo.", MsgBoxStyle.Information, "Eliminar Registro")
                    lbl_mensaje.Text = "No se puede eliminar el registro de declaración ya que tiene enlaces en las unidades de apoyo."
                End If
            Else
                MsgBox("No se puede eliminar el registro de declaración ya que tiene estados realizados en el.", MsgBoxStyle.Information, "Eliminar Registro")
                lbl_mensaje.Text = "No se puede eliminar el registro de declaración ya que tiene estados realizados en el."
            End If
        Else
            MsgBox("No se puede eliminar el registro de declaración ya que no existe en el sistema.", MsgBoxStyle.Information, "Eliminar Registro")
            lbl_mensaje.Text = "No se puede eliminar el registro de declaración ya que no existe en el sistema."
        End If
        lbl_mensaje.Visible = True


    End Sub

End Class
