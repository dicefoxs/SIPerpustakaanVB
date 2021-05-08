Public Class PinjamBuku
    Dim books As List(Of Buku) = Admin_Panel.getBuku
    Dim kats As List(Of Kategori) = Admin_Panel.getKategori
    Dim penerbits As List(Of Penerbit) = Admin_Panel.getPenerbit
    Dim members As List(Of Anggota) = Admin_Panel.getMembers
    Dim pinjams As List(Of Pinjam) = Admin_Panel.getPinjam

    Private Function setPinjam() As Pinjam
        Dim pinjam As New Pinjam
        pinjam.idPinjam = Convert.ToInt32(IdPinjamBox.Text)
        pinjam.idBuku = Convert.ToInt32(IdBukuBox.SelectedValue)
        pinjam.idAnggota = Convert.ToInt32(IdMemberBox.SelectedValue)
        pinjam.tglPinjam = DateTimePicker1.Value
        Return pinjam
    End Function

    Private Function getPinjam(ByVal id As Integer) As Pinjam
        For i = 0 To pinjams.Count
            If pinjams(i).idPinjam = id Then
                Return pinjams(i)
            End If
        Next
    End Function

    Private Function getBuku(ByVal id As Integer) As Buku
        Dim i As Integer = 0
        For Each book As Buku In books
            If books(i).idBuku = id Then
                Return books(i)
            End If
            i += 1
        Next
    End Function

    Private Function getAnggota(ByVal id As Integer) As Anggota

        Dim i As Integer = 0
        For Each anggota As Anggota In members
            If members(i).idAnggota = id Then
                Return members(i)
            End If
            i += 1
        Next
    End Function

    Public Sub DGView()
        Dim i As Integer = 0
        For Each pinjam As Pinjam In pinjams
            SiticoneDataGridView1.Rows.Add(pinjams(i).idPinjam.ToString(),
                                           getBuku(pinjams(i).idBuku).namaBuku.ToString,
                                           getAnggota(pinjams(i).idAnggota).Nama.ToString,
                                           pinjams(i).tglPinjam.ToString("dd/MM/yyy"),
                                           If(pinjams(i).statusPinjam, "Sudah Kembali", "Belum Kembali"))
            i += 1
        Next
    End Sub

    Private Sub Reset()
        SaveBtn.Enabled = False
        EditBtn.Enabled = False
        DeleteBtn.Enabled = False
        IdBukuBox.SelectedValue = 1
        NamaBuku.Text = getBuku(IdBukuBox.SelectedValue).namaBuku
        IdMemberBox.SelectedValue = 1
        NamaAnggota.Text = getAnggota(IdMemberBox.SelectedValue).Nama
        DateTimePicker1.Value = Format(Date.Now)
        stsPinjam.Text = ""
    End Sub

    Private Sub IdBukuBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles IdBukuBox.SelectionChangeCommitted
        NamaBuku.Text = getBuku(IdBukuBox.SelectedValue).namaBuku
    End Sub

    Private Sub IdMemberBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles IdMemberBox.SelectionChangeCommitted
        NamaAnggota.Text = getAnggota(IdMemberBox.SelectedValue).Nama
    End Sub

    Private Sub PinjamBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IdBukuBox.DataSource = books
        IdBukuBox.ValueMember = "idBuku"
        IdBukuBox.DisplayMember = "idBuku"
        NamaBuku.Text = getBuku(IdBukuBox.SelectedValue).namaBuku
        IdMemberBox.DataSource = members
        IdMemberBox.ValueMember = "idAnggota"
        IdMemberBox.DisplayMember = "idAnggota"
        NamaAnggota.Text = getAnggota(IdMemberBox.SelectedValue).Nama
        DGView()
    End Sub

    Private Sub SiticonePictureBox1_Click(sender As Object, e As EventArgs) Handles SiticonePictureBox1.Click
        Me.Dispose()
        Admin_Panel.Show()
    End Sub

    Private Sub addbook_Click(sender As Object, e As EventArgs) Handles addbook.Click
        Reset()
        IdPinjamBox.Text = If(pinjams.Count > 0, Admin_Panel.getPinjam().Last.idPinjam + 1.ToString(), "1")
        SaveBtn.Enabled = True
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        Dim member As Anggota = getAnggota(setPinjam.idAnggota)
        Dim buku1 As Buku = getBuku(setPinjam.idBuku)
        Dim buku2 As Buku = getBuku(getPinjam(IdPinjamBox.Text).idBuku)
        Dim pjm As Pinjam = setPinjam()
        If getPinjam(IdPinjamBox.Text).statusPinjam Then
            MessageBox.Show("Data pinjam yang sudah dikembalikan tidak bisa diedit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf buku1.idBuku <> getPinjam(IdPinjamBox.Text).idBuku Then
            If buku1.jumlahBuku > 0 Then
                MessageBox.Show("Buku Habis!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf member.idAnggota = getPinjam(IdPinjamBox.Text).idAnggota Or member.statusPinjam = False Then
                pjm.statusPinjam = If(stsPinjam.Text.Equals("Sudah Kembali"), True, False)
                member.statusPinjam = True
                buku2.jumlahBuku = buku2.jumlahBuku + 1
                buku1.jumlahBuku = buku1.jumlahBuku - 1
                Admin_Panel.UpdateBuku(buku2)
                Admin_Panel.UpdateBuku(buku1)
                Admin_Panel.UpdateAnggota(member)
                Admin_Panel.UpdatePinjam(pjm)
            End If
        ElseIf member.statusPinjam Then
            MessageBox.Show(member.Nama.ToString() & " Sudah Meminjam Buku!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            pjm.statusPinjam = If(stsPinjam.Text.Equals("Sudah Kembali"), True, False)
            Admin_Panel.UpdatePinjam(pjm)
        End If

        Reset()
        SiticoneDataGridView1.Rows.Clear()
        DGView()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim member As Anggota = getAnggota(setPinjam.idAnggota)
        Dim buku1 As Buku = getBuku(setPinjam.idBuku)
        If member.statusPinjam Then
            MessageBox.Show(member.Nama.ToString() & " Sudah Meminjam Buku!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Admin_Panel.AddPinjam(setPinjam)
            buku1.jumlahBuku = buku1.jumlahBuku - 1
            member.statusPinjam = True
            Admin_Panel.UpdateAnggota(member)
            Admin_Panel.UpdateBuku(buku1)
        End If
        Reset()
        SiticoneDataGridView1.Rows.Clear()
        DGView()
    End Sub

    Private Sub SiticoneButton4_Click(sender As Object, e As EventArgs) Handles SiticoneButton4.Click
        Reset()
    End Sub

    Private Sub SiticoneDataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SiticoneDataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            SaveBtn.Enabled = False
            EditBtn.Enabled = True
            DeleteBtn.Enabled = True
            Dim row As DataGridViewRow = SiticoneDataGridView1.Rows(e.RowIndex)
            IdPinjamBox.Text = row.Cells(0).Value.ToString()
            IdBukuBox.SelectedValue = getPinjam(row.Cells(0).Value).idBuku
            IdMemberBox.SelectedValue = getPinjam(row.Cells(0).Value).idAnggota
            stsPinjam.Text = If(getPinjam(row.Cells(0).Value).statusPinjam, "Sudah Kembali", "Belum Kembali")
            DateTimePicker1.Value = getPinjam(row.Cells(0).Value).tglPinjam.ToString("dd/MM/yyyy")
        End If
    End Sub
End Class