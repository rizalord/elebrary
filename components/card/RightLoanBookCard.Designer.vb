<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RightLoanBookCard
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
        Me.btn_delete = New Guna.UI2.WinForms.Guna2Button()
        Me.box_title = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel9 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_delete
        '
        Me.btn_delete.BorderRadius = 3
        Me.btn_delete.CheckedState.Parent = Me.btn_delete
        Me.btn_delete.CustomImages.Parent = Me.btn_delete
        Me.btn_delete.FillColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btn_delete.Font = New System.Drawing.Font("Poppins Light", 10.0!)
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.HoverState.Parent = Me.btn_delete
        Me.btn_delete.Location = New System.Drawing.Point(283, 5)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.ShadowDecoration.Parent = Me.btn_delete
        Me.btn_delete.Size = New System.Drawing.Size(82, 30)
        Me.btn_delete.TabIndex = 1
        Me.btn_delete.Text = "Delete"
        '
        'box_title
        '
        Me.box_title.BackColor = System.Drawing.Color.Transparent
        Me.box_title.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.box_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.box_title.Location = New System.Drawing.Point(12, 5)
        Me.box_title.Name = "box_title"
        Me.box_title.Size = New System.Drawing.Size(166, 30)
        Me.box_title.TabIndex = 0
        Me.box_title.Text = "Sherlock Holmes (10)"
        '
        'Guna2Panel9
        '
        Me.Guna2Panel9.BorderColor = System.Drawing.Color.LightGray
        Me.Guna2Panel9.BorderRadius = 3
        Me.Guna2Panel9.BorderThickness = 1
        Me.Guna2Panel9.Controls.Add(Me.btn_delete)
        Me.Guna2Panel9.Controls.Add(Me.box_title)
        Me.Guna2Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel9.Name = "Guna2Panel9"
        Me.Guna2Panel9.ShadowDecoration.Parent = Me.Guna2Panel9
        Me.Guna2Panel9.Size = New System.Drawing.Size(371, 39)
        Me.Guna2Panel9.TabIndex = 4
        '
        'RightLoanBookCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Guna2Panel9)
        Me.Name = "RightLoanBookCard"
        Me.Size = New System.Drawing.Size(371, 48)
        Me.Guna2Panel9.ResumeLayout(False)
        Me.Guna2Panel9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_delete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents box_title As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel9 As Guna.UI2.WinForms.Guna2Panel
End Class
