Public Class EditLoanBookModal

    Dim loans As List(Of Loan)
    Sub New(loans As List(Of Loan))

        InitializeComponent()

        Me.loans = loans

    End Sub

    Private Sub EditLoanBookModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        panel_list.Controls.Clear()

        Me.loans.ForEach(Sub(loan)

                             Dim elbc As New EditLoanBookCard(loan.book.title, loan.quantity)
                             elbc.Dock = DockStyle.Top
                             panel_list.Controls.Add(elbc)

                         End Sub)

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class