<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LeftLoanBookCard
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btn_add = New Guna.UI2.WinForms.Guna2Button()
        Me.box_title = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel5)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(371, 40)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BorderColor = System.Drawing.Color.LightGray
        Me.Guna2Panel5.BorderRadius = 3
        Me.Guna2Panel5.BorderThickness = 1
        Me.Guna2Panel5.Controls.Add(Me.btn_add)
        Me.Guna2Panel5.Controls.Add(Me.box_title)
        Me.Guna2Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        Me.Guna2Panel5.Size = New System.Drawing.Size(371, 40)
        Me.Guna2Panel5.TabIndex = 2
        '
        'btn_add
        '
        Me.btn_add.BorderRadius = 3
        Me.btn_add.CheckedState.Parent = Me.btn_add
        Me.btn_add.CustomImages.Parent = Me.btn_add
        Me.btn_add.Font = New System.Drawing.Font("Poppins Light", 10.0!)
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.HoverState.Parent = Me.btn_add
        Me.btn_add.Location = New System.Drawing.Point(299, 5)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.ShadowDecoration.Parent = Me.btn_add
        Me.btn_add.Size = New System.Drawing.Size(66, 30)
        Me.btn_add.TabIndex = 1
        Me.btn_add.Text = "Add"
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
        'LeftLoanBookCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 3, 3, 12)
        Me.Name = "LeftLoanBookCard"
        Me.Size = New System.Drawing.Size(371, 48)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btn_add As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents box_title As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
