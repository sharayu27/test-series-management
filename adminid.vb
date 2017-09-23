Public Class adminid

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (admintextbox.Text = pay_res.adid) Then
            Me.Hide()
            Attempt.Show()

        Else
            Me.Hide()
            pay_res.Show()
            MsgBox("You have entered wrong Admin Id")
        End If
    End Sub

    
End Class