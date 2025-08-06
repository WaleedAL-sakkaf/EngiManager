Public Class cphones

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Form1.PhonesTableAdapter.Fill(Form1.DatabaseDataSet.phones)
        Dim rp As New cphones1
        rp.SetDataSource(Form1.DatabaseDataSet)
        Me.CrystalReportViewer1.ReportSource = rp
    End Sub
End Class