<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.btnClone = New System.Windows.Forms.Button()
        Me.btnXML = New System.Windows.Forms.Button()
        Me.btnSaveSchema = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(65, 106)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(144, 48)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(163, 8)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(237, 22)
        Me.txtUsername.TabIndex = 2
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(163, 59)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(237, 22)
        Me.txtAge.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Age"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 160)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(262, 278)
        Me.DataGridView1.TabIndex = 5
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(280, 160)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(262, 278)
        Me.DataGridView2.TabIndex = 7
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(329, 106)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(144, 48)
        Me.btnCopy.TabIndex = 6
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(548, 160)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(262, 278)
        Me.DataGridView3.TabIndex = 9
        '
        'btnClone
        '
        Me.btnClone.Location = New System.Drawing.Point(597, 106)
        Me.btnClone.Name = "btnClone"
        Me.btnClone.Size = New System.Drawing.Size(144, 48)
        Me.btnClone.TabIndex = 8
        Me.btnClone.Text = "Clone"
        Me.btnClone.UseVisualStyleBackColor = True
        '
        'btnXML
        '
        Me.btnXML.Location = New System.Drawing.Point(451, 13)
        Me.btnXML.Name = "btnXML"
        Me.btnXML.Size = New System.Drawing.Size(144, 48)
        Me.btnXML.TabIndex = 10
        Me.btnXML.Text = "Convert to XML"
        Me.btnXML.UseVisualStyleBackColor = True
        '
        'btnSaveSchema
        '
        Me.btnSaveSchema.Location = New System.Drawing.Point(633, 13)
        Me.btnSaveSchema.Name = "btnSaveSchema"
        Me.btnSaveSchema.Size = New System.Drawing.Size(144, 48)
        Me.btnSaveSchema.TabIndex = 11
        Me.btnSaveSchema.Text = "Save Schema"
        Me.btnSaveSchema.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 450)
        Me.Controls.Add(Me.btnSaveSchema)
        Me.Controls.Add(Me.btnXML)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.btnClone)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btnCopy As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents btnClone As Button
    Friend WithEvents btnXML As Button
    Friend WithEvents btnSaveSchema As Button
End Class
