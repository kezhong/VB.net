Option Strict On
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFrame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFrame))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EstimateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CarWashToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CommissionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TitleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripSplitButton
        Me.EstimateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ServiceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CarWashToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CommissionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuTile = New System.Windows.Forms.ToolStripButton
        Me.mnuVertically = New System.Windows.Forms.ToolStripButton
        Me.mnuCastcade = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.tsbExit = New System.Windows.Forms.ToolStripButton
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.WindowToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstimateToolStripMenuItem, Me.ServiceToolStripMenuItem, Me.CarWashToolStripMenuItem, Me.CommissionToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'EstimateToolStripMenuItem
        '
        Me.EstimateToolStripMenuItem.Name = "EstimateToolStripMenuItem"
        Me.EstimateToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EstimateToolStripMenuItem.Text = "&Estimate"
        '
        'ServiceToolStripMenuItem
        '
        Me.ServiceToolStripMenuItem.Name = "ServiceToolStripMenuItem"
        Me.ServiceToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ServiceToolStripMenuItem.Text = "&Service"
        '
        'CarWashToolStripMenuItem
        '
        Me.CarWashToolStripMenuItem.Name = "CarWashToolStripMenuItem"
        Me.CarWashToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CarWashToolStripMenuItem.Text = "&Car Wash"
        '
        'CommissionToolStripMenuItem
        '
        Me.CommissionToolStripMenuItem.Name = "CommissionToolStripMenuItem"
        Me.CommissionToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CommissionToolStripMenuItem.Text = "Co&mmission"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReportsToolStripMenuItem.Text = "&Reports"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TitleToolStripMenuItem, Me.LayerToolStripMenuItem, Me.CascadeToolStripMenuItem})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.WindowToolStripMenuItem.Text = "Window"
        '
        'TitleToolStripMenuItem
        '
        Me.TitleToolStripMenuItem.Name = "TitleToolStripMenuItem"
        Me.TitleToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.TitleToolStripMenuItem.Text = "Title"
        '
        'LayerToolStripMenuItem
        '
        Me.LayerToolStripMenuItem.Name = "LayerToolStripMenuItem"
        Me.LayerToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.LayerToolStripMenuItem.Text = "Layer"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.CascadeToolStripMenuItem.Text = "Cascade"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.mnuTile, Me.mnuVertically, Me.mnuCastcade, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.tsbExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(284, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstimateToolStripMenuItem1, Me.ServiceToolStripMenuItem1, Me.CarWashToolStripMenuItem1, Me.CommissionToolStripMenuItem1, Me.ReportsToolStripMenuItem1})
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(32, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'EstimateToolStripMenuItem1
        '
        Me.EstimateToolStripMenuItem1.Image = CType(resources.GetObject("EstimateToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.EstimateToolStripMenuItem1.Name = "EstimateToolStripMenuItem1"
        Me.EstimateToolStripMenuItem1.Size = New System.Drawing.Size(141, 22)
        Me.EstimateToolStripMenuItem1.Text = "Estimate"
        '
        'ServiceToolStripMenuItem1
        '
        Me.ServiceToolStripMenuItem1.Image = CType(resources.GetObject("ServiceToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ServiceToolStripMenuItem1.Name = "ServiceToolStripMenuItem1"
        Me.ServiceToolStripMenuItem1.Size = New System.Drawing.Size(141, 22)
        Me.ServiceToolStripMenuItem1.Text = "Service"
        '
        'CarWashToolStripMenuItem1
        '
        Me.CarWashToolStripMenuItem1.Image = CType(resources.GetObject("CarWashToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.CarWashToolStripMenuItem1.Name = "CarWashToolStripMenuItem1"
        Me.CarWashToolStripMenuItem1.Size = New System.Drawing.Size(141, 22)
        Me.CarWashToolStripMenuItem1.Text = "Car Wash"
        '
        'CommissionToolStripMenuItem1
        '
        Me.CommissionToolStripMenuItem1.Image = CType(resources.GetObject("CommissionToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.CommissionToolStripMenuItem1.Name = "CommissionToolStripMenuItem1"
        Me.CommissionToolStripMenuItem1.Size = New System.Drawing.Size(141, 22)
        Me.CommissionToolStripMenuItem1.Text = "Commission"
        '
        'ReportsToolStripMenuItem1
        '
        Me.ReportsToolStripMenuItem1.Image = CType(resources.GetObject("ReportsToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ReportsToolStripMenuItem1.Name = "ReportsToolStripMenuItem1"
        Me.ReportsToolStripMenuItem1.Size = New System.Drawing.Size(141, 22)
        Me.ReportsToolStripMenuItem1.Text = "Reports"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'mnuTile
        '
        Me.mnuTile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTile.Image = CType(resources.GetObject("mnuTile.Image"), System.Drawing.Image)
        Me.mnuTile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTile.Name = "mnuTile"
        Me.mnuTile.Size = New System.Drawing.Size(23, 22)
        Me.mnuTile.Text = "ToolStripButton2"
        '
        'mnuVertically
        '
        Me.mnuVertically.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuVertically.Image = CType(resources.GetObject("mnuVertically.Image"), System.Drawing.Image)
        Me.mnuVertically.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuVertically.Name = "mnuVertically"
        Me.mnuVertically.Size = New System.Drawing.Size(23, 22)
        Me.mnuVertically.Text = "ToolStripButton3"
        '
        'mnuCastcade
        '
        Me.mnuCastcade.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuCastcade.Image = CType(resources.GetObject("mnuCastcade.Image"), System.Drawing.Image)
        Me.mnuCastcade.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuCastcade.Name = "mnuCastcade"
        Me.mnuCastcade.Size = New System.Drawing.Size(23, 22)
        Me.mnuCastcade.Text = "ToolStripButton4"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "ToolStripButton5"
        '
        'tsbExit
        '
        Me.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbExit.Image = CType(resources.GetObject("tsbExit.Image"), System.Drawing.Image)
        Me.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExit.Name = "tsbExit"
        Me.tsbExit.Size = New System.Drawing.Size(23, 22)
        Me.tsbExit.Text = "ToolStripButton6"
        '
        'frmFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmFrame"
        Me.Text = "Auto Maintenance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstimateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CarWashToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CommissionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TitleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LayerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents EstimateToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServiceToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CarWashToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CommissionToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuTile As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuVertically As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuCastcade As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbExit As System.Windows.Forms.ToolStripButton
End Class
