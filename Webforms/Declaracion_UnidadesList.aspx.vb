Imports System.Collections.Generic
Imports ingNovar.Utilidades2
Imports System.Data
Imports Especiales
Imports Telerik.Web.UI

Partial Class WebForms_Declaracion_UnidadesList
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
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_Fuente, 6, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_LugarFuente, 73, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_tipodeclarante, 76, New ListItem("Seleccione", 0))
        BindHelper.SubTablasUIL.BindToListControlPorId_Tabla(ddl_grupo, 26, New ListItem("Seleccione", 0))

        Dim ListDeclarantesUnidades As List(Of DeclaracionBrl) = Session("ListDeclarantesUnidades")

        'si no hay una variable de sesión con la lista.
        If ListDeclarantesUnidades Is Nothing Or Request.QueryString.Item("Refrescar") = 1 Then
            ListDeclarantesUnidades = DeclaracionBrl.CargarPorId_Regional(0)
            Session("ListDeclarantesUnidades") = ListDeclarantesUnidades
        End If

        Rg_Listado.DataSource = Session("ListDeclarantesUnidades")
        Rg_Listado.DataBind()

    End Sub

    Protected Sub Rg_Listado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rg_Listado.SelectedIndexChanged
        Dim item As Telerik.Web.UI.GridDataItem = Me.Rg_Listado.SelectedItems.Item(Rg_Listado.SelectedIndexes.Item(0))
        Response.Redirect("Declaracion_Unidades.aspx?ID=" & item("id").Text)
    End Sub

    Protected Sub Rg_Listado_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles Rg_Listado.NeedDataSource
        Rg_Listado.DataSource = Session("ListDeclarantesUnidades")
    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        Response.Redirect("../webforms/Declaracion_UnidadesList.aspx?Refrescar=1")
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
        Session.Remove("ListDeclarantesUnidades")
        Dim ListDeclarantesUnidades As New List(Of DeclaracionBrl)
        ListDeclarantesUnidades = DeclaracionBrl.CargarPorId_Regional(0)
        Session("ListDeclarantesUnidades") = ListDeclarantesUnidades
        txt_identificacion.Text = ""
        ddl_regional.SelectedValue = 0
        ddl_LugarFuente.SelectedValue = 0
        txt_nombre.Text = ""
        ddl_regional.SelectedValue = 0
        ddl_grupo.SelectedValue = 0
        rdpfechaInicialEntrega.SelectedDate = Nothing
        rdpfechaFinalEntrega.SelectedDate = Nothing
        Rg_Listado.DataSource = Session("ListDeclarantesUnidades")
        Rg_Listado.DataBind()
    End Sub

    Protected Sub btn_Procesar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_Procesar.Click
        Dim whorario As String = ""
        Dim wdeclarante As String = ""

        Session.Remove("ListDeclarantesUnidades")
        Dim ListDeclarantesUnidades As New List(Of DeclaracionBrl)
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


        Dim wfechainicioprogramacion As String = ""
        Dim wfechafinalprogramacion As String = ""


        ListDeclarantesUnidades = DeclaracionBrl.CargarBusquedaDeclaraciones(0, ddl_grupo.SelectedValue, txt_identificacion.Text.Trim, txt_nombre.Text.Trim, ddl_regional.SelectedValue, wfechainicioradicacion, wfechafinalradicacion, wfechainicioentrega, wfechafinalentrega, ddl_Fuente.SelectedValue, wfechainicioprogramacion, wfechafinalprogramacion, whorario, ddl_tipodeclarante.SelectedValue, ddl_LugarFuente.SelectedValue, "A")
        Session("ListDeclarantesUnidades") = ListDeclarantesUnidades
        Rg_Listado.DataSource = Session("ListDeclarantesUnidades")
        Rg_Listado.DataBind()
    End Sub

    Protected Sub btn_uariv_Click(sender As Object, e As System.EventArgs) Handles btn_uariv.Click
        '
        '  Proceso de Web service contra la unidad 
        '
        Dim ListDeclaraciones As List(Of DeclaracionBrl)
        ListDeclaraciones = DeclaracionBrl.Cargarbusqueda(ddl_grupo.SelectedValue, "", "", ddl_regional.SelectedValue, "", "", rdpfechaInicialEntrega.DbSelectedDate, rdpfechaFinalEntrega.DbSelectedDate, ddl_Fuente.SelectedValue, "", "", "", 0, ddl_LugarFuente.SelectedValue)
        Dim ds As DataSet
        Dim objunidades As Declaracion_UnidadesBrl
        For Each fila As DeclaracionBrl In ListDeclaraciones
            ds = New DataSet
            ds = Class1.ConsultaTodos(fila.Personas_Declarante.Identificacion)
            If ds.Tables.Count > 0 Then
                If ds.Tables(0).Rows.Count > 0 Then
                    For Each filarow As DataRow In ds.Tables(0).Rows

                        If filarow("Estado").ToString.ToUpper = "INCLUIDO" Then
                            objunidades = New Declaracion_UnidadesBrl
                            objunidades.Id_Unidad = 32
                            objunidades.Id_EstadoUnidad = 371
                            objunidades.Fecha_Inclusion = CType(filarow("Fecha_Valoracion"), Date)
                            objunidades.Id_Declaracion = fila.ID
                            objunidades.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
                            objunidades.Fecha_Creacion = Now
                            objunidades.Fecha_Investigacion = Now()
                            objunidades.Fuente = "Web Service " & filarow("Entidad")
                            objunidades.Guardar()
                        End If

                        If filarow("Estado").ToString.ToUpper = "NO INCLUIDO" Then
                            objunidades = New Declaracion_UnidadesBrl
                            objunidades.Id_Unidad = 32
                            objunidades.Id_EstadoUnidad = 372
                            objunidades.Fecha_Inclusion = CType(filarow("Fecha_Valoracion"), Date)
                            objunidades.Id_Declaracion = fila.ID
                            objunidades.Id_Usuario_Creacion = CType(Master.FindControl("lblidusuario"), Label).Text
                            objunidades.Fecha_Creacion = Now
                            objunidades.Fecha_Investigacion = Now()
                            objunidades.Fuente = "Web Service " & filarow("Entidad")
                            objunidades.Guardar()
                        End If


                    Next

                End If
            End If
        Next

        ''Dim dsmiranda As New DataSet
        ''dsmiranda = DeclaracionDAL.cargarbasemiranda
        ''Dim ds As DataSet

        ''For Each miranda As DataRow In dsmiranda.Tables(0).Rows
        ''    ds = New DataSet
        ''    ds = Class1.ConsultaTodos(miranda.Item("Documento").ToString.Trim)
        ''    If ds.Tables.Count > 0 Then
        ''        If ds.Tables(0).Rows.Count > 0 Then
        ''            For Each filarow As DataRow In ds.Tables(0).Rows
        ''                If filarow("Estado").ToString.ToUpper = "INCLUIDO" Then
        ''                    DeclaracionDAL.ActualizarBaseMiranda(miranda.Item("Documento").ToString.Trim, "INCLUIDO", CType(filarow("Fecha_Valoracion"), Date))
        ''                End If

        ''                If filarow("Estado").ToString.ToUpper = "NO INCLUIDO" Then
        ''                    DeclaracionDAL.ActualizarBaseMiranda(miranda.Item("Documento").ToString.Trim, "NO INCLUIDO", CType(filarow("Fecha_Valoracion"), Date))
        ''                End If
        ''            Next
        ''        End If
        ''    End If
        ''Next
    End Sub
End Class
