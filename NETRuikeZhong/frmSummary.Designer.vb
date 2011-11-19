<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSummary
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
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblTotalAllServiceContracts = New System.Windows.Forms.Label
        Me.lblNumContracts = New System.Windows.Forms.Label
        Me.lblTotalPST = New System.Windows.Forms.Label
        Me.lblTotalGST = New System.Windows.Forms.Label
        Me.lblAvgContract = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(125, 22)
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(18, 264)
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(234, 277)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(65, 273)
        Me.Label2.Size = New System.Drawing.Size(230, 2)
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(67, 284)
        Me.Label3.Size = New System.Drawing.Size(160, 2)
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(67, 296)
        Me.Label4.Size = New System.Drawing.Size(160, 2)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(185, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Total All Service Contracts(Tax Excl.):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Number of Service Contracts:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Total PST:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Total GST:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 191)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Average Contract(Tax Incl.):"
        '
        'lblTotalAllServiceContracts
        '
        Me.lblTotalAllServiceContracts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalAllServiceContracts.Location = New System.Drawing.Point(209, 67)
        Me.lblTotalAllServiceContracts.Name = "lblTotalAllServiceContracts"
        Me.lblTotalAllServiceContracts.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalAllServiceContracts.TabIndex = 11
        Me.lblTotalAllServiceContracts.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNumContracts
        '
        Me.lblNumContracts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumContracts.Location = New System.Drawing.Point(209, 98)
        Me.lblNumContracts.Name = "lblNumContracts"
        Me.lblNumContracts.Size = New System.Drawing.Size(100, 23)
        Me.lblNumContracts.TabIndex = 12
        Me.lblNumContracts.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalPST
        '
        Me.lblTotalPST.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalPST.Location = New System.Drawing.Point(209, 129)
        Me.lblTotalPST.Name = "lblTotalPST"
        Me.lblTotalPST.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalPST.TabIndex = 13
        Me.lblTotalPST.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalGST
        '
        Me.lblTotalGST.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalGST.Location = New System.Drawing.Point(209, 160)
        Me.lblTotalGST.Name = "lblTotalGST"
        Me.lblTotalGST.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalGST.TabIndex = 14
        Me.lblTotalGST.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAvgContract
        '
        Me.lblAvgContract.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAvgContract.Location = New System.Drawing.Point(209, 191)
        Me.lblAvgContract.Name = "lblAvgContract"
        Me.lblAvgContract.Size = New System.Drawing.Size(100, 23)
        Me.lblAvgContract.TabIndex = 15
        Me.lblAvgContract.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(348, 309)
        Me.Controls.Add(Me.lblNumContracts)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblAvgContract)
        Me.Controls.Add(Me.lblTotalGST)
        Me.Controls.Add(Me.lblTotalPST)
        Me.Controls.Add(Me.lblTotalAllServiceContracts)
        Me.Name = "frmSummary"
        Me.Text = "VBAuto Service Summary"
        Me.Controls.SetChildIndex(Me.lblTotalAllServiceContracts, 0)
        Me.Controls.SetChildIndex(Me.lblTotalPST, 0)
        Me.Controls.SetChildIndex(Me.lblTotalGST, 0)
        Me.Controls.SetChildIndex(Me.lblAvgContract, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.lblNumContracts, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblTotalAllServiceContracts As System.Windows.Forms.Label
    Friend WithEvents lblNumContracts As System.Windows.Forms.Label
    Friend WithEvents lblTotalPST As System.Windows.Forms.Label
    Friend WithEvents lblTotalGST As System.Windows.Forms.Label
    Friend WithEvents lblAvgContract As System.Windows.Forms.Label

End Class
