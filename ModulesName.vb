Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class ModulesName

    Dim counter As Integer = 0
    Dim qid As Integer
    Public flag As String   'X'
    


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Logic_Button.Click
        flag = "L"
        Logic_Button.Enabled = False
        Label5.ForeColor = Color.DarkGray
        Me.Hide()
        logical.Show()
        Dim mongo As MongoServer = MongoServer.Create
        mongo.Connect()
        Dim db = mongo.GetDatabase("AptitudeMock")
        Dim q As String
        qid = 1
        q = qid
        Dim query = New QueryDocument("Qid", q)
        Using mongo.RequestStart(db)
            Dim collection1 = db.GetCollection(Of BsonDocument)("Logic_ques")

            If (counter = 0) Then
                For Each item In collection1.Find(query)
                    Dim id As BsonElement = item.GetElement("Qid")
                    Dim op1 As BsonElement = item.GetElement("OP1")
                    Dim op2 As BsonElement = item.GetElement("OP2")
                    Dim op3 As BsonElement = item.GetElement("OP3")
                    Dim op4 As BsonElement = item.GetElement("OP4")
                    Dim que As BsonElement = item.GetElement("Ques")
                    Dim ca As BsonElement = item.GetElement("CA")

                    QuestionPage_Logc.QNo_label.Text = id.Value
                    QuestionPage_Logc.Ques_label.Text = que.Value
                    QuestionPage_Logc.OP1_RB.Text = op1.Value

                    QuestionPage_Logc.OP2_RB.Text = op2.Value

                    QuestionPage_Logc.OP3_RB.Text = op3.Value

                    QuestionPage_Logc.OP4_RB.Text = op4.Value
                    QuestionPage_Logc.ca_label.Text = ca.Value
                    counter = counter + 1
                Next
            End If

        End Using


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quant_Button.Click
        flag = "Q"
        Quant_Button.Enabled = False
        Label2.ForeColor = Color.DarkGray

        Me.Hide()
        Quantitative.Show()
        Dim mongo As MongoServer = MongoServer.Create
        mongo.Connect()
        Dim db = mongo.GetDatabase("AptitudeMock")
        Dim q As String
        qid = 1
        q = qid
        Dim query = New QueryDocument("Qid", q)

        Using mongo.RequestStart(db)
            Dim collection1 = db.GetCollection(Of BsonDocument)("Quant_ques")

            If (counter = 0) Then

                For Each item In collection1.Find(query)
                    Dim id As BsonElement = item.GetElement("Qid")
                    Dim op1 As BsonElement = item.GetElement("OP1")
                    Dim op2 As BsonElement = item.GetElement("OP2")
                    Dim op3 As BsonElement = item.GetElement("OP3")
                    Dim op4 As BsonElement = item.GetElement("OP4")
                    Dim que As BsonElement = item.GetElement("Ques")
                    Dim ca As BsonElement = item.GetElement("CA")

                    QuestionPage_Quant.QNo_label.Text = id.Value
                    QuestionPage_Quant.Ques_label.Text = que.Value
                    QuestionPage_Quant.OP1_RB.Text = op1.Value

                    QuestionPage_Quant.OP2_RB.Text = op2.Value

                    QuestionPage_Quant.OP3_RB.Text = op3.Value

                    QuestionPage_Quant.OP4_RB.Text = op4.Value
                    QuestionPage_Quant.ca_label.Text = ca.Value
                    counter = counter + 1
                Next
            End If

        End Using



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CP_Button.Click
        flag = "C"
        CP_Button.Enabled = False
        Label3.ForeColor = Color.DarkGray
        Me.Hide()
        compProg.Show()
        Dim mongo As MongoServer = MongoServer.Create
        mongo.Connect()
        Dim db = mongo.GetDatabase("AptitudeMock")
        Dim q As String
        qid = 1
        q = qid
        Dim query = New QueryDocument("Qid", q)

        Using mongo.RequestStart(db)
            Dim collection1 = db.GetCollection(Of BsonDocument)("CP_ques")

            If (counter = 0) Then

                For Each item In collection1.Find(query)
                    Dim id As BsonElement = item.GetElement("Qid")
                    Dim op1 As BsonElement = item.GetElement("OP1")
                    Dim op2 As BsonElement = item.GetElement("OP2")
                    Dim op3 As BsonElement = item.GetElement("OP3")
                    Dim op4 As BsonElement = item.GetElement("OP4")
                    Dim que As BsonElement = item.GetElement("Ques")
                    Dim ca As BsonElement = item.GetElement("CA")

                    QuestionPage_CP.QNo_label.Text = id.Value
                    QuestionPage_CP.Ques_label.Text = que.Value
                    QuestionPage_CP.OP1_RB.Text = op1.Value

                    QuestionPage_CP.OP2_RB.Text = op2.Value

                    QuestionPage_CP.OP3_RB.Text = op3.Value

                    QuestionPage_CP.OP4_RB.Text = op4.Value
                    QuestionPage_CP.ca_label.Text = ca.Value
                    counter = counter + 1
                Next
            End If

        End Using


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eng_button.Click
        flag = "E"
        Eng_button.Enabled = False
        Label4.ForeColor = Color.DarkGray
        Me.Hide()
        VerbalAbility.Show()
        Dim mongo As MongoServer = MongoServer.Create
        'Dim item As BsonDocument
        mongo.Connect()
        Dim db = mongo.GetDatabase("AptitudeMock")
        Dim q As String
        qid = 1
        q = qid
        Dim query = New QueryDocument("Qid", q)

        Using mongo.RequestStart(db)
            Dim collection1 = db.GetCollection(Of BsonDocument)("English_ques")

            If (counter = 0) Then

                For Each item In collection1.Find(query)
                    Dim id As BsonElement = item.GetElement("Qid")
                    Dim op1 As BsonElement = item.GetElement("OP1")
                    Dim op2 As BsonElement = item.GetElement("OP2")
                    Dim op3 As BsonElement = item.GetElement("OP3")
                    Dim op4 As BsonElement = item.GetElement("OP4")
                    Dim que As BsonElement = item.GetElement("Ques")
                    Dim ca As BsonElement = item.GetElement("CA")

                    QuestionPage_English.QNo_label.Text = id.Value
                    QuestionPage_English.Ques_label.Text = que.Value
                    QuestionPage_English.OP1_RB.Text = op1.Value

                    QuestionPage_English.OP2_RB.Text = op2.Value

                    QuestionPage_English.OP3_RB.Text = op3.Value

                    QuestionPage_English.OP4_RB.Text = op4.Value
                    QuestionPage_English.ca_label.Text = ca.Value
                    counter = counter + 1
                Next
            End If

        End Using



    End Sub
End Class