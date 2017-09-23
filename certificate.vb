Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class certificate

    Private Sub certificate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Dim mongo As MongoServer = MongoServer.Create
        'mongo.Connect()
        Dim mongo As MongoServer = MongoServer.Create
        mongo.Connect()


        Dim db = mongo.GetDatabase("AptitudeMock")
        Dim collection = db.GetCollection(Of BsonDocument)("regform")
        Dim query = New QueryDocument("username", StartPage.TextBox1.Text)



        For Each item As BsonDocument In collection.Find(query)
            Dim name As BsonElement = item.GetElement("name")

            Label1.Text= name.Value()

           

        Next

       
    
        Label2.Text = Result.Result_Label.Text
        Label7.Text = Now.Date


    End Sub

   

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Thankyou.Show()
    End Sub

End Class