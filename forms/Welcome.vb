Public Class Welcome

    Private Property isSetup As Boolean = False

    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        set_button_state(AuthHelper.isSetup)

    End Sub

    Private Sub set_button_state(isLogin As Boolean)
        isSetup = isLogin

        If isSetup Then
            main_button.Text = "LOGIN"
        Else
            main_button.Text = "GET STARTED"
        End If

    End Sub

    Private Sub main_button_Click(sender As Object, e As EventArgs) Handles main_button.Click

        If isSetup Then

            handle_btn_login()

        Else

            handle_btn_setup()

        End If

    End Sub

    Private Sub handle_btn_login()
        Dim loginDialog As LoginModal = New LoginModal()
        Go(loginDialog)
    End Sub

    Private Sub handle_btn_setup()
        Dim setupDialog As SetupModal = New SetupModal()
        Go(setupDialog)
    End Sub

    Private Sub Go(fm As Form)
        If fm.ShowDialog() = DialogResult.OK Then
            Dim dashboard As SuperAdminDashboard = New SuperAdminDashboard()
            dashboard.Show()
            Me.Hide()
        End If
    End Sub
End Class
