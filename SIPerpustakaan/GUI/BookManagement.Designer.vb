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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SiticonePanel1 = New ns1.SiticonePanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SiticonePictureBox1 = New ns1.SiticonePictureBox()
        Me.SiticoneCustomGradientPanel1 = New ns1.SiticoneCustomGradientPanel()
        Me.JmlBuku = New System.Windows.Forms.NumericUpDown()
        Me.SiticoneButton1 = New ns1.SiticoneButton()
        Me.TmbhKat = New ns1.SiticoneButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.addbook = New ns1.SiticoneButton()
        Me.IdBox = New ns1.SiticoneMaterialTextBox()
        Me.SiticoneButton4 = New ns1.SiticoneButton()
        Me.DeleteBtn = New ns1.SiticoneButton()
        Me.EditBtn = New ns1.SiticoneButton()
        Me.SaveBtn = New ns1.SiticoneButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.KatPenerbit = New ns1.SiticoneComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.KatBuku = New ns1.SiticoneComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NamaBuku = New ns1.SiticoneMaterialTextBox()
        Me.SiticoneDataGridView1 = New ns1.SiticoneDataGridView()
        Me.nomor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumBuku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiticoneDragControl1 = New ns1.SiticoneDragControl(Me.components)
        Me.SiticonePanel1.SuspendLayout()
        CType(Me.SiticonePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SiticoneCustomGradientPanel1.SuspendLayout()
        CType(Me.JmlBuku, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SiticonePanel1.Size = New System.Drawing.Size(1070, 30)
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
        Me.Label6.Size = New System.Drawing.Size(161, 21)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Book Management"
        '
        'SiticonePictureBox1
        '
        Me.SiticonePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.SiticonePictureBox1.Image = Global.SIPerpustakaan.My.Resources.Resources.icons8_close_window_48
        Me.SiticonePictureBox1.Location = New System.Drawing.Point(1042, 2)
        Me.SiticonePictureBox1.Name = "SiticonePictureBox1"
        Me.SiticonePictureBox1.ShadowDecoration.Parent = Me.SiticonePictureBox1
        Me.SiticonePictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.SiticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SiticonePictureBox1.TabIndex = 2
        Me.SiticonePictureBox1.TabStop = False
        '
        'SiticoneCustomGradientPanel1
        '
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.JmlBuku)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.SiticoneButton1)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.TmbhKat)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label5)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.addbook)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.IdBox)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.SiticoneButton4)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.DeleteBtn)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.EditBtn)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.SaveBtn)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label4)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.KatPenerbit)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label3)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.KatBuku)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label2)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label1)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.NamaBuku)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.SiticoneDataGridView1)
        Me.SiticoneCustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SiticoneCustomGradientPanel1.Location = New System.Drawing.Point(0, 30)
        Me.SiticoneCustomGradientPanel1.Name = "SiticoneCustomGradientPanel1"
        Me.SiticoneCustomGradientPanel1.ShadowDecoration.Parent = Me.SiticoneCustomGradientPanel1
        Me.SiticoneCustomGradientPanel1.Size = New System.Drawing.Size(1070, 615)
        Me.SiticoneCustomGradientPanel1.TabIndex = 4
        '
        'JmlBuku
        '
        Me.JmlBuku.Location = New System.Drawing.Point(193, 166)
        Me.JmlBuku.Name = "JmlBuku"
        Me.JmlBuku.Size = New System.Drawing.Size(150, 20)
        Me.JmlBuku.TabIndex = 19
        '
        'SiticoneButton1
        '
        Me.SiticoneButton1.CheckedState.Parent = Me.SiticoneButton1
        Me.SiticoneButton1.CustomImages.Parent = Me.SiticoneButton1
        Me.SiticoneButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SiticoneButton1.ForeColor = System.Drawing.Color.White
        Me.SiticoneButton1.HoveredState.Parent = Me.SiticoneButton1
        Me.SiticoneButton1.Location = New System.Drawing.Point(931, 98)
        Me.SiticoneButton1.Name = "SiticoneButton1"
        Me.SiticoneButton1.ShadowDecoration.Parent = Me.SiticoneButton1
        Me.SiticoneButton1.Size = New System.Drawing.Size(107, 45)
        Me.SiticoneButton1.TabIndex = 18
        Me.SiticoneButton1.Text = "Add Penerbit"
        '
        'TmbhKat
        '
        Me.TmbhKat.CheckedState.Parent = Me.TmbhKat
        Me.TmbhKat.CustomImages.Parent = Me.TmbhKat
        Me.TmbhKat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TmbhKat.ForeColor = System.Drawing.Color.White
        Me.TmbhKat.HoveredState.Parent = Me.TmbhKat
        Me.TmbhKat.Location = New System.Drawing.Point(931, 47)
        Me.TmbhKat.Name = "TmbhKat"
        Me.TmbhKat.ShadowDecoration.Parent = Me.TmbhKat
        Me.TmbhKat.Size = New System.Drawing.Size(107, 45)
        Me.TmbhKat.TabIndex = 17
        Me.TmbhKat.Text = "Add Kategori"
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
        Me.addbook.Location = New System.Drawing.Point(688, 220)
        Me.addbook.Name = "addbook"
        Me.addbook.ShadowDecoration.Parent = Me.addbook
        Me.addbook.Size = New System.Drawing.Size(107, 45)
        Me.addbook.TabIndex = 15
        Me.addbook.Text = "New"
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
        Me.IdBox.Location = New System.Drawing.Point(16, 69)
        Me.IdBox.Name = "IdBox"
        Me.IdBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IdBox.PlaceholderText = ""
        Me.IdBox.SelectedText = ""
        Me.IdBox.ShadowDecoration.Parent = Me.IdBox
        Me.IdBox.Size = New System.Drawing.Size(150, 36)
        Me.IdBox.TabIndex = 14
        '
        'SiticoneButton4
        '
        Me.SiticoneButton4.CheckedState.Parent = Me.SiticoneButton4
        Me.SiticoneButton4.CustomImages.Parent = Me.SiticoneButton4
        Me.SiticoneButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SiticoneButton4.ForeColor = System.Drawing.Color.White
        Me.SiticoneButton4.HoveredState.Parent = Me.SiticoneButton4
        Me.SiticoneButton4.Location = New System.Drawing.Point(575, 220)
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
        Me.DeleteBtn.Location = New System.Drawing.Point(462, 220)
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
        Me.EditBtn.Location = New System.Drawing.Point(349, 220)
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
        Me.SaveBtn.Location = New System.Drawing.Point(236, 220)
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
        Me.Label4.Location = New System.Drawing.Point(604, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Penerbit"
        '
        'KatPenerbit
        '
        Me.KatPenerbit.BackColor = System.Drawing.Color.Transparent
        Me.KatPenerbit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.KatPenerbit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.KatPenerbit.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.KatPenerbit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.KatPenerbit.FormattingEnabled = True
        Me.KatPenerbit.HoveredState.Parent = Me.KatPenerbit
        Me.KatPenerbit.ItemHeight = 30
        Me.KatPenerbit.ItemsAppearance.Parent = Me.KatPenerbit
        Me.KatPenerbit.Location = New System.Drawing.Point(608, 150)
        Me.KatPenerbit.Name = "KatPenerbit"
        Me.KatPenerbit.ShadowDecoration.Parent = Me.KatPenerbit
        Me.KatPenerbit.Size = New System.Drawing.Size(165, 36)
        Me.KatPenerbit.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(393, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Kategori Buku"
        '
        'KatBuku
        '
        Me.KatBuku.BackColor = System.Drawing.Color.Transparent
        Me.KatBuku.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.KatBuku.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.KatBuku.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.KatBuku.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.KatBuku.FormattingEnabled = True
        Me.KatBuku.HoveredState.Parent = Me.KatBuku
        Me.KatBuku.ItemHeight = 30
        Me.KatBuku.ItemsAppearance.Parent = Me.KatBuku
        Me.KatBuku.Location = New System.Drawing.Point(397, 150)
        Me.KatBuku.Name = "KatBuku"
        Me.KatBuku.ShadowDecoration.Parent = Me.KatBuku
        Me.KatBuku.Size = New System.Drawing.Size(165, 36)
        Me.KatBuku.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(189, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Jumlah Buku"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nama Buku"
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
        Me.NamaBuku.TabIndex = 1
        '
        'SiticoneDataGridView1
        '
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
        Me.SiticoneDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nomor, Me.nama, Me.jumBuku, Me.kategori})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SiticoneDataGridView1.DefaultCellStyle = DataGridViewCellStyle6
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
        Me.SiticonePanel1.PerformLayout()
        CType(Me.SiticonePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SiticoneCustomGradientPanel1.ResumeLayout(False)
        Me.SiticoneCustomGradientPanel1.PerformLayout()
        CType(Me.JmlBuku, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiticoneDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SiticonePictureBox1 As ns1.SiticonePictureBox
    Friend WithEvents SiticonePanel1 As ns1.SiticonePanel
    Friend WithEvents SiticoneCustomGradientPanel1 As ns1.SiticoneCustomGradientPanel
    Friend WithEvents SiticoneDataGridView1 As ns1.SiticoneDataGridView
    Friend WithEvents SiticoneDragControl1 As ns1.SiticoneDragControl
    Friend WithEvents NamaBuku As ns1.SiticoneMaterialTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents KatBuku As ns1.SiticoneComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents KatPenerbit As ns1.SiticoneComboBox
    Friend WithEvents SaveBtn As ns1.SiticoneButton
    Friend WithEvents SiticoneButton4 As ns1.SiticoneButton
    Friend WithEvents DeleteBtn As ns1.SiticoneButton
    Friend WithEvents EditBtn As ns1.SiticoneButton
    Friend WithEvents nomor As DataGridViewTextBoxColumn
    Friend WithEvents nama As DataGridViewTextBoxColumn
    Friend WithEvents jumBuku As DataGridViewTextBoxColumn
    Friend WithEvents kategori As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents IdBox As ns1.SiticoneMaterialTextBox
    Friend WithEvents addbook As ns1.SiticoneButton
    Friend WithEvents Label5 As Label
    Friend WithEvents SiticoneButton1 As ns1.SiticoneButton
    Friend WithEvents TmbhKat As ns1.SiticoneButton
    Friend WithEvents JmlBuku As NumericUpDown
End Class
