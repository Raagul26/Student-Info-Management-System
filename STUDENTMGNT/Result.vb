Imports MySql.Data.MySqlClient
Public Class form4
    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyConn As New MySqlConnection
        Dim COMMAND As MySqlCommand
        Dim READER As MySqlDataReader
        MyConn.ConnectionString = "server=localhost;user id=root;password=1234;database=studentdatabasemgnt"
        Try
            MyConn.Open()
            Dim Query As String
            Query = "select * from studentdatabasemgnt.result where regno='" & MaskedTextBox1.Text & "' and dob ='" & DateTimePicker1.Text & "'"
            COMMAND = New MySqlCommand(Query, MyConn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1

            End While
            If count = 1 Then
                final.Show() '    Query = "select regno,dob,marks from studentdatabasemgnt.result where regno='" & &'""
            ElseIf count > 1 Then
                MessageBox.Show("Duplicate")
            Else
                MessageBox.Show("Not Correct")

            End If
            MyConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.ToString)
        End Try
        ' query = "select * from studentdatabasemgnt.result where reg_no='" & MaskedTextBox1.Text & "','" & DateTimePicker1 & "'"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class