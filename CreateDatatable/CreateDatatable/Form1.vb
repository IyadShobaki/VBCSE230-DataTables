Imports System.Data
Public Class Form1
    Dim Contacts As New DataTable("People")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ContactID As New DataColumn("ContactID")
        ContactID.DataType = GetType(Integer)
        ContactID.Unique = True
        ContactID.AllowDBNull = False
        ContactID.Caption = "ContactID"
        Contacts.Columns.Add(ContactID)

        Dim username As New DataColumn("Username")
        username.MaxLength = 35
        username.AllowDBNull = True
        Contacts.Columns.Add(username)

        Dim age As New DataColumn("age", GetType(Integer))
        age.DefaultValue = 0
        Contacts.Columns.Add(age)
        Contacts.PrimaryKey = New DataColumn() {ContactID}

        Dim dr As DataRow = Contacts.NewRow()
        dr("ContactID") = 1234567
        dr("Username") = "Steve"
        dr("age") = 33
        Contacts.Rows.Add(dr)

        Contacts.Rows.Add(1234568, "Joe", 44)

        Contacts.LoadDataRow(New Object() {12345679, "Jerry", 25}, LoadOption.OverwriteChanges)


        DataGridView1.DataSource = Contacts
    End Sub
End Class
