<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ticketsForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ticketsDataGridView = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ticketsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ticketsDataGridView, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(824, 484)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ticketsDataGridView
        '
        Me.ticketsDataGridView.AllowUserToAddRows = False
        Me.ticketsDataGridView.AllowUserToDeleteRows = False
        Me.ticketsDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ticketsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ticketsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ticketsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.ticketsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ticketsDataGridView.EnableHeadersVisualStyles = False
        Me.ticketsDataGridView.Location = New System.Drawing.Point(8, 8)
        Me.ticketsDataGridView.MultiSelect = False
        Me.ticketsDataGridView.Name = "ticketsDataGridView"
        Me.ticketsDataGridView.ReadOnly = True
        Me.ticketsDataGridView.RowHeadersVisible = False
        Me.ticketsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ticketsDataGridView.Size = New System.Drawing.Size(808, 278)
        Me.ticketsDataGridView.TabIndex = 49
        '
        'ticketsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 484)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ticketsForm"
        Me.Text = "ticketsForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.ticketsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ticketsDataGridView As DataGridView
End Class
