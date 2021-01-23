Public Class LoanPage
    Private Sub ListPanel_Paint(sender As Object, e As PaintEventArgs) Handles ListPanel.Paint
        ListPanel.Controls.Clear()
        Dim ids As Integer() = {1, 2, 3, 1}

        For i As Integer = 0 To 3
            If ids(i) = 3 Then
                Dim c As LoanCard3 = New LoanCard3
                c.Dock = DockStyle.Top
                ListPanel.Controls.Add(c)
            ElseIf ids(i) = 2 Then
                Dim c As LoanCard2 = New LoanCard2
                c.Dock = DockStyle.Top
                ListPanel.Controls.Add(c)
            Else
                Dim c As LoanCard1 = New LoanCard1
                c.Dock = DockStyle.Top
                ListPanel.Controls.Add(c)
            End If

        Next
    End Sub

    Private Sub btn_add_loan_Click(sender As Object, e As EventArgs) Handles btn_add_loan.Click
        Dim alm As AddLoanModal = New AddLoanModal()
        alm.ShowDialog()
    End Sub
End Class