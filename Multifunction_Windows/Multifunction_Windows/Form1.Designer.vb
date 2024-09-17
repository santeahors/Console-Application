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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.close = New System.Windows.Forms.Button()
        Me.Minimize = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.sc_btn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.gp_btn = New System.Windows.Forms.Button()
        Me.age_btn = New System.Windows.Forms.Button()
        Me.loan_btn = New System.Windows.Forms.Button()
        Me.boyle_btn = New System.Windows.Forms.Button()
        Me.unit_btn = New System.Windows.Forms.Button()
        Me.HomePage = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button34 = New System.Windows.Forms.Button()
        Me.Button35 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.HomePage.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.close)
        Me.Panel1.Controls.Add(Me.Minimize)
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1434, 37)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'close
        '
        Me.close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.close.BackColor = System.Drawing.Color.DarkRed
        Me.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.close.Location = New System.Drawing.Point(1371, 0)
        Me.close.Name = "close"
        Me.close.Size = New System.Drawing.Size(62, 37)
        Me.close.TabIndex = 1
        Me.close.Text = "X"
        Me.close.UseVisualStyleBackColor = False
        '
        'Minimize
        '
        Me.Minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minimize.BackColor = System.Drawing.Color.DarkGray
        Me.Minimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Minimize.Location = New System.Drawing.Point(1311, 0)
        Me.Minimize.Name = "Minimize"
        Me.Minimize.Size = New System.Drawing.Size(62, 37)
        Me.Minimize.TabIndex = 0
        Me.Minimize.Text = "-"
        Me.Minimize.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.sc_btn)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.gp_btn)
        Me.Panel2.Controls.Add(Me.age_btn)
        Me.Panel2.Controls.Add(Me.loan_btn)
        Me.Panel2.Controls.Add(Me.boyle_btn)
        Me.Panel2.Controls.Add(Me.unit_btn)
        Me.Panel2.Location = New System.Drawing.Point(0, 39)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(226, 647)
        Me.Panel2.TabIndex = 1
        '
        'sc_btn
        '
        Me.sc_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.sc_btn.FlatAppearance.BorderSize = 0
        Me.sc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sc_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_btn.ForeColor = System.Drawing.Color.DodgerBlue
        Me.sc_btn.Location = New System.Drawing.Point(2, 320)
        Me.sc_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.sc_btn.Name = "sc_btn"
        Me.sc_btn.Size = New System.Drawing.Size(222, 50)
        Me.sc_btn.TabIndex = 14
        Me.sc_btn.Text = "SCIENTIFIC CALCULATOR"
        Me.sc_btn.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Button2.Location = New System.Drawing.Point(3, 215)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(222, 50)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "HOME PAGE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'gp_btn
        '
        Me.gp_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.gp_btn.FlatAppearance.BorderSize = 0
        Me.gp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gp_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gp_btn.ForeColor = System.Drawing.Color.DodgerBlue
        Me.gp_btn.Location = New System.Drawing.Point(2, 268)
        Me.gp_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.gp_btn.Name = "gp_btn"
        Me.gp_btn.Size = New System.Drawing.Size(222, 50)
        Me.gp_btn.TabIndex = 15
        Me.gp_btn.Text = "GP CALCULATOR"
        Me.gp_btn.UseVisualStyleBackColor = False
        '
        'age_btn
        '
        Me.age_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.age_btn.FlatAppearance.BorderSize = 0
        Me.age_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.age_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.age_btn.ForeColor = System.Drawing.Color.DodgerBlue
        Me.age_btn.Location = New System.Drawing.Point(2, 374)
        Me.age_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.age_btn.Name = "age_btn"
        Me.age_btn.Size = New System.Drawing.Size(222, 50)
        Me.age_btn.TabIndex = 12
        Me.age_btn.Text = "AGE CALCULATOR"
        Me.age_btn.UseVisualStyleBackColor = False
        '
        'loan_btn
        '
        Me.loan_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.loan_btn.FlatAppearance.BorderSize = 0
        Me.loan_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loan_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loan_btn.ForeColor = System.Drawing.Color.DodgerBlue
        Me.loan_btn.Location = New System.Drawing.Point(0, 479)
        Me.loan_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.loan_btn.Name = "loan_btn"
        Me.loan_btn.Size = New System.Drawing.Size(222, 50)
        Me.loan_btn.TabIndex = 10
        Me.loan_btn.Text = "LOAN CALCULATOR"
        Me.loan_btn.UseVisualStyleBackColor = False
        '
        'boyle_btn
        '
        Me.boyle_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.boyle_btn.FlatAppearance.BorderSize = 0
        Me.boyle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.boyle_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boyle_btn.ForeColor = System.Drawing.Color.DodgerBlue
        Me.boyle_btn.Location = New System.Drawing.Point(0, 532)
        Me.boyle_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.boyle_btn.Name = "boyle_btn"
        Me.boyle_btn.Size = New System.Drawing.Size(222, 50)
        Me.boyle_btn.TabIndex = 16
        Me.boyle_btn.Text = "BOYLES CALCULATOR"
        Me.boyle_btn.UseVisualStyleBackColor = False
        '
        'unit_btn
        '
        Me.unit_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.unit_btn.FlatAppearance.BorderSize = 0
        Me.unit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.unit_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unit_btn.ForeColor = System.Drawing.Color.DodgerBlue
        Me.unit_btn.Location = New System.Drawing.Point(3, 425)
        Me.unit_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.unit_btn.Name = "unit_btn"
        Me.unit_btn.Size = New System.Drawing.Size(222, 50)
        Me.unit_btn.TabIndex = 13
        Me.unit_btn.Text = "UNIT CONVERTER"
        Me.unit_btn.UseVisualStyleBackColor = False
        '
        'HomePage
        '
        Me.HomePage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HomePage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.HomePage.BackColor = System.Drawing.SystemColors.Window
        Me.HomePage.BackgroundImage = CType(resources.GetObject("HomePage.BackgroundImage"), System.Drawing.Image)
        Me.HomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HomePage.Controls.Add(Me.Label1)
        Me.HomePage.Controls.Add(Me.Button1)
        Me.HomePage.Controls.Add(Me.Button8)
        Me.HomePage.Controls.Add(Me.Button14)
        Me.HomePage.Controls.Add(Me.Button22)
        Me.HomePage.Controls.Add(Me.Button34)
        Me.HomePage.Controls.Add(Me.Button35)
        Me.HomePage.ForeColor = System.Drawing.Color.Blue
        Me.HomePage.Location = New System.Drawing.Point(226, 45)
        Me.HomePage.Name = "HomePage"
        Me.HomePage.Size = New System.Drawing.Size(1196, 641)
        Me.HomePage.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightCyan
        Me.Label1.Location = New System.Drawing.Point(66, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1114, 193)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "AfooTECH MULTIFUNCTION                       SOLUTION"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Button1.Location = New System.Drawing.Point(510, 326)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(191, 71)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "UNIT CONVERTER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Button8.Location = New System.Drawing.Point(318, 244)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(191, 71)
        Me.Button8.TabIndex = 24
        Me.Button8.Text = "GP CALCULATOR"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Button14.Location = New System.Drawing.Point(703, 326)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(191, 71)
        Me.Button14.TabIndex = 20
        Me.Button14.Text = "BOYLE'S LAW"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button22
        '
        Me.Button22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button22.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button22.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button22.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Button22.Location = New System.Drawing.Point(703, 244)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(191, 71)
        Me.Button22.TabIndex = 23
        Me.Button22.Text = "LOAN APP"
        Me.Button22.UseVisualStyleBackColor = False
        '
        'Button34
        '
        Me.Button34.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button34.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button34.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button34.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Button34.Location = New System.Drawing.Point(318, 326)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(191, 71)
        Me.Button34.TabIndex = 21
        Me.Button34.Text = "SIMPLE CALCULATOR"
        Me.Button34.UseVisualStyleBackColor = False
        '
        'Button35
        '
        Me.Button35.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button35.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button35.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button35.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Button35.Location = New System.Drawing.Point(510, 244)
        Me.Button35.Name = "Button35"
        Me.Button35.Size = New System.Drawing.Size(191, 71)
        Me.Button35.TabIndex = 22
        Me.Button35.Text = "AGE CALCULATOR"
        Me.Button35.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(221, 213)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1434, 686)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.HomePage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Multifunction"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.HomePage.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents close As System.Windows.Forms.Button
    Friend WithEvents Minimize As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents HomePage As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents Button34 As System.Windows.Forms.Button
    Friend WithEvents Button35 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sc_btn As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents gp_btn As System.Windows.Forms.Button
    Friend WithEvents age_btn As System.Windows.Forms.Button
    Friend WithEvents loan_btn As System.Windows.Forms.Button
    Friend WithEvents boyle_btn As System.Windows.Forms.Button
    Friend WithEvents unit_btn As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
