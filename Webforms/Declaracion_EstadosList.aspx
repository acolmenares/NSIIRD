<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="Declaracion_EstadosList.aspx.vb" Inherits="WebForms_Declaracion_EstadosList" %>
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
                        Text="VISTA GENERAL DE ESTADOS DE LAS DECLARACIONES" Width="100%" 
                        CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
                <asp:Label ID="Label4" runat="server" CssClass="TitMensaje" Text="_" Width="100%" Visible="False"></asp:Label></td>
                <td style="width: 20%" align="right">
                    <asp:ImageButton ID="Btn_Excel" runat="server" 
                        ImageUrl="~/Images/Excel-icon.png" ToolTip="Exportar a Excel Alterno" 
                        TabIndex="1" PostBackUrl="~/Webforms/Declaracion_EstadosExcel.aspx" />
                    <asp:ImageButton ID="btn_actualizar" runat="server" 
                        ImageUrl="~/Images/Reload.jpg" TabIndex="1" 
                        ToolTip="Actualizar la vista actual." />
                    <asp:ImageButton ID="btn_buscar" runat="server" ImageUrl="~/Images/Zoom In.jpg" ToolTip="Ver/quitar Sistema de Búsqueda." TabIndex="2" />
                    <asp:ImageButton ID="btn_nuevo" runat="server" ImageUrl="~/Images/Add.jpg" 
                        ToolTip="Crear Nuevo Registro." TabIndex="3" Visible="False" />
                    <asp:ImageButton ID="btn_cerrar" runat="server" ImageUrl="~/Images/Stop.jpg" ToolTip="Cerrar - Volver a la vista anterior." TabIndex="4" />
                    <asp:ImageButton ID="btn_home" runat="server" ImageUrl="~/Images/Home.jpg" ToolTip="Ir al Inicio." TabIndex="5" />
                </td>
            </tr>
            <tr valign ="top">
                <td colspan="2" align="center" >
				    <asp:Panel ID="pnl_buscar" runat="server" Width="100%" HorizontalAlign="Center" Visible="False">
                        <table border="0" cellpadding="0" cellspacing="0" style="width: 100%; text-align: left; padding-left: 3px;">
                            <tr valign ="top">
                                <td colspan="5" style="text-align: left" >
                                    <asp:Label ID="Label5" runat="server" Text="Sistema de Búsqueda Selectiva" Width="90%" Font-Bold="True" Font-Underline="False"></asp:Label></td>
                                <td align="right" >
                                    <asp:ImageButton ID="btn_Procesar" runat="server" ImageUrl="~/Images/Search.jpg" ToolTip="Realizar la Búsqueda." TabIndex="5" />
                                    <asp:ImageButton ID="btn_limpiar" runat="server" ImageUrl="~/Images/New.jpg" ToolTip="Limpiar Campos Búsqueda." TabIndex="6" /></td>
                            </tr>
                            
                            <tr valign="top">
                                <td style="width: 15%; height: 21px;">
                                    <asp:Label ID="Label41" runat="server" Text="Regional" Width="94%"></asp:Label></td>
                                <td style="width: 15%; height: 21px;">
                                    <asp:dropdownlist ID="ddl_regional" runat="server" Width="94%" 
                                        Font-Size="X-Small" AutoPostBack="True">
                                    </asp:dropdownlist></td>
                                <td style="width: 15%; height: 21px;">
                                    <asp:Label ID="Label10" runat="server" Text="Fecha Inicial Radicación" Width="94%"></asp:Label></td>
                                <td style="width: 15%; height: 21px;">
                                    <telerik:RadDatePicker ID="rdpFechaInicial" runat="server" 
                                        Culture="es-CO" MinDate="" Skin="Telerik" 
                                        ToolTip="Seleccione Fecha ..." Width="95%" ResolvedRenderMode="Classic">
                                        <Calendar Skin="Telerik" UseColumnHeadersAsSelectors="False" 
                                            UseRowHeadersAsSelectors="False" ViewSelectorText="x">
                                            <FastNavigationSettings CancelButtonCaption="Cancelar" 
                                                DateIsOutOfRangeMessage="Fecha Fuera de Rango" TodayButtonCaption="Hoy">
                                            </FastNavigationSettings>
                                        </Calendar>
                                        <DatePopupButton HoverImageUrl="" ImageUrl="" ToolTip="Abrir el Calendario" />
                                        <DateInput DateFormat="dd/MM/yyyy" DisplayDateFormat="dd/MMMM/yyyy" 
                                            EmptyMessage="Fecha ...">
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
                                <td style="width: 15%; height: 21px;">
                                    <asp:Label ID="Label16" runat="server" Text="Fecha Inicial Declaración" Width="94%"></asp:Label></td>
                                <td style="width: 15%; height: 21px;">
                                    <telerik:RadDatePicker ID="rdpFechaInicial_Declaracion" runat="server" 
                                        Culture="Spanish (Colombia)" MinDate="" Skin="Telerik" 
                                        ToolTip="Seleccione Fecha ..." Width="95%">
                                        <Calendar Skin="Telerik" UseColumnHeadersAsSelectors="False" 
                                            UseRowHeadersAsSelectors="False" ViewSelectorText="x">
                                            <FastNavigationSettings CancelButtonCaption="Cancelar" 
                                                DateIsOutOfRangeMessage="Fecha Fuera de Rango" TodayButtonCaption="Hoy">
                                            </FastNavigationSettings>
                                        </Calendar>
                                        <DatePopupButton HoverImageUrl="" ImageUrl="" ToolTip="Abrir el Calendario" />
                                        <DateInput DateFormat="dd/MM/yyyy" DisplayDateFormat="dd/MMMM/yyyy" 
                                            EmptyMessage="Fecha ...">
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
                            </tr>
                            <tr valign="top">
                                <td style="width: 15%; height: 21px;">
                                        <asp:Label ID="Label42" runat="server" Text="Lugar de Entrega" Width="94%"></asp:Label>
                                </td>
                               <td style="width: 15%; height: 21px;">
                                        <asp:DropDownList ID="ddl_Lugar_Entrega" runat="server" Font-Size="X-Small" 
                                            Width="94%">
                                        </asp:DropDownList>
                                </td>
                                <td style="width: 15%; height: 21px;">
                                    <asp:Label ID="Label12" runat="server" Text="Fecha Final Radicación" Width="94%"></asp:Label></td>
                                <td style="width: 15%; height: 21px;">
                                    <telerik:RadDatePicker ID="rdpfechaFinal" runat="server" 
                                        Culture="Spanish (Colombia)" MinDate="" Skin="Telerik" TabIndex="1" 
                                        ToolTip="Seleccione Fecha ..." Width="95%">
                                        <Calendar Skin="Telerik" UseColumnHeadersAsSelectors="False" 
                                            UseRowHeadersAsSelectors="False" ViewSelectorText="x">
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
                                <td style="width: 15%; height: 21px;">
                                    <asp:Label ID="Label17" runat="server" Text="Fecha Final Declaración" Width="94%"></asp:Label></td>
                                <td style="width: 15%; height: 21px;">
                                    <telerik:RadDatePicker ID="rdpfechaFinal_Declaracion" runat="server" 
                                        Culture="Spanish (Colombia)" MinDate="" Skin="Telerik" TabIndex="1" 
                                        ToolTip="Seleccione Fecha ..." Width="95%">
                                        <Calendar Skin="Telerik" UseColumnHeadersAsSelectors="False" 
                                            UseRowHeadersAsSelectors="False" ViewSelectorText="x">
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
                            </tr>
                            <tr valign="top">
                                <td style="width: 15%">
                                    <asp:Label ID="Label21" runat="server" Text="Tipo Declarante" Width="94%"></asp:Label>
                                </td>
                                <td style="width: 15%">
                                    <asp:DropDownList ID="ddl_tipodeclarante" runat="server" Font-Size="X-Small" 
                                        Width="94%">
                                    </asp:DropDownList>
                                </td>
                                <td style="width: 15%; height: 21px;">
                                    &nbsp;</td>
                                <td style="width: 15%">
                                    &nbsp;</td>
                                <td style="width: 15%; height: 21px;">
                                    &nbsp;</td>
                                <td style="width: 15%; height: 21px;">
                                    &nbsp;</td>
                            </tr>
                        </table>
                        
                    </asp:Panel>
                </td>
            </tr>
            <tr valign ="top">
                <td colspan="2">

                    <telerik:RadGrid ID="Rg_Listado" runat="server" AllowSorting="True" GridLines="None" Skin="WebBlue" Width="100%" 
                        AutoGenerateColumns="False" ShowStatusBar="True" TabIndex="6" PageSize="20" CellSpacing="0">
                        <MasterTableView  NoDetailRecordsText="No hay informaci&#243;n." 
                            NoMasterRecordsText="No hay informaci&#243;n." DataKeyNames="Id" 
                            CommandItemDisplay ="Top" AllowPaging="True">
                            <Columns>
                                <telerik:GridTemplateColumn HeaderText="No." DefaultInsertValue="" UniqueName="TemplateColumn">
                                    <ItemTemplate>
                                        <asp:label runat="server" id="lblno" text='<%# ctype(CType(Container.Parent.Parent.Parent,RadGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>' ToolTip ='<%#Container.DataItem.Id%>' />
                                        <asp:Label runat="Server" Id="lblid" Visible ="False" Text ='<%#Container.DataItem.Id%>'/>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>                                
                        
                                <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" HeaderText="Id" ReadOnly="True"
                                    SortExpression="Id" UniqueName="Id"  Display ="False" >
                                </telerik:GridBoundColumn>
					            
                                <telerik:GridBoundColumn DataField="Declarante" HeaderText="TD" HeaderTooltip ="Tipo de Declarante"
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

                                <telerik:GridBoundColumn DataField="NombreLugarFuente" HeaderText="Lugar Entrega" SortExpression="NombreLugarFuente" UniqueName="NombreLugarFuente" >
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

                                <telerik:GridBoundColumn DataField="Fecha_Contactado" DataType="System.String" HeaderText="Fecha Contacto"
                                     SortExpression="Fecha_Contactado" UniqueName="Fecha_Contactado">
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                </telerik:GridBoundColumn>	
					            
                                <telerik:GridBoundColumn DataField="Programado" HeaderText="PRG" SortExpression="Programado" UniqueName="Programado" >
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                </telerik:GridBoundColumn> 

                                <telerik:GridBoundColumn DataField="Fecha_Programado" DataType="System.String" HeaderText="Fecha Programado"
                                    SortExpression="Fecha_Programado" UniqueName="Fecha_Programado">
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                </telerik:GridBoundColumn>				            

                                <telerik:GridBoundColumn DataField="ReProgramado" HeaderText="RPRG" SortExpression="ReProgramado" UniqueName="ReProgramado" >
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                </telerik:GridBoundColumn> 

                                <telerik:GridBoundColumn DataField="Fecha_ReProgramado" DataType="System.String" HeaderText="Fecha ReProgramado"
                                     SortExpression="Fecha_ReProgramado" UniqueName="Fecha_ReProgramado" >
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                </telerik:GridBoundColumn>	

                                <telerik:GridBoundColumn DataField="Atendido" HeaderText="ATE" SortExpression="Atendido" UniqueName="Atendido"  >
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                </telerik:GridBoundColumn> 

                                <telerik:GridBoundColumn DataField="VFechaAtencion" DataType="System.String" HeaderText="Fecha Atención"
                                    SortExpression="VFechaAtencion" UniqueName="VFechaAtencion">
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                </telerik:GridBoundColumn>	

                                <telerik:GridBoundColumn DataField="TipoEntregaReprogramacion" DataType="System.String" HeaderText="Tipo Reprogramación"
                                        SortExpression="TipoEntregaReprogramacion" UniqueName="TipoEntregaReprogramacion">
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
                            HideStructureColumns="True" filename ="Estados" ExportOnlyData="True" IgnorePaging="True" OpenInNewWindow="True">
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
        <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server" 
            DefaultLoadingPanelID="LoadingPanel2">
            <AjaxSettings>
                <telerik:AjaxSetting AjaxControlID="btn_actualizar">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="pnl_buscar" UpdatePanelCssClass="" />
                        <telerik:AjaxUpdatedControl ControlID="Rg_Listado" UpdatePanelCssClass="" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="btn_buscar">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="pnl_buscar" UpdatePanelCssClass="" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="btn_Procesar">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="pnl_buscar" UpdatePanelCssClass="" />
                        <telerik:AjaxUpdatedControl ControlID="Rg_Listado" UpdatePanelCssClass="" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="btn_limpiar">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="pnl_buscar" UpdatePanelCssClass="" />
                        <telerik:AjaxUpdatedControl ControlID="Rg_Listado" UpdatePanelCssClass="" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="ddl_regional">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="ddl_Lugar_Entrega" 
                            UpdatePanelCssClass="" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
            </AjaxSettings>
        </telerik:RadAjaxManager>
    </telerik:RadAjaxLoadingPanel>
</asp:Content>

