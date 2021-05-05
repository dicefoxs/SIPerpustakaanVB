Public Class AnggotaController
    Public AnggotaArray As List(Of Anggota)
    Public Sub New()
        Dim tgllahir As New Date(2001, 6, 11)
        Dim anggota As New Anggota
        anggota.idAnggota = 1
        anggota.Nama = "Gunanda Achmad"
        anggota.JenisKel = "Laki-laki"
        anggota.NIK = "9879845646"
        anggota.Alamat = "Tambak Pring Timur"
        anggota.tglLahir = tgllahir
        anggota.idPinjam = Nothing
        addAnggota(anggota)
    End Sub

    Public Sub addAnggota(anggota As Anggota)
        AnggotaArray.Add(anggota)
    End Sub

    Public Function getAnggota() As List(Of Anggota)
        Return AnggotaArray
    End Function

    Public Function getAnggota(idAnggota As Integer) As Anggota
        For Each anggota As Anggota In AnggotaArray
            If anggota.idAnggota = idAnggota Then
                Return anggota
            Else
                Return Nothing
            End If
        Next
    End Function

    Public Sub deleteAnggota(idAnggota As Integer)
        AnggotaArray.Remove(getAnggota(idAnggota))
    End Sub

    Public Sub updateAnggota(idAnggota As Integer, anggota As Anggota)
        AnggotaArray(idAnggota - 1) = anggota
    End Sub
End Class
