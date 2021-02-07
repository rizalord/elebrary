Public Class DashboardPage

    Private Sub Guna2HtmlLabel6_Click(sender As Object, e As EventArgs) Handles label_total_books.Click

    End Sub

    Private Sub Guna2HtmlLabel13_Click(sender As Object, e As EventArgs) Handles label_popular_name.Click

    End Sub

    Private Sub Guna2Panel16_Paint(sender As Object, e As PaintEventArgs) Handles panel_history.Paint

        Dim db As New ElebraryContext

        Dim totalBooks As Integer = db.Books.Count()
        Dim totalAdmins As Integer = db.Admins.Count()

        Dim borrowedBooks As Integer = 0
        db.Customers.Include("loans").Where(Function(customer) customer.is_returned = True).ToList().ForEach(Sub(customer) customer.loans.ToList().ForEach(Sub(loan) borrowedBooks += loan.quantity))

        Dim featuredBook As Book = db.Books.Where(Function(book) book.is_featured = True).FirstOrDefault()
        Dim popularBookId As Integer = db.Loans.Include("book").GroupBy(Function(loan) loan.book.id).OrderByDescending(Function(loan) loan.Count()).Take(1).Select(Function(loan) loan.Key).FirstOrDefault()
        Dim popularBook As Book = db.Books.Where(Function(book) book.id = popularBookId).FirstOrDefault()
        Dim popularCount As Integer = db.Loans.Where(Function(loan) loan.book.id = popularBookId).Count()

        Dim lastWeek As Date = DateTime.Now.Date.AddDays(-7)

        Dim recentlyBookId As Integer = db.Loans.Include("book").Where(Function(loan) loan.created_at > lastWeek).GroupBy(Function(loan) loan.book.id).OrderByDescending(Function(loan) loan.Count()).Take(1).Select(Function(loan) loan.Key).FirstOrDefault()
        Dim recentlyBook As Book = db.Books.Where(Function(book) book.id = recentlyBookId).FirstOrDefault()


        label_total_books.Text = totalBooks.ToString() + "+"
        label_total_admins.Text = totalAdmins.ToString() + "+"
        label_borrowed_books.Text = borrowedBooks.ToString() + "+"

        If featuredBook Is Nothing Then
            label_featured_book.Text = "-"
        Else
            label_featured_book.Text = featuredBook.title
        End If

        If popularBook Is Nothing Then
            label_popular_name.Text = "-"
            label_popular_time.Text = "-"
        Else
            label_popular_name.Text = popularBook.title
            label_popular_time.Text = "Borrowed " + popularCount.ToString() + " times"
        End If

        If recentlyBook Is Nothing Then
            label_recently_book.Text = "-"
        Else
            label_recently_book.Text = recentlyBook.title
        End If

        panel_history.Controls.Clear()

        Dim logs As List(Of AdminLog) = db.AdminLogs.OrderByDescending(Function(log) log.created_at).Take(3).ToList()
        logs.Reverse()



        If logs.Count = 0 Then
            label_empty.Visible = True
        Else
            label_empty.Visible = False
        End If

        logs.ForEach(Sub(log) SetHistory(log))


    End Sub

    Private Sub SetHistory(ByVal log As AdminLog)
        If log.icon_id = 1 Then
            Dim c As HistoryCard1 = New HistoryCard1
            c.Dock = DockStyle.Top
            c.label_title.Text = log.title
            c.label_subtitle.Text = log.subtitle
            c.label_date.Text = log.created_at.ToString("dd-MM-yyyy")
            panel_history.Controls.Add(c)
        ElseIf log.icon_id = 2 Then
            Dim c As HistoryCard2 = New HistoryCard2
            c.Dock = DockStyle.Top
            c.label_title.Text = log.title
            c.label_subtitle.Text = log.subtitle
            c.label_date.Text = log.created_at.ToString("dd-MM-yyyy")
            panel_history.Controls.Add(c)
        ElseIf log.icon_id = 3 Then
            Dim c As HistoryCard3 = New HistoryCard3
            c.Dock = DockStyle.Top
            c.label_title.Text = log.title
            c.label_subtitle.Text = log.subtitle
            c.label_date.Text = log.created_at.ToString("dd-MM-yyyy")
            panel_history.Controls.Add(c)
        End If

    End Sub
End Class