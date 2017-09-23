Imports MongoDB.Bson

Imports MongoDB.Driver
Public Class checkanswer_verbal
    Dim counter As Integer = 0
    Public qid As Integer
    Public sum_e As Integer
    Public flag As Integer = 0
    Dim flag1 As String


    Private Sub checkanswer_verbal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub Button_PREV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_PREV.Click
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

    Private Sub Button_NEXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_NEXT.Click
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
                    '    If (qid = 13) Then
                    'Me.Hide()
                    'Result.Show()

                    '                    End If
                Next
            End If

        End Using

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Result.Show()

    End Sub
End Class