Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class StartPage

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mongo As MongoServer = MongoServer.Create
        mongo.Connect()
        Dim flag As Integer
        flag = 0
        Dim db = mongo.GetDatabase("AptitudeMock")
            Dim collection = db.GetCollection(Of BsonDocument)("login")
            Dim query = New QueryDocument("username", TextBox1.Text)
            Dim query1 = New QueryDocument("password", TextBox2.Text)


            For Each item As BsonDocument In collection.Find(query)

                For Each item1 As BsonDocument In collection.Find(query1)
                    flag = 1

                    Me.Hide()
                payment.Show()

                Next

            Next

        If (flag = 0) Then
            MsgBox("Invalid Username or Password")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        RegForm1.Show()
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Button1.Enabled = True
    End Sub

    Private Sub StartPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
