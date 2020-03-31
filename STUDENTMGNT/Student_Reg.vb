Imports MySql.Data.MySqlClient

Public Class Student_Reg
    Dim connection As New MySqlConnection("server=localhost;user id=root;password=1234;database=studentdatabasemgnt")

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox3_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim command As New MySqlCommand("INSERT INTO `stu_reg` (`fname`, `lname`, `gender`,`course`,`sslc`,`hsc`,`regno`,`frname`,`mrname`,`dob`,`mobile`,`address`) VALUES (@fn,@ln,@gen,@co,@ss,@hs,@rn,@frn,@mrn,@db,@mob,@add)", connection)
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = MaskedTextBox1.Text
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = MaskedTextBox2.Text
            command.Parameters.Add("@gen", MySqlDbType.VarChar).Value = ListBox1.Text
            command.Parameters.Add("@co", MySqlDbType.VarChar).Value = ListBox2.Text
            command.Parameters.Add("@ss", MySqlDbType.Int32).Value = MaskedTextBox4.Text
            command.Parameters.Add("@hs", MySqlDbType.Int32).Value = MaskedTextBox5.Text
            command.Parameters.Add("@rn", MySqlDbType.VarChar).Value = MaskedTextBox6.Text
            command.Parameters.Add("@frn", MySqlDbType.VarChar).Value = MaskedTextBox7.Text
            command.Parameters.Add("@mrn", MySqlDbType.VarChar).Value = MaskedTextBox8.Text
            command.Parameters.Add("@db", MySqlDbType.VarChar).Value = DateTimePicker1.Text
            command.Parameters.Add("@mob", MySqlDbType.VarChar).Value = MaskedTextBox9.Text
            command.Parameters.Add("@add", MySqlDbType.VarChar).Value = TextBox1.Text

            connection.Open()

            If command.ExecuteNonQuery() = 1 Then

                MessageBox.Show("Data Inserted")

            Else

                MessageBox.Show("ERROR")

            End If
            connection.Close()

    End Sub

    Private Function query() As String
        Throw New NotImplementedException()
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Student_Reg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

