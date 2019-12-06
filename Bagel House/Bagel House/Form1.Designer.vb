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
        Me.radWheat = New System.Windows.Forms.RadioButton()
        Me.radWhite = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radCafeAuLait = New System.Windows.Forms.RadioButton()
        Me.radCappuccino = New System.Windows.Forms.RadioButton()
        Me.radRegCoffee = New System.Windows.Forms.RadioButton()
        Me.radNoCoffee = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkPeach = New System.Windows.Forms.CheckBox()
        Me.chkRaspberry = New System.Windows.Forms.CheckBox()
        Me.chkBlueberry = New System.Windows.Forms.CheckBox()
        Me.chkButter = New System.Windows.Forms.CheckBox()
        Me.chkCreamCheese = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.TextBox()
        Me.lblTax = New System.Windows.Forms.TextBox()
        Me.lblSubtotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radWheat)
        Me.GroupBox1.Controls.Add(Me.radWhite)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pick a Bagel"
        '
        'radWheat
        '
        Me.radWheat.AutoSize = True
        Me.radWheat.Location = New System.Drawing.Point(18, 66)
        Me.radWheat.Name = "radWheat"
        Me.radWheat.Size = New System.Drawing.Size(91, 17)
        Me.radWheat.TabIndex = 1
        Me.radWheat.TabStop = True
        Me.radWheat.Text = "Whole Wheat"
        Me.radWheat.UseVisualStyleBackColor = True
        '
        'radWhite
        '
        Me.radWhite.AutoSize = True
        Me.radWhite.Location = New System.Drawing.Point(18, 31)
        Me.radWhite.Name = "radWhite"
        Me.radWhite.Size = New System.Drawing.Size(53, 17)
        Me.radWhite.TabIndex = 0
        Me.radWhite.TabStop = True
        Me.radWhite.Text = "White"
        Me.radWhite.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radCafeAuLait)
        Me.GroupBox2.Controls.Add(Me.radCappuccino)
        Me.GroupBox2.Controls.Add(Me.radRegCoffee)
        Me.GroupBox2.Controls.Add(Me.radNoCoffee)
        Me.GroupBox2.Location = New System.Drawing.Point(236, 74)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 135)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Want Coffee with that?"
        '
        'radCafeAuLait
        '
        Me.radCafeAuLait.AutoSize = True
        Me.radCafeAuLait.Location = New System.Drawing.Point(33, 96)
        Me.radCafeAuLait.Name = "radCafeAuLait"
        Me.radCafeAuLait.Size = New System.Drawing.Size(114, 17)
        Me.radCafeAuLait.TabIndex = 5
        Me.radCafeAuLait.TabStop = True
        Me.radCafeAuLait.Text = "Cafe au lait ($1.75)"
        Me.radCafeAuLait.UseVisualStyleBackColor = True
        '
        'radCappuccino
        '
        Me.radCappuccino.AutoEllipsis = True
        Me.radCappuccino.AutoSize = True
        Me.radCappuccino.Location = New System.Drawing.Point(33, 73)
        Me.radCappuccino.Name = "radCappuccino"
        Me.radCappuccino.Size = New System.Drawing.Size(118, 17)
        Me.radCappuccino.TabIndex = 4
        Me.radCappuccino.TabStop = True
        Me.radCappuccino.Text = "Cappuccino ($2.00)"
        Me.radCappuccino.UseVisualStyleBackColor = True
        '
        'radRegCoffee
        '
        Me.radRegCoffee.AutoSize = True
        Me.radRegCoffee.Location = New System.Drawing.Point(33, 50)
        Me.radRegCoffee.Name = "radRegCoffee"
        Me.radRegCoffee.Size = New System.Drawing.Size(132, 17)
        Me.radRegCoffee.TabIndex = 3
        Me.radRegCoffee.TabStop = True
        Me.radRegCoffee.Text = "Regular Coffee ($1.25)"
        Me.radRegCoffee.UseVisualStyleBackColor = True
        '
        'radNoCoffee
        '
        Me.radNoCoffee.AutoSize = True
        Me.radNoCoffee.Location = New System.Drawing.Point(33, 27)
        Me.radNoCoffee.Name = "radNoCoffee"
        Me.radNoCoffee.Size = New System.Drawing.Size(51, 17)
        Me.radNoCoffee.TabIndex = 2
        Me.radNoCoffee.TabStop = True
        Me.radNoCoffee.Text = "None"
        Me.radNoCoffee.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkPeach)
        Me.GroupBox3.Controls.Add(Me.chkRaspberry)
        Me.GroupBox3.Controls.Add(Me.chkBlueberry)
        Me.GroupBox3.Controls.Add(Me.chkButter)
        Me.GroupBox3.Controls.Add(Me.chkCreamCheese)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 180)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 182)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "pick your toppings"
        '
        'chkPeach
        '
        Me.chkPeach.AutoSize = True
        Me.chkPeach.Location = New System.Drawing.Point(18, 155)
        Me.chkPeach.Name = "chkPeach"
        Me.chkPeach.Size = New System.Drawing.Size(107, 17)
        Me.chkPeach.TabIndex = 4
        Me.chkPeach.Text = "Peach Jelly($.75)"
        Me.chkPeach.UseVisualStyleBackColor = True
        '
        'chkRaspberry
        '
        Me.chkRaspberry.AutoSize = True
        Me.chkRaspberry.Location = New System.Drawing.Point(18, 124)
        Me.chkRaspberry.Name = "chkRaspberry"
        Me.chkRaspberry.Size = New System.Drawing.Size(126, 17)
        Me.chkRaspberry.TabIndex = 3
        Me.chkRaspberry.Text = "Raspberry Jam ($.75)"
        Me.chkRaspberry.UseVisualStyleBackColor = True
        '
        'chkBlueberry
        '
        Me.chkBlueberry.AutoSize = True
        Me.chkBlueberry.Location = New System.Drawing.Point(18, 92)
        Me.chkBlueberry.Name = "chkBlueberry"
        Me.chkBlueberry.Size = New System.Drawing.Size(119, 17)
        Me.chkBlueberry.TabIndex = 2
        Me.chkBlueberry.Text = "Blueberry Jam($.75)"
        Me.chkBlueberry.UseVisualStyleBackColor = True
        '
        'chkButter
        '
        Me.chkButter.AutoSize = True
        Me.chkButter.Location = New System.Drawing.Point(18, 55)
        Me.chkButter.Name = "chkButter"
        Me.chkButter.Size = New System.Drawing.Size(84, 17)
        Me.chkButter.TabIndex = 1
        Me.chkButter.Text = "Butter ($.25)"
        Me.chkButter.UseVisualStyleBackColor = True
        '
        'chkCreamCheese
        '
        Me.chkCreamCheese.AutoSize = True
        Me.chkCreamCheese.Location = New System.Drawing.Point(18, 20)
        Me.chkCreamCheese.Name = "chkCreamCheese"
        Me.chkCreamCheese.Size = New System.Drawing.Size(125, 17)
        Me.chkCreamCheese.TabIndex = 0
        Me.chkCreamCheese.Text = "Cream Cheese ($.50)"
        Me.chkCreamCheese.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblTotal)
        Me.GroupBox4.Controls.Add(Me.lblTax)
        Me.GroupBox4.Controls.Add(Me.lblSubtotal)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(236, 238)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 124)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Price"
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(94, 97)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(80, 20)
        Me.lblTotal.TabIndex = 5
        '
        'lblTax
        '
        Me.lblTax.Location = New System.Drawing.Point(94, 65)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(80, 20)
        Me.lblTax.TabIndex = 4
        '
        'lblSubtotal
        '
        Me.lblSubtotal.Location = New System.Drawing.Point(94, 28)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(80, 20)
        Me.lblSubtotal.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tax"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subtotal"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(46, 390)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(177, 390)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(311, 390)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(118, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Brandi's Bagel House"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 449)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Bagel and Coffee Price Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radWheat As System.Windows.Forms.RadioButton
    Friend WithEvents radWhite As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radCafeAuLait As System.Windows.Forms.RadioButton
    Friend WithEvents radCappuccino As System.Windows.Forms.RadioButton
    Friend WithEvents radRegCoffee As System.Windows.Forms.RadioButton
    Friend WithEvents radNoCoffee As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkPeach As System.Windows.Forms.CheckBox
    Friend WithEvents chkRaspberry As System.Windows.Forms.CheckBox
    Friend WithEvents chkBlueberry As System.Windows.Forms.CheckBox
    Friend WithEvents chkButter As System.Windows.Forms.CheckBox
    Friend WithEvents chkCreamCheese As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblTax As System.Windows.Forms.TextBox
    Friend WithEvents lblSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
