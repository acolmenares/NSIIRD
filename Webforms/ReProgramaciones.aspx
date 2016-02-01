<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="ReProgramaciones.aspx.vb" Inherits="WebForms_ReProgramaciones" %>
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
    <telerik:RadStyleSheetManager ID="RadStyleSheetManager1" runat="server">
    </telerik:RadStyleSheetManager>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
    </telerik:RadAjaxManager>
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
    <asp:ValidationSummary ID="ValidationSummaryESTADO" runat="server" ValidationGroup="ELEGIBLE" ForeColor="Red" />
    <asp:ValidationSummary ID="ValidationSummaryCONTACTADO" runat="server" ValidationGroup="CONTACTADO" ForeColor="Red" />
    <asp:ValidationSummary ID="ValidationSummaryPROGRAMADO" runat="server" ValidationGroup="PROGRAMADO" ForeColor="Red" />
    <asp:ValidationSummary ID="ValidationSummaryREPROGRAMADO" runat="server" ValidationGroup="REPROGRAMADO" ForeColor="Red" />

        <asp:Panel runat="server" ID="pnl_principal" DefaultButton="btn_cerrar" Width="1000px">
        <table id="Table2" cellspacing="0" cellpadding="0" border="0" class="ContentTable"
            style="width: 100%">
            <tr valign="top">
                <td style="width: 75%; text-align: left;">
                    <asp:Label ID="lbl_Titulo" runat="server" Text="REPROGRAMACION DE DECLARANTE DESPLAZADO"
                        Width="90%" CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
                    <asp:Label ID="lblMensaje" runat="server" CssClass="TitMensaje" Text="_" Width="90%"
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
                        TabIndex="8" />&nbsp;
                </td>
            </tr>
            <tr valign="top">
                <td colspan="2">
                    <table id="tblContenido" class="EditControlsTable" cellspacing="0" 
                        cellpadding="0" border="0" style="padding-left: 5px">
                        <tr valign="top">
                            <td class="LabelCell" colspan="6" style="background-color: orange; width: 100%; height: 16px;">
                                <asp:Label ID="Label10" runat="server" Font-Bold="True" ForeColor="Navy">Datos del Desplazamiento</asp:Label>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="style1" style="width: 17%; ">
                                <asp:Label ID="Label38" runat="server" Width="100%" Font-Bold="True">Tipo de Declarante</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_tipo_declarante" runat="server" Width="90%">.</asp:Label>
                            </td>
                            <td class="style1" style="width: 17%; ">
                                <asp:Label ID="Label17" runat="server" Width="100%" Font-Bold="True">Fecha Radicación</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_FechaRadicacion" runat="server" Width="100%">.</asp:Label>
                            </td>
                            <td class="style1" style="width: 17%; ">
                                <asp:Label ID="Label75" runat="server" Width="100%" Font-Bold="True">Tipo de Familia</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_TipoFamilia" runat="server" Width="100%">.</asp:Label>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="style1" style="width: 17%; ">
                                <asp:Label ID="lblSubTablasId_Fuente" runat="server" Width="100%" 
                                    Font-Bold="True">Fuente</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_fuente" runat="server" Width="90%">.</asp:Label>
                            </td>
                            <td class="style1" style="width: 17%; ">
                                <asp:Label ID="Label1" runat="server" Width="100%" Font-Bold="True">Fecha Declaración</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_FechaDeclaracion" runat="server" Width="100%">.</asp:Label>
                            </td>
                            <td class="style1" style="width: 17%; ">
                                <asp:Label ID="Label18" runat="server" Width="100%" Font-Bold="True">Regional</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_regional" runat="server" Width="100%">.</asp:Label>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="style1" style="width: 17%; ">
                                <asp:Label ID="Label43" runat="server" Width="100%" Font-Bold="True">Lugar de Fuente</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_lugarFuente" runat="server" Width="90%">.</asp:Label>
                            </td>
                            <td class="style1" style="width: 17%; ">
                                <asp:Label ID="Label31" runat="server" Width="100%" Font-Bold="True">Fecha Desplazamiento</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%;">
                                <asp:Label ID="lbl_FechaDesplazamiento" runat="server" Width="100%">.</asp:Label>
                            </td>
                            <td class="style1" style="width: 17%; ">
                                <asp:Label ID="Label39" runat="server" Width="100%" Font-Bold="True">Horario de Atención</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_Horario" runat="server" Width="100%">.</asp:Label>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="style1" style="width: 17%; ">
                                <asp:Label ID="Label44" runat="server" Width="100%" Font-Bold="True">En Línea</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_enlinea" runat="server" Width="90%">.</asp:Label>
                            </td>
                            <td class="style1" style="width: 17%; ">
                                <asp:Label ID="Label72" runat="server" Width="100%" Font-Bold="True">Número Declaración</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%;">
                                <asp:Label ID="lbl_NumeroDeclaracion" runat="server" Width="100%">.</asp:Label>
                            </td>
                            <td class="style1" style="width: 17%;">
                                <asp:Label ID="Label36" runat="server" Width="100%" Font-Bold="True">Motivo Desplazamiento</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%;">
                                <asp:Label ID="lbl_Motivo" runat="server" Width="100%">.</asp:Label>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" colspan="6" style="background-color: orange; width: 100%; height: 16px;">
                                <asp:Label ID="Label35" runat="server" Font-Bold="True" ForeColor="Navy">Datos Generales</asp:Label>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="style1" style="width: 17%; ">
                                <asp:Label ID="Label6" runat="server" Width="100%" Font-Bold="True">Primer Nombre</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_PrimerNombre" runat="server" Width="100%">.</asp:Label>
                            </td>
                            <td class="style1" style="width: 17%; ">
                                <asp:Label ID="Label4" runat="server" Width="100%" Font-Bold="True">Segundo Nombre</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_SegundoNombre" runat="server" Width="100%">.</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; text-align: left;">
                                <asp:Label ID="Label16" runat="server" Width="100%" Font-Bold="True">Tipo de Identificación</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_TipoIdentificacion" runat="server" Width="100%">.</asp:Label>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="style1" style="width: 17%; ">
                                <asp:Label ID="Label5" runat="server" Width="100%" Font-Bold="True">Primer Apellido</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_PrimerApellido" runat="server" Width="100%">.</asp:Label>
                            </td>
                            <td class="style1" style="width: 17%; ">
                                <asp:Label ID="Label3" runat="server" Width="100%" Font-Bold="True">Segundo Apellido</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_SegundoApellido" runat="server" Width="100%">.</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; text-align: left;">
                                <asp:Label ID="Label15" runat="server" Width="100%" Font-Bold="True">Número Identificación</asp:Label>
                            </td>
                            <td style="width: 17%">
                                <asp:Label ID="lbl_Identificacion" runat="server" Width="100%">.</asp:Label>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="style1" style="width: 17%; ">
                                <asp:Label ID="Label30" runat="server" Width="100%" Font-Bold="True">Genero</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_Genero" runat="server" Width="100%">.</asp:Label>
                            </td>
                            <td class="style1" style="width: 17%; ">
                                <asp:Label ID="Label28" runat="server" Width="100%" Font-Bold="True">Fecha de Nacimiento</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_FechaNacimiento" runat="server" Width="100%">.</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="Label27" runat="server" Width="100%" Font-Bold="True" 
                                    style="text-align: left">Edad</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_Edad" runat="server" Width="100%">.</asp:Label>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" colspan="6" style="background-color: orange; width: 100%;">
                                <asp:Label ID="Label41" runat="server" Width="22%" Font-Bold="True">Datos de Contacto</asp:Label>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" rowspan="5" style="width: 17%; background-color: lightyellow;"
                                align="left" valign="middle">
                                <asp:Label ID="Label7" runat="server" Width="100%">Seleccione los tipos de Contacto con este declarante o vulnerable</asp:Label>
                            </td>
                            <td class="ControlCell" colspan="2" rowspan="5" 
                                style="width: 34%; background-color: lightyellow;">
                                <asp:ListBox ID="Lst_Tipos_Contacto" runat="server" Height="100px" Width="98%" Font-Size="X-Small">
                                </asp:ListBox>
                            </td>
                            <td class="ControlCell" style="width: 17%; background-color: lightyellow;">
                                <asp:Label ID="Label8" runat="server" Width="100%" Style="text-align: center">Digite valor para contacto</asp:Label>
                            </td>
                            <td class="ControlCell" colspan="2" rowspan="5" style="width: 330px; background-color: lightyellow;">
                                <asp:ListBox ID="Lst_Tipos_Contacto_Persona" runat="server" Height="100px" Width="98%"
                                    Font-Size="X-Small"></asp:ListBox>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="ControlCell" style="width: 17%; background-color: lightyellow;">
                                <asp:TextBox ID="txtvalor" runat="server" BackColor="ButtonFace" Width="96%" Font-Size="X-Small"></asp:TextBox>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="ControlCell" style="width: 17%; background-color: lightyellow;">
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="ControlCell" style="width: 17%; background-color: lightyellow;" 
                                align="right">
                                <asp:LinkButton ID="LinkButton1" runat="server">Cargar</asp:LinkButton>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="ControlCell" style="width: 17%; background-color: lightyellow;">
                                <asp:LinkButton ID="LinkButton2" runat="server">Retirar</asp:LinkButton>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" colspan="6" rowspan="1" style="background-color: orange; width: 100%;">
                                <asp:Label ID="Label33" runat="server" Font-Bold="True" Width="29%">Coordinación y programación</asp:Label>&nbsp;
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" colspan="4" rowspan="1" style="background-color: khaki; width: 50%;"
                               align="center">
                                
                                <asp:Label ID="Label66" runat="server" Font-Bold="True" Width="90%">Agregar o Editar fechas de coordinación</asp:Label>
                                
                            </td>
                            <td class="ControlCell" colspan="2" style="background-color: khaki; width: 50%;"
                                align="center">
                                
                                <asp:Label ID="Label67" runat="server" Font-Bold="True" Width="90%">Vista de Fechas de Control</asp:Label>
                                
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" colspan="4" rowspan="1" style="background-color: khaki; width: 50%;"                               >

                                         <table ID="Table4" border="0" cellpadding="0" cellspacing="0" 
                                            style="width:100%;">
                                            <tr>
                                                <td style="width: 275px">
                                                    &nbsp;</td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td style="width: 275px">
                                                    <asp:Label ID="Label24" runat="server" Width="100%">Se Seguira Atendiendo</asp:Label>
                                                </td>
                                                <td style="text-align: left">
                                                    <asp:DropDownList ID="ddl_reprogramado" runat="server" Font-Size="X-Small" 
                                                        Width="50%" AutoPostBack="True">
                                                    </asp:DropDownList>
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" 
                                                        ControlToValidate="ddl_reprogramado" EnableClientScript="False" 
                                                        ErrorMessage="Falta Resultado del Proceso" ForeColor="Red" 
                                                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="REPROGRAMADO">*</asp:RegularExpressionValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="width: 275px">
                                                    <asp:Label ID="Label76" runat="server" Width="100%">Motivo de Por que no se atiende?</asp:Label>
                                                </td>
                                                <td style="text-align: left">
                                                    <asp:DropDownList ID="ddl_MotivoPorQueNo" runat="server" 
                                                        Font-Size="X-Small" Visible="False" Width="80%">
                                                    </asp:DropDownList>
                                                    <asp:RegularExpressionValidator ID="rev_Motivo_NoContactado" runat="server" 
                                                        ControlToValidate="ddl_MotivoPorQueNo" EnableClientScript="False" 
                                                        ErrorMessage="Falta Motivo de No Contactado" ForeColor="Red" 
                                                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="CONTACTADO">*</asp:RegularExpressionValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="width: 275px">
                                                    <asp:Label ID="lbl_Reprograma" runat="server" Width="100%">Registro Reprogramación</asp:Label>
                                                </td>
                                                <td style="text-align: left">
                                                    <asp:DropDownList ID="ddl_Programa_Reprograma" runat="server" 
                                                        Font-Size="X-Small" Width="50%" Visible="False">
                                                    </asp:DropDownList>
                                                    <asp:RegularExpressionValidator ID="rev_reprograma" runat="server" 
                                                        ControlToValidate="ddl_Programa_Reprograma" EnableClientScript="False" 
                                                        ErrorMessage="Falta Re-Programa" ForeColor="Red" 
                                                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="REPROGRAMADO" 
                                                        Visible="False">*</asp:RegularExpressionValidator>
                                                </td>
                                            </tr>
                                             <tr>
                                                 <td style="width: 275px">
                                                     &nbsp;</td>
                                                 <td style="text-align: left">
                                                     &nbsp;</td>
                                             </tr>
                                            <tr>
                                                <td style="width: 275px; text-align: center;">
                                                    <asp:Button ID="btn_GrabarReprogramacion" runat="server" CssClass="Boton" 
                                                        Text="Grabar Reprogramación" Width="50%" />
                                                </td>
                                                <td style="text-align: center">
                                                    <asp:Button ID="btn_limpiarReprogramación" runat="server" CssClass="Boton" 
                                                        Text="Limpiar" Width="50%" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="width: 275px; text-align: center;">
                                                    &nbsp;</td>
                                                <td style="text-align: center">
                                                    &nbsp;</td>
                                            </tr>
                                        </table>


                            </td>
                            <td class="ControlCell" colspan="2" style="background-color: khaki; width: 50%;"
                                align="center">
                                <asp:GridView ID="gv_estados" runat="server" AutoGenerateColumns="False" 
                                    CellPadding="4" EmptyDataText="No hay información " ForeColor="#333333" 
                                    GridLines="None" Width="100%">
                                    <RowStyle BackColor="#E3EAEB" />
                                    <Columns>
                                        <asp:TemplateField HeaderText="Estado">
                                            <ItemTemplate>
                                                <asp:Label ID="Label1" runat="server" 
                                                    Text='<%# Eval("TipoEstado.Descripcion") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Resultado">
                                            <ItemTemplate>
                                                <asp:Label ID="Label2" runat="server" 
                                                    Text='<%# Eval("ComoEstado.Descripcion") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText="Programa">
                                            <ItemTemplate>
                                                <asp:Label ID="Label3" runat="server" 
                                                    Text='<%# Eval("ProgramaAsistio") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>

   
                                        <asp:TemplateField HeaderText="Asistio">
                                            <ItemTemplate>
                                                <asp:Label ID="Label2" runat="server" 
                                                    Text='<%# Eval("AsistioEstado") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="Fecha" DataFormatString="{0:dd/MMM/yyyy}" 
                                            HeaderText="Fecha" SortExpression="Fecha" />
                                        <asp:BoundField DataField="Id" Visible="False" />
     
                                    </Columns>
                                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                                    <EditRowStyle BackColor="#7C6F57" />
                                    <AlternatingRowStyle BackColor="White" />
                                </asp:GridView>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td align="left" class="LabelCell" colspan="1" 
                                style="background-color: #FFFFFF">
                                <asp:Label ID="lbl_Reprograma0" runat="server" Width="100%">Observaciones :</asp:Label>
                            </td>
                            <td colspan="5" style="background-color: #FFFFFF; text-align: left;">
                                <asp:TextBox ID="txt_observaciones" runat="server" MaxLength="8000" Rows="6" 
                                    style="text-align: left" TextMode="MultiLine" Width="90%"></asp:TextBox>
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
            </telerik:RadAjaxLoadingPanel>
        </asp:Panel>
    </asp:Panel>
</asp:Content>

