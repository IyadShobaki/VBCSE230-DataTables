Public Class Form1
    Dim dl As New dataLayer
    Dim dt As DataTable = dl.getDataTable()
    Dim ds As DataSet = New DataSet("MyDataset")
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        dl.AddData(txtUsername.Text, CType(txtAge.Text, Integer), dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ds.Tables.Add(dt)
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Dim dtCopy As DataTable = dt.Copy()
        dtCopy.Rows.Add(5, "Copied", 1)
        DataGridView2.DataSource = dtCopy
    End Sub

    Private Sub btnClone_Click(sender As Object, e As EventArgs) Handles btnClone.Click
        Dim dtClone As DataTable = dt.Clone()
        dtClone.Rows.Add(7, "Clone", 2)
        DataGridView3.DataSource = dtClone
    End Sub

    Private Sub btnXML_Click(sender As Object, e As EventArgs) Handles btnXML.Click
        ds.WriteXml("Data.xml")
    End Sub

    Private Sub btnSaveSchema_Click(sender As Object, e As EventArgs) Handles btnSaveSchema.Click
        ds.WriteXml("dataSchema.xml", XmlWriteMode.WriteSchema)
    End Sub
End Class
