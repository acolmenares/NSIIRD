<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="EncuestaEspecial.aspx.vb" Inherits="WebForms_EncuestaEspecial" MaintainScrollPositionOnPostback ="true" %>
<%@ Register Src="../Controles/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .ControlCell
        {
            text-align: center;
        }
    </style>
    <link href="../main.css" rel="stylesheet" type="text/css" />
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
<asp:ValidationSummary ID="valSummarybe" runat="server" ValidationGroup="BE" ForeColor="Red" style="text-align: left" />
<asp:ValidationSummary ID="ValidationSummarySE" runat="server" ValidationGroup="SE" ForeColor="Red" style="text-align: left" />
<asp:ValidationSummary ID="ValidationSummaryRS" runat="server" ValidationGroup="RS" ForeColor="Red" style="text-align: left" />
                    
<asp:Panel runat="server" ID="pnl_principal" DefaultButton ="btnGuardar" Width ="100%">        
    <table id="Table1" cellspacing="0" cellpadding="0" border="0" class="ContentTable" style="width: 100%">
        <tr valign="top">
            <td class="LabelMessage">
                <table id="tbldeclarante" border="0" cellpadding="0" cellspacing="0" style="width: 100%">
                    <tr valign="top">
                    <td style="width: 75%; text-align: left;" colspan="3"> 
                        <asp:Label ID="lbl_Titulo" runat="server" 
                            Text="ENCUESTA PARA ENTREGA ESPECIAL DE DESPLAZADOS VULNERABLES" Width="90%" 
                            CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
                        <asp:Label ID="Label12" runat="server" CssClass="TitMensaje" Text="_" Width="90%" Visible="False"/>
                    </td>
                    <td style="width: 25%" align="right">
                        <asp:ImageButton ID="btn_actualizar" runat="server" ImageUrl="~/Images/Reload.jpg" ToolTip="Actualizar la vista actual." TabIndex="5" />
                        <asp:ImageButton ID="btn_nuevo" runat="server" ImageUrl="~/Images/Add.jpg" 
                            ToolTip="Crear Nuevo Registro." TabIndex="6" Visible="False" />
                        <asp:ImageButton ID="btn_cerrar" runat="server" ImageUrl="~/Images/Stop.jpg" ToolTip="Cerrar - Volver a la vista anterior." TabIndex="7" />
                        <asp:ImageButton ID="btn_home" runat="server" ImageUrl="~/Images/Home.jpg" ToolTip="Ir al Inicio." TabIndex="8" />&nbsp;</td>
                    </tr>
                    <tr valign="top">
                        <td colspan="4">
                            <asp:Label ID="lblmensaje" runat="server" Width="26%"></asp:Label>
                        </td>
                    </tr>
                    <tr valign="top">
                        <td style="background-color: darkblue;" colspan="4">
                            <asp:Label ID="Label49" runat="server" ForeColor="Yellow" Font-Bold="True" Font-Italic="False">Información General del Declarante</asp:Label>
                        </td>
                    </tr>
                    <tr valign="top">
                        <td style="width: 15%;">
                            <asp:Label ID="Label98" runat="server" ForeColor="#C00000">NOMBRE COMPLETO</asp:Label>
                        </td>
                        <td style="width: 55%;">
                            <asp:Label ID="lbl_Nombre_Completo" runat="server" Font-Size="Medium" 
                                ForeColor="#C00000" Width="100%">NOMBRE COMPLETO</asp:Label>
                        </td>
                        <td align="center" style="width: 15%;">
                            <asp:Label ID="Label99" runat="server">PROGRAMACION</asp:Label>
                        </td>
                        <td align="center" style="width: 25%;">
                            <asp:Label ID="lbl_Programa" runat="server" Font-Bold="True" 
                                ForeColor="#C00000">REG. PROGRAMA</asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr valign="top">
            <td class="ContentCell">
                <table id="TablaContenido" cellspacing="0" cellpadding="0" border="0" class="ContentTable" width="100%">
                    <tr valign="top">
                        <td>
                            <table id="tblContenido" class="EditControlsTable" cellspacing="0" cellpadding="0" border="0" width="1000" align="center">
                                <tr valign="top">
                                    <td align="center" class="LabelCell" colspan="4" style="background-color: activecaption;">
                                        <asp:Label ID="Label31" runat="server" Font-Bold="True" ForeColor="Navy">INICIO  DE  LA  ENCUESTA DE VULNERABLES</asp:Label></td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="background-color: coral; height: 13px;" colspan="4">
                                        <asp:Label ID="Label5" runat="server" ForeColor="Navy">.</asp:Label></td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%">
                                        <asp:Label id="Label32" runat="server" Width="96%">Fecha de la Encuesta</asp:Label></td>
                                    <td class="ControlCell" style="width: 25%; text-align: left;">
                                        <telerik:RadDatePicker ID="rdpfecha" runat="server" 
                                            Culture="Spanish (Colombia)" MinDate="" Skin="Telerik" TabIndex="1" 
                                            ToolTip="Seleccione Fecha ..." Width="90%">
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
                                        <asp:RequiredFieldValidator ID="rfv_Fecha" runat="server" ControlToValidate="rdpfecha"
                                                ErrorMessage="Falta Fecha de Entrega Especial." ValidationGroup="SE" 
                                            ForeColor="Red">*</asp:RequiredFieldValidator>
                                    </td>
                                    <td class="ControlCell" style="width: 25%"></td>
                                    <td class="ControlCell" style="width: 249px"></td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%">
                                        <asp:Label ID="lblSubTablasId_Reparaciones" runat="server" Width="96%">Usted ha oido hablar de la Mesa de desplazados o de las asociaciones de Desplazados?</asp:Label></td>
                                    <td class="ControlCell" style="width: 25%; text-align: left;">
                                        <asp:dropdownlist id="ddl_haoidoasociaciones" runat="server" 
                                            Font-Size="X-Small" Width="90%" AutoPostBack="True" >
                                    </asp:dropdownlist>
                                        <asp:RegularExpressionValidator ID="rev_oido_asociaciones" runat="server" ControlToValidate="ddl_haoidoasociaciones"
                                                ErrorMessage="Falta si ha oido de asociaciones " 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE" ForeColor="Red" 
                                            EnableClientScript="False">*</asp:RegularExpressionValidator></td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:Label ID="Label33" runat="server" Width="96%">Pertenece a alguna de las Asociaciones de Desplazados?</asp:Label></td>
                                    <td class="ControlCell" style="width: 249px">
                                        <asp:dropdownlist id="ddl_pertenece_asociacion" runat="server" 
                                            Font-Size="X-Small" Width="90%" Enabled="False" AutoPostBack="True" >
                                    </asp:dropdownlist>
                                        <asp:RegularExpressionValidator ID="rev_Pertenece_Asociacion" runat="server" ControlToValidate="ddl_pertenece_asociacion"
                                                Enabled="False" ErrorMessage="Falta si ha pertenecido a alguna asociacion"
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE" ForeColor="Red" 
                                            EnableClientScript="False">*</asp:RegularExpressionValidator></td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%">
                                        <asp:Label ID="Label16" runat="server" Width="96%">Cual Asociación</asp:Label></td>
                                    <td class="ControlCell" colspan="3" style="text-align: left">
                                        <asp:TextBox ID="txt_Asociacion" runat="server" Width="90%" Enabled="False" MaxLength="100" Font-Size="X-Small"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfv_Nombre_Asociacion" runat="server" ControlToValidate="txt_Asociacion"
                                            Enabled="False" ErrorMessage="Falta ingresar Nombre de la Asociación" 
                                            ValidationGroup="SE" ForeColor="Red" EnableClientScript="False">*</asp:RequiredFieldValidator></td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="background-color: coral" colspan="4">
                                        <asp:Label ID="Label9" runat="server" Font-Bold="True" ForeColor="Navy">Trabajo Antes y Después</asp:Label></td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%">
                                        <asp:Label ID="Label18" runat="server" Width="96%">Que fuente de ingresos tiene su familia?</asp:Label></td>
                                    <td class="ControlCell" style="width: 25%; text-align: left;">
                                        <asp:ListBox ID="Lst_FuentesIngreso" runat="server" AutoPostBack="True" BackColor="Gainsboro"
                                            Font-Size="X-Small" Width="96%"></asp:ListBox></td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:Label ID="Label19" runat="server" Width="96%">Seleccione o Retire con clic en cada casilla las fuentes de ingreso del declarante</asp:Label></td>
                                    <td class="ControlCell" style="width: 249px; text-align: left;">
                                        <asp:ListBox ID="Lst_FuentesIngresoDeclarante" runat="server" AutoPostBack="True"
                                            BackColor="ControlLight" Font-Size="X-Small" Width="96%"></asp:ListBox></td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%;">
                                        <asp:Label ID="Label90" runat="server" Width="96%">Indique el promedio de ingresos mensuales de su familia en pesos($)</asp:Label></td>
                                    <td class="ControlCell" style="width: 25%; text-align: left;">
                                        <asp:TextBox ID="Txt_ingresos" runat="server" Font-Size="X-Small" onkeypress="return ValNumero(this, event)"
                                            Style="text-align: right" Width="96%"></asp:TextBox></td>
                                    <td class="ControlCell" style="width: 25%;">
                                        </td>
                                    <td class="ControlCell" style="width: 249px; text-align: left;">
                                        &nbsp;</td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%">
                                        <asp:Label ID="Label22" runat="server" Width="96%">Siente que algún miembro de su familia se ha visto más afectado luego del desplazamiento</asp:Label></td>
                                    <td class="ControlCell" style="width: 25%; text-align: left;">
                                        <asp:DropDownList ID="ddl_Afectado_Desplazamiento" runat="server"
                                            Font-Size="X-Small" Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_Afecto_Desplazamiento" runat="server" ControlToValidate="ddl_Afectado_Desplazamiento"
                                            ErrorMessage="Falta Saber si lo afecto el desplazamiento" ValidationExpression="^[1-9]+[0-9]*$"
                                            ValidationGroup="SE" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:Label ID="Label1" runat="server" Width="96%">Le gustaria Iniciar un proceso de apoyo emocional mutuo frente a lo que ha venido sintiendo despues del desplazamiento?</asp:Label></td>
                                    <td class="ControlCell" style="width: 249px; text-align: left;">
                                        <asp:DropDownList ID="ddl_apoyo_emocional" runat="server" Font-Size="X-Small"
                                            Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_apoyo_emocional" runat="server" ControlToValidate="ddl_apoyo_emocional"
                                            ErrorMessage="Falta el apoyo emocional" ValidationExpression="^[1-9]+[0-9]*$"
                                            ValidationGroup="SE" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" colspan="2">
                                        <asp:DataGrid ID="Dg_Psicosocial" runat="server" AllowSorting="True" AutoGenerateColumns="False"
                                            BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2"
                                            ForeColor="Black" GridLines="None" Width="96%" Visible="False">
                                            <FooterStyle BackColor="Tan" CssClass="DataGridFooterStyle" />
                                            <EditItemStyle CssClass="DataGridEditItemStyle" />
                                            <SelectedItemStyle BackColor="DarkSlateBlue" CssClass="DataGridSelectedItemStyle"
                                                ForeColor="GhostWhite" />
                                            <PagerStyle BackColor="PaleGoldenrod" CssClass="PagerStyle" ForeColor="DarkSlateBlue"
                                                HorizontalAlign="Center" Mode="NumericPages" />
                                            <AlternatingItemStyle BackColor="PaleGoldenrod" CssClass="DataGridAlternatingItemStyle" />
                                            <ItemStyle CssClass="DataGridItemStyle" />
                                            <Columns>
                                                <asp:TemplateColumn HeaderText="No.">
                                                    <ItemTemplate>
                                                        <%# ctype(CType(Container.Parent.Parent,DataGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>
                                                        <asp:Label ID="lblid" runat="server" Text='<%# Container.DataItem.ID %>' Visible="false"></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>
                                                <asp:TemplateColumn HeaderText="Tipo" SortExpression="Tipo">
                                                    <ItemTemplate>
                                                        <%#Container.DataItem.Tipo%>
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>
                                                <asp:TemplateColumn HeaderText="Nombre Completo" SortExpression="NombreCompleto">
                                                    <ItemTemplate>
                                                        <%#Container.DataItem.NombreCompleto%>
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>
                                                <asp:TemplateColumn HeaderText="SAP" SortExpression="SAP"  >
                                                <ItemTemplate >
                                                    <asp:CheckBox runat="server" ID="chk_sap" Checked = '<%#Container.DataItem.SAP%>' Enabled="False" />
                                                </ItemTemplate>
                                                </asp:TemplateColumn>
                                            <asp:TemplateColumn HeaderText="RAP" SortExpression="RAP">
                                                <ItemTemplate>
                                                    <asp:CheckBox runat="server" ID="chk_rap" Checked = '<%#Container.DataItem.RAP%>' Enabled="False"/>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>
                                            <asp:TemplateColumn HeaderText="Qui&#233;n ?" SortExpression="Quien_Atencion_Psicologica">
                                                <ItemTemplate>
                                                    <asp:TextBox runat="server" ID="txt_quien" Text= '<%#Container.DataItem.Quien_Atencion_Psicologica%>' Enabled="False" Font-Size="X-Small"/>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>
                                            <asp:TemplateColumn HeaderText="ADD" SortExpression="ADD">
                                                <ItemTemplate>
                                                    <asp:CheckBox runat="server" ID="chk_add" Checked = '<%#Container.DataItem.ADD%>' Enabled="False" />
                                                </ItemTemplate>
                                            </asp:TemplateColumn>
                                            </Columns>
                                            <HeaderStyle BackColor="Tan" CssClass="DataGridHeaderStyle" Font-Bold="True" />
                                        </asp:DataGrid>
                                    </td>
                                    <td class="ControlCell" colspan="2">
                                        <asp:DataGrid ID="Dg_Emociones" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow"
                                            BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None"
                                            Width="98%">
                                            <FooterStyle BackColor="Tan" CssClass="DataGridFooterStyle" />
                                            <EditItemStyle CssClass="DataGridEditItemStyle" />
                                            <SelectedItemStyle BackColor="DarkSlateBlue" CssClass="DataGridSelectedItemStyle"
                                                ForeColor="GhostWhite" />
                                            <PagerStyle BackColor="PaleGoldenrod" CssClass="PagerStyle" ForeColor="DarkSlateBlue"
                                                HorizontalAlign="Center" Mode="NumericPages" />
                                            <AlternatingItemStyle BackColor="PaleGoldenrod" CssClass="DataGridAlternatingItemStyle" />
                                            <ItemStyle CssClass="DataGridItemStyle" />
                                            <Columns>
                                                <asp:TemplateColumn HeaderText="No.">
                                                    <ItemTemplate>
                                                        <%# ctype(CType(Container.Parent.Parent,DataGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>
                                                        <asp:Label ID="lblid" runat="server" Text='<%# Container.DataItem.ID %>' Visible="false"></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>
                                                <asp:TemplateColumn HeaderText="Descripci&#243;n" SortExpression="Descripcion">
                                                    <ItemTemplate>
                                                        <%#Container.DataItem.Descripcion%>
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>
                                                <asp:TemplateColumn HeaderText="En el &#250;ltimo mes ha sentido usted?">
                                                    <ItemTemplate>
                                                        <asp:DropDownList ID="ddl_emociones_usted" runat="server" Font-Size="X-Small">
                                                        <asp:ListItem Text ="0 - No Responde." Value ="0"/>
                                                        <asp:ListItem Text ="1 - Nunca. " Value ="1"/>
                                                        <asp:ListItem Text ="2 - Muy Pocas Veces." Value ="2"/>
                                                        <asp:ListItem Text ="3 - Algunas Veces." Value ="3"/>
                                                        <asp:ListItem Text ="4 - Casi Siempre." Value ="4"/>
                                                        <asp:ListItem Text ="5 - Siempre." Value ="5"/>
                                                        </asp:DropDownList>
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>
                                                <asp:TemplateColumn HeaderText="Cuales se le presenta a su familia ?">
                                                    <ItemTemplate>
                                                        <asp:DropDownList ID="ddl_emociones_familia" runat="server" Font-Size="X-Small">
                                                        <asp:ListItem Text ="0 - No Responde." Value ="0"/>
                                                        <asp:ListItem Text ="1 - Nunca. " Value ="1"/>
                                                        <asp:ListItem Text ="2 - Muy Pocas Veces." Value ="2"/>
                                                        <asp:ListItem Text ="3 - Algunas Veces." Value ="3"/>
                                                        <asp:ListItem Text ="4 - Casi Siempre." Value ="4"/>
                                                        <asp:ListItem Text ="5 - Siempre." Value ="5"/>
                                                        </asp:DropDownList>
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>
                                            </Columns>
                                            <HeaderStyle BackColor="Tan" CssClass="DataGridHeaderStyle" Font-Bold="True" />
                                        </asp:DataGrid>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%">
                                        <asp:Label ID="Label23" runat="server" Width="96%">¿De lo que viene sintiendo en el último mes, usted ha buscado ayuda para hablar?</asp:Label></td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:DropDownList ID="ddl_emociones" runat="server" AutoPostBack="True" Font-Size="X-Small"
                                            Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_emociones" runat="server"
                                            ControlToValidate="ddl_emociones" ErrorMessage="Falta Dato de emociones" ValidationExpression="^[1-9]+[0-9]*$"
                                            ValidationGroup="SE" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                                    <td class="ControlCell" style="width: 25%">
                                    </td>
                                    <td class="ControlCell" style="width: 249px">
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%">
                                        <asp:Label ID="Label89" runat="server" Width="96%">De Quien?</asp:Label></td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:ListBox ID="Lst_PersonasAyuda" runat="server" AutoPostBack="True" BackColor="Gainsboro"
                                            Enabled="False" Font-Size="X-Small" Width="96%"></asp:ListBox></td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:Label ID="Label102" runat="server" Width="100%">Seleccione o Retire con clic en cada casilla quien le ayudo con las emociones</asp:Label></td>
                                    <td class="ControlCell" style="width: 249px">
                                        <asp:ListBox ID="Lst_PersonasAyuda_Declarante" runat="server" AutoPostBack="True"
                                            BackColor="ControlLight" Enabled="False" Font-Size="X-Small" Width="96%"></asp:ListBox></td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%">
                                        <asp:Label ID="Label103" runat="server" Width="96%">En que lo apoyo ?</asp:Label></td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:ListBox ID="Lst_ApoyoPersonas" runat="server" AutoPostBack="True" BackColor="Gainsboro"
                                            Enabled="False" Font-Size="X-Small" Width="96%"></asp:ListBox></td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:Label ID="Label107" runat="server" Width="100%">Seleccione o Retire con clic en cada casilla el tipo de apoyo que recibio</asp:Label></td>
                                    <td class="ControlCell" style="width: 249px">
                                        <asp:ListBox ID="Lst_ApoyoPersonas_Declarante" runat="server" AutoPostBack="True"
                                            BackColor="ControlLight" Enabled="False" Font-Size="X-Small" Width="96%"></asp:ListBox></td>
                                </tr>
                            </table> 
                            <asp:Panel runat="server" ID= "pnl_regimen_salud" Visible = "false">
                                <table id="tbl_regimen_salud" class="EditControlsTable" cellspacing="0" cellpadding="0" border="0" width="1000" align="center" >
                                    <tr valign="top">
                                        <td class="LabelCell" colspan="4" style="width: 100%; height: 14px; background-color: coral">
                                            <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Navy">Acceso a Regimen de Salud</asp:Label></td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 25%; height: 16px">
                                            <asp:Label ID="Label11" runat="server" ForeColor="#C00000">Información de los Beneficiarios</asp:Label></td>
                                        <td class="ControlCell" colspan="2" style="height: 16px">
                                            <asp:Label ID="lbl_NC2" runat="server" Font-Size="Medium" ForeColor="#C00000" 
                                                Width="100%" Enabled="False"></asp:Label></td>
                                        <td class="ControlCell" align="left">
                                            <asp:Button ID="btn_GrabarRegimen" runat="server" Text="Guardar Regimen" 
                                                cssclass="Boton" Width="100px" ToolTip="BE" Enabled="False"/><asp:Label ID="lblerror1" runat="server" ForeColor="Red"
                                                    Visible="False" Width="45%">Error al Grabar.!!!</asp:Label></td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 25%;">
                                            <asp:Label ID="Label3" runat="server" Width="90%">Regimen de Salud</asp:Label></td>
                                        <td class="ControlCell" style="width: 25%;">
                                            <asp:dropdownlist id="ddl_regimen" runat="server" Width="90%" 
                                                Font-Size="X-Small" Enabled="False" >
                                            </asp:DropDownList>
                                            <asp:RegularExpressionValidator ID="rev_regimen" runat="server" ControlToValidate="ddl_regimen"
                                                ErrorMessage="Falta regimen de salud" 
                                                ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="RS" ForeColor="Red" 
                                                EnableClientScript="False" Enabled="False">*</asp:RegularExpressionValidator></td>
                                        <td class="ControlCell" style="width: 25%;">
                                            <asp:Label ID="Label4" runat="server" Width="90%">EPS</asp:Label></td>
                                        <td class="ControlCell">
                                            <asp:dropdownlist id="ddl_eps" runat="server" Width="90%" Font-Size="X-Small" 
                                                Enabled="False" >
                                            </asp:DropDownList>
                                            <asp:RegularExpressionValidator ID="rev_eps" runat="server" ControlToValidate="ddl_eps"
                                                ErrorMessage="Falta dato de eps" ValidationExpression="^[1-9]+[0-9]*$" 
                                                ValidationGroup="RS" ForeColor="Red" EnableClientScript="False" 
                                                Enabled="False">*</asp:RegularExpressionValidator></td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 25%;">
                                            <asp:Label ID="Label8" runat="server" Width="90%">Municipio donde esta afiliado </asp:Label></td>
                                        <td class="ControlCell" style="width: 25%;">
                                            <asp:TextBox ID="txt_municipio_regimen" runat="server" Font-Size="X-Small"
                                                Width="90%" Enabled="False"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfv_municipio_regimen" runat="server" 
                                                ControlToValidate="txt_municipio_regimen" ErrorMessage="Falta ingresar Nombre de Municipio regimen Salud"
                                                ValidationGroup="RS" ForeColor="Red" EnableClientScript="False" 
                                                Enabled="False">*</asp:RequiredFieldValidator></td>
                                        <td class="ControlCell" style="width: 25%;">
                                            <asp:Label ID="Label10" runat="server" Width="90%">Necesita Traslado</asp:Label></td>
                                        <td class="ControlCell">
                                            <asp:dropdownlist id="ddl_Necesita_Traslado" runat="server" Width="90%" 
                                                Font-Size="X-Small" Enabled="False" >
                                        </asp:DropDownList>
                                            <asp:RegularExpressionValidator ID="rev_Necesita_Traslado" runat="server" ControlToValidate="ddl_Necesita_Traslado"
                                                ErrorMessage="Falta dato de necesitar traslado" ValidationExpression="^[1-9]+[0-9]*$"
                                                ValidationGroup="RS" ForeColor="Red" EnableClientScript="False" 
                                                Enabled="False">*</asp:RegularExpressionValidator></td>
                                    </tr>
                   
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 25%">
                                        </td>
                                        <td class="ControlCell" style="width: 25%">
                                            <asp:Label ID="lblidpersonars" runat="server" Visible="False" Width="7%"></asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 25%">
                                            <asp:Label ID="lblidrs" runat="server" Visible="False" Width="7%"></asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 249px; text-align: left;">
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" colspan="4">
				                            <telerik:RadGrid ID="Rg_Regimen" runat="server" AllowSorting="True" Skin="WebBlue" Width="100%"  
                                                AutoGenerateColumns="False" ShowStatusBar="True" TabIndex="6" PageSize="20" ResolvedRenderMode="Classic">
                                                <MasterTableView  NoDetailRecordsText="No hay informaci&#243;n." 
                                                    NoMasterRecordsText="No hay informaci&#243;n." DataKeyNames="Id" CommandItemDisplay ="Top" ShowFooter="True">
                                                    <Columns>
                                                        <telerik:GridTemplateColumn HeaderText="No." DefaultInsertValue="" UniqueName="TemplateColumn">
                                                            <ItemTemplate>
                                                                <asp:label runat="server" id="lblno" text='<%# ctype(CType(Container.Parent.Parent.Parent,RadGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>'  ToolTip = '<%#Container.DataItem.Id%>'/>
                                                                <asp:Label runat="Server" Id="lblid" Visible ="False" Text ='<%#Container.DataItem.Id%>'/>
                                                            </ItemTemplate>
                                                        </telerik:GridTemplateColumn>                                
                        
                                                        <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" HeaderText="Id" 
                                                            SortExpression="Id" UniqueName="Id"  Display ="False" >
                                                        </telerik:GridBoundColumn>

                                                        <telerik:GridBoundColumn DataField="Tipo" HeaderText="Tipo"
                                                            SortExpression="Tipo" UniqueName="Tipo" >
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>

                                                        <telerik:GridBoundColumn DataField="Identificacion" HeaderText="Identificación"
                                                            SortExpression="Identificacion" UniqueName="Identificacion" >
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>

                                                        <telerik:GridBoundColumn DataField="NombreCompleto" HeaderText="Nombre Completo"
                                                            SortExpression="NombreCompleto" UniqueName="NombreCompleto" >
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>

                                                        <telerik:GridBoundColumn DataField="RegimenEntregaEspecial" HeaderText="Regimen Salud"
                                                            SortExpression="RegimenEntregaEspecial" UniqueName="RegimenEntregaEspecial" >
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>

                                                        <telerik:GridBoundColumn DataField="MunicipioEntregaEspecial" HeaderText="Municipio"
                                                            SortExpression="MunicipioEntregaEspecial" UniqueName="MunicipioEntregaEspecial" >
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>

                                                        <telerik:GridBoundColumn DataField="EPSEntregaEspecial" HeaderText="EPS"
                                                            SortExpression="EPSEntregaEspecial" UniqueName="EPSEntregaEspecial" >
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>
                                                        
                                                        <telerik:GridBoundColumn DataField="NecesitaTrasladoEntregaEspecial" HeaderText="Traslado"
                                                            SortExpression="NecesitaTrasladoEntregaEspecial" UniqueName="NecesitaTrasladoEntregaEspecial" >
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>

				                                    </Columns>
                                                    <CommandItemSettings ExportToCsvText ="Exportar a CSV" ExportToExcelText ="Exportar a Excel" ExportToPdfText ="Exportar a PDF"
                                                        ExportToWordText ="Exportar a Word" RefreshText ="Actualizar" AddNewRecordText =""  AddNewRecordImageUrl ="~/Images/nothing.gif"
                                                        ShowExportToCsvButton="True" ShowExportToExcelButton="True" ShowExportToPdfButton="True" ShowExportToWordButton ="True" 
                                                        ShowAddNewRecordButton="False"/>
                                                    <PagerStyle Mode="NumericPages" FirstPageToolTip="Primera" LastPageToolTip="Ultima" NextPagesToolTip="Pr&#243;ximas" NextPageToolTip="Pr&#243;xima" PagerTextFormat="Cambiar P&#225;gina: {4} &amp;nbsp;P&#225;gina &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;, registros &lt;strong&gt;{2}&lt;/strong&gt; a &lt;strong&gt;{3}&lt;/strong&gt; de &lt;strong&gt;{5}&lt;/strong&gt;." PrevPageToolTip="Anterior"  PrevPagesToolTip="Anteriores" />
                                                </MasterTableView>
                                                <ClientSettings EnablePostBackOnRowClick="True" EnableRowHoverStyle ="True" >
                                                    <Selecting AllowRowSelect ="True"  />
                                                </ClientSettings>
                    
                                                <ExportSettings HideStructureColumns="True" filename ="RegimenSaludEE" ExportOnlyData="True" IgnorePaging="True" OpenInNewWindow="True">
                                                    <Pdf PageWidth="" >
                                                    </Pdf>
                                                </ExportSettings>
                                                <SortingSettings SortToolTip="Clic aqui para ordenar..."  SortedAscToolTip ="Ordenar Ascendente" SortedDescToolTip ="Ordenar Descendente" />
                                                <PagerStyle Mode="NumericPages"    />
                                            </telerik:RadGrid>
                                        </td>
                                    </tr>
                                </table> 
                            </asp:Panel>
                            <asp:Panel runat="server" ID= "pnl_educacion" Visible = "false">
                                <table id="tbl_Educacion" class="EditControlsTable" cellspacing="0" cellpadding="0" border="0" width="1000" align="center">
                                    <tr valign="top">
                                        <td class="LabelCell" colspan="4" style="width: 100%; background-color: coral">
                                            <asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="Navy">Acceso a la Educación</asp:Label></td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 25%; height: 16px;">
                                            <asp:Label ID="Label25" runat="server" ForeColor="#C00000">Información de los Beneficiarios</asp:Label></td>
                                        <td class="ControlCell" style="width: 25%; height: 16px;" colspan="2">
                                            <asp:Label ID="lbl_NC" runat="server" Font-Size="Medium" ForeColor="#C00000" Width="100%"></asp:Label></td>
                                        <td class="ControlCell" style="width: 25%; height: 16px; text-align: left;">
                                            <asp:Button ID="btn_GrabarBeneficiario" runat="server" Text="Guardar Educación" 
                                                cssclass="Boton" Width="111px" ToolTip="Guardar la información de Educación" 
                                                Enabled="False"/><asp:Label
                                                ID="lblerror" runat="server" ForeColor="Red" Visible="False" Width="45%">Error al Grabar.!!!</asp:Label></td>
                                        <td class="ControlCell" style="width: 250px; height: 16px;">
                                            </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 25%;">
                                            <asp:Label ID="Label26" runat="server" Width="90%">Estudia Actualmente</asp:Label></td>
                                        <td class="ControlCell" style="width: 25%;">
                                            <asp:dropdownlist id="ddl_Estudia_Actualmente" runat="server" Width="90%" 
                                                Font-Size="X-Small" AutoPostBack="True" Enabled="False" >
                                        </asp:dropdownlist>
                                            <asp:RegularExpressionValidator ID="rev_EstudiaActualmente" runat="server" ControlToValidate="ddl_Estudia_Actualmente"
                                                ErrorMessage="Falta indicar si estudia actualmente"
                                                ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="BE" ForeColor="Red" 
                                                EnableClientScript="False" Enabled="False">*</asp:RegularExpressionValidator></td>
                                        <td class="ControlCell" style="width: 25%;">
                                            <asp:Label ID="Label27" runat="server" Width="90%">Motivo de No Estudio</asp:Label></td>
                                        <td class="ControlCell" style="width: 249px; text-align: left;">
                                            <asp:dropdownlist id="ddl_MotivoNoestudio" runat="server" Width="90%" 
                                                Font-Size="X-Small" Enabled="False" AutoPostBack="True" >
                                        </asp:dropdownlist>
                                            <asp:RegularExpressionValidator ID="rev_MotivoNoestudia" runat="server" ControlToValidate="ddl_MotivoNoestudio"
                                                Enabled="False" ErrorMessage="Falta indicar el motivo de no estudio."
                                                ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="BE" ForeColor="Red" 
                                                EnableClientScript="False">*</asp:RegularExpressionValidator></td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 25%;">
                                            <asp:Label ID="Label28" runat="server" Width="90%">Trajo Certificado Matrícula ?</asp:Label></td>
                                        <td class="ControlCell" style="width: 25%;"><asp:dropdownlist id="ddl_Certificado" 
                                                runat="server" Width="90%" Font-Size="X-Small" AutoPostBack="True" 
                                                Enabled="False" >
                                        </asp:dropdownlist>
                                            <asp:RegularExpressionValidator ID="rev_certificado" runat="server" ControlToValidate="ddl_Certificado"
                                                Enabled="False" ErrorMessage="Falta indicar si tiene el certificado de estudio."
                                                ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="BE" ForeColor="Red" 
                                                EnableClientScript="False">*</asp:RegularExpressionValidator></td>
                                        <td class="ControlCell" style="width: 25%;">
                                            <asp:Label ID="Label29" runat="server" Width="90%">Nombre de Establecimiento</asp:Label>
                                            </td>
                                        <td class="ControlCell" style="width: 249px; text-align: left;">
                                            <asp:TextBox ID="Txt_Establecimiento" runat="server"  Width="90%" Enabled="False" Font-Size="X-Small"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfv_establecimiento" runat="server" ControlToValidate="Txt_Establecimiento"
                                                Enabled="False" ErrorMessage="Falta ingresar Nombre del Inst. Educativo"
                                                ValidationGroup="BE" ForeColor="Red" EnableClientScript="False">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 25%;">
                                            <asp:Label ID="Label34" runat="server" Width="90%">Grado Escolar</asp:Label></td>
                                        <td class="ControlCell" style="width: 25%;">
                                            <asp:dropdownlist id="ddl_GradoEscolar" runat="server" Width="90%" Font-Size="X-Small" Enabled="False" >
                                            </asp:dropdownlist>
                                            <asp:RegularExpressionValidator ID="rev_gradoescolar" runat="server" ControlToValidate="ddl_GradoEscolar"
                                                Enabled="False" ErrorMessage="Falta indicar el grado escolar al que ingreso."
                                                ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="BE" ForeColor="Red" 
                                                EnableClientScript="False">*</asp:RegularExpressionValidator>
                                        </td>
                                        <td class="ControlCell" style="width: 25%;">
                                            <asp:Label ID="Label35" runat="server" Width="90%">Continua con Seguimiento ??</asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 249px; text-align: left;">
                                            <asp:dropdownlist id="ddl_Seguimiento" runat="server" Width="90%" 
                                                Font-Size="X-Small" Enabled="False" >
                                            </asp:dropdownlist>
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 25%; height: 16px">
                                        </td>
                                        <td class="ControlCell" style="width: 25%; height: 16px">
                                        </td>
                                        <td class="ControlCell" style="width: 25%; height: 16px">
                                            <asp:Label ID="LblIdPersona" runat="server" Width="7%"></asp:Label>
                                        </td>
                                        <td class="ControlCell" style="width: 249px; height: 16px; text-align: left;">
                                            <asp:Label ID="lblId" runat="server" Width="7%"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" colspan="4" style="height: 16px">
				                            <telerik:RadGrid ID="Rg_Listado" runat="server" AllowSorting="True"  GridLines="None" Skin="WebBlue" Width="100%" 
                                                AutoGenerateColumns="False" ShowStatusBar="True" TabIndex="6"  PageSize="20" CellSpacing="0">
                                                <MasterTableView  NoDetailRecordsText="No hay informaci&#243;n." NoMasterRecordsText="No hay informaci&#243;n." DataKeyNames="Id" CommandItemDisplay ="Top" AllowPaging="True">
                                                    <Columns>
                                                        <telerik:GridTemplateColumn HeaderText="No." DefaultInsertValue="" UniqueName="TemplateColumn">
                                                            <ItemTemplate>
                                                                <asp:label runat="server" id="lblno" text='<%# ctype(CType(Container.Parent.Parent.Parent,RadGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>' ToolTip = '<%#Container.DataItem.Id%>' />
                                                                <asp:Label runat="Server" Id="lblid" Visible ="False" Text ='<%#Container.DataItem.Id%>'/>
                                                            </ItemTemplate>
                                                        </telerik:GridTemplateColumn>                                
                        
                                                        <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" HeaderText="Id" ReadOnly="True"
                                                            SortExpression="Id" UniqueName="Id"  Display ="False" >
                                                        </telerik:GridBoundColumn>

                                                        <telerik:GridBoundColumn DataField="Tipo" HeaderText="Tipo" SortExpression="Tipo" UniqueName="Tipo" >
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>

                                                        <telerik:GridBoundColumn DataField="Identificacion" HeaderText="Identificación"
                                                            SortExpression="Identificacion" UniqueName="Identificacion" >
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>

                                                        <telerik:GridBoundColumn DataField="NombreCompleto" HeaderText="Nombre Completo"
                                                            SortExpression="NombreCompleto" UniqueName="NombreCompleto" >
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>

                                                        <telerik:GridBoundColumn DataField="Edad" HeaderText="Edad"
                                                            SortExpression="Edad" UniqueName="Edad" >
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>  
                                            
                                                        <telerik:GridBoundColumn DataField="Estudiaba_Actualmente" HeaderText="Est. Act. 1E"
                                                            SortExpression="Estudiaba_Actualmente" UniqueName="Estudiaba_Actualmente" >
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn> 
                             
                                                        <telerik:GridBoundColumn DataField="Certificado" HeaderText="Certificado"
                                                            SortExpression="Certificado" UniqueName="Certificado" >
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>  
                                                                                    
                                                        <telerik:GridBoundColumn DataField="EstudiaActualmente_EE" HeaderText="Est. Act. EE"
                                                            SortExpression="EstudiaActualmente_eE" UniqueName="EstudiaActualmente_EE" >
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>                                                          

                                                        <telerik:GridBoundColumn DataField="Grado_EE" HeaderText="Grado EE"
                                                            SortExpression="Grado_EE" UniqueName="Grado_EE" >
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>                                                          

                                                        <telerik:GridBoundColumn DataField="Certificado_EE" HeaderText="Certif. EE"
                                                            SortExpression="Certificado_EE" UniqueName="Certificado_EE" >
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>                                                           
                                                           
                                                        <telerik:GridBoundColumn DataField="MotivoNoEstudia_EE" HeaderText="MNE" HeaderTooltip ="Motivo No Estudio"
                                                            SortExpression="MotivoNoEstudia_EE" UniqueName="MotivoNoEstudia_EE" >
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>    

                                                        <telerik:GridBoundColumn DataField="Seguimiento_EE" HeaderText="Seg." HeaderTooltip ="Seguimiento"
                                                            SortExpression="Seguimiento_EE" UniqueName="Seguimiento_EE" >
                                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                        </telerik:GridBoundColumn>  

				                                    </Columns>
                                                    <CommandItemSettings ExportToCsvText ="Exportar a CSV" 
                                                        ExportToExcelText ="Exportar a Excel" ExportToPdfText ="Exportar a PDF"
                                                            ExportToWordText ="Exportar a Word" RefreshText ="Actualizar" 
                                                        AddNewRecordText =""  AddNewRecordImageUrl ="~/Images/nothing.gif"
                                                            ShowExportToCsvButton="True" ShowExportToExcelButton="True" 
                                                        ShowExportToPdfButton="True" ShowExportToWordButton ="True" 
                                                        ShowAddNewRecordButton="False"/>
                                                    <PagerStyle Mode="NumericPages" FirstPageToolTip="Primera" LastPageToolTip="Ultima" NextPagesToolTip="Pr&#243;ximas" NextPageToolTip="Pr&#243;xima" PagerTextFormat="Cambiar P&#225;gina: {4} &amp;nbsp;P&#225;gina &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;, registros &lt;strong&gt;{2}&lt;/strong&gt; a &lt;strong&gt;{3}&lt;/strong&gt; de &lt;strong&gt;{5}&lt;/strong&gt;." PrevPageToolTip="Anterior"  PrevPagesToolTip="Anteriores" />
                                                </MasterTableView>
                                                <ClientSettings EnablePostBackOnRowClick="True" EnableRowHoverStyle ="True" >
                                                    <Selecting AllowRowSelect ="True"  />
                                                </ClientSettings>
                    
                                                <ExportSettings
                                                    HideStructureColumns="True" filename ="Educacion_EE" ExportOnlyData="True" IgnorePaging="True" OpenInNewWindow="True">
                                                        <Pdf PageWidth="" >
                                                        </Pdf>
                                                </ExportSettings>
                                                <SortingSettings SortToolTip="Clic aqui para ordenar..."  SortedAscToolTip ="Ordenar Ascendente" SortedDescToolTip ="Ordenar Descendente" />
                                                <PagerStyle Mode="NumericPages"    />
                
                                            </telerik:RadGrid>
                                        </td>
                                    </tr>
                                </table> 
                            </asp:Panel>
                            <table id="tbl_resumn_psicologico" class="EditControlsTable" cellspacing="0" cellpadding="0" border="0" width="1000" align="center" >
                                <tr valign="top">
                                    <td class="LabelCell" colspan="2" style="width: 100%; background-color: coral">
                                        <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="Navy">Luego de estos encuentros grupales frente a las emociones que venia sintiendo en el último mes usted considera ?</asp:Label></td>
                                    <td class="LabelCell" colspan="2" style="background-color: coral">
                                        <asp:Label ID="Label14" runat="server" Font-Bold="True" ForeColor="Navy">A partir del ejercicio del dia de hoy (Mapa de Red Social) usted cree que puede ?</asp:Label></td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%; height: 16px">
                                        <asp:Label ID="Label15" runat="server" Width="90%">Aliviado al compartir su experiencia con otras familias que han vivido el desplazamiento</asp:Label></td>
                                    <td class="ControlCell" style="width: 25%; height: 16px; text-align: left;">
                                        <asp:dropdownlist id="ddl_aliviado" runat="server" Width="90%" 
                                            Font-Size="X-Small" />
                                                
                                        <asp:RegularExpressionValidator ID="rev_aliviado" runat="server"
                                            ControlToValidate="ddl_aliviado" ErrorMessage="Falta si esta aliviado" ValidationExpression="^[1-9]+[0-9]*$"
                                            ValidationGroup="SE" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                                    <td class="ControlCell" style="width: 25%; height: 16px">
                                        <asp:Label ID="Label44" runat="server" Width="90%">Recordar a quién usted puede acudir en momentos dificiles</asp:Label></td>
                                    <td class="ControlCell" style="width: 249px; height: 16px; text-align: left;">
                                        <asp:dropdownlist id="ddl_momentos" runat="server" Width="90%" 
                                            Font-Size="X-Small" >
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_momentos" runat="server"
                                            ControlToValidate="ddl_momentos" ErrorMessage="Falta momentos dificicles" ValidationExpression="^[1-9]+[0-9]*$"
                                            ValidationGroup="SE" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%; height: 16px">
                                        <asp:Label ID="Label20" runat="server" Width="90%">Ha tenido la oportunidad de comprender sus miedos?</asp:Label></td>
                                    <td class="ControlCell" style="width: 25%; height: 16px; text-align: left;">
                                        <asp:dropdownlist id="ddl_comprender_miedos" runat="server" Width="90%" 
                                            Font-Size="X-Small" >
                                        </asp:dropdownlist>
                                        <asp:RegularExpressionValidator ID="rev_comprender_miedos" runat="server"
                                            ControlToValidate="ddl_comprender_miedos" ErrorMessage="Falta comprender sus miedos"
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                                    <td class="ControlCell" style="width: 25%; height: 16px">
                                        <asp:Label ID="Label45" runat="server" Width="90%">Identificar Organizaciones del barrio que puede ayudarle</asp:Label></td>
                                    <td class="ControlCell" style="width: 249px; height: 16px; text-align: left;">
                                        <asp:dropdownlist id="ddl_identificar_organizaciones" runat="server" 
                                            Width="90%" Font-Size="X-Small" >
                                        </asp:dropdownlist>
                                        <asp:RegularExpressionValidator ID="rev_identificar_organizaciones"
                                            runat="server" ControlToValidate="ddl_identificar_organizaciones" ErrorMessage="Falta identificar organizaciones"
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%; height: 16px">
                                        <asp:Label ID="Label21" runat="server" Width="90%">Escuchado por el grupo</asp:Label></td>
                                    <td class="ControlCell" style="width: 25%; height: 16px; text-align: left;">
                                        <asp:dropdownlist id="ddl_escuchado" runat="server" Width="90%" 
                                            Font-Size="X-Small" >
                                        </asp:dropdownlist>
                                        <asp:RegularExpressionValidator ID="rev_escuchado" runat="server"
                                            ControlToValidate="ddl_escuchado" ErrorMessage="Falta escuchado por el grupo"
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                                    <td class="ControlCell" style="width: 25%; height: 16px">
                                        <asp:Label ID="Label46" runat="server" Width="90%">Identificar instituciones locales que puede acudir</asp:Label></td>
                                    <td class="ControlCell" style="width: 249px; height: 16px; text-align: left;">
                                        <asp:dropdownlist id="ddl_identificar_instituciones" runat="server" Width="90%" 
                                            Font-Size="X-Small" >
                                        </asp:dropdownlist>
                                        <asp:RegularExpressionValidator ID="rev_identificar_instituciones"
                                            runat="server" ControlToValidate="ddl_identificar_instituciones" ErrorMessage="Falta dato de identificar instituciones"
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%; height: 16px">
                                        <asp:Label ID="Label24" runat="server" Width="90%">Buscar ayuda de las personas de su barrio</asp:Label></td>
                                    <td class="ControlCell" style="width: 25%; height: 16px; text-align: left;">
                                        <asp:dropdownlist id="ddl_ayuda_personas" runat="server" Width="90%" 
                                            Font-Size="X-Small" >
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_ayuda_personas" runat="server"
                                            ControlToValidate="ddl_ayuda_personas" ErrorMessage="Falta ayuda a personas"
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                                    <td class="ControlCell" style="width: 25%; height: 16px">
                                        <asp:Label ID="Label47" runat="server" Width="90%">No me sirvio para nada</asp:Label></td>
                                    <td class="ControlCell" style="width: 249px; height: 16px; text-align: left;">
                                        <asp:dropdownlist id="ddl_sirvio" runat="server" Width="90%" 
                                            Font-Size="X-Small" >
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_sirvio" runat="server"
                                            ControlToValidate="ddl_sirvio" ErrorMessage="Falta dato de sirvio para nada"
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%; height: 16px">
                                        <asp:Label ID="Label37" runat="server" Width="90%">Identificar las habilidades con la que cuenta para salir adelante</asp:Label></td>
                                    <td class="ControlCell" style="width: 25%; height: 16px; text-align: left;">
                                        <asp:dropdownlist id="ddl_habilidades_salir" runat="server" Width="90%" 
                                            Font-Size="X-Small" >
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_habilidades_salir" runat="server"
                                            ControlToValidate="ddl_habilidades_salir" ErrorMessage="Falta habilidades salir"
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                                    <td class="ControlCell" style="width: 25%; height: 16px">
                                    </td>
                                    <td class="ControlCell" style="width: 249px; height: 16px; text-align: left;">
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%; height: 16px">
                                        <asp:Label ID="Label38" runat="server" Width="90%">Le ayuda para su bienestar emocional</asp:Label></td>
                                    <td class="ControlCell" style="width: 25%; height: 16px; text-align: left;">
                                        <asp:dropdownlist id="ddl_bienestar_emocional" runat="server" Width="90%" 
                                            Font-Size="X-Small" >
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_bienestar" runat="server"
                                            ControlToValidate="ddl_bienestar_emocional" ErrorMessage="Falta bienestar emocional"
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                                    <td class="ControlCell" style="width: 25%; height: 16px">
                                        <asp:Label ID="Label39" runat="server" Width="90%">Relaciones con su familia han mejorado</asp:Label>
                                    </td>
                                    <td class="ControlCell" style="width: 249px; height: 16px; text-align: left;">
                                        <asp:DropDownList ID="ddl_relaciones_familia" runat="server" 
                                            Font-Size="X-Small" Width="90%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_relaciones_familia" runat="server" 
                                            ControlToValidate="ddl_relaciones_familia" 
                                            ErrorMessage="Falta relaciones con la familia" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE">*</asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" colspan="4" style="background-color: coral">
                                        <asp:Label ID="Label50" runat="server" Font-Bold="True" ForeColor="Navy">Unidades de Apoyo</asp:Label></td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%; height: 16px">
                                        <asp:Label ID="Label40" runat="server" Width="90%">Ya inicio la primera sesion de seguimiento con un congestor UNIDOS?</asp:Label></td>
                                    <td class="ControlCell" style="width: 25%; height: 16px; text-align: left;">
                                        <asp:dropdownlist id="ddl_unidos" runat="server" Width="90%" 
                                            Font-Size="X-Small" AutoPostBack="True" >
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_unidos" runat="server" ControlToValidate="ddl_unidos"
                                            ErrorMessage="Falta dato de Unidos" ValidationExpression="^[1-9]+[0-9]*$" 
                                            ValidationGroup="SE" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                                    <td class="ControlCell" style="width: 25%; height: 16px">
                                        <asp:Label ID="Label42" runat="server" Width="90%">En que municipio?</asp:Label></td>
                                    <td class="ControlCell" style="width: 249px; height: 16px; text-align: left;">
                                        <asp:TextBox ID="txt_municipio_unidos" runat="server" Enabled="False" Font-Size="X-Small"
                                            Width="90%"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfv_Municipio_Unidos" runat="server" 
                                            ControlToValidate="txt_municipio_unidos" Enabled="False" 
                                            ErrorMessage="Falta Municipio Unidos" ForeColor="Red" ValidationGroup="SE">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%">
                                        <asp:Label ID="Label41" runat="server" Width="90%">Esta inscrito en Familias en Accion?</asp:Label></td>
                                    <td class="ControlCell" style="width: 25%; text-align: left;">
                                        <asp:dropdownlist id="ddl_familiasAccion" runat="server" Width="90%" 
                                            Font-Size="X-Small" AutoPostBack="True" >
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_FamiliasAccion" runat="server" ControlToValidate="ddl_familiasAccion"
                                            ErrorMessage="Falta dato de Familias en Accion" ValidationExpression="^[1-9]+[0-9]*$"
                                            ValidationGroup="SE" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                                    <td class="ControlCell" style="width: 25%">
                                        <asp:Label ID="Label43" runat="server" Width="90%">Esta inscrito en algún programa de alimentos del ICBF?</asp:Label></td>
                                    <td class="ControlCell" style="width: 249px; text-align: left;">
                                        <asp:dropdownlist id="ddl_icbf" runat="server" Width="90%" Font-Size="X-Small" >
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_icbf" runat="server" ControlToValidate="ddl_icbf"
                                            ErrorMessage="Falta dato de ICBF" ValidationExpression="^[1-9]+[0-9]*$" 
                                            ValidationGroup="SE" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" colspan="4" style="height: 14px">
                                        </td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="width: 25%">
                                        <asp:Label ID="Label36" runat="server" Width="90%">Observaciones</asp:Label></td>
                                    <td class="ControlCell" colspan="3">
                                        <asp:TextBox ID="txt_Observaciones" runat="server" MaxLength="800" Rows="5" Style="text-align: left"
                                            TextMode="MultiLine" Width="96%" Font-Size="X-Small"></asp:TextBox></td>
                                </tr>
                                <tr valign="top">
                                    <td class="LabelCell" style="background-color: infobackground" colspan="4" align="center">
                                        <asp:Label ID="Label17" runat="server" ForeColor="Navy" Font-Bold="True" Font-Italic="True" Font-Size="X-Small" Width="796px">RECUERDE ORIENTAR A LA PERSONA SOBRE LA ORGANIZACION Y LOS LIDERES CORRESPONDIENTES A SU LUGAR DE RESIDENCIA</asp:Label></td>
                                </tr>

                                <tr valign="top">
                                <td align="center" class="LabelCell" colspan="4" style="background-color: activecaption">
                                    <asp:Label ID="Label30" runat="server" Font-Bold="True" ForeColor="Navy">FIN  DE  LA  ENCUESTA</asp:Label></td>
                                </tr>

                            </table>
                            <table width="100%">
                                <tr valign="top">
                                    <td align="center">
                                        <div>
                                            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" cssclass="Boton" 
                                                Width="204px"></asp:Button>&nbsp;</div>
                                    </td>
                                </tr>
                            </table>
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
            <telerik:AjaxSetting AjaxControlID="ddl_haoidoasociaciones">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ddl_pertenece_asociacion" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rev_Pertenece_Asociacion" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_Asociacion" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rfv_Nombre_Asociacion" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ddl_pertenece_asociacion">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="txt_Asociacion" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rfv_Nombre_Asociacion" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Lst_FuentesIngreso">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="Lst_FuentesIngreso" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Lst_FuentesIngresoDeclarante" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Lst_FuentesIngresoDeclarante">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="Lst_FuentesIngreso" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Lst_FuentesIngresoDeclarante" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Dg_Psicosocial">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="Dg_Psicosocial" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Dg_Emociones">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="Dg_Emociones" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ddl_emociones">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="Lst_PersonasAyuda" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Lst_PersonasAyuda_Declarante" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Lst_ApoyoPersonas" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Lst_ApoyoPersonas_Declarante" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Lst_PersonasAyuda">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="Lst_PersonasAyuda" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Lst_PersonasAyuda_Declarante" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Lst_PersonasAyuda_Declarante">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="Lst_PersonasAyuda" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Lst_PersonasAyuda_Declarante" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Lst_ApoyoPersonas">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="Lst_ApoyoPersonas" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Lst_ApoyoPersonas_Declarante" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Lst_ApoyoPersonas_Declarante">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="Lst_ApoyoPersonas" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Lst_ApoyoPersonas_Declarante" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btn_GrabarRegimen">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ValidationSummaryRS" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="lbl_NC2" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="btn_GrabarRegimen" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="lblerror1" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_regimen" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rev_regimen" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_eps" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rev_eps" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_municipio_regimen" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rfv_municipio_regimen" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_Necesita_Traslado" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rev_Necesita_Traslado" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="lblidpersonars" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="lblidrs" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Rg_Regimen" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Rg_Regimen">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="lbl_NC2" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="btn_GrabarRegimen" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="lblerror1" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_regimen" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rev_regimen" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_eps" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rev_eps" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_municipio_regimen" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rfv_municipio_regimen" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_Necesita_Traslado" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rev_Necesita_Traslado" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="lblidpersonars" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="lblidrs" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btn_GrabarBeneficiario">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="valSummarybe" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="lbl_NC" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="lblerror" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_Estudia_Actualmente" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rev_EstudiaActualmente" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_MotivoNoestudio" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rev_MotivoNoestudia" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_Certificado" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rev_certificado" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Txt_Establecimiento" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rfv_establecimiento" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_GradoEscolar" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rev_gradoescolar" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_Seguimiento" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="LblIdPersona" />
                    <telerik:AjaxUpdatedControl ControlID="lblId" />
                    <telerik:AjaxUpdatedControl ControlID="Rg_Listado" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ddl_Estudia_Actualmente">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ddl_MotivoNoestudio" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rev_MotivoNoestudia" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_Certificado" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rev_certificado" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Txt_Establecimiento" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rfv_establecimiento" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_GradoEscolar" />
                    <telerik:AjaxUpdatedControl ControlID="rev_gradoescolar" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_Seguimiento" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ddl_MotivoNoestudio">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ddl_Certificado" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rev_certificado" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_Seguimiento" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ddl_Certificado">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ddl_Seguimiento" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Rg_Listado">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="lbl_NC" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="btn_GrabarBeneficiario" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_Estudia_Actualmente" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rev_EstudiaActualmente" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_MotivoNoestudio" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rev_MotivoNoestudia" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_Certificado" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rev_certificado" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Txt_Establecimiento" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rfv_establecimiento" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_GradoEscolar" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rev_gradoescolar" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_Seguimiento" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="LblIdPersona" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="lblId" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ddl_unidos">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="txt_municipio_unidos" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rfv_Municipio_Unidos" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnGuardar">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ValidationSummarySE" />
                    <telerik:AjaxUpdatedControl ControlID="pnl_principal" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
</asp:Content>

