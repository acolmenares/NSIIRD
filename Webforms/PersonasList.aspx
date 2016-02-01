<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="PersonasList.aspx.vb" Inherits="WebForms_PersonasList" %>
<%@ Register Src="../Controles/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script type="text/javascript">
        function ValNumero(fld, e) {
            var strCheck = '012345678 9';
            var whichCode = (window.Event) ? e.which : e.keyCode;
            var key;
            if (e && e.which) {
                e = e
                key = e.which
            }
            else {
                e = event
                key = e.keyCode
            }
            key = String.fromCharCode(key);
            if (strCheck.indexOf(key) == -1) return false; //valida que slo sea numerico o punto
            if (fld.value.indexOf(".") != -1 && key == ".") return false; //valida que slo permita un punto decimal
            if (fld.value == "" && key == ".") return false; //valida que no sea vacio o que no tenga un punto sin nmeros
        }
    </script>
    
    <asp:Panel runat="server" ID="pnl_principal" DefaultButton ="btn_Procesar" Width ="100%">
        <table id="tbl_Interna" border="0" cellpadding="1" cellspacing="0" width="100%" 
            style="border-right: whitesmoke thin solid; border-top: whitesmoke thin solid; border-left: whitesmoke thin solid; border-bottom: whitesmoke thin solid">
            <tr valign ="top">
                <td style="width: 80%;"> 
                    <asp:Label ID="Label31" runat="server" 
                        Text="VISTA GENERAL DE PERSONAS Y CONTACTOS" Width="100%" 
                        CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
                    <asp:Label ID="Label42" runat="server" CssClass="TitMensaje" Text="_" Width="100%" Visible="False"></asp:Label>
                </td>
                <td style="width: 20%" align="right">
                    <asp:ImageButton ID="btn_Exportar" runat="server" 
                    ImageUrl="~/Images/Excel-icon.png" ToolTip="Exportar a Excel Alterno" 
                    TabIndex="1" PostBackUrl="~/Webforms/PersonasExcel.aspx" />
                <asp:ImageButton ID="btn_actualizar" runat="server" 
                    ImageUrl="~/Images/Reload.jpg" TabIndex="1" 
                    ToolTip="Actualizar la vista actual." />
                <asp:ImageButton ID="btn_buscar" runat="server" ImageUrl="~/Images/Zoom In.jpg" ToolTip="Ver/quitar Sistema de Búsqueda." TabIndex="2" />
                <asp:ImageButton ID="btn_cerrar" runat="server" ImageUrl="~/Images/Stop.jpg" ToolTip="Cerrar - Volver a la vista anterior." TabIndex="4" />
                <asp:ImageButton ID="btn_home" runat="server" ImageUrl="~/Images/Home.jpg" ToolTip="Ir al Inicio." TabIndex="5" />&nbsp;</td>
            </tr>
            <tr valign="top">
                <td colspan="2" align="center">

					<asp:Panel ID="pnl_buscar" runat="server" Width="100%" HorizontalAlign="Center" Visible="False">
                        <table border="0" cellpadding="0" cellspacing="0" 
                            style="width: 100%; text-align: left; padding-left: 3px;">
                            <tr valign="top">
                                <td colspan="5" style="text-align: left; width: 85%;" align="left">
                                    <asp:Label ID="Label3" runat="server" Text="Sistema de Búsqueda Selectiva" Width="90%"
                                        Font-Bold="True" Font-Underline="False"></asp:Label></td>
                                <td style="width: 15%" align="right">
                                    <asp:ImageButton ID="btn_Procesar" runat="server" ImageUrl="~/Images/Search.jpg" ToolTip="Realizar la Búsqueda." TabIndex="6" />
                                    <asp:ImageButton ID="btn_limpiar" runat="server" ImageUrl="~/Images/New.jpg" ToolTip="Limpiar Campos Búsqueda." TabIndex="7" /></td>
                            </tr>
                            <tr valign="top">
                                <td style="width: 17%">
                                    <asp:Label ID="Label4" runat="server" Text="Regional" Width="94%"></asp:Label>
                                </td>
                                <td style="width: 17%">
                                    <asp:DropDownList ID="ddl_regional" runat="server" AutoPostBack="True" 
                                        Font-Size="X-Small" Width="90%">
                                    </asp:DropDownList>
                                </td>
                                <td style="width: 17%">
                                    <asp:Label ID="Label1" runat="server" Text="Identificación" Width="94%"></asp:Label></td>
                                <td style="width: 17%">
                                    <asp:TextBox ID="txt_identificacion" runat="server" Font-Size="X-Small" Width="90%"></asp:TextBox></td>
                                <td style="width: 17%">
                                    <asp:Label ID="Label7" runat="server" Text="Fuente" Width="94%"></asp:Label></td>
                                <td style="width: 17%">
                                    <asp:dropdownlist ID="ddl_Fuente" runat="server" Width="90%" 
                                        Font-Size="X-Small">
                                    </asp:dropdownlist></td>
                            </tr>
                            <tr valign="top">
                                <td class="style1">
                                    <asp:Label ID="Label22" runat="server" Text="Lugar Fuente" Width="94%"></asp:Label>
                                </td>
                                <td class="style1">
                                    <asp:DropDownList ID="ddl_LugarEntrega" runat="server" AutoPostBack="True" 
                                        Font-Size="X-Small" Width="90%">
                                    </asp:DropDownList>
                                </td>
                                <td class="style1">
                                    <asp:Label ID="Label5" runat="server" Text="Nombre" Width="94%"></asp:Label></td>
                                <td class="style1">
                                    <asp:TextBox ID="txt_nombre" runat="server" Font-Size="X-Small" Width="90%"></asp:TextBox></td>
                                <td class="style1" colspan="2">
                                    <asp:Label ID="Label20" runat="server" Text="Horario" Width="24%"></asp:Label>
                                    <asp:RadioButtonList ID="rdb_Horario" runat="server" 
                                        RepeatDirection="Horizontal" RepeatLayout="Flow">
                                        <asp:ListItem Value="TO">Todos</asp:ListItem>
                                        <asp:ListItem>AM</asp:ListItem>
                                        <asp:ListItem>PM</asp:ListItem>
                                        <asp:ListItem>TD</asp:ListItem>
                                    </asp:RadioButtonList>
                                </td>
                            </tr>
                            <tr valign="top">
                                <td style="width: 17%">
                                    <asp:Label ID="Label2" runat="server" Text="Grupo" Width="94%"></asp:Label>
                                </td>
                                <td style="width: 17%">
                                    <asp:DropDownList ID="ddl_grupo" runat="server" Font-Size="X-Small" Width="90%">
                                    </asp:DropDownList>
                                </td>
                                <td style="width: 17%">
                                    <asp:Label ID="Label21" runat="server" Text="Tipo Declarante" Width="94%"></asp:Label></td>
                                <td style="width: 17%">
                                    <asp:DropDownList ID="ddl_tipodeclarante" runat="server" Font-Size="X-Small" Width="94%">
                                    </asp:DropDownList>
                                    </td>
                                <td colspan="2">
                                    &nbsp;</td>
                            </tr>
                            <tr valign="top">
                                <td style="background-color: #3366CC;" colspan="2">
                                    <asp:Label ID="Label43" runat="server" 
                                        style="font-weight: 700; text-align: center; color: #FFFF00;" 
                                        Text="Fechas de Desplazamiento" Width="100%"></asp:Label>
                                </td>
                                <td style="background-color: #3366CC;" colspan="2">
                                    <asp:Label ID="Label44" runat="server" 
                                        style="font-weight: 700; color: #FFFF00; text-align: center" Text="Fechas deAtención" 
                                        Width="100%"></asp:Label>
                                </td>
                                <td style="background-color: #3366CC;" colspan="2">
                                    <asp:Label ID="Label45" runat="server" 
                                        style="font-weight: 700; color: #FFFF00; text-align: center" Text="Declaración" 
                                        Width="100%"></asp:Label>
                                </td>
                            </tr>
                            <tr valign="top">
                                <td style="width: 17%">
                                    <asp:Label ID="Label8" runat="server" Text="Fecha Inicial " Width="94%"></asp:Label>
                                </td>
                                <td style="width: 17%">
                                    <telerik:RadDatePicker ID="rdpFechaInicial_desplazamiento" runat="server" 
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
                                <td style="width: 17%">
                                    <asp:Label ID="Label10" runat="server" Text="Fecha Inicial " Width="94%"></asp:Label>
                                </td>
                                <td style="width: 17%">
                                    <telerik:RadDatePicker ID="rdpFechaInicial_Entrega" runat="server" 
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
                                <td style="width: 17%">
                                    <asp:Label ID="Label16" runat="server" Text="Fecha Inicial " Width="94%"></asp:Label>
                                </td>
                                <td style="width: 17%">
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
                                <td style="width: 17%">
                                    <asp:Label ID="Label9" runat="server" Text="Fecha Final " Width="94%"></asp:Label></td>
                                <td style="width: 17%">
                                    <telerik:RadDatePicker ID="rdpFechaFinal_Desplazamiento" runat="server" 
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
                                <td style="width: 17%">
                                    <asp:Label ID="Label12" runat="server" Text="Fecha Final " Width="94%"></asp:Label></td>
                                <td style="width: 17%">
                                    <telerik:RadDatePicker ID="rdpFechaFinal_Entrega" runat="server" 
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
                                <td style="width: 17%">
                                    <asp:Label ID="Label17" runat="server" Text="Fecha Final " Width="94%"></asp:Label></td>
                                <td style="width: 17%">
                                    <telerik:RadDatePicker ID="rdpFechaFinal_Declaracion" runat="server" 
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
                        </table>
                        
                    </asp:Panel>
				</td>
            </tr>
            <tr valign ="top">
                <td colspan="2">
				    <telerik:RadGrid ID="Rg_Listado" runat="server" AllowSorting="True" 
                        GridLines="None" Skin="WebBlue" Width="100%" 
                        AutoGenerateColumns="False" ShowStatusBar="True" TabIndex="6" 
                        PageSize="20" CellSpacing="0">
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
					            
                               <telerik:GridBoundColumn DataField="Tipo" HeaderText="Tipo"
                                    SortExpression="Tipo" UniqueName="Tipo" >
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

                               <telerik:GridBoundColumn DataField="Estudiaba_Actualmente" HeaderText="Est. Actual"
                                    SortExpression="Estudiaba_Actualmente" UniqueName="Estudiaba_Actualmente" >
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                </telerik:GridBoundColumn>

                               <telerik:GridBoundColumn DataField="Persona_Grupo_Etnico" HeaderText="Etnia"
                                    SortExpression="Persona_Grupo_Etnico" UniqueName="Persona_Grupo_Etnico" >
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
                            <Selecting AllowRowSelect ="True"  />
                        </ClientSettings>
                    
                         <ExportSettings
                           HideStructureColumns="True" filename ="Personas" ExportOnlyData="True" IgnorePaging="True" OpenInNewWindow="True">
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

    <telerik:RadAjaxLoadingPanel ID="LoadingPanel2" runat="server" BackgroundPosition="Right" Height="0px" Transparency="50">
        <asp:Image ID="Image1" runat="server" AlternateText="Cargando..." ImageUrl="~/Images/loading.gif" />
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
                          <telerik:AjaxUpdatedControl ControlID="ddl_LugarEntrega" 
                              UpdatePanelCssClass="" />
                          <telerik:AjaxUpdatedControl ControlID="ddl_grupo" UpdatePanelCssClass="" />
                      </UpdatedControls>
                  </telerik:AjaxSetting>
                  <telerik:AjaxSetting AjaxControlID="ddl_LugarEntrega">
                      <UpdatedControls>
                          <telerik:AjaxUpdatedControl ControlID="ddl_grupo" UpdatePanelCssClass="" />
                      </UpdatedControls>
                  </telerik:AjaxSetting>
                  <telerik:AjaxSetting AjaxControlID="rfltMenu">
                      <UpdatedControls>
                          <telerik:AjaxUpdatedControl ControlID="Rg_Listado" UpdatePanelCssClass="" />
                      </UpdatedControls>
                  </telerik:AjaxSetting>
              </AjaxSettings>
          </telerik:RadAjaxManager>
    </telerik:RadAjaxLoadingPanel>
</asp:Content>

