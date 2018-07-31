Public Class Form1
    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer
    ' pause for 5 seconds
    Dim APdl As Boolean = False 'jelzi hogy kell-e menteni az (első) listát kilépéskor
    Dim Bpdl As Boolean = False 'u.a. B-re
    Dim ALenght As Long = 0
    Dim BLenght As Long = 0
    Dim Cnt As Long = 0
    Dim Art As Boolean = True
    Dim Webstat As Short = 0
    Dim PlayErr As Short = 0
    Dim vze As Boolean = False
    Private Sub PlyTimer_Tick(sender As Object, e As EventArgs) Handles PlyTimer.Tick
        Dim Rv As Integer = 0
        Dim Rs As String = Space(128)
        Dim s As String
        Dim q As Long
        '* * System time * *
        SysTime.Text = TimeString
        If Webstat = 0 Then ' web l. lejjebb
            If Poz1.ForeColor <> System.Drawing.Color.Black Then 'nem fekete a csúszka
                Rv = mciSendString("status asong mode", Rs, 128, 0)
                If LCase(Mid(Rs, 1, 4)) = "stop" Then
                    Rv = mciSendString("close asong", 0, 0, 0)
                    AfterEnd(True) '                                 stop-hoz ért ->>
                End If
                If LCase(Mid(Rs, 1, 4)) = "play" Then
                    Rv = mciSendString("status asong position", Rs, 128, 0)
                    If InStr(Szhms(Val(Rs) / 1000), "Web") Then
                        NowTime.Text = "00:00:00"
                    Else '                                          Played time kiírás
                        NowTime.Text = Szhms(Val(Rs) / 1000)
                        q = Fix((10 * Val(Rs) / (ALenght + 1)))
                        Select Case q'                              Played time - lemezjátszó kar
                            Case 2
                                Pict1.Image = My.Resources.Arm02
                            Case 3
                                Pict1.Image = My.Resources.Arm03
                            Case 4
                                Pict1.Image = My.Resources.Arm04
                            Case 5
                                Pict1.Image = My.Resources.Arm05
                            Case 6
                                Pict1.Image = My.Resources.Arm06
                            Case 7
                                Pict1.Image = My.Resources.Arm07
                            Case 8
                                Pict1.Image = My.Resources.Arm08
                            Case 9
                                Pict1.Image = My.Resources.Arm09
                        End Select
                    End If
                    Poz1.Left = Box1.Left + (Val(Rs) / ((ALenght + 1) / Box1.Width)) ' CSÚSZTATÁS o->
                    If Pict0.Visible = False And Pict0.TabStop And (Cnt < 1) Then AfterEnd(True) ' SZÁMLÁLÓ LEJÁRT ->>
                End If
            End If '=============================================================================================
            If Poz2.ForeColor <> System.Drawing.Color.Black Then '            - Bre is -
                Rv = mciSendString("status bsong mode", Rs, 128, 0)
                If LCase(Mid(Rs, 1, 4)) = "stop" Then
                    Rv = mciSendString("close bsong", 0, 0, 0)
                    AfterEnd(False)
                End If
                If LCase(Mid(Rs, 1, 4)) = "play" Then
                    Rv = mciSendString("status bsong position", Rs, 128, 0)
                    If InStr(Szhms(Val(Rs) / 1000), "Web") Then
                        NowTime.Text = "00:00:00"
                    Else
                        NowTime.Text = Szhms(Val(Rs) / 1000)
                    End If
                    Poz2.Left = Box2.Left + (Val(Rs) / ((BLenght + 1) / Box2.Width))
                    q = Fix((10 * Val(Rs) / (BLenght + 1)))
                    Select Case q
                        Case 2
                            Pict2.Image = My.Resources.Arm02
                        Case 3
                            Pict2.Image = My.Resources.Arm03
                        Case 4
                            Pict2.Image = My.Resources.Arm04
                        Case 5
                            Pict2.Image = My.Resources.Arm05
                        Case 6
                            Pict2.Image = My.Resources.Arm06
                        Case 7
                            Pict2.Image = My.Resources.Arm07
                        Case 8
                            Pict2.Image = My.Resources.Arm08
                        Case 9
                            Pict2.Image = My.Resources.Arm09
                    End Select
                    If Pict0.Visible = False And Pict0.TabStop And (Cnt < 1) Then AfterEnd(False)
                End If
            End If  '=============================================================================================

            If Pict0.Visible = False Then
                If (Cnt > 0) Then
                    If vze Then
                        If Paso.TabStop And Pict0.TabStop Then
                            BckTime.Text = "Paso"
                        Else
                            BckTime.Text = Mid(Szhms(Cnt), 4, 5)
                            Cnt = Cnt + vze
                        End If
                    End If
                    If Pict0.TabStop Then
                        If (Cnt < 6) And (Paso.TabStop = False) Then
                            Volreg(Art, (100 - VolCtrl1.Value) / (7 - Cnt))
                        End If
                    End If
                    If (Pict0.TabStop = False) And (Bell.TabStop = False) Then
                        If (Cnt / 10) = Int(Cnt / 10) Then
                            Rv = mciSendString("play bell from 0", vbNullString, 0, 0)
                        End If
                        If Cnt = 5 Then
                            Rv = mciSendString("stop bell", 0, 0, 0)
                            Rv = mciSendString("close bell", 0, 0, 0)
                            Rv = mciSendString("open " & Chr(34) & "bell02.mp3" & Chr(34) & " type mpegvideo alias bell", vbNullString, 0, 0)
                        End If
                        If Cnt = 4 Then Rv = mciSendString("play bell", vbNullString, 0, 0)
                        If Cnt = 3 Then
                            Rv = mciSendString("stop bell", 0, 0, 0)
                            Rv = mciSendString("close bell", 0, 0, 0)
                            Rv = mciSendString("open " & Chr(34) & "bell03.mp3" & Chr(34) & " type mpegvideo alias bell", vbNullString, 0, 0)
                        End If
                        If Cnt = 2 Then Rv = mciSendString("open " & Chr(34) & "bell02.mp3" & Chr(34) & " type mpegvideo alias bell", vbNullString, 0, 0)
                        If Cnt = 0 Then Rv = mciSendString("play bell", vbNullString, 0, 0)
                    End If
                Else
                    If (Pict0.TabStop = False) And BckTime.ForeColor = System.Drawing.Color.Yellow Then
                        Rv = mciSendString("stop bell", 0, 0, 0)
                        Rv = mciSendString("close bell", 0, 0, 0)
                        BckTime.ForeColor = System.Drawing.Color.Aqua
                        If Paso.TabStop Then
                            BckTime.Text = "Paso"
                        Else
                            BckTime.Text = Mid(Szhms(BackCtrl.Value), 4, 5)
                            '  Pict0.TabStop = False
                        End If
                        PlayNext(Art, True)
                    End If
                End If
            End If
        Else
            'Web megy -----------------------------------------'WEB 
            If Webstat = 3 Then AfterEnd(True) ' Lejárt a web
            If Webstat = 4 Then AfterEnd(False)
            If Pict0.Visible = False Then
                If Paso.TabStop = False Then
                    If Cnt > 0 Then
                        BckTime.Text = Mid(Szhms(Cnt), 4, 5)
                        Cnt = Cnt + vze
                    Else
                        If (Webstat = 1) Or (Webstat = 3) Then AfterEnd(True)
                        If (Webstat = 2) Or (Webstat = 4) Then AfterEnd(False)
                    End If
                Else
                    BckTime.Text = "Paso"
                End If
            End If
        End If
    End Sub
    Sub Set_WebStat(q As Short) 'CALLED FROM WEBPLAYER
        Webstat = q
    End Sub
    Sub AfterEnd(A As Boolean) '<=============== END POINT ==================>
        Dim Rv As Integer
        If Webstat > 0 Then
            Webstat = 0
            Form2.SetRcnt(0, 0)
        End If
        If Pict0.Visible Then
            If A Then PlayNext(True, True) Else PlayNext(False, True)
        Else
            Pict0.TabStop = False
            Rv = mciSendString("open " & Chr(34) & "bell01.mp3" & Chr(34) & " type mpegvideo alias bell", vbNullString, 0, 0)
            Rv = mciSendString("setaudio bell volume to " & "10" * 10, vbNullString, 0, 0)
            BckTime.ForeColor = System.Drawing.Color.Yellow
            Cnt = WaitCtrl.Value
            Art = A
            If A Then
                Rv = mciSendString("stop asong", 0, 0, 0)
                Poz1.ForeColor = System.Drawing.Color.Black
                NowTime.Text = " ♪ ♪ ♪ ♪ ♪"
            Else
                Rv = mciSendString("stop bsong", 0, 0, 0)
                Poz2.ForeColor = System.Drawing.Color.Black
                NowTime.Text = " ♫ ♫ ♫ ♫"
            End If
        End If
    End Sub
    Sub PlayMCI(Cm As Short)
        Dim Rv As Integer = 0
        Dim Rs As String = Space(128)
        Dim s As String
        Select Case Cm
            Case 1
                If Box1.SelectedIndex > -1 Then
                    StopMCI(1)
                    s = Trim(Box11.Items(Box1.SelectedIndex))
                    If TipTxt1.Text <> "WEB" Then
                        Rv = mciSendString("open " & Chr(34) & s & Chr(34) & " type mpegvideo alias asong", vbNullString, 0, 0)
                        Rv = mciSendString("play asong", vbNullString, 0, 0)
                        If Rv = 0 Then
                            Text = s
                            NowTxt1.Text = BoxTxt1.Text
                            Rv = mciSendString("status asong length", Rs, 128, 0)
                            ALenght = Val(Rs)
                            TimTxt1.Text = Szhms(ALenght / 1000)
                            Poz1.ForeColor = System.Drawing.Color.Yellow
                            If Paso.TabStop Then Cnt = 4 + ALenght / 1000 Else Cnt = BackCtrl.Value
                            Pict1.Image = My.Resources.Arm01
                            Volreg(True, (100 - VolCtrl1.Value))
                            Art = True
                            Pict0.TabStop = True ' cnt indul
                            PlayErr = 0                             '*** bad file 4× -> stop
                            vze = True
                        Else
                            Rv = mciSendString("close asong", 0, 0, 0)
                            PlayErr = PlayErr + 1
                            If PlayErr < Box1.Items.Count Then
                                AfterEnd(True)
                            Else
                                PlayErr = -1
                                StopMCI(1)
                            End If
                        End If
                    Else
                        'TIPTXT1 WEB
                        Webstat = 1
                        Form2.SetRcnt(1, 500) ' BIZTONSÁGI IDŐ 8,33 '
                        Cnt = BackCtrl.Value
                        Text = s
                        NowTxt1.Text = Mid(Box1.Text, 11)
                        Form2.Label1.Text = "♪" & Mid(Box1.Text, 11)
                        Form2.TextBox1.Text = s
                        Form2.WBros.Navigate(s)
                        NowTime.Text = "♪ Web ♪"
                        vze = True
                    End If
                End If
            Case 2
                If Box2.SelectedIndex > -1 Then
                    StopMCI(2)
                    s = Trim(Box22.Items(Box2.SelectedIndex))
                    If TipTxt2.Text <> "WEB" Then
                        Rv = mciSendString("stop bsong", 0, 0, 0)
                        Rv = mciSendString("close bsong", 0, 0, 0)
                        Rv = mciSendString("open " & Chr(34) & s & Chr(34) & " type mpegvideo alias bsong", vbNullString, 0, 0)
                        Rv = mciSendString("play bsong", vbNullString, 0, 0)
                        If Rv = 0 Then
                            Text = s
                            NowTxt2.Text = BoxTxt2.Text
                            Rv = mciSendString("status bsong length", Rs, 128, 0)
                            BLenght = Val(Rs)
                            TimTxt2.Text = Szhms(BLenght / 1000)
                            Poz2.ForeColor = System.Drawing.Color.Yellow
                            If Paso.TabStop Then Cnt = 4 + BLenght / 1000 Else Cnt = BackCtrl.Value
                            Pict2.Image = My.Resources.Arm01
                            Volreg(False, (100 - VolCtrl1.Value))
                            Art = False
                            Pict0.TabStop = True ' cnt indul
                            PlayErr = 0
                            vze = True
                        Else
                            Rv = mciSendString("close bsong", 0, 0, 0)
                            PlayErr = PlayErr + 1
                            If PlayErr < Box2.Items.Count Then
                                AfterEnd(False)
                            Else
                                PlayErr = -1
                                StopMCI(2)
                            End If
                        End If
                    Else
                        'TIPTXT2 WEB
                        Webstat = 2
                        Form2.SetRcnt(2, 500) ' BIZTONSÁGI IDŐ 8,33 ' *
                        Cnt = BackCtrl.Value
                        Text = s
                        NowTxt2.Text = Mid(Box2.Text, 11)
                        Form2.Label1.Text = "♫ " & Mid(Box2.Text, 11)
                        Form2.TextBox1.Text = s
                        Form2.WBros.Navigate(s)
                        NowTime.Text = "♫ Web ♫"
                        vze = True
                    End If
                End If
        End Select
    End Sub
    Sub PauseMCI(Cm As Short)
        Dim Rv As Integer = 0
        If Cm = 1 Then
            If Poz1.ForeColor = System.Drawing.Color.Yellow Then
                Rv = mciSendString("pause asong", 0, 0, 0)
                Poz1.ForeColor = System.Drawing.Color.Lime
            Else
                Rv = mciSendString("resume asong", 0, 0, 0)
                Poz1.ForeColor = System.Drawing.Color.Yellow
            End If
        End If
        If Cm = 2 Then
            If Poz2.ForeColor = System.Drawing.Color.Yellow Then
                Rv = mciSendString("pause bsong", 0, 0, 0)
                Poz2.ForeColor = System.Drawing.Color.Lime
            Else
                Rv = mciSendString("resume bsong", 0, 0, 0)
                Poz2.ForeColor = System.Drawing.Color.Yellow
            End If
        End If
    End Sub
    Sub StopMCI(Cm As Short)
        Dim Rv As Integer = 0
        PlyTimer.Enabled = False
        If Webstat > 0 Then
            'Web Stop from player
            If (Webstat = 1) And (Cm = 1) Then
                Form2.SetRcnt(0, 0)
            End If
            If (Webstat = 2) And (Cm = 2) Then
                Form2.SetRcnt(0, 0)
            End If
            Webstat = 0
            vze = False
        End If
        If Cm = 1 Then
            Poz1.ForeColor = System.Drawing.Color.Black
            NowTxt1.Text = "Dance Player"
            TimTxt1.Text = "00:00:00"
            Rv = mciSendString("stop asong", 0, 0, 0)
            Rv = mciSendString("close asong", 0, 0, 0)
            NowTime.Text = " ♪ ♪ ♪ ♪ ♪"
            Pict1.Image = My.Resources.Arm00
            vze = False
        End If
        If Cm = 2 Then
            Poz2.ForeColor = System.Drawing.Color.Black
            NowTxt2.Text = "Dance Player"
            TimTxt2.Text = "00:00:00"
            Rv = mciSendString("stop bsong", 0, 0, 0)
            Rv = mciSendString("close bsong", 0, 0, 0)
            NowTime.Text = " ♫ ♫ ♫ ♫"
            Pict2.Image = My.Resources.Arm00
            vze = False
        End If
        BckTime.ForeColor = System.Drawing.Color.Aqua
        If Paso.TabStop Then
            BckTime.Text = "Paso"
        Else
            BckTime.Text = Mid(Szhms(BackCtrl.Value), 4, 5)
            '  Pict0.TabStop = False
        End If
        PlyTimer.Enabled = True
    End Sub
    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        Dim x As Integer = 1000 * e.X / Width
        Dim y As Integer = 1000 * (e.Y + 40) / Height
        '   Dim s As String = "*"
        If (y > 473) And (y < 600) Then  ' ******** SET POSITION *******
            Dim Rv As Integer
            Dim Rs As String = Space(128)
            Dim p As Long
            If e.X < Box1.Width + 30 Then
                If Poz1.ForeColor <> System.Drawing.Color.Black Then
                    p = 100 * (e.X - Box1.Left) / Box1.Width
                    If p < 0 Then p = 0
                    If p > 100 Then p = 100
                    p = p * ALenght / 100
                    Rv = mciSendString("play asong from " + Str(p), Rs, 128, 0)
                End If
            Else
                If Poz2.ForeColor <> System.Drawing.Color.Black Then
                    p = 100 * (e.X - Box2.Left) / Box2.Width
                    If p < 0 Then p = 0
                    If p > 100 Then p = 100
                    p = p * BLenght / 100
                    Rv = mciSendString("play bsong from " + Str(p), Rs, 128, 0)
                End If
            End If
        End If '-- setposition area --
        If (y > 387) And (y < 474) Then ' ****** PLAYER BUTTONS ********
            '#### PLAY ####
            If (x > 173) And (x < 208) Then
                PlayMCI(1)
            End If
            If (x > 699) And (x < 734) Then
                PlayMCI(2)
            End If
            '#### PAUSE/RESUME ####
            If (x > 211) And (x < 246) Then
                PauseMCI(1)
            End If
            If (x > 737) And (x < 772) Then
                PauseMCI(2)
            End If
            '#### STOP ####
            If (x > 250) And (x < 285) Then
                StopMCI(1)
                Box1.Select()
            End If
            If (x > 776) And (x < 811) Then
                StopMCI(2)
                Box2.Select()
            End If
            '#### FORWARD ####
            If (x > 290) And (x < 325) Then
                PlayNext(True, True)
            End If
            If (x > 816) And (x < 851) Then
                PlayNext(False, True)
            End If
            '#### BACKWARD ####
            If (x > 130) And (x < 164) Then
                PlayNext(True, False)
            End If
            If (x > 656) And (x < 690) Then
                PlayNext(False, False)
            End If
        End If
        '----------------------------------------------------- LISTBOX -----------------
        '##### LIST BUTTONS ####
        If (x > 501) And (x < 525) Then
            If (y > 754) And (y < 821) Then
                '*** copy Left to Right
                Dim index As Integer
                index = Box1.SelectedIndex
                If index > -1 Then
                    Box2.Items.Add(Box1.SelectedItem)
                    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
                    Box22.Items.Add(Box11.Items(index))
                    If index < (Box1.Items.Count - 1) Then
                        Box1.SetSelected(index + 1, True)
                    End If
                End If
            End If
            If (y > 833) And (y < 889) Then
                '*** copy Right to Left
                Dim index As Integer
                index = Box2.SelectedIndex
                If index > -1 Then
                    Box1.Items.Add(Box2.SelectedItem)
                    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
                    Box11.Items.Add(Box22.Items(index))
                    If index < (Box2.Items.Count - 1) Then
                        Box2.SetSelected(index + 1, True)
                    End If
                End If
            End If
        End If
        '-----------------------------------------------------------
        If y > 960 Then
            If x < 64 Then
                '**** ADD A FILES ****
                PlyTimer.Enabled = False
                If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    For i As Integer = 0 To Val(OpenFileDialog1.FileNames.Length) - 1
                        AddMusicFile(True, OpenFileDialog1.FileNames(i))
                    Next
                End If
                PlyTimer.Enabled = True
            End If
            If (x > 509) And (x < 566) Then
                '**** ADD B FILES ****
                PlyTimer.Enabled = False
                If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                    For i As Integer = 0 To Val(OpenFileDialog1.FileNames.Length) - 1
                        AddMusicFile(False, OpenFileDialog1.FileNames(i))
                    Next
                End If
                PlyTimer.Enabled = True
            End If
            If (x > 70) And (x < 93) Then
                '**** LOAD A FOLDER ****
                PlyTimer.Enabled = False
                If (FolderOpen.ShowDialog() = DialogResult.OK) Then
                    For Each foundFile As String In My.Computer.FileSystem.GetFiles(FolderOpen.SelectedPath)
                        AddMusicFile(True, foundFile)
                    Next
                End If
                PlyTimer.Enabled = True
            End If
            If (x > 566) And (x < 594) Then
                '**** LOAD B FOLDER ****
                PlyTimer.Enabled = False
                If (FolderOpen.ShowDialog() = DialogResult.OK) Then
                    For Each foundFile As String In My.Computer.FileSystem.GetFiles(FolderOpen.SelectedPath)
                        AddMusicFile(False, foundFile)
                    Next
                End If
                PlyTimer.Enabled = True
            End If
            If (x > 106) And (x < 152) Then ' *-*-*-*-*-*-*-*-*-*- LISTBOX SOURCE *-*-*-*-*-*-*---
                'del1 one song
                Dim index = Box1.SelectedIndex
                If index > -1 Then
                    Box1.Items.RemoveAt(index)
                    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
                    Box11.Items.RemoveAt(index)
                    If Box1.Items.Count = index Then index = index - 1
                    If Box1.Items.Count > 0 Then Box1.SetSelected(index, True)
                End If
            End If
            If (x > 602) And (x < 652) Then
                'del2 one song
                Dim index = Box2.SelectedIndex
                If index > -1 Then
                    Box2.Items.RemoveAt(index)
                    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
                    Box22.Items.RemoveAt(index)
                    If Box2.Items.Count = index Then index = index - 1
                    If Box2.Items.Count > 0 Then Box2.SetSelected(index, True)
                End If
            End If
            If (x > 175) And (x < 198) Then
                'up1
                Dim index As Integer
                Dim sm As String
                index = Box1.SelectedIndex
                If index > 0 Then
                    sm = Box1.SelectedItem
                    Box1.Items(index) = Box1.Items(index - 1)
                    Box1.Items(index - 1) = sm
                    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
                    sm = Box11.Items(index)
                    Box11.Items(index) = Box11.Items(index - 1)
                    Box11.Items(index - 1) = sm
                    Box1.SetSelected(index - 1, True)
                End If
            End If
            If (x > 670) And (x < 700) Then
                'up2
                Dim index As Integer
                Dim sm As String
                index = Box2.SelectedIndex
                If index > 0 Then
                    sm = Box2.SelectedItem
                    Box2.Items(index) = Box2.Items(index - 1)
                    Box2.Items(index - 1) = sm
                    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
                    sm = Box22.Items(index)
                    Box22.Items(index) = Box22.Items(index - 1)
                    Box22.Items(index - 1) = sm
                    Box2.SetSelected(index - 1, True)
                End If
            End If
            If (x > 206) And (x < 229) Then
                'dwn1
                Dim index As Integer
                Dim sm As String
                index = Box1.SelectedIndex
                If index < (Box1.Items.Count - 1) Then
                    sm = Box1.SelectedItem
                    Box1.Items(index) = Box1.Items(index + 1)
                    Box1.Items(index + 1) = sm
                    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
                    sm = Box11.Items(index)
                    Box11.Items(index) = Box11.Items(index + 1)
                    Box11.Items(index + 1) = sm
                    Box1.SetSelected(index + 1, True)
                End If
            End If
            If (x > 698) And (x < 730) Then
                'dwn2
                Dim index As Integer
                Dim sm As String
                index = Box2.SelectedIndex
                If index < (Box2.Items.Count - 1) Then
                    sm = Box2.SelectedItem
                    Box2.Items(index) = Box2.Items(index + 1)
                    Box2.Items(index + 1) = sm
                    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
                    sm = Box22.Items(index)
                    Box22.Items(index) = Box22.Items(index + 1)
                    Box22.Items(index + 1) = sm
                    Box2.SetSelected(index + 1, True)
                End If
            End If
            If (x > 254) And (x < 316) Then
                Dim ori As String
                If Box1.SelectedIndex > -1 Then
                    ori = Box1.Items(Box1.SelectedIndex)
                    Edit1.Text = Mid(ori, 10, Len(ori))
                    Edit1.Visible = True
                    Edit1.Select()
                End If
            End If
            If (x > 746) And (x < 817) Then
                Dim ori As String
                If Box2.SelectedIndex > -1 Then
                    ori = Box2.Items(Box2.SelectedIndex)
                    Edit2.Text = Mid(ori, 10, Len(ori))
                    Edit2.Visible = True
                    Edit2.Select()
                End If
            End If
            If (x > 335) And (x < 376) Then
                'clear1
                Box1.Items.Clear()
                '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
                Box11.Items.Clear()
            End If
            If (x > 827) And (x < 879) Then
                'clear2
                Box2.Items.Clear()
                '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
                Box22.Items.Clear()
            End If
            If (x > 392) And (x < 435) Then
                '**** LOAD A PLAYLIST ****
                PlyTimer.Enabled = False
                ListLoad(True)
                PlyTimer.Enabled = True
            End If
            If (x > 883) And (x < 935) Then
                '**** LOAD B PLAYLIST ****
                PlyTimer.Enabled = False
                ListLoad(False)
                PlyTimer.Enabled = True
            End If
            If (x > 441) And (x < 483) Then
                'save1
                Dim file As System.IO.StreamWriter
                Dim Sz As String = ""
                Dim t As Long
                PlyTimer.Enabled = False
                If Box1.Items.Count > 0 Then
                    If SaveFileDialog1.ShowDialog() = 1 Then
                        file = My.Computer.FileSystem.OpenTextFileWriter(SaveFileDialog1.FileName, False)
                        file.WriteLine("#EXTM3U")
                        For i As Integer = 0 To Val(Box1.Items.Count) - 1
                            Sz = Box1.Items(i)
                            If Mid(Sz, 1, 1) > "9" Then
                                t = -1
                            Else
                                t = 60 * 60 * Val(Mid(Sz, 1, 2))
                                t = t + 60 * (Mid(Sz, 4, 2))
                                t = t + (Mid(Sz, 7, 2))
                            End If
                            file.WriteLine("#EXTINF:" & t & "," & Trim(Mid(Sz, 10, Len(Sz))))
                            file.WriteLine(Box11.Items(i))
                        Next
                        file.Close()
                    End If
                End If
                PlyTimer.Enabled = True
            End If
            If x > 933 Then
                'save2
                Dim file As System.IO.StreamWriter
                Dim Sz As String
                Dim t As Long
                PlyTimer.Enabled = False
                If Box2.Items.Count > 0 Then
                    If SaveFileDialog1.ShowDialog() = 1 Then
                        file = My.Computer.FileSystem.OpenTextFileWriter(SaveFileDialog1.FileName, False)
                        file.WriteLine("#EXTM3U")
                        For i As Integer = 0 To Val(Box2.Items.Count) - 1
                            Sz = Box2.Items(i)
                            If Mid(Sz, 1, 1) > "9" Then
                                t = -1
                            Else
                                t = 60 * 60 * Val(Mid(Sz, 1, 2))
                                t = t + 60 * (Mid(Sz, 4, 2))
                                t = t + (Mid(Sz, 7, 2))
                            End If
                            file.WriteLine("#EXTINF:" & t & "," & Trim(Mid(Sz, 10, Len(Sz))))
                            file.WriteLine(Box22.Items(i))
                        Next
                        file.Close()
                    End If
                End If
                PlyTimer.Enabled = True
            End If
        End If

        '-------------------------------------------------------------------------------
        If (x > 405) And (x < 586) And (y < 100) Then ' # # # # ||||| OPACITY -----
            Opacity = 1 - ((x - 420) / 165) + 0.15
        End If
        '  Text = x & " " & y & " - " & s
        '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    End Sub
    Private Sub Box1_DoubleClick(sender As Object, e As EventArgs) Handles Box1.DoubleClick
        PlayMCI(1)
    End Sub
    Private Sub Box2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Box2.MouseDoubleClick
        PlayMCI(2)
    End Sub
    Private Function Szhms(t As Long) As String
        '###################### 00:00:00 format string ###########
        Dim sz As String = "Web Song " '********************************* 'Web Song ' ************** !!!!!
        Dim TT As Long
        Dim HH As Long
        Dim MM As Long
        Dim Ts As String
        Dim Hs As String
        Dim Ms As String
        TT = t
        If t > 0 Then
            MM = Fix(TT / 60) : TT = TT - 60 * MM
            HH = Fix(MM / 60) : MM = MM - 60 * HH : TT = Fix(TT - 60 * 60 * HH)
            If TT < 1 Then TT = 0
            Hs = "0" + Trim(HH) : If Len(Hs) > 2 Then Hs = Mid(Hs, 2, 2)
            Ms = "0" + Trim(MM) : If Len(Ms) > 2 Then Ms = Mid(Ms, 2, 2)
            Ts = "0" + Trim(TT) : If Len(Ts) > 2 Then Ts = Mid(Ts, 2, 2)
            sz = Hs & ":" & Ms & ":" & Ts '********************************** or time *************
        End If
        Return sz
    End Function
    Private Sub AddMusicFile(A As Boolean, mf As String)
        Dim l As Integer
        Dim x As String
        Dim RetVal As Integer
        Dim ReturnData As String = Space(128)
        Dim Fl As Integer
        Dim fLen As Long
        Dim Rd, Ru As Byte
        Dim Sz As String = ""
        Dim s As String = ""
        Dim Tag As String = ""
        Dim j As Integer
        Dim cp As Short = 0
        Dim Llng As String = "0"
        Dim LAdr As String = ""
        Dim LArt As String = ""
        Dim LGen = ""
        l = InStrRev(mf, ".")
        x = UCase(Mid(mf, l + 1))
        If x = "MP3" Or x = "WAV" Or x = "WMA" Or x = "MID" Then
            RetVal = mciSendString("open " & Chr(34) & mf & Chr(34) & " type mpegvideo alias song", vbNullString, 0, 0)
            If RetVal = 0 Then
                RetVal = mciSendString("status song length", ReturnData, 128, 0)
                RetVal = mciSendString("close song", 0, 0, 0)
                fLen = Val(ReturnData) / 1000
                If fLen < 1 Then fLen = 1
                Llng = Szhms(fLen)
                Fl = FreeFile()
                FileOpen(Fl, mf, Mode:=OpenMode.Binary)
                fLen = LOF(Fl) : If fLen < 500 Then GoTo Clos
                '#################### ID3V2 TAG #######################
                Sz = ""
                For j = 1 To 3 '- ID3 - ID3V2
                    FileGet(Fl, Rd)
                    Sz = Sz + Chr(Rd)
                Next j
                If Sz <> "ID3" Then GoTo ID3V1PLUS '=====> not ID3
                For j = 1 To 7 : FileGet(Fl, Rd) : Next j
