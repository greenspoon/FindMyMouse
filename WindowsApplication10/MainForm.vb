Imports Microsoft.Win32

Public Class FindMouseForm

    Private Const DQUOTE = """"
    Private Const APPNAME = "FindMyMouse"
    Private Const WINDOWSRUNREGKEY = "SOFTWARE\Microsoft\Windows\CurrentVersion\Run\"
    Private MouseTimer As Timer
    Private isStared As Boolean = False

    Private SystemTrayContextMenu As System.Windows.Forms.ContextMenu

    ReadOnly Property MousePoint As Point
        Get
            Return My.Settings.MousePoint
        End Get
    End Property


    Private Sub startTimer()

        MouseTimer = New Timer

        MouseTimer.Interval = 10

        AddHandler MouseTimer.Tick, Sub()
                                        'getting the selected items from the comboboxes and casting into Key
                                        Dim selectedKeys = {DirectCast(Key1ComboBox.SelectedItem, Key), DirectCast(Key2ComboBox.SelectedItem, Key)}

                                        'selecting just the keys that are not set to "None"
                                        Dim notNoneKeys = (From it In selectedKeys Where it.KeyValue <> Keys.None).ToList

                                        If notNoneKeys.Count > 0 Then

                                            'if every key is pressed set the locatin of the cursor
                                            If (From itm In notNoneKeys Where itm.isPressed = True).Count = notNoneKeys.Count Then
                                                Windows.Forms.Cursor.Position = MousePoint
                                            End If
                                        End If

                                    End Sub

        MouseTimer.Start()

    End Sub


    Private Sub TextBoxes_Event(sender As Object, e As EventArgs) Handles XTextBox.TextChanged, YTextBox.TextChanged

        'Save the mouse cursor location to the Settings by leaving a Textbox
        If isStared Then
            My.Settings.MousePoint = New Point(CInt(XTextBox.Text), CInt(YTextBox.Text))
            My.Settings.Save()
        End If

    End Sub

    Private Sub FillComboBoxes()


        Dim keyList = New List(Of Key)

        'get every key avaible in the Keys Enum and add to a list 
        For Each itm In [Enum].GetValues(GetType(Keys))
            keyList.Add(New Key(DirectCast(itm, Keys)))
        Next


        Key1ComboBox.DataSource = keyList

        'when you don't do .ToArray an the keylist it will bind both to the same list
        'which will trigger the selection event on both comboxes at the same time
        Key2ComboBox.DataSource = keyList.ToArray

        Key1ComboBox.SelectedIndex = My.Settings.Keys.X
        Key2ComboBox.SelectedIndex = My.Settings.Keys.Y

    End Sub


    Private Sub minimizeInTray()

        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
        NotifyIcon1.Visible = True
        NotifyIcon1.Icon = My.Resources.mouse
        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.Text = APPNAME
        NotifyIcon1.BalloonTipTitle = APPNAME
        NotifyIcon1.BalloonTipText = My.Resources.NowInTray
        NotifyIcon1.ShowBalloonTip(2000)
        NotifyIcon1.ContextMenu = SystemTrayContextMenu

    End Sub

    Private Sub initContextMenu()

        SystemTrayContextMenu = New ContextMenu
        Dim ExitMenuItem = New MenuItem(My.Resources.MenuItemExit)

        AddHandler ExitMenuItem.Click, Sub()
                                           Me.Close()
                                       End Sub

        Dim OpenMenuItem = New MenuItem(My.Resources.MenuItemOpen)

        AddHandler OpenMenuItem.Click, Sub()
                                           OpenFromSystemTray()
                                       End Sub

        Me.SystemTrayContextMenu.MenuItems.Add(ExitMenuItem)
        Me.SystemTrayContextMenu.MenuItems.Add(OpenMenuItem)


    End Sub


    Private Sub FindMouseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Starts the application in system tray if the command line parameter m is there - for the windowsstartup
        If My.Application.CommandLineArgs.Count > 0 AndAlso My.Application.CommandLineArgs(0).Contains("m") Then
            minimizeInTray()
        End If

        'init the Context menu for system tray icon
        initContextMenu()

        'load settings for mouse coordinates
        XTextBox.Text = My.Settings.MousePoint.X.ToString
        YTextBox.Text = My.Settings.MousePoint.Y.ToString

        'load "Start with windows" from registry
        SetCheckBox()

        'fill hotkey comboboxes with windows keys
        FillComboBoxes()

        'start the timer that look if a key was pressed
        startTimer()

        'flag for several methods to avoid event triggering to avoid overriding settings. 
        isStared = True

        Me.Icon = My.Resources.mouse

    End Sub

    Private Sub Key1ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Key1ComboBox.SelectedIndexChanged, Key2ComboBox.SelectedIndexChanged

        If isStared = True Then
            My.Settings.Reload()
            My.Settings.Keys = New Point(Key1ComboBox.SelectedIndex, Key2ComboBox.SelectedIndex)
            My.Settings.Save()
        End If

    End Sub



    Private Sub SetCheckBox()
        Try
            Dim regKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default).OpenSubKey(WINDOWSRUNREGKEY)
            Dim value = regKey.GetValue(APPNAME)
            Me.StartWindowsCheckBox.Checked = True
        Catch ex As Exception
            Me.StartWindowsCheckBox.Checked = False
        End Try

    End Sub

    Private Sub StartWindowsCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles StartWindowsCheckBox.CheckedChanged

        If isStared Then

            If StartWindowsCheckBox.Checked Then

                Dim appPath = IO.Path.Combine(My.Application.Info.DirectoryPath, My.Application.Info.AssemblyName) + ".exe -m"
                Dim regKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default).OpenSubKey(WINDOWSRUNREGKEY, True)
                regKey.SetValue(APPNAME, appPath)

            Else

                Dim regKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default).OpenSubKey(WINDOWSRUNREGKEY, True)
                regKey.DeleteValue(APPNAME)

            End If
        End If

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub FindMouseForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            minimizeInTray()
        Else
            OpenFromSystemTray()
        End If
    End Sub

    Private Sub OpenFromSystemTray()
        Me.TopMost = True
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
        Me.TopMost = False
    End Sub


    Private Sub AimMouseLocationButton_MouseDown(sender As Object, e As MouseEventArgs) Handles AimMouseLocationButton.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Left Then

            Dim timer As New Timer() With {
                    .Interval = 10
                }
            AddHandler timer.Tick, Sub()

                                       Dim LocalMousePosition = Cursor.Position

                                       XTextBox.Text = LocalMousePosition.X.ToString
                                       YTextBox.Text = LocalMousePosition.Y.ToString

                                       If Key.GetAsyncKeyState(Keys.LButton) = 0 Then

                                           timer.Stop()
                                           Me.Cursor = Cursors.Default

                                       End If

                                   End Sub
            timer.Start()

            Me.Cursor = Cursors.Cross

        End If

    End Sub

End Class

