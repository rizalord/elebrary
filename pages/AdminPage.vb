Public Class AdminPage
    Private Sub ListPanel_Paint(sender As Object, e As PaintEventArgs) Handles ListPanel.Paint
        ListPanel.Controls.Clear()

        For i As Integer = 0 To 3
            Dim c As AdminCard = New AdminCard
            c.Dock = DockStyle.Top
            ListPanel.Controls.Add(c)
        Next
    End Sub
End Class