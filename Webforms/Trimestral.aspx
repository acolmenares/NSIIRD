<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="Trimestral.aspx.vb" Inherits="WebForms_Trimestral" %>
<%@ Register Src="../Controles/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    <asp:Panel runat="server" ID="pnl_principal" DefaultButton ="btnGuardar" Width ="100%">
        <table id="Table2" cellspacing="0" cellpadding="0" border="0" class="ContentTable" style="width: 100%">
            <tr valign="top">
                <td style="width: 75%; text-align: left;"> 
                    <asp:Label ID="lbl_Titulo" runat="server" 
                        Text="CREACION / MODIFICACION DE TRIMESTRALES" Width="90%" CssClass="TitTitulo" 
                        BackColor="PeachPuff"></asp:Label><br />
                    <asp:Label ID="lblMensaje" runat="server" CssClass="TitMensaje" Text="_" Width="90%" Visible="False"/>
                </td>
                <td style="width: 25%" align="right">
                    <asp:ImageButton ID="btn_actualizar" runat="server" ImageUrl="~/Images/Reload.jpg" ToolTip="Actualizar la vista actual." TabIndex="5" />
                    <asp:ImageButton ID="btn_nuevo" runat="server" ImageUrl="~/Images/Add.jpg" 
                        ToolTip="Crear Nuevo Registro." TabIndex="6" Visible="False" />
                    <asp:ImageButton ID="btn_cerrar" runat="server" ImageUrl="~/Images/Stop.jpg" ToolTip="Cerrar - Volver a la vista anterior." TabIndex="7" />
                    <asp:ImageButton ID="btn_home" runat="server" ImageUrl="~/Images/Home.jpg" ToolTip="Ir al Inicio." TabIndex="8" />&nbsp;</td>
                </tr>

            <tr valign="top">
                <td>
                    <table id="TablaContenido" cellspacing="0" cellpadding="0" border="0" class="ContentTable" width="100%">
                        <tr valign="top">
                            <td colspan="1">
                                <table id="tblContenido" class="EditControlsTable" cellspacing="0" cellpadding="0" border="0">
                                    
<tr><td  class="LabelCell" style="width: 200px">
<asp:Label id="lblDescripcion" runat="server" Width="90%">Descripcion</asp:Label>


</td><td class="ControlCell" style="width: 400px">
<asp:TextBox id="txtDescripcion" runat = "server" MaxLength="100" Width="90%" Font-Size="X-Small"></asp:TextBox></td></tr>

<tr><td  class="LabelCell" style="width: 200px">
<asp:Label id="lblFecha_Inicial" runat="server" Width="90%">Fecha Inicial</asp:Label>


</td><td class="ControlCell" style="width: 400px">
        <telerik:RadDatePicker ID="rdpFechaInicial" runat="server" 
            Culture="Spanish (Colombia)" MinDate="" Skin="WebBlue" 
            ToolTip="Seleccione Fecha ..." Width="80%">
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
    <asp:RequiredFieldValidator ID="rfv_FechaInicial" runat="server" ControlToValidate="rdpFechaInicial"
        EnableClientScript="False" ErrorMessage="Falta Fecha Inicial" ForeColor="Red">*</asp:RequiredFieldValidator></td></tr>

<tr><td  class="LabelCell" style="width: 200px">
<asp:Label id="lblFecha_Final" runat="server" Width="90%">Fecha Final</asp:Label>


</td><td class="ControlCell" style="width: 400px">
        <telerik:RadDatePicker ID="rdpFechaFinal" runat="server" 
            Culture="Spanish (Colombia)" MinDate="" Skin="WebBlue" 
            ToolTip="Seleccione Fecha ..." Width="80%">
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
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="rdpFechaFinal"
        EnableClientScript="False" ErrorMessage="Falta Fecha Final" ForeColor="Red">*</asp:RequiredFieldValidator></td></tr>

                                </table>
                            </td>
                         </tr>
                        <tr valign="top">
                            <td>
                                <table id="tbl_grupos" runat="Server" style="width: 100%" border="0" cellpadding="2" cellspacing="1" >
                                    <tr>
                                        <td style="width: 40%; background-color: #ffcc66" align="center">
                                            <asp:Label ID="Label1" runat="server" Font-Bold="True" Width="48%">Grupos Libres sin Asignar</asp:Label></td>
                                        <td style="width: 5%; background-color: #ffffcc">
                                        </td>
                                        <td style="width: 40%; background-color: #ffcc66;" align="center">
                                            <asp:Label ID="Label2" runat="server" Font-Bold="True" Width="58%">Grupos Asignados al Trimestral</asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 40%" rowspan="2" valign="top">
                                            <asp:ListBox ID="List_GruposLibres" runat="server" Font-Size="X-Small" 
                                                SelectionMode="Multiple" Width="96%" Height="400px"></asp:ListBox></td>
                                        <td style="width: 5%; background-color: #eeeeee" align="center" valign="middle">
                                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/fder.png" /></td>
                                        <td style="width: 40%" rowspan="2" valign="top">
                                            <asp:ListBox ID="List_GruposActivos" runat="server" Font-Size="X-Small" 
                                                Width="96%" Height="400px"></asp:ListBox></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 5%; background-color: #eeeeee" align="center" valign="middle">
                                            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Images/fizq.png" /></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>

                    </table>
                </td>
                <td style="width: 25%" align="right">
                </td>
            </tr>
                    
        </table>
        <asp:Panel ID="pnl_final" runat="server" Width="100%" style="vertical-align: middle; text-align: center" >
            <table border="0" cellpadding="0" cellspacing="0" style="width: 90%">
                <tr valign="top">
                    <td style="width: 15%; height: 16px;">
                    </td>
                    <td style="width: 15%; height: 16px;">
                        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" cssClass="Boton" Width="100px" TabIndex="1"></asp:Button>
                    </td>
                    <td style="width: 16%; height: 16px;">
                        <asp:Button ID="btnGuardarOtro" runat="server" Text="Guardar y agregar otro" cssClass="Boton" Width="150px" TabIndex="2"></asp:Button>
                    </td>
                    <td style="width: 15%; height: 16px;">
                        &nbsp;</td>
                    <td style="width: 15%; height: 16px;">
                    </td>
                </tr>
            </table>
        </asp:Panel> 
    </asp:Panel>   
    
    
        <telerik:RadAjaxLoadingPanel ID="LoadingPanel2" runat="server" 
        BackgroundPosition="Right" Height="0px" Transparency="50">
        <asp:Image ID="Image1" runat="server" AlternateText="Cargando..." 
            ImageUrl="~/Images/loading.gif" />
            <telerik:RadScriptManager ID="RadScriptManager1" runat="server" />
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
            <telerik:AjaxSetting AjaxControlID="btnGuardar">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="pnl_principal" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnGuardarOtro">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="lblMensaje" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
</asp:Content>

