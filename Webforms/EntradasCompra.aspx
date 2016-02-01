<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="EntradasCompra.aspx.vb" Inherits="WebForms_EntradasCompra" %>
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
    <asp:ValidationSummary ID="ValidationSummaryASIG" runat="server" 
        ValidationGroup="ASIG" ForeColor="Red" style="text-align: left" />
    <asp:ValidationSummary ID="valSummaryPROD" runat="server" 
        ValidationGroup="PROD" ForeColor="Red" style="text-align: left" />
    <asp:ValidationSummary ID="ValidationSummaryFACT" runat="server" 
        BorderWidth="0px" ValidationGroup="FACT" ForeColor="Red" 
        style="text-align: left" />
    <asp:ValidationSummary ID="ValidationSummaryRET" runat="server" 
        BorderWidth="0px" ValidationGroup="RET" ForeColor="Red" 
        style="text-align: left" />
    <asp:ValidationSummary ID="ValidationSummaryOC" runat="server" 
        BorderWidth="0px" ValidationGroup="OC" ForeColor="Red" 
        style="text-align: left" />

      <asp:Panel runat="server" ID="pnl_principal" DefaultButton ="btnGuardar" Width ="100%">
        <table id="Table2" cellspacing="0" cellpadding="0" border="0" class="ContentTable" style="width: 100%">
            <tr valign="top">
            <td style="width: 75%; text-align: left;"> 
                <asp:Label ID="lbl_Titulo" runat="server" 
                    Text="CREACION / MODIFICACION DE ENTRADAS POR MERCANCIA" Width="90%" 
                    CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
                <asp:Label ID="lblMensaje" runat="server" CssClass="TitMensaje" Text="_" Width="90%" Visible="False"/>
            </td>
            <td style="width: 25%" align="right">
                <asp:ImageButton ID="btn_actualizar" runat="server" ImageUrl="~/Images/Reload.jpg" ToolTip="Actualizar la vista actual." TabIndex="5" />
                <asp:ImageButton ID="btn_nuevo" runat="server" ImageUrl="~/Images/Add.jpg" 
                    ToolTip="Crear Nuevo Registro." TabIndex="6" />
                <asp:ImageButton ID="btn_cerrar" runat="server" ImageUrl="~/Images/Stop.jpg" ToolTip="Cerrar - Volver a la vista anterior." TabIndex="7" />
                <asp:ImageButton ID="btn_home" runat="server" ImageUrl="~/Images/Home.jpg" ToolTip="Ir al Inicio." TabIndex="8" />&nbsp;</td>
            </tr>

            <tr valign="top">
                <td colspan="2">
                    <table id="Table4" class="EditControlsTable" cellspacing="0" cellpadding="0" border="0" width="100%">
                        <tr  valign="top">
                            <td class="LabelCell" colspan="6" style="background-color: orange;">
                                <asp:Label ID="Label2" runat="server" Font-Bold="True">DATOS DE LA FACTURA u ORDEN DE ENTRADA</asp:Label></td>
                        </tr>

                        <tr  valign="top">
                          <td  class="LabelCell" style="width: 17%">
                        <asp:Label id="lblProveedores" runat="server" Width="90%">Proveedor</asp:Label></td>
                            <td class="ControlCell" style="width: 17%; text-align: left;">
                                                                    <asp:dropdownlist id="ddlProveedores" runat="server" Font-Size="X-Small" Width="90%" ></asp:dropdownlist>
                            <asp:RegularExpressionValidator ID="rev_Proveedor" runat="server" ControlToValidate="ddlProveedores"
                                EnableClientScript="False" ErrorMessage="Falta Seleccionar Proveedor" ValidationExpression="^[1-9]+[0-9]*$"
                                ValidationGroup="FACT" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                            <td class="ControlCell" style="width: 17%">
                            <asp:Label ID="lblSubTablasRegionalId_Regional" runat="server" Width="90%">Regional</asp:Label></td>
                            <td class="ControlCell" style="width: 17%; text-align: left;">
                        <asp:dropdownlist id="ddl_Regional" runat="server" Font-Size="X-Small" Width="90%" AutoPostBack="True" >
                        </asp:dropdownlist>
                            <asp:RegularExpressionValidator ID="rev_Regional" runat="server" ControlToValidate="ddl_Regional"
                                EnableClientScript="False" ErrorMessage="Falta Seleccionar la Regional" ValidationExpression="^[1-9]+[0-9]*$"
                                ValidationGroup="FACT" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                            <td class="ControlCell" style="width: 17%">
                        <asp:Label id="lblFecha" runat="server" Width="90%">Fecha</asp:Label></td>
                            <td class="ControlCell" style="width: 17%; text-align: left;">
                                <telerik:RadDatePicker ID="rdpfecha" runat="server" 
                                    Culture="Spanish (Colombia)" MinDate="" Skin="WebBlue" TabIndex="1" 
                                    ToolTip="Seleccione Fecha ..." Width="95%">
                                    <Calendar Skin="WebBlue" UseColumnHeadersAsSelectors="False" 
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
                                    EnableClientScript="False" ErrorMessage="Falta Fecha de Compra" 
                                    ValidationGroup="FACT" ForeColor="Red">*</asp:RequiredFieldValidator></td>
                        </tr>
                                                            <tr  valign="top">
                                                                <td class="LabelCell" style="width: 17%">
                                <asp:Label ID="lblNumero_Factura_Proveedor" runat="server" Width="90%">No. Factura / Acta</asp:Label></td>
                                                                <td class="ControlCell" style="width: 17%; text-align: left;">
                                                                    <asp:TextBox id="txtNumero_Factura_Proveedor" runat = "server" Font-Size="X-Small" MaxLength="10" style="text-align: left"></asp:TextBox>      
                                <asp:RequiredFieldValidator ID="rfv_Factura" runat="server" ControlToValidate="txtNumero_Factura_Proveedor"
                                    ErrorMessage="Debe Digitar Número de Factura" ValidationGroup="FACT" ForeColor="Red">*</asp:RequiredFieldValidator></td>
                                                                <td class="ControlCell" style="width: 17%">
                        <asp:Label id="lblNumero_Entrada" runat="server" Width="90%">Número Entrada Interna</asp:Label></td>
                                                                <td class="ControlCell" style="width: 17%; text-align: left;">
                        <asp:TextBox id="txtNumero_Entrada" runat = "server" Font-Size="X-Small"  MaxLength ="10" style="text-align: center"></asp:TextBox>      
                                <asp:RequiredFieldValidator ID="rfv_NumeroEntrada" runat="server" ControlToValidate="txtNumero_Entrada"
                                    ErrorMessage="Debe Digitar Número de Entrada Interna" ValidationGroup="FACT" ForeColor="Red">*</asp:RequiredFieldValidator></td>
                                                                <td class="ControlCell" style="width: 17%">
                                <asp:Label ID="LblId" runat="server" Visible="False"></asp:Label></td>
                                                                <td class="ControlCell" style="width: 17%; text-align: left;">
                                                                    
                                                                </td>
                                                            </tr>
                        <tr  valign="top">
                            <td class="LabelCell" style="width: 17%">
                        <asp:Label id="lblUsuariosRecibio" runat="server" Width="90%">Recibido Por </asp:Label></td>
                            <td class="ControlCell" style="width: 17%; text-align: left;">
                                <asp:Label ID="lbl_Recibido" runat="server" Width="90%">Recibido Por </asp:Label>
                            </td>
                            <td class="ControlCell" style="width: 17%">
                        <asp:Label id="lblNombre_Entrego" runat="server" Width="90%">Nombre Entrego</asp:Label></td>
                            <td class="ControlCell" style="width: 17%; text-align: left;">
                        <asp:TextBox id="txtNombre_Entrego" runat = "server" Font-Size="X-Small" Width="90%"></asp:TextBox>      
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNombre_Entrego"
                                ErrorMessage="Debe Digitar nombre de quien entregó la mercancia" 
                                    ValidationGroup="FACT" ForeColor="Red">*</asp:RequiredFieldValidator></td>
                            <td class="ControlCell" style="width: 17%;">
                        <asp:Label id="lblIdentificacion_Entrego" runat="server" Width="90%">Identificación Entrego</asp:Label></td>
                                                                        <td class="ControlCell" 
                                style="width: 17%; text-align: left;">
                        <asp:TextBox id="txtIdentificacion_Entrego" runat = "server" Font-Size="X-Small" Width="90%" onkeypress="return ValNumero(this, event)"  MaxLength ="20" ></asp:TextBox></td>
                                                                    </tr>

                                <tr  valign="top"><td  class="LabelCell" style="width: 17%">
                                <asp:Label id="lblObservacion" runat="server" Width="90%">Observación</asp:Label></td>
                                    <td class="ControlCell" colspan="5" style="width: 60%; text-align: left;">
                                <asp:TextBox id="txtObservacion" runat = "server" Font-Size="X-Small" Width="94%" Rows="2" TextMode="MultiLine"></asp:TextBox></td></tr>
                         <tr style="background-color: #F7F7F7;" >
                            <td align="center" colspan="6">
                                <div>
                                    <asp:Panel ID="Panel1" runat="server" Width="100%" style="vertical-align: middle; text-align: center" >
                                    <table border="0" cellpadding="0" cellspacing="0" style="width: 90%">
                                        <tr valign="top">
                                            <td style="width: 15%; height: 16px;">
                                            </td>
                                            <td style="width: 15%; height: 16px;">
                                                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" cssClass="Boton" Width="100px" TabIndex="1"></asp:Button>
                                            </td>
                                            <td style="width: 16%; height: 16px;">
                                                <asp:Button ID="btnGuardarOtro" runat="server" Text="Guardar y agregar otro" cssClass="Boton" Width="150px" TabIndex="2"></asp:Button>
                                            </td>
                                            <td style="width: 15%; height: 16px;">
                                                <asp:Button ID="btnEliminar" runat="server" Text='Eliminar' CssClass="Boton" Width="100px" TabIndex="3"></asp:Button>
                                            </td>
                                            <td style="width: 15%; height: 16px;">
                                                &nbsp;</td>
                                            <td style="width: 15%; height: 16px;">
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                    
                                    </div>
                                 </td>
                                    <td style="width: 33%"></td>
                                </tr>
                            </table>
                                       
                            </td>
                        </tr>
                        <tr  valign="top"><td  class="LabelCell" style="background-color: orange;" colspan="6">
                            <asp:Label ID="Label3" runat="server" Font-Bold="True">PRODUCTOS DE LA FACTURA</asp:Label></td>
                        </tr>

                        <tr  valign="top">
                           <td  class="LabelCell" colspan="6" align="center" valign="middle">
                            
                            <asp:panel ID="pnl_producto" runat="Server" Width="100%" Visible="False" BackColor="NavajoWhite">
                              <table runat="server" id="tbl_ingreso" width="100%" style="border-right: lightslategray thin solid; border-top: lightslategray thin solid; border-left: lightslategray thin solid; border-bottom: lightslategray thin solid" border="0" cellpadding="0" cellspacing="0" >
                                <tr  valign="top">

                                    <td class="ControlCell" style="width: 25%; background-color: #ffffcc; height: 14px;" align="left">
                                    </td>
                                    <td class="ControlCell" style="width: 25%; background-color: lightsalmon; height: 14px;" align="center" colspan="2">
                                        <asp:Label ID="Label5" runat="server" Font-Bold="True">Ingreso / Modificación de Nuevo Producto</asp:Label></td>
                                    <td class="ControlCell" style="width: 25%; background-color: #ffffcc; height: 14px;" align="left">
                                        <asp:Label ID="lblIdProducto" runat="server" Visible="False"></asp:Label>
                                    </td>
                                </tr>
                                <tr  valign="top">

                                    <td class="ControlCell" style="width: 25%; background-color: #ffffcc;" align="left">
                                        <asp:Label ID="lblSubTablasProductoId_Producto" runat="server" Width="90%">Producto que se compró</asp:Label></td>
                                    <td class="ControlCell" style="width: 25%; background-color: #ffffcc;" align="left">
                                        <asp:dropdownlist ID="ddl_Productos" runat="server" Font-Size="X-Small"
                                            Width="90%" AutoPostBack="True">
                                        </asp:dropdownlist>
                                        <asp:RegularExpressionValidator ID="rev_Productos" runat="server" ControlToValidate="ddl_Productos"
                                            EnableClientScript="False" ErrorMessage="Falta Dato de Producto" ValidationExpression="^[1-9]+[0-9]*$"
                                            ValidationGroup="PROD" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                                    <td class="ControlCell" style="width: 25%; background-color: #ffffcc;" align="left">
                                        &nbsp;</td>
                                    <td class="ControlCell" style="width: 25%; background-color: #ffffcc;" align="left">
                                        &nbsp;</td>
                                </tr>
                                <tr  valign="top">

                                    <td class="ControlCell" style="width: 25%; background-color: #ffffcc;" align="left">
                                        <asp:Label ID="lblCantidad" runat="server" Width="90%">Cantidad</asp:Label></td>
                                    <td class="ControlCell" style="width: 25%; background-color: #ffffcc;" align="left">
                                        <asp:TextBox ID="txtCantidad" runat="server" Font-Size="X-Small" style="text-align: right" MaxLength="10" onkeypress="return ValNumero(this, event)"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfv_Cantidad" runat="server" ControlToValidate="txtCantidad"
                                            ErrorMessage="Debe Digitar Cantidad" ValidationGroup="PROD" 
                                            ForeColor="Red">*</asp:RequiredFieldValidator></td>
                                    <td class="ControlCell" style="width: 25%; background-color: #ffffcc;" align="left">
                                        <asp:Label ID="Label10" runat="server" Width="90%">Fecha de Vencimiento</asp:Label></td>
                                    <td class="ControlCell" style="width: 25%; background-color: #ffffcc;" align="left">
                                        <telerik:RadDatePicker ID="rdpfecha_Vencimiento" runat="server" 
                                            Culture="Spanish (Colombia)" MinDate="" Skin="WebBlue" TabIndex="1" 
                                            ToolTip="Seleccione Fecha ..." Width="95%">
                                            <Calendar Skin="WebBlue" UseColumnHeadersAsSelectors="False" 
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
                                        <asp:RequiredFieldValidator ID="rfv_Fecha0" runat="server" 
                                            ControlToValidate="rdpfecha_Vencimiento" EnableClientScript="False" 
                                            ErrorMessage="Falta Fecha de Vencimiento" ForeColor="Red" 
                                            ValidationGroup="PROD">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>                
                                  <tr  valign="top">
                                      <td class="ControlCell" style="width: 25%; background-color: #ffffcc; height: 21px;" align="left">
                                        <asp:Label ID="lblValor_Unitario" runat="server" Width="90%">Valor Unitario</asp:Label></td>
                                      <td class="ControlCell" style="width: 25%; background-color: #ffffcc; height: 21px;" align="left">
                                        <asp:TextBox ID="txtValor_Unitario" runat="server" onkeypress="return ValNumero(this, event)"  MaxLength ="10" Font-Size="X-Small" style="text-align: right"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfv_ValorUnitario" runat="server" ControlToValidate="txtValor_Unitario"
                                            ErrorMessage="Debe Digitar Valor Unitario" ValidationGroup="PROD" 
                                              ForeColor="Red">*</asp:RequiredFieldValidator></td>
                                      <td class="ControlCell" style="width: 25%; background-color: #ffffcc; height: 21px;" align="left">
                                          <asp:Label ID="lblSubTablasCapacidadId_Capacidad" runat="server" Width="90%">Capacidad / Unidad de Medida</asp:Label>
                                      </td>
                                      <td class="ControlCell" style="width: 25%; background-color: #ffffcc; height: 21px;" align="left">
                                          <asp:DropDownList ID="ddl_capacidad" runat="server" Font-Size="X-Small" 
                                              Width="90%">
                                          </asp:DropDownList>
                                          <asp:RegularExpressionValidator ID="rev_Capacidad" runat="server" 
                                              ControlToValidate="ddl_capacidad" EnableClientScript="False" 
                                              ErrorMessage="Falta Dato de Unidad de Medida" ForeColor="Red" 
                                              ValidationExpression="^[1-9]+[0-9]*$" ValidationGroup="PROD">*</asp:RegularExpressionValidator>
                                      </td>
                                  </tr>
                                  <tr  valign="top">
                                      <td class="ControlCell" colspan="2" style="background-color: #ffcc66; height: 14px;">
                                          <asp:Label ID="Label11" runat="server" Font-Bold="True">DISTRIBUCION DEL PRODUCTO EN LAS BODEGAS</asp:Label></td>
                                      <td class="ControlCell" colspan="2" style="background-color: gold; height: 14px;">
                                          <asp:Label ID="Label7" runat="server" Font-Bold="True">ASIGNACION A ORDENES DE COMPRA</asp:Label></td>
                                  </tr>
                                  <tr  valign="top">
                                      <td class="ControlCell" colspan="2"  valign="top" style="background-color: #ffffcc" align="center">
                                         <table border="0" cellpadding="0" cellspacing="0" id="dist_bodegas">
                                           <tr>
                                             <td colspan="2" rowspan="5" align="left" valign="top">
                                               <asp:DataGrid ID="dgAsignacion" runat="server" AllowPaging="True"
                                                        AutoGenerateColumns="False" CellPadding="2" ForeColor="Black" GridLines="None"
                                                        OnItemCommand="subCommandItemAsignacion" OnPageIndexChanged="CambioPaginaAsignacion" Width="96%" PageSize="3" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px">
                                                      <FooterStyle BackColor="Tan" CssClass="DataGridFooterStyle" />
                                                      <EditItemStyle CssClass="DataGridEditItemStyle" />
                                                      <SelectedItemStyle BackColor="DarkSlateBlue" CssClass="DataGridSelectedItemStyle"
                                                ForeColor="GhostWhite" />
                                                      <PagerStyle BackColor="PaleGoldenrod" CssClass="PagerStyle" ForeColor="DarkSlateBlue" HorizontalAlign="Center"
                                                Mode="NumericPages" />
                                                      <AlternatingItemStyle BackColor="PaleGoldenrod" CssClass="DataGridAlternatingItemStyle" />
                                                      <ItemStyle CssClass="DataGridItemStyle" />
                                                      <Columns>
                                                          <asp:TemplateColumn HeaderText="No." >
                                                              <ItemTemplate>
                                                                  <%# ctype(CType(Container.Parent.Parent,DataGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>
                                                              </ItemTemplate>
                                                          </asp:TemplateColumn>
                                                          <asp:TemplateColumn HeaderText ="Cod." Visible="False">
                                                              <ItemTemplate>
                                                                  <asp:Label ID="lblId" runat="server" Text='<%# Container.DataItem.ID %>'></asp:Label>
                                                              </ItemTemplate>
                                                              <ItemStyle HorizontalAlign ="Center" />
                                                          </asp:TemplateColumn>
                                                          <asp:TemplateColumn HeaderText="Bodega" SortExpression="Bodegas.Descripcion">
                                                              <ItemTemplate>
                                                                  <%#Container.DataItem.Bodegas.Descripcion%>
                                                              </ItemTemplate>
                                                              <ItemStyle Width="100px" />
                                                              <HeaderStyle Width ="100px" />
                                                          </asp:TemplateColumn>
                                                          <asp:TemplateColumn HeaderText="Cantidad" SortExpression="Cantidad">
                                                              <ItemTemplate>
                                                                  <%# String.Format("{0:n1}",Container.DataItem.Cantidad)%>
                                                              </ItemTemplate>
                                                              <ItemStyle HorizontalAlign ="Right"  Width ="80px"/>
                                                              <HeaderStyle HorizontalAlign ="Right" Width ="80px" />
                                                          </asp:TemplateColumn>
                                                          <asp:EditCommandColumn EditText="Abrir" HeaderImageUrl ="~/Images/Edit1.gif" >
                                                              <HeaderStyle Width="50px" />
                                                              <ItemStyle Width="50px" HorizontalAlign ="Right" />
                                                          </asp:EditCommandColumn>
                                                          <asp:TemplateColumn>
                                                              <ItemTemplate>
                                                                  <asp:ImageButton runat="server" ID="btneliminarasig" CommandName ="EliminarAsignacion"  ImageUrl ="~/Images/delete.gif" ToolTip ="Eliminar Asignación" />
                                                              </ItemTemplate>
                                                              <HeaderStyle HorizontalAlign ="Center" Width="10px" />
                                                              <ItemStyle HorizontalAlign ="Center" Width="10px" />
                                                          </asp:TemplateColumn>
                                                      </Columns>
                                                      <HeaderStyle BackColor="Tan" CssClass="DataGridHeaderStyle" Font-Bold="True" />
                                                  </asp:DataGrid>
                                             </td>
                                             
                                      <td class="ControlCell" colspan="2" style="background-color: lemonchiffon" align="center">
                                          <asp:Label ID="Label15" runat="server" Font-Bold="True">ASIGNACION A BODEGA</asp:Label></td>
                                  </tr>
                                  <tr  valign="top">
                                      <td class="ControlCell" style="width: 15%" align="left">
                                          <asp:Label ID="Label12" runat="server" Width="90%">Bodega</asp:Label></td>
                                      <td class="ControlCell" style="width: 35%" align="left">
                                          <asp:dropdownlist ID="ddl_bodegas" runat="server" Font-Size="X-Small"
                                            Width="90%">
                                          </asp:dropdownlist>
                                          <asp:RequiredFieldValidator ID="rfv_Bodegas" runat="server" ControlToValidate="ddl_bodegas"
                                              ErrorMessage="Debe Seleccionar Bodega" ValidationGroup="ASIG" 
                                              ForeColor="Red">*</asp:RequiredFieldValidator>
                                          <asp:RegularExpressionValidator ID="rev_Bodegas" runat="server" ControlToValidate="ddl_bodegas"
                                              EnableClientScript="False" ErrorMessage="Falta Dato de Bodega" ValidationExpression="^[1-9]+[0-9]*$"
                                              ValidationGroup="ASIG" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                                  </tr>
                                  <tr  valign="top">
                                      <td class="ControlCell" style="width: 15%" align="left">
                                          <asp:Label ID="Label13" runat="server" Width="90%">Cantidad</asp:Label></td>
                                      <td class="ControlCell" style="width: 35%" align="left">
                                          <asp:TextBox ID="txt_cantidadbodega" runat="server" Font-Size="X-Small" style="text-align: right" onkeypress="return ValNumero(this, event)"  MaxLength="10" ></asp:TextBox>
                                          <asp:RequiredFieldValidator ID="rfv_CantidadBodega" runat="server" ControlToValidate="txt_cantidadbodega"
                                              ErrorMessage="Debe Digitar Cantidad" ValidationGroup="ASIG" 
                                              ForeColor="Red">*</asp:RequiredFieldValidator></td>
                                  </tr>
                                  <tr  valign="top">
                                      <td class="ControlCell" style="width: 15%" align="left">
                                          <asp:Label ID="Label14" runat="server" Width="90%">Observación</asp:Label></td>
                                      <td class="ControlCell" style="width: 35%" align="left">
                                          <asp:TextBox ID="txt_observacionbodega" runat="server" Font-Size="X-Small" Rows="1"
                                              Width="90%" MaxLength="200"></asp:TextBox></td>
                                  </tr>
                                  <tr  valign="top">
                                      <td class="ControlCell" colspan="2" style="background-color: lemonchiffon; width: 50%;" align="center" id="pnl_asignar">
                                          <div style="width: 100%">
                                              <asp:Button ID="Btn_GuardarAsignacion" runat="server" CssClass="Boton" 
                                                  Text="Guardar" />
                                              <asp:Button ID="btn_nuevaasignacion" runat="server" CssClass="Boton" Text="Nueva Asignación" />
                                              <asp:Label ID="lblIdAsignacion" runat="server" Visible="False"></asp:Label>
                                              </div>
                                                                                 
                                             </td>
                                             
                                           </tr>
                                         </table>
                                      </td>
                                      <td class="ControlCell" colspan="2"  valign="top" style="background-color: #ffffcc" align="left">
                                         <asp:Panel ID="panel_OC" runat="server" Width="100%">
                                         <table border="0" cellpadding="0" cellspacing="0" id="Table_Oc" style="width: 100%">
                                           <tr>
                                             <td colspan="2" rowspan="5" align="left" valign="top">
                                               <asp:DataGrid ID="dg_OrdenesCompra" runat="server" AllowPaging="True"
                                                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None"
                                                    OnItemCommand="subCommandItemOC" OnPageIndexChanged="CambioPaginaOC" Width="96%" PageSize="3">
                                                      <FooterStyle BackColor="#1C5E55" CssClass="DataGridFooterStyle" Font-Bold="True" ForeColor="White" />
                                                      <EditItemStyle CssClass="DataGridEditItemStyle" BackColor="#7C6F57" />
                                                      <SelectedItemStyle BackColor="#C5BBAF" CssClass="DataGridSelectedItemStyle"
                                                ForeColor="#333333" Font-Bold="True" />
                                                      <PagerStyle BackColor="#666666" CssClass="PagerStyle" ForeColor="White" HorizontalAlign="Center"
                                                Mode="NumericPages" />
                                                      <AlternatingItemStyle BackColor="White" CssClass="DataGridAlternatingItemStyle" />
                                                      <ItemStyle CssClass="DataGridItemStyle" BackColor="#E3EAEB" />
                                                      <Columns>
                                                          <asp:TemplateColumn HeaderText="No." >
                                                              <ItemTemplate>
                                                                  <%# ctype(CType(Container.Parent.Parent,DataGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>
                                                              </ItemTemplate>
                                                          </asp:TemplateColumn>
                                                          <asp:TemplateColumn HeaderText ="Cod." Visible="False">
                                                              <ItemTemplate>
                                                                  <asp:Label ID="lblId" runat="server" Text='<%# Container.DataItem.ID %>'></asp:Label>
                                                              </ItemTemplate>
                                                              <ItemStyle HorizontalAlign ="Center" />
                                                          </asp:TemplateColumn>
                                                          <asp:TemplateColumn HeaderText="O.C." SortExpression="OrdenCompra_Detalle.OrdenCompra.Numero">
                                                              <ItemTemplate>
                                                                  <%#Container.DataItem.OrdenCompra_Detalle.OrdenCompra.Numero%>
                                                              </ItemTemplate>
                                                              <ItemStyle Width="100px" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" />
                                                              <HeaderStyle Width ="100px" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" />
                                                          </asp:TemplateColumn>
                                                          <asp:TemplateColumn HeaderText="Cantidad" SortExpression="Cantidad">
                                                              <ItemTemplate>
                                                                  <%# String.Format("{0:n1}",Container.DataItem.Cantidad)%>
                                                              </ItemTemplate>
                                                              <ItemStyle HorizontalAlign ="Right"  Width="80px"/>
                                                              <HeaderStyle HorizontalAlign ="Right"   Width="80px" />
                                                          </asp:TemplateColumn>
                                                          <asp:EditCommandColumn EditText="Abrir" HeaderImageUrl ="~/Images/Edit1.gif" >
                                                              <HeaderStyle Width="50px" />
                                                              <ItemStyle Width="50px" HorizontalAlign ="Right" />
                                                          </asp:EditCommandColumn>
                                                          <asp:TemplateColumn>
                                                              <ItemTemplate>
                                                                  <asp:ImageButton runat="server" ID="btneliminarasig" CommandName ="Eliminar"  ImageUrl ="~/Images/delete.gif" ToolTip ="Eliminar Orden de Compra" />
                                                              </ItemTemplate>
                                                              <HeaderStyle HorizontalAlign ="Center" Width="10px" />
                                                              <ItemStyle HorizontalAlign ="Center" Width="10px" />
                                                          </asp:TemplateColumn>
                                                      </Columns>
                                                      <HeaderStyle BackColor="#1C5E55" CssClass="DataGridHeaderStyle" Font-Bold="True" ForeColor="White" />
                                                  </asp:DataGrid>
                                             </td>
                                             
                                      <td class="ControlCell" colspan="2" style="background-color: lemonchiffon" align="center">
                                          <asp:Label ID="Label8" runat="server" Font-Bold="True">SELECCIONE LA ORDEN DE COMPRA</asp:Label></td>
                                  </tr>
                                  <tr  valign="top">
                                      <td class="ControlCell" style="width: 15%" align="left">
                                          <asp:Label ID="Label9" runat="server" Width="90%">O.C.</asp:Label></td>
                                      <td class="ControlCell" style="width: 35%" align="left">
                                          <asp:dropdownlist ID="ddl_OrdenCompra" runat="server" Font-Size="X-Small"
                                            Width="90%">
                                          </asp:dropdownlist>
                                          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddl_OrdenCompra"
                                              ErrorMessage="Debe Seleccionar Orden de Compra" ValidationGroup="OC" 
                                              ForeColor="Red">*</asp:RequiredFieldValidator>
                                          <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="ddl_OrdenCompra"
                                              EnableClientScript="False" ErrorMessage="Falta Dato de Orden de Compra" ValidationExpression="^[1-9]+[0-9]*$"
                                              ValidationGroup="OC" ForeColor="Red">*</asp:RegularExpressionValidator></td>
                                  </tr>
                                  <tr  valign="top">
                                      <td class="ControlCell" style="width: 15%" align="left">
                                          <asp:Label ID="Label19" runat="server" Width="90%">Cantidad</asp:Label></td>
                                      <td class="ControlCell" style="width: 35%" align="left">
                                          <asp:TextBox ID="txt_cantidadOC" runat="server" Font-Size="X-Small" style="text-align: right" onkeypress="return ValNumero(this, event)"  MaxLength="10" ></asp:TextBox>
                                          <asp:RequiredFieldValidator ID="rfv_cantidadoc" runat="server" ControlToValidate="txt_cantidadOC"
                                              ErrorMessage="Debe Digitar Cantidad" ValidationGroup="OC" ForeColor="Red">*</asp:RequiredFieldValidator></td>
                                  </tr>
                                  <tr  valign="top">
                                      <td class="ControlCell" style="width: 15%" align="left">
                                          <asp:Label ID="lbl_CantidadAntesEditar" runat="server" Visible="False" Width="1%"></asp:Label>
                                          </td>
                                      <td class="ControlCell" style="width: 35%" align="left">
                                          </td>
                                  </tr>
                                  <tr  valign="top">
                                      <td class="ControlCell" colspan="2" style="background-color: lemonchiffon; width: 50%;" align="center" id="Td1">
                                          <div style="width: 100%">
                                              <asp:Button ID="btn_GuardarOC" runat="server" CssClass="Boton" Text="Guardar" />
                                              <asp:Button ID="btn_Nuevaorden" runat="server" CssClass="Boton" Text="Nueva Orden " />
                                              <asp:Label ID="lbl_IdOC" runat="server" Visible="False"></asp:Label>
                                              </div>
                                                                                 
                                             </td>
                                             
                                           </tr>
                                         </table>
                                         </asp:Panel>
                                      </td>
                                  </tr>
                                  <tr  valign="top">
                                      <td class="ControlCell" colspan="4" style="background-color: #ffcc66">
                                      </td>
                                  </tr>
                                  <tr  valign="top">
                                      <td class="ControlCell" colspan="4" align="center">
                                        <div>
                                            <asp:Button ID="Button1" runat="server" Text="Guardar Producto" cssClass="Boton"></asp:Button>&nbsp;<asp:Button ID="btn_limpiar" runat="server" Text="Limpiar" cssClass="Boton"></asp:Button></div>
                                      </td>
                                  </tr>
                              </table>      
                            </asp:panel>
                        </td>
                        </tr>

                        <tr  valign="top"><td  class="LabelCell" colspan="6" align="right">
				                <telerik:RadGrid ID="Rg_Listado" runat="server" AllowSorting="True" GridLines="None" Skin="WebBlue" Width="100%"  OnItemCommand="subCommandItem"
                                    AutoGenerateColumns="False" ShowStatusBar="True" TabIndex="6" PageSize="20" CellSpacing="0">
                                    <MasterTableView  NoDetailRecordsText="No hay informaci&#243;n." 
                                        NoMasterRecordsText="No hay informaci&#243;n." DataKeyNames="Id" CommandItemDisplay ="Top" ShowFooter="True">
                                        <Columns>
                                           <telerik:GridTemplateColumn HeaderText="No." DefaultInsertValue="" UniqueName="TemplateColumn">
                                                <ItemTemplate>
                                                    <asp:label runat="server" id="lblno" text='<%# ctype(CType(Container.Parent.Parent.Parent,RadGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>' />
                                                    <asp:Label runat="Server" Id="lblid" Visible ="False" Text ='<%#Container.DataItem.Id%>'/>
                                                </ItemTemplate>
                                            </telerik:GridTemplateColumn>                                
                        
                                            <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" HeaderText="Id" 
                                                SortExpression="Id" UniqueName="Id"  Visible ="True" >
                                            </telerik:GridBoundColumn>

                          
						                    <telerik:GridBoundColumn DataField="Producto.Descripcion" HeaderText="Producto"
                                                SortExpression="Producto.Descripcion" UniqueName="Producto.Descripcion" >
                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                            </telerik:GridBoundColumn>   
 						                    <telerik:GridBoundColumn DataField="Capacidad.Descripcion" HeaderText="Unidad"
                                                SortExpression="Capacidad.Descripcion" UniqueName="Capacidad.Descripcion" >
                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                            </telerik:GridBoundColumn> 
                                    
						                    <telerik:GridBoundColumn DataField="Cantidad" HeaderText="Cantidad" Aggregate="Sum" FooterAggregateFormatString ="{0:n0}"
                                                SortExpression="Cantidad" UniqueName="Cantidad" DataFormatString ="{0:n0}" >
                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                <ItemStyle HorizontalAlign ="Right" />
                                                <FooterStyle  HorizontalAlign ="Right" />
                                            </telerik:GridBoundColumn> 
                                    
						                    <telerik:GridBoundColumn DataField="Valor_Unitario" HeaderText="Valor Unitario" 
                                                SortExpression="Valor_Unitario" UniqueName="Valor_Unitario" DataFormatString ="{0:n1}" >
                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                <ItemStyle HorizontalAlign ="Right" />
                                                
                                            </telerik:GridBoundColumn> 

						                    <telerik:GridBoundColumn DataField="ValorProducto" HeaderText="Total" Aggregate="Sum" FooterAggregateFormatString ="{0:n1}"
                                                SortExpression="ValorProducto" UniqueName="ValorProducto" DataFormatString ="{0:n1}" >
                                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                    Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                <ItemStyle HorizontalAlign ="Right" />
                                                <FooterStyle  HorizontalAlign ="Right" />

                                            </telerik:GridBoundColumn> 

                                            <telerik:GridButtonColumn ConfirmText="Desea eliminar este registro?" ConfirmDialogType ="Classic"   HeaderTooltip = "Eliminar Producto del Ajuste " HeaderText ="X"
                                                ConfirmTitle="Borrar Item de Ajuste de Entrada."  CommandName="EliminarProducto" UniqueName="Borrar" ButtonType="ImageButton" ImageUrl="../Images/balde.gif">
                                                <ItemStyle Width="10px" HorizontalAlign ="Center" />
                                                <HeaderStyle HorizontalAlign ="Center"  />
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
                                    <ClientSettings EnablePostBackOnRowClick="True" EnableRowHoverStyle ="True"  >
                                        <Selecting AllowRowSelect ="True"   />
                                    </ClientSettings>
                    
                                     <ExportSettings
                                       HideStructureColumns="True" filename ="DetalleEntradasCompra" ExportOnlyData="True" IgnorePaging="True" OpenInNewWindow="True">
                                         <Pdf PageWidth=""  AllowPrinting="true">
                                         </Pdf>
                                    </ExportSettings>
                                    <SortingSettings SortToolTip="Clic aqui para ordenar..."  SortedAscToolTip ="Ordenar Ascendente" SortedDescToolTip ="Ordenar Descendente" />
                                    <PagerStyle Mode="NumericPages" AlwaysVisible="True"    />
                
                                </telerik:RadGrid>
                            <div runat="server" id="divnuevo" align="center" >
                            <asp:Button ID="Btn_Nuevo_Producto" runat="server" CssClass="Boton" 
                                    Text="Nuevo Producto" />
                            </div>
                            </td>
                        </tr>

                        <tr  valign="top"><td  class="LabelCell" style="background-color: #ff6633; text-align: center;" colspan="6">
                            <asp:Label ID="Label4" runat="server" Font-Bold="True">FIN DE LA ORDEN DE COMPRA</asp:Label></td>
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
            <telerik:AjaxSetting AjaxControlID="btnGuardar">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ValidationSummaryFACT" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="lblMensaje" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddlProveedores" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_Regional" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rdpfecha" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rfv_Fecha" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txtNumero_Factura_Proveedor" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txtNumero_Entrada" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="LblId" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddlUsuarios" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txtNombre_Entrego" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txtIdentificacion_Entrego" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txtObservacion" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="pnl_producto" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Rg_Listado" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnGuardarOtro">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ValidationSummaryFACT" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="lblMensaje" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddlProveedores" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_Regional" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rdpfecha" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txtNumero_Factura_Proveedor" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txtNumero_Entrada" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="LblId" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddlUsuarios" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txtNombre_Entrego" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txtIdentificacion_Entrego" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txtObservacion" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="pnl_producto" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnEliminar">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="lblMensaje" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="dgAsignacion">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="dgAsignacion" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_bodegas" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_cantidadbodega" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_observacionbodega" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="lblIdAsignacion" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Btn_GuardarAsignacion">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="dgAsignacion" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddl_bodegas" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_cantidadbodega" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_observacionbodega" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="lblIdAsignacion" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btn_nuevaasignacion">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ddl_bodegas" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_cantidadbodega" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="txt_observacionbodega" />
                    <telerik:AjaxUpdatedControl ControlID="lblIdAsignacion" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btn_GuardarOC">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ValidationSummaryOC" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="lblMensaje" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="panel_OC" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btn_Nuevaorden">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="panel_OC" 
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Button1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="valSummaryPROD" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="lblMensaje" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="pnl_producto" 
                        UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="Rg_Listado" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btn_limpiar">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="pnl_producto" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Rg_Listado">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="pnl_producto" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Btn_Nuevo_Producto">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="pnl_producto" />
                    <telerik:AjaxUpdatedControl ControlID="divnuevo" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>  
</asp:Content>

