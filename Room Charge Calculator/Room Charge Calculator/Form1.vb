Public Class Form1

    
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblTimeToday.Text = Now.ToString("T")
        LblDateToday.Text = Now.ToString("D")
    End Sub




    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNights.Text = ""
        txtNightlyCharge.Text = ""
        LblTimeToday.Text = Now.ToString("T")
        LblDateToday.Text = Now.ToString("D")
        txtRoomService.Text = ""
        txtTelephone.Text = ""
        txtMisc.Text = ""
        lblRoomCharges.Text = ""
        lblAddCharges.Text = ""
        lblSubtotal.Text = ""
        lblTax.Text = ""
        lblTotal.Text = ""


    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Declare variables for the calculations.
        Dim decRoomCharges As Decimal ' Room charges total
        Dim decAddCharges As Decimal ' Additional charges
        Dim decSubtotal As Decimal ' Subtotal
        Dim decTax As Decimal ' Tax
        Dim decTotal As Decimal ' Total of all charges
        Const decTAX_RATE As Decimal = 0.08D ' Tax rate
        Try
            ' Calculate and display the room charges.
            decRoomCharges = CDec(txtNights.Text) *
            CDec(txtNightlyCharge.Text)
            lblRoomCharges.Text = decRoomCharges.ToString("c")
            ' Calculate and display the additional charges.
            decAddCharges = CDec(txtRoomService.Text) +
            CDec(txtTelephone.Text) +
            CDec(txtMisc.Text)
            lblAddCharges.Text = decAddCharges.ToString("c")
            ' Calculate and display the subtotal.
            decSubtotal = decRoomCharges + decAddCharges
            lblSubtotal.Text = decSubtotal.ToString("c")
            ' Calculate and display the tax.
            decTax = decSubtotal * decTAX_RATE
            lblTax.Text = decTax.ToString("c")
            ' Calculate and display the total charges.
            decTotal = decSubtotal + decTax
            lblTotal.Text = decTotal.ToString("c")
            ' Change the colors for the total charges.
            lblTotal.BackColor = Color.Blue
            lblTotal.ForeColor = Color.White
        Catch
            ' Error message
            MessageBox.Show("All input must be valid numeric values.")
        End Try
    End Sub
End Class
