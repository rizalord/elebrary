Public Class ClassCard

    Private Property dataKelas As Kelas
    Dim closure As Action

    Sub New(kelas As Kelas, cls As Action)

        InitializeComponent()

        dataKelas = kelas
        closure = cls

        label_id.Text = kelas.id.ToString()
        label_title.Text = kelas.name
        label_tanggal.Text = kelas.updated_at.ToString("dd-MM-yyyy")

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim editModal As EditClassModal = New EditClassModal(dataKelas)

        If editModal.ShowDialog() = DialogResult.OK Then
            closure()
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim db As New ElebraryContext

        Dim count As Integer = db.Customers.Include("loans").Include("identifier").Where(Function(customer) customer.is_returned = False And customer.identifier.id = dataKelas.id).Count()

        If count > 0 Then
            MsgBox("Class is still used in loan, cannot be deleted!")
        Else

            Dim deleteModal As DeleteClassModal = New DeleteClassModal(dataKelas)

            If deleteModal.ShowDialog() = DialogResult.OK Then
                closure()
            End If

        End If


    End Sub

End Class
