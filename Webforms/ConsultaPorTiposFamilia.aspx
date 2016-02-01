<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="ConsultaPorTiposFamilia.aspx.vb" Inherits="WebForms_ConsultaPorTiposFamilia" %>
<%@ Register Src="../Controles/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel runat="server" ID="pnl_principal" DefaultButton ="btn_actualizar" Width ="100%">
     <table id="tbl_Interna" border="0" cellpadding="1" cellspacing="0" width="95%" 
            style="border-right: whitesmoke thin solid; border-top: whitesmoke thin solid; border-left: whitesmoke thin solid; border-bottom: whitesmoke thin solid">
        <tr valign ="top">
        <td style="width: 80%;"> 
            <asp:Label ID="Label3" runat="server" 
                Text="CONSULTA GENERAL POR TIPOS DE FAMILIA" Width="100%" CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
            <asp:Label ID="Label4" runat="server" CssClass="TitMensaje" Text="_" Width="100%" Visible="False"></asp:Label></td>
        <td style="width: 20%" align="right">
            <asp:ImageButton ID="btn_actualizar" runat="server" ImageUrl="~/Images/Reload.jpg" ToolTip="Actualizar la vista actual." TabIndex="1" />
            <asp:ImageButton ID="btn_buscar" runat="server" ImageUrl="~/Images/Zoom In.jpg" ToolTip="Ver/quitar Sistema de Búsqueda." TabIndex="2" />
            <asp:ImageButton ID="btn_nuevo" runat="server" ImageUrl="~/Images/Add.jpg" ToolTip="Crear Nuevo Registro." TabIndex="3" visble ="False"/>
            <asp:ImageButton ID="btn_cerrar" runat="server" ImageUrl="~/Images/Stop.jpg" ToolTip="Cerrar - Volver a la vista anterior." TabIndex="4" />
            <asp:ImageButton ID="btn_home" runat="server" ImageUrl="~/Images/Home.jpg" ToolTip="Ir al Inicio." TabIndex="5" />&nbsp;</td>
        </tr>
            <tr valign="top">
                <td colspan="2" align="center">
                    <asp:Panel ID="Pnl_Buscar" runat="server" Width="90%" Style="text-align: center;
                        border-right: palegoldenrod thin ridge; border-top: palegoldenrod thin ridge;
                        border-left: palegoldenrod thin ridge; border-bottom: palegoldenrod thin ridge;"
                        Visible="False">
                        <table border="0" cellpadding="0" cellspacing="0" style="width: 100%">
                            <tr valign="top">
                                <td colspan="4" style="text-align: left; width: 85%;" align="left">
                                    <asp:Label ID="Label2" runat="server" Text="Sistema de Búsqueda Selectiva" Width="90%"
                                        Font-Bold="True" Font-Underline="False"></asp:Label></td>
                                <td style="width: 15%" align="right">
                                    <asp:ImageButton ID="btn_Procesar" runat="server" ImageUrl="~/Images/Search.jpg" ToolTip="Realizar la Búsqueda." TabIndex="6" />
                                    <asp:ImageButton ID="btn_limpiar" runat="server" ImageUrl="~/Images/New.jpg" ToolTip="Limpiar Campos Búsqueda." TabIndex="7" /></td>
                            </tr>
                            <tr valign="top">
                                <td style="width: 15%;" align="left">
                                    <asp:Label ID="Label5" runat="server" Font-Bold="False" Text="Fecha Inicial" Width="90%"></asp:Label></td>
                                <td style="width: 15%;" align="left">
                                    <telerik:RadDatePicker ID="rdpFechaInicial" runat="server" Culture="Spanish (Colombia)"
                                        MinDate="" Skin="WebBlue" ToolTip="Seleccione Fecha ..." Width="95%">
                                        <Calendar Skin="WebBlue" UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False"
                                            ViewSelectorText="x">
                                            <FastNavigationSettings CancelButtonCaption="Cancelar" DateIsOutOfRangeMessage="Fecha Fuera de Rango"
                                                TodayButtonCaption="Hoy">
                                            </FastNavigationSettings>
                                        </Calendar>
                                        <DatePopupButton HoverImageUrl="" ImageUrl="" ToolTip="Abrir el Calendario" />
                                        <DateInput DateFormat="dd/MM/yyyy" DisplayDateFormat="dd/MMMM/yyyy" EmptyMessage="Fecha ...">
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
                                <td style="width: 15%;" align="left">
                                    <asp:Label ID="Label8" runat="server" Text="Regional" Width="90%"></asp:Label>
                                </td>
                                <td align="left">
                                    <asp:DropDownList ID="ddl_Regional" runat="server" CssClass="drop01" 
                                        TabIndex="4" />
                                </td>
                                <td style="width: 15%" align="left">
                                    &nbsp;</td>
                            </tr>
                            <tr valign="top">
                                <td style="width: 15%" align="left">
                                    <asp:Label ID="Label9" runat="server" Text="Fecha Final" Width="90%"></asp:Label></td>
                                <td style="width: 15%" align="left">
                                    <telerik:RadDatePicker ID="rdpfechaFinal" runat="server" Culture="Spanish (Colombia)"
                                        MinDate="" Skin="WebBlue" TabIndex="1" ToolTip="Seleccione Fecha ..." 
                                        Width="95%">
                                        <Calendar Skin="WebBlue" UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False"
                                            ViewSelectorText="x">
                                            <FastNavigationSettings CancelButtonCaption="Cancelar" DateIsOutOfRangeMessage="Fecha Fuera de Rango"
                                                TodayButtonCaption="Hoy">
                                            </FastNavigationSettings>
                                        </Calendar>
                                        <DatePopupButton HoverImageUrl="" ImageUrl="" TabIndex="1" ToolTip="Abrir el Calendario" />
                                        <DateInput DateFormat="dd/MM/yyyy" DisplayDateFormat="dd/MMMM/yyyy" EmptyMessage="Fecha ..."
                                            TabIndex="1">
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
                                <td style="width: 15%" align="left">
                                    <asp:Label ID="Label1" runat="server" Text="Grupo" Width="90%"></asp:Label>
                                </td>
                                <td align="left">
                                    <asp:DropDownList ID="ddl_Grupos" runat="server" CssClass="drop01" 
                                        TabIndex="5" />
                                </td>
                                <td style="width: 15%" align="left">
                                    &nbsp;</td>
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
                    PageSize="20" CellSpacing="0" AllowPaging="True">
                    <MasterTableView  NoDetailRecordsText="No hay informaci&#243;n." 
                        NoMasterRecordsText="No hay informaci&#243;n." DataKeyNames="Id" 
                        CommandItemDisplay ="Top">
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
                           
                            <telerik:GridBoundColumn DataField="Descripcion" HeaderText="Grupo"
                                SortExpression="Descripcion" UniqueName="Descripcion" >
                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn>       
                            
                            <telerik:GridBoundColumn DataField="Fecha_Grupo" DataType="System.DateTime" HeaderText="Fecha Atención"
                                DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_Grupo" UniqueName="Fecha_Grupo">
                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn>

                            <telerik:GridBoundColumn DataField="TipoFamilia01" HeaderText="01" SortExpression="TipoFamilia01" UniqueName="TipoFamilia01" DataFormatString="{0:N0}" >
                                 <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn>   
                                                                       
                            <telerik:GridBoundColumn DataField="TipoFamilia02" HeaderText="02" SortExpression="TipoFamilia02" UniqueName="TipoFamilia02" DataFormatString="{0:N0}" >
                                 <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn>  

                            <telerik:GridBoundColumn DataField="TipoFamilia03" HeaderText="03" SortExpression="TipoFamilia03" UniqueName="TipoFamilia03" DataFormatString="{0:N0}" >
                                 <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn>  

                            <telerik:GridBoundColumn DataField="TipoFamilia04" HeaderText="04" SortExpression="TipoFamilia04" UniqueName="TipoFamilia04" DataFormatString="{0:N0}" >
                                 <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn>   
                                                                       
                            <telerik:GridBoundColumn DataField="TipoFamilia05" HeaderText="05" SortExpression="TipoFamilia05" UniqueName="TipoFamilia05" DataFormatString="{0:N0}" >
                                 <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn>  

                            <telerik:GridBoundColumn DataField="TipoFamilia06" HeaderText="06" SortExpression="TipoFamilia06" UniqueName="TipoFamilia06" DataFormatString="{0:N0}" >
                                 <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn>  

                            <telerik:GridBoundColumn DataField="TipoFamilia07" HeaderText="07" SortExpression="TipoFamilia07" UniqueName="TipoFamilia07" DataFormatString="{0:N0}" >
                                 <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn>   
                                                                       
                            <telerik:GridBoundColumn DataField="TipoFamilia08" HeaderText="08" SortExpression="TipoFamilia08" UniqueName="TipoFamilia08" DataFormatString="{0:N0}" >
                                 <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn>  

                            <telerik:GridBoundColumn DataField="TipoFamilia09" HeaderText="09" SortExpression="TipoFamilia09" UniqueName="TipoFamilia09" DataFormatString="{0:N0}" >
                                 <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn>  

                            <telerik:GridBoundColumn DataField="TipoFamilia10" HeaderText="10" SortExpression="TipoFamilia10" UniqueName="TipoFamilia10" DataFormatString="{0:N0}" >
                                 <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn>   
                                                                       
                            <telerik:GridBoundColumn DataField="TipoFamilia11" HeaderText="11" SortExpression="TipoFamilia11" UniqueName="TipoFamilia11" DataFormatString="{0:N0}" >
                                 <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn>  

                            <telerik:GridBoundColumn DataField="TipoFamilia12" HeaderText="12" SortExpression="TipoFamilia12" UniqueName="TipoFamilia12" DataFormatString="{0:N0}" >
                                 <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn>  

                            <telerik:GridBoundColumn DataField="TipoFamilia13" HeaderText="13" SortExpression="TipoFamilia13" UniqueName="TipoFamilia13" DataFormatString="{0:N0}" >
                                 <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn>   
                                                                       
                            <telerik:GridBoundColumn DataField="TipoFamilia14" HeaderText="14" SortExpression="TipoFamilia14" UniqueName="TipoFamilia14" DataFormatString="{0:N0}" >
                                 <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn>  

                            <telerik:GridBoundColumn DataField="TipoFamilia15" HeaderText="15" SortExpression="TipoFamilia15" UniqueName="TipoFamilia15" DataFormatString="{0:N0}" >
                                 <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn>  

                            <telerik:GridBoundColumn DataField="conteopersonas" HeaderText="Benef" SortExpression="conteopersonas" UniqueName="conteopersonas" DataFormatString="{0:N0}"  >
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
                       HideStructureColumns="True" filename ="ConsultaTipoFamilia" ExportOnlyData="True" IgnorePaging="True" OpenInNewWindow="True">
                         <Pdf PageWidth="" >
                         </Pdf>
                    </ExportSettings>
                    <SortingSettings SortToolTip="Clic aqui para ordenar..."  SortedAscToolTip ="Ordenar Ascendente" SortedDescToolTip ="Ordenar Descendente" />
                    <PagerStyle Mode="NumericPages" AlwaysVisible="True"    />
                
                </telerik:RadGrid>
                <telerik:RadAjaxLoadingPanel ID="LoadingPanel2" runat="server" 
                    BackgroundPosition="Right" Height="0px" Transparency="50">
                    <asp:Image ID="Image1" runat="server" AlternateText="Cargando..." 
                        ImageUrl="~/Images/loading.gif" />
                    <telerik:RadScriptManager ID="RadScriptManager1" Runat="server">
                    </telerik:RadScriptManager>
                </telerik:RadAjaxLoadingPanel>
            </td>
        </tr>
    </table>
    </asp:Panel> 
</asp:Content>

