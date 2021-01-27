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

    Public Function login(ByVal username As String, ByVal password As String) As Boolean

        Dim match As Admin = (From admin In context.Admins Where admin.username = username Select admin).FirstOrDefault

        If match IsNot Nothing Then

            Dim encryptor As New EncryptHelper(password)

            Dim adminPassword As String = match.password
            Dim adminRealPassword As String = encryptor.DecryptData(adminPassword)


            If password.Equals(adminRealPassword) = False Then

                Dim loger As New LoginAttempt
                loger.attempts = 1
                loger.last_login = DateTime.Now

                context.LoginAttempts.Add(loger)
                context.SaveChanges()

                Return False
            End If

            context.LoginAttempts.RemoveRange(context.LoginAttempts)
            context.SaveChanges()

            Return True


        End If

        Dim log As New LoginAttempt
        log.attempts = 1
        log.last_login = DateTime.Now

        context.LoginAttempts.Add(log)
        context.SaveChanges()

        Return False

    End Function

    Public Function count_logs() As Integer
        Return context.LoginAttempts.Count
    End Function

    Public Function last_login() As DateTime
        'Return context.LoginAttempts.Last().last_login.Millisecond
        Return context.LoginAttempts.OrderByDescending(Function(p) p.id).First.last_login
    End Function




End Module
