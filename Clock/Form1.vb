Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()
        Label2.Text = DateTime.Now.ToString("MMMM dd, yyyy")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now.ToString("HH:mm")
    End Sub

End Class
