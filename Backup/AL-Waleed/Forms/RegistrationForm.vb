Imports System.Data.OleDb

Public Class RegistrationForm
    Dim conect As New OleDbConnection

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub



    Private Sub Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

   

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then

            MsgBox(" يرجى ادخال الاسم وكلمة السر")


        Else
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + IO.Directory.GetCurrentDirectory + "\Database.accdb"
            Dim query As String = "INSERT INTO Users ([Username], [Password], [UserRoleID]) VALUES (@Username, @Password, @UserRoleID);"
            Using conect As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, conect)
                    command.Parameters.AddWithValue("@Username", TextBox1.Text)
                    command.Parameters.AddWithValue("@Password", TextBox2.Text)
                    command.Parameters.AddWithValue("@UserRoleID", 2) ' Set the default role ID to 2 (regular user)
                    conect.Open()
                    command.ExecuteNonQuery()
                    conect.Close()
                    MsgBox("تم انشاء حساب جديد ")
                End Using
            End Using
        End If
    End Sub

   
End Class