﻿Module AdminController
    Private Property db As New ElebraryContext

    Public Function index(Optional page As Integer = 1, Optional perPage As Integer = 4, Optional keyword As String = "") As AdminResponse

        page -= 1

        Dim listData As List(Of Admin) = db.Admins.Where(Function(e) e.role.id = 1 And (e.username.Contains(keyword) Or e.fullname.Contains(keyword) Or e.id.ToString().Contains(keyword))).OrderByDescending(Function(e) e.id).Skip(page * perPage).Take(perPage).ToList()
        Dim countNext As Integer = db.Admins.Where(Function(e) e.role.id = 1 And (e.username.Contains(keyword) Or e.fullname.Contains(keyword) Or e.id.ToString().Contains(keyword))).OrderByDescending(Function(e) e.id).Skip((page + 1) * perPage).Take(perPage).ToList().Count
        Dim isNext As Boolean = countNext > 0 And countNext <= perPage
        Dim totalData As Integer = db.Admins.Where(Function(e) e.role.id = 1).Count()

        listData.Reverse()

        Return New AdminResponse(listData, isNext, totalData)

    End Function

    Public Sub delete(admin As Admin)
        db.Admins.Remove(admin)

        Dim log As New AdminLog
        log.title = Globals.user.fullname + " has remove an admin"
        log.subtitle = Globals.user.fullname + " remove " + admin.fullname + " from admins."
        log.icon_id = 1
        log.created_at = DateTime.Now
        log.updated_at = DateTime.Now
        log.admin = Globals.user

        db.Admins.Attach(Globals.user)

        db.AdminLogs.Add(log)

        db.SaveChanges()
    End Sub


    Class AdminResponse
        Public Property data As List(Of Admin)
        Public Property isNext As Boolean
        Public Property totalData As Integer

        Sub New(data As List(Of Admin), isNext As Boolean, total As Integer)
            Me.data = data
            Me.isNext = isNext
            Me.totalData = total
        End Sub

    End Class
End Module
