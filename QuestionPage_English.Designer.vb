<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuestionPage_English
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
        Me.submit_Button = New System.Windows.Forms.Button()
        Me.Clear_Button = New System.Windows.Forms.Button()
        Me.save_Button = New System.Windows.Forms.Button()
        Me.next_Button = New System.Windows.Forms.Button()
        Me.Pre_Button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Ques_label = New System.Windows.Forms.Label()
        Me.QNo_label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ca_label = New System.Windows.Forms.Label()
        Me.OP4_RB = New System.Windows.Forms.RadioButton()
        Me.OP1_RB = New System.Windows.Forms.RadioButton()
        Me.OP3_RB = New System.Windows.Forms.RadioButton()
        Me.OP2_RB = New System.Windows.Forms.RadioButton()
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
        'submit_Button
        '
        Me.submit_Button.Enabled = False
        Me.submit_Button.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit_Button.Location = New System.Drawing.Point(1005, 585)
        Me.submit_Button.Name = "submit_Button"
        Me.submit_Button.Size = New System.Drawing.Size(101, 33)
        Me.submit_Button.TabIndex = 19
        Me.submit_Button.Text = "Submit"
        Me.submit_Button.UseVisualStyleBackColor = True
        '
        'Clear_Button
        '
        Me.Clear_Button.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear_Button.Location = New System.Drawing.Point(282, 585)
        Me.Clear_Button.Name = "Clear_Button"
        Me.Clear_Button.Size = New System.Drawing.Size(101, 33)
        Me.Clear_Button.TabIndex = 18
        Me.Clear_Button.Text = "Clear"
        Me.Clear_Button.UseVisualStyleBackColor = True
        '
        'save_Button
        '
        Me.save_Button.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_Button.Location = New System.Drawing.Point(535, 585)
        Me.save_Button.Name = "save_Button"
        Me.save_Button.Size = New System.Drawing.Size(101, 33)
        Me.save_Button.TabIndex = 17
        Me.save_Button.Text = "Save"
        Me.save_Button.UseVisualStyleBackColor = True
        '
        'next_Button
        '
        Me.next_Button.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.next_Button.Location = New System.Drawing.Point(776, 585)
        Me.next_Button.Name = "next_Button"
        Me.next_Button.Size = New System.Drawing.Size(101, 33)
        Me.next_Button.TabIndex = 16
        Me.next_Button.Text = "Next"
        Me.next_Button.UseVisualStyleBackColor = True
        '
        'Pre_Button
        '
        Me.Pre_Button.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pre_Button.Location = New System.Drawing.Point(33, 585)
        Me.Pre_Button.Name = "Pre_Button"
        Me.Pre_Button.Size = New System.Drawing.Size(97, 33)
        Me.Pre_Button.TabIndex = 15
        Me.Pre_Button.Text = "Previous"
        Me.Pre_Button.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Ques_label)
        Me.Panel1.Controls.Add(Me.QNo_label)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(18, 117)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1138, 144)
        Me.Panel1.TabIndex = 25
        '
        'Ques_label
        '
        Me.Ques_label.AutoEllipsis = True
        Me.Ques_label.AutoSize = True
        Me.Ques_label.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ques_label.Location = New System.Drawing.Point(19, 60)
        Me.Ques_label.Name = "Ques_label"
        Me.Ques_label.Size = New System.Drawing.Size(67, 23)
        Me.Ques_label.TabIndex = 29
        Me.Ques_label.Text = "Label3"
        '
        'QNo_label
        '
        Me.QNo_label.AutoSize = True
        Me.QNo_label.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QNo_label.Location = New System.Drawing.Point(137, 13)
        Me.QNo_label.Name = "QNo_label"
        Me.QNo_label.Size = New System.Drawing.Size(67, 23)
        Me.QNo_label.TabIndex = 28
        Me.QNo_label.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 23)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Question no"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Controls.Add(Me.ca_label)
        Me.Panel2.Controls.Add(Me.OP4_RB)
        Me.Panel2.Controls.Add(Me.OP1_RB)
        Me.Panel2.Controls.Add(Me.OP3_RB)
        Me.Panel2.Controls.Add(Me.OP2_RB)
        Me.Panel2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(18, 283)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1138, 255)
        Me.Panel2.TabIndex = 27
        '
        'ca_label
        '
        Me.ca_label.AutoSize = True
        Me.ca_label.Location = New System.Drawing.Point(613, 168)
        Me.ca_label.Name = "ca_label"
        Me.ca_label.Size = New System.Drawing.Size(67, 23)
        Me.ca_label.TabIndex = 31
        Me.ca_label.Text = "Label2"
        Me.ca_label.Visible = False
        '
        'OP4_RB
        '
        Me.OP4_RB.AutoSize = True
        Me.OP4_RB.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OP4_RB.Location = New System.Drawing.Point(23, 190)
        Me.OP4_RB.Name = "OP4_RB"
        Me.OP4_RB.Size = New System.Drawing.Size(147, 27)
        Me.OP4_RB.TabIndex = 30
        Me.OP4_RB.TabStop = True
        Me.OP4_RB.Text = "RadioButton4"
        Me.OP4_RB.UseVisualStyleBackColor = True
        '
        'OP1_RB
        '
        Me.OP1_RB.AutoSize = True
        Me.OP1_RB.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OP1_RB.Location = New System.Drawing.Point(23, 17)
        Me.OP1_RB.Name = "OP1_RB"
        Me.OP1_RB.Size = New System.Drawing.Size(147, 27)
        Me.OP1_RB.TabIndex = 27
        Me.OP1_RB.TabStop = True
        Me.OP1_RB.Text = "RadioButton1"
        Me.OP1_RB.UseVisualStyleBackColor = True
        '
        'OP3_RB
        '
        Me.OP3_RB.AutoSize = True
        Me.OP3_RB.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OP3_RB.Location = New System.Drawing.Point(23, 133)
        Me.OP3_RB.Name = "OP3_RB"
        Me.OP3_RB.Size = New System.Drawing.Size(147, 27)
        Me.OP3_RB.TabIndex = 29
        Me.OP3_RB.TabStop = True
        Me.OP3_RB.Text = "RadioButton3"
        Me.OP3_RB.UseVisualStyleBackColor = True
        '
        'OP2_RB
        '
        Me.OP2_RB.AutoSize = True
        Me.OP2_RB.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OP2_RB.Location = New System.Drawing.Point(23, 74)
        Me.OP2_RB.Name = "OP2_RB"
        Me.OP2_RB.Size = New System.Drawing.Size(147, 27)
        Me.OP2_RB.TabIndex = 28
        Me.OP2_RB.TabStop = True
        Me.OP2_RB.Text = "RadioButton2"
        Me.OP2_RB.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(790, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 27)
        Me.Label2.TabIndex = 28
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
        Me.Label5.Location = New System.Drawing.Point(1043, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 27)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "sec"
        '
        'min
        '
        Me.min.AutoSize = True
        Me.min.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.min.Location = New System.Drawing.Point(926, 56)
        Me.min.Name = "min"
        Me.min.Size = New System.Drawing.Size(24, 27)
        Me.min.TabIndex = 38
        Me.min.Text = "9"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(957, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 27)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "min"
        '
        'sec
        '
        Me.sec.AutoSize = True
        Me.sec.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sec.Location = New System.Drawing.Point(1001, 56)
        Me.sec.Name = "sec"
        Me.sec.Size = New System.Drawing.Size(36, 27)
        Me.sec.TabIndex = 36
        Me.sec.Text = "59"
        '
        'QuestionPage_English
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
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.submit_Button)
        Me.Controls.Add(Me.Clear_Button)
        Me.Controls.Add(Me.save_Button)
        Me.Controls.Add(Me.next_Button)
        Me.Controls.Add(Me.Pre_Button)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "QuestionPage_English"
        Me.Text = "QuestionPage_English"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents submit_Button As System.Windows.Forms.Button
    Friend WithEvents Clear_Button As System.Windows.Forms.Button
    Friend WithEvents save_Button As System.Windows.Forms.Button
    Friend WithEvents next_Button As System.Windows.Forms.Button
    Friend WithEvents Pre_Button As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Ques_label As System.Windows.Forms.Label
    Friend WithEvents QNo_label As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ca_label As System.Windows.Forms.Label
    Friend WithEvents OP4_RB As System.Windows.Forms.RadioButton
    Friend WithEvents OP1_RB As System.Windows.Forms.RadioButton
    Friend WithEvents OP3_RB As System.Windows.Forms.RadioButton
    Friend WithEvents OP2_RB As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents min As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents sec As System.Windows.Forms.Label
End Class
