Public Class DashboardPage

    Private Sub Guna2HtmlLabel6_Click(sender As Object, e As EventArgs) Handles label_total_books.Click

    End Sub

    Private Sub Guna2HtmlLabel13_Click(sender As Object, e As EventArgs) Handles label_popular_name.Click

    End Sub

    Private Sub Guna2Panel16_Paint(sender As Object, e As PaintEventArgs) Handles panel_history.Paint
        Dim ids As Integer() = {3, 2, 1}
        Dim titles As String() = {"David join as Admin", "David join as Admin", "David join as Admin"}
        Dim subtitles As String() = {"David has been added as admin by Master.", "David has been added as admin by Master.", "David has been added as admin by Master."}
        Dim dates As String() = {"05 Juni 2021", "04 April 2021", "01 January 2021"}

        For i As Integer = 0 To 2
            SetHistoryById(ids(i), titles(i), subtitles(i), dates(i))
        Next
    End Sub

    Private Sub SetHistoryById(ByVal id As Integer, ByVal title As String, ByVal subtitle As String, ByVal datelabel As String)
        If id = 1 Then
            Dim c As HistoryCard1 = New HistoryCard1
            c.Dock = DockStyle.Top
            c.title.Text = title
            c.subtitle.Text = subtitle
            c.date_label.Text = datelabel
            panel_history.Controls.Add(c)
        ElseIf id = 2 Then
            Dim c As HistoryCard2 = New HistoryCard2
            c.Dock = DockStyle.Top
            c.title.Text = title
            c.subtitle.Text = subtitle
            c.date_label.Text = datelabel
            panel_history.Controls.Add(c)
        ElseIf id = 3 Then
            Dim c As HistoryCard3 = New HistoryCard3
            c.Dock = DockStyle.Top
            c.title.Text = title
            c.subtitle.Text = subtitle
            c.date_label.Text = datelabel
            panel_history.Controls.Add(c)
        End If

    End Sub

    Private Sub DashboardPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim db As New ElebraryContext

        Dim totalBooks As Integer = db.Books.Count()
        Dim totalAdmins As Integer = db.Admins.Count()

        Dim borrowedBooks As Integer = 0
        db.Customers.Include("loans").Where(Function(customer) customer.is_returned = True).ToList().ForEach(Sub(customer) customer.loans.ToList().ForEach(Sub(loan) borrowedBooks += loan.quantity))

        Dim featuredBook As Book = db.Books.Where(Function(book) book.is_featured = True).FirstOrDefault()
        Dim popularBookId As Integer = db.Loans.Include("book").GroupBy(Function(loan) loan.book.id).OrderByDescending(Function(loan) loan.Count()).Take(1).Select(Function(loan) loan.Key).FirstOrDefault()
        Dim popularBook As Book = db.Books.Where(Function(book) book.id = popularBookId).FirstOrDefault()

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
        Else
            label_popular_name.Text = popularBook.title
        End If

        If recentlyBook Is Nothing Then
            label_recently_book.Text = "-"
        Else
            label_recently_book.Text = recentlyBook.title
        End If



    End Sub
End Class