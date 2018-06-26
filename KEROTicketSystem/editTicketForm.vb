Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.Collections.Specialized

Public Class editTicketForm
    Private da As MySqlDataAdapter
    Private bsource As BindingSource = New BindingSource()
    Private ds As DataSet = Nothing
    Private sql As String
    Private conn As MySqlConnection
    Private dt As New MySqlDataAdapter


    Public connString As String
    Public selectedTicket As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        connString = My.Settings.ConnString
    End Sub

    Private Sub editTicketForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            sql = "SELECT * From wp_wsdesk_tickets where ticket_parent = '" & selectedTicket & "'"

            da = New MySqlDataAdapter(sql, conn)                    'make new dataAdapter (with sql query, and connection string)
            'ConnectDatabase()                                                       'connect to DB

            ds = New DataSet                                                        'make new dataSet
            Dim commandBuilder As MySqlCommandBuilder = New MySqlCommandBuilder(da) 'make instance of command builder(with data adapter)



            da.Fill(ds, "wp_wsdesk_tickets")                                                 'fill data adapter with (dataset and table called customer 
            bsource.DataSource = ds.Tables("wp_wsdesk_tickets")                              'set binding source to the same as (dataset table (customer))
            selectedticketsDataGridView.DataSource = bsource                               'set DGV datasource to the same as the binding source


            selectedticketsDataGridView.Sort(selectedticketsDataGridView.Columns(0), SortOrder.Ascending)

        Catch ex As Exception
        End Try
    End Sub

End Class