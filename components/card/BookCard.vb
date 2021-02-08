Public Class BookCard

    Private Property dataBuku As Book
    Dim closure As Action

    Sub New(buku As Book, cls As Action)

        InitializeComponent()

        dataBuku = buku
        closure = cls

        label_id.Text = buku.id.ToString()
        label_title.Text = buku.title
        label_author.Text = buku.author
        label_qnt.Text = buku.stock.ToString()

    End Sub

    Private Sub btn_detail_Click(sender As Object, e As EventArgs) Handles btn_detail.Click
        Dim dbm As DetailBookModal = New DetailBookModal(dataBuku)
        dbm.ShowDialog()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim ebm As EditBookModal = New EditBookModal(dataBuku)

        If ebm.ShowDialog() = DialogResult.OK Then
            closure()
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim db As New ElebraryContext

        Dim count As Integer = db.Customers.Include("loans").Include("loans.book").Where(Function(customer) customer.is_returned = False).SelectMany(Function(customer) customer.loans).Where(Function(loan) loan.book.id = dataBuku.id).Count()

        If count > 0 Then
            MsgBox("Book are still being borrowed, it cannot be deleted!")
        Else

            Dim dbm As DeleteBookModal = New DeleteBookModal(dataBuku)

            If dbm.ShowDialog() = DialogResult.OK Then
                closure()
            End If

        End If

    End Sub

End Class
