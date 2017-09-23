Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class QuestionPage_Quant

    Dim counter As Integer = 0
    Public qid As Integer
    Public sum_q As Integer

    Public flag As Integer = 0
    Public flag1 As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Next_Button.Click

        Dim mongo As MongoServer = MongoServer.Create
        Dim db = mongo.GetDatabase("AptitudeMock")
        Dim str As String
        str = qid + 1


        mongo.Connect()
        Using mongo.RequestStart(db)

            Dim collection = db.GetCollection("Quant_ques")

            Dim op1 As BsonElement
            Dim op2 As BsonElement
            Dim op3 As BsonElement
            Dim op4 As BsonElement
            Dim que As BsonElement
            Dim id As BsonElement
            Dim ca As BsonElement

            Dim query1 = New QueryDocument("Qid", str)

            If Not (counter = 0) Then
                For Each item As BsonDocument In collection.Find(query1)
                    id = item.GetElement("Qid")
                    op1 = item.GetElement("OP1")
                    op2 = item.GetElement("OP2")
                    op3 = item.GetElement("OP3")
                    op4 = item.GetElement("OP4")
                    que = item.GetElement("Ques")
                    ca = item.GetElement("CA")
                    QNo_label.Text = id.Value
                    Ques_label.Text = que.Value
                    OP1_RB.Text = op1.Value
                    OP2_RB.Text = op2.Value
                    OP3_RB.Text = op3.Value
                    OP4_RB.Text = op4.Value
                    ca_label.Text = ca.Value
                    counter = +1
                    qid = qid + 1
                    OP1_RB.Checked = False
                    OP2_RB.Checked = False
                    OP3_RB.Checked = False
                    OP4_RB.Checked = False
                    If (qid = 12) Then
                        Next_Button.Enabled = False
                        Submit_Button.Enabled = True
                    End If
                    
                Next

            End If
            

        End Using
    End Sub

    Private Sub QuestionPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (Next_Button.Enabled = False) Then
            Next_Button.Enabled = True
        End If

        Dim mongo As MongoServer = MongoServer.Create
        mongo.Connect()
        Dim db = mongo.GetDatabase("AptitudeMock")
        Using mongo.RequestStart(db)

            Dim q As String
            qid = 1
            q = qid
            Dim query = New QueryDocument("Qid", q)


            Dim collection = db.GetCollection(Of BsonDocument)("Quant_ques")

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


                    OP1_RB.Checked = False
                    OP2_RB.Checked = False
                    OP3_RB.Checked = False
                    OP4_RB.Checked = False

                    counter = counter + 1





                Next
            End If
        End Using
        AnswerStatus.Label_1.Text = "Not Saved"
        AnswerStatus.Label_2.Text = "Not Saved"
        AnswerStatus.Label_3.Text = "Not Saved"
        AnswerStatus.Label_4.Text = "Not Saved"
        AnswerStatus.Label_5.Text = "Not Saved"
        AnswerStatus.Label_6.Text = "Not Saved"
        AnswerStatus.Label_7.Text = "Not Saved"
        AnswerStatus.Label_8.Text = "Not Saved"
        AnswerStatus.Label_9.Text = "Not Saved"
        AnswerStatus.Label_10.Text = "Not Saved"
        AnswerStatus.Label_11.Text = "Not Saved"
        AnswerStatus.Label_12.Text = "Not Saved"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit_Button.Click
        Me.Hide()
        AnswerStatus.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clr_Button.Click
        OP1_RB.Checked = False
        OP2_RB.Checked = False
        OP3_RB.Checked = False
        OP4_RB.Checked = False
        ' Statuslabel.Visible = False


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save_Button.Click
        Dim mongo As MongoServer = MongoServer.Create
        mongo.Connect()
        Dim db = mongo.GetDatabase("AptitudeMock")
        Dim collection = db.GetCollection(Of BsonDocument)("Check_result_quant")
        Dim ans As String
        Dim res As BsonDocument = New BsonDocument()
        flag = 1
        If (OP1_RB.Checked = False And OP2_RB.Checked = False And OP3_RB.Checked = False And OP4_RB.Checked = False) Then
            MsgBox("Please select a option")
        End If

        If (OP1_RB.Checked = True) Then
            ans = OP1_RB.Text
        ElseIf (OP2_RB.Checked = True) Then
            ans = OP2_RB.Text
        ElseIf (OP3_RB.Checked = True) Then
            ans = OP3_RB.Text
        ElseIf (OP4_RB.Checked = True) Then
            ans = OP4_RB.Text
        End If
        Using mongo.RequestStart(db)
            If Not (OP1_RB.Checked = False And OP2_RB.Checked = False And OP3_RB.Checked = False And OP4_RB.Checked = False) Then
                res.Add("Qid", qid)
                res.Add("Save_ans", ans)
                res.Add("CA", ca_label.Text)

                collection.Insert(res)

                Select Case qid
                    Case (1)
                        AnswerStatus.Label_1.Text = "Saved"
                    Case (2)
                        AnswerStatus.Label_2.Text = "Saved"
                    Case (3)
                        AnswerStatus.Label_3.Text = "Saved"
                    Case (4)
                        AnswerStatus.Label_4.Text = "Saved"
                    Case (5)
                        AnswerStatus.Label_5.Text = "Saved"
                    Case (6)
                        AnswerStatus.Label_6.Text = "Saved"
                    Case (7)
                        AnswerStatus.Label_7.Text = "Saved"
                    Case (8)
                        AnswerStatus.Label_8.Text = "Saved"
                    Case (9)
                        AnswerStatus.Label_9.Text = "Saved"
                    Case (10)
                        AnswerStatus.Label_10.Text = "Saved"
                    Case (11)
                        AnswerStatus.Label_11.Text = "Saved"
                    Case (12)
                        AnswerStatus.Label_12.Text = "Saved"
                End Select

                ' Statuslabel.Visible = True

            End If
            If Not (OP1_RB.Checked = False And OP2_RB.Checked = False And OP3_RB.Checked = False And OP4_RB.Checked = False) Then
                MsgBox("Your answer is saved")
            End If
            If (ans = ca_label.Text) Then
                sum_q = sum_q + 1
            Else
                sum_q = sum_q
            End If
        End Using
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Previous_Button.Click
        flag1 = "u"
        Dim mongo As MongoServer = MongoServer.Create
        Dim db = mongo.GetDatabase("AptitudeMock")
        Dim str As String


        str = qid - 1
        
        mongo.Connect()
        Using mongo.RequestStart(db)

            Dim collection = db.GetCollection(Of BsonDocument)("Quant_ques")

            Dim id As BsonElement
            Dim op1 As BsonElement
            Dim op2 As BsonElement
            Dim op3 As BsonElement
            Dim op4 As BsonElement
            Dim que As BsonElement
            Dim ca As BsonElement
            Dim query1 = New QueryDocument("Qid", str)

            If Not (counter = 0) Then

                For Each item As BsonDocument In collection.Find(query1)
                    id = item.GetElement("Qid")
                    op1 = item.GetElement("OP1")
                    op2 = item.GetElement("OP2")
                    op3 = item.GetElement("OP3")
                    op4 = item.GetElement("OP4")
                    que = item.GetElement("Ques")
                    ca = item.GetElement("CA")

                    QNo_label.Text = id.Value
                    Ques_label.Text = que.Value


                    OP1_RB.Text = op1.Value

                    OP2_RB.Text = op2.Value

                    OP3_RB.Text = op3.Value

                    OP4_RB.Text = op4.Value
                    ca_label.Text = ca.Value

                    counter = +1
                    qid = qid - 1
                    If (qid = 14) Then
                        Next_Button.Enabled = False
                        Submit_Button.Enabled = True
                    End If
                Next



            End If

        End Using
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
End Class





