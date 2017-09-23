Imports MongoDB.Bson
Imports MongoDB.Driver
Imports System.Text.RegularExpressions

Public Class payment
    Public flag As String = "X"
    Private NameValid As Boolean 'Is Name  Valid?
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not (TextBox_pin.TextLength = 4) Then
            MsgBox("Please enter Valid ATM pin")
            TextBox_pin.Clear()
        Else

            Me.Hide()
            pay_res.Show()
            If Not (TextBox1.TextLength = 4 Or TextBox2.TextLength = 4 Or TextBox3.TextLength = 4 Or TextBox4.TextLength = 4) Then
                flag = "i"
                pay_res.fail.Visible = True
                pay_res.failback.Visible = True
                pay_res.success.Visible = False
                pay_res.successpro.Visible = False
                pay_res.adminidbut.Visible = False
            Else
                pay_res.fail.Visible = False
                pay_res.failback.Visible = False
                pay_res.success.Visible = True
                pay_res.successpro.Visible = True
                pay_res.adminidbut.Visible = True
            End If
        End If



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        TextBox_pin.Text = (TextBox_pin.Text & "1")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox_pin.Text = (TextBox_pin.Text & "2")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox_pin.Text = (TextBox_pin.Text & "3")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox_pin.Text = (TextBox_pin.Text & "4")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox_pin.Text = (TextBox_pin.Text & "5")
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox_pin.Text = (TextBox_pin.Text & "6")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        TextBox_pin.Text = (TextBox_pin.Text & "7")
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TextBox_pin.Text = (TextBox_pin.Text & "8")
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        TextBox_pin.Text = (TextBox_pin.Text & "9")
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        TextBox_pin.Text = (TextBox_pin.Text & "0")
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        TextBox_pin.Clear()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles name_card.TextChanged
        flag = "C"
        If Not Regex.Match(name_card.Text, "[a-z] ", RegexOptions.IgnoreCase).Success Then 'Only Letters

            pay_res.fail.Visible = True
            pay_res.failback.Visible = True
            pay_res.success.Visible = False
            pay_res.successpro.Visible = False
            pay_res.adminidbut.Visible = False

            '  MessageBox.Show("Please Enter Alphabetic Characters Only!") 'Inform User

            name_card.Focus() 'Return Focus
            'name_card.Clear() 'Clear TextBox

            NameValid = False 'Boolean = False
        Else

            NameValid = True 'Everything Fine
            pay_res.fail.Visible = False
            pay_res.failback.Visible = False
            pay_res.success.Visible = True
            pay_res.successpro.Visible = True
            pay_res.adminidbut.Visible = True
        End If
    End Sub
  

  
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        Button10.Enabled = True
        Button11.Enabled = True
        Button12.Enabled = True

    End Sub

   

    Private Sub payment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class