<%@ Import Namespace="System.Data" %>
<%@ import Namespace="System.data.sqlclient"%>
<%@ Page Language="vb" AutoEventWireup="false" aspcompat="true" Inherits="css.winkel" CodeFile="winkel.aspx.vb" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Template</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<TABLE id="pagina" cellSpacing="0" cellPadding="0" width="1024" border="0">
				<TR>
					<TD width="177" background="img_bg/logo.gif" height="153"></TD>
					<TD style="WIDTH: 608px" width="608" background="img_bg/logo_text.gif" height="153"></TD>
					<TD vAlign="top" width="256" background="img_bg/nav_boven.gif" height="153">
						<TABLE id="navboven" style="WIDTH: 256px; HEIGHT: 104px" cellSpacing="0" cellPadding="0"
							width="262" border="0">
							<TR>
								<TD style="HEIGHT: 74px" width="256" background="img_bg/nav_boven.gif" colSpan="3" align="right">
									<TABLE id="login" cellSpacing="0" cellPadding="0" width="190" border="0" style="HEIGHT: 48px">
										<TR>
											<TD><small>Account:</small>
											</TD>
											<TD>
												<asp:TextBox id="Txtaccount" runat="server" Width="90px" BackColor="#F9AB14" ForeColor="#5D5D5B"></asp:TextBox></TD>
										</TR>
										<TR>
											<TD><small>Paswoord:</small>
											</TD>
											<TD>
												<asp:TextBox id="Txtpaswoord" runat="server" Width="90px" BackColor="#F9AB14" ForeColor="#5D5D5B"
													TextMode="Password"></asp:TextBox></TD>
										</TR>
										<tr>
											<td colspan="2" align="center"><asp:Button id="Button1" runat="server" Text="Login" ForeColor="#5D5D5B" Font-Bold="True"></asp:Button></td>
										</tr>
									</TABLE>
								</TD>
							</TR>
							<TR>
								<TD style="HEIGHT: 40px"><asp:imagebutton id="Imgbutcontact_b" runat="server" ImageUrl="img_nav/navrboven_01.gif" Width="85px"></asp:imagebutton></TD>
								<TD style="HEIGHT: 40px"><asp:imagebutton id="Imgbutstatus_b" runat="server" ImageUrl="img_nav/navrboven_02.gif" Width="77px"></asp:imagebutton></TD>
								<TD style="HEIGHT: 40px"><asp:imagebutton id="Imgbutproduct_b" runat="server" ImageUrl="img_nav/navrboven_03.gif"></asp:imagebutton></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD vAlign="top" width="177" background="img_bg/nav_left.gif" height="463">
						<TABLE id="navlinks" cellSpacing="0" cellPadding="0" width="177" border="0">
							<tr>
								<td background="img_bg/nav_left.gif" height="70"></td>
							</tr>
							<TR>
								<TD><asp:imagebutton id="Imgbuthome" runat="server" ImageUrl="img_nav/navleft_01.gif"></asp:imagebutton></TD>
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
								<TD><asp:imagebutton id="Imgbutherstelling" runat="server" ImageUrl="img_nav/navleft_07.gif"></asp:imagebutton></TD>
							</TR>
							<TR>
								<TD><asp:imagebutton id="Imgbutsupport" runat="server" ImageUrl="img_nav/navleft_08.gif"></asp:imagebutton></TD>
							</TR>
						</TABLE>
					</TD>
					<TD colSpan="2" height="463" rowSpan="2"></TD>
					<TD height="463"></TD>
				</TR>
				<TR>
					<TD width="177" background="img_bg/nav_left_o.gif"></TD>
					<TD></TD>
					<TD></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
