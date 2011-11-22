<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVBAuto
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
        Me.grbPersonInfo = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblID = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.lblCode = New System.Windows.Forms.Label
        Me.btnPrevious = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.grbInfo = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmbStock = New System.Windows.Forms.ComboBox
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.txtCostPrice = New System.Windows.Forms.TextBox
        Me.txtRetailPrice = New System.Windows.Forms.TextBox
        Me.lblCommission = New System.Windows.Forms.Label
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.btnView = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbPersonInfo.SuspendLayout()
        Me.grbInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(181, 9)
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(40, 529)
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(368, 548)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(87, 546)
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(87, 557)
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(87, 569)
        '
        'grbPersonInfo
        '
        Me.grbPersonInfo.Controls.Add(Me.btnNext)
        Me.grbPersonInfo.Controls.Add(Me.btnPrevious)
        Me.grbPersonInfo.Controls.Add(Me.lblCode)
        Me.grbPersonInfo.Controls.Add(Me.lblName)
        Me.grbPersonInfo.Controls.Add(Me.lblID)
        Me.grbPersonInfo.Controls.Add(Me.Label7)
        Me.grbPersonInfo.Controls.Add(Me.Label6)
        Me.grbPersonInfo.Controls.Add(Me.Label5)
        Me.grbPersonInfo.Location = New System.Drawing.Point(40, 56)
        Me.grbPersonInfo.Name = "grbPersonInfo"
        Me.grbPersonInfo.Size = New System.Drawing.Size(403, 167)
        Me.grbPersonInfo.TabIndex = 6
        Me.grbPersonInfo.TabStop = False
        Me.grbPersonInfo.Text = "Sales Person Info"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Sales Person ID: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Sales Person Name: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Dealer Code:"
        '
        'lblID
        '
        Me.lblID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblID.Location = New System.Drawing.Point(165, 20)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(189, 23)
        Me.lblID.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.Location = New System.Drawing.Point(165, 55)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(189, 23)
        Me.lblName.TabIndex = 4
        '
        'lblCode
        '
        Me.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCode.Location = New System.Drawing.Point(165, 92)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(189, 23)
        Me.lblCode.TabIndex = 5
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(165, 138)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 6
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(279, 138)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'grbInfo
        '
        Me.grbInfo.Controls.Add(Me.btnView)
        Me.grbInfo.Controls.Add(Me.btnCalculate)
        Me.grbInfo.Controls.Add(Me.lblCommission)
        Me.grbInfo.Controls.Add(Me.txtRetailPrice)
        Me.grbInfo.Controls.Add(Me.txtCostPrice)
        Me.grbInfo.Controls.Add(Me.txtDescription)
        Me.grbInfo.Controls.Add(Me.cmbStock)
        Me.grbInfo.Controls.Add(Me.Label12)
        Me.grbInfo.Controls.Add(Me.Label11)
        Me.grbInfo.Controls.Add(Me.Label10)
        Me.grbInfo.Controls.Add(Me.Label9)
        Me.grbInfo.Controls.Add(Me.Label8)
        Me.grbInfo.Location = New System.Drawing.Point(40, 282)
        Me.grbInfo.Name = "grbInfo"
        Me.grbInfo.Size = New System.Drawing.Size(403, 241)
        Me.grbInfo.TabIndex = 7
        Me.grbInfo.TabStop = False
        Me.grbInfo.Text = "Stock Information"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Stock #:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(40, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Description:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(40, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Cost Price:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(40, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Retail Price:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(40, 172)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Commission:"
        '
        'cmbStock
        '
        Me.cmbStock.FormattingEnabled = True
        Me.cmbStock.Location = New System.Drawing.Point(126, 34)
        Me.cmbStock.Name = "cmbStock"
        Me.cmbStock.Size = New System.Drawing.Size(121, 21)
        Me.cmbStock.TabIndex = 5
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(126, 71)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(121, 20)
        Me.txtDescription.TabIndex = 6
        '
        'txtCostPrice
        '
        Me.txtCostPrice.Location = New System.Drawing.Point(126, 105)
        Me.txtCostPrice.Name = "txtCostPrice"
        Me.txtCostPrice.Size = New System.Drawing.Size(121, 20)
        Me.txtCostPrice.TabIndex = 7
        '
        'txtRetailPrice
        '
        Me.txtRetailPrice.Location = New System.Drawing.Point(126, 134)
        Me.txtRetailPrice.Name = "txtRetailPrice"
        Me.txtRetailPrice.Size = New System.Drawing.Size(121, 20)
        Me.txtRetailPrice.TabIndex = 8
        '
        'lblCommission
        '
        Me.lblCommission.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCommission.Location = New System.Drawing.Point(126, 172)
        Me.lblCommission.Name = "lblCommission"
        Me.lblCommission.Size = New System.Drawing.Size(121, 23)
        Me.lblCommission.TabIndex = 9
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(126, 212)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(230, 212)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 23)
        Me.btnView.TabIndex = 11
        Me.btnView.Text = "View Comm"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'frmVBAuto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(473, 577)
        Me.Controls.Add(Me.grbInfo)
        Me.Controls.Add(Me.grbPersonInfo)
        Me.Name = "frmVBAuto"
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.grbPersonInfo, 0)
        Me.Controls.SetChildIndex(Me.grbInfo, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbPersonInfo.ResumeLayout(False)
        Me.grbPersonInfo.PerformLayout()
        Me.grbInfo.ResumeLayout(False)
        Me.grbInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grbPersonInfo As System.Windows.Forms.GroupBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grbInfo As System.Windows.Forms.GroupBox
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblCommission As System.Windows.Forms.Label
    Friend WithEvents txtRetailPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtCostPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents cmbStock As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
