Public Class Human
    Protected Property _Nama As String
    Protected Property _NIK As String
    Protected Property _TglLahir As Date
    Protected Property _Alamat As String
    Protected Property _JenisKel As String
    Protected Property _NoTelp As String

    Public Property Nama As String
        Set(value As String)
            _Nama = value
        End Set
        Get
            Return _Nama
        End Get
    End Property
    Public Property NIK As String
        Set(value As String)
            _NIK = value
        End Set
        Get
            Return _NIK
        End Get
    End Property
    Public Property tglLahir As Date
        Set(value As Date)
            _TglLahir = value
        End Set
        Get
            Return _TglLahir
        End Get
    End Property
    Public Property Alamat As String
        Set(value As String)
            _Alamat = value
        End Set
        Get
            Return _Alamat
        End Get
    End Property
    Public Property JenisKel As String
        Set(value As String)
            _JenisKel = value
        End Set
        Get
            Return _JenisKel
        End Get
    End Property

    Public Property NoTelp As String
        Set(value As String)
            _NoTelp = value
        End Set
        Get
            Return _NoTelp
        End Get
    End Property

End Class
