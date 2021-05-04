Public Class Anggota
    Inherits Human
    Private Property _idAnggota As Integer
    Private Property _StatusAnggota As String
    Private Property _StatusPinjam As Boolean
    Private Property _Denda As Integer
    Private Property _Status As Boolean


    Public Property idAnggota As Integer
        Set(value As Integer)
            _idAnggota = value
        End Set
        Get
            Return _idAnggota
        End Get
    End Property
End Class
