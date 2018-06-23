Public Class mainForm
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Imports System.Drawing


    Public Class mainForm
        Dim dockedleft As Boolean = False
        Dim dockedwidth As Boolean = False
        Dim drag As Boolean
        Dim mousex As Integer
        Dim mousey As Integer

        Dim unpin As Image = My.Resources.Unpin_32px
        Dim pin As Image = My.Resources.Pin_32px


        Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            For Each cntrl As Control In Me.Controls
                If TypeOf cntrl Is Label Then
                    cntrl.BackColor = Color.FromArgb(27, 36, 49)
                    'Do Something
                End If
            Next

            Dim Screen As System.Drawing.Rectangle
            Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
            Me.Top = (Screen.Height \ 2) - (Me.Height \ 2)
            Me.Left = (Screen.Width \ 4) - (Me.Width \ 2)

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
            If drag Then
                If pinIconPictureBox.Image Is unpin Then
                    Me.Top = Cursor.Position.Y - mousey


                Else

                    Me.Top = Cursor.Position.Y - mousey
                    Me.Left = Cursor.Position.X - mousex
                End If

            End If
        End Sub

        Private Sub customerButton_Click(sender As Object, e As EventArgs) Handles Button.Click
            Dim NewCustomer As New customerForm
            NewCustomer.StartPosition = FormStartPosition.Manual
            NewCustomer.Location = New Point(Me.Left + Me.Width, Me.Top)
            NewCustomer.ShowDialog()

            NewCustomer.Dispose()


        End Sub

        Private Sub customerPictureBox_Click(sender As Object, e As EventArgs) Handles customerPictureBox.Click
            Dim NewCustomer As New customerForm
            If dockedleft = True Then
                NewCustomer.StartPosition = FormStartPosition.CenterScreen

            Else

                NewCustomer.StartPosition = FormStartPosition.Manual
                NewCustomer.Location = New Point(Me.Left + Me.Width, Me.Top)
                If NewCustomer.Left + NewCustomer.Width > Screen.PrimaryScreen.Bounds.Right() Then
                    NewCustomer.Left = Screen.PrimaryScreen.Bounds.Right - NewCustomer.Width
                End If

                Me.Left = NewCustomer.Left - Me.Width

            End If

            NewCustomer.ShowDialog()

            NewCustomer.Dispose()

        End Sub

        Private Sub customerPictureBox_MouseEnter(sender As Object, e As EventArgs) Handles customerPictureBox.MouseEnter
            customerPictureBox.BackColor = Color.FromArgb(44, 55, 73)
            customerLabel.BackColor = Color.FromArgb(44, 55, 73)
            custIconPictureBox.BackColor = Color.FromArgb(44, 55, 73)
        End Sub
        Private Sub customerPictureBox_MouseLeave(sender As Object, e As EventArgs) Handles customerPictureBox.MouseLeave
            customerPictureBox.BackColor = Color.FromArgb(27, 36, 49)
            customerLabel.BackColor = Color.FromArgb(27, 36, 49)
            custIconPictureBox.BackColor = Color.FromArgb(27, 36, 49)
        End Sub


        Private Sub jobsheetsPictureBox_MouseEnter(sender As Object, e As EventArgs) Handles jobsheetsPictureBox.MouseEnter
            jobsheetsPictureBox.BackColor = Color.FromArgb(44, 55, 73)
            jobsheetLabel.BackColor = Color.FromArgb(44, 55, 73)
            jobSheetIconPictureBox.BackColor = Color.FromArgb(44, 55, 73)
        End Sub
        Private Sub jobsheetsPictureBox_MouseLeave(sender As Object, e As EventArgs) Handles jobsheetsPictureBox.MouseLeave
            jobsheetsPictureBox.BackColor = Color.FromArgb(27, 36, 49)
            jobsheetLabel.BackColor = Color.FromArgb(27, 36, 49)
            jobSheetIconPictureBox.BackColor = Color.FromArgb(27, 36, 49)
        End Sub

        Private Sub productsPictureBox_MouseEnter(sender As Object, e As EventArgs) Handles productsPictureBox.MouseEnter
            productsPictureBox.BackColor = Color.FromArgb(44, 55, 73)
            productLabel.BackColor = Color.FromArgb(44, 55, 73)
            productsIconPictureBox.BackColor = Color.FromArgb(44, 55, 73)

        End Sub

        Private Sub productsPictureBox_MouseLeave(sender As Object, e As EventArgs) Handles productsPictureBox.MouseLeave
            productsPictureBox.BackColor = Color.FromArgb(27, 36, 49)
            productLabel.BackColor = Color.FromArgb(27, 36, 49)
            productsIconPictureBox.BackColor = Color.FromArgb(27, 36, 49)

        End Sub
        Private Sub employeesPictureBox_MouseEnter(sender As Object, e As EventArgs) Handles employeesPictureBox.MouseEnter
            employeesPictureBox.BackColor = Color.FromArgb(44, 55, 73)
            employeeLabel.BackColor = Color.FromArgb(44, 55, 73)
            employeesIconPictureBox.BackColor = Color.FromArgb(44, 55, 73)

        End Sub

        Private Sub employeesPictureBox_MouseLeave(sender As Object, e As EventArgs) Handles employeesPictureBox.MouseLeave
            employeesPictureBox.BackColor = Color.FromArgb(27, 36, 49)
            employeeLabel.BackColor = Color.FromArgb(27, 36, 49)
            employeesIconPictureBox.BackColor = Color.FromArgb(27, 36, 49)

        End Sub


        Private Sub holsPictureBox_MouseEnter(sender As Object, e As EventArgs) Handles holsPictureBox.MouseEnter
            holsPictureBox.BackColor = Color.FromArgb(44, 55, 73)
            holsLabel.BackColor = Color.FromArgb(44, 55, 73)
            holsIconPictureBox.BackColor = Color.FromArgb(44, 55, 73)

        End Sub

        Private Sub holsPictureBox_MouseLeave(sender As Object, e As EventArgs) Handles holsPictureBox.MouseLeave
            holsPictureBox.BackColor = Color.FromArgb(27, 36, 49)
            holsLabel.BackColor = Color.FromArgb(27, 36, 49)
            holsIconPictureBox.BackColor = Color.FromArgb(27, 36, 49)

        End Sub

        Private Sub ordersPictureBox_MouseEnter(sender As Object, e As EventArgs) Handles ordersPictureBox.MouseEnter
            ordersPictureBox.BackColor = Color.FromArgb(44, 55, 73)
            ordersLabel.BackColor = Color.FromArgb(44, 55, 73)
            ordersIconPictureBox.BackColor = Color.FromArgb(44, 55, 73)

        End Sub

        Private Sub ordersPictureBox_MouseLeave(sender As Object, e As EventArgs) Handles ordersPictureBox.MouseLeave
            ordersPictureBox.BackColor = Color.FromArgb(27, 36, 49)
            ordersLabel.BackColor = Color.FromArgb(27, 36, 49)
            ordersIconPictureBox.BackColor = Color.FromArgb(27, 36, 49)

        End Sub

        Private Sub timeSheetPictureBox_MouseEnter(sender As Object, e As EventArgs) Handles timeSheetPictureBox.MouseEnter
            timeSheetPictureBox.BackColor = Color.FromArgb(44, 55, 73)
            timeSheetLabel.BackColor = Color.FromArgb(44, 55, 73)
            timeSheetIconPictureBox.BackColor = Color.FromArgb(44, 55, 73)

        End Sub

        Private Sub timeSheetPictureBox_MouseLeave(sender As Object, e As EventArgs) Handles timeSheetPictureBox.MouseLeave
            timeSheetPictureBox.BackColor = Color.FromArgb(27, 36, 49)
            timeSheetLabel.BackColor = Color.FromArgb(27, 36, 49)
            timeSheetIconPictureBox.BackColor = Color.FromArgb(27, 36, 49)

        End Sub

        Private Sub loggedbyPictureBox_MouseEnter(sender As Object, e As EventArgs) Handles loggedbyPictureBox.MouseEnter
            loggedbyPictureBox.BackColor = Color.FromArgb(44, 55, 73)
            loggedByLabel.BackColor = Color.FromArgb(44, 55, 73)
            loggedIconPictureBox.BackColor = Color.FromArgb(44, 55, 73)

        End Sub

        Private Sub loggedbyPictureBox_MouseLeave(sender As Object, e As EventArgs) Handles loggedbyPictureBox.MouseLeave
            loggedbyPictureBox.BackColor = Color.FromArgb(27, 36, 49)
            loggedByLabel.BackColor = Color.FromArgb(27, 36, 49)
            loggedIconPictureBox.BackColor = Color.FromArgb(27, 36, 49)

        End Sub

        Private Sub departmentsPictureBox_MouseEnter(sender As Object, e As EventArgs) Handles departmentsPictureBox.MouseEnter
            departmentsPictureBox.BackColor = Color.FromArgb(44, 55, 73)
            departmentsLabel.BackColor = Color.FromArgb(44, 55, 73)
            deptIconPictureBox.BackColor = Color.FromArgb(44, 55, 73)

        End Sub

        Private Sub departmentsPictureBox_MouseLeave(sender As Object, e As EventArgs) Handles departmentsPictureBox.MouseLeave
            departmentsPictureBox.BackColor = Color.FromArgb(27, 36, 49)
            departmentsLabel.BackColor = Color.FromArgb(27, 36, 49)
            deptIconPictureBox.BackColor = Color.FromArgb(27, 36, 49)

        End Sub

        Private Sub salesTeamPictureBox_MouseEnter(sender As Object, e As EventArgs) Handles salesTeamPictureBox.MouseEnter
            salesTeamPictureBox.BackColor = Color.FromArgb(44, 55, 73)
            salesTeamLabel.BackColor = Color.FromArgb(44, 55, 73)
            salesIconPictureBox.BackColor = Color.FromArgb(44, 55, 73)

        End Sub

        Private Sub salesTeamPictureBox_MouseLeave(sender As Object, e As EventArgs) Handles salesTeamPictureBox.MouseLeave
            salesTeamPictureBox.BackColor = Color.FromArgb(27, 36, 49)
            salesTeamLabel.BackColor = Color.FromArgb(27, 36, 49)
            salesIconPictureBox.BackColor = Color.FromArgb(27, 36, 49)

        End Sub

        Private Sub orderItemsPictureBox_MouseEnter(sender As Object, e As EventArgs) Handles orderItemsPictureBox.MouseEnter
            orderItemsPictureBox.BackColor = Color.FromArgb(44, 55, 73)
            orderItemsLabel.BackColor = Color.FromArgb(44, 55, 73)
            orderItemsIconPictureBox.BackColor = Color.FromArgb(44, 55, 73)


        End Sub

        Private Sub orderItemsPictureBox_MouseLeave(sender As Object, e As EventArgs) Handles orderItemsPictureBox.MouseLeave
            orderItemsPictureBox.BackColor = Color.FromArgb(27, 36, 49)
            orderItemsLabel.BackColor = Color.FromArgb(27, 36, 49)
            orderItemsIconPictureBox.BackColor = Color.FromArgb(27, 36, 49)

        End Sub


        Private Sub suppliersPictureBox_MouseEnter(sender As Object, e As EventArgs) Handles suppliersPictureBox.MouseEnter
            suppliersPictureBox.BackColor = Color.FromArgb(44, 55, 73)
            suppliersLabel.BackColor = Color.FromArgb(44, 55, 73)
            suppliersIconPictureBox.BackColor = Color.FromArgb(44, 55, 73)

        End Sub

        Private Sub suppliersPictureBox_MouseLeave(sender As Object, e As EventArgs) Handles suppliersPictureBox.MouseLeave
            suppliersPictureBox.BackColor = Color.FromArgb(27, 36, 49)
            suppliersLabel.BackColor = Color.FromArgb(27, 36, 49)
            suppliersIconPictureBox.BackColor = Color.FromArgb(27, 36, 49)

        End Sub
        Private Sub engineersPictureBox_MouseEnter(sender As Object, e As EventArgs) Handles engineersPictureBox.MouseEnter
            engineersPictureBox.BackColor = Color.FromArgb(44, 55, 73)
            engineersLabel.BackColor = Color.FromArgb(44, 55, 73)
            engineersIconPictureBox.BackColor = Color.FromArgb(44, 55, 73)

        End Sub

        Private Sub engineersPictureBox_MouseLeave(sender As Object, e As EventArgs) Handles engineersPictureBox.MouseLeave
            engineersPictureBox.BackColor = Color.FromArgb(27, 36, 49)
            engineersLabel.BackColor = Color.FromArgb(27, 36, 49)
            engineersIconPictureBox.BackColor = Color.FromArgb(27, 36, 49)
        End Sub
        Private Sub supplierInvoicePictureBox_MouseEnter(sender As Object, e As EventArgs) Handles supplierInvoicePictureBox.MouseEnter
            supplierInvoicePictureBox.BackColor = Color.FromArgb(44, 55, 73)
            supplierInvoiceLabel.BackColor = Color.FromArgb(44, 55, 73)
            supplierInvoiceIconPictureBox.BackColor = Color.FromArgb(44, 55, 73)

        End Sub

        Private Sub supplierInvoicePictureBox_MouseLeave(sender As Object, e As EventArgs) Handles supplierInvoicePictureBox.MouseLeave
            supplierInvoicePictureBox.BackColor = Color.FromArgb(27, 36, 49)
            supplierInvoiceLabel.BackColor = Color.FromArgb(27, 36, 49)
            supplierInvoiceIconPictureBox.BackColor = Color.FromArgb(27, 36, 49)
        End Sub

        Private Sub jobsheetsPictureBox_Click(sender As Object, e As EventArgs) Handles jobsheetsPictureBox.Click
            Dim NewJobsheet As New jobsheetForm
            If dockedleft = True Then
                NewJobsheet.StartPosition = FormStartPosition.CenterScreen

            Else

                NewJobsheet.StartPosition = FormStartPosition.Manual
                NewJobsheet.Location = New Point(Me.Left + Me.Width, Me.Top)
                If NewJobsheet.Left + NewJobsheet.Width > Screen.PrimaryScreen.Bounds.Right() Then
                    NewJobsheet.Left = Screen.PrimaryScreen.Bounds.Right - NewJobsheet.Width
                End If

                Me.Left = NewJobsheet.Left - Me.Width

            End If

            NewJobsheet.ShowDialog()

            NewJobsheet.Dispose()
        End Sub

        Private Sub jobsheetLabel_Click(sender As Object, e As EventArgs) Handles jobsheetLabel.Click
            jobsheetsPictureBox_Click(sender, e)
        End Sub

        Private Sub productsPictureBox_Click(sender As Object, e As EventArgs) Handles productsPictureBox.Click
            Dim NewProduct As New productForm
            If dockedleft = True Then
                NewProduct.StartPosition = FormStartPosition.CenterScreen

            Else

                NewProduct.StartPosition = FormStartPosition.Manual
                NewProduct.Location = New Point(Me.Left + Me.Width, Me.Top)
                If NewProduct.Left + NewProduct.Width > Screen.PrimaryScreen.Bounds.Right() Then
                    NewProduct.Left = Screen.PrimaryScreen.Bounds.Right - NewProduct.Width
                End If

                Me.Left = NewProduct.Left - Me.Width

            End If

            NewProduct.ShowDialog()

            NewProduct.Dispose()
        End Sub

        Private Sub employeesPictureBox_Click(sender As Object, e As EventArgs) Handles employeesPictureBox.Click
            Dim NewEmployee As New employeeForm
            If dockedleft = True Then
                NewEmployee.StartPosition = FormStartPosition.CenterScreen

            Else

                NewEmployee.StartPosition = FormStartPosition.Manual
                NewEmployee.Location = New Point(Me.Left + Me.Width, Me.Top)
                If NewEmployee.Left + NewEmployee.Width > Screen.PrimaryScreen.Bounds.Right() Then
                    NewEmployee.Left = Screen.PrimaryScreen.Bounds.Right - NewEmployee.Width
                End If

                Me.Left = NewEmployee.Left - Me.Width

            End If

            NewEmployee.ShowDialog()

            NewEmployee.Dispose()
        End Sub

        Private Sub holsPictureBox_Click(sender As Object, e As EventArgs) Handles holsPictureBox.Click
            Dim NewHoliday As New holsForm
            If dockedleft = True Then
                NewHoliday.StartPosition = FormStartPosition.CenterScreen

            Else

                NewHoliday.StartPosition = FormStartPosition.Manual
                NewHoliday.Location = New Point(Me.Left + Me.Width, Me.Top)
                If NewHoliday.Left + NewHoliday.Width > Screen.PrimaryScreen.Bounds.Right() Then
                    NewHoliday.Left = Screen.PrimaryScreen.Bounds.Right - NewHoliday.Width
                End If

                Me.Left = NewHoliday.Left - Me.Width

            End If

            NewHoliday.ShowDialog()

            NewHoliday.Dispose()
        End Sub

        Private Sub ordersPictureBox_Click(sender As Object, e As EventArgs) Handles ordersPictureBox.Click
            Dim NewOrder As New orderForm
            If dockedleft = True Then
                NewOrder.StartPosition = FormStartPosition.CenterScreen

            Else

                NewOrder.StartPosition = FormStartPosition.Manual
                NewOrder.Location = New Point(Me.Left + Me.Width, Me.Top)
                If NewOrder.Left + NewOrder.Width > Screen.PrimaryScreen.Bounds.Right() Then
                    NewOrder.Left = Screen.PrimaryScreen.Bounds.Right - NewOrder.Width
                End If

                Me.Left = NewOrder.Left - Me.Width

            End If

            NewOrder.ShowDialog()

            NewOrder.Dispose()
        End Sub

        Private Sub closeButton_Click_1(sender As Object, e As EventArgs) Handles closeButton.Click
            Me.Close()
        End Sub

        Private Sub minButton_Click_1(sender As Object, e As EventArgs) Handles minButton.Click
            Me.WindowState = FormWindowState.Minimized

        End Sub

        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
            If dockedwidth = True Then
                Me.Width += 5
                If Me.Width >= 205 Then
                    Timer1.Enabled = False
                    Me.Width = 205
                    dockedwidth = False

                End If
            Else
                Me.Width -= 5
                If Me.Width <= 40 Then
                    Timer1.Enabled = False

                    Me.Width = 40
                    dockedwidth = True

                End If
            End If

        End Sub

        Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick


            Dim Screen As System.Drawing.Rectangle
            Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()

            ''###############################
            ''#  slide from left to right   #
            ''###############################
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
                If Me.Left <= (Screen.Width \ 4) - (Me.Width \ 2) Then

                    Timer2.Enabled = False
                    dockedleft = False
                    Me.Left = (Screen.Width \ 4) - (Me.Width \ 2)
                End If

            End If



            ''###############################
            ''#  slide from right to left   #
            ''###############################
            'If dockedleft = True Then
            '    Me.Left += 30


            '    If Me.Left >= (Screen.Width \ 4) - (Me.Width \ 2) Then

            '        Timer2.Enabled = False
            '        dockedleft = False
            '        Me.Left = (Screen.Width \ 4) - (Me.Width \ 2)
            '    End If

            'Else
            '    Me.Left -= 30

            '    If Me.Left <= 0 Then

            '        Timer2.Enabled = False

            '        dockedleft = True

            '        Me.Left = 0
            '    End If
            'End If

        End Sub

        Private Sub pinIconPictureBox_Click(sender As Object, e As EventArgs) Handles pinIconPictureBox.Click
            Timer1.Enabled = True
            Timer2.Enabled = True

            If pinIconPictureBox.Image Is pin Then
                pinIconPictureBox.Image = unpin
            Else
                pinIconPictureBox.Image = pin
            End If




        End Sub

        Private Sub timeSheetPictureBox_Click(sender As Object, e As EventArgs) Handles timeSheetPictureBox.Click
            Dim NewTimeSheet As New timesheetForm
            If dockedleft = True Then
                NewTimeSheet.StartPosition = FormStartPosition.CenterScreen

            Else

                NewTimeSheet.StartPosition = FormStartPosition.Manual
                NewTimeSheet.Location = New Point(Me.Left + Me.Width, Me.Top)
                If NewTimeSheet.Left + NewTimeSheet.Width > Screen.PrimaryScreen.Bounds.Right() Then
                    NewTimeSheet.Left = Screen.PrimaryScreen.Bounds.Right - NewTimeSheet.Width
                End If

                Me.Left = NewTimeSheet.Left - Me.Width

            End If

            NewTimeSheet.ShowDialog()

            NewTimeSheet.Dispose()
        End Sub
    End Class

End Class
