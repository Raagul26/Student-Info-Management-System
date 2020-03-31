Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyConn As New MySqlConnection
        Dim COMMAND As MySqlCommand
        Dim READER As MySqlDataReader
        MyConn.ConnectionString = "server=localhost;user id=root;password=1234;database=studentdatabasemgnt"
        Try
            MyConn.Open()
            Dim Query As String
            Query = "select * from studentdatabasemgnt.logininfo where userid='" & MaskedTextBox1.Text & "' and passwd ='" & MaskedTextBox2.Text & "'"
            COMMAND = New MySqlCommand(Query, MyConn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1

            End While
            If count = 1 Then
                Student_Reg.Show()
            ElseIf count > 1 Then
                MessageBox.Show("Duplicate")
            Else
                MessageBox.Show("Not Correct")

            End If
            MyConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox2.MaskInputRejected

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        form4.Show()
    End Sub
End Class
