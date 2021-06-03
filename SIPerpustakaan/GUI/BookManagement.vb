Public Class BookManagement

    Private Sub SiticonePictureBox1_Click(sender As Object, e As EventArgs) Handles SiticonePictureBox1.Click
        Admin_Panel.Show()
        Me.Dispose()
    End Sub

    Private Sub BookManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVShow()
        ComboBxItems()
    End Sub

    Private Sub DGVShow()
        SiticoneDataGridView1.DataSource = Admin_Panel.getBooks.Tables("buku")
    End Sub

    Private Function GetBuku() As Buku
        Dim buku As New Buku
        buku.idBuku = Convert.ToInt32(IdBox.Text)
        buku.jumlahBuku = JmlBuku.Value
        buku.idKategori = CInt(KatBuku.SelectedValue)
        buku.idPenerbit = CInt(KatPenerbit.SelectedValue)
        buku.idPenulis = CInt(PenulisBx.SelectedValue)
        buku.namaBuku = NamaBuku.Text
        Return buku
    End Function

    Private Sub Reset()
        IdBox.Text = ""
        NamaBuku.Text = ""
        JmlBuku.Value = 0
        SaveBtn.Enabled = False
        EditBtn.Enabled = False
        DeleteBtn.Enabled = False
    End Sub

    Private Sub ComboBxItems()
        Try
            conn.Open()
            da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * From kategori WHERE status = 'Aktif'", conn)
            ds = New DataSet
            da.Fill(ds, "kategori")
            KatBuku.DataSource = ds.Tables("kategori")
            KatBuku.DisplayMember = "nama_kategori"
            KatBuku.ValueMember = "id_kategori"
            da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * From penerbit", conn)
            ds = New DataSet
            da.Fill(ds, "penerbit")
            KatPenerbit.DataSource = ds.Tables("penerbit")
            KatPenerbit.ValueMember = "id_penerbit"
            KatPenerbit.DisplayMember = "nama_penerbit"
            da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * From penulis", conn)
            ds = New DataSet
            da.Fill(ds, "penulis")
            PenulisBx.DataSource = ds.Tables("penulis")
            PenulisBx.ValueMember = "id_penulis"
            PenulisBx.DisplayMember = "nama_penulis"
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub SiticoneDataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SiticoneDataGridView1.CellMouseClick
        Try

            If e.RowIndex >= 0 Then
                SaveBtn.Enabled = False
                EditBtn.Enabled = True
                DeleteBtn.Enabled = True
                Dim row As DataGridViewRow = SiticoneDataGridView1.Rows(e.RowIndex)
                IdBox.Text = row.Cells(0).Value.ToString()
                NamaBuku.Text = row.Cells(1).Value.ToString()
                JmlBuku.Value = Convert.ToInt32(row.Cells(5).Value.ToString)
                KatBuku.SelectedValue = Admin_Panel.getBook(Convert.ToInt32(row.Cells(0).Value.ToString)).idKategori
                KatPenerbit.SelectedValue = Admin_Panel.getBook(row.Cells(0).Value.ToString).idPenerbit
                PenulisBx.SelectedValue = Admin_Panel.getBook(row.Cells(0).Value.ToString).idPenulis
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub addbook_Click(sender As Object, e As EventArgs) Handles addbook.Click
        EditBtn.Enabled = False
        DeleteBtn.Enabled = False

        Reset()

        SaveBtn.Enabled = True
        Try
            conn.Open()
            cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT AUTO_INCREMENT FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'db_perpus' AND TABLE_NAME = 'buku'", conn)
            IdBox.Text = cmd.ExecuteScalar().ToString
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If NamaBuku.Text = "" Then
            MessageBox.Show("Harap Isi Nama Buku", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Admin_Panel.AddBuku(GetBuku)
            DGVShow()
            Reset()
        End If

    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If NamaBuku.Text = "" Then
            MessageBox.Show("Harap Isi Nama Buku", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Admin_Panel.UpdateBuku(GetBuku)
            DGVShow()
            Reset()
        End If
    End Sub

    Private Sub SiticoneButton4_Click_1(sender As Object, e As EventArgs) Handles SiticoneButton4.Click
        Reset()
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Dim x As Object = MessageBox.Show("Apakah Anda Ingin Menghapus Data? Data yang terhapus akan hilang permanent!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If x = vbYes Then
            Admin_Panel.DeleteBuku(GetBuku)
            DGVShow()
            Reset()
        End If
    End Sub
End Class