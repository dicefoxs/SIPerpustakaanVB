Public Class MemberManagement


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
        member.StatusAnggota = stsAnggota.SelectedIndex
        member.NoTelp = NoTelp.Text
        Return member
    End Function



    Private Sub DGVShow()
        SiticoneDataGridView1.DataSource = Admin_Panel.getMemberss.Tables("member")
    End Sub

    Private Sub SiticoneDataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SiticoneDataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            SaveBtn.Enabled = False
            EditBtn.Enabled = True
            DeleteBtn.Enabled = True
            Dim row As DataGridViewRow = SiticoneDataGridView1.Rows(e.RowIndex)
            IdBox.Text = row.Cells(0).Value.ToString()
            namaAnggota.Text = row.Cells(1).Value.ToString()
            nikAnggota.Text = row.Cells(4).Value
            alamatAnggota.Text = row.Cells(2).Value.ToString
            For i = 0 To 1
                If row.Cells(5).Value.ToString().Equals("Laki-laki") Then
                    JenisKelamin.SelectedIndex = 0
                Else
                    JenisKelamin.SelectedIndex = 1
                End If
            Next
            DateTimePicker1.Value = row.Cells(6).Value.ToString()
            NoTelp.Text = row.Cells(3).Value.ToString()
            If row.Cells(7).Value = 1 Then
                stsAnggota.SelectedIndex = 1
            Else
                stsAnggota.SelectedIndex = 0
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
        NoTelp.Text = ""
        DateTimePicker1.Value = Format(Date.Now)
        SaveBtn.Enabled = False
        EditBtn.Enabled = False
        DeleteBtn.Enabled = False
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If namaAnggota.Text = "" Or nikAnggota.Text = "" Or alamatAnggota.Text = "" Then
            MessageBox.Show("Harap Isi Semua Field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Admin_Panel.UpdateAnggota(GetMember)
            DGVShow()
            Reset()
        End If
    End Sub

    Private Sub newBtn_Click(sender As Object, e As EventArgs) Handles newBtn.Click
        SaveBtn.Enabled = True
        EditBtn.Enabled = False
        DeleteBtn.Enabled = False
        IdBox.Text = ""
        namaAnggota.Text = ""
        nikAnggota.Text = ""
        alamatAnggota.Text = ""
        NoTelp.Text = ""
        JenisKelamin.SelectedIndex = 0
        stsAnggota.SelectedIndex = 0
        Try
            conn.Open()
            cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT AUTO_INCREMENT FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'db_perpus' AND TABLE_NAME = 'member'", conn)
            IdBox.Text = cmd.ExecuteScalar().ToString
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

        DateTimePicker1.Value = Format(Date.Now)
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If namaAnggota.Text = "" Or nikAnggota.Text = "" Or alamatAnggota.Text = "" Then
            MessageBox.Show("Harap Isi Semua Field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Admin_Panel.AddAnggota(GetMember)
            DGVShow()
            Reset()
        End If
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Dim x As Object = MessageBox.Show("Apakah Anda Ingin Menghapus Data? Data yang terhapus akan hilang permanent!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If x = vbYes Then
            Admin_Panel.DeleteAnggota(GetMember)
            DGVShow()
            Reset()
        End If
    End Sub
End Class