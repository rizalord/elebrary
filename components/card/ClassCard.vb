Public Class ClassCard
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim mdl As EditClassModal = New EditClassModal()
        mdl.ShowDialog()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim mdl As DeleteClassModal = New DeleteClassModal()
        mdl.ShowDialog()
    End Sub
End Class
