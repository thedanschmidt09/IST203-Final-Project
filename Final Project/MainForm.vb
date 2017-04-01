Public Class MainForm

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnLease_Click(sender As Object, e As EventArgs) Handles btnLease.Click

        LeaseForm.ShowDialog()

    End Sub

    Private Sub btnBuy_Click(sender As Object, e As EventArgs) Handles btnBuy.Click

        BuyForm.ShowDialog()

    End Sub

End Class
