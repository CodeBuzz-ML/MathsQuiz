<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Result
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
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCorrect = New System.Windows.Forms.Label()
        Me.lblPercentage = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnOpenCert = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Questions"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(153, 9)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(230, 22)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "Total Questions"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 55)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Correct"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCorrect
        '
        Me.lblCorrect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCorrect.Location = New System.Drawing.Point(153, 55)
        Me.lblCorrect.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCorrect.Name = "lblCorrect"
        Me.lblCorrect.Size = New System.Drawing.Size(232, 24)
        Me.lblCorrect.TabIndex = 3
        Me.lblCorrect.Text = "Total Questions"
        Me.lblCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPercentage
        '
        Me.lblPercentage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPercentage.Location = New System.Drawing.Point(153, 101)
        Me.lblPercentage.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(232, 24)
        Me.lblPercentage.TabIndex = 5
        Me.lblPercentage.Text = "Total Questions"
        Me.lblPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 101)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 22)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Percentage (%)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 30)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Exit Application"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnOpenCert
        '
        Me.btnOpenCert.Location = New System.Drawing.Point(132, 135)
        Me.btnOpenCert.Name = "btnOpenCert"
        Me.btnOpenCert.Size = New System.Drawing.Size(184, 30)
        Me.btnOpenCert.TabIndex = 7
        Me.btnOpenCert.Text = "View Certificate"
        Me.btnOpenCert.UseVisualStyleBackColor = True
        '
        'Result
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 170)
        Me.Controls.Add(Me.btnOpenCert)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblPercentage)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblCorrect)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Result"
        Me.Text = "Result"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCorrect As Label
    Friend WithEvents lblPercentage As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnOpenCert As Button
End Class
