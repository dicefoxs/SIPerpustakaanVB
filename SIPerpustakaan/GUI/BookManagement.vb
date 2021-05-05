Public Class BookManagement
    Dim books As List(Of Buku) = Admin_Panel.getBuku
    Dim kats As List(Of Kategori) = Admin_Panel.getKategori
    Private Sub SiticonePictureBox1_Click(sender As Object, e As EventArgs) Handles SiticonePictureBox1.Click
        Admin_Panel.Show()
        Me.Dispose()
    End Sub

    Private Sub BookManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVShow()
        ComboBxItems()
    End Sub

    Private Sub DGVShow()
        For Each book As Buku In books
            With book
                SiticoneDataGridView1.Rows.Add(.idBuku.ToString(), .namaBuku.ToString(), .jumlahBuku.ToString(), .idKategori.ToString())
            End With
        Next
    End Sub

    Private Sub ComboBxItems()
        SiticoneComboBox1.DataSource = kats
        SiticoneComboBox1.ValueMember = "idKategori"
        SiticoneComboBox1.DisplayMember = "namaKategori"
    End Sub
End Class