<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.tooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.cmbAlgorithm = New System.Windows.Forms.ComboBox()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.btnWrite = New MetroFramework.Controls.MetroButton()
        Me.btnOpen = New MetroFramework.Controls.MetroButton()
        Me.btnUnhide = New MetroFramework.Controls.MetroButton()
        Me.btnEmail = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'cmbAlgorithm
        '
        Me.cmbAlgorithm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAlgorithm.FormattingEnabled = True
        Me.cmbAlgorithm.Items.AddRange(New Object() {"RC2", "DES", "3DES", "AES"})
        Me.cmbAlgorithm.Location = New System.Drawing.Point(21, 226)
        Me.cmbAlgorithm.Name = "cmbAlgorithm"
        Me.cmbAlgorithm.Size = New System.Drawing.Size(166, 23)
        Me.cmbAlgorithm.TabIndex = 14
        Me.cmbAlgorithm.Text = "Encryption algorithm"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(21, 188)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(166, 31)
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "Close"
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(21, 36)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(166, 31)
        Me.btnWrite.Style = MetroFramework.MetroColorStyle.Silver
        Me.btnWrite.TabIndex = 20
        Me.btnWrite.Text = "Write File"
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(21, 74)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(166, 31)
        Me.btnOpen.TabIndex = 21
        Me.btnOpen.Text = "Open File"
        '
        'btnUnhide
        '
        Me.btnUnhide.Location = New System.Drawing.Point(21, 112)
        Me.btnUnhide.Name = "btnUnhide"
        Me.btnUnhide.Size = New System.Drawing.Size(166, 31)
        Me.btnUnhide.TabIndex = 22
        Me.btnUnhide.Text = "Unhide File"
        '
        'btnEmail
        '
        Me.btnEmail.Location = New System.Drawing.Point(21, 150)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(166, 31)
        Me.btnEmail.TabIndex = 23
        Me.btnEmail.Text = "EMAIL"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(209, 275)
        Me.Controls.Add(Me.btnEmail)
        Me.Controls.Add(Me.btnUnhide)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnWrite)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.cmbAlgorithm)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me, "")
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Resizable = False
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Theme = MetroFramework.MetroThemeStyle.Light
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tooltip As System.Windows.Forms.ToolTip
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents cmbAlgorithm As System.Windows.Forms.ComboBox
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents btnWrite As MetroFramework.Controls.MetroButton
    Friend WithEvents btnOpen As MetroFramework.Controls.MetroButton
    Friend WithEvents btnUnhide As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEmail As MetroFramework.Controls.MetroButton
End Class
