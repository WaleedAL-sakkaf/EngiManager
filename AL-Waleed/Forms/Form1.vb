

Public Class Form1


    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Button4_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.MouseEnter
        Button4.BackColor = ColorTranslator.FromHtml("#608dc0")
        Button4.Cursor = Cursors.Hand
    End Sub

    Private Sub Button4_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.MouseLeave
        Button4.BackColor = Color.FromArgb(&H394053)
        Button4.Cursor = Cursors.Default
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click


        Panel4.Controls.Clear()
        Form2.TopLevel = False
        Panel4.Controls.Add(Form2)
        Form2.Show()

      
       

    End Sub

    Private Sub Button7_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles Button7.MouseEnter
        Button7.BackColor = ColorTranslator.FromHtml("#608dc0")
        Button7.Cursor = Cursors.Hand
    End Sub

    Private Sub Button7_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Button7.MouseLeave
        Button7.BackColor = Color.FromArgb(&H394053)
        Button7.Cursor = Cursors.Default
    End Sub



    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click



        Panel4.Controls.Clear()
        Form0.TopLevel = False
        Panel4.Controls.Add(Form0)
        Form0.Show()


    End Sub
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing

        RegistrationForm.Close()
        LoginForm.Close()


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.phones' table. You can move, or remove it, as needed.
        Me.PhonesTableAdapter.Fill(Me.DatabaseDataSet.phones)


    End Sub

    Private Sub Button3_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.MouseEnter
        Button3.BackColor = ColorTranslator.FromHtml("#608dc0")
        Button3.Cursor = Cursors.Hand
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.MouseLeave
        Button3.BackColor = Color.FromArgb(&H394053)
        Button3.Cursor = Cursors.Default

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Panel4.Controls.Clear()
        parts.TopLevel = False
        Panel4.Controls.Add(parts)
        parts.Show()
    End Sub


    Private Sub Button2_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.MouseEnter
        Button2.BackColor = ColorTranslator.FromHtml("#608dc0")
        Button2.Cursor = Cursors.Hand
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.FromArgb(&H394053)
        Button2.Cursor = Cursors.Default
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Panel4.Controls.Clear()
        debt.TopLevel = False
        Panel4.Controls.Add(debt)
        debt.Show()
    End Sub


    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = ColorTranslator.FromHtml("#608dc0")
        Button1.Cursor = Cursors.Hand
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.FromArgb(&H394053)
        Button1.Cursor = Cursors.Default
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Panel4.Controls.Clear()
        Trash.TopLevel = False
        Panel4.Controls.Add(Trash)
        Trash.Show()

        Button2.Cursor = Cursors.Hand

    End Sub
End Class
