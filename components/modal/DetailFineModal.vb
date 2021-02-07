Public Class DetailFineModal

    Sub New(daypass As Integer, fine As Integer, totalFine As Integer)

        InitializeComponent()

        label_day.Text = daypass
        label_fine.Text = fine
        label_total.Text = totalFine

    End Sub
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class