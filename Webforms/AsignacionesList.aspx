<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="AsignacionesList.aspx.vb" Inherits="WebForms_AsignacionesList" %>
<%@ Register Src="../Controles/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 15%;
        }
        .style2
        {
            width: 20%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel runat="server" ID="pnl_principal" DefaultButton ="btn_Procesar" Width ="100%">
     <table id="tbl_Interna" border="0" cellpadding="1" cellspacing="0" width="100%" 
            style="border-right: whitesmoke thin solid; border-top: whitesmoke thin solid; border-left: whitesmoke thin solid; border-bottom: whitesmoke thin solid">
        <tr valign ="top">
        <td style="width: 80%;"> 
            <asp:Label ID="Label3" runat="server" 
                Text="VISTA GENERAL DE  ELEGIBILIDAD Y ASIGNACION DE DECLARANTES (Pendientes - Todos)" 
                Width="100%" CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
            <asp:Label ID="Label4" runat="server" CssClass="TitMensaje" Text="_" Width="100%" Visible="False"></asp:Label></td>
        <td style="width: 20%" align="right">
            <asp:ImageButton ID="Btn_Excel" runat="server" 
                ImageUrl="~/Images/Excel-icon.png" ToolTip="Exportar a Excel Alterno" 
                TabIndex="1" PostBackUrl="~/Webforms/AsignacionesExcel.aspx" />
            <asp:ImageButton ID="btn_actualizar" runat="server" 
                ImageUrl="~/Images/Reload.jpg" TabIndex="1" 
                ToolTip="Actualizar la vista actual." />
            <asp:ImageButton ID="btn_buscar" runat="server" ImageUrl="~/Images/Zoom In.jpg" ToolTip="Ver/quitar Sistema de Búsqueda." TabIndex="2" />
            <asp:ImageButton ID="btn_cerrar" runat="server" ImageUrl="~/Images/Stop.jpg" ToolTip="Cerrar - Volver a la vista anterior." TabIndex="4" />
            <asp:ImageButton ID="btn_home" runat="server" ImageUrl="~/Images/Home.jpg" ToolTip="Ir al Inicio." TabIndex="5" />&nbsp;</td>
        </tr>
        <tr valign ="top">
            <td colspan="2" align="center" >
                <asp:Panel ID="pnl_buscar" runat="server" Width="100%" HorizontalAlign="Center" Visible="False">
                        <table border="0" cellpadding="0" cellspacing="0" 
                            style="width: 100%; text-align: left; padding-left: 10px;">
                            <tr valign ="top">
                                <td colspan="5" style="text-align: left; vertical-align: middle;" >
                                    <asp:Label ID="Label6" runat="server" Text="Sistema de Búsqueda Selectiva" Width="90%" Font-Bold="True" Font-Underline="False"></asp:Label></td>
                                <td style="width: 20%" align="right">
                                    <asp:ImageButton ID="btn_Procesar" runat="server" ImageUrl="~/Images/Search.jpg" ToolTip="Realizar la Búsqueda." TabIndex="5" />
                                    <asp:ImageButton ID="btn_limpiar" runat="server" ImageUrl="~/Images/New.jpg" ToolTip="Limpiar Campos Búsqueda." TabIndex="6" /></td>
                            </tr>
                            <tr valign="top">
                                <td style="width: 13%; vertical-align: middle;">
                                    <asp:Label ID="Label44" runat="server" Text="Regional" Width="94%"></asp:Label>
                                </td>
                                <td style="width: 20%; vertical-align: middle;">
                                    <asp:DropDownList ID="ddl_regional" runat="server" Font-Size="X-Small" 
                                        TabIndex="3" Width="90%" AutoPostBack="True">
                                    </asp:DropDownList>
                                </td>
                                <td style="width: 13%; vertical-align: middle;">
                                    <asp:Label ID="Label1" runat="server" Text="Identificación" Width="90%"></asp:Label></td>
                                <td style="width: 20%; vertical-align: middle;">
                                    <asp:TextBox ID="txt_identificacion" runat="server" Font-Size="X-Small" 
                                        Width="90%" TabIndex="1" MaxLength="50"></asp:TextBox></td>
                                <td style="width: 13%; vertical-align: middle;">
                                    <asp:Label ID="Label5" runat="server" Text="Nombre" Width="94%"></asp:Label>
                                </td>
                                <td style="width: 20%; vertical-align: middle;">
                                    <asp:TextBox ID="txt_nombre" runat="server" Font-Size="X-Small" TabIndex="4" 
                                        Width="90%" MaxLength="50"></asp:TextBox>
                                </td>
                            </tr>
                            <tr valign="top">
                                <td style="width: 13%; vertical-align: middle;">
                                    <asp:Label ID="lbl_Programa" runat="server" Text="Programas Libres" Width="94%"></asp:Label>
                                </td>
                                <td style="width: 20%; vertical-align: middle;">
                                    <asp:DropDownList ID="ddl_programa" runat="server" Font-Size="X-Small" 
                                        TabIndex="3" Width="90%">
                                    </asp:DropDownList>
                                </td>
                                <td align="center" bgcolor="#FF9933" colspan="2" 
                                    style="width: 33%; vertical-align: middle;">
                                    <asp:Label ID="Label47" runat="server" Text="Fechas de Radicación" 
                                        Width="100%"></asp:Label>
                                </td>
                                <td style="width: 13%">
                                    <asp:Label ID="Label22" runat="server" Text="Lugar de Fuente" Width="94%"></asp:Label></td>
                                <td style="width: 20%; vertical-align: middle;">
                                    <asp:dropdownlist ID="ddl_LugarFuente" runat="server" Width="90%" 
                                        Font-Size="X-Small" TabIndex="5">
                                    </asp:dropdownlist></td>
                            </tr>
                                <tr valign="top">
                                    <td class="style1" style="width: 13%; vertical-align: middle;">
                                        <asp:Label ID="Label21" runat="server" Text="Tipo Declarante" Width="94%"></asp:Label>
                                    </td>
                                    <td class="style2" style="width: 20%; vertical-align: middle;">
                                        <asp:DropDownList ID="ddl_tipodeclarante" runat="server" Font-Size="X-Small" 
                                            TabIndex="7" Width="90%">
                                        </asp:DropDownList>
                                    </td>
                                    <td class="style1" style="width: 13%; vertical-align: middle;">
                                        <asp:Label ID="Label8" runat="server" Text="Fecha Inicial " Width="94%"></asp:Label>
                                    </td>
                                    <td class="style1" style="width: 20%; vertical-align: middle;">
                                        <telerik:RadDatePicker ID="rdpfechaInicialProgramacion" runat="server" 
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
                                    <td class="style1" style="width: 13%; vertical-align: middle;">
                                        <asp:Label ID="Label20" runat="server" Text="Horario" Width="90%"></asp:Label>
                                        </td>
                                    <td class="style2" style="width: 20%; vertical-align: middle;">
                                        <asp:RadioButtonList ID="rdb_Horario" runat="server" Font-Size="XX-Small" 
                                            RepeatDirection="Horizontal" RepeatLayout="Flow" TabIndex="6" Width="94%">
                                            <asp:ListItem Value="TO">Todos</asp:ListItem>
                                            <asp:ListItem>AM</asp:ListItem>
                                            <asp:ListItem>PM</asp:ListItem>
                                            <asp:ListItem>TD</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </td>
                                </tr>                            
                            
                            <tr valign="top">
                                <td style="width: 13%; vertical-align: middle;">
                                    <asp:Label ID="Label7" runat="server" Text="Fuente" Width="90%"></asp:Label>
                                </td>
                                <td style="width: 20%; vertical-align: middle;">
                                    <asp:DropDownList ID="ddl_Fuente" runat="server" Font-Size="X-Small" 
                                        TabIndex="2" Width="90%">
                                    </asp:DropDownList>
                                </td>
                                <td style="width: 13%; vertical-align: middle;">
                                    <asp:Label ID="Label9" runat="server" Height="16px" 
                                        Text="Fecha Final " Width="94%"></asp:Label>
                                </td>
                                <td style="width: 20%; vertical-align: middle;">
                                    <telerik:RadDatePicker ID="rdpfechaFinalProgramacion" runat="server" 
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
                                <td style="width: 13%; vertical-align: middle;">
                                    <asp:CheckBox ID="chb_Pendiente" runat="server" Text="Pendientes" Checked="True" />
                                </td>
                                <td style="width: 20%; vertical-align: middle;">
                                    <asp:CheckBox ID="chb_todosgrupos" runat="server" AutoPostBack="True" Text="Habilitar Todos los Grupos" />
                                </td>
                            </tr>
                        </table>
                        
                        </asp:Panel>
            </td>
        </tr>
        <tr valign ="top">
            <td colspan="2">					
				<telerik:RadGrid ID="Rg_Listado" runat="server" AllowSorting="True"  PageSize="20" CellSpacing="0"
                    GridLines="None" Skin="WebBlue" Width="100%"  AutoGenerateColumns="False" ShowStatusBar="True" TabIndex="6" >
                    <MasterTableView  NoDetailRecordsText="No hay informaci&#243;n."  NoMasterRecordsText="No hay informaci&#243;n." DataKeyNames="Id" 
                        CommandItemDisplay ="Top" AllowPaging="True">
                        <Columns>
                           <telerik:GridTemplateColumn HeaderText="No." DefaultInsertValue="" UniqueName="TemplateColumn">
                                <ItemTemplate>
                                    <asp:label runat="server" id="lblno" text='<%# ctype(CType(Container.Parent.Parent.Parent,RadGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>' ToolTip ='<%#Container.DataItem.Id%>' />
                                    <asp:Label runat="Server" Id="lblid" Visible ="False" Text ='<%#Container.DataItem.Id%>'/>
                                </ItemTemplate>
                            </telerik:GridTemplateColumn>                                
                        
                            <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" HeaderText="Id" 
                                SortExpression="Id" UniqueName="Id"  Display ="False" >
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
                            					       
						    <telerik:GridBoundColumn DataField="Horario" HeaderText="HOR"  HeaderTooltip ="Horario"
                                SortExpression="Horario" UniqueName="Horario" >
                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn>                                 

						    <telerik:GridBoundColumn DataField="Declarante" HeaderText="TD"  HeaderTooltip ="Declarante"
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
						
						    <telerik:GridBoundColumn DataField="Personas_Declarante.Celular.Descripcion" HeaderText="Celular"  
                                SortExpression="Personas_Declarante.Celular.Descripcion" UniqueName="Personas_Declarante.Celular.Descripcion" >
                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn> 					                        

						    <telerik:GridBoundColumn DataField="Personas_Declarante.Telefono.Descripcion" HeaderText="Telefono"  
                                SortExpression="Personas_Declarante.Telefono.Descripcion" UniqueName="Personas_Declarante.Telefono.Descripcion" >
                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn> 

						    <telerik:GridBoundColumn DataField="TipoFamiliaxaEmpacar" HeaderText="TFE" HeaderTooltip ="Tipo de Familia x Empacar"  
                                SortExpression="TipoFamiliaxaEmpacar" UniqueName="TipoFamiliaxaEmpacar" >
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
                    
                     <ExportSettings Excel-Format ="Biff"
                       HideStructureColumns="True" filename ="Asignaciones" ExportOnlyData="True" IgnorePaging="True" OpenInNewWindow="True">
                         <Pdf PageWidth="" >
                         </Pdf>
                         <Excel Format = "Biff" />
                    </ExportSettings>
                    <SortingSettings SortToolTip="Clic aqui para ordenar..."  SortedAscToolTip ="Ordenar Ascendente" SortedDescToolTip ="Ordenar Descendente" />
                    <PagerStyle Mode="NumericPages" AlwaysVisible="True"    />
                
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
                        <telerik:AjaxUpdatedControl ControlID="lbl_Programa" UpdatePanelCssClass="" />
                        <telerik:AjaxUpdatedControl ControlID="ddl_programa" 
                            UpdatePanelCssClass="" />
                        <telerik:AjaxUpdatedControl ControlID="ddl_LugarFuente" />
                        <telerik:AjaxUpdatedControl ControlID="chb_todosgrupos" 
                            UpdatePanelCssClass="" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="chb_todosgrupos">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="lbl_Programa" UpdatePanelCssClass="" />
                        <telerik:AjaxUpdatedControl ControlID="ddl_programa" UpdatePanelCssClass="" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
            </AjaxSettings>
        </telerik:RadAjaxManager>
    </telerik:RadAjaxLoadingPanel>
</asp:Content>

