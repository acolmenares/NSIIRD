<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="Validar_Identificacion.aspx.vb" Inherits="WebForms_Validar_Identificacion" %>
<%@ Register Src="../Controles/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <asp:Panel runat="server" ID="pnl_principal" DefaultButton ="btn_actualizar" Width ="100%">
     <table id="tbl_Interna" border="0" cellpadding="1" cellspacing="0" width="95%" 
            style="border-right: whitesmoke thin solid; border-top: whitesmoke thin solid; border-left: whitesmoke thin solid; border-bottom: whitesmoke thin solid">
        <tr valign ="top">
        <td style="width: 80%;"> 
            <asp:Label ID="Label31" runat="server" 
                Text="SISTEMA DE VALIDACION DE IDENTIFICACION" Width="100%" 
                CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
            <asp:Label ID="lblmensaje" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="Label42" runat="server" CssClass="TitMensaje" Text="_" Width="100%" Visible="False"></asp:Label></td>
        <td style="width: 20%" align="right">
            <asp:ImageButton ID="btn_actualizar" runat="server" 
                ImageUrl="~/Images/Reload.jpg" TabIndex="1" 
                ToolTip="Actualizar la vista actual." />
            <asp:ImageButton ID="btn_buscar" runat="server" ImageUrl="~/Images/Zoom In.jpg" 
                ToolTip="Ver/quitar Sistema de Búsqueda." TabIndex="2" Visible="False" />
            <asp:ImageButton ID="btn_nuevo" runat="server" ImageUrl="~/Images/Add.jpg" 
                ToolTip="Crear Nuevo Registro." TabIndex="3" Visible="False" />
            <asp:ImageButton ID="btn_cerrar" runat="server" ImageUrl="~/Images/Stop.jpg" ToolTip="Cerrar - Volver a la vista anterior." TabIndex="4" />
            <asp:ImageButton ID="btn_home" runat="server" ImageUrl="~/Images/Home.jpg" ToolTip="Ir al Inicio." TabIndex="5" />&nbsp;</td>
        </tr>
            <tr valign="top">
                <td colspan="2" align="center">
                    <table id="TablaContenido" cellspacing="0" cellpadding="0" border="0" class="ContentTable" style="width: 100%; text-align: center">
                        <tr valign="top">
                            <td align="left" colspan="2" style="background-color: gainsboro">
                                <asp:Label ID="Label2" runat="server" ForeColor="Navy" Width="250px">Digite el número de  Identificación</asp:Label><asp:TextBox id="txt_Identificacion" runat = "server" Width="200px" MaxLength="15"></asp:TextBox>
                                <asp:Button ID="btn_validar" runat="server" Cssclass="Boton" Text=">>"  ToolTip="Realizar la búsqueda " /></td>
                        </tr>
                        <tr style="background-color: #F7F7F7;">
                            <td style="width: 100%; " align="left" colspan="2">
				                <telerik:RadGrid ID="Rg_Listado" runat="server" AllowSorting="True" 
                                    GridLines="None" Skin="WebBlue" Width="100%" 
                                    AutoGenerateColumns="False" ShowStatusBar="True" TabIndex="6" 
                                    PageSize="20" CellSpacing="0">
                                    <MasterTableView  NoDetailRecordsText="No hay informaci&#243;n." NoMasterRecordsText="No hay informaci&#243;n." DataKeyNames="Id" CommandItemDisplay ="Top" AllowPaging="True">
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

                                            <telerik:GridBoundColumn DataField="Declaracion.DescripcionGrupo" HeaderText="Grupo"
                                                SortExpression="Declaracion.DescripcionGrupo" UniqueName="Declaracion.DescripcionGrupo" >
                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                            </telerik:GridBoundColumn>

                                            <telerik:GridBoundColumn DataField="Declaracion.Declarante" HeaderText="T.D."
                                                SortExpression="Declaracion.Declarante" UniqueName="Declaracion.Declarante" >
                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                            </telerik:GridBoundColumn>								
		
                                            <telerik:GridBoundColumn DataField="Tipo" HeaderText="Tipo"
                                                SortExpression="Tipo" UniqueName="Tipo" >
                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                            </telerik:GridBoundColumn>	
	
                                            <telerik:GridBoundColumn DataField="NombreCompleto" HeaderText="Nombre Completo"
                                                SortExpression="NombreCompleto" UniqueName="NombreCompleto" >
                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                            </telerik:GridBoundColumn>	
	
                                            <telerik:GridBoundColumn DataField="Identificacion" HeaderText="Identificacion"
                                                SortExpression="Identificacion" UniqueName="Identificacion" >
                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                            </telerik:GridBoundColumn>
					            
                                            <telerik:GridBoundColumn DataField="Edad" HeaderText="Edad"
                                                SortExpression="Edad" UniqueName="Edad" >
                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                            </telerik:GridBoundColumn>

                                            <telerik:GridBoundColumn DataField="Declaracion.Personas_Declarante.NombreCompleto" HeaderText="Declarante"
                                                SortExpression="Declaracion.Personas_Declarante.NombreCompleto" UniqueName="Declaracion.Personas_Declarante.NombreCompleto" >
                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                            </telerik:GridBoundColumn>
					            
                                            <telerik:GridBoundColumn DataField="Declaracion.Personas_Declarante.Identificacion" HeaderText="Identificación"
                                                SortExpression="Declaracion.Personas_Declarante.Identificacion" UniqueName="Declaracion.Personas_Declarante.Identificacion" >
                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                            </telerik:GridBoundColumn>

                                            <telerik:GridBoundColumn DataField="Declaracion.Fecha_Declaracion" DataType="System.DateTime" HeaderText="Fecha Declaración"
                                                DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Declaracion.Fecha_Declaracion" UniqueName="Declaracion.Fecha_Declaracion">
                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                            </telerik:GridBoundColumn>	

                                            <telerik:GridBoundColumn DataField="Declaracion.Fecha_Valoracion" DataType="System.DateTime" HeaderText="Fecha Atención"
                                                DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Declaracion.Fecha_Valoracion" UniqueName="Declaracion.Fecha_Valoracion">
                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                            </telerik:GridBoundColumn>						            

                                            <telerik:GridBoundColumn DataField="Declaracion.Atendido" HeaderText="Atendido"
                                                SortExpression="Declaracion.Atendido" UniqueName="Declaracion.Atendido" >
                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                            </telerik:GridBoundColumn>
					            
                                            <telerik:GridBoundColumn DataField="Declaracion.Personas_Declarante.Direccion.Descripcion" HeaderText="Dirección"
                                                SortExpression="Declaracion.Personas_Declarante.Direccion.Descripcion" UniqueName="Declaracion.Personas_Declarante.Direccion.Descripcion" >
                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                            </telerik:GridBoundColumn>
					            
                                            <telerik:GridBoundColumn DataField="Declaracion.Personas_Declarante.Celular.Descripcion" HeaderText="Celular"
                                                SortExpression="Declaracion.Personas_Declarante.Celular.Descripcion" UniqueName="Declaracion.Personas_Declarante.Celular.Descripcion" >
                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                            </telerik:GridBoundColumn>
					            
                                            <telerik:GridBoundColumn DataField="Declaracion.TipoFamilia" HeaderText="Tipo"
                                                SortExpression="Declaracion.TipoFamilia" UniqueName="Declaracion.TipoFamilia" >
                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                            </telerik:GridBoundColumn>				            
					            
				                        </Columns>
                                        <CommandItemSettings ExportToCsvText ="Exportar a CSV" 
                                            ExportToExcelText ="Exportar a Excel" ExportToPdfText ="Exportar a PDF"
                                                ExportToWordText ="Exportar a Word" RefreshText ="Actualizar" 
                                            AddNewRecordText =""  AddNewRecordImageUrl ="~/Images/nothing.gif"
                                                ShowExportToCsvButton="True" ShowExportToExcelButton="True" 
                                            ShowExportToPdfButton="True" ShowExportToWordButton ="True" 
                                            ShowAddNewRecordButton="False"/>
                                        <PagerStyle Mode="NumericPages" FirstPageToolTip="Primera" LastPageToolTip="Ultima" NextPagesToolTip="Pr&#243;ximas" NextPageToolTip="Pr&#243;xima" PagerTextFormat="Cambiar P&#225;gina: {4} &amp;nbsp;P&#225;gina &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;, registros &lt;strong&gt;{2}&lt;/strong&gt; a &lt;strong&gt;{3}&lt;/strong&gt; de &lt;strong&gt;{5}&lt;/strong&gt;." PrevPageToolTip="Anterior"  PrevPagesToolTip="Anteriores" />
                                    </MasterTableView>
                                    <ClientSettings EnablePostBackOnRowClick="True" EnableRowHoverStyle ="True" >
                                    <Selecting AllowRowSelect ="True"  />
                                    </ClientSettings>
                    
                                        <ExportSettings
                                        HideStructureColumns="True" filename ="Validacion" ExportOnlyData="True" IgnorePaging="True" OpenInNewWindow="True">
                                            <Pdf PageWidth="" >
                                            </Pdf>
                                    </ExportSettings>
                                    <SortingSettings SortToolTip="Clic aqui para ordenar..."  SortedAscToolTip ="Ordenar Ascendente" SortedDescToolTip ="Ordenar Descendente" />
                                    <PagerStyle Mode="NumericPages"    />
                
                                </telerik:RadGrid>                          
                            
                             </td>
                        </tr>
                    </table>
                 
                </td>
            </tr>

        </table>
    </asp:Panel>

