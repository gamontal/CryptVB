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
        Me.txtPlainText = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lnkRegular = New System.Windows.Forms.LinkLabel()
        Me.lnkBold = New System.Windows.Forms.LinkLabel()
        Me.btnClear = New MetroFramework.Controls.MetroButton()
        Me.btnSpCheck = New MetroFramework.Controls.MetroButton()
        Me.lblWords = New MetroFramework.Controls.MetroLabel()
        Me.lblChar = New MetroFramework.Controls.MetroLabel()
        Me.btnCcl1 = New MetroFramework.Controls.MetroButton()
        Me.btnDone1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lnkRegular)
        Me.GroupBox1.Controls.Add(Me.lnkBold)
        Me.GroupBox1.Location = New System.Drawing.Point(527, 522)
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
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(12, 525)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear Screen"
        '
        'btnSpCheck
        '
        Me.btnSpCheck.Location = New System.Drawing.Point(93, 525)
        Me.btnSpCheck.Name = "btnSpCheck"
        Me.btnSpCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnSpCheck.TabIndex = 11
        Me.btnSpCheck.Text = "Spell Check"
        '
        'lblWords
        '
        Me.lblWords.AutoSize = True
        Me.lblWords.CustomBackground = True
        Me.lblWords.Location = New System.Drawing.Point(183, 527)
        Me.lblWords.Name = "lblWords"
        Me.lblWords.Size = New System.Drawing.Size(82, 19)
        Me.lblWords.TabIndex = 12
        Me.lblWords.Text = "Word count:"
        '
        'lblChar
        '
        Me.lblChar.AutoSize = True
        Me.lblChar.CustomBackground = True
        Me.lblChar.Location = New System.Drawing.Point(325, 527)
        Me.lblChar.Name = "lblChar"
        Me.lblChar.Size = New System.Drawing.Size(105, 19)
        Me.lblChar.TabIndex = 13
        Me.lblChar.Text = "Character count:"
        '
        'btnCcl1
        '
        Me.btnCcl1.Location = New System.Drawing.Point(723, 525)
        Me.btnCcl1.Name = "btnCcl1"
        Me.btnCcl1.Size = New System.Drawing.Size(55, 23)
        Me.btnCcl1.TabIndex = 14
        Me.btnCcl1.Text = "Cancel"
        '
        'btnDone1
        '
        Me.btnDone1.Location = New System.Drawing.Point(784, 525)
        Me.btnDone1.Name = "btnDone1"
        Me.btnDone1.Size = New System.Drawing.Size(48, 23)
        Me.btnDone1.TabIndex = 15
        Me.btnDone1.Text = "Done"
        '
        'WriteFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 554)
        Me.Controls.Add(Me.btnDone1)
        Me.Controls.Add(Me.btnCcl1)
        Me.Controls.Add(Me.lblChar)
        Me.Controls.Add(Me.lblWords)
        Me.Controls.Add(Me.btnSpCheck)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtPlainText)
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
    Friend WithEvents txtPlainText As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lnkRegular As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkBold As System.Windows.Forms.LinkLabel
    Friend WithEvents btnClear As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSpCheck As MetroFramework.Controls.MetroButton
    Friend WithEvents lblWords As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblChar As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnCcl1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDone1 As MetroFramework.Controls.MetroButton
End Class
