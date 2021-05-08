Public Class KembaliController
    Private ArrayKembali As New List(Of Kembali)

    Public Sub addKembali(ByVal kembali As Kembali)
        ArrayKembali.Add(kembali)
    End Sub


    Public Function getKembali()
        Return ArrayKembali
    End Function
End Class
