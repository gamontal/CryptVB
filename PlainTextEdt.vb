Imports Microsoft.Office.Interop
Public Class PlainTextEdt
    Protected MBlankValid1 As Boolean = True
    Protected MReturnText1 As String = ""

    Public Overloads Function ShowDialog( _
      ByVal titleText1 As Object, _
      ByVal defaultText1 As String, _
      ByRef enteredTextPlainText As String, _
      ByVal blankValid1 As Boolean) As Windows.Forms.DialogResult
        MBlankValid1 = blankValid1
        Text = titleText1
        txtPlainText.Text = defaultText1
        ShowDialog()
        enteredTextPlainText = MReturnText1
        Return DialogResult
    End Function

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPlainText.TextChanged

        Dim chrCount As Integer
        ' Dim wordCount = New Regex("\w+").Matches(s).Count

        ' character count
        If String.IsNullOrEmpty(txtPlainText.Text) = False Then
            chrCount = txtPlainText.Text.Length
            ' ReSharper disable once LocalizableElement
            lblChar.Text = "Characters: " & chrCount.ToString()
        End If
        If String.IsNullOrEmpty(txtPlainText.Text) Then
            ' ReSharper disable once LocalizableElement
            lblChar.Text = "Characters: 0"
        End If

        ' word count
        Static rex As New System.Text.RegularExpressions.Regex("\b", System.Text.RegularExpressions.RegexOptions.Compiled Or System.Text.RegularExpressions.RegexOptions.Multiline)

        ' ReSharper disable once LocalizableElement
        lblWords.Text = "Words: " & (rex.Matches(txtPlainText.Text).Count / 2).ToString()


        If txtPlainText.Text = "" Then
            btnDone1.Enabled = MBlankValid1
        Else
            btnDone1.Enabled = True
        End If

        If txtPlainText.Text = "" Then
            btnSpCheck.Visible = False
        Else
            btnSpCheck.Visible = True
        End If

        If (txtPlainText.TextLength >= 2754) Then
            txtPlainText.ScrollBars = ScrollBars.Vertical
        End If
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnDone1.Click
        DialogResult = Windows.Forms.DialogResult.OK
        MReturnText1 = txtPlainText.Text
        txtPlainText.Focus()
        Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCcl1.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        MReturnText1 = ""
        txtPlainText.Focus()
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

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtPlainText.Clear()
        txtPlainText.Focus()
    End Sub

    Private Sub btnSpCheck_Click(sender As Object, e As EventArgs) Handles btnSpCheck.Click
        If txtPlainText.Text.Length > 0 Then
            Dim wordApp As New Word.Application
            wordApp.Visible = False
            Dim doc As Word.Document = wordApp.Documents.Add()
            Dim range As Word.Range
            range = doc.Range()
            range.Text = txtPlainText.Text
            doc.Activate()
            doc.CheckSpelling()
            Dim chars() As Char = {CType(vbCr, Char), CType(vbLf, Char)}
            txtPlainText.Text = doc.Range().Text.Trim(chars)
            doc.Close(SaveChanges:=False)
            wordApp.Quit()
        End If
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

    Private Sub lnkBold_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkBold.LinkClicked
        txtPlainText.Font = New Font(txtPlainText.Font, FontStyle.Bold)
        txtPlainText.Focus()
    End Sub

    Private Sub lnkRegular_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRegular.LinkClicked
        txtPlainText.Font = New Font(txtPlainText.Font, FontStyle.Regular)
        txtPlainText.Focus()
    End Sub

    Private Sub btnIn_Click(sender As Object, e As EventArgs)
        txtPlainText.Focus()
    End Sub

    Private Sub btnDe_Click(sender As Object, e As EventArgs)
        txtPlainText.Focus()
    End Sub

    Private Sub InputBoxTxt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPlainText.Font = New Font(txtPlainText.Font, FontStyle.Regular)
    End Sub
End Class