<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.admin_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.user_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.Controls.Add(Me.admin_btn)
        Me.Guna2Panel1.Controls.Add(Me.user_btn)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(89, 41)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(787, 414)
        Me.Guna2Panel1.TabIndex = 0
        '
        'admin_btn
        '
        Me.admin_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.admin_btn.Animated = True
        Me.admin_btn.BorderRadius = 5
        Me.admin_btn.CheckedState.Parent = Me.admin_btn
        Me.admin_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.admin_btn.CustomImages.Parent = Me.admin_btn
        Me.admin_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.admin_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_btn.ForeColor = System.Drawing.Color.White
        Me.admin_btn.HoverState.FillColor = System.Drawing.Color.Navy
        Me.admin_btn.HoverState.Parent = Me.admin_btn
        Me.admin_btn.Location = New System.Drawing.Point(495, 240)
        Me.admin_btn.Name = "admin_btn"
        Me.admin_btn.ShadowDecoration.Parent = Me.admin_btn
        Me.admin_btn.Size = New System.Drawing.Size(153, 48)
        Me.admin_btn.TabIndex = 1
        Me.admin_btn.Text = "LOGIN AS ADMIN"
        '
        'user_btn
        '
        Me.user_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.user_btn.Animated = True
        Me.user_btn.BorderRadius = 5
        Me.user_btn.CheckedState.Parent = Me.user_btn
        Me.user_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.user_btn.CustomImages.Parent = Me.user_btn
        Me.user_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.user_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user_btn.ForeColor = System.Drawing.Color.White
        Me.user_btn.HoverState.FillColor = System.Drawing.Color.Navy
        Me.user_btn.HoverState.Parent = Me.user_btn
        Me.user_btn.Location = New System.Drawing.Point(198, 240)
        Me.user_btn.Name = "user_btn"
        Me.user_btn.ShadowDecoration.Parent = Me.user_btn
        Me.user_btn.Size = New System.Drawing.Size(153, 48)
        Me.user_btn.TabIndex = 1
        Me.user_btn.Text = "LOGIN AS USER"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(184, 159)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(464, 40)
        Me.Guna2HtmlLabel2.TabIndex = 0
        Me.Guna2HtmlLabel2.Text = "APPLICATION SOFTWARE"
        Me.Guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(53, 107)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(689, 40)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "WELCOME TO BANK SANTEAHORS PLC"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(940, 481)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "BANK SANTEAHORS"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents admin_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents user_btn As Guna.UI2.WinForms.Guna2Button

End Class
