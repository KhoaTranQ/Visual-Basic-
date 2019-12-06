Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnShowInfo_Click(sender As Object, e As EventArgs) Handles btnShowInfo.Click
        If lblName.Visible = False Then
            lblName.Visible = True
            lblStreet.Visible = True
            lblCityStateZip.Visible = True
        ElseIf lblName.Visible = True Then
            lblName.Visible = False
            lblStreet.Visible = False
            lblCityStateZip.Visible = False

        End If
    End Sub

    Private Sub lvlCityStateZip_Click(sender As Object, e As EventArgs) Handles lblCityStateZip.Click

    End Sub

    Private Sub lblStreet_Click(sender As Object, e As EventArgs) Handles lblStreet.Click

    End Sub
End Class
