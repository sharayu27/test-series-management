Imports MongoDB.Bson
Imports MongoDB.Driver
Imports System.Text.RegularExpressions

Public Class RegForm1
    Public Shared log As BsonDocument = New BsonDocument()


    Private NameValid As Boolean 'Is Name  Valid?

    Private SurnameValid As Boolean 'Is Surname Valid?

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
            Log.Add("name", Trim(FirstName_TextBox.Text + LastName_TextBox.Text))
            Log.Add("Dob", Trim(DateTimePicker1.Text))
            Log.Add("college", Trim(College_ComboBox.Text))
            Log.Add("gender", Male_RadioButton.Checked Or Female_RadioButton.Checked)
            Log.Add("age", Age_TextBox.Text)

            Log.Add("contact", MaskedTextBox1.Text)
            Log.Add("username", Trim(Username_TextBox.Text))
            Log.Add("password", Trim(Password_TextBox.Text))


            collection.Insert(Log)
            precollection.Insert(Log)

            If Not (MaskedTextBox1.Text.Length = 10) Then
                MsgBox("Please enter correct mobile number")
            Else
                MsgBox("Password generated successfully")
            End If
            Me.Hide()
            StartPage.Show()
        End If
        Me.Hide()
        RegForm2.Show()

    End Sub





    'Private Sub FirstName_TextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FirstName_TextBox.TextChanged
    'If Not A Matching Format Entered
    '    If Not Regex.Match(FirstName_TextBox.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then 'Only Letters

    '       MessageBox.Show("Please Enter Alphabetic Characters Only!") 'Inform User
    '
    '       FirstName_TextBox.Focus() 'Return Focus
    '      FirstName_TextBox.Clear() 'Clear TextBox
    '
    '       NameValid = False 'Boolean = False
    '  Else
    '
    '       NameValid = True 'Everything Fine
    '
    '   End If
    'End Sub

    'Private Sub LastName_TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ''Create A Pattern For Surname
    'Dim strSurname As String = "^[a-zA-Z\s]+$"

    'Dim reSurname As New Regex(strSurname) 'Attach Pattern To Surname Textbox

    'Not A Match
    '   If Not reSurname.IsMatch(LastName_TextBox.Text) Then

    '        MessageBox.Show("Please Enter Alphabetic Characters Only!")

    '       LastName_TextBox.Focus()

    '        LastName_TextBox.Clear()

    '       SurnameValid = False

    '    Else

    '       SurnameValid = True

    '    End If
    '    End Sub



    Private Sub Next_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Next_Button.Click

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
            Dim log1 As BsonDocument = New BsonDocument
            Log = RegForm1.log
            Log.Add("name", Trim(FirstName_TextBox.Text + LastName_TextBox.Text))
            Log.Add("Dob", Trim(DateTimePicker1.Text))
            Log.Add("college", Trim(College_ComboBox.Text))
            Log.Add("gender", Male_RadioButton.Checked Or Female_RadioButton.Checked)
            Log.Add("age", Age_TextBox.Text)
            Log.Add("contact", MaskedTextBox1.Text)
            Log.Add("username", Trim(Username_TextBox.Text))
            Log.Add("password", Trim(Password_TextBox.Text))
            log1.Add("username", Trim(Username_TextBox.Text))
            log1.Add("password", Trim(Password_TextBox.Text))

            collection.Insert(Log)
            precollection.Insert(log1)

            If Not (MaskedTextBox1.Text.Length = 10) Then
                MsgBox("Please enter correct mobile number")
            Else
                MsgBox("Password generated successfully")
                Me.Hide()
                StartPage.Show()
            End If
        End If
        Me.Hide()
        StartPage.Show()

    End Sub


    Private Sub DateTimePicker1_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Dim year As Integer = (DateDiff(Microsoft.VisualBasic.DateInterval.Day, DateTimePicker1.Value, Now) / 365)
        Age_TextBox.Text = year

    End Sub

    Private Sub Age_TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Age_TextBox.TextChanged
        If (Age_TextBox.Text < 18) Then
            MsgBox("Age not valid")
            Me.Hide()
            StartPage.Show()
        End If
    End Sub

    
 
    Private Sub FirstName_TextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles FirstName_TextBox.Validating
        If IsNumeric(FirstName_TextBox.Text) Then
            ErrorProvider1.SetError(FirstName_TextBox, "enter only characters")
            e.Cancel = True
        ElseIf FirstName_TextBox.Text = "" Then
            ErrorProvider1.SetError(FirstName_TextBox, "please enter first name")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(FirstName_TextBox, "")
        End If

    End Sub

    Private Sub LastName_TextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LastName_TextBox.Validating
        If IsNumeric(LastName_TextBox.Text) Then
            ErrorProvider1.SetError(LastName_TextBox, "enter only characters")
            e.Cancel = True
        ElseIf LastName_TextBox.Text = "" Then
            ErrorProvider1.SetError(LastName_TextBox, "please enter first name")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(LastName_TextBox, "")
        End If
    End Sub

   
End Class