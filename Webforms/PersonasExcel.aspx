<%@ Page Language="VB" AutoEventWireup="false" CodeFile="PersonasExcel.aspx.vb" Inherits="WebForms_PersonasExcel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sistema de Exportar Personas</title>
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

                    <telerik:GridBoundColumn DataField="Id_Declaracion" DataType="System.Int32" HeaderText="Declaracion" ReadOnly="True"
                        SortExpression="Id_Declaracion" UniqueName="Id_Declaracion"  Visible ="True" >
                    </telerik:GridBoundColumn>
					            
                    <telerik:GridBoundColumn DataField="Declaracion.NombreRegional" HeaderText="Regional"
                        SortExpression="Declaracion.NombreRegional" UniqueName="Declaracion.NombreRegional" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Declaracion.NombreLugarFuente" HeaderText="Lugar Fuente"
                        SortExpression="Declaracion.NombreLugarFuente" UniqueName="Declaracion.NombreLugarFuente" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Declaracion.Grupo.Descripcion" HeaderText="Grupo"
                        SortExpression="Declaracion.Grupo.Descripcion" UniqueName="Declaracion.Grupo.Descripcion" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Declaracion.NombreFuente" HeaderText="Fuente"
                        SortExpression="Declaracion.NombreFuente" UniqueName="Declaracion.NombreFuente" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Declaracion.Fecha_Valoracion" DataType="System.DateTime" HeaderText="Fecha Atención"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Declaracion.Fecha_Valoracion" UniqueName="Declaracion.Fecha_Valoracion">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>	

                    <telerik:GridBoundColumn DataField="Declaracion.Fecha_Declaracion" DataType="System.DateTime" HeaderText="Fecha Declaración"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Declaracion.Fecha_Declaracion" UniqueName="Declaracion.Fecha_Declaracion">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>					    
                        
                    <telerik:GridBoundColumn DataField="Declaracion.Fecha_Desplazamiento" DataType="System.DateTime" HeaderText="Fecha Desplazamiento"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Declaracion.Fecha_Desplazamiento" UniqueName="Declaracion.Fecha_Desplazamiento">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
                                
                    <telerik:GridBoundColumn DataField="Tipo" HeaderText="Tipo"
                        SortExpression="Tipo" UniqueName="Tipo" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Tipo_Identificacion.descripcion" HeaderText="T.I."
                        SortExpression="Tipo_Identificacion.descripcion" UniqueName="Tipo_Identificacion.descripcion" >
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

                    <telerik:GridBoundColumn DataField="Primer_Apellido" HeaderText="Primer Apellido"
                        SortExpression="Primer_Apellido" UniqueName="Primer_Apellido" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Segundo_Apellido" HeaderText="Segundo Apellido"
                        SortExpression="Segundo_Apellido" UniqueName="Segundo_Apellido" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Primer_Nombre" HeaderText="Primer Nombre"
                        SortExpression="Primer_Nombre" UniqueName="Primer_Nombre" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Segundo_Nombre" HeaderText="Segundo Nombre"
                        SortExpression="Segundo_Nombre" UniqueName="Segundo_Nombre" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="GeneroPersona" HeaderText="Genero"
                        SortExpression="GeneroPersona" UniqueName="GeneroPersona" >
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

                    <telerik:GridBoundColumn DataField="ParentescoPersona" HeaderText="Parentesco"
                        SortExpression="ParentescoPersona" UniqueName="ParentescoPersona" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
					        
                    <telerik:GridBoundColumn DataField="EstadoEmbarazada" HeaderText="Embarazada"
                        SortExpression="EstadoEmbarazada" UniqueName="EstadoEmbarazada" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>                            

                    <telerik:GridBoundColumn DataField="EstadoLactando" HeaderText="Lactando"
                        SortExpression="EstadoLactando" UniqueName="EstadoLactando" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 
                                
                    <telerik:GridBoundColumn DataField="TipoMiembro" HeaderText="Miembro"
                        SortExpression="TipoMiembro" UniqueName="TipoMiembro" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Persona_Discapacitado" HeaderText="Discapacitado"
                        SortExpression="Persona_Discapacitado" UniqueName="Persona_Discapacitado" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Persona_TipoDiscapacidad" HeaderText="Tipo Discapacidad"
                        SortExpression="Persona_TipoDiscapacidad" UniqueName="Persona_TipoDiscapacidad" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Estudiaba_Actualmente" HeaderText="Est. Actual"
                        SortExpression="Estudiaba_Actualmente" UniqueName="Estudiaba_Actualmente" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Institucion_Estudia" HeaderText="Institución"
                        SortExpression="Institucion_Estudia" UniqueName="Institucion_Estudia" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Persona_UltimoGrado" HeaderText="Ult. Grado"
                        SortExpression="Persona_UltimoGrado" UniqueName="Persona_UltimoGrado" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>                            

                    <telerik:GridBoundColumn DataField="Sabe_LeerEscribir" HeaderText="Sabe L/E"
                        SortExpression="Sabe_LeerEscribir" UniqueName="Sabe_LeerEscribir" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 
						
	                <telerik:GridBoundColumn DataField="MotivoNoestudiaPrimeraEntrega" HeaderText="Motivo No Estudia PE"
                        SortExpression="MotivoNoestudiaPrimeraEntrega" UniqueName="MotivoNoestudiaPrimeraEntrega" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

	                <telerik:GridBoundColumn DataField="TipoApoyoEducativo" HeaderText="Apoyo Educativo"
                        SortExpression="TipoApoyoEducativo" UniqueName="TipoApoyoEducativo" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Persona_Grupo_Etnico" HeaderText="Etnia"
                        SortExpression="Persona_Grupo_Etnico" UniqueName="Persona_Grupo_Etnico" >
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

                    <telerik:GridBoundColumn DataField="Declaracion.Personas_Declarante.Direccion.Descripcion" HeaderText="Direccion Declarante"
                        SortExpression="Declaracion.Personas_Declarante.Direccion.Descripcion" UniqueName="Declaracion.Personas_Declarante.Direccion.Descripcion" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Declaracion.Personas_Declarante.Telefono.Descripcion" HeaderText="Telefono Declarante"
                        SortExpression="Declaracion.Personas_Declarante.Telefono.Descripcion" UniqueName="Declaracion.Personas_Declarante.Telefono.Descripcion" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Declaracion.Personas_Declarante.Barrio.Descripcion" HeaderText="Barrio Declarante"
                        SortExpression="Declaracion.Personas_Declarante.Barrrio.Descripcion" UniqueName="Declaracion.Personas_Declarante.Barrio.Descripcion" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Declaracion.EstadoRUV" HeaderText="Estado RUV" SortExpression="Declaracion.EstadoRUV" UniqueName="Declaracion.EstadoRUV" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

                    <telerik:GridBoundColumn DataField="Declaracion.WFecha_Valoracion_RUV" DataType="System.String" HeaderText="Fecha Valoración RUV"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Declaracion.WFecha_Valoracion_RUV" UniqueName="Declaracion.WFecha_Valoracion_RUV">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Declaracion.WFecha_Investigacion_RUV" DataType="System.DateTime" HeaderText="Fecha Invest RUV"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Declaracion.WFecha_Investigacion_RUV" UniqueName="Declaracion.WFecha_Investigacion_RUV">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>



                    <telerik:GridBoundColumn DataField="Declaracion.EstadoPAARI" HeaderText="Estado PAARI" SortExpression="Declaracion.EstadoPAARI" UniqueName="Declaracion.EstadoPAARI" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

                    <telerik:GridBoundColumn DataField="Declaracion.WFecha_InclusionPAARI" DataType="System.DateTime" HeaderText="Fecha Inclusión PAARI"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Declaracion.WFecha_InclusionPAARI" UniqueName="Declaracion.WFecha_InclusionPAARI">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Declaracion.WFecha_InvestigacionPAARI" DataType="System.DateTime" HeaderText="Fecha Invest PAARI"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Declaracion.WFecha_InvestigacionPAARI" UniqueName="Declaracion.WFecha_InvestigacionPAARI">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>



                    <telerik:GridBoundColumn DataField="Declaracion.EstadoFaccion" HeaderText="Estado F Accion" SortExpression="Declaracion.EstadoFaccion" UniqueName="Declaracion.EstadoFaccion" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

                    <telerik:GridBoundColumn DataField="Declaracion.WFecha_InclusionFaccion" DataType="System.DateTime" HeaderText="Fecha Inclusión F Accion"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Declaracion.WFecha_InclusionFaccion" UniqueName="Declaracion.WFecha_InclusionFaccion">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Declaracion.WFecha_InvestigacionFaccion" DataType="System.DateTime" HeaderText="Fecha Invest F Accion"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Declaracion.WFecha_InvestigacionFaccion" UniqueName="Declaracion.WFecha_InvestigacionFaccion">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
			

                     <telerik:GridBoundColumn DataField="Declaracion.EstadoNotificacion" HeaderText="Estado Notificación" SortExpression="Declaracion.EstadoNotificacion" UniqueName="Declaracion.EstadoNotificacion" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

                    <telerik:GridBoundColumn DataField="Declaracion.WFecha_InclusionNotificacion" DataType="System.DateTime" HeaderText="Fecha Notificación"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Declaracion.WFecha_InclusionNotificacion" UniqueName="Declaracion.WFecha_InclusionNotificacion">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Declaracion.WFecha_InvestigacionNotificacion" DataType="System.DateTime" HeaderText="Fecha Invest Notificación"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Declaracion.WFecha_InvestigacionNotificacion" UniqueName="Declaracion.WFecha_InvestigacionNotificacion">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>	
                    
                    <telerik:GridBoundColumn DataField="Declaracion.TipoFamilia" HeaderText="Tipo Familia Real"
                        SortExpression="Declaracion.TipoFamilia" UniqueName="Declaracion.TipoFamilia" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 
                    
                    <telerik:GridBoundColumn DataField="Declaracion.Ninos05" HeaderText="NIños 0-5"
                        SortExpression="Declaracion.Ninos05" UniqueName="Declaracion.Ninos05" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 
                           
                    <telerik:GridBoundColumn DataField="Declaracion.Ninos0617" HeaderText="NIños 6-17"
                        SortExpression="Declaracion.Ninos0617" UniqueName="Declaracion.Ninos0617" >
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
