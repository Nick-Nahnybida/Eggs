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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEggs4 = New System.Windows.Forms.TextBox()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.lblRemainder = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.lblDozen = New System.Windows.Forms.Label()
        Me.txtEggs1 = New System.Windows.Forms.TextBox()
        Me.txtEggs2 = New System.Windows.Forms.TextBox()
        Me.txtEggs3 = New System.Windows.Forms.TextBox()
        Me.txtEggs5 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Give Eggs"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dozen(s):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(131, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Remainder:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(225, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total $:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(219, 309)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(124, 309)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(36, 309)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(43, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Number of Eggs:"
        '
        'txtEggs4
        '
        Me.txtEggs4.Location = New System.Drawing.Point(219, 113)
        Me.txtEggs4.Name = "txtEggs4"
        Me.txtEggs4.Size = New System.Drawing.Size(100, 20)
        Me.txtEggs4.TabIndex = 12
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotalPrice.Location = New System.Drawing.Point(228, 237)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(65, 23)
        Me.lblTotalPrice.TabIndex = 14
        '
        'lblRemainder
        '
        Me.lblRemainder.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRemainder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRemainder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblRemainder.Location = New System.Drawing.Point(134, 237)
        Me.lblRemainder.Name = "lblRemainder"
        Me.lblRemainder.Size = New System.Drawing.Size(65, 23)
        Me.lblRemainder.TabIndex = 15
        '
        'lblD
        '
        Me.lblD.AutoSize = True
        Me.lblD.Location = New System.Drawing.Point(46, 187)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(0, 13)
        Me.lblD.TabIndex = 16
        '
        'lblDozen
        '
        Me.lblDozen.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDozen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDozen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDozen.Location = New System.Drawing.Point(46, 237)
        Me.lblDozen.Name = "lblDozen"
        Me.lblDozen.Size = New System.Drawing.Size(65, 23)
        Me.lblDozen.TabIndex = 17
        '
        'txtEggs1
        '
        Me.txtEggs1.Location = New System.Drawing.Point(219, 35)
        Me.txtEggs1.Name = "txtEggs1"
        Me.txtEggs1.Size = New System.Drawing.Size(100, 20)
        Me.txtEggs1.TabIndex = 18
        '
        'txtEggs2
        '
        Me.txtEggs2.Location = New System.Drawing.Point(219, 61)
        Me.txtEggs2.Name = "txtEggs2"
        Me.txtEggs2.Size = New System.Drawing.Size(100, 20)
        Me.txtEggs2.TabIndex = 19
        '
        'txtEggs3
        '
        Me.txtEggs3.Location = New System.Drawing.Point(219, 87)
        Me.txtEggs3.Name = "txtEggs3"
        Me.txtEggs3.Size = New System.Drawing.Size(100, 20)
        Me.txtEggs3.TabIndex = 20
        '
        'txtEggs5
        '
        Me.txtEggs5.Location = New System.Drawing.Point(219, 139)
        Me.txtEggs5.Name = "txtEggs5"
        Me.txtEggs5.Size = New System.Drawing.Size(100, 20)
        Me.txtEggs5.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 424)
        Me.Controls.Add(Me.txtEggs5)
        Me.Controls.Add(Me.txtEggs3)
        Me.Controls.Add(Me.txtEggs2)
        Me.Controls.Add(Me.txtEggs1)
        Me.Controls.Add(Me.lblDozen)
        Me.Controls.Add(Me.lblD)
        Me.Controls.Add(Me.lblRemainder)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEggs4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEggs4 As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label
    Friend WithEvents lblRemainder As System.Windows.Forms.Label
    Friend WithEvents lblD As System.Windows.Forms.Label
    Friend WithEvents lblDozen As System.Windows.Forms.Label
    Friend WithEvents txtEggs1 As System.Windows.Forms.TextBox
    Friend WithEvents txtEggs2 As System.Windows.Forms.TextBox
    Friend WithEvents txtEggs3 As System.Windows.Forms.TextBox
    Friend WithEvents txtEggs5 As System.Windows.Forms.TextBox

End Class
