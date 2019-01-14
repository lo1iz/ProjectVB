Public Class Netflix
    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Dim RT As Integer
        Dim MessageRT As String
        If ComboBoxType.SelectedIndex = 0 Then
            If ComboBoxGenre.SelectedIndex = 0 Then
                If ComboBoxGenre.SelectedIndex = 1 Then
                    If ComboBoxRate.SelectedIndex = 1 Then

                    End If
                End If
                If ComboBoxGenre.SelectedIndex = 2 Then

                End If
                If ComboBoxGenre.SelectedIndex = 3 Then

                End If
                If ComboBoxGenre.SelectedIndex = 4 Then

                End If
                If ComboBoxGenre.SelectedIndex = 5 Then

                End If
                If ComboBoxGenre.SelectedIndex = 6 Then

                End If
            End If
        ElseIf ComboBoxType.SelectedIndex = 1 Then
            If ComboBoxGenre.SelectedIndex = 0 Then
            ElseIf ComboBoxGenre.SelectedIndex = 1 Then
            ElseIf ComboBoxGenre.SelectedIndex = 2 Then
            ElseIf ComboBoxGenre.SelectedIndex = 3 Then
            ElseIf ComboBoxGenre.SelectedIndex = 4 Then
            ElseIf ComboBoxGenre.SelectedIndex = 5 Then
            ElseIf ComboBoxGenre.SelectedIndex = 6 Then
            End If
        End If
        If Integer.TryParse(TextBoxRT.Text, RT) = False Or RT < 0 Then
            MessageBox.Show("Incorrect! Please enter a number of minute", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TextBoxRT.Text = ""
            Return
        ElseIf RT > 60 Then
            MessageRT = "Long Film"
        Else
            MessageRT = "Short Film"
        End If
        MessageBox.Show("Type : " & ComboBoxType.Text & vbNewLine &
                        "Genre : " & ComboBoxGenre.Text & vbNewLine &
                        "Rate : " & ComboBoxRate.Text & vbNewLine &
                        "Runtime : " & MessageRT, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ComboBoxType.SelectedIndex = -1
        ComboBoxGenre.SelectedIndex = -1
        ComboBoxRate.SelectedIndex = -1
        TextBoxRT.Text = ""
        ButtonOK.Enabled = False
        ButtonReset.Enabled = False
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        ComboBoxType.SelectedIndex = -1
        ComboBoxGenre.SelectedIndex = -1
        ComboBoxRate.SelectedIndex = -1
        TextBoxRT.Text = ""
        ButtonOK.Enabled = False
        ButtonReset.Enabled = False
    End Sub

    Private Sub ComboBoxType_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRT.TextChanged, ComboBoxType.TextChanged, ComboBoxRate.TextChanged, ComboBoxGenre.TextChanged

        If ComboBoxType.SelectedIndex <> -1 And ComboBoxGenre.SelectedIndex <> -1 And ComboBoxRate.SelectedIndex <> -1 Then
            TextBoxRT.Enabled = True
        Else
            TextBoxRT.Enabled = False
        End If
        If ComboBoxType.SelectedIndex <> -1 And ComboBoxGenre.SelectedIndex <> -1 And ComboBoxRate.SelectedIndex <> -1 And TextBoxRT.Text <> "" Then
            ButtonOK.Enabled = True
        ElseIf ComboBoxType.Text <> "" And ComboBoxGenre.Text <> "" And ComboBoxRate.Text <> "" And TextBoxRT.Text <> "" Then
            ButtonOK.Enabled = False
        End If
        If ComboBoxType.SelectedIndex <> -1 Or ComboBoxGenre.SelectedIndex <> -1 Or ComboBoxRate.SelectedIndex <> -1 Or TextBoxRT.Text <> "" Then
            ButtonReset.Enabled = True
        Else
            ButtonReset.Enabled = False
        End If
    End Sub
    Private Sub ComboBox1_MouseWheel(sender As Object, e As MouseEventArgs) Handles ComboBoxType.MouseWheel, ComboBoxGenre.MouseWheel, ComboBoxRate.MouseWheel
        Dim MouseWheel As HandledMouseEventArgs = DirectCast(e, HandledMouseEventArgs)
        MouseWheel.Handled = True
    End Sub
End Class