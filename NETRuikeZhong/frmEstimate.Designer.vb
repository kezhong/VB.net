<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstimate
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstimate))
        Me.lblCustomerName = New System.Windows.Forms.Label
        Me.txtCustomerName = New System.Windows.Forms.TextBox
        Me.lblCarPrice = New System.Windows.Forms.Label
        Me.txtCarPrice = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblAccessoriesFinish = New System.Windows.Forms.Label
        Me.lblSubtotal = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblSalesTax = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtTradeInAllowance = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblAmountDue = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.grpAccessories = New System.Windows.Forms.GroupBox
        Me.chkCptNavigation = New System.Windows.Forms.CheckBox
        Me.chkLeatherInterior = New System.Windows.Forms.CheckBox
        Me.chkStereoSystem = New System.Windows.Forms.CheckBox
        Me.grpCarExteriorFinish = New System.Windows.Forms.GroupBox
        Me.radCustomized = New System.Windows.Forms.RadioButton
        Me.radPearlized = New System.Windows.Forms.RadioButton
        Me.radStandard = New System.Windows.Forms.RadioButton
        Me.imgExclamation = New System.Windows.Forms.PictureBox
        Me.imgTradeInAllowance = New System.Windows.Forms.PictureBox
        Me.grpHSB = New System.Windows.Forms.GroupBox
        Me.lblMonthlyPayment = New System.Windows.Forms.Label
        Me.lblInsterestRate = New System.Windows.Forms.Label
        Me.lblNoOfYears = New System.Windows.Forms.Label
        Me.lable6 = New System.Windows.Forms.Label
        Me.lable5 = New System.Windows.Forms.Label
        Me.lable4 = New System.Windows.Forms.Label
        Me.hsbInsterestRate = New System.Windows.Forms.HScrollBar
        Me.hsbNoOfYears = New System.Windows.Forms.HScrollBar
        Me.ctxForm = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ctxCalculate = New System.Windows.Forms.ToolStripMenuItem
        Me.ctxAcceptQuote = New System.Windows.Forms.ToolStripMenuItem
        Me.ctxClear = New System.Windows.Forms.ToolStripMenuItem
        Me.ctxSummary = New System.Windows.Forms.ToolStripMenuItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.grpAccessories.SuspendLayout()
        Me.grpCarExteriorFinish.SuspendLayout()
        CType(Me.imgExclamation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgTradeInAllowance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpHSB.SuspendLayout()
        Me.ctxForm.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(15, 16)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(85, 13)
        Me.lblCustomerName.TabIndex = 0
        Me.lblCustomerName.Text = "C&ustomer Name:"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(145, 16)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerName.TabIndex = 1
        Me.txtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCarPrice
        '
        Me.lblCarPrice.AutoSize = True
        Me.lblCarPrice.Location = New System.Drawing.Point(14, 55)
        Me.lblCarPrice.Name = "lblCarPrice"
        Me.lblCarPrice.Size = New System.Drawing.Size(81, 13)
        Me.lblCarPrice.TabIndex = 2
        Me.lblCarPrice.Text = "C&ar's Sale Price"
        '
        'txtCarPrice
        '
        Me.txtCarPrice.Location = New System.Drawing.Point(145, 55)
        Me.txtCarPrice.Name = "txtCarPrice"
        Me.txtCarPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtCarPrice.TabIndex = 3
        Me.txtCarPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Accessories && Finish:"
        '
        'lblAccessoriesFinish
        '
        Me.lblAccessoriesFinish.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAccessoriesFinish.Location = New System.Drawing.Point(145, 97)
        Me.lblAccessoriesFinish.Name = "lblAccessoriesFinish"
        Me.lblAccessoriesFinish.Size = New System.Drawing.Size(100, 23)
        Me.lblAccessoriesFinish.TabIndex = 5
        Me.lblAccessoriesFinish.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotal.Location = New System.Drawing.Point(145, 138)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(100, 23)
        Me.lblSubtotal.TabIndex = 7
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Subtotal:"
        '
        'lblSalesTax
        '
        Me.lblSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSalesTax.Location = New System.Drawing.Point(145, 181)
        Me.lblSalesTax.Name = "lblSalesTax"
        Me.lblSalesTax.Size = New System.Drawing.Size(100, 23)
        Me.lblSalesTax.TabIndex = 9
        Me.lblSalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Sales Tax (12%):"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(145, 223)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 11
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Total:"
        '
        'txtTradeInAllowance
        '
        Me.txtTradeInAllowance.Location = New System.Drawing.Point(145, 270)
        Me.txtTradeInAllowance.Name = "txtTradeInAllowance"
        Me.txtTradeInAllowance.Size = New System.Drawing.Size(100, 20)
        Me.txtTradeInAllowance.TabIndex = 13
        Me.txtTradeInAllowance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 273)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "T&rade-In Allowance:"
        '
        'lblAmountDue
        '
        Me.lblAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAmountDue.Location = New System.Drawing.Point(145, 315)
        Me.lblAmountDue.Name = "lblAmountDue"
        Me.lblAmountDue.Size = New System.Drawing.Size(100, 23)
        Me.lblAmountDue.TabIndex = 15
        Me.lblAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 325)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Amount Due:"
        '
        'grpAccessories
        '
        Me.grpAccessories.Controls.Add(Me.chkCptNavigation)
        Me.grpAccessories.Controls.Add(Me.chkLeatherInterior)
        Me.grpAccessories.Controls.Add(Me.chkStereoSystem)
        Me.grpAccessories.Location = New System.Drawing.Point(314, 12)
        Me.grpAccessories.Name = "grpAccessories"
        Me.grpAccessories.Size = New System.Drawing.Size(200, 100)
        Me.grpAccessories.TabIndex = 16
        Me.grpAccessories.TabStop = False
        Me.grpAccessories.Text = "Accessories"
        '
        'chkCptNavigation
        '
        Me.chkCptNavigation.AutoSize = True
        Me.chkCptNavigation.Location = New System.Drawing.Point(33, 76)
        Me.chkCptNavigation.Name = "chkCptNavigation"
        Me.chkCptNavigation.Size = New System.Drawing.Size(125, 17)
        Me.chkCptNavigation.TabIndex = 2
        Me.chkCptNavigation.Text = "Computer &Navigation"
        Me.chkCptNavigation.UseVisualStyleBackColor = True
        '
        'chkLeatherInterior
        '
        Me.chkLeatherInterior.AutoSize = True
        Me.chkLeatherInterior.Location = New System.Drawing.Point(33, 46)
        Me.chkLeatherInterior.Name = "chkLeatherInterior"
        Me.chkLeatherInterior.Size = New System.Drawing.Size(97, 17)
        Me.chkLeatherInterior.TabIndex = 1
        Me.chkLeatherInterior.Text = "Leather &Interior"
        Me.chkLeatherInterior.UseVisualStyleBackColor = True
        '
        'chkStereoSystem
        '
        Me.chkStereoSystem.AutoSize = True
        Me.chkStereoSystem.Location = New System.Drawing.Point(33, 19)
        Me.chkStereoSystem.Name = "chkStereoSystem"
        Me.chkStereoSystem.Size = New System.Drawing.Size(94, 17)
        Me.chkStereoSystem.TabIndex = 0
        Me.chkStereoSystem.Text = "&Stereo System"
        Me.chkStereoSystem.UseVisualStyleBackColor = True
        '
        'grpCarExteriorFinish
        '
        Me.grpCarExteriorFinish.Controls.Add(Me.radCustomized)
        Me.grpCarExteriorFinish.Controls.Add(Me.radPearlized)
        Me.grpCarExteriorFinish.Controls.Add(Me.radStandard)
        Me.grpCarExteriorFinish.Location = New System.Drawing.Point(314, 238)
        Me.grpCarExteriorFinish.Name = "grpCarExteriorFinish"
        Me.grpCarExteriorFinish.Size = New System.Drawing.Size(200, 100)
        Me.grpCarExteriorFinish.TabIndex = 17
        Me.grpCarExteriorFinish.TabStop = False
        Me.grpCarExteriorFinish.Text = "Car Exterior Finish"
        '
        'radCustomized
        '
        Me.radCustomized.AutoSize = True
        Me.radCustomized.Location = New System.Drawing.Point(20, 65)
        Me.radCustomized.Name = "radCustomized"
        Me.radCustomized.Size = New System.Drawing.Size(123, 17)
        Me.radCustomized.TabIndex = 2
        Me.radCustomized.TabStop = True
        Me.radCustomized.Text = "Customized &Detailing"
        Me.radCustomized.UseVisualStyleBackColor = True
        '
        'radPearlized
        '
        Me.radPearlized.AutoSize = True
        Me.radPearlized.Location = New System.Drawing.Point(20, 43)
        Me.radPearlized.Name = "radPearlized"
        Me.radPearlized.Size = New System.Drawing.Size(68, 17)
        Me.radPearlized.TabIndex = 1
        Me.radPearlized.TabStop = True
        Me.radPearlized.Text = "Pearli&zed"
        Me.radPearlized.UseVisualStyleBackColor = True
        '
        'radStandard
        '
        Me.radStandard.AutoSize = True
        Me.radStandard.Checked = True
        Me.radStandard.Location = New System.Drawing.Point(20, 20)
        Me.radStandard.Name = "radStandard"
        Me.radStandard.Size = New System.Drawing.Size(68, 17)
        Me.radStandard.TabIndex = 0
        Me.radStandard.TabStop = True
        Me.radStandard.Text = "&Standard"
        Me.radStandard.UseVisualStyleBackColor = True
        '
        'imgExclamation
        '
        Me.imgExclamation.Image = CType(resources.GetObject("imgExclamation.Image"), System.Drawing.Image)
        Me.imgExclamation.InitialImage = CType(resources.GetObject("imgExclamation.InitialImage"), System.Drawing.Image)
        Me.imgExclamation.Location = New System.Drawing.Point(115, 51)
        Me.imgExclamation.Name = "imgExclamation"
        Me.imgExclamation.Size = New System.Drawing.Size(24, 24)
        Me.imgExclamation.TabIndex = 21
        Me.imgExclamation.TabStop = False
        Me.imgExclamation.Visible = False
        '
        'imgTradeInAllowance
        '
        Me.imgTradeInAllowance.Image = CType(resources.GetObject("imgTradeInAllowance.Image"), System.Drawing.Image)
        Me.imgTradeInAllowance.InitialImage = CType(resources.GetObject("imgTradeInAllowance.InitialImage"), System.Drawing.Image)
        Me.imgTradeInAllowance.Location = New System.Drawing.Point(115, 266)
        Me.imgTradeInAllowance.Name = "imgTradeInAllowance"
        Me.imgTradeInAllowance.Size = New System.Drawing.Size(24, 24)
        Me.imgTradeInAllowance.TabIndex = 22
        Me.imgTradeInAllowance.TabStop = False
        Me.imgTradeInAllowance.Visible = False
        '
        'grpHSB
        '
        Me.grpHSB.Controls.Add(Me.lblMonthlyPayment)
        Me.grpHSB.Controls.Add(Me.lblInsterestRate)
        Me.grpHSB.Controls.Add(Me.lblNoOfYears)
        Me.grpHSB.Controls.Add(Me.lable6)
        Me.grpHSB.Controls.Add(Me.lable5)
        Me.grpHSB.Controls.Add(Me.lable4)
        Me.grpHSB.Controls.Add(Me.hsbInsterestRate)
        Me.grpHSB.Controls.Add(Me.hsbNoOfYears)
        Me.grpHSB.Enabled = False
        Me.grpHSB.Location = New System.Drawing.Point(42, 448)
        Me.grpHSB.Name = "grpHSB"
        Me.grpHSB.Size = New System.Drawing.Size(445, 147)
        Me.grpHSB.TabIndex = 23
        Me.grpHSB.TabStop = False
        Me.grpHSB.Text = "Finance"
        '
        'lblMonthlyPayment
        '
        Me.lblMonthlyPayment.AutoSize = True
        Me.lblMonthlyPayment.Location = New System.Drawing.Point(360, 66)
        Me.lblMonthlyPayment.Name = "lblMonthlyPayment"
        Me.lblMonthlyPayment.Size = New System.Drawing.Size(0, 13)
        Me.lblMonthlyPayment.TabIndex = 8
        '
        'lblInsterestRate
        '
        Me.lblInsterestRate.AutoSize = True
        Me.lblInsterestRate.Location = New System.Drawing.Point(215, 66)
        Me.lblInsterestRate.Name = "lblInsterestRate"
        Me.lblInsterestRate.Size = New System.Drawing.Size(0, 13)
        Me.lblInsterestRate.TabIndex = 7
        '
        'lblNoOfYears
        '
        Me.lblNoOfYears.AutoSize = True
        Me.lblNoOfYears.Location = New System.Drawing.Point(38, 66)
        Me.lblNoOfYears.Name = "lblNoOfYears"
        Me.lblNoOfYears.Size = New System.Drawing.Size(0, 13)
        Me.lblNoOfYears.TabIndex = 6
        '
        'lable6
        '
        Me.lable6.AutoSize = True
        Me.lable6.Location = New System.Drawing.Point(339, 29)
        Me.lable6.Name = "lable6"
        Me.lable6.Size = New System.Drawing.Size(88, 13)
        Me.lable6.TabIndex = 5
        Me.lable6.Text = "Monthly Payment"
        '
        'lable5
        '
        Me.lable5.AutoSize = True
        Me.lable5.Location = New System.Drawing.Point(197, 29)
        Me.lable5.Name = "lable5"
        Me.lable5.Size = New System.Drawing.Size(73, 13)
        Me.lable5.TabIndex = 4
        Me.lable5.Text = "Insterest Rate"
        '
        'lable4
        '
        Me.lable4.AutoSize = True
        Me.lable4.Location = New System.Drawing.Point(33, 29)
        Me.lable4.Name = "lable4"
        Me.lable4.Size = New System.Drawing.Size(66, 13)
        Me.lable4.TabIndex = 3
        Me.lable4.Text = "No. of Years"
        '
        'hsbInsterestRate
        '
        Me.hsbInsterestRate.LargeChange = 25
        Me.hsbInsterestRate.Location = New System.Drawing.Point(193, 107)
        Me.hsbInsterestRate.Maximum = 2524
        Me.hsbInsterestRate.Name = "hsbInsterestRate"
        Me.hsbInsterestRate.Size = New System.Drawing.Size(80, 17)
        Me.hsbInsterestRate.TabIndex = 1
        '
        'hsbNoOfYears
        '
        Me.hsbNoOfYears.LargeChange = 3
        Me.hsbNoOfYears.Location = New System.Drawing.Point(17, 107)
        Me.hsbNoOfYears.Maximum = 12
        Me.hsbNoOfYears.Minimum = 1
        Me.hsbNoOfYears.Name = "hsbNoOfYears"
        Me.hsbNoOfYears.Size = New System.Drawing.Size(80, 17)
        Me.hsbNoOfYears.TabIndex = 0
        Me.hsbNoOfYears.Value = 1
        '
        'ctxForm
        '
        Me.ctxForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ctxCalculate, Me.ctxAcceptQuote, Me.ctxClear, Me.ctxSummary})
        Me.ctxForm.Name = "ContextMenuStrip1"
        Me.ctxForm.Size = New System.Drawing.Size(148, 92)
        '
        'ctxCalculate
        '
        Me.ctxCalculate.Enabled = False
        Me.ctxCalculate.Name = "ctxCalculate"
        Me.ctxCalculate.Size = New System.Drawing.Size(147, 22)
        Me.ctxCalculate.Text = "Calculate"
        '
        'ctxAcceptQuote
        '
        Me.ctxAcceptQuote.Enabled = False
        Me.ctxAcceptQuote.Name = "ctxAcceptQuote"
        Me.ctxAcceptQuote.Size = New System.Drawing.Size(147, 22)
        Me.ctxAcceptQuote.Text = "Accept Quote"
        '
        'ctxClear
        '
        Me.ctxClear.Name = "ctxClear"
        Me.ctxClear.Size = New System.Drawing.Size(147, 22)
        Me.ctxClear.Text = "Clear"
        '
        'ctxSummary
        '
        Me.ctxSummary.Enabled = False
        Me.ctxSummary.Name = "ctxSummary"
        Me.ctxSummary.Size = New System.Drawing.Size(147, 22)
        Me.ctxSummary.Text = "Summary"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Location = New System.Drawing.Point(12, 409)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(504, 3)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'frmEstimate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 619)
        Me.ContextMenuStrip = Me.ctxForm
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grpHSB)
        Me.Controls.Add(Me.imgTradeInAllowance)
        Me.Controls.Add(Me.imgExclamation)
        Me.Controls.Add(Me.grpCarExteriorFinish)
        Me.Controls.Add(Me.grpAccessories)
        Me.Controls.Add(Me.lblAmountDue)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTradeInAllowance)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblSalesTax)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblAccessoriesFinish)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCarPrice)
        Me.Controls.Add(Me.lblCarPrice)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Name = "frmEstimate"
        Me.Text = "frmEstimate"
        Me.grpAccessories.ResumeLayout(False)
        Me.grpAccessories.PerformLayout()
        Me.grpCarExteriorFinish.ResumeLayout(False)
        Me.grpCarExteriorFinish.PerformLayout()
        CType(Me.imgExclamation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgTradeInAllowance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpHSB.ResumeLayout(False)
        Me.grpHSB.PerformLayout()
        Me.ctxForm.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents lblCarPrice As System.Windows.Forms.Label
    Friend WithEvents txtCarPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAccessoriesFinish As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblSalesTax As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTradeInAllowance As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblAmountDue As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents grpAccessories As System.Windows.Forms.GroupBox
    Friend WithEvents chkStereoSystem As System.Windows.Forms.CheckBox
    Friend WithEvents chkCptNavigation As System.Windows.Forms.CheckBox
    Friend WithEvents chkLeatherInterior As System.Windows.Forms.CheckBox
    Friend WithEvents grpCarExteriorFinish As System.Windows.Forms.GroupBox
    Friend WithEvents radCustomized As System.Windows.Forms.RadioButton
    Friend WithEvents radPearlized As System.Windows.Forms.RadioButton
    Friend WithEvents radStandard As System.Windows.Forms.RadioButton
    Friend WithEvents imgExclamation As System.Windows.Forms.PictureBox
    Friend WithEvents imgTradeInAllowance As System.Windows.Forms.PictureBox
    Friend WithEvents grpHSB As System.Windows.Forms.GroupBox
    Friend WithEvents lable6 As System.Windows.Forms.Label
    Friend WithEvents lable5 As System.Windows.Forms.Label
    Friend WithEvents lable4 As System.Windows.Forms.Label
    Friend WithEvents hsbInsterestRate As System.Windows.Forms.HScrollBar
    Friend WithEvents hsbNoOfYears As System.Windows.Forms.HScrollBar
    Friend WithEvents lblMonthlyPayment As System.Windows.Forms.Label
    Friend WithEvents lblInsterestRate As System.Windows.Forms.Label
    Friend WithEvents lblNoOfYears As System.Windows.Forms.Label
    Friend WithEvents ctxForm As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ctxCalculate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxAcceptQuote As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxSummary As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
