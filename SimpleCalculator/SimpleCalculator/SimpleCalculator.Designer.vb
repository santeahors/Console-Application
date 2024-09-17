<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimpleCalculator
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
        Me.Calculate = New System.Windows.Forms.Button()
        Me.Sum_btn = New System.Windows.Forms.Button()
        Me.Minus_btn = New System.Windows.Forms.Button()
        Me.Multiply_btn = New System.Windows.Forms.Button()
        Me.Division_btn = New System.Windows.Forms.Button()
        Me.First_no_txt = New System.Windows.Forms.TextBox()
        Me.Second_no_txt = New System.Windows.Forms.TextBox()
        Me.result_txt = New System.Windows.Forms.TextBox()
        Me.Clear_btn = New System.Windows.Forms.Button()
        Me.errorLabel = New System.Windows.Forms.Label()
        Me.Showoperator_txt = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SIMPLE CALCULATOR"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Centaur", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First number"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Centaur", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Second Number"
        '
        'Calculate
        '
        Me.Calculate.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Calculate.FlatAppearance.BorderSize = 0
        Me.Calculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Calculate.Font = New System.Drawing.Font("Lucida Sans Typewriter", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Calculate.Location = New System.Drawing.Point(16, 251)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(157, 38)
        Me.Calculate.TabIndex = 4
        Me.Calculate.Text = "CALCULATE"
        Me.Calculate.UseVisualStyleBackColor = False
        '
        'Sum_btn
        '
        Me.Sum_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sum_btn.Location = New System.Drawing.Point(19, 127)
        Me.Sum_btn.Name = "Sum_btn"
        Me.Sum_btn.Size = New System.Drawing.Size(56, 33)
        Me.Sum_btn.TabIndex = 5
        Me.Sum_btn.Text = "+"
        Me.Sum_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Sum_btn.UseVisualStyleBackColor = True
        '
        'Minus_btn
        '
        Me.Minus_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minus_btn.Location = New System.Drawing.Point(19, 167)
        Me.Minus_btn.Name = "Minus_btn"
        Me.Minus_btn.Size = New System.Drawing.Size(56, 33)
        Me.Minus_btn.TabIndex = 6
        Me.Minus_btn.Text = "-"
        Me.Minus_btn.UseVisualStyleBackColor = True
        '
        'Multiply_btn
        '
        Me.Multiply_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Multiply_btn.Location = New System.Drawing.Point(87, 127)
        Me.Multiply_btn.Name = "Multiply_btn"
        Me.Multiply_btn.Size = New System.Drawing.Size(56, 33)
        Me.Multiply_btn.TabIndex = 7
        Me.Multiply_btn.Text = "*"
        Me.Multiply_btn.UseVisualStyleBackColor = True
        '
        'Division_btn
        '
        Me.Division_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Division_btn.Location = New System.Drawing.Point(87, 167)
        Me.Division_btn.Name = "Division_btn"
        Me.Division_btn.Size = New System.Drawing.Size(56, 33)
        Me.Division_btn.TabIndex = 8
        Me.Division_btn.Text = "/"
        Me.Division_btn.UseVisualStyleBackColor = True
        '
        'First_no_txt
        '
        Me.First_no_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_no_txt.Location = New System.Drawing.Point(192, 90)
        Me.First_no_txt.Multiline = True
        Me.First_no_txt.Name = "First_no_txt"
        Me.First_no_txt.Size = New System.Drawing.Size(129, 27)
        Me.First_no_txt.TabIndex = 9
        '
        'Second_no_txt
        '
        Me.Second_no_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Second_no_txt.Location = New System.Drawing.Point(192, 194)
        Me.Second_no_txt.Multiline = True
        Me.Second_no_txt.Name = "Second_no_txt"
        Me.Second_no_txt.Size = New System.Drawing.Size(129, 32)
        Me.Second_no_txt.TabIndex = 10
        '
        'result_txt
        '
        Me.result_txt.Enabled = False
        Me.result_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result_txt.Location = New System.Drawing.Point(187, 296)
        Me.result_txt.Multiline = True
        Me.result_txt.Name = "result_txt"
        Me.result_txt.Size = New System.Drawing.Size(141, 43)
        Me.result_txt.TabIndex = 11
        Me.result_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.result_txt.UseWaitCursor = True
        '
        'Clear_btn
        '
        Me.Clear_btn.BackColor = System.Drawing.Color.Maroon
        Me.Clear_btn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Clear_btn.FlatAppearance.BorderSize = 0
        Me.Clear_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Clear_btn.Location = New System.Drawing.Point(12, 296)
        Me.Clear_btn.Name = "Clear_btn"
        Me.Clear_btn.Size = New System.Drawing.Size(75, 36)
        Me.Clear_btn.TabIndex = 12
        Me.Clear_btn.Text = "CLEAR"
        Me.Clear_btn.UseVisualStyleBackColor = False
        '
        'errorLabel
        '
        Me.errorLabel.Location = New System.Drawing.Point(189, 249)
        Me.errorLabel.Name = "errorLabel"
        Me.errorLabel.Size = New System.Drawing.Size(148, 27)
        Me.errorLabel.TabIndex = 13
        '
        'Showoperator_txt
        '
        Me.Showoperator_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Showoperator_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Showoperator_txt.Location = New System.Drawing.Point(267, 142)
        Me.Showoperator_txt.Name = "Showoperator_txt"
        Me.Showoperator_txt.Size = New System.Drawing.Size(54, 34)
        Me.Showoperator_txt.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(163, 308)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 24)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "="
        '
        'SimpleCalculator
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 351)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Showoperator_txt)
        Me.Controls.Add(Me.errorLabel)
        Me.Controls.Add(Me.Clear_btn)
        Me.Controls.Add(Me.result_txt)
        Me.Controls.Add(Me.Second_no_txt)
        Me.Controls.Add(Me.First_no_txt)
        Me.Controls.Add(Me.Division_btn)
        Me.Controls.Add(Me.Multiply_btn)
        Me.Controls.Add(Me.Minus_btn)
        Me.Controls.Add(Me.Sum_btn)
        Me.Controls.Add(Me.Calculate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SimpleCalculator"
        Me.Text = "SimpleCalc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Calculate As System.Windows.Forms.Button
    Friend WithEvents Sum_btn As System.Windows.Forms.Button
    Friend WithEvents Minus_btn As System.Windows.Forms.Button
    Friend WithEvents Multiply_btn As System.Windows.Forms.Button
    Friend WithEvents Division_btn As System.Windows.Forms.Button
    Friend WithEvents First_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents Second_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents result_txt As System.Windows.Forms.TextBox
    Friend WithEvents Clear_btn As System.Windows.Forms.Button
    Friend WithEvents errorLabel As System.Windows.Forms.Label
    Friend WithEvents Showoperator_txt As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
