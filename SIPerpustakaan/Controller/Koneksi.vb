Imports MySql.Data.MySqlClient
Module Koneksi
    Public conn As New MySqlConnection("Server=localhost;user id=root;password=;database=db_perpus")
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public str As String
End Module
