<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnlockerFlyingButton
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Image = Global.LockScreen.My.Resources.Resources.unlock
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 37)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Unlock Screen"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UnlockerFlyingButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(119, 40)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UnlockerFlyingButton"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "UnlockerFlyingButton"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
End Class