NxFrame:
                Sz = ""
                For j = 1 To 4 : FileGet(Fl, Rd) : Sz = Sz + Chr(Rd) : Next j
                Select Case Sz
                    Case "TIT2" : Tag = "TITLE"
                    Case "TPE1" : Tag = "ARTIST"
                    Case "TCON" : Tag = "GENRE"
                    Case Else
                        Tag = ""
                        If (Sz < "A000") Or (Sz > "ZZZZ") Then GoTo ID3V1PLUS
                End Select
                For j = 1 To 3 : FileGet(Fl, Rd) : Next j
                FileGet(Fl, Rd) : l = Rd - 1
                For j = 1 To 2 : FileGet(Fl, Rd) : Next j
                FileGet(Fl, Rd) : cp = Rd ' - KÓDOLÁS N -
                Sz = ""
                If cp = 0 Then
                    For j = 1 To l
                        FileGet(Fl, Rd)
                        If Rd Then Sz = Sz + Chr(Rd)
                    Next j
                Else
                    For j = 1 To 2
                        FileGet(Fl, Rd)
                    Next j
                    For j = 3 To l Step 2
                        FileGet(Fl, Rd) : s = Chr(Rd)
                        FileGet(Fl, Ru)
                        If Ru = 1 Then
                            If Rd = 80 Then s = "Ő" : GoTo karok
                            If Rd = 81 Then s = "ő" : GoTo karok
                            If Rd = 112 Then s = "Ű" : GoTo karok
                            If Rd = 113 Then s = "ű" : GoTo karok
                            ' MsgBox("CHR " & Rd)
