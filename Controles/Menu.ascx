<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Menu.ascx.vb" Inherits="Controles_Menu" %>

<telerik:RadMenu ID="Menu_Principal" Runat="server" Skin="Silk" 
    style="text-align: left" ResolvedRenderMode="Classic" >
    <Items>
        <telerik:RadMenuItem runat="server" Text="Inicio" NavigateUrl="~/Webforms/Principal.aspx" />
        
        <telerik:RadMenuItem runat="server" Text="Movimientos" Value= "Movimientos">
            <Items>
                <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/ProgramacionList.aspx" Text="Programaciones"></telerik:RadMenuItem>
                <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/ReProgramacionesList.aspx" Text="Reprogramaciones"> </telerik:RadMenuItem>
                
                <telerik:RadMenuItem runat="server" IsSeparator="True" Text="Root RadMenuItem8"></telerik:RadMenuItem>
                <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/Declaracion_IngresoList.aspx" Text="Registro Inicial"></telerik:RadMenuItem>
                <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/AsignacionesList.aspx" Text="Elegibilidad y Asignación"></telerik:RadMenuItem>
                <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/DeclaracionList.aspx" Text="Declaraciones"></telerik:RadMenuItem>
                <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/PersonasList.aspx" Text="Personas"></telerik:RadMenuItem>
                <telerik:RadMenuItem runat="server" IsSeparator="True" Text="Root RadMenuItem8"></telerik:RadMenuItem>                
                <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/Validar_Identificacion.aspx" Text="Validar Identificación"></telerik:RadMenuItem>
                <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/Entregas_AdicionalesList.aspx" Text="Entregas Especiales"></telerik:RadMenuItem>
                <telerik:RadMenuItem runat="server" IsSeparator="True" Text="Root RadMenuItem8"></telerik:RadMenuItem>
                <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/CierreProgramacionList.aspx" Text="Cierres de Programación"></telerik:RadMenuItem>
                
            </Items>
        </telerik:RadMenuItem>

        <telerik:RadMenuItem runat="server" Text="Inventarios">
            <Items>
                 <telerik:RadMenuItem runat="server" Text="Entradas de Mercancia" Value= "Entradas">
                   <Items>
                        <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/EntradasIIList.aspx?Refrescar=1" Text="Inventarios Iniciales" ToolTip="Inventarios Inciales">
                        </telerik:RadMenuItem>
                        <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/EntradasCompraList.aspx?Refrescar=1" Text="Por Orden de Compra" tooltip = "Compras de IRD">
                        </telerik:RadMenuItem>
                        <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/EntradasDonacionesList.aspx?Refrescar=1" Text="Por Donación"  ToolTip ="Ingresos de Donantes">
                        </telerik:RadMenuItem>
                        <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/EntradasDevolucionesList.aspx?Refrescar=1" Text="Por Reintegros" ToolTip="Reintegro de Proveedores">
                        </telerik:RadMenuItem>
                        <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/EntradasAjustesList.aspx?Refrescar=1" Text="Por Ajustes" >
                        </telerik:RadMenuItem>
                        <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/EntradasTrasladosList.aspx?Refrescar=1" Text="Por Traslados" >
                        </telerik:RadMenuItem>
                        <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/EntradasDevolucionesEntregaList.aspx?Refrescar=1" Text="Por Devoluciones en Entregas" >
                        </telerik:RadMenuItem>

                        
                   </Items>
                </telerik:RadMenuItem> 

                 <telerik:RadMenuItem runat="server" Text="Salidas de Mercancia" Value= "Salidas">
                   <Items>
                        <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/SalidasEntregasList.aspx?Refrescar=1" Text="Por Entregas de Ayuda " ToolTip="Entregas de Alimentos">
                        </telerik:RadMenuItem>
                        <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/SalidasDonacionesList.aspx?Refrescar=1" Text="Por Donaciones" tooltip = "Donaciones de IRD">
                        </telerik:RadMenuItem>
                        <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/SalidasDevolucionesList.aspx?Refrescar=1" Text="Por Devoluciones" ToolTip="Devoluciones a Proveedores">
                        </telerik:RadMenuItem>
                        <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/SalidasAjustesList.aspx?Refrescar=1" Text="Por Ajustes" >
                        </telerik:RadMenuItem>
                        <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/SalidasTrasladosList.aspx?Refrescar=1" Text="Por Traslados" >
                        </telerik:RadMenuItem>
                   </Items>
                </telerik:RadMenuItem>  
                              
                 <telerik:RadMenuItem runat="server" Text="Aprobaciones Ajustes">
                    <Items>
                        <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/SalidasAjustesAprobarList.aspx?TA=1&amp;Refrescar=1" Text="Log&#237;stica y Servicios " ToolTip="Oficial de Logística" Enabled ="False">
                        </telerik:RadMenuItem>
                        <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/SalidasAjustesAprobarList.aspx?TA=2&amp;Refrescar=1" Text="Finanzas y Adm. Regional " ToolTip="Oficial de Finanzas" Enabled ="False">
                        </telerik:RadMenuItem>
                        <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/SalidasAjustesAprobarList.aspx?TA=3&amp;Refrescar=1" Text="Coordinación de Logística " ToolTip="Coordinador Logística" Enabled ="False">
                        </telerik:RadMenuItem>
                        <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/SalidasAjustesAprobarList.aspx?TA=4&amp;Refrescar=1" Text="Coodinador Regional" ToolTip="Coordinaci&#243;n de la Regional" Enabled ="False">
                        </telerik:RadMenuItem>
                        <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/SalidasAjustesAprobarList.aspx?TA=5&amp;Refrescar=1" Text="Operaciones / M&amp;E " ToolTip="Director de Operaciones" Enabled ="False">
                        </telerik:RadMenuItem>
                        <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/SalidasAjustesAprobarList.aspx?TA=6&amp;Refrescar=1" Text="Direcci&#243;n Financiera" ToolTip="Administrac&#243;n y Finanzas Central" Enabled ="False">
                        </telerik:RadMenuItem>
                    </Items>
                </telerik:RadMenuItem>
                
                 <telerik:RadMenuItem runat="server" IsSeparator="True" 
                     Text="Root RadMenuItem12">
                 </telerik:RadMenuItem>
                <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/RacionesList.aspx" Text="Raciones" ToolTip="Sistema de Raciones"/>
                
                <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/TmpInventariosList.aspx" Text="Saldos de Inventarios" ToolTip="Saldos de Inventarios"/>
                <telerik:RadMenuItem runat="server" Text="Consultas e Informes">
                    <Items>
                        <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/PlanillaList.aspx" Text="Planillas de Entrega" ToolTip="Planillas de Programación"/>
                        <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/LegalizacionList.aspx" Text="Legalización de Planillas" ToolTip="Legalización de Ayuda Humanitaria">
                        </telerik:RadMenuItem>
                    </Items>  
                </telerik:RadMenuItem> 
            </Items>
        </telerik:RadMenuItem>

        <telerik:RadMenuItem runat="server" Text="Sistema de Salud">
            <Items>
                <telerik:RadMenuItem runat="server" Text="Niños Menores" NavigateUrl="~/Webforms/SaludList.aspx" Tooltip ="Seguimiento a Ni&#241;os Menores de 5 A&#241;os"/>
                <telerik:RadMenuItem runat="server" Text="Gestantes" NavigateUrl="~/Webforms/GestantesList.aspx?Refrescar=1"/>
                <telerik:RadMenuItem runat="server" Text="Regimen de Salud" NavigateUrl="~/Webforms/Personas_Regimen_SaludList.aspx?Refrescar=1" Tooltip="Seguimiento a Regimen de Salud"/>
            </Items>
        </telerik:RadMenuItem>

        <telerik:RadMenuItem runat="server" Text="Educación">
            <Items>
                <telerik:RadMenuItem runat="server" Text="Niños en Edad Escolar" NavigateUrl ="~/Webforms/Personas_EducacionList.aspx" tooltip="Seguimiento a niños de 6 a 17 años"/>
            </Items>
        </telerik:RadMenuItem>

        <telerik:RadMenuItem runat="server" Text="Psicosocial">
            <Items>
                <telerik:RadMenuItem runat="server" Text="Estado Emocional" NavigateUrl ="~/Webforms/DeclaracionPsicosocialList.aspx" tooltip="Información Emocional De Encuestados"/>
            </Items>
        </telerik:RadMenuItem>


        <telerik:RadMenuItem runat="server" Text="Monitoreo">
            <Items>
                <telerik:RadMenuItem runat="server" Text="Totales por Grupos" NavigateUrl="~/Webforms/ConsultaTotalesList.aspx"/>
                <telerik:RadMenuItem runat="server" Text="Tipos de Familia" NavigateUrl="~/Webforms/ConsultaPorTiposFamilia.aspx"/>
                <telerik:RadMenuItem runat="server" Text="Root RadMenuItem9" IsSeparator="True"/>
                <telerik:RadMenuItem runat="server" Text="Estados Generales" NavigateUrl="~/Webforms/Declaracion_EstadosList.aspx" /> 
                <telerik:RadMenuItem runat="server" Text="Unidades de Apoyo" NavigateUrl="~/Webforms/Declaracion_UnidadesList.aspx"/>
                
            </Items>
        </telerik:RadMenuItem>

        <telerik:RadMenuItem runat="server" Text="Tablas de Apoyo">
            <Items>
                <telerik:RadMenuItem runat="server" Text="Bodegas" 
                    NavigateUrl="~/Webforms/BodegasList.aspx"/>
                <telerik:RadMenuItem runat="server"  
                    NavigateUrl="~/Webforms/TrimestralList.aspx" Owner="" Text="Trimestrales">
                </telerik:RadMenuItem>

                <telerik:RadMenuItem runat="server" Text="Root RadMenuItem12" 
                    IsSeparator="True">
                </telerik:RadMenuItem>
                <telerik:RadMenuItem runat="server" Text="Sucursales / Regionales" NavigateUrl="~/Webforms/RegionalesList.aspx"/>
                <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/LugaresEntregaList.aspx" Text="Lugares de Entrega"/>
                <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/ConcejosList.aspx" Owner="" Text="Concejos y Resguardos"/>
                <telerik:RadMenuItem runat="server" Text="Root RadMenuItem12" 
                    IsSeparator="True"/>

                <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/GruposList.aspx" 
                    Owner="" Text="Grupos de Atención">
                </telerik:RadMenuItem>

                <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/ProgramacionList.aspx" Text="Programaciones"></telerik:RadMenuItem>

            </Items>
        </telerik:RadMenuItem>

        <telerik:RadMenuItem runat="server" IsSeparator="True" 
            Text="Root RadMenuItem10">
        </telerik:RadMenuItem>
        <telerik:RadMenuItem runat="server" NavigateUrl="~/Login.aspx" 
            Text="Cerrar Sesion">
        </telerik:RadMenuItem>

    </Items>
</telerik:RadMenu>