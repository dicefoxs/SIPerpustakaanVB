Public Class KategoriController
    Private ArrayKategori As New List(Of Kategori)

    Public Sub New()
        Dim kategori As New Kategori
        kategori.idKategori = 1
        kategori.namaKategori = "Modul"
        addKategori(kategori)
    End Sub

    Public Sub addKategori(ByVal id As Integer, ByVal nama As String)
        Dim kategori As New Kategori
        kategori.idKategori = id
        kategori.namaKategori = nama
        Me.ArrayKategori.Add(kategori)
    End Sub

    Public Sub addKategori(ByVal kategori As Kategori)
        Me.ArrayKategori.Add(kategori)
    End Sub

    Public Function getKategori() As List(Of Kategori)
        Return Me.ArrayKategori
    End Function

    Public Sub UpdateKategori(ByVal id As Integer, ByVal nama As String)
        Dim i As Integer = 0
        For Each kat As Kategori In ArrayKategori
            If kat.idKategori = id Then
                ArrayKategori(i).namaKategori = nama
            End If

            i += 1
        Next
    End Sub

End Class
