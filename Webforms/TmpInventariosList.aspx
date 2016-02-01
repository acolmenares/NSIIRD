<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="TmpInventariosList.aspx.vb" Inherits="WebForms_TmpInventariosList" %>
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
                Text="VISTA GENERAL DE INVENTARIOS DE BODEGA" Width="100%" 
                CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
            <asp:Label ID="Label42" runat="server" CssClass="TitMensaje" Text="_" Width="100%" Visible="False"></asp:Label></td>
        <td style="width: 20%" align="right">
            <asp:ImageButton ID="btn_exportar" runat="server" 
                ImageUrl="~/Images/Excel-icon.png" ToolTip="Exportar a Excel Alterno" 
                TabIndex="1" />
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

                        <asp:Panel ID="pnl_buscar" runat="server" Width="100%" HorizontalAlign="Center">
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
                                <td style="width: 15%">
                                    <asp:Label ID="Label4" runat="server" Text="Regional" Width="94%"></asp:Label></td>
                                <td style="width: 15%">
                                    <asp:dropdownlist ID="ddl_regional" runat="server" Width="90%" 
                                        Font-Size="X-Small">
                                    </asp:dropdownlist></td>
                                <td style="width: 15%">
                                    <asp:Label ID="Label10" runat="server" Text="Fecha Inicial " Width="94%"></asp:Label></td>
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
                                    <asp:Label ID="Label21" runat="server" Text="Tipo Entrada" Width="94%"></asp:Label></td>
                                <td style="width: 15%"><asp:DropDownList ID="ddl_tipoentrada" runat="server" 
                                        Font-Size="X-Small" Width="90%">
                                </asp:DropDownList></td>
                            </tr>
                            <tr valign="top">
                                <td style="width: 15%">
                                    <asp:Label ID="Label2" runat="server" Text="Bodega" Width="94%"></asp:Label></td>
                                <td style="width: 15%">
                                    <asp:dropdownlist ID="ddl_bodega" runat="server" Width="90%" 
                                        Font-Size="X-Small">
                                </asp:dropdownlist></td>
                                <td style="width: 15%">
                                    <asp:Label ID="Label12" runat="server" Text="Fecha Final" Width="94%"></asp:Label></td>
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
                                    <asp:Label ID="Label5" runat="server" Text="Tipo Salida" Width="94%"></asp:Label></td>
                                <td style="width: 15%"><asp:DropDownList ID="ddl_TipoSalida" runat="server" 
                                        Font-Size="X-Small" Width="90%">
                                </asp:DropDownList></td>
                            </tr>
                        </table>
                        
                        </asp:Panel>
                        <div>						
                            <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Seleccione su modo de ver la información"
                                Width="25%"></asp:Label>
                        <asp:RadioButtonList ID="rdb_vista" runat="server" RepeatDirection="Horizontal" 
                                AutoPostBack="True" Width="33%">
                            <asp:ListItem Value="0" Selected="True">Ver Todo</asp:ListItem>
                            <asp:ListItem Value="1">Totales</asp:ListItem>
                            <asp:ListItem Value="2">Entradas</asp:ListItem>
                            <asp:ListItem Value="3">Salidas</asp:ListItem>
                        </asp:RadioButtonList>
                        </div>
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
                                <asp:label runat="server" id="lblno" text='<%# ctype(CType(Container.Parent.Parent.Parent,RadGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>' />
                                <asp:Label runat="Server" Id="lblid" Visible ="False" Text ='<%#Container.DataItem.Id%>'/>
                            </ItemTemplate>
                        </telerik:GridTemplateColumn>                                
                        
                        <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" HeaderText="Id" ReadOnly="True"
                            SortExpression="Id" UniqueName="Id"  Visible ="True" >
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Regional.Descripcion" HeaderText="Regional"
                            SortExpression="Regional.Descripcion" UniqueName="Regional.Descripcion" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Bodega.Descripcion" HeaderText="Bodega"
                            SortExpression="Bodega.Descripcion" UniqueName="Bodega.Descripcion" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Producto.Descripcion" HeaderText="Producto"
                            SortExpression="Producto.Descripcion" UniqueName="Producto.Descripcion" >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Antes" HeaderText="Antes" DataFormatString = "{0:N1}"
                            SortExpression="Antes" UniqueName="Antes"  >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            <ItemStyle HorizontalAlign ="Right" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Inventario_Inicial" HeaderText="Inv. Inicial"  DataFormatString = "{0:N1}"
                            SortExpression="Inventario_Inicial" UniqueName="Inventario_Inicial"  >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            <ItemStyle HorizontalAlign ="Right" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Compras" HeaderText="Compras"  DataFormatString = "{0:N1}"
                            SortExpression="Compras" UniqueName="Compras"  >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            <ItemStyle HorizontalAlign ="Right" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Devoluciones" HeaderText="Dev. Prv."  DataFormatString = "{0:N1}"
                            SortExpression="Devoluciones" UniqueName="Devoluciones"  >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            <ItemStyle HorizontalAlign ="Right" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Donaciones" HeaderText="Donaciones"  DataFormatString = "{0:N1}"
                            SortExpression="Donaciones" UniqueName="Donaciones"  >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            <ItemStyle HorizontalAlign ="Right" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Traslados_Entradas" HeaderText="Traslados"  DataFormatString = "{0:N1}"
                            SortExpression="Traslados_Entradas" UniqueName="Traslados_Entradas"  >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            <ItemStyle HorizontalAlign ="Right" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Ajustes_Entradas_Aprobadas" HeaderText="Ajustes Apr"  DataFormatString = "{0:N1}"
                            SortExpression="Ajustes_Entradas_Aprobadas" UniqueName="Ajustes_Entradas_Aprobadas"  >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            <ItemStyle HorizontalAlign ="Right" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Ajustes_Entradas_NoAprobadas" HeaderText="Ajustes No Apr"  DataFormatString = "{0:N1}"
                            SortExpression="Ajustes_Entradas_NoAprobadas" UniqueName="Ajustes_Entradas_NoAprobadas"  >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            <ItemStyle HorizontalAlign ="Right" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Entradas_Devoluciones" HeaderText="Ent. Devoluciones"  DataFormatString = "{0:N1}"
                            SortExpression="Entradas_Devoluciones" UniqueName="Entradas_Devoluciones"  >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            <ItemStyle HorizontalAlign ="Right" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Ingresos" HeaderText="Ingresos"  DataFormatString = "{0:N1}"
                            SortExpression="Ingresos" UniqueName="Ingresos"  >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            <ItemStyle HorizontalAlign ="Right" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Salidas_Automaticas" HeaderText="Ent. Aut."  DataFormatString = "{0:N1}"
                            SortExpression="Salidas_Automaticas" UniqueName="Salidas_Automaticas"  >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            <ItemStyle HorizontalAlign ="Right" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Salidas_Manuales" HeaderText="Ent. Man."  DataFormatString = "{0:N1}"
                            SortExpression="Salidas_Manuales" UniqueName="Salidas_Manuales"  >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            <ItemStyle HorizontalAlign ="Right" />
                        </telerik:GridBoundColumn>			            

                        <telerik:GridBoundColumn DataField="Devoluciones_Proveedor" HeaderText="Dev. Prv."  DataFormatString = "{0:N1}"
                            SortExpression="Devoluciones_Proveedor" UniqueName="Devoluciones_Proveedor"  >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            <ItemStyle HorizontalAlign ="Right" />
                        </telerik:GridBoundColumn>	

                        <telerik:GridBoundColumn DataField="Traslados_Salidas" HeaderText="Traslados"  DataFormatString = "{0:N1}"
                            SortExpression="Traslados_Salidas" UniqueName="Traslados_Salidas"  >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            <ItemStyle HorizontalAlign ="Right" />
                        </telerik:GridBoundColumn>	

                        <telerik:GridBoundColumn DataField="Ajustes_Sin_Aprobar" HeaderText="Ajustes SA"  DataFormatString = "{0:N1}"
                            SortExpression="Ajustes_Sin_Aprobar" UniqueName="Ajustes_Sin_Aprobar"  >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            <ItemStyle HorizontalAlign ="Right" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Ajustes_Aprobados" HeaderText="Ajustes Apr"  DataFormatString = "{0:N1}"
                            SortExpression="Ajustes_Aprobados" UniqueName="Ajustes_Aprobados"  >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            <ItemStyle HorizontalAlign ="Right" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Salidas_Donaciones" HeaderText="Sal Don"  DataFormatString = "{0:N1}"
                            SortExpression="Salidas_Donaciones" UniqueName="Salidas_Donaciones"  >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            <ItemStyle HorizontalAlign ="Right" />
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Salidas" HeaderText="Salidas"  DataFormatString = "{0:N1}"
                            SortExpression="Salidas" UniqueName="Salidas"  >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            <ItemStyle HorizontalAlign ="Right" />
                        </telerik:GridBoundColumn>	

                        <telerik:GridBoundColumn DataField="GranTotal" HeaderText="Gran Total"  DataFormatString = "{0:N1}"
                            SortExpression="GranTotal" UniqueName="GranTotal"  >
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            <ItemStyle HorizontalAlign ="Right" />
                        </telerik:GridBoundColumn>	

				    </Columns>
                    <CommandItemSettings ExportToCsvText ="Exportar a CSV" 
                        ExportToExcelText ="Exportar a Excel" ExportToPdfText ="Exportar a PDF"
                            ExportToWordText ="Exportar a Word" RefreshText ="Actualizar" 
                        AddNewRecordText =""  AddNewRecordImageUrl ="~/Images/nothing.gif" ShowExportToExcelButton="True" 
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
                    HideStructureColumns="True" filename ="Inventarios" ExportOnlyData="True" IgnorePaging="True" OpenInNewWindow="True">
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

