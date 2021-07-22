Module PassConfig

    Dim appData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    Dim appName = "LockScreen"
    Dim filename = "configPass.inf"
    Dim path As String = appData & "\\" & appName & "\\" & filename

    Dim textRef1 As TextBox
    Dim textRef2 As TextBox

    Public Sub writePass(ByVal textValue As String)
        'saving string to file
        'using generic path


        'MessageBox.Show(appData & "\\" & appName)



        'If IO.File.Exists(path) = False Then

        Dim ArrayData() As String = {textValue}
        IO.File.WriteAllLines(path, ArrayData)


        'End If
    End Sub

    Function readPass()

        Dim data As String = Nothing

        If (IO.File.Exists(path)) Then

            Dim Lines = IO.File.ReadAllLines(path)
            For Each line In Lines
                If (line.Length > 0) Then
                    data = line
                End If

            Next

        End If

        'directly
        PassConfig.storeData(data)

        Return data
    End Function

    Sub storeData(ByVal dataNa As String)

        If (textRef1 IsNot Nothing) Then
            textRef1.Text = dataNa
            textRef2.Text = dataNa
        End If


    End Sub


    Sub elementPass(ByVal textbox1, ByVal textbox2)
        textRef1 = textbox1
        textRef2 = textbox2
    End Sub

End Module
