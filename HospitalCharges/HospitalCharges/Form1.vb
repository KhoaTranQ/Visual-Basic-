Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Function CalcStayCharges() As Decimal
        Dim NumDays As Integer
        NumDays = txtNumDays.Text
        Return (NumDays * 350)
    End Function

    Function CalcMiscCharges() As Decimal
        Dim medCharge As Decimal
        Dim SurgCharge As Decimal
        Dim LabCharge As Decimal
        Dim PhysCharge As Decimal
        Dim MiscCharges As Decimal

        medCharge = txtMed.Text
        SurgCharge = txtSurg.Text
        LabCharge = txtLab.Text
        PhysCharge = txtPhys.Text
        MiscCharges = medCharge + SurgCharge + LabCharge + PhysCharge
        Return (MiscCharges)

    End Function

    Function CalcTotalCharges() As Decimal
        Dim TotalCharges As Decimal
        TotalCharges = CalcStayCharges() + CalcMiscCharges()
        lblTotal.Text = TotalCharges.ToString("c")
        Return TotalCharges

    End Function

    Function ValidateInputFields() As Boolean
        If txtNumDays.Text < 0 Then
            txtNumDays.Clear()
            MessageBox.Show("There Cannot be Negative number of Days", "Error")
            Return False
        End If
        If txtMed.Text < 0 Then
            txtMed.Clear()
            MessageBox.Show("There Cannot be a Negative Medication Charges  ", "Error")
            Return False
        End If
        If txtSurg.Text < 0 Then
            txtSurg.Clear()
            MessageBox.Show("There Cannot be a Negative Surgical Charges ", "Error")
            Return False
        End If
        If txtLab.Text < 0 Then
            txtLab.Clear()
            MessageBox.Show("There Cannot be a Negative Lab Fees ", "Error")
            Return False
        End If
        If txtPhys.Text < 0 Then
            txtPhys.Clear()
            MessageBox.Show(" There Cannot be a Negative Physical Cost", "Error")
            Return False
        End If

        Return True
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumDays.Clear()
        txtMed.Clear()
        txtSurg.Clear()
        txtLab.Clear()
        txtPhys.Clear()
        lblTotal.Text = ""
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If ValidateInputFields() Then
            CalcTotalCharges()
        End If
    End Sub


    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class
