Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class Result
    Public qid As Integer
    Public counter As Integer





    Private Sub Result_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sum As Integer = 0
        sum = QuestionPage_Quant.sum_q + QuestionPage_Logc.sum_l + QuestionPage_CP.sum_c + QuestionPage_English.sum_e
        Result_Label.Text = sum


    End Sub


    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()

        certificate.Show()

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        checkanswer_quant.Show()


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        checkanswer_cp.Show()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        checkanswer_verbal.Show()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Hide()
        checkanswer_logical.Show()
    End Sub
End Class