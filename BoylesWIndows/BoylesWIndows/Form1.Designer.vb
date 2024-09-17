<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BoylesCalc
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Display = New System.Windows.Forms.Label()
        Me.showlbl1 = New System.Windows.Forms.Label()
        Me.showlbl2 = New System.Windows.Forms.Label()
        Me.showLbl3 = New System.Windows.Forms.Label()
        Me.InputA_txt = New System.Windows.Forms.TextBox()
        Me.InputB_txt = New System.Windows.Forms.TextBox()
        Me.InputC_txt = New System.Windows.Forms.TextBox()
        Me.Resultt_txt = New System.Windows.Forms.TextBox()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.qslblp1 = New System.Windows.Forms.Label()
        Me.qslblP2 = New System.Windows.Forms.Label()
        Me.qslblV1 = New System.Windows.Forms.Label()
        Me.qslblV2 = New System.Windows.Forms.Label()
        Me.Calclbl = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BOYLES CALULATOR"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Button1.Location = New System.Drawing.Point(7, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Initial (P1)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Button2.Location = New System.Drawing.Point(107, 65)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 35)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Initial (V1)"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Button3.Location = New System.Drawing.Point(207, 65)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 35)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Final (P2)"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button4.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Button4.Location = New System.Drawing.Point(302, 65)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(84, 35)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Final (V2)"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Display
        '
        Me.Display.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Display.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Display.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Display.Location = New System.Drawing.Point(7, 132)
        Me.Display.Name = "Display"
        Me.Display.Size = New System.Drawing.Size(379, 50)
        Me.Display.TabIndex = 5
        Me.Display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'showlbl1
        '
        Me.showlbl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.showlbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showlbl1.Location = New System.Drawing.Point(7, 218)
        Me.showlbl1.Name = "showlbl1"
        Me.showlbl1.Size = New System.Drawing.Size(60, 26)
        Me.showlbl1.TabIndex = 6
        '
        'showlbl2
        '
        Me.showlbl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.showlbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showlbl2.Location = New System.Drawing.Point(7, 261)
        Me.showlbl2.Name = "showlbl2"
        Me.showlbl2.Size = New System.Drawing.Size(60, 26)
        Me.showlbl2.TabIndex = 7
        '
        'showLbl3
        '
        Me.showLbl3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.showLbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showLbl3.Location = New System.Drawing.Point(7, 300)
        Me.showLbl3.Name = "showLbl3"
        Me.showLbl3.Size = New System.Drawing.Size(60, 26)
        Me.showLbl3.TabIndex = 8
        '
        'InputA_txt
        '
        Me.InputA_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputA_txt.Location = New System.Drawing.Point(120, 217)
        Me.InputA_txt.Name = "InputA_txt"
        Me.InputA_txt.Size = New System.Drawing.Size(266, 26)
        Me.InputA_txt.TabIndex = 9
        '
        'InputB_txt
        '
        Me.InputB_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputB_txt.Location = New System.Drawing.Point(120, 260)
        Me.InputB_txt.Name = "InputB_txt"
        Me.InputB_txt.Size = New System.Drawing.Size(266, 26)
        Me.InputB_txt.TabIndex = 10
        '
        'InputC_txt
        '
        Me.InputC_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputC_txt.Location = New System.Drawing.Point(120, 300)
        Me.InputC_txt.Name = "InputC_txt"
        Me.InputC_txt.Size = New System.Drawing.Size(266, 26)
        Me.InputC_txt.TabIndex = 11
        '
        'Resultt_txt
        '
        Me.Resultt_txt.Enabled = False
        Me.Resultt_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resultt_txt.ForeColor = System.Drawing.Color.Black
        Me.Resultt_txt.Location = New System.Drawing.Point(153, 396)
        Me.Resultt_txt.Margin = New System.Windows.Forms.Padding(0)
        Me.Resultt_txt.Multiline = True
        Me.Resultt_txt.Name = "Resultt_txt"
        Me.Resultt_txt.Size = New System.Drawing.Size(233, 68)
        Me.Resultt_txt.TabIndex = 12
        Me.Resultt_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Resultt_txt.UseWaitCursor = True
        '
        'clear_btn
        '
        Me.clear_btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.clear_btn.BackColor = System.Drawing.Color.Maroon
        Me.clear_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.ForeColor = System.Drawing.Color.AliceBlue
        Me.clear_btn.Location = New System.Drawing.Point(4, 396)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(139, 68)
        Me.clear_btn.TabIndex = 14
        Me.clear_btn.Text = "CLEAR"
        Me.clear_btn.UseVisualStyleBackColor = False
        '
        'qslblp1
        '
        Me.qslblp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qslblp1.Location = New System.Drawing.Point(10, 100)
        Me.qslblp1.Name = "qslblp1"
        Me.qslblp1.Size = New System.Drawing.Size(45, 26)
        Me.qslblp1.TabIndex = 15
        Me.qslblp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'qslblP2
        '
        Me.qslblP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qslblP2.Location = New System.Drawing.Point(210, 100)
        Me.qslblP2.Name = "qslblP2"
        Me.qslblP2.Size = New System.Drawing.Size(45, 26)
        Me.qslblP2.TabIndex = 16
        Me.qslblP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'qslblV1
        '
        Me.qslblV1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qslblV1.Location = New System.Drawing.Point(109, 100)
        Me.qslblV1.Name = "qslblV1"
        Me.qslblV1.Size = New System.Drawing.Size(45, 26)
        Me.qslblV1.TabIndex = 17
        Me.qslblV1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'qslblV2
        '
        Me.qslblV2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qslblV2.Location = New System.Drawing.Point(304, 102)
        Me.qslblV2.Name = "qslblV2"
        Me.qslblV2.Size = New System.Drawing.Size(45, 26)
        Me.qslblV2.TabIndex = 18
        Me.qslblV2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Calclbl
        '
        Me.Calclbl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Calclbl.BackColor = System.Drawing.Color.LightGray
        Me.Calclbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calclbl.ForeColor = System.Drawing.Color.Black
        Me.Calclbl.Location = New System.Drawing.Point(4, 346)
        Me.Calclbl.Name = "Calclbl"
        Me.Calclbl.Size = New System.Drawing.Size(382, 47)
        Me.Calclbl.TabIndex = 20
        Me.Calclbl.Text = "CALCULATE"
        Me.Calclbl.UseVisualStyleBackColor = False
        '
        'BoylesCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(395, 470)
        Me.Controls.Add(Me.Calclbl)
        Me.Controls.Add(Me.qslblV2)
        Me.Controls.Add(Me.qslblV1)
        Me.Controls.Add(Me.qslblP2)
        Me.Controls.Add(Me.qslblp1)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.Resultt_txt)
        Me.Controls.Add(Me.InputC_txt)
        Me.Controls.Add(Me.InputB_txt)
        Me.Controls.Add(Me.InputA_txt)
        Me.Controls.Add(Me.showLbl3)
        Me.Controls.Add(Me.showlbl2)
        Me.Controls.Add(Me.showlbl1)
        Me.Controls.Add(Me.Display)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(10, Byte))
        Me.MaximizeBox = False
        Me.Name = "BoylesCalc"
        Me.Opacity = 0.8R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BoylesCalc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Display As System.Windows.Forms.Label
    Friend WithEvents showlbl1 As System.Windows.Forms.Label
    Friend WithEvents showlbl2 As System.Windows.Forms.Label
    Friend WithEvents showLbl3 As System.Windows.Forms.Label
    Friend WithEvents InputA_txt As System.Windows.Forms.TextBox
    Friend WithEvents InputB_txt As System.Windows.Forms.TextBox
    Friend WithEvents InputC_txt As System.Windows.Forms.TextBox
    Friend WithEvents Resultt_txt As System.Windows.Forms.TextBox
    Friend WithEvents clear_btn As System.Windows.Forms.Button
    Friend WithEvents qslblp1 As System.Windows.Forms.Label
    Friend WithEvents qslblP2 As System.Windows.Forms.Label
    Friend WithEvents qslblV1 As System.Windows.Forms.Label
    Friend WithEvents qslblV2 As System.Windows.Forms.Label
    Friend WithEvents Calclbl As System.Windows.Forms.Button

End Class
