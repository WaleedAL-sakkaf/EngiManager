
Imports System.Data.OleDb

Public Class Form0
    Dim conect As New OleDbConnection



    Private Sub Form0_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        'TODO: This line of code loads data into the 'DatabaseDataSet.parts' table. You can move, or remove it, as needed.
        Me.PartsTableAdapter.Fill(Me.DatabaseDataSet.parts)
        'TODO: This line of code loads data into the 'DatabaseDataSet.daliy' table. You can move, or remove it, as needed.
        Me.DaliyTableAdapter.Fill(Me.DatabaseDataSet.daliy)




        conect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + IO.Directory.GetCurrentDirectory + "\Database.accdb"

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        



        conect.Open()
        Try
            Dim cmdinsert As New OleDbCommand
            cmdinsert.Connection = conect
            cmdinsert.CommandText = "insert into phones values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + ComboBox1.Text + "','" + DateTimePicker1.Value + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "')"
            cmdinsert.ExecuteNonQuery()
            MsgBox("تم اضضافه الجهاز")

            Dim cmdselect As New OleDbCommand
            cmdselect.Connection = conect
            cmdselect.CommandText = "SELECT * FROM phones"
            Dim adapter As New OleDbDataAdapter(cmdselect)
            Dim table As New DataTable()
            adapter.Fill(table)
            Form2.DataGridView1.DataSource = table
            Form2.DataGridView1.Refresh()

            TextBox1.Clear()
            TextBox2.Clear()
            ComboBox1.Text = ""
            DateTimePicker1.Value = Now
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)

        End Try

        conect.Close()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim result As Integer
        result = (Val(TextBox9.Text) * Val(TextBox3.Text)).ToString() / 100

       

        conect.Open()


        Dim cmdupdate As New OleDbCommand()
        cmdupdate.Connection = conect
        cmdupdate.CommandText = "UPDATE parts SET الكمية = الكمية - 1 WHERE الاسم = '" + ComboBox2.Text + "'"
        cmdupdate.ExecuteNonQuery()


        Dim cmdselectt As New OleDbCommand
        cmdselectt.Connection = conect
        cmdselectt.CommandText = "SELECT * FROM parts"
        Dim adapter2 As New OleDbDataAdapter(cmdselectt)
        Dim table2 As New DataTable()
        adapter2.Fill(table2)
        parts.DataGridView1.DataSource = table2
        parts.DataGridView1.Refresh()


        Try
            Dim cmdinsert As New OleDbCommand
            cmdinsert.Connection = conect
            cmdinsert.CommandText = "INSERT INTO daliy VALUES ('" + TextBox7.Text + "','" + TextBox9.Text + "','" + ComboBox2.Text + "','" + TextBox10.Text + "','" + result.ToString() + "')"
            cmdinsert.ExecuteNonQuery()
            MsgBox("تم اضافة الجهاز")

            Dim cmdselect As New OleDbCommand
            cmdselectt.Connection = conect
            cmdselectt.CommandText = "SELECT * FROM daliy"
            Dim adapter As New OleDbDataAdapter(cmdselectt)
            Dim table As New DataTable()
            adapter2.Fill(table)
            DataGridView1.DataSource = table

            TextBox7.Clear()
            ComboBox2.Text = ""
            TextBox9.Clear()
            TextBox10.Clear()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            conect.Close()
        End Try


    End Sub

    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cphones.Show()
    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click







        conect.Open()
        Try
            Dim cmddelete As New OleDbCommand
            cmddelete.Connection = conect
            cmddelete.CommandText = "delete from phones where الاسم ='" + TextBox1.Text + "'"
            cmddelete.ExecuteNonQuery()
            MsgBox("تم الحذف")

            Dim cmdselect As New OleDbCommand
            cmdselect.Connection = conect
            cmdselect.CommandText = "SELECT * FROM phones"
            Dim adapter As New OleDbDataAdapter(cmdselect)
            Dim table As New DataTable()
            adapter.Fill(table)
            Form2.DataGridView1.DataSource = table


            TextBox1.Clear()
            TextBox2.Clear()
            ComboBox1.Text = ""
            DateTimePicker1.Value = Now
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        conect.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        Dim resultt As Integer
        resultt = (Val(TextBox9.Text) * Val(TextBox3.Text)).ToString() / 100

        Label1.Text = "قيمة الربح بالنسبة هي:" & resultt.ToString()



    End Sub


    Private Sub ComboBox2_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim cmdselect As New OleDbCommand
        cmdselect.Connection = conect
        cmdselect.CommandText = "SELECT السعر FROM parts WHERE الاسم = @الاسم"
        cmdselect.Parameters.AddWithValue("@الاسم", ComboBox2.Text)
        conect.Open()
        Dim price As Object = cmdselect.ExecuteScalar()
        If price IsNot Nothing AndAlso IsNumeric(price) Then
            TextBox10.Text = price.ToString()
        Else
            TextBox10.Text = ""
        End If
        conect.Close()
    End Sub
End Class
