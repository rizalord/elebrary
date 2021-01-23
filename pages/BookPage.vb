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

    Private Sub btn_add_book_Click(sender As Object, e As EventArgs) Handles btn_add_book.Click
        Dim abm As AddBookModal = New AddBookModal()
        If abm.ShowDialog() = DialogResult.OK Then

        End If
    End Sub
End Class