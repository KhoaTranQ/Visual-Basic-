Public Class Form1

    

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        Select Case CInt(txtDecimal.Text)
            Case 1
                txtRoman.Text = ("I")
            Case 2
                txtRoman.Text = ("II")
            Case 3
                txtRoman.Text = ("III")
            Case 4
                txtRoman.Text = ("IV")
            Case 5
                txtRoman.Text = ("V")
            Case 6
                txtRoman.Text = ("VI")
            Case 7
                txtRoman.Text = ("VII")
            Case 8
                txtRoman.Text = ("VIII")
            Case 9
                txtRoman.Text = ("IX")
            Case 10
                txtRoman.Text = ("X")
            Case Else
                MessageBox.Show("Number Must be in range of 1 - 10")
        End Select







    End Sub
End Class
