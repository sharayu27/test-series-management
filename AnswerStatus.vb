Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class AnswerStatus


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Submit.Show()
    End Sub

    Private Sub AnswerStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mongo As MongoServer = MongoServer.Create
        mongo.Connect()
        ' Dim str As String
        ' Dim db = mongo.GetDatabase("AptitudeMock")
        ' Dim collection = db.GetCollection("Check_result_quant")

        '        Dim query1 = New BsonDocument("Qid", str)
        '
        'For Each item As BsonDocument In collection.Find(query1)
        'Dim save As BsonElement = item.GetElement("Save_ans")
        'Dim id As BsonElement = item.GetElement("Qid")




        'Next
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_Button.Click
        Me.Hide()
        If (ModulesName.flag = "Q") Then
            QuestionPage_Quant.Show()
            QuestionPage_Quant.Next_Button.Enabled = True
            QuestionPage_Quant.Submit_Button.Enabled = False
        End If
        If (ModulesName.flag = "C") Then
            QuestionPage_CP.Show()
            QuestionPage_CP.Next_Button.Enabled = True
            QuestionPage_CP.Submit_Button.Enabled = False
        End If

    End Sub

    Private Sub RectangleShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class