<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.WOpac = New System.Windows.Forms.Label()
        Me.NavStop = New System.Windows.Forms.Button()
        Me.OneX = New System.Windows.Forms.Button()
        Me.Fress = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ForwardButton = New System.Windows.Forms.Button()
        Me.BackwardButton = New System.Windows.Forms.Button()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Station = New System.Windows.Forms.Button()
        Me.Navi = New System.Windows.Forms.Button()
        Me.WBros = New System.Windows.Forms.WebBrowser()
        Me.Radio = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AddList1 = New System.Windows.Forms.Label()
        Me.AddList2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WOpac
        '
        Me.WOpac.AutoSize = True
        Me.WOpac.ForeColor = System.Drawing.Color.LimeGreen
        Me.WOpac.Location = New System.Drawing.Point(633, -10)
        Me.WOpac.Name = "WOpac"
        Me.WOpac.Size = New System.Drawing.Size(183, 15)
        Me.WOpac.TabIndex = 103
        Me.WOpac.Text = "█ █ ▌ ▌ ▌ ▐ ▐ ▐ ▐  ║║║ | | | | |"
        '
        'NavStop
        '
        Me.NavStop.Font = New System.Drawing.Font("Webdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.NavStop.Location = New System.Drawing.Point(674, 8)
        Me.NavStop.Name = "NavStop"
        Me.NavStop.Size = New System.Drawing.Size(42, 33)
        Me.NavStop.TabIndex = 102
        Me.NavStop.Text = "r"
        Me.NavStop.UseVisualStyleBackColor = True
        '
        'OneX
        '
        Me.OneX.Font = New System.Drawing.Font("Wingdings", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.OneX.Location = New System.Drawing.Point(870, 11)
        Me.OneX.Name = "OneX"
        Me.OneX.Size = New System.Drawing.Size(42, 33)
        Me.OneX.TabIndex = 101
        Me.OneX.Text = ""
        Me.OneX.UseVisualStyleBackColor = True
        '
        'Fress
        '
        Me.Fress.Font = New System.Drawing.Font("Webdings", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Fress.Location = New System.Drawing.Point(59, 8)
        Me.Fress.Name = "Fress"
        Me.Fress.Size = New System.Drawing.Size(42, 33)
        Me.Fress.TabIndex = 100
        Me.Fress.Text = "q"
        Me.Fress.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label2.Location = New System.Drawing.Point(122, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "00:00:00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(183, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 19)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = ":"
        '
        'ForwardButton
        '
        Me.ForwardButton.Font = New System.Drawing.Font("Webdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.ForwardButton.Location = New System.Drawing.Point(772, 9)
        Me.ForwardButton.Name = "ForwardButton"
        Me.ForwardButton.Size = New System.Drawing.Size(42, 33)
        Me.ForwardButton.TabIndex = 97
        Me.ForwardButton.Text = "8"
        Me.ForwardButton.UseVisualStyleBackColor = True
        '
        'BackwardButton
        '
        Me.BackwardButton.Font = New System.Drawing.Font("Webdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.BackwardButton.Location = New System.Drawing.Point(723, 8)
        Me.BackwardButton.Name = "BackwardButton"
        Me.BackwardButton.Size = New System.Drawing.Size(42, 33)
        Me.BackwardButton.TabIndex = 96
        Me.BackwardButton.Text = "7"
        Me.BackwardButton.UseVisualStyleBackColor = True
        '
        'HomeButton
        '
        Me.HomeButton.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.HomeButton.Location = New System.Drawing.Point(11, 8)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(42, 33)
        Me.HomeButton.TabIndex = 95
        Me.HomeButton.Text = "⌂"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(183, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(436, 21)
        Me.TextBox1.TabIndex = 94
        '
        'Station
        '
        Me.Station.Font = New System.Drawing.Font("Webdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Station.Location = New System.Drawing.Point(821, 11)
        Me.Station.Name = "Station"
        Me.Station.Size = New System.Drawing.Size(42, 33)
        Me.Station.TabIndex = 93
        Me.Station.Text = "~"
        Me.Station.UseVisualStyleBackColor = True
        '
        'Navi
        '
        Me.Navi.Font = New System.Drawing.Font("Wingdings 3", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Navi.Location = New System.Drawing.Point(625, 8)
        Me.Navi.Name = "Navi"
        Me.Navi.Size = New System.Drawing.Size(42, 33)
        Me.Navi.TabIndex = 92
        Me.Navi.Text = "_"
        Me.Navi.UseVisualStyleBackColor = True
        '
        'WBros
        '
        Me.WBros.Location = New System.Drawing.Point(26, 50)
        Me.WBros.MinimumSize = New System.Drawing.Size(23, 23)
        Me.WBros.Name = "WBros"
        Me.WBros.ScriptErrorsSuppressed = True
        Me.WBros.Size = New System.Drawing.Size(861, 481)
        Me.WBros.TabIndex = 91
        Me.WBros.Url = New System.Uri("about:blank", System.UriKind.Absolute)
        '
        'Radio
        '
        Me.Radio.AutoSize = True
        Me.Radio.ForeColor = System.Drawing.Color.White
        Me.Radio.Location = New System.Drawing.Point(337, 534)
        Me.Radio.Name = "Radio"
        Me.Radio.Size = New System.Drawing.Size(258, 15)
        Me.Radio.TabIndex = 104
        Me.Radio.Text = "https://www.auckland80s.com/auckland-80s.html"
        Me.Radio.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'AddList1
        '
        Me.AddList1.AutoSize = True
        Me.AddList1.BackColor = System.Drawing.Color.Black
        Me.AddList1.Font = New System.Drawing.Font("Wingdings 2", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.AddList1.ForeColor = System.Drawing.Color.Salmon
        Me.AddList1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AddList1.Location = New System.Drawing.Point(106, 16)
        Me.AddList1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AddList1.Name = "AddList1"
        Me.AddList1.Size = New System.Drawing.Size(34, 22)
        Me.AddList1.TabIndex = 110
        Me.AddList1.Text = "4"
        Me.AddList1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AddList2
        '
        Me.AddList2.AutoSize = True
        Me.AddList2.BackColor = System.Drawing.Color.Black
        Me.AddList2.Font = New System.Drawing.Font("Wingdings 2", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.AddList2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.AddList2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AddList2.Location = New System.Drawing.Point(143, 16)
        Me.AddList2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AddList2.Name = "AddList2"
        Me.AddList2.Size = New System.Drawing.Size(34, 22)
        Me.AddList2.TabIndex = 122
        Me.AddList2.Text = "4"
        Me.AddList2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(898, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 56)
        Me.Button1.TabIndex = 123
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(931, 545)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AddList2)
        Me.Controls.Add(Me.AddList1)
        Me.Controls.Add(Me.Radio)
        Me.Controls.Add(Me.WOpac)
        Me.Controls.Add(Me.NavStop)
        Me.Controls.Add(Me.OneX)
        Me.Controls.Add(Me.Fress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ForwardButton)
        Me.Controls.Add(Me.BackwardButton)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Station)
        Me.Controls.Add(Me.Navi)
        Me.Controls.Add(Me.WBros)
        Me.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ForeColor = System.Drawing.Color.DarkGreen
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Dance Play 3 * Web"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WOpac As Label
    Friend WithEvents NavStop As Button
    Friend WithEvents OneX As Button
    Friend WithEvents Fress As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ForwardButton As Button
    Friend WithEvents BackwardButton As Button
    Friend WithEvents HomeButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Station As Button
    Friend WithEvents Navi As Button
    Friend WithEvents WBros As WebBrowser
    Friend WithEvents Radio As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents AddList1 As Label
    Friend WithEvents AddList2 As Label
    Friend WithEvents Button1 As Button
End Class
