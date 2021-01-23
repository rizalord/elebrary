Public Class EditLoanModal
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btn_show_books_Click(sender As Object, e As EventArgs) Handles btn_show_books.Click
        Dim sb As EditLoanBookModal = New EditLoanBookModal()
        sb.ShowDialog()
    End Sub
End Class