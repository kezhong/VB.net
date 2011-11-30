<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
    Inherits NETRuikeZhong.frmBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.crpCommission = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crpCommission
        '
        Me.crpCommission.ActiveViewIndex = -1
        Me.crpCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crpCommission.DisplayGroupTree = False
        Me.crpCommission.Location = New System.Drawing.Point(12, 12)
        Me.crpCommission.Name = "crpCommission"
        Me.crpCommission.SelectionFormula = ""
        Me.crpCommission.Size = New System.Drawing.Size(922, 722)
        Me.crpCommission.TabIndex = 6
        Me.crpCommission.ViewTimeSelectionFormula = ""
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(946, 746)
        Me.Controls.Add(Me.crpCommission)
        Me.Name = "frmReport"
        Me.Text = "Commission Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.crpCommission, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents crpCommission As CrystalDecisions.Windows.Forms.CrystalReportViewer

End Class
