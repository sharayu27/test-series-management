<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminid
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.admintextbox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(308, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please enter your admin id"
        '
        'admintextbox
        '
        Me.admintextbox.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admintextbox.Location = New System.Drawing.Point(172, 212)
        Me.admintextbox.Multiline = True
        Me.admintextbox.Name = "admintextbox"
        Me.admintextbox.Size = New System.Drawing.Size(500, 30)
        Me.admintextbox.TabIndex = 1
        Me.admintextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(341, 297)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 42)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Enter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'adminid
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(835, 510)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.admintextbox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "adminid"
        Me.Text = "adminid"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents admintextbox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
