﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAdminModal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddAdminModal))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btn_cancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_save = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.password_label = New Guna.UI2.WinForms.Guna2TextBox()
        Me.username_label = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.fullname_label = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.Controls.Add(Me.btn_cancel)
        Me.Guna2Panel2.Controls.Add(Me.btn_save)
        Me.Guna2Panel2.CustomBorderThickness = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Guna2Panel2.CustomizableEdges.BottomLeft = False
        Me.Guna2Panel2.CustomizableEdges.BottomRight = False
        Me.Guna2Panel2.CustomizableEdges.TopLeft = False
        Me.Guna2Panel2.CustomizableEdges.TopRight = False
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 278)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.CustomizableEdges.TopLeft = False
        Me.Guna2Panel2.ShadowDecoration.CustomizableEdges.TopRight = False
        Me.Guna2Panel2.ShadowDecoration.Depth = 20
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(750, 54)
        Me.Guna2Panel2.TabIndex = 9
        '
        'btn_cancel
        '
        Me.btn_cancel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btn_cancel.BorderRadius = 3
        Me.btn_cancel.BorderThickness = 1
        Me.btn_cancel.CheckedState.Parent = Me.btn_cancel
        Me.btn_cancel.CustomImages.Parent = Me.btn_cancel
        Me.btn_cancel.FillColor = System.Drawing.Color.Transparent
        Me.btn_cancel.Font = New System.Drawing.Font("Poppins Light", 10.0!)
        Me.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btn_cancel.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_cancel.HoverState.Parent = Me.btn_cancel
        Me.btn_cancel.Location = New System.Drawing.Point(557, 12)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.PressedColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.btn_cancel.ShadowDecoration.Parent = Me.btn_cancel
        Me.btn_cancel.Size = New System.Drawing.Size(94, 30)
        Me.btn_cancel.TabIndex = 1
        Me.btn_cancel.Text = "Cancel"
        '
        'btn_save
        '
        Me.btn_save.BorderRadius = 3
        Me.btn_save.CheckedState.Parent = Me.btn_save
        Me.btn_save.CustomImages.Parent = Me.btn_save
        Me.btn_save.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btn_save.Font = New System.Drawing.Font("Poppins Light", 10.0!)
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.HoverState.Parent = Me.btn_save
        Me.btn_save.Location = New System.Drawing.Point(657, 12)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.ShadowDecoration.Parent = Me.btn_save
        Me.btn_save.Size = New System.Drawing.Size(81, 30)
        Me.btn_save.TabIndex = 0
        Me.btn_save.Text = "Save"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.Guna2ImageButton1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Guna2Panel1.CustomizableEdges.BottomLeft = False
        Me.Guna2Panel1.CustomizableEdges.BottomRight = False
        Me.Guna2Panel1.CustomizableEdges.TopLeft = False
        Me.Guna2Panel1.CustomizableEdges.TopRight = False
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.CustomizableEdges.TopLeft = False
        Me.Guna2Panel1.ShadowDecoration.CustomizableEdges.TopRight = False
        Me.Guna2Panel1.ShadowDecoration.Depth = 20
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(750, 54)
        Me.Guna2Panel1.TabIndex = 8
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2ImageButton1.CheckedState.Image = Global.Elebrary.My.Resources.Resources.close_icon_transparent
        Me.Guna2ImageButton1.CheckedState.ImageSize = New System.Drawing.Size(19, 19)
        Me.Guna2ImageButton1.CheckedState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.HoverState.Image = Global.Elebrary.My.Resources.Resources.close_icon_transparent
        Me.Guna2ImageButton1.HoverState.ImageSize = New System.Drawing.Size(19, 19)
        Me.Guna2ImageButton1.HoverState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Image = Global.Elebrary.My.Resources.Resources.close_icon
        Me.Guna2ImageButton1.ImageRotate = 0!
        Me.Guna2ImageButton1.ImageSize = New System.Drawing.Size(19, 19)
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(708, 11)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.PressedState.Image = Global.Elebrary.My.Resources.Resources.close_icon_transparent
        Me.Guna2ImageButton1.PressedState.ImageSize = New System.Drawing.Size(19, 19)
        Me.Guna2ImageButton1.PressedState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(32, 32)
        Me.Guna2ImageButton1.TabIndex = 6
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Poppins Medium", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(20, 10)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(117, 38)
        Me.Guna2HtmlLabel1.TabIndex = 3
        Me.Guna2HtmlLabel1.Text = "Add Admin"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'password_label
        '
        Me.password_label.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.password_label.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password_label.DefaultText = ""
        Me.password_label.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.password_label.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.password_label.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password_label.DisabledState.Parent = Me.password_label
        Me.password_label.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password_label.FillColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.password_label.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password_label.FocusedState.Parent = Me.password_label
        Me.password_label.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.password_label.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password_label.HoverState.Parent = Me.password_label
        Me.password_label.Location = New System.Drawing.Point(298, 213)
        Me.password_label.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.password_label.Name = "password_label"
        Me.password_label.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.password_label.PlaceholderText = ""
        Me.password_label.SelectedText = ""
        Me.password_label.ShadowDecoration.Parent = Me.password_label
        Me.password_label.Size = New System.Drawing.Size(253, 32)
        Me.password_label.TabIndex = 27
        Me.password_label.UseSystemPasswordChar = True
        '
        'username_label
        '
        Me.username_label.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.username_label.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.username_label.DefaultText = ""
        Me.username_label.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.username_label.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.username_label.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.username_label.DisabledState.Parent = Me.username_label
        Me.username_label.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.username_label.FillColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.username_label.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.username_label.FocusedState.Parent = Me.username_label
        Me.username_label.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.username_label.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.username_label.HoverState.Parent = Me.username_label
        Me.username_label.Location = New System.Drawing.Point(298, 150)
        Me.username_label.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.username_label.Name = "username_label"
        Me.username_label.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.username_label.PlaceholderText = ""
        Me.username_label.SelectedText = ""
        Me.username_label.ShadowDecoration.Parent = Me.username_label
        Me.username_label.Size = New System.Drawing.Size(253, 32)
        Me.username_label.TabIndex = 26
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(195, 213)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(82, 30)
        Me.Guna2HtmlLabel4.TabIndex = 25
        Me.Guna2HtmlLabel4.Text = "Password"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(190, 152)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(87, 30)
        Me.Guna2HtmlLabel3.TabIndex = 24
        Me.Guna2HtmlLabel3.Text = "Username"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(200, 87)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(77, 30)
        Me.Guna2HtmlLabel2.TabIndex = 22
        Me.Guna2HtmlLabel2.Text = "Fullname"
        '
        'fullname_label
        '
        Me.fullname_label.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.fullname_label.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fullname_label.DefaultText = ""
        Me.fullname_label.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.fullname_label.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.fullname_label.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fullname_label.DisabledState.Parent = Me.fullname_label
        Me.fullname_label.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fullname_label.FillColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.fullname_label.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fullname_label.FocusedState.Parent = Me.fullname_label
        Me.fullname_label.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.fullname_label.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fullname_label.HoverState.Parent = Me.fullname_label
        Me.fullname_label.Location = New System.Drawing.Point(298, 87)
        Me.fullname_label.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.fullname_label.Name = "fullname_label"
        Me.fullname_label.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fullname_label.PlaceholderText = ""
        Me.fullname_label.SelectedText = ""
        Me.fullname_label.ShadowDecoration.Parent = Me.fullname_label
        Me.fullname_label.Size = New System.Drawing.Size(253, 32)
        Me.fullname_label.TabIndex = 23
        '
        'AddAdminModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(750, 332)
        Me.Controls.Add(Me.password_label)
        Me.Controls.Add(Me.username_label)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.fullname_label)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddAdminModal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AddAdminModal"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btn_cancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents password_label As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents username_label As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents fullname_label As Guna.UI2.WinForms.Guna2TextBox
End Class
