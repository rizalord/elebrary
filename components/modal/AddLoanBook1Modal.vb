Public Class AddLoanBook1Modal

    Dim db As New ElebraryContext
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Globals.books.Clear()
        Globals.booksQuantity.Clear()

        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub search_box_KeyPress(sender As Object, e As KeyPressEventArgs) Handles search_box.KeyPress

        Dim keyword As String = search_box.Text.Trim()

        If Char.IsLetter(e.KeyChar) Then
            keyword = keyword + e.KeyChar.ToString()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back) Then
            keyword = keyword.Substring(0, keyword.Length - 1)
        End If

        If keyword.Length = 0 Then
            list_left_panel.Controls.Clear()
        Else
            retrieveSearchedBooks()
        End If


    End Sub

    Sub retrieveSearchedBooks()
        list_left_panel.Controls.Clear()

        Dim keyword As String = search_box.Text.Trim()

        Dim selectedBooks As New List(Of String)

        Globals.books.ForEach(Sub(buku)
                                  selectedBooks.Add(buku.title)
                              End Sub)

        Dim hasilBuku As List(Of Book) = db.Books.Where(Function(buku) buku.title.Contains(keyword)).Where(Function(buku) selectedBooks.Contains(buku.title) = False).Take(10).ToList()

        hasilBuku.ForEach(Sub(buku)

                              Dim singleBook As New LeftLoanBookCard(buku, AddressOf refreshList)
                              singleBook.Dock = DockStyle.Top
                              list_left_panel.Controls.Add(singleBook)

                          End Sub)
    End Sub

    Sub retrieveSelectedBooks()
        list_right_panel.Controls.Clear()


        Globals.books.ForEach(Sub(buku)

                                  Dim singleBook As New RightLoanBookCard(buku, AddressOf refreshList)
                                  singleBook.Dock = DockStyle.Top
                                  list_right_panel.Controls.Add(singleBook)

                              End Sub)

    End Sub



    Private Sub AddLoanBook1Modal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        retrieveSelectedBooks()
    End Sub

    Sub refreshList()
        retrieveSearchedBooks()
        retrieveSelectedBooks()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class