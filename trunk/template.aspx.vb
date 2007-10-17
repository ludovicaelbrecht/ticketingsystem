Namespace css

Partial Class template
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub


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

        '''boven navigatie
        Me.Imgbutcontact_b.Attributes("onmouseover") = "this.src='img_nav/over/navrboven_over_01.gif';"
        Me.Imgbutcontact_b.Attributes("onmouseout") = "this.src='img_nav/navrboven_01.gif';"
        Me.Imgbutstatus_b.Attributes("onmouseover") = "this.src='img_nav/over/navrboven_over_02.gif';"
        Me.Imgbutstatus_b.Attributes("onmouseout") = "this.src='img_nav/navrboven_02.gif';"
        Me.Imgbutproduct_b.Attributes("onmouseover") = "this.src='img_nav/over/navrboven_over_03.gif';"
        Me.Imgbutproduct_b.Attributes("onmouseout") = "this.src='img_nav/navrboven_03.gif';"
    End Sub


End Class

End Namespace
