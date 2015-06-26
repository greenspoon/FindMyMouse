Public Class ListItem

    Private dataobj As Object

    Property DataboundItem As Object
        Get
            Return dataobj
        End Get
        Set(value As Object)
            dataobj = value
        End Set
    End Property


    Sub New()
        InitializeComponent()
    End Sub
    Sub New(databoundItem As Object)

        InitializeComponent()

        Me.DataboundItem = databoundItem
        Me.TextLabel.Text = databoundItem.ToString
    End Sub

    Public Event ItemDeleted(sender As Object, e As ItemDeletedEventArgs)

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

        RaiseEvent ItemDeleted(Me, New ItemDeletedEventArgs() With {.Item = Me})

    End Sub
End Class

Public Class ItemDeletedEventArgs
    Inherits EventArgs

    Property Item As ListItem

End Class

