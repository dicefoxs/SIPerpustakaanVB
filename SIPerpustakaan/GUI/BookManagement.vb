Public Class BookManagement
    Public _book As List(Of Buku)

    Public Sub setBook(value As List(Of Buku))
        _book = value
    End Sub

    Private Sub BookManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class