<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class editTicketForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.selectedTicketsDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.selectedTicketsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'selectedTicketsDataGridView
        '
        Me.selectedTicketsDataGridView.AllowUserToAddRows = False
        Me.selectedTicketsDataGridView.AllowUserToDeleteRows = False
        Me.selectedTicketsDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.selectedTicketsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.selectedTicketsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.selectedTicketsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.selectedTicketsDataGridView.EnableHeadersVisualStyles = False
        Me.selectedTicketsDataGridView.Location = New System.Drawing.Point(8, 8)
        Me.selectedTicketsDataGridView.MultiSelect = False
        Me.selectedTicketsDataGridView.Name = "selectedTicketsDataGridView"
        Me.selectedTicketsDataGridView.ReadOnly = True
        Me.selectedTicketsDataGridView.RowHeadersVisible = False
        Me.selectedTicketsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.selectedTicketsDataGridView.Size = New System.Drawing.Size(460, 366)
        Me.selectedTicketsDataGridView.TabIndex = 50
        Me.selectedTicketsDataGridView.Visible = False
        '
        'editTicketForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 566)
        Me.Controls.Add(Me.selectedTicketsDataGridView)
        Me.Name = "editTicketForm"
        Me.Text = "editTicketForm"
        CType(Me.selectedTicketsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents selectedTicketsDataGridView As DataGridView
End Class
