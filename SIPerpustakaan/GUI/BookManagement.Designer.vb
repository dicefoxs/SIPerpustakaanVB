<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookManagement
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SiticonePanel1 = New ns1.SiticonePanel()
        Me.SiticoneCustomGradientPanel1 = New ns1.SiticoneCustomGradientPanel()
        Me.SiticoneDataGridView1 = New ns1.SiticoneDataGridView()
        Me.nomor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumBuku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiticoneDragControl1 = New ns1.SiticoneDragControl(Me.components)
        Me.SiticonePictureBox1 = New ns1.SiticonePictureBox()
        Me.SiticoneMaterialTextBox1 = New ns1.SiticoneMaterialTextBox()
        Me.SiticoneMaterialTextBox2 = New ns1.SiticoneMaterialTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SiticoneComboBox1 = New ns1.SiticoneComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SiticoneComboBox2 = New ns1.SiticoneComboBox()
        Me.SiticonePanel1.SuspendLayout()
        Me.SiticoneCustomGradientPanel1.SuspendLayout()
        CType(Me.SiticoneDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiticonePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.SiticonePanel1.Size = New System.Drawing.Size(1070, 30)
        Me.SiticonePanel1.TabIndex = 3
        '
        'SiticoneCustomGradientPanel1
        '
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label4)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.SiticoneComboBox2)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label3)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.SiticoneComboBox1)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label2)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label1)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.SiticoneMaterialTextBox2)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.SiticoneMaterialTextBox1)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.SiticoneDataGridView1)
        Me.SiticoneCustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SiticoneCustomGradientPanel1.Location = New System.Drawing.Point(0, 30)
        Me.SiticoneCustomGradientPanel1.Name = "SiticoneCustomGradientPanel1"
        Me.SiticoneCustomGradientPanel1.ShadowDecoration.Parent = Me.SiticoneCustomGradientPanel1
        Me.SiticoneCustomGradientPanel1.Size = New System.Drawing.Size(1070, 615)
        Me.SiticoneCustomGradientPanel1.TabIndex = 4
        '
        'SiticoneDataGridView1
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.SiticoneDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.SiticoneDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SiticoneDataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.SiticoneDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SiticoneDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.SiticoneDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SiticoneDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.SiticoneDataGridView1.ColumnHeadersHeight = 21
        Me.SiticoneDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nomor, Me.nama, Me.jumBuku, Me.kategori})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SiticoneDataGridView1.DefaultCellStyle = DataGridViewCellStyle9
        Me.SiticoneDataGridView1.EnableHeadersVisualStyles = False
        Me.SiticoneDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneDataGridView1.Location = New System.Drawing.Point(12, 282)
        Me.SiticoneDataGridView1.Name = "SiticoneDataGridView1"
        Me.SiticoneDataGridView1.RowHeadersVisible = False
        Me.SiticoneDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SiticoneDataGridView1.Size = New System.Drawing.Size(1046, 321)
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
        'nomor
        '
        Me.nomor.HeaderText = "No."
        Me.nomor.Name = "nomor"
        '
        'nama
        '
        Me.nama.HeaderText = "Nama"
        Me.nama.Name = "nama"
        '
        'jumBuku
        '
        Me.jumBuku.HeaderText = "Jumlah Buku"
        Me.jumBuku.Name = "jumBuku"
        '
        'kategori
        '
        Me.kategori.HeaderText = "KategoriBuku"
        Me.kategori.Name = "kategori"
        '
        'SiticoneDragControl1
        '
        Me.SiticoneDragControl1.TargetControl = Me.SiticonePanel1
        '
        'SiticonePictureBox1
        '
        Me.SiticonePictureBox1.BackColor = System.Drawing.Color.White
        Me.SiticonePictureBox1.Image = Global.SIPerpustakaan.My.Resources.Resources.icons8_close_window_48
        Me.SiticonePictureBox1.Location = New System.Drawing.Point(1042, 2)
        Me.SiticonePictureBox1.Name = "SiticonePictureBox1"
        Me.SiticonePictureBox1.ShadowDecoration.Parent = Me.SiticonePictureBox1
        Me.SiticonePictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.SiticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SiticonePictureBox1.TabIndex = 2
        Me.SiticonePictureBox1.TabStop = False
        '
        'SiticoneMaterialTextBox1
        '
        Me.SiticoneMaterialTextBox1.BorderColor = System.Drawing.Color.Black
        Me.SiticoneMaterialTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SiticoneMaterialTextBox1.DefaultText = ""
        Me.SiticoneMaterialTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SiticoneMaterialTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SiticoneMaterialTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SiticoneMaterialTextBox1.DisabledState.Parent = Me.SiticoneMaterialTextBox1
        Me.SiticoneMaterialTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SiticoneMaterialTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneMaterialTextBox1.FocusedState.Parent = Me.SiticoneMaterialTextBox1
        Me.SiticoneMaterialTextBox1.ForeColor = System.Drawing.Color.Black
        Me.SiticoneMaterialTextBox1.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneMaterialTextBox1.HoveredState.Parent = Me.SiticoneMaterialTextBox1
        Me.SiticoneMaterialTextBox1.Location = New System.Drawing.Point(12, 189)
        Me.SiticoneMaterialTextBox1.Name = "SiticoneMaterialTextBox1"
        Me.SiticoneMaterialTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SiticoneMaterialTextBox1.PlaceholderText = ""
        Me.SiticoneMaterialTextBox1.SelectedText = ""
        Me.SiticoneMaterialTextBox1.ShadowDecoration.Parent = Me.SiticoneMaterialTextBox1
        Me.SiticoneMaterialTextBox1.Size = New System.Drawing.Size(150, 36)
        Me.SiticoneMaterialTextBox1.TabIndex = 1
        '
        'SiticoneMaterialTextBox2
        '
        Me.SiticoneMaterialTextBox2.BorderColor = System.Drawing.Color.Black
        Me.SiticoneMaterialTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SiticoneMaterialTextBox2.DefaultText = ""
        Me.SiticoneMaterialTextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SiticoneMaterialTextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SiticoneMaterialTextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SiticoneMaterialTextBox2.DisabledState.Parent = Me.SiticoneMaterialTextBox2
        Me.SiticoneMaterialTextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SiticoneMaterialTextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneMaterialTextBox2.FocusedState.Parent = Me.SiticoneMaterialTextBox2
        Me.SiticoneMaterialTextBox2.ForeColor = System.Drawing.Color.Black
        Me.SiticoneMaterialTextBox2.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneMaterialTextBox2.HoveredState.Parent = Me.SiticoneMaterialTextBox2
        Me.SiticoneMaterialTextBox2.Location = New System.Drawing.Point(193, 189)
        Me.SiticoneMaterialTextBox2.Name = "SiticoneMaterialTextBox2"
        Me.SiticoneMaterialTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SiticoneMaterialTextBox2.PlaceholderText = ""
        Me.SiticoneMaterialTextBox2.SelectedText = ""
        Me.SiticoneMaterialTextBox2.ShadowDecoration.Parent = Me.SiticoneMaterialTextBox2
        Me.SiticoneMaterialTextBox2.Size = New System.Drawing.Size(150, 36)
        Me.SiticoneMaterialTextBox2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nama Buku"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(189, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Jumlah Buku"
        '
        'SiticoneComboBox1
        '
        Me.SiticoneComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SiticoneComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SiticoneComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.SiticoneComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.SiticoneComboBox1.FormattingEnabled = True
        Me.SiticoneComboBox1.HoveredState.Parent = Me.SiticoneComboBox1
        Me.SiticoneComboBox1.ItemHeight = 30
        Me.SiticoneComboBox1.ItemsAppearance.Parent = Me.SiticoneComboBox1
        Me.SiticoneComboBox1.Location = New System.Drawing.Point(397, 189)
        Me.SiticoneComboBox1.Name = "SiticoneComboBox1"
        Me.SiticoneComboBox1.ShadowDecoration.Parent = Me.SiticoneComboBox1
        Me.SiticoneComboBox1.Size = New System.Drawing.Size(165, 36)
        Me.SiticoneComboBox1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(393, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Kategori Buku"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(604, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Penerbit"
        '
        'SiticoneComboBox2
        '
        Me.SiticoneComboBox2.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SiticoneComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SiticoneComboBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.SiticoneComboBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.SiticoneComboBox2.FormattingEnabled = True
        Me.SiticoneComboBox2.HoveredState.Parent = Me.SiticoneComboBox2
        Me.SiticoneComboBox2.ItemHeight = 30
        Me.SiticoneComboBox2.ItemsAppearance.Parent = Me.SiticoneComboBox2
        Me.SiticoneComboBox2.Location = New System.Drawing.Point(608, 189)
        Me.SiticoneComboBox2.Name = "SiticoneComboBox2"
        Me.SiticoneComboBox2.ShadowDecoration.Parent = Me.SiticoneComboBox2
        Me.SiticoneComboBox2.Size = New System.Drawing.Size(165, 36)
        Me.SiticoneComboBox2.TabIndex = 8
        '
        'BookManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 645)
        Me.Controls.Add(Me.SiticoneCustomGradientPanel1)
        Me.Controls.Add(Me.SiticonePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BookManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BookManagement"
        Me.SiticonePanel1.ResumeLayout(False)
        Me.SiticoneCustomGradientPanel1.ResumeLayout(False)
        Me.SiticoneCustomGradientPanel1.PerformLayout()
        CType(Me.SiticoneDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiticonePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SiticonePictureBox1 As ns1.SiticonePictureBox
    Friend WithEvents SiticonePanel1 As ns1.SiticonePanel
    Friend WithEvents SiticoneCustomGradientPanel1 As ns1.SiticoneCustomGradientPanel
    Friend WithEvents SiticoneDataGridView1 As ns1.SiticoneDataGridView
    Friend WithEvents nomor As DataGridViewTextBoxColumn
    Friend WithEvents nama As DataGridViewTextBoxColumn
    Friend WithEvents jumBuku As DataGridViewTextBoxColumn
    Friend WithEvents kategori As DataGridViewTextBoxColumn
    Friend WithEvents SiticoneDragControl1 As ns1.SiticoneDragControl
    Friend WithEvents SiticoneMaterialTextBox1 As ns1.SiticoneMaterialTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SiticoneMaterialTextBox2 As ns1.SiticoneMaterialTextBox
    Friend WithEvents SiticoneComboBox1 As ns1.SiticoneComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SiticoneComboBox2 As ns1.SiticoneComboBox
End Class
