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
        '*** RÁDIÓ ÁLLOMÁS ***
        Form1.StopMCI(1)
        Form1.StopMCI(2)
        If TextBox1.Text = Radio.Text Then
            TextBox1.Text = "https://www.auckland80s.com/auckland-80s.html"
            Label1.Text = "Auckland 80's radio"
        Else
            TextBox1.Text = Radio.Text
            Label1.Text = "Web Radio"
        End If
        Navi_Click(sender, e)
    End Sub
    Private Sub Navi_Click(sender As Object, e As EventArgs) Handles Navi.Click
        WBros.Navigate(TextBox1.Text)
        Label1.Text = Mid(TextBox1.Text, 13, 32)
    End Sub
    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Form1.StopMCI(1)
        Form1.StopMCI(2)
        WBros.GoHome()
        Label1.Text = ""
        TextBox1.Text = "https://www.google.com/?hl=hu"
        '   WebBrowser1.Navigate(TextBox1.Text)
    End Sub
    Private Sub BackwardButton_Click(sender As Object, e As EventArgs) Handles BackwardButton.Click
        WBros.GoBack()
    End Sub
    Private Sub ForwardButton_Click(sender As Object, e As EventArgs) Handles ForwardButton.Click
        WBros.GoForward()
    End Sub

    Private Sub NavStop_Click(sender As Object, e As EventArgs) Handles NavStop.Click
        WBros.Navigate("about:blank")
        TextBox1.Select()
    End Sub
    Private Sub OneX_Click(sender As Object, e As EventArgs) Handles OneX.Click
        If Asc(OneX.Text) = 129 Then
            OneX.Text = Chr(122)
            Opacity = 1
        Else
            OneX.Text = Chr(129)
            Opacity = Form1.Opacity
        End If
    End Sub

    Private Sub Fress_Click(sender As Object, e As EventArgs) Handles Fress.Click
        WBros.Refresh()
    End Sub
End Class