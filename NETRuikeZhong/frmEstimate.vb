Option Strict On

Public Class frmEstimate
    'Set up data for Accessories
    Const mdecSTEREO_SYSTEM As Decimal = 505.05D
    Const mdecLEATHER_INTERIOR As Decimal = 1010.1D
    Const mdecCOMPUTER_NAVIGATION As Decimal = 1515.15D
    'Set up data for Finish
    Const mdecSTANDARD As Decimal = 0D
    Const mdecPEARLIZED As Decimal = 404.04D
    Const mdecCUSTOMIZED As Decimal = 606.06D
    'Set up tax rate
    Const mdecTAX_RATE As Decimal = 0.12D
    Const MONTHS_PER_YEAR As Integer = 12
    Dim mdecFinish As Decimal
    Dim mdecAccessories As Decimal = 0.0
    'Checkboxes control
    Dim stereoSystemCountUncheck As Integer = 0
    Dim leatherInteriorCountUncheck As Integer = 0
    Dim cptNavigationCountUncheck As Integer = 0
    Dim mblnTest As Boolean
    Dim mstrTestString As String
    Dim mDialogResult As DialogResult
    Dim payment As Double = 0.0R
    Dim amountDue As Decimal
    Dim totalAmountDue As Decimal
    Dim numQuote As Integer

    Private Sub radAll_CheckChanged(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) _
    Handles radStandard.CheckedChanged, _
    radPearlized.CheckedChanged, _
    radCustomized.CheckedChanged

        'generic radiobutton
        Dim radSelected As RadioButton
        'make generic radiobutton represent the radiobutton that triggered the event
        radSelected = CType(sender, RadioButton)
        Select Case radSelected.Name
            Case "radStandard"
                mdecFinish = mdecSTANDARD
            Case "radPearlized"
                mdecFinish = mdecPEARLIZED
            Case "radCustomized"
                mdecFinish = mdecCUSTOMIZED
        End Select
    End Sub
    ''' <summary>
    ''' CheckBoxes control
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub chkAll_CheckedChanged(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) _
        Handles chkStereoSystem.CheckedChanged, _
        chkLeatherInterior.CheckedChanged, _
        chkCptNavigation.CheckedChanged

        If chkStereoSystem.Checked = True And stereoSystemCountUncheck = 0 Then
            mdecAccessories += mdecSTEREO_SYSTEM
            stereoSystemCountUncheck = -1

        End If

        If chkStereoSystem.Checked = False And stereoSystemCountUncheck = -1 Then
            mdecAccessories = mdecAccessories - mdecSTEREO_SYSTEM
            stereoSystemCountUncheck = 0
        End If


        If chkLeatherInterior.Checked = True And leatherInteriorCountUncheck = 0 Then
            mdecAccessories += mdecLEATHER_INTERIOR
            leatherInteriorCountUncheck = -1
        End If
        If chkLeatherInterior.Checked = False And leatherInteriorCountUncheck = -1 Then
            mdecAccessories -= mdecLEATHER_INTERIOR
            leatherInteriorCountUncheck = 0
        End If


        If chkCptNavigation.Checked = True And cptNavigationCountUncheck = 0 Then
            mdecAccessories += mdecCOMPUTER_NAVIGATION
            cptNavigationCountUncheck = -1
        End If
        If chkCptNavigation.Checked = False And cptNavigationCountUncheck = -1 Then
            mdecAccessories -= mdecCOMPUTER_NAVIGATION
            cptNavigationCountUncheck = 0
        End If
    End Sub
    Private Sub txtBoxes_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