karok:
                        End If
                        If s <> Chr(0) Then Sz = Sz + s
                    Next j
                End If
                If Tag = "GENRE" Then LGen = Sz
                If Tag = "TITLE" Then LAdr = Sz
                If Tag = "ARTIST" Then LArt = Sz
                GoTo NxFrame
ID3V1PLUS:
                '#################### ID3V1 TAG+ #######################
                Sz = ""
                Seek(Fl, fLen - 226)
                For j = 1 To 4 '- TAG+ - ID3V1
                    FileGet(Fl, Rd)
                    Sz = Sz + Chr(Rd)
                Next j
                If Sz <> "TAG+" Then GoTo ID3V1TAG
                Sz = "" ' -  Title - ID3V1 +
                For j = 1 To 60
                    FileGet(Fl, Rd)
                    If Rd Then Sz = Sz + Chr(Rd)
                Next j
                If LAdr = "" Then LAdr = Sz
                Sz = "" ' -  Artist - ID3V1 +
                For j = 1 To 60
                    FileGet(Fl, Rd)
                    If Rd Then Sz = Sz + Chr(Rd)
                Next j
                If LArt = "" Then LArt = Sz
                For j = 1 To 60 : FileGet(Fl, Rd) : Next j ' -  Album - ID3V1 +
                FileGet(Fl, Rd) ' SPEED 0 = unset, 1 = lassú, 2 = közepes, 3 = gyors, 4 = hardcore
                Sz = "" ' -  Genre+ - ID3V1 +
                For j = 1 To 30
                    FileGet(Fl, Rd)
                    If Rd Then Sz = Sz + Chr(Rd)
                Next j
                If LGen = "" Then LGen = Sz
