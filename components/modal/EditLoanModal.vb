Public Class EditLoanModal

    Private Property customer As Customer

    Private Property classes As List(Of Kelas)

    Private Property prevReturned As Boolean

    Sub New(customer As Customer, kelases As List(Of Kelas))

        InitializeComponent()
        Me.customer = customer
        Me.classes = kelases

        box_customer_name.Text = customer.name
        box_customer_address.Text = customer.address
        box_fines.Value = customer.fines_per_day
        box_date_return.Value = customer.return_at
        box_returned.Checked = customer.is_returned
        prevReturned = customer.is_returned
        kelases.ForEach(Function(data) box_class.Items.Add(data.name))
        box_class.SelectedIndex = kelases.IndexOf(kelases.Where(Function(kelas) kelas.id = customer.identifier.id).FirstOrDefault())

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
        Dim kelas As String = box_class.SelectedItem.ToString().Trim()
        Dim finesPerDay As Integer = Convert.ToInt32(box_fines.Value)
        Dim dateReturned As DateTime = box_date_return.Value
        Dim isReturned As Boolean = box_returned.Checked

        If customerName.Length = 0 Then
            MsgBox("Customer Name cannot be blank!")
        ElseIf customerAddress.Length = 0 Then
            MsgBox("Customer Address cannot be blank!")
        ElseIf finesPerDay = 0 Then
            MsgBox("Fines must greater than 0!")
        Else

            customer.name = customerName
            customer.address = customerAddress
            customer.identifier = classes.ElementAt(box_class.SelectedIndex)
            customer.fines_per_day = finesPerDay
            customer.return_at = dateReturned
            customer.is_returned = isReturned

            Dim result As ReturnMessage = CustomerController.update(customer, prevReturned)

            If result.status = True Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MsgBox(result.message)
            End If


        End If
    End Sub

    Private Sub box_fines_ValueChanged(sender As Object, e As EventArgs) Handles box_fines.ValueChanged

    End Sub

    Private Sub box_date_return_ValueChanged(sender As Object, e As EventArgs) Handles box_date_return.ValueChanged

    End Sub

    Private Sub box_class_SelectedIndexChanged(sender As Object, e As EventArgs) Handles box_class.SelectedIndexChanged

    End Sub

    Private Sub box_customer_name_TextChanged(sender As Object, e As EventArgs) Handles box_customer_name.TextChanged

    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click

    End Sub

    Private Sub Guna2HtmlLabel8_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel8.Click

    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel2.Click

    End Sub

    Private Sub box_customer_address_TextChanged(sender As Object, e As EventArgs) Handles box_customer_address.TextChanged

    End Sub

    Private Sub Guna2HtmlLabel7_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel7.Click

    End Sub

    Private Sub box_returned_CheckedChanged(sender As Object, e As EventArgs) Handles box_returned.CheckedChanged

    End Sub

    Private Sub Guna2HtmlLabel6_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel6.Click

    End Sub

    Private Sub Guna2HtmlLabel5_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel5.Click

    End Sub

    Private Sub Guna2HtmlLabel4_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel4.Click

    End Sub

    Private Sub Guna2HtmlLabel3_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel3.Click

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub Guna2HtmlLabel9_Click(sender As Object, e As EventArgs) Handles mata_uang_label.Click

    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class