Public Class SetupModal

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click

        Dim username As String = username_box.Text.Trim()
        Dim password As String = password_box.Text.Trim()
        Dim target As String = target_projects.SelectedItem.ToString().Trim()
        Dim currency As String = currencies.SelectedItem.ToString().Trim()

        If username.Length = 0 Then
            MsgBox("Username cannot be blank!")
        ElseIf password.Length <= 8 Then
            MsgBox("Password is too short! (Min: 8)")
        ElseIf password_confirmation_box.Text.Trim().Length = 0 Then
            MsgBox("Password Confirmation cannot be blank!")
        ElseIf password.Equals(password_box.Text.Trim()) = False Then
            MsgBox("Password doesn't match!")
        ElseIf AuthHelper.setup(username, password, target, currency) Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MsgBox("Something's wrong, Please try again later.")
        End If
    End Sub

End Class