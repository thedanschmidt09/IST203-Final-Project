Public Class LeaseVehicleCylinders
    Private adapter As New VehicleSelectionDataSetTableAdapters.LeaseInventoryTableAdapter

    Public ReadOnly Property Items() As DataTable
        Get
            Dim table As DataTable = adapter.GetData()
            table.DefaultView.Sort = "Cylinders"
            Return table

        End Get
    End Property

End Class
