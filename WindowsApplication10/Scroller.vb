Public Class Scroller



    Private isMouseDown As Boolean = False
    Private Sub ScrollerPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles ScrollerPanel.MouseDown
        isMouseDown = True
    End Sub


    Private Sub ScrollerPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles ScrollerPanel.MouseUp
        isMouseDown = False

    End Sub

    Private Sub ScrollerPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles ScrollerPanel.MouseMove
        'If isMouseDown Then
        'If e.Y Then
        'ScrollerPanel.Location = New Point(ScrollerPanel.Location.X, e.Y)

        'End If
    End Sub
End Class
