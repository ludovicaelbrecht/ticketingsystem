Imports System.web.Mail


Namespace css

Partial Class overzichtwinkelkar
    Inherits System.Web.UI.Page
    Dim artikelNr As Integer ' dit is het nr v/h artikel, doorgegeven v/d productpagina
    Public aantalRijen As Integer = 0


#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
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
        Me.Imgbutproducten.Attributes("onmouseover") = "this.src='img_nav/over/navleft_over_03.gif';"
        Me.Imgbutproducten.Attributes("onmouseout") = "this.src='img_nav/navleft_03.gif';"
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
        Me.Imgbutoverzicht.Attributes("onmouseover") = "this.src='img_nav/navleft_09.gif';"
        Me.Imgbutoverzicht.Attributes("onmouseout") = "this.src='img_nav/over/navleft_over_09.gif';"

        If Session.Contents("loginNaam") = "" Then
            Me.Txtpaswoord.Visible = True
            Me.Txtaccount.Visible = True
            Me.cmdLogin.Visible = True
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
            Me.lblAccount.Visible = False
            Me.lblPaswoord.Visible = False
            Me.cmdLogout.Visible = True
            Me.lblGebruikersnaam.Visible = True
            Me.lblGebruikersnaam.Text = "Gebruikersnaam: " & Session.Contents("loginNaam")
            Me.Txtaccount.Text = ""
            Me.Txtpaswoord.Text = ""
            Me.Imgbutoverzicht.Visible = True
        End If

    End Sub

    Private Sub SqlConnection1_InfoMessage(ByVal sender As System.Object, ByVal e As System.Data.SqlClient.SqlInfoMessageEventArgs)

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
        Session.Contents("loginNaam") = Me.Txtaccount.Text
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
            'Session.Contents("klantCode") = rs(0).value.ToString()
            Me.Txtpaswoord.Visible = False
            Me.Txtaccount.Visible = False
            Me.cmdLogin.Visible = False
            Me.lblAccount.Visible = False
            Me.lblPaswoord.Visible = False
            Me.cmdLogout.Visible = True
            Me.lblGebruikersnaam.Visible = True
            Me.lblGebruikersnaam.Text = "Gebruikersnaam:" & " " & Session.Contents("loginNaam")
            Me.Txtaccount.Text = ""
            Me.Txtpaswoord.Text = ""
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

    Public Sub getOverzichtWinkelkarData()
        Dim objConn, sqlstr, rs
        Dim i As Integer, strScript As String

        If Session.Contents("loginNaam") = "" Then
            strScript = "<script type='text/javascript'>alert('U bent niet aangemeld.\nGelieve u eerst aan te melden om het overzicht van de winkelkar te bezichtigen.');window.location='home.aspx';</script>"
            ' de redirect gebeurt via javascript omdat de alert voor response.redirect niet meer werkt
            RegisterClientScriptBlock("Toegevoegd", strScript)

        ElseIf Session.Contents("aantalArtikelenInWagen") < 1 Then
            Response.Write("Uw winkelkar is leeg.")
            Response.Write("<br><p style='text-align:left; font-weight:normal; font-style:italic; font-size:smaller;'><br><br><a href='producten.aspx'>Producten toevoegen &raquo;</a>")
        Else
            objConn = CreateObject("ADODB.Connection") ' Set removed.
            objConn.Open("Driver={MySQL ODBC 3.51 Driver}; SERVER=localhost; DATABASE=css; UID=root; PASSWORD=admin") ' Parentheses added.

            Response.Write("<table class='productenTabel'><tr>")
            Response.Write("<td class='productenTabel' style='font-size: 15px;'><b>Artikel</b></td>")
            Response.Write("<td class='productenTabel' style='font-size: 15px;'><b>Beschrijving</b></td>")
            Response.Write("<td class='productenTabel' style='font-size: 15px;'><b>Merk</b></td>")
            Response.Write("<td class='productenTabel' style='font-size: 15px;'><b>Categorie</b></td>")
            Response.Write("<td class='productenTabel' style='font-size: 15px;'><b>Aantal</b></td>")
            Response.Write("<td class='productenTabel' style='font-size: 15px;'><b>Prijs</b></td>")
            Response.Write("<td class='productenTabel' style='font-size: 15px;'><b>Totaal</b></td>")
            Response.Write("<td class='productenTabel' style='font-size: 15px;'><b>Verwijder?</b></td></tr>")


            'Dim aantalRijen As Integer = 0

            Dim nr As Integer
            For i = 1 To Session.Contents("aantalArtikelenInWagen")
                'nr = CInt(Session.Contents("artikelNr" & i))
                nr = Session.Contents("artikelNr" & i)
                If nr <> 99999 Then ' artikel is niet 'verwijderd' door klant
                    sqlstr = "SELECT * FROM computerspricelist WHERE article=" & nr
                    rs = objConn.execute(sqlstr) ' Set statement removed.

                    Response.Write("<tr><td class='productenTabel' style='font-size: 14px;'>" & rs("article").value.ToString() & "</td>" & vbCrLf)
                    ' dit voorkomt EOF/BOF errors als er geen 2de beschrijving bestaat
                    If rs("description 2").value.ToString() = "" Then
                        Response.Write("<td class='productenTabel' style='font-size: 14px;'>" & rs("description").value.ToString() & "</td>" & vbCrLf)
                    Else
                        Response.Write("<td class='productenTabel' style='font-size: 14px;'>" & rs("description").value.ToString() & "&nbsp;&nbsp;-&nbsp;&nbsp;" & rs("description 2").value.ToString() & "</td>" & vbCrLf)
                    End If
                    Response.Write("<td class='productenTabel' style='font-size: 14px;'>" & rs("brand").value.ToString() & "</td>" & vbCrLf)
                    Response.Write("<td class='productenTabel' style='font-size: 14px;'>" & rs("productgroup").value.ToString() & "</td>" & vbCrLf)
                    Response.Write("<td class='productenTabel' style='font-size: 14px; text-align: center;'>" & Session.Contents("artikelAantal" & i) & "</td>" & vbCrLf)
                    Response.Write("<td class='productenTabel' style='font-size: 14px; text-align: right;'>" & rs("price").value.ToString() & "&nbsp;&euro;</td>" & vbCrLf)
                    Response.Write("<td class='productenTabel' style='font-size: 14px; text-align: right;'>" & (rs("price").value.ToString() * Session.Contents("artikelAantal" & i)) & "&nbsp;&euro;</td>" & vbCrLf)
                    Response.Write("<td class='productenTabel' style='font-size: 14px; text-align: center; background-color: white;'><a href='verwijderArtikel.aspx?artikelNr=" & i & "'><img src='img/trash.jpg'></a></td></tr>" & vbCrLf)

                    aantalRijen += 1
                End If
            Next

            Response.Write("</table>")
            Response.Write("<p style='text-align:left; font-weight:normal; font-style:italic; font-size:smaller;'><br><br><a href='producten.aspx'>Extra producten toevoegen &raquo;</a>")

            rs.close()
            rs = Nothing ' Set statement removed.
            objConn.close()
            objConn = Nothing

            Me.cmdBestel.Visible = True
        End If
    End Sub

    Private Sub sendmailNaarCss()
        Dim objConn, sqlstr, rs
        Dim i As Integer, nr As Integer
        Dim emailKlant As String
        Dim tekstEmail As String = ""

        objConn = CreateObject("ADODB.Connection") ' Set removed.
        objConn.Open("Driver={MySQL ODBC 3.51 Driver}; SERVER=localhost; DATABASE=css; UID=root; PASSWORD=admin") ' Parentheses added.
        sqlstr = "SELECT * FROM klant WHERE account='" & Session.Contents("loginNaam") & "'"
        rs = objConn.execute(sqlstr) ' Set statement removed.

        emailKlant = rs("mail").value.ToString()

        tekstEmail += "<html><body bgcolor=#D5D5D5 font=Verdana>"
        tekstEmail += "Gebruikersnaam: <b>" & rs("account").value.ToString()
        tekstEmail += "<br></b>Voornaam: <b>" & rs("voornaam").value.ToString()
        tekstEmail += "<br></b>Naam: <b>" & rs("naam").value.ToString()
        tekstEmail += "<br></b>Adres: <b>" & rs("straat").value.ToString() & vbTab & rs("huisnummer").value.ToString()
        tekstEmail += "<br></b>Adres: <b>" & rs("postcode").value.ToString() & vbTab & rs("gemeente").value.ToString()
        tekstEmail += "<br></b>Tel: <b>" & rs("telefoonnummer").value.ToString()
        tekstEmail += "<br></b>Fax: <b>" & rs("fax").value.ToString()
        tekstEmail += "<br></b>E-mail: <b>" & emailKlant
        tekstEmail += "<br></b>BTW-nummer: <b>" & rs("btw").value.ToString()
        tekstEmail += "<br></b>IP-adres: <b>" & Request.ServerVariables("REMOTE_ADDR") & "</b><br><br><br>"


        tekstEmail += "<table border=2 cellspacing=0 cellpadding=1 bordercolor=black><tr><td><b>Art.</b></td><td><b>Beschrijving</b></td><td><b>Merk</b></td><td><b>Categorie</b></td><td><b>Aantal</b></td><td><b>Eenheidsrijs</b></td><td><b>Totaal</b></td></tr>"

        For i = 1 To Session.Contents("aantalArtikelenInWagen")
            nr = Session.Contents("artikelNr" & i)
            If nr <> 99999 Then ' artikel is niet 'verwijderd' door klant
                sqlstr = "SELECT * FROM computerspricelist WHERE article=" & nr
                rs = objConn.execute(sqlstr) ' Set statement removed.

                tekstEmail += "<tr><td><b>" & rs("article").value.ToString() & "</b></td>"
                tekstEmail += "<td>" & rs("description").value.ToString() & "</td>"
                tekstEmail += "<td>" & rs("brand").value.ToString() & "</td>"
                tekstEmail += "<td>" & rs("productgroup").value.ToString() & "</td>"
                tekstEmail += "<td align='center'>" & Session.Contents("artikelAantal" & i) & "</td>"
                tekstEmail += "<td align='right'>" & rs("price").value.ToString() & " &euro;</td>"
                tekstEmail += "<td align='right'>" & (rs("price").value.ToString() * Session.Contents("artikelAantal" & i)) & " &euro;</td></tr>"
            End If
        Next

        rs.close()
        rs = Nothing ' Set statement removed.
        objConn.close()
        objConn = Nothing


        Dim myMailer As New MailMessage
        myMailer.From = emailKlant
        myMailer.To = "css@scarlet.be"

        myMailer.BodyFormat = MailFormat.Html
        myMailer.Priority = MailPriority.Normal
        myMailer.Subject = "Bestelling via website"

        myMailer.Body = tekstEmail

        SmtpMail.SmtpServer = "smtp.scarlet.be"
        SmtpMail.Send(myMailer)

    End Sub

    Private Sub sendmailNaarKlant()
        Dim objConn, sqlstr, rs
        Dim i As Integer, nr As Integer
        Dim emailKlant As String
        Dim tekstEmail As String = ""

        objConn = CreateObject("ADODB.Connection") ' Set removed.
        objConn.Open("Driver={MySQL ODBC 3.51 Driver}; SERVER=localhost; DATABASE=css; UID=root; PASSWORD=admin") ' Parentheses added.
        sqlstr = "SELECT * FROM klant WHERE account='" & Session.Contents("loginNaam") & "'"
        rs = objConn.execute(sqlstr) ' Set statement removed.

        emailKlant = rs("mail").value.ToString()

        tekstEmail += "Bedankt voor uw bestelling bij CSS!" & vbCrLf & vbCrLf & vbCrLf

        For i = 1 To Session.Contents("aantalArtikelenInWagen")
            nr = Session.Contents("artikelNr" & i)
            If nr <> 99999 Then ' artikel is niet 'verwijderd' door klant
                sqlstr = "SELECT * FROM computerspricelist WHERE article=" & nr
                rs = objConn.execute(sqlstr) ' Set statement removed.

                'tekstEmail += "Art." & vbTab & "Beschrijving" & vbTab & "Merk" & vbTab & "Categorie" & vbTab & "Aantal" & "Eenheidsrijs" & "Totaal"
                tekstEmail += rs("article").value.ToString() & vbTab
                tekstEmail += rs("description").value.ToString() & vbTab
                tekstEmail += rs("brand").value.ToString() & vbTab
                tekstEmail += rs("productgroup").value.ToString() & vbTab
                tekstEmail += rs("price").value.ToString() & " euro" & " * "
                tekstEmail += Session.Contents("artikelAantal" & i) & " = "
                tekstEmail += (rs("price").value.ToString() * Session.Contents("artikelAantal" & i)) & " euro" & vbCrLf & vbCrLf

                'tekstEmail += "<tr><td>Nummer artikel: " & rs("article").value.ToString() & vbCrLf
                'tekstEmail += "<tr><td>Beschrijving: " & rs("description").value.ToString() & " - " & rs("description 2").value.ToString() & vbCrLf
                'tekstEmail += "<tr><td>Merk: " & rs("brand").value.ToString() & vbCrLf
                'tekstEmail += "<tr><td>Categorie: " & rs("productgroup").value.ToString() & vbCrLf
                'tekstEmail += "<tr><td>Aantal: " & Session.Contents("artikelAantal" & i) & vbCrLf
                'tekstEmail += "<tr><td>Eenheidsprijs: " & rs("price").value.ToString() & " &euro;" & vbCrLf
                'tekstEmail += "<tr><td>Totaal: " & (rs("price").value.ToString() * Session.Contents("artikelAantal" & i)) & " &euro;" & vbCrLf & vbCrLf & vbCrLf

            End If
        Next

        tekstEmail += vbCrLf
        tekstEmail += "U zal gecontacteerd worden wanneer uw bestelling klaar is voor afhaling." & vbCrLf
        tekstEmail += "Indien er problemen zijn met uw bestelling, gelieve contact op te nemen met CSS." & vbCrLf
        tekstEmail += "Dit kan zowel telefonisch (016/44.72.53) als via e-mail (css@scarlet.be)." & vbCrLf
        tekstEmail += "Dank u voor uw vertrouwen in CSS."

        rs.close()
        rs = Nothing ' Set statement removed.
        objConn.close()
        objConn = Nothing


        Dim myMailer As New MailMessage
        myMailer.From = "css@scarlet.be"
        myMailer.To = emailKlant

        myMailer.BodyFormat = MailFormat.Text
        myMailer.Priority = MailPriority.Normal
        myMailer.Subject = "Uw bestelling bij CSS"

        myMailer.Body = tekstEmail

        SmtpMail.SmtpServer = "smtp.scarlet.be"
        SmtpMail.Send(myMailer)

    End Sub

    Private Sub cmdBestel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBestel.Click
        Call sendmailNaarCss()
        Call sendmailNaarKlant()
        Call winkelkarLedigen()
    End Sub

    Private Sub winkelkarLedigen()
        'winkelwagen ledigen
        Dim tmpLoginNaam As String
        tmpLoginNaam = Session.Contents("loginNaam")
        Session.Contents.RemoveAll()
        Session.Contents("loginNaam") = tmpLoginNaam

        Me.cmdBestel.Visible = False

        Dim strScript As String
        strScript = "<script type='text/javascript'>alert('Uw bestelling is geplaatst.\nU zal binnenkort een e-mail ontvangen ter bevestiging.\nIndien er problemen zijn met uw bestelling, gelieve contact op te nemen met CSS.');</script>"
        RegisterClientScriptBlock("MailVerstuurd", strScript)
    End Sub
End Class
End Namespace
