<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="ProgramacionList.aspx.vb" Inherits="WebForms_ProgramacionList" %>
<%@ Register Src="../Controles/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel runat="server" ID="pnl_principal" DefaultButton ="btn_Procesar" Width ="100%">
         <table id="tbl_Interna" border="0" cellpadding="1" cellspacing="0" width="100%" 
                style="border-right: whitesmoke thin solid; border-top: whitesmoke thin solid; border-left: whitesmoke thin solid; border-bottom: whitesmoke thin solid">
            <tr valign ="top">
                <td style="width: 80%;"> 
                    <asp:Label ID="Label3" runat="server" 
                        Text="VISTA GENERAL DE PROGRAMACIONES" Width="100%" 
                        CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
                    <asp:Label ID="Label4" runat="server" CssClass="TitMensaje" Text="_" Width="100%" Visible="False"></asp:Label>
                </td>
                <td style="width: 20%" align="right">
                    <asp:ImageButton ID="btn_excel" runat="server" 
                        ImageUrl="~/Images/Excel-icon.png" ToolTip="Exportar a Excel Alterno" 
                        TabIndex="1" />
                    <asp:ImageButton ID="btn_actualizar" runat="server" 
                        ImageUrl="~/Images/Reload.jpg" TabIndex="1" 
                        ToolTip="Actualizar la vista actual." />
                    <asp:ImageButton ID="btn_buscar" runat="server" ImageUrl="~/Images/Zoom In.jpg" ToolTip="Ver/quitar Sistema de Búsqueda." TabIndex="2" />
                    <asp:ImageButton ID="btn_nuevo" runat="server" ImageUrl="~/Images/Add.jpg" 
                        ToolTip="Crear Nuevo Registro." TabIndex="3" />
                    <asp:ImageButton ID="btn_cerrar" runat="server" ImageUrl="~/Images/Stop.jpg" ToolTip="Cerrar - Volver a la vista anterior." TabIndex="4" />
                    <asp:ImageButton ID="btn_home" runat="server" ImageUrl="~/Images/Home.jpg" ToolTip="Ir al Inicio." TabIndex="5" />&nbsp;</td>
            </tr>
            <tr valign ="top">
                <td colspan="2" align="center" >
                    <asp:Panel ID="pnl_buscar" runat="server" Width="100%" HorizontalAlign="Center" Visible="False">
                        <table border="0" cellpadding="0" cellspacing="0" style="width: 100%; text-align: left; padding-left: 3px;">
                        <tr valign ="top">
                            <td colspan="5" style="text-align: left; width: 80%;" >
                                <asp:Label ID="Label6" runat="server" Text="Sistema de Búsqueda Selectiva" Width="90%" Font-Bold="True" Font-Underline="False"></asp:Label></td>
                            <td style="width: 20%" align="right">
                                <asp:ImageButton ID="btn_Procesar" runat="server" ImageUrl="~/Images/Search.jpg" ToolTip="Realizar la Búsqueda." TabIndex="5" />
                                <asp:ImageButton ID="btn_limpiar" runat="server" ImageUrl="~/Images/New.jpg" ToolTip="Limpiar Campos Búsqueda." TabIndex="6" /></td>
                        </tr>
                        <tr valign="top">
                            <td style="width: 15%">
                                <asp:Label ID="Label41" runat="server" Text="Regional" Width="94%"></asp:Label>
                            </td>
                            <td style="width: 15%">
                                <asp:DropDownList ID="ddl_regional" runat="server" AutoPostBack="True" 
                                    Font-Size="X-Small" TabIndex="3" Width="94%">
                                </asp:DropDownList>
                            </td>
                            <td style="width: 15%">
                                <asp:Label ID="Label8" runat="server" Text="Fecha Inicial programación" 
                                    Width="94%"></asp:Label>
                            </td>
                            <td style="width: 25%">
                                <telerik:RadDatePicker ID="rdpfechaInicialRadicacion" runat="server" 
                                    Culture="es-CO" MaxDate="2020-12-31" MinDate="" Skin="Telerik" TabIndex="1" 
                                    ToolTip="Seleccione Fecha ..." Width="90%">
                                    <Calendar EnableKeyboardNavigation="True" Skin="Telerik" 
                                        UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False" 
                                        ViewSelectorText="x">
                                        <FastNavigationSettings CancelButtonCaption="Cancelar" 
                                            DateIsOutOfRangeMessage="Fecha Fuera de Rango" TodayButtonCaption="Hoy">
                                        </FastNavigationSettings>
                                    </Calendar>
                                    <DatePopupButton HoverImageUrl="" ImageUrl="" TabIndex="1" 
                                        ToolTip="Abrir el Calendario" />
                                    <DateInput DateFormat="dd/MM/yyyy" DisplayDateFormat="dd/MMMM/yyyy" 
                                        EmptyMessage="Fecha ..." TabIndex="1">
                                        <EmptyMessageStyle Resize="None" />
                                        <ReadOnlyStyle Resize="None" />
                                        <FocusedStyle Resize="None" />
                                        <DisabledStyle Resize="None" />
                                        <InvalidStyle Resize="None" />
                                        <HoveredStyle Resize="None" />
                                        <EnabledStyle Resize="None" />
                                    </DateInput>
                                </telerik:RadDatePicker>
                            </td>
                            <td style="width: 15%">
                                <asp:Label ID="Label22" runat="server" Text="Lugar de Fuente" Width="94%"></asp:Label>
                            </td>
                            <td style="width: 15%">
                                <asp:DropDownList ID="ddl_LugarFuente" runat="server" Font-Size="X-Small" 
                                    TabIndex="5" Width="94%">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td style="width: 15%">
                                <asp:Label ID="Label42" runat="server" Text="Programa" Width="94%"></asp:Label></td>
                            <td style="width: 15%">
                                <asp:dropdownlist ID="ddl_Programas" runat="server" Width="94%" 
                                    Font-Size="X-Small">
                                </asp:dropdownlist></td>
                            <td style="width: 15%">
                                <asp:Label ID="Label9" runat="server" Text="Fecha Final Programación" 
                                    Width="94%"></asp:Label>
                            </td>
                            <td style="width: 25%">
                                <telerik:RadDatePicker ID="rdpfechaFinalRadicacion" runat="server" 
                                    Culture="es-CO" MaxDate="2020-12-31" MinDate="" Skin="Telerik" TabIndex="1" 
                                    ToolTip="Seleccione Fecha ..." Width="90%">
                                    <Calendar EnableKeyboardNavigation="True" Skin="Telerik" 
                                        UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False" 
                                        ViewSelectorText="x">
                                        <FastNavigationSettings CancelButtonCaption="Cancelar" 
                                            DateIsOutOfRangeMessage="Fecha Fuera de Rango" TodayButtonCaption="Hoy">
                                        </FastNavigationSettings>
                                    </Calendar>
                                    <DatePopupButton HoverImageUrl="" ImageUrl="" TabIndex="1" 
                                        ToolTip="Abrir el Calendario" />
                                    <DateInput DateFormat="dd/MM/yyyy" DisplayDateFormat="dd/MMMM/yyyy" 
                                        EmptyMessage="Fecha ..." TabIndex="1">
                                        <EmptyMessageStyle Resize="None" />
                                        <ReadOnlyStyle Resize="None" />
                                        <FocusedStyle Resize="None" />
                                        <DisabledStyle Resize="None" />
                                        <InvalidStyle Resize="None" />
                                        <HoveredStyle Resize="None" />
                                        <EnabledStyle Resize="None" />
                                    </DateInput>
                                </telerik:RadDatePicker>
                            </td>
                            <td style="width: 15%">
                                &nbsp;</td>
                            <td style="width: 15%">
                                </td>
                        </tr>
                    </table>
                        
                    </asp:Panel>
			    </td>
            </tr>
            <tr valign ="top">
                <td colspan="2">
				    <telerik:RadGrid ID="Rg_Listado" runat="server" AllowSorting="True" GridLines="None" Skin="WebBlue" Width="100%"  
                        AutoGenerateColumns="False" ShowStatusBar="True" TabIndex="6" PageSize="20" CellSpacing="0">
                        <MasterTableView  NoDetailRecordsText="No hay informaci&#243;n." NoMasterRecordsText="No hay informaci&#243;n." DataKeyNames="Id" CommandItemDisplay ="Top" AllowPaging="True">
                            <Columns>
                               <telerik:GridTemplateColumn HeaderText="No." DefaultInsertValue="" UniqueName="TemplateColumn">
                                    <ItemTemplate>
                                        <asp:label runat="server" id="lblno" text='<%# ctype(CType(Container.Parent.Parent.Parent,RadGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>' ToolTip = '<%#Container.DataItem.Id%>' />
                                        <asp:Label runat="Server" Id="lblid" Visible ="False" Text ='<%#Container.DataItem.Id%>'/>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>                                
                        
                                <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" HeaderText="Id" ReadOnly="True"
                                    SortExpression="Id" UniqueName="Id"  Display ="False" >
                                </telerik:GridBoundColumn>

                                <telerik:GridBoundColumn DataField="Fecha" DataType="System.DateTime" HeaderText="Fecha "
                                    DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha" UniqueName="Fecha">
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                </telerik:GridBoundColumn>						            
				            
						        <telerik:GridBoundColumn DataField="Regionales.Descripcion" HeaderText="Regional"  
                                    SortExpression="Regionales.Descripcion" UniqueName="Regionales.Descripcion" >
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                </telerik:GridBoundColumn> 
					            					            
						        <telerik:GridBoundColumn DataField="LugarEntrega.Descripcion" HeaderText="Lugar Entrega"
                                    SortExpression="LugarEntrega.Descripcion" UniqueName="LugarEntrega.Descripcion" >
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                </telerik:GridBoundColumn> 
					            
						        <telerik:GridBoundColumn DataField="Estados.Descripcion" HeaderText="Estado"
                                    SortExpression="Estados.Descripcion" UniqueName="Estados.Descripcion" >
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                </telerik:GridBoundColumn> 				            
					            
						        <telerik:GridBoundColumn DataField="Grupo.Descripcion" HeaderText="Grupo"
                                    SortExpression="Grupo.Descripcion" UniqueName="Grupo.Descripcion" >
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                </telerik:GridBoundColumn> 	                                
                                						
						        <telerik:GridBoundColumn DataField="Numero" HeaderText="Número"  
                                    SortExpression="Numero" UniqueName="Numero" >
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                </telerik:GridBoundColumn> 	

						        <telerik:GridBoundColumn DataField="TipoEntrega.Descripcion" HeaderText="Tipo Entrega"
                                    SortExpression="TipoEntrega.Descripcion" UniqueName="TipoEntrega.Descripcion" >
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                </telerik:GridBoundColumn> 
                            			  
						        <telerik:GridBoundColumn DataField="Bodegas.Descripcion" HeaderText="Bodega"
                                    SortExpression="Bodegas.Descripcion" UniqueName="Bodegas.Descripcion" >
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
                            <PagerStyle Mode="NumericPages" FirstPageToolTip="Primera" 
                                LastPageToolTip="Ultima" NextPagesToolTip="Pr&#243;ximas" 
                                NextPageToolTip="Pr&#243;xima" 
                                PagerTextFormat="Cambiar P&#225;gina: {4} &amp;nbsp;P&#225;gina &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;, registros &lt;strong&gt;{2}&lt;/strong&gt; a &lt;strong&gt;{3}&lt;/strong&gt; de &lt;strong&gt;{5}&lt;/strong&gt;." 
                                PrevPageToolTip="Anterior"  PrevPagesToolTip="Anteriores" 
                                AlwaysVisible="True" />
                        </MasterTableView>
                        <ClientSettings EnablePostBackOnRowClick="True" EnableRowHoverStyle ="True" >
                        <Selecting AllowRowSelect ="True"  />
                        </ClientSettings>
                    
                         <ExportSettings
                           HideStructureColumns="True" filename ="Programaciones" ExportOnlyData="True" IgnorePaging="True" OpenInNewWindow="True">
                             <Pdf PageWidth="" >
                             </Pdf>
                        </ExportSettings>
                        <SortingSettings SortToolTip="Clic aqui para ordenar..."  SortedAscToolTip ="Ordenar Ascendente" SortedDescToolTip ="Ordenar Descendente" />
                        <PagerStyle Mode="NumericPages"    />
                
                    </telerik:RadGrid>
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
       
    </telerik:RadAjaxLoadingPanel>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server" 
        DefaultLoadingPanelID="LoadingPanel2">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="btn_actualizar">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="pnl_principal" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btn_buscar">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="pnl_buscar" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btn_nuevo">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="pnl_principal" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btn_Procesar">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="pnl_buscar" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Rg_Listado" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btn_limpiar">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ddl_regional" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rdpfechaInicialRadicacion" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_LugarFuente" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_Programas" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rdpfechaFinalRadicacion" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Rg_Listado" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ddl_regional">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ddl_LugarFuente" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_Programas" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager> 
</asp:Content>

