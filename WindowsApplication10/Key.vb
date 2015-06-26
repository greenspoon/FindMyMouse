Public Class Key

    Property KeyName As String
    Property KeyValue As Integer
    Public Const isMODIFIER As Integer = -1337

    Private Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Short) As Integer

    Private Const KEY_PRESSED As Integer = -127

    Sub New(keyname As String, keyValue As Integer)

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

    Public Const CONTROL As String = "Control"
    Public Const ALT As String = "Alt"
    Public Const SHIFT As String = "Shift"

    Private Function isModifierPressed(name As String) As Boolean

        Select Case name
            Case CONTROL
                Return My.Computer.Keyboard.CtrlKeyDown
            Case ALT
                Return My.Computer.Keyboard.AltKeyDown
            Case SHIFT
                Return My.Computer.Keyboard.ShiftKeyDown
        End Select

        Return False

    End Function

    Public ReadOnly Property isPressed As Boolean
        Get
            Return isKeyPressed()
        End Get
    End Property

    Private Function isKeyPressed() As Boolean

        If KeyValue = isMODIFIER Then
            Return isModifierPressed(KeyName)
        End If

        Return GetKeyState(CShort(Me.KeyValue)) = KEY_PRESSED

    End Function
End Class
