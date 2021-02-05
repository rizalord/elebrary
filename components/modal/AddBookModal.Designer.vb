<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBookModal
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btn_cancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_save = New Guna.UI2.WinForms.Guna2Button()
        Me.box_title = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.box_publishedat = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.box_featured = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.box_stock = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.box_author = New Guna.UI2.WinForms.Guna2TextBox()
        Me.box_publisher = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.box_stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
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
        Me.Guna2Panel1.TabIndex = 0
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
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(100, 38)
        Me.Guna2HtmlLabel1.TabIndex = 3
        Me.Guna2HtmlLabel1.Text = "Add Book"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 469)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.CustomizableEdges.TopLeft = False
        Me.Guna2Panel2.ShadowDecoration.CustomizableEdges.TopRight = False
        Me.Guna2Panel2.ShadowDecoration.Depth = 20
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(750, 54)
        Me.Guna2Panel2.TabIndex = 7
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
        'box_title
        '
        Me.box_title.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.box_title.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.box_title.DefaultText = ""
        Me.box_title.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.box_title.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.box_title.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.box_title.DisabledState.Parent = Me.box_title
        Me.box_title.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.box_title.FillColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.box_title.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.box_title.FocusedState.Parent = Me.box_title
        Me.box_title.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.box_title.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.box_title.HoverState.Parent = Me.box_title
        Me.box_title.Location = New System.Drawing.Point(318, 87)
        Me.box_title.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.box_title.Name = "box_title"
        Me.box_title.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.box_title.PlaceholderText = ""
        Me.box_title.SelectedText = ""
        Me.box_title.ShadowDecoration.Parent = Me.box_title
        Me.box_title.Size = New System.Drawing.Size(253, 32)
        Me.box_title.TabIndex = 10
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(261, 89)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(36, 30)
        Me.Guna2HtmlLabel2.TabIndex = 9
        Me.Guna2HtmlLabel2.Text = "Title"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(241, 152)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(56, 30)
        Me.Guna2HtmlLabel3.TabIndex = 11
        Me.Guna2HtmlLabel3.Text = "Author"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(220, 214)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(77, 30)
        Me.Guna2HtmlLabel4.TabIndex = 13
        Me.Guna2HtmlLabel4.Text = "Publisher"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(194, 280)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(103, 30)
        Me.Guna2HtmlLabel5.TabIndex = 14
        Me.Guna2HtmlLabel5.Text = "Published At"
        '
        'box_publishedat
        '
        Me.box_publishedat.CheckedState.Parent = Me.box_publishedat
        Me.box_publishedat.FillColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.box_publishedat.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.box_publishedat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.box_publishedat.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.box_publishedat.HoverState.Parent = Me.box_publishedat
        Me.box_publishedat.Location = New System.Drawing.Point(318, 278)
        Me.box_publishedat.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.box_publishedat.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.box_publishedat.Name = "box_publishedat"
        Me.box_publishedat.ShadowDecoration.Parent = Me.box_publishedat
        Me.box_publishedat.Size = New System.Drawing.Size(253, 32)
        Me.box_publishedat.TabIndex = 15
        Me.box_publishedat.Value = New Date(2021, 1, 19, 17, 8, 36, 147)
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(249, 343)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(48, 30)
        Me.Guna2HtmlLabel6.TabIndex = 16
        Me.Guna2HtmlLabel6.Text = "Stock"
        '
        'box_featured
        '
        Me.box_featured.BackColor = System.Drawing.Color.Transparent
        Me.box_featured.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.box_featured.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.box_featured.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.box_featured.CheckedState.InnerColor = System.Drawing.Color.White
        Me.box_featured.CheckedState.Parent = Me.box_featured
        Me.box_featured.Location = New System.Drawing.Point(318, 403)
        Me.box_featured.Name = "box_featured"
        Me.box_featured.ShadowDecoration.Parent = Me.box_featured
        Me.box_featured.Size = New System.Drawing.Size(56, 32)
        Me.box_featured.TabIndex = 0
        Me.box_featured.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.box_featured.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.box_featured.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.box_featured.UncheckedState.InnerColor = System.Drawing.Color.White
        Me.box_featured.UncheckedState.Parent = Me.box_featured
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(222, 405)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(75, 30)
        Me.Guna2HtmlLabel7.TabIndex = 18
        Me.Guna2HtmlLabel7.Text = "Featured"
        '
        'box_stock
        '
        Me.box_stock.BackColor = System.Drawing.Color.Transparent
        Me.box_stock.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.box_stock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.box_stock.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.box_stock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.box_stock.DisabledState.Parent = Me.box_stock
        Me.box_stock.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.box_stock.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.box_stock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.box_stock.FocusedState.Parent = Me.box_stock
        Me.box_stock.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.box_stock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.box_stock.Location = New System.Drawing.Point(318, 341)
        Me.box_stock.Name = "box_stock"
        Me.box_stock.ShadowDecoration.Parent = Me.box_stock
        Me.box_stock.Size = New System.Drawing.Size(253, 32)
        Me.box_stock.TabIndex = 19
        Me.box_stock.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        '
        'box_author
        '
        Me.box_author.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.box_author.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.box_author.DefaultText = ""
        Me.box_author.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.box_author.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.box_author.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.box_author.DisabledState.Parent = Me.box_author
        Me.box_author.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.box_author.FillColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.box_author.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.box_author.FocusedState.Parent = Me.box_author
        Me.box_author.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.box_author.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.box_author.HoverState.Parent = Me.box_author
        Me.box_author.Location = New System.Drawing.Point(318, 150)
        Me.box_author.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.box_author.Name = "box_author"
        Me.box_author.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.box_author.PlaceholderText = ""
        Me.box_author.SelectedText = ""
        Me.box_author.ShadowDecoration.Parent = Me.box_author
        Me.box_author.Size = New System.Drawing.Size(253, 32)
        Me.box_author.TabIndex = 20
        '
        'box_publisher
        '
        Me.box_publisher.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.box_publisher.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.box_publisher.DefaultText = ""
        Me.box_publisher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.box_publisher.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.box_publisher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.box_publisher.DisabledState.Parent = Me.box_publisher
        Me.box_publisher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.box_publisher.FillColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.box_publisher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.box_publisher.FocusedState.Parent = Me.box_publisher
        Me.box_publisher.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.box_publisher.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.box_publisher.HoverState.Parent = Me.box_publisher
        Me.box_publisher.Location = New System.Drawing.Point(318, 213)
        Me.box_publisher.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.box_publisher.Name = "box_publisher"
        Me.box_publisher.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.box_publisher.PlaceholderText = ""
        Me.box_publisher.SelectedText = ""
        Me.box_publisher.ShadowDecoration.Parent = Me.box_publisher
        Me.box_publisher.Size = New System.Drawing.Size(253, 32)
        Me.box_publisher.TabIndex = 21
        '
        'AddBookModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(750, 523)
        Me.Controls.Add(Me.box_publisher)
        Me.Controls.Add(Me.box_author)
        Me.Controls.Add(Me.box_stock)
        Me.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Controls.Add(Me.box_featured)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.box_publishedat)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.box_title)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddBookModal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddBookModal"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        CType(Me.box_stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btn_cancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents box_featured As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents box_publishedat As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents box_title As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents box_stock As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents box_publisher As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents box_author As Guna.UI2.WinForms.Guna2TextBox
End Class
