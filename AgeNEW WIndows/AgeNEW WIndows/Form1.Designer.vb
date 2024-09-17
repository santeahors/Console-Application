<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgeCalculator
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dBirth_txt = New System.Windows.Forms.TextBox()
        Me.Calc_btn = New System.Windows.Forms.Button()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.yBirth_txt = New System.Windows.Forms.TextBox()
        Me.mBirth_txt = New System.Windows.Forms.TextBox()
        Me.Age_txt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(156, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 16)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "MONTH OF BIRTH"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(306, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 16)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "YEAR OF BIRTH"
        '
        'dBirth_txt
        '
        Me.dBirth_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dBirth_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dBirth_txt.Location = New System.Drawing.Point(25, 192)
        Me.dBirth_txt.Multiline = True
        Me.dBirth_txt.Name = "dBirth_txt"
        Me.dBirth_txt.Size = New System.Drawing.Size(97, 33)
        Me.dBirth_txt.TabIndex = 31
        Me.dBirth_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Calc_btn
        '
        Me.Calc_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calc_btn.Location = New System.Drawing.Point(25, 250)
        Me.Calc_btn.Name = "Calc_btn"
        Me.Calc_btn.Size = New System.Drawing.Size(268, 41)
        Me.Calc_btn.TabIndex = 30
        Me.Calc_btn.Text = "CALCULATE"
        Me.Calc_btn.UseVisualStyleBackColor = True
        '
        'clear_btn
        '
        Me.clear_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.clear_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.Location = New System.Drawing.Point(328, 250)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(96, 41)
        Me.clear_btn.TabIndex = 29
        Me.clear_btn.Text = "CLEAR"
        Me.clear_btn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 355)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 16)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "YOUR AGE"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(25, 106)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(404, 29)
        Me.DateTimePicker1.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "DAY OF BIRTH"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "TODAY'S DATE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 36)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "AGE CALCULATOR"
        '
        'yBirth_txt
        '
        Me.yBirth_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.yBirth_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yBirth_txt.Location = New System.Drawing.Point(328, 191)
        Me.yBirth_txt.Multiline = True
        Me.yBirth_txt.Name = "yBirth_txt"
        Me.yBirth_txt.Size = New System.Drawing.Size(96, 33)
        Me.yBirth_txt.TabIndex = 36
        Me.yBirth_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mBirth_txt
        '
        Me.mBirth_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mBirth_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mBirth_txt.Location = New System.Drawing.Point(172, 192)
        Me.mBirth_txt.Multiline = True
        Me.mBirth_txt.Name = "mBirth_txt"
        Me.mBirth_txt.Size = New System.Drawing.Size(99, 33)
        Me.mBirth_txt.TabIndex = 37
        Me.mBirth_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Age_txt
        '
        Me.Age_txt.BackColor = System.Drawing.Color.LightGray
        Me.Age_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Age_txt.Enabled = False
        Me.Age_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Age_txt.ForeColor = System.Drawing.Color.Black
        Me.Age_txt.Location = New System.Drawing.Point(25, 383)
        Me.Age_txt.Multiline = True
        Me.Age_txt.Name = "Age_txt"
        Me.Age_txt.Size = New System.Drawing.Size(399, 79)
        Me.Age_txt.TabIndex = 23
        '
        'AgeCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 474)
        Me.Controls.Add(Me.mBirth_txt)
        Me.Controls.Add(Me.yBirth_txt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dBirth_txt)
        Me.Controls.Add(Me.Age_txt)
        Me.Controls.Add(Me.Calc_btn)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AgeCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dBirth_txt As System.Windows.Forms.TextBox
    Friend WithEvents Calc_btn As System.Windows.Forms.Button
    Friend WithEvents clear_btn As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents yBirth_txt As System.Windows.Forms.TextBox
    Friend WithEvents mBirth_txt As System.Windows.Forms.TextBox
    Friend WithEvents Age_txt As System.Windows.Forms.TextBox

End Class
