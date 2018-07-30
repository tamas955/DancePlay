Imports System.Web.Script.Serialization

Public Class Form2
    Dim rcnt As Long
    Dim mode As Short = 0
    Private Sub WBros_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WBros.DocumentCompleted
        Dim s As String
        Dim p As String
        Dim l As Integer
        Dim Host1 As String = e.Url.DnsSafeHost
        Dim Orig As String = e.Url.OriginalString
        Dim Path2 As String = e.Url.LocalPath

        If Mid(TextBox1.Text, 1, 13) = "https://youtu" Then ' youtube only & mode0 only
            If mode > 0 Then
                '*** ignore other all ***
                If (Host1 <> "www.youtube.com") And (Trim(Host1) <> "") Then
                    WBros.Refresh()
                    ' Label1.Text = Mid(Host1, 1, 30) 'ignored host
                End If
            End If
        End If

        If Path2 = "/watch" Then
            s = Orig
            l = InStr(s, "?v=") + 3
            s = Mid(s, l, 11)
            '<><><><> Document same as?
            p = TextBox1.Text
            l = InStrRev(p, "/") + 1
            p = Mid(p, l, 11)
            If mode = 0 Then
                '************* mode 0
                If (s <> p) And (Trim(s) <> "") Then
                    TextBox1.Text = "https://youtu.be/" & s 'Mid(e.Url.OriginalString, l, 250)
                    Label1.Text = "New song"
                End If
            Else
                '************* mode 1-2 Document changed -> AfterEnd
                If s <> p Then
                    Form1.Set_WebStat(mode + 2)
                    mode = 0
                    WBros.Navigate("about:blank")
                End If
            End If
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '        'oooooooooooooooooooooooooo WEB TIMER ooooooooooooooooooooooooooooooooooooooooooo
        If Asc(OneX.Text) = 129 Then
            If rcnt > 0 Then
                If rcnt = 1 Then
                    Form1.Set_WebStat(mode + 2)
                    mode = 0
                    WBros.Navigate("about:blank")
                End If
                rcnt = rcnt - 1
            End If
            Label2.Text = rcnt & Chr(34)
        Else
            Label2.Text = TimeString
        End If
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '*** WEB FORM LOAD ***
        Opacity = Form1.Opacity
    End Sub
    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        '*** WEB FORM BEZÁRÁSA ***
        If mode > 0 Then Form1.Set_WebStat(mode + 2)
        If Form1.WindowState = 1 Then
            Form1.WindowState = FormWindowState.Normal
        Else
            Form1.Show()
        End If
    End Sub
    Private Sub Station_Click(sender As Object, e As EventArgs) Handles Station.Click
        '*** RÁDIÓ ÁLLOMÁS ***
        Dim s As String
        SetMode0()
        If TextBox1.Text = Radio.Text Then
            TextBox1.Text = "https://www.auckland80s.com/auckland-80s.html"
            s = "Auckland 80's radio"
        Else
            TextBox1.Text = Radio.Text
            s = "Web Radio"
        End If
        Navi_Click(sender, e)
        Label1.Text = s
    End Sub
    Private Sub Navi_Click(sender As Object, e As EventArgs) Handles Navi.Click
        SetMode0()
        WBros.Navigate(TextBox1.Text)
        Label1.Text = "Navigate..."
    End Sub
    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        SetMode0()
        WBros.GoHome()
        Label1.Text = ""
        TextBox1.Text = "https://www.google.com/?hl=hu"
        '   WebBrowser1.Navigate(TextBox1.Text)
    End Sub
    Private Sub BackwardButton_Click(sender As Object, e As EventArgs) Handles BackwardButton.Click
        SetMode0()
        WBros.GoBack()
        Label1.Text = ""
    End Sub
    Private Sub ForwardButton_Click(sender As Object, e As EventArgs) Handles ForwardButton.Click
        SetMode0()
        WBros.GoForward()
        Label1.Text = ""
    End Sub
    Private Sub NavStop_Click(sender As Object, e As EventArgs) Handles NavStop.Click
        SetMode0()
        WBros.Navigate("about:blank")
        TextBox1.Select()
    End Sub
    Private Sub OneX_Click(sender As Object, e As EventArgs) Handles OneX.Click
        If Asc(OneX.Text) = 129 Then
            OneX.Text = Chr(122) '   ><
        Else
            OneX.Text = Chr(129) ' ( 1 )
        End If
    End Sub
    Private Sub Fress_Click(sender As Object, e As EventArgs) Handles Fress.Click
        WBros.Refresh()
    End Sub
    Private Sub Form2_ClientSizeChanged(sender As Object, e As EventArgs) Handles MyBase.ClientSizeChanged
        WBros.Width = ClientSize.Width - 46
        WBros.Height = ClientSize.Height - 60
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
        If mode = 0 Then
            MsgBox("Web Song " & Mid(TextBox1.Text, 9) & Chr(10) & TextBox1.Text)
            GoTo odane
            Form1.Box1.Items.Add("Web Song " & Mid(TextBox1.Text, 9))
            Form1.Box11.Items.Add(TextBox1.Text)
            Label1.Text = "Added to PlayList ♪"
            Form1.Box1.SetSelected(Form1.Box1.Items.Count - 1, True)
odane:
        End If
    End Sub
    Private Sub AddList2_Click(sender As Object, e As EventArgs) Handles AddList2.Click
        If mode = 0 Then
            Form1.Box2.Items.Add("Web Song " & Mid(TextBox1.Text, 9))
            Form1.Box22.Items.Add(TextBox1.Text)
            Label1.Text = "Added to PlayList ♫"
            Form1.Box2.SetSelected(Form1.Box2.Items.Count - 1, True)
        End If
    End Sub
    Sub SetMode0() ' CHANGE LOCAL STAT
        mode = 0
        OneX.Text = Chr(122)
        Form1.StopMCI(1)
        Form1.StopMCI(2)
    End Sub
    Sub SetRcnt(A As Short, t As Long) ' CALL FROM PLAYER
        mode = A
        rcnt = t ' **** set timeout ****
        OneX.Text = Chr(129)
        If A * t = 0 Then
            WBros.Navigate("about:blank")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim URL As String = "https://www.youtube.com/watch?v=Q-c-oj5MKgI"
        Dim webClient As New System.Net.WebClient
        Dim result As String = webClient.DownloadString("https://www.youtube.com/oembed?format=json&url=" + URL)
        Dim serializer As New JavaScriptSerializer()
        Dim dict As Dictionary(Of String, String) = serializer.Deserialize(Of Dictionary(Of String, String))(result)
        MsgBox(dict.Item("title"))
    End Sub
End Class