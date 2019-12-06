<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblExtension = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.TextBox()
        Me.lblNumber = New System.Windows.Forms.TextBox()
        Me.lblLast = New System.Windows.Forms.TextBox()
        Me.lblMiddle = New System.Windows.Forms.TextBox()
        Me.lblFirst = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.lblExtension)
        Me.GroupBox1.Controls.Add(Me.lblPhone)
        Me.GroupBox1.Controls.Add(Me.lblEmail)
        Me.GroupBox1.Controls.Add(Me.lblNumber)
        Me.GroupBox1.Controls.Add(Me.lblLast)
        Me.GroupBox1.Controls.Add(Me.lblMiddle)
        Me.GroupBox1.Controls.Add(Me.lblFirst)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 379)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Employee Data"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Accounting", "Administration", "Marketing", "MIS", "Sales"})
        Me.ComboBox1.Location = New System.Drawing.Point(151, 209)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 15
        '
        'lblExtension
        '
        Me.lblExtension.Location = New System.Drawing.Point(151, 304)
        Me.lblExtension.Name = "lblExtension"
        Me.lblExtension.Size = New System.Drawing.Size(118, 20)
        Me.lblExtension.TabIndex = 14
        '
        'lblPhone
        '
        Me.lblPhone.Location = New System.Drawing.Point(154, 258)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(118, 20)
        Me.lblPhone.TabIndex = 13
        '
        'lblEmail
        '
        Me.lblEmail.Location = New System.Drawing.Point(151, 344)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(118, 20)
        Me.lblEmail.TabIndex = 12
        '
        'lblNumber
        '
        Me.lblNumber.Location = New System.Drawing.Point(151, 163)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(121, 20)
        Me.lblNumber.TabIndex = 11
        '
        'lblLast
        '
        Me.lblLast.Location = New System.Drawing.Point(151, 117)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(121, 20)
        Me.lblLast.TabIndex = 10
        '
        'lblMiddle
        '
        Me.lblMiddle.Location = New System.Drawing.Point(151, 79)
        Me.lblMiddle.Name = "lblMiddle"
        Me.lblMiddle.Size = New System.Drawing.Size(121, 20)
        Me.lblMiddle.TabIndex = 9
        '
        'lblFirst
        '
        Me.lblFirst.Location = New System.Drawing.Point(151, 34)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(121, 20)
        Me.lblFirst.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 344)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "E-mail Address:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 304)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Extension: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Telephone: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Department:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Employee Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Middle Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(50, 411)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(98, 52)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save Record"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(192, 411)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(89, 52)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(129, 486)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 46)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 544)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Employee Data"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblExtension As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblLast As System.Windows.Forms.TextBox
    Friend WithEvents lblMiddle As System.Windows.Forms.TextBox
    Friend WithEvents lblFirst As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
