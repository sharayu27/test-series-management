<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegForm2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegForm2))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Submit_Button = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.YearPass_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Email_TextBox = New System.Windows.Forms.TextBox()
        Me.Username_TextBox = New System.Windows.Forms.TextBox()
        Me.Password_TextBox = New System.Windows.Forms.TextBox()
        Me.CP_TextBox = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, 18)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 109)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(242, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Registration Form"
        '
        'Submit_Button
        '
        Me.Submit_Button.Location = New System.Drawing.Point(187, 463)
        Me.Submit_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Submit_Button.Name = "Submit_Button"
        Me.Submit_Button.Size = New System.Drawing.Size(112, 34)
        Me.Submit_Button.TabIndex = 2
        Me.Submit_Button.Text = "Submit"
        Me.Submit_Button.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 145)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "*Year of passing"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 184)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "e-mail ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 230)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Contact"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 275)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "*Username"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 318)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "*Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 360)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 19)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "*Confirm Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(46, 417)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(218, 19)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "To create new user click SUBMIT"
        '
        'YearPass_ComboBox
        '
        Me.YearPass_ComboBox.FormattingEnabled = True
        Me.YearPass_ComboBox.Items.AddRange(New Object() {"2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021"})
        Me.YearPass_ComboBox.Location = New System.Drawing.Point(178, 137)
        Me.YearPass_ComboBox.Name = "YearPass_ComboBox"
        Me.YearPass_ComboBox.Size = New System.Drawing.Size(121, 27)
        Me.YearPass_ComboBox.TabIndex = 10
        '
        'Email_TextBox
        '
        Me.Email_TextBox.Location = New System.Drawing.Point(178, 184)
        Me.Email_TextBox.Name = "Email_TextBox"
        Me.Email_TextBox.Size = New System.Drawing.Size(229, 26)
        Me.Email_TextBox.TabIndex = 11
        '
        'Username_TextBox
        '
        Me.Username_TextBox.Location = New System.Drawing.Point(178, 275)
        Me.Username_TextBox.Name = "Username_TextBox"
        Me.Username_TextBox.Size = New System.Drawing.Size(121, 26)
        Me.Username_TextBox.TabIndex = 13
        '
        'Password_TextBox
        '
        Me.Password_TextBox.Location = New System.Drawing.Point(178, 316)
        Me.Password_TextBox.Name = "Password_TextBox"
        Me.Password_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password_TextBox.Size = New System.Drawing.Size(121, 26)
        Me.Password_TextBox.TabIndex = 14
        '
        'CP_TextBox
        '
        Me.CP_TextBox.Location = New System.Drawing.Point(178, 353)
        Me.CP_TextBox.Name = "CP_TextBox"
        Me.CP_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.CP_TextBox.Size = New System.Drawing.Size(121, 26)
        Me.CP_TextBox.TabIndex = 15
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(178, 228)
        Me.MaskedTextBox1.Mask = "0000000000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(121, 26)
        Me.MaskedTextBox1.TabIndex = 16
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(434, 66)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(389, 457)
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'RegForm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(835, 510)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.CP_TextBox)
        Me.Controls.Add(Me.Password_TextBox)
        Me.Controls.Add(Me.Username_TextBox)
        Me.Controls.Add(Me.Email_TextBox)
        Me.Controls.Add(Me.YearPass_ComboBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Submit_Button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "RegForm2"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Submit_Button As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents YearPass_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Email_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Username_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Password_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CP_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
