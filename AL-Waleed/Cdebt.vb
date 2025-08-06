Public Class Cdebt

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        debt.DebtTableAdapter.Fill(debt.DatabaseDataSet.debt)
        Dim rp As New crdebt
        rp.SetDataSource(debt.DatabaseDataSet)
        Me.CrystalReportViewer1.ReportSource = rp
    End Sub
End Class