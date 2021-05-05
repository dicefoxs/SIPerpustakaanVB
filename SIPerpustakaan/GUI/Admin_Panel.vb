Public Class Admin_Panel
    Dim _buku As New BukuController
    Dim buku As New Buku
    Private Sub SiticonePictureBox1_Click(sender As Object, e As EventArgs) Handles SiticonePictureBox1.Click
        Dim x As Object = MessageBox.Show("Ingin Keluar Aplikasi", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = vbYes Then
            Me.Dispose()
            splash.Dispose()
        End If
    End Sub

    Private Sub Admin_Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub SiticonePictureBox2_Click(sender As Object, e As EventArgs) Handles SiticonePictureBox2.Click
        BookManagement.Show()
        Me.Hide()
        For Each book As Buku In _buku.getBuku()
            With book
                BookManagement.SiticoneDataGridView1.Rows.Add(.idBuku.ToString(), .namaBuku.ToString(), .jumlahBuku.ToString(), .idKategori.ToString())
            End With
        Next
    End Sub
End Class