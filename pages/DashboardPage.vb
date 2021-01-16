Public Class DashboardPage
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Guna2HtmlLabel6_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel6.Click

    End Sub

    Private Sub Guna2HtmlLabel13_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel13.Click

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
End Class