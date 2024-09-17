Private Sub first_no_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

End Sub

Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

End Sub
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Subtraction
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
        Me.first_no_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.second_no_txt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.result_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(374, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SUBTRACTION OF TWO NUMBERS"
        '
        'first_no_txt
        '
        Me.first_no_txt.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.first_no_txt.Font = New System.Drawing.Font("Lucida Fax", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.first_no_txt.Location = New System.Drawing.Point(267, 98)
        Me.first_no_txt.Multiline = True
        Me.first_no_txt.Name = "first_no_txt"
        Me.first_no_txt.Size = New System.Drawing.Size(146, 35)
        Me.first_no_txt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter the First Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(213, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Enter the Second Number"
        '
        'second_no_txt
        '
        Me.second_no_txt.Font = New System.Drawing.Font("Lucida Fax", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.second_no_txt.Location = New System.Drawing.Point(267, 194)
        Me.second_no_txt.Multiline = True
        Me.second_no_txt.Name = "second_no_txt"
        Me.second_no_txt.Size = New System.Drawing.Size(146, 35)
        Me.second_no_txt.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGray
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Lucida Fax", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(34, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(193, 50)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "CALCULATE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'result_txt
        '
        Me.result_txt.Enabled = False
        Me.result_txt.Font = New System.Drawing.Font("Lucida Fax", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result_txt.Location = New System.Drawing.Point(267, 308)
        Me.result_txt.Multiline = True
        Me.result_txt.Name = "result_txt"
        Me.result_txt.Size = New System.Drawing.Size(146, 38)
        Me.result_txt.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Fax", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(295, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Result"
        '
        'Subtraction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(438, 389)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.result_txt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.second_no_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.first_no_txt)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Subtraction"
        Me.Text = "Subtraction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents first_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents second_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents result_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public Class Subtraction
        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
            Dim first_no, second_no As Double
            Dim result As Double

            If Double.TryParse(first_no_txt.Text, first_no) AndAlso Double.TryParse(second_no_txt.Text, second_no) Then
                If second_no <> 0 Then
                    result = first_no / second_no
                    result_txt.Text = "  " & result.ToString("N2")
                    lblError.Text = ""
                Else
                    lblError.Text = "Division by zero is not allowed."
                    result_txt.Text = ""
                End If
            Else
                lblError.Text = "Please enter valid numbers."
                result_txt.Text = ""
            End If
        End Sub

        Private Sub first_no_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles first_no_txt.TextChanged
            Dim errorMsg As String = ""

            Select Case True
                Case Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> "."c)
                    e.Handled = True
                    errorMsg = "Invalid input. Please enter a valid number."

                Case (e.KeyChar = "."c) AndAlso (DirectCast(sender, TextBox).Text.Length = 0)
                    e.Handled = True
                    errorMsg = "Input cannot start with a decimal point."

                Case (e.KeyChar = "."c) AndAlso (DirectCast(sender, TextBox).Text.IndexOf("."c) > -1)
                    e.Handled = True
                    errorMsg = "Only one decimal point is allowed."
            End Select

            If errorMsg <> "" Then
                lblError.Text = errorMsg
            Else
                lblError.Text = ""
            End If
        End Sub

        Private Sub second_no_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles second_no_txt.TextChanged
            Dim errorMsg As String = ""

            Select Case True
                Case Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> "."c)
                    e.Handled = True
                    errorMsg = "Invalid input. Please enter a valid number."

                Case (e.KeyChar = "."c) AndAlso (DirectCast(sender, TextBox).Text.Length = 0)
                    e.Handled = True
                    errorMsg = "Input cannot start with a decimal point."

                Case (e.KeyChar = "."c) AndAlso (DirectCast(sender, TextBox).Text.IndexOf("."c) > -1)
                    e.Handled = True
                    errorMsg = "Only one decimal point is allowed."
            End Select

            If errorMsg <> "" Then
                lblError.Text = errorMsg
            Else
                lblError.Text = ""
            End If
        End Sub

        Private Sub lblError_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles lblError.Paint

            InitializeComponent()
            lblError = New Label()
            lblError.Name = "lblError"
            lblError.Text = ""
            lblError.ForeColor = Color.Red
            lblError.AutoSize = True
            Me.Controls.Add(lblError)
        End Sub
    End Class
