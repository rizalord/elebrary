Public Class ClassesPage
    Private Sub ListPanel_Paint(sender As Object, e As PaintEventArgs) Handles ListPanel.Paint
        ListPanel.Controls.Clear()

        For i As Integer = 0 To 3
            Dim c As ClassCard = New ClassCard
            c.Dock = DockStyle.Top
            ListPanel.Controls.Add(c)
        Next
    End Sub

    Private Sub btn_add_class_Click(sender As Object, e As EventArgs) Handles btn_add_class.Click
        Dim mdl As AddClassModal = New AddClassModal()
        mdl.ShowDialog()
    End Sub
End Class