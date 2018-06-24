<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.chatLabel = New System.Windows.Forms.Label()
        Me.ticketLabel = New System.Windows.Forms.Label()
        Me.settingsLabel = New System.Windows.Forms.Label()
        Me.settingsIconPictureBox = New System.Windows.Forms.PictureBox()
        Me.settingsPictureBox = New System.Windows.Forms.PictureBox()
        Me.closePictureBox = New System.Windows.Forms.PictureBox()
        Me.minPictureBox = New System.Windows.Forms.PictureBox()
        Me.chatIconPictureBox = New System.Windows.Forms.PictureBox()
        Me.ticketIconPictureBox = New System.Windows.Forms.PictureBox()
        Me.pinIconPictureBox = New System.Windows.Forms.PictureBox()
        Me.chatPictureBox = New System.Windows.Forms.PictureBox()
        Me.ticketPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.settingsIconPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.settingsPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chatIconPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ticketIconPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pinIconPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chatPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ticketPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'chatLabel
        '
        Me.chatLabel.AutoSize = True
        Me.chatLabel.BackColor = System.Drawing.Color.White
        Me.chatLabel.Font = New System.Drawing.Font("Gotham Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chatLabel.ForeColor = System.Drawing.Color.Black
        Me.chatLabel.Location = New System.Drawing.Point(32, 79)
        Me.chatLabel.Name = "chatLabel"
        Me.chatLabel.Size = New System.Drawing.Size(37, 15)
        Me.chatLabel.TabIndex = 54
        Me.chatLabel.Text = "Chat"
        '
        'ticketLabel
        '
        Me.ticketLabel.AutoSize = True
        Me.ticketLabel.BackColor = System.Drawing.Color.White
        Me.ticketLabel.Font = New System.Drawing.Font("Gotham Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ticketLabel.ForeColor = System.Drawing.Color.Black
        Me.ticketLabel.Location = New System.Drawing.Point(29, 56)
        Me.ticketLabel.Name = "ticketLabel"
        Me.ticketLabel.Size = New System.Drawing.Size(51, 15)
        Me.ticketLabel.TabIndex = 66
        Me.ticketLabel.Text = "Tickets"
        '
        'settingsLabel
        '
        Me.settingsLabel.AutoSize = True
        Me.settingsLabel.BackColor = System.Drawing.Color.White
        Me.settingsLabel.Font = New System.Drawing.Font("Gotham Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settingsLabel.ForeColor = System.Drawing.Color.Black
        Me.settingsLabel.Location = New System.Drawing.Point(32, 103)
        Me.settingsLabel.Name = "settingsLabel"
        Me.settingsLabel.Size = New System.Drawing.Size(59, 15)
        Me.settingsLabel.TabIndex = 88
        Me.settingsLabel.Text = "Settings"
        '
        'settingsIconPictureBox
        '
        Me.settingsIconPictureBox.BackColor = System.Drawing.Color.White
        Me.settingsIconPictureBox.BackgroundImage = Global.KEROTicketSystem.My.Resources.Resources.Settings_96px
        Me.settingsIconPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.settingsIconPictureBox.Enabled = False
        Me.settingsIconPictureBox.Location = New System.Drawing.Point(2, 99)
        Me.settingsIconPictureBox.Name = "settingsIconPictureBox"
        Me.settingsIconPictureBox.Size = New System.Drawing.Size(25, 25)
        Me.settingsIconPictureBox.TabIndex = 89
        Me.settingsIconPictureBox.TabStop = False
        '
        'settingsPictureBox
        '
        Me.settingsPictureBox.BackColor = System.Drawing.Color.White
        Me.settingsPictureBox.Location = New System.Drawing.Point(2, 99)
        Me.settingsPictureBox.Name = "settingsPictureBox"
        Me.settingsPictureBox.Size = New System.Drawing.Size(176, 25)
        Me.settingsPictureBox.TabIndex = 87
        Me.settingsPictureBox.TabStop = False
        '
        'closePictureBox
        '
        Me.closePictureBox.BackgroundImage = Global.KEROTicketSystem.My.Resources.Resources.Close_Window_96px
        Me.closePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.closePictureBox.Location = New System.Drawing.Point(130, 0)
        Me.closePictureBox.Name = "closePictureBox"
        Me.closePictureBox.Size = New System.Drawing.Size(22, 19)
        Me.closePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.closePictureBox.TabIndex = 86
        Me.closePictureBox.TabStop = False
        '
        'minPictureBox
        '
        Me.minPictureBox.BackgroundImage = Global.KEROTicketSystem.My.Resources.Resources.Minimize_Window_96px_2
        Me.minPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.minPictureBox.Location = New System.Drawing.Point(2, 0)
        Me.minPictureBox.Name = "minPictureBox"
        Me.minPictureBox.Size = New System.Drawing.Size(22, 19)
        Me.minPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.minPictureBox.TabIndex = 85
        Me.minPictureBox.TabStop = False
        '
        'chatIconPictureBox
        '
        Me.chatIconPictureBox.BackColor = System.Drawing.Color.White
        Me.chatIconPictureBox.BackgroundImage = Global.KEROTicketSystem.My.Resources.Resources.Chat_96px
        Me.chatIconPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.chatIconPictureBox.Enabled = False
        Me.chatIconPictureBox.Location = New System.Drawing.Point(2, 75)
        Me.chatIconPictureBox.Name = "chatIconPictureBox"
        Me.chatIconPictureBox.Size = New System.Drawing.Size(25, 25)
        Me.chatIconPictureBox.TabIndex = 72
        Me.chatIconPictureBox.TabStop = False
        '
        'ticketIconPictureBox
        '
        Me.ticketIconPictureBox.BackColor = System.Drawing.Color.White
        Me.ticketIconPictureBox.BackgroundImage = Global.KEROTicketSystem.My.Resources.Resources.Ticket_96px
        Me.ticketIconPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ticketIconPictureBox.Enabled = False
        Me.ticketIconPictureBox.Location = New System.Drawing.Point(2, 50)
        Me.ticketIconPictureBox.Name = "ticketIconPictureBox"
        Me.ticketIconPictureBox.Size = New System.Drawing.Size(25, 25)
        Me.ticketIconPictureBox.TabIndex = 71
        Me.ticketIconPictureBox.TabStop = False
        '
        'pinIconPictureBox
        '
        Me.pinIconPictureBox.BackgroundImage = Global.KEROTicketSystem.My.Resources.Resources.Pin_in_circle_96px
        Me.pinIconPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pinIconPictureBox.Location = New System.Drawing.Point(2, 23)
        Me.pinIconPictureBox.Name = "pinIconPictureBox"
        Me.pinIconPictureBox.Size = New System.Drawing.Size(22, 19)
        Me.pinIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pinIconPictureBox.TabIndex = 70
        Me.pinIconPictureBox.TabStop = False
        '
        'chatPictureBox
        '
        Me.chatPictureBox.BackColor = System.Drawing.Color.White
        Me.chatPictureBox.Location = New System.Drawing.Point(2, 75)
        Me.chatPictureBox.Name = "chatPictureBox"
        Me.chatPictureBox.Size = New System.Drawing.Size(176, 25)
        Me.chatPictureBox.TabIndex = 48
        Me.chatPictureBox.TabStop = False
        '
        'ticketPictureBox
        '
        Me.ticketPictureBox.BackColor = System.Drawing.Color.White
        Me.ticketPictureBox.Location = New System.Drawing.Point(2, 50)
        Me.ticketPictureBox.Name = "ticketPictureBox"
        Me.ticketPictureBox.Size = New System.Drawing.Size(176, 25)
        Me.ticketPictureBox.TabIndex = 52
        Me.ticketPictureBox.TabStop = False
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(150, 192)
        Me.Controls.Add(Me.settingsIconPictureBox)
        Me.Controls.Add(Me.settingsLabel)
        Me.Controls.Add(Me.settingsPictureBox)
        Me.Controls.Add(Me.closePictureBox)
        Me.Controls.Add(Me.minPictureBox)
        Me.Controls.Add(Me.chatIconPictureBox)
        Me.Controls.Add(Me.ticketIconPictureBox)
        Me.Controls.Add(Me.pinIconPictureBox)
        Me.Controls.Add(Me.chatLabel)
        Me.Controls.Add(Me.chatPictureBox)
        Me.Controls.Add(Me.ticketLabel)
        Me.Controls.Add(Me.ticketPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mainForm"
        Me.Text = " "
        CType(Me.settingsIconPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.settingsPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chatIconPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ticketIconPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pinIconPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chatPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ticketPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chatIconPictureBox As PictureBox
    Friend WithEvents ticketIconPictureBox As PictureBox
    Friend WithEvents pinIconPictureBox As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents chatLabel As Label
    Friend WithEvents chatPictureBox As PictureBox
    Friend WithEvents ticketLabel As Label
    Friend WithEvents ticketPictureBox As PictureBox
    Friend WithEvents minPictureBox As PictureBox
    Friend WithEvents closePictureBox As PictureBox
    Friend WithEvents settingsIconPictureBox As PictureBox
    Friend WithEvents settingsLabel As Label
    Friend WithEvents settingsPictureBox As PictureBox

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()

        StartSmall = My.Settings.StartSmall
        AlywaysOnTop = My.Settings.AlwaysOnTop

        If AlywaysOnTop = "True" Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If

        If StartSmall = "True" Then

            dockWindow()

        Else

            Me.StartPosition = StartPosition.CenterScreen

            'Me.StartPosition = FormStartPosition.Manual
            'Me.Left = Screen.Width - 40

            'Me.Top = (Screen.Height \ 2) - (Me.Height \ 2)
            'Me.Left = (Screen.Width \ 4) - (Me.Width \ 2)

        End If

    End Sub
End Class
