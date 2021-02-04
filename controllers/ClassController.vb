Module ClassController
    Private Property db As New ElebraryContext

    Public Function index(Optional page As Integer = 1, Optional perPage As Integer = 4) As ClassResponse

        page -= 1

        Dim listData As List(Of Kelas) = db.Classes.OrderByDescending(Function(e) e.id).Skip(page * perPage).Take(perPage).ToList()
        Dim countNext As Integer = db.Classes.OrderByDescending(Function(e) e.id).Skip((page + 1) * perPage).Take(perPage).ToList().Count
        Dim isNext As Boolean = countNext > 0 And countNext <= perPage
        Dim totalData As Integer = db.Classes.Count()

        listData.Reverse()

        Return New ClassResponse(listData, isNext, totalData)

    End Function

    Public Function create(ByVal classname As String) As ReturnMessage
        Try

            If classname.Length = 0 Then
                Return New ReturnMessage(False, "Classname cannot be blank!")
            Else


                Dim kelas As New Kelas
                kelas.name = classname
                kelas.created_at = DateTime.Now
                kelas.updated_at = DateTime.Now

                db.Classes.Add(kelas)
                db.SaveChanges()


            End If

        Catch ex As Exception

            Return New ReturnMessage(False, "There's something wrong, Please try again later!")
        End Try

        Return New ReturnMessage(True)
    End Function

    Public Function update(ByVal kelas As Kelas) As ReturnMessage
        Try

            If kelas.name.Length = 0 Then
                Return New ReturnMessage(False, "Classname cannot be blank!")
            Else


                Dim retrievedKelas As Kelas = db.Classes.Where(Function(e) e.id = kelas.id).FirstOrDefault()
                retrievedKelas.name = kelas.name

                db.SaveChanges()

            End If

        Catch ex As Exception

            Return New ReturnMessage(False, "There's something wrong, Please try again later!")
        End Try

        Return New ReturnMessage(True)
    End Function

    Public Sub delete(kelas As Kelas)
        db.Classes.Remove(kelas)
        db.SaveChanges()
    End Sub


    Class ClassResponse
        Public Property data As List(Of Kelas)
        Public Property isNext As Boolean
        Public Property totalData As Integer

        Sub New(data As List(Of Kelas), isNext As Boolean, total As Integer)
            Me.data = data
            Me.isNext = isNext
            Me.totalData = total
        End Sub

    End Class
End Module
