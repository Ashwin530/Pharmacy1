Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "admin" And TextBox2.Text = "123" Then
            MessageBox.Show("Admin Verified")
            Me.Hide()
            Admin.Show()

        Else
            MessageBox.Show("Recheck User ID and Password.")

        End If
    End Sub
End Class