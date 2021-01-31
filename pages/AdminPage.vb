Public Class AdminPage

    Private Property page As Integer = 1
    Private Property perPage As Integer = 4
    Private Property isNext As Boolean = False
    Private Property currentCountData As Integer = 0

    Private Sub AdminPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RetrieveWithReset()
    End Sub

    Private Sub RetrieveWithReset()
        page = 1
        perPage = 4
        RetrieveData()
    End Sub

    Private Sub RetrieveData()
        ListPanel.Controls.Clear()

        Dim data As AdminResponse = AdminController.index(page, perPage)
        isNext = data.isNext

        data.data.ForEach(Sub(e)

                              Dim c As AdminCard = New AdminCard(e)
                              c.Dock = DockStyle.Top
                              ListPanel.Controls.Add(c)

                          End Sub)

        currentCountData = data.data.Count()

        managePaginator(data.totalData)

    End Sub

    Private Sub managePaginator(total As Integer)

        If page = 1 Then
            btn_prev.Enabled = False
            btn_prev.Visible = False
        Else
            btn_prev.Enabled = True
            btn_prev.Visible = True
        End If

        If isNext = True Then
            btn_next.Enabled = True
            btn_next.Visible = True
        Else
            btn_next.Enabled = False
            btn_next.Visible = False
        End If

        label_totaldata.Text = "Showing " & ((page - 1) * perPage) + 1 & " to " & ((page - 1) * perPage) + currentCountData & " of " & total & " results"

    End Sub

    Private Sub btn_add_admin_Click(sender As Object, e As EventArgs) Handles btn_add_admin.Click
        Dim modal As AddAdminModal = New AddAdminModal()

        If modal.ShowDialog() = DialogResult.OK Then

            RetrieveWithReset()

        End If
    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        page += 1
        RetrieveData()
    End Sub

    Private Sub btn_prev_Click(sender As Object, e As EventArgs) Handles btn_prev.Click
        page -= 1
        RetrieveData()
    End Sub
End Class