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
        Me.SiticonePictureBox1 = New ns1.SiticonePictureBox()
        Me.SiticonePanel1 = New ns1.SiticonePanel()
        CType(Me.SiticonePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SiticonePanel1.SuspendLayout()
        Me.SuspendLayout()
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
        'BookManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 624)
        Me.Controls.Add(Me.SiticonePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BookManagement"
        Me.Text = "BookManagement"
        CType(Me.SiticonePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SiticonePanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SiticonePictureBox1 As ns1.SiticonePictureBox
    Friend WithEvents SiticonePanel1 As ns1.SiticonePanel
End Class
