Public Class EditLoanModal2
    Private Property customer As Customer


    Private Property prevReturned As Boolean

    Sub New(customer As Customer)

        InitializeComponent()
        Me.customer = customer

        box_customer_name.Text = customer.name
        box_customer_address.Text = customer.address
        box_fines.Value = customer.fines_per_day
        box_date_return.Value = customer.return_at
        box_returned.Checked = customer.is_returned
        prevReturned = customer.is_returned
        box_idcard.Text = customer.identifier.name

        If Globals.infos(1).value.Equals("USD") Then
            mata_uang_label.Text = "$"
        Else
            mata_uang_label.Text = "Rupiah"
        End If

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btn_show_books_Click(sender As Object, e As EventArgs) Handles btn_show_books.Click
        Dim sb As EditLoanBookModal = New EditLoanBookModal(customer.loans.ToList())
        sb.ShowDialog()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim customerName As String = box_customer_name.Text.Trim()
        Dim customerAddress As String = box_customer_address.Text.Trim()
        Dim idCard As String = box_idcard.Text.ToString().Trim()
        Dim finesPerDay As Integer = Convert.ToInt32(box_fines.Value)
        Dim dateReturned As DateTime = box_date_return.Value
        Dim isReturned As Boolean = box_returned.Checked

        If customerName.Length = 0 Then
            MsgBox("Customer Name cannot be blank!")
        ElseIf customerAddress.Length = 0 Then
            MsgBox("Customer Address cannot be blank!")
        ElseIf idCard.Length = 0 Then
            MsgBox("ID Card cannot be blank!")
        ElseIf finesPerDay = 0 Then
            MsgBox("Fines must greater than 0!")
        Else

            customer.name = customerName
            customer.address = customerAddress
            customer.identifier.name = idCard
            customer.fines_per_day = finesPerDay
            customer.return_at = dateReturned
            customer.is_returned = isReturned

            Dim result As ReturnMessage = CustomerController.update2(customer, prevReturned)

            If result.status = True Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MsgBox(result.message)
            End If


        End If
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class