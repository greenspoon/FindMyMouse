Public Class FindMouseForm

    Private MouseTimer As Timer

    ReadOnly Property MousePoint As Point
        Get
            Return My.Settings.MousePoint
        End Get
    End Property


    Private Sub startTimer()

        MouseTimer = New Timer

        MouseTimer.Interval = 10

        AddHandler MouseTimer.Tick, Sub()

                                        Dim selectedKeys = {DirectCast(Key1ComboBox.SelectedItem, Key), DirectCast(Key2ComboBox.SelectedItem, Key)}
                                        Dim notNoneKeys = (From it In selectedKeys Where it.KeyValue <> Keys.None).ToList

                                        If notNoneKeys.Count > 0 Then
                                            If (From itm In notNoneKeys Where itm.isPressed = True).Count = notNoneKeys.Count Then
                                                Windows.Forms.Cursor.Position = MousePoint
                                            End If
                                        End If

                                    End Sub

        MouseTimer.Start()

    End Sub


    Private Sub XTextBox_Leave(sender As Object, e As EventArgs) Handles XTextBox.Leave, YTextBox.Leave

        My.Settings.MousePoint = New Point(CInt(XTextBox.Text), CInt(YTextBox.Text))
        My.Settings.Save()

    End Sub

    Private Sub FillComboBoxes()

        Dim abc = "abcdefghijklmnopqrstuvwxyz"

        Dim allKeyValues = DirectCast([Enum].GetValues(GetType(Keys)), Keys())
        Dim keyList = New List(Of Key)

        keyList.Add(New Key(Keys.None))

        keyList.Add(New Key(Key.CONTROL, Key.isMODIFIER))
        keyList.Add(New Key(Key.SHIFT, Key.isMODIFIER))
        keyList.Add(New Key(Key.ALT, Key.isMODIFIER))

        For Each letter In abc

            Dim currentKey = (From itm In allKeyValues Where [Enum].GetName(GetType(Keys), itm).ToLower.Equals(letter)).SingleOrDefault

            keyList.Add(New Key(currentKey))

        Next

        Key1ComboBox.DataSource = keyList
        Key2ComboBox.DataSource = keyList.ToArray

        Key1ComboBox.SelectedIndex = My.Settings.Keys.X
        Key2ComboBox.SelectedIndex = My.Settings.Keys.Y

        isStared = True
    End Sub
    Private isStared As Boolean = False
    Private Sub FindMouseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        XTextBox.Text = My.Settings.MousePoint.X.ToString
        YTextBox.Text = My.Settings.MousePoint.Y.ToString

        FillComboBoxes()

        startTimer()

    End Sub

    Private Sub Key1ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Key1ComboBox.SelectedIndexChanged, Key2ComboBox.SelectedIndexChanged
        If isStared = True Then
            My.Settings.Reload()
            My.Settings.Keys = New Point(Key1ComboBox.SelectedIndex, Key2ComboBox.SelectedIndex)
            My.Settings.Save()
        End If

    End Sub
End Class

