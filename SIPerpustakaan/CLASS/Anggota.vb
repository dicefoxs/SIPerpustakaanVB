Public Class Anggota
    Inherits Human
    Private Property _idAnggota As Integer
    Private Property _StatusAnggota As String
    Private Property _StatusPinjam As Boolean
    Private Property _Denda As Integer
    Private Property _idPinjam As Integer


    Public Property idAnggota As Integer
        Set(value As Integer)
            _idAnggota = value
        End Set
        Get
            Return _idAnggota
        End Get
    End Property

    Public Overloads Property Nama As String
        Set(value As String)
            _Nama = value
        End Set
        Get
            Return _Nama
        End Get
    End Property
    Public Overloads Property NIK As String
        Set(value As String)
            _NIK = value
        End Set
        Get
            Return _NIK
        End Get
    End Property
    Public Overloads Property tglLahir As Date
        Set(value As Date)
            _TglLahir = value
        End Set
        Get
            Return _TglLahir
        End Get
    End Property
    Public Overloads Property Alamat As String
        Set(value As String)
            _Alamat = value
        End Set
        Get
            Return _Alamat
        End Get
    End Property
    Public Overloads Property JenisKel As String
        Set(value As String)
            _JenisKel = value
        End Set
        Get
            Return _JenisKel
        End Get
    End Property
End Class
