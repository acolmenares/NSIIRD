
Partial Class WebForms_DeclaracionExcel
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.ContentType = "application/vnd.ms-excel"
        Rg_Listado.DataSource = Session("ListDeclaracion")
        Rg_Listado.DataBind()
        Response.AddHeader("Content-Disposition", "attachment;filename=Declaracion.xls")
        Response.Charset = "UTF-8"
        Response.ContentEncoding = Encoding.Default
    End Sub

End Class
