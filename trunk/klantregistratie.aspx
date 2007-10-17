<%@ Page Language="vb" AutoEventWireup="false" aspcompat="true" Inherits="css.klantregistratie" CodeFile="klantregistratie.aspx.vb" %>
<%@ import Namespace="System.data.sqlclient"%>
<%@ Import Namespace="System.Data" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>CSS - Computer Sales & Services - Registratie</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			-+
			<TABLE id="pagina" cellSpacing="0" cellPadding="0" width="1003" border="0">
				<TR>
					<TD style="WIDTH: 177px" width="159" background="img_bg/logo.gif" height="153"></TD>
					<TD style="WIDTH: 591px" vAlign="bottom" align="center" width="574" background="img_bg/logo_text.gif"
						height="153"><asp:label id="lblFout" runat="server" Width="498px" BackColor="Transparent" ForeColor="Red"
							Height="40px" Visible="False" Font-Bold="True" Font-Size="Medium">foutmelding</asp:label></TD>
					<TD vAlign="top" width="235" height="153">
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
											<td align="center" colSpan="2"><asp:button id="cmdLogin" runat="server" ForeColor="#5D5D5B" Font-Bold="True" Text="Login" CausesValidation="False"></asp:button></td>
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
									<P align="left"><asp:imagebutton id="Imgbuthome" runat="server" ImageUrl="img_nav/navleft_01.gif" CausesValidation="False"></asp:imagebutton></P>
								</TD>
							</TR>
							<TR>
								<TD><asp:imagebutton id="Imgbutinfo" runat="server" ImageUrl="img_nav/navleft_02.gif" CausesValidation="False"></asp:imagebutton></TD>
							</TR>
							<TR>
								<TD><asp:imagebutton id="Imgbutproducten" runat="server" ImageUrl="img_nav/navleft_03.gif" CausesValidation="False"></asp:imagebutton></TD>
							</TR>
							<TR>
								<TD><asp:imagebutton id="Imgbutpromoties" runat="server" ImageUrl="img_nav/navleft_04.gif" CausesValidation="False"></asp:imagebutton></TD>
							</TR>
							<TR>
								<TD><asp:imagebutton id="Imgbutcontact" runat="server" ImageUrl="img_nav/navleft_05.gif" CausesValidation="False"></asp:imagebutton></TD>
							</TR>
							<TR>
								<TD><asp:imagebutton id="Imgbutorderstatus" runat="server" ImageUrl="img_nav/navleft_06.gif" CausesValidation="False"
										Visible="False"></asp:imagebutton></TD>
							</TR>
							<TR>
								<TD><asp:imagebutton id="Imgbutherstelling" runat="server" ImageUrl="img_nav/navleft_07.gif" CausesValidation="False"
										Visible="False"></asp:imagebutton></TD>
							</TR>
							<TR>
								<TD><asp:imagebutton id="Imgbutsupport" runat="server" ImageUrl="img_nav/navleft_08.gif" CausesValidation="False"
										Visible="False"></asp:imagebutton></TD>
							</TR>
							<tr>
								<td align="left"><br>
									<font size="-1">
										<asp:label id="lblGebruikersnaam" runat="server" Width="128px" BackColor="Transparent" Height="46px"
											Visible="False" Font-Bold="True">Label</asp:label></font></td>
							</tr>
							<tr>
								<td align="left">&nbsp;&nbsp;&nbsp;&nbsp;<asp:button id="cmdLogout" runat="server" Width="64px" Visible="False" Text="Log uit"></asp:button></td>
							</tr>
						</TABLE>
					</TD>
					<TD vAlign="top" align="center" colSpan="2" rowSpan="2">
						<TABLE id="paginainhoud" cellSpacing="0" cellPadding="0" border="0">
							<TR height="40">
								<TD vAlign="top" align="center" colSpan="2"><b>Registreer</b><br>
									<br>
									<table>
										<tr>
											<td align="left"><asp:validationsummary id="mySummary" HeaderText="Volgende fouten zijn opgetreden:" Runat="server" EnableClientScript="true"></asp:validationsummary></td>
										</tr>
									</table>
								</TD>
							</TR>
							<tr height="40">
								<td style="WIDTH: 286px">
									<b>Naam:</b>
								*
								<td><asp:textbox id="txtnaam" runat="server" ForeColor="#5D5D5B" BackColor="White" BorderColor="#5D5D5B"
										BorderWidth="1px"></asp:textbox><asp:requiredfieldvalidator id="RequiredFieldValidator1" runat="server" Text="*" ControlToValidate="txtnaam"
										ErrorMessage="Geen naam ingegeven"></asp:requiredfieldvalidator></td>
							</tr>
							<tr height="40">
								<td style="WIDTH: 286px">
									<b>Voornaam:</b>
								*
								<td style="WIDTH: 319px"><asp:textbox id="txtvoornaam" runat="server" ForeColor="#5D5D5B" BackColor="White" BorderColor="#5D5D5B"
										BorderWidth="1px"></asp:textbox><asp:requiredfieldvalidator id="Requiredfieldvalidator2" runat="server" Text="*" ControlToValidate="txtvoornaam"
										ErrorMessage="Geen voornaam ingegeven"></asp:requiredfieldvalidator></td>
							</tr>
							<tr height="40">
								<td style="WIDTH: 286px">
									<b>Gebruikersnaam:</b>
								*
								<td style="WIDTH: 319px"><asp:textbox id="txtgebruikersnaam" runat="server" ForeColor="#5D5D5B" BackColor="White" BorderColor="#5D5D5B"
										BorderWidth="1px"></asp:textbox><asp:requiredfieldvalidator id="Requiredfieldvalidator3" runat="server" Text="*" ControlToValidate="txtgebruikersnaam"
										ErrorMessage="Geen gebruikersnaam ingegeven"></asp:requiredfieldvalidator></td>
							</tr>
							<tr height="40">
								<td style="WIDTH: 286px">
									<b>Paswoord:</b>
								*
								<td style="WIDTH: 319px"><asp:textbox id="txtwachtwoord" runat="server" TextMode="Password" ForeColor="#5D5D5B" BackColor="White"
										BorderColor="#5D5D5B" BorderWidth="1px"></asp:textbox><asp:requiredfieldvalidator id="Requiredfieldvalidator4" runat="server" Text="*" ControlToValidate="txtwachtwoord"
										ErrorMessage="Geen paswoord ingegeven"></asp:requiredfieldvalidator></td>
							</tr>
							<tr height="40">
								<td style="WIDTH: 286px">
									<b>Paswoord bevestigen:</b>
								*
								<td style="WIDTH: 319px"><asp:textbox id="txtwachtwoord2" runat="server" TextMode="Password" ForeColor="#5D5D5B" BackColor="White"
										BorderColor="#5D5D5B" BorderWidth="1px"></asp:textbox><asp:requiredfieldvalidator id="Requiredfieldvalidator5" runat="server" Text="*" ControlToValidate="txtwachtwoord2"
										ErrorMessage="Geen bevestigend paswoord ingegeven"></asp:requiredfieldvalidator></td>
							</tr>
							<tr height="40">
								<td style="WIDTH: 286px">
									<b>Straat / nummer:</b>
								*
								<td style="WIDTH: 319px"><asp:textbox id="txtstraat" runat="server" Width="195px" ForeColor="#5D5D5B" BackColor="White"
										BorderColor="#5D5D5B" BorderWidth="1px"></asp:textbox><asp:requiredfieldvalidator id="Requiredfieldvalidator6" runat="server" Text="*" ControlToValidate="txtstraat"
										ErrorMessage="Geen straat ingegeven"></asp:requiredfieldvalidator>&nbsp;
									<asp:textbox id="txtnummer" runat="server" Width="34px" ForeColor="#5D5D5B" BackColor="White"
										BorderColor="#5D5D5B" BorderWidth="1px"></asp:textbox><asp:requiredfieldvalidator id="Requiredfieldvalidator7" runat="server" Text="*" ControlToValidate="txtnummer"
										ErrorMessage="Geen straatnummer ingegeven"></asp:requiredfieldvalidator></td>
							</tr>
							<tr height="40">
								<td style="WIDTH: 286px">
									<b>Gemeente / postcode:</b>
								*
								<td style="WIDTH: 319px"><asp:textbox id="txtgemeente" runat="server" Width="176px" ForeColor="#5D5D5B" BackColor="White"
										BorderColor="#5D5D5B" BorderWidth="1px"></asp:textbox><asp:requiredfieldvalidator id="Requiredfieldvalidator8" runat="server" Text="*" ControlToValidate="txtgemeente"
										ErrorMessage="Geen gemeente ingegeven"></asp:requiredfieldvalidator>&nbsp;
									<asp:textbox id="txtpostcode" runat="server" Width="55px" ForeColor="#5D5D5B" BackColor="White"
										BorderColor="#5D5D5B" BorderWidth="1px"></asp:textbox><asp:requiredfieldvalidator id="Requiredfieldvalidator9" runat="server" Text="*" ControlToValidate="txtpostcode"
										ErrorMessage="Geen postcode ingegeven"></asp:requiredfieldvalidator></td>
							</tr>
							<tr height="40">
								<td style="WIDTH: 286px">
									<b>Telefoonnummer:</b>
								<td style="WIDTH: 319px"><asp:textbox id="txttelefoonnummer" runat="server" Width="120px" ForeColor="#5D5D5B" BackColor="White"
										BorderColor="#5D5D5B" BorderWidth="1px"></asp:textbox></td>
							</tr>
							<tr height="40">
								<td style="WIDTH: 286px">
									<b>Fax:</b>
								<td style="WIDTH: 319px"><asp:textbox id="txtfax" runat="server" Width="120px" ForeColor="#5D5D5B" BackColor="White" BorderColor="#5D5D5B"
										BorderWidth="1px"></asp:textbox></td>
							</tr>
							<tr height="40">
								<td style="WIDTH: 286px">
									<b>e-mailadres:</b>
								*
								<td style="WIDTH: 319px"><asp:textbox id="txtmail" runat="server" Width="176px" ForeColor="#5D5D5B" BackColor="White"
										BorderColor="#5D5D5B" BorderWidth="1px"></asp:textbox>

								</td>
							</tr>
							<tr height="40">
								<td style="WIDTH: 286px">
									<b>e-mailadres (bevestiging):</b>
								*
								<td style="WIDTH: 319px"><asp:textbox id="txtmail2" runat="server" Width="176px" ForeColor="#5D5D5B" BackColor="White"
										BorderColor="#5D5D5B" BorderWidth="1px"></asp:textbox><asp:requiredfieldvalidator id="Requiredfieldvalidator11" runat="server" Text="*" ControlToValidate="txtmail"
										ErrorMessage="Geen e-mailadres ingegeven ter bevestiging"></asp:requiredfieldvalidator></td>
							</tr>
							<tr height="40">
								<td style="WIDTH: 286px">
									<b>BTW-nummer:</b>
								<td style="WIDTH: 319px"><asp:textbox id="txtbtw" runat="server" Width="120px" ForeColor="#5D5D5B" BackColor="White" BorderColor="#5D5D5B"
										BorderWidth="1px"></asp:textbox></td>
							</tr>
							<tr height="40">
								<td style="WIDTH: 319px" align="center" colSpan="2"><asp:button id="cmdSubmit" runat="server" ForeColor="#5D5D5B" Font-Bold="True" Text="Submit"></asp:button></td>
							</tr>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 159px" background="img_bg/nav_left_o.gif" height="260"></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 34px" align="center" colSpan="3">
						<hr>
						<b>Copyright &copy;2005 by webmaster&nbsp;<A href="mailto:&#118;&#101;&#114;&#118;&#111;&#111;&#114;&#116;&#64;&#112;&#097;&#110;&#100;&#111;&#114;&#097;&#46;&#098;&#101;">Gwen Vervoort</A></b>
					</TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
