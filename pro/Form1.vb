Public Class Form1
    Dim Username As String
    Dim password As Char


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Username = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        password = TextBox2.Text

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "ace" And TextBox2.Text = "1234" Then
            Form2.Show()
        Else
            MsgBox("sorry, username incorrect", MsgBoxStyle.OkOnly, "invalid input")
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
