Public Class KategoriController
    Private ArrayKategory As New List(Of Kategori)

    Public Sub New()
        Dim kategori As New Kategori
        kategori.idKategori = 1
        kategori.namaKategori = "Modul"
        addKategory(kategori)
    End Sub

    Public Sub addKategory(kategory As Kategori)
        Me.ArrayKategory.Add(kategory)
    End Sub

    Public Function getKategory() As List(Of Kategori)
        Return Me.ArrayKategory
    End Function

End Class
