Public Class AnswerStatus1

    Private Sub RectangleShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape2.Click

    End Sub

    Private Sub AnswerStatus1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Submit.Show()

    End Sub

    Private Sub back_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_Button.Click
        Me.Hide()
        If (ModulesName.flag = "E") Then
            QuestionPage_English.Show()
            QuestionPage_English.next_Button.Enabled = True
            QuestionPage_English.submit_Button.Enabled = False
        End If
        If (ModulesName.flag = "L") Then
            QuestionPage_Logc.Show()
            QuestionPage_Logc.Next_Button.Enabled = True
            QuestionPage_Logc.Submit_Button.Enabled = False
        End If

    End Sub
End Class