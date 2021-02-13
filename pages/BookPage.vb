Public Class BookPage
    Private Property page As Integer = 1
    Private Property perPage As Integer = 4
    Private Property isNext As Boolean = False
    Private Property currentCountData As Integer = 0

    Public Sub RefreshForm()
        RetrieveWithReset()
    End Sub

    'Private Sub BookPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    RetrieveWithReset()
    'End Sub

    Private Sub RetrieveWithReset(Optional keyword As String = "")
        page = 1
        perPage = 4
        RetrieveData(keyword)
    End Sub

    Private Sub RetrieveData(Optional keyword As String = "")
        ListPanel.Controls.Clear()

        Dim data As BookResponse = BookController.index(page, perPage, keyword)
        isNext = data.isNext

        data.data.ForEach(Sub(e)

                              Dim c As BookCard = New BookCard(e, AddressOf RetrieveWithReset)
                              c.Dock = DockStyle.Top
                              ListPanel.Controls.Add(c)

                          End Sub)

        currentCountData = data.data.Count()

        managePaginator(data.totalData)

    End Sub

    Private Sub managePaginator(total As Integer)

        If page = 1 Then
            btn_prev.Enabled = False
            btn_prev.Visible = False
        Else
            btn_prev.Enabled = True
            btn_prev.Visible = True
        End If

        If isNext = True Then
            btn_next.Enabled = True
            btn_next.Visible = True
        Else
            btn_next.Enabled = False
            btn_next.Visible = False
        End If

        If page = 1 And currentCountData = 0 Then
            label_totaldata.Text = "Showing " & ((page - 1) * perPage) & " to " & ((page - 1) * perPage) + currentCountData & " of " & total & " results"
        Else
            label_totaldata.Text = "Showing " & ((page - 1) * perPage) + 1 & " to " & ((page - 1) * perPage) + currentCountData & " of " & total & " results"
        End If



    End Sub

    Private Sub btn_add_book_Click(sender As Object, e As EventArgs) Handles btn_add_book.Click
        Dim mdl As AddBookModal = New AddBookModal()

        If mdl.ShowDialog() = DialogResult.OK Then

            RetrieveWithReset()

        End If
    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        page += 1
        RetrieveData()
    End Sub

    Private Sub btn_prev_Click(sender As Object, e As EventArgs) Handles btn_prev.Click
        page -= 1
        RetrieveData()
    End Sub

    Private Sub Guna2Panel10_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel10.Paint

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        BookController.Export()
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        RetrieveWithReset(Guna2TextBox1.Text)
    End Sub
End Class