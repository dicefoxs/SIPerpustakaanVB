Public Class Buku
    Private Property _namaBuku As String
    Private Property _idBuku As Integer
    Private Property _idKategori As Integer
    Private Property _jumlahBuku As Integer
    Private Property _idPenerbit As Integer
    Private Property _idPenulis As Integer

    Public Property idBuku As Integer
        Set(value As Integer)
            _idBuku = value
        End Set
        Get
            Return _idBuku
        End Get
    End Property

    Public Property namaBuku As String
        Set(value As String)
            _namaBuku = value
        End Set
        Get
            Return _namaBuku
        End Get
    End Property

    Public Property idKategori As Integer
        Set(value As Integer)
            _idKategori = value
        End Set
        Get
            Return _idKategori
        End Get
    End Property

    Public Property idPenerbit As Integer
        Set(value As Integer)
            _idPenerbit = value
        End Set
        Get
            Return _idPenerbit
        End Get
    End Property

    Public Property jumlahBuku As Integer
        Set(value As Integer)
            _jumlahBuku = value
        End Set
        Get
            Return _jumlahBuku
        End Get
    End Property

    Public Property idPenulis As Integer
        Set(value As Integer)
            _idPenulis = value
        End Set
        Get
            Return _idPenulis
        End Get
    End Property
End Class
