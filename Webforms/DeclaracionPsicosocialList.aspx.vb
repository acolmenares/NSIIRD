Imports System.Collections.Generic
Imports ingNovar.Utilidades2
Imports System.Data
Imports Telerik.Web.UI
Imports Especiales

Partial Class WebForms_DeclaracionPsicosocialList
    Inherits System.Web.UI.Page

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
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_grupo, 26, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Fuente, 6, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_LugarFuente, 73, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_tipodeclarante, 76, New ListItem("Seleccione", 0))

        Dim ListPsicosocial As List(Of DeclaracionBrl) = Session("ListPsicosocial")

        'si no hay una variable de sesión con la lista.
        If ListPsicosocial Is Nothing Or Request.QueryString.Item("Refrescar") = 1 Then
            ListPsicosocial = DeclaracionBrl.CargarPorId_Regional(0)
            Session("ListPsicosocial") = ListPsicosocial
        End If

        Rg_Listado.DataSource = Session("ListPsicosocial")
        Rg_Listado.DataBind()

    End Sub

    Protected Sub Rg_Listado_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Listado.NeedDataSource
        Rg_Listado.DataSource = Session("ListPsicosocial")
    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        Response.Redirect("../webforms/DeclaracionPsicosocialList.aspx?Refrescar=1")
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
        Session.Remove("ListPsicosocial")
        Dim ListPsicosocial As New List(Of DeclaracionBrl)
        ListPsicosocial = DeclaracionBrl.CargarPorId_Regional(0)
        Session("ListPsicosocial") = ListPsicosocial
        txt_identificacion.Text = ""
        ddl_grupo.SelectedValue = 0
        ddl_regional.SelectedValue = 0
        txt_nombre.Text = ""
        ddl_regional.SelectedValue = 0
        ddl_LugarFuente.SelectedValue = 0
        rdpfechaFinalDeclaracion.SelectedDate = Nothing
        rdpfechaInicialDeclaracion.SelectedDate = Nothing
        rdpfechaFinalEntrega.SelectedDate = Nothing
        rdpfechaInicialEntrega.SelectedDate = Nothing
        rdpfechaInicialDeclaracion.SelectedDate = Nothing
        rdpfechaFinalDeclaracion.SelectedDate = Nothing
        Rg_Listado.DataSource = Session("ListPsicosocial")
        Rg_Listado.DataBind()
    End Sub

    Protected Sub btn_Procesar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_Procesar.Click
        Dim whorario As String = ""
        Dim wdeclarante As Integer = 0

        Session.Remove("ListPsicosocial")
        Dim ListPsicosocial As New List(Of DeclaracionBrl)
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

        Dim wfechainiciodeclaracion As String = ""
        Dim wfechafinaldeclaracion As String = ""
        If rdpfechaInicialDeclaracion.SelectedDate.ToString.Trim <> "" Then
            wfechainiciodeclaracion = ajustarFecha10digitos(rdpfechaInicialDeclaracion.SelectedDate)
        End If
        If rdpfechaFinalDeclaracion.SelectedDate.ToString.Trim <> "" Then
            wfechafinaldeclaracion = ajustarFecha10digitos(rdpfechaFinalDeclaracion.SelectedDate)
        End If

        ListPsicosocial = DeclaracionBrl.CargarBusquedaDeclaraciones(0, ddl_grupo.SelectedValue, txt_identificacion.Text.Trim, txt_nombre.Text.Trim, ddl_regional.SelectedValue, wfechainicioradicacion, wfechafinalradicacion, wfechainicioentrega, wfechafinalentrega, ddl_Fuente.SelectedValue, wfechainiciodeclaracion, wfechafinaldeclaracion, whorario, ddl_tipodeclarante.SelectedValue, ddl_LugarFuente.SelectedValue, "A")
        Session("ListPsicosocial") = ListPsicosocial
        Rg_Listado.DataSource = Session("ListPsicosocial")
        Rg_Listado.DataBind()


        '
        ' Crear el archivo de Excel que se necesita para la exportacion
        '
        Dim wusuario As Integer = CType(Master.FindControl("lblidusuario"), Label).Text

        DeclaracionDAL.CargarBusquedaPsicosocial(wusuario, ddl_grupo.SelectedValue, txt_identificacion.Text.Trim, txt_nombre.Text.Trim, ddl_regional.SelectedValue, wfechainicioradicacion, wfechafinalradicacion, wfechainicioentrega, wfechafinalentrega, ddl_Fuente.SelectedValue, wfechainiciodeclaracion, wfechafinaldeclaracion, whorario, ddl_tipodeclarante.SelectedValue, ddl_LugarFuente.SelectedValue)

        Dim List_tmppsicosocial As List(Of Tmp_PsicosocialBrl)
        List_tmppsicosocial = Tmp_PsicosocialBrl.CargarPorID_Usuario(wusuario)

        Session("Tmp_Psicosocial") = List_tmppsicosocial


    End Sub
End Class
