<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PswrdCreation
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PswrdCreation))
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.lblVerify = New System.Windows.Forms.Label()
        Me.txtEntry = New MetroFramework.Controls.MetroTextBox()
        Me.txtVerify = New MetroFramework.Controls.MetroTextBox()
        Me.btnDone = New MetroFramework.Controls.MetroButton()
        Me.btnCcl = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.ForeColor = System.Drawing.Color.Black
        Me.lblPrompt.Location = New System.Drawing.Point(12, 9)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(56, 13)
        Me.lblPrompt.TabIndex = 7
        Me.lblPrompt.Text = "Password:"
        '
        'lblVerify
        '
        Me.lblVerify.AutoSize = True
        Me.lblVerify.Location = New System.Drawing.Point(12, 53)
        Me.lblVerify.Name = "lblVerify"
        Me.lblVerify.Size = New System.Drawing.Size(36, 13)
        Me.lblVerify.TabIndex = 8
        Me.lblVerify.Text = "Verify:"
        '
        'txtEntry
        '
        Me.txtEntry.Location = New System.Drawing.Point(15, 25)
        Me.txtEntry.Name = "txtEntry"
        Me.txtEntry.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtEntry.Size = New System.Drawing.Size(296, 23)
        Me.txtEntry.TabIndex = 10
        Me.txtEntry.UseSystemPasswordChar = True
        '
        'txtVerify
        '
        Me.txtVerify.Location = New System.Drawing.Point(15, 69)
        Me.txtVerify.Name = "txtVerify"
        Me.txtVerify.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtVerify.Size = New System.Drawing.Size(296, 23)
        Me.txtVerify.TabIndex = 11
        Me.txtVerify.UseSystemPasswordChar = True
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(205, 100)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(46, 23)
        Me.btnDone.TabIndex = 12
        Me.btnDone.Text = "Done"
        '
        'btnCcl
        '
        Me.btnCcl.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCcl.Location = New System.Drawing.Point(258, 100)
        Me.btnCcl.Name = "btnCcl"
        Me.btnCcl.Size = New System.Drawing.Size(53, 23)
        Me.btnCcl.TabIndex = 13
        Me.btnCcl.Text = "Cancel"
        '
        'PswrdCreation
        '
        Me.AcceptButton = Me.btnDone
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnCcl
        Me.ClientSize = New System.Drawing.Size(324, 131)
        Me.Controls.Add(Me.btnCcl)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.txtVerify)
        Me.Controls.Add(Me.txtEntry)
        Me.Controls.Add(Me.lblVerify)
        Me.Controls.Add(Me.lblPrompt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PswrdCreation"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents lblVerify As System.Windows.Forms.Label
    Friend WithEvents txtEntry As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtVerify As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnDone As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCcl As MetroFramework.Controls.MetroButton
End Class
