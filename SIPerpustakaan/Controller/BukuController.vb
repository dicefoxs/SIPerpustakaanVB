Class BukuController
    Public Property ArrayBuku As New List(Of Buku)

    Public Sub New()
        Dim buku As New Buku
        buku.idBuku = 1
        buku.namaBuku = "Modul PBO"
        buku.idPenerbit = 1
        buku.jumlahBuku = 25
        buku.idKategori = 1
        addBuku(buku)
    End Sub

    Public Sub addBuku(ByVal buku As Buku)
        Me.ArrayBuku.Add(buku)
    End Sub

    Public Sub addBuku(ByVal buku As List(Of Buku))
        ArrayBuku = buku
    End Sub

    Public Function getBuku() As List(Of Buku)
        Return ArrayBuku
    End Function
End Class
