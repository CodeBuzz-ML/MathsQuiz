Public Class CertWindow
    Private Sub CertWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer.ReportSource = PublicVars.objRpt
        ReportViewer.Refresh()
        ReportViewer.Zoom(1)

    End Sub
End Class