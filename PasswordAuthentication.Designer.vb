<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordAuthentication
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PasswordAuthentication))
        Me.txtEntry = New System.Windows.Forms.TextBox()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.btnCcl = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtEntry
        '
        Me.txtEntry.BackColor = System.Drawing.Color.LightGray
        Me.txtEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEntry.ForeColor = System.Drawing.Color.Black
        Me.txtEntry.Location = New System.Drawing.Point(15, 27)
        Me.txtEntry.Name = "txtEntry"
        Me.txtEntry.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtEntry.Size = New System.Drawing.Size(298, 20)
        Me.txtEntry.TabIndex = 12
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.ForeColor = System.Drawing.Color.Black
        Me.lblPrompt.Location = New System.Drawing.Point(12, 11)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(56, 13)
        Me.lblPrompt.TabIndex = 13
        Me.lblPrompt.Text = "Password:"
        '
        'btnCcl
        '
        Me.btnCcl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCcl.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCcl.ForeColor = System.Drawing.Color.Black
        Me.btnCcl.Location = New System.Drawing.Point(259, 53)
        Me.btnCcl.Name = "btnCcl"
        Me.btnCcl.Size = New System.Drawing.Size(54, 23)
        Me.btnCcl.TabIndex = 11
        Me.btnCcl.TabStop = False
        Me.btnCcl.Text = "Cancel"
        Me.btnCcl.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDone.ForeColor = System.Drawing.Color.Black
        Me.btnDone.Location = New System.Drawing.Point(207, 53)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(46, 23)
        Me.btnDone.TabIndex = 10
        Me.btnDone.TabStop = False
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'UnlockFile
        '
        Me.AcceptButton = Me.btnDone
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCcl
        Me.ClientSize = New System.Drawing.Size(324, 82)
        Me.Controls.Add(Me.txtEntry)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.btnCcl)
        Me.Controls.Add(Me.btnDone)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UnlockFile"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEntry As System.Windows.Forms.TextBox
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents btnCcl As System.Windows.Forms.Button
    Friend WithEvents btnDone As System.Windows.Forms.Button
End Class
