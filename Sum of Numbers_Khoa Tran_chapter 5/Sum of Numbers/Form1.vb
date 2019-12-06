Public Class Form1



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim intInput As Integer
        intInput = InputBox("Enter a positive Value.", "Input Needed", 10)
        If intInput > 0 Then
            Dim intCount As Integer = 0
            Dim intSum As Integer = 0
            Dim intInc As Integer = 1
            While intCount < intInput
                intSum += intInc
                intInc += 1
                intCount += 1
            End While
            MsgBox(intSum)

        Else
            MsgBox("You can only enter Positive number")
        End If

    End Sub



End Class
