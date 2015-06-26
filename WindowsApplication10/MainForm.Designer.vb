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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.YTextbox = New FindMyMouse.NumTextbox()
        Me.XTextbox = New FindMyMouse.NumTextbox()
        Me.XYLabel = New System.Windows.Forms.Label()
        Me.AimMouseLocationButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DeleteButtonListBox1 = New FindMyMouse.DeleteButtonListBox()
        Me.AddKeyButton = New System.Windows.Forms.Button()
        Me.StartWindowsCheckBox = New System.Windows.Forms.CheckBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Y"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.YTextbox)
        Me.GroupBox1.Controls.Add(Me.XTextbox)
        Me.GroupBox1.Controls.Add(Me.XYLabel)
        Me.GroupBox1.Controls.Add(Me.AimMouseLocationButton)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 167)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 101)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mouse Location"
        '
        'YTextbox
        '
        Me.YTextbox.Location = New System.Drawing.Point(173, 58)
        Me.YTextbox.Name = "YTextbox"
        Me.YTextbox.Size = New System.Drawing.Size(123, 22)
        Me.YTextbox.TabIndex = 16
        '
        'XTextbox
        '
        Me.XTextbox.Location = New System.Drawing.Point(9, 58)
        Me.XTextbox.Name = "XTextbox"
        Me.XTextbox.Size = New System.Drawing.Size(139, 22)
        Me.XTextbox.TabIndex = 15
        '
        'XYLabel
        '
        Me.XYLabel.AutoSize = True
        Me.XYLabel.Location = New System.Drawing.Point(245, 38)
        Me.XYLabel.Name = "XYLabel"
        Me.XYLabel.Size = New System.Drawing.Size(0, 17)
        Me.XYLabel.TabIndex = 14
        '
        'AimMouseLocationButton
        '
        Me.AimMouseLocationButton.BackgroundImage = Global.FindMyMouse.My.Resources.Resources.scope
        Me.AimMouseLocationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AimMouseLocationButton.Location = New System.Drawing.Point(261, 17)
        Me.AimMouseLocationButton.Name = "AimMouseLocationButton"
        Me.AimMouseLocationButton.Size = New System.Drawing.Size(35, 35)
        Me.AimMouseLocationButton.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.AimMouseLocationButton, "Press and hold the left mouse button and aim for the location you want your curso" & _
        "r to appear, when you fire the shortcut." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.AimMouseLocationButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DeleteButtonListBox1)
        Me.GroupBox2.Controls.Add(Me.AddKeyButton)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(310, 149)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Shortcut"
        '
        'DeleteButtonListBox1
        '
        Me.DeleteButtonListBox1.AutoScroll = True
        Me.DeleteButtonListBox1.BackColor = System.Drawing.Color.Gray
        Me.DeleteButtonListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DeleteButtonListBox1.Location = New System.Drawing.Point(9, 21)
        Me.DeleteButtonListBox1.Name = "DeleteButtonListBox1"
        Me.DeleteButtonListBox1.Size = New System.Drawing.Size(287, 84)
        Me.DeleteButtonListBox1.TabIndex = 12
        '
        'AddKeyButton
        '
        Me.AddKeyButton.Location = New System.Drawing.Point(9, 111)
        Me.AddKeyButton.Name = "AddKeyButton"
        Me.AddKeyButton.Size = New System.Drawing.Size(287, 24)
        Me.AddKeyButton.TabIndex = 11
        Me.AddKeyButton.Text = "Add Key"
        Me.AddKeyButton.UseVisualStyleBackColor = True
        '
        'StartWindowsCheckBox
        '
        Me.StartWindowsCheckBox.AutoSize = True
        Me.StartWindowsCheckBox.Location = New System.Drawing.Point(12, 274)
        Me.StartWindowsCheckBox.Name = "StartWindowsCheckBox"
        Me.StartWindowsCheckBox.Size = New System.Drawing.Size(148, 21)
        Me.StartWindowsCheckBox.TabIndex = 12
        Me.StartWindowsCheckBox.Text = "Start with Windows"
        Me.StartWindowsCheckBox.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'FindMouseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 317)
        Me.Controls.Add(Me.StartWindowsCheckBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FindMouseForm"
        Me.Text = "Find My Mouse"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents StartWindowsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents AimMouseLocationButton As System.Windows.Forms.Button
    Friend WithEvents XYLabel As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents AddKeyButton As System.Windows.Forms.Button
    Friend WithEvents YTextbox As FindMyMouse.NumTextbox
    Friend WithEvents XTextbox As FindMyMouse.NumTextbox
    Friend WithEvents DeleteButtonListBox1 As FindMyMouse.DeleteButtonListBox

End Class
