<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="PrimeraEncuesta.aspx.vb" Inherits="WebForms_PrimeraEncuesta" %>
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
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Assembly="Telerik.Web.UI" 
                Name="Telerik.Web.UI.Common.Core.js">
            </asp:ScriptReference>
            <asp:ScriptReference Assembly="Telerik.Web.UI" 
                Name="Telerik.Web.UI.Common.jQuery.js">
            </asp:ScriptReference>
            <asp:ScriptReference Assembly="Telerik.Web.UI" 
                Name="Telerik.Web.UI.Common.jQueryInclude.js">
            </asp:ScriptReference>
        </Scripts>
    </telerik:RadScriptManager>
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

   <asp:Panel runat="server" ID="pnl_principal" DefaultButton ="btn_actualizar" Width ="100%">

        <asp:ValidationSummary ID="ValidationSummaryGB" runat="server" ValidationGroup="GB" ForeColor="Red" style="text-align: left" />
        <asp:ValidationSummary ID="ValidationSummaryGA" runat="server" ValidationGroup="GA" ForeColor="Red" style="text-align: left" />

        <table id="Table1" cellspacing="0" cellpadding="0" border="0" class="ContentTable" style="width: 100%">
            <tr valign="top">
                <td style="width: 75%; text-align: left;"> 
                    <asp:Label ID="lbl_Titulo" runat="server" Text="ENCUESTA PARA PRIMERA ENTREGA DE DESPLAZADOS" Width="90%" 
                        CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
                    <asp:Label ID="lblMensaje" runat="server" CssClass="TitMensaje" Text="_" Width="90%" Visible="False"/>
                </td>
                <td style="width: 25%" align="right">
                    <asp:ImageButton ID="btn_actualizar" runat="server" ImageUrl="~/Images/Reload.jpg" ToolTip="Actualizar la vista actual." TabIndex="5" />
                    <asp:ImageButton ID="btn_nuevo" runat="server" ImageUrl="~/Images/Add.jpg" 
                        ToolTip="Crear Nuevo Registro." TabIndex="6" Visible="False" />
                    <asp:ImageButton ID="btn_cerrar" runat="server" ImageUrl="~/Images/Stop.jpg" ToolTip="Cerrar - Volver a la vista anterior." TabIndex="7" />
                    <asp:ImageButton ID="btn_home" runat="server" ImageUrl="~/Images/Home.jpg" ToolTip="Ir al Inicio." TabIndex="8" />
                </td>
            </tr>

            <tr valign="top">
                <td colspan="2">
                    <table id="TablaContenido" cellspacing="0" cellpadding="0" border="0" class="ContentTable" width="100%">
                        <tr valign="top">
                            <td>
                                <table cellpadding="0" cellspacing ="0" border="0" id="tbldeclarante" style="width: 100%">
                                    <tr valign="top">
                                        <td style="background-color: darkblue;" colspan="6">
                                            <asp:Label ID="Label49" runat="server" ForeColor="Yellow" Font-Bold="True" Font-Italic="False">Información General del Declarante</asp:Label></td>
                                    </tr>
                                    <tr valign="top">
                                        <td style="width: 15%; height: 19px;">
                                            <asp:Label ID="Label98" runat="server" ForeColor="#C00000">NOMBRE COMPLETO</asp:Label></td>
                                        <td colspan="3" style="width: 55%; height: 19px;">
                                            <asp:Label ID="lbl_Nombre_Completo" runat="server" ForeColor="#C00000" Width="100%" Font-Size="Medium">NOMBRE COMPLETO</asp:Label></td>
                                        <td style="width: 15%; height: 19px;">
                                            <asp:Label ID="Label99" runat="server">GRUPO</asp:Label></td>
                                        <td style="width: 25%; height: 19px;" align="center">
                                            <asp:Label ID="lbl_Grupo" runat="server" Font-Bold="True" ForeColor="#C00000" Font-Size="Medium">GRUPO</asp:Label></td>
                                    </tr>
                                    <tr valign="top"><td style="width: 15%;">
                                        <asp:Label id="lblMenores" runat="server" Width="100%">Niños Menores 5 Años</asp:Label></td>
                                        <td style="width: 20%;">
                                            <asp:TextBox id="txt_NinosMenores" runat = "server" style="text-align: right" Width="90%" onkeypress="return ValNumero(this, event)" Font-Size="X-Small" MaxLength="2" BackColor="Control"></asp:TextBox></td>
                                        <td style="width: 15%;">
                                            <asp:Label ID="lblGestantes" runat="server" Width="100%">Mujeres Gestantes</asp:Label></td>
                                        <td style="width: 20%;">
                                            <asp:TextBox ID="Txt_Gestantes" runat="server" Style="text-align: right" Width="90%" onkeypress="return ValNumero(this, event)" Font-Size="X-Small" MaxLength="2" BackColor="Control"></asp:TextBox></td>
                                        <td style="width: 15%;">
                                            <asp:Label ID="Label54" runat="server" Width="100%">Resto del Núcleo</asp:Label></td>
                                        <td style="width: 25%">
                                            <asp:TextBox ID="Txt_RestoNucleo" runat="server" Style="text-align: right" Width="90%" onkeypress="return ValNumero(this, event)" Font-Size="X-Small" MaxLength="2" BackColor="Control"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Txt_RestoNucleo"
                                                    ErrorMessage="Ingresar Cantidad Personas Núcleo" ValidationGroup="GA" 
                                                ForeColor="Red">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>

                                </table>
                                <table cellpadding="0" cellspacing="0" border="1" style="width: 100%;">
                                    <tr valign="top">
                                        <td class="LabelCell" colspan="4" style="background-color: orange; width: 100%;">
                                            <asp:Label ID="Label109" runat="server" Width="22%" Font-Bold="True">Datos de Contacto</asp:Label></td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" rowspan="5" style="width: 150px">
                                            <asp:Label ID="Label110" runat="server" Width="100%">Seleccione los tipos de Contacto con este declarante o vulnerable</asp:Label></td>
                                        <td class="ControlCell"  rowspan="5" style="width: 333px">
                                            <asp:ListBox ID="Lst_Tipos_Contacto" runat="server" Height="100px" Width="98%" Font-Size="X-Small"></asp:ListBox></td>
                                        <td class="ControlCell" style="width: 183px; text-align: left;">
                                            <asp:Label ID="Label111" runat="server" Width="100%" style="text-align: center">Digite valor para contacto</asp:Label></td>
                                        <td class="ControlCell"  rowspan="5" style="width: 333px">
                                            <asp:ListBox ID="Lst_Tipos_Contacto_Persona" runat="server" Height="100px" Width="98%" Font-Size="X-Small">
                                            </asp:ListBox></td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="ControlCell" style="width: 183px; text-align: left;">
                                            <asp:TextBox ID="txtvalor" runat="server" BackColor="ButtonFace" Width="96%"></asp:TextBox></td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="ControlCell" style="width: 183px; text-align: left;">
                                            <asp:Label ID="lbl_actcontacto" runat="server" Style="text-align: center" Visible="False"
                                                Width="20px">0</asp:Label>
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="ControlCell" style="width: 183px; text-align: left;" align="center">
                                            <asp:LinkButton ID="LinkButton1" runat="server">Cargar</asp:LinkButton></td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="ControlCell" style="width: 183px; text-align: right">
                                            <asp:LinkButton ID="LinkButton2" runat="server">Retirar</asp:LinkButton></td>
                                    </tr>
                                    <tr valign="top">
                                        <td style="width: 100%; background-color: darkblue;" colspan="4">
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <table border="0" cellpadding="0" cellspacing="0" width="100%"  > 
            <tr>
                <td>
                    <telerik:RadTabStrip ID="RadTabStrip1" runat="server" SelectedIndex="0" 
                        Skin="Windows7" MultiPageID="RadMultiPage1" ResolvedRenderMode="Classic">
                        <Tabs>
                            <telerik:RadTab runat="server" SelectedIndex="0" 
                                Text="Beneficiarios del Declarante" Selected="True">
                            </telerik:RadTab>
                            <telerik:RadTab runat="server" SelectedIndex="1" 
                                Text="Encuesta de Primera Entrega">
                            </telerik:RadTab>
                            <telerik:RadTab runat="server" Text="Información PAARI">
                            </telerik:RadTab>
                        </Tabs>
                    </telerik:RadTabStrip>
                    <telerik:RadMultiPage ID="RadMultiPage1" runat="server" SelectedIndex="0">
                        <telerik:RadPageView ID="RadPageView1" runat="server">
                            <table ID="tbl_personas" border="0" cellpadding="2" cellspacing="0" 
                                width="1000">
                                <tr valign="top">
                                    <td colspan="6" style="background-color: orange; width: 100%;">
                                        <asp:Label ID="Label67" runat="server" ForeColor="Navy" Width ="900px">Composición y Características Básicas del Hogar</asp:Label>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td style="width: 15%" valign="top">
                                        <asp:Label ID="Label70" runat="server" Width="100%">Tipo de Miembro</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;" valign="top">
                                        <asp:DropDownList ID="Ddl_Tipo_Miembro" runat="server" Font-Size="X-Small" 
                                            Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_Tipo_Miembro" runat="server" 
                                            ControlToValidate="Ddl_Tipo_Miembro" 
                                            ErrorMessage="Falta seleccionar el tipo de miembro" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GB">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="width: 15%" valign="top">
                                        <asp:Label ID="Label75" runat="server" Width="100%">Grupo Etnico</asp:Label>
                                    </td>
                                    <td style="width: 20%; " valign="top">
                                        <asp:DropDownList ID="ddl_Grupo_Etnico" runat="server" Font-Size="X-Small" 
                                            Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator39" 
                                            runat="server" ControlToValidate="ddl_Grupo_Etnico" 
                                            ErrorMessage="Falta Grupo etnico" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GB">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="width: 15%" valign="top">
                                        <asp:Label ID="Label32" runat="server" Width="100%">Tipo de Persona</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;" valign="top">
                                        <asp:RadioButton ID="rdb_Declarante" runat="server" Enabled="False" 
                                            Font-Size="XX-Small" GroupName="Miembro" Text="Declarante" Width="48%" />
                                        <asp:RadioButton ID="rdb_Beneficiario" runat="server" Checked="True" 
                                            Enabled="False" Font-Size="XX-Small" GroupName="Miembro" Text="Beneficiario" 
                                            Width="48%" />
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td style="width: 15%" valign="top">
                                        <asp:Label ID="Label56" runat="server" Width="100%">Primer Nombre</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;" valign="top">
                                        <asp:TextBox ID="txt_Nombre1" runat="server" Font-Size="X-Small" Width="92%" 
                                            MaxLength="50"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                            ControlToValidate="txt_Nombre1" 
                                            ErrorMessage="Ingresar el Nombre del declarante" ForeColor="Red" 
                                            ValidationGroup="GB">*</asp:RequiredFieldValidator>
                                    </td>
                                    <td style="width: 15%" valign="top">
                                        <asp:Label ID="Label58" runat="server" Width="100%">Segundo Nombre</asp:Label>
                                    </td>
                                    <td style="width: 20%; " valign="top">
                                        <asp:TextBox ID="Txt_Nombre2" runat="server" Font-Size="X-Small" Width="92%" 
                                            MaxLength="50"></asp:TextBox>
                                    </td>
                                    <td style="width: 15%" valign="top">
                                        <asp:Label ID="Label65" runat="server" Width="100%" Height="16px">Genero</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;" valign="top">
                                        <asp:DropDownList ID="ddl_Genero" runat="server" AutoPostBack="True" 
                                            Font-Size="X-Small" Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" 
                                            ControlToValidate="ddl_Genero" ErrorMessage="Falta Genero" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GB">*</asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td style="width: 15%;">
                                        <asp:Label ID="Label57" runat="server" Width="100%">Primer Apellido</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;">
                                        <asp:TextBox ID="Txt_Apellido1" runat="server" Font-Size="X-Small" Width="92%" 
                                            MaxLength="50"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                            ControlToValidate="Txt_Apellido1" 
                                            ErrorMessage="Ingresar el Apellido del declarante" ForeColor="Red" 
                                            ValidationGroup="GB">*</asp:RequiredFieldValidator>
                                    </td>
                                    <td style="width: 15%;">
                                        <asp:Label ID="Label59" runat="server" Width="100%">Segundo Apellido</asp:Label>
                                    </td>
                                    <td style="width: 20%; ">
                                        <asp:TextBox ID="Txt_Apellido2" runat="server" Font-Size="X-Small" Width="92%" 
                                            MaxLength="50"></asp:TextBox>
                                    </td>
                                    <td style="width: 15%;">
                                        <asp:Label ID="Label35" runat="server" Width="100%">Parentesco</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;">
                                        <asp:DropDownList ID="ddl_Parentesco" runat="server" Font-Size="X-Small" 
                                            Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_parentesco" runat="server" 
                                            ControlToValidate="ddl_Parentesco" ErrorMessage="Falta Parentesco" 
                                            ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GB">*</asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td style="width: 15%;">
                                        <asp:Label ID="lblSubTablasId_Condicion_Especial" runat="server" Width="100%">Tipo de Identificación</asp:Label>
                                    </td>
                                    <td style="width: 20%;">
                                        <asp:DropDownList ID="ddl_Tipo_Identificacion" runat="server" 
                                            Font-Size="X-Small" Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator36" 
                                            runat="server" ControlToValidate="ddl_Tipo_Identificacion" 
                                            ErrorMessage="Falta Tipo de Identificación" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GB">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="width: 15%;">
                                        <asp:Label ID="Label62" runat="server" Width="100%">Fecha de Nacimiento</asp:Label>
                                    </td>
                                    <td style="width: 20%; " >
                                        <telerik:RadDatePicker ID="rdpfechaNacimiento" runat="server" 
                                            Culture="es-CO" MinDate="" Skin="Telerik" TabIndex="1" 
                                            ToolTip="Seleccione Fecha ..." Width="95%" ResolvedRenderMode="Classic">
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
                                        <asp:RequiredFieldValidator ID="rfv_FechaNacimiento" runat="server" 
                                            ControlToValidate="rdpfechaNacimiento" 
                                            ErrorMessage="Ingresar la Fecha de Nacimiento " ForeColor="Red" 
                                            ValidationGroup="GB">*</asp:RequiredFieldValidator>
                                    </td>
                                    <td style="width: 15%;">
                                        <asp:Label ID="Label55" runat="server" Width="100%">Edad</asp:Label>
                                    </td>
                                    <td style="width: 20%;">
                                        <asp:TextBox ID="txt_edad" runat="server" AutoPostBack="True" 
                                            Font-Size="X-Small" MaxLength="3" Width="48px"></asp:TextBox>
                                        <asp:Label ID="lblid0" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td style="width: 15%">
                                        <asp:Label ID="Label66" runat="server" Width="100%">Identificación</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;">
                                        <asp:TextBox ID="txt_Identificacion" runat="server" Font-Size="X-Small" 
                                            MaxLength="50" onkeypress="return ValNumero(this, event)" Width="92%"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                            ControlToValidate="txt_Identificacion" 
                                            ErrorMessage="Ingresar Número de Identificación" ForeColor="Red" 
                                            ValidationGroup="GB">*</asp:RequiredFieldValidator>
                                    </td>
                                    <td style="width: 15%">
                                        <asp:Label ID="Label72" runat="server" Width="100%">Esta Embarazada?</asp:Label>
                                    </td>
                                    <td style="width: 20%; ">
                                        <asp:DropDownList ID="ddl_Embarazada" runat="server" Enabled="False" 
                                            Font-Size="X-Small" Width="90%">
                                        </asp:DropDownList>
                                    </td>
                                    <td style="width: 15%">
                                        <asp:Label ID="Label73" runat="server" Width="100%">Esta Lactando?</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;">
                                        <asp:DropDownList ID="ddl_lactando" runat="server" Enabled="False" 
                                            Font-Size="X-Small" Width="90%">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td colspan="6" style="width: 100%; background-color: orange;">
                                        <asp:Label ID="Label41" runat="server" Font-Bold="True" ForeColor="Navy">Derecho a Salud - Miembros del Hogar</asp:Label>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td style="width: 15%;">
                                        <asp:Label ID="Label46" runat="server" Width="150px">Discapacitado</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;">
                                        <asp:DropDownList ID="ddl_Discapacitado" runat="server" AutoPostBack="True" 
                                            Font-Size="X-Small" Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_discapacitado" runat="server" 
                                            ControlToValidate="ddl_Discapacitado" 
                                            ErrorMessage="Falta Si esta Discapacitado" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GB">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="width: 15%;">
                                        <asp:Label ID="Label69" runat="server" Width="100%">Tipo de Discapacidad</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;">
                                        <asp:DropDownList ID="ddl_Tipo_Discapacidad" runat="server" Enabled="False" 
                                            Font-Size="X-Small" Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rfv_tipodiscapacidad" runat="server" 
                                            ControlToValidate="ddl_Tipo_Discapacidad" 
                                            ErrorMessage="Falta tipo de  Discapacidad" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GB" Enabled="False">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="width: 15%;">
                                        <asp:Label ID="lblid" runat="server"></asp:Label>
                                    </td>
                                    <td style="width: 20%" class="style1">
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td style="width: 15%;">
                                        <asp:Label ID="lblSubTablasId_Regimen_Salud" runat="server" Width="100%">Regimen de Salud Antes</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;">
                                        <asp:DropDownList ID="ddl_Regimen_Salud_Antes" runat="server" 
                                            Font-Size="X-Small" Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="Rev_Regimen_Antes" runat="server" 
                                            ControlToValidate="ddl_Regimen_Salud_Antes" 
                                            ErrorMessage="Falta Regimen de Salud Antes del desplazamiento" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GB">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="width: 15%;">
                                        <asp:Label ID="Label33" runat="server" Width="100%">E.P.S. Antes</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;">
                                        <asp:DropDownList ID="ddl_Eps_Antes" runat="server" Font-Size="X-Small" 
                                            Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_eps_antes" runat="server" 
                                            ControlToValidate="ddl_eps_Antes" ErrorMessage="Falta EPS Antes" 
                                            ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GB">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="width: 15%;">
                                        <asp:Label ID="Label36" runat="server" Width="100%">Municipio Afiliación Antes</asp:Label>
                                    </td>
                                    <td style="width: 20%; " class="style1">
                                        <asp:DropDownList ID="ddl_departamento_rsa" runat="server" AutoPostBack="True" 
                                            Font-Size="X-Small" Width="90%">
                                        </asp:DropDownList>
                                        <asp:DropDownList ID="ddl_municipio_rsa" runat="server" Font-Size="X-Small" 
                                            Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_municipio_rsa" runat="server" 
                                            ControlToValidate="ddl_municipio_rsa" 
                                            ErrorMessage="Falta municipio regimen salud antes" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GB">*</asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td style="width: 15%;">
                                        <asp:Label ID="Label26" runat="server" Width="100%">Regimen de Salud Después</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;">
                                        <asp:DropDownList ID="ddl_Regimen_Salud_Despues" runat="server" 
                                            Font-Size="X-Small" Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_Regimen_Despues" runat="server" 
                                            ControlToValidate="ddl_Regimen_Salud_Despues" 
                                            ErrorMessage="Falta Regimen de Salud Después del desplazamiento" 
                                            ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GB">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="width: 15%;">
                                        <asp:Label ID="Label34" runat="server" Width="100%">E.P.S. Después</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;">
                                        <asp:DropDownList ID="ddl_Eps_Despues" runat="server" Font-Size="X-Small" 
                                            Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_eps_despues" runat="server" 
                                            ControlToValidate="ddl_Eps_Despues" ErrorMessage="Falta EPS Después" 
                                            ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GB">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="width: 15%;">
                                        <asp:Label ID="Label37" runat="server" Width="100%">Municipio Afiliación Después</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;">
                                        <asp:DropDownList ID="ddl_departamento_rsd" runat="server" AutoPostBack="True" 
                                            Font-Size="X-Small" Width="90%">
                                        </asp:DropDownList>
                                        <asp:DropDownList ID="ddl_municipio_rsd" runat="server" Font-Size="X-Small" 
                                            Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_municipio_rsd" runat="server" 
                                            ControlToValidate="ddl_municipio_rsd" 
                                            ErrorMessage="Falta municipio regimen salud despues" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GB">*</asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td colspan="6" style="width: 100%; background-color: orange;">
                                        <asp:Label ID="Label74" runat="server" Font-Bold="True" ForeColor="Navy">Derecho a Educación - Miembros del Hogar</asp:Label>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td style="width: 15%">
                                        <asp:Label ID="Label42" runat="server" Width="150px">Sabe leer o escribir</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;">
                                        <asp:DropDownList ID="ddl_Sabe_Leer" runat="server" Enabled="False" 
                                            Font-Size="X-Small" Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_Sabe_Leer" runat="server" 
                                            ControlToValidate="ddl_Sabe_Leer" Enabled="False" 
                                            ErrorMessage="Falta si sabe leer o escribir" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GB">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="width: 15%">
                                        <asp:Label ID="Label47" runat="server" Width="150px">Ultimo Grado</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;">
                                        <asp:DropDownList ID="ddl_UltimoGrado" runat="server" Enabled="False" 
                                            Font-Size="X-Small" Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_grado" runat="server" 
                                            ControlToValidate="ddl_UltimoGrado" Enabled="False" 
                                            ErrorMessage="Falta el grado actual o último grado realizado" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GB">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="width: 15%">
                                        &nbsp;</td>
                                    <td style="width: 20%; ">
                                        &nbsp;</td>
                                </tr>
                                <tr valign="top">
                                    <td style="width: 15%;">
                                        <asp:Label ID="Label38" runat="server" Width="150px">Estudiaba Antes</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;">
                                        <asp:DropDownList ID="ddl_EstudiabaAntes" runat="server" Enabled="False" 
                                            Font-Size="X-Small" Width="90%" AutoPostBack="True">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_Estudiaba_Antes" runat="server" 
                                            ControlToValidate="ddl_EstudiabaAntes" Enabled="False" 
                                            ErrorMessage="Falta si estudiaba antes" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GB">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="width: 15%;">
                                        <asp:Label ID="Label44" runat="server" Width="150px">Institución donde estudiaba</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;">
                                        <asp:TextBox ID="txt_Institucion_Estudiaba" runat="server" Enabled="False" 
                                            Font-Size="X-Small" MaxLength="100" Width="90%"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfv_Institucion_Estudiaba" runat="server" 
                                            ControlToValidate="txt_Institucion_Estudiaba" 
                                            ErrorMessage="Falta inst. donde estudiaba" ForeColor="Red" 
                                            ValidationGroup="GB" Enabled="False">*</asp:RequiredFieldValidator>
                                    </td>
                                    <td style="width: 15%;">
                                        <asp:Label ID="Label483" runat="server" Width="150px">Municipio Institución</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;">
                                        <asp:DropDownList ID="ddl_departamento_antes" runat="server" 
                                            AutoPostBack="True" Enabled="False" Font-Size="X-Small" Width="90%">
                                        </asp:DropDownList>
                                        <asp:DropDownList ID="ddl_municipio_instituto_antes" runat="server" 
                                            Font-Size="X-Small" Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_municipio_antes" runat="server" 
                                            ControlToValidate="ddl_municipio_instituto_antes" Enabled="False" 
                                            ErrorMessage="Falta municipio instituto antes" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GB">*</asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td style="width: 15%;">
                                        <asp:Label ID="Label43" runat="server" Width="150px">Estudia Actualmente</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;">
                                        <asp:DropDownList ID="ddl_EstudiaActualmente" runat="server" 
                                            AutoPostBack="True" Enabled="False" Font-Size="X-Small" Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_Estudia_Actualmente" runat="server" 
                                            ControlToValidate="ddl_EstudiaActualmente" Enabled="False" 
                                            ErrorMessage="Falta si estudia actualmente" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GB">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="width: 15%;">
                                     
                                        <asp:Label ID="Label39" runat="server" Width="150px">Institución donde estudia</asp:Label>
                                     
                                    </td>
                                    <td style="width: 20%; text-align: left;">
                                        <asp:TextBox ID="txt_Institucion_Estudia" runat="server" Enabled="False" 
                                            Font-Size="X-Small" MaxLength="100" Width="90%"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfv_Institucion_Estudia" runat="server" 
                                            ControlToValidate="txt_Institucion_Estudia" EnableTheming="True" 
                                            ErrorMessage="Falta inst. donde estudia" ForeColor="Red" 
                                            ValidationGroup="GB" Enabled="False">*</asp:RequiredFieldValidator>
                                    </td>
                                    <td style="width: 15%;">
                                        <asp:Label ID="Label484" runat="server" Width="150px">Municipio Institución</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;">
                                        <asp:DropDownList ID="ddl_departamento_actual" runat="server" 
                                            AutoPostBack="True" Enabled="False" Font-Size="X-Small" Width="90%">
                                        </asp:DropDownList>
                                        <asp:DropDownList ID="ddl_municipio_instituto_actual" runat="server" 
                                            Font-Size="X-Small" Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_municipio_actual" runat="server" 
                                            ControlToValidate="ddl_municipio_instituto_actual" Enabled="False" 
                                            ErrorMessage="Falta municipio instituto actual" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GB">*</asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td style="width: 15%;">
                                        <asp:Label ID="Label481" runat="server" Width="150px">Motivo No Estudio</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;">
                                        <asp:DropDownList ID="ddl_MotivoNoEstudio" runat="server" AutoPostBack="True" 
                                            Enabled="False" Font-Size="X-Small" Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_Motivo_NoEstudiar" runat="server" 
                                            ControlToValidate="ddl_MotivoNoEstudio" Enabled="False" 
                                            ErrorMessage="Falta el Motivo de No estudiar Actualmente" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GB">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="width: 15%;">
                                        <asp:Label ID="Label120" runat="server" Width="150px">Trajo certificación</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;">
                                        <asp:DropDownList ID="ddl_certificacion" runat="server" Enabled="False" 
                                            Font-Size="X-Small" Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_certificacion" runat="server" 
                                            ControlToValidate="ddl_certificacion" Enabled="False" 
                                            ErrorMessage="Falta Certificación Estudio" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GB">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="width: 15%;">
                                        <asp:Label ID="Label121" runat="server" Width="150px">Tipo de Apoyo Escolar</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;">
                                        <asp:DropDownList ID="Ddl_Tipo_Apoyo_Escolar" runat="server" Enabled="False" 
                                            Font-Size="X-Small" Width="90%" />
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td colspan="6" style="width: 100%; background-color: orange;">
                                        <asp:Label ID="Label86" runat="server" Font-Bold="True" ForeColor="Navy">Datos Psicologicos .. (se llenan en encuesta)</asp:Label>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td style="width: 15%;">
                                        <asp:Label ID="Label48" runat="server" Width="90%">Solicito</asp:Label>
                                    </td>
                                    <td style="width: 20%;">
                                        <asp:Label ID="lbl_Solicito" runat="server" Width="90%">Sin Dato !!! </asp:Label>
                                    </td>
                                    <td style="width: 15%;">
                                        <asp:Label ID="Label451" runat="server" Width="90%">Recibio</asp:Label>
                                    </td>
                                    <td style="width: 20%;">
                                        <asp:Label ID="lbl_Recibio_Atencion" runat="server">Sin Dato !!!</asp:Label>
                                    </td>
                                    <td style="width: 15%; background-color: white;">
                                        <asp:Label ID="Label115" runat="server" Width="90%">Solicito</asp:Label>
                                    </td>
                                    <td style="width: 20%;">
                                        <asp:Label ID="Lbl_Afectado_Desplazamiento" runat="server">Sin Dato !!!</asp:Label>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td style="width: 15%;">
                                        <asp:Label ID="Label100" runat="server" Width="90%">Quien Atendió?</asp:Label>
                                    </td>
                                    <td colspan="3" style="background-color: white">
                                        <asp:Label ID="lbl_Quien_Atendio" runat="server">Sin Dato !!!</asp:Label>
                                    </td>
                                    <td style="width: 15%; background-color: white">
                                    </td>
                                    <td style="width: 20%; background-color: white">
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td align="center" colspan="6" style="background-color: papayawhip;">
                                        <asp:Button ID="Btn_GuardarPersona" runat="server" Cssclass="Boton" 
                                            Text="Guardar" ToolTip="Guardar el registro del beneficiario" Width="100px" />
                                        <asp:Button ID="btnLimpiar" runat="server" Cssclass="Boton" Text="Nuevo" 
                                            ToolTip="Generar un nuevo registro de beneficiario" Width="100px" />
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td colspan="6">
                                        <telerik:RadGrid ID="Rg_Listado" runat="server" AllowSorting="True" GridLines="None" Skin="WebBlue" Width="100%" 
                                            AutoGenerateColumns="False" ShowStatusBar="True" TabIndex="6" PageSize="20" CellSpacing="0" OnItemCommand="subCommandItem" >
                                            <MasterTableView  NoDetailRecordsText="No hay informaci&#243;n." 
                                                NoMasterRecordsText="No hay informaci&#243;n." DataKeyNames="Id" 
                                                CommandItemDisplay ="Top" AllowPaging="True">
                                                <Columns>
                                                    <telerik:GridTemplateColumn HeaderText="No." DefaultInsertValue="" UniqueName="TemplateColumn">
                                                        <ItemTemplate>
                                                            <asp:label runat="server" id="lblno" text='<%# ctype(CType(Container.Parent.Parent.Parent,RadGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>' ToolTip ='<%#Container.DataItem.Id%>' />
                                                            <asp:Label runat="Server" Id="lblid" Visible ="False" Text ='<%#Container.DataItem.Id%>'/>
                                                        </ItemTemplate>
                                                    </telerik:GridTemplateColumn>                                
                                                    <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" HeaderText="Id" 
                                                        SortExpression="Id" UniqueName="Id" Display="False">
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridBoundColumn DataField="Tipo" HeaderText="Tipo" 
                                                        SortExpression="Tipo" UniqueName="Tipo">
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                            Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                            Wrap="True" />
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridBoundColumn DataField="Identificacion" HeaderText="Identificación" 
                                                        SortExpression="Identificacion" UniqueName="Identificacion">
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                            Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                            Wrap="True" />
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridBoundColumn DataField="NombreCompleto" HeaderText="Nombre Completo" 
                                                        SortExpression="NombreCompleto" UniqueName="NombreCompleto">
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                            Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                            Wrap="True" />
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridBoundColumn DataField="ParentescoPersona" HeaderText="Parentesco" 
                                                        SortExpression="ParentescoPersona" UniqueName="ParentescoPersona">
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                            Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                            Wrap="True" />
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridBoundColumn DataField="Edad" HeaderText="Edad" 
                                                        SortExpression="Edad" UniqueName="Edad">
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                            Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                            Wrap="True" />
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridBoundColumn DataField="Estudiaba_Actualmente"  HeaderTooltip ="Estudia Actualmente?"
                                                        HeaderText="Estudia" SortExpression="Estudiaba_Actualmente" UniqueName="Estudiaba_Actualmente">
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                            Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                            Wrap="True" />
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridBoundColumn DataField="Persona_Grupo_Etnico" HeaderText="Etnia" 
                                                        SortExpression="Persona_Grupo_Etnico" UniqueName="Persona_Grupo_Etnico">
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                            Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                            Wrap="True" />
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridBoundColumn DataField="Persona_Regimen_Salud_Antes" HeaderTooltip ="Reg. Salud Antes del Desplazamiento"
                                                        HeaderText="Reg. Salud" SortExpression="Persona_Regimen_Salud_Antes" 
                                                        UniqueName="Persona_Regimen_Salud_Antes">
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                            Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                            Wrap="True" />
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridBoundColumn DataField="EPS_Antes_Persona" headertooltip ="EPS Antes del Desplazamiento"
                                                        HeaderText="EPS" SortExpression="EPS_Antes_Persona" 
                                                        UniqueName="EPS_Antes_Persona">
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                            Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                            Wrap="True" />
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridButtonColumn ButtonType="ImageButton" ConfirmDialogType="Classic"  CommandName ="EliminarBeneficiario"
                                                        ConfirmText="Desea eliminar este registro?" ConfirmTitle="Borrar Beneficiario." 
                                                        HeaderText="X" HeaderTooltip="Eliminar Registro de Beneficiario " 
                                                        ImageUrl="../Images/balde.gif" UniqueName="Borrar">
                                                        <ItemStyle HorizontalAlign="Center" Width="10px" />
                                                        <HeaderStyle HorizontalAlign="Center" />
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
                    
                                             <ExportSettings  Excel-Format ="ExcelML" SuppressColumnDataFormatStrings ="true"
                                               HideStructureColumns="True" filename ="Beneficiarios" ExportOnlyData="True" IgnorePaging="True" OpenInNewWindow="True">
                                                 <Pdf PageWidth="" >
                                                 </Pdf>
                                                 <Excel Format="ExcelML" />
                                            </ExportSettings>
                                            <SortingSettings SortToolTip="Clic aqui para ordenar..."  SortedAscToolTip ="Ordenar Ascendente" SortedDescToolTip ="Ordenar Descendente" />
                                            <PagerStyle Mode="NumericPages" AlwaysVisible="True"    />
                
                                        </telerik:RadGrid>
                                    </td>
                                </tr>
                            </table>
                        </telerik:RadPageView>
                        <telerik:RadPageView ID="RadPageView2" runat="server">
                            <table ID="tblContenido" border="0" cellpadding="2" cellspacing="0" 
                                class="EditControlsTable" width="1000">
                                <tr valign="top">
                                    <td align="center" class="LabelCell" colspan="4" 
                                        style="background-color: activecaption; width: 100%;">
                                        <asp:Label ID="Label31" runat="server" Font-Bold="True" ForeColor="Navy">INICIO  DE  LA  ENCUESTA # 1</asp:Label>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" colspan="4" style="width: 25%; background-color: orange;">
                                        <asp:Label ID="Label76" runat="server" Font-Bold="True" ForeColor="Navy">Vivienda</asp:Label>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%;">
                                        <asp:Label ID="Label77" runat="server" Width="96%">Tipo de tenencia</asp:Label>
                                    </td>
                                    <td class="style1" style="width: 25%;">
                                        <asp:DropDownList ID="ddl_Tipo_Tenencia" runat="server" Font-Size="X-Small" 
                                            Width="96%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" 
                                            ControlToValidate="ddl_Tipo_Tenencia" ErrorMessage="Falta Tipo de Tenencia" 
                                            ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td class="ControlCell" style="width: 25%;">
                                        <asp:Label ID="Label79" runat="server" Width="96%">Cuantas Habitaciones tiene la vivienda</asp:Label>
                                    </td>
                                    <td class="style1" style="width: 25%;">
                                        <asp:DropDownList ID="ddl_Cuantas_habitaciones" runat="server" 
                                            Font-Size="X-Small" Width="96%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator10" 
                                            runat="server" ControlToValidate="ddl_Cuantas_habitaciones" 
                                            ErrorMessage="Falta Cuantas Habitaciones hay?" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%">
                                        <asp:Label ID="Label81" runat="server" Width="96%">Cuantas Personas habitan la vivienda?</asp:Label>
                                    </td>
                                    <td class="style1" style="width: 25%">
                                        <asp:DropDownList ID="ddl_Cuantas_Personas_Habitan" runat="server" 
                                            Font-Size="X-Small" Width="96%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator11" 
                                            runat="server" ControlToValidate="ddl_Cuantas_Personas_Habitan" 
                                            ErrorMessage="Falta Cuantas personas habitan" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:Label ID="Label78" runat="server" Width="96%">Número Personas en su Habitación</asp:Label>
                                    </td>
                                    <td class="style1" style="width: 25%">
                                        <asp:DropDownList ID="ddl_Personas_Habitacion" runat="server" 
                                            Font-Size="X-Small" Width="96%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator14" 
                                            runat="server" ControlToValidate="ddl_Personas_Habitacion" 
                                            ErrorMessage="Falta No. Personas Por Habitación" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%">
                                        <asp:Label ID="Label80" runat="server" Font-Bold="False" Width="96%">Materiales de la Vivienda</asp:Label>
                                    </td>
                                    <td class="style1" style="width: 25%">
                                        <asp:DropDownList ID="ddl_Materiales_Vivienda" runat="server" 
                                            Font-Size="X-Small" Width="96%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator12" 
                                            runat="server" ControlToValidate="ddl_Materiales_Vivienda" 
                                            ErrorMessage="Falta materiales de vivienda" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:Label ID="Label114" runat="server" Width="96%">Registro Cerrado</asp:Label>
                                    </td>
                                    <td class="style1" style="width: 25%">
                                        <asp:CheckBox ID="Chb_Cerrado" runat="server" Enabled="False" />
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%">
                                        <asp:Label ID="Label15" runat="server" Width="96%">De donde obtiene el agua para beber y cocinar?</asp:Label>
                                    </td>
                                    <td class="style1" style="width: 25%">
                                        <asp:ListBox ID="Lst_ObtieneAgua" runat="server" AutoPostBack="True" 
                                            BackColor="Gainsboro" Font-Size="X-Small" Width="96%"></asp:ListBox>
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:Label ID="Label16" runat="server" Width="96%">Seleccione o Retire con clic en cada casilla los lugares de donde obtiene el agua el declarante</asp:Label>
                                    </td>
                                    <td class="style1" style="width: 25%">
                                        <asp:ListBox ID="Lst_ObtieneAguaDeclarante" runat="server" AutoPostBack="True" 
                                            BackColor="ControlLight" Font-Size="X-Small" Width="96%"></asp:ListBox>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%">
                                        <asp:Label ID="Label50" runat="server" Width="96%">El agua que consumen es potable?</asp:Label>
                                    </td>
                                    <td class="style1" style="width: 25%">
                                        <asp:DropDownList ID="ddl_Agua_Potable" runat="server" 
                                            Font-Size="X-Small" Width="96%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_aguapotable" runat="server" 
                                            ControlToValidate="ddl_Agua_Potable" ErrorMessage="Falta Dato de agua potable" 
                                            ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                        &nbsp;</td>
                                    <td class="style1" style="width: 25%">
                                        &nbsp;</td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" colspan="4" style="width: 25%; background-color: orange;">
                                        <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Navy">Información sobre el Desplazamiento</asp:Label>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%;">
                                        <asp:Label ID="lblFecha_Desplazamiento" runat="server" Width="96%">Fecha Desplazamiento</asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 25%;">
                                        <telerik:RadDatePicker ID="rdpfechaDesplazamiento" runat="server" 
                                            Culture="Spanish (Colombia)" MinDate="" Skin="Telerik" TabIndex="1" 
                                            ToolTip="Seleccione Fecha ..." Width="95%">
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
                                        <asp:RequiredFieldValidator ID="rfv_FechaDesplazamiento" runat="server" 
                                            ControlToValidate="rdpfechaDesplazamiento" 
                                            ErrorMessage="Falta Fecha de Desplazamiento" ForeColor="Red" 
                                            ValidationGroup="GA">*</asp:RequiredFieldValidator>
                                    </td>
                                    <td class="ControlCell" style="width: 25%;">
                                        <asp:Label ID="Label3" runat="server" Width="96%">Tipo Desplazamiento</asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 25%;">
                                        <asp:DropDownList ID="Ddl_Tipo_desplazamiento" runat="server" 
                                            Font-Size="X-Small" Width="96%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator15" 
                                            runat="server" ControlToValidate="Ddl_Tipo_desplazamiento" 
                                            ErrorMessage="Falta Tipo de Desplazamiento" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%">
                                        <asp:Label ID="Label4" runat="server" Width="96%">Departamento Expulsor</asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:DropDownList ID="ddl_Departamento_Expulsor" runat="server" 
                                            AutoPostBack="True" Font-Size="X-Small" Width="96%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator13" 
                                            runat="server" ControlToValidate="ddl_Departamento_Expulsor" 
                                            ErrorMessage="Falta Dato de Departamento" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:Label ID="lblSubTablasId_Municipio_Expulsor" runat="server" Width="96%">Municipio Expulsor</asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:DropDownList ID="ddl_Municipio_Expulsor" runat="server" 
                                            AutoPostBack="True" Enabled="False" Font-Size="X-Small" Width="96%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_MunicipioExpulsor" runat="server" 
                                            ControlToValidate="ddl_Municipio_Expulsor" 
                                            ErrorMessage="Falta Municipio Expulsor" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%">
                                        <asp:Label ID="Label52" runat="server" Width="96%">Concejo / Resguardo Expulsor</asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:DropDownList ID="Ddl_Concejo_Expulsor" runat="server" Enabled="False" 
                                            Font-Size="X-Small" Width="96%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_ConcejoExpulsor" runat="server" 
                                            ControlToValidate="Ddl_Concejo_Expulsor" ErrorMessage="Falta Concejo Expulsor" 
                                            ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:Label ID="lblId_Vereda_Expulsor" runat="server" Width="96%">Vereda Expulsor</asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:TextBox ID="txt_vereda" runat="server" Enabled="False" Font-Size="X-Small" 
                                            MaxLength="100" Width="92%"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%">
                                        <asp:Label ID="Label5" runat="server" Width="96%">Cuantas Veces su familia ha sido desplazada</asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:DropDownList ID="ddl_Cuantos_Desplazamientos" runat="server" 
                                            Font-Size="X-Small" Width="96%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_Cuantos_Desplazamientos" runat="server" 
                                            ControlToValidate="ddl_Cuantos_Desplazamientos" 
                                            ErrorMessage="Falta Dato de Cuantos Desplazamientos" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:Label ID="lblSubTablasId_Ha_Declarado_Antes" runat="server" Width="96%">Usted ha declarado en otra ocasión por otro desplazamiento?</asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:DropDownList ID="ddl_Ha_Declarado_Antes" runat="server" 
                                            AutoPostBack="True" Font-Size="X-Small" Width="96%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator16" 
                                            runat="server" ControlToValidate="ddl_Ha_Declarado_Antes" 
                                            ErrorMessage="Falta Ha Declarado Antes" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%">
                                        <asp:Label ID="Label7" runat="server" Width="96%">Fecha de cuando declaro</asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                        <telerik:RadDatePicker ID="rdpfechaOtroDesplazamiento" runat="server" 
                                            Culture="es-CO" MinDate="" Skin="Telerik" TabIndex="1" 
                                            ToolTip="Seleccione Fecha ..." Width="95%" ResolvedRenderMode="Classic">
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
                                        <asp:RequiredFieldValidator ID="rfv_Fecha_Otra_Declaracion" runat="server" 
                                            ControlToValidate="rdpfechaOtroDesplazamiento" Enabled="False" 
                                            ErrorMessage="Falta Fecha de Otra Declaración" ForeColor="Red" 
                                            ValidationGroup="GA">*</asp:RequiredFieldValidator>
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:Label ID="Label6" runat="server" Width="96%">Lugar </asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:TextBox ID="txt_Lugar_Otro_Desplazamiento" runat="server" Enabled="False" 
                                            Font-Size="X-Small" Width="92%"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfv_Lugar_Otro_Desplazamiento" runat="server" 
                                            ControlToValidate="txt_Lugar_Otro_Desplazamiento" Enabled="False" 
                                            ErrorMessage="Falta Lugar de Otro Desplazamiento" ForeColor="Red" 
                                            ValidationGroup="GA">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%">
                                        <asp:Label ID="lblSubTablasId_Ha_Regresado" runat="server" Width="96%">Desde su desplazamiento, usted ha regresado a su vereda o municipio?</asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:DropDownList ID="ddl_Ha_Regresado" runat="server" Font-Size="X-Small" 
                                            Width="96%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator17" 
                                            runat="server" ControlToValidate="ddl_Ha_Regresado" 
                                            ErrorMessage="Falta Ha Regresado?" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%">
                                        <asp:Label ID="Label29" runat="server" Width="96%">Cuales fueron las causas del desplazamiento?</asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 25%; text-align: left;">
                                        <asp:ListBox ID="Lst_Causas" runat="server" AutoPostBack="True" 
                                            BackColor="Gainsboro" Font-Size="X-Small" Width="96%"></asp:ListBox>
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:Label ID="Label82" runat="server" Width="96%">Seleccione o Retire con clic en cada casilla las causas de desplazamiento  </asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 25%; text-align: left;">
                                        <asp:ListBox ID="Lst_causasDec" runat="server" AutoPostBack="True" 
                                            BackColor="ControlLight" Font-Size="X-Small" Width="96%"></asp:ListBox>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%;">
                                        <asp:Label ID="lblFecha_Declaracion" runat="server" Width="96%">Fecha Declaración</asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 25%;">
                                        <telerik:RadDatePicker ID="rdpfechaDeclaracion" runat="server" 
                                            Culture="Spanish (Colombia)" MinDate="" Skin="Telerik" TabIndex="1" 
                                            ToolTip="Seleccione Fecha ..." Width="95%">
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
                                        <asp:RequiredFieldValidator ID="rfv_FechaDeclaracion" runat="server" 
                                            ControlToValidate="rdpfechaDeclaracion" 
                                            ErrorMessage="Falta Fecha de Declaración" ForeColor="Red" ValidationGroup="GA">*</asp:RequiredFieldValidator>
                                    </td>
                                    <td class="ControlCell" style="width: 25%;">
                                        <asp:Label ID="lblSubTablasId_Fuente" runat="server" Width="96%">Lugar de declaración (Fuente)</asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 25%;">
                                        <asp:DropDownList ID="ddl_Fuente" runat="server" Font-Size="X-Small" 
                                            Width="96%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                                            ControlToValidate="ddl_Fuente" ErrorMessage="Falta Fuente de Declaración" 
                                            ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%">
                                        <asp:Label ID="Label8" runat="server" Width="96%">Al llegar. Cuanto tiempo demoro en declarar?</asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:DropDownList ID="ddl_Tiempo_Demoro" runat="server" AutoPostBack="True" 
                                            Font-Size="X-Small" Width="96%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_Tiempo_En_Declarar" runat="server" 
                                            ControlToValidate="ddl_Tiempo_Demoro" 
                                            ErrorMessage="Falta Dato de Tiempo de Demora en Declarar" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:Label ID="Label83" runat="server" Width="96%">Por que tardó tanto en declarar</asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:DropDownList ID="ddl_Motivo_Demora" runat="server" Enabled="False" 
                                            Font-Size="X-Small" Width="96%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_PorqueTardo" runat="server" 
                                            ControlToValidate="ddl_Motivo_Demora" 
                                            ErrorMessage="Falta ingresar el motivo de la demora" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" colspan="4" style="width: 25%; background-color: orange;">
                                        <asp:Label ID="Label105" runat="server" Width="4%">.</asp:Label>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%">
                                        <asp:Label ID="Label104" runat="server" Width="96%">Usted es de este municipio?</asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:DropDownList ID="ddl_EsdelMunicipio" runat="server" 
                                            Font-Size="X-Small" Width="96%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_EsDelMunicipio" runat="server" 
                                            ControlToValidate="ddl_EsdelMunicipio" 
                                            ErrorMessage="Falta Dato de si es del municipio" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                        &nbsp;</td>
                                    <td class="ControlCell" style="width: 25%">
                                        &nbsp;</td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%;">
                                        <asp:Label ID="Label40" runat="server" Width="96%">Antes de desplazarse era beneficiario de Familias en Accion?</asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 25%;">
                                        <asp:DropDownList ID="ddl_Familias_Accion" runat="server" Font-Size="X-Small" 
                                            Width="96%" AutoPostBack="True">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_Familias_Accion" runat="server" 
                                            ControlToValidate="ddl_Familias_Accion" 
                                            ErrorMessage="Falta Si es de Familias en Acción" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td class="ControlCell" style="width: 25%;">
                                        <asp:Label ID="Label482" runat="server" Width="96%">Municipio</asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 25%; text-align: left;">
                                        <asp:DropDownList ID="ddl_departamento_faccion" runat="server" 
                                            AutoPostBack="True" Enabled="False" Font-Size="X-Small" Width="90%">
                                        </asp:DropDownList>
                                        <asp:DropDownList ID="ddl_municipio_faccion" runat="server" Enabled="False" 
                                            Font-Size="X-Small" Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_Municipio_FA" runat="server" 
                                            ControlToValidate="ddl_municipio_faccion" Enabled="False" 
                                            ErrorMessage="Falta dato de Municipio en Familias en Accion" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" colspan="4" style="width: 25%; background-color: orange;">
                                        <asp:Label ID="Label20" runat="server" Font-Bold="True" ForeColor="Navy">Atención Psicosocial</asp:Label>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%">
                                        <asp:Label ID="Label14" runat="server" Width="96%">Indique los daños que ha sufrido su familia por causa del desplazamiento</asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 25%; text-align: left;">
                                        <asp:ListBox ID="lst_Danos" runat="server" AutoPostBack="True" 
                                            BackColor="Gainsboro" Font-Size="X-Small" Width="96%"></asp:ListBox>
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:Label ID="Label17" runat="server" Width="96%">Seleccione o Retire con clic en cada casilla los daños de la familia del declarante</asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 25%; text-align: left;">
                                        <asp:ListBox ID="Lst_danosDec" runat="server" AutoPostBack="True" 
                                            BackColor="ControlLight" Font-Size="X-Small" Width="96%"></asp:ListBox>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%;">
                                        <asp:Label ID="lblSubTablasId_Llegada_Insultos" runat="server" Width="96%">En el marco del conflicto armado, considera que usted o algún miembro de su familia ha sido víctima de violencia sexual?</asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 25%;">
                                        <asp:DropDownList ID="ddl_Llegada_vbg" runat="server" 
                                            Font-Size="X-Small" Width="96%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_LlegadaVBG" runat="server" 
                                            ControlToValidate="ddl_Llegada_vbg" ErrorMessage="Falta Dato de llegada VBG" 
                                            ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td class="ControlCell" style="width: 25%;">
                                        &nbsp;</td>
                                    <td class="ControlCell" style="width: 25%; text-align: left;">
                                        &nbsp;</td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" colspan="4" style="width: 25%;">
                                        <asp:DataGrid ID="Dg_Emociones" runat="server" AutoGenerateColumns="False" 
                                            BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" 
                                            CellPadding="2" ForeColor="Black" GridLines="None" width="98%">
                                            <FooterStyle BackColor="Tan" Cssclass="DataGridFooterStyle" />
                                            <EditItemStyle Cssclass="DataGridEditItemStyle" />
                                            <SelectedItemStyle BackColor="DarkSlateBlue" 
                                                Cssclass="DataGridSelectedItemStyle" ForeColor="GhostWhite" />
                                            <PagerStyle BackColor="PaleGoldenrod" CssClass="PagerStyle" 
                                                ForeColor="DarkSlateBlue" HorizontalAlign="Center" Mode="NumericPages" />
                                            <AlternatingItemStyle BackColor="PaleGoldenrod" 
                                                cssclass="DataGridAlternatingItemStyle" />
                                            <ItemStyle Cssclass="DataGridItemStyle" />
                                            <Columns>
                                                <asp:TemplateColumn HeaderText="No.">
                                                    <ItemTemplate>
                                                        <%# ctype(CType(Container.Parent.Parent,DataGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>
                                                        <asp:Label ID="lblid" runat="server" Text="<%# Container.DataItem.ID %>" Visible="false" />
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>
                                                <asp:TemplateColumn HeaderText="Descripción" SortExpression="Descripcion">
                                                    <ItemTemplate>
                                                        <%#Container.DataItem.Descripcion%>
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>
                                                <asp:TemplateColumn HeaderText="En el último mes ha sentido usted?">
                                                    <ItemTemplate>
                                                        <asp:DropDownList ID="ddl_emociones_usted" runat="server" Font-Size="X-Small">
                                                            <asp:ListItem Text="0 - No Responde." Value="0" />
                                                            <asp:ListItem Text="1 - Nunca. " Value="1" />
                                                            <asp:ListItem Text="2 - Muy Pocas Veces." Value="2" />
                                                            <asp:ListItem Text="3 - Algunas Veces." Value="3" />
                                                            <asp:ListItem Text="4 - Casi Siempre." Value="4" />
                                                            <asp:ListItem Text="5 - Siempre." Value="5" />
                                                        </asp:DropDownList>
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>
                                                <asp:TemplateColumn HeaderText="Cuales se le presenta a su familia ?">
                                                    <ItemTemplate>
                                                        <asp:DropDownList ID="ddl_emociones_familia" runat="server" Font-Size="X-Small">
                                                            <asp:ListItem Text="0 - No Responde." Value="0" />
                                                            <asp:ListItem Text="1 - Nunca. " Value="1" />
                                                            <asp:ListItem Text="2 - Muy Pocas Veces." Value="2" />
                                                            <asp:ListItem Text="3 - Algunas Veces." Value="3" />
                                                            <asp:ListItem Text="4 - Casi Siempre." Value="4" />
                                                            <asp:ListItem Text="5 - Siempre." Value="5" />
                                                        </asp:DropDownList>
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>
                                            </Columns>
                                            <HeaderStyle BackColor="Tan" cssclass="DataGridHeaderStyle" Font-Bold="True" />
                                        </asp:DataGrid>
                                    </td>
                                </tr>

                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%;">
                                        <asp:Label ID="Label119" runat="server" Width="96%">¿Usted o alguien de su familia tiene algún tipo de adicción?</asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 25%;">
                                        <asp:DropDownList ID="ddl_Tipo_Adiccion" runat="server" AutoPostBack="True" 
                                            Font-Size="X-Small" Width="96%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_Tipo_Adiccion" runat="server" 
                                            ControlToValidate="ddl_Tipo_Adiccion" 
                                            ErrorMessage="Falta Si tiene algún tipo de adicción" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td class="ControlCell" style="width: 25%;">
                                        <asp:CheckBox ID="chk_alcohol" runat="server" Enabled="False" 
                                            Text="Consumo de Alcohol" />
                                    </td>
                                    <td class="ControlCell" style="width: 25%; text-align: left;">
                                        <asp:CheckBox ID="chk_droga" runat="server" Enabled="False" 
                                            Text="Consumo de Sustancias Psicoactivas" />
                                    </td>
                                </tr>

                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%;">
                                        <asp:Label ID="lblSubTablasId_Aplico_Reparaciones" runat="server" Width="96%">Usted o alguien de sus miembros de su familia solicito atención psicologica?</asp:Label>
                                        <br />
                                        <br />
                                    </td>
                                    <td class="ControlCell" style="width: 25%;">
                                        <asp:DropDownList ID="ddl_Solicito_Atencion_Psicologica" runat="server" 
                                            AutoPostBack="True" Font-Size="X-Small" Width="96%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_Solicito_Atencion_psicologica" 
                                            runat="server" ControlToValidate="ddl_Solicito_Atencion_Psicologica" 
                                            ErrorMessage="Falta si solicito atención psicologica" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td class="ControlCell" colspan="2" rowspan="2" style="width: 25%;" 
                                        valign="top">
                                        <asp:DataGrid ID="Dg_Psicosocial" runat="server" AllowSorting="True" 
                                            AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" 
                                            BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" 
                                            width="96%">
                                            <FooterStyle BackColor="Tan" Cssclass="DataGridFooterStyle" />
                                            <EditItemStyle Cssclass="DataGridEditItemStyle" />
                                            <SelectedItemStyle BackColor="DarkSlateBlue" 
                                                Cssclass="DataGridSelectedItemStyle" ForeColor="GhostWhite" />
                                            <PagerStyle BackColor="PaleGoldenrod" CssClass="PagerStyle" 
                                                ForeColor="DarkSlateBlue" HorizontalAlign="Center" Mode="NumericPages" />
                                            <AlternatingItemStyle BackColor="PaleGoldenrod" 
                                                cssclass="DataGridAlternatingItemStyle" />
                                            <ItemStyle Cssclass="DataGridItemStyle" />
                                            <Columns>
                                                <asp:TemplateColumn HeaderText="No.">
                                                    <ItemTemplate>
                                                        <%# ctype(CType(Container.Parent.Parent,DataGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>
                                                        <asp:Label ID="lblidPsi" runat="server" Text="<%# Container.DataItem.ID %>"  Visible="false" />
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>
                                                <asp:TemplateColumn HeaderText="Tipo" SortExpression="Tipo">
                                                    <ItemTemplate>
                                                        <%#Container.DataItem.Tipo%>
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>
                                                <asp:TemplateColumn HeaderText="Nombre Completo" 
                                                    SortExpression="NombreCompleto">
                                                    <ItemTemplate>
                                                        <%#Container.DataItem.NombreCompleto%>
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>
                                                <asp:TemplateColumn HeaderText="SAP" SortExpression="SAP">
                                                    <ItemTemplate>
                                                        <asp:CheckBox ID="chk_sap" runat="server" Checked="<%#Container.DataItem.SAP%>" 
                                                            Enabled="False" />
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>
                                                <asp:TemplateColumn HeaderText="RAP" SortExpression="RAP">
                                                    <ItemTemplate>
                                                        <asp:CheckBox ID="chk_rap" runat="server" Checked="<%#Container.DataItem.RAP%>" 
                                                            Enabled="False" />
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>
                                                <asp:TemplateColumn HeaderText="Quién ?" 
                                                    SortExpression="Quien_Atencion_Psicologica">
                                                    <ItemTemplate>
                                                        <asp:TextBox ID="txt_quien" runat="server" Enabled="False" Font-Size="X-Small" 
                                                            Text="<%#Container.DataItem.Quien_Atencion_Psicologica%>" />
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>
 
                                            </Columns>
                                            <HeaderStyle BackColor="Tan" cssclass="DataGridHeaderStyle" Font-Bold="True" />
                                        </asp:DataGrid>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%;">
                                        &nbsp;</td>
                                    <td class="ControlCell" style="width: 25%;">
                                        &nbsp;</td>
                                </tr>

                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%">
                                        <asp:Label ID="Label23" runat="server" Width="96%">¿De lo que viene sintiendo en el último mes, usted ha buscado ayuda para hablar? </asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:DropDownList ID="ddl_emociones" runat="server" AutoPostBack="True" 
                                            Font-Size="X-Small" Width="90%" style="text-align: left">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_emociones" runat="server" 
                                            ControlToValidate="ddl_emociones" ErrorMessage="Falta Dato de emociones" 
                                            ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                        &nbsp;</td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%" valign="middle">
                                        <asp:Label ID="Label89" runat="server" Width="96%">De Quien?</asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:ListBox ID="Lst_PersonasAyuda" runat="server" AutoPostBack="True" 
                                            BackColor="Gainsboro" Enabled="False" Font-Size="X-Small" Width="96%">
                                        </asp:ListBox>
                                    </td>
                                    <td class="ControlCell" style="width: 25%" valign="middle">
                                        <asp:Label ID="Label102" runat="server" Width="100%">Seleccione o Retire con clic en cada casilla quien le ayudo con las emociones</asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:ListBox ID="Lst_PersonasAyuda_Declarante" runat="server" 
                                            AutoPostBack="True" BackColor="ControlLight" Enabled="False" 
                                            Font-Size="X-Small" Width="96%"></asp:ListBox>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%;" valign="middle">
                                        <asp:Label ID="Label103" runat="server" Width="96%">En que lo apoyo ?</asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 25%;">
                                        <asp:ListBox ID="Lst_ApoyoPersonas" runat="server" AutoPostBack="True" 
                                            BackColor="Gainsboro" Enabled="False" Font-Size="X-Small" Width="96%">
                                        </asp:ListBox>
                                    </td>
                                    <td class="ControlCell" style="width: 25%;" valign="middle">
                                        <asp:Label ID="Label107" runat="server" Width="100%">Seleccione o Retire con clic en cada casilla el tipo de apoyo que recibio</asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 25%;">
                                        <asp:ListBox ID="Lst_ApoyoPersonas_Declarante" runat="server" 
                                            AutoPostBack="True" BackColor="ControlLight" Enabled="False" 
                                            Font-Size="X-Small" Width="96%"></asp:ListBox>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" colspan="4" style="width: 100%; background-color: orange">
                                        <asp:Label ID="Label101" runat="server" Width="36%">.</asp:Label>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td align="center" class="LabelCell" 
                                        style="width: 25%; vertical-align: middle; text-align: center;">
                                        <asp:Label ID="Label97" runat="server">Observaciones Generales</asp:Label>
                                    </td>
                                    <td class="ControlCell" colspan="3" style="width: 75%">
                                        <asp:TextBox ID="txt_Observaciones" runat="server" BackColor="ButtonFace" 
                                            Font-Size="X-Small" MaxLength="4000" Rows="5" TextMode="MultiLine" Width="98%"></asp:TextBox>
                                    </td>
                                </tr>

                            </table>
                        </telerik:RadPageView>
                        <telerik:RadPageView ID="RadPageView3" runat="server">
                            <table ID="tbl_paari" border="0" cellpadding="2" cellspacing="0" 
                                width="1000" style="border-bottom-width: thin">
                                <tr valign="top">
                                    <td colspan="6" style="background-color: orange; width: 100%;">
                                        <asp:Label ID="Label485" runat="server" ForeColor="Navy" Width="100%" 
                                            style="font-weight: 700">Medias de Asistencia y Reparación - Medida Alimentación</asp:Label>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td colspan="6" 
                                        style="background-color: #CCCCCC; width: 100%; text-align: left;">
                                        <asp:Label ID="Label525" runat="server" ForeColor="Navy" 
                                            style="font-weight: 700; color: #CC3300; text-align: center;" Width="100%">Iniciar las preguntas a continuación con el siguiente texto &quot;En los últimos siete días , contando el día de ayer, cuántos días este hogar consumio ...?</asp:Label>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td style="width: 15%" valign="top">
                                        <asp:Label ID="Label486" runat="server" Width="100%">Cereales ?</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;" valign="top">
                                        <asp:DropDownList ID="ddl_cereales" runat="server" Font-Size="X-Small" 
                                            Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_cereales" runat="server" 
                                            ControlToValidate="ddl_cereales" 
                                            ErrorMessage="Falta dato de cereales" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="width: 15%; background-color: #E1E1E1;" valign="top">
                                        <asp:Label ID="Label487" runat="server" Width="100%" style="color: #004080">(Arroz, Harina de Trigo, Avena)</asp:Label>
                                    </td>
                                    <td style="width: 20%; " valign="top" class="style1">
                                        <asp:Label ID="Label491" runat="server" Height="16px" Width="100%">Raíces, Tubérculos y Plátanos?</asp:Label>
                                    </td>
                                    <td style="width: 15%" valign="top">
                                        <asp:DropDownList ID="ddl_raices" runat="server" Font-Size="X-Small" 
                                            Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_raices" runat="server" 
                                            ControlToValidate="ddl_raices" ErrorMessage="Falta dato de raices" 
                                            ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="width: 20%; background-color: #E1E1E1;" valign="top">
                                        <asp:Label ID="Label488" runat="server" style="color: #004080" Width="100%">(yuca, Ñame, Plátano, Papa, Arracacha, etc.)</asp:Label>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td style="width: 15%" valign="top">
                                        <asp:Label ID="Label489" runat="server" Width="100%">Verduras y Hortalizas ?</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;" valign="top">
                                        <asp:DropDownList ID="ddl_verduras" runat="server" Font-Size="X-Small" 
                                            Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_verduras" runat="server" 
                                            ControlToValidate="ddl_verduras" ErrorMessage="Falta dato de verduras" 
                                            ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="width: 15%; background-color: #E1E1E1;" valign="top">
                                        <asp:Label ID="Label490" runat="server" Width="100%" style="color: #004080">(Tomate, Cebolla, Habichuela, Arveja verde, Zanahoria)</asp:Label>
                                    </td>
                                    <td style="width: 20%; " valign="top" class="style1">
                                        <asp:Label ID="Label494" runat="server" Width="100%">Frutas ?</asp:Label>
                                    </td>
                                    <td style="width: 15%" valign="top">
                                        <asp:DropDownList ID="ddl_frutas" runat="server" Font-Size="X-Small" 
                                            Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_frutas" runat="server" 
                                            ControlToValidate="ddl_frutas" ErrorMessage="Falta Dato de frutas" 
                                            ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="width: 20%; background-color: #E1E1E1;" valign="top">
                                        <asp:Label ID="Label493" runat="server" style="color: #004080" Width="100%">(Guayaba, Mango, Piña, Papaya, etc.)</asp:Label>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td style="width: 15%;">
                                        <asp:Label ID="lblSubTablasId_Condicion_Especial0" runat="server" Width="100%">Carnes ?</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;">
                                        <asp:DropDownList ID="ddl_carnes" runat="server" 
                                            Font-Size="X-Small" Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_carnes" 
                                            runat="server" ControlToValidate="ddl_carnes" 
                                            ErrorMessage="Falta Dato de Carnes" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="background-color: #E1E1E1;">
                                        <asp:Label ID="Label498" runat="server" style="color: #004080" Width="100%">(Pollo, Carne, Pescado)</asp:Label>
                                    </td>
                                    <td style="width: 20%; " class="style1">
                                        <asp:Label ID="Label499" runat="server" Width="100%">Huevos ?</asp:Label>
                                    </td>
                                    <td style="width: 15%;">
                                        <asp:DropDownList ID="ddl_huevos" runat="server" 
                                            Font-Size="X-Small" Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_huevos" runat="server" 
                                            ControlToValidate="ddl_huevos" ErrorMessage="Falta dato de Huevos" 
                                            ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="background-color: #E1E1E1;">
                                        <asp:Label ID="Label496" runat="server" 
                                            style="text-align: center; color: #004080" Width="100%">(Huevos de Gallina)</asp:Label>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td style="width: 15%">
                                        <asp:Label ID="Label497" runat="server" Width="100%">Leguminosas Secas?</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;">
                                        <asp:DropDownList ID="ddl_leguminosas" runat="server" Font-Size="X-Small" 
                                            Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_leguminosas" runat="server" 
                                            ControlToValidate="ddl_leguminosas" 
                                            ErrorMessage="Falta Dato de Leguminosas" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="background-color: #E1E1E1;">
                                        <asp:Label ID="Label502" runat="server" style="color: #004080" Width="100%">(Frijol, Lenteja, Garbanzo, etc)</asp:Label>
                                    </td>
                                    <td class="style1">
                                        <asp:Label ID="Label529" runat="server" Width="100%">Lácteos ?</asp:Label>
                                    </td>
                                    <td style="width: 15%">
                                        <asp:DropDownList ID="ddl_lacteos" runat="server" Font-Size="X-Small" 
                                            Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_lacteos" runat="server" 
                                            ControlToValidate="ddl_lacteos" ErrorMessage="Falta Dato de Lacteos" 
                                            ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="background-color: #E1E1E1;">
                                        <asp:Label ID="Label504" runat="server" style="color: #004080" Width="100%">(Leche, Queso, Kumis, Yogurth,etc)</asp:Label>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td style="width: 15%;">
                                        <asp:Label ID="Label501" runat="server" Width="150px">Grasas ?</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;">
                                        <asp:DropDownList ID="ddl_grasas" runat="server" 
                                            Font-Size="X-Small" Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_grasas" runat="server" 
                                            ControlToValidate="ddl_grasas" 
                                            ErrorMessage="Falta Dato de Grasas" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="background-color: #E1E1E1;">
                                        <asp:Label ID="Label533" runat="server" style="color: #004080" Width="100%">(Aceites, Mantequilla, Margarina, Mayonesa ,etc)</asp:Label>
                                    </td>
                                    <td style="width: 20%; " class="style1">
                                        <asp:Label ID="Label530" runat="server" style="text-align: left" Width="100%">Azucares ?</asp:Label>
                                    </td>
                                    <td style="width: 15%;">
                                        <asp:DropDownList ID="ddl_Azucares" runat="server" Font-Size="X-Small" 
                                            Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_azucares" runat="server" 
                                            ControlToValidate="ddl_Azucares" ErrorMessage="Falta Dato de Azucares" 
                                            ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="background-color: #E1E1E1;">
                                        <asp:Label ID="Label507" runat="server" style="color: #004080" Width="100%">(Azúcar, Panela, Bocadillo)</asp:Label>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td style="width: 15%;">
                                        <asp:Label ID="lblSubTablasId_Regimen_Salud0" runat="server" Width="100%">Harinas ?</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;">
                                        <asp:DropDownList ID="ddl_harinas" runat="server" 
                                            Font-Size="X-Small" Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="Rev_harinas" runat="server" 
                                            ControlToValidate="ddl_harinas" 
                                            ErrorMessage="Falta Dato de Harinas" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="background-color: #E1E1E1;">
                                        <asp:Label ID="Label503" runat="server" Width="100%" style="color: #004080">(Arepas, Pan, Galletas y otros)</asp:Label>
                                    </td>
                                    <td style="width: 20%; " class="style1">
                                        <asp:Label ID="Label531" runat="server" style="text-align: left" Width="100%">Embutidos ?</asp:Label>
                                    </td>
                                    <td style="width: 15%;">
                                        <asp:DropDownList ID="ddl_Enbutidos" runat="server" Font-Size="X-Small" 
                                            Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_embutidos" runat="server" 
                                            ControlToValidate="ddl_Enbutidos" ErrorMessage="Falta Dato de Embutidos" 
                                            ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="background-color: #E1E1E1;">
                                        <asp:Label ID="Label526" runat="server" style="color: #004080" Width="100%">(Jamon, Salchichas, Salchichon.)</asp:Label>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td style="width: 15%;">
                                        <asp:Label ID="Label505" runat="server" Width="100%">Enlatados ?</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;">
                                        <asp:DropDownList ID="ddl_enlatados" runat="server" 
                                            Font-Size="X-Small" Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_enlatados" runat="server" 
                                            ControlToValidate="ddl_enlatados" 
                                            ErrorMessage="Falta dato de enlatados" 
                                            ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" 
                                            ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="background-color: #E1E1E1;">
                                        <asp:Label ID="Label506" runat="server" Width="100%" style="color: #004080">(Sardinas, Atún, etc)</asp:Label>
                                    </td>
                                    <td style="width: 20%; " class="style1">
                                        <asp:Label ID="Label532" runat="server" style="text-align: left" Width="100%">Gaseosas ?</asp:Label>
                                    </td>
                                    <td style="width: 15%;">
                                        <asp:DropDownList ID="ddl_gaseosas" runat="server" Font-Size="X-Small" 
                                            Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_gaseosas" runat="server" 
                                            ControlToValidate="ddl_gaseosas" ErrorMessage="Falta dato de gaseosas o jugos" 
                                            ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="background-color: #E1E1E1;">
                                        <asp:Label ID="Label527" runat="server" style="color: #004080" Width="100%">(Gaseosas, Jugos, Maltas)</asp:Label>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td style="width: 15%;">
                                        <asp:Label ID="Label536" runat="server" Width="100%">Agua ?</asp:Label>
                                    </td>
                                    <td style="width: 20%; text-align: left;">
                                        <asp:DropDownList ID="ddl_agua" runat="server" Font-Size="X-Small" Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_agua" runat="server" 
                                            ControlToValidate="ddl_agua" ErrorMessage="Falta Dato de Agua" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="background-color: #E1E1E1;">
                                        <asp:Label ID="Label534" runat="server" style="color: #004080" Width="100%">(Agua embotellada o en Carro tanque)</asp:Label>
                                    </td>
                                    <td style="width: 20%; " class="style1">
                                        <asp:Label ID="Label535" runat="server" style="text-align: left" Width="100%">Bienestarina ?</asp:Label>
                                    </td>
                                    <td style="width: 15%;">
                                        <asp:DropDownList ID="ddl_bienestarina" runat="server" Font-Size="X-Small" 
                                            Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_bienestarina" runat="server" 
                                            ControlToValidate="ddl_bienestarina" ErrorMessage="Falta dato de bienestarina" 
                                            ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="background-color: #E1E1E1;">
                                        <asp:Label ID="Label528" runat="server" style="color: #004080" Width="100%">(Propiedad del ICBF)</asp:Label>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td colspan="6" style="width: 100%; background-color: orange;">
                                        <asp:Label ID="Label537" runat="server" ForeColor="Navy" 
                                            style="font-weight: 700" Width="100%">Medias de Asistencia y Reparación - Medida Alojamiento</asp:Label>
                                    </td>
                                </tr>

                                <tr valign="top">
                                    <td colspan = "6">
                                        <table ID="tbl_alojamiento" cellpadding="2" style="width: 100%">
                                            <tr valign="top">
                                                <td style="width: 25%">
                                                    <asp:Label ID="Label509" runat="server" Width="100%">En que tipo de vivienda habita el hogar ?</asp:Label>
                                                </td>
                                                <td style="width: 25%" class="style1">
                                                    <asp:DropDownList ID="ddl_tipo_vivienda" runat="server" Font-Size="X-Small" 
                                                        Width="90%" AutoPostBack="True">
                                                    </asp:DropDownList>
                                                    <asp:RegularExpressionValidator ID="rev_tipo_vivienda" runat="server" 
                                                        ControlToValidate="ddl_tipo_vivienda" 
                                                        ErrorMessage="Falta dato de tipo de vivienda" ForeColor="Red" 
                                                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                                </td>
                                                <td style="width: 25%">
                                                    <asp:Label ID="Label510" runat="server" Height="16px" Width="100%">Otro. Cuál ?</asp:Label>
                                                </td>
                                                <td style="width: 25%" class="style1">
                                                    <asp:DropDownList ID="ddl_tipo_vivienda_otro" runat="server" 
                                                        Font-Size="X-Small" Width="90%" Enabled="False">
                                                    </asp:DropDownList>
                                                    <asp:RegularExpressionValidator ID="rev_tipo_vivienda_otro" runat="server" 
                                                        ControlToValidate="ddl_tipo_vivienda_otro" EnableTheming="True" 
                                                        ErrorMessage="Falta dato de otro tipo de vivienda" ForeColor="Red" 
                                                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA" 
                                                        Enabled="False">*</asp:RegularExpressionValidator>
                                                </td>
                                            </tr>
                                            <tr valign="top">
                                                <td style="width: 25%">
                                                    <asp:Label ID="Label511" runat="server" Height="16px" Width="100%">Cuál es el material predominante de los pisos de esta vivienda ?</asp:Label>
                                                </td>
                                                <td style="width: 25%" class="style1">
                                                    <asp:DropDownList ID="ddl_material_pisos" runat="server" Font-Size="X-Small" 
                                                        Width="90%" Enabled="False">
                                                    </asp:DropDownList>
                                                    <asp:RegularExpressionValidator ID="rev_Material_pisos" runat="server" 
                                                        ControlToValidate="ddl_material_pisos" 
                                                        ErrorMessage="Falta dato material de los pisos" ForeColor="Red" 
                                                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA" 
                                                        Enabled="False">*</asp:RegularExpressionValidator>
                                                </td>
                                                <td style="width: 25%">
                                                    <asp:Label ID="Label513" runat="server" Width="100%">Cuál es el material predominante de las paredes exteriores de esta vivienda ?</asp:Label>
                                                </td>
                                                <td style="width: 25%" class="style1">
                                                    <asp:DropDownList ID="ddl_material_paredes" runat="server" Font-Size="X-Small" 
                                                        Width="90%" Enabled="False">
                                                    </asp:DropDownList>
                                                    <asp:RegularExpressionValidator ID="rev_material_paredes" runat="server" 
                                                        ControlToValidate="ddl_material_paredes" 
                                                        ErrorMessage="Falta dato de material paredes" ForeColor="Red" 
                                                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA" 
                                                        Enabled="False">*</asp:RegularExpressionValidator>
                                                </td>
                                            </tr>
                                            <tr valign="top">
                                                <td style="width: 25%">
                                                    <asp:Label ID="Label514" runat="server" Width="100%">La zona donde esta su vivienda ha sido afectada por : ?</asp:Label>
                                                </td>
                                                <td style="width: 25%" class="style1">
                                                    <asp:DropDownList ID="ddl_zona_riesgo" runat="server" Font-Size="X-Small" 
                                                        Width="90%" Enabled="False">
                                                    </asp:DropDownList>
                                                    <asp:RegularExpressionValidator ID="rev_zona_riesgo" runat="server" 
                                                        ControlToValidate="ddl_zona_riesgo" ErrorMessage="Falta dato de zona de riesgo" 
                                                        ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" 
                                                        ValidationGroup="GA" Enabled="False">*</asp:RegularExpressionValidator>
                                                </td>
                                                <td style="width: 25%">
                                                    <asp:Label ID="Label516" runat="server" style="margin-bottom: 0px" Width="100%">Cuantas personas en total duermen por cuarto ?</asp:Label>
                                                </td>
                                                <td style="width: 25%" class="style1">
                                                    <asp:DropDownList ID="ddl_personas_cuarto" runat="server" Font-Size="X-Small" 
                                                        Width="90%" Enabled="False">
                                                    </asp:DropDownList>
                                                    <asp:RegularExpressionValidator ID="rev_personas_cuarto" runat="server" 
                                                        ControlToValidate="ddl_personas_cuarto" 
                                                        ErrorMessage="Falta dato de personas por cuarto" ForeColor="Red" 
                                                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA" 
                                                        Enabled="False">*</asp:RegularExpressionValidator>
                                                </td>
                                            </tr>
                                            <tr valign="top">
                                                <td style="width: 25%">
                                                    <asp:Label ID="Label518" runat="server" Width="100%">El hogar cuenta con el servicio de Acueducto ?</asp:Label>
                                                </td>
                                                <td style="width: 25%" class="style1">
                                                    <asp:DropDownList ID="ddl_acueducto" runat="server" Font-Size="X-Small" 
                                                        Width="90%" AutoPostBack="True">
                                                    </asp:DropDownList>
                                                    <asp:RegularExpressionValidator ID="rev_acueducto" runat="server" 
                                                        ControlToValidate="ddl_acueducto" ErrorMessage="Falta dato de acueducto" 
                                                        ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                                </td>
                                                <td style="width: 25%">
                                                    <asp:Label ID="Label517" runat="server" Width="100%">De donde obtiene el agua para el consumo ?</asp:Label>
                                                </td>
                                                <td style="width: 25%" class="style1">
                                                    <asp:DropDownList ID="ddl_obtiene_agua" runat="server" Font-Size="X-Small" 
                                                        Width="90%" Enabled="False">
                                                    </asp:DropDownList>
                                                    <asp:RegularExpressionValidator ID="rev_obtiene_agua" runat="server" 
                                                        ControlToValidate="ddl_obtiene_agua" 
                                                        ErrorMessage="Falta dato de obtención del agua" ForeColor="Red" 
                                                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA" 
                                                        Enabled="False">*</asp:RegularExpressionValidator>
                                                </td>
                                            </tr>
                                            <tr valign="top">
                                                <td style="width: 25%">
                                                    <asp:Label ID="Label519" runat="server" Width="100%">El hogar cuenta con el servicio de Alcantarillado ?</asp:Label>
                                                </td>
                                                <td style="width: 25%" class="style1">
                                                    <asp:DropDownList ID="ddl_alcantarillado" runat="server" Font-Size="X-Small" 
                                                        Width="90%" AutoPostBack="True" />
                                                    <asp:RegularExpressionValidator ID="rev_alcantarillado" runat="server" 
                                                        ControlToValidate="ddl_alcantarillado" 
                                                        ErrorMessage="Falta dato de alcantarillado" ForeColor="Red" 
                                                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA">*</asp:RegularExpressionValidator>
                                                </td>
                                                <td style="width: 25%">
                                                    <asp:Label ID="Label515" runat="server" Width="100%">Con que tipo de servicio sanitario cuenta el hogar?</asp:Label>
                                                </td>
                                                <td style="width: 25%" class="style1">
                                                    <asp:DropDownList ID="ddl_servicio_sanitario" runat="server" 
                                                        Font-Size="X-Small" Width="90%" Enabled="False">
                                                    </asp:DropDownList>
                                                    <asp:RegularExpressionValidator ID="rev_servicio_sanitario" runat="server" 
                                                        ControlToValidate="ddl_servicio_sanitario" 
                                                        ErrorMessage="Falta dato de servicio sanitario" ForeColor="Red" 
                                                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="GA" 
                                                        Enabled="False">*</asp:RegularExpressionValidator>
                                                </td>
                                            </tr>

                                        </table>


                                    </td>
                                </tr> 
                                <tr valign="top">
                                    <td colspan="6" style="width: 100%; background-color: orange;">
                                        <asp:Label ID="Label520" runat="server" Font-Bold="True" ForeColor="Navy">PUNTAJE ALOJAMIENTO Y ALIMENTACION</asp:Label>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td style="width: 15%;">
                                        <asp:Label ID="Label521" runat="server" Width="90%">Generar Calificación PAARI </asp:Label>
                                    </td>
                                    <td style="width: 20%;">
                                        <asp:Button ID="btn_paari" runat="server" CssClass="Boton" 
                                            Text="Procesar Calificación" />
                                    </td>
                                    <td style="width: 15%;">
                                        <asp:Label ID="Label522" runat="server" Width="90%" 
                                            style="font-weight: 700; color: #004080">Alimentación -------&gt;</asp:Label>
                                    </td>
                                    <td style="width: 20%;">
                                        <asp:Label ID="lbl_Alimentacion" runat="server" 
                                            style="font-weight: 700; color: #800000; font-size: medium">Sin Dato !!!</asp:Label>
                                    </td>
                                    <td style="width: 15%; background-color: white;">
                                        <asp:Label ID="Label523" runat="server" Width="90%" 
                                            style="font-weight: 700; color: #004080">Alojamiento ------&gt;</asp:Label>
                                    </td>
                                    <td style="width: 20%;">
                                        <asp:Label ID="Lbl_Alojamiento" runat="server" 
                                            style="font-size: medium; font-weight: 700; color: #800000">Sin Dato !!!</asp:Label>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td align="center" colspan="6" style="background-color: papayawhip;">
                                        <asp:Label ID="lblid1" runat="server" style="color: #FF3300">----------------------------------------------------------------------------------</asp:Label>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td colspan="6">
                                        <asp:Label ID="lbl_dato_alimentacion" runat="server" Height="16px"></asp:Label>
                                        <asp:Label ID="lbl_dato_alojamiento" runat="server" Height="16px"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </telerik:RadPageView>
                        
                    </telerik:RadMultiPage>

                    <table ID="Table2" border="0" cellpadding="2" cellspacing="0" width="1000" style="border-bottom-width: thin">
                        <tr valign="top">
                            <td align="center" class="LabelCell" colspan="4" 
                                style="background-color: activecaption; width: 100%; height: 16px;">
                                <asp:Label ID="Label30" runat="server" Font-Bold="True" ForeColor="Navy">FIN  DE  LA  ENCUESTA</asp:Label>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td align="center" class="LabelCell" colspan="4" 
                                style="width: 100%; background-color: papayawhip">
                                <asp:Button ID="btnGuardar" runat="server" cssclass="Boton" Text="Guardar" 
                                    Width="100px" />
                                <asp:Button ID="btnCerrar" runat="server" cssclass="Boton" Text="Cerrar" 
                                    Width="100px" />
                            </td>
                        </tr>                    
                    </table>

                </td>
            </tr>
        </table>
       
       
   </asp:Panel>


</asp:Content>

