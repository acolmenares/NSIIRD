<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="LugarEntrega.aspx.vb" Inherits="WebForms_LugarEntrega" %>
<%@ Register Src="../Controles/Header.ascx" TagName="Header" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    <asp:Panel runat="server" ID="pnl_principal" DefaultButton ="btnGuardar" Width ="100%">
        <table id="Table2" cellspacing="0" cellpadding="0" border="0" class="ContentTable" style="width: 100%">
            <tr valign="top">
                <td style="width: 75%"> 
                    <asp:Label ID="lbl_Titulo" runat="server" Text="CREACION / MODIFICACION DE LUGARES DE ENTREGA" Width="90%" CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
                    <asp:Label ID="lblMensaje" runat="server" CssClass="TitMensaje" Text="_" Width="90%" Visible="False"/>
                </td>
                <td style="width: 25%" align="right">
                    <asp:ImageButton ID="btn_actualizar" runat="server" ImageUrl="~/Images/Reload.jpg" ToolTip="Actualizar la vista actual." TabIndex="5" />
                    <asp:ImageButton ID="btn_nuevo" runat="server" ImageUrl="~/Images/Add.jpg" ToolTip="Crear Nuevo Registro." TabIndex="6" />
                    <asp:ImageButton ID="btn_cerrar" runat="server" ImageUrl="~/Images/Stop.jpg" ToolTip="Cerrar - Volver a la vista anterior." TabIndex="7" />
                    <asp:ImageButton ID="btn_home" runat="server" ImageUrl="~/Images/Home.jpg" ToolTip="Ir al Inicio." TabIndex="8" />&nbsp;</td>
                </tr>

            <tr valign="top">
                <td>
                    <table id="TablaContenido" cellspacing="0" cellpadding="0" border="0" class="ContentTable" style="width: 100%">
                        <tr valign="top">
                            <td style="width: 100%">
                                <table id="tblContenido" class="EditControlsTable" cellspacing="0" 
                                    cellpadding="0" border="0" width="100%">

                                    <tr valign="top"><td  class="LabelCell" style="width: 40%; height: 21px;">
                                    <asp:Label id="lblDescripcion" runat="server" Width="90%">Nombre de Lugar de Entrega</asp:Label></td><td class="ControlCell" style="width: 60%; height: 21px;">
                                    <asp:TextBox id="txtDescripcion" runat = "server" Width="200px" Font-Size="X-Small" MaxLength="100"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfv_Nombre" runat="server" ControlToValidate="txtDescripcion"
                                            EnableClientScript="False" 
                                                ErrorMessage="Debe digitar nombre de lugar de entrega" ForeColor="Red">*</asp:RequiredFieldValidator></td></tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 40%">
                                            <asp:Label ID="Label1" runat="server" Width="90%">Regional</asp:Label></td>
                                        <td class="ControlCell" style="width: 60%">
                                            <asp:dropdownlist id="ddl_Regional" runat="server" Width="200px" Font-Size="X-Small" />
                                            
                                            <asp:RegularExpressionValidator ID="rev_Regional" runat="server" ControlToValidate="ddl_Regional"
                                                EnableClientScript="False" ErrorMessage="Debe ingresar la regional a la que aplica"
                                                ValidationExpression="^[1-9]+[0-9]*$" ForeColor="Red">*</asp:RegularExpressionValidator></td>
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
                        <asp:Button ID="btnEliminar" runat="server" Text='Eliminar' CssClass="Boton" Width="100px" TabIndex="3"></asp:Button>
                    </td>
                    <td style="width: 15%; height: 16px;">
                        <asp:Button ID="btnCerrar" runat="server" Text="Cerrar" cssClass="Boton" 
                            Width="100px" TabIndex="4" CausesValidation="False"></asp:Button>
                    </td>
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
            <telerik:AjaxSetting AjaxControlID="btnGuardar">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ValidationSummary1" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="pnl_principal" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnGuardarOtro">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ValidationSummary1" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="pnl_principal" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnEliminar">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ValidationSummary1" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="pnl_principal" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>     
                              
</asp:Content>

