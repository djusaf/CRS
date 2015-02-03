Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.IO

Public Class CustomerRelationshipSystem

    Private connstring As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=" & My.Computer.FileSystem.CurrentDirectory & "\Customers.mdf;Integrated Security=True;Connect Timeout=30"

    Dim id As New List(Of String)
    Dim fnames As New List(Of String)
    Dim mnames As New List(Of String)
    Dim lnames As New List(Of String)
    Dim pnumber As New List(Of String)
    Dim email As New List(Of String)
    Dim currentCustomer As New List(Of String)

    Dim firstContactDate As New List(Of String)
    Dim secondContactDate As New List(Of String)
    Dim thirdContactDate As New List(Of String)

    Dim asales As New List(Of String)
    Dim msales As New List(Of String)

    Public customer(99) As Customer
    Dim curValue As Integer
    Dim count As Integer


    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomersDataSet11.Customer_Info' table. You can move, or remove it, as needed.
        Me.Customer_InfoTableAdapter.Fill(Me.CustomersDataSet11.Customer_Info)
        'TODO: This line of code loads data into the 'CustomersDataSet11.Customer_Info' table. You can move, or remove it, as needed.
        Me.Customer_InfoTableAdapter.Fill(Me.CustomersDataSet11.Customer_Info)
        Dim conn As New SqlConnection(connstring)
        Dim cmd As New SqlCommand("SELECT * FROM Customer_Info", conn)
        '******Retreives First Name only from the database to populate the combobox
        Try
            conn.Open()
            Dim rd As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While rd.Read()
                id.Add(rd("Id").ToString)
                fnames.Add(rd("firstName").ToString)
                mnames.Add(rd("middleName").ToString)
                lnames.Add(rd("lastName").ToString)
                pnumber.Add(rd("phoneNumber").ToString)
                email.Add(rd("email").ToString)
                currentCustomer.Add(rd("currentCustomer").ToString)

                firstContactDate.Add(rd("firstContactDate").ToString)

            End While
            rd.Close()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(e.ToString)
        End Try

        mtxt_phoneNumber.Mask = "(000) 000-0000"

    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btn_NewContact_Click(sender As Object, e As EventArgs) Handles btn_NewContact.Click

        '***************************DATABASE CONNECTION INFORMATION******************************
        Dim conn As New SqlConnection(connstring)
        Dim cmd As New SqlCommand("", conn)

        conn.Open()

        cmd.CommandText = "INSERT INTO Customer_Info values(@firstName, @middleName, @lastName, @phoneNumber, @email, @currentCustomer, @firstContact, @secondContact, @thirdContact)"

        cmd.Parameters.Add(New SqlParameter("@firstName", SqlDbType.VarChar, 50))
        cmd.Parameters("@firstName").Value = txt_firstName.Text
        id.Add(curValue + 1)
        fnames.Add(txt_firstName.Text)

        cmd.Parameters.Add(New SqlParameter("@middleName", SqlDbType.VarChar, 50))
        cmd.Parameters("@middleName").Value = txt_middleName.Text
        mnames.Add(txt_middleName.Text)


        cmd.Parameters.Add(New SqlParameter("@lastName", SqlDbType.VarChar, 50))
        cmd.Parameters("@lastName").Value = txt_lastName.Text
        lnames.Add(txt_lastName.Text)


        cmd.Parameters.Add(New SqlParameter("@phoneNumber", SqlDbType.VarChar, 50))
        cmd.Parameters("@phoneNumber").Value = mtxt_phoneNumber.Text
        pnumber.Add(mtxt_phoneNumber.Text)


        cmd.Parameters.Add(New SqlParameter("@email", SqlDbType.VarChar, 50))
        cmd.Parameters("@email").Value = txt_Email.Text
        email.Add(txt_Email.Text)

        cmd.Parameters.Add(New SqlParameter("@currentCustomer", SqlDbType.NChar, 10))
        If rb_Yes.Checked = True Then
            cmd.Parameters("@currentCustomer").Value = ("Yes")
            currentCustomer.Add("Yes")
        End If
        If rb_No.Checked = True Then
            cmd.Parameters("@currentCustomer").Value = ("No")
            currentCustomer.Add("No")
        End If

        cmd.Parameters.Add(New SqlParameter("@firstContact", SqlDbType.Char, 10))
        cmd.Parameters("@firstContact").Value = txt_firstContactDate.Text
        firstContactDate.Add(txt_firstContactDate.Text)

        cmd.Parameters.Add(New SqlParameter("@secondContact", SqlDbType.Char, 10))
        cmd.Parameters("@secondContact").Value = ""
        firstContactDate.Add("")

        cmd.Parameters.Add(New SqlParameter("@thirdContact", SqlDbType.Char, 10))
        cmd.Parameters("@thirdContact").Value = ""
        firstContactDate.Add("")


        '**************************END DATABASE INFORMATION**********************************************

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Successful Database Insert")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try

        clearFields()


    End Sub

    Private Sub clearFields()
        txt_firstName.Text = ""
        txt_middleName.Text = ""
        txt_lastName.Text = ""
        mtxt_phoneNumber.Text = ""
        txt_Email.Text = ""
    End Sub

    Private Sub txt_firstName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_firstName.KeyPress
        'TODO add code to verify that only alphabetical characters are entered
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
            MessageBox.Show("You can only enter letters.")
        End If
    End Sub

    Private Sub txt_middleName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_middleName.KeyPress
        'TODO add code to verify that only alphabetical characters are entered
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
            MessageBox.Show("You can only enter letters.")
        End If
    End Sub

    Private Sub txt_lastName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_lastName.KeyPress
        'TODO add code to verify that only alphabetical characters are entered
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
            MessageBox.Show("You can only enter letters.")
        End If
    End Sub

    Private Sub txt_email_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim sign As String = "@"
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
                If Asc(e.KeyChar) <> 46 And Asc(e.KeyChar) <> 95 Then
                    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                        If sign.IndexOf(e.KeyChar) = -1 Then
                            e.Handled = True

                        Else

                            If txt_Email.Text.Contains("@") And e.KeyChar = "@" Then
                                e.Handled = True
                            End If

                        End If
                    End If
                End If
            End If

        End If
    End Sub

    Private Sub txt_phoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub txt_email_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        Dim pattern As String = "^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$"


        Dim match As System.Text.RegularExpressions.Match = Regex.Match(txt_Email.Text.Trim(), pattern, RegexOptions.IgnoreCase)
        If (match.Success) Then

        Else
            MessageBox.Show("Please enter a valid email id", "Checking")
            txt_Email.Clear()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs)
        Dim combobox As ComboBox = CType(sender, ComboBox)


        If combobox.SelectedItem IsNot Nothing Then
            curValue = CType(combobox.SelectedIndex, String)

            txt_firstName.Text = pnumber(curValue)
            txt_lastName.Text = email(curValue)
            txt_Email.Text = fnames(curValue)
            mtxt_phoneNumber.Text = lnames(curValue)
            txt_annualSales.Text = FormatCurrency(asales(curValue))
            txt_monthlySales.Text = FormatCurrency(msales(curValue))
            If (String.CompareOrdinal(currentCustomer(curValue), "YES")) Then
                rb_Yes.Checked = True
            Else
                rb_No.Checked = True
            End If

            If (String.IsNullOrEmpty(firstContactDate(curValue))) Then
                txt_firstContactDate.Text = ""
                txt_firstContactDate.ReadOnly = False
            Else
                txt_firstContactDate.Text = firstContactDate(curValue)
                txt_firstContactDate.ReadOnly = True
            End If

        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)
        CustomerInfoBindingSource.Filter = DataGridViewColumnSortMode.Automatic
    End Sub

    Private Sub btn_Update_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class
