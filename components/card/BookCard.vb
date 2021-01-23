Public Class BookCard

    Private Sub btn_detail_Click(sender As Object, e As EventArgs) Handles btn_detail.Click
        Dim dbm As DetailBookModal = New DetailBookModal()
        dbm.ShowDialog()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim ebm As EditBookModal = New EditBookModal()
        ebm.ShowDialog()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim dbm As DeleteBookModal = New DeleteBookModal()
        dbm.ShowDialog()
    End Sub
End Class
