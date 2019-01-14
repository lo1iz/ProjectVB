Public Class Netflix
    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Dim RT As Integer
        Dim MessageRT As String
        Dim ValueType As Double
        Dim ValueGenre As Double
        Dim ValueRate As Double
        Dim Result As String

        'Change string to double for easy work in process
        If ComboBoxType.SelectedItem = "Movie" Then
            ValueType = 0
        ElseIf ComboBoxType.SelectedItem = "Series" Then
            ValueType = 1
        End If

        If ComboBoxGenre.SelectedItem = "Action" Then
            ValueGenre = 0
        ElseIf ComboBoxGenre.SelectedItem = "Adventure" Then
            ValueGenre = 1
        ElseIf ComboBoxGenre.SelectedItem = "Animation" Then
            ValueGenre = 2
        ElseIf ComboBoxGenre.SelectedItem = "Biography" Then
            ValueGenre = 3
        ElseIf ComboBoxGenre.SelectedItem = "Comedy" Then
            ValueGenre = 4
        ElseIf ComboBoxGenre.SelectedItem = "Crime" Then
            ValueGenre = 5
        ElseIf ComboBoxGenre.SelectedItem = "Documentary" Then
            ValueGenre = 6
        ElseIf ComboBoxGenre.SelectedItem = "Drama" Then
            ValueGenre = 7
        ElseIf ComboBoxGenre.SelectedItem = "Musical" Then
            ValueGenre = 8
        ElseIf ComboBoxGenre.SelectedItem = "Mystery" Then
            ValueGenre = 9
        ElseIf ComboBoxGenre.SelectedItem = "Reality-TV" Then
            ValueGenre = 10
        ElseIf ComboBoxGenre.SelectedItem = "Thriller" Then
            ValueGenre = 11
        End If

        If ComboBoxRate.SelectedItem = "G" Then
            ValueRate = 0
        ElseIf ComboBoxRate.SelectedItem = "PASSED" Then
            ValueRate = 1
        ElseIf ComboBoxRate.SelectedItem = "PG" Then
            ValueRate = 2
        ElseIf ComboBoxRate.SelectedItem = "PG-13" Then
            ValueRate = 3
        ElseIf ComboBoxRate.SelectedItem = "R" Then
            ValueRate = 4
        ElseIf ComboBoxRate.SelectedItem = "TV-14" Then
            ValueRate = 5
        ElseIf ComboBoxRate.SelectedItem = "TV-G" Then
            ValueRate = 6
        ElseIf ComboBoxRate.SelectedItem = "TV-MA" Then
            ValueRate = 7
        ElseIf ComboBoxRate.SelectedItem = "TV-PG" Then
            ValueRate = 8
        ElseIf ComboBoxRate.SelectedItem = "TV-Y" Then
            ValueRate = 9
        ElseIf ComboBoxRate.SelectedItem = "TV-Y7" Then
            ValueRate = 10
        End If

        'Main process
        If ValueType <= 0.5 Then
            If ValueGenre <= 3.5 Then
                If ValueGenre <= 1.5 Then
                    If ValueRate <= 1.0 Then
                        Result = "Good"
                    Else
                        Result = "Bad"
                    End If
                Else
                    If ValueRate <= 3.0 Then
                        Result = "Good"
                    Else
                        Result = "Bad"
                    End If
                End If
            Else
                If ValueRate <= 2.5 Then
                    If ValueGenre <= 5.0 Then
                        Result = "Bad"
                    Else
                        Result = "Bad"
                    End If
                Else
                    If ValueGenre <= 7.5 Then
                        Result = "Bad"
                    Else
                        Result = "Good"
                    End If
                End If
            End If
        Else
            If ValueGenre <= 4.5 Then
                If ValueRate <= 6.5 Then
                    If ValueGenre <= 1.5 Then
                        Result = "Good"
                    Else
                        Result = "Good"
                    End If
                Else
                    If ValueRate <= 8.5 Then
                        Result = "Good"
                    Else
                        Result = "Good"
                    End If
                End If
            Else
                Result = "Good"
            End If
        End If

        'This is alert message when enter incorrect value
        If Integer.TryParse(TextBoxRT.Text, RT) = False Or RT < 0 Then
            MessageBox.Show("Please enter a number of minute", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TextBoxRT.Text = ""
            Return
        ElseIf RT > 60 Then
            MessageRT = "Long Film"
        Else
            MessageRT = "Short Film"
        End If

        'Show results message
        MessageBox.Show("Type : " & ComboBoxType.Text & vbNewLine &
                        "Genre : " & ComboBoxGenre.Text & vbNewLine &
                        "Rate : " & ComboBoxRate.Text & vbNewLine &
                        "Runtime : " & MessageRT & vbNewLine &
                        "Result : " & Result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'Reset UI to defalt when the message is shown
        ComboBoxType.SelectedIndex = -1
        ComboBoxGenre.SelectedIndex = -1
        ComboBoxRate.SelectedIndex = -1
        TextBoxRT.Text = ""
        ButtonOK.Enabled = False
        ButtonReset.Enabled = False
    End Sub

    'This is Button Reset
    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        ComboBoxType.SelectedIndex = -1
        ComboBoxGenre.SelectedIndex = -1
        ComboBoxRate.SelectedIndex = -1
        TextBoxRT.Text = ""
        ButtonOK.Enabled = False
        ButtonReset.Enabled = False
    End Sub

    'This is function enable/disable in textbox and button
    Private Sub ComboBoxType_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRT.TextChanged, ComboBoxType.TextChanged, ComboBoxRate.TextChanged, ComboBoxGenre.TextChanged

        If ComboBoxType.SelectedIndex <> -1 And ComboBoxGenre.SelectedIndex <> -1 And ComboBoxRate.SelectedIndex <> -1 Then
            TextBoxRT.Enabled = True
        Else
            TextBoxRT.Enabled = False
        End If
        If ComboBoxType.SelectedIndex <> -1 And ComboBoxGenre.SelectedIndex <> -1 And ComboBoxRate.SelectedIndex <> -1 And TextBoxRT.Text <> "" Then
            ButtonOK.Enabled = True
        Else
            ButtonOK.Enabled = False
        End If
        If ComboBoxType.SelectedIndex <> -1 Or ComboBoxGenre.SelectedIndex <> -1 Or ComboBoxRate.SelectedIndex <> -1 Or TextBoxRT.Text <> "" Then
            ButtonReset.Enabled = True
        Else
            ButtonReset.Enabled = False
        End If
    End Sub

    'This is function disabled mouse wheel in combobox
    Private Sub ComboBox1_MouseWheel(sender As Object, e As MouseEventArgs) Handles ComboBoxType.MouseWheel, ComboBoxGenre.MouseWheel, ComboBoxRate.MouseWheel
        Dim MouseWheel As HandledMouseEventArgs = DirectCast(e, HandledMouseEventArgs)
        MouseWheel.Handled = True
    End Sub
End Class