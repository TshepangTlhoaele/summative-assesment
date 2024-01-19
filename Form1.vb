Public Class Form1
    Private Sub AddButton_Click(Sender As Object, e As EventArgs) Handles Button1.Click
        'Check if the value has been entered in the TextBox'
        If TextBox1.TextLength > 0 Then
            'Check If the word or phrase already exist in the list'


        End If
        End
        Dim i As Integer
        If ListBox1.Items(i).ToString = TextBox1.Text.ToString Then
            MessageBox.Show("The item already exist in the list")
        End If
        'Add the word or phrase to the list if it does not already exist
        If TextBox1.Text.Length > 0 Then
            ListBox1.Items.Add(TextBox1.Text.ToString)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
