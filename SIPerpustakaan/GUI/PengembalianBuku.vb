Public Class PengembalianBuku
    Dim books As List(Of Buku) = Admin_Panel.getBuku
    Dim kats As List(Of Kategori) = Admin_Panel.getKategori
    Dim penerbits As List(Of Penerbit) = Admin_Panel.getPenerbit
    Dim members As List(Of Anggota) = Admin_Panel.getMembers
    Dim pinjams As List(Of Pinjam) = Admin_Panel.getPinjam
    Dim kembalis As List(Of Kembali) = Admin_Panel.getKembali

    Private Function setKembali() As Kembali
        Dim kembali As New Kembali
        kembali.idKembali = Convert.ToInt32(IdKembali.Text)
        kembali.idPinjam = idPinjamBox.SelectedValue
        kembali.tglKembali = DateTimePicker2.Value
        Return kembali
    End Function

    Private Function arrayPinjam() As List(Of Pinjam)
        Dim pjms As New List(Of Pinjam)
        For Each pjm As Pinjam In pinjams
            If pjm.statusPinjam = False Then
                pjms.Add(pjm)
            End If
        Next
        Return pjms
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

    Public Function getDenda() As Integer
        Dim dt1 As DateTime = Convert.ToDateTime(DateTimePicker1.Value.ToString("dd/MM/yyyy"))
        Dim dt2 As DateTime = Convert.ToDateTime(DateTimePicker2.Value.ToString("dd/MM/yyyy"))

        Dim ts As TimeSpan = dt2.Subtract(dt1)


        If Convert.ToInt32(ts.Days) > 14 Then
            Return (Convert.ToInt32(ts.Days) - 14) * 2000
        Else
            Return 0
        End If



    End Function

    Public Sub DGView()
        Dim i As Integer = 0
        For Each kembali As Kembali In kembalis
            SiticoneDataGridView1.Rows.Add(kembalis(i).idKembali.ToString(),
                                           kembalis(i).idPinjam,
                                           getBuku(getPinjam(kembalis(i).idPinjam).idBuku).namaBuku,
                                           getAnggota(getPinjam(kembalis(i).idPinjam).idAnggota).Nama,
                                           getPinjam((kembalis(i).idPinjam)).tglPinjam.ToString("dd/MM/yyyy"),
                                           kembalis(i).tglKembali.ToString("dd/MM/yyyy"),
                                           kembalis(i).Denda.ToString)
            i += 1
        Next
    End Sub

    Private Sub combobox()
        idPinjamBox.DataSource = arrayPinjam()
        idPinjamBox.ValueMember = "idPinjam"
        idPinjamBox.DisplayMember = "idPinjam"
    End Sub

    Private Sub Reset()
        combobox()
        SaveBtn.Enabled = False
        NamaAnggota.Text = ""
        NamaBuku.Text = ""
        idPinjamBox.Enabled = False
        DateTimePicker2.Enabled = False
    End Sub

    Private Sub addbook_Click(sender As Object, e As EventArgs) Handles addbook.Click
        If pinjams.Count < 1 Then
            MessageBox.Show("Tidak Ada Data Pinjaman", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf arrayPinjam().Count < 1 Then
            MessageBox.Show("Tidak Ada Data Pinjaman yang belum kembali", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Reset()
            IdKembali.Text = If(kembalis.Count > 0, Admin_Panel.getKembali().Last.idKembali + 1.ToString(), "1")
            NamaBuku.Text = getBuku(getPinjam(idPinjamBox.SelectedValue).idBuku).namaBuku.ToString
            NamaAnggota.Text = getAnggota(getPinjam(idPinjamBox.SelectedValue).idAnggota).Nama.ToString
            DateTimePicker1.Value = getPinjam(idPinjamBox.SelectedValue).tglPinjam
            idPinjamBox.Enabled = True
            SaveBtn.Enabled = True
            Denda.Text = getDenda.ToString
        End If
    End Sub
    Private Sub PengembalianBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGView()
    End Sub
    Private Sub idPinjamBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles idPinjamBox.SelectionChangeCommitted
        NamaBuku.Text = getBuku(getPinjam(idPinjamBox.SelectedValue).idBuku).namaBuku.ToString
        NamaAnggota.Text = getAnggota(getPinjam(idPinjamBox.SelectedValue).idAnggota).Nama.ToString
        DateTimePicker1.Value = getPinjam(idPinjamBox.SelectedValue).tglPinjam

    End Sub
    Private Sub SiticoneButton4_Click(sender As Object, e As EventArgs) Handles SiticoneButton4.Click
        Reset()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim pinjam As Pinjam = getPinjam(setKembali.idPinjam)
        Dim anggota As Anggota = getAnggota(getPinjam(setKembali.idPinjam).idAnggota)
        Dim buku As Buku = getBuku(getPinjam(setKembali.idPinjam).idBuku)
        Dim x As Object = MessageBox.Show(anggota.Nama & " Akan mengembalikan buku" & buku.namaBuku & "?", "Pengembalian Buku", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = vbYes Then
            Admin_Panel.AddKembali(setKembali)
            buku.jumlahBuku += 1
            anggota.statusPinjam = False
            pinjam.statusPinjam = True
            Admin_Panel.UpdateBuku(buku)
            Admin_Panel.UpdateAnggota(anggota)
            Admin_Panel.UpdatePinjam(pinjam)
            Reset()
            SiticoneDataGridView1.Rows.Clear()
            DGView()
        End If
    End Sub

    Private Sub SiticonePictureBox1_Click(sender As Object, e As EventArgs) Handles SiticonePictureBox1.Click
        Me.Dispose()
        Admin_Panel.Show()
    End Sub
End Class