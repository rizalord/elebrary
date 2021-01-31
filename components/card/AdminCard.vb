Public Class AdminCard

    Sub New(admin As Admin)

        InitializeComponent()

        label_id.Text = admin.id.ToString()
        label_fullname.Text = admin.fullname
        label_username.Text = admin.username
        label_date.Text = admin.created_at.ToString("dd-MM-yyyy")

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim deleteModal As DeleteAdminModal = New DeleteAdminModal()
        deleteModal.ShowDialog()
    End Sub

End Class
