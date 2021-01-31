Public Class DeleteAdminModal

    Private Property admin As Admin

    Sub New(pAdmin As Admin)

        InitializeComponent()
        admin = pAdmin

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        AdminController.delete(admin)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class