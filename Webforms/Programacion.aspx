<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="Programacion.aspx.vb" Inherits="WebForms_Programacion" %>
<%@ Register Src="../Controles/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
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
    <asp:ValidationSummary ID="ValidationSummaryRI" runat="server" ValidationGroup="RI"
        ForeColor="Red" EnableClientScript="False" style="text-align: left" />
    <asp:Panel runat="server" ID="pnl_principal" DefaultButton="btn_actualizar" Width="100%">
        <table id="Table2" cellspacing="0" cellpadding="0" border="0" class="ContentTable"
            style="width: 100%">
            <tr valign="top">
                <td style="width: 75%; text-align: left;">
                    <asp:Label ID="lbl_Titulo" runat="server" Text="CREACION / EDICION DE REGISTROS DE PROGRAMACION"
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
                        TabIndex="8" />&nbsp;
                </td>
            </tr>
            <tr valign="top">
                <td colspan="2">
                    <table id="tblContenido" class="EditControlsTable" cellspacing="0" cellpadding="0"
                        border="0" style="padding-left: 3px" width="100%">
                        <tr valign="top">
                            <td class="LabelCell" style="width: 17%; ">
                                <asp:Label ID="Label17" runat="server" Width="100%">Fecha Programación</asp:Label>
                            </td>
                            <td class="ControlCell" 
                                style="width: 17%; ">
                                <telerik:RadDatePicker ID="rdpFechaRadicacion" runat="server" 
                                    Culture="es-CO" MinDate="" Skin="Telerik" 
                                    ToolTip="Seleccione Fecha ..." Width="95%" ResolvedRenderMode="Classic">
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
                                <asp:RequiredFieldValidator ID="rfv_FechaRadicacion" runat="server" 
                                    ControlToValidate="rdpFechaRadicacion" EnableClientScript="False" 
                                    ErrorMessage="Falta la Fecha de Radicación" ForeColor="Red" 
                                    ValidationGroup="RI">*</asp:RequiredFieldValidator>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="Label18" runat="server" Width="100%">Regional</asp:Label>
                            </td>
                            <td class="ControlCell" 
                                style="width: 17%; ">
                                <asp:DropDownList ID="ddl_regional" runat="server" Font-Size="X-Small" 
                                    Width="94%" AutoPostBack="True">
                                </asp:DropDownList>
                                <asp:RegularExpressionValidator ID="rev_Regional" runat="server" 
                                    ControlToValidate="ddl_regional" EnableClientScript="False" 
                                    ErrorMessage="Falta la Regional" ForeColor="Red" 
                                    ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="RI">*</asp:RegularExpressionValidator>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="Label74" runat="server" Width="100%">Bodega a Descargar</asp:Label>
                            </td>
                            <td class="ControlCell" 
                                style="width: 17%; ">
                                <asp:DropDownList ID="ddl_bodegas" runat="server" AutoPostBack="True" 
                                    Font-Size="X-Small" Width="94%">
                                </asp:DropDownList>
                                <asp:RegularExpressionValidator ID="rev_bodegas" runat="server" 
                                    ControlToValidate="ddl_bodegas" EnableClientScript="False" 
                                    ErrorMessage="Falta la Bodega" ForeColor="Red" 
                                    ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="RI">*</asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" style="width: 17%; ">
                                <asp:Label ID="Label72" runat="server" Width="100%">Número Registro</asp:Label>
                            </td>
                            <td class="ControlCell" 
                                style="width: 17%; ">
                                <asp:TextBox ID="Txt_Numero_Registro" runat="server" MaxLength="20" 
                                    Width="81%" />
                                <asp:RequiredFieldValidator ID="rev_Numero_Registro" runat="server" 
                                    ControlToValidate="Txt_Numero_Registro" EnableClientScript="False" 
                                    ErrorMessage="Falta el Número de Registro" ForeColor="Red" ValidationGroup="RI">*</asp:RequiredFieldValidator>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="Label43" runat="server" Width="100%">Lugar de Fuente</asp:Label>
                            </td>
                            <td class="ControlCell" 
                                style="width: 17%; ">
                                <asp:DropDownList ID="ddl_LugarFuente" runat="server" Font-Size="X-Small" 
                                    Width="94%">
                                </asp:DropDownList>
                                <asp:RegularExpressionValidator ID="rev_LugarFuente" runat="server" 
                                    ControlToValidate="ddl_LugarFuente" EnableClientScript="False" 
                                    ErrorMessage="Falta Lugar de la Fuente de Información" ForeColor="Red" 
                                    ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="RI">*</asp:RegularExpressionValidator>
                            </td>
                            <td class="ControlCell" style="width: 17%; ">
                                <asp:Label ID="Label38" runat="server" Width="100%">Estado Actual</asp:Label>
                            </td>
                            <td class="ControlCell" 
                                style="width: 17%; ">
                                <asp:Label ID="lbl_estado" runat="server" Width="100%">N/A</asp:Label>
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="style5" style="width: 17%;">
                                <asp:Label ID="Label73" runat="server" Width="100%">Tipo de Entrega</asp:Label>
                            </td>
                            <td class="style4" style="width: 17%;">
                                <asp:DropDownList ID="ddl_tipoEntrega" runat="server" Font-Size="X-Small" 
                                    Width="94%">
                                </asp:DropDownList>
                                <asp:RegularExpressionValidator ID="rev_LugarFuente0" runat="server" 
                                    ControlToValidate="ddl_tipoEntrega" EnableClientScript="False" 
                                    ErrorMessage="Falta Tipo de Entrega" ForeColor="Red" 
                                    ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="RI">*</asp:RegularExpressionValidator>
                            </td>
                            <td class="style1" style="width: 17%;">
                                <asp:Button ID="btnactivar" runat="server" CssClass="Boton" TabIndex="3" 
                                    Text="Activar Programación" Width="120px" />
                                </td>
                            <td class="style2" 
                                style="width: 17%;">
                                <asp:Button ID="btnAsignar" runat="server" CssClass="Boton" TabIndex="3" 
                                    Text="Asignar Grupo" Width="120px" />
                            </td>
                            <td class="style6" style="width: 17%;">
                                <asp:Label ID="Label4" runat="server" Width="100%">Grupo Asignado</asp:Label>
                                </td>
                            <td class="style6" style="width: 17%;">
                                
                                <asp:Label ID="lbl_Grupo" runat="server" Height="16px" 
                                    style="color: #FF6699; font-weight: 700" Width="100%">N/A</asp:Label>
                                
                            </td>
                        </tr>
                        <tr valign="top">
                            <td class="LabelCell" colspan="6" style="background-color: orange; width: 100%; height: 16px;">
                                <asp:Label ID="Label35" runat="server" Font-Bold="True" ForeColor="Navy">Datos Generales</asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <asp:Panel ID="pnl_final" runat="server" Width="100%" Style="vertical-align: middle;
            text-align: center">
            <table border="0" cellpadding="0" cellspacing="0" style="width: 100%">
                <tr valign="top">
                    <td style="width: 15%; height: 16px;">
                        &nbsp;</td>
                    <td style="width: 15%; height: 16px;">
                        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="Boton" Width="100px"
                            TabIndex="1" ToolTip="Guardar la programación activa"></asp:Button>
                    </td>
                    <td style="width: 16%; height: 16px;">
                        <asp:Button ID="btnGuardarOtro" runat="server" Text="Guardar y agregar otro" CssClass="Boton"
                            Width="150px" TabIndex="2" 
                            ToolTip="Guardar la programación activa e iniciar uno nuevo"></asp:Button>
                    </td>
                    <td style="width: 15%; height: 16px;">
                        <asp:Button ID="btnEliminar" runat="server" Text='Eliminar' CssClass="Boton" Width="100px"
                            TabIndex="3"></asp:Button>
                    </td>
                    <td style="width: 15%; height: 16px;">
                        <asp:Label ID="lbl_IdEntregaAdicional" runat="server" Visible="False" 
                            Width="100%">..</asp:Label>
                    </td>
                </tr>
            </table>
            <asp:panel ID="pnl_asignar" runat ="server" Visible="False" >
            <table id="tbl_asignacion" runat="server" border="0" cellpadding="0" 
                    cellspacing="0" width="100%">
                <tr>
                    <td colspan="2" style="background-color: orange; width: 100%; height: 16px;">
                        <asp:Label ID="lbl_titulo1" runat="server" Text="ASIGNACION DE GRUPO" 
                            style="font-weight: 700; color: #000066"></asp:Label>
                    </td>

                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Por Favor Seleccione Su Grupo"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="RECOMENDACIONES IMPORTANTES" 
                            style="font-weight: 700"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList runat="server" ID="ddl_grupos" CssClass="drop01" ></asp:DropDownList>
                        <asp:Label ID="lbl_GrupoFijo" runat="server" Font-Bold="True" 
                            Font-Italic="True" Font-Size="XX-Large" ForeColor="#FF0066" Visible="False">FF5-006</asp:Label>
                    </td>
                    <td>
                        
                        <asp:ListBox ID="lst_recomendaciones" runat="server" Height="100%" Rows="7" 
                            Width="100%" Font-Size="X-Small">
                            <asp:ListItem>- Los Grupos a Seleccionar son libres (&quot;Abiertos&quot;)</asp:ListItem>
                            <asp:ListItem>- Las encuestas de la correspondiente entrega deben estar diligenciadas</asp:ListItem>
                            <asp:ListItem>- Deben estar las programaciones listas de segunda entrega si aplican!</asp:ListItem>
                            <asp:ListItem>- No se Pueden agregar mas personas a este grupo</asp:ListItem>
                            <asp:ListItem>- Toda doble reprogramación genera Motivo de exclusión</asp:ListItem>
                            <asp:ListItem>- Todo reprogramado debe ir a la seccion de Reprogramaciones</asp:ListItem>
                            <asp:ListItem Selected="True">- !!! ESTE PROCESO ES IRREVERSIBLE !!!</asp:ListItem>
                        </asp:ListBox>
                        
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <telerik:RadGrid ID="Rg_Listado" runat="server" AllowSorting="True" 
                            AutoGenerateColumns="False" CellSpacing="0" GridLines="None" PageSize="20" 
                            ShowStatusBar="True" Skin="WebBlue" TabIndex="6" Width="100%">
                            <MasterTableView CommandItemDisplay="Top" DataKeyNames="Id" 
                                NoDetailRecordsText="No hay información." 
                                NoMasterRecordsText="No hay información.">
                                <CommandItemSettings ShowAddNewRecordButton="False" />
                                <Columns>
                                    <telerik:GridTemplateColumn DefaultInsertValue="" HeaderText="No." 
                                        UniqueName="TemplateColumn">
                                        <ItemTemplate>
                                            <asp:Label ID="lblno" runat="server" text="<%# ctype(CType(Container.Parent.Parent.Parent,RadGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>" ToolTip = '<%#Container.DataItem.Id%>' />
                                            <asp:Label ID="lblid" runat="Server" Text='<%#Container.DataItem.Id%>' Visible="False" />
                                            <asp:Label ID="lbl_IdDeclaracion" runat="Server" Text="<%#Container.DataItem.Id_Declaracion%>" Visible="False" />
                                            <asp:Label ID="Lbl_IdPersona" runat="Server" Text="<%#Container.DataItem.Declaracion.Personas_Declarante.Id%>" Visible="False" />
                                            
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" HeaderText="Id" 
                                        ReadOnly="True" SortExpression="Id" UniqueName="Id" Display="False">
                                    </telerik:GridBoundColumn>

                                    <telerik:GridBoundColumn DataField="Declaracion.Declarante" HeaderText="TD" 
                                        HeaderTooltip="Tipo Declarante" SortExpression="Declaracion.Declarante" 
                                        UniqueName="Declaracion.Declarante">
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                            Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                            Wrap="True" />
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn DataField="Declaracion.Personas_Declarante.NombreCompleto" 
                                        HeaderText="Nombre Declarante" 
                                        SortExpression="Declaracion.Personas_Declarante.NombreCompleto" 
                                        UniqueName="Declaracion.Personas_Declarante.NombreCompleto">
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                            Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                            Wrap="True" />
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn DataField="Declaracion.Personas_Declarante.Identificacion" 
                                        HeaderText="Identificación" 
                                        SortExpression="Declaracion.Personas_Declarante.Identificacion" 
                                        UniqueName="Declaracion.Personas_Declarante.Identificacion">
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                            Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                            Wrap="True" />
                                    </telerik:GridBoundColumn>

                                    <telerik:GridBoundColumn DataField="Declaracion.TipoFamiliaxaEmpacar" 
                                        HeaderText="TFE" HeaderTooltip="Tipo de Familia Empacar" 
                                        SortExpression="Declaracion.TipoFamiliaxaEmpacar" 
                                        UniqueName="Declaracion.TipoFamiliaxaEmpacar">
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                            Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                    </telerik:GridBoundColumn>

                                    <telerik:GridBoundColumn DataField="Declaracion.TipoFamilia" HeaderText="TFR" HeaderTooltip="Tipo de Familia Real" 
                                        SortExpression="Declaracion.TipoFamilia" UniqueName="Declaracion.TipoFamilia">
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" 
                                            Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                            <ItemStyle Font-Bold ="true" />
                                    </telerik:GridBoundColumn>

                                    <telerik:GridTemplateColumn HeaderText ="Encuesta" HeaderTooltip ="Realizo la Encuesta Respectiva ?">
                                        <ItemTemplate >
                                            <asp:CheckBox ID="chb_encuesta" runat="server" enabled="false" />
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign ="Center" Width="30px" />
                                    </telerik:GridTemplateColumn>

                                    <telerik:GridTemplateColumn HeaderTooltip ="Asistio a la Programación ?" >
                                        <ItemTemplate >
                                            <asp:CheckBox ID="chb_asistio" runat="server" checked="False" AutoPostBack ="True" OnCheckedChanged ="chb_asistioChanged" />
                                        </ItemTemplate>
                                        <HeaderTemplate>
                                            <asp:Label runat="server" ID="lblasistiotodos" Text="Todos : "></asp:Label>
                                            <asp:CheckBox ID="chb_asistiotodos" runat="server" checked="False" AutoPostBack ="True" OnCheckedChanged ="chb_asistiotodosChanged"  />
                                        </HeaderTemplate>
                                        <HeaderStyle HorizontalAlign ="Center" />
                                    </telerik:GridTemplateColumn>

                                    <telerik:GridTemplateColumn HeaderText ="Programación" HeaderTooltip ="Programación de Segunda Entrega " >
                                        <ItemTemplate >
                                            <asp:DropDownList id="ddl_Programaslibres" runat="server" Visible ="false"  ></asp:DropDownList>
                                            <asp:label id="lbldobleprogramacion" runat="server" Visible ="false" ></asp:label>
                                        </ItemTemplate>
                                        <HeaderTemplate >
                                            <asp:DropDownList id="ddl_ProgramasTodosLibres" runat="server" CssClass="drop01" Width="100px" />
                                            <asp:Button runat="server" ID="btn_cargaratodos" OnClick ="CargaraTodosClick" Width ="26px" Text="OK" Font-Italic="True" Font-Size="XX-Small"/>
                                        </HeaderTemplate>

                                    </telerik:GridTemplateColumn>

                                    <telerik:GridTemplateColumn  HeaderTooltip ="Aprobar registro ?">
                                        <ItemTemplate >
                                            <asp:CheckBox ID="chb_aprobo" runat="server" checked="False" />
                                        </ItemTemplate>
                                        <HeaderTemplate >
                                            <asp:Label runat="server" ID="lblaprobotodos" Text="Aprobar : "></asp:Label>
                                            <asp:CheckBox ID="chb_aprobotodos" runat="server" checked="False" AutoPostBack ="True" OnCheckedChanged ="chb_aprobotodosChanged" />
                                        </HeaderTemplate>
                                        <HeaderStyle HorizontalAlign ="Center" />
                                        <ItemStyle HorizontalAlign ="Center" />
                                    </telerik:GridTemplateColumn>


                                </Columns>

                                <PagerStyle AlwaysVisible="True" FirstPageToolTip="Primera" 
                                    LastPageToolTip="Ultima" Mode="NumericPages" NextPagesToolTip="Próximas" 
                                    NextPageToolTip="Próxima" 
                                    PagerTextFormat="Cambiar Página: {4} &amp;nbsp;Página &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;, registros &lt;strong&gt;{2}&lt;/strong&gt; a &lt;strong&gt;{3}&lt;/strong&gt; de &lt;strong&gt;{5}&lt;/strong&gt;." 
                                    PrevPagesToolTip="Anteriores" PrevPageToolTip="Anterior" />
                            </MasterTableView>
                            <ExportSettings>
                                <Pdf PageWidth="">
                                </Pdf>
                            </ExportSettings>
                            <ClientSettings EnablePostBackOnRowClick="False" EnableRowHoverStyle="True">
                                <Selecting AllowRowSelect="True" />
                            </ClientSettings>

                            <SortingSettings SortedAscToolTip="Ordenar Ascendente" 
                                SortedDescToolTip="Ordenar Descendente" 
                                SortToolTip="Clic aqui para ordenar..." />
                            <PagerStyle Mode="NumericPages" />
                        </telerik:RadGrid>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="background-color: orange; width: 100%; height: 16px;">
                        <asp:Label ID="Label3" runat="server" Text="_" 
                            style="font-weight: 700; color: #000066"></asp:Label>
                    </td>

                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnGrabarTodo" runat="server" CssClass="Boton" TabIndex="3" 
                            Text="Validar, Cerrar Programación y Asignar Grupo .... Proceso Final !!" 
                            Width="400px" />
                    </td>
                </tr>

            </table>
            

            </asp:panel>

        </asp:Panel>
    </asp:Panel>


    </asp:Content>