<telerik:RadAjaxLoadingPanel ID="LoadingPanel2" runat="server" 
        BackgroundPosition="Right" Height="0px" Transparency="50">
        <asp:Image ID="Image1" runat="server" AlternateText="Cargando..." 
            ImageUrl="~/Images/loading.gif" />
            <telerik:RadScriptManager ID="RadScriptManager1" Runat="server">
        </telerik:RadScriptManager>
              <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server" 
                  DefaultLoadingPanelID="LoadingPanel2">
                  <AjaxSettings>
                      <telerik:AjaxSetting AjaxControlID="btn_actualizar">
                          <UpdatedControls>
                              <telerik:AjaxUpdatedControl ControlID="pnl_principal" />
                          </UpdatedControls>
                      </telerik:AjaxSetting>
                      <telerik:AjaxSetting AjaxControlID="btn_buscar">
                      </telerik:AjaxSetting>
                      <telerik:AjaxSetting AjaxControlID="btn_validar">
                          <UpdatedControls>
                              <telerik:AjaxUpdatedControl ControlID="txt_Identificacion" 
                                  UpdatePanelCssClass="" />
                              <telerik:AjaxUpdatedControl ControlID="Rg_Listado" UpdatePanelCssClass="" />
                          </UpdatedControls>
                      </telerik:AjaxSetting>
                      <telerik:AjaxSetting AjaxControlID="Rg_Listado">
                          <UpdatedControls>
                              <telerik:AjaxUpdatedControl ControlID="Rg_Listado" UpdatePanelCssClass="" />
                          </UpdatedControls>
                      </telerik:AjaxSetting>
                  </AjaxSettings>
              </telerik:RadAjaxManager>
    </telerik:RadAjaxLoadingPanel>
</asp:Content>

