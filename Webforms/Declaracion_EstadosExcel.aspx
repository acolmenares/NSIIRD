<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Declaracion_EstadosExcel.aspx.vb" Inherits="WebForms_Declaracion_EstadosExcel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <telerik:RadGrid ID="Rg_Listado" runat="server" GridLines="None" Width="100%" 
            AutoGenerateColumns="False" ShowStatusBar="True" TabIndex="6"             
            PageSize="20" CellSpacing="0">
            <ExportSettings>
                <Pdf PageWidth="">
                </Pdf>
            </ExportSettings>
            <AlternatingItemStyle BackColor="White" Cssclass="DataGridAlternatingItemStyle" />
            <ItemStyle BackColor="#E3EAEB" Cssclass="DataGridItemStyle" />
            <MasterTableView  NoDetailRecordsText="No hay informaci&#243;n." NoMasterRecordsText="No hay informaci&#243;n." DataKeyNames="Id" 
                 ShowFooter="False" AllowSorting="False">
                <CommandItemSettings ShowAddNewRecordButton="False" />
                <Columns>
                    <telerik:GridTemplateColumn HeaderText="No." DefaultInsertValue="" UniqueName="TemplateColumn">
                        <ItemTemplate>
                            <asp:label runat="server" id="lblno" text='<%# ctype(CType(Container.Parent.Parent.Parent,RadGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>' />
                            <asp:Label runat="Server" Id="lblid" Visible ="False" Text ='<%#Container.DataItem.Id%>'/>
                        </ItemTemplate>
                    </telerik:GridTemplateColumn>                                
                        
                    <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" HeaderText="Id" ReadOnly="True"
                        SortExpression="Id" UniqueName="Id"  Visible ="True" >
                    </telerik:GridBoundColumn>
					            
                    <telerik:GridBoundColumn DataField="Declarante" HeaderText="TD"
                        SortExpression="Declarante" UniqueName="Declarante" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

                    <telerik:GridBoundColumn DataField="Personas_Declarante.NombreCompleto" HeaderText="Nombre Declarante"
                        SortExpression="Personas_Declarante.NombreCompleto" UniqueName="Personas_Declarante.NombreCompleto" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

                    <telerik:GridBoundColumn DataField="Personas_Declarante.Identificacion" HeaderText="Identificación"
                        SortExpression="Personas_Declarante.Identificacion" UniqueName="Personas_Declarante.Identificacion" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 					            
					            
                    <telerik:GridBoundColumn DataField="Personas_Declarante.Direccion.Descripcion" HeaderText="Dirección"
                        SortExpression="Personas_Declarante.Direccion.Descripcion" UniqueName="Personas_Declarante.Direccion.Descripcion" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 					            

                    <telerik:GridBoundColumn DataField="Personas_Declarante.Barrio.Descripcion" HeaderText="Barrio"
                        SortExpression="Personas_Declarante.Barrio.Descripcion" UniqueName="Personas_Declarante.Barrio.Descripcion" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 
                            
                    <telerik:GridBoundColumn DataField="Personas_Declarante.Telefono.Descripcion" HeaderText="Teléfono"
                        SortExpression="Personas_Declarante.Telefono.Descripcion" UniqueName="Personas_Declarante.Telefono.Descripcion" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 					            
                            
                    <telerik:GridBoundColumn DataField="Personas_Declarante.Celular.Descripcion" HeaderText="Celular"
                        SortExpression="Personas_Declarante.Celular.Descripcion" UniqueName="Personas_Declarante.Celular.Descripcion" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 					            
                            
                    <telerik:GridBoundColumn DataField="NombreRegional" HeaderText="Regional" SortExpression="NombreRegional" UniqueName="NombreRegional" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

                    <telerik:GridBoundColumn DataField="NombreLugarFuente" HeaderText="Lugar Entrega" SortExpression="NombreLugarFuente" UniqueName="NombreLugarFuente" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 					            

                    <telerik:GridBoundColumn DataField="TipoFamiliaxaEmpacar" HeaderText="TFE" SortExpression="TipoFamiliaxaEmpacar" UniqueName="TipoFamiliaxaEmpacar" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Fecha_Radicacion" DataType="System.DateTime" HeaderText="Radicación"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_Radicacion" UniqueName="Fecha_Radicacion">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Fecha_Declaracion" DataType="System.DateTime" HeaderText="Declaración"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_Declaracion" UniqueName="Fecha_Declaracion">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
					            
                    <telerik:GridBoundColumn DataField="Elegible" HeaderText="ELE" SortExpression="Elegible" UniqueName="Elegible" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

                    <telerik:GridBoundColumn DataField="Fecha_Elegible" DataType="System.String" HeaderText="Fecha Elegible"
                         SortExpression="Fecha_Elegible" UniqueName="Fecha_Elegible">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>						            

                    <telerik:GridBoundColumn DataField="Contactado" HeaderText="CON" SortExpression="Contactado" UniqueName="Contactado" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

                    <telerik:GridBoundColumn DataField="Fecha_Contactado" DataType="System.String" HeaderText="Fecha Contactado"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_Contactado" UniqueName="Fecha_Contactado">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>	
					            
                    <telerik:GridBoundColumn DataField="Programado" HeaderText="PRG" SortExpression="Programado" UniqueName="Programado" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

                    <telerik:GridBoundColumn DataField="Fecha_Programado" DataType="System.String" HeaderText="Fecha Programado"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_Programado" UniqueName="Fecha_Programado">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>				            

                    <telerik:GridBoundColumn DataField="ReProgramado" HeaderText="RPRG" SortExpression="ReProgramado" UniqueName="ReProgramado" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

                    <telerik:GridBoundColumn DataField="Fecha_ReProgramado" DataType="System.String" HeaderText="Fecha ReProgramado"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_ReProgramado" UniqueName="Fecha_ReProgramado">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>	

                    <telerik:GridBoundColumn DataField="Atendido" HeaderText="ATE" SortExpression="Atendido" UniqueName="Atendido" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

                    <telerik:GridBoundColumn DataField="VFechaAtencion" DataType="System.String" HeaderText="Fecha Atención"
                         SortExpression="VFechaAtencion" UniqueName="VFechaAtencion">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>	

                    <telerik:GridBoundColumn DataField="MotivoNoAtencion" HeaderText="Motivo No Atención" SortExpression="MotivoNoAtencion" UniqueName="MotivoNoAtencion" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

                    <telerik:GridBoundColumn DataField="TipoEntregaReprogramacion" DataType="System.String" HeaderText="Tipo Reprogramación"
                            SortExpression="TipoEntregaReprogramacion" UniqueName="TipoEntregaReprogramacion">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
							
                </Columns>
            </MasterTableView>
        </telerik:RadGrid>
        <telerik:RadScriptManager ID="RadScriptManager1" Runat="server">
        </telerik:RadScriptManager>    
    </div>
    </form>
</body>
</html>
