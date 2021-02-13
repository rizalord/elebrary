Public Class AddClassModal
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim classname As String = box_classname.Text.Trim()

        If classname.Length = 0 Then
            MsgBox("Classname cannot be blank!")
        Else

            Dim result As ReturnMessage = ClassController.create(classname)

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