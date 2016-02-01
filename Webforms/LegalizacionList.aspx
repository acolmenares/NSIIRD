<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="LegalizacionList.aspx.vb" Inherits="WebForms_LegalizacionList" %>
<%@ Register Src="../Controles/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="ENTREGA" style="color: #FF0000; text-align: left" />
    <asp:Panel runat="server" ID="pnl_principal" DefaultButton ="btn_Procesar" Width ="1000px">
         <table id="tbl_Interna" border="0" cellpadding="1" cellspacing="0" width="1000px" 
                style="border-right: whitesmoke thin solid; border-top: whitesmoke thin solid; border-left: whitesmoke thin solid; border-bottom: whitesmoke thin solid">
            <tr valign ="top">
                <td style="width: 80%;"> 
                    <asp:Label ID="Label3" runat="server" 
                        Text="VISTA GENERAL DE LEGALIZACION DE PLANILLAS DE PROGRAMACION" Width="100%" CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
                    <asp:Label ID="lbl_mensaje" runat="server" CssClass="TitMensaje" Text="_" Width="100%" Visible="False"></asp:Label>
                </td>
                <td style="width: 20%" align="right">
                    <asp:ImageButton ID="btn_actualizar" runat="server" ImageUrl="~/Images/Reload.jpg" TabIndex="1" ToolTip="Actualizar la vista actual." />
                    <asp:ImageButton ID="btn_buscar" runat="server" ImageUrl="~/Images/Zoom In.jpg" ToolTip="Ver/quitar Sistema de Búsqueda." TabIndex="2" />
                    <asp:ImageButton ID="btn_cerrar" runat="server" ImageUrl="~/Images/Stop.jpg" ToolTip="Cerrar - Volver a la vista anterior." TabIndex="4" />
                    <asp:ImageButton ID="btn_home" runat="server" ImageUrl="~/Images/Home.jpg" ToolTip="Ir al Inicio." TabIndex="5" />
                </td>
            </tr>
            <tr valign ="top">
                <td colspan="2" align="center" >
                    <asp:Panel ID="pnl_buscar" runat="server" Width="100%" HorizontalAlign="Center" Visible="False">
                        <table border="0" cellpadding="0" cellspacing="0" style="width: 1000px; text-align: left;">
                            <tr valign ="top">
                                <td colspan="5" style="text-align: left; width: 80%;" >
                                    <asp:Label ID="Label6" runat="server" Text="Sistema de Búsqueda Selectiva" Width="90%" Font-Bold="True" Font-Underline="False"></asp:Label></td>
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
                                    <asp:DropDownList ID="ddl_LugarEntrega" runat="server" Font-Size="X-Small" 
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
				    <telerik:RadGrid ID="Rg_Programas" runat="server" AllowSorting="True" 
                        Skin="WebBlue" Width="100%"  
                        AutoGenerateColumns="False" ShowStatusBar="True" TabIndex="6" 
                        PageSize="20" ResolvedRenderMode="Classic">
                        <MasterTableView  NoDetailRecordsText="No hay informaci&#243;n." NoMasterRecordsText="No hay informaci&#243;n." DataKeyNames="Id" CommandItemDisplay ="Top" AllowPaging="True">
                            <Columns>
                                <telerik:GridTemplateColumn HeaderText="No." DefaultInsertValue="" UniqueName="TemplateColumn">
                                    <ItemTemplate>
                                        <asp:label runat="server" id="lblno" text='<%# ctype(CType(Container.Parent.Parent.Parent,RadGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>' ToolTip = '<%#Container.DataItem.Id%>'/>
                                        <asp:Label runat="Server" Id="lblid" Visible ="False" Text ='<%#Container.DataItem.Id%>'/>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>                                
                        
                                <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" HeaderText="Id" ReadOnly="True"
                                    SortExpression="Id" UniqueName="Id" Display ="False" >
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
                        MultiPageID ="RadMultiPage1" Skin="WebBlue" SelectedIndex="0" 
                        ResolvedRenderMode="Classic">
                        <Tabs>
                            <telerik:RadTab runat="server" Text="Beneficiarios de Planilla" 
                                SelectedIndex="0" PageViewID="PageView1" Owner="RadTabStrip1" 
                                Selected="True" >
                            </telerik:RadTab>
                            <telerik:RadTab runat="server" Text="Detalle de Entregas" SelectedIndex="1"   Owner="RadTabStrip1"
                                PageViewID="PageView3"  >
                            </telerik:RadTab>
                            <telerik:RadTab runat="server" Text="Entrega Manual" SelectedIndex="2"   Owner="RadTabStrip1"
                                PageViewID="PageView2">
                            </telerik:RadTab>
                            <telerik:RadTab runat="server" Text="Resumen Legalización" SelectedIndex="3">
                            </telerik:RadTab>
                        </Tabs>
                    </telerik:RadTabStrip>
                    <telerik:RadMultiPage ID="RadMultiPage1" runat="server" 
                        Width="100%" SelectedIndex="0">
                        <telerik:RadPageView ID="PageView1" runat="server" Selected="True"  >
                            <asp:Panel ID="Panel1" runat="server">
                                <asp:Button ID="btn_pasar" runat="server" CssClass="Boton" Text="Pasar Valor" Width="150px" />
                                <asp:Button ID="btn_recargar" runat="server" CssClass="Boton" Text="Recargar" Width="150px" />
                                <asp:Button ID="btn_grabar" runat="server" CssClass="Boton" Text="Grabar Proceso" Width="150px" />
                                <asp:Button ID="btn_Legalizar" runat="server" CssClass="Boton" Text="Legalizar" Width="150px" />
                            </asp:Panel>
                            <telerik:RadGrid ID="Rg_Listado" runat="server" AllowSorting="True" AutoGenerateColumns="False" CellSpacing="0" GridLines="None" 
                                ShowStatusBar="True" Skin="WebBlue" TabIndex="6" Width="100%">
                                <MasterTableView CommandItemDisplay="Top" DataKeyNames="Id" 
                                    NoDetailRecordsText="No hay información."   NoMasterRecordsText="No hay información.">
                                    <GroupByExpressions>
                                        <telerik:GridGroupByExpression>
                                            <SelectFields>
                                                <telerik:GridGroupByField FieldAlias="Personas.Identificacion" FieldName="Personas.Identificacion">
                                                </telerik:GridGroupByField>
                                                <telerik:GridGroupByField FieldName="Personas.NombreCompleto" Headertext="Nombre " FieldAlias="Personas.NombreCompleto"/>
                                                <telerik:GridGroupByField FieldName="Personas.Declaracion.DescripcionGrupo" Headertext="Grupo " FieldAlias="Personas.Declaracion.DescripcionGrupo"/>
                                                
                                            </SelectFields>
                                            <GroupByFields>
                                                <telerik:GridGroupByField FieldName="Personas.Identificacion" Headertext="Declarante "></telerik:GridGroupByField>
                                            </GroupByFields>
                                        </telerik:GridGroupByExpression>
                                    </GroupByExpressions>
                                    <Columns>
                                        <telerik:GridTemplateColumn DefaultInsertValue="" HeaderText="No." UniqueName="TemplateColumn">
                                            <ItemTemplate>
                                                <asp:Label ID="lblno" runat="server" text="<%# ctype(CType(Container.Parent.Parent.Parent,RadGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>"  ToolTip = '<%#Container.DataItem.Id%>'/>
                                                <asp:Label ID="lblid" runat="Server" Text="<%#Container.DataItem.Id%>" Visible="False" />
                                            </ItemTemplate>
                                        </telerik:GridTemplateColumn>
                                                
                                        <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" HeaderText="Id" 
                                            ReadOnly="True" SortExpression="Id" UniqueName="Id" Display ="False">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Personas.Declaracion.Fecha_Valoracion" 
                                            DataFormatString="{0:dd/MMM/yyyy}" DataType="System.DateTime" 
                                            HeaderText="Fecha Declaración" SortExpression="Personas.Declaracion.Fecha_Valoracion" 
                                            UniqueName="Personas.Declaracion.Fecha_Valoracion">
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                Wrap="True" />
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Personas.Identificacion" HeaderText="Identificación" 
                                            HeaderTooltip="Identificación del Declarante" SortExpression="Personas.Identificacion" 
                                            UniqueName="Personas.Identificacion" Display ="false">
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                Wrap="True" />
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Personas.NombreCompleto" HeaderText="Desplazado Declarante" 
                                            HeaderTooltip="Nombre Declarante" SortExpression="Personas.NombreCompleto" 
                                            UniqueName="Personas.NombreCompleto" Display="false">
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                Wrap="True" />
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Personas.Declaracion.DescripcionGrupo" HeaderText="Grupo" SortExpression="Personas.Declaracion.DescripcionGrupo" 
                                            UniqueName="Personas.Declaracion.DescripcionGrupo" Display="false">
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                Wrap="True" />
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Productos.Descripcion" HeaderText="Nombre Producto" 
                                            SortExpression="Productos.Descripcion" UniqueName="Productos.Descripcion">
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                Wrap="True" />
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Cantidad" HeaderText="Cantidad" SortExpression="Cantidad" UniqueName="Cantidad">
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False"  
                                                Wrap="True" />
                                            <HeaderStyle  width="70px" />
                                            <ItemStyle Width="50px" HorizontalAlign ="Right" />
                                        </telerik:GridBoundColumn>
                                                
                                        <telerik:GridBoundColumn DataField="Unidad.Descripcion" HeaderText="Unidad de Medida" 
                                            SortExpression="Unidad.Descripcion" UniqueName="Unidad.Descripcion"><HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                            Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                            Wrap="True" />
                                        </telerik:GridBoundColumn>
                                        <telerik:GridTemplateColumn HeaderText ="Legalizado" >
                                            <ItemTemplate >
                                                <asp:TextBox runat="server" ID="txt_legalizado" Text="<%#Container.DataItem.Cantidad_Legalizada%>" 
                                                    style="text-align: right" Font-Size="X-Small" Width="15px" >
                                                </asp:TextBox>
                                            </ItemTemplate>
                                            <HeaderStyle HorizontalAlign ="Right" width="80px" />
                                            <ItemStyle HorizontalAlign ="Right" width= "80px"/>
                                        </telerik:GridTemplateColumn>
                                                
                                        <telerik:GridBoundColumn DataField="Personas.Declaracion.TipoFamilia" 
                                            HeaderText="TF" HeaderTooltip="Tipo de Familia Real" 
                                            SortExpression="Personas.Declaracion.TipoFamilia" UniqueName="Personas.Declaracion.TipoFamilia"><HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                            Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                            Wrap="True" />
                                        </telerik:GridBoundColumn>
                                    </Columns>
                                    <CommandItemSettings AddNewRecordImageUrl="~/Images/nothing.gif" 
                                        AddNewRecordText="" ExportToCsvText="Exportar a CSV" 
                                        ExportToExcelText="Exportar a Excel" ExportToPdfText="Exportar a PDF" 
                                        ExportToWordText="Exportar a Word" RefreshText="Actualizar" 
                                        ShowAddNewRecordButton="False" ShowExportToExcelButton="True" 
                                        ShowExportToPdfButton="True" ShowExportToWordButton="True" /><PagerStyle AlwaysVisible="True" FirstPageToolTip="Primera" 
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
                            <telerik:RadGrid ID="Rg_Entregas" runat="server" AllowSorting="True" 
                                AutoGenerateColumns="False" CellSpacing="0" GridLines="None" PageSize="20" 
                                ShowStatusBar="True" Skin="WebBlue" TabIndex="6" Width="100%"><MasterTableView AllowPaging="True" CommandItemDisplay="Top" DataKeyNames="Id" 
                                    NoDetailRecordsText="No hay información." NoMasterRecordsText="No hay información.">
                                    <Columns>
                                        <telerik:GridTemplateColumn DefaultInsertValue="" HeaderText="No." UniqueName="TemplateColumn">
                                            <ItemTemplate><asp:Label ID="lblno0" runat="server" text="<%# ctype(CType(Container.Parent.Parent.Parent,RadGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>" />
                                                <asp:Label ID="lblid0" runat="Server" Text="<%#Container.DataItem.Id%>" Visible="False" />
                                            </ItemTemplate>
                                        </telerik:GridTemplateColumn>
                                        <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" HeaderText="Id" ReadOnly="True" SortExpression="Id" UniqueName="Id" Visible="True">
                                        </telerik:GridBoundColumn>
                                            
                                        <telerik:GridBoundColumn DataField="Salidas.Fecha" DataFormatString="{0:dd/MMM/yyyy}" 
                                            DataType="System.DateTime" HeaderText="Fecha Salida" SortExpression="Salidas.Fecha" 
                                            UniqueName="Salidas.Fecha"><HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                Wrap="True" /></telerik:GridBoundColumn><telerik:GridBoundColumn DataField="Salidas.Numero" HeaderText="Número" 
                                            HeaderTooltip="Número de Salida" SortExpression="Salidas.Numero" 
                                            UniqueName="Salidas.Numero"><HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                Wrap="True" /></telerik:GridBoundColumn><telerik:GridBoundColumn DataField="Productos.Descripcion"  HeaderText="Producto" HeaderTooltip="Nombre del Producto" 
                                            SortExpression="Productos.Descripcion" 
                                            UniqueName="Productos.Descripcion"><HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                Wrap="True" /></telerik:GridBoundColumn><telerik:GridBoundColumn DataField="Cantidad" HeaderText="Cantidad" HeaderTooltip="Cantidad de Salida" 
                                            SortExpression="Cantidad" UniqueName="Cantidad">
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                Wrap="True" />
                                            <ItemStyle HorizontalAlign ="Right" />    
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn DataField="Capacidad.Descripcion" HeaderText="Unidad de Medida" 
                                            SortExpression="Capacidad.Descripcion" UniqueName="Capacidad.Descripcion"><HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                Wrap="True" /></telerik:GridBoundColumn></Columns><CommandItemSettings AddNewRecordImageUrl="~/Images/nothing.gif" 
                                        AddNewRecordText="" ExportToCsvText="Exportar a CSV" 
                                        ExportToExcelText="Exportar a Excel" ExportToPdfText="Exportar a PDF" 
                                        ExportToWordText="Exportar a Word" RefreshText="Actualizar" 
                                        ShowAddNewRecordButton="False" ShowExportToExcelButton="True" 
                                        ShowExportToPdfButton="True" ShowExportToWordButton="True" /><PagerStyle AlwaysVisible="True" FirstPageToolTip="Primera" 
                                        LastPageToolTip="Ultima" Mode="NumericPages" NextPagesToolTip="Próximas" 
                                        NextPageToolTip="Próxima" 
                                        PagerTextFormat="Cambiar Página: {4} &amp;nbsp;Página &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;, registros &lt;strong&gt;{2}&lt;/strong&gt; a &lt;strong&gt;{3}&lt;/strong&gt; de &lt;strong&gt;{5}&lt;/strong&gt;." 
                                        PrevPagesToolTip="Anteriores" PrevPageToolTip="Anterior" /></MasterTableView><ClientSettings EnablePostBackOnRowClick="False" EnableRowHoverStyle="True"><Selecting AllowRowSelect="True" /></ClientSettings><ExportSettings ExportOnlyData="True" filename="Salidas_Grupo" 
                                    HideStructureColumns="True" IgnorePaging="True" OpenInNewWindow="True"><Pdf PageWidth=""></Pdf></ExportSettings><SortingSettings SortedAscToolTip="Ordenar Ascendente" 
                                    SortedDescToolTip="Ordenar Descendente" 
                                    SortToolTip="Clic aqui para ordenar..." /><PagerStyle Mode="NumericPages" /></telerik:RadGrid></telerik:RadPageView>
                        <telerik:RadPageView ID="PageView2" runat="server">
                        
                            <table border="0" cellpadding="0" cellspacing="0" style="width: 500px; text-align: left;">
                            <tr valign ="top">
                                <td colspan="2" 
                                    style="width: 100%; background-color: #FF9900; text-align: center;" width="40%">
                                    <asp:Label runat="server" ID="Label7" style="font-weight: 700; color: #000099; font-size: medium" >INGRESO DE NUEVO PRODUCTO</asp:Label>
                                </td>
                            </tr>
                            <tr valign="top">
                                <td width="40%" style="width: 50%">
                                    <asp:Label ID="lbl_declarante" runat="server">Seleccione el Declarante del Grupo</asp:Label>
                                </td>
                                <td width="60%" style="width: 50%;">
                                    <asp:DropDownList ID="ddl_declarantes" runat="server" CssClass="drop01"></asp:DropDownList>
                                    <asp:RegularExpressionValidator ID="rev_declarantes" runat="server" 
                                            ControlToValidate="ddl_declarantes" 
                                            ErrorMessage="Falta Seleccionar el Declarante" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="ENTREGA">*</asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr valign ="top">
                                <td width="40%" style="width: 50%">
                                    <asp:Label runat="server" ID="Label1" >Seleccione el Producto que le va a asignar</asp:Label>
                                </td>
                                <td width="60%" style="width: 50%;">
                                    <asp:DropDownList ID="ddl_productos" runat="server" CssClass="drop01"></asp:DropDownList>
                                    <asp:RegularExpressionValidator ID="rev_Productos" runat="server" 
                                            ControlToValidate="ddl_productos" ErrorMessage="Falta Seleccionar el Producto" 
                                            ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="ENTREGA">*</asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr valign ="top">
                                <td width="40%" style="width: 50%">
                                    <asp:Label runat="server" ID="Label2" >Seleccione el tipo de Unidad</asp:Label>
                                </td>
                                <td width="60%" style="width: 50%;">
                                    <asp:DropDownList ID="ddl_unidad" runat="server" CssClass="drop01"></asp:DropDownList>
                                    <asp:RegularExpressionValidator ID="rev_unidad" runat="server" 
                                            ControlToValidate="ddl_unidad" 
                                            ErrorMessage="Falta Seleccionar el Tipo de Medida" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="ENTREGA">*</asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr valign ="top">
                                <td width="40%" style="width: 50%">
                                    <asp:Label runat="server" ID="Label5" >Cantidad</asp:Label>
                                </td>
                                <td width="60%" class="ControlCell" style="width: 50%">
                                    <asp:TextBox ID="txt_cantidad" runat="server" MaxLength="4"  style="text-align: right" Font-Size="X-Small" ></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfv_cantidad" runat="server" 
                                            ControlToValidate="txt_cantidad" ErrorMessage="Debe Digitar Cantidad" 
                                            ForeColor="Red" ValidationGroup="ENTREGA">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr valign="top">
                                <td width="40%" style="width: 50%">&nbsp;</td>
                                <td class="ControlCell" width="60%" style="width: 50%">
                                    <asp:Label ID="lbl_Id" runat="server" Visible="False"></asp:Label>
                                </td>
                                </tr>
                                <tr valign ="top">
                                <td colspan="2" style="width: 100%"  align="center">
                                    <asp:Button ID="Button1" runat="server" CssClass="Boton" Text="Registrar Nuevo Producto" Width="200px" />
                                </td>
                                </tr>
                            </table>
                        
                                            
                        </telerik:RadPageView>
                        <telerik:RadPageView ID="RadPageView1" runat="server">
                            <telerik:RadGrid ID="Rg_Resumen" runat="server" AllowSorting="True"  ShowFooter ="True"
                                AutoGenerateColumns="False" CellSpacing="0" GridLines="None"  ShowStatusBar="True" Skin="WebBlue" TabIndex="6" Width="100%">
                                <MasterTableView CommandItemDisplay="Top" DataKeyNames="Id" NoDetailRecordsText="No hay información." 
                                    NoMasterRecordsText="No hay información.">
                                    <Columns>
