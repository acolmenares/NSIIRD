<%@ Page Title="" Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="SalidasAjustesAprobarList.aspx.vb" Inherits="WebForms_SalidasAjustesAprobarList" %>
<%@ Register Src="../Controles/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <table id="ContainerFormList"  class="ContainerFormList" width="900">
                <tr>
				    <td class="HeaderFormList" colspan="1">
                         <uc1:Header ID="Header1" runat="server" />
					</td>
				</tr>
				<tr>
				    <td class="ActionButtonsFormList" colspan="1">
	    				<table id="table1" cellspacing="0" cellpadding="0" width="100%">
			                <tr valign="top">
				                <td style="width: 35%; background-color: navajowhite;">
						            <div class="EntityNameFormList">
						            <asp:label runat="server" Id="lbltitulo" style="font-weight: bold; font-size: medium; color: navy; font-style: italic" >Salidas por Ajustes de Mercancia</asp:label></div>
					            </td>
					            <td style="width: 15%;">
						            <div>
							            <asp:LinkButton id="lnkBuscar" runat="server">Buscar <<</asp:LinkButton>&nbsp;
						            </div>
					            </td>
					            <td style="width: 11%;" align="right">
                                    <asp:Label ID="lblidUsuario" runat="server" Font-Italic="True" Font-Underline="True"
                                        Visible="False">_</asp:Label>
					            <asp:Label runat="Server" ID="lbltxtusuario" Font-Bold="True" >Usuario Actual :</asp:Label>
					            </td>
							
					            <td align="left">
					            </td>	
                                <td align="left" style="width: 34%;">
                                    <asp:Label ID="Lblnombreusuario" runat="Server" Font-Italic="True" Font-Underline="True">_</asp:Label></td>
					            </tr>						
			            </table>
                        <asp:Panel ID="pnl_buscar" runat="server" HorizontalAlign="Center" Width="100%">
                            <table border="0" cellpadding="0" cellspacing="0" style="width: 100%; text-align: left">
                                <tr valign="top">
                                    <td colspan="5">
                                        <asp:Label ID="Label3" runat="server" ForeColor="#C04000" Text="Seleccione los datos de búsqueda"></asp:Label></td>
                                    <td colspan="1">
                                        <asp:ImageButton ID="ImbEducacion" runat="server" ImageAlign="Right" ImageUrl="~/Images/Search.jpg"
                                            ToolTip="Carga la información de Estudio" />
                                        <asp:ImageButton ID="ImageButton1" runat="server" ImageAlign="Right" ImageUrl="~/Images/New.jpg"
                                            ToolTip="Carga Toda la Información" />
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td style="width: 15%">
                                        <asp:Label ID="Label2" runat="server" Text="Bodega" Width="94%"></asp:Label></td>
                                    <td style="width: 15%">
                                        <asp:DropDownList ID="ddl_bodegas" runat="server" Font-Size="X-Small" Width="100%">
                                        </asp:DropDownList></td>
                                    <td style="width: 15%">
                                        <asp:Label ID="Label10" runat="server" Text="Fecha Inicial" Width="94%"></asp:Label></td>
                                    <td style="width: 16%">
                                        <asp:TextBox ID="txt_Fecha_Inicial" runat="server" Font-Size="X-Small" MaxLength="10"
                                            Width="50%"></asp:TextBox>
                                        <asp:Label ID="Label14" runat="server">dd-mm-aaaa</asp:Label>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_Fecha_Inicial"
                                            EnableClientScript="False" ErrorMessage="Fecha Inicial de mal ingresada" ValidationExpression="^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$">*</asp:RegularExpressionValidator></td>
                                    <td style="width: 15%">
                                        <asp:Label ID="Label5" runat="server" Text="Número de Salida" Width="94%"></asp:Label></td>
                                    <td style="width: 15%">
                                        <asp:TextBox ID="txt_numero" runat="server" Font-Size="X-Small" Width="90%"></asp:TextBox></td>
                                </tr>
                                <tr valign="top">
                                    <td style="width: 15%">
                                        <asp:Label ID="Label4" runat="server" Text="Regional" Width="94%"></asp:Label></td>
                                    <td style="width: 15%">
                                        <asp:DropDownList ID="ddl_regional" runat="server" Font-Size="X-Small" Width="100%">
                                        </asp:DropDownList></td>
                                    <td style="width: 15%">
                                        <asp:Label ID="Label12" runat="server" Text="Fecha Final " Width="94%"></asp:Label></td>
                                    <td style="width: 16%">
                                        <asp:TextBox ID="Txt_Fecha_Final" runat="server" Font-Bold="False" Font-Size="X-Small"
                                            MaxLength="10" Width="50%"></asp:TextBox>
                                        <asp:Label ID="Label15" runat="server">dd-mm-aaaa</asp:Label>
                                        <asp:RegularExpressionValidator ID="rev_Fecha_Final_Entrega" runat="server" ControlToValidate="Txt_Fecha_Final"
                                            EnableClientScript="False" ErrorMessage="Fecha Final mal ingresada" ValidationExpression="^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$">*</asp:RegularExpressionValidator></td>
                                    <td style="width: 15%">
                                    </td>
                                    <td style="width: 15%">
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
					</td>
				</tr>
				<tr>
					<td  class="DataGridFormList">
						<asp:datagrid id="dgListado" width="100%"  runat="server" OnItemCommand="subCommandItem"
							AutoGenerateColumns="False" OnPageIndexChanged="CambioPagina" AllowPaging="True"
							AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="20">
                                                <SelectedItemStyle  CssClass="DataGridSelectedItemStyle" BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                                                <AlternatingItemStyle cssclass="DataGridAlternatingItemStyle" BackColor="White" />
                                                <ItemStyle CssClass="DataGridItemStyle" BackColor="#E3EAEB" />
                                                <EditItemStyle CssClass="DataGridEditItemStyle" BackColor="#7C6F57" />
                                                <FooterStyle CssClass="DataGridFooterStyle" BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                                                <HeaderStyle cssclass="DataGridHeaderStyle" BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />

							<Columns>
                                <asp:TemplateColumn HeaderText="No.">
								    <ItemTemplate>
									    <%# ctype(CType(Container.Parent.Parent,DataGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>
								    </ItemTemplate>
								    <HeaderStyle Width="30px" HorizontalAlign ="Center" />
						            <ItemStyle Width="30px" HorizontalAlign ="Center"  />	
								</asp:TemplateColumn>
								<asp:TemplateColumn Visible="False">
									<ItemTemplate>
										<asp:Label ID="lblId" runat="server" Text='<%# Container.DataItem.ID %>'></asp:Label>
					                </ItemTemplate>
					            </asp:TemplateColumn>
					            
					            <asp:TemplateColumn HeaderText="Regional" SortExpression="Regional.Descripcion">
						            <ItemTemplate>
							            <%#Container.DataItem.Regional.Descripcion%>
						            </ItemTemplate>
						            <HeaderStyle Width="80px" HorizontalAlign ="Center" />
						            <ItemStyle Width="80px" HorizontalAlign ="Center"  />						            
					            </asp:TemplateColumn>

					            <asp:TemplateColumn HeaderText="Bodega" SortExpression="Bodega.Descripcion">
						            <ItemTemplate>
							            <%#Container.DataItem.Bodega.Descripcion%>
						            </ItemTemplate>
						            <HeaderStyle Width="80px" HorizontalAlign ="Center" />
						            <ItemStyle Width="80px" HorizontalAlign ="Center"  />						            
					            </asp:TemplateColumn>	
					            				            
					            <asp:TemplateColumn HeaderText="N&#250;mero" SortExpression="Numero">
						            <ItemTemplate>
							            <%# Container.DataItem.Numero %>
						            </ItemTemplate>
						            <HeaderStyle Width="50px" HorizontalAlign ="Center" />
						            <ItemStyle Width="50px" HorizontalAlign ="Center"  />						            
					            </asp:TemplateColumn>

					            <asp:TemplateColumn HeaderText="Fecha" SortExpression="Fecha">
						            <ItemTemplate>
							            <%#ingNovar.Utilidades2.FechaUtil.toStringDDMMYYY(Container.DataItem.Fecha)%>
						            </ItemTemplate>
						            <HeaderStyle Width="80px" HorizontalAlign ="Center" />
						            <ItemStyle Width="80px" HorizontalAlign ="Center"  />
					            </asp:TemplateColumn>						            

								<asp:TemplateColumn HeaderText="LOG" >
						            <ItemTemplate>
						               <asp:CheckBox runat="server" ID="chk_aprblog" Enabled ="false" Checked = '<%#Container.DataItem.Salidas_Aprobaciones.item(0).Aprobacion_Logistica_Oficina%>' ToolTip = '<%#Container.DataItem.Salidas_Aprobaciones.item(0).Fecha_ALO%>' />
						            </ItemTemplate>
						            <ItemStyle Width="80px" HorizontalAlign ="Center" />
						            <HeaderStyle Width="80px"  HorizontalAlign ="Center" />
					            </asp:TemplateColumn>

								<asp:TemplateColumn HeaderText="FIN" >
						            <ItemTemplate>
						               <asp:CheckBox runat="server" ID="chk_aprbfin" Enabled ="false" Checked = '<%#Container.DataItem.Salidas_Aprobaciones.item(0).Aprobacion_Finanzas_Oficina%>' ToolTip = '<%#Container.DataItem.Salidas_Aprobaciones.item(0).Fecha_AFO%>' />
						            </ItemTemplate>
						            <ItemStyle Width="80px" HorizontalAlign ="Center" />
						            <HeaderStyle Width="80px" HorizontalAlign ="Center"  />
					            </asp:TemplateColumn>	

								<asp:TemplateColumn HeaderText="COO" >
						            <ItemTemplate>
						               <asp:CheckBox runat="server" ID="chk_aprbcoo" Enabled ="false" Checked = '<%#Container.DataItem.Salidas_Aprobaciones.item(0).Aprobacion_Coordinador_Oficina%>' ToolTip = '<%#Container.DataItem.Salidas_Aprobaciones.item(0).Fecha_ACO%>' />
						            </ItemTemplate>
						            <ItemStyle Width="80px" HorizontalAlign ="Center" />
						            <HeaderStyle Width="80px" HorizontalAlign ="Center" />
					            </asp:TemplateColumn>

								<asp:TemplateColumn HeaderText="COB" >
						            <ItemTemplate>
						               <asp:CheckBox runat="server" ID="chk_aprbcob" Enabled ="false" Checked = '<%#Container.DataItem.Salidas_Aprobaciones.item(0).Aprobacion_Coordinador_Logistica%>' ToolTip = '<%#Container.DataItem.Salidas_Aprobaciones.item(0).Fecha_ACL%>'/>
						            </ItemTemplate>
						            <ItemStyle Width="80px" HorizontalAlign ="Center" />
						            <HeaderStyle Width="80px" HorizontalAlign ="Center"  />
					            </asp:TemplateColumn>

								<asp:TemplateColumn HeaderText="FIB" >
						            <ItemTemplate>
						               <asp:CheckBox runat="server" ID="chk_aprbdir" Enabled ="false" Checked = '<%#Container.DataItem.Salidas_Aprobaciones.item(0).Aprobacion_Director_Financiero%>' ToolTip = '<%#Container.DataItem.Salidas_Aprobaciones.item(0).Fecha_ADF%>' />
						            </ItemTemplate>
						            <ItemStyle Width="80px" HorizontalAlign ="Center" />
						            <HeaderStyle Width="80px" HorizontalAlign ="Center"  />
					            </asp:TemplateColumn>

								<asp:TemplateColumn HeaderText="OPE" >
						            <ItemTemplate>
						               <asp:CheckBox runat="server" ID="chk_aprbope" Enabled ="false" Checked = '<%#Container.DataItem.Salidas_Aprobaciones.item(0).Aprobacion_Director_Pais%>' ToolTip = '<%#Container.DataItem.Salidas_Aprobaciones.item(0).Fecha_ADP%>' />
						            </ItemTemplate>
						            <ItemStyle Width="80px" HorizontalAlign ="Center" />
						            <HeaderStyle Width="80px" HorizontalAlign ="Center" />
					            </asp:TemplateColumn>

    							<asp:TemplateColumn HeaderText="Aprobar" >
						            <ItemTemplate>
						               <asp:CheckBox runat="server" ID="chk_aprobar" />
						            </ItemTemplate>
						            <ItemStyle Width="80px" HorizontalAlign ="Center" />
						            <HeaderStyle Width="80px" HorizontalAlign ="Center"  />
					            </asp:TemplateColumn>

								<asp:EditCommandColumn EditText="Ver Doc" HeaderText="Salida">
								    <ItemStyle Width="50px"></ItemStyle>
                                    <HeaderStyle Width="50px" />
								</asp:EditCommandColumn>
								
							</Columns>
							<PagerStyle BackColor="#666666" CssClass="PagerStyle" ForeColor="White" HorizontalAlign="Center" Mode="NumericPages"></PagerStyle>
						</asp:datagrid>
					</td>
				</tr>
				<tr>
				  <td align="center">
                      <asp:Button ID="btn_AprobarOrdenes" runat="server" CssClass="Boton" Text="Aprobar los Ajustes de Salida" />
                  </td>
				</tr>
			</table>
</asp:Content>

