Public Class DeleteButtonListBox
    Inherits Panel


    Sub New()
        Items = New DeleteButtonItemList(Of ListItem)
        AddHandler Items.ItemAdded, AddressOf Items_ItemAdded
        AddHandler Items.ItemDeleted, AddressOf Items_ItemDeleted

        Dim scrollbar = New VScrollBar()
        scrollbar.Dock = DockStyle.Right
        AddHandler scrollbar.Scroll, Sub()
                                         Me.VerticalScroll.Value = scrollbar.Value
                                     End Sub


    End Sub

    Property Items As DeleteButtonItemList(Of ListItem)

    Private Sub Items_ItemAdded(sender As Object, e As ItemEventArgs(Of ListItem))

        DrawItems()

    End Sub

    Private Sub Items_ItemDeleted(sender As Object, e As ItemEventArgs(Of ListItem))

        Me.Controls.Remove(e.Item)
        DrawItems()

    End Sub

    Private Const ITEMDISTANCE As Integer = 3

    Private Sub DrawItems()

        Me.Controls.Clear()

        For i As Integer = 0 To Items.Count - 1
            Dim itm = Items(i)
            itm.Location = New Point(0, (i * itm.Height) + (ITEMDISTANCE * i))
            itm.Width = Me.Width
            itm.Anchor = AnchorStyles.Left And AnchorStyles.Right
            Me.Controls.Add(itm)

        Next

    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'DeleteButtonListBox
        '
        Me.AutoScroll = True
        Me.ResumeLayout(False)

    End Sub
End Class
