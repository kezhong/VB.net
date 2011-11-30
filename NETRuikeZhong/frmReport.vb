Public Class frmReport

    Private Sub frmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim objData As New DataTier.clsData
            Dim dsData As New DataSet
            'Connect to database AutoSales.mdb
            objData.connect()
            'Retrieve data from the commissions table
            dsData = objData.getCommission
            Dim crRpt As New crpCommission
            crRpt.SetDataSource(dsData)
            crpCommission.ReportSource = crRpt
        Catch ex As Exception
            sendMessage(ex.Message, "Error: frmReport")
        End Try


    End Sub
End Class
