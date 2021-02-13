Public Class EditBookModal

    Private Property buku As Book

    Private Property globalStock As String

    Sub New(buku As Book)

        InitializeComponent()
        Me.buku = buku

        box_title.Text = buku.title
        box_author.Text = buku.author
        box_publisher.Text = buku.publisher
        box_publishedat.Value = buku.published_at.Date
        box_stock.Value = Convert.ToDecimal(buku.stock)
        box_featured.Checked = buku.is_featured
        globalStock = buku.stock.ToString()

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
        Dim stock As String = globalStock
        Dim featured As Boolean = box_featured.Checked


        If title.Length = 0 Then
            MsgBox("Title cannot be blank!")
        ElseIf author.Length = 0 Then
            MsgBox("Author cannot be blank!")
        ElseIf publisher.Length = 0 Then
            MsgBox("Publisher cannot be blank!")
        ElseIf publishedAt = Nothing Then
            MsgBox("Published At cannot be blank!")
        ElseIf stock.Length = 0 Then
            MsgBox("Stock must greater than 0!")
        Else

            buku.title = title
            buku.author = author
            buku.publisher = publisher
            buku.published_at = publishedAt
            buku.stock = Convert.ToInt32(stock)
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

    Private Sub box_stock_ValueChanged(sender As Object, e As EventArgs) Handles box_stock.ValueChanged
        globalStock = box_stock.Value.ToString()
    End Sub

    Private Sub box_stock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles box_stock.KeyPress

        If Char.IsNumber(e.KeyChar) Then
            globalStock = globalStock.ToString() + e.KeyChar.ToString()
        ElseIf Asc(e.KeyChar) = 8 Then
            Try
                If globalStock.Length > 0 Then
                    globalStock = globalStock.ToString().Substring(0, globalStock.ToString().Length - 1)
                End If

            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class