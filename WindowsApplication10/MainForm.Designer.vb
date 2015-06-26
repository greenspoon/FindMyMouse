<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindMouseForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Key1ComboBox = New System.Windows.Forms.ComboBox()
        Me.PlusLabel = New System.Windows.Forms.Label()
        Me.Key2ComboBox = New System.Windows.Forms.ComboBox()
        Me.Key1Label = New System.Windows.Forms.Label()
        Me.Key2Label = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NumTextbox2 = New FindMyMouse.NumTextbox()
        Me.NumTextbox1 = New FindMyMouse.NumTextbox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Y"
        '
        'Key1ComboBox
        '
        Me.Key1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Key1ComboBox.FormattingEnabled = True
        Me.Key1ComboBox.Location = New System.Drawing.Point(9, 48)
        Me.Key1ComboBox.Name = "Key1ComboBox"
        Me.Key1ComboBox.Size = New System.Drawing.Size(123, 24)
        Me.Key1ComboBox.TabIndex = 5
        '
        'PlusLabel
        '
        Me.PlusLabel.AutoSize = True
        Me.PlusLabel.Location = New System.Drawing.Point(146, 51)
        Me.PlusLabel.Name = "PlusLabel"
        Me.PlusLabel.Size = New System.Drawing.Size(16, 17)
        Me.PlusLabel.TabIndex = 7
        Me.PlusLabel.Text = "+"
        '
        'Key2ComboBox
        '
        Me.Key2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Key2ComboBox.FormattingEnabled = True
        Me.Key2ComboBox.Location = New System.Drawing.Point(173, 48)
        Me.Key2ComboBox.Name = "Key2ComboBox"
        Me.Key2ComboBox.Size = New System.Drawing.Size(123, 24)
        Me.Key2ComboBox.TabIndex = 8
        '
        'Key1Label
        '
        Me.Key1Label.AutoSize = True
        Me.Key1Label.Location = New System.Drawing.Point(6, 28)
        Me.Key1Label.Name = "Key1Label"
        Me.Key1Label.Size = New System.Drawing.Size(44, 17)
        Me.Key1Label.TabIndex = 9
        Me.Key1Label.Text = "Key 1"
        '
        'Key2Label
        '
        Me.Key2Label.AutoSize = True
        Me.Key2Label.Location = New System.Drawing.Point(171, 28)
        Me.Key2Label.Name = "Key2Label"
        Me.Key2Label.Size = New System.Drawing.Size(44, 17)
        Me.Key2Label.TabIndex = 9
        Me.Key2Label.Text = "Key 2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NumTextbox2)
        Me.GroupBox1.Controls.Add(Me.NumTextbox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 101)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mouse Location"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Key1ComboBox)
        Me.GroupBox2.Controls.Add(Me.PlusLabel)
        Me.GroupBox2.Controls.Add(Me.Key2Label)
        Me.GroupBox2.Controls.Add(Me.Key1Label)
        Me.GroupBox2.Controls.Add(Me.Key2ComboBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(310, 100)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Shortcut"
        '
        'NumTextbox2
        '
        Me.NumTextbox2.Location = New System.Drawing.Point(173, 58)
        Me.NumTextbox2.Name = "NumTextbox2"
        Me.NumTextbox2.Size = New System.Drawing.Size(123, 22)
        Me.NumTextbox2.TabIndex = 5
        Me.NumTextbox2.Text = "0"
        '
        'NumTextbox1
        '
        Me.NumTextbox1.Location = New System.Drawing.Point(9, 58)
        Me.NumTextbox1.Name = "NumTextbox1"
        Me.NumTextbox1.Size = New System.Drawing.Size(123, 22)
        Me.NumTextbox1.TabIndex = 4
        Me.NumTextbox1.Text = "0"
        '
        'FindMouseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 237)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FindMouseForm"
        Me.Text = "Find Mouse"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents YTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Key1ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PlusLabel As System.Windows.Forms.Label
    Friend WithEvents Key2ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Key1Label As System.Windows.Forms.Label
    Friend WithEvents Key2Label As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents NumTextbox2 As FindMyMouse.NumTextbox
    Friend WithEvents NumTextbox1 As FindMyMouse.NumTextbox

End Class
