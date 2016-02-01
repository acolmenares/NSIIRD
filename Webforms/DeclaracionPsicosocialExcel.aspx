<%@ Page Language="VB" AutoEventWireup="false" CodeFile="DeclaracionPsicosocialExcel.aspx.vb" Inherits="WebForms_DeclaracionPsicosocialExcel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
		<telerik:RadScriptManager ID="RadScriptManager2" Runat="server">
        </telerik:RadScriptManager>
 		<telerik:RadGrid ID="Rg_Listado" runat="server" GridLines="None" Skin="WebBlue" Width="100%"  
            AutoGenerateColumns="False" ShowStatusBar="True" TabIndex="6" PageSize="20" CellSpacing="0">
            <AlternatingItemStyle BackColor="White" Cssclass="DataGridAlternatingItemStyle" />
            <ItemStyle BackColor="#E3EAEB" Cssclass="DataGridItemStyle" />
            <MasterTableView  NoDetailRecordsText="No hay informaci&#243;n." NoMasterRecordsText="No hay informaci&#243;n." DataKeyNames="Id" >
                <Columns> 
                    <telerik:GridBoundColumn DataField="Id" DataType="System.Int32" HeaderText="Id" ReadOnly="True"
                        SortExpression="Id" UniqueName="Id"  Visible ="True" >
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Fecha_Valoracion" DataType="System.DateTime" HeaderText="Fecha Atención"
                        DataFormatString="{0:dd/MMM/yyyy}"  UniqueName="Fecha_Valoracion">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

					<telerik:GridBoundColumn DataField="Regional" HeaderText="Regional"  UniqueName="Regional" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 
  
  					<telerik:GridBoundColumn DataField="Lugar_entrega" HeaderText="Lugar Entrega"  UniqueName="Lugar_entrega" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

  					<telerik:GridBoundColumn DataField="Primer_Nombre" HeaderText="Primer Nombre"  UniqueName="Primer_Nombre" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

  					<telerik:GridBoundColumn DataField="Primer_Apellido" HeaderText="Primer Apellido"  UniqueName="Primer_Apellido" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

  					<telerik:GridBoundColumn DataField="Identificacion" HeaderText="Identificación"  UniqueName="Identificacion" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

  					<telerik:GridBoundColumn DataField="Declaracion.EstadoAccionSocial" HeaderText="Unidad Victimas"  UniqueName="Declaracion.EstadoAccionSocial" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

                    

  					<telerik:GridBoundColumn DataField="Emociones" HeaderText="Emociones"  UniqueName="Emociones" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

  					<telerik:GridBoundColumn DataField="TipoFamilia" HeaderText="Tipo Familia"  UniqueName="TipoFamilia" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

  					<telerik:GridBoundColumn DataField="YoMuertoPE" HeaderText="YoMuertoPE"  UniqueName="YoMuertoPE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="YoNoDormirPE" HeaderText="YoNoDormirPE"  UniqueName="YoNoDormirPE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="YoApetitoPE" HeaderText="YoApetitoPE"  UniqueName="YoApetitoPE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="YoMiedoPE" HeaderText="YoMiedoPE"  UniqueName="YoMiedoPE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="YoVenganzaPE" HeaderText="YoVenganzaPE"  UniqueName="YoVenganzaPE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="YoCulpaPE" HeaderText="YoCulpaPE"  UniqueName="YoCulpaPE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="YoRelFamiPE" HeaderText="YoRelFamiPE"  UniqueName="YoRelFamiPE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="YoTristezaPE" HeaderText="YoTristezaPE"  UniqueName="YoTristezaPE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="YoRabiaPE" HeaderText="YoRabiaPE"  UniqueName="YoRabiaPE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="YoDolorCabezaPE" HeaderText="YoDolorCabezaPE"  UniqueName="YoDolorCabezaPE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="YoDolorEstomagoPE" HeaderText="YoDolorEstomagoPE"  UniqueName="YoDolorEstomagoPE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="YoRelComuPE" HeaderText="YoRelComuPE"  UniqueName="YoRelComuPE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>

  					<telerik:GridBoundColumn DataField="FamMuertoPE" HeaderText="FamMuertoPE"  UniqueName="FamMuertoPE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>  
  					<telerik:GridBoundColumn DataField="FamNoDormirPE" HeaderText="FamNoDormirPE"  UniqueName="FamNoDormirPE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="FamApetitoPE" HeaderText="FamApetitoPE"  UniqueName="FamApetitoPE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="FamMiedoPE" HeaderText="FamMiedoPE"  UniqueName="FamMiedoPE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="FamVenganzaPE" HeaderText="FamVenganzaPE"  UniqueName="FamVenganzaPE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 
  					<telerik:GridBoundColumn DataField="FamCulpaPE" HeaderText="FamCulpaPE"  UniqueName="FamCulpaPE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>  
  					<telerik:GridBoundColumn DataField="FamRelFamiPE" HeaderText="FamRelFamiPE"  UniqueName="FamRelFamiPE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>  
  					<telerik:GridBoundColumn DataField="FamTristezaPE" HeaderText="FamTristezaPE"  UniqueName="FamTristezaPE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="FamRabiaPE" HeaderText="FamRabiaPE"  UniqueName="FamRabiaPE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="FamDolorCabezaPE" HeaderText="FamDolorCabezaPE"  UniqueName="FamDolorCabezaPE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="FamDolorEstomagoPE" HeaderText="FamDolorEstomagoPE"  UniqueName="FamDolorEstomagoPE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="FamRelComuPE" HeaderText="FamRelComuPE"  UniqueName="FamRelComuPE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>  

  					<telerik:GridBoundColumn DataField="FamiliarPE" HeaderText="FamiliarPE"  UniqueName="FamiliarPE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>  
  					<telerik:GridBoundColumn DataField="VecinoPE" HeaderText="VecinoPE"  UniqueName="VecinoPE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>      
  					<telerik:GridBoundColumn DataField="AyudaEspiritualPE" HeaderText="AyudaEspiritualPE"  UniqueName="AyudaEspiritualPE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>  
  					<telerik:GridBoundColumn DataField="FunSaludPE" HeaderText="FunSaludPE"  UniqueName="FunSaludPE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>   
  					<telerik:GridBoundColumn DataField="OrgVictimasPE" HeaderText="OrgVictimasPE"  UniqueName="OrgVictimasPE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 

                    <telerik:GridBoundColumn DataField="PrimeraEntregaIndice" DataType="System.DateTime" HeaderText="Indice PE" HeaderTooltip ="Indice de Primera Entrega"
                        DataFormatString="{0:N4}" SortExpression="PrimeraEntregaIndice" UniqueName="PrimeraEntregaIndice">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
 

  					<telerik:GridBoundColumn DataField="YoMuertoSE" HeaderText="YoMuertoSE"  UniqueName="YoMuertoSE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="YoNoDormirSE" HeaderText="YoNoDormirSE"  UniqueName="YoNoDormirSE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="YoApetitoSE" HeaderText="YoApetitoSE"  UniqueName="YoApetitoSE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="YoMiedoSE" HeaderText="YoMiedoSE"  UniqueName="YoMiedoSE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="YoVenganzaSE" HeaderText="YoVenganzaSE"  UniqueName="YoVenganzaSE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="YoCulpaSE" HeaderText="YoCulpaSE"  UniqueName="YoCulpaSE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="YoRelFamiSE" HeaderText="YoRelFamiSE"  UniqueName="YoRelFamiSE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="YoTristezaSE" HeaderText="YoTristezaSE"  UniqueName="YoTristezaSE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="YoRabiaSE" HeaderText="YoRabiaSE"  UniqueName="YoRabiaSE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="YoDolorCabezaSE" HeaderText="YoDolorCabezaSE"  UniqueName="YoDolorCabezaSE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="YoDolorEstomagoSE" HeaderText="YoDolorEstomagoSE"  UniqueName="YoDolorEstomagoSE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="YoRelComuSE" HeaderText="YoRelComuSE"  UniqueName="YoRelComuSE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>


  					<telerik:GridBoundColumn DataField="FamMuertoSE" HeaderText="FamMuertoSE"  UniqueName="FamMuertoSE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>  
  					<telerik:GridBoundColumn DataField="FamNoDormirSE" HeaderText="FamNoDormirSE"  UniqueName="FamNoDormirSE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="FamApetitoSE" HeaderText="FamApetitoSE"  UniqueName="FamApetitoSE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="FamMiedoSE" HeaderText="FamMiedoSE"  UniqueName="FamMiedoSE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="FamVenganzaSE" HeaderText="FamVenganzaSE"  UniqueName="FamVenganzaSE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn> 
  					<telerik:GridBoundColumn DataField="FamCulpaSE" HeaderText="FamCulpaSE"  UniqueName="FamCulpaSE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>  
  					<telerik:GridBoundColumn DataField="FamRelFamiSE" HeaderText="FamRelFamiSE"  UniqueName="FamRelFamiSE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>  
  					<telerik:GridBoundColumn DataField="FamTristezaSE" HeaderText="FamTristezaSE"  UniqueName="FamTristezaSE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="FamRabiaSE" HeaderText="FamRabiaSE"  UniqueName="FamRabiaSE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="FamDolorCabezaSE" HeaderText="FamDolorCabezaSE"  UniqueName="FamDolorCabezaSE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="FamDolorEstomagoSE" HeaderText="FamDolorEstomagoSE"  UniqueName="FamDolorEstomagoSE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>
  					<telerik:GridBoundColumn DataField="FamRelComuSE" HeaderText="FamRelComuSE"  UniqueName="FamRelComuSE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>  


  					<telerik:GridBoundColumn DataField="FamiliarSE" HeaderText="FamiliarSE"  UniqueName="FamiliarSE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>  
  					<telerik:GridBoundColumn DataField="VecinoSE" HeaderText="VecinoSE"  UniqueName="VecinoSE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>      
  					<telerik:GridBoundColumn DataField="AyudaEspiritualSE" HeaderText="AyudaEspiritualSE"  UniqueName="AyudaEspiritualSE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>  
  					<telerik:GridBoundColumn DataField="FunSaludSE" HeaderText="FunSaludSE"  UniqueName="FunSaludSE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>   
  					<telerik:GridBoundColumn DataField="OrgVictimasSE" HeaderText="OrgVictimasSE"  UniqueName="OrgVictimasSE" >
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>                     

                    <telerik:GridBoundColumn DataField="SegundaEntregaIndice" DataType="System.DateTime" HeaderText="Indice SE" HeaderTooltip ="Indice de Segunda Entrega"
                        DataFormatString="{0:N4}" SortExpression="SegundaEntregaIndice" UniqueName="SegundaEntregaIndice">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                    </telerik:GridBoundColumn>   


                                                                              
                </Columns>
            </MasterTableView>
        </telerik:RadGrid>    
    </div>
    </form>
</body>
</html>
