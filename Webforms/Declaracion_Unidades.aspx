<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="Declaracion_Unidades.aspx.vb" Inherits="WebForms_Declaracion_Unidades" %>
<%@ Register Src="../Controles/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            font-weight: bold;
        }
        .style2
        {
            text-align: left;
        }
        .style3
        {
            height: 14px;
        }
.RadPicker{vertical-align:middle}.RadPicker{vertical-align:middle}.RadPicker{vertical-align:middle}.rdfd_{position:absolute}.rdfd_{position:absolute}.rdfd_{position:absolute}.RadPicker .rcTable{table-layout:auto}.RadPicker .rcTable{table-layout:auto}.RadPicker .rcTable{table-layout:auto}.RadPicker .RadInput{vertical-align:baseline}.RadPicker .RadInput{vertical-align:baseline}.RadPicker .RadInput{vertical-align:baseline}.RadInput_Default{font:12px "segoe ui",arial,sans-serif}.RadInput{vertical-align:middle}.RadInput_Default{font:12px "segoe ui",arial,sans-serif}.RadInput{vertical-align:middle}.RadInput_Default{font:12px "segoe ui",arial,sans-serif}.RadInput{vertical-align:middle}.RadInput .riTextBox{height:17px}.RadInput .riTextBox{height:17px}.RadInput .riTextBox{height:17px}
        </style>
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
    <div style="text-align: left">
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    </div>


    <asp:Panel runat="server" ID="pnl_principal" DefaultButton="btn_cerrar" Width="1000px">
    <table id="Table2" cellspacing="0" cellpadding="0" border="0" class="ContentTable" style="width: 100%">
        <tr valign="top">
            <td style="width: 75%; text-align: left;">
                <asp:Label ID="lbl_Titulo" runat="server" Text="UNIDADES DE APOYO"
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
                <table id="tblContenido" class="EditControlsTable" cellspacing="0" cellpadding="0" border="0">
                    <tr valign="top">
                        <td class="LabelCell" colspan="6" 
                            style="background-color: #FF6600; width: 100%; height: 16px;">
                            <asp:Label ID="Label10" runat="server" Font-Bold="True" ForeColor="Navy">Datos del Desplazamiento</asp:Label>
                        </td>
                    </tr>
                    <tr valign="top">
                        <td class="LabelCell" style="width: 17%; ">
                            <asp:Label ID="Label38" runat="server" Width="100%" 
                                style="font-weight: 700; text-align: left">Tipo de Declarante</asp:Label>
                        </td>
                        <td class="ControlCell" style="width: 17%; ">
                            <asp:Label ID="lbl_tipo_declarante" runat="server" Width="90%">.</asp:Label>
                        </td>
                        <td class="style2" style="width: 17%; ">
                            <asp:Label ID="Label17" runat="server" Width="100%" CssClass="style1">Fecha Radicación</asp:Label>
                        </td>
                        <td class="ControlCell" style="width: 17%; ">
                            <asp:Label ID="lbl_FechaRadicacion" runat="server" Width="100%">.</asp:Label>
                        </td>
                        <td class="style2" style="width: 17%; ">
                            <asp:Label ID="Label75" runat="server" Width="100%" CssClass="style1">Tipo de Familia</asp:Label>
                        </td>
                        <td class="ControlCell" style="width: 17%; ">
                            <asp:Label ID="lbl_TipoFamilia" runat="server" Width="100%">.</asp:Label>
                        </td>
                    </tr>
                    <tr valign="top">
                        <td class="LabelCell" style="width: 17%; ">
                            <asp:Label ID="lblSubTablasId_Fuente" runat="server" Width="100%" 
                                style="font-weight: 700; text-align: left">Fuente</asp:Label>
                        </td>
                        <td class="ControlCell" style="width: 17%; ">
                            <asp:Label ID="lbl_fuente" runat="server" Width="90%">.</asp:Label>
                        </td>
                        <td class="style2" style="width: 17%; ">
                            <asp:Label ID="Label1" runat="server" Width="100%" CssClass="style1">Fecha Declaración</asp:Label>
                        </td>
                        <td class="ControlCell" style="width: 17%; ">
                            <asp:Label ID="lbl_FechaDeclaracion" runat="server" Width="100%">.</asp:Label>
                        </td>
                        <td class="style2" style="width: 17%; ">
                            <asp:Label ID="Label18" runat="server" Width="100%" CssClass="style1">Regional</asp:Label>
                        </td>
                        <td class="ControlCell" style="width: 17%; ">
                            <asp:Label ID="lbl_regional" runat="server" Width="100%">.</asp:Label>
                        </td>
                    </tr>
                    <tr valign="top">
                        <td class="style2" style="width: 17%; ">
                            <asp:Label ID="Label43" runat="server" Width="100%" CssClass="style1">Lugar de Fuente</asp:Label>
                        </td>
                        <td class="ControlCell" style="width: 17%; ">
                            <asp:Label ID="lbl_lugarFuente" runat="server" Width="90%">.</asp:Label>
                        </td>
                        <td class="style2" style="width: 17%; ">
                            <asp:Label ID="Label31" runat="server" Width="100%" CssClass="style1">Fecha Desplazamiento</asp:Label>
                        </td>
                        <td class="ControlCell" style="width: 17%;">
                            <asp:Label ID="lbl_FechaDesplazamiento" runat="server" Width="100%">.</asp:Label>
                        </td>
                        <td class="style2" style="width: 17%; ">
                            <asp:Label ID="Label39" runat="server" Width="100%" CssClass="style1">Horario de Atención</asp:Label>
                        </td>
                        <td class="ControlCell" style="width: 17%; ">
                            <asp:Label ID="lbl_Horario" runat="server" Width="100%">.</asp:Label>
                        </td>
                    </tr>
                    <tr valign="top">
                        <td class="style2" style="width: 17%; ">
                            <asp:Label ID="Label44" runat="server" Width="100%" CssClass="style1">En Línea</asp:Label>
                        </td>
                        <td class="ControlCell" style="width: 17%; ">
                            <asp:Label ID="lbl_enlinea" runat="server" Width="90%">.</asp:Label>
                        </td>
                        <td class="style2" style="width: 17%; ">
                            <asp:Label ID="Label72" runat="server" Width="100%" CssClass="style1">Número Declaración</asp:Label>
                        </td>
                        <td class="ControlCell" style="width: 17%;">
                            <asp:Label ID="lbl_NumeroDeclaracion" runat="server" Width="100%">.</asp:Label>
                        </td>
                        <td class="style2" style="width: 17%;">
                            <asp:Label ID="Label36" runat="server" Width="100%" CssClass="style1">Motivo Desplazamiento</asp:Label>
                        </td>
                        <td class="ControlCell" style="width: 17%;">
                            <asp:Label ID="lbl_Motivo" runat="server" Width="100%">.</asp:Label>
                        </td>
                    </tr>
                    <tr valign="top">
                        <td class="LabelCell" colspan="6" 
                            style="background-color: #FF6600; width: 100%; height: 16px;">
                            <asp:Label ID="Label35" runat="server" Font-Bold="True" ForeColor="Navy">Datos Generales</asp:Label>
                        </td>
                    </tr>
                    <tr valign="top">
                        <td class="style2" style="width: 17%; ">
                            <asp:Label ID="Label6" runat="server" Width="100%" CssClass="style1">Primer Nombre</asp:Label>
                        </td>
                        <td class="ControlCell" style="width: 17%; ">
                            <asp:Label ID="lbl_PrimerNombre" runat="server" Width="100%">.</asp:Label>
                        </td>
                        <td class="style2" style="width: 17%; ">
                            <asp:Label ID="Label4" runat="server" Width="100%" CssClass="style1">Segundo Nombre</asp:Label>
                        </td>
                        <td class="ControlCell" style="width: 17%; ">
                            <asp:Label ID="lbl_SegundoNombre" runat="server" Width="100%">.</asp:Label>
                        </td>
                        <td class="style2" style="width: 17%; ">
                            <asp:Label ID="Label16" runat="server" Width="100%" CssClass="style1">Tipo de Identificación</asp:Label>
                        </td>
                        <td class="ControlCell" style="width: 17%; ">
                            <asp:Label ID="lbl_TipoIdentificacion" runat="server" Width="100%">.</asp:Label>
                        </td>
                    </tr>
                    <tr valign="top">
                        <td class="style2" style="width: 17%; ">
                            <asp:Label ID="Label5" runat="server" Width="100%" CssClass="style1">Primer Apellido</asp:Label>
                        </td>
                        <td class="ControlCell" style="width: 17%; ">
                            <asp:Label ID="lbl_PrimerApellido" runat="server" Width="100%">.</asp:Label>
                        </td>
                        <td class="style2" style="width: 17%; ">
                            <asp:Label ID="Label3" runat="server" Width="100%" CssClass="style1">Segundo Apellido</asp:Label>
                        </td>
                        <td class="ControlCell" style="width: 17%; ">
                            <asp:Label ID="lbl_SegundoApellido" runat="server" Width="100%">.</asp:Label>
                        </td>
                        <td class="style2" style="width: 17%; ">
                            <asp:Label ID="Label15" runat="server" Width="100%" CssClass="style1">Número Identificación</asp:Label>
                        </td>
                        <td style="width: 17%">
                            <asp:Label ID="lbl_Identificacion" runat="server" Width="100%">.</asp:Label>
                        </td>
                    </tr>
                    <tr valign="top">
                        <td class="style2" style="width: 17%; ">
                            <asp:Label ID="Label30" runat="server" Width="100%" CssClass="style1">Genero</asp:Label>
                        </td>
                        <td class="ControlCell" style="width: 17%; ">
                            <asp:Label ID="lbl_Genero" runat="server" Width="100%">.</asp:Label>
                        </td>
                        <td class="style2" style="width: 17%; ">
                            <asp:Label ID="Label28" runat="server" Width="100%" CssClass="style1">Fecha de Nacimiento</asp:Label>
                        </td>
                        <td class="ControlCell" style="width: 17%; ">
                            <asp:Label ID="lbl_FechaNacimiento" runat="server" Width="100%">.</asp:Label>
                        </td>
                        <td class="style2" style="width: 17%; ">
                            <asp:Label ID="Label27" runat="server" Width="100%" CssClass="style1">Edad</asp:Label>
                        </td>
                        <td class="ControlCell" style="width: 17%; ">
                            <asp:Label ID="lbl_Edad" runat="server" Width="100%">.</asp:Label>
                        </td>
                    </tr>
                    <tr valign="top">
                        <td class="LabelCell" style="background-color: lightyellow; width: 17%;" 
                            align="left" valign="middle">
                            &nbsp;</td>
                        <td class="ControlCell" colspan="2" 
                            style="width: 34%; background-color: lightyellow;">
                            &nbsp;</td>
                        <td class="ControlCell" style="width: 17%; background-color: lightyellow;">
                            &nbsp;</td>
                        <td class="ControlCell" colspan="2" 
                            style="width: 330px; background-color: lightyellow;">
                            &nbsp;</td>
                    </tr>
                    <tr valign="top">
                        <td class="LabelCell" colspan="6" rowspan="1" 
                            style="background-color: #FF6600; width: 100%;">
                            <asp:Label ID="Label33" runat="server" Font-Bold="True" Width="49%">Generación de Nuevo Registro de Unidades de Apoyo</asp:Label>&nbsp;
                        </td>
                    </tr>

                    <tr valign="top">
                        <td align="left" class="LabelCell" colspan="6" 
                            style="background-color: #FFFFFF">
                            <table style="width:100%;">
                                <tr>
                                    <td style="width: 17%">
                                        <asp:Label ID="Label76" runat="server" CssClass="style1" Width="100%">Unidad de Apoyo</asp:Label>
                                    </td>
                                    <td style="width: 17%">
                                        <asp:DropDownList ID="ddl_unidad" runat="server" AutoPostBack="True" 
                                            Font-Size="X-Small" TabIndex="1" Width="94%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_unidad" runat="server" 
                                            ControlToValidate="ddl_unidad" EnableClientScript="False" 
                                            ErrorMessage="Falta definir la unidad de apoyo" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="width: 17%">
                                        <asp:Label ID="Label77" runat="server" CssClass="style1" Width="100%">Estado de la Unidad</asp:Label>
                                    </td>
                                    <td style="width: 17%">
                                        <asp:DropDownList ID="ddl_estado" runat="server" 
                                            Font-Size="X-Small" TabIndex="1" Width="94%">
                                        </asp:DropDownList>
                                        <asp:RegularExpressionValidator ID="rev_estado" runat="server" 
                                            ControlToValidate="ddl_estado" EnableClientScript="False" 
                                            ErrorMessage="Falta definir estado de unidad" ForeColor="Red" 
                                            ValidationExpression="^[1-9]+[0-9]*$">*</asp:RegularExpressionValidator>
                                    </td>
                                    <td style="width: 17%">
                                        <asp:Label ID="Label78" runat="server" CssClass="style1" Width="100%">Fecha Proceso</asp:Label>
                                    </td>
                                    <td style="width: 17%">
                                        <telerik:RadDatePicker ID="rdpFecha" runat="server" 
                                            Culture="Spanish (Colombia)" MinDate="" ToolTip="Seleccione Fecha ..." 
                                            Width="95%">
                                            <Calendar UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False" 
                                                ViewSelectorText="x">
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
                                        <asp:RequiredFieldValidator ID="rfv_Fecha" runat="server" 
                                            ControlToValidate="rdpFecha" EnableClientScript="False" 
                                            ErrorMessage="Falta la Fecha de Proceso" ForeColor="Red">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 17%">
                                        <asp:Label ID="Label79" runat="server" CssClass="style1" Width="100%">Modo de Proceso</asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:RadioButtonList ID="rdb_fuente" runat="server" 
                                            RepeatDirection="Horizontal">
                                            <asp:ListItem Selected="True">En IRD</asp:ListItem>
                                            <asp:ListItem>En Unidad</asp:ListItem>
                                            <asp:ListItem>Web Service RUV</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </td>
                                    <td style="width: 17%">
                                        &nbsp;</td>
                                    <td style="width: 17%">
                                        <asp:Label ID="Label80" runat="server" CssClass="style1" Width="100%">Fecha Investigación</asp:Label>
                                    </td>
                                    <td style="width: 17%">
                                        <telerik:RadDatePicker ID="rdpFecha_Investigacion" runat="server" 
                                            Culture="Spanish (Colombia)" MinDate="" ToolTip="Seleccione Fecha ..." 
                                            Width="95%">
                                            <Calendar UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False" 
                                                ViewSelectorText="x">
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
                                        <asp:RequiredFieldValidator ID="rfv_FechaInvestigacion" runat="server" 
                                            ControlToValidate="rdpFecha_Investigacion" EnableClientScript="False" 
                                            ErrorMessage="Falta la Fecha de Investigación" ForeColor="Red">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td colspan="2" style="text-align: center">
                                        <asp:Button ID="btn_grabar" runat="server" CssClass="Boton" 
                                            Text="Grabar Registro" />
                                    </td>
                                    <td colspan="2" style="text-align: center">
                                        <asp:Button ID="btn_limpiar" runat="server" CssClass="Boton" 
                                            Text="Limpiar Campos" />
                                    </td>
                                    <td>
                                        <asp:Label ID="lbl_idestado" runat="server"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>

                    <tr valign="top">
                        <td class="LabelCell" colspan="6" rowspan="1" 
                            style="background-color: #FF6600; width: 100%;">
                            <asp:Label ID="Label2" runat="server" Font-Bold="True" Width="49%">Resumen de las Unidades de Apoyo</asp:Label>&nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td colspan="6" class="style3">
                            <telerik:RadGrid ID="Rg_Listado" runat="server" AllowSorting="True" 
                                AutoGenerateColumns="False" CellSpacing="0" GridLines="None" PageSize="20" 
                                ShowStatusBar="True" Skin="WebBlue" TabIndex="6" Width="100%">
                                <MasterTableView AllowPaging="True" CommandItemDisplay="Top" DataKeyNames="Id" 
                                    NoDetailRecordsText="No hay información." 
                                    NoMasterRecordsText="No hay información.">
                                    <Columns>
                                        <telerik:GridTemplateColumn DefaultInsertValue="" HeaderText="No." 
                                            UniqueName="TemplateColumn">
                                            <ItemTemplate>
                                                <asp:Label ID="lblno" runat="server" 
                                                    text="<%# ctype(CType(Container.Parent.Parent.Parent,RadGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>" 
                                                    ToolTip="<%#Container.DataItem.Id%>" />
                                                <asp:Label ID="lblid" runat="Server" Text="<%#Container.DataItem.Id%>" 
                                                    Visible="False" />
                                            </ItemTemplate>
                                        </telerik:GridTemplateColumn>
                                        <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" Display="False" 
                                            HeaderText="Id" SortExpression="Id" UniqueName="Id">
                                        </telerik:GridBoundColumn>
                                        
                                        <telerik:GridBoundColumn DataField="Fecha_Investigacion" DataFormatString="{0:dd/MMM/yyyy}" DataType="System.DateTime" 
                                            HeaderText="Fecha Investigación" SortExpression="Fecha_Investigacion" UniqueName="Fecha_Investigacion">
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                Wrap="True" />
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="Fecha_Inclusion" DataFormatString="{0:dd/MMM/yyyy}" DataType="System.DateTime" 
                                            HeaderText="Fecha Proceso" SortExpression="Fecha_Inclusion" UniqueName="Fecha_Inclusion">
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                Wrap="True" />
                                        </telerik:GridBoundColumn>
                                        
                                        <telerik:GridBoundColumn DataField="Unidad.Descripcion" HeaderText="Unidad de Apoyo" SortExpression="Unidad.Descripcion" 
                                            UniqueName="Unidad.Descripcion">
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                Wrap="True" />
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="EstadoUnidad.Descripcion" HeaderText="Estado de Unidad" 
                                            SortExpression="EstadoUnidad.Descripcion" UniqueName="EstadoUnidad.Descripcion">
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                Wrap="True" />
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="Fuente" HeaderText="Fuente " SortExpression="Fuente" 
                                            UniqueName="Fuente">
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                Wrap="True" />
                                        </telerik:GridBoundColumn>

                                        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                            ConfirmDialogType="RadWindow" 
                                            ConfirmText="Desea Eliminar esta Registro de Unidades de Apoyo?" 
                                            ConfirmTitle="!!! Borrar Registro !!!" HeaderText="Eliminar" 
                                            HeaderTooltip="Eliminar Registro">
                                            <ItemStyle HorizontalAlign="Center" Width="20px" />
                                        </telerik:GridButtonColumn>
                                    </Columns>
                                    <CommandItemSettings AddNewRecordImageUrl="~/Images/nothing.gif" 
                                        AddNewRecordText="" ExportToCsvText="Exportar a CSV" 
                                        ExportToExcelText="Exportar a Excel" ExportToPdfText="Exportar a PDF" 
                                        ExportToWordText="Exportar a Word" RefreshText="Actualizar" 
                                        ShowAddNewRecordButton="False" ShowExportToCsvButton="True" 
                                        ShowExportToExcelButton="True" ShowExportToPdfButton="True" 
                                        ShowExportToWordButton="True" />
                                    <PagerStyle AlwaysVisible="True" FirstPageToolTip="Primera" 
                                        LastPageToolTip="Ultima" Mode="NumericPages" NextPagesToolTip="Próximas" 
                                        NextPageToolTip="Próxima" 
                                        PagerTextFormat="Cambiar Página: {4} &amp;nbsp;Página &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;, registros &lt;strong&gt;{2}&lt;/strong&gt; a &lt;strong&gt;{3}&lt;/strong&gt; de &lt;strong&gt;{5}&lt;/strong&gt;." 
                                        PrevPagesToolTip="Anteriores" PrevPageToolTip="Anterior" />
                                </MasterTableView>
                                <ClientSettings EnablePostBackOnRowClick="True" EnableRowHoverStyle="True">
                                    <Selecting AllowRowSelect="True" />
                                </ClientSettings>
                                <ExportSettings Excel-Format="ExcelML" ExportOnlyData="True" 
                                    filename="UnidadesApoyo" HideStructureColumns="True" IgnorePaging="True" 
                                    OpenInNewWindow="True" SuppressColumnDataFormatStrings="true">
                                    <Pdf PageWidth="">
                                    </Pdf>
                                    <Excel Format="ExcelML" />
                                </ExportSettings>
                                <SortingSettings SortedAscToolTip="Ordenar Ascendente" 
                                    SortedDescToolTip="Ordenar Descendente" 
                                    SortToolTip="Clic aqui para ordenar..." />
                                <PagerStyle AlwaysVisible="True" Mode="NumericPages" />
                            </telerik:RadGrid>
                        </td>
                    
                    
                    </tr>


                </table>
            </td>
        </tr>
    </table>
    <asp:Panel ID="pnl_final" runat="server" Width="100%" Style="vertical-align: middle;
        text-align: center">
        <telerik:RadAjaxLoadingPanel ID="LoadingPanel2" runat="server" BackgroundPosition="Right"
            Height="0px" Transparency="50">
            <asp:Image ID="Image1" runat="server" AlternateText="Cargando..." ImageUrl="~/Images/loading.gif" />
            <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
            </telerik:RadScriptManager>
            <telerik:RadStyleSheetManager ID="RadStyleSheetManager1" runat="server">
            </telerik:RadStyleSheetManager>
            <telerik:RadAjaxManager ID="RadAjaxManager2" runat="server" 
                DefaultLoadingPanelID="LoadingPanel2" EnableHistory="True">
                <AjaxSettings>
                    <telerik:AjaxSetting AjaxControlID="ddl_unidad">
                        <UpdatedControls>
                            <telerik:AjaxUpdatedControl ControlID="ddl_estado" UpdatePanelCssClass="" />
                        </UpdatedControls>
                    </telerik:AjaxSetting>
                    <telerik:AjaxSetting AjaxControlID="btn_grabar">
                        <UpdatedControls>
                            <telerik:AjaxUpdatedControl ControlID="ddl_unidad" UpdatePanelCssClass="" />
                            <telerik:AjaxUpdatedControl ControlID="ddl_estado" UpdatePanelCssClass="" />
                            <telerik:AjaxUpdatedControl ControlID="rdpFecha" UpdatePanelCssClass="" />
                            <telerik:AjaxUpdatedControl ControlID="Rg_Listado" UpdatePanelCssClass="" />
                            <telerik:AjaxUpdatedControl ControlID="lbl_idestado" UpdatePanelCssClass="" />
                            <telerik:AjaxUpdatedControl ControlID="rdpFecha_Investigacion" 
                                UpdatePanelCssClass="" />
                            <telerik:AjaxUpdatedControl ControlID="rdb_fuente" UpdatePanelCssClass="" />
                        </UpdatedControls>
                    </telerik:AjaxSetting>
                    <telerik:AjaxSetting AjaxControlID="btn_limpiar">
                        <UpdatedControls>
                            <telerik:AjaxUpdatedControl ControlID="ddl_unidad" UpdatePanelCssClass="" />
                            <telerik:AjaxUpdatedControl ControlID="ddl_estado" UpdatePanelCssClass="" />
                            <telerik:AjaxUpdatedControl ControlID="rdpFecha" UpdatePanelCssClass="" />
                            <telerik:AjaxUpdatedControl ControlID="lbl_idestado" UpdatePanelCssClass="" />
                            <telerik:AjaxUpdatedControl ControlID="rdpFecha_Investigacion" 
                                UpdatePanelCssClass="" />
                            <telerik:AjaxUpdatedControl ControlID="rdb_fuente" UpdatePanelCssClass="" />
                        </UpdatedControls>
                    </telerik:AjaxSetting>
                    <telerik:AjaxSetting AjaxControlID="Rg_Listado">
                        <UpdatedControls>
                            <telerik:AjaxUpdatedControl ControlID="ddl_unidad" UpdatePanelCssClass="" />
                            <telerik:AjaxUpdatedControl ControlID="ddl_estado" UpdatePanelCssClass="" />
                            <telerik:AjaxUpdatedControl ControlID="rdpFecha" UpdatePanelCssClass="" />
                            <telerik:AjaxUpdatedControl ControlID="lbl_idestado" UpdatePanelCssClass="" />
                            <telerik:AjaxUpdatedControl ControlID="rdpFecha_Investigacion" 
                                UpdatePanelCssClass="" />
                            <telerik:AjaxUpdatedControl ControlID="rdb_fuente" UpdatePanelCssClass="" />
                        </UpdatedControls>
                    </telerik:AjaxSetting>
                </AjaxSettings>
            </telerik:RadAjaxManager>
        </telerik:RadAjaxLoadingPanel>
    </asp:Panel>
</asp:Panel>
</asp:Content>

