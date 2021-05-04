<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.Panel1 = New ns1.SiticonePanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SiticonePictureBox1 = New ns1.SiticonePictureBox()
        Me.Panel2 = New ns1.SiticonePanel()
        Me.SubPanel1 = New ns1.SiticonePanel()
        Me.SiticoneCustomGradientPanel1 = New ns1.SiticoneCustomGradientPanel()
        Me.SiticoneCirclePictureBox1 = New ns1.SiticoneCirclePictureBox()
        Me.SiticoneLabel2 = New ns1.SiticoneLabel()
        Me.SiticoneLabel1 = New ns1.SiticoneLabel()
        Me.Password = New ns1.SiticoneTextBox()
        Me.Username = New ns1.SiticoneTextBox()
        Me.LoginButton = New ns1.SiticoneButton()
        Me.Panel1.SuspendLayout()
        CType(Me.SiticonePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SiticoneCustomGradientPanel1.SuspendLayout()
        CType(Me.SiticoneCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.SiticonePictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.ShadowDecoration.Parent = Me.Panel1
        Me.Panel1.Size = New System.Drawing.Size(470, 33)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Login Admin"
        '
        'SiticonePictureBox1
        '
        Me.SiticonePictureBox1.BackColor = System.Drawing.Color.White
        Me.SiticonePictureBox1.Image = Global.SIPerpustakaan.My.Resources.Resources.icons8_close_window_48
        Me.SiticonePictureBox1.Location = New System.Drawing.Point(442, 3)
        Me.SiticonePictureBox1.Name = "SiticonePictureBox1"
        Me.SiticonePictureBox1.ShadowDecoration.Parent = Me.SiticonePictureBox1
        Me.SiticonePictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.SiticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SiticonePictureBox1.TabIndex = 0
        Me.SiticonePictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Panel2.Controls.Add(Me.SubPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.ShadowDecoration.Parent = Me.Panel2
        Me.Panel2.Size = New System.Drawing.Size(470, 507)
        Me.Panel2.TabIndex = 1
        '
        'SubPanel1
        '
        Me.SubPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.SubPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubPanel1.Location = New System.Drawing.Point(0, 0)
        Me.SubPanel1.Name = "SubPanel1"
        Me.SubPanel1.ShadowDecoration.Parent = Me.SubPanel1
        Me.SubPanel1.Size = New System.Drawing.Size(470, 143)
        Me.SubPanel1.TabIndex = 0
        '
        'SiticoneCustomGradientPanel1
        '
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.SiticoneCirclePictureBox1)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.SiticoneLabel2)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.SiticoneLabel1)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Password)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Username)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.LoginButton)
        Me.SiticoneCustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.SiticoneCustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.SiticoneCustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.SiticoneCustomGradientPanel1.Location = New System.Drawing.Point(68, 61)
        Me.SiticoneCustomGradientPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.SiticoneCustomGradientPanel1.Name = "SiticoneCustomGradientPanel1"
        Me.SiticoneCustomGradientPanel1.Quality = 7
        Me.SiticoneCustomGradientPanel1.ShadowDecoration.Parent = Me.SiticoneCustomGradientPanel1
        Me.SiticoneCustomGradientPanel1.Size = New System.Drawing.Size(338, 451)
        Me.SiticoneCustomGradientPanel1.TabIndex = 0
        '
        'SiticoneCirclePictureBox1
        '
        Me.SiticoneCirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneCirclePictureBox1.Image = Global.SIPerpustakaan.My.Resources.Resources.user_6_White
        Me.SiticoneCirclePictureBox1.Location = New System.Drawing.Point(109, 15)
        Me.SiticoneCirclePictureBox1.Name = "SiticoneCirclePictureBox1"
        Me.SiticoneCirclePictureBox1.ShadowDecoration.Mode = ns5.ShadowMode.Circle
        Me.SiticoneCirclePictureBox1.ShadowDecoration.Parent = Me.SiticoneCirclePictureBox1
        Me.SiticoneCirclePictureBox1.Size = New System.Drawing.Size(120, 120)
        Me.SiticoneCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SiticoneCirclePictureBox1.TabIndex = 5
        Me.SiticoneCirclePictureBox1.TabStop = False
        '
        'SiticoneLabel2
        '
        Me.SiticoneLabel2.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneLabel2.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.SiticoneLabel2.ForeColor = System.Drawing.Color.White
        Me.SiticoneLabel2.Location = New System.Drawing.Point(120, 236)
        Me.SiticoneLabel2.Name = "SiticoneLabel2"
        Me.SiticoneLabel2.Size = New System.Drawing.Size(97, 26)
        Me.SiticoneLabel2.TabIndex = 4
        Me.SiticoneLabel2.Text = "Password"
        '
        'SiticoneLabel1
        '
        Me.SiticoneLabel1.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneLabel1.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.SiticoneLabel1.ForeColor = System.Drawing.Color.White
        Me.SiticoneLabel1.Location = New System.Drawing.Point(116, 161)
        Me.SiticoneLabel1.Name = "SiticoneLabel1"
        Me.SiticoneLabel1.Size = New System.Drawing.Size(106, 26)
        Me.SiticoneLabel1.TabIndex = 3
        Me.SiticoneLabel1.Text = "Username"
        '
        'Password
        '
        Me.Password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Password.DefaultText = ""
        Me.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password.DisabledState.Parent = Me.Password
        Me.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Password.FocusedState.Parent = Me.Password
        Me.Password.ForeColor = System.Drawing.Color.Black
        Me.Password.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Password.HoveredState.Parent = Me.Password
        Me.Password.Location = New System.Drawing.Point(69, 264)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.PlaceholderText = ""
        Me.Password.SelectedText = ""
        Me.Password.ShadowDecoration.Parent = Me.Password
        Me.Password.Size = New System.Drawing.Size(200, 21)
        Me.Password.TabIndex = 2
        Me.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Username
        '
        Me.Username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Username.DefaultText = ""
        Me.Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Username.DisabledState.Parent = Me.Username
        Me.Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Username.FocusedState.Parent = Me.Username
        Me.Username.ForeColor = System.Drawing.Color.Black
        Me.Username.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Username.HoveredState.Parent = Me.Username
        Me.Username.Location = New System.Drawing.Point(69, 193)
        Me.Username.Name = "Username"
        Me.Username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Username.PlaceholderText = ""
        Me.Username.SelectedText = ""
        Me.Username.ShadowDecoration.Parent = Me.Username
        Me.Username.Size = New System.Drawing.Size(200, 21)
        Me.Username.TabIndex = 1
        Me.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.LoginButton.CheckedState.Parent = Me.LoginButton
        Me.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginButton.CustomImages.Parent = Me.LoginButton
        Me.LoginButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.LoginButton.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LoginButton.ForeColor = System.Drawing.Color.White
        Me.LoginButton.HoveredState.Parent = Me.LoginButton
        Me.LoginButton.Location = New System.Drawing.Point(114, 347)
        Me.LoginButton.Margin = New System.Windows.Forms.Padding(2)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.ShadowDecoration.Parent = Me.LoginButton
        Me.LoginButton.Size = New System.Drawing.Size(104, 37)
        Me.LoginButton.TabIndex = 0
        Me.LoginButton.Text = "LOGIN"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(470, 540)
        Me.Controls.Add(Me.SiticoneCustomGradientPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.SiticonePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.SiticoneCustomGradientPanel1.ResumeLayout(False)
        Me.SiticoneCustomGradientPanel1.PerformLayout()
        CType(Me.SiticoneCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As ns1.SiticonePanel
    Friend WithEvents SiticonePictureBox1 As ns1.SiticonePictureBox
    Friend WithEvents Panel2 As ns1.SiticonePanel
    Friend WithEvents SubPanel1 As ns1.SiticonePanel
    Friend WithEvents SiticoneCustomGradientPanel1 As ns1.SiticoneCustomGradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents LoginButton As ns1.SiticoneButton
    Friend WithEvents Password As ns1.SiticoneTextBox
    Friend WithEvents Username As ns1.SiticoneTextBox
    Friend WithEvents SiticoneLabel1 As ns1.SiticoneLabel
    Friend WithEvents SiticoneLabel2 As ns1.SiticoneLabel
    Friend WithEvents SiticoneCirclePictureBox1 As ns1.SiticoneCirclePictureBox
End Class
