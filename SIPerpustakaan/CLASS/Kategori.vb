Public Class Kategori
    Private Property _idKategori As Integer
    Private Property _namaKategori As String

    Public Property idKategori As Integer
        Set(value As Integer)
            _idKategori = value
        End Set
        Get
            Return _idKategori
        End Get
    End Property

    Public Property namaKategori As String
        Set(value As String)
            _namaKategori = value
        End Set
        Get
            Return _namaKategori
        End Get
    End Property
End Class
