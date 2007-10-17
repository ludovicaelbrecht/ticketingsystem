Imports System.web.Mail


Namespace css

Partial Class winkelkar
    Inherits System.Web.UI.Page
    Public aantalRijen As Integer
    Dim artikelNr As Integer ' dit is het nr v/h artikel, doorgegeven v/d productpagina


#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        '
        'SqlConnection1
        '

    End Sub
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents lstCategorie As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ph As System.Web.UI.WebControls.PlaceHolder


    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '''onder navigatie
        Me.Imgbuthome.Attributes("onmouseover") = "this.src='img_nav/over/navleft_over_01.gif';"
        Me.Imgbuthome.Attributes("onmouseout") = "this.src='img_nav/navleft_01.gif';"
        Me.Imgbutinfo.Attributes("onmouseover") = "this.src='img_nav/over/navleft_over_02.gif';"
        Me.Imgbutinfo.Attributes("onmouseout") = "this.src='img_nav/navleft_02.gif';"
        Me.Imgbutproducten.Attributes("onmouseover") = "this.src='img_nav/navleft_03.gif';"
        Me.Imgbutproducten.Attributes("onmouseout") = "this.src='img_nav/over/navleft_over_03.gif';"
        Me.Imgbutpromoties.Attributes("onmouseover") = "this.src='img_nav/over/navleft_over_04.gif';"
        Me.Imgbutpromoties.Attributes("onmouseout") = "this.src='img_nav/navleft_04.gif';"
        Me.Imgbutcontact.Attributes("onmouseover") = "this.src='img_nav/over/navleft_over_05.gif';"
        Me.Imgbutcontact.Attributes("onmouseout") = "this.src='img_nav/navleft_05.gif';"
        Me.Imgbutorderstatus.Attributes("onmouseover") = "this.src='img_nav/over/navleft_over_06.gif';"
        Me.Imgbutorderstatus.Attributes("onmouseout") = "this.src='img_nav/navleft_06.gif';"
        Me.Imgbutherstelling.Attributes("onmouseover") = "this.src='img_nav/over/navleft_over_07.gif';"
        Me.Imgbutherstelling.Attributes("onmouseout") = "this.src='img_nav/navleft_07.gif';"
        Me.Imgbutsupport.Attributes("onmouseover") = "this.src='img_nav/over/navleft_over_08.gif';"
        Me.Imgbutsupport.Attributes("onmouseout") = "this.src='img_nav/navleft_08.gif';"
        Me.Imgbutoverzicht.Attributes("onmouseover") = "this.src='img_nav/over/navleft_over_09.gif';"
        Me.Imgbutoverzicht.Attributes("onmouseout") = "this.src='img_nav/navleft_09.gif';"

        If Session.Contents("loginNaam") = "" Then
            Me.Txtpaswoord.Visible = True
            Me.Txtaccount.Visible = True
            Me.cmdLogin.Visible = True
            Me.cmdRegistreer.Visible = True
            Me.lblAccount.Visible = True
            Me.lblPaswoord.Visible = True
            Me.cmdLogout.Visible = False
            Me.lblGebruikersnaam.Visible = False
            Me.lblGebruikersnaam.Text = ""
            'Me.Txtaccount.Text = ""
            'Me.Txtpaswoord.Text = ""
            Me.Imgbutoverzicht.Visible = False
        Else
            Me.Txtpaswoord.Visible = False
            Me.Txtaccount.Visible = False
            Me.cmdLogin.Visible = False
            Me.cmdRegistreer.Visible = False
            Me.lblAccount.Visible = False
            Me.lblPaswoord.Visible = False
            Me.cmdLogout.Visible = True
            Me.lblGebruikersnaam.Visible = True
            Me.lblGebruikersnaam.Text = "Gebruikersnaam: " & Session.Contents("loginNaam")
            Me.Txtaccount.Text = ""
            Me.Txtpaswoord.Text = ""
            Me.Imgbutoverzicht.Visible = True
        End If

        Dim strScript As String
        If Session.Contents("loginNaam") = "" Then
            strScript = "<script type='text/javascript'>alert('U bent niet aangemeld.\nGelieve u eerst in te loggen alvorens te bestellen.');window.location='home.aspx';</script>"
                RegisterClientScriptBlock("Mislukt", strScript)
            End If

        End Sub

        Private Sub SqlConnection1_InfoMessage(ByVal sender As System.Object, ByVal e As System.Data.SqlClient.SqlInfoMessageEventArgs) Handles SqlConnection1.InfoMessage

        End Sub

        Private Sub Imgbutproducten_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imgbutproducten.Click
            Response.Redirect("producten.aspx")
        End Sub

        Private Sub Imgbutinfo_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imgbutinfo.Click
            Response.Redirect("info.aspx")
        End Sub

        Private Sub Imgbutpromoties_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imgbutpromoties.Click
            Response.Redirect("promoties.aspx")
        End Sub

        Private Sub Imgbutcontact_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imgbutcontact.Click
            Response.Redirect("contact.aspx")
        End Sub

        Private Sub Imgbutsupport_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imgbutsupport.Click
            Response.Redirect("support.aspx")
        End Sub

        Private Sub Imgbutherstelling_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imgbutherstelling.Click
            Response.Redirect("herstelling.aspx")
        End Sub

        Private Sub Imgbutorderstatus_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imgbutorderstatus.Click
            Response.Redirect("orderstatus.aspx")
        End Sub

        Private Sub Imgbuthome_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imgbuthome.Click
            Response.Redirect("home.aspx")
        End Sub

        Private Sub Imgbutoverzicht_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imgbutoverzicht.Click
            Response.Redirect("overzichtwinkelkar.aspx")
        End Sub

        Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
            Dim wachtwoord = Me.Txtpaswoord.Text
            Dim objConn, sqlstr, rs

            objConn = CreateObject("ADODB.Connection") ' Set removed.
            objConn.Open("Driver={MySQL ODBC 3.51 Driver}; SERVER=localhost; DATABASE=css; UID=root; PASSWORD=admin") ' Parentheses added.
            sqlstr = "SELECT klantcode,account,paswoord FROM klant WHERE account='" & Me.Txtaccount.Text & "' and paswoord='" & Me.Txtpaswoord.Text & "'"
            rs = objConn.execute(sqlstr) ' Set statement removed.
            If rs.BOF And rs.EOF Then ' Query didn't return any records.
                Me.lblFout.Visible = True
                Me.lblFout.Text = "De gegevens zijn niet correct, gelieve opnieuw te proberen"
                Me.Txtaccount.Text = ""
                Me.Txtpaswoord.Text = ""
            Else
                Session.Contents("loginNaam") = Me.Txtaccount.Text
                'Session.Contents("klantCode") = rs(0).value.ToString()
                Me.Txtpaswoord.Visible = False
                Me.Txtaccount.Visible = False
                Me.cmdLogin.Visible = False
                Me.cmdRegistreer.Visible = False
                Me.lblAccount.Visible = False
                Me.lblPaswoord.Visible = False
                Me.cmdLogout.Visible = True
                Me.lblGebruikersnaam.Visible = True
                Me.lblGebruikersnaam.Text = "Gebruikersnaam:" & " " & Session.Contents("loginNaam")
                Me.Txtaccount.Text = ""
                Me.Txtpaswoord.Text = ""
                Me.lblFout.Visible = False
                Me.Imgbutoverzicht.Visible = True
            End If
            rs.close()
            rs = Nothing ' Set statement removed.
            objConn.close()
            objConn = Nothing
        End Sub

        Private Sub cmdLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogout.Click
            Me.Txtpaswoord.Visible = True
            Me.Txtaccount.Visible = True
            Me.cmdLogin.Visible = True
            Me.lblAccount.Visible = True
            Me.lblPaswoord.Visible = True
            Me.cmdLogout.Visible = False
            Me.lblGebruikersnaam.Visible = False
            Me.lblGebruikersnaam.Text = ""
            Me.Txtaccount.Text = ""
            Me.Txtpaswoord.Text = ""
            Session.Contents("loginNaam") = ""
            Session.Contents.RemoveAll()
            Me.Imgbutoverzicht.Visible = False
            Response.Redirect("home.aspx") ' uitgelogde klanten moeten hier niet zijn
        End Sub

        Public Sub getWinkelkarData()
            Dim objConn, sqlstr, rs

            artikelNr = Request.QueryString("artikel")

            objConn = CreateObject("ADODB.Connection") ' Set removed.
            objConn.Open("Driver={MySQL ODBC 3.51 Driver}; SERVER=localhost; DATABASE=css; UID=root; PASSWORD=admin") ' Parentheses added.

            sqlstr = "SELECT * FROM computerspricelist WHERE article=" & artikelNr
            rs = objConn.execute(sqlstr)

            If rs.EOF Or rs.BOF Then
                Response.Write("<b>Fout:</b><br>" & vbCrLf)
                Response.Write("Het artikelnummer is verkeerd. Gelieve het opnieuw te proberen." & vbCrLf)
            Else
                Response.Write("<table class='productenTabel'>" & vbCrLf)
                Response.Write("<td class='productenTabel' colspan='2' style='font-size: 16px; text-align: center;'><b>Beschrijving product</b></td>")
                Response.Write("<tr><td class='productenTabel' style='font-size: 14px;'><b>Categorie:</b></td><td class='productenTabel' style='font-size: 14px;'>" & rs("productgroup").value.ToString() & "</td></tr>" & vbCrLf)
                Response.Write("<tr><td class='productenTabel' style='font-size: 14px;'><b>Merk:</b></td><td class='productenTabel' style='font-size: 14px;'>" & rs("brand").value.ToString() & "</td></tr>" & vbCrLf)
                Response.Write("<tr><td class='productenTabel' style='font-size: 14px;'><b>Nummer artikel:</b></td><td class='productenTabel' style='font-size: 14px;'>" & rs("article").value.ToString() & "</td></tr>" & vbCrLf)
                Response.Write("<tr><td class='productenTabel' style='font-size: 14px;'><b>Beschrijving:</b></td><td class='productenTabel' style='font-size: 14px;'>" & rs("description").value.ToString() & "&nbsp;&nbsp;-&nbsp;&nbsp;" & rs("description 2").value.ToString() & "</td></tr>" & vbCrLf)
                Response.Write("<tr><td class='productenTabel' style='font-size: 14px;'><b>Eenheidsprijs:</b></td><td class='productenTabel' style='font-size: 14px;'>" & rs("price").value.ToString() & "</td></tr>" & vbCrLf)
                Response.Write("</table>" & vbCrLf)
                Response.Write("<br><div align='left'>Te bestellen aantal: " & vbCrLf)

                Me.txtAantal.Visible = True
                Me.cmdBestellen.Visible = True
            End If

            rs.close()
            rs = Nothing ' Set statement removed.
            objConn.close()
            objConn = Nothing
        End Sub

        Private Sub cmdBestellen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBestellen.Click
            Dim strScript As String

            If Session.Contents("loginNaam") = "" Then
                strScript = "<script type='text/javascript'>alert('U bent niet aangemeld.\nGelieve u eerst in te loggen alvorens te bestellen.');</script>"
                RegisterClientScriptBlock("Mislukt", strScript)
            ElseIf CInt(Val(Me.txtAantal.Text)) < 1 Then ' stel: 0 a
                strScript = "<script type='text/javascript'>alert('U hebt het te bestellen aantal foutief ingevuld.\nGelieve opnieuw te proberen.');</script>"
                RegisterClientScriptBlock("Toegevoegd", strScript)
            ElseIf CInt(Val(Me.txtAantal.Text)) <> Me.txtAantal.Text Then ' stel: 1.5 1,5 a
                strScript = "<script type='text/javascript'>alert('U hebt het te bestellen aantal foutief ingevuld.\nGelieve opnieuw te proberen.');</script>"
                RegisterClientScriptBlock("Toegevoegd", strScript)

            Else
                Session.Contents("aantalArtikelenInWagen") += 1
                Session.Contents("artikelNr" & Session.Contents("aantalArtikelenInWagen")) = Request.QueryString("artikel")
                Session.Contents("artikelAantal" & Session.Contents("aantalArtikelenInWagen")) = Me.txtAantal.Text

                strScript = "<script type='text/javascript'>alert('Het artikel is toegevoegd aan uw winkelkar.\nU wordt nu teruggestuurd naar de productcatalogus.');window.location='overzichtwinkelkar.aspx';</script>"
                ' de redirect gebeurt via javascript omdat de alert voor response.redirect niet meer werkt
                RegisterClientScriptBlock("Toegevoegd", strScript)

            End If
        End Sub

    Private Sub cmdRegistreer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRegistreer.Click
        Response.Redirect("klantregistratie.aspx")
    End Sub
End Class
End Namespace
