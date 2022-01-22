Public Class Form1

   

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lbltime.Text = TimeOfDay()
        lbldate.Text = DateString

    End Sub

    Private Sub txtcd_TextChanged(sender As Object, e As EventArgs) Handles txtcuday.TextChanged

    End Sub

    Private Sub txtcd_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtcuday.Validating

        Dim cuday As Integer

        Try
            cuday = Integer.Parse(txtcuday.Text)

            If txtcuday.Text = String.Empty Then

                'Cancel the event
                e.Cancel = True
                txtcuday.SelectAll()
                txtcuday.Focus()
                ErrorProvider.SetError(txtcuday, "Day must not be blank")
            Else
                If cuday < 1 Or cuday > 31 Then

                    e.Cancel = True
                    txtcuday.SelectAll()
                    txtcuday.Focus()
                    ErrorProvider.SetError(txtcuday, "Day must be between 1 and 31")

                End If

            End If

        Catch ex As Exception
            e.Cancel = True
            txtcuday.SelectAll()
            txtcuday.Focus()
            ErrorProvider.SetError(txtcuday, "Day must be numeric")
        End Try

    End Sub

    Private Sub txtbd_TextChanged(sender As Object, e As EventArgs) Handles txtdob.TextChanged

        


    End Sub

    Private Sub txtdob_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtdob.Validating

        Dim dob As Integer

        Try
            dob = Integer.Parse(txtdob.Text)

            If txtdob.Text = String.Empty Then

                'Cancel the event
                e.Cancel = True
                txtdob.SelectAll()
                txtdob.Focus()
                ErrorProvider.SetError(txtdob, "Day must not be blank")

            Else

                If dob < 1 Or dob > 31 Then

                    e.Cancel = True
                    txtdob.SelectAll()
                    txtdob.Focus()
                    ErrorProvider.SetError(txtdob, "Day must be between 1 and 31")

                End If
            End If

        Catch ex As Exception
            e.Cancel = True
            txtdob.SelectAll()
            txtdob.Focus()
            ErrorProvider.SetError(txtdob, "Day must be numeric")
        End Try

    End Sub

    Private Sub txtbm_TextChanged(sender As Object, e As EventArgs) Handles txtmob.TextChanged

    End Sub

    Private Sub txtbm_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtmob.Validating

        Dim mob As Integer

        Try
            mob = Integer.Parse(txtmob.Text)

            If txtmob.Text = String.Empty Then

                'Cancel the event
                e.Cancel = True
                txtmob.SelectAll()
                txtmob.Focus()
                ErrorProvider.SetError(txtmob, "Month must not be blank")

            Else

                If mob < 1 Or mob > 12 Then

                    e.Cancel = True
                    txtmob.SelectAll()
                    txtmob.Focus()
                    ErrorProvider.SetError(txtmob, "Month must be between 1 and 12")

                End If
            End If

        Catch ex As Exception
            e.Cancel = True
            txtmob.SelectAll()
            txtmob.Focus()
            ErrorProvider.SetError(txtmob, "Month must be numeric")
        End Try

    End Sub

    Private Sub txtby_TextChanged(sender As Object, e As EventArgs) Handles txtyob.TextChanged

    End Sub

    Private Sub txtby_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtyob.Validating

        Dim yob As Integer

        Try
            yob = Integer.Parse(txtyob.Text)

            If txtyob.Text = String.Empty Then

                'Cancel the event
                e.Cancel = True
                txtyob.SelectAll()
                txtyob.Clear()
                txtyob.Focus()
                ErrorProvider.SetError(txtyob, "Year must not be blank")

            End If

        Catch ex As Exception
            e.Cancel = True
            txtyob.SelectAll()
            txtyob.Focus()
            ErrorProvider.SetError(txtyob, "Year must be numeric")
        End Try

    End Sub

    Private Sub txtcm_TextChanged(sender As Object, e As EventArgs) Handles txtcumonth.TextChanged

    End Sub

    Private Sub txtcm_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtcumonth.Validating

        Dim cumonth As Integer

        Try
            cumonth = Integer.Parse(txtcumonth.Text)

            If txtcumonth.Text = String.Empty Then

                'cancel the event
                e.Cancel = True
                txtcumonth.SelectAll()
                txtcumonth.Focus()
                ErrorProvider.SetError(txtcumonth, "Month must not be blank")

            Else

                If cumonth < 1 Or cumonth > 12 Then

                    e.Cancel = True
                    txtcumonth.SelectAll()
                    txtcumonth.Focus()
                    ErrorProvider.SetError(txtcumonth, "Month must be between 1 and 12")

                End If
            End If

        Catch ex As Exception
            e.Cancel = True
            txtcumonth.SelectAll()
            txtcumonth.Focus()
            ErrorProvider.SetError(txtcumonth, "Month must be numeric")
        End Try

    End Sub

    Private Sub txtcy_TextChanged(sender As Object, e As EventArgs) Handles txtcuyear.TextChanged

    End Sub

    Private Sub txtcy_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtcuyear.Validating

        Dim cuyear As Integer

        Try
            cuyear = Integer.Parse(txtcuyear.Text)

            If txtcuyear.Text = String.Empty Then

                'Cancel the event
                e.Cancel = True
                txtcuyear.SelectAll()
                txtcuyear.Focus()
                ErrorProvider.SetError(txtcuyear, "Year must not be blank")

            End If

        Catch ex As Exception
            e.Cancel = True
            txtcuyear.SelectAll()
            txtcuyear.Focus()
            ErrorProvider.SetError(txtcuyear, "Year must be numeric")
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        'to close the app

        Dim returndialogresult As System.Windows.Forms.DialogResult
        Dim title As String = "Sure to exit"
        Dim message As String = "Do you want to exit?"

        returndialogresult = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If returndialogresult = Windows.Forms.DialogResult.Yes Then

            Me.Close()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        txtcuday.Text = ""
        txtcumonth.Text = ""
        txtcuyear.Text = ""

        txtdob.Text = ""
        txtmob.Text = ""
        txtyob.Text = ""


        lbloutputdays.Text = ""
        lbloutputmonth.Text = ""
        lbloutputyear.Text = ""

        lblhours.Text = ""
        lblminutes.Text = ""
        lblseconds.Text = ""


    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        'Do not allow validation to cancel the form's closing.

        e.Cancel = False

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cuday, cumonth, cuyear As Integer
        Dim dob, mob, yob As Integer

        Dim years, months, days, weeks As Integer
        ' Dim hours, minutes, seconds As Integer


        Try
            cuday = Integer.Parse(txtcuday.Text)

            Try
                cumonth = Integer.Parse(txtcumonth.Text)

                Try
                    cuyear = Integer.Parse(txtcuyear.Text)

                    Try
                        dob = Integer.Parse(txtdob.Text)

                        Try
                            mob = Integer.Parse(txtmob.Text)

                            Try
                                yob = Integer.Parse(txtyob.Text)


                                If cuday < dob Then

                                    cuday = cuday + 30
                                    cumonth = cumonth - 1

                                End If

                                If cumonth < mob Then

                                    cumonth = cumonth + 12
                                    cuyear = cuyear - 1

                                End If

                                years = cuyear - yob
                                months = cumonth - mob
                                days = cuday - dob


                                lbloutputdays.Text = days
                                lbloutputmonth.Text = months
                                lbloutputyear.Text = years


                            Catch ex As Exception
                                MessageBox.Show("Check input")
                            End Try

                        Catch ex As Exception
                            MessageBox.Show("Check input")
                        End Try

                    Catch ex As Exception
                        MessageBox.Show("Check input")
                    End Try

                Catch ex As Exception
                    MessageBox.Show("Check input")
                End Try

            Catch ex As Exception
                MessageBox.Show("Check input")
            End Try

        Catch ex As Exception
            MessageBox.Show("Check input")
        End Try


      


        ' Val(txtyob.Text)


    End Sub
End Class
