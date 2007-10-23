<%@ Import Namespace="System.Data" %>
<%@ import Namespace="System.data.sqlclient"%>
<%@ Page Language="vb" AutoEventWireup="false" aspcompat="true" Inherits="css.contact" CodeFile="contact.aspx.vb" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>CSS - Computer Sales & Services - Contacteren</title>
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
												<asp:label id="lblAccount" runat="server" Width="70px" BackColor="Transparent" Height="16px"
													Font-Italic="True">Account:</asp:label></TD>
											<TD style="HEIGHT: 8px"><asp:textbox id="Txtaccount" runat="server" Width="90px" BackColor="#F9AB14" ForeColor="#5D5D5B"></asp:textbox></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 42px" vAlign="baseline" align="right"><asp:label id="lblPaswoord" runat="server" Width="70px" BackColor="Transparent" Font-Italic="True">Paswoord:</asp:label></TD>
											<TD><asp:textbox id="Txtpaswoord" runat="server" Width="90px" BackColor="#F9AB14" ForeColor="#5D5D5B"
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
								<TD><asp:imagebutton id="Imgbutcontact" runat="server" ImageUrl="img_nav/over/navleft_over_05.gif"></asp:imagebutton></TD>
							</TR>
							<TR>
								<TD><asp:imagebutton id="Imgbutorderstatus" runat="server" Visible="False" ImageUrl="img_nav/navleft_06.gif"></asp:imagebutton></TD>
							</TR>
							<TR>
								<TD><asp:imagebutton id="Imgbutherstelling" runat="server" Visible="False" ImageUrl="img_nav/navleft_07.gif"></asp:imagebutton></TD>
							</TR>
							<TR>
								<TD><asp:imagebutton id="Imgbutsupport" runat="server" Visible="True" ImageUrl="img_nav/navleft_08.gif"></asp:imagebutton></TD>
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
								<TD vAlign="top" align="center">
									<H5 align="center">Hebt u vragen? Aarzel dan niet om ons te contacteren!</H5>
									<P align="center"><br>
										CSS nv
										<br>
										Aarschotsesteenweg 944
										<br>
										3012 Wilsele
										<br>
										Tel.: 016/44.72.53
										<br>
										FAX: 016/44.88.87
										<br>
										BTW: 422.626.822
										<br>
										E-mail: <A href="mailto:css@scarlet.be">css@ping.be</A>
									</P>
									<br>
									<img src="img/plan.jpg">
									<P align="center">&nbsp;</P>
									<H5 align="center">Openingsuren:</H5>
									Zo en ma gesloten
									<br>
									di t/m za:
									<br>
									9.00 - 12.00
									<br>
									13.00 - 18.00
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
					<TD style="WIDTH: 159px; HEIGHT: 350px" background="img_bg/nav_left_o.gif"></TD>
				</TR>
				<TR>
					<TD align="center" colSpan="3">
						<hr>
						<b>Copyright ©2005 by webmaster&nbsp;<A href="mailto:vervoort@pandora.be">Gwen Vervoort</A></b>
					</TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
