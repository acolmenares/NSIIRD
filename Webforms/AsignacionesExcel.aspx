<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AsignacionesExcel.aspx.vb" Inherits="WebForms_AsignacionesExcel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
 		<telerik:RadGrid ID="Rg_Listado" runat="server" GridLines="None" Skin="WebBlue" Width="100%"  AutoGenerateColumns="False" ShowStatusBar="True" TabIndex="6" 
            PageSize="20" CellSpacing="0">
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
                        
                    <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" HeaderText="Id" 
                        SortExpression="Id" UniqueName="Id"  Visible ="False" >
                    </telerik:GridBoundColumn>
						
					<telerik:GridBoundColumn DataField="Grupo.Descripcion" HeaderText="Grupo"
                        SortExpression="Grupo.Descripcion" UniqueName="Grupo.Descripcion" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

                    <telerik:GridBoundColumn DataField="NombreLugarFuente" HeaderText="Fuente"
                        SortExpression="NombreLugarFuente" UniqueName="NombreLugarFuente" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="NombreRegional" HeaderText="Regional"
                        SortExpression="NombreRegional" UniqueName="NombreRegional" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Fecha_Declaracion" DataType="System.DateTime" HeaderText="Fecha Declaración"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_Declaracion" UniqueName="Fecha_Declaracion">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

					<telerik:GridBoundColumn DataField="NombreFuente" HeaderText="Fuente"
                        SortExpression="NombreFuente" UniqueName="NombreFuente" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

                    <telerik:GridBoundColumn DataField="Fecha_Radicacion" DataType="System.DateTime" HeaderText="Fecha Radicación"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_Radicacion" UniqueName="Fecha_Radicacion">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Fecha_Desplazamiento" DataType="System.DateTime" HeaderText="Fecha Desplazamiento"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_Desplazamiento" UniqueName="Fecha_Desplazamiento">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Fecha_Programado" DataType="System.DateTime" HeaderText="Fecha Programado"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_Programado" UniqueName="Fecha_Programado">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Fecha_Valoracion" DataType="System.DateTime" HeaderText="Fecha Atención"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_Valoracion" UniqueName="Fecha_Valoracion">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
					       
					<telerik:GridBoundColumn DataField="Horario" HeaderText="H"  HeaderTooltip ="Horario"
                        SortExpression="Horario" UniqueName="Horario" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>                                 

					<telerik:GridBoundColumn DataField="Declarante" HeaderText="TD"  HeaderTooltip ="Declarante"
                        SortExpression="Declarante" UniqueName="Declarante" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 					            

					<telerik:GridBoundColumn DataField="Personas_Declarante.Primer_Apellido" HeaderText="Primer Apellido"  
                        SortExpression="Personas_Declarante.Primer_Apellido" UniqueName="Personas_Declarante.Primer_Apellido" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 	

					<telerik:GridBoundColumn DataField="Personas_Declarante.Segundo_Apellido" HeaderText="Segundo Apellido"  
                        SortExpression="Personas_Declarante.Segundo_Apellido" UniqueName="Personas_Declarante.Segundo_Apellido" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

					<telerik:GridBoundColumn DataField="Personas_Declarante.Primer_Nombre" HeaderText="Primer Nombre"  
                        SortExpression="Personas_Declarante.Primer_Nombre" UniqueName="Personas_Declarante.Primer_Nombre" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 	

					<telerik:GridBoundColumn DataField="Personas_Declarante.Segundo_Nombre" HeaderText="Segundo Nombre"  
                        SortExpression="Personas_Declarante.Segundo_Nombre" UniqueName="Personas_Declarante.Segundo_Nombre" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

					<telerik:GridBoundColumn DataField="Personas_Declarante.Tipo_Identificacion.Descripcion" HeaderText="TI"  
                        SortExpression="Personas_Declarante.Tipo_Identificacion.Descripcion" UniqueName="Personas_Declarante.Tipo_Identificacion.Descripcion" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

					<telerik:GridBoundColumn DataField="Personas_Declarante.Identificacion" HeaderText="Identificación"  
                        SortExpression="Personas_Declarante.Identificacion" UniqueName="Personas_Declarante.Identificacion" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 
						
					<telerik:GridBoundColumn DataField="Personas_Declarante.Celular.Descripcion" HeaderText="Celular"  
                        SortExpression="Personas_Declarante.Celular.Descripcion" UniqueName="Personas_Declarante.Celular.Descripcion" >
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

					<telerik:GridBoundColumn DataField="Personas_Declarante.Direccion.Descripcion" HeaderText="Dirección"  
                        SortExpression="Personas_Declarante.Direccion.Descripcion" UniqueName="Personas_Declarante.Direccion.Descripcion" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

					<telerik:GridBoundColumn DataField="Personas_Declarante.Edad" HeaderText="Edad"  
                        SortExpression="Personas_Declarante.Edad" UniqueName="Personas_Declarante.Edad" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>  

                    <telerik:GridBoundColumn DataField="Personas_Declarante.Fecha_Nacimiento" DataType="System.DateTime" HeaderText="Fecha Nacimiento"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Personas_Declarante.Fecha_Nacimiento" UniqueName="Personas_Declarante.Fecha_Nacimiento">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

					<telerik:GridBoundColumn DataField="Personas_Declarante.GeneroPersona" HeaderText="Genero"  
                        SortExpression="Personas_Declarante.GeneroPersona" UniqueName="Personas_Declarante.GeneroPersona" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>  

					<telerik:GridBoundColumn DataField="Gestantes" HeaderText="Gestantes" SortExpression="Gestantes" UniqueName="Gestantes" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

					<telerik:GridBoundColumn DataField="Menores_Ninos" HeaderText="Niños Menores" SortExpression="Menores_Ninos" UniqueName="Menores_Ninos" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

					<telerik:GridBoundColumn DataField="Resto_Nucleo" HeaderText="Resto Nucleo" SortExpression="Resto_Nucleo" UniqueName="Resto_Nucleo" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

					<telerik:GridBoundColumn DataField="TipoFamiliaxaEmpacar" HeaderText="TF Empaque"   
                        SortExpression="TipoFamiliaxaEmpacar" UniqueName="TipoFamiliaxaEmpacar" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 					            

                    <telerik:GridBoundColumn DataField="Atendido" HeaderText="ATE" SortExpression="Atendido" UniqueName="Atendido" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

                    <telerik:GridBoundColumn DataField="MotivoNoAtencion" HeaderText="Motivo No Atención" SortExpression="MotivoNoAtencion" UniqueName="MotivoNoAtencion" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

                    <telerik:GridBoundColumn DataField="EstadoAccionSocial" HeaderText="Estado ante UV" SortExpression="EstadoAccionSocial" UniqueName="EstadoAccionSocial" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

                    <telerik:GridBoundColumn DataField="Fecha_Inclusion" DataType="System.DateTime" HeaderText="Fecha Inclusión UV"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_Inclusion" UniqueName="Fecha_Inclusion">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Fecha_Investigacion" DataType="System.DateTime" HeaderText="Fecha Invest UV"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_Investigacion" UniqueName="Fecha_Investigacion">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="EstadoUnidos" HeaderText="Estado Unidos" SortExpression="EstadoUnidos" UniqueName="EstadoUnidos" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

                    <telerik:GridBoundColumn DataField="Fecha_InclusionUnidos" DataType="System.DateTime" HeaderText="Fecha Inclusión Unidos"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_InclusionUnidos" UniqueName="Fecha_InclusionUnidos">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Fecha_InvestigacionUnidos" DataType="System.DateTime" HeaderText="Fecha Invest Unidos"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_InvestigacionUnidos" UniqueName="Fecha_InvestigacionUnidos">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="EstadoFaccion" HeaderText="Estado F Accion" SortExpression="EstadoFaccion" UniqueName="EstadoFaccion" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

                    <telerik:GridBoundColumn DataField="Fecha_InclusionFaccion" DataType="System.DateTime" HeaderText="Fecha Inclusión F Accion"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_InclusionFaccion" UniqueName="Fecha_InclusionFaccion">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Fecha_InvestigacionFaccion" DataType="System.DateTime" HeaderText="Fecha Invest F Accion"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_InvestigacionFaccion" UniqueName="Fecha_InvestigacionFaccion">
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
