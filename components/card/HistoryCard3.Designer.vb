﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoryCard3
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
        Me.subtitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.title = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.date_label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'subtitle
        '
        Me.subtitle.BackColor = System.Drawing.Color.Transparent
        Me.subtitle.Font = New System.Drawing.Font("Roboto Medium", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.subtitle.Location = New System.Drawing.Point(11, 43)
        Me.subtitle.Name = "subtitle"
        Me.subtitle.Size = New System.Drawing.Size(274, 19)
        Me.subtitle.TabIndex = 1
        Me.subtitle.Text = "David has been added as admin by Master."
        '
        'title
        '
        Me.title.BackColor = System.Drawing.Color.Transparent
        Me.title.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(11, 13)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(174, 25)
        Me.title.TabIndex = 0
        Me.title.Text = "David join as Admin"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.subtitle)
        Me.Guna2Panel2.Controls.Add(Me.title)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel2.Location = New System.Drawing.Point(75, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(387, 75)
        Me.Guna2Panel2.TabIndex = 7
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Controls.Add(Me.date_label)
        Me.Guna2Panel3.Controls.Add(Me.Guna2Panel4)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel3.Location = New System.Drawing.Point(462, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(151, 75)
        Me.Guna2Panel3.TabIndex = 8
        '
        'date_label
        '
        Me.date_label.BackColor = System.Drawing.Color.Transparent
        Me.date_label.Font = New System.Drawing.Font("Roboto Medium", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.date_label.Location = New System.Drawing.Point(53, 30)
        Me.date_label.Name = "date_label"
        Me.date_label.Size = New System.Drawing.Size(66, 15)
        Me.date_label.TabIndex = 2
        Me.date_label.Text = "05 Juni 2021"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackgroundImage = Global.Elebrary.My.Resources.Resources.history_date_icon
        Me.Guna2Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel4.Location = New System.Drawing.Point(13, 24)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(25, 25)
        Me.Guna2Panel4.TabIndex = 0
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel5)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Padding = New System.Windows.Forms.Padding(10)
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(75, 75)
        Me.Guna2Panel1.TabIndex = 6
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BackgroundImage = Global.Elebrary.My.Resources.Resources.history_icon_3
        Me.Guna2Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel5.Location = New System.Drawing.Point(13, 12)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        Me.Guna2Panel5.Size = New System.Drawing.Size(49, 49)
        Me.Guna2Panel5.TabIndex = 0
        '
        'HistoryCard3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "HistoryCard3"
        Me.Size = New System.Drawing.Size(613, 75)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents subtitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents title As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents date_label As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
End Class
