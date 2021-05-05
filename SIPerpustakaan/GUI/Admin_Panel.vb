Imports System.Reflection
Public Class Admin_Panel
    Dim _buku As New BukuController
    Dim _members As New AnggotaController
    Dim _kategori As New KategoriController
    Dim buku As New Buku

    Public Function getBuku() As List(Of Buku)
        Return _buku.getBuku
    End Function

    Public Function getMembers() As List(Of Anggota)
        Return _members.getAnggota
    End Function

    Public Function getKategori() As List(Of Kategori)
        Return _kategori.getKategory
    End Function

    Private Sub SiticonePictureBox1_Click(sender As Object, e As EventArgs) Handles SiticonePictureBox1.Click
        Dim x As Object = MessageBox.Show("Ingin Keluar Aplikasi", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = vbYes Then
            Me.Dispose()
            splash.Dispose()
        End If
    End Sub

    Private Sub Admin_Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SiticonePictureBox2_Click(sender As Object, e As EventArgs) Handles SiticonePictureBox2.Click
        BookManagement.Show()
        Me.Hide()
    End Sub

    Private Sub SiticonePictureBox3_Click(sender As Object, e As EventArgs) Handles SiticonePictureBox3.Click
        MemberManagement.Show()
        Me.Hide()
    End Sub
End Class