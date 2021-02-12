Imports System.Data.Entity
Imports System.IO
Imports OfficeOpenXml

Module CustomerController
    Private Property db As ElebraryContext

    Sub New()
        db = Globals.globalDb
    End Sub

    Public Function index(Optional page As Integer = 1, Optional perPage As Integer = 4) As CustomerResponse

        page -= 1

        Dim listData As List(Of Customer) = db.Customers.Include("loans").Include("identifier").Include("loans.book").OrderByDescending(Function(e) e.id).Skip(page * perPage).Take(perPage).ToList()
        Dim countNext As Integer = db.Customers.OrderByDescending(Function(e) e.id).Skip((page + 1) * perPage).Take(perPage).ToList().Count
        Dim isNext As Boolean = countNext > 0 And countNext <= perPage
        Dim totalData As Integer = db.Customers.Count()

        listData.Reverse()

        Return New CustomerResponse(listData, isNext, totalData)

    End Function

    Public Function create(ByVal customerName As String, ByVal customerAddress As String, ByVal kelas As String, ByVal finesPerDay As Integer, ByVal dateReturned As DateTime, ByVal isReturned As Boolean, books As List(Of Book), booksQuantity As List(Of Integer)) As ReturnMessage
        Try

            If customerName.Length = 0 Then
                MsgBox("Customer Name cannot be blank!")
            ElseIf customerAddress.Length = 0 Then
                MsgBox("Customer Address cannot be blank!")
            ElseIf finesPerDay = 0 Then
                MsgBox("Fines must greater than 0!")
            ElseIf Globals.books.Count = 0 Then
                MsgBox("Books to be borrowed cannot be empty!")
            Else

                Dim loans As New List(Of Loan)

                books.ForEach(Sub(buku)

                                  Dim loan As New Loan
                                  loan.book = buku
                                  loan.quantity = Globals.booksQuantity.ElementAt(Globals.books.IndexOf(buku))
                                  loan.created_at = DateTime.Now
                                  loan.updated_at = DateTime.Now
                                  loans.Add(loan)

                                  If isReturned = False Then

                                      Dim getBook As Book = db.Books.Where(Function(book) book.id = buku.id).FirstOrDefault()
                                      getBook.stock = getBook.stock - loan.quantity

                                      db.SaveChanges()
                                      db.Entry(getBook).Reload()

                                  End If

                              End Sub)

                Dim customer As New Customer
                customer.name = customerName
                customer.address = customerAddress
                customer.identifier = db.Classes.Where(Function(e) e.name = kelas).FirstOrDefault()
                customer.fines_per_day = finesPerDay
                customer.is_returned = isReturned
                customer.return_at = dateReturned
                customer.loans = loans
                customer.created_at = DateTime.Now
                customer.updated_at = DateTime.Now

                Dim newDb As New ElebraryContext

                customer.loans.ToList().ForEach(Sub(loan)
                                                    newDb.Books.Attach(loan.book)
                                                End Sub)

                newDb.Classes.Attach(customer.identifier)

                newDb.Customers.Add(customer)


                Dim log As New AdminLog
                log.title = customer.name + " has loan some books"
                log.subtitle = Globals.user.fullname + " added new loan."
                log.icon_id = 2
                log.created_at = DateTime.Now
                log.updated_at = DateTime.Now
                log.admin = Globals.user

                newDb.Admins.Attach(Globals.user)

                newDb.AdminLogs.Add(log)


                newDb.SaveChanges()

            End If

        Catch ex As Exception
            MsgBox(ex.InnerException.Message)
            Return New ReturnMessage(False, "There's something wrong, Please try again later!")
        End Try

        Return New ReturnMessage(True)
    End Function

    Public Function update(ByVal customer As Customer, ByVal prevReturned As Boolean) As ReturnMessage
        Try

            If customer.name.Length = 0 Then
                MsgBox("Customer Name cannot be blank!")
            ElseIf customer.address.Length = 0 Then
                MsgBox("Customer Address cannot be blank!")
            ElseIf customer.fines_per_day = 0 Then
                MsgBox("Fines must greater than 0!")
            Else


                Dim retrievedCustomer As Customer = db.Customers.Where(Function(e) e.id = customer.id).FirstOrDefault()

                retrievedCustomer.name = customer.name
                retrievedCustomer.address = customer.address
                retrievedCustomer.identifier = db.Classes.Where(Function(e) e.name = customer.identifier.name).FirstOrDefault()
                retrievedCustomer.fines_per_day = customer.fines_per_day
                retrievedCustomer.is_returned = customer.is_returned
                retrievedCustomer.return_at = customer.return_at
                retrievedCustomer.updated_at = DateTime.Now



                retrievedCustomer.loans.ToList().ForEach(Sub(loan)

                                                             If prevReturned = False And customer.is_returned = True Then

                                                                 Dim getBook As Book = db.Books.Where(Function(book) book.id = loan.book.id).FirstOrDefault()
                                                                 getBook.stock = getBook.stock + loan.quantity

                                                                 db.SaveChanges()

                                                             ElseIf prevReturned = True And customer.is_returned = False Then

                                                                 Dim getBook As Book = db.Books.Where(Function(book) book.id = loan.book.id).FirstOrDefault()
                                                                 getBook.stock = getBook.stock - loan.quantity

                                                                 db.SaveChanges()

                                                             End If

                                                         End Sub)

                retrievedCustomer.loans.ToList().ForEach(Sub(loan) db.Books.Attach(loan.book))

                db.Classes.Attach(retrievedCustomer.identifier)

                Dim log As New AdminLog
                log.title = Globals.user.fullname + " has edited a loan"
                log.subtitle = Globals.user.fullname + " edited a loan with Id " + retrievedCustomer.id.ToString()
                log.icon_id = 2
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

    Public Sub delete(customer As Customer)
        db.Loans.RemoveRange(customer.loans)
        db.Customers.Remove(customer)

        Dim log As New AdminLog
        log.title = Globals.user.fullname + " has deleted a loan"
        log.subtitle = Globals.user.fullname + " deleted a loan with Id " + customer.id.ToString()
        log.icon_id = 2
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

            Dim file As FileInfo = New FileInfo("C:\Temp\tempLoan.xlsx")
            file.Delete()
            file = New FileInfo("C:\Temp\tempLoan.xlsx")

            Using package As New ExcelPackage(file)


                Dim sheet As ExcelWorksheet = package.Workbook.Worksheets.Add("Main Sheet")


                sheet.Cells("A1").Value = "NO"
                sheet.Cells("B1").Value = "ID"
                sheet.Cells("C1").Value = "NAME"
                sheet.Cells("D1").Value = "ADDRESS"
                sheet.Cells("E1").Value = "CLASS"
                sheet.Cells("F1").Value = "FINES/DAY"
                sheet.Cells("G1").Value = "RETURN DATE"
                sheet.Cells("H1").Value = "IS RETURNED"
                sheet.Cells("I1").Value = "CREATED AT"

                sheet.Cells("A1:I1").Style.HorizontalAlignment = HorizontalAlignment.Center
                sheet.Cells("A1:I1").Style.Border.Top.Style = Style.ExcelBorderStyle.Thin
                sheet.Cells("A1:I1").Style.Border.Bottom.Style = Style.ExcelBorderStyle.Thin
                sheet.Cells("A1:I1").Style.Border.Left.Style = Style.ExcelBorderStyle.Thin
                sheet.Cells("A1:I1").Style.Border.Right.Style = Style.ExcelBorderStyle.Thin

                sheet.Cells("A1:I1").Style.Font.Bold = True

                sheet.Cells("A2:I2").Style.HorizontalAlignment = HorizontalAlignment.Center
                sheet.Cells("A2:I2").Style.Border.Top.Style = Style.ExcelBorderStyle.Thin
                sheet.Cells("A2:I2").Style.Border.Bottom.Style = Style.ExcelBorderStyle.Thin
                sheet.Cells("A2:I2").Style.Border.Left.Style = Style.ExcelBorderStyle.Thin
                sheet.Cells("A2:I2").Style.Border.Right.Style = Style.ExcelBorderStyle.Thin

                sheet.Column(7).Width = 21
                sheet.Column(8).Width = 15
                sheet.Column(9).Width = 21

                Dim customers As List(Of Customer) = db.Customers.Include("loans").Include("identifier").ToList()
                customers.ForEach(Sub(e)

                                      Dim index As Integer = customers.IndexOf(e) + 3

                                      sheet.Cells("A" & index).Value = index - 2
                                      sheet.Cells("A" & index).Style.HorizontalAlignment = HorizontalAlignment.Right

                                      sheet.Cells("B" & index).Value = e.id
                                      sheet.Cells("B" & index).Style.HorizontalAlignment = HorizontalAlignment.Center

                                      sheet.Cells("C" & index).Value = e.name
                                      sheet.Cells("D" & index).Value = e.address

                                      sheet.Cells("E" & index).Value = e.identifier.name
                                      sheet.Cells("E" & index).Style.HorizontalAlignment = HorizontalAlignment.Center

                                      sheet.Cells("F" & index).Value = e.fines_per_day
                                      sheet.Cells("G" & index).Value = e.return_at.ToString("MM/dd/yyyy h:mm:ss")
                                      sheet.Cells("H" & index).Value = e.is_returned
                                      sheet.Cells("I" & index).Value = e.created_at.ToString("MM/dd/yyyy h:mm:ss")

                                      sheet.Cells("A" & index & ":I" & index).Style.Border.Top.Style = Style.ExcelBorderStyle.Thin
                                      sheet.Cells("A" & index & ":I" & index).Style.Border.Bottom.Style = Style.ExcelBorderStyle.Thin
                                      sheet.Cells("A" & index & ":I" & index).Style.Border.Left.Style = Style.ExcelBorderStyle.Thin
                                      sheet.Cells("A" & index & ":I" & index).Style.Border.Right.Style = Style.ExcelBorderStyle.Thin

                                  End Sub)

                package.Save()
            End Using

            Using sfd As New SaveFileDialog

                sfd.Filter = "Excel files (*.xlsx)|*.xlsx"
                sfd.FilterIndex = 0
                sfd.RestoreDirectory = True

                If sfd.ShowDialog() = DialogResult.OK Then

                    Dim source As String = "C:\Temp\tempLoan.xlsx"
                    Dim destination As String = sfd.FileName

                    My.Computer.FileSystem.MoveFile(source, destination)

                Else

                    Dim filek As FileInfo = New FileInfo("C:\Temp\tempLoan.xlsx")
                    filek.Delete()

                End If
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)

            Dim file As FileInfo = New FileInfo("C:\Temp\tempLoan.xlsx")
            file.Delete()
        End Try



    End Sub


    Class CustomerResponse
        Public Property data As List(Of Customer)
        Public Property isNext As Boolean
        Public Property totalData As Integer

        Sub New(data As List(Of Customer), isNext As Boolean, total As Integer)
            Me.data = data
            Me.isNext = isNext
            Me.totalData = total
        End Sub

    End Class
End Module
