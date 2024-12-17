<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class index_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(index_form))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.loginAdminBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.loginUserBtn = New Guna.UI2.WinForms.Guna2Button()
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
        Me.Guna2Panel1.Controls.Add(Me.loginAdminBtn)
        Me.Guna2Panel1.Controls.Add(Me.loginUserBtn)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(116, 49)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(787, 414)
        Me.Guna2Panel1.TabIndex = 1
        '
        'loginAdminBtn
        '
        Me.loginAdminBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.loginAdminBtn.Animated = True
        Me.loginAdminBtn.BorderRadius = 5
        Me.loginAdminBtn.CheckedState.Parent = Me.loginAdminBtn
        Me.loginAdminBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginAdminBtn.CustomImages.Parent = Me.loginAdminBtn
        Me.loginAdminBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.loginAdminBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginAdminBtn.ForeColor = System.Drawing.Color.White
        Me.loginAdminBtn.HoverState.FillColor = System.Drawing.Color.Navy
        Me.loginAdminBtn.HoverState.Parent = Me.loginAdminBtn
        Me.loginAdminBtn.Location = New System.Drawing.Point(495, 240)
        Me.loginAdminBtn.Name = "loginAdminBtn"
        Me.loginAdminBtn.ShadowDecoration.Parent = Me.loginAdminBtn
        Me.loginAdminBtn.Size = New System.Drawing.Size(153, 48)
        Me.loginAdminBtn.TabIndex = 1
        Me.loginAdminBtn.Text = "LOGIN AS ADMIN"
        '
        'loginUserBtn
        '
        Me.loginUserBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.loginUserBtn.Animated = True
        Me.loginUserBtn.BorderRadius = 5
        Me.loginUserBtn.CheckedState.Parent = Me.loginUserBtn
        Me.loginUserBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginUserBtn.CustomImages.Parent = Me.loginUserBtn
        Me.loginUserBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.loginUserBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginUserBtn.ForeColor = System.Drawing.Color.White
        Me.loginUserBtn.HoverState.FillColor = System.Drawing.Color.Navy
        Me.loginUserBtn.HoverState.Parent = Me.loginUserBtn
        Me.loginUserBtn.Location = New System.Drawing.Point(198, 240)
        Me.loginUserBtn.Name = "loginUserBtn"
        Me.loginUserBtn.ShadowDecoration.Parent = Me.loginUserBtn
        Me.loginUserBtn.Size = New System.Drawing.Size(153, 48)
        Me.loginUserBtn.TabIndex = 1
        Me.loginUserBtn.Text = "LOGIN AS USER"
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
        'index_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1019, 513)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "index_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "BANK SANTEAHORS PLC"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents loginAdminBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents loginUserBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
