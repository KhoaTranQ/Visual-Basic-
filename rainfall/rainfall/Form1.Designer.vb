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
        Me.lstRain = New System.Windows.Forms.ListBox()
        Me.lstMonth = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.TextBox()
        Me.lblAvg = New System.Windows.Forms.TextBox()
        Me.lblMin = New System.Windows.Forms.TextBox()
        Me.lblMax = New System.Windows.Forms.TextBox()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstRain
        '
        Me.lstRain.FormattingEnabled = True
        Me.lstRain.Location = New System.Drawing.Point(25, 26)
        Me.lstRain.Name = "lstRain"
        Me.lstRain.Size = New System.Drawing.Size(166, 225)
        Me.lstRain.TabIndex = 0
        '
        'lstMonth
        '
        Me.lstMonth.AutoSize = True
        Me.lstMonth.Location = New System.Drawing.Point(218, 41)
        Me.lstMonth.Name = "lstMonth"
        Me.lstMonth.Size = New System.Drawing.Size(127, 13)
        Me.lstMonth.TabIndex = 1
        Me.lstMonth.Text = "Monthly Rainfall Statistics"
        '
        'lbltotal
        '
        Me.lbltotal.BackColor = System.Drawing.SystemColors.Menu
        Me.lbltotal.Location = New System.Drawing.Point(221, 71)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(249, 20)
        Me.lbltotal.TabIndex = 2
        '
        'lblAvg
        '
        Me.lblAvg.BackColor = System.Drawing.SystemColors.Menu
        Me.lblAvg.Location = New System.Drawing.Point(221, 112)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(249, 20)
        Me.lblAvg.TabIndex = 3
        '
        'lblMin
        '
        Me.lblMin.BackColor = System.Drawing.SystemColors.Menu
        Me.lblMin.Location = New System.Drawing.Point(221, 152)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(249, 20)
        Me.lblMin.TabIndex = 4
        '
        'lblMax
        '
        Me.lblMax.BackColor = System.Drawing.SystemColors.Menu
        Me.lblMax.Location = New System.Drawing.Point(221, 193)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(249, 20)
        Me.lblMax.TabIndex = 6
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(25, 281)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(134, 54)
        Me.btnInput.TabIndex = 7
        Me.btnInput.Text = "Input Monthly Rainfall"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(189, 281)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(69, 54)
        Me.btnDisplay.TabIndex = 8
        Me.btnDisplay.Text = "Display Stats"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(296, 281)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(69, 54)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(402, 281)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(68, 54)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 357)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.lblAvg)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lstMonth)
        Me.Controls.Add(Me.lstRain)
        Me.Name = "Form1"
        Me.Text = "RainFall Statistics"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstRain As System.Windows.Forms.ListBox
    Friend WithEvents lstMonth As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.TextBox
    Friend WithEvents lblAvg As System.Windows.Forms.TextBox
    Friend WithEvents lblMin As System.Windows.Forms.TextBox
    Friend WithEvents lblMax As System.Windows.Forms.TextBox
    Friend WithEvents btnInput As System.Windows.Forms.Button
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
