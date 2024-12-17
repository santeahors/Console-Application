<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Division
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
        Me.first_no_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.second_n_txt = New System.Windows.Forms.TextBox()
        Me.result_txt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'first_no_txt
        '
        Me.first_no_txt.AutoCompleteCustomSource.AddRange(New String() {"1,2,3,4,5,6,7,8,9,0"})
        Me.first_no_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.first_no_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.first_no_txt.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.first_no_txt.Location = New System.Drawing.Point(28, 145)
        Me.first_no_txt.Multiline = True
        Me.first_no_txt.Name = "first_no_txt"
        Me.first_no_txt.Size = New System.Drawing.Size(181, 35)
        Me.first_no_txt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DIVISION OF  TWO NUMBERS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Input First Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Input Second Number"
        '
        'second_n_txt
        '
        Me.second_n_txt.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.second_n_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.second_n_txt.Location = New System.Drawing.Point(28, 255)
        Me.second_n_txt.Multiline = True
        Me.second_n_txt.Name = "second_n_txt"
        Me.second_n_txt.Size = New System.Drawing.Size(181, 35)
        Me.second_n_txt.TabIndex = 4
        '
        'result_txt
        '
        Me.result_txt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.result_txt.BackColor = System.Drawing.Color.LightGray
        Me.result_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.result_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result_txt.ForeColor = System.Drawing.Color.Black
        Me.result_txt.Location = New System.Drawing.Point(221, 333)
        Me.result_txt.Multiline = True
        Me.result_txt.Name = "result_txt"
        Me.result_txt.ReadOnly = True
        Me.result_txt.Size = New System.Drawing.Size(122, 37)
        Me.result_txt.TabIndex = 5
        Me.result_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(28, 333)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 37)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.Enabled = False
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.Location = New System.Drawing.Point(236, 195)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(129, 48)
        Me.lblError.TabIndex = 7
        Me.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Division
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 434)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.result_txt)
        Me.Controls.Add(Me.second_n_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.first_no_txt)
        Me.MinimizeBox = False
        Me.Name = "Division"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Division"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents first_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents second_n_txt As System.Windows.Forms.TextBox
    Friend WithEvents result_txt As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblError As System.Windows.Forms.Label

End Class
