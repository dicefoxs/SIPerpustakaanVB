Public Class MemberManagement
    Dim books As List(Of Buku) = Admin_Panel.getBuku
    Dim kats As List(Of Kategori) = Admin_Panel.getKategori
    Dim penerbits As List(Of Penerbit) = Admin_Panel.getPenerbit
    Dim members As List(Of Anggota) = Admin_Panel.getMembers


    Private Sub MemberManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        JenisKelamin.SelectedIndex = 0
        stsAnggota.SelectedIndex = 0
        DGVShow()
    End Sub

    Private Sub SiticonePictureBox1_Click(sender As Object, e As EventArgs) Handles SiticonePictureBox1.Click
        Admin_Panel.Show()
        Me.Dispose()
    End Sub

    Private Function GetMember() As Anggota
        Dim member As New Anggota
        member.idAnggota = Convert.ToInt32(IdBox.Text)
        member.Nama = namaAnggota.Text
        member.NIK = nikAnggota.Text
        member.Alamat = alamatAnggota.Text
        member.JenisKel = JenisKelamin.SelectedItem.ToString()
        member.tglLahir = DateTimePicker1.Value
        Return member
    End Function

    Private Sub DGVShow()
        For Each member As Anggota In members
            With member
                SiticoneDataGridView1.Rows.Add(.idAnggota.ToString(), .Nama.ToString(), .NIK.ToString(), .Alamat.ToString(), .JenisKel.ToString(), .tglLahir.ToString(), If(.StatusAnggota, "Aktif", "Nonaktif"), If(.statusPinjam, "Pinjam", "Tidak Pinjam"))
            End With
        Next
    End Sub

    Private Sub SiticoneDataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SiticoneDataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            SaveBtn.Enabled = False
            EditBtn.Enabled = True
            DeleteBtn.Enabled = True
            Dim row As DataGridViewRow = SiticoneDataGridView1.Rows(e.RowIndex)
            IdBox.Text = row.Cells(0).Value.ToString()
            namaAnggota.Text = row.Cells(1).Value.ToString()
            nikAnggota.Text = row.Cells(2).Value
            alamatAnggota.Text = row.Cells(3).Value.ToString
            For i = 0 To 1
                If row.Cells(4).Value.ToString().Equals("Laki-laki") Then
                    JenisKelamin.SelectedIndex = 0
                Else
                    JenisKelamin.SelectedIndex = 1
                End If
            Next
            DateTimePicker1.Value = row.Cells(5).Value.ToString()
            If row.Cells(6).Value.ToString.Equals("Aktif") Then
                stsAnggota.SelectedIndex = 0
            Else
                stsAnggota.SelectedIndex = 1
            End If
        End If
    End Sub

End Class