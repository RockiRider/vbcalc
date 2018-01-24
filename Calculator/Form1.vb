Public Class Form1
    Dim First As Decimal
    Dim Second As Decimal
    Dim Result As Decimal
    Dim Operations As String


  
    Private Sub btnone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnone.Click
        If txtdisplay.Text = "0" Then
            txtdisplay.Text = "1"
        Else
            txtdisplay.Text = txtdisplay.Text + "1"


        End If
    End Sub

    Private Sub btntwo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntwo.Click

        If txtdisplay.Text = "0" Then
            txtdisplay.Text = "2"
        Else
            txtdisplay.Text = txtdisplay.Text + "2"


        End If
    End Sub


    Private Sub btnthree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthree.Click

        If txtdisplay.Text = "0" Then
            txtdisplay.Text = "3"
        Else
            txtdisplay.Text = txtdisplay.Text + "3"


        End If
    End Sub
    
    Private Sub btnfour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfour.Click

        If txtdisplay.Text = "0" Then
            txtdisplay.Text = "4"
        Else
            txtdisplay.Text = txtdisplay.Text + "4"


        End If
    End Sub


    Private Sub btnfive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfive.Click

        If txtdisplay.Text = "0" Then
            txtdisplay.Text = "5"
        Else
            txtdisplay.Text = txtdisplay.Text + "5"


        End If
    End Sub


    Private Sub btnsix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsix.Click

        If txtdisplay.Text = "0" Then
            txtdisplay.Text = "6"
        Else
            txtdisplay.Text = txtdisplay.Text + "6"


        End If
    End Sub


    Private Sub btnseven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnseven.Click

        If txtdisplay.Text - "0" Then
            txtdisplay.Text = "7"
        Else
            txtdisplay.Text = txtdisplay.Text + "7"


        End If
    End Sub


    Private Sub btneight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneight.Click

        If txtdisplay.Text = "0" Then
            txtdisplay.Text = "8"
        Else
            txtdisplay.Text = txtdisplay.Text + "8"


        End If
    End Sub


    Private Sub btnnine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnine.Click

        If txtdisplay.Text = "0" Then
            txtdisplay.Text = "9"
        Else
            txtdisplay.Text = txtdisplay.Text + "9"


        End If
    End Sub


    Private Sub btnzero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnzero.Click

        If txtdisplay.Text = "0" Then
            txtdisplay.Text = "0"
        Else
            txtdisplay.Text = txtdisplay.Text + "0"


        End If
    End Sub

    Private Sub btnequals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnequals.Click
        Second = txtdisplay.Text
        If Operations = "+" Then
            Result = First + Second
            txtdisplay.Text = Result
        ElseIf Operations = "-" Then
            Result = First - Second
            txtdisplay.Text = Result
        ElseIf Operations = "*" Then
            Result = First * Second
            txtdisplay.Text = Result
        ElseIf Operations = "/" Then
            Result = First / Second
            txtdisplay.Text = Result


        End If
    End Sub

    Private Sub btnc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnc.Click
        txtdisplay.Text = "0"
    End Sub

    Private Sub btntimes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntimes.Click
        First = txtdisplay.Text
        txtdisplay.Text = ""
        Operations = "*"
    End Sub

    Private Sub btnminus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnminus.Click


        First = txtdisplay.Text
        txtdisplay.Text = ""
        Operations = "-"
    End Sub

    Private Sub btndiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndiv.Click
        First = txtdisplay.Text
        txtdisplay.Text = ""
        Operations = "/"
    End Sub

    Private Sub btndot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndot.Click
        If InStr(txtdisplay.Text, ".") = 0 Then
            txtdisplay.Text = txtdisplay.Text + "."
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnplus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnplus.Click
        First = txtdisplay.Text
        txtdisplay.Text = "0"
        Operations = "+"
    End Sub
End Class
