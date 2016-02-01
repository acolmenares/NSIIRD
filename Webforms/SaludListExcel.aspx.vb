
Partial Class WebForms_SaludListExcel
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.ContentType = "application/vnd.ms-excel"
        dgListado.DataSource = Session("ListSaludExcel")
        dgListado.DataBind()
        Response.AddHeader("Content-Disposition", "attachment;filename=Salud.xls")
        Response.Charset = "UTF-8"
        Response.ContentEncoding = Encoding.Default
    End Sub
End Class
