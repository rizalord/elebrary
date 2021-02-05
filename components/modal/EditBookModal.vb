Public Class EditBookModal

    Private Property buku As Book

    Sub New(buku As Book)

        InitializeComponent()
        Me.buku = buku

        box_title.Text = buku.title
        box_author.Text = buku.author
        box_publisher.Text = buku.publisher
        box_publishedat.Value = buku.published_at.Date
        box_stock.Value = Convert.ToDecimal(buku.stock)
        box_featured.Checked = buku.is_featured

    End Sub
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim title As String = box_title.Text.Trim()
        Dim author As String = box_author.Text.Trim()
        Dim publisher As String = box_publisher.Text.Trim()
        Dim publishedAt As DateTime = box_publishedat.Value.Date
        Dim stock As Integer = Convert.ToInt32(box_stock.Value)
        Dim featured As Boolean = box_featured.Checked

        If title.Length = 0 Then
            MsgBox("Title cannot be blank!")
        ElseIf author.Length = 0 Then
            MsgBox("Author cannot be blank!")
        ElseIf publisher.Length = 0 Then
            MsgBox("Publisher cannot be blank!")
        ElseIf publishedAt = Nothing Then
            MsgBox("Published At cannot be blank!")
        ElseIf stock <= 0 Then
            MsgBox("Stock must greater than 0!")
        Else

            buku.title = title
            buku.author = author
            buku.publisher = publisher
            buku.published_at = publishedAt
            buku.stock = stock
            buku.is_featured = featured

            Dim result As ReturnMessage = BookController.update(buku)

            If result.status = True Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MsgBox(result.message)
            End If


        End If
    End Sub
End Class