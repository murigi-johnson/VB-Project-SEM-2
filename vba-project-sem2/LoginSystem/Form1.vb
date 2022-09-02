Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Please Input some values")
        Else
            My.Settings.username = TextBox3.Text
            My.Settings.password = TextBox4.Text
            My.Settings.Save()
            MsgBox("Successfully Registered")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.username AndAlso TextBox2.Text = My.Settings.password Then
            MsgBox("Access Granted")
        Else
            MsgBox("Access Denied")
        End If
    End Sub
End Class
