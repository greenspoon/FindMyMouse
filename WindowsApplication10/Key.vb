Public Class Key
    'user32 lib for getting the current state of a key
    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As System.Windows.Forms.Keys) As Short

    Property KeyName As String
    Property KeyValue As Keys

    Public ReadOnly Property isPressed As Boolean
        Get
            Return GetAsyncKeyState(Me.KeyValue) <> 0
        End Get
    End Property

    Sub New(keyname As String, keyValue As Keys)

        Me.KeyName = keyname
        Me.KeyValue = keyValue

    End Sub

    Sub New()

    End Sub

    Sub New(WinKey As Keys)
        Me.KeyName = [Enum].GetName(GetType(Keys), WinKey)
        Me.KeyValue = WinKey
    End Sub

    Public Overrides Function ToString() As String
        Return KeyName
    End Function

End Class