ID3V1TAG:
                '#################### ID3V1 TAG #######################
                Sz = ""
                Seek(Fl, fLen - 127)
                For j = 1 To 3 '- TAG - ID3V1
                    FileGet(Fl, Rd)
                    Sz = Sz + Chr(Rd)
                Next j
                If Sz <> "TAG" Then GoTo Clos
                Sz = "" ' -  Title - ID3V1 
                For j = 1 To 30
                    FileGet(Fl, Rd)
                    If Rd Then Sz = Sz + Chr(Rd)
                Next j
                LAdr = Sz
                Sz = "" ' -  Artist - ID3V1
                For j = 1 To 30
                    FileGet(Fl, Rd)
                    If Rd Then Sz = Sz + Chr(Rd)
                    LArt = Sz
                Next j
                Sz = "" ' -  ALbum - ID3V1
                For j = 1 To 30
                    FileGet(Fl, Rd)
                    If Rd Then Sz = Sz + Chr(Rd)
                Next j
                Sz = "" ' -  Year - ID3V1
                For j = 1 To 4
                    FileGet(Fl, Rd)
                    If Rd Then Sz = Sz + Chr(Rd)
                Next j
                Sz = "" ' -  Comment - ID3V1
                For j = 1 To 28
                    FileGet(Fl, Rd)
                    If Rd Then Sz = Sz + Chr(Rd)
                Next j
                FileGet(Fl, Rd)
                If Rd = 0 Then
                    FileGet(Fl, Rd)
                Else
                    Sz = Sz + Chr(Rd) '- Comment Tail -
                    FileGet(Fl, Rd)
                    If Rd Then Sz = Sz + Chr(Rd)
                End If
                FileGet(Fl, Rd)
                Sz = ""
                Select Case Rd
                    Case 54 : Sz = "Standard"
                    Case 95 : Sz = "Slow Waltz"
                    Case 113 : Sz = "Tango"
                    Case 66 : Sz = "Waltz"
                    Case 111 : Sz = "Slowfox"
                    Case 85 : Sz = "Quickstep"
                    Case 0 : Sz = "Blues"
                    Case 83 : Sz = "Swing"
                    Case 86 : Sz = "Latin"
                    Case 114 : Sz = "Samba"
                    Case 142 : Sz = "Cha-Cha"
                    Case 135 : Sz = "Rumba"
                    Case 123 : Sz = "Paso Doble"
                    Case 78 : Sz = "Jive"
                    Case 143 : Sz = "Salsa"
                    Case 4 : Sz = "Disco"
                    Case 3 : Sz = "Dance"
                    Case 125 : Sz = "Ballroom"
                End Select
                If LGen = "" Then LGen = Sz
