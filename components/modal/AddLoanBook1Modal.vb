Public Class AddLoanBook1Modal
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim nd As AddLoanBook2Modal = New AddLoanBook2Modal()
        nd.ShowDialog()
    End Sub
End Class