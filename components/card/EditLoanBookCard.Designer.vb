<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditLoanBookCard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.title = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.BackColor = System.Drawing.Color.Transparent
        Me.title.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.title.Location = New System.Drawing.Point(12, 5)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(166, 30)
        Me.title.TabIndex = 0
        Me.title.Text = "Sherlock Holmes (10)"
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BorderColor = System.Drawing.Color.LightGray
        Me.Guna2Panel5.BorderRadius = 3
        Me.Guna2Panel5.BorderThickness = 1
        Me.Guna2Panel5.Controls.Add(Me.title)
        Me.Guna2Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        Me.Guna2Panel5.Size = New System.Drawing.Size(371, 39)
        Me.Guna2Panel5.TabIndex = 1
        '
        'EditLoanBookCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Name = "EditLoanBookCard"
        Me.Size = New System.Drawing.Size(371, 46)
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents title As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
End Class
