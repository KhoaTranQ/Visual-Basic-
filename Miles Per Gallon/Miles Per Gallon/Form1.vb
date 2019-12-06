Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtgallon.Clear()
        txtmiles.Clear()
        txtmpg.Clear()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Decmpg As Double ' calculage mpg

        Try
            Decmpg = CDbl(txtmiles.Text) / CDbl(txtgallon.Text)
            txtmpg.Text = Decmpg.ToString()
        Catch ex As Exception
            MessageBox.Show("Miles and Gallons must be number", "Error")
        End Try


    End Sub
End Class
