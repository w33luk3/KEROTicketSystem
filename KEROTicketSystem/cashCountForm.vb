Public Class cashCountForm
    Dim iTotal As String = "0"

    Private Sub AddTotals()

        Try
            iTotal = twentyTotal.Text + +tenTotal.Text + +fiveTotal.Text + +oneTotal.Text + +fiftyTotal.Text + +twentypTotal.Text + +tenpTotal.Text + +fivepTotal.Text + +onepTotal.Text
            totalLabel.Text = "TOTAL:   " & FormatCurrency(iTotal)

        Catch ex As Exception
        End Try
    End Sub

    Private Sub twentyTextBox_TextChanged(sender As Object, e As EventArgs) Handles twentyTextBox.TextChanged
        Try
            If twentyTextBox.Text = String.Empty Then
                twentyTextBox.Text = "0"
            Else
                twentyTotal.Text = FormatCurrency(twentyTextBox.Text * twentyLabel.Text)
                AddTotals()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tenTextBox_TextChanged(sender As Object, e As EventArgs) Handles tenTextBox.TextChanged
        Try
            If tenTextBox.Text = String.Empty Then
                tenTotal.Text = "0"
            Else
                tenTotal.Text = FormatCurrency(tenTextBox.Text * tenLabel.Text)
                AddTotals()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub fiveTextBox_TextChanged(sender As Object, e As EventArgs) Handles fiveTextBox.TextChanged
        Try
            If fiveTextBox.Text = String.Empty Then
                fiveTotal.Text = "0"
            Else
                fiveTotal.Text = FormatCurrency(fiveTextBox.Text * fiveLabel.Text)
                AddTotals()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub oneTextBox_TextChanged(sender As Object, e As EventArgs) Handles oneTextBox.TextChanged
        Try
            If oneTextBox.Text = String.Empty Then
                oneTotal.Text = "0"
            Else
                oneTotal.Text = FormatCurrency(oneTextBox.Text * oneLabel.Text)
                AddTotals()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub fiftyTextBox_TextChanged(sender As Object, e As EventArgs) Handles fiftyTextBox.TextChanged
        Try
            If fiftyTextBox.Text = String.Empty Then
                fiftyTotal.Text = "0"
            Else
                fiftyTotal.Text = FormatCurrency(fiftyTextBox.Text * fiftyLabel.Text)
                AddTotals()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub twentypTextBox_TextChanged(sender As Object, e As EventArgs) Handles twentypTextBox.TextChanged
        Try
            If twentypTextBox.Text = String.Empty Then
                twentypTotal.Text = "0"
            Else
                twentypTotal.Text = FormatCurrency(twentypTextBox.Text * twentypLabel.Text)
                AddTotals()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tenpTextBox_TextChanged(sender As Object, e As EventArgs) Handles tenpTextBox.TextChanged
        Try
            If tenpTextBox.Text = String.Empty Then
                tenpTotal.Text = "0"
            Else
                tenpTotal.Text = FormatCurrency(tenpTextBox.Text * tenpLabel.Text)
                AddTotals()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub fivepTextBox_TextChanged(sender As Object, e As EventArgs) Handles fivepTextBox.TextChanged
        Try
            If fivepTextBox.Text = String.Empty Then
                fivepTotal.Text = "0"
            Else
                fivepTotal.Text = FormatCurrency(fivepTextBox.Text * fivepLabel.Text)
                AddTotals()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub onepTextBox_TextChanged(sender As Object, e As EventArgs) Handles onepTextBox.TextChanged
        Try
            If onepTextBox.Text = String.Empty Then
                onepTotal.Text = "0"
            Else
                onepTotal.Text = FormatCurrency(onepTextBox.Text * onepLabel.Text)
                AddTotals()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub totalLabel_Click(sender As Object, e As EventArgs) Handles totalLabel.Click
        Try
            Clipboard.SetText(iTotal.ToString)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub closePictureBox_Click(sender As Object, e As EventArgs) Handles closePictureBox.Click
        Me.Close()
    End Sub
End Class