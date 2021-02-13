Public Class LoginModal
    Private Sub LoginModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        suffel_captcha()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        Dim username As String = username_box.Text.Trim()
        Dim password As String = password_box.Text.Trim()
        Dim captchaInput As String = captcha_box.Text.Trim()
        Dim captchaText As String = captcha_text.Text.Trim()

        If username.Length = 0 Then
            MsgBox("Username cannot be blank!")
        ElseIf password.Length = 0 Then
            MsgBox("Password cannot be blank!")
        ElseIf captchaInput.Length = 0 Then
            MsgBox("Captcha cannot be blank!")
        ElseIf captchaInput.Equals(captchaText) = False Then
            'password_box.Text = ""
            captcha_box.Text = ""
            suffel_captcha()
        Else

            Dim count As Integer = AuthHelper.count_logs

            If count > 2 Then

                Dim time As Long = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond
                Dim minutes As Long = Convert.ToInt64(900000 * (count - 3))
                Dim lastLogin As Long = AuthHelper.last_login().Ticks / TimeSpan.TicksPerMillisecond


                If lastLogin + minutes > time Then
                    Dim minuteLeft As Integer = Math.Ceiling((((lastLogin + minutes) - time) / 1000) / 60)
                    MsgBox("Cannot login, Please wait " + minuteLeft.ToString() + " minutes.")

                Else

                    If AuthHelper.login(username, password) = False Then
                        MsgBox("Username or Password is wrong!")
                        captcha_box.Text = ""
                        suffel_captcha()
                    Else
                        Me.DialogResult = DialogResult.OK
                        Me.Hide()
                    End If

                End If

            Else

                If AuthHelper.login(username, password) = False Then
                    MsgBox("Username or Password is wrong!")
                    captcha_box.Text = ""
                    suffel_captcha()
                Else
                    Me.DialogResult = DialogResult.OK
                    Me.Hide()
                End If

            End If




        End If
    End Sub

    Private Sub suffel_captcha()
        captcha_text.Text = GetRandomString()
    End Sub

    Private Function GetRandomString() As String
        Dim pass As String = String.Empty
        Dim AllowedChars() As String = {"ABCDEFGHJKLMNPQRSTWXYZ", "0123456789"}
        Dim rnd = New Random()
        While pass.Length < 6
            Dim rndSet As Integer = rnd.Next(0, AllowedChars.Length)
            pass &= AllowedChars(rndSet).Substring(rnd.Next(0, AllowedChars(rndSet).Length), 1)
        End While
        Return pass
    End Function


End Class