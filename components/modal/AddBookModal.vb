Public Class AddBookModal

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim title As String = box_title.Text.Trim()
        Dim author As String = box_author.Text.Trim()
        Dim publisher As String = box_publisher.Text.Trim()
        Dim publishedAt As DateTime = box_publishedat.Value.Date
        Dim stock As Integer = Convert.ToInt32(box_stock.Value)
        Dim featured As Boolean = box_featured.Checked

        If title.Length = 0 Then
            MsgBox("Title cannot be blank!")
        ElseIf author.Length = 0 Then
            MsgBox("Author cannot be blank!")
        ElseIf publisher.Length = 0 Then
            MsgBox("Publisher cannot be blank!")
        ElseIf publishedAt = Nothing Then
            MsgBox("Published At cannot be blank!")
        ElseIf stock <= 0 Then
            MsgBox("Stock must greater than 0!")
        Else

            Dim result As ReturnMessage = BookController.create(title, author, publisher, publishedAt, stock, featured)

            If result.status = True Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MsgBox(result.message)
            End If


        End If
    End Sub
End Class