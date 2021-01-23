Public Class Welcome
    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        main_button.Text = "LOGIN"
    End Sub

    Private Sub main_button_Click(sender As Object, e As EventArgs) Handles main_button.Click
        Dim login As LoginModal = New LoginModal()
        If login.ShowDialog() = DialogResult.OK Then
            Dim dashboard As SuperAdminDashboard = New SuperAdminDashboard()
            dashboard.Show()
            Me.Hide()
        End If
    End Sub
End Class
