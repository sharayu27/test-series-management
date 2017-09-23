<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegForm1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegForm1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FirstName_TextBox = New System.Windows.Forms.TextBox()
        Me.Age_TextBox = New System.Windows.Forms.TextBox()
        Me.Male_RadioButton = New System.Windows.Forms.RadioButton()
        Me.Female_RadioButton = New System.Windows.Forms.RadioButton()
        Me.LastName_TextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.CP_TextBox = New System.Windows.Forms.TextBox()
        Me.Password_TextBox = New System.Windows.Forms.TextBox()
        Me.Username_TextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Next_Button = New System.Windows.Forms.Button()
        Me.College_ComboBox = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(260, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Registration Form"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(119, 116)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Date of birth"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(117, 196)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Gender"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(117, 232)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "College"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Location = New System.Drawing.Point(120, 160)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 19)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Age"
        '
        'FirstName_TextBox
        '
        Me.FirstName_TextBox.Location = New System.Drawing.Point(260, 73)
        Me.FirstName_TextBox.Name = "FirstName_TextBox"
        Me.FirstName_TextBox.Size = New System.Drawing.Size(121, 26)
        Me.FirstName_TextBox.TabIndex = 13
        '
        'Age_TextBox
        '
        Me.Age_TextBox.Enabled = False
        Me.Age_TextBox.Location = New System.Drawing.Point(260, 157)
        Me.Age_TextBox.Name = "Age_TextBox"
        Me.Age_TextBox.Size = New System.Drawing.Size(121, 26)
        Me.Age_TextBox.TabIndex = 15
        '
        'Male_RadioButton
        '
        Me.Male_RadioButton.AutoSize = True
        Me.Male_RadioButton.Location = New System.Drawing.Point(260, 194)
        Me.Male_RadioButton.Name = "Male_RadioButton"
        Me.Male_RadioButton.Size = New System.Drawing.Size(58, 23)
        Me.Male_RadioButton.TabIndex = 17
        Me.Male_RadioButton.TabStop = True
        Me.Male_RadioButton.Text = "Male"
        Me.Male_RadioButton.UseVisualStyleBackColor = True
        '
        'Female_RadioButton
        '
        Me.Female_RadioButton.AutoSize = True
        Me.Female_RadioButton.Location = New System.Drawing.Point(367, 194)
        Me.Female_RadioButton.Name = "Female_RadioButton"
        Me.Female_RadioButton.Size = New System.Drawing.Size(71, 23)
        Me.Female_RadioButton.TabIndex = 18
        Me.Female_RadioButton.TabStop = True
        Me.Female_RadioButton.Text = "Female"
        Me.Female_RadioButton.UseVisualStyleBackColor = True
        '
        'LastName_TextBox
        '
        Me.LastName_TextBox.Location = New System.Drawing.Point(609, 73)
        Me.LastName_TextBox.Name = "LastName_TextBox"
        Me.LastName_TextBox.Size = New System.Drawing.Size(135, 26)
        Me.LastName_TextBox.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(506, 76)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 19)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Last Name"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(260, 116)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(244, 26)
        Me.DateTimePicker1.TabIndex = 25
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(260, 274)
        Me.MaskedTextBox1.Mask = "0000000000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(121, 26)
        Me.MaskedTextBox1.TabIndex = 35
        '
        'CP_TextBox
        '
        Me.CP_TextBox.Location = New System.Drawing.Point(260, 398)
        Me.CP_TextBox.Name = "CP_TextBox"
        Me.CP_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.CP_TextBox.Size = New System.Drawing.Size(121, 26)
        Me.CP_TextBox.TabIndex = 34
        '
        'Password_TextBox
        '
        Me.Password_TextBox.Location = New System.Drawing.Point(260, 357)
        Me.Password_TextBox.Name = "Password_TextBox"
        Me.Password_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password_TextBox.Size = New System.Drawing.Size(121, 26)
        Me.Password_TextBox.TabIndex = 33
        '
        'Username_TextBox
        '
        Me.Username_TextBox.Location = New System.Drawing.Point(260, 316)
        Me.Username_TextBox.Name = "Username_TextBox"
        Me.Username_TextBox.Size = New System.Drawing.Size(121, 26)
        Me.Username_TextBox.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(117, 405)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 19)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "*Confirm Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(119, 364)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 19)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "*Password"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(117, 323)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 19)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "*Username"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(119, 277)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 19)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Contact"
        '
        'Next_Button
        '
        Me.Next_Button.Location = New System.Drawing.Point(548, 463)
        Me.Next_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Next_Button.Name = "Next_Button"
        Me.Next_Button.Size = New System.Drawing.Size(112, 34)
        Me.Next_Button.TabIndex = 36
        Me.Next_Button.Text = "Submit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Next_Button.UseVisualStyleBackColor = True
        '
        'College_ComboBox
        '
        Me.College_ComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.College_ComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.College_ComboBox.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.College_ComboBox.FormattingEnabled = True
        Me.College_ComboBox.Items.AddRange(New Object() {"Sinhgad college of engineering,vadgaon", "Smt. kashibai navale college of engineering", "NBN sinhgad school of engineering", "RMD sinhgad college of engineering", "Pune institute of computer technology", "Maharashtra institute of technolgy", "Pue vidhyarathi gruah", "CUMMINS girls college of engineering", "Vishvakarama institute of technology ", "D.Y.Patil of engineering", "Symboisistechnial institues", "J.S.P.M College of engineering"})
        Me.College_ComboBox.Location = New System.Drawing.Point(260, 228)
        Me.College_ComboBox.Name = "College_ComboBox"
        Me.College_ComboBox.Size = New System.Drawing.Size(244, 23)
        Me.College_ComboBox.TabIndex = 37
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(492, 57)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(398, 459)
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 111)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'RegForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(835, 510)
        Me.Controls.Add(Me.College_ComboBox)
        Me.Controls.Add(Me.Next_Button)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.CP_TextBox)
        Me.Controls.Add(Me.Password_TextBox)
        Me.Controls.Add(Me.Username_TextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LastName_TextBox)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Female_RadioButton)
        Me.Controls.Add(Me.Male_RadioButton)
        Me.Controls.Add(Me.Age_TextBox)
        Me.Controls.Add(Me.FirstName_TextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "RegForm1"
        Me.Text = "Form1"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents FirstName_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Age_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Male_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Female_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LastName_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CP_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Password_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Username_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Next_Button As System.Windows.Forms.Button
    Friend WithEvents College_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
