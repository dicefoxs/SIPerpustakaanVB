Class BukuController
    Public ArrayBuku As List(Of Buku)

    Public Sub BukuController()
        Dim buku As New Buku
        buku.idBuku = 1
        buku.namaBuku = "Modul PBO"
        buku.namaPenerbit = "Lab RPL"
        buku.jumlahBuku = 25
        buku.idJenis = 1
        addBuku(buku)
    End Sub

    Public Sub addBuku(buku As Buku)
        ArrayBuku.Add(buku)
    End Sub

    Public Sub addBuku(buku As List(Of Buku))
        ArrayBuku = buku
    End Sub

    Public Function getBuku() As List(Of Buku)
        Return ArrayBuku
    End Function
End Class
