<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="Personas_Regimen_Salud.aspx.vb" Inherits="WebForms_Personas_Regimen_Salud" %>
<%@ Register Src="../Controles/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .ControlCell
        {
            text-align: left;
        }
    </style>
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
    <asp:ValidationSummary ID="ValidationSummary3" runat="server" ValidationGroup="SE" ForeColor="Red" style="text-align: left" />
    <asp:Panel runat="server" ID="pnl_principal" DefaultButton ="btnGuardar" Width ="100%">
        <table id="Table2" cellspacing="0" cellpadding="0" border="0" class="ContentTable" style="width: 100%">
            <tr valign="top">
                <td style="width: 75%; text-align: left;"> 
                    <asp:Label ID="lbl_Titulo" runat="server" Text="SEGUIMIENTOS DE PERSONAS EN REGIMEN DE SALUD" Width="90%" CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
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
                        <tr valign="top">
                            <td style="width: 100%">
                                <table id="tblContenido" class="EditControlsTable" cellspacing="0" cellpadding="0" border="0" style="width: 100%; padding-left: 3px;">
                                    <tr>
                                        <td  class="ControlCell" style="width: 25%;">
                                            <asp:Label id="lblPersonas" runat="server" Width="90%">Nombre del Beneficiario</asp:Label>
                                        </td>
                                        <td class="ControlCell" colspan="3">
                                            <asp:Label ID="lbl_NombreCompleto" runat="server" Width="90%" Font-Size="Medium" ForeColor="#C00000"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="ControlCell" style="width: 25%; height: 14px">
                                            <asp:Label id="lblFecha" runat="server" Width="90%">Fecha</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="height: 14px">
                                            <telerik:RadDatePicker ID="rdpfecha" runat="server" 
                                                Culture="Spanish (Colombia)" MinDate="" Skin="Telerik" TabIndex="1" 
                                                ToolTip="Seleccione Fecha ..." Width="95%" style="text-align: center">
                                                <Calendar Skin="Telerik" UseColumnHeadersAsSelectors="False" 
                                                    UseRowHeadersAsSelectors="False" ViewSelectorText="x">
                                                    <FastNavigationSettings CancelButtonCaption="Cancelar" 
                                                        DateIsOutOfRangeMessage="Fecha Fuera de Rango" TodayButtonCaption="Hoy">
                                                    </FastNavigationSettings>
                                                </Calendar>
                                                <DatePopupButton HoverImageUrl="" ImageUrl="" TabIndex="1" 
                                                    ToolTip="Abrir el Calendario" />
                                                <DateInput DateFormat="dd/MM/yyyy" DisplayDateFormat="dd/MMMM/yyyy" 
                                                    EmptyMessage="Fecha ..." TabIndex="1">
                                                    <EmptyMessageStyle Resize="None" />
                                                    <ReadOnlyStyle Resize="None" />
                                                    <FocusedStyle Resize="None" />
                                                    <DisabledStyle Resize="None" />
                                                    <InvalidStyle Resize="None" />
                                                    <HoveredStyle Resize="None" />
                                                    <EnabledStyle Resize="None" />
                                                </DateInput>
                                            </telerik:RadDatePicker>
                                            <asp:RequiredFieldValidator ID="rfv_Fecha" runat="server" ControlToValidate="rdpfecha" EnableClientScript="False"
                                                ErrorMessage="Ingresar la Fecha " ValidationGroup="SE" ForeColor="Red">*</asp:RequiredFieldValidator>
                                        </td>
                                        <td class="ControlCell" style="height: 14px">
                                            <asp:Label ID="Label1" runat="server" Width="90%">Grupo</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="height: 14px">
                                            <asp:Label ID="lbl_Grupo" runat="server" Font-Size="Medium" ForeColor="#C00000"></asp:Label>
                                            <asp:Label ID="lblId" runat="server" Visible="False"></asp:Label>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td  class="ControlCell" style="width: 25%; height: 19px;">
                                            <asp:Label id="lbl_Regimen_Salud" runat="server" Width="90%">Regimen de Salud</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 30%; height: 19px;">
                                            <asp:dropdownlist id="ddl_Regimen_Salud" runat="server" AutoPostBack="True" Font-Size="X-Small" Width="90%" ></asp:dropdownlist>        
                                            <asp:RegularExpressionValidator ID="rev_Regimen_salud" runat="server" ControlToValidate="ddl_Regimen_Salud"
                                                EnableClientScript="False" ErrorMessage="Falta Regimen de Salud"
                                                ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE" ForeColor="Red">*
                                            </asp:RegularExpressionValidator>
                                        </td>
                                        <td class="ControlCell" style="width: 20%; height: 19px;">
                                            <asp:Label id="lbl_Eps" runat="server" Width="90%">EPS</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 30%; height: 19px;">
                                            <asp:dropdownlist id="ddl_eps" runat="server" Font-Size="X-Small" Width="90%" ></asp:dropdownlist>        
                                                <asp:RegularExpressionValidator ID="rev_eps" runat="server" ControlToValidate="ddl_eps"
                                                    EnableClientScript="False" ErrorMessage="Falta el dato de la EPS"
                                                    ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE" ForeColor="Red">*
                                                </asp:RegularExpressionValidator>
                                        </td>
                                    </tr>

                                    <tr><td  class="ControlCell" style="width: 25%">
                                    <asp:Label id="lblEstablecimiento" runat="server" Width="90%">Municipio</asp:Label></td><td class="ControlCell" style="width: 30%">
                                            <asp:DropDownList ID="ddl_departamento" runat="server" AutoPostBack="True" 
                                                Font-Size="X-Small" Width="90%">
                                            </asp:DropDownList>
                                            <asp:RegularExpressionValidator ID="rev_municipio" runat="server" 
                                                ControlToValidate="ddl_municipio" EnableClientScript="False" 
                                                ErrorMessage="Falta Municipio " ForeColor="Red" 
                                                ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE">*</asp:RegularExpressionValidator>
                                            <asp:DropDownList ID="ddl_municipio" runat="server" Font-Size="X-Small" 
                                                Width="90%">
                                            </asp:DropDownList>
                                        </td>
                                        <td class="ControlCell" style="width: 20%">
                                    </td>
                                        <td class="ControlCell" style="width: 30%">
                                            &nbsp;
                                            </td>
                                    </tr>
                                    <tr>
                                        <td class="ControlCell" style="width: 25%">
