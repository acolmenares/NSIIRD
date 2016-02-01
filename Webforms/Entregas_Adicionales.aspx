<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="Entregas_Adicionales.aspx.vb" Inherits="WebForms_Entregas_Adicionales" %>
<%@ Register Src="../Controles/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <script type="text/javascript">
        function ValNumero(fld, e) {
            var strCheck = '012345678., 9-';
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
    <asp:ValidationSummary ID="valSummary" runat="server" ValidationGroup="PROGRAMA" ForeColor="Red" style="text-align: left" />
    <asp:Panel runat="server" ID="pnl_principal" DefaultButton ="btn_actualizar" Width ="100%">
        <table id="Table2" cellspacing="0" cellpadding="0" border="0" class="ContentTable" style="width: 100%">
            <tr valign="top">
                <td style="width: 75%; text-align: left;"> 
                    <asp:Label ID="lbl_Titulo" runat="server" 
                        Text="VISTA DE VULNERABLES" Width="90%" 
                        CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
                    <asp:Label ID="lblMensaje" runat="server" CssClass="TitMensaje" Text="_" Width="90%" Visible="False"/>
                </td>
                <td style="width: 25%" align="right">
                    <asp:ImageButton ID="btn_actualizar" runat="server" ImageUrl="~/Images/Reload.jpg" ToolTip="Actualizar la vista actual." TabIndex="5" />
                    <asp:ImageButton ID="btn_nuevo" runat="server" ImageUrl="~/Images/Add.jpg" ToolTip="Crear Nuevo Registro." TabIndex="6" />
                    <asp:ImageButton ID="btn_cerrar" runat="server" ImageUrl="~/Images/Stop.jpg" ToolTip="Cerrar - Volver a la vista anterior." TabIndex="7" />
                    <asp:ImageButton ID="btn_home" runat="server" ImageUrl="~/Images/Home.jpg" ToolTip="Ir al Inicio." TabIndex="8" />
                </td>
            </tr>

            <tr valign="top">
                <td colspan="2">
                    <table id="TablaContenido" cellspacing="0" cellpadding="0" border="0" class="ContentTable" style="width: 100%">
                        <tr>
                            <td>
                                <table id="tblContenido" class="EditControlsTable" cellspacing="0" 
                                    cellpadding="0" border="0" width="100%">
                                    <tr>
                                        <td class="LabelCell" colspan="5" style="background-color: #ffc080">
                                            <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="Navy" Width="85%">Creación de Grupo de Entrega </asp:Label>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td  class="LabelCell" style="width: 20%;">
                                            <asp:Label id="lblNumero" runat="server" Width="100%">Seleccione Programa</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 20%; text-align: left;">
                                            <asp:dropdownlist id="ddlPrograma" runat="server" Font-Size="X-Small" Width="90%" AutoPostBack="True" ></asp:dropdownlist>        
                                            <asp:RegularExpressionValidator ID="rev_Programa" runat="server" ControlToValidate="ddlPrograma"
                                                ErrorMessage="Falta Registro de Programación" ValidationExpression="^[1-9]+[0-9]*$" EnableClientScript="False" ValidationGroup="PROGRAMA" ForeColor="Red" Text= '*'/>
                                        </td>
                                        <td class="ControlCell" style="width: 20%;">
                                            <asp:Label id="lblFecha" runat="server" Width="90%">Fecha</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 20%;">
                                                <asp:Label ID="lbl_Fecha" runat="server" Width="90%">...</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 20%;">
                                            <asp:Button ID="btn_crear" runat="server" CssClass="Boton" 
                                                Text="Crear Entrega Especial" 
                                                ToolTip="Crear o Grabar la informacion de la Entrega Adicional" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="LabelCell" colspan="5">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="LabelCell" colspan="5" style="height: 16px; background-color: #ffc080;">
                                            <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Navy" Width="85%">Seleccion de Declarantes para la Entrega</asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="left" style="width: 20%">
                                            <asp:Label ID="Label5" runat="server" Width="90%">Digite Identificación</asp:Label>
                                        </td>
                                        <td align="left" style="width: 20%">
                                            <asp:TextBox ID="txt_Identificacion" runat="server" Font-Size="X-Small" MaxLength="20"
                                                onkeypress="return ValNumero(this, event)" Style="text-align: right" Width="70%" AutoPostBack="True">
                                            </asp:TextBox>
                                            <asp:Button ID="btn_buscar" runat="server" CssClass="Boton" Text="Buscar" />
                                        </td>
                                        <td align="left" style="width: 20%">
                                            <asp:Label ID="Label3" runat="server" Width="94%">Seleccione la declaración a aplicar</asp:Label>
                                        </td>
                                        <td align="left" style="width: 20%">
                                            <asp:dropdownlist id="ddl_personas" runat="server" Font-Size="X-Small" Width="90%" ></asp:DropDownList>
                                        </td>
                                        <td align="left" style="width: 20%">
                                            <asp:Button ID="btn_cargar" runat="server" CssClass="Boton" Text="Cargar Declarante" ToolTip="Cargar el declarante seleccionado" />
                                        </td>
                                    </tr>

                                    <tr>
                                        <td align="center" class="LabelCell" colspan="5" style="background-color: #ffc080">
                                            <asp:Label ID="Label2" runat="server" BackColor="#FFC080" Font-Bold="True" ForeColor="Navy"
                                                Width="100%">Nombre de los declarantes que forman parte del registro de Programación</asp:Label>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td  class="LabelCell" colspan="5">
                                            <telerik:RadGrid ID="Rg_Listado" runat="server" AllowSorting="True" 
                                                GridLines="None" Skin="WebBlue" Width="100%" OnItemCommand="subCommandItem"
                                                AutoGenerateColumns="False" ShowStatusBar="True" TabIndex="6" 
                                                PageSize="20" CellSpacing="0">
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
					            					            
						                                <telerik:GridBoundColumn DataField="Personas.NombreCompleto" HeaderText="Nombre del Vulnerable"
                                                            SortExpression="Personas.NombreCompleto" UniqueName="Personas.NombreCompleto" >
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn> 
					            
						                                <telerik:GridBoundColumn DataField="Personas.Identificacion" HeaderText="Identificación"  
                                                            SortExpression="Personas.Identificacion" UniqueName="Personas.Identificacion" >
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn> 					            
					            
						                                <telerik:GridBoundColumn DataField="Personas.Declaracion.TipoFamilia" HeaderText="TFR"  
                                                            SortExpression="Personas.Declaracion.TipoFamilia" UniqueName="Personas.Declaracion.TipoFamilia" >
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>
                                                                  
                                                        <telerik:GridTemplateColumn HeaderText ="ENC" HeaderTooltip ="Encuesta de Vulnerables" >
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                            <ItemTemplate >
                                                                <asp:ImageButton ID="imbEncuesta" runat="server" ImageUrl ="~/Images/encuesta2.jpg" CommandName ="Encuesta" ToolTip ="Ir a la Encuesta de Entrega Especial"   />
                                                            </ItemTemplate>
                                                        </telerik:GridTemplateColumn>

                                                        <telerik:GridButtonColumn ButtonType="ImageButton" ConfirmDialogType="Classic"  CommandName ="Eliminar"
                                                            ConfirmText="Desea eliminar este registro?" ConfirmTitle="Borrar Vulnerable." 
                                                            HeaderText="X" HeaderTooltip="Eliminar Registro de Vulnerable " 
                                                            ImageUrl="../Images/balde.gif" UniqueName="Borrar">
                                                            <ItemStyle HorizontalAlign="Center" Width="10px" />
                                                            <HeaderStyle HorizontalAlign="Center" />
                                                        </telerik:GridButtonColumn>   
                                                        <telerik:GridTemplateColumn HeaderText="No." DefaultInsertValue="" UniqueName="TemplateColumn" Visible ="False">
                                                            <ItemTemplate>
                                                                <asp:Label runat="Server" Id="lblid_declaracion_seguimiento" Visible ="True" Text ='<%#Container.DataItem.Id_Declaracion_Seguimiento%>'/>
                                                                <asp:Label runat="Server" Id="lblid_declaracion" Visible ="True" Text ='<%#Container.DataItem.Personas.Id_Declaracion%>'/>
                                                            </ItemTemplate>
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
                                                <ClientSettings EnablePostBackOnRowClick="False" EnableRowHoverStyle ="True" >
                                                    <Selecting AllowRowSelect ="True"  />
                                                </ClientSettings>
                    
                                                    <ExportSettings
                                                    HideStructureColumns="True" filename ="EntregasAdicionalesPersonas" ExportOnlyData="True" IgnorePaging="True" OpenInNewWindow="True">
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

