Imports System
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class MainSrc
    Private Const CancelClicked As String = ""
    ReadOnly saveFileDialog1 As New SaveFileDialog() ' Save as window 
    ReadOnly openFileDialog1 As New OpenFileDialog() ' Open file window 
    Dim oReader As StreamReader ' file finder
    Dim savedFilepath As String
    ReadOnly i As New PlainTextEdt
    ReadOnly c As New PswrdCreation
    ReadOnly u As New PasswordAuthentication
    Dim textReturned As String = ""
    Dim textReturnedPlain As String = ""
    ReadOnly cMsg As New ShowTextWnd

    ' ENCIPHER 
    Private Sub btnEncipher_Click(sender As Object, e As EventArgs) Handles btnEncipher.Click

        If cmbAlgorithm.Text = "RC2" Or cmbAlgorithm.Text = "rc2" Then
            RC2encryption()

        ElseIf cmbAlgorithm.Text = "DES" Or cmbAlgorithm.Text = "des" Then
            DESencryption()

        ElseIf cmbAlgorithm.Text = "3DES" Or cmbAlgorithm.Text = "3des" Then
            tripleDESencryption()

        ElseIf cmbAlgorithm.Text = "AES" Or cmbAlgorithm.Text = "aes" Then
            AESencryption()

        Else
            cmbAlgorithm.Text = "Encryption algorithm"
            MsgBox("Select encryption algorithm.", MsgBoxStyle.Exclamation, "Error!")

            cmbAlgorithm.Focus()

        End If

    End Sub
    ' DECIPHER 
    Private Sub btnDecipher_Click(sender As Object, e As EventArgs) Handles btnDecipher.Click

        If cmbAlgorithm.Text = "RC2" Or cmbAlgorithm.Text = "rc2" Then
            RC2decryption()

        ElseIf cmbAlgorithm.Text = "DES" Or cmbAlgorithm.Text = "des" Then
            DESdecryption()


        ElseIf cmbAlgorithm.Text = "3DES" Or cmbAlgorithm.Text = "3des" Then
            tripleDESdecryption()


        ElseIf cmbAlgorithm.Text = "AES" Or cmbAlgorithm.Text = "aes" Then
            AESdecryption()

        Else

            cmbAlgorithm.Text = "Encryption algorithm"

            MsgBox("Select encryption algorithm.", MsgBoxStyle.Exclamation, "Error!")

            cmbAlgorithm.Focus()

        End If
    End Sub

    Public Shared Function RemoveAttribute(ByVal attributes As FileAttributes,
                                           ByVal attributesToRemove As FileAttributes) As FileAttributes
        Return attributes And (Not attributesToRemove)
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnUnhide_Click(sender As Object, e As EventArgs) Handles btnUnhide.Click

        Dim attributes As FileAttributes
        attributes = RemoveAttribute(attributes, FileAttributes.Hidden)

        Dim hiddenFile As String = InputBox("Enter hidden file directory here: ", " ")
        If hiddenFile = CancelClicked Then
            Exit Sub
        End If

        If My.Computer.FileSystem.FileExists(hiddenFile) And hiddenFile.EndsWith(".txt") Then

            File.SetAttributes(hiddenFile, attributes)
            File.SetAttributes(hiddenFile, File.GetAttributes(hiddenFile) Or FileAttributes.ReadOnly)
            MsgBox(hiddenFile & " is no longer hidden.", MsgBoxStyle.Information, " ")
        Else
            MsgBox("File not found: " & hiddenFile, MsgBoxStyle.Exclamation, " ")
        End If
    End Sub


    Public Sub tripleDESencryption()

        i.ShowDialog("Enter plaintext here: ", "", textReturnedPlain, False)

        Dim plainText As String = textReturnedPlain

        If plainText = CancelClicked Then
            Exit Sub
        End If

        c.ShowDialog("Set Password", "Password: ", "", textReturned, False)

        Dim password As String = textReturned


        If password = "" Then
            MessageBox.Show("Error, no password entered. Press OK to exit.", "")
            Exit Sub
        Else
            Do Until CheckForAlphaCharacters(password) = True

                If CheckForAlphaCharacters(password) = False Then
                    MsgBox("Invalid data. Please try again.", MsgBoxStyle.Critical, " ")
                End If

                c.ShowDialog("Set Password", "Password: ", "", textReturned, False)
                password = textReturned
                If password = CancelClicked Then
                    MessageBox.Show("Error, no password entered. Press OK to exit.", "")
                    Exit Sub
                End If
            Loop



            Dim wrapper As New TripleDESclass(password)
            Dim cipherText As String = wrapper.EncryptData(plainText)

            MsgBox("Encryption complete.", MsgBoxStyle.Information, "")

            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*" ' .txt files only
            saveFileDialog1.DefaultExt = "txt" ' default extension
            saveFileDialog1.FileName = "" ' default file name
            saveFileDialog1.CheckPathExists = True
            saveFileDialog1.Title = "file path ?"

            If saveFileDialog1.ShowDialog = DialogResult.OK _
                Then

                savedFilepath = Path.GetFullPath(saveFileDialog1.FileName) ' get file directory

                My.Computer.FileSystem.WriteAllText _
                    (saveFileDialog1.FileName, cipherText, True)

                File.SetAttributes(savedFilepath, File.GetAttributes(savedFilepath) Or FileAttributes.ReadOnly)

                Dim hiddenOk As Integer = MessageBox.Show("Hide encrypted file?", " ", MessageBoxButtons.YesNo)

                If hiddenOk = DialogResult.No Then
                    Exit Sub

                ElseIf hiddenOk = DialogResult.Yes Then
                    File.SetAttributes(savedFilepath, File.GetAttributes(savedFilepath) Or FileAttributes.Hidden)
                    File.SetAttributes(savedFilepath, File.GetAttributes(savedFilepath) Or FileAttributes.ReadOnly)

                    Dim documentsPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments

                    Dim file1 As FileInfo
                    file1 = My.Computer.FileSystem.GetFileInfo(savedFilepath)

                    Dim fileName As String = "(Directory) " & file1.Name

                    Dim hiddenPath As String = My.Computer.FileSystem.CombinePath(documentsPath, fileName)
                    Dim fs As FileStream = File.Create(hiddenPath)

                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(savedFilepath)
                    fs.Write(info, 0, info.Length)
                    fs.Close()

                    MsgBox("A text file with the directory of your hidden file has been added to your Documents folder.",
                           MsgBoxStyle.Information, " ")
                End If
            End If
        End If
    End Sub


    Public Sub AESencryption()

        i.ShowDialog("Enter plaintext here: ", "", textReturnedPlain, False)

        Dim plainText As String = textReturnedPlain

        If plainText = CancelClicked Then
            Exit Sub
        End If

        c.ShowDialog("Set Password", "Password: ", "", textReturned, False)

        Dim password As String = textReturned


        If password = "" Then
            MessageBox.Show("Error, no password entered. Press OK to exit.", "")
            Exit Sub
        Else
            Do Until CheckForAlphaCharacters(password) = True

                If CheckForAlphaCharacters(password) = False Then
                    MsgBox("Invalid data. Please try again.", MsgBoxStyle.Critical, " ")
                End If

                c.ShowDialog("Set Password", "Password: ", "", textReturned, False)
                password = textReturned
                If password = CancelClicked Then
                    MessageBox.Show("Error, no password entered. Press OK to exit.", "")
                    Exit Sub
                End If
            Loop

            Dim wrapper As New AESclass(password)
            Dim cipherText As String = wrapper.EncryptData(plainText)

            MsgBox("Encryption complete.", MsgBoxStyle.Information, "")

            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*" ' .txt files only
            saveFileDialog1.DefaultExt = "txt" ' default extension
            saveFileDialog1.FileName = "" ' default file name
            saveFileDialog1.CheckPathExists = True
            saveFileDialog1.Title = "file path ?"

            If saveFileDialog1.ShowDialog = DialogResult.OK _
                Then

                savedFilepath = Path.GetFullPath(saveFileDialog1.FileName) ' get file directory

                My.Computer.FileSystem.WriteAllText _
                    (saveFileDialog1.FileName, cipherText, True)

                File.SetAttributes(savedFilepath, File.GetAttributes(savedFilepath) Or FileAttributes.ReadOnly)

                Dim hiddenOk As Integer = MessageBox.Show("Hide encrypted file?", " ", MessageBoxButtons.YesNo)

                If hiddenOk = DialogResult.No Then
                    Exit Sub

                ElseIf hiddenOk = DialogResult.Yes Then
                    File.SetAttributes(savedFilepath, File.GetAttributes(savedFilepath) Or FileAttributes.Hidden)
                    File.SetAttributes(savedFilepath, File.GetAttributes(savedFilepath) Or FileAttributes.ReadOnly)

                    Dim documentsPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments

                    Dim file1 As FileInfo
                    file1 = My.Computer.FileSystem.GetFileInfo(savedFilepath)

                    Dim fileName As String = "(Directory) " & file1.Name

                    Dim hiddenPath As String = My.Computer.FileSystem.CombinePath(documentsPath, fileName)
                    Dim fs As FileStream = File.Create(hiddenPath)

                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(savedFilepath)
                    fs.Write(info, 0, info.Length)
                    fs.Close()

                    MsgBox("A text file with the directory of your hidden file has been added to your Documents folder.",
                           MsgBoxStyle.Information, " ")
                End If
            End If
        End If
    End Sub


    Public Sub RC2encryption()

        i.ShowDialog("Enter plaintext here: ", "", textReturnedPlain, False)

        Dim plainText As String = textReturnedPlain

        If plainText = CancelClicked Then
            Exit Sub
        End If

        c.ShowDialog("Set Password", "Password: ", "", textReturned, False)

        Dim password As String = textReturned


        If password = "" Then
            MessageBox.Show("Error, no password entered. Press OK to exit.", "")
            Exit Sub
        Else
            Do Until CheckForAlphaCharacters(password) = True

                If CheckForAlphaCharacters(password) = False Then
                    MsgBox("Invalid data. Please try again.", MsgBoxStyle.Critical, " ")
                End If

                c.ShowDialog("Set Password", "Password: ", "", textReturned, False)
                password = textReturned
                If password = CancelClicked Then
                    MessageBox.Show("Error, no password entered. Press OK to exit.", "")
                    Exit Sub
                End If
            Loop



            Dim wrapper As New RC2class(password)
            Dim cipherText As String = wrapper.EncryptData(plainText)

            MsgBox("Encryption complete.", MsgBoxStyle.Information, "")

            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*" ' .txt files only
            saveFileDialog1.DefaultExt = "txt" ' default extension
            saveFileDialog1.FileName = "" ' default file name
            saveFileDialog1.CheckPathExists = True
            saveFileDialog1.Title = "file path ?"


            If saveFileDialog1.ShowDialog = DialogResult.OK _
                Then

                savedFilepath = Path.GetFullPath(saveFileDialog1.FileName) ' get file directory

                My.Computer.FileSystem.WriteAllText _
                    (saveFileDialog1.FileName, cipherText, True)

                File.SetAttributes(savedFilepath, File.GetAttributes(savedFilepath) Or FileAttributes.ReadOnly)

                Dim hiddenOk As Integer = MessageBox.Show("Hide encrypted file?", " ", MessageBoxButtons.YesNo)

                If hiddenOk = DialogResult.No Then
                    Exit Sub

                ElseIf hiddenOk = DialogResult.Yes Then
                    File.SetAttributes(savedFilepath, File.GetAttributes(savedFilepath) Or FileAttributes.Hidden)
                    File.SetAttributes(savedFilepath, File.GetAttributes(savedFilepath) Or FileAttributes.ReadOnly)

                    Dim documentsPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments

                    Dim file1 As FileInfo
                    file1 = My.Computer.FileSystem.GetFileInfo(savedFilepath)

                    Dim fileName As String = "(Directory) " & file1.Name

                    Dim hiddenPath As String = My.Computer.FileSystem.CombinePath(documentsPath, fileName)
                    Dim fs As FileStream = File.Create(hiddenPath)

                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(savedFilepath)
                    fs.Write(info, 0, info.Length)
                    fs.Close()

                    MsgBox("A text file with the directory of your hidden file has been added to your Documents folder.",
                           MsgBoxStyle.Information, " ")
                End If
            End If
        End If
    End Sub


    Public Sub DESencryption()

        i.ShowDialog("Enter plaintext here: ", "", textReturnedPlain, False)

        Dim plainText As String = textReturnedPlain

        If plainText = CancelClicked Then
            Exit Sub
        End If

        c.ShowDialog("Set Password", "Password: ", "", textReturned, False)

        Dim password As String = textReturned


        If password = "" Then
            MessageBox.Show("Error, no password entered. Press OK to exit.", "")
            Exit Sub
        Else
            Do Until CheckForAlphaCharacters(password) = True

                If CheckForAlphaCharacters(password) = False Then
                    MsgBox("Invalid data. Please try again.", MsgBoxStyle.Critical, " ")
                End If

                c.ShowDialog("Set Password", "Password: ", "", textReturned, False)
                password = textReturned
                If password = CancelClicked Then
                    MessageBox.Show("Error, no password entered. Press OK to exit.", "")
                    Exit Sub
                End If
            Loop



            Dim wrapper As New DESclass(password)
            Dim cipherText As String = wrapper.EncryptData(plainText)

            MsgBox("Encryption complete.", MsgBoxStyle.Information, "")

            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*" ' .txt files only
            saveFileDialog1.DefaultExt = "txt" ' default extension
            saveFileDialog1.FileName = "" ' default file name
            saveFileDialog1.CheckPathExists = True
            saveFileDialog1.Title = "file path ?"


            If saveFileDialog1.ShowDialog = DialogResult.OK _
                Then

                savedFilepath = Path.GetFullPath(saveFileDialog1.FileName) ' get file directory

                My.Computer.FileSystem.WriteAllText _
                    (saveFileDialog1.FileName, cipherText, True)

                File.SetAttributes(savedFilepath, File.GetAttributes(savedFilepath) Or FileAttributes.ReadOnly)

                Dim hiddenOk As Integer = MessageBox.Show("Hide encrypted file?", " ", MessageBoxButtons.YesNo)

                If hiddenOk = DialogResult.No Then
                    Exit Sub

                ElseIf hiddenOk = DialogResult.Yes Then
                    File.SetAttributes(savedFilepath, File.GetAttributes(savedFilepath) Or FileAttributes.Hidden)
                    File.SetAttributes(savedFilepath, File.GetAttributes(savedFilepath) Or FileAttributes.ReadOnly)

                    Dim documentsPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments

                    Dim file1 As FileInfo
                    file1 = My.Computer.FileSystem.GetFileInfo(savedFilepath)

                    Dim fileName As String = "(Directory) " & file1.Name

                    Dim hiddenPath As String = My.Computer.FileSystem.CombinePath(documentsPath, fileName)
                    Dim fs As FileStream = File.Create(hiddenPath)

                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(savedFilepath)
                    fs.Write(info, 0, info.Length)
                    fs.Close()

                    MsgBox("A text file with the directory of your hidden file has been added to your Documents folder.",
                           MsgBoxStyle.Information, " ")
                End If
            End If
        End If
    End Sub


    Public Sub tripleDESdecryption()

        Dim fullPath As String

        openFileDialog1.CheckFileExists = True
        openFileDialog1.CheckPathExists = True
        openFileDialog1.DefaultExt = "txt" ' default extension
        openFileDialog1.FileName = ""
        openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*" ' text restrictions
        openFileDialog1.Multiselect = False
        ' open existing file commands

        If openFileDialog1.ShowDialog = DialogResult.OK Then

            fullPath = Path.GetFullPath(openFileDialog1.FileName) ' get file directory

            Dim state As Boolean = CheckifFileisEncoded(fullPath) ' check if the content is encrypted 

            If state = True Then
                Dim fileReader As New StreamReader(fullPath)
                fileReader.ReadToEnd()
                fileReader.Close()

                oReader = New StreamReader(openFileDialog1.FileName, True)
                Dim cipherText As String = oReader.ReadToEnd

                u.ShowDialog(" ", "Password: ", "", textReturned, False)

                Dim password As String = textReturned ' prompts user for password input

                If password <> "" Then
                    Dim wrapper As New TripleDESclass(password)

                    ' DecryptData throws if the wrong password is used. 
                    Try
                        Dim plainText As String = wrapper.DecryptData(cipherText)
                        cMsg.ShowDialog(plainText, "Plaintext: ")

                    Catch ex As CryptographicException
                        MessageBox.Show("The data could not be decrypted with the password.", "") ' error message

                    End Try
                Else
                    MessageBox.Show("Error, no password entered. Press OK to exit.", "") ' error message

                    Exit Sub
                End If

            Else
                MsgBox("There was an error opening your file", MsgBoxStyle.Critical, "") ' error message

                Exit Sub
            End If
        End If
    End Sub


    Public Sub AESdecryption()

        Dim fullPath As String

        openFileDialog1.CheckFileExists = True
        openFileDialog1.CheckPathExists = True
        openFileDialog1.DefaultExt = "txt" ' default extension
        openFileDialog1.FileName = ""
        openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*" ' text restrictions
        openFileDialog1.Multiselect = False
        ' open existing file commands

        If openFileDialog1.ShowDialog = DialogResult.OK Then

            fullPath = Path.GetFullPath(openFileDialog1.FileName) ' get file directory

            Dim state As Boolean = CheckifFileisEncoded(fullPath) ' check if the content is encrypted 

            If state = True Then
                Dim fileReader As New StreamReader(fullPath)
                fileReader.ReadToEnd()
                fileReader.Close()

                oReader = New StreamReader(openFileDialog1.FileName, True)
                Dim cipherText As String = oReader.ReadToEnd

                u.ShowDialog(" ", "Password: ", "", textReturned, False)

                Dim password As String = textReturned ' prompts user for password input

                If password <> "" Then
                    Dim wrapper As New AESclass(password)

                    ' DecryptData throws if the wrong password is used. 
                    Try
                        Dim plainText As String = wrapper.DecryptData(cipherText)
                        cMsg.ShowDialog(plainText, "Plaintext: ")

                    Catch ex As CryptographicException
                        MessageBox.Show("The data could not be decrypted with the password.", "") ' error message

                    End Try
                Else
                    MessageBox.Show("Error, no password entered. Press OK to exit.", "") ' error message

                    Exit Sub
                End If

            Else
                MsgBox("There was an error opening your file", MsgBoxStyle.Critical, "") ' error message

                Exit Sub
            End If
        End If
    End Sub


    Public Sub RC2decryption()

        Dim fullPath As String

        openFileDialog1.CheckFileExists = True
        openFileDialog1.CheckPathExists = True
        openFileDialog1.DefaultExt = "txt" ' default extension
        openFileDialog1.FileName = ""
        openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*" ' text restrictions
        openFileDialog1.Multiselect = False
        ' open existing file commands

        If openFileDialog1.ShowDialog = DialogResult.OK Then

            fullPath = Path.GetFullPath(openFileDialog1.FileName) ' get file directory

            Dim state As Boolean = CheckifFileisEncoded(fullPath) ' check if the content is encrypted 

            If state = True Then
                Dim fileReader As New StreamReader(fullPath)
                fileReader.ReadToEnd()
                fileReader.Close()

                oReader = New StreamReader(openFileDialog1.FileName, True)
                Dim cipherText As String = oReader.ReadToEnd

                u.ShowDialog(" ", "Password: ", "", textReturned, False)

                Dim password As String = textReturned ' prompts user for password input

                If password <> "" Then
                    Dim wrapper As New RC2class(password)

                    ' DecryptData throws if the wrong password is used. 
                    Try
                        Dim plainText As String = wrapper.DecryptData(cipherText)
                        cMsg.ShowDialog(plainText, "Plaintext: ")

                    Catch ex As CryptographicException
                        MessageBox.Show("The data could not be decrypted with the password.", "") ' error message

                    End Try
                Else
                    MessageBox.Show("Error, no password entered. Press OK to exit.", "") ' error message

                    Exit Sub
                End If

            Else
                MsgBox("There was an error opening your file", MsgBoxStyle.Critical, "") ' error message

                Exit Sub
            End If
        End If
    End Sub


    Public Sub DESdecryption()

        Dim fullPath As String

        openFileDialog1.CheckFileExists = True
        openFileDialog1.CheckPathExists = True
        openFileDialog1.DefaultExt = "txt" ' default extension
        openFileDialog1.FileName = ""
        openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*" ' text restrictions
        openFileDialog1.Multiselect = False
        ' open existing file commands

        If openFileDialog1.ShowDialog = DialogResult.OK Then

            fullPath = Path.GetFullPath(openFileDialog1.FileName) ' get file directory

            Dim state As Boolean = CheckifFileisEncoded(fullPath) ' check if the content is encrypted 

            If state = True Then
                Dim fileReader As New StreamReader(fullPath)
                fileReader.ReadToEnd()
                fileReader.Close()

                oReader = New StreamReader(openFileDialog1.FileName, True)
                Dim cipherText As String = oReader.ReadToEnd

                u.ShowDialog(" ", "Password: ", "", textReturned, False)

                Dim password As String = textReturned ' prompts user for password input

                If password <> "" Then
                    Dim wrapper As New DESclass(password)

                    ' DecryptData throws if the wrong password is used. 
                    Try
                        Dim plainText As String = wrapper.DecryptData(cipherText)
                        cMsg.ShowDialog(plainText, "Plaintext: ")

                    Catch ex As CryptographicException
                        MessageBox.Show("The data could not be decrypted with the password.", "") ' error message

                    End Try
                Else
                    MessageBox.Show("Error, no password entered. Press OK to exit.", "") ' error message

                    Exit Sub
                End If

            Else
                MsgBox("There was an error opening your file", MsgBoxStyle.Critical, "") ' error message

                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click
        MailClient.Show()
    End Sub


    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub MPGPmainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        btnEncipher.Focus()
    End Sub

End Class


