<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.WOpac = New System.Windows.Forms.Label()
        Me.NavStop = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.SuspendLayout()
        '
        'WOpac
        '
        Me.WOpac.AutoSize = True
        Me.WOpac.Location = New System.Drawing.Point(633, -10)
        Me.WOpac.Name = "WOpac"
        Me.WOpac.Size = New System.Drawing.Size(183, 15)
        Me.WOpac.TabIndex = 103
        Me.WOpac.Text = "█ █ ▌ ▌ ▌ ▐ ▐ ▐ ▐  ║║║ | | | | |"
        '
        'NavStop
        '
        Me.NavStop.Font = New System.Drawing.Font("Webdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.NavStop.Location = New System.Drawing.Point(637, 9)
        Me.NavStop.Name = "NavStop"
        Me.NavStop.Size = New System.Drawing.Size(42, 33)
        Me.NavStop.TabIndex = 102
        Me.NavStop.Text = "r"
        Me.NavStop.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Wingdings", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Button2.Location = New System.Drawing.Point(833, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 33)
        Me.Button2.TabIndex = 101
        Me.Button2.Text = ""
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Webdings", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Button1.Location = New System.Drawing.Point(107, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 33)
        Me.Button1.TabIndex = 100
        Me.Button1.Text = "q"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label2.Location = New System.Drawing.Point(156, -2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "URL:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(202, -7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 19)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = ":"
        '
        'ForwardButton
        '
        Me.ForwardButton.Font = New System.Drawing.Font("Webdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.ForwardButton.Location = New System.Drawing.Point(735, 10)
        Me.ForwardButton.Name = "ForwardButton"
        Me.ForwardButton.Size = New System.Drawing.Size(42, 33)
        Me.ForwardButton.TabIndex = 97
        Me.ForwardButton.Text = "8"
        Me.ForwardButton.UseVisualStyleBackColor = True
        '
        'BackwardButton
        '
        Me.BackwardButton.Font = New System.Drawing.Font("Webdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.BackwardButton.Location = New System.Drawing.Point(686, 9)
        Me.BackwardButton.Name = "BackwardButton"
        Me.BackwardButton.Size = New System.Drawing.Size(42, 33)
        Me.BackwardButton.TabIndex = 96
        Me.BackwardButton.Text = "7"
        Me.BackwardButton.UseVisualStyleBackColor = True
        '
        'HomeButton
        '
        Me.HomeButton.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.HomeButton.Location = New System.Drawing.Point(58, 9)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(42, 33)
        Me.HomeButton.TabIndex = 95
        Me.HomeButton.Text = "⌂"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(156, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(424, 21)
        Me.TextBox1.TabIndex = 94
        '
        'Station
        '
        Me.Station.Font = New System.Drawing.Font("Webdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Station.Location = New System.Drawing.Point(784, 12)
        Me.Station.Name = "Station"
        Me.Station.Size = New System.Drawing.Size(42, 33)
        Me.Station.TabIndex = 93
        Me.Station.Text = "~"
        Me.Station.UseVisualStyleBackColor = True
        '
        'Navi
        '
        Me.Navi.Font = New System.Drawing.Font("Wingdings 3", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Navi.Location = New System.Drawing.Point(588, 9)
        Me.Navi.Name = "Navi"
        Me.Navi.Size = New System.Drawing.Size(42, 33)
        Me.Navi.TabIndex = 92
        Me.Navi.Text = "_"
        Me.Navi.UseVisualStyleBackColor = True
        '
        'WBros
        '
        Me.WBros.Location = New System.Drawing.Point(82, 50)
        Me.WBros.MinimumSize = New System.Drawing.Size(23, 23)
        Me.WBros.Name = "WBros"
        Me.WBros.ScriptErrorsSuppressed = True
        Me.WBros.Size = New System.Drawing.Size(793, 481)
        Me.WBros.TabIndex = 91
        Me.WBros.Url = New System.Uri("about:blank", System.UriKind.Absolute)
        Me.WBros.Visible = False
        '
        'Radio
        '
        Me.Radio.AutoSize = True
        Me.Radio.Location = New System.Drawing.Point(540, 61)
        Me.Radio.Name = "Radio"
        Me.Radio.Size = New System.Drawing.Size(258, 15)
        Me.Radio.TabIndex = 104
        Me.Radio.Text = "https://www.auckland80s.com/auckland-80s.html"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(933, 519)
        Me.Controls.Add(Me.Radio)
        Me.Controls.Add(Me.WOpac)
        Me.Controls.Add(Me.NavStop)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
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
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
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
End Class
