Public Class ConfigureYourPass

    Dim myPass As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        myPass = TextBox1.Text

        PassConfig.writePass(myPass)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

        Button1.Enabled = validatePassBoth()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        Button1.Enabled = validatePassBoth()

    End Sub

    Function validatePassBoth()

        If (TextBox1.Text.Equals(TextBox2.Text)) Then
            Return True
        End If

        Return False

    End Function

    Private Sub ConfigureYourPass_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Me.Dispose()
    End Sub
End Class