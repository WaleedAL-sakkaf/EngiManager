Imports System.Data.OleDb
Public Class debt
    Dim conect As New OleDbConnection
    Private Sub debt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.debt' table. You can move, or remove it, as needed.
        Me.DebtTableAdapter.Fill(Me.DatabaseDataSet.debt)
        'TODO: This line of code loads data into the 'DatabaseDataSet.debt' table. You can move, or remove it, as needed.
        Me.DebtTableAdapter.Fill(Me.DatabaseDataSet.debt)
        'TODO: This line of code loads data into the 'DatabaseDataSet.debt' table. You can move, or remove it, as needed.
        Me.DebtTableAdapter.Fill(Me.DatabaseDataSet.debt)
        'TODO: This line of code loads data into the 'DatabaseDataSet.debt' table. You can move, or remove it, as needed.
        Me.DebtTableAdapter.Fill(Me.DatabaseDataSet.debt)
        'TODO: This line of code loads data into the 'DatabaseDataSet.debt' table. You can move, or remove it, as needed.
        Me.DebtTableAdapter.Fill(Me.DatabaseDataSet.debt)

        conect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + IO.Directory.GetCurrentDirectory + "\Database.accdb"

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        conect.Open()
        Try
            Dim cmdinsert As New OleDbCommand
            cmdinsert.Connection = conect
            cmdinsert.CommandText = "insert into debt values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + DateTimePicker1.Value + "')"
            cmdinsert.ExecuteNonQuery()
            'MsgBox("تم الاضافه")

            Dim cmdselect As New OleDbCommand
            cmdselect.Connection = conect
            cmdselect.CommandText = "SELECT * FROM debt"
            Dim adapter As New OleDbDataAdapter(cmdselect)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table


            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            DateTimePicker1.Value = Now
        Catch ex As Exception
            MsgBox(ex.Message.ToString)

        End Try

        conect.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        conect.Open()
        Try
            Dim cmdinsert As New OleDbCommand
            cmdinsert.Connection = conect
            cmdinsert.CommandText = "update parts set الاسم  = '" + TextBox1.Text + "'"
            cmdinsert.ExecuteNonQuery()
            MsgBox("تم التعديل")


            Dim cmdselect As New OleDbCommand
            cmdselect.Connection = conect
            cmdselect.CommandText = "SELECT * FROM debt"
            Dim adapter As New OleDbDataAdapter(cmdselect)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table


            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            DateTimePicker1.Value = Now
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        conect.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        conect.Open()
        Try
            Dim cmddelete As New OleDbCommand
            cmddelete.Connection = conect
            cmddelete.CommandText = "delete from parts where الاسم ='" + TextBox1.Text + "'"
            cmddelete.ExecuteNonQuery()
            MsgBox("تم الحذف")


            Dim cmdselect As New OleDbCommand
            cmdselect.Connection = conect
            cmdselect.CommandText = "SELECT * FROM debt"
            Dim adapter As New OleDbDataAdapter(cmdselect)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table


            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            DateTimePicker1.Value = Now

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        conect.Close()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick



        Dim index As Integer

        index = e.RowIndex

        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)

        TextBox1.Text = selectedRow.Cells(0).Value.ToString()
        TextBox2.Text = selectedRow.Cells(1).Value.ToString()
        TextBox3.Text = selectedRow.Cells(2).Value.ToString()
        DateTimePicker1.Value = selectedRow.Cells(3).Value.ToString()

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        DebtBindingSource.Filter = "الاسم LIKE '" & TextBox6.Text & "%'"
        DebtBindingSource.Sort = "الاسم "
    End Sub
End Class