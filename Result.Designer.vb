<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Result
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Result))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Result_Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(364, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(289, 73)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Out of 50"
        '
        'Result_Label
        '
        Me.Result_Label.AutoSize = True
        Me.Result_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Result_Label.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Result_Label.ForeColor = System.Drawing.Color.LawnGreen
        Me.Result_Label.Location = New System.Drawing.Point(118, 178)
        Me.Result_Label.Name = "Result_Label"
        Me.Result_Label.Size = New System.Drawing.Size(223, 75)
        Me.Result_Label.TabIndex = 8
        Me.Result_Label.Text = "Label3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(250, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 73)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Your Score"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(366, 447)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 37)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = ">>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(24, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(122, 120)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(398, 318)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 32)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Quantitative analysis"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(563, 318)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(119, 32)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Computer Knowledge"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(398, 373)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(119, 32)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Verbal Ability"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(563, 373)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(119, 32)
        Me.Button6.TabIndex = 20
        Me.Button6.Text = "Logical Ability"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 316)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 29)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Check Answers for:"
        '
        'Result
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(835, 510)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Result_Label)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Result"
        Me.Text = "Result"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Result_Label As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
