Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' WEB FORM LOAD
        ''''  Timer1.Enabled = True

    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        '*** WEB FORM BEZÁRÁSA ***
        ''''' Timer1.Enabled = False
        WBros.Navigate("about:blank")
        TextBox1.Text = ""
        ' **** lekezelések ****

        If Form1.WindowState = 1 Then
            Form1.WindowState = FormWindowState.Normal
        Else
            Form1.Show()
        End If
    End Sub

    Private Sub Form2_ClientSizeChanged(sender As Object, e As EventArgs) Handles MyBase.ClientSizeChanged
        WBros.Width = ClientSize.Width - 26
        WBros.Height = ClientSize.Height - 50

    End Sub

    Private Sub Station_Click(sender As Object, e As EventArgs) Handles Station.Click

    End Sub
End Class