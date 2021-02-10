Module BookController
    Private Property db As ElebraryContext

    Sub New()
        db = Globals.globalDb
    End Sub

    Public Function index(Optional page As Integer = 1, Optional perPage As Integer = 4) As BookResponse

        page -= 1

        Dim listData As List(Of Book) = db.Books.OrderByDescending(Function(e) e.id).Skip(page * perPage).Take(perPage).ToList()
        Dim countNext As Integer = db.Books.OrderByDescending(Function(e) e.id).Skip((page + 1) * perPage).Take(perPage).ToList().Count
        Dim isNext As Boolean = countNext > 0 And countNext <= perPage
        Dim totalData As Integer = db.Books.Count()

        listData.Reverse()


        Return New BookResponse(listData, isNext, totalData)

    End Function

    Public Function create(ByVal title As String, ByVal author As String, ByVal publisher As String, ByVal publishedAt As DateTime, ByVal stock As Integer, ByVal isFeatured As Boolean) As ReturnMessage
        Try

            If title.Length = 0 Then
                Return New ReturnMessage(False, "Title cannot be blank!")
            ElseIf author.Length = 0 Then
                Return New ReturnMessage(False, "Author cannot be blank!")
            ElseIf publisher.Length = 0 Then
                Return New ReturnMessage(False, "Publisher cannot be blank!")
            ElseIf publishedAt = Nothing Then
                Return New ReturnMessage(False, "Published At cannot be blank!")
            ElseIf stock <= 0 Then
                Return New ReturnMessage(False, "Stock must greater than 0!")
            Else

                Globals.books.Clear()
                Globals.booksQuantity.Clear()


                Dim book As New Book
                book.title = title
                book.author = author
                book.publisher = publisher
                book.published_at = publishedAt
                book.stock = stock
                book.is_featured = isFeatured
                book.created_at = DateTime.Now
                book.updated_at = DateTime.Now

                db.Books.Add(book)
                db.SaveChanges()

                Dim log As New AdminLog
                log.title = Globals.user.fullname + " has added new book"
                log.subtitle = Globals.user.fullname + " addded book with Id " + book.id.ToString()
                log.icon_id = 3
                log.created_at = DateTime.Now
                log.updated_at = DateTime.Now
                log.admin = Globals.user

                db.Admins.Attach(Globals.user)

                db.AdminLogs.Add(log)

                db.SaveChanges()


            End If

        Catch ex As Exception

            Return New ReturnMessage(False, "There's something wrong, Please try again later!")
        End Try

        Return New ReturnMessage(True)
    End Function

    Public Function update(ByVal book As Book) As ReturnMessage
        Try

            If book.title.Length = 0 Then
                Return New ReturnMessage(False, "Title cannot be blank!")
            ElseIf book.author.Length = 0 Then
                Return New ReturnMessage(False, "Author cannot be blank!")
            ElseIf book.publisher.Length = 0 Then
                Return New ReturnMessage(False, "Publisher cannot be blank!")
            ElseIf book.published_at = Nothing Then
                Return New ReturnMessage(False, "Published At cannot be blank!")
            ElseIf book.stock <= 0 Then
                Return New ReturnMessage(False, "Stock must greater than 0!")
            Else

                Globals.books.Clear()
                Globals.booksQuantity.Clear()

                Dim retrievedBook As Book = db.Books.Where(Function(e) e.id = book.id).FirstOrDefault()
                retrievedBook.title = book.title
                retrievedBook.author = book.author
                retrievedBook.publisher = book.publisher
                retrievedBook.published_at = book.published_at
                retrievedBook.stock = book.stock
                retrievedBook.is_featured = book.is_featured
                retrievedBook.updated_at = DateTime.Now

                Dim log As New AdminLog
                log.title = Globals.user.fullname + " has edited a book"
                log.subtitle = Globals.user.fullname + " edited book with Id " + book.id.ToString()
                log.icon_id = 3
                log.created_at = DateTime.Now
                log.updated_at = DateTime.Now
                log.admin = Globals.user

                db.Admins.Attach(Globals.user)

                db.AdminLogs.Add(log)

                db.SaveChanges()



            End If

        Catch ex As Exception

            Return New ReturnMessage(False, "There's something wrong, Please try again later!")
        End Try

        Return New ReturnMessage(True)
    End Function

    Public Sub delete(kelas As Book)
        db.Books.Remove(kelas)

        Dim log As New AdminLog
        log.title = Globals.user.fullname + " has delete a book"
        log.subtitle = Globals.user.fullname + " deleted a book with Id " + kelas.id.ToString()
        log.icon_id = 3
        log.created_at = DateTime.Now
        log.updated_at = DateTime.Now
        log.admin = Globals.user

        db.Admins.Attach(Globals.user)

        db.AdminLogs.Add(log)

        db.SaveChanges()
    End Sub

    Private Sub dispose()
        db.Dispose()
        db = Nothing
        db = New ElebraryContext
    End Sub


    Class BookResponse
        Public Property data As List(Of Book)
        Public Property isNext As Boolean
        Public Property totalData As Integer

        Sub New(data As List(Of Book), isNext As Boolean, total As Integer)
            Me.data = data
            Me.isNext = isNext
            Me.totalData = total
        End Sub

    End Class
End Module
