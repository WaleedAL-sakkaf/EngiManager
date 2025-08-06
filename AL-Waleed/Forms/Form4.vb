Public Class Form4

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        parts.PartsTableAdapter.Fill(parts.DatabaseDataSet.parts)
        Dim rp As New cparts
        rp.SetDataSource(parts.DatabaseDataSet)
        Me.CrystalReportViewer1.ReportSource = rp
    End Sub
End Class