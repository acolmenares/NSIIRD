<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="Personas_Educacion.aspx.vb" Inherits="WebForms_Personas_Educacion" %>
<%@ Register Src="../Controles/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 25%;
        }
        .style2
        {
            width: 30%;
        }
        .style3
        {
            width: 20%;
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
    <asp:ValidationSummary ID="ValidationSummary3" runat="server" 
        ValidationGroup="SE" ForeColor="Red" style="text-align: left" />
     <asp:Panel runat="server" ID="pnl_principal" DefaultButton ="btnGuardar" Width ="100%">
        <table id="Table2" cellspacing="0" cellpadding="0" border="0" class="ContentTable" style="width: 100%">
            <tr valign="top">
            <td style="width: 75%; text-align: left;"> 
                <asp:Label ID="lbl_Titulo" runat="server" 
                    Text="CREACION / MODIFICACION DE PERSONAS EN EDAD ESCOLAR" Width="90%" 
                    CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
                <asp:Label ID="lblMensaje" runat="server" CssClass="TitMensaje" Text="_" Width="90%" Visible="False"/>
            </td>
            <td style="width: 25%" align="right">
                <asp:ImageButton ID="btn_actualizar" runat="server" ImageUrl="~/Images/Reload.jpg" ToolTip="Actualizar la vista actual." TabIndex="5" />
                <asp:ImageButton ID="btn_nuevo" runat="server" ImageUrl="~/Images/Add.jpg" ToolTip="Crear Nuevo Registro." TabIndex="6" />
                <asp:ImageButton ID="btn_cerrar" runat="server" ImageUrl="~/Images/Stop.jpg" ToolTip="Cerrar - Volver a la vista anterior." TabIndex="7" />
                <asp:ImageButton ID="btn_home" runat="server" ImageUrl="~/Images/Home.jpg" ToolTip="Ir al Inicio." TabIndex="8" />&nbsp;</td>
            </tr>

            <tr valign="top">
                <td colspan="2">

                    <table id="tblContenido" class="EditControlsTable" cellspacing="0" cellpadding="0" border="0" style="width: 100%">

                        <tr><td  class="LabelCell" style="width: 25%;">
                        <asp:Label id="lblPersonas" runat="server" Width="90%">Nombre del Joven</asp:Label></td><td class="ControlCell" colspan="3">
                        <asp:Label ID="lbl_NombreCompleto" runat="server" Width="90%" Font-Size="Medium" ForeColor="#C00000"></asp:Label></td>
                        </tr>
                        <tr>
                            <td class="LabelCell" style="width: 25%; height: 14px">
                                <asp:Label id="lblFecha" runat="server" Width="90%">Fecha de Seguimiento</asp:Label></td>
                            <td class="ControlCell" style="height: 14px; text-align: left;">
                                <telerik:RadDatePicker ID="rdpfecha" runat="server" 
                                    Culture="Spanish (Colombia)" MinDate="" Skin="Telerik" TabIndex="1" 
                                    ToolTip="Seleccione Fecha ..." Width="90%">
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
                                <asp:RequiredFieldValidator ID="rfv_Fecha"
                                runat="server" ControlToValidate="rdpfecha" EnableClientScript="False"
                                ErrorMessage="Ingresar la Fecha de Seguimiento" ValidationGroup="SE" 
                                    ForeColor="Red">*</asp:RequiredFieldValidator></td>
                            <td class="ControlCell" style="height: 14px">
                                <asp:Label ID="lblgrupo" runat="server" Width="90%">Grupo</asp:Label></td>
                            <td class="ControlCell" style="height: 14px">
                                <asp:Label ID="lbl_Grupo" runat="server" Font-Size="Medium" ForeColor="#C00000"></asp:Label>
                                <asp:Label ID="lblId" runat="server" Visible="False"></asp:Label></td>
                        </tr>

                        <tr><td  class="style1">
                        <asp:Label id="lblEstudia_Actualmente" runat="server" Width="90%">Estudia Actualmente</asp:Label>


                        </td><td class="style2" style="text-align: left;">
                        <asp:dropdownlist id="ddl_Estudia_Actualmente" runat="server" AutoPostBack="True" Font-Size="X-Small" Width="90%" ></asp:dropdownlist>        
                        <asp:RegularExpressionValidator ID="rev_Estudia_Actualmente" runat="server" ControlToValidate="ddl_Estudia_Actualmente"
                        EnableClientScript="False" ErrorMessage="Falta si estudia actualmente"
                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                        <td class="style3">
                        <asp:Label id="lblSubTablasId_Motivo_NoEstudia" runat="server" Width="90%">Motivo No Estudia</asp:Label></td>
                        <td class="style2" style="text-align: left;">
                        <asp:dropdownlist id="ddl_Motivo_NoEstudia" runat="server" Enabled="False" 
                                Font-Size="X-Small" Width="90%" AutoPostBack="True" ></asp:dropdownlist>        
                        <asp:RegularExpressionValidator ID="rev_Motivo_NoEstudia" runat="server" ControlToValidate="ddl_Motivo_NoEstudia"
                        EnableClientScript="False" Enabled="False" ErrorMessage="Falta Motivo de No estudio"
                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                        </tr>

                        <tr><td  class="LabelCell" style="width: 25%">
                        <asp:Label id="lblCertificado_Matricula" runat="server" Width="90%">Certificado de Matricula</asp:Label>


                        </td><td class="ControlCell" style="width: 30%; text-align: left;">
                        <asp:dropdownlist id="ddl_Certificado_Matricula" runat="server" Font-Size="X-Small" 
                                    Width="90%" AutoPostBack="True" Enabled="False" ></asp:dropdownlist>        
                        <asp:RegularExpressionValidator ID="rev_Certificado" runat="server" ControlToValidate="ddl_Certificado_Matricula"
                        EnableClientScript="False" ErrorMessage="Falta el certificado de Matrícula"
                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE" ForeColor="Red" 
                                    Enabled="False">*</asp:RegularExpressionValidator></td>
                        <td class="ControlCell" style="width: 20%">
                        <asp:Label id="lblEstablecimiento" runat="server" Width="90%">Nombre Establecimiento</asp:Label></td>
                        <td class="ControlCell" style="width: 30%; text-align: left;">
                        <asp:TextBox id="txtEstablecimiento" runat = "server" Enabled="False" Width="90%"></asp:TextBox>      
                        <asp:RequiredFieldValidator ID="rfv_Establecimiento" runat="server" ControlToValidate="txtEstablecimiento"
                        Enabled="False" ErrorMessage="Falta el nombre del establecimiento" 
                                ValidationGroup="SE" ForeColor="Red">*</asp:RequiredFieldValidator>
                        </td>
                        </tr>
                        <tr>
                            <td class="LabelCell" style="width: 25%">
                                <asp:Label ID="lblDepartamentoInstituto" runat="server" Width="90%">Departamento del Instituto</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 30%; text-align: left;">
                                <asp:DropDownList ID="ddl_Departamento_Instituto" runat="server" 
                                    AutoPostBack="True" Enabled="False" Font-Size="X-Small" Width="90%">
                                </asp:DropDownList>
                            </td>
                            <td class="ControlCell" style="width: 20%">
                                <asp:Label ID="lblMunicipioInstituto" runat="server" Width="90%">Municipio Instituto</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 30%; text-align: left;">
                                <asp:DropDownList ID="ddl_municipio_Instituto" runat="server" Enabled="False" 
                                    Font-Size="X-Small" Width="90%">
                                </asp:DropDownList>
                                <asp:RegularExpressionValidator ID="rev_Municipio" runat="server" 
                                    ControlToValidate="ddl_municipio_Instituto" EnableClientScript="False" 
                                    ErrorMessage="Falta el Municipio del Instituto" ForeColor="Red" 
                                    ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE" Enabled="False">*</asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                        <td class="LabelCell" style="width: 25%">
                        <asp:Label id="lblSubTablasId_grado_escolar" runat="server" Width="90%">Grado Escolar</asp:Label></td>
                        <td class="ControlCell" style="width: 30%; text-align: left;">
                        <asp:dropdownlist id="ddl_grado_escolar" runat="server" Enabled="False" Font-Size="X-Small" Width="90%" ></asp:dropdownlist>        
                        <asp:RegularExpressionValidator ID="rev_GradoEscolar" runat="server" ControlToValidate="ddl_grado_escolar"
                        EnableClientScript="False" Enabled="False" ErrorMessage="Falta el grado escolar"
                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                        <td class="ControlCell" style="width: 20%">
                        <asp:Label id="lblSubTablasId_Seguimiento" runat="server" Width="90%">Realizar Seguimiento</asp:Label></td>
                        <td class="ControlCell" style="width: 30%; text-align: left;">
                        <asp:dropdownlist id="ddl_Seguimiento" runat="server" Font-Size="X-Small" Width="90%" Enabled="False" ></asp:dropdownlist></td>
                        </tr>
                        <tr>
                            <td class="LabelCell" style="width: 25%">
                                <asp:Label ID="Label2" runat="server" Width="90%">Verificado ante Entidad Estatal</asp:Label></td>
                            <td class="ControlCell" style="width: 30%">
                                <asp:RadioButtonList ID="rdb_verificacion" runat="server" RepeatDirection="Horizontal"
                                    Width="100px" AutoPostBack="True">
                                    <asp:ListItem Value="1">SI</asp:ListItem>
                                    <asp:ListItem Selected="True" Value="0">NO</asp:ListItem>
                                </asp:RadioButtonList></td>
                            <td class="ControlCell" style="width: 20%">
                                <asp:Label ID="Label3" runat="server" Width="90%">Municipio de Desplazamiento</asp:Label></td>
                            <td class="ControlCell" style="width: 30%" align="left">
                                <asp:Label ID="lbl_Municipio" runat="server" Width="90%" 
                                    style="color: #FF6600; font-weight: 700; background-color: #FFFF00">.</asp:Label></td>
                        </tr>
                        <tr>
                            <td class="LabelCell" style="width: 25%">
                                <asp:Label ID="Label4" runat="server" Width="90%">Observaciones</asp:Label>
                                <asp:CheckBox ID="chb_cerrado" runat="server" Enabled="False" Visible="False" /></td>
                            <td class="ControlCell" colspan="3" style="text-align: left">
                                <asp:TextBox ID="txt_observaciones" runat="server" Rows="5" TextMode="MultiLine"
                                    Width="90%"></asp:TextBox></td>
                        </tr>
                         <tr style="background-color: #F7F7F7;">
                            <td align="center" colspan="4"><asp:Button ID="btnGuardar" runat="server" 
                                    Text="Guardar" cssclass="Boton" Width="200px"/>
                                <asp:Button ID="btnNuevo" runat="server" Text="Nuevo Seguimiento" 
                                    cssclass="Boton" Width="200px"></asp:Button>
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
                                        <asp:label runat="server" id="lblno" text='<%# ctype(CType(Container.Parent.Parent.Parent,RadGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>' ToolTip = '<%#Container.DataItem.Id%>' />
                                        <asp:Label runat="Server" Id="lblid" Visible ="False" Text ='<%#Container.DataItem.Id%>'/>
                                        <asp:Label ID="lblTipoSeguimiento" runat="server" Text='<%# Container.DataItem.Id_Tipo_Entrega %>' Visible ="False"></asp:Label>
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
                            
                           <telerik:GridBoundColumn DataField="TipoSeguimiento" HeaderText="Tipo"
                                SortExpression="TipoSeguimiento" UniqueName="TipoSeguimiento" >
                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn>

                           <telerik:GridBoundColumn DataField="Estudia_Actualmente" HeaderText="Estudia Act"
                                SortExpression="Estudia_Actualmente" UniqueName="Estudia_Actualmente" >
                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn>

                           <telerik:GridBoundColumn DataField="Grado_Escolar" HeaderText="Grado Escolar"
                                SortExpression="Grado_Escolar" UniqueName="Grado_Escolar" >
                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn>

                           <telerik:GridBoundColumn DataField="Certificado" HeaderText="Certificado"
                                SortExpression="Certificado" UniqueName="Certificado" >
                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn>

                           <telerik:GridBoundColumn DataField="MotivoNoEstudia" HeaderText="Motivo No Estudio"
                                SortExpression="MotivoNoEstudia" UniqueName="MotivoNoEstudia" >
                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn>

                           <telerik:GridBoundColumn DataField="Seguimiento" HeaderText="Seguimiento"
                                SortExpression="Seguimiento" UniqueName="Seguimiento" >
                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            </telerik:GridBoundColumn>
                            
                           <telerik:GridBoundColumn DataField="Establecimiento" HeaderText="Establecimiento"
                                SortExpression="Establecimiento" UniqueName="Establecimiento" >
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
                    
                     <ExportSettings
                       HideStructureColumns="True" filename ="PersonasEducacion" ExportOnlyData="True" IgnorePaging="True" OpenInNewWindow="True">
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
            <telerik:AjaxSetting AjaxControlID="ddl_Estudia_Actualmente">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ddl_Motivo_NoEstudia" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rev_Motivo_NoEstudia" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_Certificado_Matricula" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rev_Certificado" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txtEstablecimiento" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rfv_Establecimiento" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_grado_escolar" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rev_GradoEscolar" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_Seguimiento" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ddl_Motivo_NoEstudia">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ddl_Certificado_Matricula" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rev_Certificado" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_Seguimiento" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ddl_Certificado_Matricula">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ddl_Seguimiento" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnGuardar">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ValidationSummary3" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="pnl_principal" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnNuevo">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="pnl_principal" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Rg_Listado">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="pnl_principal" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
</asp:Content>

