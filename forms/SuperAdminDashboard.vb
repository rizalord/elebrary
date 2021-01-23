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


    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles navbar_dropdown.SelectedIndexChanged
        If navbar_dropdown.SelectedIndex = 0 Then
            SwitchPanel(ProfilePage)
            nav_dashboard.Checked = False
            nav_books.Checked = False
            nav_classes.Checked = False
            nav_loans.Checked = False
            nav_admins.Checked = False
        ElseIf navbar_dropdown.SelectedIndex = 1 Then
            nav_dashboard.Checked = False
            nav_books.Checked = False
            nav_classes.Checked = False
            nav_loans.Checked = False
            nav_admins.Checked = False

            Dim btw As Welcome = New Welcome()
            btw.Show()
            Me.Close()
        End If
    End Sub

End Class