<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="Declaracion_Ingreso.aspx.vb" Inherits="WebForms_Declaracion_Ingreso" %>
<%@ Register Src="../Controles/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script type="text/javascript">
       function ValNumero(fld, e) {
           var strCheck = '012345678 9-';
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
    <asp:Panel runat="server" ID="pnl_principal" DefaultButton="btn_actualizar" Width="100%">
    <asp:ValidationSummary ID="ValidationSummaryRI" runat="server" ValidationGroup="RI"  ForeColor="Red" EnableClientScript="False" 
        style="text-align: left" />

        <table id="Table2" cellspacing="0" cellpadding="0" border="0" class="ContentTable" style="width: 100%">
            <tr valign="top">
                <td style="width: 75%; text-align: left;">
                    <asp:Label ID="lbl_Titulo" runat="server" Text="REGISTRO INICIAL DE DECLARACIONES"
                        Width="100%" CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
                    <asp:Label ID="lblMensaje" runat="server" CssClass="TitMensaje" Text="_" Width="100%"
                        Visible="False" />
                </td>
                <td style="width: 25%" align="right">
                    <asp:ImageButton ID="btn_actualizar" runat="server" ImageUrl="~/Images/Reload.jpg"
                        ToolTip="Actualizar la vista actual." TabIndex="5" />
                    <asp:ImageButton ID="btn_nuevo" runat="server" ImageUrl="~/Images/Add.jpg" ToolTip="Crear Nuevo Registro."
                        TabIndex="6" />
                    <asp:ImageButton ID="btn_cerrar" runat="server" ImageUrl="~/Images/Stop.jpg" ToolTip="Cerrar - Volver a la vista anterior."
                        TabIndex="7" />
                    <asp:ImageButton ID="btn_home" runat="server" ImageUrl="~/Images/Home.jpg" ToolTip="Ir al Inicio."
                        TabIndex="8" />&nbsp;</td>
            </tr>
            <tr valign="top">
                <td colspan="2" style="width: 100%">
                    <table id="tblContenido" class="EditControlsTable" cellspacing="0" 
                        cellpadding="0" border="0">
                        <tr valign="top">
                            <td class="LabelCell" style="width: 150px; background-color: lightyellow;">
                                <asp:Label ID="Label17" runat="server" Width="100%">Fecha Radicación</asp:Label>
                            </td>
                            <td class="ControlCell" 
                                style="width: 185px; background-color: lightyellow; text-align: left;">
                                <telerik:RadDatePicker ID="rdpFechaRadicacion" runat="server" 
                                    Culture="Spanish (Colombia)" MinDate="" 
                                    ToolTip="Seleccione Fecha ..." Width="95%">
                                    <Calendar  UseColumnHeadersAsSelectors="False" 
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
                                <asp:RequiredFieldValidator ID="rfv_FechaRadicacion" runat="server" 
                                    ControlToValidate="rdpFechaRadicacion" EnableClientScript="False" 
                                    ErrorMessage="Falta la Fecha de Radicación" ForeColor="Red" 
                                    ValidationGroup="RI">*</asp:RequiredFieldValidator>
                            </td>
                            <td class="ControlCell" style="width: 150px; background-color: lightyellow;">
                                <asp:Label ID="Label18" runat="server" Width="100%">Regional</asp:Label>
                            </td>
                            <td class="ControlCell" 
                                style="width: 185px; background-color: lightyellow; text-align: left;">
                                <asp:DropDownList ID="ddl_regional" runat="server" Font-Size="X-Small" 
                                    Width="94%" TabIndex="1" AutoPostBack="True">
                                </asp:DropDownList>
                                &nbsp;<asp:RegularExpressionValidator ID="rev_Regional" runat="server" 
                                    ControlToValidate="ddl_regional" EnableClientScript="False" 
                                    ErrorMessage="Falta la Regional" ForeColor="Red" 
                                    ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="RI">*</asp:RegularExpressionValidator>
                            </td>
                            <td class="ControlCell" style="width: 150px; background-color: lightyellow;">
                                <asp:Label ID="Label43" runat="server" Width="100%">Lugar de Fuente</asp:Label>
                            </td>
                            <td class="ControlCell" 
                                style="width: 185px; background-color: lightyellow; text-align: left;">
                                <asp:DropDownList ID="ddl_LugarFuente" runat="server" Font-Size="X-Small" 
                                    TabIndex="5" Width="94%">
                                </asp:DropDownList>
                                &nbsp;<asp:RegularExpressionValidator ID="rev_LugarFuente" runat="server" 
                                    ControlToValidate="ddl_LugarFuente" EnableClientScript="False" 
                                    ErrorMessage="Falta Lugar de la Fuente de Información" ForeColor="Red" 
                                    ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="RI">*</asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" style="width: 150px; background-color: lightyellow">
                                <asp:Label ID="lblSubTablasId_Fuente" runat="server" Width="100%">Fuente</asp:Label>
                            </td>
                            <td class="ControlCell" 
                                style="width: 185px; background-color: lightyellow; text-align: left;">
                                <asp:DropDownList ID="ddl_Fuente" runat="server" Width="94%" 
                                    Font-Size="X-Small" TabIndex="3">
                                </asp:DropDownList>
                                <asp:RegularExpressionValidator ID="rev_Fuente" runat="server" ControlToValidate="ddl_Fuente"
                                    EnableClientScript="False" ErrorMessage="Falta Fuente de Información" ValidationExpression="^[1-9]+[0-9]*$"
                                    ValidationGroup="RI" ForeColor="Red">*</asp:RegularExpressionValidator>
                            </td>
                            <td class="ControlCell" style="width: 150px; background-color: lightyellow">
                                <asp:Label ID="Label1" runat="server" Width="100%">Fecha Declaración</asp:Label>
                            </td>
                            <td class="ControlCell" 
                                style="width: 185px; background-color: lightyellow; text-align: left;">
                                <telerik:RadDatePicker ID="rdpFechaDeclaracion" runat="server" Culture="Spanish (Colombia)"
                                    MinDate=""  ToolTip="Seleccione Fecha ..." Width="95%" 
                                    TabIndex="4" Skin="Telerik">
                                    <Calendar  UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False"
                                        ViewSelectorText="x" Skin="Telerik">
                                        <FastNavigationSettings CancelButtonCaption="Cancelar" DateIsOutOfRangeMessage="Fecha Fuera de Rango"
                                            TodayButtonCaption="Hoy">
                                        </FastNavigationSettings>
                                    </Calendar>
                                    <DatePopupButton HoverImageUrl="" ImageUrl="" ToolTip="Abrir el Calendario" 
                                        TabIndex="4" />
                                    <DateInput DateFormat="dd/MM/yyyy" DisplayDateFormat="dd/MMMM/yyyy" 
                                        EmptyMessage="Fecha ..." TabIndex="4">
                                        <EmptyMessageStyle Resize="None" />
                                        <ReadOnlyStyle Resize="None" />
                                        <FocusedStyle Resize="None" />
                                        <DisabledStyle Resize="None" />
                                        <InvalidStyle Resize="None" />
                                        <HoveredStyle Resize="None" />
                                        <EnabledStyle Resize="None" />
                                    </DateInput>
                                </telerik:RadDatePicker>
                                <asp:RequiredFieldValidator ID="rfv_Fecha_Declaracion" runat="server" ControlToValidate="rdpFechaDeclaracion"
                                    ErrorMessage="Falta la Fecha de Declaración" ValidationGroup="RI" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </td>
                            <td class="ControlCell" style="width: 150px; background-color: lightyellow">
                                <asp:Label ID="Label38" runat="server" Width="100%">Tipo de Declarante</asp:Label>
                            </td>
                            <td class="ControlCell" 
                                style="width: 185px; background-color: lightyellow; text-align: left;">
                                <asp:DropDownList ID="ddl_tipodeclarante" runat="server" AutoPostBack="True" 
                                    Font-Size="X-Small" TabIndex="2" Width="94%">
                                </asp:DropDownList>
                                &nbsp;<asp:RegularExpressionValidator ID="rev_tipodeclarante" runat="server" 
                                    ControlToValidate="ddl_tipodeclarante" EnableClientScript="False" 
                                    ErrorMessage="Falta tipo de Declarante" ForeColor="Red" 
                                    ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="RI">*</asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" style="width: 150px; background-color: lightyellow">
                                <asp:Label ID="Label44" runat="server" Width="100%">En Línea</asp:Label>
                            </td>
                            <td class="ControlCell" 
                                style="width: 185px; background-color: lightyellow; text-align: left;">
                                <asp:DropDownList ID="ddl_Enlinea" runat="server" Font-Size="X-Small" 
                                    TabIndex="8" Width="94%">
                                </asp:DropDownList>
                                <asp:RegularExpressionValidator ID="rev_enlinea" runat="server" 
                                    ControlToValidate="ddl_Enlinea" EnableClientScript="False" 
                                    ErrorMessage="Falta Definir si es en línea  o no" ForeColor="Red" 
                                    ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="RI">*</asp:RegularExpressionValidator>
                            </td>
                            <td class="ControlCell" style="width: 150px; background-color: lightyellow">
                                <asp:Label ID="Label31" runat="server" Width="100%">Fecha Desplazamiento</asp:Label>
                            </td>
                            <td class="ControlCell" 
                                style="background-color: lightyellow; width: 185px; text-align: left;">
                                <telerik:RadDatePicker ID="rdpFechaDesplazamiento" runat="server" Culture="Spanish (Colombia)"
                                    MinDate=""  ToolTip="Seleccione Fecha ..." Width="95%" 
                                    TabIndex="6" Skin="Telerik">
                                    <Calendar  UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False"
                                        ViewSelectorText="x" Skin="Telerik">
                                        <FastNavigationSettings CancelButtonCaption="Cancelar" DateIsOutOfRangeMessage="Fecha Fuera de Rango"
                                            TodayButtonCaption="Hoy">
                                        </FastNavigationSettings>
                                    </Calendar>
                                    <DatePopupButton HoverImageUrl="" ImageUrl="" ToolTip="Abrir el Calendario" 
                                        TabIndex="6" />
                                    <DateInput DateFormat="dd/MM/yyyy" DisplayDateFormat="dd/MMMM/yyyy" 
                                        EmptyMessage="Fecha ..." TabIndex="6">
                                        <EmptyMessageStyle Resize="None" />
                                        <ReadOnlyStyle Resize="None" />
                                        <FocusedStyle Resize="None" />
                                        <DisabledStyle Resize="None" />
                                        <InvalidStyle Resize="None" />
                                        <HoveredStyle Resize="None" />
                                        <EnabledStyle Resize="None" />
                                    </DateInput>
                                </telerik:RadDatePicker>
                                <asp:RequiredFieldValidator ID="rfv_Fecha_Desplazamiento" runat="server" ControlToValidate="rdpFechaDesplazamiento"
                                    ErrorMessage="Falta la Fecha de Desplazamiento" ForeColor="Red" ValidationGroup="RI">*</asp:RequiredFieldValidator>
                            </td>
                            <td class="ControlCell" style="width: 150px; background-color: lightyellow">
                                <asp:Label ID="Label39" runat="server" Width="100%">Horario de Atención</asp:Label>
                            </td>
                            <td class="ControlCell" 
                                style="width: 185px; background-color: lightyellow; text-align: left;">
                                <asp:RadioButtonList ID="rdb_Horario" runat="server" RepeatDirection="Horizontal"
                                    RepeatLayout="Flow" ToolTip="AM - Mañana / PM - Tarde / TD - Todo el Día" 
                                    Width="144px" TabIndex="7">
                                    <asp:ListItem Value="AM">AM</asp:ListItem>
                                    <asp:ListItem Value="PM">PM</asp:ListItem>
                                    <asp:ListItem Selected="True">TD</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" style="width: 150px; background-color: lightyellow">
                                <asp:Label ID="Label72" runat="server" Width="100%">Número Declaración</asp:Label>
                            </td>
                            <td class="ControlCell" 
                                style="width: 185px; background-color: lightyellow; text-align: left;">
                                <asp:TextBox ID="Txt_Numero_Declaracion" runat="server" MaxLength="20" 
                                    TabIndex="9" Width="81%" />
                                <asp:RequiredFieldValidator ID="rfv_Numero_Declaracion" runat="server" 
                                    ControlToValidate="Txt_Numero_Declaracion" EnableClientScript="False" 
                                    ErrorMessage="Falta el Número de Declaración" ForeColor="Red" 
                                    ValidationGroup="RI">*</asp:RequiredFieldValidator>
                            </td>
                            <td class="ControlCell" style="width: 150px; background-color: lightyellow">
                                <asp:Label ID="Label36" runat="server" Width="100%">Motivo Desplazamiento</asp:Label>
                            </td>
                            <td class="ControlCell" 
                                style="background-color: lightyellow; text-align: left;" colspan="3">
                                <asp:TextBox ID="Txt_Motivo" runat="server" TabIndex="10" Width="95%"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfv_Motivo" runat="server" 
                                    ControlToValidate="Txt_Motivo" EnableClientScript="False" Enabled="False" 
                                    ErrorMessage="Falta el Motivo del Desplazamiento" ForeColor="Red" 
                                    ValidationGroup="RI">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" colspan="6" style="background-color: orange; width: 100%; height: 16px;">
                                <asp:Label ID="Label35" runat="server" Font-Bold="True" ForeColor="Navy">Datos Generales</asp:Label>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" style="width: 150px; background-color: lightyellow;">
                                <asp:Label ID="Label6" runat="server" Width="100%">Primer Nombre</asp:Label>
                            </td>
                            <td class="ControlCell" 
                                style="width: 185px; background-color: lightyellow; text-align: left;">
                                <asp:TextBox ID="txt_PrimerNombre" runat="server" Width="90%" MaxLength="50" 
                                    TabIndex="11"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_PrimerNombre"
                                    EnableClientScript="False" ErrorMessage="Ingresar el Nombre del declarante" ValidationGroup="RI"
                                    ForeColor="Red">*</asp:RequiredFieldValidator>
                            </td>
                            <td class="ControlCell" style="width: 150px; background-color: lightyellow;">
                                <asp:Label ID="Label4" runat="server" Width="100%">Segundo Nombre</asp:Label>
                            </td>
                            <td class="ControlCell" 
                                style="width: 185px; background-color: lightyellow; text-align: left;">
                                <asp:TextBox ID="txt_SegundoNombre" runat="server" Width="90%" MaxLength="50" 
                                    TabIndex="12"></asp:TextBox>
                            </td>
                            <td class="ControlCell" style="width: 150px; background-color: lightyellow;">
                                <asp:Label ID="Label16" runat="server" Width="100%">Tipo de Identificación</asp:Label>
                            </td>
                            <td class="ControlCell" 
                                style="width: 180px; background-color: lightyellow; text-align: left;">
                                <asp:DropDownList ID="ddl_TipoIdentificacion" runat="server" Width="94%" 
                                    Font-Size="X-Small" TabIndex="13">
                                </asp:DropDownList>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="ddl_TipoIdentificacion"
                                    EnableClientScript="False" ErrorMessage="Falta Tipo de Identificación" ValidationExpression="^[1-9]+[0-9]*$"
                                    ValidationGroup="RI" ForeColor="Red">*</asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" style="width: 150px; background-color: lightyellow;">
                                <asp:Label ID="Label5" runat="server" Width="100%">Primer Apellido</asp:Label>
                            </td>
                            <td class="ControlCell" 
                                style="width: 185px; background-color: lightyellow; text-align: left;">
                                <asp:TextBox ID="Txt_PrimerApellido" runat="server" Width="90%" MaxLength="50" 
                                    TabIndex="14"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Txt_PrimerApellido"
                                    EnableClientScript="False" ErrorMessage="Ingresar el apellido del declarante"
                                    ValidationGroup="RI" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </td>
                            <td class="ControlCell" style="width: 150px; background-color: lightyellow;">
                                <asp:Label ID="Label3" runat="server" Width="100%">Segundo Apellido</asp:Label>
                            </td>
                            <td class="ControlCell" 
                                style="width: 185px; background-color: lightyellow; text-align: left;">
                                <asp:TextBox ID="txt_SegundoApellido" runat="server" Width="90%" MaxLength="50" 
                                    TabIndex="15"></asp:TextBox>
                            </td>
                            <td class="ControlCell" style="width: 150px; background-color: lightyellow;">
                                <asp:Label ID="Label15" runat="server" Width="100%">Número Identificación</asp:Label>
                            </td>
                            <td class="ControlCell" 
                                style="width: 180px; background-color: lightyellow; text-align: left;">
                                <asp:TextBox ID="txt_Identificacion" runat="server" MaxLength="20" Width="90%" 
                                    onkeypress="return ValNumero(this, event)" TabIndex="16"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txt_Identificacion"
                                    EnableClientScript="False" ErrorMessage="Ingresar Número de Identificación" ValidationGroup="RI"
                                    ForeColor="Red">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" style="width: 150px; background-color: lightyellow;">
                                <asp:Label ID="Label30" runat="server" Width="100%">Genero</asp:Label>
                            </td>
                            <td class="ControlCell" 
                                style="width: 185px; background-color: lightyellow; text-align: left;">
                                <asp:DropDownList ID="ddl_genero" runat="server" Width="94%" 
                                    Font-Size="X-Small" TabIndex="17">
                                </asp:DropDownList>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="ddl_genero"
                                    EnableClientScript="False" ErrorMessage="Falta Genero" ValidationExpression="^[1-9]+[0-9]*$"
                                    ValidationGroup="RI" ForeColor="Red">*</asp:RegularExpressionValidator>
                            </td>
                            <td class="ControlCell" style="width: 150px; background-color: lightyellow;">
                                <asp:Label ID="Label28" runat="server" Width="100%">Fecha de Nacimiento</asp:Label>
                            </td>
                            <td class="ControlCell" 
                                style="width: 185px; background-color: lightyellow; text-align: left;">
                                <telerik:RadDatePicker ID="rdpFechaNacimiento" runat="server" Culture="Spanish (Colombia)"
                                    MinDate=""  ToolTip="Seleccione Fecha ..." Width="95%" 
                                    TabIndex="18" Skin="Telerik">
                                    <Calendar  UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False"
                                        ViewSelectorText="x" Skin="Telerik">
                                        <FastNavigationSettings CancelButtonCaption="Cancelar" DateIsOutOfRangeMessage="Fecha Fuera de Rango"
                                            TodayButtonCaption="Hoy">
                                        </FastNavigationSettings>
                                    </Calendar>
                                    <DatePopupButton HoverImageUrl="" ImageUrl="" ToolTip="Abrir el Calendario" 
                                        TabIndex="18" />
                                    <DateInput DateFormat="dd/MM/yyyy" DisplayDateFormat="dd/MMMM/yyyy" 
                                        EmptyMessage="Fecha ..." TabIndex="18">
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
                            <td class="ControlCell" style="width: 150px; background-color: lightyellow;">
                                <asp:Button ID="btn_incluir" runat="server" CssClass="Boton" 
                                    Text="Ver inclusión" />
                            </td>
                            <td class="ControlCell" style="width: 180px; background-color: lightyellow;">
                                <asp:Label ID="lbl73" runat="server" style="color: #FF9933" Width="150px">....</asp:Label>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" colspan="6" style="background-color: orange; width: 100%;">
                                <asp:Label ID="Label41" runat="server" Width="22%" Font-Bold="True">Datos de Contacto</asp:Label>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" rowspan="5" style="width: 150px; background-color: lightyellow; text-align: center;"
                                align="left" valign="middle">
                                <asp:Label ID="Label7" runat="server" Width="100%">Seleccione los tipos de Contacto con este declarante o vulnerable</asp:Label>
                            </td>
                            <td class="ControlCell" colspan="2" rowspan="5" style="width: 330px; background-color: lightyellow;">
                                <asp:ListBox ID="Lst_Tipos_Contacto" runat="server" Height="100px" Width="98%" 
                                    Font-Size="X-Small" TabIndex="19">
                                </asp:ListBox>
                            </td>
                            <td class="ControlCell" style="width: 185px; background-color: lightyellow;">
                                <asp:Label ID="Label8" runat="server" Width="100%" Style="text-align: center">Digite valor para contacto</asp:Label>
                            </td>
                            <td class="ControlCell" colspan="2" rowspan="5" style="width: 330px; background-color: lightyellow;">
                                <asp:ListBox ID="Lst_Tipos_Contacto_Persona" runat="server" Height="100px" Width="98%"
                                    Font-Size="X-Small" TabIndex="23"></asp:ListBox>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="ControlCell" style="width: 185px; background-color: lightyellow;">
                                <asp:TextBox ID="txtvalor" runat="server" BackColor="ButtonFace" Width="96%" 
                                    Font-Size="X-Small" TabIndex="20" MaxLength="100"></asp:TextBox>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="ControlCell" style="width: 185px; background-color: lightyellow;">
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="ControlCell" style="width: 185px; background-color: lightyellow;" align="right">
                                <asp:LinkButton ID="LinkButton1" runat="server" TabIndex="21">Cargar</asp:LinkButton>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="ControlCell" 
                                style="width: 185px; background-color: lightyellow; text-align: left;">
                                <asp:LinkButton ID="LinkButton2" runat="server" TabIndex="22">Retirar</asp:LinkButton>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" colspan="6" style="background-color: orange; width: 100%;">
                                <asp:Label ID="Label42" runat="server" Font-Bold="True" ForeColor="Navy" Width="50%">Información para Inventarios</asp:Label>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" style="background-color: lightyellow;">
                                <asp:Label ID="Label9" runat="server" Width="100%">Niños Menores 5 Años</asp:Label>
                            </td>
                            <td class="ControlCell" style="background-color: lightyellow;">
                                <asp:TextBox ID="Txt_NinosMenores" runat="server" Style="text-align: right" onkeypress="return ValNumero(this, event)"
                                    MaxLength="2" Width="90%" TabIndex="24"></asp:TextBox>
                            </td>
                            <td class="ControlCell" style="background-color: lightyellow;">
                                <asp:Label ID="Label13" runat="server" Width="100%">Gestantes</asp:Label>
                            </td>
                            <td class="ControlCell" style="background-color: lightyellow;">
                                <asp:TextBox ID="Txt_Gestantes" runat="server" Style="text-align: right" onkeypress="return ValNumero(this, event)"
                                    MaxLength="2" Width="90%" TabIndex="25"></asp:TextBox>
                            </td>
                            <td class="ControlCell" style="background-color: lightyellow;">
                                <asp:Label ID="Label14" runat="server" Width="100%">Resto del Núcleo Familiar</asp:Label>
                            </td>
                            <td class="ControlCell" style="background-color: lightyellow;">
                                <asp:TextBox ID="Txt_RestoNucleo" runat="server" Style="text-align: right" onkeypress="return ValNumero(this, event)"
                                    MaxLength="2" Width="90%" TabIndex="26"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Txt_RestoNucleo"
                                    EnableClientScript="False" ErrorMessage="Ingresar Cantidad Personas Núcleo" ValidationGroup="RI"
                                    ForeColor="Red">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td align="left" class="LabelCell" 
                                style="width: 150px; background-color: lightyellow; text-align: center;" 
                                valign="middle">
                                <asp:Label ID="Label40" runat="server" Width="100%">Observaciones</asp:Label>
                            </td>
                            <td class="ControlCell" colspan="5" 
                                style="width: 850px; background-color: lightyellow; text-align: left;">
                                <asp:TextBox ID="txt_Observaciones" runat="server" MaxLength="4000" Rows="5" 
                                    TextMode="MultiLine" Width="96%" TabIndex="27"></asp:TextBox>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" colspan="6" style="background-color: orange; width: 100%;">
                                <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Navy" Width="50%">Opciones de Proceso con los registros </asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <asp:Panel ID="pnl_final" runat="server" Width="100%" Style="vertical-align: middle;
            text-align: center" TabIndex="28">
            <table border="0" cellpadding="0" cellspacing="0" style="width: 90%">
                <tr valign="top">
                    <td style="width: 15%; height: 16px;">
                        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="Boton" Width="100px"
                            TabIndex="1" ToolTip="Guardar el registro Inicial actual"></asp:Button>
                    </td>
                    <td style="width: 16%; height: 16px;">
                        <asp:Button ID="btnGuardarOtro" runat="server" Text="Guardar y agregar otro" CssClass="Boton"
                            Width="150px" TabIndex="2" 
                            ToolTip="Guardar el registro Inicial actual e iniciar uno nuevo"></asp:Button>
                    </td>
                    <td style="width: 15%; height: 16px;">
                        <asp:Button ID="btnEliminar" runat="server" Text='Eliminar' CssClass="Boton" Width="100px"
                            TabIndex="3" ToolTip="Eliminar el registro actual"></asp:Button>
                    </td>
                </tr>
            </table>

            
        </asp:Panel>
                <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
                </telerik:RadScriptManager>
            <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
                    Skin="Default" Transparency="50">
                    <asp:Image ID="Image1" runat="server" AlternateText="Cargando..." 
                        ImageUrl="~/Images/loading.gif" />
            </telerik:RadAjaxLoadingPanel>
                <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server" 
                    DefaultLoadingPanelID="RadAjaxLoadingPanel1">
                    <AjaxSettings>
                        <telerik:AjaxSetting AjaxControlID="ddl_regional">
                            <UpdatedControls>
                                <telerik:AjaxUpdatedControl ControlID="ddl_LugarFuente" 
                                    UpdatePanelCssClass="" />
                            </UpdatedControls>
                        </telerik:AjaxSetting>
                        <telerik:AjaxSetting AjaxControlID="btn_incluir">
                            <UpdatedControls>
                                <telerik:AjaxUpdatedControl ControlID="lbl73" UpdatePanelCssClass="" />
                            </UpdatedControls>
                        </telerik:AjaxSetting>
                        <telerik:AjaxSetting AjaxControlID="LinkButton1">
                            <UpdatedControls>
                                <telerik:AjaxUpdatedControl ControlID="Lst_Tipos_Contacto" 
                                    UpdatePanelCssClass="" />
                                <telerik:AjaxUpdatedControl ControlID="Lst_Tipos_Contacto_Persona" 
                                    UpdatePanelCssClass="" />
                                <telerik:AjaxUpdatedControl ControlID="txtvalor" UpdatePanelCssClass="" />
                            </UpdatedControls>
                        </telerik:AjaxSetting>
                        <telerik:AjaxSetting AjaxControlID="LinkButton2">
                            <UpdatedControls>
                                <telerik:AjaxUpdatedControl ControlID="Lst_Tipos_Contacto" 
                                    UpdatePanelCssClass="" />
                                <telerik:AjaxUpdatedControl ControlID="Lst_Tipos_Contacto_Persona" 
                                    UpdatePanelCssClass="" />
                                <telerik:AjaxUpdatedControl ControlID="txtvalor" UpdatePanelCssClass="" />
                            </UpdatedControls>
                        </telerik:AjaxSetting>
                    </AjaxSettings>
                </telerik:RadAjaxManager>



    </asp:Panel>
</asp:Content>

