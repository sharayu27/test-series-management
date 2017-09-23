<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pay_res
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
        Me.success = New System.Windows.Forms.Label()
        Me.fail = New System.Windows.Forms.Label()
        Me.failback = New System.Windows.Forms.Button()
        Me.adminidbut = New System.Windows.Forms.Button()
        Me.ad = New System.Windows.Forms.Label()
        Me.val = New System.Windows.Forms.Label()
        Me.successpro = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'success
        '
        Me.success.AutoSize = True
        Me.success.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.success.ForeColor = System.Drawing.Color.ForestGreen
        Me.success.Location = New System.Drawing.Point(349, 212)
        Me.success.Name = "success"
        Me.success.Size = New System.Drawing.Size(233, 36)
        Me.success.TabIndex = 0
        Me.success.Text = "Successfully paid"
        Me.success.Visible = False
        '
        'fail
        '
        Me.fail.AutoSize = True
        Me.fail.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fail.ForeColor = System.Drawing.Color.DarkRed
        Me.fail.Location = New System.Drawing.Point(279, 142)
        Me.fail.Name = "fail"
        Me.fail.Size = New System.Drawing.Size(181, 36)
        Me.fail.TabIndex = 1
        Me.fail.Text = "Failed to pay"
        Me.fail.Visible = False
        '
        'failback
        '
        Me.failback.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.failback.Location = New System.Drawing.Point(525, 134)
        Me.failback.Name = "failback"
        Me.failback.Size = New System.Drawing.Size(147, 57)
        Me.failback.TabIndex = 3
        Me.failback.Text = "Back"
        Me.failback.UseVisualStyleBackColor = True
        Me.failback.Visible = False
        '
        'adminidbut
        '
        Me.adminidbut.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminidbut.Location = New System.Drawing.Point(182, 281)
        Me.adminidbut.Name = "adminidbut"
        Me.adminidbut.Size = New System.Drawing.Size(192, 57)
        Me.adminidbut.TabIndex = 4
        Me.adminidbut.Text = "Get your Admin id"
        Me.adminidbut.UseVisualStyleBackColor = True
        Me.adminidbut.Visible = False
        '
        'ad
        '
        Me.ad.AutoSize = True
        Me.ad.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ad.Location = New System.Drawing.Point(281, 398)
        Me.ad.Name = "ad"
        Me.ad.Size = New System.Drawing.Size(148, 23)
        Me.ad.TabIndex = 5
        Me.ad.Text = "Your admin id is"
        Me.ad.Visible = False
        '
        'val
        '
        Me.val.AutoSize = True
        Me.val.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.val.Location = New System.Drawing.Point(483, 398)
        Me.val.Name = "val"
        Me.val.Size = New System.Drawing.Size(67, 23)
        Me.val.TabIndex = 6
        Me.val.Text = "Label1"
        Me.val.Visible = False
        '
        'successpro
        '
        Me.successpro.Enabled = False
        Me.successpro.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.successpro.Location = New System.Drawing.Point(548, 281)
        Me.successpro.Name = "successpro"
        Me.successpro.Size = New System.Drawing.Size(147, 57)
        Me.successpro.TabIndex = 2
        Me.successpro.Text = "Proceed"
        Me.successpro.UseVisualStyleBackColor = True
        Me.successpro.Visible = False
        '
        'pay_res
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(848, 510)
        Me.Controls.Add(Me.val)
        Me.Controls.Add(Me.ad)
        Me.Controls.Add(Me.adminidbut)
        Me.Controls.Add(Me.failback)
        Me.Controls.Add(Me.successpro)
        Me.Controls.Add(Me.fail)
        Me.Controls.Add(Me.success)
        Me.Name = "pay_res"
        Me.Text = "pay_res"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents success As System.Windows.Forms.Label
    Friend WithEvents fail As System.Windows.Forms.Label
    Friend WithEvents failback As System.Windows.Forms.Button
    Friend WithEvents adminidbut As System.Windows.Forms.Button
    Friend WithEvents ad As System.Windows.Forms.Label
    Friend WithEvents val As System.Windows.Forms.Label
    Friend WithEvents successpro As System.Windows.Forms.Button
End Class
