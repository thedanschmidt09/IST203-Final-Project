Public Class BuyForm

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub cboVehicle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVehicle.SelectedIndexChanged



    End Sub

    Private Sub cboEngine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEngine.SelectedIndexChanged



    End Sub

    Private Sub cboMake_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMake.SelectedIndexChanged



    End Sub

    Private Sub BuyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VehicleSelectionDataSet.BuyInventory' table. You can move, or remove it, as needed.
        Me.BuyInventoryTableAdapter.Fill(Me.VehicleSelectionDataSet.BuyInventory)

    End Sub
End Class