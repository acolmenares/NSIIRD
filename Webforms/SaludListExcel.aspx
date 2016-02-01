<%@ Page Language="VB" AutoEventWireup="false" CodeFile="SaludListExcel.aspx.vb" Inherits="WebForms_SaludListExcel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <asp:DataGrid ID="dgListado" runat="server" AutoGenerateColumns="False" CellPadding="4"
            ForeColor="#333333" GridLines="None" Width="100%">
            <FooterStyle BackColor="#1C5E55" Cssclass="DataGridFooterStyle" Font-Bold="True" ForeColor="White" />
            <EditItemStyle BackColor="#7C6F57" Cssclass="DataGridEditItemStyle" />
            <SelectedItemStyle BackColor="#C5BBAF" Cssclass="DataGridSelectedItemStyle" Font-Bold="True"
                ForeColor="#333333" />
            <PagerStyle BackColor="#666666" Cssclass="PagerStyle" ForeColor="White" HorizontalAlign="Center"
                Mode="NumericPages" />
            <AlternatingItemStyle BackColor="White" Cssclass="DataGridAlternatingItemStyle" />
            <ItemStyle BackColor="#E3EAEB" Cssclass="DataGridItemStyle" />
            <Columns>
                <asp:TemplateColumn HeaderText="No.">
                    <ItemTemplate>
					    <%# ctype(CType(Container.Parent.Parent,DataGrid).DataSource,IList).IndexOf(Container.DataItem)+1 %>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Grupo" >
                    <ItemTemplate>
                        <%#Container.DataItem.DescripcionGrupo%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Regional" >
                    <ItemTemplate>
                        <%# Container.DataItem.Regional%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Lugar Entrega" >
                    <ItemTemplate>
                        <%#Container.DataItem.LugarEntrega%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="TD" >
                    <ItemTemplate>
                        <%#Container.DataItem.Declarante%>
                    </ItemTemplate>
                </asp:TemplateColumn>                

                <asp:TemplateColumn HeaderText="TI" >
                    <ItemTemplate>
                        <%#Container.DataItem.Tipo_Identificacion%>
                    </ItemTemplate>
                </asp:TemplateColumn>                

                <asp:TemplateColumn HeaderText="Número" >
                    <ItemTemplate>
                        <%# Container.DataItem.Identificacion %>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Edad" >
                    <ItemTemplate>
                        <%#Container.DataItem.Edad%>
                    </ItemTemplate>
                </asp:TemplateColumn>                

                <asp:TemplateColumn HeaderText="Nombre Completo" >
                    <ItemTemplate>
                        <%#Container.DataItem.Nombre_Completo%>
                    </ItemTemplate>
                </asp:TemplateColumn>
                
                <asp:TemplateColumn HeaderText="Genero" >
                    <ItemTemplate>
                        <%#Container.DataItem.Genero%>
                    </ItemTemplate>
                </asp:TemplateColumn>
                
                <asp:TemplateColumn HeaderText="Fecha Nacimiento" >
		            <ItemTemplate>
			             <%#ingNovar.Utilidades2.FechaUtil.toStringDDMMYYY(Container.DataItem.Fecha_Nacimiento)%>
		            </ItemTemplate>
	            </asp:TemplateColumn>                

                <asp:TemplateColumn HeaderText="Nombre Declarante" >
                    <ItemTemplate>
                        <%# Container.DataItem.Nombre_Declarante %>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Identificación Declarante" >
                    <ItemTemplate>
                        <%#Container.DataItem.Identificacion_Declarante%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Teléfono Declarante" >
                    <ItemTemplate>
                        <%#Container.DataItem.Telefono_Declarante%>
                    </ItemTemplate>
                </asp:TemplateColumn>
                
                <asp:TemplateColumn HeaderText="Dirección Declarante" >
                    <ItemTemplate>
                        <%#Container.DataItem.Direccion_Declarante%>
                    </ItemTemplate>
                </asp:TemplateColumn>
                
                <asp:TemplateColumn HeaderText="Celular Declarante" >
                    <ItemTemplate>
                        <%#Container.DataItem.Celular_Declarante%>
                    </ItemTemplate>
                </asp:TemplateColumn>                                

                <asp:TemplateColumn HeaderText="Barrio Declarante" >
                    <ItemTemplate>
                        <%# Container.DataItem.Barrio_Declarante%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="CYD" >
                    <ItemTemplate>
                        <%#Container.DataItem.CYD%>
                    </ItemTemplate>
                </asp:TemplateColumn>
                
                <asp:TemplateColumn HeaderText="Patologia" >
                    <ItemTemplate>
                        <%#Container.DataItem.Patologia%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Lactando" >
                    <ItemTemplate>
                        <%#Container.DataItem.Lactando%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="M. Lactancia" >
                    <ItemTemplate>
                        <%#Container.DataItem.Lactancia_meses%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="M. Exclusiva" >
                    <ItemTemplate>
                        <%#Container.DataItem.Lactancia_Exclusiva%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Despar." >
                    <ItemTemplate>
                        <%#Container.DataItem.Desparasitacion%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Supl." >
                    <ItemTemplate>
                        <%#Container.DataItem.Suplementacion%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Carnet" >
                    <ItemTemplate>
                        <%#Container.DataItem.Carnet%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Motivo No Carnet" >
                    <ItemTemplate>
                        <%#Container.DataItem.Motivo_NoCarnet%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Vac. Completa" >
                    <ItemTemplate>
                        <%#Container.DataItem.Vacunacion%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Motivo No V.C." >
                    <ItemTemplate>
                        <%#Container.DataItem.Motivo_No_VacunacionCompleta%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Vacunados" >
                    <ItemTemplate>
                        <%#Container.DataItem.Vacunados%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Motivo No Vacunados" >
                    <ItemTemplate>
                        <%#Container.DataItem.MotivoNovacunados%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Fecha Vacunados" >
                    <ItemTemplate>
                        <%#ingNovar.Utilidades2.FechaUtil.toStringDDMMYYY(Container.DataItem.Fecha_Esquema_Vacunacion)%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Observaciones" >
                    <ItemTemplate>
                        <%#Container.DataItem.Observaciones_Salud%>
                    </ItemTemplate>
                </asp:TemplateColumn>

               <asp:TemplateColumn HeaderText="Fecha Valoración 01" >
                    <ItemTemplate>
                        <%#ingNovar.Utilidades2.FechaUtil.toStringDDMMYYY(Container.DataItem.Fecha_Valoracion01)%>
                    </ItemTemplate>
                </asp:TemplateColumn>
                
                <asp:TemplateColumn HeaderText="Ant. Peso 01" >
                    <ItemTemplate>
                        <%#Container.DataItem.AntropometriaPeso01%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Ant. Talla" >
                    <ItemTemplate>
                        <%#Container.DataItem.AntropometriaTalla01%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Ant. Per. Bra." >
                    <ItemTemplate>
                        <%#Container.DataItem.Antropometia_Perimetro_Branquial01%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Recuperado 01" >
                    <ItemTemplate>
                        <%#Container.DataItem.Recuperado01%>
                    </ItemTemplate>
                </asp:TemplateColumn>
                
                <asp:TemplateColumn HeaderText="Obs. Valoración 01" >
                    <ItemTemplate>
                        <%#Container.DataItem.Observaciones01%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="PT 01" >
                    <ItemTemplate>
                        <%#Container.DataItem.Pesotalla01%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="PE 01" >
                    <ItemTemplate>
                        <%#Container.DataItem.PesoEdad01%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="TE 01" >
                    <ItemTemplate>
                        <%#Container.DataItem.TallaLongitud01%>
                    </ItemTemplate>
                </asp:TemplateColumn>
     
                <asp:TemplateColumn HeaderText="IMC Edad" >
                    <ItemTemplate>
                        <%#Container.DataItem.IMC_Edad01%>
                    </ItemTemplate>
                </asp:TemplateColumn>     
             
                <asp:TemplateColumn HeaderText="Edad 01" >
                    <ItemTemplate>
                        <%#Container.DataItem.Edad01%>
                    </ItemTemplate>
                </asp:TemplateColumn>  

                <asp:TemplateColumn HeaderText="Meses 01" >
                    <ItemTemplate>
                        <%#Container.DataItem.Meses01%>
                    </ItemTemplate>
                </asp:TemplateColumn>  

                <asp:TemplateColumn HeaderText="T. Edad 01" >
                    <ItemTemplate>
                        <%#Container.DataItem.TallaParaEdad01%>
                    </ItemTemplate>
                </asp:TemplateColumn>  

                <asp:TemplateColumn HeaderText="E.Nutricional 01" >
                    <ItemTemplate>
                        <%#Container.DataItem.EstadoNutricional01%>
                    </ItemTemplate>
                </asp:TemplateColumn>  

               <asp:TemplateColumn HeaderText="Fecha Valoración 02" >
                    <ItemTemplate>
                        <%#ingNovar.Utilidades2.FechaUtil.toStringDDMMYYY(Container.DataItem.Fecha_Valoracion02)%>
                    </ItemTemplate>
                </asp:TemplateColumn>
                
                <asp:TemplateColumn HeaderText="Ant. Peso 02" >
                    <ItemTemplate>
                        <%#Container.DataItem.AntropometriaPeso02%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Ant. Talla 02" >
                    <ItemTemplate>
                        <%#Container.DataItem.AntropometriaTalla02%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Ant. Per. Bra. 02" >
                    <ItemTemplate>
                        <%#Container.DataItem.Antropometia_Perimetro_Branquial02%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Recuperado 02" >
                    <ItemTemplate>
                        <%#Container.DataItem.Recuperado02%>
                    </ItemTemplate>
                </asp:TemplateColumn>
                
                <asp:TemplateColumn HeaderText="Obs. Valoración 02" >
                    <ItemTemplate>
                        <%#Container.DataItem.Observaciones02%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="PT 02" >
                    <ItemTemplate>
                        <%#Container.DataItem.Pesotalla02%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="PE 02" >
                    <ItemTemplate>
                        <%#Container.DataItem.PesoEdad02%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="TE 02" >
                    <ItemTemplate>
                        <%#Container.DataItem.TallaLongitud02%>
                    </ItemTemplate>
                </asp:TemplateColumn>
     
                <asp:TemplateColumn HeaderText="IMC Edad 02" >
                    <ItemTemplate>
                        <%#Container.DataItem.IMC_Edad02%>
                    </ItemTemplate>
                </asp:TemplateColumn>     
             
                <asp:TemplateColumn HeaderText="Edad 02" >
                    <ItemTemplate>
                        <%#Container.DataItem.Edad02%>
                    </ItemTemplate>
                </asp:TemplateColumn>  

                <asp:TemplateColumn HeaderText="Meses 02" >
                    <ItemTemplate>
                        <%#Container.DataItem.Meses02%>
                    </ItemTemplate>
                </asp:TemplateColumn>  

                <asp:TemplateColumn HeaderText="T. Edad 02" >
                    <ItemTemplate>
                        <%#Container.DataItem.TallaParaEdad02%>
                    </ItemTemplate>
                </asp:TemplateColumn>  

                <asp:TemplateColumn HeaderText="E.Nutricional 02" >
                    <ItemTemplate>
                        <%#Container.DataItem.EstadoNutricional02%>
                    </ItemTemplate>
                </asp:TemplateColumn>  

               <asp:TemplateColumn HeaderText="Fecha Valoración 03" >
                    <ItemTemplate>
                        <%#ingNovar.Utilidades2.FechaUtil.toStringDDMMYYY(Container.DataItem.Fecha_Valoracion03)%>
                    </ItemTemplate>
                </asp:TemplateColumn>
                
                <asp:TemplateColumn HeaderText="Ant. Peso 03" >
                    <ItemTemplate>
                        <%#Container.DataItem.AntropometriaPeso03%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Ant. Talla 03" >
                    <ItemTemplate>
                        <%#Container.DataItem.AntropometriaTalla03%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Ant. Per. Bra. 03" >
                    <ItemTemplate>
                        <%#Container.DataItem.Antropometia_Perimetro_Branquial03%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Recuperado 03" >
                    <ItemTemplate>
                        <%#Container.DataItem.Recuperado03%>
                    </ItemTemplate>
                </asp:TemplateColumn>
                
                <asp:TemplateColumn HeaderText="Obs. Valoración 03" >
                    <ItemTemplate>
                        <%#Container.DataItem.Observaciones03%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="PT 03" >
                    <ItemTemplate>
                        <%#Container.DataItem.Pesotalla03%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="PE 03" >
                    <ItemTemplate>
                        <%#Container.DataItem.PesoEdad03%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="TE 03" >
                    <ItemTemplate>
                        <%#Container.DataItem.TallaLongitud03%>
                    </ItemTemplate>
                </asp:TemplateColumn>
     
                <asp:TemplateColumn HeaderText="IMC Edad 03" >
                    <ItemTemplate>
                        <%#Container.DataItem.IMC_Edad03%>
                    </ItemTemplate>
                </asp:TemplateColumn>     
             
                <asp:TemplateColumn HeaderText="Edad 03" >
                    <ItemTemplate>
                        <%#Container.DataItem.Edad03%>
                    </ItemTemplate>
                </asp:TemplateColumn>  

                <asp:TemplateColumn HeaderText="Meses 03" >
                    <ItemTemplate>
                        <%#Container.DataItem.Meses03%>
                    </ItemTemplate>
                </asp:TemplateColumn>  

                <asp:TemplateColumn HeaderText="T. Edad 03" >
                    <ItemTemplate>
                        <%#Container.DataItem.TallaParaEdad03%>
                    </ItemTemplate>
                </asp:TemplateColumn>  

                <asp:TemplateColumn HeaderText="E.Nutricional 03" >
                    <ItemTemplate>
                        <%#Container.DataItem.EstadoNutricional03%>
                    </ItemTemplate>
                </asp:TemplateColumn>  

               <asp:TemplateColumn HeaderText="Fecha Valoración seg" >
                    <ItemTemplate>
                        <%#ingNovar.Utilidades2.FechaUtil.toStringDDMMYYY(Container.DataItem.Fecha_ValoracionSeg)%>
                    </ItemTemplate>
                </asp:TemplateColumn>
                
                <asp:TemplateColumn HeaderText="Ant. Peso Seg" >
                    <ItemTemplate>
                        <%#Container.DataItem.AntropometriaPesoSeg%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Ant. Talla Seg" >
                    <ItemTemplate>
                        <%#Container.DataItem.AntropometriaTallaSeg%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Ant. Per. Bra. Seg" >
                    <ItemTemplate>
                        <%#Container.DataItem.Antropometia_Perimetro_BranquialSeg%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="Recuperado Seg" >
                    <ItemTemplate>
                        <%#Container.DataItem.RecuperadoSeg%>
                    </ItemTemplate>
                </asp:TemplateColumn>
                
                <asp:TemplateColumn HeaderText="Obs. Valoración Seg" >
                    <ItemTemplate>
                        <%#Container.DataItem.ObservacionesSeg%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="PT Seg" >
                    <ItemTemplate>
                        <%#Container.DataItem.PesotallaSeg%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="PE Seg" >
                    <ItemTemplate>
                        <%#Container.DataItem.PesoEdadSeg%>
                    </ItemTemplate>
                </asp:TemplateColumn>

                <asp:TemplateColumn HeaderText="TE Seg" >
                    <ItemTemplate>
                        <%#Container.DataItem.TallaLongitudSeg%>
                    </ItemTemplate>
                </asp:TemplateColumn>
     
                <asp:TemplateColumn HeaderText="IMC Edad Seg" >
                    <ItemTemplate>
                        <%#Container.DataItem.IMC_EdadSeg%>
                    </ItemTemplate>
                </asp:TemplateColumn>     
             
                <asp:TemplateColumn HeaderText="Edad Seg" >
                    <ItemTemplate>
                        <%#Container.DataItem.EdadSeg%>
                    </ItemTemplate>
                </asp:TemplateColumn>  

                <asp:TemplateColumn HeaderText="Meses Seg" >
                    <ItemTemplate>
                        <%#Container.DataItem.MesesSeg%>
                    </ItemTemplate>
                </asp:TemplateColumn>  

                <asp:TemplateColumn HeaderText="T. Edad Seg" >
                    <ItemTemplate>
                        <%#Container.DataItem.TallaParaEdadSeg%>
                    </ItemTemplate>
                </asp:TemplateColumn>  

                <asp:TemplateColumn HeaderText="E.Nutricional Seg" >
                    <ItemTemplate>
                        <%#Container.DataItem.EstadoNutricionalSeg%>
                    </ItemTemplate>
                </asp:TemplateColumn>  

                <asp:TemplateColumn HeaderText="Fecha Rem 01" >
                    <ItemTemplate>
                        <%#Container.DataItem.FechaRemision01%>
                    </ItemTemplate>
                </asp:TemplateColumn>  

                <asp:TemplateColumn HeaderText="Fecha Rea 01" >
                    <ItemTemplate>
                        <%#Container.DataItem.FechaRealizado01%>
                    </ItemTemplate>
                </asp:TemplateColumn>  

                <asp:TemplateColumn HeaderText="Entidad Rem 01" >
                    <ItemTemplate>
                        <%#Container.DataItem.EntidadRemision01%>
                    </ItemTemplate>
                </asp:TemplateColumn>  

                <asp:TemplateColumn HeaderText="Servicio Rem 01" >
                    <ItemTemplate>
                        <%#Container.DataItem.ServicioRemision01%>
                    </ItemTemplate>
                </asp:TemplateColumn>  

                <asp:TemplateColumn HeaderText="Fecha Rem 02" >
                    <ItemTemplate>
                        <%#Container.DataItem.FechaRemision02%>
                    </ItemTemplate>
                </asp:TemplateColumn>  

                <asp:TemplateColumn HeaderText="Fecha Rea 02" >
                    <ItemTemplate>
                        <%#Container.DataItem.FechaRealizado02%>
                    </ItemTemplate>
                </asp:TemplateColumn>  

                <asp:TemplateColumn HeaderText="Entidad Rem 02" >
                    <ItemTemplate>
                        <%#Container.DataItem.EntidadRemision02%>
                    </ItemTemplate>
                </asp:TemplateColumn>  

                <asp:TemplateColumn HeaderText="Servicio Rem 02" >
                    <ItemTemplate>
                        <%#Container.DataItem.ServicioRemision02%>
                    </ItemTemplate>
                </asp:TemplateColumn>  


                <asp:TemplateColumn HeaderText="Fecha Rem 03" >
                    <ItemTemplate>
                        <%#Container.DataItem.FechaRemision03%>
                    </ItemTemplate>
                </asp:TemplateColumn>  

                <asp:TemplateColumn HeaderText="Fecha Rea 03" >
                    <ItemTemplate>
                        <%#Container.DataItem.FechaRealizado03%>
                    </ItemTemplate>
                </asp:TemplateColumn>  

                <asp:TemplateColumn HeaderText="Entidad Rem 03" >
                    <ItemTemplate>
                        <%#Container.DataItem.EntidadRemision03%>
                    </ItemTemplate>
                </asp:TemplateColumn>  

                <asp:TemplateColumn HeaderText="Servicio Rem 03" >
                    <ItemTemplate>
                        <%#Container.DataItem.ServicioRemision03%>
                    </ItemTemplate>
                </asp:TemplateColumn>  


            </Columns>
            <HeaderStyle BackColor="#1C5E55" Cssclass="DataGridHeaderStyle" Font-Bold="True"
                ForeColor="White" />
        </asp:DataGrid>    
    </div>
    </form>
</body>
</html>