<asp:Label id="lblSubTablasId_Certificado_Matricula" runat="server" Width="90%">Necesita Traslado</asp:Label></td>
                                        <td class="ControlCell" style="width: 30%">
<asp:dropdownlist id="ddl_Necesita_Traslado" runat="server" Font-Size="X-Small" Width="90%" AutoPostBack="True" ></asp:dropdownlist>        
    <asp:RegularExpressionValidator ID="rev_Necesita_Traslado" runat="server" ControlToValidate="ddl_Necesita_Traslado"
        EnableClientScript="False" ErrorMessage="Falta si necesita traslado"
        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                                        <td class="ControlCell" style="width: 20%">
                                            <asp:Label ID="Label5" runat="server" Width="90%">Motivo No Necesita Traslado</asp:Label></td>
                                        <td class="ControlCell" style="width: 30%">
                                            <asp:dropdownlist id="ddl_Motivo_No_Necesita_Traslado" runat="server" Font-Size="X-Small" Width="90%" Enabled="False" >
                                            </asp:DropDownList>
                                            <asp:RegularExpressionValidator ID="rev_Motivo_No_Necesita_Traslado" runat="server"
                                                ControlToValidate="ddl_Motivo_No_Necesita_Traslado" EnableClientScript="False"
                                                Enabled="False" ErrorMessage="Falta motivo de no necesitar traslado" ValidationExpression="^[1-9]+[0-9]*$"
                                                ValidationGroup="SE" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                                    </tr>
<tr>
<td class="ControlCell" style="width: 25%">
    <asp:Label id="lblSubTablasId_grado_escolar" runat="server" Width="90%">Realizo Traslado</asp:Label></td>
<td class="ControlCell" style="width: 30%">
<asp:dropdownlist id="ddl_Realizo_Traslado" runat="server" Font-Size="X-Small" Width="90%" AutoPostBack="True" Enabled="False" ></asp:dropdownlist>        
    <asp:RegularExpressionValidator ID="rev_realizo_traslado" runat="server" ControlToValidate="ddl_Realizo_Traslado"
        EnableClientScript="False" Enabled="False" ErrorMessage="Fakta dato de realizar traslado"
        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE" ForeColor="Red">*</asp:RegularExpressionValidator></td>
    <td class="ControlCell" style="width: 20%">
