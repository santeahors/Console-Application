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
        Me.first_no_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.second_no_txt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.result_txt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'first_no_txt
        '
        Me.first_no_txt.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.first_no_txt.Location = New System.Drawing.Point(48, 156)
        Me.first_no_txt.Multiline = True
        Me.first_no_txt.Name = "first_no_txt"
        Me.first_no_txt.Size = New System.Drawing.Size(277, 35)
        Me.first_no_txt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ADDITION OF TWO NUMBERS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter the First Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(276, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Enter the Second Number"
        '
        'second_no_txt
        '
        Me.second_no_txt.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.second_no_txt.Location = New System.Drawing.Point(49, 282)
        Me.second_no_txt.Multiline = True
        Me.second_no_txt.Name = "second_no_txt"
        Me.second_no_txt.Size = New System.Drawing.Size(277, 35)
        Me.second_no_txt.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGray
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(49, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(277, 40)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "CALCULATE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'result_txt
        '
        Me.result_txt.Enabled = False
        Me.result_txt.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result_txt.Location = New System.Drawing.Point(49, 450)
        Me.result_txt.Multiline = True
        Me.result_txt.Name = "result_txt"
        Me.result_txt.Size = New System.Drawing.Size(277, 35)
        Me.result_txt.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 538)
        Me.Controls.Add(Me.result_txt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.second_no_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.first_no_txt)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents first_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents second_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents result_txt As System.Windows.Forms.TextBox

End Class
