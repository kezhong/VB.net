Public Class frmBase
    Dim mblnTest As Boolean
    Dim mstrTestString As String
    Dim mDialogResult As DialogResult

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Protected Function sendMessage(ByVal text As String, ByVal caption As String, Optional _
    ByVal buttons As MessageBoxButtons = MessageBoxButtons.OK, Optional ByVal icon As  _
    MessageBoxIcon = MessageBoxIcon.Information, Optional ByVal defaultButton As  _
    MessageBoxDefaultButton = MessageBoxDefaultButton.Button1) As DialogResult
        If mblnTest = True Then
            mstrTestString = text
            Return mDialogResult
        Else
            Return MessageBox.Show(text, caption, buttons, icon, defaultButton)
        End If
    End Function
End Class