Imports System.IO

Public Class Form1
    Dim filename As String
    Dim ifile As System.IO.StreamReader
    Dim intCount As Integer = 1
    Dim strRecordNumber As String
    Dim strFirst As String
    Dim strMiddle As String
    Dim strLast As String
    Dim strNumber As String
    Dim strDept As String
    Dim strPhone As String
    Dim strExt As String
    Dim strEmail As String



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
        lblDepartment.Clear()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filename = InputBox("Enter file name")


        ifile = File.OpenText(filename)


        strRecordNumber = intCount.ToString()
        lblRecord.Text = strRecordNumber.ToString()
        intCount += 1


        strFirst = ifile.ReadLine()
        lblFirst.Text = strFirst.ToString()


        strMiddle = ifile.ReadLine()
        lblMiddle.Text = strMiddle.ToString()


        strLast = ifile.ReadLine()
        lblLast.Text = strLast.ToString()


        strNumber = ifile.ReadLine()
        lblNumber.Text = strNumber.ToString()


        strDept = ifile.ReadLine()
        lblDepartment.Text = strDept.ToString()


        strPhone = ifile.ReadLine()
        lblPhone.Text = strPhone.ToString()


        strExt = ifile.ReadLine()
        lblExtension.Text = strExt.ToString()


        strEmail = ifile.ReadLine()
        lblEmail.Text = strEmail.ToString()







    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        Do Until ifile.Peek = -1

            strRecordNumber = intCount.ToString()
            lblRecord.Text = strRecordNumber.ToString()
            intCount += 1


            strFirst = ifile.ReadLine()
            lblFirst.Text = strFirst.ToString()


            strMiddle = ifile.ReadLine()
            lblMiddle.Text = strMiddle.ToString()


            strLast = ifile.ReadLine()
            lblLast.Text = strLast.ToString()


            strNumber = ifile.ReadLine()
            lblNumber.Text = strNumber.ToString()


            strDept = ifile.ReadLine()
            lblDepartment.Text = strDept.ToString()


            strPhone = ifile.ReadLine()
            lblPhone.Text = strPhone.ToString()


            strExt = ifile.ReadLine()
            lblExtension.Text = strExt.ToString()


            strEmail = ifile.ReadLine()
            lblEmail.Text = strEmail.ToString()
        Loop



    End Sub
End Class
