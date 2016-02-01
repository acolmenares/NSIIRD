Imports Telerik.Web.UI

Partial Class WebForms_PlanillaExcel
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim objprograma As ProgramacionBrl = ProgramacionBrl.CargarPorID(Session("IdPrograma"))
        lbl_Regional.Text = objprograma.Regionales.Descripcion
        lbl_Municipio.Text = objprograma.LugarEntrega.Descripcion
        lbl_TipoEntrega.Text = objprograma.TipoEntrega.Descripcion
        lbl_Fecha.Text = Now.ToLongDateString
        lbl_programa.Text = objprograma.Numero
        lbl_elaborado.Text = Session("NombreUsuario")
        Image1.ImageUrl = "../Images/IRDCompleto.jpg"
        Response.ContentType = "application/vnd.ms-excel"
        Rg_Listado.DataSource = Session("PlanillaPrograma")
        Rg_Listado.DataBind()
        Dim wcolumna As New GridTemplateColumn
        wcolumna.HeaderText = "Firma"
        wcolumna.UniqueName = "Firma"
        wcolumna.OrderIndex = 30
        wcolumna.ConvertEmptyStringToNull = True
        Rg_Listado.MasterTableView.Columns.Add(wcolumna)
        wcolumna = New GridTemplateColumn
        wcolumna.HeaderText = "Observaciones"
        wcolumna.UniqueName = "Observaciones"
        wcolumna.OrderIndex = 31
        wcolumna.ConvertEmptyStringToNull = True
        Rg_Listado.MasterTableView.Columns.Add(wcolumna)
        Rg_Listado.Rebind()
        Response.AddHeader("Content-Disposition", "attachment;filename=Planilla" + lbl_programa.Text.Trim + ".xls")
        Response.Charset = "UTF-8"
        Response.ContentEncoding = Encoding.Default
    End Sub

End Class
