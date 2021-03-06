Public Class Admin_Panel
    Dim _buku As New BukuController
    Dim _members As New AnggotaController
    Dim _kategori As New KategoriController
    Dim _pinjam As New PinjamController
    Dim _penerbit As New PenerbitController
    Dim _kembali As New KembaliController
    'Get data
    Public Function getPenerbit() As List(Of Penerbit)
        Return _penerbit.getPenerbits
    End Function

    Public Function getBooks() As DataSet
        Return _buku.getBooks
    End Function

    Public Function getBook(ByRef id As Integer) As Buku
        Return _buku.getBook(id)
    End Function

    Public Function getMemberss() As DataSet
        Return _members.getAnggotas
    End Function

    Public Function getKategori() As List(Of Kategori)
        Return _kategori.getKategori
    End Function

    Public Function getPinjam() As List(Of Pinjam)
        Return _pinjam.getPinjam
    End Function
    Public Function getKembali() As List(Of Kembali)
        Return _kembali.getKembali
    End Function
    'store buku
    Public Sub AddBuku(ByVal buku As Buku)
        _buku.addBuku(buku)
    End Sub
    Public Sub UpdateBuku(ByVal buku As Buku)
        _buku.UpdateBuku(buku)
    End Sub
    Public Sub DeleteBuku(ByVal buku As Buku)
        _buku.DeleteBuku(buku)
    End Sub
    'store anggota
    Public Sub AddAnggota(ByVal member As Anggota)
        _members.addAnggotas(member)
    End Sub
    Public Sub UpdateAnggota(ByVal member As Anggota)
        _members.updateAnggota(member)
    End Sub
    Public Sub DeleteAnggota(ByVal member As Anggota)
        _members.deleteAnggota(member)
    End Sub
    'store pinjam
    Public Sub AddPinjam(ByVal pinjam As Pinjam)
        _pinjam.addPinjam(pinjam)
    End Sub
    Public Sub UpdatePinjam(ByVal pinjam As Pinjam)
        _pinjam.UpdatePinjam(pinjam)
    End Sub
    Public Sub DeletePinjam(ByVal pinjam As Pinjam)
        _pinjam.DeletePinjam(pinjam)
    End Sub
    'store kembali
    Public Sub AddKembali(ByVal kembali As Kembali)
        _kembali.addKembali(kembali)
    End Sub

    Private Sub SiticonePictureBox1_Click(sender As Object, e As EventArgs) Handles SiticonePictureBox1.Click
        Dim x As Object = MessageBox.Show("Ingin Keluar Aplikasi", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = vbYes Then
            Me.Dispose()
            splash.Dispose()
        End If
    End Sub

    Private Sub Admin_Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim kategori As New Kategori
        kategori.idKategori = 2
        kategori.namaKategori = "Komik"
        _kategori.addKategori(kategori)
    End Sub

    Private Sub SiticonePictureBox2_Click(sender As Object, e As EventArgs) Handles SiticonePictureBox2.Click
        BookManagement.Show()
        Me.Hide()
    End Sub

    Private Sub SiticonePictureBox3_Click(sender As Object, e As EventArgs) Handles SiticonePictureBox3.Click
        MemberManagement.Show()
        Me.Hide()
    End Sub

    Private Sub SiticonePictureBox4_Click(sender As Object, e As EventArgs) Handles SiticonePictureBox4.Click
        PinjamBuku.Show()
        Me.Hide()
    End Sub

    Private Sub SiticonePictureBox5_Click(sender As Object, e As EventArgs) Handles SiticonePictureBox5.Click
        PengembalianBuku.Show()
        Me.Hide()
    End Sub
End Class