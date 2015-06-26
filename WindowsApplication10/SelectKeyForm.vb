Public Class SelectKeyForm

    Private isStarted As Boolean = False

    Private Sub SelectKeyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim keyList = New List(Of Key)

        'get every key avaible in the Keys Enum and add to a list 
        For Each itm In [Enum].GetValues(GetType(Keys))
            If DirectCast(itm, Keys) <> Keys.None Then
                keyList.Add(New Key(DirectCast(itm, Keys)))
            End If
        Next

        KeyComboBox.DataSource = keyList


        isStarted = True
        Me.SelectedKey = DirectCast(KeyComboBox.SelectedItem, Key)
    End Sub
    Property SelectedKey As Key

    Private Sub KeyComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KeyComboBox.SelectedIndexChanged
        If isStarted Then
            Me.SelectedKey = DirectCast(KeyComboBox.SelectedItem, Key)
        End If
    End Sub

End Class