Handles txtCarPrice.Leave, _
        txtTradeInAllowance.Leave, _
        txtCarPrice.TextChanged, _
        txtTradeInAllowance.TextChanged
        Dim txtBox As TextBox
        txtBox = CType(sender, TextBox)

        If txtBox.Text.Length > 0 Then
            If IsNumeric(txtBox.Text) Then
                'format number strips off the $ to allow
                'for conversion to decimal
                If Decimal.Parse(FormatNumber(txtBox.Text)) > 0 Then
                    imgExclamation.Visible = False
                    imgTradeInAllowance.Visible = False
                    clear(True)
                End If
            Else
                sendMessage("Data is not numeric", "Data Error")
                txtBox.Focus()
                txtBox.SelectAll()
                Select Case txtBox.Name
                    Case "txtCarPrice"
                        imgExclamation.Visible = True
                    Case "txtTradeInAllowance"
                        imgTradeInAllowance.Visible = True
                End Select

                clear(False) 'disable the calculate and clear context menu items
                enableFinance(False) 'disable the finace groupbox

            End If
        End If

    End Sub
    ''' <summary>
    ''' Calculations 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ctxCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctxCalculate.Click
        Dim total As Decimal = 0
        Dim finishAndAccessories As Decimal = 0
        Dim saleTax As Decimal = 0
        Dim subTotal As Decimal = 0
        finishAndAccessories = mdecFinish + mdecAccessories
        lblAccessoriesFinish.Text = finishAndAccessories.ToString("C")
        subTotal = finishAndAccessories + Decimal.Parse(txtCarPrice.Text)
        lblSubtotal.Text = subTotal.ToString("C")
        saleTax = subTotal * mdecTAX_RATE
        lblSalesTax.Text = saleTax.ToString("C")
        total = subTotal + saleTax
        lblTotal.Text = total.ToString("C")
        If txtTradeInAllowance.Text.Length > 0 Then
            amountDue = total - Decimal.Parse(txtTradeInAllowance.Text)
        Else
            amountDue = total
        End If

        lblAmountDue.Text = amountDue.ToString()
        quote(True)
        clear(True)
        enableFinance(True)
        txtCarPrice.Text = Decimal.Parse(txtCarPrice.Text).ToString("C")

        txtCarPrice.Focus()
        txtCarPrice.SelectAll()


    End Sub

    ''' <summary>
    ''' Clear everything
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ctxClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctxClear.Click
        txtCustomerName.Text = ""
        txtCarPrice.Text = ""
        txtTradeInAllowance.Text = ""
        lblAccessoriesFinish.Text = ""
        lblAmountDue.Text = ""
        lblSalesTax.Text = ""
        lblSubtotal.Text = ""
        lblTotal.Text = ""
        chkStereoSystem.Checked = False
        chkLeatherInterior.Checked = False
        chkCptNavigation.Checked = False
        radStandard.Checked = True
        stereoSystemCountUncheck = 0
        leatherInteriorCountUncheck = 0
        cptNavigationCountUncheck = 0
        mdecAccessories = 0
        amountDue = 0
        enableFinance(False)

    End Sub

    Private Sub HScrollBars_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) _
    Handles hsbNoOfYears.Scroll, hsbInsterestRate.Scroll
        lblNoOfYears.Text = hsbNoOfYears.Value.ToString()
        lblInsterestRate.Text = (hsbInsterestRate.Value / 10000).ToString()
        calculate()
    End Sub

    Protected Function sendMessage(ByVal text As String, ByVal caption As String, Optional _
    ByVal buttons As MessageBoxButtons = MessageBoxButtons.OK, Optional ByVal icon As  _
    MessageBoxIcon = MessageBoxIcon.Information, Optional ByVal defaultButton As  _
    MessageBoxDefaultButton = MessageBoxDefaultButton.Button1) As DialogResult
        If mblnTest = True Then
            mstrTestString = text
            Return mDialogResult
        Else
            Return MessageBox.Show(text, caption, buttons, icon, defaultButton)
        End If
    End Function
    ''' <summary>
    ''' Enable/disable the Accept Quote context menu item based on 
    ''' the value of the passed parameter
    ''' </summary>
    ''' <param name="acceptOrNo"></param>
    ''' <remarks></remarks>
    Private Sub quote(ByVal acceptOrNo As Boolean)
        If acceptOrNo = True Then
            ctxAcceptQuote.Enabled = True
        End If
    End Sub
    ''' <summary>
    '''Enable/disable the Clear and Calculate context menu item
    '''  based on the value of passed parameter
    ''' </summary>
    ''' <param name="clearOrNo"></param>
    ''' <remarks></remarks>
    Private Sub clear(ByVal clearOrNo As Boolean)
        If clearOrNo = False Then
            ctxClear.Enabled = False
            ctxCalculate.Enabled = False
        Else
            ctxClear.Enabled = True
            ctxCalculate.Enabled = True
        End If
    End Sub
    ''' <summary>
    ''' Determine the monthly payment suing the built-in function "PMT"
    ''' Display the payment in a label under the heading Monthly Payment
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub calculate()
        Dim percentageRate As Double
        Dim periodYears As Double
        Dim principal As Double
        periodYears = Double.Parse(lblNoOfYears.Text)
        percentageRate = Double.Parse(lblInsterestRate.Text)
        principal = amountDue
        payment = Pmt(percentageRate / MONTHS_PER_YEAR, _
                                   periodYears * MONTHS_PER_YEAR, _
                                   -principal, DueDate.EndOfPeriod)
        lblMonthlyPayment.Text = payment.ToString("c")
        lblInsterestRate.Text = percentageRate.ToString("P")
        lblAmountDue.Text = amountDue.ToString("c")
    End Sub
    ''' <summary>
    ''' Determine whether any finance calculation in this session
    ''' if not
    ''' set the value of the Years scrollbar to 3 and the corresponding label displays a value of 3
    ''' set the value of the Interest Rate scrollbar to be equivalent to 5.00%
    ''' and
    ''' </summary>
    ''' <param name="finace"></param>
    ''' <remarks></remarks>
    Private Sub enableFinance(ByVal finace As Boolean)
        If finace Then
            grpHSB.Enabled = finace

            hsbNoOfYears.Value = 3
            hsbInsterestRate.Value = 500
            lblNoOfYears.Text = hsbNoOfYears.Value.ToString()
            lblInsterestRate.Text = (hsbInsterestRate.Value / 10000).ToString()
            lblAmountDue.Text = amountDue.ToString()
            calculate()

        Else : grpHSB.Enabled = False
        End If
    End Sub
    ''' <summary>
    ''' Accept quote menu click. Accumulate the amount due and number of quotes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ctxAcceptQuote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctxAcceptQuote.Click
        totalAmountDue += amountDue
        numQuote += 1
        ctxSummary.Enabled = True
        quote(False)
    End Sub
    ''' <summary>
    ''' Show summary in message box
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ctxSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctxSummary.Click
        Dim average As Decimal
        Dim strMessage As String
        average = totalAmountDue / numQuote
        strMessage = "Total Estimates: " & FormatCurrency(totalAmountDue) _
                    & ControlChars.NewLine _
                    & "Number of Estimates: " & numQuote _
        & ControlChars.NewLine _
        & "Average: " & FormatCurrency(average)
        'MessageBox.Show(strMessage, "Summary of Accepted Quotes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        sendMessage(strMessage, "Summary of Accepted Quotes")
    End Sub
End Class
