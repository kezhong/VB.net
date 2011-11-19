Public Class frmSummary
    ''' <summary>
    ''' Loading data and display in proper format
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTotalAllServiceContracts.Text = (BusinessTier.clsService.AccumulatedCalcTotals - BusinessTier.clsService.AccumulatedGST - BusinessTier.clsService.AccumulatedPST).ToString("c")
        lblNumContracts.Text = BusinessTier.clsService.NoOfContracts.ToString()
        lblTotalPST.Text = BusinessTier.clsService.AccumulatedPST.ToString("c")
        lblTotalGST.Text = BusinessTier.clsService.AccumulatedGST.ToString("c")
        Dim average As Decimal
        average = BusinessTier.clsService.averageContract
        lblAvgContract.Text = average.ToString("c")
    End Sub

End Class
