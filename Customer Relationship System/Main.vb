Public Class Main

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomersDataSet1.Customer_Info' table. You can move, or remove it, as needed.
        Me.Customer_InfoTableAdapter.Fill(Me.CustomersDataSet1.Customer_Info)
        'TODO: This line of code loads data into the 'CustomersDataSet1.Customer_Info' table. You can move, or remove it, as needed.
        Me.Customer_InfoTableAdapter.Fill(Me.CustomersDataSet1.Customer_Info)

    End Sub
End Class