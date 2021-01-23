Public Class AdminCard
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim deleteModal As DeleteAdminModal = New DeleteAdminModal()
        deleteModal.ShowDialog()
    End Sub
End Class
