<%@ Page Language="VB" AutoEventWireup="false" CodeFile="SaludRemisionesListExcel.aspx.vb" Inherits="WebForms_SaludRemisionesListExcel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <asp:DataGrid ID="dgListado" runat="server" AutoGenerateColumns="False" CellPadding="4"
            ForeColor="#333333" GridLines="None" Width="100%">
            <FooterStyle BackColor="#1C5E55" Cssclass="DataGridFooterStyle" Font-Bold="True" ForeColor="White" />
            <EditItemStyle BackColor="#7C6F57" Cssclass="DataGridEditItemStyle" />
            <SelectedItemStyle BackColor="#C5BBAF" Cssclass="DataGridSelectedItemStyle" Font-Bold="True"
                ForeColor="#333333" />
            <PagerStyle BackColor="#666666" Cssclass="PagerStyle" ForeColor="White" HorizontalAlign="Center"
                Mode="NumericPages" />
            <AlternatingItemStyle BackColor="White" Cssclass="DataGridAlternatingItemStyle" />
            <ItemStyle BackColor="#E3EAEB" Cssclass="DataGridItemStyle" />
            <Columns>
                <asp:TemplateColumn HeaderText="No.">
                    <ItemTemplate>
					    <%# ctype(CType(Container.Parent.Parent,DataGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>
                    </ItemTemplate>
                    <HeaderStyle Width="25px" />
                </asp:TemplateColumn>
                <asp:TemplateColumn HeaderText="Grupo" >
                    <ItemTemplate>
                        <%#Container.DataItem.Salud.Personas.Declaracion.DescripcionGrupo%>
                    </ItemTemplate>
                    <HeaderStyle Width="50px" />
                </asp:TemplateColumn>
                <asp:TemplateColumn HeaderText="TD" >
                    <ItemTemplate>
                        <%#Container.DataItem.Salud.Personas.Declaracion.Declarante%>
                    </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Center" Width="10px" />
                    <ItemStyle Width="10px" />
                </asp:TemplateColumn>                
                
                <asp:TemplateColumn HeaderText="TI" >
                    <ItemTemplate>
                        <%#Container.DataItem.Salud.Personas.SubTablasTipo_Identificacion.Descripcion%>
                    </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Center" Width="100px" />
                    <ItemStyle Width="100px" />
                </asp:TemplateColumn>                
                <asp:TemplateColumn HeaderText="Número" >
                    <ItemTemplate>
                        <%# Container.DataItem.Salud.Personas.Identificacion %>
                    </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Center" Width="75px" />
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Edad" >
                    <ItemTemplate>
                        <%#Container.DataItem.Salud.Personas.Edad%>
                    </ItemTemplate>
                    <HeaderStyle Width="50px" />
                </asp:TemplateColumn>                

                <asp:TemplateColumn HeaderText="Nombre Completo" >
                    <ItemTemplate>
                        <%#Container.DataItem.Salud.Personas.NombreCompleto%>
                    </ItemTemplate>
                    <HeaderStyle Width="300px" />
                </asp:TemplateColumn>
                
                <asp:TemplateColumn HeaderText="Genero" >
                    <ItemTemplate>
                        <%#Container.DataItem.Salud.Personas.Genero%>
                    </ItemTemplate>
                    <HeaderStyle Width="80px" />
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Declarante" >
                    <ItemTemplate>
                        <%# Container.DataItem.Salud.Personas.Declaracion.Personas_Declarante.NombreCompleto %>
                    </ItemTemplate>
                    <HeaderStyle Width="300px" />
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Identificación" >
                    <ItemTemplate>
                        <%#Container.DataItem.Salud.Personas.Declaracion.Personas_Declarante.Identificacion%>
                    </ItemTemplate>
                    <HeaderStyle Width="150px" />
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Entidad Rem " >
                    <ItemTemplate>
                        <%#Container.DataItem.Entidad_Remision.Descripcion%>
                    </ItemTemplate>
                    <HeaderStyle Width="100px" />
                </asp:TemplateColumn>
                
                <asp:TemplateColumn HeaderText="Fecha Rem." >
                    <ItemTemplate>
                        <%#ingNovar.Utilidades2.FechaUtil.toStringDDMMYYY(Container.DataItem.Fecha_Remision)%>
                    </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Center" Width="100px" />
                    <ItemStyle Width="100px" />
                </asp:TemplateColumn>                

                <asp:TemplateColumn HeaderText="Fecha ING." >
                    <ItemTemplate>
                        <%#ingNovar.Utilidades2.FechaUtil.toStringDDMMYYY(Container.DataItem.Fecha_Ingreso)%>
                    </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Center" Width="100px" />
                    <ItemStyle Width="100px" />
                </asp:TemplateColumn> 
                
                <asp:TemplateColumn HeaderText="Fecha FIN." >
                    <ItemTemplate>
                        <%#ingNovar.Utilidades2.FechaUtil.toStringDDMMYYY(Container.DataItem.Fecha_Retiro)%>
                    </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Center" Width="100px" />
                    <ItemStyle Width="100px" />
                </asp:TemplateColumn> 

                <asp:TemplateColumn HeaderText="Entidad Inf " >
                    <ItemTemplate>
                        <%#Container.DataItem.Entidad_Informacion.Descripcion%>
                    </ItemTemplate>
                    <HeaderStyle Width="100px" />
                </asp:TemplateColumn>


                <asp:TemplateColumn HeaderText="Observaciones" >
                    <ItemTemplate>
                        <%#Container.DataItem.Observaciones%>
                    </ItemTemplate>
                    <HeaderStyle Width="100px" />
                </asp:TemplateColumn>  

            </Columns>
            <HeaderStyle BackColor="#1C5E55" Cssclass="DataGridHeaderStyle" Font-Bold="True"
                ForeColor="White" />
        </asp:DataGrid>   
    </div>
    </form>
</body>
</html>
