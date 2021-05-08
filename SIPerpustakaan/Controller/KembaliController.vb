Public Class KembaliController
    Private ArrayKembali As New List(Of Kembali)

    Public Sub addKembali(ByVal kembali As Kembali)
        ArrayKembali.Add(kembali)
    End Sub

    Public Sub deleteKembali(ByVal kembali As Kembali)
        For i = 0 To ArrayKembali.Count
            If kembali.idKembali = ArrayKembali(i).idKembali Then
                ArrayKembali.RemoveAt(i)
                Exit For
            End If
        Next
    End Sub

    Public Function getKembali()
        Return ArrayKembali
    End Function
End Class
