Public Class Form1

    Dim flyingButton As New UnlockerFlyingButton
    Dim configWindow As New ConfigureYourPass

    Sub showUnlockerFlyingButton()
        If (flyingButton.IsDisposed = False) Then
            If (flyingButton.Visible = False) Then
                flyingButton.Visible = True
            End If
        Else
            flyingButton = New UnlockerFlyingButton
            flyingButton.Visible = True
        End If
    End Sub

    Private Sub Form1_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover
        showUnlockerFlyingButton()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0.1 + 45 / 100

        ' create system tray first

        NotifyIcon1.ShowBalloonTip(2000)

        ' read back the element from config
        readConfigFromFile()

    End Sub

    Private Sub readConfigFromFile()
        'where to store the data?
        PassConfig.elementPass(configWindow.TextBox1, configWindow.TextBox2)
        PassConfig.readPass()
    End Sub



    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' cancel the ALT + F4 shortcut
        If (e.CloseReason = CloseReason.UserClosing) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        ' show Configure your pass...
        If (configWindow.IsDisposed) Then

            ' recreate the window
            configWindow = New ConfigureYourPass

            ' re-read back
            readConfigFromFile()
        End If

        configWindow.Visible = True

    End Sub

    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles Label1.MouseHover
        showUnlockerFlyingButton()
        Cursor.Hide()
    End Sub
End Class
