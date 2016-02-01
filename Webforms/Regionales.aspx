<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="Regionales.aspx.vb" Inherits="WebForms_Regionales" %>
<%@ Register Src="../Controles/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    <asp:Panel runat="server" ID="pnl_principal" DefaultButton ="btnGuardar" Width ="100%">
        <table id="Table2" cellspacing="0" cellpadding="0" border="0" class="ContentTable" style="width: 100%">
            <tr valign="top">
                <td style="width: 75%"> 
                    <asp:Label ID="lbl_Titulo" runat="server" Text="CREACION / MODIFICACION DE REGIONALES" Width="90%" CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
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
                    
                    <table id="TablaContenido" cellspacing="0" cellpadding="0" border="0" class="ContentTable" width="80%">
                        <tr valign="top">
                            <td>
                                <table id="tblContenido" class="EditControlsTable" cellspacing="0" cellpadding="0" border="0">
                                    
<tr valign="top"><td  class="LabelCell" style="width: 200px">
<asp:Label id="lblDescripcion" runat="server">Descripción</asp:Label>


</td><td class="ControlCell" style="width: 400px">
<asp:TextBox id="txtDescripcion" runat = "server" Width="90%"></asp:TextBox>      



<asp:regularexpressionvalidator id="revDescripcion" runat="server" 
            EnableClientScript="False" 
            ErrorMessage="El valor ingresado para Descripcion no es válido"  
            ControlToValidate="txtDescripcion" ValidationExpression=".{0,100}" 
            ForeColor="Red">*</asp:regularexpressionvalidator>
    <asp:RequiredFieldValidator ID="rfv_descripcion" runat="server" 
            ErrorMessage="Falta Digitar el Nombre de la Regional" 
            ControlToValidate="txtDescripcion" ForeColor="Red">*</asp:RequiredFieldValidator></td></tr>

                                </table>
                            </td>
                        </tr>
                        <tr style="background-color: #F7F7F7;">
                            <td align="center">
                            <div>
                                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" cssclass="Boton" />
                                <asp:Button ID="btnGuardarOtro" runat="server" Text="Guardar y agregar otro" cssclass="Boton" />
                                <asp:Button ID="btnEliminar" runat="server" Text='Eliminar' Cssclass="Boton"/>
                             </div>

                            </td>
                        </tr>
                    </table>
                 
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

