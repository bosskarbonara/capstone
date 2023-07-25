Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim pass As String = txtpassword.Text

        If txtusername.Text = "abcd" And txtpassword.Text = "123" Then
            txtusername.Text = ""
            txtpassword.Text = ""

            MsgBox("You Log in ")
            home.Show()
            Me.Hide()




        Else
            MsgBox("wrong pass")
            txtusername.Text = ""
            txtpassword.Text = ""
        End If
    End Sub

    Private Sub change_Click(sender As Object, e As EventArgs) Handles change.Click
        admin.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label5.Text = Date.Now.ToString("dd-MM-yyyy hh:mm:ss")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        txtpassword.PasswordChar = "*"c
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        txtusername.Text = String.Empty
        txtpassword.Text = String.Empty
    End Sub
End Class
