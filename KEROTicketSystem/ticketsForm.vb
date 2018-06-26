Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.Collections.Specialized

Public Class ticketsForm
    Private da As MySqlDataAdapter
    Private bsource As BindingSource = New BindingSource()
    Private ds As DataSet = Nothing
    Private sql As String
    Private conn As MySqlConnection
    Private dt As New MySqlDataAdapter


    Public connString As String
    Public selectedTicket As String

    Dim iCount As UInteger

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        connString = My.Settings.ConnString
    End Sub

    Private Sub ticketsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadData()
        GetAgents()
        GetStatus()
        GetTags()
        GetLastTicket()

        iCount = 0
        checkTicketsTimer.Enabled = True

    End Sub

    Private Sub ConnectDatabase()
        Try

            conn = New MySqlConnection()
            conn.ConnectionString = connString

            conn.Open()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Private Sub LoadData()
        Try
            ConnectDatabase()                                                       'connect to DB
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor                'display wait cursor when loading
            'sql query

            sql = "SELECT * From wp_wsdesk_tickets"

            da = New MySqlDataAdapter(sql, conn)                    'make new dataAdapter (with sql query, and connection string)
            'ConnectDatabase()                                                       'connect to DB

            ds = New DataSet                                                        'make new dataSet
            Dim commandBuilder As MySqlCommandBuilder = New MySqlCommandBuilder(da) 'make instance of command builder(with data adapter)



            da.Fill(ds, "wp_wsdesk_tickets")                                                 'fill data adapter with (dataset and table called customer 
            bsource.DataSource = ds.Tables("wp_wsdesk_tickets")                              'set binding source to the same as (dataset table (customer))
            ticketsDataGridView.DataSource = bsource                               'set DGV datasource to the same as the binding source


            ticketsDataGridView.Sort(ticketsDataGridView.Columns(0), SortOrder.Ascending)

        Catch ex As Exception
        End Try
    End Sub
    Public Sub GetAgents()
        Try
            Dim result As New ArrayList()

            ' Set the connection string in the Solutions Explorer/Properties/Settings object (double-click)
            Using cmd = New MySqlCommand("SELECT * FROM wp_users", conn)

                Try
                    Dim dr = cmd.ExecuteReader()
                    While dr.Read()

                        Dim dict As New Dictionary(Of String, Object)
                        For count As Integer = 0 To (dr.FieldCount - 1)
                            dict.Add(dr.GetName(count), dr(count))
                        Next

                        ' Add the dictionary to the ArrayList
                        result.Add(dict)


                    End While

                    dr.Close()  ' close datareader
                    dr.Dispose()

                    For Each dat As Dictionary(Of String, Object) In result
                        agentNameComboBox.Items.Add(dat("user_login"))
                        agentIDComboBox.Items.Add(dat(("ID")))
                    Next

                Catch ex As MySqlException

                    MessageBox.Show("There was an error accessing your data. DETAIL: " & ex.ToString())
                End Try
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub GetTags()
        Try
            Dim result As New ArrayList()

            ' Set the connection string in the Solutions Explorer/Properties/Settings object (double-click)
            Using cmd = New MySqlCommand("SELECT * FROM wp_wsdesk_settings WHERE type = 'tag'", conn)

                Try
                    Dim dr = cmd.ExecuteReader()
                    While dr.Read()

                        Dim dict As New Dictionary(Of String, Object)
                        For count As Integer = 0 To (dr.FieldCount - 1)
                            dict.Add(dr.GetName(count), dr(count))
                        Next

                        ' Add the dictionary to the ArrayList
                        result.Add(dict)


                    End While

                    dr.Close()  ' close datareader
                    dr.Dispose()

                    For Each dat As Dictionary(Of String, Object) In result
                        tagNameComboBox.Items.Add(dat("title"))
                        tagIDComboBox.Items.Add(dat(("slug")))
                    Next

                Catch ex As MySqlException

                    MessageBox.Show("There was an error accessing your data. DETAIL: " & ex.ToString())
                End Try
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub GetStatus()
        Try
            Dim result As New ArrayList()

            ' Set the connection string in the Solutions Explorer/Properties/Settings object (double-click)
            Using cmd = New MySqlCommand("SELECT * FROM wp_wsdesk_settings WHERE type = 'label' ", conn)

                Try
                    Dim dr = cmd.ExecuteReader()
                    While dr.Read()

                        Dim dict As New Dictionary(Of String, Object)
                        For count As Integer = 0 To (dr.FieldCount - 1)
                            dict.Add(dr.GetName(count), dr(count))
                        Next

                        ' Add the dictionary to the ArrayList
                        result.Add(dict)


                    End While

                    dr.Close()  ' close datareader
                    dr.Dispose()

                    For Each dat As Dictionary(Of String, Object) In result
                        statusNameComboBox.Items.Add(dat("title"))
                        statusIDNameComboBox.Items.Add(dat(("slug")))
                    Next

                Catch ex As MySqlException

                    MessageBox.Show("There was an error accessing your data. DETAIL: " & ex.ToString())
                End Try
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub UpdateLabels()
        Dim i As Integer  'declare variable

        If ticketsDataGridView.SelectedRows.Count > 0 Then
            '  customerGroupBox.Visible = True
            i = ticketsDataGridView.CurrentRow.Index       'i = dgv row index

            selectedTicket = ticketsDataGridView.Item(0, i).Value.ToString
            '    customerGroupBox.Text = ticketsDataGridView.Item(1, i).Value.ToString             'update labels to match dgv row headers
            '    custAdd1Label.Text = ticketsDataGridView.Item(2, i).Value.ToString             '
            '    custAdd2Label.Text = ticketsDataGridView.Item(3, i).Value.ToString             '
            '    custTownLabel.Text = ticketsDataGridView.Item(4, i).Value.ToString             '
            '    custCountyLabel.Text = ticketsDataGridView.Item(5, i).Value.ToString           '
            '    custPostCodeLabel.Text = ticketsDataGridView.Item(6, i).Value.ToString         '
            '    custPhone.Text = ticketsDataGridView.Item(7, i).Value.ToString                 '
            '    custFaxLabel.Text = ticketsDataGridView.Item(8, i).Value.ToString              '
            '    custEmailNameLabel.Text = ticketsDataGridView.Item(9, i).Value.ToString
            '    custConactNameLabel.Text = ticketsDataGridView.Item(10, i).Value.ToString       '
            '    custAccountNameLabel.Text = ticketsDataGridView.Item(11, i).Value.ToString     '


            '    ticketsDataGridView.Columns(0).Visible = False                                 'hide Cust_ID column

            '    customerEditButton.Enabled = True
            '    customerDeleteButton.Enabled = True

            'Else
            '    customerGroupBox.Text = ""             'update labels to match dgv row headers
            '    custAdd1Label.Text = ""                  '
            '    custAdd2Label.Text = ""                  '
            '    custTownLabel.Text = ""                  '
            '    custCountyLabel.Text = ""              '
            '    custPostCodeLabel.Text = ""              '
            '    custPhone.Text = ""                   '
            '    custFaxLabel.Text = ""            '
            '    custEmailNameLabel.Text = ""
            '    custConactNameLabel.Text = ""            '
            '    custAccountNameLabel.Text = ""
            '    customerEditButton.Enabled = False
            '    customerDeleteButton.Enabled = False
        End If


    End Sub

    Private Sub agentNameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles agentNameComboBox.SelectedIndexChanged
        agentIDComboBox.SelectedIndex = agentNameComboBox.SelectedIndex
        Dim tempagentID As String = agentIDComboBox.Text
        Label1.Text = "a:1:{i:0:d:1:" & tempagentID & ":}"


        Try
            Dim result As New ArrayList()

            ' Set the connection string in the Solutions Explorer/Properties/Settings object (double-click)
            Using cmd = New MySqlCommand("SELECT * FROM wp_wsdesk_ticketsmeta WHERE meta_value like '" & Label1.Text & "' ", conn)

                Try
                    Dim dr = cmd.ExecuteReader()
                    While dr.Read()

                        Dim dict As New Dictionary(Of String, Object)
                        For count As Integer = 0 To (dr.FieldCount - 1)
                            dict.Add(dr.GetName(count), dr(count))
                        Next

                        ' Add the dictionary to the ArrayList
                        result.Add(dict)


                    End While

                    dr.Close()  ' close datareader
                    dr.Dispose()

                    For Each dat As Dictionary(Of String, Object) In result
                        Dim agentTicketID As String =
                        statusIDNameComboBox.Items.Add(dat(("slug")))
                    Next

                Catch ex As MySqlException

                    MessageBox.Show("There was an error accessing your data. DETAIL: " & ex.ToString())
                End Try
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub tagNameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tagNameComboBox.SelectedIndexChanged
        tagIDComboBox.SelectedIndex = tagNameComboBox.SelectedIndex
        Dim temptagID As String = tagIDComboBox.Text

    End Sub

    Private Sub statusNameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles statusNameComboBox.SelectedIndexChanged
        statusIDNameComboBox.SelectedIndex = statusNameComboBox.SelectedIndex
        Dim tempstatusID As String = statusIDNameComboBox.Text

    End Sub

    Private Sub ticketsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ticketsDataGridView.CellContentClick

    End Sub

    Private Sub GetLastTicket()
        Dim tempTicket As Integer
        Try
            Dim cmd As New MySqlCommand("SELECT MAX(ticket_id) From wp_wsdesk_tickets", conn)
            Dim myreader As MySqlDataReader
            myreader = cmd.ExecuteReader()
            myreader.Read()
            If myreader.HasRows Then
                tempTicket = (myreader.Item("MAX(ticket_id)"))


            End If
            myreader.Close()
            myreader.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        My.Settings.LastTicket = tempTicket
        My.Settings.Save()

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub ticketsDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles ticketsDataGridView.DoubleClick
        Dim EditTicket As New editTicketForm
        editTicketForm.selectedTicket = selectedTicket

        editTicketForm.Show()

    End Sub

    Private Sub ticketsDataGridView_Click(sender As Object, e As EventArgs) Handles ticketsDataGridView.Click
        UpdateLabels()
    End Sub

    Private Sub checkTicketsTimer_Tick(sender As Object, e As EventArgs) Handles checkTicketsTimer.Tick
        iCount += 1

        Label1.Text = iCount
    End Sub
End Class