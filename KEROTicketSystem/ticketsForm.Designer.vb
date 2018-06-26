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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ticketsDataGridView = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.agentIDComboBox = New System.Windows.Forms.ComboBox()
        Me.agentNameComboBox = New System.Windows.Forms.ComboBox()
        Me.statusNameComboBox = New System.Windows.Forms.ComboBox()
        Me.statusIDNameComboBox = New System.Windows.Forms.ComboBox()
        Me.tagNameComboBox = New System.Windows.Forms.ComboBox()
        Me.tagIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.checkTicketsTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ticketsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ticketsDataGridView, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 2)
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
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 388.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.agentIDComboBox, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.agentNameComboBox, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.statusNameComboBox, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.statusIDNameComboBox, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.tagNameComboBox, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tagIDComboBox, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(8, 292)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.93617!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.06383!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(776, 125)
        Me.TableLayoutPanel2.TabIndex = 50
        '
        'agentIDComboBox
        '
        Me.agentIDComboBox.FormattingEnabled = True
        Me.agentIDComboBox.Location = New System.Drawing.Point(3, 26)
        Me.agentIDComboBox.Name = "agentIDComboBox"
        Me.agentIDComboBox.Size = New System.Drawing.Size(188, 21)
        Me.agentIDComboBox.TabIndex = 53
        '
        'agentNameComboBox
        '
        Me.agentNameComboBox.FormattingEnabled = True
        Me.agentNameComboBox.Location = New System.Drawing.Point(3, 3)
        Me.agentNameComboBox.Name = "agentNameComboBox"
        Me.agentNameComboBox.Size = New System.Drawing.Size(188, 21)
        Me.agentNameComboBox.TabIndex = 51
        '
        'statusNameComboBox
        '
        Me.statusNameComboBox.FormattingEnabled = True
        Me.statusNameComboBox.Location = New System.Drawing.Point(197, 3)
        Me.statusNameComboBox.Name = "statusNameComboBox"
        Me.statusNameComboBox.Size = New System.Drawing.Size(188, 21)
        Me.statusNameComboBox.TabIndex = 55
        '
        'statusIDNameComboBox
        '
        Me.statusIDNameComboBox.FormattingEnabled = True
        Me.statusIDNameComboBox.Location = New System.Drawing.Point(197, 26)
        Me.statusIDNameComboBox.Name = "statusIDNameComboBox"
        Me.statusIDNameComboBox.Size = New System.Drawing.Size(188, 21)
        Me.statusIDNameComboBox.TabIndex = 54
        '
        'tagNameComboBox
        '
        Me.tagNameComboBox.FormattingEnabled = True
        Me.tagNameComboBox.Location = New System.Drawing.Point(391, 3)
        Me.tagNameComboBox.Name = "tagNameComboBox"
        Me.tagNameComboBox.Size = New System.Drawing.Size(188, 21)
        Me.tagNameComboBox.TabIndex = 56
        '
        'tagIDComboBox
        '
        Me.tagIDComboBox.FormattingEnabled = True
        Me.tagIDComboBox.Location = New System.Drawing.Point(391, 26)
        Me.tagIDComboBox.Name = "tagIDComboBox"
        Me.tagIDComboBox.Size = New System.Drawing.Size(188, 21)
        Me.tagIDComboBox.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Label1"
        '
        'checkTicketsTimer
        '
        Me.checkTicketsTimer.Interval = 500
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
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ticketsDataGridView As DataGridView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents agentNameComboBox As ComboBox
    Friend WithEvents agentIDComboBox As ComboBox
    Friend WithEvents statusNameComboBox As ComboBox
    Friend WithEvents statusIDNameComboBox As ComboBox
    Friend WithEvents tagNameComboBox As ComboBox
    Friend WithEvents tagIDComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents checkTicketsTimer As Timer
End Class
