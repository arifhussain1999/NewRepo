<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        Me.stName = New System.Windows.Forms.TextBox()
        Me.labelName = New System.Windows.Forms.Label()
        Me.labelEmail = New System.Windows.Forms.Label()
        Me.stEmail = New System.Windows.Forms.TextBox()
        Me.stNumber = New System.Windows.Forms.TextBox()
        Me.stGithub = New System.Windows.Forms.TextBox()
        Me.stStopwatch = New System.Windows.Forms.TextBox()
        Me.labelNumber = New System.Windows.Forms.Label()
        Me.labelGithub = New System.Windows.Forms.Label()
        Me.labelStopwatch = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'stName
        '
        Me.stName.Location = New System.Drawing.Point(416, 37)
        Me.stName.Name = "stName"
        Me.stName.ReadOnly = True
        Me.stName.Size = New System.Drawing.Size(197, 20)
        Me.stName.TabIndex = 0
        '
        'labelName
        '
        Me.labelName.AutoSize = True
        Me.labelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelName.Location = New System.Drawing.Point(252, 37)
        Me.labelName.Name = "labelName"
        Me.labelName.Size = New System.Drawing.Size(51, 20)
        Me.labelName.TabIndex = 1
        Me.labelName.Text = "Name"
        '
        'labelEmail
        '
        Me.labelEmail.AutoSize = True
        Me.labelEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelEmail.Location = New System.Drawing.Point(252, 85)
        Me.labelEmail.Name = "labelEmail"
        Me.labelEmail.Size = New System.Drawing.Size(48, 20)
        Me.labelEmail.TabIndex = 2
        Me.labelEmail.Text = "Email"
        '
        'stEmail
        '
        Me.stEmail.Location = New System.Drawing.Point(416, 85)
        Me.stEmail.Name = "stEmail"
        Me.stEmail.ReadOnly = True
        Me.stEmail.Size = New System.Drawing.Size(197, 20)
        Me.stEmail.TabIndex = 3
        '
        'stNumber
        '
        Me.stNumber.Location = New System.Drawing.Point(416, 137)
        Me.stNumber.Name = "stNumber"
        Me.stNumber.ReadOnly = True
        Me.stNumber.Size = New System.Drawing.Size(197, 20)
        Me.stNumber.TabIndex = 4
        '
        'stGithub
        '
        Me.stGithub.Location = New System.Drawing.Point(416, 194)
        Me.stGithub.Name = "stGithub"
        Me.stGithub.ReadOnly = True
        Me.stGithub.Size = New System.Drawing.Size(197, 20)
        Me.stGithub.TabIndex = 5
        '
        'stStopwatch
        '
        Me.stStopwatch.Location = New System.Drawing.Point(416, 249)
        Me.stStopwatch.Name = "stStopwatch"
        Me.stStopwatch.ReadOnly = True
        Me.stStopwatch.Size = New System.Drawing.Size(197, 20)
        Me.stStopwatch.TabIndex = 6
        '
        'labelNumber
        '
        Me.labelNumber.AutoSize = True
        Me.labelNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNumber.Location = New System.Drawing.Point(253, 137)
        Me.labelNumber.Name = "labelNumber"
        Me.labelNumber.Size = New System.Drawing.Size(115, 20)
        Me.labelNumber.TabIndex = 7
        Me.labelNumber.Text = "Phone Number"
        '
        'labelGithub
        '
        Me.labelGithub.AutoSize = True
        Me.labelGithub.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelGithub.Location = New System.Drawing.Point(253, 194)
        Me.labelGithub.Name = "labelGithub"
        Me.labelGithub.Size = New System.Drawing.Size(90, 20)
        Me.labelGithub.TabIndex = 8
        Me.labelGithub.Text = "Github Link"
        '
        'labelStopwatch
        '
        Me.labelStopwatch.AutoSize = True
        Me.labelStopwatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelStopwatch.Location = New System.Drawing.Point(253, 249)
        Me.labelStopwatch.Name = "labelStopwatch"
        Me.labelStopwatch.Size = New System.Drawing.Size(123, 20)
        Me.labelStopwatch.TabIndex = 9
        Me.labelStopwatch.Text = "Stopwatch Time"
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(151, 341)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(192, 45)
        Me.btnPrevious.TabIndex = 10
        Me.btnPrevious.Text = "PREVIOUS (Ctrl + P)"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(572, 341)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(192, 45)
        Me.btnNext.TabIndex = 11
        Me.btnNext.Text = "NEXT (Ctrl + N)"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.labelStopwatch)
        Me.Controls.Add(Me.labelGithub)
        Me.Controls.Add(Me.labelNumber)
        Me.Controls.Add(Me.stStopwatch)
        Me.Controls.Add(Me.stGithub)
        Me.Controls.Add(Me.stNumber)
        Me.Controls.Add(Me.stEmail)
        Me.Controls.Add(Me.labelEmail)
        Me.Controls.Add(Me.labelName)
        Me.Controls.Add(Me.stName)
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents stName As TextBox
    Friend WithEvents labelName As Label
    Friend WithEvents labelEmail As Label
    Friend WithEvents stEmail As TextBox
    Friend WithEvents stNumber As TextBox
    Friend WithEvents stGithub As TextBox
    Friend WithEvents stStopwatch As TextBox
    Friend WithEvents labelNumber As Label
    Friend WithEvents labelGithub As Label
    Friend WithEvents labelStopwatch As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
End Class
