' de 4 imports zijn nodig voor encryptie
Imports System.Security.Cryptography
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient


Namespace css


Partial Class klantregistratie
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        '
        'SqlConnection1
        '

    End Sub
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Textbox6 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Requiredfieldvalidator10 As System.Web.UI.WebControls.RequiredFieldValidator


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
        Else
            Me.Txtpaswoord.Visible = False
            Me.Txtaccount.Visible = False
            Me.cmdLogin.Visible = False
            Me.lblAccount.Visible = False
            Me.lblPaswoord.Visible = False
            Me.cmdLogout.Visible = True
            Me.lblGebruikersnaam.Visible = True
            Me.lblGebruikersnaam.Text = "Gebruikersnaam:" & " " & Session.Contents("loginNaam")
            ' Me.Txtaccount.Text = ""
            ' Me.Txtpaswoord.Text = ""
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
        'Session.Contents("klantCode") = ""
        Session.Contents("loginNaam") = ""
    End Sub

    Private Sub cmdSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubmit.Click
        Dim isOnbestaand As Boolean
        Dim objConn, sqlstr, rs, rs2
        Dim strScript As String, boodschap As String

        If Me.txtwachtwoord.Text <> Me.txtwachtwoord2.Text Then
            strScript = "<script type='text/javascript'>alert('Het wachtwoord dat u gekozen hebt komt niet overeen met het bevestigingswachtwoord.\nGelieve opnieuw te proberen');</script>"
            RegisterClientScriptBlock("MisluktWachtwoord", strScript)
        ElseIf Me.txtmail.Text <> Me.txtmail2.Text Then
            strScript = "<script type='text/javascript'>alert('Het e-mailadres dat u gekozen hebt komt niet overeen met het bevestigingse-mailadres.\nGelieve opnieuw te proberen');</script>"
            RegisterClientScriptBlock("MisluktEmail", strScript)
        Else
            objConn = CreateObject("ADODB.Connection") ' Set removed.
            objConn.Open("Driver={MySQL ODBC 3.51 Driver}; SERVER=localhost; DATABASE=css; UID=root; PASSWORD=admin") ' Parentheses added.

            sqlstr = "SELECT account FROM klant WHERE account='" & Me.txtgebruikersnaam.Text & "'"
            rs = objConn.execute(sqlstr)
            If rs.BOF And rs.EOF Then
                isOnbestaand = True
            Else
                isOnbestaand = False
            End If

            If isOnbestaand Then
                Session.Contents("loginNaam") = Me.txtgebruikersnaam.Text

                sqlstr = "INSERT INTO klant (naam, voornaam, account, paswoord, straat, huisnummer, gemeente, postcode, telefoonnummer, mail, fax, btw) VALUES ('" _
                            & Me.txtnaam.Text _
                            & "','" & Me.txtvoornaam.Text _
                            & "','" & Me.txtgebruikersnaam.Text _
                            & "','" & Me.txtwachtwoord.Text _
                            & "','" & Me.txtstraat.Text _
                            & "','" & Me.txtnummer.Text _
                            & "','" & Me.txtgemeente.Text _
                            & "','" & Me.txtpostcode.Text _
                            & "','" & Me.txttelefoonnummer.Text _
                            & "','" & Me.txtmail.Text _
                            & "','" & Me.txtfax.Text _
                            & "','" & Me.txtbtw.Text _
                            & "');"
                rs = objConn.execute(sqlstr) ' Set statement removed.

                'sqlstr = "SELECT klantcode FROM klant WHERE account='" & Session.Contents("loginNaam") & "'"
                'rs = objConn.execute(sqlstr)
                'Session.Contents("klantCode") = rs(0).value.ToString()

                Response.Redirect("registratieoverzicht.aspx")
            Else
                boodschap = "'De gebruikersnaam die u gekozen hebt (" & Me.txtgebruikersnaam.Text _
                & ") bestaat reeds.\nGelieve een andere te kiezen.'"
                strScript = "<script type='text/javascript'>alert(" & boodschap & ");</script>"
                RegisterClientScriptBlock("Mislukt", strScript)
            End If

            rs.close()
            rs = Nothing ' Set statement removed.
            objConn.close()
            objConn = Nothing
        End If
    End Sub
End Class

End Namespace
