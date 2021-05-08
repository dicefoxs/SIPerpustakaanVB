<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PengembalianBuku
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SiticoneDragControl1 = New ns1.SiticoneDragControl(Me.components)
        Me.SiticonePanel1 = New ns1.SiticonePanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SiticonePictureBox1 = New ns1.SiticonePictureBox()
        Me.SiticoneDataGridView1 = New ns1.SiticoneDataGridView()
        Me.nomor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumBuku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tglKembali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.statusPinjam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SaveBtn = New ns1.SiticoneButton()
        Me.EditBtn = New ns1.SiticoneButton()
        Me.DeleteBtn = New ns1.SiticoneButton()
        Me.SiticoneButton4 = New ns1.SiticoneButton()
        Me.addbook = New ns1.SiticoneButton()
        Me.idPinjamBox = New ns1.SiticoneComboBox()
        Me.NamaAnggota = New ns1.SiticoneMaterialTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NamaBuku = New ns1.SiticoneMaterialTextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IdKembali = New ns1.SiticoneMaterialTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SiticoneComboBox1 = New ns1.SiticoneComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Denda = New ns1.SiticoneMaterialTextBox()
        Me.SiticoneCustomGradientPanel1 = New ns1.SiticoneCustomGradientPanel()
        Me.dendas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiticonePanel1.SuspendLayout()
        CType(Me.SiticonePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiticoneDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SiticoneCustomGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SiticoneDragControl1
        '
        Me.SiticoneDragControl1.TargetControl = Me.SiticonePanel1
        '
        'SiticonePanel1
        '
        Me.SiticonePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.SiticonePanel1.Controls.Add(Me.Label6)
        Me.SiticonePanel1.Controls.Add(Me.SiticonePictureBox1)
        Me.SiticonePanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SiticonePanel1.ForeColor = System.Drawing.Color.Black
        Me.SiticonePanel1.Location = New System.Drawing.Point(0, 0)
        Me.SiticonePanel1.Name = "SiticonePanel1"
        Me.SiticonePanel1.ShadowDecoration.Parent = Me.SiticonePanel1
        Me.SiticonePanel1.Size = New System.Drawing.Size(727, 30)
        Me.SiticonePanel1.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(2, 5)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 21)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Pengembalian Buku"
        '
        'SiticonePictureBox1
        '
        Me.SiticonePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.SiticonePictureBox1.Image = Global.SIPerpustakaan.My.Resources.Resources.icons8_close_window_48
        Me.SiticonePictureBox1.Location = New System.Drawing.Point(699, 2)
        Me.SiticonePictureBox1.Name = "SiticonePictureBox1"
        Me.SiticonePictureBox1.ShadowDecoration.Parent = Me.SiticonePictureBox1
        Me.SiticonePictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.SiticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SiticonePictureBox1.TabIndex = 2
        Me.SiticonePictureBox1.TabStop = False
        '
        'SiticoneDataGridView1
        '
        Me.SiticoneDataGridView1.AllowUserToAddRows = False
        Me.SiticoneDataGridView1.AllowUserToDeleteRows = False
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
        Me.SiticoneDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nomor, Me.nama, Me.jumBuku, Me.kategori, Me.tglKembali, Me.statusPinjam, Me.dendas})
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
        Me.SiticoneDataGridView1.ReadOnly = True
        Me.SiticoneDataGridView1.RowHeadersVisible = False
        Me.SiticoneDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SiticoneDataGridView1.Size = New System.Drawing.Size(703, 321)
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
        Me.SiticoneDataGridView1.ThemeStyle.ReadOnly = True
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
        Me.nomor.FillWeight = 30.0!
        Me.nomor.HeaderText = "ID"
        Me.nomor.Name = "nomor"
        Me.nomor.ReadOnly = True
        '
        'nama
        '
        Me.nama.HeaderText = "Nama Buku"
        Me.nama.Name = "nama"
        Me.nama.ReadOnly = True
        '
        'jumBuku
        '
        Me.jumBuku.HeaderText = "Peminjam"
        Me.jumBuku.Name = "jumBuku"
        Me.jumBuku.ReadOnly = True
        '
        'kategori
        '
        Me.kategori.HeaderText = "Tanggal Pinjam"
        Me.kategori.Name = "kategori"
        Me.kategori.ReadOnly = True
        '
        'tglKembali
        '
        Me.tglKembali.HeaderText = "tanggal Kembali"
        Me.tglKembali.Name = "tglKembali"
        Me.tglKembali.ReadOnly = True
        '
        'statusPinjam
        '
        Me.statusPinjam.HeaderText = "Status Pinjam"
        Me.statusPinjam.Name = "statusPinjam"
        Me.statusPinjam.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID Pinjam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(189, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nama Anggota"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(373, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tanggal Pinjam"
        '
        'SaveBtn
        '
        Me.SaveBtn.CheckedState.Parent = Me.SaveBtn
        Me.SaveBtn.CustomImages.Parent = Me.SaveBtn
        Me.SaveBtn.Enabled = False
        Me.SaveBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SaveBtn.ForeColor = System.Drawing.Color.White
        Me.SaveBtn.HoveredState.Parent = Me.SaveBtn
        Me.SaveBtn.Location = New System.Drawing.Point(85, 214)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.ShadowDecoration.Parent = Me.SaveBtn
        Me.SaveBtn.Size = New System.Drawing.Size(107, 45)
        Me.SaveBtn.TabIndex = 10
        Me.SaveBtn.Text = "Save"
        '
        'EditBtn
        '
        Me.EditBtn.CheckedState.Parent = Me.EditBtn
        Me.EditBtn.CustomImages.Parent = Me.EditBtn
        Me.EditBtn.Enabled = False
        Me.EditBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.EditBtn.ForeColor = System.Drawing.Color.White
        Me.EditBtn.HoveredState.Parent = Me.EditBtn
        Me.EditBtn.Location = New System.Drawing.Point(198, 214)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.ShadowDecoration.Parent = Me.EditBtn
        Me.EditBtn.Size = New System.Drawing.Size(107, 45)
        Me.EditBtn.TabIndex = 11
        Me.EditBtn.Text = "Edit"
        '
        'DeleteBtn
        '
        Me.DeleteBtn.CheckedState.Parent = Me.DeleteBtn
        Me.DeleteBtn.CustomImages.Parent = Me.DeleteBtn
        Me.DeleteBtn.Enabled = False
        Me.DeleteBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DeleteBtn.ForeColor = System.Drawing.Color.White
        Me.DeleteBtn.HoveredState.Parent = Me.DeleteBtn
        Me.DeleteBtn.Location = New System.Drawing.Point(311, 214)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.ShadowDecoration.Parent = Me.DeleteBtn
        Me.DeleteBtn.Size = New System.Drawing.Size(107, 45)
        Me.DeleteBtn.TabIndex = 12
        Me.DeleteBtn.Text = "Delete"
        '
        'SiticoneButton4
        '
        Me.SiticoneButton4.CheckedState.Parent = Me.SiticoneButton4
        Me.SiticoneButton4.CustomImages.Parent = Me.SiticoneButton4
        Me.SiticoneButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SiticoneButton4.ForeColor = System.Drawing.Color.White
        Me.SiticoneButton4.HoveredState.Parent = Me.SiticoneButton4
        Me.SiticoneButton4.Location = New System.Drawing.Point(424, 214)
        Me.SiticoneButton4.Name = "SiticoneButton4"
        Me.SiticoneButton4.ShadowDecoration.Parent = Me.SiticoneButton4
        Me.SiticoneButton4.Size = New System.Drawing.Size(107, 45)
        Me.SiticoneButton4.TabIndex = 13
        Me.SiticoneButton4.Text = "Reset"
        '
        'addbook
        '
        Me.addbook.CheckedState.Parent = Me.addbook
        Me.addbook.CustomImages.Parent = Me.addbook
        Me.addbook.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.addbook.ForeColor = System.Drawing.Color.White
        Me.addbook.HoveredState.Parent = Me.addbook
        Me.addbook.Location = New System.Drawing.Point(537, 214)
        Me.addbook.Name = "addbook"
        Me.addbook.ShadowDecoration.Parent = Me.addbook
        Me.addbook.Size = New System.Drawing.Size(107, 45)
        Me.addbook.TabIndex = 15
        Me.addbook.Text = "New"
        '
        'idPinjamBox
        '
        Me.idPinjamBox.BackColor = System.Drawing.Color.Transparent
        Me.idPinjamBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.idPinjamBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.idPinjamBox.Enabled = False
        Me.idPinjamBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.idPinjamBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.idPinjamBox.FormattingEnabled = True
        Me.idPinjamBox.HoveredState.Parent = Me.idPinjamBox
        Me.idPinjamBox.ItemHeight = 30
        Me.idPinjamBox.ItemsAppearance.Parent = Me.idPinjamBox
        Me.idPinjamBox.Location = New System.Drawing.Point(12, 69)
        Me.idPinjamBox.Name = "idPinjamBox"
        Me.idPinjamBox.ShadowDecoration.Parent = Me.idPinjamBox
        Me.idPinjamBox.Size = New System.Drawing.Size(165, 36)
        Me.idPinjamBox.TabIndex = 21
        '
        'NamaAnggota
        '
        Me.NamaAnggota.BorderColor = System.Drawing.Color.Black
        Me.NamaAnggota.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NamaAnggota.DefaultText = ""
        Me.NamaAnggota.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NamaAnggota.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NamaAnggota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NamaAnggota.DisabledState.Parent = Me.NamaAnggota
        Me.NamaAnggota.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NamaAnggota.Enabled = False
        Me.NamaAnggota.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NamaAnggota.FocusedState.Parent = Me.NamaAnggota
        Me.NamaAnggota.ForeColor = System.Drawing.Color.Black
        Me.NamaAnggota.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NamaAnggota.HoveredState.Parent = Me.NamaAnggota
        Me.NamaAnggota.Location = New System.Drawing.Point(193, 150)
        Me.NamaAnggota.Name = "NamaAnggota"
        Me.NamaAnggota.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NamaAnggota.PlaceholderText = ""
        Me.NamaAnggota.SelectedText = ""
        Me.NamaAnggota.ShadowDecoration.Parent = Me.NamaAnggota
        Me.NamaAnggota.Size = New System.Drawing.Size(150, 36)
        Me.NamaAnggota.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(8, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 19)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Nama Buku"
        '
        'NamaBuku
        '
        Me.NamaBuku.BorderColor = System.Drawing.Color.Black
        Me.NamaBuku.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NamaBuku.DefaultText = ""
        Me.NamaBuku.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NamaBuku.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NamaBuku.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NamaBuku.DisabledState.Parent = Me.NamaBuku
        Me.NamaBuku.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NamaBuku.Enabled = False
        Me.NamaBuku.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NamaBuku.FocusedState.Parent = Me.NamaBuku
        Me.NamaBuku.ForeColor = System.Drawing.Color.Black
        Me.NamaBuku.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NamaBuku.HoveredState.Parent = Me.NamaBuku
        Me.NamaBuku.Location = New System.Drawing.Point(12, 150)
        Me.NamaBuku.Name = "NamaBuku"
        Me.NamaBuku.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NamaBuku.PlaceholderText = ""
        Me.NamaBuku.SelectedText = ""
        Me.NamaBuku.ShadowDecoration.Parent = Me.NamaBuku
        Me.NamaBuku.Size = New System.Drawing.Size(150, 36)
        Me.NamaBuku.TabIndex = 24
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(377, 85)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(154, 20)
        Me.DateTimePicker1.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(549, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 19)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "ID Kembali"
        '
        'IdKembali
        '
        Me.IdKembali.BorderColor = System.Drawing.Color.Black
        Me.IdKembali.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IdKembali.DefaultText = ""
        Me.IdKembali.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.IdKembali.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.IdKembali.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IdKembali.DisabledState.Parent = Me.IdKembali
        Me.IdKembali.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IdKembali.Enabled = False
        Me.IdKembali.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IdKembali.FocusedState.Parent = Me.IdKembali
        Me.IdKembali.ForeColor = System.Drawing.Color.Black
        Me.IdKembali.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IdKembali.HoveredState.Parent = Me.IdKembali
        Me.IdKembali.Location = New System.Drawing.Point(553, 69)
        Me.IdKembali.Name = "IdKembali"
        Me.IdKembali.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IdKembali.PlaceholderText = ""
        Me.IdKembali.SelectedText = ""
        Me.IdKembali.ShadowDecoration.Parent = Me.IdKembali
        Me.IdKembali.Size = New System.Drawing.Size(150, 36)
        Me.IdKembali.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(189, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 19)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Status Pinjam"
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
        Me.SiticoneComboBox1.Location = New System.Drawing.Point(193, 69)
        Me.SiticoneComboBox1.Name = "SiticoneComboBox1"
        Me.SiticoneComboBox1.ShadowDecoration.Parent = Me.SiticoneComboBox1
        Me.SiticoneComboBox1.Size = New System.Drawing.Size(165, 36)
        Me.SiticoneComboBox1.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(373, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 19)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Tanggal Kembali"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Location = New System.Drawing.Point(377, 166)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(154, 20)
        Me.DateTimePicker2.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Enabled = False
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(549, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 19)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Denda"
        '
        'Denda
        '
        Me.Denda.BorderColor = System.Drawing.Color.Black
        Me.Denda.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Denda.DefaultText = ""
        Me.Denda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Denda.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Denda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Denda.DisabledState.Parent = Me.Denda
        Me.Denda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Denda.Enabled = False
        Me.Denda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Denda.FocusedState.Parent = Me.Denda
        Me.Denda.ForeColor = System.Drawing.Color.Black
        Me.Denda.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Denda.HoveredState.Parent = Me.Denda
        Me.Denda.Location = New System.Drawing.Point(553, 150)
        Me.Denda.Name = "Denda"
        Me.Denda.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Denda.PlaceholderText = ""
        Me.Denda.SelectedText = ""
        Me.Denda.ShadowDecoration.Parent = Me.Denda
        Me.Denda.Size = New System.Drawing.Size(150, 36)
        Me.Denda.TabIndex = 33
        '
        'SiticoneCustomGradientPanel1
        '
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Denda)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label9)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.DateTimePicker2)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label5)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.SiticoneComboBox1)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label8)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.IdKembali)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label3)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.DateTimePicker1)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.NamaBuku)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label7)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.NamaAnggota)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.idPinjamBox)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.addbook)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.SiticoneButton4)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.DeleteBtn)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.EditBtn)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.SaveBtn)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label4)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label2)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label1)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.SiticoneDataGridView1)
        Me.SiticoneCustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SiticoneCustomGradientPanel1.Location = New System.Drawing.Point(0, 30)
        Me.SiticoneCustomGradientPanel1.Name = "SiticoneCustomGradientPanel1"
        Me.SiticoneCustomGradientPanel1.ShadowDecoration.Parent = Me.SiticoneCustomGradientPanel1
        Me.SiticoneCustomGradientPanel1.Size = New System.Drawing.Size(727, 615)
        Me.SiticoneCustomGradientPanel1.TabIndex = 4
        '
        'dendas
        '
        Me.dendas.HeaderText = "Denda"
        Me.dendas.Name = "dendas"
        Me.dendas.ReadOnly = True
        '
        'PengembalianBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 645)
        Me.Controls.Add(Me.SiticoneCustomGradientPanel1)
        Me.Controls.Add(Me.SiticonePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PengembalianBuku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PinjamBuku"
        Me.SiticonePanel1.ResumeLayout(False)
        Me.SiticonePanel1.PerformLayout()
        CType(Me.SiticonePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiticoneDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SiticoneCustomGradientPanel1.ResumeLayout(False)
        Me.SiticoneCustomGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SiticoneDragControl1 As ns1.SiticoneDragControl
    Friend WithEvents SiticonePanel1 As ns1.SiticonePanel
    Friend WithEvents Label6 As Label
    Friend WithEvents SiticonePictureBox1 As ns1.SiticonePictureBox
    Friend WithEvents SiticoneDataGridView1 As ns1.SiticoneDataGridView
    Friend WithEvents nomor As DataGridViewTextBoxColumn
    Friend WithEvents nama As DataGridViewTextBoxColumn
    Friend WithEvents jumBuku As DataGridViewTextBoxColumn
    Friend WithEvents kategori As DataGridViewTextBoxColumn
    Friend WithEvents tglKembali As DataGridViewTextBoxColumn
    Friend WithEvents statusPinjam As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SaveBtn As ns1.SiticoneButton
    Friend WithEvents EditBtn As ns1.SiticoneButton
    Friend WithEvents DeleteBtn As ns1.SiticoneButton
    Friend WithEvents SiticoneButton4 As ns1.SiticoneButton
    Friend WithEvents addbook As ns1.SiticoneButton
    Friend WithEvents idPinjamBox As ns1.SiticoneComboBox
    Friend WithEvents NamaAnggota As ns1.SiticoneMaterialTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents NamaBuku As ns1.SiticoneMaterialTextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents IdKembali As ns1.SiticoneMaterialTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents SiticoneComboBox1 As ns1.SiticoneComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Denda As ns1.SiticoneMaterialTextBox
    Friend WithEvents SiticoneCustomGradientPanel1 As ns1.SiticoneCustomGradientPanel
    Friend WithEvents dendas As DataGridViewTextBoxColumn
End Class
