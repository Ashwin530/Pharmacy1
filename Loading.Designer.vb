<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loading
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Loading))
        Label6 = New Label()
        ProgressBar1 = New ProgressBar()
        Label1 = New Label()
        Timer1 = New Timer(components)
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(194, 28)
        Label6.Name = "Label6"
        Label6.Size = New Size(288, 38)
        Label6.TabIndex = 9
        Label6.Text = "PHARMA VERSE"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(42, 272)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(601, 57)
        ProgressBar1.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(204, 332)
        Label1.Name = "Label1"
        Label1.Size = New Size(278, 38)
        Label1.TabIndex = 11
        Label1.Text = "INITIALIZING..."
        ' 
        ' Timer1
        ' 
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.clinic_xxl
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(232, 69)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(203, 197)
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Loading
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(690, 388)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(ProgressBar1)
        Controls.Add(Label6)
        FormBorderStyle = FormBorderStyle.None
        Name = "Loading"
        Text = "Loading"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
