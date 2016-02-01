<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Declaracion_IngresoExcel.aspx.vb" Inherits="WebForms_Declaracion_IngresoExcel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
		<telerik:RadGrid ID="Rg_Listado" runat="server" Skin="WebBlue" Width="100%"  
            AutoGenerateColumns="False" ShowStatusBar="True" TabIndex="6" 
            PageSize="20" ResolvedRenderMode="Classic">
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

                    <telerik:GridBoundColumn DataField="Fecha_Declaracion" DataType="System.DateTime" HeaderText="Fecha Declaración"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_Declaracion" UniqueName="Fecha_Declaracion">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
                    
                    <telerik:GridBoundColumn DataField="Fecha_Desplazamiento" DataType="System.DateTime" HeaderText="Fecha Desplazamiento"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_Desplazamiento" UniqueName="Fecha_Desplazamiento">
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

					<telerik:GridBoundColumn DataField="Numero_Declaracion" HeaderText="Número Declaración"  HeaderTooltip ="Número de Declaración"
                        SortExpression="Numero_Declaracion" UniqueName="Numero_Declaracion" >
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

					<telerik:GridBoundColumn DataField="TipoFamiliaxaEmpacar" HeaderText="TF Empacar"   
                        SortExpression="TipoFamiliaxaEmpacar" UniqueName="TipoFamiliaxaEmpacar" >
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

                    <telerik:GridBoundColumn DataField="TipoFamiliaxaEmpacar" HeaderText="TF Empacar"   
                        SortExpression="TipoFamiliaxaEmpacar" UniqueName="TipoFamiliaxaEmpacar" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 	

                    <telerik:GridBoundColumn DataField="EstadoRUV" HeaderText="Estado RUV" SortExpression="EstadoRUV" UniqueName="EstadoRUV" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

                    <telerik:GridBoundColumn DataField="WFecha_Valoracion_RUV" DataType="System.String" HeaderText="Fecha Valoración RUV"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="WFecha_Valoracion_RUV" UniqueName="WFecha_Valoracion_RUV">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="WFecha_Investigacion_RUV" DataType="System.DateTime" HeaderText="Fecha Invest RUV"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="WFecha_Investigacion_RUV" UniqueName="WFecha_Investigacion_RUV">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>



                    <telerik:GridBoundColumn DataField="EstadoPAARI" HeaderText="Estado PAARI" SortExpression="EstadoPAARI" UniqueName="EstadoPAARI" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

                    <telerik:GridBoundColumn DataField="WFecha_InclusionPAARI" DataType="System.DateTime" HeaderText="Fecha Inclusión PAARI"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="WFecha_InclusionPAARI" UniqueName="WFecha_InclusionPAARI">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="WFecha_InvestigacionPAARI" DataType="System.DateTime" HeaderText="Fecha Invest PAARI"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="WFecha_InvestigacionPAARI" UniqueName="WFecha_InvestigacionPAARI">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>



                    <telerik:GridBoundColumn DataField="EstadoFaccion" HeaderText="Estado F Accion" SortExpression="EstadoFaccion" UniqueName="EstadoFaccion" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

                    <telerik:GridBoundColumn DataField="WFecha_InclusionFaccion" DataType="System.DateTime" HeaderText="Fecha Inclusión F Accion"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="WFecha_InclusionFaccion" UniqueName="WFecha_InclusionFaccion">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="WFecha_InvestigacionFaccion" DataType="System.DateTime" HeaderText="Fecha Invest F Accion"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="WFecha_InvestigacionFaccion" UniqueName="WFecha_InvestigacionFaccion">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
			


                     <telerik:GridBoundColumn DataField="EstadoActoAdministrativo" HeaderText="Estado AA" SortExpression="EstadoActoAdministrativo" UniqueName="EstadoActoAdministrativo" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

                    <telerik:GridBoundColumn DataField="WFecha_InclusionEstadoActoAdministrativo" DataType="System.DateTime" HeaderText="Fecha AA"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="WFecha_InclusionEstadoActoAdministrativo" UniqueName="WFecha_InclusionEstadoActoAdministrativo">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="WFecha_InvestigacionEstadoActoAdministrativo" DataType="System.DateTime" HeaderText="Fecha Invest AA"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="WFecha_InvestigacionEstadoActoAdministrativo" UniqueName="WFecha_InvestigacionEstadoActoAdministrativo">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>



                     <telerik:GridBoundColumn DataField="EstadoNotificacion" HeaderText="Estado Notificación" SortExpression="EstadoNotificacion" UniqueName="EstadoNotificacion" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

                    <telerik:GridBoundColumn DataField="WFecha_InclusionNotificacion" DataType="System.DateTime" HeaderText="Fecha Notificación"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="WFecha_InclusionNotificacion" UniqueName="WFecha_InclusionNotificacion">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="WFecha_InvestigacionNotificacion" DataType="System.DateTime" HeaderText="Fecha Invest Notificación"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="WFecha_InvestigacionNotificacion" UniqueName="WFecha_InvestigacionNotificacion">
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
