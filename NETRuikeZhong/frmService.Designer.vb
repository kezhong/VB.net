<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmService
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
        Me.components = New System.ComponentModel.Container
        Me.lblServiceDescription = New System.Windows.Forms.Label
        Me.lblPrice = New System.Windows.Forms.Label
        Me.lblParts = New System.Windows.Forms.Label
        Me.lblShopMaterial = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtServiceDescription = New System.Windows.Forms.TextBox
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.txtParts = New System.Windows.Forms.TextBox
        Me.txtShopMaterial = New System.Windows.Forms.TextBox
        Me.lblPST = New System.Windows.Forms.Label
        Me.lblGST = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.ctxForm = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ctxCalculate = New System.Windows.Forms.ToolStripMenuItem
        Me.ctxClear = New System.Windows.Forms.ToolStripMenuItem
        Me.ctxSummary = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctxForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 30)
        Me.Label1.Size = New System.Drawing.Size(130, 20)
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(24, 399)
        Me.PictureBox1.Size = New System.Drawing.Size(46, 42)
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(331, 423)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(76, 416)
        Me.Label2.Size = New System.Drawing.Size(300, 2)
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(76, 427)
        Me.Label3.Size = New System.Drawing.Size(245, 2)
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(76, 439)
        Me.Label4.Size = New System.Drawing.Size(245, 2)
        '
        'lblServiceDescription
        '
        Me.lblServiceDescription.AutoSize = True
        Me.lblServiceDescription.Location = New System.Drawing.Point(85, 67)
        Me.lblServiceDescription.Name = "lblServiceDescription"
        Me.lblServiceDescription.Size = New System.Drawing.Size(102, 13)
        Me.lblServiceDescription.TabIndex = 6
        Me.lblServiceDescription.Text = "Service &Description:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(85, 111)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(34, 13)
        Me.lblPrice.TabIndex = 7
        Me.lblPrice.Text = "P&rice:"
        '
        'lblParts
        '
        Me.lblParts.AutoSize = True
        Me.lblParts.Location = New System.Drawing.Point(85, 155)
        Me.lblParts.Name = "lblParts"
        Me.lblParts.Size = New System.Drawing.Size(34, 13)
        Me.lblParts.TabIndex = 8
        Me.lblParts.Text = "&Parts:"
        '
        'lblShopMaterial
        '
        Me.lblShopMaterial.AutoSize = True
        Me.lblShopMaterial.Location = New System.Drawing.Point(85, 199)
        Me.lblShopMaterial.Name = "lblShopMaterial"
        Me.lblShopMaterial.Size = New System.Drawing.Size(75, 13)
        Me.lblShopMaterial.TabIndex = 9
        Me.lblShopMaterial.Text = "&Shop Material:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(85, 243)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "PST:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(85, 287)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "GST:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(85, 331)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Total:"
        '
        'txtServiceDescription
        '
        Me.txtServiceDescription.Location = New System.Drawing.Point(202, 67)
        Me.txtServiceDescription.Name = "txtServiceDescription"
        Me.txtServiceDescription.Size = New System.Drawing.Size(177, 20)
        Me.txtServiceDescription.TabIndex = 13
        Me.txtServiceDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(202, 109)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 14
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtParts
        '
        Me.txtParts.Location = New System.Drawing.Point(202, 150)
        Me.txtParts.Name = "txtParts"
        Me.txtParts.Size = New System.Drawing.Size(100, 20)
        Me.txtParts.TabIndex = 15
        Me.txtParts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtShopMaterial
        '
        Me.txtShopMaterial.Location = New System.Drawing.Point(202, 195)
        Me.txtShopMaterial.Name = "txtShopMaterial"
        Me.txtShopMaterial.Size = New System.Drawing.Size(100, 20)
        Me.txtShopMaterial.TabIndex = 16
        Me.txtShopMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPST
        '
        Me.lblPST.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPST.Location = New System.Drawing.Point(202, 238)
        Me.lblPST.Name = "lblPST"
        Me.lblPST.Size = New System.Drawing.Size(100, 23)
        Me.lblPST.TabIndex = 17
        Me.lblPST.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGST
        '
        Me.lblGST.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGST.Location = New System.Drawing.Point(202, 282)
        Me.lblGST.Name = "lblGST"
        Me.lblGST.Size = New System.Drawing.Size(100, 23)
        Me.lblGST.TabIndex = 18
        Me.lblGST.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(202, 324)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 19
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ctxForm
        '
        Me.ctxForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ctxCalculate, Me.ctxClear, Me.ctxSummary})
        Me.ctxForm.Name = "ContextMenuStrip1"
        Me.ctxForm.Size = New System.Drawing.Size(126, 70)
        '
        'ctxCalculate
        '
        Me.ctxCalculate.Enabled = False
        Me.ctxCalculate.Name = "ctxCalculate"
        Me.ctxCalculate.Size = New System.Drawing.Size(125, 22)
        Me.ctxCalculate.Text = "Calculate"
        '
        'ctxClear
        '
        Me.ctxClear.Name = "ctxClear"
        Me.ctxClear.Size = New System.Drawing.Size(125, 22)
        Me.ctxClear.Text = "Clear"
        '
        'ctxSummary
        '
        Me.ctxSummary.Enabled = False
        Me.ctxSummary.Name = "ctxSummary"
        Me.ctxSummary.Size = New System.Drawing.Size(125, 22)
        Me.ctxSummary.Text = "Summary"
        '
        'frmService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(425, 456)
        Me.ContextMenuStrip = Me.ctxForm
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblShopMaterial)
        Me.Controls.Add(Me.lblParts)
        Me.Controls.Add(Me.txtServiceDescription)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblGST)
        Me.Controls.Add(Me.lblPST)
        Me.Controls.Add(Me.txtShopMaterial)
        Me.Controls.Add(Me.txtParts)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblServiceDescription)
        Me.Controls.Add(Me.txtPrice)
        Me.Name = "frmService"
        Me.Text = "VBAuto Service"
        Me.Controls.SetChildIndex(Me.txtPrice, 0)
        Me.Controls.SetChildIndex(Me.lblServiceDescription, 0)
        Me.Controls.SetChildIndex(Me.lblPrice, 0)
        Me.Controls.SetChildIndex(Me.txtParts, 0)
        Me.Controls.SetChildIndex(Me.txtShopMaterial, 0)
        Me.Controls.SetChildIndex(Me.lblPST, 0)
        Me.Controls.SetChildIndex(Me.lblGST, 0)
        Me.Controls.SetChildIndex(Me.lblTotal, 0)
        Me.Controls.SetChildIndex(Me.txtServiceDescription, 0)
        Me.Controls.SetChildIndex(Me.lblParts, 0)
        Me.Controls.SetChildIndex(Me.lblShopMaterial, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctxForm.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblServiceDescription As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblParts As System.Windows.Forms.Label
    Friend WithEvents lblShopMaterial As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtServiceDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtParts As System.Windows.Forms.TextBox
    Friend WithEvents txtShopMaterial As System.Windows.Forms.TextBox
    Friend WithEvents lblPST As System.Windows.Forms.Label
    Friend WithEvents lblGST As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents ctxForm As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ctxCalculate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxSummary As System.Windows.Forms.ToolStripMenuItem

End Class
