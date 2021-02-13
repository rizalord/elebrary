Public Class LoanPage
    Private Property page As Integer = 1
    Private Property perPage As Integer = 4
    Private Property isNext As Boolean = False
    Private Property currentCountData As Integer = 0

    Private Sub LoanPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RetrieveWithReset()
    End Sub

    Private Sub RetrieveWithReset(Optional keyword As String = "")
        page = 1
        perPage = 4
        RetrieveData(keyword)
    End Sub

    Private Sub RetrieveData(Optional keyword As String = "")
        ListPanel.Controls.Clear()

        Dim data As CustomerResponse = CustomerController.index(page, perPage, keyword)
        isNext = data.isNext

        data.data.ForEach(Sub(e)

                              Dim timeNow As Long = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond
                              Dim timeReturn As Long = e.return_at.Ticks / TimeSpan.TicksPerMillisecond

                              Dim exceedTime As Boolean = False
                              Dim daysPassed As Integer

                              If timeNow > timeReturn Then

                                  Dim timeLeft As Long = timeNow - timeReturn
                                  daysPassed = Convert.ToInt32(Math.Ceiling(timeLeft / 86400000))
                                  exceedTime = True

                              End If


                              If e.is_returned Then
                                  Dim c As LoanCard3 = New LoanCard3(e, AddressOf RetrieveWithReset)
                                  c.Dock = DockStyle.Top
                                  ListPanel.Controls.Add(c)
                              ElseIf e.is_returned = False And exceedTime = True Then
                                  Dim c As LoanCard2 = New LoanCard2(e, AddressOf RetrieveWithReset, daysPassed)
                                  c.Dock = DockStyle.Top
                                  ListPanel.Controls.Add(c)
                              Else
                                  Dim c As LoanCard1 = New LoanCard1(e, AddressOf RetrieveWithReset)
                                  c.Dock = DockStyle.Top
                                  ListPanel.Controls.Add(c)
                              End If


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

        If page = 1 And currentCountData = 0 Then
            label_totaldata.Text = "Showing " & ((page - 1) * perPage) & " to " & ((page - 1) * perPage) + currentCountData & " of " & total & " results"
        Else
            label_totaldata.Text = "Showing " & ((page - 1) * perPage) + 1 & " to " & ((page - 1) * perPage) + currentCountData & " of " & total & " results"
        End If



    End Sub

    Private Sub btn_add_loan_Click(sender As Object, e As EventArgs) Handles btn_add_loan.Click

        Dim db As New ElebraryContext

        Dim classes As List(Of Kelas) = db.Classes.ToList()

        If classes.Count = 0 Then
            MsgBox("Please add some class before add new loan!")
        ElseIf db.Books.Count = 0 Then
            MsgBox("Please add some books before add new loan!")
        Else
            Dim alm As AddLoanModal = New AddLoanModal(classes)

            If alm.ShowDialog() = DialogResult.OK Then

                RetrieveWithReset()

            End If
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

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        CustomerController.Export()
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        RetrieveWithReset(Guna2TextBox1.Text)
    End Sub
End Class