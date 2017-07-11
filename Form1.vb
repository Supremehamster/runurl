Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            System.Diagnostics.Process.Start("http://m-b-a.biz#last")
        Catch
            'Code to handle the error.
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Application.Exit()
        End
    End Sub
End Class
