Imports System.IO

Public Class Form1
    Dim filename As String

    Dim oWrite As System.IO.StreamWriter

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblEmail.Clear()
        lblExtension.Clear()
        lblFirst.Clear()
        lblLast.Clear()
        lblMiddle.Clear()
        lblNumber.Clear()
        lblPhone.Clear()


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filename = InputBox("Enter output file name")
        oWrite = File.CreateText(filename)


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        oWrite.WriteLine(lblFirst.Text)
        oWrite.WriteLine(lblMiddle.Text)
        oWrite.WriteLine(lblLast.Text)
        oWrite.WriteLine(lblNumber.Text)
        oWrite.WriteLine(ComboBox1.SelectedItem)
        oWrite.WriteLine(lblPhone.Text)
        oWrite.WriteLine(lblExtension.Text)
        oWrite.WriteLine(lblEmail.Text)
        oWrite.Close()
        MessageBox.Show("The data was added and the file " & filename & " was saved.")





    End Sub
End Class
