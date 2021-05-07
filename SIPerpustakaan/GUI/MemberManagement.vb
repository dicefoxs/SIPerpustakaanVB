Public Class MemberManagement
    Dim books As List(Of Buku) = Admin_Panel.getBuku
    Dim kats As List(Of Kategori) = Admin_Panel.getKategori
    Dim penerbits As List(Of Penerbit) = Admin_Panel.getPenerbit
    Dim members As List(Of Anggota) = Admin_Panel.getMembers


    Private Sub MemberManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        JenisKelamin.SelectedIndex = 0
        stsAnggota.SelectedIndex = 0
        SaveBtn.Enabled = False
        EditBtn.Enabled = False
        DeleteBtn.Enabled = False
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
        member.StatusAnggota = If(stsAnggota.SelectedIndex = 0, True, False)
        Return member
    End Function



    Private Sub DGVShow()
        For Each member As Anggota In members
            With member
                SiticoneDataGridView1.Rows.Add(.idAnggota.ToString(), .Nama.ToString(), .NIK.ToString(), .Alamat.ToString(), .JenisKel.ToString(), .tglLahir.ToString("dd/MM/yyyy"), If(.StatusAnggota, "Aktif", "Nonaktif"), If(.statusPinjam, "Pinjam", "Tidak Pinjam"))
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


    Private Sub Reset()
        IdBox.Text = ""
        namaAnggota.Text = ""
        nikAnggota.Text = ""
        alamatAnggota.Text = ""
        JenisKelamin.SelectedIndex = 0
        stsAnggota.SelectedIndex = 0
        DateTimePicker1.Value = Format(Date.Now)
        SaveBtn.Enabled = False
        EditBtn.Enabled = False
        DeleteBtn.Enabled = False
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        Admin_Panel.UpdateAnggota(GetMember)
        SiticoneDataGridView1.Rows.Clear()
        DGVShow()
        Reset()
    End Sub

    Private Sub newBtn_Click(sender As Object, e As EventArgs) Handles newBtn.Click
        SaveBtn.Enabled = True
        EditBtn.Enabled = False
        DeleteBtn.Enabled = False
        IdBox.Text = ""
        namaAnggota.Text = ""
        nikAnggota.Text = ""
        alamatAnggota.Text = ""
        JenisKelamin.SelectedIndex = 0
        stsAnggota.SelectedIndex = 0
        If Admin_Panel.getMembers().Count > 0 Then
            IdBox.Text = Admin_Panel.getMembers().Last.idAnggota + 1
        Else
            IdBox.Text = 1
        End If
        DateTimePicker1.Value = Format(Date.Now)
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Admin_Panel.AddAnggota(GetMember)
        SiticoneDataGridView1.Rows.Clear()
        DGVShow()
        Reset()
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Dim x As Object = MessageBox.Show("Apakah Anda Ingin Menghapus Data? Data yang terhapus akan hilang permanent!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If x = vbYes Then
            Admin_Panel.DeleteAnggota(GetMember)
            SiticoneDataGridView1.Rows.Clear()
            DGVShow()
            Reset()
        End If
    End Sub
End Class