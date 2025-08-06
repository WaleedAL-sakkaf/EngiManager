

Imports System.Data.OleDb
Public Class parts
    Dim conect As New OleDbConnection

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click, Label6.Click, Label5.Click, Label4.Click, Label3.Click, Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim resulte As Integer
        resulte = (Val(TextBox4.Text) * Val(TextBox5.Text)).ToString()

        conect.Open()
        Try
            Dim cmdinsert As New OleDbCommand
            cmdinsert.Connection = conect
            cmdinsert.CommandText = "insert into parts values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + ComboBox1.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + resulte.ToString() + "')"
            cmdinsert.ExecuteNonQuery()
            '  MsgBox("تم الاضافه")

            Dim cmdselect As New OleDbCommand
            cmdselect.Connection = conect
            cmdselect.CommandText = "SELECT * FROM parts"
            Dim adapter As New OleDbDataAdapter(cmdselect)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table


            TextBox1.Clear()
            TextBox2.Clear()
            ComboBox1.Text = ""
            TextBox4.Clear()
            TextBox5.Clear()


        Catch ex As Exception
            MsgBox(ex.Message.ToString)

        End Try

        conect.Close()

    End Sub

    Private Sub parts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.parts' table. You can move, or remove it, as needed.
        Me.PartsTableAdapter.Fill(Me.DatabaseDataSet.parts)

        'TODO: This line of code loads data into the 'DatabaseDataSet.parts' table. You can move, or remove it, as needed.
        Me.PartsTableAdapter.Fill(Me.DatabaseDataSet.parts)


        conect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + IO.Directory.GetCurrentDirectory + "\Database.accdb"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        conect.Open()
        Try
            Dim cmdinsert As New OleDbCommand
            cmdinsert.Connection = conect
            cmdinsert.CommandText = "UPDATE parts SET [نوع الجهاز] = @DeviceType, [الكمية] = @Quantity, [السعر] = @Price WHERE [الاسم] = @Name"
            cmdinsert.Parameters.AddWithValue("@DeviceType", TextBox2.Text)
            cmdinsert.Parameters.AddWithValue("@Quantity", TextBox4.Text)
            cmdinsert.Parameters.AddWithValue("@Price", TextBox5.Text)
            cmdinsert.Parameters.AddWithValue("@Name", TextBox1.Text)
            cmdinsert.ExecuteNonQuery()
            MsgBox("تم التعديل")
        Catch ex As Exception
            MsgBox("حدث خطأ أثناء التعديل: " & ex.Message)
        Finally

            conect.Close()
        End Try
        Try
            Dim cmdselect As New OleDbCommand
            cmdselect.Connection = conect
            cmdselect.CommandText = "SELECT * FROM parts"
            Dim adapter As New OleDbDataAdapter(cmdselect)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table


            TextBox1.Clear()
            TextBox2.Clear()
            ComboBox1.Text = ""
            TextBox4.Clear()
            TextBox5.Clear()
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
            cmdselect.CommandText = "SELECT * FROM parts"
            Dim adapter As New OleDbDataAdapter(cmdselect)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table


            TextBox1.Clear()
            TextBox2.Clear()
            ComboBox1.Text = ""
            TextBox4.Clear()
            TextBox5.Clear()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        conect.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form4.CrystalReportViewer1.SelectionFormula = "{parts.الاسم} Like '" & TextBox6.Text & "*'"
        Form4.Show()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        Dim index As Integer

        index = e.RowIndex

        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)

        TextBox1.Text = selectedRow.Cells(0).Value.ToString()
        TextBox2.Text = selectedRow.Cells(1).Value.ToString()
        ComboBox1.Text = selectedRow.Cells(2).Value.ToString()
        TextBox4.Text = selectedRow.Cells(3).Value.ToString()
        TextBox5.Text = selectedRow.Cells(4).Value.ToString()

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        PartsBindingSource.Filter = "الاسم LIKE '" & TextBox6.Text & "%'"
        PartsBindingSource.Sort = "الاسم "
    End Sub

   
End Class