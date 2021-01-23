<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookCard
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
        Me.label_qnt = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.label_author = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.label_title = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.label_id = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btn_delete = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_update = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_detail = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.SuspendLayout()
        '
        'label_qnt
        '
        Me.label_qnt.BackColor = System.Drawing.Color.Transparent
        Me.label_qnt.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_qnt.ForeColor = System.Drawing.Color.Black
        Me.label_qnt.Location = New System.Drawing.Point(490, 17)
        Me.label_qnt.Name = "label_qnt"
        Me.label_qnt.Size = New System.Drawing.Size(18, 30)
        Me.label_qnt.TabIndex = 10
        Me.label_qnt.Text = "10"
        '
        'label_author
        '
        Me.label_author.BackColor = System.Drawing.Color.Transparent
        Me.label_author.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_author.ForeColor = System.Drawing.Color.Black
        Me.label_author.Location = New System.Drawing.Point(340, 17)
        Me.label_author.Name = "label_author"
        Me.label_author.Size = New System.Drawing.Size(108, 30)
        Me.label_author.TabIndex = 9
        Me.label_author.Text = "Arthur Conan"
        '
        'label_title
        '
        Me.label_title.BackColor = System.Drawing.Color.Transparent
        Me.label_title.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_title.ForeColor = System.Drawing.Color.Black
        Me.label_title.Location = New System.Drawing.Point(79, 17)
        Me.label_title.Name = "label_title"
        Me.label_title.Size = New System.Drawing.Size(133, 30)
        Me.label_title.TabIndex = 8
        Me.label_title.Text = "Sherlock Holmes"
        '
        'label_id
        '
        Me.label_id.BackColor = System.Drawing.Color.Transparent
        Me.label_id.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_id.ForeColor = System.Drawing.Color.Black
        Me.label_id.Location = New System.Drawing.Point(9, 17)
        Me.label_id.Name = "label_id"
        Me.label_id.Size = New System.Drawing.Size(21, 30)
        Me.label_id.TabIndex = 7
        Me.label_id.Text = "#1"
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
        Me.btn_delete.TabIndex = 11
        Me.btn_delete.Text = "Delete"
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.Transparent
        Me.btn_update.BorderRadius = 3
        Me.btn_update.CheckedState.Parent = Me.btn_update
        Me.btn_update.CustomImages.Parent = Me.btn_update
        Me.btn_update.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btn_update.Font = New System.Drawing.Font("Poppins Light", 12.0!)
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.HoverState.Parent = Me.btn_update
        Me.btn_update.Location = New System.Drawing.Point(705, 10)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.ShadowDecoration.Parent = Me.btn_update
        Me.btn_update.Size = New System.Drawing.Size(109, 41)
        Me.btn_update.TabIndex = 12
        Me.btn_update.Text = "Update"
        '
        'btn_detail
        '
        Me.btn_detail.BackColor = System.Drawing.Color.Transparent
        Me.btn_detail.BorderRadius = 3
        Me.btn_detail.CheckedState.Parent = Me.btn_detail
        Me.btn_detail.CustomImages.Parent = Me.btn_detail
        Me.btn_detail.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btn_detail.Font = New System.Drawing.Font("Poppins Light", 12.0!)
        Me.btn_detail.ForeColor = System.Drawing.Color.White
        Me.btn_detail.HoverState.Parent = Me.btn_detail
        Me.btn_detail.Location = New System.Drawing.Point(590, 10)
        Me.btn_detail.Name = "btn_detail"
        Me.btn_detail.ShadowDecoration.Parent = Me.btn_detail
        Me.btn_detail.Size = New System.Drawing.Size(109, 41)
        Me.btn_detail.TabIndex = 13
        Me.btn_detail.Text = "Detail"
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
        Me.Guna2Panel5.TabIndex = 14
        '
        'BookCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Controls.Add(Me.btn_detail)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.label_qnt)
        Me.Controls.Add(Me.label_author)
        Me.Controls.Add(Me.label_title)
        Me.Controls.Add(Me.label_id)
        Me.Name = "BookCard"
        Me.Size = New System.Drawing.Size(949, 60)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label_qnt As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents label_author As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents label_title As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents label_id As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btn_delete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_update As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_detail As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
End Class
