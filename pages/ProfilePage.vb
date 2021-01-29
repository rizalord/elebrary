Imports VB = Microsoft.VisualBasic
Public Class ProfilePage

    Dim updateName As Action(Of String)

    Private Sub ProfilePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        name_label.Text = Globals.user.fullname
        username_label.Text = Globals.user.username

    End Sub

    Sub New(closure As Action(Of String))

        InitializeComponent()

        updateName = closure

    End Sub

    Private Sub btn_save_information_Click(sender As Object, e As EventArgs) Handles btn_save_information.Click
        Dim result As ReturnMessage = ProfileHelper.SaveProfile(name_label.Text.ToString(), username_label.Text.ToString())

        If result.status Then

            result_profile.Visible = True
            updateName(Globals.user.fullname)
            wait(1.5)
            result_profile.Visible = False

        Else

            MsgBox(result.message)

        End If
    End Sub

    Public Sub wait(ByVal seconds As Single)
        Static start As Single
        start = VB.Timer()
        Do While VB.Timer() < start + seconds
            Application.DoEvents()
        Loop
    End Sub

    Private Sub btn_save_password_Click(sender As Object, e As EventArgs) Handles btn_save_password.Click
        Dim result As ReturnMessage = ProfileHelper.SavePassword(currentpassword_label.Text.ToString(), newpassword_label.Text.ToString(), confirmpassword_label.Text.ToString())

        If result.status Then

            currentpassword_label.Text = ""
            newpassword_label.Text = ""
            confirmpassword_label.Text = ""

            result_password.Visible = True
            wait(1.5)
            result_password.Visible = False

        Else

            MsgBox(result.message)

        End If
    End Sub
End Class