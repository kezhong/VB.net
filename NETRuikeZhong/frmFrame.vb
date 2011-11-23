Public Class frmFrame
    ''' <summary>
    ''' open the estimate form as a child form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub EstimateToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles EstimateToolStripMenuItem1.Click, EstimateToolStripMenuItem.Click
        Dim frmInstance As New frmEstimate
        frmInstance.MdiParent = Me
        frmInstance.Show()

    End Sub
    ''' <summary>
    ''' close the frame and all child windows
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub tsbExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles tsbExit.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub mnuCastcade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuCastcade.Click, CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    ''' <summary>
    ''' Tile all open forms horizontally
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub mnuTile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuTile.Click, TitleToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub
    ''' <summary>
    ''' Tile all open forms vertically
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub mnuVertically_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuVertically.Click, LayerToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub
    ''' <summary>
    ''' open form Service
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ServiceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiceToolStripMenuItem1.Click
        Dim frmServiceInstance As New frmService
        frmServiceInstance.MdiParent = Me
        frmServiceInstance.Show()
    End Sub
    ''' <summary>
    ''' open form About
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim frmAboutInstance As New frmAbout
        frmAboutInstance.MdiParent = Me
        frmAboutInstance.Show()
    End Sub

    Private Sub CarWashToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                    Handles CarWashToolStripMenuItem.Click, CarWashToolStripMenuItem1.Click
        Dim frmCarWashInstance As New frmCarWash
        frmCarWashInstance.MdiParent = Me
        frmCarWashInstance.Show()
    End Sub

    Private Sub CommissionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
            Handles CommissionToolStripMenuItem1.Click, CommissionToolStripMenuItem.Click
        Dim frmVBAutoInstance As New frmVBAuto
        frmVBAutoInstance.MdiParent = Me
        frmVBAutoInstance.Show()
    End Sub

End Class
