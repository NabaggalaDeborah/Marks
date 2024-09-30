Public Class Form1
    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click
        Dim Marks As Integer = CInt(txtEnterMarks.Text)
        Dim Grade As String = txtGrade.Text
        If Marks > 100 Then
            MessageBox.Show("Wrong entry, re-enter the mark")
            txtGrade.Text = ""
        ElseIf Marks >= 90 And Marks <= 100 Then
            txtGrade.Text = "Excellent"
        ElseIf Marks >= 80 And Marks <= 89 Then
            txtGrade.Text = "Very Good"
        ElseIf Marks >= 70 And Marks <= 79 Then
            txtGrade.Text = "Good"
        ElseIf Marks >= 60 And Marks <= 69 Then
            txtGrade.Text = "Medium"
        ElseIf Marks >= 50 And Marks <= 59 Then
            txtGrade.Text = "Pass"
        ElseIf Marks >= 40 And Marks <= 49 Then
            txtGrade.Text = "Failed"
        End If

    End Sub

    Private Sub txtGrade_TextChanged(sender As Object, e As EventArgs) Handles txtGrade.TextChanged

    End Sub
End Class
