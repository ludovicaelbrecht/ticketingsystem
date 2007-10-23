<%@ Import Namespace="System.Data" %>
<%@ import Namespace="System.data.sqlclient"%>
<%@ Page Language="vb" AutoEventWireup="false" aspcompat="true" Inherits="css.support" CodeFile="support.aspx.vb" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>CSS - Computer Sales & Services - Support</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<TABLE id="pagina" cellSpacing="0" cellPadding="0" width="1003" border="0">
				<TR>
					<TD style="WIDTH: 177px; HEIGHT: 129px" width="159" background="img_bg/logo.gif" height="129"></TD>
					<TD style="WIDTH: 591px; HEIGHT: 129px" vAlign="bottom" align="center" width="574" background="img_bg/logo_text.gif"
						height="129"><asp:label id="lblFout" runat="server" Width="498px" BackColor="Transparent" ForeColor="Red"
							Height="40px" Visible="False" Font-Bold="True" Font-Size="Medium">foutmelding</asp:label></TD>
					<TD style="HEIGHT: 132px" vAlign="top" width="235" height="132">
						<TABLE id="navboven" style="WIDTH: 235px; HEIGHT: 120px" cellSpacing="0" cellPadding="0"
							width="233" background="img_bg/nav_boven.gif" border="0">
							<TR>
								<TD style="HEIGHT: 74px" align="right" width="233" background="img_bg/nav_boven.gif"
									colSpan="3">
									<TABLE id="login" style="WIDTH: 187px; HEIGHT: 72px" cellSpacing="0" cellPadding="0" width="187"
										align="right" border="0">
										<TR>
											<TD style="WIDTH: 42px" vAlign="baseline" align="right">&nbsp;
												<asp:label id="lblAccount" runat="server" Height="16px" BackColor="Transparent" Width="70px"
													Font-Italic="True">Account:</asp:label></TD>
											<TD style="HEIGHT: 8px"><asp:textbox id="Txtaccount" runat="server" ForeColor="#5D5D5B" BackColor="#F9AB14" Width="90px"></asp:textbox></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 42px" vAlign="baseline" align="right"><asp:label id="lblPaswoord" runat="server" BackColor="Transparent" Width="70px" Font-Italic="True">Paswoord:</asp:label></TD>
											<TD><asp:textbox id="Txtpaswoord" runat="server" ForeColor="#5D5D5B" BackColor="#F9AB14" Width="90px"
													TextMode="Password"></asp:textbox></TD>
										</TR>
										<tr>
											<td align="center">
												<asp:button id="cmdLogin" tabIndex="3" runat="server" ForeColor="#5D5D5B" Font-Bold="True" Text="Login"></asp:button>
											</td>
											<td align="center">
												<asp:button id="cmdRegistreer" tabIndex="4" runat="server" Width="76px" ForeColor="#5D5D5B"
													Font-Bold="True" Text="Registreer"></asp:button>
											</td>
										</tr>
									</TABLE>
								</TD>
							</TR>
							<TR>
								<TD style="HEIGHT: 79px" vAlign="top" align="left"><a class="rechtsBoven" href="contact.aspx">&nbsp;&nbsp;&nbsp;&nbsp;Contact</a></TD>
								<TD style="HEIGHT: 79px" vAlign="top" align="right"><a class="rechtsBoven" href="producten.aspx">Producten&nbsp;&nbsp;&nbsp;&nbsp;</a></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 159px; HEIGHT: 463px" vAlign="top" width="159" background="img_bg/nav_left.gif">
						<TABLE id="navlinks" cellSpacing="0" cellPadding="0" width="177" border="0">
							<TR>
								<TD>
									<P>&nbsp;</P>
									<P>&nbsp;</P>
									<P align="left"><asp:imagebutton id="Imgbuthome" runat="server" ImageUrl="img_nav/navleft_01.gif"></asp:imagebutton></P>
								</TD>
							</TR>
							<TR>
								<TD><asp:imagebutton id="Imgbutinfo" runat="server" ImageUrl="img_nav/navleft_02.gif"></asp:imagebutton></TD>
							</TR>
							<TR>
								<TD><asp:imagebutton id="Imgbutproducten" runat="server" ImageUrl="img_nav/navleft_03.gif"></asp:imagebutton></TD>
							</TR>
							<TR>
								<TD><asp:imagebutton id="Imgbutpromoties" runat="server" ImageUrl="img_nav/navleft_04.gif"></asp:imagebutton></TD>
							</TR>
							<TR>
								<TD><asp:imagebutton id="Imgbutcontact" runat="server" ImageUrl="img_nav/navleft_05.gif"></asp:imagebutton></TD>
							</TR>
							<TR>
								<TD><asp:imagebutton id="Imgbutorderstatus" runat="server" ImageUrl="img_nav/navleft_06.gif" Visible="False"></asp:imagebutton></TD>
							</TR>
							<TR>
								<TD><asp:imagebutton id="Imgbutherstelling" runat="server" ImageUrl="img_nav/navleft_07.gif" Visible="False"></asp:imagebutton></TD>
							</TR>
							<TR>
								<TD><asp:imagebutton id="Imgbutsupport" runat="server" Visible="True" ImageUrl="img_nav/over/navleft_over_08.gif"></asp:imagebutton></TD>
							</TR>
							<TR>
								<TD><asp:imagebutton id="Imgbutoverzicht" runat="server" Visible="true" ImageUrl="img_nav/navleft_09.gif"></asp:imagebutton></TD>
							</TR>
							<tr>
								<td align="left"><br>
									<font size="-1">
										<asp:label id="lblGebruikersnaam" runat="server" Width="128px" BackColor="Transparent" Height="46px"
											Visible="False" Font-Bold="True">Label</asp:label></font></td>
							</tr>
							<tr>
								<td align="left">&nbsp;&nbsp;&nbsp;&nbsp;<asp:button id="cmdLogout" runat="server" Width="64px" ForeColor="#5D5D5B" Visible="False" Font-Bold="True"
										Text="Log uit"></asp:button></td>
							</tr>
						</TABLE>
					</TD>
					<TD vAlign="top" align="center" colSpan="2" rowSpan="3">
						<TABLE id="paginainhoud" cellSpacing="0" cellPadding="0" width="792" border="0">
							<TR>
								<TD vAlign="top">
									<table align=center>
									<tr align=center> 	
										<td> <a href="http://www.acer.be"><img src=img/merken/acer.jpg border=0>   </a> <td>
										<td> <a href="http://www.amd.com"><img src=img/merken/amd.jpg border=0>   </a> <td>
										<td> <a href="http://www.aopen.com"><img src=img/merken/aopen.jpg border=0></a> <td>
									<tr align=center>	
										<td> <a href="http://www.asus.com"><img src=img/merken/asus.jpg border=0>   </a> <td>
										<td> <a href="http://www.ati.com"><img src=img/merken/ati.gif border=0>   </a> <td>
										<td> <a href="http://www.canon.be"><img src=img/merken/canon.jpg border=0>   </a> <td>
									<tr align=center>	
										<td> <a href="http://www.chieftec.com"><img src=img/merken/chieftec.jpg border=0>   </a> <td>
										<td> <a href="http://www.coolermaster.com"><img src=img/merken/coolermaster.jpg border=0>   </a> <td>
										<td> <a href="http://www.creative.com"><img src=img/merken/creative.jpg border=0>   </a> <td>
									<tr align=center>	
										<td> <a href="http://www.hp.be"><img src=img/merken/hp.jpg border=0>   </a> <td>
										<td> <a href="http://www.intel.com"><img src=img/merken/intel.gif border=0>   </a> <td>
										<td> <a href="http://www.logitech.be"><img src=img/merken/logitech.jpg border=0>   </a> <td>
									<tr align=center>	
										<td> <a href="http://www.maxtor.com"><img src=img/merken/maxtor.jpg border=0>   </a> <td>
										<td> <a href="http://www.microsoft.be"><img src=img/merken/microsoft.jpg border=0>   </a> <td>
										<td> <a href="http://www.msi.be"><img src=img/merken/msi.jpg border=0>   </a> <td>
									<tr align=center>	
										<td> <a href="http://www.sony.be"><img src=img/merken/sony.gif border=0>   </a> <td>
										<td> <a href="http://www.wdc.com"><img src=img/merken/western.gif border=0>   </a> <td>
								</table>
								<br><br>
								<div align="center"><b>
									Indien u op zoek bent naar de allerlaatste drivers voor apparatuur van deze merken,
									<br>klik dan op het logo. U zal op hun website terecht komen.
								</b></div>
								</TD>
							</TR>
						</TABLE>
						<P>&nbsp;</P>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 159px" background="img_bg/nav_left_o.gif"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 159px; HEIGHT: 19px" background="img_bg/nav_left_o.gif"></TD>
				</TR>
				<TR>
					<TD align="center" colSpan="3">
						<hr>
						<b>Copyright &copy;2005 by webmaster&nbsp;<A href="mailto:&#118;&#101;&#114;&#118;&#111;&#111;&#114;&#116;&#64;&#112;&#097;&#110;&#100;&#111;&#114;&#097;&#46;&#098;&#101;">Gwen Vervoort</A></b>
					</TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
