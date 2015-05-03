Public Class PasswordAuthentication
    Protected MBlankValid As Boolean = True
    Protected MReturnText As String = ""

    Public Overloads Function ShowDialog( _
      ByVal titleText As String, _
      ByVal promptText As String, _
      ByVal defaultText As String, _
      ByRef enteredText As String, _
      ByVal blankValid As Boolean) As Windows.Forms.DialogResult
        MBlankValid = blankValid
        lblPrompt.Text = promptText
        Text = titleText
        txtEntry.Text = defaultText
        ShowDialog()
        enteredText = MReturnText
        Return DialogResult
    End Function

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnDone.Click
        DialogResult = Windows.Forms.DialogResult.OK
        MReturnText = txtEntry.Text
        Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCcl.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        MReturnText = ""
        txtEntry.Focus()
        Close()
    End Sub

    Private Const CpNocloseButton As Integer = &H200
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CpNocloseButton
            Return myCp
        End Get
    End Property

    Private Sub txtEntry_TextChanged(sender As Object, e As EventArgs) Handles txtEntry.TextChanged
        If String.IsNullOrEmpty(txtEntry.Text) = True Then
            btnDone.Enabled = False
        Else
            btnDone.Enabled = True
        End If
    End Sub

    Private Sub UnlockFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEntry.Focus()
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        Const wmNclbuttondown As Integer = 161
        Const wmSyscommand As Integer = 274
        Const htcaption As Integer = 2
        Const scMove As Integer = 61456

        If (m.Msg = wmSyscommand) And (m.WParam.ToInt32() = scMove) Then
            Return
        End If

        If (m.Msg = wmNclbuttondown) And (m.WParam.ToInt32() = htcaption) Then
            Return
        End If

        MyBase.WndProc(m)
    End Sub
End Class