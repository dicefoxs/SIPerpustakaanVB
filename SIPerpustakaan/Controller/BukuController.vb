Imports MySql.Data.MySqlClient

Class BukuController
    Public Property ArrayBuku As New List(Of Buku)

    Public Function getBook(ByVal id As Integer) As Buku
        Dim buku As New Buku
        Try
            conn.Open()
            str = "SELECT * FROM buku where id_buku = " & id & ""
            da = New MySqlDataAdapter(str, conn)
            ds = New DataSet
            da.Fill(ds, "buku")
            buku.idBuku = ds.Tables("buku").Rows(0).Item(0)
            buku.namaBuku = ds.Tables("buku").Rows(0).Item(1).ToString
            buku.idKategori = ds.Tables("buku").Rows(0).Item(2)
            buku.idPenulis = ds.Tables("buku").Rows(0).Item(3)
            buku.idPenerbit = ds.Tables("buku").Rows(0).Item(4)
            buku.jumlahBuku = ds.Tables("buku").Rows(0).Item(5)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        Return buku
    End Function

    Public Function getBooks() As DataSet
        Try
            conn.Open()
            str = "select buku.id_buku as id, buku.nama_buku as namaBuku, kategori.nama_kategori as kategori, penulis.nama_penulis as penulis, penerbit.nama_penerbit as penerbit, buku.jumlah as jumlah FROM buku
                   JOIN kategori ON kategori.id_kategori =  buku.id_kategori
                   JOIN penulis ON penulis.id_penulis = buku.id_penulis
                   JOIN penerbit ON penerbit.id_penerbit = buku.id_penerbit
                   ORDER BY buku.id_buku ASC"
            da = New MySqlDataAdapter(str, conn)
            ds = New DataSet
            da.Fill(ds, "buku")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Dispose()
        End Try
        Return ds
    End Function

    Public Sub addBuku(ByVal buku As Buku)
        Try
            conn.Open()
            str = "INSERT INTO buku(nama_buku, id_kategori, id_penulis, id_penerbit, jumlah) VALUES('" & buku.namaBuku & "', " & buku.idKategori & "," & buku.idPenulis & ", " & buku.idPenerbit & ", " & buku.jumlahBuku & ")"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Berhasil Tambah Data", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Public Sub DeleteBuku(ByVal buku As Buku)
        Try
            conn.Open()
            str = "DELETE FROM buku
                   WHERE id_buku = " & buku.idBuku
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Berhasil Hapus Data", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Public Sub UpdateBuku(ByVal buku As Buku)
        Try
            conn.Open()
            str = "UPDATE buku SET nama_buku = '" & buku.namaBuku & "', 
                   id_kategori = " & buku.idKategori & ",
                   id_penulis = " & buku.idPenulis & ",
                   id_penerbit = " & buku.idPenerbit & ",
                   jumlah = " & buku.jumlahBuku & "
                   WHERE id_buku = " & buku.idBuku
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Berhasil Update Data", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub MsgBox(v1 As String, v2 As String, oK As MessageBoxButtons)
        Throw New NotImplementedException()
    End Sub

    Private Sub MsgBox(v1 As String, v2 As String, oK As MessageBoxButtons, information As MessageBoxIcon)
        Throw New NotImplementedException()
    End Sub
End Class
