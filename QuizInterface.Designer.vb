<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuizInterface
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
        Me.rdbOpt1 = New System.Windows.Forms.RadioButton()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.rdbOpt2 = New System.Windows.Forms.RadioButton()
        Me.rdbOpt3 = New System.Windows.Forms.RadioButton()
        Me.rdbOpt4 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'rdbOpt1
        '
        Me.rdbOpt1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rdbOpt1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdbOpt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.rdbOpt1.Location = New System.Drawing.Point(12, 39)
        Me.rdbOpt1.Name = "rdbOpt1"
        Me.rdbOpt1.Size = New System.Drawing.Size(278, 36)
        Me.rdbOpt1.TabIndex = 0
        Me.rdbOpt1.TabStop = True
        Me.rdbOpt1.Text = "Option 1"
        Me.rdbOpt1.UseVisualStyleBackColor = False
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblQuestion.Location = New System.Drawing.Point(39, 9)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(225, 24)
        Me.lblQuestion.TabIndex = 1
        Me.lblQuestion.Text = "Question will appear here"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(160, 207)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(130, 23)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "Select Answer"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'rdbOpt2
        '
        Me.rdbOpt2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rdbOpt2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdbOpt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.rdbOpt2.Location = New System.Drawing.Point(12, 78)
        Me.rdbOpt2.Name = "rdbOpt2"
        Me.rdbOpt2.Size = New System.Drawing.Size(278, 36)
        Me.rdbOpt2.TabIndex = 3
        Me.rdbOpt2.TabStop = True
        Me.rdbOpt2.Text = "Option 2"
        Me.rdbOpt2.UseVisualStyleBackColor = False
        '
        'rdbOpt3
        '
        Me.rdbOpt3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rdbOpt3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdbOpt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.rdbOpt3.Location = New System.Drawing.Point(12, 117)
        Me.rdbOpt3.Name = "rdbOpt3"
        Me.rdbOpt3.Size = New System.Drawing.Size(278, 36)
        Me.rdbOpt3.TabIndex = 4
        Me.rdbOpt3.TabStop = True
        Me.rdbOpt3.Text = "Option 3"
        Me.rdbOpt3.UseVisualStyleBackColor = False
        '
        'rdbOpt4
        '
        Me.rdbOpt4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rdbOpt4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdbOpt4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.rdbOpt4.Location = New System.Drawing.Point(12, 156)
        Me.rdbOpt4.Name = "rdbOpt4"
        Me.rdbOpt4.Size = New System.Drawing.Size(278, 36)
        Me.rdbOpt4.TabIndex = 5
        Me.rdbOpt4.TabStop = True
        Me.rdbOpt4.Text = "Option 4"
        Me.rdbOpt4.UseVisualStyleBackColor = False
        '
        'QuizInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 242)
        Me.Controls.Add(Me.rdbOpt4)
        Me.Controls.Add(Me.rdbOpt3)
        Me.Controls.Add(Me.rdbOpt2)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.rdbOpt1)
        Me.Name = "QuizInterface"
        Me.Text = "Quiz"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdbOpt1 As RadioButton
    Friend WithEvents lblQuestion As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents rdbOpt2 As RadioButton
    Friend WithEvents rdbOpt3 As RadioButton
    Friend WithEvents rdbOpt4 As RadioButton
End Class
