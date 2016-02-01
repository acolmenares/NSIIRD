<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="SaludList.aspx.vb" Inherits="WebForms_SaludList" %>
<%@ Register Src="../Controles/Header.ascx" TagName="Header" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel runat="server" ID="pnl_principal" DefaultButton ="btn_actualizar" Width ="100%">
     <table id="tbl_Interna" border="0" cellpadding="1" cellspacing="0" width="1000px" 
            style="border-right: whitesmoke thin solid; border-top: whitesmoke thin solid; border-left: whitesmoke thin solid; border-bottom: whitesmoke thin solid">
        <tr valign ="top">
            <td style="width: 80%;"> 
            <asp:Label ID="Label31" runat="server" 
                Text="VISTA GENERAL DE SALUD" Width="100%" 
                CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
            <asp:Label ID="Label42" runat="server" CssClass="TitMensaje" Text="_" Width="100%" Visible="False"></asp:Label></td>
        <td style="width: 20%" align="right">
            <asp:ImageButton ID="btn_exportar" runat="server" 
                ImageUrl="~/Images/Excel-icon.png" ToolTip="Exportar a Excel Alterno" 
                TabIndex="1" PostBackUrl="~/Webforms/SaludListExcel.aspx" />
            <asp:ImageButton ID="btn_actualizar" runat="server" 
                ImageUrl="~/Images/Reload.jpg" TabIndex="1" 
                ToolTip="Actualizar la vista actual." />
            <asp:ImageButton ID="btn_buscar" runat="server" ImageUrl="~/Images/Zoom In.jpg" ToolTip="Ver/quitar Sistema de Búsqueda." TabIndex="2" />
            <asp:ImageButton ID="btn_nuevo" runat="server" ImageUrl="~/Images/Add.jpg" ToolTip="Crear Nuevo Registro." TabIndex="3" />
            <asp:ImageButton ID="btn_cerrar" runat="server" ImageUrl="~/Images/Stop.jpg" ToolTip="Cerrar - Volver a la vista anterior." TabIndex="4" />
            <asp:ImageButton ID="btn_home" runat="server" ImageUrl="~/Images/Home.jpg" ToolTip="Ir al Inicio." TabIndex="5" />&nbsp;</td>
        </tr>
            <tr valign="top">
                <td colspan="2" align="center">
                        <asp:Panel ID="pnl_buscar" runat="server" Width="100%" HorizontalAlign="Center" 
                            Visible="False">
                            <table border="0" cellpadding="0" cellspacing="0" style="width: 100%; text-align: left;">
                            <tr valign="top">
                                <td align="left" colspan="5" style="text-align: left; width: 85%;">
                                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Underline="False" 
                                        Text="Sistema de Búsqueda Selectiva" Width="90%"></asp:Label>
                                </td>
                                <td align="right" style="width: 15%">
                                    <asp:ImageButton ID="btn_Procesar" runat="server" ImageUrl="~/Images/Search.jpg" TabIndex="6" ToolTip="Realizar la Búsqueda." />
                                    <asp:ImageButton ID="btn_limpiar" runat="server" ImageUrl="~/Images/New.jpg" TabIndex="7" ToolTip="Limpiar Campos Búsqueda." />
                                </td>
                            </tr> 
                            <tr valign="top">
                                <td style="width: 15%; vertical-align: middle;" rowspan="4">
                                    <asp:Label ID="Label2" runat="server" Text="Seleccione Grupo o Grupos (Manten Presionado CTRL para seleccionar más de 1)"
                                        Width="94%"></asp:Label></td>
                                <td style="width: 15%" rowspan="4">
                                    <asp:ListBox ID="Lst_grupos" runat="server" Font-Size="X-Small" Rows="6" SelectionMode="Multiple"
                                        Width="94%"></asp:ListBox></td>
                                <td style="width: 15%">
                                    <asp:Label ID="Label1" runat="server" Text="Identificación" Width="94%"></asp:Label></td>
                                <td style="width: 16%">
                                    <asp:TextBox ID="txt_identificacion" runat="server" Font-Size="X-Small" Width="90%"></asp:TextBox></td>
                                <td style="width: 15%">
                                    <asp:Label ID="Label43" runat="server" Text="Programa" Width="94%"></asp:Label>
                                    </td>
                                <td style="width: 15%">
                                    <asp:DropDownList ID="ddl_programas" runat="server" Font-Size="X-Small" Width="90%">
                                    </asp:DropDownList>
                                    </td>
                            </tr>
                            <tr valign="top">
                                <td style="width: 15%">
                                    <asp:Label ID="Label5" runat="server" Text="Nombre(s) / Apellido(s)" Width="94%"></asp:Label></td>
                                <td style="width: 16%">
                                    <asp:TextBox ID="txt_nombre" runat="server" Font-Size="X-Small" Width="90%"></asp:TextBox></td>
                                <td style="width: 15%">
                                    <asp:Label ID="Label11" runat="server" Text="Tipo Declaración" Width="94%"></asp:Label></td>
                                <td style="width: 15%">
                                    <asp:dropdownlist ID="ddl_TipoDeclaracion" runat="server" Width="90%" 
                                        Font-Size="X-Small">
                                    </asp:dropdownlist></td>
                            </tr>
                            <tr valign="top">
                                <td style="width: 15%">
                                    <asp:Label ID="Label10" runat="server" Text="Fecha Inicial Entrega" Width="94%"></asp:Label></td>
                                <td style="width: 16%">
                                    <telerik:RadDatePicker ID="rdpFechaInicial" runat="server" 
                                        Culture="Spanish (Colombia)" MinDate="" Skin="WebBlue" 
                                        ToolTip="Seleccione Fecha ..." Width="95%">
                                        <Calendar Skin="WebBlue" UseColumnHeadersAsSelectors="False" 
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
                                    <asp:Label ID="Label4" runat="server" Text="Regional" Width="94%"></asp:Label></td>
                                <td style="width: 15%">
                                    <asp:dropdownlist ID="ddl_regional" runat="server" Width="90%" 
                                        Font-Size="X-Small">
                                    </asp:dropdownlist></td>
                            </tr>
                            <tr valign="top">
                                <td style="width: 15%">
                                    <asp:Label ID="Label12" runat="server" Text="Fecha Final Entrega" Width="94%"></asp:Label></td>
                                <td style="width: 16%">
                                    <telerik:RadDatePicker ID="rdpFechaFinal" runat="server" 
                                        Culture="Spanish (Colombia)" MinDate="" Skin="WebBlue" 
                                        ToolTip="Seleccione Fecha ..." Width="95%">
                                        <Calendar Skin="WebBlue" UseColumnHeadersAsSelectors="False" 
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
                                    <asp:Label ID="Label6" runat="server" Text="Lugar de Entrega" Width="94%"></asp:Label></td>
                                <td style="width: 15%">
                                    <asp:dropdownlist ID="ddl_LugarEntrega" runat="server" Width="90%" 
                                        Font-Size="X-Small">
                                </asp:DropDownList></td>
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
                                <asp:label runat="server" id="lblno" text='<%# ctype(CType(Container.Parent.Parent.Parent,RadGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>' />
                                <asp:Label runat="Server" Id="lblid" Visible ="False" Text ='<%#Container.DataItem.Id%>'/>
                            </ItemTemplate>
                        </telerik:GridTemplateColumn>                                
                        
                        <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" HeaderText="Id" ReadOnly="True"
                            SortExpression="Id" UniqueName="Id"  Visible ="True" >
                        </telerik:GridBoundColumn>
			            
                        <telerik:GridBoundColumn DataField="Declaracion.Fecha_Valoracion" DataType="System.DateTime" HeaderText="Fecha"
                            DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Declaracion.Fecha_Valoracion" UniqueName="Declaracion.Fecha_Valoracion">
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>	

                        <telerik:GridBoundColumn DataField="Declaracion.SubTablasGrupo.Descripcion" HeaderText="Grupo"
                            SortExpression="Declaracion.SubTablasGrupo.Descripcion" UniqueName="Declaracion.SubTablasGrupo.Descripcion" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>	

                        <telerik:GridBoundColumn DataField="Declaracion.Declarante" HeaderText="T.D."
                            SortExpression="Declaracion.Declarante" UniqueName="Declaracion.Declarante" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>	

                        <telerik:GridBoundColumn DataField="Fecha_Nacimiento" DataType="System.DateTime" HeaderText="Fecha Nacimiento"
                            DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_Nacimiento" UniqueName="Fecha_Nacimiento">
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

                        <telerik:GridTemplateColumn HeaderText ="Años"  >
                        <ItemTemplate >
						    <asp:Label runat="server" ID="lbl_Fecha_Nacimiento" Visible ="False" Text='<%#ingNovar.Utilidades2.FechaUtil.toStringDDMMYYY(Container.DataItem.Fecha_Nacimiento)%>'></asp:Label>
						    <asp:Label runat="server" ID="lbl_Fecha_Valoracion" Visible ="False" Text='<%#ingNovar.Utilidades2.FechaUtil.toStringDDMMYYY(Container.DataItem.Declaracion.Fecha_Valoracion)%>' ></asp:Label>
							<asp:Label runat="server" ID="lbl_Edad"></asp:Label>
                        </ItemTemplate>
                        </telerik:GridTemplateColumn> 

                        <telerik:GridBoundColumn DataField="Persona_Regimen_Salud_Antes" HeaderText="R.S. Antes"
                            SortExpression="Persona_Regimen_Salud_Antes" UniqueName="Persona_Regimen_Salud_Antes" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

  				            <telerik:GridTemplateColumn HeaderText="V.PE" >
						        <ItemTemplate>
						            <asp:CheckBox ID="chk_valpe" runat="server" Enabled ="False" Checked = '<%#Container.DataItem.primeravaloracion%>' />
						        </ItemTemplate>
					        </telerik:GridTemplateColumn>

					        <telerik:GridTemplateColumn HeaderText="V.SE" >
						        <ItemTemplate>
                                    <asp:CheckBox ID="chk_valse" runat="server" Enabled ="False" Checked = '<%#Container.DataItem.segundavaloracion%>' />
                                </ItemTemplate>
					        </telerik:GridTemplateColumn>

					        <telerik:GridTemplateColumn HeaderText="V.SEG" >
						        <ItemTemplate>
							        <asp:CheckBox ID="chk_valseg" runat="server" Enabled ="False" Checked = '<%#Container.DataItem.seguimientovaloracion%>' />
						        </ItemTemplate>
					        </telerik:GridTemplateColumn>

					        <telerik:GridTemplateColumn HeaderText="# Val" SortExpression="CantidadValoraciones" >
						        <ItemTemplate>
							        <%#Container.DataItem.CantidadValoraciones%>
						        </ItemTemplate>
						        <HeaderStyle HorizontalAlign="Center" />
					        </telerik:GridTemplateColumn>
					            
				          						            
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
                    HideStructureColumns="True" filename ="Salud" ExportOnlyData="True" IgnorePaging="True" OpenInNewWindow="True">
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
</asp:Content>

