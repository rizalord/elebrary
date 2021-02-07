Public Class RightLoanBookCard
    Dim buku As Book
    Dim closure As Action

    Sub New(pBuku As Book, closure As Action)

        InitializeComponent()

        buku = pBuku
        Me.closure = closure

        Dim stock As Integer = Globals.booksQuantity.ElementAt(Globals.books.IndexOf(buku))

        box_title.Text = pBuku.title + "(" + stock.ToString() + ")"

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim index As Integer = Globals.books.IndexOf(buku)

        Globals.books.RemoveAt(index)
        Globals.booksQuantity.RemoveAt(index)

        closure()
    End Sub
End Class
