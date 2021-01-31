<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginModal
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
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.btn_login = New Guna.UI2.WinForms.Guna2Button()
        Me.password_box = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.username_box = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.captcha_text = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.captcha_box = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.Transparent
        Me.btn_login.BorderRadius = 5
        Me.btn_login.CheckedState.Parent = Me.btn_login
        Me.btn_login.CustomImages.Parent = Me.btn_login
        Me.btn_login.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btn_login.Font = New System.Drawing.Font("Poppins", 10.5!)
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.HoverState.Parent = Me.btn_login
        Me.btn_login.Location = New System.Drawing.Point(19, 471)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.ShadowDecoration.BorderRadius = 1
        Me.btn_login.ShadowDecoration.Depth = 4
        Me.btn_login.ShadowDecoration.Enabled = True
        Me.btn_login.ShadowDecoration.Parent = Me.btn_login
        Me.btn_login.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.btn_login.Size = New System.Drawing.Size(338, 42)
        Me.btn_login.TabIndex = 22
        Me.btn_login.Text = "Login"
        '
        'password_box
        '
        Me.password_box.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.password_box.BorderRadius = 4
        Me.password_box.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password_box.DefaultText = ""
        Me.password_box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.password_box.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.password_box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password_box.DisabledState.Parent = Me.password_box
        Me.password_box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password_box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password_box.FocusedState.Parent = Me.password_box
        Me.password_box.Font = New System.Drawing.Font("Roboto", 10.5!)
        Me.password_box.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password_box.HoverState.Parent = Me.password_box
        Me.password_box.Location = New System.Drawing.Point(19, 228)
        Me.password_box.Name = "password_box"
        Me.password_box.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.password_box.PlaceholderText = ""
        Me.password_box.SelectedText = ""
        Me.password_box.ShadowDecoration.Parent = Me.password_box
        Me.password_box.Size = New System.Drawing.Size(338, 34)
        Me.password_box.TabIndex = 17
        Me.password_box.UseSystemPasswordChar = True
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(19, 198)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(73, 21)
        Me.Guna2HtmlLabel3.TabIndex = 16
        Me.Guna2HtmlLabel3.Text = "Password"
        '
        'username_box
        '
        Me.username_box.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.username_box.BorderRadius = 4
        Me.username_box.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.username_box.DefaultText = ""
        Me.username_box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.username_box.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.username_box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.username_box.DisabledState.Parent = Me.username_box
        Me.username_box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.username_box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.username_box.FocusedState.Parent = Me.username_box
        Me.username_box.Font = New System.Drawing.Font("Roboto", 10.5!)
        Me.username_box.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.username_box.HoverState.Parent = Me.username_box
        Me.username_box.Location = New System.Drawing.Point(19, 145)
        Me.username_box.Name = "username_box"
        Me.username_box.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.username_box.PlaceholderText = ""
        Me.username_box.SelectedText = ""
        Me.username_box.ShadowDecoration.Parent = Me.username_box
        Me.username_box.Size = New System.Drawing.Size(338, 34)
        Me.username_box.TabIndex = 15
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(19, 115)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(74, 21)
        Me.Guna2HtmlLabel2.TabIndex = 14
        Me.Guna2HtmlLabel2.Text = "Username"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Poppins", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(154, 32)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(65, 42)
        Me.Guna2HtmlLabel1.TabIndex = 13
        Me.Guna2HtmlLabel1.Text = "Login"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(377, 5)
        Me.Guna2Panel1.TabIndex = 25
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.captcha_text)
        Me.Guna2Panel2.Location = New System.Drawing.Point(19, 296)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(338, 74)
        Me.Guna2Panel2.TabIndex = 26
        '
        'captcha_text
        '
        Me.captcha_text.BackColor = System.Drawing.Color.Transparent
        Me.captcha_text.Font = New System.Drawing.Font("Pirata One", 32.0!)
        Me.captcha_text.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.captcha_text.Location = New System.Drawing.Point(114, 11)
        Me.captcha_text.Name = "captcha_text"
        Me.captcha_text.Size = New System.Drawing.Size(113, 57)
        Me.captcha_text.TabIndex = 0
        Me.captcha_text.Text = "SN6UWi"
        '
        'captcha_box
        '
        Me.captcha_box.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.captcha_box.BorderRadius = 4
        Me.captcha_box.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.captcha_box.DefaultText = ""
        Me.captcha_box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.captcha_box.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.captcha_box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.captcha_box.DisabledState.Parent = Me.captcha_box
        Me.captcha_box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.captcha_box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.captcha_box.FocusedState.Parent = Me.captcha_box
        Me.captcha_box.Font = New System.Drawing.Font("Roboto", 10.5!)
        Me.captcha_box.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.captcha_box.HoverState.Parent = Me.captcha_box
        Me.captcha_box.Location = New System.Drawing.Point(19, 404)
        Me.captcha_box.Name = "captcha_box"
        Me.captcha_box.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.captcha_box.PlaceholderText = ""
        Me.captcha_box.SelectedText = ""
        Me.captcha_box.ShadowDecoration.Parent = Me.captcha_box
        Me.captcha_box.Size = New System.Drawing.Size(338, 35)
        Me.captcha_box.TabIndex = 28
        Me.captcha_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(19, 380)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(80, 16)
        Me.Guna2HtmlLabel4.TabIndex = 27
        Me.Guna2HtmlLabel4.Text = "Input Captcha"
        '
        'LoginModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(377, 545)
        Me.Controls.Add(Me.captcha_box)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.password_box)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.username_box)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginModal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents btn_login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents password_box As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents username_box As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents captcha_box As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents captcha_text As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
