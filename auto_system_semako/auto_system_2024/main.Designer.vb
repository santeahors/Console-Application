<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.close_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.user_count_label_txt = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.view_rec_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.home_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.clear_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.save_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.phone_number_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.email_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.full_name_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.profile_id = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.delete_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.fetch_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.passport = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.select_passport_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        CType(Me.passport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.close_btn)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(711, 43)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox1.BorderRadius = 10
        Me.Guna2PictureBox1.Image = Global.auto_system_2024.My.Resources.Resources.afootech_logo
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(5, 2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(38, 38)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'close_btn
        '
        Me.close_btn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.close_btn.Animated = True
        Me.close_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.close_btn.BorderRadius = 19
        Me.close_btn.CheckedState.Parent = Me.close_btn
        Me.close_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close_btn.CustomImages.Parent = Me.close_btn
        Me.close_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.close_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close_btn.ForeColor = System.Drawing.Color.White
        Me.close_btn.HoverState.FillColor = System.Drawing.Color.Maroon
        Me.close_btn.HoverState.Parent = Me.close_btn
        Me.close_btn.Location = New System.Drawing.Point(668, 4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.ShadowDecoration.Parent = Me.close_btn
        Me.close_btn.Size = New System.Drawing.Size(36, 35)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Silver
        Me.Guna2Panel2.Controls.Add(Me.user_count_label_txt)
        Me.Guna2Panel2.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel2.Controls.Add(Me.view_rec_btn)
        Me.Guna2Panel2.Controls.Add(Me.home_btn)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.Silver
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 43)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(706, 43)
        Me.Guna2Panel2.TabIndex = 1
        '
        'user_count_label_txt
        '
        Me.user_count_label_txt.BackColor = System.Drawing.Color.Transparent
        Me.user_count_label_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user_count_label_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.user_count_label_txt.Location = New System.Drawing.Point(619, 12)
        Me.user_count_label_txt.Name = "user_count_label_txt"
        Me.user_count_label_txt.Size = New System.Drawing.Size(11, 17)
        Me.user_count_label_txt.TabIndex = 2
        Me.user_count_label_txt.Text = "0"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(512, 12)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(101, 17)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "USERS COUNT"
        '
        'view_rec_btn
        '
        Me.view_rec_btn.BackColor = System.Drawing.Color.Silver
        Me.view_rec_btn.BorderColor = System.Drawing.Color.Transparent
        Me.view_rec_btn.BorderRadius = 5
        Me.view_rec_btn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.view_rec_btn.CheckedState.Parent = Me.view_rec_btn
        Me.view_rec_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.view_rec_btn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.view_rec_btn.CustomImages.Parent = Me.view_rec_btn
        Me.view_rec_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.view_rec_btn.ForeColor = System.Drawing.Color.White
        Me.view_rec_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.view_rec_btn.HoverState.Parent = Me.view_rec_btn
        Me.view_rec_btn.Location = New System.Drawing.Point(130, 5)
        Me.view_rec_btn.Name = "view_rec_btn"
        Me.view_rec_btn.ShadowDecoration.Parent = Me.view_rec_btn
        Me.view_rec_btn.Size = New System.Drawing.Size(137, 33)
        Me.view_rec_btn.TabIndex = 1
        Me.view_rec_btn.Text = "VIEW RECORD"
        '
        'home_btn
        '
        Me.home_btn.BackColor = System.Drawing.Color.Silver
        Me.home_btn.BorderColor = System.Drawing.Color.Transparent
        Me.home_btn.BorderRadius = 5
        Me.home_btn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.home_btn.CheckedState.Parent = Me.home_btn
        Me.home_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.home_btn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.home_btn.CustomImages.Parent = Me.home_btn
        Me.home_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.home_btn.ForeColor = System.Drawing.Color.White
        Me.home_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.home_btn.HoverState.Parent = Me.home_btn
        Me.home_btn.Location = New System.Drawing.Point(12, 5)
        Me.home_btn.Name = "home_btn"
        Me.home_btn.ShadowDecoration.Parent = Me.home_btn
        Me.home_btn.Size = New System.Drawing.Size(102, 33)
        Me.home_btn.TabIndex = 0
        Me.home_btn.Text = "HOME"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderRadius = 4
        Me.Guna2GroupBox1.Controls.Add(Me.clear_btn)
        Me.Guna2GroupBox1.Controls.Add(Me.save_btn)
        Me.Guna2GroupBox1.Controls.Add(Me.phone_number_txt)
        Me.Guna2GroupBox1.Controls.Add(Me.email_txt)
        Me.Guna2GroupBox1.Controls.Add(Me.full_name_txt)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(12, 203)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(450, 251)
        Me.Guna2GroupBox1.TabIndex = 3
        Me.Guna2GroupBox1.Text = "REGISTRATION"
        '
        'clear_btn
        '
        Me.clear_btn.BackColor = System.Drawing.SystemColors.Control
        Me.clear_btn.BorderColor = System.Drawing.Color.Transparent
        Me.clear_btn.BorderRadius = 5
        Me.clear_btn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.clear_btn.CheckedState.Parent = Me.clear_btn
        Me.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear_btn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.clear_btn.CustomImages.Parent = Me.clear_btn
        Me.clear_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.clear_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.ForeColor = System.Drawing.Color.White
        Me.clear_btn.HoverState.FillColor = System.Drawing.Color.Maroon
        Me.clear_btn.HoverState.Parent = Me.clear_btn
        Me.clear_btn.Location = New System.Drawing.Point(130, 199)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.ShadowDecoration.Parent = Me.clear_btn
        Me.clear_btn.Size = New System.Drawing.Size(102, 33)
        Me.clear_btn.TabIndex = 6
        Me.clear_btn.Text = "CLEAR"
        '
        'save_btn
        '
        Me.save_btn.BackColor = System.Drawing.SystemColors.Control
        Me.save_btn.BorderColor = System.Drawing.Color.Transparent
        Me.save_btn.BorderRadius = 5
        Me.save_btn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.save_btn.CheckedState.Parent = Me.save_btn
        Me.save_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save_btn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.save_btn.CustomImages.Parent = Me.save_btn
        Me.save_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_btn.ForeColor = System.Drawing.Color.White
        Me.save_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.save_btn.HoverState.Parent = Me.save_btn
        Me.save_btn.Location = New System.Drawing.Point(12, 199)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.ShadowDecoration.Parent = Me.save_btn
        Me.save_btn.Size = New System.Drawing.Size(102, 33)
        Me.save_btn.TabIndex = 5
        Me.save_btn.Text = "SAVE"
        '
        'phone_number_txt
        '
        Me.phone_number_txt.BorderRadius = 5
        Me.phone_number_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.phone_number_txt.DefaultText = ""
        Me.phone_number_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.phone_number_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.phone_number_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.phone_number_txt.DisabledState.Parent = Me.phone_number_txt
        Me.phone_number_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.phone_number_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.phone_number_txt.FocusedState.Parent = Me.phone_number_txt
        Me.phone_number_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phone_number_txt.ForeColor = System.Drawing.Color.Black
        Me.phone_number_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.phone_number_txt.HoverState.Parent = Me.phone_number_txt
        Me.phone_number_txt.Location = New System.Drawing.Point(12, 146)
        Me.phone_number_txt.Name = "phone_number_txt"
        Me.phone_number_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.phone_number_txt.PlaceholderText = "PHONE NUMBER"
        Me.phone_number_txt.SelectedText = ""
        Me.phone_number_txt.ShadowDecoration.Parent = Me.phone_number_txt
        Me.phone_number_txt.Size = New System.Drawing.Size(427, 38)
        Me.phone_number_txt.TabIndex = 2
        '
        'email_txt
        '
        Me.email_txt.BorderRadius = 5
        Me.email_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.email_txt.DefaultText = ""
        Me.email_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.email_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.email_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.email_txt.DisabledState.Parent = Me.email_txt
        Me.email_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.email_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email_txt.FocusedState.Parent = Me.email_txt
        Me.email_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_txt.ForeColor = System.Drawing.Color.Black
        Me.email_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email_txt.HoverState.Parent = Me.email_txt
        Me.email_txt.Location = New System.Drawing.Point(12, 101)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.email_txt.PlaceholderText = "EMAIL"
        Me.email_txt.SelectedText = ""
        Me.email_txt.ShadowDecoration.Parent = Me.email_txt
        Me.email_txt.Size = New System.Drawing.Size(427, 38)
        Me.email_txt.TabIndex = 1
        '
        'full_name_txt
        '
        Me.full_name_txt.BorderRadius = 5
        Me.full_name_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.full_name_txt.DefaultText = ""
        Me.full_name_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.full_name_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.full_name_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.full_name_txt.DisabledState.Parent = Me.full_name_txt
        Me.full_name_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.full_name_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.full_name_txt.FocusedState.Parent = Me.full_name_txt
        Me.full_name_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.full_name_txt.ForeColor = System.Drawing.Color.Black
        Me.full_name_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.full_name_txt.HoverState.Parent = Me.full_name_txt
        Me.full_name_txt.Location = New System.Drawing.Point(12, 56)
        Me.full_name_txt.Name = "full_name_txt"
        Me.full_name_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.full_name_txt.PlaceholderText = "FULLNAME"
        Me.full_name_txt.SelectedText = ""
        Me.full_name_txt.ShadowDecoration.Parent = Me.full_name_txt
        Me.full_name_txt.Size = New System.Drawing.Size(427, 38)
        Me.full_name_txt.TabIndex = 0
        '
        'profile_id
        '
        Me.profile_id.BackColor = System.Drawing.Color.Transparent
        Me.profile_id.BorderRadius = 5
        Me.profile_id.Cursor = System.Windows.Forms.Cursors.Hand
        Me.profile_id.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.profile_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.profile_id.FocusedColor = System.Drawing.Color.Empty
        Me.profile_id.FocusedState.Parent = Me.profile_id
        Me.profile_id.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profile_id.ForeColor = System.Drawing.Color.Black
        Me.profile_id.FormattingEnabled = True
        Me.profile_id.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.profile_id.HoverState.Parent = Me.profile_id
        Me.profile_id.ItemHeight = 30
        Me.profile_id.ItemsAppearance.Parent = Me.profile_id
        Me.profile_id.Location = New System.Drawing.Point(14, 20)
        Me.profile_id.Name = "profile_id"
        Me.profile_id.ShadowDecoration.Parent = Me.profile_id
        Me.profile_id.Size = New System.Drawing.Size(656, 36)
        Me.profile_id.TabIndex = 0
        '
        'delete_btn
        '
        Me.delete_btn.BackColor = System.Drawing.SystemColors.Control
        Me.delete_btn.BorderColor = System.Drawing.Color.Transparent
        Me.delete_btn.BorderRadius = 5
        Me.delete_btn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.delete_btn.CheckedState.Parent = Me.delete_btn
        Me.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delete_btn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.delete_btn.CustomImages.Parent = Me.delete_btn
        Me.delete_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.delete_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_btn.ForeColor = System.Drawing.Color.White
        Me.delete_btn.HoverState.FillColor = System.Drawing.Color.Maroon
        Me.delete_btn.HoverState.Parent = Me.delete_btn
        Me.delete_btn.Location = New System.Drawing.Point(568, 62)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.ShadowDecoration.Parent = Me.delete_btn
        Me.delete_btn.Size = New System.Drawing.Size(102, 33)
        Me.delete_btn.TabIndex = 3
        Me.delete_btn.Text = "DELETE"
        '
        'fetch_btn
        '
        Me.fetch_btn.BackColor = System.Drawing.SystemColors.Control
        Me.fetch_btn.BorderColor = System.Drawing.Color.Transparent
        Me.fetch_btn.BorderRadius = 5
        Me.fetch_btn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.fetch_btn.CheckedState.Parent = Me.fetch_btn
        Me.fetch_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fetch_btn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.fetch_btn.CustomImages.Parent = Me.fetch_btn
        Me.fetch_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fetch_btn.ForeColor = System.Drawing.Color.White
        Me.fetch_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fetch_btn.HoverState.Parent = Me.fetch_btn
        Me.fetch_btn.Location = New System.Drawing.Point(456, 62)
        Me.fetch_btn.Name = "fetch_btn"
        Me.fetch_btn.ShadowDecoration.Parent = Me.fetch_btn
        Me.fetch_btn.Size = New System.Drawing.Size(102, 33)
        Me.fetch_btn.TabIndex = 4
        Me.fetch_btn.Text = "FETCH"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.fetch_btn)
        Me.GroupBox1.Controls.Add(Me.delete_btn)
        Me.GroupBox1.Controls.Add(Me.profile_id)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(682, 103)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PROFILE ID"
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BorderRadius = 4
        Me.Guna2GroupBox2.Controls.Add(Me.passport)
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(468, 205)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(225, 201)
        Me.Guna2GroupBox2.TabIndex = 4
        Me.Guna2GroupBox2.Text = "PROFILE PICTURE"
        '
        'passport
        '
        Me.passport.BackgroundImage = Global.auto_system_2024.My.Resources.Resources.download
        Me.passport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.passport.Location = New System.Drawing.Point(8, 42)
        Me.passport.Name = "passport"
        Me.passport.ShadowDecoration.Parent = Me.passport
        Me.passport.Size = New System.Drawing.Size(210, 155)
        Me.passport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.passport.TabIndex = 0
        Me.passport.TabStop = False
        '
        'select_passport_btn
        '
        Me.select_passport_btn.BackColor = System.Drawing.SystemColors.Control
        Me.select_passport_btn.BorderColor = System.Drawing.Color.Transparent
        Me.select_passport_btn.BorderRadius = 5
        Me.select_passport_btn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.select_passport_btn.CheckedState.Parent = Me.select_passport_btn
        Me.select_passport_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.select_passport_btn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.select_passport_btn.CustomImages.Parent = Me.select_passport_btn
        Me.select_passport_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.select_passport_btn.ForeColor = System.Drawing.Color.White
        Me.select_passport_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.select_passport_btn.HoverState.Parent = Me.select_passport_btn
        Me.select_passport_btn.Location = New System.Drawing.Point(468, 412)
        Me.select_passport_btn.Name = "select_passport_btn"
        Me.select_passport_btn.ShadowDecoration.Parent = Me.select_passport_btn
        Me.select_passport_btn.Size = New System.Drawing.Size(225, 42)
        Me.select_passport_btn.TabIndex = 3
        Me.select_passport_btn.Text = "SELECT PASSPORT"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 470)
        Me.Controls.Add(Me.select_passport_btn)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox2.ResumeLayout(False)
        CType(Me.passport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents close_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents home_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents view_rec_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents user_count_label_txt As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents profile_id As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents delete_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents fetch_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents passport As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents clear_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents save_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents phone_number_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents email_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents full_name_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents select_passport_btn As Guna.UI2.WinForms.Guna2Button
End Class
