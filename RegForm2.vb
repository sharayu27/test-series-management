Imports MongoDB.Bson
Imports System.Text.RegularExpressions

Imports MongoDB.Driver
Public Class RegForm2
    Dim log1 As BsonDocument = New BsonDocument()
    Private PhoneValid As Boolean 'Is Phone Number Valid?
    Private EmailValid As Boolean 'Is Email Valid?


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit_Button.Click
        If Not (Password_TextBox.Text = CP_TextBox.Text) Then

            MsgBox("Please enter password again")
            Password_TextBox.Clear()
            CP_TextBox.Clear()

        Else

            Dim mongo As MongoServer = MongoServer.Create
            Dim db = mongo.GetDatabase("AptitudeMock")
            Dim collection = db.GetCollection(Of BsonDocument)("regform")
            Dim precollection = db.GetCollection(Of BsonDocument)("login")
            Dim Log As BsonDocument = New BsonDocument
            Log = RegForm1.log
            log1.Add("YOP", YearPass_ComboBox.Text)
            log1.Add("email", Trim(Email_TextBox.Text))
            log1.Add("contact", MaskedTextBox1.Text)
            log1.Add("username", Trim(Username_TextBox.Text))
            log1.Add("password", Trim(Password_TextBox.Text))

            collection.Insert(log1)
            collection.Insert(Log)
            precollection.Insert(log1)

            If Not (MaskedTextBox1.Text.Length = 10) Then
                MsgBox("Please enter correct mobile number")
            Else
                MsgBox("Password generated successfully")
            End If
            Me.Hide()
            StartPage.Show()
        End If
    End Sub

    Private Sub ValidateEmail()
        'Set Up Reg Exp Pattern To Allow Most Characters, And No Special Characters
        Dim reEmail As Regex = New Regex("([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\." + _
        ")|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})", _
        RegexOptions.IgnoreCase _
        Or RegexOptions.CultureInvariant _
        Or RegexOptions.IgnorePatternWhitespace _
        Or RegexOptions.Compiled _
        )

        Dim blnPossibleMatch As Boolean = reEmail.IsMatch(Email_TextBox.Text)

        If blnPossibleMatch Then

            'Check If Entered Email Is In Correct Format
            If Not Email_TextBox.Text.Equals(reEmail.Match(Email_TextBox.Text).ToString) Then

                MessageBox.Show("Invalid Email Address!")

            Else

                EmailValid = True 'Email is Perfect

            End If

        Else 'Not A Match To Pattern

            EmailValid = False 'Set Boolean Variable To False

            MessageBox.Show("Invalid Email Address!") 'Inform User

            Email_TextBox.Clear() 'Clear Textbox

            Email_TextBox.Focus() 'Set Focus To TextBox

        End If
    End Sub

    Private Sub Email_TextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Email_TextBox.LostFocus
        ValidateEmail() 'Check Email Validity
    End Sub

    Private Sub Email_TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Email_TextBox.TextChanged

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Private Sub RegForm2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class