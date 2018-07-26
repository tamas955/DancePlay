Public Class Form2
    Dim rcnt As Long
    Dim mode As Short = 0
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' WEB FORM LOAD
        Opacity = Form1.Opacity
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
        WBros.Width = ClientSize.Width - 46
        WBros.Height = ClientSize.Height - 60
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
            OneX.Text = Chr(122) ' nav mode
        Else
            OneX.Text = Chr(129) ' play mode
        End If
    End Sub
    Private Sub Fress_Click(sender As Object, e As EventArgs) Handles Fress.Click
        WBros.Refresh()
    End Sub
    Private Sub WBros_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WBros.DocumentCompleted
        Dim s As String
        Dim p As String
        Dim l As Integer
        If e.Url.LocalPath = "/watch" Then
            s = e.Url.OriginalString
            l = InStr(s, "?v=") + 3
            s = Mid(s, l, 11)
            '<><><><> Document same as?
            p = TextBox1.Text
            l = InStrRev(p, "/") + 1
            p = Mid(p, l, 11)
            If mode = 0 Then
                '************* mode 0
                TextBox1.Text = "https://youtu.be/" & Mid(e.Url.OriginalString, l, 250)
                OneX.Text = Chr(122) ' nav mode
            Else
                '************* mode 1-2 Document changed -> AfterEnd
                If s <> p Then
                    Form1.Set_WebStat(mode + 2)
                    WBros.Navigate("about:blank")
                End If
            End If
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '        'oooooooooooooooooooooooooo WEB TIMER ooooooooooooooooooooooooooooooooooooooooooo
        If Asc(OneX.Text) = 129 Then
            rcnt = rcnt - 1
            Label1.Text = mode & " " & rcnt
            If rcnt > 0 Then
                If rcnt = 1 Then
                    Form1.Set_WebStat(mode + 2)
                    WBros.Navigate("about:blank")
                End If
                rcnt = rcnt - 1
            End If
        End If
    End Sub
    Sub SetRcnt(t As Long)
        rcnt = t ' **** set timeout ****
        OneX.Text = Chr(129)
    End Sub
    Private Sub WOpac_MouseClick(sender As Object, e As MouseEventArgs) Handles WOpac.MouseClick
        '$$$$$$$$$$$$$$$$$$ OPACITY $$$$$$$$$$$$$$$$
        Dim X As Short
        X = 100 - (0.5 * e.X)
        If X < 33 Then X = 33
        If X > 90 Then X = 100
        Opacity = X / 100
    End Sub
    Private Sub AddList1_Click(sender As Object, e As EventArgs) Handles AddList1.Click
        ' Form1.ListBox1.Items.Add("Web Song " & Mid(TextBox1.Text, 9))
        'Form1.ListBox3.Items.Add(TextBox1.Text)
        Label1.Text = "Added to PlayList ♪"
    End Sub
    Private Sub AddList2_Click(sender As Object, e As EventArgs) Handles AddList2.Click
        Label1.Text = "Added to PlayList ♫"
    End Sub
End Class