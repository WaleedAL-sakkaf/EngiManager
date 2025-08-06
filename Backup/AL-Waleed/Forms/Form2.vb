Imports System.Data.OleDb
Public Class Form2
    Dim conect As New OleDbConnection
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged
        DataGridView1.Refresh()
        PhonesBindingSource.Filter = "الاسم LIKE '" & TextBox1.Text & "%'"
        PhonesBindingSource.Sort = "الاسم "
    End Sub


    Private Sub Form2_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Done' table. You can move, or remove it, as needed.
        Me.DoneTableAdapter.Fill(Me.DatabaseDataSet.Done)
        'TODO: This line of code loads data into the 'DatabaseDataSet.phones' table. You can move, or remove it, as needed.
        Me.PhonesTableAdapter.Fill(Me.DatabaseDataSet.phones)

        'TODO: This line of code loads data into the 'DatabaseDataSet.phones' table. You can move, or remove it, as needed.
        Me.PhonesTableAdapter.Fill(Me.DatabaseDataSet.phones)

        conect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + IO.Directory.GetCurrentDirectory + "\Database.accdb"


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Visible = False
        DialogResult = Me.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button4.Click
        PhonesBindingSource.Filter = "الاسم LIKE '" & TextBox1.Text & "%'"
        PhonesBindingSource.Sort = "الاسم "
        DataGridView1.Refresh()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        conect.Open()


        Try
            Dim cmdser As New OleDbCommand
            cmdser.Connection = conect
            cmdser.CommandText = "select * from phones where الاسم = '" + Form0.TextBox1.Text + "' "
            Dim rd As OleDbDataReader
            rd = cmdser.ExecuteReader
            If rd.Read Then


                Form0.TextBox1.Text = rd(0)
                Form0.TextBox2.Text = rd(1)
                Form0.ComboBox1.Text = rd(2)
                Form0.DateTimePicker1.Value = Now
                Form0.TextBox4.Text = rd(4)
                Form0.TextBox5.Text = rd(5)
                Form0.TextBox6.Text = rd(6)


            Else
                '   MsgBox("عذر لاتوجد بيانات لهذا الشخص")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try


        If Form0.TextBox1.Text = "" Then
            MsgBox("يرجى تحديد الجهاز")
        Else
            Try
                Dim cmdinsert As New OleDbCommand
                cmdinsert.Connection = conect
                cmdinsert.CommandText = "insert into Done values ('" + Form0.TextBox1.Text + "','" + Form0.TextBox2.Text + "','" + Form0.ComboBox1.Text + "','" + Form0.DateTimePicker1.Value + "','" + Form0.TextBox4.Text + "','" + Form0.TextBox5.Text + "','" + Form0.TextBox6.Text + "')"
                cmdinsert.ExecuteNonQuery()
                MsgBox(" تم الترحيل الى  الجاهزة ")


                Dim cmdselect1 As New OleDbCommand
                cmdselect1.Connection = conect
                cmdselect1.CommandText = "SELECT * FROM phones"
                Dim adapter1 As New OleDbDataAdapter(cmdselect1)
                Dim table1 As New DataTable()
                adapter1.Fill(table1)
                DataGridView1.DataSource = table1

                Dim cmdselect2 As New OleDbCommand
                cmdselect2.Connection = conect
                cmdselect2.CommandText = "SELECT * FROM Done"
                Dim adapter2 As New OleDbDataAdapter(cmdselect2)
                Dim table2 As New DataTable()
                adapter2.Fill(table2)
                DataGridView2.DataSource = table2

            Catch ex As Exception
                MsgBox(ex.Message.ToString)

            End Try
        End If

       
        Try
            Dim cmddelete As New OleDbCommand
            cmddelete.Connection = conect
            cmddelete.CommandText = "delete from phones where الاسم ='" + Form0.TextBox1.Text + "'"
            cmddelete.ExecuteNonQuery()
            ' MsgBox("تم النقل الى الاجهزة الجاهزة")

            Dim cmdselect1 As New OleDbCommand
            cmdselect1.Connection = conect
            cmdselect1.CommandText = "SELECT * FROM phones"
            Dim adapter1 As New OleDbDataAdapter(cmdselect1)
            Dim table1 As New DataTable()
            adapter1.Fill(table1)
            DataGridView1.DataSource = table1

            Dim cmdselect2 As New OleDbCommand
            cmdselect2.Connection = conect
            cmdselect2.CommandText = "SELECT * FROM Done"
            Dim adapter2 As New OleDbDataAdapter(cmdselect2)
            Dim table2 As New DataTable()
            adapter2.Fill(table2)
            DataGridView2.DataSource = table2


            Form0.TextBox1.Clear()
            Form0.TextBox2.Clear()
            Form0.ComboBox1.Text = ""
            Form0.DateTimePicker1.Value = Now
            Form0.TextBox4.Clear()
            Form0.TextBox5.Clear()
            Form0.TextBox6.Clear()




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

        Form0.TextBox1.Text = selectedRow.Cells(0).Value.ToString()
        Form0.TextBox2.Text = selectedRow.Cells(1).Value.ToString()
        Form0.ComboBox1.Text = selectedRow.Cells(2).Value.ToString()
        Form0.DateTimePicker1.Value = selectedRow.Cells(3).Value.ToString()
        Form0.TextBox4.Text = selectedRow.Cells(4).Value.ToString()
        Form0.TextBox5.Text = selectedRow.Cells(5).Value.ToString()
        Form0.TextBox6.Text = selectedRow.Cells(6).Value.ToString()

        MsgBox("تم تحديد الاسم انقر الاصلاح")
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
       


        conect.Open()


        Try
            Dim cmdser As New OleDbCommand
            cmdser.Connection = conect
            cmdser.CommandText = "select * from Done where الاسم = '" + Form0.TextBox1.Text + "' "
            Dim rd As OleDbDataReader
            rd = cmdser.ExecuteReader
            If rd.Read Then


                Form0.TextBox1.Text = rd(0)
                Form0.TextBox2.Text = rd(1)
                Form0.ComboBox1.Text = rd(2)
                Form0.DateTimePicker1.Value = Now
                Form0.TextBox4.Text = rd(4)
                Form0.TextBox5.Text = rd(5)
                Form0.TextBox6.Text = rd(6)


            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try



        If Form0.TextBox1.Text = "" Then
            MsgBox("يرجى تحديد الجهاز")
        Else
            Try
                Dim cmdinsert As New OleDbCommand
                cmdinsert.Connection = conect
                cmdinsert.CommandText = "insert into Delivered values ('" + Form0.TextBox1.Text + "','" + Form0.TextBox2.Text + "','" + Form0.ComboBox1.Text + "','" + Form0.DateTimePicker1.Value + "','" + Form0.TextBox4.Text + "','" + Form0.TextBox5.Text + "','" + Form0.TextBox6.Text + "')"
                cmdinsert.ExecuteNonQuery()
                MsgBox("   تم استلام الجهاز ")

                Dim cmddelete As New OleDbCommand
                cmddelete.Connection = conect
                cmddelete.CommandText = "delete from Done where الاسم ='" + Form0.TextBox1.Text + "'"
                cmddelete.ExecuteNonQuery()
                ' MsgBox("تم النقل الى الاجهزة الجاهزة")

                Dim cmdselect1 As New OleDbCommand
                cmdselect1.Connection = conect
                cmdselect1.CommandText = "SELECT * FROM Done"
                Dim adapter1 As New OleDbDataAdapter(cmdselect1)
                Dim table1 As New DataTable()
                adapter1.Fill(table1)
                DataGridView2.DataSource = table1

                Dim cmdselect2 As New OleDbCommand
                cmdselect2.Connection = conect
                cmdselect2.CommandText = "SELECT * FROM Delivered"
                Dim adapter2 As New OleDbDataAdapter(cmdselect2)
                Dim table2 As New DataTable()
                adapter2.Fill(table2)
                Trash.DataGridView1.DataSource = table2


                Form0.TextBox1.Clear()
                Form0.TextBox2.Clear()
                Form0.ComboBox1.Text = ""
                Form0.DateTimePicker1.Value = Now
                Form0.TextBox4.Clear()
                Form0.TextBox5.Clear()
                Form0.TextBox6.Clear()




            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try


        End If

        conect.Close()




    End Sub

    Private Sub DataGridView2_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        Dim index As Integer

        index = e.RowIndex

        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView2.Rows(index)

        Form0.TextBox1.Text = selectedRow.Cells(0).Value.ToString()
        Form0.TextBox2.Text = selectedRow.Cells(1).Value.ToString()
        Form0.ComboBox1.Text = selectedRow.Cells(2).Value.ToString()
        Form0.DateTimePicker1.Value = selectedRow.Cells(3).Value.ToString()
        Form0.TextBox4.Text = selectedRow.Cells(4).Value.ToString()
        Form0.TextBox5.Text = selectedRow.Cells(5).Value.ToString()
        Form0.TextBox6.Text = selectedRow.Cells(6).Value.ToString()

        MsgBox("تم تحديد الاسم انقر تم التسليم")
    End Sub
End Class