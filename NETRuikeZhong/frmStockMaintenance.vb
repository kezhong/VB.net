Imports System.Data.OleDb
Public Class frmStockMaintenance
    'A Boolean indicating whether the current record is
    'new or existing true = new, false = existing
    Dim mdbNewOrExisting As Boolean

    'A String which represents the name (name property) 
    'of the TextBox that had been modified in the VB Auto Commission form
    Dim mdsName As String
    'A String which represents the new value (text property) of 
    'the TextBox that had been modified in the VB Auto 
    'Commission form
    Dim mdsValue As String

    Dim mdsStockNo As String

    Dim mdsSingleCar As DataSet
    Dim mdsAllCars As DataSet

    Dim mbmOneCar As BindingManagerBase
    Dim mobjClsData As New DataTier.clsData

    'This subprocedure will bind the various controls to the form’s “One Car” DataSet
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
    'This constructor will be used when a new stock 
    'number has been entered in the VB Auto Commissions form
    Public Sub New(ByVal stockNum As String)
        InitializeComponent()
        lblStockNo.Text = stockNum
        mdbNewOrExisting = True
        btnUpdate.Enabled = False
    End Sub
    'This constructor will be used when an existing stock 
    'record has been modified in the VB Auto Commissions form
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
    'The activated event is being used here so that focus can be 
    'properly set to the textbox containing the modified data
    Private Sub frmStockMaintenance_Activated(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles MyBase.Activated
        'A mdbNewOrExisting indicating whether the current record is
        'new or existing true = new, false = existing
        Try
            If mdbNewOrExisting Then
                'Call the clsData’s connect subprocedure to connect to the application’s database
                mobjClsData.connect()
                'Call the clsData’s getAllCars subprocedure to retrieve all records 
                'from the UsedCars table into the form’s “All Cars” DataSet
                mdsAllCars = mobjClsData.getAllCars()
                'Set the text property of the Update Button to be Add
                btnUpdate.Text = "Add"
                'Set focus to the Description TextBox
                txtDescription.Focus()
            Else
                mobjClsData.connect()
                'Call the clsData’s getOneCar subprocedure to retrieve a single record 
                'from the UsedCars table into the form’s “One Car” DataSet based on 
                'the stock number passed to this routine
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
    ''' <summary>
    ''' Create a shared event procedure which will validate all 
    ''' TextBoxes when the user tabs or clicks out of the control (Leave event)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Public Sub txtBoxes_LeaveChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles txtDescription.Leave, _
            txtCostPrice.Leave, _
            txtRetailPrice.Leave, _
            txtColour.Leave, _
            txtModel.Leave, _
            txtYear.Leave

        'Declare a generic TextBox which will represent the TextBox that triggered the event
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
                'If the validateNumeric function returns a false
                'Select all of the text in the TextBox
                'Set focus to the text box in error
                txtBox.SelectAll()
                txtBox.Focus()
            End If

        End If
        'Check all TextBoxes if contain data
        'If all TextBoxes contain data, enable the Update Button, otherwise disable the Update Button
        If txtColour.Text.Length > 0 And txtCostPrice.Text.Length > 0 _
        And txtDescription.Text.Length > 0 And txtModel.Text.Length > 0 _
        And txtRetailPrice.Text.Length > 0 And txtYear.Text.Length > 0 Then
            btnUpdate.Enabled = True
        Else
            btnUpdate.Enabled = False
        End If


    End Sub

    ''' <summary>
    ''' Code script for the Update Button to update the UsedCars
    '''  table in the VBAutoSales.mdb database with the information currently displayed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
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
            'Once a record has been inserted or updated, close the form
            Me.Close()
        Catch ex As Exception
            sendMessage(ex.Message, "Error: btnUpdate_Click")
        End Try

    End Sub

End Class
