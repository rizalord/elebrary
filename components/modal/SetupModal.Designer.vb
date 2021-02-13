<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SetupModal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetupModal))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.username_box = New Guna.UI2.WinForms.Guna2TextBox()
        Me.password_box = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.password_confirmation_box = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.target_projects = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btn_submit = New Guna.UI2.WinForms.Guna2Button()
        Me.currencies = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(377, 5)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Poppins", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(153, 38)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(69, 42)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "Setup"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(18, 121)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(74, 21)
        Me.Guna2HtmlLabel2.TabIndex = 2
        Me.Guna2HtmlLabel2.Text = "Username"
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
        Me.username_box.Location = New System.Drawing.Point(18, 151)
        Me.username_box.Name = "username_box"
        Me.username_box.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.username_box.PlaceholderText = ""
        Me.username_box.SelectedText = ""
        Me.username_box.ShadowDecoration.Parent = Me.username_box
        Me.username_box.Size = New System.Drawing.Size(338, 34)
        Me.username_box.TabIndex = 3
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
        Me.password_box.Location = New System.Drawing.Point(18, 234)
        Me.password_box.Name = "password_box"
        Me.password_box.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.password_box.PlaceholderText = ""
        Me.password_box.SelectedText = ""
        Me.password_box.ShadowDecoration.Parent = Me.password_box
        Me.password_box.Size = New System.Drawing.Size(338, 34)
        Me.password_box.TabIndex = 5
        Me.password_box.UseSystemPasswordChar = True
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(18, 204)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(73, 21)
        Me.Guna2HtmlLabel3.TabIndex = 4
        Me.Guna2HtmlLabel3.Text = "Password"
        '
        'password_confirmation_box
        '
        Me.password_confirmation_box.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.password_confirmation_box.BorderRadius = 4
        Me.password_confirmation_box.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password_confirmation_box.DefaultText = ""
        Me.password_confirmation_box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.password_confirmation_box.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.password_confirmation_box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password_confirmation_box.DisabledState.Parent = Me.password_confirmation_box
        Me.password_confirmation_box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password_confirmation_box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password_confirmation_box.FocusedState.Parent = Me.password_confirmation_box
        Me.password_confirmation_box.Font = New System.Drawing.Font("Roboto", 10.5!)
        Me.password_confirmation_box.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password_confirmation_box.HoverState.Parent = Me.password_confirmation_box
        Me.password_confirmation_box.Location = New System.Drawing.Point(18, 322)
        Me.password_confirmation_box.Name = "password_confirmation_box"
        Me.password_confirmation_box.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.password_confirmation_box.PlaceholderText = ""
        Me.password_confirmation_box.SelectedText = ""
        Me.password_confirmation_box.ShadowDecoration.Parent = Me.password_confirmation_box
        Me.password_confirmation_box.Size = New System.Drawing.Size(338, 34)
        Me.password_confirmation_box.TabIndex = 7
        Me.password_confirmation_box.UseSystemPasswordChar = True
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(18, 292)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(170, 21)
        Me.Guna2HtmlLabel4.TabIndex = 6
        Me.Guna2HtmlLabel4.Text = "Confirmation Password"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(18, 379)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(102, 21)
        Me.Guna2HtmlLabel5.TabIndex = 8
        Me.Guna2HtmlLabel5.Text = "Target Project"
        '
        'target_projects
        '
        Me.target_projects.BackColor = System.Drawing.Color.Transparent
        Me.target_projects.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.target_projects.BorderRadius = 4
        Me.target_projects.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.target_projects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.target_projects.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.target_projects.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.target_projects.FocusedState.Parent = Me.target_projects
        Me.target_projects.Font = New System.Drawing.Font("Roboto", 10.5!)
        Me.target_projects.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.target_projects.HoverState.Parent = Me.target_projects
        Me.target_projects.ItemHeight = 30
        Me.target_projects.Items.AddRange(New Object() {"General", "School"})
        Me.target_projects.ItemsAppearance.Parent = Me.target_projects
        Me.target_projects.Location = New System.Drawing.Point(18, 407)
        Me.target_projects.Name = "target_projects"
        Me.target_projects.ShadowDecoration.Parent = Me.target_projects
        Me.target_projects.Size = New System.Drawing.Size(157, 36)
        Me.target_projects.StartIndex = 0
        Me.target_projects.TabIndex = 9
        '
        'btn_submit
        '
        Me.btn_submit.BackColor = System.Drawing.Color.Transparent
        Me.btn_submit.BorderRadius = 5
        Me.btn_submit.CheckedState.Parent = Me.btn_submit
        Me.btn_submit.CustomImages.Parent = Me.btn_submit
        Me.btn_submit.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btn_submit.Font = New System.Drawing.Font("Poppins", 10.5!)
        Me.btn_submit.ForeColor = System.Drawing.Color.White
        Me.btn_submit.HoverState.Parent = Me.btn_submit
        Me.btn_submit.Location = New System.Drawing.Point(18, 477)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.ShadowDecoration.BorderRadius = 1
        Me.btn_submit.ShadowDecoration.Depth = 4
        Me.btn_submit.ShadowDecoration.Enabled = True
        Me.btn_submit.ShadowDecoration.Parent = Me.btn_submit
        Me.btn_submit.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.btn_submit.Size = New System.Drawing.Size(338, 42)
        Me.btn_submit.TabIndex = 10
        Me.btn_submit.Text = "Ready to start"
        '
        'currencies
        '
        Me.currencies.BackColor = System.Drawing.Color.Transparent
        Me.currencies.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.currencies.BorderRadius = 4
        Me.currencies.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.currencies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.currencies.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.currencies.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.currencies.FocusedState.Parent = Me.currencies
        Me.currencies.Font = New System.Drawing.Font("Roboto", 10.5!)
        Me.currencies.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.currencies.HoverState.Parent = Me.currencies
        Me.currencies.ItemHeight = 30
        Me.currencies.Items.AddRange(New Object() {"USD", "Rupiah"})
        Me.currencies.ItemsAppearance.Parent = Me.currencies
        Me.currencies.Location = New System.Drawing.Point(199, 407)
        Me.currencies.Name = "currencies"
        Me.currencies.ShadowDecoration.Parent = Me.currencies
        Me.currencies.Size = New System.Drawing.Size(157, 36)
        Me.currencies.StartIndex = 0
        Me.currencies.TabIndex = 12
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(199, 379)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(65, 21)
        Me.Guna2HtmlLabel6.TabIndex = 11
        Me.Guna2HtmlLabel6.Text = "Currency"
        '
        'SetupModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(377, 545)
        Me.Controls.Add(Me.currencies)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.target_projects)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.password_confirmation_box)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.password_box)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.username_box)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SetupModal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elebrary - Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents username_box As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents password_confirmation_box As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents password_box As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents target_projects As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btn_submit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents currencies As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
