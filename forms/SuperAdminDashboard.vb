Public Class SuperAdminDashboard
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SuperAdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchPanel(DashboardPage)
    End Sub

    Private Sub SwitchPanel(ByVal panel As Form)
        MainPanel.Controls.Clear()
        panel.TopLevel = False
        MainPanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub nav_dashboard_Click(sender As Object, e As EventArgs) Handles nav_dashboard.Click
        SwitchPanel(DashboardPage)
    End Sub

    Private Sub nav_books_Click(sender As Object, e As EventArgs) Handles nav_books.Click
        SwitchPanel(BookPage)
    End Sub

    Private Sub nav_loans_Click(sender As Object, e As EventArgs) Handles nav_loans.Click
        SwitchPanel(LoanPage)
    End Sub

    Private Sub nav_classes_Click(sender As Object, e As EventArgs) Handles nav_classes.Click
        SwitchPanel(ClassesPage)
    End Sub

    Private Sub nav_admins_Click(sender As Object, e As EventArgs) Handles nav_admins.Click
        SwitchPanel(AdminPage)
    End Sub
End Class