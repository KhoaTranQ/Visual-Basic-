Public Class Form1
    Dim strMonth() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
    Dim intMonth(11) As Integer
    Dim intRain() As Integer

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstRain.Items.Clear()
        lbltotal.Clear()
        lblAvg.Clear()
        lblMin.Clear()
        lblMax.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        Dim intCount As Integer
        Dim dblAvg As Double
        Dim intTotal As Integer = 0
        For intCount = 0 To (strMonth.Length - 1)
            intTotal += intMonth(intCount) 'total
        Next intCount

        dblAvg = (intTotal / strMonth.Length) 'avg



        Dim intMax As Integer = intMonth(0)
        Dim max As Integer = 0
        For intCount = 1 To (intMonth.Length - 1)
            If intMonth(intCount) > intMax Then
                intMax = intMonth(intCount)
                max = intCount 'max
            End If
        Next intCount



        Dim intMin As Integer = intMonth(0)
        Dim min As Integer = 0
        For intCount = 1 To (strMonth.Length - 1)
            If intMonth(intCount) < intMin Then
                intMin = intMonth(intCount)
                min = intCount 'min
            End If
        Next intCount


        lblAvg.Text = "The average monthly rainfall was " & dblAvg.ToString("n2")
        lbltotal.Text = "The total annual rainfall was " & intTotal
        lblMin.Text = "The minimum monthly rainfall was " & intMin & " (" & strMonth(min) & ")"
        lblMax.Text = "The maximum monthly rainfall was " & intMax & " (" & strMonth(max) & ")"

    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click


        Dim intCount As Integer
        Dim intRain As Integer

        lstRain.Items.Add("Monthly Rainfall Input")
        lstRain.Items.Add("-----------------------------------")

        For intCount = 0 To 11
            intRain = (InputBox("Enter the number of inches of rainfall for" & " " & strMonth(intCount)))
            lstRain.Items.Add("Rainfall for " & strMonth(intCount) & " = " & (intRain).ToString())
            intMonth(intCount) = intRain
        Next intCount
    End Sub

    Private Sub lbltotal_TextChanged(sender As Object, e As EventArgs) Handles lbltotal.TextChanged

    End Sub
End Class
