<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scroller
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ScrollerPanel = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'ScrollerPanel
        '
        Me.ScrollerPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ScrollerPanel.BackColor = System.Drawing.Color.Black
        Me.ScrollerPanel.Location = New System.Drawing.Point(3, 3)
        Me.ScrollerPanel.Name = "ScrollerPanel"
        Me.ScrollerPanel.Size = New System.Drawing.Size(13, 33)
        Me.ScrollerPanel.TabIndex = 0
        '
        'Scroller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.ScrollerPanel)
        Me.Name = "Scroller"
        Me.Size = New System.Drawing.Size(19, 148)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ScrollerPanel As System.Windows.Forms.Panel

End Class
