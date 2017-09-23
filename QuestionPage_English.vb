Imports MongoDB.Bson

Imports MongoDB.Driver

Public Class QuestionPage_English
    Dim counter As Integer = 0
    Public qid As Integer
    Public sum_e As Integer
    Public flag As Integer = 0
    Dim flag1 As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles next_Button.Click
        

        Dim mongo As MongoServer = MongoServer.Create
        Dim db = mongo.GetDatabase("AptitudeMock")
        Dim str As String
        str = qid + 1

        mongo.Connect()
        Using mongo.RequestStart(db)

            Dim collection = db.GetCollection("English_ques")

            Dim op1 As BsonElement
            Dim op2 As BsonElement
            Dim op3 As BsonElement
            Dim op4 As BsonElement
            Dim que As BsonElement
            Dim id As BsonElement
            Dim query1 = New QueryDocument("Qid", str)

            If Not (counter = 0) Then
                For Each item As BsonDocument In collection.Find(query1)
                    id = item.GetElement("Qid")
                    op1 = item.GetElement("OP1")
                    op2 = item.GetElement("OP2")
                    op3 = item.GetElement("OP3")
                    op4 = item.GetElement("OP4")
                    que = item.GetElement("Ques")
                    Dim ca As BsonElement = item.GetElement("CA")
                    ca_label.Text = ca.Value
                    QNo_label.Text = id.Value
                    Ques_label.Text = que.Value
                    OP1_RB.Text = op1.Value
                    OP2_RB.Text = op2.Value
                    OP3_RB.Text = op3.Value
                    OP4_RB.Text = op4.Value

                    counter = +1
                    qid = qid + 1

                    OP1_RB.Checked = False
                    OP2_RB.Checked = False
                    OP3_RB.Checked = False
                    OP4_RB.Checked = False
                    If (qid = 13) Then
                        AnswerStatus1.Label_13.Visible = True
                        AnswerStatus1.Label18.Visible = True
                        AnswerStatus1.RectangleShape2.Visible = True
                        AnswerStatus1.LineShape10.Visible = True
                        next_Button.Enabled = False
                        submit_Button.Enabled = True
                    End If
                Next
            End If
            
        End Using
       
    End Sub

    Private Sub Pre_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pre_Button.Click
        If (next_Button.Enabled = False) Then
            next_Button.Enabled = True
        End If

        Dim mongo As MongoServer = MongoServer.Create
        Dim db = mongo.GetDatabase("AptitudeMock")
        Dim str As String
        str = qid - 1
       
        mongo.Connect()
        Using mongo.RequestStart(db)


            Dim collection = db.GetCollection(Of BsonDocument)("English_ques")


            Dim id As BsonElement
            Dim op1 As BsonElement
            Dim op2 As BsonElement
            Dim op3 As BsonElement
            Dim op4 As BsonElement
            Dim que As BsonElement
            Dim query1 = New QueryDocument("Qid", str)

            If Not (counter = 0) Then

                For Each item As BsonDocument In collection.Find(query1)
                    id = item.GetElement("Qid")
                    op1 = item.GetElement("OP1")
                    op2 = item.GetElement("OP2")
                    op3 = item.GetElement("OP3")
                    op4 = item.GetElement("OP4")
                    que = item.GetElement("Ques")
                    Dim ca As BsonElement = item.GetElement("CA")
                    ca_label.Text = ca.Value
                    QNo_label.Text = id.Value
                    Ques_label.Text = que.Value


                    OP1_RB.Text = op1.Value

                    OP2_RB.Text = op2.Value

                    OP3_RB.Text = op3.Value

                    OP4_RB.Text = op4.Value
                    counter = +1
                    qid = qid - 1
                Next



            End If

        End Using
    End Sub

    Private Sub Clear_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear_Button.Click
        OP1_RB.Checked = False
        OP2_RB.Checked = False
        OP3_RB.Checked = False
        OP4_RB.Checked = False


    End Sub

    Private Sub save_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_Button.Click
        Dim mongo As MongoServer = MongoServer.Create
        mongo.Connect()
        Dim db = mongo.GetDatabase("AptitudeMock")
        Dim collection = db.GetCollection(Of BsonDocument)("Check_result_english")
        Dim ans As String
        Dim res As BsonDocument = New BsonDocument()
        flag = 1
        If (OP1_RB.Checked = False And OP2_RB.Checked = False And OP3_RB.Checked = False And OP4_RB.Checked = False) Then
            MsgBox("Please select a option")

        ElseIf (OP1_RB.Checked = True) Then
            ans = OP1_RB.Text
        ElseIf (OP2_RB.Checked = True) Then
            ans = OP2_RB.Text
        ElseIf (OP3_RB.Checked = True) Then
            ans = OP3_RB.Text
        ElseIf (OP4_RB.Checked = True) Then
            ans = OP4_RB.Text
        End If
        Using mongo.RequestStart(db)

            res.Add("Qid", qid)
            res.Add("Save_ans", ans)
            res.Add("CA", ca_label.Text)
            collection.Insert(res)


            Select Case qid
                Case (1)
                    AnswerStatus1.Label_1.Text = "Saved"
                Case (2)
                    AnswerStatus1.Label_2.Text = "Saved"
                Case (3)
                    AnswerStatus1.Label_3.Text = "Saved"
                Case (4)
                    AnswerStatus1.Label_4.Text = "Saved"
                Case (5)
                    AnswerStatus1.Label_5.Text = "Saved"
                Case (6)
                    AnswerStatus1.Label_6.Text = "Saved"
                Case (7)
                    AnswerStatus1.Label_7.Text = "Saved"
                Case (8)
                    AnswerStatus1.Label_8.Text = "Saved"
                Case (9)
                    AnswerStatus1.Label_9.Text = "Saved"
                Case (10)
                    AnswerStatus1.Label_10.Text = "Saved"
                Case (11)
                    AnswerStatus1.Label_11.Text = "Saved"
                Case (12)
                    AnswerStatus1.Label_12.Text = "Saved"
                Case (13)
                    AnswerStatus1.Label_13.Text = "Saved"
            End Select
            If Not (OP1_RB.Checked = False And OP2_RB.Checked = False And OP3_RB.Checked = False And OP4_RB.Checked = False) Then
                MsgBox("your answer is saved")
            End If
            If (ans = ca_label.Text) Then
                sum_e = sum_e + 1
            Else
                sum_e = sum_e
            End If
        End Using
    End Sub

    Private Sub submit_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit_Button.Click
        Me.Hide()
        If (ModulesName.flag = "Q" Or ModulesName.flag = "C") Then
            AnswerStatus.Show()
        Else
            AnswerStatus1.Show()
        End If


    End Sub

    Private Sub QuestionPage_English_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mongo As MongoServer = MongoServer.Create

        mongo.Connect()
        Dim db = mongo.GetDatabase("AptitudeMock")
        Using mongo.RequestStart(db)

            Dim q As String
            qid = 1
            q = qid
            Dim query = New QueryDocument("Qid", q)


            Dim collection = db.GetCollection(Of BsonDocument)("English_ques")

            If (counter = 0) Then

                For Each item In collection.Find(query)
                    Dim id As BsonElement = item.GetElement("Qid")

                    Dim que As BsonElement = item.GetElement("Ques")
                    Dim op1 As BsonElement = item.GetElement("OP1")
                    Dim op2 As BsonElement = item.GetElement("OP2")
                    Dim op3 As BsonElement = item.GetElement("OP3")
                    Dim op4 As BsonElement = item.GetElement("OP4")
                    Dim ca As BsonElement = item.GetElement("CA")
                    QNo_label.Text = id.Value
                    ca_label.Text = ca.Value
                    QNo_label.Text = id.Value
                    Ques_label.Text = que.Value
                    OP1_RB.Text = op1.Value
                    OP2_RB.Text = op2.Value
                    OP3_RB.Text = op3.Value
                    OP4_RB.Text = op4.Value
                    counter = counter + 1

                Next
            End If
        End Using
        AnswerStatus1.Label_1.Text = "Not Saved"
        AnswerStatus1.Label_2.Text = "Not Saved"
        AnswerStatus1.Label_3.Text = "Not Saved"
        AnswerStatus1.Label_4.Text = "Not Saved"
        AnswerStatus1.Label_5.Text = "Not Saved"
        AnswerStatus1.Label_6.Text = "Not Saved"
        AnswerStatus1.Label_7.Text = "Not Saved"
        AnswerStatus1.Label_8.Text = "Not Saved"
        AnswerStatus1.Label_9.Text = "Not Saved"
        AnswerStatus1.Label_10.Text = "Not Saved"
        AnswerStatus1.Label_11.Text = "Not Saved"
        AnswerStatus1.Label_12.Text = "Not Saved"
        AnswerStatus1.Label_13.Text = "Not Saved"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If sec.Text = "0" Then
            sec.Text = "59"
            min.Text = min.Text - 1
        End If

        sec.Text = sec.Text - 1

        If (min.Text = "0" And sec.Text = "0") Then
            Timer1.Enabled = False
            MsgBox("Sorry, TIME UP!!!")
            Me.Hide()
            ModulesName.Show()
        End If
        If sec.Text = "59" Then

            sec.Text = "00"

        End If
    End Sub

    Private Sub min_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles min.Click

    End Sub
End Class
