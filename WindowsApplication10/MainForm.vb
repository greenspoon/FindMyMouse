Public Class FindMouseForm

    Private MouseTimer As Timer

    ReadOnly Property MousePoint As Point
        Get
            Return New Point()
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
        If Not IsNumeric(XTextBox.Text) Then
            XTextBox.Text = "0"
        End If
    End Sub

    Private Sub FillComboBoxes()

        Dim abc = "abcdefghijklmnopqrstuvwxyz"

        Dim allKeyValues = DirectCast([Enum].GetValues(GetType(Keys)), Keys())
        Dim keyList = New List(Of Key)

        keyList.Add(New Key(Keys.None))

        For Each letter In abc

            Dim currentKey = (From itm In allKeyValues Where [Enum].GetName(GetType(Keys), itm).ToLower.Equals(letter)).SingleOrDefault

            keyList.Add(New Key(currentKey))

        Next

        keyList.Add(New Key(Key.CONTROL, Key.isMODIFIER))
        keyList.Add(New Key(Key.SHIFT, Key.isMODIFIER))
        keyList.Add(New Key(Key.ALT, Key.isMODIFIER))

        Key1ComboBox.DataSource = keyList
        Key2ComboBox.DataSource = keyList.ToArray

        Key1ComboBox.SelectedIndex = 0
        Key2ComboBox.SelectedIndex = 0

    End Sub

    Private Sub FindMouseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FillComboBoxes()

        startTimer()

    End Sub

End Class

