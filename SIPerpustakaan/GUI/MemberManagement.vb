Public Class MemberManagement
    Dim books As List(Of Buku) = Admin_Panel.getBuku
    Dim kats As List(Of Kategori) = Admin_Panel.getKategori
    Dim penerbits As List(Of Penerbit) = Admin_Panel.getPenerbit
    Dim members As List(Of Anggota) = Admin_Panel.getMembers

    Private Sub MemberManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVShow()
    End Sub

    Private Sub SiticonePictureBox1_Click(sender As Object, e As EventArgs) Handles SiticonePictureBox1.Click
        Admin_Panel.Show()
        Me.Dispose()
    End Sub

    Private Sub DGVShow()
        For Each member As Anggota In members
            With member
                SiticoneDataGridView1.Rows.Add(.idAnggota.ToString(), .Nama.ToString(), .NIK.ToString(), .Alamat.ToString, .JenisKel.ToString(), .tglLahir.ToString)
            End With
        Next
    End Sub

    Private Function getKategori(ByVal id As Integer) As Kategori
        For Each kate As Kategori In kats
            If kate.idKategori = id Then
                Return kate
            Else
                Return Nothing
            End If
        Next
    End Function
End Class