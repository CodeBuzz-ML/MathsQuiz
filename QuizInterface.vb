Public Class QuizInterface
    Dim ansIndex_Public As Integer
    Dim correct As Integer = 0
    Dim answer As Decimal
    Dim elapsedQs As Integer
    Dim questions As Integer = qs
    Private Sub QuizInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Importing the variables from the public vars file/module
        Dim questions As Integer = qs
        Dim level As Integer = lvl


        'Generating + and - questions if level is 1
        Dim Random As System.Random = New System.Random()
        If level = 1 Then
            Dim val1 As Integer = Random.Next(1, 10000)
            Dim val2 As Integer = Random.Next(1, 10000)
            Dim op As Integer = Random.Next(1, 3)
            If op = 1 Then
                Dim operation As String = "+"
            ElseIf op = 2 Then
                Dim operation As String = "-"
            End If

            If op = 1 Then
                answer = val1 + val2
            ElseIf op = 2 Then
                answer = val1 - val2
            End If
            Dim opt1 As Integer = Random.Next(1, 10000)
            Dim opt2 As Integer = Random.Next(1, 10000)
            Dim opt3 As Integer = Random.Next(1, 10000)
            Dim ansIndex As Integer = Random.Next(1, 4)
            ansIndex_Public = ansIndex
            If ansIndex = 1 Then
                rdbOpt1.Text = answer
                rdbOpt2.Text = opt2
                rdbOpt3.Text = opt1
                rdbOpt4.Text = opt3
            ElseIf ansIndex = 2 Then
                rdbOpt2.Text = answer
                rdbOpt1.Text = opt2
                rdbOpt3.Text = opt1
                rdbOpt4.Text = opt3
            ElseIf ansIndex = 3 Then
                rdbOpt3.Text = answer
                rdbOpt2.Text = opt2
                rdbOpt1.Text = opt1
                rdbOpt4.Text = opt3
            ElseIf ansIndex = 4 Then
                rdbOpt4.Text = answer
                rdbOpt2.Text = opt2
                rdbOpt1.Text = opt1
                rdbOpt1.Text = opt3
            End If
            Dim eq As String
            If op = 1 Then
                eq = val1.ToString() + " + " + val2.ToString()
                lblQuestion.Text = eq
            ElseIf op = 2 Then
                eq = val1.ToString() + " - " + val2.ToString()
                lblQuestion.Text = eq
            End If

            'Generating * questions if level is 2
        ElseIf level = 2 Then
            Dim val1 As Integer = Random.Next(1, 10000)
            Dim val2 As Integer = Random.Next(1, 10000)
            Dim op As Integer = 1
            Dim operation As String = "*"
            answer = val1 * val2
            Dim opt1 As Integer = Random.Next(1, 100000000)
            Dim opt2 As Integer = Random.Next(1, 100000000)
            Dim opt3 As Integer = Random.Next(1, 100000000)
            Dim ansIndex As Integer = Random.Next(1, 4)
            If ansIndex = 1 Then
                rdbOpt1.Text = answer
                rdbOpt2.Text = opt2
                rdbOpt3.Text = opt1
                rdbOpt4.Text = opt3
            ElseIf ansIndex = 2 Then
                rdbOpt2.Text = answer
                rdbOpt1.Text = opt2
                rdbOpt3.Text = opt1
                rdbOpt4.Text = opt3
            ElseIf ansIndex = 3 Then
                rdbOpt3.Text = answer
                rdbOpt2.Text = opt2
                rdbOpt1.Text = opt1
                rdbOpt4.Text = opt3
            ElseIf ansIndex = 4 Then
                rdbOpt4.Text = answer
                rdbOpt2.Text = opt2
                rdbOpt1.Text = opt1
                rdbOpt1.Text = opt3
            End If
            Dim eq As String = val1.ToString() + operation + val2.ToString()
            lblQuestion.Text = eq

            'Generating / questions if level is 3
        ElseIf level = 3 Then
            Dim val1 As Integer = Random.Next(1, 10000)
            Dim val2 As Integer = Random.Next(1, 10000)
            Dim op As Integer = 1
            Dim operation As String = "/"
            answer = val1 / val2
            Dim opt1 As Decimal = Random.Next(1, 100)
            Dim opt2 As Decimal = Random.Next(1, 100)
            Dim opt3 As Decimal = Random.Next(1, 100)
            Dim ansIndex As Integer = Random.Next(1, 4)
            If ansIndex = 1 Then
                rdbOpt1.Text = answer
                rdbOpt2.Text = opt2
                rdbOpt3.Text = opt1
                rdbOpt4.Text = opt3
            ElseIf ansIndex = 2 Then
                rdbOpt2.Text = answer
                rdbOpt1.Text = opt2
                rdbOpt3.Text = opt1
                rdbOpt4.Text = opt3
            ElseIf ansIndex = 3 Then
                rdbOpt3.Text = answer
                rdbOpt2.Text = opt2
                rdbOpt1.Text = opt1
                rdbOpt4.Text = opt3
            ElseIf ansIndex = 4 Then
                rdbOpt4.Text = answer
                rdbOpt2.Text = opt2
                rdbOpt1.Text = opt1
                rdbOpt1.Text = opt3
            End If
            Dim eq As String = val1.ToString() + operation + val2.ToString()
            lblQuestion.Text = eq
        End If
    End Sub 'Form Load Event

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If CDec(rdbOpt1.Text) = answer And rdbOpt1.Checked Then
            correct = correct + 1
        ElseIf CDec(rdbOpt2.Text) = answer And rdbOpt2.Checked Then
            correct = correct + 1
        ElseIf CDec(rdbOpt3.Text) = answer And rdbOpt3.Checked Then
            correct = correct + 1
        ElseIf CDec(rdbOpt4.Text) = answer And rdbOpt4.Checked Then
            correct = correct + 1
        End If
        Dim questions As Integer = qs

        If elapsedQs = qs - 1 Then
            'MessageBox.Show(correct.ToString + "/" + qs.ToString, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PublicVars.result = correct
            Me.Hide()
            Result.Show()
        ElseIf elapsedQs <> qs Then
            Dim level As Integer = lvl

            'Generating + and - questions if level is 1
            Dim Random As System.Random = New System.Random()
            If level = 1 Then
                Dim val1 As Integer = Random.Next(1, 10000)
                Dim val2 As Integer = Random.Next(1, 10000)
                Dim op As Integer = Random.Next(1, 2)
                If op = 1 Then
                    Dim operation As String = "+"
                ElseIf op = 2 Then
                    Dim operation As String = "-"
                End If

                If op = 1 Then
                    answer = val1 + val2
                ElseIf op = 2 Then
                    answer = val1 - val2
                End If
                Dim opt1 As Integer = Random.Next(1, 10000)
                Dim opt2 As Integer = Random.Next(1, 10000)
                Dim opt3 As Integer = Random.Next(1, 10000)
                Dim ansIndex As Integer = Random.Next(1, 4)
                ansIndex_Public = ansIndex
                If ansIndex = 1 Then
                    rdbOpt1.Text = answer
                    rdbOpt2.Text = opt2
                    rdbOpt3.Text = opt1
                    rdbOpt4.Text = opt3
                ElseIf ansIndex = 2 Then
                    rdbOpt2.Text = answer
                    rdbOpt1.Text = opt2
                    rdbOpt3.Text = opt1
                    rdbOpt4.Text = opt3
                ElseIf ansIndex = 3 Then
                    rdbOpt3.Text = answer
                    rdbOpt2.Text = opt2
                    rdbOpt1.Text = opt1
                    rdbOpt4.Text = opt3
                ElseIf ansIndex = 4 Then
                    rdbOpt4.Text = answer
                    rdbOpt2.Text = opt2
                    rdbOpt1.Text = opt1
                    rdbOpt1.Text = opt3
                End If
                Dim eq As String
                If op = 1 Then
                    eq = val1.ToString() + " + " + val2.ToString()
                    lblQuestion.Text = eq
                ElseIf op = 2 Then
                    eq = val1.ToString() + " - " + val2.ToString()
                    lblQuestion.Text = eq
                End If

                'Generating * questions if level is 2
            ElseIf level = 2 Then
                Dim val1 As Integer = Random.Next(1, 10000)
                Dim val2 As Integer = Random.Next(1, 10000)
                Dim op As Integer = 1
                Dim operation As String = "*"
                answer = val1 * val2
                Dim opt1 As Integer = Random.Next(1, 100000000)
                Dim opt2 As Integer = Random.Next(1, 100000000)
                Dim opt3 As Integer = Random.Next(1, 100000000)
                Dim ansIndex As Integer = Random.Next(1, 4)
                If ansIndex = 1 Then
                    rdbOpt1.Text = answer
                    rdbOpt2.Text = opt2
                    rdbOpt3.Text = opt1
                    rdbOpt4.Text = opt3
                ElseIf ansIndex = 2 Then
                    rdbOpt2.Text = answer
                    rdbOpt1.Text = opt2
                    rdbOpt3.Text = opt1
                    rdbOpt4.Text = opt3
                ElseIf ansIndex = 3 Then
                    rdbOpt3.Text = answer
                    rdbOpt2.Text = opt2
                    rdbOpt1.Text = opt1
                    rdbOpt4.Text = opt3
                ElseIf ansIndex = 4 Then
                    rdbOpt4.Text = answer
                    rdbOpt2.Text = opt2
                    rdbOpt1.Text = opt1
                    rdbOpt1.Text = opt3
                End If
                Dim eq As String = val1.ToString() + operation + val2.ToString()
                lblQuestion.Text = eq

                'Generating / questions if level is 3
            ElseIf level = 3 Then
                Dim val1 As Integer = Random.Next(1, 10000)
                Dim val2 As Integer = Random.Next(1, 10000)
                Dim op As Integer = 1
                Dim operation As String = "/"
                answer = val1 / val2
                Dim opt1 As Decimal = Random.Next(1, 100)
                Dim opt2 As Decimal = Random.Next(1, 100)
                Dim opt3 As Decimal = Random.Next(1, 100)
                Dim ansIndex As Integer = Random.Next(1, 4)
                If ansIndex = 1 Then
                    rdbOpt1.Text = answer
                    rdbOpt2.Text = opt2
                    rdbOpt3.Text = opt1
                    rdbOpt4.Text = opt3
                ElseIf ansIndex = 2 Then
                    rdbOpt2.Text = answer
                    rdbOpt1.Text = opt2
                    rdbOpt3.Text = opt1
                    rdbOpt4.Text = opt3
                ElseIf ansIndex = 3 Then
                    rdbOpt3.Text = answer
                    rdbOpt2.Text = opt2
                    rdbOpt1.Text = opt1
                    rdbOpt4.Text = opt3
                ElseIf ansIndex = 4 Then
                    rdbOpt4.Text = answer
                    rdbOpt2.Text = opt2
                    rdbOpt1.Text = opt1
                    rdbOpt1.Text = opt3
                End If
                Dim eq As String = val1.ToString() + operation + val2.ToString()
                lblQuestion.Text = eq
            End If
        End If
        elapsedQs = elapsedQs + 1
    End Sub
End Class