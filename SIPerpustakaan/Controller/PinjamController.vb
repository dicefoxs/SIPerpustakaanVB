Public Class PinjamController
    Private ArrayPinjam As New List(Of Pinjam)

    Public Sub addPinjam(ByVal pjm As Pinjam)
        ArrayPinjam.Add(pjm)
    End Sub

    Public Sub UpdatePinjam(ByVal pinjam As Pinjam)
        For i = 0 To ArrayPinjam.Count
            If pinjam.idPinjam = ArrayPinjam(i).idPinjam Then
                ArrayPinjam(i).idAnggota = pinjam.idAnggota
                ArrayPinjam(i).idBuku = pinjam.idBuku
                ArrayPinjam(i).tglPinjam = pinjam.tglPinjam
                ArrayPinjam(i).statusPinjam = pinjam.statusPinjam
                Exit For
            End If
        Next
    End Sub

    Public Sub DeletePinjam(ByVal pinjam As Pinjam)
        For i = 0 To ArrayPinjam.Count
            If pinjam.idPinjam = ArrayPinjam(i).idPinjam Then
                ArrayPinjam.RemoveAt(i)
                Exit For
            End If
        Next
    End Sub

    Public Function getPinjam() As List(Of Pinjam)
        Return ArrayPinjam
    End Function
End Class
