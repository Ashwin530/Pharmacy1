Imports System.Data.SqlClient

Public Class Billing
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashwi\OneDrive\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30")
    Dim dr As IDataReader


    Dim cmd As New SqlCommand

    Private Sub Billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Dim cmd As New SqlCommand("select * from Medicine", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        ComboBox1.DataSource = Tbl
        ComboBox1.DisplayMember = "Name"
        ComboBox1.ValueMember = "Name"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Admin.Show()
    End Sub

    Dim Quantity
    Private Sub FetchQty()
        If con.State = ConnectionState.Closed Then
            con.Open()

        End If

        Dim query = "select Quantity from Medicine where Name = '" & ComboBox1.SelectedValue.ToString() & "' "
        Dim cmd As New SqlCommand(query, con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            'MsgBox("" + reader(0).ToString())

            Price = reader(0)

            Label2.Text = "Quantity Available:" + reader(0).ToString()
        End While

        con.Close()

    End Sub

    Dim Price
    Private Sub Fetchprice()
        If con.State = ConnectionState.Closed Then
            con.Open()

        End If

        Dim query = "select Sprice from Medicine where Name = '" & ComboBox1.SelectedValue.ToString() & "' "
        Dim cmd As New SqlCommand(query, con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            'MsgBox("" + reader(0).ToString())

            Price = reader(0)

            Label3.Text = "Grand Total Price is:" + reader(0).ToString()
        End While

        con.Close()

    End Sub
    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted, ComboBox1.SelectedIndexChanged
        FetchQty()
        Fetchprice()
    End Sub
    Dim i = 0
    Dim Gtotal = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text < Quantity Then
            MsgBox("Not enough stock")
        ElseIf TextBox1.Text = "" Then
            MsgBox("Enter Quantity")
        Else
            Dim rnum As Integer = DataGridView1.Rows.Add()
            i += i + 1
            DataGridView1.Rows.Item(rnum).Cells("Column1").Value = i
            DataGridView1.Rows.Item(rnum).Cells("Column2").Value = ComboBox1.SelectedValue.ToString()
            DataGridView1.Rows.Item(rnum).Cells("Column3").Value = TextBox1.Text
            DataGridView1.Rows.Item(rnum).Cells("Column4").Value = TextBox2.Text
            DataGridView1.Rows.Item(rnum).Cells("Column5").Value = TextBox1.Text * TextBox2.Text
            Dim Subtot = TextBox1.Text * TextBox2.Text
            Gtotal += Subtot
            Label4.Text = Gtotal

        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PrintPreviewDialog1.Show()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("PharmaVerse", New Font("Arial", 22), Brushes.BlueViolet, 335, 35)
        e.Graphics.DrawString("*****Your Bill*****", New Font("Arial", 14), Brushes.BlueViolet, 350, 60)


        Dim bm As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bm, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(bm, 0, 90)
        e.Graphics.DrawString("Total Amount" + Label4.Text, New Font("Arial", 15), Brushes.Crimson, 325, 580)
        e.Graphics.DrawString("***************Thank You For Your Purchase***************", New Font("Arial", 20), Brushes.Crimson, 130, 600)
    End Sub
End Class
