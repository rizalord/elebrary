Module AuthHelper

    Dim context As ElebraryContext = New ElebraryContext

    Public Function isSetup() As Boolean

        Return context.ApplicationInfos.Count() > 0

    End Function

    Public Function setup(ByVal username As String, ByVal password As String, ByVal target As String, ByVal currency As String) As Boolean
        Try
            Dim saRole As Role

            For i As Integer = 1 To 2

                Dim role As Role = New Role
                role.id = i
                role.name = IIf(i = 1, "Admin", "Super Admin")
                role.created_at = DateTime.Now
                role.updated_at = DateTime.Now

                context.Roles.Add(role)

                If i = 2 Then
                    saRole = role
                    context.SaveChanges()
                End If

            Next


            Dim encriptor As New EncryptHelper(password)

            Dim admin As Admin = New Admin()
            admin.username = username
            admin.fullname = "Super Admin"
            admin.password = encriptor.EncryptData(password)
            admin.role = saRole
            admin.created_at = DateTime.Now
            admin.updated_at = DateTime.Now


            Dim ai1 As ApplicationInfo = New ApplicationInfo
            ai1.key = "target"
            ai1.value = target
            ai1.created_at = DateTime.Now
            ai1.updated_at = DateTime.Now

            Dim ai2 As ApplicationInfo = New ApplicationInfo
            ai2.key = "currency"
            ai2.value = currency
            ai2.created_at = DateTime.Now
            ai2.updated_at = DateTime.Now

            context.Admins.Add(admin)
            context.ApplicationInfos.Add(ai1)
            context.ApplicationInfos.Add(ai2)
            context.SaveChanges()


        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.InnerException.Message)
            context.Roles.RemoveRange(context.Roles)
            context.Admins.RemoveRange(context.Admins)
            context.ApplicationInfos.RemoveRange(context.ApplicationInfos)
            context.SaveChanges()

            Return False
        End Try

        Return True
    End Function




End Module
