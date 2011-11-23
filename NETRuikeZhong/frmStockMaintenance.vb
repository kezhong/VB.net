Imports System.Data.OleDb
Public Class frmStockMaintenance
    'A Boolean indicating whether the current record is
    'new or existing true = new, false = existing
    Dim mdbNewOrExisting As Boolean
    Dim mdsName As String
    Dim mdsValue As String
    Dim mdsStockNo As String
    Dim mdsSingleCar As DataSet
    Dim mdsAllCars As DataSet
    Dim mbmOneCar As BindingManagerBase
    Dim mobjClsData As New DataTier.clsData
    Public Sub bindData()
        Try
            lblStockNo.DataBindings.Add("Text", mdsSingleCar.Tables("UsedCars"), "StockNo")
            txtColour.DataBindings.Add("Text", mdsSingleCar.Tables("UsedCars"), "Color")
            txtCostPrice.DataBindings.Add("Text", mdsSingleCar.Tables("UsedCars"), "CostPrice")
            txtDescription.DataBindings.Add("Text", mdsSingleCar.Tables("UsedCars"), "Description")
            txtModel.DataBindings.Add("Text", mdsSingleCar.Tables("UsedCars"), "Model")
            txtRetailPrice.DataBindings.Add("Text", mdsSingleCar.Tables("UsedCars"), "RetailPrice")
            txtYear.DataBindings.Add("Text", mdsSingleCar.Tables("UsedCars"), "ManufacturedYear")
            mbmOneCar = Me.BindingContext(mdsSingleCar.Tables("UsedCars"))


        Catch ex As Exception
            sendMessage(ex.Message, "Error:bindData")
        End Try
    End Sub
    Public Sub New(ByVal stockNum As String)
        InitializeComponent()
        lblStockNo.Text = stockNum
        mdbNewOrExisting = True
        btnUpdate.Enabled = False
    End Sub

    Public Sub New(ByVal stockNum As String, _
                   ByVal name As String, _
                   ByVal value As String)
        InitializeComponent()
        lblStockNo.Text = stockNum
        mdsStockNo = stockNum
        mdsName = name
        mdsValue = value

        mdbNewOrExisting = False

    End Sub

    Private Sub frmStockMaintenance_Activated(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles MyBase.Activated
        'A mdbNewOrExisting indicating whether the current record is
        'new or existing true = new, false = existing
        Try
            If mdbNewOrExisting Then
                mobjClsData.connect()
                mdsAllCars = mobjClsData.getAllCars()
                btnUpdate.Text = "Add"
                txtDescription.Focus()
            Else
                mobjClsData.connect()
                mdsSingleCar = mobjClsData.getOneCar(mdsStockNo)
                bindData()

                Select Case mdsName
                    Case "txtDescription"
                        txtDescription.Focus()
                        txtDescription.Text = mdsValue
                    Case "txtCostPrice"
                        txtCostPrice.Focus()
                        txtCostPrice.Text = mdsValue
                    Case "txtRetailPrice"
                        txtRetailPrice.Focus()
                        txtRetailPrice.Text = mdsValue

                    Case Else
                        txtDescription.Focus()
                End Select

            End If
        Catch ex As Exception
            sendMessage(ex.Message, "Error:frmStockMaintenance_activated")
        End Try

    End Sub


    Public Sub txtBoxes_LeaveChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles txtDescription.Leave, _
            txtCostPrice.Leave, _
            txtRetailPrice.Leave, _
            txtColour.Leave, _
            txtModel.Leave, _
            txtYear.Leave


        Dim txtBox As TextBox
        txtBox = CType(sender, TextBox)
        If txtBox.Name = "txtCostPrice" Or txtBox.Name = "txtRetailPrice" _
         Or txtBox.Name = "txtYear" Then
            Dim result As Boolean = validateNumeric(txtBox.Text)
            If result Then
                If txtBox.Name = "txtYear" Then
                    If txtYear.Text.Length = 4 Then
                    Else
                        sendMessage("Year has to be entered 4 digits", "Error: Year")
                        txtBox.SelectAll()
                        txtBox.Focus()
                    End If
                End If
            Else
                txtBox.SelectAll()
                txtBox.Focus()
            End If

        End If

        If txtColour.Text.Length > 0 And txtCostPrice.Text.Length > 0 _
        And txtDescription.Text.Length > 0 And txtModel.Text.Length > 0 _
        And txtRetailPrice.Text.Length > 0 And txtYear.Text.Length > 0 Then
            btnUpdate.Enabled = True
        Else
            btnUpdate.Enabled = False
        End If


    End Sub


    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        'A mdbNewOrExisting indicating whether the current record is
        'new or existing true = new, false = existing
        Try
            If mdbNewOrExisting Then
                mobjClsData.updateNewCar(lblStockNo.Text, Decimal.Parse(txtYear.Text), _
                                         txtDescription.Text, txtModel.Text, txtColour.Text, _
                                         Decimal.Parse(txtCostPrice.Text), Decimal.Parse(txtRetailPrice.Text))
            Else
                mbmOneCar.EndCurrentEdit()
                mobjClsData.updateOneCar(mdsSingleCar)

            End If

            Me.Close()
        Catch ex As Exception
            sendMessage(ex.Message, "Error: btnUpdate_Click")
        End Try

    End Sub

End Class
