Public Class LeftLoanBookCard

    Dim buku As Book
    Dim closure As Action

    Sub New(pBuku As Book, closure As Action)

        InitializeComponent()

        buku = pBuku
        Me.closure = closure

        box_title.Text = pBuku.title + "(" + pBuku.stock.ToString() + ")"

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim modal As New AddLoanBook2Modal(buku)

        If modal.ShowDialog = DialogResult.OK Then
            closure()
        End If

    End Sub

End Class
