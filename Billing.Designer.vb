<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Billing
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Billing))
        Label6 = New Label()
        Label1 = New Label()
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Button2 = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Button3 = New Button()
        TextBox2 = New TextBox()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        PrintDialog1 = New PrintDialog()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(379, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(306, 46)
        Label6.TabIndex = 11
        Label6.Text = "CHECKOUT FORM"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(47, 138)
        Label1.Name = "Label1"
        Label1.Size = New Size(163, 17)
        Label1.TabIndex = 12
        Label1.Text = "NAME OF MEDICINE"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(47, 267)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(174, 27)
        TextBox1.TabIndex = 13
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(47, 175)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(174, 28)
        ComboBox1.TabIndex = 14
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(47, 226)
        Label2.Name = "Label2"
        Label2.Size = New Size(180, 23)
        Label2.TabIndex = 15
        Label2.Text = "AVAIL_QUANTITY"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(85, 408)
        Button1.Name = "Button1"
        Button1.Size = New Size(117, 29)
        Button1.TabIndex = 16
        Button1.Text = "ADD TO BILL"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        DataGridView1.Location = New Point(270, 63)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(679, 454)
        DataGridView1.TabIndex = 17
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ID"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Name"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Quantity"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Sprice"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Total Price"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Width = 125
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(85, 461)
        Button2.Name = "Button2"
        Button2.Size = New Size(117, 29)
        Button2.TabIndex = 18
        Button2.Text = "BACK"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(47, 317)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 23)
        Label3.TabIndex = 19
        Label3.Text = "PRICE"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(270, 548)
        Label4.Name = "Label4"
        Label4.Size = New Size(199, 25)
        Label4.TabIndex = 20
        Label4.Text = "TOTAL AMOUNT"
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(601, 537)
        Button3.Name = "Button3"
        Button3.Size = New Size(128, 50)
        Button3.TabIndex = 21
        Button3.Text = "PRINT " & vbCrLf & "INVOICE"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(47, 352)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(174, 27)
        TextBox2.TabIndex = 22
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' Billing
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1000, 595)
        Controls.Add(TextBox2)
        Controls.Add(Button3)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Button2)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Label6)
        Name = "Billing"
        Text = "Billing"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
