Imports System.Data.OleDb

Public Class LoginForm

    Dim conect As New OleDbConnection


    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        RegistrationForm.Show()
        Me.Hide()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        If AuthenticateUser(username, password) Then
            MessageBox.Show("تم تسجيل الدخول بنجاح!")
            Form1.Show()
            Me.Hide()
        Else
            MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة!")
        End If
    End Sub

    Private Function AuthenticateUser(ByVal username As String, ByVal password As String) As Boolean
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + IO.Directory.GetCurrentDirectory + "\Database.accdb"
        Dim query As String = "SELECT ID FROM Users WHERE Username = @Username AND Password = @Password;"
        Using conect As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(query, conect)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)
                conect.Open()
                Dim userId As Object = command.ExecuteScalar()
                conect.Close()
                Return userId IsNot Nothing
            End Using
        End Using
    End Function


    

   
End Class