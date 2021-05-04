Public Class Buku
    Private Property _namaBuku As String
    Private Property _idBuku As Integer
    Private Property _idJenis As Integer
    Private Property _jumlahBuku As Integer
    Private Property _namaPenerbit As String
    Private Property _thnTerbit As Date

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
    Public Property idJenis As Integer
        Set(value As Integer)
            _idBuku = value
        End Set
        Get
            Return _idBuku
        End Get
    End Property
    Public Property namaPenerbit As Integer
        Set(value As Integer)
            _namaPenerbit = value
        End Set
        Get
            Return _namaPenerbit
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
    Public Property thnTerbit As Date
        Set(value As Date)
            _thnTerbit = value
        End Set
        Get
            Return _thnTerbit
        End Get
    End Property
End Class
