
Partial Class WebForms_SaludRemisionesListExcel
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.ContentType = "application/vnd.ms-excel"
        dgListado.DataSource = Session("SaludRemisiones")
        dgListado.DataBind()

    End Sub
End Class
