Public Class splash
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If SiticoneProgressBar1.Value <= 30 Then
            SiticoneProgressBar1.Increment(2)
        ElseIf SiticoneProgressBar1.Value > 30 And SiticoneProgressBar1.Value <= 60 Then
            SiticoneProgressBar1.Increment(4)
        ElseIf SiticoneProgressBar1.Value >= 100 Then
            Timer1.Stop()
            Me.Hide()
            login.Show()

        Else
            SiticoneProgressBar1.Increment(4)
        End If
    End Sub

    Private Sub splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SiticoneProgressBar1.Value = 0
        Timer1.Start()
    End Sub
End Class