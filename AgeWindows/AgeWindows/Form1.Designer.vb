<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Age
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Next_txt = New System.Windows.Forms.TextBox()
        Me.Extra_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.Calc_btn = New System.Windows.Forms.Button()
        Me.Age_txt = New System.Windows.Forms.TextBox()
        Me.dBirth_txt = New System.Windows.Forms.TextBox()
        Me.yBirth_txt = New System.Windows.Forms.TextBox()
        Me.mBirth_txt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AGE CALCULATOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TODAY'S DATE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "DAY OF BIRTH"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(10, 109)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(404, 29)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Next_txt
        '
        Me.Next_txt.Enabled = False
        Me.Next_txt.Location = New System.Drawing.Point(12, 390)
        Me.Next_txt.Multiline = True
        Me.Next_txt.Name = "Next_txt"
        Me.Next_txt.Size = New System.Drawing.Size(399, 79)
        Me.Next_txt.TabIndex = 7
        '
        'Extra_txt
        '
        Me.Extra_txt.Enabled = False
        Me.Extra_txt.Location = New System.Drawing.Point(12, 502)
        Me.Extra_txt.Multiline = True
        Me.Extra_txt.Name = "Extra_txt"
        Me.Extra_txt.Size = New System.Drawing.Size(399, 124)
        Me.Extra_txt.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 483)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "EXTRAS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 371)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "NEXT BIRTHDAY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "YOUR AGE"
        '
        'clear_btn
        '
        Me.clear_btn.Location = New System.Drawing.Point(10, 220)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(121, 41)
        Me.clear_btn.TabIndex = 12
        Me.clear_btn.Text = "CLEAR"
        Me.clear_btn.UseVisualStyleBackColor = True
        '
        'Calc_btn
        '
        Me.Calc_btn.Location = New System.Drawing.Point(242, 220)
        Me.Calc_btn.Name = "Calc_btn"
        Me.Calc_btn.Size = New System.Drawing.Size(169, 41)
        Me.Calc_btn.TabIndex = 13
        Me.Calc_btn.Text = "CALCULATE"
        Me.Calc_btn.UseVisualStyleBackColor = True
        '
        'Age_txt
        '
        Me.Age_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Age_txt.Enabled = False
        Me.Age_txt.Location = New System.Drawing.Point(12, 283)
        Me.Age_txt.Multiline = True
        Me.Age_txt.Name = "Age_txt"
        Me.Age_txt.Size = New System.Drawing.Size(399, 79)
        Me.Age_txt.TabIndex = 6
        '
        'dBirth_txt
        '
        Me.dBirth_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dBirth_txt.Location = New System.Drawing.Point(12, 181)
        Me.dBirth_txt.Multiline = True
        Me.dBirth_txt.Name = "dBirth_txt"
        Me.dBirth_txt.Size = New System.Drawing.Size(84, 33)
        Me.dBirth_txt.TabIndex = 14
        '
        'yBirth_txt
        '
        Me.yBirth_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.yBirth_txt.Enabled = False
        Me.yBirth_txt.Location = New System.Drawing.Point(327, 181)
        Me.yBirth_txt.Multiline = True
        Me.yBirth_txt.Name = "yBirth_txt"
        Me.yBirth_txt.Size = New System.Drawing.Size(84, 33)
        Me.yBirth_txt.TabIndex = 15
        '
        'mBirth_txt
        '
        Me.mBirth_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mBirth_txt.Enabled = False
        Me.mBirth_txt.Location = New System.Drawing.Point(161, 181)
        Me.mBirth_txt.Multiline = True
        Me.mBirth_txt.Name = "mBirth_txt"
        Me.mBirth_txt.Size = New System.Drawing.Size(84, 33)
        Me.mBirth_txt.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(291, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "YEAR OF BIRTH"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(141, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "MONTH OF BIRTH"
        '
        'Age
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 635)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.mBirth_txt)
        Me.Controls.Add(Me.yBirth_txt)
        Me.Controls.Add(Me.dBirth_txt)
        Me.Controls.Add(Me.Age_txt)
        Me.Controls.Add(Me.Calc_btn)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Extra_txt)
        Me.Controls.Add(Me.Next_txt)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Age"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgeCAlc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Next_txt As System.Windows.Forms.TextBox
    Friend WithEvents Extra_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents clear_btn As System.Windows.Forms.Button
    Friend WithEvents Calc_btn As System.Windows.Forms.Button
    Friend WithEvents Age_txt As System.Windows.Forms.TextBox
    Friend WithEvents dBirth_txt As System.Windows.Forms.TextBox
    Friend WithEvents yBirth_txt As System.Windows.Forms.TextBox
    Friend WithEvents mBirth_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
