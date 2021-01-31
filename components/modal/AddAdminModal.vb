Public Class AddAdminModal
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        Dim fullname As String = fullname_label.Text.Trim()
        Dim username As String = username_label.Text.Trim()
        Dim password As String = password_label.Text.Trim()

        If fullname.Length = 0 Then
            MsgBox("Fullname cannot be blank!")
        ElseIf username.Length = 0 Then
            MsgBox("Username cannot be blank!")
        ElseIf InStr(username, " ") > 0 Then
            MsgBox("Username contain empty space!")
        ElseIf password.Length <= 8 Then
            MsgBox("Password is too short! (Min: 8)")
        Else

            Dim result As ReturnMessage = AuthHelper.createAdmin(fullname, username, password)

            If result.status = True Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MsgBox(result.message)
            End If


        End If


    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class