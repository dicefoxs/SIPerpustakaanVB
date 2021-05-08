Public Class BookManagement

    Private Sub SiticonePictureBox1_Click(sender As Object, e As EventArgs) Handles SiticonePictureBox1.Click
        Admin_Panel.Show()
        Me.Dispose()
    End Sub

    Private Sub BookManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVShow()
        ComboBxItems()
    End Sub

    Private Function getKategori(ByVal id As Integer) As Kategori

        Dim i As Integer = 0
        For Each kate As Kategori In Admin_Panel.getKategori()
            If Admin_Panel.getKategori(i).idKategori = id Then
                Return Admin_Panel.getKategori(i)
            End If
            i += 1
        Next
    End Function

    Private Function getBuku(ByVal id As Integer) As Buku

        Dim i As Integer = 0
        For Each book As Buku In Admin_Panel.getBuku()
            If Admin_Panel.getBuku(i).idBuku = id Then
                Return Admin_Panel.getBuku(i)
            End If
            i += 1
        Next
    End Function

    Private Sub DGVShow()
        Dim i As Integer = 0
        For Each kat As Buku In Admin_Panel.getBuku()
            SiticoneDataGridView1.Rows.Add(Admin_Panel.getBuku()(i).idBuku.ToString(), Admin_Panel.getBuku()(i).namaBuku.ToString(), Admin_Panel.getBuku()(i).jumlahBuku.ToString(), getKategori(Admin_Panel.getBuku()(i).idKategori).namaKategori)
            i += 1
        Next
    End Sub

    Private Function GetBuku() As Buku
        Dim buku As New Buku
        buku.idBuku = Convert.ToInt32(IdBox.Text)
        buku.jumlahBuku = JmlBuku.Value
        buku.idKategori = CInt(KatBuku.SelectedValue)
        buku.idPenerbit = CInt(KatPenerbit.SelectedValue)
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
        KatBuku.DataSource = Admin_Panel.getKategori()
        KatBuku.ValueMember = "idKategori"
        KatBuku.DisplayMember = "namaKategori"

        KatPenerbit.DataSource = Admin_Panel.getPenerbit()
        KatPenerbit.ValueMember = "idPenerbit"
        KatPenerbit.DisplayMember = "namaPenerbit"
    End Sub

    Private Sub SiticoneDataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SiticoneDataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            SaveBtn.Enabled = False
            EditBtn.Enabled = True
            DeleteBtn.Enabled = True
            Dim row As DataGridViewRow = SiticoneDataGridView1.Rows(e.RowIndex)
            IdBox.Text = row.Cells(0).Value.ToString()
            NamaBuku.Text = row.Cells(1).Value.ToString()
            JmlBuku.Value = row.Cells(2).Value
            KatBuku.SelectedValue = getBuku(row.Cells(0).Value).idKategori
            KatPenerbit.SelectedValue = getBuku(row.Cells(0).Value).idPenerbit

        End If
    End Sub

    Private Sub addbook_Click(sender As Object, e As EventArgs) Handles addbook.Click
        EditBtn.Enabled = False
        DeleteBtn.Enabled = False

        Reset()

        SaveBtn.Enabled = True
        If Admin_Panel.getBuku().Count > 0 Then
            IdBox.Text = Admin_Panel.getBuku().Last.idBuku + 1
        Else
            IdBox.Text = 1
        End If

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If NamaBuku.Text = "" Then
            MessageBox.Show("Harap Isi Nama Buku", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Admin_Panel.AddBuku(GetBuku)
            SiticoneDataGridView1.Rows.Clear()
            DGVShow()
            Reset()
        End If

    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If NamaBuku.Text = "" Then
            MessageBox.Show("Harap Isi Nama Buku", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Admin_Panel.UpdateBuku(GetBuku)
            SiticoneDataGridView1.Rows.Clear()
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
            SiticoneDataGridView1.Rows.Clear()
            DGVShow()
            Reset()
        End If
    End Sub
End Class