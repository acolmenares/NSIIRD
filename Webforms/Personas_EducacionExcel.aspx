<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Personas_EducacionExcel.aspx.vb" Inherits="WebForms_Personas_EducacionExcel" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sistema de Exportar Educación </title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <telerik:RadScriptManager ID="RadScriptManager1" Runat="server" />
        
		<telerik:RadGrid ID="Rg_Listado" runat="server" GridLines="None" Skin="Default" Width="100%" 
            AutoGenerateColumns="False" ShowStatusBar="True" TabIndex="6" 
            PageSize="20" CellSpacing="0">
            <AlternatingItemStyle BackColor="White" Cssclass="DataGridAlternatingItemStyle" />
            <ItemStyle BackColor="#E3EAEB" Cssclass="DataGridItemStyle" />
            <MasterTableView  NoDetailRecordsText="No hay informaci&#243;n." 
                NoMasterRecordsText="No hay informaci&#243;n." DataKeyNames="Id">
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

                    <telerik:GridBoundColumn DataField="Fecha_Nacimiento" DataType="System.DateTime" HeaderText="Fecha Nacimiento"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_Nacimiento" UniqueName="Fecha_Nacimiento">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>	

                     <telerik:GridBoundColumn DataField="Persona_Grupo_Etnico" HeaderText="Etnia"
                        SortExpression="Persona_Grupo_Etnico" UniqueName="Persona_Grupo_Etnico" >
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

                    <telerik:GridBoundColumn DataField="Declaracion.Declarante" HeaderText="T.D."
                        SortExpression="Declaracion.Declarante" UniqueName="Declaracion.Declarante" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Declaracion.Personas_Declarante.Identificacion" HeaderText="Identificación Declarante"
                        SortExpression="Declaracion.Personas_Declarante.Identificacion" UniqueName="Declaracion.Personas_Declarante.Identificacion" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Declaracion.Personas_Declarante.NombreCompleto" HeaderText="Nombre Declarante"
                        SortExpression="Declaracion.Personas_Declarante.NombreCompleto" UniqueName="Declaracion.Personas_Declarante.NombreCompleto" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Declaracion.Personas_Declarante.Celular.Descripcion" HeaderText="Celular Declarante"
                        SortExpression="Declaracion.Personas_Declarante.Celular.Descripcion" UniqueName="Declaracion.Personas_Declarante.Celular.Descripcion" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Declaracion.Personas_Declarante.Barrio.Descripcion" HeaderText="Barrio Declarante"
                        SortExpression="Declaracion.Personas_Declarante.Barrio.Descripcion" UniqueName="Declaracion.Personas_Declarante.Barrio.Descripcion" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Declaracion.Personas_Declarante.Telefono.Descripcion" HeaderText="Telefono Declarante"
                        SortExpression="Declaracion.Personas_Declarante.Telefono.Descripcion" UniqueName="Declaracion.Personas_Declarante.Telefono.Descripcion" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Declaracion.Personas_Declarante.Direccion.Descripcion" HeaderText="Direccion Declarante"
                        SortExpression="Declaracion.Personas_Declarante.Direccion.Descripcion" UniqueName="Declaracion.Personas_Declarante.Direccion.Descripcion" >
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

                    <telerik:GridBoundColumn DataField="Estudiaba_Actualmente" HeaderText="Estudia Actual"
                        SortExpression="Estudiaba_Actualmente" UniqueName="Estudiaba_Actualmente" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

	                <telerik:GridBoundColumn DataField="Certificado" HeaderText="Certificado"
                        SortExpression="Certificado" UniqueName="Certificado" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

	                <telerik:GridBoundColumn DataField="MotivoNoestudiaPrimeraEntrega" HeaderText="Motivo No Estudia PE"
                        SortExpression="MotivoNoestudiaPrimeraEntrega" UniqueName="MotivoNoestudiaPrimeraEntrega" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

	                <telerik:GridBoundColumn DataField="Persona_UltimoGrado" HeaderText="Grado PE"
                        SortExpression="Persona_UltimoGrado" UniqueName="Persona_UltimoGrado" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

	                <telerik:GridBoundColumn DataField="TipoApoyoEducativo" HeaderText="Apoyo Educativo"
                        SortExpression="TipoApoyoEducativo" UniqueName="TipoApoyoEducativo" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

	                <telerik:GridBoundColumn DataField="Nombre_Municipio_Actual" HeaderText="Mun. Instituto"
                        SortExpression="Nombre_Municipio_Actual" UniqueName="Nombre_Municipio_Actual" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

	                <telerik:GridBoundColumn DataField="Institucion_Estudia" HeaderText="Nombre Instituto"
                        SortExpression="Institucion_Estudia" UniqueName="Institucion_Estudia" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>


                    

                    <telerik:GridBoundColumn DataField="Fecha_Segunda_Encuesta" DataType="System.DateTime" HeaderText="Fecha 2a Entrega"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_Segunda_Encuesta" UniqueName="Fecha_Segunda_Encuesta">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>	

	                <telerik:GridBoundColumn DataField="EstudiaActualmente_SE" HeaderText="Estudia Actualmente SE"
                        SortExpression="EstudiaActualmente_SE" UniqueName="EstudiaActualmente_SE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

	                <telerik:GridBoundColumn DataField="MotivoNoEstudia_SE" HeaderText="Motivo No Estudia SE"
                        SortExpression="MotivoNoEstudia_SE" UniqueName="MotivoNoEstudia_SE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

	                <telerik:GridBoundColumn DataField="Grado_SE" HeaderText="Grado SE"
                        SortExpression="Grado_SE" UniqueName="Grado_SE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

	                <telerik:GridBoundColumn DataField="Certificado_SE" HeaderText="Certificado SE"
                        SortExpression="Certificado_SE" UniqueName="Certificado_SE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

	                <telerik:GridBoundColumn DataField="Seguimiento_SE" HeaderText="Seguimiento SE"
                        SortExpression="Seguimiento_SE" UniqueName="Seguimiento_SE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

	                <telerik:GridBoundColumn DataField="Municipio_Establecimiento_SE" HeaderText="Mun. Instituto SE"
                        SortExpression="Municipio_Establecimiento_SE" UniqueName="Municipio_Establecimiento_SE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

	                <telerik:GridBoundColumn DataField="Establecimiento" HeaderText=" Instituto SE"
                        SortExpression="Establecimiento" UniqueName="Establecimiento" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
 
                            
                    <telerik:GridBoundColumn DataField="FechaSeguimiento" DataType="System.DateTime" HeaderText="Fecha Seguimiento"
                        DataFormatString="{0:dd/MMM/yyyy}" SortExpression="FechaSeguimiento" UniqueName="FechaSeguimiento">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>	

	                <telerik:GridBoundColumn DataField="EstudiaActualmenteSeguimiento" HeaderText="Estudia Actualmente SEG"
                        SortExpression="EstudiaActualmenteSeguimiento" UniqueName="EstudiaActualmenteSeguimiento" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

	                <telerik:GridBoundColumn DataField="MotivoNoEstudiaSeguimiento" HeaderText="Motivo No Estudia SEG"
                        SortExpression="MotivoNoEstudiaSeguimiento" UniqueName="MotivoNoEstudiaSeguimiento" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

	                <telerik:GridBoundColumn DataField="GradoSeguimiento" HeaderText="Grado SEG"
                        SortExpression="GradoSeguimiento" UniqueName="GradoSeguimiento" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

	                <telerik:GridBoundColumn DataField="CertificadoSeguimiento" HeaderText="Certificado SEG"
                        SortExpression="CertificadoSeguimiento" UniqueName="CertificadoSeguimiento" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

	                <telerik:GridBoundColumn DataField="SeguimientoSeguimiento" HeaderText="Seguimiento SEG"
                        SortExpression="SeguimientoSeguimiento" UniqueName="SeguimientoSeguimiento" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

	                <telerik:GridBoundColumn DataField="MunicipioSeguimiento" HeaderText="Mun. Instituto SEG"
                        SortExpression="MunicipioSeguimiento" UniqueName="MunicipioSeguimiento" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

	                <telerik:GridBoundColumn DataField="EstablecimientoSeguimiento" HeaderText=" Instituto SEG"
                        SortExpression="EstablecimientoSeguimiento" UniqueName="EstablecimientoSeguimiento" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
                 

	                <telerik:GridBoundColumn DataField="Verificado" HeaderText="Verificado SEG"
                        SortExpression="Verificado" UniqueName="Verificado" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

							            
				</Columns>
                <CommandItemSettings ExportToCsvText ="Exportar a CSV" ExportToExcelText ="Exportar a Excel" ExportToPdfText ="Exportar a PDF"
                        ExportToWordText ="Exportar a Word" RefreshText ="Actualizar" AddNewRecordText =""  AddNewRecordImageUrl ="~/Images/nothing.gif"
                        ShowExportToCsvButton="True" ShowExportToExcelButton="True" ShowExportToPdfButton="True" ShowExportToWordButton ="True"/>
                <PagerStyle Mode="NumericPages" FirstPageToolTip="Primera" LastPageToolTip="Ultima" NextPagesToolTip="Pr&#243;ximas" NextPageToolTip="Pr&#243;xima" PagerTextFormat="Cambiar P&#225;gina: {4} &amp;nbsp;P&#225;gina &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;, registros &lt;strong&gt;{2}&lt;/strong&gt; a &lt;strong&gt;{3}&lt;/strong&gt; de &lt;strong&gt;{5}&lt;/strong&gt;." PrevPageToolTip="Anterior"  PrevPagesToolTip="Anteriores" />
            </MasterTableView>
            <ClientSettings EnablePostBackOnRowClick="True" EnableRowHoverStyle ="True" >
            </ClientSettings>
                    
                <ExportSettings
                HideStructureColumns="True" filename ="SeguimientoEducacion" ExportOnlyData="True" IgnorePaging="True" OpenInNewWindow="True">
                    <Pdf PageWidth="" >
                    </Pdf>
            </ExportSettings>
            <SortingSettings SortToolTip="Clic aqui para ordenar..."  SortedAscToolTip ="Ordenar Ascendente" SortedDescToolTip ="Ordenar Descendente" />
            <PagerStyle Mode="NumericPages"    />
                
        </telerik:RadGrid>    
    </div>
    </form>
</body>
</html>
