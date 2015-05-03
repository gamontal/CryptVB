Public Class PswrdCreation

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

    Private Sub txtEntry_TextChanged(sender As Object, e As EventArgs) Handles txtEntry.TextChanged, txtVerify.TextChanged
        If String.IsNullOrEmpty(txtEntry.Text) = True Then
            btnDone.Enabled = False
        Else
            btnDone.Enabled = True
        End If
        If String.IsNullOrEmpty(txtEntry.Text) = True And String.IsNullOrEmpty(txtVerify.Text) = True Then
            txtEntry.BackColor = Color.LightGray
            txtVerify.BackColor = Color.LightGray
        Else

            If txtEntry.Text = txtVerify.Text Then
                txtVerify.BackColor = Color.LightBlue

            ElseIf String.IsNullOrEmpty(txtEntry.Text) = False And String.IsNullOrEmpty(txtVerify.Text) = True Then

                txtVerify.BackColor = Color.LightGray

            Else

                txtVerify.BackColor = Color.LightSalmon

            End If
        End If
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnDone.Click
        If (txtEntry.Text = txtVerify.Text) = False Then
            MsgBox("Passwords do not match!", MsgBoxStyle.Exclamation, "")
            Exit Sub
        Else
            DialogResult = Windows.Forms.DialogResult.OK
            MReturnText = txtEntry.Text
            txtVerify.Clear()
            Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCcl.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        MReturnText = ""
        txtEntry.Focus()
        txtVerify.Clear()
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