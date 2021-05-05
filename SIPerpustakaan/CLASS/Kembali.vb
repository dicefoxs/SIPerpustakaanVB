Public Class Kembali

    Private Property _idKembali As Integer
    Private Property _idPinjam As Integer
    Private Property _Denda As Integer
    Private Property _idAnggota As Integer
    Private Property _tglKembali As Date

    Public Property idKembali As Integer
        Set(value As Integer)
            _idKembali = value
        End Set
        Get
            Return _idKembali
        End Get
    End Property

    Public Property idPinjam As Integer
        Set(value As Integer)
            _idPinjam = value
        End Set
        Get
            Return _idPinjam
        End Get
    End Property

    Public Property Denda As Integer
        Set(value As Integer)
            _Denda = Denda
        End Set
        Get
            Return _Denda
        End Get
    End Property

    Public Property tglKembali As Date
        Set(value As Date)
            _tglKembali = value
        End Set
        Get
            Return _tglKembali
        End Get
    End Property
End Class
