Public Class ShowTextWnd
    Public Overloads Function ShowDialog(ByRef Text As String, _
       Optional ByVal Title As Object = Nothing _
    ) As DialogResult

        'Set other properties
        txtMsg.Text = Text
        Me.Text = Title
        'Button1.DialogResult = DialogResult.OK


        'Display the form modally and return its DialogResult
        Return ShowDialog()
    End Function
End Class