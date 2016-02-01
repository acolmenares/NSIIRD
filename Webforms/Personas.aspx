<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="Personas.aspx.vb" Inherits="WebForms_Personas" %>
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


    <asp:Panel runat="server" ID="pnl_principal" DefaultButton="btn_actualizar" Width="1000px">

            <asp:ValidationSummary ID="Contacto" runat="server" 
                EnableClientScript="False" ForeColor="Red" style="text-align: left" 
                ValidationGroup="PROGRAMADOVULNERABLE" />
            <table id="Table2" cellspacing="0" cellpadding="0" border="0" class="ContentTable"
                style="width: 100%">
                <tr valign="top">
                    <td style="width: 75%; text-align: left;">
                        <asp:Label ID="lbl_Titulo" runat="server" Text="MANEJO GENERAL DE CONTACTOS DEL DECLARANTE"
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
                        <table id="tblContenido" class="EditControlsTable" cellspacing="0" 
                            cellpadding="0" border="0" width="100%">

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
                                <td class="LabelCell" colspan="6" rowspan="1" style="background-color: orange; width: 100%;">
                                    <asp:Label ID="Label33" runat="server" Font-Bold="True" Width="42%">Beneficiarios de la Familia</asp:Label>&nbsp;
                                </td>
                            </tr>
                            <tr valign="top">
                                <td class="LabelCell" colspan="6" 
                                    style="background-color: orange; width: 100%;">
                                    <telerik:RadGrid ID="Rg_Listado" runat="server" AllowSorting="True" AutoGenerateColumns="False" PageSize="20" 
                                        ShowStatusBar="True" Skin="WebBlue" TabIndex="6" Width="100%" ResolvedRenderMode="Classic">
                                        <MasterTableView AllowPaging="True"  DataKeyNames="Id" NoDetailRecordsText="No hay información." NoMasterRecordsText="No hay información." CommandItemDisplay ="None">
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

                                                <telerik:GridBoundColumn DataField="GeneroPersona" HeaderText="Genero"
                                                    SortExpression="GeneroPersona" UniqueName="GeneroPersona" >
                                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                </telerik:GridBoundColumn>

                                                <telerik:GridBoundColumn DataField="Edad" HeaderText="Edad"
                                                    SortExpression="Edad" UniqueName="Edad" >
                                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                </telerik:GridBoundColumn>

                                                <telerik:GridBoundColumn DataField="Fecha_Nacimiento" DataType="System.DateTime" HeaderText="Fecha Nacimiento"
                                                    DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_Nacimiento" UniqueName="Fecha_Nacimiento">
                                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                                </telerik:GridBoundColumn>

                                                <telerik:GridBoundColumn DataField="ParentescoPersona" HeaderText="Parentesco"
                                                    SortExpression="ParentescoPersona" UniqueName="ParentescoPersona" >
                                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
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
                                <td class="LabelCell" colspan="6" style="background-color: orange; width: 100%;">
                                    <asp:Label ID="Label41" runat="server" Width="22%" Font-Bold="True">Datos de Contacto Primarios</asp:Label>
                                </td>
                            </tr>
                            <tr valign="top">
                                <td class="LabelCell" colspan="6" style="background-color: orange; width: 100%;">
                                    <Table id="tbl_principales" runat="server" width ="100%">
                                        <tr valign="top">
                                            <td style="width: 15%; background-color: #FFFFFF;" >
                                        
                                                <asp:Label ID="Label76" runat="server" Width="100%">Celular :</asp:Label>
                                        
                                            </td>
                                            <td style="width: 25%; background-color: #FFFFFF;" >
                                        
                                                <asp:DropDownList ID="ddl_celular" runat="server" Width="100%" 
                                                    CssClass="drop01">
                                                </asp:DropDownList>
                                        
                                            </td>
                                            <td style="width: 15%; background-color: #FFFFFF;" >
                                        
                                                <asp:Label ID="Label78" runat="server" Width="100%">Dirección</asp:Label>
                                        
                                            </td>
                                            <td style="width: 40%; background-color: #FFFFFF;" >
                                        
                                                <asp:DropDownList ID="ddl_direccion" runat="server" CssClass="drop01" 
                                                    Width="100%">
                                                </asp:DropDownList>
                                        
                                            </td>
                                            <td style="width: 5%; background-color: #FFFFFF;" >
                                        
                                                <asp:Button ID="btn_refrescar" runat="server" CssClass="Boton" 
                                                    Height="30px" Text="R" Width="30px" ToolTip="Refrescar Información" />
                                        
                                            </td>

                                        </tr>
                                        <tr valign="top">
                                            <td style="background-color: #FFFFFF;" >
                                        
                                                <asp:Label ID="Label77" runat="server" Width="100%">Telefono :</asp:Label>
                                        
                                            </td>
                                            <td style="background-color: #FFFFFF;" >
                                        
                                                <asp:DropDownList ID="ddl_telefono" runat="server" CssClass="drop01" 
                                                    Width="100%">
                                                </asp:DropDownList>
                                        
                                            </td>
                                            <td style="background-color: #FFFFFF;" >
                                        
                                                <asp:Label ID="Label79" runat="server" Width="100%">Barrio</asp:Label>
                                        
                                            </td>
                                            <td style="background-color: #FFFFFF;" >
                                        
                                                <asp:DropDownList ID="ddl_barrio" runat="server" CssClass="drop01" Width="100%">
                                                </asp:DropDownList>
                                        
                                            </td>
                                            <td style="background-color: #FFFFFF;" >
                                        
                                                <asp:Button ID="btn_Grabar" runat="server" CssClass="Boton" 
                                                    Height="30px" Text="G" Width="30px" 
                                                    ToolTip="Guardar los Principales Contactos" />
                                        
                                            </td>

                                        </tr>                                
                                    </Table>


                                </td>
                            </tr>



                            <tr valign="top">
                                <td align="center" class="LabelCell" colspan="6" 
                                    style="background-color: orange; width: 50%;">
                                    <asp:Label ID="Label66" runat="server" Font-Bold="True" Width="100%">Información General de los Contactos</asp:Label>
                                </td>
                            </tr>
                            <tr valign="top">
                                <td class="LabelCell" colspan="6" rowspan="1" style="background-color: khaki; width: 50%;"                               >

                                    <telerik:RadTabStrip ID="rts_estados" runat="server" 
                                        MultiPageID="RadMultiPage1" SelectedIndex="0" Skin="Telerik" 
                                        ResolvedRenderMode="Classic">
                                        <Tabs>
                                            <telerik:RadTab runat="server" Text="Celular" 
                                                SelectedIndex="0" Owner="rts_estados" Selected="True" PageViewID="1">
                                            </telerik:RadTab>
                                            <telerik:RadTab runat="server" Text="Teléfono" SelectedIndex="1" 
                                                Owner="rts_estados" PageViewID="2">
                                            </telerik:RadTab>
                                            <telerik:RadTab runat="server" Text="Dirección" SelectedIndex="2" 
                                                Owner="rts_estados" PageViewID="3">
                                            </telerik:RadTab>
                                            <telerik:RadTab runat="server" Text="Barrio" SelectedIndex="3" PageViewID="4">
                                            </telerik:RadTab>
                                        </Tabs>
                                    </telerik:RadTabStrip>
                                    <telerik:RadMultiPage ID="RadMultiPage1" runat="server" Width="100%" SelectedIndex="0">
                                        <telerik:RadPageView ID="RadPageView1" runat="server" Selected="True" >
                                            <telerik:RadGrid ID="Rg_Celulares" runat="server" AutoGenerateColumns="False" 
                                                PageSize="20" Skin="WebBlue" TabIndex="6" Width="100%"  
                                                OnItemCommand ="subCommandItemCelular"  ResolvedRenderMode="Classic">
                                                <MasterTableView   DataKeyNames="ID" 
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
                                                            <ItemStyle Width="30px" />
                                                        </telerik:GridTemplateColumn>
                                                        <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" Display="False" 
                                                            HeaderText="Id" ReadOnly="True" SortExpression="Id" UniqueName="Id">
                                                            <ItemStyle Width="30px" />
                                                        </telerik:GridBoundColumn>

                                                        <telerik:GridTemplateColumn DefaultInsertValue="" HeaderText="Número de Celular y Descripcion (si aplica)" 
                                                            UniqueName="TemplateColumn">
                                                            <ItemTemplate>
                                                                <asp:TextBox runat="server" ID="txt_celular" Width ="400px" Text ='<%#Container.DataItem.Descripcion%>' Enabled="False"  ></asp:TextBox>
                                                            </ItemTemplate>
                                                            <ItemStyle Width="500px" />
                                                        </telerik:GridTemplateColumn>

                                                        <telerik:GridTemplateColumn DefaultInsertValue="" HeaderText="Principal" 
                                                            UniqueName="TemplateColumn">
                                                            <ItemTemplate>
                                                                <asp:CheckBox runat="server" ID="chb_principal" Width ="20px"  Checked  ='<%#Container.DataItem.Activo%>' Enabled ="False" />
                                                            </ItemTemplate>
                                                            <ItemStyle Width="50px" />
                                                            <HeaderStyle Width="50px"  />
                                                        </telerik:GridTemplateColumn>

                                                        
                                                        <telerik:GridTemplateColumn DefaultInsertValue="" HeaderText="Opciones" UniqueName="ColumnaOpciones" >
                                                            <ItemTemplate>
                                                                <asp:ImageButton runat="server" ID="btn_aceptar" ImageUrl ="~/Images/aceptar.png" CommandName ="GrabarCelular" ToolTip ="Grabar el Ajuste" visible ="false" />
                                                                <asp:ImageButton runat="server" ID="btn_cancelar" ImageUrl ="~/Images/cancel.png" CommandName ="CancelarCelular" ToolTip ="Cancelar el Ajuste" visible ="false" />
                                                            </ItemTemplate>
                                                            <ItemStyle Width="50px" />
                                                            <HeaderStyle Width="50px"  />
                                                        </telerik:GridTemplateColumn>
                               
                                                        <telerik:GridTemplateColumn DefaultInsertValue="" HeaderText="Edición" UniqueName="ColumnaEdicion">
                                                            <ItemTemplate>
                                                                <asp:ImageButton runat="server" ID="btn_editar" ImageUrl ="~/Images/edit.png" CommandName ="EditarCelular" ToolTip ="Editar Celular" />
                                                                <asp:ImageButton runat="server" ID="btn_eliminar" ImageUrl ="~/Images/balde.gif" CommandName ="EliminarCelular" ToolTip ="Eliminar Celular" />
                                                            </ItemTemplate>
                                                            <ItemStyle Width="50px" />
                                                            <HeaderStyle Width="50px"  />
                                                        </telerik:GridTemplateColumn>
    

                                                    </Columns>
                                       

                                                    <PagerStyle FirstPageToolTip="Primera" LastPageToolTip="Ultima" 
                                                        Mode="NumericPages" NextPagesToolTip="Próximas" NextPageToolTip="Próxima" 
                                                        PagerTextFormat="Cambiar Página: {4} &amp;nbsp;Página &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;, registros &lt;strong&gt;{2}&lt;/strong&gt; a &lt;strong&gt;{3}&lt;/strong&gt; de &lt;strong&gt;{5}&lt;/strong&gt;." 
                                                        PrevPagesToolTip="Anteriores" PrevPageToolTip="Anterior" />
                                                </MasterTableView>
                                                <ClientSettings EnablePostBackOnRowClick="False" EnableRowHoverStyle="True">
                                                    <Selecting AllowRowSelect="True" />
                                                </ClientSettings>
                                                <ExportSettings ExportOnlyData="True" filename="Personas_Celulares"  
                                                    HideStructureColumns="True" IgnorePaging="True" OpenInNewWindow="True">
                                                    <Pdf PageWidth="">
                                                    </Pdf>
                                                </ExportSettings>
                                                <SortingSettings SortedAscToolTip="Ordenar Ascendente" 
                                                    SortedDescToolTip="Ordenar Descendente" 
                                                    SortToolTip="Clic aqui para ordenar..." />
                                                <PagerStyle Mode="NumericPages" />
                                            </telerik:RadGrid>
                                            <table runat="server" ID="tbl_nuevocelular" Width= "100%" >
                                                <tr valign="top">
                                                    <td width="150">
                                                        <asp:Label runat="server" ID="Label80" 
                                                            style="font-weight: 700; color: #0000CC" >NUEVO REGISTRO  -------&gt;</asp:Label>  
                                                    </td>
                                                    <td width="200">
                                                        <asp:Label runat="server">Digite Nuevo Número Celular : </asp:Label>
                                                    </td>
                                                    <td style="text-align: left">
                                                        <asp:TextBox runat="server" ID="txt_nuevocelular" Width="500px" />
                                                    </td>
                                                    <td>
                                                        <asp:ImageButton runat="server" ID="btn_nuevocelular" ImageUrl ="~/Images/guardar.png" ToolTip="Guardar nuevo dato" />
                                                    </td>
                                                    <td>
                                                        <asp:ImageButton runat="server" ID="btn_limpiarcelular" ImageUrl ="~/Images/limpiar.png" ToolTip="Limpiar dato De Celular" />
                                                    </td>


                                                </tr>
                                            </table>
                                        </telerik:RadPageView>

                                        <telerik:RadPageView ID="RadPageView2" runat="server"  >
                                            <telerik:RadGrid ID="Rg_telefono" runat="server" AutoGenerateColumns="False" PageSize="20"
                                               Skin="WebBlue" TabIndex="6" Width="100%"  OnItemCommand ="subCommandItemTelefono"
                                                    ResolvedRenderMode="Classic">
                                                <MasterTableView   DataKeyNames="ID" 
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
                                                            <ItemStyle Width="30px" />
                                                        </telerik:GridTemplateColumn>
                                                        <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" Display="False" 
                                                            HeaderText="Id" ReadOnly="True" SortExpression="Id" UniqueName="Id">
                                                            <ItemStyle Width="30px" />
                                                        </telerik:GridBoundColumn>

                                                        <telerik:GridTemplateColumn DefaultInsertValue="" HeaderText="Número de Teléfono y Descripcion (si aplica)" 
                                                            UniqueName="TemplateColumn">
                                                            <ItemTemplate>
                                                                <asp:TextBox runat="server" ID="txt_telefono" Width ="400px" Text ='<%#Container.DataItem.Descripcion%>' Enabled="False"  ></asp:TextBox>
                                                            </ItemTemplate>
                                                            <ItemStyle Width="500px" />
                                                        </telerik:GridTemplateColumn>

                                                        <telerik:GridTemplateColumn DefaultInsertValue="" HeaderText="Principal" 
                                                            UniqueName="TemplateColumn">
                                                            <ItemTemplate>
                                                                <asp:CheckBox runat="server" ID="chb_principal" Width ="20px"  Checked  ='<%#Container.DataItem.Activo%>'  Enabled ="False"/>
                                                            </ItemTemplate>
                                                            <ItemStyle Width="50px" />
                                                            <HeaderStyle Width="50px"  />
                                                        </telerik:GridTemplateColumn>

                                                        
                                                        <telerik:GridTemplateColumn DefaultInsertValue="" HeaderText="Opciones" UniqueName="ColumnaOpciones" >
                                                            <ItemTemplate>
                                                                <asp:ImageButton runat="server" ID="btn_aceptar" ImageUrl ="~/Images/aceptar.png" CommandName ="GrabarTelefono" ToolTip ="Grabar el Ajuste" visible ="false" />
                                                                <asp:ImageButton runat="server" ID="btn_cancelar" ImageUrl ="~/Images/cancel.png" CommandName ="CancelarTelefono" ToolTip ="Cancelar el Ajuste" visible ="false" />
                                                            </ItemTemplate>
                                                            <ItemStyle Width="50px" />
                                                            <HeaderStyle Width="50px"  />
                                                        </telerik:GridTemplateColumn>
                               
                                                        <telerik:GridTemplateColumn DefaultInsertValue="" HeaderText="Edición" UniqueName="ColumnaEdicion">
                                                            <ItemTemplate>
                                                                <asp:ImageButton runat="server" ID="btn_editar" ImageUrl ="~/Images/edit.png" CommandName ="EditarTelefono" ToolTip ="Editar Teléfono" />
                                                                <asp:ImageButton runat="server" ID="btn_eliminar" ImageUrl ="~/Images/balde.gif" CommandName ="EliminarTelefono" ToolTip ="Eliminar Teléfono" />
                                                            </ItemTemplate>
                                                            <ItemStyle Width="50px" />
                                                            <HeaderStyle Width="50px"  />
                                                        </telerik:GridTemplateColumn>
    

                                                    </Columns>
                                       

                                                    <PagerStyle FirstPageToolTip="Primera" LastPageToolTip="Ultima" 
                                                        Mode="NumericPages" NextPagesToolTip="Próximas" NextPageToolTip="Próxima" 
                                                        PagerTextFormat="Cambiar Página: {4} &amp;nbsp;Página &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;, registros &lt;strong&gt;{2}&lt;/strong&gt; a &lt;strong&gt;{3}&lt;/strong&gt; de &lt;strong&gt;{5}&lt;/strong&gt;." 
                                                        PrevPagesToolTip="Anteriores" PrevPageToolTip="Anterior" />
                                                </MasterTableView>
                                                <ClientSettings EnablePostBackOnRowClick="False" EnableRowHoverStyle="True">
                                                    <Selecting AllowRowSelect="True" />
                                                </ClientSettings>
                                                <ExportSettings ExportOnlyData="True" filename="Personas_Telefonos"  
                                                    HideStructureColumns="True" IgnorePaging="True" OpenInNewWindow="True">
                                                    <Pdf PageWidth="">
                                                    </Pdf>
                                                </ExportSettings>
                                                <SortingSettings SortedAscToolTip="Ordenar Ascendente" 
                                                    SortedDescToolTip="Ordenar Descendente" 
                                                    SortToolTip="Clic aqui para ordenar..." />
                                                <PagerStyle Mode="NumericPages" />
                                            </telerik:RadGrid>
                                            <table runat="server" ID="Table1" Width= "100%" >
                                                <tr valign="top">
                                                    <td width="150">
                                                        <asp:Label runat="server" ID="Label2" 
                                                            style="font-weight: 700; color: #0000CC" >NUEVO REGISTRO  -------&gt;</asp:Label>  
                                                    </td>
                                                    <td width="200">
                                                        <asp:Label ID="Label7" runat="server">Digite Nuevo Número Teléfono : </asp:Label>
                                                    </td>
                                                    <td style="text-align: left">
                                                        <asp:TextBox runat="server" ID="txt_nuevoTelefono" Width="500px" />
                                                    </td>
                                                    <td>
                                                        <asp:ImageButton runat="server" ID="btn_nuevotelefono" ImageUrl ="~/Images/guardar.png" ToolTip="Guardar nuevo dato" />
                                                    </td>
                                                    <td>
                                                        <asp:ImageButton runat="server" ID="btn_limpiartelefono" ImageUrl ="~/Images/limpiar.png" ToolTip="Limpiar dato De Teléfono" />
                                                    </td>


                                                </tr>
                                            </table>
                                        </telerik:RadPageView>
                                        
                                        <telerik:RadPageView ID="RadPageView3" runat="server"  >
                                            <telerik:RadGrid ID="Rg_Direccion" runat="server" AutoGenerateColumns="False" PageSize="20"
                                                 Skin="WebBlue" TabIndex="6" Width="100%" OnItemCommand ="subCommandItemDireccion"
                                                 ResolvedRenderMode="Classic">
                                                <MasterTableView   DataKeyNames="ID" 
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
                                                            <ItemStyle Width="30px" />
                                                        </telerik:GridTemplateColumn>
                                                        <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" Display="False" 
                                                            HeaderText="Id" ReadOnly="True" SortExpression="Id" UniqueName="Id">
                                                            <ItemStyle Width="30px" />
                                                        </telerik:GridBoundColumn>

                                                        <telerik:GridTemplateColumn DefaultInsertValue="" HeaderText="Dato Completo de Dirección (si aplica)" 
                                                            UniqueName="TemplateColumn">
                                                            <ItemTemplate>
                                                                <asp:TextBox runat="server" ID="txt_direccion" Width ="400px" Text ='<%#Container.DataItem.Descripcion%>' Enabled="False"  ></asp:TextBox>
                                                            </ItemTemplate>
                                                            <ItemStyle Width="500px" />
                                                        </telerik:GridTemplateColumn>

                                                        <telerik:GridTemplateColumn DefaultInsertValue="" HeaderText="Principal" 
                                                            UniqueName="TemplateColumn">
                                                            <ItemTemplate>
                                                                <asp:CheckBox runat="server" ID="chb_principal" Width ="20px"  Checked  ='<%#Container.DataItem.Activo%>' Enabled ="False" />
                                                            </ItemTemplate>
                                                            <ItemStyle Width="50px" />
                                                            <HeaderStyle Width="50px"  />
                                                        </telerik:GridTemplateColumn>

                                                        
                                                        <telerik:GridTemplateColumn DefaultInsertValue="" HeaderText="Opciones" UniqueName="ColumnaOpciones" >
                                                            <ItemTemplate>
                                                                <asp:ImageButton runat="server" ID="btn_aceptar" ImageUrl ="~/Images/aceptar.png" CommandName ="GrabarDireccion" ToolTip ="Grabar el Ajuste" visible ="false" />
                                                                <asp:ImageButton runat="server" ID="btn_cancelar" ImageUrl ="~/Images/cancel.png" CommandName ="CancelarDireccion" ToolTip ="Cancelar el Ajuste" visible ="false" />
                                                            </ItemTemplate>
                                                            <ItemStyle Width="50px" />
                                                            <HeaderStyle Width="50px"  />
                                                        </telerik:GridTemplateColumn>
                               
                                                        <telerik:GridTemplateColumn DefaultInsertValue="" HeaderText="Edición" UniqueName="ColumnaEdicion">
                                                            <ItemTemplate>
                                                                <asp:ImageButton runat="server" ID="btn_editar" ImageUrl ="~/Images/edit.png" CommandName ="EditarDireccion" ToolTip ="Editar Dirección" />
                                                                <asp:ImageButton runat="server" ID="btn_eliminar" ImageUrl ="~/Images/balde.gif" CommandName ="EliminarDireccion" ToolTip ="Eliminar Dirección" />
                                                            </ItemTemplate>
                                                            <ItemStyle Width="50px" />
                                                            <HeaderStyle Width="50px"  />
                                                        </telerik:GridTemplateColumn>
    

                                                    </Columns>
                                       

                                                    <PagerStyle FirstPageToolTip="Primera" LastPageToolTip="Ultima" 
                                                        Mode="NumericPages" NextPagesToolTip="Próximas" NextPageToolTip="Próxima" 
                                                        PagerTextFormat="Cambiar Página: {4} &amp;nbsp;Página &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;, registros &lt;strong&gt;{2}&lt;/strong&gt; a &lt;strong&gt;{3}&lt;/strong&gt; de &lt;strong&gt;{5}&lt;/strong&gt;." 
                                                        PrevPagesToolTip="Anteriores" PrevPageToolTip="Anterior" />
                                                </MasterTableView>
                                                <ClientSettings EnablePostBackOnRowClick="False" EnableRowHoverStyle="True">
                                                    <Selecting AllowRowSelect="True" />
                                                </ClientSettings>
                                                <ExportSettings ExportOnlyData="True" filename="Personas_Direcciones"  
                                                    HideStructureColumns="True" IgnorePaging="True" OpenInNewWindow="True">
                                                    <Pdf PageWidth="">
                                                    </Pdf>
                                                </ExportSettings>
                                                <SortingSettings SortedAscToolTip="Ordenar Ascendente" 
                                                    SortedDescToolTip="Ordenar Descendente" 
                                                    SortToolTip="Clic aqui para ordenar..." />
                                                <PagerStyle Mode="NumericPages" />
                                            </telerik:RadGrid>
                                            <table runat="server" ID="Table3" Width= "100%" >
                                                <tr valign="top">
                                                    <td width="150">
                                                        <asp:Label runat="server" ID="Label8" 
                                                            style="font-weight: 700; color: #0000CC" >NUEVO REGISTRO  -------&gt;</asp:Label>  
                                                    </td>
                                                    <td width="200">
                                                        <asp:Label ID="Label9" runat="server">Digite Nueva Dirección Completa : </asp:Label>
                                                    </td>
                                                    <td style="text-align: left">
                                                        <asp:TextBox runat="server" ID="txt_nuevadireccion" Width="500px" />
                                                    </td>
                                                    <td>
                                                        <asp:ImageButton runat="server" ID="btn_nuevadireccion" ImageUrl ="~/Images/guardar.png" ToolTip="Guardar nuevo dato" />
                                                    </td>
                                                    <td>
                                                        <asp:ImageButton runat="server" ID="btn_limpiardireccion" ImageUrl ="~/Images/limpiar.png" ToolTip="Limpiar dato De Dirección" />
                                                    </td>


                                                </tr>
                                            </table>
                                        </telerik:RadPageView>
                                        
                                        <telerik:RadPageView ID="RadPageView4" runat="server"  >
                                            <telerik:RadGrid ID="Rg_Barrio" runat="server" AutoGenerateColumns="False" PageSize="20"
                                                Skin="WebBlue" TabIndex="6" Width="100%"  OnItemCommand ="subCommandItemBarrio"
                                                ResolvedRenderMode="Classic">
                                                <MasterTableView  DataKeyNames="ID" 
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
                                                            <ItemStyle Width="30px" />
                                                        </telerik:GridTemplateColumn>
                                                        <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" Display="False" 
                                                            HeaderText="Id" ReadOnly="True" SortExpression="Id" UniqueName="Id">
                                                            <ItemStyle Width="30px" />
                                                        </telerik:GridBoundColumn>

                                                        <telerik:GridTemplateColumn DefaultInsertValue="" HeaderText="Nombre del Barrio Completo (si aplica)" 
                                                            UniqueName="TemplateColumn">
                                                            <ItemTemplate>
                                                                <asp:TextBox runat="server" ID="txt_barrio" Width ="400px" Text ='<%#Container.DataItem.Descripcion%>' Enabled="False"  ></asp:TextBox>
                                                            </ItemTemplate>
                                                            <ItemStyle Width="500px" />
                                                        </telerik:GridTemplateColumn>

                                                        <telerik:GridTemplateColumn DefaultInsertValue="" HeaderText="Principal" 
                                                            UniqueName="TemplateColumn">
                                                            <ItemTemplate>
                                                                <asp:CheckBox runat="server" ID="chb_principal" Width ="20px"  Checked  ='<%#Container.DataItem.Activo%>' Enabled ="False" />
                                                            </ItemTemplate>
                                                            <ItemStyle Width="50px" />
                                                            <HeaderStyle Width="50px"  />
                                                        </telerik:GridTemplateColumn>

                                                        
                                                        <telerik:GridTemplateColumn DefaultInsertValue="" HeaderText="Opciones" UniqueName="ColumnaOpciones" >
                                                            <ItemTemplate>
                                                                <asp:ImageButton runat="server" ID="btn_aceptar" ImageUrl ="~/Images/aceptar.png" CommandName ="GrabarBarrio" ToolTip ="Grabar el Ajuste" visible ="false" />
                                                                <asp:ImageButton runat="server" ID="btn_cancelar" ImageUrl ="~/Images/cancel.png" CommandName ="CancelarBarrio" ToolTip ="Cancelar el Ajuste" visible ="false" />
                                                            </ItemTemplate>
                                                            <ItemStyle Width="50px" />
                                                            <HeaderStyle Width="50px"  />
                                                        </telerik:GridTemplateColumn>
                               
                                                        <telerik:GridTemplateColumn DefaultInsertValue="" HeaderText="Edición" UniqueName="ColumnaEdicion">
                                                            <ItemTemplate>
                                                                <asp:ImageButton runat="server" ID="btn_editar" ImageUrl ="~/Images/edit.png" CommandName ="EditarBarrio" ToolTip ="Editar Barrio" />
                                                                <asp:ImageButton runat="server" ID="btn_eliminar" ImageUrl ="~/Images/balde.gif" CommandName ="EliminarBarrio" ToolTip ="Eliminar Barrio" />
                                                            </ItemTemplate>
                                                            <ItemStyle Width="50px" />
                                                            <HeaderStyle Width="50px"  />
                                                        </telerik:GridTemplateColumn>
    

                                                    </Columns>
                                       

                                                    <PagerStyle FirstPageToolTip="Primera" LastPageToolTip="Ultima" 
                                                        Mode="NumericPages" NextPagesToolTip="Próximas" NextPageToolTip="Próxima" 
                                                        PagerTextFormat="Cambiar Página: {4} &amp;nbsp;Página &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;, registros &lt;strong&gt;{2}&lt;/strong&gt; a &lt;strong&gt;{3}&lt;/strong&gt; de &lt;strong&gt;{5}&lt;/strong&gt;." 
                                                        PrevPagesToolTip="Anteriores" PrevPageToolTip="Anterior" />
                                                </MasterTableView>
                                                <ClientSettings EnablePostBackOnRowClick="False" EnableRowHoverStyle="True">
                                                    <Selecting AllowRowSelect="True" />
                                                </ClientSettings>
                                                <ExportSettings ExportOnlyData="True" filename="Personas_Barrio"  
                                                    HideStructureColumns="True" IgnorePaging="True" OpenInNewWindow="True">
                                                    <Pdf PageWidth="">
                                                    </Pdf>
                                                </ExportSettings>
                                                <SortingSettings SortedAscToolTip="Ordenar Ascendente" 
                                                    SortedDescToolTip="Ordenar Descendente" 
                                                    SortToolTip="Clic aqui para ordenar..." />
                                                <PagerStyle Mode="NumericPages" />
                                            </telerik:RadGrid>
                                            <table runat="server" ID="Table4" Width= "100%" >
                                                <tr valign="top">
                                                    <td width="150">
                                                        <asp:Label runat="server" ID="Label11" 
                                                            style="font-weight: 700; color: #0000CC" >NUEVO REGISTRO  -------&gt;</asp:Label>  
                                                    </td>
                                                    <td width="200">
                                                        <asp:Label ID="Label12" runat="server">Digite Nuevo Barrio Completo : </asp:Label>
                                                    </td>
                                                    <td style="text-align: left">
                                                        <asp:TextBox runat="server" ID="txt_nuevobarrio" Width="500px" />
                                                    </td>
                                                    <td>
                                                        <asp:ImageButton runat="server" ID="btn_nuevobarrio" ImageUrl ="~/Images/guardar.png" ToolTip="Guardar nuevo dato" />
                                                    </td>
                                                    <td>
                                                        <asp:ImageButton runat="server" ID="btn_limpiarbarrio" ImageUrl ="~/Images/limpiar.png" ToolTip="Limpiar dato De Barrio" />
                                                    </td>


                                                </tr>
                                            </table>
                                        </telerik:RadPageView>


                                    </telerik:RadMultiPage>

                                </td>

                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
    </asp:Panel>
</asp:Content>

