<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="Personas_EducacionList.aspx.vb" Inherits="WebForms_Personas_EducacionList" %>
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
    
<asp:Panel runat="server" ID="pnl_principal" DefaultButton ="btn_actualizar" Width ="100%">
     <table id="tbl_Interna" border="0" cellpadding="1" cellspacing="0" width="100%" 
         style="border-right: whitesmoke thin solid; border-top: whitesmoke thin solid; border-left: whitesmoke thin solid; border-bottom: whitesmoke thin solid">
        <tr valign ="top">
            <td style="width: 80%;"> 
                <asp:Label ID="Label31" runat="server" 
                    Text="VISTA GENERAL DE JOVENES EN EDAD ESCOLAR" Width="100%" 
                    CssClass="TitTitulo" BackColor="PeachPuff">
                </asp:Label><br />
                <asp:Label ID="Label42" runat="server" CssClass="TitMensaje" Text="_" Width="100%" Visible="False"></asp:Label>
            </td>
            <td style="width: 20%" align="right">
                <asp:ImageButton ID="btn_excelalterno" runat="server" 
                    ImageUrl="~/Images/Excel-icon.png" ToolTip="Exportar a Excel Alterno" 
                    TabIndex="1" PostBackUrl="~/Webforms/Personas_EducacionExcel.aspx" />
                <asp:ImageButton ID="btn_actualizar" runat="server" 
                    ImageUrl="~/Images/Reload.jpg" TabIndex="1" 
                    ToolTip="Actualizar la vista actual." />
                <asp:ImageButton ID="btn_buscar" runat="server" ImageUrl="~/Images/Zoom In.jpg" ToolTip="Ver/quitar Sistema de Búsqueda." TabIndex="2" />
                <asp:ImageButton ID="btn_cerrar" runat="server" ImageUrl="~/Images/Stop.jpg" ToolTip="Cerrar - Volver a la vista anterior." TabIndex="4" />
                <asp:ImageButton ID="btn_home" runat="server" ImageUrl="~/Images/Home.jpg" ToolTip="Ir al Inicio." TabIndex="5" />
            </td>
        </tr>
        <tr valign="top">
            <td colspan="2" align="center">
                <asp:Panel ID="pnl_buscar" runat="server" Width="100%" HorizontalAlign="Center" 
                    Visible="False">
                    <table border="0" cellpadding="0" cellspacing="0" style="width: 100%; text-align: left;">
                        <tr valign="top">
                            <td colspan="5" style="text-align: left; width: 85%;" align="left">
                                <asp:Label ID="Label3" runat="server" Text="Sistema de Búsqueda Selectiva" Width="90%" Font-Bold="True" Font-Underline="False"></asp:Label>
                            </td>
                            <td style="width: 15%" align="right">
                                <asp:ImageButton ID="btn_Procesar" runat="server" ImageUrl="~/Images/Search.jpg" ToolTip="Realizar la Búsqueda." TabIndex="6" />
                                <asp:ImageButton ID="btn_limpiar" runat="server" ImageUrl="~/Images/New.jpg" ToolTip="Limpiar Campos Búsqueda." TabIndex="7" />
                            </td>
                        </tr>
                        <tr valign="top">
                            <td style="width: 15%">
                                <asp:Label ID="Label4" runat="server" Text="Regional" Width="94%"></asp:Label>
                            </td>
                            <td style="width: 15%">
                                <asp:dropdownlist ID="ddl_regional" runat="server" Width="90%" 
                                    Font-Size="X-Small" AutoPostBack="True">
                                </asp:dropdownlist>
                            </td>
                            <td style="width: 15%">
                                <asp:Label ID="Label10" runat="server" Text="Fecha Inicial Entrega" Width="94%"></asp:Label>
                            </td>
                            <td style="width: 16%">
                                <telerik:RadDatePicker ID="rdpFechaInicial" runat="server" 
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
                            <td style="width: 15%">
                                <asp:Label ID="Label1" runat="server" Text="Identificación" Width="94%"></asp:Label>
                            </td>
                            <td style="width: 15%">
                                <asp:TextBox ID="txt_identificacion" runat="server" Font-Size="X-Small" 
                                    Width="90%" MaxLength="50"></asp:TextBox>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td style="width: 15%">
                                <asp:Label ID="Label6" runat="server" Text="Lugar de Entrega" Width="94%"></asp:Label>
                            </td>
                            <td style="width: 15%">
                                <asp:DropDownList ID="ddl_LugarEntrega" runat="server" AutoPostBack="True" 
                                    Font-Size="X-Small" Width="90%">
                                </asp:DropDownList>
                            </td>
                            <td style="width: 15%">
                                    <asp:Label ID="Label12" runat="server" Text="Fecha Final Entrega" Width="94%"></asp:Label>
                            </td>
                            <td style="width: 16%">
                                    <telerik:RadDatePicker ID="rdpFechaFinal" runat="server" 
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
                            <td style="width: 15%">
                                <asp:Label ID="Label5" runat="server" Text="Nombre / Apellido" Width="94%"></asp:Label>
                            </td>
                            <td style="width: 15%">
                                <asp:TextBox ID="txt_nombre" runat="server" Font-Size="X-Small" Width="90%" MaxLength="50"></asp:TextBox>
                            </td>
                        </tr>
                            <tr valign="top">
                                <td style="width: 15%">
                                    <asp:Label ID="Label2" runat="server" Text="Grupo" Width="94%"></asp:Label>
                                </td>
                                <td style="width: 15%">
                                    <asp:DropDownList ID="ddl_grupo" runat="server" Font-Size="X-Small" Width="90%">
                                    </asp:DropDownList>
                                </td>
                                <td style="width: 15%">
                                    <asp:Label ID="Label21" runat="server" Text="Tipo Declarante" Width="94%"></asp:Label>
                                </td>
                                <td style="width: 16%">
                                    <asp:DropDownList ID="ddl_tipodeclarante" runat="server" Font-Size="X-Small" Width="90%">
                                    </asp:DropDownList>
                                </td>
                                <td style="width: 15%">
                                    <asp:Label ID="Label11" runat="server" Height="19px" Text="Pendientes" Width="94%"></asp:Label>
                                </td>
                                <td style="width: 15%">
                                    <asp:CheckBox ID="chk_pendiente" runat="server" />
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

                            <telerik:GridBoundColumn DataField="Declaracion.Grupo.Descripcion" HeaderText="Grupo"
                                SortExpression="Declaracion.Grupo.Descripcion" UniqueName="Declaracion.Grupo.Descripcion" >
                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn>

                           <telerik:GridBoundColumn DataField="Declaracion.Declarante" HeaderText="T.D."
                                SortExpression="Declaracion.Declarante" UniqueName="Declaracion.Declarante" >
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

                           <telerik:GridBoundColumn DataField="MotivoNoestudiaPrimeraEntrega" HeaderText="Motivo No Est PE"
                                SortExpression="MotivoNoestudiaPrimeraEntrega" UniqueName="MotivoNoestudiaPrimeraEntrega" >
                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                           </telerik:GridBoundColumn>

                           <telerik:GridBoundColumn DataField="Edad" HeaderText="Edad" SortExpression="Edad" UniqueName="Edad" >
                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                           </telerik:GridBoundColumn>
					            
	                        <telerik:GridBoundColumn DataField="EstudiaActualmente_SE" HeaderText="EA SE" HeaderTooltip ="Estudia Actualmente Segunda Entrega"
                                SortExpression="EstudiaActualmente_SE" UniqueName="EstudiaActualmente_SE" >
                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn>

	                        <telerik:GridBoundColumn DataField="Grado_SE" HeaderText="Grado SE"
                                SortExpression="Grado_SE" UniqueName="Grado_SE" >
                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn>

	                        <telerik:GridBoundColumn DataField="Certificado_SE" HeaderText="Cert. SE"
                                SortExpression="Certificado_SE" UniqueName="Certificado_SE" >
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
                    
                     <ExportSettings Excel-Format ="ExcelML" SuppressColumnDataFormatStrings ="true"
                       HideStructureColumns="True" filename ="Educacion" ExportOnlyData="True" IgnorePaging="True" OpenInNewWindow="True">
                         <Pdf PageWidth="" >
                         </Pdf>
                         <Excel Format="ExcelML" />
                    </ExportSettings>
                    <SortingSettings SortToolTip="Clic aqui para ordenar..."  SortedAscToolTip ="Ordenar Ascendente" SortedDescToolTip ="Ordenar Descendente" />
                    <PagerStyle Mode="NumericPages"   AlwaysVisible="True"  />
                
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
                        <telerik:AjaxUpdatedControl ControlID="ddl_LugarEntrega" 
                            UpdatePanelCssClass="" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="ddl_LugarEntrega">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="ddl_grupo" UpdatePanelCssClass="" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
            </AjaxSettings>
        </telerik:RadAjaxManager>
    </telerik:RadAjaxLoadingPanel>
</asp:Content>

