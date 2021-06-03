Imports MySql.Data.MySqlClient
Public Class AnggotaController

    Public anggotas As New DataSet()

    Public Function getAnggotas() As DataSet
        Try
            conn.Open()
            da = New MySqlDataAdapter("SELECT id_member as id, nama_member as nama, alamat_member as alamat, telp_member as Telepon, nik, jenis_kelamin as JenisKelamin, tanggal_lahir, status, status_pinjam From member", conn)
            ds = New DataSet
            da.Fill(ds, "member")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        Return ds
    End Function

    Public Sub addAnggotas(anggota As Anggota)
        Try
            conn.Open()
            cmd = New MySqlCommand("INSERT INTO member(nama_member, alamat_member, telp_member, nik, jenis_kelamin ,tanggal_lahir ,status, status_pinjam) VALUES('" & anggota.Nama & "','" & anggota.Alamat & "','" & anggota.NoTelp & "','" & anggota.NIK & "','" & anggota.JenisKel & "','" & anggota.tglLahir.ToString("yyyy-MM-dd ") & "'," & anggota.StatusAnggota & ", 0)", conn)
            cmd.ExecuteReader()
            MsgBox("Berhasil Memasukan Data", MsgBoxStyle.DefaultButton2)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Public Sub deleteAnggota(ByVal anggota As Anggota)
        Try
            conn.Open()
            str = "DELETE FROM member
                   WHERE id_member=" & anggota.idAnggota & ""
            cmd = New MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Public Sub updateAnggota(ByVal anggota As Anggota)
        Try
            conn.Open()
            str = "UPDATE member SET nama_member = '" & anggota.Nama & "' ,
                   alamat_member = '" & anggota.Alamat & "',
                   telp_member = '" & anggota.NoTelp & "',
                   nik = '" & anggota.NIK & "',
                   jenis_kelamin = '" & anggota.JenisKel & "',
                   tanggal_lahir = '" & anggota.tglLahir.ToString("yyyy-MM-dd") & "',
                   status = '" & anggota.StatusAnggota & "'
                   WHERE id_member=" & anggota.idAnggota & ""
            cmd = New MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
End Class
