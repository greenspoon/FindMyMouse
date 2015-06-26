Imports System.Text

Public Class NumTextbox
    Inherits TextBox

    Sub New()
        initKeyList()
    End Sub

    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)

        e.SuppressKeyPress = Not isInKeylist(e.KeyCode)

        MyBase.OnKeyDown(e)
    End Sub

    Private Function isInKeylist(Key As Keys) As Boolean
        Return (From itm In keylist Where itm.Equals(Key)).Count > 0
    End Function


    Private keylist As List(Of Keys)


    Sub initKeyList()

        keylist = New List(Of Keys)
        keylist.Add(Keys.NumPad0)
        keylist.Add(Keys.NumPad1)
        keylist.Add(Keys.NumPad2)
        keylist.Add(Keys.NumPad3)
        keylist.Add(Keys.NumPad4)
        keylist.Add(Keys.NumPad5)
        keylist.Add(Keys.NumPad6)
        keylist.Add(Keys.NumPad7)
        keylist.Add(Keys.NumPad8)
        keylist.Add(Keys.NumPad9)
        keylist.Add(Keys.NumPad9)
        keylist.Add(Keys.Left)
        keylist.Add(Keys.Right)
        keylist.Add(Keys.Tab)
        keylist.Add(Keys.Back)
        keylist.Add(Keys.Delete)
        keylist.Add(Keys.D0)
        keylist.Add(Keys.D1)
        keylist.Add(Keys.D2)
        keylist.Add(Keys.D3)
        keylist.Add(Keys.D4)
        keylist.Add(Keys.D5)
        keylist.Add(Keys.D6)
        keylist.Add(Keys.D7)
        keylist.Add(Keys.D8)
        keylist.Add(Keys.D9)
        keylist.Add(Keys.D9)

    End Sub
End Class
