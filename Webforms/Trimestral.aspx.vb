Imports ingNovar.Utilidades2
Imports System.Collections.Generic

Partial Class WebForms_Trimestral
    Inherits System.Web.UI.Page

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

        If Request.QueryString.Item("Editar") = 1 Then
            Dim objTrimestral As TrimestralBRL = TrimestralBRL.CargarPorID(Request.QueryString.Item("ID"))

            If objTrimestral Is Nothing Then
                lblMensaje.Text = "Registro no existe"
                lblMensaje.Visible = True
                Exit Sub
            End If

            txtDescripcion.Text = objTrimestral.Descripcion
            rdpFechaInicial.SelectedDate = objTrimestral.Fecha_Inicial
            rdpFechaFinal.SelectedDate = objTrimestral.Fecha_Final

            ' cargue de grupos libres

            BindHelper.SubTablasUIL.BindToListControlPorGruposLibres(Me.List_GruposLibres)
            BindHelper.Trimestral_GruposUIL.BindToListControlPorId_Trimestral(Me.List_GruposActivos, Request.QueryString.Item("ID"))
        End If

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Validate()
        If Not IsValid Then Exit Sub

        Dim ID As Int32

        Try
            ID = Grabar()
            Response.Redirect("Trimestral.aspx?Editar=1&Mensaje=1&ID=" & ID)
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Private Sub btnGuardarOtro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarOtro.Click
        Validate()
        If Not IsValid Then Exit Sub

        Try
            Grabar()
            Response.Redirect("Trimestral.aspx?Mensaje=1")
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Private Function Grabar() As Int32

        Dim objTrimestral As TrimestralBrl

        If Request.QueryString.Item("Editar") = 1 Then
            objTrimestral = TrimestralBrl.CargarPorID(Request.QueryString.Item("ID"))
        Else
            objTrimestral = New TrimestralBrl
        End If

        objTrimestral.Descripcion = txtDescripcion.Text
        objTrimestral.Fecha_Inicial = rdpFechaInicial.SelectedDate
        objTrimestral.Fecha_Final = rdpFechaFinal.SelectedDate

        objTrimestral.Guardar()

        Return objTrimestral.ID

    End Function

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        If Request.QueryString.Item("Editar") = 1 Then
            If Me.List_GruposLibres.SelectedValue <> 0 Then
                Dim objtrimestral As New Trimestral_GruposBrl
                objtrimestral.Id_Grupo = List_GruposLibres.SelectedValue
                objtrimestral.Id_Trimestral = Request.QueryString.Item("Id")
                objtrimestral.Guardar()
            End If

            BindHelper.SubTablasUIL.BindToListControlPorGruposLibres(Me.List_GruposLibres)
            BindHelper.Trimestral_GruposUIL.BindToListControlPorId_Trimestral(Me.List_GruposActivos, Request.QueryString.Item("ID"))
        Else
            lblMensaje.Text = "Primero debe grabar el trimestre. Despues asigne grupos."
            lblMensaje.Visible = False
            lblMensaje.ForeColor = Drawing.Color.Red
        End If

    End Sub

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        Dim objgrupotrimestral As Trimestral_GruposBrl
        objgrupotrimestral = Trimestral_GruposBrl.CargarPorID(Me.List_GruposActivos.SelectedValue)
        objgrupotrimestral.Eliminar()

        BindHelper.SubTablasUIL.BindToListControlPorGruposLibres(Me.List_GruposLibres)
        BindHelper.Trimestral_GruposUIL.BindToListControlPorId_Trimestral(Me.List_GruposActivos, Request.QueryString.Item("ID"))

    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        Response.Redirect("../webforms/Trimestral.aspx")
    End Sub
End Class
