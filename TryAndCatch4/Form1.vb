Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number1 As String
        number1 = txtNum.Text
        Try
            'taking the value from the user and convert it to integer data type if it fails then catchbox follows
            number1 = CInt(txtNum.Text)
            'displaying the number the user entered if the an ineteger is entered
            MsgBox("You have entered " & number1)
        Catch ex As Exception
            'if try box fails then catch box will follow printing out the error on the screen
            MsgBox("Error, you have entered a non-numeric value")
            MsgBox(ex.ToString)
        Finally
            MsgBox("We are done here")
        End Try
    End Sub
End Class
