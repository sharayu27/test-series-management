<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuestionPage_Logc
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Ques_label = New System.Windows.Forms.Label()
        Me.QNo_label = New System.Windows.Forms.Label()
        Me.OP4_RB = New System.Windows.Forms.RadioButton()
        Me.OP3_RB = New System.Windows.Forms.RadioButton()
        Me.OP2_RB = New System.Windows.Forms.RadioButton()
        Me.OP1_RB = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Submit_Button = New System.Windows.Forms.Button()
        Me.Clr_Button = New System.Windows.Forms.Button()
        Me.Save_Button = New System.Windows.Forms.Button()
        Me.Next_Button = New System.Windows.Forms.Button()
        Me.Previous_Button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ca_label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.min = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sec = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MAIN.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(18, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 83)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Ques_label
        '
        Me.Ques_label.AutoEllipsis = True
        Me.Ques_label.AutoSize = True
        Me.Ques_label.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Ques_label.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ques_label.Location = New System.Drawing.Point(14, 71)
        Me.Ques_label.Name = "Ques_label"
        Me.Ques_label.Size = New System.Drawing.Size(67, 23)
        Me.Ques_label.TabIndex = 38
        Me.Ques_label.Text = "Label3"
        '
        'QNo_label
        '
        Me.QNo_label.AutoSize = True
        Me.QNo_label.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.QNo_label.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QNo_label.Location = New System.Drawing.Point(132, 9)
        Me.QNo_label.Name = "QNo_label"
        Me.QNo_label.Size = New System.Drawing.Size(67, 23)
        Me.QNo_label.TabIndex = 37
        Me.QNo_label.Text = "Label2"
        '
        'OP4_RB
        '
        Me.OP4_RB.AutoSize = True
        Me.OP4_RB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.OP4_RB.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OP4_RB.Location = New System.Drawing.Point(18, 191)
        Me.OP4_RB.Name = "OP4_RB"
        Me.OP4_RB.Size = New System.Drawing.Size(147, 27)
        Me.OP4_RB.TabIndex = 36
        Me.OP4_RB.TabStop = True
        Me.OP4_RB.Text = "RadioButton4"
        Me.OP4_RB.UseVisualStyleBackColor = False
        '
        'OP3_RB
        '
        Me.OP3_RB.AutoSize = True
        Me.OP3_RB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.OP3_RB.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OP3_RB.Location = New System.Drawing.Point(18, 133)
        Me.OP3_RB.Name = "OP3_RB"
        Me.OP3_RB.Size = New System.Drawing.Size(147, 27)
        Me.OP3_RB.TabIndex = 35
        Me.OP3_RB.TabStop = True
        Me.OP3_RB.Text = "RadioButton3"
        Me.OP3_RB.UseVisualStyleBackColor = False
        '
        'OP2_RB
        '
        Me.OP2_RB.AutoSize = True
        Me.OP2_RB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.OP2_RB.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OP2_RB.Location = New System.Drawing.Point(18, 79)
        Me.OP2_RB.Name = "OP2_RB"
        Me.OP2_RB.Size = New System.Drawing.Size(147, 27)
        Me.OP2_RB.TabIndex = 34
        Me.OP2_RB.TabStop = True
        Me.OP2_RB.Text = "RadioButton2"
        Me.OP2_RB.UseVisualStyleBackColor = False
        '
        'OP1_RB
        '
        Me.OP1_RB.AutoSize = True
        Me.OP1_RB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.OP1_RB.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OP1_RB.Location = New System.Drawing.Point(18, 27)
        Me.OP1_RB.Name = "OP1_RB"
        Me.OP1_RB.Size = New System.Drawing.Size(147, 27)
        Me.OP1_RB.TabIndex = 33
        Me.OP1_RB.TabStop = True
        Me.OP1_RB.Text = "RadioButton1"
        Me.OP1_RB.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 23)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Question no"
        '
        'Submit_Button
        '
        Me.Submit_Button.Enabled = False
        Me.Submit_Button.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit_Button.Location = New System.Drawing.Point(969, 585)
        Me.Submit_Button.Name = "Submit_Button"
        Me.Submit_Button.Size = New System.Drawing.Size(101, 33)
        Me.Submit_Button.TabIndex = 31
        Me.Submit_Button.Text = "Submit"
        Me.Submit_Button.UseVisualStyleBackColor = True
        '
        'Clr_Button
        '
        Me.Clr_Button.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clr_Button.Location = New System.Drawing.Point(267, 585)
        Me.Clr_Button.Name = "Clr_Button"
        Me.Clr_Button.Size = New System.Drawing.Size(101, 33)
        Me.Clr_Button.TabIndex = 30
        Me.Clr_Button.Text = "Clear"
        Me.Clr_Button.UseVisualStyleBackColor = True
        '
        'Save_Button
        '
        Me.Save_Button.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save_Button.Location = New System.Drawing.Point(509, 585)
        Me.Save_Button.Name = "Save_Button"
        Me.Save_Button.Size = New System.Drawing.Size(101, 33)
        Me.Save_Button.TabIndex = 29
        Me.Save_Button.Text = "Save"
        Me.Save_Button.UseVisualStyleBackColor = True
        '
        'Next_Button
        '
        Me.Next_Button.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Next_Button.Location = New System.Drawing.Point(740, 585)
        Me.Next_Button.Name = "Next_Button"
        Me.Next_Button.Size = New System.Drawing.Size(101, 33)
        Me.Next_Button.TabIndex = 28
        Me.Next_Button.Text = "Next"
        Me.Next_Button.UseVisualStyleBackColor = True
        '
        'Previous_Button
        '
        Me.Previous_Button.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Previous_Button.Location = New System.Drawing.Point(33, 585)
        Me.Previous_Button.Name = "Previous_Button"
        Me.Previous_Button.Size = New System.Drawing.Size(97, 33)
        Me.Previous_Button.TabIndex = 27
        Me.Previous_Button.Text = "Previous"
        Me.Previous_Button.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Ques_label)
        Me.Panel1.Controls.Add(Me.QNo_label)
        Me.Panel1.Location = New System.Drawing.Point(18, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1138, 144)
        Me.Panel1.TabIndex = 39
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Controls.Add(Me.ca_label)
        Me.Panel2.Controls.Add(Me.OP2_RB)
        Me.Panel2.Controls.Add(Me.OP1_RB)
        Me.Panel2.Controls.Add(Me.OP3_RB)
        Me.Panel2.Controls.Add(Me.OP4_RB)
        Me.Panel2.Location = New System.Drawing.Point(18, 279)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1138, 255)
        Me.Panel2.TabIndex = 40
        '
        'ca_label
        '
        Me.ca_label.AutoSize = True
        Me.ca_label.Location = New System.Drawing.Point(655, 162)
        Me.ca_label.Name = "ca_label"
        Me.ca_label.Size = New System.Drawing.Size(39, 13)
        Me.ca_label.TabIndex = 0
        Me.ca_label.Text = "Label2"
        Me.ca_label.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(783, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 27)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Time Left :"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1039, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 27)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "sec"
        '
        'min
        '
        Me.min.AutoSize = True
        Me.min.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.min.Location = New System.Drawing.Point(922, 50)
        Me.min.Name = "min"
        Me.min.Size = New System.Drawing.Size(24, 27)
        Me.min.TabIndex = 44
        Me.min.Text = "9"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(953, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 27)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "min"
        '
        'sec
        '
        Me.sec.AutoSize = True
        Me.sec.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sec.Location = New System.Drawing.Point(997, 50)
        Me.sec.Name = "sec"
        Me.sec.Size = New System.Drawing.Size(36, 27)
        Me.sec.TabIndex = 42
        Me.sec.Text = "59"
        '
        'QuestionPage_Logc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.min)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.sec)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Submit_Button)
        Me.Controls.Add(Me.Clr_Button)
        Me.Controls.Add(Me.Save_Button)
        Me.Controls.Add(Me.Next_Button)
        Me.Controls.Add(Me.Previous_Button)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "QuestionPage_Logc"
        Me.Text = "QuestionPage_Logc"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Ques_label As System.Windows.Forms.Label
    Friend WithEvents QNo_label As System.Windows.Forms.Label
    Friend WithEvents OP4_RB As System.Windows.Forms.RadioButton
    Friend WithEvents OP3_RB As System.Windows.Forms.RadioButton
    Friend WithEvents OP2_RB As System.Windows.Forms.RadioButton
    Friend WithEvents OP1_RB As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Submit_Button As System.Windows.Forms.Button
    Friend WithEvents Clr_Button As System.Windows.Forms.Button
    Friend WithEvents Save_Button As System.Windows.Forms.Button
    Friend WithEvents Next_Button As System.Windows.Forms.Button
    Friend WithEvents Previous_Button As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ca_label As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents min As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents sec As System.Windows.Forms.Label
End Class
