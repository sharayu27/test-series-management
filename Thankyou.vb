Imports MongoDB.Driver
Imports MongoDB.Bson

Public Class Thankyou

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mongo As MongoServer = MongoServer.Create
        mongo.Connect()
        Dim str As Integer
        Dim db = mongo.GetDatabase("AptitudeMock")
        Dim collection1 = db.GetCollection("Check_result_quant")
        '  Dim collection2 = db.GetCollection("Check_result_CP")
        ' Dim collection3 = db.GetCollection("Check_result_english")
        'Dim collection4 = db.GetCollection("Check_result_logic")

        Dim query1 = New QueryDocument("Qid", str)
        For Each item As BsonDocument In collection1.Find(query1)
            collection1.Remove(query1)
        Next

        'collection2.Remove(query1)
        'collection3.Remove(query1)
        'collection4.Remove(query1)

        End
       
    End Sub
End Class