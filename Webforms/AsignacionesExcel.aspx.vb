
Partial Class WebForms_AsignacionesExcel
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.ContentType = "application/vnd.ms-excel"
        Rg_Listado.DataSource = Session("ListDeclaracionAsignacion")
        Rg_Listado.DataBind()
        Response.AddHeader("Content-Disposition", "attachment;filename=Asignaciones.xls")
        Response.Charset = "UTF-8"
        Response.ContentEncoding = Encoding.Default
    End Sub

End Class
