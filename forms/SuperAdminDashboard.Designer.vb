<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuperAdminDashboard
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
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.name_label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.navbar_dropdown = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.nav_admins = New Guna.UI2.WinForms.Guna2Button()
        Me.nav_classes = New Guna.UI2.WinForms.Guna2Button()
        Me.nav_loans = New Guna.UI2.WinForms.Guna2Button()
        Me.nav_books = New Guna.UI2.WinForms.Guna2Button()
        Me.nav_dashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.MainPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.name_label)
        Me.Guna2Panel1.Controls.Add(Me.navbar_dropdown)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel5)
        Me.Guna2Panel1.Controls.Add(Me.nav_admins)
        Me.Guna2Panel1.Controls.Add(Me.nav_classes)
        Me.Guna2Panel1.Controls.Add(Me.nav_loans)
        Me.Guna2Panel1.Controls.Add(Me.nav_books)
        Me.Guna2Panel1.Controls.Add(Me.nav_dashboard)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1136, 59)
        Me.Guna2Panel1.TabIndex = 0
        '
        'name_label
        '
        Me.name_label.BackColor = System.Drawing.Color.Transparent
        Me.name_label.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.name_label.ForeColor = System.Drawing.Color.Black
        Me.name_label.Location = New System.Drawing.Point(919, 19)
        Me.name_label.Name = "name_label"
        Me.name_label.Size = New System.Drawing.Size(121, 25)
        Me.name_label.TabIndex = 13
        Me.name_label.Text = "Ahmad Khamdani"
        Me.name_label.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'navbar_dropdown
        '
        Me.navbar_dropdown.BackColor = System.Drawing.Color.Transparent
        Me.navbar_dropdown.BorderColor = System.Drawing.Color.White
        Me.navbar_dropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.navbar_dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.navbar_dropdown.FocusedColor = System.Drawing.Color.White
        Me.navbar_dropdown.FocusedState.BorderColor = System.Drawing.Color.White
        Me.navbar_dropdown.FocusedState.FillColor = System.Drawing.Color.White
        Me.navbar_dropdown.FocusedState.Parent = Me.navbar_dropdown
        Me.navbar_dropdown.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.navbar_dropdown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.navbar_dropdown.HoverState.Parent = Me.navbar_dropdown
        Me.navbar_dropdown.ItemHeight = 30
        Me.navbar_dropdown.Items.AddRange(New Object() {"Profile", "Logout"})
        Me.navbar_dropdown.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.navbar_dropdown.ItemsAppearance.ForeColor = System.Drawing.Color.Black
        Me.navbar_dropdown.ItemsAppearance.Parent = Me.navbar_dropdown
        Me.navbar_dropdown.ItemsAppearance.SelectedBackColor = System.Drawing.Color.WhiteSmoke
        Me.navbar_dropdown.Location = New System.Drawing.Point(926, 12)
        Me.navbar_dropdown.Name = "navbar_dropdown"
        Me.navbar_dropdown.ShadowDecoration.Parent = Me.navbar_dropdown
        Me.navbar_dropdown.Size = New System.Drawing.Size(140, 36)
        Me.navbar_dropdown.TabIndex = 12
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel5.Location = New System.Drawing.Point(1072, 0)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        Me.Guna2Panel5.Size = New System.Drawing.Size(64, 59)
        Me.Guna2Panel5.TabIndex = 11
        '
        'nav_admins
        '
        Me.nav_admins.Animated = True
        Me.nav_admins.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.nav_admins.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.nav_admins.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.nav_admins.CheckedState.FillColor = System.Drawing.Color.White
        Me.nav_admins.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_admins.CheckedState.Parent = Me.nav_admins
        Me.nav_admins.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.nav_admins.CustomImages.Parent = Me.nav_admins
        Me.nav_admins.Dock = System.Windows.Forms.DockStyle.Left
        Me.nav_admins.FillColor = System.Drawing.Color.White
        Me.nav_admins.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.nav_admins.ForeColor = System.Drawing.Color.Black
        Me.nav_admins.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.nav_admins.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_admins.HoverState.Parent = Me.nav_admins
        Me.nav_admins.Location = New System.Drawing.Point(525, 0)
        Me.nav_admins.Name = "nav_admins"
        Me.nav_admins.PressedDepth = 0
        Me.nav_admins.ShadowDecoration.Parent = Me.nav_admins
        Me.nav_admins.Size = New System.Drawing.Size(89, 59)
        Me.nav_admins.TabIndex = 10
        Me.nav_admins.Text = "Admins"
        '
        'nav_classes
        '
        Me.nav_classes.Animated = True
        Me.nav_classes.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.nav_classes.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.nav_classes.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.nav_classes.CheckedState.FillColor = System.Drawing.Color.White
        Me.nav_classes.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_classes.CheckedState.Parent = Me.nav_classes
        Me.nav_classes.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.nav_classes.CustomImages.Parent = Me.nav_classes
        Me.nav_classes.Dock = System.Windows.Forms.DockStyle.Left
        Me.nav_classes.FillColor = System.Drawing.Color.White
        Me.nav_classes.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.nav_classes.ForeColor = System.Drawing.Color.Black
        Me.nav_classes.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.nav_classes.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_classes.HoverState.Parent = Me.nav_classes
        Me.nav_classes.Location = New System.Drawing.Point(432, 0)
        Me.nav_classes.Name = "nav_classes"
        Me.nav_classes.PressedDepth = 0
        Me.nav_classes.ShadowDecoration.Parent = Me.nav_classes
        Me.nav_classes.Size = New System.Drawing.Size(93, 59)
        Me.nav_classes.TabIndex = 9
        Me.nav_classes.Text = "Classes"
        '
        'nav_loans
        '
        Me.nav_loans.Animated = True
        Me.nav_loans.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.nav_loans.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.nav_loans.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.nav_loans.CheckedState.FillColor = System.Drawing.Color.White
        Me.nav_loans.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_loans.CheckedState.Parent = Me.nav_loans
        Me.nav_loans.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.nav_loans.CustomImages.Parent = Me.nav_loans
        Me.nav_loans.Dock = System.Windows.Forms.DockStyle.Left
        Me.nav_loans.FillColor = System.Drawing.Color.White
        Me.nav_loans.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.nav_loans.ForeColor = System.Drawing.Color.Black
        Me.nav_loans.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.nav_loans.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_loans.HoverState.Parent = Me.nav_loans
        Me.nav_loans.Location = New System.Drawing.Point(347, 0)
        Me.nav_loans.Name = "nav_loans"
        Me.nav_loans.PressedDepth = 0
        Me.nav_loans.ShadowDecoration.Parent = Me.nav_loans
        Me.nav_loans.Size = New System.Drawing.Size(85, 59)
        Me.nav_loans.TabIndex = 8
        Me.nav_loans.Text = "Loans"
        '
        'nav_books
        '
        Me.nav_books.Animated = True
        Me.nav_books.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.nav_books.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.nav_books.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.nav_books.CheckedState.FillColor = System.Drawing.Color.White
        Me.nav_books.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_books.CheckedState.Parent = Me.nav_books
        Me.nav_books.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.nav_books.CustomImages.Parent = Me.nav_books
        Me.nav_books.Dock = System.Windows.Forms.DockStyle.Left
        Me.nav_books.FillColor = System.Drawing.Color.White
        Me.nav_books.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.nav_books.ForeColor = System.Drawing.Color.Black
        Me.nav_books.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.nav_books.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_books.HoverState.Parent = Me.nav_books
        Me.nav_books.Location = New System.Drawing.Point(257, 0)
        Me.nav_books.Name = "nav_books"
        Me.nav_books.PressedDepth = 0
        Me.nav_books.ShadowDecoration.Parent = Me.nav_books
        Me.nav_books.Size = New System.Drawing.Size(90, 59)
        Me.nav_books.TabIndex = 7
        Me.nav_books.Text = "Books"
        '
        'nav_dashboard
        '
        Me.nav_dashboard.Animated = True
        Me.nav_dashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.nav_dashboard.Checked = True
        Me.nav_dashboard.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.nav_dashboard.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.nav_dashboard.CheckedState.FillColor = System.Drawing.Color.White
        Me.nav_dashboard.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_dashboard.CheckedState.Parent = Me.nav_dashboard
        Me.nav_dashboard.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.nav_dashboard.CustomImages.Parent = Me.nav_dashboard
        Me.nav_dashboard.Dock = System.Windows.Forms.DockStyle.Left
        Me.nav_dashboard.FillColor = System.Drawing.Color.White
        Me.nav_dashboard.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.nav_dashboard.ForeColor = System.Drawing.Color.Black
        Me.nav_dashboard.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.nav_dashboard.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_dashboard.HoverState.Parent = Me.nav_dashboard
        Me.nav_dashboard.Location = New System.Drawing.Point(149, 0)
        Me.nav_dashboard.Name = "nav_dashboard"
        Me.nav_dashboard.PressedDepth = 0
        Me.nav_dashboard.ShadowDecoration.Parent = Me.nav_dashboard
        Me.nav_dashboard.Size = New System.Drawing.Size(108, 59)
        Me.nav_dashboard.TabIndex = 6
        Me.nav_dashboard.Text = "Dashboard"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel4.Location = New System.Drawing.Point(123, 0)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(26, 59)
        Me.Guna2Panel4.TabIndex = 5
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackgroundImage = Global.Elebrary.My.Resources.Resources.logo
        Me.Guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel2.Location = New System.Drawing.Point(64, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(59, 59)
        Me.Guna2Panel2.TabIndex = 3
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(64, 59)
        Me.Guna2Panel3.TabIndex = 2
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.White
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MainPanel.Location = New System.Drawing.Point(0, 61)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.ShadowDecoration.Parent = Me.MainPanel
        Me.MainPanel.Size = New System.Drawing.Size(1136, 600)
        Me.MainPanel.TabIndex = 1
        '
        'SuperAdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1136, 661)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SuperAdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SuperAdminDashboard"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents nav_admins As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents nav_classes As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents nav_loans As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents nav_books As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents nav_dashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents MainPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents navbar_dropdown As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents name_label As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
