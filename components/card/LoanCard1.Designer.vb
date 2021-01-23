<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoanCard1
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
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btn_edit = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_delete = New Guna.UI2.WinForms.Guna2Button()
        Me.label_qnt = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.label_author = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.label_title = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.label_id = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Guna2Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel5.FillColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Guna2Panel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Guna2Panel5.Location = New System.Drawing.Point(0, 59)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        Me.Guna2Panel5.Size = New System.Drawing.Size(949, 1)
        Me.Guna2Panel5.TabIndex = 22
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.Transparent
        Me.btn_edit.BorderRadius = 3
        Me.btn_edit.CheckedState.Parent = Me.btn_edit
        Me.btn_edit.CustomImages.Parent = Me.btn_edit
        Me.btn_edit.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btn_edit.Font = New System.Drawing.Font("Poppins Light", 12.0!)
        Me.btn_edit.ForeColor = System.Drawing.Color.White
        Me.btn_edit.HoverState.Parent = Me.btn_edit
        Me.btn_edit.Location = New System.Drawing.Point(705, 10)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.ShadowDecoration.Parent = Me.btn_edit
        Me.btn_edit.Size = New System.Drawing.Size(109, 41)
        Me.btn_edit.TabIndex = 20
        Me.btn_edit.Text = "Update"
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Transparent
        Me.btn_delete.BorderRadius = 3
        Me.btn_delete.CheckedState.Parent = Me.btn_delete
        Me.btn_delete.CustomImages.Parent = Me.btn_delete
        Me.btn_delete.FillColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btn_delete.Font = New System.Drawing.Font("Poppins Light", 12.0!)
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.HoverState.Parent = Me.btn_delete
        Me.btn_delete.Location = New System.Drawing.Point(820, 10)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.ShadowDecoration.Parent = Me.btn_delete
        Me.btn_delete.Size = New System.Drawing.Size(109, 41)
        Me.btn_delete.TabIndex = 19
        Me.btn_delete.Text = "Delete"
        '
        'label_qnt
        '
        Me.label_qnt.BackColor = System.Drawing.Color.Transparent
        Me.label_qnt.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_qnt.ForeColor = System.Drawing.Color.Black
        Me.label_qnt.Location = New System.Drawing.Point(428, 17)
        Me.label_qnt.Name = "label_qnt"
        Me.label_qnt.Size = New System.Drawing.Size(83, 30)
        Me.label_qnt.TabIndex = 18
        Me.label_qnt.Text = "11 Jan 2021"
        '
        'label_author
        '
        Me.label_author.BackColor = System.Drawing.Color.Transparent
        Me.label_author.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_author.ForeColor = System.Drawing.Color.Black
        Me.label_author.Location = New System.Drawing.Point(287, 17)
        Me.label_author.Name = "label_author"
        Me.label_author.Size = New System.Drawing.Size(65, 30)
        Me.label_author.TabIndex = 17
        Me.label_author.Text = "XII RPL C"
        '
        'label_title
        '
        Me.label_title.BackColor = System.Drawing.Color.Transparent
        Me.label_title.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_title.ForeColor = System.Drawing.Color.Black
        Me.label_title.Location = New System.Drawing.Point(69, 17)
        Me.label_title.Name = "label_title"
        Me.label_title.Size = New System.Drawing.Size(147, 30)
        Me.label_title.TabIndex = 16
        Me.label_title.Text = "Ahmad Khamdani"
        '
        'label_id
        '
        Me.label_id.BackColor = System.Drawing.Color.Transparent
        Me.label_id.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_id.ForeColor = System.Drawing.Color.Black
        Me.label_id.Location = New System.Drawing.Point(9, 17)
        Me.label_id.Name = "label_id"
        Me.label_id.Size = New System.Drawing.Size(21, 30)
        Me.label_id.TabIndex = 15
        Me.label_id.Text = "#1"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 20
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.Silver
        Me.Guna2Panel1.Location = New System.Drawing.Point(554, 12)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(109, 37)
        Me.Guna2Panel1.TabIndex = 24
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Poppins Light", 11.0!)
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(21, 5)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(66, 28)
        Me.Guna2HtmlLabel1.TabIndex = 3
        Me.Guna2HtmlLabel1.Text = "Ongoing"
        '
        'LoanCard1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.label_qnt)
        Me.Controls.Add(Me.label_author)
        Me.Controls.Add(Me.label_title)
        Me.Controls.Add(Me.label_id)
        Me.Name = "LoanCard1"
        Me.Size = New System.Drawing.Size(949, 60)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btn_edit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_delete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents label_qnt As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents label_author As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents label_title As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents label_id As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