Clos: '= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
                FileClose(Fl) ' ****** enfin from filename ****
                If LAdr = "" Then
                    Sz = mf
                    l = InStrRev(Sz, ".")
                    Sz = Mid(Sz, 1, l - 1)
                    l = InStrRev(Sz, "\") + 1
                    Sz = Mid(Sz, l)
                    LAdr = Sz
                End If
                If LArt <> "" Then LArt = LArt & " - "
                ' : : : : : : : : : : : : : : : : : : : : : : : :
                If LGen <> "" Then
                    If A Then
                        Box1.Items.Add(Llng & " " & LArt & LAdr & " {" & LGen & "}")
                    Else
                        Box2.Items.Add(Llng & " " & LArt & LAdr & " {" & LGen & "}")
                    End If
                Else
                    If A Then
                        Box1.Items.Add(Llng & " " & LArt & LAdr)
                    Else
                        Box2.Items.Add(Llng & " " & LArt & LAdr)
                    End If
                End If
                '\\\\\\\\\\\\\\\\\\\\\
                If A Then
                    Box11.Items.Add(mf)
                Else
                    Box22.Items.Add(mf)
                End If
            End If
        End If
    End Sub
    Private Sub ListLoad(A As Boolean)
        Dim Fl As Integer
        Dim Sz As String
        Dim l As Short
        Dim t As Long
        PlyTimer.Enabled = False
        If (OpenFileDialog2.ShowDialog() = DialogResult.OK) Then
            If LCase(Mid(OpenFileDialog2.FileName, Len(OpenFileDialog2.FileName) - 2, 3)) = "m3u" Then
                Fl = FreeFile()
                Dim file As System.IO.StreamReader
                file = My.Computer.FileSystem.OpenTextFileReader(OpenFileDialog2.FileName)

                While Not file.EndOfStream
                    Sz = file.ReadLine()
                    If Sz <> "#EXTM3U" Then
                        If Mid(Sz, 1, 1) = "#" Then
                            Sz = Mid(Sz, 9, Len(Sz)) '#EXTINF
                            l = InStr(Sz, ",") - 1
                            t = Mid(Sz, 1, l) '------- seconds
                            Sz = Mid(Sz, l + 2, Len(Sz))

                            If A Then
                                Box1.Items.Add(Szhms(t) & " " & Sz)
                            Else
                                Box2.Items.Add(Szhms(t) & " " & Sz)
                            End If
                        Else
                            '\\\\\\\\\\\\\\\\\\\\\\
                            If A Then
                                Box11.Items.Add(Sz)
                            Else
                                Box22.Items.Add(Sz)
                            End If
                        End If
                    End If
                End While
                file.Close()
            End If
        End If
        PlyTimer.Enabled = True
    End Sub
    Private Sub Box1_KeyDown(sender As Object, e As KeyEventArgs) Handles Box1.KeyDown
        If Art Then
            Select Case e.KeyValue
                Case Keys.MediaPlayPause
                    PauseMCI(1)
                Case Keys.Space
                    PauseMCI(1)
                Case Keys.MediaPreviousTrack
                    PlayNext(True, False)
                Case Keys.MediaNextTrack
                    PlayNext(True, True)
                Case Keys.MediaStop
                    StopMCI(1)
                Case Keys.Play
                    PlayMCI(1)
                Case Keys.Enter
                    PlayMCI(1)
                Case Keys.Add
                    If Speed1.Value < 150 Then
                        Speed1.Value = Speed1.Value + 5
                    End If
                Case Keys.Subtract
                    If Speed1.Value > 50 Then
                        Speed1.Value = Speed1.Value - 5
                    End If
            End Select
        Else
            Select Case e.KeyValue
                Case Keys.MediaPlayPause
                    PauseMCI(2)
                Case Keys.Space
                    PauseMCI(2)
                Case Keys.MediaPreviousTrack
                    PlayNext(False, False)
                Case Keys.MediaNextTrack
                    PlayNext(False, True)
                Case Keys.MediaStop
                    StopMCI(2)
                Case Keys.Play
                    PlayMCI(2)
                Case Keys.Enter
                    PlayMCI(2)
                Case Keys.Add
                    If Speed2.Value < 150 Then
                        Speed2.Value = Speed2.Value + 5
                    End If
                Case Keys.Subtract
                    If Speed2.Value > 50 Then
                        Speed2.Value = Speed2.Value - 5
                    End If
            End Select
        End If
        Select Case e.KeyValue
            Case Keys.P
                Paso_Click(sender, e)
            Case Keys.W
                Bell_Click(sender, e)
            Case Keys.Escape
                If Pict0.Visible Then
                    Pict0_Click(sender, e)
                Else
                    BckTime_Click(sender, e)
                End If
            Case Keys.R
                Rpt1_Click(sender, e)
            Case Keys.L
                Lst1_Click(sender, e)
        End Select
    End Sub
    Private Sub Box2_KeyDown(sender As Object, e As KeyEventArgs) Handles Box2.KeyDown
        Box1_KeyDown(sender, e)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '#################  FORM LOAD INIT #################
        Dim file As System.IO.StreamReader
        Dim Fl As Integer = 0
        Dim Sz As String
        Dim l As Short
        Dim t As Long
        Dims()
        '**** when form loading ************* INITIALIZE =============================== 
        If Dir("B.m3u") <> "" Then
            file = My.Computer.FileSystem.OpenTextFileReader("B.m3u") '******** B !!! ********
            While Not file.EndOfStream
                Sz = file.ReadLine()
                If Sz <> "#EXTM3U" Then
                    If Mid(Sz, 1, 1) = "#" Then
                        Sz = Mid(Sz, 9, Len(Sz)) '#EXTINF
                        l = InStr(Sz, ",") - 1
                        t = Mid(Sz, 1, l) '------- seconds ( web -1)
                        Sz = Trim(Mid(Sz, l + 2, Len(Sz)))
                        Box2.Items.Add(Szhms(t) & " " & Sz)
                    Else
                        '\\\\\\\\\\\\\\\\\\\\\\
                        Box22.Items.Add(Sz)
                    End If
                End If
            End While
            Box2.SetSelected(0, True)
            Box2.Select()
            file.Close()
            Bpdl = True '****** sikerült betölteni : kilépéskor már nem kell automatikusan menteni
        End If ' Dir B.m3u
        If Dir("A.m3u") <> "" Then
            file = My.Computer.FileSystem.OpenTextFileReader("A.m3u")
            While Not file.EndOfStream
                Sz = file.ReadLine()
                If Sz <> "#EXTM3U" Then
                    If Mid(Sz, 1, 1) = "#" Then
                        Sz = Mid(Sz, 9, Len(Sz)) '#EXTINF
                        If Mid(Sz, 1, 1) > "9" Then
                            t = -1
                        Else
                            l = InStr(Sz, ",") - 1
                            t = Mid(Sz, 1, l) '------- seconds
                        End If
                        Sz = Trim(Mid(Sz, l + 2, Len(Sz)))
                        Box1.Items.Add(Szhms(t) & " " & Sz)
                    Else
                        '\\\\\\\\\\\\\\\\\\\\\\ path/link sor
                        Box11.Items.Add(Sz)
                    End If '# (extinf)
                End If '#EXT3MU
            End While
            Box1.SetSelected(0, True)
            Box1.Select()
            file.Close()
            APdl = True '****** sikerült betölteni : kilépéskor már nem kell automatikusan menteni
        End If
        '----------- URL ------------- #### INI file ####
        If Dir("DancePlayer.ini ") <> "" Then
            file = My.Computer.FileSystem.OpenTextFileReader("DancePlayer.ini")
            While Not file.EndOfStream
                Sz = file.ReadLine()
                If LCase(Sz) = "[default]" Then
                    If Not file.EndOfStream Then
                        Sz = file.ReadLine()
                        Form2.TextBox1.Text = Sz
                    End If
                End If
                If LCase(Sz) = "[radio]" Then
                    If Not file.EndOfStream Then
                        Sz = file.ReadLine()
                        Form2.Radio.Text = Sz
                    End If
                End If
            End While
            file.Close() '--- URL ---
        End If
        '###### OTHER INITS #####
        Text = "♪ Dance Player ♫"
        Opacity = 0.92
        Poz1.ForeColor = System.Drawing.Color.Black
        Poz2.ForeColor = System.Drawing.Color.Black
        NowTime.Text = "♪ ← → ♫"
        PlyTimer.Enabled = True
        Form2.Timer1.Enabled = True
    End Sub
    Private Sub Edit1_Leave(sender As Object, e As EventArgs) Handles Edit1.Leave
        TextEdited(True)
    End Sub
    Private Sub Edit2_Leave(sender As Object, e As EventArgs) Handles Edit2.Leave
        TextEdited(False)
    End Sub
    Private Sub Edit1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Edit1.KeyPress
        'EditA
        If e.KeyChar = Chr(13) Then
            TextEdited(True)
        End If
    End Sub
    Private Sub Edit2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Edit2.KeyPress
        'EditA
        If e.KeyChar = Chr(13) Then
            TextEdited(False)
        End If
    End Sub
    Sub TextEdited(A As Boolean)
        Dim Ori As String
        If A Then
            If Box1.SelectedIndex > -1 Then
                Edit1.Text = Trim(Edit1.Text)
                If Edit1.Text <> "" Then
                    Ori = Mid(Box1.Items(Box1.SelectedIndex), 1, 9)
                    Box1.Items(Box1.SelectedIndex) = Ori & Edit1.Text
                End If
            End If
            Edit1.Text = ""
            Edit1.Visible = False
            Box1.Select()
        Else
            If Box2.SelectedIndex > -1 Then
                Edit2.Text = Trim(Edit2.Text)
                If Edit2.Text <> "" Then
                    Ori = Mid(Box2.Items(Box2.SelectedIndex), 1, 9)
                    Box2.Items(Box2.SelectedIndex) = Ori & Edit2.Text
                End If
            End If
            Edit2.Text = ""
            Edit2.Visible = False
            Box2.Select()
        End If
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dims()
    End Sub
    Private Sub Dims()
        PlyTimer.Enabled = False
        '--- FONTS ----
        Dim FntSize As Short = ((Height / 50) + (Width / 100)) / 2
        GoWeb.Font = New Font("Webdings", 1.5 * FntSize)
        GoWeb.Font = New Font(GoWeb.Font, FontStyle.Bold)
        BoxTxt1.Font = New Font("Microsoft Sans Serif", FntSize)
        BoxTxt1.Font = New Font(BoxTxt1.Font, FontStyle.Bold)
        BoxTxt2.Font = BoxTxt1.Font
        Edit1.Font = BoxTxt1.Font
        Edit1.Font = BoxTxt1.Font
        Edit2.Font = BoxTxt1.Font
        Box1.Font = BoxTxt1.Font
        Box2.Font = BoxTxt1.Font
        Speaker1.Font = GoWeb.Font
        Speaker2.Font = GoWeb.Font
        Rpt1.Font = GoWeb.Font
        One1.Font = New Font("Wingdings 2", 1.5 * FntSize)
        One1.Font = New Font(One1.Font, FontStyle.Bold)
        Lst1.Font = One1.Font
        Sol1.Font = GoWeb.Font
        Rpt2.Font = GoWeb.Font
        One2.Font = One1.Font
        Lst2.Font = One1.Font
        Sol2.Font = GoWeb.Font
        TipTxt1.Font = BoxTxt1.Font
        TipTxt2.Font = BoxTxt1.Font
        NowTxt1.Font = BoxTxt1.Font
        NowTxt2.Font = BoxTxt1.Font
        TimTxt1.Font = BoxTxt1.Font
        TimTxt2.Font = BoxTxt1.Font
        NowTime.Font = New Font("Tahoma", 3.3 * FntSize)
        NowTime.Font = New Font(NowTime.Font, FontStyle.Bold)
        BckTime.Font = New Font("Tahoma", 3.9 * FntSize)
        BckTime.Font = New Font(BckTime.Font, FontStyle.Bold)
        BackCtrl.Font = New Font("Tahoma", 2 * FntSize)
        SysTime.Font = BackCtrl.Font
        SysTime.Font = New Font(SysTime.Font, FontStyle.Bold)
        WaitCtrl.Font = SysTime.Font
        Speed1.Font = SysTime.Font
        Speed2.Font = SysTime.Font

        '---- TOPS ----
        GoWeb.Top = 0.4 * Height - (GoWeb.Height / 2) + 1
        BoxTxt1.Top = GoWeb.Top + FntSize / 4
        TipTxt1.Top = BoxTxt1.Top
        BoxTxt2.Top = BoxTxt1.Top
        TipTxt2.Top = BoxTxt1.Top
        Edit1.Top = BoxTxt1.Top
        Edit2.Top = BoxTxt1.Top
        Box1.Top = GoWeb.Top + BoxTxt1.Height + (Height / 80) + Poz1.Height / 1.5
        Box2.Top = Box1.Top
        NowTxt1.Top = Height / 80
        TimTxt1.Top = NowTxt1.Top
        NowTxt2.Top = NowTxt1.Top
        TimTxt2.Top = NowTxt1.Top
        VolCtrl1.Top = NowTxt1.Top + NowTxt1.Height + FntSize / 4
        VolCtrl2.Top = VolCtrl1.Top
        Speaker1.Top = VolCtrl1.Top
        Speaker2.Top = VolCtrl1.Top
        Rpt1.Top = 0.14 * Height
        One1.Top = Rpt1.Top
        Rpt2.Top = Rpt1.Top
        One2.Top = Rpt1.Top
        Lst1.Top = 0.22 * Height
        Sol1.Top = Lst1.Top
        Lst2.Top = Lst1.Top
        Sol2.Top = Lst1.Top
        NowTime.Top = Speaker1.Top + FntSize / 50
        BckTime.Top = NowTime.Top + NowTime.Height
        BackCtrl.Top = BckTime.Top + 1.5 * FntSize
        WaitCtrl.Top = BackCtrl.Top
        SysTime.Top = BoxTxt1.Top - SysTime.Height
        Speed1.Top = BoxTxt1.Top - Speed1.Height
        Speed2.Top = Speed1.Top
        Paso.Top = Speed1.Top
        Bell.Top = Speed1.Top
        Poz1.Top = Box1.Top - Poz1.Height + 1
        Poz2.Top = Poz1.Top
        Pict1.Top = VolCtrl1.Top
        Pict2.Top = VolCtrl1.Top

        '---- WIDTHS ----
        BoxTxt1.Width = 0.415 * Width
        TipTxt1.Width = 0.05 * Width
        BoxTxt2.Width = 0.396 * Width
        TipTxt2.Width = TipTxt1.Width
        Box2.Width = BoxTxt2.Width + TipTxt2.Width
        Edit1.Width = 0.5 * Width
        Edit2.Width = Edit1.Width
        TimTxt1.Width = FntSize * 7
        NowTxt1.Width = 0.32 * Width
        NowTxt2.Width = NowTxt1.Width
        TimTxt2.Width = TimTxt1.Width
        WaitCtrl.Width = 6 * FntSize
        Speed1.Width = 7.2 * FntSize
        Speed2.Width = Speed1.Width
        Paso.Width = 3 * FntSize
        Bell.Width = 3 * FntSize
        Pict1.Width = 0.16 * Width
        Pict2.Width = Pict1.Width

        '---- LEFTS -----
        GoWeb.Left = (Width / 2) - 1.1 * FntSize
        BoxTxt1.Left = 15
        Box1.Left = BoxTxt1.Left
        BoxTxt2.Left = GoWeb.Left + GoWeb.Width + Width / 200
        Box2.Left = BoxTxt2.Left
        TipTxt1.Left = BoxTxt1.Left + BoxTxt1.Width
        TipTxt2.Left = BoxTxt2.Left + BoxTxt2.Width
        Edit1.Left = BoxTxt1.Left
        Edit2.Left = BoxTxt2.Left
        VolCtrl1.Left = BoxTxt1.Left
        VolCtrl2.Left = Width - 28 - Width / 95
        Speaker1.Left = 0.1 * Width
        Speaker2.Left = 0.87 * Width
        Rpt1.Left = 0.06 * Width
        Lst1.Left = Rpt1.Left
        One1.Left = 0.099 * Width
        Sol1.Left = One1.Left
        Rpt2.Left = 0.874 * Width
        Lst2.Left = Rpt2.Left
        One2.Left = 0.914 * Width
        Sol2.Left = One2.Left
        NowTxt1.Left = BoxTxt1.Left
        TimTxt1.Left = NowTxt1.Left + NowTxt1.Width
        NowTxt2.Left = Width - NowTxt2.Width - TimTxt2.Width - FntSize * 2
        TimTxt2.Left = NowTxt2.Left + NowTxt2.Width
        NowTime.Left = Width / 2 - NowTime.Width / 2
        BckTime.Left = Width / 2 - BckTime.Width / 2
        SysTime.Left = Width / 2 - SysTime.Width / 2 - 1
        BackCtrl.Left = BckTime.Left - 2 * BackCtrl.Width
        WaitCtrl.Left = BckTime.Left + BckTime.Width
        Speed1.Left = 4 * FntSize
        Speed2.Left = Width - Speed2.Width - 5 * FntSize
        Paso.Left = SysTime.Left - 3.5 * FntSize
        Bell.Left = SysTime.Left + SysTime.Width
        Poz1.Left = Box1.Left
        Poz2.Left = Box2.Left
        Pict1.Left = Speaker1.Left + 1.2 * Speaker1.Width + 2 * FntSize
        Pict2.Left = Speaker2.Left - Pict2.Width - 2 * FntSize

        '---- HEIGHTS ----
        Box1.Height = Height - Box1.Top - 50
        Box2.Height = Box1.Height
        VolCtrl1.Height = BoxTxt1.Top - NowTxt1.Top - 3 * FntSize
        VolCtrl2.Height = VolCtrl1.Height
        Paso.Height = 3 * FntSize
        Bell.Height = 3 * FntSize
        Pict1.Height = 0.7 * VolCtrl1.Height
        Pict2.Height = Pict1.Height

        '---- ! ----
        Box1.Width = Width - 2 * Box1.Left - GoWeb.Left
        Pict0.Width = WaitCtrl.Left - BackCtrl.Left + 7.1 * FntSize
        Pict0.Left = BackCtrl.Left - 1.55 * FntSize
        Pict0.Top = Pict1.Top + FntSize
        Pict0.Height = Speed1.Top - Pict1.Top - FntSize / 2
        If Pict0.Visible Then
            NowTime.Font = BackCtrl.Font
            NowTime.Top = NowTxt1.Top
            NowTime.Left = Width / 2 - NowTime.Width / 2
        End If
        PlyTimer.Enabled = True
    End Sub
    Private Sub Pict0_Click(sender As Object, e As EventArgs) Handles Pict0.Click
        PictOff(True)
    End Sub
    Private Sub BckTime_Click(sender As Object, e As EventArgs) Handles BckTime.Click
        PictOff(False)
    End Sub
    Private Sub NowTime_Click(sender As Object, e As EventArgs) Handles NowTime.Click
        PictOff(False)
    End Sub
    Sub PictOff(A As Boolean)
        Pict0.Visible = Not A
        BackCtrl.Visible = A
        BckTime.Visible = A
        Bell.Visible = A
        WaitCtrl.Visible = A
        Paso.Visible = A
        Bell.Visible = A
        Dims()
    End Sub
    Private Sub Speaker1_Click(sender As Object, e As EventArgs) Handles Speaker1.Click
        If Speaker1.ForeColor = System.Drawing.Color.Lime Then
            Volreg(True, 100 - VolCtrl1.Value)
            Speaker1.ForeColor = System.Drawing.Color.Salmon
        Else
            Volreg(True, 0)
            Speaker1.ForeColor = System.Drawing.Color.Lime
        End If
    End Sub
    Private Sub Speaker2_Click(sender As Object, e As EventArgs) Handles Speaker2.Click
        If Speaker2.ForeColor = System.Drawing.Color.Lime Then
            Volreg(False, 100 - VolCtrl2.Value)
            Speaker2.ForeColor = System.Drawing.Color.CornflowerBlue
        Else
            Volreg(False, 0)
            Speaker2.ForeColor = System.Drawing.Color.Lime
        End If
    End Sub
    Private Sub VolCtrl1_Scroll(sender As Object, e As ScrollEventArgs) Handles VolCtrl1.Scroll
        Volreg(True, 100 - VolCtrl1.Value)
        Speaker1.ForeColor = System.Drawing.Color.Salmon
    End Sub
    Private Sub VolCtrl2_Scroll(sender As Object, e As ScrollEventArgs) Handles VolCtrl2.Scroll
        Volreg(False, 100 - VolCtrl2.Value)
        Speaker1.ForeColor = System.Drawing.Color.CornflowerBlue
    End Sub
    Sub Volreg(A As Boolean, P As Integer)
        '###################### SET VOLUME ########################
        Dim RetString As String = Space$(128)
        Dim retVal As Integer
        If A Then '/// A
            retVal = mciSendString("setaudio asong volume To " & P * 10, RetString, 128, 0)
        Else '/// /// B
            retVal = mciSendString("setaudio bsong volume To " & P * 10, RetString, 128, 0)
        End If
    End Sub
    Private Sub Rpt1_Click(sender As Object, e As EventArgs) Handles Rpt1.Click
        If Rpt1.ForeColor = System.Drawing.Color.Lime Then
            Rpt1.ForeColor = System.Drawing.Color.Salmon
            One1.ForeColor = System.Drawing.Color.Lime
        Else
            Rpt1.ForeColor = System.Drawing.Color.Lime
            One1.ForeColor = System.Drawing.Color.Salmon
        End If
    End Sub
    Private Sub Rpt2_Click(sender As Object, e As EventArgs) Handles Rpt2.Click
        If Rpt2.ForeColor = System.Drawing.Color.Lime Then
            Rpt2.ForeColor = System.Drawing.Color.CornflowerBlue
            One2.ForeColor = System.Drawing.Color.Lime
        Else
            Rpt2.ForeColor = System.Drawing.Color.Lime
            One2.ForeColor = System.Drawing.Color.CornflowerBlue
        End If
    End Sub
    Private Sub One1_Click(sender As Object, e As EventArgs) Handles One1.Click
        Rpt1_Click(sender, e)
    End Sub
    Private Sub One2_Click(sender As Object, e As EventArgs) Handles One2.Click
        Rpt2_Click(sender, e)
    End Sub
    Private Sub Lst1_Click(sender As Object, e As EventArgs) Handles Lst1.Click
        If Lst1.ForeColor = System.Drawing.Color.Lime Then
            Lst1.ForeColor = System.Drawing.Color.Salmon
            Sol1.ForeColor = System.Drawing.Color.Lime
        Else
            Lst1.ForeColor = System.Drawing.Color.Lime
            Sol1.ForeColor = System.Drawing.Color.Salmon
        End If
    End Sub
    Private Sub Lst2_Click(sender As Object, e As EventArgs) Handles Lst2.Click
        If Lst2.ForeColor = System.Drawing.Color.Lime Then
            Lst2.ForeColor = System.Drawing.Color.CornflowerBlue
            Sol2.ForeColor = System.Drawing.Color.Lime
        Else
            Lst2.ForeColor = System.Drawing.Color.Lime
            Sol2.ForeColor = System.Drawing.Color.CornflowerBlue
        End If
    End Sub
    Private Sub Sol1_Click(sender As Object, e As EventArgs) Handles Sol1.Click
        Lst1_Click(sender, e)
    End Sub
    Private Sub Sol2_Click(sender As Object, e As EventArgs) Handles Sol2.Click
        Lst2_Click(sender, e)
    End Sub
    Private Sub Speed1_MouseClick(sender As Object, e As MouseEventArgs) Handles Speed1.MouseClick
        Speed1.Value = 100
    End Sub
    Private Sub Speed2_MouseClick(sender As Object, e As MouseEventArgs) Handles Speed2.MouseClick
        Speed2.Value = 100
    End Sub
    Private Sub Speed1_ValueChanged(sender As Object, e As EventArgs) Handles Speed1.ValueChanged
        SpeedSet(True, Speed1.Value)
    End Sub
    Private Sub Speed2_ValueChanged(sender As Object, e As EventArgs) Handles Speed2.ValueChanged
        SpeedSet(False, Speed2.Value)
    End Sub
    Sub SpeedSet(A As Boolean, P As Integer)
        '################### SET SPEED ############################
        Dim Rs As String = Space$(128)
        Dim Rv As Integer
        If A Then
            Rv = mciSendString("status asong speed", Rs, 128, 0)
            Rv = mciSendString("Set asong speed " + Str(P * 10), Rs, 128, 0)
        Else
            Rv = mciSendString("status bsong speed", Rs, 128, 0)
            Rv = mciSendString("Set bsong speed " + Str(P * 10), Rs, 128, 0)
        End If
    End Sub
    Private Sub BackCtrl_ValueChanged(sender As Object, e As EventArgs) Handles BackCtrl.ValueChanged
        Paso.TabStop = False
        Paso.Image = DancePlay3.My.Resources.Brake
        BckTime.Text = Mid(Szhms(BackCtrl.Value), 4, 5)
    End Sub
    Private Sub Paso_Click(sender As Object, e As EventArgs) Handles Paso.Click
        If Paso.TabStop = False Then
            Paso.TabStop = True
            Paso.Image = DancePlay3.My.Resources.Matador
            BckTime.Text = "Paso"
        Else
            Paso.TabStop = False
            Paso.Image = DancePlay3.My.Resources.Brake
            BckTime.Text = Mid(Szhms(BackCtrl.Value), 4, 5)
        End If
    End Sub
    Private Sub Bell_Click(sender As Object, e As EventArgs) Handles Bell.Click
        If Bell.TabStop = False Then
            Bell.TabStop = True
            Bell.Image = DancePlay3.My.Resources.Quiet
        Else
            Bell.TabStop = False
            Bell.Image = DancePlay3.My.Resources.Bell
        End If
    End Sub
    Private Sub GoWeb_Click(sender As Object, e As EventArgs) Handles GoWeb.Click
        '################# GO WEB from Button ##################
        If Form2.WindowState = 1 Then
            Form2.WindowState = FormWindowState.Normal
        Else
            ' Form2.SetMode(3)
            Form2.Show()
        End If
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        '**** when form closing ********** TERMINATE ===================================
        Dim file As System.IO.StreamWriter
        Dim Sz As String
        Dim t As Long
        If (Not (APdl)) And (Box1.Items.Count > 0) Then
            file = My.Computer.FileSystem.OpenTextFileWriter("A.m3u", False)
            file.WriteLine("#EXTM3U")
            For i As Integer = 0 To Val(Box1.Items.Count) - 1
                Sz = Box1.Items(i)
                If Mid(Sz, 1, 1) > "9" Then 'WEB'
                    t = -1
                Else
                    t = 60 * 60 * Val(Mid(Sz, 1, 2)) 'Time to minute
                    t = t + 60 * (Mid(Sz, 4, 2))
                    t = t + (Mid(Sz, 7, 2))
                End If
                file.WriteLine("#EXTINF:" & t & "," & Trim(Mid(Sz, 10, Len(Sz))))
                file.WriteLine(Box11.Items(i))
            Next
            file.Close()
        End If
        If Not (Bpdl) And (Box2.Items.Count > 0) Then
            file = My.Computer.FileSystem.OpenTextFileWriter("B.m3u", False)
            file.WriteLine("#EXTM3U")
            For i As Integer = 0 To Val(Box2.Items.Count) - 1
                Sz = Box2.Items(i)
                If Mid(Sz, 1, 1) > "9" Then
                    t = -1
                Else
                    t = 60 * 60 * Val(Mid(Sz, 1, 2))
                    t = t + 60 * (Mid(Sz, 4, 2))
                    t = t + (Mid(Sz, 7, 2))
                End If
                file.WriteLine("#EXTINF:" & t & "," & Trim(Mid(Sz, 10, Len(Sz))))
                file.WriteLine(Box22.Items(i))
            Next
            file.Close()
        End If
    End Sub
    Private Sub Box1_Enter(sender As Object, e As EventArgs) Handles Box1.Enter
        BoxTxt1.BackColor = System.Drawing.Color.DarkRed
        BoxTxt2.BackColor = System.Drawing.Color.Black
    End Sub

    Private Sub Box2_Enter(sender As Object, e As EventArgs) Handles Box2.Enter
        BoxTxt2.BackColor = System.Drawing.Color.DarkBlue
        BoxTxt1.BackColor = System.Drawing.Color.Black
    End Sub
    Private Sub Box1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Box1.SelectedIndexChanged
        ' ***** index1 change
        Dim s As String
        Dim l As Short
        If Box1.SelectedIndex > -1 Then
            s = Trim(Box11.Items(Box1.SelectedIndex))
            If s <> "" Then
                BoxTxt1.Text = Mid(Box1.SelectedItem, 10)
                If LCase(Mid(s, 1, 4)) = "http" Then
                    TipTxt1.Text = "WEB"
                Else
                    l = InStrRev(s, ".")
                    If l > 0 Then
                        TipTxt1.Text = UCase(Mid(s, l + 1))
                        s = Mid(s, 1, l - 1)
                        l = InStrRev(s, "\") + 1
                        s = Mid(s, l)
                    Else
                        TipTxt1.Text = "!"
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub Box2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Box2.SelectedIndexChanged
        ' ***** index2 change
        Dim s As String
        Dim l As Short
        If Box2.SelectedIndex > -1 Then
            s = Trim(Box22.Items(Box2.SelectedIndex))
            If s <> "" Then
                BoxTxt2.Text = Mid(Box2.SelectedItem, 10)
                If LCase(Mid(s, 1, 4)) = "http" Then
                    TipTxt2.Text = "WEB"
                Else
                    l = InStrRev(s, ".")
                    If l > 0 Then
                        TipTxt2.Text = UCase(Mid(s, l + 1))
                        s = Mid(s, 1, l - 1)
                        l = InStrRev(s, "\") + 1
                        s = Mid(s, l)
                    Else
                        TipTxt2.Text = "!"
                    End If
                End If
            End If
        End If
    End Sub
    Sub PlayNext(A As Boolean, D As Boolean)
        '#### >> NEXT  / << BACK  #####
        Dim N As Integer
        Dim M As Integer
        Dim Rv As Integer
        PlyTimer.Enabled = False
        If A Then '============================ A  >>>>>>>>>>>>>>>>>>>>>>>>>>>>> A
            Rv = mciSendString("stop asong", 0, 0, 0)
            Rv = mciSendString("close asong", 0, 0, 0)
            N = Box1.SelectedIndex
            M = Box1.Items.Count
            If (M < 1) Or (N < 0) Then GoTo tova ' ( nem érvényes )
            If D Then '>>>>>>>>> előre
                If Sol1.ForeColor = System.Drawing.Color.Lime Then
                    If One1.ForeColor = System.Drawing.Color.Lime Then
                        ' SOLO 1×
                        StopMCI(1)
                        GoTo tova '---------------------> 1× csak és vége A
                    Else
                        'SOLO REPEAT
                        Replay(True, N)
                        GoTo tova '---------------------> egy számot játszik örökké A
                    End If
                Else
                    If One1.ForeColor = System.Drawing.Color.Lime Then
                        'List 1×
                        If (M - 1) > N Then
                            Box1.SetSelected(N + 1, True)
                            Replay(True, N + 1)
                            GoTo tova '---------------------> 1× lista következő A
                        Else
                            StopMCI(1)
                            GoTo tova '---------------------> 1× lista vége befejez A
                        End If
                    Else
                        'LIST REPEAT
                        If (M - 1) > N Then
                            Box1.SetSelected(N + 1, True)
                            Replay(True, N + 1)
                            GoTo tova '---------------------> örök lista következő A
                        Else
                            Box1.SetSelected(0, True)
                            Replay(True, 0)
                            GoTo tova '---------------------> örök lista előről A
                        End If
                    End If
                End If
            Else '    D-A  <<<<<<<<< hátra
                If N > 0 Then
                    Box1.SetSelected(N - 1, True)
                    Replay(True, N - 1)
                    GoTo tova '---------------------> hátra A
                End If
            End If
        Else '================================= B  >>>>>>>>>>>>>>>>>>>>>>>>>>>>> B
            Rv = mciSendString("stop bsong", 0, 0, 0)
            Rv = mciSendString("close bsong", 0, 0, 0)
            N = Box2.SelectedIndex
            M = Box2.Items.Count
            If (M < 1) Or (N < 0) Then GoTo tova ' ( nem érvényes )
            If D Then '>>>>>>>>> előre
                If Sol2.ForeColor = System.Drawing.Color.Lime Then
                    If One2.ForeColor = System.Drawing.Color.Lime Then
                        ' SOLO 1×
                        StopMCI(2)
                        GoTo tova '---------------------> 1× csak és vége B
                    Else
                        'SOLO REPEAT
                        Replay(False, N)
                        GoTo tova '---------------------> egy számot játszik örökké B
                    End If
                Else
                    If One2.ForeColor = System.Drawing.Color.Lime Then
                        'List 1×
                        If (M - 1) > N Then
                            Box2.SetSelected(N + 1, True)
                            Replay(False, N + 1)
                            GoTo tova '---------------------> 1× lista következő B
                        Else
                            StopMCI(2)
                            GoTo tova '---------------------> 1× lista vége befejez B
                        End If
                    Else
                        'LIST REPEAT
                        If (M - 1) > N Then
                            Box2.SetSelected(N + 1, True)
                            Replay(False, N + 1)
                            GoTo tova '---------------------> örök lista következő B
                        Else
                            Box2.SetSelected(0, True)
                            Replay(False, 0)
                            GoTo tova '---------------------> örök lista előről B
                        End If
                    End If
                End If
            Else '    D-B  <<<<<<<<< hátra
                If N > 0 Then
                    Box2.SetSelected(N - 1, True)
                    Replay(False, N - 1)
                    GoTo tova '---------------------> hátra B
                End If
            End If
        End If
tova:
        PlyTimer.Enabled = True
    End Sub
    Sub Replay(A As Boolean, X As Integer)
        '######### PLAY BY INDEX ######### 
        If A Then '@@@@@@@@@@@@@@@@@@@@@@@@@ PLAY A-X @@@@@@@@@@@@@@@@@@@ A-X
            Box1.SelectedValue = X
            If PlayErr > -1 Then PlayMCI(1) Else PlayErr = 0
        Else '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ PLAY B-X @@@@@@@@@@@@@@@@@@@ B-X
            Box2.SelectedValue = X
            If PlayErr > -1 Then PlayMCI(2) Else PlayErr = 0
        End If
    End Sub

    '@#@#@#@#@#@#@#@#@#@#  CLASS  #@#@#@#@#@#@#@#@#@#@#
End Class