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
End Class