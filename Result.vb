Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data

Public Class Result
    Dim total As Integer = PublicVars.qs
    Dim result As Integer = PublicVars.result
    Dim percentage As Decimal = (result / total) * 100
    Dim level As Integer = PublicVars.lvl
    Dim mode As String
    Private Sub Result_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        total = PublicVars.qs
        result = PublicVars.result
        percentage = (result / total) * 100
        level = PublicVars.lvl


        If level = 1 Then
            mode = "Beginner: + and - Questions"
        ElseIf level = 2 Then
            mode = "Intermediate: * Questions"
        ElseIf level = 3 Then
            mode = "Expert: / Questions"
        End If



        lblTotal.Text = total
        lblCorrect.Text = result
        lblPercentage.Text = percentage
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        QuizInterface.Close()
        SelectOptions.Close()
        Me.Close()
    End Sub

    Private Sub btnOpenCert_Click(sender As Object, e As EventArgs) Handles btnOpenCert.Click


        Dim ds As New CertDataSet
        Dim t As DataTable = ds.Tables.Add("Data")
        t.Columns.Add("TotalPercentage", Type.GetType("System.Decimal"))
        t.Columns.Add("Mode", Type.GetType("System.String"))
        t.Columns.Add("TotalQs", Type.GetType("System.Int32"))
        t.Columns.Add("CorrectQs", Type.GetType("System.Int32"))

        Dim r As DataRow = t.NewRow()

        r("TotalPercentage") = percentage
        r("Mode") = mode
        r("TotalQs") = total
        r("CorrectQs") = result
        t.Rows.Add(r)
        PublicVars.objRpt.SetDataSource(ds.Tables(1))
        CertWindow.ShowDialog()

    End Sub
End Class