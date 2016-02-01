<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="SegundaEncuesta.aspx.vb" Inherits="WebForms_SegundaEncuesta" MaintainScrollPositionOnPostback ="true" %>
<%@ Register Src="../Controles/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .ControlCell
        {
            text-align: left;
        }
        .LabelCell
        {
            text-align: center;
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
                                Text="ENCUESTA PARA SEGUNDA ENTREGA DE DESPLAZADOS" Width="90%" 
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
                                <asp:Label ID="Label99" runat="server">GRUPO</asp:Label>
                            </td>
                            <td align="center" style="width: 25%;">
                                <asp:Label ID="lbl_Grupo" runat="server" Font-Bold="True" ForeColor="#C00000">GRUPO</asp:Label>
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
                                <table id="tblContenido" class="EditControlsTable" cellspacing="0" 
                                    cellpadding="0" border="0" width="1000" align="center">

                                    <tr valign="top">
                                        <td align="center" class="LabelCell" colspan="4" style="background-color: activecaption;">
                                            <asp:Label ID="Label31" runat="server" Font-Bold="True" ForeColor="Navy">INICIO  DE  LA  ENCUESTA # 2</asp:Label></td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="background-color: coral; height: 13px;" colspan="4">
                                            <asp:Label ID="Label5" runat="server" ForeColor="Navy">.</asp:Label></td>
                                    </tr>
                                    <tr valign="top">
                                        <td class="LabelCell" style="width: 25%">
                                            <asp:Label ID="lblSubTablasId_Reparaciones" runat="server" Width="96%">Usted ha oído hablar de la Mesa Municipal de Participacion de Víctimas?</asp:Label></td>
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
                                            <asp:Label ID="Label9" runat="server" Font-Bold="True" ForeColor="Navy">Atención Psicosocial</asp:Label></td>
                                    </tr>
                                            <tr valign="top">
                                                <td class="LabelCell" style="width: 25%">
                                                    <asp:Label ID="Label1" runat="server" Width="96%">Le gustaria Iniciar un proceso de apoyo emocional mutuo frente a lo que ha venido sintiendo despues del desplazamiento?</asp:Label>
                                                </td>
                                                <td class="ControlCell" style="width: 25%; text-align: left;">
                                                    <asp:DropDownList ID="ddl_apoyo_emocional" runat="server" Font-Size="X-Small" 
                                                        Width="90%">
                                                    </asp:DropDownList>
                                                    <asp:RegularExpressionValidator ID="rev_apoyo_emocional" runat="server" 
                                                        ControlToValidate="ddl_apoyo_emocional" ErrorMessage="Falta el apoyo emocional" 
                                                        ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE">*</asp:RegularExpressionValidator>
                                                </td>
                                                <td class="ControlCell" colspan="2" rowspan="2">
                                                    <asp:DataGrid ID="Dg_Emociones" runat="server" AutoGenerateColumns="False" 
                                                        BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" 
                                                        CellPadding="2" ForeColor="Black" GridLines="None" Width="98%">
                                                        <FooterStyle BackColor="Tan" CssClass="DataGridFooterStyle" />
                                                        <EditItemStyle CssClass="DataGridEditItemStyle" />
                                                        <SelectedItemStyle BackColor="DarkSlateBlue" 
                                                            CssClass="DataGridSelectedItemStyle" ForeColor="GhostWhite" />
                                                        <PagerStyle BackColor="PaleGoldenrod" CssClass="PagerStyle" 
                                                            ForeColor="DarkSlateBlue" HorizontalAlign="Center" Mode="NumericPages" />
                                                        <AlternatingItemStyle BackColor="PaleGoldenrod" 
                                                            CssClass="DataGridAlternatingItemStyle" />
                                                        <ItemStyle CssClass="DataGridItemStyle" />
                                                        <Columns>
                                                            <asp:TemplateColumn HeaderText="No.">
                                                                <ItemTemplate>
                                                                    <%# ctype(CType(Container.Parent.Parent,DataGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>
                                                                    <asp:Label ID="lblid" runat="server" Text="<%# Container.DataItem.ID %>" 
                                                                        Visible="false"></asp:Label>
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
                                                        <HeaderStyle BackColor="Tan" CssClass="DataGridHeaderStyle" Font-Bold="True" />
                                                    </asp:DataGrid>
                                                </td>
                                            </tr>
                                            <tr valign="top">
                                                <td class="LabelCell">
                                                    <asp:Label ID="Label23" runat="server" Width="96%">¿De lo que viene sintiendo en el último mes, usted ha buscado ayuda para hablar?</asp:Label>
                                                </td>
                                                <td class="LabelCell">
                                                    <asp:DropDownList ID="ddl_emociones" runat="server" AutoPostBack="True" 
                                                        Font-Size="X-Small" Width="90%">
                                                    </asp:DropDownList>
                                                    <asp:RegularExpressionValidator ID="rev_emociones" runat="server" 
                                                        ControlToValidate="ddl_emociones" ErrorMessage="Falta Dato de emociones" 
                                                        ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE">*</asp:RegularExpressionValidator>
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
                                                    <asp:DropDownList ID="ddl_departamento_rs" runat="server" AutoPostBack="True" 
                                                        Enabled="False" Font-Size="X-Small" Width="90%">
                                                    </asp:DropDownList>
                                                    <asp:DropDownList ID="ddl_municipio_rs" runat="server" Enabled="False" 
                                                        Font-Size="X-Small" Width="90%">
                                                    </asp:DropDownList>
                                                    <asp:RegularExpressionValidator ID="rev_regimen_municipio" runat="server" 
                                                        ControlToValidate="ddl_municipio_rs" EnableClientScript="False" Enabled="False" 
                                                        ErrorMessage="Falta municipio de regimen de salud" ForeColor="Red" 
                                                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="RS">*</asp:RegularExpressionValidator>
                                                </td>
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
				                                    <telerik:RadGrid ID="Rg_Regimen" runat="server" AllowSorting="True" GridLines="None" Skin="WebBlue" Width="100%"  
                                                        AutoGenerateColumns="False" ShowStatusBar="True" TabIndex="6" PageSize="20" CellSpacing="0">
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

                                                               <telerik:GridBoundColumn DataField="RegimenSegundaEntrega" HeaderText="Regimen Salud"
                                                                    SortExpression="RegimenSegundaEntrega" UniqueName="RegimenSegundaEntrega" >
                                                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                                </telerik:GridBoundColumn>

                                                               <telerik:GridBoundColumn DataField="MunicipioSegundaEntrega" HeaderText="Municipio"
                                                                    SortExpression="MunicipioSegundaEntrega" UniqueName="MunicipioSegundaEntrega" >
                                                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                                </telerik:GridBoundColumn>

                                                               <telerik:GridBoundColumn DataField="EPSSegundaEntrega" HeaderText="EPS"
                                                                    SortExpression="EPSSegundaEntrega" UniqueName="EPSSegundaEntrega" >
                                                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                                </telerik:GridBoundColumn>
                                                        
                                                               <telerik:GridBoundColumn DataField="NecesitaTrasladoSegundaEntrega" HeaderText="Traslado"
                                                                    SortExpression="NecesitaTrasladoSegundaEntrega" UniqueName="NecesitaTrasladoSegundaEntrega" >
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
                    
                                                     <ExportSettings
                                                       HideStructureColumns="True" filename ="RegimenSaludSE" ExportOnlyData="True" IgnorePaging="True" OpenInNewWindow="True">
                                                         <Pdf PageWidth="" >
                                                         </Pdf>
                                                    </ExportSettings>
                                                    <SortingSettings SortToolTip="Clic aqui para ordenar..."  SortedAscToolTip ="Ordenar Ascendente" SortedDescToolTip ="Ordenar Descendente" />
                                                    <PagerStyle Mode="NumericPages"    />
                
                                                </telerik:RadGrid>
                                                </td>
                                            </tr>
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
                                                        ValidationGroup="BE" ForeColor="Red" EnableClientScript="False">*</asp:RequiredFieldValidator></td>
                                            </tr>
                                            <tr valign="top">
                                                <td class="LabelCell" style="width: 25%;">
                                                    <asp:Label ID="Label108" runat="server" Width="90%">Departamento del Instituto</asp:Label>
                                                </td>
                                                <td class="ControlCell" style="width: 25%;">
                                                    <asp:DropDownList ID="ddl_Departamento_Instituto" runat="server" 
                                                        AutoPostBack="True" Enabled="False" Font-Size="X-Small" Width="90%">
                                                    </asp:DropDownList>
                                                </td>
                                                <td class="ControlCell" style="width: 25%;">
                                                    <asp:Label ID="Label109" runat="server" Width="90%">Municipio del Instituto</asp:Label>
                                                </td>
                                                <td class="ControlCell" style="width: 249px; text-align: left;">
                                                    <asp:DropDownList ID="ddl_Municipio_Instituto" runat="server" Enabled="False" 
                                                        Font-Size="X-Small" Width="90%">
                                                    </asp:DropDownList>
                                                    <asp:RegularExpressionValidator ID="rev_municipio_instituto" runat="server" 
                                                        ControlToValidate="ddl_Municipio_Instituto" EnableClientScript="False" 
                                                        Enabled="False" ErrorMessage="Falta municipio del instituto" ForeColor="Red" 
                                                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="BE">*</asp:RegularExpressionValidator>
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
                                                    <asp:Label ID="LblIdPersona" runat="server" Width="7%" Visible="False"></asp:Label></td>
                                                <td class="ControlCell" style="width: 249px; height: 16px; text-align: left;">
                                                    <asp:Label ID="lblId" runat="server" Width="7%" Visible="False"></asp:Label>
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
                                                                                    
                                                                <telerik:GridBoundColumn DataField="EstudiaActualmente_SE" HeaderText="Est. Act. 2E"
                                                                    SortExpression="EstudiaActualmente_SE" UniqueName="EstudiaActualmente_SE" >
                                                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                                </telerik:GridBoundColumn>                                                          

                                                                <telerik:GridBoundColumn DataField="Grado_SE" HeaderText="Grado 2E"
                                                                    SortExpression="Grado_SE" UniqueName="Grado_SE" >
                                                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                                </telerik:GridBoundColumn>                                                          

                                                                <telerik:GridBoundColumn DataField="Certificado_SE" HeaderText="Certif. 2E"
                                                                    SortExpression="Certificado_SE" UniqueName="Certificado_SE" >
                                                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                                </telerik:GridBoundColumn>                                                           
                                                           
                                                                <telerik:GridBoundColumn DataField="MotivoNoEstudia_SE" HeaderText="MNE" HeaderTooltip ="Motivo No Estudio"
                                                                    SortExpression="MotivoNoEstudia_SE" UniqueName="MotivoNoEstudia_SE" >
                                                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                                </telerik:GridBoundColumn>    

                                                                <telerik:GridBoundColumn DataField="Seguimiento_SE" HeaderText="Seg." HeaderTooltip ="Seguimiento"
                                                                    SortExpression="Seguimiento_SE" UniqueName="Seguimiento_SE" >
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
                                                            HideStructureColumns="True" filename ="Educacion_SE" ExportOnlyData="True" IgnorePaging="True" OpenInNewWindow="True">
                                                                <Pdf PageWidth="" >
                                                                </Pdf>
                                                        </ExportSettings>
                                                        <SortingSettings SortToolTip="Clic aqui para ordenar..."  SortedAscToolTip ="Ordenar Ascendente" SortedDescToolTip ="Ordenar Descendente" />
                                                        <PagerStyle Mode="NumericPages"    />
                
                                                    </telerik:RadGrid>
                                                </td>
                                            </tr>
                                            <tr valign="top">
                                                <td class="LabelCell" colspan="4" style="background-color: coral">
                                                    <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="Navy">Luego de estos encuentros grupales frente a las emociones que venia sintiendo en el último mes usted considera ?</asp:Label></td>
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
                                                    <asp:Label ID="Label44" runat="server" Width="90%">Recordar a quién usted puede acudir en momentos dificiles</asp:Label>
                                                </td>
                                                <td class="ControlCell" style="width: 249px; height: 16px; text-align: left;">
                                                    <asp:DropDownList ID="ddl_momentos" runat="server" Font-Size="X-Small" 
                                                        Width="90%">
                                                    </asp:DropDownList>
                                                    <asp:RegularExpressionValidator ID="rev_momentos" runat="server" 
                                                        ControlToValidate="ddl_momentos" ErrorMessage="Falta momentos dificicles" 
                                                        ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE">*</asp:RegularExpressionValidator>
                                                </td>
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
                                                    <asp:Label ID="Label45" runat="server" Width="90%">Identificar Organizaciones del barrio que puede ayudarle</asp:Label></td>
                                                <td class="ControlCell" style="width: 249px; height: 16px; text-align: left;">
                                                    <asp:DropDownList ID="ddl_identificar_organizaciones" runat="server" 
                                                        Font-Size="X-Small" Width="90%">
                                                    </asp:DropDownList>
                                                    <asp:RegularExpressionValidator ID="rev_identificar_organizaciones" 
                                                        runat="server" ControlToValidate="ddl_identificar_organizaciones" 
                                                        ErrorMessage="Falta identificar organizaciones" ForeColor="Red" 
                                                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE">*</asp:RegularExpressionValidator>
                                                </td>
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
                                                    <asp:Label ID="Label46" runat="server" Width="90%">Identificar instituciones locales que puede acudir</asp:Label>
                                                </td>
                                                <td class="ControlCell" style="width: 249px; height: 16px; text-align: left;">
                                                    <asp:DropDownList ID="ddl_identificar_instituciones" runat="server" 
                                                        Font-Size="X-Small" Width="90%">
                                                    </asp:DropDownList>
                                                    <asp:RegularExpressionValidator ID="rev_identificar_instituciones" 
                                                        runat="server" ControlToValidate="ddl_identificar_instituciones" 
                                                        ErrorMessage="Falta dato de identificar instituciones" ForeColor="Red" 
                                                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE">*</asp:RegularExpressionValidator>
                                                </td>
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
                                                    <asp:Label ID="Label47" runat="server" Width="90%">No me sirvio para nada</asp:Label>
                                                </td>
                                                <td class="ControlCell" style="width: 249px; height: 16px; text-align: left;">
                                                    <asp:DropDownList ID="ddl_sirvio" runat="server" Font-Size="X-Small" 
                                                        Width="90%">
                                                    </asp:DropDownList>
                                                    <asp:RegularExpressionValidator ID="rev_sirvio" runat="server" 
                                                        ControlToValidate="ddl_sirvio" ErrorMessage="Falta dato de sirvio para nada" 
                                                        ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE">*</asp:RegularExpressionValidator>
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
                                                    &nbsp;</td>
                                                <td class="ControlCell" style="width: 249px; height: 16px; text-align: left;">
                                                    &nbsp;</td>
                                            </tr>
                                            <tr valign="top">
                                                <td class="LabelCell" colspan="4" style="background-color: coral">
                                                    <asp:Label ID="Label50" runat="server" Font-Bold="True" ForeColor="Navy">Otras Medidas de Asistencia</asp:Label></td>
                                            </tr>
                                            <tr valign="top">
                                                <td class="LabelCell" style="width: 25%; height: 16px">
                                                    <asp:Label ID="Label41" runat="server" Width="90%">Esta inscrito en Familias en Accion?</asp:Label>
                                                </td>
                                                <td class="ControlCell" style="width: 25%; height: 16px; text-align: left;">
                                                    <asp:DropDownList ID="ddl_familiasAccion" runat="server" AutoPostBack="True" 
                                                        Font-Size="X-Small" Width="90%">
                                                    </asp:DropDownList>
                                                    <asp:RegularExpressionValidator ID="rev_FamiliasAccion" runat="server" 
                                                        ControlToValidate="ddl_familiasAccion" 
                                                        ErrorMessage="Falta dato de Familias en Accion" ForeColor="Red" 
                                                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE">*</asp:RegularExpressionValidator>
                                                </td>
                                                <td class="ControlCell" style="width: 25%; height: 16px">
                                                    <asp:Label ID="Label42" runat="server" Width="90%">En que municipio?</asp:Label></td>
                                                <td class="ControlCell" style="width: 249px; height: 16px; text-align: left;">
                                                    <asp:TextBox ID="txt_municipio_faccion" runat="server" Enabled="False" Font-Size="X-Small"
                                                        Width="90%"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="rfv_Municipio_Faccion" runat="server" 
                                                        ControlToValidate="txt_municipio_faccion" Enabled="False" 
                                                        ErrorMessage="Falta Municipio Familias en Acción" ForeColor="Red" 
                                                        ValidationGroup="SE">*</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr valign="top">
                                                <td class="LabelCell" style="width: 25%">
                                                    <asp:Label ID="Lbl_Psicosocial" runat="server" Width="90%">Usted o algún miembro de su familia ha recibido atención psicosocial?</asp:Label>
                                                </td>
                                                <td class="ControlCell" style="width: 25%; text-align: left;">
                                                    <asp:DropDownList ID="ddl_atencion_psicosocial" runat="server" 
                                                        Font-Size="X-Small" Width="90%">
                                                    </asp:DropDownList>
                                                    <asp:RegularExpressionValidator ID="_psicosocial" runat="server" 
                                                        ControlToValidate="ddl_atencion_psicosocial" 
                                                        ErrorMessage="Falta dato de Atencion Psicosocial" ForeColor="Red" 
                                                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE">*</asp:RegularExpressionValidator>
                                                </td>
                                                <td class="ControlCell" style="width: 25%">
                                                    &nbsp;</td>
                                                <td class="ControlCell" style="width: 249px; text-align: left;">
                                                    &nbsp;</td>
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


                                </table>

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
                                                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE">*</asp:RegularExpressionValidator>
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
                                                        ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE">*</asp:RegularExpressionValidator>
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
                                                        ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE">*</asp:RegularExpressionValidator>
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
                                                        ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE">*</asp:RegularExpressionValidator>
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
                                                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE">*</asp:RegularExpressionValidator>
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
                                                        ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE">*</asp:RegularExpressionValidator>
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
                                                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE">*</asp:RegularExpressionValidator>
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
                                                        ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE">*</asp:RegularExpressionValidator>
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
                                                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE">*</asp:RegularExpressionValidator>
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
                                                        ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE">*</asp:RegularExpressionValidator>
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
                                                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE">*</asp:RegularExpressionValidator>
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
                                                        ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE">*</asp:RegularExpressionValidator>
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
                                                        ValidationGroup="SE">*</asp:RegularExpressionValidator>
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
                                                        ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE">*</asp:RegularExpressionValidator>
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
                                                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE">*</asp:RegularExpressionValidator>
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
                                                        ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE">*</asp:RegularExpressionValidator>
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
                                                                    ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE">*</asp:RegularExpressionValidator>
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
                                                                    ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE" 
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
                                                                    ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE" 
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
                                                                    ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE" 
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
                                                                    ValidationGroup="SE" Enabled="False">*</asp:RegularExpressionValidator>
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
                                                                    ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE" 
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
                                                                    ForeColor="Red" ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE">*</asp:RegularExpressionValidator>
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
                                                                    ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE" 
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
                                                                    ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE">*</asp:RegularExpressionValidator>
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
                                                                    ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="SE" 
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

                                            <tr valign="top">
                                                <td align="center" class="LabelCell" colspan="6" style="background-color: activecaption">
                                                    <asp:Label ID="Label30" runat="server" Font-Bold="True" ForeColor="Navy">FIN  DE  LA  ENCUESTA</asp:Label></td>
                                            </tr>
                                            <tr valign="top">
                                                <td colspan="4">
                                        
                                                </td>
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
    </asp:Content>

