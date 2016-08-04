Public Class progress

    Private Sub progress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        ProgressBar1.Value = Timer1.Interval
    End Sub
End Class