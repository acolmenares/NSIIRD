<%@ Page Language="VB" AutoEventWireup="false" CodeFile="PlanillaExcel.aspx.vb" Inherits="WebForms_PlanillaExcel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sistema de Planilla de Entregas por Programa</title>
    <style type="text/css">
        .style2
        {
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <telerik:RadScriptManager ID="RadScriptManager1" Runat="server"/>
               

		<table id="tbl_planilla" align="left" border="0" cellpadding="0" 
            cellspacing="0" style="width:100%;">
            <tr>
                <td align="center" colspan="6">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/IRDCompleto.jpg"     />
                       
                </td>
            </tr>
            <tr>
                <td align="center" colspan="6">
                    <asp:Label ID="Label13" runat="server" Font-Bold="True" Font-Size="Medium" 
                        Text="Control de Entregas IRD Colombia"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="6">
                    <asp:Label ID="Label14" runat="server" Font-Italic="True" Font-Size="Small" 
                        Text="Programa : PRM &quot;Cerrando Brechas en la asistencia humanitaria a la población desplazada en Colombia&quot;"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 17%">
                    <asp:Label ID="Label2" runat="server" CssClass="style2" Font-Italic="False" 
                        Font-Size="Small" Text="Regional"></asp:Label>
                </td>
                <td style="width: 17%; border-bottom-width: thin; border-bottom-style: solid;">
                    <asp:Label ID="lbl_Regional" runat="server" Text="."></asp:Label>
                </td>
                <td style="width: 17%">
                    <asp:Label ID="Label3" runat="server" CssClass="style2" Font-Italic="False" 
                        Font-Size="Small" Text="Municipio :"></asp:Label>
                </td>
                <td style="width: 17%; border-bottom-width: thin; border-bottom-style: solid;">
                    <asp:Label ID="lbl_Municipio" runat="server" Text="."></asp:Label>
                </td>
                <td style="width: 17%">
                    <asp:Label ID="Label1" runat="server" CssClass="style2" Font-Italic="False" 
                        Font-Size="Small" Text="Tipo de Entrega :"></asp:Label>
                </td>
                <td style="width: 17%; border-bottom-width: thin; border-bottom-style: solid;">
                    <asp:Label ID="lbl_TipoEntrega" runat="server" Text="."></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="6">

        

		<telerik:RadGrid ID="Rg_Listado" runat="server" GridLines="None" Skin="WebBlue" 
            Width="100%" ShowStatusBar="True" TabIndex="6" PageSize="20" CellSpacing="0">

            <ExportSettings>
                <Pdf AllowPrinting="False" PageWidth="">
                </Pdf>
            </ExportSettings>

            <AlternatingItemStyle BackColor="White" Cssclass="DataGridAlternatingItemStyle" />
            <ItemStyle BackColor="#E3EAEB" Cssclass="DataGridItemStyle" />
            <MasterTableView  NoDetailRecordsText="No hay informaci&#243;n." NoMasterRecordsText="No hay informaci&#243;n."  >
               
                <CommandItemSettings ShowAddNewRecordButton="False" />
               
                <Columns>
                          
   
				</Columns>
               </MasterTableView>
        </telerik:RadGrid>
                </td>
            </tr>
            <tr>
                <td style="width: 17%">
                    <asp:Label ID="Label7" runat="server" Text="Nota :"></asp:Label>
                </td>
                <td colspan="5" style="border-bottom-style: solid; border-bottom-width: thin">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 17%">
                    <asp:Label ID="Label8" runat="server" CssClass="style2" Font-Italic="False" 
                        Font-Size="Small" Text="Elaborado Por :"></asp:Label>
                </td>
                <td style="width: 17%; border-bottom-style: solid; border-bottom-width: thin;">
                    <asp:Label ID="lbl_elaborado" runat="server" Text="."></asp:Label>
                </td>
                <td style="width: 17%">
                    <asp:Label ID="Label9" runat="server" CssClass="style2" Font-Italic="False" 
                        Font-Size="Small" Text="Fecha :"></asp:Label>
                </td>
                <td style="width: 17%; border-bottom-width: thin; border-bottom-style: solid;">
                    <asp:Label ID="lbl_Fecha" runat="server" Text="."></asp:Label>
                </td>
                <td style="width: 17%">
                    <asp:Label ID="Label12" runat="server" CssClass="style2" Font-Italic="False" 
                        Font-Size="Small" Text="Registro de Programación:"></asp:Label>
                </td>
                <td style="width: 17%; border-bottom-width: thin; border-bottom-style: solid;">
                    <asp:Label ID="lbl_programa" runat="server" Text="."></asp:Label>
                </td>
            </tr>
        </table>    
    </div>
    </form>
</body>
</html>
