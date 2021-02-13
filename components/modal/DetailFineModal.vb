Public Class DetailFineModal

    Sub New(daypass As Integer, fine As Integer, totalFine As Integer)

        InitializeComponent()

        label_day.Text = daypass

        If Globals.infos(1).value.Equals("USD") Then
            label_fine.Text = "$" & fine
            label_total.Text = "$" & totalFine
        Else
            label_fine.Text = "Rp. " & fine
            label_total.Text = "Rp. " & totalFine
        End If

    End Sub
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class