Public Class Trash

    Private Sub Trash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Delivered' table. You can move, or remove it, as needed.
        Me.DeliveredTableAdapter.Fill(Me.DatabaseDataSet.Delivered)

    End Sub
End Class