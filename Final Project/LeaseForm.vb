Public Class LeaseForm
    Private mTypes As New BuyVehicleTypes
    Private mCylinders As New BuyVehicleCylinders
    Private mMake As New BuyVehicleMake

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub cboVehicle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVehicle.SelectedIndexChanged

        Dim carType As String = ""
        If cboVehicle.SelectedIndex = 0 Then
            carType = "Sedan"
        ElseIf cboVehicle.SelectedIndex = 1 Then
            carType = "SUV"
        ElseIf cboVehicle.SelectedIndex = 2 Then
            carType = "Coupe"
        ElseIf cboVehicle.SelectedIndex = 3 Then
            carType = "Truck"
        End If
        dgvVehicles.DataSource = LeaseInventoryTableAdapter.GetLeaseType(carType)

    End Sub

    Private Sub cboEngine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEngine.SelectedIndexChanged

        Dim engineType As Integer = 0
        If cboEngine.SelectedIndex = 0 Then
            engineType = 4
        ElseIf cboEngine.SelectedIndex = 1 Then
            engineType = 6
        ElseIf cboEngine.SelectedIndex = 2 Then
            engineType = 8
        End If
        dgvVehicles.DataSource = LeaseInventoryTableAdapter.GetLeaseCylinders(engineType)

    End Sub

    Private Sub cboMake_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMake.SelectedIndexChanged

        Dim carMake As String = ""
        If cboMake.SelectedIndex = 0 Then
            carMake = "Acura"
        ElseIf cboMake.SelectedIndex = 1 Then
            carMake = "Dodge"
        ElseIf cboMake.SelectedIndex = 2 Then
            carMake = "Chevrolet"
        ElseIf cboMake.SelectedIndex = 3 Then
            carMake = "Nissan"
        ElseIf cboMake.SelectedIndex = 4 Then
            carMake = "Toyota"
        End If
        dgvVehicles.DataSource = LeaseInventoryTableAdapter.GetLeaseMake(carMake)

    End Sub

    Private Sub LeaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VehicleSelectionDataSet.LeaseInventory' table. You can move, or remove it, as needed.
        Me.LeaseInventoryTableAdapter.Fill(Me.VehicleSelectionDataSet.LeaseInventory)

        cboEngine.SelectedIndex = -1
        cboMake.SelectedIndex = -1
        cboVehicle.SelectedIndex = -1

    End Sub
End Class