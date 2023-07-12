<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label2 = New Label()
        TextBox3 = New TextBox()
        Label3 = New Label()
        TextBox4 = New TextBox()
        Label4 = New Label()
        TextBox5 = New TextBox()
        Label5 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        DataGridView1 = New DataGridView()
        Label6 = New Label()
        Button5 = New Button()
        TextBox6 = New TextBox()
        Label7 = New Label()
        Button6 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(24, 127)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 17)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(123, 127)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(123, 176)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(26, 183)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 17)
        Label2.TabIndex = 2
        Label2.Text = "Bprice"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(123, 237)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(26, 244)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 17)
        Label3.TabIndex = 4
        Label3.Text = "Sprice"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(123, 296)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(125, 27)
        TextBox4.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(26, 303)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 17)
        Label4.TabIndex = 6
        Label4.Text = "Quantity"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(123, 362)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(125, 27)
        TextBox5.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(26, 369)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 17)
        Label5.TabIndex = 8
        Label5.Text = "ExpiryDate"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(26, 409)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 10
        Button1.Text = "ADD"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(154, 409)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 11
        Button2.Text = "UPDATE"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(154, 467)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 13
        Button3.Text = "DISPLAY"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(26, 463)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 12
        Button4.Text = "Delete"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(276, 71)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(744, 462)
        DataGridView1.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(369, 20)
        Label6.Name = "Label6"
        Label6.Size = New Size(309, 38)
        Label6.TabIndex = 8
        Label6.Text = "MEDICINE FORM"
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.Location = New Point(26, 513)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 15
        Button5.Text = "SEARCH"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(123, 69)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(125, 27)
        TextBox6.TabIndex = 17
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(26, 76)
        Label7.Name = "Label7"
        Label7.Size = New Size(22, 17)
        Label7.TabIndex = 16
        Label7.Text = "Id"
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.Location = New Point(154, 513)
        Button6.Name = "Button6"
        Button6.Size = New Size(94, 29)
        Button6.TabIndex = 18
        Button6.Text = "BACK"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1037, 557)
        Controls.Add(Button6)
        Controls.Add(TextBox6)
        Controls.Add(Label7)
        Controls.Add(Button5)
        Controls.Add(DataGridView1)
        Controls.Add(Button3)
        Controls.Add(Button4)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox5)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(TextBox4)
        Controls.Add(Label4)
        Controls.Add(TextBox3)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button6 As Button
End Class
