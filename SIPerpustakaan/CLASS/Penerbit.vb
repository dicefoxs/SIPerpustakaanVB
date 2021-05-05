Public Class Penerbit
    Private Property _idPenerbit As Integer
    Private Property _namaPenerbit As String

    Public Property idPenerbit As Integer
        Set(value As Integer)
            _idPenerbit = value
        End Set
        Get
            Return _idPenerbit
        End Get
    End Property

    Public Property namaPenerbit As String
        Set(value As String)
            _namaPenerbit = value
        End Set
        Get
            Return _namaPenerbit
        End Get
    End Property
End Class
