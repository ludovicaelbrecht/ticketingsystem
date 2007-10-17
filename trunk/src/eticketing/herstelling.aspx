<%@ Import Namespace="System.Data" %>
<%@ import Namespace="System.data.sqlclient"%>
<%@ Page Language="vb" AutoEventWireup="false" aspcompat="true" Inherits="css.herstelling" CodeFile="herstelling.aspx.vb" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>CSS - Computer Sales &amp; Services - Herstellingen</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body link="red" alink="lime" vlink="red">
		<form id="Form1" method="post" runat="server">
			<TABLE id="pagina" cellSpacing="0" cellPadding="0" width="1003" border="0">
				<TR>
					<TD style="WIDTH: 177px" width="159" background="img_bg/logo.gif" height="153"></TD>
					<TD style="WIDTH: 591px" width="574" background="img_bg/logo_text.gif" height="153"></TD>
					<TD vAlign="top" width="235" height="153">
						<TABLE id="navboven" style="WIDTH: 235px; HEIGHT: 120px" cellSpacing="0" cellPadding="0"
							width="233" background="img_bg/nav_boven.gif" border="0">
							<TR>
								<TD style="HEIGHT: 74px" align="right" width="233" background="img_bg/nav_boven.gif"
									colSpan="3">
									<TABLE id="login" style="WIDTH: 187px; HEIGHT: 72px" cellSpacing="0" cellPadding="0" width="187"
										align="right" border="0">
										<TR>
											<TD style="WIDTH: 79px" align="right"><small>Account:</small>&nbsp;
											</TD>
											<TD><asp:textbox id="Txtaccount" runat="server" ForeColor="#5D5D5B" BackColor="#F9AB14" Width="90px"></asp:textbox></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 79px" align="right"><small>Paswoord:</small>&nbsp;
											</TD>
											<TD><asp:textbox id="Txtpaswoord" runat="server" ForeColor="#5D5D5B" BackColor="#F9AB14" Width="90px"
													TextMode="Password"></asp:textbox></TD>
										</TR>
										<tr>
											<td align="center" colSpan="2"><asp:button id="Button1" runat="server" ForeColor="#5D5D5B" Font-Bold="True" Text="Login"></asp:button></td>
										</tr>
									</TABLE>
								</TD>
							</TR>
							<TR>
								<style id="rechtsBoven" type="text/css">A:link { FONT-WEIGHT: bold; COLOR: #f9ab14; FONT-FAMILY: Arial; TEXT-DECORATION: none }
	A:visited { FONT-WEIGHT: bold; COLOR: #f9ab14; FONT-FAMILY: Arial; TEXT-DECORATION: none }
	A:hover { FONT-WEIGHT: bold; COLOR: #959594; FONT-FAMILY: Arial; TEXT-DECORATION: none }
	A:active { FONT-WEIGHT: bold; COLOR: #959594; FONT-FAMILY: Arial; TEXT-DECORATION: none }
								</style>
								<TD style="HEIGHT: 79px" valign="top"><a id="rechtsBoven" href="">Contact</a></TD>
								<TD style="HEIGHT: 79px" valign="top"><a id="rechtsBoven" href="">Status</a></TD>
								<TD style="HEIGHT: 79px" valign="top"><a id="rechtsBoven" href="">Producten</a></TD>
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
									<P align="left">
										<asp:ImageButton id="Imgbuthome" runat="server" ImageUrl="img_nav/navleft_01.gif"></asp:ImageButton></P>
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
								<TD><asp:imagebutton id="Imgbutorderstatus" runat="server" ImageUrl="img_nav/navleft_06.gif"></asp:imagebutton></TD>
							</TR>
							<TR>
								<TD><asp:imagebutton id="Imgbutherstelling" runat="server" ImageUrl="img_nav/over/navleft_over_07.gif"></asp:imagebutton></TD>
							</TR>
							<TR>
								<TD><asp:imagebutton id="Imgbutsupport" runat="server" ImageUrl="img_nav/navleft_08.gif"></asp:imagebutton></TD>
							</TR>
							<TR>
								<TD><asp:imagebutton id="Imgbutoverzicht" runat="server" Visible="true" ImageUrl="img_nav/navleft_09.gif"></asp:imagebutton></TD>
							</TR>
						</TABLE>
					</TD>
					<TD vAlign="top" align="center" colSpan="2" rowSpan="3" cellSpacing="0" cellPadding="0">
						<TABLE id="paginainhoud" cellSpacing="0" cellPadding="0" width="792" border="0">
							<TR>
								<TD vAlign="top" align="center">
									<H5 align="center">Herstellingen</H5>
									<P align="center">
										CSS verricht herstellingswerken van pc's, laptops en printers op gebied van 
										hard- en software.
									</P>
									<P><b>Tarieven:</b><BR>
										Eerste uur:<BR>
										Per begonnen kwartier:</P>
									<P>Maximum uurprijs alvorens te verwittigen:</P>
									<P>Deze prijzen zijn BTW-inbegrepen.</P>
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
