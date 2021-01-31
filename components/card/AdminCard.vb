Public Class AdminCard

    Private Property dataAdmin As Admin
    Dim closure As Action

    Sub New(admin As Admin, cls As Action)

        InitializeComponent()

        dataAdmin = admin
        closure = cls

        label_id.Text = admin.id.ToString()
        label_fullname.Text = admin.fullname
        label_username.Text = admin.username
        label_date.Text = admin.created_at.ToString("dd-MM-yyyy")

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim deleteModal As DeleteAdminModal = New DeleteAdminModal(dataAdmin)

        If deleteModal.ShowDialog() = DialogResult.OK Then
            closure()
        End If
    End Sub

End Class
