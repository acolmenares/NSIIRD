<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="Entregas_AdicionalesList.aspx.vb" Inherits="WebForms_Entregas_AdicionalesList" %>
<%@ Register Src="../Controles/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Panel runat="server" ID="pnl_principal" DefaultButton ="btn_actualizar" Width ="100%">
        <script type="text/javascript">
            function ValNumero(fld, e) {
                var strCheck = '012345678,.-9';
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
                if (fld.value.indexOf(".") != -1 && key == ".") return false; //valida que solo permita un punto decimal
                if (fld.value == "" && key == ".") return false; //valida que no sea vacio o que no tenga un punto sin nmeros
            }


        </script>
        <table id="tbl_Interna" border="0" cellpadding="1" cellspacing="0" width="100%" 
                style="border-right: whitesmoke thin solid; border-top: whitesmoke thin solid; border-left: whitesmoke thin solid; border-bottom: whitesmoke thin solid">
            <tr valign ="top">
                <td style="width: 80%;"> 
                    <asp:Label ID="Label31" runat="server" 
                        Text="VISTA GENERAL DE ENTREGAS ESPECIALES" Width="100%" 
                        CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
                    <asp:Label ID="lbl_Mensaje" runat="server" CssClass="TitMensaje" Text="_" 
                        Width="100%" Visible="False"></asp:Label>
                </td>
                <td style="width: 20%" align="right">
                    <asp:ImageButton ID="btn_actualizar" runat="server" ImageUrl="~/Images/Reload.jpg" ToolTip="Actualizar la vista actual." TabIndex="1" />
                    <asp:ImageButton ID="btn_buscar" runat="server" ImageUrl="~/Images/Zoom In.jpg" 
                        ToolTip="Ver/quitar Sistema de Búsqueda." TabIndex="2" Visible="False" />
                    <asp:ImageButton ID="btn_nuevo" runat="server" ImageUrl="~/Images/Add.jpg" 
                        ToolTip="Crear Nuevo Registro." TabIndex="3" />
                    <asp:ImageButton ID="btn_cerrar" runat="server" ImageUrl="~/Images/Stop.jpg" ToolTip="Cerrar - Volver a la vista anterior." TabIndex="4" />
                    <asp:ImageButton ID="btn_home" runat="server" ImageUrl="~/Images/Home.jpg" ToolTip="Ir al Inicio." TabIndex="5" />
                </td>
            </tr>
             <tr valign="top">
                    <td colspan="2" align="center">
                        <table id="TablaContenido" cellspacing="0" cellpadding="0" border="0" class="ContentTable" style="width: 100%">
                            <tr valign="top">
                                <td>
                                    <table id="tblContenido" class="EditControlsTable" cellspacing="0" cellpadding="0" border="0" style="width: 100%">
				                        <tr valign="top">
				                            <td>
                                                <telerik:RadGrid ID="Rg_Listado" runat="server" AllowSorting="True" 
                                                    Skin="WebBlue" Width="100%" OnItemCommand="subCommandItem"
                                                    AutoGenerateColumns="False" ShowStatusBar="True" TabIndex="6" 
                                                    PageSize="20" ResolvedRenderMode="Classic">
                                                    <MasterTableView  NoDetailRecordsText="No hay informaci&#243;n." NoMasterRecordsText="No hay informaci&#243;n." DataKeyNames="Id" 
                                                        CommandItemDisplay ="Top" AllowPaging="True" ShowFooter="True">
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

                                                            <telerik:GridBoundColumn DataField="Fecha" DataType="System.DateTime" HeaderText="Fecha Atención"
                                                                DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha" UniqueName="Fecha">
                                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                            </telerik:GridBoundColumn>						            
					            					            
						                                    <telerik:GridBoundColumn DataField="TipoEntrega.Descripcion" HeaderText="Tipo Entrega"
                                                                SortExpression="TipoEntrega.Descripcion" UniqueName="TipoEntrega.Descripcion" >
                                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                            </telerik:GridBoundColumn> 
					            
						                                    <telerik:GridBoundColumn DataField="Programa.Numero" HeaderText="Programación"  HeaderTooltip ="Número de Programación"
                                                                SortExpression="Programa.Numero" UniqueName="Programa.Numero" >
                                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                            </telerik:GridBoundColumn> 					            
					            
						                                    <telerik:GridBoundColumn DataField="Programa.LugarEntrega.Descripcion" HeaderText="Lugar Entrega"  
                                                                SortExpression="Programa.LugarEntrega.Descripcion" UniqueName="Programa.LugarEntrega.Descripcion" >
                                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                            </telerik:GridBoundColumn>
					            						
						                                    <telerik:GridBoundColumn DataField="Programa.Grupo.Descripcion" HeaderText="Grupo"  
                                                                SortExpression="Programa.Grupo.Descripcion" UniqueName="Programa.Grupo.Descripcion" >
                                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                            </telerik:GridBoundColumn> 

                                                            <telerik:GridButtonColumn ButtonType="ImageButton" ConfirmDialogType="Classic"  CommandName ="Eliminar"
                                                                ConfirmText="Desea eliminar este registro?" ConfirmTitle="Borrar Entrega." 
                                                                HeaderText="X" HeaderTooltip="Eliminar Registro de Entrega " 
                                                                ImageUrl="../Images/balde.gif" UniqueName="Borrar">
                                                                <ItemStyle HorizontalAlign="Center" Width="10px" />
                                                                <HeaderStyle HorizontalAlign="Center" />
                                                            </telerik:GridButtonColumn>                                

                            
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
                                                       HideStructureColumns="True" filename ="EntregasAdicionales" ExportOnlyData="True" IgnorePaging="True" OpenInNewWindow="True">
                                                         <Pdf PageWidth="" >
                                                         </Pdf>
                                                    </ExportSettings>
                                                    <SortingSettings SortToolTip="Clic aqui para ordenar..."  SortedAscToolTip ="Ordenar Ascendente" SortedDescToolTip ="Ordenar Descendente" />
                                                    <PagerStyle Mode="NumericPages"    />
                
                                                </telerik:RadGrid>
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
                                                                    <telerik:AjaxUpdatedControl ControlID="pnl_principal" />
                                                                </UpdatedControls>
                                                            </telerik:AjaxSetting>
                                                            <telerik:AjaxSetting AjaxControlID="btn_buscar">
                                                                <UpdatedControls>
                                                                    <telerik:AjaxUpdatedControl ControlID="pnl_buscar" UpdatePanelCssClass="" />
                                                                </UpdatedControls>
                                                            </telerik:AjaxSetting>
                                                            <telerik:AjaxSetting AjaxControlID="btn_nuevo">
                                                                <UpdatedControls>
                                                                    <telerik:AjaxUpdatedControl ControlID="pnl_principal" UpdatePanelCssClass="" />
                                                                </UpdatedControls>
                                                            </telerik:AjaxSetting>
                                                            <telerik:AjaxSetting AjaxControlID="btn_Procesar">
                                                                <UpdatedControls>
                                                                    <telerik:AjaxUpdatedControl ControlID="pnl_buscar" UpdatePanelCssClass="" />
                                                                    <telerik:AjaxUpdatedControl ControlID="Rg_Listado" />
                                                                </UpdatedControls>
                                                            </telerik:AjaxSetting>
                                                            <telerik:AjaxSetting AjaxControlID="ddl_regional">
                                                                <UpdatedControls>
                                                                    <telerik:AjaxUpdatedControl ControlID="ddl_LugarFuente" 
                                                                        UpdatePanelCssClass="" />
                                                                </UpdatedControls>
                                                            </telerik:AjaxSetting>
                                                            <telerik:AjaxSetting AjaxControlID="Rg_Listado">
                                                                <UpdatedControls>
                                                                    <telerik:AjaxUpdatedControl ControlID="lbl_mensaje" UpdatePanelCssClass="" />
                                                                </UpdatedControls>
                                                            </telerik:AjaxSetting>
                                                        </AjaxSettings>
                                                    </telerik:RadAjaxManager>
                                                </telerik:RadAjaxLoadingPanel>
				                            </td>
				                        </tr>
			                        </table>
						                        
                                </td>
                            </tr>
                        </table>
                     </td>
                </tr>
            </table>

    </asp:Panel>

</asp:Content>

