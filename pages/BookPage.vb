Public Class BookPage
    Private Sub Guna2Panel10_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel10.Paint

    End Sub

    Private Sub ListPanel_Paint(sender As Object, e As PaintEventArgs) Handles ListPanel.Paint

        ListPanel.Controls.Clear()

        For i As Integer = 0 To 3
            Dim c As BookCard = New BookCard
            c.Dock = DockStyle.Top
            ListPanel.Controls.Add(c)
        Next

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim abm As AddBookModal = New AddBookModal
        abm.ShowDialog()
    End Sub
End Class