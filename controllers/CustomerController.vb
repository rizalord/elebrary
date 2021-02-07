Imports System.Data.Entity

Module CustomerController
    Private Property db As New ElebraryContext

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

                newDb.Customers.Add(customer)
                newDb.SaveChanges()

            End If

        Catch ex As Exception
            MsgBox(ex.InnerException.Message)
            Return New ReturnMessage(False, "There's something wrong, Please try again later!")
        End Try

        Return New ReturnMessage(True)
    End Function

    Public Function update(ByVal customer As Customer) As ReturnMessage
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
                                                             db.Books.Attach(loan.book)
                                                         End Sub)

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
        db.SaveChanges()
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
