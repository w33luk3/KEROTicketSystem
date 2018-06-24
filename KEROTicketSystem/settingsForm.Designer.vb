<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settingsForm
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
        Me.ontopCheckBox = New System.Windows.Forms.CheckBox()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.startDockedCheckBox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ontopCheckBox
        '
        Me.ontopCheckBox.AutoSize = True
        Me.ontopCheckBox.Location = New System.Drawing.Point(12, 16)
        Me.ontopCheckBox.Name = "ontopCheckBox"
        Me.ontopCheckBox.Size = New System.Drawing.Size(98, 17)
        Me.ontopCheckBox.TabIndex = 0
        Me.ontopCheckBox.Text = "Always On Top"
        Me.ontopCheckBox.UseVisualStyleBackColor = True
        '
        'saveButton
        '
        Me.saveButton.Location = New System.Drawing.Point(12, 89)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(89, 23)
        Me.saveButton.TabIndex = 1
        Me.saveButton.Text = "Save"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'startDockedCheckBox
        '
        Me.startDockedCheckBox.AutoSize = True
        Me.startDockedCheckBox.Location = New System.Drawing.Point(12, 39)
        Me.startDockedCheckBox.Name = "startDockedCheckBox"
        Me.startDockedCheckBox.Size = New System.Drawing.Size(89, 17)
        Me.startDockedCheckBox.TabIndex = 2
        Me.startDockedCheckBox.Text = "Start Docked"
        Me.startDockedCheckBox.UseVisualStyleBackColor = True
        '
        'settingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(120, 129)
        Me.Controls.Add(Me.startDockedCheckBox)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.ontopCheckBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "settingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ontopCheckBox As CheckBox
    Friend WithEvents saveButton As Button
    Friend WithEvents startDockedCheckBox As CheckBox
End Class
