<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="Gestantes.aspx.vb" Inherits="WebForms_Gestantes" %>
<%@ Register Src="../Controles/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 20%;
        }
        .style2
        {
            width: 30%;
        }
        .style3
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
    <asp:ValidationSummary ID="valSummary" runat="server" ForeColor="Red" 
        style="text-align: left" />

    <asp:Panel runat="server" ID="pnl_principal" DefaultButton ="btnGuardar" Width ="100%">
        <table id="Table2" cellspacing="0" cellpadding="0" border="0" class="ContentTable" style="width: 100%">
            <tr valign="top">
            <td style="width: 75%; text-align: left;"> 
                <asp:Label ID="lbl_Titulo" runat="server" 
                    Text="SEGUIMIENTO A INFORMACION DE GESTANTES" Width="90%" 
                    CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
                <asp:Label ID="lblMensaje" runat="server" CssClass="TitMensaje" Text="_" Width="90%" Visible="False"/>
            </td>
            <td style="width: 25%" align="right">
                <asp:ImageButton ID="btn_actualizar" runat="server" ImageUrl="~/Images/Reload.jpg" ToolTip="Actualizar la vista actual." TabIndex="5" />
                <asp:ImageButton ID="btn_cerrar" runat="server" ImageUrl="~/Images/Stop.jpg" ToolTip="Cerrar - Volver a la vista anterior." TabIndex="7" />
                <asp:ImageButton ID="btn_home" runat="server" ImageUrl="~/Images/Home.jpg" ToolTip="Ir al Inicio." TabIndex="8" />&nbsp;</td>
            </tr>

            <tr valign="top">
                <td colspan="2">
                    <table id="TablaContenido" cellspacing="0" cellpadding="0" border="0" class="ContentTable" style="width: 100%">
                        <tr valign="top">
                            <td>
                                <table id="tblContenido" class="EditControlsTable" cellspacing="0" 
                                    cellpadding="1" border="0" style="width: 100%">
                                    <tr valign="top">
                                        <td class="ControlCell" colspan="4" style="background-color: orange">
                                            <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="Navy" Width="29%">DATOS DE LA GESTANTE</asp:Label></td>
                                    </tr>

                                    <tr valign="top"><td  class="style1" style="background-color: whitesmoke;">
                                    <asp:Label id="lblPersonas" runat="server" Width="90%">Nombre Madre Gestante</asp:Label>
                                    </td><td class="style2" style="background-color: whitesmoke;">
                                        <asp:Label ID="lbl_Nombre_completo" runat="server" Font-Bold="True" Font-Size="Medium"
                                            ForeColor="#C04000"></asp:Label></td>
                                        <td class="style1" style="background-color: whitesmoke;">
                                            <asp:Label ID="label09" runat="server" Width="90%">Edad al Desplazamiento</asp:Label></td>
                                        <td class="style2" style="background-color: whitesmoke;">
                                            <asp:Label ID="lbl_Edad" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="#C04000"></asp:Label>
                                            <asp:CheckBox ID="Chb_cerrado" runat="server" Enabled="False" Visible="False" /></td>
                                    </tr>

                                    <tr valign="top"><td  class="LabelCell" 
                                            style="width: 20%; background-color: whitesmoke;" valign="middle">
                                    <asp:Label id="lblSubTablasId_Control_Prenatal" runat="server" Width="90%">Tiene Control Prenatal ?</asp:Label>


                                    </td><td class="style3" style="width: 30%; background-color: whitesmoke;">
                                    <asp:dropdownlist id="ddl_Control_Prenatal" runat="server" Width="90%" 
                                                Font-Size="X-Small" AutoPostBack="True" ></asp:dropdownlist>
                                        <asp:RegularExpressionValidator ID="Rev_Control_Prenatal" runat="server" ControlToValidate="ddl_Control_Prenatal"
                                            EnableClientScript="False" ErrorMessage="Debe ingresar si tiene control prenatal"
                                            ValidationExpression="^[1-9]+[0-9]*$" ForeColor="Red">*</asp:RegularExpressionValidator>
                                    </td>
                                        <td class="ControlCell" style="width: 20%; background-color: whitesmoke;">
                                            <asp:Label ID="Label1" runat="server" Width="90%">Fecha de Control Prenatal</asp:Label></td>
                                        <td class="ControlCell" style="width: 30%; background-color: whitesmoke;">
                                            <telerik:RadDatePicker ID="rdpFechaControlPrenatal" runat="server" 
                                                Culture="Spanish (Colombia)" MinDate="" Skin="Telerik" 
                                                ToolTip="Seleccione Fecha ..." Width="95%" Enabled="False" 
                                                style="text-align: left">
                                                <Calendar Skin="Telerik" UseColumnHeadersAsSelectors="False" 
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
                                        </td>
                                    </tr>

                                    <tr valign="top"><td  class="LabelCell" style="width: 20%; background-color: whitesmoke;">
                                    <asp:Label id="lblUnidad_Basica_Atencion" runat="server" Width="90%">Unidad Básica de Atención</asp:Label>
                                    </td><td class="style3" style="width: 30%; background-color: whitesmoke;">
                                    <asp:TextBox id="txtUnidad_Basica_Atencion" runat = "server" Width="90%" 
                                                Font-Size="X-Small" MaxLength="100"></asp:TextBox>&nbsp;
                                    </td>
                                        <td class="ControlCell" style="width: 20%; background-color: whitesmoke;">
                                    <asp:Label id="lblSubTablasId_Ingesta_Micronutrientes" runat="server" Width="90%">Ha recibido Micronutrientes?</asp:Label></td>
                                        <td class="ControlCell" 
                                            style="width: 30%; background-color: whitesmoke; text-align: left;">
                                    <asp:dropdownlist id="ddl_Ingesta_Micronutrientes" runat="server" Width="60%" 
                                                Font-Size="X-Small" ></asp:dropdownlist>        
                                        <asp:RegularExpressionValidator ID="rev_Ingesta" runat="server" ControlToValidate="ddl_Ingesta_Micronutrientes"
                                            EnableClientScript="False" ErrorMessage="Debe ingresar si ha recibido ingesta de micronutrientes"
                                            ValidationExpression="^[1-9]+[0-9]*$" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                                    </tr>
                                    <tr valign="top"><td  class="LabelCell" 
                                            style="width: 20%; background-color: whitesmoke;" valign="middle">
                                    <asp:Label id="lblEnfermedades" runat="server" Width="90%">Enfermedades</asp:Label></td>
                                        <td class="style3" style="width: 80%; background-color: whitesmoke;" 
                                            colspan="3">
                                    <asp:TextBox id="txtEnfermedades" runat = "server" MaxLength="200" Rows="5" 
                                                TextMode="MultiLine" Width="95%" Font-Size="Small"></asp:TextBox>&nbsp;
                                    </td></tr>

                                    <tr valign="top"><td  class="LabelCell" style="width: 20%; background-color: whitesmoke;">
                                    <asp:Label id="lblSemanas_Gestacion" runat="server" Width="90%">Semanas de Gestación</asp:Label>
                                    </td><td class="style3" style="width: 30%; background-color: whitesmoke;">
                                    <asp:TextBox id="txtSemanas_Gestacion" runat = "server" MaxLength="2" 
                                                onkeypress="return ValNumero(this, event)" Font-Size="X-Small" 
                                                AutoPostBack="True" Width="80px"></asp:TextBox>      
                                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtSemanas_Gestacion"
                                            EnableClientScript="False" ErrorMessage="Las semanas deben estar entre 0 y 42 semanas"
                                            MaximumValue="42" MinimumValue="0" Type="Integer" ForeColor="Red">*</asp:RangeValidator>
                                        <asp:RequiredFieldValidator ID="rfv_Semanas" runat="server" ControlToValidate="txtSemanas_Gestacion"
                                            EnableClientScript="False" 
                                                ErrorMessage="Debe digitarse valor en Semanas de Gestación" ForeColor="Red">*</asp:RequiredFieldValidator></td>
                                        <td class="ControlCell" style="width: 20%; background-color: whitesmoke;">
                                            <asp:Label ID="Label8" runat="server" Width="90%">Peso</asp:Label></td>
                                        <td class="style3" style="width: 30%; background-color: whitesmoke;">
                                            <asp:TextBox ID="txt_peso" runat="server" AutoPostBack="True" Font-Size="X-Small"
                                                MaxLength="5" onkeypress="return ValNumero(this, event)" Width="80px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfv_peso" runat="server" ControlToValidate="txt_peso"
                                                EnableClientScript="False" ErrorMessage="Falta el valor del peso" 
                                                ForeColor="Red">*</asp:RequiredFieldValidator>
                                            </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 20%; background-color: whitesmoke">
                                            <asp:Label ID="Label10" runat="server" Width="90%">Talla en CM</asp:Label></td>
                                        <td class="style3" style="width: 30%; background-color: whitesmoke">
                                            <asp:TextBox ID="txt_talla" runat="server" AutoPostBack="True" Font-Size="X-Small"
                                                MaxLength="5" onkeypress="return ValNumero(this, event)" Width="80px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfv_talla" runat="server" ControlToValidate="txt_talla"
                                                EnableClientScript="False" ErrorMessage="Falta el valor de la talla" 
                                                ForeColor="Red">*</asp:RequiredFieldValidator>
                                            <asp:Label ID="Label11" runat="server" Font-Bold="False" Width="24%">Decimales (.)</asp:Label></td>
                                        <td class="ControlCell" style="width: 20%; background-color: whitesmoke">
                                            <asp:Label ID="Label12" runat="server" Width="90%">Estado Nutricional</asp:Label></td>
                                        <td class="style3" style="width: 30%; background-color: whitesmoke">
                                            <asp:Label ID="LBL_IMC" runat="server" BackColor="Yellow" BorderStyle="Ridge" ForeColor="Navy"
                                                Width="27%" style="text-align: center"></asp:Label>
                                            <asp:Label ID="Lbl_Estado_Nutricional" runat="server" BackColor="Yellow" BorderStyle="Double"
                                                ForeColor="#C04000" Width="37%" style="text-align: center"></asp:Label></td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" colspan="4" style="background-color: orange">
                                            <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="Navy" Width="29%">DATOS DE LA REMISION</asp:Label></td>
                                    </tr>

                                    <tr valign="top"><td  class="LabelCell" style="width: 20%;">
                                    <asp:Label id="lblSubTablasId_Remitidas" runat="server" Width="90%">Enviar a Remisión ?</asp:Label>


                                    </td><td class="style3" style="width: 30%;">
                                    <asp:dropdownlist id="ddl_Remitidas" runat="server" Width="60%" Font-Size="X-Small" 
                                                AutoPostBack="True" ></asp:dropdownlist>        
                                        <asp:RegularExpressionValidator ID="rev_Remitidas" runat="server" ControlToValidate="ddl_Remitidas"
                                            EnableClientScript="False" ErrorMessage="Debe ingresar si tiene remisión" 
                                                ValidationExpression="^[1-9]+[0-9]*$" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                                        <td class="ControlCell" style="width: 20%;">
                                            <asp:Label ID="lblFecha_Remision" runat="server" Width="90%">Fecha Remisión</asp:Label></td>
                                        <td class="ControlCell" style="width: 30%;">
                                            <telerik:RadDatePicker ID="rdpFechaRemision" runat="server" 
                                                Culture="Spanish (Colombia)" MinDate="" Skin="Telerik" 
                                                ToolTip="Seleccione Fecha ..." Width="95%" Enabled="False">
                                                <Calendar Skin="Telerik" UseColumnHeadersAsSelectors="False" 
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
                                        </td>
                                    </tr>

                                    <tr valign="top"><td  class="LabelCell" style="width: 20%;" valign="middle">
                                        <asp:Label ID="Label4" runat="server" Width="90%">Observaciones</asp:Label></td>
                                        <td class="style3" colspan="3" style="width: 80%;">
                                        <asp:TextBox ID="txtObservaciones" runat="server" Font-Size="Small" MaxLength="200"
                                            Rows="5" TextMode="MultiLine" Width="95%"></asp:TextBox>
                                    </td></tr>
                                                                        <tr valign="top">
                                                                            <td class="LabelCell" colspan="4" style="background-color: orange; width: 100%;">
                                                                                <asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="Navy" Width="29%">INFORMACION DE VISITA DOMICILIARIA</asp:Label></td>
                                                                        </tr>

                                    <tr valign="top"><td  class="LabelCell" style="width: 20%;">
                                    <asp:Label id="lblSubTablasId_Visita_Domiciliaria" runat="server" Width="90%">Generar la Visita Domiciliaria</asp:Label>


                                    </td><td class="ControlCell" style="width: 30%; text-align: left;">
                                    <asp:dropdownlist id="ddl_Visita_Domiciliaria" runat="server" Width="60%" 
                                                Font-Size="X-Small" AutoPostBack="True" ></asp:dropdownlist>        
                                        <asp:RegularExpressionValidator ID="rev_Visita" runat="server" ControlToValidate="ddl_Visita_Domiciliaria"
                                            EnableClientScript="False" ErrorMessage="Debe ingresar si tiene visita domiciliaria"
                                            ValidationExpression="^[1-9]+[0-9]*$" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                                        <td class="ControlCell" style="width: 20%;">
                                    <asp:Label id="lblFecha_Visita" runat="server" Width="90%">Fecha Visita Domiciliaria</asp:Label></td>
                                        <td class="ControlCell" style="width: 30%;">
                                            <telerik:RadDatePicker ID="rdpFechaVisita" runat="server" 
                                                Culture="Spanish (Colombia)" MinDate="" Skin="Telerik" 
                                                ToolTip="Seleccione Fecha ..." Width="95%" Enabled="False" 
                                                style="text-align: left">
                                                <Calendar Skin="Telerik" UseColumnHeadersAsSelectors="False" 
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
                                        </td>
                                    </tr>

                                    <tr valign="top"><td  class="LabelCell" style="width: 20%;" valign="middle">
                                        <asp:Label ID="Label3" runat="server" Width="90%">Observaciones Generales</asp:Label></td>
                                        <td class="ControlCell" style="width: 20%; text-align: left;" colspan="3">
                                        <asp:TextBox ID="txt_Observaciones_Visita" runat="server" Font-Size="Small" MaxLength="200"
                                            Rows="5" TextMode="MultiLine" Width="95%"></asp:TextBox></td></tr>

                                </table>
                            </td>
                         </tr>
                         <tr style="background-color: #F7F7F7;">
                            <td align="center">
                                &nbsp;<asp:Button ID="btnGuardar" runat="server" Text="Guardar" 
                                    cssclass="Boton" Width="200px" ToolTip="Guardar la información de gestante"></asp:Button>
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
                        <telerik:AjaxUpdatedControl ControlID="pnl_principal" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="ddl_Control_Prenatal">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="rdpFechaControlPrenatal" 
                            UpdatePanelCssClass="" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="ddl_Remitidas">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="rdpFechaRemision" 
                            UpdatePanelCssClass="" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="ddl_Visita_Domiciliaria">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="rdpFechaVisita" UpdatePanelCssClass="" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="btnGuardar">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="pnl_principal" UpdatePanelCssClass="" />
                        <telerik:AjaxUpdatedControl ControlID="valSummary" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
            </AjaxSettings>
        </telerik:RadAjaxManager>
    </telerik:RadAjaxLoadingPanel>
    
</asp:Content>

