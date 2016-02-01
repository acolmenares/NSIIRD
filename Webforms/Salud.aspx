<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="Salud.aspx.vb" Inherits="WebForms_Salud" %>
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
    <asp:ValidationSummary ID="ValidationSummaryGVG" runat="server" 
        ValidationGroup="GVG" ForeColor="Red" style="text-align: left" />
    <asp:ValidationSummary ID="ValidationSummaryGV1" runat="server" 
        ValidationGroup="GV1" ForeColor="Red" style="text-align: left" />
    <asp:ValidationSummary ID="ValidationSummaryGV2" runat="server" 
        ValidationGroup="GV2" ForeColor="Red" style="text-align: left" />
    <asp:Panel runat="server" ID="pnl_principal" DefaultButton="btnGuardar" Width="100%">
        <table id="Table3" cellspacing="0" cellpadding="0" border="0" class="ContentTable"
            style="width: 100%">
            <tr valign="top">
                <td style="width: 75%; text-align: left;">
                    <asp:Label ID="lbl_Titulo" runat="server" Text="CREACION / MODIFICACION DE VALORACION DE NIÑOS"
                        Width="90%" CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
                    <asp:Label ID="lblMensaje" runat="server" CssClass="TitMensaje" Text="_" Width="90%"
                        Visible="False" />
                </td>
                <td style="width: 25%" align="right">
                    <asp:ImageButton ID="btn_actualizar" runat="server" ImageUrl="~/Images/Reload.jpg"
                        ToolTip="Actualizar la vista actual." TabIndex="5" />
                    <asp:ImageButton ID="btn_nuevo" runat="server" ImageUrl="~/Images/Add.jpg" ToolTip="Crear Nuevo Registro."
                        TabIndex="6" Visible="False" />
                    <asp:ImageButton ID="btn_cerrar" runat="server" ImageUrl="~/Images/Stop.jpg" ToolTip="Cerrar - Volver a la vista anterior."
                        TabIndex="7" />
                    <asp:ImageButton ID="btn_home" runat="server" ImageUrl="~/Images/Home.jpg" ToolTip="Ir al Inicio."
                        TabIndex="8" />&nbsp;
                </td>
            </tr>
            <tr valign="top">
                <td colspan="2">
                    <table id="TablaContenido" cellspacing="0" cellpadding="0" border="0" class="ContentTable"
                        style="width: 100%">
                        <tr valign="top">
                            <td>
                                <table id="tblContenido" class="EditControlsTable" cellspacing="0" cellpadding="0"
                                    border="0" width="100%">
                                    <tr valign="top">
                                        <td class="LabelCell" colspan="6" style="background-color: orange">
                                            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="False" Font-Overline="False"
                                                Font-Underline="False">INFORMACION GENERAL DEL NIÑO</asp:Label>
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 15%;">
                                            <asp:Label ID="lblPersonas" runat="server" Width="96%">Nombre del Niño(a)</asp:Label>
                                        </td>
                                        <td class="ControlCell" colspan="3" style="width: 55%">
                                            <asp:Label ID="lbl_Nombre_completo" runat="server" Font-Bold="True" ForeColor="#C04000"
                                                Font-Size="Medium"></asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 15%;">
                                            <asp:Label ID="Label1" runat="server" Width="96%">Fecha de Nacimiento</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 15%; text-align: left;">
                                            <asp:Label ID="lbl_Fecha_Nacimiento" runat="server" Font-Bold="True" ForeColor="#C04000"
                                                Font-Size="Medium">0</asp:Label>
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 15%; vertical-align: middle; text-align: left;"
                                            align="center" rowspan="2">
                                            <asp:Label ID="lblPatologia" runat="server" Width="96%">Patología</asp:Label>
                                        </td>
                                        <td class="ControlCell" colspan="3" style="width: 55%; text-align: left;" 
                                            rowspan="2">
                                            <asp:TextBox ID="txtPatologia" runat="server" Font-Size="X-Small" Width="96%" MaxLength="200"
                                                Rows="3" TextMode="MultiLine" TabIndex="1"></asp:TextBox>
                                        </td>
                                        <td class="ControlCell" style="width: 15%">
                                            <asp:Label ID="lblSubTablasId_Lactancia_Lactando" runat="server" Width="96%">Esta Lactando?</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 15%; text-align: left;">
                                            <asp:DropDownList ID="ddlId_Lactancia_Lactando" runat="server" Font-Size="X-Small"
                                                Width="90%" TabIndex="3">
                                            </asp:DropDownList>
                                            <asp:RegularExpressionValidator ID="revId_Lactancia_Lactando" runat="server" EnableClientScript="False"
                                                ErrorMessage="El valor ingresado para Lactancia no es válido" ControlToValidate="ddlId_Lactancia_Lactando"
                                                ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GVG" ForeColor="Red">*</asp:RegularExpressionValidator>
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="ControlCell" style="width: 15%;">
                                            <asp:Label ID="lblLactancia_meses" runat="server" Width="96%">Total Meses Lactancia</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 15%; text-align: left;">
                                            <asp:TextBox ID="txtLactancia_meses" runat="server" onkeypress="return ValNumero(this, event)"
                                                Width="90%" Font-Size="X-Small" MaxLength="2" TabIndex="4"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 16%; text-align: left;">
                                            <asp:Label ID="lblSubTablasId_Crecimiento_Desarrollo" runat="server" Width="96%">Crecimiento y Desarrollo</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 16%; text-align: left;">
                                            <asp:DropDownList ID="ddl_Crecimiento_Desarrollo" runat="server" Font-Size="X-Small"
                                                Width="90%" TabIndex="2" AutoPostBack="True">
                                            </asp:DropDownList>
                                            <asp:RegularExpressionValidator ID="revId_Crecimiento_Desarrollo" runat="server"
                                                ControlToValidate="ddl_Crecimiento_Desarrollo" EnableClientScript="False" ErrorMessage="El valor ingresado para Crecimiento y Desarrollo no es válido"
                                                ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GVG" 
                                                ForeColor="Red">*</asp:RegularExpressionValidator>
                                        </td>
                                        <td class="ControlCell" style="width: 16%; text-align: left;">
                                            <asp:Label ID="Label11" runat="server" Width="96%">Motivo de NO CYD</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 16%; text-align: left;">
                                            <asp:DropDownList ID="ddl_Motivo_Crecimiento_Desarrollo" runat="server" Font-Size="X-Small"
                                                Width="90%" TabIndex="2">
                                            </asp:DropDownList>
                                            <asp:RegularExpressionValidator ID="rev_Motivo_CYD" runat="server" ControlToValidate="ddl_Motivo_Crecimiento_Desarrollo"
                                                EnableClientScript="False" ErrorMessage="El valor ingresado para Motivo No Crecimiento y Desarrollo no es válido"
                                                ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GVG" 
                                                ForeColor="Red">*</asp:RegularExpressionValidator>
                                        </td>
                                        <td class="ControlCell" style="width: 16%; text-align: left;">
                                            <asp:Label ID="lblSubTablasId_Lactancia_Exclusiva" runat="server" Width="96%">Lactancia Exclusiva</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 16%;" align="left">
                                            <asp:TextBox ID="txtLactancia_Exclusiva" runat="server" onkeypress="return ValNumero(this, event)"
                                                Width="14%" Font-Size="X-Small" MaxLength="2" TabIndex="5"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtLactancia_Exclusiva"
                                                EnableClientScript="False" ErrorMessage="Debe ingresar datos a Meses de lactancia Esclusiva"
                                                ValidationGroup="GVG" ForeColor="Red">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 16%; text-align: left;">
                                            <asp:Label ID="Label33" runat="server" Width="96%">Crecimiento y Desarrollo despues de IRD</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 16%; text-align: left;">
                                            <asp:DropDownList ID="ddl_Crecimiento_Desarrollo_IRD" runat="server" Font-Size="X-Small"
                                                Width="90%" TabIndex="2" AutoPostBack="True">
                                            </asp:DropDownList>
                                        </td>
                                        <td class="ControlCell" style="width: 16%; text-align: left;">
                                            <asp:Label ID="Label34" runat="server" Width="96%">Motivo de NO CYD IRD</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 16%; text-align: left;">
                                            <asp:DropDownList ID="ddl_Motivo_Crecimiento_Desarrollo_IRD" runat="server" Font-Size="X-Small"
                                                Width="90%" TabIndex="2">
                                            </asp:DropDownList>
                                        </td>
                                        <td class="ControlCell" style="width: 16%; text-align: left;">
                                            <asp:Label ID="Label22" runat="server" Width="96%">Grupo</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 16%; text-align: left;">
                                            &nbsp;<asp:Label ID="lbl_Grupo" runat="server" Font-Bold="True" ForeColor="#C04000"
                                                Font-Size="Medium">0</asp:Label>
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 100%; background-color: orange" colspan="6">
                                            <asp:Label ID="Label10" runat="server">Información de Vacunación</asp:Label>
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 15%">
                                            <asp:Label ID="lblSubTablasId_Vacunacion_Carnet" runat="server" Width="96%">Tiene  Carnet de Vacunación?</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 20%; text-align: left;">
                                            <asp:DropDownList ID="ddl_Vacunacion_Carnet" runat="server" Font-Size="X-Small" Width="90%"
                                                AutoPostBack="True" TabIndex="8">
                                            </asp:DropDownList>
                                            <asp:RegularExpressionValidator ID="revId_Vacunacion_Carnet" runat="server" EnableClientScript="False"
                                                ErrorMessage="El valor ingresado para Vacunacion Carnet no es válido" ControlToValidate="ddl_Vacunacion_Carnet"
                                                ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GVG" ForeColor="Red">*</asp:RegularExpressionValidator>
                                        </td>
                                        <td class="ControlCell" style="width: 15%">
                                            <asp:Label ID="lblSubTablasId_Razon_No_Carnet" runat="server" Width="96%">Motivo por el cuál no tiene el Carnet</asp:Label>
                                        </td>
                                        <td class="ControlCell" colspan="2" style="width: 35%; text-align: left;">
                                            <asp:DropDownList ID="ddl_Razon_No_Carnet" runat="server" Font-Size="X-Small" Width="90%"
                                                TabIndex="9">
                                            </asp:DropDownList>
                                            <asp:RegularExpressionValidator ID="rev_Razon_No_Carnet" runat="server" ControlToValidate="ddl_Razon_No_Carnet"
                                                EnableClientScript="False" Enabled="False" ErrorMessage="El valor ingresado para Razon de No carnet no es válido"
                                                ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GVG" ForeColor="Red">*</asp:RegularExpressionValidator>
                                        </td>
                                        <td class="ControlCell" style="width: 15%">
                                            &nbsp;<asp:Label ID="lblidsalud" runat="server" Width="96%" Visible="False"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 15%">
                                            <asp:Label ID="lblSubTablasId_Esquema_Vacunacion_Completo" runat="server" Width="96%">Tiene el Esquema Vacunación Completo?</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 20%; text-align: left;">
                                            <asp:DropDownList ID="ddl_Esquema_Vacunacion_Completo" runat="server" Font-Size="X-Small"
                                                Width="90%" AutoPostBack="True" TabIndex="10">
                                            </asp:DropDownList>
                                            <asp:RegularExpressionValidator ID="revId_Esquema_Vacunacion_Completo" runat="server"
                                                EnableClientScript="False" ErrorMessage="El valor ingresado para Esquema Vacunación Completo no es válido"
                                                ControlToValidate="ddl_Esquema_Vacunacion_Completo" ValidationExpression="^[1-9]+[0-9]*$"
                                                ValidationGroup="GVG" ForeColor="Red">*</asp:RegularExpressionValidator>
                                        </td>
                                        <td class="ControlCell" style="width: 15%">
                                            <asp:Label ID="lblSubTablasId_Razon_No_Vacunacion_Completo" runat="server" Width="96%">Razon No Vacunación Completo</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 35%; text-align: left;" colspan="2">
                                            <asp:DropDownList ID="ddl_Razon_No_Vacunacion_Completo" runat="server" Font-Size="X-Small"
                                                Width="90%" TabIndex="11">
                                            </asp:DropDownList>
                                            <asp:RegularExpressionValidator ID="Rev_Razon_No_Vacunacion_Completo" runat="server"
                                                ControlToValidate="ddl_Razon_No_Vacunacion_Completo" EnableClientScript="False"
                                                Enabled="False" ErrorMessage="El valor ingresado para Razon de No vacunación completa no es válido"
                                                ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GVG" ForeColor="Red">*</asp:RegularExpressionValidator>
                                        </td>
                                        <td class="ControlCell" style="width: 15%">
                                            <asp:Label ID="lblFecha_Esquema_Vacunacion" runat="server" Width="96%">Fecha Validación IRD Vacunación</asp:Label>
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 15%">
                                            <asp:Label ID="lblSubTablasId_Ninos_Vacunados" runat="server" Width="96%">Despues de IRD tiene las vacunas al Dia?</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 20%; text-align: left;">
                                            <asp:DropDownList ID="ddl_Ninos_Vacunados" runat="server" Font-Size="X-Small" Width="90%"
                                                AutoPostBack="True" TabIndex="12">
                                            </asp:DropDownList>
                                        </td>
                                        <td class="ControlCell" style="width: 15%">
                                            <asp:Label ID="lblSubTablasId_Motivo_No_Vacunados" runat="server" Width="96%">Motivo por el cual no estan las vacunas al día?</asp:Label>
                                        </td>
                                        <td class="ControlCell" colspan="2" style="width: 35%; text-align: left;">
                                            <asp:DropDownList ID="ddl_Motivo_No_Vacunados" runat="server" Font-Size="X-Small"
                                                Width="90%" TabIndex="13">
                                            </asp:DropDownList>
                                            <asp:RegularExpressionValidator ID="revMotivo_No_Vacunados" runat="server" ControlToValidate="ddl_Motivo_No_Vacunados"
                                                EnableClientScript="False" Enabled="False" ErrorMessage="El valor ingresado para Motivo de No vacunados no es válido"
                                                ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GVG" ForeColor="Red">*</asp:RegularExpressionValidator>
                                        </td>
                                        <td class="ControlCell" style="width: 15%">
                                            <telerik:RadDatePicker ID="rdpfecha_Vacunacion" runat="server" Culture="Spanish (Colombia)"
                                                MinDate="" Skin="WebBlue" TabIndex="1" ToolTip="Seleccione Fecha ..." 
                                                Width="90%">
                                                <Calendar Skin="WebBlue" UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False"
                                                    ViewSelectorText="x">
                                                    <FastNavigationSettings CancelButtonCaption="Cancelar" DateIsOutOfRangeMessage="Fecha Fuera de Rango"
                                                        TodayButtonCaption="Hoy">
                                                    </FastNavigationSettings>
                                                </Calendar>
                                                <DatePopupButton HoverImageUrl="" ImageUrl="" TabIndex="1" ToolTip="Abrir el Calendario" />
                                                <DateInput DateFormat="dd/MM/yyyy" DisplayDateFormat="dd/MMMM/yyyy" EmptyMessage="Fecha ..."
                                                    TabIndex="1">
                                                    <EmptyMessageStyle Resize="None" />
                                                    <ReadOnlyStyle Resize="None" />
                                                    <FocusedStyle Resize="None" />
                                                    <DisabledStyle Resize="None" />
                                                    <InvalidStyle Resize="None" />
                                                    <HoveredStyle Resize="None" />
                                                    <EnabledStyle Resize="None" />
                                                </DateInput>
                                            </telerik:RadDatePicker>
                                            <asp:RequiredFieldValidator ID="rfv_Fecha_Esquema_Vacunacion" runat="server" ControlToValidate="rdpfecha_Vacunacion"
                                                EnableClientScript="False" Enabled="False" ErrorMessage="Se debe diligenciar la fecha de Validación IRD"
                                                ValidationGroup="GVG" ForeColor="Red">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 15%">
                                            <asp:Label ID="lblObservaciones" runat="server" Width="96%">Observaciones</asp:Label>
                                        </td>
                                        <td class="ControlCell" colspan="5" style="text-align: left">
                                            <asp:TextBox ID="txtObservaciones" runat="server" Width="96%" Rows="4" TextMode="MultiLine"
                                                MaxLength="400" TabIndex="15" style="text-align: left"></asp:TextBox>
                                            <asp:RegularExpressionValidator ID="revObservaciones" runat="server" EnableClientScript="False"
                                                ErrorMessage="El valor ingresado para Observaciones no es válido" ControlToValidate="txtObservaciones"
                                                ValidationExpression=".{0,400}" ValidationGroup="GVG" ForeColor="Red">*</asp:RegularExpressionValidator>&nbsp;
                                        </td>
                                    </tr>
                                    <tr style="background-color: #F7F7F7;">
                                        <td colspan="6" align="center">
                                            <asp:Button ID="btnGuardar" runat="server" Text="Guardar Información" CssClass="Boton"
                                                ToolTip="Guardar Información de Salud" TabIndex="17"></asp:Button>
                                            <asp:Button ID="btnGuardarOtro" runat="server" Text="Guardar y agregar otro" CssClass="Boton"
                                                Visible="False" TabIndex="18"></asp:Button>
                                            <asp:Button ID="btnEliminar" runat="server" Text='Eliminar' Visible="False" CssClass="Boton"
                                                TabIndex="19"></asp:Button>
                                            <asp:CheckBox ID="Chb_Cerrado" runat="server" Enabled="False" Text="Registro Cerrado" />
                                        </td>
                                    </tr>
                                </table>
                                <br />
 
                                <table id="Table1" border="0" cellpadding="0" cellspacing="0" class="EditControlsTable"
                                    width="100%">
                                    <tr valign="top">
                                        <td align="center" class="LabelCell" colspan="4" style="width: 100%; background-color: activecaption">
                                            <asp:Label ID="Label31" runat="server" Font-Bold="True" ForeColor="Navy">INFORMACION GENERAL DE PESO Y TALLA DE LOS NIÑOS</asp:Label>
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 25%">
                                            <asp:Label ID="Label32" runat="server" Width="96%">Tipo de Valoración</asp:Label>
                                        </td>
                                        <td class="LabelCell" style="width: 25%; text-align: left;">
                                            <asp:DropDownList ID="ddl_Tipo_Proceso" runat="server" Font-Size="X-Small" Width="90%"
                                                TabIndex="21" style="text-align: left">
                                            </asp:DropDownList>
                                            <asp:RegularExpressionValidator ID="rev_Tipo_Proceso" runat="server" ControlToValidate="ddl_Tipo_Proceso"
                                                EnableClientScript="False" ErrorMessage="Falta Tipo de Proceso" ValidationExpression="^[1-9]+[0-9]*$"
                                                ValidationGroup="GV1" ForeColor="Red">*</asp:RegularExpressionValidator>
                                        </td>
                                        <td class="LabelCell" style="width: 25%">
                                        </td>
                                        <td align="center" class="LabelCell" style="width: 25%">
                                            <asp:CheckBox ID="Chb_Cerrado_Valoracion" runat="server" Enabled="False" Text="Registro Cerrado" />
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 25%">
                                            <asp:Label ID="lblFecha_Valoracion" runat="server" Width="96%">Fecha de Valoración</asp:Label>
                                        </td>
                                        <td class="LabelCell" style="width: 25%; text-align: left;">
                                            <telerik:RadDatePicker ID="rdpfechaValoracion" runat="server" Culture="Spanish (Colombia)"
                                                MinDate="" Skin="WebBlue" TabIndex="1" ToolTip="Seleccione Fecha ..." 
                                                Width="95%" style="text-align: left">
                                                <Calendar Skin="WebBlue" UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False"
                                                    ViewSelectorText="x">
                                                    <FastNavigationSettings CancelButtonCaption="Cancelar" DateIsOutOfRangeMessage="Fecha Fuera de Rango"
                                                        TodayButtonCaption="Hoy">
                                                    </FastNavigationSettings>
                                                </Calendar>
                                                <DatePopupButton HoverImageUrl="" ImageUrl="" TabIndex="1" ToolTip="Abrir el Calendario" />
                                                <DateInput DateFormat="dd/MM/yyyy" DisplayDateFormat="dd/MMMM/yyyy" EmptyMessage="Fecha ..."
                                                    TabIndex="1">
                                                    <EmptyMessageStyle Resize="None" />
                                                    <ReadOnlyStyle Resize="None" />
                                                    <FocusedStyle Resize="None" />
                                                    <DisabledStyle Resize="None" />
                                                    <InvalidStyle Resize="None" />
                                                    <HoveredStyle Resize="None" />
                                                    <EnabledStyle Resize="None" />
                                                </DateInput>
                                            </telerik:RadDatePicker>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="rdpfechaValoracion"
                                                EnableClientScript="False" ErrorMessage="Falta Fecha de Atención" ValidationGroup="GV1"
                                                ForeColor="Red">*</asp:RequiredFieldValidator>
                                        </td>
                                        <td class="LabelCell" style="width: 25%">
                                            <asp:Label ID="Label18" runat="server" Width="96%">Edad Actual</asp:Label>
                                        </td>
                                        <td class="LabelCell" style="width: 25%" align="center">
                                            <asp:Label ID="Lbl_Edad_Anos_Actual" runat="server" Text="0" Font-Size="Medium"></asp:Label>
                                            <asp:Label ID="Label19" runat="server" Text="Años" Font-Size="Medium"></asp:Label>
                                            <asp:Label ID="Lbl_Edad_Meses_Actual" runat="server" Text="0" Font-Size="Medium"></asp:Label>
                                            <asp:Label ID="Label20" runat="server" Text="Meses" Font-Size="Medium"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" colspan="2" 
                                            style="width: 50%; background-color: lightsalmon; text-align: left;">
                                            <asp:Label ID="Label138" runat="server" Font-Bold="True" ForeColor="Navy">Datos Antropométricos</asp:Label>
                                        </td>
                                        <td class="LabelCell" colspan="2" style="width: 50%; background-color: lightsalmon">
                                        </td>
                                        <td class="LabelCell" colspan="2" style="width: 50%; background-color: lightsalmon">
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 25%;">
                                            <asp:Label ID="Label77" runat="server" Width="96%">Peso</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 25%; text-align: left;">
                                            <asp:TextBox ID="txt_peso" onkeypress="return ValNumero(this, event)" runat="server"
                                                Width="90%" Style="text-align: right" Font-Size="X-Small" MaxLength="7" TabIndex="23"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfv_peso" runat="server" ControlToValidate="txt_peso"
                                                EnableClientScript="False" ErrorMessage="Se debe diligenciar el peso" ValidationGroup="GV1"
                                                ForeColor="Red">*</asp:RequiredFieldValidator>
                                        </td>
                                        <td class="ControlCell" style="width: 25%;">
                                            <asp:Label ID="Label79" runat="server" Width="96%">Peso para la Talla</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 25%; text-align: left;">
                                            <asp:TextBox ID="txt_peso_talla" runat="server" Width="90%" onkeypress="return ValNumero(this, event)"
                                                Font-Size="X-Small" Style="text-align: right" MaxLength="7" TabIndex="26"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfv_Peso_Talla" runat="server" ControlToValidate="txt_peso_talla"
                                                EnableClientScript="False" ErrorMessage="Se debe diligenciar peso par la talla"
                                                ValidationGroup="GV1" ForeColor="Red">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 25%">
                                            <asp:Label ID="Label81" runat="server" Width="96%">Talla</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 25%; text-align: left;">
                                            <asp:TextBox ID="txt_talla" runat="server" Width="90%" onkeypress="return ValNumero(this, event)"
                                                Font-Size="X-Small" Style="text-align: right" MaxLength="7" TabIndex="24"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfv_Talla" runat="server" ControlToValidate="txt_talla"
                                                EnableClientScript="False" ErrorMessage="Se debe diligenciar la talla" ValidationGroup="GV1"
                                                ForeColor="Red">*</asp:RequiredFieldValidator>
                                        </td>
                                        <td class="ControlCell" style="width: 25%">
                                            <asp:Label ID="Label78" runat="server" Width="96%">Peso para la Edad</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 25%; text-align: left;">
                                            <asp:TextBox ID="txt_peso_edad" runat="server" Width="90%" onkeypress="return ValNumero(this, event)"
                                                Font-Size="X-Small" Style="text-align: right" MaxLength="7" TabIndex="27"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfv_Peso_Edad" runat="server" ControlToValidate="txt_peso_edad"
                                                EnableClientScript="False" ErrorMessage="Se debe diligenciar el peso para la edad"
                                                ValidationGroup="GV1" ForeColor="Red">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 25%">
                                            <asp:Label ID="Label80" runat="server" Font-Bold="False" Width="96%">Perímetro Cefálico</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 25%; text-align: left;">
                                            <asp:TextBox ID="txt_perimetro" runat="server" Width="90%" onkeypress="return ValNumero(this, event)"
                                                Font-Size="X-Small" Style="text-align: right" MaxLength="7" TabIndex="25"></asp:TextBox>
                                        </td>
                                        <td class="ControlCell" style="width: 25%">
                                            <asp:Label ID="Label139" runat="server" Width="96%">Talla para la Edad</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 25%; text-align: left;">
                                            <asp:TextBox ID="txt_talla_longitud" runat="server" Width="90%" onkeypress="return ValNumero(this, event)"
                                                Font-Size="X-Small" Style="text-align: right" MaxLength="7" TabIndex="28"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfv_Talla_Longitud" runat="server" ControlToValidate="txt_talla_longitud"
                                                EnableClientScript="False" ErrorMessage="Se debe diligenciar Talla-Longitud"
                                                ValidationGroup="GV1" ForeColor="Red">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 25%">
                                            <asp:Label ID="lblIdValoracion" runat="server" Visible="False"></asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 25%; text-align: left;">
                                            <asp:Label ID="Label23" runat="server" Font-Bold="False" Width="83%">Los decimales ingresarlos con (.)</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 25%">
                                            <asp:Label ID="Label21" runat="server" Width="96%">IMC / Edad</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 25%; text-align: left;">
                                            <asp:TextBox ID="Txt_IMC_Edad" runat="server" Font-Size="X-Small" MaxLength="7" onkeypress="return ValNumero(this, event)"
                                                Style="text-align: right" Width="90%" TabIndex="29"></asp:TextBox><asp:RequiredFieldValidator
                                                    ID="RequiredFieldValidator2" runat="server" ControlToValidate="Txt_IMC_Edad"
                                                    EnableClientScript="False" ErrorMessage="Se debe diligenciar el IMC para la edad"
                                                    ValidationGroup="GV1" ForeColor="Red">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" colspan="4" style="width: 100%; background-color: lightsalmon">
                                            <asp:Label ID="Label4" runat="server" ForeColor="Navy" Font-Bold="True">Estado Nutricional y Diferencias</asp:Label>
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 25%;">
                                            <asp:Label ID="lblFecha_Desplazamiento" runat="server" Width="96%">Estado Nutricional</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 25%; text-align: left;">
                                            <asp:TextBox ID="txt_Estado_Nutricional" runat="server" Width="90%" Font-Size="X-Small"
                                                BackColor="#C0C0FF" Font-Bold="True" ForeColor="#C04000" ReadOnly="True" 
                                                BorderColor="White"></asp:TextBox>
                                        </td>
                                        <td class="ControlCell" style="width: 25%; text-align: left;">
                                            <asp:Label ID="Label5" runat="server" Width="96%">T/E</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 25%; text-align: left;">
                                            <asp:TextBox ID="Txt_Valoracion_TE" runat="server" Font-Size="X-Small" Width="90%"
                                                BackColor="#C0C0FF" Font-Bold="True" ForeColor="#C04000" ReadOnly="True"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 25%; text-align: left;">
                                            <asp:Label ID="Label6" runat="server" Width="96%" style="text-align: center">Diferencia de Peso</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 25%; text-align: left;">
                                            <asp:TextBox ID="txt_Diferencia_Peso" runat="server" Width="90%" onkeypress="return ValNumero(this, event)"
                                                MaxLength="7" Style="text-align: right" BackColor="#C0C0FF" Font-Bold="True"
                                                ForeColor="#C04000"></asp:TextBox>
                                        </td>
                                        <td class="ControlCell" style="width: 25%">
                                            <asp:Label ID="lblRecuperado" runat="server" Width="96%">Recuperado</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 25%">
                                            <asp:DropDownList ID="ddl_Recuperado" runat="server" Font-Size="X-Small" Width="42%"
                                                TabIndex="30">
                                            </asp:DropDownList>
                                            <asp:Button ID="btn_calcular" runat="server" Font-Italic="True" 
                                                Font-Size="XX-Small" Text="Calcular"
                                                ToolTip="Calcula las variables de acuerdo a los parámetros establecidos" />
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" colspan="4" style="width: 100%; background-color: lemonchiffon">
                                            <asp:Label ID="Label101" runat="server" Width="96%">.</asp:Label>
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td align="center" class="LabelCell" style="vertical-align: middle; width: 25%; text-align: center">
                                            <asp:Label ID="Label97" runat="server">Observaciones Generales</asp:Label>
                                        </td>
                                        <td class="ControlCell" colspan="3" style="width: 75%">
                                            <asp:TextBox ID="txt_Observaciones" runat="server" BackColor="ButtonFace" MaxLength="4000"
                                                Rows="3" TextMode="MultiLine" Width="98%" TabIndex="31"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td align="center" class="LabelCell" colspan="4" style="width: 100%; background-color: activecaption;
                                            height: 14px;">
                                            <asp:Label ID="Label30" runat="server" Font-Bold="True" ForeColor="Navy">FIN DE INFORMACION DE VALORACION</asp:Label>
                                        </td>
                                    </tr>
                                </table>
                                <table width="100%">
                                    <tr valign="top">
                                        <td align="center" colspan="4">
                                            <div>
                                                <asp:Button ID="btnGuardarValoracion" runat="server" CssClass="Boton" Text="Guardar Valoración"
                                                    TabIndex="32" /><asp:Button ID="btnNuevaValoracion" runat="server" CssClass="Boton"
                                                        Text="Nueva Valoración" TabIndex="33" /></div>
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td align="center" colspan="4" style="width: 100%">
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td align="center" colspan="4" style="width: 100%">
                                            <telerik:RadGrid ID="Rg_Valoraciones" runat="server" AllowSorting="True" GridLines="None"
                                                Skin="WebBlue" Width="100%" AutoGenerateColumns="False" ShowStatusBar="True"
                                                TabIndex="6" PageSize="20" CellSpacing="0">
                                                <MasterTableView NoDetailRecordsText="No hay informaci&#243;n." NoMasterRecordsText="No hay informaci&#243;n."
                                                    DataKeyNames="Id" CommandItemDisplay="Top" AllowPaging="True">
                                                    <Columns>
                                                        <telerik:GridTemplateColumn HeaderText="No." DefaultInsertValue="" UniqueName="TemplateColumn">
                                                            <ItemTemplate>
                                                                <asp:Label runat="server" ID="lblno" Text='<%# ctype(CType(Container.Parent.Parent.Parent,RadGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>' />
                                                                <asp:Label runat="Server" ID="lblIdV" Visible="False" Text='<%#Container.DataItem.Id%>' />
                                                            </ItemTemplate>
                                                        </telerik:GridTemplateColumn>
                                                        <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" HeaderText="Id" ReadOnly="True"
                                                            SortExpression="Id" UniqueName="Id" Visible="True">
                                                        </telerik:GridBoundColumn>
                                                        <telerik:GridBoundColumn DataField="Fecha_Valoracion" DataType="System.DateTime" HeaderText="Fecha"
                                                            DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_Valoracion" UniqueName="Fecha_Valoracion">
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>
                                                        <telerik:GridBoundColumn DataField="TipoProceso.Descripcion" HeaderText="Tipo"
                                                            SortExpression="TipoProceso.Descripcion" UniqueName="TipoProceso.Descripcion">
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>
                                                        <telerik:GridBoundColumn DataField="Edad" HeaderText="Edad Años"
                                                            SortExpression="Edad" UniqueName="Edad">
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>
                                                        <telerik:GridBoundColumn DataField="Meses" HeaderText="Edad Meses"
                                                            SortExpression="Meses" UniqueName="Meses">
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>
                                                        <telerik:GridBoundColumn DataField="Antropometria_Peso" HeaderText="Peso"
                                                            SortExpression="Antropometria_Peso" UniqueName="Antropometria_Peso">
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>
                                                        <telerik:GridBoundColumn DataField="Diferencia_Peso" HeaderText="Dif. Peso"
                                                            SortExpression="Diferencia_Peso" UniqueName="Diferencia_Peso">
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>
                                                        <telerik:GridBoundColumn DataField="Antropometria_Talla" HeaderText="Talla"
                                                            SortExpression="Antropometria_Talla" UniqueName="Antropometria_Talla">
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>
                                                        <telerik:GridBoundColumn DataField="Antropometia_Perimetro_Branquial" HeaderText="Per. Braq."
                                                            SortExpression="Antropometia_Perimetro_Branquial" UniqueName="Antropometia_Perimetro_Branquial">
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>
                                                        <telerik:GridBoundColumn DataField="Peso_talla" HeaderText="P/T"
                                                            SortExpression="Peso_talla" UniqueName="Peso_talla">
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>
                                                        <telerik:GridBoundColumn DataField="Peso_edad" HeaderText="P/E"
                                                            SortExpression="Peso_edad" UniqueName="Peso_edad">
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>
                                                        <telerik:GridBoundColumn DataField="Talla_Longitud" HeaderText="T/E"
                                                            SortExpression="Talla_Longitud" UniqueName="Talla_Longitud">
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>
                                                        <telerik:GridBoundColumn DataField="IMC_Edad" HeaderText="IMC/Edad"
                                                            SortExpression="IMC_Edad" UniqueName="IMC_Edad">
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>
                                                        <telerik:GridBoundColumn DataField="Estado_Nutricional" HeaderText="E. Nutricional"
                                                            SortExpression="Estado_Nutricional" UniqueName="Estado_Nutricional">
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>
                                                        <telerik:GridBoundColumn DataField="Talla_Para_Edad" HeaderText="T/E"
                                                            SortExpression="Talla_Para_Edad" UniqueName="Talla_Para_Edad">
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>
                                                        <telerik:GridButtonColumn ConfirmText="Desea eliminar este registro?" ConfirmDialogType="Classic"
                                                            HeaderTooltip="Eliminar Producto de la salida " HeaderText="X" ConfirmTitle="Borrar Item de Ajuste de Salida."
                                                            CommandName="Eliminar" UniqueName="Borrar" ButtonType="ImageButton" ImageUrl="../Images/balde.gif">
                                                            <ItemStyle Width="10px" HorizontalAlign="Center" />
                                                            <HeaderStyle HorizontalAlign="Center" />
                                                        </telerik:GridButtonColumn>
                                                    </Columns>
                                                    <CommandItemSettings ExportToCsvText="Exportar a CSV" ExportToExcelText="Exportar a Excel"
                                                        ExportToPdfText="Exportar a PDF" ExportToWordText="Exportar a Word" RefreshText="Actualizar"
                                                        AddNewRecordText="" AddNewRecordImageUrl="~/Images/nothing.gif" ShowExportToCsvButton="True"
                                                        ShowExportToExcelButton="True" ShowExportToPdfButton="True" ShowExportToWordButton="True"
                                                        ShowAddNewRecordButton="False" />
                                                    <PagerStyle Mode="NumericPages" FirstPageToolTip="Primera" LastPageToolTip="Ultima"
                                                        NextPagesToolTip="Pr&#243;ximas" NextPageToolTip="Pr&#243;xima" PagerTextFormat="Cambiar P&#225;gina: {4} &amp;nbsp;P&#225;gina &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;, registros &lt;strong&gt;{2}&lt;/strong&gt; a &lt;strong&gt;{3}&lt;/strong&gt; de &lt;strong&gt;{5}&lt;/strong&gt;."
                                                        PrevPageToolTip="Anterior" PrevPagesToolTip="Anteriores" AlwaysVisible="True" />
                                                </MasterTableView>
                                                <ClientSettings EnablePostBackOnRowClick="True" EnableRowHoverStyle="True">
                                                    <Selecting AllowRowSelect="True" />
                                                </ClientSettings>
                                                <ExportSettings HideStructureColumns="True" FileName="SaludValoraciones" ExportOnlyData="True"
                                                    IgnorePaging="True" OpenInNewWindow="True">
                                                    <Pdf PageWidth="" AllowPrinting="true">
                                                    </Pdf>
                                                </ExportSettings>
                                                <SortingSettings SortToolTip="Clic aqui para ordenar..." SortedAscToolTip="Ordenar Ascendente"
                                                    SortedDescToolTip="Ordenar Descendente" />
                                                <PagerStyle Mode="NumericPages" AlwaysVisible="True" />
                                            </telerik:RadGrid>
                                        </td>
                                    </tr>
                                </table>
                                <table id="Table2" border="0" cellpadding="0" cellspacing="0" class="EditControlsTable"
                                    width="100%">
                                    <tr valign="top">
                                        <td align="center" class="LabelCell" colspan="4" style="width: 100%; background-color: activecaption">
                                            <asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="Navy" Width="226px">INFORMACION DE REMISIONES</asp:Label>
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" colspan="2" style="width: 50%; background-color: lightsalmon">
                                        </td>
                                        <td class="LabelCell" colspan="2" style="width: 50%; background-color: lightsalmon">
                                        </td>
                                        <td class="LabelCell" colspan="2" style="width: 50%; background-color: lightsalmon">
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 25%;">
                                            <asp:Label ID="Label12" runat="server" Width="96%">Entidad de Remisión</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 25%; text-align: left;">
                                            <asp:DropDownList ID="ddl_Entidad_Remision" runat="server" Font-Size="X-Small" Width="90%"
                                                TabIndex="34">
                                            </asp:DropDownList>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator16" runat="server"
                                                ControlToValidate="ddl_Entidad_Remision" EnableClientScript="False" ErrorMessage="Falta Entidad de Remision"
                                                ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GV2" ForeColor="Red">*</asp:RegularExpressionValidator>
                                        </td>
                                        <td class="ControlCell" style="width: 25%;">
                                            <asp:Label ID="Label13" runat="server" Width="96%">Fecha de Remisión</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 25%; text-align: left;">
                                            <telerik:RadDatePicker ID="rdpfechaRemision" runat="server" Culture="Spanish (Colombia)"
                                                MinDate="" Skin="WebBlue" TabIndex="1" ToolTip="Seleccione Fecha ..." 
                                                Width="90%">
                                                <Calendar Skin="WebBlue" UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False"
                                                    ViewSelectorText="x">
                                                    <FastNavigationSettings CancelButtonCaption="Cancelar" DateIsOutOfRangeMessage="Fecha Fuera de Rango"
                                                        TodayButtonCaption="Hoy">
                                                    </FastNavigationSettings>
                                                </Calendar>
                                                <DatePopupButton HoverImageUrl="" ImageUrl="" TabIndex="1" ToolTip="Abrir el Calendario" />
                                                <DateInput DateFormat="dd/MM/yyyy" DisplayDateFormat="dd/MMMM/yyyy" EmptyMessage="Fecha ..."
                                                    TabIndex="1">
                                                    <EmptyMessageStyle Resize="None" />
                                                    <ReadOnlyStyle Resize="None" />
                                                    <FocusedStyle Resize="None" />
                                                    <DisabledStyle Resize="None" />
                                                    <InvalidStyle Resize="None" />
                                                    <HoveredStyle Resize="None" />
                                                    <EnabledStyle Resize="None" />
                                                </DateInput>
                                            </telerik:RadDatePicker>
                                            <asp:RequiredFieldValidator ID="rfv_fecha_Remision" runat="server" ControlToValidate="rdpfechaRemision"
                                                EnableClientScript="False" Enabled="False" ErrorMessage="Se debe diligenciar la fecha de remisión"
                                                ValidationGroup="GV2" ForeColor="Red">*</asp:RequiredFieldValidator>
                                            <asp:Label ID="lblIdRemision" runat="server" Visible="False"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 25%; height: 24px;">
                                            <asp:Label ID="Label29" runat="server" Width="96%">Servicio a prestar la entidad</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 25%; height: 24px; text-align: left;">
                                            <asp:DropDownList ID="ddl_Informacion" runat="server" Font-Size="X-Small" Width="90%"
                                                TabIndex="38">
                                            </asp:DropDownList>
                                            <asp:RegularExpressionValidator ID="rev_Informacion_Entidad" runat="server" ControlToValidate="ddl_Informacion"
                                                EnableClientScript="False" ErrorMessage="Falta Clasificación de Información de Entidad"
                                                ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GV2" ForeColor="Red">*</asp:RegularExpressionValidator>
                                        </td>
                                        <td class="ControlCell" style="width: 25%; height: 24px;">
                                            <asp:Label ID="Label14" runat="server" Width="96%">Fecha de Verificación</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 25%; height: 24px; text-align: left;">
                                            <telerik:RadDatePicker ID="rdpfechaVerificacion" runat="server" Culture="Spanish (Colombia)"
                                                MinDate="" Skin="WebBlue" TabIndex="1" ToolTip="Seleccione Fecha ..." 
                                                Width="90%">
                                                <Calendar Skin="WebBlue" UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False"
                                                    ViewSelectorText="x">
                                                    <FastNavigationSettings CancelButtonCaption="Cancelar" DateIsOutOfRangeMessage="Fecha Fuera de Rango"
                                                        TodayButtonCaption="Hoy">
                                                    </FastNavigationSettings>
                                                </Calendar>
                                                <DatePopupButton HoverImageUrl="" ImageUrl="" TabIndex="1" ToolTip="Abrir el Calendario" />
                                                <DateInput DateFormat="dd/MM/yyyy" DisplayDateFormat="dd/MMMM/yyyy" EmptyMessage="Fecha ..."
                                                    TabIndex="1">
                                                    <EmptyMessageStyle Resize="None" />
                                                    <ReadOnlyStyle Resize="None" />
                                                    <FocusedStyle Resize="None" />
                                                    <DisabledStyle Resize="None" />
                                                    <InvalidStyle Resize="None" />
                                                    <HoveredStyle Resize="None" />
                                                    <EnabledStyle Resize="None" />
                                                </DateInput>
                                            </telerik:RadDatePicker>
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" colspan="4" style="width: 100%; background-color: lemonchiffon;
                                            height: 14px;">
                                            <asp:Label ID="Label24" runat="server" Width="42%">.</asp:Label>
                                            <asp:CheckBox ID="Chb_Cerrado_Remision" runat="server" Enabled="False" Text="Registro Cerrado" />
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td align="center" class="LabelCell" style="vertical-align: middle; width: 25%; text-align: center">
                                            <asp:Label ID="Label25" runat="server">Observaciones Generales</asp:Label>
                                        </td>
                                        <td class="ControlCell" colspan="3" style="width: 75%">
                                            <asp:TextBox ID="Txt_Observaciones_Remision" runat="server" BackColor="ButtonFace"
                                                MaxLength="4000" Rows="3" TextMode="MultiLine" Width="98%" TabIndex="39"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td align="center" class="LabelCell" colspan="4" style="width: 100%; background-color: activecaption;
                                            height: 14px;">
                                            <asp:Label ID="Label26" runat="server" Font-Bold="True" ForeColor="Navy">FIN DE INFORMACION DE REMISION</asp:Label>
                                        </td>
                                    </tr>
                                </table>
                                <div>
                                    <table width="100%">
                                        <tr valign="top">
                                            <td align="center" colspan="4">
                                                <div>
                                                    <asp:Button ID="BtnGuardarRemision" runat="server" CssClass="Boton" Text="Guardar Remisión"
                                                        TabIndex="40" /><asp:Button ID="btnNuevaRemision" runat="server" CssClass="Boton"
                                                            Text="Nueva Remisión" TabIndex="41" />&nbsp;</div>
                                            </td>
                                        </tr>
                                        <tr valign="top">
                                            <td align="center" colspan="4" style="width: 100%">
                                            </td>
                                        </tr>
                                        <tr valign="top">
                                            <td align="center" colspan="4" style="width: 100%">
                                                <telerik:RadGrid ID="Rg_Remisiones" runat="server" AllowSorting="True" GridLines="None"
                                                    Skin="WebBlue" Width="100%" AutoGenerateColumns="False" ShowStatusBar="True"
                                                    TabIndex="6" PageSize="20" CellSpacing="0">
                                                    <MasterTableView NoDetailRecordsText="No hay informaci&#243;n." NoMasterRecordsText="No hay informaci&#243;n."
                                                        DataKeyNames="Id" CommandItemDisplay="Top" AllowPaging="True">
                                                        <Columns>
                                                            <telerik:GridTemplateColumn HeaderText="No." DefaultInsertValue="" UniqueName="TemplateColumn">
                                                                <ItemTemplate>
                                                                    <asp:Label runat="server" ID="lblno" Text='<%# ctype(CType(Container.Parent.Parent.Parent,RadGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>' />
                                                                    <asp:Label runat="Server" ID="lblIdR" Visible="False" Text='<%#Container.DataItem.Id%>' />
                                                                </ItemTemplate>
                                                            </telerik:GridTemplateColumn>
                                                            <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" HeaderText="Id" ReadOnly="True"
                                                                SortExpression="Id" UniqueName="Id" Visible="True">
                                                            </telerik:GridBoundColumn>
                                                            <telerik:GridBoundColumn DataField="Fecha_Remision" DataType="System.DateTime" HeaderText="Fecha"
                                                                DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_Remision" UniqueName="Fecha_Remision">
                                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                            </telerik:GridBoundColumn>
                                                            <telerik:GridBoundColumn DataField="Entidad_Remision.Descripcion" HeaderText="Entidad"
                                                                SortExpression="Entidad_Remision.Descripcion" UniqueName="Entidad_Remision.Descripcion">
                                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                            </telerik:GridBoundColumn>
                                                            <telerik:GridBoundColumn DataField="Entidad_Informacion.Descripcion" HeaderText="Servicio"
                                                                SortExpression="Entidad_Informacion.Descripcion" UniqueName="Entidad_Informacion.Descripcion">
                                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                            </telerik:GridBoundColumn>
                                                            <telerik:GridBoundColumn DataField="Fecha_Ingreso" DataType="System.DateTime" HeaderText="Fecha Revisado"
                                                                DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_Ingreso" UniqueName="Fecha_Ingreso">
                                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                            </telerik:GridBoundColumn>
                                                            <telerik:GridButtonColumn ConfirmText="Desea eliminar este registro?" ConfirmDialogType="Classic"
                                                                HeaderTooltip="Eliminar Producto de la remisión " HeaderText="X" ConfirmTitle="Borrar Item de Ajuste de Salida."
                                                                CommandName="Eliminar" UniqueName="Borrar" ButtonType="ImageButton" ImageUrl="../Images/balde.gif">
                                                                <ItemStyle Width="10px" HorizontalAlign="Center" />
                                                                <HeaderStyle HorizontalAlign="Center" />
                                                            </telerik:GridButtonColumn>
                                                        </Columns>
                                                        <CommandItemSettings ExportToCsvText="Exportar a CSV" ExportToExcelText="Exportar a Excel"
                                                            ExportToPdfText="Exportar a PDF" ExportToWordText="Exportar a Word" RefreshText="Actualizar"
                                                            AddNewRecordText="" AddNewRecordImageUrl="~/Images/nothing.gif" ShowExportToCsvButton="True"
                                                            ShowExportToExcelButton="True" ShowExportToPdfButton="True" ShowExportToWordButton="True"
                                                            ShowAddNewRecordButton="False" />
                                                        <PagerStyle Mode="NumericPages" FirstPageToolTip="Primera" LastPageToolTip="Ultima"
                                                            NextPagesToolTip="Pr&#243;ximas" NextPageToolTip="Pr&#243;xima" PagerTextFormat="Cambiar P&#225;gina: {4} &amp;nbsp;P&#225;gina &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;, registros &lt;strong&gt;{2}&lt;/strong&gt; a &lt;strong&gt;{3}&lt;/strong&gt; de &lt;strong&gt;{5}&lt;/strong&gt;."
                                                            PrevPageToolTip="Anterior" PrevPagesToolTip="Anteriores" AlwaysVisible="True" />
                                                    </MasterTableView>
                                                    <ClientSettings EnablePostBackOnRowClick="True" EnableRowHoverStyle="True">
                                                        <Selecting AllowRowSelect="True" />
                                                    </ClientSettings>
                                                    <ExportSettings HideStructureColumns="True" FileName="Salud" ExportOnlyData="True"
                                                        IgnorePaging="True" OpenInNewWindow="True">
                                                        <Pdf PageWidth="" AllowPrinting="true">
                                                        </Pdf>
                                                    </ExportSettings>
                                                    <SortingSettings SortToolTip="Clic aqui para ordenar..." SortedAscToolTip="Ordenar Ascendente"
                                                        SortedDescToolTip="Ordenar Descendente" />
                                                    <PagerStyle Mode="NumericPages" AlwaysVisible="True" />
                                                </telerik:RadGrid>
                                            </td>
                                        </tr>
                                    </table>
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
            <telerik:AjaxSetting AjaxControlID="ddl_Crecimiento_Desarrollo">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ddl_Motivo_Crecimiento_Desarrollo_IRD" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ddl_Crecimiento_Desarrollo_IRD">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ddl_Motivo_Crecimiento_Desarrollo_IRD" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ddl_Vacunacion_Carnet">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ddl_Razon_No_Carnet" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rev_Razon_No_Carnet" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ddl_Esquema_Vacunacion_Completo">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ddl_Razon_No_Vacunacion_Completo" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Rev_Razon_No_Vacunacion_Completo" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ddl_Ninos_Vacunados">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ddl_Motivo_No_Vacunados" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="revMotivo_No_Vacunados" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnGuardar">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ValidationSummaryGVG" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="lblMensaje" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnGuardarOtro">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ValidationSummaryGVG" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="lblMensaje" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnEliminar">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="pnl_principal" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btn_calcular">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="txt_peso" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_peso_talla" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_talla" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_peso_edad" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_perimetro" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_talla_longitud" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="lblIdValoracion" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Txt_IMC_Edad" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_Estado_Nutricional" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Txt_Valoracion_TE" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_Diferencia_Peso" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnGuardarValoracion">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ValidationSummaryGV1" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_Tipo_Proceso" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rdpfechaValoracion" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_peso" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_peso_talla" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_talla" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_peso_edad" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_perimetro" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_talla_longitud" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="lblIdValoracion" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Txt_IMC_Edad" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_Estado_Nutricional" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Txt_Valoracion_TE" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_Diferencia_Peso" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_Recuperado" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_Observaciones" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnNuevaValoracion">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ddl_Tipo_Proceso" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rdpfechaValoracion" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_peso" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_peso_talla" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_talla" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_peso_edad" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_perimetro" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_talla_longitud" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="lblIdValoracion" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Txt_IMC_Edad" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_Estado_Nutricional" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Txt_Valoracion_TE" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_Diferencia_Peso" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_Recuperado" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Rg_Valoraciones">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ddl_Tipo_Proceso" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rdpfechaValoracion" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_peso" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_peso_talla" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_talla" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_peso_edad" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_perimetro" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_talla_longitud" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="lblIdValoracion" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Txt_IMC_Edad" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_Estado_Nutricional" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Txt_Valoracion_TE" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_Diferencia_Peso" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_Recuperado" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_Observaciones" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="BtnGuardarRemision">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ValidationSummaryGV2" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Rg_Remisiones" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnNuevaRemision">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ddl_Entidad_Remision" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rdpfechaRemision" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="lblIdRemision" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_Informacion" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rdpfechaVerificacion" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Chb_Cerrado_Remision" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Txt_Observaciones_Remision" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Rg_Remisiones">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ddl_Entidad_Remision" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rdpfechaRemision" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="lblIdRemision" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_Informacion" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rdpfechaVerificacion" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Chb_Cerrado_Remision" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Txt_Observaciones_Remision" />
                    <telerik:AjaxUpdatedControl ControlID="Rg_Remisiones" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
</asp:Content>

