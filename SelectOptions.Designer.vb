<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectOptions
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grbOptions = New System.Windows.Forms.GroupBox()
        Me.rdbAdvanced = New System.Windows.Forms.RadioButton()
        Me.rdbIntermediate = New System.Windows.Forms.RadioButton()
        Me.rdbBeginner = New System.Windows.Forms.RadioButton()
        Me.txtbxQs = New System.Windows.Forms.TextBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grbOptions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(169, 28)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Mathematics Quiz"
        '
        'grbOptions
        '
        Me.grbOptions.Controls.Add(Me.rdbAdvanced)
        Me.grbOptions.Controls.Add(Me.rdbIntermediate)
        Me.grbOptions.Controls.Add(Me.rdbBeginner)
        Me.grbOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!)
        Me.grbOptions.Location = New System.Drawing.Point(12, 40)
        Me.grbOptions.Name = "grbOptions"
        Me.grbOptions.Size = New System.Drawing.Size(205, 103)
        Me.grbOptions.TabIndex = 2
        Me.grbOptions.TabStop = False
        Me.grbOptions.Text = "Select Difficulty Level"
        '
        'rdbAdvanced
        '
        Me.rdbAdvanced.AutoSize = True
        Me.rdbAdvanced.Location = New System.Drawing.Point(6, 73)
        Me.rdbAdvanced.Name = "rdbAdvanced"
        Me.rdbAdvanced.Size = New System.Drawing.Size(103, 20)
        Me.rdbAdvanced.TabIndex = 5
        Me.rdbAdvanced.TabStop = True
        Me.rdbAdvanced.Text = "Advanced (/)"
        Me.rdbAdvanced.UseVisualStyleBackColor = True
        '
        'rdbIntermediate
        '
        Me.rdbIntermediate.AutoSize = True
        Me.rdbIntermediate.Location = New System.Drawing.Point(6, 47)
        Me.rdbIntermediate.Name = "rdbIntermediate"
        Me.rdbIntermediate.Size = New System.Drawing.Size(116, 20)
        Me.rdbIntermediate.TabIndex = 4
        Me.rdbIntermediate.TabStop = True
        Me.rdbIntermediate.Text = "Intermediate (*)"
        Me.rdbIntermediate.UseVisualStyleBackColor = True
        '
        'rdbBeginner
        '
        Me.rdbBeginner.AutoSize = True
        Me.rdbBeginner.Location = New System.Drawing.Point(6, 21)
        Me.rdbBeginner.Name = "rdbBeginner"
        Me.rdbBeginner.Size = New System.Drawing.Size(105, 20)
        Me.rdbBeginner.TabIndex = 3
        Me.rdbBeginner.TabStop = True
        Me.rdbBeginner.Text = "Beginner (+,-)"
        Me.rdbBeginner.UseVisualStyleBackColor = True
        '
        'txtbxQs
        '
        Me.txtbxQs.Location = New System.Drawing.Point(13, 21)
        Me.txtbxQs.Name = "txtbxQs"
        Me.txtbxQs.Size = New System.Drawing.Size(144, 22)
        Me.txtbxQs.TabIndex = 0
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(12, 213)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(157, 23)
        Me.btnGenerate.TabIndex = 1
        Me.btnGenerate.Text = "Generate Quiz"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbxQs)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 150)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(205, 57)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Number Of Questions"
        '
        'SelectOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(235, 251)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.grbOptions)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "SelectOptions"
        Me.Text = "Options"
        Me.grbOptions.ResumeLayout(False)
        Me.grbOptions.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents grbOptions As GroupBox
    Friend WithEvents txtbxQs As TextBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents rdbAdvanced As RadioButton
    Friend WithEvents rdbIntermediate As RadioButton
    Friend WithEvents rdbBeginner As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
End Class
