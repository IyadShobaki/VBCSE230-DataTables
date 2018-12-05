Imports System.Data
Public Class dataLayer
    Public Function getDataTable() As DataTable
        Dim Contacts As New DataTable("People")
        Dim ContactID As New DataColumn("ContactID")
        ContactID.DataType = GetType(Integer)
        ContactID.Unique = True
        ContactID.AllowDBNull = False
        ContactID.Caption = "ContactID"
        Contacts.Columns.Add(ContactID)

        Contacts.PrimaryKey = New DataColumn() {ContactID}
        Contacts.Columns("ContactID").AutoIncrement = True
        Contacts.Columns("ContactID").AutoIncrementSeed = 10
        Contacts.Columns("ContactID").AutoIncrementStep = 1

        Dim username As New DataColumn("Username")
        username.MaxLength = 35
        username.AllowDBNull = True
        Contacts.Columns.Add(username)

        Dim age As New DataColumn("age", GetType(Integer))
        age.DefaultValue = 0
        Contacts.Columns.Add(age)
        Return Contacts

    End Function
    Public Sub AddData(ByVal username As String, ByVal age As Integer, ByRef dt As DataTable)
        Dim dr As DataRow = dt.NewRow()
        dr("Username") = username
        dr("Age") = age
        dt.Rows.Add(dr)
    End Sub
End Class
