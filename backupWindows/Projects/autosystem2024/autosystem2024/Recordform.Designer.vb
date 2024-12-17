<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recordform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recordform))
        record_btn = New Button()
        home_btn = New Button()
        Panel2 = New Panel()
        Label1 = New Label()
        MASTER = New Label()
        close_btn = New Button()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        DataGridView1 = New DataGridView()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' record_btn
        ' 
        record_btn.AutoEllipsis = True
        record_btn.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        record_btn.Cursor = Cursors.AppStarting
        record_btn.FlatAppearance.BorderSize = 0
        record_btn.FlatAppearance.CheckedBackColor = Color.Red
        record_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        record_btn.FlatAppearance.MouseOverBackColor = Color.Red
        record_btn.FlatStyle = FlatStyle.Flat
        record_btn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        record_btn.ForeColor = Color.WhiteSmoke
        record_btn.ImeMode = ImeMode.NoControl
        record_btn.Location = New Point(110, 11)
        record_btn.Name = "record_btn"
        record_btn.Size = New Size(88, 32)
        record_btn.TabIndex = 3
        record_btn.Text = "RECORD"
        record_btn.UseCompatibleTextRendering = True
        record_btn.UseVisualStyleBackColor = True
        record_btn.UseWaitCursor = True
        ' 
        ' home_btn
        ' 
        home_btn.AutoEllipsis = True
        home_btn.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        home_btn.Cursor = Cursors.AppStarting
        home_btn.FlatAppearance.BorderSize = 0
        home_btn.FlatAppearance.CheckedBackColor = Color.Red
        home_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        home_btn.FlatAppearance.MouseOverBackColor = Color.Red
        home_btn.FlatStyle = FlatStyle.Flat
        home_btn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        home_btn.ForeColor = Color.WhiteSmoke
        home_btn.ImeMode = ImeMode.NoControl
        home_btn.Location = New Point(12, 11)
        home_btn.Name = "home_btn"
        home_btn.Size = New Size(75, 32)
        home_btn.TabIndex = 2
        home_btn.Text = "HOME"
        home_btn.UseCompatibleTextRendering = True
        home_btn.UseVisualStyleBackColor = True
        home_btn.UseWaitCursor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Control
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(MASTER)
        Panel2.Controls.Add(record_btn)
        Panel2.Controls.Add(home_btn)
        Panel2.Location = New Point(-1, 39)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(725, 53)
        Panel2.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Red
        Label1.ImeMode = ImeMode.NoControl
        Label1.Location = New Point(700, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(15, 17)
        Label1.TabIndex = 5
        ' 
        ' MASTER
        ' 
        MASTER.AutoSize = True
        MASTER.ImeMode = ImeMode.NoControl
        MASTER.Location = New Point(595, 22)
        MASTER.Name = "MASTER"
        MASTER.Size = New Size(100, 15)
        MASTER.TabIndex = 4
        MASTER.Text = "NO OF RECORDS:"
        ' 
        ' close_btn
        ' 
        close_btn.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        close_btn.BackColor = Color.Red
        close_btn.FlatAppearance.BorderSize = 0
        close_btn.FlatStyle = FlatStyle.Flat
        close_btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        close_btn.ForeColor = SystemColors.ControlLightLight
        close_btn.ImeMode = ImeMode.NoControl
        close_btn.Location = New Point(686, 1)
        close_btn.Name = "close_btn"
        close_btn.Padding = New Padding(4)
        close_btn.Size = New Size(37, 35)
        close_btn.TabIndex = 2
        close_btn.Text = "X"
        close_btn.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel1.Controls.Add(close_btn)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(2, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(723, 39)
        Panel1.TabIndex = 4
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.ImeMode = ImeMode.NoControl
        PictureBox1.Location = New Point(11, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Padding = New Padding(1)
        PictureBox1.Size = New Size(42, 35)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ControlLight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(-1, 88)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(726, 350)
        DataGridView1.TabIndex = 5
        ' 
        ' Recordform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(727, 450)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "Recordform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Recordform"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents record_btn As Button
    Friend WithEvents home_btn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MASTER As Label
    Friend WithEvents close_btn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
