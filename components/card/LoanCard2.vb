Public Class LoanCard2
    Private Property dataCustomer As Customer
    Dim closure As Action
    Dim dayPass As Integer
    Dim fine As Integer
    Dim totalFine As Integer

    Sub New(pCustomer As Customer, cls As Action, daysPassed As Integer)

        InitializeComponent()

        dataCustomer = pCustomer
        closure = cls

        dayPass = daysPassed
        fine = dataCustomer.fines_per_day
        totalFine = dayPass * fine

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

    Private Sub btn_fine_Click(sender As Object, e As EventArgs) Handles btn_fine.Click
        Dim fine As DetailFineModal = New DetailFineModal(dayPass, Me.fine, totalFine)
        fine.ShowDialog()
    End Sub
End Class
