Public Class frmService
    Dim mobjService As BusinessTier.clsService
    ''' <summary>
    ''' Checking the data in text box
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtBoxes_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles txtParts.Leave, _
            txtPrice.Leave, _
            txtShopMaterial.Leave, _
            txtParts.TextChanged, _
            txtPrice.TextChanged, _
            txtShopMaterial.TextChanged
        Dim txtBox As TextBox
        txtBox = CType(sender, TextBox)
        If txtParts.Text.Length > 0 And txtPrice.Text.Length > 0 And txtShopMaterial.Text.Length > 0 Then
            ctxCalculate.Enabled = True
        End If

        If txtBox.Text.Length > 0 Then
            If IsNumeric(txtBox.Text) Then
                'format number strips off the $ to allow
                'for conversion to decimal
                If Decimal.Parse(FormatNumber(txtBox.Text)) > 0 Then

                End If
            Else
                sendMessage("Data is not numeric", "Data Error")
                txtBox.Focus()
                txtBox.SelectAll()
                ctxCalculate.Enabled = False 'disable the calculate and clear context menu items
            End If
        End If

    End Sub
    ''' <summary>
    ''' Creat a instance of clsService and display data
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ctxCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctxCalculate.Click
        Try
            mobjService = New BusinessTier.clsService(Decimal.Parse(txtPrice.Text), Decimal.Parse(txtParts.Text), Decimal.Parse(txtShopMaterial.Text))
            mobjService.calcAMount()
            lblPST.Text = mobjService.CalculatedPST().ToString("c")
            lblGST.Text = mobjService.CalculatedGST().ToString("c")
            lblTotal.Text = mobjService.CalculatedTotal().ToString("c")
            ctxSummary.Enabled = True
        Catch ex As Exception
            sendMessage("Could not get data from BusinessTire", "Error")
        End Try
    End Sub

    Private Sub ctxSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctxSummary.Click
        Dim frmSummaryInst As New frmSummary
        frmSummaryInst.MdiParent = Me.MdiParent
        frmSummaryInst.Show()
    End Sub

    Private Sub ctxClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctxClear.Click
        txtServiceDescription.Text = ""
        txtPrice.Text = ""
        txtParts.Text = ""
        txtShopMaterial.Text = ""
        lblPST.Text = ""
        lblGST.Text = ""
        lblTotal.Text = ""
        ctxCalculate.Enabled = False
    End Sub

End Class
