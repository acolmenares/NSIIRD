<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="Asignaciones.aspx.vb" Inherits="WebForms_Asignaciones" %>
<%@ Register Src="../Controles/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style2
        {
            width: 440px;
        }
        .style3
        {
            width: 439px;
        }
        .style4
        {
            width: 438px;
        }
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


        <asp:Panel runat="server" ID="pnl_principal" DefaultButton="btn_actualizar" Width="1000px">

        <asp:ValidationSummary ID="VSCONTACTADO" runat="server" ValidationGroup="CONTACTADO" ForeColor="Red" style="text-align: left" EnableClientScript="False"  />
        <asp:ValidationSummary ID="VSELEGIBLE" runat="server" ValidationGroup="ELEGIBLE" ForeColor="Red" style="text-align: left" EnableClientScript="False" />
        <asp:ValidationSummary ID="VSPROGRAMADO0" runat="server" 
                ValidationGroup="PROGRAMADO" ForeColor="Red" style="text-align: left" 
                EnableClientScript="False" />
            <asp:ValidationSummary ID="VSPROGRAMADOVULNERABLE" runat="server" 
                EnableClientScript="False" ForeColor="Red" style="text-align: left" 
                ValidationGroup="PROGRAMADOVULNERABLE" />
        <table id="Table2" cellspacing="0" cellpadding="0" border="0" class="ContentTable"
            style="width: 100%">
            <tr valign="top">
                <td style="width: 75%; text-align: left;">
                    <asp:Label ID="lbl_Titulo" runat="server" Text="ASIGNACION  DE PROGRAMAS A DECLARANTES - ELEGIBILIDAD"
                        Width="90%" CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
                    <asp:Label ID="lblMensaje" runat="server" CssClass="TitMensaje" Text="_" Width="90%"
                        Visible="False" />
                </td>
                <td style="width: 25%" align="right">
                    <asp:ImageButton ID="btn_actualizar" runat="server" ImageUrl="~/Images/Reload.jpg"
                        ToolTip="Actualizar la vista actual." TabIndex="5" />
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
                            <td class="LabelCell" colspan="6" style="background-color: orange; width: 100%; height: 16px;">
                                <asp:Label ID="Label10" runat="server" Font-Bold="True" ForeColor="Navy">Datos del Desplazamiento</asp:Label>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" style="width: 17%; background-color: #FFCC99;">
                                <asp:Label ID="Label38" runat="server" Width="100%">Tipo de Declarante</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_tipo_declarante" runat="server" Width="90%" 
                                    style="color: #000066">.</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; background-color: #FFCC99;">
                                <asp:Label ID="Label17" runat="server" Width="100%">Fecha Radicación</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_FechaRadicacion" runat="server" Width="100%" 
                                    style="color: #000066">.</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; background-color: #FFCC99;">
                                <asp:Label ID="Label75" runat="server" Width="100%" style="color: #000000">Tipo de Familia</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_TipoFamilia" runat="server" Width="100%" 
                                    style="color: #000066">.</asp:Label>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" style="width: 17%; background-color: #FFCC99;">
                                <asp:Label ID="lblSubTablasId_Fuente" runat="server" Width="100%">Fuente</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_fuente" runat="server" Width="90%" style="color: #000066">.</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; background-color: #FFCC99;">
                                <asp:Label ID="Label1" runat="server" Width="100%">Fecha Declaración</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_FechaDeclaracion" runat="server" Width="100%">.</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; background-color: #FFCC99;">
                                <asp:Label ID="Label18" runat="server" Width="100%" style="color: #000000">Regional</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_regional_Declarante" runat="server" Width="100%" 
                                    style="color: #000066">.</asp:Label>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" style="width: 17%; background-color: #FFCC99;">
                                <asp:Label ID="Label43" runat="server" Width="100%">Lugar de Fuente</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_lugarFuente" runat="server" Width="90%" 
                                    style="color: #000066">.</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; background-color: #FFCC99;">
                                <asp:Label ID="Label31" runat="server" Width="100%">Fecha Desplazamiento</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%;">
                                <asp:Label ID="lbl_FechaDesplazamiento" runat="server" Width="100%" 
                                    style="color: #000066">.</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; background-color: #FFCC99;">
                                <asp:Label ID="Label39" runat="server" Width="100%" style="color: #000000">Horario de Atención</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_Horario" runat="server" Width="100%" style="color: #000066">.</asp:Label>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" style="width: 17%; background-color: #FFCC99;">
                                <asp:Label ID="Label44" runat="server" Width="100%">En Línea</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_enlinea" runat="server" Width="90%" style="color: #000066">.</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; background-color: #FFCC99;">
                                <asp:Label ID="Label72" runat="server" Width="100%">Número Declaración</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%;">
                                <asp:Label ID="lbl_NumeroDeclaracion" runat="server" Width="100%" 
                                    style="color: #000066">.</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; background-color: #FFCC99;">
                                <asp:Label ID="Label36" runat="server" Width="100%" style="color: #000000">Motivo Desplazamiento</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%;">
                                <asp:Label ID="lbl_Motivo" runat="server" Width="100%" style="color: #000066">.</asp:Label>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" colspan="6" style="background-color: orange; width: 100%; height: 16px;">
                                <asp:Label ID="Label35" runat="server" Font-Bold="True" ForeColor="Navy">Datos Generales</asp:Label>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" style="width: 17%; background-color: #FFCC99;">
                                <asp:Label ID="Label6" runat="server" Width="100%">Primer Nombre</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_PrimerNombre" runat="server" Width="100%" 
                                    style="color: #000066">.</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; background-color: #FFCC99;">
                                <asp:Label ID="Label4" runat="server" Width="100%">Segundo Nombre</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_SegundoNombre" runat="server" Width="100%" 
                                    style="color: #000066">.</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; background-color: #FFCC99;">
                                <asp:Label ID="Label16" runat="server" Width="100%">Tipo de Identificación</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_TipoIdentificacion" runat="server" Width="100%" 
                                    style="color: #000066">.</asp:Label>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" style="width: 17%; background-color: #FFCC99;">
                                <asp:Label ID="Label5" runat="server" Width="100%">Primer Apellido</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_PrimerApellido" runat="server" Width="100%" 
                                    style="color: #000066">.</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; background-color: #FFCC99;">
                                <asp:Label ID="Label3" runat="server" Width="100%">Segundo Apellido</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_SegundoApellido" runat="server" Width="100%" 
                                    style="color: #000066">.</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; background-color: #FFCC99;">
                                <asp:Label ID="Label15" runat="server" Width="100%">Número Identificación</asp:Label>
                            </td>
                            <td style="width: 17%">
                                <asp:Label ID="lbl_Identificacion" runat="server" Width="100%" 
                                    style="color: #000066">.</asp:Label>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" style="width: 17%; background-color: #FFCC99;">
                                <asp:Label ID="Label30" runat="server" Width="100%">Genero</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_Genero" runat="server" Width="100%" style="color: #000066">.</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; background-color: #FFCC99;">
                                <asp:Label ID="Label28" runat="server" Width="100%">Fecha de Nacimiento</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_FechaNacimiento" runat="server" Width="100%" 
                                    style="color: #000066">.</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; background-color: #FFCC99;">
                                <asp:Label ID="Label27" runat="server" Width="100%">Edad</asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="lbl_Edad" runat="server" Width="100%" style="color: #000066">.</asp:Label>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" colspan="6" style="background-color: orange; width: 100%;">
                                <asp:Label ID="Label41" runat="server" Width="22%" Font-Bold="True">Datos de Contacto</asp:Label>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" rowspan="5" style="width: 17%; background-color: lightyellow; text-align: center;"
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
                            <td class="ControlCell" 
                                style="width: 17%; background-color: lightyellow; text-align: left;">
                                <asp:LinkButton ID="LinkButton2" runat="server">Retirar</asp:LinkButton>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" colspan="6" rowspan="1" style="background-color: orange; width: 100%;">
                                <asp:Label ID="Label33" runat="server" Font-Bold="True" Width="42%">Estados Generales del Declarante. Programación y Coordinación</asp:Label>&nbsp;
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" colspan="6" 
                                style="background-color: orange; width: 100%;">
                                <telerik:RadGrid ID="Rg_Listado" runat="server" AllowSorting="True" 
                                    AutoGenerateColumns="False" PageSize="20" 
                                    ShowStatusBar="True" Skin="WebBlue" TabIndex="6" Width="100%" 
                                    ResolvedRenderMode="Classic">
                                    <MasterTableView AllowPaging="True" CommandItemDisplay="Top" DataKeyNames="Id" 
                                        NoDetailRecordsText="No hay información." 
                                        NoMasterRecordsText="No hay información.">
                                        <Columns>
                                            <telerik:GridTemplateColumn DefaultInsertValue="" HeaderText="No." 
                                                UniqueName="TemplateColumn">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblno" runat="server" 
                                                        text="<%# ctype(CType(Container.Parent.Parent.Parent,RadGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>" ToolTip ='<%#Container.DataItem.Id%>' />
                                                    <asp:Label ID="lblid" runat="Server" Text="<%#Container.DataItem.Id%>" Visible="False" />
                                                </ItemTemplate>
                                            </telerik:GridTemplateColumn>
                                            <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" Display="False" 
                                                HeaderText="Id" ReadOnly="True" SortExpression="Id" UniqueName="Id">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="Fecha" DataType="System.DateTime" HeaderText="Fecha "
                                                DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha" UniqueName="Fecha">
                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                <ItemStyle HorizontalAlign ="Center" />
                                            </telerik:GridBoundColumn>	

                                            <telerik:GridBoundColumn DataField="TipoEstado.Descripcion" HeaderText="Estado" 
                                                SortExpression="TipoEstado.Descripcion" UniqueName="TipoEstado.Descripcion">
                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                    Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                    Wrap="True" />
                                                    <ItemStyle HorizontalAlign ="Center" />
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="ComoEstado.Descripcion" 
                                                HeaderText="Resultado" SortExpression="ComoEstado.Descripcion" 
                                                UniqueName="ComoEstado.Descripcion">
                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                    Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                    Wrap="True" />
                                                <ItemStyle HorizontalAlign ="Center" />
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="ProgramaAsistio" HeaderText="Programa" 
                                                SortExpression="ProgramaAsistio" UniqueName="ProgramaAsistio">
                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                    Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                    Wrap="True" />
                                                    <ItemStyle HorizontalAlign ="Center" />
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="AsistioEstado" HeaderText="Asistio" 
                                                SortExpression="AsistioEstado" UniqueName="AsistioEstado">
                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                                    Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                                    Wrap="True" />
                                                    <ItemStyle HorizontalAlign ="Center" />
                                            </telerik:GridBoundColumn>
                                        </Columns>
                                        <CommandItemSettings AddNewRecordImageUrl="~/Images/nothing.gif" 
                                            AddNewRecordText="" ExportToCsvText="Exportar a CSV" 
                                            ExportToExcelText="Exportar a Excel" ExportToPdfText="Exportar a PDF" 
                                            ExportToWordText="Exportar a Word" RefreshText="Actualizar" 
                                            ShowAddNewRecordButton="False" ShowExportToCsvButton="True" 
                                            ShowExportToExcelButton="True" ShowExportToPdfButton="True" 
                                            ShowExportToWordButton="True" />
                                        <PagerStyle FirstPageToolTip="Primera" LastPageToolTip="Ultima" 
                                            Mode="NumericPages" NextPagesToolTip="Próximas" NextPageToolTip="Próxima" 
                                            PagerTextFormat="Cambiar Página: {4} &amp;nbsp;Página &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;, registros &lt;strong&gt;{2}&lt;/strong&gt; a &lt;strong&gt;{3}&lt;/strong&gt; de &lt;strong&gt;{5}&lt;/strong&gt;." 
                                            PrevPagesToolTip="Anteriores" PrevPageToolTip="Anterior" />
                                    </MasterTableView>
                                    <ClientSettings EnablePostBackOnRowClick="True" EnableRowHoverStyle="True">
                                        <Selecting AllowRowSelect="True" />
                                    </ClientSettings>
                                    <ExportSettings ExportOnlyData="True" filename="EstadosAsignacion" 
                                        HideStructureColumns="True" IgnorePaging="True" OpenInNewWindow="True">
                                        <Pdf PageWidth="">
                                        </Pdf>
                                    </ExportSettings>
                                    <SortingSettings SortedAscToolTip="Ordenar Ascendente" 
                                        SortedDescToolTip="Ordenar Descendente" 
                                        SortToolTip="Clic aqui para ordenar..." />
                                    <PagerStyle Mode="NumericPages" />
                                </telerik:RadGrid>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td align="center" class="LabelCell" colspan="6" 
                                style="background-color: orange; width: 50%;">
                                <asp:Label ID="Label66" runat="server" Font-Bold="True" Width="90%">Asignar las fechas de Coordinación al Declarante</asp:Label>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" colspan="6" rowspan="1" style="background-color: khaki; width: 50%;"                               >

                                <telerik:RadTabStrip ID="rts_estados" runat="server" 
                                    MultiPageID="RadMultiPage1" SelectedIndex="3" Skin="Telerik" 
                                    Enabled="False" ResolvedRenderMode="Classic">
                                    <Tabs>
                                        <telerik:RadTab runat="server" Text="Elegible" 
                                            SelectedIndex="0" Owner="rts_estados">
                                        </telerik:RadTab>
                                        <telerik:RadTab runat="server" Text="Contacto" SelectedIndex="1" 
                                            Owner="rts_estados">
                                        </telerik:RadTab>
                                        <telerik:RadTab runat="server" Text="Programación" SelectedIndex="2" 
                                            Owner="rts_estados">
                                        </telerik:RadTab>
                                        <telerik:RadTab runat="server" Selected="True" Text="Especiales">
                                        </telerik:RadTab>
                                    </Tabs>
                                </telerik:RadTabStrip>
                                <telerik:RadMultiPage ID="RadMultiPage1" runat="server" Width="100%" 
                                    SelectedIndex="3">
                                    <telerik:RadPageView ID="RadPageView1" runat="server" Selected="True" 
                                        Enabled="False">
                                        <table ID="tbl_elegible" border="0" cellpadding="0" cellspacing="0" 
                                            style="width:100%;">
                                            <tr valign="top">
                                                <td style="width: 275px">
                                                    &nbsp;</td>
                                                <td class="style3">
                                                    <asp:Label ID="lbl_IdEstado" runat="server"></asp:Label>
                                                </td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                            <tr valign="top">
                                                <td style="width: 275px">
                                                    <asp:Label ID="Label63" runat="server" Width="100%">Este Declarante es Elegible ?</asp:Label>
                                                </td>
                                                <td class="style3">
                                                    <asp:DropDownList ID="ddl_elegible" runat="server" Font-Size="X-Small" 
                                                        Width="50%" AutoPostBack="True">
                                                    </asp:DropDownList>
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" 
                                                        ControlToValidate="ddl_elegible" EnableClientScript="False" 
                                                        ErrorMessage="Falta Definir si es Elegible" ForeColor="Red" 
                                                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="ELEGIBLE">*</asp:RegularExpressionValidator>
                                                </td>
                                                <td rowspan="3" style="vertical-align: middle">
                                                    <asp:Button ID="btn_GrabarElegible" runat="server" CssClass="Boton" 
                                                        Height="36px" Text="Grabar Elegibilidad" Width="115px" />
                                                </td>
                                            </tr>
                                            <tr valign="top">
                                                <td>
                                                    <asp:Label ID="Label64" runat="server" Width="100%">Fecha Elegibilidad</asp:Label>
                                                </td>
                                                <td class="style3">
                                                    <telerik:RadDatePicker ID="rdp_FechaElegible" runat="server" 
                                                        Culture="Spanish (Colombia)" MinDate="" Skin="Telerik" 
                                                        ToolTip="Seleccione Fecha ..." Width="60%">
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
                                                    <asp:RequiredFieldValidator ID="rfv_elegible" runat="server" 
                                                        ControlToValidate="rdp_FechaElegible" 
                                                        ErrorMessage="Falta la Fecha de Elegibilidad" ForeColor="Red" 
                                                        ValidationGroup="ELEGIBLE" EnableClientScript="False">*</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr valign="top">
                                                <td>
                                                    <asp:Label ID="Lbl_Noelegible" runat="server" Visible="False" Width="100%">Motivo de No Elegible</asp:Label>
                                                </td>
                                                <td class="style3">
                                                    <asp:DropDownList ID="ddl_MotivoPorQueNo" runat="server" Font-Size="X-Small" 
                                                        Visible="False" Width="80%">
                                                    </asp:DropDownList>
                                                    <asp:RegularExpressionValidator ID="rev_Motivonoelegible" runat="server" 
                                                        ControlToValidate="ddl_MotivoPorQueNo" 
                                                        ErrorMessage="Falta Motivo de No Elección" ForeColor="Red" 
                                                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="ELEGIBLE" 
                                                        Enabled="False">*</asp:RegularExpressionValidator>
                                                </td>
                                            </tr>
                                        </table>
                                    </telerik:RadPageView>
                                    <telerik:RadPageView ID="RadPageView2" runat="server" Enabled="False">
                                        <table ID="Table1" border="0" cellpadding="0" cellspacing="0" 
                                            style="width:100%;">
                                            <tr valign="top">
                                                <td style="width: 275px"></td>
                                                <td class="style3" >
                                                    <asp:Label ID="lbl_IdContacto" runat="server"></asp:Label>
                                                </td>
                                                <td></td>
                                            </tr>
                                            <tr valign="top">
                                                <td style="width: 275px">
                                                    <asp:Label ID="Label12" runat="server" Width="100%">Este declarante ha sido Contactado ?</asp:Label>
                                                </td>
                                                <td class="style3" >
                                                    <asp:DropDownList ID="ddl_contactado" runat="server" Font-Size="X-Small" 
                                                        Width="50%">
                                                    </asp:DropDownList>
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                                                        ControlToValidate="ddl_contactado" EnableClientScript="False" 
                                                        ErrorMessage="Falta si el Declarante ha sido contactado" ForeColor="Red" 
                                                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="CONTACTADO">*</asp:RegularExpressionValidator>
                                                </td>
                                                <td rowspan="2" style="vertical-align: middle">
                                                    <asp:Button ID="btn_GrabarContactado" runat="server" CssClass="Boton" 
                                                        Height="36px" Text="Grabar Contactado" Width="115px" />
                                                </td>
                                            </tr>
                                            <tr valign="top">
                                                <td style="width: 275px">
                                                    <asp:Label ID="Label13" runat="server" Width="100%">Fecha Contacto</asp:Label>
                                                </td>
                                                <td class="style3" >
                                                    <telerik:RadDatePicker ID="rdp_FechaContacto" runat="server" 
                                                        Culture="Spanish (Colombia)" MinDate="" Skin="Telerik" 
                                                        ToolTip="Seleccione Fecha ..." Width="60%" style="text-align: center">
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
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                        ControlToValidate="rdp_FechaContacto" 
                                                        ErrorMessage="Falta la Fecha de Contacto" ForeColor="Red" 
                                                        ValidationGroup="CONTACTADO">*</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                        </table>
                                    </telerik:RadPageView>
                                    <telerik:RadPageView ID="RadPageView3" runat="server" Enabled="False">
                                        <table ID="Table3" border="0" cellpadding="0" cellspacing="0" 
                                            style="width:100%;">
                                            <tr valign="top">
                                                <td style="width: 275px">
                                                    </td>
                                                <td class="style2" >
                                                    <asp:Label ID="lbl_IdProgramado" runat="server"></asp:Label>
                                                </td>
                                                <td>
                                                   </td>
                                            </tr>
                                            <tr valign="top">
                                                <td style="width: 275px">
                                                    <asp:Label ID="Label20" runat="server" Width="100%">Este declarante ha sido Programado ?</asp:Label>
                                                </td>
                                                <td class="style2" >
                                                    <asp:DropDownList ID="ddl_Programado" runat="server" Font-Size="X-Small" 
                                                        Width="50%" AutoPostBack="True">
                                                    </asp:DropDownList>
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                                                        ControlToValidate="ddl_Programado" EnableClientScript="False" 
                                                        ErrorMessage="Falta si el Declarante se va a Programar ?" ForeColor="Red" 
                                                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="PROGRAMADO">*</asp:RegularExpressionValidator>
                                                </td>
                                                <td rowspan="3" style="vertical-align: middle">
                                                    <asp:Button ID="btn_GrabarProgramacion" runat="server" CssClass="Boton" 
                                                        Height="36px" Text="Grabar programación" Width="115px" />
                                                </td>
                                            </tr>
                                            <tr valign="top">
                                                <td style="width: 275px">
                                                    <asp:Label ID="lbl_Programa" runat="server" Width="100%" Visible="False">Registro programación</asp:Label>
                                                </td>
                                                <td class="style2" >
                                                    <asp:DropDownList ID="ddl_Programa" runat="server" AutoPostBack="True" 
                                                        Font-Size="X-Small" Width="50%" Visible="False">
                                                    </asp:DropDownList>
                                                    <asp:RegularExpressionValidator ID="rev_Programa" runat="server" 
                                                        ControlToValidate="ddl_Programa" EnableClientScript="False" 
                                                        ErrorMessage="Falta Registro de Programación del Declarante" ForeColor="Red" 
                                                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="PROGRAMADO" 
                                                        Visible="False">*</asp:RegularExpressionValidator>
                                                </td>
                                            </tr>
                                            <tr valign="top">
                                                <td style="width: 275px">
                                                    <asp:Label ID="Label_Fecha_Programacion" runat="server" Width="100%" 
                                                        Visible="False">Fecha</asp:Label>
                                                </td>
                                                <td class="style2" >
                                                    <asp:Label ID="lbl_Fecha_Programacion" runat="server" 
                                                        style="color: #0000FF; font-size: small" Width="100%" Visible="False">Sin Definir</asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </telerik:RadPageView>

                                    <telerik:RadPageView ID="RadPageView4" runat="server" Enabled="False">
                                        <table ID="Table4" border="0" cellpadding="0" cellspacing="0" 
                                            style="width:100%;">
                                            <tr valign="top">
                                                <td style="width: 275px">
                                                    </td>
                                                <td class="style2" >
                                                    <asp:Label ID="lbl_IdProgramadoV" runat="server"></asp:Label>
                                                </td>
                                                <td>
                                                   </td>
                                            </tr>
                                            <tr valign="top">
                                                <td style="width: 275px">
                                                    <asp:Label ID="Label9" runat="server" Width="100%">Este declarante ha sido Programado Vulnerable?</asp:Label>
                                                </td>
                                                <td class="style2" >
                                                    <asp:DropDownList ID="ddl_ProgramadoV" runat="server" Font-Size="X-Small" 
                                                        Width="50%" AutoPostBack="True">
                                                    </asp:DropDownList>
                                                    <asp:RegularExpressionValidator ID="rev_Programado_Vulnerable" runat="server" 
                                                        ControlToValidate="ddl_ProgramadoV" EnableClientScript="False" 
                                                        ErrorMessage="Falta si el Declarante se va a Programar ?" ForeColor="Red" 
                                                        ValidationExpression="^[1-9]+[0-9]*$" 
                                                        ValidationGroup="PROGRAMADOVULNERABLE">*</asp:RegularExpressionValidator>
                                                </td>
                                                <td rowspan="3" style="vertical-align: middle">
                                                    <asp:Button ID="Button1" runat="server" CssClass="Boton" 
                                                        Height="36px" Text="Grabar programación" Width="115px" />
                                                </td>
                                            </tr>
                                            <tr valign="top">
                                                <td style="width: 275px">
                                                    <asp:Label ID="lbl_ProgramaV" runat="server" Width="100%" Visible="False">Registro programación</asp:Label>
                                                </td>
                                                <td class="style2" >
                                                    <asp:DropDownList ID="ddl_ProgramaV" runat="server" AutoPostBack="True" 
                                                        Font-Size="X-Small" Width="50%" Visible="False">
                                                    </asp:DropDownList>
                                                    <asp:RegularExpressionValidator ID="rev_ProgramaV" runat="server" 
                                                        ControlToValidate="ddl_ProgramaV" EnableClientScript="False" 
                                                        ErrorMessage="Falta Registro de Programación del Declarante" ForeColor="Red" 
                                                        ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="PROGRAMADOVULNERABLE" 
                                                        Visible="False">*</asp:RegularExpressionValidator>
                                                </td>
                                            </tr>
                                            <tr valign="top">
                                                <td style="width: 275px">
                                                    <asp:Label ID="Label_Fecha_ProgramacionV" runat="server" Width="100%" 
                                                        Visible="False">Fecha</asp:Label>
                                                </td>
                                                <td class="style2" >
                                                    <asp:Label ID="lbl_Fecha_ProgramacionV" runat="server" 
                                                        style="color: #0000FF; font-size: small" Width="100%" Visible="False">Sin Definir</asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </telerik:RadPageView>


                                </telerik:RadMultiPage>

                            </td>

                        </tr>
                        <tr valign="top">
                            <td align="left" class="LabelCell" colspan="1" 
                                style="background-color: #FFA500; text-align: center;" valign="middle">
                                <asp:Label ID="lbl_Observaciones" runat="server" Width="100%">Observaciones :</asp:Label>
                            </td>
                            <td colspan="5" style="background-color: #FFA500; text-align: left;">
                                <asp:TextBox ID="txt_observaciones" runat="server" MaxLength="4000" Rows="5" 
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
                <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server" 
                    DefaultLoadingPanelID="LoadingPanel2">
                    <AjaxSettings>
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
            </telerik:RadAjaxLoadingPanel>
        </asp:Panel>
    </asp:Panel>
</asp:Content>

