<%@ Page Language="VB" AutoEventWireup="false" CodeFile="TiposMercadoExcel.aspx.vb" Inherits="WebForms_TiposMercadoExcel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DataGrid ID="dgtipomercado" runat="server" AutoGenerateColumns="False" CellPadding="4"
            ForeColor="#333333" GridLines="None" Width="100%">
            <FooterStyle BackColor="#1C5E55" Cssclass="DataGridFooterStyle" Font-Bold="True"
                ForeColor="White" />
            <EditItemStyle BackColor="#7C6F57" Cssclass="DataGridEditItemStyle" />
            <SelectedItemStyle BackColor="#C5BBAF" Cssclass="DataGridSelectedItemStyle" Font-Bold="True"
                ForeColor="#333333" />
            <PagerStyle BackColor="#666666" Cssclass="PagerStyle" ForeColor="White" HorizontalAlign="Center"
                Mode="NumericPages" />
            <AlternatingItemStyle BackColor="White" Cssclass="DataGridAlternatingItemStyle" />
            <ItemStyle BackColor="#E3EAEB" Cssclass="DataGridItemStyle" />
            <Columns>
                  <asp:TemplateColumn HeaderText="Tipo" >
                    <ItemTemplate>
                        <%#DataBinder.Eval(Container, "DataItem.Tipo")%>
                    </ItemTemplate>
                    <HeaderStyle Width="50px" HorizontalAlign ="Center" />
                    <ItemStyle Width="50px" HorizontalAlign ="Center" />
                </asp:TemplateColumn>
                <asp:TemplateColumn HeaderText="Cantidad" >
                    <ItemTemplate>
                        <%# DataBinder.Eval(Container, "DataItem.Cantidad") %>
                    </ItemTemplate>
                    <HeaderStyle Width="50px" HorizontalAlign ="Center" />
                    <ItemStyle Width="50px" HorizontalAlign ="Center" />
                </asp:TemplateColumn>
            </Columns>
            
            <HeaderStyle BackColor="#1C5E55" Cssclass="DataGridHeaderStyle" Font-Bold="True"
                ForeColor="White" />
        </asp:DataGrid>    
    </div>
    </form>
</body>
</html>
