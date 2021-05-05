Public Class PinjamController
    Private ArrayPinjam As New List(Of Pinjam)

    Public Sub addPinjam(pjm As Pinjam)
        ArrayPinjam.Add(pjm)
    End Sub
    Public Function getPinjam() As List(Of Pinjam)
        Return ArrayPinjam
    End Function
End Class
