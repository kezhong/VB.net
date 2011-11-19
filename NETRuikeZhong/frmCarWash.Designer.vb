<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarWash
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
        Me.btnClear = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Lbl = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblCharges = New System.Windows.Forms.Label
        Me.lblTaxes = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.cboDetailing = New System.Windows.Forms.ComboBox
        Me.lstInterior = New System.Windows.Forms.ListBox
        Me.cboFragrance = New System.Windows.Forms.ComboBox
        Me.lstExterior = New System.Windows.Forms.ListBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(244, 24)
        Me.Label1.Size = New System.Drawing.Size(148, 24)
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(31, 385)
        Me.PictureBox1.Size = New System.Drawing.Size(47, 46)
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(493, 416)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(86, 399)
        Me.Label2.Size = New System.Drawing.Size(400, 2)
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(84, 416)
        Me.Label3.Size = New System.Drawing.Size(400, 2)
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(84, 435)
        Me.Label4.Size = New System.Drawing.Size(400, 2)
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(84, 385)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(480, 2)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Label5"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(492, 389)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Detailing"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Fragrance"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(279, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 15)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Interior"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(456, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 15)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Exterior"
        '
        'Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl.Location = New System.Drawing.Point(372, 275)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(64, 15)
        Me.Lbl.TabIndex = 8
        Me.Lbl.Text = "Charges:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(274, 312)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(162, 15)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Taxes(GST&&PST)@12%:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(393, 351)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 15)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Total:"
        '
        'lblCharges
        '
        Me.lblCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCharges.Location = New System.Drawing.Point(469, 272)
        Me.lblCharges.Name = "lblCharges"
        Me.lblCharges.Size = New System.Drawing.Size(100, 23)
        Me.lblCharges.TabIndex = 9
        Me.lblCharges.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTaxes
        '
        Me.lblTaxes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTaxes.Location = New System.Drawing.Point(469, 310)
        Me.lblTaxes.Name = "lblTaxes"
        Me.lblTaxes.Size = New System.Drawing.Size(100, 23)
        Me.lblTaxes.TabIndex = 9
        Me.lblTaxes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(469, 347)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 9
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboDetailing
        '
        Me.cboDetailing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDetailing.FormattingEnabled = True
        Me.cboDetailing.Location = New System.Drawing.Point(31, 98)
        Me.cboDetailing.Name = "cboDetailing"
        Me.cboDetailing.Size = New System.Drawing.Size(121, 21)
        Me.cboDetailing.TabIndex = 10
        '
        'lstInterior
        '
        Me.lstInterior.FormattingEnabled = True
        Me.lstInterior.Location = New System.Drawing.Point(258, 98)
        Me.lstInterior.Name = "lstInterior"
        Me.lstInterior.Size = New System.Drawing.Size(152, 121)
        Me.lstInterior.TabIndex = 11
        '
        'cboFragrance
        '
        Me.cboFragrance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFragrance.FormattingEnabled = True
        Me.cboFragrance.Location = New System.Drawing.Point(31, 247)
        Me.cboFragrance.Name = "cboFragrance"
        Me.cboFragrance.Size = New System.Drawing.Size(121, 21)
        Me.cboFragrance.TabIndex = 10
        '
        'lstExterior
        '
        Me.lstExterior.FormattingEnabled = True
        Me.lstExterior.Location = New System.Drawing.Point(433, 98)
        Me.lstExterior.Name = "lstExterior"
        Me.lstExterior.Size = New System.Drawing.Size(136, 121)
        Me.lstExterior.TabIndex = 11
        '
        'frmCarWash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(611, 447)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lstInterior)
        Me.Controls.Add(Me.cboDetailing)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Lbl)
        Me.Controls.Add(Me.lblCharges)
        Me.Controls.Add(Me.lstExterior)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cboFragrance)
        Me.Controls.Add(Me.lblTaxes)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label7)
        Me.Name = "frmCarWash"
        Me.Text = "VB Auto Centre Car Wash"
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.lblTotal, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.lblTaxes, 0)
        Me.Controls.SetChildIndex(Me.cboFragrance, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.lstExterior, 0)
        Me.Controls.SetChildIndex(Me.lblCharges, 0)
        Me.Controls.SetChildIndex(Me.Lbl, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.cboDetailing, 0)
        Me.Controls.SetChildIndex(Me.lstInterior, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.btnClear, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Lbl As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblCharges As System.Windows.Forms.Label
    Friend WithEvents lblTaxes As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents cboDetailing As System.Windows.Forms.ComboBox
    Friend WithEvents lstInterior As System.Windows.Forms.ListBox
    Friend WithEvents cboFragrance As System.Windows.Forms.ComboBox
    Friend WithEvents lstExterior As System.Windows.Forms.ListBox

End Class
