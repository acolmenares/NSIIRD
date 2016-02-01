<%@ Page Language="VB" AutoEventWireup="false" CodeFile="DeclaracionExcel.aspx.vb" Inherits="WebForms_DeclaracionExcel" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
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

                        <telerik:GridBoundColumn DataField="Fecha_Declaracion" DataType="System.DateTime" HeaderText="Fecha Declaración"
                            DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_Declaracion" UniqueName="Fecha_Declaracion">
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>						            
					            
                        <telerik:GridBoundColumn DataField="VFechaAtencion" DataType="System.DateTime" HeaderText="Fecha Atención"
                            DataFormatString="{0:dd/MMM/yyyy}" SortExpression="VFechaAtencion" UniqueName="VFechaAtencion">
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>
					            
					    <telerik:GridBoundColumn DataField="Horario" HeaderText="H"  HeaderTooltip ="Horario"
                            SortExpression="Horario" UniqueName="Horario" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn> 
					            					            
					    <telerik:GridBoundColumn DataField="DescripcionGrupo" HeaderText="Grupo"
                            SortExpression="DescripcionGrupo" UniqueName="DescripcionGrupo" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn> 

					    <telerik:GridBoundColumn DataField="NombreFuente" HeaderText="Fuente"
                            SortExpression="NombreFuente" UniqueName="NombreFuente" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn> 

					    <telerik:GridBoundColumn DataField="NombreRegional" HeaderText="Regional"
                            SortExpression="NombreRegional" UniqueName="NombreRegional" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn> 

					    <telerik:GridBoundColumn DataField="NombreLugarFuente" HeaderText="Lugar de Entrega"
                            SortExpression="NombreLugarFuente" UniqueName="NombreLugarFuente" >
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
					            
					    <telerik:GridBoundColumn DataField="DeclaracionEnLinea" HeaderText="Línea"  
                            SortExpression="DeclaracionEnLinea" UniqueName="DeclaracionEnLinea" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>  

					    <telerik:GridBoundColumn DataField="Atendido" HeaderText="Atendido"  SortExpression="Atendido" UniqueName="Atendido" >
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

					    <telerik:GridBoundColumn DataField="Personas_Declarante.Persona_Grupo_Etnico" HeaderText="Etnia"  
                            SortExpression="Personas_Declarante.Persona_Grupo_Etnico" UniqueName="Personas_Declarante.Persona_Grupo_Etnico" >
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

                        <telerik:GridBoundColumn DataField="TipoFamilia" HeaderText="TFR" HeaderTooltip ="Tipo de Familia Real"  
                            SortExpression="TipoFamilia" UniqueName="TipoFamilia" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="MotivoNoAtencion" HeaderText="Motivo de No Atención"  
                            SortExpression="MotivoNoAtencion" UniqueName="MotivoNoAtencion" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>                            

                        <telerik:GridBoundColumn DataField="TipoTenencia" HeaderText="Tipo de Tenencia"  
                            SortExpression="TipoTenencia" UniqueName="TipoTenencia" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>  

                        <telerik:GridBoundColumn DataField="CuantasHabitaciones" HeaderText="No Habit"  
                            SortExpression="CuantasHabitaciones" UniqueName="CuantasHabitaciones" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>  

                        <telerik:GridBoundColumn DataField="PersonasVivienda" HeaderText="Personas Vivienda"  
                            SortExpression="PersonasVivienda" UniqueName="PersonasVivienda" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn> 

                        <telerik:GridBoundColumn DataField="PersonasHabitacion" HeaderText="Personas Habitación"  
                            SortExpression="PersonasHabitacion" UniqueName="PersonasHabitacion" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>                    

                        <telerik:GridBoundColumn DataField="MaterialesVivienda" HeaderText="Materiales Vivienda"
                            SortExpression="MaterialesVivienda" UniqueName="MaterialesVivienda" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn> 

                        <telerik:GridBoundColumn DataField="Agua_potable" HeaderText="Agua Potable"
                            SortExpression="Agua_potable" UniqueName="Agua_potable" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>    
                
                        <telerik:GridBoundColumn DataField="ObtencionAgua" HeaderText="Obtención Agua"
                            SortExpression="ObtencionAgua" UniqueName="ObtencionAgua" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn> 

                        <telerik:GridBoundColumn DataField="FormaDeclaracion" HeaderText="Tipo Desplazamiento"
                            SortExpression="FormaDeclaracion" UniqueName="FormaDeclaracion" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn> 

                        <telerik:GridBoundColumn DataField="DescripcionDepartamento" HeaderText="Departamento"
                            SortExpression="DescripcionDepartamento" UniqueName="DescripcionDepartamento" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn> 

                        <telerik:GridBoundColumn DataField="DescripcionMunicipio" HeaderText="Municipio"
                            SortExpression="DescripcionMunicipio" UniqueName="DescripcionMunicipio" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn> 
   
                        <telerik:GridBoundColumn DataField="DescripcionConcejo" HeaderText="Concejo/Resguardo"
                            SortExpression="DescripcionConcejo" UniqueName="DescripcionConcejo" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>                 

                        <telerik:GridBoundColumn DataField="Vereda_Desplazamiento" HeaderText="Vereda"
                            SortExpression="Vereda_Desplazamiento" UniqueName="Vereda_Desplazamiento" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>      

                        <telerik:GridBoundColumn DataField="CuantasVecesHaSidoDesplazado" HeaderText="Cuantos Desplaz"
                            SortExpression="CuantasVecesHaSidoDesplazado" UniqueName="CuantasVecesHaSidoDesplazado" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>
                  
                        <telerik:GridBoundColumn DataField="HaDeclaradoAntes" HeaderText="Ha Declarado Antes"
                            SortExpression="HaDeclaradoAntes" UniqueName="HaDeclaradoAntes" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>                                       
            
                        <telerik:GridBoundColumn DataField="Fecha_Desplazamiento_Anterior" DataType="System.DateTime" HeaderText="Fecha Desplazamiento Anterior"
                            DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_Desplazamiento_Anterior" UniqueName="Fecha_Desplazamiento_Anterior">
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>                

                        <telerik:GridBoundColumn DataField="Lugar_Desplazamiento" HeaderText="Lugar Desplazamiento Antes"
                            SortExpression="Lugar_Desplazamiento" UniqueName="Lugar_Desplazamiento" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>                   
                
                        <telerik:GridBoundColumn DataField="HaRegresado" HeaderText="Ha Regresado"
                            SortExpression="HaRegresado" UniqueName="HaRegresado" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>    
                            
                        <telerik:GridBoundColumn DataField="CausasDesplazamiento" HeaderText="Causas Desplazamiento"
                            SortExpression="CausasDesplazamiento" UniqueName="CausasDesplazamiento" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>   

                        <telerik:GridBoundColumn DataField="TiempoDeclarar" HeaderText="Tiempo en Declarar"
                            SortExpression="TiempoDeclarar" UniqueName="TiempoDeclarar" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn> 

                        <telerik:GridBoundColumn DataField="TardoTiempoDeclarar" HeaderText="Porque Tardo en Declarar"
                            SortExpression="TardoTiempoDeclarar" UniqueName="TardoTiempoDeclarar" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn> 
 
                            <telerik:GridBoundColumn DataField="EsDelMunicipio" HeaderText="Es del Municipio"
                            SortExpression="EsDelMunicipio" UniqueName="EsDelMunicipio" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn> 

                        <telerik:GridBoundColumn DataField="MotivoNoDecMunicipio" HeaderText="Porque No Dec. en Municipio"
                            SortExpression="MotivoNoDecMunicipio" UniqueName="MotivoNoDecMunicipio" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn> 

                        <telerik:GridBoundColumn DataField="ADD_Familias_Accion" HeaderText="ADD Familias Acccion"
                            SortExpression="ADD_Familias_Accion" UniqueName="ADD_Familias_Accion" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn> 

                        <telerik:GridBoundColumn DataField="MunicipioFaccion" HeaderText="Municipio F Accion"
                            SortExpression="MunicipioFaccion" UniqueName="MunicipioFaccion" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn> 
                
                        <telerik:GridBoundColumn DataField="ADD_Unidos" HeaderText="ADD Unidos"
                            SortExpression="ADD_Unidos" UniqueName="ADD_Unidos" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn> 
                
                        <telerik:GridBoundColumn DataField="Municipio_Unidos" HeaderText="Municipio Unidos"
                            SortExpression="Municipio_Unidos" UniqueName="Municipio_Unidos" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn> 

                        <telerik:GridBoundColumn DataField="Declarante_Solicito_Ayuda" HeaderText="Sol. Ayuda"
                            SortExpression="Declarante_Solicito_Ayuda" UniqueName="Declarante_Solicito_Ayuda" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn> 
              
                        <telerik:GridBoundColumn DataField="EntidadInicial" HeaderText="Entidad Inicial"
                            SortExpression="EntidadInicial" UniqueName="EntidadInicial" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn> 

                        <telerik:GridBoundColumn DataField="ComoFueAtencion" HeaderText="Como fue Atención"
                            SortExpression="ComoFueAtencion" UniqueName="ComoFueAtencion" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn> 

                        <telerik:GridBoundColumn DataField="FuenteIngresos" HeaderText="Fuente Ingresos"
                            SortExpression="FuenteIngresos" UniqueName="FuenteIngresos" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Promedio_Ingresos_Mensuales" HeaderText="Promedio Ingresos"
                            SortExpression="Promedio_Ingresos_Mensuales" UniqueName="Promedio_Ingresos_Mensuales" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="DanosFamilia" HeaderText="Daños Familia"
                            SortExpression="DanosFamilia" UniqueName="DanosFamilia" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Ha_VBG_General" HeaderText="VBG General"
                            SortExpression="Ha_VBG_General" UniqueName="Ha_VBG_General" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>
              
                        <telerik:GridBoundColumn DataField="VBG_General_Agresor" HeaderText="VBG Agresor"
                            SortExpression="VBG_General_Agresor" UniqueName="VBG_General_Agresor" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>
              
                        <telerik:GridBoundColumn DataField="Muerto" HeaderText="ADD Muerto"
                            SortExpression="Muerto" UniqueName="Muerto" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>            
              
                        <telerik:GridBoundColumn DataField="Muerto_Despues" HeaderText="DDD Muerto"
                            SortExpression="Muerto_Despues" UniqueName="Muerto_Despues" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>  

                        <telerik:GridBoundColumn DataField="Desaparecido" HeaderText="Desaparecido"
                            SortExpression="Desaparecido" UniqueName="Desaparecido" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn> 

                        <telerik:GridBoundColumn DataField="DatoRetornaria" HeaderText="Retornaria"
                            SortExpression="DatoRetornaria" UniqueName="DatoRetornaria" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>
              
                        <telerik:GridBoundColumn DataField="MotivoNoRetorno" HeaderText="Motivo No Retornaria"
                            SortExpression="MotivoNoRetorno" UniqueName="MotivoNoRetorno" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Atencion_Psicosocial" HeaderText="Atención Psicosocial"
                            SortExpression="Atencion_Psicosocial" UniqueName="Atencion_Psicosocial" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Atencion_Psicosocial" HeaderText="Atención Psicosocial"
                            SortExpression="Atencion_Psicosocial" UniqueName="Atencion_Psicosocial" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Ha_Afectado_Desplazamiento" HeaderText="Ha Afectado Desplazamiento"
                            SortExpression="Ha_Afectado_Desplazamiento" UniqueName="Ha_Afectado_Desplazamiento" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>               
             
                        <telerik:GridBoundColumn DataField="Ha_Sentido_Emociones" HeaderText="Ayuda Hablar"
                            SortExpression="Ha_Sentido_Emociones" UniqueName="Ha_Sentido_Emociones" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>  

                        <telerik:GridBoundColumn DataField="PersonasAyuda" HeaderText="Personas Ayuda Hablar"
                            SortExpression="PersonasAyuda" UniqueName="PersonasAyuda" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>  

                        <telerik:GridBoundColumn DataField="ApoyoAyuda" HeaderText="Apoyo Ayuda Hablar"
                            SortExpression="ApoyoAyuda" UniqueName="ApoyoAyuda" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Ha_Tenido_Adiccion" HeaderText="Adicción"
                            SortExpression="Ha_Tenido_Adiccion" UniqueName="Ha_Tenido_Adiccion" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Ha_Adiccion_Alcohol" HeaderText="Adicción Alcohol"
                            SortExpression="Ha_Adiccion_Alcohol" UniqueName="Ha_Adiccion_Alcohol" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>
                
                        <telerik:GridBoundColumn DataField="Ha_Adiccion_Droga" HeaderText="Adicción Droga"
                            SortExpression="Ha_Adiccion_Droga" UniqueName="Ha_Adiccion_Droga" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>                
                 
                        <telerik:GridBoundColumn DataField="Declaracion_Bienes_Perdio" HeaderText="Bienes Perdio"
                            SortExpression="Declaracion_Bienes_Perdio" UniqueName="Declaracion_Bienes_Perdio" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>  
           
                        <telerik:GridBoundColumn DataField="DescripcionTipo_Bien_Rural" HeaderText="Tipo Bien Rural"
                            SortExpression="DescripcionTipo_Bien_Rural" UniqueName="DescripcionTipo_Bien_Rural" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn> 
             
                        <telerik:GridBoundColumn DataField="DescripcionDocumento_Propiedad" HeaderText="Doc. Propiedad"
                            SortExpression="DescripcionDocumento_Propiedad" UniqueName="DescripcionDocumento_Propiedad" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn> 
              
                        <telerik:GridBoundColumn DataField="Copia_Documento" HeaderText="Copia Documento"
                            SortExpression="Copia_Documento" UniqueName="Copia_Documento" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn> 
              
                        <telerik:GridBoundColumn DataField="DescripcionDestino_Tierra" HeaderText="Destino Tierra"
                            SortExpression="DescripcionDestino_Tierra" UniqueName="DescripcionDestino_Tierra" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn> 

                        <telerik:GridBoundColumn DataField="Situacion_Actual" HeaderText="Situación Actual"
                            SortExpression="Situacion_Actual" UniqueName="Situacion_Actual" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn> 
							
                    </Columns>
                </MasterTableView>
            </telerik:RadGrid>
            <telerik:RadScriptManager ID="RadScriptManager2" Runat="server">
            </telerik:RadScriptManager>    
        </div>
    </form>
</body>
</html>
