
Partial Class WebForms_TiposMercadoExcel
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Response.ContentType = "application/vnd.ms-excel"
        dgtipomercado.DataSource = Session("TipoMercado")
        dgtipomercado.DataBind()

    End Sub
End Class
