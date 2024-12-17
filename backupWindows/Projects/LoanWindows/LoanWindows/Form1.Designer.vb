<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loan
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LoanAmount_txt = New System.Windows.Forms.TextBox()
        Me.LoanDuration_txt = New System.Windows.Forms.TextBox()
        Me.TotalAmount_txt = New System.Windows.Forms.TextBox()
        Me.Payments_txt = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOAN APPLICATION"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 12.22!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 40)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "LOAN AMOUNT"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 12.22!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(477, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 40)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "LOAN DURATION"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 12.22!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-12, 455)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 40)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TOTAL AMOUNT"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(258, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 41)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "CALCULATE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LoanAmount_txt
        '
        Me.LoanAmount_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoanAmount_txt.Location = New System.Drawing.Point(47, 131)
        Me.LoanAmount_txt.Multiline = True
        Me.LoanAmount_txt.Name = "LoanAmount_txt"
        Me.LoanAmount_txt.Size = New System.Drawing.Size(136, 34)
        Me.LoanAmount_txt.TabIndex = 5
        Me.LoanAmount_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LoanDuration_txt
        '
        Me.LoanDuration_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LoanDuration_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoanDuration_txt.Location = New System.Drawing.Point(494, 131)
        Me.LoanDuration_txt.Multiline = True
        Me.LoanDuration_txt.Name = "LoanDuration_txt"
        Me.LoanDuration_txt.Size = New System.Drawing.Size(148, 34)
        Me.LoanDuration_txt.TabIndex = 6
        Me.LoanDuration_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TotalAmount_txt
        '
        Me.TotalAmount_txt.Enabled = False
        Me.TotalAmount_txt.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmount_txt.ForeColor = System.Drawing.Color.Black
        Me.TotalAmount_txt.HideSelection = False
        Me.TotalAmount_txt.Location = New System.Drawing.Point(12, 485)
        Me.TotalAmount_txt.Multiline = True
        Me.TotalAmount_txt.Name = "TotalAmount_txt"
        Me.TotalAmount_txt.Size = New System.Drawing.Size(171, 61)
        Me.TotalAmount_txt.TabIndex = 7
        Me.TotalAmount_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Payments_txt
        '
        Me.Payments_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Payments_txt.Enabled = False
        Me.Payments_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Payments_txt.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Payments_txt.Location = New System.Drawing.Point(12, 242)
        Me.Payments_txt.Multiline = True
        Me.Payments_txt.Name = "Payments_txt"
        Me.Payments_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Payments_txt.Size = New System.Drawing.Size(630, 209)
        Me.Payments_txt.TabIndex = 8
        Me.Payments_txt.UseWaitCursor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkRed
        Me.Button2.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Button2.Location = New System.Drawing.Point(542, 485)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 61)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Loan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 558)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Payments_txt)
        Me.Controls.Add(Me.TotalAmount_txt)
        Me.Controls.Add(Me.LoanDuration_txt)
        Me.Controls.Add(Me.LoanAmount_txt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Loan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LoanAmount_txt As System.Windows.Forms.TextBox
    Friend WithEvents LoanDuration_txt As System.Windows.Forms.TextBox
    Friend WithEvents TotalAmount_txt As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Public WithEvents Payments_txt As System.Windows.Forms.TextBox

End Class
