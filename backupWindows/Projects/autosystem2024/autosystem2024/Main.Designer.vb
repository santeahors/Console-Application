<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        close_btn = New Button()
        Panel2 = New Panel()
        Label1 = New Label()
        MASTER = New Label()
        record_btn = New Button()
        home_btn = New Button()
        REGISTRATION = New GroupBox()
        Label4 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        phone = New TextBox()
        email = New TextBox()
        fullname = New TextBox()
        GroupBox1 = New GroupBox()
        delete_btn = New Button()
        fetch_btn = New Button()
        profile_id = New ComboBox()
        GroupBox2 = New GroupBox()
        selectpicture_btn = New Button()
        passport = New PictureBox()
        clear_btn = New Button()
        submit_btn = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        REGISTRATION.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(passport, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        resources.ApplyResources(Panel1, "Panel1")
        Panel1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(close_btn)
        Panel1.Name = "Panel1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        resources.ApplyResources(PictureBox1, "PictureBox1")
        PictureBox1.Name = "PictureBox1"
        PictureBox1.TabStop = False
        ' 
        ' close_btn
        ' 
        resources.ApplyResources(close_btn, "close_btn")
        close_btn.BackColor = Color.Red
        close_btn.FlatAppearance.BorderSize = 0
        close_btn.ForeColor = SystemColors.ControlLightLight
        close_btn.Name = "close_btn"
        close_btn.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Control
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(MASTER)
        Panel2.Controls.Add(record_btn)
        Panel2.Controls.Add(home_btn)
        resources.ApplyResources(Panel2, "Panel2")
        Panel2.Name = "Panel2"
        ' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.ForeColor = Color.Red
        Label1.Name = "Label1"
        ' 
        ' MASTER
        ' 
        resources.ApplyResources(MASTER, "MASTER")
        MASTER.Name = "MASTER"
        ' 
        ' record_btn
        ' 
        record_btn.AutoEllipsis = True
        record_btn.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        record_btn.Cursor = Cursors.AppStarting
        record_btn.FlatAppearance.BorderSize = 0
        record_btn.FlatAppearance.CheckedBackColor = Color.Red
        record_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        record_btn.FlatAppearance.MouseOverBackColor = Color.Red
        resources.ApplyResources(record_btn, "record_btn")
        record_btn.ForeColor = Color.WhiteSmoke
        record_btn.Name = "record_btn"
        record_btn.UseCompatibleTextRendering = True
        record_btn.UseVisualStyleBackColor = True
        record_btn.UseWaitCursor = True
        ' 
        ' home_btn
        ' 
        home_btn.AutoEllipsis = True
        home_btn.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        home_btn.Cursor = Cursors.AppStarting
        home_btn.FlatAppearance.BorderSize = 0
        home_btn.FlatAppearance.CheckedBackColor = Color.Red
        home_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        home_btn.FlatAppearance.MouseOverBackColor = Color.Red
        resources.ApplyResources(home_btn, "home_btn")
        home_btn.ForeColor = Color.WhiteSmoke
        home_btn.Name = "home_btn"
        home_btn.UseCompatibleTextRendering = True
        home_btn.UseVisualStyleBackColor = True
        home_btn.UseWaitCursor = True
        ' 
        ' REGISTRATION
        ' 
        REGISTRATION.BackColor = Color.WhiteSmoke
        REGISTRATION.Controls.Add(Label4)
        REGISTRATION.Controls.Add(Label2)
        REGISTRATION.Controls.Add(Label3)
        REGISTRATION.Controls.Add(phone)
        REGISTRATION.Controls.Add(email)
        REGISTRATION.Controls.Add(fullname)
        resources.ApplyResources(REGISTRATION, "REGISTRATION")
        REGISTRATION.Name = "REGISTRATION"
        REGISTRATION.TabStop = False
        ' 
        ' Label4
        ' 
        resources.ApplyResources(Label4, "Label4")
        Label4.Name = "Label4"
        ' 
        ' Label2
        ' 
        resources.ApplyResources(Label2, "Label2")
        Label2.Name = "Label2"
        ' 
        ' Label3
        ' 
        resources.ApplyResources(Label3, "Label3")
        Label3.Name = "Label3"
        ' 
        ' phone
        ' 
        phone.BackColor = SystemColors.Menu
        phone.BorderStyle = BorderStyle.None
        resources.ApplyResources(phone, "phone")
        phone.Name = "phone"
        ' 
        ' email
        ' 
        email.BackColor = SystemColors.Menu
        email.BorderStyle = BorderStyle.None
        resources.ApplyResources(email, "email")
        email.Name = "email"
        ' 
        ' fullname
        ' 
        fullname.BackColor = SystemColors.Menu
        fullname.BorderStyle = BorderStyle.None
        resources.ApplyResources(fullname, "fullname")
        fullname.Name = "fullname"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.WhiteSmoke
        GroupBox1.Controls.Add(delete_btn)
        GroupBox1.Controls.Add(fetch_btn)
        GroupBox1.Controls.Add(profile_id)
        resources.ApplyResources(GroupBox1, "GroupBox1")
        GroupBox1.Name = "GroupBox1"
        GroupBox1.TabStop = False
        ' 
        ' delete_btn
        ' 
        delete_btn.BackColor = Color.Red
        delete_btn.FlatAppearance.BorderSize = 0
        delete_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        resources.ApplyResources(delete_btn, "delete_btn")
        delete_btn.ForeColor = Color.WhiteSmoke
        delete_btn.Name = "delete_btn"
        delete_btn.UseVisualStyleBackColor = False
        ' 
        ' fetch_btn
        ' 
        fetch_btn.AutoEllipsis = True
        fetch_btn.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        fetch_btn.Cursor = Cursors.AppStarting
        fetch_btn.FlatAppearance.BorderSize = 0
        fetch_btn.FlatAppearance.CheckedBackColor = Color.Red
        fetch_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        fetch_btn.FlatAppearance.MouseOverBackColor = Color.Red
        resources.ApplyResources(fetch_btn, "fetch_btn")
        fetch_btn.ForeColor = Color.WhiteSmoke
        fetch_btn.Name = "fetch_btn"
        fetch_btn.UseCompatibleTextRendering = True
        fetch_btn.UseVisualStyleBackColor = True
        fetch_btn.UseWaitCursor = True
        ' 
        ' profile_id
        ' 
        resources.ApplyResources(profile_id, "profile_id")
        profile_id.FormattingEnabled = True
        profile_id.Name = "profile_id"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.WhiteSmoke
        GroupBox2.Controls.Add(selectpicture_btn)
        GroupBox2.Controls.Add(passport)
        resources.ApplyResources(GroupBox2, "GroupBox2")
        GroupBox2.Name = "GroupBox2"
        GroupBox2.TabStop = False
        ' 
        ' selectpicture_btn
        ' 
        selectpicture_btn.AutoEllipsis = True
        selectpicture_btn.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        selectpicture_btn.Cursor = Cursors.AppStarting
        selectpicture_btn.FlatAppearance.BorderSize = 0
        selectpicture_btn.FlatAppearance.MouseOverBackColor = Color.Red
        resources.ApplyResources(selectpicture_btn, "selectpicture_btn")
        selectpicture_btn.ForeColor = Color.WhiteSmoke
        selectpicture_btn.Name = "selectpicture_btn"
        selectpicture_btn.UseCompatibleTextRendering = True
        selectpicture_btn.UseVisualStyleBackColor = True
        selectpicture_btn.UseWaitCursor = True
        ' 
        ' passport
        ' 
        passport.BackgroundImage = My.Resources.Resources.passport
        resources.ApplyResources(passport, "passport")
        passport.Image = My.Resources.Resources.passport
        passport.Name = "passport"
        passport.TabStop = False
        ' 
        ' clear_btn
        ' 
        clear_btn.BackColor = Color.Red
        clear_btn.FlatAppearance.BorderSize = 0
        clear_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        resources.ApplyResources(clear_btn, "clear_btn")
        clear_btn.ForeColor = Color.WhiteSmoke
        clear_btn.Name = "clear_btn"
        clear_btn.UseVisualStyleBackColor = False
        ' 
        ' submit_btn
        ' 
        submit_btn.AutoEllipsis = True
        submit_btn.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        submit_btn.Cursor = Cursors.AppStarting
        submit_btn.FlatAppearance.BorderSize = 0
        submit_btn.FlatAppearance.CheckedBackColor = Color.Red
        submit_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        submit_btn.FlatAppearance.MouseOverBackColor = Color.Red
        resources.ApplyResources(submit_btn, "submit_btn")
        submit_btn.ForeColor = Color.WhiteSmoke
        submit_btn.Name = "submit_btn"
        submit_btn.UseCompatibleTextRendering = True
        submit_btn.UseVisualStyleBackColor = True
        submit_btn.UseWaitCursor = True
        ' 
        ' Main
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Dpi
        Controls.Add(clear_btn)
        Controls.Add(submit_btn)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(REGISTRATION)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        ForeColor = Color.Black
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "Main"
        Opacity = 0.95R
        TopMost = True
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        REGISTRATION.ResumeLayout(False)
        REGISTRATION.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        CType(passport, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents close_btn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents record_btn As Button
    Friend WithEvents home_btn As Button
    Friend WithEvents REGISTRATION As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MASTER As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents delete_btn As Button
    Friend WithEvents fetch_btn As Button
    Friend WithEvents profile_id As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents selectpicture_btn As Button
    Friend WithEvents passport As PictureBox
    Friend WithEvents phone As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents fullname As TextBox
    Friend WithEvents clear_btn As Button
    Friend WithEvents submit_btn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
