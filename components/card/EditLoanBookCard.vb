Public Class EditLoanBookCard

    Sub New(mTitle As String, quantity As Integer)

        InitializeComponent()

        title.Text = mTitle + " (" + quantity.ToString() + ")"

    End Sub


End Class
