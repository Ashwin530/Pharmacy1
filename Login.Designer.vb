<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Label6 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(186, 25)
        Label6.Name = "Label6"
        Label6.Size = New Size(278, 38)
        Label6.TabIndex = 10
        Label6.Text = "PHARMAVERSE"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(294, 127)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 17)
        Label1.TabIndex = 11
        Label1.Text = "USERNAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(294, 214)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 17)
        Label2.TabIndex = 12
        Label2.Text = "PASSWORD"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(443, 120)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(145, 27)
        TextBox1.TabIndex = 13
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(443, 214)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(145, 27)
        TextBox2.TabIndex = 14
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(443, 289)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 15
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.WhatsApp_Image_2023_05_01_at_5_26_09_PM__1_
        ClientSize = New Size(667, 396)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label6)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
End Class
