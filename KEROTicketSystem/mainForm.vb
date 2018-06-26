Imports System.Drawing
Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.Collections.Specialized

Public Class mainForm
    Private da As MySqlDataAdapter
    Private bsource As BindingSource = New BindingSource()
    Private ds As DataSet = Nothing
    Private sql As String
    Private conn As MySqlConnection
    Private dt As New MySqlDataAdapter


    Public StartSmall As String
    Public AlywaysOnTop As String
    Public ConnString As String


    Dim dockedleft As Boolean = False
    Dim dockedwidth As Boolean = False
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim ticketcount As Integer
    Dim lastTicket As String = 0
    Dim tempTicket As Integer = -0

    Dim unpin As Image = My.Resources.Unpin_2_96px
    Dim pin As Image = My.Resources.Pin_in_circle_96px

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each cntrl As Control In Me.Controls
            If TypeOf cntrl Is Label Then
                cntrl.BackColor = Color.White
            End If
        Next
        lastTicket = My.Settings.LastTicket.ToString
        chatLabel.Text = lastTicket

        ticketLabel.Text = tempTicket

        tempTicket = lastTicket
        checkTimer.Enabled = True
        ConnString = My.Settings.ConnString
    End Sub
    Private Sub mainForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown

        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
        Me.Cursor = Cursors.SizeAll

    End Sub

    Private Sub mainForm_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        drag = False
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub mainForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
        If drag Then
            If pinIconPictureBox.Image Is unpin Then
                Me.Top = Cursor.Position.Y - mousey
                If Me.Top + Me.Height = Screen.Height Then
                    ' add code to stop form going outside the screen

                End If
            Else
                Me.Top = Cursor.Position.Y - mousey
                Me.Left = Cursor.Position.X - mousex
            End If

        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ''###############################
        ''#     Make the form small     #
        ''###############################

        If dockedwidth = True Then
            Me.Width += 5
            If Me.Width >= 150 Then
                Timer1.Enabled = False
                Me.Width = 150
                dockedwidth = False

            End If
        Else
            Me.Width -= 5
            If Me.Width <= 30 Then
                Timer1.Enabled = False

                Me.Width = 30
                dockedwidth = True

            End If
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        ''###############################
        ''#  slide from left to right   #
        ''###############################

        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()

        If dockedleft = False Then
            Me.Left += 50
            If Me.Left >= Screen.Width Then
                Timer2.Enabled = False
                Me.Left = Screen.Width - 40
                dockedleft = True
                pinIconPictureBox.Image = unpin
            End If

        Else

            Me.Left -= 50
            If Me.Left <= (Screen.Width \ 2) - (Me.Width \ 2) Then

                Timer2.Enabled = False
                dockedleft = False
                Me.Left = (Screen.Width \ 2) - (Me.Width \ 2)
            End If

        End If

    End Sub
    Private Sub dockWindow()
        Timer1.Enabled = True
        Timer2.Enabled = True

        If pinIconPictureBox.Image Is pin Then
            pinIconPictureBox.Image = unpin
        Else
            pinIconPictureBox.Image = pin
        End If

    End Sub
    Private Sub pinIconPictureBox_Click(sender As Object, e As EventArgs) Handles pinIconPictureBox.Click
        dockWindow()
    End Sub

    Private Sub minPictureBox_Click(sender As Object, e As EventArgs) Handles minPictureBox.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub closePictureBox_Click(sender As Object, e As EventArgs) Handles closePictureBox.Click
        Me.Close()

    End Sub
    Private Sub settingsPictureBox_Click(sender As Object, e As EventArgs) Handles settingsPictureBox.Click
        Dim SettingsForm As New settingsForm
        If dockedleft = True Then
            SettingsForm.StartPosition = FormStartPosition.Manual
            SettingsForm.Location = New Point(Me.Left + Me.Width, Me.Top)


            SettingsForm.Left = Screen.PrimaryScreen.Bounds.Right - SettingsForm.Width - Me.Width

        Else
            dockWindow()
            SettingsForm.StartPosition = StartPosition.CenterScreen

            '##########   THIS WILL LOAD THE FORM RIGHT BESIDE THE DOCKED FORM   ##################
            'SettingsForm.StartPosition = FormStartPosition.Manual
            'SettingsForm.Location = New Point(Me.Left + Me.Width, Me.Top)
            'If SettingsForm.Left + SettingsForm.Width > Screen.PrimaryScreen.Bounds.Right() Then
            '    SettingsForm.Left = Screen.PrimaryScreen.Bounds.Right - SettingsForm.Width
            'End If

            'Me.Left = SettingsForm.Left - Me.Width

        End If

        SettingsForm.ShowDialog()

    End Sub

    Private Sub ticketPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles ticketPictureBox.MouseMove
        ticketPictureBox.BackColor = Color.PowderBlue
        ticketLabel.BackColor = Color.PowderBlue
        ticketIconPictureBox.BackColor = Color.PowderBlue
    End Sub


    Private Sub ticketPictureBox_MouseLeave(sender As Object, e As EventArgs) Handles ticketPictureBox.MouseLeave
        ticketPictureBox.BackColor = Color.White
        ticketLabel.BackColor = Color.White
        ticketIconPictureBox.BackColor = Color.White
    End Sub

    Private Sub ticketPictureBox_Click(sender As Object, e As EventArgs) Handles ticketPictureBox.Click
        Dim TicketsForm As New ticketsForm

        If flashTimer.Enabled = True Then
            flashTimer.Enabled = False
            Me.BackColor = Color.White
            For Each cntrl As Control In Me.Controls
                If TypeOf cntrl Is PictureBox Then
                    cntrl.BackColor = Color.White
                End If
            Next
            lastTicket = tempTicket
            My.Settings.Save()
        Else
            'you'll do nuttin!
        End If


        If dockedleft = True Then
            TicketsForm.StartPosition = FormStartPosition.Manual
            TicketsForm.Location = New Point(Me.Left + Me.Width, Me.Top)


            TicketsForm.Left = Screen.PrimaryScreen.Bounds.Right - TicketsForm.Width - Me.Width - 15

        Else
            dockWindow()
            TicketsForm.StartPosition = StartPosition.CenterScreen

            '##########   THIS WILL LOAD THE FORM RIGHT BESIDE THE DOCKED FORM   ##################
            'SettingsForm.StartPosition = FormStartPosition.Manual
            'SettingsForm.Location = New Point(Me.Left + Me.Width, Me.Top)
            'If SettingsForm.Left + SettingsForm.Width > Screen.PrimaryScreen.Bounds.Right() Then
            '    SettingsForm.Left = Screen.PrimaryScreen.Bounds.Right - SettingsForm.Width
            'End If

            'Me.Left = SettingsForm.Left - Me.Width

        End If

        TicketsForm.ShowDialog()

    End Sub

    Private Sub ConnectDatabase()
        Try

            conn = New MySqlConnection()
            conn.ConnectionString = ConnString

            conn.Open()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub GetLastTicket()

        Try
            ConnectDatabase()
            Dim cmd As New MySqlCommand("SELECT MAX(ticket_id) From wp_wsdesk_tickets", conn)
            Dim myreader As MySqlDataReader
            myreader = cmd.ExecuteReader()
            myreader.Read()
            If myreader.HasRows Then
                tempTicket = (myreader.Item("MAX(ticket_id)"))
                ticketLabel.Text = tempTicket

            End If
            myreader.Close()
            myreader.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub checkTimer_Tick(sender As Object, e As EventArgs) Handles checkTimer.Tick
        ticketcount += 1
        settingsLabel.Text = ticketcount

        If tempTicket > lastTicket Then
            notifyNewTicket()
        Else
            flashTimer.Enabled = False
        End If

        If ticketcount = 30 Then
            GetLastTicket()

            ticketcount = 0
            chatLabel.Text = lastTicket
        End If

    End Sub
    Private Sub notifyNewTicket()
        Me.TopMost = True
        flashTimer.Enabled = True
    End Sub

    Private Sub flashTimer_Tick(sender As Object, e As EventArgs) Handles flashTimer.Tick
        If Me.BackColor = Color.White Then
            Me.BackColor = Color.Red
            For Each cntrl As Control In Me.Controls
                If TypeOf cntrl Is PictureBox Then
                    cntrl.BackColor = Color.Red
                End If
            Next
        Else
            Me.BackColor = Color.White

            For Each cntrl As Control In Me.Controls
                If TypeOf cntrl Is PictureBox Then
                    cntrl.BackColor = Color.White
                End If
            Next
        End If


    End Sub

    Private Sub settingsIconPictureBox_Click(sender As Object, e As EventArgs) Handles settingsIconPictureBox.Click

    End Sub

    Private Sub ticketIconPictureBox_Click(sender As Object, e As EventArgs) Handles ticketIconPictureBox.Click

    End Sub

    Private Sub cashCountPictureBox_Click(sender As Object, e As EventArgs) Handles cashCountPictureBox.Click
        Dim CashCount As New cashCountForm
        If dockedleft = True Then
            CashCount.StartPosition = FormStartPosition.Manual
            CashCount.Location = New Point(Me.Left + Me.Width, Me.Top)


            CashCount.Left = Screen.PrimaryScreen.Bounds.Right - CashCount.Width - Me.Width - 15

        Else
            dockWindow()
            CashCount.StartPosition = StartPosition.CenterScreen
        End If

        CashCount.ShowDialog()

    End Sub
End Class
