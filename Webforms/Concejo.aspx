<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="Concejo.aspx.vb" Inherits="WebForms_Concejo" %>
<%@ Register Src="../Controles/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ValidationSummary ID="VS_Concejo" runat="server" ForeColor="Red" 
        style="text-align: left" />
    <asp:Panel runat="server" ID="pnl_principal" DefaultButton ="btnGuardar" Width ="100%">
        <table id="Table2" cellspacing="0" cellpadding="0" border="0" class="ContentTable" style="width: 100%">
            <tr valign="top">
            <td style="width: 75%; text-align: left;"> 
                <asp:Label ID="lbl_Titulo" runat="server" 
                    Text="Creación / Edición de Concejo/Resguardo/Cabildo/Grupo Indígena" Width="90%" 
                    CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
                <asp:Label ID="lblMensaje" runat="server" CssClass="TitMensaje" Text="_" 
                    Width="90%"/>
            </td>
            <td style="width: 25%" align="right">
                <asp:ImageButton ID="btn_actualizar" runat="server" ImageUrl="~/Images/Reload.jpg" ToolTip="Actualizar la vista actual." TabIndex="5" />
                <asp:ImageButton ID="btn_nuevo" runat="server" ImageUrl="~/Images/Add.jpg" ToolTip="Crear Nuevo Registro." TabIndex="6" />
                <asp:ImageButton ID="btn_cerrar" runat="server" ImageUrl="~/Images/Stop.jpg" ToolTip="Cerrar - Volver a la vista anterior." TabIndex="7" />
                <asp:ImageButton ID="btn_home" runat="server" ImageUrl="~/Images/Home.jpg" ToolTip="Ir al Inicio." TabIndex="8" />&nbsp;</td>
            </tr>

            <tr valign="top">
                <td>
                    <table id="Table4" class="EditControlsTable" cellspacing="0" cellpadding="0" 
                        border="0" width="100%">

                        <tr valign="top">
                            <td  class="style1" style="padding-left: 20px;">
                            <asp:Label id="lblDescripcion" runat="server" Width="98%">Nombre de Concejo/Resguardo/Cabildo/Grupo Indígena</asp:Label></td>
                            <td class="style1" style="width: 60%">
                            <asp:TextBox id="txtDescripcion" runat = "server" Width="200px" Font-Size="X-Small" 
                                    MaxLength="100"></asp:TextBox>
                                &nbsp;<asp:RequiredFieldValidator ID="rfv_descripcion" runat="server" 
                                    ControlToValidate="txtDescripcion" ErrorMessage="Falta el nombre del  Concejo/Resguardo/Cabildo/Grupo Indígena" 
                                    ForeColor="Red" EnableClientScript="False">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="style1" style="padding-left: 20px;">
                                <asp:Label ID="Label1" runat="server" Width="96%">Seleccione el Municipio</asp:Label></td>
                            <td class="style1" style="width: 60%; height: 19px;">
                                <asp:dropdownlist id="ddl_Municipios" runat="server" Width="300px" 
                                    Font-Size="X-Small" >
                                </asp:dropdownlist>&nbsp;<asp:RegularExpressionValidator ID="rev_TipoOrden" 
                                    runat="server" ControlToValidate="ddl_Municipios" 
                                    ErrorMessage="Falta Municipio de origen del concejo o resguardo" ForeColor="Red" 
                                    ValidationExpression="^[1-9]+[0-9]*$" EnableClientScript="False">*</asp:RegularExpressionValidator>
                            </td>
                        </tr>

                        <tr valign="top">
                            <td class="LabelCell" colspan="2" style="height: 19px;">
                                <asp:Panel ID="pnl_final0" runat="server" 
                                    style="vertical-align: middle; text-align: center" Width="100%">
                                    <table border="0" cellpadding="0" cellspacing="0" style="width: 90%">
                                        <tr valign="top">
                                            <td style="width: 15%; height: 16px;">
                                                <asp:Button ID="btnGuardar" runat="server" cssClass="Boton" TabIndex="1" 
                                                    Text="Guardar" Width="100px" />
                                            </td>
                                            <td style="width: 16%; height: 16px;">
                                                <asp:Button ID="btnGuardarOtro" runat="server" cssClass="Boton" TabIndex="2" 
                                                    Text="Guardar y agregar otro" Width="150px" />
                                            </td>
                                            <td style="width: 15%; height: 16px;">
                                                <asp:Button ID="btnEliminar" runat="server" CssClass="Boton" TabIndex="3" 
                                                    Text="Eliminar" Width="100px" />
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </td>
                        </tr>

                    </table>
 
                </td>
                <td style="width: 33%"></td>
            </tr>
        </table>
    
    </asp:Panel>                        
    <telerik:RadAjaxLoadingPanel ID="LoadingPanel2" runat="server" BackgroundPosition="Right"
        Height="0px" Transparency="50">
        <asp:Image ID="Image1" runat="server" AlternateText="Cargando..." ImageUrl="~/Images/loading.gif" />
        <telerik:RadScriptManager ID="RadScriptManager1" runat="server" />
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
                        <telerik:AjaxUpdatedControl ControlID="pnl_principal" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="btnGuardar">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="lblMensaje" />
                        <telerik:AjaxUpdatedControl ControlID="txtDescripcion" />
                        <telerik:AjaxUpdatedControl ControlID="ddl_Municipios" UpdatePanelCssClass="" />
                        <telerik:AjaxUpdatedControl ControlID="VS_Concejo" UpdatePanelCssClass="" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="btnGuardarOtro">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="lblMensaje" />
                        <telerik:AjaxUpdatedControl ControlID="txtDescripcion" />
                        <telerik:AjaxUpdatedControl ControlID="ddl_Municipios" />
                        <telerik:AjaxUpdatedControl ControlID="VS_Concejo" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="btnEliminar">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="lblMensaje" />
                        <telerik:AjaxUpdatedControl ControlID="txtDescripcion" />
                        <telerik:AjaxUpdatedControl ControlID="ddl_Municipios" UpdatePanelCssClass="" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
            </AjaxSettings>
        </telerik:RadAjaxManager>
    </telerik:RadAjaxLoadingPanel>
</asp:Content>

