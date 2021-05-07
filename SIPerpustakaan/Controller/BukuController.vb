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
        Me.ArrayBuku = buku
    End Sub

    Public Function getBuku() As List(Of Buku)
        Return ArrayBuku
    End Function

    Public Sub DeleteBuku(ByVal buku As Buku)
        For i = 0 To ArrayBuku.Count
            If ArrayBuku(i).idBuku = buku.idBuku Then
                ArrayBuku.RemoveAt(i)
                Exit For
            End If
        Next
    End Sub

    Public Sub UpdateBuku(ByVal buku As Buku)
        Dim i As Integer = 0
        For Each book As Buku In ArrayBuku
            If book.idBuku = buku.idBuku Then
                ArrayBuku(i).namaBuku = buku.namaBuku
                ArrayBuku(i).idKategori = buku.idKategori
                ArrayBuku(i).idPenerbit = buku.idPenerbit
                ArrayBuku(i).jumlahBuku = buku.jumlahBuku
            End If
            i += 1
        Next
    End Sub
End Class