<asp:Label id="lblSubTablasId_Seguimiento" runat="server" Width="90%">Motivo No Realizo Traslado</asp:Label></td>
    <td class="ControlCell" style="width: 30%">
<asp:dropdownlist id="ddl_Motivo_No_Realizo_Traslado" runat="server" Font-Size="X-Small" Width="90%" Enabled="False" ></asp:dropdownlist>
        <asp:RegularExpressionValidator ID="rev_motivo_no_realizar_traslado" runat="server"
            ControlToValidate="ddl_Motivo_No_Realizo_Traslado" EnableClientScript="False"
            Enabled="False" ErrorMessage="Falta motivo de no realizar traslado" ValidationExpression="^[1-9]+[0-9]*$"
            ValidationGroup="SE" ForeColor="Red">*</asp:RegularExpressionValidator></td>
</tr>
                                    <tr>
                                        <td class="ControlCell" style="width: 25%">
                                            <asp:Label ID="Label2" runat="server" Width="90%">Cerrar Caso !!!</asp:Label></td>
                                        <td class="ControlCell" style="width: 30%"><asp:dropdownlist id="ddl_cerrar" runat="server" Font-Size="X-Small" Width="90%" >
                                        </asp:DropDownList>
                                            <asp:RegularExpressionValidator ID="rev_cerrar" runat="server" ControlToValidate="ddl_cerrar"
                                                EnableClientScript="False" ErrorMessage="Falta dato de cerrar caso" ValidationExpression="^[1-9]+[0-9]*$"
                                                ValidationGroup="SE" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                                        <td class="ControlCell" style="width: 20%">
                                            </td>
                                        <td class="ControlCell" style="width: 30%">
                                            <asp:CheckBox ID="chb_cerrado" runat="server" Enabled="False" Visible="False" /></td>
                                    </tr>
                                    <tr>
                                        <td class="ControlCell" style="width: 25%">
                                            <asp:Label ID="Label4" runat="server" Width="90%">Observaciones</asp:Label>
                                            </td>
                                        <td class="ControlCell" colspan="3">
                                            <asp:TextBox ID="txt_observaciones" runat="server" Rows="5" TextMode="MultiLine"
                                                Width="95%" MaxLength="800"></asp:TextBox></td>
                                    </tr>

                                </table>
                            </td>
                         </tr>
                         <tr style="background-color: #F7F7F7;">
                            <td align="center">
                                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" cssclass="Boton" 
                                    Width="120px"></asp:Button>&nbsp;<asp:Button ID="btnNuevo" runat="server" 
                                    CssClass="Boton" Text="Nuevo Seguimiento" />
                            </td>
                        </tr>
                    </table>
                 
                </td>
            </tr>
            
            <tr valign="top">
                <td class="FooterFormEdit" colspan="2">
				    <telerik:RadGrid ID="Rg_Listado" runat="server" AllowSorting="True" GridLines="None" Skin="WebBlue" Width="100%"  OnItemCommand="subCommandItem"
                        AutoGenerateColumns="False" ShowStatusBar="True" TabIndex="6" PageSize="20" CellSpacing="0">
                        <MasterTableView  NoDetailRecordsText="No hay informaci&#243;n." 
                            NoMasterRecordsText="No hay informaci&#243;n." DataKeyNames="Id" CommandItemDisplay ="Top" ShowFooter="True">
                            <Columns>
                                <telerik:GridTemplateColumn HeaderText="No." DefaultInsertValue="" UniqueName="TemplateColumn">
                                    <ItemTemplate>
                                        <asp:label runat="server" id="lblno" text='<%# ctype(CType(Container.Parent.Parent.Parent,RadGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>'  ToolTip = '<%#Container.DataItem.Id%>'/>
                                        <asp:Label runat="Server" Id="lblid" Visible ="False" Text ='<%#Container.DataItem.Id%>'/>
                                        <asp:Label ID="lblTipoSeguimiento" runat="server" Visible ="False" Text='<%# Container.DataItem.Id_Tipo_Entrega %>'></asp:Label>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>                                
                        
                                <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" HeaderText="Id" 
                                    SortExpression="Id" UniqueName="Id"  Display ="False" >
                                </telerik:GridBoundColumn>

                                <telerik:GridBoundColumn DataField="Fecha" DataType="System.DateTime" HeaderText="Fecha"
                                    DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha" UniqueName="Fecha">
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                </telerik:GridBoundColumn>	                          
                            
                               <telerik:GridBoundColumn DataField="Tipo_Entrega.Descripcion" HeaderText="Tipo Entrega"
                                    SortExpression="Tipo_Entrega.Descripcion" UniqueName="Tipo_Entrega.Descripcion" >
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                </telerik:GridBoundColumn>

                               <telerik:GridBoundColumn DataField="Regimen_Salud.Descripcion" HeaderText="Regimen Salud"
                                    SortExpression="Regimen_Salud.Descripcion" UniqueName="Regimen_Salud.Descripcion" >
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                </telerik:GridBoundColumn>

                               <telerik:GridBoundColumn DataField="Eps.Descripcion" HeaderText="E.P.S."
                                    SortExpression="Eps.Descripcion" UniqueName="Eps.Descripcion" >
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                </telerik:GridBoundColumn>

                               <telerik:GridBoundColumn DataField="NecesitaTraslado" HeaderText="Traslado"
                                    SortExpression="NecesitaTraslado" UniqueName="NecesitaTraslado" >
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                </telerik:GridBoundColumn>

                               <telerik:GridBoundColumn DataField="MotivoNoTraslado" HeaderText="Motivo No Traslado"
                                    SortExpression="MotivoNoTraslado" UniqueName="MotivoNoTraslado" >
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                </telerik:GridBoundColumn>

                               <telerik:GridBoundColumn DataField="RealizoTraslado" HeaderText="Realizo"
                                    SortExpression="RealizoTraslado" UniqueName="RealizoTraslado" >
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                               </telerik:GridBoundColumn>

                               <telerik:GridBoundColumn DataField="Cerrado" HeaderText="Cerrado"
                                    SortExpression="Cerrado" UniqueName="Cerrado" >
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                </telerik:GridBoundColumn>

                                <telerik:GridButtonColumn ConfirmText="Desea eliminar este registro?" ConfirmDialogType ="Classic"   HeaderTooltip = "Eliminar Registro de Educación " HeaderText ="X"
                                    ConfirmTitle="Borrar Item de Educación."  CommandName="Eliminar" UniqueName="Borrar" ButtonType="ImageButton" ImageUrl="../Images/balde.gif">
                                    <ItemStyle Width="10px" HorizontalAlign ="Center" />
                                    <HeaderStyle HorizontalAlign ="Center"  />
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
                    
                        <ExportSettings HideStructureColumns="True" filename ="PersonasRegimenSalud" ExportOnlyData="True" IgnorePaging="True" OpenInNewWindow="True">
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
        <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server" 
            DefaultLoadingPanelID="LoadingPanel2">
            <AjaxSettings>
                <telerik:AjaxSetting AjaxControlID="btn_actualizar">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="pnl_principal" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="btn_nuevo">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="pnl_principal" UpdatePanelCssClass="" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="ddl_Necesita_Traslado">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="ddl_Motivo_No_Necesita_Traslado" 
                            UpdatePanelCssClass="" />
                        <telerik:AjaxUpdatedControl ControlID="rev_Motivo_No_Necesita_Traslado" 
                            UpdatePanelCssClass="" />
                        <telerik:AjaxUpdatedControl ControlID="ddl_Realizo_Traslado" 
                            UpdatePanelCssClass="" />
                        <telerik:AjaxUpdatedControl ControlID="rev_realizo_traslado" 
                            UpdatePanelCssClass="" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="ddl_Realizo_Traslado">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="ddl_Motivo_No_Realizo_Traslado" 
                            UpdatePanelCssClass="" />
                        <telerik:AjaxUpdatedControl ControlID="rev_motivo_no_realizar_traslado" 
                            UpdatePanelCssClass="" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="btnGuardar">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="ValidationSummary3" 
                            UpdatePanelCssClass="" />
                        <telerik:AjaxUpdatedControl ControlID="pnl_principal" UpdatePanelCssClass="" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="btnNuevo">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="pnl_principal" UpdatePanelCssClass="" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="ddl_departamento">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="ddl_municipio" UpdatePanelCssClass="" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
            </AjaxSettings>
        </telerik:RadAjaxManager>
    </telerik:RadAjaxLoadingPanel>
</asp:Content>

