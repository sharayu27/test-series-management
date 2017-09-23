Public Class Submit

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer
        i = 1
        Me.Hide()
        For i = 1 To 4
            ModulesName.Show()
            i = i + 1
        Next
        If ((ModulesName.Logic_Button.Enabled = False) And (ModulesName.Quant_Button.Enabled = False) And (ModulesName.CP_Button.Enabled = False) And (ModulesName.Eng_button.Enabled = False)) Then
            ModulesName.Hide()
            Result.Show()
        End If
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        i = 1
        Me.Hide()
        For i = 1 To 4
            ModulesName.Show()
            i = i + 1
        Next
        If ((ModulesName.Logic_Button.Enabled = False) And (ModulesName.Quant_Button.Enabled = False) And (ModulesName.CP_Button.Enabled = False) And (ModulesName.Eng_button.Enabled = False)) Then
            ModulesName.Hide()
            Result.Show()

        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        If (ModulesName.flag = "Q") Then
            QuestionPage_Quant.Show()
            QuestionPage_Quant.Next_Button.Enabled = False
            QuestionPage_Quant.Submit_Button.Enabled = True
        End If
        If (ModulesName.flag = "C") Then
            QuestionPage_CP.Show()
            QuestionPage_CP.Next_Button.Enabled = False
            QuestionPage_CP.Submit_Button.Enabled = True
        End If
        If (ModulesName.flag = "E") Then
            QuestionPage_English.Show()
            QuestionPage_English.next_Button.Enabled = False
            QuestionPage_English.submit_Button.Enabled = True
        End If
        If (ModulesName.flag = "L") Then
            QuestionPage_Logc.Show()
            QuestionPage_Logc.Next_Button.Enabled = False
            QuestionPage_Logc.Submit_Button.Enabled = True
        End If

    End Sub
End Class