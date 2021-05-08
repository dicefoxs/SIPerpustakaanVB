<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PinjamBuku
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
        Me.SiticonePanel1 = New ns1.SiticonePanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SiticonePictureBox1 = New ns1.SiticonePictureBox()
        Me.SiticoneCustomGradientPanel1 = New ns1.SiticoneCustomGradientPanel()
        Me.stsPinjam = New ns1.SiticoneMaterialTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.IdPinjamBox = New ns1.SiticoneMaterialTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.NamaBuku = New ns1.SiticoneMaterialTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NamaAnggota = New ns1.SiticoneMaterialTextBox()
        Me.IdMemberBox = New ns1.SiticoneComboBox()
        Me.IdBukuBox = New ns1.SiticoneComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.addbook = New ns1.SiticoneButton()
        Me.SiticoneButton4 = New ns1.SiticoneButton()
        Me.DeleteBtn = New ns1.SiticoneButton()
        Me.EditBtn = New ns1.SiticoneButton()
        Me.SaveBtn = New ns1.SiticoneButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SiticoneDataGridView1 = New ns1.SiticoneDataGridView()
        Me.nomor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumBuku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.statusPinjam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiticoneDragControl1 = New ns1.SiticoneDragControl(Me.components)
        Me.SiticonePanel1.SuspendLayout()
        CType(Me.SiticonePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SiticoneCustomGradientPanel1.SuspendLayout()
        CType(Me.SiticoneDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Label6.Size = New System.Drawing.Size(102, 21)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Pinjam Buku"
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
        'SiticoneCustomGradientPanel1
        '
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.stsPinjam)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label8)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.IdPinjamBox)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label3)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.DateTimePicker1)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.NamaBuku)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label7)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.NamaAnggota)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.IdMemberBox)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.IdBukuBox)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label5)
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
        'stsPinjam
        '
        Me.stsPinjam.BorderColor = System.Drawing.Color.Black
        Me.stsPinjam.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.stsPinjam.DefaultText = ""
        Me.stsPinjam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.stsPinjam.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.stsPinjam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.stsPinjam.DisabledState.Parent = Me.stsPinjam
        Me.stsPinjam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.stsPinjam.Enabled = False
        Me.stsPinjam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stsPinjam.FocusedState.Parent = Me.stsPinjam
        Me.stsPinjam.ForeColor = System.Drawing.Color.Black
        Me.stsPinjam.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stsPinjam.HoveredState.Parent = Me.stsPinjam
        Me.stsPinjam.Location = New System.Drawing.Point(388, 69)
        Me.stsPinjam.Name = "stsPinjam"
        Me.stsPinjam.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.stsPinjam.PlaceholderText = ""
        Me.stsPinjam.SelectedText = ""
        Me.stsPinjam.ShadowDecoration.Parent = Me.stsPinjam
        Me.stsPinjam.Size = New System.Drawing.Size(150, 36)
        Me.stsPinjam.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(384, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 19)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Status Pinjam"
        '
        'IdPinjamBox
        '
        Me.IdPinjamBox.BorderColor = System.Drawing.Color.Black
        Me.IdPinjamBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IdPinjamBox.DefaultText = ""
        Me.IdPinjamBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.IdPinjamBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.IdPinjamBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IdPinjamBox.DisabledState.Parent = Me.IdPinjamBox
        Me.IdPinjamBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IdPinjamBox.Enabled = False
        Me.IdPinjamBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IdPinjamBox.FocusedState.Parent = Me.IdPinjamBox
        Me.IdPinjamBox.ForeColor = System.Drawing.Color.Black
        Me.IdPinjamBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IdPinjamBox.HoveredState.Parent = Me.IdPinjamBox
        Me.IdPinjamBox.Location = New System.Drawing.Point(565, 150)
        Me.IdPinjamBox.Name = "IdPinjamBox"
        Me.IdPinjamBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IdPinjamBox.PlaceholderText = ""
        Me.IdPinjamBox.SelectedText = ""
        Me.IdPinjamBox.ShadowDecoration.Parent = Me.IdPinjamBox
        Me.IdPinjamBox.Size = New System.Drawing.Size(150, 36)
        Me.IdPinjamBox.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(561, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "ID Pinjam"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(388, 165)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(154, 20)
        Me.DateTimePicker1.TabIndex = 25
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
        Me.NamaBuku.Location = New System.Drawing.Point(193, 69)
        Me.NamaBuku.Name = "NamaBuku"
        Me.NamaBuku.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NamaBuku.PlaceholderText = ""
        Me.NamaBuku.SelectedText = ""
        Me.NamaBuku.ShadowDecoration.Parent = Me.NamaBuku
        Me.NamaBuku.Size = New System.Drawing.Size(150, 36)
        Me.NamaBuku.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(189, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 19)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Nama Buku"
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
        'IdMemberBox
        '
        Me.IdMemberBox.BackColor = System.Drawing.Color.Transparent
        Me.IdMemberBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.IdMemberBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdMemberBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.IdMemberBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.IdMemberBox.FormattingEnabled = True
        Me.IdMemberBox.HoveredState.Parent = Me.IdMemberBox
        Me.IdMemberBox.ItemHeight = 30
        Me.IdMemberBox.ItemsAppearance.Parent = Me.IdMemberBox
        Me.IdMemberBox.Location = New System.Drawing.Point(16, 150)
        Me.IdMemberBox.Name = "IdMemberBox"
        Me.IdMemberBox.ShadowDecoration.Parent = Me.IdMemberBox
        Me.IdMemberBox.Size = New System.Drawing.Size(165, 36)
        Me.IdMemberBox.TabIndex = 21
        '
        'IdBukuBox
        '
        Me.IdBukuBox.BackColor = System.Drawing.Color.Transparent
        Me.IdBukuBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.IdBukuBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdBukuBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.IdBukuBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.IdBukuBox.FormattingEnabled = True
        Me.IdBukuBox.HoveredState.Parent = Me.IdBukuBox
        Me.IdBukuBox.ItemHeight = 30
        Me.IdBukuBox.ItemsAppearance.Parent = Me.IdBukuBox
        Me.IdBukuBox.Location = New System.Drawing.Point(16, 69)
        Me.IdBukuBox.Name = "IdBukuBox"
        Me.IdBukuBox.ShadowDecoration.Parent = Me.IdBukuBox
        Me.IdBukuBox.Size = New System.Drawing.Size(165, 36)
        Me.IdBukuBox.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 19)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "ID Buku"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(384, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tanggal Pinjam"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID Anggota"
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
        Me.SiticoneDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nomor, Me.nama, Me.jumBuku, Me.kategori, Me.statusPinjam})
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
        Me.nomor.HeaderText = "No."
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
        'statusPinjam
        '
        Me.statusPinjam.HeaderText = "Status Pinjam"
        Me.statusPinjam.Name = "statusPinjam"
        Me.statusPinjam.ReadOnly = True
        '
        'SiticoneDragControl1
        '
        Me.SiticoneDragControl1.TargetControl = Me.SiticonePanel1
        '
        'PinjamBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 645)
        Me.Controls.Add(Me.SiticoneCustomGradientPanel1)
        Me.Controls.Add(Me.SiticonePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PinjamBuku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PinjamBuku"
        Me.SiticonePanel1.ResumeLayout(False)
        Me.SiticonePanel1.PerformLayout()
        CType(Me.SiticonePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SiticoneCustomGradientPanel1.ResumeLayout(False)
        Me.SiticoneCustomGradientPanel1.PerformLayout()
        CType(Me.SiticoneDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SiticonePictureBox1 As ns1.SiticonePictureBox
    Friend WithEvents SiticonePanel1 As ns1.SiticonePanel
    Friend WithEvents SiticoneCustomGradientPanel1 As ns1.SiticoneCustomGradientPanel
    Friend WithEvents SiticoneDataGridView1 As ns1.SiticoneDataGridView
    Friend WithEvents SiticoneDragControl1 As ns1.SiticoneDragControl
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SaveBtn As ns1.SiticoneButton
    Friend WithEvents SiticoneButton4 As ns1.SiticoneButton
    Friend WithEvents DeleteBtn As ns1.SiticoneButton
    Friend WithEvents Label6 As Label
    Friend WithEvents addbook As ns1.SiticoneButton
    Friend WithEvents Label5 As Label
    Friend WithEvents NamaBuku As ns1.SiticoneMaterialTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents NamaAnggota As ns1.SiticoneMaterialTextBox
    Friend WithEvents IdMemberBox As ns1.SiticoneComboBox
    Friend WithEvents IdBukuBox As ns1.SiticoneComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents IdPinjamBox As ns1.SiticoneMaterialTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents EditBtn As ns1.SiticoneButton
    Friend WithEvents nomor As DataGridViewTextBoxColumn
    Friend WithEvents nama As DataGridViewTextBoxColumn
    Friend WithEvents jumBuku As DataGridViewTextBoxColumn
    Friend WithEvents kategori As DataGridViewTextBoxColumn
    Friend WithEvents stsPinjam As ns1.SiticoneMaterialTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents statusPinjam As DataGridViewTextBoxColumn
End Class
