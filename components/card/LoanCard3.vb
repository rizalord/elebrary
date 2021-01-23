Public Class LoanCard3
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim elm As EditLoanModal = New EditLoanModal()
        elm.ShowDialog()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim dlm As DeleteLoanModal = New DeleteLoanModal()
        dlm.ShowDialog()
    End Sub
End Class
