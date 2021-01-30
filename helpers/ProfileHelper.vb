Module ProfileHelper
    Dim context As New ElebraryContext

    Public Function SaveProfile(fullname As String, username As String) As ReturnMessage

        fullname = fullname.Trim()
        username = username.Trim()

        If fullname.Length = 0 Then
            Return New ReturnMessage(False, "Name is too short!")
        ElseIf username.Length = 0 Then
            Return New ReturnMessage(False, "Username is too short!")
        ElseIf InStr(username, " ") > 0 Then
            Return New ReturnMessage(False, "Username cannot contain space!")
        Else

            Dim user As Admin = (From admin In context.Admins Where admin.username = username Select admin).FirstOrDefault

            If user Is Nothing Or Globals.user.username = username Then

                Try

                    Dim admin As Admin = Globals.user

                    Dim realAdmin As Admin = (From a In context.Admins Where a.id = admin.id Select a).FirstOrDefault
                    realAdmin.fullname = fullname
                    realAdmin.username = username

                    Globals.user = realAdmin
                    context.SaveChanges()
                    refresh()

                    Return New ReturnMessage(True, "")

                Catch ex As Exception

                    Return New ReturnMessage(False, "Something Wrong, Please try again later!")

                End Try




            Else
                Return New ReturnMessage(False, "Username already exist!")
            End If

        End If


    End Function


    Public Function SavePassword(currentpassword As String, newpassword As String, newpasswordconfirmation As String) As ReturnMessage

        currentpassword = currentpassword.Trim()
        newpassword = newpassword.Trim()
        newpasswordconfirmation = newpasswordconfirmation.Trim()

        If currentpassword.Length <= 6 Then
            Return New ReturnMessage(False, "Current Password is too short!")
        ElseIf newpassword.Length <= 6 Then
            Return New ReturnMessage(False, "New Password is too short!")
        ElseIf newpasswordconfirmation.Equals(newpassword) = False Then
            Return New ReturnMessage(False, "New Password does'nt match!")
        Else
            Dim encriptor As New EncryptHelper(currentpassword)
            Dim realCurrentPassword As String = encriptor.DecryptData(Globals.user.password)

            If currentpassword.Equals(realCurrentPassword) Then

                Try

                    Dim newEncriptor As New EncryptHelper(newpassword)

                    Dim realAdmin As Admin = (From a In context.Admins Where a.id = Globals.user.id Select a).FirstOrDefault
                    realAdmin.password = newEncriptor.EncryptData(newpassword)

                    Globals.user = realAdmin
                    context.SaveChanges()
                    refresh()

                    Return New ReturnMessage(True, "")

                Catch ex As Exception

                    Return New ReturnMessage(False, "Something Wrong, Please try again later!")

                End Try

            Else

                Return New ReturnMessage(False, "Current Password is wrong!")

            End If


        End If


    End Function

    Class ReturnMessage
        Public Property status As Boolean
        Public Property message As String

        Sub New(sts As Boolean, Optional msg As String = "")
            status = sts
            message = msg
        End Sub
    End Class

    Public Sub refresh()
        context.Dispose()
        context = New ElebraryContext
    End Sub


End Module
