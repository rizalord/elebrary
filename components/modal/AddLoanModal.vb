Public Class AddLoanModal
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btn_load_books_Click(sender As Object, e As EventArgs) Handles btn_load_books.Click
        Dim mdl As AddLoanBook1Modal = New AddLoanBook1Modal()
        mdl.ShowDialog()
    End Sub
End Class