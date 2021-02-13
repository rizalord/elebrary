Public Class AddLoanModal

    Dim daftarKelas As List(Of Kelas)

    Sub New(kelases As List(Of Kelas))

        InitializeComponent()

        daftarKelas = kelases

        daftarKelas.ForEach(Function(data) box_class.Items.Add(data.name))

        box_class.SelectedIndex = 0

        If Globals.infos(1).value.Equals("USD") Then
            mata_uang_label.Text = "$"
        Else
            mata_uang_label.Text = "Rupiah"
        End If

    End Sub
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Globals.books.Clear()
        Globals.booksQuantity.Clear()

        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btn_load_books_Click(sender As Object, e As EventArgs) Handles btn_load_books.Click
        Dim mdl As AddLoanBook1Modal = New AddLoanBook1Modal()
        mdl.ShowDialog()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
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
        ElseIf Globals.books.Count = 0 Then
            MsgBox("Books to be borrowed cannot be empty!")
        Else

            Dim result As ReturnMessage = CustomerController.create(customerName, customerAddress, kelas, finesPerDay, dateReturned, isReturned, Globals.books, Globals.booksQuantity)

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