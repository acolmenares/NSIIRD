<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Personas_Regimen_SaludExcel.aspx.vb" Inherits="WebForms_Personas_Regimen_SaludExcel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sistema de Exportar Regimen de Salud  </title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
           <telerik:RadScriptManager ID="RadScriptManager1" Runat="server"/>
            
			<telerik:RadGrid ID="Rg_Listado" runat="server" GridLines="None" Skin="WebBlue" Width="100%" 
                AutoGenerateColumns="False" ShowStatusBar="True" TabIndex="6" PageSize="20" CellSpacing="0">
                <AlternatingItemStyle BackColor="White" Cssclass="DataGridAlternatingItemStyle" />
                <ItemStyle BackColor="#E3EAEB" Cssclass="DataGridItemStyle" />
                <MasterTableView  NoDetailRecordsText="No hay informaci&#243;n." NoMasterRecordsText="No hay informaci&#243;n." DataKeyNames="Id" >
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

                        <telerik:GridBoundColumn DataField="Declaracion.Grupo.Descripcion" HeaderText="Grupo"
                            SortExpression="Declaracion.Grupo.Descripcion" UniqueName="Declaracion.Grupo.Descripcion" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Declaracion.NombreRegional" HeaderText="Regional"
                            SortExpression="Declaracion.NombreRegional" UniqueName="Declaracion.NombreRegional" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Declaracion.NombreLugarFuente" HeaderText="Lugar Entrega"
                            SortExpression="Declaracion.NombreLugarFuente" UniqueName="Declaracion.NombreLugarFuente" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>
                        
                        <telerik:GridBoundColumn DataField="Tipo" HeaderText="Tipo" SortExpression="Tipo" UniqueName="Tipo" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Declaracion.Fecha_Valoracion" DataType="System.DateTime" HeaderText="Fecha Atención"
                            DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Declaracion.Fecha_Valoracion" UniqueName="Declaracion.Fecha_Valoracion">
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>	

                        <telerik:GridBoundColumn DataField="Identificacion" HeaderText="Identificación"
                            SortExpression="Identificacion" UniqueName="Identificacion" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="NombreCompleto" HeaderText="Nombre Completo"
                            SortExpression="NombreCompleto" UniqueName="NombreCompleto" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Edad" HeaderText="Edad"
                            SortExpression="Edad" UniqueName="Edad" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Fecha_Nacimiento" DataType="System.DateTime" HeaderText="Fecha Nacimiento"
                            DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_Nacimiento" UniqueName="Fecha_Nacimiento">
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>	

                        <telerik:GridBoundColumn DataField="Declaracion.Declarante" HeaderText="Tipo"
                            SortExpression="Declaracion.Declarante" UniqueName="Declaracion.Declarante" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Declaracion.Personas_Declarante.NombreCompleto" HeaderText="Nombre Declarante"
                            SortExpression="Declaracion.Personas_Declarante.NombreCompleto" UniqueName="Declaracion.Personas_Declarante.NombreCompleto" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Declaracion.Personas_Declarante.Identificacion" HeaderText="Identificación Declarante"
                            SortExpression="Declaracion.Personas_Declarante.Identificacion" UniqueName="Declaracion.Personas_Declarante.Identificacion" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Declaracion.Personas_Declarante.Celular.Descripcion" HeaderText="Celular Declarante"
                            SortExpression="Declaracion.Personas_Declarante.Celular.Descripcion" UniqueName="Declaracion.Personas_Declarante.Celular.Descripcion" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Declaracion.Personas_Declarante.Direccion.Descripcion" HeaderText="Dirección Declarante"
                            SortExpression="Declaracion.Personas_Declarante.Direccion.Descripcion" UniqueName="Declaracion.Personas_Declarante.Direccion.Descripcion" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Declaracion.Personas_Declarante.Telefono.Descripcion" HeaderText="Teléfono Declarante"
                            SortExpression="Declaracion.Personas_Declarante.Telefono.Descripcion" UniqueName="Declaracion.Personas_Declarante.Telefono.Descripcion" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Declaracion.Personas_Declarante.Barrio.Descripcion" HeaderText="Barrio Declarante"
                            SortExpression="Declaracion.Personas_Declarante.Barrrio.Descripcion" UniqueName="Declaracion.Personas_Declarante.Barrio.Descripcion" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>
                                                    
                        <telerik:GridBoundColumn DataField="Declaracion.EstadoRUV" HeaderText="Estado RUV"
                            SortExpression="Declaracion.EstadoRUV" UniqueName="Declaracion.EstadoRUV" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Declaracion.WFecha_Valoracion_RUV" DataType="System.DateTime" HeaderText="Fecha Inclusión"
                            DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Declaracion.WFecha_Valoracion_RUV" UniqueName="Declaracion.WFecha_Valoracion_RUV">
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>	

                        <telerik:GridBoundColumn DataField="Persona_Regimen_Salud_Antes" HeaderText="R.S. Antes"
                            SortExpression="Persona_Regimen_Salud_Antes" UniqueName="Persona_Regimen_Salud_Antes" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="EPS_Antes_Persona" HeaderText="EPS Antes"
                            SortExpression="EPS_Antes_Persona" UniqueName="EPS_Antes_Persona" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Municipio_Antes_Persona" HeaderText="Municipio Antes"
                            SortExpression="Municipio_Antes_Persona" UniqueName="Municipio_Antes_Persona" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Persona_Regimen_Salud_Despues" HeaderText="R.S. 1a Entrega"
                            SortExpression="Persona_Regimen_Salud_Despues" UniqueName="Persona_Regimen_Salud_Despues" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="EPS_Despues_Persona" HeaderText="EPS 1a Entrega"
                            SortExpression="EPS_Despues_Persona" UniqueName="EPS_Despues_Persona" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Municipio_Despues_Persona" HeaderText="Municipio 1a Entrega"
                            SortExpression="Municipio_Despues_Persona" UniqueName="Municipio_Despues_Persona" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Fecha_SE_Persona" DataType="System.DateTime" HeaderText="Fecha 2a Entrega"
                            DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_SE_Persona" UniqueName="Fecha_SE_Persona">
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>	
				          		
                        <telerik:GridBoundColumn DataField="Persona_Regimen_Salud_SE" HeaderText="R.S. 2a Entrega"
                            SortExpression="Persona_Regimen_Salud_SE" UniqueName="Persona_Regimen_Salud_SE" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="EPS_SE_Persona" HeaderText="EPS 2a Entrega"
                            SortExpression="EPS_SE_Persona" UniqueName="EPS_SE_Persona" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Municipio_SE_Persona" HeaderText="Municipio 2a Entrega"
                            SortExpression="Municipio_SE_Persona" UniqueName="Municipio_SE_Persona" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Persona_Fecha_Final" DataType="System.DateTime" HeaderText="Fecha Seguimiento"
                            DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Persona_Fecha_Final" UniqueName="Persona_Fecha_Final">
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>	
				          		
                        <telerik:GridBoundColumn DataField="Persona_Regimen_Salud_Final" HeaderText="R.S. Seguimiento"
                            SortExpression="Persona_Regimen_Salud_Final" UniqueName="Persona_Regimen_Salud_Final" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Persona_EPS_Final" HeaderText="EPS Seguimiento"
                            SortExpression="Persona_EPS_Final" UniqueName="Persona_EPS_Final" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Persona_Municipio_Final" HeaderText="Municipio Seguimiento"
                            SortExpression="Persona_Municipio_Final" UniqueName="Persona_Municipio_Final" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                                				            
				    </Columns>
                 </MasterTableView>
            </telerik:RadGrid>    
    </div>
    </form>
</body>
</html>
