Public Class LoanCard3
    Private Property dataCustomer As Customer
    Dim closure As Action

    Sub New(pCustomer As Customer, cls As Action)

        InitializeComponent()

        dataCustomer = pCustomer
        closure = cls

        label_id.Text = dataCustomer.id.ToString()
        label_title.Text = dataCustomer.name
        label_class.Text = dataCustomer.identifier.name
        label_date.Text = dataCustomer.created_at.ToString("dd-MM-yyyy")

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        Dim db As New ElebraryContext

        Dim classes As List(Of Kelas) = db.Classes.ToList()

        Dim elm As EditLoanModal = New EditLoanModal(dataCustomer, classes)

        If elm.ShowDialog() = DialogResult.OK Then
            closure()
        End If

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim dlm As DeleteLoanModal = New DeleteLoanModal(dataCustomer)

        If dlm.ShowDialog() = DialogResult.OK Then
            closure()
        End If

    End Sub

End Class
