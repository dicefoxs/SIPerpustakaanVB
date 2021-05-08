Public Class Pinjam
    Private Property _idPinjam As Integer
    Private Property _idAnggota As Integer
    Private Property _idBuku As Integer
    Private Property _tglPinjam As Date
    Private Property _statusPinjam As Boolean

    Public Sub New()
        statusPinjam = False
    End Sub

    Public Property idPinjam As Integer
        Set(value As Integer)
            _idPinjam = value
        End Set
        Get
            Return _idPinjam
        End Get
    End Property

    Public Property idBuku As Integer
        Set(value As Integer)
            _idBuku = value
        End Set
        Get
            Return _idBuku
        End Get
    End Property

    Public Property statusPinjam As Boolean
        Set(value As Boolean)
            _statusPinjam = value
        End Set
        Get
            Return _statusPinjam
        End Get
    End Property

    Public Property idAnggota As Integer
        Set(value As Integer)
            _idAnggota = value
        End Set
        Get
            Return _idAnggota
        End Get
    End Property

    Public Property tglPinjam As Date
        Set(value As Date)
            _tglPinjam = value
        End Set
        Get
            Return _tglPinjam
        End Get
    End Property
End Class
