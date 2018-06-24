Imports MySql.Data.MySqlClient

Public Class ticketsForm
    Private da As MySqlDataAdapter
    Private bsource As BindingSource = New BindingSource()
    Private ds As DataSet = Nothing
    Private sql As String
    Private conn As MySqlConnection
    Private dt As New MySqlDataAdapter


    Public connString As String

    Private Sub ticketsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connString = My.Settings.ConnString
        LoadData()
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

            sql = "Select ticket_id as '#', ticket_email as 'Requester', ticket_title as 'Subject', ticket_date as 'Requested' From wp_wsdesk_tickets"

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
    Public Sub GetStatus()
        'Try
        '    ConnectDatabase()
        '    Dim cmd As New MySqlCommand("SELECT * FROM engineer WHERE Eng_ID = '" & EngineerID & "'", conn)
        '    Dim myreader As MySqlDataReader
        '    myreader = cmd.ExecuteReader()
        '    While myreader.Read
        '        engNameTextBox.Text = (myreader("Eng_Name"))
        '        engBillRateTextBox.Text = (myreader("Eng_BillRate"))
        '    End While
        '    myreader.Close()

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try

    End Sub
    Private Sub UpdateLabels()
        Dim i As Integer  'declare variable

        If ticketsDataGridView.SelectedRows.Count > 0 Then
            '  customerGroupBox.Visible = True
            i = ticketsDataGridView.CurrentRow.Index       'i = dgv row index

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

End Class