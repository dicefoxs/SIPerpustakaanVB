Public Class PengembalianBuku
    Dim books As List(Of Buku) = Admin_Panel.getBuku
    Dim kats As List(Of Kategori) = Admin_Panel.getKategori
    Dim penerbits As List(Of Penerbit) = Admin_Panel.getPenerbit
    Dim members As List(Of Anggota) = Admin_Panel.getMembers
    Dim pinjam As List(Of Pinjam) = Admin_Panel.getPinjam

    Private Function arrayPinjam() As List(Of Pinjam)
        Dim pjms As New List(Of Pinjam)
        For Each pjm As Pinjam In pinjam
            If pjm.statusPinjam = False Then
                pjms.Add(pjm)
            End If
        Next
        Return pjms
    End Function



    Private Sub combobox()
        idPinjamBox.DataSource = arrayPinjam()
        idPinjamBox.ValueMember = "idPinjam"
        idPinjamBox.DisplayMember = "idPinjam"
    End Sub

    Private Sub Reset()
        combobox()
        SaveBtn.Enabled = False
        EditBtn.Enabled = False
        DeleteBtn.Enabled = False
        NamaAnggota.Text = ""
        NamaBuku.Text = ""
        idPinjamBox.Enabled = False
        DateTimePicker2.Enabled = False
    End Sub

    Private Sub SiticoneDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SiticoneDataGridView1.CellContentClick

    End Sub

    Private Sub addbook_Click(sender As Object, e As EventArgs) Handles addbook.Click

    End Sub
    Private Sub PengembalianBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        combobox()
    End Sub
End Class