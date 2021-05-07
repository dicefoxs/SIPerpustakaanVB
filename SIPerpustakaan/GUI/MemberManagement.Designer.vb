<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MemberManagement
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SiticoneCustomGradientPanel1 = New ns1.SiticoneCustomGradientPanel()
        Me.JenisKelamin = New ns1.SiticoneComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.IdBox = New ns1.SiticoneMaterialTextBox()
        Me.addbook = New ns1.SiticoneButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SiticoneButton4 = New ns1.SiticoneButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DeleteBtn = New ns1.SiticoneButton()
        Me.EditBtn = New ns1.SiticoneButton()
        Me.SaveBtn = New ns1.SiticoneButton()
        Me.alamatAnggota = New ns1.SiticoneMaterialTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nikAnggota = New ns1.SiticoneMaterialTextBox()
        Me.namaAnggota = New ns1.SiticoneMaterialTextBox()
        Me.SiticoneDataGridView1 = New ns1.SiticoneDataGridView()
        Me.SiticonePanel1 = New ns1.SiticonePanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SiticonePictureBox1 = New ns1.SiticonePictureBox()
        Me.SiticoneDragControl1 = New ns1.SiticoneDragControl(Me.components)
        Me.nomor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nik = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jeniskel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgllahir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.statuspjm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stsAnggota = New ns1.SiticoneComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SiticoneCustomGradientPanel1.SuspendLayout()
        CType(Me.SiticoneDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SiticonePanel1.SuspendLayout()
        CType(Me.SiticonePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SiticoneCustomGradientPanel1
        '
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.stsAnggota)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label8)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.JenisKelamin)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label7)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.IdBox)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.addbook)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.DateTimePicker1)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.SiticoneButton4)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label5)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.DeleteBtn)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.EditBtn)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.SaveBtn)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.alamatAnggota)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label4)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label3)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label2)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label1)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.nikAnggota)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.namaAnggota)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.SiticoneDataGridView1)
        Me.SiticoneCustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SiticoneCustomGradientPanel1.Location = New System.Drawing.Point(0, 30)
        Me.SiticoneCustomGradientPanel1.Name = "SiticoneCustomGradientPanel1"
        Me.SiticoneCustomGradientPanel1.ShadowDecoration.Parent = Me.SiticoneCustomGradientPanel1
        Me.SiticoneCustomGradientPanel1.Size = New System.Drawing.Size(1072, 586)
        Me.SiticoneCustomGradientPanel1.TabIndex = 6
        '
        'JenisKelamin
        '
        Me.JenisKelamin.BackColor = System.Drawing.Color.Transparent
        Me.JenisKelamin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.JenisKelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.JenisKelamin.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.JenisKelamin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.JenisKelamin.FormattingEnabled = True
        Me.JenisKelamin.HoveredState.Parent = Me.JenisKelamin
        Me.JenisKelamin.ItemHeight = 30
        Me.JenisKelamin.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.JenisKelamin.ItemsAppearance.Parent = Me.JenisKelamin
        Me.JenisKelamin.Location = New System.Drawing.Point(610, 149)
        Me.JenisKelamin.Name = "JenisKelamin"
        Me.JenisKelamin.ShadowDecoration.Parent = Me.JenisKelamin
        Me.JenisKelamin.Size = New System.Drawing.Size(159, 36)
        Me.JenisKelamin.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(5, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 19)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "ID Anggota"
        '
        'IdBox
        '
        Me.IdBox.BorderColor = System.Drawing.Color.Black
        Me.IdBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IdBox.DefaultText = ""
        Me.IdBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.IdBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.IdBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IdBox.DisabledState.Parent = Me.IdBox
        Me.IdBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IdBox.Enabled = False
        Me.IdBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IdBox.FocusedState.Parent = Me.IdBox
        Me.IdBox.ForeColor = System.Drawing.Color.Black
        Me.IdBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IdBox.HoveredState.Parent = Me.IdBox
        Me.IdBox.Location = New System.Drawing.Point(9, 70)
        Me.IdBox.Name = "IdBox"
        Me.IdBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IdBox.PlaceholderText = ""
        Me.IdBox.SelectedText = ""
        Me.IdBox.ShadowDecoration.Parent = Me.IdBox
        Me.IdBox.Size = New System.Drawing.Size(150, 36)
        Me.IdBox.TabIndex = 21
        '
        'addbook
        '
        Me.addbook.CheckedState.Parent = Me.addbook
        Me.addbook.CustomImages.Parent = Me.addbook
        Me.addbook.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.addbook.ForeColor = System.Drawing.Color.White
        Me.addbook.HoveredState.Parent = Me.addbook
        Me.addbook.Location = New System.Drawing.Point(701, 231)
        Me.addbook.Name = "addbook"
        Me.addbook.ShadowDecoration.Parent = Me.addbook
        Me.addbook.Size = New System.Drawing.Size(107, 45)
        Me.addbook.TabIndex = 20
        Me.addbook.Text = "New"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(789, 165)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(157, 20)
        Me.DateTimePicker1.TabIndex = 19
        '
        'SiticoneButton4
        '
        Me.SiticoneButton4.CheckedState.Parent = Me.SiticoneButton4
        Me.SiticoneButton4.CustomImages.Parent = Me.SiticoneButton4
        Me.SiticoneButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SiticoneButton4.ForeColor = System.Drawing.Color.White
        Me.SiticoneButton4.HoveredState.Parent = Me.SiticoneButton4
        Me.SiticoneButton4.Location = New System.Drawing.Point(588, 231)
        Me.SiticoneButton4.Name = "SiticoneButton4"
        Me.SiticoneButton4.ShadowDecoration.Parent = Me.SiticoneButton4
        Me.SiticoneButton4.Size = New System.Drawing.Size(107, 45)
        Me.SiticoneButton4.TabIndex = 19
        Me.SiticoneButton4.Text = "Reset"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(785, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 19)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Tanggal Lahir"
        '
        'DeleteBtn
        '
        Me.DeleteBtn.CheckedState.Parent = Me.DeleteBtn
        Me.DeleteBtn.CustomImages.Parent = Me.DeleteBtn
        Me.DeleteBtn.Enabled = False
        Me.DeleteBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DeleteBtn.ForeColor = System.Drawing.Color.White
        Me.DeleteBtn.HoveredState.Parent = Me.DeleteBtn
        Me.DeleteBtn.Location = New System.Drawing.Point(475, 231)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.ShadowDecoration.Parent = Me.DeleteBtn
        Me.DeleteBtn.Size = New System.Drawing.Size(107, 45)
        Me.DeleteBtn.TabIndex = 18
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
        Me.EditBtn.Location = New System.Drawing.Point(362, 231)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.ShadowDecoration.Parent = Me.EditBtn
        Me.EditBtn.Size = New System.Drawing.Size(107, 45)
        Me.EditBtn.TabIndex = 17
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
        Me.SaveBtn.Location = New System.Drawing.Point(249, 231)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.ShadowDecoration.Parent = Me.SaveBtn
        Me.SaveBtn.Size = New System.Drawing.Size(107, 45)
        Me.SaveBtn.TabIndex = 16
        Me.SaveBtn.Text = "Save"
        '
        'alamatAnggota
        '
        Me.alamatAnggota.BorderColor = System.Drawing.Color.Black
        Me.alamatAnggota.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.alamatAnggota.DefaultText = ""
        Me.alamatAnggota.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.alamatAnggota.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.alamatAnggota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.alamatAnggota.DisabledState.Parent = Me.alamatAnggota
        Me.alamatAnggota.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.alamatAnggota.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.alamatAnggota.FocusedState.Parent = Me.alamatAnggota
        Me.alamatAnggota.ForeColor = System.Drawing.Color.Black
        Me.alamatAnggota.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.alamatAnggota.HoveredState.Parent = Me.alamatAnggota
        Me.alamatAnggota.Location = New System.Drawing.Point(370, 149)
        Me.alamatAnggota.Name = "alamatAnggota"
        Me.alamatAnggota.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.alamatAnggota.PlaceholderText = ""
        Me.alamatAnggota.SelectedText = ""
        Me.alamatAnggota.ShadowDecoration.Parent = Me.alamatAnggota
        Me.alamatAnggota.Size = New System.Drawing.Size(212, 36)
        Me.alamatAnggota.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(606, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 19)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(366, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 19)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(186, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 19)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "NIK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(5, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nama Anggota"
        '
        'nikAnggota
        '
        Me.nikAnggota.BorderColor = System.Drawing.Color.Black
        Me.nikAnggota.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nikAnggota.DefaultText = ""
        Me.nikAnggota.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.nikAnggota.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.nikAnggota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.nikAnggota.DisabledState.Parent = Me.nikAnggota
        Me.nikAnggota.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.nikAnggota.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nikAnggota.FocusedState.Parent = Me.nikAnggota
        Me.nikAnggota.ForeColor = System.Drawing.Color.Black
        Me.nikAnggota.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nikAnggota.HoveredState.Parent = Me.nikAnggota
        Me.nikAnggota.Location = New System.Drawing.Point(190, 149)
        Me.nikAnggota.Name = "nikAnggota"
        Me.nikAnggota.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nikAnggota.PlaceholderText = ""
        Me.nikAnggota.SelectedText = ""
        Me.nikAnggota.ShadowDecoration.Parent = Me.nikAnggota
        Me.nikAnggota.Size = New System.Drawing.Size(150, 36)
        Me.nikAnggota.TabIndex = 11
        '
        'namaAnggota
        '
        Me.namaAnggota.BorderColor = System.Drawing.Color.Black
        Me.namaAnggota.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.namaAnggota.DefaultText = ""
        Me.namaAnggota.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.namaAnggota.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.namaAnggota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.namaAnggota.DisabledState.Parent = Me.namaAnggota
        Me.namaAnggota.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.namaAnggota.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.namaAnggota.FocusedState.Parent = Me.namaAnggota
        Me.namaAnggota.ForeColor = System.Drawing.Color.Black
        Me.namaAnggota.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.namaAnggota.HoveredState.Parent = Me.namaAnggota
        Me.namaAnggota.Location = New System.Drawing.Point(9, 149)
        Me.namaAnggota.Name = "namaAnggota"
        Me.namaAnggota.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.namaAnggota.PlaceholderText = ""
        Me.namaAnggota.SelectedText = ""
        Me.namaAnggota.ShadowDecoration.Parent = Me.namaAnggota
        Me.namaAnggota.Size = New System.Drawing.Size(150, 36)
        Me.namaAnggota.TabIndex = 10
        '
        'SiticoneDataGridView1
        '
        Me.SiticoneDataGridView1.AllowUserToAddRows = False
        Me.SiticoneDataGridView1.AllowUserToDeleteRows = False
        Me.SiticoneDataGridView1.AllowUserToResizeColumns = False
        Me.SiticoneDataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.SiticoneDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.SiticoneDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SiticoneDataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.SiticoneDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SiticoneDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.SiticoneDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SiticoneDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.SiticoneDataGridView1.ColumnHeadersHeight = 21
        Me.SiticoneDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nomor, Me.nama, Me.nik, Me.alamat, Me.jeniskel, Me.tgllahir, Me.status, Me.statuspjm})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SiticoneDataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.SiticoneDataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SiticoneDataGridView1.EnableHeadersVisualStyles = False
        Me.SiticoneDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneDataGridView1.Location = New System.Drawing.Point(0, 294)
        Me.SiticoneDataGridView1.Name = "SiticoneDataGridView1"
        Me.SiticoneDataGridView1.ReadOnly = True
        Me.SiticoneDataGridView1.RowHeadersVisible = False
        Me.SiticoneDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SiticoneDataGridView1.Size = New System.Drawing.Size(1072, 292)
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
        Me.SiticonePanel1.Size = New System.Drawing.Size(1072, 30)
        Me.SiticonePanel1.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(8, 5)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 21)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Member Management"
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
        'SiticoneDragControl1
        '
        Me.SiticoneDragControl1.TargetControl = Me.SiticonePanel1
        '
        'nomor
        '
        Me.nomor.FillWeight = 5.0!
        Me.nomor.HeaderText = "No."
        Me.nomor.Name = "nomor"
        Me.nomor.ReadOnly = True
        '
        'nama
        '
        Me.nama.FillWeight = 14.54857!
        Me.nama.HeaderText = "Nama Anggota"
        Me.nama.Name = "nama"
        Me.nama.ReadOnly = True
        '
        'nik
        '
        Me.nik.FillWeight = 14.54857!
        Me.nik.HeaderText = "NIK"
        Me.nik.Name = "nik"
        Me.nik.ReadOnly = True
        '
        'alamat
        '
        Me.alamat.FillWeight = 14.54857!
        Me.alamat.HeaderText = "Alamat"
        Me.alamat.Name = "alamat"
        Me.alamat.ReadOnly = True
        '
        'jeniskel
        '
        Me.jeniskel.FillWeight = 14.54857!
        Me.jeniskel.HeaderText = "Jenis Kelamin"
        Me.jeniskel.Name = "jeniskel"
        Me.jeniskel.ReadOnly = True
        '
        'tgllahir
        '
        Me.tgllahir.FillWeight = 14.54857!
        Me.tgllahir.HeaderText = "Tanggal Lahir"
        Me.tgllahir.Name = "tgllahir"
        Me.tgllahir.ReadOnly = True
        '
        'status
        '
        Me.status.FillWeight = 14.54857!
        Me.status.HeaderText = "status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'statuspjm
        '
        Me.statuspjm.FillWeight = 14.54857!
        Me.statuspjm.HeaderText = "Status Pinjam"
        Me.statuspjm.Name = "statuspjm"
        Me.statuspjm.ReadOnly = True
        '
        'stsAnggota
        '
        Me.stsAnggota.BackColor = System.Drawing.Color.Transparent
        Me.stsAnggota.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.stsAnggota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.stsAnggota.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.stsAnggota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.stsAnggota.FormattingEnabled = True
        Me.stsAnggota.HoveredState.Parent = Me.stsAnggota
        Me.stsAnggota.ItemHeight = 30
        Me.stsAnggota.Items.AddRange(New Object() {"Aktif", "Tidak Aktif"})
        Me.stsAnggota.ItemsAppearance.Parent = Me.stsAnggota
        Me.stsAnggota.Location = New System.Drawing.Point(190, 70)
        Me.stsAnggota.Name = "stsAnggota"
        Me.stsAnggota.ShadowDecoration.Parent = Me.stsAnggota
        Me.stsAnggota.Size = New System.Drawing.Size(159, 36)
        Me.stsAnggota.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(186, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 19)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Status Anggota"
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MemberManagement"
        Me.SiticoneCustomGradientPanel1.ResumeLayout(False)
        Me.SiticoneCustomGradientPanel1.PerformLayout()
        CType(Me.SiticoneDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SiticonePanel1.ResumeLayout(False)
        Me.SiticonePanel1.PerformLayout()
        CType(Me.SiticonePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SiticoneCustomGradientPanel1 As ns1.SiticoneCustomGradientPanel
    Friend WithEvents SiticoneDataGridView1 As ns1.SiticoneDataGridView
    Friend WithEvents SiticonePictureBox1 As ns1.SiticonePictureBox
    Friend WithEvents SiticonePanel1 As ns1.SiticonePanel
    Friend WithEvents SiticoneDragControl1 As ns1.SiticoneDragControl
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nikAnggota As ns1.SiticoneMaterialTextBox
    Friend WithEvents namaAnggota As ns1.SiticoneMaterialTextBox
    Friend WithEvents alamatAnggota As ns1.SiticoneMaterialTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents addbook As ns1.SiticoneButton
    Friend WithEvents SiticoneButton4 As ns1.SiticoneButton
    Friend WithEvents DeleteBtn As ns1.SiticoneButton
    Friend WithEvents EditBtn As ns1.SiticoneButton
    Friend WithEvents SaveBtn As ns1.SiticoneButton
    Friend WithEvents Label7 As Label
    Friend WithEvents IdBox As ns1.SiticoneMaterialTextBox
    Friend WithEvents JenisKelamin As ns1.SiticoneComboBox
    Friend WithEvents nomor As DataGridViewTextBoxColumn
    Friend WithEvents nama As DataGridViewTextBoxColumn
    Friend WithEvents nik As DataGridViewTextBoxColumn
    Friend WithEvents alamat As DataGridViewTextBoxColumn
    Friend WithEvents jeniskel As DataGridViewTextBoxColumn
    Friend WithEvents tgllahir As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents statuspjm As DataGridViewTextBoxColumn
    Friend WithEvents stsAnggota As ns1.SiticoneComboBox
    Friend WithEvents Label8 As Label
End Class
