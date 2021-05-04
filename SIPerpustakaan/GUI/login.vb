Public Class login
    Private Sub GunaCirclePictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SiticonePictureBox1_Click(sender As Object, e As EventArgs) Handles SiticonePictureBox1.Click
        Dim x As Object = MessageBox.Show("Ingin Keluar Aplikasi", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = vbYes Then
            Me.Dispose()
            splash.Dispose()
        End If
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If Username.Text = "" Or Password.Text = "" Then
            MessageBox.Show("Isi Username atau Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If Username.Text = "" And Password.Text <> "" Then
                Username.Focus()
            ElseIf Username.Text <> "" And Password.Text = "" Then
                Password.Focus()
            Else
                Username.Focus()
            End If
        ElseIf Username.Text = "admin" And Password.Text = "admin" Then
                Me.Hide()
            Admin_Panel.Show()
        End If
    End Sub
End Class