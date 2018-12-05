Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Grid1.DataSource = DsNorthwind1.Customers
        Grid1.MultiSelect = False
        Grid1.SelectionMode = DataGridViewSelectionMode.CellSelect
    End Sub

    Private Sub btnFillTable_Click(sender As Object, e As EventArgs) Handles btnFillTable.Click
        SqlDataAdapter1.Fill(DsNorthwind1.Customers)
    End Sub

    Private Sub btnAddRow_Click(sender As Object, e As EventArgs) Handles btnAddRow.Click
        Dim newrow As dsNorthwind.CustomersRow =
            CType(DsNorthwind1.Customers.NewRow, dsNorthwind.CustomersRow)
        With newrow
            .CustomerID = "WINGT"
            .CompanyName = "Wingtip Toys"
            .ContactName = "Steve Jones"
            .ContactTitle = "CEO"
            .Address = "1234 Main Street"
            .City = "Canton"
            ._Region = "NY"
            .PostalCode = "44711"
            .Country = "USA"
            .Phone = "330-455-5555"
            .Fax = "216-555-5555"
        End With
        Try
            DsNorthwind1.Customers.Rows.Add(newrow)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Add Row Faild")

        End Try
    End Sub
    Private Function getSelectedRow() As dsNorthwind.CustomersRow
        Dim selectedCustomerID As String =
            Grid1.CurrentRow.Cells("CustomerID").Value.ToString()
        Dim selectedrow As dsNorthwind.CustomersRow =
            DsNorthwind1.Customers.FindByCustomerID(selectedCustomerID)
        Return selectedrow
    End Function

    Private Sub btnDeleteRow_Click(sender As Object, e As EventArgs) Handles btnDeleteRow.Click
        getSelectedRow.Delete()

    End Sub
    Private Sub updateRowVersionDispaly()
        Try
            txtCurrent.Text = getSelectedRow.Item(Grid1.CurrentCell.OwningColumn.Name, DataRowVersion.Current).ToString()

        Catch ex As Exception
            txtCurrent.Text = ex.Message
        End Try
        Try
            txtOriginal.Text = getSelectedRow.Item(Grid1.CurrentCell.OwningColumn.Name, DataRowVersion.Original).ToString()

        Catch ex As Exception
            txtRowState.Text = getSelectedRow.RowState.ToString()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        getSelectedRow(Grid1.CurrentCell.OwningColumn.Name) = txtCellValue.Text
        updateRowVersionDispaly()
    End Sub

    Private Sub Grid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid1.CellClick
        txtCellValue.Text = Grid1.CurrentCell.Value.ToString()
        updateRowVersionDispaly()
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        getSelectedRow().AcceptChanges()
        updateRowVersionDispaly()
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        getSelectedRow().RejectChanges()
        updateRowVersionDispaly()
    End Sub
End Class
