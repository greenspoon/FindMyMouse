<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectKeyForm
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
        Me.OKButton = New System.Windows.Forms.Button()
        Me.KeyComboBox = New System.Windows.Forms.ComboBox()
        Me.SelectKeyLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OKButton
        '
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OKButton.Location = New System.Drawing.Point(12, 62)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(258, 23)
        Me.OKButton.TabIndex = 0
        Me.OKButton.Text = "Select key"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'KeyComboBox
        '
        Me.KeyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.KeyComboBox.FormattingEnabled = True
        Me.KeyComboBox.Location = New System.Drawing.Point(12, 32)
        Me.KeyComboBox.Name = "KeyComboBox"
        Me.KeyComboBox.Size = New System.Drawing.Size(258, 24)
        Me.KeyComboBox.TabIndex = 1
        '
        'SelectKeyLabel
        '
        Me.SelectKeyLabel.AutoSize = True
        Me.SelectKeyLabel.Location = New System.Drawing.Point(12, 9)
        Me.SelectKeyLabel.Name = "SelectKeyLabel"
        Me.SelectKeyLabel.Size = New System.Drawing.Size(87, 17)
        Me.SelectKeyLabel.TabIndex = 2
        Me.SelectKeyLabel.Text = "Select a Key"
        '
        'SelectKeyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 97)
        Me.Controls.Add(Me.SelectKeyLabel)
        Me.Controls.Add(Me.KeyComboBox)
        Me.Controls.Add(Me.OKButton)
        Me.Name = "SelectKeyForm"
        Me.Text = "SelectKeyForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents KeyComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SelectKeyLabel As System.Windows.Forms.Label
End Class
