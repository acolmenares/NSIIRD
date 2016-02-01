<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="BodegasList.aspx.vb" Inherits="WebForms_BodegasList" %>
<%@ Register Src="../Controles/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel runat="server" ID="pnl_principal" DefaultButton ="btn_actualizar" Width ="100%">
     <table id="tbl_Interna" border="0" cellpadding="1" cellspacing="0" width="100%" 
            
            style="border-right: whitesmoke thin solid; border-top: whitesmoke thin solid; border-left: whitesmoke thin solid; border-bottom: whitesmoke thin solid">
        <tr valign ="top">
        <td style="width: 80%;"> 
            <asp:Label ID="Label3" runat="server" 
                Text="VISTA GENERAL DE BODEGAS" Width="100%" CssClass="TitTitulo" 
                BackColor="PeachPuff"></asp:Label><br />
            <asp:Label ID="Label4" runat="server" CssClass="TitMensaje" Text="_" Width="100%" Visible="False"></asp:Label></td>
        <td style="width: 20%" align="right">
            <asp:ImageButton ID="btn_actualizar" runat="server" ImageUrl="~/Images/Reload.jpg" ToolTip="Actualizar la vista actual." TabIndex="1" />
            <asp:ImageButton ID="btn_buscar" runat="server" ImageUrl="~/Images/Zoom In.jpg" 
                TabIndex="2" ToolTip="Ver/quitar Sistema de Búsqueda." />
            <asp:ImageButton ID="btn_nuevo" runat="server" ImageUrl="~/Images/Add.jpg" ToolTip="Crear Nuevo Registro." TabIndex="3" />
            <asp:ImageButton ID="btn_cerrar" runat="server" ImageUrl="~/Images/Stop.jpg" ToolTip="Cerrar - Volver a la vista anterior." TabIndex="4" />
            <asp:ImageButton ID="btn_home" runat="server" ImageUrl="~/Images/Home.jpg" ToolTip="Ir al Inicio." TabIndex="5" />&nbsp;</td>
        </tr>
        <tr valign ="top">
            <td colspan="2" align="center" >
                <asp:Panel ID="pnl_buscar" runat="server" HorizontalAlign="Center" 
                    Visible="False" Width="100%">
                    <table border="0" cellpadding="0" cellspacing="0" 
                        style="width: 100%; text-align: left; padding-left: 3px;">
                        <tr valign="top">
                            <td colspan="5" style="text-align: left; width: 80%;">
                                <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Underline="False" 
                                    Text="Sistema de Búsqueda Selectiva" Width="90%"></asp:Label>
                            </td>
                            <td align="right" style="width: 20%">
                                <asp:ImageButton ID="btn_Procesar" runat="server" 
                                    ImageUrl="~/Images/Search.jpg" TabIndex="5" ToolTip="Realizar la Búsqueda." />
                                <asp:ImageButton ID="btn_limpiar" runat="server" ImageUrl="~/Images/New.jpg" 
                                    TabIndex="6" ToolTip="Limpiar Campos Búsqueda." />
                            </td>
                        </tr>
                        <tr valign="top">
                            <td style="width: 20%">
                                <asp:Label ID="Label41" runat="server" Text="Regional" Width="94%"></asp:Label>
                            </td>
                            <td style="width: 20%">
                                <asp:DropDownList ID="ddl_regional" runat="server" Font-Size="X-Small" 
                                    TabIndex="3" Width="94%">
                                </asp:DropDownList>
                            </td>
                            <td style="width: 20%">
                                &nbsp;</td>
                            <td style="width: 20%">
                                &nbsp;</td>
                            <td colspan="2" height="25" style="width: 20%">
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
                </td>
        </tr>
        <tr valign ="top">
            <td colspan="2">
                <telerik:RadGrid ID="Rg_Listado" runat="server" AllowSorting="True" GridLines="None"  Width="100%" 
                    AutoGenerateColumns="False" ShowStatusBar="True" TabIndex="6" PageSize="20" CellSpacing="0" AllowPaging="True" Skin="WebBlue">
                    <MasterTableView  NoDetailRecordsText="No hay informaci&#243;n." NoMasterRecordsText="No hay informaci&#243;n." DataKeyNames="Id" 
                        CommandItemDisplay ="Top">
                        <Columns>
                           <telerik:GridTemplateColumn HeaderText="No." DefaultInsertValue="" UniqueName="TemplateColumn">
                                <ItemTemplate>
                                    <asp:label runat="server" id="lblno" text='<%# ctype(CType(Container.Parent.Parent.Parent,RadGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>'  ToolTip ='<%#Container.DataItem.Id%>'/>
                                    <asp:Label runat="Server" Id="lblid" Visible ="False" Text ='<%#Container.DataItem.Id%>'/>
                                </ItemTemplate>
                                
                                <ItemStyle Width ="40px" HorizontalAlign ="Center" />
                                    
                            </telerik:GridTemplateColumn>                                
                        
                            <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" HeaderText="Id" ReadOnly="True"
                                SortExpression="Id" UniqueName="Id"  Visible ="True"  Display ="False">
                            </telerik:GridBoundColumn>
                           
                            <telerik:GridBoundColumn DataField="Padre" HeaderText="Regional" SortExpression="Padre" UniqueName="Padre"  >
                                 <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn> 

                            <telerik:GridBoundColumn DataField="Descripcion" HeaderText="Descripcion"
                                SortExpression="Descripcion" UniqueName="Descripcion" >
                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn>       
                              
                            <telerik:GridButtonColumn ConfirmText="Eliminar esta Bodega?" ConfirmDialogType ="RadWindow"   
                                 ConfirmTitle="!!! Borrar Registro !!!" ButtonType="ImageButton" CommandName ="Delete" HeaderText ="Eliminar" HeaderTooltip ="Eliminar Bodega" >
                               <ItemStyle Width="20px" HorizontalAlign ="Center" />
                            </telerik:GridButtonColumn>                                            
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
                    
                     <ExportSettings Excel-Format ="ExcelML"  SuppressColumnDataFormatStrings ="true"
                       HideStructureColumns="True" filename ="Bodegas" ExportOnlyData="True" IgnorePaging="True" OpenInNewWindow="True">
                         <Pdf PageWidth="">
                         </Pdf>
                         <Excel Format="ExcelML" />
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
                        <telerik:AjaxUpdatedControl ControlID="pnl_principal" UpdatePanelCssClass="" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="Rg_Listado">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="Rg_Listado" UpdatePanelCssClass="" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
            </AjaxSettings>
        </telerik:RadAjaxManager>
    </telerik:RadAjaxLoadingPanel>

</asp:Content>

