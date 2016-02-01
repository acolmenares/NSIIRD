<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="Raciones.aspx.vb" Inherits="WebForms_Raciones" %>
<%@ Register Src="../Controles/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" style="text-align: left" />
    <asp:Panel runat="server" ID="pnl_principal" DefaultButton ="btnGuardar" Width ="100%">
        <table id="Table2" cellspacing="0" cellpadding="0" border="0" class="ContentTable" style="width: 100%">
            <tr valign="top">
                <td style="width: 75%; text-align: left;"> 
                    <asp:Label ID="lbl_Titulo" runat="server" 
                        Text="CREACION / MODIFICACION DE RACIONES" Width="90%" CssClass="TitTitulo" 
                        BackColor="PeachPuff"></asp:Label><br />
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
                    <table id="TablaContenido" cellspacing="0" cellpadding="0" border="0" class="ContentTable" width="100%">
                        <tr valign ="top">
                            <td>
                                <table id="tblContenido" class="EditControlsTable" cellspacing="0" 
                                    cellpadding="0" border="0" width="100%">

                                    <tr  valign="top"><td  class="LabelCell" style="width: 25%">
                                    <asp:Label id="lblSubTablasProductoId_Producto" runat="server" Width="90%">Seleccione Producto</asp:Label>


                                    </td><td class="ControlCell" style="width: 25%; text-align: left;">
                                    <asp:dropdownlist id="ddl_Productos" runat="server" Font-Size="X-Small" Width="90%" ></asp:dropdownlist>&nbsp;<asp:RegularExpressionValidator 
                                                ID="rev_producto" runat="server"
                                        ControlToValidate="ddl_Productos" EnableClientScript="False" ErrorMessage="Falta Producto"
                                        ValidationExpression="^[1-9]+[0-9]*$" ForeColor="Red">*</asp:RegularExpressionValidator>



                                    </td>
                                        <td class="ControlCell" style="width: 25%">
                                            <asp:Label ID="lblCantidad" runat="server">Cantidad</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 25%; text-align: left;">
                                            <asp:TextBox ID="txtCantidad" runat="server" Font-Size="X-Small" MaxLength="5" 
                                                onkeypress="return ValNumero(this, event)" style="text-align: right"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfv_Cantidad" runat="server" 
                                                ControlToValidate="txtCantidad" EnableClientScript="False" 
                                                ErrorMessage="Falta Cantidad" ForeColor="Red">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>

                                    <tr  valign="top"><td  class="LabelCell" style="width: 25%;">
                                    <asp:Label id="lblFecha_Inicial" runat="server" Width="90%">Fecha Inicial</asp:Label>


                                    </td><td class="ControlCell" style="width: 25%; text-align: left;">
                                            <telerik:RadDatePicker ID="rdpFechaInicial" runat="server" 
                                                Culture="Spanish (Colombia)" MinDate="" Skin="WebBlue" 
                                                ToolTip="Seleccione Fecha ..." Width="90%">
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
                                            EnableClientScript="False" ErrorMessage="Falta Fecha Inicial" ForeColor="Red">*</asp:RequiredFieldValidator></td>
                                        <td class="ControlCell" style="width: 25%;">
                                            <asp:Label ID="lblSubTablasCapacidadId_Capacidad" runat="server">Unidad de Medida</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 25%; text-align: left;">
                                            <asp:DropDownList ID="ddl_Capacidad" runat="server" Font-Size="X-Small" 
                                                Width="90%">
                                            </asp:DropDownList>
                                            <asp:RegularExpressionValidator ID="rev_capacidad" runat="server" 
                                                ControlToValidate="ddl_Capacidad" EnableClientScript="False" 
                                                ErrorMessage="Falta Unidad de Medida" ForeColor="Red" 
                                                ValidationExpression="^[1-9]+[0-9]*$">*</asp:RegularExpressionValidator>
                                        </td>
                                    </tr>

                                    <tr  valign="top"><td  class="LabelCell" style="width: 25%">
                                    <asp:Label id="lblFecha_Final" runat="server" Width="90%">Fecha Final</asp:Label>


                                    </td><td class="ControlCell" style="width: 25%; text-align: left;">
                                            <telerik:RadDatePicker ID="rdpFechaFinal" runat="server" 
                                                Culture="Spanish (Colombia)" MinDate="" Skin="WebBlue" 
                                                ToolTip="Seleccione Fecha ..." Width="90%">
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
                                        <asp:RequiredFieldValidator ID="rfv_FechaFinal" runat="server" ControlToValidate="rdpFechaFinal"
                                            EnableClientScript="False" ErrorMessage="Falta Fecha Final" ForeColor="Red">*</asp:RequiredFieldValidator></td>
                                        <td class="ControlCell" style="width: 25%">
                                            <asp:Label ID="Label2" runat="server" Width="90%">Condición de Entrega</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 25%; text-align: left;">
                                            <asp:RadioButtonList ID="rdb_condicion" runat="server" RepeatColumns="1" 
                                                RepeatLayout="Flow" Width="100%">
                                                <asp:ListItem Value="F">Por Familia</asp:ListItem>
                                                <asp:ListItem Selected="True" Value="B">Por Beneficiario</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                    </tr>
                                    <tr  valign="top">
                                        <td class="LabelCell" colspan="4" style="background-color: #008080">
                                            <asp:Label ID="Label4" runat="server" Width="50%" 
                                                style="font-weight: 700; color: #FFFF66">Seleccione los tipos de entrega a los que aplica la ración</asp:Label></td>
                                    </tr>
                                    <tr  valign="top">
                                        <td class="LabelCell" colspan="4">
                                            <table style="width: 100%">
                                                <tr  valign="top">
                                                    <td rowspan="2" style="width: 45%">
                                                        <asp:ListBox ID="Lst_Tipos_Entrega" runat="server" SelectionMode="Multiple" Width="90%" Font-Size="X-Small" Rows="6">
                                                        </asp:ListBox></td>
                                                    <td align="center" style="width: 10%">
                                                        <asp:ImageButton ID="imb_cargar" runat="server" AlternateText="Cargar" CausesValidation="False"
                                                            ImageUrl="~/Images/fder.png" ToolTip="Cargar la Entrega" />
                                                    </td>
                                                    <td rowspan="2" style="width: 45%">
                                                        <asp:ListBox ID="lst_Tipos_Entrega_Racion" runat="server" SelectionMode="Multiple"
                                                            Width="90%" Font-Size="X-Small" Rows="6"></asp:ListBox></td>
                                                </tr>
                                                <tr  valign="top">
                                                    <td align="center" style="width: 10%">
                                                        <asp:ImageButton ID="imb_retirar" runat="server" AlternateText="Retirar" CausesValidation="False"
                                                            ImageUrl="~/Images/fizq.png" ToolTip="Retirar la Entrega" /></td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr  valign="top">
                                        <td class="LabelCell" colspan="4" style="background-color: #008080">
                                            <asp:Label ID="Label6" runat="server" Width="50%" 
                                                style="font-weight: 700; color: #FFFF00">Seleccione las lugares de entrega a los que aplica la ración</asp:Label></td>
                                    </tr>                                    
                                    <tr  valign="top">
                                        <td class="LabelCell" colspan="4">
                                            <table style="width: 100%">
                                                <tr  valign="top">
                                                    <td rowspan="2" style="width: 45%">
                                                        <asp:ListBox ID="Lst_Lugares" runat="server" SelectionMode="Multiple" 
                                                            Width="90%" Font-Size="X-Small" Rows="6">
                                                        </asp:ListBox></td>
                                                    <td align="center" style="width: 10%">
                                                        <asp:ImageButton ID="imb_cargar1" runat="server" AlternateText="Cargar" CausesValidation="False"
                                                            ImageUrl="~/Images/fder.png" ToolTip="Cargar la Regional" />
                                                    </td>
                                                    <td rowspan="2" style="width: 45%">
                                                        <asp:ListBox ID="Lst_Lugares_Racion" runat="server" SelectionMode="Multiple"
                                                            Width="90%" Font-Size="X-Small" Rows="6"></asp:ListBox></td>
                                                </tr>
                                                <tr  valign="top">
                                                    <td align="center" style="width: 10%">
                                                        <asp:ImageButton ID="imb_retirar1" runat="server" AlternateText="Retirar" CausesValidation="False"
                                                            ImageUrl="~/Images/fizq.png" ToolTip="Retirar la Regional" /></td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                         </tr>

                         <tr style="background-color: #F7F7F7;">
                            <td align="center">
                                <div>
                                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" cssClass="Boton"   Width="100px"></asp:Button>
                                    <asp:Button ID="btnGuardarOtro" runat="server" Text="Guardar y agregar otro" 
                                        cssClass="Boton" Width="150px"></asp:Button>
                                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" cssClass="Boton"  Width="100px"></asp:Button>
                                </div>
                            
                            </td>
                        </tr>
                        <tr style="background-color: #F7F7F7;">
                            <td align="center">
                                <asp:CheckBoxList ID="chb_tipofamilia" runat="server" ForeColor="#000099" 
                                    RepeatDirection="Horizontal" RepeatLayout="Flow">
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>3</asp:ListItem>
                                    <asp:ListItem>4</asp:ListItem>
                                    <asp:ListItem>5</asp:ListItem>
                                    <asp:ListItem>6</asp:ListItem>
                                    <asp:ListItem>7</asp:ListItem>
                                    <asp:ListItem>8</asp:ListItem>
                                    <asp:ListItem>9</asp:ListItem>
                                    <asp:ListItem>10</asp:ListItem>
                                    <asp:ListItem>11</asp:ListItem>
                                    <asp:ListItem>12</asp:ListItem>
                                    <asp:ListItem>13</asp:ListItem>
                                    <asp:ListItem>14</asp:ListItem>
                                    <asp:ListItem>15</asp:ListItem>
                                    <asp:ListItem>16</asp:ListItem>
                                    <asp:ListItem>17</asp:ListItem>
                                    <asp:ListItem>18</asp:ListItem>
                                    <asp:ListItem>19</asp:ListItem>
                                    <asp:ListItem>20</asp:ListItem>
                                </asp:CheckBoxList>
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

