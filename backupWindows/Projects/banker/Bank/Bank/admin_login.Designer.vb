<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_login
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
        Me.login_panel = New Guna.UI2.WinForms.Guna2Panel()
        Me.forgotpass_link = New System.Windows.Forms.LinkLabel()
        Me.admin_login_btn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.exit_home = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.admin_log_panel = New Guna.UI2.WinForms.Guna2Panel()
        Me.admin_reset_panel = New Guna.UI2.WinForms.Guna2Panel()
        Me.reset = New System.Windows.Forms.GroupBox()
        Me.login_link = New System.Windows.Forms.LinkLabel()
        Me.proceed_btn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2TextBox3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.login_panel.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.admin_log_panel.SuspendLayout()
        Me.admin_reset_panel.SuspendLayout()
        Me.reset.SuspendLayout()
        Me.SuspendLayout()
        '
        'login_panel
        '
        Me.login_panel.BorderColor = System.Drawing.Color.White
        Me.login_panel.BorderRadius = 3
        Me.login_panel.BorderThickness = 2
        Me.login_panel.Controls.Add(Me.forgotpass_link)
        Me.login_panel.Controls.Add(Me.admin_login_btn)
        Me.login_panel.Controls.Add(Me.Guna2HtmlLabel6)
        Me.login_panel.Controls.Add(Me.Guna2HtmlLabel5)
        Me.login_panel.Controls.Add(Me.Guna2TextBox2)
        Me.login_panel.Controls.Add(Me.Guna2TextBox1)
        Me.login_panel.Controls.Add(Me.Guna2HtmlLabel3)
        Me.login_panel.Location = New System.Drawing.Point(3, 25)
        Me.login_panel.Name = "login_panel"
        Me.login_panel.ShadowDecoration.Parent = Me.login_panel
        Me.login_panel.Size = New System.Drawing.Size(441, 321)
        Me.login_panel.TabIndex = 23
        Me.login_panel.UseWaitCursor = True
        '
        'forgotpass_link
        '
        Me.forgotpass_link.AutoSize = True
        Me.forgotpass_link.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forgotpass_link.LinkColor = System.Drawing.Color.DarkGray
        Me.forgotpass_link.Location = New System.Drawing.Point(312, 249)
        Me.forgotpass_link.Name = "forgotpass_link"
        Me.forgotpass_link.Size = New System.Drawing.Size(115, 16)
        Me.forgotpass_link.TabIndex = 22
        Me.forgotpass_link.TabStop = True
        Me.forgotpass_link.Text = "Forgot password?"
        Me.forgotpass_link.UseWaitCursor = True
        '
        'admin_login_btn
        '
        Me.admin_login_btn.Animated = True
        Me.admin_login_btn.BorderRadius = 5
        Me.admin_login_btn.CheckedState.Parent = Me.admin_login_btn
        Me.admin_login_btn.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.admin_login_btn.CustomImages.Parent = Me.admin_login_btn
        Me.admin_login_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.admin_login_btn.FillColor2 = System.Drawing.Color.Navy
        Me.admin_login_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.admin_login_btn.ForeColor = System.Drawing.Color.White
        Me.admin_login_btn.HoverState.Parent = Me.admin_login_btn
        Me.admin_login_btn.Image = Global.Bank.My.Resources.Resources.tick
        Me.admin_login_btn.ImageSize = New System.Drawing.Size(10, 10)
        Me.admin_login_btn.Location = New System.Drawing.Point(26, 236)
        Me.admin_login_btn.Name = "admin_login_btn"
        Me.admin_login_btn.ShadowDecoration.Parent = Me.admin_login_btn
        Me.admin_login_btn.Size = New System.Drawing.Size(152, 42)
        Me.admin_login_btn.TabIndex = 21
        Me.admin_login_btn.Text = "LOG-IN"
        Me.admin_login_btn.UseWaitCursor = True
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(39, 153)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(74, 15)
        Me.Guna2HtmlLabel6.TabIndex = 23
        Me.Guna2HtmlLabel6.Text = "PASSWORD"
        Me.Guna2HtmlLabel6.UseWaitCursor = True
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(39, 52)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(103, 15)
        Me.Guna2HtmlLabel5.TabIndex = 24
        Me.Guna2HtmlLabel5.Text = "EMAIL ADDRESS"
        Me.Guna2HtmlLabel5.UseWaitCursor = True
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox2.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox2.BorderRadius = 7
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.HoverState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.Location = New System.Drawing.Point(21, 174)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2.PlaceholderText = "ENTER YOUR PASSWORD"
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.ShadowDecoration.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.Size = New System.Drawing.Size(408, 48)
        Me.Guna2TextBox2.TabIndex = 19
        Me.Guna2TextBox2.UseWaitCursor = True
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox1.BorderRadius = 7
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.HoverState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Location = New System.Drawing.Point(21, 73)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = "ENTER EMAIL ADDRESS"
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.ShadowDecoration.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Size = New System.Drawing.Size(408, 48)
        Me.Guna2TextBox1.TabIndex = 20
        Me.Guna2TextBox1.UseWaitCursor = True
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(41, 17)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(3, 2)
        Me.Guna2HtmlLabel3.TabIndex = 7
        Me.Guna2HtmlLabel3.Text = Nothing
        Me.Guna2HtmlLabel3.UseWaitCursor = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.exit_home)
        Me.Guna2Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Depth = 55
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Panel1.Size = New System.Drawing.Size(459, 40)
        Me.Guna2Panel1.TabIndex = 22
        Me.Guna2Panel1.UseWaitCursor = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BorderRadius = 10
        Me.Guna2PictureBox1.Image = Global.Bank.My.Resources.Resources.afootech_logo
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(5, 1)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(43, 37)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseWaitCursor = True
        '
        'exit_home
        '
        Me.exit_home.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exit_home.Animated = True
        Me.exit_home.CheckedState.Parent = Me.exit_home
        Me.exit_home.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.exit_home.CustomImages.Parent = Me.exit_home
        Me.exit_home.FillColor = System.Drawing.Color.Red
        Me.exit_home.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_home.ForeColor = System.Drawing.Color.White
        Me.exit_home.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.exit_home.HoverState.Parent = Me.exit_home
        Me.exit_home.Location = New System.Drawing.Point(408, 0)
        Me.exit_home.Name = "exit_home"
        Me.exit_home.ShadowDecoration.Depth = 10
        Me.exit_home.ShadowDecoration.Parent = Me.exit_home
        Me.exit_home.Size = New System.Drawing.Size(51, 40)
        Me.exit_home.TabIndex = 1
        Me.exit_home.Text = "x"
        Me.exit_home.UseWaitCursor = True
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(24, 12)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(225, 27)
        Me.Guna2HtmlLabel1.TabIndex = 25
        Me.Guna2HtmlLabel1.Text = "Administrative Log-in"
        Me.Guna2HtmlLabel1.UseWaitCursor = True
        '
        'admin_log_panel
        '
        Me.admin_log_panel.Controls.Add(Me.Guna2HtmlLabel1)
        Me.admin_log_panel.Controls.Add(Me.login_panel)
        Me.admin_log_panel.Location = New System.Drawing.Point(3, 61)
        Me.admin_log_panel.Name = "admin_log_panel"
        Me.admin_log_panel.ShadowDecoration.Parent = Me.admin_log_panel
        Me.admin_log_panel.Size = New System.Drawing.Size(456, 367)
        Me.admin_log_panel.TabIndex = 26
        Me.admin_log_panel.UseWaitCursor = True
        '
        'admin_reset_panel
        '
        Me.admin_reset_panel.Controls.Add(Me.reset)
        Me.admin_reset_panel.Location = New System.Drawing.Point(11, 72)
        Me.admin_reset_panel.Name = "admin_reset_panel"
        Me.admin_reset_panel.ShadowDecoration.Parent = Me.admin_reset_panel
        Me.admin_reset_panel.Size = New System.Drawing.Size(440, 351)
        Me.admin_reset_panel.TabIndex = 27
        Me.admin_reset_panel.UseWaitCursor = True
        Me.admin_reset_panel.Visible = False
        '
        'reset
        '
        Me.reset.Controls.Add(Me.login_link)
        Me.reset.Controls.Add(Me.proceed_btn)
        Me.reset.Controls.Add(Me.Guna2HtmlLabel4)
        Me.reset.Controls.Add(Me.Guna2TextBox3)
        Me.reset.Location = New System.Drawing.Point(17, 7)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(415, 327)
        Me.reset.TabIndex = 15
        Me.reset.TabStop = False
        Me.reset.Text = "RESET PASSWORD"
        Me.reset.UseWaitCursor = True
        '
        'login_link
        '
        Me.login_link.AutoSize = True
        Me.login_link.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_link.LinkColor = System.Drawing.Color.DarkGray
        Me.login_link.Location = New System.Drawing.Point(323, 141)
        Me.login_link.Name = "login_link"
        Me.login_link.Size = New System.Drawing.Size(57, 24)
        Me.login_link.TabIndex = 20
        Me.login_link.TabStop = True
        Me.login_link.Text = "Login"
        Me.login_link.UseWaitCursor = True
        '
        'proceed_btn
        '
        Me.proceed_btn.Animated = True
        Me.proceed_btn.BorderRadius = 5
        Me.proceed_btn.CheckedState.Parent = Me.proceed_btn
        Me.proceed_btn.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.proceed_btn.CustomImages.Parent = Me.proceed_btn
        Me.proceed_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.proceed_btn.FillColor2 = System.Drawing.Color.Navy
        Me.proceed_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.proceed_btn.ForeColor = System.Drawing.Color.White
        Me.proceed_btn.HoverState.Parent = Me.proceed_btn
        Me.proceed_btn.Image = Global.Bank.My.Resources.Resources.tick
        Me.proceed_btn.ImageSize = New System.Drawing.Size(10, 10)
        Me.proceed_btn.Location = New System.Drawing.Point(31, 131)
        Me.proceed_btn.Name = "proceed_btn"
        Me.proceed_btn.ShadowDecoration.Parent = Me.proceed_btn
        Me.proceed_btn.Size = New System.Drawing.Size(109, 42)
        Me.proceed_btn.TabIndex = 19
        Me.proceed_btn.Text = "PROCEED"
        Me.proceed_btn.UseWaitCursor = True
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(37, 44)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(103, 15)
        Me.Guna2HtmlLabel4.TabIndex = 18
        Me.Guna2HtmlLabel4.Text = "EMAIL ADDRESS"
        Me.Guna2HtmlLabel4.UseWaitCursor = True
        '
        'Guna2TextBox3
        '
        Me.Guna2TextBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox3.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox3.BorderRadius = 7
        Me.Guna2TextBox3.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Guna2TextBox3.DefaultText = ""
        Me.Guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.Parent = Me.Guna2TextBox3
        Me.Guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox3.FocusedState.Parent = Me.Guna2TextBox3
        Me.Guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox3.HoverState.Parent = Me.Guna2TextBox3
        Me.Guna2TextBox3.Location = New System.Drawing.Point(23, 62)
        Me.Guna2TextBox3.Name = "Guna2TextBox3"
        Me.Guna2TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox3.PlaceholderText = "ENTER EMAIL ADDRESS"
        Me.Guna2TextBox3.SelectedText = ""
        Me.Guna2TextBox3.ShadowDecoration.Parent = Me.Guna2TextBox3
        Me.Guna2TextBox3.Size = New System.Drawing.Size(365, 48)
        Me.Guna2TextBox3.TabIndex = 17
        Me.Guna2TextBox3.UseWaitCursor = True
        '
        'admin_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 439)
        Me.Controls.Add(Me.admin_reset_panel)
        Me.Controls.Add(Me.admin_log_panel)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "admin_login"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "admin_login"
        Me.TopMost = True
        Me.login_panel.ResumeLayout(False)
        Me.login_panel.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.admin_log_panel.ResumeLayout(False)
        Me.admin_log_panel.PerformLayout()
        Me.admin_reset_panel.ResumeLayout(False)
        Me.reset.ResumeLayout(False)
        Me.reset.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents login_panel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents forgotpass_link As System.Windows.Forms.LinkLabel
    Friend WithEvents admin_login_btn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents exit_home As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents admin_log_panel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents admin_reset_panel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents reset As System.Windows.Forms.GroupBox
    Friend WithEvents login_link As System.Windows.Forms.LinkLabel
    Friend WithEvents proceed_btn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2TextBox3 As Guna.UI2.WinForms.Guna2TextBox
End Class
