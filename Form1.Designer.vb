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
        Me.btnViewSubmissions = New System.Windows.Forms.Button()
        Me.btnCreateSubmission = New System.Windows.Forms.Button()
        Me.btnDeleteSubmission = New System.Windows.Forms.Button()
        Me.txtPhoneNumberToDelete = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnViewSubmissions
        '
        Me.btnViewSubmissions.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnViewSubmissions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewSubmissions.Location = New System.Drawing.Point(111, 240)
        Me.btnViewSubmissions.Name = "btnViewSubmissions"
        Me.btnViewSubmissions.Size = New System.Drawing.Size(284, 45)
        Me.btnViewSubmissions.TabIndex = 0
        Me.btnViewSubmissions.Text = "View Submissions (Ctrl + V)"
        Me.btnViewSubmissions.UseVisualStyleBackColor = False
        '
        'btnCreateSubmission
        '
        Me.btnCreateSubmission.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCreateSubmission.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateSubmission.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnCreateSubmission.Location = New System.Drawing.Point(421, 240)
        Me.btnCreateSubmission.Name = "btnCreateSubmission"
        Me.btnCreateSubmission.Size = New System.Drawing.Size(284, 45)
        Me.btnCreateSubmission.TabIndex = 1
        Me.btnCreateSubmission.Text = "Create New Submission (Ctrl + N)"
        Me.btnCreateSubmission.UseVisualStyleBackColor = False
        '
        'btnDeleteSubmission
        '
        Me.btnDeleteSubmission.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnDeleteSubmission.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteSubmission.Location = New System.Drawing.Point(203, 86)
        Me.btnDeleteSubmission.Name = "btnDeleteSubmission"
        Me.btnDeleteSubmission.Size = New System.Drawing.Size(245, 51)
        Me.btnDeleteSubmission.TabIndex = 2
        Me.btnDeleteSubmission.Text = "Delete Submission (Ctrl + D)"
        Me.btnDeleteSubmission.UseVisualStyleBackColor = False
        '
        'txtPhoneNumberToDelete
        '
        Me.txtPhoneNumberToDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumberToDelete.Location = New System.Drawing.Point(500, 105)
        Me.txtPhoneNumberToDelete.Multiline = True
        Me.txtPhoneNumberToDelete.Name = "txtPhoneNumberToDelete"
        Me.txtPhoneNumberToDelete.Size = New System.Drawing.Size(171, 32)
        Me.txtPhoneNumberToDelete.TabIndex = 3
        Me.txtPhoneNumberToDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(539, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter Phone Number"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPhoneNumberToDelete)
        Me.Controls.Add(Me.btnDeleteSubmission)
        Me.Controls.Add(Me.btnCreateSubmission)
        Me.Controls.Add(Me.btnViewSubmissions)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateSubmission As Button
    Friend WithEvents btnDeleteSubmission As Button
    Friend WithEvents txtPhoneNumberToDelete As TextBox
    Friend WithEvents Label1 As Label
End Class
