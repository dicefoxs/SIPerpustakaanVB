<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(splash))
        Me.SiticoneProgressBar1 = New ns1.SiticoneProgressBar()
        Me.SiticonePictureBox1 = New ns1.SiticonePictureBox()
        Me.SiticoneLabel1 = New ns1.SiticoneLabel()
        Me.SiticoneLabel2 = New ns1.SiticoneLabel()
        Me.SiticoneLabel3 = New ns1.SiticoneLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.SiticonePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SiticoneProgressBar1
        '
        Me.SiticoneProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.SiticoneProgressBar1.Location = New System.Drawing.Point(12, 336)
        Me.SiticoneProgressBar1.Name = "SiticoneProgressBar1"
        Me.SiticoneProgressBar1.ProgressBrushMode = ns5.BrushMode.SolidTransition
        Me.SiticoneProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.SiticoneProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.SiticoneProgressBar1.ShadowDecoration.Parent = Me.SiticoneProgressBar1
        Me.SiticoneProgressBar1.Size = New System.Drawing.Size(341, 12)
        Me.SiticoneProgressBar1.TabIndex = 0
        Me.SiticoneProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'SiticonePictureBox1
        '
        Me.SiticonePictureBox1.Image = Global.SIPerpustakaan.My.Resources.Resources.c54323942a5b08df8411e33e25680ab3_pile_of_books_vector_by_vexels
        Me.SiticonePictureBox1.Location = New System.Drawing.Point(359, 56)
        Me.SiticonePictureBox1.Name = "SiticonePictureBox1"
        Me.SiticonePictureBox1.ShadowDecoration.Parent = Me.SiticonePictureBox1
        Me.SiticonePictureBox1.Size = New System.Drawing.Size(222, 292)
        Me.SiticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SiticonePictureBox1.TabIndex = 1
        Me.SiticonePictureBox1.TabStop = False
        '
        'SiticoneLabel1
        '
        Me.SiticoneLabel1.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneLabel1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneLabel1.Location = New System.Drawing.Point(12, 69)
        Me.SiticoneLabel1.Name = "SiticoneLabel1"
        Me.SiticoneLabel1.Size = New System.Drawing.Size(261, 42)
        Me.SiticoneLabel1.TabIndex = 2
        Me.SiticoneLabel1.Text = "SI-Perpustakaan"
        '
        'SiticoneLabel2
        '
        Me.SiticoneLabel2.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneLabel2.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneLabel2.Location = New System.Drawing.Point(12, 117)
        Me.SiticoneLabel2.Name = "SiticoneLabel2"
        Me.SiticoneLabel2.Size = New System.Drawing.Size(122, 17)
        Me.SiticoneLabel2.TabIndex = 3
        Me.SiticoneLabel2.Text = "By Achmad Ardivan"
        '
        'SiticoneLabel3
        '
        Me.SiticoneLabel3.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneLabel3.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneLabel3.Location = New System.Drawing.Point(156, 312)
        Me.SiticoneLabel3.Name = "SiticoneLabel3"
        Me.SiticoneLabel3.Size = New System.Drawing.Size(44, 18)
        Me.SiticoneLabel3.TabIndex = 4
        Me.SiticoneLabel3.Text = "Loading..."
        '
        'Timer1
        '
        '
        'splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 360)
        Me.Controls.Add(Me.SiticoneLabel3)
        Me.Controls.Add(Me.SiticoneLabel2)
        Me.Controls.Add(Me.SiticoneLabel1)
        Me.Controls.Add(Me.SiticonePictureBox1)
        Me.Controls.Add(Me.SiticoneProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "splash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "splash"
        CType(Me.SiticonePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SiticoneProgressBar1 As ns1.SiticoneProgressBar
    Friend WithEvents SiticonePictureBox1 As ns1.SiticonePictureBox
    Friend WithEvents SiticoneLabel1 As ns1.SiticoneLabel
    Friend WithEvents SiticoneLabel2 As ns1.SiticoneLabel
    Friend WithEvents SiticoneLabel3 As ns1.SiticoneLabel
    Friend WithEvents Timer1 As Timer
End Class
