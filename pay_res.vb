Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class pay_res

    Public pin As Integer
    Public id As Integer
    Public adid As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles successpro.Click

        Me.Hide()
        adminid.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles failback.Click

        Me.Hide()
        If payment.flag = "C" Then
            payment.name_card.Clear()
            payment.alert.Visible = True
            payment.Show()
        End If
        If payment.flag = "i" Then
            payment.TextBox1.Clear()
            payment.TextBox3.Clear()
            payment.TextBox2.Clear()
            payment.TextBox4.Clear()
            payment.failcard.Visible = True
            payment.Show()
        End If



    End Sub

    Private Sub adminid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adminidbut.Click

        pin = payment.TextBox_pin.Text
        id = (pin * 3) + (pin * 5) + 1900
        adid = id + 120000
        ad.Visible = True
        val.Visible = True
        val.Text = adid
        successpro.Enabled = True
    End Sub

    
    Private Sub success_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles success.Click

    End Sub

    Private Sub pay_res_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class