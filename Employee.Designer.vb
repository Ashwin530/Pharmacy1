<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Employee))
        Button6 = New Button()
        Button5 = New Button()
        DataGridView1 = New DataGridView()
        Button3 = New Button()
        Button4 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label1 = New Label()
        TextBox4 = New TextBox()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label8 = New Label()
        Label5 = New Label()
        TextBox5 = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Times New Roman", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.Location = New Point(148, 474)
        Button6.Name = "Button6"
        Button6.Size = New Size(94, 29)
        Button6.TabIndex = 54
        Button6.Text = "BACK"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Times New Roman", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.Location = New Point(20, 474)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 53
        Button5.Text = "SEARCH"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(270, 61)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(744, 462)
        DataGridView1.TabIndex = 52
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Times New Roman", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(148, 424)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 51
        Button3.Text = "DISPLAY"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Times New Roman", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(20, 424)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 50
        Button4.Text = "Delete"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Times New Roman", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(148, 370)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 49
        Button2.Text = "UPDATE"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Times New Roman", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(20, 370)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 48
        Button1.Text = "ADD"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(367, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(369, 38)
        Label1.TabIndex = 47
        Label1.Text = "EMPLOYEE DETAILS"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(117, 230)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(125, 27)
        TextBox4.TabIndex = 46
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(20, 237)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 17)
        Label4.TabIndex = 45
        Label4.Text = "PHONE "
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(117, 171)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 44
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(20, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 17)
        Label3.TabIndex = 43
        Label3.Text = "AGE"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(117, 117)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 42
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(20, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 17)
        Label2.TabIndex = 41
        Label2.Text = "NAME"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(117, 61)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 40
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(18, 61)
        Label8.Name = "Label8"
        Label8.Size = New Size(25, 17)
        Label8.TabIndex = 39
        Label8.Text = "ID"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(12, 302)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 17)
        Label5.TabIndex = 55
        Label5.Text = "PASSWORD"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(117, 295)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(125, 27)
        TextBox5.TabIndex = 56
        ' 
        ' Employee
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1045, 546)
        Controls.Add(TextBox5)
        Controls.Add(Label5)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(DataGridView1)
        Controls.Add(Button3)
        Controls.Add(Button4)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(TextBox4)
        Controls.Add(Label4)
        Controls.Add(TextBox3)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label8)
        Name = "Employee"
        Text = "Employee"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
End Class
