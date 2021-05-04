Module BukuController
    Public ArrayBuku As List(Of Buku)

    Public Sub BukuController()
        Dim buku As New Buku
        buku.idBuku = 1
        buku.namaBuku = "Modul PBO"
        buku.namaPenerbit = "Lab RPL"

    End Sub

    Public Sub addBuku(buku As Buku)
        ArrayBuku.Add(buku)
    End Sub

    Public Function getBuku() As List(Of Buku)
        Return ArrayBuku
    End Function
End Module
