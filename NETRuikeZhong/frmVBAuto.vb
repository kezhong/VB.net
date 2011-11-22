Imports System.Data.OleDb

Public Class frmVBAuto

    Dim objClsData As DataTier.clsData = New DataTier.clsData
    Dim mdsAllUsedCars As New DataSet
    Dim mdsSingleUsedCar As New DataSet
    Dim mdsAllSalesStaff As New DataSet

    'select all records from the SalesStaff table
    Dim mdaAllSalesStaff As New OleDbDataAdapter
    'select all records from the UsedCars table
    Dim mdaAllUsedcars As New OleDbDataAdapter

    Dim mbmSalesStaff As BindingManagerBase

    Private Sub refreshData(ByVal stockNo As String)
        mdsAllUsedCars.Clear()
        mdsAllUsedCars = objClsData.getAllCars()
        cmbStock.Items.Add(stockNo)
    End Sub

    Private Sub binData()
        Try
            lblName.DataBindings.Add("Text", mdsAllSalesStaff.Tables("SalesStaff"), "SalesPersonName")
            lblCode.DataBindings.Add("Text", mdsAllSalesStaff.Tables("SalesStaff"), "DealerCode")
            mbmSalesStaff = Me.BindingContext(mdsAllSalesStaff.Tables("SalesStaff"))
            cmbStock.DataSource = mdsAllUsedCars.Tables("UsedCar")
            cmbStock.DisplayMember = "StockNo"
        Catch ex As Exception

        End Try
    End Sub
End Class
