Public Class Admin_Panel
    Dim _buku As New BukuController
    Private Sub SiticonePictureBox1_Click(sender As Object, e As EventArgs)
        Dim x As Object = MessageBox.Show("Ingin Keluar Aplikasi", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = vbYes Then
            Me.Dispose()
            splash.Dispose()
        End If
    End Sub

    Private Sub Admin_Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub SiticonePictureBox2_Click(sender As Object, e As EventArgs) Handles SiticonePictureBox2.Click
        BookManagement.setBook(_buku.getBuku)
    End Sub
End Class