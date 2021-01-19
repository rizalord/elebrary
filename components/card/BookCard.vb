Public Class BookCard
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim ebm As EditBookModal = New EditBookModal
        ebm.ShowDialog()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim ebm As DeleteBookModal = New DeleteBookModal
        ebm.ShowDialog()
    End Sub
End Class
