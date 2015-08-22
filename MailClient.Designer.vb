<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MailClient
    Inherits MetroFramework.Forms.MetroForm

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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.lnkRemoveAtt = New System.Windows.Forms.LinkLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.btnBrowse = New MetroFramework.Controls.MetroButton()
        Me.btnCancel = New MetroFramework.Controls.MetroButton()
        Me.btnSend = New MetroFramework.Controls.MetroButton()
        Me.txtUsername = New MetroFramework.Controls.MetroTextBox()
        Me.txtPassword = New MetroFramework.Controls.MetroTextBox()
        Me.txtTo = New MetroFramework.Controls.MetroTextBox()
        Me.txtSubject = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(190, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gmail accounts only *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Send file to: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Subject:"
        '
        'lblFileName
        '
        Me.lblFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFileName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFileName.Location = New System.Drawing.Point(126, 225)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(148, 20)
        Me.lblFileName.TabIndex = 14
        Me.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lnkRemoveAtt
        '
        Me.lnkRemoveAtt.AutoSize = True
        Me.lnkRemoveAtt.Location = New System.Drawing.Point(176, 245)
        Me.lnkRemoveAtt.Name = "lnkRemoveAtt"
        Me.lnkRemoveAtt.Size = New System.Drawing.Size(98, 13)
        Me.lnkRemoveAtt.TabIndex = 16
        Me.lnkRemoveAtt.TabStop = True
        Me.lnkRemoveAtt.Text = "remove attachment"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 34)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(110, 19)
        Me.MetroLabel1.TabIndex = 17
        Me.MetroLabel1.Text = "User Information:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 129)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel2.TabIndex = 18
        Me.MetroLabel2.Text = "Send:"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(30, 225)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 20)
        Me.btnBrowse.TabIndex = 19
        Me.btnBrowse.Text = "Browse"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(30, 273)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "Cancel"
        '
        'btnSend
        '
        Me.btnSend.Enabled = False
        Me.btnSend.Location = New System.Drawing.Point(126, 273)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(148, 23)
        Me.btnSend.TabIndex = 21
        Me.btnSend.Text = "Send"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(126, 65)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(148, 23)
        Me.txtUsername.TabIndex = 22
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(126, 99)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Size = New System.Drawing.Size(148, 23)
        Me.txtPassword.TabIndex = 23
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(126, 156)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(148, 23)
        Me.txtTo.TabIndex = 24
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(126, 190)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(148, 23)
        Me.txtSubject.TabIndex = 25
        '
        'MailClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(314, 321)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.lnkRemoveAtt)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MailClient"
        Me.ShowIcon = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblFileName As System.Windows.Forms.Label
    Friend WithEvents lnkRemoveAtt As System.Windows.Forms.LinkLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnBrowse As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSend As MetroFramework.Controls.MetroButton
    Friend WithEvents txtUsername As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtSubject As MetroFramework.Controls.MetroTextBox
End Class
