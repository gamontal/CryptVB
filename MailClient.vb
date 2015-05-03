﻿
Imports System.Net.Mail
Imports System.IO
Public Class MailClient

    ReadOnly openFileDialog1 As New OpenFileDialog()
    Dim fullPath As String ' this variable will store the attachment file's path

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim recipient As String = txtTo.Text

        Dim SMTP As New SmtpClient("smtp.gmail.com") ' allows applications to send emails by using the Simple Mail Transfer Protocol (SMTP)

        SMTP.Port = 587 ' gets or sets the port used for SMTP transactions
        SMTP.EnableSsl = True ' uses Secure Sockets Layer to encrypt data
        SMTP.Credentials = New Net.NetworkCredential(username, password) ' credentials used to authenticate the sender

        Dim e_mail As New MailMessage() ' represents email message

        e_mail.From = New MailAddress(username) '.From sets from address
        e_mail.To.Add(recipient) ' .To.Add() sets To address
        e_mail.Subject = txtSubject.Text ' .Subject sets the subject
        e_mail.Body = "Sent using MPGP software." ' .Body sets the body of the message

        Dim msgAtt As New Attachment(fullPath) ' sets attachment

        e_mail.Attachments.Add(msgAtt) 'adds the attachment to the message

        Try
            SMTP.Send(e_mail) ' sends email

            MsgBox("Email has been sent!") 'user message confirmation 

            Close()

        Catch ex As Exception
            MsgBox("Error ocurred. Please, check your information and internet connection and try again.", MsgBoxStyle.Critical, "")
        End Try
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        openFileDialog1.CheckFileExists = True
        openFileDialog1.CheckPathExists = True
        openFileDialog1.DefaultExt = "txt" ' default extension
        openFileDialog1.FileName = ""
        openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        openFileDialog1.Multiselect = False
        ' open existing file commands

        If openFileDialog1.ShowDialog = DialogResult.OK Then

            fullPath = Path.GetFullPath(openFileDialog1.FileName) ' gets path from file

            lblFileName.Text = fullPath ' sets path value

        End If

    End Sub

    Private Sub txtChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged, txtPassword.TextChanged, txtSubject.TextChanged, lblFileName.TextChanged

        If txtUsername.Text = "" Or txtPassword.Text = "" Or txtSubject.Text = "" Or lblFileName.Text = "" Or txtTo.Text = "" Then

            btnSend.Enabled = False

        Else

            btnSend.Enabled = True

        End If

    End Sub

    '///
    Public Function Test(ByVal x As String, ByVal y As String, _
                              ByVal comparison As StringComparison)
        If x.EndsWith(y, comparison) Then
            Return True
        Else
            Return False
        End If

    End Function
    '///

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        txtUsername.Clear()

        txtPassword.Clear()

        txtSubject.Clear()

        lblFileName.Text = ""

        Close()

    End Sub

    Private Sub lnkRemoveAtt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRemoveAtt.LinkClicked
        lblFileName.Text = ""
    End Sub

End Class