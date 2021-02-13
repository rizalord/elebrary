Public Class DetailBookModal

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
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class