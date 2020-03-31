Imports MySql.Data.MySqlClient

Public Class final
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub final_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As MySqlConnection
        Dim command As MySqlCommand


        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;user id=root;password=1234;database=studentdatabasemgnt"
        Dim dataset As New DataTable
        Dim bindinsrc As New BindingSource
        Dim dataadapt As New MySqlDataAdapter
        Try
            connection.Open()
            command = New MySqlCommand("select * from studentdatabasemgnt.result", connection)
            dataadapt.SelectCommand = command
            dataadapt.Fill(dataset)
            bindinsrc.DataSource = dataset
            DataGridView1.DataSource = bindinsrc
            dataadapt.Update(dataset)
            connection.Close()


        Catch ex As Exception



        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class