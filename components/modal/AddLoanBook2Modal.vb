Public Class AddLoanBook2Modal

    Dim buku As Book

    Sub New(pBuku As Book)

        InitializeComponent()

        buku = pBuku

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If box_quantity.Value > buku.stock Then
            MsgBox("The amount to be borrowed must not exceed the stock!")
        Else
            Globals.books.Add(buku)
            Globals.booksQuantity.Add(box_quantity.Value)

            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If

    End Sub
End Class