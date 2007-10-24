Imports css.clsdatabase
Imports System.data.sqlclient
Imports System.data

Namespace css

    Partial Class producten
        Inherits System.Web.UI.Page
        Public aantalRijen As Integer

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

            If Not IsPostBack Then
                DDLcategorie.DataSource = CreateDataSource()
                DDLcategorie.DataTextField = "product"
                DDLcategorie.DataValueField = "pkint"
                ' Bind the data to the control.
                DDLcategorie.DataBind()
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

        Function CreateDataSource() As ICollection

            ' Create a table to store data for the DropDownList control.
            Dim dt As DataTable = New DataTable

            ' Define the columns of the table.
            dt.Columns.Add(New DataColumn("pkint", GetType(String)))
            dt.Columns.Add(New DataColumn("product", GetType(String)))

            ' make connection en get records

            Dim rs, sqlstr

            sqlstr = "SELECT `pkint`,`product` FROM `categories`"

            'functie oproepen om recordset te vullen
            rs = clsdatabase.openConn(sqlstr)

            dt.Rows.Add(CreateRow("0", "<<selecteer categorie>>", dt))
            If rs.BOF And rs.EOF Then ' Query didn't return any records.

            Else
                ' Populate the table with sample values.
                rs.MoveFirst()
                Do While Not rs.EOF
                    dt.Rows.Add(CreateRow(rs("pkint").value, rs("product").value, dt))
                    rs.MoveNext()
                Loop

            End If
            rs.close()
            rs = Nothing ' Set statement removed.


            ' Create a DataView from the DataTable to act as the data source
            ' for the DropDownList control.
            Dim dv As DataView = New DataView(dt)
            Return dv

        End Function

        Function CreateRow(ByVal Text As String, ByVal Value As String, ByVal dt As DataTable) As DataRow

            ' Create a DataRow using the DataTable defined in the 
            ' CreateDataSource method.
            Dim dr As DataRow = dt.NewRow()

            ' This DataRow contains the ColorTextField and ColorValueField 
            ' fields, as defined in the CreateDataSource method. Set the 
            ' fields with the appropriate value. Remember that column 0 
            ' is defined as ColorTextField, and column 1 is defined as 
            ' ColorValueField.
            dr(0) = Text
            dr(1) = Value

            Return dr

        End Function

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
                Me.cmdRegistreer.Visible = False
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
            Me.cmdRegistreer.Visible = True
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
        End Sub

        Private Sub cmdRegistreer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRegistreer.Click
            Response.Redirect("klantregistratie.aspx")
        End Sub


        Private Sub cmdZoekCategorie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdZoekCategorie.Click
            Response.Redirect("producten.aspx?DDLindex=" & Me.DDLcategorie.SelectedIndex)
        End Sub

        Public Sub getData()
            Dim objConn, sqlstr, rs
            Dim DDLindex As Integer, aantal As Integer, groepnaam As String, strScript As String

            DDLindex = CInt(Val(Request.QueryString("DDLindex")))

            objConn = CreateObject("ADODB.Connection") ' Set removed.
            objConn.Open("Driver={MySQL ODBC 3.51 Driver}; SERVER=localhost; DATABASE=css; UID=root; PASSWORD=admin") ' Parentheses added.

            sqlstr = "SELECT count(*) FROM categories"
            rs = objConn.execute(sqlstr)
            aantal = CInt(rs(0).value.ToString())

            If DDLindex > aantal Then
                strScript = "<script type='text/javascript'>alert('Er is een fout opgetreden.\nGelieve opnieuw te zoeken.');</script>"
                RegisterClientScriptBlock("Mislukt", strScript)
            ElseIf CInt(Val(DDLindex)) < 1 Then
                strScript = "<script type='text/javascript'>alert('Er is een fout opgetreden.\nGelieve opnieuw te zoeken.');</script>"
                RegisterClientScriptBlock("Mislukt", strScript)
            ElseIf CInt(Val(DDLindex)) <> DDLindex Then
                strScript = "<script type='text/javascript'>alert('Er is een fout opgetreden.\nGelieve opnieuw te zoeken.');</script>"
                RegisterClientScriptBlock("Mislukt", strScript)
            ElseIf CInt(Val(DDLindex)) > 0 Then
                Me.DDLcategorie.SelectedIndex = DDLindex
                groepnaam = Me.DDLcategorie.SelectedItem.ToString()

                sqlstr = "SELECT * FROM computerspricelist WHERE nr='" & DDLindex & "' ORDER BY brand"
                rs = objConn.execute(sqlstr)

                Response.Write("<br><br><br><table class='productenTabel'>")
                Response.Write("<tr><td class='productenTabel' style='font-weight:bolder; height:30; text-align:center; font-size:14px;' colspan='4'>" & groepnaam & "</td>")
                Response.Write("<td class='productenTabel' style='font-weight:bolder; height:30; text-align:center; font-size:14px;'>Bestellen?</td></tr>")

                rs.movefirst()
                aantalRijen = 0

                While Not rs.eof
                    ' de vbCrLf's dienen om de broncode overzichtelijker te houden
                    Response.Write("<tr>" & vbCrLf)
                    Response.Write("<td class='productenTabel'>" & Server.HtmlEncode(rs("brand").value.ToString()) & "&nbsp;&nbsp;&nbsp;</td>" & vbCrLf)
                    Response.Write("<td class='productenTabel'>" & Server.HtmlEncode(rs("description").value.ToString()) & "&nbsp;&nbsp;&nbsp;</td>" & vbCrLf)
                    Response.Write("<td class='productenTabel'>" & Server.HtmlEncode(rs("description 2").value.ToString()) & "&nbsp;&nbsp;&nbsp;</td>" & vbCrLf)
                    Response.Write("<td align='right' class='productenTabel'>" & Server.HtmlEncode(rs("price").value.ToString()) & " &euro;</td>" & vbCrLf)
                    Response.Write("<td align='center' class='productenTabel' style='text-align: center; background-color: white;'><a href='winkelkar.aspx?artikel=" & rs("article").value.ToString() & "'><img border='0' src='img/winkelkar.gif'></a>" & vbCrLf)
                    Response.Write("</tr>" & vbCrLf & vbCrLf)

                    aantalRijen += 1
                    rs.movenext()
                End While

                Response.Write("</table><br>")
            End If

            rs.close()
            rs = Nothing ' Set statement removed.
            objConn.close()
            objConn = Nothing
        End Sub

    End Class
End Namespace
