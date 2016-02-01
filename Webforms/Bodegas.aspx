<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="Bodegas.aspx.vb" Inherits="WebForms_Bodegas" %>
<%@ Register Src="../Controles/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ValidationSummary ID="VS" runat="server" style="color: #FF0000; text-align: left" />
    <asp:Panel runat="server" ID="pnl_principal" DefaultButton ="btnGuardar" Width ="100%">
        <table id="Table2" cellspacing="0" cellpadding="0" border="0" 
            class="ContentTable" style="width: 100%" align="left">
            <tr valign="top">
            <td style="width: 75%; text-align: left;"> 
                <asp:Label ID="lbl_Titulo" runat="server" 
                    Text="CREACION / MODIFICACION DE BODEGAS" Width="100%" CssClass="TitTitulo" 
                    BackColor="PeachPuff"></asp:Label><br />
                <asp:Label ID="lblMensaje" runat="server" CssClass="TitMensaje" Text="_" 
                    Width="100%" Visible="False"/>
            </td>
            <td style="width: 25%" align="right">
                <asp:ImageButton ID="btn_actualizar" runat="server" ImageUrl="~/Images/Reload.jpg" ToolTip="Actualizar la vista actual." TabIndex="5" />
                <asp:ImageButton ID="btn_nuevo" runat="server" ImageUrl="~/Images/Add.jpg" ToolTip="Crear Nuevo Registro." TabIndex="6" />
                <asp:ImageButton ID="btn_cerrar" runat="server" ImageUrl="~/Images/Stop.jpg" ToolTip="Cerrar - Volver a la vista anterior." TabIndex="7" />
                <asp:ImageButton ID="btn_home" runat="server" ImageUrl="~/Images/Home.jpg" ToolTip="Ir al Inicio." TabIndex="8" />&nbsp;</td>
            </tr>

            <tr valign="top">
                <td colspan="1" style="width: 75%">
                    <table id="tblContenido" class="EditControlsTable" cellspacing="0" 
                        cellpadding="0" border="0" align="left" width="100%">
                        <tr valign="top">
                            <td  class="LabelCell" style="width: 40%; padding-left: 20px;" align="left">
                                <asp:Label id="lblDescripcion" runat="server">Nombre de la Bodega</asp:Label></td>
                            <td class="ControlCell" style="width: 60%; text-align: left;">
                            <asp:TextBox id="txtDescripcion" runat = "server" Width="90%" Font-Size="X-Small" 
                                    MaxLength="100"></asp:TextBox>      
                            <asp:regularexpressionvalidator id="revDescripcion" runat="server" 
                                    EnableClientScript="False" 
                                    ErrorMessage="El valor ingresado para Descripcion no es válido"  
                                    ControlToValidate="txtDescripcion" ValidationExpression=".{0,100}" 
                                    ForeColor="Red">*</asp:regularexpressionvalidator>
                            <asp:RequiredFieldValidator ID="rfv_descripcion" runat="server" EnableClientScript="False"
                            ErrorMessage="Debe ingresar nombre de la bodega" 
                                    ControlToValidate="txtDescripcion" ForeColor="Red">*</asp:RequiredFieldValidator></td></tr>
                        <tr valign="top">
                            <td class="LabelCell" style="width: 40%; padding-left: 20px;" align="left">
                                <asp:Label ID="Label1" runat="server">Regional de la Bodega</asp:Label></td>
                            <td class="ControlCell" style="width: 60%; text-align: left;">
                                <asp:dropdownlist ID="ddl_Regional" runat="server" Font-Size="X-Small" 
                                    CssClass="drop01">
                                </asp:dropdownlist>
                                <asp:RegularExpressionValidator ID="rev_Regional" runat="server" ControlToValidate="ddl_Regional"
                                    EnableClientScript="False" ErrorMessage="Falta Regional de la Bodega" 
                                    ValidationExpression="^[1-9]+[0-9]*$" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                        </tr>

                        <tr valign="top">
                            <td align="left" class="LabelCell" style="width: 100%; padding-left: 20px;" 
                                colspan="2">
                            <asp:Panel ID="pnl_final" runat="server" Width="100%" style="vertical-align: middle; text-align: center" >
                                <table border="0" cellpadding="0" cellspacing="0" style="width: 90%">
                                    <tr valign="top">
                                        <td style="width: 15%; height: 16px;">
                                            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" cssClass="Boton" Width="100px" TabIndex="1"></asp:Button>
                                        </td>
                                        <td style="width: 16%; height: 16px;">
                                            <asp:Button ID="btnGuardarOtro" runat="server" Text="Guardar y agregar otro" cssClass="Boton" Width="150px" TabIndex="2"></asp:Button>
                                        </td>
                                        <td style="width: 15%; height: 16px;">
                                            <asp:Button ID="btnEliminar" runat="server" Text='Eliminar' CssClass="Boton" Width="100px" TabIndex="3"></asp:Button>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
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
        <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server" 
            DefaultLoadingPanelID="LoadingPanel2">
            <AjaxSettings>
                <telerik:AjaxSetting AjaxControlID="btn_actualizar">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="pnl_principal" UpdatePanelCssClass="" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="btnGuardar">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="VS" UpdatePanelCssClass="" />
                        <telerik:AjaxUpdatedControl ControlID="lblMensaje" UpdatePanelCssClass="" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="btnGuardarOtro">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="VS" UpdatePanelCssClass="" />
                        <telerik:AjaxUpdatedControl ControlID="lblMensaje" UpdatePanelCssClass="" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="btnEliminar">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="VS" UpdatePanelCssClass="" />
                        <telerik:AjaxUpdatedControl ControlID="lblMensaje" UpdatePanelCssClass="" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
            </AjaxSettings>
        </telerik:RadAjaxManager>
    </telerik:RadAjaxLoadingPanel>

</asp:Content>

