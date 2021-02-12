Imports System.IO
Imports OfficeOpenXml

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

    Sub Export()
        Try
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial

            Dim file As FileInfo = New FileInfo("C:\Temp\tempBooks.xlsx")
            file.Delete()
            file = New FileInfo("C:\Temp\tempBooks.xlsx")

            Using package As New ExcelPackage(file)


                Dim sheet As ExcelWorksheet = package.Workbook.Worksheets.Add("Main Sheet")


                sheet.Cells("A1").Value = "NO"
                sheet.Cells("B1").Value = "ID"
                sheet.Cells("C1").Value = "TITLE"
                sheet.Cells("D1").Value = "AUTHOR"
                sheet.Cells("E1").Value = "PUBLISHER"
                sheet.Cells("F1").Value = "STOCK"
                sheet.Cells("G1").Value = "PUBLISHED AT"
                sheet.Cells("H1").Value = "CREATED AT"

                sheet.Cells("A1:H1").Style.HorizontalAlignment = HorizontalAlignment.Center
                sheet.Cells("A1:H1").Style.Border.Top.Style = Style.ExcelBorderStyle.Thin
                sheet.Cells("A1:H1").Style.Border.Bottom.Style = Style.ExcelBorderStyle.Thin
                sheet.Cells("A1:H1").Style.Border.Left.Style = Style.ExcelBorderStyle.Thin
                sheet.Cells("A1:H1").Style.Border.Right.Style = Style.ExcelBorderStyle.Thin

                sheet.Cells("A1:H1").Style.Font.Bold = True

                sheet.Cells("A2:H2").Style.HorizontalAlignment = HorizontalAlignment.Center
                sheet.Cells("A2:H2").Style.Border.Top.Style = Style.ExcelBorderStyle.Thin
                sheet.Cells("A2:H2").Style.Border.Bottom.Style = Style.ExcelBorderStyle.Thin
                sheet.Cells("A2:H2").Style.Border.Left.Style = Style.ExcelBorderStyle.Thin
                sheet.Cells("A2:H2").Style.Border.Right.Style = Style.ExcelBorderStyle.Thin

                sheet.Column(3).Width = 35
                sheet.Column(4).Width = 25
                sheet.Column(5).Width = 15
                sheet.Column(7).Width = 24
                sheet.Column(8).Width = 24

                Dim books As List(Of Book) = db.Books.ToList()
                books.ForEach(Sub(e)

                                  Dim index As Integer = books.IndexOf(e) + 3

                                  sheet.Cells("A" & index).Value = index - 2
                                  sheet.Cells("A" & index).Style.HorizontalAlignment = HorizontalAlignment.Right

                                  sheet.Cells("B" & index).Value = e.id
                                  sheet.Cells("B" & index).Style.HorizontalAlignment = HorizontalAlignment.Center

                                  sheet.Cells("C" & index).Value = e.title
                                  sheet.Cells("D" & index).Value = e.author

                                  sheet.Cells("E" & index).Value = e.publisher

                                  sheet.Cells("F" & index).Value = e.stock
                                  sheet.Cells("F" & index).Style.HorizontalAlignment = HorizontalAlignment.Center

                                  sheet.Cells("G" & index).Value = e.published_at.ToString("MM/dd/yyyy h:mm:ss")
                                  sheet.Cells("G" & index).Style.HorizontalAlignment = HorizontalAlignment.Center

                                  sheet.Cells("H" & index).Value = e.created_at.ToString("MM/dd/yyyy h:mm:ss")
                                  sheet.Cells("H" & index).Style.HorizontalAlignment = HorizontalAlignment.Center

                                  sheet.Cells("A" & index & ":H" & index).Style.Border.Top.Style = Style.ExcelBorderStyle.Thin
                                  sheet.Cells("A" & index & ":H" & index).Style.Border.Bottom.Style = Style.ExcelBorderStyle.Thin
                                  sheet.Cells("A" & index & ":H" & index).Style.Border.Left.Style = Style.ExcelBorderStyle.Thin
                                  sheet.Cells("A" & index & ":H" & index).Style.Border.Right.Style = Style.ExcelBorderStyle.Thin

                              End Sub)

                package.Save()
            End Using

            Using sfd As New SaveFileDialog

                sfd.Filter = "Excel files (*.xlsx)|*.xlsx"
                sfd.FilterIndex = 0
                sfd.RestoreDirectory = True

                If sfd.ShowDialog() = DialogResult.OK Then

                    Dim source As String = "C:\Temp\tempBooks.xlsx"
                    Dim destination As String = sfd.FileName

                    My.Computer.FileSystem.MoveFile(source, destination)

                Else

                    Dim filek As FileInfo = New FileInfo("C:\Temp\tempBooks.xlsx")
                    filek.Delete()

                End If
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)

            Dim file As FileInfo = New FileInfo("C:\Temp\tempLoan.xlsx")
            file.Delete()
        End Try



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
