Public Class AdminPage
    Private Sub ListPanel_Paint(sender As Object, e As PaintEventArgs) Handles ListPanel.Paint
        ListPanel.Controls.Clear()

        For i As Integer = 0 To 3
            Dim c As AdminCard = New AdminCard
            c.Dock = DockStyle.Top
            ListPanel.Controls.Add(c)
        Next
    End Sub

    Private Sub btn_add_admin_Click(sender As Object, e As EventArgs) Handles btn_add_admin.Click
        Dim modal As AddAdminModal = New AddAdminModal()

        If modal.ShowDialog() = DialogResult.OK Then


        End If


    End Sub

End Class