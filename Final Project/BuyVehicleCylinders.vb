Public Class BuyVehicleCylinders
    Private adapter As New VehicleSelectionDataSetTableAdapters.BuyInventoryTableAdapter

    Public ReadOnly Property Items() As DataTable
        Get
            Dim table As DataTable = adapter.GetData()
            table.DefaultView.Sort = "Cylinders"
            Return table

        End Get
    End Property

End Class
