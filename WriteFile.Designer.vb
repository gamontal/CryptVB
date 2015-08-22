<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WriteFile
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
        Me.btnDone1 = New System.Windows.Forms.Button()
        Me.btnCcl1 = New System.Windows.Forms.Button()
        Me.txtPlainText = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSpCheck = New System.Windows.Forms.Button()
        Me.lblWords = New System.Windows.Forms.Label()
        Me.lblChar = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lnkRegular = New System.Windows.Forms.LinkLabel()
        Me.lnkBold = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDone1
        '
        Me.btnDone1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDone1.ForeColor = System.Drawing.Color.Black
        Me.btnDone1.Location = New System.Drawing.Point(784, 525)
        Me.btnDone1.Name = "btnDone1"
        Me.btnDone1.Size = New System.Drawing.Size(48, 22)
        Me.btnDone1.TabIndex = 2
        Me.btnDone1.TabStop = False
        Me.btnDone1.Text = "Done"
        Me.btnDone1.UseVisualStyleBackColor = True
        '
        'btnCcl1
        '
        Me.btnCcl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCcl1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCcl1.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnCcl1.ForeColor = System.Drawing.Color.Red
        Me.btnCcl1.Location = New System.Drawing.Point(728, 525)
        Me.btnCcl1.Name = "btnCcl1"
        Me.btnCcl1.Size = New System.Drawing.Size(50, 23)
        Me.btnCcl1.TabIndex = 3
        Me.btnCcl1.TabStop = False
        Me.btnCcl1.Text = "Cancel"
        Me.btnCcl1.UseVisualStyleBackColor = True
        '
        'txtPlainText
        '
        Me.txtPlainText.BackColor = System.Drawing.Color.White
        Me.txtPlainText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlainText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlainText.Location = New System.Drawing.Point(12, 12)
        Me.txtPlainText.MaxLength = 3000000
        Me.txtPlainText.Multiline = True
        Me.txtPlainText.Name = "txtPlainText"
        Me.txtPlainText.Size = New System.Drawing.Size(820, 503)
        Me.txtPlainText.TabIndex = 4
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(12, 525)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(87, 23)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Clear screen"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSpCheck
        '
        Me.btnSpCheck.Location = New System.Drawing.Point(105, 525)
        Me.btnSpCheck.Name = "btnSpCheck"
        Me.btnSpCheck.Size = New System.Drawing.Size(71, 23)
        Me.btnSpCheck.TabIndex = 6
        Me.btnSpCheck.Text = "Spell check"
        Me.btnSpCheck.UseVisualStyleBackColor = True
        Me.btnSpCheck.Visible = False
        '
        'lblWords
        '
        Me.lblWords.AutoSize = True
        Me.lblWords.Location = New System.Drawing.Point(182, 530)
        Me.lblWords.Name = "lblWords"
        Me.lblWords.Size = New System.Drawing.Size(44, 13)
        Me.lblWords.TabIndex = 7
        Me.lblWords.Text = "Words: "
        '
        'lblChar
        '
        Me.lblChar.AutoSize = True
        Me.lblChar.Location = New System.Drawing.Point(286, 530)
        Me.lblChar.Name = "lblChar"
        Me.lblChar.Size = New System.Drawing.Size(64, 13)
        Me.lblChar.TabIndex = 8
        Me.lblChar.Text = "Characters: "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lnkRegular)
        Me.GroupBox1.Controls.Add(Me.lnkBold)
        Me.GroupBox1.Location = New System.Drawing.Point(417, 521)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(172, 26)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Font Style:"
        '
        'lnkRegular
        '
        Me.lnkRegular.ActiveLinkColor = System.Drawing.Color.Black
        Me.lnkRegular.AutoSize = True
        Me.lnkRegular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkRegular.LinkColor = System.Drawing.Color.Black
        Me.lnkRegular.Location = New System.Drawing.Point(113, 9)
        Me.lnkRegular.Name = "lnkRegular"
        Me.lnkRegular.Size = New System.Drawing.Size(44, 13)
        Me.lnkRegular.TabIndex = 1
        Me.lnkRegular.TabStop = True
        Me.lnkRegular.Text = "Regular"
        '
        'lnkBold
        '
        Me.lnkBold.ActiveLinkColor = System.Drawing.Color.Black
        Me.lnkBold.AutoSize = True
        Me.lnkBold.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkBold.LinkColor = System.Drawing.Color.Black
        Me.lnkBold.Location = New System.Drawing.Point(75, 9)
        Me.lnkBold.Name = "lnkBold"
        Me.lnkBold.Size = New System.Drawing.Size(32, 13)
        Me.lnkBold.TabIndex = 0
        Me.lnkBold.TabStop = True
        Me.lnkBold.Text = "Bold"
        '
        'WriteFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCcl1
        Me.ClientSize = New System.Drawing.Size(844, 554)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblChar)
        Me.Controls.Add(Me.lblWords)
        Me.Controls.Add(Me.btnSpCheck)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtPlainText)
        Me.Controls.Add(Me.btnCcl1)
        Me.Controls.Add(Me.btnDone1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WriteFile"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDone1 As System.Windows.Forms.Button
    Friend WithEvents btnCcl1 As System.Windows.Forms.Button
    Friend WithEvents txtPlainText As System.Windows.Forms.TextBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnSpCheck As System.Windows.Forms.Button
    Friend WithEvents lblWords As System.Windows.Forms.Label
    Friend WithEvents lblChar As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lnkRegular As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkBold As System.Windows.Forms.LinkLabel
End Class
