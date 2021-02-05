Public Class DeleteBookModal

    Private Property buku As Book

    Sub New(pBuku As Book)

        InitializeComponent()
        buku = pBuku

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        BookController.delete(buku)
        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub


    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class