<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommission
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
        Me.dgvCommission = New System.Windows.Forms.DataGridView
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCommission, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(279, 18)
        Me.Label1.Size = New System.Drawing.Size(157, 25)
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 385)
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(634, 407)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(59, 402)
        Me.Label2.Size = New System.Drawing.Size(650, 2)
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(59, 413)
        Me.Label3.Size = New System.Drawing.Size(570, 2)
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(59, 425)
        Me.Label4.Size = New System.Drawing.Size(570, 2)
        '
        'dgvCommission
        '
        Me.dgvCommission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCommission.Location = New System.Drawing.Point(41, 51)
        Me.dgvCommission.Name = "dgvCommission"
        Me.dgvCommission.ReadOnly = True
        Me.dgvCommission.Size = New System.Drawing.Size(636, 334)
        Me.dgvCommission.TabIndex = 6
        '
        'frmCommission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(732, 441)
        Me.Controls.Add(Me.dgvCommission)
        Me.Name = "frmCommission"
        Me.Text = "Commission Listing"
        Me.Controls.SetChildIndex(Me.dgvCommission, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCommission, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCommission As System.Windows.Forms.DataGridView

End Class
