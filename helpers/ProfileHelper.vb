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

                    Return New ReturnMessage(True, "")

                Catch ex As Exception

                    Return New ReturnMessage(False, "Something Wrong, Please try again later!")

                End Try




            Else
                Return New ReturnMessage(False, "Username already exist!")
            End If

        End If


    End Function

    Class ReturnMessage
        Public Property status As Boolean
        Public Property message As String

        Sub New(sts As Boolean, msg As String)
            status = sts
            message = msg
        End Sub
    End Class


End Module
