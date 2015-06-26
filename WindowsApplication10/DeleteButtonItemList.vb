Public Class DeleteButtonItemList(Of t)
    Inherits List(Of t)

    Public Event ItemAdded(sender As Object, e As ItemEventArgs(Of t))
    Public Event ItemDeleted(sender As Object, e As ItemEventArgs(Of t))

    Public Property ItemHeight As Integer = 0

    Overloads Sub Add(item As t)
        MyBase.Add(item)
        RaiseEvent ItemAdded(Me, New ItemEventArgs(Of t)(item))

    End Sub

    Overloads Sub Remove(item As t)
        MyBase.Remove(item)
        RaiseEvent ItemDeleted(Me, New ItemEventArgs(Of t)(item))
    End Sub

End Class

Public Class ItemEventArgs(Of t)
    Inherits EventArgs

    Sub New(it As t)
        Me.Item = it
    End Sub

    Property Item As t


End Class
