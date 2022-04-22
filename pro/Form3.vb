Public Class Form3
    Dim myinputs As New List(Of String)
    Dim mypasses As New List(Of String)
    Dim username As String
    Dim password As String
    Dim frm1 As New Form1


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm1.Visible = True
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            myinputs.Add(TextBox1.Text)
            mypasses.Add(TextBox2.Text)
            TextBox1.Clear()
            TextBox2.Clear()
            frm1.Show()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        username = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        password = TextBox2.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frm1.Visible = True
        frm1.Show()
    End Sub
End Class