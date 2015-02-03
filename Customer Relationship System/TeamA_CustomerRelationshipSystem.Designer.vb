<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerRelationshipSystem
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
        Me.tbc_Info = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rb_No = New System.Windows.Forms.RadioButton()
        Me.rb_Yes = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_thirdContactDate = New System.Windows.Forms.TextBox()
        Me.txt_secondContactDate = New System.Windows.Forms.TextBox()
        Me.txt_firstContactDate = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_firstContactDate = New System.Windows.Forms.Label()
        Me.btn_Update = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_middleName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.txt_phoneNumber = New System.Windows.Forms.TextBox()
        Me.txt_lastName = New System.Windows.Forms.TextBox()
        Me.txt_firstName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_annualSales = New System.Windows.Forms.TextBox()
        Me.txt_monthlySales = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_NewContact = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txt_emailSearch = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_test = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentCustomerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstContactDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecondContactDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThirdContactDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersDataSet11BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersDataSet11 = New Customer_Relationship_System.CustomersDataSet1()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.CustomersDataSet1 = New Customer_Relationship_System.CustomersDataSet()
        Me.Customer_InfoTableAdapter = New Customer_Relationship_System.CustomersDataSet1TableAdapters.Customer_InfoTableAdapter()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.First_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Last_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Annual_Sales = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Monthly_Sales = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tbc_Info.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersDataSet11BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.CustomersDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbc_Info
        '
        Me.tbc_Info.Controls.Add(Me.TabPage1)
        Me.tbc_Info.Controls.Add(Me.TabPage2)
        Me.tbc_Info.Controls.Add(Me.TabPage3)
        Me.tbc_Info.Location = New System.Drawing.Point(12, 14)
        Me.tbc_Info.Name = "tbc_Info"
        Me.tbc_Info.SelectedIndex = 0
        Me.tbc_Info.Size = New System.Drawing.Size(1129, 484)
        Me.tbc_Info.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tbc_Info.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.btn_Update)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.btn_Back)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.btn_NewContact)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.lbl_test)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1121, 458)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rb_No)
        Me.GroupBox4.Controls.Add(Me.rb_Yes)
        Me.GroupBox4.Location = New System.Drawing.Point(80, 212)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(233, 51)
        Me.GroupBox4.TabIndex = 31
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Current Customer"
        '
        'rb_No
        '
        Me.rb_No.AutoSize = True
        Me.rb_No.Location = New System.Drawing.Point(114, 19)
        Me.rb_No.Name = "rb_No"
        Me.rb_No.Size = New System.Drawing.Size(39, 17)
        Me.rb_No.TabIndex = 2
        Me.rb_No.TabStop = True
        Me.rb_No.Text = "No"
        Me.rb_No.UseVisualStyleBackColor = True
        '
        'rb_Yes
        '
        Me.rb_Yes.AutoSize = True
        Me.rb_Yes.Location = New System.Drawing.Point(20, 19)
        Me.rb_Yes.Name = "rb_Yes"
        Me.rb_Yes.Size = New System.Drawing.Size(43, 17)
        Me.rb_Yes.TabIndex = 0
        Me.rb_Yes.TabStop = True
        Me.rb_Yes.Text = "Yes"
        Me.rb_Yes.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_thirdContactDate)
        Me.GroupBox3.Controls.Add(Me.txt_secondContactDate)
        Me.GroupBox3.Controls.Add(Me.txt_firstContactDate)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.lbl_firstContactDate)
        Me.GroupBox3.Location = New System.Drawing.Point(80, 278)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(233, 93)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contact Attempts"
        '
        'txt_thirdContactDate
        '
        Me.txt_thirdContactDate.Location = New System.Drawing.Point(114, 64)
        Me.txt_thirdContactDate.Name = "txt_thirdContactDate"
        Me.txt_thirdContactDate.Size = New System.Drawing.Size(100, 20)
        Me.txt_thirdContactDate.TabIndex = 18
        '
        'txt_secondContactDate
        '
        Me.txt_secondContactDate.Location = New System.Drawing.Point(114, 41)
        Me.txt_secondContactDate.Name = "txt_secondContactDate"
        Me.txt_secondContactDate.Size = New System.Drawing.Size(100, 20)
        Me.txt_secondContactDate.TabIndex = 17
        '
        'txt_firstContactDate
        '
        Me.txt_firstContactDate.Location = New System.Drawing.Point(114, 18)
        Me.txt_firstContactDate.Name = "txt_firstContactDate"
        Me.txt_firstContactDate.Size = New System.Drawing.Size(100, 20)
        Me.txt_firstContactDate.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Third:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Second:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "First:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(111, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(111, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 4
        '
        'lbl_firstContactDate
        '
        Me.lbl_firstContactDate.AutoSize = True
        Me.lbl_firstContactDate.Location = New System.Drawing.Point(111, 21)
        Me.lbl_firstContactDate.Name = "lbl_firstContactDate"
        Me.lbl_firstContactDate.Size = New System.Drawing.Size(0, 13)
        Me.lbl_firstContactDate.TabIndex = 3
        '
        'btn_Update
        '
        Me.btn_Update.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Update.Location = New System.Drawing.Point(251, 377)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(164, 41)
        Me.btn_Update.TabIndex = 29
        Me.btn_Update.Text = "Update Contact"
        Me.btn_Update.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_middleName)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txt_Email)
        Me.GroupBox1.Controls.Add(Me.txt_phoneNumber)
        Me.GroupBox1.Controls.Add(Me.txt_lastName)
        Me.GroupBox1.Controls.Add(Me.txt_firstName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblPhoneNumber)
        Me.GroupBox1.Controls.Add(Me.lblEmail)
        Me.GroupBox1.Location = New System.Drawing.Point(80, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(233, 185)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Information"
        '
        'txt_middleName
        '
        Me.txt_middleName.Location = New System.Drawing.Point(114, 97)
        Me.txt_middleName.Name = "txt_middleName"
        Me.txt_middleName.Size = New System.Drawing.Size(100, 20)
        Me.txt_middleName.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Middle Name"
        '
        'txt_Email
        '
        Me.txt_Email.Location = New System.Drawing.Point(114, 148)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(100, 20)
        Me.txt_Email.TabIndex = 20
        '
        'txt_phoneNumber
        '
        Me.txt_phoneNumber.Location = New System.Drawing.Point(114, 123)
        Me.txt_phoneNumber.Name = "txt_phoneNumber"
        Me.txt_phoneNumber.Size = New System.Drawing.Size(100, 20)
        Me.txt_phoneNumber.TabIndex = 19
        '
        'txt_lastName
        '
        Me.txt_lastName.Location = New System.Drawing.Point(114, 73)
        Me.txt_lastName.Name = "txt_lastName"
        Me.txt_lastName.Size = New System.Drawing.Size(100, 20)
        Me.txt_lastName.TabIndex = 18
        '
        'txt_firstName
        '
        Me.txt_firstName.Location = New System.Drawing.Point(114, 50)
        Me.txt_firstName.Name = "txt_firstName"
        Me.txt_firstName.Size = New System.Drawing.Size(100, 20)
        Me.txt_firstName.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Name:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(114, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "First Name:"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(17, 126)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(81, 13)
        Me.lblPhoneNumber.TabIndex = 2
        Me.lblPhoneNumber.Text = "Phone Number:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(17, 151)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email:"
        '
        'btn_Back
        '
        Me.btn_Back.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Back.Location = New System.Drawing.Point(421, 377)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(164, 41)
        Me.btn_Back.TabIndex = 28
        Me.btn_Back.Text = "Exit"
        Me.btn_Back.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_annualSales)
        Me.GroupBox2.Controls.Add(Me.txt_monthlySales)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(319, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(266, 100)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Recent Sales"
        '
        'txt_annualSales
        '
        Me.txt_annualSales.Location = New System.Drawing.Point(113, 24)
        Me.txt_annualSales.Name = "txt_annualSales"
        Me.txt_annualSales.Size = New System.Drawing.Size(100, 20)
        Me.txt_annualSales.TabIndex = 3
        '
        'txt_monthlySales
        '
        Me.txt_monthlySales.Location = New System.Drawing.Point(113, 50)
        Me.txt_monthlySales.Name = "txt_monthlySales"
        Me.txt_monthlySales.Size = New System.Drawing.Size(100, 20)
        Me.txt_monthlySales.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Montly Sales Avg:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Annual Sales:"
        '
        'btn_NewContact
        '
        Me.btn_NewContact.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NewContact.Location = New System.Drawing.Point(76, 377)
        Me.btn_NewContact.Name = "btn_NewContact"
        Me.btn_NewContact.Size = New System.Drawing.Size(164, 41)
        Me.btn_NewContact.TabIndex = 32
        Me.btn_NewContact.Text = "Add Contact"
        Me.btn_NewContact.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txt_emailSearch)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Location = New System.Drawing.Point(319, 127)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(266, 136)
        Me.GroupBox5.TabIndex = 34
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Search"
        '
        'txt_emailSearch
        '
        Me.txt_emailSearch.Location = New System.Drawing.Point(113, 42)
        Me.txt_emailSearch.Name = "txt_emailSearch"
        Me.txt_emailSearch.Size = New System.Drawing.Size(100, 20)
        Me.txt_emailSearch.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(49, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 41)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 45)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Email:"
        '
        'lbl_test
        '
        Me.lbl_test.AutoSize = True
        Me.lbl_test.Location = New System.Drawing.Point(334, 147)
        Me.lbl_test.Name = "lbl_test"
        Me.lbl_test.Size = New System.Drawing.Size(0, 13)
        Me.lbl_test.TabIndex = 33
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1121, 458)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Contact"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.MiddleNameDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.CurrentCustomerDataGridViewTextBoxColumn, Me.FirstContactDateDataGridViewTextBoxColumn, Me.SecondContactDateDataGridViewTextBoxColumn, Me.ThirdContactDateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomerInfoBindingSource
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1109, 464)
        Me.DataGridView1.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "firstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "lastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'MiddleNameDataGridViewTextBoxColumn
        '
        Me.MiddleNameDataGridViewTextBoxColumn.DataPropertyName = "middleName"
        Me.MiddleNameDataGridViewTextBoxColumn.HeaderText = "middleName"
        Me.MiddleNameDataGridViewTextBoxColumn.Name = "MiddleNameDataGridViewTextBoxColumn"
        '
        'PhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "phoneNumber"
        Me.PhoneNumberDataGridViewTextBoxColumn.HeaderText = "phoneNumber"
        Me.PhoneNumberDataGridViewTextBoxColumn.Name = "PhoneNumberDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'CurrentCustomerDataGridViewTextBoxColumn
        '
        Me.CurrentCustomerDataGridViewTextBoxColumn.DataPropertyName = "currentCustomer"
        Me.CurrentCustomerDataGridViewTextBoxColumn.HeaderText = "currentCustomer"
        Me.CurrentCustomerDataGridViewTextBoxColumn.Name = "CurrentCustomerDataGridViewTextBoxColumn"
        '
        'FirstContactDateDataGridViewTextBoxColumn
        '
        Me.FirstContactDateDataGridViewTextBoxColumn.DataPropertyName = "firstContactDate"
        Me.FirstContactDateDataGridViewTextBoxColumn.HeaderText = "firstContactDate"
        Me.FirstContactDateDataGridViewTextBoxColumn.Name = "FirstContactDateDataGridViewTextBoxColumn"
        '
        'SecondContactDateDataGridViewTextBoxColumn
        '
        Me.SecondContactDateDataGridViewTextBoxColumn.DataPropertyName = "secondContactDate"
        Me.SecondContactDateDataGridViewTextBoxColumn.HeaderText = "secondContactDate"
        Me.SecondContactDateDataGridViewTextBoxColumn.Name = "SecondContactDateDataGridViewTextBoxColumn"
        '
        'ThirdContactDateDataGridViewTextBoxColumn
        '
        Me.ThirdContactDateDataGridViewTextBoxColumn.DataPropertyName = "thirdContactDate"
        Me.ThirdContactDateDataGridViewTextBoxColumn.HeaderText = "thirdContactDate"
        Me.ThirdContactDateDataGridViewTextBoxColumn.Name = "ThirdContactDateDataGridViewTextBoxColumn"
        '
        'CustomerInfoBindingSource
        '
        Me.CustomerInfoBindingSource.DataMember = "Customer_Info"
        Me.CustomerInfoBindingSource.DataSource = Me.CustomersDataSet11BindingSource
        '
        'CustomersDataSet11BindingSource
        '
        Me.CustomersDataSet11BindingSource.DataSource = Me.CustomersDataSet11
        Me.CustomersDataSet11BindingSource.Position = 0
        '
        'CustomersDataSet11
        '
        Me.CustomersDataSet11.DataSetName = "CustomersDataSet1"
        Me.CustomersDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ListView1)
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1121, 458)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Query"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 65)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(199, 17)
        Me.RadioButton3.TabIndex = 3
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Customers Recieving 5% Disconnect"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(205, 17)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Customers Recieving 15% Disconnect"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(205, 17)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Customers Recieving 25% Disconnect"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'CustomersDataSet1
        '
        Me.CustomersDataSet1.DataSetName = "CustomersDataSet"
        Me.CustomersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Customer_InfoTableAdapter
        '
        Me.Customer_InfoTableAdapter.ClearBeforeFill = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.RadioButton3)
        Me.GroupBox6.Controls.Add(Me.RadioButton1)
        Me.GroupBox6.Controls.Add(Me.RadioButton2)
        Me.GroupBox6.Location = New System.Drawing.Point(3, 116)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(218, 94)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Discount"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.First_Name, Me.Last_Name, Me.Annual_Sales, Me.Monthly_Sales})
        Me.ListView1.Location = New System.Drawing.Point(227, 3)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(765, 402)
        Me.ListView1.TabIndex = 5
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'First_Name
        '
        Me.First_Name.Text = "First Name"
        '
        'Last_Name
        '
        Me.Last_Name.Text = "Last Name"
        '
        'Annual_Sales
        '
        Me.Annual_Sales.Text = "Annual Sales"
        '
        'Monthly_Sales
        '
        Me.Monthly_Sales.Text = "Monthly Sales"
        '
        'CustomerRelationshipSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 526)
        Me.Controls.Add(Me.tbc_Info)
        Me.Name = "CustomerRelationshipSystem"
        Me.Text = "a"
        Me.tbc_Info.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersDataSet11BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.CustomersDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbc_Info As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_No As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Yes As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_thirdContactDate As System.Windows.Forms.TextBox
    Friend WithEvents txt_secondContactDate As System.Windows.Forms.TextBox
    Friend WithEvents txt_firstContactDate As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_firstContactDate As System.Windows.Forms.Label
    Friend WithEvents btn_Update As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_middleName As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_Email As System.Windows.Forms.TextBox
    Friend WithEvents txt_phoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents txt_lastName As System.Windows.Forms.TextBox
    Friend WithEvents txt_firstName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_annualSales As System.Windows.Forms.TextBox
    Friend WithEvents txt_monthlySales As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_NewContact As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_emailSearch As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbl_test As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents CustomersDataSet1 As Customer_Relationship_System.CustomersDataSet
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CustomersDataSet11BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersDataSet11 As Customer_Relationship_System.CustomersDataSet1
    Friend WithEvents CustomerInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Customer_InfoTableAdapter As Customer_Relationship_System.CustomersDataSet1TableAdapters.Customer_InfoTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MiddleNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrentCustomerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstContactDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SecondContactDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ThirdContactDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents First_Name As System.Windows.Forms.ColumnHeader
    Friend WithEvents Last_Name As System.Windows.Forms.ColumnHeader
    Friend WithEvents Annual_Sales As System.Windows.Forms.ColumnHeader
    Friend WithEvents Monthly_Sales As System.Windows.Forms.ColumnHeader

End Class
