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
    Dim mbmUsedCar As BindingManagerBase

    Private Sub refreshData(ByVal stockNo As String)
        mdsAllUsedCars.Clear()
        mdsAllUsedCars = objClsData.getAllCars()
        cmbStock.Text = stockNo
    End Sub
    'This subprocedure will bind the various controls to module
    'level DataSet containing the corresponding data
    Private Sub bindData()
        Try
            lblID.DataBindings.Add("Text", mdsAllSalesStaff.Tables("SalesStaff"), "SalesID")
            lblName.DataBindings.Add("Text", mdsAllSalesStaff.Tables("SalesStaff"), "SalesPersonName")
            lblCode.DataBindings.Add("Text", mdsAllSalesStaff.Tables("SalesStaff"), "DealerCode")

            mbmSalesStaff = Me.BindingContext(mdsAllSalesStaff.Tables("SalesStaff"))
            cmbStock.DataSource = mdsAllUsedCars.Tables("UsedCars")
            cmbStock.DisplayMember = "StockNo"

            txtCostPrice.DataBindings.Add("Text", mdsAllUsedCars.Tables("UsedCars"), "CostPrice")
            txtDescription.DataBindings.Add("Text", mdsAllUsedCars.Tables("UsedCars"), "Description")
            txtRetailPrice.DataBindings.Add("Text", mdsAllUsedCars.Tables("UsedCars"), "RetailPrice")
            mbmUsedCar = Me.BindingContext(mdsAllUsedCars.Tables("UsedCars"))
        Catch ex As Exception
            sendMessage(ex.Message, "Error--bindData")
        End Try
    End Sub

    Private Sub frmVBAuto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            objClsData.connect()
            mdsAllSalesStaff = objClsData.getSalesStaff()
            mdsAllUsedCars = objClsData.getAllCars()
            bindData()
        Catch ex As Exception
            sendMessage(ex.Message, "Error--VBAutoLoad")
        End Try


    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        mbmSalesStaff.Position += 1
        lblCommission.Text = ""
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        mbmSalesStaff.Position -= 1
        lblCommission.Text = ""
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim commission As Decimal
        Try
            Dim objClsCommission As BusinessTier.clsCommission _
                                = New BusinessTier.clsCommission(Decimal.Parse(txtCostPrice.Text), Decimal.Parse(txtRetailPrice.Text))
            commission = objClsCommission.calCommission()
            lblCommission.Text = commission.ToString("c")
            'Call the calcCommission method to prepare teh clsData OleDBDataAdapter
            'for the update performed in the next step
            mdsAllSalesStaff = objClsData.getCommission()

            objClsData.updateCommission(lblName.Text, cmbStock.Text, txtDescription.Text, commission)
        Catch ex As Exception
            sendMessage(ex.Message, "Error-btnCalculate_Click")
        End Try


    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        'Open form frmCarWash
        Dim frmCommissionInstance As New frmCommission
        frmCommissionInstance.Show()
    End Sub

    Private Sub txtBoxes_LeaveChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles txtDescription.Leave, _
            txtCostPrice.Leave, _
            txtRetailPrice.Leave
        Dim name As String
        Dim value As String
        Dim txtBox As TextBox
        txtBox = CType(sender, TextBox)
        If txtBox.Text.Length > 0 And txtBox.Modified Then
            name = txtBox.Name
            value = txtBox.Text
            Dim frmStockMaintenance As frmStockMaintenance
            frmStockMaintenance = New frmStockMaintenance(cmbStock.Text, name, value)
            frmStockMaintenance.ShowDialog()
            refreshData(cmbStock.Text)
        End If


    End Sub

    Private Sub cmbStock_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbStock.Leave
        Dim result As Boolean
        result = validateNumeric(Trim(cmbStock.Text))

        If result Then
            mdsSingleUsedCar = objClsData.getOneCar(cmbStock.Text)
            If mdsSingleUsedCar.Tables("UsedCars").Rows.Count > 0 Then
                refreshData(cmbStock.Text)
            Else
                If cmbStock.Text.Length <= 7 Then
                    Dim resultYN As DialogResult
                    resultYN = sendMessage("Stock Number does not exit in database would you like to add it?", _
                                "New Stock Number", MessageBoxButtons.YesNo)
                    If resultYN = Windows.Forms.DialogResult.Yes Then
                        Dim frmStockMaintenanceInstance As frmStockMaintenance
                        frmStockMaintenanceInstance = New frmStockMaintenance(cmbStock.Text)
                        frmStockMaintenanceInstance.ShowDialog()
                        mdsSingleUsedCar.Clear()
                        mdsSingleUsedCar = objClsData.getOneCar(cmbStock.Text)

                        If mdsSingleUsedCar.Tables("UsedCars").Rows.Count > 0 Then
                            refreshData(cmbStock.Text)
                        Else
                            cmbStock.SelectedIndex = 0
                        End If
                    Else
                        cmbStock.Focus()
                    End If
                Else
                    sendMessage("Stock Number must lest than 7 digits", "Error in Stock Number")
                    cmbStock.Focus()
                    cmbStock.SelectAll()
                End If
            End If

        Else

        End If
    End Sub


    Private Sub cmbStock_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStock.SelectedIndexChanged
        lblCommission.Text = ""
    End Sub
End Class
