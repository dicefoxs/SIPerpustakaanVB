<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemberManagement
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SiticoneCustomGradientPanel1 = New ns1.SiticoneCustomGradientPanel()
        Me.SiticoneDataGridView1 = New ns1.SiticoneDataGridView()
        Me.SiticonePanel1 = New ns1.SiticonePanel()
        Me.SiticoneDragControl1 = New ns1.SiticoneDragControl(Me.components)
        Me.SiticonePictureBox1 = New ns1.SiticonePictureBox()
        Me.nomor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nik = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiticoneCustomGradientPanel1.SuspendLayout()
        CType(Me.SiticoneDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SiticonePanel1.SuspendLayout()
        CType(Me.SiticonePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SiticoneCustomGradientPanel1
        '
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.SiticoneDataGridView1)
        Me.SiticoneCustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SiticoneCustomGradientPanel1.Location = New System.Drawing.Point(0, 30)
        Me.SiticoneCustomGradientPanel1.Name = "SiticoneCustomGradientPanel1"
        Me.SiticoneCustomGradientPanel1.ShadowDecoration.Parent = Me.SiticoneCustomGradientPanel1
        Me.SiticoneCustomGradientPanel1.Size = New System.Drawing.Size(1072, 586)
        Me.SiticoneCustomGradientPanel1.TabIndex = 6
        '
        'SiticoneDataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.SiticoneDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.SiticoneDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SiticoneDataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.SiticoneDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SiticoneDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.SiticoneDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SiticoneDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.SiticoneDataGridView1.ColumnHeadersHeight = 21
        Me.SiticoneDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nomor, Me.nama, Me.nik, Me.alamat})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SiticoneDataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.SiticoneDataGridView1.EnableHeadersVisualStyles = False
        Me.SiticoneDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneDataGridView1.Location = New System.Drawing.Point(12, 282)
        Me.SiticoneDataGridView1.Name = "SiticoneDataGridView1"
        Me.SiticoneDataGridView1.RowHeadersVisible = False
        Me.SiticoneDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SiticoneDataGridView1.Size = New System.Drawing.Size(1046, 292)
        Me.SiticoneDataGridView1.TabIndex = 0
        Me.SiticoneDataGridView1.Theme = ns5.DataGridViewPresetThemes.[Default]
        Me.SiticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.SiticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.SiticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.SiticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.SiticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.SiticoneDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.SiticoneDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.SiticoneDataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.SiticoneDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.SiticoneDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.SiticoneDataGridView1.ThemeStyle.HeaderStyle.Height = 21
        Me.SiticoneDataGridView1.ThemeStyle.ReadOnly = False
        Me.SiticoneDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.SiticoneDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.SiticoneDataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.SiticoneDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.SiticoneDataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.SiticoneDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'SiticonePanel1
        '
        Me.SiticonePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.SiticonePanel1.Controls.Add(Me.SiticonePictureBox1)
        Me.SiticonePanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SiticonePanel1.ForeColor = System.Drawing.Color.Black
        Me.SiticonePanel1.Location = New System.Drawing.Point(0, 0)
        Me.SiticonePanel1.Name = "SiticonePanel1"
        Me.SiticonePanel1.ShadowDecoration.Parent = Me.SiticonePanel1
        Me.SiticonePanel1.Size = New System.Drawing.Size(1072, 30)
        Me.SiticonePanel1.TabIndex = 5
        '
        'SiticoneDragControl1
        '
        Me.SiticoneDragControl1.TargetControl = Me.SiticonePanel1
        '
        'SiticonePictureBox1
        '
        Me.SiticonePictureBox1.BackColor = System.Drawing.Color.White
        Me.SiticonePictureBox1.Image = Global.SIPerpustakaan.My.Resources.Resources.icons8_close_window_48
        Me.SiticonePictureBox1.Location = New System.Drawing.Point(1044, 2)
        Me.SiticonePictureBox1.Name = "SiticonePictureBox1"
        Me.SiticonePictureBox1.ShadowDecoration.Parent = Me.SiticonePictureBox1
        Me.SiticonePictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.SiticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SiticonePictureBox1.TabIndex = 2
        Me.SiticonePictureBox1.TabStop = False
        '
        'nomor
        '
        Me.nomor.HeaderText = "No."
        Me.nomor.Name = "nomor"
        '
        'nama
        '
        Me.nama.HeaderText = "Nama Anggota"
        Me.nama.Name = "nama"
        '
        'nik
        '
        Me.nik.HeaderText = "NIK"
        Me.nik.Name = "nik"
        '
        'alamat
        '
        Me.alamat.HeaderText = "Alamat"
        Me.alamat.Name = "alamat"
        '
        'MemberManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 616)
        Me.Controls.Add(Me.SiticoneCustomGradientPanel1)
        Me.Controls.Add(Me.SiticonePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MemberManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MemberManagement"
        Me.SiticoneCustomGradientPanel1.ResumeLayout(False)
        CType(Me.SiticoneDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SiticonePanel1.ResumeLayout(False)
        CType(Me.SiticonePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SiticoneCustomGradientPanel1 As ns1.SiticoneCustomGradientPanel
    Friend WithEvents SiticoneDataGridView1 As ns1.SiticoneDataGridView
    Friend WithEvents SiticonePictureBox1 As ns1.SiticonePictureBox
    Friend WithEvents SiticonePanel1 As ns1.SiticonePanel
    Friend WithEvents SiticoneDragControl1 As ns1.SiticoneDragControl
    Friend WithEvents nomor As DataGridViewTextBoxColumn
    Friend WithEvents nama As DataGridViewTextBoxColumn
    Friend WithEvents nik As DataGridViewTextBoxColumn
    Friend WithEvents alamat As DataGridViewTextBoxColumn
End Class
