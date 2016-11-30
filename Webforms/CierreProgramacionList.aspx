<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="CierreProgramacionList.aspx.vb" Inherits="WebForms_CierreProgramacionList" %>
<%@ Register Src="../Controles/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <asp:Panel runat="server" ID="pnl_principal" DefaultButton ="btn_Procesar" Width ="1000px">
         <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="ENTREGA" style="color: #FF0000; text-align: left" />
         <table id="tbl_Interna" border="0" cellpadding="1" cellspacing="0" width="1000px" 
                style="border-right: whitesmoke thin solid; border-top: whitesmoke thin solid; border-left: whitesmoke thin solid; border-bottom: whitesmoke thin solid">
            <tr valign ="top">
                <td style="width: 80%;"> 
                    <asp:Label ID="Label3" runat="server" 
                        Text="VISTA GENERAL DE CIERRES DE PLANILLAS LEGALIZADAS DE PROGRAMACION" Width="100%" 
                        CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
                    <asp:Label ID="lbl_mensaje" runat="server" CssClass="TitMensaje" Text="_" 
                        Width="100%" Visible="False"></asp:Label></td>
                <td style="width: 20%" align="right">
                    <asp:ImageButton ID="btn_actualizar" runat="server" ImageUrl="~/Images/Reload.jpg" TabIndex="1" ToolTip="Actualizar la vista actual." />
                    &nbsp;<asp:ImageButton ID="btn_buscar" runat="server" ImageUrl="~/Images/Zoom In.jpg" ToolTip="Ver/quitar Sistema de Búsqueda." TabIndex="2" />
                    &nbsp;<asp:ImageButton ID="btn_cerrar" runat="server" ImageUrl="~/Images/Stop.jpg" ToolTip="Cerrar - Volver a la vista anterior." TabIndex="4" />
                    <asp:ImageButton ID="btn_home" runat="server" ImageUrl="~/Images/Home.jpg" ToolTip="Ir al Inicio." TabIndex="5" />
                </td>
            </tr>
            <tr valign ="top">
                <td colspan="2" align="center" >
                    <asp:Panel ID="pnl_buscar" runat="server" Width="100%" HorizontalAlign="Center" Visible="False">
                        <table border="0" cellpadding="0" cellspacing="0" style="width: 1000px; text-align: left;">
                        <tr valign ="top">
                            <td colspan="5" style="width: 80%;" >
                                <asp:Label ID="Label6" runat="server" Text="Sistema de Búsqueda Selectiva" Width="90%" Font-Bold="True" Font-Underline="False"></asp:Label>
                                <asp:Label ID="lbl_Id" runat="server" Visible="False"></asp:Label>
                            </td>
                            <td style="width: 20%" align="right">
                                <asp:ImageButton ID="btn_Procesar" runat="server" ImageUrl="~/Images/Search.jpg" ToolTip="Realizar la Búsqueda." TabIndex="5" />
                                <asp:ImageButton ID="btn_limpiar" runat="server" ImageUrl="~/Images/New.jpg" ToolTip="Limpiar Campos Búsqueda." TabIndex="6" /></td>
                        </tr>
                        <tr valign="top">
                            <td style="width: 15%">
                                <asp:Label ID="Label41" runat="server" style="margin-bottom: 0px" 
                                    Text="Regional" Width="90%"></asp:Label>
                            </td>
                            <td style="width: 20%">
                                <asp:DropDownList ID="ddl_regional" runat="server" Font-Size="X-Small" 
                                    TabIndex="3" Width="90%" AutoPostBack="True">
                                </asp:DropDownList>
                            </td>
                            <td style="width: 15%">
                                <asp:Label ID="Label43" runat="server" Text="Lugar de Entrega" Width="90%"></asp:Label>
                            </td>
                            <td style="width: 15%">
                                <asp:DropDownList ID="ddl_Lugar_Entrega" runat="server" Font-Size="X-Small" 
                                    Width="90%" AutoPostBack="True">
                                </asp:DropDownList>
                            </td>
                            <td style="width: 15%">
                                <asp:Label ID="Label44" runat="server" Text="Grupo" Width="94%"></asp:Label>
                            </td>
                            <td style="width: 20%">
                                <asp:DropDownList ID="ddl_Grupo" runat="server" Font-Size="X-Small" 
                                    TabIndex="5" Width="90%">
                                </asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                        
                    </asp:Panel>
			    </td>
            </tr>
            <tr valign="top">
                <td colspan="2">

				    <telerik:RadGrid ID="Rg_Programas" runat="server" AllowSorting="True" GridLines="None" Skin="WebBlue" Width="100%"  
                        AutoGenerateColumns="False" ShowStatusBar="True" TabIndex="6" PageSize="30" CellSpacing="0">
                        <MasterTableView  NoDetailRecordsText="No hay informaci&#243;n." NoMasterRecordsText="No hay informaci&#243;n." DataKeyNames="Id" CommandItemDisplay ="Top" AllowPaging="True">
                            <Columns>
                               <telerik:GridTemplateColumn HeaderText="No." DefaultInsertValue="" UniqueName="TemplateColumn">
                                    <ItemTemplate>
                                        <asp:label runat="server" id="lblno" text='<%# ctype(CType(Container.Parent.Parent.Parent,RadGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>' ToolTip = '<%#Container.DataItem.Id%>' />
                                        <asp:Label runat="Server" Id="lblid" Visible ="False" Text ='<%#Container.DataItem.Id%>'/>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>                                
                        
                                <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" HeaderText="Id" ReadOnly="True"
                                    SortExpression="Id" UniqueName="ID" Display ="False" >
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
					            						
						        <telerik:GridBoundColumn DataField="Numero" HeaderText="Número"  
                                    SortExpression="Numero" UniqueName="Numero" >
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                </telerik:GridBoundColumn> 	

						        <telerik:GridBoundColumn DataField="Grupo.Descripcion" HeaderText="Grupo"
                                    SortExpression="Grupo.Descripcion" UniqueName="Grupo.Descripcion" >
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
                           HideStructureColumns="True" filename ="Legalizaciones" ExportOnlyData="True" IgnorePaging="True" OpenInNewWindow="True">
                             <Pdf PageWidth="" >
                             </Pdf>
                        </ExportSettings>
                        <SortingSettings SortToolTip="Clic aqui para ordenar..."  SortedAscToolTip ="Ordenar Ascendente" SortedDescToolTip ="Ordenar Descendente" />
                        <PagerStyle Mode="NumericPages"    />
                
                    </telerik:RadGrid>            
            
                </td>
            </tr>
            <tr valign ="top">
                <td colspan="2">
                    <telerik:RadTabStrip ID="RadTabStrip1" runat="server" 
                        MultiPageID ="RadMultiPage1" Skin="Office2007" SelectedIndex="0">
                        <Tabs>
                            <telerik:RadTab runat="server" Text="Familias Y Beneficiarios" 
                                SelectedIndex="0" PageViewID="PageView1" Selected="True" 
                                Owner="RadTabStrip1" >
                            </telerik:RadTab>
                            <telerik:RadTab runat="server" Text="Resumen Legalización Productos" 
                                PageViewID="PageView3">
                            </telerik:RadTab>
                            <telerik:RadTab runat="server" Owner="RadTabStrip1" PageViewID="PageView2" 
                                SelectedIndex="1" Text="Resumen General">
                            </telerik:RadTab>
                        </Tabs>
                    </telerik:RadTabStrip>
                    <telerik:RadMultiPage ID="RadMultiPage1" runat="server" 
                        Width="100%" SelectedIndex="0">
                        <telerik:RadPageView ID="PageView1" runat="server" Selected="True"  >
                            <telerik:RadGrid ID="Rg_Listado" runat="server" AllowSorting="True"  AutoGenerateColumns="False" CellSpacing="0" GridLines="None" PageSize="30" 
                                ShowStatusBar="True" Skin="WebBlue" TabIndex="6" Width="100%">
                                <MasterTableView AllowPaging="True" CommandItemDisplay="Top" DataKeyNames="ID" NoDetailRecordsText="No hay información." NoMasterRecordsText="No hay información.">
                                    <DetailTables>
                                        <telerik:GridTableView DataKeyNames="ID" Name="Beneficiarios" Width="100%" runat="server" NoDetailRecordsText="No hay informaci&#243;n." NoMasterRecordsText="No hay informaci&#243;n." Font-Size="XX-Small"  ShowHeadersWhenNoRecords ="False" >
                                            <Columns>
                                                <telerik:GridBoundColumn SortExpression="Id" HeaderText="Id" HeaderButtonType="TextButton"
                                                    DataField="Id" UniqueName="ID" Visible="False" DefaultInsertValue="">
                                                </telerik:GridBoundColumn>  
                                                <telerik:GridBoundColumn DataField="Identificacion" HeaderText="Identificación" 
                                                    HeaderTooltip="Identificación del Beneficiario" SortExpression="Identificacion" 
                                                    UniqueName="Personas.Identificacion" Display ="false">
                                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                        Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                        Wrap="True" />
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn DataField="NombreCompleto" HeaderText="Nombre del Beneficiario" 
                                                    HeaderTooltip="Nombre Beneficiario" SortExpression="NombreCompleto" 
                                                    UniqueName="NombreCompleto" >
                                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                        Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                        Wrap="True" />
                                                </telerik:GridBoundColumn>   
                                                <telerik:GridBoundColumn DataField="Edad" HeaderText="Edad" 
                                                     SortExpression="Edad" UniqueName="Edad" >
                                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                        Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                        Wrap="True" />
                                                </telerik:GridBoundColumn>                                               
                                                <telerik:GridBoundColumn DataField="ParentescoPersona" HeaderText="Parentesco" 
                                                     SortExpression="ParentescoPersona" UniqueName="ParentescoPersona" >
                                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                        Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                        Wrap="True" />
                                                </telerik:GridBoundColumn> 
                                                <telerik:GridBoundColumn DataField="GeneroPersona" HeaderText="Genero" 
                                                     SortExpression="GeneroPersona" UniqueName="GeneroPersona" >
                                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                        Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                        Wrap="True" />
                                                </telerik:GridBoundColumn> 
                                                                                                  
                                                                                                                                          
                                            </Columns>
                                        <ExpandCollapseColumn Visible="True">
                                        </ExpandCollapseColumn>
                                        </telerik:GridTableView>
                                    </DetailTables>


                                    <Columns>
                                        <telerik:GridTemplateColumn DefaultInsertValue="" HeaderText="No." UniqueName="TemplateColumn">
                                            <ItemTemplate>
                                                <asp:Label ID="lblno" runat="server" text="<%# ctype(CType(Container.Parent.Parent.Parent,RadGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>" />
                                                <asp:Label ID="lblid" runat="Server" Text="<%#Container.DataItem.Id%>" Visible="False" />
                                            </ItemTemplate>
                                            </telerik:GridTemplateColumn>
                                                
                                        <telerik:GridBoundColumn DataField="ID" DataType="System.Int32" HeaderText="Id" 
                                            ReadOnly="True" SortExpression="ID" UniqueName="Id" Display ="False">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="Identificacion" HeaderText="Identificación" 
                                            HeaderTooltip="Identificación del Declarante" SortExpression="Identificacion" 
                                            UniqueName="Personas.Identificacion" Display ="false">
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                Wrap="True" />
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="NombreCompleto" HeaderText="Nombre del Declarante" 
                                            HeaderTooltip="Nombre Declarante" SortExpression="NombreCompleto" 
                                            UniqueName="NombreCompleto" >
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                Wrap="True" />
                                        </telerik:GridBoundColumn>
       
                                        <telerik:GridBoundColumn DataField="Declaracion.TipoFamilia" HeaderText="TFR" HeaderTooltip="Tipo de Familia Real" 
                                            SortExpression="Declaracion.TipoFamilia" UniqueName="Declaracion.TipoFamilia"><HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                            Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                            Wrap="True" />
                                        </telerik:GridBoundColumn>
                                    </Columns>
                                    <CommandItemSettings AddNewRecordImageUrl="~/Images/nothing.gif" 
                                        AddNewRecordText="" ExportToCsvText="Exportar a CSV" 
                                        ExportToExcelText="Exportar a Excel" ExportToPdfText="Exportar a PDF" 
                                        ExportToWordText="Exportar a Word" RefreshText="Actualizar" 
                                        ShowAddNewRecordButton="False" ShowExportToExcelButton="True" 
                                        ShowExportToPdfButton="True" ShowExportToWordButton="True" />
                                    <PagerStyle AlwaysVisible="True" FirstPageToolTip="Primera" 
                                        LastPageToolTip="Ultima" Mode="NumericPages" NextPagesToolTip="Próximas" 
                                        NextPageToolTip="Próxima" 
                                        PagerTextFormat="Cambiar Página: {4} &amp;nbsp;Página &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;, registros &lt;strong&gt;{2}&lt;/strong&gt; a &lt;strong&gt;{3}&lt;/strong&gt; de &lt;strong&gt;{5}&lt;/strong&gt;." 
                                        PrevPagesToolTip="Anteriores" PrevPageToolTip="Anterior" />
                                </MasterTableView>
                                <GroupingSettings ShowUnGroupButton="True" CollapseTooltip="Contraer grupo" ExpandTooltip="Expandir Grupo" />
                                <ClientSettings EnablePostBackOnRowClick="False" EnableRowHoverStyle="True">
                                    <Selecting AllowRowSelect="True" />
                                </ClientSettings>
                                <ExportSettings ExportOnlyData="True" filename="ProductosLegalizacion" 
                                    HideStructureColumns="True" IgnorePaging="True" OpenInNewWindow="True">
                                    <Pdf PageWidth=""></Pdf>
                                </ExportSettings>
                                <SortingSettings SortedAscToolTip="Ordenar Ascendente" 
                                        SortedDescToolTip="Ordenar Descendente" 
                                        SortToolTip="Clic aqui para ordenar..." />
                                <PagerStyle Mode="NumericPages" />
                            </telerik:RadGrid>
                        </telerik:RadPageView>
                        <telerik:RadPageView ID="PageView3" runat="server">
                            <telerik:RadGrid ID="Rg_Resumen" runat="server" AllowSorting="True" 
                                AutoGenerateColumns="False" PageSize="30" 
                                ShowFooter="True" ShowStatusBar="True" Skin="WebBlue" TabIndex="6" 
                                Width="100%" ResolvedRenderMode="Classic">
                                <MasterTableView AllowPaging="True" CommandItemDisplay="Top" DataKeyNames="Id" 
                                    NoDetailRecordsText="No hay información." 
                                    NoMasterRecordsText="No hay información.">
                                    <Columns>
                                        <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" HeaderText="Id" 
                                            ReadOnly="True" SortExpression="Id" UniqueName="Id" Visible="True">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Descripcion" 
                                            HeaderText="Nombre del Producto" HeaderTooltip="Nombre del Producto" 
                                            SortExpression="Descripcion" UniqueName="Descripcion">
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                Wrap="True" />
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="SalManual" DataFormatString="{0:N1}" 
                                            HeaderText="Salida Manual" HeaderTooltip="Salidas Manuales" 
                                            SortExpression="SalManual" UniqueName="SalManual">
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                Wrap="True" />
                                            <ItemStyle HorizontalAlign="Right" />
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="SalAutomatico" DataFormatString="{0:N1}" 
                                            HeaderText="Salida Automática" HeaderTooltip="Salidas Automáticas" 
                                            SortExpression="SalAutomatico" UniqueName="SalAutomatico">
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                Wrap="True" />
                                            <ItemStyle HorizontalAlign="Right" />
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="SalTotal" DataFormatString="{0:N1}" 
                                            HeaderText="Total Salidas" SortExpression="SalTotal" UniqueName="SalTotal">
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                Wrap="True" />
                                            <ItemStyle HorizontalAlign="Right" />
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Legalizado" DataFormatString="{0:N1}" 
                                            HeaderText="Total Legalizado" SortExpression="Legalizado" 
                                            UniqueName="Legalizado">
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                Wrap="True" />
                                            <ItemStyle HorizontalAlign="Right" />
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn Aggregate="Sum" DataField="Saldo" 
                                            DataFormatString="{0:N1}" HeaderText="Saldo Resumen" SortExpression="Saldo" 
                                            UniqueName="Saldo">
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                Wrap="True" />
                                            <ItemStyle HorizontalAlign="Right" />
                                            <FooterStyle HorizontalAlign="Right" />
                                        </telerik:GridBoundColumn>
                                    </Columns>
                                    <CommandItemSettings AddNewRecordImageUrl="~/Images/nothing.gif" 
                                        AddNewRecordText="" ExportToCsvText="Exportar a CSV" 
                                        ExportToExcelText="Exportar a Excel" ExportToPdfText="Exportar a PDF" 
                                        ExportToWordText="Exportar a Word" RefreshText="Actualizar" 
                                        ShowAddNewRecordButton="False" ShowExportToExcelButton="True" 
                                        ShowExportToPdfButton="True" ShowExportToWordButton="True" />
                                    <PagerStyle AlwaysVisible="True" FirstPageToolTip="Primera" 
                                        LastPageToolTip="Ultima" Mode="NumericPages" NextPagesToolTip="Próximas" 
                                        NextPageToolTip="Próxima" 
                                        PagerTextFormat="Cambiar Página: {4} &amp;nbsp;Página &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;, registros &lt;strong&gt;{2}&lt;/strong&gt; a &lt;strong&gt;{3}&lt;/strong&gt; de &lt;strong&gt;{5}&lt;/strong&gt;." 
                                        PrevPagesToolTip="Anteriores" PrevPageToolTip="Anterior" />
                                </MasterTableView>
                                <ClientSettings EnablePostBackOnRowClick="False" EnableRowHoverStyle="True">
                                    <Selecting AllowRowSelect="True" />
                                </ClientSettings>
                                <ExportSettings ExportOnlyData="True" filename="Salidas_Grupo" 
                                    HideStructureColumns="True" IgnorePaging="True" OpenInNewWindow="True">
                                    <Pdf PageWidth="">
                                    </Pdf>
                                </ExportSettings>
                                <SortingSettings SortedAscToolTip="Ordenar Ascendente" 
                                    SortedDescToolTip="Ordenar Descendente" 
                                    SortToolTip="Clic aqui para ordenar..." />
                                <PagerStyle Mode="NumericPages" />
                            </telerik:RadGrid>
                            <asp:Panel runat="server" ID="pnl_botonresumen" HorizontalAlign="Center" 
                                Width="90%" >
                            <asp:Button ID="btn_resumen" runat="server" CssClass="Boton" Text="Procesar Resumen" 
                                ToolTip="Recargar el resumen de productos entregados por grupo de programación" Width="200px" />
                            
                            </asp:Panel>
                        </telerik:RadPageView>
                        <telerik:RadPageView ID="PageView2" runat="server">

                            <asp:Panel ID="Panel1" runat="server" Width="100%" HorizontalAlign="Center">
                                <table style="width:90%;" align="center">
                                    <tr>
                                        <td colspan="6" style="background-color: #FF6600">
                                            <asp:Label ID="Label57" runat="server" 
                                                style="font-weight: 700; text-decoration: underline; font-size: medium" 
                                                Text="Resumen General de Grupo de Programación" Width="90%"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:Label ID="Label58" runat="server" Text="PRIMERA ENTREGA" Width="90%" 
                                                style="font-weight: 700"></asp:Label>
                                        </td>
                                        <td colspan="2">
                                            <asp:Label ID="Label59" runat="server" style="font-weight: 700" 
                                                Text="SEGUNDA ENTREGA " Width="90%"></asp:Label>
                                        </td>
                                        <td colspan="2">
                                            <asp:Label ID="Label63" runat="server" style="font-weight: 700" 
                                                Text="REPROGRAMACIONES" Width="90%"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 17%">
                                            <asp:Label ID="Label45" runat="server" Text="Total Familias " Width="90%"></asp:Label>
                                        </td>
                                        <td style="width: 17%">
                                            <asp:Label ID="lbl_familias" runat="server" Text="0" Width="90%"></asp:Label>
                                        </td>
                                        <td style="width: 17%">
                                            <asp:Label ID="Label60" runat="server" Text="Total Familias " Width="90%"></asp:Label>
                                        </td>
                                        <td style="width: 17%">
                                            <asp:Label ID="lbl_familias_2E" runat="server" Text="0" Width="90%"></asp:Label>
                                        </td>
                                        <td style="width: 17%">
                                            <asp:Label ID="Label62" runat="server" Text="Total Familias " Width="90%"></asp:Label>
                                        </td>
                                        <td style="width: 17%">
                                            <asp:Label ID="lbl_Familias_REP" runat="server" Text="0" Width="90%"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 17%">
                                            <asp:Label ID="Label49" runat="server" Text="Total Beneficiarios" Width="90%"></asp:Label>
                                        </td>
                                        <td style="width: 17%">
                                            <asp:Label ID="lbl_Beneficiarios" runat="server" Text="0" Width="90%"></asp:Label>
                                        </td>
                                        <td style="width: 17%">
                                            <asp:Label ID="Label61" runat="server" Text="Total Beneficiarios" Width="90%"></asp:Label>
                                        </td>
                                        <td style="width: 17%">
                                            <asp:Label ID="lbl_Beneficiarios_2E" runat="server" Text="0" Width="90%"></asp:Label>
                                        </td>
                                        <td style="width: 17%">
                                            <asp:Label ID="lbl_grupo3" runat="server" Text="Total Beneficiarios" Width="90%"></asp:Label>
                                        </td>
                                        <td style="width: 17%">
                                            <asp:Label ID="lbl_Beneficiarios_REP" runat="server" Text="0" Width="90%"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 17%">
                                            <asp:Label ID="lbl_grupo1" runat="server" Text="Grupo Activo" Width="90%"></asp:Label>
                                        </td>
                                        <td style="width: 17%">
                                            <asp:Label ID="lbl_GrupoActivo" runat="server" Text="_" Width="90%"></asp:Label>
                                        </td>
                                        <td style="width: 17%">
                                            &nbsp;</td>
                                        <td style="width: 17%">
                                            &nbsp;</td>
                                        <td style="width: 17%">
                                            &nbsp;</td>
                                        <td style="width: 17%">
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td style="width: 17%; ">
                                            <asp:Label ID="Label46" runat="server" Text="Niños para Salud" Width="90%"></asp:Label>
                                        </td>
                                        <td style="width: 17%; ">
                                            <asp:Label ID="lbl_salud" runat="server" Text="0" Width="90%"></asp:Label>
                                        </td>
                                        <td style="width: 17%; ">
                                            <asp:Label ID="Label51" runat="server" Text="Niños Edad Escolar" Width="90%"></asp:Label>
                                        </td>
                                        <td style="width: 17%; ">
                                            <asp:Label ID="lbl_edadescolar" runat="server" Text="0" Width="90%"></asp:Label>
                                        </td>
                                        <td style="width: 17%; ">
                                            <asp:Label ID="Label55" runat="server" Text="Requiere Devolución" Width="90%"></asp:Label>
                                        </td>
                                        <td style="width: 17%; ">
                                            <asp:Label ID="lbl_devolucion" runat="server" Text="_" Width="90%"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="6">
                                            <asp:BulletedList ID="BulletedList1" runat="server">
                                                <asp:ListItem>Si existe saldo de productos se generara la devolución automática.</asp:ListItem>
                                                <asp:ListItem>Este proceso es irreversible.</asp:ListItem>
                                                <asp:ListItem>Tanto el grupo como el registro de programación quedan cerrados.</asp:ListItem>
                                                <asp:ListItem Selected="True">Por favor revise bien la información antes de cerrar grupo.</asp:ListItem>
                                            </asp:BulletedList>
                                        </td>
                                    </tr>
                                </table>
                                <asp:Button ID="btn_Legalizar" runat="server" CssClass="Boton" 
                                    Text="Cerrar Programación....  (Genera Devolución Automatica)" Width="305px" />
                            </asp:Panel> 
                       </telerik:RadPageView>
                    </telerik:RadMultiPage>
                </td>    
            </tr> 
        </table>

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
            <telerik:AjaxSetting AjaxControlID="btn_Procesar">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="pnl_buscar" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Rg_Programas" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Rg_Listado" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btn_limpiar">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="lbl_Id" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_regional" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_Lugar_Entrega" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_Grupo" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Rg_Listado" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ddl_regional">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ddl_Lugar_Entrega" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_Grupo" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ddl_Lugar_Entrega">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ddl_Grupo" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Rg_Programas">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadTabStrip1" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="RadMultiPage1" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager> 


    </asp:Panel>   
</asp:Content>

