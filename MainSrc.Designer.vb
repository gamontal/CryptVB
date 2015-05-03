<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainSrc
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainSrc))
        Me.btnEncipher = New System.Windows.Forms.Button()
        Me.btnDecipher = New System.Windows.Forms.Button()
        Me.tooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.btnUnhide = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnEmail = New System.Windows.Forms.Button()
        Me.cmbAlgorithm = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnEncipher
        '
        Me.btnEncipher.BackColor = System.Drawing.Color.Transparent
        Me.btnEncipher.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEncipher.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnEncipher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEncipher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEncipher.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncipher.ForeColor = System.Drawing.Color.Black
        Me.HelpProvider1.SetHelpString(Me.btnEncipher, "Encrypt text. (you can set your file's destination once you create your password)" & _
        "")
        Me.btnEncipher.Location = New System.Drawing.Point(17, 17)
        Me.btnEncipher.Name = "btnEncipher"
        Me.HelpProvider1.SetShowHelp(Me.btnEncipher, True)
        Me.btnEncipher.Size = New System.Drawing.Size(174, 25)
        Me.btnEncipher.TabIndex = 0
        Me.btnEncipher.TabStop = False
        Me.btnEncipher.Text = "&Encipher/"
        Me.btnEncipher.UseVisualStyleBackColor = False
        '
        'btnDecipher
        '
        Me.btnDecipher.BackColor = System.Drawing.Color.Transparent
        Me.btnDecipher.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDecipher.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnDecipher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDecipher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDecipher.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecipher.ForeColor = System.Drawing.Color.Black
        Me.HelpProvider1.SetHelpString(Me.btnDecipher, "Decrypt text. ( *Hidden files will become visible once you decipher them. To chan" & _
        "ge this setting, go to the file's properties, check hidden and click ok )")
        Me.btnDecipher.Location = New System.Drawing.Point(17, 48)
        Me.btnDecipher.Name = "btnDecipher"
        Me.HelpProvider1.SetShowHelp(Me.btnDecipher, True)
        Me.btnDecipher.Size = New System.Drawing.Size(174, 25)
        Me.btnDecipher.TabIndex = 0
        Me.btnDecipher.TabStop = False
        Me.btnDecipher.Text = "/&Decipher"
        Me.btnDecipher.UseVisualStyleBackColor = False
        '
        'btnUnhide
        '
        Me.btnUnhide.BackColor = System.Drawing.Color.Transparent
        Me.btnUnhide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUnhide.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnUnhide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnUnhide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnUnhide.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnUnhide.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!)
        Me.btnUnhide.ForeColor = System.Drawing.Color.Black
        Me.btnUnhide.Location = New System.Drawing.Point(17, 110)
        Me.btnUnhide.Name = "btnUnhide"
        Me.btnUnhide.Size = New System.Drawing.Size(174, 25)
        Me.btnUnhide.TabIndex = 2
        Me.btnUnhide.Text = "&Unhide File"
        Me.btnUnhide.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnClose.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!)
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(17, 141)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(174, 25)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnEmail
        '
        Me.btnEmail.BackColor = System.Drawing.Color.Transparent
        Me.btnEmail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmail.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEmail.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!)
        Me.btnEmail.ForeColor = System.Drawing.Color.Black
        Me.btnEmail.Location = New System.Drawing.Point(17, 79)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(174, 25)
        Me.btnEmail.TabIndex = 10
        Me.btnEmail.Text = "E&MAIL"
        Me.btnEmail.UseVisualStyleBackColor = False
        '
        'cmbAlgorithm
        '
        Me.cmbAlgorithm.FormattingEnabled = True
        Me.cmbAlgorithm.Items.AddRange(New Object() {"RC2", "DES", "3DES", "AES"})
        Me.cmbAlgorithm.Location = New System.Drawing.Point(17, 181)
        Me.cmbAlgorithm.Name = "cmbAlgorithm"
        Me.cmbAlgorithm.Size = New System.Drawing.Size(174, 21)
        Me.cmbAlgorithm.TabIndex = 14
        Me.cmbAlgorithm.Text = "Encryption algorithm"
        '
        'MPGPmainForm
        '
        Me.AcceptButton = Me.btnEncipher
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(209, 216)
        Me.Controls.Add(Me.cmbAlgorithm)
        Me.Controls.Add(Me.btnUnhide)
        Me.Controls.Add(Me.btnEmail)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDecipher)
        Me.Controls.Add(Me.btnEncipher)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpString(Me, "")
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MPGPmainForm"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEncipher As System.Windows.Forms.Button
    Friend WithEvents btnDecipher As System.Windows.Forms.Button
    Friend WithEvents tooltip As System.Windows.Forms.ToolTip
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents btnUnhide As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnEmail As System.Windows.Forms.Button
    Friend WithEvents cmbAlgorithm As System.Windows.Forms.ComboBox
End Class