<%--                                        <telerik:GridTemplateColumn DefaultInsertValue="" HeaderText="No." 
                                            UniqueName="TemplateColumn">
                                            <ItemTemplate>
                                                <asp:Label ID="lblid1" runat="Server" Text="<%#Container.DataItem.Id%>"  Visible="True" />
                                            </ItemTemplate>
                                        </telerik:GridTemplateColumn>--%>
                                        <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" HeaderText="Id" 
                                            ReadOnly="True" SortExpression="Id" UniqueName="Id" Visible="True">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="Descripcion" HeaderText="Nombre del Producto" 
                                            HeaderTooltip="Nombre del Producto" SortExpression="Descripcion" 
                                            UniqueName="Descripcion">
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                Wrap="True" />
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="SalManual"  DataFormatString="{0:N1}"
                                            HeaderText="Salida Manual" HeaderTooltip="Salidas Manuales" 
                                            SortExpression="SalManual" UniqueName="SalManual">
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                Wrap="True" />
                                            <ItemStyle HorizontalAlign ="Right" />
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="SalAutomatico" HeaderText="Salida Automatica"  DataFormatString="{0:N1}"
                                            HeaderTooltip="Salidas Automaticas" SortExpression="SalAutomatico" UniqueName="SalAutomatico">
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                Wrap="True" />
                                            <ItemStyle HorizontalAlign ="Right" /> 

                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="SalTotal" DataFormatString="{0:N1}"
                                            HeaderText="Total Salidas" SortExpression="SalTotal" UniqueName="SalTotal">
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                Wrap="True" />
                                                <ItemStyle HorizontalAlign ="Right" />
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Legalizado" DataFormatString="{0:N1}"
                                            HeaderText="Total Legalizado" SortExpression="Legalizado" UniqueName="Legalizado">
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                Wrap="True" />
                                                <ItemStyle HorizontalAlign ="Right" />
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Saldo" DataFormatString="{0:N1}" Aggregate ="Sum"
                                            HeaderText="Saldo Resumen" SortExpression="Saldo" UniqueName="Saldo">
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                Wrap="True" />
                                                <ItemStyle HorizontalAlign ="Right" />
                                                <FooterStyle HorizontalAlign ="Right" />

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
                                <ExportSettings ExportOnlyData="True" filename="Legalizaciones" 
                                    HideStructureColumns="True" IgnorePaging="True" OpenInNewWindow="True">

                                </ExportSettings>
                                <SortingSettings SortedAscToolTip="Ordenar Ascendente" 
                                    SortedDescToolTip="Ordenar Descendente" 
                                    SortToolTip="Clic aqui para ordenar..." />
                                <PagerStyle Mode="NumericPages" />
                            </telerik:RadGrid>

                            <asp:Panel runat="server" ID="pnl_resumen">
                                <asp:Button ID="btn_resumen" runat="server" CssClass="Boton" 
                                    Text="Procesar Resumen" Width="200px" 
                                    ToolTip="Recargar el resumen de productos entregados por grupo de programación" />   
                                <br />
                                <asp:BulletedList ID="BulletedList1" runat="server" style="text-align: left">
                                    <asp:ListItem>Saldos Negativos no permiten legalizar el grupo de programación</asp:ListItem>
                                    <asp:ListItem>Saldos a Favor se consideraran Devoluciones Automáticas</asp:ListItem>
                                    <asp:ListItem>Las Devoluciones Automáticas se generan al cerrar el Grupo de Programación</asp:ListItem>
                                </asp:BulletedList>
                            </asp:Panel>
                        </telerik:RadPageView>
                    </telerik:RadMultiPage>

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
            <telerik:AjaxSetting AjaxControlID="btn_Procesar">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="pnl_buscar" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Rg_Programas" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Rg_Listado" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btn_limpiar">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ddl_regional" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_Grupo" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Rg_Listado" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="lbl_Id" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ddl_regional">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ddl_Grupo" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Rg_Programas">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadTabStrip1" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="RadMultiPage1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btn_recargar">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="Rg_Listado" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Button1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="Rg_Listado" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_declarantes" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_productos" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_unidad" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_cantidad" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="lbl_Id" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Rg_Resumen" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btn_resumen">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="Rg_Resumen" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager> 

</asp:Content>

