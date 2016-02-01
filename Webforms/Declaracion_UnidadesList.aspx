<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="Declaracion_UnidadesList.aspx.vb" Inherits="WebForms_Declaracion_UnidadesList" %>
<%@ Register Src="../Controles/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Panel runat="server" ID="pnl_principal" DefaultButton ="btn_actualizar" Width ="100%">
        <table id="tbl_Interna" border="0" cellpadding="1" cellspacing="0" width="100%" 
                style="border-right: whitesmoke thin solid; border-top: whitesmoke thin solid; border-left: whitesmoke thin solid; border-bottom: whitesmoke thin solid">
            <tr valign ="top">
                <td style="width: 80%;"> 
                    <asp:Label ID="Label3" runat="server" Text="VISTA GENERAL DE UNIDADES DE APOYO DE DECLARANTES" Width="100%" CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
                    <asp:Label ID="Label4" runat="server" CssClass="TitMensaje" Text="_" Width="100%" Visible="False"></asp:Label>
                </td>
                <td style="width: 20%" align="right">
                    <asp:ImageButton ID="btn_actualizar" runat="server" 
                    ImageUrl="~/Images/Reload.jpg" TabIndex="1" 
                    ToolTip="Actualizar la vista actual." />
                    <asp:ImageButton ID="btn_buscar" runat="server" ImageUrl="~/Images/Zoom In.jpg" ToolTip="Ver/quitar Sistema de Búsqueda." TabIndex="2" />
                    <asp:ImageButton ID="btn_nuevo" runat="server" ImageUrl="~/Images/Add.jpg" ToolTip="Crear Nuevo Registro." TabIndex="3" Visible="False" />
                    <asp:ImageButton ID="btn_cerrar" runat="server" ImageUrl="~/Images/Stop.jpg" ToolTip="Cerrar - Volver a la vista anterior." TabIndex="4" />
                    <asp:ImageButton ID="btn_home" runat="server" ImageUrl="~/Images/Home.jpg" ToolTip="Ir al Inicio." TabIndex="5" />
                </td>
            </tr>
            <tr valign ="top">
                <td colspan="2" align="center" >
                    <asp:Panel ID="pnl_buscar" runat="server" Width="100%" HorizontalAlign="Center" Visible="False">
                            <table border="0" cellpadding="0" cellspacing="0" 
                                style="width: 100%; text-align: left; padding-left: 3px;">
                                <tr valign ="top">
                                    <td colspan="5" style="text-align: left" >
                                        <asp:Label ID="Label6" runat="server" Text="Sistema de Búsqueda Selectiva" Width="90%" Font-Bold="True" Font-Underline="False"></asp:Label></td>
                                    <td style="width: 20%" align="right">
                                        <asp:ImageButton ID="btn_Procesar" runat="server" ImageUrl="~/Images/Search.jpg" ToolTip="Realizar la Búsqueda." TabIndex="5" />
                                        <asp:ImageButton ID="btn_limpiar" runat="server" ImageUrl="~/Images/New.jpg" ToolTip="Limpiar Campos Búsqueda." TabIndex="6" /></td>
                                </tr>
                                <tr valign="top">
                                    <td style="width: 15%">
                                        <asp:Label ID="Label44" runat="server" Text="Regional" Width="94%"></asp:Label>
                                    </td>
                                    <td style="width: 20%">
                                        <asp:DropDownList ID="ddl_regional" runat="server" Font-Size="X-Small" 
                                            TabIndex="3" Width="90%">
                                        </asp:DropDownList>
                                    </td>
                                    <td style="width: 15%">
                                        <asp:Label ID="Label1" runat="server" Text="Identificación" Width="90%"></asp:Label></td>
                                    <td style="width: 15%">
                                        <asp:TextBox ID="txt_identificacion" runat="server" Font-Size="X-Small" Width="90%" TabIndex="1"></asp:TextBox></td>
                                    <td style="width: 15%">
                                        <asp:Label ID="Label7" runat="server" Text="Fuente" Width="90%"></asp:Label></td>
                                    <td style="width: 20%">
                                        <asp:dropdownlist ID="ddl_Fuente" runat="server" Width="90%" Font-Size="X-Small" TabIndex="2">
                                        </asp:dropdownlist></td>
                                </tr>
                                <tr valign="top">
                                    <td style="width: 15%">
                                        <asp:Label ID="Label42" runat="server" Text="Grupo" Width="94%"/></td>
                                    <td style="width: 20%">
                                        <asp:dropdownlist ID="ddl_grupo" runat="server" Width="90%" 
                                            Font-Size="X-Small"/></td>
                                    <td style="width: 15%">
                                        <asp:Label ID="Label5" runat="server" Text="Nombre" Width="94%"></asp:Label></td>
                                    <td style="width: 15%">
                                        <asp:TextBox ID="txt_nombre" runat="server" Font-Size="X-Small" Width="90%" TabIndex="4"></asp:TextBox></td>
                                    <td style="width: 15%">
                                        <asp:Label ID="Label22" runat="server" Text="Lugar de Fuente" Width="94%"></asp:Label></td>
                                    <td style="width: 20%">
                                        <asp:dropdownlist ID="ddl_LugarFuente" runat="server" Width="90%" 
                                            Font-Size="X-Small" TabIndex="5">
                                        </asp:dropdownlist></td>
                                </tr>
                            
                                <tr valign="top">
                                    <td style="width: 15%">
                                        <asp:Label ID="Label10" runat="server" Text="Fecha Inicial Entrega" Width="94%"></asp:Label>
                                    </td>
                                    <td style="width: 20%">
                                        <telerik:RadDatePicker ID="rdpfechaInicialEntrega" runat="server" 
                                            Culture="es-CO" MaxDate="2020-12-31" MinDate="" Skin="Vista" TabIndex="1" 
                                            ToolTip="Seleccione Fecha ..." Width="95%">
                                            <Calendar EnableKeyboardNavigation="True" Skin="Vista" 
                                                UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False" 
                                                ViewSelectorText="x">
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
                                    </td>
                                    <td style="width: 15%">
                                        <asp:Label ID="Label21" runat="server" Text="Tipo Declarante" Width="94%"></asp:Label>
                                    </td>
                                    <td style="width: 15%">
                                        <asp:DropDownList ID="ddl_tipodeclarante" runat="server" Font-Size="X-Small" 
                                            TabIndex="7" Width="90%">
                                        </asp:DropDownList>
                                    </td>
                                    <td style="width: 15%">
                                        <asp:Label ID="Label20" runat="server" Text="Horario" Width="90%"></asp:Label>
                                    </td>
                                    <td style="width: 20%">
                                        <asp:RadioButtonList ID="rdb_Horario" runat="server" Font-Size="XX-Small" 
                                            RepeatDirection="Horizontal" RepeatLayout="Flow" TabIndex="6" Width="94%">
                                            <asp:ListItem Value="TO">Todos</asp:ListItem>
                                            <asp:ListItem>AM</asp:ListItem>
                                            <asp:ListItem>PM</asp:ListItem>
                                            <asp:ListItem>TD</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td style="width: 15%">
                                        <asp:Label ID="Label12" runat="server" Text="Fecha Final Entrega" Width="94%"></asp:Label>
                                    </td>
                                    <td style="width: 20%">
                                        <telerik:RadDatePicker ID="rdpfechaFinalEntrega" runat="server" Culture="es-CO" 
                                            MaxDate="2020-12-31" MinDate="2000-10-01" Skin="WebBlue" TabIndex="1" 
                                            ToolTip="Seleccione Fecha ..." Width="90%">
                                            <Calendar EnableKeyboardNavigation="True" Skin="WebBlue" 
                                                UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False" 
                                                ViewSelectorText="x">
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
                                    </td>
                                    <td style="width: 15%">
                                        &nbsp;</td>
                                    <td style="width: 15%">
                                        &nbsp;</td>
                                    <td style="width: 15%">
                                        &nbsp;</td>
                                    <td style="width: 20%">
                                        <asp:Button ID="btn_uariv" runat="server" Text="Procesar WS" Width="90%" />
                                    </td>
                                </tr>
                            </table>
                        
                            </asp:Panel>
                </td>
            </tr>
            <tr valign ="top">
                <td colspan="2">					
				    <telerik:RadGrid ID="Rg_Listado" runat="server" AllowSorting="True" Skin="WebBlue" Width="100%"  
                        AutoGenerateColumns="False" ShowStatusBar="True" TabIndex="6" PageSize="20" ResolvedRenderMode="Classic">
                        <MasterTableView  NoDetailRecordsText="No hay informaci&#243;n." NoMasterRecordsText="No hay informaci&#243;n." DataKeyNames="Id" 
                            CommandItemDisplay ="Top" AllowPaging="True">
                            <Columns>
                                <telerik:GridTemplateColumn HeaderText="No." DefaultInsertValue="" UniqueName="TemplateColumn">
                                    <ItemTemplate>
                                        <asp:label runat="server" id="lblno" text='<%# ctype(CType(Container.Parent.Parent.Parent,RadGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>' />
                                        <asp:Label runat="Server" Id="lblid" Visible ="False" Text ='<%#Container.DataItem.Id%>'/>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>                                
                        
                                <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" HeaderText="Id" 
                                    SortExpression="Id" UniqueName="Id"  Display ="False" >
                                </telerik:GridBoundColumn>
	
                                <telerik:GridBoundColumn DataField="Fecha_Valoracion" DataType="System.DateTime" HeaderText="Fecha Atención"
                                    DataFormatString="{0:dd/MMM/yyyy}" SortExpression="Fecha_Valoracion" UniqueName="Fecha_Valoracion">
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                </telerik:GridBoundColumn>    

						        <telerik:GridBoundColumn DataField="Declarante" HeaderText="TD"  HeaderTooltip ="Declarante"
                                    SortExpression="Declarante" UniqueName="Declarante" >
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                </telerik:GridBoundColumn> 					            

						        <telerik:GridBoundColumn DataField="DescripcionGrupo" HeaderText="Grupo"  HeaderTooltip ="Nombre de Grupo"
                                    SortExpression="DescripcionGrupo" UniqueName="DescripcionGrupo" >
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                </telerik:GridBoundColumn> 	

						        <telerik:GridBoundColumn DataField="Personas_Declarante.NombreCompleto" HeaderText="Nombre Declarante"  
                                    SortExpression="Personas_Declarante.NombreCompleto" UniqueName="Personas_Declarante.NombreCompleto" >
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                </telerik:GridBoundColumn> 	

						        <telerik:GridBoundColumn DataField="Personas_Declarante.Identificacion" HeaderText="Identificación"  
                                    SortExpression="Personas_Declarante.Identificacion" UniqueName="Personas_Declarante.Identificacion" >
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                </telerik:GridBoundColumn> 
                            
                                <telerik:GridTemplateColumn >
                                  <ItemTemplate >
                                     <asp:label runat="server" ID="lbl_estadoruv" text='<%#Container.DataItem.EstadoRUV%>' ToolTip ='<%#Container.DataItem.WFecha_Valoracion_RUV%>'/>
                                  </ItemTemplate>
                                  <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                    <HeaderTemplate  >
                                        <asp:Label ID="Label2" runat="Server" Text='R.U.V.'></asp:Label>
                                    </HeaderTemplate>
                                </telerik:GridTemplateColumn>
			            
                                <telerik:GridTemplateColumn >
                                    <ItemTemplate   >
                                        <asp:label runat="server" ID="lbl_estadofaccion" text='<%#Container.DataItem.EstadoFaccion%>' ToolTip ='<%#Container.DataItem.WFecha_InclusionFaccion%>'/>
                                    </ItemTemplate>
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                    <HeaderTemplate  >
                                        <asp:Label runat="Server" Text='F.Acción'></asp:Label>
                                    </HeaderTemplate>
                                </telerik:GridTemplateColumn>

                                <telerik:GridTemplateColumn >
                                    <ItemTemplate   >
                                        <asp:label runat="server" ID="lbl_estadoaa" text='<%#Container.DataItem.EstadoActoAdministrativo%>' ToolTip ='<%#Container.DataItem.WFecha_InclusionEstadoActoAdministrativo%>'/>
                                    </ItemTemplate>
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                    <HeaderTemplate  >
                                        <asp:Label ID="Label8" runat="Server" Text='A. Administrativo'></asp:Label>
                                    </HeaderTemplate>
                                </telerik:GridTemplateColumn>

                                <telerik:GridTemplateColumn >
                                    <ItemTemplate   >
                                        <asp:label runat="server" ID="lbl_estadonotificacion" text='<%#Container.DataItem.EstadoNotificacion%>' ToolTip ='<%#Container.DataItem.WFecha_InclusionNotificacion%>'/>
                                    </ItemTemplate>
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                    <HeaderTemplate  >
                                        <asp:Label ID="Label8" runat="Server" Text='Notificación'></asp:Label>
                                    </HeaderTemplate>
                                </telerik:GridTemplateColumn>

                                <telerik:GridTemplateColumn >
                                    <ItemTemplate   >
                                        <asp:label runat="server" ID="lbl_estadopaari" text='<%#Container.DataItem.EstadoPAARI%>' ToolTip ='<%#Container.DataItem.WFecha_InclusionPAARI%>'/>
                                    </ItemTemplate>
                                    <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                                    <HeaderTemplate  >
                                        <asp:Label ID="Label8" runat="Server" Text='PAARI'></asp:Label>
                                    </HeaderTemplate>
                                </telerik:GridTemplateColumn>

                            </Columns>
                            <CommandItemSettings ExportToCsvText ="Exportar a CSV" 
                                ExportToExcelText ="Exportar a Excel" ExportToPdfText ="Exportar a PDF"
                                 ExportToWordText ="Exportar a Word" RefreshText ="Actualizar" 
                                AddNewRecordText =""  AddNewRecordImageUrl ="~/Images/nothing.gif"
                                  ShowExportToCsvButton="True" ShowExportToExcelButton="True" 
                                ShowExportToPdfButton="True" ShowExportToWordButton ="True" 
                                ShowAddNewRecordButton="False" />
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
                    
                         <ExportSettings  Excel-Format ="ExcelML" SuppressColumnDataFormatStrings ="true"   
                           HideStructureColumns="True" filename ="UnidadesApoyo" ExportOnlyData="True" IgnorePaging="True" OpenInNewWindow="True">
                             <Pdf PageWidth=""  >
                             </Pdf>
                             <Excel Format="ExcelML"   />
                        </ExportSettings>
                        <SortingSettings SortToolTip="Clic aqui para ordenar..."  SortedAscToolTip ="Ordenar Ascendente" SortedDescToolTip ="Ordenar Descendente" />
                        <PagerStyle Mode="NumericPages" AlwaysVisible="True"    />
                
                    </telerik:RadGrid>
                </td>
            </tr>
        </table>
    </asp:Panel> 
    <telerik:RadScriptManager ID="RadScriptManager1" Runat="server"/>
            
    <telerik:RadAjaxLoadingPanel ID="LoadingPanel2" runat="server" 
        BackgroundPosition="Right" Height="0px" Transparency="50">
        <asp:Image ID="Image1" runat="server" AlternateText="Cargando..." 
            ImageUrl="~/Images/loading.gif" />


    </telerik:RadAjaxLoadingPanel>
</asp:Content>

